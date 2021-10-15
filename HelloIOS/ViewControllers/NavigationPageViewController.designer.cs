using Foundation;

namespace HelloIOS.ViewControllers
{
    [Register("NavigationPageViewController")]
    partial class NavigationPageViewController
    {
        [Outlet]
        UIKit.UIButton NavigationButtonAddCollar { get; set; }

        [Outlet]
        UIKit.UIButton NavigationButtonDynamic { get; set; }

        [Outlet]
        UIKit.UIButton NavigationButtonHello { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (NavigationButtonHello != null)
            {
                NavigationButtonHello.Dispose();
                NavigationButtonHello = null;
            }

            if (NavigationButtonAddCollar != null)
            {
                NavigationButtonAddCollar.Dispose();
                NavigationButtonAddCollar = null;
            }

            if (NavigationButtonDynamic != null)
            {
                NavigationButtonDynamic.Dispose();
                NavigationButtonDynamic = null;
            }
        }
    }
}