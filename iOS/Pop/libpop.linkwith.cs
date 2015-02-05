using System;
using ObjCRuntime;

[assembly: LinkWith ("libpop.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, IsCxx = true, ForceLoad = true, LinkerFlags = "-Objc -lc++")]
