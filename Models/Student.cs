namespace StudentMS.Models;

public class Student
{
	public Student(string name, string studentClass, string course, string grade)
	{
		Name = name;
		Class = studentClass;
		Course = course;
		Grade = grade;
	}

	public string? Name { get; set; }
	public string? Class { get; set; }
	public string? Course { get; set; }
	public string? Grade { get; set; }
}