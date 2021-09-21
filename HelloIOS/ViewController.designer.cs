// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HelloIOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel LabelH { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelH != null) {
				LabelH.Dispose ();
				LabelH = null;
			}
		}
	}
}
