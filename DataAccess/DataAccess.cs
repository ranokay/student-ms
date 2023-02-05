using DotNetEnv;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using StudentMS.Models;

namespace StudentMS.DataAccess;

public class DataAccess
{
	private readonly FirebaseClient _firebase;

	public DataAccess()
	{
		Env.Load();
		Env.TraversePath().Load();
		var apiKey = Environment.GetEnvironmentVariable("FIREBASE_API_KEY");
		var baseUrl = Environment.GetEnvironmentVariable("FIREBASE_BASE_URL");
		_firebase = new FirebaseClient(baseUrl,
			new FirebaseOptions
			{
				AuthTokenAsyncFactory = () => Task.FromResult(apiKey)
			});
	}

	// add teacher
	public async Task AddTeacher(Teacher teacher)
	{
		await _firebase.Child("teachers").PostAsync(JsonConvert.SerializeObject(teacher));
	}

	// get teacher by username
	public async Task<Teacher?> GetTeacher(string? username)
	{
		var teachers = await _firebase.Child("teachers").OnceAsync<Teacher>();
		return (from teacher in teachers where teacher.Object.Username == username select teacher.Object).FirstOrDefault();
	}

	// get the teacher's key
	public async Task<string?> GetTeacherKey(string? username)
	{
		try
		{
			var teachers = await _firebase.Child("teachers").OnceAsync<Teacher>();
			return (from teacher in teachers where teacher.Object.Username == username select teacher.Key).FirstOrDefault();
		}

		catch (Exception)
		{
			return null;
		}
	}

	// update teacher
	public async Task UpdateTeacher(string? username, Teacher teacher)
	{
		var teacherKey = await GetTeacherKey(username);
		await _firebase.Child("teachers").Child(teacherKey).PutAsync(JsonConvert.SerializeObject(teacher));
	}

	// delete teacher
	public async Task DeleteTeacher(string? username)
	{
		var teacherKey = await GetTeacherKey(username);
		await _firebase.Child("teachers").Child(teacherKey).DeleteAsync();
	}

	// add student
	public async Task AddStudent(Student student, string? username)
	{
		var teacherKey = await GetTeacherKey(username);
		await _firebase.Child("teachers").Child(teacherKey).Child("students")
			.PostAsync(JsonConvert.SerializeObject(student));
	}

	// get all students
	public async Task<List<Student>> GetAllStudents(string? username)
	{
		var teacherKey = await GetTeacherKey(username);
		try
		{
			var students = await _firebase.Child("teachers").Child(teacherKey).Child("students").OnceAsync<Student>();
			return students.Select(student => student.Object).ToList();
		}
		catch (Exception)
		{
			return new List<Student>();
		}
	}

	// get student by name
	public async Task<Student?> GetStudent(string? name, string? username)
	{
		var teacherKey = await GetTeacherKey(username);
		var students = await _firebase.Child("teachers").Child(teacherKey).Child("students").OnceAsync<Student>();
		return (from student in students where student.Object.Name == name select student.Object).FirstOrDefault();
	}

	// get student's key
	private async Task<string?> GetStudentKey(string? name, string? username)
	{
		var teacherKey = await GetTeacherKey(username);
		var students = await _firebase.Child("teachers").Child(teacherKey).Child("students").OnceAsync<Student>();
		return (from student in students where student.Object.Name == name select student.Key).FirstOrDefault();
	}

	// delete student
	public async Task DeleteStudent(string? name, string? username)
	{
		var teacherKey = await GetTeacherKey(username);
		var studentKey = await GetStudentKey(name, username);
		await _firebase.Child("teachers").Child(teacherKey).Child("students").Child(studentKey).DeleteAsync();
	}

	// update student
	public async Task UpdateStudent(string? name, string? username, Student student)
	{
		var teacherKey = await GetTeacherKey(username);
		var studentKey = await GetStudentKey(name, username);
		await _firebase.Child("teachers").Child(teacherKey).Child("students").Child(studentKey)
			.PutAsync(JsonConvert.SerializeObject(student));
	}
}