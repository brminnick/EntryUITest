using Xamarin.Forms;

namespace Entry_UITest
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var emailKeyboardEntry = new Entry
			{
				Placeholder = "Enter Text Here",
				Keyboard = Keyboard.Email,
				AutomationId = "MyEntry",
			};

			MainPage = new ContentPage
			{
				Content = emailKeyboardEntry
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

