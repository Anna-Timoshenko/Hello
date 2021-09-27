using Softeq.XToolkit.Common.Collections;
using Softeq.XToolkit.Common.Commands;
using Softeq.XToolkit.WhiteLabel.Mvvm;
using Softeq.XToolkit.WhiteLabel.Navigation;
using System.Collections.Generic;
using System.Windows.Input;

namespace Hello.ViewModels
{
    internal enum Category
    {
        Navigation,
        Collections,
        Controls,
        Components
    }

    public class NavigationViewModel : ViewModelBase
    {
        private readonly IPageNavigationService _pageNavigationService;

        public NavigationViewModel(IPageNavigationService pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
            Items = new ObservableKeyGroupsCollection<string, CommandAction>();
            NavigateCommandHello = new RelayCommand(NavigateMain);
            NavigateCommandAddCollar = new RelayCommand(NavigateAddCollar);
        }

        public ObservableKeyGroupsCollection<string, CommandAction> Items { get; }

        public ICommand NavigateCommandHello { get; }
        public ICommand NavigateCommandAddCollar { get; }

        public override void OnInitialize()
        {
            base.OnInitialize();

            AddItems();
        }

        private void NavigateMain()
        {
            _pageNavigationService.For<MainPageViewModel>().Navigate();
        }

        private void NavigateAddCollar()
        {
            _pageNavigationService.For<AddCollarPairViewModel>().Navigate();
        }

        private void AddItems()
        {
            var actions = new List<(Category Header, CommandAction Item)>
            {
                (Category.Navigation, new CommandAction(
                    new RelayCommand(() =>
                    {
                        _pageNavigationService
                            .For<MainPageViewModel>()
                            .Navigate();
                    }),
                    "Go Hello")),
                (Category.Navigation, new CommandAction(
                    new RelayCommand(() =>
                    {
                        _pageNavigationService
                            .For<AddCollarPairViewModel>()
                            .Navigate();
                    }),
                    "Go Add")),
            };


            //Items.AddRangeToGroups<(Category Header, CommandAction Item)>(actions , x => x.Header.ToString(), x => x.Item);
        }
    }
}
