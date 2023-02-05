using System.Globalization;
using Newtonsoft.Json;
using StudentMS.Controllers;
using StudentMS.Models;

namespace StudentMS.Forms;

public partial class Home : Form

{
	private readonly DataAccess.DataAccess _dataAccess = new();

	private readonly string? _teacherId = JsonConvert.DeserializeObject<Teacher>(File.ReadAllText("user.json"))?.Id;

	private readonly string? _teacherUsername =
		JsonConvert.DeserializeObject<Teacher>(File.ReadAllText("user.json"))?.Username;

	private string? _addStudentClass;
	private string? _addStudentCourse;
	private string? _addStudentGrade;
	private string? _addStudentName;
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
		HomeUserLabel.Text = _teacherUsername;

		// show the students
		if (HomeTabControl.SelectedTab == StudentsListPage)
			StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherId);
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

		var getStudent = await _dataAccess.GetStudent(_addStudentName, _teacherId);

		// Check all the required fields
		var allFieldsMessage = FieldsValidation.CheckAllFields(_addStudentName, _addStudentCourse, _addStudentGrade);
		if (allFieldsMessage != null)
		{
			ErrorMsgAddStudent.Text = allFieldsMessage as string;
			return;
		}

		// Check if student already exists
		var studentExists = getStudent?.Name;
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

		await _dataAccess.AddStudent(_teacherId, student);

		// Show success message
		FieldsValidation.SuccessMsg(ErrorMsgAddStudent, "Student added successfully");

		ActiveControl = null;

		// Clear the fields
		FieldsValidation.ClearFields(AddStudentName, AddStudentClass, AddStudentCourse, AddStudentGrade,
			ErrorMsgAddStudent);

		// Refresh the students list
		StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherId);
	}

	private void Enter_KeyDown(object sender, KeyEventArgs e)
	{
		// Pressed enter key and remove sound
		if (e.KeyCode != Keys.Enter) return;
		e.SuppressKeyPress = true;
		AddNewStudentBtn.PerformClick();
	}

	private async void StudentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		// Check if the clicked cell is a button, Must be non-negative and less than the size of the collection.
		if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex > StudentsGridView.Columns.Count - 1) return;
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
				StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherId);
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
					var student = await _dataAccess.GetStudent(studentName, _teacherId);

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

						await _dataAccess.UpdateStudent(studentName, _teacherId, student);
					}

					for (var i = 0; i < 4; i++) StudentsGridView.Rows[e.RowIndex].Cells[i].ReadOnly = true;

					StudentsGridView.Rows[e.RowIndex].Cells[4].Value = "✏️";

					// Refresh the list view
					StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherId);
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

		// Clear the fields
		FieldsValidation.ClearFields(NewTeacherName, NewTeacherUsername, NewTeacherPassword,
			ConfirmNewTeacherPassword, ErrorMsgUpdateTeacher);
	}

	private async void SaveNewTeacherBtn_Click(object sender, EventArgs e)
	{
		_updateName = NewTeacherName.Text.ToLower().Trim();
		_updateUsername = NewTeacherUsername.Text.ToLower().Trim();
		_updatePassword = NewTeacherPassword.Text;
		_updateConfirmPassword = ConfirmNewTeacherPassword.Text;

		var getTeacher = await _dataAccess.GetTeacherByUsername(_teacherUsername);

		if (string.IsNullOrEmpty(_updateName) && string.IsNullOrEmpty(_updateUsername) &&
		    string.IsNullOrEmpty(_updatePassword) && string.IsNullOrEmpty(_updateConfirmPassword))
		{
			ErrorMsgUpdateTeacher.Text = @"Please fill at least one field!";
			return;
		}

		// Name validation
		if (!string.IsNullOrEmpty(_updateName))
		{
			var nameMsg = FieldsValidation.CheckName(_updateName);
			if (nameMsg != null)
			{
				ErrorMsgUpdateTeacher.Text = nameMsg;
				return;
			}

			if (getTeacher?.Name == _updateName)
			{
				ErrorMsgUpdateTeacher.Text = @"Name already taken!";
				return;
			}

			if (getTeacher != null) getTeacher.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_updateName);
		}

		// Username validation
		if (!string.IsNullOrEmpty(_updateUsername))
		{
			var usernameMsg = FieldsValidation.CheckUsername(_updateUsername);
			if (usernameMsg != null)
			{
				ErrorMsgUpdateTeacher.Text = usernameMsg;
				return;
			}

			if (getTeacher?.Username == _updateUsername)
			{
				ErrorMsgUpdateTeacher.Text = @"Username already taken!";
				return;
			}

			if (getTeacher != null) getTeacher.Username = _updateUsername;
		}

		// Password validation
		if (!string.IsNullOrEmpty(_updatePassword))
		{
			var passwordMsg = FieldsValidation.CheckPassword(_updatePassword);
			if (passwordMsg != null)
			{
				ErrorMsgUpdateTeacher.Text = passwordMsg;
				return;
			}

			if (_updatePassword != _updateConfirmPassword)
			{
				ErrorMsgUpdateTeacher.Text = @"Passwords do not match!";
				return;
			}

			if (getTeacher != null)
			{
				var hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(_updatePassword);
				getTeacher.Password = hashedNewPassword;
			}
		}

		if (getTeacher != null)
		{
			await _dataAccess.UpdateTeacher(getTeacher, _teacherId);

			File.Delete("user.json");
			var user = new Teacher(_teacherId, getTeacher.Name, getTeacher.Username, getTeacher.Password);
			var json = JsonConvert.SerializeObject(user, Formatting.Indented);
			await File.WriteAllTextAsync("user.json", json);

			HomeUserLabel.Text = getTeacher.Name;
		}

		// Hide the edit teacher panel
		EditTeacherBtn.Visible = true;
		EditTeacherPanel.Visible = false;

		// Refresh the list view
		StudentsGridView.DataSource = await _dataAccess.GetAllStudents(_teacherId);

		ActiveControl = null;

		// Show the success message
		MessageBox.Show(@"Profile updated successfully!", @"Success", MessageBoxButtons.OK,
			MessageBoxIcon.Information);

		// Clear the fields
		FieldsValidation.ClearFields(NewTeacherName, NewTeacherUsername, NewTeacherPassword,
			ConfirmNewTeacherPassword, ErrorMsgUpdateTeacher);
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

		// Clear the fields
		FieldsValidation.ClearFields(ConfirmDeletionPassword, ConfirmDeletionErrorMsg);
	}

	private async void ConfirmDeletionBtn_Click(object sender, EventArgs e)
	{
		var teacherUsername = JsonConvert.DeserializeObject<Teacher>(await File.ReadAllTextAsync("user.json"))?.Username;
		var teacherId = JsonConvert.DeserializeObject<Teacher>(await File.ReadAllTextAsync("user.json"))?.Id;

		// Get the teacher
		var getTeacher = await _dataAccess.GetTeacherByUsername(teacherUsername);

		// Check if the password is correct
		if (!BCrypt.Net.BCrypt.Verify(ConfirmDeletionPassword.Text, getTeacher?.Password))
		{
			ConfirmDeletionErrorMsg.Text = @"Incorrect password!";
			return;
		}

		// Delete the teacher
		await _dataAccess.DeleteTeacher(teacherId);

		// Show the login form
		var loginForm = new Login();
		loginForm.Show();
		Hide();

		// Delete the user.json file
		File.Delete("user.json");

		// Clear the fields
		FieldsValidation.ClearFields(ConfirmDeletionPassword, ConfirmDeletionErrorMsg);
	}

	private void CancelDeletionBtn_Click(object sender, EventArgs e)
	{
		// Hide the delete profile panel
		ConfirmDeletionPanel.Visible = false;

		// Show the edit panel
		EditTeacherPanel.Visible = true;
	}
}