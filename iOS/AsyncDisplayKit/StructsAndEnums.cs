using System;
using ObjCRuntime;

namespace AsyncDisplayKit
{
    [Native]
    public enum ASAsyncTransactionContainerState : ulong /* nuint */ {
        NoTransactions = 0,
        PendingTransactions
    }

    [Native]
    public enum ASControlNodeEvent : ulong /* nuint */ {
        TouchDown = 1 << 0,
        TouchDownRepeat = 1 << 1,
        TouchDragInside = 1 << 2,
        TouchDragOutside = 1 << 3,
        TouchUpInside = 1 << 4,
        TouchUpOutside = 1 << 5,
        TouchCancel = 1 << 6,
        AllEvents = 4294967295U
    }

    [Native]
    public enum ASImageNodeTint : ulong /* nuint */ {
        Normal = 0,
        Greyscale
    }

    [Native]
    public enum ASTextNodeHighlightStyle : ulong /* nuint */ {
        Light,
        Dark
    }

    [Native]
    public enum ASMultiplexImageNodeErrorCode : ulong /* nuint */ {
        NoSourceForImage = 0,
        BestImageIdentifierChanged
    }

    [Native]
    public enum ASScrollDirection : long /* nint */ {
        None,
        Right,
        Left,
        Up,
        Down
    }

    [Native]
    public enum ASFlowLayoutDirection : ulong /* nuint */ {
        Vertical,
        Horizontal
    }

}

