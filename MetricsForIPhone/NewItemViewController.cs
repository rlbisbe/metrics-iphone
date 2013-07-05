using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MetricsForIPhone
{
	public partial class NewItemViewController : UIViewController
	{
		public Widget NewWidget {
			get;
			set;
		}

		public NewItemViewController () : base ("NewItemViewController", null)
		{		
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			addAccountButton.TouchUpInside += delegate {
				NewWidget = new Widget();
				NewWidget.Title = name.Text;
				NewWidget.Value = "9332";
				this.NavigationController.PopToRootViewController(true);
			};

		}
	}
}

