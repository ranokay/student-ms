using StudentMS.Forms;

namespace StudentMS;

internal static class Program
{
	/// <summary>
	///   The main entry point for the application.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();

		// Check if the user is already logged in
		if (File.Exists("user.json"))
		{
			Application.Run(new Home());
			return;
		}

		Application.Run(new Login());
	}
}