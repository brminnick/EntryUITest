namespace EntryUITest
{
    class MainViewModel : BaseViewModel
    {
        string _emailKeyboardEntryText = string.Empty, _textLabelText = string.Empty;

        public string TextLabelText
        {
            get => _textLabelText;
            set => SetProperty(ref _textLabelText, value);
        }

        public string EmailKeyboardEntryText
        {
            get => _emailKeyboardEntryText;
            set => SetProperty(ref _emailKeyboardEntryText, value, () => TextLabelText = value);
        }
    }
}
