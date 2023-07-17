using System;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// ENUM <b>D3D12_COMMAND_LIST_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum CommandListType : uint {
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE_DIRECT</b> = 0
	/// </summary>
	Direct = 0,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE_BUNDLE</b> = 1
	/// </summary>
	Bundle = 1,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE_COMPUTE</b> = 2
	/// </summary>
	Compute = 2,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE_COPY</b> = 3
	/// </summary>
	Copy = 3,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE</b> = 4
	/// </summary>
	VideoDecode = 4,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS</b> = 5
	/// </summary>
	VideoProcess = 5,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE</b> = 6
	/// </summary>
	VideoEncode = 6,
}

/// <summary>
/// ENUM <b>D3D12_COMMAND_QUEUE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum CommandQueueFlags : uint {
	/// <summary>
	/// <b>D3D12_COMMAND_QUEUE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_COMMAND_QUEUE_FLAG_DISABLE_GPU_TIMEOUT</b> = 0x1
	/// </summary>
	FlagDisableGpuTimeout = 1,
}

/// <summary>
/// ENUM <b>D3D12_COMMAND_QUEUE_PRIORITY</b><br/>
/// D3D12.h
/// </summary>
public enum CommandQueuePriority : uint {
	/// <summary>
	/// <b>D3D12_COMMAND_QUEUE_PRIORITY_NORMAL</b> = 0
	/// </summary>
	Normal = 0,
	/// <summary>
	/// <b>D3D12_COMMAND_QUEUE_PRIORITY_HIGH</b> = 100
	/// </summary>
	High = 100,
	/// <summary>
	/// <b>D3D12_COMMAND_QUEUE_PRIORITY_GLOBAL_REALTIME</b> = 10000
	/// </summary>
	GlobalRealtime = 10000,
}

/// <summary>
/// ENUM <b>D3D12_PRIMITIVE_TOPOLOGY_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum PrimitiveTopologyType : uint {
	/// <summary>
	/// <b>D3D12_PRIMITIVE_TOPOLOGY_TYPE_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D12_PRIMITIVE_TOPOLOGY_TYPE_POINT</b> = 1
	/// </summary>
	Point = 1,
	/// <summary>
	/// <b>D3D12_PRIMITIVE_TOPOLOGY_TYPE_LINE</b> = 2
	/// </summary>
	Line = 2,
	/// <summary>
	/// <b>D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE</b> = 3
	/// </summary>
	Triangle = 3,
	/// <summary>
	/// <b>D3D12_PRIMITIVE_TOPOLOGY_TYPE_PATCH</b> = 4
	/// </summary>
	Patch = 4,
}

/// <summary>
/// ENUM <b>D3D12_INPUT_CLASSIFICATION</b><br/>
/// D3D12.h
/// </summary>
public enum InputClassification : uint {
	/// <summary>
	/// <b>D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA</b> = 0
	/// </summary>
	PerVertexData = 0,
	/// <summary>
	/// <b>D3D12_INPUT_CLASSIFICATION_PER_INSTANCE_DATA</b> = 1
	/// </summary>
	PerInstanceData = 1,
}

/// <summary>
/// ENUM <b>D3D12_FILL_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum FillMode : uint {
	/// <summary>
	/// <b>D3D12_FILL_MODE_WIREFRAME</b> = 2
	/// </summary>
	Wireframe = 2,
	/// <summary>
	/// <b>D3D12_FILL_MODE_SOLID</b> = 3
	/// </summary>
	Solid = 3,
}

/// <summary>
/// ENUM <b>D3D12_CULL_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum CullMode : uint {
	/// <summary>
	/// <b>D3D12_CULL_MODE_NONE</b> = 1
	/// </summary>
	None = 1,
	/// <summary>
	/// <b>D3D12_CULL_MODE_FRONT</b> = 2
	/// </summary>
	Front = 2,
	/// <summary>
	/// <b>D3D12_CULL_MODE_BACK</b> = 3
	/// </summary>
	Back = 3,
}

/// <summary>
/// ENUM <b>D3D12_COMPARISON_FUNC</b><br/>
/// D3D12.h
/// </summary>
public enum ComparisonFunc : uint {
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_NEVER</b> = 1
	/// </summary>
	Never = 1,
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_LESS</b> = 2
	/// </summary>
	Less = 2,
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_EQUAL</b> = 3
	/// </summary>
	Equal = 3,
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_LESS_EQUAL</b> = 4
	/// </summary>
	LessEqual = 4,
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_GREATER</b> = 5
	/// </summary>
	Greater = 5,
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_NOT_EQUAL</b> = 6
	/// </summary>
	NotEqual = 6,
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_GREATER_EQUAL</b> = 7
	/// </summary>
	GreaterEqual = 7,
	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC_ALWAYS</b> = 8
	/// </summary>
	Always = 8,
}

/// <summary>
/// ENUM <b>D3D12_DEPTH_WRITE_MASK</b><br/>
/// D3D12.h
/// </summary>
public enum DepthWriteMask : uint {
	/// <summary>
	/// <b>D3D12_DEPTH_WRITE_MASK_ZERO</b> = 0
	/// </summary>
	Zero = 0,
	/// <summary>
	/// <b>D3D12_DEPTH_WRITE_MASK_ALL</b> = 1
	/// </summary>
	All = 1,
}

/// <summary>
/// ENUM <b>D3D12_STENCIL_OP</b><br/>
/// D3D12.h
/// </summary>
public enum StencilOp : uint {
	/// <summary>
	/// <b>D3D12_STENCIL_OP_KEEP</b> = 1
	/// </summary>
	Keep = 1,
	/// <summary>
	/// <b>D3D12_STENCIL_OP_ZERO</b> = 2
	/// </summary>
	Zero = 2,
	/// <summary>
	/// <b>D3D12_STENCIL_OP_REPLACE</b> = 3
	/// </summary>
	Replace = 3,
	/// <summary>
	/// <b>D3D12_STENCIL_OP_INCR_SAT</b> = 4
	/// </summary>
	IncrSat = 4,
	/// <summary>
	/// <b>D3D12_STENCIL_OP_DECR_SAT</b> = 5
	/// </summary>
	DecrSat = 5,
	/// <summary>
	/// <b>D3D12_STENCIL_OP_INVERT</b> = 6
	/// </summary>
	Invert = 6,
	/// <summary>
	/// <b>D3D12_STENCIL_OP_INCR</b> = 7
	/// </summary>
	Incr = 7,
	/// <summary>
	/// <b>D3D12_STENCIL_OP_DECR</b> = 8
	/// </summary>
	Decr = 8,
}

/// <summary>
/// ENUM <b>D3D12_BLEND</b><br/>
/// D3D12.h
/// </summary>
public enum Blend : uint {
	/// <summary>
	/// <b>D3D12_BLEND_ZERO</b> = 1
	/// </summary>
	Zero = 1,
	/// <summary>
	/// <b>D3D12_BLEND_ONE</b> = 2
	/// </summary>
	One = 2,
	/// <summary>
	/// <b>D3D12_BLEND_SRC_COLOR</b> = 3
	/// </summary>
	SrcColor = 3,
	/// <summary>
	/// <b>D3D12_BLEND_INV_SRC_COLOR</b> = 4
	/// </summary>
	InvSrcColor = 4,
	/// <summary>
	/// <b>D3D12_BLEND_SRC_ALPHA</b> = 5
	/// </summary>
	SrcAlpha = 5,
	/// <summary>
	/// <b>D3D12_BLEND_INV_SRC_ALPHA</b> = 6
	/// </summary>
	InvSrcAlpha = 6,
	/// <summary>
	/// <b>D3D12_BLEND_DEST_ALPHA</b> = 7
	/// </summary>
	DestAlpha = 7,
	/// <summary>
	/// <b>D3D12_BLEND_INV_DEST_ALPHA</b> = 8
	/// </summary>
	InvDestAlpha = 8,
	/// <summary>
	/// <b>D3D12_BLEND_DEST_COLOR</b> = 9
	/// </summary>
	DestColor = 9,
	/// <summary>
	/// <b>D3D12_BLEND_INV_DEST_COLOR</b> = 10
	/// </summary>
	InvDestColor = 10,
	/// <summary>
	/// <b>D3D12_BLEND_SRC_ALPHA_SAT</b> = 11
	/// </summary>
	SrcAlphaSat = 11,
	/// <summary>
	/// <b>D3D12_BLEND_BLEND_FACTOR</b> = 14
	/// </summary>
	BlendFactor = 14,
	/// <summary>
	/// <b>D3D12_BLEND_INV_BLEND_FACTOR</b> = 15
	/// </summary>
	InvBlendFactor = 15,
	/// <summary>
	/// <b>D3D12_BLEND_SRC1_COLOR</b> = 16
	/// </summary>
	Src1Color = 16,
	/// <summary>
	/// <b>D3D12_BLEND_INV_SRC1_COLOR</b> = 17
	/// </summary>
	InvSrc1Color = 17,
	/// <summary>
	/// <b>D3D12_BLEND_SRC1_ALPHA</b> = 18
	/// </summary>
	Src1Alpha = 18,
	/// <summary>
	/// <b>D3D12_BLEND_INV_SRC1_ALPHA</b> = 19
	/// </summary>
	InvSrc1Alpha = 19,
	/// <summary>
	/// <b>D3D12_BLEND_ALPHA_FACTOR</b> = 20
	/// </summary>
	AlphaFactor = 20,
	/// <summary>
	/// <b>D3D12_BLEND_INV_ALPHA_FACTOR</b> = 21
	/// </summary>
	InvAlphaFactor = 21,
}

/// <summary>
/// ENUM <b>D3D12_BLEND_OP</b><br/>
/// D3D12.h
/// </summary>
public enum BlendOp : uint {
	/// <summary>
	/// <b>D3D12_BLEND_OP_ADD</b> = 1
	/// </summary>
	Add = 1,
	/// <summary>
	/// <b>D3D12_BLEND_OP_SUBTRACT</b> = 2
	/// </summary>
	Subtract = 2,
	/// <summary>
	/// <b>D3D12_BLEND_OP_REV_SUBTRACT</b> = 3
	/// </summary>
	RevSubtract = 3,
	/// <summary>
	/// <b>D3D12_BLEND_OP_MIN</b> = 4
	/// </summary>
	Min = 4,
	/// <summary>
	/// <b>D3D12_BLEND_OP_MAX</b> = 5
	/// </summary>
	Max = 5,
}

/// <summary>
/// ENUM <b>D3D12_COLOR_WRITE_ENABLE</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ColorWriteEnable : uint {
	/// <summary>
	/// <b>D3D12_COLOR_WRITE_ENABLE_RED</b> = 1
	/// </summary>
	Red = 1,
	/// <summary>
	/// <b>D3D12_COLOR_WRITE_ENABLE_GREEN</b> = 2
	/// </summary>
	Green = 2,
	/// <summary>
	/// <b>D3D12_COLOR_WRITE_ENABLE_BLUE</b> = 4
	/// </summary>
	Blue = 4,
	/// <summary>
	/// <b>D3D12_COLOR_WRITE_ENABLE_ALPHA</b> = 8
	/// </summary>
	Alpha = 8,
	/// <summary>
	/// <b>D3D12_COLOR_WRITE_ENABLE_ALL</b> = ( ( ( D3D12_COLOR_WRITE_ENABLE_RED | D3D12_COLOR_WRITE_ENABLE_GREEN )  | D3D12_COLOR_WRITE_ENABLE_BLUE )  | D3D12_COLOR_WRITE_ENABLE_ALPHA )
	/// </summary>
	All = Red | Green | Blue | Alpha,
}

/// <summary>
/// ENUM <b>D3D12_LOGIC_OP</b><br/>
/// D3D12.h
/// </summary>
public enum LogicOp : uint {
	/// <summary>
	/// <b>D3D12_LOGIC_OP_CLEAR</b> = 0
	/// </summary>
	Clear = 0,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_SET</b> = ( D3D12_LOGIC_OP_CLEAR + 1 )
	/// </summary>
	Set = Clear + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_COPY</b> = ( D3D12_LOGIC_OP_SET + 1 )
	/// </summary>
	Copy = Set + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_COPY_INVERTED</b> = ( D3D12_LOGIC_OP_COPY + 1 )
	/// </summary>
	CopyInverted = Copy + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_NOOP</b> = ( D3D12_LOGIC_OP_COPY_INVERTED + 1 )
	/// </summary>
	Noop = CopyInverted + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_INVERT</b> = ( D3D12_LOGIC_OP_NOOP + 1 )
	/// </summary>
	Invert = Noop + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_AND</b> = ( D3D12_LOGIC_OP_INVERT + 1 )
	/// </summary>
	And = Invert + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_NAND</b> = ( D3D12_LOGIC_OP_AND + 1 )
	/// </summary>
	Nand = And + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_OR</b> = ( D3D12_LOGIC_OP_NAND + 1 )
	/// </summary>
	Or = Nand + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_NOR</b> = ( D3D12_LOGIC_OP_OR + 1 )
	/// </summary>
	Nor = Or + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_XOR</b> = ( D3D12_LOGIC_OP_NOR + 1 )
	/// </summary>
	Xor = Nor + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_EQUIV</b> = ( D3D12_LOGIC_OP_XOR + 1 )
	/// </summary>
	Equiv = Xor + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_AND_REVERSE</b> = ( D3D12_LOGIC_OP_EQUIV + 1 )
	/// </summary>
	AndReverse = Equiv + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_AND_INVERTED</b> = ( D3D12_LOGIC_OP_AND_REVERSE + 1 )
	/// </summary>
	AndInverted = AndReverse + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_OR_REVERSE</b> = ( D3D12_LOGIC_OP_AND_INVERTED + 1 )
	/// </summary>
	OrReverse = AndInverted + 1,
	/// <summary>
	/// <b>D3D12_LOGIC_OP_OR_INVERTED</b> = ( D3D12_LOGIC_OP_OR_REVERSE + 1 )
	/// </summary>
	OrInverted = OrReverse + 1,
}

/// <summary>
/// ENUM <b>D3D12_CONSERVATIVE_RASTERIZATION_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum ConservativeRasterizationMode : uint {
	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_MODE_OFF</b> = 0
	/// </summary>
	Off = 0,
	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_MODE_ON</b> = 1
	/// </summary>
	On = 1,
}

/// <summary>
/// ENUM <b>D3D12_INDEX_BUFFER_STRIP_CUT_VALUE</b><br/>
/// D3D12.h
/// </summary>
public enum IndexBufferStripCutValue : uint {
	/// <summary>
	/// <b>D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED</b> = 0
	/// </summary>
	Disabled = 0,
	/// <summary>
	/// <b>D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF</b> = 1
	/// </summary>
	Value0xFFFF = 1,
	/// <summary>
	/// <b>D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF</b> = 2
	/// </summary>
	Value0xFFFFFFFF = 2,
}

/// <summary>
/// ENUM <b>D3D12_PIPELINE_STATE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum PipelineStateFlags : uint {
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG</b> = 0x1
	/// </summary>
	FlagToolDebug = 1,
}

/// <summary>
/// ENUM <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum PipelineStateSubobjectType : uint {
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE</b> = 0
	/// </summary>
	RootSignature = 0,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE + 1 )
	/// </summary>
	Vs = RootSignature + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS + 1 )
	/// </summary>
	Ps = Vs + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS + 1 )
	/// </summary>
	Ds = Ps + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS + 1 )
	/// </summary>
	Hs = Ds + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS + 1 )
	/// </summary>
	Gs = Hs + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS + 1 )
	/// </summary>
	Cs = Gs + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS + 1 )
	/// </summary>
	StreamOutput = Cs + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT + 1 )
	/// </summary>
	Blend = StreamOutput + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND + 1 )
	/// </summary>
	SampleMask = Blend + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK + 1 )
	/// </summary>
	Rasterizer = SampleMask + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER + 1 )
	/// </summary>
	DepthStencil = Rasterizer + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL + 1 )
	/// </summary>
	InputLayout = DepthStencil + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT + 1 )
	/// </summary>
	IbStripCutValue = InputLayout + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE + 1 )
	/// </summary>
	PrimitiveTopology = IbStripCutValue + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY + 1 )
	/// </summary>
	RenderTargetFormats = PrimitiveTopology + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS + 1 )
	/// </summary>
	DepthStencilFormat = RenderTargetFormats + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT + 1 )
	/// </summary>
	SampleDesc = DepthStencilFormat + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC + 1 )
	/// </summary>
	NodeMask = SampleDesc + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK + 1 )
	/// </summary>
	CachedPso = NodeMask + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO + 1 )
	/// </summary>
	Flags = CachedPso + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS + 1 )
	/// </summary>
	DepthStencil1 = Flags + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1 + 1 )
	/// </summary>
	ViewInstancing = DepthStencil1 + 1,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS</b> = 24
	/// </summary>
	As = 24,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS</b> = 25
	/// </summary>
	Ms = 25,
	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID</b> = ( D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS + 1 )
	/// </summary>
	MaxValid = Ms + 1,
}

/// <summary>
/// ENUM <b>D3D12_FEATURE</b><br/>
/// D3D12.h
/// </summary>
public enum Feature : uint {
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS</b> = 0
	/// </summary>
	D3d12Options = 0,
	/// <summary>
	/// <b>D3D12_FEATURE_ARCHITECTURE</b> = 1
	/// </summary>
	Architecture = 1,
	/// <summary>
	/// <b>D3D12_FEATURE_FEATURE_LEVELS</b> = 2
	/// </summary>
	FeatureLevels = 2,
	/// <summary>
	/// <b>D3D12_FEATURE_FORMAT_SUPPORT</b> = 3
	/// </summary>
	FormatSupport = 3,
	/// <summary>
	/// <b>D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS</b> = 4
	/// </summary>
	MultisampleQualityLevels = 4,
	/// <summary>
	/// <b>D3D12_FEATURE_FORMAT_INFO</b> = 5
	/// </summary>
	FormatInfo = 5,
	/// <summary>
	/// <b>D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT</b> = 6
	/// </summary>
	GpuVirtualAddressSupport = 6,
	/// <summary>
	/// <b>D3D12_FEATURE_SHADER_MODEL</b> = 7
	/// </summary>
	ShaderModel = 7,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS1</b> = 8
	/// </summary>
	D3d12Options1 = 8,
	/// <summary>
	/// <b>D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT</b> = 10
	/// </summary>
	ProtectedResourceSessionSupport = 10,
	/// <summary>
	/// <b>D3D12_FEATURE_ROOT_SIGNATURE</b> = 12
	/// </summary>
	RootSignature = 12,
	/// <summary>
	/// <b>D3D12_FEATURE_ARCHITECTURE1</b> = 16
	/// </summary>
	Architecture1 = 16,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS2</b> = 18
	/// </summary>
	D3d12Options2 = 18,
	/// <summary>
	/// <b>D3D12_FEATURE_SHADER_CACHE</b> = 19
	/// </summary>
	ShaderCache = 19,
	/// <summary>
	/// <b>D3D12_FEATURE_COMMAND_QUEUE_PRIORITY</b> = 20
	/// </summary>
	CommandQueuePriority = 20,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS3</b> = 21
	/// </summary>
	D3d12Options3 = 21,
	/// <summary>
	/// <b>D3D12_FEATURE_EXISTING_HEAPS</b> = 22
	/// </summary>
	ExistingHeaps = 22,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS4</b> = 23
	/// </summary>
	D3d12Options4 = 23,
	/// <summary>
	/// <b>D3D12_FEATURE_SERIALIZATION</b> = 24
	/// </summary>
	Serialization = 24,
	/// <summary>
	/// <b>D3D12_FEATURE_CROSS_NODE</b> = 25
	/// </summary>
	CrossNode = 25,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS5</b> = 27
	/// </summary>
	D3d12Options5 = 27,
	/// <summary>
	/// <b>D3D12_FEATURE_DISPLAYABLE</b> = 28
	/// </summary>
	Displayable = 28,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS6</b> = 30
	/// </summary>
	D3d12Options6 = 30,
	/// <summary>
	/// <b>D3D12_FEATURE_QUERY_META_COMMAND</b> = 31
	/// </summary>
	QueryMetaCommand = 31,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS7</b> = 32
	/// </summary>
	D3d12Options7 = 32,
	/// <summary>
	/// <b>D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT</b> = 33
	/// </summary>
	ProtectedResourceSessionTypeCount = 33,
	/// <summary>
	/// <b>D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES</b> = 34
	/// </summary>
	ProtectedResourceSessionTypes = 34,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS8</b> = 36
	/// </summary>
	D3d12Options8 = 36,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS9</b> = 37
	/// </summary>
	D3d12Options9 = 37,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS10</b> = 39
	/// </summary>
	D3d12Options10 = 39,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS11</b> = 40
	/// </summary>
	D3d12Options11 = 40,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS12</b> = 41
	/// </summary>
	D3d12Options12 = 41,
	/// <summary>
	/// <b>D3D12_FEATURE_D3D12_OPTIONS13</b> = 42
	/// </summary>
	D3d12Options13 = 42,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_MIN_PRECISION_SUPPORT</b><br/>
/// D3D12.h
/// </summary>
public enum ShaderMinPrecisionSupport : uint {
	/// <summary>
	/// <b>D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT</b> = 0x1
	/// </summary>
	Support10Bit = 1,
	/// <summary>
	/// <b>D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT</b> = 0x2
	/// </summary>
	Support16Bit = 2,
}

/// <summary>
/// ENUM <b>D3D12_TILED_RESOURCES_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum TiledResourcesTier : uint {
	/// <summary>
	/// <b>D3D12_TILED_RESOURCES_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_TILED_RESOURCES_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_TILED_RESOURCES_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
	/// <summary>
	/// <b>D3D12_TILED_RESOURCES_TIER_3</b> = 3
	/// </summary>
	Tier3 = 3,
	/// <summary>
	/// <b>D3D12_TILED_RESOURCES_TIER_4</b> = 4
	/// </summary>
	Tier4 = 4,
}

/// <summary>
/// ENUM <b>D3D12_RESOURCE_BINDING_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum ResourceBindingTier : uint {
	/// <summary>
	/// <b>D3D12_RESOURCE_BINDING_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_RESOURCE_BINDING_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
	/// <summary>
	/// <b>D3D12_RESOURCE_BINDING_TIER_3</b> = 3
	/// </summary>
	Tier3 = 3,
}

/// <summary>
/// ENUM <b>D3D12_CONSERVATIVE_RASTERIZATION_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum ConservativeRasterizationTier : uint {
	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_TIER_3</b> = 3
	/// </summary>
	Tier3 = 3,
}

/// <summary>
/// ENUM <b>D3D12_FORMAT_SUPPORT1</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum FormatSupport1 : uint {
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_BUFFER</b> = 0x1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER</b> = 0x2
	/// </summary>
	IaVertexBuffer = 2,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER</b> = 0x4
	/// </summary>
	IaIndexBuffer = 4,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_SO_BUFFER</b> = 0x8
	/// </summary>
	SoBuffer = 8,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_TEXTURE1D</b> = 0x10
	/// </summary>
	Texture1d = 16,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_TEXTURE2D</b> = 0x20
	/// </summary>
	Texture2d = 32,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_TEXTURE3D</b> = 0x40
	/// </summary>
	Texture3d = 64,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_TEXTURECUBE</b> = 0x80
	/// </summary>
	Texturecube = 128,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_SHADER_LOAD</b> = 0x100
	/// </summary>
	ShaderLoad = 256,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE</b> = 0x200
	/// </summary>
	ShaderSample = 512,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON</b> = 0x400
	/// </summary>
	ShaderSampleComparison = 1024,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT</b> = 0x800
	/// </summary>
	ShaderSampleMonoText = 2048,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_MIP</b> = 0x1000
	/// </summary>
	Mip = 4096,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_RENDER_TARGET</b> = 0x4000
	/// </summary>
	RenderTarget = 16384,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_BLENDABLE</b> = 0x8000
	/// </summary>
	Blendable = 32768,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL</b> = 0x10000
	/// </summary>
	DepthStencil = 65536,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE</b> = 0x40000
	/// </summary>
	MultisampleResolve = 262144,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_DISPLAY</b> = 0x80000
	/// </summary>
	Display = 524288,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT</b> = 0x100000
	/// </summary>
	CastWithinBitLayout = 1048576,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET</b> = 0x200000
	/// </summary>
	MultisampleRendertarget = 2097152,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD</b> = 0x400000
	/// </summary>
	MultisampleLoad = 4194304,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_SHADER_GATHER</b> = 0x800000
	/// </summary>
	ShaderGather = 8388608,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST</b> = 0x1000000
	/// </summary>
	BackBufferCast = 16777216,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW</b> = 0x2000000
	/// </summary>
	TypedUnorderedAccessView = 33554432,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON</b> = 0x4000000
	/// </summary>
	ShaderGatherComparison = 67108864,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT</b> = 0x8000000
	/// </summary>
	DecoderOutput = 134217728,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT</b> = 0x10000000
	/// </summary>
	VideoProcessorOutput = 268435456,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT</b> = 0x20000000
	/// </summary>
	VideoProcessorInput = 536870912,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER</b> = 0x40000000
	/// </summary>
	VideoEncoder = 1073741824,
}

/// <summary>
/// ENUM <b>D3D12_FORMAT_SUPPORT2</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum FormatSupport2 : uint {
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_ADD</b> = 0x1
	/// </summary>
	UavAtomicAdd = 1,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS</b> = 0x2
	/// </summary>
	UavAtomicBitwiseOps = 2,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE</b> = 0x4
	/// </summary>
	UavAtomicCompareStoreOrCompareExchange = 4,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE</b> = 0x8
	/// </summary>
	UavAtomicExchange = 8,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX</b> = 0x10
	/// </summary>
	UavAtomicSignedMinOrMax = 16,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX</b> = 0x20
	/// </summary>
	UavAtomicUnsignedMinOrMax = 32,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_TYPED_LOAD</b> = 0x40
	/// </summary>
	UavTypedLoad = 64,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_UAV_TYPED_STORE</b> = 0x80
	/// </summary>
	UavTypedStore = 128,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP</b> = 0x100
	/// </summary>
	OutputMergerLogicOp = 256,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_TILED</b> = 0x200
	/// </summary>
	Tiled = 512,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY</b> = 0x4000
	/// </summary>
	MultiplaneOverlay = 16384,
	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2_SAMPLER_FEEDBACK</b> = 0x8000
	/// </summary>
	SamplerFeedback = 32768,
}

/// <summary>
/// ENUM <b>D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum MultisampleQualityLevelFlags : uint {
	/// <summary>
	/// <b>D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_NONE</b> = 0
	/// </summary>
	SFlagNone = 0,
	/// <summary>
	/// <b>D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_TILED_RESOURCE</b> = 0x1
	/// </summary>
	SFlagTiledResource = 1,
}

/// <summary>
/// ENUM <b>D3D12_CROSS_NODE_SHARING_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum CrossNodeSharingTier : uint {
	/// <summary>
	/// <b>D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_CROSS_NODE_SHARING_TIER_1_EMULATED</b> = 1
	/// </summary>
	Tier1Emulated = 1,
	/// <summary>
	/// <b>D3D12_CROSS_NODE_SHARING_TIER_1</b> = 2
	/// </summary>
	Tier1 = 2,
	/// <summary>
	/// <b>D3D12_CROSS_NODE_SHARING_TIER_2</b> = 3
	/// </summary>
	Tier2 = 3,
	/// <summary>
	/// <b>D3D12_CROSS_NODE_SHARING_TIER_3</b> = 4
	/// </summary>
	Tier3 = 4,
}

/// <summary>
/// ENUM <b>D3D12_RESOURCE_HEAP_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum ResourceHeapTier : uint {
	/// <summary>
	/// <b>D3D12_RESOURCE_HEAP_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_RESOURCE_HEAP_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
}

/// <summary>
/// ENUM <b>D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum ProgrammableSamplePositionsTier : uint {
	/// <summary>
	/// <b>D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
}

/// <summary>
/// ENUM <b>D3D12_VIEW_INSTANCING_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum ViewInstancingTier : uint {
	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_TIER_3</b> = 3
	/// </summary>
	Tier3 = 3,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_CACHE_SUPPORT_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ShaderCacheSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_SINGLE_PSO</b> = 0x1
	/// </summary>
	SinglePso = 1,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_LIBRARY</b> = 0x2
	/// </summary>
	Library = 2,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE</b> = 0x4
	/// </summary>
	AutomaticInprocCache = 4,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE</b> = 0x8
	/// </summary>
	AutomaticDiskCache = 8,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_DRIVER_MANAGED_CACHE</b> = 0x10
	/// </summary>
	DriverManagedCache = 16,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_SHADER_CONTROL_CLEAR</b> = 0x20
	/// </summary>
	ShaderControlClear = 32,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_SHADER_SESSION_DELETE</b> = 0x40
	/// </summary>
	ShaderSessionDelete = 64,
}

/// <summary>
/// ENUM <b>D3D12_COMMAND_LIST_SUPPORT_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum CommandListSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_DIRECT</b> = ( 1 &lt;&lt; D3D12_COMMAND_LIST_TYPE_DIRECT )
	/// </summary>
	FlagDirect = 1 << (int) CommandListType.Direct,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_BUNDLE</b> = ( 1 &lt;&lt; D3D12_COMMAND_LIST_TYPE_BUNDLE )
	/// </summary>
	FlagBundle = 1 << (int) CommandListType.Bundle,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_COMPUTE</b> = ( 1 &lt;&lt; D3D12_COMMAND_LIST_TYPE_COMPUTE )
	/// </summary>
	FlagCompute = 1 << (int) CommandListType.Compute,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_COPY</b> = ( 1 &lt;&lt; D3D12_COMMAND_LIST_TYPE_COPY )
	/// </summary>
	FlagCopy = 1 << (int) CommandListType.Copy,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_DECODE</b> = ( 1 &lt;&lt; D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE )
	/// </summary>
	FlagVideoDecode = 1 << (int) CommandListType.VideoDecode,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_PROCESS</b> = ( 1 &lt;&lt; D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS )
	/// </summary>
	FlagVideoProcess = 1 << (int) CommandListType.VideoProcess,
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_ENCODE</b> = ( 1 &lt;&lt; D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE )
	/// </summary>
	FlagVideoEncode = 1 << (int) CommandListType.VideoEncode,
}

/// <summary>
/// ENUM <b>D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum SharedResourceCompatibilityTier : uint {
	/// <summary>
	/// <b>D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0</b> = 0
	/// </summary>
	Tier0 = 0,
	/// <summary>
	/// <b>D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1</b> = ( D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0 + 1 )
	/// </summary>
	Tier1 = Tier0 + 1,
	/// <summary>
	/// <b>D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_2</b> = ( D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1 + 1 )
	/// </summary>
	Tier2 = Tier1 + 1,
}

/// <summary>
/// ENUM <b>D3D12_HEAP_SERIALIZATION_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum HeapSerializationTier : uint {
	/// <summary>
	/// <b>D3D12_HEAP_SERIALIZATION_TIER_0</b> = 0
	/// </summary>
	Tier0 = 0,
	/// <summary>
	/// <b>D3D12_HEAP_SERIALIZATION_TIER_10</b> = 10
	/// </summary>
	Tier10 = 10,
}

/// <summary>
/// ENUM <b>D3D12_RENDER_PASS_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum RenderPassTier : uint {
	/// <summary>
	/// <b>D3D12_RENDER_PASS_TIER_0</b> = 0
	/// </summary>
	Tier0 = 0,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum RaytracingTier : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_TIER_1_0</b> = 10
	/// </summary>
	Tier10 = 10,
	/// <summary>
	/// <b>D3D12_RAYTRACING_TIER_1_1</b> = 11
	/// </summary>
	Tier11 = 11,
}

/// <summary>
/// ENUM <b>D3D12_VARIABLE_SHADING_RATE_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum VariableShadingRateTier : uint {
	/// <summary>
	/// <b>D3D12_VARIABLE_SHADING_RATE_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_VARIABLE_SHADING_RATE_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_VARIABLE_SHADING_RATE_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
}

/// <summary>
/// ENUM <b>D3D12_MESH_SHADER_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum MeshShaderTier : uint {
	/// <summary>
	/// <b>D3D12_MESH_SHADER_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_MESH_SHADER_TIER_1</b> = 10
	/// </summary>
	Tier1 = 10,
}

/// <summary>
/// ENUM <b>D3D12_SAMPLER_FEEDBACK_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum SamplerFeedbackTier : uint {
	/// <summary>
	/// <b>D3D12_SAMPLER_FEEDBACK_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_SAMPLER_FEEDBACK_TIER_0_9</b> = 90
	/// </summary>
	Tier09 = 90,
	/// <summary>
	/// <b>D3D12_SAMPLER_FEEDBACK_TIER_1_0</b> = 100
	/// </summary>
	Tier10 = 100,
}

/// <summary>
/// ENUM <b>D3D12_WAVE_MMA_TIER</b><br/>
/// D3D12.h
/// </summary>
public enum WaveMmaTier : uint {
	/// <summary>
	/// <b>D3D12_WAVE_MMA_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_WAVE_MMA_TIER_1_0</b> = 10
	/// </summary>
	Tier10 = 10,
}

/// <summary>
/// ENUM <b>D3D12_TRI_STATE</b><br/>
/// D3D12.h
/// </summary>
public enum TriState : uint {
	/// <summary>
	/// <b>D3D12_TRI_STATE_UNKNOWN</b> = -1
	/// </summary>
	Unknown = 0xffffffff,
	/// <summary>
	/// <b>D3D12_TRI_STATE_FALSE</b> = 0
	/// </summary>
	False = 0,
	/// <summary>
	/// <b>D3D12_TRI_STATE_TRUE</b> = 1
	/// </summary>
	True = 1,
}

/// <summary>
/// ENUM <b>D3D12_HEAP_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum HeapType : uint {
	/// <summary>
	/// <b>D3D12_HEAP_TYPE_DEFAULT</b> = 1
	/// </summary>
	Default = 1,
	/// <summary>
	/// <b>D3D12_HEAP_TYPE_UPLOAD</b> = 2
	/// </summary>
	Upload = 2,
	/// <summary>
	/// <b>D3D12_HEAP_TYPE_READBACK</b> = 3
	/// </summary>
	Readback = 3,
	/// <summary>
	/// <b>D3D12_HEAP_TYPE_CUSTOM</b> = 4
	/// </summary>
	Custom = 4,
}

/// <summary>
/// ENUM <b>D3D12_CPU_PAGE_PROPERTY</b><br/>
/// D3D12.h
/// </summary>
public enum CpuPageProperty : uint {
	/// <summary>
	/// <b>D3D12_CPU_PAGE_PROPERTY_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_CPU_PAGE_PROPERTY_NOT_AVAILABLE</b> = 1
	/// </summary>
	NotAvailable = 1,
	/// <summary>
	/// <b>D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE</b> = 2
	/// </summary>
	WriteCombine = 2,
	/// <summary>
	/// <b>D3D12_CPU_PAGE_PROPERTY_WRITE_BACK</b> = 3
	/// </summary>
	WriteBack = 3,
}

/// <summary>
/// ENUM <b>D3D12_MEMORY_POOL</b><br/>
/// D3D12.h
/// </summary>
public enum MemoryPool : uint {
	/// <summary>
	/// <b>D3D12_MEMORY_POOL_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_MEMORY_POOL_L0</b> = 1
	/// </summary>
	L0 = 1,
	/// <summary>
	/// <b>D3D12_MEMORY_POOL_L1</b> = 2
	/// </summary>
	L1 = 2,
}

/// <summary>
/// ENUM <b>D3D12_HEAP_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum HeapFlags : uint {
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_SHARED</b> = 0x1
	/// </summary>
	FlagShared = 1,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_DENY_BUFFERS</b> = 0x4
	/// </summary>
	FlagDenyBuffers = 4,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_ALLOW_DISPLAY</b> = 0x8
	/// </summary>
	FlagAllowDisplay = 8,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER</b> = 0x20
	/// </summary>
	FlagSharedCrossAdapter = 32,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES</b> = 0x40
	/// </summary>
	FlagDenyRtDsTextures = 64,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES</b> = 0x80
	/// </summary>
	FlagDenyNonRtDsTextures = 128,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_HARDWARE_PROTECTED</b> = 0x100
	/// </summary>
	FlagHardwareProtected = 256,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH</b> = 0x200
	/// </summary>
	FlagAllowWriteWatch = 512,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS</b> = 0x400
	/// </summary>
	FlagAllowShaderAtomics = 1024,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT</b> = 0x800
	/// </summary>
	FlagCreateNotResident = 2048,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_CREATE_NOT_ZEROED</b> = 0x1000
	/// </summary>
	FlagCreateNotZeroed = 4096,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES</b> = 0
	/// </summary>
	FlagAllowAllBuffersAndTextures = 0,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS</b> = 0xc0
	/// </summary>
	FlagAllowOnlyBuffers = 192,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES</b> = 0x44
	/// </summary>
	FlagAllowOnlyNonRtDsTextures = 68,
	/// <summary>
	/// <b>D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES</b> = 0x84
	/// </summary>
	FlagAllowOnlyRtDsTextures = 132,
}

/// <summary>
/// ENUM <b>D3D12_RESOURCE_DIMENSION</b><br/>
/// D3D12.h
/// </summary>
public enum ResourceDimension : uint {
	/// <summary>
	/// <b>D3D12_RESOURCE_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_RESOURCE_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D12_RESOURCE_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D12_RESOURCE_DIMENSION_TEXTURE2D</b> = 3
	/// </summary>
	Texture2d = 3,
	/// <summary>
	/// <b>D3D12_RESOURCE_DIMENSION_TEXTURE3D</b> = 4
	/// </summary>
	Texture3d = 4,
}

/// <summary>
/// ENUM <b>D3D12_TEXTURE_LAYOUT</b><br/>
/// D3D12.h
/// </summary>
public enum TextureLayout : uint {
	/// <summary>
	/// <b>D3D12_TEXTURE_LAYOUT_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_TEXTURE_LAYOUT_ROW_MAJOR</b> = 1
	/// </summary>
	RowMajor = 1,
	/// <summary>
	/// <b>D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE</b> = 2
	/// </summary>
	Layout64KbUndefinedSwizzle = 2,
	/// <summary>
	/// <b>D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE</b> = 3
	/// </summary>
	Layout64KbStandardSwizzle = 3,
}

/// <summary>
/// ENUM <b>D3D12_RESOURCE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ResourceFlags : uint {
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET</b> = 0x1
	/// </summary>
	FlagAllowRenderTarget = 1,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL</b> = 0x2
	/// </summary>
	FlagAllowDepthStencil = 2,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS</b> = 0x4
	/// </summary>
	FlagAllowUnorderedAccess = 4,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE</b> = 0x8
	/// </summary>
	FlagDenyShaderResource = 8,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER</b> = 0x10
	/// </summary>
	FlagAllowCrossAdapter = 16,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS</b> = 0x20
	/// </summary>
	FlagAllowSimultaneousAccess = 32,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY</b> = 0x40
	/// </summary>
	FlagVideoDecodeReferenceOnly = 64,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY</b> = 0x80
	/// </summary>
	FlagVideoEncodeReferenceOnly = 128,
	/// <summary>
	/// <b>D3D12_RESOURCE_FLAG_RAYTRACING_ACCELERATION_STRUCTURE</b> = 0x100
	/// </summary>
	FlagRaytracingAccelerationStructure = 256,
}

/// <summary>
/// ENUM <b>D3D12_TILE_RANGE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum TileRangeFlags : uint {
	/// <summary>
	/// <b>D3D12_TILE_RANGE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_TILE_RANGE_FLAG_NULL</b> = 1
	/// </summary>
	FlagNull = 1,
	/// <summary>
	/// <b>D3D12_TILE_RANGE_FLAG_SKIP</b> = 2
	/// </summary>
	FlagSkip = 2,
	/// <summary>
	/// <b>D3D12_TILE_RANGE_FLAG_REUSE_SINGLE_TILE</b> = 4
	/// </summary>
	FlagReuseSingleTile = 4,
}

/// <summary>
/// ENUM <b>D3D12_TILE_MAPPING_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum TileMappingFlags : uint {
	/// <summary>
	/// <b>D3D12_TILE_MAPPING_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_TILE_MAPPING_FLAG_NO_HAZARD</b> = 0x1
	/// </summary>
	FlagNoHazard = 1,
}

/// <summary>
/// ENUM <b>D3D12_TILE_COPY_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum TileCopyFlags : uint {
	/// <summary>
	/// <b>D3D12_TILE_COPY_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_TILE_COPY_FLAG_NO_HAZARD</b> = 0x1
	/// </summary>
	FlagNoHazard = 1,
	/// <summary>
	/// <b>D3D12_TILE_COPY_FLAG_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE</b> = 0x2
	/// </summary>
	FlagLinearBufferToSwizzledTiledResource = 2,
	/// <summary>
	/// <b>D3D12_TILE_COPY_FLAG_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER</b> = 0x4
	/// </summary>
	FlagSwizzledTiledResourceToLinearBuffer = 4,
}

/// <summary>
/// ENUM <b>D3D12_RESOURCE_STATES</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ResourceStates : uint {
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_COMMON</b> = 0
	/// </summary>
	StateCommon = 0,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER</b> = 0x1
	/// </summary>
	StateVertexAndConstantBuffer = 1,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_INDEX_BUFFER</b> = 0x2
	/// </summary>
	StateIndexBuffer = 2,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_RENDER_TARGET</b> = 0x4
	/// </summary>
	StateRenderTarget = 4,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_UNORDERED_ACCESS</b> = 0x8
	/// </summary>
	StateUnorderedAccess = 8,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_DEPTH_WRITE</b> = 0x10
	/// </summary>
	StateDepthWrite = 16,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_DEPTH_READ</b> = 0x20
	/// </summary>
	StateDepthRead = 32,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE</b> = 0x40
	/// </summary>
	StateNonPixelShaderResource = 64,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE</b> = 0x80
	/// </summary>
	StatePixelShaderResource = 128,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_STREAM_OUT</b> = 0x100
	/// </summary>
	StateStreamOut = 256,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT</b> = 0x200
	/// </summary>
	StateIndirectArgument = 512,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_COPY_DEST</b> = 0x400
	/// </summary>
	StateCopyDest = 1024,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_COPY_SOURCE</b> = 0x800
	/// </summary>
	StateCopySource = 2048,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_RESOLVE_DEST</b> = 0x1000
	/// </summary>
	StateResolveDest = 4096,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_RESOLVE_SOURCE</b> = 0x2000
	/// </summary>
	StateResolveSource = 8192,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE</b> = 0x400000
	/// </summary>
	StateRaytracingAccelerationStructure = 4194304,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_SHADING_RATE_SOURCE</b> = 0x1000000
	/// </summary>
	StateShadingRateSource = 16777216,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_GENERIC_READ</b> = ( ( ( ( ( 0x1 | 0x2 )  | 0x40 )  | 0x80 )  | 0x200 )  | 0x800 )
	/// </summary>
	StateGenericRead = 1 | 2 | 64 | 128 | 512 | 2048,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_ALL_SHADER_RESOURCE</b> = ( 0x40 | 0x80 )
	/// </summary>
	StateAllShaderResource = 64 | 128,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_PRESENT</b> = 0
	/// </summary>
	StatePresent = 0,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_PREDICATION</b> = 0x200
	/// </summary>
	StatePredication = 512,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_VIDEO_DECODE_READ</b> = 0x10000
	/// </summary>
	StateVideoDecodeRead = 65536,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_VIDEO_DECODE_WRITE</b> = 0x20000
	/// </summary>
	StateVideoDecodeWrite = 131072,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_VIDEO_PROCESS_READ</b> = 0x40000
	/// </summary>
	StateVideoProcessRead = 262144,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_VIDEO_PROCESS_WRITE</b> = 0x80000
	/// </summary>
	StateVideoProcessWrite = 524288,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_VIDEO_ENCODE_READ</b> = 0x200000
	/// </summary>
	StateVideoEncodeRead = 2097152,
	/// <summary>
	/// <b>D3D12_RESOURCE_STATE_VIDEO_ENCODE_WRITE</b> = 0x800000
	/// </summary>
	StateVideoEncodeWrite = 8388608,
}

/// <summary>
/// ENUM <b>D3D12_RESOURCE_BARRIER_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum ResourceBarrierType : uint {
	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_TYPE_TRANSITION</b> = 0
	/// </summary>
	Transition = 0,
	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_TYPE_ALIASING</b> = ( D3D12_RESOURCE_BARRIER_TYPE_TRANSITION + 1 )
	/// </summary>
	Aliasing = Transition + 1,
	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_TYPE_UAV</b> = ( D3D12_RESOURCE_BARRIER_TYPE_ALIASING + 1 )
	/// </summary>
	Uav = Aliasing + 1,
}

/// <summary>
/// ENUM <b>D3D12_RESOURCE_BARRIER_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ResourceBarrierFlags : uint {
	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_FLAG_BEGIN_ONLY</b> = 0x1
	/// </summary>
	FlagBeginOnly = 1,
	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_FLAG_END_ONLY</b> = 0x2
	/// </summary>
	FlagEndOnly = 2,
}

/// <summary>
/// ENUM <b>D3D12_TEXTURE_COPY_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum TextureCopyType : uint {
	/// <summary>
	/// <b>D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX</b> = 0
	/// </summary>
	SubresourceIndex = 0,
	/// <summary>
	/// <b>D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT</b> = 1
	/// </summary>
	PlacedFootprint = 1,
}

/// <summary>
/// ENUM <b>D3D12_RESOLVE_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum ResolveMode : uint {
	/// <summary>
	/// <b>D3D12_RESOLVE_MODE_DECOMPRESS</b> = 0
	/// </summary>
	Decompress = 0,
	/// <summary>
	/// <b>D3D12_RESOLVE_MODE_MIN</b> = 1
	/// </summary>
	Min = 1,
	/// <summary>
	/// <b>D3D12_RESOLVE_MODE_MAX</b> = 2
	/// </summary>
	Max = 2,
	/// <summary>
	/// <b>D3D12_RESOLVE_MODE_AVERAGE</b> = 3
	/// </summary>
	Average = 3,
	/// <summary>
	/// <b>D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK</b> = 4
	/// </summary>
	EncodeSamplerFeedback = 4,
	/// <summary>
	/// <b>D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK</b> = 5
	/// </summary>
	DecodeSamplerFeedback = 5,
}

/// <summary>
/// ENUM <b>D3D12_VIEW_INSTANCING_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ViewInstancingFlags : uint {
	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_FLAG_ENABLE_VIEW_INSTANCE_MASKING</b> = 0x1
	/// </summary>
	FlagEnableViewInstanceMasking = 1,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_COMPONENT_MAPPING</b><br/>
/// D3D12.h
/// </summary>
public enum ShaderComponentMapping : uint {
	/// <summary>
	/// <b>D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_0</b> = 0
	/// </summary>
	FromMemoryComponent0 = 0,
	/// <summary>
	/// <b>D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_1</b> = 1
	/// </summary>
	FromMemoryComponent1 = 1,
	/// <summary>
	/// <b>D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_2</b> = 2
	/// </summary>
	FromMemoryComponent2 = 2,
	/// <summary>
	/// <b>D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_3</b> = 3
	/// </summary>
	FromMemoryComponent3 = 3,
	/// <summary>
	/// <b>D3D12_SHADER_COMPONENT_MAPPING_FORCE_VALUE_0</b> = 4
	/// </summary>
	ForceValue0 = 4,
	/// <summary>
	/// <b>D3D12_SHADER_COMPONENT_MAPPING_FORCE_VALUE_1</b> = 5
	/// </summary>
	ForceValue1 = 5,
}

/// <summary>
/// ENUM <b>D3D12_BUFFER_SRV_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum BufferSrvFlags : uint {
	/// <summary>
	/// <b>D3D12_BUFFER_SRV_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_BUFFER_SRV_FLAG_RAW</b> = 0x1
	/// </summary>
	FlagRaw = 1,
}

/// <summary>
/// ENUM <b>D3D12_SRV_DIMENSION</b><br/>
/// D3D12.h
/// </summary>
public enum SrvDimension : uint {
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURE1DARRAY</b> = 3
	/// </summary>
	Texture1darray = 3,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURE2D</b> = 4
	/// </summary>
	Texture2d = 4,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURE2DARRAY</b> = 5
	/// </summary>
	Texture2darray = 5,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURE2DMS</b> = 6
	/// </summary>
	Texture2dms = 6,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURE2DMSARRAY</b> = 7
	/// </summary>
	Texture2dmsarray = 7,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURE3D</b> = 8
	/// </summary>
	Texture3d = 8,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURECUBE</b> = 9
	/// </summary>
	Texturecube = 9,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_TEXTURECUBEARRAY</b> = 10
	/// </summary>
	Texturecubearray = 10,
	/// <summary>
	/// <b>D3D12_SRV_DIMENSION_RAYTRACING_ACCELERATION_STRUCTURE</b> = 11
	/// </summary>
	RaytracingAccelerationStructure = 11,
}

/// <summary>
/// ENUM <b>D3D12_FILTER</b><br/>
/// D3D12.h
/// </summary>
public enum Filter : uint {
	/// <summary>
	/// <b>D3D12_FILTER_MIN_MAG_MIP_POINT</b> = 0
	/// </summary>
	MinMagMipPoint = 0,
	/// <summary>
	/// <b>D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR</b> = 0x1
	/// </summary>
	MinMagPointMipLinear = 1,
	/// <summary>
	/// <b>D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x4
	/// </summary>
	MinPointMagLinearMipPoint = 4,
	/// <summary>
	/// <b>D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR</b> = 0x5
	/// </summary>
	MinPointMagMipLinear = 5,
	/// <summary>
	/// <b>D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT</b> = 0x10
	/// </summary>
	MinLinearMagMipPoint = 16,
	/// <summary>
	/// <b>D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x11
	/// </summary>
	MinLinearMagPointMipLinear = 17,
	/// <summary>
	/// <b>D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT</b> = 0x14
	/// </summary>
	MinMagLinearMipPoint = 20,
	/// <summary>
	/// <b>D3D12_FILTER_MIN_MAG_MIP_LINEAR</b> = 0x15
	/// </summary>
	MinMagMipLinear = 21,
	/// <summary>
	/// <b>D3D12_FILTER_ANISOTROPIC</b> = 0x55
	/// </summary>
	Anisotropic = 85,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_MAG_MIP_POINT</b> = 0x80
	/// </summary>
	ComparisonMinMagMipPoint = 128,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR</b> = 0x81
	/// </summary>
	ComparisonMinMagPointMipLinear = 129,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x84
	/// </summary>
	ComparisonMinPointMagLinearMipPoint = 132,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR</b> = 0x85
	/// </summary>
	ComparisonMinPointMagMipLinear = 133,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT</b> = 0x90
	/// </summary>
	ComparisonMinLinearMagMipPoint = 144,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x91
	/// </summary>
	ComparisonMinLinearMagPointMipLinear = 145,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT</b> = 0x94
	/// </summary>
	ComparisonMinMagLinearMipPoint = 148,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR</b> = 0x95
	/// </summary>
	ComparisonMinMagMipLinear = 149,
	/// <summary>
	/// <b>D3D12_FILTER_COMPARISON_ANISOTROPIC</b> = 0xd5
	/// </summary>
	ComparisonAnisotropic = 213,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_MAG_MIP_POINT</b> = 0x100
	/// </summary>
	MinimumMinMagMipPoint = 256,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR</b> = 0x101
	/// </summary>
	MinimumMinMagPointMipLinear = 257,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x104
	/// </summary>
	MinimumMinPointMagLinearMipPoint = 260,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR</b> = 0x105
	/// </summary>
	MinimumMinPointMagMipLinear = 261,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT</b> = 0x110
	/// </summary>
	MinimumMinLinearMagMipPoint = 272,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x111
	/// </summary>
	MinimumMinLinearMagPointMipLinear = 273,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT</b> = 0x114
	/// </summary>
	MinimumMinMagLinearMipPoint = 276,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR</b> = 0x115
	/// </summary>
	MinimumMinMagMipLinear = 277,
	/// <summary>
	/// <b>D3D12_FILTER_MINIMUM_ANISOTROPIC</b> = 0x155
	/// </summary>
	MinimumAnisotropic = 341,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_POINT</b> = 0x180
	/// </summary>
	MaximumMinMagMipPoint = 384,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR</b> = 0x181
	/// </summary>
	MaximumMinMagPointMipLinear = 385,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT</b> = 0x184
	/// </summary>
	MaximumMinPointMagLinearMipPoint = 388,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR</b> = 0x185
	/// </summary>
	MaximumMinPointMagMipLinear = 389,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT</b> = 0x190
	/// </summary>
	MaximumMinLinearMagMipPoint = 400,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR</b> = 0x191
	/// </summary>
	MaximumMinLinearMagPointMipLinear = 401,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT</b> = 0x194
	/// </summary>
	MaximumMinMagLinearMipPoint = 404,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR</b> = 0x195
	/// </summary>
	MaximumMinMagMipLinear = 405,
	/// <summary>
	/// <b>D3D12_FILTER_MAXIMUM_ANISOTROPIC</b> = 0x1d5
	/// </summary>
	MaximumAnisotropic = 469,
}

/// <summary>
/// ENUM <b>D3D12_FILTER_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum FilterType : uint {
	/// <summary>
	/// <b>D3D12_FILTER_TYPE_POINT</b> = 0
	/// </summary>
	Point = 0,
	/// <summary>
	/// <b>D3D12_FILTER_TYPE_LINEAR</b> = 1
	/// </summary>
	Linear = 1,
}

/// <summary>
/// ENUM <b>D3D12_FILTER_REDUCTION_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum FilterReductionType : uint {
	/// <summary>
	/// <b>D3D12_FILTER_REDUCTION_TYPE_STANDARD</b> = 0
	/// </summary>
	Standard = 0,
	/// <summary>
	/// <b>D3D12_FILTER_REDUCTION_TYPE_COMPARISON</b> = 1
	/// </summary>
	Comparison = 1,
	/// <summary>
	/// <b>D3D12_FILTER_REDUCTION_TYPE_MINIMUM</b> = 2
	/// </summary>
	Minimum = 2,
	/// <summary>
	/// <b>D3D12_FILTER_REDUCTION_TYPE_MAXIMUM</b> = 3
	/// </summary>
	Maximum = 3,
}

/// <summary>
/// ENUM <b>D3D12_TEXTURE_ADDRESS_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum TextureAddressMode : uint {
	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE_WRAP</b> = 1
	/// </summary>
	Wrap = 1,
	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE_MIRROR</b> = 2
	/// </summary>
	Mirror = 2,
	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE_CLAMP</b> = 3
	/// </summary>
	Clamp = 3,
	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE_BORDER</b> = 4
	/// </summary>
	Border = 4,
	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE_MIRROR_ONCE</b> = 5
	/// </summary>
	MirrorOnce = 5,
}

/// <summary>
/// ENUM <b>D3D12_BUFFER_UAV_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum BufferUavFlags : uint {
	/// <summary>
	/// <b>D3D12_BUFFER_UAV_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_BUFFER_UAV_FLAG_RAW</b> = 0x1
	/// </summary>
	FlagRaw = 1,
}

/// <summary>
/// ENUM <b>D3D12_UAV_DIMENSION</b><br/>
/// D3D12.h
/// </summary>
public enum UavDimension : uint {
	/// <summary>
	/// <b>D3D12_UAV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_UAV_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D12_UAV_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D12_UAV_DIMENSION_TEXTURE1DARRAY</b> = 3
	/// </summary>
	Texture1darray = 3,
	/// <summary>
	/// <b>D3D12_UAV_DIMENSION_TEXTURE2D</b> = 4
	/// </summary>
	Texture2d = 4,
	/// <summary>
	/// <b>D3D12_UAV_DIMENSION_TEXTURE2DARRAY</b> = 5
	/// </summary>
	Texture2darray = 5,
	/// <summary>
	/// <b>D3D12_UAV_DIMENSION_TEXTURE3D</b> = 8
	/// </summary>
	Texture3d = 8,
}

/// <summary>
/// ENUM <b>D3D12_RTV_DIMENSION</b><br/>
/// D3D12.h
/// </summary>
public enum RtvDimension : uint {
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_TEXTURE1DARRAY</b> = 3
	/// </summary>
	Texture1darray = 3,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_TEXTURE2D</b> = 4
	/// </summary>
	Texture2d = 4,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_TEXTURE2DARRAY</b> = 5
	/// </summary>
	Texture2darray = 5,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_TEXTURE2DMS</b> = 6
	/// </summary>
	Texture2dms = 6,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_TEXTURE2DMSARRAY</b> = 7
	/// </summary>
	Texture2dmsarray = 7,
	/// <summary>
	/// <b>D3D12_RTV_DIMENSION_TEXTURE3D</b> = 8
	/// </summary>
	Texture3d = 8,
}

/// <summary>
/// ENUM <b>D3D12_DSV_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum DsvFlags : uint {
	/// <summary>
	/// <b>D3D12_DSV_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_DSV_FLAG_READ_ONLY_DEPTH</b> = 0x1
	/// </summary>
	FlagReadOnlyDepth = 1,
	/// <summary>
	/// <b>D3D12_DSV_FLAG_READ_ONLY_STENCIL</b> = 0x2
	/// </summary>
	FlagReadOnlyStencil = 2,
}

/// <summary>
/// ENUM <b>D3D12_DSV_DIMENSION</b><br/>
/// D3D12.h
/// </summary>
public enum DsvDimension : uint {
	/// <summary>
	/// <b>D3D12_DSV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_DSV_DIMENSION_TEXTURE1D</b> = 1
	/// </summary>
	Texture1d = 1,
	/// <summary>
	/// <b>D3D12_DSV_DIMENSION_TEXTURE1DARRAY</b> = 2
	/// </summary>
	Texture1darray = 2,
	/// <summary>
	/// <b>D3D12_DSV_DIMENSION_TEXTURE2D</b> = 3
	/// </summary>
	Texture2d = 3,
	/// <summary>
	/// <b>D3D12_DSV_DIMENSION_TEXTURE2DARRAY</b> = 4
	/// </summary>
	Texture2darray = 4,
	/// <summary>
	/// <b>D3D12_DSV_DIMENSION_TEXTURE2DMS</b> = 5
	/// </summary>
	Texture2dms = 5,
	/// <summary>
	/// <b>D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY</b> = 6
	/// </summary>
	Texture2dmsarray = 6,
}

/// <summary>
/// ENUM <b>D3D12_CLEAR_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ClearFlags : uint {
	/// <summary>
	/// <b>D3D12_CLEAR_FLAG_DEPTH</b> = 0x1
	/// </summary>
	FlagDepth = 1,
	/// <summary>
	/// <b>D3D12_CLEAR_FLAG_STENCIL</b> = 0x2
	/// </summary>
	FlagStencil = 2,
}

/// <summary>
/// ENUM <b>D3D12_FENCE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum FenceFlags : uint {
	/// <summary>
	/// <b>D3D12_FENCE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_FENCE_FLAG_SHARED</b> = 0x1
	/// </summary>
	FlagShared = 1,
	/// <summary>
	/// <b>D3D12_FENCE_FLAG_SHARED_CROSS_ADAPTER</b> = 0x2
	/// </summary>
	FlagSharedCrossAdapter = 2,
	/// <summary>
	/// <b>D3D12_FENCE_FLAG_NON_MONITORED</b> = 0x4
	/// </summary>
	FlagNonMonitored = 4,
}

/// <summary>
/// ENUM <b>D3D12_DESCRIPTOR_HEAP_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum DescriptorHeapType : uint {
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV</b> = 0
	/// </summary>
	CbvSrvUav = 0,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER</b> = ( D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV + 1 )
	/// </summary>
	Sampler = CbvSrvUav + 1,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_TYPE_RTV</b> = ( D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER + 1 )
	/// </summary>
	Rtv = Sampler + 1,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_TYPE_DSV</b> = ( D3D12_DESCRIPTOR_HEAP_TYPE_RTV + 1 )
	/// </summary>
	Dsv = Rtv + 1,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES</b> = ( D3D12_DESCRIPTOR_HEAP_TYPE_DSV + 1 )
	/// </summary>
	NumTypes = Dsv + 1,
}

/// <summary>
/// ENUM <b>D3D12_DESCRIPTOR_HEAP_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum DescriptorHeapFlags : uint {
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE</b> = 0x1
	/// </summary>
	FlagShaderVisible = 1,
}

/// <summary>
/// ENUM <b>D3D12_DESCRIPTOR_RANGE_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum DescriptorRangeType : uint {
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_TYPE_SRV</b> = 0
	/// </summary>
	Srv = 0,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_TYPE_UAV</b> = ( D3D12_DESCRIPTOR_RANGE_TYPE_SRV + 1 )
	/// </summary>
	Uav = Srv + 1,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_TYPE_CBV</b> = ( D3D12_DESCRIPTOR_RANGE_TYPE_UAV + 1 )
	/// </summary>
	Cbv = Uav + 1,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_TYPE_SAMPLER</b> = ( D3D12_DESCRIPTOR_RANGE_TYPE_CBV + 1 )
	/// </summary>
	Sampler = Cbv + 1,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_VISIBILITY</b><br/>
/// D3D12.h
/// </summary>
public enum ShaderVisibility : uint {
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_ALL</b> = 0
	/// </summary>
	All = 0,
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_VERTEX</b> = 1
	/// </summary>
	Vertex = 1,
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_HULL</b> = 2
	/// </summary>
	Hull = 2,
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_DOMAIN</b> = 3
	/// </summary>
	Domain = 3,
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_GEOMETRY</b> = 4
	/// </summary>
	Geometry = 4,
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_PIXEL</b> = 5
	/// </summary>
	Pixel = 5,
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_AMPLIFICATION</b> = 6
	/// </summary>
	Amplification = 6,
	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY_MESH</b> = 7
	/// </summary>
	Mesh = 7,
}

/// <summary>
/// ENUM <b>D3D12_ROOT_PARAMETER_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum RootParameterType : uint {
	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE</b> = 0
	/// </summary>
	DescriptorTable = 0,
	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS</b> = ( D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE + 1 )
	/// </summary>
	Type32BitConstants = DescriptorTable + 1,
	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER_TYPE_CBV</b> = ( D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS + 1 )
	/// </summary>
	Cbv = Type32BitConstants + 1,
	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER_TYPE_SRV</b> = ( D3D12_ROOT_PARAMETER_TYPE_CBV + 1 )
	/// </summary>
	Srv = Cbv + 1,
	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER_TYPE_UAV</b> = ( D3D12_ROOT_PARAMETER_TYPE_SRV + 1 )
	/// </summary>
	Uav = Srv + 1,
}

/// <summary>
/// ENUM <b>D3D12_ROOT_SIGNATURE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum RootSignatureFlags : uint {
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT</b> = 0x1
	/// </summary>
	FlagAllowInputAssemblerInputLayout = 1,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_DENY_VERTEX_SHADER_ROOT_ACCESS</b> = 0x2
	/// </summary>
	FlagDenyVertexShaderRootAccess = 2,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS</b> = 0x4
	/// </summary>
	FlagDenyHullShaderRootAccess = 4,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS</b> = 0x8
	/// </summary>
	FlagDenyDomainShaderRootAccess = 8,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS</b> = 0x10
	/// </summary>
	FlagDenyGeometryShaderRootAccess = 16,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_DENY_PIXEL_SHADER_ROOT_ACCESS</b> = 0x20
	/// </summary>
	FlagDenyPixelShaderRootAccess = 32,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_ALLOW_STREAM_OUTPUT</b> = 0x40
	/// </summary>
	FlagAllowStreamOutput = 64,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_LOCAL_ROOT_SIGNATURE</b> = 0x80
	/// </summary>
	FlagLocalRootSignature = 128,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_DENY_AMPLIFICATION_SHADER_ROOT_ACCESS</b> = 0x100
	/// </summary>
	FlagDenyAmplificationShaderRootAccess = 256,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_DENY_MESH_SHADER_ROOT_ACCESS</b> = 0x200
	/// </summary>
	FlagDenyMeshShaderRootAccess = 512,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_CBV_SRV_UAV_HEAP_DIRECTLY_INDEXED</b> = 0x400
	/// </summary>
	FlagCbvSrvUavHeapDirectlyIndexed = 1024,
	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAG_SAMPLER_HEAP_DIRECTLY_INDEXED</b> = 0x800
	/// </summary>
	FlagSamplerHeapDirectlyIndexed = 2048,
}

/// <summary>
/// ENUM <b>D3D12_STATIC_BORDER_COLOR</b><br/>
/// D3D12.h
/// </summary>
public enum StaticBorderColor : uint {
	/// <summary>
	/// <b>D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK</b> = 0
	/// </summary>
	TransparentBlack = 0,
	/// <summary>
	/// <b>D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK</b> = ( D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK + 1 )
	/// </summary>
	OpaqueBlack = TransparentBlack + 1,
	/// <summary>
	/// <b>D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE</b> = ( D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK + 1 )
	/// </summary>
	OpaqueWhite = OpaqueBlack + 1,
}

/// <summary>
/// ENUM <b>D3D12_DESCRIPTOR_RANGE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum DescriptorRangeFlags : uint {
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_VOLATILE</b> = 0x1
	/// </summary>
	FlagDescriptorsVolatile = 1,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_FLAG_DATA_VOLATILE</b> = 0x2
	/// </summary>
	FlagDataVolatile = 2,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE</b> = 0x4
	/// </summary>
	FlagDataStaticWhileSetAtExecute = 4,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC</b> = 0x8
	/// </summary>
	FlagDataStatic = 8,
	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_STATIC_KEEPING_BUFFER_BOUNDS_CHECKS</b> = 0x10000
	/// </summary>
	FlagDescriptorsStaticKeepingBufferBoundsChecks = 65536,
}

/// <summary>
/// ENUM <b>D3D12_ROOT_DESCRIPTOR_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum RootDescriptorFlags : uint {
	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR_FLAG_DATA_VOLATILE</b> = 0x2
	/// </summary>
	FlagDataVolatile = 2,
	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE</b> = 0x4
	/// </summary>
	FlagDataStaticWhileSetAtExecute = 4,
	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC</b> = 0x8
	/// </summary>
	FlagDataStatic = 8,
}

/// <summary>
/// ENUM <b>D3D12_QUERY_HEAP_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum QueryHeapType : uint {
	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE_OCCLUSION</b> = 0
	/// </summary>
	Occlusion = 0,
	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE_TIMESTAMP</b> = 1
	/// </summary>
	Timestamp = 1,
	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS</b> = 2
	/// </summary>
	PipelineStatistics = 2,
	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE_SO_STATISTICS</b> = 3
	/// </summary>
	SoStatistics = 3,
	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE_VIDEO_DECODE_STATISTICS</b> = 4
	/// </summary>
	VideoDecodeStatistics = 4,
	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE_COPY_QUEUE_TIMESTAMP</b> = 5
	/// </summary>
	CopyQueueTimestamp = 5,
	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS1</b> = 7
	/// </summary>
	PipelineStatistics1 = 7,
}

/// <summary>
/// ENUM <b>D3D12_QUERY_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum QueryType : uint {
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_OCCLUSION</b> = 0
	/// </summary>
	Occlusion = 0,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_BINARY_OCCLUSION</b> = 1
	/// </summary>
	BinaryOcclusion = 1,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_TIMESTAMP</b> = 2
	/// </summary>
	Timestamp = 2,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_PIPELINE_STATISTICS</b> = 3
	/// </summary>
	PipelineStatistics = 3,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0</b> = 4
	/// </summary>
	SoStatisticsStream0 = 4,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1</b> = 5
	/// </summary>
	SoStatisticsStream1 = 5,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2</b> = 6
	/// </summary>
	SoStatisticsStream2 = 6,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3</b> = 7
	/// </summary>
	SoStatisticsStream3 = 7,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS</b> = 8
	/// </summary>
	VideoDecodeStatistics = 8,
	/// <summary>
	/// <b>D3D12_QUERY_TYPE_PIPELINE_STATISTICS1</b> = 10
	/// </summary>
	PipelineStatistics1 = 10,
}

/// <summary>
/// ENUM <b>D3D12_PREDICATION_OP</b><br/>
/// D3D12.h
/// </summary>
public enum PredicationOp : uint {
	/// <summary>
	/// <b>D3D12_PREDICATION_OP_EQUAL_ZERO</b> = 0
	/// </summary>
	EqualZero = 0,
	/// <summary>
	/// <b>D3D12_PREDICATION_OP_NOT_EQUAL_ZERO</b> = 1
	/// </summary>
	NotEqualZero = 1,
}

/// <summary>
/// ENUM <b>D3D12_INDIRECT_ARGUMENT_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum IndirectArgumentType : uint {
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_DRAW</b> = 0
	/// </summary>
	Draw = 0,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_DRAW + 1 )
	/// </summary>
	DrawIndexed = Draw + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED + 1 )
	/// </summary>
	Dispatch = DrawIndexed + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH + 1 )
	/// </summary>
	VertexBufferView = Dispatch + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW + 1 )
	/// </summary>
	IndexBufferView = VertexBufferView + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW + 1 )
	/// </summary>
	Constant = IndexBufferView + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT + 1 )
	/// </summary>
	ConstantBufferView = Constant + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW + 1 )
	/// </summary>
	ShaderResourceView = ConstantBufferView + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW + 1 )
	/// </summary>
	UnorderedAccessView = ShaderResourceView + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW + 1 )
	/// </summary>
	DispatchRays = UnorderedAccessView + 1,
	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_MESH</b> = ( D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS + 1 )
	/// </summary>
	DispatchMesh = DispatchRays + 1,
}

/// <summary>
/// ENUM <b>D3D12_WRITEBUFFERIMMEDIATE_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum WritebufferimmediateMode : uint {
	/// <summary>
	/// <b>D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN</b> = 0x1
	/// </summary>
	MarkerIn = 1,
	/// <summary>
	/// <b>D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT</b> = 0x2
	/// </summary>
	MarkerOut = 2,
}

/// <summary>
/// ENUM <b>D3D12_MULTIPLE_FENCE_WAIT_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum MultipleFenceWaitFlags : uint {
	/// <summary>
	/// <b>D3D12_MULTIPLE_FENCE_WAIT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_MULTIPLE_FENCE_WAIT_FLAG_ANY</b> = 0x1
	/// </summary>
	FlagAny = 1,
	/// <summary>
	/// <b>D3D12_MULTIPLE_FENCE_WAIT_FLAG_ALL</b> = 0
	/// </summary>
	FlagAll = 0,
}

/// <summary>
/// ENUM <b>D3D12_RESIDENCY_PRIORITY</b><br/>
/// D3D12.h
/// </summary>
public enum ResidencyPriority : uint {
	/// <summary>
	/// <b>D3D12_RESIDENCY_PRIORITY_MINIMUM</b> = 0x28000000
	/// </summary>
	Minimum = 671088640,
	/// <summary>
	/// <b>D3D12_RESIDENCY_PRIORITY_LOW</b> = 0x50000000
	/// </summary>
	Low = 1342177280,
	/// <summary>
	/// <b>D3D12_RESIDENCY_PRIORITY_NORMAL</b> = 0x78000000
	/// </summary>
	Normal = 2013265920,
	/// <summary>
	/// <b>D3D12_RESIDENCY_PRIORITY_HIGH</b> = 0xa0010000
	/// </summary>
	High = 2684420096,
	/// <summary>
	/// <b>D3D12_RESIDENCY_PRIORITY_MAXIMUM</b> = 0xc8000000
	/// </summary>
	Maximum = 3355443200,
}

/// <summary>
/// ENUM <b>D3D12_RESIDENCY_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum ResidencyFlags : uint {
	/// <summary>
	/// <b>D3D12_RESIDENCY_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RESIDENCY_FLAG_DENY_OVERBUDGET</b> = 0x1
	/// </summary>
	FlagDenyOverbudget = 1,
}

/// <summary>
/// ENUM <b>D3D12_COMMAND_LIST_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum CommandListFlags : uint {
	/// <summary>
	/// <b>D3D12_COMMAND_LIST_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}

/// <summary>
/// ENUM <b>D3D12_COMMAND_POOL_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum CommandPoolFlags : uint {
	/// <summary>
	/// <b>D3D12_COMMAND_POOL_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}

/// <summary>
/// ENUM <b>D3D12_COMMAND_RECORDER_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum CommandRecorderFlags : uint {
	/// <summary>
	/// <b>D3D12_COMMAND_RECORDER_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}

/// <summary>
/// ENUM <b>D3D12_PROTECTED_SESSION_STATUS</b><br/>
/// D3D12.h
/// </summary>
public enum ProtectedSessionStatus : uint {
	/// <summary>
	/// <b>D3D12_PROTECTED_SESSION_STATUS_OK</b> = 0
	/// </summary>
	Ok = 0,
	/// <summary>
	/// <b>D3D12_PROTECTED_SESSION_STATUS_INVALID</b> = 1
	/// </summary>
	Invalid = 1,
}

/// <summary>
/// ENUM <b>D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ProtectedResourceSessionSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_SUPPORTED</b> = 0x1
	/// </summary>
	FlagSupported = 1,
}

/// <summary>
/// ENUM <b>D3D12_PROTECTED_RESOURCE_SESSION_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum ProtectedResourceSessionFlags : uint {
	/// <summary>
	/// <b>D3D12_PROTECTED_RESOURCE_SESSION_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}

/// <summary>
/// ENUM <b>D3D12_LIFETIME_STATE</b><br/>
/// D3D12.h
/// </summary>
public enum LifetimeState : uint {
	/// <summary>
	/// <b>D3D12_LIFETIME_STATE_IN_USE</b> = 0
	/// </summary>
	InUse = 0,
	/// <summary>
	/// <b>D3D12_LIFETIME_STATE_NOT_IN_USE</b> = ( D3D12_LIFETIME_STATE_IN_USE + 1 )
	/// </summary>
	NotInUse = InUse + 1,
}

/// <summary>
/// ENUM <b>D3D12_META_COMMAND_PARAMETER_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum MetaCommandParameterType : uint {
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_TYPE_FLOAT</b> = 0
	/// </summary>
	Float = 0,
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_TYPE_UINT64</b> = 1
	/// </summary>
	Uint64 = 1,
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_TYPE_GPU_VIRTUAL_ADDRESS</b> = 2
	/// </summary>
	GpuVirtualAddress = 2,
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_TYPE_CPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV</b> = 3
	/// </summary>
	CpuDescriptorHandleHeapTypeCbvSrvUav = 3,
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_TYPE_GPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV</b> = 4
	/// </summary>
	GpuDescriptorHandleHeapTypeCbvSrvUav = 4,
}

/// <summary>
/// ENUM <b>D3D12_META_COMMAND_PARAMETER_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum MetaCommandParameterFlags : uint {
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_FLAG_INPUT</b> = 0x1
	/// </summary>
	FlagInput = 1,
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_FLAG_OUTPUT</b> = 0x2
	/// </summary>
	FlagOutput = 2,
}

/// <summary>
/// ENUM <b>D3D12_META_COMMAND_PARAMETER_STAGE</b><br/>
/// D3D12.h
/// </summary>
public enum MetaCommandParameterStage : uint {
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_STAGE_CREATION</b> = 0
	/// </summary>
	Creation = 0,
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION</b> = 1
	/// </summary>
	Initialization = 1,
	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION</b> = 2
	/// </summary>
	Execution = 2,
}

/// <summary>
/// ENUM <b>D3D12_GRAPHICS_STATES</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum GraphicsStates : uint {
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_NONE</b> = 0
	/// </summary>
	StateNone = 0,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS</b> = ( 1 &lt;&lt; 0 )
	/// </summary>
	StateIaVertexBuffers = 1 << 0,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER</b> = ( 1 &lt;&lt; 1 )
	/// </summary>
	StateIaIndexBuffer = 1 << 1,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY</b> = ( 1 &lt;&lt; 2 )
	/// </summary>
	StateIaPrimitiveTopology = 1 << 2,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP</b> = ( 1 &lt;&lt; 3 )
	/// </summary>
	StateDescriptorHeap = 1 << 3,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE</b> = ( 1 &lt;&lt; 4 )
	/// </summary>
	StateGraphicsRootSignature = 1 << 4,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE</b> = ( 1 &lt;&lt; 5 )
	/// </summary>
	StateComputeRootSignature = 1 << 5,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_RS_VIEWPORTS</b> = ( 1 &lt;&lt; 6 )
	/// </summary>
	StateRsViewports = 1 << 6,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS</b> = ( 1 &lt;&lt; 7 )
	/// </summary>
	StateRsScissorRects = 1 << 7,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_PREDICATION</b> = ( 1 &lt;&lt; 8 )
	/// </summary>
	StatePredication = 1 << 8,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS</b> = ( 1 &lt;&lt; 9 )
	/// </summary>
	StateOmRenderTargets = 1 << 9,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_OM_STENCIL_REF</b> = ( 1 &lt;&lt; 10 )
	/// </summary>
	StateOmStencilRef = 1 << 10,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR</b> = ( 1 &lt;&lt; 11 )
	/// </summary>
	StateOmBlendFactor = 1 << 11,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_PIPELINE_STATE</b> = ( 1 &lt;&lt; 12 )
	/// </summary>
	StatePipelineState = 1 << 12,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_SO_TARGETS</b> = ( 1 &lt;&lt; 13 )
	/// </summary>
	StateSoTargets = 1 << 13,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS</b> = ( 1 &lt;&lt; 14 )
	/// </summary>
	StateOmDepthBounds = 1 << 14,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS</b> = ( 1 &lt;&lt; 15 )
	/// </summary>
	StateSamplePositions = 1 << 15,
	/// <summary>
	/// <b>D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK</b> = ( 1 &lt;&lt; 16 )
	/// </summary>
	StateViewInstanceMask = 1 << 16,
}

/// <summary>
/// ENUM <b>D3D12_STATE_SUBOBJECT_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum StateSubobjectType : uint {
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG</b> = 0
	/// </summary>
	StateObjectConfig = 0,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE</b> = 1
	/// </summary>
	GlobalRootSignature = 1,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE</b> = 2
	/// </summary>
	LocalRootSignature = 2,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK</b> = 3
	/// </summary>
	NodeMask = 3,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY</b> = 5
	/// </summary>
	DxilLibrary = 5,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION</b> = 6
	/// </summary>
	ExistingCollection = 6,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION</b> = 7
	/// </summary>
	SubobjectToExportsAssociation = 7,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION</b> = 8
	/// </summary>
	DxilSubobjectToExportsAssociation = 8,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG</b> = 9
	/// </summary>
	RaytracingShaderConfig = 9,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG</b> = 10
	/// </summary>
	RaytracingPipelineConfig = 10,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP</b> = 11
	/// </summary>
	HitGroup = 11,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1</b> = 12
	/// </summary>
	RaytracingPipelineConfig1 = 12,
	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID</b> = ( D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1 + 1 )
	/// </summary>
	MaxValid = RaytracingPipelineConfig1 + 1,
}

/// <summary>
/// ENUM <b>D3D12_STATE_OBJECT_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum StateObjectFlags : uint {
	/// <summary>
	/// <b>D3D12_STATE_OBJECT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_STATE_OBJECT_FLAG_ALLOW_LOCAL_DEPENDENCIES_ON_EXTERNAL_DEFINITIONS</b> = 0x1
	/// </summary>
	FlagAllowLocalDependenciesOnExternalDefinitions = 1,
	/// <summary>
	/// <b>D3D12_STATE_OBJECT_FLAG_ALLOW_EXTERNAL_DEPENDENCIES_ON_LOCAL_DEFINITIONS</b> = 0x2
	/// </summary>
	FlagAllowExternalDependenciesOnLocalDefinitions = 2,
	/// <summary>
	/// <b>D3D12_STATE_OBJECT_FLAG_ALLOW_STATE_OBJECT_ADDITIONS</b> = 0x4
	/// </summary>
	FlagAllowStateObjectAdditions = 4,
}

/// <summary>
/// ENUM <b>D3D12_EXPORT_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum ExportFlags : uint {
	/// <summary>
	/// <b>D3D12_EXPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}

/// <summary>
/// ENUM <b>D3D12_HIT_GROUP_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum HitGroupType : uint {
	/// <summary>
	/// <b>D3D12_HIT_GROUP_TYPE_TRIANGLES</b> = 0
	/// </summary>
	Triangles = 0,
	/// <summary>
	/// <b>D3D12_HIT_GROUP_TYPE_PROCEDURAL_PRIMITIVE</b> = 0x1
	/// </summary>
	ProceduralPrimitive = 1,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_PIPELINE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum RaytracingPipelineFlags : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_PIPELINE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_TRIANGLES</b> = 0x100
	/// </summary>
	FlagSkipTriangles = 256,
	/// <summary>
	/// <b>D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_PROCEDURAL_PRIMITIVES</b> = 0x200
	/// </summary>
	FlagSkipProceduralPrimitives = 512,
}

/// <summary>
/// ENUM <b>D3D12_STATE_OBJECT_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum StateObjectType : uint {
	/// <summary>
	/// <b>D3D12_STATE_OBJECT_TYPE_COLLECTION</b> = 0
	/// </summary>
	Collection = 0,
	/// <summary>
	/// <b>D3D12_STATE_OBJECT_TYPE_RAYTRACING_PIPELINE</b> = 3
	/// </summary>
	RaytracingPipeline = 3,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_GEOMETRY_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum RaytracingGeometryFlags : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_FLAG_OPAQUE</b> = 0x1
	/// </summary>
	FlagOpaque = 1,
	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_FLAG_NO_DUPLICATE_ANYHIT_INVOCATION</b> = 0x2
	/// </summary>
	FlagNoDuplicateAnyhitInvocation = 2,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_GEOMETRY_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum RaytracingGeometryType : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_TYPE_TRIANGLES</b> = 0
	/// </summary>
	Triangles = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_TYPE_PROCEDURAL_PRIMITIVE_AABBS</b> = ( D3D12_RAYTRACING_GEOMETRY_TYPE_TRIANGLES + 1 )
	/// </summary>
	ProceduralPrimitiveAabbs = Triangles + 1,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_INSTANCE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum RaytracingInstanceFlags : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_INSTANCE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE</b> = 0x1
	/// </summary>
	FlagTriangleCullDisable = 1,
	/// <summary>
	/// <b>D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE</b> = 0x2
	/// </summary>
	FlagTriangleFrontCounterclockwise = 2,
	/// <summary>
	/// <b>D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE</b> = 0x4
	/// </summary>
	FlagForceOpaque = 4,
	/// <summary>
	/// <b>D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE</b> = 0x8
	/// </summary>
	FlagForceNonOpaque = 8,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum RaytracingAccelerationStructureBuildFlags : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_UPDATE</b> = 0x1
	/// </summary>
	FlagAllowUpdate = 1,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_COMPACTION</b> = 0x2
	/// </summary>
	FlagAllowCompaction = 2,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_TRACE</b> = 0x4
	/// </summary>
	FlagPreferFastTrace = 4,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_BUILD</b> = 0x8
	/// </summary>
	FlagPreferFastBuild = 8,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_MINIMIZE_MEMORY</b> = 0x10
	/// </summary>
	FlagMinimizeMemory = 16,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PERFORM_UPDATE</b> = 0x20
	/// </summary>
	FlagPerformUpdate = 32,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum RaytracingAccelerationStructureCopyMode : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_CLONE</b> = 0
	/// </summary>
	Clone = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_COMPACT</b> = 0x1
	/// </summary>
	Compact = 1,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_VISUALIZATION_DECODE_FOR_TOOLS</b> = 0x2
	/// </summary>
	VisualizationDecodeForTools = 2,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_SERIALIZE</b> = 0x3
	/// </summary>
	Serialize = 3,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_DESERIALIZE</b> = 0x4
	/// </summary>
	Deserialize = 4,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum RaytracingAccelerationStructureType : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL</b> = 0
	/// </summary>
	TopLevel = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL</b> = 0x1
	/// </summary>
	BottomLevel = 1,
}

/// <summary>
/// ENUM <b>D3D12_ELEMENTS_LAYOUT</b><br/>
/// D3D12.h
/// </summary>
public enum ElementsLayout : uint {
	/// <summary>
	/// <b>D3D12_ELEMENTS_LAYOUT_ARRAY</b> = 0
	/// </summary>
	Array = 0,
	/// <summary>
	/// <b>D3D12_ELEMENTS_LAYOUT_ARRAY_OF_POINTERS</b> = 0x1
	/// </summary>
	ArrayOfPointers = 1,
}

/// <summary>
/// ENUM <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum RaytracingAccelerationStructurePostbuildInfoType : uint {
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE</b> = 0
	/// </summary>
	CompactedSize = 0,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TOOLS_VISUALIZATION</b> = 0x1
	/// </summary>
	ToolsVisualization = 1,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION</b> = 0x2
	/// </summary>
	Serialization = 2,
	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_CURRENT_SIZE</b> = 0x3
	/// </summary>
	CurrentSize = 3,
}

/// <summary>
/// ENUM <b>D3D12_SERIALIZED_DATA_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum SerializedDataType : uint {
	/// <summary>
	/// <b>D3D12_SERIALIZED_DATA_RAYTRACING_ACCELERATION_STRUCTURE</b> = 0
	/// </summary>
	RaytracingAccelerationStructure = 0,
}

/// <summary>
/// ENUM <b>D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS</b><br/>
/// D3D12.h
/// </summary>
public enum DriverMatchingIdentifierStatus : uint {
	/// <summary>
	/// <b>D3D12_DRIVER_MATCHING_IDENTIFIER_COMPATIBLE_WITH_DEVICE</b> = 0
	/// </summary>
	CompatibleWithDevice = 0,
	/// <summary>
	/// <b>D3D12_DRIVER_MATCHING_IDENTIFIER_UNSUPPORTED_TYPE</b> = 0x1
	/// </summary>
	UnsupportedType = 1,
	/// <summary>
	/// <b>D3D12_DRIVER_MATCHING_IDENTIFIER_UNRECOGNIZED</b> = 0x2
	/// </summary>
	Unrecognized = 2,
	/// <summary>
	/// <b>D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_VERSION</b> = 0x3
	/// </summary>
	IncompatibleVersion = 3,
	/// <summary>
	/// <b>D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_TYPE</b> = 0x4
	/// </summary>
	IncompatibleType = 4,
}

/// <summary>
/// ENUM <b>D3D12_RAY_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum RayFlags : uint {
	/// <summary>
	/// <b>D3D12_RAY_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_FORCE_OPAQUE</b> = 0x1
	/// </summary>
	FlagForceOpaque = 1,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_FORCE_NON_OPAQUE</b> = 0x2
	/// </summary>
	FlagForceNonOpaque = 2,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH</b> = 0x4
	/// </summary>
	FlagAcceptFirstHitAndEndSearch = 4,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER</b> = 0x8
	/// </summary>
	FlagSkipClosestHitShader = 8,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES</b> = 0x10
	/// </summary>
	FlagCullBackFacingTriangles = 16,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES</b> = 0x20
	/// </summary>
	FlagCullFrontFacingTriangles = 32,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_CULL_OPAQUE</b> = 0x40
	/// </summary>
	FlagCullOpaque = 64,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_CULL_NON_OPAQUE</b> = 0x80
	/// </summary>
	FlagCullNonOpaque = 128,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_SKIP_TRIANGLES</b> = 0x100
	/// </summary>
	FlagSkipTriangles = 256,
	/// <summary>
	/// <b>D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES</b> = 0x200
	/// </summary>
	FlagSkipProceduralPrimitives = 512,
}

/// <summary>
/// ENUM <b>D3D12_HIT_KIND</b><br/>
/// D3D12.h
/// </summary>
public enum HitKind : uint {
	/// <summary>
	/// <b>D3D12_HIT_KIND_TRIANGLE_FRONT_FACE</b> = 0xfe
	/// </summary>
	TriangleFrontFace = 254,
	/// <summary>
	/// <b>D3D12_HIT_KIND_TRIANGLE_BACK_FACE</b> = 0xff
	/// </summary>
	TriangleBackFace = 255,
}

/// <summary>
/// ENUM <b>D3D12_AUTO_BREADCRUMB_OP</b><br/>
/// D3D12.h
/// </summary>
public enum AutoBreadcrumbOp : uint {
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_SETMARKER</b> = 0
	/// </summary>
	Setmarker = 0,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_BEGINEVENT</b> = 1
	/// </summary>
	Beginevent = 1,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_ENDEVENT</b> = 2
	/// </summary>
	Endevent = 2,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DRAWINSTANCED</b> = 3
	/// </summary>
	Drawinstanced = 3,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DRAWINDEXEDINSTANCED</b> = 4
	/// </summary>
	Drawindexedinstanced = 4,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_EXECUTEINDIRECT</b> = 5
	/// </summary>
	Executeindirect = 5,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DISPATCH</b> = 6
	/// </summary>
	Dispatch = 6,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_COPYBUFFERREGION</b> = 7
	/// </summary>
	Copybufferregion = 7,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_COPYTEXTUREREGION</b> = 8
	/// </summary>
	Copytextureregion = 8,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_COPYRESOURCE</b> = 9
	/// </summary>
	Copyresource = 9,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_COPYTILES</b> = 10
	/// </summary>
	Copytiles = 10,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCE</b> = 11
	/// </summary>
	Resolvesubresource = 11,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_CLEARRENDERTARGETVIEW</b> = 12
	/// </summary>
	Clearrendertargetview = 12,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_CLEARUNORDEREDACCESSVIEW</b> = 13
	/// </summary>
	Clearunorderedaccessview = 13,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_CLEARDEPTHSTENCILVIEW</b> = 14
	/// </summary>
	Cleardepthstencilview = 14,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_RESOURCEBARRIER</b> = 15
	/// </summary>
	Resourcebarrier = 15,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_EXECUTEBUNDLE</b> = 16
	/// </summary>
	Executebundle = 16,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_PRESENT</b> = 17
	/// </summary>
	Present = 17,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_RESOLVEQUERYDATA</b> = 18
	/// </summary>
	Resolvequerydata = 18,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_BEGINSUBMISSION</b> = 19
	/// </summary>
	Beginsubmission = 19,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_ENDSUBMISSION</b> = 20
	/// </summary>
	Endsubmission = 20,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME</b> = 21
	/// </summary>
	Decodeframe = 21,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES</b> = 22
	/// </summary>
	Processframes = 22,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT</b> = 23
	/// </summary>
	Atomiccopybufferuint = 23,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT64</b> = 24
	/// </summary>
	Atomiccopybufferuint64 = 24,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCEREGION</b> = 25
	/// </summary>
	Resolvesubresourceregion = 25,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_WRITEBUFFERIMMEDIATE</b> = 26
	/// </summary>
	Writebufferimmediate = 26,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME1</b> = 27
	/// </summary>
	Decodeframe1 = 27,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_SETPROTECTEDRESOURCESESSION</b> = 28
	/// </summary>
	Setprotectedresourcesession = 28,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME2</b> = 29
	/// </summary>
	Decodeframe2 = 29,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES1</b> = 30
	/// </summary>
	Processframes1 = 30,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_BUILDRAYTRACINGACCELERATIONSTRUCTURE</b> = 31
	/// </summary>
	Buildraytracingaccelerationstructure = 31,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO</b> = 32
	/// </summary>
	Emitraytracingaccelerationstructurepostbuildinfo = 32,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_COPYRAYTRACINGACCELERATIONSTRUCTURE</b> = 33
	/// </summary>
	Copyraytracingaccelerationstructure = 33,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DISPATCHRAYS</b> = 34
	/// </summary>
	Dispatchrays = 34,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_INITIALIZEMETACOMMAND</b> = 35
	/// </summary>
	Initializemetacommand = 35,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_EXECUTEMETACOMMAND</b> = 36
	/// </summary>
	Executemetacommand = 36,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_ESTIMATEMOTION</b> = 37
	/// </summary>
	Estimatemotion = 37,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_RESOLVEMOTIONVECTORHEAP</b> = 38
	/// </summary>
	Resolvemotionvectorheap = 38,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_SETPIPELINESTATE1</b> = 39
	/// </summary>
	Setpipelinestate1 = 39,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_INITIALIZEEXTENSIONCOMMAND</b> = 40
	/// </summary>
	Initializeextensioncommand = 40,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_EXECUTEEXTENSIONCOMMAND</b> = 41
	/// </summary>
	Executeextensioncommand = 41,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_DISPATCHMESH</b> = 42
	/// </summary>
	Dispatchmesh = 42,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_ENCODEFRAME</b> = 43
	/// </summary>
	Encodeframe = 43,
	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP_RESOLVEENCODEROUTPUTMETADATA</b> = 44
	/// </summary>
	Resolveencoderoutputmetadata = 44,
}

/// <summary>
/// ENUM <b>D3D12_DRED_VERSION</b><br/>
/// D3D12.h
/// </summary>
public enum DredVersion : uint {
	/// <summary>
	/// <b>D3D12_DRED_VERSION_1_0</b> = 0x1
	/// </summary>
	Version10 = 1,
	/// <summary>
	/// <b>D3D12_DRED_VERSION_1_1</b> = 0x2
	/// </summary>
	Version11 = 2,
	/// <summary>
	/// <b>D3D12_DRED_VERSION_1_2</b> = 0x3
	/// </summary>
	Version12 = 3,
	/// <summary>
	/// <b>D3D12_DRED_VERSION_1_3</b> = 0x4
	/// </summary>
	Version13 = 4,
}

/// <summary>
/// ENUM <b>D3D12_DRED_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum DredFlags : uint {
	/// <summary>
	/// <b>D3D12_DRED_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_DRED_FLAG_FORCE_ENABLE</b> = 1
	/// </summary>
	FlagForceEnable = 1,
	/// <summary>
	/// <b>D3D12_DRED_FLAG_DISABLE_AUTOBREADCRUMBS</b> = 2
	/// </summary>
	FlagDisableAutobreadcrumbs = 2,
}

/// <summary>
/// ENUM <b>D3D12_DRED_ENABLEMENT</b><br/>
/// D3D12.h
/// </summary>
public enum DredEnablement : uint {
	/// <summary>
	/// <b>D3D12_DRED_ENABLEMENT_SYSTEM_CONTROLLED</b> = 0
	/// </summary>
	SystemControlled = 0,
	/// <summary>
	/// <b>D3D12_DRED_ENABLEMENT_FORCED_OFF</b> = 1
	/// </summary>
	ForcedOff = 1,
	/// <summary>
	/// <b>D3D12_DRED_ENABLEMENT_FORCED_ON</b> = 2
	/// </summary>
	ForcedOn = 2,
}

/// <summary>
/// ENUM <b>D3D12_DRED_ALLOCATION_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum DredAllocationType : uint {
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE</b> = 19
	/// </summary>
	CommandQueue = 19,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR</b> = 20
	/// </summary>
	CommandAllocator = 20,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE</b> = 21
	/// </summary>
	PipelineState = 21,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST</b> = 22
	/// </summary>
	CommandList = 22,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_FENCE</b> = 23
	/// </summary>
	Fence = 23,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP</b> = 24
	/// </summary>
	DescriptorHeap = 24,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_HEAP</b> = 25
	/// </summary>
	Heap = 25,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP</b> = 27
	/// </summary>
	QueryHeap = 27,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE</b> = 28
	/// </summary>
	CommandSignature = 28,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY</b> = 29
	/// </summary>
	PipelineLibrary = 29,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER</b> = 30
	/// </summary>
	VideoDecoder = 30,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR</b> = 32
	/// </summary>
	VideoProcessor = 32,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_RESOURCE</b> = 34
	/// </summary>
	Resource = 34,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_PASS</b> = 35
	/// </summary>
	Pass = 35,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION</b> = 36
	/// </summary>
	Cryptosession = 36,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY</b> = 37
	/// </summary>
	Cryptosessionpolicy = 37,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION</b> = 38
	/// </summary>
	Protectedresourcesession = 38,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP</b> = 39
	/// </summary>
	VideoDecoderHeap = 39,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL</b> = 40
	/// </summary>
	CommandPool = 40,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER</b> = 41
	/// </summary>
	CommandRecorder = 41,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT</b> = 42
	/// </summary>
	StateObject = 42,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_METACOMMAND</b> = 43
	/// </summary>
	Metacommand = 43,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP</b> = 44
	/// </summary>
	Schedulinggroup = 44,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR</b> = 45
	/// </summary>
	VideoMotionEstimator = 45,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP</b> = 46
	/// </summary>
	VideoMotionVectorHeap = 46,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND</b> = 47
	/// </summary>
	VideoExtensionCommand = 47,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER</b> = 48
	/// </summary>
	VideoEncoder = 48,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP</b> = 49
	/// </summary>
	VideoEncoderHeap = 49,
	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE_INVALID</b> = 0xffffffff
	/// </summary>
	Invalid = 4294967295,
}

/// <summary>
/// ENUM <b>D3D12_DRED_PAGE_FAULT_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum DredPageFaultFlags : uint {
	/// <summary>
	/// <b>D3D12_DRED_PAGE_FAULT_FLAGS_NONE</b> = 0
	/// </summary>
	None = 0,
}

/// <summary>
/// ENUM <b>D3D12_DRED_DEVICE_STATE</b><br/>
/// D3D12.h
/// </summary>
public enum DredDeviceState : uint {
	/// <summary>
	/// <b>D3D12_DRED_DEVICE_STATE_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_DRED_DEVICE_STATE_HUNG</b> = 3
	/// </summary>
	Hung = 3,
	/// <summary>
	/// <b>D3D12_DRED_DEVICE_STATE_FAULT</b> = 6
	/// </summary>
	Fault = 6,
	/// <summary>
	/// <b>D3D12_DRED_DEVICE_STATE_PAGEFAULT</b> = 7
	/// </summary>
	Pagefault = 7,
}

/// <summary>
/// ENUM <b>D3D12_BACKGROUND_PROCESSING_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum BackgroundProcessingMode : uint {
	/// <summary>
	/// <b>D3D12_BACKGROUND_PROCESSING_MODE_ALLOWED</b> = 0
	/// </summary>
	Allowed = 0,
	/// <summary>
	/// <b>D3D12_BACKGROUND_PROCESSING_MODE_ALLOW_INTRUSIVE_MEASUREMENTS</b> = ( D3D12_BACKGROUND_PROCESSING_MODE_ALLOWED + 1 )
	/// </summary>
	AllowIntrusiveMeasurements = Allowed + 1,
	/// <summary>
	/// <b>D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_BACKGROUND_WORK</b> = ( D3D12_BACKGROUND_PROCESSING_MODE_ALLOW_INTRUSIVE_MEASUREMENTS + 1 )
	/// </summary>
	DisableBackgroundWork = AllowIntrusiveMeasurements + 1,
	/// <summary>
	/// <b>D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_PROFILING_BY_SYSTEM</b> = ( D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_BACKGROUND_WORK + 1 )
	/// </summary>
	DisableProfilingBySystem = DisableBackgroundWork + 1,
}

/// <summary>
/// ENUM <b>D3D12_MEASUREMENTS_ACTION</b><br/>
/// D3D12.h
/// </summary>
public enum MeasurementsAction : uint {
	/// <summary>
	/// <b>D3D12_MEASUREMENTS_ACTION_KEEP_ALL</b> = 0
	/// </summary>
	KeepAll = 0,
	/// <summary>
	/// <b>D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS</b> = ( D3D12_MEASUREMENTS_ACTION_KEEP_ALL + 1 )
	/// </summary>
	CommitResults = KeepAll + 1,
	/// <summary>
	/// <b>D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY</b> = ( D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS + 1 )
	/// </summary>
	CommitResultsHighPriority = CommitResults + 1,
	/// <summary>
	/// <b>D3D12_MEASUREMENTS_ACTION_DISCARD_PREVIOUS</b> = ( D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY + 1 )
	/// </summary>
	DiscardPrevious = CommitResultsHighPriority + 1,
}

/// <summary>
/// ENUM <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum RenderPassBeginningAccessType : uint {
	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD</b> = 0
	/// </summary>
	Discard = 0,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE</b> = ( D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD + 1 )
	/// </summary>
	Preserve = Discard + 1,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR</b> = ( D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE + 1 )
	/// </summary>
	Clear = Preserve + 1,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS</b> = ( D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR + 1 )
	/// </summary>
	NoAccess = Clear + 1,
}

/// <summary>
/// ENUM <b>D3D12_RENDER_PASS_ENDING_ACCESS_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum RenderPassEndingAccessType : uint {
	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_DISCARD</b> = 0
	/// </summary>
	Discard = 0,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE</b> = ( D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_DISCARD + 1 )
	/// </summary>
	Preserve = Discard + 1,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE</b> = ( D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE + 1 )
	/// </summary>
	Resolve = Preserve + 1,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_NO_ACCESS</b> = ( D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE + 1 )
	/// </summary>
	NoAccess = Resolve + 1,
}

/// <summary>
/// ENUM <b>D3D12_RENDER_PASS_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum RenderPassFlags : uint {
	/// <summary>
	/// <b>D3D12_RENDER_PASS_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES</b> = 0x1
	/// </summary>
	FlagAllowUavWrites = 1,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS</b> = 0x2
	/// </summary>
	FlagSuspendingPass = 2,
	/// <summary>
	/// <b>D3D12_RENDER_PASS_FLAG_RESUMING_PASS</b> = 0x4
	/// </summary>
	FlagResumingPass = 4,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_CACHE_MODE</b><br/>
/// D3D12.h
/// </summary>
public enum ShaderCacheMode : uint {
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_MODE_MEMORY</b> = 0
	/// </summary>
	Memory = 0,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_MODE_DISK</b> = ( D3D12_SHADER_CACHE_MODE_MEMORY + 1 )
	/// </summary>
	Disk = Memory + 1,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_CACHE_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum ShaderCacheFlags : uint {
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_FLAG_DRIVER_VERSIONED</b> = 0x1
	/// </summary>
	FlagDriverVersioned = 1,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_FLAG_USE_WORKING_DIR</b> = 0x2
	/// </summary>
	FlagUseWorkingDir = 2,
}

/// <summary>
/// ENUM <b>D3D12_BARRIER_LAYOUT</b><br/>
/// D3D12.h
/// </summary>
public enum BarrierLayout : uint {
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_UNDEFINED</b> = 0xffffffff
	/// </summary>
	Undefined = 4294967295,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COMMON</b> = 0
	/// </summary>
	Common = 0,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_PRESENT</b> = 0
	/// </summary>
	Present = 0,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_GENERIC_READ</b> = ( D3D12_BARRIER_LAYOUT_PRESENT + 1 )
	/// </summary>
	GenericRead = Present + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_RENDER_TARGET</b> = ( D3D12_BARRIER_LAYOUT_GENERIC_READ + 1 )
	/// </summary>
	RenderTarget = GenericRead + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_UNORDERED_ACCESS</b> = ( D3D12_BARRIER_LAYOUT_RENDER_TARGET + 1 )
	/// </summary>
	UnorderedAccess = RenderTarget + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_WRITE</b> = ( D3D12_BARRIER_LAYOUT_UNORDERED_ACCESS + 1 )
	/// </summary>
	DepthStencilWrite = UnorderedAccess + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_READ</b> = ( D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_WRITE + 1 )
	/// </summary>
	DepthStencilRead = DepthStencilWrite + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_SHADER_RESOURCE</b> = ( D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_READ + 1 )
	/// </summary>
	ShaderResource = DepthStencilRead + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COPY_SOURCE</b> = ( D3D12_BARRIER_LAYOUT_SHADER_RESOURCE + 1 )
	/// </summary>
	CopySource = ShaderResource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COPY_DEST</b> = ( D3D12_BARRIER_LAYOUT_COPY_SOURCE + 1 )
	/// </summary>
	CopyDest = CopySource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_RESOLVE_SOURCE</b> = ( D3D12_BARRIER_LAYOUT_COPY_DEST + 1 )
	/// </summary>
	ResolveSource = CopyDest + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_RESOLVE_DEST</b> = ( D3D12_BARRIER_LAYOUT_RESOLVE_SOURCE + 1 )
	/// </summary>
	ResolveDest = ResolveSource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_SHADING_RATE_SOURCE</b> = ( D3D12_BARRIER_LAYOUT_RESOLVE_DEST + 1 )
	/// </summary>
	ShadingRateSource = ResolveDest + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_VIDEO_DECODE_READ</b> = ( D3D12_BARRIER_LAYOUT_SHADING_RATE_SOURCE + 1 )
	/// </summary>
	VideoDecodeRead = ShadingRateSource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_VIDEO_DECODE_WRITE</b> = ( D3D12_BARRIER_LAYOUT_VIDEO_DECODE_READ + 1 )
	/// </summary>
	VideoDecodeWrite = VideoDecodeRead + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_READ</b> = ( D3D12_BARRIER_LAYOUT_VIDEO_DECODE_WRITE + 1 )
	/// </summary>
	VideoProcessRead = VideoDecodeWrite + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_WRITE</b> = ( D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_READ + 1 )
	/// </summary>
	VideoProcessWrite = VideoProcessRead + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_READ</b> = ( D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_WRITE + 1 )
	/// </summary>
	VideoEncodeRead = VideoProcessWrite + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_WRITE</b> = ( D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_READ + 1 )
	/// </summary>
	VideoEncodeWrite = VideoEncodeRead + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COMMON</b> = ( D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_WRITE + 1 )
	/// </summary>
	DirectQueueCommon = VideoEncodeWrite + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_GENERIC_READ</b> = ( D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COMMON + 1 )
	/// </summary>
	DirectQueueGenericRead = DirectQueueCommon + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_UNORDERED_ACCESS</b> = ( D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_GENERIC_READ + 1 )
	/// </summary>
	DirectQueueUnorderedAccess = DirectQueueGenericRead + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_SHADER_RESOURCE</b> = ( D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_UNORDERED_ACCESS + 1 )
	/// </summary>
	DirectQueueShaderResource = DirectQueueUnorderedAccess + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_SOURCE</b> = ( D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_SHADER_RESOURCE + 1 )
	/// </summary>
	DirectQueueCopySource = DirectQueueShaderResource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_DEST</b> = ( D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_SOURCE + 1 )
	/// </summary>
	DirectQueueCopyDest = DirectQueueCopySource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COMMON</b> = ( D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_DEST + 1 )
	/// </summary>
	ComputeQueueCommon = DirectQueueCopyDest + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_GENERIC_READ</b> = ( D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COMMON + 1 )
	/// </summary>
	ComputeQueueGenericRead = ComputeQueueCommon + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_UNORDERED_ACCESS</b> = ( D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_GENERIC_READ + 1 )
	/// </summary>
	ComputeQueueUnorderedAccess = ComputeQueueGenericRead + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_SHADER_RESOURCE</b> = ( D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_UNORDERED_ACCESS + 1 )
	/// </summary>
	ComputeQueueShaderResource = ComputeQueueUnorderedAccess + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_SOURCE</b> = ( D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_SHADER_RESOURCE + 1 )
	/// </summary>
	ComputeQueueCopySource = ComputeQueueShaderResource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_DEST</b> = ( D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_SOURCE + 1 )
	/// </summary>
	ComputeQueueCopyDest = ComputeQueueCopySource + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT_VIDEO_QUEUE_COMMON</b> = ( D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_DEST + 1 )
	/// </summary>
	VideoQueueCommon = ComputeQueueCopyDest + 1,
}

/// <summary>
/// ENUM <b>D3D12_BARRIER_SYNC</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum BarrierSync : uint {
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_ALL</b> = 0x1
	/// </summary>
	All = 1,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_DRAW</b> = 0x2
	/// </summary>
	Draw = 2,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_INPUT_ASSEMBLER</b> = 0x4
	/// </summary>
	InputAssembler = 4,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_VERTEX_SHADING</b> = 0x8
	/// </summary>
	VertexShading = 8,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_PIXEL_SHADING</b> = 0x10
	/// </summary>
	PixelShading = 16,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_DEPTH_STENCIL</b> = 0x20
	/// </summary>
	DepthStencil = 32,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_RENDER_TARGET</b> = 0x40
	/// </summary>
	RenderTarget = 64,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_COMPUTE_SHADING</b> = 0x80
	/// </summary>
	ComputeShading = 128,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_RAYTRACING</b> = 0x100
	/// </summary>
	Raytracing = 256,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_COPY</b> = 0x200
	/// </summary>
	Copy = 512,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_RESOLVE</b> = 0x400
	/// </summary>
	Resolve = 1024,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_EXECUTE_INDIRECT</b> = 0x800
	/// </summary>
	ExecuteIndirect = 2048,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_PREDICATION</b> = 0x800
	/// </summary>
	Predication = 2048,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_ALL_SHADING</b> = 0x1000
	/// </summary>
	AllShading = 4096,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_NON_PIXEL_SHADING</b> = 0x2000
	/// </summary>
	NonPixelShading = 8192,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO</b> = 0x4000
	/// </summary>
	EmitRaytracingAccelerationStructurePostbuildInfo = 16384,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_VIDEO_DECODE</b> = 0x100000
	/// </summary>
	VideoDecode = 1048576,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_VIDEO_PROCESS</b> = 0x200000
	/// </summary>
	VideoProcess = 2097152,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_VIDEO_ENCODE</b> = 0x400000
	/// </summary>
	VideoEncode = 4194304,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_BUILD_RAYTRACING_ACCELERATION_STRUCTURE</b> = 0x800000
	/// </summary>
	BuildRaytracingAccelerationStructure = 8388608,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_COPY_RAYTRACING_ACCELERATION_STRUCTURE</b> = 0x1000000
	/// </summary>
	CopyRaytracingAccelerationStructure = 16777216,
	/// <summary>
	/// <b>D3D12_BARRIER_SYNC_SPLIT</b> = 0x80000000
	/// </summary>
	Split = 2147483648,
}

/// <summary>
/// ENUM <b>D3D12_BARRIER_ACCESS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum BarrierAccess : uint {
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_COMMON</b> = 0
	/// </summary>
	Common = 0,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_VERTEX_BUFFER</b> = 0x1
	/// </summary>
	VertexBuffer = 1,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_CONSTANT_BUFFER</b> = 0x2
	/// </summary>
	ConstantBuffer = 2,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_INDEX_BUFFER</b> = 0x4
	/// </summary>
	IndexBuffer = 4,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_RENDER_TARGET</b> = 0x8
	/// </summary>
	RenderTarget = 8,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_UNORDERED_ACCESS</b> = 0x10
	/// </summary>
	UnorderedAccess = 16,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_DEPTH_STENCIL_WRITE</b> = 0x20
	/// </summary>
	DepthStencilWrite = 32,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_DEPTH_STENCIL_READ</b> = 0x40
	/// </summary>
	DepthStencilRead = 64,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_SHADER_RESOURCE</b> = 0x80
	/// </summary>
	ShaderResource = 128,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_STREAM_OUTPUT</b> = 0x100
	/// </summary>
	StreamOutput = 256,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_INDIRECT_ARGUMENT</b> = 0x200
	/// </summary>
	IndirectArgument = 512,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_PREDICATION</b> = 0x200
	/// </summary>
	Predication = 512,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_COPY_DEST</b> = 0x400
	/// </summary>
	CopyDest = 1024,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_COPY_SOURCE</b> = 0x800
	/// </summary>
	CopySource = 2048,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_RESOLVE_DEST</b> = 0x1000
	/// </summary>
	ResolveDest = 4096,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_RESOLVE_SOURCE</b> = 0x2000
	/// </summary>
	ResolveSource = 8192,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_READ</b> = 0x4000
	/// </summary>
	RaytracingAccelerationStructureRead = 16384,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_WRITE</b> = 0x8000
	/// </summary>
	RaytracingAccelerationStructureWrite = 32768,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_SHADING_RATE_SOURCE</b> = 0x10000
	/// </summary>
	ShadingRateSource = 65536,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_VIDEO_DECODE_READ</b> = 0x20000
	/// </summary>
	VideoDecodeRead = 131072,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_VIDEO_DECODE_WRITE</b> = 0x40000
	/// </summary>
	VideoDecodeWrite = 262144,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_VIDEO_PROCESS_READ</b> = 0x80000
	/// </summary>
	VideoProcessRead = 524288,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_VIDEO_PROCESS_WRITE</b> = 0x100000
	/// </summary>
	VideoProcessWrite = 1048576,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_VIDEO_ENCODE_READ</b> = 0x200000
	/// </summary>
	VideoEncodeRead = 2097152,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_VIDEO_ENCODE_WRITE</b> = 0x400000
	/// </summary>
	VideoEncodeWrite = 4194304,
	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS_NO_ACCESS</b> = 0x80000000
	/// </summary>
	NoAccess = 2147483648,
}

/// <summary>
/// ENUM <b>D3D12_BARRIER_TYPE</b><br/>
/// D3D12.h
/// </summary>
public enum BarrierType : uint {
	/// <summary>
	/// <b>D3D12_BARRIER_TYPE_GLOBAL</b> = 0
	/// </summary>
	Global = 0,
	/// <summary>
	/// <b>D3D12_BARRIER_TYPE_TEXTURE</b> = ( D3D12_BARRIER_TYPE_GLOBAL + 1 )
	/// </summary>
	Texture = Global + 1,
	/// <summary>
	/// <b>D3D12_BARRIER_TYPE_BUFFER</b> = ( D3D12_BARRIER_TYPE_TEXTURE + 1 )
	/// </summary>
	Buffer = Texture + 1,
}

/// <summary>
/// ENUM <b>D3D12_TEXTURE_BARRIER_FLAGS</b><br/>
/// D3D12.h
/// </summary>
public enum TextureBarrierFlags : uint {
	/// <summary>
	/// <b>D3D12_TEXTURE_BARRIER_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_TEXTURE_BARRIER_FLAG_DISCARD</b> = 0x1
	/// </summary>
	FlagDiscard = 1,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_CACHE_KIND_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ShaderCacheKindFlags : uint {
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CACHE_FOR_DRIVER</b> = 0x1
	/// </summary>
	FlagImplicitD3dCacheForDriver = 1,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CONVERSIONS</b> = 0x2
	/// </summary>
	FlagImplicitD3dConversions = 2,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_DRIVER_MANAGED</b> = 0x4
	/// </summary>
	FlagImplicitDriverManaged = 4,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_KIND_FLAG_APPLICATION_MANAGED</b> = 0x8
	/// </summary>
	FlagApplicationManaged = 8,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_CACHE_CONTROL_FLAGS</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum ShaderCacheControlFlags : uint {
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE</b> = 0x1
	/// </summary>
	FlagDisable = 1,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE</b> = 0x2
	/// </summary>
	FlagEnable = 2,
	/// <summary>
	/// <b>D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR</b> = 0x4
	/// </summary>
	FlagClear = 4,
}

/// <summary>
/// ENUM <b>D3D12_AXIS_SHADING_RATE</b><br/>
/// D3D12.h
/// </summary>
[Flags]
public enum AxisShadingRate : uint {
	/// <summary>
	/// <b>D3D12_AXIS_SHADING_RATE_1X</b> = 0
	/// </summary>
	Rate1X = 0,
	/// <summary>
	/// <b>D3D12_AXIS_SHADING_RATE_2X</b> = 0x1
	/// </summary>
	Rate2X = 1,
	/// <summary>
	/// <b>D3D12_AXIS_SHADING_RATE_4X</b> = 0x2
	/// </summary>
	Rate4X = 2,
}

/// <summary>
/// ENUM <b>D3D12_SHADING_RATE</b><br/>
/// D3D12.h
/// </summary>
public enum ShadingRate : uint {
	/// <summary>
	/// <b>D3D12_SHADING_RATE_1X1</b> = 0
	/// </summary>
	Rate1X1 = 0,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_1X2</b> = 0x1
	/// </summary>
	Rate1X2 = 1,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_2X1</b> = 0x4
	/// </summary>
	Rate2X1 = 4,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_2X2</b> = 0x5
	/// </summary>
	Rate2X2 = 5,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_2X4</b> = 0x6
	/// </summary>
	Rate2X4 = 6,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_4X2</b> = 0x9
	/// </summary>
	Rate4X2 = 9,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_4X4</b> = 0xa
	/// </summary>
	Rate4X4 = 10,
}

/// <summary>
/// ENUM <b>D3D12_SHADING_RATE_COMBINER</b><br/>
/// D3D12.h
/// </summary>
public enum ShadingRateCombiner : uint {
	/// <summary>
	/// <b>D3D12_SHADING_RATE_COMBINER_PASSTHROUGH</b> = 0
	/// </summary>
	Passthrough = 0,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_COMBINER_OVERRIDE</b> = 1
	/// </summary>
	Override = 1,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_COMBINER_MIN</b> = 2
	/// </summary>
	Min = 2,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_COMBINER_MAX</b> = 3
	/// </summary>
	Max = 3,
	/// <summary>
	/// <b>D3D12_SHADING_RATE_COMBINER_SUM</b> = 4
	/// </summary>
	Sum = 4,
}

/// <summary>
/// ENUM <b>D3D12_COMPATIBILITY_SHARED_FLAGS</b><br/>
/// D3D12COMPATIBILITY.h
/// </summary>
[Flags]
public enum CompatibilitySharedFlags : uint {
	/// <summary>
	/// <b>D3D12_COMPATIBILITY_SHARED_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_COMPATIBILITY_SHARED_FLAG_NON_NT_HANDLE</b> = 0x1
	/// </summary>
	FlagNonNtHandle = 1,
	/// <summary>
	/// <b>D3D12_COMPATIBILITY_SHARED_FLAG_KEYED_MUTEX</b> = 0x2
	/// </summary>
	FlagKeyedMutex = 2,
	/// <summary>
	/// <b>D3D12_COMPATIBILITY_SHARED_FLAG_9_ON_12</b> = 0x4
	/// </summary>
	Flag9On12 = 4,
}

/// <summary>
/// ENUM <b>D3D12_REFLECT_SHARED_PROPERTY</b><br/>
/// D3D12COMPATIBILITY.h
/// </summary>
public enum ReflectSharedProperty : uint {
	/// <summary>
	/// <b>D3D12_REFLECT_SHARED_PROPERTY_D3D11_RESOURCE_FLAGS</b> = 0
	/// </summary>
	D3d11ResourceFlags = 0,
	/// <summary>
	/// <b>D3D12_REFELCT_SHARED_PROPERTY_COMPATIBILITY_SHARED_FLAGS</b> = ( D3D12_REFLECT_SHARED_PROPERTY_D3D11_RESOURCE_FLAGS + 1 )
	/// </summary>
	RefelctSharedPropertyCompatibilitySharedFlags = D3d11ResourceFlags + 1,
	/// <summary>
	/// <b>D3D12_REFLECT_SHARED_PROPERTY_NON_NT_SHARED_HANDLE</b> = ( D3D12_REFELCT_SHARED_PROPERTY_COMPATIBILITY_SHARED_FLAGS + 1 )
	/// </summary>
	NonNtSharedHandle = RefelctSharedPropertyCompatibilitySharedFlags + 1,
}

/// <summary>
/// ENUM <b>D3D12_GPU_BASED_VALIDATION_FLAGS</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum GpuBasedValidationFlags : uint {
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_FLAGS_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_FLAGS_DISABLE_STATE_TRACKING</b> = 0x1
	/// </summary>
	DisableStateTracking = 1,
}

/// <summary>
/// ENUM <b>D3D12_RLDO_FLAGS</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[Flags]
public enum RldoFlags : uint {
	/// <summary>
	/// <b>D3D12_RLDO_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_RLDO_SUMMARY</b> = 0x1
	/// </summary>
	Summary = 1,
	/// <summary>
	/// <b>D3D12_RLDO_DETAIL</b> = 0x2
	/// </summary>
	Detail = 2,
	/// <summary>
	/// <b>D3D12_RLDO_IGNORE_INTERNAL</b> = 0x4
	/// </summary>
	IgnoreInternal = 4,
}

/// <summary>
/// ENUM <b>D3D12_DEBUG_DEVICE_PARAMETER_TYPE</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum DebugDeviceParameterType : uint {
	/// <summary>
	/// <b>D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS</b> = 0
	/// </summary>
	FeatureFlags = 0,
	/// <summary>
	/// <b>D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS</b> = ( D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS + 1 )
	/// </summary>
	GpuBasedValidationSettings = FeatureFlags + 1,
	/// <summary>
	/// <b>D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR</b> = ( D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS + 1 )
	/// </summary>
	GpuSlowdownPerformanceFactor = GpuBasedValidationSettings + 1,
}

/// <summary>
/// ENUM <b>D3D12_DEBUG_FEATURE</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[Flags]
public enum DebugFeature : uint {
	/// <summary>
	/// <b>D3D12_DEBUG_FEATURE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS</b> = 0x1
	/// </summary>
	AllowBehaviorChangingDebugAids = 1,
	/// <summary>
	/// <b>D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING</b> = 0x2
	/// </summary>
	ConservativeResourceStateTracking = 2,
	/// <summary>
	/// <b>D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION</b> = 0x4
	/// </summary>
	DisableVirtualizedBundlesValidation = 4,
	/// <summary>
	/// <b>D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7</b> = 0x8
	/// </summary>
	EmulateWindows7 = 8,
}

/// <summary>
/// ENUM <b>D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum GpuBasedValidationShaderPatchMode : uint {
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_STATE_TRACKING_ONLY</b> = ( D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_NONE + 1 )
	/// </summary>
	StateTrackingOnly = None + 1,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_UNGUARDED_VALIDATION</b> = ( D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_STATE_TRACKING_ONLY + 1 )
	/// </summary>
	UnguardedValidation = StateTrackingOnly + 1,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_GUARDED_VALIDATION</b> = ( D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_UNGUARDED_VALIDATION + 1 )
	/// </summary>
	GuardedValidation = UnguardedValidation + 1,
	/// <summary>
	/// <b>NUM_D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODES</b> = ( D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_GUARDED_VALIDATION + 1 )
	/// </summary>
	NumD3d12GpuBasedValidationShaderPatchModes = GuardedValidation + 1,
}

/// <summary>
/// ENUM <b>D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[Flags]
public enum GpuBasedValidationPipelineStateCreateFlags : uint {
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_TRACKING_ONLY_SHADERS</b> = 0x1
	/// </summary>
	FlagFrontLoadCreateTrackingOnlyShaders = 1,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_UNGUARDED_VALIDATION_SHADERS</b> = 0x2
	/// </summary>
	FlagFrontLoadCreateUnguardedValidationShaders = 2,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_GUARDED_VALIDATION_SHADERS</b> = 0x4
	/// </summary>
	FlagFrontLoadCreateGuardedValidationShaders = 4,
	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS_VALID_MASK</b> = 0x7
	/// </summary>
	ValidMask = 7,
}

/// <summary>
/// ENUM <b>D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum DebugCommandListParameterType : uint {
	/// <summary>
	/// <b>D3D12_DEBUG_COMMAND_LIST_PARAMETER_GPU_BASED_VALIDATION_SETTINGS</b> = 0
	/// </summary>
	GpuBasedValidationSettings = 0,
}

/// <summary>
/// ENUM <b>D3D12_MESSAGE_CATEGORY</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum MessageCategory : uint {
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED</b> = 0
	/// </summary>
	ApplicationDefined = 0,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_MISCELLANEOUS</b> = ( D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED + 1 )
	/// </summary>
	Miscellaneous = ApplicationDefined + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_INITIALIZATION</b> = ( D3D12_MESSAGE_CATEGORY_MISCELLANEOUS + 1 )
	/// </summary>
	Initialization = Miscellaneous + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_CLEANUP</b> = ( D3D12_MESSAGE_CATEGORY_INITIALIZATION + 1 )
	/// </summary>
	Cleanup = Initialization + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_COMPILATION</b> = ( D3D12_MESSAGE_CATEGORY_CLEANUP + 1 )
	/// </summary>
	Compilation = Cleanup + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_STATE_CREATION</b> = ( D3D12_MESSAGE_CATEGORY_COMPILATION + 1 )
	/// </summary>
	StateCreation = Compilation + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_STATE_SETTING</b> = ( D3D12_MESSAGE_CATEGORY_STATE_CREATION + 1 )
	/// </summary>
	StateSetting = StateCreation + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_STATE_GETTING</b> = ( D3D12_MESSAGE_CATEGORY_STATE_SETTING + 1 )
	/// </summary>
	StateGetting = StateSetting + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION</b> = ( D3D12_MESSAGE_CATEGORY_STATE_GETTING + 1 )
	/// </summary>
	ResourceManipulation = StateGetting + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_EXECUTION</b> = ( D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION + 1 )
	/// </summary>
	Execution = ResourceManipulation + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY_SHADER</b> = ( D3D12_MESSAGE_CATEGORY_EXECUTION + 1 )
	/// </summary>
	Shader = Execution + 1,
}

/// <summary>
/// ENUM <b>D3D12_MESSAGE_SEVERITY</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum MessageSeverity : uint {
	/// <summary>
	/// <b>D3D12_MESSAGE_SEVERITY_CORRUPTION</b> = 0
	/// </summary>
	Corruption = 0,
	/// <summary>
	/// <b>D3D12_MESSAGE_SEVERITY_ERROR</b> = ( D3D12_MESSAGE_SEVERITY_CORRUPTION + 1 )
	/// </summary>
	Error = Corruption + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_SEVERITY_WARNING</b> = ( D3D12_MESSAGE_SEVERITY_ERROR + 1 )
	/// </summary>
	Warning = Error + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_SEVERITY_INFO</b> = ( D3D12_MESSAGE_SEVERITY_WARNING + 1 )
	/// </summary>
	Info = Warning + 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_SEVERITY_MESSAGE</b> = ( D3D12_MESSAGE_SEVERITY_INFO + 1 )
	/// </summary>
	Message = Info + 1,
}

/// <summary>
/// ENUM <b>D3D12_MESSAGE_ID</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum MessageId : uint {
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_STRING_FROM_APPLICATION</b> = 1
	/// </summary>
	StringFromApplication = 1,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_THIS</b> = 2
	/// </summary>
	CorruptedThis = 2,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER1</b> = 3
	/// </summary>
	CorruptedParameter1 = 3,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER2</b> = 4
	/// </summary>
	CorruptedParameter2 = 4,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER3</b> = 5
	/// </summary>
	CorruptedParameter3 = 5,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER4</b> = 6
	/// </summary>
	CorruptedParameter4 = 6,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER5</b> = 7
	/// </summary>
	CorruptedParameter5 = 7,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER6</b> = 8
	/// </summary>
	CorruptedParameter6 = 8,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER7</b> = 9
	/// </summary>
	CorruptedParameter7 = 9,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER8</b> = 10
	/// </summary>
	CorruptedParameter8 = 10,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER9</b> = 11
	/// </summary>
	CorruptedParameter9 = 11,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER10</b> = 12
	/// </summary>
	CorruptedParameter10 = 12,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER11</b> = 13
	/// </summary>
	CorruptedParameter11 = 13,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER12</b> = 14
	/// </summary>
	CorruptedParameter12 = 14,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER13</b> = 15
	/// </summary>
	CorruptedParameter13 = 15,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER14</b> = 16
	/// </summary>
	CorruptedParameter14 = 16,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_PARAMETER15</b> = 17
	/// </summary>
	CorruptedParameter15 = 17,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CORRUPTED_MULTITHREADING</b> = 18
	/// </summary>
	CorruptedMultithreading = 18,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY</b> = 19
	/// </summary>
	MessageReportingOutofmemory = 19,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETPRIVATEDATA_MOREDATA</b> = 20
	/// </summary>
	GetprivatedataMoredata = 20,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA</b> = 21
	/// </summary>
	SetprivatedataInvalidfreedata = 21,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS</b> = 24
	/// </summary>
	SetprivatedataChangingparams = 24,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY</b> = 25
	/// </summary>
	SetprivatedataOutofmemory = 25,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT</b> = 26
	/// </summary>
	CreateshaderresourceviewUnrecognizedformat = 26,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC</b> = 27
	/// </summary>
	CreateshaderresourceviewInvaliddesc = 27,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT</b> = 28
	/// </summary>
	CreateshaderresourceviewInvalidformat = 28,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANESLICE</b> = 29
	/// </summary>
	CreateshaderresourceviewInvalidvideoplaneslice = 29,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANESLICE</b> = 30
	/// </summary>
	CreateshaderresourceviewInvalidplaneslice = 30,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS</b> = 31
	/// </summary>
	CreateshaderresourceviewInvaliddimensions = 31,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE</b> = 32
	/// </summary>
	CreateshaderresourceviewInvalidresource = 32,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT</b> = 35
	/// </summary>
	CreaterendertargetviewUnrecognizedformat = 35,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT</b> = 36
	/// </summary>
	CreaterendertargetviewUnsupportedformat = 36,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC</b> = 37
	/// </summary>
	CreaterendertargetviewInvaliddesc = 37,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT</b> = 38
	/// </summary>
	CreaterendertargetviewInvalidformat = 38,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANESLICE</b> = 39
	/// </summary>
	CreaterendertargetviewInvalidvideoplaneslice = 39,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANESLICE</b> = 40
	/// </summary>
	CreaterendertargetviewInvalidplaneslice = 40,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS</b> = 41
	/// </summary>
	CreaterendertargetviewInvaliddimensions = 41,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE</b> = 42
	/// </summary>
	CreaterendertargetviewInvalidresource = 42,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT</b> = 45
	/// </summary>
	CreatedepthstencilviewUnrecognizedformat = 45,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC</b> = 46
	/// </summary>
	CreatedepthstencilviewInvaliddesc = 46,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT</b> = 47
	/// </summary>
	CreatedepthstencilviewInvalidformat = 47,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS</b> = 48
	/// </summary>
	CreatedepthstencilviewInvaliddimensions = 48,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE</b> = 49
	/// </summary>
	CreatedepthstencilviewInvalidresource = 49,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY</b> = 52
	/// </summary>
	CreateinputlayoutOutofmemory = 52,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS</b> = 53
	/// </summary>
	CreateinputlayoutToomanyelements = 53,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT</b> = 54
	/// </summary>
	CreateinputlayoutInvalidformat = 54,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT</b> = 55
	/// </summary>
	CreateinputlayoutIncompatibleformat = 55,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT</b> = 56
	/// </summary>
	CreateinputlayoutInvalidslot = 56,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS</b> = 57
	/// </summary>
	CreateinputlayoutInvalidinputslotclass = 57,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH</b> = 58
	/// </summary>
	CreateinputlayoutSteprateslotclassmismatch = 58,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE</b> = 59
	/// </summary>
	CreateinputlayoutInvalidslotclasschange = 59,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE</b> = 60
	/// </summary>
	CreateinputlayoutInvalidstepratechange = 60,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT</b> = 61
	/// </summary>
	CreateinputlayoutInvalidalignment = 61,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC</b> = 62
	/// </summary>
	CreateinputlayoutDuplicatesemantic = 62,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE</b> = 63
	/// </summary>
	CreateinputlayoutUnparseableinputsignature = 63,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC</b> = 64
	/// </summary>
	CreateinputlayoutNullsemantic = 64,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT</b> = 65
	/// </summary>
	CreateinputlayoutMissingelement = 65,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY</b> = 66
	/// </summary>
	CreatevertexshaderOutofmemory = 66,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE</b> = 67
	/// </summary>
	CreatevertexshaderInvalidshaderbytecode = 67,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE</b> = 68
	/// </summary>
	CreatevertexshaderInvalidshadertype = 68,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY</b> = 69
	/// </summary>
	CreategeometryshaderOutofmemory = 69,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE</b> = 70
	/// </summary>
	CreategeometryshaderInvalidshaderbytecode = 70,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE</b> = 71
	/// </summary>
	CreategeometryshaderInvalidshadertype = 71,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY</b> = 72
	/// </summary>
	CreategeometryshaderwithstreamoutputOutofmemory = 72,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE</b> = 73
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidshaderbytecode = 73,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE</b> = 74
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidshadertype = 74,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES</b> = 75
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidnumentries = 75,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED</b> = 76
	/// </summary>
	CreategeometryshaderwithstreamoutputOutputstreamstrideunused = 76,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED</b> = 79
	/// </summary>
	CreategeometryshaderwithstreamoutputOutputslot0expected = 79,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT</b> = 80
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidoutputslot = 80,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT</b> = 81
	/// </summary>
	CreategeometryshaderwithstreamoutputOnlyoneelementperslot = 81,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT</b> = 82
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidcomponentcount = 82,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT</b> = 83
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 83,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION</b> = 84
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidgapdefinition = 84,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT</b> = 85
	/// </summary>
	CreategeometryshaderwithstreamoutputRepeatedoutput = 85,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE</b> = 86
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 86,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC</b> = 87
	/// </summary>
	CreategeometryshaderwithstreamoutputMissingsemantic = 87,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH</b> = 88
	/// </summary>
	CreategeometryshaderwithstreamoutputMaskmismatch = 88,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS</b> = 89
	/// </summary>
	CreategeometryshaderwithstreamoutputCanthaveonlygaps = 89,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX</b> = 90
	/// </summary>
	CreategeometryshaderwithstreamoutputDecltoocomplex = 90,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE</b> = 91
	/// </summary>
	CreategeometryshaderwithstreamoutputMissingoutputsignature = 91,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY</b> = 92
	/// </summary>
	CreatepixelshaderOutofmemory = 92,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE</b> = 93
	/// </summary>
	CreatepixelshaderInvalidshaderbytecode = 93,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE</b> = 94
	/// </summary>
	CreatepixelshaderInvalidshadertype = 94,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE</b> = 95
	/// </summary>
	CreaterasterizerstateInvalidfillmode = 95,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE</b> = 96
	/// </summary>
	CreaterasterizerstateInvalidcullmode = 96,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP</b> = 97
	/// </summary>
	CreaterasterizerstateInvaliddepthbiasclamp = 97,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS</b> = 98
	/// </summary>
	CreaterasterizerstateInvalidslopescaleddepthbias = 98,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK</b> = 100
	/// </summary>
	CreatedepthstencilstateInvaliddepthwritemask = 100,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC</b> = 101
	/// </summary>
	CreatedepthstencilstateInvaliddepthfunc = 101,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP</b> = 102
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilfailop = 102,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP</b> = 103
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilzfailop = 103,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP</b> = 104
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilpassop = 104,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC</b> = 105
	/// </summary>
	CreatedepthstencilstateInvalidfrontfacestencilfunc = 105,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP</b> = 106
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilfailop = 106,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP</b> = 107
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilzfailop = 107,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP</b> = 108
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilpassop = 108,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC</b> = 109
	/// </summary>
	CreatedepthstencilstateInvalidbackfacestencilfunc = 109,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND</b> = 111
	/// </summary>
	CreateblendstateInvalidsrcblend = 111,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND</b> = 112
	/// </summary>
	CreateblendstateInvaliddestblend = 112,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP</b> = 113
	/// </summary>
	CreateblendstateInvalidblendop = 113,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA</b> = 114
	/// </summary>
	CreateblendstateInvalidsrcblendalpha = 114,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA</b> = 115
	/// </summary>
	CreateblendstateInvaliddestblendalpha = 115,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA</b> = 116
	/// </summary>
	CreateblendstateInvalidblendopalpha = 116,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK</b> = 117
	/// </summary>
	CreateblendstateInvalidrendertargetwritemask = 117,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID</b> = 135
	/// </summary>
	CleardepthstencilviewInvalid = 135,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_NOT_SET</b> = 200
	/// </summary>
	CommandListDrawRootSignatureNotSet = 200,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_MISMATCH</b> = 201
	/// </summary>
	CommandListDrawRootSignatureMismatch = 201,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_NOT_SET</b> = 202
	/// </summary>
	CommandListDrawVertexBufferNotSet = 202,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL</b> = 209
	/// </summary>
	CommandListDrawVertexBufferStrideTooSmall = 209,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_TOO_SMALL</b> = 210
	/// </summary>
	CommandListDrawVertexBufferTooSmall = 210,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_NOT_SET</b> = 211
	/// </summary>
	CommandListDrawIndexBufferNotSet = 211,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_FORMAT_INVALID</b> = 212
	/// </summary>
	CommandListDrawIndexBufferFormatInvalid = 212,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_TOO_SMALL</b> = 213
	/// </summary>
	CommandListDrawIndexBufferTooSmall = 213,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INVALID_PRIMITIVETOPOLOGY</b> = 219
	/// </summary>
	CommandListDrawInvalidPrimitivetopology = 219,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_STRIDE_UNALIGNED</b> = 221
	/// </summary>
	CommandListDrawVertexStrideUnaligned = 221,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_OFFSET_UNALIGNED</b> = 222
	/// </summary>
	CommandListDrawIndexOffsetUnaligned = 222,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT</b> = 232
	/// </summary>
	DeviceRemovalProcessAtFault = 232,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT</b> = 233
	/// </summary>
	DeviceRemovalProcessPossiblyAtFault = 233,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT</b> = 234
	/// </summary>
	DeviceRemovalProcessNotAtFault = 234,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC</b> = 239
	/// </summary>
	CreateinputlayoutTrailingDigitInSemantic = 239,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC</b> = 240
	/// </summary>
	CreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 240,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH</b> = 245
	/// </summary>
	CreateinputlayoutTypeMismatch = 245,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT</b> = 253
	/// </summary>
	CreateinputlayoutEmptyLayout = 253,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_OBJECT_SUMMARY</b> = 255
	/// </summary>
	LiveObjectSummary = 255,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_DEVICE</b> = 274
	/// </summary>
	LiveDevice = 274,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_SWAPCHAIN</b> = 275
	/// </summary>
	LiveSwapchain = 275,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS</b> = 276
	/// </summary>
	CreatedepthstencilviewInvalidflags = 276,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE</b> = 277
	/// </summary>
	CreatevertexshaderInvalidclasslinkage = 277,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE</b> = 278
	/// </summary>
	CreategeometryshaderInvalidclasslinkage = 278,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER</b> = 280
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 280,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE</b> = 283
	/// </summary>
	CreatepixelshaderInvalidclasslinkage = 283,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM</b> = 284
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidstream = 284,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES</b> = 285
	/// </summary>
	CreategeometryshaderwithstreamoutputUnexpectedentries = 285,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES</b> = 286
	/// </summary>
	CreategeometryshaderwithstreamoutputUnexpectedstrides = 286,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES</b> = 287
	/// </summary>
	CreategeometryshaderwithstreamoutputInvalidnumstrides = 287,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY</b> = 289
	/// </summary>
	CreatehullshaderOutofmemory = 289,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE</b> = 290
	/// </summary>
	CreatehullshaderInvalidshaderbytecode = 290,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE</b> = 291
	/// </summary>
	CreatehullshaderInvalidshadertype = 291,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE</b> = 292
	/// </summary>
	CreatehullshaderInvalidclasslinkage = 292,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY</b> = 294
	/// </summary>
	CreatedomainshaderOutofmemory = 294,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE</b> = 295
	/// </summary>
	CreatedomainshaderInvalidshaderbytecode = 295,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE</b> = 296
	/// </summary>
	CreatedomainshaderInvalidshadertype = 296,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE</b> = 297
	/// </summary>
	CreatedomainshaderInvalidclasslinkage = 297,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED</b> = 310
	/// </summary>
	ResourceUnmapNotmapped = 310,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE</b> = 318
	/// </summary>
	DeviceCheckfeaturesupportMismatchedDataSize = 318,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY</b> = 321
	/// </summary>
	CreatecomputeshaderOutofmemory = 321,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE</b> = 322
	/// </summary>
	CreatecomputeshaderInvalidshaderbytecode = 322,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE</b> = 323
	/// </summary>
	CreatecomputeshaderInvalidclasslinkage = 323,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = 331
	/// </summary>
	DeviceCreatevertexshaderDoublefloatopsnotsupported = 331,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = 332
	/// </summary>
	DeviceCreatehullshaderDoublefloatopsnotsupported = 332,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = 333
	/// </summary>
	DeviceCreatedomainshaderDoublefloatopsnotsupported = 333,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = 334
	/// </summary>
	DeviceCreategeometryshaderDoublefloatopsnotsupported = 334,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED</b> = 335
	/// </summary>
	DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 335,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = 336
	/// </summary>
	DeviceCreatepixelshaderDoublefloatopsnotsupported = 336,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED</b> = 337
	/// </summary>
	DeviceCreatecomputeshaderDoublefloatopsnotsupported = 337,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE</b> = 340
	/// </summary>
	CreateunorderedaccessviewInvalidresource = 340,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC</b> = 341
	/// </summary>
	CreateunorderedaccessviewInvaliddesc = 341,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT</b> = 342
	/// </summary>
	CreateunorderedaccessviewInvalidformat = 342,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANESLICE</b> = 343
	/// </summary>
	CreateunorderedaccessviewInvalidvideoplaneslice = 343,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANESLICE</b> = 344
	/// </summary>
	CreateunorderedaccessviewInvalidplaneslice = 344,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS</b> = 345
	/// </summary>
	CreateunorderedaccessviewInvaliddimensions = 345,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT</b> = 346
	/// </summary>
	CreateunorderedaccessviewUnrecognizedformat = 346,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS</b> = 354
	/// </summary>
	CreateunorderedaccessviewInvalidflags = 354,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT</b> = 401
	/// </summary>
	CreaterasterizerstateInvalidforcedsamplecount = 401,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS</b> = 403
	/// </summary>
	CreateblendstateInvalidlogicops = 403,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = 410
	/// </summary>
	DeviceCreatevertexshaderDoubleextensionsnotsupported = 410,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = 412
	/// </summary>
	DeviceCreatehullshaderDoubleextensionsnotsupported = 412,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = 414
	/// </summary>
	DeviceCreatedomainshaderDoubleextensionsnotsupported = 414,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = 416
	/// </summary>
	DeviceCreategeometryshaderDoubleextensionsnotsupported = 416,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED</b> = 418
	/// </summary>
	DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 418,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = 420
	/// </summary>
	DeviceCreatepixelshaderDoubleextensionsnotsupported = 420,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED</b> = 422
	/// </summary>
	DeviceCreatecomputeshaderDoubleextensionsnotsupported = 422,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED</b> = 425
	/// </summary>
	DeviceCreatevertexshaderUavsnotsupported = 425,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED</b> = 426
	/// </summary>
	DeviceCreatehullshaderUavsnotsupported = 426,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED</b> = 427
	/// </summary>
	DeviceCreatedomainshaderUavsnotsupported = 427,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED</b> = 428
	/// </summary>
	DeviceCreategeometryshaderUavsnotsupported = 428,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED</b> = 429
	/// </summary>
	DeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 429,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED</b> = 430
	/// </summary>
	DeviceCreatepixelshaderUavsnotsupported = 430,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED</b> = 431
	/// </summary>
	DeviceCreatecomputeshaderUavsnotsupported = 431,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT</b> = 447
	/// </summary>
	DeviceClearviewInvalidsourcerect = 447,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT</b> = 448
	/// </summary>
	DeviceClearviewEmptyrect = 448,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER</b> = 493
	/// </summary>
	UpdatetilemappingsInvalidParameter = 493,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER</b> = 494
	/// </summary>
	CopytilemappingsInvalidParameter = 494,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEVICE_INVALIDARGS</b> = 506
	/// </summary>
	CreatedeviceInvalidargs = 506,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEVICE_WARNING</b> = 507
	/// </summary>
	CreatedeviceWarning = 507,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_TYPE</b> = 519
	/// </summary>
	ResourceBarrierInvalidType = 519,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_NULL_POINTER</b> = 520
	/// </summary>
	ResourceBarrierNullPointer = 520,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SUBRESOURCE</b> = 521
	/// </summary>
	ResourceBarrierInvalidSubresource = 521,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_RESERVED_BITS</b> = 522
	/// </summary>
	ResourceBarrierReservedBits = 522,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISSING_BIND_FLAGS</b> = 523
	/// </summary>
	ResourceBarrierMissingBindFlags = 523,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_MISC_FLAGS</b> = 524
	/// </summary>
	ResourceBarrierMismatchingMiscFlags = 524,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_MATCHING_STATES</b> = 525
	/// </summary>
	ResourceBarrierMatchingStates = 525,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINATION</b> = 526
	/// </summary>
	ResourceBarrierInvalidCombination = 526,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_BEFORE_AFTER_MISMATCH</b> = 527
	/// </summary>
	ResourceBarrierBeforeAfterMismatch = 527,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_RESOURCE</b> = 528
	/// </summary>
	ResourceBarrierInvalidResource = 528,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_SAMPLE_COUNT</b> = 529
	/// </summary>
	ResourceBarrierSampleCount = 529,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS</b> = 530
	/// </summary>
	ResourceBarrierInvalidFlags = 530,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINED_FLAGS</b> = 531
	/// </summary>
	ResourceBarrierInvalidCombinedFlags = 531,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS_FOR_FORMAT</b> = 532
	/// </summary>
	ResourceBarrierInvalidFlagsForFormat = 532,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SPLIT_BARRIER</b> = 533
	/// </summary>
	ResourceBarrierInvalidSplitBarrier = 533,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_END</b> = 534
	/// </summary>
	ResourceBarrierUnmatchedEnd = 534,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_BEGIN</b> = 535
	/// </summary>
	ResourceBarrierUnmatchedBegin = 535,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAG</b> = 536
	/// </summary>
	ResourceBarrierInvalidFlag = 536,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMMAND_LIST_TYPE</b> = 537
	/// </summary>
	ResourceBarrierInvalidCommandListType = 537,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INVALID_SUBRESOURCE_STATE</b> = 538
	/// </summary>
	InvalidSubresourceState = 538,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CONTENTION</b> = 540
	/// </summary>
	CommandAllocatorContention = 540,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET</b> = 541
	/// </summary>
	CommandAllocatorReset = 541,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET_BUNDLE</b> = 542
	/// </summary>
	CommandAllocatorResetBundle = 542,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CANNOT_RESET</b> = 543
	/// </summary>
	CommandAllocatorCannotReset = 543,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_OPEN</b> = 544
	/// </summary>
	CommandListOpen = 544,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INVALID_BUNDLE_API</b> = 546
	/// </summary>
	InvalidBundleApi = 546,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_CLOSED</b> = 547
	/// </summary>
	CommandListClosed = 547,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRONG_COMMAND_ALLOCATOR_TYPE</b> = 549
	/// </summary>
	WrongCommandAllocatorType = 549,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_SYNC</b> = 552
	/// </summary>
	CommandAllocatorSync = 552,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_SYNC</b> = 553
	/// </summary>
	CommandListSync = 553,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_DESCRIPTOR_HEAP_INVALID</b> = 554
	/// </summary>
	SetDescriptorHeapInvalid = 554,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMANDQUEUE</b> = 557
	/// </summary>
	CreateCommandqueue = 557,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMANDALLOCATOR</b> = 558
	/// </summary>
	CreateCommandallocator = 558,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_PIPELINESTATE</b> = 559
	/// </summary>
	CreatePipelinestate = 559,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMANDLIST12</b> = 560
	/// </summary>
	CreateCommandlist12 = 560,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_RESOURCE</b> = 562
	/// </summary>
	CreateResource = 562,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_DESCRIPTORHEAP</b> = 563
	/// </summary>
	CreateDescriptorheap = 563,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_ROOTSIGNATURE</b> = 564
	/// </summary>
	CreateRootsignature = 564,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_LIBRARY</b> = 565
	/// </summary>
	CreateLibrary = 565,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_HEAP</b> = 566
	/// </summary>
	CreateHeap = 566,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_MONITOREDFENCE</b> = 567
	/// </summary>
	CreateMonitoredfence = 567,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_QUERYHEAP</b> = 568
	/// </summary>
	CreateQueryheap = 568,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMANDSIGNATURE</b> = 569
	/// </summary>
	CreateCommandsignature = 569,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_COMMANDQUEUE</b> = 570
	/// </summary>
	LiveCommandqueue = 570,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_COMMANDALLOCATOR</b> = 571
	/// </summary>
	LiveCommandallocator = 571,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_PIPELINESTATE</b> = 572
	/// </summary>
	LivePipelinestate = 572,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_COMMANDLIST12</b> = 573
	/// </summary>
	LiveCommandlist12 = 573,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_RESOURCE</b> = 575
	/// </summary>
	LiveResource = 575,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_DESCRIPTORHEAP</b> = 576
	/// </summary>
	LiveDescriptorheap = 576,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_ROOTSIGNATURE</b> = 577
	/// </summary>
	LiveRootsignature = 577,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_LIBRARY</b> = 578
	/// </summary>
	LiveLibrary = 578,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_HEAP</b> = 579
	/// </summary>
	LiveHeap = 579,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_MONITOREDFENCE</b> = 580
	/// </summary>
	LiveMonitoredfence = 580,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_QUERYHEAP</b> = 581
	/// </summary>
	LiveQueryheap = 581,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_COMMANDSIGNATURE</b> = 582
	/// </summary>
	LiveCommandsignature = 582,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_COMMANDQUEUE</b> = 583
	/// </summary>
	DestroyCommandqueue = 583,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_COMMANDALLOCATOR</b> = 584
	/// </summary>
	DestroyCommandallocator = 584,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_PIPELINESTATE</b> = 585
	/// </summary>
	DestroyPipelinestate = 585,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_COMMANDLIST12</b> = 586
	/// </summary>
	DestroyCommandlist12 = 586,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_RESOURCE</b> = 588
	/// </summary>
	DestroyResource = 588,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_DESCRIPTORHEAP</b> = 589
	/// </summary>
	DestroyDescriptorheap = 589,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_ROOTSIGNATURE</b> = 590
	/// </summary>
	DestroyRootsignature = 590,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_LIBRARY</b> = 591
	/// </summary>
	DestroyLibrary = 591,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_HEAP</b> = 592
	/// </summary>
	DestroyHeap = 592,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_MONITOREDFENCE</b> = 593
	/// </summary>
	DestroyMonitoredfence = 593,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_QUERYHEAP</b> = 594
	/// </summary>
	DestroyQueryheap = 594,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_COMMANDSIGNATURE</b> = 595
	/// </summary>
	DestroyCommandsignature = 595,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONS</b> = 597
	/// </summary>
	CreateresourceInvaliddimensions = 597,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMISCFLAGS</b> = 599
	/// </summary>
	CreateresourceInvalidmiscflags = 599,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDARG_RETURN</b> = 602
	/// </summary>
	CreateresourceInvalidargReturn = 602,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_OUTOFMEMORY_RETURN</b> = 603
	/// </summary>
	CreateresourceOutofmemoryReturn = 603,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDESC</b> = 604
	/// </summary>
	CreateresourceInvaliddesc = 604,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_POSSIBLY_INVALID_SUBRESOURCE_STATE</b> = 607
	/// </summary>
	PossiblyInvalidSubresourceState = 607,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INVALID_USE_OF_NON_RESIDENT_RESOURCE</b> = 608
	/// </summary>
	InvalidUseOfNonResidentResource = 608,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_POSSIBLE_INVALID_USE_OF_NON_RESIDENT_RESOURCE</b> = 609
	/// </summary>
	PossibleInvalidUseOfNonResidentResource = 609,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_BUNDLE_PIPELINE_STATE_MISMATCH</b> = 610
	/// </summary>
	BundlePipelineStateMismatch = 610,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_MISMATCH_PIPELINE_STATE</b> = 611
	/// </summary>
	PrimitiveTopologyMismatchPipelineState = 611,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_TARGET_FORMAT_MISMATCH_PIPELINE_STATE</b> = 613
	/// </summary>
	RenderTargetFormatMismatchPipelineState = 613,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_TARGET_SAMPLE_DESC_MISMATCH_PIPELINE_STATE</b> = 614
	/// </summary>
	RenderTargetSampleDescMismatchPipelineState = 614,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEPTH_STENCIL_FORMAT_MISMATCH_PIPELINE_STATE</b> = 615
	/// </summary>
	DepthStencilFormatMismatchPipelineState = 615,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEPTH_STENCIL_SAMPLE_DESC_MISMATCH_PIPELINE_STATE</b> = 616
	/// </summary>
	DepthStencilSampleDescMismatchPipelineState = 616,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADER_INVALIDBYTECODE</b> = 622
	/// </summary>
	CreateshaderInvalidbytecode = 622,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_NULLDESC</b> = 623
	/// </summary>
	CreateheapNulldesc = 623,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_INVALIDSIZE</b> = 624
	/// </summary>
	CreateheapInvalidsize = 624,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDHEAPTYPE</b> = 625
	/// </summary>
	CreateheapUnrecognizedheaptype = 625,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES</b> = 626
	/// </summary>
	CreateheapUnrecognizedcpupageproperties = 626,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMEMORYPOOL</b> = 627
	/// </summary>
	CreateheapUnrecognizedmemorypool = 627,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_INVALIDPROPERTIES</b> = 628
	/// </summary>
	CreateheapInvalidproperties = 628,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_INVALIDALIGNMENT</b> = 629
	/// </summary>
	CreateheapInvalidalignment = 629,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMISCFLAGS</b> = 630
	/// </summary>
	CreateheapUnrecognizedmiscflags = 630,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_INVALIDMISCFLAGS</b> = 631
	/// </summary>
	CreateheapInvalidmiscflags = 631,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_INVALIDARG_RETURN</b> = 632
	/// </summary>
	CreateheapInvalidargReturn = 632,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEHEAP_OUTOFMEMORY_RETURN</b> = 633
	/// </summary>
	CreateheapOutofmemoryReturn = 633,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAPPROPERTIES</b> = 634
	/// </summary>
	CreateresourceandheapNullheapproperties = 634,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPTYPE</b> = 635
	/// </summary>
	CreateresourceandheapUnrecognizedheaptype = 635,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES</b> = 636
	/// </summary>
	CreateresourceandheapUnrecognizedcpupageproperties = 636,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDMEMORYPOOL</b> = 637
	/// </summary>
	CreateresourceandheapUnrecognizedmemorypool = 637,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPPROPERTIES</b> = 638
	/// </summary>
	CreateresourceandheapInvalidheapproperties = 638,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPMISCFLAGS</b> = 639
	/// </summary>
	CreateresourceandheapUnrecognizedheapmiscflags = 639,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPMISCFLAGS</b> = 640
	/// </summary>
	CreateresourceandheapInvalidheapmiscflags = 640,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDARG_RETURN</b> = 641
	/// </summary>
	CreateresourceandheapInvalidargReturn = 641,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_OUTOFMEMORY_RETURN</b> = 642
	/// </summary>
	CreateresourceandheapOutofmemoryReturn = 642,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_UNRECOGNIZEDHEAPTYPE</b> = 643
	/// </summary>
	GetcustomheappropertiesUnrecognizedheaptype = 643,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_INVALIDHEAPTYPE</b> = 644
	/// </summary>
	GetcustomheappropertiesInvalidheaptype = 644,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_INVALID_DESC</b> = 645
	/// </summary>
	CreateDescriptorHeapInvalidDesc = 645,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INVALID_DESCRIPTOR_HANDLE</b> = 646
	/// </summary>
	InvalidDescriptorHandle = 646,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE</b> = 647
	/// </summary>
	CreaterasterizerstateInvalidConservativerastermode = 647,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_RESOURCE</b> = 649
	/// </summary>
	CreateConstantBufferViewInvalidResource = 649,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_DESC</b> = 650
	/// </summary>
	CreateConstantBufferViewInvalidDesc = 650,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_UNORDEREDACCESS_VIEW_INVALID_COUNTER_USAGE</b> = 652
	/// </summary>
	CreateUnorderedaccessViewInvalidCounterUsage = 652,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPY_DESCRIPTORS_INVALID_RANGES</b> = 653
	/// </summary>
	CopyDescriptorsInvalidRanges = 653,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPY_DESCRIPTORS_WRITE_ONLY_DESCRIPTOR</b> = 654
	/// </summary>
	CopyDescriptorsWriteOnlyDescriptor = 654,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RTV_FORMAT_NOT_UNKNOWN</b> = 655
	/// </summary>
	CreategraphicspipelinestateRtvFormatNotUnknown = 655,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_RENDER_TARGET_COUNT</b> = 656
	/// </summary>
	CreategraphicspipelinestateInvalidRenderTargetCount = 656,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VERTEX_SHADER_NOT_SET</b> = 657
	/// </summary>
	CreategraphicspipelinestateVertexShaderNotSet = 657,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_NOT_SET</b> = 658
	/// </summary>
	CreategraphicspipelinestateInputlayoutNotSet = 658,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_HS_DS_SIGNATURE_MISMATCH</b> = 659
	/// </summary>
	CreategraphicspipelinestateShaderLinkageHsDsSignatureMismatch = 659,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERINDEX</b> = 660
	/// </summary>
	CreategraphicspipelinestateShaderLinkageRegisterindex = 660,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_COMPONENTTYPE</b> = 661
	/// </summary>
	CreategraphicspipelinestateShaderLinkageComponenttype = 661,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERMASK</b> = 662
	/// </summary>
	CreategraphicspipelinestateShaderLinkageRegistermask = 662,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SYSTEMVALUE</b> = 663
	/// </summary>
	CreategraphicspipelinestateShaderLinkageSystemvalue = 663,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS</b> = 664
	/// </summary>
	CreategraphicspipelinestateShaderLinkageNeverwrittenAlwaysreads = 664,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_MINPRECISION</b> = 665
	/// </summary>
	CreategraphicspipelinestateShaderLinkageMinprecision = 665,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND</b> = 666
	/// </summary>
	CreategraphicspipelinestateShaderLinkageSemanticnameNotFound = 666,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_XOR_DS_MISMATCH</b> = 667
	/// </summary>
	CreategraphicspipelinestateHsXorDsMismatch = 667,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH</b> = 668
	/// </summary>
	CreategraphicspipelinestateHullShaderInputTopologyMismatch = 668,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_CONTROL_POINT_COUNT_MISMATCH</b> = 669
	/// </summary>
	CreategraphicspipelinestateHsDsControlPointCountMismatch = 669,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_TESSELLATOR_DOMAIN_MISMATCH</b> = 670
	/// </summary>
	CreategraphicspipelinestateHsDsTessellatorDomainMismatch = 670,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN</b> = 671
	/// </summary>
	CreategraphicspipelinestateInvalidUseOfCenterMultisamplePattern = 671,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_FORCED_SAMPLE_COUNT</b> = 672
	/// </summary>
	CreategraphicspipelinestateInvalidUseOfForcedSampleCount = 672,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_PRIMITIVETOPOLOGY</b> = 673
	/// </summary>
	CreategraphicspipelinestateInvalidPrimitivetopology = 673,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SYSTEMVALUE</b> = 674
	/// </summary>
	CreategraphicspipelinestateInvalidSystemvalue = 674,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0</b> = 675
	/// </summary>
	CreategraphicspipelinestateOmDualSourceBlendingCanOnlyHaveRenderTarget0 = 675,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING</b> = 676
	/// </summary>
	CreategraphicspipelinestateOmRenderTargetDoesNotSupportBlending = 676,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_TYPE_MISMATCH</b> = 677
	/// </summary>
	CreategraphicspipelinestatePsOutputTypeMismatch = 677,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS</b> = 678
	/// </summary>
	CreategraphicspipelinestateOmRenderTargetDoesNotSupportLogicOps = 678,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDERTARGETVIEW_NOT_SET</b> = 679
	/// </summary>
	CreategraphicspipelinestateRendertargetviewNotSet = 679,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DEPTHSTENCILVIEW_NOT_SET</b> = 680
	/// </summary>
	CreategraphicspipelinestateDepthstencilviewNotSet = 680,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_INPUT_PRIMITIVE_MISMATCH</b> = 681
	/// </summary>
	CreategraphicspipelinestateGsInputPrimitiveMismatch = 681,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_POSITION_NOT_PRESENT</b> = 682
	/// </summary>
	CreategraphicspipelinestatePositionNotPresent = 682,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE_FLAGS</b> = 683
	/// </summary>
	CreategraphicspipelinestateMissingRootSignatureFlags = 683,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_INDEX_BUFFER_PROPERTIES</b> = 684
	/// </summary>
	CreategraphicspipelinestateInvalidIndexBufferProperties = 684,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SAMPLE_DESC</b> = 685
	/// </summary>
	CreategraphicspipelinestateInvalidSampleDesc = 685,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_ROOT_SIGNATURE_MISMATCH</b> = 686
	/// </summary>
	CreategraphicspipelinestateHsRootSignatureMismatch = 686,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DS_ROOT_SIGNATURE_MISMATCH</b> = 687
	/// </summary>
	CreategraphicspipelinestateDsRootSignatureMismatch = 687,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VS_ROOT_SIGNATURE_MISMATCH</b> = 688
	/// </summary>
	CreategraphicspipelinestateVsRootSignatureMismatch = 688,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_ROOT_SIGNATURE_MISMATCH</b> = 689
	/// </summary>
	CreategraphicspipelinestateGsRootSignatureMismatch = 689,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_ROOT_SIGNATURE_MISMATCH</b> = 690
	/// </summary>
	CreategraphicspipelinestatePsRootSignatureMismatch = 690,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE</b> = 691
	/// </summary>
	CreategraphicspipelinestateMissingRootSignature = 691,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTE_BUNDLE_OPEN_BUNDLE</b> = 692
	/// </summary>
	ExecuteBundleOpenBundle = 692,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTE_BUNDLE_DESCRIPTOR_HEAP_MISMATCH</b> = 693
	/// </summary>
	ExecuteBundleDescriptorHeapMismatch = 693,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTE_BUNDLE_TYPE</b> = 694
	/// </summary>
	ExecuteBundleType = 694,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DRAW_EMPTY_SCISSOR_RECTANGLE</b> = 695
	/// </summary>
	DrawEmptyScissorRectangle = 695,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_BLOB_NOT_FOUND</b> = 696
	/// </summary>
	CreateRootSignatureBlobNotFound = 696,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_DESERIALIZE_FAILED</b> = 697
	/// </summary>
	CreateRootSignatureDeserializeFailed = 697,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_INVALID_CONFIGURATION</b> = 698
	/// </summary>
	CreateRootSignatureInvalidConfiguration = 698,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_SUPPORTED_ON_DEVICE</b> = 699
	/// </summary>
	CreateRootSignatureNotSupportedOnDevice = 699,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLRESOURCEPROPERTIES</b> = 700
	/// </summary>
	CreateresourceandheapNullresourceproperties = 700,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAP</b> = 701
	/// </summary>
	CreateresourceandheapNullheap = 701,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETRESOURCEALLOCATIONINFO_INVALIDRDESCS</b> = 702
	/// </summary>
	GetresourceallocationinfoInvalidrdescs = 702,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAKERESIDENT_NULLOBJECTARRAY</b> = 703
	/// </summary>
	MakeresidentNullobjectarray = 703,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EVICT_NULLOBJECTARRAY</b> = 705
	/// </summary>
	EvictNullobjectarray = 705,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_DESCRIPTOR_TABLE_INVALID</b> = 708
	/// </summary>
	SetDescriptorTableInvalid = 708,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_INVALID</b> = 709
	/// </summary>
	SetRootConstantInvalid = 709,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_BUFFER_VIEW_INVALID</b> = 710
	/// </summary>
	SetRootConstantBufferViewInvalid = 710,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_ROOT_SHADER_RESOURCE_VIEW_INVALID</b> = 711
	/// </summary>
	SetRootShaderResourceViewInvalid = 711,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_ROOT_UNORDERED_ACCESS_VIEW_INVALID</b> = 712
	/// </summary>
	SetRootUnorderedAccessViewInvalid = 712,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID_DESC</b> = 713
	/// </summary>
	SetVertexBuffersInvalidDesc = 713,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID_DESC</b> = 715
	/// </summary>
	SetIndexBufferInvalidDesc = 715,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID_DESC</b> = 717
	/// </summary>
	SetStreamOutputBuffersInvalidDesc = 717,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDDIMENSIONALITY</b> = 718
	/// </summary>
	CreateresourceUnrecognizeddimensionality = 718,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDLAYOUT</b> = 719
	/// </summary>
	CreateresourceUnrecognizedlayout = 719,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONALITY</b> = 720
	/// </summary>
	CreateresourceInvaliddimensionality = 720,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT</b> = 721
	/// </summary>
	CreateresourceInvalidalignment = 721,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMIPLEVELS</b> = 722
	/// </summary>
	CreateresourceInvalidmiplevels = 722,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDSAMPLEDESC</b> = 723
	/// </summary>
	CreateresourceInvalidsampledesc = 723,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDLAYOUT</b> = 724
	/// </summary>
	CreateresourceInvalidlayout = 724,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID</b> = 725
	/// </summary>
	SetIndexBufferInvalid = 725,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID</b> = 726
	/// </summary>
	SetVertexBuffersInvalid = 726,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID</b> = 727
	/// </summary>
	SetStreamOutputBuffersInvalid = 727,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_RENDER_TARGETS_INVALID</b> = 728
	/// </summary>
	SetRenderTargetsInvalid = 728,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEQUERY_HEAP_INVALID_PARAMETERS</b> = 729
	/// </summary>
	CreatequeryHeapInvalidParameters = 729,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_BEGIN_END_QUERY_INVALID_PARAMETERS</b> = 731
	/// </summary>
	BeginEndQueryInvalidParameters = 731,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CLOSE_COMMAND_LIST_OPEN_QUERY</b> = 732
	/// </summary>
	CloseCommandListOpenQuery = 732,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVE_QUERY_DATA_INVALID_PARAMETERS</b> = 733
	/// </summary>
	ResolveQueryDataInvalidParameters = 733,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_PREDICATION_INVALID_PARAMETERS</b> = 734
	/// </summary>
	SetPredicationInvalidParameters = 734,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_TIMESTAMPS_NOT_SUPPORTED</b> = 735
	/// </summary>
	TimestampsNotSupported = 735,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDFORMAT</b> = 737
	/// </summary>
	CreateresourceUnrecognizedformat = 737,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDFORMAT</b> = 738
	/// </summary>
	CreateresourceInvalidformat = 738,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDSUBRESOURCERANGE</b> = 739
	/// </summary>
	GetcopyablefootprintsInvalidsubresourcerange = 739,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDBASEOFFSET</b> = 740
	/// </summary>
	GetcopyablefootprintsInvalidbaseoffset = 740,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDSUBRESOURCERANGE</b> = 739
	/// </summary>
	GetcopyablelayoutInvalidsubresourcerange = 739,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDBASEOFFSET</b> = 740
	/// </summary>
	GetcopyablelayoutInvalidbaseoffset = 740,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_HEAP</b> = 741
	/// </summary>
	ResourceBarrierInvalidHeap = 741,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_SAMPLER_INVALID</b> = 742
	/// </summary>
	CreateSamplerInvalid = 742,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMMANDSIGNATURE_INVALID</b> = 743
	/// </summary>
	CreatecommandsignatureInvalid = 743,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTE_INDIRECT_INVALID_PARAMETERS</b> = 744
	/// </summary>
	ExecuteIndirectInvalidParameters = 744,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_RESOURCE_DIMENSION</b> = 745
	/// </summary>
	GetgpuvirtualaddressInvalidResourceDimension = 745,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUE</b> = 815
	/// </summary>
	CreateresourceInvalidclearvalue = 815,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDCLEARVALUEFORMAT</b> = 816
	/// </summary>
	CreateresourceUnrecognizedclearvalueformat = 816,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUEFORMAT</b> = 817
	/// </summary>
	CreateresourceInvalidclearvalueformat = 817,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_CLEARVALUEDENORMFLUSH</b> = 818
	/// </summary>
	CreateresourceClearvaluedenormflush = 818,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CLEARRENDERTARGETVIEW_MISMATCHINGCLEARVALUE</b> = 820
	/// </summary>
	ClearrendertargetviewMismatchingclearvalue = 820,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_MISMATCHINGCLEARVALUE</b> = 821
	/// </summary>
	CleardepthstencilviewMismatchingclearvalue = 821,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_INVALIDHEAP</b> = 822
	/// </summary>
	MapInvalidheap = 822,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNMAP_INVALIDHEAP</b> = 823
	/// </summary>
	UnmapInvalidheap = 823,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_INVALIDRESOURCE</b> = 824
	/// </summary>
	MapInvalidresource = 824,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNMAP_INVALIDRESOURCE</b> = 825
	/// </summary>
	UnmapInvalidresource = 825,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_INVALIDSUBRESOURCE</b> = 826
	/// </summary>
	MapInvalidsubresource = 826,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNMAP_INVALIDSUBRESOURCE</b> = 827
	/// </summary>
	UnmapInvalidsubresource = 827,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_INVALIDRANGE</b> = 828
	/// </summary>
	MapInvalidrange = 828,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNMAP_INVALIDRANGE</b> = 829
	/// </summary>
	UnmapInvalidrange = 829,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_INVALIDDATAPOINTER</b> = 832
	/// </summary>
	MapInvaliddatapointer = 832,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_INVALIDARG_RETURN</b> = 833
	/// </summary>
	MapInvalidargReturn = 833,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_OUTOFMEMORY_RETURN</b> = 834
	/// </summary>
	MapOutofmemoryReturn = 834,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_BUNDLENOTSUPPORTED</b> = 835
	/// </summary>
	ExecutecommandlistsBundlenotsupported = 835,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_COMMANDLISTMISMATCH</b> = 836
	/// </summary>
	ExecutecommandlistsCommandlistmismatch = 836,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_OPENCOMMANDLIST</b> = 837
	/// </summary>
	ExecutecommandlistsOpencommandlist = 837,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_FAILEDCOMMANDLIST</b> = 838
	/// </summary>
	ExecutecommandlistsFailedcommandlist = 838,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLDST</b> = 839
	/// </summary>
	CopybufferregionNulldst = 839,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDDSTRESOURCEDIMENSION</b> = 840
	/// </summary>
	CopybufferregionInvaliddstresourcedimension = 840,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_DSTRANGEOUTOFBOUNDS</b> = 841
	/// </summary>
	CopybufferregionDstrangeoutofbounds = 841,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLSRC</b> = 842
	/// </summary>
	CopybufferregionNullsrc = 842,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDSRCRESOURCEDIMENSION</b> = 843
	/// </summary>
	CopybufferregionInvalidsrcresourcedimension = 843,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_SRCRANGEOUTOFBOUNDS</b> = 844
	/// </summary>
	CopybufferregionSrcrangeoutofbounds = 844,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDCOPYFLAGS</b> = 845
	/// </summary>
	CopybufferregionInvalidcopyflags = 845,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLDST</b> = 846
	/// </summary>
	CopytextureregionNulldst = 846,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTTYPE</b> = 847
	/// </summary>
	CopytextureregionUnrecognizeddsttype = 847,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCEDIMENSION</b> = 848
	/// </summary>
	CopytextureregionInvaliddstresourcedimension = 848,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCE</b> = 849
	/// </summary>
	CopytextureregionInvaliddstresource = 849,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTSUBRESOURCE</b> = 850
	/// </summary>
	CopytextureregionInvaliddstsubresource = 850,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTOFFSET</b> = 851
	/// </summary>
	CopytextureregionInvaliddstoffset = 851,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTFORMAT</b> = 852
	/// </summary>
	CopytextureregionUnrecognizeddstformat = 852,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTFORMAT</b> = 853
	/// </summary>
	CopytextureregionInvaliddstformat = 853,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDIMENSIONS</b> = 854
	/// </summary>
	CopytextureregionInvaliddstdimensions = 854,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTROWPITCH</b> = 855
	/// </summary>
	CopytextureregionInvaliddstrowpitch = 855,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTPLACEMENT</b> = 856
	/// </summary>
	CopytextureregionInvaliddstplacement = 856,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDSPLACEDFOOTPRINTFORMAT</b> = 857
	/// </summary>
	CopytextureregionInvaliddstdsplacedfootprintformat = 857,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_DSTREGIONOUTOFBOUNDS</b> = 858
	/// </summary>
	CopytextureregionDstregionoutofbounds = 858,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLSRC</b> = 859
	/// </summary>
	CopytextureregionNullsrc = 859,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCTYPE</b> = 860
	/// </summary>
	CopytextureregionUnrecognizedsrctype = 860,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCEDIMENSION</b> = 861
	/// </summary>
	CopytextureregionInvalidsrcresourcedimension = 861,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCE</b> = 862
	/// </summary>
	CopytextureregionInvalidsrcresource = 862,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCSUBRESOURCE</b> = 863
	/// </summary>
	CopytextureregionInvalidsrcsubresource = 863,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCOFFSET</b> = 864
	/// </summary>
	CopytextureregionInvalidsrcoffset = 864,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCFORMAT</b> = 865
	/// </summary>
	CopytextureregionUnrecognizedsrcformat = 865,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCFORMAT</b> = 866
	/// </summary>
	CopytextureregionInvalidsrcformat = 866,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDIMENSIONS</b> = 867
	/// </summary>
	CopytextureregionInvalidsrcdimensions = 867,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCROWPITCH</b> = 868
	/// </summary>
	CopytextureregionInvalidsrcrowpitch = 868,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCPLACEMENT</b> = 869
	/// </summary>
	CopytextureregionInvalidsrcplacement = 869,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDSPLACEDFOOTPRINTFORMAT</b> = 870
	/// </summary>
	CopytextureregionInvalidsrcdsplacedfootprintformat = 870,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_SRCREGIONOUTOFBOUNDS</b> = 871
	/// </summary>
	CopytextureregionSrcregionoutofbounds = 871,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTCOORDINATES</b> = 872
	/// </summary>
	CopytextureregionInvaliddstcoordinates = 872,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCBOX</b> = 873
	/// </summary>
	CopytextureregionInvalidsrcbox = 873,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_FORMATMISMATCH</b> = 874
	/// </summary>
	CopytextureregionFormatmismatch = 874,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_EMPTYBOX</b> = 875
	/// </summary>
	CopytextureregionEmptybox = 875,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDCOPYFLAGS</b> = 876
	/// </summary>
	CopytextureregionInvalidcopyflags = 876,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SUBRESOURCE_INDEX</b> = 877
	/// </summary>
	ResolvesubresourceInvalidSubresourceIndex = 877,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_FORMAT</b> = 878
	/// </summary>
	ResolvesubresourceInvalidFormat = 878,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_MISMATCH</b> = 879
	/// </summary>
	ResolvesubresourceResourceMismatch = 879,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SAMPLE_COUNT</b> = 880
	/// </summary>
	ResolvesubresourceInvalidSampleCount = 880,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_INVALID_SHADER</b> = 881
	/// </summary>
	CreatecomputepipelinestateInvalidShader = 881,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_CS_ROOT_SIGNATURE_MISMATCH</b> = 882
	/// </summary>
	CreatecomputepipelinestateCsRootSignatureMismatch = 882,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_MISSING_ROOT_SIGNATURE</b> = 883
	/// </summary>
	CreatecomputepipelinestateMissingRootSignature = 883,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALIDCACHEDBLOB</b> = 884
	/// </summary>
	CreatepipelinestateInvalidcachedblob = 884,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBADAPTERMISMATCH</b> = 885
	/// </summary>
	CreatepipelinestateCachedblobadaptermismatch = 885,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDRIVERVERSIONMISMATCH</b> = 886
	/// </summary>
	CreatepipelinestateCachedblobdriverversionmismatch = 886,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDESCMISMATCH</b> = 887
	/// </summary>
	CreatepipelinestateCachedblobdescmismatch = 887,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBIGNORED</b> = 888
	/// </summary>
	CreatepipelinestateCachedblobignored = 888,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDHEAP</b> = 889
	/// </summary>
	WritetosubresourceInvalidheap = 889,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDRESOURCE</b> = 890
	/// </summary>
	WritetosubresourceInvalidresource = 890,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDBOX</b> = 891
	/// </summary>
	WritetosubresourceInvalidbox = 891,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDSUBRESOURCE</b> = 892
	/// </summary>
	WritetosubresourceInvalidsubresource = 892,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_EMPTYBOX</b> = 893
	/// </summary>
	WritetosubresourceEmptybox = 893,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDHEAP</b> = 894
	/// </summary>
	ReadfromsubresourceInvalidheap = 894,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDRESOURCE</b> = 895
	/// </summary>
	ReadfromsubresourceInvalidresource = 895,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDBOX</b> = 896
	/// </summary>
	ReadfromsubresourceInvalidbox = 896,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDSUBRESOURCE</b> = 897
	/// </summary>
	ReadfromsubresourceInvalidsubresource = 897,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_READFROMSUBRESOURCE_EMPTYBOX</b> = 898
	/// </summary>
	ReadfromsubresourceEmptybox = 898,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_TOO_MANY_NODES_SPECIFIED</b> = 899
	/// </summary>
	TooManyNodesSpecified = 899,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INVALID_NODE_INDEX</b> = 900
	/// </summary>
	InvalidNodeIndex = 900,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETHEAPPROPERTIES_INVALIDRESOURCE</b> = 901
	/// </summary>
	GetheappropertiesInvalidresource = 901,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_NODE_MASK_MISMATCH</b> = 902
	/// </summary>
	NodeMaskMismatch = 902,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_OUTOFMEMORY</b> = 903
	/// </summary>
	CommandListOutofmemory = 903,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_MULTIPLE_SWAPCHAIN_BUFFER_REFERENCES</b> = 904
	/// </summary>
	CommandListMultipleSwapchainBufferReferences = 904,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_TOO_MANY_SWAPCHAIN_REFERENCES</b> = 905
	/// </summary>
	CommandListTooManySwapchainReferences = 905,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_QUEUE_TOO_MANY_SWAPCHAIN_REFERENCES</b> = 906
	/// </summary>
	CommandQueueTooManySwapchainReferences = 906,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_WRONGSWAPCHAINBUFFERREFERENCE</b> = 907
	/// </summary>
	ExecutecommandlistsWrongswapchainbufferreference = 907,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_SETRENDERTARGETS_INVALIDNUMRENDERTARGETS</b> = 908
	/// </summary>
	CommandListSetrendertargetsInvalidnumrendertargets = 908,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_TYPE</b> = 909
	/// </summary>
	CreateQueueInvalidType = 909,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_FLAGS</b> = 910
	/// </summary>
	CreateQueueInvalidFlags = 910,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFLAGS</b> = 911
	/// </summary>
	CreatesharedresourceInvalidflags = 911,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFORMAT</b> = 912
	/// </summary>
	CreatesharedresourceInvalidformat = 912,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHAREDHEAP_INVALIDFLAGS</b> = 913
	/// </summary>
	CreatesharedheapInvalidflags = 913,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_UNRECOGNIZEDPROPERTIES</b> = 914
	/// </summary>
	ReflectsharedpropertiesUnrecognizedproperties = 914,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDSIZE</b> = 915
	/// </summary>
	ReflectsharedpropertiesInvalidsize = 915,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDOBJECT</b> = 916
	/// </summary>
	ReflectsharedpropertiesInvalidobject = 916,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDOBJECT</b> = 917
	/// </summary>
	KeyedmutexInvalidobject = 917,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDKEY</b> = 918
	/// </summary>
	KeyedmutexInvalidkey = 918,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_KEYEDMUTEX_WRONGSTATE</b> = 919
	/// </summary>
	KeyedmutexWrongstate = 919,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_PRIORITY</b> = 920
	/// </summary>
	CreateQueueInvalidPriority = 920,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OBJECT_DELETED_WHILE_STILL_IN_USE</b> = 921
	/// </summary>
	ObjectDeletedWhileStillInUse = 921,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_FLAGS</b> = 922
	/// </summary>
	CreatepipelinestateInvalidFlags = 922,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_HAS_NO_RESOURCE</b> = 923
	/// </summary>
	HeapAddressRangeHasNoResource = 923,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_RENDER_TARGET_DELETED</b> = 924
	/// </summary>
	CommandListDrawRenderTargetDeleted = 924,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_ALL_RENDER_TARGETS_HAVE_UNKNOWN_FORMAT</b> = 925
	/// </summary>
	CreategraphicspipelinestateAllRenderTargetsHaveUnknownFormat = 925,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_INTERSECTS_MULTIPLE_BUFFERS</b> = 926
	/// </summary>
	HeapAddressRangeIntersectsMultipleBuffers = 926,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_GPU_WRITTEN_READBACK_RESOURCE_MAPPED</b> = 927
	/// </summary>
	ExecutecommandlistsGpuWrittenReadbackResourceMapped = 927,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNMAP_RANGE_NOT_EMPTY</b> = 929
	/// </summary>
	UnmapRangeNotEmpty = 929,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MAP_INVALID_NULLRANGE</b> = 930
	/// </summary>
	MapInvalidNullrange = 930,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNMAP_INVALID_NULLRANGE</b> = 931
	/// </summary>
	UnmapInvalidNullrange = 931,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_NO_GRAPHICS_API_SUPPORT</b> = 932
	/// </summary>
	NoGraphicsApiSupport = 932,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_NO_COMPUTE_API_SUPPORT</b> = 933
	/// </summary>
	NoComputeApiSupport = 933,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_FLAGS_NOT_SUPPORTED</b> = 934
	/// </summary>
	ResolvesubresourceResourceFlagsNotSupported = 934,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_ARGUMENT_UNINITIALIZED</b> = 935
	/// </summary>
	GpuBasedValidationRootArgumentUninitialized = 935,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_HEAP_INDEX_OUT_OF_BOUNDS</b> = 936
	/// </summary>
	GpuBasedValidationDescriptorHeapIndexOutOfBounds = 936,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TABLE_REGISTER_INDEX_OUT_OF_BOUNDS</b> = 937
	/// </summary>
	GpuBasedValidationDescriptorTableRegisterIndexOutOfBounds = 937,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_UNINITIALIZED</b> = 938
	/// </summary>
	GpuBasedValidationDescriptorUninitialized = 938,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TYPE_MISMATCH</b> = 939
	/// </summary>
	GpuBasedValidationDescriptorTypeMismatch = 939,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SRV_RESOURCE_DIMENSION_MISMATCH</b> = 940
	/// </summary>
	GpuBasedValidationSrvResourceDimensionMismatch = 940,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UAV_RESOURCE_DIMENSION_MISMATCH</b> = 941
	/// </summary>
	GpuBasedValidationUavResourceDimensionMismatch = 941,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_RESOURCE_STATE</b> = 942
	/// </summary>
	GpuBasedValidationIncompatibleResourceState = 942,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYRESOURCE_NULLDST</b> = 943
	/// </summary>
	CopyresourceNulldst = 943,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDDSTRESOURCE</b> = 944
	/// </summary>
	CopyresourceInvaliddstresource = 944,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYRESOURCE_NULLSRC</b> = 945
	/// </summary>
	CopyresourceNullsrc = 945,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDSRCRESOURCE</b> = 946
	/// </summary>
	CopyresourceInvalidsrcresource = 946,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLDST</b> = 947
	/// </summary>
	ResolvesubresourceNulldst = 947,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDDSTRESOURCE</b> = 948
	/// </summary>
	ResolvesubresourceInvaliddstresource = 948,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLSRC</b> = 949
	/// </summary>
	ResolvesubresourceNullsrc = 949,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDSRCRESOURCE</b> = 950
	/// </summary>
	ResolvesubresourceInvalidsrcresource = 950,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_PIPELINE_STATE_TYPE_MISMATCH</b> = 951
	/// </summary>
	PipelineStateTypeMismatch = 951,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_NOT_SET</b> = 952
	/// </summary>
	CommandListDispatchRootSignatureNotSet = 952,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_MISMATCH</b> = 953
	/// </summary>
	CommandListDispatchRootSignatureMismatch = 953,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_ZERO_BARRIERS</b> = 954
	/// </summary>
	ResourceBarrierZeroBarriers = 954,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_BEGIN_END_EVENT_MISMATCH</b> = 955
	/// </summary>
	BeginEndEventMismatch = 955,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_POSSIBLE_BEFORE_AFTER_MISMATCH</b> = 956
	/// </summary>
	ResourceBarrierPossibleBeforeAfterMismatch = 956,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_BEGIN_END</b> = 957
	/// </summary>
	ResourceBarrierMismatchingBeginEnd = 957,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INVALID_RESOURCE</b> = 958
	/// </summary>
	GpuBasedValidationInvalidResource = 958,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT</b> = 959
	/// </summary>
	UseOfZeroRefcountObject = 959,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OBJECT_EVICTED_WHILE_STILL_IN_USE</b> = 960
	/// </summary>
	ObjectEvictedWhileStillInUse = 960,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_DESCRIPTOR_ACCESS_OUT_OF_BOUNDS</b> = 961
	/// </summary>
	GpuBasedValidationRootDescriptorAccessOutOfBounds = 961,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_INVALIDLIBRARYBLOB</b> = 962
	/// </summary>
	CreatepipelinelibraryInvalidlibraryblob = 962,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_DRIVERVERSIONMISMATCH</b> = 963
	/// </summary>
	CreatepipelinelibraryDriverversionmismatch = 963,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_ADAPTERVERSIONMISMATCH</b> = 964
	/// </summary>
	CreatepipelinelibraryAdapterversionmismatch = 964,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_UNSUPPORTED</b> = 965
	/// </summary>
	CreatepipelinelibraryUnsupported = 965,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_PIPELINELIBRARY</b> = 966
	/// </summary>
	CreatePipelinelibrary = 966,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_PIPELINELIBRARY</b> = 967
	/// </summary>
	LivePipelinelibrary = 967,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_PIPELINELIBRARY</b> = 968
	/// </summary>
	DestroyPipelinelibrary = 968,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_STOREPIPELINE_NONAME</b> = 969
	/// </summary>
	StorepipelineNoname = 969,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_STOREPIPELINE_DUPLICATENAME</b> = 970
	/// </summary>
	StorepipelineDuplicatename = 970,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LOADPIPELINE_NAMENOTFOUND</b> = 971
	/// </summary>
	LoadpipelineNamenotfound = 971,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LOADPIPELINE_INVALIDDESC</b> = 972
	/// </summary>
	LoadpipelineInvaliddesc = 972,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_PIPELINELIBRARY_SERIALIZE_NOTENOUGHMEMORY</b> = 973
	/// </summary>
	PipelinelibrarySerializeNotenoughmemory = 973,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_RT_OUTPUT_MISMATCH</b> = 974
	/// </summary>
	CreategraphicspipelinestatePsOutputRtOutputMismatch = 974,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETEVENTONMULTIPLEFENCECOMPLETION_INVALIDFLAGS</b> = 975
	/// </summary>
	SeteventonmultiplefencecompletionInvalidflags = 975,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_QUEUE_VIDEO_NOT_SUPPORTED</b> = 976
	/// </summary>
	CreateQueueVideoNotSupported = 976,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_ALLOCATOR_VIDEO_NOT_SUPPORTED</b> = 977
	/// </summary>
	CreateCommandAllocatorVideoNotSupported = 977,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEQUERY_HEAP_VIDEO_DECODE_STATISTICS_NOT_SUPPORTED</b> = 978
	/// </summary>
	CreatequeryHeapVideoDecodeStatisticsNotSupported = 978,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDLIST</b> = 979
	/// </summary>
	CreateVideodecodecommandlist = 979,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEODECODER</b> = 980
	/// </summary>
	CreateVideodecoder = 980,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEODECODESTREAM</b> = 981
	/// </summary>
	CreateVideodecodestream = 981,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDLIST</b> = 982
	/// </summary>
	LiveVideodecodecommandlist = 982,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEODECODER</b> = 983
	/// </summary>
	LiveVideodecoder = 983,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEODECODESTREAM</b> = 984
	/// </summary>
	LiveVideodecodestream = 984,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDLIST</b> = 985
	/// </summary>
	DestroyVideodecodecommandlist = 985,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEODECODER</b> = 986
	/// </summary>
	DestroyVideodecoder = 986,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEODECODESTREAM</b> = 987
	/// </summary>
	DestroyVideodecodestream = 987,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DECODE_FRAME_INVALID_PARAMETERS</b> = 988
	/// </summary>
	DecodeFrameInvalidParameters = 988,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEPRECATED_API</b> = 989
	/// </summary>
	DeprecatedApi = 989,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_COMMAND_LIST_TYPE</b> = 990
	/// </summary>
	ResourceBarrierMismatchingCommandListType = 990,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DESCRIPTOR_TABLE_NOT_SET</b> = 991
	/// </summary>
	CommandListDescriptorTableNotSet = 991,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_CONSTANT_BUFFER_VIEW_NOT_SET</b> = 992
	/// </summary>
	CommandListRootConstantBufferViewNotSet = 992,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_SHADER_RESOURCE_VIEW_NOT_SET</b> = 993
	/// </summary>
	CommandListRootShaderResourceViewNotSet = 993,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_UNORDERED_ACCESS_VIEW_NOT_SET</b> = 994
	/// </summary>
	CommandListRootUnorderedAccessViewNotSet = 994,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DISCARD_INVALID_SUBRESOURCE_RANGE</b> = 995
	/// </summary>
	DiscardInvalidSubresourceRange = 995,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DISCARD_ONE_SUBRESOURCE_FOR_MIPS_WITH_RECTS</b> = 996
	/// </summary>
	DiscardOneSubresourceForMipsWithRects = 996,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DISCARD_NO_RECTS_FOR_NON_TEXTURE2D</b> = 997
	/// </summary>
	DiscardNoRectsForNonTexture2d = 997,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPY_ON_SAME_SUBRESOURCE</b> = 998
	/// </summary>
	CopyOnSameSubresource = 998,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PAGEABLE</b> = 999
	/// </summary>
	SetresidencypriorityInvalidPageable = 999,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UNSUPPORTED</b> = 1000
	/// </summary>
	GpuBasedValidationUnsupported = 1000,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_STATIC_DESCRIPTOR_INVALID_DESCRIPTOR_CHANGE</b> = 1001
	/// </summary>
	StaticDescriptorInvalidDescriptorChange = 1001,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DATA_STATIC_DESCRIPTOR_INVALID_DATA_CHANGE</b> = 1002
	/// </summary>
	DataStaticDescriptorInvalidDataChange = 1002,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DATA_STATIC_WHILE_SET_AT_EXECUTE_DESCRIPTOR_INVALID_DATA_CHANGE</b> = 1003
	/// </summary>
	DataStaticWhileSetAtExecuteDescriptorInvalidDataChange = 1003,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EXECUTE_BUNDLE_STATIC_DESCRIPTOR_DATA_STATIC_NOT_SET</b> = 1004
	/// </summary>
	ExecuteBundleStaticDescriptorDataStaticNotSet = 1004,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_ACCESS_OUT_OF_BOUNDS</b> = 1005
	/// </summary>
	GpuBasedValidationResourceAccessOutOfBounds = 1005,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SAMPLER_MODE_MISMATCH</b> = 1006
	/// </summary>
	GpuBasedValidationSamplerModeMismatch = 1006,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_FENCE_INVALID_FLAGS</b> = 1007
	/// </summary>
	CreateFenceInvalidFlags = 1007,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_BARRIER_DUPLICATE_SUBRESOURCE_TRANSITIONS</b> = 1008
	/// </summary>
	ResourceBarrierDuplicateSubresourceTransitions = 1008,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PRIORITY</b> = 1009
	/// </summary>
	SetresidencypriorityInvalidPriority = 1009,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_LARGE_NUM_DESCRIPTORS</b> = 1013
	/// </summary>
	CreateDescriptorHeapLargeNumDescriptors = 1013,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_BEGIN_EVENT</b> = 1014
	/// </summary>
	BeginEvent = 1014,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_END_EVENT</b> = 1015
	/// </summary>
	EndEvent = 1015,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEVICE_DEBUG_LAYER_STARTUP_OPTIONS</b> = 1016
	/// </summary>
	CreatedeviceDebugLayerStartupOptions = 1016,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_DEPTHBOUNDSTEST_UNSUPPORTED</b> = 1017
	/// </summary>
	CreatedepthstencilstateDepthboundstestUnsupported = 1017,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_DUPLICATE_SUBOBJECT</b> = 1018
	/// </summary>
	CreatepipelinestateDuplicateSubobject = 1018,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_UNKNOWN_SUBOBJECT</b> = 1019
	/// </summary>
	CreatepipelinestateUnknownSubobject = 1019,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_ZERO_SIZE_STREAM</b> = 1020
	/// </summary>
	CreatepipelinestateZeroSizeStream = 1020,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_STREAM</b> = 1021
	/// </summary>
	CreatepipelinestateInvalidStream = 1021,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CANNOT_DEDUCE_TYPE</b> = 1022
	/// </summary>
	CreatepipelinestateCannotDeduceType = 1022,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_RESOURCE_DIMENSION_MISMATCH</b> = 1023
	/// </summary>
	CommandListStaticDescriptorResourceDimensionMismatch = 1023,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_PRIVILEGE_FOR_GLOBAL_REALTIME</b> = 1024
	/// </summary>
	CreateCommandQueueInsufficientPrivilegeForGlobalRealtime = 1024,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_HARDWARE_SUPPORT_FOR_GLOBAL_REALTIME</b> = 1025
	/// </summary>
	CreateCommandQueueInsufficientHardwareSupportForGlobalRealtime = 1025,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_ARCHITECTURE</b> = 1026
	/// </summary>
	AtomiccopybufferInvalidArchitecture = 1026,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DST</b> = 1027
	/// </summary>
	AtomiccopybufferNullDst = 1027,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE_DIMENSION</b> = 1028
	/// </summary>
	AtomiccopybufferInvalidDstResourceDimension = 1028,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DST_RANGE_OUT_OF_BOUNDS</b> = 1029
	/// </summary>
	AtomiccopybufferDstRangeOutOfBounds = 1029,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_SRC</b> = 1030
	/// </summary>
	AtomiccopybufferNullSrc = 1030,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE_DIMENSION</b> = 1031
	/// </summary>
	AtomiccopybufferInvalidSrcResourceDimension = 1031,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_SRC_RANGE_OUT_OF_BOUNDS</b> = 1032
	/// </summary>
	AtomiccopybufferSrcRangeOutOfBounds = 1032,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_OFFSET_ALIGNMENT</b> = 1033
	/// </summary>
	AtomiccopybufferInvalidOffsetAlignment = 1033,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_RESOURCES</b> = 1034
	/// </summary>
	AtomiccopybufferNullDependentResources = 1034,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_SUBRESOURCE_RANGES</b> = 1035
	/// </summary>
	AtomiccopybufferNullDependentSubresourceRanges = 1035,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_RESOURCE</b> = 1036
	/// </summary>
	AtomiccopybufferInvalidDependentResource = 1036,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_SUBRESOURCE_RANGE</b> = 1037
	/// </summary>
	AtomiccopybufferInvalidDependentSubresourceRange = 1037,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_SUBRESOURCE_OUT_OF_BOUNDS</b> = 1038
	/// </summary>
	AtomiccopybufferDependentSubresourceOutOfBounds = 1038,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_RANGE_OUT_OF_BOUNDS</b> = 1039
	/// </summary>
	AtomiccopybufferDependentRangeOutOfBounds = 1039,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_ZERO_DEPENDENCIES</b> = 1040
	/// </summary>
	AtomiccopybufferZeroDependencies = 1040,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_CREATE_SHARED_HANDLE_INVALIDARG</b> = 1041
	/// </summary>
	DeviceCreateSharedHandleInvalidarg = 1041,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESCRIPTOR_HANDLE_WITH_INVALID_RESOURCE</b> = 1042
	/// </summary>
	DescriptorHandleWithInvalidResource = 1042,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETDEPTHBOUNDS_INVALIDARGS</b> = 1043
	/// </summary>
	SetdepthboundsInvalidargs = 1043,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_STATE_IMPRECISE</b> = 1044
	/// </summary>
	GpuBasedValidationResourceStateImprecise = 1044,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_PIPELINE_STATE_NOT_SET</b> = 1045
	/// </summary>
	CommandListPipelineStateNotSet = 1045,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_MODEL_MISMATCH</b> = 1046
	/// </summary>
	CreategraphicspipelinestateShaderModelMismatch = 1046,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OBJECT_ACCESSED_WHILE_STILL_IN_USE</b> = 1047
	/// </summary>
	ObjectAccessedWhileStillInUse = 1047,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_PROGRAMMABLE_MSAA_UNSUPPORTED</b> = 1048
	/// </summary>
	ProgrammableMsaaUnsupported = 1048,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETSAMPLEPOSITIONS_INVALIDARGS</b> = 1049
	/// </summary>
	SetsamplepositionsInvalidargs = 1049,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCEREGION_INVALID_RECT</b> = 1050
	/// </summary>
	ResolvesubresourceregionInvalidRect = 1050,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDQUEUE</b> = 1051
	/// </summary>
	CreateVideodecodecommandqueue = 1051,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDLIST</b> = 1052
	/// </summary>
	CreateVideoprocesscommandlist = 1052,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDQUEUE</b> = 1053
	/// </summary>
	CreateVideoprocesscommandqueue = 1053,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDQUEUE</b> = 1054
	/// </summary>
	LiveVideodecodecommandqueue = 1054,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDLIST</b> = 1055
	/// </summary>
	LiveVideoprocesscommandlist = 1055,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDQUEUE</b> = 1056
	/// </summary>
	LiveVideoprocesscommandqueue = 1056,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDQUEUE</b> = 1057
	/// </summary>
	DestroyVideodecodecommandqueue = 1057,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDLIST</b> = 1058
	/// </summary>
	DestroyVideoprocesscommandlist = 1058,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDQUEUE</b> = 1059
	/// </summary>
	DestroyVideoprocesscommandqueue = 1059,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSOR</b> = 1060
	/// </summary>
	CreateVideoprocessor = 1060,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSSTREAM</b> = 1061
	/// </summary>
	CreateVideoprocessstream = 1061,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSOR</b> = 1062
	/// </summary>
	LiveVideoprocessor = 1062,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSSTREAM</b> = 1063
	/// </summary>
	LiveVideoprocessstream = 1063,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSOR</b> = 1064
	/// </summary>
	DestroyVideoprocessor = 1064,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSSTREAM</b> = 1065
	/// </summary>
	DestroyVideoprocessstream = 1065,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_PROCESS_FRAME_INVALID_PARAMETERS</b> = 1066
	/// </summary>
	ProcessFrameInvalidParameters = 1066,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPY_INVALIDLAYOUT</b> = 1067
	/// </summary>
	CopyInvalidlayout = 1067,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION</b> = 1068
	/// </summary>
	CreateCryptoSession = 1068,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION_POLICY</b> = 1069
	/// </summary>
	CreateCryptoSessionPolicy = 1069,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION</b> = 1070
	/// </summary>
	CreateProtectedResourceSession = 1070,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION</b> = 1071
	/// </summary>
	LiveCryptoSession = 1071,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION_POLICY</b> = 1072
	/// </summary>
	LiveCryptoSessionPolicy = 1072,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_PROTECTED_RESOURCE_SESSION</b> = 1073
	/// </summary>
	LiveProtectedResourceSession = 1073,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION</b> = 1074
	/// </summary>
	DestroyCryptoSession = 1074,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION_POLICY</b> = 1075
	/// </summary>
	DestroyCryptoSessionPolicy = 1075,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_PROTECTED_RESOURCE_SESSION</b> = 1076
	/// </summary>
	DestroyProtectedResourceSession = 1076,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_PROTECTED_RESOURCE_SESSION_UNSUPPORTED</b> = 1077
	/// </summary>
	ProtectedResourceSessionUnsupported = 1077,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_FENCE_INVALIDOPERATION</b> = 1078
	/// </summary>
	FenceInvalidoperation = 1078,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEQUERY_HEAP_COPY_QUEUE_TIMESTAMPS_NOT_SUPPORTED</b> = 1079
	/// </summary>
	CreatequeryHeapCopyQueueTimestampsNotSupported = 1079,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_DEFERRED</b> = 1080
	/// </summary>
	SamplepositionsMismatchDeferred = 1080,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMFIRSTUSE</b> = 1081
	/// </summary>
	SamplepositionsMismatchRecordtimeAssumedfromfirstuse = 1081,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMCLEAR</b> = 1082
	/// </summary>
	SamplepositionsMismatchRecordtimeAssumedfromclear = 1082,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEODECODERHEAP</b> = 1083
	/// </summary>
	CreateVideodecoderheap = 1083,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEODECODERHEAP</b> = 1084
	/// </summary>
	LiveVideodecoderheap = 1084,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEODECODERHEAP</b> = 1085
	/// </summary>
	DestroyVideodecoderheap = 1085,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDARG_RETURN</b> = 1086
	/// </summary>
	OpenexistingheapInvalidargReturn = 1086,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OPENEXISTINGHEAP_OUTOFMEMORY_RETURN</b> = 1087
	/// </summary>
	OpenexistingheapOutofmemoryReturn = 1087,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDADDRESS</b> = 1088
	/// </summary>
	OpenexistingheapInvalidaddress = 1088,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDHANDLE</b> = 1089
	/// </summary>
	OpenexistingheapInvalidhandle = 1089,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_DEST</b> = 1090
	/// </summary>
	WritebufferimmediateInvalidDest = 1090,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_MODE</b> = 1091
	/// </summary>
	WritebufferimmediateInvalidMode = 1091,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_ALIGNMENT</b> = 1092
	/// </summary>
	WritebufferimmediateInvalidAlignment = 1092,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_NOT_SUPPORTED</b> = 1093
	/// </summary>
	WritebufferimmediateNotSupported = 1093,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETVIEWINSTANCEMASK_INVALIDARGS</b> = 1094
	/// </summary>
	SetviewinstancemaskInvalidargs = 1094,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIEW_INSTANCING_UNSUPPORTED</b> = 1095
	/// </summary>
	ViewInstancingUnsupported = 1095,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIEW_INSTANCING_INVALIDARGS</b> = 1096
	/// </summary>
	ViewInstancingInvalidargs = 1096,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_DECODE_REFERENCE_ONLY_FLAG</b> = 1097
	/// </summary>
	CopytextureregionMismatchDecodeReferenceOnlyFlag = 1097,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_DECODE_REFERENCE_ONLY_FLAG</b> = 1098
	/// </summary>
	CopyresourceMismatchDecodeReferenceOnlyFlag = 1098,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_FAILURE</b> = 1099
	/// </summary>
	CreateVideoDecodeHeapCapsFailure = 1099,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_UNSUPPORTED</b> = 1100
	/// </summary>
	CreateVideoDecodeHeapCapsUnsupported = 1100,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_INVALID_INPUT</b> = 1101
	/// </summary>
	VideoDecodeSupportInvalidInput = 1101,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_DECODER_UNSUPPORTED</b> = 1102
	/// </summary>
	CreateVideoDecoderUnsupported = 1102,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_METADATA_ERROR</b> = 1103
	/// </summary>
	CreategraphicspipelinestateMetadataError = 1103,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VIEW_INSTANCING_VERTEX_SIZE_EXCEEDED</b> = 1104
	/// </summary>
	CreategraphicspipelinestateViewInstancingVertexSizeExceeded = 1104,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RUNTIME_INTERNAL_ERROR</b> = 1105
	/// </summary>
	CreategraphicspipelinestateRuntimeInternalError = 1105,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_NO_VIDEO_API_SUPPORT</b> = 1106
	/// </summary>
	NoVideoApiSupport = 1106,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_INVALID_INPUT</b> = 1107
	/// </summary>
	VideoProcessSupportInvalidInput = 1107,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_PROCESSOR_CAPS_FAILURE</b> = 1108
	/// </summary>
	CreateVideoProcessorCapsFailure = 1108,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_UNSUPPORTED_FORMAT</b> = 1109
	/// </summary>
	VideoProcessSupportUnsupportedFormat = 1109,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_DECODE_FRAME_INVALID_ARGUMENT</b> = 1110
	/// </summary>
	VideoDecodeFrameInvalidArgument = 1110,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ENQUEUE_MAKE_RESIDENT_INVALID_FLAGS</b> = 1111
	/// </summary>
	EnqueueMakeResidentInvalidFlags = 1111,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OPENEXISTINGHEAP_UNSUPPORTED</b> = 1112
	/// </summary>
	OpenexistingheapUnsupported = 1112,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_PROCESS_FRAMES_INVALID_ARGUMENT</b> = 1113
	/// </summary>
	VideoProcessFramesInvalidArgument = 1113,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_UNSUPPORTED</b> = 1114
	/// </summary>
	VideoDecodeSupportUnsupported = 1114,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMANDRECORDER</b> = 1115
	/// </summary>
	CreateCommandrecorder = 1115,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_COMMANDRECORDER</b> = 1116
	/// </summary>
	LiveCommandrecorder = 1116,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_COMMANDRECORDER</b> = 1117
	/// </summary>
	DestroyCommandrecorder = 1117,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_VIDEO_NOT_SUPPORTED</b> = 1118
	/// </summary>
	CreateCommandRecorderVideoNotSupported = 1118,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_SUPPORT_FLAGS</b> = 1119
	/// </summary>
	CreateCommandRecorderInvalidSupportFlags = 1119,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_FLAGS</b> = 1120
	/// </summary>
	CreateCommandRecorderInvalidFlags = 1120,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_MORE_RECORDERS_THAN_LOGICAL_PROCESSORS</b> = 1121
	/// </summary>
	CreateCommandRecorderMoreRecordersThanLogicalProcessors = 1121,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMANDPOOL</b> = 1122
	/// </summary>
	CreateCommandpool = 1122,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_COMMANDPOOL</b> = 1123
	/// </summary>
	LiveCommandpool = 1123,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_COMMANDPOOL</b> = 1124
	/// </summary>
	DestroyCommandpool = 1124,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_POOL_INVALID_FLAGS</b> = 1125
	/// </summary>
	CreateCommandPoolInvalidFlags = 1125,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_VIDEO_NOT_SUPPORTED</b> = 1126
	/// </summary>
	CreateCommandListVideoNotSupported = 1126,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_RECORDER_SUPPORT_FLAGS_MISMATCH</b> = 1127
	/// </summary>
	CommandRecorderSupportFlagsMismatch = 1127,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_RECORDER_CONTENTION</b> = 1128
	/// </summary>
	CommandRecorderContention = 1128,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_RECORDER_USAGE_WITH_CREATECOMMANDLIST_COMMAND_LIST</b> = 1129
	/// </summary>
	CommandRecorderUsageWithCreatecommandlistCommandList = 1129,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_USAGE_WITH_CREATECOMMANDLIST1_COMMAND_LIST</b> = 1130
	/// </summary>
	CommandAllocatorUsageWithCreatecommandlist1CommandList = 1130,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CANNOT_EXECUTE_EMPTY_COMMAND_LIST</b> = 1131
	/// </summary>
	CannotExecuteEmptyCommandList = 1131,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CANNOT_RESET_COMMAND_POOL_WITH_OPEN_COMMAND_LISTS</b> = 1132
	/// </summary>
	CannotResetCommandPoolWithOpenCommandLists = 1132,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CANNOT_USE_COMMAND_RECORDER_WITHOUT_CURRENT_TARGET</b> = 1133
	/// </summary>
	CannotUseCommandRecorderWithoutCurrentTarget = 1133,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CANNOT_CHANGE_COMMAND_RECORDER_TARGET_WHILE_RECORDING</b> = 1134
	/// </summary>
	CannotChangeCommandRecorderTargetWhileRecording = 1134,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_POOL_SYNC</b> = 1135
	/// </summary>
	CommandPoolSync = 1135,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EVICT_UNDERFLOW</b> = 1136
	/// </summary>
	EvictUnderflow = 1136,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_META_COMMAND</b> = 1137
	/// </summary>
	CreateMetaCommand = 1137,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_META_COMMAND</b> = 1138
	/// </summary>
	LiveMetaCommand = 1138,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_META_COMMAND</b> = 1139
	/// </summary>
	DestroyMetaCommand = 1139,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_DST_RESOURCE</b> = 1140
	/// </summary>
	CopybufferregionInvalidDstResource = 1140,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_SRC_RESOURCE</b> = 1141
	/// </summary>
	CopybufferregionInvalidSrcResource = 1141,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE</b> = 1142
	/// </summary>
	AtomiccopybufferInvalidDstResource = 1142,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE</b> = 1143
	/// </summary>
	AtomiccopybufferInvalidSrcResource = 1143,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_BUFFER</b> = 1144
	/// </summary>
	CreateplacedresourceonbufferNullBuffer = 1144,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_RESOURCE_DESC</b> = 1145
	/// </summary>
	CreateplacedresourceonbufferNullResourceDesc = 1145,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_UNSUPPORTED</b> = 1146
	/// </summary>
	CreateplacedresourceonbufferUnsupported = 1146,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_DIMENSION</b> = 1147
	/// </summary>
	CreateplacedresourceonbufferInvalidBufferDimension = 1147,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_FLAGS</b> = 1148
	/// </summary>
	CreateplacedresourceonbufferInvalidBufferFlags = 1148,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_OFFSET</b> = 1149
	/// </summary>
	CreateplacedresourceonbufferInvalidBufferOffset = 1149,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_DIMENSION</b> = 1150
	/// </summary>
	CreateplacedresourceonbufferInvalidResourceDimension = 1150,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_FLAGS</b> = 1151
	/// </summary>
	CreateplacedresourceonbufferInvalidResourceFlags = 1151,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_OUTOFMEMORY_RETURN</b> = 1152
	/// </summary>
	CreateplacedresourceonbufferOutofmemoryReturn = 1152,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CANNOT_CREATE_GRAPHICS_AND_VIDEO_COMMAND_RECORDER</b> = 1153
	/// </summary>
	CannotCreateGraphicsAndVideoCommandRecorder = 1153,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_POSSIBLY_MISMATCHING_PROPERTIES</b> = 1154
	/// </summary>
	UpdatetilemappingsPossiblyMismatchingProperties = 1154,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE</b> = 1155
	/// </summary>
	CreateCommandListInvalidCommandListType = 1155,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INCOMPATIBLE_WITH_STRUCTURED_BUFFERS</b> = 1156
	/// </summary>
	ClearunorderedaccessviewIncompatibleWithStructuredBuffers = 1156,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMPUTE_ONLY_DEVICE_OPERATION_UNSUPPORTED</b> = 1157
	/// </summary>
	ComputeOnlyDeviceOperationUnsupported = 1157,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INVALID</b> = 1158
	/// </summary>
	BuildRaytracingAccelerationStructureInvalid = 1158,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_INVALID</b> = 1159
	/// </summary>
	EmitRaytracingAccelerationStructurePostbuildInfoInvalid = 1159,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPY_RAYTRACING_ACCELERATION_STRUCTURE_INVALID</b> = 1160
	/// </summary>
	CopyRaytracingAccelerationStructureInvalid = 1160,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DISPATCH_RAYS_INVALID</b> = 1161
	/// </summary>
	DispatchRaysInvalid = 1161,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GET_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO_INVALID</b> = 1162
	/// </summary>
	GetRaytracingAccelerationStructurePrebuildInfoInvalid = 1162,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_LIFETIMETRACKER</b> = 1163
	/// </summary>
	CreateLifetimetracker = 1163,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_LIFETIMETRACKER</b> = 1164
	/// </summary>
	LiveLifetimetracker = 1164,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_LIFETIMETRACKER</b> = 1165
	/// </summary>
	DestroyLifetimetracker = 1165,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROYOWNEDOBJECT_OBJECTNOTOWNED</b> = 1166
	/// </summary>
	DestroyownedobjectObjectnotowned = 1166,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_TRACKEDWORKLOAD</b> = 1167
	/// </summary>
	CreateTrackedworkload = 1167,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_TRACKEDWORKLOAD</b> = 1168
	/// </summary>
	LiveTrackedworkload = 1168,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD</b> = 1169
	/// </summary>
	DestroyTrackedworkload = 1169,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_ERROR</b> = 1170
	/// </summary>
	RenderPassError = 1170,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_META_COMMAND_ID_INVALID</b> = 1171
	/// </summary>
	MetaCommandIdInvalid = 1171,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_META_COMMAND_UNSUPPORTED_PARAMS</b> = 1172
	/// </summary>
	MetaCommandUnsupportedParams = 1172,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_META_COMMAND_FAILED_ENUMERATION</b> = 1173
	/// </summary>
	MetaCommandFailedEnumeration = 1173,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_META_COMMAND_PARAMETER_SIZE_MISMATCH</b> = 1174
	/// </summary>
	MetaCommandParameterSizeMismatch = 1174,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNINITIALIZED_META_COMMAND</b> = 1175
	/// </summary>
	UninitializedMetaCommand = 1175,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_META_COMMAND_INVALID_GPU_VIRTUAL_ADDRESS</b> = 1176
	/// </summary>
	MetaCommandInvalidGpuVirtualAddress = 1176,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDLIST</b> = 1177
	/// </summary>
	CreateVideoencodecommandlist = 1177,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDLIST</b> = 1178
	/// </summary>
	LiveVideoencodecommandlist = 1178,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDLIST</b> = 1179
	/// </summary>
	DestroyVideoencodecommandlist = 1179,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDQUEUE</b> = 1180
	/// </summary>
	CreateVideoencodecommandqueue = 1180,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDQUEUE</b> = 1181
	/// </summary>
	LiveVideoencodecommandqueue = 1181,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDQUEUE</b> = 1182
	/// </summary>
	DestroyVideoencodecommandqueue = 1182,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONESTIMATOR</b> = 1183
	/// </summary>
	CreateVideomotionestimator = 1183,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONESTIMATOR</b> = 1184
	/// </summary>
	LiveVideomotionestimator = 1184,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONESTIMATOR</b> = 1185
	/// </summary>
	DestroyVideomotionestimator = 1185,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONVECTORHEAP</b> = 1186
	/// </summary>
	CreateVideomotionvectorheap = 1186,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONVECTORHEAP</b> = 1187
	/// </summary>
	LiveVideomotionvectorheap = 1187,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONVECTORHEAP</b> = 1188
	/// </summary>
	DestroyVideomotionvectorheap = 1188,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS</b> = 1189
	/// </summary>
	MultipleTrackedWorkloads = 1189,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS</b> = 1190
	/// </summary>
	MultipleTrackedWorkloadPairs = 1190,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR</b> = 1191
	/// </summary>
	OutOfOrderTrackedWorkloadPair = 1191,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD</b> = 1192
	/// </summary>
	CannotAddTrackedWorkload = 1192,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR</b> = 1193
	/// </summary>
	IncompleteTrackedWorkloadPair = 1193,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_STATE_OBJECT_ERROR</b> = 1194
	/// </summary>
	CreateStateObjectError = 1194,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_ERROR</b> = 1195
	/// </summary>
	GetShaderIdentifierError = 1195,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GET_SHADER_STACK_SIZE_ERROR</b> = 1196
	/// </summary>
	GetShaderStackSizeError = 1196,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GET_PIPELINE_STACK_SIZE_ERROR</b> = 1197
	/// </summary>
	GetPipelineStackSizeError = 1197,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_PIPELINE_STACK_SIZE_ERROR</b> = 1198
	/// </summary>
	SetPipelineStackSizeError = 1198,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_SIZE_INVALID</b> = 1199
	/// </summary>
	GetShaderIdentifierSizeInvalid = 1199,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_INVALID</b> = 1200
	/// </summary>
	CheckDriverMatchingIdentifierInvalid = 1200,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_DRIVER_REPORTED_ISSUE</b> = 1201
	/// </summary>
	CheckDriverMatchingIdentifierDriverReportedIssue = 1201,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_INVALID_RESOURCE_BARRIER</b> = 1202
	/// </summary>
	RenderPassInvalidResourceBarrier = 1202,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_DISALLOWED_API_CALLED</b> = 1203
	/// </summary>
	RenderPassDisallowedApiCalled = 1203,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_NEST_RENDER_PASSES</b> = 1204
	/// </summary>
	RenderPassCannotNestRenderPasses = 1204,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_END_WITHOUT_BEGIN</b> = 1205
	/// </summary>
	RenderPassCannotEndWithoutBegin = 1205,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_CLOSE_COMMAND_LIST</b> = 1206
	/// </summary>
	RenderPassCannotCloseCommandList = 1206,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_GPU_WORK_WHILE_SUSPENDED</b> = 1207
	/// </summary>
	RenderPassGpuWorkWhileSuspended = 1207,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_SUSPEND_RESUME</b> = 1208
	/// </summary>
	RenderPassMismatchingSuspendResume = 1208,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_NO_PRIOR_SUSPEND_WITHIN_EXECUTECOMMANDLISTS</b> = 1209
	/// </summary>
	RenderPassNoPriorSuspendWithinExecutecommandlists = 1209,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_NO_SUBSEQUENT_RESUME_WITHIN_EXECUTECOMMANDLISTS</b> = 1210
	/// </summary>
	RenderPassNoSubsequentResumeWithinExecutecommandlists = 1210,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_TRACKED_WORKLOAD_COMMAND_QUEUE_MISMATCH</b> = 1211
	/// </summary>
	TrackedWorkloadCommandQueueMismatch = 1211,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED</b> = 1212
	/// </summary>
	TrackedWorkloadNotSupported = 1212,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_NO_ACCESS</b> = 1213
	/// </summary>
	RenderPassMismatchingNoAccess = 1213,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RENDER_PASS_UNSUPPORTED_RESOLVE</b> = 1214
	/// </summary>
	RenderPassUnsupportedResolve = 1214,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INVALID_RESOURCE_PTR</b> = 1215
	/// </summary>
	ClearunorderedaccessviewInvalidResourcePtr = 1215,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_SIGNAL</b> = 1216
	/// </summary>
	Windows7FenceOutoforderSignal = 1216,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_WAIT</b> = 1217
	/// </summary>
	Windows7FenceOutoforderWait = 1217,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_ESTIMATOR_INVALID_ARGUMENT</b> = 1218
	/// </summary>
	VideoCreateMotionEstimatorInvalidArgument = 1218,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT</b> = 1219
	/// </summary>
	VideoCreateMotionVectorHeapInvalidArgument = 1219,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ESTIMATE_MOTION_INVALID_ARGUMENT</b> = 1220
	/// </summary>
	EstimateMotionInvalidArgument = 1220,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT</b> = 1221
	/// </summary>
	ResolveMotionVectorHeapInvalidArgument = 1221,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_HEAP_TYPE</b> = 1222
	/// </summary>
	GetgpuvirtualaddressInvalidHeapType = 1222,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_BACKGROUND_PROCESSING_MODE_INVALID_ARGUMENT</b> = 1223
	/// </summary>
	SetBackgroundProcessingModeInvalidArgument = 1223,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE_FOR_FEATURE_LEVEL</b> = 1224
	/// </summary>
	CreateCommandListInvalidCommandListTypeForFeatureLevel = 1224,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOEXTENSIONCOMMAND</b> = 1225
	/// </summary>
	CreateVideoextensioncommand = 1225,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOEXTENSIONCOMMAND</b> = 1226
	/// </summary>
	LiveVideoextensioncommand = 1226,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOEXTENSIONCOMMAND</b> = 1227
	/// </summary>
	DestroyVideoextensioncommand = 1227,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INVALID_VIDEO_EXTENSION_COMMAND_ID</b> = 1228
	/// </summary>
	InvalidVideoExtensionCommandId = 1228,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VIDEO_EXTENSION_COMMAND_INVALID_ARGUMENT</b> = 1229
	/// </summary>
	VideoExtensionCommandInvalidArgument = 1229,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_UNIQUE_IN_DXIL_LIBRARY</b> = 1230
	/// </summary>
	CreateRootSignatureNotUniqueInDxilLibrary = 1230,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VARIABLE_SHADING_RATE_NOT_ALLOWED_WITH_TIR</b> = 1231
	/// </summary>
	VariableShadingRateNotAllowedWithTir = 1231,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GEOMETRY_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE</b> = 1232
	/// </summary>
	GeometryShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 1232,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_SHADING_RATE</b> = 1233
	/// </summary>
	RssetshadingRateInvalidShadingRate = 1233,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RSSETSHADING_RATE_SHADING_RATE_NOT_PERMITTED_BY_CAP</b> = 1234
	/// </summary>
	RssetshadingRateShadingRateNotPermittedByCap = 1234,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_COMBINER</b> = 1235
	/// </summary>
	RssetshadingRateInvalidCombiner = 1235,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RSSETSHADINGRATEIMAGE_REQUIRES_TIER_2</b> = 1236
	/// </summary>
	RssetshadingrateimageRequiresTier2 = 1236,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RSSETSHADINGRATE_REQUIRES_TIER_1</b> = 1237
	/// </summary>
	RssetshadingrateRequiresTier1 = 1237,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_FORMAT</b> = 1238
	/// </summary>
	ShadingRateImageIncorrectFormat = 1238,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_ARRAY_SIZE</b> = 1239
	/// </summary>
	ShadingRateImageIncorrectArraySize = 1239,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_MIP_LEVEL</b> = 1240
	/// </summary>
	ShadingRateImageIncorrectMipLevel = 1240,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_COUNT</b> = 1241
	/// </summary>
	ShadingRateImageIncorrectSampleCount = 1241,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_QUALITY</b> = 1242
	/// </summary>
	ShadingRateImageIncorrectSampleQuality = 1242,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_NON_RETAIL_SHADER_MODEL_WONT_VALIDATE</b> = 1243
	/// </summary>
	NonRetailShaderModelWontValidate = 1243,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_ROOT_SIGNATURE_MISMATCH</b> = 1244
	/// </summary>
	CreategraphicspipelinestateAsRootSignatureMismatch = 1244,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_ROOT_SIGNATURE_MISMATCH</b> = 1245
	/// </summary>
	CreategraphicspipelinestateMsRootSignatureMismatch = 1245,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ADD_TO_STATE_OBJECT_ERROR</b> = 1246
	/// </summary>
	AddToStateObjectError = 1246,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION_INVALID_ARGUMENT</b> = 1247
	/// </summary>
	CreateProtectedResourceSessionInvalidArgument = 1247,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_PSO_DESC_MISMATCH</b> = 1248
	/// </summary>
	CreategraphicspipelinestateMsPsoDescMismatch = 1248,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEPIPELINESTATE_MS_INCOMPLETE_TYPE</b> = 1249
	/// </summary>
	CreatepipelinestateMsIncompleteType = 1249,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_NOT_MS_MISMATCH</b> = 1250
	/// </summary>
	CreategraphicspipelinestateAsNotMsMismatch = 1250,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_NOT_PS_MISMATCH</b> = 1251
	/// </summary>
	CreategraphicspipelinestateMsNotPsMismatch = 1251,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_NONZERO_SAMPLER_FEEDBACK_MIP_REGION_WITH_INCOMPATIBLE_FORMAT</b> = 1252
	/// </summary>
	NonzeroSamplerFeedbackMipRegionWithIncompatibleFormat = 1252,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_SHADER_MISMATCH</b> = 1253
	/// </summary>
	CreategraphicspipelinestateInputlayoutShaderMismatch = 1253,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EMPTY_DISPATCH</b> = 1254
	/// </summary>
	EmptyDispatch = 1254,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOURCE_FORMAT_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY</b> = 1255
	/// </summary>
	ResourceFormatRequiresSamplerFeedbackCapability = 1255,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_MIP_REGION</b> = 1256
	/// </summary>
	SamplerFeedbackMapInvalidMipRegion = 1256,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_DIMENSION</b> = 1257
	/// </summary>
	SamplerFeedbackMapInvalidDimension = 1257,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_COUNT</b> = 1258
	/// </summary>
	SamplerFeedbackMapInvalidSampleCount = 1258,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_QUALITY</b> = 1259
	/// </summary>
	SamplerFeedbackMapInvalidSampleQuality = 1259,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_LAYOUT</b> = 1260
	/// </summary>
	SamplerFeedbackMapInvalidLayout = 1260,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_REQUIRES_UNORDERED_ACCESS_FLAG</b> = 1261
	/// </summary>
	SamplerFeedbackMapRequiresUnorderedAccessFlag = 1261,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_NULL_ARGUMENTS</b> = 1262
	/// </summary>
	SamplerFeedbackCreateUavNullArguments = 1262,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_UAV_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY</b> = 1263
	/// </summary>
	SamplerFeedbackUavRequiresSamplerFeedbackCapability = 1263,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_REQUIRES_FEEDBACK_MAP_FORMAT</b> = 1264
	/// </summary>
	SamplerFeedbackCreateUavRequiresFeedbackMapFormat = 1264,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEMESHSHADER_INVALIDSHADERBYTECODE</b> = 1265
	/// </summary>
	CreatemeshshaderInvalidshaderbytecode = 1265,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTOFMEMORY</b> = 1266
	/// </summary>
	CreatemeshshaderOutofmemory = 1266,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEMESHSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE</b> = 1267
	/// </summary>
	CreatemeshshaderwithstreamoutputInvalidshadertype = 1267,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_INVALID_FORMAT</b> = 1268
	/// </summary>
	ResolvesubresourceSamplerFeedbackTranscodeInvalidFormat = 1268,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_INVALID_MIP_LEVEL_COUNT</b> = 1269
	/// </summary>
	ResolvesubresourceSamplerFeedbackInvalidMipLevelCount = 1269,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_ARRAY_SIZE_MISMATCH</b> = 1270
	/// </summary>
	ResolvesubresourceSamplerFeedbackTranscodeArraySizeMismatch = 1270,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_MISMATCHING_TARGETED_RESOURCE</b> = 1271
	/// </summary>
	SamplerFeedbackCreateUavMismatchingTargetedResource = 1271,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTPUTEXCEEDSMAXSIZE</b> = 1272
	/// </summary>
	CreatemeshshaderOutputexceedsmaxsize = 1272,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEMESHSHADER_GROUPSHAREDEXCEEDSMAXSIZE</b> = 1273
	/// </summary>
	CreatemeshshaderGroupsharedexceedsmaxsize = 1273,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VERTEX_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE</b> = 1274
	/// </summary>
	VertexShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 1274,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_MESH_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE</b> = 1275
	/// </summary>
	MeshShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 1275,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEMESHSHADER_MISMATCHEDASMSPAYLOADSIZE</b> = 1276
	/// </summary>
	CreatemeshshaderMismatchedasmspayloadsize = 1276,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_UNBOUNDED_STATIC_DESCRIPTORS</b> = 1277
	/// </summary>
	CreateRootSignatureUnboundedStaticDescriptors = 1277,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_INVALIDSHADERBYTECODE</b> = 1278
	/// </summary>
	CreateamplificationshaderInvalidshaderbytecode = 1278,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_OUTOFMEMORY</b> = 1279
	/// </summary>
	CreateamplificationshaderOutofmemory = 1279,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_SHADERCACHESESSION</b> = 1280
	/// </summary>
	CreateShadercachesession = 1280,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_SHADERCACHESESSION</b> = 1281
	/// </summary>
	LiveShadercachesession = 1281,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_SHADERCACHESESSION</b> = 1282
	/// </summary>
	DestroyShadercachesession = 1282,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_INVALIDARGS</b> = 1283
	/// </summary>
	CreateshadercachesessionInvalidargs = 1283,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_DISABLED</b> = 1284
	/// </summary>
	CreateshadercachesessionDisabled = 1284,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_ALREADYOPEN</b> = 1285
	/// </summary>
	CreateshadercachesessionAlreadyopen = 1285,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHECONTROL_DEVELOPERMODE</b> = 1286
	/// </summary>
	ShadercachecontrolDevelopermode = 1286,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHECONTROL_INVALIDFLAGS</b> = 1287
	/// </summary>
	ShadercachecontrolInvalidflags = 1287,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHECONTROL_STATEALREADYSET</b> = 1288
	/// </summary>
	ShadercachecontrolStatealreadyset = 1288,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHECONTROL_IGNOREDFLAG</b> = 1289
	/// </summary>
	ShadercachecontrolIgnoredflag = 1289,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_ALREADYPRESENT</b> = 1290
	/// </summary>
	ShadercachesessionStorevalueAlreadypresent = 1290,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_HASHCOLLISION</b> = 1291
	/// </summary>
	ShadercachesessionStorevalueHashcollision = 1291,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_CACHEFULL</b> = 1292
	/// </summary>
	ShadercachesessionStorevalueCachefull = 1292,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHESESSION_FINDVALUE_NOTFOUND</b> = 1293
	/// </summary>
	ShadercachesessionFindvalueNotfound = 1293,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHESESSION_CORRUPT</b> = 1294
	/// </summary>
	ShadercachesessionCorrupt = 1294,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHESESSION_DISABLED</b> = 1295
	/// </summary>
	ShadercachesessionDisabled = 1295,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OVERSIZED_DISPATCH</b> = 1296
	/// </summary>
	OversizedDispatch = 1296,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOENCODER</b> = 1297
	/// </summary>
	CreateVideoencoder = 1297,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOENCODER</b> = 1298
	/// </summary>
	LiveVideoencoder = 1298,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOENCODER</b> = 1299
	/// </summary>
	DestroyVideoencoder = 1299,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEOENCODERHEAP</b> = 1300
	/// </summary>
	CreateVideoencoderheap = 1300,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LIVE_VIDEOENCODERHEAP</b> = 1301
	/// </summary>
	LiveVideoencoderheap = 1301,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESTROY_VIDEOENCODERHEAP</b> = 1302
	/// </summary>
	DestroyVideoencoderheap = 1302,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG</b> = 1303
	/// </summary>
	CopytextureregionMismatchEncodeReferenceOnlyFlag = 1303,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG</b> = 1304
	/// </summary>
	CopyresourceMismatchEncodeReferenceOnlyFlag = 1304,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ENCODE_FRAME_INVALID_PARAMETERS</b> = 1305
	/// </summary>
	EncodeFrameInvalidParameters = 1305,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ENCODE_FRAME_UNSUPPORTED_PARAMETERS</b> = 1306
	/// </summary>
	EncodeFrameUnsupportedParameters = 1306,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_INVALID_PARAMETERS</b> = 1307
	/// </summary>
	ResolveEncoderOutputMetadataInvalidParameters = 1307,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_UNSUPPORTED_PARAMETERS</b> = 1308
	/// </summary>
	ResolveEncoderOutputMetadataUnsupportedParameters = 1308,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_INVALID_PARAMETERS</b> = 1309
	/// </summary>
	CreateVideoEncoderInvalidParameters = 1309,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_UNSUPPORTED_PARAMETERS</b> = 1310
	/// </summary>
	CreateVideoEncoderUnsupportedParameters = 1310,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_INVALID_PARAMETERS</b> = 1311
	/// </summary>
	CreateVideoEncoderHeapInvalidParameters = 1311,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_UNSUPPORTED_PARAMETERS</b> = 1312
	/// </summary>
	CreateVideoEncoderHeapUnsupportedParameters = 1312,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATECOMMANDLIST_NULL_COMMANDALLOCATOR</b> = 1313
	/// </summary>
	CreatecommandlistNullCommandallocator = 1313,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CLEAR_UNORDERED_ACCESS_VIEW_INVALID_DESCRIPTOR_HANDLE</b> = 1314
	/// </summary>
	ClearUnorderedAccessViewInvalidDescriptorHandle = 1314,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DESCRIPTOR_HEAP_NOT_SHADER_VISIBLE</b> = 1315
	/// </summary>
	DescriptorHeapNotShaderVisible = 1315,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOP_WARNING</b> = 1316
	/// </summary>
	CreateblendstateBlendopWarning = 1316,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOPALPHA_WARNING</b> = 1317
	/// </summary>
	CreateblendstateBlendopalphaWarning = 1317,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_WRITE_COMBINE_PERFORMANCE_WARNING</b> = 1318
	/// </summary>
	WriteCombinePerformanceWarning = 1318,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_RESOLVE_QUERY_INVALID_QUERY_STATE</b> = 1319
	/// </summary>
	ResolveQueryInvalidQueryState = 1319,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETPRIVATEDATA_NO_ACCESS</b> = 1320
	/// </summary>
	SetprivatedataNoAccess = 1320,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_SAMPLER_MODE_MISMATCH</b> = 1321
	/// </summary>
	CommandListStaticDescriptorSamplerModeMismatch = 1321,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_UNSUPPORTED_BUFFER_WIDTH</b> = 1322
	/// </summary>
	GetcopyablefootprintsUnsupportedBufferWidth = 1322,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATEMESHSHADER_TOPOLOGY_MISMATCH</b> = 1323
	/// </summary>
	CreatemeshshaderTopologyMismatch = 1323,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_VRS_SUM_COMBINER_REQUIRES_CAPABILITY</b> = 1324
	/// </summary>
	VrsSumCombinerRequiresCapability = 1324,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SETTING_SHADING_RATE_FROM_MS_REQUIRES_CAPABILITY</b> = 1325
	/// </summary>
	SettingShadingRateFromMsRequiresCapability = 1325,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHESESSION_SHADERCACHEDELETE_NOTSUPPORTED</b> = 1326
	/// </summary>
	ShadercachesessionShadercachedeleteNotsupported = 1326,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADERCACHECONTROL_SHADERCACHECLEAR_NOTSUPPORTED</b> = 1327
	/// </summary>
	ShadercachecontrolShadercacheclearNotsupported = 1327,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCE_STATE_IGNORED</b> = 1328
	/// </summary>
	CreateresourceStateIgnored = 1328,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNUSED_CROSS_EXECUTE_SPLIT_BARRIER</b> = 1329
	/// </summary>
	UnusedCrossExecuteSplitBarrier = 1329,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_DEVICE_OPEN_SHARED_HANDLE_ACCESS_DENIED</b> = 1330
	/// </summary>
	DeviceOpenSharedHandleAccessDenied = 1330,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_VALUES</b> = 1331
	/// </summary>
	IncompatibleBarrierValues = 1331,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_ACCESS</b> = 1332
	/// </summary>
	IncompatibleBarrierAccess = 1332,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_SYNC</b> = 1333
	/// </summary>
	IncompatibleBarrierSync = 1333,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_LAYOUT</b> = 1334
	/// </summary>
	IncompatibleBarrierLayout = 1334,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_TYPE</b> = 1335
	/// </summary>
	IncompatibleBarrierType = 1335,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_OUT_OF_BOUNDS_BARRIER_SUBRESOURCE_RANGE</b> = 1336
	/// </summary>
	OutOfBoundsBarrierSubresourceRange = 1336,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_RESOURCE_DIMENSION</b> = 1337
	/// </summary>
	IncompatibleBarrierResourceDimension = 1337,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SET_SCISSOR_RECTS_INVALID_RECT</b> = 1338
	/// </summary>
	SetScissorRectsInvalidRect = 1338,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_SHADING_RATE_SOURCE_REQUIRES_DIMENSION_TEXTURE2D</b> = 1339
	/// </summary>
	ShadingRateSourceRequiresDimensionTexture2d = 1339,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_BUFFER_BARRIER_SUBREGION_OUT_OF_BOUNDS</b> = 1340
	/// </summary>
	BufferBarrierSubregionOutOfBounds = 1340,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_UNSUPPORTED_BARRIER_LAYOUT</b> = 1341
	/// </summary>
	UnsupportedBarrierLayout = 1341,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALID_PARAMETERS</b> = 1342
	/// </summary>
	CreateresourceandheapInvalidParameters = 1342,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ENHANCED_BARRIERS_NOT_SUPPORTED</b> = 1343
	/// </summary>
	EnhancedBarriersNotSupported = 1343,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CAST_TARGET_TEXEL_SIZE_MISMATCH</b> = 1344
	/// </summary>
	CastTargetTexelSizeMismatch = 1344,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_CAST_TO_PLANAR_NOT_SUPORTED</b> = 1345
	/// </summary>
	CastToPlanarNotSuported = 1345,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_LEGACY_BARRIER_VALIDATION_FORCED_ON</b> = 1346
	/// </summary>
	LegacyBarrierValidationForcedOn = 1346,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_EMPTY_ROOT_DESCRIPTOR_TABLE</b> = 1347
	/// </summary>
	EmptyRootDescriptorTable = 1347,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ELEMENT_OFFSET_UNALIGNED</b> = 1348
	/// </summary>
	CommandListDrawElementOffsetUnaligned = 1348,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_ALPHA_BLEND_FACTOR_NOT_SUPPORTED</b> = 1349
	/// </summary>
	AlphaBlendFactorNotSupported = 1349,
	/// <summary>
	/// <b>D3D12_MESSAGE_ID_D3D12_MESSAGES_END</b> = ( D3D12_MESSAGE_ID_ALPHA_BLEND_FACTOR_NOT_SUPPORTED + 1 )
	/// </summary>
	D3d12MessagesEnd = AlphaBlendFactorNotSupported + 1,
}

/// <summary>
/// ENUM <b>D3D12_MESSAGE_CALLBACK_FLAGS</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
public enum MessageCallbackFlags : uint {
	/// <summary>
	/// <b>D3D12_MESSAGE_CALLBACK_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_MESSAGE_CALLBACK_IGNORE_FILTERS</b> = 0x1
	/// </summary>
	IgnoreFilters = 1,
}

/// <summary>
/// ENUM <b>D3D12_SHADER_VERSION_TYPE</b><br/>
/// D3D12SHADER.h
/// </summary>
public enum ShaderVersionType : uint {
	/// <summary>
	/// <b>D3D12_SHVER_PIXEL_SHADER</b> = 0
	/// </summary>
	ShverPixelShader = 0,
	/// <summary>
	/// <b>D3D12_SHVER_VERTEX_SHADER</b> = 1
	/// </summary>
	ShverVertexShader = 1,
	/// <summary>
	/// <b>D3D12_SHVER_GEOMETRY_SHADER</b> = 2
	/// </summary>
	ShverGeometryShader = 2,
	/// <summary>
	/// <b>D3D12_SHVER_HULL_SHADER</b> = 3
	/// </summary>
	ShverHullShader = 3,
	/// <summary>
	/// <b>D3D12_SHVER_DOMAIN_SHADER</b> = 4
	/// </summary>
	ShverDomainShader = 4,
	/// <summary>
	/// <b>D3D12_SHVER_COMPUTE_SHADER</b> = 5
	/// </summary>
	ShverComputeShader = 5,
	/// <summary>
	/// <b>D3D12_SHVER_LIBRARY</b> = 6
	/// </summary>
	ShverLibrary = 6,
	/// <summary>
	/// <b>D3D12_SHVER_RAY_GENERATION_SHADER</b> = 7
	/// </summary>
	ShverRayGenerationShader = 7,
	/// <summary>
	/// <b>D3D12_SHVER_INTERSECTION_SHADER</b> = 8
	/// </summary>
	ShverIntersectionShader = 8,
	/// <summary>
	/// <b>D3D12_SHVER_ANY_HIT_SHADER</b> = 9
	/// </summary>
	ShverAnyHitShader = 9,
	/// <summary>
	/// <b>D3D12_SHVER_CLOSEST_HIT_SHADER</b> = 10
	/// </summary>
	ShverClosestHitShader = 10,
	/// <summary>
	/// <b>D3D12_SHVER_MISS_SHADER</b> = 11
	/// </summary>
	ShverMissShader = 11,
	/// <summary>
	/// <b>D3D12_SHVER_CALLABLE_SHADER</b> = 12
	/// </summary>
	ShverCallableShader = 12,
	/// <summary>
	/// <b>D3D12_SHVER_MESH_SHADER</b> = 13
	/// </summary>
	ShverMeshShader = 13,
	/// <summary>
	/// <b>D3D12_SHVER_AMPLIFICATION_SHADER</b> = 14
	/// </summary>
	ShverAmplificationShader = 14,
	/// <summary>
	/// <b>D3D12_SHVER_RESERVED0</b> = 0xFFF0
	/// </summary>
	ShverReserved0 = 65520,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_FIELD_TYPE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoFieldType : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_FIELD_TYPE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_FIELD_TYPE_INTERLACED_TOP_FIELD_FIRST</b> = 1
	/// </summary>
	InterlacedTopFieldFirst = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_FIELD_TYPE_INTERLACED_BOTTOM_FIELD_FIRST</b> = 2
	/// </summary>
	InterlacedBottomFieldFirst = 2,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_FRAME_STEREO_FORMAT</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoFrameStereoFormat : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT_MONO</b> = 1
	/// </summary>
	Mono = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT_HORIZONTAL</b> = 2
	/// </summary>
	Horizontal = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT_VERTICAL</b> = 3
	/// </summary>
	Vertical = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT_SEPARATE</b> = 4
	/// </summary>
	Separate = 4,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoFrameCodedInterlaceType : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_FIELD_BASED</b> = 1
	/// </summary>
	FieldBased = 1,
}

/// <summary>
/// ENUM <b>D3D12_FEATURE_VIDEO</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum FeatureVideo : uint {
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_SUPPORT</b> = 0
	/// </summary>
	DecodeSupport = 0,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_PROFILES</b> = 1
	/// </summary>
	DecodeProfiles = 1,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_FORMATS</b> = 2
	/// </summary>
	DecodeFormats = 2,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_CONVERSION_SUPPORT</b> = 3
	/// </summary>
	DecodeConversionSupport = 3,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_PROCESS_SUPPORT</b> = 5
	/// </summary>
	ProcessSupport = 5,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_PROCESS_MAX_INPUT_STREAMS</b> = 6
	/// </summary>
	ProcessMaxInputStreams = 6,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_PROCESS_REFERENCE_INFO</b> = 7
	/// </summary>
	ProcessReferenceInfo = 7,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE</b> = 8
	/// </summary>
	DecoderHeapSize = 8,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_PROCESSOR_SIZE</b> = 9
	/// </summary>
	ProcessorSize = 9,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_PROFILE_COUNT</b> = 10
	/// </summary>
	DecodeProfileCount = 10,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_FORMAT_COUNT</b> = 11
	/// </summary>
	DecodeFormatCount = 11,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ARCHITECTURE</b> = 17
	/// </summary>
	Architecture = 17,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_HISTOGRAM</b> = 18
	/// </summary>
	DecodeHistogram = 18,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_FEATURE_AREA_SUPPORT</b> = 19
	/// </summary>
	FeatureAreaSupport = 19,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR</b> = 20
	/// </summary>
	MotionEstimator = 20,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_SIZE</b> = 21
	/// </summary>
	MotionEstimatorSize = 21,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_COUNT</b> = 22
	/// </summary>
	ExtensionCommandCount = 22,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_EXTENSION_COMMANDS</b> = 23
	/// </summary>
	ExtensionCommands = 23,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT</b> = 24
	/// </summary>
	ExtensionCommandParameterCount = 24,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETERS</b> = 25
	/// </summary>
	ExtensionCommandParameters = 25,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SUPPORT</b> = 26
	/// </summary>
	ExtensionCommandSupport = 26,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SIZE</b> = 27
	/// </summary>
	ExtensionCommandSize = 27,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODE_PROTECTED_RESOURCES</b> = 28
	/// </summary>
	DecodeProtectedResources = 28,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_PROCESS_PROTECTED_RESOURCES</b> = 29
	/// </summary>
	ProcessProtectedResources = 29,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES</b> = 30
	/// </summary>
	MotionEstimatorProtectedResources = 30,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE1</b> = 31
	/// </summary>
	DecoderHeapSize1 = 31,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_PROCESSOR_SIZE1</b> = 32
	/// </summary>
	ProcessorSize1 = 32,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_CODEC</b> = 33
	/// </summary>
	EncoderCodec = 33,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_PROFILE_LEVEL</b> = 34
	/// </summary>
	EncoderProfileLevel = 34,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION_RATIOS_COUNT</b> = 35
	/// </summary>
	EncoderOutputResolutionRatiosCount = 35,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION</b> = 36
	/// </summary>
	EncoderOutputResolution = 36,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_INPUT_FORMAT</b> = 37
	/// </summary>
	EncoderInputFormat = 37,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_RATE_CONTROL_MODE</b> = 38
	/// </summary>
	EncoderRateControlMode = 38,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_INTRA_REFRESH_MODE</b> = 39
	/// </summary>
	EncoderIntraRefreshMode = 39,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE</b> = 40
	/// </summary>
	EncoderFrameSubregionLayoutMode = 40,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_HEAP_SIZE</b> = 41
	/// </summary>
	EncoderHeapSize = 41,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT</b> = 42
	/// </summary>
	EncoderCodecConfigurationSupport = 42,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_SUPPORT</b> = 43
	/// </summary>
	EncoderSupport = 43,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT</b> = 44
	/// </summary>
	EncoderCodecPictureControlSupport = 44,
	/// <summary>
	/// <b>D3D12_FEATURE_VIDEO_ENCODER_RESOURCE_REQUIREMENTS</b> = 45
	/// </summary>
	EncoderResourceRequirements = 45,
}

/// <summary>
/// ENUM <b>D3D12_BITSTREAM_ENCRYPTION_TYPE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum BitstreamEncryptionType : uint {
	/// <summary>
	/// <b>D3D12_BITSTREAM_ENCRYPTION_TYPE_NONE</b> = 0
	/// </summary>
	None = 0,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_FILTER</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoProcessFilter : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS</b> = 0
	/// </summary>
	Brightness = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_CONTRAST</b> = 1
	/// </summary>
	Contrast = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_HUE</b> = 2
	/// </summary>
	Hue = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_SATURATION</b> = 3
	/// </summary>
	Saturation = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION</b> = 4
	/// </summary>
	NoiseReduction = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT</b> = 5
	/// </summary>
	EdgeEnhancement = 5,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING</b> = 6
	/// </summary>
	AnamorphicScaling = 6,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT</b> = 7
	/// </summary>
	StereoAdjustment = 7,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_FILTER_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoProcessFilterFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS )
	/// </summary>
	FlagBrightness = 1 << (int) VideoProcessFilter.Brightness,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_CONTRAST )
	/// </summary>
	FlagContrast = 1 << (int) VideoProcessFilter.Contrast,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_HUE )
	/// </summary>
	FlagHue = 1 << (int) VideoProcessFilter.Hue,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_SATURATION )
	/// </summary>
	FlagSaturation = 1 << (int) VideoProcessFilter.Saturation,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION )
	/// </summary>
	FlagNoiseReduction = 1 << (int) VideoProcessFilter.NoiseReduction,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT )
	/// </summary>
	FlagEdgeEnhancement = 1 << (int) VideoProcessFilter.EdgeEnhancement,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING )
	/// </summary>
	FlagAnamorphicScaling = 1 << (int) VideoProcessFilter.AnamorphicScaling,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT</b> = ( 1 &lt;&lt; D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT )
	/// </summary>
	FlagStereoAdjustment = 1 << (int) VideoProcessFilter.StereoAdjustment,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoProcessDeinterlaceFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB</b> = 0x1
	/// </summary>
	FlagBob = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM</b> = 0x80000000
	/// </summary>
	FlagCustom = 2147483648,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoProcessAlphaFillMode : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE</b> = 0
	/// </summary>
	Opaque = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND</b> = 1
	/// </summary>
	Background = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION</b> = 2
	/// </summary>
	Destination = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM</b> = 3
	/// </summary>
	SourceStream = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_TIER</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoDecodeTier : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_TIER_NOT_SUPPORTED</b> = 0
	/// </summary>
	NotSupported = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_TIER_1</b> = 1
	/// </summary>
	Tier1 = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_TIER_2</b> = 2
	/// </summary>
	Tier2 = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_TIER_3</b> = 3
	/// </summary>
	Tier3 = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_SUPPORT_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoDecodeSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_SUPPORT_FLAG_SUPPORTED</b> = 0x1
	/// </summary>
	FlagSupported = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoDecodeConfigurationFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_HEIGHT_ALIGNMENT_MULTIPLE_32_REQUIRED</b> = 0x1
	/// </summary>
	FlagHeightAlignmentMultiple32Required = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_POST_PROCESSING_SUPPORTED</b> = 0x2
	/// </summary>
	FlagPostProcessingSupported = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_REFERENCE_ONLY_ALLOCATIONS_REQUIRED</b> = 0x4
	/// </summary>
	FlagReferenceOnlyAllocationsRequired = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_ALLOW_RESOLUTION_CHANGE_ON_NON_KEY_FRAME</b> = 0x8
	/// </summary>
	FlagAllowResolutionChangeOnNonKeyFrame = 8,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_STATUS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoDecodeStatus : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_STATUS_OK</b> = 0
	/// </summary>
	Ok = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_STATUS_CONTINUE</b> = 1
	/// </summary>
	Continue = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY</b> = 2
	/// </summary>
	ContinueSkipDisplay = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_STATUS_RESTART</b> = 3
	/// </summary>
	Restart = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED</b> = 4
	/// </summary>
	RateExceeded = 4,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_ARGUMENT_TYPE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoDecodeArgumentType : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS</b> = 0
	/// </summary>
	PictureParameters = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX</b> = 1
	/// </summary>
	InverseQuantizationMatrix = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL</b> = 2
	/// </summary>
	SliceControl = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_ARGUMENT_TYPE_MAX_VALID</b> = 3
	/// </summary>
	MaxValid = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoDecodeHistogramComponent : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y</b> = 0
	/// </summary>
	Y = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U</b> = 1
	/// </summary>
	U = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V</b> = 2
	/// </summary>
	V = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R</b> = 0
	/// </summary>
	R = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G</b> = 1
	/// </summary>
	G = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B</b> = 2
	/// </summary>
	B = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A</b> = 3
	/// </summary>
	A = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoDecodeHistogramComponentFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_Y</b> = ( 1 &lt;&lt; D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y )
	/// </summary>
	FlagY = 1 << (int) VideoDecodeHistogramComponent.Y,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_U</b> = ( 1 &lt;&lt; D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U )
	/// </summary>
	FlagU = 1 << (int) VideoDecodeHistogramComponent.U,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_V</b> = ( 1 &lt;&lt; D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V )
	/// </summary>
	FlagV = 1 << (int) VideoDecodeHistogramComponent.V,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_R</b> = ( 1 &lt;&lt; D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R )
	/// </summary>
	FlagR = 1 << (int) VideoDecodeHistogramComponent.R,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_G</b> = ( 1 &lt;&lt; D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G )
	/// </summary>
	FlagG = 1 << (int) VideoDecodeHistogramComponent.G,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_B</b> = ( 1 &lt;&lt; D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B )
	/// </summary>
	FlagB = 1 << (int) VideoDecodeHistogramComponent.B,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_A</b> = ( 1 &lt;&lt; D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A )
	/// </summary>
	FlagA = 1 << (int) VideoDecodeHistogramComponent.A,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoDecodeConversionSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAG_SUPPORTED</b> = 0x1
	/// </summary>
	FlagSupported = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_SCALE_SUPPORT_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoScaleSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_SCALE_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_SCALE_SUPPORT_FLAG_POW2_ONLY</b> = 0x1
	/// </summary>
	FlagPow2Only = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_SCALE_SUPPORT_FLAG_EVEN_DIMENSIONS_ONLY</b> = 0x2
	/// </summary>
	FlagEvenDimensionsOnly = 2,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_FEATURE_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoProcessFeatureFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL</b> = 0x1
	/// </summary>
	FlagAlphaFill = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY</b> = 0x2
	/// </summary>
	FlagLumaKey = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO</b> = 0x4
	/// </summary>
	FlagStereo = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION</b> = 0x8
	/// </summary>
	FlagRotation = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP</b> = 0x10
	/// </summary>
	FlagFlip = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING</b> = 0x20
	/// </summary>
	FlagAlphaBlending = 32,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO</b> = 0x40
	/// </summary>
	FlagPixelAspectRatio = 64,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoProcessAutoProcessingFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE</b> = 0x1
	/// </summary>
	FlagDenoise = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING</b> = 0x2
	/// </summary>
	FlagDeringing = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT</b> = 0x4
	/// </summary>
	FlagEdgeEnhancement = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION</b> = 0x8
	/// </summary>
	FlagColorCorrection = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING</b> = 0x10
	/// </summary>
	FlagFleshToneMapping = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION</b> = 0x20
	/// </summary>
	FlagImageStabilization = 32,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION</b> = 0x40
	/// </summary>
	FlagSuperResolution = 64,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING</b> = 0x80
	/// </summary>
	FlagAnamorphicScaling = 128,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM</b> = 0x80000000
	/// </summary>
	FlagCustom = 2147483648,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_ORIENTATION</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoProcessOrientation : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL</b> = 1
	/// </summary>
	FlipHorizontal = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90</b> = 2
	/// </summary>
	Clockwise90 = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL</b> = 3
	/// </summary>
	Clockwise90FlipHorizontal = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180</b> = 4
	/// </summary>
	Clockwise180 = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL</b> = 5
	/// </summary>
	FlipVertical = 5,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270</b> = 6
	/// </summary>
	Clockwise270 = 6,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL</b> = 7
	/// </summary>
	Clockwise270FlipHorizontal = 7,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoProcessInputStreamFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY</b> = 0x1
	/// </summary>
	FlagFrameDiscontinuity = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT</b> = 0x2
	/// </summary>
	FlagFrameRepeat = 2,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROCESS_SUPPORT_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoProcessSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_SUPPORT_FLAG_SUPPORTED</b> = 0x1
	/// </summary>
	FlagSupported = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoMotionEstimatorSearchBlockSize : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_8X8</b> = 0
	/// </summary>
	Size8X8 = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_16X16</b> = 1
	/// </summary>
	Size16X16 = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoMotionEstimatorSearchBlockSizeFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAG_8X8</b> = ( 1 &lt;&lt; D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_8X8 )
	/// </summary>
	Flag8X8 = 1 << (int) VideoMotionEstimatorSearchBlockSize.Size8X8,
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAG_16X16</b> = ( 1 &lt;&lt; D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_16X16 )
	/// </summary>
	Flag16X16 = 1 << (int) VideoMotionEstimatorSearchBlockSize.Size16X16,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoMotionEstimatorVectorPrecision : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL</b> = 0
	/// </summary>
	QuarterPel = 0,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoMotionEstimatorVectorPrecisionFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL</b> = ( 1 &lt;&lt; D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL )
	/// </summary>
	FlagQuarterPel = 1 << (int) VideoMotionEstimatorVectorPrecision.QuarterPel,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoProtectedResourceSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_SUPPORTED</b> = 0x1
	/// </summary>
	FlagSupported = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoExtensionCommandParameterStage : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CREATION</b> = 0
	/// </summary>
	Creation = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_INITIALIZATION</b> = 1
	/// </summary>
	Initialization = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_EXECUTION</b> = 2
	/// </summary>
	Execution = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_INPUT</b> = 3
	/// </summary>
	CapsInput = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_OUTPUT</b> = 4
	/// </summary>
	CapsOutput = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_INPUT</b> = 5
	/// </summary>
	DeviceExecuteInput = 5,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_OUTPUT</b> = 6
	/// </summary>
	DeviceExecuteOutput = 6,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoExtensionCommandParameterType : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT8</b> = 0
	/// </summary>
	Uint8 = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT16</b> = 1
	/// </summary>
	Uint16 = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT32</b> = 2
	/// </summary>
	Uint32 = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT64</b> = 3
	/// </summary>
	Uint64 = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT8</b> = 4
	/// </summary>
	Sint8 = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT16</b> = 5
	/// </summary>
	Sint16 = 5,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT32</b> = 6
	/// </summary>
	Sint32 = 6,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT64</b> = 7
	/// </summary>
	Sint64 = 7,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_FLOAT</b> = 8
	/// </summary>
	Float = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_DOUBLE</b> = 9
	/// </summary>
	Double = 9,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_RESOURCE</b> = 10
	/// </summary>
	Resource = 10,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoExtensionCommandParameterFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ</b> = 0x1
	/// </summary>
	FlagRead = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE</b> = 0x2
	/// </summary>
	FlagWrite = 2,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderRateControlMode : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP</b> = 0
	/// </summary>
	AbsoluteQpMap = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP</b> = 1
	/// </summary>
	Cqp = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR</b> = 2
	/// </summary>
	Cbr = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR</b> = 3
	/// </summary>
	Vbr = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR</b> = 4
	/// </summary>
	Qvbr = 4,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderRateControlFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP</b> = 0x1
	/// </summary>
	FlagEnableDeltaQp = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS</b> = 0x2
	/// </summary>
	FlagEnableFrameAnalysis = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE</b> = 0x4
	/// </summary>
	FlagEnableQpRange = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP</b> = 0x8
	/// </summary>
	FlagEnableInitialQp = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE</b> = 0x10
	/// </summary>
	FlagEnableMaxFrameSize = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES</b> = 0x20
	/// </summary>
	FlagEnableVbvSizes = 32,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderCodec : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_H264</b> = 0
	/// </summary>
	H264 = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_HEVC</b> = 1
	/// </summary>
	Hevc = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_PROFILE_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderProfileH264 : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_H264_MAIN</b> = 0
	/// </summary>
	Main = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH</b> = 1
	/// </summary>
	High = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH_10</b> = 2
	/// </summary>
	High10 = 2,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_PROFILE_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderProfileHevc : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN</b> = 0
	/// </summary>
	Main = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10</b> = 1
	/// </summary>
	Main10 = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_LEVELS_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderLevelsH264 : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_1</b> = 0
	/// </summary>
	H2641 = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_1b</b> = 1
	/// </summary>
	H2641b = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_11</b> = 2
	/// </summary>
	H26411 = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_12</b> = 3
	/// </summary>
	H26412 = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_13</b> = 4
	/// </summary>
	H26413 = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_2</b> = 5
	/// </summary>
	H2642 = 5,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_21</b> = 6
	/// </summary>
	H26421 = 6,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_22</b> = 7
	/// </summary>
	H26422 = 7,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_3</b> = 8
	/// </summary>
	H2643 = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_31</b> = 9
	/// </summary>
	H26431 = 9,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_32</b> = 10
	/// </summary>
	H26432 = 10,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_4</b> = 11
	/// </summary>
	H2644 = 11,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_41</b> = 12
	/// </summary>
	H26441 = 12,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_42</b> = 13
	/// </summary>
	H26442 = 13,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_5</b> = 14
	/// </summary>
	H2645 = 14,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_51</b> = 15
	/// </summary>
	H26451 = 15,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_52</b> = 16
	/// </summary>
	H26452 = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_6</b> = 17
	/// </summary>
	H2646 = 17,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_61</b> = 18
	/// </summary>
	H26461 = 18,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264_62</b> = 19
	/// </summary>
	H26462 = 19,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_TIER_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderTierHevc : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_TIER_HEVC_MAIN</b> = 0
	/// </summary>
	Main = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_TIER_HEVC_HIGH</b> = 1
	/// </summary>
	High = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderLevelsHevc : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_1</b> = 0
	/// </summary>
	Hevc1 = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_2</b> = 1
	/// </summary>
	Hevc2 = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_21</b> = 2
	/// </summary>
	Hevc21 = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_3</b> = 3
	/// </summary>
	Hevc3 = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_31</b> = 4
	/// </summary>
	Hevc31 = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_4</b> = 5
	/// </summary>
	Hevc4 = 5,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_41</b> = 6
	/// </summary>
	Hevc41 = 6,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_5</b> = 7
	/// </summary>
	Hevc5 = 7,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_51</b> = 8
	/// </summary>
	Hevc51 = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_52</b> = 9
	/// </summary>
	Hevc52 = 9,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_6</b> = 10
	/// </summary>
	Hevc6 = 10,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_61</b> = 11
	/// </summary>
	Hevc61 = 11,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC_62</b> = 12
	/// </summary>
	Hevc62 = 12,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderIntraRefreshMode : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_ROW_BASED</b> = 1
	/// </summary>
	RowBased = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderFrameSubregionLayoutMode : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_FULL_FRAME</b> = 0
	/// </summary>
	FullFrame = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_BYTES_PER_SUBREGION</b> = 1
	/// </summary>
	BytesPerSubregion = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_SQUARE_UNITS_PER_SUBREGION_ROW_UNALIGNED</b> = 2
	/// </summary>
	SquareUnitsPerSubregionRowUnaligned = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_ROWS_PER_SUBREGION</b> = 3
	/// </summary>
	UniformPartitioningRowsPerSubregion = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_SUBREGIONS_PER_FRAME</b> = 4
	/// </summary>
	UniformPartitioningSubregionsPerFrame = 4,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_HEAP_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderHeapFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_HEAP_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderCodecConfigurationSupportH264Flags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CABAC_ENCODING_SUPPORT</b> = 0x1
	/// </summary>
	FlagCabacEncodingSupport = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT</b> = 0x2
	/// </summary>
	FlagIntraSliceConstrainedEncodingSupport = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_BFRAME_LTR_COMBINED_SUPPORT</b> = 0x4
	/// </summary>
	FlagBframeLtrCombinedSupport = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_ADAPTIVE_8x8_TRANSFORM_ENCODING_SUPPORT</b> = 0x8
	/// </summary>
	FlagAdaptive8x8TransformEncodingSupport = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_SPATIAL_ENCODING_SUPPORT</b> = 0x10
	/// </summary>
	FlagDirectSpatialEncodingSupport = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_TEMPORAL_ENCODING_SUPPORT</b> = 0x20
	/// </summary>
	FlagDirectTemporalEncodingSupport = 32,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT</b> = 0x40
	/// </summary>
	FlagConstrainedIntrapredictionSupport = 64,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODES</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderCodecConfigurationH264SlicesDeblockingModes : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_0_ALL_LUMA_CHROMA_SLICE_BLOCK_EDGES_ALWAYS_FILTERED</b> = 0
	/// </summary>
	Mode0AllLumaChromaSliceBlockEdgesAlwaysFiltered = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_1_DISABLE_ALL_SLICE_BLOCK_EDGES</b> = 1
	/// </summary>
	Mode1DisableAllSliceBlockEdges = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_2_DISABLE_SLICE_BOUNDARIES_BLOCKS</b> = 2
	/// </summary>
	Mode2DisableSliceBoundariesBlocks = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_3_USE_TWO_STAGE_DEBLOCKING</b> = 3
	/// </summary>
	Mode3UseTwoStageDeblocking = 3,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_4_DISABLE_CHROMA_BLOCK_EDGES</b> = 4
	/// </summary>
	Mode4DisableChromaBlockEdges = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_5_DISABLE_CHROMA_BLOCK_EDGES_AND_LUMA_BOUNDARIES</b> = 5
	/// </summary>
	Mode5DisableChromaBlockEdgesAndLumaBoundaries = 5,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_6_DISABLE_CHROMA_BLOCK_EDGES_AND_USE_LUMA_TWO_STAGE_DEBLOCKING</b> = 6
	/// </summary>
	Mode6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking = 6,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_0_ALL_LUMA_CHROMA_SLICE_BLOCK_EDGES_ALWAYS_FILTERED</b> = ( 1 &lt;&lt; D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_0_ALL_LUMA_CHROMA_SLICE_BLOCK_EDGES_ALWAYS_FILTERED )
	/// </summary>
	Flag0AllLumaChromaSliceBlockEdgesAlwaysFiltered = 1 << (int) VideoEncoderCodecConfigurationH264SlicesDeblockingModes.Mode0AllLumaChromaSliceBlockEdgesAlwaysFiltered,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_1_DISABLE_ALL_SLICE_BLOCK_EDGES</b> = ( 1 &lt;&lt; D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_1_DISABLE_ALL_SLICE_BLOCK_EDGES )
	/// </summary>
	Flag1DisableAllSliceBlockEdges = 1 << (int) VideoEncoderCodecConfigurationH264SlicesDeblockingModes.Mode1DisableAllSliceBlockEdges,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_2_DISABLE_SLICE_BOUNDARIES_BLOCKS</b> = ( 1 &lt;&lt; D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_2_DISABLE_SLICE_BOUNDARIES_BLOCKS )
	/// </summary>
	Flag2DisableSliceBoundariesBlocks = 1 << (int) VideoEncoderCodecConfigurationH264SlicesDeblockingModes.Mode2DisableSliceBoundariesBlocks,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_3_USE_TWO_STAGE_DEBLOCKING</b> = ( 1 &lt;&lt; D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_3_USE_TWO_STAGE_DEBLOCKING )
	/// </summary>
	Flag3UseTwoStageDeblocking = 1 << (int) VideoEncoderCodecConfigurationH264SlicesDeblockingModes.Mode3UseTwoStageDeblocking,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_4_DISABLE_CHROMA_BLOCK_EDGES</b> = ( 1 &lt;&lt; D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_4_DISABLE_CHROMA_BLOCK_EDGES )
	/// </summary>
	Flag4DisableChromaBlockEdges = 1 << (int) VideoEncoderCodecConfigurationH264SlicesDeblockingModes.Mode4DisableChromaBlockEdges,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_5_DISABLE_CHROMA_BLOCK_EDGES_AND_LUMA_BOUNDARIES</b> = ( 1 &lt;&lt; D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_5_DISABLE_CHROMA_BLOCK_EDGES_AND_LUMA_BOUNDARIES )
	/// </summary>
	Flag5DisableChromaBlockEdgesAndLumaBoundaries = 1 << (int) VideoEncoderCodecConfigurationH264SlicesDeblockingModes.Mode5DisableChromaBlockEdgesAndLumaBoundaries,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_6_DISABLE_CHROMA_BLOCK_EDGES_AND_USE_LUMA_TWO_STAGE_DEBLOCKING</b> = ( 1 &lt;&lt; D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_6_DISABLE_CHROMA_BLOCK_EDGES_AND_USE_LUMA_TWO_STAGE_DEBLOCKING )
	/// </summary>
	Flag6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking = 1 << (int) VideoEncoderCodecConfigurationH264SlicesDeblockingModes.Mode6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderCodecConfigurationSupportHevcFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_BFRAME_LTR_COMBINED_SUPPORT</b> = 0x1
	/// </summary>
	FlagBframeLtrCombinedSupport = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT</b> = 0x2
	/// </summary>
	FlagIntraSliceConstrainedEncodingSupport = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT</b> = 0x4
	/// </summary>
	FlagConstrainedIntrapredictionSupport = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_SAO_FILTER_SUPPORT</b> = 0x8
	/// </summary>
	FlagSaoFilterSupport = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_SUPPORT</b> = 0x10
	/// </summary>
	FlagAsymetricMotionPartitionSupport = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_REQUIRED</b> = 0x20
	/// </summary>
	FlagAsymetricMotionPartitionRequired = 32,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_SUPPORT</b> = 0x40
	/// </summary>
	FlagTransformSkipSupport = 64,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_DISABLING_LOOP_FILTER_ACROSS_SLICES_SUPPORT</b> = 0x80
	/// </summary>
	FlagDisablingLoopFilterAcrossSlicesSupport = 128,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_P_FRAMES_IMPLEMENTED_AS_LOW_DELAY_B_FRAMES</b> = 0x100
	/// </summary>
	FlagPFramesImplementedAsLowDelayBFrames = 256,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderCodecConfigurationHevcCusize : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_8x8</b> = 0
	/// </summary>
	Cusize8x8 = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_16x16</b> = 1
	/// </summary>
	Cusize16x16 = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_32x32</b> = 2
	/// </summary>
	Cusize32x32 = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_64x64</b> = 3
	/// </summary>
	Cusize64x64 = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderCodecConfigurationHevcTusize : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_4x4</b> = 0
	/// </summary>
	Tusize4x4 = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_8x8</b> = 1
	/// </summary>
	Tusize8x8 = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_16x16</b> = 2
	/// </summary>
	Tusize16x16 = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_32x32</b> = 3
	/// </summary>
	Tusize32x32 = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderSupportFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_GENERAL_SUPPORT_OK</b> = 0x1
	/// </summary>
	FlagGeneralSupportOk = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_RECONFIGURATION_AVAILABLE</b> = 0x2
	/// </summary>
	FlagRateControlReconfigurationAvailable = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RESOLUTION_RECONFIGURATION_AVAILABLE</b> = 0x4
	/// </summary>
	FlagResolutionReconfigurationAvailable = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_VBV_SIZE_CONFIG_AVAILABLE</b> = 0x8
	/// </summary>
	FlagRateControlVbvSizeConfigAvailable = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_FRAME_ANALYSIS_AVAILABLE</b> = 0x10
	/// </summary>
	FlagRateControlFrameAnalysisAvailable = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RECONSTRUCTED_FRAMES_REQUIRE_TEXTURE_ARRAYS</b> = 0x20
	/// </summary>
	FlagReconstructedFramesRequireTextureArrays = 32,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_DELTA_QP_AVAILABLE</b> = 0x40
	/// </summary>
	FlagRateControlDeltaQpAvailable = 64,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SUBREGION_LAYOUT_RECONFIGURATION_AVAILABLE</b> = 0x80
	/// </summary>
	FlagSubregionLayoutReconfigurationAvailable = 128,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_ADJUSTABLE_QP_RANGE_AVAILABLE</b> = 0x100
	/// </summary>
	FlagRateControlAdjustableQpRangeAvailable = 256,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_INITIAL_QP_AVAILABLE</b> = 0x200
	/// </summary>
	FlagRateControlInitialQpAvailable = 512,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_MAX_FRAME_SIZE_AVAILABLE</b> = 0x400
	/// </summary>
	FlagRateControlMaxFrameSizeAvailable = 1024,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SEQUENCE_GOP_RECONFIGURATION_AVAILABLE</b> = 0x800
	/// </summary>
	FlagSequenceGopReconfigurationAvailable = 2048,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAG_MOTION_ESTIMATION_PRECISION_MODE_LIMIT_AVAILABLE</b> = 0x1000
	/// </summary>
	FlagMotionEstimationPrecisionModeLimitAvailable = 4096,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderCodecConfigurationH264Flags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_CONSTRAINED_INTRAPREDICTION</b> = 0x1
	/// </summary>
	FlagUseConstrainedIntraprediction = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_ADAPTIVE_8x8_TRANSFORM</b> = 0x2
	/// </summary>
	FlagUseAdaptive8x8Transform = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ENABLE_CABAC_ENCODING</b> = 0x4
	/// </summary>
	FlagEnableCabacEncoding = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES</b> = 0x8
	/// </summary>
	FlagAllowRequestIntraConstrainedSlices = 8,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderCodecConfigurationH264DirectModes : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_DISABLED</b> = 0
	/// </summary>
	Disabled = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_TEMPORAL</b> = 1
	/// </summary>
	Temporal = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_SPATIAL</b> = 2
	/// </summary>
	Spatial = 2,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderCodecConfigurationHevcFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_DISABLE_LOOP_FILTER_ACROSS_SLICES</b> = 0x1
	/// </summary>
	FlagDisableLoopFilterAcrossSlices = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES</b> = 0x2
	/// </summary>
	FlagAllowRequestIntraConstrainedSlices = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_SAO_FILTER</b> = 0x4
	/// </summary>
	FlagEnableSaoFilter = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_LONG_TERM_REFERENCES</b> = 0x8
	/// </summary>
	FlagEnableLongTermReferences = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_ASYMETRIC_MOTION_PARTITION</b> = 0x10
	/// </summary>
	FlagUseAsymetricMotionPartition = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_TRANSFORM_SKIPPING</b> = 0x20
	/// </summary>
	FlagEnableTransformSkipping = 32,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_CONSTRAINED_INTRAPREDICTION</b> = 0x40
	/// </summary>
	FlagUseConstrainedIntraprediction = 64,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderMotionEstimationPrecisionMode : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_MAXIMUM</b> = 0
	/// </summary>
	Maximum = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_FULL_PIXEL</b> = 1
	/// </summary>
	FullPixel = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_HALF_PIXEL</b> = 2
	/// </summary>
	HalfPixel = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_QUARTER_PIXEL</b> = 3
	/// </summary>
	QuarterPixel = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderValidationFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_NOT_SUPPORTED</b> = 0x1
	/// </summary>
	FlagCodecNotSupported = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INPUT_FORMAT_NOT_SUPPORTED</b> = 0x8
	/// </summary>
	FlagInputFormatNotSupported = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_CONFIGURATION_NOT_SUPPORTED</b> = 0x10
	/// </summary>
	FlagCodecConfigurationNotSupported = 16,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_MODE_NOT_SUPPORTED</b> = 0x20
	/// </summary>
	FlagRateControlModeNotSupported = 32,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_CONFIGURATION_NOT_SUPPORTED</b> = 0x40
	/// </summary>
	FlagRateControlConfigurationNotSupported = 64,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INTRA_REFRESH_MODE_NOT_SUPPORTED</b> = 0x80
	/// </summary>
	FlagIntraRefreshModeNotSupported = 128,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_MODE_NOT_SUPPORTED</b> = 0x100
	/// </summary>
	FlagSubregionLayoutModeNotSupported = 256,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RESOLUTION_NOT_SUPPORTED_IN_LIST</b> = 0x200
	/// </summary>
	FlagResolutionNotSupportedInList = 512,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAG_GOP_STRUCTURE_NOT_SUPPORTED</b> = 0x800
	/// </summary>
	FlagGopStructureNotSupported = 2048,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderFrameTypeH264 : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_I_FRAME</b> = 0
	/// </summary>
	IFrame = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_P_FRAME</b> = 1
	/// </summary>
	PFrame = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_B_FRAME</b> = 2
	/// </summary>
	BFrame = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_IDR_FRAME</b> = 3
	/// </summary>
	IdrFrame = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderPictureControlCodecDataH264Flags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_REQUEST_INTRA_CONSTRAINED_SLICES</b> = 0x1
	/// </summary>
	FlagRequestIntraConstrainedSlices = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderFrameTypeHevc : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_I_FRAME</b> = 0
	/// </summary>
	IFrame = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_P_FRAME</b> = 1
	/// </summary>
	PFrame = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_B_FRAME</b> = 2
	/// </summary>
	BFrame = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_IDR_FRAME</b> = 3
	/// </summary>
	IdrFrame = 3,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderPictureControlCodecDataHevcFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAG_REQUEST_INTRA_CONSTRAINED_SLICES</b> = 0x1
	/// </summary>
	FlagRequestIntraConstrainedSlices = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
public enum VideoEncoderPictureControlFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_USED_AS_REFERENCE_PICTURE</b> = 0x1
	/// </summary>
	FlagUsedAsReferencePicture = 1,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderSequenceControlFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_NONE</b> = 0
	/// </summary>
	FlagNone = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RESOLUTION_CHANGE</b> = 0x1
	/// </summary>
	FlagResolutionChange = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RATE_CONTROL_CHANGE</b> = 0x2
	/// </summary>
	FlagRateControlChange = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_SUBREGION_LAYOUT_CHANGE</b> = 0x4
	/// </summary>
	FlagSubregionLayoutChange = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_REQUEST_INTRA_REFRESH</b> = 0x8
	/// </summary>
	FlagRequestIntraRefresh = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_GOP_SEQUENCE_CHANGE</b> = 0x10
	/// </summary>
	FlagGopSequenceChange = 16,
}

/// <summary>
/// ENUM <b>D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[Flags]
public enum VideoEncoderEncodeErrorFlags : uint {
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_NO_ERROR</b> = 0
	/// </summary>
	FlagNoError = 0,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_CODEC_PICTURE_CONTROL_NOT_SUPPORTED</b> = 0x1
	/// </summary>
	FlagCodecPictureControlNotSupported = 1,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_SUBREGION_LAYOUT_CONFIGURATION_NOT_SUPPORTED</b> = 0x2
	/// </summary>
	FlagSubregionLayoutConfigurationNotSupported = 2,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_REFERENCE_PICTURES</b> = 0x4
	/// </summary>
	FlagInvalidReferencePictures = 4,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_RECONFIGURATION_REQUEST_NOT_SUPPORTED</b> = 0x8
	/// </summary>
	FlagReconfigurationRequestNotSupported = 8,
	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_METADATA_BUFFER_SOURCE</b> = 0x10
	/// </summary>
	FlagInvalidMetadataBufferSource = 16,
}
