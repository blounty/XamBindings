using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace Chameleon
{
    [Category]
    [BaseType (typeof (UIColor))]
    interface ChameleonColor {

        // @property (nonatomic, strong) UIImage * gradientImage;
        [Export ("gradientImage", ArgumentSemantic.Retain)]
        UIImage GradientImage ();

        // +(UIColor *)flatBlackColor;
        [Static, Export ("flatBlackColor")]
        UIColor FlatBlackColor ();

        // +(UIColor *)flatBlueColor;
        [Static, Export ("flatBlueColor")]
        UIColor FlatBlueColor ();

        // +(UIColor *)flatBrownColor;
        [Static, Export ("flatBrownColor")]
        UIColor FlatBrownColor ();

        // +(UIColor *)flatCoffeeColor;
        [Static, Export ("flatCoffeeColor")]
        UIColor FlatCoffeeColor ();

        // +(UIColor *)flatForestGreenColor;
        [Static, Export ("flatForestGreenColor")]
        UIColor FlatForestGreenColor ();

        // +(UIColor *)flatGrayColor;
        [Static, Export ("flatGrayColor")]
        UIColor FlatGrayColor ();

        // +(UIColor *)flatGreenColor;
        [Static, Export ("flatGreenColor")]
        UIColor FlatGreenColor ();

        // +(UIColor *)flatLimeColor;
        [Static, Export ("flatLimeColor")]
        UIColor FlatLimeColor ();

        // +(UIColor *)flatMagentaColor;
        [Static, Export ("flatMagentaColor")]
        UIColor FlatMagentaColor ();

        // +(UIColor *)flatMaroonColor;
        [Static, Export ("flatMaroonColor")]
        UIColor FlatMaroonColor ();

        // +(UIColor *)flatMintColor;
        [Static, Export ("flatMintColor")]
        UIColor FlatMintColor ();

        // +(UIColor *)flatNavyBlueColor;
        [Static, Export ("flatNavyBlueColor")]
        UIColor FlatNavyBlueColor ();

        // +(UIColor *)flatOrangeColor;
        [Static, Export ("flatOrangeColor")]
        UIColor FlatOrangeColor ();

        // +(UIColor *)flatPinkColor;
        [Static, Export ("flatPinkColor")]
        UIColor FlatPinkColor ();

        // +(UIColor *)flatPlumColor;
        [Static, Export ("flatPlumColor")]
        UIColor FlatPlumColor ();

        // +(UIColor *)flatPowderBlueColor;
        [Static, Export ("flatPowderBlueColor")]
        UIColor FlatPowderBlueColor ();

        // +(UIColor *)flatPurpleColor;
        [Static, Export ("flatPurpleColor")]
        UIColor FlatPurpleColor ();

        // +(UIColor *)flatRedColor;
        [Static, Export ("flatRedColor")]
        UIColor FlatRedColor ();

        // +(UIColor *)flatSandColor;
        [Static, Export ("flatSandColor")]
        UIColor FlatSandColor ();

        // +(UIColor *)flatSkyBlueColor;
        [Static, Export ("flatSkyBlueColor")]
        UIColor FlatSkyBlueColor ();

        // +(UIColor *)flatTealColor;
        [Static, Export ("flatTealColor")]
        UIColor FlatTealColor ();

        // +(UIColor *)flatWatermelonColor;
        [Static, Export ("flatWatermelonColor")]
        UIColor FlatWatermelonColor ();

        // +(UIColor *)flatWhiteColor;
        [Static, Export ("flatWhiteColor")]
        UIColor FlatWhiteColor ();

        // +(UIColor *)flatYellowColor;
        [Static, Export ("flatYellowColor")]
        UIColor FlatYellowColor ();

        // +(UIColor *)flatBlackColorDark;
        [Static, Export ("flatBlackColorDark")]
        UIColor FlatBlackColorDark ();

        // +(UIColor *)flatBlueColorDark;
        [Static, Export ("flatBlueColorDark")]
        UIColor FlatBlueColorDark ();

        // +(UIColor *)flatBrownColorDark;
        [Static, Export ("flatBrownColorDark")]
        UIColor FlatBrownColorDark ();

        // +(UIColor *)flatCoffeeColorDark;
        [Static, Export ("flatCoffeeColorDark")]
        UIColor FlatCoffeeColorDark ();

        // +(UIColor *)flatForestGreenColorDark;
        [Static, Export ("flatForestGreenColorDark")]
        UIColor FlatForestGreenColorDark ();

        // +(UIColor *)flatGrayColorDark;
        [Static, Export ("flatGrayColorDark")]
        UIColor FlatGrayColorDark ();

        // +(UIColor *)flatGreenColorDark;
        [Static, Export ("flatGreenColorDark")]
        UIColor FlatGreenColorDark ();

        // +(UIColor *)flatLimeColorDark;
        [Static, Export ("flatLimeColorDark")]
        UIColor FlatLimeColorDark ();

        // +(UIColor *)flatMagentaColorDark;
        [Static, Export ("flatMagentaColorDark")]
        UIColor FlatMagentaColorDark ();

        // +(UIColor *)flatMaroonColorDark;
        [Static, Export ("flatMaroonColorDark")]
        UIColor FlatMaroonColorDark ();

        // +(UIColor *)flatMintColorDark;
        [Static, Export ("flatMintColorDark")]
        UIColor FlatMintColorDark ();

        // +(UIColor *)flatNavyBlueColorDark;
        [Static, Export ("flatNavyBlueColorDark")]
        UIColor FlatNavyBlueColorDark ();

        // +(UIColor *)flatOrangeColorDark;
        [Static, Export ("flatOrangeColorDark")]
        UIColor FlatOrangeColorDark ();

        // +(UIColor *)flatPinkColorDark;
        [Static, Export ("flatPinkColorDark")]
        UIColor FlatPinkColorDark ();

        // +(UIColor *)flatPlumColorDark;
        [Static, Export ("flatPlumColorDark")]
        UIColor FlatPlumColorDark ();

        // +(UIColor *)flatPowderBlueColorDark;
        [Static, Export ("flatPowderBlueColorDark")]
        UIColor FlatPowderBlueColorDark ();

        // +(UIColor *)flatPurpleColorDark;
        [Static, Export ("flatPurpleColorDark")]
        UIColor FlatPurpleColorDark ();

        // +(UIColor *)flatRedColorDark;
        [Static, Export ("flatRedColorDark")]
        UIColor FlatRedColorDark ();

        // +(UIColor *)flatSandColorDark;
        [Static, Export ("flatSandColorDark")]
        UIColor FlatSandColorDark ();

        // +(UIColor *)flatSkyBlueColorDark;
        [Static, Export ("flatSkyBlueColorDark")]
        UIColor FlatSkyBlueColorDark ();

        // +(UIColor *)flatTealColorDark;
        [Static, Export ("flatTealColorDark")]
        UIColor FlatTealColorDark ();

        // +(UIColor *)flatWatermelonColorDark;
        [Static, Export ("flatWatermelonColorDark")]
        UIColor FlatWatermelonColorDark ();

        // +(UIColor *)flatWhiteColorDark;
        [Static, Export ("flatWhiteColorDark")]
        UIColor FlatWhiteColorDark ();

        // +(UIColor *)flatYellowColorDark;
        [Static, Export ("flatYellowColorDark")]
        UIColor FlatYellowColorDark ();

        // +(UIColor *)randomFlatColor;
        [Static, Export ("randomFlatColor")]
        UIColor RandomFlatColor ();

        // +(UIColor *)colorWithComplementaryFlatColorOf:(UIColor *)color;
        [Static, Export ("colorWithComplementaryFlatColorOf:")]
        UIColor ColorWithComplementaryFlatColorOf (UIColor color);

        // +(UIColor *)colorWithFlatVersionOf:(UIColor *)color;
        [Static, Export ("colorWithFlatVersionOf:")]
        UIColor ColorWithFlatVersionOf (UIColor color);

        // +(UIColor *)colorWithContrastingBlackOrWhiteColorOn:(UIColor *)backgroundColor isFlat:(BOOL)flat;
        [Static, Export ("colorWithContrastingBlackOrWhiteColorOn:isFlat:")]
        UIColor ColorWithContrastingBlackOrWhiteColorOn (UIColor backgroundColor, bool flat);

        // +(UIColor *)colorWithRandomFlatColorOfShadeStyle:(UIShadeStyle)shadeStyle;
        [Static, Export ("colorWithRandomFlatColorOfShadeStyle:")]
        UIColor ColorWithRandomFlatColorOfShadeStyle (UIShadeStyle shadeStyle);

        // +(UIColor *)colorWithGradientStyle:(UIGradientStyle)gradientStyle withFrame:(CGRect)frame andColors:(NSArray *)colors;
        [Export ("colorWithGradientStyle:withFrame:andColors:")]
        UIColor ColorWithGradientStyle (UIGradientStyle gradientStyle, CGRect frame, UIColor [] colors);

        // +(UIColor *)colorWithContrastingBlackOrWhiteColorOn:(UIColor *)backgroundColor;
        [Static, Internal, Export ("colorWithContrastingBlackOrWhiteColorOn:")]
        UIColor ColorWithContrastingBlackOrWhiteColorOn (UIColor backgroundColor);
    }

    // @interface ChameleonStatusBar : NSObject
    [BaseType (typeof (NSObject))]
    interface ChameleonStatusBar {

        // +(UIStatusBarStyle)statusBarStyleForColor:(UIColor *)backgroundColor;
        [Export ("statusBarStyleForColor:")]
        UIStatusBarStyle StatusBarStyleForColor (UIColor backgroundColor);
    }

    // @interface Chameleon (NSArray)
    [Category]
    [BaseType (typeof (NSArray))]
    interface ChameleonArray {

        // +(NSArray *)arrayOfColorsWithColorScheme:(ColorScheme)colorScheme with:(UIColor *)color flatScheme:(BOOL)isFlatScheme;
        [Static, Export ("arrayOfColorsWithColorScheme:with:flatScheme:")]
        NSObject [] ArrayOfColorsWithColor (ColorScheme colorScheme, UIColor withColor, bool isFlatScheme);

        // +(NSArray *)arrayOfColorsWithColorScheme:(ColorScheme)colorScheme for:(UIColor *)color flatScheme:(BOOL)isFlatScheme;
        [Static, Internal, Export ("arrayOfColorsWithColorScheme:for:flatScheme:")]
        NSObject [] ArrayOfColorsForColor (ColorScheme colorScheme, UIColor forColor, bool isFlatScheme);
    }

    // @interface Chameleon (UIViewController)
    [Category]
    [BaseType (typeof (UIViewController))]
    interface ChameleonUIViewController {

        // -(void)flatify;
        [Export ("flatify")]
        void Flatify ();

        // -(void)flatifyAndContrast;
        [Export ("flatifyAndContrast")]
        void FlatifyAndContrast ();
    }
}

