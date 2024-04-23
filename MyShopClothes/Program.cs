using MyShopClothes.App.Forms;

namespace MyShopClothes
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			var formStart = new LoginForm();

			Application.Run(formStart);

			// Hung Comment
			// This is My Login Page

			// COMMENT HUNG
		}
	}
}
