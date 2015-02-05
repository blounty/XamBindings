using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace PagingView
{
    [BaseType (typeof (UIViewController), Name="SLPagingViewController")]
    interface PagingViewController {

        // -(id)initWithNavBarItems:(NSArray *)items views:(NSArray *)views;
        [Export ("initWithNavBarItems:views:")]
        IntPtr Constructor (UIImageView [] tabBarItems, UIView [] views);

        // -(id)initWithNavBarItems:(NSArray *)items views:(NSArray *)views showPageControl:(BOOL)addPageControl;
        [Export ("initWithNavBarItems:views:showPageControl:")]
        IntPtr Constructor (UIImageView [] tabBarItems, UIView [] views, bool showPageControl);

        // -(id)initWithNavBarItems:(NSArray *)items navBarBackground:(UIColor *)background views:(NSArray *)views showPageControl:(BOOL)addPageControl;
        [Export ("initWithNavBarItems:navBarBackground:views:showPageControl:")]
        IntPtr Constructor (UIImageView [] tabBarItems, UIColor background, UIView [] views, bool showPageControl);

        // -(id)initWithNavBarControllers:(NSArray *)controllers;
        [Export ("initWithNavBarControllers:")]
        IntPtr Constructor (UIViewController [] controllers);

        // -(id)initWithNavBarControllers:(NSArray *)controllers showPageControl:(BOOL)addPageControl;
        [Export ("initWithNavBarControllers:showPageControl:")]
        IntPtr Constructor (UIViewController [] controllers, bool showPageControl);

        // -(id)initWithNavBarControllers:(NSArray *)controllers navBarBackground:(UIColor *)background showPageControl:(BOOL)addPageControl;
        [Export ("initWithNavBarControllers:navBarBackground:showPageControl:")]
        IntPtr Constructor (UIViewController [] controllers, UIColor background, bool showPageControl);

        // @property (copy, nonatomic) SLPagingViewMovingRedefine pagingViewMovingRedefine;
        [Export ("pagingViewMovingRedefine", ArgumentSemantic.Copy)]
        Action<UIScrollView, UIView[]> MovePageAction { get; set; }

        // @property (copy, nonatomic) SLPagingViewMoving pagingViewMoving;
        [Export ("pagingViewMoving", ArgumentSemantic.Copy),Internal]
        Action<UIView[]> MovePageActionInternal { get; set; }

        // @property (copy, nonatomic) SLPagingViewDidChanged didChangedPage;
        [Export ("didChangedPage", ArgumentSemantic.Copy)]
        Action<int> ChangedPageAction { get; set; }

        // @property (nonatomic, strong) NSDictionary * viewControllers;
        [Export ("viewControllers", ArgumentSemantic.Retain)]
        NSDictionary ViewControllers { get; set; }

        // @property (nonatomic, strong) UIColor * tintPageControlColor;
        [Export ("tintPageControlColor", ArgumentSemantic.Retain)]
        UIColor TintPageControlColor { get; set; }

        // @property (nonatomic, strong) UIColor * currentPageControlColor;
        [Export ("currentPageControlColor", ArgumentSemantic.Retain)]
        UIColor CurrentPageControlColor { get; set; }

        // @property (nonatomic) SLNavigationSideItemsStyle navigationSideItemsStyle;
        [Export ("navigationSideItemsStyle")]
        NavigationSideItemsStyle NavigationSideItemsStyle { get; set; }

        // -(void)updateUserInteractionOnNavigation:(BOOL)activate;
        [Export ("updateUserInteractionOnNavigation:")]
        void UpdateUserInteractionOnNavigation (bool activate);

        // -(void)setCurrentIndex:(NSInteger)index animated:(BOOL)animated;
        [Export ("setCurrentIndex:animated:")]
        void SetCurrentIndex (nint index, bool animated);
    }

}

