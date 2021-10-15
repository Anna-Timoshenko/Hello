using System;
using Hello.ViewModels;
using Softeq.XToolkit.WhiteLabel.iOS;

namespace HelloIOS.ViewControllers
{
    public partial class MainPageViewController : ViewControllerBase<MainPageViewModel>
    {
        public MainPageViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LabelHello.Text = ViewModel.HelloText;

            NavigationView.SetTitle(ViewModel.Title);
            NavigationView.SetButtonClose(ViewModel.NavigateCommandBack);
        }
    }
}