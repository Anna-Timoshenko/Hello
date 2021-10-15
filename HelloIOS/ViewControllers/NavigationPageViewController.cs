using System;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.WhiteLabel.iOS;
using Softeq.XToolkit.WhiteLabel.iOS.Extensions;
using UIKit;

namespace HelloIOS.ViewControllers
{
    public partial class NavigationPageViewController : ViewControllerBase<NavigationViewModel>
    {
        public NavigationPageViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.NavigationBar.Hidden = true;

            NavigationButtonHello.SetTitle(ViewModel.TextButtonHello, UIControlState.Normal);
            NavigationButtonHello.SetCommand(ViewModel.NavigateCommandHello);

            NavigationButtonAddCollar.SetTitle(ViewModel.TextButtonAddCollar, UIControlState.Normal);
            NavigationButtonAddCollar.SetCommand(ViewModel.NavigateCommandAddCollar);

            NavigationButtonDynamic.SetTitle(ViewModel.TextButtonDynamic, UIControlState.Normal);
            NavigationButtonDynamic.SetCommand(ViewModel.NavigateCommandDynamic);
        }
    }
}