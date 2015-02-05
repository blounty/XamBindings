using System;
using ObjCRuntime;

[assembly: LinkWith ("libChameleonDemo.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true, IsCxx=true, LinkerFlags="-all_load -Objc")]
