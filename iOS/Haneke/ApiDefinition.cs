
// @interface HNKCache : NSObject
using System;
using UIKit;
using Foundation;
using CoreGraphics;
using ObjCRuntime;

namespace Haneke {
    [BaseType (typeof (NSObject)), Protocol]
    interface HNKCache {

        // -(id)initWithName:(NSString *)name;
        [Export ("initWithName:")]
        IntPtr Constructor (string name);

        // @property (readonly, nonatomic) NSDictionary * formats;
        [Export ("formats")]
        NSDictionary Formats { get; }

        // +(HNKCache *)sharedCache;
        [Static, Export ("sharedCache")]
        HNKCache SharedCache ();

        // -(void)registerFormat:(HNKCacheFormat *)format;
        [Export ("registerFormat:")]
        void RegisterFormat (HNKCacheFormat format);

        // -(BOOL)fetchImageForFetcher:(id<HNKFetcher>)fetcher formatName:(NSString *)formatName success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("fetchImageForFetcher:formatName:success:failure:")]
        bool FetchImage (HNKFetcher fetcher, string formatName, Action<UIImage> success, Action<NSError> failure);

        // -(BOOL)fetchImageForKey:(NSString *)key formatName:(NSString *)formatName success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("fetchImageForKey:formatName:success:failure:")]
        bool FetchImage (string key, string formatName, Action<UIImage> success, Action<NSError> failure);

        // -(void)setImage:(UIImage *)image forKey:(NSString *)key formatName:(NSString *)formatName;
        [Export ("setImage:forKey:formatName:")]
        void SetImage (UIImage image, string key, string formatName);

        // -(void)removeAllImages;
        [Export ("removeAllImages")]
        void RemoveAllImages ();

        // -(void)removeImagesOfFormatNamed:(NSString *)formatName;
        [Export ("removeImagesOfFormatNamed:")]
        void RemoveImagesOfFormatNamed (string formatName);

        // -(void)removeImagesForKey:(NSString *)key;
        [Export ("removeImagesForKey:")]
        void RemoveImagesForKey (string key);
    }

    // @protocol HNKFetcher <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface HNKFetcher {

        // @property (readonly, nonatomic) NSString * key;
        [Export ("key")]
        string Key { get; }

        // @required -(void)fetchImageWithSuccess:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("fetchImageWithSuccess:failure:")]
        [Abstract]
        void FetchImage (Action<UIImage> success, Action<NSError> failure);

        // @optional -(void)cancelFetch;
        [Export ("cancelFetch")]
        void CancelFetch ();
    }

    // @interface HNKCacheFormat : NSObject
    [BaseType (typeof (NSObject)), Protocol]
    interface HNKCacheFormat {

        // -(id)initWithName:(NSString *)name;
        [Export ("initWithName:")]
        IntPtr Constructor (string name);

        // @property (assign, nonatomic) BOOL allowUpscaling;
        [Export ("allowUpscaling", ArgumentSemantic.UnsafeUnretained)]
        bool AllowUpscaling { get; set; }

        // @property (assign, nonatomic) CGFloat compressionQuality;
        [Export ("compressionQuality", ArgumentSemantic.UnsafeUnretained)]
        nfloat CompressionQuality { get; set; }

        // @property (readonly, nonatomic) NSString * name;
        [Export ("name")]
        string Name { get; }

        // @property (assign, nonatomic) CGSize size;
        [Export ("size", ArgumentSemantic.UnsafeUnretained)]
        CGSize Size { get; set; }

        // @property (assign, nonatomic) HNKScaleMode scaleMode;
        [Export ("scaleMode", ArgumentSemantic.UnsafeUnretained)]
        HNKScaleMode ScaleMode { get; set; }

        // @property (assign, nonatomic) unsigned long long diskCapacity;
        [Export ("diskCapacity", ArgumentSemantic.UnsafeUnretained)]
        ulong DiskCapacity { get; set; }

        // @property (readonly, nonatomic) unsigned long long diskSize;
        [Export ("diskSize")]
        ulong DiskSize { get; }

        // @property (assign, nonatomic) HNKPreloadPolicy preloadPolicy;
        [Export ("preloadPolicy", ArgumentSemantic.UnsafeUnretained)]
        HNKPreloadPolicy PreloadPolicy { get; set; }

        // @property (copy, nonatomic) UIImage *(^)(NSString *, UIImage *) preResizeBlock;
        [Export ("preResizeBlock", ArgumentSemantic.Copy)]
        Func<NSString, UIImage, UIImage> PreResizeFunc { get; set; }

        // @property (copy, nonatomic) UIImage *(^)(NSString *, UIImage *) postResizeBlock;
        [Export ("postResizeBlock", ArgumentSemantic.Copy)]
        Func<NSString, UIImage, UIImage> PostResizeFunc { get; set; }

        // -(UIImage *)resizedImageFromImage:(UIImage *)image;
        [Export ("resizedImageFromImage:")]
        UIImage ResizedImage (UIImage image);
    }

    // @interface HNKDiskFetcher : NSObject <HNKFetcher>
    [BaseType (typeof (NSObject)), Protocol]
    interface HNKDiskFetcher : HNKFetcher {

        // -(instancetype)initWithPath:(NSString *)path;
        [Export ("initWithPath:")]
        IntPtr Constructor (string path);

        // -(void)cancelFetch;
        [Export ("cancelFetch")]
        void CancelFetch ();
    }

    // @interface HNKNetworkFetcher : NSObject <HNKFetcher>
    [BaseType (typeof (NSObject)), Protocol]
    interface HNKNetworkFetcher : HNKFetcher {

        // -(instancetype)initWithURL:(NSURL *)URL;
        [Export ("initWithURL:")]
        IntPtr Constructor (NSUrl URL);

        // @property (readonly, nonatomic) NSURL * URL;
        [Export ("URL")]
        NSUrl URL { get; }

        // -(void)cancelFetch;
        [Export ("cancelFetch")]
        void CancelFetch ();
    }

    // @interface Subclassing (HNKNetworkFetcher)
    [Category]
    [BaseType (typeof (HNKNetworkFetcher))]
    interface Subclassing {

        // @property (readonly, nonatomic) NSURLSession * URLSession;
        [Export ("URLSession"), Static]
        NSUrlSession URLSession { get; }
    }

    // @interface Haneke (UIImageView)
    [Category]
    [BaseType (typeof (UIImageView))]
    interface HanekeUIImageView {
    
        [Export ("setHnk_cacheFormat:")]
        void SetCacheFormat (HNKCacheFormat cacheFormat);

        [Export ("hnk_cacheFormat")]
        HNKCacheFormat CacheFormat ();

        // -(void)hnk_setImageFromFile:(NSString *)path;
        [Export ("hnk_setImageFromFile:")]
        void SetImage (string filePath);

        // -(void)hnk_setImageFromFile:(NSString *)path placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImageFromFile:placeholder:")]
        void SetImage (string filePath, UIImage placeholder);

        // -(void)hnk_setImageFromFile:(NSString *)path placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImageFromFile:placeholder:success:failure:")]
        void SetImage (string filePath, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setImageFromURL:(NSURL *)url;
        [Export ("hnk_setImageFromURL:")]
        void SetImage (NSUrl url);

        // -(void)hnk_setImageFromURL:(NSURL *)url placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImageFromURL:placeholder:")]
        void SetImage (NSUrl url, UIImage placeholder);

        // -(void)hnk_setImageFromURL:(NSURL *)url placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImageFromURL:placeholder:success:failure:")]
        void SetImage (NSUrl url, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setImage:(UIImage *)image withKey:(NSString *)key;
        [Export ("hnk_setImage:withKey:")]
        void SetImage (UIImage image, string key);

        // -(void)hnk_setImage:(UIImage *)image withKey:(NSString *)key placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImage:withKey:placeholder:")]
        void SetImage (UIImage image, string key, UIImage placeholder);

        // -(void)hnk_setImage:(UIImage *)image withKey:(NSString *)key placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImage:withKey:placeholder:success:failure:")]
        void SetImage (UIImage image, string key, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setImageFromFetcher:(id<HNKFetcher>)fetcher;
        [Export ("hnk_setImageFromFetcher:")]
        void SetImage (HNKFetcher fetcher);

        // -(void)hnk_setImageFromFetcher:(id<HNKFetcher>)fetcher placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImageFromFetcher:placeholder:")]
        void SetImage (HNKFetcher fetcher, UIImage placeholder);

        // -(void)hnk_setImageFromFetcher:(id<HNKFetcher>)fetcher placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImageFromFetcher:placeholder:success:failure:")]
        void SetImage (HNKFetcher fetcher, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_cancelSetImage;
        [Export ("hnk_cancelSetImage")]
        void CancelSetImage ();
    }

    // @interface Haneke (UIButton)
    [Category]
    [BaseType (typeof (UIButton))]
    interface HanekeUIButton {

        [Export ("setHnk_imageFormat:")]
        void SetImageFormat (HNKCacheFormat cacheFormat);

        [Export ("hnk_imageFormat")]
        HNKCacheFormat ImageeFormat ();

        // -(void)hnk_setImageFromURL:(NSURL *)URL forState:(UIControlState)state;
        [Export ("hnk_setImageFromURL:forState:")]
        void SetImage (NSUrl URL, UIControlState state);

        // -(void)hnk_setImageFromURL:(NSURL *)URL forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImageFromURL:forState:placeholder:")]
        void SetImage (NSUrl URL, UIControlState state, UIImage placeholder);

        // -(void)hnk_setImageFromURL:(NSURL *)URL forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImageFromURL:forState:placeholder:success:failure:")]
        void SetImage (NSUrl URL, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setImageFromFile:(NSString *)path forState:(UIControlState)state;
        [Export ("hnk_setImageFromFile:forState:")]
        void SetImage (string path, UIControlState state);

        // -(void)hnk_setImageFromFile:(NSString *)path forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImageFromFile:forState:placeholder:")]
        void SetImage (string path, UIControlState state, UIImage placeholder);

        // -(void)hnk_setImageFromFile:(NSString *)path forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImageFromFile:forState:placeholder:success:failure:")]
        void SetImage (string path, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setImage:(UIImage *)image withKey:(NSString *)key forState:(UIControlState)state;
        [Export ("hnk_setImage:withKey:forState:")]
        void SetImage (UIImage image, string key, UIControlState state);

        // -(void)hnk_setImage:(UIImage *)image withKey:(NSString *)key forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImage:withKey:forState:placeholder:")]
        void SetImage (UIImage image, string key, UIControlState state, UIImage placeholder);

        // -(void)hnk_setImage:(UIImage *)image withKey:(NSString *)key forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImage:withKey:forState:placeholder:success:failure:")]
        void SetImage (UIImage image, string key, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setImageFromFetcher:(id<HNKFetcher>)fetcher forState:(UIControlState)state;
        [Export ("hnk_setImageFromFetcher:forState:")]
        void SetImage (HNKFetcher fetcher, UIControlState state);

        // -(void)hnk_setImageFromFetcher:(id<HNKFetcher>)fetcher forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setImageFromFetcher:forState:placeholder:")]
        void SetImage (HNKFetcher fetcher, UIControlState state, UIImage placeholder);

        // -(void)hnk_setImageFromFetcher:(id<HNKFetcher>)fetcher forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setImageFromFetcher:forState:placeholder:success:failure:")]
        void SetImage (HNKFetcher fetcher, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_cancelSetImage;
        [Export ("hnk_cancelSetImage")]
        void CancelSetImage ();

        // -(void)hnk_setBackgroundImageFromURL:(NSURL *)URL forState:(UIControlState)state;
        [Export ("hnk_setBackgroundImageFromURL:forState:")]
        void SetBackgroundImage (NSUrl URL, UIControlState state);

        // -(void)hnk_setBackgroundImageFromURL:(NSURL *)URL forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setBackgroundImageFromURL:forState:placeholder:")]
        void SetBackgroundImage (NSUrl URL, UIControlState state, UIImage placeholder);

        // -(void)hnk_setBackgroundImageFromURL:(NSURL *)URL forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setBackgroundImageFromURL:forState:placeholder:success:failure:")]
        void SetBackgroundImage (NSUrl URL, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setBackgroundImageFromFile:(NSString *)path forState:(UIControlState)state;
        [Export ("hnk_setBackgroundImageFromFile:forState:")]
        void SetBackgroundImage (string path, UIControlState state);

        // -(void)hnk_setBackgroundImageFromFile:(NSString *)path forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setBackgroundImageFromFile:forState:placeholder:")]
        void SetBackgroundImage (string path, UIControlState state, UIImage placeholder);

        // -(void)hnk_setBackgroundImageFromFile:(NSString *)path forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setBackgroundImageFromFile:forState:placeholder:success:failure:")]
        void SetBackgroundImage (string path, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setBackgroundImage:(UIImage *)image withKey:(NSString *)key forState:(UIControlState)state;
        [Export ("hnk_setBackgroundImage:withKey:forState:")]
        void SetBackgroundImage (UIImage image, string key, UIControlState state);

        // -(void)hnk_setBackgroundImage:(UIImage *)image withKey:(NSString *)key forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setBackgroundImage:withKey:forState:placeholder:")]
        void SetBackgroundImage (UIImage image, string key, UIControlState state, UIImage placeholder);

        // -(void)hnk_setBackgroundImage:(UIImage *)image withKey:(NSString *)key forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setBackgroundImage:withKey:forState:placeholder:success:failure:")]
        void SetBackgroundImage (UIImage image, string key, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_setBackgroundImageFromFetcher:(id<HNKFetcher>)fetcher forState:(UIControlState)state;
        [Export ("hnk_setBackgroundImageFromFetcher:forState:")]
        void SetBackgroundImage (HNKFetcher fetcher, UIControlState state);

        // -(void)hnk_setBackgroundImageFromFetcher:(id<HNKFetcher>)fetcher forState:(UIControlState)state placeholder:(UIImage *)placeholder;
        [Export ("hnk_setBackgroundImageFromFetcher:forState:placeholder:")]
        void SetBackgroundImage (HNKFetcher fetcher, UIControlState state, UIImage placeholder);

        // -(void)hnk_setBackgroundImageFromFetcher:(id<HNKFetcher>)fetcher forState:(UIControlState)state placeholder:(UIImage *)placeholder success:(void (^)(UIImage *))success failure:(void (^)(NSError *))failure;
        [Export ("hnk_setBackgroundImageFromFetcher:forState:placeholder:success:failure:")]
        void SetBackgroundImage (HNKFetcher fetcher, UIControlState state, UIImage placeholder, Action<UIImage> success, Action<NSError> failure);

        // -(void)hnk_cancelSetBackgroundImage;
        [Export ("hnk_cancelSetBackgroundImage")]
        void CancelSetBackgroundImage ();
    }
}
