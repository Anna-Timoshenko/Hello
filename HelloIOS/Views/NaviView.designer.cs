using Foundation;

namespace HelloIOS.Views
{
    partial class NaviView
    {
        [Outlet]
        UIKit.UIButton ButtonClose { get; set; }

        [Outlet]
        UIKit.UIButton ButtonDone { get; set; }

        [Outlet]
        UIKit.UILabel Title { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (ButtonClose != null)
            {
                ButtonClose.Dispose();
                ButtonClose = null;
            }

            if (Title != null)
            {
                Title.Dispose();
                Title = null;
            }

            if (ButtonDone != null)
            {
                ButtonDone.Dispose();
                ButtonDone = null;
            }
        }
    }
}