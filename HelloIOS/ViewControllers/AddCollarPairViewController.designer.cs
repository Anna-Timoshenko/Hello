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
	[Register ("AddCollarPairViewController")]
	partial class AddCollarPairViewController
	{
		[Outlet]
		UIKit.UIButton ButtonAdd { get; set; }

		[Outlet]
		HelloIOS.Views.NaviView NavigationBarView { get; set; }

		[Outlet]
		UIKit.UITableView TableViewAddPet { get; set; }

		[Outlet]
		UIKit.UITableView TableViewPetsWithCollars { get; set; }

		[Outlet]
		UIKit.UILabel TextChoose { get; set; }

		[Outlet]
		UIKit.UILabel TextPetsWithCollars { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ButtonAdd != null) {
				ButtonAdd.Dispose ();
				ButtonAdd = null;
			}

			if (TableViewAddPet != null) {
				TableViewAddPet.Dispose ();
				TableViewAddPet = null;
			}

			if (TableViewPetsWithCollars != null) {
				TableViewPetsWithCollars.Dispose ();
				TableViewPetsWithCollars = null;
			}

			if (TextChoose != null) {
				TextChoose.Dispose ();
				TextChoose = null;
			}

			if (TextPetsWithCollars != null) {
				TextPetsWithCollars.Dispose ();
				TextPetsWithCollars = null;
			}

			if (NavigationBarView != null) {
				NavigationBarView.Dispose ();
				NavigationBarView = null;
			}
		}
	}
}
