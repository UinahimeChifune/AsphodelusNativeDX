using System;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// ENUM <b>D2D1_GAMMA</b><br/>
/// D2D1.h
/// </summary>
public enum Gamma : uint {
	/// <summary>
	/// <b>D2D1_GAMMA_2_2</b> = 0
	/// </summary>
	Gamma22 = 0,
	/// <summary>
	/// <b>D2D1_GAMMA_1_0</b> = 1
	/// </summary>
	Gamma10 = 1,
}

/// <summary>
/// ENUM <b>D2D1_OPACITY_MASK_CONTENT</b><br/>
/// D2D1.h
/// </summary>
public enum OpacityMaskContent : uint {
	/// <summary>
	/// <b>D2D1_OPACITY_MASK_CONTENT_GRAPHICS</b> = 0
	/// </summary>
	Graphics = 0,
	/// <summary>
	/// <b>D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL</b> = 1
	/// </summary>
	TextNatural = 1,
	/// <summary>
	/// <b>D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE</b> = 2
	/// </summary>
	TextGdiCompatible = 2,
}

/// <summary>
/// ENUM <b>D2D1_EXTEND_MODE</b><br/>
/// D2D1.h
/// </summary>
public enum ExtendMode : uint {
	/// <summary>
	/// <b>D2D1_EXTEND_MODE_CLAMP</b> = 0
	/// </summary>
	Clamp = 0,
	/// <summary>
	/// <b>D2D1_EXTEND_MODE_WRAP</b> = 1
	/// </summary>
	Wrap = 1,
	/// <summary>
	/// <b>D2D1_EXTEND_MODE_MIRROR</b> = 2
	/// </summary>
	Mirror = 2,
}

/// <summary>
/// ENUM <b>D2D1_ANTIALIAS_MODE</b><br/>
/// D2D1.h
/// </summary>
public enum AntialiasMode : uint {
	/// <summary>
	/// <b>D2D1_ANTIALIAS_MODE_PER_PRIMITIVE</b> = 0
	/// </summary>
	PerPrimitive = 0,
	/// <summary>
	/// <b>D2D1_ANTIALIAS_MODE_ALIASED</b> = 1
	/// </summary>
	Aliased = 1,
}

/// <summary>
/// ENUM <b>D2D1_TEXT_ANTIALIAS_MODE</b><br/>
/// D2D1.h
/// </summary>
public enum TextAntialiasMode : uint {
	/// <summary>
	/// <b>D2D1_TEXT_ANTIALIAS_MODE_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE</b> = 1
	/// </summary>
	Cleartype = 1,
	/// <summary>
	/// <b>D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE</b> = 2
	/// </summary>
	Grayscale = 2,
	/// <summary>
	/// <b>D2D1_TEXT_ANTIALIAS_MODE_ALIASED</b> = 3
	/// </summary>
	Aliased = 3,
}

/// <summary>
/// ENUM <b>D2D1_BITMAP_INTERPOLATION_MODE</b><br/>
/// D2D1.h
/// </summary>
public enum BitmapInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR
	/// </summary>
	NearestNeighbor,
	/// <summary>
	/// <b>D2D1_BITMAP_INTERPOLATION_MODE_LINEAR</b> = D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR
	/// </summary>
	Linear,
}

/// <summary>
/// ENUM <b>D2D1_DRAW_TEXT_OPTIONS</b><br/>
/// D2D1.h
/// </summary>
[Flags]
public enum DrawTextOptions : uint {
	/// <summary>
	/// <b>D2D1_DRAW_TEXT_OPTIONS_NO_SNAP</b> = 0x00000001
	/// </summary>
	NoSnap = 1,
	/// <summary>
	/// <b>D2D1_DRAW_TEXT_OPTIONS_CLIP</b> = 0x00000002
	/// </summary>
	Clip = 2,
	/// <summary>
	/// <b>D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT</b> = 0x00000004
	/// </summary>
	EnableColorFont = 4,
	/// <summary>
	/// <b>D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING</b> = 0x00000008
	/// </summary>
	DisableColorBitmapSnapping = 8,
	/// <summary>
	/// <b>D2D1_DRAW_TEXT_OPTIONS_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
}

/// <summary>
/// ENUM <b>D2D1_ARC_SIZE</b><br/>
/// D2D1.h
/// </summary>
public enum ArcSize : uint {
	/// <summary>
	/// <b>D2D1_ARC_SIZE_SMALL</b> = 0
	/// </summary>
	Small = 0,
	/// <summary>
	/// <b>D2D1_ARC_SIZE_LARGE</b> = 1
	/// </summary>
	Large = 1,
}

/// <summary>
/// ENUM <b>D2D1_CAP_STYLE</b><br/>
/// D2D1.h
/// </summary>
public enum CapStyle : uint {
	/// <summary>
	/// <b>D2D1_CAP_STYLE_FLAT</b> = 0
	/// </summary>
	Flat = 0,
	/// <summary>
	/// <b>D2D1_CAP_STYLE_SQUARE</b> = 1
	/// </summary>
	Square = 1,
	/// <summary>
	/// <b>D2D1_CAP_STYLE_ROUND</b> = 2
	/// </summary>
	Round = 2,
	/// <summary>
	/// <b>D2D1_CAP_STYLE_TRIANGLE</b> = 3
	/// </summary>
	Triangle = 3,
}

/// <summary>
/// ENUM <b>D2D1_DASH_STYLE</b><br/>
/// D2D1.h
/// </summary>
public enum DashStyle : uint {
	/// <summary>
	/// <b>D2D1_DASH_STYLE_SOLID</b> = 0
	/// </summary>
	Solid = 0,
	/// <summary>
	/// <b>D2D1_DASH_STYLE_DASH</b> = 1
	/// </summary>
	Dash = 1,
	/// <summary>
	/// <b>D2D1_DASH_STYLE_DOT</b> = 2
	/// </summary>
	Dot = 2,
	/// <summary>
	/// <b>D2D1_DASH_STYLE_DASH_DOT</b> = 3
	/// </summary>
	DashDot = 3,
	/// <summary>
	/// <b>D2D1_DASH_STYLE_DASH_DOT_DOT</b> = 4
	/// </summary>
	DashDotDot = 4,
	/// <summary>
	/// <b>D2D1_DASH_STYLE_CUSTOM</b> = 5
	/// </summary>
	Custom = 5,
}

/// <summary>
/// ENUM <b>D2D1_LINE_JOIN</b><br/>
/// D2D1.h
/// </summary>
public enum LineJoin : uint {
	/// <summary>
	/// <b>D2D1_LINE_JOIN_MITER</b> = 0
	/// </summary>
	Miter = 0,
	/// <summary>
	/// <b>D2D1_LINE_JOIN_BEVEL</b> = 1
	/// </summary>
	Bevel = 1,
	/// <summary>
	/// <b>D2D1_LINE_JOIN_ROUND</b> = 2
	/// </summary>
	Round = 2,
	/// <summary>
	/// <b>D2D1_LINE_JOIN_MITER_OR_BEVEL</b> = 3
	/// </summary>
	MiterOrBevel = 3,
}

/// <summary>
/// ENUM <b>D2D1_COMBINE_MODE</b><br/>
/// D2D1.h
/// </summary>
public enum CombineMode : uint {
	/// <summary>
	/// <b>D2D1_COMBINE_MODE_UNION</b> = 0
	/// </summary>
	Union = 0,
	/// <summary>
	/// <b>D2D1_COMBINE_MODE_INTERSECT</b> = 1
	/// </summary>
	Intersect = 1,
	/// <summary>
	/// <b>D2D1_COMBINE_MODE_XOR</b> = 2
	/// </summary>
	Xor = 2,
	/// <summary>
	/// <b>D2D1_COMBINE_MODE_EXCLUDE</b> = 3
	/// </summary>
	Exclude = 3,
}

/// <summary>
/// ENUM <b>D2D1_GEOMETRY_RELATION</b><br/>
/// D2D1.h
/// </summary>
public enum GeometryRelation : uint {
	/// <summary>
	/// <b>D2D1_GEOMETRY_RELATION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D2D1_GEOMETRY_RELATION_DISJOINT</b> = 1
	/// </summary>
	Disjoint = 1,
	/// <summary>
	/// <b>D2D1_GEOMETRY_RELATION_IS_CONTAINED</b> = 2
	/// </summary>
	IsContained = 2,
	/// <summary>
	/// <b>D2D1_GEOMETRY_RELATION_CONTAINS</b> = 3
	/// </summary>
	Contains = 3,
	/// <summary>
	/// <b>D2D1_GEOMETRY_RELATION_OVERLAP</b> = 4
	/// </summary>
	Overlap = 4,
}

/// <summary>
/// ENUM <b>D2D1_GEOMETRY_SIMPLIFICATION_OPTION</b><br/>
/// D2D1.h
/// </summary>
public enum GeometrySimplificationOption : uint {
	/// <summary>
	/// <b>D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES</b> = 0
	/// </summary>
	CubicsAndLines = 0,
	/// <summary>
	/// <b>D2D1_GEOMETRY_SIMPLIFICATION_OPTION_LINES</b> = 1
	/// </summary>
	Lines = 1,
}

/// <summary>
/// ENUM <b>D2D1_FIGURE_BEGIN</b><br/>
/// D2D1.h
/// </summary>
public enum FigureBegin : uint {
	/// <summary>
	/// <b>D2D1_FIGURE_BEGIN_FILLED</b> = 0
	/// </summary>
	Filled = 0,
	/// <summary>
	/// <b>D2D1_FIGURE_BEGIN_HOLLOW</b> = 1
	/// </summary>
	Hollow = 1,
}

/// <summary>
/// ENUM <b>D2D1_FIGURE_END</b><br/>
/// D2D1.h
/// </summary>
public enum FigureEnd : uint {
	/// <summary>
	/// <b>D2D1_FIGURE_END_OPEN</b> = 0
	/// </summary>
	Open = 0,
	/// <summary>
	/// <b>D2D1_FIGURE_END_CLOSED</b> = 1
	/// </summary>
	Closed = 1,
}

/// <summary>
/// ENUM <b>D2D1_PATH_SEGMENT</b><br/>
/// D2D1.h
/// </summary>
[Flags]
public enum PathSegment : uint {
	/// <summary>
	/// <b>D2D1_PATH_SEGMENT_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_PATH_SEGMENT_FORCE_UNSTROKED</b> = 0x00000001
	/// </summary>
	ForceUnstroked = 1,
	/// <summary>
	/// <b>D2D1_PATH_SEGMENT_FORCE_ROUND_LINE_JOIN</b> = 0x00000002
	/// </summary>
	ForceRoundLineJoin = 2,
}

/// <summary>
/// ENUM <b>D2D1_SWEEP_DIRECTION</b><br/>
/// D2D1.h
/// </summary>
public enum SweepDirection : uint {
	/// <summary>
	/// <b>D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE</b> = 0
	/// </summary>
	CounterClockwise = 0,
	/// <summary>
	/// <b>D2D1_SWEEP_DIRECTION_CLOCKWISE</b> = 1
	/// </summary>
	Clockwise = 1,
}

/// <summary>
/// ENUM <b>D2D1_FILL_MODE</b><br/>
/// D2D1.h
/// </summary>
public enum FillMode : uint {
	/// <summary>
	/// <b>D2D1_FILL_MODE_ALTERNATE</b> = 0
	/// </summary>
	Alternate = 0,
	/// <summary>
	/// <b>D2D1_FILL_MODE_WINDING</b> = 1
	/// </summary>
	Winding = 1,
}

/// <summary>
/// ENUM <b>D2D1_LAYER_OPTIONS</b><br/>
/// D2D1.h
/// </summary>
public enum LayerOptions : uint {
	/// <summary>
	/// <b>D2D1_LAYER_OPTIONS_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE</b> = 0x00000001
	/// </summary>
	InitializeForCleartype = 1,
}

/// <summary>
/// ENUM <b>D2D1_WINDOW_STATE</b><br/>
/// D2D1.h
/// </summary>
public enum WindowState : uint {
	/// <summary>
	/// <b>D2D1_WINDOW_STATE_NONE</b> = 0x0000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_WINDOW_STATE_OCCLUDED</b> = 0x0000001
	/// </summary>
	Occluded = 1,
}

/// <summary>
/// ENUM <b>D2D1_RENDER_TARGET_TYPE</b><br/>
/// D2D1.h
/// </summary>
public enum RenderTargetType : uint {
	/// <summary>
	/// <b>D2D1_RENDER_TARGET_TYPE_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D2D1_RENDER_TARGET_TYPE_SOFTWARE</b> = 1
	/// </summary>
	Software = 1,
	/// <summary>
	/// <b>D2D1_RENDER_TARGET_TYPE_HARDWARE</b> = 2
	/// </summary>
	Hardware = 2,
}

/// <summary>
/// ENUM <b>D2D1_FEATURE_LEVEL</b><br/>
/// D2D1.h
/// </summary>
public enum FeatureLevel : uint {
	/// <summary>
	/// <b>D2D1_FEATURE_LEVEL_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D2D1_FEATURE_LEVEL_9</b> = D3D_FEATURE_LEVEL_9_1
	/// </summary>
	Level9 = Direct3D.FeatureLevel.Level91,
	/// <summary>
	/// <b>D2D1_FEATURE_LEVEL_10</b> = D3D_FEATURE_LEVEL_10_0
	/// </summary>
	Level10 = Direct3D.FeatureLevel.Level100,
}

/// <summary>
/// ENUM <b>D2D1_RENDER_TARGET_USAGE</b><br/>
/// D2D1.h
/// </summary>
public enum RenderTargetUsage : uint {
	/// <summary>
	/// <b>D2D1_RENDER_TARGET_USAGE_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING</b> = 0x00000001
	/// </summary>
	ForceBitmapRemoting = 1,
	/// <summary>
	/// <b>D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE</b> = 0x00000002
	/// </summary>
	GdiCompatible = 2,
}

/// <summary>
/// ENUM <b>D2D1_PRESENT_OPTIONS</b><br/>
/// D2D1.h
/// </summary>
public enum PresentOptions : uint {
	/// <summary>
	/// <b>D2D1_PRESENT_OPTIONS_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_PRESENT_OPTIONS_RETAIN_CONTENTS</b> = 0x00000001
	/// </summary>
	RetainContents = 1,
	/// <summary>
	/// <b>D2D1_PRESENT_OPTIONS_IMMEDIATELY</b> = 0x00000002
	/// </summary>
	Immediately = 2,
}

/// <summary>
/// ENUM <b>D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS</b><br/>
/// D2D1.h
/// </summary>
public enum CompatibleRenderTargetOptions : uint {
	/// <summary>
	/// <b>D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE</b> = 0x00000001
	/// </summary>
	GdiCompatible = 1,
}

/// <summary>
/// ENUM <b>D2D1_DC_INITIALIZE_MODE</b><br/>
/// D2D1.h
/// </summary>
public enum DcInitializeMode : uint {
	/// <summary>
	/// <b>D2D1_DC_INITIALIZE_MODE_COPY</b> = 0
	/// </summary>
	Copy = 0,
	/// <summary>
	/// <b>D2D1_DC_INITIALIZE_MODE_CLEAR</b> = 1
	/// </summary>
	Clear = 1,
}

/// <summary>
/// ENUM <b>D2D1_DEBUG_LEVEL</b><br/>
/// D2D1.h
/// </summary>
public enum DebugLevel : uint {
	/// <summary>
	/// <b>D2D1_DEBUG_LEVEL_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_DEBUG_LEVEL_ERROR</b> = 1
	/// </summary>
	Error = 1,
	/// <summary>
	/// <b>D2D1_DEBUG_LEVEL_WARNING</b> = 2
	/// </summary>
	Warning = 2,
	/// <summary>
	/// <b>D2D1_DEBUG_LEVEL_INFORMATION</b> = 3
	/// </summary>
	Information = 3,
}

/// <summary>
/// ENUM <b>D2D1_FACTORY_TYPE</b><br/>
/// D2D1.h
/// </summary>
public enum FactoryType : uint {
	/// <summary>
	/// <b>D2D1_FACTORY_TYPE_SINGLE_THREADED</b> = 0
	/// </summary>
	SingleThreaded = 0,
	/// <summary>
	/// <b>D2D1_FACTORY_TYPE_MULTI_THREADED</b> = 1
	/// </summary>
	MultiThreaded = 1,
}

/// <summary>
/// ENUM <b>D2D1_CHANGE_TYPE</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum ChangeType : uint {
	/// <summary>
	/// <b>D2D1_CHANGE_TYPE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_CHANGE_TYPE_PROPERTIES</b> = 1
	/// </summary>
	Properties = 1,
	/// <summary>
	/// <b>D2D1_CHANGE_TYPE_CONTEXT</b> = 2
	/// </summary>
	Context = 2,
	/// <summary>
	/// <b>D2D1_CHANGE_TYPE_GRAPH</b> = 3
	/// </summary>
	Graph = 3,
}

/// <summary>
/// ENUM <b>D2D1_PIXEL_OPTIONS</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum PixelOptions : uint {
	/// <summary>
	/// <b>D2D1_PIXEL_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_PIXEL_OPTIONS_TRIVIAL_SAMPLING</b> = 1
	/// </summary>
	TrivialSampling = 1,
}

/// <summary>
/// ENUM <b>D2D1_VERTEX_OPTIONS</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[Flags]
public enum VertexOptions : uint {
	/// <summary>
	/// <b>D2D1_VERTEX_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR</b> = 1
	/// </summary>
	DoNotClear = 1,
	/// <summary>
	/// <b>D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER</b> = 2
	/// </summary>
	UseDepthBuffer = 2,
	/// <summary>
	/// <b>D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP</b> = 4
	/// </summary>
	AssumeNoOverlap = 4,
}

/// <summary>
/// ENUM <b>D2D1_VERTEX_USAGE</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum VertexUsage : uint {
	/// <summary>
	/// <b>D2D1_VERTEX_USAGE_STATIC</b> = 0
	/// </summary>
	Static = 0,
	/// <summary>
	/// <b>D2D1_VERTEX_USAGE_DYNAMIC</b> = 1
	/// </summary>
	Dynamic = 1,
}

/// <summary>
/// ENUM <b>D2D1_BLEND_OPERATION</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum BlendOperation : uint {
	/// <summary>
	/// <b>D2D1_BLEND_OPERATION_ADD</b> = 1
	/// </summary>
	Add = 1,
	/// <summary>
	/// <b>D2D1_BLEND_OPERATION_SUBTRACT</b> = 2
	/// </summary>
	Subtract = 2,
	/// <summary>
	/// <b>D2D1_BLEND_OPERATION_REV_SUBTRACT</b> = 3
	/// </summary>
	RevSubtract = 3,
	/// <summary>
	/// <b>D2D1_BLEND_OPERATION_MIN</b> = 4
	/// </summary>
	Min = 4,
	/// <summary>
	/// <b>D2D1_BLEND_OPERATION_MAX</b> = 5
	/// </summary>
	Max = 5,
}

/// <summary>
/// ENUM <b>D2D1_BLEND</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum Blend : uint {
	/// <summary>
	/// <b>D2D1_BLEND_ZERO</b> = 1
	/// </summary>
	Zero = 1,
	/// <summary>
	/// <b>D2D1_BLEND_ONE</b> = 2
	/// </summary>
	One = 2,
	/// <summary>
	/// <b>D2D1_BLEND_SRC_COLOR</b> = 3
	/// </summary>
	SrcColor = 3,
	/// <summary>
	/// <b>D2D1_BLEND_INV_SRC_COLOR</b> = 4
	/// </summary>
	InvSrcColor = 4,
	/// <summary>
	/// <b>D2D1_BLEND_SRC_ALPHA</b> = 5
	/// </summary>
	SrcAlpha = 5,
	/// <summary>
	/// <b>D2D1_BLEND_INV_SRC_ALPHA</b> = 6
	/// </summary>
	InvSrcAlpha = 6,
	/// <summary>
	/// <b>D2D1_BLEND_DEST_ALPHA</b> = 7
	/// </summary>
	DestAlpha = 7,
	/// <summary>
	/// <b>D2D1_BLEND_INV_DEST_ALPHA</b> = 8
	/// </summary>
	InvDestAlpha = 8,
	/// <summary>
	/// <b>D2D1_BLEND_DEST_COLOR</b> = 9
	/// </summary>
	DestColor = 9,
	/// <summary>
	/// <b>D2D1_BLEND_INV_DEST_COLOR</b> = 10
	/// </summary>
	InvDestColor = 10,
	/// <summary>
	/// <b>D2D1_BLEND_SRC_ALPHA_SAT</b> = 11
	/// </summary>
	SrcAlphaSat = 11,
	/// <summary>
	/// <b>D2D1_BLEND_BLEND_FACTOR</b> = 14
	/// </summary>
	BlendFactor = 14,
	/// <summary>
	/// <b>D2D1_BLEND_INV_BLEND_FACTOR</b> = 15
	/// </summary>
	InvBlendFactor = 15,
}

/// <summary>
/// ENUM <b>D2D1_CHANNEL_DEPTH</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum ChannelDepth : uint {
	/// <summary>
	/// <b>D2D1_CHANNEL_DEPTH_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D2D1_CHANNEL_DEPTH_1</b> = 1
	/// </summary>
	Depth1 = 1,
	/// <summary>
	/// <b>D2D1_CHANNEL_DEPTH_4</b> = 4
	/// </summary>
	Depth4 = 4,
}

/// <summary>
/// ENUM <b>D2D1_FILTER</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum Filter : uint {
	/// <summary>
	/// <b>D2D1_FILTER_MIN_MAG_MIP_POINT</b> = 0x00
	/// </summary>
	MinMagMipPoint = 0,
	/// <summary>
	/// <b>D2D1_FILTER_MIN_MAG_POINT_MIP_LINEAR</b> = 0x01
	/// </summary>
	MinMagPointMipLinear = 1,
	/// <summary>
	/// <b>D2D1_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x04
	/// </summary>
	MinPointMagLinearMipPoint = 4,
	/// <summary>
	/// <b>D2D1_FILTER_MIN_POINT_MAG_MIP_LINEAR</b> = 0x05
	/// </summary>
	MinPointMagMipLinear = 5,
	/// <summary>
	/// <b>D2D1_FILTER_MIN_LINEAR_MAG_MIP_POINT</b> = 0x10
	/// </summary>
	MinLinearMagMipPoint = 16,
	/// <summary>
	/// <b>D2D1_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x11
	/// </summary>
	MinLinearMagPointMipLinear = 17,
	/// <summary>
	/// <b>D2D1_FILTER_MIN_MAG_LINEAR_MIP_POINT</b> = 0x14
	/// </summary>
	MinMagLinearMipPoint = 20,
	/// <summary>
	/// <b>D2D1_FILTER_MIN_MAG_MIP_LINEAR</b> = 0x15
	/// </summary>
	MinMagMipLinear = 21,
	/// <summary>
	/// <b>D2D1_FILTER_ANISOTROPIC</b> = 0x55
	/// </summary>
	Anisotropic = 85,
}

/// <summary>
/// ENUM <b>D2D1_FEATURE</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
public enum Feature : uint {
	/// <summary>
	/// <b>D2D1_FEATURE_DOUBLES</b> = 0
	/// </summary>
	Doubles = 0,
	/// <summary>
	/// <b>D2D1_FEATURE_D3D10_X_HARDWARE_OPTIONS</b> = 1
	/// </summary>
	D3d10XHardwareOptions = 1,
}

/// <summary>
/// ENUM <b>D2D1_BORDER_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BorderMode : uint {
	/// <summary>
	/// <b>D2D1_BORDER_MODE_SOFT</b> = 0
	/// </summary>
	Soft = 0,
	/// <summary>
	/// <b>D2D1_BORDER_MODE_HARD</b> = 1
	/// </summary>
	Hard = 1,
}

/// <summary>
/// ENUM <b>D2D1_CHANNEL_SELECTOR</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ChannelSelector : uint {
	/// <summary>
	/// <b>D2D1_CHANNEL_SELECTOR_R</b> = 0
	/// </summary>
	R = 0,
	/// <summary>
	/// <b>D2D1_CHANNEL_SELECTOR_G</b> = 1
	/// </summary>
	G = 1,
	/// <summary>
	/// <b>D2D1_CHANNEL_SELECTOR_B</b> = 2
	/// </summary>
	B = 2,
	/// <summary>
	/// <b>D2D1_CHANNEL_SELECTOR_A</b> = 3
	/// </summary>
	A = 3,
}

/// <summary>
/// ENUM <b>D2D1_BITMAPSOURCE_ORIENTATION</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BitmapsourceOrientation : uint {
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_DEFAULT</b> = 1
	/// </summary>
	Default = 1,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_FLIP_HORIZONTAL</b> = 2
	/// </summary>
	FlipHorizontal = 2,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180</b> = 3
	/// </summary>
	RotateClockwise180 = 3,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL</b> = 4
	/// </summary>
	RotateClockwise180FlipHorizontal = 4,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL</b> = 5
	/// </summary>
	RotateClockwise270FlipHorizontal = 5,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90</b> = 6
	/// </summary>
	RotateClockwise90 = 6,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL</b> = 7
	/// </summary>
	RotateClockwise90FlipHorizontal = 7,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270</b> = 8
	/// </summary>
	RotateClockwise270 = 8,
}

/// <summary>
/// ENUM <b>D2D1_GAUSSIANBLUR_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum GaussianblurProp : uint {
	/// <summary>
	/// <b>D2D1_GAUSSIANBLUR_PROP_STANDARD_DEVIATION</b> = 0
	/// </summary>
	StandardDeviation = 0,
	/// <summary>
	/// <b>D2D1_GAUSSIANBLUR_PROP_OPTIMIZATION</b> = 1
	/// </summary>
	Optimization = 1,
	/// <summary>
	/// <b>D2D1_GAUSSIANBLUR_PROP_BORDER_MODE</b> = 2
	/// </summary>
	BorderMode = 2,
}

/// <summary>
/// ENUM <b>D2D1_GAUSSIANBLUR_OPTIMIZATION</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum GaussianblurOptimization : uint {
	/// <summary>
	/// <b>D2D1_GAUSSIANBLUR_OPTIMIZATION_SPEED</b> = 0
	/// </summary>
	Speed = 0,
	/// <summary>
	/// <b>D2D1_GAUSSIANBLUR_OPTIMIZATION_BALANCED</b> = 1
	/// </summary>
	Balanced = 1,
	/// <summary>
	/// <b>D2D1_GAUSSIANBLUR_OPTIMIZATION_QUALITY</b> = 2
	/// </summary>
	Quality = 2,
}

/// <summary>
/// ENUM <b>D2D1_DIRECTIONALBLUR_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DirectionalblurProp : uint {
	/// <summary>
	/// <b>D2D1_DIRECTIONALBLUR_PROP_STANDARD_DEVIATION</b> = 0
	/// </summary>
	StandardDeviation = 0,
	/// <summary>
	/// <b>D2D1_DIRECTIONALBLUR_PROP_ANGLE</b> = 1
	/// </summary>
	Angle = 1,
	/// <summary>
	/// <b>D2D1_DIRECTIONALBLUR_PROP_OPTIMIZATION</b> = 2
	/// </summary>
	Optimization = 2,
	/// <summary>
	/// <b>D2D1_DIRECTIONALBLUR_PROP_BORDER_MODE</b> = 3
	/// </summary>
	BorderMode = 3,
}

/// <summary>
/// ENUM <b>D2D1_DIRECTIONALBLUR_OPTIMIZATION</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DirectionalblurOptimization : uint {
	/// <summary>
	/// <b>D2D1_DIRECTIONALBLUR_OPTIMIZATION_SPEED</b> = 0
	/// </summary>
	Speed = 0,
	/// <summary>
	/// <b>D2D1_DIRECTIONALBLUR_OPTIMIZATION_BALANCED</b> = 1
	/// </summary>
	Balanced = 1,
	/// <summary>
	/// <b>D2D1_DIRECTIONALBLUR_OPTIMIZATION_QUALITY</b> = 2
	/// </summary>
	Quality = 2,
}

/// <summary>
/// ENUM <b>D2D1_SHADOW_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ShadowProp : uint {
	/// <summary>
	/// <b>D2D1_SHADOW_PROP_BLUR_STANDARD_DEVIATION</b> = 0
	/// </summary>
	BlurStandardDeviation = 0,
	/// <summary>
	/// <b>D2D1_SHADOW_PROP_COLOR</b> = 1
	/// </summary>
	Color = 1,
	/// <summary>
	/// <b>D2D1_SHADOW_PROP_OPTIMIZATION</b> = 2
	/// </summary>
	Optimization = 2,
}

/// <summary>
/// ENUM <b>D2D1_SHADOW_OPTIMIZATION</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ShadowOptimization : uint {
	/// <summary>
	/// <b>D2D1_SHADOW_OPTIMIZATION_SPEED</b> = 0
	/// </summary>
	Speed = 0,
	/// <summary>
	/// <b>D2D1_SHADOW_OPTIMIZATION_BALANCED</b> = 1
	/// </summary>
	Balanced = 1,
	/// <summary>
	/// <b>D2D1_SHADOW_OPTIMIZATION_QUALITY</b> = 2
	/// </summary>
	Quality = 2,
}

/// <summary>
/// ENUM <b>D2D1_BLEND_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BlendProp : uint {
	/// <summary>
	/// <b>D2D1_BLEND_PROP_MODE</b> = 0
	/// </summary>
	Mode = 0,
}

/// <summary>
/// ENUM <b>D2D1_BLEND_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BlendMode : uint {
	/// <summary>
	/// <b>D2D1_BLEND_MODE_MULTIPLY</b> = 0
	/// </summary>
	Multiply = 0,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_SCREEN</b> = 1
	/// </summary>
	Screen = 1,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_DARKEN</b> = 2
	/// </summary>
	Darken = 2,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_LIGHTEN</b> = 3
	/// </summary>
	Lighten = 3,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_DISSOLVE</b> = 4
	/// </summary>
	Dissolve = 4,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_COLOR_BURN</b> = 5
	/// </summary>
	ColorBurn = 5,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_LINEAR_BURN</b> = 6
	/// </summary>
	LinearBurn = 6,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_DARKER_COLOR</b> = 7
	/// </summary>
	DarkerColor = 7,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_LIGHTER_COLOR</b> = 8
	/// </summary>
	LighterColor = 8,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_COLOR_DODGE</b> = 9
	/// </summary>
	ColorDodge = 9,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_LINEAR_DODGE</b> = 10
	/// </summary>
	LinearDodge = 10,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_OVERLAY</b> = 11
	/// </summary>
	Overlay = 11,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_SOFT_LIGHT</b> = 12
	/// </summary>
	SoftLight = 12,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_HARD_LIGHT</b> = 13
	/// </summary>
	HardLight = 13,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_VIVID_LIGHT</b> = 14
	/// </summary>
	VividLight = 14,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_LINEAR_LIGHT</b> = 15
	/// </summary>
	LinearLight = 15,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_PIN_LIGHT</b> = 16
	/// </summary>
	PinLight = 16,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_HARD_MIX</b> = 17
	/// </summary>
	HardMix = 17,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_DIFFERENCE</b> = 18
	/// </summary>
	Difference = 18,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_EXCLUSION</b> = 19
	/// </summary>
	Exclusion = 19,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_HUE</b> = 20
	/// </summary>
	Hue = 20,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_SATURATION</b> = 21
	/// </summary>
	Saturation = 21,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_COLOR</b> = 22
	/// </summary>
	Color = 22,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_LUMINOSITY</b> = 23
	/// </summary>
	Luminosity = 23,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_SUBTRACT</b> = 24
	/// </summary>
	Subtract = 24,
	/// <summary>
	/// <b>D2D1_BLEND_MODE_DIVISION</b> = 25
	/// </summary>
	Division = 25,
}

/// <summary>
/// ENUM <b>D2D1_SATURATION_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum SaturationProp : uint {
	/// <summary>
	/// <b>D2D1_SATURATION_PROP_SATURATION</b> = 0
	/// </summary>
	Saturation = 0,
}

/// <summary>
/// ENUM <b>D2D1_HUEROTATION_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum HuerotationProp : uint {
	/// <summary>
	/// <b>D2D1_HUEROTATION_PROP_ANGLE</b> = 0
	/// </summary>
	Angle = 0,
}

/// <summary>
/// ENUM <b>D2D1_COLORMATRIX_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ColormatrixProp : uint {
	/// <summary>
	/// <b>D2D1_COLORMATRIX_PROP_COLOR_MATRIX</b> = 0
	/// </summary>
	ColorMatrix = 0,
	/// <summary>
	/// <b>D2D1_COLORMATRIX_PROP_ALPHA_MODE</b> = 1
	/// </summary>
	AlphaMode = 1,
	/// <summary>
	/// <b>D2D1_COLORMATRIX_PROP_CLAMP_OUTPUT</b> = 2
	/// </summary>
	ClampOutput = 2,
}

/// <summary>
/// ENUM <b>D2D1_COLORMATRIX_ALPHA_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ColormatrixAlphaMode : uint {
	/// <summary>
	/// <b>D2D1_COLORMATRIX_ALPHA_MODE_PREMULTIPLIED</b> = 1
	/// </summary>
	Premultiplied = 1,
	/// <summary>
	/// <b>D2D1_COLORMATRIX_ALPHA_MODE_STRAIGHT</b> = 2
	/// </summary>
	Straight = 2,
}

/// <summary>
/// ENUM <b>D2D1_BITMAPSOURCE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BitmapsourceProp : uint {
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_PROP_WIC_BITMAP_SOURCE</b> = 0
	/// </summary>
	WicBitmapSource = 0,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_PROP_SCALE</b> = 1
	/// </summary>
	Scale = 1,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_PROP_INTERPOLATION_MODE</b> = 2
	/// </summary>
	InterpolationMode = 2,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_PROP_ENABLE_DPI_CORRECTION</b> = 3
	/// </summary>
	EnableDpiCorrection = 3,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_PROP_ALPHA_MODE</b> = 4
	/// </summary>
	AlphaMode = 4,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_PROP_ORIENTATION</b> = 5
	/// </summary>
	Orientation = 5,
}

/// <summary>
/// ENUM <b>D2D1_BITMAPSOURCE_INTERPOLATION_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BitmapsourceInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_INTERPOLATION_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_INTERPOLATION_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FANT</b> = 6
	/// </summary>
	Fant = 6,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_INTERPOLATION_MODE_MIPMAP_LINEAR</b> = 7
	/// </summary>
	MipmapLinear = 7,
}

/// <summary>
/// ENUM <b>D2D1_BITMAPSOURCE_ALPHA_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BitmapsourceAlphaMode : uint {
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ALPHA_MODE_PREMULTIPLIED</b> = 1
	/// </summary>
	Premultiplied = 1,
	/// <summary>
	/// <b>D2D1_BITMAPSOURCE_ALPHA_MODE_STRAIGHT</b> = 2
	/// </summary>
	Straight = 2,
}

/// <summary>
/// ENUM <b>D2D1_COMPOSITE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum CompositeProp : uint {
	/// <summary>
	/// <b>D2D1_COMPOSITE_PROP_MODE</b> = 0
	/// </summary>
	Mode = 0,
}

/// <summary>
/// ENUM <b>D2D1_3DTRANSFORM_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum _3DtransformProp : uint {
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_PROP_INTERPOLATION_MODE</b> = 0
	/// </summary>
	InterpolationMode = 0,
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_PROP_BORDER_MODE</b> = 1
	/// </summary>
	BorderMode = 1,
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_PROP_TRANSFORM_MATRIX</b> = 2
	/// </summary>
	TransformMatrix = 2,
}

/// <summary>
/// ENUM <b>D2D1_3DTRANSFORM_INTERPOLATION_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum _3DtransformInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_INTERPOLATION_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_INTERPOLATION_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_3DTRANSFORM_INTERPOLATION_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
}

/// <summary>
/// ENUM <b>D2D1_3DPERSPECTIVETRANSFORM_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum _3DperspectivetransformProp : uint {
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_INTERPOLATION_MODE</b> = 0
	/// </summary>
	InterpolationMode = 0,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_BORDER_MODE</b> = 1
	/// </summary>
	BorderMode = 1,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_DEPTH</b> = 2
	/// </summary>
	Depth = 2,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_PERSPECTIVE_ORIGIN</b> = 3
	/// </summary>
	PerspectiveOrigin = 3,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_LOCAL_OFFSET</b> = 4
	/// </summary>
	LocalOffset = 4,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_GLOBAL_OFFSET</b> = 5
	/// </summary>
	GlobalOffset = 5,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION_ORIGIN</b> = 6
	/// </summary>
	RotationOrigin = 6,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION</b> = 7
	/// </summary>
	Rotation = 7,
}

/// <summary>
/// ENUM <b>D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum _3DperspectivetransformInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
}

/// <summary>
/// ENUM <b>D2D1_2DAFFINETRANSFORM_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum _2DaffinetransformProp : uint {
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_PROP_INTERPOLATION_MODE</b> = 0
	/// </summary>
	InterpolationMode = 0,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_PROP_BORDER_MODE</b> = 1
	/// </summary>
	BorderMode = 1,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_PROP_TRANSFORM_MATRIX</b> = 2
	/// </summary>
	TransformMatrix = 2,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_PROP_SHARPNESS</b> = 3
	/// </summary>
	Sharpness = 3,
}

/// <summary>
/// ENUM <b>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum _2DaffinetransformInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_DPICOMPENSATION_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DpicompensationProp : uint {
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_PROP_INTERPOLATION_MODE</b> = 0
	/// </summary>
	InterpolationMode = 0,
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_PROP_BORDER_MODE</b> = 1
	/// </summary>
	BorderMode = 1,
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_PROP_INPUT_DPI</b> = 2
	/// </summary>
	InputDpi = 2,
}

/// <summary>
/// ENUM <b>D2D1_DPICOMPENSATION_INTERPOLATION_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DpicompensationInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_INTERPOLATION_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_INTERPOLATION_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_INTERPOLATION_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_DPICOMPENSATION_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_SCALE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ScaleProp : uint {
	/// <summary>
	/// <b>D2D1_SCALE_PROP_SCALE</b> = 0
	/// </summary>
	Scale = 0,
	/// <summary>
	/// <b>D2D1_SCALE_PROP_CENTER_POINT</b> = 1
	/// </summary>
	CenterPoint = 1,
	/// <summary>
	/// <b>D2D1_SCALE_PROP_INTERPOLATION_MODE</b> = 2
	/// </summary>
	InterpolationMode = 2,
	/// <summary>
	/// <b>D2D1_SCALE_PROP_BORDER_MODE</b> = 3
	/// </summary>
	BorderMode = 3,
	/// <summary>
	/// <b>D2D1_SCALE_PROP_SHARPNESS</b> = 4
	/// </summary>
	Sharpness = 4,
}

/// <summary>
/// ENUM <b>D2D1_SCALE_INTERPOLATION_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ScaleInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_SCALE_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_SCALE_INTERPOLATION_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_SCALE_INTERPOLATION_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_SCALE_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_SCALE_INTERPOLATION_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_SCALE_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_TURBULENCE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum TurbulenceProp : uint {
	/// <summary>
	/// <b>D2D1_TURBULENCE_PROP_OFFSET</b> = 0
	/// </summary>
	Offset = 0,
	/// <summary>
	/// <b>D2D1_TURBULENCE_PROP_SIZE</b> = 1
	/// </summary>
	Size = 1,
	/// <summary>
	/// <b>D2D1_TURBULENCE_PROP_BASE_FREQUENCY</b> = 2
	/// </summary>
	BaseFrequency = 2,
	/// <summary>
	/// <b>D2D1_TURBULENCE_PROP_NUM_OCTAVES</b> = 3
	/// </summary>
	NumOctaves = 3,
	/// <summary>
	/// <b>D2D1_TURBULENCE_PROP_SEED</b> = 4
	/// </summary>
	Seed = 4,
	/// <summary>
	/// <b>D2D1_TURBULENCE_PROP_NOISE</b> = 5
	/// </summary>
	Noise = 5,
	/// <summary>
	/// <b>D2D1_TURBULENCE_PROP_STITCHABLE</b> = 6
	/// </summary>
	Stitchable = 6,
}

/// <summary>
/// ENUM <b>D2D1_TURBULENCE_NOISE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum TurbulenceNoise : uint {
	/// <summary>
	/// <b>D2D1_TURBULENCE_NOISE_FRACTAL_SUM</b> = 0
	/// </summary>
	FractalSum = 0,
	/// <summary>
	/// <b>D2D1_TURBULENCE_NOISE_TURBULENCE</b> = 1
	/// </summary>
	Turbulence = 1,
}

/// <summary>
/// ENUM <b>D2D1_DISPLACEMENTMAP_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DisplacementmapProp : uint {
	/// <summary>
	/// <b>D2D1_DISPLACEMENTMAP_PROP_SCALE</b> = 0
	/// </summary>
	Scale = 0,
	/// <summary>
	/// <b>D2D1_DISPLACEMENTMAP_PROP_X_CHANNEL_SELECT</b> = 1
	/// </summary>
	XChannelSelect = 1,
	/// <summary>
	/// <b>D2D1_DISPLACEMENTMAP_PROP_Y_CHANNEL_SELECT</b> = 2
	/// </summary>
	YChannelSelect = 2,
}

/// <summary>
/// ENUM <b>D2D1_COLORMANAGEMENT_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ColormanagementProp : uint {
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT</b> = 0
	/// </summary>
	SourceColorContext = 0,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT</b> = 1
	/// </summary>
	SourceRenderingIntent = 1,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT</b> = 2
	/// </summary>
	DestinationColorContext = 2,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT</b> = 3
	/// </summary>
	DestinationRenderingIntent = 3,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE</b> = 4
	/// </summary>
	AlphaMode = 4,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_PROP_QUALITY</b> = 5
	/// </summary>
	Quality = 5,
}

/// <summary>
/// ENUM <b>D2D1_COLORMANAGEMENT_ALPHA_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ColormanagementAlphaMode : uint {
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_ALPHA_MODE_PREMULTIPLIED</b> = 1
	/// </summary>
	Premultiplied = 1,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_ALPHA_MODE_STRAIGHT</b> = 2
	/// </summary>
	Straight = 2,
}

/// <summary>
/// ENUM <b>D2D1_COLORMANAGEMENT_QUALITY</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ColormanagementQuality : uint {
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_QUALITY_PROOF</b> = 0
	/// </summary>
	Proof = 0,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_QUALITY_NORMAL</b> = 1
	/// </summary>
	Normal = 1,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_QUALITY_BEST</b> = 2
	/// </summary>
	Best = 2,
}

/// <summary>
/// ENUM <b>D2D1_COLORMANAGEMENT_RENDERING_INTENT</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ColormanagementRenderingIntent : uint {
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL</b> = 0
	/// </summary>
	Perceptual = 0,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_RENDERING_INTENT_RELATIVE_COLORIMETRIC</b> = 1
	/// </summary>
	RelativeColorimetric = 1,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_RENDERING_INTENT_SATURATION</b> = 2
	/// </summary>
	Saturation = 2,
	/// <summary>
	/// <b>D2D1_COLORMANAGEMENT_RENDERING_INTENT_ABSOLUTE_COLORIMETRIC</b> = 3
	/// </summary>
	AbsoluteColorimetric = 3,
}

/// <summary>
/// ENUM <b>D2D1_HISTOGRAM_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum HistogramProp : uint {
	/// <summary>
	/// <b>D2D1_HISTOGRAM_PROP_NUM_BINS</b> = 0
	/// </summary>
	NumBins = 0,
	/// <summary>
	/// <b>D2D1_HISTOGRAM_PROP_CHANNEL_SELECT</b> = 1
	/// </summary>
	ChannelSelect = 1,
	/// <summary>
	/// <b>D2D1_HISTOGRAM_PROP_HISTOGRAM_OUTPUT</b> = 2
	/// </summary>
	HistogramOutput = 2,
}

/// <summary>
/// ENUM <b>D2D1_POINTSPECULAR_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum PointspecularProp : uint {
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_PROP_LIGHT_POSITION</b> = 0
	/// </summary>
	LightPosition = 0,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_PROP_SPECULAR_EXPONENT</b> = 1
	/// </summary>
	SpecularExponent = 1,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_PROP_SPECULAR_CONSTANT</b> = 2
	/// </summary>
	SpecularConstant = 2,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_PROP_SURFACE_SCALE</b> = 3
	/// </summary>
	SurfaceScale = 3,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_PROP_COLOR</b> = 4
	/// </summary>
	Color = 4,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_PROP_KERNEL_UNIT_LENGTH</b> = 5
	/// </summary>
	KernelUnitLength = 5,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_PROP_SCALE_MODE</b> = 6
	/// </summary>
	ScaleMode = 6,
}

/// <summary>
/// ENUM <b>D2D1_POINTSPECULAR_SCALE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum PointspecularScaleMode : uint {
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_POINTSPECULAR_SCALE_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_SPOTSPECULAR_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum SpotspecularProp : uint {
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_LIGHT_POSITION</b> = 0
	/// </summary>
	LightPosition = 0,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_POINTS_AT</b> = 1
	/// </summary>
	PointsAt = 1,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_FOCUS</b> = 2
	/// </summary>
	Focus = 2,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_LIMITING_CONE_ANGLE</b> = 3
	/// </summary>
	LimitingConeAngle = 3,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_SPECULAR_EXPONENT</b> = 4
	/// </summary>
	SpecularExponent = 4,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_SPECULAR_CONSTANT</b> = 5
	/// </summary>
	SpecularConstant = 5,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_SURFACE_SCALE</b> = 6
	/// </summary>
	SurfaceScale = 6,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_COLOR</b> = 7
	/// </summary>
	Color = 7,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_KERNEL_UNIT_LENGTH</b> = 8
	/// </summary>
	KernelUnitLength = 8,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_PROP_SCALE_MODE</b> = 9
	/// </summary>
	ScaleMode = 9,
}

/// <summary>
/// ENUM <b>D2D1_SPOTSPECULAR_SCALE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum SpotspecularScaleMode : uint {
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_SPOTSPECULAR_SCALE_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_DISTANTSPECULAR_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DistantspecularProp : uint {
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_AZIMUTH</b> = 0
	/// </summary>
	Azimuth = 0,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_ELEVATION</b> = 1
	/// </summary>
	Elevation = 1,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_SPECULAR_EXPONENT</b> = 2
	/// </summary>
	SpecularExponent = 2,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_SPECULAR_CONSTANT</b> = 3
	/// </summary>
	SpecularConstant = 3,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_SURFACE_SCALE</b> = 4
	/// </summary>
	SurfaceScale = 4,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_COLOR</b> = 5
	/// </summary>
	Color = 5,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_KERNEL_UNIT_LENGTH</b> = 6
	/// </summary>
	KernelUnitLength = 6,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_PROP_SCALE_MODE</b> = 7
	/// </summary>
	ScaleMode = 7,
}

/// <summary>
/// ENUM <b>D2D1_DISTANTSPECULAR_SCALE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DistantspecularScaleMode : uint {
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_DISTANTSPECULAR_SCALE_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_POINTDIFFUSE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum PointdiffuseProp : uint {
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_PROP_LIGHT_POSITION</b> = 0
	/// </summary>
	LightPosition = 0,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_PROP_DIFFUSE_CONSTANT</b> = 1
	/// </summary>
	DiffuseConstant = 1,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_PROP_SURFACE_SCALE</b> = 2
	/// </summary>
	SurfaceScale = 2,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_PROP_COLOR</b> = 3
	/// </summary>
	Color = 3,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_PROP_KERNEL_UNIT_LENGTH</b> = 4
	/// </summary>
	KernelUnitLength = 4,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_PROP_SCALE_MODE</b> = 5
	/// </summary>
	ScaleMode = 5,
}

/// <summary>
/// ENUM <b>D2D1_POINTDIFFUSE_SCALE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum PointdiffuseScaleMode : uint {
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_POINTDIFFUSE_SCALE_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_SPOTDIFFUSE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum SpotdiffuseProp : uint {
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_LIGHT_POSITION</b> = 0
	/// </summary>
	LightPosition = 0,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_POINTS_AT</b> = 1
	/// </summary>
	PointsAt = 1,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_FOCUS</b> = 2
	/// </summary>
	Focus = 2,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_LIMITING_CONE_ANGLE</b> = 3
	/// </summary>
	LimitingConeAngle = 3,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_DIFFUSE_CONSTANT</b> = 4
	/// </summary>
	DiffuseConstant = 4,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_SURFACE_SCALE</b> = 5
	/// </summary>
	SurfaceScale = 5,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_COLOR</b> = 6
	/// </summary>
	Color = 6,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_KERNEL_UNIT_LENGTH</b> = 7
	/// </summary>
	KernelUnitLength = 7,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_PROP_SCALE_MODE</b> = 8
	/// </summary>
	ScaleMode = 8,
}

/// <summary>
/// ENUM <b>D2D1_SPOTDIFFUSE_SCALE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum SpotdiffuseScaleMode : uint {
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_SPOTDIFFUSE_SCALE_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_DISTANTDIFFUSE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DistantdiffuseProp : uint {
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_PROP_AZIMUTH</b> = 0
	/// </summary>
	Azimuth = 0,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_PROP_ELEVATION</b> = 1
	/// </summary>
	Elevation = 1,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_PROP_DIFFUSE_CONSTANT</b> = 2
	/// </summary>
	DiffuseConstant = 2,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_PROP_SURFACE_SCALE</b> = 3
	/// </summary>
	SurfaceScale = 3,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_PROP_COLOR</b> = 4
	/// </summary>
	Color = 4,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_PROP_KERNEL_UNIT_LENGTH</b> = 5
	/// </summary>
	KernelUnitLength = 5,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_PROP_SCALE_MODE</b> = 6
	/// </summary>
	ScaleMode = 6,
}

/// <summary>
/// ENUM <b>D2D1_DISTANTDIFFUSE_SCALE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DistantdiffuseScaleMode : uint {
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_DISTANTDIFFUSE_SCALE_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_FLOOD_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum FloodProp : uint {
	/// <summary>
	/// <b>D2D1_FLOOD_PROP_COLOR</b> = 0
	/// </summary>
	Color = 0,
}

/// <summary>
/// ENUM <b>D2D1_LINEARTRANSFER_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum LineartransferProp : uint {
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT</b> = 0
	/// </summary>
	RedYIntercept = 0,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_RED_SLOPE</b> = 1
	/// </summary>
	RedSlope = 1,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_RED_DISABLE</b> = 2
	/// </summary>
	RedDisable = 2,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT</b> = 3
	/// </summary>
	GreenYIntercept = 3,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE</b> = 4
	/// </summary>
	GreenSlope = 4,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE</b> = 5
	/// </summary>
	GreenDisable = 5,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT</b> = 6
	/// </summary>
	BlueYIntercept = 6,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE</b> = 7
	/// </summary>
	BlueSlope = 7,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE</b> = 8
	/// </summary>
	BlueDisable = 8,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT</b> = 9
	/// </summary>
	AlphaYIntercept = 9,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE</b> = 10
	/// </summary>
	AlphaSlope = 10,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE</b> = 11
	/// </summary>
	AlphaDisable = 11,
	/// <summary>
	/// <b>D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT</b> = 12
	/// </summary>
	ClampOutput = 12,
}

/// <summary>
/// ENUM <b>D2D1_GAMMATRANSFER_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum GammatransferProp : uint {
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_RED_AMPLITUDE</b> = 0
	/// </summary>
	RedAmplitude = 0,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_RED_EXPONENT</b> = 1
	/// </summary>
	RedExponent = 1,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_RED_OFFSET</b> = 2
	/// </summary>
	RedOffset = 2,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_RED_DISABLE</b> = 3
	/// </summary>
	RedDisable = 3,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_GREEN_AMPLITUDE</b> = 4
	/// </summary>
	GreenAmplitude = 4,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_GREEN_EXPONENT</b> = 5
	/// </summary>
	GreenExponent = 5,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_GREEN_OFFSET</b> = 6
	/// </summary>
	GreenOffset = 6,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_GREEN_DISABLE</b> = 7
	/// </summary>
	GreenDisable = 7,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_BLUE_AMPLITUDE</b> = 8
	/// </summary>
	BlueAmplitude = 8,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_BLUE_EXPONENT</b> = 9
	/// </summary>
	BlueExponent = 9,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_BLUE_OFFSET</b> = 10
	/// </summary>
	BlueOffset = 10,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_BLUE_DISABLE</b> = 11
	/// </summary>
	BlueDisable = 11,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_ALPHA_AMPLITUDE</b> = 12
	/// </summary>
	AlphaAmplitude = 12,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_ALPHA_EXPONENT</b> = 13
	/// </summary>
	AlphaExponent = 13,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_ALPHA_OFFSET</b> = 14
	/// </summary>
	AlphaOffset = 14,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_ALPHA_DISABLE</b> = 15
	/// </summary>
	AlphaDisable = 15,
	/// <summary>
	/// <b>D2D1_GAMMATRANSFER_PROP_CLAMP_OUTPUT</b> = 16
	/// </summary>
	ClampOutput = 16,
}

/// <summary>
/// ENUM <b>D2D1_TABLETRANSFER_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum TabletransferProp : uint {
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_RED_TABLE</b> = 0
	/// </summary>
	RedTable = 0,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_RED_DISABLE</b> = 1
	/// </summary>
	RedDisable = 1,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_GREEN_TABLE</b> = 2
	/// </summary>
	GreenTable = 2,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_GREEN_DISABLE</b> = 3
	/// </summary>
	GreenDisable = 3,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_BLUE_TABLE</b> = 4
	/// </summary>
	BlueTable = 4,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_BLUE_DISABLE</b> = 5
	/// </summary>
	BlueDisable = 5,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_ALPHA_TABLE</b> = 6
	/// </summary>
	AlphaTable = 6,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_ALPHA_DISABLE</b> = 7
	/// </summary>
	AlphaDisable = 7,
	/// <summary>
	/// <b>D2D1_TABLETRANSFER_PROP_CLAMP_OUTPUT</b> = 8
	/// </summary>
	ClampOutput = 8,
}

/// <summary>
/// ENUM <b>D2D1_DISCRETETRANSFER_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum DiscretetransferProp : uint {
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_RED_TABLE</b> = 0
	/// </summary>
	RedTable = 0,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_RED_DISABLE</b> = 1
	/// </summary>
	RedDisable = 1,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_GREEN_TABLE</b> = 2
	/// </summary>
	GreenTable = 2,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_GREEN_DISABLE</b> = 3
	/// </summary>
	GreenDisable = 3,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_BLUE_TABLE</b> = 4
	/// </summary>
	BlueTable = 4,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_BLUE_DISABLE</b> = 5
	/// </summary>
	BlueDisable = 5,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_ALPHA_TABLE</b> = 6
	/// </summary>
	AlphaTable = 6,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_ALPHA_DISABLE</b> = 7
	/// </summary>
	AlphaDisable = 7,
	/// <summary>
	/// <b>D2D1_DISCRETETRANSFER_PROP_CLAMP_OUTPUT</b> = 8
	/// </summary>
	ClampOutput = 8,
}

/// <summary>
/// ENUM <b>D2D1_CONVOLVEMATRIX_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ConvolvematrixProp : uint {
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_KERNEL_UNIT_LENGTH</b> = 0
	/// </summary>
	KernelUnitLength = 0,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_SCALE_MODE</b> = 1
	/// </summary>
	ScaleMode = 1,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_X</b> = 2
	/// </summary>
	KernelSizeX = 2,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_Y</b> = 3
	/// </summary>
	KernelSizeY = 3,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_KERNEL_MATRIX</b> = 4
	/// </summary>
	KernelMatrix = 4,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_DIVISOR</b> = 5
	/// </summary>
	Divisor = 5,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_BIAS</b> = 6
	/// </summary>
	Bias = 6,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_KERNEL_OFFSET</b> = 7
	/// </summary>
	KernelOffset = 7,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_PRESERVE_ALPHA</b> = 8
	/// </summary>
	PreserveAlpha = 8,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_BORDER_MODE</b> = 9
	/// </summary>
	BorderMode = 9,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_PROP_CLAMP_OUTPUT</b> = 10
	/// </summary>
	ClampOutput = 10,
}

/// <summary>
/// ENUM <b>D2D1_CONVOLVEMATRIX_SCALE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ConvolvematrixScaleMode : uint {
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_CONVOLVEMATRIX_SCALE_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_BRIGHTNESS_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BrightnessProp : uint {
	/// <summary>
	/// <b>D2D1_BRIGHTNESS_PROP_WHITE_POINT</b> = 0
	/// </summary>
	WhitePoint = 0,
	/// <summary>
	/// <b>D2D1_BRIGHTNESS_PROP_BLACK_POINT</b> = 1
	/// </summary>
	BlackPoint = 1,
}

/// <summary>
/// ENUM <b>D2D1_ARITHMETICCOMPOSITE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum ArithmeticcompositeProp : uint {
	/// <summary>
	/// <b>D2D1_ARITHMETICCOMPOSITE_PROP_COEFFICIENTS</b> = 0
	/// </summary>
	Coefficients = 0,
	/// <summary>
	/// <b>D2D1_ARITHMETICCOMPOSITE_PROP_CLAMP_OUTPUT</b> = 1
	/// </summary>
	ClampOutput = 1,
}

/// <summary>
/// ENUM <b>D2D1_CROP_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum CropProp : uint {
	/// <summary>
	/// <b>D2D1_CROP_PROP_RECT</b> = 0
	/// </summary>
	Rect = 0,
	/// <summary>
	/// <b>D2D1_CROP_PROP_BORDER_MODE</b> = 1
	/// </summary>
	BorderMode = 1,
}

/// <summary>
/// ENUM <b>D2D1_BORDER_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BorderProp : uint {
	/// <summary>
	/// <b>D2D1_BORDER_PROP_EDGE_MODE_X</b> = 0
	/// </summary>
	EdgeModeX = 0,
	/// <summary>
	/// <b>D2D1_BORDER_PROP_EDGE_MODE_Y</b> = 1
	/// </summary>
	EdgeModeY = 1,
}

/// <summary>
/// ENUM <b>D2D1_BORDER_EDGE_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum BorderEdgeMode : uint {
	/// <summary>
	/// <b>D2D1_BORDER_EDGE_MODE_CLAMP</b> = 0
	/// </summary>
	Clamp = 0,
	/// <summary>
	/// <b>D2D1_BORDER_EDGE_MODE_WRAP</b> = 1
	/// </summary>
	Wrap = 1,
	/// <summary>
	/// <b>D2D1_BORDER_EDGE_MODE_MIRROR</b> = 2
	/// </summary>
	Mirror = 2,
}

/// <summary>
/// ENUM <b>D2D1_MORPHOLOGY_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum MorphologyProp : uint {
	/// <summary>
	/// <b>D2D1_MORPHOLOGY_PROP_MODE</b> = 0
	/// </summary>
	Mode = 0,
	/// <summary>
	/// <b>D2D1_MORPHOLOGY_PROP_WIDTH</b> = 1
	/// </summary>
	Width = 1,
	/// <summary>
	/// <b>D2D1_MORPHOLOGY_PROP_HEIGHT</b> = 2
	/// </summary>
	Height = 2,
}

/// <summary>
/// ENUM <b>D2D1_MORPHOLOGY_MODE</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum MorphologyMode : uint {
	/// <summary>
	/// <b>D2D1_MORPHOLOGY_MODE_ERODE</b> = 0
	/// </summary>
	Erode = 0,
	/// <summary>
	/// <b>D2D1_MORPHOLOGY_MODE_DILATE</b> = 1
	/// </summary>
	Dilate = 1,
}

/// <summary>
/// ENUM <b>D2D1_TILE_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum TileProp : uint {
	/// <summary>
	/// <b>D2D1_TILE_PROP_RECT</b> = 0
	/// </summary>
	Rect = 0,
}

/// <summary>
/// ENUM <b>D2D1_ATLAS_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum AtlasProp : uint {
	/// <summary>
	/// <b>D2D1_ATLAS_PROP_INPUT_RECT</b> = 0
	/// </summary>
	InputRect = 0,
	/// <summary>
	/// <b>D2D1_ATLAS_PROP_INPUT_PADDING_RECT</b> = 1
	/// </summary>
	InputPaddingRect = 1,
}

/// <summary>
/// ENUM <b>D2D1_OPACITYMETADATA_PROP</b><br/>
/// D2D1EFFECTS.h
/// </summary>
public enum OpacitymetadataProp : uint {
	/// <summary>
	/// <b>D2D1_OPACITYMETADATA_PROP_INPUT_OPAQUE_RECT</b> = 0
	/// </summary>
	InputOpaqueRect = 0,
}

/// <summary>
/// ENUM <b>D2D1_YCBCR_PROP</b><br/>
/// D2D1EFFECTS_1.h
/// </summary>
public enum YcbcrProp : uint {
	/// <summary>
	/// <b>D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING</b> = 0
	/// </summary>
	ChromaSubsampling = 0,
	/// <summary>
	/// <b>D2D1_YCBCR_PROP_TRANSFORM_MATRIX</b> = 1
	/// </summary>
	TransformMatrix = 1,
	/// <summary>
	/// <b>D2D1_YCBCR_PROP_INTERPOLATION_MODE</b> = 2
	/// </summary>
	InterpolationMode = 2,
}

/// <summary>
/// ENUM <b>D2D1_YCBCR_CHROMA_SUBSAMPLING</b><br/>
/// D2D1EFFECTS_1.h
/// </summary>
public enum YcbcrChromaSubsampling : uint {
	/// <summary>
	/// <b>D2D1_YCBCR_CHROMA_SUBSAMPLING_AUTO</b> = 0
	/// </summary>
	Auto = 0,
	/// <summary>
	/// <b>D2D1_YCBCR_CHROMA_SUBSAMPLING_420</b> = 1
	/// </summary>
	Subsampling420 = 1,
	/// <summary>
	/// <b>D2D1_YCBCR_CHROMA_SUBSAMPLING_422</b> = 2
	/// </summary>
	Subsampling422 = 2,
	/// <summary>
	/// <b>D2D1_YCBCR_CHROMA_SUBSAMPLING_444</b> = 3
	/// </summary>
	Subsampling444 = 3,
	/// <summary>
	/// <b>D2D1_YCBCR_CHROMA_SUBSAMPLING_440</b> = 4
	/// </summary>
	Subsampling440 = 4,
}

/// <summary>
/// ENUM <b>D2D1_YCBCR_INTERPOLATION_MODE</b><br/>
/// D2D1EFFECTS_1.h
/// </summary>
public enum YcbcrInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_YCBCR_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_YCBCR_INTERPOLATION_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_YCBCR_INTERPOLATION_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_YCBCR_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_YCBCR_INTERPOLATION_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
	/// <summary>
	/// <b>D2D1_YCBCR_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC</b> = 5
	/// </summary>
	HighQualityCubic = 5,
}

/// <summary>
/// ENUM <b>D2D1_CONTRAST_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum ContrastProp : uint {
	/// <summary>
	/// <b>D2D1_CONTRAST_PROP_CONTRAST</b> = 0
	/// </summary>
	Contrast = 0,
	/// <summary>
	/// <b>D2D1_CONTRAST_PROP_CLAMP_INPUT</b> = 1
	/// </summary>
	ClampInput = 1,
}

/// <summary>
/// ENUM <b>D2D1_RGBTOHUE_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum RgbtohueProp : uint {
	/// <summary>
	/// <b>D2D1_RGBTOHUE_PROP_OUTPUT_COLOR_SPACE</b> = 0
	/// </summary>
	OutputColorSpace = 0,
}

/// <summary>
/// ENUM <b>D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum RgbtohueOutputColorSpace : uint {
	/// <summary>
	/// <b>D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_HUE_SATURATION_VALUE</b> = 0
	/// </summary>
	HueSaturationValue = 0,
	/// <summary>
	/// <b>D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_HUE_SATURATION_LIGHTNESS</b> = 1
	/// </summary>
	HueSaturationLightness = 1,
}

/// <summary>
/// ENUM <b>D2D1_HUETORGB_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum HuetorgbProp : uint {
	/// <summary>
	/// <b>D2D1_HUETORGB_PROP_INPUT_COLOR_SPACE</b> = 0
	/// </summary>
	InputColorSpace = 0,
}

/// <summary>
/// ENUM <b>D2D1_HUETORGB_INPUT_COLOR_SPACE</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum HuetorgbInputColorSpace : uint {
	/// <summary>
	/// <b>D2D1_HUETORGB_INPUT_COLOR_SPACE_HUE_SATURATION_VALUE</b> = 0
	/// </summary>
	HueSaturationValue = 0,
	/// <summary>
	/// <b>D2D1_HUETORGB_INPUT_COLOR_SPACE_HUE_SATURATION_LIGHTNESS</b> = 1
	/// </summary>
	HueSaturationLightness = 1,
}

/// <summary>
/// ENUM <b>D2D1_CHROMAKEY_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum ChromakeyProp : uint {
	/// <summary>
	/// <b>D2D1_CHROMAKEY_PROP_COLOR</b> = 0
	/// </summary>
	Color = 0,
	/// <summary>
	/// <b>D2D1_CHROMAKEY_PROP_TOLERANCE</b> = 1
	/// </summary>
	Tolerance = 1,
	/// <summary>
	/// <b>D2D1_CHROMAKEY_PROP_INVERT_ALPHA</b> = 2
	/// </summary>
	InvertAlpha = 2,
	/// <summary>
	/// <b>D2D1_CHROMAKEY_PROP_FEATHER</b> = 3
	/// </summary>
	Feather = 3,
}

/// <summary>
/// ENUM <b>D2D1_EMBOSS_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum EmbossProp : uint {
	/// <summary>
	/// <b>D2D1_EMBOSS_PROP_HEIGHT</b> = 0
	/// </summary>
	Height = 0,
	/// <summary>
	/// <b>D2D1_EMBOSS_PROP_DIRECTION</b> = 1
	/// </summary>
	Direction = 1,
}

/// <summary>
/// ENUM <b>D2D1_EXPOSURE_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum ExposureProp : uint {
	/// <summary>
	/// <b>D2D1_EXPOSURE_PROP_EXPOSURE_VALUE</b> = 0
	/// </summary>
	ExposureValue = 0,
}

/// <summary>
/// ENUM <b>D2D1_POSTERIZE_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum PosterizeProp : uint {
	/// <summary>
	/// <b>D2D1_POSTERIZE_PROP_RED_VALUE_COUNT</b> = 0
	/// </summary>
	RedValueCount = 0,
	/// <summary>
	/// <b>D2D1_POSTERIZE_PROP_GREEN_VALUE_COUNT</b> = 1
	/// </summary>
	GreenValueCount = 1,
	/// <summary>
	/// <b>D2D1_POSTERIZE_PROP_BLUE_VALUE_COUNT</b> = 2
	/// </summary>
	BlueValueCount = 2,
}

/// <summary>
/// ENUM <b>D2D1_SEPIA_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum SepiaProp : uint {
	/// <summary>
	/// <b>D2D1_SEPIA_PROP_INTENSITY</b> = 0
	/// </summary>
	Intensity = 0,
	/// <summary>
	/// <b>D2D1_SEPIA_PROP_ALPHA_MODE</b> = 1
	/// </summary>
	AlphaMode = 1,
}

/// <summary>
/// ENUM <b>D2D1_SHARPEN_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum SharpenProp : uint {
	/// <summary>
	/// <b>D2D1_SHARPEN_PROP_SHARPNESS</b> = 0
	/// </summary>
	Sharpness = 0,
	/// <summary>
	/// <b>D2D1_SHARPEN_PROP_THRESHOLD</b> = 1
	/// </summary>
	Threshold = 1,
}

/// <summary>
/// ENUM <b>D2D1_STRAIGHTEN_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum StraightenProp : uint {
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_PROP_ANGLE</b> = 0
	/// </summary>
	Angle = 0,
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_PROP_MAINTAIN_SIZE</b> = 1
	/// </summary>
	MaintainSize = 1,
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_PROP_SCALE_MODE</b> = 2
	/// </summary>
	ScaleMode = 2,
}

/// <summary>
/// ENUM <b>D2D1_STRAIGHTEN_SCALE_MODE</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum StraightenScaleMode : uint {
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_SCALE_MODE_NEAREST_NEIGHBOR</b> = 0
	/// </summary>
	NearestNeighbor = 0,
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_SCALE_MODE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_SCALE_MODE_CUBIC</b> = 2
	/// </summary>
	Cubic = 2,
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_SCALE_MODE_MULTI_SAMPLE_LINEAR</b> = 3
	/// </summary>
	MultiSampleLinear = 3,
	/// <summary>
	/// <b>D2D1_STRAIGHTEN_SCALE_MODE_ANISOTROPIC</b> = 4
	/// </summary>
	Anisotropic = 4,
}

/// <summary>
/// ENUM <b>D2D1_TEMPERATUREANDTINT_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum TemperatureandtintProp : uint {
	/// <summary>
	/// <b>D2D1_TEMPERATUREANDTINT_PROP_TEMPERATURE</b> = 0
	/// </summary>
	Temperature = 0,
	/// <summary>
	/// <b>D2D1_TEMPERATUREANDTINT_PROP_TINT</b> = 1
	/// </summary>
	Tint = 1,
}

/// <summary>
/// ENUM <b>D2D1_VIGNETTE_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum VignetteProp : uint {
	/// <summary>
	/// <b>D2D1_VIGNETTE_PROP_COLOR</b> = 0
	/// </summary>
	Color = 0,
	/// <summary>
	/// <b>D2D1_VIGNETTE_PROP_TRANSITION_SIZE</b> = 1
	/// </summary>
	TransitionSize = 1,
	/// <summary>
	/// <b>D2D1_VIGNETTE_PROP_STRENGTH</b> = 2
	/// </summary>
	Strength = 2,
}

/// <summary>
/// ENUM <b>D2D1_EDGEDETECTION_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum EdgedetectionProp : uint {
	/// <summary>
	/// <b>D2D1_EDGEDETECTION_PROP_STRENGTH</b> = 0
	/// </summary>
	Strength = 0,
	/// <summary>
	/// <b>D2D1_EDGEDETECTION_PROP_BLUR_RADIUS</b> = 1
	/// </summary>
	BlurRadius = 1,
	/// <summary>
	/// <b>D2D1_EDGEDETECTION_PROP_MODE</b> = 2
	/// </summary>
	Mode = 2,
	/// <summary>
	/// <b>D2D1_EDGEDETECTION_PROP_OVERLAY_EDGES</b> = 3
	/// </summary>
	OverlayEdges = 3,
	/// <summary>
	/// <b>D2D1_EDGEDETECTION_PROP_ALPHA_MODE</b> = 4
	/// </summary>
	AlphaMode = 4,
}

/// <summary>
/// ENUM <b>D2D1_EDGEDETECTION_MODE</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum EdgedetectionMode : uint {
	/// <summary>
	/// <b>D2D1_EDGEDETECTION_MODE_SOBEL</b> = 0
	/// </summary>
	Sobel = 0,
	/// <summary>
	/// <b>D2D1_EDGEDETECTION_MODE_PREWITT</b> = 1
	/// </summary>
	Prewitt = 1,
}

/// <summary>
/// ENUM <b>D2D1_HIGHLIGHTSANDSHADOWS_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum HighlightsandshadowsProp : uint {
	/// <summary>
	/// <b>D2D1_HIGHLIGHTSANDSHADOWS_PROP_HIGHLIGHTS</b> = 0
	/// </summary>
	Highlights = 0,
	/// <summary>
	/// <b>D2D1_HIGHLIGHTSANDSHADOWS_PROP_SHADOWS</b> = 1
	/// </summary>
	Shadows = 1,
	/// <summary>
	/// <b>D2D1_HIGHLIGHTSANDSHADOWS_PROP_CLARITY</b> = 2
	/// </summary>
	Clarity = 2,
	/// <summary>
	/// <b>D2D1_HIGHLIGHTSANDSHADOWS_PROP_INPUT_GAMMA</b> = 3
	/// </summary>
	InputGamma = 3,
	/// <summary>
	/// <b>D2D1_HIGHLIGHTSANDSHADOWS_PROP_MASK_BLUR_RADIUS</b> = 4
	/// </summary>
	MaskBlurRadius = 4,
}

/// <summary>
/// ENUM <b>D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum HighlightsandshadowsInputGamma : uint {
	/// <summary>
	/// <b>D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_LINEAR</b> = 0
	/// </summary>
	Linear = 0,
	/// <summary>
	/// <b>D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_SRGB</b> = 1
	/// </summary>
	Srgb = 1,
}

/// <summary>
/// ENUM <b>D2D1_LOOKUPTABLE3D_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum Lookuptable3dProp : uint {
	/// <summary>
	/// <b>D2D1_LOOKUPTABLE3D_PROP_LUT</b> = 0
	/// </summary>
	Lut = 0,
	/// <summary>
	/// <b>D2D1_LOOKUPTABLE3D_PROP_ALPHA_MODE</b> = 1
	/// </summary>
	AlphaMode = 1,
}

/// <summary>
/// ENUM <b>D2D1_OPACITY_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum OpacityProp : uint {
	/// <summary>
	/// <b>D2D1_OPACITY_PROP_OPACITY</b> = 0
	/// </summary>
	Opacity = 0,
}

/// <summary>
/// ENUM <b>D2D1_CROSSFADE_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum CrossfadeProp : uint {
	/// <summary>
	/// <b>D2D1_CROSSFADE_PROP_WEIGHT</b> = 0
	/// </summary>
	Weight = 0,
}

/// <summary>
/// ENUM <b>D2D1_TINT_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum TintProp : uint {
	/// <summary>
	/// <b>D2D1_TINT_PROP_COLOR</b> = 0
	/// </summary>
	Color = 0,
	/// <summary>
	/// <b>D2D1_TINT_PROP_CLAMP_OUTPUT</b> = 1
	/// </summary>
	ClampOutput = 1,
}

/// <summary>
/// ENUM <b>D2D1_WHITELEVELADJUSTMENT_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum WhiteleveladjustmentProp : uint {
	/// <summary>
	/// <b>D2D1_WHITELEVELADJUSTMENT_PROP_INPUT_WHITE_LEVEL</b> = 0
	/// </summary>
	InputWhiteLevel = 0,
	/// <summary>
	/// <b>D2D1_WHITELEVELADJUSTMENT_PROP_OUTPUT_WHITE_LEVEL</b> = 1
	/// </summary>
	OutputWhiteLevel = 1,
}

/// <summary>
/// ENUM <b>D2D1_HDRTONEMAP_PROP</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum HdrtonemapProp : uint {
	/// <summary>
	/// <b>D2D1_HDRTONEMAP_PROP_INPUT_MAX_LUMINANCE</b> = 0
	/// </summary>
	InputMaxLuminance = 0,
	/// <summary>
	/// <b>D2D1_HDRTONEMAP_PROP_OUTPUT_MAX_LUMINANCE</b> = 1
	/// </summary>
	OutputMaxLuminance = 1,
	/// <summary>
	/// <b>D2D1_HDRTONEMAP_PROP_DISPLAY_MODE</b> = 2
	/// </summary>
	DisplayMode = 2,
}

/// <summary>
/// ENUM <b>D2D1_HDRTONEMAP_DISPLAY_MODE</b><br/>
/// D2D1EFFECTS_2.h
/// </summary>
public enum HdrtonemapDisplayMode : uint {
	/// <summary>
	/// <b>D2D1_HDRTONEMAP_DISPLAY_MODE_SDR</b> = 0
	/// </summary>
	Sdr = 0,
	/// <summary>
	/// <b>D2D1_HDRTONEMAP_DISPLAY_MODE_HDR</b> = 1
	/// </summary>
	Hdr = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_PAINT_TYPE</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgPaintType : uint {
	/// <summary>
	/// <b>D2D1_SVG_PAINT_TYPE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_SVG_PAINT_TYPE_COLOR</b> = 1
	/// </summary>
	Color = 1,
	/// <summary>
	/// <b>D2D1_SVG_PAINT_TYPE_CURRENT_COLOR</b> = 2
	/// </summary>
	CurrentColor = 2,
	/// <summary>
	/// <b>D2D1_SVG_PAINT_TYPE_URI</b> = 3
	/// </summary>
	Uri = 3,
	/// <summary>
	/// <b>D2D1_SVG_PAINT_TYPE_URI_NONE</b> = 4
	/// </summary>
	UriNone = 4,
	/// <summary>
	/// <b>D2D1_SVG_PAINT_TYPE_URI_COLOR</b> = 5
	/// </summary>
	UriColor = 5,
	/// <summary>
	/// <b>D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR</b> = 6
	/// </summary>
	UriCurrentColor = 6,
}

/// <summary>
/// ENUM <b>D2D1_SVG_LENGTH_UNITS</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgLengthUnits : uint {
	/// <summary>
	/// <b>D2D1_SVG_LENGTH_UNITS_NUMBER</b> = 0
	/// </summary>
	Number = 0,
	/// <summary>
	/// <b>D2D1_SVG_LENGTH_UNITS_PERCENTAGE</b> = 1
	/// </summary>
	Percentage = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_DISPLAY</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgDisplay : uint {
	/// <summary>
	/// <b>D2D1_SVG_DISPLAY_INLINE</b> = 0
	/// </summary>
	Inline = 0,
	/// <summary>
	/// <b>D2D1_SVG_DISPLAY_NONE</b> = 1
	/// </summary>
	None = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_VISIBILITY</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgVisibility : uint {
	/// <summary>
	/// <b>D2D1_SVG_VISIBILITY_VISIBLE</b> = 0
	/// </summary>
	Visible = 0,
	/// <summary>
	/// <b>D2D1_SVG_VISIBILITY_HIDDEN</b> = 1
	/// </summary>
	Hidden = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_OVERFLOW</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgOverflow : uint {
	/// <summary>
	/// <b>D2D1_SVG_OVERFLOW_VISIBLE</b> = 0
	/// </summary>
	Visible = 0,
	/// <summary>
	/// <b>D2D1_SVG_OVERFLOW_HIDDEN</b> = 1
	/// </summary>
	Hidden = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_LINE_CAP</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgLineCap : uint {
	/// <summary>
	/// <b>D2D1_SVG_LINE_CAP_BUTT</b> = D2D1_CAP_STYLE_FLAT
	/// </summary>
	Butt = CapStyle.Flat,
	/// <summary>
	/// <b>D2D1_SVG_LINE_CAP_SQUARE</b> = D2D1_CAP_STYLE_SQUARE
	/// </summary>
	Square = CapStyle.Square,
	/// <summary>
	/// <b>D2D1_SVG_LINE_CAP_ROUND</b> = D2D1_CAP_STYLE_ROUND
	/// </summary>
	Round = CapStyle.Round,
}

/// <summary>
/// ENUM <b>D2D1_SVG_LINE_JOIN</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgLineJoin : uint {
	/// <summary>
	/// <b>D2D1_SVG_LINE_JOIN_BEVEL</b> = D2D1_LINE_JOIN_BEVEL
	/// </summary>
	Bevel = LineJoin.Bevel,
	/// <summary>
	/// <b>D2D1_SVG_LINE_JOIN_MITER</b> = D2D1_LINE_JOIN_MITER_OR_BEVEL
	/// </summary>
	Miter = LineJoin.MiterOrBevel,
	/// <summary>
	/// <b>D2D1_SVG_LINE_JOIN_ROUND</b> = D2D1_LINE_JOIN_ROUND
	/// </summary>
	Round = LineJoin.Round,
}

/// <summary>
/// ENUM <b>D2D1_SVG_ASPECT_ALIGN</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgAspectAlign : uint {
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN</b> = 1
	/// </summary>
	XMinYMin = 1,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN</b> = 2
	/// </summary>
	XMidYMin = 2,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN</b> = 3
	/// </summary>
	XMaxYMin = 3,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID</b> = 4
	/// </summary>
	XMinYMid = 4,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID</b> = 5
	/// </summary>
	XMidYMid = 5,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID</b> = 6
	/// </summary>
	XMaxYMid = 6,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX</b> = 7
	/// </summary>
	XMinYMax = 7,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX</b> = 8
	/// </summary>
	XMidYMax = 8,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX</b> = 9
	/// </summary>
	XMaxYMax = 9,
}

/// <summary>
/// ENUM <b>D2D1_SVG_ASPECT_SCALING</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgAspectScaling : uint {
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_SCALING_MEET</b> = 0
	/// </summary>
	Meet = 0,
	/// <summary>
	/// <b>D2D1_SVG_ASPECT_SCALING_SLICE</b> = 1
	/// </summary>
	Slice = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_PATH_COMMAND</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgPathCommand : uint {
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_CLOSE_PATH</b> = 0
	/// </summary>
	ClosePath = 0,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE</b> = 1
	/// </summary>
	MoveAbsolute = 1,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE</b> = 2
	/// </summary>
	MoveRelative = 2,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE</b> = 3
	/// </summary>
	LineAbsolute = 3,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_LINE_RELATIVE</b> = 4
	/// </summary>
	LineRelative = 4,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE</b> = 5
	/// </summary>
	CubicAbsolute = 5,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE</b> = 6
	/// </summary>
	CubicRelative = 6,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE</b> = 7
	/// </summary>
	QuadradicAbsolute = 7,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE</b> = 8
	/// </summary>
	QuadradicRelative = 8,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE</b> = 9
	/// </summary>
	ArcAbsolute = 9,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_ARC_RELATIVE</b> = 10
	/// </summary>
	ArcRelative = 10,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE</b> = 11
	/// </summary>
	HorizontalAbsolute = 11,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE</b> = 12
	/// </summary>
	HorizontalRelative = 12,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE</b> = 13
	/// </summary>
	VerticalAbsolute = 13,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE</b> = 14
	/// </summary>
	VerticalRelative = 14,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE</b> = 15
	/// </summary>
	CubicSmoothAbsolute = 15,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE</b> = 16
	/// </summary>
	CubicSmoothRelative = 16,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE</b> = 17
	/// </summary>
	QuadradicSmoothAbsolute = 17,
	/// <summary>
	/// <b>D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE</b> = 18
	/// </summary>
	QuadradicSmoothRelative = 18,
}

/// <summary>
/// ENUM <b>D2D1_SVG_UNIT_TYPE</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgUnitType : uint {
	/// <summary>
	/// <b>D2D1_SVG_UNIT_TYPE_USER_SPACE_ON_USE</b> = 0
	/// </summary>
	UserSpaceOnUse = 0,
	/// <summary>
	/// <b>D2D1_SVG_UNIT_TYPE_OBJECT_BOUNDING_BOX</b> = 1
	/// </summary>
	ObjectBoundingBox = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_ATTRIBUTE_STRING_TYPE</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgAttributeStringType : uint {
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_STRING_TYPE_SVG</b> = 0
	/// </summary>
	Svg = 0,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_STRING_TYPE_ID</b> = 1
	/// </summary>
	Id = 1,
}

/// <summary>
/// ENUM <b>D2D1_SVG_ATTRIBUTE_POD_TYPE</b><br/>
/// D2D1SVG.h
/// </summary>
public enum SvgAttributePodType : uint {
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT</b> = 0
	/// </summary>
	Float = 0,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR</b> = 1
	/// </summary>
	Color = 1,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE</b> = 2
	/// </summary>
	FillMode = 2,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY</b> = 3
	/// </summary>
	Display = 3,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW</b> = 4
	/// </summary>
	Overflow = 4,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP</b> = 5
	/// </summary>
	LineCap = 5,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN</b> = 6
	/// </summary>
	LineJoin = 6,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY</b> = 7
	/// </summary>
	Visibility = 7,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX</b> = 8
	/// </summary>
	Matrix = 8,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE</b> = 9
	/// </summary>
	UnitType = 9,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE</b> = 10
	/// </summary>
	ExtendMode = 10,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO</b> = 11
	/// </summary>
	PreserveAspectRatio = 11,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX</b> = 12
	/// </summary>
	Viewbox = 12,
	/// <summary>
	/// <b>D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH</b> = 13
	/// </summary>
	Length = 13,
}

/// <summary>
/// ENUM <b>D2D1_PROPERTY_TYPE</b><br/>
/// D2D1_1.h
/// </summary>
public enum PropertyType : uint {
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_STRING</b> = 1
	/// </summary>
	String = 1,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_BOOL</b> = 2
	/// </summary>
	Bool = 2,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_UINT32</b> = 3
	/// </summary>
	Uint32 = 3,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_INT32</b> = 4
	/// </summary>
	Int32 = 4,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_FLOAT</b> = 5
	/// </summary>
	Float = 5,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_VECTOR2</b> = 6
	/// </summary>
	Vector2 = 6,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_VECTOR3</b> = 7
	/// </summary>
	Vector3 = 7,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_VECTOR4</b> = 8
	/// </summary>
	Vector4 = 8,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_BLOB</b> = 9
	/// </summary>
	Blob = 9,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_IUNKNOWN</b> = 10
	/// </summary>
	Iunknown = 10,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_ENUM</b> = 11
	/// </summary>
	Enum = 11,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_ARRAY</b> = 12
	/// </summary>
	Array = 12,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_CLSID</b> = 13
	/// </summary>
	Clsid = 13,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_MATRIX_3X2</b> = 14
	/// </summary>
	Matrix3X2 = 14,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_MATRIX_4X3</b> = 15
	/// </summary>
	Matrix4X3 = 15,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_MATRIX_4X4</b> = 16
	/// </summary>
	Matrix4X4 = 16,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_MATRIX_5X4</b> = 17
	/// </summary>
	Matrix5X4 = 17,
	/// <summary>
	/// <b>D2D1_PROPERTY_TYPE_COLOR_CONTEXT</b> = 18
	/// </summary>
	ColorContext = 18,
}

/// <summary>
/// ENUM <b>D2D1_PROPERTY</b><br/>
/// D2D1_1.h
/// </summary>
public enum Property : uint {
	/// <summary>
	/// <b>D2D1_PROPERTY_CLSID</b> = 0x80000000
	/// </summary>
	Clsid = 2147483648,
	/// <summary>
	/// <b>D2D1_PROPERTY_DISPLAYNAME</b> = 0x80000001
	/// </summary>
	Displayname = 2147483649,
	/// <summary>
	/// <b>D2D1_PROPERTY_AUTHOR</b> = 0x80000002
	/// </summary>
	Author = 2147483650,
	/// <summary>
	/// <b>D2D1_PROPERTY_CATEGORY</b> = 0x80000003
	/// </summary>
	Category = 2147483651,
	/// <summary>
	/// <b>D2D1_PROPERTY_DESCRIPTION</b> = 0x80000004
	/// </summary>
	Description = 2147483652,
	/// <summary>
	/// <b>D2D1_PROPERTY_INPUTS</b> = 0x80000005
	/// </summary>
	Inputs = 2147483653,
	/// <summary>
	/// <b>D2D1_PROPERTY_CACHED</b> = 0x80000006
	/// </summary>
	Cached = 2147483654,
	/// <summary>
	/// <b>D2D1_PROPERTY_PRECISION</b> = 0x80000007
	/// </summary>
	Precision = 2147483655,
	/// <summary>
	/// <b>D2D1_PROPERTY_MIN_INPUTS</b> = 0x80000008
	/// </summary>
	MinInputs = 2147483656,
	/// <summary>
	/// <b>D2D1_PROPERTY_MAX_INPUTS</b> = 0x80000009
	/// </summary>
	MaxInputs = 2147483657,
}

/// <summary>
/// ENUM <b>D2D1_SUBPROPERTY</b><br/>
/// D2D1_1.h
/// </summary>
public enum Subproperty : uint {
	/// <summary>
	/// <b>D2D1_SUBPROPERTY_DISPLAYNAME</b> = 0x80000000
	/// </summary>
	Displayname = 2147483648,
	/// <summary>
	/// <b>D2D1_SUBPROPERTY_ISREADONLY</b> = 0x80000001
	/// </summary>
	Isreadonly = 2147483649,
	/// <summary>
	/// <b>D2D1_SUBPROPERTY_MIN</b> = 0x80000002
	/// </summary>
	Min = 2147483650,
	/// <summary>
	/// <b>D2D1_SUBPROPERTY_MAX</b> = 0x80000003
	/// </summary>
	Max = 2147483651,
	/// <summary>
	/// <b>D2D1_SUBPROPERTY_DEFAULT</b> = 0x80000004
	/// </summary>
	Default = 2147483652,
	/// <summary>
	/// <b>D2D1_SUBPROPERTY_FIELDS</b> = 0x80000005
	/// </summary>
	Fields = 2147483653,
	/// <summary>
	/// <b>D2D1_SUBPROPERTY_INDEX</b> = 0x80000006
	/// </summary>
	Index = 2147483654,
}

/// <summary>
/// ENUM <b>D2D1_BITMAP_OPTIONS</b><br/>
/// D2D1_1.h
/// </summary>
public enum BitmapOptions : uint {
	/// <summary>
	/// <b>D2D1_BITMAP_OPTIONS_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_BITMAP_OPTIONS_TARGET</b> = 0x00000001
	/// </summary>
	Target = 1,
	/// <summary>
	/// <b>D2D1_BITMAP_OPTIONS_CANNOT_DRAW</b> = 0x00000002
	/// </summary>
	CannotDraw = 2,
	/// <summary>
	/// <b>D2D1_BITMAP_OPTIONS_CPU_READ</b> = 0x00000004
	/// </summary>
	CpuRead = 4,
	/// <summary>
	/// <b>D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE</b> = 0x00000008
	/// </summary>
	GdiCompatible = 8,
}

/// <summary>
/// ENUM <b>D2D1_COMPOSITE_MODE</b><br/>
/// D2D1_1.h
/// </summary>
public enum CompositeMode : uint {
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_SOURCE_OVER</b> = 0
	/// </summary>
	SourceOver = 0,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_DESTINATION_OVER</b> = 1
	/// </summary>
	DestinationOver = 1,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_SOURCE_IN</b> = 2
	/// </summary>
	SourceIn = 2,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_DESTINATION_IN</b> = 3
	/// </summary>
	DestinationIn = 3,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_SOURCE_OUT</b> = 4
	/// </summary>
	SourceOut = 4,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_DESTINATION_OUT</b> = 5
	/// </summary>
	DestinationOut = 5,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_SOURCE_ATOP</b> = 6
	/// </summary>
	SourceAtop = 6,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_DESTINATION_ATOP</b> = 7
	/// </summary>
	DestinationAtop = 7,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_XOR</b> = 8
	/// </summary>
	Xor = 8,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_PLUS</b> = 9
	/// </summary>
	Plus = 9,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_SOURCE_COPY</b> = 10
	/// </summary>
	SourceCopy = 10,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_BOUNDED_SOURCE_COPY</b> = 11
	/// </summary>
	BoundedSourceCopy = 11,
	/// <summary>
	/// <b>D2D1_COMPOSITE_MODE_MASK_INVERT</b> = 12
	/// </summary>
	MaskInvert = 12,
}

/// <summary>
/// ENUM <b>D2D1_BUFFER_PRECISION</b><br/>
/// D2D1_1.h
/// </summary>
public enum BufferPrecision : uint {
	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION_8BPC_UNORM</b> = 1
	/// </summary>
	Precision8BpcUnorm = 1,
	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION_8BPC_UNORM_SRGB</b> = 2
	/// </summary>
	Precision8BpcUnormSrgb = 2,
	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION_16BPC_UNORM</b> = 3
	/// </summary>
	Precision16BpcUnorm = 3,
	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION_16BPC_FLOAT</b> = 4
	/// </summary>
	Precision16BpcFloat = 4,
	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION_32BPC_FLOAT</b> = 5
	/// </summary>
	Precision32BpcFloat = 5,
}

/// <summary>
/// ENUM <b>D2D1_MAP_OPTIONS</b><br/>
/// D2D1_1.h
/// </summary>
public enum MapOptions : uint {
	/// <summary>
	/// <b>D2D1_MAP_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_MAP_OPTIONS_READ</b> = 1
	/// </summary>
	Read = 1,
	/// <summary>
	/// <b>D2D1_MAP_OPTIONS_WRITE</b> = 2
	/// </summary>
	Write = 2,
	/// <summary>
	/// <b>D2D1_MAP_OPTIONS_DISCARD</b> = 4
	/// </summary>
	Discard = 4,
}

/// <summary>
/// ENUM <b>D2D1_INTERPOLATION_MODE</b><br/>
/// D2D1_1.h
/// </summary>
public enum InterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR</b> = D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR
	/// </summary>
	NearestNeighbor,
	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE_LINEAR</b> = D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR
	/// </summary>
	Linear,
	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE_CUBIC</b> = D2D1_INTERPOLATION_MODE_DEFINITION_CUBIC
	/// </summary>
	Cubic,
	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</b> = D2D1_INTERPOLATION_MODE_DEFINITION_MULTI_SAMPLE_LINEAR
	/// </summary>
	MultiSampleLinear,
	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE_ANISOTROPIC</b> = D2D1_INTERPOLATION_MODE_DEFINITION_ANISOTROPIC
	/// </summary>
	Anisotropic,
	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC</b> = D2D1_INTERPOLATION_MODE_DEFINITION_HIGH_QUALITY_CUBIC
	/// </summary>
	HighQualityCubic,
}

/// <summary>
/// ENUM <b>D2D1_UNIT_MODE</b><br/>
/// D2D1_1.h
/// </summary>
public enum UnitMode : uint {
	/// <summary>
	/// <b>D2D1_UNIT_MODE_DIPS</b> = 0
	/// </summary>
	Dips = 0,
	/// <summary>
	/// <b>D2D1_UNIT_MODE_PIXELS</b> = 1
	/// </summary>
	Pixels = 1,
}

/// <summary>
/// ENUM <b>D2D1_COLOR_SPACE</b><br/>
/// D2D1_1.h
/// </summary>
public enum ColorSpace : uint {
	/// <summary>
	/// <b>D2D1_COLOR_SPACE_CUSTOM</b> = 0
	/// </summary>
	Custom = 0,
	/// <summary>
	/// <b>D2D1_COLOR_SPACE_SRGB</b> = 1
	/// </summary>
	Srgb = 1,
	/// <summary>
	/// <b>D2D1_COLOR_SPACE_SCRGB</b> = 2
	/// </summary>
	Scrgb = 2,
}

/// <summary>
/// ENUM <b>D2D1_DEVICE_CONTEXT_OPTIONS</b><br/>
/// D2D1_1.h
/// </summary>
public enum DeviceContextOptions : uint {
	/// <summary>
	/// <b>D2D1_DEVICE_CONTEXT_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_DEVICE_CONTEXT_OPTIONS_ENABLE_MULTITHREADED_OPTIMIZATIONS</b> = 1
	/// </summary>
	EnableMultithreadedOptimizations = 1,
}

/// <summary>
/// ENUM <b>D2D1_STROKE_TRANSFORM_TYPE</b><br/>
/// D2D1_1.h
/// </summary>
public enum StrokeTransformType : uint {
	/// <summary>
	/// <b>D2D1_STROKE_TRANSFORM_TYPE_NORMAL</b> = 0
	/// </summary>
	Normal = 0,
	/// <summary>
	/// <b>D2D1_STROKE_TRANSFORM_TYPE_FIXED</b> = 1
	/// </summary>
	Fixed = 1,
	/// <summary>
	/// <b>D2D1_STROKE_TRANSFORM_TYPE_HAIRLINE</b> = 2
	/// </summary>
	Hairline = 2,
}

/// <summary>
/// ENUM <b>D2D1_PRIMITIVE_BLEND</b><br/>
/// D2D1_1.h
/// </summary>
public enum PrimitiveBlend : uint {
	/// <summary>
	/// <b>D2D1_PRIMITIVE_BLEND_SOURCE_OVER</b> = 0
	/// </summary>
	SourceOver = 0,
	/// <summary>
	/// <b>D2D1_PRIMITIVE_BLEND_COPY</b> = 1
	/// </summary>
	Copy = 1,
	/// <summary>
	/// <b>D2D1_PRIMITIVE_BLEND_MIN</b> = 2
	/// </summary>
	Min = 2,
	/// <summary>
	/// <b>D2D1_PRIMITIVE_BLEND_ADD</b> = 3
	/// </summary>
	Add = 3,
	/// <summary>
	/// <b>D2D1_PRIMITIVE_BLEND_MAX</b> = 4
	/// </summary>
	Max = 4,
}

/// <summary>
/// ENUM <b>D2D1_THREADING_MODE</b><br/>
/// D2D1_1.h
/// </summary>
public enum ThreadingMode : uint {
	/// <summary>
	/// <b>D2D1_THREADING_MODE_SINGLE_THREADED</b> = D2D1_FACTORY_TYPE_SINGLE_THREADED
	/// </summary>
	SingleThreaded = FactoryType.SingleThreaded,
	/// <summary>
	/// <b>D2D1_THREADING_MODE_MULTI_THREADED</b> = D2D1_FACTORY_TYPE_MULTI_THREADED
	/// </summary>
	MultiThreaded = FactoryType.MultiThreaded,
}

/// <summary>
/// ENUM <b>D2D1_COLOR_INTERPOLATION_MODE</b><br/>
/// D2D1_1.h
/// </summary>
public enum ColorInterpolationMode : uint {
	/// <summary>
	/// <b>D2D1_COLOR_INTERPOLATION_MODE_STRAIGHT</b> = 0
	/// </summary>
	Straight = 0,
	/// <summary>
	/// <b>D2D1_COLOR_INTERPOLATION_MODE_PREMULTIPLIED</b> = 1
	/// </summary>
	Premultiplied = 1,
}

/// <summary>
/// ENUM <b>D2D1_LAYER_OPTIONS1</b><br/>
/// D2D1_1.h
/// </summary>
public enum LayerOptions1 : uint {
	/// <summary>
	/// <b>D2D1_LAYER_OPTIONS1_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_LAYER_OPTIONS1_INITIALIZE_FROM_BACKGROUND</b> = 1
	/// </summary>
	InitializeFromBackground = 1,
	/// <summary>
	/// <b>D2D1_LAYER_OPTIONS1_IGNORE_ALPHA</b> = 2
	/// </summary>
	IgnoreAlpha = 2,
}

/// <summary>
/// ENUM <b>D2D1_PRINT_FONT_SUBSET_MODE</b><br/>
/// D2D1_1.h
/// </summary>
public enum PrintFontSubsetMode : uint {
	/// <summary>
	/// <b>D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D2D1_PRINT_FONT_SUBSET_MODE_EACHPAGE</b> = 1
	/// </summary>
	Eachpage = 1,
	/// <summary>
	/// <b>D2D1_PRINT_FONT_SUBSET_MODE_NONE</b> = 2
	/// </summary>
	None = 2,
}

/// <summary>
/// ENUM <b>D2D1_RENDERING_PRIORITY</b><br/>
/// D2D1_2.h
/// </summary>
public enum RenderingPriority : uint {
	/// <summary>
	/// <b>D2D1_RENDERING_PRIORITY_NORMAL</b> = 0
	/// </summary>
	Normal = 0,
	/// <summary>
	/// <b>D2D1_RENDERING_PRIORITY_LOW</b> = 1
	/// </summary>
	Low = 1,
}

/// <summary>
/// ENUM <b>D2D1_INK_NIB_SHAPE</b><br/>
/// D2D1_3.h
/// </summary>
public enum InkNibShape : uint {
	/// <summary>
	/// <b>D2D1_INK_NIB_SHAPE_ROUND</b> = 0
	/// </summary>
	Round = 0,
	/// <summary>
	/// <b>D2D1_INK_NIB_SHAPE_SQUARE</b> = 1
	/// </summary>
	Square = 1,
}

/// <summary>
/// ENUM <b>D2D1_ORIENTATION</b><br/>
/// D2D1_3.h
/// </summary>
public enum Orientation : uint {
	/// <summary>
	/// <b>D2D1_ORIENTATION_DEFAULT</b> = 1
	/// </summary>
	Default = 1,
	/// <summary>
	/// <b>D2D1_ORIENTATION_FLIP_HORIZONTAL</b> = 2
	/// </summary>
	FlipHorizontal = 2,
	/// <summary>
	/// <b>D2D1_ORIENTATION_ROTATE_CLOCKWISE180</b> = 3
	/// </summary>
	RotateClockwise180 = 3,
	/// <summary>
	/// <b>D2D1_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL</b> = 4
	/// </summary>
	RotateClockwise180FlipHorizontal = 4,
	/// <summary>
	/// <b>D2D1_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL</b> = 5
	/// </summary>
	RotateClockwise90FlipHorizontal = 5,
	/// <summary>
	/// <b>D2D1_ORIENTATION_ROTATE_CLOCKWISE270</b> = 6
	/// </summary>
	RotateClockwise270 = 6,
	/// <summary>
	/// <b>D2D1_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL</b> = 7
	/// </summary>
	RotateClockwise270FlipHorizontal = 7,
	/// <summary>
	/// <b>D2D1_ORIENTATION_ROTATE_CLOCKWISE90</b> = 8
	/// </summary>
	RotateClockwise90 = 8,
}

/// <summary>
/// ENUM <b>D2D1_IMAGE_SOURCE_LOADING_OPTIONS</b><br/>
/// D2D1_3.h
/// </summary>
public enum ImageSourceLoadingOptions : uint {
	/// <summary>
	/// <b>D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE</b> = 1
	/// </summary>
	ReleaseSource = 1,
	/// <summary>
	/// <b>D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND</b> = 2
	/// </summary>
	CacheOnDemand = 2,
}

/// <summary>
/// ENUM <b>D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS</b><br/>
/// D2D1_3.h
/// </summary>
public enum ImageSourceFromDxgiOptions : uint {
	/// <summary>
	/// <b>D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_LOW_QUALITY_PRIMARY_CONVERSION</b> = 1
	/// </summary>
	LowQualityPrimaryConversion = 1,
}

/// <summary>
/// ENUM <b>D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS</b><br/>
/// D2D1_3.h
/// </summary>
public enum TransformedImageSourceOptions : uint {
	/// <summary>
	/// <b>D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS_DISABLE_DPI_SCALE</b> = 1
	/// </summary>
	DisableDpiScale = 1,
}

/// <summary>
/// ENUM <b>D2D1_PATCH_EDGE_MODE</b><br/>
/// D2D1_3.h
/// </summary>
public enum PatchEdgeMode : uint {
	/// <summary>
	/// <b>D2D1_PATCH_EDGE_MODE_ALIASED</b> = 0
	/// </summary>
	Aliased = 0,
	/// <summary>
	/// <b>D2D1_PATCH_EDGE_MODE_ANTIALIASED</b> = 1
	/// </summary>
	Antialiased = 1,
	/// <summary>
	/// <b>D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED</b> = 2
	/// </summary>
	AliasedInflated = 2,
}

/// <summary>
/// ENUM <b>D2D1_SPRITE_OPTIONS</b><br/>
/// D2D1_3.h
/// </summary>
public enum SpriteOptions : uint {
	/// <summary>
	/// <b>D2D1_SPRITE_OPTIONS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE</b> = 1
	/// </summary>
	ClampToSourceRectangle = 1,
}

/// <summary>
/// ENUM <b>D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION</b><br/>
/// D2D1_3.h
/// </summary>
public enum ColorBitmapGlyphSnapOption : uint {
	/// <summary>
	/// <b>D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DISABLE</b> = 1
	/// </summary>
	Disable = 1,
}

/// <summary>
/// ENUM <b>D2D1_GAMMA1</b><br/>
/// D2D1_3.h
/// </summary>
public enum Gamma1 : uint {
	/// <summary>
	/// <b>D2D1_GAMMA1_G22</b> = D2D1_GAMMA_2_2
	/// </summary>
	G22 = Gamma.Gamma22,
	/// <summary>
	/// <b>D2D1_GAMMA1_G10</b> = D2D1_GAMMA_1_0
	/// </summary>
	G10 = Gamma.Gamma10,
	/// <summary>
	/// <b>D2D1_GAMMA1_G2084</b> = 2
	/// </summary>
	G2084 = 2,
}

/// <summary>
/// ENUM <b>D2D1_COLOR_CONTEXT_TYPE</b><br/>
/// D2D1_3.h
/// </summary>
public enum ColorContextType : uint {
	/// <summary>
	/// <b>D2D1_COLOR_CONTEXT_TYPE_ICC</b> = 0
	/// </summary>
	Icc = 0,
	/// <summary>
	/// <b>D2D1_COLOR_CONTEXT_TYPE_SIMPLE</b> = 1
	/// </summary>
	Simple = 1,
	/// <summary>
	/// <b>D2D1_COLOR_CONTEXT_TYPE_DXGI</b> = 2
	/// </summary>
	Dxgi = 2,
}

/// <summary>
/// ENUM <b>D2D1_ALPHA_MODE</b><br/>
/// DCOMMON.h
/// </summary>
public enum AlphaMode : uint {
	/// <summary>
	/// <b>D2D1_ALPHA_MODE_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D2D1_ALPHA_MODE_PREMULTIPLIED</b> = 1
	/// </summary>
	Premultiplied = 1,
	/// <summary>
	/// <b>D2D1_ALPHA_MODE_STRAIGHT</b> = 2
	/// </summary>
	Straight = 2,
	/// <summary>
	/// <b>D2D1_ALPHA_MODE_IGNORE</b> = 3
	/// </summary>
	Ignore = 3,
}
