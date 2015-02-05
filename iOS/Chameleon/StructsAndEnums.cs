using System;
using ObjCRuntime;

namespace Chameleon
{
    [Native]
    public enum UIGradientStyle : ulong /* nuint */ {
        LeftToRight,
        Radial,
        TopToBottom
    }

    [Native]
    public enum UIShadeStyle : long /* nint */ {
        Light,
        Dark
    }

    [Native]
    public enum ColorScheme : long /* nint */ {
        Analogous,
        Triadic,
        Complementary
    }

}

