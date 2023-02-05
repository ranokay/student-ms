namespace StudentMS.Models;

public class Teacher
{
	public Teacher(string name, string? username, string password)
	{
		Name = name;
		Username = username;
		Password = password;
	}

	public string Name { get; set; }
	public string? Username { get; set; }
	public string Password { get; set; }
}