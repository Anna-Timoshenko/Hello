// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HelloIOS.ViewControllers
{
	[Register ("NavigationPageViewController")]
	partial class NavigationPageViewController
	{
		[Outlet]
		UIKit.UIButton NavigationButtonAddCollar { get; set; }

		[Outlet]
		UIKit.UIButton NavigationButtonDynamic { get; set; }

		[Outlet]
		UIKit.UIButton NavigationButtonHello { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NavigationButtonHello != null) {
				NavigationButtonHello.Dispose ();
				NavigationButtonHello = null;
			}

			if (NavigationButtonAddCollar != null) {
				NavigationButtonAddCollar.Dispose ();
				NavigationButtonAddCollar = null;
			}

			if (NavigationButtonDynamic != null) {
				NavigationButtonDynamic.Dispose ();
				NavigationButtonDynamic = null;
			}
		}
	}
}
