using System;
using System.Collections.Generic;
using System.Linq;
using PagingView;
using Foundation;
using UIKit;
using CoreGraphics;

namespace PagingViewSample
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;
        bool twitter = true;
        //
        // This method is invoked when the application has loaded and is ready to run. In this
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var orange = UIColor.FromRGBA((255f / 255f), 69.0f / 255, 0.0f / 255, 1.0f);
            var grey = UIColor.FromRGBA(.84f, .84f, .84f, 1.0f);

            var img1 = new UIImageView(UIImage.FromBundle("Gear").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate));
            var img2 = new UIImageView(UIImage.FromBundle("Profile").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate));
            var img3 = new UIImageView(UIImage.FromBundle("Chat").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate));

            var titles = new [] { img1, img2, img3 };
            var views = new [] { ViewWithColor(orange), ViewWithColor(UIColor.Yellow), ViewWithColor(grey) };
            var pageViewController = new PagingViewController(titles, UIColor.White, views, false );

            if(twitter){
                pageViewController.MovePageAction = (scrollView, subviews) =>
                    {
                        var xOffset = scrollView.ContentOffset.X;
                        int i = 0;
                        foreach(var v in subviews){
                            nfloat alpha = 0.0f;
                            if(v.Frame.X < 145)
                                alpha = 1 - (xOffset - i*320) / 320;
                            else if(v.Frame.X >145)
                                alpha=(xOffset - i*320) / 320 + 1;
                            else if(v.Frame.X == 140)
                                alpha = 1.0f;
                            i++;
                            v.Alpha = alpha;
                        }
                    };
            } else {
                pageViewController.MovePageAction = (scrollView, subviews) =>
                    {
                        int i = 0;
                        foreach (UIImageView v in subviews) {
                            var c = grey;
                            if(v.Frame.X > 45
                                && v.Frame.X < 145){
                                // Left part
                                c = CreateGradient(v.Frame.X, 46, 144, orange, grey);
                            } else if(v.Frame.X > 145
                                && v.Frame.X < 245){
                                // Right part
                                c = CreateGradient(v.Frame.X, 146, 244, grey, orange);
                            }else if(v.Frame.X == 145){
                                c = orange;
                            }
                            v.TintColor= c;
                            i++;
                        }
                    };
            }

            var nav = new UINavigationController(pageViewController);
            window = new UIWindow(UIScreen.MainScreen.Bounds);
            window.RootViewController = nav;
            window.BackgroundColor = UIColor.White;

            window.MakeKeyAndVisible();

            return true;
        }

        UIView ViewWithColor(UIColor color)
        {
            var view = new UIView();
            view.BackgroundColor = color;
            return view;
        }

        UIColor CreateGradient(double percent, double topX, double bottomX, UIColor init, UIColor goal)
        {
            double t = (percent - bottomX) / (topX - bottomX);

            t = Math.Max(0.0, Math.Min(t, 1.0));

            nfloat[] cgInit = init.CGColor.Components;
            nfloat[] cgGoal = goal.CGColor.Components;

            nfloat r = (nfloat)(cgInit[0] + t * (cgGoal[0] - cgInit[0]));
            nfloat g = (nfloat)(cgInit[1] + t * (cgGoal[1] - cgInit[1]));
            nfloat b = (nfloat)(cgInit[2] + t * (cgGoal[2] - cgInit[2]));

            return UIColor.FromRGBA(r, g, b, 1.0f);
        }
    }
}

