using System;

namespace AsphodelusNative.WIC;

/// <summary>
/// ENUM <b>WICColorContextType</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum ColorContextType : uint {
	/// <summary>
	/// <b>WICColorContextUninitialized</b> = 0
	/// </summary>
	Uninitialized = 0,
	/// <summary>
	/// <b>WICColorContextProfile</b> = 0x1
	/// </summary>
	Profile = 1,
	/// <summary>
	/// <b>WICColorContextExifColorSpace</b> = 0x2
	/// </summary>
	ExifColorSpace = 2,
}

/// <summary>
/// ENUM <b>WICBitmapCreateCacheOption</b><br/>
/// WINCODEC.h
/// </summary>
public enum BitmapCreateCacheOption : uint {
	/// <summary>
	/// <b>WICBitmapNoCache</b> = 0
	/// </summary>
	NoCache = 0,
	/// <summary>
	/// <b>WICBitmapCacheOnDemand</b> = 0x1
	/// </summary>
	CacheOnDemand = 1,
	/// <summary>
	/// <b>WICBitmapCacheOnLoad</b> = 0x2
	/// </summary>
	CacheOnLoad = 2,
}

/// <summary>
/// ENUM <b>WICDecodeOptions</b><br/>
/// WINCODEC.h
/// </summary>
public enum DecodeOptions : uint {
	/// <summary>
	/// <b>WICDecodeMetadataCacheOnDemand</b> = 0
	/// </summary>
	MetadataCacheOnDemand = 0,
	/// <summary>
	/// <b>WICDecodeMetadataCacheOnLoad</b> = 0x1
	/// </summary>
	MetadataCacheOnLoad = 1,
}

/// <summary>
/// ENUM <b>WICBitmapEncoderCacheOption</b><br/>
/// WINCODEC.h
/// </summary>
public enum BitmapEncoderCacheOption : uint {
	/// <summary>
	/// <b>WICBitmapEncoderCacheInMemory</b> = 0
	/// </summary>
	InMemory = 0,
	/// <summary>
	/// <b>WICBitmapEncoderCacheTempFile</b> = 0x1
	/// </summary>
	TempFile = 1,
	/// <summary>
	/// <b>WICBitmapEncoderNoCache</b> = 0x2
	/// </summary>
	NoCache = 2,
}

/// <summary>
/// ENUM <b>WICComponentType</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum ComponentType : uint {
	/// <summary>
	/// <b>WICDecoder</b> = 0x1
	/// </summary>
	Decoder = 1,
	/// <summary>
	/// <b>WICEncoder</b> = 0x2
	/// </summary>
	Encoder = 2,
	/// <summary>
	/// <b>WICPixelFormatConverter</b> = 0x4
	/// </summary>
	PixelFormatConverter = 4,
	/// <summary>
	/// <b>WICMetadataReader</b> = 0x8
	/// </summary>
	MetadataReader = 8,
	/// <summary>
	/// <b>WICMetadataWriter</b> = 0x10
	/// </summary>
	MetadataWriter = 16,
	/// <summary>
	/// <b>WICPixelFormat</b> = 0x20
	/// </summary>
	PixelFormat = 32,
	/// <summary>
	/// <b>WICAllComponents</b> = 0x3f
	/// </summary>
	AllComponents = 63,
}

/// <summary>
/// ENUM <b>WICComponentEnumerateOptions</b><br/>
/// WINCODEC.h
/// </summary>
public enum ComponentEnumerateOptions : uint {
	/// <summary>
	/// <b>WICComponentEnumerateDefault</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>WICComponentEnumerateRefresh</b> = 0x1
	/// </summary>
	Refresh = 1,
	/// <summary>
	/// <b>WICComponentEnumerateDisabled</b> = 0x80000000
	/// </summary>
	Disabled = 2147483648,
	/// <summary>
	/// <b>WICComponentEnumerateUnsigned</b> = 0x40000000
	/// </summary>
	Unsigned = 1073741824,
	/// <summary>
	/// <b>WICComponentEnumerateBuiltInOnly</b> = 0x20000000
	/// </summary>
	BuiltInOnly = 536870912,
}

/// <summary>
/// ENUM <b>WICBitmapInterpolationMode</b><br/>
/// WINCODEC.h
/// </summary>
public enum BitmapInterpolationMode : uint {
	/// <summary>
	/// <b>WICBitmapInterpolationModeNearestNeighbor</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>WICBitmapInterpolationModeLinear</b> = 0x1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>WICBitmapInterpolationModeCubic</b> = 0x2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>WICBitmapInterpolationModeFant</b> = 0x3
	/// </summary>
	Fant = 3,
	/// <summary>
	/// <b>WICBitmapInterpolationModeHighQualityCubic</b> = 0x4
	/// </summary>
	HighQualityCubic = 4,
}

/// <summary>
/// ENUM <b>WICBitmapPaletteType</b><br/>
/// WINCODEC.h
/// </summary>
public enum BitmapPaletteType : uint {
	/// <summary>
	/// <b>WICBitmapPaletteTypeCustom</b> = 0
	/// </summary>
	Custom = 0,
	/// <summary>
	/// <b>WICBitmapPaletteTypeMedianCut</b> = 0x1
	/// </summary>
	MedianCut = 1,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedBW</b> = 0x2
	/// </summary>
	FixedBW = 2,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedHalftone8</b> = 0x3
	/// </summary>
	FixedHalftone8 = 3,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedHalftone27</b> = 0x4
	/// </summary>
	FixedHalftone27 = 4,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedHalftone64</b> = 0x5
	/// </summary>
	FixedHalftone64 = 5,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedHalftone125</b> = 0x6
	/// </summary>
	FixedHalftone125 = 6,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedHalftone216</b> = 0x7
	/// </summary>
	FixedHalftone216 = 7,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedWebPalette</b> = WICBitmapPaletteTypeFixedHalftone216
	/// </summary>
	FixedWebPalette = FixedHalftone216,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedHalftone252</b> = 0x8
	/// </summary>
	FixedHalftone252 = 8,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedHalftone256</b> = 0x9
	/// </summary>
	FixedHalftone256 = 9,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedGray4</b> = 0xa
	/// </summary>
	FixedGray4 = 10,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedGray16</b> = 0xb
	/// </summary>
	FixedGray16 = 11,
	/// <summary>
	/// <b>WICBitmapPaletteTypeFixedGray256</b> = 0xc
	/// </summary>
	FixedGray256 = 12,
}

/// <summary>
/// ENUM <b>WICBitmapDitherType</b><br/>
/// WINCODEC.h
/// </summary>
public enum BitmapDitherType : uint {
	/// <summary>
	/// <b>WICBitmapDitherTypeNone</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>WICBitmapDitherTypeSolid</b> = 0
	/// </summary>
	Solid = 0,
	/// <summary>
	/// <b>WICBitmapDitherTypeOrdered4x4</b> = 0x1
	/// </summary>
	Ordered4x4 = 1,
	/// <summary>
	/// <b>WICBitmapDitherTypeOrdered8x8</b> = 0x2
	/// </summary>
	Ordered8x8 = 2,
	/// <summary>
	/// <b>WICBitmapDitherTypeOrdered16x16</b> = 0x3
	/// </summary>
	Ordered16x16 = 3,
	/// <summary>
	/// <b>WICBitmapDitherTypeSpiral4x4</b> = 0x4
	/// </summary>
	Spiral4x4 = 4,
	/// <summary>
	/// <b>WICBitmapDitherTypeSpiral8x8</b> = 0x5
	/// </summary>
	Spiral8x8 = 5,
	/// <summary>
	/// <b>WICBitmapDitherTypeDualSpiral4x4</b> = 0x6
	/// </summary>
	DualSpiral4x4 = 6,
	/// <summary>
	/// <b>WICBitmapDitherTypeDualSpiral8x8</b> = 0x7
	/// </summary>
	DualSpiral8x8 = 7,
	/// <summary>
	/// <b>WICBitmapDitherTypeErrorDiffusion</b> = 0x8
	/// </summary>
	ErrorDiffusion = 8,
}

/// <summary>
/// ENUM <b>WICBitmapAlphaChannelOption</b><br/>
/// WINCODEC.h
/// </summary>
public enum BitmapAlphaChannelOption : uint {
	/// <summary>
	/// <b>WICBitmapUseAlpha</b> = 0
	/// </summary>
	UseAlpha = 0,
	/// <summary>
	/// <b>WICBitmapUsePremultipliedAlpha</b> = 0x1
	/// </summary>
	UsePremultipliedAlpha = 1,
	/// <summary>
	/// <b>WICBitmapIgnoreAlpha</b> = 0x2
	/// </summary>
	IgnoreAlpha = 2,
}

/// <summary>
/// ENUM <b>WICBitmapTransformOptions</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum BitmapTransformOptions : uint {
	/// <summary>
	/// <b>WICBitmapTransformRotate0</b> = 0
	/// </summary>
	Rotate0 = 0,
	/// <summary>
	/// <b>WICBitmapTransformRotate90</b> = 0x1
	/// </summary>
	Rotate90 = 1,
	/// <summary>
	/// <b>WICBitmapTransformRotate180</b> = 0x2
	/// </summary>
	Rotate180 = 2,
	/// <summary>
	/// <b>WICBitmapTransformRotate270</b> = 0x3
	/// </summary>
	Rotate270 = 3,
	/// <summary>
	/// <b>WICBitmapTransformFlipHorizontal</b> = 0x8
	/// </summary>
	FlipHorizontal = 8,
	/// <summary>
	/// <b>WICBitmapTransformFlipVertical</b> = 0x10
	/// </summary>
	FlipVertical = 16,
}

/// <summary>
/// ENUM <b>WICBitmapLockFlags</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum BitmapLockFlags : uint {
	/// <summary>
	/// <b>WICBitmapLockRead</b> = 0x1
	/// </summary>
	Read = 1,
	/// <summary>
	/// <b>WICBitmapLockWrite</b> = 0x2
	/// </summary>
	Write = 2,
}

/// <summary>
/// ENUM <b>WICBitmapDecoderCapabilities</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum BitmapDecoderCapabilities : uint {
	/// <summary>
	/// <b>WICBitmapDecoderCapabilitySameEncoder</b> = 0x1
	/// </summary>
	CapabilitySameEncoder = 1,
	/// <summary>
	/// <b>WICBitmapDecoderCapabilityCanDecodeAllImages</b> = 0x2
	/// </summary>
	CapabilityCanDecodeAllImages = 2,
	/// <summary>
	/// <b>WICBitmapDecoderCapabilityCanDecodeSomeImages</b> = 0x4
	/// </summary>
	CapabilityCanDecodeSomeImages = 4,
	/// <summary>
	/// <b>WICBitmapDecoderCapabilityCanEnumerateMetadata</b> = 0x8
	/// </summary>
	CapabilityCanEnumerateMetadata = 8,
	/// <summary>
	/// <b>WICBitmapDecoderCapabilityCanDecodeThumbnail</b> = 0x10
	/// </summary>
	CapabilityCanDecodeThumbnail = 16,
}

/// <summary>
/// ENUM <b>WICProgressOperation</b><br/>
/// WINCODEC.h
/// </summary>
public enum ProgressOperation : uint {
	/// <summary>
	/// <b>WICProgressOperationCopyPixels</b> = 0x1
	/// </summary>
	CopyPixels = 1,
	/// <summary>
	/// <b>WICProgressOperationWritePixels</b> = 0x2
	/// </summary>
	WritePixels = 2,
	/// <summary>
	/// <b>WICProgressOperationAll</b> = 0xffff
	/// </summary>
	All = 65535,
}

/// <summary>
/// ENUM <b>WICProgressNotification</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum ProgressNotification : uint {
	/// <summary>
	/// <b>WICProgressNotificationBegin</b> = 0x10000
	/// </summary>
	Begin = 65536,
	/// <summary>
	/// <b>WICProgressNotificationEnd</b> = 0x20000
	/// </summary>
	End = 131072,
	/// <summary>
	/// <b>WICProgressNotificationFrequent</b> = 0x40000
	/// </summary>
	Frequent = 262144,
	/// <summary>
	/// <b>WICProgressNotificationAll</b> = 0xffff0000
	/// </summary>
	All = 4294901760,
}

/// <summary>
/// ENUM <b>WICComponentSigning</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum ComponentSigning : uint {
	/// <summary>
	/// <b>WICComponentSigned</b> = 0x1
	/// </summary>
	Signed = 1,
	/// <summary>
	/// <b>WICComponentUnsigned</b> = 0x2
	/// </summary>
	Unsigned = 2,
	/// <summary>
	/// <b>WICComponentSafe</b> = 0x4
	/// </summary>
	Safe = 4,
	/// <summary>
	/// <b>WICComponentDisabled</b> = 0x80000000
	/// </summary>
	Disabled = 2147483648,
}

/// <summary>
/// ENUM <b>WICGifLogicalScreenDescriptorProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum GifLogicalScreenDescriptorProperties : uint {
	/// <summary>
	/// <b>WICGifLogicalScreenSignature</b> = 0x1
	/// </summary>
	Signature = 1,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorWidth</b> = 0x2
	/// </summary>
	Width = 2,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorHeight</b> = 0x3
	/// </summary>
	Height = 3,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorGlobalColorTableFlag</b> = 0x4
	/// </summary>
	GlobalColorTableFlag = 4,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorColorResolution</b> = 0x5
	/// </summary>
	ColorResolution = 5,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorSortFlag</b> = 0x6
	/// </summary>
	SortFlag = 6,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorGlobalColorTableSize</b> = 0x7
	/// </summary>
	GlobalColorTableSize = 7,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorBackgroundColorIndex</b> = 0x8
	/// </summary>
	BackgroundColorIndex = 8,
	/// <summary>
	/// <b>WICGifLogicalScreenDescriptorPixelAspectRatio</b> = 0x9
	/// </summary>
	PixelAspectRatio = 9,
}

/// <summary>
/// ENUM <b>WICGifImageDescriptorProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum GifImageDescriptorProperties : uint {
	/// <summary>
	/// <b>WICGifImageDescriptorLeft</b> = 0x1
	/// </summary>
	Left = 1,
	/// <summary>
	/// <b>WICGifImageDescriptorTop</b> = 0x2
	/// </summary>
	Top = 2,
	/// <summary>
	/// <b>WICGifImageDescriptorWidth</b> = 0x3
	/// </summary>
	Width = 3,
	/// <summary>
	/// <b>WICGifImageDescriptorHeight</b> = 0x4
	/// </summary>
	Height = 4,
	/// <summary>
	/// <b>WICGifImageDescriptorLocalColorTableFlag</b> = 0x5
	/// </summary>
	LocalColorTableFlag = 5,
	/// <summary>
	/// <b>WICGifImageDescriptorInterlaceFlag</b> = 0x6
	/// </summary>
	InterlaceFlag = 6,
	/// <summary>
	/// <b>WICGifImageDescriptorSortFlag</b> = 0x7
	/// </summary>
	SortFlag = 7,
	/// <summary>
	/// <b>WICGifImageDescriptorLocalColorTableSize</b> = 0x8
	/// </summary>
	LocalColorTableSize = 8,
}

/// <summary>
/// ENUM <b>WICGifGraphicControlExtensionProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum GifGraphicControlExtensionProperties : uint {
	/// <summary>
	/// <b>WICGifGraphicControlExtensionDisposal</b> = 0x1
	/// </summary>
	Disposal = 1,
	/// <summary>
	/// <b>WICGifGraphicControlExtensionUserInputFlag</b> = 0x2
	/// </summary>
	UserInputFlag = 2,
	/// <summary>
	/// <b>WICGifGraphicControlExtensionTransparencyFlag</b> = 0x3
	/// </summary>
	TransparencyFlag = 3,
	/// <summary>
	/// <b>WICGifGraphicControlExtensionDelay</b> = 0x4
	/// </summary>
	Delay = 4,
	/// <summary>
	/// <b>WICGifGraphicControlExtensionTransparentColorIndex</b> = 0x5
	/// </summary>
	TransparentColorIndex = 5,
}

/// <summary>
/// ENUM <b>WICGifApplicationExtensionProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum GifApplicationExtensionProperties : uint {
	/// <summary>
	/// <b>WICGifApplicationExtensionApplication</b> = 0x1
	/// </summary>
	Application = 1,
	/// <summary>
	/// <b>WICGifApplicationExtensionData</b> = 0x2
	/// </summary>
	Data = 2,
}

/// <summary>
/// ENUM <b>WICGifCommentExtensionProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum GifCommentExtensionProperties : uint {
	/// <summary>
	/// <b>WICGifCommentExtensionText</b> = 0x1
	/// </summary>
	Text = 1,
}

/// <summary>
/// ENUM <b>WICJpegCommentProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum JpegCommentProperties : uint {
	/// <summary>
	/// <b>WICJpegCommentText</b> = 0x1
	/// </summary>
	Text = 1,
}

/// <summary>
/// ENUM <b>WICJpegLuminanceProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum JpegLuminanceProperties : uint {
	/// <summary>
	/// <b>WICJpegLuminanceTable</b> = 0x1
	/// </summary>
	Table = 1,
}

/// <summary>
/// ENUM <b>WICJpegChrominanceProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum JpegChrominanceProperties : uint {
	/// <summary>
	/// <b>WICJpegChrominanceTable</b> = 0x1
	/// </summary>
	Table = 1,
}

/// <summary>
/// ENUM <b>WIC8BIMIptcProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum _8BIMIptcProperties : uint {
	/// <summary>
	/// <b>WIC8BIMIptcPString</b> = 0
	/// </summary>
	PString = 0,
	/// <summary>
	/// <b>WIC8BIMIptcEmbeddedIPTC</b> = 0x1
	/// </summary>
	EmbeddedIPTC = 1,
}

/// <summary>
/// ENUM <b>WIC8BIMResolutionInfoProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum _8BIMResolutionInfoProperties : uint {
	/// <summary>
	/// <b>WIC8BIMResolutionInfoPString</b> = 0x1
	/// </summary>
	PString = 1,
	/// <summary>
	/// <b>WIC8BIMResolutionInfoHResolution</b> = 0x2
	/// </summary>
	HResolution = 2,
	/// <summary>
	/// <b>WIC8BIMResolutionInfoHResolutionUnit</b> = 0x3
	/// </summary>
	HResolutionUnit = 3,
	/// <summary>
	/// <b>WIC8BIMResolutionInfoWidthUnit</b> = 0x4
	/// </summary>
	WidthUnit = 4,
	/// <summary>
	/// <b>WIC8BIMResolutionInfoVResolution</b> = 0x5
	/// </summary>
	VResolution = 5,
	/// <summary>
	/// <b>WIC8BIMResolutionInfoVResolutionUnit</b> = 0x6
	/// </summary>
	VResolutionUnit = 6,
	/// <summary>
	/// <b>WIC8BIMResolutionInfoHeightUnit</b> = 0x7
	/// </summary>
	HeightUnit = 7,
}

/// <summary>
/// ENUM <b>WIC8BIMIptcDigestProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum _8BIMIptcDigestProperties : uint {
	/// <summary>
	/// <b>WIC8BIMIptcDigestPString</b> = 0x1
	/// </summary>
	PString = 1,
	/// <summary>
	/// <b>WIC8BIMIptcDigestIptcDigest</b> = 0x2
	/// </summary>
	IptcDigest = 2,
}

/// <summary>
/// ENUM <b>WICPngGamaProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngGamaProperties : uint {
	/// <summary>
	/// <b>WICPngGamaGamma</b> = 0x1
	/// </summary>
	Gamma = 1,
}

/// <summary>
/// ENUM <b>WICPngBkgdProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngBkgdProperties : uint {
	/// <summary>
	/// <b>WICPngBkgdBackgroundColor</b> = 0x1
	/// </summary>
	BackgroundColor = 1,
}

/// <summary>
/// ENUM <b>WICPngItxtProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngItxtProperties : uint {
	/// <summary>
	/// <b>WICPngItxtKeyword</b> = 0x1
	/// </summary>
	Keyword = 1,
	/// <summary>
	/// <b>WICPngItxtCompressionFlag</b> = 0x2
	/// </summary>
	CompressionFlag = 2,
	/// <summary>
	/// <b>WICPngItxtLanguageTag</b> = 0x3
	/// </summary>
	LanguageTag = 3,
	/// <summary>
	/// <b>WICPngItxtTranslatedKeyword</b> = 0x4
	/// </summary>
	TranslatedKeyword = 4,
	/// <summary>
	/// <b>WICPngItxtText</b> = 0x5
	/// </summary>
	Text = 5,
}

/// <summary>
/// ENUM <b>WICPngChrmProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngChrmProperties : uint {
	/// <summary>
	/// <b>WICPngChrmWhitePointX</b> = 0x1
	/// </summary>
	WhitePointX = 1,
	/// <summary>
	/// <b>WICPngChrmWhitePointY</b> = 0x2
	/// </summary>
	WhitePointY = 2,
	/// <summary>
	/// <b>WICPngChrmRedX</b> = 0x3
	/// </summary>
	RedX = 3,
	/// <summary>
	/// <b>WICPngChrmRedY</b> = 0x4
	/// </summary>
	RedY = 4,
	/// <summary>
	/// <b>WICPngChrmGreenX</b> = 0x5
	/// </summary>
	GreenX = 5,
	/// <summary>
	/// <b>WICPngChrmGreenY</b> = 0x6
	/// </summary>
	GreenY = 6,
	/// <summary>
	/// <b>WICPngChrmBlueX</b> = 0x7
	/// </summary>
	BlueX = 7,
	/// <summary>
	/// <b>WICPngChrmBlueY</b> = 0x8
	/// </summary>
	BlueY = 8,
}

/// <summary>
/// ENUM <b>WICPngHistProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngHistProperties : uint {
	/// <summary>
	/// <b>WICPngHistFrequencies</b> = 0x1
	/// </summary>
	Frequencies = 1,
}

/// <summary>
/// ENUM <b>WICPngIccpProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngIccpProperties : uint {
	/// <summary>
	/// <b>WICPngIccpProfileName</b> = 0x1
	/// </summary>
	ProfileName = 1,
	/// <summary>
	/// <b>WICPngIccpProfileData</b> = 0x2
	/// </summary>
	ProfileData = 2,
}

/// <summary>
/// ENUM <b>WICPngSrgbProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngSrgbProperties : uint {
	/// <summary>
	/// <b>WICPngSrgbRenderingIntent</b> = 0x1
	/// </summary>
	RenderingIntent = 1,
}

/// <summary>
/// ENUM <b>WICPngTimeProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngTimeProperties : uint {
	/// <summary>
	/// <b>WICPngTimeYear</b> = 0x1
	/// </summary>
	Year = 1,
	/// <summary>
	/// <b>WICPngTimeMonth</b> = 0x2
	/// </summary>
	Month = 2,
	/// <summary>
	/// <b>WICPngTimeDay</b> = 0x3
	/// </summary>
	Day = 3,
	/// <summary>
	/// <b>WICPngTimeHour</b> = 0x4
	/// </summary>
	Hour = 4,
	/// <summary>
	/// <b>WICPngTimeMinute</b> = 0x5
	/// </summary>
	Minute = 5,
	/// <summary>
	/// <b>WICPngTimeSecond</b> = 0x6
	/// </summary>
	Second = 6,
}

/// <summary>
/// ENUM <b>WICHeifProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum HeifProperties : uint {
	/// <summary>
	/// <b>WICHeifOrientation</b> = 0x1
	/// </summary>
	Orientation = 1,
}

/// <summary>
/// ENUM <b>WICHeifHdrProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum HeifHdrProperties : uint {
	/// <summary>
	/// <b>WICHeifHdrMaximumLuminanceLevel</b> = 0x1
	/// </summary>
	MaximumLuminanceLevel = 1,
	/// <summary>
	/// <b>WICHeifHdrMaximumFrameAverageLuminanceLevel</b> = 0x2
	/// </summary>
	MaximumFrameAverageLuminanceLevel = 2,
	/// <summary>
	/// <b>WICHeifHdrMinimumMasteringDisplayLuminanceLevel</b> = 0x3
	/// </summary>
	MinimumMasteringDisplayLuminanceLevel = 3,
	/// <summary>
	/// <b>WICHeifHdrMaximumMasteringDisplayLuminanceLevel</b> = 0x4
	/// </summary>
	MaximumMasteringDisplayLuminanceLevel = 4,
	/// <summary>
	/// <b>WICHeifHdrCustomVideoPrimaries</b> = 0x5
	/// </summary>
	CustomVideoPrimaries = 5,
}

/// <summary>
/// ENUM <b>WICWebpAnimProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum WebpAnimProperties : uint {
	/// <summary>
	/// <b>WICWebpAnimLoopCount</b> = 0x1
	/// </summary>
	LoopCount = 1,
}

/// <summary>
/// ENUM <b>WICWebpAnmfProperties</b><br/>
/// WINCODEC.h
/// </summary>
public enum WebpAnmfProperties : uint {
	/// <summary>
	/// <b>WICWebpAnmfFrameDuration</b> = 0x1
	/// </summary>
	FrameDuration = 1,
}

/// <summary>
/// ENUM <b>WICSectionAccessLevel</b><br/>
/// WINCODEC.h
/// </summary>
public enum SectionAccessLevel : uint {
	/// <summary>
	/// <b>WICSectionAccessLevelRead</b> = 0x1
	/// </summary>
	Read = 1,
	/// <summary>
	/// <b>WICSectionAccessLevelReadWrite</b> = 0x3
	/// </summary>
	ReadWrite = 3,
}

/// <summary>
/// ENUM <b>WICPixelFormatNumericRepresentation</b><br/>
/// WINCODEC.h
/// </summary>
public enum PixelFormatNumericRepresentation : uint {
	/// <summary>
	/// <b>WICPixelFormatNumericRepresentationUnspecified</b> = 0
	/// </summary>
	Unspecified = 0,
	/// <summary>
	/// <b>WICPixelFormatNumericRepresentationIndexed</b> = 0x1
	/// </summary>
	Indexed = 1,
	/// <summary>
	/// <b>WICPixelFormatNumericRepresentationUnsignedInteger</b> = 0x2
	/// </summary>
	UnsignedInteger = 2,
	/// <summary>
	/// <b>WICPixelFormatNumericRepresentationSignedInteger</b> = 0x3
	/// </summary>
	SignedInteger = 3,
	/// <summary>
	/// <b>WICPixelFormatNumericRepresentationFixed</b> = 0x4
	/// </summary>
	Fixed = 4,
	/// <summary>
	/// <b>WICPixelFormatNumericRepresentationFloat</b> = 0x5
	/// </summary>
	Float = 5,
}

/// <summary>
/// ENUM <b>WICPlanarOptions</b><br/>
/// WINCODEC.h
/// </summary>
public enum PlanarOptions : uint {
	/// <summary>
	/// <b>WICPlanarOptionsDefault</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>WICPlanarOptionsPreserveSubsampling</b> = 0x1
	/// </summary>
	PreserveSubsampling = 1,
}

/// <summary>
/// ENUM <b>WICJpegIndexingOptions</b><br/>
/// WINCODEC.h
/// </summary>
public enum JpegIndexingOptions : uint {
	/// <summary>
	/// <b>WICJpegIndexingOptionsGenerateOnDemand</b> = 0
	/// </summary>
	GenerateOnDemand = 0,
	/// <summary>
	/// <b>WICJpegIndexingOptionsGenerateOnLoad</b> = 0x1
	/// </summary>
	GenerateOnLoad = 1,
}

/// <summary>
/// ENUM <b>WICJpegTransferMatrix</b><br/>
/// WINCODEC.h
/// </summary>
public enum JpegTransferMatrix : uint {
	/// <summary>
	/// <b>WICJpegTransferMatrixIdentity</b> = 0
	/// </summary>
	Identity = 0,
	/// <summary>
	/// <b>WICJpegTransferMatrixBT601</b> = 0x1
	/// </summary>
	Bt601 = 1,
}

/// <summary>
/// ENUM <b>WICJpegScanType</b><br/>
/// WINCODEC.h
/// </summary>
public enum JpegScanType : uint {
	/// <summary>
	/// <b>WICJpegScanTypeInterleaved</b> = 0
	/// </summary>
	Interleaved = 0,
	/// <summary>
	/// <b>WICJpegScanTypePlanarComponents</b> = 0x1
	/// </summary>
	PlanarComponents = 1,
	/// <summary>
	/// <b>WICJpegScanTypeProgressive</b> = 0x2
	/// </summary>
	Progressive = 2,
}

/// <summary>
/// ENUM <b>WICTiffCompressionOption</b><br/>
/// WINCODEC.h
/// </summary>
public enum TiffCompressionOption : uint {
	/// <summary>
	/// <b>WICTiffCompressionDontCare</b> = 0
	/// </summary>
	DontCare = 0,
	/// <summary>
	/// <b>WICTiffCompressionNone</b> = 0x1
	/// </summary>
	None = 1,
	/// <summary>
	/// <b>WICTiffCompressionCCITT3</b> = 0x2
	/// </summary>
	Ccitt3 = 2,
	/// <summary>
	/// <b>WICTiffCompressionCCITT4</b> = 0x3
	/// </summary>
	Ccitt4 = 3,
	/// <summary>
	/// <b>WICTiffCompressionLZW</b> = 0x4
	/// </summary>
	Lzw = 4,
	/// <summary>
	/// <b>WICTiffCompressionRLE</b> = 0x5
	/// </summary>
	Rle = 5,
	/// <summary>
	/// <b>WICTiffCompressionZIP</b> = 0x6
	/// </summary>
	Zip = 6,
	/// <summary>
	/// <b>WICTiffCompressionLZWHDifferencing</b> = 0x7
	/// </summary>
	LZWHDifferencing = 7,
}

/// <summary>
/// ENUM <b>WICJpegYCrCbSubsamplingOption</b><br/>
/// WINCODEC.h
/// </summary>
public enum JpegYCrCbSubsamplingOption : uint {
	/// <summary>
	/// <b>WICJpegYCrCbSubsamplingDefault</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>WICJpegYCrCbSubsampling420</b> = 0x1
	/// </summary>
	Subsampling420 = 1,
	/// <summary>
	/// <b>WICJpegYCrCbSubsampling422</b> = 0x2
	/// </summary>
	Subsampling422 = 2,
	/// <summary>
	/// <b>WICJpegYCrCbSubsampling444</b> = 0x3
	/// </summary>
	Subsampling444 = 3,
	/// <summary>
	/// <b>WICJpegYCrCbSubsampling440</b> = 0x4
	/// </summary>
	Subsampling440 = 4,
}

/// <summary>
/// ENUM <b>WICPngFilterOption</b><br/>
/// WINCODEC.h
/// </summary>
public enum PngFilterOption : uint {
	/// <summary>
	/// <b>WICPngFilterUnspecified</b> = 0
	/// </summary>
	Unspecified = 0,
	/// <summary>
	/// <b>WICPngFilterNone</b> = 0x1
	/// </summary>
	None = 1,
	/// <summary>
	/// <b>WICPngFilterSub</b> = 0x2
	/// </summary>
	Sub = 2,
	/// <summary>
	/// <b>WICPngFilterUp</b> = 0x3
	/// </summary>
	Up = 3,
	/// <summary>
	/// <b>WICPngFilterAverage</b> = 0x4
	/// </summary>
	Average = 4,
	/// <summary>
	/// <b>WICPngFilterPaeth</b> = 0x5
	/// </summary>
	Paeth = 5,
	/// <summary>
	/// <b>WICPngFilterAdaptive</b> = 0x6
	/// </summary>
	Adaptive = 6,
}

/// <summary>
/// ENUM <b>WICNamedWhitePoint</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum NamedWhitePoint : uint {
	/// <summary>
	/// <b>WICWhitePointDefault</b> = 0x1
	/// </summary>
	WhitePointDefault = 1,
	/// <summary>
	/// <b>WICWhitePointDaylight</b> = 0x2
	/// </summary>
	WhitePointDaylight = 2,
	/// <summary>
	/// <b>WICWhitePointCloudy</b> = 0x4
	/// </summary>
	WhitePointCloudy = 4,
	/// <summary>
	/// <b>WICWhitePointShade</b> = 0x8
	/// </summary>
	WhitePointShade = 8,
	/// <summary>
	/// <b>WICWhitePointTungsten</b> = 0x10
	/// </summary>
	WhitePointTungsten = 16,
	/// <summary>
	/// <b>WICWhitePointFluorescent</b> = 0x20
	/// </summary>
	WhitePointFluorescent = 32,
	/// <summary>
	/// <b>WICWhitePointFlash</b> = 0x40
	/// </summary>
	WhitePointFlash = 64,
	/// <summary>
	/// <b>WICWhitePointUnderwater</b> = 0x80
	/// </summary>
	WhitePointUnderwater = 128,
	/// <summary>
	/// <b>WICWhitePointCustom</b> = 0x100
	/// </summary>
	WhitePointCustom = 256,
	/// <summary>
	/// <b>WICWhitePointAutoWhiteBalance</b> = 0x200
	/// </summary>
	WhitePointAutoWhiteBalance = 512,
	/// <summary>
	/// <b>WICWhitePointAsShot</b> = WICWhitePointDefault
	/// </summary>
	WhitePointAsShot = WhitePointDefault,
}

/// <summary>
/// ENUM <b>WICRawCapabilities</b><br/>
/// WINCODEC.h
/// </summary>
[Flags]
public enum RawCapabilities : uint {
	/// <summary>
	/// <b>WICRawCapabilityNotSupported</b> = 0
	/// </summary>
	CapabilityNotSupported = 0,
	/// <summary>
	/// <b>WICRawCapabilityGetSupported</b> = 0x1
	/// </summary>
	CapabilityGetSupported = 1,
	/// <summary>
	/// <b>WICRawCapabilityFullySupported</b> = 0x2
	/// </summary>
	CapabilityFullySupported = 2,
}

/// <summary>
/// ENUM <b>WICRawRotationCapabilities</b><br/>
/// WINCODEC.h
/// </summary>
public enum RawRotationCapabilities : uint {
	/// <summary>
	/// <b>WICRawRotationCapabilityNotSupported</b> = 0
	/// </summary>
	CapabilityNotSupported = 0,
	/// <summary>
	/// <b>WICRawRotationCapabilityGetSupported</b> = 0x1
	/// </summary>
	CapabilityGetSupported = 1,
	/// <summary>
	/// <b>WICRawRotationCapabilityNinetyDegreesSupported</b> = 0x2
	/// </summary>
	CapabilityNinetyDegreesSupported = 2,
	/// <summary>
	/// <b>WICRawRotationCapabilityFullySupported</b> = 0x3
	/// </summary>
	CapabilityFullySupported = 3,
}

/// <summary>
/// ENUM <b>WICRawParameterSet</b><br/>
/// WINCODEC.h
/// </summary>
public enum RawParameterSet : uint {
	/// <summary>
	/// <b>WICAsShotParameterSet</b> = 0x1
	/// </summary>
	AsShotParameterSet = 1,
	/// <summary>
	/// <b>WICUserAdjustedParameterSet</b> = 0x2
	/// </summary>
	UserAdjustedParameterSet = 2,
	/// <summary>
	/// <b>WICAutoAdjustedParameterSet</b> = 0x3
	/// </summary>
	AutoAdjustedParameterSet = 3,
}

/// <summary>
/// ENUM <b>WICRawRenderMode</b><br/>
/// WINCODEC.h
/// </summary>
public enum RawRenderMode : uint {
	/// <summary>
	/// <b>WICRawRenderModeDraft</b> = 0x1
	/// </summary>
	Draft = 1,
	/// <summary>
	/// <b>WICRawRenderModeNormal</b> = 0x2
	/// </summary>
	Normal = 2,
	/// <summary>
	/// <b>WICRawRenderModeBestQuality</b> = 0x3
	/// </summary>
	BestQuality = 3,
}

/// <summary>
/// ENUM <b>WICDdsDimension</b><br/>
/// WINCODEC.h
/// </summary>
public enum DdsDimension : uint {
	/// <summary>
	/// <b>WICDdsTexture1D</b> = 0
	/// </summary>
	Texture1D = 0,
	/// <summary>
	/// <b>WICDdsTexture2D</b> = 0x1
	/// </summary>
	Texture2D = 1,
	/// <summary>
	/// <b>WICDdsTexture3D</b> = 0x2
	/// </summary>
	Texture3D = 2,
	/// <summary>
	/// <b>WICDdsTextureCube</b> = 0x3
	/// </summary>
	TextureCube = 3,
}

/// <summary>
/// ENUM <b>WICDdsAlphaMode</b><br/>
/// WINCODEC.h
/// </summary>
public enum DdsAlphaMode : uint {
	/// <summary>
	/// <b>WICDdsAlphaModeUnknown</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>WICDdsAlphaModeStraight</b> = 0x1
	/// </summary>
	Straight = 1,
	/// <summary>
	/// <b>WICDdsAlphaModePremultiplied</b> = 0x2
	/// </summary>
	Premultiplied = 2,
	/// <summary>
	/// <b>WICDdsAlphaModeOpaque</b> = 0x3
	/// </summary>
	Opaque = 3,
	/// <summary>
	/// <b>WICDdsAlphaModeCustom</b> = 0x4
	/// </summary>
	Custom = 4,
}

/// <summary>
/// ENUM <b>WICMetadataCreationOptions</b><br/>
/// WINCODECSDK.h
/// </summary>
public enum MetadataCreationOptions : uint {
	/// <summary>
	/// <b>WICMetadataCreationDefault</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>WICMetadataCreationAllowUnknown</b> = WICMetadataCreationDefault
	/// </summary>
	AllowUnknown = Default,
	/// <summary>
	/// <b>WICMetadataCreationFailUnknown</b> = 0x10000
	/// </summary>
	FailUnknown = 65536,
	/// <summary>
	/// <b>WICMetadataCreationMask</b> = 0xffff0000
	/// </summary>
	Mask = 4294901760,
}

/// <summary>
/// ENUM <b>WICPersistOptions</b><br/>
/// WINCODECSDK.h
/// </summary>
[Flags]
public enum PersistOptions : uint {
	/// <summary>
	/// <b>WICPersistOptionDefault</b> = 0
	/// </summary>
	OptionDefault = 0,
	/// <summary>
	/// <b>WICPersistOptionLittleEndian</b> = 0
	/// </summary>
	OptionLittleEndian = 0,
	/// <summary>
	/// <b>WICPersistOptionBigEndian</b> = 0x1
	/// </summary>
	OptionBigEndian = 1,
	/// <summary>
	/// <b>WICPersistOptionStrictFormat</b> = 0x2
	/// </summary>
	TrictFormat = 2,
	/// <summary>
	/// <b>WICPersistOptionNoCacheStream</b> = 0x4
	/// </summary>
	OptionNoCacheStream = 4,
	/// <summary>
	/// <b>WICPersistOptionPreferUTF8</b> = 0x8
	/// </summary>
	OptionPreferUTF8 = 8,
	/// <summary>
	/// <b>WICPersistOptionMask</b> = 0xffff
	/// </summary>
	OptionMask = 65535,
}
