using Xamarin.Forms;

using EntryUITest.ViewModels;

namespace EntryUITest
{
	public class BasePage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
	{
		readonly TViewModel _viewModel;

		public BasePage()
		{
			_viewModel = new TViewModel();
			BindingContext = ViewModel;
		}

		protected TViewModel ViewModel => _viewModel;
	}
}
