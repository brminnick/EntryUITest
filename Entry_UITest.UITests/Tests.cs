using System;
using NUnit.Framework;

using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Entry_UITest.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        Query MyEntry;
        Query MyLabel;

        public Tests(Platform platform)
        {
            this.platform = platform;

            //Always initialize your UITest queries using "x.Marked" and referencing the UI ID
            //In Xamarin.Forms, you set the UI ID by setting the control's "AutomationId"
            //In Xamarin.Android, you set the UI ID by setting the control's "ContentDescription"
            //In Xamarin.iOS, you set the UI ID by setting the control's "AccessibilityIdentifiers"
            
			MyEntry = x => x.Marked("MyEntry");
            MyLabel = x => x.Marked("MyLabel");
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void EnterText()
        {
            //Arrange
            string typedText = "Hello world!";
            string retrievedText;

            //Act
            app.Tap(MyEntry);
            app.ClearText();
            app.ClearText();
            app.Screenshot("Entry Tapped");

            app.EnterText(typedText);
			app.DismissKeyboard();
            app.Screenshot($"Entered Text: {typedText}");

            //Assert
            retrievedText = app.Query(MyLabel)[0]?.Text;
            Assert.AreEqual(typedText, "Wrong", "The typed text does not match the text displayed on the screen");
        }

		[Ignore ("Repl for testing/development only")]
        [Test]
        public void Repl()
        {
            app.Repl();
        }

		[Test]
		public void NewTest()
		{
			app.Tap(x => x.Marked("MyEntry"));
			app.Screenshot("Tapped on view with class: EntryEditText marked: MyEntry");

			app.ClearText();
			app.ClearText();

			app.EnterText(x => x.Marked("MyEntry"), "Hello World!");
			app.Screenshot("Entered text: Hello World!");

			app.DismissKeyboard();
			app.Screenshot("Dismissed keyboard");

			app.WaitForElement(x => x.Marked("MyLabel"), timeout: TimeSpan.FromSeconds(5));
			app.Screenshot("AssertionEvent[AppView: Class=Xamarin.TestRecorder.Portable.Models.Class, Id=, Text=Hello World!, Marked=MyLabel, Css=, XPath=, IndexInTree=0, Rect=[Rectangle: Left=0, Top=0, CenterX=539, CenterY=992.5, Width=394, Height=57, Bottom=1021, Right=736]]");
		}
	}
}

