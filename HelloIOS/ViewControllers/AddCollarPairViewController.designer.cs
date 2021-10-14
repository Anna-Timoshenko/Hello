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
		UIKit.UIButton ButtonClose { get; set; }

		[Outlet]
		UIKit.UIButton ButtonDone { get; set; }

		[Outlet]
		UIKit.UITableView TableViewAddPet { get; set; }

		[Outlet]
		UIKit.UITableView TableViewPetsWithCollars { get; set; }

		[Outlet]
		UIKit.UILabel TextChoose { get; set; }

		[Outlet]
		UIKit.UILabel TextPetsWithCollars { get; set; }

		[Outlet]
		UIKit.UILabel TitleBar { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ButtonAdd != null) {
				ButtonAdd.Dispose ();
				ButtonAdd = null;
			}

			if (ButtonClose != null) {
				ButtonClose.Dispose ();
				ButtonClose = null;
			}

			if (ButtonDone != null) {
				ButtonDone.Dispose ();
				ButtonDone = null;
			}

			if (TableViewAddPet != null) {
				TableViewAddPet.Dispose ();
				TableViewAddPet = null;
			}

			if (TextChoose != null) {
				TextChoose.Dispose ();
				TextChoose = null;
			}

			if (TitleBar != null) {
				TitleBar.Dispose ();
				TitleBar = null;
			}

			if (TextPetsWithCollars != null) {
				TextPetsWithCollars.Dispose ();
				TextPetsWithCollars = null;
			}

			if (TableViewPetsWithCollars != null) {
				TableViewPetsWithCollars.Dispose ();
				TableViewPetsWithCollars = null;
			}
		}
	}
}
