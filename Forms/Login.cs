using System.Globalization;
using Newtonsoft.Json;
using StudentMS.Controllers;
using StudentMS.Models;

namespace StudentMS.Forms;

public partial class Login : Form
{
	private readonly DataAccess.DataAccess _dataAccess = new();

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
	}

	private void SignInBtnRedir_Click(object sender, EventArgs e)
	{
		LoginTabControl.SelectTab("SignInPage");
		ActiveControl = null;
		FieldsValidation.ClearFields(SignInUsername, SignInPassword);
	}

	private void SignUpBtnRedir_Click(object sender, EventArgs e)
	{
		LoginTabControl.SelectTab("SignUpPage");
		ActiveControl = null;
		FieldsValidation.ClearFields(SignUpName, SignUpUsername, SignUpPassword, SignUpConfirmPassword);
	}

	private async void SignUpBtn_Click(object? sender, EventArgs e)
	{
		_signUpName = SignUpName.Text.ToLower().Trim();
		_signUpUsername = SignUpUsername.Text.ToLower().Trim();
		_signUpPassword = SignUpPassword.Text;
		_signUpConfirmPassword = SignUpConfirmPassword.Text;

		var getTeacher = await _dataAccess.GetTeacherByUsername(_signUpUsername);

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
		var usernameExists = getTeacher?.Username;
		if (usernameExists != null)
		{
			ErrorMsgSignUp.Text = @"Username already exists!";
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

		var teacherName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_signUpName);

		// Create a new teacher for the firebase database
		var teacherId = Guid.NewGuid().ToString();
		var newTeacher = new Teacher(teacherId, teacherName, _signUpUsername, hashedPassword);

		await _dataAccess.AddTeacher(newTeacher);

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

		var getTeacher = await _dataAccess.GetTeacherByUsername(_signInUsername);

		// Check if the user has entered all the required fields
		var allFieldsMessage = FieldsValidation.CheckAllFields(_signInUsername, _signInPassword);
		if (allFieldsMessage != null)
		{
			ErrorMsgSignIn.Text = allFieldsMessage as string;
			return;
		}

		// Check if the username exists
		var teacherUsername = getTeacher?.Username;
		if (teacherUsername == null)
		{
			ErrorMsgSignIn.Text = @"Username does not exist!";
			return;
		}

		// Check if the password is correct
		if (!BCrypt.Net.BCrypt.Verify(_signInPassword, getTeacher?.Password))
		{
			ErrorMsgSignIn.Text = @"Incorrect password!";
			return;
		}

		// Get teacher's id
		var teacherId = getTeacher?.Id;

		// Create a new session
		var session = new Teacher(teacherId, getTeacher?.Name, getTeacher?.Username, getTeacher?.Password);
		var json = JsonConvert.SerializeObject(session);
		await File.WriteAllTextAsync("user.json", json);

		// Open the home form
		var home = new Home();
		home.Show();
		Hide();
	}

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