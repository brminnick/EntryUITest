namespace EntryUITest
{
    class MainViewModel : BaseViewModel
    {
        #region Fields
        string _emailKeyboardEntryText, _textLabelText;
        #endregion

        #region Properties
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
        #endregion
    }
}
