
namespace EntryUITest.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        #region Fields
        string _emailKeyboardEntryText, _textLabelText;
        #endregion

        #region Properties
        public string TextLabelText => _textLabelText;

        public string EmailKeyboardEntryText
        {
            get => _emailKeyboardEntryText;
            set
            {
                SetProperty(ref _emailKeyboardEntryText, value);
                SetProperty(ref _textLabelText, value, nameof(TextLabelText));
            }
        }
        #endregion
    }
}
