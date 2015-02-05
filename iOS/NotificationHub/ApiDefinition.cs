using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NotificationHub
{
    // @interface RKNotificationHub : NSObject
    [BaseType (typeof (NSObject), Name="RKNotificationHub")]
    interface Notifier {

        // -(id)initWithView:(UIView *)view;
        [Export ("initWithView:")]
        IntPtr Constructor (UIView view);

        // @property (nonatomic) UIView * hubView;
        [Export ("hubView")]
        UIView HubView { get; set; }

        // -(void)setView:(UIView *)view andCount:(int)startCount;
        [Export ("setView:andCount:")]
        void SetView (UIView view, int startCount);

        // -(void)setCircleAtFrame:(CGRect)frame;
        [Export ("setCircleAtFrame:")]
        void SetCircleFrame (RectangleF frame);

        // -(void)setCircleColor:(UIColor *)circleColor labelColor:(UIColor *)labelColor;
        [Export ("setCircleColor:labelColor:")]
        void SetCircleColor (UIColor circleColor, UIColor labelColor);

        // -(void)moveCircleByX:(CGFloat)x Y:(CGFloat)y;
        [Export ("moveCircleByX:Y:")]
        void MoveCircle (nfloat x, nfloat y);

        // -(void)scaleCircleSizeBy:(CGFloat)scale;
        [Export ("scaleCircleSizeBy:")]
        void ScaleCircle (nfloat scale);

        // -(void)increment;
        [Export ("increment"), Internal]
        void Increment ();

        // -(void)incrementBy:(int)amount;
        [Export ("incrementBy:"), Internal]
        void Increment (int amount);

        // -(void)decrement;
        [Export ("decrement"), Internal]
        void Decrement ();

        // -(void)decrementBy:(int)amount;
        [Export ("decrementBy:"), Internal]
        void Decrement (int amount);

        // -(void)setCount:(int)newCount;
        [Export ("setCount:"), Internal]
        void SetCount (int newCount);

        // -(int)count;
        [Export ("count"), Internal]
        int Count ();

        // -(void)hideCount;
        [Export ("hideCount")]
        void HideCount ();

        // -(void)showCount;
        [Export ("showCount")]
        void ShowCount ();

        // -(void)pop;
        [Export ("pop"), Internal]
        void Pop ();

        // -(void)blink;
        [Export ("blink"), Internal]
        void Blink ();

        // -(void)bump;
        [Export ("bump"), Internal]
        void Bump ();
    }

}

