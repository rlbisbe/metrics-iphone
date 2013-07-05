// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MetricsForIPhone
{
	[Register ("NewItemViewController")]
	partial class NewItemViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton addAccountButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField name { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addAccountButton != null) {
				addAccountButton.Dispose ();
				addAccountButton = null;
			}

			if (name != null) {
				name.Dispose ();
				name = null;
			}
		}
	}
}
