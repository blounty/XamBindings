using System;
using ObjCRuntime;

[assembly: LinkWith ("libNotificationHub.a", LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
