using ReactiveUI;

namespace AvaloniaMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _CurrentPage;

        public MainWindowViewModel()
        {
            CurrentPage = new ProductListViewModel();
        }

        public ViewModelBase CurrentPage
        {
            get => _CurrentPage;
            set => this.RaiseAndSetIfChanged(ref _CurrentPage, value, propertyName: nameof(CurrentPage));
        }
    }
}