using System;
using System.Windows.Input;
using Foundation;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.WhiteLabel.iOS.Controls;
using UIKit;

namespace HelloIOS.Views
{
    [Register(nameof(NaviView))]
    public partial class NaviView : CustomViewBase
    {
        public NaviView(IntPtr handle) : base(handle)
        {
        }

        public void SetTitle(string text)
        {
            Title.Text = text;
            Title.Hidden = false;
        }

        public void SetButtonRight(string label, ICommand command)
        {
            ButtonDone.SetTitle(label, UIControlState.Normal);
            ButtonDone.Hidden = false;
            ButtonDone.SetCommand(command);
        }

        public void SetButtonClose(ICommand command)
        {
            ButtonClose.SetTitle("Close", UIControlState.Normal);
            ButtonClose.Hidden = false;
            ButtonClose.SetCommand(command);
        }
    }
}