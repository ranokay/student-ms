using System.Net.Mail;
using Timer = System.Windows.Forms.Timer;

namespace StudentMS.Controllers;

internal abstract class FieldsValidation
{
	// Check if the teacher has entered all the required fields
	public static object? CheckAllFields(params string[] fields)
	{
		return fields.Any(string.IsNullOrEmpty) ? "Please fill all the required fields" : null;
	}


	// Name validation
	public static string? CheckName(string name)
	{
		var message = name.Length switch
		{
			< 3 => @"Name must be at least 3 characters long!",
			> 50 => @"Name must be at most 50 characters long!",
			_ when name.Any(c => !char.IsLetter(c) && c != ' ') => @"Name must contain only letters and spaces!",
			_ => null
		};

		return message;
	}

	// Username/email validation
	public static string? CheckUsername(string username)
	{
		try
		{
			var email = new MailAddress(username.ToLower());
			return !email.Host.Contains('.') ? @"Invalid email address!" : null;
		}
		catch (FormatException)
		{
			var message = username.Length switch
			{
				< 4 => @"Username must be more than 4 characters!",
				> 20 => @"Username must be less than 20 characters!",
				_ when username.Contains(' ') => @"Username must not contain spaces!",
				_ when username.Any(c => !char.IsLetterOrDigit(c)) => @"Username must contain only letters and digits!",
				_ => null
			};

			return message;
		}
	}

	// Password validation
	public static string? CheckPassword(string password)
	{
		var message = password.Length switch
		{
			< 8 => @"Password must be at least 8 characters long!",
			> 20 => @"Password must be at most 20 characters long!",
			_ when !password.Any(char.IsUpper) => @"Password must contain at least one uppercase letter!",
			_ when !password.Any(char.IsLower) => @"Password must contain at least one lowercase letter!",
			_ when !password.Any(char.IsDigit) => @"Password must contain at least one digit!",
			_ => null
		};

		return message;
	}

	public static void SuccessMsg(Label label, string? message)
	{
		label.Text = message;
		label.ForeColor = Color.Green;

		// hide the label after 3 seconds
		var timer = new Timer { Interval = 3000 };

		timer.Tick += (_, _) =>
		{
			label.Text = "";
			timer.Stop();
		};

		timer.Start();
	}

	// Clear all the fields in the form
	public static void ClearFields(params Control[] controls)
	{
		foreach (var control in controls)
			switch (control)
			{
				case TextBox textBox:
					textBox.Text = "";
					break;
				case ComboBox comboBox:
					comboBox.SelectedIndex = -1;
					break;
				case Label label:
					label.Text = "";
					break;
			}
	}

	// Course validation
	public static string? CheckCourse(string course)
	{
		var message = course.Length switch
		{
			< 3 => @"Course must be at least 3 characters long!",
			> 50 => @"Course must be at most 50 characters long!",
			_ when course.Any(c => !char.IsLetter(c) && c != ' ' && c != '-') =>
				@"Course must contain only letters, spaces and dashes!",
			_ => null
		};

		return message;
	}

	// Grade validation (only numbers, float or int)
	public static string? CheckGrade(string grade)
	{
		var message = grade.Length switch
		{
			< 1 => @"Grade must be at least 1 character long!",
			> 5 => @"Grade must be at most 5 characters long!",
			_ when !grade.All(char.IsDigit) && !grade.Contains('.') => @"Grade must contain only numbers!",
			_ when grade.Contains('.') && grade.Split('.').Length > 2 => @"Grade must contain only one dot!",
			_ when grade.Contains('.') && grade.Split('.')[1].Length > 2 => @"Grade must contain only two decimal places!",
			_ when float.Parse(grade) > 10 || float.Parse(grade) < 0 => @"Grade must be between 0 and 10!",
			_ => null
		};

		return message;
	}

	// Class validation
	public static string? CheckClass(string @class)
	{
		var message = @class.Length switch
		{
			< 3 => @"Class must be at least 3 characters long!",
			> 50 => @"Class must be at most 50 characters long!",
			_ when @class.Any(c => !char.IsLetterOrDigit(c) && c != ' ' && c != '-') =>
				@"Class must contain only letters, numbers, spaces and dashes!",
			_ => null
		};

		return message;
	}
}