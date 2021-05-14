﻿using System;
using EntryUITest.Shared;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Markup;

namespace EntryUITest.Pages
{
    class MainPage : BaseContentPage<MainViewModel>
    {
        public MainPage() : base(PageTitleConstants.MainPage)
        {
            BackgroundColor = Color.FromHex("4FCAE6");

            Padding = GetPagePadding();

            Content = new StackLayout
            {
                Children =
                {
                    new Entry
                    {
                        ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                        Placeholder = "Enter Text Here",
                        PlaceholderColor = Color.FromHex("749FA8"),
                        AutomationId = AutomationIdConstants.EntryAutomationID,
                        TextColor = Color.FromHex("2C7797"),
                        BackgroundColor = Color.FromHex("91E2F4"),
                        ReturnType = ReturnType.Done,
                        ReturnCommand = new Command(Unfocus)
                    }.Bind(Entry.TextProperty, nameof(MainViewModel.EmailKeyboardEntryText)),

                    new Label
                    {
                        TextColor = Color.White,
                        AutomationId = AutomationIdConstants.LabelAutomationID,
                    }.TextCenter()
                     .Bind(Label.TextProperty, nameof(MainViewModel.TextLabelText))
                     
                }
            }.CenterExpand();
        }

        Thickness GetPagePadding() => Device.RuntimePlatform switch
        {
            Device.iOS => new Thickness(30, 20, 30, 5),
            Device.Android => new Thickness(30, 0, 30, 5),
            _ => throw new NotSupportedException("Platform Unsupported"),
        };
    }
}
