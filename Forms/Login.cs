using System.Globalization;
using Newtonsoft.Json;
using StudentMS.Controllers;
using StudentMS.Models;

namespace StudentMS.Forms;

public partial class Login : Form
{
	private DataAccess.DataAccess _dataAccess = new();
	private string? _signInPassword;

	private string? _signInUsername;
	private string? _signUpConfirmPassword;
	private string? _signUpName;
	private string? _signUpPassword;
	private string? _signUpUsername;

	public Login()
	{
		InitializeComponent();
	}

	private void Login_Load(object sender, EventArgs e)
	{
		// close the application when the form is closed
		FormClosing += (_, _) => Application.Exit();

		// Initialize the firebase database
		_dataAccess = new DataAccess.DataAccess();
	}

	private void SignInBtnRedir_Click(object sender, EventArgs e)
	{
		LoginTabControl.SelectTab("SignInPage");
		ActiveControl = null;
		ErrorMsgSignIn.Text = "";
	}

	private void SignUpBtnRedir_Click(object sender, EventArgs e)
	{
		LoginTabControl.SelectTab("SignUpPage");
		ActiveControl = null;
		ErrorMsgSignUp.Text = "";
		SignInUsername.Text = "";
		SignInPassword.Text = "";
	}

	private async void SignUpBtn_Click(object? sender, EventArgs e)
	{
		_signUpName = SignUpName.Text.ToLower().Trim();
		_signUpUsername = SignUpUsername.Text.ToLower().Trim();
		_signUpPassword = SignUpPassword.Text;
		_signUpConfirmPassword = SignUpConfirmPassword.Text;

		// Check all the required fields
		var allFieldsMessage =
			FieldsValidation.CheckAllFields(_signUpName, _signUpUsername, _signUpPassword, _signUpConfirmPassword);
		if (allFieldsMessage != null)
		{
			ErrorMsgSignUp.Text = allFieldsMessage as string;
			return;
		}

		// Name validation
		var nameMessage = FieldsValidation.CheckName(_signUpName);
		if (nameMessage != null)
		{
			ErrorMsgSignUp.Text = nameMessage;
			return;
		}

		// Username validation
		var usernameMessage = FieldsValidation.CheckUsername(_signUpUsername);
		if (usernameMessage != null)
		{
			ErrorMsgSignUp.Text = usernameMessage;
			return;
		}

		// Check if the username is already taken
		var usernameExists = await _dataAccess.GetTeacher(_signUpUsername);
		if (usernameExists != null)
		{
			ErrorMsgSignUp.Text = @"Username already exists!";
			return;
		}

		// Check if the name is already taken
		var nameExists = await _dataAccess.GetTeacher(_signUpName);
		if (nameExists != null)
		{
			ErrorMsgSignUp.Text = @"Teacher with this name already exists!";
			return;
		}

		// Password validation
		var passwordMessage = FieldsValidation.CheckPassword(_signUpPassword);
		if (passwordMessage != null)
		{
			ErrorMsgSignUp.Text = passwordMessage;
			return;
		}

		// Confirm password
		if (_signUpPassword != _signUpConfirmPassword)
		{
			ErrorMsgSignUp.Text = @"Passwords do not match!";
			return;
		}

		// Hash the password
		var hashedPassword = BCrypt.Net.BCrypt.HashPassword(_signUpPassword);

		// Name to title case
		var teacherName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_signUpName);

		// Create a new teacher for the firebase database
		var newTeacher = new Teacher(teacherName, _signUpUsername, hashedPassword);

		// Push the teacher to database
		try
		{
			await _dataAccess.AddTeacher(newTeacher);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}

		LoginTabControl.SelectTab("SignInPage");
		FieldsValidation.SuccessMsg(ErrorMsgSignIn, "Account created successfully!");
		ActiveControl = null;

		// Clear the fields
		FieldsValidation.ClearFields(SignUpName, SignUpUsername, SignUpPassword, SignUpConfirmPassword);
	}

	private async void LoginBtn_Click(object sender, EventArgs e)
	{
		_signInUsername = SignInUsername.Text.ToLower().Trim();
		_signInPassword = SignInPassword.Text;

		// Check if the user has entered all the required fields
		var allFieldsMessage = FieldsValidation.CheckAllFields(_signInUsername, _signInPassword);
		if (allFieldsMessage != null)
		{
			ErrorMsgSignIn.Text = allFieldsMessage as string;
			return;
		}

		// Check if the username exists
		var teacher = await _dataAccess.GetTeacher(_signInUsername);
		if (teacher == null)
		{
			ErrorMsgSignIn.Text = @"Username does not exist!";
			return;
		}

		// Check if the password is correct
		if (!BCrypt.Net.BCrypt.Verify(_signInPassword, teacher.Password))
		{
			ErrorMsgSignIn.Text = @"Incorrect password!";
			return;
		}

		// Create a new session
		var session = new Session(teacher.Name, teacher.Username);
		var json = JsonConvert.SerializeObject(session);
		await File.WriteAllTextAsync("session.json", json);

		// Open the home form
		var home = new Home();
		home.Show();
		Hide();
	}

	// Login on enter key press
	private void Enter_KeyDown(object sender, KeyEventArgs e)
	{
		// Pressed enter key and remove sound
		if (e.KeyCode != Keys.Enter) return;
		e.SuppressKeyPress = true;

		// Check if the user is on the sign in page
		if (LoginTabControl.SelectedTab == SignInPage)
			LoginBtn.PerformClick();
		else
			SignUpBtn.PerformClick();
	}
}