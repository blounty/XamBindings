using System;
using ObjCRuntime;

namespace PagingView
{
    [Native]
    public enum NavigationSideItemsStyle : long /* nint */ {
        OnBounds = 40,
        Close = 30,
        Normal = 20,
        Far = 10,
        Default = 0,
        CloseToEachOne = -40
    }
}

