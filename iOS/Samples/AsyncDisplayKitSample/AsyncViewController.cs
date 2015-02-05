using System;
using UIKit;
using AsyncDisplayKit;
using CoreGraphics;
using System.Collections.Generic;
using CoreFoundation;
using Foundation;

namespace AsyncDisplayKitSample
{
    public class AsyncViewController : UIViewController
    {

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
            var viewSize = View.Frame.Size;
            DispatchQueue.DefaultGlobalQueue.DispatchAsync(() =>
                {
                    var node = new ASTextNode();
                    node.AttributedString = new NSAttributedString("hello");
                    node.Measure(viewSize);
                    node.Frame = new CGRect(new CGPoint(10,40), node.CalculatedSize);

                    DispatchQueue.MainQueue.DispatchAsync(() => View.AddSubview(node.View));
                });
        }

    }
}

