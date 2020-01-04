using System;
using System.Linq;
using EntryUITest.Shared;
using NUnit.Framework;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace EntryUITest.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        readonly Query _myEntry, _myLabel;
        readonly Platform _platform;

        IApp? _app;

        IApp App => _app ?? throw new NullReferenceException();

        public Tests(Platform platform)
        {
            _platform = platform;

            //Always initialize your UITest queries using "x.Marked" and referencing the UI ID
            //In Xamarin.Forms, you set the UI ID by setting the control's "AutomationId"
            //In Xamarin.Android, you set the UI ID by setting the control's "ContentDescription"
            //In Xamarin.iOS, you set the UI ID by setting the control's "AccessibilityIdentifiers"

            _myEntry = x => x.Marked(AutomationIdConstants.EntryAutomationID);
            _myLabel = x => x.Marked(AutomationIdConstants.LabelAutomationID);
        }

        [SetUp]
        public void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(_platform);
            _app.WaitForElement(PageTitleConstants.MainPage);
        }

        [Test]
        public void EnterText()
        {
            //Arrange
            const string typedText = "Hello world!";
            string retrievedText;

            //Act
            App.EnterText(_myEntry, typedText);
            App.DismissKeyboard();
            App.Screenshot($"Entered Text: {typedText}");

            //Assert
            retrievedText = App.Query(_myLabel).First().Text;
            Assert.AreEqual(typedText, retrievedText, "The typed text does not match the text displayed on the screen");
        }

        [Ignore("Repl for testing/development only")]
        [Test]
        public void Repl() => App.Repl();
    }
}

