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
	[Register ("DynamicPageViewController")]
	partial class DynamicPageViewController
	{
		[Outlet]
		UIKit.UIButton ButtonMinus { get; set; }

		[Outlet]
		UIKit.UIButton ButtonPlus { get; set; }

		[Outlet]
		UIKit.UILabel Counter { get; set; }

		[Outlet]
		UIKit.UISwitch Switch { get; set; }

		[Outlet]
		UIKit.UITextField TextInput { get; set; }

		[Outlet]
		UIKit.UILabel TextOutput { get; set; }

		[Outlet]
		UIKit.UILabel TextSwitch { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TextSwitch != null) {
				TextSwitch.Dispose ();
				TextSwitch = null;
			}

			if (Switch != null) {
				Switch.Dispose ();
				Switch = null;
			}

			if (Counter != null) {
				Counter.Dispose ();
				Counter = null;
			}

			if (ButtonMinus != null) {
				ButtonMinus.Dispose ();
				ButtonMinus = null;
			}

			if (ButtonPlus != null) {
				ButtonPlus.Dispose ();
				ButtonPlus = null;
			}

			if (TextOutput != null) {
				TextOutput.Dispose ();
				TextOutput = null;
			}

			if (TextInput != null) {
				TextInput.Dispose ();
				TextInput = null;
			}
		}
	}
}
