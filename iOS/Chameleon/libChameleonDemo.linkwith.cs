using System;
using ObjCRuntime;

[assembly: LinkWith ("libChameleonDemo.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true, LinkerFlags="-ObjC")]
