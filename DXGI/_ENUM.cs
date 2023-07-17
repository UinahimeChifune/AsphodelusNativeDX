using System;

namespace AsphodelusNative.DXGI;

/// <summary>
/// <b>DXGI_USAGE</b><br/>
/// DXGI.h
/// </summary>
[Flags]
public enum Usage : uint {
	/// <summary>
	/// #define <b>DXGI_CPU_ACCESS_NONE</b>    ( 0 ) 
	/// </summary>
	CpuAccessNone = 0,
	/// <summary>
	/// #define <b>DXGI_CPU_ACCESS_DYNAMIC</b>    ( 1 )
	/// </summary>
	CpuAccessDynamic = 1,
	/// <summary>
	/// #define <b>DXGI_CPU_ACCESS_READ_WRITE</b>    ( 2 )
	/// </summary>
	CpuAccessWrite = 2,
	/// <summary>
	/// #define <b>DXGI_CPU_ACCESS_SCRATCH</b>    ( 3 )
	/// </summary>
	CpuAccessScratch = 3,
	/// <summary>
	/// #define <b>DXGI_CPU_ACCESS_FIELD</b>        15
	/// </summary>
	CpuAccessField = 15,
	/// <summary>
	/// #define <b>DXGI_USAGE_SHADER_INPUT</b>             0x00000010
	/// </summary>
	ShaderInput = 16,
	/// <summary>
	/// #define <b>DXGI_USAGE_RENDER_TARGET_OUTPUT</b>     0x00000020
	/// </summary>
	RenderTargetOutput = 32,
	/// <summary>
	/// #define <b>DXGI_USAGE_BACK_BUFFER</b>              0x00000040
	/// </summary>
	BackBuffer = 64,
	/// <summary>
	/// #define <b>DXGI_USAGE_SHARED</b>                   0x00000080
	/// </summary>
	Shared = 128,
	/// <summary>
	/// #define <b>DXGI_USAGE_READ_ONLY</b>                0x00000100
	/// </summary>
	ReadOnly = 256,
	/// <summary>
	/// #define <b>DXGI_USAGE_DISCARD_ON_PRESENT</b>       0x00000200
	/// </summary>
	DiscardOnPresent = 512,
	/// <summary>
	/// #define <b>DXGI_USAGE_UNORDERED_ACCESS</b>         0x00000400
	/// </summary>
	UnorderedAccess = 1024,
}

/// <summary>
/// ENUM <b>DXGI_RESIDENCY</b><br/>
/// DXGI.h
/// </summary>
public enum Residency : uint {
	/// <summary>
	/// <b>DXGI_RESIDENCY_FULLY_RESIDENT</b> = 1
	/// </summary>
	FullyResident = 1,
	/// <summary>
	/// <b>DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY</b> = 2
	/// </summary>
	ResidentInSharedMemory = 2,
	/// <summary>
	/// <b>DXGI_RESIDENCY_EVICTED_TO_DISK</b> = 3
	/// </summary>
	EvictedToDisk = 3,
}

/// <summary>
/// ENUM <b>DXGI_SWAP_EFFECT</b><br/>
/// DXGI.h
/// </summary>
public enum SwapEffect : uint {
	/// <summary>
	/// <b>DXGI_SWAP_EFFECT_DISCARD</b> = 0
	/// </summary>
	Discard = 0,
	/// <summary>
	/// <b>DXGI_SWAP_EFFECT_SEQUENTIAL</b> = 1
	/// </summary>
	Sequential = 1,
	/// <summary>
	/// <b>DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL</b> = 3
	/// </summary>
	FlipSequential = 3,
	/// <summary>
	/// <b>DXGI_SWAP_EFFECT_FLIP_DISCARD</b> = 4
	/// </summary>
	FlipDiscard = 4,
}

/// <summary>
/// ENUM <b>DXGI_SWAP_CHAIN_FLAG</b><br/>
/// DXGI.h
/// </summary>
[Flags]
public enum SwapChainFlag : uint {
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_NONPREROTATED</b> = 1
	/// </summary>
	Nonprerotated = 1,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH</b> = 2
	/// </summary>
	AllowModeSwitch = 2,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE</b> = 4
	/// </summary>
	GdiCompatible = 4,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT</b> = 8
	/// </summary>
	RestrictedContent = 8,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER</b> = 16
	/// </summary>
	RestrictSharedResourceDriver = 16,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY</b> = 32
	/// </summary>
	DisplayOnly = 32,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT</b> = 64
	/// </summary>
	FrameLatencyWaitableObject = 64,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER</b> = 128
	/// </summary>
	ForegroundLayer = 128,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO</b> = 256
	/// </summary>
	FullscreenVideo = 256,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO</b> = 512
	/// </summary>
	YuvVideo = 512,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED</b> = 1024
	/// </summary>
	HwProtected = 1024,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING</b> = 2048
	/// </summary>
	AllowTearing = 2048,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS</b> = 4096
	/// </summary>
	RestrictedToAllHolographicDisplays = 4096,
}

/// <summary>
/// ENUM <b>DXGI_ADAPTER_FLAG</b><br/>
/// DXGI.h
/// </summary>
[Flags]
public enum AdapterFlag : uint {
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG_REMOTE</b> = 1
	/// </summary>
	Remote = 1,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG_SOFTWARE</b> = 2
	/// </summary>
	Software = 2,
}

/// <summary>
/// ENUM <b>DXGI_OUTDUPL_POINTER_SHAPE_TYPE</b><br/>
/// DXGI1_2.h
/// </summary>
[Flags]
public enum OutduplPointerShapeType : uint {
	/// <summary>
	/// <b>DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MONOCHROME</b> = 0x1
	/// </summary>
	Monochrome = 1,
	/// <summary>
	/// <b>DXGI_OUTDUPL_POINTER_SHAPE_TYPE_COLOR</b> = 0x2
	/// </summary>
	Color = 2,
	/// <summary>
	/// <b>DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MASKED_COLOR</b> = 0x4
	/// </summary>
	MaskedColor = 4,
}

/// <summary>
/// ENUM <b>DXGI_ALPHA_MODE</b><br/>
/// DXGI1_2.h
/// </summary>
public enum AlphaMode : uint {
	/// <summary>
	/// <b>DXGI_ALPHA_MODE_UNSPECIFIED</b> = 0
	/// </summary>
	Unspecified = 0,
	/// <summary>
	/// <b>DXGI_ALPHA_MODE_PREMULTIPLIED</b> = 1
	/// </summary>
	Premultiplied = 1,
	/// <summary>
	/// <b>DXGI_ALPHA_MODE_STRAIGHT</b> = 2
	/// </summary>
	Straight = 2,
	/// <summary>
	/// <b>DXGI_ALPHA_MODE_IGNORE</b> = 3
	/// </summary>
	Ignore = 3,
}

/// <summary>
/// ENUM <b>_DXGI_OFFER_RESOURCE_PRIORITY</b> (DXGI_OFFER_RESOURCE_PRIORITY)<br/>
/// DXGI1_2.h
/// </summary>
public enum OfferResourcePriority : uint {
	/// <summary>
	/// <b>DXGI_OFFER_RESOURCE_PRIORITY_LOW</b> = 1
	/// </summary>
	Low = 1,
	/// <summary>
	/// <b>DXGI_OFFER_RESOURCE_PRIORITY_NORMAL</b> = ( DXGI_OFFER_RESOURCE_PRIORITY_LOW + 1 )
	/// </summary>
	Normal = Low + 1,
	/// <summary>
	/// <b>DXGI_OFFER_RESOURCE_PRIORITY_HIGH</b> = ( DXGI_OFFER_RESOURCE_PRIORITY_NORMAL + 1 )
	/// </summary>
	High = Normal + 1,
}

/// <summary>
/// ENUM <b>DXGI_SCALING</b><br/>
/// DXGI1_2.h
/// </summary>
public enum Scaling : uint {
	/// <summary>
	/// <b>DXGI_SCALING_STRETCH</b> = 0
	/// </summary>
	Stretch = 0,
	/// <summary>
	/// <b>DXGI_SCALING_NONE</b> = 1
	/// </summary>
	None = 1,
	/// <summary>
	/// <b>DXGI_SCALING_ASPECT_RATIO_STRETCH</b> = 2
	/// </summary>
	AspectRatioStretch = 2,
}

/// <summary>
/// ENUM <b>DXGI_GRAPHICS_PREEMPTION_GRANULARITY</b><br/>
/// DXGI1_2.h
/// </summary>
public enum GraphicsPreemptionGranularity : uint {
	/// <summary>
	/// <b>DXGI_GRAPHICS_PREEMPTION_DMA_BUFFER_BOUNDARY</b> = 0
	/// </summary>
	DmaBufferBoundary = 0,
	/// <summary>
	/// <b>DXGI_GRAPHICS_PREEMPTION_PRIMITIVE_BOUNDARY</b> = 1
	/// </summary>
	PrimitiveBoundary = 1,
	/// <summary>
	/// <b>DXGI_GRAPHICS_PREEMPTION_TRIANGLE_BOUNDARY</b> = 2
	/// </summary>
	TriangleBoundary = 2,
	/// <summary>
	/// <b>DXGI_GRAPHICS_PREEMPTION_PIXEL_BOUNDARY</b> = 3
	/// </summary>
	PixelBoundary = 3,
	/// <summary>
	/// <b>DXGI_GRAPHICS_PREEMPTION_INSTRUCTION_BOUNDARY</b> = 4
	/// </summary>
	InstructionBoundary = 4,
}

/// <summary>
/// ENUM <b>DXGI_COMPUTE_PREEMPTION_GRANULARITY</b><br/>
/// DXGI1_2.h
/// </summary>
public enum ComputePreemptionGranularity : uint {
	/// <summary>
	/// <b>DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY</b> = 0
	/// </summary>
	DmaBufferBoundary = 0,
	/// <summary>
	/// <b>DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY</b> = 1
	/// </summary>
	DispatchBoundary = 1,
	/// <summary>
	/// <b>DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY</b> = 2
	/// </summary>
	ThreadGroupBoundary = 2,
	/// <summary>
	/// <b>DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY</b> = 3
	/// </summary>
	ThreadBoundary = 3,
	/// <summary>
	/// <b>DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY</b> = 4
	/// </summary>
	InstructionBoundary = 4,
}

/// <summary>
/// ENUM <b>DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS</b><br/>
/// DXGI1_3.h
/// </summary>
[Flags]
public enum MultiplaneOverlayYCbCrFlags : uint {
	/// <summary>
	/// <b>DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_NOMINAL_RANGE</b> = 0x1
	/// </summary>
	FlagNominalRange = 1,
	/// <summary>
	/// <b>DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_BT709</b> = 0x2
	/// </summary>
	FlagBt709 = 2,
	/// <summary>
	/// <b>DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_xvYCC</b> = 0x4
	/// </summary>
	FlagxvYCC = 4,
}

/// <summary>
/// ENUM <b>DXGI_FRAME_PRESENTATION_MODE</b><br/>
/// DXGI1_3.h
/// </summary>
public enum FramePresentationMode : uint {
	/// <summary>
	/// <b>DXGI_FRAME_PRESENTATION_MODE_COMPOSED</b> = 0
	/// </summary>
	Composed = 0,
	/// <summary>
	/// <b>DXGI_FRAME_PRESENTATION_MODE_OVERLAY</b> = 1
	/// </summary>
	Overlay = 1,
	/// <summary>
	/// <b>DXGI_FRAME_PRESENTATION_MODE_NONE</b> = 2
	/// </summary>
	None = 2,
	/// <summary>
	/// <b>DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE</b> = 3
	/// </summary>
	CompositionFailure = 3,
}

/// <summary>
/// ENUM <b>DXGI_OVERLAY_SUPPORT_FLAG</b><br/>
/// DXGI1_3.h
/// </summary>
[Flags]
public enum OverlaySupportFlag : uint {
	/// <summary>
	/// <b>DXGI_OVERLAY_SUPPORT_FLAG_DIRECT</b> = 0x1
	/// </summary>
	Direct = 1,
	/// <summary>
	/// <b>DXGI_OVERLAY_SUPPORT_FLAG_SCALING</b> = 0x2
	/// </summary>
	Scaling = 2,
}

/// <summary>
/// ENUM <b>DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG</b><br/>
/// DXGI1_4.h
/// </summary>
[Flags]
public enum SwapChainColorSpaceSupportFlag : uint {
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_PRESENT</b> = 0x1
	/// </summary>
	Present = 1,
	/// <summary>
	/// <b>DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_OVERLAY_PRESENT</b> = 0x2
	/// </summary>
	OverlayPresent = 2,
}

/// <summary>
/// ENUM <b>DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG</b><br/>
/// DXGI1_4.h
/// </summary>
public enum OverlayColorSpaceSupportFlag : uint {
	/// <summary>
	/// <b>DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG_PRESENT</b> = 0x1
	/// </summary>
	Present = 1,
}

/// <summary>
/// ENUM <b>DXGI_MEMORY_SEGMENT_GROUP</b><br/>
/// DXGI1_4.h
/// </summary>
public enum MemorySegmentGroup : uint {
	/// <summary>
	/// <b>DXGI_MEMORY_SEGMENT_GROUP_LOCAL</b> = 0
	/// </summary>
	Local = 0,
	/// <summary>
	/// <b>DXGI_MEMORY_SEGMENT_GROUP_NON_LOCAL</b> = 1
	/// </summary>
	NonLocal = 1,
}

/// <summary>
/// ENUM <b>DXGI_OUTDUPL_FLAG</b><br/>
/// DXGI1_5.h
/// </summary>
public enum OutduplFlag : uint {
	/// <summary>
	/// <b>DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY</b> = 1
	/// </summary>
	CompositedUiCaptureOnly = 1,
}

/// <summary>
/// ENUM <b>DXGI_HDR_METADATA_TYPE</b><br/>
/// DXGI1_5.h
/// </summary>
public enum HdrMetadataType : uint {
	/// <summary>
	/// <b>DXGI_HDR_METADATA_TYPE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>DXGI_HDR_METADATA_TYPE_HDR10</b> = 1
	/// </summary>
	Hdr10 = 1,
	/// <summary>
	/// <b>DXGI_HDR_METADATA_TYPE_HDR10PLUS</b> = 2
	/// </summary>
	Hdr10plus = 2,
}

/// <summary>
/// ENUM <b>_DXGI_OFFER_RESOURCE_FLAGS</b> (DXGI_OFFER_RESOURCE_FLAGS)<br/>
/// DXGI1_5.h
/// </summary>
public enum OfferResourceFlags : uint {
	/// <summary>
	/// <b>DXGI_OFFER_RESOURCE_FLAG_ALLOW_DECOMMIT</b> = 0x1
	/// </summary>
	FlagAllowDecommit = 1,
}

/// <summary>
/// ENUM <b>_DXGI_RECLAIM_RESOURCE_RESULTS</b> (DXGI_RECLAIM_RESOURCE_RESULTS)<br/>
/// DXGI1_5.h
/// </summary>
public enum ReclaimResourceResults : uint {
	/// <summary>
	/// <b>DXGI_RECLAIM_RESOURCE_RESULT_OK</b> = 0
	/// </summary>
	ResultOk = 0,
	/// <summary>
	/// <b>DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED</b> = 1
	/// </summary>
	ResultDiscarded = 1,
	/// <summary>
	/// <b>DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED</b> = 2
	/// </summary>
	ResultNotCommitted = 2,
}

/// <summary>
/// ENUM <b>DXGI_FEATURE</b><br/>
/// DXGI1_5.h
/// </summary>
public enum Feature : uint {
	/// <summary>
	/// <b>DXGI_FEATURE_PRESENT_ALLOW_TEARING</b> = 0
	/// </summary>
	PresentAllowTearing = 0,
}

/// <summary>
/// ENUM <b>DXGI_ADAPTER_FLAG3</b><br/>
/// DXGI1_6.h
/// </summary>
[Flags]
public enum AdapterFlag3 : uint {
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3_REMOTE</b> = 1
	/// </summary>
	Remote = 1,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3_SOFTWARE</b> = 2
	/// </summary>
	Software = 2,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE</b> = 4
	/// </summary>
	AcgCompatible = 4,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES</b> = 8
	/// </summary>
	SupportMonitoredFences = 8,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES</b> = 0x10
	/// </summary>
	SupportNonMonitoredFences = 16,
	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE</b> = 0x20
	/// </summary>
	KeyedMutexConformance = 32,
}

/// <summary>
/// ENUM <b>DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS</b><br/>
/// DXGI1_6.h
/// </summary>
[Flags]
public enum HardwareCompositionSupportFlags : uint {
	/// <summary>
	/// <b>DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN</b> = 1
	/// </summary>
	FlagFullscreen = 1,
	/// <summary>
	/// <b>DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED</b> = 2
	/// </summary>
	FlagWindowed = 2,
	/// <summary>
	/// <b>DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED</b> = 4
	/// </summary>
	FlagCursorStretched = 4,
}

/// <summary>
/// ENUM <b>DXGI_GPU_PREFERENCE</b><br/>
/// DXGI1_6.h
/// </summary>
public enum GpuPreference : uint {
	/// <summary>
	/// <b>DXGI_GPU_PREFERENCE_UNSPECIFIED</b> = 0
	/// </summary>
	Unspecified = 0,
	/// <summary>
	/// <b>DXGI_GPU_PREFERENCE_MINIMUM_POWER</b> = ( DXGI_GPU_PREFERENCE_UNSPECIFIED + 1 )
	/// </summary>
	MinimumPower = Unspecified + 1,
	/// <summary>
	/// <b>DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE</b> = ( DXGI_GPU_PREFERENCE_MINIMUM_POWER + 1 )
	/// </summary>
	HighPerformance = MinimumPower + 1,
}

/// <summary>
/// ENUM <b>DXGI_COLOR_SPACE_TYPE</b><br/>
/// DXGICOMMON.h
/// </summary>
public enum ColorSpaceType : uint {
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709</b> = 0
	/// </summary>
	RgbFullG22NoneP709 = 0,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709</b> = 1
	/// </summary>
	RgbFullG10NoneP709 = 1,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709</b> = 2
	/// </summary>
	RgbStudioG22NoneP709 = 2,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020</b> = 3
	/// </summary>
	RgbStudioG22NoneP2020 = 3,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RESERVED</b> = 4
	/// </summary>
	Reserved = 4,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601</b> = 5
	/// </summary>
	YcbcrFullG22NoneP709X601 = 5,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601</b> = 6
	/// </summary>
	YcbcrStudioG22LeftP601 = 6,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601</b> = 7
	/// </summary>
	YcbcrFullG22LeftP601 = 7,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709</b> = 8
	/// </summary>
	YcbcrStudioG22LeftP709 = 8,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709</b> = 9
	/// </summary>
	YcbcrFullG22LeftP709 = 9,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020</b> = 10
	/// </summary>
	YcbcrStudioG22LeftP2020 = 10,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020</b> = 11
	/// </summary>
	YcbcrFullG22LeftP2020 = 11,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020</b> = 12
	/// </summary>
	RgbFullG2084NoneP2020 = 12,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020</b> = 13
	/// </summary>
	YcbcrStudioG2084LeftP2020 = 13,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020</b> = 14
	/// </summary>
	RgbStudioG2084NoneP2020 = 14,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020</b> = 15
	/// </summary>
	YcbcrStudioG22TopleftP2020 = 15,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020</b> = 16
	/// </summary>
	YcbcrStudioG2084TopleftP2020 = 16,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020</b> = 17
	/// </summary>
	RgbFullG22NoneP2020 = 17,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020</b> = 18
	/// </summary>
	YcbcrStudioGhlgTopleftP2020 = 18,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020</b> = 19
	/// </summary>
	YcbcrFullGhlgTopleftP2020 = 19,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709</b> = 20
	/// </summary>
	RgbStudioG24NoneP709 = 20,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020</b> = 21
	/// </summary>
	RgbStudioG24NoneP2020 = 21,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709</b> = 22
	/// </summary>
	YcbcrStudioG24LeftP709 = 22,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020</b> = 23
	/// </summary>
	YcbcrStudioG24LeftP2020 = 23,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020</b> = 24
	/// </summary>
	YcbcrStudioG24TopleftP2020 = 24,
	/// <summary>
	/// <b>DXGI_COLOR_SPACE_CUSTOM</b> = 0xFFFFFFFF
	/// </summary>
	Custom = 4294967295,
}

/// <summary>
/// ENUM <b>DXGI_DEBUG_RLO_FLAGS</b><br/>
/// DXGIDEBUG.h
/// </summary>
[Flags]
public enum DebugRloFlags : uint {
	/// <summary>
	/// <b>DXGI_DEBUG_RLO_SUMMARY</b> = 0x1
	/// </summary>
	Summary = 1,
	/// <summary>
	/// <b>DXGI_DEBUG_RLO_DETAIL</b> = 0x2
	/// </summary>
	Detail = 2,
	/// <summary>
	/// <b>DXGI_DEBUG_RLO_IGNORE_INTERNAL</b> = 0x4
	/// </summary>
	IgnoreInternal = 4,
	/// <summary>
	/// <b>DXGI_DEBUG_RLO_ALL</b> = 0x7
	/// </summary>
	All = 7,
}

/// <summary>
/// ENUM <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY</b><br/>
/// DXGIDEBUG.h
/// </summary>
public enum InfoQueueMessageCategory : uint {
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_MISCELLANEOUS</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_UNKNOWN + 1 )
	/// </summary>
	Miscellaneous = Unknown + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_INITIALIZATION</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_MISCELLANEOUS + 1 )
	/// </summary>
	Initialization = Miscellaneous + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_CLEANUP</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_INITIALIZATION + 1 )
	/// </summary>
	Cleanup = Initialization + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_COMPILATION</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_CLEANUP + 1 )
	/// </summary>
	Compilation = Cleanup + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_CREATION</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_COMPILATION + 1 )
	/// </summary>
	StateCreation = Compilation + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_SETTING</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_CREATION + 1 )
	/// </summary>
	StateSetting = StateCreation + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_GETTING</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_SETTING + 1 )
	/// </summary>
	StateGetting = StateSetting + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_RESOURCE_MANIPULATION</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_GETTING + 1 )
	/// </summary>
	ResourceManipulation = StateGetting + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_EXECUTION</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_RESOURCE_MANIPULATION + 1 )
	/// </summary>
	Execution = ResourceManipulation + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY_SHADER</b> = ( DXGI_INFO_QUEUE_MESSAGE_CATEGORY_EXECUTION + 1 )
	/// </summary>
	Shader = Execution + 1,
}

/// <summary>
/// ENUM <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY</b><br/>
/// DXGIDEBUG.h
/// </summary>
public enum InfoQueueMessageSeverity : uint {
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY_CORRUPTION</b> = 0
	/// </summary>
	Corruption = 0,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY_ERROR</b> = ( DXGI_INFO_QUEUE_MESSAGE_SEVERITY_CORRUPTION + 1 )
	/// </summary>
	Error = Corruption + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY_WARNING</b> = ( DXGI_INFO_QUEUE_MESSAGE_SEVERITY_ERROR + 1 )
	/// </summary>
	Warning = Error + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY_INFO</b> = ( DXGI_INFO_QUEUE_MESSAGE_SEVERITY_WARNING + 1 )
	/// </summary>
	Info = Warning + 1,
	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY_MESSAGE</b> = ( DXGI_INFO_QUEUE_MESSAGE_SEVERITY_INFO + 1 )
	/// </summary>
	Message = Info + 1,
}

/// <summary>
/// ENUM <b>DXGI_FORMAT</b><br/>
/// DXGIFORMAT.h
/// </summary>
public enum Format : uint {
	/// <summary>
	/// <b>DXGI_FORMAT_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32A32_TYPELESS</b> = 1
	/// </summary>
	R32g32b32a32Typeless = 1,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32A32_FLOAT</b> = 2
	/// </summary>
	R32g32b32a32Float = 2,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32A32_UINT</b> = 3
	/// </summary>
	R32g32b32a32Uint = 3,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32A32_SINT</b> = 4
	/// </summary>
	R32g32b32a32Sint = 4,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32_TYPELESS</b> = 5
	/// </summary>
	R32g32b32Typeless = 5,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32_FLOAT</b> = 6
	/// </summary>
	R32g32b32Float = 6,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32_UINT</b> = 7
	/// </summary>
	R32g32b32Uint = 7,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32B32_SINT</b> = 8
	/// </summary>
	R32g32b32Sint = 8,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16B16A16_TYPELESS</b> = 9
	/// </summary>
	R16g16b16a16Typeless = 9,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16B16A16_FLOAT</b> = 10
	/// </summary>
	R16g16b16a16Float = 10,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16B16A16_UNORM</b> = 11
	/// </summary>
	R16g16b16a16Unorm = 11,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16B16A16_UINT</b> = 12
	/// </summary>
	R16g16b16a16Uint = 12,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16B16A16_SNORM</b> = 13
	/// </summary>
	R16g16b16a16Snorm = 13,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16B16A16_SINT</b> = 14
	/// </summary>
	R16g16b16a16Sint = 14,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32_TYPELESS</b> = 15
	/// </summary>
	R32g32Typeless = 15,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32_FLOAT</b> = 16
	/// </summary>
	R32g32Float = 16,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32_UINT</b> = 17
	/// </summary>
	R32g32Uint = 17,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G32_SINT</b> = 18
	/// </summary>
	R32g32Sint = 18,
	/// <summary>
	/// <b>DXGI_FORMAT_R32G8X24_TYPELESS</b> = 19
	/// </summary>
	R32g8x24Typeless = 19,
	/// <summary>
	/// <b>DXGI_FORMAT_D32_FLOAT_S8X24_UINT</b> = 20
	/// </summary>
	D32FloatS8x24Uint = 20,
	/// <summary>
	/// <b>DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS</b> = 21
	/// </summary>
	R32FloatX8x24Typeless = 21,
	/// <summary>
	/// <b>DXGI_FORMAT_X32_TYPELESS_G8X24_UINT</b> = 22
	/// </summary>
	X32TypelessG8x24Uint = 22,
	/// <summary>
	/// <b>DXGI_FORMAT_R10G10B10A2_TYPELESS</b> = 23
	/// </summary>
	R10g10b10a2Typeless = 23,
	/// <summary>
	/// <b>DXGI_FORMAT_R10G10B10A2_UNORM</b> = 24
	/// </summary>
	R10g10b10a2Unorm = 24,
	/// <summary>
	/// <b>DXGI_FORMAT_R10G10B10A2_UINT</b> = 25
	/// </summary>
	R10g10b10a2Uint = 25,
	/// <summary>
	/// <b>DXGI_FORMAT_R11G11B10_FLOAT</b> = 26
	/// </summary>
	R11g11b10Float = 26,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8B8A8_TYPELESS</b> = 27
	/// </summary>
	R8g8b8a8Typeless = 27,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8B8A8_UNORM</b> = 28
	/// </summary>
	R8g8b8a8Unorm = 28,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8B8A8_UNORM_SRGB</b> = 29
	/// </summary>
	R8g8b8a8UnormSrgb = 29,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8B8A8_UINT</b> = 30
	/// </summary>
	R8g8b8a8Uint = 30,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8B8A8_SNORM</b> = 31
	/// </summary>
	R8g8b8a8Snorm = 31,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8B8A8_SINT</b> = 32
	/// </summary>
	R8g8b8a8Sint = 32,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16_TYPELESS</b> = 33
	/// </summary>
	R16g16Typeless = 33,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16_FLOAT</b> = 34
	/// </summary>
	R16g16Float = 34,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16_UNORM</b> = 35
	/// </summary>
	R16g16Unorm = 35,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16_UINT</b> = 36
	/// </summary>
	R16g16Uint = 36,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16_SNORM</b> = 37
	/// </summary>
	R16g16Snorm = 37,
	/// <summary>
	/// <b>DXGI_FORMAT_R16G16_SINT</b> = 38
	/// </summary>
	R16g16Sint = 38,
	/// <summary>
	/// <b>DXGI_FORMAT_R32_TYPELESS</b> = 39
	/// </summary>
	R32Typeless = 39,
	/// <summary>
	/// <b>DXGI_FORMAT_D32_FLOAT</b> = 40
	/// </summary>
	D32Float = 40,
	/// <summary>
	/// <b>DXGI_FORMAT_R32_FLOAT</b> = 41
	/// </summary>
	R32Float = 41,
	/// <summary>
	/// <b>DXGI_FORMAT_R32_UINT</b> = 42
	/// </summary>
	R32Uint = 42,
	/// <summary>
	/// <b>DXGI_FORMAT_R32_SINT</b> = 43
	/// </summary>
	R32Sint = 43,
	/// <summary>
	/// <b>DXGI_FORMAT_R24G8_TYPELESS</b> = 44
	/// </summary>
	R24g8Typeless = 44,
	/// <summary>
	/// <b>DXGI_FORMAT_D24_UNORM_S8_UINT</b> = 45
	/// </summary>
	D24UnormS8Uint = 45,
	/// <summary>
	/// <b>DXGI_FORMAT_R24_UNORM_X8_TYPELESS</b> = 46
	/// </summary>
	R24UnormX8Typeless = 46,
	/// <summary>
	/// <b>DXGI_FORMAT_X24_TYPELESS_G8_UINT</b> = 47
	/// </summary>
	X24TypelessG8Uint = 47,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8_TYPELESS</b> = 48
	/// </summary>
	R8g8Typeless = 48,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8_UNORM</b> = 49
	/// </summary>
	R8g8Unorm = 49,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8_UINT</b> = 50
	/// </summary>
	R8g8Uint = 50,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8_SNORM</b> = 51
	/// </summary>
	R8g8Snorm = 51,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8_SINT</b> = 52
	/// </summary>
	R8g8Sint = 52,
	/// <summary>
	/// <b>DXGI_FORMAT_R16_TYPELESS</b> = 53
	/// </summary>
	R16Typeless = 53,
	/// <summary>
	/// <b>DXGI_FORMAT_R16_FLOAT</b> = 54
	/// </summary>
	R16Float = 54,
	/// <summary>
	/// <b>DXGI_FORMAT_D16_UNORM</b> = 55
	/// </summary>
	D16Unorm = 55,
	/// <summary>
	/// <b>DXGI_FORMAT_R16_UNORM</b> = 56
	/// </summary>
	R16Unorm = 56,
	/// <summary>
	/// <b>DXGI_FORMAT_R16_UINT</b> = 57
	/// </summary>
	R16Uint = 57,
	/// <summary>
	/// <b>DXGI_FORMAT_R16_SNORM</b> = 58
	/// </summary>
	R16Snorm = 58,
	/// <summary>
	/// <b>DXGI_FORMAT_R16_SINT</b> = 59
	/// </summary>
	R16Sint = 59,
	/// <summary>
	/// <b>DXGI_FORMAT_R8_TYPELESS</b> = 60
	/// </summary>
	R8Typeless = 60,
	/// <summary>
	/// <b>DXGI_FORMAT_R8_UNORM</b> = 61
	/// </summary>
	R8Unorm = 61,
	/// <summary>
	/// <b>DXGI_FORMAT_R8_UINT</b> = 62
	/// </summary>
	R8Uint = 62,
	/// <summary>
	/// <b>DXGI_FORMAT_R8_SNORM</b> = 63
	/// </summary>
	R8Snorm = 63,
	/// <summary>
	/// <b>DXGI_FORMAT_R8_SINT</b> = 64
	/// </summary>
	R8Sint = 64,
	/// <summary>
	/// <b>DXGI_FORMAT_A8_UNORM</b> = 65
	/// </summary>
	A8Unorm = 65,
	/// <summary>
	/// <b>DXGI_FORMAT_R1_UNORM</b> = 66
	/// </summary>
	R1Unorm = 66,
	/// <summary>
	/// <b>DXGI_FORMAT_R9G9B9E5_SHAREDEXP</b> = 67
	/// </summary>
	R9g9b9e5Sharedexp = 67,
	/// <summary>
	/// <b>DXGI_FORMAT_R8G8_B8G8_UNORM</b> = 68
	/// </summary>
	R8g8B8g8Unorm = 68,
	/// <summary>
	/// <b>DXGI_FORMAT_G8R8_G8B8_UNORM</b> = 69
	/// </summary>
	G8r8G8b8Unorm = 69,
	/// <summary>
	/// <b>DXGI_FORMAT_BC1_TYPELESS</b> = 70
	/// </summary>
	Bc1Typeless = 70,
	/// <summary>
	/// <b>DXGI_FORMAT_BC1_UNORM</b> = 71
	/// </summary>
	Bc1Unorm = 71,
	/// <summary>
	/// <b>DXGI_FORMAT_BC1_UNORM_SRGB</b> = 72
	/// </summary>
	Bc1UnormSrgb = 72,
	/// <summary>
	/// <b>DXGI_FORMAT_BC2_TYPELESS</b> = 73
	/// </summary>
	Bc2Typeless = 73,
	/// <summary>
	/// <b>DXGI_FORMAT_BC2_UNORM</b> = 74
	/// </summary>
	Bc2Unorm = 74,
	/// <summary>
	/// <b>DXGI_FORMAT_BC2_UNORM_SRGB</b> = 75
	/// </summary>
	Bc2UnormSrgb = 75,
	/// <summary>
	/// <b>DXGI_FORMAT_BC3_TYPELESS</b> = 76
	/// </summary>
	Bc3Typeless = 76,
	/// <summary>
	/// <b>DXGI_FORMAT_BC3_UNORM</b> = 77
	/// </summary>
	Bc3Unorm = 77,
	/// <summary>
	/// <b>DXGI_FORMAT_BC3_UNORM_SRGB</b> = 78
	/// </summary>
	Bc3UnormSrgb = 78,
	/// <summary>
	/// <b>DXGI_FORMAT_BC4_TYPELESS</b> = 79
	/// </summary>
	Bc4Typeless = 79,
	/// <summary>
	/// <b>DXGI_FORMAT_BC4_UNORM</b> = 80
	/// </summary>
	Bc4Unorm = 80,
	/// <summary>
	/// <b>DXGI_FORMAT_BC4_SNORM</b> = 81
	/// </summary>
	Bc4Snorm = 81,
	/// <summary>
	/// <b>DXGI_FORMAT_BC5_TYPELESS</b> = 82
	/// </summary>
	Bc5Typeless = 82,
	/// <summary>
	/// <b>DXGI_FORMAT_BC5_UNORM</b> = 83
	/// </summary>
	Bc5Unorm = 83,
	/// <summary>
	/// <b>DXGI_FORMAT_BC5_SNORM</b> = 84
	/// </summary>
	Bc5Snorm = 84,
	/// <summary>
	/// <b>DXGI_FORMAT_B5G6R5_UNORM</b> = 85
	/// </summary>
	B5g6r5Unorm = 85,
	/// <summary>
	/// <b>DXGI_FORMAT_B5G5R5A1_UNORM</b> = 86
	/// </summary>
	B5g5r5a1Unorm = 86,
	/// <summary>
	/// <b>DXGI_FORMAT_B8G8R8A8_UNORM</b> = 87
	/// </summary>
	B8g8r8a8Unorm = 87,
	/// <summary>
	/// <b>DXGI_FORMAT_B8G8R8X8_UNORM</b> = 88
	/// </summary>
	B8g8r8x8Unorm = 88,
	/// <summary>
	/// <b>DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM</b> = 89
	/// </summary>
	R10g10b10XrBiasA2Unorm = 89,
	/// <summary>
	/// <b>DXGI_FORMAT_B8G8R8A8_TYPELESS</b> = 90
	/// </summary>
	B8g8r8a8Typeless = 90,
	/// <summary>
	/// <b>DXGI_FORMAT_B8G8R8A8_UNORM_SRGB</b> = 91
	/// </summary>
	B8g8r8a8UnormSrgb = 91,
	/// <summary>
	/// <b>DXGI_FORMAT_B8G8R8X8_TYPELESS</b> = 92
	/// </summary>
	B8g8r8x8Typeless = 92,
	/// <summary>
	/// <b>DXGI_FORMAT_B8G8R8X8_UNORM_SRGB</b> = 93
	/// </summary>
	B8g8r8x8UnormSrgb = 93,
	/// <summary>
	/// <b>DXGI_FORMAT_BC6H_TYPELESS</b> = 94
	/// </summary>
	Bc6hTypeless = 94,
	/// <summary>
	/// <b>DXGI_FORMAT_BC6H_UF16</b> = 95
	/// </summary>
	Bc6hUf16 = 95,
	/// <summary>
	/// <b>DXGI_FORMAT_BC6H_SF16</b> = 96
	/// </summary>
	Bc6hSf16 = 96,
	/// <summary>
	/// <b>DXGI_FORMAT_BC7_TYPELESS</b> = 97
	/// </summary>
	Bc7Typeless = 97,
	/// <summary>
	/// <b>DXGI_FORMAT_BC7_UNORM</b> = 98
	/// </summary>
	Bc7Unorm = 98,
	/// <summary>
	/// <b>DXGI_FORMAT_BC7_UNORM_SRGB</b> = 99
	/// </summary>
	Bc7UnormSrgb = 99,
	/// <summary>
	/// <b>DXGI_FORMAT_AYUV</b> = 100
	/// </summary>
	Ayuv = 100,
	/// <summary>
	/// <b>DXGI_FORMAT_Y410</b> = 101
	/// </summary>
	Y410 = 101,
	/// <summary>
	/// <b>DXGI_FORMAT_Y416</b> = 102
	/// </summary>
	Y416 = 102,
	/// <summary>
	/// <b>DXGI_FORMAT_NV12</b> = 103
	/// </summary>
	Nv12 = 103,
	/// <summary>
	/// <b>DXGI_FORMAT_P010</b> = 104
	/// </summary>
	P010 = 104,
	/// <summary>
	/// <b>DXGI_FORMAT_P016</b> = 105
	/// </summary>
	P016 = 105,
	/// <summary>
	/// <b>DXGI_FORMAT_420_OPAQUE</b> = 106
	/// </summary>
	Format420Opaque = 106,
	/// <summary>
	/// <b>DXGI_FORMAT_YUY2</b> = 107
	/// </summary>
	Yuy2 = 107,
	/// <summary>
	/// <b>DXGI_FORMAT_Y210</b> = 108
	/// </summary>
	Y210 = 108,
	/// <summary>
	/// <b>DXGI_FORMAT_Y216</b> = 109
	/// </summary>
	Y216 = 109,
	/// <summary>
	/// <b>DXGI_FORMAT_NV11</b> = 110
	/// </summary>
	Nv11 = 110,
	/// <summary>
	/// <b>DXGI_FORMAT_AI44</b> = 111
	/// </summary>
	Ai44 = 111,
	/// <summary>
	/// <b>DXGI_FORMAT_IA44</b> = 112
	/// </summary>
	Ia44 = 112,
	/// <summary>
	/// <b>DXGI_FORMAT_P8</b> = 113
	/// </summary>
	P8 = 113,
	/// <summary>
	/// <b>DXGI_FORMAT_A8P8</b> = 114
	/// </summary>
	A8p8 = 114,
	/// <summary>
	/// <b>DXGI_FORMAT_B4G4R4A4_UNORM</b> = 115
	/// </summary>
	B4g4r4a4Unorm = 115,
	/// <summary>
	/// <b>DXGI_FORMAT_P208</b> = 130
	/// </summary>
	P208 = 130,
	/// <summary>
	/// <b>DXGI_FORMAT_V208</b> = 131
	/// </summary>
	V208 = 131,
	/// <summary>
	/// <b>DXGI_FORMAT_V408</b> = 132
	/// </summary>
	V408 = 132,
	/// <summary>
	/// <b>DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE</b> = 189
	/// </summary>
	SamplerFeedbackMinMipOpaque = 189,
	/// <summary>
	/// <b>DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE</b> = 190
	/// </summary>
	SamplerFeedbackMipRegionUsedOpaque = 190,
	/// <summary>
	/// <b>DXGI_FORMAT_FORCE_UINT</b> = 0xffffffff
	/// </summary>
	ForceUint = 4294967295,
}

/// <summary>
/// ENUM <b>DXGI_MODE_SCANLINE_ORDER</b><br/>
/// DXGITYPE.h
/// </summary>
public enum ModeScanlineOrder : uint {
	/// <summary>
	/// <b>DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED</b> = 0
	/// </summary>
	Unspecified = 0,
	/// <summary>
	/// <b>DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE</b> = 1
	/// </summary>
	Progressive = 1,
	/// <summary>
	/// <b>DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST</b> = 2
	/// </summary>
	UpperFieldFirst = 2,
	/// <summary>
	/// <b>DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST</b> = 3
	/// </summary>
	LowerFieldFirst = 3,
}

/// <summary>
/// ENUM <b>DXGI_MODE_SCALING</b><br/>
/// DXGITYPE.h
/// </summary>
public enum ModeScaling : uint {
	/// <summary>
	/// <b>DXGI_MODE_SCALING_UNSPECIFIED</b> = 0
	/// </summary>
	Unspecified = 0,
	/// <summary>
	/// <b>DXGI_MODE_SCALING_CENTERED</b> = 1
	/// </summary>
	Centered = 1,
	/// <summary>
	/// <b>DXGI_MODE_SCALING_STRETCHED</b> = 2
	/// </summary>
	Stretched = 2,
}

/// <summary>
/// ENUM <b>DXGI_MODE_ROTATION</b><br/>
/// DXGITYPE.h
/// </summary>
public enum ModeRotation : uint {
	/// <summary>
	/// <b>DXGI_MODE_ROTATION_UNSPECIFIED</b> = 0
	/// </summary>
	Unspecified = 0,
	/// <summary>
	/// <b>DXGI_MODE_ROTATION_IDENTITY</b> = 1
	/// </summary>
	Identity = 1,
	/// <summary>
	/// <b>DXGI_MODE_ROTATION_ROTATE90</b> = 2
	/// </summary>
	Rotate90 = 2,
	/// <summary>
	/// <b>DXGI_MODE_ROTATION_ROTATE180</b> = 3
	/// </summary>
	Rotate180 = 3,
	/// <summary>
	/// <b>DXGI_MODE_ROTATION_ROTATE270</b> = 4
	/// </summary>
	Rotate270 = 4,
}
