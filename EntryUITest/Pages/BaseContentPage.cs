using System;

using Xamarin.Forms;

namespace EntryUITest
{
    public class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
    {
        readonly Lazy<TViewModel> _viewModelHolder = new Lazy<TViewModel>();

        public BaseContentPage() => BindingContext = ViewModel;

        protected TViewModel ViewModel => _viewModelHolder.Value;
    }
}
