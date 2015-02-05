// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NotificationHubSample
{
	[Register ("NotificationHubSampleViewController")]
	partial class NotificationHubSampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView EarthImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton IncrementButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (EarthImageView != null) {
				EarthImageView.Dispose ();
				EarthImageView = null;
			}
			if (IncrementButton != null) {
				IncrementButton.Dispose ();
				IncrementButton = null;
			}
		}
	}
}
