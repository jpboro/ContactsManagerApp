using Prism.Mvvm;
using Prism.Navigation;

namespace ContactsManagerApp.ViewModel
{
    public class ViewModelBase : BindableBase, IDestructible, INavigationAware
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public void Destroy()
        {
            
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}