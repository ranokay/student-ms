namespace StudentMS.Models;

public class Teacher
{
	public Teacher(string? id, string? name, string? username, string? password)
	{
		Id = id;
		Name = name;
		Username = username;
		Password = password;
	}

	public string? Id { get; set; }
	public string? Name { get; set; }
	public string? Username { get; set; }
	public string? Password { get; set; }
}