using System;
using ObjCRuntime;
using UIKit;

[Native]
public enum HNKScaleMode : long
{
    Fill = UIViewContentMode.ScaleToFill,
    AspectFit = UIViewContentMode.ScaleAspectFit,
    AspectFill = UIViewContentMode.ScaleAspectFill,
    None
}

[Native]
public enum HNKPreloadPolicy : long
{
    None,
    LastSession,
    All
}

public enum HNKError
{
    ImageNotFound = -100,
    FetcherMustReturnImage = -200,
    DiskCacheCannotReadImageFromData = -300
}

public enum HNKErrorDiskFetcher
{
    HNKErrorDiskFetcherInvalidData = -500
}

public enum HNKErrorNetworkFetcher
{
    InvalidData = -400,
    MissingData = -401,
    InvalidStatusCode = -402
}
