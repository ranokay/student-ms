using System.Globalization;
using Newtonsoft.Json;
using StudentMS.Controllers;
using StudentMS.Models;
using Timer = System.Windows.Forms.Timer;

namespace StudentMS.Forms;

public partial class Home : Form

{
	private readonly DataAccess.DataAccess _dataAccess = new();

	private readonly string? _teacherUsername =
		JsonConvert.DeserializeObject<Teacher>(File.ReadAllText("user.json"))?.Username;

	private string? _addStudentClass;

	private string? _addStudentCourse;
	private string? _addStudentGrade;
	private string? _addStudentName;

	private string? _teacherName =
		JsonConvert.DeserializeObject<Teacher>(File.ReadAllText("user.json"))?.Name;

	private string? _updateConfirmPassword;
	private string? _updateName;
	private string? _updatePassword;
	private string? _updateUsername;

	public Home()
	{
		InitializeComponent();
	}

	private async void Home_Load(object sender, EventArgs e)
	{
		// close the application when the form is closed
		FormClosed += (_, _) => Application.Exit();
		ActiveControl = null;

		HomeUserLabel.Text = _teacherName;

		var teacherExists = await _dataAccess.GetTeacher(_teacherUsername);
		if (teacherExists == null) HomeUserLabel.Text += @" (Offline)";

		// show the students in the list view and refresh the list view every 5 seconds
		if (HomeTabControl.SelectedTab != StudentsListPage) return;
		{
			StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherUsername);

			// refresh the list view every 5 seconds
			var timer = new Timer { Interval = 5000 };
			timer.Tick += async (_, _) =>
			{
				StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherUsername);
			};
			timer.Start();
		}
	}

	private void LogoutBtn_Click(object sender, EventArgs e)
	{
		// delete the user.json file
		File.Delete("user.json");

		// open the login form
		Login login = new();
		login.Show();
		Hide();
	}

	private void AddStudentBtn_Click(object sender, EventArgs e)
	{
		HomeTabControl.SelectTab("AddStudentPage");
	}

	private async void AddNewStudentBtn_Click(object sender, EventArgs e)
	{
		_addStudentName = AddStudentName.Text.ToLower().Trim();
		_addStudentCourse = AddStudentCourse.Text.ToLower().Trim();
		_addStudentGrade = AddStudentGrade.Text.Trim();
		_addStudentClass = AddStudentClass.Text.ToLower().Trim();

		// Clear the error message
		ErrorMsgAddStudent.Text = string.Empty;

		// Check all the required fields
		var allFieldsMessage = FieldsValidation.CheckAllFields(_addStudentName, _addStudentCourse, _addStudentGrade);
		if (allFieldsMessage != null)
		{
			ErrorMsgAddStudent.Text = allFieldsMessage as string;
			return;
		}

		// Check if student already exists
		var studentExists = await _dataAccess.GetStudent(_addStudentName, _teacherUsername);
		if (studentExists != null)
		{
			ErrorMsgAddStudent.Text = @"Student already exists";
			return;
		}

		// Name validation
		var nameMessage = FieldsValidation.CheckName(_addStudentName);
		if (nameMessage != null)
		{
			ErrorMsgAddStudent.Text = nameMessage;
			return;
		}

		// Class validation
		var classMessage = FieldsValidation.CheckClass(_addStudentClass);
		if (classMessage != null)
		{
			ErrorMsgAddStudent.Text = classMessage;
			return;
		}

		// Course validation
		var courseMessage = FieldsValidation.CheckCourse(_addStudentCourse);
		if (courseMessage != null)
		{
			ErrorMsgAddStudent.Text = courseMessage;
			return;
		}

		// Grade validation
		var gradeMessage = FieldsValidation.CheckGrade(_addStudentGrade);
		if (gradeMessage != null)
		{
			ErrorMsgAddStudent.Text = gradeMessage;
			return;
		}

		// To title case
		var studentName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_addStudentName);
		var studentCourse = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_addStudentCourse);
		var studentClass = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_addStudentClass);

		// Create a new student object
		var student = new Student(studentName, studentClass, studentCourse, _addStudentGrade);

		// Add the student to the database
		try
		{
			await _dataAccess.AddStudent(student, _teacherUsername);
		}
		catch (Exception exception)
		{
			MessageBox.Show(exception.Message);
		}

		// Show success message
		FieldsValidation.SuccessMsg(ErrorMsgAddStudent, "Student added successfully");

		ActiveControl = null;

		// Clear the fields
		FieldsValidation.ClearFields(AddStudentName, AddStudentClass, AddStudentCourse, AddStudentGrade);
	}

	// Add student on enter key press
	private void Enter_KeyDown(object sender, KeyEventArgs e)
	{
		// Pressed enter key and remove sound
		if (e.KeyCode != Keys.Enter) return;
		e.SuppressKeyPress = true;
		AddNewStudentBtn.PerformClick();
	}

	// Update student
	private async void StudentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		// Check if the clicked cell is a button, Must be non-negative and less than the size of the collection.
		if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex > StudentsGridView.Columns.Count - 1) return;

		// Check if the clicked cell is a button
		if (StudentsGridView.Columns[e.ColumnIndex] is not DataGridViewButtonColumn) return;

		switch (e.ColumnIndex)
		{
			// Get the delete button
			case 5:
			{
				var studentName = StudentsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

				// Delete the student
				await _dataAccess.DeleteStudent(studentName, _teacherUsername);

				// Refresh the list view
				StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherUsername);
				break;
			}
			// Get the edit button
			case 4:
			{
				// Check if the student name is null
				if (StudentsGridView.Rows[e.RowIndex].Cells[0].Value == null) return;

				// Change the read only property of the first 4 columns
				for (var i = 0; i < 4; i++) StudentsGridView.Rows[e.RowIndex].Cells[i].ReadOnly = false;

				StudentsGridView.Rows[e.RowIndex].Cells[4].Value = "💾";

				// Update the student
				StudentsGridView.CellEndEdit += async (_, _) =>
				{
					// Get the student name
					var studentName = StudentsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
					var student = await _dataAccess.GetStudent(studentName, _teacherUsername);

					if (student != null)
					{
						// to trim and to title case the first 3 columns
						for (var i = 0; i < 3; i++)
							StudentsGridView.Rows[e.RowIndex].Cells[i].Value =
								CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
									StudentsGridView.Rows[e.RowIndex].Cells[i].Value.ToString()?.Trim() ?? string.Empty);

						student.Name = StudentsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
						student.Class = StudentsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
						student.Course = StudentsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
						student.Grade = StudentsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

						await _dataAccess.UpdateStudent(studentName, _teacherUsername, student);
					}

					for (var i = 0; i < 4; i++) StudentsGridView.Rows[e.RowIndex].Cells[i].ReadOnly = true;

					StudentsGridView.Rows[e.RowIndex].Cells[4].Value = "✏️";

					// Refresh the list view
					StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherUsername);
				};
				break;
			}
		}
	}

	private void EditTeacherBtn_Click(object sender, EventArgs e)
	{
		// Show the edit teacher panel
		EditTeacherPanel.Visible = true;

		// Hide the edit button
		EditTeacherBtn.Visible = false;

		ActiveControl = null;
	}

	private async void SaveNewTeacherBtn_Click(object sender, EventArgs e)
	{
		_updateName = NewTeacherName.Text.ToLower().Trim();
		_updateUsername = NewTeacherUsername.Text.ToLower().Trim();
		_updatePassword = NewTeacherPassword.Text;
		_updateConfirmPassword = ConfirmNewTeacherPassword.Text;

		ActiveControl = null;

		// Clear the error message
		ErrorMsgUpdateTeacher.Text = string.Empty;

		// Check if all fields are empty
		if (_updateName.Length == 0 && _updateUsername.Length == 0 && _updatePassword.Length == 0 &&
		    _updateConfirmPassword.Length == 0)
		{
			ErrorMsgUpdateTeacher.Text = @"Please fill at least one field!";
			return;
		}

		// Name validation
		var nameMsg = FieldsValidation.CheckName(_updateName);
		if (_updateName.Length != 0 && nameMsg != null)
		{
			ErrorMsgUpdateTeacher.Text = nameMsg;
			return;
		}

		// Username validation
		var usernameMsg = FieldsValidation.CheckUsername(_updateUsername);
		if (_updateUsername.Length != 0 && usernameMsg != null)
		{
			ErrorMsgUpdateTeacher.Text = usernameMsg;
			return;
		}

		// Check if the username is already taken
		var teacherUsername = await _dataAccess.GetTeacher(_updateUsername);
		if (teacherUsername != null)
		{
			ErrorMsgUpdateTeacher.Text = @"Username already taken!";
			return;
		}

		// Password validation
		var passwordMsg = FieldsValidation.CheckPassword(_updatePassword);
		if (_updatePassword.Length != 0 && passwordMsg != null)
		{
			ErrorMsgUpdateTeacher.Text = passwordMsg;
			return;
		}

		// Confirm password
		if (_updatePassword != _updateConfirmPassword && _updatePassword.Length > 0 && _updateConfirmPassword.Length > 0)
		{
			ErrorMsgUpdateTeacher.Text = @"Passwords do not match!";
			return;
		}

		// Hash the password
		var hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(_updatePassword);

		// Name to title case
		var teacherName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_updateName);

		// Get the teacher
		var teacher = await _dataAccess.GetTeacher(_teacherUsername);

		// Update the teacher
		if (teacher != null)
		{
			teacher.Name = teacherName;
			teacher.Username = _updateUsername;
			teacher.Password = hashedNewPassword;

			// Update the teacher
			await _dataAccess.UpdateTeacher(_teacherUsername, teacher);
		}

		EditTeacherBtn.Visible = true;
		EditTeacherPanel.Visible = false;

		// Refresh the teacher name
		_teacherName = teacherName;
		HomeUserLabel.Text = _teacherName;

		// Empty the fields
		FieldsValidation.ClearFields(NewTeacherName, NewTeacherUsername, NewTeacherPassword,
			ConfirmNewTeacherPassword);
	}

	private void CancelUpdateBtn_Click(object sender, EventArgs e)
	{
		// Show the edit button
		EditTeacherBtn.Visible = true;

		// Hide the edit teacher panel
		EditTeacherPanel.Visible = false;
	}

	private void DeleteProfileBtn_Click(object sender, EventArgs e)
	{
		// Hide the edit panel
		EditTeacherPanel.Visible = false;

		// Show the delete profile panel
		ConfirmDeletionPanel.Visible = true;

		ActiveControl = null;
	}

	private async void ConfirmDeletionBtn_Click(object sender, EventArgs e)
	{
		// Get the teacher password
		var teacher = await _dataAccess.GetTeacher(_teacherUsername);
		// Check if the password is correct
		if (BCrypt.Net.BCrypt.Verify(ConfirmDeletionPassword.Text, teacher?.Password))
		{
			// Delete the teacher
			await _dataAccess.DeleteTeacher(_teacherUsername);

			// Show the login form
			var loginForm = new Login();
			loginForm.Show();

			// Hide the home form
			Hide();
		}
		else
		{
			// Show the error message
			ConfirmDeletionErrorMsg.Text = @"Incorrect password!";
		}
	}

	private void CancelDeletionBtn_Click(object sender, EventArgs e)
	{
		// Hide the delete profile panel
		ConfirmDeletionPanel.Visible = false;

		// Show the edit panel
		EditTeacherPanel.Visible = true;

		// Clear the password field
		ConfirmDeletionPassword.Text = string.Empty;

		// Clear the error message
		ConfirmDeletionErrorMsg.Text = string.Empty;
	}
}