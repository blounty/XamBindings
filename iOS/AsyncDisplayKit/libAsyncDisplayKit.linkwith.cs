using System;
using ObjCRuntime;

[assembly: LinkWith ("libAsyncDisplayKit.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, IsCxx = true, ForceLoad = true, Frameworks="CoreGraphics", LinkerFlags = "-Objc -lc++")]
