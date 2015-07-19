using System;
using ObjCRuntime;

[assembly: LinkWith ("libHaneke.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64, SmartLink = true, IsCxx=true, Frameworks="ImageIO", LinkerFlags="-ObjC")]
