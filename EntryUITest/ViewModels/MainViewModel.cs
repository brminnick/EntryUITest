using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				SetProperty<string>(ref _emailKeyboardEntryText, value);
				SetProperty<string>(ref _textLabelText, value, null, "TextLabelText");
			}
		}

		public string TextLabelText
		{
			get { return _textLabelText; }
		}
	}
}
