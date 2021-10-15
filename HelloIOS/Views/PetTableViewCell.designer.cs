// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HelloIOS.Views
{
	[Register ("PetTableViewCell")]
	partial class PetTableViewCell
	{
		[Outlet]
		UIKit.UIView PetIcon { get; set; }

		[Outlet]
		UIKit.UILabel PetName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (PetIcon != null) {
				PetIcon.Dispose ();
				PetIcon = null;
			}

			if (PetName != null) {
				PetName.Dispose ();
				PetName = null;
			}
		}
	}
}
