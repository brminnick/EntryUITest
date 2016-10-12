using Xamarin.Forms;

using EntryUITest.Pages;

namespace EntryUITest
{
	public class App : Application
	{
        public App()
        {
			// The root page of your application

			MainPage = new NavigationPage(new MainPage())
			{
				BarBackgroundColor = Color.FromHex("3192B3"),
				BarTextColor = Color.White
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

