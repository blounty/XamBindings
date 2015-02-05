using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreAnimation;
using CoreGraphics;
using CoreFoundation;

namespace AsyncDisplayKit
{
    // @protocol ASDisplayNodeAsyncTransactionContainer
    [Protocol, Model]
    interface ASDisplayNodeAsyncTransactionContainer {

        // @property (assign, nonatomic, getter = asyncdisplaykit_isAsyncTransactionContainer, setter = asyncdisplaykit_setAsyncTransactionContainer:) BOOL asyncdisplaykit_asyncTransactionContainer;
        [Export ("asyncdisplaykit_asyncTransactionContainer", ArgumentSemantic.UnsafeUnretained)]
        bool Asyncdisplaykit_asyncTransactionContainer { [Bind ("asyncdisplaykit_isAsyncTransactionContainer")] get; [Bind ("asyncdisplaykit_setAsyncTransactionContainer:")] set; }

        // @property (readonly, assign, nonatomic) ASAsyncTransactionContainerState asyncdisplaykit_asyncTransactionContainerState;
        [Export ("asyncdisplaykit_asyncTransactionContainerState", ArgumentSemantic.UnsafeUnretained)]
        ASAsyncTransactionContainerState Asyncdisplaykit_asyncTransactionContainerState { get; }

        // @required -(void)asyncdisplaykit_cancelAsyncTransactions;
        [Export ("asyncdisplaykit_cancelAsyncTransactions")]
        [Abstract]
        void Asyncdisplaykit_cancelAsyncTransactions ();

        // @required -(void)asyncdisplaykit_asyncTransactionContainerStateDidChange;
        [Export ("asyncdisplaykit_asyncTransactionContainerStateDidChange")]
        [Abstract]
        void Asyncdisplaykit_asyncTransactionContainerStateDidChange ();
    }

    // @interface ASDisplayNodeAsyncTransactionContainer (CALayer) <ASDisplayNodeAsyncTransactionContainer>
    [Category]
    [BaseType (typeof (CALayer))]
    interface ASDisplayNodeAsyncTransactionContainerExtension {

        // @property (readonly, retain, nonatomic) _ASAsyncTransaction * asyncdisplaykit_asyncTransaction;
        //[Export ("asyncdisplaykit_asyncTransaction", ArgumentSemantic.Retain)]
        //ASAsyncTransaction Asyncdisplaykit_asyncTransaction { get; }

        // @property (readonly, retain, nonatomic) CALayer * asyncdisplaykit_parentTransactionContainer;
        [Export ("asyncdisplaykit_parentTransactionContainer", ArgumentSemantic.Retain)]
        CALayer Asyncdisplaykit_parentTransactionContainer();
    }

    // @interface ASDealloc2MainObject : NSObject
    [BaseType (typeof (NSObject))]
    interface ASDealloc2MainObject {

        // -(BOOL)_isDeallocating;
        [Export ("_isDeallocating")]
        bool _isDeallocating ();
    }

    // @interface ASDisplayNode : ASDealloc2MainObject
    [BaseType (typeof (ASDealloc2MainObject))]
    interface ASDisplayNode {

        // -(id)initWithViewBlock:(ASDisplayNodeViewBlock)viewBlock;
        [Export ("initWithViewBlock:")]
        IntPtr Constructor (Func<UIView> viewBlock);

        // -(id)initWithLayerBlock:(ASDisplayNodeLayerBlock)viewBlock;
        [Export ("initWithLayerBlock:")]
        IntPtr Constructor (Func<CALayer> viewBlock);

        // @property (readonly, assign, nonatomic, getter = isSynchronous) BOOL synchronous;
        [Export ("synchronous", ArgumentSemantic.UnsafeUnretained)]
        bool Synchronous { [Bind ("isSynchronous")] get; }

        // @property (readonly, retain, nonatomic) UIView * view;
        [Export ("view", ArgumentSemantic.Retain)]
        UIView View { get; }

        // @property (readonly, assign, atomic, getter = isNodeLoaded) BOOL nodeLoaded;
        [Export ("nodeLoaded", ArgumentSemantic.UnsafeUnretained)]
        bool NodeLoaded { [Bind ("isNodeLoaded")] get; }

        // @property (assign, nonatomic, getter = isLayerBacked) BOOL layerBacked;
        [Export ("layerBacked", ArgumentSemantic.UnsafeUnretained)]
        bool LayerBacked { [Bind ("isLayerBacked")] get; set; }

        // @property (readonly, retain, nonatomic) CALayer * layer;
        [Export ("layer", ArgumentSemantic.Retain)]
        CALayer Layer { get; }

        // @property (readonly, assign, nonatomic) CGSize calculatedSize;
        [Export ("calculatedSize", ArgumentSemantic.UnsafeUnretained)]
        CGSize CalculatedSize { get; }

        // @property (readonly, assign, nonatomic) CGSize constrainedSizeForCalculatedSize;
        [Export ("constrainedSizeForCalculatedSize", ArgumentSemantic.UnsafeUnretained)]
        CGSize ConstrainedSizeForCalculatedSize { get; }

        // @property (readonly, retain, nonatomic) NSArray * subnodes;
        [Export ("subnodes", ArgumentSemantic.Retain)]
        NSObject [] Subnodes { get; }

        // @property (readonly, nonatomic, weak) ASDisplayNode * supernode;
        [Export ("supernode", ArgumentSemantic.Weak)]
        ASDisplayNode Supernode { get; }

        // @property (assign, nonatomic) BOOL displaysAsynchronously;
        [Export ("displaysAsynchronously", ArgumentSemantic.UnsafeUnretained)]
        bool DisplaysAsynchronously { get; set; }

        // @property (assign, nonatomic) BOOL shouldRasterizeDescendants;
        [Export ("shouldRasterizeDescendants", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldRasterizeDescendants { get; set; }

        // @property (assign, nonatomic) BOOL displaySuspended;
        [Export ("displaySuspended", ArgumentSemantic.UnsafeUnretained)]
        bool DisplaySuspended { get; set; }

        // @property (assign, nonatomic) BOOL placeholderEnabled;
        [Export ("placeholderEnabled", ArgumentSemantic.UnsafeUnretained)]
        bool PlaceholderEnabled { get; set; }

        // @property (assign, nonatomic) BOOL placeholderFadesOut;
        [Export ("placeholderFadesOut", ArgumentSemantic.UnsafeUnretained)]
        bool PlaceholderFadesOut { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets hitTestSlop;
        [Export ("hitTestSlop", ArgumentSemantic.UnsafeUnretained)]
        UIEdgeInsets HitTestSlop { get; set; }

        // -(CGSize)measure:(CGSize)constrainedSize;
        [Export ("measure:")]
        CGSize Measure (CGSize constrainedSize);

        // -(void)addSubnode:(ASDisplayNode *)subnode;
        [Export ("addSubnode:")]
        void AddSubnode (ASDisplayNode subnode);

        // -(void)insertSubnode:(ASDisplayNode *)subnode belowSubnode:(ASDisplayNode *)below;
        [Export ("insertSubnode:belowSubnode:")]
        void InsertSubnodeBelow (ASDisplayNode subnode, ASDisplayNode below);

        // -(void)insertSubnode:(ASDisplayNode *)subnode aboveSubnode:(ASDisplayNode *)above;
        [Export ("insertSubnode:aboveSubnode:")]
        void InsertSubnodeAbove (ASDisplayNode subnode, ASDisplayNode above);

        // -(void)insertSubnode:(ASDisplayNode *)subnode atIndex:(NSInteger)idx;
        [Export ("insertSubnode:atIndex:")]
        void InsertSubnode (ASDisplayNode subnode, nint idx);

        // -(void)replaceSubnode:(ASDisplayNode *)subnode withSubnode:(ASDisplayNode *)replacementSubnode;
        [Export ("replaceSubnode:withSubnode:")]
        void ReplaceSubnode (ASDisplayNode subnode, ASDisplayNode replacementSubnode);

        // -(void)removeFromSupernode;
        [Export ("removeFromSupernode")]
        void RemoveFromSupernode ();

        // -(void)recursivelySetDisplaySuspended:(BOOL)flag;
        [Export ("recursivelySetDisplaySuspended:")]
        void RecursivelySetDisplaySuspended (bool flag);

        // -(void)recursivelyReclaimMemory;
        [Export ("recursivelyReclaimMemory")]
        void RecursivelyReclaimMemory ();

        // -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent *)event;
        [Export ("pointInside:withEvent:")]
        bool PointInside (CGPoint point, UIEvent evnt);

        // -(CGPoint)convertPoint:(CGPoint)point toNode:(ASDisplayNode *)node;
        [Export ("convertPoint:toNode:")]
        CGPoint ConvertPointToNode (CGPoint point, ASDisplayNode node);

        // -(CGPoint)convertPoint:(CGPoint)point fromNode:(ASDisplayNode *)node;
        [Export ("convertPoint:fromNode:")]
        CGPoint ConvertPointFromNode (CGPoint point, ASDisplayNode node);

        // -(CGRect)convertRect:(CGRect)rect toNode:(ASDisplayNode *)node;
        [Export ("convertRect:toNode:")]
        CGRect ConvertRectToNode (CGRect rect, ASDisplayNode node);

        // -(CGRect)convertRect:(CGRect)rect fromNode:(ASDisplayNode *)node;
        [Export ("convertRect:fromNode:")]
        CGRect ConvertRectFromNode (CGRect rect, ASDisplayNode node);

        // @property (retain, atomic) id contents;
        [Export ("contents", ArgumentSemantic.Retain)]
        NSObject Contents { get; set; }

        // @property (assign, atomic) BOOL clipsToBounds;
        [Export ("clipsToBounds", ArgumentSemantic.UnsafeUnretained)]
        bool ClipsToBounds { get; set; }

        // @property (atomic, getter = isOpaque) BOOL opaque;
        [Export ("opaque")]
        bool Opaque { [Bind ("isOpaque")] get; set; }

        // @property (assign, atomic) BOOL allowsEdgeAntialiasing;
        [Export ("allowsEdgeAntialiasing", ArgumentSemantic.UnsafeUnretained)]
        bool AllowsEdgeAntialiasing { get; set; }

        // @property (assign, atomic) unsigned int edgeAntialiasingMask;
        [Export ("edgeAntialiasingMask", ArgumentSemantic.UnsafeUnretained)]
        uint EdgeAntialiasingMask { get; set; }

        // @property (atomic, getter = isHidden) BOOL hidden;
        [Export ("hidden")]
        bool Hidden { [Bind ("isHidden")] get; set; }

        // @property (assign, atomic) BOOL needsDisplayOnBoundsChange;
        [Export ("needsDisplayOnBoundsChange", ArgumentSemantic.UnsafeUnretained)]
        bool NeedsDisplayOnBoundsChange { get; set; }

        // @property (assign, atomic) BOOL autoresizesSubviews;
        [Export ("autoresizesSubviews", ArgumentSemantic.UnsafeUnretained)]
        bool AutoresizesSubviews { get; set; }

        // @property (assign, atomic) UIViewAutoresizing autoresizingMask;
        [Export ("autoresizingMask", ArgumentSemantic.UnsafeUnretained)]
        UIViewAutoresizing AutoresizingMask { get; set; }

        // @property (assign, atomic) CGFloat alpha;
        [Export ("alpha", ArgumentSemantic.UnsafeUnretained)]
        nfloat Alpha { get; set; }

        // @property (assign, atomic) CGRect bounds;
        [Export ("bounds", ArgumentSemantic.UnsafeUnretained)]
        CGRect Bounds { get; set; }

        // @property (assign, atomic) CGRect frame;
        [Export ("frame", ArgumentSemantic.UnsafeUnretained)]
        CGRect Frame { get; set; }

        // @property (assign, atomic) CGPoint anchorPoint;
        [Export ("anchorPoint", ArgumentSemantic.UnsafeUnretained)]
        CGPoint AnchorPoint { get; set; }

        // @property (assign, atomic) CGFloat zPosition;
        [Export ("zPosition", ArgumentSemantic.UnsafeUnretained)]
        nfloat ZPosition { get; set; }

        // @property (assign, atomic) CGPoint position;
        [Export ("position", ArgumentSemantic.UnsafeUnretained)]
        CGPoint Position { get; set; }

        // @property (assign, atomic) CGFloat cornerRadius;
        [Export ("cornerRadius", ArgumentSemantic.UnsafeUnretained)]
        nfloat CornerRadius { get; set; }

        // @property (assign, atomic) CGFloat contentsScale;
        [Export ("contentsScale", ArgumentSemantic.UnsafeUnretained)]
        nfloat ContentsScale { get; set; }

        // @property (assign, atomic) CATransform3D transform;
        [Export ("transform", ArgumentSemantic.UnsafeUnretained)]
        CATransform3D Transform { get; set; }

        // @property (assign, atomic) CATransform3D subnodeTransform;
        [Export ("subnodeTransform", ArgumentSemantic.UnsafeUnretained)]
        CATransform3D SubnodeTransform { get; set; }

        // @property (copy, atomic) NSString * name;
        [Export ("name")]
        string Name { get; set; }

        // @property (retain, atomic) UIColor * backgroundColor;
        [Export ("backgroundColor", ArgumentSemantic.Retain)]
        UIColor BackgroundColor { get; set; }

        // @property (retain, atomic) UIColor * tintColor;
        [Export ("tintColor", ArgumentSemantic.Retain)]
        UIColor TintColor { get; set; }

        // @property (assign, atomic) UIViewContentMode contentMode;
        [Export ("contentMode", ArgumentSemantic.UnsafeUnretained)]
        UIViewContentMode ContentMode { get; set; }

        // @property (assign, atomic, getter = isUserInteractionEnabled) BOOL userInteractionEnabled;
        [Export ("userInteractionEnabled", ArgumentSemantic.UnsafeUnretained)]
        bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

        // @property (assign, atomic, getter = isExclusiveTouch) BOOL exclusiveTouch;
        [Export ("exclusiveTouch", ArgumentSemantic.UnsafeUnretained)]
        bool ExclusiveTouch { [Bind ("isExclusiveTouch")] get; set; }

        // @property (assign, atomic) CGColorRef shadowColor;
        [Export ("shadowColor", ArgumentSemantic.UnsafeUnretained)]
        CGColor ShadowColor { get; set; }

        // @property (assign, atomic) CGFloat shadowOpacity;
        [Export ("shadowOpacity", ArgumentSemantic.UnsafeUnretained)]
        nfloat ShadowOpacity { get; set; }

        // @property (assign, atomic) CGSize shadowOffset;
        [Export ("shadowOffset", ArgumentSemantic.UnsafeUnretained)]
        CGSize ShadowOffset { get; set; }

        // @property (assign, atomic) CGFloat shadowRadius;
        [Export ("shadowRadius", ArgumentSemantic.UnsafeUnretained)]
        nfloat ShadowRadius { get; set; }

        // @property (assign, atomic) CGFloat borderWidth;
        [Export ("borderWidth", ArgumentSemantic.UnsafeUnretained)]
        nfloat BorderWidth { get; set; }

        // @property (assign, atomic) CGColorRef borderColor;
        [Export ("borderColor", ArgumentSemantic.UnsafeUnretained)]
        CGColor BorderColor { get; set; }

        // @property (assign, atomic) BOOL isAccessibilityElement;
        [Export ("isAccessibilityElement", ArgumentSemantic.UnsafeUnretained)]
        bool IsAccessibilityElement { get; set; }

        // @property (copy, atomic) NSString * accessibilityLabel;
        [Export ("accessibilityLabel")]
        string AccessibilityLabel { get; set; }

        // @property (copy, atomic) NSString * accessibilityHint;
        [Export ("accessibilityHint")]
        string AccessibilityHint { get; set; }

        // @property (copy, atomic) NSString * accessibilityValue;
        [Export ("accessibilityValue")]
        string AccessibilityValue { get; set; }

        // @property (assign, atomic) UIAccessibilityTraits accessibilityTraits;
        [Export ("accessibilityTraits", ArgumentSemantic.UnsafeUnretained)]
        ulong AccessibilityTraits { get; set; }

        // @property (assign, atomic) CGRect accessibilityFrame;
        [Export ("accessibilityFrame", ArgumentSemantic.UnsafeUnretained)]
        CGRect AccessibilityFrame { get; set; }

        // @property (retain, atomic) NSString * accessibilityLanguage;
        [Export ("accessibilityLanguage", ArgumentSemantic.Retain)]
        string AccessibilityLanguage { get; set; }

        // @property (assign, atomic) BOOL accessibilityElementsHidden;
        [Export ("accessibilityElementsHidden", ArgumentSemantic.UnsafeUnretained)]
        bool AccessibilityElementsHidden { get; set; }

        // @property (assign, atomic) BOOL accessibilityViewIsModal;
        [Export ("accessibilityViewIsModal", ArgumentSemantic.UnsafeUnretained)]
        bool AccessibilityViewIsModal { get; set; }

        // @property (assign, atomic) BOOL shouldGroupAccessibilityChildren;
        [Export ("shouldGroupAccessibilityChildren", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldGroupAccessibilityChildren { get; set; }

        // -(void)setNeedsDisplay;
        [Export ("setNeedsDisplay")]
        void SetNeedsDisplay ();

        // -(void)setNeedsLayout;
        [Export ("setNeedsLayout")]
        void SetNeedsLayout ();

        // -(void)tintColorDidChange;
        [Export ("tintColorDidChange")]
        void TintColorDidChange ();
    }

    // @interface Debugging (ASDisplayNode)
    [Category]
    [BaseType (typeof (ASDisplayNode))]
    interface Debugging {

        // -(NSString *)displayNodeRecursiveDescription;
        [Export ("displayNodeRecursiveDescription")]
        string DisplayNodeRecursiveDescription ();
    }

    // @interface ASControlNode : ASDisplayNode
    [BaseType (typeof (ASDisplayNode))]
    interface ASControlNode {

        // @property (assign, nonatomic, getter = isEnabled) BOOL enabled;
        [Export ("enabled", ArgumentSemantic.UnsafeUnretained)]
        bool Enabled { [Bind ("isEnabled")] get; set; }

        // @property (readonly, assign, nonatomic, getter = isHighlighted) BOOL highlighted;
        [Export ("highlighted", ArgumentSemantic.UnsafeUnretained)]
        bool Highlighted { [Bind ("isHighlighted")] get; }

        // @property (readonly, assign, nonatomic, getter = isTracking) BOOL tracking;
        [Export ("tracking", ArgumentSemantic.UnsafeUnretained)]
        bool Tracking { [Bind ("isTracking")] get; }

        // @property (readonly, assign, nonatomic, getter = isTouchInside) BOOL touchInside;
        [Export ("touchInside", ArgumentSemantic.UnsafeUnretained)]
        bool TouchInside { [Bind ("isTouchInside")] get; }

        // -(void)addTarget:(id)target action:(SEL)action forControlEvents:(ASControlNodeEvent)controlEvents;
        [Export ("addTarget:action:forControlEvents:")]
        void AddTarget (NSObject target, Selector action, ASControlNodeEvent controlEvents);

        // -(NSArray *)actionsForTarget:(id)target forControlEvent:(ASControlNodeEvent)controlEvent;
        [Export ("actionsForTarget:forControlEvent:")]
        NSObject [] ActionsForTarget (NSObject target, ASControlNodeEvent controlEvent);

        // -(NSSet *)allTargets;
        [Export ("allTargets")]
        NSSet AllTargets ();

        // -(void)removeTarget:(id)target action:(SEL)action forControlEvents:(ASControlNodeEvent)controlEvents;
        [Export ("removeTarget:action:forControlEvents:")]
        void RemoveTarget (NSObject target, Selector action, ASControlNodeEvent controlEvents);

        // -(void)sendActionsForControlEvents:(ASControlNodeEvent)controlEvents withEvent:(UIEvent *)event;
        [Export ("sendActionsForControlEvents:withEvent:")]
        void SendActionsForControlEvents (ASControlNodeEvent controlEvents, UIEvent evnt);
    }

    // @interface ASImageNode : ASControlNode
    [BaseType (typeof (ASControlNode))]
    interface ASImageNode {

        // @property (retain, atomic) UIImage * image;
        [Export ("image", ArgumentSemantic.Retain)]
        UIImage Image { get; set; }

        // @property (assign, nonatomic) ASImageNodeTint tint;
        [Export ("tint", ArgumentSemantic.UnsafeUnretained)]
        ASImageNodeTint Tint { get; set; }

        // @property (nonatomic, strong) UIColor * placeholderColor;
        [Export ("placeholderColor", ArgumentSemantic.Retain)]
        UIColor PlaceholderColor { get; set; }

        // @property (assign, nonatomic, getter = isCropEnabled) BOOL cropEnabled;
        [Export ("cropEnabled", ArgumentSemantic.UnsafeUnretained)]
        bool CropEnabled { [Bind ("isCropEnabled")] get; set; }

        // @property (assign, readwrite, nonatomic) CGRect cropRect;
        [Export ("cropRect", ArgumentSemantic.UnsafeUnretained)]
        CGRect CropRect { get; set; }

        // @property (readwrite, copy, nonatomic) asimagenode_modification_block_t imageModificationBlock;
        [Export ("imageModificationBlock", ArgumentSemantic.Copy)]
        Func<UIImage, UIImage> ImageModificationBlock { get; set; }

        // -(void)setCropEnabled:(BOOL)cropEnabled recropImmediately:(BOOL)recropImmediately inBounds:(CGRect)cropBounds;
        [Export ("setCropEnabled:recropImmediately:inBounds:")]
        void SetCropEnabled (bool cropEnabled, bool recropImmediately, CGRect cropBounds);

        // -(void)setNeedsDisplayWithCompletion:(void (^)(BOOL))displayCompletionBlock;
        [Export ("setNeedsDisplayWithCompletion:")]
        void SetNeedsDisplayWithCompletion (Action<sbyte> displayCompletionBlock);
    }

    // @interface ASTextNode : ASControlNode
    [BaseType (typeof (ASControlNode))]
    interface ASTextNode {

        // @property (copy, nonatomic) NSAttributedString * attributedString;
        [Export ("attributedString", ArgumentSemantic.Copy)]
        NSAttributedString AttributedString { get; set; }

        // @property (copy, nonatomic) NSAttributedString * truncationAttributedString;
        [Export ("truncationAttributedString", ArgumentSemantic.Copy)]
        NSAttributedString TruncationAttributedString { get; set; }

        // @property (copy, nonatomic) NSAttributedString * additionalTruncationMessage;
        [Export ("additionalTruncationMessage", ArgumentSemantic.Copy)]
        NSAttributedString AdditionalTruncationMessage { get; set; }

        // @property (assign, nonatomic) NSLineBreakMode truncationMode;
        //[Export ("truncationMode", ArgumentSemantic.UnsafeUnretained)]
        //NSLineBreakMode TruncationMode { get; set; }

        // @property (readonly, assign, nonatomic, getter = isTruncated) BOOL truncated;
        [Export ("truncated", ArgumentSemantic.UnsafeUnretained)]
        bool Truncated { [Bind ("isTruncated")] get; }

        // @property (assign, nonatomic) NSUInteger maximumLineCount;
        [Export ("maximumLineCount", ArgumentSemantic.UnsafeUnretained)]
        nuint MaximumLineCount { get; set; }

        // @property (readonly, assign, nonatomic) NSUInteger lineCount;
        [Export ("lineCount", ArgumentSemantic.UnsafeUnretained)]
        nuint LineCount { get; }

        // @property (nonatomic, strong) UIColor * placeholderColor;
        [Export ("placeholderColor", ArgumentSemantic.Retain)]
        UIColor PlaceholderColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets placeholderInsets;
        [Export ("placeholderInsets", ArgumentSemantic.UnsafeUnretained)]
        UIEdgeInsets PlaceholderInsets { get; set; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets shadowPadding;
        [Export ("shadowPadding", ArgumentSemantic.UnsafeUnretained)]
        UIEdgeInsets ShadowPadding { get; }

        // @property (copy, nonatomic) NSArray * linkAttributeNames;
        [Export ("linkAttributeNames", ArgumentSemantic.Copy)]
        NSObject [] LinkAttributeNames { get; set; }

        // @property (assign, nonatomic) ASTextNodeHighlightStyle highlightStyle;
        [Export ("highlightStyle", ArgumentSemantic.UnsafeUnretained)]
        ASTextNodeHighlightStyle HighlightStyle { get; set; }

        // @property (assign, nonatomic) NSRange highlightRange;
        [Export ("highlightRange", ArgumentSemantic.UnsafeUnretained)]
        NSRange HighlightRange { get; set; }

        // @property (nonatomic, weak) id<ASTextNodeDelegate> delegate;
        [Export ("delegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<ASTextNodeDelegate> delegate;
        [Wrap ("WeakDelegate")]
        ASTextNodeDelegate Delegate { get; set; }

        // -(NSArray *)rectsForTextRange:(NSRange)textRange;
        [Export ("rectsForTextRange:")]
        NSObject [] RectsForTextRange (NSRange textRange);

        // -(NSArray *)highlightRectsForTextRange:(NSRange)textRange;
        [Export ("highlightRectsForTextRange:")]
        NSObject [] HighlightRectsForTextRange (NSRange textRange);

        // -(CGRect)frameForTextRange:(NSRange)textRange;
        [Export ("frameForTextRange:")]
        CGRect FrameForTextRange (NSRange textRange);

        // -(CGRect)trailingRect;
        [Export ("trailingRect")]
        CGRect TrailingRect ();

        // -(id)linkAttributeValueAtPoint:(CGPoint)point attributeName:(NSString **)attributeNameOut range:(NSRange *)rangeOut;
        [Export ("linkAttributeValueAtPoint:attributeName:range:")]
        NSObject LinkAttributeValueAtPoint (CGPoint point, out string attributeNameOut, NSRange rangeOut);

        // -(void)setHighlightRange:(NSRange)highlightRange animated:(BOOL)animated;
        [Export ("setHighlightRange:animated:")]
        void SetHighlightRange (NSRange highlightRange, bool animated);
    }

    // @protocol ASTextNodeDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASTextNodeDelegate {

        // @optional -(void)textNode:(ASTextNode *)textNode tappedLinkAttribute:(NSString *)attribute value:(id)value atPoint:(CGPoint)point textRange:(NSRange)textRange;
        [Export ("textNode:tappedLinkAttribute:value:atPoint:textRange:")]
        void TappedLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point, NSRange textRange);

        // @optional -(void)textNode:(ASTextNode *)textNode longPressedLinkAttribute:(NSString *)attribute value:(id)value atPoint:(CGPoint)point textRange:(NSRange)textRange;
        [Export ("textNode:longPressedLinkAttribute:value:atPoint:textRange:")]
        void LongPressedLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point, NSRange textRange);

        // @optional -(void)textNodeTappedTruncationToken:(ASTextNode *)textNode;
        [Export ("textNodeTappedTruncationToken:")]
        void TextNodeTappedTruncationToken (ASTextNode textNode);

        // @optional -(BOOL)textNode:(ASTextNode *)textNode shouldHighlightLinkAttribute:(NSString *)attribute value:(id)value atPoint:(CGPoint)point;
        [Export ("textNode:shouldHighlightLinkAttribute:value:atPoint:")]
        bool ShouldHighlightLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point);

        // @optional -(BOOL)textNode:(ASTextNode *)textNode shouldLongPressLinkAttribute:(NSString *)attribute value:(id)value atPoint:(CGPoint)point;
        [Export ("textNode:shouldLongPressLinkAttribute:value:atPoint:")]
        bool ShouldLongPressLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point);
    }

    // @interface ASEditableTextNode : ASDisplayNode
    [BaseType (typeof (ASDisplayNode))]
    interface ASEditableTextNode {

        // @property (readwrite, nonatomic, weak) id<ASEditableTextNodeDelegate> delegate;
        [Export ("delegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakDelegate { get; set; }

        // @property (readwrite, nonatomic, weak) id<ASEditableTextNodeDelegate> delegate;
        [Wrap ("WeakDelegate")]
        ASEditableTextNodeDelegate Delegate { get; set; }

        // @property (readwrite, nonatomic, strong) NSDictionary * typingAttributes;
        [Export ("typingAttributes", ArgumentSemantic.Retain)]
        NSDictionary TypingAttributes { get; set; }

        // @property (assign, readwrite, nonatomic) NSRange selectedRange;
        [Export ("selectedRange", ArgumentSemantic.UnsafeUnretained)]
        NSRange SelectedRange { get; set; }

        // @property (readwrite, nonatomic, strong) NSAttributedString * attributedPlaceholderText;
        [Export ("attributedPlaceholderText", ArgumentSemantic.Retain)]
        NSAttributedString AttributedPlaceholderText { get; set; }

        // @property (readwrite, copy, nonatomic) NSAttributedString * attributedText;
        [Export ("attributedText", ArgumentSemantic.Copy)]
        NSAttributedString AttributedText { get; set; }

        // @property (readonly, nonatomic) UITextInputMode * textInputMode;
        [Export ("textInputMode")]
        UITextInputMode TextInputMode { get; }

        // -(BOOL)isDisplayingPlaceholder;
        [Export ("isDisplayingPlaceholder")]
        bool IsDisplayingPlaceholder ();

        // -(BOOL)isFirstResponder;
        [Export ("isFirstResponder")]
        bool IsFirstResponder ();

        // -(void)becomeFirstResponder;
        [Export ("becomeFirstResponder")]
        void BecomeFirstResponder ();

        // -(void)resignFirstResponder;
        [Export ("resignFirstResponder")]
        void ResignFirstResponder ();

        // -(CGRect)frameForTextRange:(NSRange)textRange;
        [Export ("frameForTextRange:")]
        CGRect FrameForTextRange (NSRange textRange);
    }

    // @protocol ASEditableTextNodeDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASEditableTextNodeDelegate {

        // @optional -(void)editableTextNodeDidBeginEditing:(ASEditableTextNode *)editableTextNode;
        [Export ("editableTextNodeDidBeginEditing:")]
        void EditableTextNodeDidBeginEditing (ASEditableTextNode editableTextNode);

        // @optional -(BOOL)editableTextNode:(ASEditableTextNode *)editableTextNode shouldChangeTextInRange:(NSRange)range replacementText:(NSString *)text;
        [Export ("editableTextNode:shouldChangeTextInRange:replacementText:")]
        bool ShouldChangeTextInRange (ASEditableTextNode editableTextNode, NSRange range, string text);

        // @optional -(void)editableTextNodeDidChangeSelection:(ASEditableTextNode *)editableTextNode fromSelectedRange:(NSRange)fromSelectedRange toSelectedRange:(NSRange)toSelectedRange dueToEditing:(BOOL)dueToEditing;
        [Export ("editableTextNodeDidChangeSelection:fromSelectedRange:toSelectedRange:dueToEditing:")]
        void FromSelectedRange (ASEditableTextNode editableTextNode, NSRange fromSelectedRange, NSRange toSelectedRange, bool dueToEditing);

        // @optional -(void)editableTextNodeDidUpdateText:(ASEditableTextNode *)editableTextNode;
        [Export ("editableTextNodeDidUpdateText:")]
        void EditableTextNodeDidUpdateText (ASEditableTextNode editableTextNode);

        // @optional -(void)editableTextNodeDidFinishEditing:(ASEditableTextNode *)editableTextNode;
        [Export ("editableTextNodeDidFinishEditing:")]
        void EditableTextNodeDidFinishEditing (ASEditableTextNode editableTextNode);
    }

    // @protocol ASImageCacheProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASImageCacheProtocol {

        // @required -(void)fetchCachedImageWithURL:(NSURL *)URL callbackQueue:(dispatch_queue_t)callbackQueue completion:(void (^)(CGImageRef))completion;
        //[Export ("fetchCachedImageWithURL:callbackQueue:completion:")]
        //[Abstract]
        //void CallbackQueue (NSUrl URL, DispatchQueue callbackQueue, Action<CGImage> completion);
    }

    // @protocol ASImageDownloaderProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASImageDownloaderProtocol {

        // @required -(id)downloadImageWithURL:(NSURL *)URL callbackQueue:(dispatch_queue_t)callbackQueue downloadProgressBlock:(void (^)(CGFloat))downloadProgressBlock completion:(void (^)(CGImageRef, NSError *))completion;
        //[Export ("downloadImageWithURL:callbackQueue:downloadProgressBlock:completion:")]
        //[Abstract]
       // NSObject DownloadImageWithURL (NSUrl URL, DispatchQueue callbackQueue, Action<float> downloadProgressBlock, Action<CGImage, NSError> completion);

        // @required -(void)cancelImageDownloadForIdentifier:(id)downloadIdentifier;
        [Export ("cancelImageDownloadForIdentifier:")]
        [Abstract]
        void CancelImageDownloadForIdentifier (NSObject downloadIdentifier);
    }

    // @interface ASBasicImageDownloader : NSObject <ASImageDownloaderProtocol>
    [BaseType (typeof (NSObject))]
    interface ASBasicImageDownloader : ASImageDownloaderProtocol {

    }

    // @interface ASMultiplexImageNode : ASImageNode
    [BaseType (typeof (ASImageNode))]
    interface ASMultiplexImageNode {

        // -(instancetype)initWithCache:(id<ASImageCacheProtocol>)cache downloader:(id<ASImageDownloaderProtocol>)downloader;
        [Export ("initWithCache:downloader:")]
        IntPtr Constructor (ASImageCacheProtocol cache, ASImageDownloaderProtocol downloader);

        // @property (readwrite, nonatomic, weak) id<ASMultiplexImageNodeDelegate> delegate;
        [Export ("delegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakDelegate { get; set; }

        // @property (readwrite, nonatomic, weak) id<ASMultiplexImageNodeDelegate> delegate;
        [Wrap ("WeakDelegate")]
        ASMultiplexImageNodeDelegate Delegate { get; set; }

        // @property (readwrite, nonatomic, weak) id<ASMultiplexImageNodeDataSource> dataSource;
        [Export ("dataSource", ArgumentSemantic.Weak)]
        ASMultiplexImageNodeDataSource DataSource { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL downloadsIntermediateImages;
        [Export ("downloadsIntermediateImages", ArgumentSemantic.UnsafeUnretained)]
        bool DownloadsIntermediateImages { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL haltsLoadingOnError;
        [Export ("haltsLoadingOnError", ArgumentSemantic.UnsafeUnretained)]
        bool HaltsLoadingOnError { get; set; }

        // @property (readwrite, copy, nonatomic) NSArray * imageIdentifiers;
        [Export ("imageIdentifiers", ArgumentSemantic.Copy)]
        NSObject [] ImageIdentifiers { get; set; }

        // @property (readonly, nonatomic) id loadedImageIdentifier;
        [Export ("loadedImageIdentifier")]
        NSObject LoadedImageIdentifier { get; }

        // @property (readonly, nonatomic) id displayedImageIdentifier;
        [Export ("displayedImageIdentifier")]
        NSObject DisplayedImageIdentifier { get; }

        // -(void)reloadImageIdentifierSources;
        [Export ("reloadImageIdentifierSources")]
        void ReloadImageIdentifierSources ();
    }

    // @protocol ASMultiplexImageNodeDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASMultiplexImageNodeDelegate {

        // @optional -(void)multiplexImageNode:(ASMultiplexImageNode *)imageNode didStartDownloadOfImageWithIdentifier:(id)imageIdentifier;
        [Export ("multiplexImageNode:didStartDownloadOfImageWithIdentifier:")]
        void DidStartDownloadOfImageWithIdentifier (ASMultiplexImageNode imageNode, NSObject imageIdentifier);

        // @optional -(void)multiplexImageNode:(ASMultiplexImageNode *)imageNode didUpdateDownloadProgress:(CGFloat)downloadProgress forImageWithIdentifier:(id)imageIdentifier;
        [Export ("multiplexImageNode:didUpdateDownloadProgress:forImageWithIdentifier:")]
        void DidUpdateDownloadProgress (ASMultiplexImageNode imageNode, nfloat downloadProgress, NSObject imageIdentifier);

        // @optional -(void)multiplexImageNode:(ASMultiplexImageNode *)imageNode didFinishDownloadingImageWithIdentifier:(id)imageIdentifier error:(NSError *)error;
        [Export ("multiplexImageNode:didFinishDownloadingImageWithIdentifier:error:")]
        void DidFinishDownloadingImageWithIdentifier (ASMultiplexImageNode imageNode, NSObject imageIdentifier, NSError error);

        // @optional -(void)multiplexImageNode:(ASMultiplexImageNode *)imageNode didUpdateImage:(UIImage *)image withIdentifier:(id)imageIdentifier fromImage:(UIImage *)previousImage withIdentifier:(id)previousImageIdentifier;
        [Export ("multiplexImageNode:didUpdateImage:withIdentifier:fromImage:withIdentifier:")]
        void DidUpdateImage (ASMultiplexImageNode imageNode, UIImage image, NSObject imageIdentifier, UIImage previousImage, NSObject previousImageIdentifier);

        // @optional -(void)multiplexImageNode:(ASMultiplexImageNode *)imageNode didDisplayUpdatedImage:(UIImage *)image withIdentifier:(id)imageIdentifier;
        [Export ("multiplexImageNode:didDisplayUpdatedImage:withIdentifier:")]
        void DidDisplayUpdatedImage (ASMultiplexImageNode imageNode, UIImage image, NSObject imageIdentifier);

        // @optional -(void)multiplexImageNodeDidFinishDisplay:(ASMultiplexImageNode *)imageNode;
        [Export ("multiplexImageNodeDidFinishDisplay:")]
        void MultiplexImageNodeDidFinishDisplay (ASMultiplexImageNode imageNode);
    }

    // @protocol ASMultiplexImageNodeDataSource <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASMultiplexImageNodeDataSource {

        // @optional -(UIImage *)multiplexImageNode:(ASMultiplexImageNode *)imageNode imageForImageIdentifier:(id)imageIdentifier;
        [Export ("multiplexImageNode:imageForImageIdentifier:")]
        UIImage ImageForImageIdentifier (ASMultiplexImageNode imageNode, NSObject imageIdentifier);

        // @optional -(NSURL *)multiplexImageNode:(ASMultiplexImageNode *)imageNode URLForImageIdentifier:(id)imageIdentifier;
        [Export ("multiplexImageNode:URLForImageIdentifier:")]
        NSUrl URLForImageIdentifier (ASMultiplexImageNode imageNode, NSObject imageIdentifier);
    }

    // @interface ASNetworkImageNode : ASImageNode
    [BaseType (typeof (ASImageNode))]
    interface ASNetworkImageNode {

        // -(instancetype)initWithCache:(id<ASImageCacheProtocol>)cache downloader:(id<ASImageDownloaderProtocol>)downloader;
        [Export ("initWithCache:downloader:")]
        IntPtr Constructor (ASImageCacheProtocol cache, ASImageDownloaderProtocol downloader);

        // @property (readwrite, atomic, weak) id<ASNetworkImageNodeDelegate> delegate;
        [Export ("delegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakDelegate { get; set; }

        // @property (readwrite, atomic, weak) id<ASNetworkImageNodeDelegate> delegate;
        [Wrap ("WeakDelegate")]
        ASNetworkImageNodeDelegate Delegate { get; set; }

        // @property (readwrite, atomic, strong) UIImage * defaultImage;
        [Export ("defaultImage", ArgumentSemantic.Retain)]
        UIImage DefaultImage { get; set; }

        // @property (readwrite, atomic, strong) NSURL * URL;
        [Export ("URL", ArgumentSemantic.Retain)]
        NSUrl URL { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL shouldCacheImage;
        [Export ("shouldCacheImage", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldCacheImage { get; set; }

        // -(void)setURL:(NSURL *)URL resetToDefault:(BOOL)reset;
        [Export ("setURL:resetToDefault:")]
        void SetURL (NSUrl URL, bool reset);
    }

    // @protocol ASNetworkImageNodeDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASNetworkImageNodeDelegate {

        // @required -(void)imageNode:(ASNetworkImageNode *)imageNode didLoadImage:(UIImage *)image;
        [Export ("imageNode:didLoadImage:")]
        [Abstract]
        void DidLoadImage (ASNetworkImageNode imageNode, UIImage image);

        // @optional -(void)imageNodeDidFinishDecoding:(ASNetworkImageNode *)imageNode;
        [Export ("imageNodeDidFinishDecoding:")]
        void ImageNodeDidFinishDecoding (ASNetworkImageNode imageNode);
    }

    // @interface ASCellNode : ASDisplayNode
    [BaseType (typeof (ASDisplayNode))]
    interface ASCellNode {

        // @property (nonatomic) UITableViewCellSelectionStyle selectionStyle;
        [Export ("selectionStyle")]
        UITableViewCellSelectionStyle SelectionStyle { get; set; }
    }

    // @interface ASTextCellNode : ASCellNode
    [BaseType (typeof (ASCellNode))]
    interface ASTextCellNode {

        // @property (copy, nonatomic) NSString * text;
        [Export ("text")]
        string Text { get; set; }
    }

    // @protocol ASDataControllerSource <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASDataControllerSource {

        // @required -(ASCellNode *)dataController:(ASDataController *)dataController nodeAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("dataController:nodeAtIndexPath:")]
        [Abstract]
        ASCellNode NodeAtIndexPath (ASDataController dataController, NSIndexPath indexPath);

        // @required -(CGSize)dataController:(ASDataController *)dataController constrainedSizeForNodeAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("dataController:constrainedSizeForNodeAtIndexPath:")]
        [Abstract]
        CGSize SizeForNodeAtIndexPath (ASDataController dataController, NSIndexPath indexPath);

        // @required -(NSUInteger)dataController:(ASDataController *)dataControllre rowsInSection:(NSUInteger)section;
        [Export ("dataController:rowsInSection:")]
        [Abstract]
        nuint DataController (ASDataController dataControllre, nuint section);

        // @required -(NSUInteger)dataControllerNumberOfSections:(ASDataController *)dataController;
        [Export ("dataControllerNumberOfSections:")]
        [Abstract]
        nuint DataControllerNumberOfSections (ASDataController dataController);
    }

    // @protocol ASDataControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASDataControllerDelegate {

        // @optional -(void)dataControllerBeginUpdates:(ASDataController *)dataController;
        [Export ("dataControllerBeginUpdates:")]
        void DataControllerBeginUpdates (ASDataController dataController);

        // @optional -(void)dataControllerEndUpdates:(ASDataController *)dataController;
        [Export ("dataControllerEndUpdates:")]
        void DataControllerEndUpdates (ASDataController dataController);

        // @optional -(void)dataController:(ASDataController *)dataController willInsertNodes:(NSArray *)nodes atIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:willInsertNodes:atIndexPaths:withAnimationOption:")]
        void WillInsertNodes (ASDataController dataController, NSObject [] nodes, NSObject [] indexPaths, nuint animationOption);

        // @optional -(void)dataController:(ASDataController *)dataController didInsertNodes:(NSArray *)nodes atIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:didInsertNodes:atIndexPaths:withAnimationOption:")]
        void DidInsertNodes (ASDataController dataController, NSObject [] nodes, NSObject [] indexPaths, nuint animationOption);

        // @optional -(void)dataController:(ASDataController *)dataController willDeleteNodesAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:willDeleteNodesAtIndexPaths:withAnimationOption:")]
        void WillDeleteNodesAtIndexPaths (ASDataController dataController, NSObject [] indexPaths, nuint animationOption);

        // @optional -(void)dataController:(ASDataController *)dataController didDeleteNodesAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:didDeleteNodesAtIndexPaths:withAnimationOption:")]
        void DidDeleteNodesAtIndexPaths (ASDataController dataController, NSObject [] indexPaths, nuint animationOption);

        // @optional -(void)dataController:(ASDataController *)dataController willInsertSections:(NSArray *)sections atIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:willInsertSections:atIndexSet:withAnimationOption:")]
        void WillInsertSections (ASDataController dataController, NSObject [] sections, NSIndexSet indexSet, nuint animationOption);

        // @optional -(void)dataController:(ASDataController *)dataController didInsertSections:(NSArray *)sections atIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:didInsertSections:atIndexSet:withAnimationOption:")]
        void DidInsertSections (ASDataController dataController, NSObject [] sections, NSIndexSet indexSet, nuint animationOption);

        // @optional -(void)dataController:(ASDataController *)dataController willDeleteSectionsAtIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:willDeleteSectionsAtIndexSet:withAnimationOption:")]
        void WillDeleteSectionsAtIndexSet (ASDataController dataController, NSIndexSet indexSet, nuint animationOption);

        // @optional -(void)dataController:(ASDataController *)dataController didDeleteSectionsAtIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("dataController:didDeleteSectionsAtIndexSet:withAnimationOption:")]
        void DidDeleteSectionsAtIndexSet (ASDataController dataController, NSIndexSet indexSet, nuint animationOption);
    }

    // @interface ASDataController : ASDealloc2MainObject
    [BaseType (typeof (ASDealloc2MainObject))]
    interface ASDataController {

        // @property (nonatomic, weak) id<ASDataControllerSource> dataSource;
        [Export ("dataSource", ArgumentSemantic.Weak)]
        ASDataControllerSource DataSource { get; set; }

        // @property (nonatomic, weak) id<ASDataControllerDelegate> delegate;
        [Export ("delegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<ASDataControllerDelegate> delegate;
        [Wrap ("WeakDelegate")]
        ASDataControllerDelegate Delegate { get; set; }

        // -(void)initialDataLoadingWithAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("initialDataLoadingWithAnimationOption:")]
        void InitialDataLoadingWithAnimationOption (nuint animationOption);

        // -(void)beginUpdates;
        [Export ("beginUpdates")]
        void BeginUpdates ();

        // -(void)endUpdates;
        [Export ("endUpdates")]
        void EndUpdates ();

        // -(void)insertSections:(NSIndexSet *)sections withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("insertSections:withAnimationOption:")]
        void InsertSections (NSIndexSet sections, nuint animationOption);

        // -(void)deleteSections:(NSIndexSet *)sections withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("deleteSections:withAnimationOption:")]
        void DeleteSections (NSIndexSet sections, nuint animationOption);

        // -(void)reloadSections:(NSIndexSet *)sections withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("reloadSections:withAnimationOption:")]
        void ReloadSections (NSIndexSet sections, nuint animationOption);

        // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("moveSection:toSection:withAnimationOption:")]
        void MoveSection (nint section, nint newSection, nuint animationOption);

        // -(void)insertRowsAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("insertRowsAtIndexPaths:withAnimationOption:")]
        void InsertRowsAtIndexPaths (NSObject [] indexPaths, nuint animationOption);

        // -(void)deleteRowsAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("deleteRowsAtIndexPaths:withAnimationOption:")]
        void DeleteRowsAtIndexPaths (NSObject [] indexPaths, nuint animationOption);

        // -(void)reloadRowsAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("reloadRowsAtIndexPaths:withAnimationOption:")]
        void ReloadRowsAtIndexPaths (NSObject [] indexPaths, nuint animationOption);

        // -(void)moveRowAtIndexPath:(NSIndexPath *)indexPath toIndexPath:(NSIndexPath *)newIndexPath withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("moveRowAtIndexPath:toIndexPath:withAnimationOption:")]
        void MoveRowAtIndexPath (NSIndexPath indexPath, NSIndexPath newIndexPath, nuint animationOption);

        // -(void)reloadDataWithAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("reloadDataWithAnimationOption:")]
        void ReloadDataWithAnimationOption (nuint animationOption);

        // -(NSUInteger)numberOfSections;
        [Export ("numberOfSections")]
        nuint NumberOfSections ();

        // -(NSUInteger)numberOfRowsInSection:(NSUInteger)section;
        [Export ("numberOfRowsInSection:")]
        nuint NumberOfRowsInSection (nuint section);

        // -(ASCellNode *)nodeAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("nodeAtIndexPath:")]
        ASCellNode NodeAtIndexPath (NSIndexPath indexPath);

        // -(NSArray *)nodesAtIndexPaths:(NSArray *)indexPaths;
        [Export ("nodesAtIndexPaths:")]
        NSObject [] NodesAtIndexPaths (NSObject [] indexPaths);
    }

    // @protocol ASLayoutController <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASLayoutController {

        // @property (assign, nonatomic) ASRangeTuningParameters tuningParameters;
        //[Export ("tuningParameters", ArgumentSemantic.UnsafeUnretained)]
        //ASRangeTuningParameters TuningParameters { get; set; }

        // @required -(void)insertNodesAtIndexPaths:(NSArray *)indexPaths withSizes:(NSArray *)nodeSizes;
        [Export ("insertNodesAtIndexPaths:withSizes:")]
        [Abstract]
        void InsertNodesAtIndexPaths (NSObject [] indexPaths, NSObject [] nodeSizes);

        // @required -(void)deleteNodesAtIndexPaths:(NSArray *)indexPaths;
        [Export ("deleteNodesAtIndexPaths:")]
        [Abstract]
        void DeleteNodesAtIndexPaths (NSObject [] indexPaths);

        // @required -(void)insertSections:(NSArray *)sections atIndexSet:(NSIndexSet *)indexSet;
        [Export ("insertSections:atIndexSet:")]
        [Abstract]
        void InsertSections (NSObject [] sections, NSIndexSet indexSet);

        // @required -(void)deleteSectionsAtIndexSet:(NSIndexSet *)indexSet;
        [Export ("deleteSectionsAtIndexSet:")]
        [Abstract]
        void DeleteSectionsAtIndexSet (NSIndexSet indexSet);

        // @required -(void)setVisibleNodeIndexPaths:(NSArray *)indexPaths;
        [Export ("setVisibleNodeIndexPaths:")]
        [Abstract]
        void SetVisibleNodeIndexPaths (NSObject [] indexPaths);

        // @required -(BOOL)shouldUpdateWorkingRangesForVisibleIndexPath:(NSArray *)indexPath viewportSize:(CGSize)viewportSize;
        [Export ("shouldUpdateWorkingRangesForVisibleIndexPath:viewportSize:")]
        [Abstract]
        bool ShouldUpdateWorkingRangesForVisibleIndexPath (NSObject [] indexPath, CGSize viewportSize);

        // @required -(NSSet *)workingRangeIndexPathsForScrolling:(enum ASScrollDirection)scrollDirection viewportSize:(CGSize)viewportSize;
        [Export ("workingRangeIndexPathsForScrolling:viewportSize:")]
        [Abstract]
        NSSet WorkingRangeIndexPathsForScrolling (ASScrollDirection scrollDirection, CGSize viewportSize);
    }

    // @interface ASFlowLayoutController : NSObject <ASLayoutController>
    [BaseType (typeof (NSObject))]
    interface ASFlowLayoutController : ASLayoutController {

        // -(instancetype)initWithScrollOption:(ASFlowLayoutDirection)layoutDirection;
        [Export ("initWithScrollOption:")]
        IntPtr Constructor (ASFlowLayoutDirection layoutDirection);

        // @property (assign, nonatomic) ASRangeTuningParameters tuningParameters;
        //[Export ("tuningParameters", ArgumentSemantic.UnsafeUnretained)]
        //ASRangeTuningParameters TuningParameters { get; set; }

        // @property (readonly, assign, nonatomic) ASFlowLayoutDirection layoutDirection;
        [Export ("layoutDirection", ArgumentSemantic.UnsafeUnretained)]
        ASFlowLayoutDirection LayoutDirection { get; }
    }

    // @interface ASRangeController : ASDealloc2MainObject <ASDataControllerDelegate>
    [BaseType (typeof (ASDealloc2MainObject))]
    interface ASRangeController : ASDataControllerDelegate {

        // @property (nonatomic, weak) id<ASRangeControllerDelegate> delegate;
        [Export ("delegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<ASRangeControllerDelegate> delegate;
        [Wrap ("WeakDelegate")]
        ASRangeControllerDelegate Delegate { get; set; }

        // @property (nonatomic, strong) id<ASLayoutController> layoutController;
        [Export ("layoutController", ArgumentSemantic.Retain)]
        ASLayoutController LayoutController { get; set; }

        // -(void)visibleNodeIndexPathsDidChangeWithScrollDirection:(enum ASScrollDirection)scrollDirection;
        [Export ("visibleNodeIndexPathsDidChangeWithScrollDirection:")]
        void VisibleNodeIndexPathsDidChangeWithScrollDirection (ASScrollDirection scrollDirection);

        // -(void)configureContentView:(UIView *)contentView forCellNode:(ASCellNode *)node;
        [Export ("configureContentView:forCellNode:")]
        void ConfigureContentView (UIView contentView, ASCellNode node);
    }

    // @protocol ASRangeControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASRangeControllerDelegate {

        // @required -(NSArray *)rangeControllerVisibleNodeIndexPaths:(ASRangeController *)rangeController;
        [Export ("rangeControllerVisibleNodeIndexPaths:")]
        [Abstract]
        NSObject [] RangeControllerVisibleNodeIndexPaths (ASRangeController rangeController);

        // @required -(CGSize)rangeControllerViewportSize:(ASRangeController *)rangeController;
        [Export ("rangeControllerViewportSize:")]
        [Abstract]
        CGSize RangeControllerViewportSize (ASRangeController rangeController);

        // @required -(void)rangeControllerBeginUpdates:(ASRangeController *)rangeController;
        [Export ("rangeControllerBeginUpdates:")]
        [Abstract]
        void RangeControllerBeginUpdates (ASRangeController rangeController);

        // @required -(void)rangeControllerEndUpdates:(ASRangeController *)rangeController;
        [Export ("rangeControllerEndUpdates:")]
        [Abstract]
        void RangeControllerEndUpdates (ASRangeController rangeController);

        // @required -(NSArray *)rangeController:(ASRangeController *)rangeController nodesAtIndexPaths:(NSArray *)indexPaths;
        [Export ("rangeController:nodesAtIndexPaths:")]
        [Abstract]
        NSObject [] NodesAtIndexPaths (ASRangeController rangeController, NSObject [] indexPaths);

        // @required -(void)rangeController:(ASRangeController *)rangeController didInsertNodesAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:didInsertNodesAtIndexPaths:withAnimationOption:")]
        [Abstract]
        void DidInsertNodesAtIndexPaths (ASRangeController rangeController, NSObject [] indexPaths, nuint animationOption);

        // @required -(void)rangeController:(ASRangeController *)rangeController didDeleteNodesAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:didDeleteNodesAtIndexPaths:withAnimationOption:")]
        [Abstract]
        void DidDeleteNodesAtIndexPaths (ASRangeController rangeController, NSObject [] indexPaths, nuint animationOption);

        // @required -(void)rangeController:(ASRangeController *)rangeController didInsertSectionsAtIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:didInsertSectionsAtIndexSet:withAnimationOption:")]
        [Abstract]
        void DidInsertSectionsAtIndexSet (ASRangeController rangeController, NSIndexSet indexSet, nuint animationOption);

        // @required -(void)rangeController:(ASRangeController *)rangeController didDeleteSectionsAtIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:didDeleteSectionsAtIndexSet:withAnimationOption:")]
        [Abstract]
        void DidDeleteSectionsAtIndexSet (ASRangeController rangeController, NSIndexSet indexSet, nuint animationOption);

        // @optional -(void)rangeController:(ASRangeController *)rangeController willInsertNodesAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:willInsertNodesAtIndexPaths:withAnimationOption:")]
        void WillInsertNodesAtIndexPaths (ASRangeController rangeController, NSObject [] indexPaths, nuint animationOption);

        // @optional -(void)rangeController:(ASRangeController *)rangeController willDeleteNodesAtIndexPaths:(NSArray *)indexPaths withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:willDeleteNodesAtIndexPaths:withAnimationOption:")]
        void WillDeleteNodesAtIndexPaths (ASRangeController rangeController, NSObject [] indexPaths, nuint animationOption);

        // @optional -(void)rangeController:(ASRangeController *)rangeController willInsertSectionsAtIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:willInsertSectionsAtIndexSet:withAnimationOption:")]
        void WillInsertSectionsAtIndexSet (ASRangeController rangeController, NSIndexSet indexSet, nuint animationOption);

        // @optional -(void)rangeController:(ASRangeController *)rangeController willDeleteSectionsAtIndexSet:(NSIndexSet *)indexSet withAnimationOption:(ASDataControllerAnimationOptions)animationOption;
        [Export ("rangeController:willDeleteSectionsAtIndexSet:withAnimationOption:")]
        void WillDeleteSectionsAtIndexSet (ASRangeController rangeController, NSIndexSet indexSet, nuint animationOption);
    }

    // @protocol ASCommonTableViewDataSource <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASCommonTableViewDataSource {

        // @required -(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section;
        [Export ("tableView:numberOfRowsInSection:")]
        [Abstract]
        nint NumberOfRowsInSection (UITableView tableView, nint section);

        // @optional -(NSInteger)numberOfSectionsInTableView:(UITableView *)tableView;
        [Export ("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView (UITableView tableView);

        // @optional -(NSString *)tableView:(UITableView *)tableView titleForHeaderInSection:(NSInteger)section;
        [Export ("tableView:titleForHeaderInSection:")]
        string TitleForHeaderInSection (UITableView tableView, nint section);

        // @optional -(NSString *)tableView:(UITableView *)tableView titleForFooterInSection:(NSInteger)section;
        [Export ("tableView:titleForFooterInSection:")]
        string TitleForFooterInSection (UITableView tableView, nint section);

        // @optional -(BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:canEditRowAtIndexPath:")]
        bool CanEditRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView *)tableView canMoveRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:canMoveRowAtIndexPath:")]
        bool CanMoveRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSArray *)sectionIndexTitlesForTableView:(UITableView *)tableView;
        [Export ("sectionIndexTitlesForTableView:")]
        NSObject [] SectionIndexTitlesForTableView (UITableView tableView);

        // @optional -(NSInteger)tableView:(UITableView *)tableView sectionForSectionIndexTitle:(NSString *)title atIndex:(NSInteger)index;
        [Export ("tableView:sectionForSectionIndexTitle:atIndex:")]
        nint SectionForSectionIndexTitle (UITableView tableView, string title, nint index);

        // @optional -(void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:commitEditingStyle:forRowAtIndexPath:")]
        void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView moveRowAtIndexPath:(NSIndexPath *)sourceIndexPath toIndexPath:(NSIndexPath *)destinationIndexPath;
        [Export ("tableView:moveRowAtIndexPath:toIndexPath:")]
        void MoveRowAtIndexPath (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath);
    }

    // @protocol ASCommonTableViewDelegate <NSObject, UIScrollViewDelegate>
    [Protocol, Model]
    [BaseType (typeof (UIScrollViewDelegate))]
    interface ASCommonTableViewDelegate {

        // @optional -(void)tableView:(UITableView *)tableView willDisplayHeaderView:(UIView *)view forSection:(NSInteger)section;
        [Export ("tableView:willDisplayHeaderView:forSection:")]
        void WillDisplayHeaderView (UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView *)tableView willDisplayFooterView:(UIView *)view forSection:(NSInteger)section;
        [Export ("tableView:willDisplayFooterView:forSection:")]
        void WillDisplayFooterView (UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView *)tableView didEndDisplayingHeaderView:(UIView *)view forSection:(NSInteger)section;
        [Export ("tableView:didEndDisplayingHeaderView:forSection:")]
        void DidEndDisplayingHeaderView (UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView *)tableView didEndDisplayingFooterView:(UIView *)view forSection:(NSInteger)section;
        [Export ("tableView:didEndDisplayingFooterView:forSection:")]
        void DidEndDisplayingFooterView (UITableView tableView, UIView view, nint section);

        // @optional -(CGFloat)tableView:(UITableView *)tableView heightForHeaderInSection:(NSInteger)section;
        [Export ("tableView:heightForHeaderInSection:")]
        nfloat HeightForHeaderInSection (UITableView tableView, nint section);

        // @optional -(CGFloat)tableView:(UITableView *)tableView heightForFooterInSection:(NSInteger)section;
        [Export ("tableView:heightForFooterInSection:")]
        nfloat HeightForFooterInSection (UITableView tableView, nint section);

        // @optional -(UIView *)tableView:(UITableView *)tableView viewForHeaderInSection:(NSInteger)section;
        [Export ("tableView:viewForHeaderInSection:")]
        UIView ViewForHeaderInSection (UITableView tableView, nint section);

        // @optional -(UIView *)tableView:(UITableView *)tableView viewForFooterInSection:(NSInteger)section;
        [Export ("tableView:viewForFooterInSection:")]
        UIView ViewForFooterInSection (UITableView tableView, nint section);

        // @optional -(void)tableView:(UITableView *)tableView accessoryButtonTappedForRowWithIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:accessoryButtonTappedForRowWithIndexPath:")]
        void AccessoryButtonTappedForRowWithIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView *)tableView shouldHighlightRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:shouldHighlightRowAtIndexPath:")]
        bool ShouldHighlightRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView didHighlightRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:didHighlightRowAtIndexPath:")]
        void DidHighlightRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView didUnhighlightRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:didUnhighlightRowAtIndexPath:")]
        void DidUnhighlightRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath *)tableView:(UITableView *)tableView willSelectRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:willSelectRowAtIndexPath:")]
        NSIndexPath WillSelectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath *)tableView:(UITableView *)tableView willDeselectRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:willDeselectRowAtIndexPath:")]
        NSIndexPath WillDeselectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:didSelectRowAtIndexPath:")]
        void DidSelectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView didDeselectRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:didDeselectRowAtIndexPath:")]
        void DidDeselectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(UITableViewCellEditingStyle)tableView:(UITableView *)tableView editingStyleForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:editingStyleForRowAtIndexPath:")]
        UITableViewCellEditingStyle EditingStyleForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSString *)tableView:(UITableView *)tableView titleForDeleteConfirmationButtonForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:")]
        string TitleForDeleteConfirmationButtonForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSArray *)tableView:(UITableView *)tableView editActionsForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:editActionsForRowAtIndexPath:")]
        NSObject [] EditActionsForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView *)tableView shouldIndentWhileEditingRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:shouldIndentWhileEditingRowAtIndexPath:")]
        bool ShouldIndentWhileEditingRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView willBeginEditingRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:willBeginEditingRowAtIndexPath:")]
        void WillBeginEditingRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView didEndEditingRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:didEndEditingRowAtIndexPath:")]
        void DidEndEditingRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath *)tableView:(UITableView *)tableView targetIndexPathForMoveFromRowAtIndexPath:(NSIndexPath *)sourceIndexPath toProposedIndexPath:(NSIndexPath *)proposedDestinationIndexPath;
        [Export ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:")]
        NSIndexPath TargetIndexPathForMoveFromRowAtIndexPath (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedDestinationIndexPath);

        // @optional -(NSInteger)tableView:(UITableView *)tableView indentationLevelForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:indentationLevelForRowAtIndexPath:")]
        nint IndentationLevelForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView *)tableView shouldShowMenuForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:shouldShowMenuForRowAtIndexPath:")]
        bool ShouldShowMenuForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView *)tableView canPerformAction:(SEL)action forRowAtIndexPath:(NSIndexPath *)indexPath withSender:(id)sender;
        [Export ("tableView:canPerformAction:forRowAtIndexPath:withSender:")]
        bool CanPerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender);

        // @optional -(void)tableView:(UITableView *)tableView performAction:(SEL)action forRowAtIndexPath:(NSIndexPath *)indexPath withSender:(id)sender;
        [Export ("tableView:performAction:forRowAtIndexPath:withSender:")]
        void PerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender);
    }
        

    // @interface ASTableView : UITableView
    [BaseType (typeof (UITableView))]
    interface ASTableView {

        // @property (nonatomic, weak) id<ASTableViewDataSource> asyncDataSource;
        [Export ("asyncDataSource", ArgumentSemantic.Weak)]
        ASTableViewDataSource AsyncDataSource { get; set; }

        // @property (nonatomic, weak) id<ASTableViewDelegate> asyncDelegate;
        [Export ("asyncDelegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakAsyncDelegate { get; set; }

        // @property (nonatomic, weak) id<ASTableViewDelegate> asyncDelegate;
        [Wrap ("WeakAsyncDelegate")]
        ASTableViewDelegate AsyncDelegate { get; set; }

        // @property (assign, nonatomic) ASRangeTuningParameters rangeTuningParameters;
        //[Export ("rangeTuningParameters", ArgumentSemantic.UnsafeUnretained)]
        //ASRangeTuningParameters RangeTuningParameters { get; set; }

        // -(void)reloadData;
        [Export ("reloadData")]
        void ReloadData ();

        // -(void)beginUpdates;
        [Export ("beginUpdates")]
        void BeginUpdates ();

        // -(void)endUpdates;
        [Export ("endUpdates")]
        void EndUpdates ();

        // -(void)insertSections:(NSIndexSet *)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("insertSections:withRowAnimation:")]
        void InsertSections (NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)deleteSections:(NSIndexSet *)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("deleteSections:withRowAnimation:")]
        void DeleteSections (NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)reloadSections:(NSIndexSet *)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("reloadSections:withRowAnimation:")]
        void ReloadSections (NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection;
        [Export ("moveSection:toSection:")]
        void MoveSection (nint section, nint newSection);

        // -(void)insertRowsAtIndexPaths:(NSArray *)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("insertRowsAtIndexPaths:withRowAnimation:")]
        void InsertRowsAtIndexPaths (NSObject [] indexPaths, UITableViewRowAnimation animation);

        // -(void)deleteRowsAtIndexPaths:(NSArray *)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("deleteRowsAtIndexPaths:withRowAnimation:")]
        void DeleteRowsAtIndexPaths (NSObject [] indexPaths, UITableViewRowAnimation animation);

        // -(void)reloadRowsAtIndexPaths:(NSArray *)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("reloadRowsAtIndexPaths:withRowAnimation:")]
        void ReloadRowsAtIndexPaths (NSObject [] indexPaths, UITableViewRowAnimation animation);

        // -(void)moveRowAtIndexPath:(NSIndexPath *)indexPath toIndexPath:(NSIndexPath *)newIndexPath;
        [Export ("moveRowAtIndexPath:toIndexPath:")]
        void MoveRowAtIndexPath (NSIndexPath indexPath, NSIndexPath newIndexPath);

        // -(ASCellNode *)nodeForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("nodeForRowAtIndexPath:")]
        ASCellNode NodeForRowAtIndexPath (NSIndexPath indexPath);

        // -(NSArray *)visibleNodes;
        [Export ("visibleNodes")]
        NSObject [] VisibleNodes ();
    }

    // @protocol ASTableViewDataSource <ASCommonTableViewDataSource, NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASTableViewDataSource : ASCommonTableViewDataSource {

        // @required -(ASCellNode *)tableView:(ASTableView *)tableView nodeForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:nodeForRowAtIndexPath:")]
        [Abstract]
        ASCellNode NodeForRowAtIndexPath (ASTableView tableView, NSIndexPath indexPath);
    }

    // @protocol ASTableViewDelegate <ASCommonTableViewDelegate, NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASTableViewDelegate : ASCommonTableViewDelegate {

        // @optional -(void)tableView:(UITableView *)tableView willDisplayNodeForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:willDisplayNodeForRowAtIndexPath:")]
        void WillDisplayNodeForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView *)tableView didEndDisplayingNodeForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("tableView:didEndDisplayingNodeForRowAtIndexPath:")]
        void DidEndDisplayingNodeForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);
    }

    // @protocol ASCommonCollectionViewDataSource <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASCommonCollectionViewDataSource {

        // @required -(NSInteger)collectionView:(UICollectionView *)collectionView numberOfItemsInSection:(NSInteger)section;
        [Export ("collectionView:numberOfItemsInSection:")]
        [Abstract]
        nint NumberOfItemsInSection (UICollectionView collectionView, nint section);

        // @optional -(NSInteger)numberOfSectionsInCollectionView:(UICollectionView *)collectionView;
        [Export ("numberOfSectionsInCollectionView:")]
        nint NumberOfSectionsInCollectionView (UICollectionView collectionView);

        // @optional -(UICollectionReusableView *)collectionView:(UICollectionView *)collectionView viewForSupplementaryElementOfKind:(NSString *)kind atIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
        UICollectionReusableView ViewForSupplementaryElementOfKind (UICollectionView collectionView, string kind, NSIndexPath indexPath);
    }

    // @protocol ASCommonCollectionViewDelegate <NSObject, UIScrollViewDelegate>
    [Protocol, Model]
    [BaseType (typeof (UIScrollViewDelegate))]
    interface ASCommonCollectionViewDelegate {

        // @optional -(UICollectionViewTransitionLayout *)collectionView:(UICollectionView *)collectionView transitionLayoutForOldLayout:(UICollectionViewLayout *)fromLayout newLayout:(UICollectionViewLayout *)toLayout;
        [Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
        UICollectionViewTransitionLayout TransitionLayoutForOldLayout (UICollectionView collectionView, UICollectionViewLayout fromLayout, UICollectionViewLayout toLayout);

        // @optional -(void)collectionView:(UICollectionView *)collectionView willDisplaySupplementaryView:(UICollectionReusableView *)view forElementKind:(NSString *)elementKind atIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
        void WillDisplaySupplementaryView (UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView *)collectionView didEndDisplayingSupplementaryView:(UICollectionReusableView *)view forElementOfKind:(NSString *)elementKind atIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
        void DidEndDisplayingSupplementaryView (UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView *)collectionView shouldHighlightItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:shouldHighlightItemAtIndexPath:")]
        bool ShouldHighlightItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView *)collectionView didHighlightItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:didHighlightItemAtIndexPath:")]
        void DidHighlightItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView *)collectionView didUnhighlightItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:didUnhighlightItemAtIndexPath:")]
        void DidUnhighlightItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView *)collectionView shouldSelectItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:shouldSelectItemAtIndexPath:")]
        bool ShouldSelectItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView *)collectionView didSelectItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:didSelectItemAtIndexPath:")]
        void DidSelectItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView *)collectionView shouldDeselectItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:shouldDeselectItemAtIndexPath:")]
        bool ShouldDeselectItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView *)collectionView didDeselectItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:didDeselectItemAtIndexPath:")]
        void DidDeselectItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView *)collectionView shouldShowMenuForItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:shouldShowMenuForItemAtIndexPath:")]
        bool ShouldShowMenuForItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView *)collectionView canPerformAction:(SEL)action forItemAtIndexPath:(NSIndexPath *)indexPath withSender:(id)sender;
        [Export ("collectionView:canPerformAction:forItemAtIndexPath:withSender:")]
        bool CanPerformAction (UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender);

        // @optional -(void)collectionView:(UICollectionView *)collectionView performAction:(SEL)action forItemAtIndexPath:(NSIndexPath *)indexPath withSender:(id)sender;
        [Export ("collectionView:performAction:forItemAtIndexPath:withSender:")]
        void PerformAction (UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender);
    }

    // @interface ASCollectionView : UICollectionView
    [BaseType (typeof (UICollectionView))]
    interface ASCollectionView {

        // @property (nonatomic, weak) id<ASCollectionViewDataSource> asyncDataSource;
        [Export ("asyncDataSource", ArgumentSemantic.Weak)]
        ASCollectionViewDataSource AsyncDataSource { get; set; }

        // @property (nonatomic, weak) id<ASCollectionViewDelegate> asyncDelegate;
        [Export ("asyncDelegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakAsyncDelegate { get; set; }

        // @property (nonatomic, weak) id<ASCollectionViewDelegate> asyncDelegate;
        [Wrap ("WeakAsyncDelegate")]
        ASCollectionViewDelegate AsyncDelegate { get; set; }

        // @property (assign, nonatomic) ASRangeTuningParameters rangeTuningParameters;
        //[Export ("rangeTuningParameters", ArgumentSemantic.UnsafeUnretained)]
        //ASRangeTuningParameters RangeTuningParameters { get; set; }

        // -(void)reloadData;
        [Export ("reloadData")]
        void ReloadData ();

        // -(void)insertSections:(NSIndexSet *)sections;
        [Export ("insertSections:")]
        void InsertSections (NSIndexSet sections);

        // -(void)deleteSections:(NSIndexSet *)sections;
        [Export ("deleteSections:")]
        void DeleteSections (NSIndexSet sections);

        // -(void)reloadSections:(NSIndexSet *)sections;
        [Export ("reloadSections:")]
        void ReloadSections (NSIndexSet sections);

        // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection;
        [Export ("moveSection:toSection:")]
        void MoveSection (nint section, nint newSection);

        // -(void)insertItemsAtIndexPaths:(NSArray *)indexPaths;
        [Export ("insertItemsAtIndexPaths:")]
        void InsertItemsAtIndexPaths (NSObject [] indexPaths);

        // -(void)deleteItemsAtIndexPaths:(NSArray *)indexPaths;
        [Export ("deleteItemsAtIndexPaths:")]
        void DeleteItemsAtIndexPaths (NSObject [] indexPaths);

        // -(void)reloadItemsAtIndexPaths:(NSArray *)indexPaths;
        [Export ("reloadItemsAtIndexPaths:")]
        void ReloadItemsAtIndexPaths (NSObject [] indexPaths);

        // -(void)moveItemAtIndexPath:(NSIndexPath *)indexPath toIndexPath:(NSIndexPath *)newIndexPath;
        [Export ("moveItemAtIndexPath:toIndexPath:")]
        void MoveItemAtIndexPath (NSIndexPath indexPath, NSIndexPath newIndexPath);

        // -(ASCellNode *)nodeForItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("nodeForItemAtIndexPath:")]
        ASCellNode NodeForItemAtIndexPath (NSIndexPath indexPath);

        // -(NSArray *)visibleNodes;
        [Export ("visibleNodes")]
        NSObject [] VisibleNodes ();

        // -(CGSize)calculatedSizeForNodeAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("calculatedSizeForNodeAtIndexPath:")]
        CGSize CalculatedSizeForNodeAtIndexPath (NSIndexPath indexPath);
    }

    // @protocol ASCollectionViewDataSource <ASCommonCollectionViewDataSource, NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASCollectionViewDataSource : ASCommonCollectionViewDataSource {

        // @required -(ASCellNode *)collectionView:(ASCollectionView *)collectionView nodeForItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:nodeForItemAtIndexPath:")]
        [Abstract]
        ASCellNode NodeForItemAtIndexPath (ASCollectionView collectionView, NSIndexPath indexPath);
    }

    // @protocol ASCollectionViewDelegate <ASCommonCollectionViewDelegate, NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ASCollectionViewDelegate : ASCommonCollectionViewDelegate {

        // @optional -(void)collectionView:(UICollectionView *)collectionView willDisplayNodeForItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:willDisplayNodeForItemAtIndexPath:")]
        void WillDisplayNodeForItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView *)collectionView didEndDisplayingNodeForItemAtIndexPath:(NSIndexPath *)indexPath;
        [Export ("collectionView:didEndDisplayingNodeForItemAtIndexPath:")]
        void DidEndDisplayingNodeForItemAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);
    }
}

