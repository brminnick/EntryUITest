using Xamarin.Forms;

using EntryUITest.ViewModels;

namespace EntryUITest.Pages
{
	class MainPage : BasePage<MainViewModel>
	{
		public MainPage()
		{
			Title = "Main Page";
			BackgroundColor = Color.FromHex("4FCAE6");

			var emailKeyboardEntry = new Entry
			{
				Placeholder = "Enter Text Here",
				PlaceholderColor = Color.FromHex("749FA8"),
				Keyboard = Keyboard.Email,
				AutomationId = AutomationIdConstants.EntryAutomationID,
				TextColor = Color.FromHex("2C7797"),
				BackgroundColor = Color.FromHex("91E2F4")
			};
			emailKeyboardEntry.SetBinding<MainViewModel>(Entry.TextProperty, vm => vm.EmailKeyboardEntryText);

			var textLabel = new Label
			{
				TextColor = Color.White,
				AutomationId = AutomationIdConstants.LabelAutomationID,
				HorizontalTextAlignment = TextAlignment.Center
			};
			textLabel.SetBinding<MainViewModel>(Label.TextProperty, vm => vm.TextLabelText);

			Padding = new Thickness(30, Device.OnPlatform(20, 0, 0), 30, 5);

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children =
				{
					emailKeyboardEntry,
					textLabel
				}
			};
		}
	}
}
