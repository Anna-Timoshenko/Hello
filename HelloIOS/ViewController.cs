using Foundation;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings.Extensions;
using Softeq.XToolkit.WhiteLabel.iOS;
using System;
using UIKit;

namespace HelloIOS
{
    public partial class ViewController : ViewControllerBase<MainPageViewModel>
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            LabelH.Text = ViewModel.HelloText;
        }
    }
}
