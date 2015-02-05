using System;
using ObjCRuntime;

[assembly: LinkWith ("libAsyncDisplayKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator, SmartLink = true, IsCxx = true, ForceLoad = true, LinkerFlags = "-all_load")]
