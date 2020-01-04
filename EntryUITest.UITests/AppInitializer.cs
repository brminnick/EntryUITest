using System;
using Xamarin.UITest;

namespace EntryUITest.UITests
{
    public static class AppInitializer
    {
        public static IApp StartApp(Platform platform) => platform switch
        {
            Platform.Android => ConfigureApp.Android.EnableLocalScreenshots().StartApp(),
            Platform.iOS => ConfigureApp.iOS.EnableLocalScreenshots().StartApp(),
            _ => throw new NotSupportedException()
        };
    }
}

