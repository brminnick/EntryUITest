using Xamarin.Forms;

using EntryUITest.Pages;

namespace EntryUITest
{
    public class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "Markup_Experimental" });

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("3192B3"),
                BarTextColor = Color.White
            };
        }
    }
}

