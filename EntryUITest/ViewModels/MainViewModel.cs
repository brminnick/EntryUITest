
namespace EntryUITest.ViewModels
{
	class MainViewModel : BaseViewModel
	{
		string _emailKeyboardEntryText, _textLabelText;

		public string EmailKeyboardEntryText
		{
			get { return _emailKeyboardEntryText; }
			set
			{
				SetProperty(ref _emailKeyboardEntryText, value);
				SetProperty(ref _textLabelText, value, nameof(TextLabelText));
			}
		}

		public string TextLabelText
		{
			get { return _textLabelText; }
		}
	}
}
