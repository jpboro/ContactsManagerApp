using ContactsManagerApp.ViewModel;
using Prism.Navigation;

namespace ContactsManagerApp
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "MAIN PAGE PRISM TEST";
        }
    }
}