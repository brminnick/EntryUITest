using Xamarin.UITest;

namespace EntryUITest.UITests
{
	public static class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
            if (platform is Platform.Android)
                return ConfigureApp.Android.EnableLocalScreenshots().StartApp();

			return ConfigureApp.iOS.EnableLocalScreenshots().StartApp();
		}
	}
}

