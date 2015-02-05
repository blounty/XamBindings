using System;
using System.Drawing;
using NotificationHub;
using Foundation;
using UIKit;

namespace NotificationHubSample
{
    public partial class NotificationHubSampleViewController : UIViewController
    {
        Notifier hub;
        public NotificationHubSampleViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            hub = new Notifier(EarthImageView);
            hub.MoveCircle(-15, 15);

            IncrementButton.TouchUpInside += (sender, e) => hub.Increment(NotificationAnimationType.Bump);
        }
            
        #endregion
    }
}

