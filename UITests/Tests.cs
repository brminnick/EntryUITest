using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace EmailKeyboard_UITest.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
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
			app.Tap(x => x.Marked("EmailKeyboard"));
			app.ClearText();
			app.ClearText();
			app.EnterText(typedText);

			//Assert
			retrievedText = app.Query(x => x.Marked("EmailKeyboard"))[0].Text;
			Assert.AreEqual(typedText,retrievedText, "The typed text does not match the text displayed on the screen");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}
	}
}

