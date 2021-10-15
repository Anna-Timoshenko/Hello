using Foundation;

namespace HelloIOS.ViewControllers
{
    [Register("DynamicPageViewController")]
    partial class DynamicPageViewController
    {
        [Outlet]
        UIKit.UIButton ButtonMinus { get; set; }

        [Outlet]
        UIKit.UIButton ButtonPlus { get; set; }

        [Outlet]
        UIKit.UILabel Counter { get; set; }

        [Outlet]
        HelloIOS.Views.NaviView NavigationBarView { get; set; }

        [Outlet]
        UIKit.UISwitch Switch { get; set; }

        [Outlet]
        UIKit.UITextField TextInput { get; set; }

        [Outlet]
        UIKit.UILabel TextOutput { get; set; }

        [Outlet]
        UIKit.UILabel TextSwitch { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (ButtonMinus != null)
            {
                ButtonMinus.Dispose();
                ButtonMinus = null;
            }

            if (ButtonPlus != null)
            {
                ButtonPlus.Dispose();
                ButtonPlus = null;
            }

            if (Counter != null)
            {
                Counter.Dispose();
                Counter = null;
            }

            if (Switch != null)
            {
                Switch.Dispose();
                Switch = null;
            }

            if (TextInput != null)
            {
                TextInput.Dispose();
                TextInput = null;
            }

            if (TextOutput != null)
            {
                TextOutput.Dispose();
                TextOutput = null;
            }

            if (TextSwitch != null)
            {
                TextSwitch.Dispose();
                TextSwitch = null;
            }

            if (NavigationBarView != null)
            {
                NavigationBarView.Dispose();
                NavigationBarView = null;
            }
        }
    }
}