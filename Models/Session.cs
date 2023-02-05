namespace StudentMS.Models;

internal class Session
{
	public Session(string teacherName, string? teacherUsername)
	{
		Name = teacherName;
		Username = teacherUsername;
	}

	public string? Username { get; set; }
	public string? Name { get; set; }
}