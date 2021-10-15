using Foundation;

namespace HelloIOS.ViewControllers
{
    [Register("MainPageViewController")]
    partial class MainPageViewController
    {
        [Outlet]
        UIKit.UILabel LabelHello { get; set; }

        [Outlet]
        HelloIOS.Views.NaviView NavigationView { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (LabelHello != null)
            {
                LabelHello.Dispose();
                LabelHello = null;
            }

            if (NavigationView != null)
            {
                NavigationView.Dispose();
                NavigationView = null;
            }
        }
    }
}