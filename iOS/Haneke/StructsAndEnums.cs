using ObjCRuntime;

[Native]
public enum HNKScaleMode : long /* nint */ {
    Fill = 0,
    AspectFit = 1,
    AspectFill = 2,
    None
}

[Native]
public enum HNKPreloadPolicy : long /* nint */ {
    None,
    LastSession,
    All
}
/*
public enum <unamed-C-enum> {
    HNKErrorImageNotFound = -100,
    HNKErrorFetcherMustReturnImage = -200,
    HNKErrorDiskCacheCannotReadImageFromData = -300
}

public enum <unamed-C-enum> {
    HNKErrorDiskFetcherInvalidData = -500
}

public enum <unamed-C-enum> {
    HNKErrorNetworkFetcherInvalidData = -400,
    HNKErrorNetworkFetcherMissingData = -401,
    HNKErrorNetworkFetcherInvalidStatusCode = -402
}*/
