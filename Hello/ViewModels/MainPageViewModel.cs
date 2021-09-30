using Softeq.XToolkit.Common.Commands;
using Softeq.XToolkit.WhiteLabel.Mvvm;
using Softeq.XToolkit.WhiteLabel.Navigation;
using System.Windows.Input;

namespace Hello.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IPageNavigationService _pageNavigationService;

        public MainPageViewModel(IPageNavigationService pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
            NavigateCommandBack = new RelayCommand(NavigateBack);
        }

        public string HelloText => "Hello world";
        public string Title => "Main Hello";

        public ICommand NavigateCommandBack { get; }

        private void NavigateBack()
        {
            _pageNavigationService.GoBack();
        }
    }
}
