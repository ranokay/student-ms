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

	// get the teacher's key
	private async Task<string?> GetTeacherKey(string? id)
	{
		var teachers = await _firebase.Child("teachers").OnceAsync<Teacher>();
		return (from teacher in teachers where teacher.Object.Id == id select teacher.Key).FirstOrDefault();
	}

	// get teacher by id
	public async Task<Teacher?> GetTeacher(string? id)
	{
		var teacherKey = await GetTeacherKey(id);
		var teachers = await _firebase.Child("teachers").OnceAsync<Teacher>();
		return (from teacher in teachers where teacher.Key == teacherKey select teacher.Object).FirstOrDefault();
	}

	// get teacher by username
	public async Task<Teacher?> GetTeacherByUsername(string? username)
	{
		var teachers = await _firebase.Child("teachers").OnceAsync<Teacher>();
		return (from teacher in teachers where teacher.Object.Username == username select teacher.Object).FirstOrDefault();
	}

	// update teacher
	public async Task UpdateTeacher(Teacher teacher, string? id)
	{
		var teacherKey = await GetTeacherKey(id);
		await _firebase.Child("teachers").Child(teacherKey).PutAsync(JsonConvert.SerializeObject(teacher));
	}

	// delete teacher
	public async Task DeleteTeacher(string? id)
	{
		var teacherKey = await GetTeacherKey(id);
		await _firebase.Child("teachers").Child(teacherKey).DeleteAsync();
	}

	// add student
	public async Task AddStudent(Student student, string? teacherId)
	{
		var teacherKey = await GetTeacherKey(teacherId);
		await _firebase.Child("teachers").Child(teacherKey).Child("students")
			.PostAsync(JsonConvert.SerializeObject(student));
	}

	// get all students
	public async Task<List<Student>> GetAllStudents(string? teacherId)
	{
		try
		{
			var teacherKey = await GetTeacherKey(teacherId);
			var students = await _firebase.Child("teachers").Child(teacherKey).Child("students").OnceAsync<Student>();
			return students.Select(student => student.Object).ToList();
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}
	}

	// get student by name
	public async Task<Student?> GetStudent(string? name, string? teacherId)
	{
		var teacherKey = await GetTeacherKey(teacherId);

		var students = await _firebase.Child("teachers").Child(teacherKey).Child("students").OnceAsync<Student>();
		return (from student in students where student.Object.Name == name select student.Object).FirstOrDefault();
	}

	// get student's key
	private async Task<string?> GetStudentKey(string? name, string? teacherId)
	{
		var teacherKey = await GetTeacherKey(teacherId);
		var students = await _firebase.Child("teachers").Child(teacherKey).Child("students").OnceAsync<Student>();
		return (from student in students where student.Object.Name == name select student.Key).FirstOrDefault();
	}

	// delete student
	public async Task DeleteStudent(string? name, string? teacherId)
	{
		var teacherKey = await GetTeacherKey(teacherId);
		var studentKey = await GetStudentKey(name, teacherId);
		await _firebase.Child("teachers").Child(teacherKey).Child("students").Child(studentKey).DeleteAsync();
	}

	// update student
	public async Task UpdateStudent(string? name, string? teacherId, Student student)
	{
		var teacherKey = await GetTeacherKey(teacherId);
		var studentKey = await GetStudentKey(name, teacherId);
		await _firebase.Child("teachers").Child(teacherKey).Child("students").Child(studentKey)
			.PutAsync(JsonConvert.SerializeObject(student));
	}
}