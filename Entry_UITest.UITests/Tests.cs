using NUnit.Framework;

using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace EmailKeyboard_UITest.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		Query MyEntry;

		public Tests(Platform platform)
		{
			this.platform = platform;

			MyEntry = x => x.Marked("MyEntry");
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void TypeInEntry()
		{
			//Arrange
			string typedText = "Hello world!";
			string retrievedText;

			//Act
			app.Tap(MyEntry);
			app.ClearText();
			app.ClearText();
			app.EnterText(typedText);

			//Assert
			retrievedText = app.Query(MyEntry)[0].Text;
			Assert.AreEqual(typedText,retrievedText, "The typed text does not match the text displayed on the screen");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}
	}
}

