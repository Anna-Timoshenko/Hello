using Softeq.XToolkit.Common.Commands;
using Softeq.XToolkit.WhiteLabel.Mvvm;
using Softeq.XToolkit.WhiteLabel.Navigation;
using System.Windows.Input;

namespace Hello.ViewModels
{
    public class NavigationViewModel : ViewModelBase
    {
        private readonly IPageNavigationService _pageNavigationService;

        public NavigationViewModel(IPageNavigationService pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
            NavigateCommandHello = new RelayCommand(NavigateMain);
            NavigateCommandAddCollar = new RelayCommand(NavigateAddCollar);
        }

        public ICommand NavigateCommandHello { get; }
        public ICommand NavigateCommandAddCollar { get; }

        public string TextButtomHello => "Go Hello world";
        public string TextButtomAddCollar => "Go add collar pair";
        public string TextButtomDynamic => "Go dynamic page";

        public override void OnInitialize()
        {
            base.OnInitialize();
        }
        private void NavigateMain()
        {
            _pageNavigationService.For<MainPageViewModel>().Navigate();
        }

        private void NavigateAddCollar()
        {
            _pageNavigationService.For<AddCollarPairViewModel>().Navigate();
        }
    }
}
