using System;
using ObjCRuntime;

[assembly: LinkWith ("libPaging.a", LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
