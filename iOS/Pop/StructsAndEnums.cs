using System;
using ObjCRuntime;

namespace Pop
{
    [Native]
    public enum POPAnimationEventType : ulong {
        PropertyRead = 0,
        PropertyWrite,
        ToValueUpdate,
        FromValueUpdate,
        VelocityUpdate,
        BouncinessUpdate,
        SpeedUpdate,
        FrictionUpdate,
        MassUpdate,
        TensionUpdate,
        DidStart,
        DidStop,
        DidReachToValue,
        Autoreversed
    }

    [Native]
    public enum POPAnimationClampFlags : ulong {
        None = 0,
        Start = 1UL << 0,
        End = 1UL << 1,
        Both = Start | End
    }

}

