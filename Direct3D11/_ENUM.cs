using System;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// ENUM <b>D3D11_INPUT_CLASSIFICATION</b><br/>
/// D3D11.h
/// </summary>
public enum InputClassification : uint {
	/// <summary>
	/// <b>D3D11_INPUT_PER_VERTEX_DATA</b> = 0
	/// </summary>
	PerVertexData = 0,
	/// <summary>
	/// <b>D3D11_INPUT_PER_INSTANCE_DATA</b> = 1
	/// </summary>
	PerInstanceData = 1,
}

/// <summary>
/// ENUM <b>D3D11_FILL_MODE</b><br/>
/// D3D11.h
/// </summary>
public enum FillMode : uint {
	/// <summary>
	/// <b>D3D11_FILL_WIREFRAME</b> = 2
	/// </summary>
	Wireframe = 2,
	/// <summary>
	/// <b>D3D11_FILL_SOLID</b> = 3
	/// </summary>
	Solid = 3,
}

/// <summary>
/// ENUM <b>D3D11_CULL_MODE</b><br/>
/// D3D11.h
/// </summary>
public enum CullMode : uint {
	/// <summary>
	/// <b>D3D11_CULL_NONE</b> = 1
	/// </summary>
	None = 1,
	/// <summary>
	/// <b>D3D11_CULL_FRONT</b> = 2
	/// </summary>
	Front = 2,
	/// <summary>
	/// <b>D3D11_CULL_BACK</b> = 3
	/// </summary>
	Back = 3,
}

/// <summary>
/// ENUM <b>D3D11_RESOURCE_DIMENSION</b><br/>
/// D3D11.h
/// </summary>
public enum ResourceDimension : uint {
	/// <summary>
	/// <b>D3D11_RESOURCE_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_RESOURCE_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D11_RESOURCE_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D11_RESOURCE_DIMENSION_TEXTURE2D</b> = 3
	/// </summary>
	Texture2d = 3,
	/// <summary>
	/// <b>D3D11_RESOURCE_DIMENSION_TEXTURE3D</b> = 4
	/// </summary>
	Texture3d = 4,
}

/// <summary>
/// ENUM <b>D3D11_DSV_DIMENSION</b><br/>
/// D3D11.h
/// </summary>
public enum DsvDimension : uint {
	/// <summary>
	/// <b>D3D11_DSV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_DSV_DIMENSION_TEXTURE1D</b> = 1
	/// </summary>
	Texture1d = 1,
	/// <summary>
	/// <b>D3D11_DSV_DIMENSION_TEXTURE1DARRAY</b> = 2
	/// </summary>
	Texture1darray = 2,
	/// <summary>
	/// <b>D3D11_DSV_DIMENSION_TEXTURE2D</b> = 3
	/// </summary>
	Texture2d = 3,
	/// <summary>
	/// <b>D3D11_DSV_DIMENSION_TEXTURE2DARRAY</b> = 4
	/// </summary>
	Texture2darray = 4,
	/// <summary>
	/// <b>D3D11_DSV_DIMENSION_TEXTURE2DMS</b> = 5
	/// </summary>
	Texture2dms = 5,
	/// <summary>
	/// <b>D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY</b> = 6
	/// </summary>
	Texture2dmsarray = 6,
}

/// <summary>
/// ENUM <b>D3D11_RTV_DIMENSION</b><br/>
/// D3D11.h
/// </summary>
public enum RtvDimension : uint {
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_TEXTURE1DARRAY</b> = 3
	/// </summary>
	Texture1darray = 3,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_TEXTURE2D</b> = 4
	/// </summary>
	Texture2d = 4,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_TEXTURE2DARRAY</b> = 5
	/// </summary>
	Texture2darray = 5,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_TEXTURE2DMS</b> = 6
	/// </summary>
	Texture2dms = 6,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_TEXTURE2DMSARRAY</b> = 7
	/// </summary>
	Texture2dmsarray = 7,
	/// <summary>
	/// <b>D3D11_RTV_DIMENSION_TEXTURE3D</b> = 8
	/// </summary>
	Texture3d = 8,
}

/// <summary>
/// ENUM <b>D3D11_UAV_DIMENSION</b><br/>
/// D3D11.h
/// </summary>
public enum UavDimension : uint {
	/// <summary>
	/// <b>D3D11_UAV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_UAV_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D11_UAV_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D11_UAV_DIMENSION_TEXTURE1DARRAY</b> = 3
	/// </summary>
	Texture1darray = 3,
	/// <summary>
	/// <b>D3D11_UAV_DIMENSION_TEXTURE2D</b> = 4
	/// </summary>
	Texture2d = 4,
	/// <summary>
	/// <b>D3D11_UAV_DIMENSION_TEXTURE2DARRAY</b> = 5
	/// </summary>
	Texture2darray = 5,
	/// <summary>
	/// <b>D3D11_UAV_DIMENSION_TEXTURE3D</b> = 8
	/// </summary>
	Texture3d = 8,
}

/// <summary>
/// ENUM <b>D3D11_USAGE</b><br/>
/// D3D11.h
/// </summary>
public enum Usage : uint {
	/// <summary>
	/// <b>D3D11_USAGE_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D3D11_USAGE_IMMUTABLE</b> = 1
	/// </summary>
	Immutable = 1,
	/// <summary>
	/// <b>D3D11_USAGE_DYNAMIC</b> = 2
	/// </summary>
	Dynamic = 2,
	/// <summary>
	/// <b>D3D11_USAGE_STAGING</b> = 3
	/// </summary>
	Staging = 3,
}

/// <summary>
/// ENUM <b>D3D11_BIND_FLAG</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum BindFlag : uint {
	/// <summary>
	/// <b>D3D11_BIND_VERTEX_BUFFER</b> = 0x1L
	/// </summary>
	VertexBuffer = 1,
	/// <summary>
	/// <b>D3D11_BIND_INDEX_BUFFER</b> = 0x2L
	/// </summary>
	IndexBuffer = 2,
	/// <summary>
	/// <b>D3D11_BIND_CONSTANT_BUFFER</b> = 0x4L
	/// </summary>
	ConstantBuffer = 4,
	/// <summary>
	/// <b>D3D11_BIND_SHADER_RESOURCE</b> = 0x8L
	/// </summary>
	ShaderResource = 8,
	/// <summary>
	/// <b>D3D11_BIND_STREAM_OUTPUT</b> = 0x10L
	/// </summary>
	StreamOutput = 16,
	/// <summary>
	/// <b>D3D11_BIND_RENDER_TARGET</b> = 0x20L
	/// </summary>
	RenderTarget = 32,
	/// <summary>
	/// <b>D3D11_BIND_DEPTH_STENCIL</b> = 0x40L
	/// </summary>
	DepthStencil = 64,
	/// <summary>
	/// <b>D3D11_BIND_UNORDERED_ACCESS</b> = 0x80L
	/// </summary>
	UnorderedAccess = 128,
	/// <summary>
	/// <b>D3D11_BIND_DECODER</b> = 0x200L
	/// </summary>
	Decoder = 512,
	/// <summary>
	/// <b>D3D11_BIND_VIDEO_ENCODER</b> = 0x400L
	/// </summary>
	VideoEncoder = 1024,
}

/// <summary>
/// ENUM <b>D3D11_CPU_ACCESS_FLAG</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum CpuAccessFlag : uint {
	/// <summary>
	/// <b>D3D11_CPU_ACCESS_WRITE</b> = 0x10000L
	/// </summary>
	Write = 65536,
	/// <summary>
	/// <b>D3D11_CPU_ACCESS_READ</b> = 0x20000L
	/// </summary>
	Read = 131072,
}

/// <summary>
/// ENUM <b>D3D11_RESOURCE_MISC_FLAG</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum ResourceMiscFlag : uint {
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_GENERATE_MIPS</b> = 0x1L
	/// </summary>
	GenerateMips = 1,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_SHARED</b> = 0x2L
	/// </summary>
	Shared = 2,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_TEXTURECUBE</b> = 0x4L
	/// </summary>
	Texturecube = 4,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_DRAWINDIRECT_ARGS</b> = 0x10L
	/// </summary>
	DrawindirectArgs = 16,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_BUFFER_ALLOW_RAW_VIEWS</b> = 0x20L
	/// </summary>
	BufferAllowRawViews = 32,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_BUFFER_STRUCTURED</b> = 0x40L
	/// </summary>
	BufferStructured = 64,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_RESOURCE_CLAMP</b> = 0x80L
	/// </summary>
	ResourceClamp = 128,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX</b> = 0x100L
	/// </summary>
	SharedKeyedmutex = 256,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_GDI_COMPATIBLE</b> = 0x200L
	/// </summary>
	GdiCompatible = 512,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_SHARED_NTHANDLE</b> = 0x800L
	/// </summary>
	SharedNthandle = 2048,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_RESTRICTED_CONTENT</b> = 0x1000L
	/// </summary>
	RestrictedContent = 4096,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE</b> = 0x2000L
	/// </summary>
	RestrictSharedResource = 8192,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE_DRIVER</b> = 0x4000L
	/// </summary>
	RestrictSharedResourceDriver = 16384,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_GUARDED</b> = 0x8000L
	/// </summary>
	Guarded = 32768,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_TILE_POOL</b> = 0x20000L
	/// </summary>
	TilePool = 131072,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_TILED</b> = 0x40000L
	/// </summary>
	Tiled = 262144,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_HW_PROTECTED</b> = 0x80000L
	/// </summary>
	HwProtected = 524288,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_SHARED_DISPLAYABLE</b> = 0x100000L
	/// </summary>
	SharedDisplayable = 1048576,
	/// <summary>
	/// <b>D3D11_RESOURCE_MISC_SHARED_EXCLUSIVE_WRITER</b> = 0x200000L
	/// </summary>
	SharedExclusiveWriter = 2097152,
}

/// <summary>
/// ENUM <b>D3D11_MAP</b><br/>
/// D3D11.h
/// </summary>
public enum Map : uint {
	/// <summary>
	/// <b>D3D11_MAP_READ</b> = 1
	/// </summary>
	Read = 1,
	/// <summary>
	/// <b>D3D11_MAP_WRITE</b> = 2
	/// </summary>
	Write = 2,
	/// <summary>
	/// <b>D3D11_MAP_READ_WRITE</b> = 3
	/// </summary>
	ReadWrite = 3,
	/// <summary>
	/// <b>D3D11_MAP_WRITE_DISCARD</b> = 4
	/// </summary>
	WriteDiscard = 4,
	/// <summary>
	/// <b>D3D11_MAP_WRITE_NO_OVERWRITE</b> = 5
	/// </summary>
	WriteNoOverwrite = 5,
}

/// <summary>
/// ENUM <b>D3D11_MAP_FLAG</b><br/>
/// D3D11.h
/// </summary>
public enum MapFlag : uint {
	/// <summary>
	/// <b>D3D11_MAP_FLAG_DO_NOT_WAIT</b> = 0x100000L
	/// </summary>
	DoNotWait = 1048576,
}

/// <summary>
/// ENUM <b>D3D11_RAISE_FLAG</b><br/>
/// D3D11.h
/// </summary>
public enum RaiseFlag : uint {
	/// <summary>
	/// <b>D3D11_RAISE_FLAG_DRIVER_INTERNAL_ERROR</b> = 0x1L
	/// </summary>
	DriverInternalError = 1,
}

/// <summary>
/// ENUM <b>D3D11_CLEAR_FLAG</b><br/>
/// D3D11.h
/// </summary>
public enum ClearFlag : uint {
	/// <summary>
	/// <b>D3D11_CLEAR_DEPTH</b> = 0x1L
	/// </summary>
	Depth = 1,
	/// <summary>
	/// <b>D3D11_CLEAR_STENCIL</b> = 0x2L
	/// </summary>
	Stencil = 2,
}

/// <summary>
/// ENUM <b>D3D11_COMPARISON_FUNC</b><br/>
/// D3D11.h
/// </summary>
public enum ComparisonFunc : uint {
	/// <summary>
	/// <b>D3D11_COMPARISON_NEVER</b> = 1
	/// </summary>
	Never = 1,
	/// <summary>
	/// <b>D3D11_COMPARISON_LESS</b> = 2
	/// </summary>
	Less = 2,
	/// <summary>
	/// <b>D3D11_COMPARISON_EQUAL</b> = 3
	/// </summary>
	Equal = 3,
	/// <summary>
	/// <b>D3D11_COMPARISON_LESS_EQUAL</b> = 4
	/// </summary>
	LessEqual = 4,
	/// <summary>
	/// <b>D3D11_COMPARISON_GREATER</b> = 5
	/// </summary>
	Greater = 5,
	/// <summary>
	/// <b>D3D11_COMPARISON_NOT_EQUAL</b> = 6
	/// </summary>
	NotEqual = 6,
	/// <summary>
	/// <b>D3D11_COMPARISON_GREATER_EQUAL</b> = 7
	/// </summary>
	GreaterEqual = 7,
	/// <summary>
	/// <b>D3D11_COMPARISON_ALWAYS</b> = 8
	/// </summary>
	Always = 8,
}

/// <summary>
/// ENUM <b>D3D11_DEPTH_WRITE_MASK</b><br/>
/// D3D11.h
/// </summary>
public enum DepthWriteMask : uint {
	/// <summary>
	/// <b>D3D11_DEPTH_WRITE_MASK_ZERO</b> = 0
	/// </summary>
	Zero = 0,
	/// <summary>
	/// <b>D3D11_DEPTH_WRITE_MASK_ALL</b> = 1
	/// </summary>
	All = 1,
}

/// <summary>
/// ENUM <b>D3D11_STENCIL_OP</b><br/>
/// D3D11.h
/// </summary>
public enum StencilOp : uint {
	/// <summary>
	/// <b>D3D11_STENCIL_OP_KEEP</b> = 1
	/// </summary>
	Keep = 1,
	/// <summary>
	/// <b>D3D11_STENCIL_OP_ZERO</b> = 2
	/// </summary>
	Zero = 2,
	/// <summary>
	/// <b>D3D11_STENCIL_OP_REPLACE</b> = 3
	/// </summary>
	Replace = 3,
	/// <summary>
	/// <b>D3D11_STENCIL_OP_INCR_SAT</b> = 4
	/// </summary>
	IncrSat = 4,
	/// <summary>
	/// <b>D3D11_STENCIL_OP_DECR_SAT</b> = 5
	/// </summary>
	DecrSat = 5,
	/// <summary>
	/// <b>D3D11_STENCIL_OP_INVERT</b> = 6
	/// </summary>
	Invert = 6,
	/// <summary>
	/// <b>D3D11_STENCIL_OP_INCR</b> = 7
	/// </summary>
	Incr = 7,
	/// <summary>
	/// <b>D3D11_STENCIL_OP_DECR</b> = 8
	/// </summary>
	Decr = 8,
}

/// <summary>
/// ENUM <b>D3D11_BLEND</b><br/>
/// D3D11.h
/// </summary>
public enum Blend : uint {
	/// <summary>
	/// <b>D3D11_BLEND_ZERO</b> = 1
	/// </summary>
	Zero = 1,
	/// <summary>
	/// <b>D3D11_BLEND_ONE</b> = 2
	/// </summary>
	One = 2,
	/// <summary>
	/// <b>D3D11_BLEND_SRC_COLOR</b> = 3
	/// </summary>
	SrcColor = 3,
	/// <summary>
	/// <b>D3D11_BLEND_INV_SRC_COLOR</b> = 4
	/// </summary>
	InvSrcColor = 4,
	/// <summary>
	/// <b>D3D11_BLEND_SRC_ALPHA</b> = 5
	/// </summary>
	SrcAlpha = 5,
	/// <summary>
	/// <b>D3D11_BLEND_INV_SRC_ALPHA</b> = 6
	/// </summary>
	InvSrcAlpha = 6,
	/// <summary>
	/// <b>D3D11_BLEND_DEST_ALPHA</b> = 7
	/// </summary>
	DestAlpha = 7,
	/// <summary>
	/// <b>D3D11_BLEND_INV_DEST_ALPHA</b> = 8
	/// </summary>
	InvDestAlpha = 8,
	/// <summary>
	/// <b>D3D11_BLEND_DEST_COLOR</b> = 9
	/// </summary>
	DestColor = 9,
	/// <summary>
	/// <b>D3D11_BLEND_INV_DEST_COLOR</b> = 10
	/// </summary>
	InvDestColor = 10,
	/// <summary>
	/// <b>D3D11_BLEND_SRC_ALPHA_SAT</b> = 11
	/// </summary>
	SrcAlphaSat = 11,
	/// <summary>
	/// <b>D3D11_BLEND_BLEND_FACTOR</b> = 14
	/// </summary>
	BlendFactor = 14,
	/// <summary>
	/// <b>D3D11_BLEND_INV_BLEND_FACTOR</b> = 15
	/// </summary>
	InvBlendFactor = 15,
	/// <summary>
	/// <b>D3D11_BLEND_SRC1_COLOR</b> = 16
	/// </summary>
	Src1Color = 16,
	/// <summary>
	/// <b>D3D11_BLEND_INV_SRC1_COLOR</b> = 17
	/// </summary>
	InvSrc1Color = 17,
	/// <summary>
	/// <b>D3D11_BLEND_SRC1_ALPHA</b> = 18
	/// </summary>
	Src1Alpha = 18,
	/// <summary>
	/// <b>D3D11_BLEND_INV_SRC1_ALPHA</b> = 19
	/// </summary>
	InvSrc1Alpha = 19,
}

/// <summary>
/// ENUM <b>D3D11_BLEND_OP</b><br/>
/// D3D11.h
/// </summary>
public enum BlendOp : uint {
	/// <summary>
	/// <b>D3D11_BLEND_OP_ADD</b> = 1
	/// </summary>
	Add = 1,
	/// <summary>
	/// <b>D3D11_BLEND_OP_SUBTRACT</b> = 2
	/// </summary>
	Subtract = 2,
	/// <summary>
	/// <b>D3D11_BLEND_OP_REV_SUBTRACT</b> = 3
	/// </summary>
	RevSubtract = 3,
	/// <summary>
	/// <b>D3D11_BLEND_OP_MIN</b> = 4
	/// </summary>
	Min = 4,
	/// <summary>
	/// <b>D3D11_BLEND_OP_MAX</b> = 5
	/// </summary>
	Max = 5,
}

/// <summary>
/// ENUM <b>D3D11_COLOR_WRITE_ENABLE</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum ColorWriteEnable : uint {
	/// <summary>
	/// <b>D3D11_COLOR_WRITE_ENABLE_RED</b> = 1
	/// </summary>
	Red = 1,
	/// <summary>
	/// <b>D3D11_COLOR_WRITE_ENABLE_GREEN</b> = 2
	/// </summary>
	Green = 2,
	/// <summary>
	/// <b>D3D11_COLOR_WRITE_ENABLE_BLUE</b> = 4
	/// </summary>
	Blue = 4,
	/// <summary>
	/// <b>D3D11_COLOR_WRITE_ENABLE_ALPHA</b> = 8
	/// </summary>
	Alpha = 8,
	/// <summary>
	/// <b>D3D11_COLOR_WRITE_ENABLE_ALL</b> = ( ( ( D3D11_COLOR_WRITE_ENABLE_RED | D3D11_COLOR_WRITE_ENABLE_GREEN )  | D3D11_COLOR_WRITE_ENABLE_BLUE )  | D3D11_COLOR_WRITE_ENABLE_ALPHA )
	/// </summary>
	All = Red | Green | Blue | Alpha,
}

/// <summary>
/// ENUM <b>D3D11_TEXTURECUBE_FACE</b><br/>
/// D3D11.h
/// </summary>
public enum TexturecubeFace : uint {
	/// <summary>
	/// <b>D3D11_TEXTURECUBE_FACE_POSITIVE_X</b> = 0
	/// </summary>
	PositiveX = 0,
	/// <summary>
	/// <b>D3D11_TEXTURECUBE_FACE_NEGATIVE_X</b> = 1
	/// </summary>
	NegativeX = 1,
	/// <summary>
	/// <b>D3D11_TEXTURECUBE_FACE_POSITIVE_Y</b> = 2
	/// </summary>
	PositiveY = 2,
	/// <summary>
	/// <b>D3D11_TEXTURECUBE_FACE_NEGATIVE_Y</b> = 3
	/// </summary>
	NegativeY = 3,
	/// <summary>
	/// <b>D3D11_TEXTURECUBE_FACE_POSITIVE_Z</b> = 4
	/// </summary>
	PositiveZ = 4,
	/// <summary>
	/// <b>D3D11_TEXTURECUBE_FACE_NEGATIVE_Z</b> = 5
	/// </summary>
	NegativeZ = 5,
}

/// <summary>
/// ENUM <b>D3D11_BUFFEREX_SRV_FLAG</b><br/>
/// D3D11.h
/// </summary>
public enum BufferexSrvFlag : uint {
	/// <summary>
	/// <b>D3D11_BUFFEREX_SRV_FLAG_RAW</b> = 0x1
	/// </summary>
	Raw = 1,
}

/// <summary>
/// ENUM <b>D3D11_DSV_FLAG</b><br/>
/// D3D11.h
/// </summary>
public enum DsvFlag : uint {
	/// <summary>
	/// <b>D3D11_DSV_READ_ONLY_DEPTH</b> = 0x1L
	/// </summary>
	ReadOnlyDepth = 1,
	/// <summary>
	/// <b>D3D11_DSV_READ_ONLY_STENCIL</b> = 0x2L
	/// </summary>
	ReadOnlyStencil = 2,
}

/// <summary>
/// ENUM <b>D3D11_BUFFER_UAV_FLAG</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum BufferUavFlag : uint {
	/// <summary>
	/// <b>D3D11_BUFFER_UAV_FLAG_RAW</b> = 0x1
	/// </summary>
	Raw = 1,
	/// <summary>
	/// <b>D3D11_BUFFER_UAV_FLAG_APPEND</b> = 0x2
	/// </summary>
	Append = 2,
	/// <summary>
	/// <b>D3D11_BUFFER_UAV_FLAG_COUNTER</b> = 0x4
	/// </summary>
	Counter = 4,
}

/// <summary>
/// ENUM <b>D3D11_FILTER</b><br/>
/// D3D11.h
/// </summary>
public enum Filter : uint {
	/// <summary>
	/// <b>D3D11_FILTER_MIN_MAG_MIP_POINT</b> = 0
	/// </summary>
	MinMagMipPoint = 0,
	/// <summary>
	/// <b>D3D11_FILTER_MIN_MAG_POINT_MIP_LINEAR</b> = 0x1
	/// </summary>
	MinMagPointMipLinear = 1,
	/// <summary>
	/// <b>D3D11_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x4
	/// </summary>
	MinPointMagLinearMipPoint = 4,
	/// <summary>
	/// <b>D3D11_FILTER_MIN_POINT_MAG_MIP_LINEAR</b> = 0x5
	/// </summary>
	MinPointMagMipLinear = 5,
	/// <summary>
	/// <b>D3D11_FILTER_MIN_LINEAR_MAG_MIP_POINT</b> = 0x10
	/// </summary>
	MinLinearMagMipPoint = 16,
	/// <summary>
	/// <b>D3D11_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x11
	/// </summary>
	MinLinearMagPointMipLinear = 17,
	/// <summary>
	/// <b>D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT</b> = 0x14
	/// </summary>
	MinMagLinearMipPoint = 20,
	/// <summary>
	/// <b>D3D11_FILTER_MIN_MAG_MIP_LINEAR</b> = 0x15
	/// </summary>
	MinMagMipLinear = 21,
	/// <summary>
	/// <b>D3D11_FILTER_ANISOTROPIC</b> = 0x55
	/// </summary>
	Anisotropic = 85,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_MAG_MIP_POINT</b> = 0x80
	/// </summary>
	ComparisonMinMagMipPoint = 128,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR</b> = 0x81
	/// </summary>
	ComparisonMinMagPointMipLinear = 129,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x84
	/// </summary>
	ComparisonMinPointMagLinearMipPoint = 132,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR</b> = 0x85
	/// </summary>
	ComparisonMinPointMagMipLinear = 133,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT</b> = 0x90
	/// </summary>
	ComparisonMinLinearMagMipPoint = 144,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x91
	/// </summary>
	ComparisonMinLinearMagPointMipLinear = 145,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT</b> = 0x94
	/// </summary>
	ComparisonMinMagLinearMipPoint = 148,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR</b> = 0x95
	/// </summary>
	ComparisonMinMagMipLinear = 149,
	/// <summary>
	/// <b>D3D11_FILTER_COMPARISON_ANISOTROPIC</b> = 0xd5
	/// </summary>
	ComparisonAnisotropic = 213,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_MAG_MIP_POINT</b> = 0x100
	/// </summary>
	MinimumMinMagMipPoint = 256,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR</b> = 0x101
	/// </summary>
	MinimumMinMagPointMipLinear = 257,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x104
	/// </summary>
	MinimumMinPointMagLinearMipPoint = 260,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR</b> = 0x105
	/// </summary>
	MinimumMinPointMagMipLinear = 261,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT</b> = 0x110
	/// </summary>
	MinimumMinLinearMagMipPoint = 272,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x111
	/// </summary>
	MinimumMinLinearMagPointMipLinear = 273,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT</b> = 0x114
	/// </summary>
	MinimumMinMagLinearMipPoint = 276,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR</b> = 0x115
	/// </summary>
	MinimumMinMagMipLinear = 277,
	/// <summary>
	/// <b>D3D11_FILTER_MINIMUM_ANISOTROPIC</b> = 0x155
	/// </summary>
	MinimumAnisotropic = 341,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_POINT</b> = 0x180
	/// </summary>
	MaximumMinMagMipPoint = 384,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR</b> = 0x181
	/// </summary>
	MaximumMinMagPointMipLinear = 385,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x184
	/// </summary>
	MaximumMinPointMagLinearMipPoint = 388,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR</b> = 0x185
	/// </summary>
	MaximumMinPointMagMipLinear = 389,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT</b> = 0x190
	/// </summary>
	MaximumMinLinearMagMipPoint = 400,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x191
	/// </summary>
	MaximumMinLinearMagPointMipLinear = 401,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT</b> = 0x194
	/// </summary>
	MaximumMinMagLinearMipPoint = 404,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR</b> = 0x195
	/// </summary>
	MaximumMinMagMipLinear = 405,
	/// <summary>
	/// <b>D3D11_FILTER_MAXIMUM_ANISOTROPIC</b> = 0x1d5
	/// </summary>
	MaximumAnisotropic = 469,
}

/// <summary>
/// ENUM <b>D3D11_FILTER_TYPE</b><br/>
/// D3D11.h
/// </summary>
public enum FilterType : uint {
	/// <summary>
	/// <b>D3D11_FILTER_TYPE_POINT</b> = 0
	/// </summary>
	Point = 0,
	/// <summary>
	/// <b>D3D11_FILTER_TYPE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
}

/// <summary>
/// ENUM <b>D3D11_FILTER_REDUCTION_TYPE</b><br/>
/// D3D11.h
/// </summary>
public enum FilterReductionType : uint {
	/// <summary>
	/// <b>D3D11_FILTER_REDUCTION_TYPE_STANDARD</b> = 0
	/// </summary>
	Standard = 0,
	/// <summary>
	/// <b>D3D11_FILTER_REDUCTION_TYPE_COMPARISON</b> = 1
	/// </summary>
	Comparison = 1,
	/// <summary>
	/// <b>D3D11_FILTER_REDUCTION_TYPE_MINIMUM</b> = 2
	/// </summary>
	Minimum = 2,
	/// <summary>
	/// <b>D3D11_FILTER_REDUCTION_TYPE_MAXIMUM</b> = 3
	/// </summary>
	Maximum = 3,
}

/// <summary>
/// ENUM <b>D3D11_TEXTURE_ADDRESS_MODE</b><br/>
/// D3D11.h
/// </summary>
public enum TextureAddressMode : uint {
	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_WRAP</b> = 1
	/// </summary>
	Wrap = 1,
	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_MIRROR</b> = 2
	/// </summary>
	Mirror = 2,
	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_CLAMP</b> = 3
	/// </summary>
	Clamp = 3,
	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_BORDER</b> = 4
	/// </summary>
	Border = 4,
	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_MIRROR_ONCE</b> = 5
	/// </summary>
	MirrorOnce = 5,
}

/// <summary>
/// ENUM <b>D3D11_FORMAT_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum FormatSupport : uint {
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_BUFFER</b> = 0x1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_IA_VERTEX_BUFFER</b> = 0x2
	/// </summary>
	IaVertexBuffer = 2,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_IA_INDEX_BUFFER</b> = 0x4
	/// </summary>
	IaIndexBuffer = 4,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_SO_BUFFER</b> = 0x8
	/// </summary>
	SoBuffer = 8,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_TEXTURE1D</b> = 0x10
	/// </summary>
	Texture1d = 16,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_TEXTURE2D</b> = 0x20
	/// </summary>
	Texture2d = 32,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_TEXTURE3D</b> = 0x40
	/// </summary>
	Texture3d = 64,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_TEXTURECUBE</b> = 0x80
	/// </summary>
	Texturecube = 128,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_SHADER_LOAD</b> = 0x100
	/// </summary>
	ShaderLoad = 256,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_SHADER_SAMPLE</b> = 0x200
	/// </summary>
	ShaderSample = 512,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON</b> = 0x400
	/// </summary>
	ShaderSampleComparison = 1024,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT</b> = 0x800
	/// </summary>
	ShaderSampleMonoText = 2048,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_MIP</b> = 0x1000
	/// </summary>
	Mip = 4096,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_MIP_AUTOGEN</b> = 0x2000
	/// </summary>
	MipAutogen = 8192,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_RENDER_TARGET</b> = 0x4000
	/// </summary>
	RenderTarget = 16384,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_BLENDABLE</b> = 0x8000
	/// </summary>
	Blendable = 32768,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_DEPTH_STENCIL</b> = 0x10000
	/// </summary>
	DepthStencil = 65536,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_CPU_LOCKABLE</b> = 0x20000
	/// </summary>
	CpuLockable = 131072,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE</b> = 0x40000
	/// </summary>
	MultisampleResolve = 262144,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_DISPLAY</b> = 0x80000
	/// </summary>
	Display = 524288,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT</b> = 0x100000
	/// </summary>
	CastWithinBitLayout = 1048576,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET</b> = 0x200000
	/// </summary>
	MultisampleRendertarget = 2097152,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_MULTISAMPLE_LOAD</b> = 0x400000
	/// </summary>
	MultisampleLoad = 4194304,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_SHADER_GATHER</b> = 0x800000
	/// </summary>
	ShaderGather = 8388608,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_BACK_BUFFER_CAST</b> = 0x1000000
	/// </summary>
	BackBufferCast = 16777216,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_TYPED_UNORDERED_ACCESS_VIEW</b> = 0x2000000
	/// </summary>
	TypedUnorderedAccessView = 33554432,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_SHADER_GATHER_COMPARISON</b> = 0x4000000
	/// </summary>
	ShaderGatherComparison = 67108864,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_DECODER_OUTPUT</b> = 0x8000000
	/// </summary>
	DecoderOutput = 134217728,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_OUTPUT</b> = 0x10000000
	/// </summary>
	VideoProcessorOutput = 268435456,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_INPUT</b> = 0x20000000
	/// </summary>
	VideoProcessorInput = 536870912,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT_VIDEO_ENCODER</b> = 0x40000000
	/// </summary>
	VideoEncoder = 1073741824,
}

/// <summary>
/// ENUM <b>D3D11_FORMAT_SUPPORT2</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum FormatSupport2 : uint {
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD</b> = 0x1
	/// </summary>
	UavAtomicAdd = 1,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS</b> = 0x2
	/// </summary>
	UavAtomicBitwiseOps = 2,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE</b> = 0x4
	/// </summary>
	UavAtomicCompareStoreOrCompareExchange = 4,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE</b> = 0x8
	/// </summary>
	UavAtomicExchange = 8,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX</b> = 0x10
	/// </summary>
	UavAtomicSignedMinOrMax = 16,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX</b> = 0x20
	/// </summary>
	UavAtomicUnsignedMinOrMax = 32,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD</b> = 0x40
	/// </summary>
	UavTypedLoad = 64,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE</b> = 0x80
	/// </summary>
	UavTypedStore = 128,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP</b> = 0x100
	/// </summary>
	OutputMergerLogicOp = 256,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_TILED</b> = 0x200
	/// </summary>
	Tiled = 512,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_SHAREABLE</b> = 0x400
	/// </summary>
	Shareable = 1024,
	/// <summary>
	/// <b>D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY</b> = 0x4000
	/// </summary>
	MultiplaneOverlay = 16384,
}

/// <summary>
/// ENUM <b>D3D11_ASYNC_GETDATA_FLAG</b><br/>
/// D3D11.h
/// </summary>
public enum AsyncGetdataFlag : uint {
	/// <summary>
	/// <b>D3D11_ASYNC_GETDATA_DONOTFLUSH</b> = 0x1
	/// </summary>
	Donotflush = 1,
}

/// <summary>
/// ENUM <b>D3D11_QUERY</b><br/>
/// D3D11.h
/// </summary>
public enum QueryEnum : uint {
	/// <summary>
	/// <b>D3D11_QUERY_EVENT</b> = 0
	/// </summary>
	Event = 0,
	/// <summary>
	/// <b>D3D11_QUERY_OCCLUSION</b> = ( D3D11_QUERY_EVENT + 1 )
	/// </summary>
	Occlusion = Event + 1,
	/// <summary>
	/// <b>D3D11_QUERY_TIMESTAMP</b> = ( D3D11_QUERY_OCCLUSION + 1 )
	/// </summary>
	Timestamp = Occlusion + 1,
	/// <summary>
	/// <b>D3D11_QUERY_TIMESTAMP_DISJOINT</b> = ( D3D11_QUERY_TIMESTAMP + 1 )
	/// </summary>
	TimestampDisjoint = Timestamp + 1,
	/// <summary>
	/// <b>D3D11_QUERY_PIPELINE_STATISTICS</b> = ( D3D11_QUERY_TIMESTAMP_DISJOINT + 1 )
	/// </summary>
	PipelineStatistics = TimestampDisjoint + 1,
	/// <summary>
	/// <b>D3D11_QUERY_OCCLUSION_PREDICATE</b> = ( D3D11_QUERY_PIPELINE_STATISTICS + 1 )
	/// </summary>
	OcclusionPredicate = PipelineStatistics + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_STATISTICS</b> = ( D3D11_QUERY_OCCLUSION_PREDICATE + 1 )
	/// </summary>
	SoStatistics = OcclusionPredicate + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_OVERFLOW_PREDICATE</b> = ( D3D11_QUERY_SO_STATISTICS + 1 )
	/// </summary>
	SoOverflowPredicate = SoStatistics + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_STATISTICS_STREAM0</b> = ( D3D11_QUERY_SO_OVERFLOW_PREDICATE + 1 )
	/// </summary>
	SoStatisticsStream0 = SoOverflowPredicate + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0</b> = ( D3D11_QUERY_SO_STATISTICS_STREAM0 + 1 )
	/// </summary>
	SoOverflowPredicateStream0 = SoStatisticsStream0 + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_STATISTICS_STREAM1</b> = ( D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0 + 1 )
	/// </summary>
	SoStatisticsStream1 = SoOverflowPredicateStream0 + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1</b> = ( D3D11_QUERY_SO_STATISTICS_STREAM1 + 1 )
	/// </summary>
	SoOverflowPredicateStream1 = SoStatisticsStream1 + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_STATISTICS_STREAM2</b> = ( D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1 + 1 )
	/// </summary>
	SoStatisticsStream2 = SoOverflowPredicateStream1 + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2</b> = ( D3D11_QUERY_SO_STATISTICS_STREAM2 + 1 )
	/// </summary>
	SoOverflowPredicateStream2 = SoStatisticsStream2 + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_STATISTICS_STREAM3</b> = ( D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2 + 1 )
	/// </summary>
	SoStatisticsStream3 = SoOverflowPredicateStream2 + 1,
	/// <summary>
	/// <b>D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM3</b> = ( D3D11_QUERY_SO_STATISTICS_STREAM3 + 1 )
	/// </summary>
	SoOverflowPredicateStream3 = SoStatisticsStream3 + 1,
}

/// <summary>
/// ENUM <b>D3D11_QUERY_MISC_FLAG</b><br/>
/// D3D11.h
/// </summary>
public enum QueryMiscFlag : uint {
	/// <summary>
	/// <b>D3D11_QUERY_MISC_PREDICATEHINT</b> = 0x1
	/// </summary>
	Predicatehint = 1,
}

/// <summary>
/// ENUM <b>D3D11_COUNTER</b><br/>
/// D3D11.h
/// </summary>
public enum CounterEnum : uint {
	/// <summary>
	/// <b>D3D11_COUNTER_DEVICE_DEPENDENT_0</b> = 0x40000000
	/// </summary>
	DeviceDependent0 = 1073741824,
}

/// <summary>
/// ENUM <b>D3D11_COUNTER_TYPE</b><br/>
/// D3D11.h
/// </summary>
public enum CounterType : uint {
	/// <summary>
	/// <b>D3D11_COUNTER_TYPE_FLOAT32</b> = 0
	/// </summary>
	Float32 = 0,
	/// <summary>
	/// <b>D3D11_COUNTER_TYPE_UINT16</b> = ( D3D11_COUNTER_TYPE_FLOAT32 + 1 )
	/// </summary>
	Uint16 = Float32 + 1,
	/// <summary>
	/// <b>D3D11_COUNTER_TYPE_UINT32</b> = ( D3D11_COUNTER_TYPE_UINT16 + 1 )
	/// </summary>
	Uint32 = Uint16 + 1,
	/// <summary>
	/// <b>D3D11_COUNTER_TYPE_UINT64</b> = ( D3D11_COUNTER_TYPE_UINT32 + 1 )
	/// </summary>
	Uint64 = Uint32 + 1,
}

/// <summary>
/// ENUM <b>D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS</b><br/>
/// D3D11.h
/// </summary>
public enum StandardMultisampleQualityLevels : uint {
	/// <summary>
	/// <b>D3D11_STANDARD_MULTISAMPLE_PATTERN</b> = 0xffffffff
	/// </summary>
	Pattern = 4294967295,
	/// <summary>
	/// <b>D3D11_CENTER_MULTISAMPLE_PATTERN</b> = 0xfffffffe
	/// </summary>
	CenterMultisamplePattern = 4294967294,
}

/// <summary>
/// ENUM <b>D3D11_DEVICE_CONTEXT_TYPE</b><br/>
/// D3D11.h
/// </summary>
public enum DeviceContextType : uint {
	/// <summary>
	/// <b>D3D11_DEVICE_CONTEXT_IMMEDIATE</b> = 0
	/// </summary>
	Immediate = 0,
	/// <summary>
	/// <b>D3D11_DEVICE_CONTEXT_DEFERRED</b> = ( D3D11_DEVICE_CONTEXT_IMMEDIATE + 1 )
	/// </summary>
	Deferred = Immediate + 1,
}

/// <summary>
/// ENUM <b>D3D11_FEATURE</b><br/>
/// D3D11.h
/// </summary>
public enum Feature : uint {
	/// <summary>
	/// <b>D3D11_FEATURE_THREADING</b> = 0
	/// </summary>
	Threading = 0,
	/// <summary>
	/// <b>D3D11_FEATURE_DOUBLES</b> = ( D3D11_FEATURE_THREADING + 1 )
	/// </summary>
	Doubles = Threading + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_FORMAT_SUPPORT</b> = ( D3D11_FEATURE_DOUBLES + 1 )
	/// </summary>
	FormatSupport = Doubles + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_FORMAT_SUPPORT2</b> = ( D3D11_FEATURE_FORMAT_SUPPORT + 1 )
	/// </summary>
	FormatSupport2 = FormatSupport + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS</b> = ( D3D11_FEATURE_FORMAT_SUPPORT2 + 1 )
	/// </summary>
	D3d10XHardwareOptions = FormatSupport2 + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D11_OPTIONS</b> = ( D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS + 1 )
	/// </summary>
	D3d11Options = D3d10XHardwareOptions + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_ARCHITECTURE_INFO</b> = ( D3D11_FEATURE_D3D11_OPTIONS + 1 )
	/// </summary>
	ArchitectureInfo = D3d11Options + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D9_OPTIONS</b> = ( D3D11_FEATURE_ARCHITECTURE_INFO + 1 )
	/// </summary>
	D3d9Options = ArchitectureInfo + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT</b> = ( D3D11_FEATURE_D3D9_OPTIONS + 1 )
	/// </summary>
	ShaderMinPrecisionSupport = D3d9Options + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D9_SHADOW_SUPPORT</b> = ( D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT + 1 )
	/// </summary>
	D3d9ShadowSupport = ShaderMinPrecisionSupport + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D11_OPTIONS1</b> = ( D3D11_FEATURE_D3D9_SHADOW_SUPPORT + 1 )
	/// </summary>
	D3d11Options1 = D3d9ShadowSupport + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT</b> = ( D3D11_FEATURE_D3D11_OPTIONS1 + 1 )
	/// </summary>
	D3d9SimpleInstancingSupport = D3d11Options1 + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_MARKER_SUPPORT</b> = ( D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT + 1 )
	/// </summary>
	MarkerSupport = D3d9SimpleInstancingSupport + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D9_OPTIONS1</b> = ( D3D11_FEATURE_MARKER_SUPPORT + 1 )
	/// </summary>
	D3d9Options1 = MarkerSupport + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D11_OPTIONS2</b> = ( D3D11_FEATURE_D3D9_OPTIONS1 + 1 )
	/// </summary>
	D3d11Options2 = D3d9Options1 + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D11_OPTIONS3</b> = ( D3D11_FEATURE_D3D11_OPTIONS2 + 1 )
	/// </summary>
	D3d11Options3 = D3d11Options2 + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT</b> = ( D3D11_FEATURE_D3D11_OPTIONS3 + 1 )
	/// </summary>
	GpuVirtualAddressSupport = D3d11Options3 + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D11_OPTIONS4</b> = ( D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT + 1 )
	/// </summary>
	D3d11Options4 = GpuVirtualAddressSupport + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_SHADER_CACHE</b> = ( D3D11_FEATURE_D3D11_OPTIONS4 + 1 )
	/// </summary>
	ShaderCache = D3d11Options4 + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_D3D11_OPTIONS5</b> = ( D3D11_FEATURE_SHADER_CACHE + 1 )
	/// </summary>
	D3d11Options5 = ShaderCache + 1,
	/// <summary>
	/// <b>D3D11_FEATURE_DISPLAYABLE</b> = ( D3D11_FEATURE_D3D11_OPTIONS5 + 1 )
	/// </summary>
	Displayable = D3d11Options5 + 1,
}

/// <summary>
/// ENUM <b>D3D11_SHADER_MIN_PRECISION_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
public enum ShaderMinPrecisionSupport : uint {
	/// <summary>
	/// <b>D3D11_SHADER_MIN_PRECISION_10_BIT</b> = 0x1
	/// </summary>
	Precision10Bit = 1,
	/// <summary>
	/// <b>D3D11_SHADER_MIN_PRECISION_16_BIT</b> = 0x2
	/// </summary>
	Precision16Bit = 2,
}

/// <summary>
/// ENUM <b>D3D11_TILED_RESOURCES_TIER</b><br/>
/// D3D11.h
/// </summary>
public enum TiledResourcesTier : uint {
	/// <summary>
	/// <b>D3D11_TILED_RESOURCES_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D11_TILED_RESOURCES_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D11_TILED_RESOURCES_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
	/// <summary>
	/// <b>D3D11_TILED_RESOURCES_TIER_3</b> = 3
	/// </summary>
	Tier3 = 3,
}

/// <summary>
/// ENUM <b>D3D11_CONSERVATIVE_RASTERIZATION_TIER</b><br/>
/// D3D11.h
/// </summary>
public enum ConservativeRasterizationTier : uint {
	/// <summary>
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
	/// <summary>
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_TIER_3</b> = 3
	/// </summary>
	Tier3 = 3,
}

/// <summary>
/// ENUM <b>D3D11_SHADER_CACHE_SUPPORT_FLAGS</b><br/>
/// D3D11.h
/// </summary>
public enum ShaderCacheSupportFlags : uint {
	/// <summary>
	/// <b>D3D11_SHADER_CACHE_SUPPORT_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE</b> = 0x1
	/// </summary>
	AutomaticInprocCache = 1,
	/// <summary>
	/// <b>D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE</b> = 0x2
	/// </summary>
	AutomaticDiskCache = 2,
}

/// <summary>
/// ENUM <b>D3D11_SHARED_RESOURCE_TIER</b><br/>
/// D3D11.h
/// </summary>
public enum SharedResourceTier : uint {
	/// <summary>
	/// <b>D3D11_SHARED_RESOURCE_TIER_0</b> = 0
	/// </summary>
	Tier0 = 0,
	/// <summary>
	/// <b>D3D11_SHARED_RESOURCE_TIER_1</b> = ( D3D11_SHARED_RESOURCE_TIER_0 + 1 )
	/// </summary>
	Tier1 = Tier0 + 1,
	/// <summary>
	/// <b>D3D11_SHARED_RESOURCE_TIER_2</b> = ( D3D11_SHARED_RESOURCE_TIER_1 + 1 )
	/// </summary>
	Tier2 = Tier1 + 1,
	/// <summary>
	/// <b>D3D11_SHARED_RESOURCE_TIER_3</b> = ( D3D11_SHARED_RESOURCE_TIER_2 + 1 )
	/// </summary>
	Tier3 = Tier2 + 1,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_DECODER_BUFFER_TYPE</b><br/>
/// D3D11.h
/// </summary>
public enum VideoDecoderBufferType : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS</b> = 0
	/// </summary>
	PictureParameters = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL</b> = 1
	/// </summary>
	MacroblockControl = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE</b> = 2
	/// </summary>
	ResidualDifference = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL</b> = 3
	/// </summary>
	DeblockingControl = 3,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX</b> = 4
	/// </summary>
	InverseQuantizationMatrix = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL</b> = 5
	/// </summary>
	SliceControl = 5,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_BITSTREAM</b> = 6
	/// </summary>
	Bitstream = 6,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR</b> = 7
	/// </summary>
	MotionVector = 7,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN</b> = 8
	/// </summary>
	FilmGrain = 8,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorFormatSupport : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_INPUT</b> = 0x1
	/// </summary>
	Input = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_OUTPUT</b> = 0x2
	/// </summary>
	Output = 2,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_DEVICE_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorDeviceCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE</b> = 0x1
	/// </summary>
	LinearSpace = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC</b> = 0x2
	/// </summary>
	XvYCC = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION</b> = 0x4
	/// </summary>
	RgbRangeConversion = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION</b> = 0x8
	/// </summary>
	YCbCrMatrixConversion = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE</b> = 0x10
	/// </summary>
	NominalRange = 16,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorFeatureCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_FILL</b> = 0x1
	/// </summary>
	AlphaFill = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_CONSTRICTION</b> = 0x2
	/// </summary>
	Constriction = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LUMA_KEY</b> = 0x4
	/// </summary>
	LumaKey = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_PALETTE</b> = 0x8
	/// </summary>
	AlphaPalette = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LEGACY</b> = 0x10
	/// </summary>
	Legacy = 16,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_STEREO</b> = 0x20
	/// </summary>
	Stereo = 32,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ROTATION</b> = 0x40
	/// </summary>
	Rotation = 64,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_STREAM</b> = 0x80
	/// </summary>
	AlphaStream = 128,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_PIXEL_ASPECT_RATIO</b> = 0x100
	/// </summary>
	PixelAspectRatio = 256,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_MIRROR</b> = 0x200
	/// </summary>
	Mirror = 512,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_SHADER_USAGE</b> = 0x400
	/// </summary>
	ShaderUsage = 1024,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_METADATA_HDR10</b> = 0x800
	/// </summary>
	MetadataHdr10 = 2048,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorFilterCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS</b> = 0x1
	/// </summary>
	Brightness = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST</b> = 0x2
	/// </summary>
	Contrast = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE</b> = 0x4
	/// </summary>
	Hue = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION</b> = 0x8
	/// </summary>
	Saturation = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION</b> = 0x10
	/// </summary>
	NoiseReduction = 16,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT</b> = 0x20
	/// </summary>
	EdgeEnhancement = 32,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING</b> = 0x40
	/// </summary>
	AnamorphicScaling = 64,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT</b> = 0x80
	/// </summary>
	StereoAdjustment = 128,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_FORMAT_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorFormatCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_INTERLACED</b> = 0x1
	/// </summary>
	RgbInterlaced = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_PROCAMP</b> = 0x2
	/// </summary>
	RgbProcamp = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_LUMA_KEY</b> = 0x4
	/// </summary>
	RgbLumaKey = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_PALETTE_INTERLACED</b> = 0x8
	/// </summary>
	PaletteInterlaced = 8,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorAutoStreamCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DENOISE</b> = 0x1
	/// </summary>
	Denoise = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DERINGING</b> = 0x2
	/// </summary>
	Deringing = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_EDGE_ENHANCEMENT</b> = 0x4
	/// </summary>
	EdgeEnhancement = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_COLOR_CORRECTION</b> = 0x8
	/// </summary>
	ColorCorrection = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_FLESH_TONE_MAPPING</b> = 0x10
	/// </summary>
	FleshToneMapping = 16,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_IMAGE_STABILIZATION</b> = 0x20
	/// </summary>
	ImageStabilization = 32,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_SUPER_RESOLUTION</b> = 0x40
	/// </summary>
	SuperResolution = 64,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_ANAMORPHIC_SCALING</b> = 0x80
	/// </summary>
	AnamorphicScaling = 128,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_STEREO_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorStereoCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_CAPS_MONO_OFFSET</b> = 0x1
	/// </summary>
	MonoOffset = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_CAPS_ROW_INTERLEAVED</b> = 0x2
	/// </summary>
	RowInterleaved = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_CAPS_COLUMN_INTERLEAVED</b> = 0x4
	/// </summary>
	ColumnInterleaved = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_CAPS_CHECKERBOARD</b> = 0x8
	/// </summary>
	Checkerboard = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_CAPS_FLIP_MODE</b> = 0x10
	/// </summary>
	FlipMode = 16,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorProcessorCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND</b> = 0x1
	/// </summary>
	DeinterlaceBlend = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB</b> = 0x2
	/// </summary>
	DeinterlaceBob = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE</b> = 0x4
	/// </summary>
	DeinterlaceAdaptive = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION</b> = 0x8
	/// </summary>
	DeinterlaceMotionCompensation = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE</b> = 0x10
	/// </summary>
	InverseTelecine = 16,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION</b> = 0x20
	/// </summary>
	FrameRateConversion = 32,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum VideoProcessorItelecineCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32</b> = 0x1
	/// </summary>
	Caps32 = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_22</b> = 0x2
	/// </summary>
	Caps22 = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2224</b> = 0x4
	/// </summary>
	Caps2224 = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2332</b> = 0x8
	/// </summary>
	Caps2332 = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32322</b> = 0x10
	/// </summary>
	Caps32322 = 16,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_55</b> = 0x20
	/// </summary>
	Caps55 = 32,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_64</b> = 0x40
	/// </summary>
	Caps64 = 64,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_87</b> = 0x80
	/// </summary>
	Caps87 = 128,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_222222222223</b> = 0x100
	/// </summary>
	Caps222222222223 = 256,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_OTHER</b> = 0x80000000
	/// </summary>
	Other = 2147483648,
}

/// <summary>
/// ENUM <b>D3D11_CONTENT_PROTECTION_CAPS</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum ContentProtectionCaps : uint {
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE</b> = 0x1
	/// </summary>
	Software = 1,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_HARDWARE</b> = 0x2
	/// </summary>
	Hardware = 2,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON</b> = 0x4
	/// </summary>
	ProtectionAlwaysOn = 4,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION</b> = 0x8
	/// </summary>
	PartialDecryption = 8,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY</b> = 0x10
	/// </summary>
	ContentKey = 16,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY</b> = 0x20
	/// </summary>
	FreshenSessionKey = 32,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK</b> = 0x40
	/// </summary>
	EncryptedReadBack = 64,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY</b> = 0x80
	/// </summary>
	EncryptedReadBackKey = 128,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV</b> = 0x100
	/// </summary>
	SequentialCtrIv = 256,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY</b> = 0x200
	/// </summary>
	EncryptSlicedataOnly = 512,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT</b> = 0x400
	/// </summary>
	DecryptionBlt = 1024,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED</b> = 0x800
	/// </summary>
	HardwareProtectUncompressed = 2048,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE</b> = 0x1000
	/// </summary>
	HardwareProtectedMemoryPageable = 4096,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN</b> = 0x2000
	/// </summary>
	HardwareTeardown = 8192,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION</b> = 0x4000
	/// </summary>
	HardwareDrmCommunication = 16384,
	/// <summary>
	/// <b>D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED</b> = 0x8000
	/// </summary>
	HardwareDrmCommunicationMultiThreaded = 32768,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_FILTER</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorFilter : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_BRIGHTNESS</b> = 0
	/// </summary>
	Brightness = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_CONTRAST</b> = 1
	/// </summary>
	Contrast = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_HUE</b> = 2
	/// </summary>
	Hue = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_SATURATION</b> = 3
	/// </summary>
	Saturation = 3,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_NOISE_REDUCTION</b> = 4
	/// </summary>
	NoiseReduction = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_EDGE_ENHANCEMENT</b> = 5
	/// </summary>
	EdgeEnhancement = 5,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_ANAMORPHIC_SCALING</b> = 6
	/// </summary>
	AnamorphicScaling = 6,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_FILTER_STEREO_ADJUSTMENT</b> = 7
	/// </summary>
	StereoAdjustment = 7,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_FRAME_FORMAT</b><br/>
/// D3D11.h
/// </summary>
public enum VideoFrameFormat : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_FRAME_FORMAT_PROGRESSIVE</b> = 0
	/// </summary>
	Progressive = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_FRAME_FORMAT_INTERLACED_TOP_FIELD_FIRST</b> = 1
	/// </summary>
	InterlacedTopFieldFirst = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_FRAME_FORMAT_INTERLACED_BOTTOM_FIELD_FIRST</b> = 2
	/// </summary>
	InterlacedBottomFieldFirst = 2,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_USAGE</b><br/>
/// D3D11.h
/// </summary>
public enum VideoUsage : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_USAGE_PLAYBACK_NORMAL</b> = 0
	/// </summary>
	PlaybackNormal = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_USAGE_OPTIMAL_SPEED</b> = 1
	/// </summary>
	OptimalSpeed = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_USAGE_OPTIMAL_QUALITY</b> = 2
	/// </summary>
	OptimalQuality = 2,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorNominalRange : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235</b> = 1
	/// </summary>
	Range16235 = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255</b> = 2
	/// </summary>
	Range0255 = 2,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorAlphaFillMode : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE</b> = 0
	/// </summary>
	Opaque = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND</b> = 1
	/// </summary>
	Background = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION</b> = 2
	/// </summary>
	Destination = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM</b> = 3
	/// </summary>
	SourceStream = 3,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_OUTPUT_RATE</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorOutputRate : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_NORMAL</b> = 0
	/// </summary>
	Normal = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_HALF</b> = 1
	/// </summary>
	Half = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_CUSTOM</b> = 2
	/// </summary>
	Custom = 2,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorStereoFormat : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO</b> = 0
	/// </summary>
	Mono = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL</b> = 1
	/// </summary>
	Horizontal = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL</b> = 2
	/// </summary>
	Vertical = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE</b> = 3
	/// </summary>
	Separate = 3,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET</b> = 4
	/// </summary>
	MonoOffset = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED</b> = 5
	/// </summary>
	RowInterleaved = 5,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED</b> = 6
	/// </summary>
	ColumnInterleaved = 6,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD</b> = 7
	/// </summary>
	Checkerboard = 7,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorStereoFlipMode : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FLIP_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME0</b> = 1
	/// </summary>
	Frame0 = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME1</b> = 2
	/// </summary>
	Frame1 = 2,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_ROTATION</b><br/>
/// D3D11.h
/// </summary>
public enum VideoProcessorRotation : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ROTATION_IDENTITY</b> = 0
	/// </summary>
	Identity = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ROTATION_90</b> = 1
	/// </summary>
	Rotation90 = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ROTATION_180</b> = 2
	/// </summary>
	Rotation180 = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_ROTATION_270</b> = 3
	/// </summary>
	Rotation270 = 3,
}

/// <summary>
/// ENUM <b>D3D11_AUTHENTICATED_CHANNEL_TYPE</b><br/>
/// D3D11.h
/// </summary>
public enum AuthenticatedChannelType : uint {
	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CHANNEL_D3D11</b> = 1
	/// </summary>
	D3d11 = 1,
	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE</b> = 2
	/// </summary>
	DriverSoftware = 2,
	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE</b> = 3
	/// </summary>
	DriverHardware = 3,
}

/// <summary>
/// ENUM <b>D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE</b><br/>
/// D3D11.h
/// </summary>
public enum AuthenticatedProcessIdentifierType : uint {
	/// <summary>
	/// <b>D3D11_PROCESSIDTYPE_UNKNOWN</b> = 0
	/// </summary>
	ProcessidtypeUnknown = 0,
	/// <summary>
	/// <b>D3D11_PROCESSIDTYPE_DWM</b> = 1
	/// </summary>
	ProcessidtypeDwm = 1,
	/// <summary>
	/// <b>D3D11_PROCESSIDTYPE_HANDLE</b> = 2
	/// </summary>
	ProcessidtypeHandle = 2,
}

/// <summary>
/// ENUM <b>D3D11_BUS_TYPE</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum BusType : uint {
	/// <summary>
	/// <b>D3D11_BUS_TYPE_OTHER</b> = 0
	/// </summary>
	Other = 0,
	/// <summary>
	/// <b>D3D11_BUS_TYPE_PCI</b> = 0x1
	/// </summary>
	Pci = 1,
	/// <summary>
	/// <b>D3D11_BUS_TYPE_PCIX</b> = 0x2
	/// </summary>
	Pcix = 2,
	/// <summary>
	/// <b>D3D11_BUS_TYPE_PCIEXPRESS</b> = 0x3
	/// </summary>
	Pciexpress = 3,
	/// <summary>
	/// <b>D3D11_BUS_TYPE_AGP</b> = 0x4
	/// </summary>
	Agp = 4,
	/// <summary>
	/// <b>D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET</b> = 0x10000
	/// </summary>
	ImplModifierInsideOfChipset = 65536,
	/// <summary>
	/// <b>D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP</b> = 0x20000
	/// </summary>
	ImplModifierTracksOnMotherBoardToChip = 131072,
	/// <summary>
	/// <b>D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET</b> = 0x30000
	/// </summary>
	ImplModifierTracksOnMotherBoardToSocket = 196608,
	/// <summary>
	/// <b>D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR</b> = 0x40000
	/// </summary>
	ImplModifierDaughterBoardConnector = 262144,
	/// <summary>
	/// <b>D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE</b> = 0x50000
	/// </summary>
	ImplModifierDaughterBoardConnectorInsideOfNuae = 327680,
	/// <summary>
	/// <b>D3D11_BUS_IMPL_MODIFIER_NON_STANDARD</b> = 0x80000000
	/// </summary>
	ImplModifierNonStandard = 2147483648,
}

/// <summary>
/// ENUM <b>D3D11_VDOV_DIMENSION</b><br/>
/// D3D11.h
/// </summary>
public enum VdovDimension : uint {
	/// <summary>
	/// <b>D3D11_VDOV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_VDOV_DIMENSION_TEXTURE2D</b> = 1
	/// </summary>
	Texture2d = 1,
}

/// <summary>
/// ENUM <b>D3D11_VPIV_DIMENSION</b><br/>
/// D3D11.h
/// </summary>
public enum VpivDimension : uint {
	/// <summary>
	/// <b>D3D11_VPIV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_VPIV_DIMENSION_TEXTURE2D</b> = 1
	/// </summary>
	Texture2d = 1,
}

/// <summary>
/// ENUM <b>D3D11_VPOV_DIMENSION</b><br/>
/// D3D11.h
/// </summary>
public enum VpovDimension : uint {
	/// <summary>
	/// <b>D3D11_VPOV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_VPOV_DIMENSION_TEXTURE2D</b> = 1
	/// </summary>
	Texture2d = 1,
	/// <summary>
	/// <b>D3D11_VPOV_DIMENSION_TEXTURE2DARRAY</b> = 2
	/// </summary>
	Texture2darray = 2,
}

/// <summary>
/// ENUM <b>D3D11_CREATE_DEVICE_FLAG</b><br/>
/// D3D11.h
/// </summary>
[Flags]
public enum CreateDeviceFlag : uint {
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_SINGLETHREADED</b> = 0x1
	/// </summary>
	Singlethreaded = 1,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_DEBUG</b> = 0x2
	/// </summary>
	Debug = 2,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_SWITCH_TO_REF</b> = 0x4
	/// </summary>
	SwitchToRef = 4,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS</b> = 0x8
	/// </summary>
	PreventInternalThreadingOptimizations = 8,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_BGRA_SUPPORT</b> = 0x20
	/// </summary>
	BgraSupport = 32,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_DEBUGGABLE</b> = 0x40
	/// </summary>
	Debuggable = 64,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY</b> = 0x80
	/// </summary>
	PreventAlteringLayerSettingsFromRegistry = 128,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT</b> = 0x100
	/// </summary>
	DisableGpuTimeout = 256,
	/// <summary>
	/// <b>D3D11_CREATE_DEVICE_VIDEO_SUPPORT</b> = 0x800
	/// </summary>
	VideoSupport = 2048,
}

/// <summary>
/// ENUM <b>D3D11_RLDO_FLAGS</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
[Flags]
public enum RldoFlags : uint {
	/// <summary>
	/// <b>D3D11_RLDO_SUMMARY</b> = 0x1
	/// </summary>
	Summary = 1,
	/// <summary>
	/// <b>D3D11_RLDO_DETAIL</b> = 0x2
	/// </summary>
	Detail = 2,
	/// <summary>
	/// <b>D3D11_RLDO_IGNORE_INTERNAL</b> = 0x4
	/// </summary>
	IgnoreInternal = 4,
}

/// <summary>
/// ENUM <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
public enum ShaderTrackingResourceType : uint {
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_UAV_DEVICEMEMORY</b> = 1
	/// </summary>
	UavDevicememory = 1,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_NON_UAV_DEVICEMEMORY</b> = 2
	/// </summary>
	NonUavDevicememory = 2,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_DEVICEMEMORY</b> = 3
	/// </summary>
	AllDevicememory = 3,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_MEMORY</b> = 4
	/// </summary>
	GroupsharedMemory = 4,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_SHARED_MEMORY</b> = 5
	/// </summary>
	AllSharedMemory = 5,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_NON_UAV</b> = 6
	/// </summary>
	GroupsharedNonUav = 6,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL</b> = 7
	/// </summary>
	All = 7,
}

/// <summary>
/// ENUM <b>D3D11_SHADER_TRACKING_OPTION</b> (D3D11_SHADER_TRACKING_OPTIONS)<br/>
/// D3D11SDKLAYERS.h
/// </summary>
[Flags]
public enum ShaderTrackingOption : uint {
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_IGNORE</b> = 0
	/// </summary>
	Ignore = 0,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED</b> = 0x1
	/// </summary>
	TrackUninitialized = 1,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_RAW</b> = 0x2
	/// </summary>
	TrackRaw = 2,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_WAR</b> = 0x4
	/// </summary>
	TrackWar = 4,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_WAW</b> = 0x8
	/// </summary>
	TrackWaw = 8,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME</b> = 0x10
	/// </summary>
	AllowSame = 16,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY</b> = 0x20
	/// </summary>
	TrackAtomicConsistency = 32,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS</b> = 0x40
	/// </summary>
	TrackRawAcrossThreadgroups = 64,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS</b> = 0x80
	/// </summary>
	TrackWarAcrossThreadgroups = 128,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS</b> = 0x100
	/// </summary>
	TrackWawAcrossThreadgroups = 256,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS</b> = 0x200
	/// </summary>
	TrackAtomicConsistencyAcrossThreadgroups = 512,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_UAV_SPECIFIC_FLAGS</b> = ( ( ( D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS | D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS )  | D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS )  | D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS )
	/// </summary>
	UavSpecificFlags = TrackRawAcrossThreadgroups | TrackWarAcrossThreadgroups | TrackWawAcrossThreadgroups | TrackAtomicConsistencyAcrossThreadgroups,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS</b> = ( ( ( ( ( ( ( D3D11_SHADER_TRACKING_OPTION_TRACK_RAW | D3D11_SHADER_TRACKING_OPTION_TRACK_WAR )  | D3D11_SHADER_TRACKING_OPTION_TRACK_WAW )  | D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY )  | D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS )  | D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS )  | D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS )  | D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS )
	/// </summary>
	AllHazards = TrackRaw | TrackWar | TrackWaw | TrackAtomicConsistency | TrackRawAcrossThreadgroups | TrackWarAcrossThreadgroups | TrackWawAcrossThreadgroups | TrackAtomicConsistencyAcrossThreadgroups,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME</b> = ( D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS | D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME )
	/// </summary>
	AllHazardsAllowingSame = AllHazards | AllowSame,
	/// <summary>
	/// <b>D3D11_SHADER_TRACKING_OPTION_ALL_OPTIONS</b> = ( D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME | D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED )
	/// </summary>
	AllOptions = AllHazardsAllowingSame | TrackUninitialized,
}

/// <summary>
/// ENUM <b>D3D11_MESSAGE_CATEGORY</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
public enum MessageCategory : uint {
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_APPLICATION_DEFINED</b> = 0
	/// </summary>
	ApplicationDefined = 0,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_MISCELLANEOUS</b> = ( D3D11_MESSAGE_CATEGORY_APPLICATION_DEFINED + 1 )
	/// </summary>
	Miscellaneous = ApplicationDefined + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_INITIALIZATION</b> = ( D3D11_MESSAGE_CATEGORY_MISCELLANEOUS + 1 )
	/// </summary>
	Initialization = Miscellaneous + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_CLEANUP</b> = ( D3D11_MESSAGE_CATEGORY_INITIALIZATION + 1 )
	/// </summary>
	Cleanup = Initialization + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_COMPILATION</b> = ( D3D11_MESSAGE_CATEGORY_CLEANUP + 1 )
	/// </summary>
	Compilation = Cleanup + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_STATE_CREATION</b> = ( D3D11_MESSAGE_CATEGORY_COMPILATION + 1 )
	/// </summary>
	StateCreation = Compilation + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_STATE_SETTING</b> = ( D3D11_MESSAGE_CATEGORY_STATE_CREATION + 1 )
	/// </summary>
	StateSetting = StateCreation + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_STATE_GETTING</b> = ( D3D11_MESSAGE_CATEGORY_STATE_SETTING + 1 )
	/// </summary>
	StateGetting = StateSetting + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_RESOURCE_MANIPULATION</b> = ( D3D11_MESSAGE_CATEGORY_STATE_GETTING + 1 )
	/// </summary>
	ResourceManipulation = StateGetting + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_EXECUTION</b> = ( D3D11_MESSAGE_CATEGORY_RESOURCE_MANIPULATION + 1 )
	/// </summary>
	Execution = ResourceManipulation + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY_SHADER</b> = ( D3D11_MESSAGE_CATEGORY_EXECUTION + 1 )
	/// </summary>
	Shader = Execution + 1,
}

/// <summary>
/// ENUM <b>D3D11_MESSAGE_SEVERITY</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
public enum MessageSeverity : uint {
	/// <summary>
	/// <b>D3D11_MESSAGE_SEVERITY_CORRUPTION</b> = 0
	/// </summary>
	Corruption = 0,
	/// <summary>
	/// <b>D3D11_MESSAGE_SEVERITY_ERROR</b> = ( D3D11_MESSAGE_SEVERITY_CORRUPTION + 1 )
	/// </summary>
	Error = Corruption + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_SEVERITY_WARNING</b> = ( D3D11_MESSAGE_SEVERITY_ERROR + 1 )
	/// </summary>
	Warning = Error + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_SEVERITY_INFO</b> = ( D3D11_MESSAGE_SEVERITY_WARNING + 1 )
	/// </summary>
	Info = Warning + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_SEVERITY_MESSAGE</b> = ( D3D11_MESSAGE_SEVERITY_INFO + 1 )
	/// </summary>
	Message = Info + 1,
}

/// <summary>
/// ENUM <b>D3D11_MESSAGE_ID</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
public enum MessageId : uint {
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_HAZARD</b> = ( D3D11_MESSAGE_ID_UNKNOWN + 1 )
	/// </summary>
	DeviceIasetvertexbuffersHazard = Unknown + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_HAZARD + 1 )
	/// </summary>
	DeviceIasetindexbufferHazard = DeviceIasetvertexbuffersHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_HAZARD + 1 )
	/// </summary>
	DeviceVssetshaderresourcesHazard = DeviceIasetindexbufferHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_HAZARD + 1 )
	/// </summary>
	DeviceVssetconstantbuffersHazard = DeviceVssetshaderresourcesHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_HAZARD + 1 )
	/// </summary>
	DeviceGssetshaderresourcesHazard = DeviceVssetconstantbuffersHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_HAZARD + 1 )
	/// </summary>
	DeviceGssetconstantbuffersHazard = DeviceGssetshaderresourcesHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_HAZARD + 1 )
	/// </summary>
	DevicePssetshaderresourcesHazard = DeviceGssetconstantbuffersHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_HAZARD + 1 )
	/// </summary>
	DevicePssetconstantbuffersHazard = DevicePssetshaderresourcesHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_HAZARD + 1 )
	/// </summary>
	DeviceOmsetrendertargetsHazard = DevicePssetconstantbuffersHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETS_HAZARD + 1 )
	/// </summary>
	DeviceSosettargetsHazard = DeviceOmsetrendertargetsHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_STRING_FROM_APPLICATION</b> = ( D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_HAZARD + 1 )
	/// </summary>
	StringFromApplication = DeviceSosettargetsHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_THIS</b> = ( D3D11_MESSAGE_ID_STRING_FROM_APPLICATION + 1 )
	/// </summary>
	CorruptedThis = StringFromApplication + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER1</b> = ( D3D11_MESSAGE_ID_CORRUPTED_THIS + 1 )
	/// </summary>
	CorruptedParameter1 = CorruptedThis + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER2</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER1 + 1 )
	/// </summary>
	CorruptedParameter2 = CorruptedParameter1 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER3</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER2 + 1 )
	/// </summary>
	CorruptedParameter3 = CorruptedParameter2 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER4</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER3 + 1 )
	/// </summary>
	CorruptedParameter4 = CorruptedParameter3 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER5</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER4 + 1 )
	/// </summary>
	CorruptedParameter5 = CorruptedParameter4 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER6</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER5 + 1 )
	/// </summary>
	CorruptedParameter6 = CorruptedParameter5 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER7</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER6 + 1 )
	/// </summary>
	CorruptedParameter7 = CorruptedParameter6 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER8</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER7 + 1 )
	/// </summary>
	CorruptedParameter8 = CorruptedParameter7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER9</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER8 + 1 )
	/// </summary>
	CorruptedParameter9 = CorruptedParameter8 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER10</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER9 + 1 )
	/// </summary>
	CorruptedParameter10 = CorruptedParameter9 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER11</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER10 + 1 )
	/// </summary>
	CorruptedParameter11 = CorruptedParameter10 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER12</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER11 + 1 )
	/// </summary>
	CorruptedParameter12 = CorruptedParameter11 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER13</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER12 + 1 )
	/// </summary>
	CorruptedParameter13 = CorruptedParameter12 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER14</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER13 + 1 )
	/// </summary>
	CorruptedParameter14 = CorruptedParameter13 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_PARAMETER15</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER14 + 1 )
	/// </summary>
	CorruptedParameter15 = CorruptedParameter14 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CORRUPTED_MULTITHREADING</b> = ( D3D11_MESSAGE_ID_CORRUPTED_PARAMETER15 + 1 )
	/// </summary>
	CorruptedMultithreading = CorruptedParameter15 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CORRUPTED_MULTITHREADING + 1 )
	/// </summary>
	MessageReportingOutofmemory = CorruptedMultithreading + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_IASETINPUTLAYOUT_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY + 1 )
	/// </summary>
	IasetinputlayoutUnbinddeletingobject = MessageReportingOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_IASETINPUTLAYOUT_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	IasetvertexbuffersUnbinddeletingobject = IasetinputlayoutUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_IASETINDEXBUFFER_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	IasetindexbufferUnbinddeletingobject = IasetvertexbuffersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETSHADER_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_IASETINDEXBUFFER_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	VssetshaderUnbinddeletingobject = IasetindexbufferUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETSHADERRESOURCES_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_VSSETSHADER_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	VssetshaderresourcesUnbinddeletingobject = VssetshaderUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_VSSETSHADERRESOURCES_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	VssetconstantbuffersUnbinddeletingobject = VssetshaderresourcesUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETSAMPLERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	VssetsamplersUnbinddeletingobject = VssetconstantbuffersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GSSETSHADER_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_VSSETSAMPLERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	GssetshaderUnbinddeletingobject = VssetsamplersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GSSETSHADERRESOURCES_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_GSSETSHADER_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	GssetshaderresourcesUnbinddeletingobject = GssetshaderUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_GSSETSHADERRESOURCES_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	GssetconstantbuffersUnbinddeletingobject = GssetshaderresourcesUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GSSETSAMPLERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	GssetsamplersUnbinddeletingobject = GssetconstantbuffersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SOSETTARGETS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_GSSETSAMPLERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	SosettargetsUnbinddeletingobject = GssetsamplersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETSHADER_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_SOSETTARGETS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	PssetshaderUnbinddeletingobject = SosettargetsUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETSHADERRESOURCES_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_PSSETSHADER_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	PssetshaderresourcesUnbinddeletingobject = PssetshaderUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_PSSETSHADERRESOURCES_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	PssetconstantbuffersUnbinddeletingobject = PssetshaderresourcesUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETSAMPLERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	PssetsamplersUnbinddeletingobject = PssetconstantbuffersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RSSETSTATE_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_PSSETSAMPLERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	RssetstateUnbinddeletingobject = PssetsamplersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETBLENDSTATE_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_RSSETSTATE_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	OmsetblendstateUnbinddeletingobject = RssetstateUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETDEPTHSTENCILSTATE_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_OMSETBLENDSTATE_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	OmsetdepthstencilstateUnbinddeletingobject = OmsetblendstateUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETRENDERTARGETS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_OMSETDEPTHSTENCILSTATE_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	OmsetrendertargetsUnbinddeletingobject = OmsetdepthstencilstateUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETPREDICATION_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_OMSETRENDERTARGETS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	SetpredicationUnbinddeletingobject = OmsetrendertargetsUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETPRIVATEDATA_MOREDATA</b> = ( D3D11_MESSAGE_ID_SETPREDICATION_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	GetprivatedataMoredata = SetpredicationUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA</b> = ( D3D11_MESSAGE_ID_GETPRIVATEDATA_MOREDATA + 1 )
	/// </summary>
	SetprivatedataInvalidfreedata = GetprivatedataMoredata + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDIUNKNOWN</b> = ( D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA + 1 )
	/// </summary>
	SetprivatedataInvalidiunknown = SetprivatedataInvalidfreedata + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDIUNKNOWN + 1 )
	/// </summary>
	SetprivatedataInvalidflags = SetprivatedataInvalidiunknown + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS</b> = ( D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFLAGS + 1 )
	/// </summary>
	SetprivatedataChangingparams = SetprivatedataInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS + 1 )
	/// </summary>
	SetprivatedataOutofmemory = SetprivatedataChangingparams + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY + 1 )
	/// </summary>
	CreatebufferUnrecognizedformat = SetprivatedataOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSAMPLES</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	CreatebufferInvalidsamples = CreatebufferUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSAMPLES + 1 )
	/// </summary>
	CreatebufferUnrecognizedusage = CreatebufferInvalidsamples + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDUSAGE + 1 )
	/// </summary>
	CreatebufferUnrecognizedbindflags = CreatebufferUnrecognizedusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDBINDFLAGS + 1 )
	/// </summary>
	CreatebufferUnrecognizedcpuaccessflags = CreatebufferUnrecognizedbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDCPUACCESSFLAGS + 1 )
	/// </summary>
	CreatebufferUnrecognizedmiscflags = CreatebufferUnrecognizedcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDMISCFLAGS + 1 )
	/// </summary>
	CreatebufferInvalidcpuaccessflags = CreatebufferUnrecognizedmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCPUACCESSFLAGS + 1 )
	/// </summary>
	CreatebufferInvalidbindflags = CreatebufferInvalidcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDINITIALDATA</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDBINDFLAGS + 1 )
	/// </summary>
	CreatebufferInvalidinitialdata = CreatebufferInvalidbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDINITIALDATA + 1 )
	/// </summary>
	CreatebufferInvaliddimensions = CreatebufferInvalidinitialdata + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMIPLEVELS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDDIMENSIONS + 1 )
	/// </summary>
	CreatebufferInvalidmiplevels = CreatebufferInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMIPLEVELS + 1 )
	/// </summary>
	CreatebufferInvalidmiscflags = CreatebufferInvalidmiplevels + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMISCFLAGS + 1 )
	/// </summary>
	CreatebufferInvalidargReturn = CreatebufferInvalidmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDARG_RETURN + 1 )
	/// </summary>
	CreatebufferOutofmemoryReturn = CreatebufferInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatebufferNulldesc = CreatebufferOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCONSTANTBUFFERBINDINGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_NULLDESC + 1 )
	/// </summary>
	CreatebufferInvalidconstantbufferbindings = CreatebufferNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_LARGEALLOCATION</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCONSTANTBUFFERBINDINGS + 1 )
	/// </summary>
	CreatebufferLargeallocation = CreatebufferInvalidconstantbufferbindings + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_LARGEALLOCATION + 1 )
	/// </summary>
	Createtexture1dUnrecognizedformat = CreatebufferLargeallocation + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_UNSUPPORTEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	Createtexture1dUnsupportedformat = Createtexture1dUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDSAMPLES</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_UNSUPPORTEDFORMAT + 1 )
	/// </summary>
	Createtexture1dInvalidsamples = Createtexture1dUnsupportedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDSAMPLES + 1 )
	/// </summary>
	Createtexture1dUnrecognizedusage = Createtexture1dInvalidsamples + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDUSAGE + 1 )
	/// </summary>
	Createtexture1dUnrecognizedbindflags = Createtexture1dUnrecognizedusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDBINDFLAGS + 1 )
	/// </summary>
	Createtexture1dUnrecognizedcpuaccessflags = Createtexture1dUnrecognizedbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDCPUACCESSFLAGS + 1 )
	/// </summary>
	Createtexture1dUnrecognizedmiscflags = Createtexture1dUnrecognizedcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDMISCFLAGS + 1 )
	/// </summary>
	Createtexture1dInvalidcpuaccessflags = Createtexture1dUnrecognizedmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDCPUACCESSFLAGS + 1 )
	/// </summary>
	Createtexture1dInvalidbindflags = Createtexture1dInvalidcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDINITIALDATA</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDBINDFLAGS + 1 )
	/// </summary>
	Createtexture1dInvalidinitialdata = Createtexture1dInvalidbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDINITIALDATA + 1 )
	/// </summary>
	Createtexture1dInvaliddimensions = Createtexture1dInvalidinitialdata + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMIPLEVELS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDDIMENSIONS + 1 )
	/// </summary>
	Createtexture1dInvalidmiplevels = Createtexture1dInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMIPLEVELS + 1 )
	/// </summary>
	Createtexture1dInvalidmiscflags = Createtexture1dInvalidmiplevels + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMISCFLAGS + 1 )
	/// </summary>
	Createtexture1dInvalidargReturn = Createtexture1dInvalidmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDARG_RETURN + 1 )
	/// </summary>
	Createtexture1dOutofmemoryReturn = Createtexture1dInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	Createtexture1dNulldesc = Createtexture1dOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_LARGEALLOCATION</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_NULLDESC + 1 )
	/// </summary>
	Createtexture1dLargeallocation = Createtexture1dNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_LARGEALLOCATION + 1 )
	/// </summary>
	Createtexture2dUnrecognizedformat = Createtexture1dLargeallocation + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_UNSUPPORTEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	Createtexture2dUnsupportedformat = Createtexture2dUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDSAMPLES</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_UNSUPPORTEDFORMAT + 1 )
	/// </summary>
	Createtexture2dInvalidsamples = Createtexture2dUnsupportedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDSAMPLES + 1 )
	/// </summary>
	Createtexture2dUnrecognizedusage = Createtexture2dInvalidsamples + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDUSAGE + 1 )
	/// </summary>
	Createtexture2dUnrecognizedbindflags = Createtexture2dUnrecognizedusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDBINDFLAGS + 1 )
	/// </summary>
	Createtexture2dUnrecognizedcpuaccessflags = Createtexture2dUnrecognizedbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDCPUACCESSFLAGS + 1 )
	/// </summary>
	Createtexture2dUnrecognizedmiscflags = Createtexture2dUnrecognizedcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDMISCFLAGS + 1 )
	/// </summary>
	Createtexture2dInvalidcpuaccessflags = Createtexture2dUnrecognizedmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDCPUACCESSFLAGS + 1 )
	/// </summary>
	Createtexture2dInvalidbindflags = Createtexture2dInvalidcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDINITIALDATA</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDBINDFLAGS + 1 )
	/// </summary>
	Createtexture2dInvalidinitialdata = Createtexture2dInvalidbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDINITIALDATA + 1 )
	/// </summary>
	Createtexture2dInvaliddimensions = Createtexture2dInvalidinitialdata + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMIPLEVELS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDDIMENSIONS + 1 )
	/// </summary>
	Createtexture2dInvalidmiplevels = Createtexture2dInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMIPLEVELS + 1 )
	/// </summary>
	Createtexture2dInvalidmiscflags = Createtexture2dInvalidmiplevels + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMISCFLAGS + 1 )
	/// </summary>
	Createtexture2dInvalidargReturn = Createtexture2dInvalidmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDARG_RETURN + 1 )
	/// </summary>
	Createtexture2dOutofmemoryReturn = Createtexture2dInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	Createtexture2dNulldesc = Createtexture2dOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_LARGEALLOCATION</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_NULLDESC + 1 )
	/// </summary>
	Createtexture2dLargeallocation = Createtexture2dNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_LARGEALLOCATION + 1 )
	/// </summary>
	Createtexture3dUnrecognizedformat = Createtexture2dLargeallocation + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_UNSUPPORTEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	Createtexture3dUnsupportedformat = Createtexture3dUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDSAMPLES</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_UNSUPPORTEDFORMAT + 1 )
	/// </summary>
	Createtexture3dInvalidsamples = Createtexture3dUnsupportedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDSAMPLES + 1 )
	/// </summary>
	Createtexture3dUnrecognizedusage = Createtexture3dInvalidsamples + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDUSAGE + 1 )
	/// </summary>
	Createtexture3dUnrecognizedbindflags = Createtexture3dUnrecognizedusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDBINDFLAGS + 1 )
	/// </summary>
	Createtexture3dUnrecognizedcpuaccessflags = Createtexture3dUnrecognizedbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDCPUACCESSFLAGS + 1 )
	/// </summary>
	Createtexture3dUnrecognizedmiscflags = Createtexture3dUnrecognizedcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDCPUACCESSFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDMISCFLAGS + 1 )
	/// </summary>
	Createtexture3dInvalidcpuaccessflags = Createtexture3dUnrecognizedmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDBINDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDCPUACCESSFLAGS + 1 )
	/// </summary>
	Createtexture3dInvalidbindflags = Createtexture3dInvalidcpuaccessflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDINITIALDATA</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDBINDFLAGS + 1 )
	/// </summary>
	Createtexture3dInvalidinitialdata = Createtexture3dInvalidbindflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDINITIALDATA + 1 )
	/// </summary>
	Createtexture3dInvaliddimensions = Createtexture3dInvalidinitialdata + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMIPLEVELS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDDIMENSIONS + 1 )
	/// </summary>
	Createtexture3dInvalidmiplevels = Createtexture3dInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMIPLEVELS + 1 )
	/// </summary>
	Createtexture3dInvalidmiscflags = Createtexture3dInvalidmiplevels + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMISCFLAGS + 1 )
	/// </summary>
	Createtexture3dInvalidargReturn = Createtexture3dInvalidmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDARG_RETURN + 1 )
	/// </summary>
	Createtexture3dOutofmemoryReturn = Createtexture3dInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	Createtexture3dNulldesc = Createtexture3dOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE3D_LARGEALLOCATION</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_NULLDESC + 1 )
	/// </summary>
	Createtexture3dLargeallocation = Createtexture3dNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE3D_LARGEALLOCATION + 1 )
	/// </summary>
	CreateshaderresourceviewUnrecognizedformat = Createtexture3dLargeallocation + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	CreateshaderresourceviewInvaliddesc = CreateshaderresourceviewUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC + 1 )
	/// </summary>
	CreateshaderresourceviewInvalidformat = CreateshaderresourceviewInvaliddesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT + 1 )
	/// </summary>
	CreateshaderresourceviewInvaliddimensions = CreateshaderresourceviewInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS + 1 )
	/// </summary>
	CreateshaderresourceviewInvalidresource = CreateshaderresourceviewInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE + 1 )
	/// </summary>
	CreateshaderresourceviewToomanyobjects = CreateshaderresourceviewInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_TOOMANYOBJECTS + 1 )
	/// </summary>
	CreateshaderresourceviewInvalidargReturn = CreateshaderresourceviewToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDARG_RETURN + 1 )
	/// </summary>
	CreateshaderresourceviewOutofmemoryReturn = CreateshaderresourceviewInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreaterendertargetviewUnrecognizedformat = CreateshaderresourceviewOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	CreaterendertargetviewUnsupportedformat = CreaterendertargetviewUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT + 1 )
	/// </summary>
	CreaterendertargetviewInvaliddesc = CreaterendertargetviewUnsupportedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC + 1 )
	/// </summary>
	CreaterendertargetviewInvalidformat = CreaterendertargetviewInvaliddesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT + 1 )
	/// </summary>
	CreaterendertargetviewInvaliddimensions = CreaterendertargetviewInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS + 1 )
	/// </summary>
	CreaterendertargetviewInvalidresource = CreaterendertargetviewInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE + 1 )
	/// </summary>
	CreaterendertargetviewToomanyobjects = CreaterendertargetviewInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_TOOMANYOBJECTS + 1 )
	/// </summary>
	CreaterendertargetviewInvalidargReturn = CreaterendertargetviewToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDARG_RETURN + 1 )
	/// </summary>
	CreaterendertargetviewOutofmemoryReturn = CreaterendertargetviewInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatedepthstencilviewUnrecognizedformat = CreaterendertargetviewOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	CreatedepthstencilviewInvaliddesc = CreatedepthstencilviewUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC + 1 )
	/// </summary>
	CreatedepthstencilviewInvalidformat = CreatedepthstencilviewInvaliddesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT + 1 )
	/// </summary>
	CreatedepthstencilviewInvaliddimensions = CreatedepthstencilviewInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS + 1 )
	/// </summary>
	CreatedepthstencilviewInvalidresource = CreatedepthstencilviewInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE + 1 )
	/// </summary>
	CreatedepthstencilviewToomanyobjects = CreatedepthstencilviewInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_TOOMANYOBJECTS + 1 )
	/// </summary>
	CreatedepthstencilviewInvalidargReturn = CreatedepthstencilviewToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDARG_RETURN + 1 )
	/// </summary>
	CreatedepthstencilviewOutofmemoryReturn = CreatedepthstencilviewInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreateinputlayoutOutofmemory = CreatedepthstencilviewOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY + 1 )
	/// </summary>
	CreateinputlayoutToomanyelements = CreateinputlayoutOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS + 1 )
	/// </summary>
	CreateinputlayoutInvalidformat = CreateinputlayoutToomanyelements + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT + 1 )
	/// </summary>
	CreateinputlayoutIncompatibleformat = CreateinputlayoutInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT + 1 )
	/// </summary>
	CreateinputlayoutInvalidslot = CreateinputlayoutIncompatibleformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT + 1 )
	/// </summary>
	CreateinputlayoutInvalidinputslotclass = CreateinputlayoutInvalidslot + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS + 1 )
	/// </summary>
	CreateinputlayoutSteprateslotclassmismatch = CreateinputlayoutInvalidinputslotclass + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH + 1 )
	/// </summary>
	CreateinputlayoutInvalidslotclasschange = CreateinputlayoutSteprateslotclassmismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE + 1 )
	/// </summary>
	CreateinputlayoutInvalidstepratechange = CreateinputlayoutInvalidslotclasschange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE + 1 )
	/// </summary>
	CreateinputlayoutInvalidalignment = CreateinputlayoutInvalidstepratechange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT + 1 )
	/// </summary>
	CreateinputlayoutDuplicatesemantic = CreateinputlayoutInvalidalignment + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC + 1 )
	/// </summary>
	CreateinputlayoutUnparseableinputsignature = CreateinputlayoutDuplicatesemantic + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE + 1 )
	/// </summary>
	CreateinputlayoutNullsemantic = CreateinputlayoutUnparseableinputsignature + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC + 1 )
	/// </summary>
	CreateinputlayoutMissingelement = CreateinputlayoutNullsemantic + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT + 1 )
	/// </summary>
	CreateinputlayoutNulldesc = CreateinputlayoutMissingelement + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLDESC + 1 )
	/// </summary>
	CreatevertexshaderOutofmemory = CreateinputlayoutNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE</b> = ( D3D11_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY + 1 )
	/// </summary>
	CreatevertexshaderInvalidshaderbytecode = CreatevertexshaderOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE</b> = ( D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE + 1 )
	/// </summary>
	CreatevertexshaderInvalidshadertype = CreatevertexshaderInvalidshaderbytecode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE + 1 )
	/// </summary>
	CreategeometryshaderOutofmemory = CreatevertexshaderInvalidshadertype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY + 1 )
	/// </summary>
	CreategeometryshaderInvalidshaderbytecode = CreategeometryshaderOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE + 1 )
	/// </summary>
	CreategeometryshaderInvalidshadertype = CreategeometryshaderInvalidshaderbytecode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputOutofmemory = CreategeometryshaderInvalidshadertype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidshaderbytecode = CreategeometryshaderwithstreamoutputOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidshadertype = CreategeometryshaderwithstreamoutputInvalidshaderbytecode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidnumentries = CreategeometryshaderwithstreamoutputInvalidshadertype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputOutputstreamstrideunused = CreategeometryshaderwithstreamoutputInvalidnumentries + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDDECL</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputUnexpecteddecl = CreategeometryshaderwithstreamoutputOutputstreamstrideunused + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_EXPECTEDDECL</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDDECL + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputExpecteddecl = CreategeometryshaderwithstreamoutputUnexpecteddecl + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_EXPECTEDDECL + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputOutputslot0expected = CreategeometryshaderwithstreamoutputExpecteddecl + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidoutputslot = CreategeometryshaderwithstreamoutputOutputslot0expected + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputOnlyoneelementperslot = CreategeometryshaderwithstreamoutputInvalidoutputslot + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidcomponentcount = CreategeometryshaderwithstreamoutputOnlyoneelementperslot + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = CreategeometryshaderwithstreamoutputInvalidcomponentcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidgapdefinition = CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputRepeatedoutput = CreategeometryshaderwithstreamoutputInvalidgapdefinition + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidoutputstreamstride = CreategeometryshaderwithstreamoutputRepeatedoutput + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputMissingsemantic = CreategeometryshaderwithstreamoutputInvalidoutputstreamstride + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputMaskmismatch = CreategeometryshaderwithstreamoutputMissingsemantic + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputCanthaveonlygaps = CreategeometryshaderwithstreamoutputMaskmismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputDecltoocomplex = CreategeometryshaderwithstreamoutputCanthaveonlygaps + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputMissingoutputsignature = CreategeometryshaderwithstreamoutputDecltoocomplex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE + 1 )
	/// </summary>
	CreatepixelshaderOutofmemory = CreategeometryshaderwithstreamoutputMissingoutputsignature + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE</b> = ( D3D11_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY + 1 )
	/// </summary>
	CreatepixelshaderInvalidshaderbytecode = CreatepixelshaderOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE</b> = ( D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE + 1 )
	/// </summary>
	CreatepixelshaderInvalidshadertype = CreatepixelshaderInvalidshaderbytecode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE</b> = ( D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE + 1 )
	/// </summary>
	CreaterasterizerstateInvalidfillmode = CreatepixelshaderInvalidshadertype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE + 1 )
	/// </summary>
	CreaterasterizerstateInvalidcullmode = CreaterasterizerstateInvalidfillmode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE + 1 )
	/// </summary>
	CreaterasterizerstateInvaliddepthbiasclamp = CreaterasterizerstateInvalidcullmode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP + 1 )
	/// </summary>
	CreaterasterizerstateInvalidslopescaleddepthbias = CreaterasterizerstateInvaliddepthbiasclamp + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS + 1 )
	/// </summary>
	CreaterasterizerstateToomanyobjects = CreaterasterizerstateInvalidslopescaleddepthbias + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_TOOMANYOBJECTS + 1 )
	/// </summary>
	CreaterasterizerstateNulldesc = CreaterasterizerstateToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_NULLDESC + 1 )
	/// </summary>
	CreatedepthstencilstateInvaliddepthwritemask = CreaterasterizerstateNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK + 1 )
	/// </summary>
	CreatedepthstencilstateInvaliddepthfunc = CreatedepthstencilstateInvaliddepthwritemask + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilfailop = CreatedepthstencilstateInvaliddepthfunc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilzfailop = CreatedepthstencilstateInvalidfrontfacestencilfailop + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilpassop = CreatedepthstencilstateInvalidfrontfacestencilzfailop + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilfunc = CreatedepthstencilstateInvalidfrontfacestencilpassop + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilfailop = CreatedepthstencilstateInvalidfrontfacestencilfunc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilzfailop = CreatedepthstencilstateInvalidbackfacestencilfailop + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilpassop = CreatedepthstencilstateInvalidbackfacestencilzfailop + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP + 1 )
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilfunc = CreatedepthstencilstateInvalidbackfacestencilpassop + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC + 1 )
	/// </summary>
	CreatedepthstencilstateToomanyobjects = CreatedepthstencilstateInvalidbackfacestencilfunc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_TOOMANYOBJECTS + 1 )
	/// </summary>
	CreatedepthstencilstateNulldesc = CreatedepthstencilstateToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_NULLDESC + 1 )
	/// </summary>
	CreateblendstateInvalidsrcblend = CreatedepthstencilstateNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND + 1 )
	/// </summary>
	CreateblendstateInvaliddestblend = CreateblendstateInvalidsrcblend + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND + 1 )
	/// </summary>
	CreateblendstateInvalidblendop = CreateblendstateInvaliddestblend + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP + 1 )
	/// </summary>
	CreateblendstateInvalidsrcblendalpha = CreateblendstateInvalidblendop + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA + 1 )
	/// </summary>
	CreateblendstateInvaliddestblendalpha = CreateblendstateInvalidsrcblendalpha + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA + 1 )
	/// </summary>
	CreateblendstateInvalidblendopalpha = CreateblendstateInvaliddestblendalpha + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA + 1 )
	/// </summary>
	CreateblendstateInvalidrendertargetwritemask = CreateblendstateInvalidblendopalpha + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK + 1 )
	/// </summary>
	CreateblendstateToomanyobjects = CreateblendstateInvalidrendertargetwritemask + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_TOOMANYOBJECTS + 1 )
	/// </summary>
	CreateblendstateNulldesc = CreateblendstateToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDFILTER</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_NULLDESC + 1 )
	/// </summary>
	CreatesamplerstateInvalidfilter = CreateblendstateNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSU</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDFILTER + 1 )
	/// </summary>
	CreatesamplerstateInvalidaddressu = CreatesamplerstateInvalidfilter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSV</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSU + 1 )
	/// </summary>
	CreatesamplerstateInvalidaddressv = CreatesamplerstateInvalidaddressu + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSW</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSV + 1 )
	/// </summary>
	CreatesamplerstateInvalidaddressw = CreatesamplerstateInvalidaddressv + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMIPLODBIAS</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSW + 1 )
	/// </summary>
	CreatesamplerstateInvalidmiplodbias = CreatesamplerstateInvalidaddressw + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXANISOTROPY</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMIPLODBIAS + 1 )
	/// </summary>
	CreatesamplerstateInvalidmaxanisotropy = CreatesamplerstateInvalidmiplodbias + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDCOMPARISONFUNC</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXANISOTROPY + 1 )
	/// </summary>
	CreatesamplerstateInvalidcomparisonfunc = CreatesamplerstateInvalidmaxanisotropy + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMINLOD</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDCOMPARISONFUNC + 1 )
	/// </summary>
	CreatesamplerstateInvalidminlod = CreatesamplerstateInvalidcomparisonfunc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXLOD</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMINLOD + 1 )
	/// </summary>
	CreatesamplerstateInvalidmaxlod = CreatesamplerstateInvalidminlod + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXLOD + 1 )
	/// </summary>
	CreatesamplerstateToomanyobjects = CreatesamplerstateInvalidmaxlod + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_TOOMANYOBJECTS + 1 )
	/// </summary>
	CreatesamplerstateNulldesc = CreatesamplerstateToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDQUERY</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NULLDESC + 1 )
	/// </summary>
	CreatequeryorpredicateInvalidquery = CreatesamplerstateNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDMISCFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDQUERY + 1 )
	/// </summary>
	CreatequeryorpredicateInvalidmiscflags = CreatequeryorpredicateInvalidquery + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNEXPECTEDMISCFLAG</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDMISCFLAGS + 1 )
	/// </summary>
	CreatequeryorpredicateUnexpectedmiscflag = CreatequeryorpredicateInvalidmiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNEXPECTEDMISCFLAG + 1 )
	/// </summary>
	CreatequeryorpredicateNulldesc = CreatequeryorpredicateUnexpectedmiscflag + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNRECOGNIZED</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_NULLDESC + 1 )
	/// </summary>
	DeviceIasetprimitivetopologyTopologyUnrecognized = CreatequeryorpredicateNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNDEFINED</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNRECOGNIZED + 1 )
	/// </summary>
	DeviceIasetprimitivetopologyTopologyUndefined = DeviceIasetprimitivetopologyTopologyUnrecognized + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNDEFINED + 1 )
	/// </summary>
	IasetvertexbuffersInvalidbuffer = DeviceIasetprimitivetopologyTopologyUndefined + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_OFFSET_TOO_LARGE</b> = ( D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceIasetvertexbuffersOffsetTooLarge = IasetvertexbuffersInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_OFFSET_TOO_LARGE + 1 )
	/// </summary>
	DeviceIasetvertexbuffersBuffersEmpty = DeviceIasetvertexbuffersOffsetTooLarge + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_IASETINDEXBUFFER_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	IasetindexbufferInvalidbuffer = DeviceIasetvertexbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_FORMAT_INVALID</b> = ( D3D11_MESSAGE_ID_IASETINDEXBUFFER_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceIasetindexbufferFormatInvalid = IasetindexbufferInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_TOO_LARGE</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_FORMAT_INVALID + 1 )
	/// </summary>
	DeviceIasetindexbufferOffsetTooLarge = DeviceIasetindexbufferFormatInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_UNALIGNED</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_TOO_LARGE + 1 )
	/// </summary>
	DeviceIasetindexbufferOffsetUnaligned = DeviceIasetindexbufferOffsetTooLarge + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_UNALIGNED + 1 )
	/// </summary>
	DeviceVssetshaderresourcesViewsEmpty = DeviceIasetindexbufferOffsetUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	VssetconstantbuffersInvalidbuffer = DeviceVssetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceVssetconstantbuffersBuffersEmpty = VssetconstantbuffersInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSSETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceVssetsamplersSamplersEmpty = DeviceVssetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_VSSETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceGssetshaderresourcesViewsEmpty = DeviceVssetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	GssetconstantbuffersInvalidbuffer = DeviceGssetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceGssetconstantbuffersBuffersEmpty = GssetconstantbuffersInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSSETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceGssetsamplersSamplersEmpty = DeviceGssetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SOSETTARGETS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_GSSETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	SosettargetsInvalidbuffer = DeviceGssetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_OFFSET_UNALIGNED</b> = ( D3D11_MESSAGE_ID_SOSETTARGETS_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceSosettargetsOffsetUnaligned = SosettargetsInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_OFFSET_UNALIGNED + 1 )
	/// </summary>
	DevicePssetshaderresourcesViewsEmpty = DeviceSosettargetsOffsetUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	PssetconstantbuffersInvalidbuffer = DevicePssetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFER + 1 )
	/// </summary>
	DevicePssetconstantbuffersBuffersEmpty = PssetconstantbuffersInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSSETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DevicePssetsamplersSamplersEmpty = DevicePssetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_INVALIDVIEWPORT</b> = ( D3D11_MESSAGE_ID_DEVICE_PSSETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceRssetviewportsInvalidviewport = DevicePssetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_INVALIDSCISSOR</b> = ( D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_INVALIDVIEWPORT + 1 )
	/// </summary>
	DeviceRssetscissorrectsInvalidscissor = DeviceRssetviewportsInvalidviewport + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARRENDERTARGETVIEW_DENORMFLUSH</b> = ( D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_INVALIDSCISSOR + 1 )
	/// </summary>
	ClearrendertargetviewDenormflush = DeviceRssetscissorrectsInvalidscissor + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DENORMFLUSH</b> = ( D3D11_MESSAGE_ID_CLEARRENDERTARGETVIEW_DENORMFLUSH + 1 )
	/// </summary>
	CleardepthstencilviewDenormflush = ClearrendertargetviewDenormflush + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID</b> = ( D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DENORMFLUSH + 1 )
	/// </summary>
	CleardepthstencilviewInvalid = CleardepthstencilviewDenormflush + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IAGETVERTEXBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID + 1 )
	/// </summary>
	DeviceIagetvertexbuffersBuffersEmpty = CleardepthstencilviewInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSGETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_IAGETVERTEXBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceVsgetshaderresourcesViewsEmpty = DeviceIagetvertexbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSGETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_VSGETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	DeviceVsgetconstantbuffersBuffersEmpty = DeviceVsgetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_VSGETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_VSGETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceVsgetsamplersSamplersEmpty = DeviceVsgetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSGETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_VSGETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceGsgetshaderresourcesViewsEmpty = DeviceVsgetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSGETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_GSGETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	DeviceGsgetconstantbuffersBuffersEmpty = DeviceGsgetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GSGETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_GSGETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceGsgetsamplersSamplersEmpty = DeviceGsgetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SOGETTARGETS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_GSGETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceSogettargetsBuffersEmpty = DeviceGsgetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSGETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_SOGETTARGETS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DevicePsgetshaderresourcesViewsEmpty = DeviceSogettargetsBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSGETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_PSGETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	DevicePsgetconstantbuffersBuffersEmpty = DevicePsgetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_PSGETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_PSGETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DevicePsgetsamplersSamplersEmpty = DevicePsgetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSGETVIEWPORTS_VIEWPORTS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_PSGETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceRsgetviewportsViewportsEmpty = DevicePsgetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSGETSCISSORRECTS_RECTS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_RSGETVIEWPORTS_VIEWPORTS_EMPTY + 1 )
	/// </summary>
	DeviceRsgetscissorrectsRectsEmpty = DeviceRsgetviewportsViewportsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GENERATEMIPS_RESOURCE_INVALID</b> = ( D3D11_MESSAGE_ID_DEVICE_RSGETSCISSORRECTS_RECTS_EMPTY + 1 )
	/// </summary>
	DeviceGeneratemipsResourceInvalid = DeviceRsgetscissorrectsRectsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_DEVICE_GENERATEMIPS_RESOURCE_INVALID + 1 )
	/// </summary>
	CopysubresourceregionInvaliddestinationsubresource = DeviceGeneratemipsResourceInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESUBRESOURCE</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSUBRESOURCE + 1 )
	/// </summary>
	CopysubresourceregionInvalidsourcesubresource = CopysubresourceregionInvaliddestinationsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCEBOX</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESUBRESOURCE + 1 )
	/// </summary>
	CopysubresourceregionInvalidsourcebox = CopysubresourceregionInvalidsourcesubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCE</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCEBOX + 1 )
	/// </summary>
	CopysubresourceregionInvalidsource = CopysubresourceregionInvalidsourcebox + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSTATE</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCE + 1 )
	/// </summary>
	CopysubresourceregionInvaliddestinationstate = CopysubresourceregionInvalidsource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESTATE</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSTATE + 1 )
	/// </summary>
	CopysubresourceregionInvalidsourcestate = CopysubresourceregionInvaliddestinationstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCE</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESTATE + 1 )
	/// </summary>
	CopyresourceInvalidsource = CopysubresourceregionInvalidsourcestate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDDESTINATIONSTATE</b> = ( D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCE + 1 )
	/// </summary>
	CopyresourceInvaliddestinationstate = CopyresourceInvalidsource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCESTATE</b> = ( D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDDESTINATIONSTATE + 1 )
	/// </summary>
	CopyresourceInvalidsourcestate = CopyresourceInvaliddestinationstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCESTATE + 1 )
	/// </summary>
	UpdatesubresourceInvaliddestinationsubresource = CopyresourceInvalidsourcestate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONBOX</b> = ( D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSUBRESOURCE + 1 )
	/// </summary>
	UpdatesubresourceInvaliddestinationbox = UpdatesubresourceInvaliddestinationsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSTATE</b> = ( D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONBOX + 1 )
	/// </summary>
	UpdatesubresourceInvaliddestinationstate = UpdatesubresourceInvaliddestinationbox + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_INVALID</b> = ( D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSTATE + 1 )
	/// </summary>
	DeviceResolvesubresourceDestinationInvalid = UpdatesubresourceInvaliddestinationstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_SUBRESOURCE_INVALID</b> = ( D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_INVALID + 1 )
	/// </summary>
	DeviceResolvesubresourceDestinationSubresourceInvalid = DeviceResolvesubresourceDestinationInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_INVALID</b> = ( D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_SUBRESOURCE_INVALID + 1 )
	/// </summary>
	DeviceResolvesubresourceSourceInvalid = DeviceResolvesubresourceDestinationSubresourceInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_SUBRESOURCE_INVALID</b> = ( D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_INVALID + 1 )
	/// </summary>
	DeviceResolvesubresourceSourceSubresourceInvalid = DeviceResolvesubresourceSourceInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_FORMAT_INVALID</b> = ( D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_SUBRESOURCE_INVALID + 1 )
	/// </summary>
	DeviceResolvesubresourceFormatInvalid = DeviceResolvesubresourceSourceSubresourceInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDMAPTYPE</b> = ( D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_FORMAT_INVALID + 1 )
	/// </summary>
	BufferMapInvalidmaptype = DeviceResolvesubresourceFormatInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDMAPTYPE + 1 )
	/// </summary>
	BufferMapInvalidflags = BufferMapInvalidmaptype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_BUFFER_MAP_ALREADYMAPPED</b> = ( D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDFLAGS + 1 )
	/// </summary>
	BufferMapAlreadymapped = BufferMapInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_BUFFER_MAP_DEVICEREMOVED_RETURN</b> = ( D3D11_MESSAGE_ID_BUFFER_MAP_ALREADYMAPPED + 1 )
	/// </summary>
	BufferMapDeviceremovedReturn = BufferMapAlreadymapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_BUFFER_UNMAP_NOTMAPPED</b> = ( D3D11_MESSAGE_ID_BUFFER_MAP_DEVICEREMOVED_RETURN + 1 )
	/// </summary>
	BufferUnmapNotmapped = BufferMapDeviceremovedReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDMAPTYPE</b> = ( D3D11_MESSAGE_ID_BUFFER_UNMAP_NOTMAPPED + 1 )
	/// </summary>
	Texture1dMapInvalidmaptype = BufferUnmapNotmapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDMAPTYPE + 1 )
	/// </summary>
	Texture1dMapInvalidsubresource = Texture1dMapInvalidmaptype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	Texture1dMapInvalidflags = Texture1dMapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE1D_MAP_ALREADYMAPPED</b> = ( D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDFLAGS + 1 )
	/// </summary>
	Texture1dMapAlreadymapped = Texture1dMapInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE1D_MAP_DEVICEREMOVED_RETURN</b> = ( D3D11_MESSAGE_ID_TEXTURE1D_MAP_ALREADYMAPPED + 1 )
	/// </summary>
	Texture1dMapDeviceremovedReturn = Texture1dMapAlreadymapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_TEXTURE1D_MAP_DEVICEREMOVED_RETURN + 1 )
	/// </summary>
	Texture1dUnmapInvalidsubresource = Texture1dMapDeviceremovedReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_NOTMAPPED</b> = ( D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	Texture1dUnmapNotmapped = Texture1dUnmapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDMAPTYPE</b> = ( D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_NOTMAPPED + 1 )
	/// </summary>
	Texture2dMapInvalidmaptype = Texture1dUnmapNotmapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDMAPTYPE + 1 )
	/// </summary>
	Texture2dMapInvalidsubresource = Texture2dMapInvalidmaptype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	Texture2dMapInvalidflags = Texture2dMapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE2D_MAP_ALREADYMAPPED</b> = ( D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDFLAGS + 1 )
	/// </summary>
	Texture2dMapAlreadymapped = Texture2dMapInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE2D_MAP_DEVICEREMOVED_RETURN</b> = ( D3D11_MESSAGE_ID_TEXTURE2D_MAP_ALREADYMAPPED + 1 )
	/// </summary>
	Texture2dMapDeviceremovedReturn = Texture2dMapAlreadymapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_TEXTURE2D_MAP_DEVICEREMOVED_RETURN + 1 )
	/// </summary>
	Texture2dUnmapInvalidsubresource = Texture2dMapDeviceremovedReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_NOTMAPPED</b> = ( D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	Texture2dUnmapNotmapped = Texture2dUnmapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDMAPTYPE</b> = ( D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_NOTMAPPED + 1 )
	/// </summary>
	Texture3dMapInvalidmaptype = Texture2dUnmapNotmapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDMAPTYPE + 1 )
	/// </summary>
	Texture3dMapInvalidsubresource = Texture3dMapInvalidmaptype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	Texture3dMapInvalidflags = Texture3dMapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE3D_MAP_ALREADYMAPPED</b> = ( D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDFLAGS + 1 )
	/// </summary>
	Texture3dMapAlreadymapped = Texture3dMapInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE3D_MAP_DEVICEREMOVED_RETURN</b> = ( D3D11_MESSAGE_ID_TEXTURE3D_MAP_ALREADYMAPPED + 1 )
	/// </summary>
	Texture3dMapDeviceremovedReturn = Texture3dMapAlreadymapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_TEXTURE3D_MAP_DEVICEREMOVED_RETURN + 1 )
	/// </summary>
	Texture3dUnmapInvalidsubresource = Texture3dMapDeviceremovedReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_NOTMAPPED</b> = ( D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	Texture3dUnmapNotmapped = Texture3dUnmapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_DEPRECATED</b> = ( D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_NOTMAPPED + 1 )
	/// </summary>
	CheckformatsupportFormatDeprecated = Texture3dUnmapNotmapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_FORMAT_DEPRECATED</b> = ( D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_DEPRECATED + 1 )
	/// </summary>
	CheckmultisamplequalitylevelsFormatDeprecated = CheckformatsupportFormatDeprecated + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETEXCEPTIONMODE_UNRECOGNIZEDFLAGS</b> = ( D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_FORMAT_DEPRECATED + 1 )
	/// </summary>
	SetexceptionmodeUnrecognizedflags = CheckmultisamplequalitylevelsFormatDeprecated + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETEXCEPTIONMODE_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_SETEXCEPTIONMODE_UNRECOGNIZEDFLAGS + 1 )
	/// </summary>
	SetexceptionmodeInvalidargReturn = SetexceptionmodeUnrecognizedflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETEXCEPTIONMODE_DEVICEREMOVED_RETURN</b> = ( D3D11_MESSAGE_ID_SETEXCEPTIONMODE_INVALIDARG_RETURN + 1 )
	/// </summary>
	SetexceptionmodeDeviceremovedReturn = SetexceptionmodeInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_SIMULATING_INFINITELY_FAST_HARDWARE</b> = ( D3D11_MESSAGE_ID_SETEXCEPTIONMODE_DEVICEREMOVED_RETURN + 1 )
	/// </summary>
	RefSimulatingInfinitelyFastHardware = SetexceptionmodeDeviceremovedReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_THREADING_MODE</b> = ( D3D11_MESSAGE_ID_REF_SIMULATING_INFINITELY_FAST_HARDWARE + 1 )
	/// </summary>
	RefThreadingMode = RefSimulatingInfinitelyFastHardware + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_UMDRIVER_EXCEPTION</b> = ( D3D11_MESSAGE_ID_REF_THREADING_MODE + 1 )
	/// </summary>
	RefUmdriverException = RefThreadingMode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_KMDRIVER_EXCEPTION</b> = ( D3D11_MESSAGE_ID_REF_UMDRIVER_EXCEPTION + 1 )
	/// </summary>
	RefKmdriverException = RefUmdriverException + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_HARDWARE_EXCEPTION</b> = ( D3D11_MESSAGE_ID_REF_KMDRIVER_EXCEPTION + 1 )
	/// </summary>
	RefHardwareException = RefKmdriverException + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_ACCESSING_INDEXABLE_TEMP_OUT_OF_RANGE</b> = ( D3D11_MESSAGE_ID_REF_HARDWARE_EXCEPTION + 1 )
	/// </summary>
	RefAccessingIndexableTempOutOfRange = RefHardwareException + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_PROBLEM_PARSING_SHADER</b> = ( D3D11_MESSAGE_ID_REF_ACCESSING_INDEXABLE_TEMP_OUT_OF_RANGE + 1 )
	/// </summary>
	RefProblemParsingShader = RefAccessingIndexableTempOutOfRange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_OUT_OF_MEMORY</b> = ( D3D11_MESSAGE_ID_REF_PROBLEM_PARSING_SHADER + 1 )
	/// </summary>
	RefOutOfMemory = RefProblemParsingShader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_INFO</b> = ( D3D11_MESSAGE_ID_REF_OUT_OF_MEMORY + 1 )
	/// </summary>
	RefInfo = RefOutOfMemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEXPOS_OVERFLOW</b> = ( D3D11_MESSAGE_ID_REF_INFO + 1 )
	/// </summary>
	DeviceDrawVertexposOverflow = RefInfo + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINDEXED_INDEXPOS_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEXPOS_OVERFLOW + 1 )
	/// </summary>
	DeviceDrawindexedIndexposOverflow = DeviceDrawVertexposOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_VERTEXPOS_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINDEXED_INDEXPOS_OVERFLOW + 1 )
	/// </summary>
	DeviceDrawinstancedVertexposOverflow = DeviceDrawindexedIndexposOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_INSTANCEPOS_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_VERTEXPOS_OVERFLOW + 1 )
	/// </summary>
	DeviceDrawinstancedInstanceposOverflow = DeviceDrawinstancedVertexposOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INSTANCEPOS_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_INSTANCEPOS_OVERFLOW + 1 )
	/// </summary>
	DeviceDrawindexedinstancedInstanceposOverflow = DeviceDrawinstancedInstanceposOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INDEXPOS_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INSTANCEPOS_OVERFLOW + 1 )
	/// </summary>
	DeviceDrawindexedinstancedIndexposOverflow = DeviceDrawindexedinstancedInstanceposOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_SHADER_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INDEXPOS_OVERFLOW + 1 )
	/// </summary>
	DeviceDrawVertexShaderNotSet = DeviceDrawindexedinstancedIndexposOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_SHADER_NOT_SET + 1 )
	/// </summary>
	DeviceShaderLinkageSemanticnameNotFound = DeviceDrawVertexShaderNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERINDEX</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND + 1 )
	/// </summary>
	DeviceShaderLinkageRegisterindex = DeviceShaderLinkageSemanticnameNotFound + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_COMPONENTTYPE</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERINDEX + 1 )
	/// </summary>
	DeviceShaderLinkageComponenttype = DeviceShaderLinkageRegisterindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERMASK</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_COMPONENTTYPE + 1 )
	/// </summary>
	DeviceShaderLinkageRegistermask = DeviceShaderLinkageComponenttype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SYSTEMVALUE</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERMASK + 1 )
	/// </summary>
	DeviceShaderLinkageSystemvalue = DeviceShaderLinkageRegistermask + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SYSTEMVALUE + 1 )
	/// </summary>
	DeviceShaderLinkageNeverwrittenAlwaysreads = DeviceShaderLinkageSystemvalue + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS + 1 )
	/// </summary>
	DeviceDrawVertexBufferNotSet = DeviceShaderLinkageNeverwrittenAlwaysreads + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INPUTLAYOUT_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_NOT_SET + 1 )
	/// </summary>
	DeviceDrawInputlayoutNotSet = DeviceDrawVertexBufferNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INPUTLAYOUT_NOT_SET + 1 )
	/// </summary>
	DeviceDrawConstantBufferNotSet = DeviceDrawInputlayoutNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_TOO_SMALL</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_NOT_SET + 1 )
	/// </summary>
	DeviceDrawConstantBufferTooSmall = DeviceDrawConstantBufferNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_TOO_SMALL + 1 )
	/// </summary>
	DeviceDrawSamplerNotSet = DeviceDrawConstantBufferTooSmall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_SHADERRESOURCEVIEW_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_NOT_SET + 1 )
	/// </summary>
	DeviceDrawShaderresourceviewNotSet = DeviceDrawSamplerNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VIEW_DIMENSION_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_SHADERRESOURCEVIEW_NOT_SET + 1 )
	/// </summary>
	DeviceDrawViewDimensionMismatch = DeviceDrawShaderresourceviewNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VIEW_DIMENSION_MISMATCH + 1 )
	/// </summary>
	DeviceDrawVertexBufferStrideTooSmall = DeviceDrawViewDimensionMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_TOO_SMALL</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL + 1 )
	/// </summary>
	DeviceDrawVertexBufferTooSmall = DeviceDrawVertexBufferStrideTooSmall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_TOO_SMALL + 1 )
	/// </summary>
	DeviceDrawIndexBufferNotSet = DeviceDrawVertexBufferTooSmall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_FORMAT_INVALID</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_NOT_SET + 1 )
	/// </summary>
	DeviceDrawIndexBufferFormatInvalid = DeviceDrawIndexBufferNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_TOO_SMALL</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_FORMAT_INVALID + 1 )
	/// </summary>
	DeviceDrawIndexBufferTooSmall = DeviceDrawIndexBufferFormatInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_GS_INPUT_PRIMITIVE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_TOO_SMALL + 1 )
	/// </summary>
	DeviceDrawGsInputPrimitiveMismatch = DeviceDrawIndexBufferTooSmall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_RETURN_TYPE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_GS_INPUT_PRIMITIVE_MISMATCH + 1 )
	/// </summary>
	DeviceDrawResourceReturnTypeMismatch = DeviceDrawGsInputPrimitiveMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_POSITION_NOT_PRESENT</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_RETURN_TYPE_MISMATCH + 1 )
	/// </summary>
	DeviceDrawPositionNotPresent = DeviceDrawResourceReturnTypeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_POSITION_NOT_PRESENT + 1 )
	/// </summary>
	DeviceDrawOutputStreamNotSet = DeviceDrawPositionNotPresent + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_BOUND_RESOURCE_MAPPED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_NOT_SET + 1 )
	/// </summary>
	DeviceDrawBoundResourceMapped = DeviceDrawOutputStreamNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_PRIMITIVETOPOLOGY</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_BOUND_RESOURCE_MAPPED + 1 )
	/// </summary>
	DeviceDrawInvalidPrimitivetopology = DeviceDrawBoundResourceMapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_OFFSET_UNALIGNED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_PRIMITIVETOPOLOGY + 1 )
	/// </summary>
	DeviceDrawVertexOffsetUnaligned = DeviceDrawInvalidPrimitivetopology + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_STRIDE_UNALIGNED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_OFFSET_UNALIGNED + 1 )
	/// </summary>
	DeviceDrawVertexStrideUnaligned = DeviceDrawVertexOffsetUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_OFFSET_UNALIGNED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_STRIDE_UNALIGNED + 1 )
	/// </summary>
	DeviceDrawIndexOffsetUnaligned = DeviceDrawVertexStrideUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_OFFSET_UNALIGNED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_OFFSET_UNALIGNED + 1 )
	/// </summary>
	DeviceDrawOutputStreamOffsetUnaligned = DeviceDrawIndexOffsetUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_LD_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_OFFSET_UNALIGNED + 1 )
	/// </summary>
	DeviceDrawResourceFormatLdUnsupported = DeviceDrawOutputStreamOffsetUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_LD_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDrawResourceFormatSampleUnsupported = DeviceDrawResourceFormatLdUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_C_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDrawResourceFormatSampleCUnsupported = DeviceDrawResourceFormatSampleUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_MULTISAMPLE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_C_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDrawResourceMultisampleUnsupported = DeviceDrawResourceFormatSampleCUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_SO_TARGETS_BOUND_WITHOUT_SOURCE</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_MULTISAMPLE_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDrawSoTargetsBoundWithoutSource = DeviceDrawResourceMultisampleUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_SO_STRIDE_LARGER_THAN_BUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_SO_TARGETS_BOUND_WITHOUT_SOURCE + 1 )
	/// </summary>
	DeviceDrawSoStrideLargerThanBuffer = DeviceDrawSoTargetsBoundWithoutSource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_SO_STRIDE_LARGER_THAN_BUFFER + 1 )
	/// </summary>
	DeviceDrawOmRenderTargetDoesNotSupportBlending = DeviceDrawSoStrideLargerThanBuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING + 1 )
	/// </summary>
	DeviceDrawOmDualSourceBlendingCanOnlyHaveRenderTarget0 = DeviceDrawOmRenderTargetDoesNotSupportBlending + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0 + 1 )
	/// </summary>
	DeviceRemovalProcessAtFault = DeviceDrawOmDualSourceBlendingCanOnlyHaveRenderTarget0 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT</b> = ( D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT + 1 )
	/// </summary>
	DeviceRemovalProcessPossiblyAtFault = DeviceRemovalProcessAtFault + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT</b> = ( D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT + 1 )
	/// </summary>
	DeviceRemovalProcessNotAtFault = DeviceRemovalProcessPossiblyAtFault + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT + 1 )
	/// </summary>
	DeviceOpenSharedResourceInvalidargReturn = DeviceRemovalProcessNotAtFault + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_INVALIDARG_RETURN + 1 )
	/// </summary>
	DeviceOpenSharedResourceOutofmemoryReturn = DeviceOpenSharedResourceInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BADINTERFACE_RETURN</b> = ( D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	DeviceOpenSharedResourceBadinterfaceReturn = DeviceOpenSharedResourceOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_VIEWPORT_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BADINTERFACE_RETURN + 1 )
	/// </summary>
	DeviceDrawViewportNotSet = DeviceOpenSharedResourceBadinterfaceReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_VIEWPORT_NOT_SET + 1 )
	/// </summary>
	CreateinputlayoutTrailingDigitInSemantic = DeviceDrawViewportNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputTrailingDigitInSemantic = CreateinputlayoutTrailingDigitInSemantic + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_DENORMFLUSH</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC + 1 )
	/// </summary>
	DeviceRssetviewportsDenormflush = CreategeometryshaderwithstreamoutputTrailingDigitInSemantic + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETRENDERTARGETS_INVALIDVIEW</b> = ( D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_DENORMFLUSH + 1 )
	/// </summary>
	OmsetrendertargetsInvalidview = DeviceRssetviewportsDenormflush + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETTEXTFILTERSIZE_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_OMSETRENDERTARGETS_INVALIDVIEW + 1 )
	/// </summary>
	DeviceSettextfiltersizeInvaliddimensions = OmsetrendertargetsInvalidview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_SETTEXTFILTERSIZE_INVALIDDIMENSIONS + 1 )
	/// </summary>
	DeviceDrawSamplerMismatch = DeviceSettextfiltersizeInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_MISMATCH + 1 )
	/// </summary>
	CreateinputlayoutTypeMismatch = DeviceDrawSamplerMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_BLENDSTATE_GETDESC_LEGACY</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH + 1 )
	/// </summary>
	BlendstateGetdescLegacy = CreateinputlayoutTypeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SHADERRESOURCEVIEW_GETDESC_LEGACY</b> = ( D3D11_MESSAGE_ID_BLENDSTATE_GETDESC_LEGACY + 1 )
	/// </summary>
	ShaderresourceviewGetdescLegacy = BlendstateGetdescLegacy + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERY_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_SHADERRESOURCEVIEW_GETDESC_LEGACY + 1 )
	/// </summary>
	CreatequeryOutofmemoryReturn = ShaderresourceviewGetdescLegacy + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEPREDICATE_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEQUERY_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatepredicateOutofmemoryReturn = CreatequeryOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFRANGE_COUNTER</b> = ( D3D11_MESSAGE_ID_CREATEPREDICATE_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatecounterOutofrangeCounter = CreatepredicateOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOUNTER_SIMULTANEOUS_ACTIVE_COUNTERS_EXHAUSTED</b> = ( D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFRANGE_COUNTER + 1 )
	/// </summary>
	CreatecounterSimultaneousActiveCountersExhausted = CreatecounterOutofrangeCounter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER</b> = ( D3D11_MESSAGE_ID_CREATECOUNTER_SIMULTANEOUS_ACTIVE_COUNTERS_EXHAUSTED + 1 )
	/// </summary>
	CreatecounterUnsupportedWellknownCounter = CreatecounterSimultaneousActiveCountersExhausted + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATECOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER + 1 )
	/// </summary>
	CreatecounterOutofmemoryReturn = CreatecounterUnsupportedWellknownCounter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOUNTER_NONEXCLUSIVE_RETURN</b> = ( D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatecounterNonexclusiveReturn = CreatecounterOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOUNTER_NULLDESC</b> = ( D3D11_MESSAGE_ID_CREATECOUNTER_NONEXCLUSIVE_RETURN + 1 )
	/// </summary>
	CreatecounterNulldesc = CreatecounterNonexclusiveReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKCOUNTER_OUTOFRANGE_COUNTER</b> = ( D3D11_MESSAGE_ID_CREATECOUNTER_NULLDESC + 1 )
	/// </summary>
	CheckcounterOutofrangeCounter = CreatecounterNulldesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKCOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER</b> = ( D3D11_MESSAGE_ID_CHECKCOUNTER_OUTOFRANGE_COUNTER + 1 )
	/// </summary>
	CheckcounterUnsupportedWellknownCounter = CheckcounterOutofrangeCounter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETPREDICATION_INVALID_PREDICATE_STATE</b> = ( D3D11_MESSAGE_ID_CHECKCOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER + 1 )
	/// </summary>
	SetpredicationInvalidPredicateState = CheckcounterUnsupportedWellknownCounter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_BEGIN_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_SETPREDICATION_INVALID_PREDICATE_STATE + 1 )
	/// </summary>
	QueryBeginUnsupported = SetpredicationInvalidPredicateState + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PREDICATE_BEGIN_DURING_PREDICATION</b> = ( D3D11_MESSAGE_ID_QUERY_BEGIN_UNSUPPORTED + 1 )
	/// </summary>
	PredicateBeginDuringPredication = QueryBeginUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_BEGIN_DUPLICATE</b> = ( D3D11_MESSAGE_ID_PREDICATE_BEGIN_DURING_PREDICATION + 1 )
	/// </summary>
	QueryBeginDuplicate = PredicateBeginDuringPredication + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_BEGIN_ABANDONING_PREVIOUS_RESULTS</b> = ( D3D11_MESSAGE_ID_QUERY_BEGIN_DUPLICATE + 1 )
	/// </summary>
	QueryBeginAbandoningPreviousResults = QueryBeginDuplicate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PREDICATE_END_DURING_PREDICATION</b> = ( D3D11_MESSAGE_ID_QUERY_BEGIN_ABANDONING_PREVIOUS_RESULTS + 1 )
	/// </summary>
	PredicateEndDuringPredication = QueryBeginAbandoningPreviousResults + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_END_ABANDONING_PREVIOUS_RESULTS</b> = ( D3D11_MESSAGE_ID_PREDICATE_END_DURING_PREDICATION + 1 )
	/// </summary>
	QueryEndAbandoningPreviousResults = PredicateEndDuringPredication + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_END_WITHOUT_BEGIN</b> = ( D3D11_MESSAGE_ID_QUERY_END_ABANDONING_PREVIOUS_RESULTS + 1 )
	/// </summary>
	QueryEndWithoutBegin = QueryEndAbandoningPreviousResults + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_DATASIZE</b> = ( D3D11_MESSAGE_ID_QUERY_END_WITHOUT_BEGIN + 1 )
	/// </summary>
	QueryGetdataInvalidDatasize = QueryEndWithoutBegin + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_FLAGS</b> = ( D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_DATASIZE + 1 )
	/// </summary>
	QueryGetdataInvalidFlags = QueryGetdataInvalidDatasize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_CALL</b> = ( D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_FLAGS + 1 )
	/// </summary>
	QueryGetdataInvalidCall = QueryGetdataInvalidFlags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_PS_OUTPUT_TYPE_MISMATCH</b> = ( D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_CALL + 1 )
	/// </summary>
	DeviceDrawPsOutputTypeMismatch = QueryGetdataInvalidCall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_GATHER_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_PS_OUTPUT_TYPE_MISMATCH + 1 )
	/// </summary>
	DeviceDrawResourceFormatGatherUnsupported = DeviceDrawPsOutputTypeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_GATHER_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDrawInvalidUseOfCenterMultisamplePattern = DeviceDrawResourceFormatGatherUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_STRIDE_TOO_LARGE</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN + 1 )
	/// </summary>
	DeviceIasetvertexbuffersStrideTooLarge = DeviceDrawInvalidUseOfCenterMultisamplePattern + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_INVALIDRANGE</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_STRIDE_TOO_LARGE + 1 )
	/// </summary>
	DeviceIasetvertexbuffersInvalidrange = DeviceIasetvertexbuffersStrideTooLarge + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_INVALIDRANGE + 1 )
	/// </summary>
	CreateinputlayoutEmptyLayout = DeviceIasetvertexbuffersInvalidrange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_SAMPLE_COUNT_MISMATCH</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT + 1 )
	/// </summary>
	DeviceDrawResourceSampleCountMismatch = CreateinputlayoutEmptyLayout + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_SAMPLE_COUNT_MISMATCH + 1 )
	/// </summary>
	LiveObjectSummary = DeviceDrawResourceSampleCountMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_BUFFER</b> = ( D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY + 1 )
	/// </summary>
	LiveBuffer = LiveObjectSummary + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_TEXTURE1D</b> = ( D3D11_MESSAGE_ID_LIVE_BUFFER + 1 )
	/// </summary>
	LiveTexture1d = LiveBuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_TEXTURE2D</b> = ( D3D11_MESSAGE_ID_LIVE_TEXTURE1D + 1 )
	/// </summary>
	LiveTexture2d = LiveTexture1d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_TEXTURE3D</b> = ( D3D11_MESSAGE_ID_LIVE_TEXTURE2D + 1 )
	/// </summary>
	LiveTexture3d = LiveTexture2d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_TEXTURE3D + 1 )
	/// </summary>
	LiveShaderresourceview = LiveTexture3d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW + 1 )
	/// </summary>
	LiveRendertargetview = LiveShaderresourceview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW + 1 )
	/// </summary>
	LiveDepthstencilview = LiveRendertargetview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_VERTEXSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW + 1 )
	/// </summary>
	LiveVertexshader = LiveDepthstencilview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_VERTEXSHADER + 1 )
	/// </summary>
	LiveGeometryshader = LiveVertexshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_PIXELSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER + 1 )
	/// </summary>
	LivePixelshader = LiveGeometryshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT</b> = ( D3D11_MESSAGE_ID_LIVE_PIXELSHADER + 1 )
	/// </summary>
	LiveInputlayout = LivePixelshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_SAMPLER</b> = ( D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT + 1 )
	/// </summary>
	LiveSampler = LiveInputlayout + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_BLENDSTATE</b> = ( D3D11_MESSAGE_ID_LIVE_SAMPLER + 1 )
	/// </summary>
	LiveBlendstate = LiveSampler + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE</b> = ( D3D11_MESSAGE_ID_LIVE_BLENDSTATE + 1 )
	/// </summary>
	LiveDepthstencilstate = LiveBlendstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE</b> = ( D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE + 1 )
	/// </summary>
	LiveRasterizerstate = LiveDepthstencilstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_QUERY</b> = ( D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE + 1 )
	/// </summary>
	LiveQuery = LiveRasterizerstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_PREDICATE</b> = ( D3D11_MESSAGE_ID_LIVE_QUERY + 1 )
	/// </summary>
	LivePredicate = LiveQuery + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_COUNTER</b> = ( D3D11_MESSAGE_ID_LIVE_PREDICATE + 1 )
	/// </summary>
	LiveCounter = LivePredicate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DEVICE</b> = ( D3D11_MESSAGE_ID_LIVE_COUNTER + 1 )
	/// </summary>
	LiveDevice = LiveCounter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_SWAPCHAIN</b> = ( D3D11_MESSAGE_ID_LIVE_DEVICE + 1 )
	/// </summary>
	LiveSwapchain = LiveDevice + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D10_MESSAGES_END</b> = ( D3D11_MESSAGE_ID_LIVE_SWAPCHAIN + 1 )
	/// </summary>
	D3d10MessagesEnd = LiveSwapchain + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D10L9_MESSAGES_START</b> = 0x100000
	/// </summary>
	D3d10l9MessagesStart = 1048576,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_STENCIL_NO_TWO_SIDED</b> = ( D3D11_MESSAGE_ID_D3D10L9_MESSAGES_START + 1 )
	/// </summary>
	CreatedepthstencilstateStencilNoTwoSided = D3d10l9MessagesStart + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthBiasClamp_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_STENCIL_NO_TWO_SIDED + 1 )
	/// </summary>
	CreaterasterizerstateDepthBiasClampNotSupported = CreatedepthstencilstateStencilNoTwoSided + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_COMPARISON_SUPPORT</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthBiasClamp_NOT_SUPPORTED + 1 )
	/// </summary>
	CreatesamplerstateNoComparisonSupport = CreaterasterizerstateDepthBiasClampNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_EXCESSIVE_ANISOTROPY</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_COMPARISON_SUPPORT + 1 )
	/// </summary>
	CreatesamplerstateExcessiveAnisotropy = CreatesamplerstateNoComparisonSupport + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_OUT_OF_RANGE</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_EXCESSIVE_ANISOTROPY + 1 )
	/// </summary>
	CreatesamplerstateBorderOutOfRange = CreatesamplerstateExcessiveAnisotropy + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETSAMPLERS_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_OUT_OF_RANGE + 1 )
	/// </summary>
	VssetsamplersNotSupported = CreatesamplerstateBorderOutOfRange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETSAMPLERS_TOO_MANY_SAMPLERS</b> = ( D3D11_MESSAGE_ID_VSSETSAMPLERS_NOT_SUPPORTED + 1 )
	/// </summary>
	VssetsamplersTooManySamplers = VssetsamplersNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETSAMPLERS_TOO_MANY_SAMPLERS</b> = ( D3D11_MESSAGE_ID_VSSETSAMPLERS_TOO_MANY_SAMPLERS + 1 )
	/// </summary>
	PssetsamplersTooManySamplers = VssetsamplersTooManySamplers + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NO_ARRAYS</b> = ( D3D11_MESSAGE_ID_PSSETSAMPLERS_TOO_MANY_SAMPLERS + 1 )
	/// </summary>
	CreateresourceNoArrays = PssetsamplersTooManySamplers + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NO_VB_AND_IB_BIND</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NO_ARRAYS + 1 )
	/// </summary>
	CreateresourceNoVbAndIbBind = CreateresourceNoArrays + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NO_TEXTURE_1D</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NO_VB_AND_IB_BIND + 1 )
	/// </summary>
	CreateresourceNoTexture1D = CreateresourceNoVbAndIbBind + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_OUT_OF_RANGE</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NO_TEXTURE_1D + 1 )
	/// </summary>
	CreateresourceDimensionOutOfRange = CreateresourceNoTexture1D + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_SHADER_RESOURCE</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_OUT_OF_RANGE + 1 )
	/// </summary>
	CreateresourceNotBindableAsShaderResource = CreateresourceDimensionOutOfRange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETRENDERTARGETS_TOO_MANY_RENDER_TARGETS</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_SHADER_RESOURCE + 1 )
	/// </summary>
	OmsetrendertargetsTooManyRenderTargets = CreateresourceNotBindableAsShaderResource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_DIFFERING_BIT_DEPTHS</b> = ( D3D11_MESSAGE_ID_OMSETRENDERTARGETS_TOO_MANY_RENDER_TARGETS + 1 )
	/// </summary>
	OmsetrendertargetsNoDifferingBitDepths = OmsetrendertargetsTooManyRenderTargets + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_BAD_BUFFER_INDEX</b> = ( D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_DIFFERING_BIT_DEPTHS + 1 )
	/// </summary>
	IasetvertexbuffersBadBufferIndex = OmsetrendertargetsNoDifferingBitDepths + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_TOO_MANY_VIEWPORTS</b> = ( D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_BAD_BUFFER_INDEX + 1 )
	/// </summary>
	DeviceRssetviewportsTooManyViewports = IasetvertexbuffersBadBufferIndex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_ADJACENCY_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_TOO_MANY_VIEWPORTS + 1 )
	/// </summary>
	DeviceIasetprimitivetopologyAdjacencyUnsupported = DeviceRssetviewportsTooManyViewports + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_TOO_MANY_SCISSORS</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_ADJACENCY_UNSUPPORTED + 1 )
	/// </summary>
	DeviceRssetscissorrectsTooManyScissors = DeviceIasetprimitivetopologyAdjacencyUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYRESOURCE_ONLY_TEXTURE_2D_WITHIN_GPU_MEMORY</b> = ( D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_TOO_MANY_SCISSORS + 1 )
	/// </summary>
	CopyresourceOnlyTexture2DWithinGpuMemory = DeviceRssetscissorrectsTooManyScissors + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_3D_READBACK</b> = ( D3D11_MESSAGE_ID_COPYRESOURCE_ONLY_TEXTURE_2D_WITHIN_GPU_MEMORY + 1 )
	/// </summary>
	CopyresourceNoTexture3DReadback = CopyresourceOnlyTexture2DWithinGpuMemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_ONLY_READBACK</b> = ( D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_3D_READBACK + 1 )
	/// </summary>
	CopyresourceNoTextureOnlyReadback = CopyresourceNoTexture3DReadback + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNSUPPORTED_FORMAT</b> = ( D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_ONLY_READBACK + 1 )
	/// </summary>
	CreateinputlayoutUnsupportedFormat = CopyresourceNoTextureOnlyReadback + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_ALPHA_TO_COVERAGE</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNSUPPORTED_FORMAT + 1 )
	/// </summary>
	CreateblendstateNoAlphaToCoverage = CreateinputlayoutUnsupportedFormat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthClipEnable_MUST_BE_TRUE</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_ALPHA_TO_COVERAGE + 1 )
	/// </summary>
	CreaterasterizerstateDepthClipEnableMustBeTrue = CreateblendstateNoAlphaToCoverage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DRAWINDEXED_STARTINDEXLOCATION_MUST_BE_POSITIVE</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthClipEnable_MUST_BE_TRUE + 1 )
	/// </summary>
	DrawindexedStartindexlocationMustBePositive = CreaterasterizerstateDepthClipEnableMustBeTrue + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_MUST_USE_LOWEST_LOD</b> = ( D3D11_MESSAGE_ID_DRAWINDEXED_STARTINDEXLOCATION_MUST_BE_POSITIVE + 1 )
	/// </summary>
	CreateshaderresourceviewMustUseLowestLod = DrawindexedStartindexlocationMustBePositive + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MINLOD_MUST_NOT_BE_FRACTIONAL</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_MUST_USE_LOWEST_LOD + 1 )
	/// </summary>
	CreatesamplerstateMinlodMustNotBeFractional = CreateshaderresourceviewMustUseLowestLod + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MAXLOD_MUST_BE_FLT_MAX</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MINLOD_MUST_NOT_BE_FRACTIONAL + 1 )
	/// </summary>
	CreatesamplerstateMaxlodMustBeFltMax = CreatesamplerstateMinlodMustNotBeFractional + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_FIRSTARRAYSLICE_MUST_BE_ZERO</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MAXLOD_MUST_BE_FLT_MAX + 1 )
	/// </summary>
	CreateshaderresourceviewFirstarraysliceMustBeZero = CreatesamplerstateMaxlodMustBeFltMax + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_CUBES_MUST_HAVE_6_SIDES</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_FIRSTARRAYSLICE_MUST_BE_ZERO + 1 )
	/// </summary>
	CreateshaderresourceviewCubesMustHave6Sides = CreateshaderresourceviewFirstarraysliceMustBeZero + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_RENDER_TARGET</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_CUBES_MUST_HAVE_6_SIDES + 1 )
	/// </summary>
	CreateresourceNotBindableAsRenderTarget = CreateshaderresourceviewCubesMustHave6Sides + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NO_DWORD_INDEX_BUFFER</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_RENDER_TARGET + 1 )
	/// </summary>
	CreateresourceNoDwordIndexBuffer = CreateresourceNotBindableAsRenderTarget + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_MSAA_PRECLUDES_SHADER_RESOURCE</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NO_DWORD_INDEX_BUFFER + 1 )
	/// </summary>
	CreateresourceMsaaPrecludesShaderResource = CreateresourceNoDwordIndexBuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_PRESENTATION_PRECLUDES_SHADER_RESOURCE</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_MSAA_PRECLUDES_SHADER_RESOURCE + 1 )
	/// </summary>
	CreateresourcePresentationPrecludesShaderResource = CreateresourceMsaaPrecludesShaderResource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_BLEND_ENABLE</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_PRESENTATION_PRECLUDES_SHADER_RESOURCE + 1 )
	/// </summary>
	CreateblendstateNoIndependentBlendEnable = CreateresourcePresentationPrecludesShaderResource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_WRITE_MASKS</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_BLEND_ENABLE + 1 )
	/// </summary>
	CreateblendstateNoIndependentWriteMasks = CreateblendstateNoIndependentBlendEnable + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NO_STREAM_OUT</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_WRITE_MASKS + 1 )
	/// </summary>
	CreateresourceNoStreamOut = CreateblendstateNoIndependentWriteMasks + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_VB_IB_FOR_BUFFERS</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NO_STREAM_OUT + 1 )
	/// </summary>
	CreateresourceOnlyVbIbForBuffers = CreateresourceNoStreamOut + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NO_AUTOGEN_FOR_VOLUMES</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_VB_IB_FOR_BUFFERS + 1 )
	/// </summary>
	CreateresourceNoAutogenForVolumes = CreateresourceOnlyVbIbForBuffers + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_DXGI_FORMAT_R8G8B8A8_CANNOT_BE_SHARED</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NO_AUTOGEN_FOR_VOLUMES + 1 )
	/// </summary>
	CreateresourceDxgiFormatR8g8b8a8CannotBeShared = CreateresourceNoAutogenForVolumes + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSHADERRESOURCES_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_DXGI_FORMAT_R8G8B8A8_CANNOT_BE_SHARED + 1 )
	/// </summary>
	VsshaderresourcesNotSupported = CreateresourceDxgiFormatR8g8b8a8CannotBeShared + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GEOMETRY_SHADER_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_VSSHADERRESOURCES_NOT_SUPPORTED + 1 )
	/// </summary>
	GeometryShaderNotSupported = VsshaderresourcesNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_STREAM_OUT_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_GEOMETRY_SHADER_NOT_SUPPORTED + 1 )
	/// </summary>
	StreamOutNotSupported = GeometryShaderNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TEXT_FILTER_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_STREAM_OUT_NOT_SUPPORTED + 1 )
	/// </summary>
	TextFilterNotSupported = StreamOutNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_SEPARATE_ALPHA_BLEND</b> = ( D3D11_MESSAGE_ID_TEXT_FILTER_NOT_SUPPORTED + 1 )
	/// </summary>
	CreateblendstateNoSeparateAlphaBlend = TextFilterNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_MRT_BLEND</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_SEPARATE_ALPHA_BLEND + 1 )
	/// </summary>
	CreateblendstateNoMrtBlend = CreateblendstateNoSeparateAlphaBlend + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_OPERATION_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_MRT_BLEND + 1 )
	/// </summary>
	CreateblendstateOperationNotSupported = CreateblendstateNoMrtBlend + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_MIRRORONCE</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_OPERATION_NOT_SUPPORTED + 1 )
	/// </summary>
	CreatesamplerstateNoMirroronce = CreateblendstateOperationNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DRAWINSTANCED_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_MIRRORONCE + 1 )
	/// </summary>
	DrawinstancedNotSupported = CreatesamplerstateNoMirroronce + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DRAWINDEXEDINSTANCED_NOT_SUPPORTED_BELOW_9_3</b> = ( D3D11_MESSAGE_ID_DRAWINSTANCED_NOT_SUPPORTED + 1 )
	/// </summary>
	DrawindexedinstancedNotSupportedBelow93 = DrawinstancedNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DRAWINDEXED_POINTLIST_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DRAWINDEXEDINSTANCED_NOT_SUPPORTED_BELOW_9_3 + 1 )
	/// </summary>
	DrawindexedPointlistUnsupported = DrawindexedinstancedNotSupportedBelow93 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SETBLENDSTATE_SAMPLE_MASK_CANNOT_BE_ZERO</b> = ( D3D11_MESSAGE_ID_DRAWINDEXED_POINTLIST_UNSUPPORTED + 1 )
	/// </summary>
	SetblendstateSampleMaskCannotBeZero = DrawindexedPointlistUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_EXCEEDS_FEATURE_LEVEL_DEFINITION</b> = ( D3D11_MESSAGE_ID_SETBLENDSTATE_SAMPLE_MASK_CANNOT_BE_ZERO + 1 )
	/// </summary>
	CreateresourceDimensionExceedsFeatureLevelDefinition = SetblendstateSampleMaskCannotBeZero + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_SINGLE_MIP_LEVEL_DEPTH_STENCIL_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_EXCEEDS_FEATURE_LEVEL_DEFINITION + 1 )
	/// </summary>
	CreateresourceOnlySingleMipLevelDepthStencilSupported = CreateresourceDimensionExceedsFeatureLevelDefinition + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_NEGATIVESCISSOR</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_SINGLE_MIP_LEVEL_DEPTH_STENCIL_SUPPORTED + 1 )
	/// </summary>
	DeviceRssetscissorrectsNegativescissor = CreateresourceOnlySingleMipLevelDepthStencilSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SLOT_ZERO_MUST_BE_D3D10_INPUT_PER_VERTEX_DATA</b> = ( D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_NEGATIVESCISSOR + 1 )
	/// </summary>
	SlotZeroMustBeD3d10InputPerVertexData = DeviceRssetscissorrectsNegativescissor + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERESOURCE_NON_POW_2_MIPMAP</b> = ( D3D11_MESSAGE_ID_SLOT_ZERO_MUST_BE_D3D10_INPUT_PER_VERTEX_DATA + 1 )
	/// </summary>
	CreateresourceNonPow2Mipmap = SlotZeroMustBeD3d10InputPerVertexData + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATERESOURCE_NON_POW_2_MIPMAP + 1 )
	/// </summary>
	CreatesamplerstateBorderNotSupported = CreateresourceNonPow2Mipmap + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_SRGB_MRT</b> = ( D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_NOT_SUPPORTED + 1 )
	/// </summary>
	OmsetrendertargetsNoSrgbMrt = CreatesamplerstateBorderNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYRESOURCE_NO_3D_MISMATCHED_UPDATES</b> = ( D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_SRGB_MRT + 1 )
	/// </summary>
	CopyresourceNo3DMismatchedUpdates = OmsetrendertargetsNoSrgbMrt + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D10L9_MESSAGES_END</b> = ( D3D11_MESSAGE_ID_COPYRESOURCE_NO_3D_MISMATCHED_UPDATES + 1 )
	/// </summary>
	D3d10l9MessagesEnd = CopyresourceNo3DMismatchedUpdates + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_MESSAGES_START</b> = 0x200000
	/// </summary>
	D3d11MessagesStart = 2097152,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_D3D11_MESSAGES_START + 1 )
	/// </summary>
	CreatedepthstencilviewInvalidflags = D3d11MessagesStart + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS + 1 )
	/// </summary>
	CreatevertexshaderInvalidclasslinkage = CreatedepthstencilviewInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE + 1 )
	/// </summary>
	CreategeometryshaderInvalidclasslinkage = CreatevertexshaderInvalidclasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTREAMS</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidnumstreams = CreategeometryshaderInvalidclasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTREAMS + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = CreategeometryshaderwithstreamoutputInvalidnumstreams + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTREAMS</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputUnexpectedstreams = CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTREAMS + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidclasslinkage = CreategeometryshaderwithstreamoutputUnexpectedstreams + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCLASSLINKAGE + 1 )
	/// </summary>
	CreatepixelshaderInvalidclasslinkage = CreategeometryshaderwithstreamoutputInvalidclasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_COMMANDLISTFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE + 1 )
	/// </summary>
	CreatedeferredcontextInvalidCommandlistflags = CreatepixelshaderInvalidclasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_SINGLETHREADED</b> = ( D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_COMMANDLISTFLAGS + 1 )
	/// </summary>
	CreatedeferredcontextSinglethreaded = CreatedeferredcontextInvalidCommandlistflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_SINGLETHREADED + 1 )
	/// </summary>
	CreatedeferredcontextInvalidargReturn = CreatedeferredcontextSinglethreaded + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_CALL_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALIDARG_RETURN + 1 )
	/// </summary>
	CreatedeferredcontextInvalidCallReturn = CreatedeferredcontextInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_CALL_RETURN + 1 )
	/// </summary>
	CreatedeferredcontextOutofmemoryReturn = CreatedeferredcontextInvalidCallReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_FINISHDISPLAYLIST_ONIMMEDIATECONTEXT</b> = ( D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	FinishdisplaylistOnimmediatecontext = CreatedeferredcontextOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_FINISHDISPLAYLIST_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_FINISHDISPLAYLIST_ONIMMEDIATECONTEXT + 1 )
	/// </summary>
	FinishdisplaylistOutofmemoryReturn = FinishdisplaylistOnimmediatecontext + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_FINISHDISPLAYLIST_INVALID_CALL_RETURN</b> = ( D3D11_MESSAGE_ID_FINISHDISPLAYLIST_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	FinishdisplaylistInvalidCallReturn = FinishdisplaylistOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_FINISHDISPLAYLIST_INVALID_CALL_RETURN + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidstream = FinishdisplaylistInvalidCallReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputUnexpectedentries = CreategeometryshaderwithstreamoutputInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputUnexpectedstrides = CreategeometryshaderwithstreamoutputUnexpectedentries + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES + 1 )
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidnumstrides = CreategeometryshaderwithstreamoutputUnexpectedstrides + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_HAZARD</b> = ( D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES + 1 )
	/// </summary>
	DeviceHssetshaderresourcesHazard = CreategeometryshaderwithstreamoutputInvalidnumstrides + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_HAZARD + 1 )
	/// </summary>
	DeviceHssetconstantbuffersHazard = DeviceHssetshaderresourcesHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_HSSETSHADERRESOURCES_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_HAZARD + 1 )
	/// </summary>
	HssetshaderresourcesUnbinddeletingobject = DeviceHssetconstantbuffersHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_HSSETSHADERRESOURCES_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	HssetconstantbuffersUnbinddeletingobject = HssetshaderresourcesUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCALL</b> = ( D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CreatehullshaderInvalidcall = HssetconstantbuffersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCALL + 1 )
	/// </summary>
	CreatehullshaderOutofmemory = CreatehullshaderInvalidcall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE</b> = ( D3D11_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY + 1 )
	/// </summary>
	CreatehullshaderInvalidshaderbytecode = CreatehullshaderOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE</b> = ( D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE + 1 )
	/// </summary>
	CreatehullshaderInvalidshadertype = CreatehullshaderInvalidshaderbytecode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE + 1 )
	/// </summary>
	CreatehullshaderInvalidclasslinkage = CreatehullshaderInvalidshadertype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE + 1 )
	/// </summary>
	DeviceHssetshaderresourcesViewsEmpty = CreatehullshaderInvalidclasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	HssetconstantbuffersInvalidbuffer = DeviceHssetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceHssetconstantbuffersBuffersEmpty = HssetconstantbuffersInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSSETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceHssetsamplersSamplersEmpty = DeviceHssetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSGETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_HSSETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceHsgetshaderresourcesViewsEmpty = DeviceHssetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSGETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_HSGETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	DeviceHsgetconstantbuffersBuffersEmpty = DeviceHsgetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_HSGETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_HSGETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceHsgetsamplersSamplersEmpty = DeviceHsgetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_HSGETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceDssetshaderresourcesHazard = DeviceHsgetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_HAZARD + 1 )
	/// </summary>
	DeviceDssetconstantbuffersHazard = DeviceDssetshaderresourcesHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DSSETSHADERRESOURCES_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_HAZARD + 1 )
	/// </summary>
	DssetshaderresourcesUnbinddeletingobject = DeviceDssetconstantbuffersHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DSSETSHADERRESOURCES_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	DssetconstantbuffersUnbinddeletingobject = DssetshaderresourcesUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCALL</b> = ( D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CreatedomainshaderInvalidcall = DssetconstantbuffersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCALL + 1 )
	/// </summary>
	CreatedomainshaderOutofmemory = CreatedomainshaderInvalidcall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE</b> = ( D3D11_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY + 1 )
	/// </summary>
	CreatedomainshaderInvalidshaderbytecode = CreatedomainshaderOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE</b> = ( D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE + 1 )
	/// </summary>
	CreatedomainshaderInvalidshadertype = CreatedomainshaderInvalidshaderbytecode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE + 1 )
	/// </summary>
	CreatedomainshaderInvalidclasslinkage = CreatedomainshaderInvalidshadertype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE + 1 )
	/// </summary>
	DeviceDssetshaderresourcesViewsEmpty = CreatedomainshaderInvalidclasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	DssetconstantbuffersInvalidbuffer = DeviceDssetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceDssetconstantbuffersBuffersEmpty = DssetconstantbuffersInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSSETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceDssetsamplersSamplersEmpty = DeviceDssetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSGETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_DSSETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceDsgetshaderresourcesViewsEmpty = DeviceDssetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSGETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_DSGETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	DeviceDsgetconstantbuffersBuffersEmpty = DeviceDsgetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DSGETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_DSGETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceDsgetsamplersSamplersEmpty = DeviceDsgetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_HS_XOR_DS_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DSGETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceDrawHsXorDsMismatch = DeviceDsgetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEFERRED_CONTEXT_REMOVAL_PROCESS_AT_FAULT</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_HS_XOR_DS_MISMATCH + 1 )
	/// </summary>
	DeferredContextRemovalProcessAtFault = DeviceDrawHsXorDsMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_INVALID_ARG_BUFFER</b> = ( D3D11_MESSAGE_ID_DEFERRED_CONTEXT_REMOVAL_PROCESS_AT_FAULT + 1 )
	/// </summary>
	DeviceDrawindirectInvalidArgBuffer = DeferredContextRemovalProcessAtFault + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_UNALIGNED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_INVALID_ARG_BUFFER + 1 )
	/// </summary>
	DeviceDrawindirectOffsetUnaligned = DeviceDrawindirectInvalidArgBuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_UNALIGNED + 1 )
	/// </summary>
	DeviceDrawindirectOffsetOverflow = DeviceDrawindirectOffsetUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDMAPTYPE</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_OVERFLOW + 1 )
	/// </summary>
	ResourceMapInvalidmaptype = DeviceDrawindirectOffsetOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDMAPTYPE + 1 )
	/// </summary>
	ResourceMapInvalidsubresource = ResourceMapInvalidmaptype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	ResourceMapInvalidflags = ResourceMapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_MAP_ALREADYMAPPED</b> = ( D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDFLAGS + 1 )
	/// </summary>
	ResourceMapAlreadymapped = ResourceMapInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_MAP_DEVICEREMOVED_RETURN</b> = ( D3D11_MESSAGE_ID_RESOURCE_MAP_ALREADYMAPPED + 1 )
	/// </summary>
	ResourceMapDeviceremovedReturn = ResourceMapAlreadymapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_MAP_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_RESOURCE_MAP_DEVICEREMOVED_RETURN + 1 )
	/// </summary>
	ResourceMapOutofmemoryReturn = ResourceMapDeviceremovedReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_MAP_WITHOUT_INITIAL_DISCARD</b> = ( D3D11_MESSAGE_ID_RESOURCE_MAP_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	ResourceMapWithoutInitialDiscard = ResourceMapOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_UNMAP_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_RESOURCE_MAP_WITHOUT_INITIAL_DISCARD + 1 )
	/// </summary>
	ResourceUnmapInvalidsubresource = ResourceMapWithoutInitialDiscard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED</b> = ( D3D11_MESSAGE_ID_RESOURCE_UNMAP_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	ResourceUnmapNotmapped = ResourceUnmapInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RASTERIZING_CONTROL_POINTS</b> = ( D3D11_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED + 1 )
	/// </summary>
	DeviceDrawRasterizingControlPoints = ResourceUnmapNotmapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RASTERIZING_CONTROL_POINTS + 1 )
	/// </summary>
	DeviceIasetprimitivetopologyTopologyUnsupported = DeviceDrawRasterizingControlPoints + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_SIGNATURE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDrawHsDsSignatureMismatch = DeviceIasetprimitivetopologyTopologyUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_SIGNATURE_MISMATCH + 1 )
	/// </summary>
	DeviceDrawHullShaderInputTopologyMismatch = DeviceDrawHsDsSignatureMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_CONTROL_POINT_COUNT_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH + 1 )
	/// </summary>
	DeviceDrawHsDsControlPointCountMismatch = DeviceDrawHullShaderInputTopologyMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_TESSELLATOR_DOMAIN_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_CONTROL_POINT_COUNT_MISMATCH + 1 )
	/// </summary>
	DeviceDrawHsDsTessellatorDomainMismatch = DeviceDrawHsDsControlPointCountMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_CONTEXT</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_TESSELLATOR_DOMAIN_MISMATCH + 1 )
	/// </summary>
	CreateContext = DeviceDrawHsDsTessellatorDomainMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_CONTEXT</b> = ( D3D11_MESSAGE_ID_CREATE_CONTEXT + 1 )
	/// </summary>
	LiveContext = CreateContext + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_CONTEXT</b> = ( D3D11_MESSAGE_ID_LIVE_CONTEXT + 1 )
	/// </summary>
	DestroyContext = LiveContext + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_BUFFER</b> = ( D3D11_MESSAGE_ID_DESTROY_CONTEXT + 1 )
	/// </summary>
	CreateBuffer = DestroyContext + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_BUFFER_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_BUFFER + 1 )
	/// </summary>
	LiveBufferWin7 = CreateBuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_BUFFER</b> = ( D3D11_MESSAGE_ID_LIVE_BUFFER_WIN7 + 1 )
	/// </summary>
	DestroyBuffer = LiveBufferWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TEXTURE1D</b> = ( D3D11_MESSAGE_ID_DESTROY_BUFFER + 1 )
	/// </summary>
	CreateTexture1d = DestroyBuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_TEXTURE1D_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_TEXTURE1D + 1 )
	/// </summary>
	LiveTexture1dWin7 = CreateTexture1d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_TEXTURE1D</b> = ( D3D11_MESSAGE_ID_LIVE_TEXTURE1D_WIN7 + 1 )
	/// </summary>
	DestroyTexture1d = LiveTexture1dWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TEXTURE2D</b> = ( D3D11_MESSAGE_ID_DESTROY_TEXTURE1D + 1 )
	/// </summary>
	CreateTexture2d = DestroyTexture1d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_TEXTURE2D_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_TEXTURE2D + 1 )
	/// </summary>
	LiveTexture2dWin7 = CreateTexture2d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_TEXTURE2D</b> = ( D3D11_MESSAGE_ID_LIVE_TEXTURE2D_WIN7 + 1 )
	/// </summary>
	DestroyTexture2d = LiveTexture2dWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TEXTURE3D</b> = ( D3D11_MESSAGE_ID_DESTROY_TEXTURE2D + 1 )
	/// </summary>
	CreateTexture3d = DestroyTexture2d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_TEXTURE3D_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_TEXTURE3D + 1 )
	/// </summary>
	LiveTexture3dWin7 = CreateTexture3d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_TEXTURE3D</b> = ( D3D11_MESSAGE_ID_LIVE_TEXTURE3D_WIN7 + 1 )
	/// </summary>
	DestroyTexture3d = LiveTexture3dWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_SHADERRESOURCEVIEW</b> = ( D3D11_MESSAGE_ID_DESTROY_TEXTURE3D + 1 )
	/// </summary>
	CreateShaderresourceview = DestroyTexture3d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_SHADERRESOURCEVIEW + 1 )
	/// </summary>
	LiveShaderresourceviewWin7 = CreateShaderresourceview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_SHADERRESOURCEVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW_WIN7 + 1 )
	/// </summary>
	DestroyShaderresourceview = LiveShaderresourceviewWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_RENDERTARGETVIEW</b> = ( D3D11_MESSAGE_ID_DESTROY_SHADERRESOURCEVIEW + 1 )
	/// </summary>
	CreateRendertargetview = DestroyShaderresourceview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_RENDERTARGETVIEW + 1 )
	/// </summary>
	LiveRendertargetviewWin7 = CreateRendertargetview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_RENDERTARGETVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW_WIN7 + 1 )
	/// </summary>
	DestroyRendertargetview = LiveRendertargetviewWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILVIEW</b> = ( D3D11_MESSAGE_ID_DESTROY_RENDERTARGETVIEW + 1 )
	/// </summary>
	CreateDepthstencilview = DestroyRendertargetview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILVIEW + 1 )
	/// </summary>
	LiveDepthstencilviewWin7 = CreateDepthstencilview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW_WIN7 + 1 )
	/// </summary>
	DestroyDepthstencilview = LiveDepthstencilviewWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_VERTEXSHADER</b> = ( D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILVIEW + 1 )
	/// </summary>
	CreateVertexshader = DestroyDepthstencilview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_VERTEXSHADER_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_VERTEXSHADER + 1 )
	/// </summary>
	LiveVertexshaderWin7 = CreateVertexshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_VERTEXSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_VERTEXSHADER_WIN7 + 1 )
	/// </summary>
	DestroyVertexshader = LiveVertexshaderWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_HULLSHADER</b> = ( D3D11_MESSAGE_ID_DESTROY_VERTEXSHADER + 1 )
	/// </summary>
	CreateHullshader = DestroyVertexshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_HULLSHADER</b> = ( D3D11_MESSAGE_ID_CREATE_HULLSHADER + 1 )
	/// </summary>
	LiveHullshader = CreateHullshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_HULLSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_HULLSHADER + 1 )
	/// </summary>
	DestroyHullshader = LiveHullshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_DOMAINSHADER</b> = ( D3D11_MESSAGE_ID_DESTROY_HULLSHADER + 1 )
	/// </summary>
	CreateDomainshader = DestroyHullshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DOMAINSHADER</b> = ( D3D11_MESSAGE_ID_CREATE_DOMAINSHADER + 1 )
	/// </summary>
	LiveDomainshader = CreateDomainshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_DOMAINSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_DOMAINSHADER + 1 )
	/// </summary>
	DestroyDomainshader = LiveDomainshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_GEOMETRYSHADER</b> = ( D3D11_MESSAGE_ID_DESTROY_DOMAINSHADER + 1 )
	/// </summary>
	CreateGeometryshader = DestroyDomainshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_GEOMETRYSHADER + 1 )
	/// </summary>
	LiveGeometryshaderWin7 = CreateGeometryshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_GEOMETRYSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER_WIN7 + 1 )
	/// </summary>
	DestroyGeometryshader = LiveGeometryshaderWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_PIXELSHADER</b> = ( D3D11_MESSAGE_ID_DESTROY_GEOMETRYSHADER + 1 )
	/// </summary>
	CreatePixelshader = DestroyGeometryshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_PIXELSHADER_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_PIXELSHADER + 1 )
	/// </summary>
	LivePixelshaderWin7 = CreatePixelshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_PIXELSHADER</b> = ( D3D11_MESSAGE_ID_LIVE_PIXELSHADER_WIN7 + 1 )
	/// </summary>
	DestroyPixelshader = LivePixelshaderWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_INPUTLAYOUT</b> = ( D3D11_MESSAGE_ID_DESTROY_PIXELSHADER + 1 )
	/// </summary>
	CreateInputlayout = DestroyPixelshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_INPUTLAYOUT + 1 )
	/// </summary>
	LiveInputlayoutWin7 = CreateInputlayout + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_INPUTLAYOUT</b> = ( D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT_WIN7 + 1 )
	/// </summary>
	DestroyInputlayout = LiveInputlayoutWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_SAMPLER</b> = ( D3D11_MESSAGE_ID_DESTROY_INPUTLAYOUT + 1 )
	/// </summary>
	CreateSampler = DestroyInputlayout + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_SAMPLER_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_SAMPLER + 1 )
	/// </summary>
	LiveSamplerWin7 = CreateSampler + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_SAMPLER</b> = ( D3D11_MESSAGE_ID_LIVE_SAMPLER_WIN7 + 1 )
	/// </summary>
	DestroySampler = LiveSamplerWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_BLENDSTATE</b> = ( D3D11_MESSAGE_ID_DESTROY_SAMPLER + 1 )
	/// </summary>
	CreateBlendstate = DestroySampler + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_BLENDSTATE_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_BLENDSTATE + 1 )
	/// </summary>
	LiveBlendstateWin7 = CreateBlendstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_BLENDSTATE</b> = ( D3D11_MESSAGE_ID_LIVE_BLENDSTATE_WIN7 + 1 )
	/// </summary>
	DestroyBlendstate = LiveBlendstateWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILSTATE</b> = ( D3D11_MESSAGE_ID_DESTROY_BLENDSTATE + 1 )
	/// </summary>
	CreateDepthstencilstate = DestroyBlendstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILSTATE + 1 )
	/// </summary>
	LiveDepthstencilstateWin7 = CreateDepthstencilstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILSTATE</b> = ( D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE_WIN7 + 1 )
	/// </summary>
	DestroyDepthstencilstate = LiveDepthstencilstateWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_RASTERIZERSTATE</b> = ( D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILSTATE + 1 )
	/// </summary>
	CreateRasterizerstate = DestroyDepthstencilstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_RASTERIZERSTATE + 1 )
	/// </summary>
	LiveRasterizerstateWin7 = CreateRasterizerstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_RASTERIZERSTATE</b> = ( D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE_WIN7 + 1 )
	/// </summary>
	DestroyRasterizerstate = LiveRasterizerstateWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_QUERY</b> = ( D3D11_MESSAGE_ID_DESTROY_RASTERIZERSTATE + 1 )
	/// </summary>
	CreateQuery = DestroyRasterizerstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_QUERY_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_QUERY + 1 )
	/// </summary>
	LiveQueryWin7 = CreateQuery + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_QUERY</b> = ( D3D11_MESSAGE_ID_LIVE_QUERY_WIN7 + 1 )
	/// </summary>
	DestroyQuery = LiveQueryWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_PREDICATE</b> = ( D3D11_MESSAGE_ID_DESTROY_QUERY + 1 )
	/// </summary>
	CreatePredicate = DestroyQuery + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_PREDICATE_WIN7</b> = ( D3D11_MESSAGE_ID_CREATE_PREDICATE + 1 )
	/// </summary>
	LivePredicateWin7 = CreatePredicate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_PREDICATE</b> = ( D3D11_MESSAGE_ID_LIVE_PREDICATE_WIN7 + 1 )
	/// </summary>
	DestroyPredicate = LivePredicateWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_COUNTER</b> = ( D3D11_MESSAGE_ID_DESTROY_PREDICATE + 1 )
	/// </summary>
	CreateCounter = DestroyPredicate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_COUNTER</b> = ( D3D11_MESSAGE_ID_CREATE_COUNTER + 1 )
	/// </summary>
	DestroyCounter = CreateCounter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_COMMANDLIST</b> = ( D3D11_MESSAGE_ID_DESTROY_COUNTER + 1 )
	/// </summary>
	CreateCommandlist = DestroyCounter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_COMMANDLIST</b> = ( D3D11_MESSAGE_ID_CREATE_COMMANDLIST + 1 )
	/// </summary>
	LiveCommandlist = CreateCommandlist + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_COMMANDLIST</b> = ( D3D11_MESSAGE_ID_LIVE_COMMANDLIST + 1 )
	/// </summary>
	DestroyCommandlist = LiveCommandlist + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_CLASSINSTANCE</b> = ( D3D11_MESSAGE_ID_DESTROY_COMMANDLIST + 1 )
	/// </summary>
	CreateClassinstance = DestroyCommandlist + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_CLASSINSTANCE</b> = ( D3D11_MESSAGE_ID_CREATE_CLASSINSTANCE + 1 )
	/// </summary>
	LiveClassinstance = CreateClassinstance + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_CLASSINSTANCE</b> = ( D3D11_MESSAGE_ID_LIVE_CLASSINSTANCE + 1 )
	/// </summary>
	DestroyClassinstance = LiveClassinstance + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_CLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_DESTROY_CLASSINSTANCE + 1 )
	/// </summary>
	CreateClasslinkage = DestroyClassinstance + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_CLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATE_CLASSLINKAGE + 1 )
	/// </summary>
	LiveClasslinkage = CreateClasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_CLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_LIVE_CLASSLINKAGE + 1 )
	/// </summary>
	DestroyClasslinkage = LiveClasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DEVICE_WIN7</b> = ( D3D11_MESSAGE_ID_DESTROY_CLASSLINKAGE + 1 )
	/// </summary>
	LiveDeviceWin7 = DestroyClasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY_WIN7</b> = ( D3D11_MESSAGE_ID_LIVE_DEVICE_WIN7 + 1 )
	/// </summary>
	LiveObjectSummaryWin7 = LiveDeviceWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_COMPUTESHADER</b> = ( D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY_WIN7 + 1 )
	/// </summary>
	CreateComputeshader = LiveObjectSummaryWin7 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_COMPUTESHADER</b> = ( D3D11_MESSAGE_ID_CREATE_COMPUTESHADER + 1 )
	/// </summary>
	LiveComputeshader = CreateComputeshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_COMPUTESHADER</b> = ( D3D11_MESSAGE_ID_LIVE_COMPUTESHADER + 1 )
	/// </summary>
	DestroyComputeshader = LiveComputeshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_UNORDEREDACCESSVIEW</b> = ( D3D11_MESSAGE_ID_DESTROY_COMPUTESHADER + 1 )
	/// </summary>
	CreateUnorderedaccessview = DestroyComputeshader + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_UNORDEREDACCESSVIEW</b> = ( D3D11_MESSAGE_ID_CREATE_UNORDEREDACCESSVIEW + 1 )
	/// </summary>
	LiveUnorderedaccessview = CreateUnorderedaccessview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_UNORDEREDACCESSVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_UNORDEREDACCESSVIEW + 1 )
	/// </summary>
	DestroyUnorderedaccessview = LiveUnorderedaccessview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACES_FEATURELEVEL</b> = ( D3D11_MESSAGE_ID_DESTROY_UNORDEREDACCESSVIEW + 1 )
	/// </summary>
	DeviceSetshaderInterfacesFeaturelevel = DestroyUnorderedaccessview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACE_COUNT_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACES_FEATURELEVEL + 1 )
	/// </summary>
	DeviceSetshaderInterfaceCountMismatch = DeviceSetshaderInterfacesFeaturelevel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACE_COUNT_MISMATCH + 1 )
	/// </summary>
	DeviceSetshaderInvalidInstance = DeviceSetshaderInterfaceCountMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_INDEX</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE + 1 )
	/// </summary>
	DeviceSetshaderInvalidInstanceIndex = DeviceSetshaderInvalidInstance + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_TYPE</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_INDEX + 1 )
	/// </summary>
	DeviceSetshaderInvalidInstanceType = DeviceSetshaderInvalidInstanceIndex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_DATA</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_TYPE + 1 )
	/// </summary>
	DeviceSetshaderInvalidInstanceData = DeviceSetshaderInvalidInstanceType + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_UNBOUND_INSTANCE_DATA</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_DATA + 1 )
	/// </summary>
	DeviceSetshaderUnboundInstanceData = DeviceSetshaderInvalidInstanceData + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETSHADER_INSTANCE_DATA_BINDINGS</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_UNBOUND_INSTANCE_DATA + 1 )
	/// </summary>
	DeviceSetshaderInstanceDataBindings = DeviceSetshaderUnboundInstanceData + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATESHADER_CLASSLINKAGE_FULL</b> = ( D3D11_MESSAGE_ID_DEVICE_SETSHADER_INSTANCE_DATA_BINDINGS + 1 )
	/// </summary>
	DeviceCreateshaderClasslinkageFull = DeviceSetshaderInstanceDataBindings + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_UNRECOGNIZED_FEATURE</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATESHADER_CLASSLINKAGE_FULL + 1 )
	/// </summary>
	DeviceCheckfeaturesupportUnrecognizedFeature = DeviceCreateshaderClasslinkageFull + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE</b> = ( D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_UNRECOGNIZED_FEATURE + 1 )
	/// </summary>
	DeviceCheckfeaturesupportMismatchedDataSize = DeviceCheckfeaturesupportUnrecognizedFeature + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE + 1 )
	/// </summary>
	DeviceCheckfeaturesupportInvalidargReturn = DeviceCheckfeaturesupportMismatchedDataSize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_INVALIDARG_RETURN + 1 )
	/// </summary>
	DeviceCssetshaderresourcesHazard = DeviceCheckfeaturesupportInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_HAZARD</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_HAZARD + 1 )
	/// </summary>
	DeviceCssetconstantbuffersHazard = DeviceCssetshaderresourcesHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CSSETSHADERRESOURCES_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_HAZARD + 1 )
	/// </summary>
	CssetshaderresourcesUnbinddeletingobject = DeviceCssetconstantbuffersHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_CSSETSHADERRESOURCES_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CssetconstantbuffersUnbinddeletingobject = CssetshaderresourcesUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCALL</b> = ( D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CreatecomputeshaderInvalidcall = CssetconstantbuffersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCALL + 1 )
	/// </summary>
	CreatecomputeshaderOutofmemory = CreatecomputeshaderInvalidcall + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE</b> = ( D3D11_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY + 1 )
	/// </summary>
	CreatecomputeshaderInvalidshaderbytecode = CreatecomputeshaderOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERTYPE</b> = ( D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE + 1 )
	/// </summary>
	CreatecomputeshaderInvalidshadertype = CreatecomputeshaderInvalidshaderbytecode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE</b> = ( D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERTYPE + 1 )
	/// </summary>
	CreatecomputeshaderInvalidclasslinkage = CreatecomputeshaderInvalidshadertype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE + 1 )
	/// </summary>
	DeviceCssetshaderresourcesViewsEmpty = CreatecomputeshaderInvalidclasslinkage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	CssetconstantbuffersInvalidbuffer = DeviceCssetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFER + 1 )
	/// </summary>
	DeviceCssetconstantbuffersBuffersEmpty = CssetconstantbuffersInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceCssetsamplersSamplersEmpty = DeviceCssetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSGETSHADERRESOURCES_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceCsgetshaderresourcesViewsEmpty = DeviceCssetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSGETCONSTANTBUFFERS_BUFFERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_CSGETSHADERRESOURCES_VIEWS_EMPTY + 1 )
	/// </summary>
	DeviceCsgetconstantbuffersBuffersEmpty = DeviceCsgetshaderresourcesViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSGETSAMPLERS_SAMPLERS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_CSGETCONSTANTBUFFERS_BUFFERS_EMPTY + 1 )
	/// </summary>
	DeviceCsgetsamplersSamplersEmpty = DeviceCsgetconstantbuffersBuffersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CSGETSAMPLERS_SAMPLERS_EMPTY + 1 )
	/// </summary>
	DeviceCreatevertexshaderDoublefloatopsnotsupported = DeviceCsgetsamplersSamplersEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatehullshaderDoublefloatopsnotsupported = DeviceCreatevertexshaderDoublefloatopsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatedomainshaderDoublefloatopsnotsupported = DeviceCreatehullshaderDoublefloatopsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderDoublefloatopsnotsupported = DeviceCreatedomainshaderDoublefloatopsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = DeviceCreategeometryshaderDoublefloatopsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatepixelshaderDoublefloatopsnotsupported = DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatecomputeshaderDoublefloatopsnotsupported = DeviceCreatepixelshaderDoublefloatopsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSTRUCTURESTRIDE</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED + 1 )
	/// </summary>
	CreatebufferInvalidstructurestride = DeviceCreatecomputeshaderDoublefloatopsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSTRUCTURESTRIDE + 1 )
	/// </summary>
	CreateshaderresourceviewInvalidflags = CreatebufferInvalidstructurestride + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFLAGS + 1 )
	/// </summary>
	CreateunorderedaccessviewInvalidresource = CreateshaderresourceviewInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE + 1 )
	/// </summary>
	CreateunorderedaccessviewInvaliddesc = CreateunorderedaccessviewInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC + 1 )
	/// </summary>
	CreateunorderedaccessviewInvalidformat = CreateunorderedaccessviewInvaliddesc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT + 1 )
	/// </summary>
	CreateunorderedaccessviewInvaliddimensions = CreateunorderedaccessviewInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS + 1 )
	/// </summary>
	CreateunorderedaccessviewUnrecognizedformat = CreateunorderedaccessviewInvaliddimensions + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_HAZARD</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT + 1 )
	/// </summary>
	DeviceOmsetrendertargetsandunorderedaccessviewsHazard = CreateunorderedaccessviewUnrecognizedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_OVERLAPPING_OLD_SLOTS</b> = ( D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_HAZARD + 1 )
	/// </summary>
	DeviceOmsetrendertargetsandunorderedaccessviewsOverlappingOldSlots = DeviceOmsetrendertargetsandunorderedaccessviewsHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NO_OP</b> = ( D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_OVERLAPPING_OLD_SLOTS + 1 )
	/// </summary>
	DeviceOmsetrendertargetsandunorderedaccessviewsNoOp = DeviceOmsetrendertargetsandunorderedaccessviewsOverlappingOldSlots + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NO_OP + 1 )
	/// </summary>
	CssetunorderedaccessviewsUnbinddeletingobject = DeviceOmsetrendertargetsandunorderedaccessviewsNoOp + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_CSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	PssetunorderedaccessviewsUnbinddeletingobject = CssetunorderedaccessviewsUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_PSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CreateunorderedaccessviewInvalidargReturn = PssetunorderedaccessviewsUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDARG_RETURN + 1 )
	/// </summary>
	CreateunorderedaccessviewOutofmemoryReturn = CreateunorderedaccessviewInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreateunorderedaccessviewToomanyobjects = CreateunorderedaccessviewOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_HAZARD</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_TOOMANYOBJECTS + 1 )
	/// </summary>
	DeviceCssetunorderedaccessviewsHazard = CreateunorderedaccessviewToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_DENORMFLUSH</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_HAZARD + 1 )
	/// </summary>
	ClearunorderedaccessviewDenormflush = DeviceCssetunorderedaccessviewsHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSS_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_DENORMFLUSH + 1 )
	/// </summary>
	DeviceCssetunorderedaccesssViewsEmpty = ClearunorderedaccessviewDenormflush + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSGETUNORDEREDACCESSS_VIEWS_EMPTY</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSS_VIEWS_EMPTY + 1 )
	/// </summary>
	DeviceCsgetunorderedaccesssViewsEmpty = DeviceCssetunorderedaccesssViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_DEVICE_CSGETUNORDEREDACCESSS_VIEWS_EMPTY + 1 )
	/// </summary>
	CreateunorderedaccessviewInvalidflags = DeviceCsgetunorderedaccesssViewsEmpty + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESESOURCEVIEW_TOOMANYOBJECTS</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS + 1 )
	/// </summary>
	CreateshaderresesourceviewToomanyobjects = CreateunorderedaccessviewInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_INVALID_ARG_BUFFER</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESESOURCEVIEW_TOOMANYOBJECTS + 1 )
	/// </summary>
	DeviceDispatchindirectInvalidArgBuffer = CreateshaderresesourceviewToomanyobjects + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_UNALIGNED</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_INVALID_ARG_BUFFER + 1 )
	/// </summary>
	DeviceDispatchindirectOffsetUnaligned = DeviceDispatchindirectInvalidArgBuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_UNALIGNED + 1 )
	/// </summary>
	DeviceDispatchindirectOffsetOverflow = DeviceDispatchindirectOffsetUnaligned + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDCONTEXT</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_OVERFLOW + 1 )
	/// </summary>
	DeviceSetresourceminlodInvalidcontext = DeviceDispatchindirectOffsetOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDCONTEXT + 1 )
	/// </summary>
	DeviceSetresourceminlodInvalidresource = DeviceSetresourceminlodInvalidcontext + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDMINLOD</b> = ( D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDRESOURCE + 1 )
	/// </summary>
	DeviceSetresourceminlodInvalidminlod = DeviceSetresourceminlodInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDCONTEXT</b> = ( D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDMINLOD + 1 )
	/// </summary>
	DeviceGetresourceminlodInvalidcontext = DeviceSetresourceminlodInvalidminlod + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDCONTEXT + 1 )
	/// </summary>
	DeviceGetresourceminlodInvalidresource = DeviceGetresourceminlodInvalidcontext + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OMSETDEPTHSTENCIL_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDRESOURCE + 1 )
	/// </summary>
	OmsetdepthstencilUnbinddeletingobject = DeviceGetresourceminlodInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DEPTH_READONLY</b> = ( D3D11_MESSAGE_ID_OMSETDEPTHSTENCIL_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CleardepthstencilviewDepthReadonly = OmsetdepthstencilUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_STENCIL_READONLY</b> = ( D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DEPTH_READONLY + 1 )
	/// </summary>
	CleardepthstencilviewStencilReadonly = CleardepthstencilviewDepthReadonly + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKFEATURESUPPORT_FORMAT_DEPRECATED</b> = ( D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_STENCIL_READONLY + 1 )
	/// </summary>
	CheckfeaturesupportFormatDeprecated = CleardepthstencilviewStencilReadonly + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RETURN_TYPE_MISMATCH</b> = ( D3D11_MESSAGE_ID_CHECKFEATURESUPPORT_FORMAT_DEPRECATED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewReturnTypeMismatch = CheckfeaturesupportFormatDeprecated + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RETURN_TYPE_MISMATCH + 1 )
	/// </summary>
	DeviceUnorderedaccessviewNotSet = DeviceUnorderedaccessviewReturnTypeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_UNORDEREDACCESSVIEW_RENDERTARGETVIEW_OVERLAP</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET + 1 )
	/// </summary>
	DeviceDrawUnorderedaccessviewRendertargetviewOverlap = DeviceUnorderedaccessviewNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_DIMENSION_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_UNORDEREDACCESSVIEW_RENDERTARGETVIEW_OVERLAP + 1 )
	/// </summary>
	DeviceUnorderedaccessviewDimensionMismatch = DeviceDrawUnorderedaccessviewRendertargetviewOverlap + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_APPEND_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_DIMENSION_MISMATCH + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAppendUnsupported = DeviceUnorderedaccessviewDimensionMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMICS_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_APPEND_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAtomicsUnsupported = DeviceUnorderedaccessviewAppendUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_STRUCTURE_STRIDE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMICS_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewStructureStrideMismatch = DeviceUnorderedaccessviewAtomicsUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_BUFFER_TYPE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_STRUCTURE_STRIDE_MISMATCH + 1 )
	/// </summary>
	DeviceUnorderedaccessviewBufferTypeMismatch = DeviceUnorderedaccessviewStructureStrideMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RAW_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_BUFFER_TYPE_MISMATCH + 1 )
	/// </summary>
	DeviceUnorderedaccessviewRawUnsupported = DeviceUnorderedaccessviewBufferTypeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_LD_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RAW_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewFormatLdUnsupported = DeviceUnorderedaccessviewRawUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_STORE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_LD_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewFormatStoreUnsupported = DeviceUnorderedaccessviewFormatLdUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_ADD_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_STORE_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAtomicAddUnsupported = DeviceUnorderedaccessviewFormatStoreUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_BITWISE_OPS_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_ADD_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAtomicBitwiseOpsUnsupported = DeviceUnorderedaccessviewAtomicAddUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_CMPSTORE_CMPEXCHANGE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_BITWISE_OPS_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAtomicCmpstoreCmpexchangeUnsupported = DeviceUnorderedaccessviewAtomicBitwiseOpsUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_EXCHANGE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_CMPSTORE_CMPEXCHANGE_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAtomicExchangeUnsupported = DeviceUnorderedaccessviewAtomicCmpstoreCmpexchangeUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_SIGNED_MINMAX_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_EXCHANGE_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAtomicSignedMinmaxUnsupported = DeviceUnorderedaccessviewAtomicExchangeUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_UNSIGNED_MINMAX_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_SIGNED_MINMAX_UNSUPPORTED + 1 )
	/// </summary>
	DeviceUnorderedaccessviewAtomicUnsignedMinmaxUnsupported = DeviceUnorderedaccessviewAtomicSignedMinmaxUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCH_BOUND_RESOURCE_MAPPED</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_UNSIGNED_MINMAX_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDispatchBoundResourceMapped = DeviceUnorderedaccessviewAtomicUnsignedMinmaxUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_OVERFLOW</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCH_BOUND_RESOURCE_MAPPED + 1 )
	/// </summary>
	DeviceDispatchThreadgroupcountOverflow = DeviceDispatchBoundResourceMapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_ZERO</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_OVERFLOW + 1 )
	/// </summary>
	DeviceDispatchThreadgroupcountZero = DeviceDispatchThreadgroupcountOverflow + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_STRUCTURE_STRIDE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_ZERO + 1 )
	/// </summary>
	DeviceShaderresourceviewStructureStrideMismatch = DeviceDispatchThreadgroupcountZero + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_BUFFER_TYPE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_STRUCTURE_STRIDE_MISMATCH + 1 )
	/// </summary>
	DeviceShaderresourceviewBufferTypeMismatch = DeviceShaderresourceviewStructureStrideMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_RAW_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_BUFFER_TYPE_MISMATCH + 1 )
	/// </summary>
	DeviceShaderresourceviewRawUnsupported = DeviceShaderresourceviewBufferTypeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCH_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_RAW_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDispatchUnsupported = DeviceShaderresourceviewRawUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCH_UNSUPPORTED + 1 )
	/// </summary>
	DeviceDispatchindirectUnsupported = DeviceDispatchUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDOFFSET</b> = ( D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_UNSUPPORTED + 1 )
	/// </summary>
	CopystructurecountInvalidoffset = DeviceDispatchindirectUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_LARGEOFFSET</b> = ( D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDOFFSET + 1 )
	/// </summary>
	CopystructurecountLargeoffset = CopystructurecountInvalidoffset + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDDESTINATIONSTATE</b> = ( D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_LARGEOFFSET + 1 )
	/// </summary>
	CopystructurecountInvaliddestinationstate = CopystructurecountLargeoffset + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDSOURCESTATE</b> = ( D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDDESTINATIONSTATE + 1 )
	/// </summary>
	CopystructurecountInvalidsourcestate = CopystructurecountInvaliddestinationstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDSOURCESTATE + 1 )
	/// </summary>
	CheckformatsupportFormatNotSupported = CopystructurecountInvalidsourcestate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDVIEW</b> = ( D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_NOT_SUPPORTED + 1 )
	/// </summary>
	DeviceCssetunorderedaccessviewsInvalidview = CheckformatsupportFormatNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDOFFSET</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDVIEW + 1 )
	/// </summary>
	DeviceCssetunorderedaccessviewsInvalidoffset = DeviceCssetunorderedaccessviewsInvalidview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_TOOMANYVIEWS</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDOFFSET + 1 )
	/// </summary>
	DeviceCssetunorderedaccessviewsToomanyviews = DeviceCssetunorderedaccessviewsInvalidoffset + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_TOOMANYVIEWS + 1 )
	/// </summary>
	ClearunorderedaccessviewfloatInvalidformat = DeviceCssetunorderedaccessviewsToomanyviews + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_COUNTER_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_INVALIDFORMAT + 1 )
	/// </summary>
	DeviceUnorderedaccessviewCounterUnsupported = ClearunorderedaccessviewfloatInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_WARNING</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_COUNTER_UNSUPPORTED + 1 )
	/// </summary>
	RefWarning = DeviceUnorderedaccessviewCounterUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_PIXEL_SHADER_WITHOUT_RTV_OR_DSV</b> = ( D3D11_MESSAGE_ID_REF_WARNING + 1 )
	/// </summary>
	DeviceDrawPixelShaderWithoutRtvOrDsv = RefWarning + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SHADER_ABORT</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_PIXEL_SHADER_WITHOUT_RTV_OR_DSV + 1 )
	/// </summary>
	ShaderAbort = DeviceDrawPixelShaderWithoutRtvOrDsv + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SHADER_MESSAGE</b> = ( D3D11_MESSAGE_ID_SHADER_ABORT + 1 )
	/// </summary>
	ShaderMessage = ShaderAbort + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SHADER_ERROR</b> = ( D3D11_MESSAGE_ID_SHADER_MESSAGE + 1 )
	/// </summary>
	ShaderError = ShaderMessage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_SHADER_ERROR + 1 )
	/// </summary>
	OfferresourcesInvalidresource = ShaderError + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_HSSETSAMPLERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDRESOURCE + 1 )
	/// </summary>
	HssetsamplersUnbinddeletingobject = OfferresourcesInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DSSETSAMPLERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_HSSETSAMPLERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	DssetsamplersUnbinddeletingobject = HssetsamplersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CSSETSAMPLERS_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DSSETSAMPLERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CssetsamplersUnbinddeletingobject = DssetsamplersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_HSSETSHADER_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_CSSETSAMPLERS_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	HssetshaderUnbinddeletingobject = CssetsamplersUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DSSETSHADER_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_HSSETSHADER_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	DssetshaderUnbinddeletingobject = HssetshaderUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CSSETSHADER_UNBINDDELETINGOBJECT</b> = ( D3D11_MESSAGE_ID_DSSETSHADER_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	CssetshaderUnbinddeletingobject = DssetshaderUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENQUEUESETEVENT_INVALIDARG_RETURN</b> = ( D3D11_MESSAGE_ID_CSSETSHADER_UNBINDDELETINGOBJECT + 1 )
	/// </summary>
	EnqueueseteventInvalidargReturn = CssetshaderUnbinddeletingobject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENQUEUESETEVENT_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_ENQUEUESETEVENT_INVALIDARG_RETURN + 1 )
	/// </summary>
	EnqueueseteventOutofmemoryReturn = EnqueueseteventInvalidargReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENQUEUESETEVENT_ACCESSDENIED_RETURN</b> = ( D3D11_MESSAGE_ID_ENQUEUESETEVENT_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	EnqueueseteventAccessdeniedReturn = EnqueueseteventOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NUMUAVS_INVALIDRANGE</b> = ( D3D11_MESSAGE_ID_ENQUEUESETEVENT_ACCESSDENIED_RETURN + 1 )
	/// </summary>
	DeviceOmsetrendertargetsandunorderedaccessviewsNumuavsInvalidrange = EnqueueseteventAccessdeniedReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT</b> = ( D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NUMUAVS_INVALIDRANGE + 1 )
	/// </summary>
	UseOfZeroRefcountObject = DeviceOmsetrendertargetsandunorderedaccessviewsNumuavsInvalidrange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_MESSAGES_END</b> = ( D3D11_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT + 1 )
	/// </summary>
	D3d11MessagesEnd = UseOfZeroRefcountObject + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_1_MESSAGES_START</b> = 0x300000
	/// </summary>
	D3d111MessagesStart = 3145728,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_VIDEODECODER</b> = ( D3D11_MESSAGE_ID_D3D11_1_MESSAGES_START + 1 )
	/// </summary>
	CreateVideodecoder = D3d111MessagesStart + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSORENUM</b> = ( D3D11_MESSAGE_ID_CREATE_VIDEODECODER + 1 )
	/// </summary>
	CreateVideoprocessorenum = CreateVideodecoder + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSOR</b> = ( D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSORENUM + 1 )
	/// </summary>
	CreateVideoprocessor = CreateVideoprocessorenum + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_DECODEROUTPUTVIEW</b> = ( D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSOR + 1 )
	/// </summary>
	CreateDecoderoutputview = CreateVideoprocessor + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_PROCESSORINPUTVIEW</b> = ( D3D11_MESSAGE_ID_CREATE_DECODEROUTPUTVIEW + 1 )
	/// </summary>
	CreateProcessorinputview = CreateDecoderoutputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_PROCESSOROUTPUTVIEW</b> = ( D3D11_MESSAGE_ID_CREATE_PROCESSORINPUTVIEW + 1 )
	/// </summary>
	CreateProcessoroutputview = CreateProcessorinputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_DEVICECONTEXTSTATE</b> = ( D3D11_MESSAGE_ID_CREATE_PROCESSOROUTPUTVIEW + 1 )
	/// </summary>
	CreateDevicecontextstate = CreateProcessoroutputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_VIDEODECODER</b> = ( D3D11_MESSAGE_ID_CREATE_DEVICECONTEXTSTATE + 1 )
	/// </summary>
	LiveVideodecoder = CreateDevicecontextstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSORENUM</b> = ( D3D11_MESSAGE_ID_LIVE_VIDEODECODER + 1 )
	/// </summary>
	LiveVideoprocessorenum = LiveVideodecoder + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSOR</b> = ( D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSORENUM + 1 )
	/// </summary>
	LiveVideoprocessor = LiveVideoprocessorenum + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DECODEROUTPUTVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSOR + 1 )
	/// </summary>
	LiveDecoderoutputview = LiveVideoprocessor + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_PROCESSORINPUTVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_DECODEROUTPUTVIEW + 1 )
	/// </summary>
	LiveProcessorinputview = LiveDecoderoutputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_PROCESSOROUTPUTVIEW</b> = ( D3D11_MESSAGE_ID_LIVE_PROCESSORINPUTVIEW + 1 )
	/// </summary>
	LiveProcessoroutputview = LiveProcessorinputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_DEVICECONTEXTSTATE</b> = ( D3D11_MESSAGE_ID_LIVE_PROCESSOROUTPUTVIEW + 1 )
	/// </summary>
	LiveDevicecontextstate = LiveProcessoroutputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_VIDEODECODER</b> = ( D3D11_MESSAGE_ID_LIVE_DEVICECONTEXTSTATE + 1 )
	/// </summary>
	DestroyVideodecoder = LiveDevicecontextstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSORENUM</b> = ( D3D11_MESSAGE_ID_DESTROY_VIDEODECODER + 1 )
	/// </summary>
	DestroyVideoprocessorenum = DestroyVideodecoder + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSOR</b> = ( D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSORENUM + 1 )
	/// </summary>
	DestroyVideoprocessor = DestroyVideoprocessorenum + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_DECODEROUTPUTVIEW</b> = ( D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSOR + 1 )
	/// </summary>
	DestroyDecoderoutputview = DestroyVideoprocessor + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_PROCESSORINPUTVIEW</b> = ( D3D11_MESSAGE_ID_DESTROY_DECODEROUTPUTVIEW + 1 )
	/// </summary>
	DestroyProcessorinputview = DestroyDecoderoutputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_PROCESSOROUTPUTVIEW</b> = ( D3D11_MESSAGE_ID_DESTROY_PROCESSORINPUTVIEW + 1 )
	/// </summary>
	DestroyProcessoroutputview = DestroyProcessorinputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_DEVICECONTEXTSTATE</b> = ( D3D11_MESSAGE_ID_DESTROY_PROCESSOROUTPUTVIEW + 1 )
	/// </summary>
	DestroyDevicecontextstate = DestroyProcessoroutputview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_DESTROY_DEVICECONTEXTSTATE + 1 )
	/// </summary>
	CreatedevicecontextstateInvalidflags = DestroyDevicecontextstate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFEATURELEVEL</b> = ( D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFLAGS + 1 )
	/// </summary>
	CreatedevicecontextstateInvalidfeaturelevel = CreatedevicecontextstateInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_FEATURELEVELS_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFEATURELEVEL + 1 )
	/// </summary>
	CreatedevicecontextstateFeaturelevelsNotSupported = CreatedevicecontextstateInvalidfeaturelevel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDREFIID</b> = ( D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_FEATURELEVELS_NOT_SUPPORTED + 1 )
	/// </summary>
	CreatedevicecontextstateInvalidrefiid = CreatedevicecontextstateFeaturelevelsNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DISCARDVIEW_INVALIDVIEW</b> = ( D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDREFIID + 1 )
	/// </summary>
	DeviceDiscardviewInvalidview = CreatedevicecontextstateInvalidrefiid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION1_INVALIDCOPYFLAGS</b> = ( D3D11_MESSAGE_ID_DEVICE_DISCARDVIEW_INVALIDVIEW + 1 )
	/// </summary>
	Copysubresourceregion1Invalidcopyflags = DeviceDiscardviewInvalidview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATESUBRESOURCE1_INVALIDCOPYFLAGS</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION1_INVALIDCOPYFLAGS + 1 )
	/// </summary>
	Updatesubresource1Invalidcopyflags = Copysubresourceregion1Invalidcopyflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT</b> = ( D3D11_MESSAGE_ID_UPDATESUBRESOURCE1_INVALIDCOPYFLAGS + 1 )
	/// </summary>
	CreaterasterizerstateInvalidforcedsamplecount = Updatesubresource1Invalidcopyflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODER_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT + 1 )
	/// </summary>
	CreatevideodecoderOutofmemoryReturn = CreaterasterizerstateInvalidforcedsamplecount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODER_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODER_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatevideodecoderNullparam = CreatevideodecoderOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODER_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODER_NULLPARAM + 1 )
	/// </summary>
	CreatevideodecoderInvalidformat = CreatevideodecoderNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODER_ZEROWIDTHHEIGHT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODER_INVALIDFORMAT + 1 )
	/// </summary>
	CreatevideodecoderZerowidthheight = CreatevideodecoderInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERSIZE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODER_ZEROWIDTHHEIGHT + 1 )
	/// </summary>
	CreatevideodecoderDriverInvalidbuffersize = CreatevideodecoderZerowidthheight + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERUSAGE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERSIZE + 1 )
	/// </summary>
	CreatevideodecoderDriverInvalidbufferusage = CreatevideodecoderDriverInvalidbuffersize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERPROFILECOUNT_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERUSAGE + 1 )
	/// </summary>
	GetvideodecoderprofilecountOutofmemory = CreatevideodecoderDriverInvalidbufferusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERPROFILECOUNT_OUTOFMEMORY + 1 )
	/// </summary>
	GetvideodecoderprofileNullparam = GetvideodecoderprofilecountOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_INVALIDINDEX</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_NULLPARAM + 1 )
	/// </summary>
	GetvideodecoderprofileInvalidindex = GetvideodecoderprofileNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_INVALIDINDEX + 1 )
	/// </summary>
	GetvideodecoderprofileOutofmemoryReturn = GetvideodecoderprofileInvalidindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CheckvideodecoderformatNullparam = GetvideodecoderprofileOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_NULLPARAM + 1 )
	/// </summary>
	CheckvideodecoderformatOutofmemoryReturn = CheckvideodecoderformatNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	GetvideodecoderconfigcountNullparam = CheckvideodecoderformatOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_NULLPARAM + 1 )
	/// </summary>
	GetvideodecoderconfigcountOutofmemoryReturn = GetvideodecoderconfigcountNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	GetvideodecoderconfigNullparam = GetvideodecoderconfigcountOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_INVALIDINDEX</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_NULLPARAM + 1 )
	/// </summary>
	GetvideodecoderconfigInvalidindex = GetvideodecoderconfigNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_INVALIDINDEX + 1 )
	/// </summary>
	GetvideodecoderconfigOutofmemoryReturn = GetvideodecoderconfigInvalidindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDECODERCREATIONPARAMS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	GetdecodercreationparamsNullparam = GetvideodecoderconfigOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDECODERDRIVERHANDLE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETDECODERCREATIONPARAMS_NULLPARAM + 1 )
	/// </summary>
	GetdecoderdriverhandleNullparam = GetdecodercreationparamsNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDECODERBUFFER_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETDECODERDRIVERHANDLE_NULLPARAM + 1 )
	/// </summary>
	GetdecoderbufferNullparam = GetdecoderdriverhandleNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDBUFFER</b> = ( D3D11_MESSAGE_ID_GETDECODERBUFFER_NULLPARAM + 1 )
	/// </summary>
	GetdecoderbufferInvalidbuffer = GetdecoderbufferNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDBUFFER + 1 )
	/// </summary>
	GetdecoderbufferInvalidtype = GetdecoderbufferInvalidbuffer + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDECODERBUFFER_LOCKED</b> = ( D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDTYPE + 1 )
	/// </summary>
	GetdecoderbufferLocked = GetdecoderbufferInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETDECODERBUFFER_LOCKED + 1 )
	/// </summary>
	ReleasedecoderbufferNullparam = GetdecoderbufferLocked + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NULLPARAM + 1 )
	/// </summary>
	ReleasedecoderbufferInvalidtype = ReleasedecoderbufferNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NOTLOCKED</b> = ( D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_INVALIDTYPE + 1 )
	/// </summary>
	ReleasedecoderbufferNotlocked = ReleasedecoderbufferInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_NULLPARAM</b> = ( D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NOTLOCKED + 1 )
	/// </summary>
	DecoderbeginframeNullparam = ReleasedecoderbufferNotlocked + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_HAZARD</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_NULLPARAM + 1 )
	/// </summary>
	DecoderbeginframeHazard = DecoderbeginframeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERENDFRAME_NULLPARAM</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_HAZARD + 1 )
	/// </summary>
	DecoderendframeNullparam = DecoderbeginframeHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_DECODERENDFRAME_NULLPARAM + 1 )
	/// </summary>
	SubmitdecoderbuffersNullparam = DecoderendframeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_NULLPARAM + 1 )
	/// </summary>
	SubmitdecoderbuffersInvalidtype = SubmitdecoderbuffersNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODEREXTENSION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_INVALIDTYPE + 1 )
	/// </summary>
	DecoderextensionNullparam = SubmitdecoderbuffersInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODEREXTENSION_INVALIDRESOURCE</b> = ( D3D11_MESSAGE_ID_DECODEREXTENSION_NULLPARAM + 1 )
	/// </summary>
	DecoderextensionInvalidresource = DecoderextensionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_DECODEREXTENSION_INVALIDRESOURCE + 1 )
	/// </summary>
	CreatevideoprocessorenumeratorOutofmemoryReturn = DecoderextensionInvalidresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatevideoprocessorenumeratorNullparam = CreatevideoprocessorenumeratorOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDFRAMEFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_NULLPARAM + 1 )
	/// </summary>
	CreatevideoprocessorenumeratorInvalidframeformat = CreatevideoprocessorenumeratorNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDFRAMEFORMAT + 1 )
	/// </summary>
	CreatevideoprocessorenumeratorInvalidusage = CreatevideoprocessorenumeratorInvalidframeformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDINPUTFRAMERATE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDUSAGE + 1 )
	/// </summary>
	CreatevideoprocessorenumeratorInvalidinputframerate = CreatevideoprocessorenumeratorInvalidusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDOUTPUTFRAMERATE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDINPUTFRAMERATE + 1 )
	/// </summary>
	CreatevideoprocessorenumeratorInvalidoutputframerate = CreatevideoprocessorenumeratorInvalidinputframerate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDWIDTHHEIGHT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDOUTPUTFRAMERATE + 1 )
	/// </summary>
	CreatevideoprocessorenumeratorInvalidwidthheight = CreatevideoprocessorenumeratorInvalidoutputframerate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORCONTENTDESC_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDWIDTHHEIGHT + 1 )
	/// </summary>
	GetvideoprocessorcontentdescNullparam = CreatevideoprocessorenumeratorInvalidwidthheight + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMAT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORCONTENTDESC_NULLPARAM + 1 )
	/// </summary>
	CheckvideoprocessorformatNullparam = GetvideoprocessorcontentdescNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORCAPS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMAT_NULLPARAM + 1 )
	/// </summary>
	GetvideoprocessorcapsNullparam = CheckvideoprocessorformatNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORCAPS_NULLPARAM + 1 )
	/// </summary>
	GetvideoprocessorrateconversioncapsNullparam = GetvideoprocessorcapsNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_INVALIDINDEX</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_NULLPARAM + 1 )
	/// </summary>
	GetvideoprocessorrateconversioncapsInvalidindex = GetvideoprocessorrateconversioncapsNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_INVALIDINDEX + 1 )
	/// </summary>
	GetvideoprocessorcustomrateNullparam = GetvideoprocessorrateconversioncapsInvalidindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_INVALIDINDEX</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_NULLPARAM + 1 )
	/// </summary>
	GetvideoprocessorcustomrateInvalidindex = GetvideoprocessorcustomrateNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_INVALIDINDEX + 1 )
	/// </summary>
	GetvideoprocessorfilterrangeNullparam = GetvideoprocessorcustomrateInvalidindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_NULLPARAM + 1 )
	/// </summary>
	GetvideoprocessorfilterrangeUnsupported = GetvideoprocessorfilterrangeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_UNSUPPORTED + 1 )
	/// </summary>
	CreatevideoprocessorOutofmemoryReturn = GetvideoprocessorfilterrangeUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatevideoprocessorNullparam = CreatevideoprocessorOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTTARGETRECT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputtargetrectNullparam = CreatevideoprocessorNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTTARGETRECT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputbackgroundcolorNullparam = VideoprocessorsetoutputtargetrectNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_INVALIDALPHA</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputbackgroundcolorInvalidalpha = VideoprocessorsetoutputbackgroundcolorNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_INVALIDALPHA + 1 )
	/// </summary>
	VideoprocessorsetoutputcolorspaceNullparam = VideoprocessorsetoutputbackgroundcolorInvalidalpha + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputalphafillmodeNullparam = VideoprocessorsetoutputcolorspaceNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputalphafillmodeUnsupported = VideoprocessorsetoutputalphafillmodeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetoutputalphafillmodeInvalidstream = VideoprocessorsetoutputalphafillmodeUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDFILLMODE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetoutputalphafillmodeInvalidfillmode = VideoprocessorsetoutputalphafillmodeInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDFILLMODE + 1 )
	/// </summary>
	VideoprocessorsetoutputconstrictionNullparam = VideoprocessorsetoutputalphafillmodeInvalidfillmode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputstereomodeNullparam = VideoprocessorsetoutputconstrictionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputstereomodeUnsupported = VideoprocessorsetoutputstereomodeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTEXTENSION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetoutputextensionNullparam = VideoprocessorsetoutputstereomodeUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTTARGETRECT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTEXTENSION_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputtargetrectNullparam = VideoprocessorsetoutputextensionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTBACKGROUNDCOLOR_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTTARGETRECT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputbackgroundcolorNullparam = VideoprocessorgetoutputtargetrectNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTBACKGROUNDCOLOR_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputcolorspaceNullparam = VideoprocessorgetoutputbackgroundcolorNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTALPHAFILLMODE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputalphafillmodeNullparam = VideoprocessorgetoutputcolorspaceNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCONSTRICTION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTALPHAFILLMODE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputconstrictionNullparam = VideoprocessorgetoutputalphafillmodeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCONSTRICTION_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputconstrictionUnsupported = VideoprocessorgetoutputconstrictionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetoutputconstrictionInvalidsize = VideoprocessorsetoutputconstrictionUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSTEREOMODE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_INVALIDSIZE + 1 )
	/// </summary>
	VideoprocessorgetoutputstereomodeNullparam = VideoprocessorsetoutputconstrictionInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTEXTENSION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSTEREOMODE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputextensionNullparam = VideoprocessorgetoutputstereomodeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTEXTENSION_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamframeformatNullparam = VideoprocessorgetoutputextensionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamframeformatInvalidformat = VideoprocessorsetstreamframeformatNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDFORMAT + 1 )
	/// </summary>
	VideoprocessorsetstreamframeformatInvalidstream = VideoprocessorsetstreamframeformatInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamcolorspaceNullparam = VideoprocessorsetstreamframeformatInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamcolorspaceInvalidstream = VideoprocessorsetstreamcolorspaceNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamoutputrateNullparam = VideoprocessorsetstreamcolorspaceInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDRATE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamoutputrateInvalidrate = VideoprocessorsetstreamoutputrateNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDFLAG</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDRATE + 1 )
	/// </summary>
	VideoprocessorsetstreamoutputrateInvalidflag = VideoprocessorsetstreamoutputrateInvalidrate + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDFLAG + 1 )
	/// </summary>
	VideoprocessorsetstreamoutputrateInvalidstream = VideoprocessorsetstreamoutputrateInvalidflag + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamsourcerectNullparam = VideoprocessorsetstreamoutputrateInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamsourcerectInvalidstream = VideoprocessorsetstreamsourcerectNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDRECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamsourcerectInvalidrect = VideoprocessorsetstreamsourcerectInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDRECT + 1 )
	/// </summary>
	VideoprocessorsetstreamdestrectNullparam = VideoprocessorsetstreamsourcerectInvalidrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamdestrectInvalidstream = VideoprocessorsetstreamdestrectNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDRECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamdestrectInvalidrect = VideoprocessorsetstreamdestrectInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDRECT + 1 )
	/// </summary>
	VideoprocessorsetstreamalphaNullparam = VideoprocessorsetstreamdestrectInvalidrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamalphaInvalidstream = VideoprocessorsetstreamalphaNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDALPHA</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamalphaInvalidalpha = VideoprocessorsetstreamalphaInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDALPHA + 1 )
	/// </summary>
	VideoprocessorsetstreampaletteNullparam = VideoprocessorsetstreamalphaInvalidalpha + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreampaletteInvalidstream = VideoprocessorsetstreampaletteNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDCOUNT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreampaletteInvalidcount = VideoprocessorsetstreampaletteInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDALPHA</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDCOUNT + 1 )
	/// </summary>
	VideoprocessorsetstreampaletteInvalidalpha = VideoprocessorsetstreampaletteInvalidcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDALPHA + 1 )
	/// </summary>
	VideoprocessorsetstreampixelaspectratioNullparam = VideoprocessorsetstreampaletteInvalidalpha + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreampixelaspectratioInvalidstream = VideoprocessorsetstreampixelaspectratioNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDRATIO</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreampixelaspectratioInvalidratio = VideoprocessorsetstreampixelaspectratioInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDRATIO + 1 )
	/// </summary>
	VideoprocessorsetstreamlumakeyNullparam = VideoprocessorsetstreampixelaspectratioInvalidratio + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamlumakeyInvalidstream = VideoprocessorsetstreamlumakeyNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDRANGE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamlumakeyInvalidrange = VideoprocessorsetstreamlumakeyInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDRANGE + 1 )
	/// </summary>
	VideoprocessorsetstreamlumakeyUnsupported = VideoprocessorsetstreamlumakeyInvalidrange + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetstreamstereoformatNullparam = VideoprocessorsetstreamlumakeyUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamstereoformatInvalidstream = VideoprocessorsetstreamstereoformatNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamstereoformatUnsupported = VideoprocessorsetstreamstereoformatInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FLIPUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetstreamstereoformatFlipunsupported = VideoprocessorsetstreamstereoformatUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_MONOOFFSETUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FLIPUNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetstreamstereoformatMonooffsetunsupported = VideoprocessorsetstreamstereoformatFlipunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FORMATUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_MONOOFFSETUNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetstreamstereoformatFormatunsupported = VideoprocessorsetstreamstereoformatMonooffsetunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FORMATUNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetstreamstereoformatInvalidformat = VideoprocessorsetstreamstereoformatFormatunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDFORMAT + 1 )
	/// </summary>
	VideoprocessorsetstreamautoprocessingmodeNullparam = VideoprocessorsetstreamstereoformatInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamautoprocessingmodeInvalidstream = VideoprocessorsetstreamautoprocessingmodeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamfilterNullparam = VideoprocessorsetstreamautoprocessingmodeInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamfilterInvalidstream = VideoprocessorsetstreamfilterNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDFILTER</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamfilterInvalidfilter = VideoprocessorsetstreamfilterInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDFILTER + 1 )
	/// </summary>
	VideoprocessorsetstreamfilterUnsupported = VideoprocessorsetstreamfilterInvalidfilter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDLEVEL</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetstreamfilterInvalidlevel = VideoprocessorsetstreamfilterUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDLEVEL + 1 )
	/// </summary>
	VideoprocessorsetstreamextensionNullparam = VideoprocessorsetstreamfilterInvalidlevel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamextensionInvalidstream = VideoprocessorsetstreamextensionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamframeformatNullparam = VideoprocessorsetstreamextensionInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamcolorspaceNullparam = VideoprocessorgetstreamframeformatNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamoutputrateNullparam = VideoprocessorgetstreamcolorspaceNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamsourcerectNullparam = VideoprocessorgetstreamoutputrateNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamdestrectNullparam = VideoprocessorgetstreamsourcerectNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamalphaNullparam = VideoprocessorgetstreamdestrectNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreampaletteNullparam = VideoprocessorgetstreamalphaNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreampixelaspectratioNullparam = VideoprocessorgetstreampaletteNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamlumakeyNullparam = VideoprocessorgetstreampixelaspectratioNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamstereoformatNullparam = VideoprocessorgetstreamlumakeyNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamautoprocessingmodeNullparam = VideoprocessorgetstreamstereoformatNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamfilterNullparam = VideoprocessorgetstreamautoprocessingmodeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamextensionNullparam = VideoprocessorgetstreamfilterNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamextensionInvalidstream = VideoprocessorgetstreamextensionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorbltNullparam = VideoprocessorgetstreamextensionInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSTREAMCOUNT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorbltInvalidstreamcount = VideoprocessorbltNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_TARGETRECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSTREAMCOUNT + 1 )
	/// </summary>
	VideoprocessorbltTargetrect = VideoprocessorbltInvalidstreamcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDOUTPUT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_TARGETRECT + 1 )
	/// </summary>
	VideoprocessorbltInvalidoutput = VideoprocessorbltTargetrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDPASTFRAMES</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDOUTPUT + 1 )
	/// </summary>
	VideoprocessorbltInvalidpastframes = VideoprocessorbltInvalidoutput + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDFUTUREFRAMES</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDPASTFRAMES + 1 )
	/// </summary>
	VideoprocessorbltInvalidfutureframes = VideoprocessorbltInvalidpastframes + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSOURCERECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDFUTUREFRAMES + 1 )
	/// </summary>
	VideoprocessorbltInvalidsourcerect = VideoprocessorbltInvalidfutureframes + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDDESTRECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSOURCERECT + 1 )
	/// </summary>
	VideoprocessorbltInvaliddestrect = VideoprocessorbltInvalidsourcerect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDINPUTRESOURCE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDDESTRECT + 1 )
	/// </summary>
	VideoprocessorbltInvalidinputresource = VideoprocessorbltInvaliddestrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAYSIZE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDINPUTRESOURCE + 1 )
	/// </summary>
	VideoprocessorbltInvalidarraysize = VideoprocessorbltInvalidinputresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAY</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAYSIZE + 1 )
	/// </summary>
	VideoprocessorbltInvalidarray = VideoprocessorbltInvalidarraysize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTEXPECTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAY + 1 )
	/// </summary>
	VideoprocessorbltRightexpected = VideoprocessorbltInvalidarray + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTNOTEXPECTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTEXPECTED + 1 )
	/// </summary>
	VideoprocessorbltRightnotexpected = VideoprocessorbltRightexpected + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_STEREONOTENABLED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTNOTEXPECTED + 1 )
	/// </summary>
	VideoprocessorbltStereonotenabled = VideoprocessorbltRightnotexpected + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDRIGHTRESOURCE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_STEREONOTENABLED + 1 )
	/// </summary>
	VideoprocessorbltInvalidrightresource = VideoprocessorbltStereonotenabled + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NOSTEREOSTREAMS</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDRIGHTRESOURCE + 1 )
	/// </summary>
	VideoprocessorbltNostereostreams = VideoprocessorbltInvalidrightresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INPUTHAZARD</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NOSTEREOSTREAMS + 1 )
	/// </summary>
	VideoprocessorbltInputhazard = VideoprocessorbltNostereostreams + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_OUTPUTHAZARD</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INPUTHAZARD + 1 )
	/// </summary>
	VideoprocessorbltOutputhazard = VideoprocessorbltInputhazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_OUTPUTHAZARD + 1 )
	/// </summary>
	CreatevideodecoderoutputviewOutofmemoryReturn = VideoprocessorbltOutputhazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatevideodecoderoutputviewNullparam = CreatevideodecoderoutputviewOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_NULLPARAM + 1 )
	/// </summary>
	CreatevideodecoderoutputviewInvalidtype = CreatevideodecoderoutputviewNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDBIND</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDTYPE + 1 )
	/// </summary>
	CreatevideodecoderoutputviewInvalidbind = CreatevideodecoderoutputviewInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDBIND + 1 )
	/// </summary>
	CreatevideodecoderoutputviewUnsupportedformat = CreatevideodecoderoutputviewInvalidbind + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDMIP</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEDFORMAT + 1 )
	/// </summary>
	CreatevideodecoderoutputviewInvalidmip = CreatevideodecoderoutputviewUnsupportedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEMIP</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDMIP + 1 )
	/// </summary>
	CreatevideodecoderoutputviewUnsupportemip = CreatevideodecoderoutputviewInvalidmip + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAYSIZE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEMIP + 1 )
	/// </summary>
	CreatevideodecoderoutputviewInvalidarraysize = CreatevideodecoderoutputviewUnsupportemip + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAY</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAYSIZE + 1 )
	/// </summary>
	CreatevideodecoderoutputviewInvalidarray = CreatevideodecoderoutputviewInvalidarraysize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDDIMENSION</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAY + 1 )
	/// </summary>
	CreatevideodecoderoutputviewInvaliddimension = CreatevideodecoderoutputviewInvalidarray + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDDIMENSION + 1 )
	/// </summary>
	CreatevideoprocessorinputviewOutofmemoryReturn = CreatevideodecoderoutputviewInvaliddimension + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatevideoprocessorinputviewNullparam = CreatevideoprocessorinputviewOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_NULLPARAM + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidtype = CreatevideoprocessorinputviewNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDBIND</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDTYPE + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidbind = CreatevideoprocessorinputviewInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMISC</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDBIND + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidmisc = CreatevideoprocessorinputviewInvalidbind + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMISC + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidusage = CreatevideoprocessorinputviewInvalidmisc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDUSAGE + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidformat = CreatevideoprocessorinputviewInvalidusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFOURCC</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFORMAT + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidfourcc = CreatevideoprocessorinputviewInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMIP</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFOURCC + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidmip = CreatevideoprocessorinputviewInvalidfourcc + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_UNSUPPORTEDMIP</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMIP + 1 )
	/// </summary>
	CreatevideoprocessorinputviewUnsupportedmip = CreatevideoprocessorinputviewInvalidmip + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAYSIZE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_UNSUPPORTEDMIP + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidarraysize = CreatevideoprocessorinputviewUnsupportedmip + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAY</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAYSIZE + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidarray = CreatevideoprocessorinputviewInvalidarraysize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDDIMENSION</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAY + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvaliddimension = CreatevideoprocessorinputviewInvalidarray + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDDIMENSION + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewOutofmemoryReturn = CreatevideoprocessorinputviewInvaliddimension + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewNullparam = CreatevideoprocessoroutputviewOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_NULLPARAM + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewInvalidtype = CreatevideoprocessoroutputviewNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDBIND</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDTYPE + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewInvalidbind = CreatevideoprocessoroutputviewInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDFORMAT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDBIND + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewInvalidformat = CreatevideoprocessoroutputviewInvalidbind + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMIP</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDFORMAT + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewInvalidmip = CreatevideoprocessoroutputviewInvalidformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDMIP</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMIP + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewUnsupportedmip = CreatevideoprocessoroutputviewInvalidmip + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDARRAY</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDMIP + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewUnsupportedarray = CreatevideoprocessoroutputviewUnsupportedmip + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDARRAY</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDARRAY + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewInvalidarray = CreatevideoprocessoroutputviewUnsupportedarray + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDDIMENSION</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDARRAY + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewInvaliddimension = CreatevideoprocessoroutputviewInvalidarray + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_FORCED_SAMPLE_COUNT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDDIMENSION + 1 )
	/// </summary>
	DeviceDrawInvalidUseOfForcedSampleCount = CreatevideoprocessoroutputviewInvaliddimension + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_FORCED_SAMPLE_COUNT + 1 )
	/// </summary>
	CreateblendstateInvalidlogicops = DeviceDrawInvalidUseOfForcedSampleCount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDARRAYWITHDECODER</b> = ( D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS + 1 )
	/// </summary>
	CreateshaderresourceviewInvaliddarraywithdecoder = CreateblendstateInvalidlogicops + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDARRAYWITHDECODER</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDARRAYWITHDECODER + 1 )
	/// </summary>
	CreateunorderedaccessviewInvaliddarraywithdecoder = CreateshaderresourceviewInvaliddarraywithdecoder + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDARRAYWITHDECODER</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDARRAYWITHDECODER + 1 )
	/// </summary>
	CreaterendertargetviewInvaliddarraywithdecoder = CreateunorderedaccessviewInvaliddarraywithdecoder + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_LOCKEDOUT_INTERFACE</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDARRAYWITHDECODER + 1 )
	/// </summary>
	DeviceLockedoutInterface = CreaterendertargetviewInvaliddarraywithdecoder + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_WARNING_ATOMIC_INCONSISTENT</b> = ( D3D11_MESSAGE_ID_DEVICE_LOCKEDOUT_INTERFACE + 1 )
	/// </summary>
	RefWarningAtomicInconsistent = DeviceLockedoutInterface + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_WARNING_READING_UNINITIALIZED_RESOURCE</b> = ( D3D11_MESSAGE_ID_REF_WARNING_ATOMIC_INCONSISTENT + 1 )
	/// </summary>
	RefWarningReadingUninitializedResource = RefWarningAtomicInconsistent + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_WARNING_RAW_HAZARD</b> = ( D3D11_MESSAGE_ID_REF_WARNING_READING_UNINITIALIZED_RESOURCE + 1 )
	/// </summary>
	RefWarningRawHazard = RefWarningReadingUninitializedResource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_WARNING_WAR_HAZARD</b> = ( D3D11_MESSAGE_ID_REF_WARNING_RAW_HAZARD + 1 )
	/// </summary>
	RefWarningWarHazard = RefWarningRawHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_REF_WARNING_WAW_HAZARD</b> = ( D3D11_MESSAGE_ID_REF_WARNING_WAR_HAZARD + 1 )
	/// </summary>
	RefWarningWawHazard = RefWarningWarHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECRYPTOSESSION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_REF_WARNING_WAW_HAZARD + 1 )
	/// </summary>
	CreatecryptosessionNullparam = RefWarningWawHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATECRYPTOSESSION_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATECRYPTOSESSION_NULLPARAM + 1 )
	/// </summary>
	CreatecryptosessionOutofmemoryReturn = CreatecryptosessionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOTYPE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CREATECRYPTOSESSION_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	GetcryptotypeNullparam = CreatecryptosessionOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDECODERPROFILE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETCRYPTOTYPE_NULLPARAM + 1 )
	/// </summary>
	GetdecoderprofileNullparam = GetcryptotypeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATESIZE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETDECODERPROFILE_NULLPARAM + 1 )
	/// </summary>
	GetcryptosessioncertificatesizeNullparam = GetdecoderprofileNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATESIZE_NULLPARAM + 1 )
	/// </summary>
	GetcryptosessioncertificateNullparam = GetcryptosessioncertificatesizeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_WRONGSIZE</b> = ( D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_NULLPARAM + 1 )
	/// </summary>
	GetcryptosessioncertificateWrongsize = GetcryptosessioncertificateNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_WRONGSIZE</b> = ( D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_WRONGSIZE + 1 )
	/// </summary>
	GetcryptosessionhandleWrongsize = GetcryptosessioncertificateWrongsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_WRONGSIZE + 1 )
	/// </summary>
	NegotiatecrpytosessionkeyexchangeNullparam = GetcryptosessionhandleWrongsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_NULLPARAM + 1 )
	/// </summary>
	EncryptionbltUnsupported = NegotiatecrpytosessionkeyexchangeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_UNSUPPORTED + 1 )
	/// </summary>
	EncryptionbltNullparam = EncryptionbltUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_WRONGDEVICE</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_NULLPARAM + 1 )
	/// </summary>
	EncryptionbltSrcWrongdevice = EncryptionbltNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_WRONGDEVICE</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_WRONGDEVICE + 1 )
	/// </summary>
	EncryptionbltDstWrongdevice = EncryptionbltSrcWrongdevice + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_FORMAT_MISMATCH</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_WRONGDEVICE + 1 )
	/// </summary>
	EncryptionbltFormatMismatch = EncryptionbltDstWrongdevice + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_SIZE_MISMATCH</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_FORMAT_MISMATCH + 1 )
	/// </summary>
	EncryptionbltSizeMismatch = EncryptionbltFormatMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MULTISAMPLED</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_SIZE_MISMATCH + 1 )
	/// </summary>
	EncryptionbltSrcMultisampled = EncryptionbltSizeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_NOT_STAGING</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MULTISAMPLED + 1 )
	/// </summary>
	EncryptionbltDstNotStaging = EncryptionbltSrcMultisampled + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MAPPED</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_NOT_STAGING + 1 )
	/// </summary>
	EncryptionbltSrcMapped = EncryptionbltDstNotStaging + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_MAPPED</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MAPPED + 1 )
	/// </summary>
	EncryptionbltDstMapped = EncryptionbltSrcMapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_OFFERED</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_MAPPED + 1 )
	/// </summary>
	EncryptionbltSrcOffered = EncryptionbltDstMapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_OFFERED</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_OFFERED + 1 )
	/// </summary>
	EncryptionbltDstOffered = EncryptionbltSrcOffered + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_CONTENT_UNDEFINED</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_OFFERED + 1 )
	/// </summary>
	EncryptionbltSrcContentUndefined = EncryptionbltDstOffered + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_CONTENT_UNDEFINED + 1 )
	/// </summary>
	DecryptionbltUnsupported = EncryptionbltSrcContentUndefined + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_NULLPARAM</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_UNSUPPORTED + 1 )
	/// </summary>
	DecryptionbltNullparam = DecryptionbltUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_WRONGDEVICE</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_NULLPARAM + 1 )
	/// </summary>
	DecryptionbltSrcWrongdevice = DecryptionbltNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_WRONGDEVICE</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_WRONGDEVICE + 1 )
	/// </summary>
	DecryptionbltDstWrongdevice = DecryptionbltSrcWrongdevice + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_FORMAT_MISMATCH</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_WRONGDEVICE + 1 )
	/// </summary>
	DecryptionbltFormatMismatch = DecryptionbltDstWrongdevice + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_SIZE_MISMATCH</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_FORMAT_MISMATCH + 1 )
	/// </summary>
	DecryptionbltSizeMismatch = DecryptionbltFormatMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MULTISAMPLED</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_SIZE_MISMATCH + 1 )
	/// </summary>
	DecryptionbltDstMultisampled = DecryptionbltSizeMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_NOT_STAGING</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MULTISAMPLED + 1 )
	/// </summary>
	DecryptionbltSrcNotStaging = DecryptionbltDstMultisampled + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_NOT_RENDER_TARGET</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_NOT_STAGING + 1 )
	/// </summary>
	DecryptionbltDstNotRenderTarget = DecryptionbltSrcNotStaging + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_MAPPED</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_NOT_RENDER_TARGET + 1 )
	/// </summary>
	DecryptionbltSrcMapped = DecryptionbltDstNotRenderTarget + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MAPPED</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_MAPPED + 1 )
	/// </summary>
	DecryptionbltDstMapped = DecryptionbltSrcMapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_OFFERED</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MAPPED + 1 )
	/// </summary>
	DecryptionbltSrcOffered = DecryptionbltDstMapped + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_OFFERED</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_OFFERED + 1 )
	/// </summary>
	DecryptionbltDstOffered = DecryptionbltSrcOffered + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_CONTENT_UNDEFINED</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_OFFERED + 1 )
	/// </summary>
	DecryptionbltSrcContentUndefined = DecryptionbltDstOffered + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_NULLPARAM</b> = ( D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_CONTENT_UNDEFINED + 1 )
	/// </summary>
	StartsessionkeyrefreshNullparam = DecryptionbltSrcContentUndefined + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_NULLPARAM + 1 )
	/// </summary>
	StartsessionkeyrefreshInvalidsize = StartsessionkeyrefreshNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_FINISHSESSIONKEYREFRESH_NULLPARAM</b> = ( D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_INVALIDSIZE + 1 )
	/// </summary>
	FinishsessionkeyrefreshNullparam = StartsessionkeyrefreshInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_NULLPARAM</b> = ( D3D11_MESSAGE_ID_FINISHSESSIONKEYREFRESH_NULLPARAM + 1 )
	/// </summary>
	GetencryptionbltkeyNullparam = FinishsessionkeyrefreshNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_NULLPARAM + 1 )
	/// </summary>
	GetencryptionbltkeyInvalidsize = GetencryptionbltkeyNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCONTENTPROTECTIONCAPS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_INVALIDSIZE + 1 )
	/// </summary>
	GetcontentprotectioncapsNullparam = GetencryptionbltkeyInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETCONTENTPROTECTIONCAPS_NULLPARAM + 1 )
	/// </summary>
	CheckcryptokeyexchangeNullparam = GetcontentprotectioncapsNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_INVALIDINDEX</b> = ( D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_NULLPARAM + 1 )
	/// </summary>
	CheckcryptokeyexchangeInvalidindex = CheckcryptokeyexchangeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_INVALIDINDEX + 1 )
	/// </summary>
	CreateauthenticatedchannelNullparam = CheckcryptokeyexchangeInvalidindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_NULLPARAM + 1 )
	/// </summary>
	CreateauthenticatedchannelUnsupported = CreateauthenticatedchannelNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_UNSUPPORTED + 1 )
	/// </summary>
	CreateauthenticatedchannelInvalidtype = CreateauthenticatedchannelUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_OUTOFMEMORY_RETURN</b> = ( D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_INVALIDTYPE + 1 )
	/// </summary>
	CreateauthenticatedchannelOutofmemoryReturn = CreateauthenticatedchannelInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_INVALIDCHANNEL</b> = ( D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_OUTOFMEMORY_RETURN + 1 )
	/// </summary>
	GetauthenticatedchannelcertificatesizeInvalidchannel = CreateauthenticatedchannelOutofmemoryReturn + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_INVALIDCHANNEL + 1 )
	/// </summary>
	GetauthenticatedchannelcertificatesizeNullparam = GetauthenticatedchannelcertificatesizeInvalidchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_INVALIDCHANNEL</b> = ( D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_NULLPARAM + 1 )
	/// </summary>
	GetauthenticatedchannelcertificateInvalidchannel = GetauthenticatedchannelcertificatesizeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_INVALIDCHANNEL + 1 )
	/// </summary>
	GetauthenticatedchannelcertificateNullparam = GetauthenticatedchannelcertificateInvalidchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_WRONGSIZE</b> = ( D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_NULLPARAM + 1 )
	/// </summary>
	GetauthenticatedchannelcertificateWrongsize = GetauthenticatedchannelcertificateNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDCHANNEL</b> = ( D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_WRONGSIZE + 1 )
	/// </summary>
	NegotiateauthenticatedchannelkeyexchangeInvalidchannel = GetauthenticatedchannelcertificateWrongsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDCHANNEL + 1 )
	/// </summary>
	NegotiateauthenticatedchannelkeyexchangeNullparam = NegotiateauthenticatedchannelkeyexchangeInvalidchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_NULLPARAM</b> = ( D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_NULLPARAM + 1 )
	/// </summary>
	QueryauthenticatedchannelNullparam = NegotiateauthenticatedchannelkeyexchangeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGCHANNEL</b> = ( D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_NULLPARAM + 1 )
	/// </summary>
	QueryauthenticatedchannelWrongchannel = QueryauthenticatedchannelNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_UNSUPPORTEDQUERY</b> = ( D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGCHANNEL + 1 )
	/// </summary>
	QueryauthenticatedchannelUnsupportedquery = QueryauthenticatedchannelWrongchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGSIZE</b> = ( D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_UNSUPPORTEDQUERY + 1 )
	/// </summary>
	QueryauthenticatedchannelWrongsize = QueryauthenticatedchannelUnsupportedquery + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_INVALIDPROCESSINDEX</b> = ( D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGSIZE + 1 )
	/// </summary>
	QueryauthenticatedchannelInvalidprocessindex = QueryauthenticatedchannelWrongsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_NULLPARAM</b> = ( D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_INVALIDPROCESSINDEX + 1 )
	/// </summary>
	ConfigureauthenticatedchannelNullparam = QueryauthenticatedchannelInvalidprocessindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGCHANNEL</b> = ( D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_NULLPARAM + 1 )
	/// </summary>
	ConfigureauthenticatedchannelWrongchannel = ConfigureauthenticatedchannelNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_UNSUPPORTEDCONFIGURE</b> = ( D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGCHANNEL + 1 )
	/// </summary>
	ConfigureauthenticatedchannelUnsupportedconfigure = ConfigureauthenticatedchannelWrongchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGSIZE</b> = ( D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_UNSUPPORTEDCONFIGURE + 1 )
	/// </summary>
	ConfigureauthenticatedchannelWrongsize = ConfigureauthenticatedchannelUnsupportedconfigure + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_INVALIDPROCESSIDTYPE</b> = ( D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGSIZE + 1 )
	/// </summary>
	ConfigureauthenticatedchannelInvalidprocessidtype = ConfigureauthenticatedchannelWrongsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT</b> = ( D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_INVALIDPROCESSIDTYPE + 1 )
	/// </summary>
	VssetconstantbuffersInvalidbufferoffsetorcount = ConfigureauthenticatedchannelInvalidprocessidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT</b> = ( D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT + 1 )
	/// </summary>
	DssetconstantbuffersInvalidbufferoffsetorcount = VssetconstantbuffersInvalidbufferoffsetorcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT</b> = ( D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT + 1 )
	/// </summary>
	HssetconstantbuffersInvalidbufferoffsetorcount = DssetconstantbuffersInvalidbufferoffsetorcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT</b> = ( D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT + 1 )
	/// </summary>
	GssetconstantbuffersInvalidbufferoffsetorcount = HssetconstantbuffersInvalidbufferoffsetorcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT</b> = ( D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT + 1 )
	/// </summary>
	PssetconstantbuffersInvalidbufferoffsetorcount = GssetconstantbuffersInvalidbufferoffsetorcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT</b> = ( D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT + 1 )
	/// </summary>
	CssetconstantbuffersInvalidbufferoffsetorcount = PssetconstantbuffersInvalidbufferoffsetorcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT + 1 )
	/// </summary>
	NegotiatecrpytosessionkeyexchangeInvalidsize = CssetconstantbuffersInvalidbufferoffsetorcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_INVALIDSIZE + 1 )
	/// </summary>
	NegotiateauthenticatedchannelkeyexchangeInvalidsize = NegotiatecrpytosessionkeyexchangeInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDPRIORITY</b> = ( D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDSIZE + 1 )
	/// </summary>
	OfferresourcesInvalidpriority = NegotiateauthenticatedchannelkeyexchangeInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_OUTOFMEMORY</b> = ( D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDPRIORITY + 1 )
	/// </summary>
	GetcryptosessionhandleOutofmemory = OfferresourcesInvalidpriority + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_OUTOFMEMORY + 1 )
	/// </summary>
	AcquirehandleforcaptureNullparam = GetcryptosessionhandleOutofmemory + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDTYPE</b> = ( D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_NULLPARAM + 1 )
	/// </summary>
	AcquirehandleforcaptureInvalidtype = AcquirehandleforcaptureNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDBIND</b> = ( D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDTYPE + 1 )
	/// </summary>
	AcquirehandleforcaptureInvalidbind = AcquirehandleforcaptureInvalidtype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDARRAY</b> = ( D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDBIND + 1 )
	/// </summary>
	AcquirehandleforcaptureInvalidarray = AcquirehandleforcaptureInvalidbind + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDARRAY + 1 )
	/// </summary>
	VideoprocessorsetstreamrotationNullparam = AcquirehandleforcaptureInvalidarray + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamrotationInvalidstream = VideoprocessorsetstreamrotationNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALID</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamrotationInvalid = VideoprocessorsetstreamrotationInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALID + 1 )
	/// </summary>
	VideoprocessorsetstreamrotationUnsupported = VideoprocessorsetstreamrotationInvalid + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorgetstreamrotationNullparam = VideoprocessorsetstreamrotationUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDVIEW</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_NULLPARAM + 1 )
	/// </summary>
	DeviceClearviewInvalidview = VideoprocessorgetstreamrotationNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDVIEW + 1 )
	/// </summary>
	DeviceCreatevertexshaderDoubleextensionsnotsupported = DeviceClearviewInvalidview + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_SHADEREXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatevertexshaderShaderextensionsnotsupported = DeviceCreatevertexshaderDoubleextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_SHADEREXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatehullshaderDoubleextensionsnotsupported = DeviceCreatevertexshaderShaderextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_SHADEREXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatehullshaderShaderextensionsnotsupported = DeviceCreatehullshaderDoubleextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_SHADEREXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatedomainshaderDoubleextensionsnotsupported = DeviceCreatehullshaderShaderextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_SHADEREXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatedomainshaderShaderextensionsnotsupported = DeviceCreatedomainshaderDoubleextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_SHADEREXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderDoubleextensionsnotsupported = DeviceCreatedomainshaderShaderextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_SHADEREXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderShaderextensionsnotsupported = DeviceCreategeometryshaderDoubleextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_SHADEREXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = DeviceCreategeometryshaderShaderextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_SHADEREXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderwithstreamoutputShaderextensionsnotsupported = DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_SHADEREXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatepixelshaderDoubleextensionsnotsupported = DeviceCreategeometryshaderwithstreamoutputShaderextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_SHADEREXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatepixelshaderShaderextensionsnotsupported = DeviceCreatepixelshaderDoubleextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_SHADEREXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatecomputeshaderDoubleextensionsnotsupported = DeviceCreatepixelshaderShaderextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_SHADEREXTENSIONSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatecomputeshaderShaderextensionsnotsupported = DeviceCreatecomputeshaderDoubleextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_MINPRECISION</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_SHADEREXTENSIONSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceShaderLinkageMinprecision = DeviceCreatecomputeshaderShaderextensionsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_MINPRECISION + 1 )
	/// </summary>
	VideoprocessorsetstreamalphaUnsupported = DeviceShaderLinkageMinprecision + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_UNSUPPORTED + 1 )
	/// </summary>
	VideoprocessorsetstreampixelaspectratioUnsupported = VideoprocessorsetstreamalphaUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_UNSUPPORTED + 1 )
	/// </summary>
	DeviceCreatevertexshaderUavsnotsupported = VideoprocessorsetstreampixelaspectratioUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatehullshaderUavsnotsupported = DeviceCreatevertexshaderUavsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatedomainshaderUavsnotsupported = DeviceCreatehullshaderUavsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderUavsnotsupported = DeviceCreatedomainshaderUavsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreategeometryshaderwithstreamoutputUavsnotsupported = DeviceCreategeometryshaderUavsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatepixelshaderUavsnotsupported = DeviceCreategeometryshaderwithstreamoutputUavsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceCreatecomputeshaderUavsnotsupported = DeviceCreatepixelshaderUavsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_INVALIDOFFSET</b> = ( D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED + 1 )
	/// </summary>
	DeviceOmsetrendertargetsandunorderedaccessviewsInvalidoffset = DeviceCreatecomputeshaderUavsnotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_TOOMANYVIEWS</b> = ( D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_INVALIDOFFSET + 1 )
	/// </summary>
	DeviceOmsetrendertargetsandunorderedaccessviewsToomanyviews = DeviceOmsetrendertargetsandunorderedaccessviewsInvalidoffset + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_NOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_TOOMANYVIEWS + 1 )
	/// </summary>
	DeviceClearviewNotsupported = DeviceOmsetrendertargetsandunorderedaccessviewsToomanyviews + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_SWAPDEVICECONTEXTSTATE_NOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_NOTSUPPORTED + 1 )
	/// </summary>
	SwapdevicecontextstateNotsupported = DeviceClearviewNotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATESUBRESOURCE_PREFERUPDATESUBRESOURCE1</b> = ( D3D11_MESSAGE_ID_SWAPDEVICECONTEXTSTATE_NOTSUPPORTED + 1 )
	/// </summary>
	UpdatesubresourcePreferupdatesubresource1 = SwapdevicecontextstateNotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDC_INACCESSIBLE</b> = ( D3D11_MESSAGE_ID_UPDATESUBRESOURCE_PREFERUPDATESUBRESOURCE1 + 1 )
	/// </summary>
	GetdcInaccessible = UpdatesubresourcePreferupdatesubresource1 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDRECT</b> = ( D3D11_MESSAGE_ID_GETDC_INACCESSIBLE + 1 )
	/// </summary>
	DeviceClearviewInvalidrect = GetdcInaccessible + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLE_MASK_IGNORED_ON_FL9</b> = ( D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDRECT + 1 )
	/// </summary>
	DeviceDrawSampleMaskIgnoredOnFl9 = DeviceClearviewInvalidrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLE_MASK_IGNORED_ON_FL9 + 1 )
	/// </summary>
	DeviceOpenSharedResource1NotSupported = DeviceDrawSampleMaskIgnoredOnFl9 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BY_NAME_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_NOT_SUPPORTED + 1 )
	/// </summary>
	DeviceOpenSharedResourceByNameNotSupported = DeviceOpenSharedResource1NotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_ENQUEUESETEVENT_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BY_NAME_NOT_SUPPORTED + 1 )
	/// </summary>
	EnqueueseteventNotSupported = DeviceOpenSharedResourceByNameNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OFFERRELEASE_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_ENQUEUESETEVENT_NOT_SUPPORTED + 1 )
	/// </summary>
	OfferreleaseNotSupported = EnqueueseteventNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OFFERRESOURCES_INACCESSIBLE</b> = ( D3D11_MESSAGE_ID_OFFERRELEASE_NOT_SUPPORTED + 1 )
	/// </summary>
	OfferresourcesInaccessible = OfferreleaseNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMSAA</b> = ( D3D11_MESSAGE_ID_OFFERRESOURCES_INACCESSIBLE + 1 )
	/// </summary>
	CreatevideoprocessorinputviewInvalidmsaa = OfferresourcesInaccessible + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMSAA</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMSAA + 1 )
	/// </summary>
	CreatevideoprocessoroutputviewInvalidmsaa = CreatevideoprocessorinputviewInvalidmsaa + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT</b> = ( D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMSAA + 1 )
	/// </summary>
	DeviceClearviewInvalidsourcerect = CreatevideoprocessoroutputviewInvalidmsaa + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT</b> = ( D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT + 1 )
	/// </summary>
	DeviceClearviewEmptyrect = DeviceClearviewInvalidsourcerect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATESUBRESOURCE_EMPTYDESTBOX</b> = ( D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT + 1 )
	/// </summary>
	UpdatesubresourceEmptydestbox = DeviceClearviewEmptyrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_EMPTYSOURCEBOX</b> = ( D3D11_MESSAGE_ID_UPDATESUBRESOURCE_EMPTYDESTBOX + 1 )
	/// </summary>
	CopysubresourceregionEmptysourcebox = UpdatesubresourceEmptydestbox + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS</b> = ( D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_EMPTYSOURCEBOX + 1 )
	/// </summary>
	DeviceDrawOmRenderTargetDoesNotSupportLogicOps = CopysubresourceregionEmptysourcebox + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_DEPTHSTENCILVIEW_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS + 1 )
	/// </summary>
	DeviceDrawDepthstencilviewNotSet = DeviceDrawOmRenderTargetDoesNotSupportLogicOps + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_DEPTHSTENCILVIEW_NOT_SET + 1 )
	/// </summary>
	DeviceDrawRendertargetviewNotSet = DeviceDrawDepthstencilviewNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET_DUE_TO_FLIP_PRESENT</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET + 1 )
	/// </summary>
	DeviceDrawRendertargetviewNotSetDueToFlipPresent = DeviceDrawRendertargetviewNotSet + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET_DUE_TO_FLIP_PRESENT</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET_DUE_TO_FLIP_PRESENT + 1 )
	/// </summary>
	DeviceUnorderedaccessviewNotSetDueToFlipPresent = DeviceDrawRendertargetviewNotSetDueToFlipPresent + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETDATAFORNEWHARDWAREKEY_NULLPARAM</b> = ( D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET_DUE_TO_FLIP_PRESENT + 1 )
	/// </summary>
	GetdatafornewhardwarekeyNullparam = DeviceUnorderedaccessviewNotSetDueToFlipPresent + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKCRYPTOSESSIONSTATUS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETDATAFORNEWHARDWAREKEY_NULLPARAM + 1 )
	/// </summary>
	CheckcryptosessionstatusNullparam = GetdatafornewhardwarekeyNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CHECKCRYPTOSESSIONSTATUS_NULLPARAM + 1 )
	/// </summary>
	GetcryptosessionprivatedatasizeNullparam = CheckcryptosessionstatusNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_NULLPARAM + 1 )
	/// </summary>
	GetvideodecodercapsNullparam = GetcryptosessionprivatedatasizeNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_ZEROWIDTHHEIGHT</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_NULLPARAM + 1 )
	/// </summary>
	GetvideodecodercapsZerowidthheight = GetvideodecodercapsNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_NULLPARAM</b> = ( D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_ZEROWIDTHHEIGHT + 1 )
	/// </summary>
	CheckvideodecoderdownsamplingNullparam = GetvideodecodercapsZerowidthheight + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE</b> = ( D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_NULLPARAM + 1 )
	/// </summary>
	CheckvideodecoderdownsamplingInvalidcolorspace = CheckvideodecoderdownsamplingNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT</b> = ( D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE + 1 )
	/// </summary>
	CheckvideodecoderdownsamplingZerowidthheight = CheckvideodecoderdownsamplingInvalidcolorspace + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT + 1 )
	/// </summary>
	VideodecoderenabledownsamplingNullparam = CheckvideodecoderdownsamplingZerowidthheight + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_NULLPARAM + 1 )
	/// </summary>
	VideodecoderenabledownsamplingUnsupported = VideodecoderenabledownsamplingNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_UNSUPPORTED + 1 )
	/// </summary>
	VideodecoderupdatedownsamplingNullparam = VideodecoderenabledownsamplingUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_NULLPARAM + 1 )
	/// </summary>
	VideodecoderupdatedownsamplingUnsupported = VideodecoderupdatedownsamplingNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMATCONVERSION_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_UNSUPPORTED + 1 )
	/// </summary>
	CheckvideoprocessorformatconversionNullparam = VideodecoderupdatedownsamplingUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE1_NULLPARAM</b> = ( D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMATCONVERSION_NULLPARAM + 1 )
	/// </summary>
	Videoprocessorsetoutputcolorspace1Nullparam = CheckvideoprocessorformatconversionNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE1_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE1_NULLPARAM + 1 )
	/// </summary>
	Videoprocessorgetoutputcolorspace1Nullparam = Videoprocessorsetoutputcolorspace1Nullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE1_NULLPARAM + 1 )
	/// </summary>
	Videoprocessorsetstreamcolorspace1Nullparam = Videoprocessorgetoutputcolorspace1Nullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_NULLPARAM + 1 )
	/// </summary>
	Videoprocessorsetstreamcolorspace1Invalidstream = Videoprocessorsetstreamcolorspace1Nullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreammirrorNullparam = Videoprocessorsetstreamcolorspace1Invalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreammirrorInvalidstream = VideoprocessorsetstreammirrorNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_UNSUPPORTED</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreammirrorUnsupported = VideoprocessorsetstreammirrorInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_UNSUPPORTED + 1 )
	/// </summary>
	Videoprocessorgetstreamcolorspace1Nullparam = VideoprocessorsetstreammirrorUnsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreammirrorNullparam = Videoprocessorgetstreamcolorspace1Nullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_NULLPARAM + 1 )
	/// </summary>
	RecommendvideodecoderdownsamplingNullparam = VideoprocessorgetstreammirrorNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE</b> = ( D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_NULLPARAM + 1 )
	/// </summary>
	RecommendvideodecoderdownsamplingInvalidcolorspace = RecommendvideodecoderdownsamplingNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT</b> = ( D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE + 1 )
	/// </summary>
	RecommendvideodecoderdownsamplingZerowidthheight = RecommendvideodecoderdownsamplingInvalidcolorspace + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSHADERUSAGE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT + 1 )
	/// </summary>
	VideoprocessorsetoutputshaderusageNullparam = RecommendvideodecoderdownsamplingZerowidthheight + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSHADERUSAGE_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSHADERUSAGE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputshaderusageNullparam = VideoprocessorsetoutputshaderusageNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSHADERUSAGE_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetbehaviorhintsNullparam = VideoprocessorgetoutputshaderusageNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSTREAMCOUNT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetbehaviorhintsInvalidstreamcount = VideoprocessorgetbehaviorhintsNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_TARGETRECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSTREAMCOUNT + 1 )
	/// </summary>
	VideoprocessorgetbehaviorhintsTargetrect = VideoprocessorgetbehaviorhintsInvalidstreamcount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSOURCERECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_TARGETRECT + 1 )
	/// </summary>
	VideoprocessorgetbehaviorhintsInvalidsourcerect = VideoprocessorgetbehaviorhintsTargetrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDDESTRECT</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSOURCERECT + 1 )
	/// </summary>
	VideoprocessorgetbehaviorhintsInvaliddestrect = VideoprocessorgetbehaviorhintsInvalidsourcerect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_INVALID_KEY_EXCHANGE_TYPE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDDESTRECT + 1 )
	/// </summary>
	GetcryptosessionprivatedatasizeInvalidKeyExchangeType = VideoprocessorgetbehaviorhintsInvaliddestrect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_ACCESS_DENIED</b> = ( D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_INVALID_KEY_EXCHANGE_TYPE + 1 )
	/// </summary>
	DeviceOpenSharedResource1AccessDenied = GetcryptosessionprivatedatasizeInvalidKeyExchangeType + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_1_MESSAGES_END</b> = ( D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_ACCESS_DENIED + 1 )
	/// </summary>
	D3d111MessagesEnd = DeviceOpenSharedResource1AccessDenied + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_2_MESSAGES_START</b> = ( D3D11_MESSAGE_ID_D3D11_1_MESSAGES_END + 1 )
	/// </summary>
	D3d112MessagesStart = D3d111MessagesEnd + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDUSAGE</b> = ( D3D11_MESSAGE_ID_D3D11_2_MESSAGES_START + 1 )
	/// </summary>
	CreatebufferInvalidusage = D3d112MessagesStart + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDUSAGE + 1 )
	/// </summary>
	Createtexture1dInvalidusage = CreatebufferInvalidusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDUSAGE</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDUSAGE + 1 )
	/// </summary>
	Createtexture2dInvalidusage = Createtexture1dInvalidusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_STEPRATE_NOT_1</b> = ( D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDUSAGE + 1 )
	/// </summary>
	CreateinputlayoutLevel9SteprateNot1 = Createtexture2dInvalidusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_INSTANCING_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_STEPRATE_NOT_1 + 1 )
	/// </summary>
	CreateinputlayoutLevel9InstancingNotSupported = CreateinputlayoutLevel9SteprateNot1 + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER</b> = ( D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_INSTANCING_NOT_SUPPORTED + 1 )
	/// </summary>
	UpdatetilemappingsInvalidParameter = CreateinputlayoutLevel9InstancingNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER</b> = ( D3D11_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER + 1 )
	/// </summary>
	CopytilemappingsInvalidParameter = UpdatetilemappingsInvalidParameter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_COPYTILES_INVALID_PARAMETER</b> = ( D3D11_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER + 1 )
	/// </summary>
	CopytilesInvalidParameter = CopytilemappingsInvalidParameter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_UPDATETILES_INVALID_PARAMETER</b> = ( D3D11_MESSAGE_ID_COPYTILES_INVALID_PARAMETER + 1 )
	/// </summary>
	UpdatetilesInvalidParameter = CopytilesInvalidParameter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESIZETILEPOOL_INVALID_PARAMETER</b> = ( D3D11_MESSAGE_ID_UPDATETILES_INVALID_PARAMETER + 1 )
	/// </summary>
	ResizetilepoolInvalidParameter = UpdatetilesInvalidParameter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TILEDRESOURCEBARRIER_INVALID_PARAMETER</b> = ( D3D11_MESSAGE_ID_RESIZETILEPOOL_INVALID_PARAMETER + 1 )
	/// </summary>
	TiledresourcebarrierInvalidParameter = ResizetilepoolInvalidParameter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_WARNING</b> = ( D3D11_MESSAGE_ID_TILEDRESOURCEBARRIER_INVALID_PARAMETER + 1 )
	/// </summary>
	NullTileMappingAccessWarning = TiledresourcebarrierInvalidParameter + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_ERROR</b> = ( D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_WARNING + 1 )
	/// </summary>
	NullTileMappingAccessError = NullTileMappingAccessWarning + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DIRTY_TILE_MAPPING_ACCESS</b> = ( D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_ERROR + 1 )
	/// </summary>
	DirtyTileMappingAccess = NullTileMappingAccessError + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DUPLICATE_TILE_MAPPINGS_IN_COVERED_AREA</b> = ( D3D11_MESSAGE_ID_DIRTY_TILE_MAPPING_ACCESS + 1 )
	/// </summary>
	DuplicateTileMappingsInCoveredArea = DirtyTileMappingAccess + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TILE_MAPPINGS_IN_COVERED_AREA_DUPLICATED_OUTSIDE</b> = ( D3D11_MESSAGE_ID_DUPLICATE_TILE_MAPPINGS_IN_COVERED_AREA + 1 )
	/// </summary>
	TileMappingsInCoveredAreaDuplicatedOutside = DuplicateTileMappingsInCoveredArea + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INCOMPATIBLE_RESOURCES</b> = ( D3D11_MESSAGE_ID_TILE_MAPPINGS_IN_COVERED_AREA_DUPLICATED_OUTSIDE + 1 )
	/// </summary>
	TileMappingsSharedBetweenIncompatibleResources = TileMappingsInCoveredAreaDuplicatedOutside + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INPUT_AND_OUTPUT</b> = ( D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INCOMPATIBLE_RESOURCES + 1 )
	/// </summary>
	TileMappingsSharedBetweenInputAndOutput = TileMappingsSharedBetweenIncompatibleResources + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INPUT_AND_OUTPUT + 1 )
	/// </summary>
	CheckmultisamplequalitylevelsInvalidflags = TileMappingsSharedBetweenInputAndOutput + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_GETRESOURCETILING_NONTILED_RESOURCE</b> = ( D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_INVALIDFLAGS + 1 )
	/// </summary>
	GetresourcetilingNontiledResource = CheckmultisamplequalitylevelsInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_RESIZETILEPOOL_SHRINK_WITH_MAPPINGS_STILL_DEFINED_PAST_END</b> = ( D3D11_MESSAGE_ID_GETRESOURCETILING_NONTILED_RESOURCE + 1 )
	/// </summary>
	ResizetilepoolShrinkWithMappingsStillDefinedPastEnd = GetresourcetilingNontiledResource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEED_TO_CALL_TILEDRESOURCEBARRIER</b> = ( D3D11_MESSAGE_ID_RESIZETILEPOOL_SHRINK_WITH_MAPPINGS_STILL_DEFINED_PAST_END + 1 )
	/// </summary>
	NeedToCallTiledresourcebarrier = ResizetilepoolShrinkWithMappingsStillDefinedPastEnd + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEVICE_INVALIDARGS</b> = ( D3D11_MESSAGE_ID_NEED_TO_CALL_TILEDRESOURCEBARRIER + 1 )
	/// </summary>
	CreatedeviceInvalidargs = NeedToCallTiledresourcebarrier + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEDEVICE_WARNING</b> = ( D3D11_MESSAGE_ID_CREATEDEVICE_INVALIDARGS + 1 )
	/// </summary>
	CreatedeviceWarning = CreatedeviceInvalidargs + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWUINT_HAZARD</b> = ( D3D11_MESSAGE_ID_CREATEDEVICE_WARNING + 1 )
	/// </summary>
	ClearunorderedaccessviewuintHazard = CreatedeviceWarning + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_HAZARD</b> = ( D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWUINT_HAZARD + 1 )
	/// </summary>
	ClearunorderedaccessviewfloatHazard = ClearunorderedaccessviewuintHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TILED_RESOURCE_TIER_1_BUFFER_TEXTURE_MISMATCH</b> = ( D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_HAZARD + 1 )
	/// </summary>
	TiledResourceTier1BufferTextureMismatch = ClearunorderedaccessviewfloatHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_CRYPTOSESSION</b> = ( D3D11_MESSAGE_ID_TILED_RESOURCE_TIER_1_BUFFER_TEXTURE_MISMATCH + 1 )
	/// </summary>
	CreateCryptosession = TiledResourceTier1BufferTextureMismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_AUTHENTICATEDCHANNEL</b> = ( D3D11_MESSAGE_ID_CREATE_CRYPTOSESSION + 1 )
	/// </summary>
	CreateAuthenticatedchannel = CreateCryptosession + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_CRYPTOSESSION</b> = ( D3D11_MESSAGE_ID_CREATE_AUTHENTICATEDCHANNEL + 1 )
	/// </summary>
	LiveCryptosession = CreateAuthenticatedchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_AUTHENTICATEDCHANNEL</b> = ( D3D11_MESSAGE_ID_LIVE_CRYPTOSESSION + 1 )
	/// </summary>
	LiveAuthenticatedchannel = LiveCryptosession + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_CRYPTOSESSION</b> = ( D3D11_MESSAGE_ID_LIVE_AUTHENTICATEDCHANNEL + 1 )
	/// </summary>
	DestroyCryptosession = LiveAuthenticatedchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_AUTHENTICATEDCHANNEL</b> = ( D3D11_MESSAGE_ID_DESTROY_CRYPTOSESSION + 1 )
	/// </summary>
	DestroyAuthenticatedchannel = DestroyCryptosession + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_2_MESSAGES_END</b> = ( D3D11_MESSAGE_ID_DESTROY_AUTHENTICATEDCHANNEL + 1 )
	/// </summary>
	D3d112MessagesEnd = DestroyAuthenticatedchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_3_MESSAGES_START</b> = ( D3D11_MESSAGE_ID_D3D11_2_MESSAGES_END + 1 )
	/// </summary>
	D3d113MessagesStart = D3d112MessagesEnd + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE</b> = ( D3D11_MESSAGE_ID_D3D11_3_MESSAGES_START + 1 )
	/// </summary>
	CreaterasterizerstateInvalidConservativerastermode = D3d113MessagesStart + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_SYSTEMVALUE</b> = ( D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE + 1 )
	/// </summary>
	DeviceDrawInvalidSystemvalue = CreaterasterizerstateInvalidConservativerastermode + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDCONTEXTTYPE</b> = ( D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_SYSTEMVALUE + 1 )
	/// </summary>
	CreatequeryorpredicateInvalidcontexttype = DeviceDrawInvalidSystemvalue + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_DECODENOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDCONTEXTTYPE + 1 )
	/// </summary>
	CreatequeryorpredicateDecodenotsupported = CreatequeryorpredicateInvalidcontexttype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_ENCODENOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_DECODENOTSUPPORTED + 1 )
	/// </summary>
	CreatequeryorpredicateEncodenotsupported = CreatequeryorpredicateDecodenotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_ENCODENOTSUPPORTED + 1 )
	/// </summary>
	CreateshaderresourceviewInvalidplaneindex = CreatequeryorpredicateEncodenotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANEINDEX + 1 )
	/// </summary>
	CreateshaderresourceviewInvalidvideoplaneindex = CreateshaderresourceviewInvalidplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_AMBIGUOUSVIDEOPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANEINDEX + 1 )
	/// </summary>
	CreateshaderresourceviewAmbiguousvideoplaneindex = CreateshaderresourceviewInvalidvideoplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_AMBIGUOUSVIDEOPLANEINDEX + 1 )
	/// </summary>
	CreaterendertargetviewInvalidplaneindex = CreateshaderresourceviewAmbiguousvideoplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANEINDEX + 1 )
	/// </summary>
	CreaterendertargetviewInvalidvideoplaneindex = CreaterendertargetviewInvalidplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_AMBIGUOUSVIDEOPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANEINDEX + 1 )
	/// </summary>
	CreaterendertargetviewAmbiguousvideoplaneindex = CreaterendertargetviewInvalidvideoplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_AMBIGUOUSVIDEOPLANEINDEX + 1 )
	/// </summary>
	CreateunorderedaccessviewInvalidplaneindex = CreaterendertargetviewAmbiguousvideoplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANEINDEX + 1 )
	/// </summary>
	CreateunorderedaccessviewInvalidvideoplaneindex = CreateunorderedaccessviewInvalidplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_AMBIGUOUSVIDEOPLANEINDEX</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANEINDEX + 1 )
	/// </summary>
	CreateunorderedaccessviewAmbiguousvideoplaneindex = CreateunorderedaccessviewInvalidvideoplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSCANDATAOFFSET</b> = ( D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_AMBIGUOUSVIDEOPLANEINDEX + 1 )
	/// </summary>
	JpegdecodeInvalidscandataoffset = CreateunorderedaccessviewAmbiguousvideoplaneindex + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_NOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSCANDATAOFFSET + 1 )
	/// </summary>
	JpegdecodeNotsupported = JpegdecodeInvalidscandataoffset + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_DIMENSIONSTOOLARGE</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_NOTSUPPORTED + 1 )
	/// </summary>
	JpegdecodeDimensionstoolarge = JpegdecodeNotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOMPONENTS</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_DIMENSIONSTOOLARGE + 1 )
	/// </summary>
	JpegdecodeInvalidcomponents = JpegdecodeDimensionstoolarge + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_DESTINATIONNOT2D</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOMPONENTS + 1 )
	/// </summary>
	JpegdecodeDestinationnot2d = JpegdecodeInvalidcomponents + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_TILEDRESOURCESUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_DESTINATIONNOT2D + 1 )
	/// </summary>
	JpegdecodeTiledresourcesunsupported = JpegdecodeDestinationnot2d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_GUARDRECTSUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_TILEDRESOURCESUNSUPPORTED + 1 )
	/// </summary>
	JpegdecodeGuardrectsunsupported = JpegdecodeTiledresourcesunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_FORMATUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_GUARDRECTSUNSUPPORTED + 1 )
	/// </summary>
	JpegdecodeFormatunsupported = JpegdecodeGuardrectsunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_FORMATUNSUPPORTED + 1 )
	/// </summary>
	JpegdecodeInvalidsubresource = JpegdecodeFormatunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_INVALIDMIPLEVEL</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	JpegdecodeInvalidmiplevel = JpegdecodeInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_EMPTYDESTBOX</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_INVALIDMIPLEVEL + 1 )
	/// </summary>
	JpegdecodeEmptydestbox = JpegdecodeInvalidmiplevel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOT2D</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_EMPTYDESTBOX + 1 )
	/// </summary>
	JpegdecodeDestboxnot2d = JpegdecodeEmptydestbox + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOTSUB</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOT2D + 1 )
	/// </summary>
	JpegdecodeDestboxnotsub = JpegdecodeDestboxnot2d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXESINTERSECT</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOTSUB + 1 )
	/// </summary>
	JpegdecodeDestboxesintersect = JpegdecodeDestboxnotsub + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEMISMATCH</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXESINTERSECT + 1 )
	/// </summary>
	JpegdecodeXsubsamplemismatch = JpegdecodeDestboxesintersect + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEMISMATCH</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEMISMATCH + 1 )
	/// </summary>
	JpegdecodeYsubsamplemismatch = JpegdecodeXsubsamplemismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEODD</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEMISMATCH + 1 )
	/// </summary>
	JpegdecodeXsubsampleodd = JpegdecodeYsubsamplemismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEODD</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEODD + 1 )
	/// </summary>
	JpegdecodeYsubsampleodd = JpegdecodeXsubsampleodd + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_OUTPUTDIMENSIONSTOOLARGE</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEODD + 1 )
	/// </summary>
	JpegdecodeOutputdimensionstoolarge = JpegdecodeYsubsampleodd + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_NONPOW2SCALEUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_OUTPUTDIMENSIONSTOOLARGE + 1 )
	/// </summary>
	JpegdecodeNonpow2scaleunsupported = JpegdecodeOutputdimensionstoolarge + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_FRACTIONALDOWNSCALETOLARGE</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_NONPOW2SCALEUNSUPPORTED + 1 )
	/// </summary>
	JpegdecodeFractionaldownscaletolarge = JpegdecodeNonpow2scaleunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_CHROMASIZEMISMATCH</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_FRACTIONALDOWNSCALETOLARGE + 1 )
	/// </summary>
	JpegdecodeChromasizemismatch = JpegdecodeFractionaldownscaletolarge + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_LUMACHROMASIZEMISMATCH</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_CHROMASIZEMISMATCH + 1 )
	/// </summary>
	JpegdecodeLumachromasizemismatch = JpegdecodeChromasizemismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_INVALIDNUMDESTINATIONS</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_LUMACHROMASIZEMISMATCH + 1 )
	/// </summary>
	JpegdecodeInvalidnumdestinations = JpegdecodeLumachromasizemismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_SUBBOXUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_INVALIDNUMDESTINATIONS + 1 )
	/// </summary>
	JpegdecodeSubboxunsupported = JpegdecodeInvalidnumdestinations + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_1DESTUNSUPPORTEDFORMAT</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_SUBBOXUNSUPPORTED + 1 )
	/// </summary>
	Jpegdecode1Destunsupportedformat = JpegdecodeSubboxunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_3DESTUNSUPPORTEDFORMAT</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_1DESTUNSUPPORTEDFORMAT + 1 )
	/// </summary>
	Jpegdecode3Destunsupportedformat = Jpegdecode1Destunsupportedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_SCALEUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_3DESTUNSUPPORTEDFORMAT + 1 )
	/// </summary>
	JpegdecodeScaleunsupported = Jpegdecode3Destunsupportedformat + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSOURCESIZE</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_SCALEUNSUPPORTED + 1 )
	/// </summary>
	JpegdecodeInvalidsourcesize = JpegdecodeScaleunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOPYFLAGS</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSOURCESIZE + 1 )
	/// </summary>
	JpegdecodeInvalidcopyflags = JpegdecodeInvalidsourcesize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_HAZARD</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOPYFLAGS + 1 )
	/// </summary>
	JpegdecodeHazard = JpegdecodeInvalidcopyflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERUSAGE</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_HAZARD + 1 )
	/// </summary>
	JpegdecodeUnsupportedsrcbufferusage = JpegdecodeHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERMISCFLAGS</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERUSAGE + 1 )
	/// </summary>
	JpegdecodeUnsupportedsrcbuffermiscflags = JpegdecodeUnsupportedsrcbufferusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDDSTTEXTUREUSAGE</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERMISCFLAGS + 1 )
	/// </summary>
	JpegdecodeUnsupporteddsttextureusage = JpegdecodeUnsupportedsrcbuffermiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_BACKBUFFERNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDDSTTEXTUREUSAGE + 1 )
	/// </summary>
	JpegdecodeBackbuffernotsupported = JpegdecodeUnsupporteddsttextureusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPRTEDCOPYFLAGS</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_BACKBUFFERNOTSUPPORTED + 1 )
	/// </summary>
	JpegdecodeUnsupprtedcopyflags = JpegdecodeBackbuffernotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_NOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPRTEDCOPYFLAGS + 1 )
	/// </summary>
	JpegencodeNotsupported = JpegdecodeUnsupprtedcopyflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSCANDATAOFFSET</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_NOTSUPPORTED + 1 )
	/// </summary>
	JpegencodeInvalidscandataoffset = JpegencodeNotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_INVALIDCOMPONENTS</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSCANDATAOFFSET + 1 )
	/// </summary>
	JpegencodeInvalidcomponents = JpegencodeInvalidscandataoffset + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_SOURCENOT2D</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_INVALIDCOMPONENTS + 1 )
	/// </summary>
	JpegencodeSourcenot2d = JpegencodeInvalidcomponents + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_TILEDRESOURCESUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_SOURCENOT2D + 1 )
	/// </summary>
	JpegencodeTiledresourcesunsupported = JpegencodeSourcenot2d + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_GUARDRECTSUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_TILEDRESOURCESUNSUPPORTED + 1 )
	/// </summary>
	JpegencodeGuardrectsunsupported = JpegencodeTiledresourcesunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_XSUBSAMPLEMISMATCH</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_GUARDRECTSUNSUPPORTED + 1 )
	/// </summary>
	JpegencodeXsubsamplemismatch = JpegencodeGuardrectsunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_YSUBSAMPLEMISMATCH</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_XSUBSAMPLEMISMATCH + 1 )
	/// </summary>
	JpegencodeYsubsamplemismatch = JpegencodeXsubsamplemismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_FORMATUNSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_YSUBSAMPLEMISMATCH + 1 )
	/// </summary>
	JpegencodeFormatunsupported = JpegencodeYsubsamplemismatch + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSUBRESOURCE</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_FORMATUNSUPPORTED + 1 )
	/// </summary>
	JpegencodeInvalidsubresource = JpegencodeFormatunsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_INVALIDMIPLEVEL</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSUBRESOURCE + 1 )
	/// </summary>
	JpegencodeInvalidmiplevel = JpegencodeInvalidsubresource + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_DIMENSIONSTOOLARGE</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_INVALIDMIPLEVEL + 1 )
	/// </summary>
	JpegencodeDimensionstoolarge = JpegencodeInvalidmiplevel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_HAZARD</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_DIMENSIONSTOOLARGE + 1 )
	/// </summary>
	JpegencodeHazard = JpegencodeDimensionstoolarge + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERUSAGE</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_HAZARD + 1 )
	/// </summary>
	JpegencodeUnsupporteddstbufferusage = JpegencodeHazard + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERMISCFLAGS</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERUSAGE + 1 )
	/// </summary>
	JpegencodeUnsupporteddstbuffermiscflags = JpegencodeUnsupporteddstbufferusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDSRCTEXTUREUSAGE</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERMISCFLAGS + 1 )
	/// </summary>
	JpegencodeUnsupportedsrctextureusage = JpegencodeUnsupporteddstbuffermiscflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_JPEGENCODE_BACKBUFFERNOTSUPPORTED</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDSRCTEXTUREUSAGE + 1 )
	/// </summary>
	JpegencodeBackbuffernotsupported = JpegencodeUnsupportedsrctextureusage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNSUPPORTEDCONTEXTTTYPEFORQUERY</b> = ( D3D11_MESSAGE_ID_JPEGENCODE_BACKBUFFERNOTSUPPORTED + 1 )
	/// </summary>
	CreatequeryorpredicateUnsupportedcontextttypeforquery = JpegencodeBackbuffernotsupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_FLUSH1_INVALIDCONTEXTTYPE</b> = ( D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNSUPPORTEDCONTEXTTTYPEFORQUERY + 1 )
	/// </summary>
	Flush1Invalidcontexttype = CreatequeryorpredicateUnsupportedcontextttypeforquery + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DEVICE_SETHARDWAREPROTECTION_INVALIDCONTEXT</b> = ( D3D11_MESSAGE_ID_FLUSH1_INVALIDCONTEXTTYPE + 1 )
	/// </summary>
	DeviceSethardwareprotectionInvalidcontext = Flush1Invalidcontexttype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_NULLPARAM</b> = ( D3D11_MESSAGE_ID_DEVICE_SETHARDWAREPROTECTION_INVALIDCONTEXT + 1 )
	/// </summary>
	VideoprocessorsetoutputhdrmetadataNullparam = DeviceSethardwareprotectionInvalidcontext + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetoutputhdrmetadataInvalidsize = VideoprocessorsetoutputhdrmetadataNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_INVALIDSIZE + 1 )
	/// </summary>
	VideoprocessorgetoutputhdrmetadataNullparam = VideoprocessorsetoutputhdrmetadataInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetoutputhdrmetadataInvalidsize = VideoprocessorgetoutputhdrmetadataNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_INVALIDSIZE + 1 )
	/// </summary>
	VideoprocessorsetstreamhdrmetadataNullparam = VideoprocessorgetoutputhdrmetadataInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorsetstreamhdrmetadataInvalidstream = VideoprocessorsetstreamhdrmetadataNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorsetstreamhdrmetadataInvalidsize = VideoprocessorsetstreamhdrmetadataInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_NULLPARAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSIZE + 1 )
	/// </summary>
	VideoprocessorgetstreamhdrmetadataNullparam = VideoprocessorsetstreamhdrmetadataInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_NULLPARAM + 1 )
	/// </summary>
	VideoprocessorgetstreamhdrmetadataInvalidstream = VideoprocessorgetstreamhdrmetadataNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSIZE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamhdrmetadataInvalidsize = VideoprocessorgetstreamhdrmetadataInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSIZE + 1 )
	/// </summary>
	VideoprocessorgetstreamframeformatInvalidstream = VideoprocessorgetstreamhdrmetadataInvalidsize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamcolorspaceInvalidstream = VideoprocessorgetstreamframeformatInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamoutputrateInvalidstream = VideoprocessorgetstreamcolorspaceInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamsourcerectInvalidstream = VideoprocessorgetstreamoutputrateInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamdestrectInvalidstream = VideoprocessorgetstreamsourcerectInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamalphaInvalidstream = VideoprocessorgetstreamdestrectInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreampaletteInvalidstream = VideoprocessorgetstreamalphaInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreampixelaspectratioInvalidstream = VideoprocessorgetstreampaletteInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamlumakeyInvalidstream = VideoprocessorgetstreampixelaspectratioInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamstereoformatInvalidstream = VideoprocessorgetstreamlumakeyInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamautoprocessingmodeInvalidstream = VideoprocessorgetstreamstereoformatInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamfilterInvalidstream = VideoprocessorgetstreamautoprocessingmodeInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreamrotationInvalidstream = VideoprocessorgetstreamfilterInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_INVALIDSTREAM + 1 )
	/// </summary>
	Videoprocessorgetstreamcolorspace1Invalidstream = VideoprocessorgetstreamrotationInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_INVALIDSTREAM</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_INVALIDSTREAM + 1 )
	/// </summary>
	VideoprocessorgetstreammirrorInvalidstream = Videoprocessorgetstreamcolorspace1Invalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_FENCE</b> = ( D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_INVALIDSTREAM + 1 )
	/// </summary>
	CreateFence = VideoprocessorgetstreammirrorInvalidstream + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_FENCE</b> = ( D3D11_MESSAGE_ID_CREATE_FENCE + 1 )
	/// </summary>
	LiveFence = CreateFence + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_FENCE</b> = ( D3D11_MESSAGE_ID_LIVE_FENCE + 1 )
	/// </summary>
	DestroyFence = LiveFence + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_SYNCHRONIZEDCHANNEL</b> = ( D3D11_MESSAGE_ID_DESTROY_FENCE + 1 )
	/// </summary>
	CreateSynchronizedchannel = DestroyFence + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_SYNCHRONIZEDCHANNEL</b> = ( D3D11_MESSAGE_ID_CREATE_SYNCHRONIZEDCHANNEL + 1 )
	/// </summary>
	LiveSynchronizedchannel = CreateSynchronizedchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_SYNCHRONIZEDCHANNEL</b> = ( D3D11_MESSAGE_ID_LIVE_SYNCHRONIZEDCHANNEL + 1 )
	/// </summary>
	DestroySynchronizedchannel = LiveSynchronizedchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATEFENCE_INVALIDFLAGS</b> = ( D3D11_MESSAGE_ID_DESTROY_SYNCHRONIZEDCHANNEL + 1 )
	/// </summary>
	CreatefenceInvalidflags = DestroySynchronizedchannel + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_3_MESSAGES_END</b> = ( D3D11_MESSAGE_ID_CREATEFENCE_INVALIDFLAGS + 1 )
	/// </summary>
	D3d113MessagesEnd = CreatefenceInvalidflags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_5_MESSAGES_START</b> = ( D3D11_MESSAGE_ID_D3D11_3_MESSAGES_END + 1 )
	/// </summary>
	D3d115MessagesStart = D3d113MessagesEnd + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_INVALIDKEYEXCHANGETYPE</b> = ( D3D11_MESSAGE_ID_D3D11_5_MESSAGES_START + 1 )
	/// </summary>
	NegotiatecryptosessionkeyexchangemtInvalidkeyexchangetype = D3d115MessagesStart + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_INVALIDKEYEXCHANGETYPE + 1 )
	/// </summary>
	NegotiatecryptosessionkeyexchangemtNotSupported = NegotiatecryptosessionkeyexchangemtInvalidkeyexchangetype + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT_COUNT</b> = ( D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_NOT_SUPPORTED + 1 )
	/// </summary>
	DecoderbeginframeInvalidHistogramComponentCount = NegotiatecryptosessionkeyexchangemtNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT_COUNT + 1 )
	/// </summary>
	DecoderbeginframeInvalidHistogramComponent = DecoderbeginframeInvalidHistogramComponentCount + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_SIZE</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT + 1 )
	/// </summary>
	DecoderbeginframeInvalidHistogramBufferSize = DecoderbeginframeInvalidHistogramComponent + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_USAGE</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_SIZE + 1 )
	/// </summary>
	DecoderbeginframeInvalidHistogramBufferUsage = DecoderbeginframeInvalidHistogramBufferSize + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_MISC_FLAGS</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_USAGE + 1 )
	/// </summary>
	DecoderbeginframeInvalidHistogramBufferMiscFlags = DecoderbeginframeInvalidHistogramBufferUsage + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_OFFSET</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_MISC_FLAGS + 1 )
	/// </summary>
	DecoderbeginframeInvalidHistogramBufferOffset = DecoderbeginframeInvalidHistogramBufferMiscFlags + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TRACKEDWORKLOAD</b> = ( D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_OFFSET + 1 )
	/// </summary>
	CreateTrackedworkload = DecoderbeginframeInvalidHistogramBufferOffset + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_LIVE_TRACKEDWORKLOAD</b> = ( D3D11_MESSAGE_ID_CREATE_TRACKEDWORKLOAD + 1 )
	/// </summary>
	LiveTrackedworkload = CreateTrackedworkload + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD</b> = ( D3D11_MESSAGE_ID_LIVE_TRACKEDWORKLOAD + 1 )
	/// </summary>
	DestroyTrackedworkload = LiveTrackedworkload + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_NULLPARAM</b> = ( D3D11_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD + 1 )
	/// </summary>
	CreateTrackedWorkloadNullparam = DestroyTrackedworkload + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_MAX_INSTANCES</b> = ( D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_NULLPARAM + 1 )
	/// </summary>
	CreateTrackedWorkloadInvalidMaxInstances = CreateTrackedWorkloadNullparam + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_DEADLINE_TYPE</b> = ( D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_MAX_INSTANCES + 1 )
	/// </summary>
	CreateTrackedWorkloadInvalidDeadlineType = CreateTrackedWorkloadInvalidMaxInstances + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_ENGINE_TYPE</b> = ( D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_DEADLINE_TYPE + 1 )
	/// </summary>
	CreateTrackedWorkloadInvalidEngineType = CreateTrackedWorkloadInvalidDeadlineType + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS</b> = ( D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_ENGINE_TYPE + 1 )
	/// </summary>
	MultipleTrackedWorkloads = CreateTrackedWorkloadInvalidEngineType + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS</b> = ( D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS + 1 )
	/// </summary>
	MultipleTrackedWorkloadPairs = MultipleTrackedWorkloads + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR</b> = ( D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS + 1 )
	/// </summary>
	IncompleteTrackedWorkloadPair = MultipleTrackedWorkloadPairs + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR</b> = ( D3D11_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR + 1 )
	/// </summary>
	OutOfOrderTrackedWorkloadPair = IncompleteTrackedWorkloadPair + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD</b> = ( D3D11_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR + 1 )
	/// </summary>
	CannotAddTrackedWorkload = OutOfOrderTrackedWorkloadPair + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED</b> = ( D3D11_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD + 1 )
	/// </summary>
	TrackedWorkloadNotSupported = CannotAddTrackedWorkload + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TRACKED_WORKLOAD_ENGINE_TYPE_NOT_FOUND</b> = ( D3D11_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED + 1 )
	/// </summary>
	TrackedWorkloadEngineTypeNotFound = TrackedWorkloadNotSupported + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_NO_TRACKED_WORKLOAD_SLOT_AVAILABLE</b> = ( D3D11_MESSAGE_ID_TRACKED_WORKLOAD_ENGINE_TYPE_NOT_FOUND + 1 )
	/// </summary>
	NoTrackedWorkloadSlotAvailable = TrackedWorkloadEngineTypeNotFound + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_END_TRACKED_WORKLOAD_INVALID_ARG</b> = ( D3D11_MESSAGE_ID_NO_TRACKED_WORKLOAD_SLOT_AVAILABLE + 1 )
	/// </summary>
	EndTrackedWorkloadInvalidArg = NoTrackedWorkloadSlotAvailable + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_TRACKED_WORKLOAD_DISJOINT_FAILURE</b> = ( D3D11_MESSAGE_ID_END_TRACKED_WORKLOAD_INVALID_ARG + 1 )
	/// </summary>
	TrackedWorkloadDisjointFailure = EndTrackedWorkloadInvalidArg + 1,
	/// <summary>
	/// <b>D3D11_MESSAGE_ID_D3D11_5_MESSAGES_END</b> = ( D3D11_MESSAGE_ID_TRACKED_WORKLOAD_DISJOINT_FAILURE + 1 )
	/// </summary>
	D3d115MessagesEnd = TrackedWorkloadDisjointFailure + 1,
}

/// <summary>
/// ENUM <b>D3D11_SHADER_VERSION_TYPE</b><br/>
/// D3D11SHADER.h
/// </summary>
public enum ShaderVersionType : uint {
	/// <summary>
	/// <b>D3D11_SHVER_PIXEL_SHADER</b> = 0
	/// </summary>
	ShverPixelShader = 0,
	/// <summary>
	/// <b>D3D11_SHVER_VERTEX_SHADER</b> = 1
	/// </summary>
	ShverVertexShader = 1,
	/// <summary>
	/// <b>D3D11_SHVER_GEOMETRY_SHADER</b> = 2
	/// </summary>
	ShverGeometryShader = 2,
	/// <summary>
	/// <b>D3D11_SHVER_HULL_SHADER</b> = 3
	/// </summary>
	ShverHullShader = 3,
	/// <summary>
	/// <b>D3D11_SHVER_DOMAIN_SHADER</b> = 4
	/// </summary>
	ShverDomainShader = 4,
	/// <summary>
	/// <b>D3D11_SHVER_COMPUTE_SHADER</b> = 5
	/// </summary>
	ShverComputeShader = 5,
	/// <summary>
	/// <b>D3D11_SHVER_RESERVED0</b> = 0xFFF0
	/// </summary>
	ShverReserved0 = 65520,
}

/// <summary>
/// ENUM <b>D3D11_COPY_FLAGS</b><br/>
/// D3D11_1.h
/// </summary>
public enum CopyFlags : uint {
	/// <summary>
	/// <b>D3D11_COPY_NO_OVERWRITE</b> = 0x1
	/// </summary>
	NoOverwrite = 1,
	/// <summary>
	/// <b>D3D11_COPY_DISCARD</b> = 0x2
	/// </summary>
	Discard = 2,
}

/// <summary>
/// ENUM <b>D3D11_LOGIC_OP</b><br/>
/// D3D11_1.h
/// </summary>
public enum LogicOp : uint {
	/// <summary>
	/// <b>D3D11_LOGIC_OP_CLEAR</b> = 0
	/// </summary>
	Clear = 0,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_SET</b> = ( D3D11_LOGIC_OP_CLEAR + 1 )
	/// </summary>
	Set = Clear + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_COPY</b> = ( D3D11_LOGIC_OP_SET + 1 )
	/// </summary>
	Copy = Set + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_COPY_INVERTED</b> = ( D3D11_LOGIC_OP_COPY + 1 )
	/// </summary>
	CopyInverted = Copy + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_NOOP</b> = ( D3D11_LOGIC_OP_COPY_INVERTED + 1 )
	/// </summary>
	Noop = CopyInverted + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_INVERT</b> = ( D3D11_LOGIC_OP_NOOP + 1 )
	/// </summary>
	Invert = Noop + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_AND</b> = ( D3D11_LOGIC_OP_INVERT + 1 )
	/// </summary>
	And = Invert + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_NAND</b> = ( D3D11_LOGIC_OP_AND + 1 )
	/// </summary>
	Nand = And + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_OR</b> = ( D3D11_LOGIC_OP_NAND + 1 )
	/// </summary>
	Or = Nand + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_NOR</b> = ( D3D11_LOGIC_OP_OR + 1 )
	/// </summary>
	Nor = Or + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_XOR</b> = ( D3D11_LOGIC_OP_NOR + 1 )
	/// </summary>
	Xor = Nor + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_EQUIV</b> = ( D3D11_LOGIC_OP_XOR + 1 )
	/// </summary>
	Equiv = Xor + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_AND_REVERSE</b> = ( D3D11_LOGIC_OP_EQUIV + 1 )
	/// </summary>
	AndReverse = Equiv + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_AND_INVERTED</b> = ( D3D11_LOGIC_OP_AND_REVERSE + 1 )
	/// </summary>
	AndInverted = AndReverse + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_OR_REVERSE</b> = ( D3D11_LOGIC_OP_AND_INVERTED + 1 )
	/// </summary>
	OrReverse = AndInverted + 1,
	/// <summary>
	/// <b>D3D11_LOGIC_OP_OR_INVERTED</b> = ( D3D11_LOGIC_OP_OR_REVERSE + 1 )
	/// </summary>
	OrInverted = OrReverse + 1,
}

/// <summary>
/// ENUM <b>D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG</b><br/>
/// D3D11_1.h
/// </summary>
public enum _1CreateDeviceContextStateFlag : uint {
	/// <summary>
	/// <b>D3D11_1_CREATE_DEVICE_CONTEXT_STATE_SINGLETHREADED</b> = 0x1
	/// </summary>
	Singlethreaded = 1,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_DECODER_CAPS</b><br/>
/// D3D11_1.h
/// </summary>
[Flags]
public enum VideoDecoderCaps : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE</b> = 0x1
	/// </summary>
	Downsample = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME</b> = 0x2
	/// </summary>
	NonRealTime = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC</b> = 0x4
	/// </summary>
	DownsampleDynamic = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED</b> = 0x8
	/// </summary>
	DownsampleRequired = 8,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED</b> = 0x10
	/// </summary>
	Unsupported = 16,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS</b><br/>
/// D3D11_1.h
/// </summary>
[Flags]
public enum VideoProcessorBehaviorHints : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_ROTATION</b> = 0x1
	/// </summary>
	HintMultiplaneOverlayRotation = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_RESIZE</b> = 0x2
	/// </summary>
	HintMultiplaneOverlayResize = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_COLOR_SPACE_CONVERSION</b> = 0x4
	/// </summary>
	HintMultiplaneOverlayColorSpaceConversion = 4,
	/// <summary>
	/// <b>D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_TRIPLE_BUFFER_OUTPUT</b> = 0x8
	/// </summary>
	HintTripleBufferOutput = 8,
}

/// <summary>
/// ENUM <b>D3D11_CRYPTO_SESSION_STATUS</b><br/>
/// D3D11_1.h
/// </summary>
public enum CryptoSessionStatus : uint {
	/// <summary>
	/// <b>D3D11_CRYPTO_SESSION_STATUS_OK</b> = 0
	/// </summary>
	Ok = 0,
	/// <summary>
	/// <b>D3D11_CRYPTO_SESSION_STATUS_KEY_LOST</b> = 1
	/// </summary>
	KeyLost = 1,
	/// <summary>
	/// <b>D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST</b> = 2
	/// </summary>
	KeyAndContentLost = 2,
}

/// <summary>
/// ENUM <b>D3D11_TILE_MAPPING_FLAG</b><br/>
/// D3D11_2.h
/// </summary>
public enum TileMappingFlag : uint {
	/// <summary>
	/// <b>D3D11_TILE_MAPPING_NO_OVERWRITE</b> = 0x1
	/// </summary>
	NoOverwrite = 1,
}

/// <summary>
/// ENUM <b>D3D11_TILE_RANGE_FLAG</b><br/>
/// D3D11_2.h
/// </summary>
[Flags]
public enum TileRangeFlag : uint {
	/// <summary>
	/// <b>D3D11_TILE_RANGE_NULL</b> = 0x1
	/// </summary>
	Null = 1,
	/// <summary>
	/// <b>D3D11_TILE_RANGE_SKIP</b> = 0x2
	/// </summary>
	Skip = 2,
	/// <summary>
	/// <b>D3D11_TILE_RANGE_REUSE_SINGLE_TILE</b> = 0x4
	/// </summary>
	ReuseSingleTile = 4,
}

/// <summary>
/// ENUM <b>D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG</b><br/>
/// D3D11_2.h
/// </summary>
public enum CheckMultisampleQualityLevelsFlag : uint {
	/// <summary>
	/// <b>D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_TILED_RESOURCE</b> = 0x1
	/// </summary>
	TiledResource = 1,
}

/// <summary>
/// ENUM <b>D3D11_TILE_COPY_FLAG</b><br/>
/// D3D11_2.h
/// </summary>
[Flags]
public enum TileCopyFlag : uint {
	/// <summary>
	/// <b>D3D11_TILE_COPY_NO_OVERWRITE</b> = 0x1
	/// </summary>
	NoOverwrite = 1,
	/// <summary>
	/// <b>D3D11_TILE_COPY_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE</b> = 0x2
	/// </summary>
	LinearBufferToSwizzledTiledResource = 2,
	/// <summary>
	/// <b>D3D11_TILE_COPY_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER</b> = 0x4
	/// </summary>
	SwizzledTiledResourceToLinearBuffer = 4,
}

/// <summary>
/// ENUM <b>D3D11_CONTEXT_TYPE</b><br/>
/// D3D11_3.h
/// </summary>
public enum ContextType : uint {
	/// <summary>
	/// <b>D3D11_CONTEXT_TYPE_ALL</b> = 0
	/// </summary>
	All = 0,
	/// <summary>
	/// <b>D3D11_CONTEXT_TYPE_3D</b> = 1
	/// </summary>
	Type3D = 1,
	/// <summary>
	/// <b>D3D11_CONTEXT_TYPE_COMPUTE</b> = 2
	/// </summary>
	Compute = 2,
	/// <summary>
	/// <b>D3D11_CONTEXT_TYPE_COPY</b> = 3
	/// </summary>
	Copy = 3,
	/// <summary>
	/// <b>D3D11_CONTEXT_TYPE_VIDEO</b> = 4
	/// </summary>
	Video = 4,
}

/// <summary>
/// ENUM <b>D3D11_TEXTURE_LAYOUT</b><br/>
/// D3D11_3.h
/// </summary>
public enum TextureLayout : uint {
	/// <summary>
	/// <b>D3D11_TEXTURE_LAYOUT_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D11_TEXTURE_LAYOUT_ROW_MAJOR</b> = 1
	/// </summary>
	RowMajor = 1,
	/// <summary>
	/// <b>D3D11_TEXTURE_LAYOUT_64K_STANDARD_SWIZZLE</b> = 2
	/// </summary>
	Layout64KStandardSwizzle = 2,
}

/// <summary>
/// ENUM <b>D3D11_CONSERVATIVE_RASTERIZATION_MODE</b><br/>
/// D3D11_3.h
/// </summary>
public enum ConservativeRasterizationMode : uint {
	/// <summary>
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_MODE_OFF</b> = 0
	/// </summary>
	Off = 0,
	/// <summary>
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_MODE_ON</b> = 1
	/// </summary>
	On = 1,
}

/// <summary>
/// ENUM <b>D3D11_FENCE_FLAG</b><br/>
/// D3D11_3.h
/// </summary>
[Flags]
public enum FenceFlag : uint {
	/// <summary>
	/// <b>D3D11_FENCE_FLAG_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D11_FENCE_FLAG_SHARED</b> = 0x2
	/// </summary>
	Shared = 2,
	/// <summary>
	/// <b>D3D11_FENCE_FLAG_SHARED_CROSS_ADAPTER</b> = 0x4
	/// </summary>
	SharedCrossAdapter = 4,
	/// <summary>
	/// <b>D3D11_FENCE_FLAG_NON_MONITORED</b> = 0x8
	/// </summary>
	NonMonitored = 8,
}

/// <summary>
/// ENUM <b>D3D11_FEATURE_VIDEO</b><br/>
/// D3D11_4.h
/// </summary>
public enum FeatureVideo : uint {
	/// <summary>
	/// <b>D3D11_FEATURE_VIDEO_DECODER_HISTOGRAM</b> = 0
	/// </summary>
	DecoderHistogram = 0,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT</b><br/>
/// D3D11_4.h
/// </summary>
public enum VideoDecoderHistogramComponent : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_Y</b> = 0
	/// </summary>
	Y = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_U</b> = 1
	/// </summary>
	U = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_V</b> = 2
	/// </summary>
	V = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_R</b> = 0
	/// </summary>
	R = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_G</b> = 1
	/// </summary>
	G = 1,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_B</b> = 2
	/// </summary>
	B = 2,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_A</b> = 3
	/// </summary>
	A = 3,
}

/// <summary>
/// ENUM <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS</b><br/>
/// D3D11_4.h
/// </summary>
[Flags]
public enum VideoDecoderHistogramComponentFlags : uint {
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_Y</b> = ( 1 &lt;&lt; D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_Y )
	/// </summary>
	FlagY = 1 << (int) VideoDecoderHistogramComponent.Y,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_U</b> = ( 1 &lt;&lt; D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_U )
	/// </summary>
	FlagU = 1 << (int) VideoDecoderHistogramComponent.U,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_V</b> = ( 1 &lt;&lt; D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_V )
	/// </summary>
	FlagV = 1 << (int) VideoDecoderHistogramComponent.V,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_R</b> = ( 1 &lt;&lt; D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_R )
	/// </summary>
	FlagR = 1 << (int) VideoDecoderHistogramComponent.R,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_G</b> = ( 1 &lt;&lt; D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_G )
	/// </summary>
	FlagG = 1 << (int) VideoDecoderHistogramComponent.G,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_B</b> = ( 1 &lt;&lt; D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_B )
	/// </summary>
	FlagB = 1 << (int) VideoDecoderHistogramComponent.B,
	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_A</b> = ( 1 &lt;&lt; D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_A )
	/// </summary>
	FlagA = 1 << (int) VideoDecoderHistogramComponent.A,
}

/// <summary>
/// ENUM <b>D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS</b><br/>
/// D3D11_4.h
/// </summary>
public enum CryptoSessionKeyExchangeFlags : uint {
	/// <summary>
	/// <b>D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}
