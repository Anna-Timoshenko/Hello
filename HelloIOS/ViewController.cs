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
            //LabelH.Text = ViewModel.HelloText;
            this.Bind(() => ViewModel.HelloText, () => LabelH.Text);
        }
    }
}
