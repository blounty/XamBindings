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

namespace Samples
{
	[Register ("SamplesViewController")]
	partial class SamplesViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton HanekeButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView HanekeImageView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (HanekeButton != null) {
				HanekeButton.Dispose ();
				HanekeButton = null;
			}
			if (HanekeImageView != null) {
				HanekeImageView.Dispose ();
				HanekeImageView = null;
			}
		}
	}
}
