using System;
using System.Drawing;

using Foundation;
using UIKit;
using CoreLocation;
using LocFake;

namespace LocFakeSample
{
    public partial class LocFakeSampleViewController : UIViewController, ICLLocationManagerDelegate
    {
        CLLocationManager locationManager;

        public LocFakeSampleViewController(IntPtr handle)
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
			
            var path = NSBundle.MainBundle.PathForResource("ashland.gpx", null);
            var url = NSUrl.FromFilename(path);
            locationManager = new CLLocationManager();

            locationManager.RequestWhenInUseAuthorization();

            locationManager.Delegate = this;

            locationManager.StartUpdatingLocation();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

        [Export("locationManager:didUpdateToLocation:fromLocation:")]
        public void UpdatedLocation(CoreLocation.CLLocationManager manager, CoreLocation.CLLocation newLocation, CoreLocation.CLLocation oldLocation)
        {
            Console.WriteLine("Lat {0} Long {1}", newLocation.Coordinate.Latitude, newLocation.Coordinate.Longitude);
        }

        public CLAuthorizationStatus AstralAuthorizationStatus
        {
            [Export("astralAuthorizationStatus")]
            get
            {
                return CLAuthorizationStatus.AuthorizedWhenInUse;
            }
        }

        public bool AstralLocationServicesEnabled
        {
            [Export("astralLocationServicesEnabled")]
            get
            {
                return true;
            }
        }
    }
}

