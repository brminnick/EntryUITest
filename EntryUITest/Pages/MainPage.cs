using System;

using Xamarin.Forms;

using EntryUITest.Shared;

namespace EntryUITest.Pages
{
    class MainPage : BaseContentPage<MainViewModel>
    {
        public MainPage() : base(PageTitleConstants.MainPage)
        {
            BackgroundColor = Color.FromHex("4FCAE6");

            var goEntry = new Entry
            {
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                Placeholder = "Enter Text Here",
                PlaceholderColor = Color.FromHex("749FA8"),
                AutomationId = AutomationIdConstants.EntryAutomationID,
                TextColor = Color.FromHex("2C7797"),
                BackgroundColor = Color.FromHex("91E2F4"),
                ReturnType = ReturnType.Done,
                ReturnCommand = new Command(Unfocus)
            };
            goEntry.SetBinding(Entry.TextProperty, nameof(MainViewModel.EmailKeyboardEntryText));

            var textLabel = new Label
            {
                TextColor = Color.White,
                AutomationId = AutomationIdConstants.LabelAutomationID,
                HorizontalTextAlignment = TextAlignment.Center
            };
            textLabel.SetBinding(Label.TextProperty, nameof(MainViewModel.TextLabelText));

            Padding = GetPagePadding();

            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    goEntry,
                    textLabel
                }
            };

            Content = new ScrollView { Content = stackLayout };
        }

        Thickness GetPagePadding()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return new Thickness(30, 20, 30, 5);
                case Device.Android:
                    return new Thickness(30, 0, 30, 5);
                default:
                    throw new NotSupportedException("Platform Unsupported");
            }
        }
    }
}
