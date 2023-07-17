using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// STRUCTURE <b>D3D12_COMMAND_QUEUE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CommandQueueDesc {

	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE Type</b>
	/// </summary>
	public readonly CommandListType Type {
		get => _type;
		init => _type = value;
	}
	readonly CommandListType _type;

	/// <summary>
	/// <b>INT Priority</b>
	/// </summary>
	public readonly int Priority {
		get => _priority;
		init => _priority = value;
	}
	readonly int _priority;

	/// <summary>
	/// <b>D3D12_COMMAND_QUEUE_FLAGS Flags</b>
	/// </summary>
	public readonly CommandQueueFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly CommandQueueFlags _flags;

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

}

/// <summary>
/// STRUCTURE <b>D3D12_INPUT_ELEMENT_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InputElementDesc {

	/// <summary>
	/// <b>LPCSTR SemanticName</b>
	/// </summary>
	public readonly char* SemanticName {
		get => _semanticName;
		init => _semanticName = value;
	}
	readonly char* _semanticName;

	/// <summary>
	/// <b>UINT SemanticIndex</b>
	/// </summary>
	public readonly uint SemanticIndex {
		get => _semanticIndex;
		init => _semanticIndex = value;
	}
	readonly uint _semanticIndex;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>UINT InputSlot</b>
	/// </summary>
	public readonly uint InputSlot {
		get => _inputSlot;
		init => _inputSlot = value;
	}
	readonly uint _inputSlot;

	/// <summary>
	/// <b>UINT AlignedByteOffset</b>
	/// </summary>
	public readonly uint AlignedByteOffset {
		get => _alignedByteOffset;
		init => _alignedByteOffset = value;
	}
	readonly uint _alignedByteOffset;

	/// <summary>
	/// <b>D3D12_INPUT_CLASSIFICATION InputSlotClass</b>
	/// </summary>
	public readonly InputClassification InputSlotClass {
		get => _inputSlotClass;
		init => _inputSlotClass = value;
	}
	readonly InputClassification _inputSlotClass;

	/// <summary>
	/// <b>UINT InstanceDataStepRate</b>
	/// </summary>
	public readonly uint InstanceDataStepRate {
		get => _instanceDataStepRate;
		init => _instanceDataStepRate = value;
	}
	readonly uint _instanceDataStepRate;

}

/// <summary>
/// STRUCTURE <b>D3D12_SO_DECLARATION_ENTRY</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SoDeclarationEntry {

	/// <summary>
	/// <b>UINT Stream</b>
	/// </summary>
	public readonly uint Stream {
		get => _stream;
		init => _stream = value;
	}
	readonly uint _stream;

	/// <summary>
	/// <b>LPCSTR SemanticName</b>
	/// </summary>
	public readonly char* SemanticName {
		get => _semanticName;
		init => _semanticName = value;
	}
	readonly char* _semanticName;

	/// <summary>
	/// <b>UINT SemanticIndex</b>
	/// </summary>
	public readonly uint SemanticIndex {
		get => _semanticIndex;
		init => _semanticIndex = value;
	}
	readonly uint _semanticIndex;

	/// <summary>
	/// <b>BYTE StartComponent</b>
	/// </summary>
	public readonly byte StartComponent {
		get => _startComponent;
		init => _startComponent = value;
	}
	readonly byte _startComponent;

	/// <summary>
	/// <b>BYTE ComponentCount</b>
	/// </summary>
	public readonly byte ComponentCount {
		get => _componentCount;
		init => _componentCount = value;
	}
	readonly byte _componentCount;

	/// <summary>
	/// <b>BYTE OutputSlot</b>
	/// </summary>
	public readonly byte OutputSlot {
		get => _outputSlot;
		init => _outputSlot = value;
	}
	readonly byte _outputSlot;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIEWPORT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Viewport {

	/// <summary>
	/// <b>FLOAT TopLeftX</b>
	/// </summary>
	public readonly float TopLeftX {
		get => _topLeftX;
		init => _topLeftX = value;
	}
	readonly float _topLeftX;

	/// <summary>
	/// <b>FLOAT TopLeftY</b>
	/// </summary>
	public readonly float TopLeftY {
		get => _topLeftY;
		init => _topLeftY = value;
	}
	readonly float _topLeftY;

	/// <summary>
	/// <b>FLOAT Width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT Height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>FLOAT MinDepth</b>
	/// </summary>
	public readonly float MinDepth {
		get => _minDepth;
		init => _minDepth = value;
	}
	readonly float _minDepth;

	/// <summary>
	/// <b>FLOAT MaxDepth</b>
	/// </summary>
	public readonly float MaxDepth {
		get => _maxDepth;
		init => _maxDepth = value;
	}
	readonly float _maxDepth;

}

/// <summary>
/// STRUCTURE <b>D3D12_BOX</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Box {

	/// <summary>
	/// <b>UINT left</b>
	/// </summary>
	public readonly uint Left {
		get => _left;
		init => _left = value;
	}
	readonly uint _left;

	/// <summary>
	/// <b>UINT top</b>
	/// </summary>
	public readonly uint Top {
		get => _top;
		init => _top = value;
	}
	readonly uint _top;

	/// <summary>
	/// <b>UINT front</b>
	/// </summary>
	public readonly uint Front {
		get => _front;
		init => _front = value;
	}
	readonly uint _front;

	/// <summary>
	/// <b>UINT right</b>
	/// </summary>
	public readonly uint Right {
		get => _right;
		init => _right = value;
	}
	readonly uint _right;

	/// <summary>
	/// <b>UINT bottom</b>
	/// </summary>
	public readonly uint Bottom {
		get => _bottom;
		init => _bottom = value;
	}
	readonly uint _bottom;

	/// <summary>
	/// <b>UINT back</b>
	/// </summary>
	public readonly uint Back {
		get => _back;
		init => _back = value;
	}
	readonly uint _back;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEPTH_STENCILOP_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DepthStencilopDesc {

	/// <summary>
	/// <b>D3D12_STENCIL_OP StencilFailOp</b>
	/// </summary>
	public readonly StencilOp StencilFailOp {
		get => _stencilFailOp;
		init => _stencilFailOp = value;
	}
	readonly StencilOp _stencilFailOp;

	/// <summary>
	/// <b>D3D12_STENCIL_OP StencilDepthFailOp</b>
	/// </summary>
	public readonly StencilOp StencilDepthFailOp {
		get => _stencilDepthFailOp;
		init => _stencilDepthFailOp = value;
	}
	readonly StencilOp _stencilDepthFailOp;

	/// <summary>
	/// <b>D3D12_STENCIL_OP StencilPassOp</b>
	/// </summary>
	public readonly StencilOp StencilPassOp {
		get => _stencilPassOp;
		init => _stencilPassOp = value;
	}
	readonly StencilOp _stencilPassOp;

	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC StencilFunc</b>
	/// </summary>
	public readonly ComparisonFunc StencilFunc {
		get => _stencilFunc;
		init => _stencilFunc = value;
	}
	readonly ComparisonFunc _stencilFunc;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEPTH_STENCIL_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DepthStencilDesc {

	/// <summary>
	/// <b>BOOL DepthEnable</b>
	/// </summary>
	public readonly bool DepthEnable {
		get => _depthEnable != 0;
		init => _depthEnable = value ? 1U : 0U;
	}
	readonly uint _depthEnable;

	/// <summary>
	/// <b>D3D12_DEPTH_WRITE_MASK DepthWriteMask</b>
	/// </summary>
	public readonly DepthWriteMask DepthWriteMask {
		get => _depthWriteMask;
		init => _depthWriteMask = value;
	}
	readonly DepthWriteMask _depthWriteMask;

	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC DepthFunc</b>
	/// </summary>
	public readonly ComparisonFunc DepthFunc {
		get => _depthFunc;
		init => _depthFunc = value;
	}
	readonly ComparisonFunc _depthFunc;

	/// <summary>
	/// <b>BOOL StencilEnable</b>
	/// </summary>
	public readonly bool StencilEnable {
		get => _stencilEnable != 0;
		init => _stencilEnable = value ? 1U : 0U;
	}
	readonly uint _stencilEnable;

	/// <summary>
	/// <b>UINT8 StencilReadMask</b>
	/// </summary>
	public readonly byte StencilReadMask {
		get => _stencilReadMask;
		init => _stencilReadMask = value;
	}
	readonly byte _stencilReadMask;

	/// <summary>
	/// <b>UINT8 StencilWriteMask</b>
	/// </summary>
	public readonly byte StencilWriteMask {
		get => _stencilWriteMask;
		init => _stencilWriteMask = value;
	}
	readonly byte _stencilWriteMask;

	/// <summary>
	/// <b>D3D12_DEPTH_STENCILOP_DESC FrontFace</b>
	/// </summary>
	public readonly DepthStencilopDesc FrontFace {
		get => _frontFace;
		init => _frontFace = value;
	}
	readonly DepthStencilopDesc _frontFace;

	/// <summary>
	/// <b>D3D12_DEPTH_STENCILOP_DESC BackFace</b>
	/// </summary>
	public readonly DepthStencilopDesc BackFace {
		get => _backFace;
		init => _backFace = value;
	}
	readonly DepthStencilopDesc _backFace;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEPTH_STENCIL_DESC1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DepthStencilDesc1 {

	/// <summary>
	/// <b>BOOL DepthEnable</b>
	/// </summary>
	public readonly bool DepthEnable {
		get => _depthEnable != 0;
		init => _depthEnable = value ? 1U : 0U;
	}
	readonly uint _depthEnable;

	/// <summary>
	/// <b>D3D12_DEPTH_WRITE_MASK DepthWriteMask</b>
	/// </summary>
	public readonly DepthWriteMask DepthWriteMask {
		get => _depthWriteMask;
		init => _depthWriteMask = value;
	}
	readonly DepthWriteMask _depthWriteMask;

	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC DepthFunc</b>
	/// </summary>
	public readonly ComparisonFunc DepthFunc {
		get => _depthFunc;
		init => _depthFunc = value;
	}
	readonly ComparisonFunc _depthFunc;

	/// <summary>
	/// <b>BOOL StencilEnable</b>
	/// </summary>
	public readonly bool StencilEnable {
		get => _stencilEnable != 0;
		init => _stencilEnable = value ? 1U : 0U;
	}
	readonly uint _stencilEnable;

	/// <summary>
	/// <b>UINT8 StencilReadMask</b>
	/// </summary>
	public readonly byte StencilReadMask {
		get => _stencilReadMask;
		init => _stencilReadMask = value;
	}
	readonly byte _stencilReadMask;

	/// <summary>
	/// <b>UINT8 StencilWriteMask</b>
	/// </summary>
	public readonly byte StencilWriteMask {
		get => _stencilWriteMask;
		init => _stencilWriteMask = value;
	}
	readonly byte _stencilWriteMask;

	/// <summary>
	/// <b>D3D12_DEPTH_STENCILOP_DESC FrontFace</b>
	/// </summary>
	public readonly DepthStencilopDesc FrontFace {
		get => _frontFace;
		init => _frontFace = value;
	}
	readonly DepthStencilopDesc _frontFace;

	/// <summary>
	/// <b>D3D12_DEPTH_STENCILOP_DESC BackFace</b>
	/// </summary>
	public readonly DepthStencilopDesc BackFace {
		get => _backFace;
		init => _backFace = value;
	}
	readonly DepthStencilopDesc _backFace;

	/// <summary>
	/// <b>BOOL DepthBoundsTestEnable</b>
	/// </summary>
	public readonly bool DepthBoundsTestEnable {
		get => _depthBoundsTestEnable != 0;
		init => _depthBoundsTestEnable = value ? 1U : 0U;
	}
	readonly uint _depthBoundsTestEnable;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_TARGET_BLEND_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderTargetBlendDesc {

	/// <summary>
	/// <b>BOOL BlendEnable</b>
	/// </summary>
	public readonly bool BlendEnable {
		get => _blendEnable != 0;
		init => _blendEnable = value ? 1U : 0U;
	}
	readonly uint _blendEnable;

	/// <summary>
	/// <b>BOOL LogicOpEnable</b>
	/// </summary>
	public readonly bool LogicOpEnable {
		get => _logicOpEnable != 0;
		init => _logicOpEnable = value ? 1U : 0U;
	}
	readonly uint _logicOpEnable;

	/// <summary>
	/// <b>D3D12_BLEND SrcBlend</b>
	/// </summary>
	public readonly Blend SrcBlend {
		get => _srcBlend;
		init => _srcBlend = value;
	}
	readonly Blend _srcBlend;

	/// <summary>
	/// <b>D3D12_BLEND DestBlend</b>
	/// </summary>
	public readonly Blend DestBlend {
		get => _destBlend;
		init => _destBlend = value;
	}
	readonly Blend _destBlend;

	/// <summary>
	/// <b>D3D12_BLEND_OP BlendOp</b>
	/// </summary>
	public readonly BlendOp BlendOp {
		get => _blendOp;
		init => _blendOp = value;
	}
	readonly BlendOp _blendOp;

	/// <summary>
	/// <b>D3D12_BLEND SrcBlendAlpha</b>
	/// </summary>
	public readonly Blend SrcBlendAlpha {
		get => _srcBlendAlpha;
		init => _srcBlendAlpha = value;
	}
	readonly Blend _srcBlendAlpha;

	/// <summary>
	/// <b>D3D12_BLEND DestBlendAlpha</b>
	/// </summary>
	public readonly Blend DestBlendAlpha {
		get => _destBlendAlpha;
		init => _destBlendAlpha = value;
	}
	readonly Blend _destBlendAlpha;

	/// <summary>
	/// <b>D3D12_BLEND_OP BlendOpAlpha</b>
	/// </summary>
	public readonly BlendOp BlendOpAlpha {
		get => _blendOpAlpha;
		init => _blendOpAlpha = value;
	}
	readonly BlendOp _blendOpAlpha;

	/// <summary>
	/// <b>D3D12_LOGIC_OP LogicOp</b>
	/// </summary>
	public readonly LogicOp LogicOp {
		get => _logicOp;
		init => _logicOp = value;
	}
	readonly LogicOp _logicOp;

	/// <summary>
	/// <b>UINT8 RenderTargetWriteMask</b>
	/// </summary>
	public readonly byte RenderTargetWriteMask {
		get => _renderTargetWriteMask;
		init => _renderTargetWriteMask = value;
	}
	readonly byte _renderTargetWriteMask;

}

/// <summary>
/// STRUCTURE <b>D3D12_BLEND_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BlendDesc {

	/// <summary>
	/// <b>BOOL AlphaToCoverageEnable</b>
	/// </summary>
	public readonly bool AlphaToCoverageEnable {
		get => _alphaToCoverageEnable != 0;
		init => _alphaToCoverageEnable = value ? 1U : 0U;
	}
	readonly uint _alphaToCoverageEnable;

	/// <summary>
	/// <b>BOOL IndependentBlendEnable</b>
	/// </summary>
	public readonly bool IndependentBlendEnable {
		get => _independentBlendEnable != 0;
		init => _independentBlendEnable = value ? 1U : 0U;
	}
	readonly uint _independentBlendEnable;

	/// <summary>
	/// <b>D3D12_RENDER_TARGET_BLEND_DESC RenderTarget [8]</b>
	/// </summary>
	public readonly Span<RenderTargetBlendDesc> RenderTarget {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _renderTarget)), 8);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_120 {
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_0;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_1;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_2;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_3;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_4;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_5;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_6;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_7;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_120 _renderTarget;

}

/// <summary>
/// STRUCTURE <b>D3D12_RASTERIZER_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RasterizerDesc {

	/// <summary>
	/// <b>D3D12_FILL_MODE FillMode</b>
	/// </summary>
	public readonly FillMode FillMode {
		get => _fillMode;
		init => _fillMode = value;
	}
	readonly FillMode _fillMode;

	/// <summary>
	/// <b>D3D12_CULL_MODE CullMode</b>
	/// </summary>
	public readonly CullMode CullMode {
		get => _cullMode;
		init => _cullMode = value;
	}
	readonly CullMode _cullMode;

	/// <summary>
	/// <b>BOOL FrontCounterClockwise</b>
	/// </summary>
	public readonly bool FrontCounterClockwise {
		get => _frontCounterClockwise != 0;
		init => _frontCounterClockwise = value ? 1U : 0U;
	}
	readonly uint _frontCounterClockwise;

	/// <summary>
	/// <b>INT DepthBias</b>
	/// </summary>
	public readonly int DepthBias {
		get => _depthBias;
		init => _depthBias = value;
	}
	readonly int _depthBias;

	/// <summary>
	/// <b>FLOAT DepthBiasClamp</b>
	/// </summary>
	public readonly float DepthBiasClamp {
		get => _depthBiasClamp;
		init => _depthBiasClamp = value;
	}
	readonly float _depthBiasClamp;

	/// <summary>
	/// <b>FLOAT SlopeScaledDepthBias</b>
	/// </summary>
	public readonly float SlopeScaledDepthBias {
		get => _slopeScaledDepthBias;
		init => _slopeScaledDepthBias = value;
	}
	readonly float _slopeScaledDepthBias;

	/// <summary>
	/// <b>BOOL DepthClipEnable</b>
	/// </summary>
	public readonly bool DepthClipEnable {
		get => _depthClipEnable != 0;
		init => _depthClipEnable = value ? 1U : 0U;
	}
	readonly uint _depthClipEnable;

	/// <summary>
	/// <b>BOOL MultisampleEnable</b>
	/// </summary>
	public readonly bool MultisampleEnable {
		get => _multisampleEnable != 0;
		init => _multisampleEnable = value ? 1U : 0U;
	}
	readonly uint _multisampleEnable;

	/// <summary>
	/// <b>BOOL AntialiasedLineEnable</b>
	/// </summary>
	public readonly bool AntialiasedLineEnable {
		get => _antialiasedLineEnable != 0;
		init => _antialiasedLineEnable = value ? 1U : 0U;
	}
	readonly uint _antialiasedLineEnable;

	/// <summary>
	/// <b>UINT ForcedSampleCount</b>
	/// </summary>
	public readonly uint ForcedSampleCount {
		get => _forcedSampleCount;
		init => _forcedSampleCount = value;
	}
	readonly uint _forcedSampleCount;

	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster</b>
	/// </summary>
	public readonly ConservativeRasterizationMode ConservativeRaster {
		get => _conservativeRaster;
		init => _conservativeRaster = value;
	}
	readonly ConservativeRasterizationMode _conservativeRaster;

}

/// <summary>
/// STRUCTURE <b>D3D12_SHADER_BYTECODE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderBytecode {

	/// <summary>
	/// <b>void* pShaderBytecode</b>
	/// </summary>
	public readonly void* PShaderBytecode {
		get => _pShaderBytecode;
		init => _pShaderBytecode = value;
	}
	readonly void* _pShaderBytecode;

	/// <summary>
	/// <b>SIZE_T BytecodeLength</b>
	/// </summary>
	public readonly nuint BytecodeLength {
		get => _bytecodeLength;
		init => _bytecodeLength = value;
	}
	readonly nuint _bytecodeLength;

}

/// <summary>
/// STRUCTURE <b>D3D12_STREAM_OUTPUT_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StreamOutputDesc {

	/// <summary>
	/// <b>D3D12_SO_DECLARATION_ENTRY* pSODeclaration</b>
	/// </summary>
	public readonly SoDeclarationEntry* PSODeclaration {
		get => _pSODeclaration;
		init => _pSODeclaration = value;
	}
	readonly SoDeclarationEntry* _pSODeclaration;

	/// <summary>
	/// <b>UINT NumEntries</b>
	/// </summary>
	public readonly uint NumEntries {
		get => _numEntries;
		init => _numEntries = value;
	}
	readonly uint _numEntries;

	/// <summary>
	/// <b>UINT* pBufferStrides</b>
	/// </summary>
	public readonly uint* PBufferStrides {
		get => _pBufferStrides;
		init => _pBufferStrides = value;
	}
	readonly uint* _pBufferStrides;

	/// <summary>
	/// <b>UINT NumStrides</b>
	/// </summary>
	public readonly uint NumStrides {
		get => _numStrides;
		init => _numStrides = value;
	}
	readonly uint _numStrides;

	/// <summary>
	/// <b>UINT RasterizedStream</b>
	/// </summary>
	public readonly uint RasterizedStream {
		get => _rasterizedStream;
		init => _rasterizedStream = value;
	}
	readonly uint _rasterizedStream;

}

/// <summary>
/// STRUCTURE <b>D3D12_INPUT_LAYOUT_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InputLayoutDesc {

	/// <summary>
	/// <b>D3D12_INPUT_ELEMENT_DESC* pInputElementDescs</b>
	/// </summary>
	public readonly InputElementDesc* PInputElementDescs {
		get => _pInputElementDescs;
		init => _pInputElementDescs = value;
	}
	readonly InputElementDesc* _pInputElementDescs;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => _numElements;
		init => _numElements = value;
	}
	readonly uint _numElements;

}

/// <summary>
/// STRUCTURE <b>D3D12_CACHED_PIPELINE_STATE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CachedPipelineState {

	/// <summary>
	/// <b>void* pCachedBlob</b>
	/// </summary>
	public readonly void* PCachedBlob {
		get => _pCachedBlob;
		init => _pCachedBlob = value;
	}
	readonly void* _pCachedBlob;

	/// <summary>
	/// <b>SIZE_T CachedBlobSizeInBytes</b>
	/// </summary>
	public readonly nuint CachedBlobSizeInBytes {
		get => _cachedBlobSizeInBytes;
		init => _cachedBlobSizeInBytes = value;
	}
	readonly nuint _cachedBlobSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_GRAPHICS_PIPELINE_STATE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GraphicsPipelineStateDesc {

	/// <summary>
	/// <b>ID3D12RootSignature* pRootSignature</b>
	/// </summary>
	public readonly T* PRootSignature<T> () where T : unmanaged, IRootSignature => (T*) _pRootSignature;
	readonly void* _pRootSignature;

	/// <summary>
	/// <b>D3D12_SHADER_BYTECODE VS</b>
	/// </summary>
	public readonly ShaderBytecode Vs {
		get => _vS;
		init => _vS = value;
	}
	readonly ShaderBytecode _vS;

	/// <summary>
	/// <b>D3D12_SHADER_BYTECODE PS</b>
	/// </summary>
	public readonly ShaderBytecode Ps {
		get => _pS;
		init => _pS = value;
	}
	readonly ShaderBytecode _pS;

	/// <summary>
	/// <b>D3D12_SHADER_BYTECODE DS</b>
	/// </summary>
	public readonly ShaderBytecode Ds {
		get => _dS;
		init => _dS = value;
	}
	readonly ShaderBytecode _dS;

	/// <summary>
	/// <b>D3D12_SHADER_BYTECODE HS</b>
	/// </summary>
	public readonly ShaderBytecode Hs {
		get => _hS;
		init => _hS = value;
	}
	readonly ShaderBytecode _hS;

	/// <summary>
	/// <b>D3D12_SHADER_BYTECODE GS</b>
	/// </summary>
	public readonly ShaderBytecode Gs {
		get => _gS;
		init => _gS = value;
	}
	readonly ShaderBytecode _gS;

	/// <summary>
	/// <b>D3D12_STREAM_OUTPUT_DESC StreamOutput</b>
	/// </summary>
	public readonly StreamOutputDesc StreamOutput {
		get => _streamOutput;
		init => _streamOutput = value;
	}
	readonly StreamOutputDesc _streamOutput;

	/// <summary>
	/// <b>D3D12_BLEND_DESC BlendState</b>
	/// </summary>
	public readonly BlendDesc BlendState {
		get => _blendState;
		init => _blendState = value;
	}
	readonly BlendDesc _blendState;

	/// <summary>
	/// <b>UINT SampleMask</b>
	/// </summary>
	public readonly uint SampleMask {
		get => _sampleMask;
		init => _sampleMask = value;
	}
	readonly uint _sampleMask;

	/// <summary>
	/// <b>D3D12_RASTERIZER_DESC RasterizerState</b>
	/// </summary>
	public readonly RasterizerDesc RasterizerState {
		get => _rasterizerState;
		init => _rasterizerState = value;
	}
	readonly RasterizerDesc _rasterizerState;

	/// <summary>
	/// <b>D3D12_DEPTH_STENCIL_DESC DepthStencilState</b>
	/// </summary>
	public readonly DepthStencilDesc DepthStencilState {
		get => _depthStencilState;
		init => _depthStencilState = value;
	}
	readonly DepthStencilDesc _depthStencilState;

	/// <summary>
	/// <b>D3D12_INPUT_LAYOUT_DESC InputLayout</b>
	/// </summary>
	public readonly InputLayoutDesc InputLayout {
		get => _inputLayout;
		init => _inputLayout = value;
	}
	readonly InputLayoutDesc _inputLayout;

	/// <summary>
	/// <b>D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue</b>
	/// </summary>
	public readonly IndexBufferStripCutValue IBStripCutValue {
		get => _iBStripCutValue;
		init => _iBStripCutValue = value;
	}
	readonly IndexBufferStripCutValue _iBStripCutValue;

	/// <summary>
	/// <b>D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType</b>
	/// </summary>
	public readonly PrimitiveTopologyType PrimitiveTopologyType {
		get => _primitiveTopologyType;
		init => _primitiveTopologyType = value;
	}
	readonly PrimitiveTopologyType _primitiveTopologyType;

	/// <summary>
	/// <b>UINT NumRenderTargets</b>
	/// </summary>
	public readonly uint NumRenderTargets {
		get => _numRenderTargets;
		init => _numRenderTargets = value;
	}
	readonly uint _numRenderTargets;

	/// <summary>
	/// <b>DXGI_FORMAT RTVFormats [8]</b>
	/// </summary>
	public readonly Span<DXGI.Format> RTVFormats {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _rTVFormats)), 8);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_121 {
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_0;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_1;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_2;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_3;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_4;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_5;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_6;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_7;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_121 _rTVFormats;

	/// <summary>
	/// <b>DXGI_FORMAT DSVFormat</b>
	/// </summary>
	public readonly DXGI.Format DSVFormat {
		get => _dSVFormat;
		init => _dSVFormat = value;
	}
	readonly DXGI.Format _dSVFormat;

	/// <summary>
	/// <b>DXGI_SAMPLE_DESC SampleDesc</b>
	/// </summary>
	public readonly DXGI.SampleDesc SampleDesc {
		get => _sampleDesc;
		init => _sampleDesc = value;
	}
	readonly DXGI.SampleDesc _sampleDesc;

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_CACHED_PIPELINE_STATE CachedPSO</b>
	/// </summary>
	public readonly CachedPipelineState CachedPSO {
		get => _cachedPSO;
		init => _cachedPSO = value;
	}
	readonly CachedPipelineState _cachedPSO;

	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_FLAGS Flags</b>
	/// </summary>
	public readonly PipelineStateFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly PipelineStateFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_COMPUTE_PIPELINE_STATE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ComputePipelineStateDesc {

	/// <summary>
	/// <b>ID3D12RootSignature* pRootSignature</b>
	/// </summary>
	public readonly T* PRootSignature<T> () where T : unmanaged, IRootSignature => (T*) _pRootSignature;
	readonly void* _pRootSignature;

	/// <summary>
	/// <b>D3D12_SHADER_BYTECODE CS</b>
	/// </summary>
	public readonly ShaderBytecode Cs {
		get => _cS;
		init => _cS = value;
	}
	readonly ShaderBytecode _cS;

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_CACHED_PIPELINE_STATE CachedPSO</b>
	/// </summary>
	public readonly CachedPipelineState CachedPSO {
		get => _cachedPSO;
		init => _cachedPSO = value;
	}
	readonly CachedPipelineState _cachedPSO;

	/// <summary>
	/// <b>D3D12_PIPELINE_STATE_FLAGS Flags</b>
	/// </summary>
	public readonly PipelineStateFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly PipelineStateFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_RT_FORMAT_ARRAY</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RtFormatArray {

	/// <summary>
	/// <b>DXGI_FORMAT RTFormats [8]</b>
	/// </summary>
	public readonly Span<DXGI.Format> RTFormats {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _rTFormats)), 8);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_122 {
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_0;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_1;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_2;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_3;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_4;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_5;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_6;
		public DXGI.Format _ASP_AUTO_GENERATED_FIELD_7;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_122 _rTFormats;

	/// <summary>
	/// <b>UINT NumRenderTargets</b>
	/// </summary>
	public readonly uint NumRenderTargets {
		get => _numRenderTargets;
		init => _numRenderTargets = value;
	}
	readonly uint _numRenderTargets;

}

/// <summary>
/// STRUCTURE <b>D3D12_PIPELINE_STATE_STREAM_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PipelineStateStreamDesc {

	/// <summary>
	/// <b>SIZE_T SizeInBytes</b>
	/// </summary>
	public readonly nuint SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly nuint _sizeInBytes;

	/// <summary>
	/// <b>void* pPipelineStateSubobjectStream</b>
	/// </summary>
	public readonly void* PPipelineStateSubobjectStream {
		get => _pPipelineStateSubobjectStream;
		init => _pPipelineStateSubobjectStream = value;
	}
	readonly void* _pPipelineStateSubobjectStream;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options {

	/// <summary>
	/// <b>BOOL DoublePrecisionFloatShaderOps</b>
	/// </summary>
	public readonly bool DoublePrecisionFloatShaderOps {
		get => _doublePrecisionFloatShaderOps != 0;
		init => _doublePrecisionFloatShaderOps = value ? 1U : 0U;
	}
	readonly uint _doublePrecisionFloatShaderOps;

	/// <summary>
	/// <b>BOOL OutputMergerLogicOp</b>
	/// </summary>
	public readonly bool OutputMergerLogicOp {
		get => _outputMergerLogicOp != 0;
		init => _outputMergerLogicOp = value ? 1U : 0U;
	}
	readonly uint _outputMergerLogicOp;

	/// <summary>
	/// <b>D3D12_SHADER_MIN_PRECISION_SUPPORT MinPrecisionSupport</b>
	/// </summary>
	public readonly ShaderMinPrecisionSupport MinPrecisionSupport {
		get => _minPrecisionSupport;
		init => _minPrecisionSupport = value;
	}
	readonly ShaderMinPrecisionSupport _minPrecisionSupport;

	/// <summary>
	/// <b>D3D12_TILED_RESOURCES_TIER TiledResourcesTier</b>
	/// </summary>
	public readonly TiledResourcesTier TiledResourcesTier {
		get => _tiledResourcesTier;
		init => _tiledResourcesTier = value;
	}
	readonly TiledResourcesTier _tiledResourcesTier;

	/// <summary>
	/// <b>D3D12_RESOURCE_BINDING_TIER ResourceBindingTier</b>
	/// </summary>
	public readonly ResourceBindingTier ResourceBindingTier {
		get => _resourceBindingTier;
		init => _resourceBindingTier = value;
	}
	readonly ResourceBindingTier _resourceBindingTier;

	/// <summary>
	/// <b>BOOL PSSpecifiedStencilRefSupported</b>
	/// </summary>
	public readonly bool PSSpecifiedStencilRefSupported {
		get => _pSSpecifiedStencilRefSupported != 0;
		init => _pSSpecifiedStencilRefSupported = value ? 1U : 0U;
	}
	readonly uint _pSSpecifiedStencilRefSupported;

	/// <summary>
	/// <b>BOOL TypedUAVLoadAdditionalFormats</b>
	/// </summary>
	public readonly bool TypedUAVLoadAdditionalFormats {
		get => _typedUAVLoadAdditionalFormats != 0;
		init => _typedUAVLoadAdditionalFormats = value ? 1U : 0U;
	}
	readonly uint _typedUAVLoadAdditionalFormats;

	/// <summary>
	/// <b>BOOL ROVsSupported</b>
	/// </summary>
	public readonly bool ROVsSupported {
		get => _rOVsSupported != 0;
		init => _rOVsSupported = value ? 1U : 0U;
	}
	readonly uint _rOVsSupported;

	/// <summary>
	/// <b>D3D12_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier</b>
	/// </summary>
	public readonly ConservativeRasterizationTier ConservativeRasterizationTier {
		get => _conservativeRasterizationTier;
		init => _conservativeRasterizationTier = value;
	}
	readonly ConservativeRasterizationTier _conservativeRasterizationTier;

	/// <summary>
	/// <b>UINT MaxGPUVirtualAddressBitsPerResource</b>
	/// </summary>
	public readonly uint MaxGPUVirtualAddressBitsPerResource {
		get => _maxGPUVirtualAddressBitsPerResource;
		init => _maxGPUVirtualAddressBitsPerResource = value;
	}
	readonly uint _maxGPUVirtualAddressBitsPerResource;

	/// <summary>
	/// <b>BOOL StandardSwizzle64KBSupported</b>
	/// </summary>
	public readonly bool StandardSwizzle64KBSupported {
		get => _standardSwizzle64KBSupported != 0;
		init => _standardSwizzle64KBSupported = value ? 1U : 0U;
	}
	readonly uint _standardSwizzle64KBSupported;

	/// <summary>
	/// <b>D3D12_CROSS_NODE_SHARING_TIER CrossNodeSharingTier</b>
	/// </summary>
	public readonly CrossNodeSharingTier CrossNodeSharingTier {
		get => _crossNodeSharingTier;
		init => _crossNodeSharingTier = value;
	}
	readonly CrossNodeSharingTier _crossNodeSharingTier;

	/// <summary>
	/// <b>BOOL CrossAdapterRowMajorTextureSupported</b>
	/// </summary>
	public readonly bool CrossAdapterRowMajorTextureSupported {
		get => _crossAdapterRowMajorTextureSupported != 0;
		init => _crossAdapterRowMajorTextureSupported = value ? 1U : 0U;
	}
	readonly uint _crossAdapterRowMajorTextureSupported;

	/// <summary>
	/// <b>BOOL VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation</b>
	/// </summary>
	public readonly bool VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation {
		get => _vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation != 0;
		init => _vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation = value ? 1U : 0U;
	}
	readonly uint _vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

	/// <summary>
	/// <b>D3D12_RESOURCE_HEAP_TIER ResourceHeapTier</b>
	/// </summary>
	public readonly ResourceHeapTier ResourceHeapTier {
		get => _resourceHeapTier;
		init => _resourceHeapTier = value;
	}
	readonly ResourceHeapTier _resourceHeapTier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options1 {

	/// <summary>
	/// <b>BOOL WaveOps</b>
	/// </summary>
	public readonly bool WaveOps {
		get => _waveOps != 0;
		init => _waveOps = value ? 1U : 0U;
	}
	readonly uint _waveOps;

	/// <summary>
	/// <b>UINT WaveLaneCountMin</b>
	/// </summary>
	public readonly uint WaveLaneCountMin {
		get => _waveLaneCountMin;
		init => _waveLaneCountMin = value;
	}
	readonly uint _waveLaneCountMin;

	/// <summary>
	/// <b>UINT WaveLaneCountMax</b>
	/// </summary>
	public readonly uint WaveLaneCountMax {
		get => _waveLaneCountMax;
		init => _waveLaneCountMax = value;
	}
	readonly uint _waveLaneCountMax;

	/// <summary>
	/// <b>UINT TotalLaneCount</b>
	/// </summary>
	public readonly uint TotalLaneCount {
		get => _totalLaneCount;
		init => _totalLaneCount = value;
	}
	readonly uint _totalLaneCount;

	/// <summary>
	/// <b>BOOL ExpandedComputeResourceStates</b>
	/// </summary>
	public readonly bool ExpandedComputeResourceStates {
		get => _expandedComputeResourceStates != 0;
		init => _expandedComputeResourceStates = value ? 1U : 0U;
	}
	readonly uint _expandedComputeResourceStates;

	/// <summary>
	/// <b>BOOL Int64ShaderOps</b>
	/// </summary>
	public readonly bool Int64ShaderOps {
		get => _int64ShaderOps != 0;
		init => _int64ShaderOps = value ? 1U : 0U;
	}
	readonly uint _int64ShaderOps;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS2</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options2 {

	/// <summary>
	/// <b>BOOL DepthBoundsTestSupported</b>
	/// </summary>
	public readonly bool DepthBoundsTestSupported {
		get => _depthBoundsTestSupported != 0;
		init => _depthBoundsTestSupported = value ? 1U : 0U;
	}
	readonly uint _depthBoundsTestSupported;

	/// <summary>
	/// <b>D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER ProgrammableSamplePositionsTier</b>
	/// </summary>
	public readonly ProgrammableSamplePositionsTier ProgrammableSamplePositionsTier {
		get => _programmableSamplePositionsTier;
		init => _programmableSamplePositionsTier = value;
	}
	readonly ProgrammableSamplePositionsTier _programmableSamplePositionsTier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_ROOT_SIGNATURE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataRootSignature {

	/// <summary>
	/// <b>D3D_ROOT_SIGNATURE_VERSION HighestVersion</b>
	/// </summary>
	public readonly Direct3D.RootSignatureVersion HighestVersion {
		get => _highestVersion;
		init => _highestVersion = value;
	}
	readonly Direct3D.RootSignatureVersion _highestVersion;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_ARCHITECTURE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataArchitecture {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>BOOL TileBasedRenderer</b>
	/// </summary>
	public readonly bool TileBasedRenderer {
		get => _tileBasedRenderer != 0;
		init => _tileBasedRenderer = value ? 1U : 0U;
	}
	readonly uint _tileBasedRenderer;

	/// <summary>
	/// <b>BOOL UMA</b>
	/// </summary>
	public readonly bool Uma {
		get => _uMA != 0;
		init => _uMA = value ? 1U : 0U;
	}
	readonly uint _uMA;

	/// <summary>
	/// <b>BOOL CacheCoherentUMA</b>
	/// </summary>
	public readonly bool CacheCoherentUMA {
		get => _cacheCoherentUMA != 0;
		init => _cacheCoherentUMA = value ? 1U : 0U;
	}
	readonly uint _cacheCoherentUMA;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_ARCHITECTURE1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataArchitecture1 {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>BOOL TileBasedRenderer</b>
	/// </summary>
	public readonly bool TileBasedRenderer {
		get => _tileBasedRenderer != 0;
		init => _tileBasedRenderer = value ? 1U : 0U;
	}
	readonly uint _tileBasedRenderer;

	/// <summary>
	/// <b>BOOL UMA</b>
	/// </summary>
	public readonly bool Uma {
		get => _uMA != 0;
		init => _uMA = value ? 1U : 0U;
	}
	readonly uint _uMA;

	/// <summary>
	/// <b>BOOL CacheCoherentUMA</b>
	/// </summary>
	public readonly bool CacheCoherentUMA {
		get => _cacheCoherentUMA != 0;
		init => _cacheCoherentUMA = value ? 1U : 0U;
	}
	readonly uint _cacheCoherentUMA;

	/// <summary>
	/// <b>BOOL IsolatedMMU</b>
	/// </summary>
	public readonly bool IsolatedMMU {
		get => _isolatedMMU != 0;
		init => _isolatedMMU = value ? 1U : 0U;
	}
	readonly uint _isolatedMMU;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_FEATURE_LEVELS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataFeatureLevels {

	/// <summary>
	/// <b>UINT NumFeatureLevels</b>
	/// </summary>
	public readonly uint NumFeatureLevels {
		get => _numFeatureLevels;
		init => _numFeatureLevels = value;
	}
	readonly uint _numFeatureLevels;

	/// <summary>
	/// <b>D3D_FEATURE_LEVEL* pFeatureLevelsRequested</b>
	/// </summary>
	public readonly Direct3D.FeatureLevel* PFeatureLevelsRequested {
		get => _pFeatureLevelsRequested;
		init => _pFeatureLevelsRequested = value;
	}
	readonly Direct3D.FeatureLevel* _pFeatureLevelsRequested;

	/// <summary>
	/// <b>D3D_FEATURE_LEVEL MaxSupportedFeatureLevel</b>
	/// </summary>
	public readonly Direct3D.FeatureLevel MaxSupportedFeatureLevel {
		get => _maxSupportedFeatureLevel;
		init => _maxSupportedFeatureLevel = value;
	}
	readonly Direct3D.FeatureLevel _maxSupportedFeatureLevel;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_SHADER_MODEL</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataShaderModel {

	/// <summary>
	/// <b>D3D_SHADER_MODEL HighestShaderModel</b>
	/// </summary>
	public readonly Direct3D.ShaderModel HighestShaderModel {
		get => _highestShaderModel;
		init => _highestShaderModel = value;
	}
	readonly Direct3D.ShaderModel _highestShaderModel;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_FORMAT_SUPPORT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataFormatSupport {

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT1 Support1</b>
	/// </summary>
	public readonly FormatSupport1 Support1 {
		get => _support1;
		init => _support1 = value;
	}
	readonly FormatSupport1 _support1;

	/// <summary>
	/// <b>D3D12_FORMAT_SUPPORT2 Support2</b>
	/// </summary>
	public readonly FormatSupport2 Support2 {
		get => _support2;
		init => _support2 = value;
	}
	readonly FormatSupport2 _support2;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataMultisampleQualityLevels {

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>UINT SampleCount</b>
	/// </summary>
	public readonly uint SampleCount {
		get => _sampleCount;
		init => _sampleCount = value;
	}
	readonly uint _sampleCount;

	/// <summary>
	/// <b>D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags</b>
	/// </summary>
	public readonly MultisampleQualityLevelFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly MultisampleQualityLevelFlags _flags;

	/// <summary>
	/// <b>UINT NumQualityLevels</b>
	/// </summary>
	public readonly uint NumQualityLevels {
		get => _numQualityLevels;
		init => _numQualityLevels = value;
	}
	readonly uint _numQualityLevels;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_FORMAT_INFO</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataFormatInfo {

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>UINT8 PlaneCount</b>
	/// </summary>
	public readonly byte PlaneCount {
		get => _planeCount;
		init => _planeCount = value;
	}
	readonly byte _planeCount;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataGpuVirtualAddressSupport {

	/// <summary>
	/// <b>UINT MaxGPUVirtualAddressBitsPerResource</b>
	/// </summary>
	public readonly uint MaxGPUVirtualAddressBitsPerResource {
		get => _maxGPUVirtualAddressBitsPerResource;
		init => _maxGPUVirtualAddressBitsPerResource = value;
	}
	readonly uint _maxGPUVirtualAddressBitsPerResource;

	/// <summary>
	/// <b>UINT MaxGPUVirtualAddressBitsPerProcess</b>
	/// </summary>
	public readonly uint MaxGPUVirtualAddressBitsPerProcess {
		get => _maxGPUVirtualAddressBitsPerProcess;
		init => _maxGPUVirtualAddressBitsPerProcess = value;
	}
	readonly uint _maxGPUVirtualAddressBitsPerProcess;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_SHADER_CACHE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataShaderCache {

	/// <summary>
	/// <b>D3D12_SHADER_CACHE_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly ShaderCacheSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly ShaderCacheSupportFlags _supportFlags;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataCommandQueuePriority {

	/// <summary>
	/// <b>D3D12_COMMAND_LIST_TYPE CommandListType</b>
	/// </summary>
	public readonly CommandListType CommandListType {
		get => _commandListType;
		init => _commandListType = value;
	}
	readonly CommandListType _commandListType;

	/// <summary>
	/// <b>UINT Priority</b>
	/// </summary>
	public readonly uint Priority {
		get => _priority;
		init => _priority = value;
	}
	readonly uint _priority;

	/// <summary>
	/// <b>BOOL PriorityForTypeIsSupported</b>
	/// </summary>
	public readonly bool PriorityForTypeIsSupported {
		get => _priorityForTypeIsSupported != 0;
		init => _priorityForTypeIsSupported = value ? 1U : 0U;
	}
	readonly uint _priorityForTypeIsSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS3</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options3 {

	/// <summary>
	/// <b>BOOL CopyQueueTimestampQueriesSupported</b>
	/// </summary>
	public readonly bool CopyQueueTimestampQueriesSupported {
		get => _copyQueueTimestampQueriesSupported != 0;
		init => _copyQueueTimestampQueriesSupported = value ? 1U : 0U;
	}
	readonly uint _copyQueueTimestampQueriesSupported;

	/// <summary>
	/// <b>BOOL CastingFullyTypedFormatSupported</b>
	/// </summary>
	public readonly bool CastingFullyTypedFormatSupported {
		get => _castingFullyTypedFormatSupported != 0;
		init => _castingFullyTypedFormatSupported = value ? 1U : 0U;
	}
	readonly uint _castingFullyTypedFormatSupported;

	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags</b>
	/// </summary>
	public readonly CommandListSupportFlags WriteBufferImmediateSupportFlags {
		get => _writeBufferImmediateSupportFlags;
		init => _writeBufferImmediateSupportFlags = value;
	}
	readonly CommandListSupportFlags _writeBufferImmediateSupportFlags;

	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_TIER ViewInstancingTier</b>
	/// </summary>
	public readonly ViewInstancingTier ViewInstancingTier {
		get => _viewInstancingTier;
		init => _viewInstancingTier = value;
	}
	readonly ViewInstancingTier _viewInstancingTier;

	/// <summary>
	/// <b>BOOL BarycentricsSupported</b>
	/// </summary>
	public readonly bool BarycentricsSupported {
		get => _barycentricsSupported != 0;
		init => _barycentricsSupported = value ? 1U : 0U;
	}
	readonly uint _barycentricsSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_EXISTING_HEAPS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataExistingHeaps {

	/// <summary>
	/// <b>BOOL Supported</b>
	/// </summary>
	public readonly bool Supported {
		get => _supported != 0;
		init => _supported = value ? 1U : 0U;
	}
	readonly uint _supported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_DISPLAYABLE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataDisplayable {

	/// <summary>
	/// <b>BOOL DisplayableTexture</b>
	/// </summary>
	public readonly bool DisplayableTexture {
		get => _displayableTexture != 0;
		init => _displayableTexture = value ? 1U : 0U;
	}
	readonly uint _displayableTexture;

	/// <summary>
	/// <b>D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier</b>
	/// </summary>
	public readonly SharedResourceCompatibilityTier SharedResourceCompatibilityTier {
		get => _sharedResourceCompatibilityTier;
		init => _sharedResourceCompatibilityTier = value;
	}
	readonly SharedResourceCompatibilityTier _sharedResourceCompatibilityTier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS4</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options4 {

	/// <summary>
	/// <b>BOOL MSAA64KBAlignedTextureSupported</b>
	/// </summary>
	public readonly bool MSAA64KBAlignedTextureSupported {
		get => _mSAA64KBAlignedTextureSupported != 0;
		init => _mSAA64KBAlignedTextureSupported = value ? 1U : 0U;
	}
	readonly uint _mSAA64KBAlignedTextureSupported;

	/// <summary>
	/// <b>D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier</b>
	/// </summary>
	public readonly SharedResourceCompatibilityTier SharedResourceCompatibilityTier {
		get => _sharedResourceCompatibilityTier;
		init => _sharedResourceCompatibilityTier = value;
	}
	readonly SharedResourceCompatibilityTier _sharedResourceCompatibilityTier;

	/// <summary>
	/// <b>BOOL Native16BitShaderOpsSupported</b>
	/// </summary>
	public readonly bool Native16BitShaderOpsSupported {
		get => _native16BitShaderOpsSupported != 0;
		init => _native16BitShaderOpsSupported = value ? 1U : 0U;
	}
	readonly uint _native16BitShaderOpsSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_SERIALIZATION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataSerialization {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_HEAP_SERIALIZATION_TIER HeapSerializationTier</b>
	/// </summary>
	public readonly HeapSerializationTier HeapSerializationTier {
		get => _heapSerializationTier;
		init => _heapSerializationTier = value;
	}
	readonly HeapSerializationTier _heapSerializationTier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_CROSS_NODE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataCrossNode {

	/// <summary>
	/// <b>D3D12_CROSS_NODE_SHARING_TIER SharingTier</b>
	/// </summary>
	public readonly CrossNodeSharingTier SharingTier {
		get => _sharingTier;
		init => _sharingTier = value;
	}
	readonly CrossNodeSharingTier _sharingTier;

	/// <summary>
	/// <b>BOOL AtomicShaderInstructions</b>
	/// </summary>
	public readonly bool AtomicShaderInstructions {
		get => _atomicShaderInstructions != 0;
		init => _atomicShaderInstructions = value ? 1U : 0U;
	}
	readonly uint _atomicShaderInstructions;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS5</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options5 {

	/// <summary>
	/// <b>BOOL SRVOnlyTiledResourceTier3</b>
	/// </summary>
	public readonly bool SRVOnlyTiledResourceTier3 {
		get => _sRVOnlyTiledResourceTier3 != 0;
		init => _sRVOnlyTiledResourceTier3 = value ? 1U : 0U;
	}
	readonly uint _sRVOnlyTiledResourceTier3;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_TIER RenderPassesTier</b>
	/// </summary>
	public readonly RenderPassTier RenderPassesTier {
		get => _renderPassesTier;
		init => _renderPassesTier = value;
	}
	readonly RenderPassTier _renderPassesTier;

	/// <summary>
	/// <b>D3D12_RAYTRACING_TIER RaytracingTier</b>
	/// </summary>
	public readonly RaytracingTier RaytracingTier {
		get => _raytracingTier;
		init => _raytracingTier = value;
	}
	readonly RaytracingTier _raytracingTier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS6</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options6 {

	/// <summary>
	/// <b>BOOL AdditionalShadingRatesSupported</b>
	/// </summary>
	public readonly bool AdditionalShadingRatesSupported {
		get => _additionalShadingRatesSupported != 0;
		init => _additionalShadingRatesSupported = value ? 1U : 0U;
	}
	readonly uint _additionalShadingRatesSupported;

	/// <summary>
	/// <b>BOOL PerPrimitiveShadingRateSupportedWithViewportIndexing</b>
	/// </summary>
	public readonly bool PerPrimitiveShadingRateSupportedWithViewportIndexing {
		get => _perPrimitiveShadingRateSupportedWithViewportIndexing != 0;
		init => _perPrimitiveShadingRateSupportedWithViewportIndexing = value ? 1U : 0U;
	}
	readonly uint _perPrimitiveShadingRateSupportedWithViewportIndexing;

	/// <summary>
	/// <b>D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier</b>
	/// </summary>
	public readonly VariableShadingRateTier VariableShadingRateTier {
		get => _variableShadingRateTier;
		init => _variableShadingRateTier = value;
	}
	readonly VariableShadingRateTier _variableShadingRateTier;

	/// <summary>
	/// <b>UINT ShadingRateImageTileSize</b>
	/// </summary>
	public readonly uint ShadingRateImageTileSize {
		get => _shadingRateImageTileSize;
		init => _shadingRateImageTileSize = value;
	}
	readonly uint _shadingRateImageTileSize;

	/// <summary>
	/// <b>BOOL BackgroundProcessingSupported</b>
	/// </summary>
	public readonly bool BackgroundProcessingSupported {
		get => _backgroundProcessingSupported != 0;
		init => _backgroundProcessingSupported = value ? 1U : 0U;
	}
	readonly uint _backgroundProcessingSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS7</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options7 {

	/// <summary>
	/// <b>D3D12_MESH_SHADER_TIER MeshShaderTier</b>
	/// </summary>
	public readonly MeshShaderTier MeshShaderTier {
		get => _meshShaderTier;
		init => _meshShaderTier = value;
	}
	readonly MeshShaderTier _meshShaderTier;

	/// <summary>
	/// <b>D3D12_SAMPLER_FEEDBACK_TIER SamplerFeedbackTier</b>
	/// </summary>
	public readonly SamplerFeedbackTier SamplerFeedbackTier {
		get => _samplerFeedbackTier;
		init => _samplerFeedbackTier = value;
	}
	readonly SamplerFeedbackTier _samplerFeedbackTier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_QUERY_META_COMMAND</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataQueryMetaCommand {

	/// <summary>
	/// <b>GUID CommandId</b>
	/// </summary>
	public readonly Guid CommandId {
		get => _commandId;
		init => _commandId = value;
	}
	readonly Guid _commandId;

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>void* pQueryInputData</b>
	/// </summary>
	public readonly void* PQueryInputData {
		get => _pQueryInputData;
		init => _pQueryInputData = value;
	}
	readonly void* _pQueryInputData;

	/// <summary>
	/// <b>SIZE_T QueryInputDataSizeInBytes</b>
	/// </summary>
	public readonly nuint QueryInputDataSizeInBytes {
		get => _queryInputDataSizeInBytes;
		init => _queryInputDataSizeInBytes = value;
	}
	readonly nuint _queryInputDataSizeInBytes;

	/// <summary>
	/// <b>void* pQueryOutputData</b>
	/// </summary>
	public readonly void* PQueryOutputData {
		get => _pQueryOutputData;
		init => _pQueryOutputData = value;
	}
	readonly void* _pQueryOutputData;

	/// <summary>
	/// <b>SIZE_T QueryOutputDataSizeInBytes</b>
	/// </summary>
	public readonly nuint QueryOutputDataSizeInBytes {
		get => _queryOutputDataSizeInBytes;
		init => _queryOutputDataSizeInBytes = value;
	}
	readonly nuint _queryOutputDataSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS8</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options8 {

	/// <summary>
	/// <b>BOOL UnalignedBlockTexturesSupported</b>
	/// </summary>
	public readonly bool UnalignedBlockTexturesSupported {
		get => _unalignedBlockTexturesSupported != 0;
		init => _unalignedBlockTexturesSupported = value ? 1U : 0U;
	}
	readonly uint _unalignedBlockTexturesSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS9</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options9 {

	/// <summary>
	/// <b>BOOL MeshShaderPipelineStatsSupported</b>
	/// </summary>
	public readonly bool MeshShaderPipelineStatsSupported {
		get => _meshShaderPipelineStatsSupported != 0;
		init => _meshShaderPipelineStatsSupported = value ? 1U : 0U;
	}
	readonly uint _meshShaderPipelineStatsSupported;

	/// <summary>
	/// <b>BOOL MeshShaderSupportsFullRangeRenderTargetArrayIndex</b>
	/// </summary>
	public readonly bool MeshShaderSupportsFullRangeRenderTargetArrayIndex {
		get => _meshShaderSupportsFullRangeRenderTargetArrayIndex != 0;
		init => _meshShaderSupportsFullRangeRenderTargetArrayIndex = value ? 1U : 0U;
	}
	readonly uint _meshShaderSupportsFullRangeRenderTargetArrayIndex;

	/// <summary>
	/// <b>BOOL AtomicInt64OnTypedResourceSupported</b>
	/// </summary>
	public readonly bool AtomicInt64OnTypedResourceSupported {
		get => _atomicInt64OnTypedResourceSupported != 0;
		init => _atomicInt64OnTypedResourceSupported = value ? 1U : 0U;
	}
	readonly uint _atomicInt64OnTypedResourceSupported;

	/// <summary>
	/// <b>BOOL AtomicInt64OnGroupSharedSupported</b>
	/// </summary>
	public readonly bool AtomicInt64OnGroupSharedSupported {
		get => _atomicInt64OnGroupSharedSupported != 0;
		init => _atomicInt64OnGroupSharedSupported = value ? 1U : 0U;
	}
	readonly uint _atomicInt64OnGroupSharedSupported;

	/// <summary>
	/// <b>BOOL DerivativesInMeshAndAmplificationShadersSupported</b>
	/// </summary>
	public readonly bool DerivativesInMeshAndAmplificationShadersSupported {
		get => _derivativesInMeshAndAmplificationShadersSupported != 0;
		init => _derivativesInMeshAndAmplificationShadersSupported = value ? 1U : 0U;
	}
	readonly uint _derivativesInMeshAndAmplificationShadersSupported;

	/// <summary>
	/// <b>D3D12_WAVE_MMA_TIER WaveMMATier</b>
	/// </summary>
	public readonly WaveMmaTier WaveMMATier {
		get => _waveMMATier;
		init => _waveMMATier = value;
	}
	readonly WaveMmaTier _waveMMATier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS10</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options10 {

	/// <summary>
	/// <b>BOOL VariableRateShadingSumCombinerSupported</b>
	/// </summary>
	public readonly bool VariableRateShadingSumCombinerSupported {
		get => _variableRateShadingSumCombinerSupported != 0;
		init => _variableRateShadingSumCombinerSupported = value ? 1U : 0U;
	}
	readonly uint _variableRateShadingSumCombinerSupported;

	/// <summary>
	/// <b>BOOL MeshShaderPerPrimitiveShadingRateSupported</b>
	/// </summary>
	public readonly bool MeshShaderPerPrimitiveShadingRateSupported {
		get => _meshShaderPerPrimitiveShadingRateSupported != 0;
		init => _meshShaderPerPrimitiveShadingRateSupported = value ? 1U : 0U;
	}
	readonly uint _meshShaderPerPrimitiveShadingRateSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS11</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options11 {

	/// <summary>
	/// <b>BOOL AtomicInt64OnDescriptorHeapResourceSupported</b>
	/// </summary>
	public readonly bool AtomicInt64OnDescriptorHeapResourceSupported {
		get => _atomicInt64OnDescriptorHeapResourceSupported != 0;
		init => _atomicInt64OnDescriptorHeapResourceSupported = value ? 1U : 0U;
	}
	readonly uint _atomicInt64OnDescriptorHeapResourceSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS12</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options12 {

	/// <summary>
	/// <b>D3D12_TRI_STATE MSPrimitivesPipelineStatisticIncludesCulledPrimitives</b>
	/// </summary>
	public readonly TriState MSPrimitivesPipelineStatisticIncludesCulledPrimitives {
		get => _mSPrimitivesPipelineStatisticIncludesCulledPrimitives;
		init => _mSPrimitivesPipelineStatisticIncludesCulledPrimitives = value;
	}
	readonly TriState _mSPrimitivesPipelineStatisticIncludesCulledPrimitives;

	/// <summary>
	/// <b>BOOL EnhancedBarriersSupported</b>
	/// </summary>
	public readonly bool EnhancedBarriersSupported {
		get => _enhancedBarriersSupported != 0;
		init => _enhancedBarriersSupported = value ? 1U : 0U;
	}
	readonly uint _enhancedBarriersSupported;

	/// <summary>
	/// <b>BOOL RelaxedFormatCastingSupported</b>
	/// </summary>
	public readonly bool RelaxedFormatCastingSupported {
		get => _relaxedFormatCastingSupported != 0;
		init => _relaxedFormatCastingSupported = value ? 1U : 0U;
	}
	readonly uint _relaxedFormatCastingSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_D3D12_OPTIONS13</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d12Options13 {

	/// <summary>
	/// <b>BOOL UnrestrictedBufferTextureCopyPitchSupported</b>
	/// </summary>
	public readonly bool UnrestrictedBufferTextureCopyPitchSupported {
		get => _unrestrictedBufferTextureCopyPitchSupported != 0;
		init => _unrestrictedBufferTextureCopyPitchSupported = value ? 1U : 0U;
	}
	readonly uint _unrestrictedBufferTextureCopyPitchSupported;

	/// <summary>
	/// <b>BOOL UnrestrictedVertexElementAlignmentSupported</b>
	/// </summary>
	public readonly bool UnrestrictedVertexElementAlignmentSupported {
		get => _unrestrictedVertexElementAlignmentSupported != 0;
		init => _unrestrictedVertexElementAlignmentSupported = value ? 1U : 0U;
	}
	readonly uint _unrestrictedVertexElementAlignmentSupported;

	/// <summary>
	/// <b>BOOL InvertedViewportHeightFlipsYSupported</b>
	/// </summary>
	public readonly bool InvertedViewportHeightFlipsYSupported {
		get => _invertedViewportHeightFlipsYSupported != 0;
		init => _invertedViewportHeightFlipsYSupported = value ? 1U : 0U;
	}
	readonly uint _invertedViewportHeightFlipsYSupported;

	/// <summary>
	/// <b>BOOL InvertedViewportDepthFlipsZSupported</b>
	/// </summary>
	public readonly bool InvertedViewportDepthFlipsZSupported {
		get => _invertedViewportDepthFlipsZSupported != 0;
		init => _invertedViewportDepthFlipsZSupported = value ? 1U : 0U;
	}
	readonly uint _invertedViewportDepthFlipsZSupported;

	/// <summary>
	/// <b>BOOL TextureCopyBetweenDimensionsSupported</b>
	/// </summary>
	public readonly bool TextureCopyBetweenDimensionsSupported {
		get => _textureCopyBetweenDimensionsSupported != 0;
		init => _textureCopyBetweenDimensionsSupported = value ? 1U : 0U;
	}
	readonly uint _textureCopyBetweenDimensionsSupported;

	/// <summary>
	/// <b>BOOL AlphaBlendFactorSupported</b>
	/// </summary>
	public readonly bool AlphaBlendFactorSupported {
		get => _alphaBlendFactorSupported != 0;
		init => _alphaBlendFactorSupported = value ? 1U : 0U;
	}
	readonly uint _alphaBlendFactorSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_ALLOCATION_INFO</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceAllocationInfo {

	/// <summary>
	/// <b>UINT64 SizeInBytes</b>
	/// </summary>
	public readonly ulong SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly ulong _sizeInBytes;

	/// <summary>
	/// <b>UINT64 Alignment</b>
	/// </summary>
	public readonly ulong Alignment {
		get => _alignment;
		init => _alignment = value;
	}
	readonly ulong _alignment;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_ALLOCATION_INFO1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceAllocationInfo1 {

	/// <summary>
	/// <b>UINT64 Offset</b>
	/// </summary>
	public readonly ulong Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly ulong _offset;

	/// <summary>
	/// <b>UINT64 Alignment</b>
	/// </summary>
	public readonly ulong Alignment {
		get => _alignment;
		init => _alignment = value;
	}
	readonly ulong _alignment;

	/// <summary>
	/// <b>UINT64 SizeInBytes</b>
	/// </summary>
	public readonly ulong SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly ulong _sizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_HEAP_PROPERTIES</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct HeapProperties {

	/// <summary>
	/// <b>D3D12_HEAP_TYPE Type</b>
	/// </summary>
	public readonly HeapType Type {
		get => _type;
		init => _type = value;
	}
	readonly HeapType _type;

	/// <summary>
	/// <b>D3D12_CPU_PAGE_PROPERTY CPUPageProperty</b>
	/// </summary>
	public readonly CpuPageProperty CPUPageProperty {
		get => _cPUPageProperty;
		init => _cPUPageProperty = value;
	}
	readonly CpuPageProperty _cPUPageProperty;

	/// <summary>
	/// <b>D3D12_MEMORY_POOL MemoryPoolPreference</b>
	/// </summary>
	public readonly MemoryPool MemoryPoolPreference {
		get => _memoryPoolPreference;
		init => _memoryPoolPreference = value;
	}
	readonly MemoryPool _memoryPoolPreference;

	/// <summary>
	/// <b>UINT CreationNodeMask</b>
	/// </summary>
	public readonly uint CreationNodeMask {
		get => _creationNodeMask;
		init => _creationNodeMask = value;
	}
	readonly uint _creationNodeMask;

	/// <summary>
	/// <b>UINT VisibleNodeMask</b>
	/// </summary>
	public readonly uint VisibleNodeMask {
		get => _visibleNodeMask;
		init => _visibleNodeMask = value;
	}
	readonly uint _visibleNodeMask;

}

/// <summary>
/// STRUCTURE <b>D3D12_HEAP_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct HeapDesc {

	/// <summary>
	/// <b>UINT64 SizeInBytes</b>
	/// </summary>
	public readonly ulong SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly ulong _sizeInBytes;

	/// <summary>
	/// <b>D3D12_HEAP_PROPERTIES Properties</b>
	/// </summary>
	public readonly HeapProperties Properties {
		get => _properties;
		init => _properties = value;
	}
	readonly HeapProperties _properties;

	/// <summary>
	/// <b>UINT64 Alignment</b>
	/// </summary>
	public readonly ulong Alignment {
		get => _alignment;
		init => _alignment = value;
	}
	readonly ulong _alignment;

	/// <summary>
	/// <b>D3D12_HEAP_FLAGS Flags</b>
	/// </summary>
	public readonly HeapFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly HeapFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_MIP_REGION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MipRegion {

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>UINT Depth</b>
	/// </summary>
	public readonly uint Depth {
		get => _depth;
		init => _depth = value;
	}
	readonly uint _depth;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceDesc {

	/// <summary>
	/// <b>D3D12_RESOURCE_DIMENSION Dimension</b>
	/// </summary>
	public readonly ResourceDimension Dimension {
		get => _dimension;
		init => _dimension = value;
	}
	readonly ResourceDimension _dimension;

	/// <summary>
	/// <b>UINT64 Alignment</b>
	/// </summary>
	public readonly ulong Alignment {
		get => _alignment;
		init => _alignment = value;
	}
	readonly ulong _alignment;

	/// <summary>
	/// <b>UINT64 Width</b>
	/// </summary>
	public readonly ulong Width {
		get => _width;
		init => _width = value;
	}
	readonly ulong _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>UINT16 DepthOrArraySize</b>
	/// </summary>
	public readonly ushort DepthOrArraySize {
		get => _depthOrArraySize;
		init => _depthOrArraySize = value;
	}
	readonly ushort _depthOrArraySize;

	/// <summary>
	/// <b>UINT16 MipLevels</b>
	/// </summary>
	public readonly ushort MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly ushort _mipLevels;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>DXGI_SAMPLE_DESC SampleDesc</b>
	/// </summary>
	public readonly DXGI.SampleDesc SampleDesc {
		get => _sampleDesc;
		init => _sampleDesc = value;
	}
	readonly DXGI.SampleDesc _sampleDesc;

	/// <summary>
	/// <b>D3D12_TEXTURE_LAYOUT Layout</b>
	/// </summary>
	public readonly TextureLayout Layout {
		get => _layout;
		init => _layout = value;
	}
	readonly TextureLayout _layout;

	/// <summary>
	/// <b>D3D12_RESOURCE_FLAGS Flags</b>
	/// </summary>
	public readonly ResourceFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ResourceFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_DESC1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceDesc1 {

	/// <summary>
	/// <b>D3D12_RESOURCE_DIMENSION Dimension</b>
	/// </summary>
	public readonly ResourceDimension Dimension {
		get => _dimension;
		init => _dimension = value;
	}
	readonly ResourceDimension _dimension;

	/// <summary>
	/// <b>UINT64 Alignment</b>
	/// </summary>
	public readonly ulong Alignment {
		get => _alignment;
		init => _alignment = value;
	}
	readonly ulong _alignment;

	/// <summary>
	/// <b>UINT64 Width</b>
	/// </summary>
	public readonly ulong Width {
		get => _width;
		init => _width = value;
	}
	readonly ulong _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>UINT16 DepthOrArraySize</b>
	/// </summary>
	public readonly ushort DepthOrArraySize {
		get => _depthOrArraySize;
		init => _depthOrArraySize = value;
	}
	readonly ushort _depthOrArraySize;

	/// <summary>
	/// <b>UINT16 MipLevels</b>
	/// </summary>
	public readonly ushort MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly ushort _mipLevels;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>DXGI_SAMPLE_DESC SampleDesc</b>
	/// </summary>
	public readonly DXGI.SampleDesc SampleDesc {
		get => _sampleDesc;
		init => _sampleDesc = value;
	}
	readonly DXGI.SampleDesc _sampleDesc;

	/// <summary>
	/// <b>D3D12_TEXTURE_LAYOUT Layout</b>
	/// </summary>
	public readonly TextureLayout Layout {
		get => _layout;
		init => _layout = value;
	}
	readonly TextureLayout _layout;

	/// <summary>
	/// <b>D3D12_RESOURCE_FLAGS Flags</b>
	/// </summary>
	public readonly ResourceFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ResourceFlags _flags;

	/// <summary>
	/// <b>D3D12_MIP_REGION SamplerFeedbackMipRegion</b>
	/// </summary>
	public readonly MipRegion SamplerFeedbackMipRegion {
		get => _samplerFeedbackMipRegion;
		init => _samplerFeedbackMipRegion = value;
	}
	readonly MipRegion _samplerFeedbackMipRegion;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEPTH_STENCIL_VALUE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DepthStencilValue {

	/// <summary>
	/// <b>FLOAT Depth</b>
	/// </summary>
	public readonly float Depth {
		get => _depth;
		init => _depth = value;
	}
	readonly float _depth;

	/// <summary>
	/// <b>UINT8 Stencil</b>
	/// </summary>
	public readonly byte Stencil {
		get => _stencil;
		init => _stencil = value;
	}
	readonly byte _stencil;

}

/// <summary>
/// STRUCTURE <b>D3D12_CLEAR_VALUE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ClearValue {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_30 {

		public readonly Span<float> Color {
			get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _color)), 4);
		}

		unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_123 {
			public fixed float _ASP_AUTO_GENERATED_FIELD_0 [4];
		}

		[FieldOffset (0)] readonly _ASP_AUTO_GENERATED_STRUCTURE_123 _color;

		[FieldOffset (0)] public DepthStencilValue depthStencil;
	}

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>FLOAT Color [4]</b>
	/// </summary>
	public readonly Span<float> Color {
		get => __aSP_AUTO_GENERATED_FIELD_30.Color;
	}

	/// <summary>
	/// <b>D3D12_DEPTH_STENCIL_VALUE DepthStencil</b>
	/// </summary>
	public readonly DepthStencilValue DepthStencil {
		get => __aSP_AUTO_GENERATED_FIELD_30.depthStencil;
		init => __aSP_AUTO_GENERATED_FIELD_30.depthStencil = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_30 __aSP_AUTO_GENERATED_FIELD_30;

}

/// <summary>
/// STRUCTURE <b>D3D12_RANGE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Range {

	/// <summary>
	/// <b>SIZE_T Begin</b>
	/// </summary>
	public readonly nuint Begin {
		get => _begin;
		init => _begin = value;
	}
	readonly nuint _begin;

	/// <summary>
	/// <b>SIZE_T End</b>
	/// </summary>
	public readonly nuint End {
		get => _end;
		init => _end = value;
	}
	readonly nuint _end;

}

/// <summary>
/// STRUCTURE <b>D3D12_RANGE_UINT64</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RangeUint64 {

	/// <summary>
	/// <b>UINT64 Begin</b>
	/// </summary>
	public readonly ulong Begin {
		get => _begin;
		init => _begin = value;
	}
	readonly ulong _begin;

	/// <summary>
	/// <b>UINT64 End</b>
	/// </summary>
	public readonly ulong End {
		get => _end;
		init => _end = value;
	}
	readonly ulong _end;

}

/// <summary>
/// STRUCTURE <b>D3D12_SUBRESOURCE_RANGE_UINT64</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SubresourceRangeUint64 {

	/// <summary>
	/// <b>UINT Subresource</b>
	/// </summary>
	public readonly uint Subresource {
		get => _subresource;
		init => _subresource = value;
	}
	readonly uint _subresource;

	/// <summary>
	/// <b>D3D12_RANGE_UINT64 Range</b>
	/// </summary>
	public readonly RangeUint64 Range {
		get => _range;
		init => _range = value;
	}
	readonly RangeUint64 _range;

}

/// <summary>
/// STRUCTURE <b>D3D12_SUBRESOURCE_INFO</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SubresourceInfo {

	/// <summary>
	/// <b>UINT64 Offset</b>
	/// </summary>
	public readonly ulong Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly ulong _offset;

	/// <summary>
	/// <b>UINT RowPitch</b>
	/// </summary>
	public readonly uint RowPitch {
		get => _rowPitch;
		init => _rowPitch = value;
	}
	readonly uint _rowPitch;

	/// <summary>
	/// <b>UINT DepthPitch</b>
	/// </summary>
	public readonly uint DepthPitch {
		get => _depthPitch;
		init => _depthPitch = value;
	}
	readonly uint _depthPitch;

}

/// <summary>
/// STRUCTURE <b>D3D12_TILED_RESOURCE_COORDINATE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TiledResourceCoordinate {

	/// <summary>
	/// <b>UINT X</b>
	/// </summary>
	public readonly uint X {
		get => _x;
		init => _x = value;
	}
	readonly uint _x;

	/// <summary>
	/// <b>UINT Y</b>
	/// </summary>
	public readonly uint Y {
		get => _y;
		init => _y = value;
	}
	readonly uint _y;

	/// <summary>
	/// <b>UINT Z</b>
	/// </summary>
	public readonly uint Z {
		get => _z;
		init => _z = value;
	}
	readonly uint _z;

	/// <summary>
	/// <b>UINT Subresource</b>
	/// </summary>
	public readonly uint Subresource {
		get => _subresource;
		init => _subresource = value;
	}
	readonly uint _subresource;

}

/// <summary>
/// STRUCTURE <b>D3D12_TILE_REGION_SIZE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TileRegionSize {

	/// <summary>
	/// <b>UINT NumTiles</b>
	/// </summary>
	public readonly uint NumTiles {
		get => _numTiles;
		init => _numTiles = value;
	}
	readonly uint _numTiles;

	/// <summary>
	/// <b>BOOL UseBox</b>
	/// </summary>
	public readonly bool UseBox {
		get => _useBox != 0;
		init => _useBox = value ? 1U : 0U;
	}
	readonly uint _useBox;

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT16 Height</b>
	/// </summary>
	public readonly ushort Height {
		get => _height;
		init => _height = value;
	}
	readonly ushort _height;

	/// <summary>
	/// <b>UINT16 Depth</b>
	/// </summary>
	public readonly ushort Depth {
		get => _depth;
		init => _depth = value;
	}
	readonly ushort _depth;

}

/// <summary>
/// STRUCTURE <b>D3D12_SUBRESOURCE_TILING</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SubresourceTiling {

	/// <summary>
	/// <b>UINT WidthInTiles</b>
	/// </summary>
	public readonly uint WidthInTiles {
		get => _widthInTiles;
		init => _widthInTiles = value;
	}
	readonly uint _widthInTiles;

	/// <summary>
	/// <b>UINT16 HeightInTiles</b>
	/// </summary>
	public readonly ushort HeightInTiles {
		get => _heightInTiles;
		init => _heightInTiles = value;
	}
	readonly ushort _heightInTiles;

	/// <summary>
	/// <b>UINT16 DepthInTiles</b>
	/// </summary>
	public readonly ushort DepthInTiles {
		get => _depthInTiles;
		init => _depthInTiles = value;
	}
	readonly ushort _depthInTiles;

	/// <summary>
	/// <b>UINT StartTileIndexInOverallResource</b>
	/// </summary>
	public readonly uint StartTileIndexInOverallResource {
		get => _startTileIndexInOverallResource;
		init => _startTileIndexInOverallResource = value;
	}
	readonly uint _startTileIndexInOverallResource;

}

/// <summary>
/// STRUCTURE <b>D3D12_TILE_SHAPE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TileShape {

	/// <summary>
	/// <b>UINT WidthInTexels</b>
	/// </summary>
	public readonly uint WidthInTexels {
		get => _widthInTexels;
		init => _widthInTexels = value;
	}
	readonly uint _widthInTexels;

	/// <summary>
	/// <b>UINT HeightInTexels</b>
	/// </summary>
	public readonly uint HeightInTexels {
		get => _heightInTexels;
		init => _heightInTexels = value;
	}
	readonly uint _heightInTexels;

	/// <summary>
	/// <b>UINT DepthInTexels</b>
	/// </summary>
	public readonly uint DepthInTexels {
		get => _depthInTexels;
		init => _depthInTexels = value;
	}
	readonly uint _depthInTexels;

}

/// <summary>
/// STRUCTURE <b>D3D12_PACKED_MIP_INFO</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PackedMipInfo {

	/// <summary>
	/// <b>UINT8 NumStandardMips</b>
	/// </summary>
	public readonly byte NumStandardMips {
		get => _numStandardMips;
		init => _numStandardMips = value;
	}
	readonly byte _numStandardMips;

	/// <summary>
	/// <b>UINT8 NumPackedMips</b>
	/// </summary>
	public readonly byte NumPackedMips {
		get => _numPackedMips;
		init => _numPackedMips = value;
	}
	readonly byte _numPackedMips;

	/// <summary>
	/// <b>UINT NumTilesForPackedMips</b>
	/// </summary>
	public readonly uint NumTilesForPackedMips {
		get => _numTilesForPackedMips;
		init => _numTilesForPackedMips = value;
	}
	readonly uint _numTilesForPackedMips;

	/// <summary>
	/// <b>UINT StartTileIndexInOverallResource</b>
	/// </summary>
	public readonly uint StartTileIndexInOverallResource {
		get => _startTileIndexInOverallResource;
		init => _startTileIndexInOverallResource = value;
	}
	readonly uint _startTileIndexInOverallResource;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_TRANSITION_BARRIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceTransitionBarrier {

	/// <summary>
	/// <b>ID3D12Resource* pResource</b>
	/// </summary>
	public readonly T* PResource<T> () where T : unmanaged, IResource => (T*) _pResource;
	readonly void* _pResource;

	/// <summary>
	/// <b>UINT Subresource</b>
	/// </summary>
	public readonly uint Subresource {
		get => _subresource;
		init => _subresource = value;
	}
	readonly uint _subresource;

	/// <summary>
	/// <b>D3D12_RESOURCE_STATES StateBefore</b>
	/// </summary>
	public readonly ResourceStates StateBefore {
		get => _stateBefore;
		init => _stateBefore = value;
	}
	readonly ResourceStates _stateBefore;

	/// <summary>
	/// <b>D3D12_RESOURCE_STATES StateAfter</b>
	/// </summary>
	public readonly ResourceStates StateAfter {
		get => _stateAfter;
		init => _stateAfter = value;
	}
	readonly ResourceStates _stateAfter;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_ALIASING_BARRIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceAliasingBarrier {

	/// <summary>
	/// <b>ID3D12Resource* pResourceBefore</b>
	/// </summary>
	public readonly T* PResourceBefore<T> () where T : unmanaged, IResource => (T*) _pResourceBefore;
	readonly void* _pResourceBefore;

	/// <summary>
	/// <b>ID3D12Resource* pResourceAfter</b>
	/// </summary>
	public readonly T* PResourceAfter<T> () where T : unmanaged, IResource => (T*) _pResourceAfter;
	readonly void* _pResourceAfter;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_UAV_BARRIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceUavBarrier {

	/// <summary>
	/// <b>ID3D12Resource* pResource</b>
	/// </summary>
	public readonly T* PResource<T> () where T : unmanaged, IResource => (T*) _pResource;
	readonly void* _pResource;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_BARRIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceBarrier {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_32 {

		[FieldOffset (0)] public ResourceTransitionBarrier _transition;
		[FieldOffset (0)] public ResourceAliasingBarrier _aliasing;
		[FieldOffset (0)] public ResourceUavBarrier _uAV;
	}

	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_TYPE Type</b>
	/// </summary>
	public readonly ResourceBarrierType Type {
		get => _type;
		init => _type = value;
	}
	readonly ResourceBarrierType _type;

	/// <summary>
	/// <b>D3D12_RESOURCE_BARRIER_FLAGS Flags</b>
	/// </summary>
	public readonly ResourceBarrierFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ResourceBarrierFlags _flags;

	/// <summary>
	/// <b>D3D12_RESOURCE_TRANSITION_BARRIER Transition</b>
	/// </summary>
	public readonly ResourceTransitionBarrier Transition {
		get => __aSP_AUTO_GENERATED_FIELD_32._transition;
		init => __aSP_AUTO_GENERATED_FIELD_32._transition = value;
	}

	/// <summary>
	/// <b>D3D12_RESOURCE_ALIASING_BARRIER Aliasing</b>
	/// </summary>
	public readonly ResourceAliasingBarrier Aliasing {
		get => __aSP_AUTO_GENERATED_FIELD_32._aliasing;
		init => __aSP_AUTO_GENERATED_FIELD_32._aliasing = value;
	}

	/// <summary>
	/// <b>D3D12_RESOURCE_UAV_BARRIER UAV</b>
	/// </summary>
	public readonly ResourceUavBarrier Uav {
		get => __aSP_AUTO_GENERATED_FIELD_32._uAV;
		init => __aSP_AUTO_GENERATED_FIELD_32._uAV = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_32 __aSP_AUTO_GENERATED_FIELD_32;

}

/// <summary>
/// STRUCTURE <b>D3D12_SUBRESOURCE_FOOTPRINT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SubresourceFootprint {

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>UINT Depth</b>
	/// </summary>
	public readonly uint Depth {
		get => _depth;
		init => _depth = value;
	}
	readonly uint _depth;

	/// <summary>
	/// <b>UINT RowPitch</b>
	/// </summary>
	public readonly uint RowPitch {
		get => _rowPitch;
		init => _rowPitch = value;
	}
	readonly uint _rowPitch;

}

/// <summary>
/// STRUCTURE <b>D3D12_PLACED_SUBRESOURCE_FOOTPRINT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PlacedSubresourceFootprint {

	/// <summary>
	/// <b>UINT64 Offset</b>
	/// </summary>
	public readonly ulong Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly ulong _offset;

	/// <summary>
	/// <b>D3D12_SUBRESOURCE_FOOTPRINT Footprint</b>
	/// </summary>
	public readonly SubresourceFootprint Footprint {
		get => _footprint;
		init => _footprint = value;
	}
	readonly SubresourceFootprint _footprint;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEXTURE_COPY_LOCATION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TextureCopyLocation {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_34 {

		[FieldOffset (0)] public PlacedSubresourceFootprint _placedFootprint;
		[FieldOffset (0)] public uint _subresourceIndex;
	}

	/// <summary>
	/// <b>ID3D12Resource* pResource</b>
	/// </summary>
	public readonly T* PResource<T> () where T : unmanaged, IResource => (T*) _pResource;
	readonly void* _pResource;

	/// <summary>
	/// <b>D3D12_TEXTURE_COPY_TYPE Type</b>
	/// </summary>
	public readonly TextureCopyType Type {
		get => _type;
		init => _type = value;
	}
	readonly TextureCopyType _type;

	/// <summary>
	/// <b>D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint</b>
	/// </summary>
	public readonly PlacedSubresourceFootprint PlacedFootprint {
		get => __aSP_AUTO_GENERATED_FIELD_34._placedFootprint;
		init => __aSP_AUTO_GENERATED_FIELD_34._placedFootprint = value;
	}

	/// <summary>
	/// <b>UINT SubresourceIndex</b>
	/// </summary>
	public readonly uint SubresourceIndex {
		get => __aSP_AUTO_GENERATED_FIELD_34._subresourceIndex;
		init => __aSP_AUTO_GENERATED_FIELD_34._subresourceIndex = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_34 __aSP_AUTO_GENERATED_FIELD_34;

}

/// <summary>
/// STRUCTURE <b>D3D12_SAMPLE_POSITION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SamplePosition {

	/// <summary>
	/// <b>INT8 X</b>
	/// </summary>
	public readonly sbyte X {
		get => _x;
		init => _x = value;
	}
	readonly sbyte _x;

	/// <summary>
	/// <b>INT8 Y</b>
	/// </summary>
	public readonly sbyte Y {
		get => _y;
		init => _y = value;
	}
	readonly sbyte _y;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIEW_INSTANCE_LOCATION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ViewInstanceLocation {

	/// <summary>
	/// <b>UINT ViewportArrayIndex</b>
	/// </summary>
	public readonly uint ViewportArrayIndex {
		get => _viewportArrayIndex;
		init => _viewportArrayIndex = value;
	}
	readonly uint _viewportArrayIndex;

	/// <summary>
	/// <b>UINT RenderTargetArrayIndex</b>
	/// </summary>
	public readonly uint RenderTargetArrayIndex {
		get => _renderTargetArrayIndex;
		init => _renderTargetArrayIndex = value;
	}
	readonly uint _renderTargetArrayIndex;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIEW_INSTANCING_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ViewInstancingDesc {

	/// <summary>
	/// <b>UINT ViewInstanceCount</b>
	/// </summary>
	public readonly uint ViewInstanceCount {
		get => _viewInstanceCount;
		init => _viewInstanceCount = value;
	}
	readonly uint _viewInstanceCount;

	/// <summary>
	/// <b>D3D12_VIEW_INSTANCE_LOCATION* pViewInstanceLocations</b>
	/// </summary>
	public readonly ViewInstanceLocation* PViewInstanceLocations {
		get => _pViewInstanceLocations;
		init => _pViewInstanceLocations = value;
	}
	readonly ViewInstanceLocation* _pViewInstanceLocations;

	/// <summary>
	/// <b>D3D12_VIEW_INSTANCING_FLAGS Flags</b>
	/// </summary>
	public readonly ViewInstancingFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ViewInstancingFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_BUFFER_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferSrv {

	/// <summary>
	/// <b>UINT64 FirstElement</b>
	/// </summary>
	public readonly ulong FirstElement {
		get => _firstElement;
		init => _firstElement = value;
	}
	readonly ulong _firstElement;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => _numElements;
		init => _numElements = value;
	}
	readonly uint _numElements;

	/// <summary>
	/// <b>UINT StructureByteStride</b>
	/// </summary>
	public readonly uint StructureByteStride {
		get => _structureByteStride;
		init => _structureByteStride = value;
	}
	readonly uint _structureByteStride;

	/// <summary>
	/// <b>D3D12_BUFFER_SRV_FLAGS Flags</b>
	/// </summary>
	public readonly BufferSrvFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly BufferSrvFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dSrv {

	/// <summary>
	/// <b>UINT MostDetailedMip</b>
	/// </summary>
	public readonly uint MostDetailedMip {
		get => _mostDetailedMip;
		init => _mostDetailedMip = value;
	}
	readonly uint _mostDetailedMip;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>FLOAT ResourceMinLODClamp</b>
	/// </summary>
	public readonly float ResourceMinLODClamp {
		get => _resourceMinLODClamp;
		init => _resourceMinLODClamp = value;
	}
	readonly float _resourceMinLODClamp;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_ARRAY_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dArraySrv {

	/// <summary>
	/// <b>UINT MostDetailedMip</b>
	/// </summary>
	public readonly uint MostDetailedMip {
		get => _mostDetailedMip;
		init => _mostDetailedMip = value;
	}
	readonly uint _mostDetailedMip;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

	/// <summary>
	/// <b>FLOAT ResourceMinLODClamp</b>
	/// </summary>
	public readonly float ResourceMinLODClamp {
		get => _resourceMinLODClamp;
		init => _resourceMinLODClamp = value;
	}
	readonly float _resourceMinLODClamp;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dSrv {

	/// <summary>
	/// <b>UINT MostDetailedMip</b>
	/// </summary>
	public readonly uint MostDetailedMip {
		get => _mostDetailedMip;
		init => _mostDetailedMip = value;
	}
	readonly uint _mostDetailedMip;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT PlaneSlice</b>
	/// </summary>
	public readonly uint PlaneSlice {
		get => _planeSlice;
		init => _planeSlice = value;
	}
	readonly uint _planeSlice;

	/// <summary>
	/// <b>FLOAT ResourceMinLODClamp</b>
	/// </summary>
	public readonly float ResourceMinLODClamp {
		get => _resourceMinLODClamp;
		init => _resourceMinLODClamp = value;
	}
	readonly float _resourceMinLODClamp;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_ARRAY_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArraySrv {

	/// <summary>
	/// <b>UINT MostDetailedMip</b>
	/// </summary>
	public readonly uint MostDetailedMip {
		get => _mostDetailedMip;
		init => _mostDetailedMip = value;
	}
	readonly uint _mostDetailedMip;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

	/// <summary>
	/// <b>UINT PlaneSlice</b>
	/// </summary>
	public readonly uint PlaneSlice {
		get => _planeSlice;
		init => _planeSlice = value;
	}
	readonly uint _planeSlice;

	/// <summary>
	/// <b>FLOAT ResourceMinLODClamp</b>
	/// </summary>
	public readonly float ResourceMinLODClamp {
		get => _resourceMinLODClamp;
		init => _resourceMinLODClamp = value;
	}
	readonly float _resourceMinLODClamp;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX3D_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex3dSrv {

	/// <summary>
	/// <b>UINT MostDetailedMip</b>
	/// </summary>
	public readonly uint MostDetailedMip {
		get => _mostDetailedMip;
		init => _mostDetailedMip = value;
	}
	readonly uint _mostDetailedMip;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>FLOAT ResourceMinLODClamp</b>
	/// </summary>
	public readonly float ResourceMinLODClamp {
		get => _resourceMinLODClamp;
		init => _resourceMinLODClamp = value;
	}
	readonly float _resourceMinLODClamp;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEXCUBE_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TexcubeSrv {

	/// <summary>
	/// <b>UINT MostDetailedMip</b>
	/// </summary>
	public readonly uint MostDetailedMip {
		get => _mostDetailedMip;
		init => _mostDetailedMip = value;
	}
	readonly uint _mostDetailedMip;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>FLOAT ResourceMinLODClamp</b>
	/// </summary>
	public readonly float ResourceMinLODClamp {
		get => _resourceMinLODClamp;
		init => _resourceMinLODClamp = value;
	}
	readonly float _resourceMinLODClamp;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEXCUBE_ARRAY_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TexcubeArraySrv {

	/// <summary>
	/// <b>UINT MostDetailedMip</b>
	/// </summary>
	public readonly uint MostDetailedMip {
		get => _mostDetailedMip;
		init => _mostDetailedMip = value;
	}
	readonly uint _mostDetailedMip;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT First2DArrayFace</b>
	/// </summary>
	public readonly uint First2DArrayFace {
		get => _first2DArrayFace;
		init => _first2DArrayFace = value;
	}
	readonly uint _first2DArrayFace;

	/// <summary>
	/// <b>UINT NumCubes</b>
	/// </summary>
	public readonly uint NumCubes {
		get => _numCubes;
		init => _numCubes = value;
	}
	readonly uint _numCubes;

	/// <summary>
	/// <b>FLOAT ResourceMinLODClamp</b>
	/// </summary>
	public readonly float ResourceMinLODClamp {
		get => _resourceMinLODClamp;
		init => _resourceMinLODClamp = value;
	}
	readonly float _resourceMinLODClamp;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2DMS_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dmsSrv {

	/// <summary>
	/// <b>UINT UnusedField_NothingToDefine</b>
	/// </summary>
	public readonly uint UnusedField_NothingToDefine {
		get => _unusedField_NothingToDefine;
		init => _unusedField_NothingToDefine = value;
	}
	readonly uint _unusedField_NothingToDefine;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2DMS_ARRAY_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dmsArraySrv {

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAccelerationStructureSrv {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS Location</b>
	/// </summary>
	public readonly ulong Location {
		get => _location;
		init => _location = value;
	}
	readonly ulong _location;

}

/// <summary>
/// STRUCTURE <b>D3D12_SHADER_RESOURCE_VIEW_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderResourceViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_36 {

		[FieldOffset (0)] public BufferSrv _buffer;
		[FieldOffset (0)] public Tex1dSrv _texture1D;
		[FieldOffset (0)] public Tex1dArraySrv _texture1DArray;
		[FieldOffset (0)] public Tex2dSrv _texture2D;
		[FieldOffset (0)] public Tex2dArraySrv _texture2DArray;
		[FieldOffset (0)] public Tex2dmsSrv _texture2DMS;
		[FieldOffset (0)] public Tex2dmsArraySrv _texture2DMSArray;
		[FieldOffset (0)] public Tex3dSrv _texture3D;
		[FieldOffset (0)] public TexcubeSrv _textureCube;
		[FieldOffset (0)] public TexcubeArraySrv _textureCubeArray;
		[FieldOffset (0)] public RaytracingAccelerationStructureSrv _raytracingAccelerationStructure;
	}

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D12_SRV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly SrvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly SrvDimension _viewDimension;

	/// <summary>
	/// <b>UINT Shader4ComponentMapping</b>
	/// </summary>
	public readonly uint Shader4ComponentMapping {
		get => _shader4ComponentMapping;
		init => _shader4ComponentMapping = value;
	}
	readonly uint _shader4ComponentMapping;

	/// <summary>
	/// <b>D3D12_BUFFER_SRV Buffer</b>
	/// </summary>
	public readonly BufferSrv Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_36._buffer;
		init => __aSP_AUTO_GENERATED_FIELD_36._buffer = value;
	}

	/// <summary>
	/// <b>D3D12_TEX1D_SRV Texture1D</b>
	/// </summary>
	public readonly Tex1dSrv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_36._texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_36._texture1D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX1D_ARRAY_SRV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArraySrv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_36._texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_36._texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_SRV Texture2D</b>
	/// </summary>
	public readonly Tex2dSrv Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_36._texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_36._texture2D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_ARRAY_SRV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArraySrv Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_36._texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_36._texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2DMS_SRV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsSrv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_36._texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_36._texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArraySrv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_36._texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_36._texture2DMSArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX3D_SRV Texture3D</b>
	/// </summary>
	public readonly Tex3dSrv Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_36._texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_36._texture3D = value;
	}

	/// <summary>
	/// <b>D3D12_TEXCUBE_SRV TextureCube</b>
	/// </summary>
	public readonly TexcubeSrv TextureCube {
		get => __aSP_AUTO_GENERATED_FIELD_36._textureCube;
		init => __aSP_AUTO_GENERATED_FIELD_36._textureCube = value;
	}

	/// <summary>
	/// <b>D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray</b>
	/// </summary>
	public readonly TexcubeArraySrv TextureCubeArray {
		get => __aSP_AUTO_GENERATED_FIELD_36._textureCubeArray;
		init => __aSP_AUTO_GENERATED_FIELD_36._textureCubeArray = value;
	}

	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure</b>
	/// </summary>
	public readonly RaytracingAccelerationStructureSrv RaytracingAccelerationStructure {
		get => __aSP_AUTO_GENERATED_FIELD_36._raytracingAccelerationStructure;
		init => __aSP_AUTO_GENERATED_FIELD_36._raytracingAccelerationStructure = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_36 __aSP_AUTO_GENERATED_FIELD_36;

}

/// <summary>
/// STRUCTURE <b>D3D12_CONSTANT_BUFFER_VIEW_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ConstantBufferViewDesc {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b>
	/// </summary>
	public readonly ulong BufferLocation {
		get => _bufferLocation;
		init => _bufferLocation = value;
	}
	readonly ulong _bufferLocation;

	/// <summary>
	/// <b>UINT SizeInBytes</b>
	/// </summary>
	public readonly uint SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly uint _sizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_SAMPLER_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SamplerDesc {

	/// <summary>
	/// <b>D3D12_FILTER Filter</b>
	/// </summary>
	public readonly Filter Filter {
		get => _filter;
		init => _filter = value;
	}
	readonly Filter _filter;

	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE AddressU</b>
	/// </summary>
	public readonly TextureAddressMode AddressU {
		get => _addressU;
		init => _addressU = value;
	}
	readonly TextureAddressMode _addressU;

	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE AddressV</b>
	/// </summary>
	public readonly TextureAddressMode AddressV {
		get => _addressV;
		init => _addressV = value;
	}
	readonly TextureAddressMode _addressV;

	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE AddressW</b>
	/// </summary>
	public readonly TextureAddressMode AddressW {
		get => _addressW;
		init => _addressW = value;
	}
	readonly TextureAddressMode _addressW;

	/// <summary>
	/// <b>FLOAT MipLODBias</b>
	/// </summary>
	public readonly float MipLODBias {
		get => _mipLODBias;
		init => _mipLODBias = value;
	}
	readonly float _mipLODBias;

	/// <summary>
	/// <b>UINT MaxAnisotropy</b>
	/// </summary>
	public readonly uint MaxAnisotropy {
		get => _maxAnisotropy;
		init => _maxAnisotropy = value;
	}
	readonly uint _maxAnisotropy;

	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC ComparisonFunc</b>
	/// </summary>
	public readonly ComparisonFunc ComparisonFunc {
		get => _comparisonFunc;
		init => _comparisonFunc = value;
	}
	readonly ComparisonFunc _comparisonFunc;

	/// <summary>
	/// <b>FLOAT BorderColor [4]</b>
	/// </summary>
	public readonly Span<float> BorderColor {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _borderColor)), 4);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_125 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [4];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_125 _borderColor;

	/// <summary>
	/// <b>FLOAT MinLOD</b>
	/// </summary>
	public readonly float MinLOD {
		get => _minLOD;
		init => _minLOD = value;
	}
	readonly float _minLOD;

	/// <summary>
	/// <b>FLOAT MaxLOD</b>
	/// </summary>
	public readonly float MaxLOD {
		get => _maxLOD;
		init => _maxLOD = value;
	}
	readonly float _maxLOD;

}

/// <summary>
/// STRUCTURE <b>D3D12_BUFFER_UAV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferUav {

	/// <summary>
	/// <b>UINT64 FirstElement</b>
	/// </summary>
	public readonly ulong FirstElement {
		get => _firstElement;
		init => _firstElement = value;
	}
	readonly ulong _firstElement;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => _numElements;
		init => _numElements = value;
	}
	readonly uint _numElements;

	/// <summary>
	/// <b>UINT StructureByteStride</b>
	/// </summary>
	public readonly uint StructureByteStride {
		get => _structureByteStride;
		init => _structureByteStride = value;
	}
	readonly uint _structureByteStride;

	/// <summary>
	/// <b>UINT64 CounterOffsetInBytes</b>
	/// </summary>
	public readonly ulong CounterOffsetInBytes {
		get => _counterOffsetInBytes;
		init => _counterOffsetInBytes = value;
	}
	readonly ulong _counterOffsetInBytes;

	/// <summary>
	/// <b>D3D12_BUFFER_UAV_FLAGS Flags</b>
	/// </summary>
	public readonly BufferUavFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly BufferUavFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_UAV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dUav {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_ARRAY_UAV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dArrayUav {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_UAV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dUav {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT PlaneSlice</b>
	/// </summary>
	public readonly uint PlaneSlice {
		get => _planeSlice;
		init => _planeSlice = value;
	}
	readonly uint _planeSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_ARRAY_UAV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArrayUav {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

	/// <summary>
	/// <b>UINT PlaneSlice</b>
	/// </summary>
	public readonly uint PlaneSlice {
		get => _planeSlice;
		init => _planeSlice = value;
	}
	readonly uint _planeSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX3D_UAV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex3dUav {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstWSlice</b>
	/// </summary>
	public readonly uint FirstWSlice {
		get => _firstWSlice;
		init => _firstWSlice = value;
	}
	readonly uint _firstWSlice;

	/// <summary>
	/// <b>UINT WSize</b>
	/// </summary>
	public readonly uint WSize {
		get => _wSize;
		init => _wSize = value;
	}
	readonly uint _wSize;

}

/// <summary>
/// STRUCTURE <b>D3D12_UNORDERED_ACCESS_VIEW_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct UnorderedAccessViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_38 {

		[FieldOffset (0)] public BufferUav _buffer;
		[FieldOffset (0)] public Tex1dUav _texture1D;
		[FieldOffset (0)] public Tex1dArrayUav _texture1DArray;
		[FieldOffset (0)] public Tex2dUav _texture2D;
		[FieldOffset (0)] public Tex2dArrayUav _texture2DArray;
		[FieldOffset (0)] public Tex3dUav _texture3D;
	}

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D12_UAV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly UavDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly UavDimension _viewDimension;

	/// <summary>
	/// <b>D3D12_BUFFER_UAV Buffer</b>
	/// </summary>
	public readonly BufferUav Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_38._buffer;
		init => __aSP_AUTO_GENERATED_FIELD_38._buffer = value;
	}

	/// <summary>
	/// <b>D3D12_TEX1D_UAV Texture1D</b>
	/// </summary>
	public readonly Tex1dUav Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_38._texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_38._texture1D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX1D_ARRAY_UAV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayUav Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_38._texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_38._texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_UAV Texture2D</b>
	/// </summary>
	public readonly Tex2dUav Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_38._texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_38._texture2D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_ARRAY_UAV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayUav Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_38._texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_38._texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX3D_UAV Texture3D</b>
	/// </summary>
	public readonly Tex3dUav Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_38._texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_38._texture3D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_38 __aSP_AUTO_GENERATED_FIELD_38;

}

/// <summary>
/// STRUCTURE <b>D3D12_BUFFER_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferRtv {

	/// <summary>
	/// <b>UINT64 FirstElement</b>
	/// </summary>
	public readonly ulong FirstElement {
		get => _firstElement;
		init => _firstElement = value;
	}
	readonly ulong _firstElement;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => _numElements;
		init => _numElements = value;
	}
	readonly uint _numElements;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dRtv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_ARRAY_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dArrayRtv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dRtv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT PlaneSlice</b>
	/// </summary>
	public readonly uint PlaneSlice {
		get => _planeSlice;
		init => _planeSlice = value;
	}
	readonly uint _planeSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2DMS_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dmsRtv {

	/// <summary>
	/// <b>UINT UnusedField_NothingToDefine</b>
	/// </summary>
	public readonly uint UnusedField_NothingToDefine {
		get => _unusedField_NothingToDefine;
		init => _unusedField_NothingToDefine = value;
	}
	readonly uint _unusedField_NothingToDefine;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_ARRAY_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArrayRtv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

	/// <summary>
	/// <b>UINT PlaneSlice</b>
	/// </summary>
	public readonly uint PlaneSlice {
		get => _planeSlice;
		init => _planeSlice = value;
	}
	readonly uint _planeSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2DMS_ARRAY_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dmsArrayRtv {

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX3D_RTV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex3dRtv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstWSlice</b>
	/// </summary>
	public readonly uint FirstWSlice {
		get => _firstWSlice;
		init => _firstWSlice = value;
	}
	readonly uint _firstWSlice;

	/// <summary>
	/// <b>UINT WSize</b>
	/// </summary>
	public readonly uint WSize {
		get => _wSize;
		init => _wSize = value;
	}
	readonly uint _wSize;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_TARGET_VIEW_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderTargetViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_40 {

		[FieldOffset (0)] public BufferRtv _buffer;
		[FieldOffset (0)] public Tex1dRtv _texture1D;
		[FieldOffset (0)] public Tex1dArrayRtv _texture1DArray;
		[FieldOffset (0)] public Tex2dRtv _texture2D;
		[FieldOffset (0)] public Tex2dArrayRtv _texture2DArray;
		[FieldOffset (0)] public Tex2dmsRtv _texture2DMS;
		[FieldOffset (0)] public Tex2dmsArrayRtv _texture2DMSArray;
		[FieldOffset (0)] public Tex3dRtv _texture3D;
	}

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D12_RTV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly RtvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly RtvDimension _viewDimension;

	/// <summary>
	/// <b>D3D12_BUFFER_RTV Buffer</b>
	/// </summary>
	public readonly BufferRtv Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_40._buffer;
		init => __aSP_AUTO_GENERATED_FIELD_40._buffer = value;
	}

	/// <summary>
	/// <b>D3D12_TEX1D_RTV Texture1D</b>
	/// </summary>
	public readonly Tex1dRtv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_40._texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_40._texture1D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX1D_ARRAY_RTV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayRtv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_40._texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_40._texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_RTV Texture2D</b>
	/// </summary>
	public readonly Tex2dRtv Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_40._texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_40._texture2D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_ARRAY_RTV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayRtv Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_40._texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_40._texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2DMS_RTV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsRtv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_40._texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_40._texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2DMS_ARRAY_RTV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArrayRtv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_40._texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_40._texture2DMSArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX3D_RTV Texture3D</b>
	/// </summary>
	public readonly Tex3dRtv Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_40._texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_40._texture3D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_40 __aSP_AUTO_GENERATED_FIELD_40;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_DSV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dDsv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX1D_ARRAY_DSV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex1dArrayDsv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_DSV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dDsv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2D_ARRAY_DSV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArrayDsv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2DMS_DSV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dmsDsv {

	/// <summary>
	/// <b>UINT UnusedField_NothingToDefine</b>
	/// </summary>
	public readonly uint UnusedField_NothingToDefine {
		get => _unusedField_NothingToDefine;
		init => _unusedField_NothingToDefine = value;
	}
	readonly uint _unusedField_NothingToDefine;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEX2DMS_ARRAY_DSV</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dmsArrayDsv {

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEPTH_STENCIL_VIEW_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DepthStencilViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_42 {

		[FieldOffset (0)] public Tex1dDsv _texture1D;
		[FieldOffset (0)] public Tex1dArrayDsv _texture1DArray;
		[FieldOffset (0)] public Tex2dDsv _texture2D;
		[FieldOffset (0)] public Tex2dArrayDsv _texture2DArray;
		[FieldOffset (0)] public Tex2dmsDsv _texture2DMS;
		[FieldOffset (0)] public Tex2dmsArrayDsv _texture2DMSArray;
	}

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D12_DSV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly DsvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly DsvDimension _viewDimension;

	/// <summary>
	/// <b>D3D12_DSV_FLAGS Flags</b>
	/// </summary>
	public readonly DsvFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly DsvFlags _flags;

	/// <summary>
	/// <b>D3D12_TEX1D_DSV Texture1D</b>
	/// </summary>
	public readonly Tex1dDsv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_42._texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_42._texture1D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX1D_ARRAY_DSV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayDsv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_42._texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_42._texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_DSV Texture2D</b>
	/// </summary>
	public readonly Tex2dDsv Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_42._texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_42._texture2D = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2D_ARRAY_DSV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayDsv Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_42._texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_42._texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2DMS_DSV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsDsv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_42._texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_42._texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D12_TEX2DMS_ARRAY_DSV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArrayDsv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_42._texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_42._texture2DMSArray = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_42 __aSP_AUTO_GENERATED_FIELD_42;

}

/// <summary>
/// STRUCTURE <b>D3D12_DESCRIPTOR_HEAP_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DescriptorHeapDesc {

	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_TYPE Type</b>
	/// </summary>
	public readonly DescriptorHeapType Type {
		get => _type;
		init => _type = value;
	}
	readonly DescriptorHeapType _type;

	/// <summary>
	/// <b>UINT NumDescriptors</b>
	/// </summary>
	public readonly uint NumDescriptors {
		get => _numDescriptors;
		init => _numDescriptors = value;
	}
	readonly uint _numDescriptors;

	/// <summary>
	/// <b>D3D12_DESCRIPTOR_HEAP_FLAGS Flags</b>
	/// </summary>
	public readonly DescriptorHeapFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly DescriptorHeapFlags _flags;

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

}

/// <summary>
/// STRUCTURE <b>D3D12_DESCRIPTOR_RANGE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DescriptorRange {

	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_TYPE RangeType</b>
	/// </summary>
	public readonly DescriptorRangeType RangeType {
		get => _rangeType;
		init => _rangeType = value;
	}
	readonly DescriptorRangeType _rangeType;

	/// <summary>
	/// <b>UINT NumDescriptors</b>
	/// </summary>
	public readonly uint NumDescriptors {
		get => _numDescriptors;
		init => _numDescriptors = value;
	}
	readonly uint _numDescriptors;

	/// <summary>
	/// <b>UINT BaseShaderRegister</b>
	/// </summary>
	public readonly uint BaseShaderRegister {
		get => _baseShaderRegister;
		init => _baseShaderRegister = value;
	}
	readonly uint _baseShaderRegister;

	/// <summary>
	/// <b>UINT RegisterSpace</b>
	/// </summary>
	public readonly uint RegisterSpace {
		get => _registerSpace;
		init => _registerSpace = value;
	}
	readonly uint _registerSpace;

	/// <summary>
	/// <b>UINT OffsetInDescriptorsFromTableStart</b>
	/// </summary>
	public readonly uint OffsetInDescriptorsFromTableStart {
		get => _offsetInDescriptorsFromTableStart;
		init => _offsetInDescriptorsFromTableStart = value;
	}
	readonly uint _offsetInDescriptorsFromTableStart;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_DESCRIPTOR_TABLE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootDescriptorTable {

	/// <summary>
	/// <b>UINT NumDescriptorRanges</b>
	/// </summary>
	public readonly uint NumDescriptorRanges {
		get => _numDescriptorRanges;
		init => _numDescriptorRanges = value;
	}
	readonly uint _numDescriptorRanges;

	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE* pDescriptorRanges</b>
	/// </summary>
	public readonly DescriptorRange* PDescriptorRanges {
		get => _pDescriptorRanges;
		init => _pDescriptorRanges = value;
	}
	readonly DescriptorRange* _pDescriptorRanges;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_CONSTANTS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootConstants {

	/// <summary>
	/// <b>UINT ShaderRegister</b>
	/// </summary>
	public readonly uint ShaderRegister {
		get => _shaderRegister;
		init => _shaderRegister = value;
	}
	readonly uint _shaderRegister;

	/// <summary>
	/// <b>UINT RegisterSpace</b>
	/// </summary>
	public readonly uint RegisterSpace {
		get => _registerSpace;
		init => _registerSpace = value;
	}
	readonly uint _registerSpace;

	/// <summary>
	/// <b>UINT Num32BitValues</b>
	/// </summary>
	public readonly uint Num32BitValues {
		get => _num32BitValues;
		init => _num32BitValues = value;
	}
	readonly uint _num32BitValues;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_DESCRIPTOR</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootDescriptor {

	/// <summary>
	/// <b>UINT ShaderRegister</b>
	/// </summary>
	public readonly uint ShaderRegister {
		get => _shaderRegister;
		init => _shaderRegister = value;
	}
	readonly uint _shaderRegister;

	/// <summary>
	/// <b>UINT RegisterSpace</b>
	/// </summary>
	public readonly uint RegisterSpace {
		get => _registerSpace;
		init => _registerSpace = value;
	}
	readonly uint _registerSpace;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_PARAMETER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootParameter {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_44 {

		[FieldOffset (0)] public RootDescriptorTable _descriptorTable;
		[FieldOffset (0)] public RootConstants _constants;
		[FieldOffset (0)] public RootDescriptor _descriptor;
	}

	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER_TYPE ParameterType</b>
	/// </summary>
	public readonly RootParameterType ParameterType {
		get => _parameterType;
		init => _parameterType = value;
	}
	readonly RootParameterType _parameterType;

	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable</b>
	/// </summary>
	public readonly RootDescriptorTable DescriptorTable {
		get => __aSP_AUTO_GENERATED_FIELD_44._descriptorTable;
		init => __aSP_AUTO_GENERATED_FIELD_44._descriptorTable = value;
	}

	/// <summary>
	/// <b>D3D12_ROOT_CONSTANTS Constants</b>
	/// </summary>
	public readonly RootConstants Constants {
		get => __aSP_AUTO_GENERATED_FIELD_44._constants;
		init => __aSP_AUTO_GENERATED_FIELD_44._constants = value;
	}

	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR Descriptor</b>
	/// </summary>
	public readonly RootDescriptor Descriptor {
		get => __aSP_AUTO_GENERATED_FIELD_44._descriptor;
		init => __aSP_AUTO_GENERATED_FIELD_44._descriptor = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_44 __aSP_AUTO_GENERATED_FIELD_44;

	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY ShaderVisibility</b>
	/// </summary>
	public readonly ShaderVisibility ShaderVisibility {
		get => _shaderVisibility;
		init => _shaderVisibility = value;
	}
	readonly ShaderVisibility _shaderVisibility;

}

/// <summary>
/// STRUCTURE <b>D3D12_STATIC_SAMPLER_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StaticSamplerDesc {

	/// <summary>
	/// <b>D3D12_FILTER Filter</b>
	/// </summary>
	public readonly Filter Filter {
		get => _filter;
		init => _filter = value;
	}
	readonly Filter _filter;

	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE AddressU</b>
	/// </summary>
	public readonly TextureAddressMode AddressU {
		get => _addressU;
		init => _addressU = value;
	}
	readonly TextureAddressMode _addressU;

	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE AddressV</b>
	/// </summary>
	public readonly TextureAddressMode AddressV {
		get => _addressV;
		init => _addressV = value;
	}
	readonly TextureAddressMode _addressV;

	/// <summary>
	/// <b>D3D12_TEXTURE_ADDRESS_MODE AddressW</b>
	/// </summary>
	public readonly TextureAddressMode AddressW {
		get => _addressW;
		init => _addressW = value;
	}
	readonly TextureAddressMode _addressW;

	/// <summary>
	/// <b>FLOAT MipLODBias</b>
	/// </summary>
	public readonly float MipLODBias {
		get => _mipLODBias;
		init => _mipLODBias = value;
	}
	readonly float _mipLODBias;

	/// <summary>
	/// <b>UINT MaxAnisotropy</b>
	/// </summary>
	public readonly uint MaxAnisotropy {
		get => _maxAnisotropy;
		init => _maxAnisotropy = value;
	}
	readonly uint _maxAnisotropy;

	/// <summary>
	/// <b>D3D12_COMPARISON_FUNC ComparisonFunc</b>
	/// </summary>
	public readonly ComparisonFunc ComparisonFunc {
		get => _comparisonFunc;
		init => _comparisonFunc = value;
	}
	readonly ComparisonFunc _comparisonFunc;

	/// <summary>
	/// <b>D3D12_STATIC_BORDER_COLOR BorderColor</b>
	/// </summary>
	public readonly StaticBorderColor BorderColor {
		get => _borderColor;
		init => _borderColor = value;
	}
	readonly StaticBorderColor _borderColor;

	/// <summary>
	/// <b>FLOAT MinLOD</b>
	/// </summary>
	public readonly float MinLOD {
		get => _minLOD;
		init => _minLOD = value;
	}
	readonly float _minLOD;

	/// <summary>
	/// <b>FLOAT MaxLOD</b>
	/// </summary>
	public readonly float MaxLOD {
		get => _maxLOD;
		init => _maxLOD = value;
	}
	readonly float _maxLOD;

	/// <summary>
	/// <b>UINT ShaderRegister</b>
	/// </summary>
	public readonly uint ShaderRegister {
		get => _shaderRegister;
		init => _shaderRegister = value;
	}
	readonly uint _shaderRegister;

	/// <summary>
	/// <b>UINT RegisterSpace</b>
	/// </summary>
	public readonly uint RegisterSpace {
		get => _registerSpace;
		init => _registerSpace = value;
	}
	readonly uint _registerSpace;

	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY ShaderVisibility</b>
	/// </summary>
	public readonly ShaderVisibility ShaderVisibility {
		get => _shaderVisibility;
		init => _shaderVisibility = value;
	}
	readonly ShaderVisibility _shaderVisibility;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_SIGNATURE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootSignatureDesc {

	/// <summary>
	/// <b>UINT NumParameters</b>
	/// </summary>
	public readonly uint NumParameters {
		get => _numParameters;
		init => _numParameters = value;
	}
	readonly uint _numParameters;

	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER* pParameters</b>
	/// </summary>
	public readonly RootParameter* PParameters {
		get => _pParameters;
		init => _pParameters = value;
	}
	readonly RootParameter* _pParameters;

	/// <summary>
	/// <b>UINT NumStaticSamplers</b>
	/// </summary>
	public readonly uint NumStaticSamplers {
		get => _numStaticSamplers;
		init => _numStaticSamplers = value;
	}
	readonly uint _numStaticSamplers;

	/// <summary>
	/// <b>D3D12_STATIC_SAMPLER_DESC* pStaticSamplers</b>
	/// </summary>
	public readonly StaticSamplerDesc* PStaticSamplers {
		get => _pStaticSamplers;
		init => _pStaticSamplers = value;
	}
	readonly StaticSamplerDesc* _pStaticSamplers;

	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAGS Flags</b>
	/// </summary>
	public readonly RootSignatureFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly RootSignatureFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_DESCRIPTOR_RANGE1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DescriptorRange1 {

	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_TYPE RangeType</b>
	/// </summary>
	public readonly DescriptorRangeType RangeType {
		get => _rangeType;
		init => _rangeType = value;
	}
	readonly DescriptorRangeType _rangeType;

	/// <summary>
	/// <b>UINT NumDescriptors</b>
	/// </summary>
	public readonly uint NumDescriptors {
		get => _numDescriptors;
		init => _numDescriptors = value;
	}
	readonly uint _numDescriptors;

	/// <summary>
	/// <b>UINT BaseShaderRegister</b>
	/// </summary>
	public readonly uint BaseShaderRegister {
		get => _baseShaderRegister;
		init => _baseShaderRegister = value;
	}
	readonly uint _baseShaderRegister;

	/// <summary>
	/// <b>UINT RegisterSpace</b>
	/// </summary>
	public readonly uint RegisterSpace {
		get => _registerSpace;
		init => _registerSpace = value;
	}
	readonly uint _registerSpace;

	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE_FLAGS Flags</b>
	/// </summary>
	public readonly DescriptorRangeFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly DescriptorRangeFlags _flags;

	/// <summary>
	/// <b>UINT OffsetInDescriptorsFromTableStart</b>
	/// </summary>
	public readonly uint OffsetInDescriptorsFromTableStart {
		get => _offsetInDescriptorsFromTableStart;
		init => _offsetInDescriptorsFromTableStart = value;
	}
	readonly uint _offsetInDescriptorsFromTableStart;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_DESCRIPTOR_TABLE1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootDescriptorTable1 {

	/// <summary>
	/// <b>UINT NumDescriptorRanges</b>
	/// </summary>
	public readonly uint NumDescriptorRanges {
		get => _numDescriptorRanges;
		init => _numDescriptorRanges = value;
	}
	readonly uint _numDescriptorRanges;

	/// <summary>
	/// <b>D3D12_DESCRIPTOR_RANGE1* pDescriptorRanges</b>
	/// </summary>
	public readonly DescriptorRange1* PDescriptorRanges {
		get => _pDescriptorRanges;
		init => _pDescriptorRanges = value;
	}
	readonly DescriptorRange1* _pDescriptorRanges;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_DESCRIPTOR1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootDescriptor1 {

	/// <summary>
	/// <b>UINT ShaderRegister</b>
	/// </summary>
	public readonly uint ShaderRegister {
		get => _shaderRegister;
		init => _shaderRegister = value;
	}
	readonly uint _shaderRegister;

	/// <summary>
	/// <b>UINT RegisterSpace</b>
	/// </summary>
	public readonly uint RegisterSpace {
		get => _registerSpace;
		init => _registerSpace = value;
	}
	readonly uint _registerSpace;

	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR_FLAGS Flags</b>
	/// </summary>
	public readonly RootDescriptorFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly RootDescriptorFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_PARAMETER1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootParameter1 {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_46 {

		[FieldOffset (0)] public RootDescriptorTable1 _descriptorTable;
		[FieldOffset (0)] public RootConstants _constants;
		[FieldOffset (0)] public RootDescriptor1 _descriptor;
	}

	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER_TYPE ParameterType</b>
	/// </summary>
	public readonly RootParameterType ParameterType {
		get => _parameterType;
		init => _parameterType = value;
	}
	readonly RootParameterType _parameterType;

	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable</b>
	/// </summary>
	public readonly RootDescriptorTable1 DescriptorTable {
		get => __aSP_AUTO_GENERATED_FIELD_46._descriptorTable;
		init => __aSP_AUTO_GENERATED_FIELD_46._descriptorTable = value;
	}

	/// <summary>
	/// <b>D3D12_ROOT_CONSTANTS Constants</b>
	/// </summary>
	public readonly RootConstants Constants {
		get => __aSP_AUTO_GENERATED_FIELD_46._constants;
		init => __aSP_AUTO_GENERATED_FIELD_46._constants = value;
	}

	/// <summary>
	/// <b>D3D12_ROOT_DESCRIPTOR1 Descriptor</b>
	/// </summary>
	public readonly RootDescriptor1 Descriptor {
		get => __aSP_AUTO_GENERATED_FIELD_46._descriptor;
		init => __aSP_AUTO_GENERATED_FIELD_46._descriptor = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_46 __aSP_AUTO_GENERATED_FIELD_46;

	/// <summary>
	/// <b>D3D12_SHADER_VISIBILITY ShaderVisibility</b>
	/// </summary>
	public readonly ShaderVisibility ShaderVisibility {
		get => _shaderVisibility;
		init => _shaderVisibility = value;
	}
	readonly ShaderVisibility _shaderVisibility;

}

/// <summary>
/// STRUCTURE <b>D3D12_ROOT_SIGNATURE_DESC1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RootSignatureDesc1 {

	/// <summary>
	/// <b>UINT NumParameters</b>
	/// </summary>
	public readonly uint NumParameters {
		get => _numParameters;
		init => _numParameters = value;
	}
	readonly uint _numParameters;

	/// <summary>
	/// <b>D3D12_ROOT_PARAMETER1* pParameters</b>
	/// </summary>
	public readonly RootParameter1* PParameters {
		get => _pParameters;
		init => _pParameters = value;
	}
	readonly RootParameter1* _pParameters;

	/// <summary>
	/// <b>UINT NumStaticSamplers</b>
	/// </summary>
	public readonly uint NumStaticSamplers {
		get => _numStaticSamplers;
		init => _numStaticSamplers = value;
	}
	readonly uint _numStaticSamplers;

	/// <summary>
	/// <b>D3D12_STATIC_SAMPLER_DESC* pStaticSamplers</b>
	/// </summary>
	public readonly StaticSamplerDesc* PStaticSamplers {
		get => _pStaticSamplers;
		init => _pStaticSamplers = value;
	}
	readonly StaticSamplerDesc* _pStaticSamplers;

	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_FLAGS Flags</b>
	/// </summary>
	public readonly RootSignatureFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly RootSignatureFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_VERSIONED_ROOT_SIGNATURE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VersionedRootSignatureDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_48 {

		[FieldOffset (0)] public RootSignatureDesc _desc_1_0;
		[FieldOffset (0)] public RootSignatureDesc1 _desc_1_1;
	}

	/// <summary>
	/// <b>D3D_ROOT_SIGNATURE_VERSION Version</b>
	/// </summary>
	public readonly Direct3D.RootSignatureVersion Version {
		get => _version;
		init => _version = value;
	}
	readonly Direct3D.RootSignatureVersion _version;

	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_DESC Desc_1_0</b>
	/// </summary>
	public readonly RootSignatureDesc Desc_1_0 {
		get => __aSP_AUTO_GENERATED_FIELD_48._desc_1_0;
		init => __aSP_AUTO_GENERATED_FIELD_48._desc_1_0 = value;
	}

	/// <summary>
	/// <b>D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1</b>
	/// </summary>
	public readonly RootSignatureDesc1 Desc_1_1 {
		get => __aSP_AUTO_GENERATED_FIELD_48._desc_1_1;
		init => __aSP_AUTO_GENERATED_FIELD_48._desc_1_1 = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_48 __aSP_AUTO_GENERATED_FIELD_48;

}

/// <summary>
/// STRUCTURE <b>D3D12_CPU_DESCRIPTOR_HANDLE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CpuDescriptorHandle {

	/// <summary>
	/// <b>SIZE_T ptr</b>
	/// </summary>
	public readonly nuint Ptr {
		get => _ptr;
		init => _ptr = value;
	}
	readonly nuint _ptr;

}

/// <summary>
/// STRUCTURE <b>D3D12_GPU_DESCRIPTOR_HANDLE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GpuDescriptorHandle {

	/// <summary>
	/// <b>UINT64 ptr</b>
	/// </summary>
	public readonly ulong Ptr {
		get => _ptr;
		init => _ptr = value;
	}
	readonly ulong _ptr;

}

/// <summary>
/// STRUCTURE <b>D3D12_DISCARD_REGION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DiscardRegion {

	/// <summary>
	/// <b>UINT NumRects</b>
	/// </summary>
	public readonly uint NumRects {
		get => _numRects;
		init => _numRects = value;
	}
	readonly uint _numRects;

	/// <summary>
	/// <b>D3D12_RECT* pRects</b>
	/// </summary>
	public readonly Vector4I* PRects {
		get => _pRects;
		init => _pRects = value;
	}
	readonly Vector4I* _pRects;

	/// <summary>
	/// <b>UINT FirstSubresource</b>
	/// </summary>
	public readonly uint FirstSubresource {
		get => _firstSubresource;
		init => _firstSubresource = value;
	}
	readonly uint _firstSubresource;

	/// <summary>
	/// <b>UINT NumSubresources</b>
	/// </summary>
	public readonly uint NumSubresources {
		get => _numSubresources;
		init => _numSubresources = value;
	}
	readonly uint _numSubresources;

}

/// <summary>
/// STRUCTURE <b>D3D12_QUERY_HEAP_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryHeapDesc {

	/// <summary>
	/// <b>D3D12_QUERY_HEAP_TYPE Type</b>
	/// </summary>
	public readonly QueryHeapType Type {
		get => _type;
		init => _type = value;
	}
	readonly QueryHeapType _type;

	/// <summary>
	/// <b>UINT Count</b>
	/// </summary>
	public readonly uint Count {
		get => _count;
		init => _count = value;
	}
	readonly uint _count;

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

}

/// <summary>
/// STRUCTURE <b>D3D12_QUERY_DATA_PIPELINE_STATISTICS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryDataPipelineStatistics {

	/// <summary>
	/// <b>UINT64 IAVertices</b>
	/// </summary>
	public readonly ulong IAVertices {
		get => _iAVertices;
		init => _iAVertices = value;
	}
	readonly ulong _iAVertices;

	/// <summary>
	/// <b>UINT64 IAPrimitives</b>
	/// </summary>
	public readonly ulong IAPrimitives {
		get => _iAPrimitives;
		init => _iAPrimitives = value;
	}
	readonly ulong _iAPrimitives;

	/// <summary>
	/// <b>UINT64 VSInvocations</b>
	/// </summary>
	public readonly ulong VSInvocations {
		get => _vSInvocations;
		init => _vSInvocations = value;
	}
	readonly ulong _vSInvocations;

	/// <summary>
	/// <b>UINT64 GSInvocations</b>
	/// </summary>
	public readonly ulong GSInvocations {
		get => _gSInvocations;
		init => _gSInvocations = value;
	}
	readonly ulong _gSInvocations;

	/// <summary>
	/// <b>UINT64 GSPrimitives</b>
	/// </summary>
	public readonly ulong GSPrimitives {
		get => _gSPrimitives;
		init => _gSPrimitives = value;
	}
	readonly ulong _gSPrimitives;

	/// <summary>
	/// <b>UINT64 CInvocations</b>
	/// </summary>
	public readonly ulong CInvocations {
		get => _cInvocations;
		init => _cInvocations = value;
	}
	readonly ulong _cInvocations;

	/// <summary>
	/// <b>UINT64 CPrimitives</b>
	/// </summary>
	public readonly ulong CPrimitives {
		get => _cPrimitives;
		init => _cPrimitives = value;
	}
	readonly ulong _cPrimitives;

	/// <summary>
	/// <b>UINT64 PSInvocations</b>
	/// </summary>
	public readonly ulong PSInvocations {
		get => _pSInvocations;
		init => _pSInvocations = value;
	}
	readonly ulong _pSInvocations;

	/// <summary>
	/// <b>UINT64 HSInvocations</b>
	/// </summary>
	public readonly ulong HSInvocations {
		get => _hSInvocations;
		init => _hSInvocations = value;
	}
	readonly ulong _hSInvocations;

	/// <summary>
	/// <b>UINT64 DSInvocations</b>
	/// </summary>
	public readonly ulong DSInvocations {
		get => _dSInvocations;
		init => _dSInvocations = value;
	}
	readonly ulong _dSInvocations;

	/// <summary>
	/// <b>UINT64 CSInvocations</b>
	/// </summary>
	public readonly ulong CSInvocations {
		get => _cSInvocations;
		init => _cSInvocations = value;
	}
	readonly ulong _cSInvocations;

}

/// <summary>
/// STRUCTURE <b>D3D12_QUERY_DATA_PIPELINE_STATISTICS1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryDataPipelineStatistics1 {

	/// <summary>
	/// <b>UINT64 IAVertices</b>
	/// </summary>
	public readonly ulong IAVertices {
		get => _iAVertices;
		init => _iAVertices = value;
	}
	readonly ulong _iAVertices;

	/// <summary>
	/// <b>UINT64 IAPrimitives</b>
	/// </summary>
	public readonly ulong IAPrimitives {
		get => _iAPrimitives;
		init => _iAPrimitives = value;
	}
	readonly ulong _iAPrimitives;

	/// <summary>
	/// <b>UINT64 VSInvocations</b>
	/// </summary>
	public readonly ulong VSInvocations {
		get => _vSInvocations;
		init => _vSInvocations = value;
	}
	readonly ulong _vSInvocations;

	/// <summary>
	/// <b>UINT64 GSInvocations</b>
	/// </summary>
	public readonly ulong GSInvocations {
		get => _gSInvocations;
		init => _gSInvocations = value;
	}
	readonly ulong _gSInvocations;

	/// <summary>
	/// <b>UINT64 GSPrimitives</b>
	/// </summary>
	public readonly ulong GSPrimitives {
		get => _gSPrimitives;
		init => _gSPrimitives = value;
	}
	readonly ulong _gSPrimitives;

	/// <summary>
	/// <b>UINT64 CInvocations</b>
	/// </summary>
	public readonly ulong CInvocations {
		get => _cInvocations;
		init => _cInvocations = value;
	}
	readonly ulong _cInvocations;

	/// <summary>
	/// <b>UINT64 CPrimitives</b>
	/// </summary>
	public readonly ulong CPrimitives {
		get => _cPrimitives;
		init => _cPrimitives = value;
	}
	readonly ulong _cPrimitives;

	/// <summary>
	/// <b>UINT64 PSInvocations</b>
	/// </summary>
	public readonly ulong PSInvocations {
		get => _pSInvocations;
		init => _pSInvocations = value;
	}
	readonly ulong _pSInvocations;

	/// <summary>
	/// <b>UINT64 HSInvocations</b>
	/// </summary>
	public readonly ulong HSInvocations {
		get => _hSInvocations;
		init => _hSInvocations = value;
	}
	readonly ulong _hSInvocations;

	/// <summary>
	/// <b>UINT64 DSInvocations</b>
	/// </summary>
	public readonly ulong DSInvocations {
		get => _dSInvocations;
		init => _dSInvocations = value;
	}
	readonly ulong _dSInvocations;

	/// <summary>
	/// <b>UINT64 CSInvocations</b>
	/// </summary>
	public readonly ulong CSInvocations {
		get => _cSInvocations;
		init => _cSInvocations = value;
	}
	readonly ulong _cSInvocations;

	/// <summary>
	/// <b>UINT64 ASInvocations</b>
	/// </summary>
	public readonly ulong ASInvocations {
		get => _aSInvocations;
		init => _aSInvocations = value;
	}
	readonly ulong _aSInvocations;

	/// <summary>
	/// <b>UINT64 MSInvocations</b>
	/// </summary>
	public readonly ulong MSInvocations {
		get => _mSInvocations;
		init => _mSInvocations = value;
	}
	readonly ulong _mSInvocations;

	/// <summary>
	/// <b>UINT64 MSPrimitives</b>
	/// </summary>
	public readonly ulong MSPrimitives {
		get => _mSPrimitives;
		init => _mSPrimitives = value;
	}
	readonly ulong _mSPrimitives;

}

/// <summary>
/// STRUCTURE <b>D3D12_QUERY_DATA_SO_STATISTICS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryDataSoStatistics {

	/// <summary>
	/// <b>UINT64 NumPrimitivesWritten</b>
	/// </summary>
	public readonly ulong NumPrimitivesWritten {
		get => _numPrimitivesWritten;
		init => _numPrimitivesWritten = value;
	}
	readonly ulong _numPrimitivesWritten;

	/// <summary>
	/// <b>UINT64 PrimitivesStorageNeeded</b>
	/// </summary>
	public readonly ulong PrimitivesStorageNeeded {
		get => _primitivesStorageNeeded;
		init => _primitivesStorageNeeded = value;
	}
	readonly ulong _primitivesStorageNeeded;

}

/// <summary>
/// STRUCTURE <b>D3D12_STREAM_OUTPUT_BUFFER_VIEW</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StreamOutputBufferView {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b>
	/// </summary>
	public readonly ulong BufferLocation {
		get => _bufferLocation;
		init => _bufferLocation = value;
	}
	readonly ulong _bufferLocation;

	/// <summary>
	/// <b>UINT64 SizeInBytes</b>
	/// </summary>
	public readonly ulong SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly ulong _sizeInBytes;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS BufferFilledSizeLocation</b>
	/// </summary>
	public readonly ulong BufferFilledSizeLocation {
		get => _bufferFilledSizeLocation;
		init => _bufferFilledSizeLocation = value;
	}
	readonly ulong _bufferFilledSizeLocation;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRAW_ARGUMENTS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DrawArguments {

	/// <summary>
	/// <b>UINT VertexCountPerInstance</b>
	/// </summary>
	public readonly uint VertexCountPerInstance {
		get => _vertexCountPerInstance;
		init => _vertexCountPerInstance = value;
	}
	readonly uint _vertexCountPerInstance;

	/// <summary>
	/// <b>UINT InstanceCount</b>
	/// </summary>
	public readonly uint InstanceCount {
		get => _instanceCount;
		init => _instanceCount = value;
	}
	readonly uint _instanceCount;

	/// <summary>
	/// <b>UINT StartVertexLocation</b>
	/// </summary>
	public readonly uint StartVertexLocation {
		get => _startVertexLocation;
		init => _startVertexLocation = value;
	}
	readonly uint _startVertexLocation;

	/// <summary>
	/// <b>UINT StartInstanceLocation</b>
	/// </summary>
	public readonly uint StartInstanceLocation {
		get => _startInstanceLocation;
		init => _startInstanceLocation = value;
	}
	readonly uint _startInstanceLocation;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRAW_INDEXED_ARGUMENTS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DrawIndexedArguments {

	/// <summary>
	/// <b>UINT IndexCountPerInstance</b>
	/// </summary>
	public readonly uint IndexCountPerInstance {
		get => _indexCountPerInstance;
		init => _indexCountPerInstance = value;
	}
	readonly uint _indexCountPerInstance;

	/// <summary>
	/// <b>UINT InstanceCount</b>
	/// </summary>
	public readonly uint InstanceCount {
		get => _instanceCount;
		init => _instanceCount = value;
	}
	readonly uint _instanceCount;

	/// <summary>
	/// <b>UINT StartIndexLocation</b>
	/// </summary>
	public readonly uint StartIndexLocation {
		get => _startIndexLocation;
		init => _startIndexLocation = value;
	}
	readonly uint _startIndexLocation;

	/// <summary>
	/// <b>INT BaseVertexLocation</b>
	/// </summary>
	public readonly int BaseVertexLocation {
		get => _baseVertexLocation;
		init => _baseVertexLocation = value;
	}
	readonly int _baseVertexLocation;

	/// <summary>
	/// <b>UINT StartInstanceLocation</b>
	/// </summary>
	public readonly uint StartInstanceLocation {
		get => _startInstanceLocation;
		init => _startInstanceLocation = value;
	}
	readonly uint _startInstanceLocation;

}

/// <summary>
/// STRUCTURE <b>D3D12_DISPATCH_ARGUMENTS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DispatchArguments {

	/// <summary>
	/// <b>UINT ThreadGroupCountX</b>
	/// </summary>
	public readonly uint ThreadGroupCountX {
		get => _threadGroupCountX;
		init => _threadGroupCountX = value;
	}
	readonly uint _threadGroupCountX;

	/// <summary>
	/// <b>UINT ThreadGroupCountY</b>
	/// </summary>
	public readonly uint ThreadGroupCountY {
		get => _threadGroupCountY;
		init => _threadGroupCountY = value;
	}
	readonly uint _threadGroupCountY;

	/// <summary>
	/// <b>UINT ThreadGroupCountZ</b>
	/// </summary>
	public readonly uint ThreadGroupCountZ {
		get => _threadGroupCountZ;
		init => _threadGroupCountZ = value;
	}
	readonly uint _threadGroupCountZ;

}

/// <summary>
/// STRUCTURE <b>D3D12_VERTEX_BUFFER_VIEW</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VertexBufferView {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b>
	/// </summary>
	public readonly ulong BufferLocation {
		get => _bufferLocation;
		init => _bufferLocation = value;
	}
	readonly ulong _bufferLocation;

	/// <summary>
	/// <b>UINT SizeInBytes</b>
	/// </summary>
	public readonly uint SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly uint _sizeInBytes;

	/// <summary>
	/// <b>UINT StrideInBytes</b>
	/// </summary>
	public readonly uint StrideInBytes {
		get => _strideInBytes;
		init => _strideInBytes = value;
	}
	readonly uint _strideInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_INDEX_BUFFER_VIEW</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct IndexBufferView {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b>
	/// </summary>
	public readonly ulong BufferLocation {
		get => _bufferLocation;
		init => _bufferLocation = value;
	}
	readonly ulong _bufferLocation;

	/// <summary>
	/// <b>UINT SizeInBytes</b>
	/// </summary>
	public readonly uint SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly uint _sizeInBytes;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

}

/// <summary>
/// STRUCTURE <b>D3D12_INDIRECT_ARGUMENT_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct IndirectArgumentDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_50 {

		[StructLayout (LayoutKind.Sequential)]
		public unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_51 {

			public uint _slot;
		}

		[StructLayout (LayoutKind.Sequential)]
		public unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_52 {

			public uint _rootParameterIndex;
			public uint _destOffsetIn32BitValues;
			public uint _num32BitValuesToSet;
		}

		[StructLayout (LayoutKind.Sequential)]
		public unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_53 {

			public uint _rootParameterIndex;
		}

		[StructLayout (LayoutKind.Sequential)]
		public unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_54 {

			public uint _rootParameterIndex;
		}

		[StructLayout (LayoutKind.Sequential)]
		public unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_55 {

			public uint _rootParameterIndex;
		}

		[FieldOffset (0)] public _ASP_AUTO_GENERATED_STRUCTURE_51 _vertexBuffer;

		[FieldOffset (0)] public _ASP_AUTO_GENERATED_STRUCTURE_52 _constant;

		[FieldOffset (0)] public _ASP_AUTO_GENERATED_STRUCTURE_53 _constantBufferView;

		[FieldOffset (0)] public _ASP_AUTO_GENERATED_STRUCTURE_54 _shaderResourceView;

		[FieldOffset (0)] public _ASP_AUTO_GENERATED_STRUCTURE_55 _unorderedAccessView;

	}

	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_TYPE Type</b>
	/// </summary>
	public readonly IndirectArgumentType Type {
		get => _type;
		init => _type = value;
	}
	readonly IndirectArgumentType _type;

	/// <summary>
	/// <b>UINT Slot</b>
	/// </summary>
	public readonly uint VertexBufferSlot {
		get => __aSP_AUTO_GENERATED_FIELD_55._vertexBuffer._slot;
		init => __aSP_AUTO_GENERATED_FIELD_55._vertexBuffer._slot = value;
	}

	/// <summary>
	/// <b>UINT RootParameterIndex</b>
	/// </summary>
	public readonly uint ConstantRootParameterIndex {
		get => __aSP_AUTO_GENERATED_FIELD_55._constant._rootParameterIndex;
		init => __aSP_AUTO_GENERATED_FIELD_55._constant._rootParameterIndex = value;
	}

	/// <summary>
	/// <b>UINT DestOffsetIn32BitValues</b>
	/// </summary>
	public readonly uint ConstantDestOffsetIn32BitValues {
		get => __aSP_AUTO_GENERATED_FIELD_55._constant._destOffsetIn32BitValues;
		init => __aSP_AUTO_GENERATED_FIELD_55._constant._destOffsetIn32BitValues = value;
	}

	/// <summary>
	/// <b>UINT Num32BitValuesToSet</b>
	/// </summary>
	public readonly uint ConstantNum32BitValuesToSet {
		get => __aSP_AUTO_GENERATED_FIELD_55._constant._num32BitValuesToSet;
		init => __aSP_AUTO_GENERATED_FIELD_55._constant._num32BitValuesToSet = value;
	}

	/// <summary>
	/// <b>UINT RootParameterIndex</b>
	/// </summary>
	public readonly uint ConstantBufferViewRootParameterIndex {
		get => __aSP_AUTO_GENERATED_FIELD_55._constantBufferView._rootParameterIndex;
		init => __aSP_AUTO_GENERATED_FIELD_55._constantBufferView._rootParameterIndex = value;
	}

	/// <summary>
	/// <b>UINT RootParameterIndex</b>
	/// </summary>
	public readonly uint ShaderResourceViewRootParameterIndex {
		get => __aSP_AUTO_GENERATED_FIELD_55._shaderResourceView._rootParameterIndex;
		init => __aSP_AUTO_GENERATED_FIELD_55._shaderResourceView._rootParameterIndex = value;
	}

	/// <summary>
	/// <b>UINT RootParameterIndex</b>
	/// </summary>
	public readonly uint UnorderedAccessViewRootParameterIndex {
		get => __aSP_AUTO_GENERATED_FIELD_55._unorderedAccessView._rootParameterIndex;
		init => __aSP_AUTO_GENERATED_FIELD_55._unorderedAccessView._rootParameterIndex = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_50 __aSP_AUTO_GENERATED_FIELD_55;

}

/// <summary>
/// STRUCTURE <b>D3D12_COMMAND_SIGNATURE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CommandSignatureDesc {

	/// <summary>
	/// <b>UINT ByteStride</b>
	/// </summary>
	public readonly uint ByteStride {
		get => _byteStride;
		init => _byteStride = value;
	}
	readonly uint _byteStride;

	/// <summary>
	/// <b>UINT NumArgumentDescs</b>
	/// </summary>
	public readonly uint NumArgumentDescs {
		get => _numArgumentDescs;
		init => _numArgumentDescs = value;
	}
	readonly uint _numArgumentDescs;

	/// <summary>
	/// <b>D3D12_INDIRECT_ARGUMENT_DESC* pArgumentDescs</b>
	/// </summary>
	public readonly IndirectArgumentDesc* PArgumentDescs {
		get => _pArgumentDescs;
		init => _pArgumentDescs = value;
	}
	readonly IndirectArgumentDesc* _pArgumentDescs;

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

}

/// <summary>
/// STRUCTURE <b>D3D12_WRITEBUFFERIMMEDIATE_PARAMETER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct WritebufferimmediateParameter {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS Dest</b>
	/// </summary>
	public readonly ulong Dest {
		get => _dest;
		init => _dest = value;
	}
	readonly ulong _dest;

	/// <summary>
	/// <b>UINT32 Value</b>
	/// </summary>
	public readonly uint Value {
		get => _value;
		init => _value = value;
	}
	readonly uint _value;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataProtectedResourceSessionSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS Support</b>
	/// </summary>
	public readonly ProtectedResourceSessionSupportFlags Support {
		get => _support;
		init => _support = value;
	}
	readonly ProtectedResourceSessionSupportFlags _support;

}

/// <summary>
/// STRUCTURE <b>D3D12_PROTECTED_RESOURCE_SESSION_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ProtectedResourceSessionDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_PROTECTED_RESOURCE_SESSION_FLAGS Flags</b>
	/// </summary>
	public readonly ProtectedResourceSessionFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ProtectedResourceSessionFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_META_COMMAND_PARAMETER_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MetaCommandParameterDesc {

	/// <summary>
	/// <b>LPCWSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_TYPE Type</b>
	/// </summary>
	public readonly MetaCommandParameterType Type {
		get => _type;
		init => _type = value;
	}
	readonly MetaCommandParameterType _type;

	/// <summary>
	/// <b>D3D12_META_COMMAND_PARAMETER_FLAGS Flags</b>
	/// </summary>
	public readonly MetaCommandParameterFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly MetaCommandParameterFlags _flags;

	/// <summary>
	/// <b>D3D12_RESOURCE_STATES RequiredResourceState</b>
	/// </summary>
	public readonly ResourceStates RequiredResourceState {
		get => _requiredResourceState;
		init => _requiredResourceState = value;
	}
	readonly ResourceStates _requiredResourceState;

	/// <summary>
	/// <b>UINT StructureOffset</b>
	/// </summary>
	public readonly uint StructureOffset {
		get => _structureOffset;
		init => _structureOffset = value;
	}
	readonly uint _structureOffset;

}

/// <summary>
/// STRUCTURE <b>D3D12_META_COMMAND_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MetaCommandDesc {

	/// <summary>
	/// <b>GUID Id</b>
	/// </summary>
	public readonly Guid Id {
		get => _id;
		init => _id = value;
	}
	readonly Guid _id;

	/// <summary>
	/// <b>LPCWSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>D3D12_GRAPHICS_STATES InitializationDirtyState</b>
	/// </summary>
	public readonly GraphicsStates InitializationDirtyState {
		get => _initializationDirtyState;
		init => _initializationDirtyState = value;
	}
	readonly GraphicsStates _initializationDirtyState;

	/// <summary>
	/// <b>D3D12_GRAPHICS_STATES ExecutionDirtyState</b>
	/// </summary>
	public readonly GraphicsStates ExecutionDirtyState {
		get => _executionDirtyState;
		init => _executionDirtyState = value;
	}
	readonly GraphicsStates _executionDirtyState;

}

/// <summary>
/// STRUCTURE <b>D3D12_STATE_SUBOBJECT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StateSubobject {

	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT_TYPE Type</b>
	/// </summary>
	public readonly StateSubobjectType Type {
		get => _type;
		init => _type = value;
	}
	readonly StateSubobjectType _type;

	/// <summary>
	/// <b>void* pDesc</b>
	/// </summary>
	public readonly void* PDesc {
		get => _pDesc;
		init => _pDesc = value;
	}
	readonly void* _pDesc;

}

/// <summary>
/// STRUCTURE <b>D3D12_STATE_OBJECT_CONFIG</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StateObjectConfig {

	/// <summary>
	/// <b>D3D12_STATE_OBJECT_FLAGS Flags</b>
	/// </summary>
	public readonly StateObjectFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly StateObjectFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_GLOBAL_ROOT_SIGNATURE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GlobalRootSignature {

	/// <summary>
	/// <b>ID3D12RootSignature* pGlobalRootSignature</b>
	/// </summary>
	public readonly T* PGlobalRootSignature<T> () where T : unmanaged, IRootSignature => (T*) _pGlobalRootSignature;
	readonly void* _pGlobalRootSignature;

}

/// <summary>
/// STRUCTURE <b>D3D12_LOCAL_ROOT_SIGNATURE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LocalRootSignature {

	/// <summary>
	/// <b>ID3D12RootSignature* pLocalRootSignature</b>
	/// </summary>
	public readonly T* PLocalRootSignature<T> () where T : unmanaged, IRootSignature => (T*) _pLocalRootSignature;
	readonly void* _pLocalRootSignature;

}

/// <summary>
/// STRUCTURE <b>D3D12_NODE_MASK</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct NodeMask {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask_ {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

}

/// <summary>
/// STRUCTURE <b>D3D12_EXPORT_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ExportDesc {

	/// <summary>
	/// <b>LPCWSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>LPCWSTR ExportToRename</b>
	/// </summary>
	public readonly char* ExportToRename {
		get => _exportToRename;
		init => _exportToRename = value;
	}
	readonly char* _exportToRename;

	/// <summary>
	/// <b>D3D12_EXPORT_FLAGS Flags</b>
	/// </summary>
	public readonly ExportFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ExportFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_DXIL_LIBRARY_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DxilLibraryDesc {

	/// <summary>
	/// <b>D3D12_SHADER_BYTECODE DXILLibrary</b>
	/// </summary>
	public readonly ShaderBytecode DXILLibrary {
		get => _dXILLibrary;
		init => _dXILLibrary = value;
	}
	readonly ShaderBytecode _dXILLibrary;

	/// <summary>
	/// <b>UINT NumExports</b>
	/// </summary>
	public readonly uint NumExports {
		get => _numExports;
		init => _numExports = value;
	}
	readonly uint _numExports;

	/// <summary>
	/// <b>D3D12_EXPORT_DESC* pExports</b>
	/// </summary>
	public readonly ExportDesc* PExports {
		get => _pExports;
		init => _pExports = value;
	}
	readonly ExportDesc* _pExports;

}

/// <summary>
/// STRUCTURE <b>D3D12_EXISTING_COLLECTION_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ExistingCollectionDesc {

	/// <summary>
	/// <b>ID3D12StateObject* pExistingCollection</b>
	/// </summary>
	public readonly T* PExistingCollection<T> () where T : unmanaged, IStateObject => (T*) _pExistingCollection;
	readonly void* _pExistingCollection;

	/// <summary>
	/// <b>UINT NumExports</b>
	/// </summary>
	public readonly uint NumExports {
		get => _numExports;
		init => _numExports = value;
	}
	readonly uint _numExports;

	/// <summary>
	/// <b>D3D12_EXPORT_DESC* pExports</b>
	/// </summary>
	public readonly ExportDesc* PExports {
		get => _pExports;
		init => _pExports = value;
	}
	readonly ExportDesc* _pExports;

}

/// <summary>
/// STRUCTURE <b>D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SubobjectToExportsAssociation {

	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT* pSubobjectToAssociate</b>
	/// </summary>
	public readonly StateSubobject* PSubobjectToAssociate {
		get => _pSubobjectToAssociate;
		init => _pSubobjectToAssociate = value;
	}
	readonly StateSubobject* _pSubobjectToAssociate;

	/// <summary>
	/// <b>UINT NumExports</b>
	/// </summary>
	public readonly uint NumExports {
		get => _numExports;
		init => _numExports = value;
	}
	readonly uint _numExports;

	/// <summary>
	/// <b>LPCWSTR* pExports</b>
	/// </summary>
	public readonly char** PExports {
		get => _pExports;
		init => _pExports = value;
	}
	readonly char** _pExports;

}

/// <summary>
/// STRUCTURE <b>D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DxilSubobjectToExportsAssociation {

	/// <summary>
	/// <b>LPCWSTR SubobjectToAssociate</b>
	/// </summary>
	public readonly char* SubobjectToAssociate {
		get => _subobjectToAssociate;
		init => _subobjectToAssociate = value;
	}
	readonly char* _subobjectToAssociate;

	/// <summary>
	/// <b>UINT NumExports</b>
	/// </summary>
	public readonly uint NumExports {
		get => _numExports;
		init => _numExports = value;
	}
	readonly uint _numExports;

	/// <summary>
	/// <b>LPCWSTR* pExports</b>
	/// </summary>
	public readonly char** PExports {
		get => _pExports;
		init => _pExports = value;
	}
	readonly char** _pExports;

}

/// <summary>
/// STRUCTURE <b>D3D12_HIT_GROUP_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct HitGroupDesc {

	/// <summary>
	/// <b>LPCWSTR HitGroupExport</b>
	/// </summary>
	public readonly char* HitGroupExport {
		get => _hitGroupExport;
		init => _hitGroupExport = value;
	}
	readonly char* _hitGroupExport;

	/// <summary>
	/// <b>D3D12_HIT_GROUP_TYPE Type</b>
	/// </summary>
	public readonly HitGroupType Type {
		get => _type;
		init => _type = value;
	}
	readonly HitGroupType _type;

	/// <summary>
	/// <b>LPCWSTR AnyHitShaderImport</b>
	/// </summary>
	public readonly char* AnyHitShaderImport {
		get => _anyHitShaderImport;
		init => _anyHitShaderImport = value;
	}
	readonly char* _anyHitShaderImport;

	/// <summary>
	/// <b>LPCWSTR ClosestHitShaderImport</b>
	/// </summary>
	public readonly char* ClosestHitShaderImport {
		get => _closestHitShaderImport;
		init => _closestHitShaderImport = value;
	}
	readonly char* _closestHitShaderImport;

	/// <summary>
	/// <b>LPCWSTR IntersectionShaderImport</b>
	/// </summary>
	public readonly char* IntersectionShaderImport {
		get => _intersectionShaderImport;
		init => _intersectionShaderImport = value;
	}
	readonly char* _intersectionShaderImport;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_SHADER_CONFIG</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingShaderConfig {

	/// <summary>
	/// <b>UINT MaxPayloadSizeInBytes</b>
	/// </summary>
	public readonly uint MaxPayloadSizeInBytes {
		get => _maxPayloadSizeInBytes;
		init => _maxPayloadSizeInBytes = value;
	}
	readonly uint _maxPayloadSizeInBytes;

	/// <summary>
	/// <b>UINT MaxAttributeSizeInBytes</b>
	/// </summary>
	public readonly uint MaxAttributeSizeInBytes {
		get => _maxAttributeSizeInBytes;
		init => _maxAttributeSizeInBytes = value;
	}
	readonly uint _maxAttributeSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_PIPELINE_CONFIG</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingPipelineConfig {

	/// <summary>
	/// <b>UINT MaxTraceRecursionDepth</b>
	/// </summary>
	public readonly uint MaxTraceRecursionDepth {
		get => _maxTraceRecursionDepth;
		init => _maxTraceRecursionDepth = value;
	}
	readonly uint _maxTraceRecursionDepth;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_PIPELINE_CONFIG1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingPipelineConfig1 {

	/// <summary>
	/// <b>UINT MaxTraceRecursionDepth</b>
	/// </summary>
	public readonly uint MaxTraceRecursionDepth {
		get => _maxTraceRecursionDepth;
		init => _maxTraceRecursionDepth = value;
	}
	readonly uint _maxTraceRecursionDepth;

	/// <summary>
	/// <b>D3D12_RAYTRACING_PIPELINE_FLAGS Flags</b>
	/// </summary>
	public readonly RaytracingPipelineFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly RaytracingPipelineFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_STATE_OBJECT_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StateObjectDesc {

	/// <summary>
	/// <b>D3D12_STATE_OBJECT_TYPE Type</b>
	/// </summary>
	public readonly StateObjectType Type {
		get => _type;
		init => _type = value;
	}
	readonly StateObjectType _type;

	/// <summary>
	/// <b>UINT NumSubobjects</b>
	/// </summary>
	public readonly uint NumSubobjects {
		get => _numSubobjects;
		init => _numSubobjects = value;
	}
	readonly uint _numSubobjects;

	/// <summary>
	/// <b>D3D12_STATE_SUBOBJECT* pSubobjects</b>
	/// </summary>
	public readonly StateSubobject* PSubobjects {
		get => _pSubobjects;
		init => _pSubobjects = value;
	}
	readonly StateSubobject* _pSubobjects;

}

/// <summary>
/// STRUCTURE <b>D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GpuVirtualAddressAndStride {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS StartAddress</b>
	/// </summary>
	public readonly ulong StartAddress {
		get => _startAddress;
		init => _startAddress = value;
	}
	readonly ulong _startAddress;

	/// <summary>
	/// <b>UINT64 StrideInBytes</b>
	/// </summary>
	public readonly ulong StrideInBytes {
		get => _strideInBytes;
		init => _strideInBytes = value;
	}
	readonly ulong _strideInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_GPU_VIRTUAL_ADDRESS_RANGE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GpuVirtualAddressRange {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS StartAddress</b>
	/// </summary>
	public readonly ulong StartAddress {
		get => _startAddress;
		init => _startAddress = value;
	}
	readonly ulong _startAddress;

	/// <summary>
	/// <b>UINT64 SizeInBytes</b>
	/// </summary>
	public readonly ulong SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly ulong _sizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GpuVirtualAddressRangeAndStride {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS StartAddress</b>
	/// </summary>
	public readonly ulong StartAddress {
		get => _startAddress;
		init => _startAddress = value;
	}
	readonly ulong _startAddress;

	/// <summary>
	/// <b>UINT64 SizeInBytes</b>
	/// </summary>
	public readonly ulong SizeInBytes {
		get => _sizeInBytes;
		init => _sizeInBytes = value;
	}
	readonly ulong _sizeInBytes;

	/// <summary>
	/// <b>UINT64 StrideInBytes</b>
	/// </summary>
	public readonly ulong StrideInBytes {
		get => _strideInBytes;
		init => _strideInBytes = value;
	}
	readonly ulong _strideInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingGeometryTrianglesDesc {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS Transform3x4</b>
	/// </summary>
	public readonly ulong Transform3x4 {
		get => _transform3x4;
		init => _transform3x4 = value;
	}
	readonly ulong _transform3x4;

	/// <summary>
	/// <b>DXGI_FORMAT IndexFormat</b>
	/// </summary>
	public readonly DXGI.Format IndexFormat {
		get => _indexFormat;
		init => _indexFormat = value;
	}
	readonly DXGI.Format _indexFormat;

	/// <summary>
	/// <b>DXGI_FORMAT VertexFormat</b>
	/// </summary>
	public readonly DXGI.Format VertexFormat {
		get => _vertexFormat;
		init => _vertexFormat = value;
	}
	readonly DXGI.Format _vertexFormat;

	/// <summary>
	/// <b>UINT IndexCount</b>
	/// </summary>
	public readonly uint IndexCount {
		get => _indexCount;
		init => _indexCount = value;
	}
	readonly uint _indexCount;

	/// <summary>
	/// <b>UINT VertexCount</b>
	/// </summary>
	public readonly uint VertexCount {
		get => _vertexCount;
		init => _vertexCount = value;
	}
	readonly uint _vertexCount;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS IndexBuffer</b>
	/// </summary>
	public readonly ulong IndexBuffer {
		get => _indexBuffer;
		init => _indexBuffer = value;
	}
	readonly ulong _indexBuffer;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE VertexBuffer</b>
	/// </summary>
	public readonly GpuVirtualAddressAndStride VertexBuffer {
		get => _vertexBuffer;
		init => _vertexBuffer = value;
	}
	readonly GpuVirtualAddressAndStride _vertexBuffer;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_AABB</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAabb {

	/// <summary>
	/// <b>FLOAT MinX</b>
	/// </summary>
	public readonly float MinX {
		get => _minX;
		init => _minX = value;
	}
	readonly float _minX;

	/// <summary>
	/// <b>FLOAT MinY</b>
	/// </summary>
	public readonly float MinY {
		get => _minY;
		init => _minY = value;
	}
	readonly float _minY;

	/// <summary>
	/// <b>FLOAT MinZ</b>
	/// </summary>
	public readonly float MinZ {
		get => _minZ;
		init => _minZ = value;
	}
	readonly float _minZ;

	/// <summary>
	/// <b>FLOAT MaxX</b>
	/// </summary>
	public readonly float MaxX {
		get => _maxX;
		init => _maxX = value;
	}
	readonly float _maxX;

	/// <summary>
	/// <b>FLOAT MaxY</b>
	/// </summary>
	public readonly float MaxY {
		get => _maxY;
		init => _maxY = value;
	}
	readonly float _maxY;

	/// <summary>
	/// <b>FLOAT MaxZ</b>
	/// </summary>
	public readonly float MaxZ {
		get => _maxZ;
		init => _maxZ = value;
	}
	readonly float _maxZ;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_GEOMETRY_AABBS_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingGeometryAabbsDesc {

	/// <summary>
	/// <b>UINT64 AABBCount</b>
	/// </summary>
	public readonly ulong AABBCount {
		get => _aABBCount;
		init => _aABBCount = value;
	}
	readonly ulong _aABBCount;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE AABBs</b>
	/// </summary>
	public readonly GpuVirtualAddressAndStride AABBs {
		get => _aABBs;
		init => _aABBs = value;
	}
	readonly GpuVirtualAddressAndStride _aABBs;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAccelerationStructurePostbuildInfoDesc {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS DestBuffer</b>
	/// </summary>
	public readonly ulong DestBuffer {
		get => _destBuffer;
		init => _destBuffer = value;
	}
	readonly ulong _destBuffer;

	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TYPE InfoType</b>
	/// </summary>
	public readonly RaytracingAccelerationStructurePostbuildInfoType InfoType {
		get => _infoType;
		init => _infoType = value;
	}
	readonly RaytracingAccelerationStructurePostbuildInfoType _infoType;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAccelerationStructurePostbuildInfoCompactedSizeDesc {

	/// <summary>
	/// <b>UINT64 CompactedSizeInBytes</b>
	/// </summary>
	public readonly ulong CompactedSizeInBytes {
		get => _compactedSizeInBytes;
		init => _compactedSizeInBytes = value;
	}
	readonly ulong _compactedSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAccelerationStructurePostbuildInfoToolsVisualizationDesc {

	/// <summary>
	/// <b>UINT64 DecodedSizeInBytes</b>
	/// </summary>
	public readonly ulong DecodedSizeInBytes {
		get => _decodedSizeInBytes;
		init => _decodedSizeInBytes = value;
	}
	readonly ulong _decodedSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_TOOLS_VISUALIZATION_HEADER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BuildRaytracingAccelerationStructureToolsVisualizationHeader {

	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type</b>
	/// </summary>
	public readonly RaytracingAccelerationStructureType Type {
		get => _type;
		init => _type = value;
	}
	readonly RaytracingAccelerationStructureType _type;

	/// <summary>
	/// <b>UINT NumDescs</b>
	/// </summary>
	public readonly uint NumDescs {
		get => _numDescs;
		init => _numDescs = value;
	}
	readonly uint _numDescs;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAccelerationStructurePostbuildInfoSerializationDesc {

	/// <summary>
	/// <b>UINT64 SerializedSizeInBytes</b>
	/// </summary>
	public readonly ulong SerializedSizeInBytes {
		get => _serializedSizeInBytes;
		init => _serializedSizeInBytes = value;
	}
	readonly ulong _serializedSizeInBytes;

	/// <summary>
	/// <b>UINT64 NumBottomLevelAccelerationStructurePointers</b>
	/// </summary>
	public readonly ulong NumBottomLevelAccelerationStructurePointers {
		get => _numBottomLevelAccelerationStructurePointers;
		init => _numBottomLevelAccelerationStructurePointers = value;
	}
	readonly ulong _numBottomLevelAccelerationStructurePointers;

}

/// <summary>
/// STRUCTURE <b>D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SerializedDataDriverMatchingIdentifier {

	/// <summary>
	/// <b>GUID DriverOpaqueGUID</b>
	/// </summary>
	public readonly Guid DriverOpaqueGUID {
		get => _driverOpaqueGUID;
		init => _driverOpaqueGUID = value;
	}
	readonly Guid _driverOpaqueGUID;

	/// <summary>
	/// <b>BYTE DriverOpaqueVersioningData [16]</b>
	/// </summary>
	public readonly Span<byte> DriverOpaqueVersioningData {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _driverOpaqueVersioningData)), 16);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_126 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [16];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_126 _driverOpaqueVersioningData;

}

/// <summary>
/// STRUCTURE <b>D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SerializedRaytracingAccelerationStructureHeader {

	/// <summary>
	/// <b>D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER DriverMatchingIdentifier</b>
	/// </summary>
	public readonly SerializedDataDriverMatchingIdentifier DriverMatchingIdentifier {
		get => _driverMatchingIdentifier;
		init => _driverMatchingIdentifier = value;
	}
	readonly SerializedDataDriverMatchingIdentifier _driverMatchingIdentifier;

	/// <summary>
	/// <b>UINT64 SerializedSizeInBytesIncludingHeader</b>
	/// </summary>
	public readonly ulong SerializedSizeInBytesIncludingHeader {
		get => _serializedSizeInBytesIncludingHeader;
		init => _serializedSizeInBytesIncludingHeader = value;
	}
	readonly ulong _serializedSizeInBytesIncludingHeader;

	/// <summary>
	/// <b>UINT64 DeserializedSizeInBytes</b>
	/// </summary>
	public readonly ulong DeserializedSizeInBytes {
		get => _deserializedSizeInBytes;
		init => _deserializedSizeInBytes = value;
	}
	readonly ulong _deserializedSizeInBytes;

	/// <summary>
	/// <b>UINT64 NumBottomLevelAccelerationStructurePointersAfterHeader</b>
	/// </summary>
	public readonly ulong NumBottomLevelAccelerationStructurePointersAfterHeader {
		get => _numBottomLevelAccelerationStructurePointersAfterHeader;
		init => _numBottomLevelAccelerationStructurePointersAfterHeader = value;
	}
	readonly ulong _numBottomLevelAccelerationStructurePointersAfterHeader;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_CURRENT_SIZE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAccelerationStructurePostbuildInfoCurrentSizeDesc {

	/// <summary>
	/// <b>UINT64 CurrentSizeInBytes</b>
	/// </summary>
	public readonly ulong CurrentSizeInBytes {
		get => _currentSizeInBytes;
		init => _currentSizeInBytes = value;
	}
	readonly ulong _currentSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_INSTANCE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingInstanceDesc {

	/// <summary>
	/// <b>FLOAT Transform [3][4]</b>
	/// </summary>
	public readonly Span<float> Transform {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _transform)), 3 * 4);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_127 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [3 * 4];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_127 _transform;

	/// <summary>
	/// <b>UINT InstanceID : 24</b>
	/// </summary>
	public readonly uint InstanceID {
		get => (uint) ((_ASP_AUTO_GENERATED_FIELD_128 << 0) >>> 40);
		init => _ASP_AUTO_GENERATED_FIELD_128 = (uint) (((value & 0b111111111111111111111111) << 40) + (_ASP_AUTO_GENERATED_FIELD_128 & 0b0000000000000000000000001111111111111111111111111111111111111111));
	}

	/// <summary>
	/// <b>UINT InstanceMask : 8</b>
	/// </summary>
	public readonly uint InstanceMask {
		get => (uint) ((_ASP_AUTO_GENERATED_FIELD_128 << 24) >>> 56);
		init => _ASP_AUTO_GENERATED_FIELD_128 = (uint) (((value & 0b11111111) << 32) + (_ASP_AUTO_GENERATED_FIELD_128 & 0b1111111111111111111111110000000011111111111111111111111111111111));
	}

	/// <summary>
	/// <b>UINT InstanceContributionToHitGroupIndex : 24</b>
	/// </summary>
	public readonly uint InstanceContributionToHitGroupIndex {
		get => (uint) ((_ASP_AUTO_GENERATED_FIELD_128 << 32) >>> 40);
		init => _ASP_AUTO_GENERATED_FIELD_128 = (uint) (((value & 0b111111111111111111111111) << 8) + (_ASP_AUTO_GENERATED_FIELD_128 & 0b1111111111111111111111111111111100000000000000000000000011111111));
	}

	/// <summary>
	/// <b>UINT Flags : 8</b>
	/// </summary>
	public readonly uint Flags {
		get => (uint) ((_ASP_AUTO_GENERATED_FIELD_128 << 56) >>> 56);
		init => _ASP_AUTO_GENERATED_FIELD_128 = (uint) (((value & 0b11111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_128 & 0b1111111111111111111111111111111111111111111111111111111100000000));
	}

	readonly ulong _ASP_AUTO_GENERATED_FIELD_128;
	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS AccelerationStructure</b>
	/// </summary>
	public readonly ulong AccelerationStructure {
		get => _accelerationStructure;
		init => _accelerationStructure = value;
	}
	readonly ulong _accelerationStructure;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_GEOMETRY_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingGeometryDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_57 {

		[FieldOffset (0)] public RaytracingGeometryTrianglesDesc _triangles;
		[FieldOffset (0)] public RaytracingGeometryAabbsDesc _aABBs;
	}

	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_TYPE Type</b>
	/// </summary>
	public readonly RaytracingGeometryType Type {
		get => _type;
		init => _type = value;
	}
	readonly RaytracingGeometryType _type;

	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_FLAGS Flags</b>
	/// </summary>
	public readonly RaytracingGeometryFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly RaytracingGeometryFlags _flags;

	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles</b>
	/// </summary>
	public readonly RaytracingGeometryTrianglesDesc Triangles {
		get => __aSP_AUTO_GENERATED_FIELD_57._triangles;
		init => __aSP_AUTO_GENERATED_FIELD_57._triangles = value;
	}

	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs</b>
	/// </summary>
	public readonly RaytracingGeometryAabbsDesc AABBs {
		get => __aSP_AUTO_GENERATED_FIELD_57._aABBs;
		init => __aSP_AUTO_GENERATED_FIELD_57._aABBs = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_57 __aSP_AUTO_GENERATED_FIELD_57;

}

/// <summary>
/// STRUCTURE <b>D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BuildRaytracingAccelerationStructureInputs {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_59 {

		[FieldOffset (0)] public ulong _instanceDescs;
		[FieldOffset (0)] public RaytracingGeometryDesc* _pGeometryDescs;
		[FieldOffset (0)] public RaytracingGeometryDesc* _ppGeometryDescs;
	}

	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type</b>
	/// </summary>
	public readonly RaytracingAccelerationStructureType Type {
		get => _type;
		init => _type = value;
	}
	readonly RaytracingAccelerationStructureType _type;

	/// <summary>
	/// <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags</b>
	/// </summary>
	public readonly RaytracingAccelerationStructureBuildFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly RaytracingAccelerationStructureBuildFlags _flags;

	/// <summary>
	/// <b>UINT NumDescs</b>
	/// </summary>
	public readonly uint NumDescs {
		get => _numDescs;
		init => _numDescs = value;
	}
	readonly uint _numDescs;

	/// <summary>
	/// <b>D3D12_ELEMENTS_LAYOUT DescsLayout</b>
	/// </summary>
	public readonly ElementsLayout DescsLayout {
		get => _descsLayout;
		init => _descsLayout = value;
	}
	readonly ElementsLayout _descsLayout;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS InstanceDescs</b>
	/// </summary>
	public readonly ulong InstanceDescs {
		get => __aSP_AUTO_GENERATED_FIELD_59._instanceDescs;
		init => __aSP_AUTO_GENERATED_FIELD_59._instanceDescs = value;
	}

	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_DESC* pGeometryDescs</b>
	/// </summary>
	public readonly RaytracingGeometryDesc* PGeometryDescs {
		get => __aSP_AUTO_GENERATED_FIELD_59._pGeometryDescs;
		init => __aSP_AUTO_GENERATED_FIELD_59._pGeometryDescs = value;
	}

	/// <summary>
	/// <b>D3D12_RAYTRACING_GEOMETRY_DESC* ppGeometryDescs</b>
	/// </summary>
	public readonly RaytracingGeometryDesc* PpGeometryDescs {
		get => __aSP_AUTO_GENERATED_FIELD_59._ppGeometryDescs;
		init => __aSP_AUTO_GENERATED_FIELD_59._ppGeometryDescs = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_59 __aSP_AUTO_GENERATED_FIELD_59;

}

/// <summary>
/// STRUCTURE <b>D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BuildRaytracingAccelerationStructureDesc {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS DestAccelerationStructureData</b>
	/// </summary>
	public readonly ulong DestAccelerationStructureData {
		get => _destAccelerationStructureData;
		init => _destAccelerationStructureData = value;
	}
	readonly ulong _destAccelerationStructureData;

	/// <summary>
	/// <b>D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS Inputs</b>
	/// </summary>
	public readonly BuildRaytracingAccelerationStructureInputs Inputs {
		get => _inputs;
		init => _inputs = value;
	}
	readonly BuildRaytracingAccelerationStructureInputs _inputs;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS SourceAccelerationStructureData</b>
	/// </summary>
	public readonly ulong SourceAccelerationStructureData {
		get => _sourceAccelerationStructureData;
		init => _sourceAccelerationStructureData = value;
	}
	readonly ulong _sourceAccelerationStructureData;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS ScratchAccelerationStructureData</b>
	/// </summary>
	public readonly ulong ScratchAccelerationStructureData {
		get => _scratchAccelerationStructureData;
		init => _scratchAccelerationStructureData = value;
	}
	readonly ulong _scratchAccelerationStructureData;

}

/// <summary>
/// STRUCTURE <b>D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RaytracingAccelerationStructurePrebuildInfo {

	/// <summary>
	/// <b>UINT64 ResultDataMaxSizeInBytes</b>
	/// </summary>
	public readonly ulong ResultDataMaxSizeInBytes {
		get => _resultDataMaxSizeInBytes;
		init => _resultDataMaxSizeInBytes = value;
	}
	readonly ulong _resultDataMaxSizeInBytes;

	/// <summary>
	/// <b>UINT64 ScratchDataSizeInBytes</b>
	/// </summary>
	public readonly ulong ScratchDataSizeInBytes {
		get => _scratchDataSizeInBytes;
		init => _scratchDataSizeInBytes = value;
	}
	readonly ulong _scratchDataSizeInBytes;

	/// <summary>
	/// <b>UINT64 UpdateScratchDataSizeInBytes</b>
	/// </summary>
	public readonly ulong UpdateScratchDataSizeInBytes {
		get => _updateScratchDataSizeInBytes;
		init => _updateScratchDataSizeInBytes = value;
	}
	readonly ulong _updateScratchDataSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_AUTO_BREADCRUMB_NODE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AutoBreadcrumbNode {

	/// <summary>
	/// <b>char* pCommandListDebugNameA</b>
	/// </summary>
	public readonly char* PCommandListDebugNameA {
		get => _pCommandListDebugNameA;
		init => _pCommandListDebugNameA = value;
	}
	readonly char* _pCommandListDebugNameA;

	/// <summary>
	/// <b>wchar_t* pCommandListDebugNameW</b>
	/// </summary>
	public readonly char* PCommandListDebugNameW {
		get => _pCommandListDebugNameW;
		init => _pCommandListDebugNameW = value;
	}
	readonly char* _pCommandListDebugNameW;

	/// <summary>
	/// <b>char* pCommandQueueDebugNameA</b>
	/// </summary>
	public readonly char* PCommandQueueDebugNameA {
		get => _pCommandQueueDebugNameA;
		init => _pCommandQueueDebugNameA = value;
	}
	readonly char* _pCommandQueueDebugNameA;

	/// <summary>
	/// <b>wchar_t* pCommandQueueDebugNameW</b>
	/// </summary>
	public readonly char* PCommandQueueDebugNameW {
		get => _pCommandQueueDebugNameW;
		init => _pCommandQueueDebugNameW = value;
	}
	readonly char* _pCommandQueueDebugNameW;

	/// <summary>
	/// <b>ID3D12GraphicsCommandList* pCommandList</b>
	/// </summary>
	public readonly T* PCommandList<T> () where T : unmanaged, IGraphicsCommandList => (T*) _pCommandList;
	readonly void* _pCommandList;

	/// <summary>
	/// <b>ID3D12CommandQueue* pCommandQueue</b>
	/// </summary>
	public readonly T* PCommandQueue<T> () where T : unmanaged, ICommandQueue => (T*) _pCommandQueue;
	readonly void* _pCommandQueue;

	/// <summary>
	/// <b>UINT32 BreadcrumbCount</b>
	/// </summary>
	public readonly uint BreadcrumbCount {
		get => _breadcrumbCount;
		init => _breadcrumbCount = value;
	}
	readonly uint _breadcrumbCount;

	/// <summary>
	/// <b>UINT32* pLastBreadcrumbValue</b>
	/// </summary>
	public readonly uint* PLastBreadcrumbValue {
		get => _pLastBreadcrumbValue;
		init => _pLastBreadcrumbValue = value;
	}
	readonly uint* _pLastBreadcrumbValue;

	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP* pCommandHistory</b>
	/// </summary>
	public readonly AutoBreadcrumbOp* PCommandHistory {
		get => _pCommandHistory;
		init => _pCommandHistory = value;
	}
	readonly AutoBreadcrumbOp* _pCommandHistory;

	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_NODE* pNext</b>
	/// </summary>
	public readonly AutoBreadcrumbNode* PNext {
		get => _pNext;
		init => _pNext = value;
	}
	readonly AutoBreadcrumbNode* _pNext;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_BREADCRUMB_CONTEXT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredBreadcrumbContext {

	/// <summary>
	/// <b>UINT BreadcrumbIndex</b>
	/// </summary>
	public readonly uint BreadcrumbIndex {
		get => _breadcrumbIndex;
		init => _breadcrumbIndex = value;
	}
	readonly uint _breadcrumbIndex;

	/// <summary>
	/// <b>wchar_t* pContextString</b>
	/// </summary>
	public readonly char* PContextString {
		get => _pContextString;
		init => _pContextString = value;
	}
	readonly char* _pContextString;

}

/// <summary>
/// STRUCTURE <b>D3D12_AUTO_BREADCRUMB_NODE1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AutoBreadcrumbNode1 {

	/// <summary>
	/// <b>char* pCommandListDebugNameA</b>
	/// </summary>
	public readonly char* PCommandListDebugNameA {
		get => _pCommandListDebugNameA;
		init => _pCommandListDebugNameA = value;
	}
	readonly char* _pCommandListDebugNameA;

	/// <summary>
	/// <b>wchar_t* pCommandListDebugNameW</b>
	/// </summary>
	public readonly char* PCommandListDebugNameW {
		get => _pCommandListDebugNameW;
		init => _pCommandListDebugNameW = value;
	}
	readonly char* _pCommandListDebugNameW;

	/// <summary>
	/// <b>char* pCommandQueueDebugNameA</b>
	/// </summary>
	public readonly char* PCommandQueueDebugNameA {
		get => _pCommandQueueDebugNameA;
		init => _pCommandQueueDebugNameA = value;
	}
	readonly char* _pCommandQueueDebugNameA;

	/// <summary>
	/// <b>wchar_t* pCommandQueueDebugNameW</b>
	/// </summary>
	public readonly char* PCommandQueueDebugNameW {
		get => _pCommandQueueDebugNameW;
		init => _pCommandQueueDebugNameW = value;
	}
	readonly char* _pCommandQueueDebugNameW;

	/// <summary>
	/// <b>ID3D12GraphicsCommandList* pCommandList</b>
	/// </summary>
	public readonly T* PCommandList<T> () where T : unmanaged, IGraphicsCommandList => (T*) _pCommandList;
	readonly void* _pCommandList;

	/// <summary>
	/// <b>ID3D12CommandQueue* pCommandQueue</b>
	/// </summary>
	public readonly T* PCommandQueue<T> () where T : unmanaged, ICommandQueue => (T*) _pCommandQueue;
	readonly void* _pCommandQueue;

	/// <summary>
	/// <b>UINT BreadcrumbCount</b>
	/// </summary>
	public readonly uint BreadcrumbCount {
		get => _breadcrumbCount;
		init => _breadcrumbCount = value;
	}
	readonly uint _breadcrumbCount;

	/// <summary>
	/// <b>UINT* pLastBreadcrumbValue</b>
	/// </summary>
	public readonly uint* PLastBreadcrumbValue {
		get => _pLastBreadcrumbValue;
		init => _pLastBreadcrumbValue = value;
	}
	readonly uint* _pLastBreadcrumbValue;

	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_OP* pCommandHistory</b>
	/// </summary>
	public readonly AutoBreadcrumbOp* PCommandHistory {
		get => _pCommandHistory;
		init => _pCommandHistory = value;
	}
	readonly AutoBreadcrumbOp* _pCommandHistory;

	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_NODE1* pNext</b>
	/// </summary>
	public readonly AutoBreadcrumbNode1* PNext {
		get => _pNext;
		init => _pNext = value;
	}
	readonly AutoBreadcrumbNode1* _pNext;

	/// <summary>
	/// <b>UINT BreadcrumbContextsCount</b>
	/// </summary>
	public readonly uint BreadcrumbContextsCount {
		get => _breadcrumbContextsCount;
		init => _breadcrumbContextsCount = value;
	}
	readonly uint _breadcrumbContextsCount;

	/// <summary>
	/// <b>D3D12_DRED_BREADCRUMB_CONTEXT* pBreadcrumbContexts</b>
	/// </summary>
	public readonly DredBreadcrumbContext* PBreadcrumbContexts {
		get => _pBreadcrumbContexts;
		init => _pBreadcrumbContexts = value;
	}
	readonly DredBreadcrumbContext* _pBreadcrumbContexts;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DeviceRemovedExtendedDataStructure {

	/// <summary>
	/// <b>D3D12_DRED_FLAGS Flags</b>
	/// </summary>
	public readonly DredFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly DredFlags _flags;

	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_NODE* pHeadAutoBreadcrumbNode</b>
	/// </summary>
	public readonly AutoBreadcrumbNode* PHeadAutoBreadcrumbNode {
		get => _pHeadAutoBreadcrumbNode;
		init => _pHeadAutoBreadcrumbNode = value;
	}
	readonly AutoBreadcrumbNode* _pHeadAutoBreadcrumbNode;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_ALLOCATION_NODE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredAllocationNode {

	/// <summary>
	/// <b>char* ObjectNameA</b>
	/// </summary>
	public readonly char* ObjectNameA {
		get => _objectNameA;
		init => _objectNameA = value;
	}
	readonly char* _objectNameA;

	/// <summary>
	/// <b>wchar_t* ObjectNameW</b>
	/// </summary>
	public readonly char* ObjectNameW {
		get => _objectNameW;
		init => _objectNameW = value;
	}
	readonly char* _objectNameW;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE AllocationType</b>
	/// </summary>
	public readonly DredAllocationType AllocationType {
		get => _allocationType;
		init => _allocationType = value;
	}
	readonly DredAllocationType _allocationType;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE* pNext</b>
	/// </summary>
	public readonly DredAllocationNode* PNext {
		get => _pNext;
		init => _pNext = value;
	}
	readonly DredAllocationNode* _pNext;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_ALLOCATION_NODE1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredAllocationNode1 {

	/// <summary>
	/// <b>char* ObjectNameA</b>
	/// </summary>
	public readonly char* ObjectNameA {
		get => _objectNameA;
		init => _objectNameA = value;
	}
	readonly char* _objectNameA;

	/// <summary>
	/// <b>wchar_t* ObjectNameW</b>
	/// </summary>
	public readonly char* ObjectNameW {
		get => _objectNameW;
		init => _objectNameW = value;
	}
	readonly char* _objectNameW;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_TYPE AllocationType</b>
	/// </summary>
	public readonly DredAllocationType AllocationType {
		get => _allocationType;
		init => _allocationType = value;
	}
	readonly DredAllocationType _allocationType;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE1* pNext</b>
	/// </summary>
	public readonly DredAllocationNode1* PNext {
		get => _pNext;
		init => _pNext = value;
	}
	readonly DredAllocationNode1* _pNext;

	/// <summary>
	/// <b>IUnknown* pObject</b>
	/// </summary>
	public readonly T* PObject<T> () where T : unmanaged, IUnknown => (T*) _pObject;
	readonly void* _pObject;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredAutoBreadcrumbsOutput {

	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_NODE* pHeadAutoBreadcrumbNode</b>
	/// </summary>
	public readonly AutoBreadcrumbNode* PHeadAutoBreadcrumbNode {
		get => _pHeadAutoBreadcrumbNode;
		init => _pHeadAutoBreadcrumbNode = value;
	}
	readonly AutoBreadcrumbNode* _pHeadAutoBreadcrumbNode;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredAutoBreadcrumbsOutput1 {

	/// <summary>
	/// <b>D3D12_AUTO_BREADCRUMB_NODE1* pHeadAutoBreadcrumbNode</b>
	/// </summary>
	public readonly AutoBreadcrumbNode1* PHeadAutoBreadcrumbNode {
		get => _pHeadAutoBreadcrumbNode;
		init => _pHeadAutoBreadcrumbNode = value;
	}
	readonly AutoBreadcrumbNode1* _pHeadAutoBreadcrumbNode;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_PAGE_FAULT_OUTPUT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredPageFaultOutput {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS PageFaultVA</b>
	/// </summary>
	public readonly ulong PageFaultVA {
		get => _pageFaultVA;
		init => _pageFaultVA = value;
	}
	readonly ulong _pageFaultVA;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE* pHeadExistingAllocationNode</b>
	/// </summary>
	public readonly DredAllocationNode* PHeadExistingAllocationNode {
		get => _pHeadExistingAllocationNode;
		init => _pHeadExistingAllocationNode = value;
	}
	readonly DredAllocationNode* _pHeadExistingAllocationNode;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE* pHeadRecentFreedAllocationNode</b>
	/// </summary>
	public readonly DredAllocationNode* PHeadRecentFreedAllocationNode {
		get => _pHeadRecentFreedAllocationNode;
		init => _pHeadRecentFreedAllocationNode = value;
	}
	readonly DredAllocationNode* _pHeadRecentFreedAllocationNode;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_PAGE_FAULT_OUTPUT1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredPageFaultOutput1 {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS PageFaultVA</b>
	/// </summary>
	public readonly ulong PageFaultVA {
		get => _pageFaultVA;
		init => _pageFaultVA = value;
	}
	readonly ulong _pageFaultVA;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE1* pHeadExistingAllocationNode</b>
	/// </summary>
	public readonly DredAllocationNode1* PHeadExistingAllocationNode {
		get => _pHeadExistingAllocationNode;
		init => _pHeadExistingAllocationNode = value;
	}
	readonly DredAllocationNode1* _pHeadExistingAllocationNode;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE1* pHeadRecentFreedAllocationNode</b>
	/// </summary>
	public readonly DredAllocationNode1* PHeadRecentFreedAllocationNode {
		get => _pHeadRecentFreedAllocationNode;
		init => _pHeadRecentFreedAllocationNode = value;
	}
	readonly DredAllocationNode1* _pHeadRecentFreedAllocationNode;

}

/// <summary>
/// STRUCTURE <b>D3D12_DRED_PAGE_FAULT_OUTPUT2</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DredPageFaultOutput2 {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS PageFaultVA</b>
	/// </summary>
	public readonly ulong PageFaultVA {
		get => _pageFaultVA;
		init => _pageFaultVA = value;
	}
	readonly ulong _pageFaultVA;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE1* pHeadExistingAllocationNode</b>
	/// </summary>
	public readonly DredAllocationNode1* PHeadExistingAllocationNode {
		get => _pHeadExistingAllocationNode;
		init => _pHeadExistingAllocationNode = value;
	}
	readonly DredAllocationNode1* _pHeadExistingAllocationNode;

	/// <summary>
	/// <b>D3D12_DRED_ALLOCATION_NODE1* pHeadRecentFreedAllocationNode</b>
	/// </summary>
	public readonly DredAllocationNode1* PHeadRecentFreedAllocationNode {
		get => _pHeadRecentFreedAllocationNode;
		init => _pHeadRecentFreedAllocationNode = value;
	}
	readonly DredAllocationNode1* _pHeadRecentFreedAllocationNode;

	/// <summary>
	/// <b>D3D12_DRED_PAGE_FAULT_FLAGS PageFaultFlags</b>
	/// </summary>
	public readonly DredPageFaultFlags PageFaultFlags {
		get => _pageFaultFlags;
		init => _pageFaultFlags = value;
	}
	readonly DredPageFaultFlags _pageFaultFlags;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DeviceRemovedExtendedData1Structure {

	/// <summary>
	/// <b>HRESULT DeviceRemovedReason</b>
	/// </summary>
	public readonly int DeviceRemovedReason {
		get => _deviceRemovedReason;
		init => _deviceRemovedReason = value;
	}
	readonly int _deviceRemovedReason;

	/// <summary>
	/// <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT AutoBreadcrumbsOutput</b>
	/// </summary>
	public readonly DredAutoBreadcrumbsOutput AutoBreadcrumbsOutput {
		get => _autoBreadcrumbsOutput;
		init => _autoBreadcrumbsOutput = value;
	}
	readonly DredAutoBreadcrumbsOutput _autoBreadcrumbsOutput;

	/// <summary>
	/// <b>D3D12_DRED_PAGE_FAULT_OUTPUT PageFaultOutput</b>
	/// </summary>
	public readonly DredPageFaultOutput PageFaultOutput {
		get => _pageFaultOutput;
		init => _pageFaultOutput = value;
	}
	readonly DredPageFaultOutput _pageFaultOutput;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA2</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DeviceRemovedExtendedData2Structure {

	/// <summary>
	/// <b>HRESULT DeviceRemovedReason</b>
	/// </summary>
	public readonly int DeviceRemovedReason {
		get => _deviceRemovedReason;
		init => _deviceRemovedReason = value;
	}
	readonly int _deviceRemovedReason;

	/// <summary>
	/// <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 AutoBreadcrumbsOutput</b>
	/// </summary>
	public readonly DredAutoBreadcrumbsOutput1 AutoBreadcrumbsOutput {
		get => _autoBreadcrumbsOutput;
		init => _autoBreadcrumbsOutput = value;
	}
	readonly DredAutoBreadcrumbsOutput1 _autoBreadcrumbsOutput;

	/// <summary>
	/// <b>D3D12_DRED_PAGE_FAULT_OUTPUT1 PageFaultOutput</b>
	/// </summary>
	public readonly DredPageFaultOutput1 PageFaultOutput {
		get => _pageFaultOutput;
		init => _pageFaultOutput = value;
	}
	readonly DredPageFaultOutput1 _pageFaultOutput;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA3</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DeviceRemovedExtendedData3Structure {

	/// <summary>
	/// <b>HRESULT DeviceRemovedReason</b>
	/// </summary>
	public readonly int DeviceRemovedReason {
		get => _deviceRemovedReason;
		init => _deviceRemovedReason = value;
	}
	readonly int _deviceRemovedReason;

	/// <summary>
	/// <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 AutoBreadcrumbsOutput</b>
	/// </summary>
	public readonly DredAutoBreadcrumbsOutput1 AutoBreadcrumbsOutput {
		get => _autoBreadcrumbsOutput;
		init => _autoBreadcrumbsOutput = value;
	}
	readonly DredAutoBreadcrumbsOutput1 _autoBreadcrumbsOutput;

	/// <summary>
	/// <b>D3D12_DRED_PAGE_FAULT_OUTPUT2 PageFaultOutput</b>
	/// </summary>
	public readonly DredPageFaultOutput2 PageFaultOutput {
		get => _pageFaultOutput;
		init => _pageFaultOutput = value;
	}
	readonly DredPageFaultOutput2 _pageFaultOutput;

	/// <summary>
	/// <b>D3D12_DRED_DEVICE_STATE DeviceState</b>
	/// </summary>
	public readonly DredDeviceState DeviceState {
		get => _deviceState;
		init => _deviceState = value;
	}
	readonly DredDeviceState _deviceState;

}

/// <summary>
/// STRUCTURE <b>D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VersionedDeviceRemovedExtendedData {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_61 {

		[FieldOffset (0)] public DeviceRemovedExtendedDataStructure _dred_1_0;
		[FieldOffset (0)] public DeviceRemovedExtendedData1Structure _dred_1_1;
		[FieldOffset (0)] public DeviceRemovedExtendedData2Structure _dred_1_2;
		[FieldOffset (0)] public DeviceRemovedExtendedData3Structure _dred_1_3;
	}

	/// <summary>
	/// <b>D3D12_DRED_VERSION Version</b>
	/// </summary>
	public readonly DredVersion Version {
		get => _version;
		init => _version = value;
	}
	readonly DredVersion _version;

	/// <summary>
	/// <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA Dred_1_0</b>
	/// </summary>
	public readonly DeviceRemovedExtendedDataStructure Dred_1_0 {
		get => __aSP_AUTO_GENERATED_FIELD_61._dred_1_0;
		init => __aSP_AUTO_GENERATED_FIELD_61._dred_1_0 = value;
	}

	/// <summary>
	/// <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA1 Dred_1_1</b>
	/// </summary>
	public readonly DeviceRemovedExtendedData1Structure Dred_1_1 {
		get => __aSP_AUTO_GENERATED_FIELD_61._dred_1_1;
		init => __aSP_AUTO_GENERATED_FIELD_61._dred_1_1 = value;
	}

	/// <summary>
	/// <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA2 Dred_1_2</b>
	/// </summary>
	public readonly DeviceRemovedExtendedData2Structure Dred_1_2 {
		get => __aSP_AUTO_GENERATED_FIELD_61._dred_1_2;
		init => __aSP_AUTO_GENERATED_FIELD_61._dred_1_2 = value;
	}

	/// <summary>
	/// <b>D3D12_DEVICE_REMOVED_EXTENDED_DATA3 Dred_1_3</b>
	/// </summary>
	public readonly DeviceRemovedExtendedData3Structure Dred_1_3 {
		get => __aSP_AUTO_GENERATED_FIELD_61._dred_1_3;
		init => __aSP_AUTO_GENERATED_FIELD_61._dred_1_3 = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_61 __aSP_AUTO_GENERATED_FIELD_61;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataProtectedResourceSessionTypeCount {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>UINT Count</b>
	/// </summary>
	public readonly uint Count {
		get => _count;
		init => _count = value;
	}
	readonly uint _count;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataProtectedResourceSessionTypes {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>UINT Count</b>
	/// </summary>
	public readonly uint Count {
		get => _count;
		init => _count = value;
	}
	readonly uint _count;

	/// <summary>
	/// <b>GUID* pTypes</b>
	/// </summary>
	public readonly Guid* PTypes {
		get => _pTypes;
		init => _pTypes = value;
	}
	readonly Guid* _pTypes;

}

/// <summary>
/// STRUCTURE <b>D3D12_PROTECTED_RESOURCE_SESSION_DESC1</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ProtectedResourceSessionDesc1 {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_PROTECTED_RESOURCE_SESSION_FLAGS Flags</b>
	/// </summary>
	public readonly ProtectedResourceSessionFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ProtectedResourceSessionFlags _flags;

	/// <summary>
	/// <b>GUID ProtectionType</b>
	/// </summary>
	public readonly Guid ProtectionType {
		get => _protectionType;
		init => _protectionType = value;
	}
	readonly Guid _protectionType;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderPassBeginningAccessClearParameters {

	/// <summary>
	/// <b>D3D12_CLEAR_VALUE ClearValue</b>
	/// </summary>
	public readonly ClearValue ClearValue {
		get => _clearValue;
		init => _clearValue = value;
	}
	readonly ClearValue _clearValue;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_PASS_BEGINNING_ACCESS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderPassBeginningAccess {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_63 {

		[FieldOffset (0)] public RenderPassBeginningAccessClearParameters _clear;
	}

	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE Type</b>
	/// </summary>
	public readonly RenderPassBeginningAccessType Type {
		get => _type;
		init => _type = value;
	}
	readonly RenderPassBeginningAccessType _type;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear</b>
	/// </summary>
	public readonly RenderPassBeginningAccessClearParameters Clear {
		get => __aSP_AUTO_GENERATED_FIELD_63._clear;
		init => __aSP_AUTO_GENERATED_FIELD_63._clear = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_63 __aSP_AUTO_GENERATED_FIELD_63;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderPassEndingAccessResolveSubresourceParameters {

	/// <summary>
	/// <b>UINT SrcSubresource</b>
	/// </summary>
	public readonly uint SrcSubresource {
		get => _srcSubresource;
		init => _srcSubresource = value;
	}
	readonly uint _srcSubresource;

	/// <summary>
	/// <b>UINT DstSubresource</b>
	/// </summary>
	public readonly uint DstSubresource {
		get => _dstSubresource;
		init => _dstSubresource = value;
	}
	readonly uint _dstSubresource;

	/// <summary>
	/// <b>UINT DstX</b>
	/// </summary>
	public readonly uint DstX {
		get => _dstX;
		init => _dstX = value;
	}
	readonly uint _dstX;

	/// <summary>
	/// <b>UINT DstY</b>
	/// </summary>
	public readonly uint DstY {
		get => _dstY;
		init => _dstY = value;
	}
	readonly uint _dstY;

	/// <summary>
	/// <b>D3D12_RECT SrcRect</b>
	/// </summary>
	public readonly Vector4I SrcRect {
		get => _srcRect;
		init => _srcRect = value;
	}
	readonly Vector4I _srcRect;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderPassEndingAccessResolveParameters {

	/// <summary>
	/// <b>ID3D12Resource* pSrcResource</b>
	/// </summary>
	public readonly T* PSrcResource<T> () where T : unmanaged, IResource => (T*) _pSrcResource;
	readonly void* _pSrcResource;

	/// <summary>
	/// <b>ID3D12Resource* pDstResource</b>
	/// </summary>
	public readonly T* PDstResource<T> () where T : unmanaged, IResource => (T*) _pDstResource;
	readonly void* _pDstResource;

	/// <summary>
	/// <b>UINT SubresourceCount</b>
	/// </summary>
	public readonly uint SubresourceCount {
		get => _subresourceCount;
		init => _subresourceCount = value;
	}
	readonly uint _subresourceCount;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS* pSubresourceParameters</b>
	/// </summary>
	public readonly RenderPassEndingAccessResolveSubresourceParameters* PSubresourceParameters {
		get => _pSubresourceParameters;
		init => _pSubresourceParameters = value;
	}
	readonly RenderPassEndingAccessResolveSubresourceParameters* _pSubresourceParameters;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D12_RESOLVE_MODE ResolveMode</b>
	/// </summary>
	public readonly ResolveMode ResolveMode {
		get => _resolveMode;
		init => _resolveMode = value;
	}
	readonly ResolveMode _resolveMode;

	/// <summary>
	/// <b>BOOL PreserveResolveSource</b>
	/// </summary>
	public readonly bool PreserveResolveSource {
		get => _preserveResolveSource != 0;
		init => _preserveResolveSource = value ? 1U : 0U;
	}
	readonly uint _preserveResolveSource;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_PASS_ENDING_ACCESS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderPassEndingAccess {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_65 {

		[FieldOffset (0)] public RenderPassEndingAccessResolveParameters _resolve;
	}

	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS_TYPE Type</b>
	/// </summary>
	public readonly RenderPassEndingAccessType Type {
		get => _type;
		init => _type = value;
	}
	readonly RenderPassEndingAccessType _type;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve</b>
	/// </summary>
	public readonly RenderPassEndingAccessResolveParameters Resolve {
		get => __aSP_AUTO_GENERATED_FIELD_65._resolve;
		init => __aSP_AUTO_GENERATED_FIELD_65._resolve = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_65 __aSP_AUTO_GENERATED_FIELD_65;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_PASS_RENDER_TARGET_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderPassRenderTargetDesc {

	/// <summary>
	/// <b>D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor</b>
	/// </summary>
	public readonly CpuDescriptorHandle CpuDescriptor {
		get => _cpuDescriptor;
		init => _cpuDescriptor = value;
	}
	readonly CpuDescriptorHandle _cpuDescriptor;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS BeginningAccess</b>
	/// </summary>
	public readonly RenderPassBeginningAccess BeginningAccess {
		get => _beginningAccess;
		init => _beginningAccess = value;
	}
	readonly RenderPassBeginningAccess _beginningAccess;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS EndingAccess</b>
	/// </summary>
	public readonly RenderPassEndingAccess EndingAccess {
		get => _endingAccess;
		init => _endingAccess = value;
	}
	readonly RenderPassEndingAccess _endingAccess;

}

/// <summary>
/// STRUCTURE <b>D3D12_RENDER_PASS_DEPTH_STENCIL_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderPassDepthStencilDesc {

	/// <summary>
	/// <b>D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor</b>
	/// </summary>
	public readonly CpuDescriptorHandle CpuDescriptor {
		get => _cpuDescriptor;
		init => _cpuDescriptor = value;
	}
	readonly CpuDescriptorHandle _cpuDescriptor;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS DepthBeginningAccess</b>
	/// </summary>
	public readonly RenderPassBeginningAccess DepthBeginningAccess {
		get => _depthBeginningAccess;
		init => _depthBeginningAccess = value;
	}
	readonly RenderPassBeginningAccess _depthBeginningAccess;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_BEGINNING_ACCESS StencilBeginningAccess</b>
	/// </summary>
	public readonly RenderPassBeginningAccess StencilBeginningAccess {
		get => _stencilBeginningAccess;
		init => _stencilBeginningAccess = value;
	}
	readonly RenderPassBeginningAccess _stencilBeginningAccess;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS DepthEndingAccess</b>
	/// </summary>
	public readonly RenderPassEndingAccess DepthEndingAccess {
		get => _depthEndingAccess;
		init => _depthEndingAccess = value;
	}
	readonly RenderPassEndingAccess _depthEndingAccess;

	/// <summary>
	/// <b>D3D12_RENDER_PASS_ENDING_ACCESS StencilEndingAccess</b>
	/// </summary>
	public readonly RenderPassEndingAccess StencilEndingAccess {
		get => _stencilEndingAccess;
		init => _stencilEndingAccess = value;
	}
	readonly RenderPassEndingAccess _stencilEndingAccess;

}

/// <summary>
/// STRUCTURE <b>D3D12_DISPATCH_RAYS_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DispatchRaysDesc {

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS_RANGE RayGenerationShaderRecord</b>
	/// </summary>
	public readonly GpuVirtualAddressRange RayGenerationShaderRecord {
		get => _rayGenerationShaderRecord;
		init => _rayGenerationShaderRecord = value;
	}
	readonly GpuVirtualAddressRange _rayGenerationShaderRecord;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE MissShaderTable</b>
	/// </summary>
	public readonly GpuVirtualAddressRangeAndStride MissShaderTable {
		get => _missShaderTable;
		init => _missShaderTable = value;
	}
	readonly GpuVirtualAddressRangeAndStride _missShaderTable;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE HitGroupTable</b>
	/// </summary>
	public readonly GpuVirtualAddressRangeAndStride HitGroupTable {
		get => _hitGroupTable;
		init => _hitGroupTable = value;
	}
	readonly GpuVirtualAddressRangeAndStride _hitGroupTable;

	/// <summary>
	/// <b>D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE CallableShaderTable</b>
	/// </summary>
	public readonly GpuVirtualAddressRangeAndStride CallableShaderTable {
		get => _callableShaderTable;
		init => _callableShaderTable = value;
	}
	readonly GpuVirtualAddressRangeAndStride _callableShaderTable;

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>UINT Depth</b>
	/// </summary>
	public readonly uint Depth {
		get => _depth;
		init => _depth = value;
	}
	readonly uint _depth;

}

/// <summary>
/// STRUCTURE <b>D3D12_SHADER_CACHE_SESSION_DESC</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderCacheSessionDesc {

	/// <summary>
	/// <b>GUID Identifier</b>
	/// </summary>
	public readonly Guid Identifier {
		get => _identifier;
		init => _identifier = value;
	}
	readonly Guid _identifier;

	/// <summary>
	/// <b>D3D12_SHADER_CACHE_MODE Mode</b>
	/// </summary>
	public readonly ShaderCacheMode Mode {
		get => _mode;
		init => _mode = value;
	}
	readonly ShaderCacheMode _mode;

	/// <summary>
	/// <b>D3D12_SHADER_CACHE_FLAGS Flags</b>
	/// </summary>
	public readonly ShaderCacheFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly ShaderCacheFlags _flags;

	/// <summary>
	/// <b>UINT MaximumInMemoryCacheSizeBytes</b>
	/// </summary>
	public readonly uint MaximumInMemoryCacheSizeBytes {
		get => _maximumInMemoryCacheSizeBytes;
		init => _maximumInMemoryCacheSizeBytes = value;
	}
	readonly uint _maximumInMemoryCacheSizeBytes;

	/// <summary>
	/// <b>UINT MaximumInMemoryCacheEntries</b>
	/// </summary>
	public readonly uint MaximumInMemoryCacheEntries {
		get => _maximumInMemoryCacheEntries;
		init => _maximumInMemoryCacheEntries = value;
	}
	readonly uint _maximumInMemoryCacheEntries;

	/// <summary>
	/// <b>UINT MaximumValueFileSizeBytes</b>
	/// </summary>
	public readonly uint MaximumValueFileSizeBytes {
		get => _maximumValueFileSizeBytes;
		init => _maximumValueFileSizeBytes = value;
	}
	readonly uint _maximumValueFileSizeBytes;

	/// <summary>
	/// <b>UINT64 Version</b>
	/// </summary>
	public readonly ulong Version {
		get => _version;
		init => _version = value;
	}
	readonly ulong _version;

}

/// <summary>
/// STRUCTURE <b>D3D12_BARRIER_SUBRESOURCE_RANGE</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BarrierSubresourceRange {

	/// <summary>
	/// <b>UINT IndexOrFirstMipLevel</b>
	/// </summary>
	public readonly uint IndexOrFirstMipLevel {
		get => _indexOrFirstMipLevel;
		init => _indexOrFirstMipLevel = value;
	}
	readonly uint _indexOrFirstMipLevel;

	/// <summary>
	/// <b>UINT NumMipLevels</b>
	/// </summary>
	public readonly uint NumMipLevels {
		get => _numMipLevels;
		init => _numMipLevels = value;
	}
	readonly uint _numMipLevels;

	/// <summary>
	/// <b>UINT FirstArraySlice</b>
	/// </summary>
	public readonly uint FirstArraySlice {
		get => _firstArraySlice;
		init => _firstArraySlice = value;
	}
	readonly uint _firstArraySlice;

	/// <summary>
	/// <b>UINT NumArraySlices</b>
	/// </summary>
	public readonly uint NumArraySlices {
		get => _numArraySlices;
		init => _numArraySlices = value;
	}
	readonly uint _numArraySlices;

	/// <summary>
	/// <b>UINT FirstPlane</b>
	/// </summary>
	public readonly uint FirstPlane {
		get => _firstPlane;
		init => _firstPlane = value;
	}
	readonly uint _firstPlane;

	/// <summary>
	/// <b>UINT NumPlanes</b>
	/// </summary>
	public readonly uint NumPlanes {
		get => _numPlanes;
		init => _numPlanes = value;
	}
	readonly uint _numPlanes;

}

/// <summary>
/// STRUCTURE <b>D3D12_GLOBAL_BARRIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GlobalBarrier {

	/// <summary>
	/// <b>D3D12_BARRIER_SYNC SyncBefore</b>
	/// </summary>
	public readonly BarrierSync SyncBefore {
		get => _syncBefore;
		init => _syncBefore = value;
	}
	readonly BarrierSync _syncBefore;

	/// <summary>
	/// <b>D3D12_BARRIER_SYNC SyncAfter</b>
	/// </summary>
	public readonly BarrierSync SyncAfter {
		get => _syncAfter;
		init => _syncAfter = value;
	}
	readonly BarrierSync _syncAfter;

	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS AccessBefore</b>
	/// </summary>
	public readonly BarrierAccess AccessBefore {
		get => _accessBefore;
		init => _accessBefore = value;
	}
	readonly BarrierAccess _accessBefore;

	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS AccessAfter</b>
	/// </summary>
	public readonly BarrierAccess AccessAfter {
		get => _accessAfter;
		init => _accessAfter = value;
	}
	readonly BarrierAccess _accessAfter;

}

/// <summary>
/// STRUCTURE <b>D3D12_TEXTURE_BARRIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TextureBarrier {

	/// <summary>
	/// <b>D3D12_BARRIER_SYNC SyncBefore</b>
	/// </summary>
	public readonly BarrierSync SyncBefore {
		get => _syncBefore;
		init => _syncBefore = value;
	}
	readonly BarrierSync _syncBefore;

	/// <summary>
	/// <b>D3D12_BARRIER_SYNC SyncAfter</b>
	/// </summary>
	public readonly BarrierSync SyncAfter {
		get => _syncAfter;
		init => _syncAfter = value;
	}
	readonly BarrierSync _syncAfter;

	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS AccessBefore</b>
	/// </summary>
	public readonly BarrierAccess AccessBefore {
		get => _accessBefore;
		init => _accessBefore = value;
	}
	readonly BarrierAccess _accessBefore;

	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS AccessAfter</b>
	/// </summary>
	public readonly BarrierAccess AccessAfter {
		get => _accessAfter;
		init => _accessAfter = value;
	}
	readonly BarrierAccess _accessAfter;

	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT LayoutBefore</b>
	/// </summary>
	public readonly BarrierLayout LayoutBefore {
		get => _layoutBefore;
		init => _layoutBefore = value;
	}
	readonly BarrierLayout _layoutBefore;

	/// <summary>
	/// <b>D3D12_BARRIER_LAYOUT LayoutAfter</b>
	/// </summary>
	public readonly BarrierLayout LayoutAfter {
		get => _layoutAfter;
		init => _layoutAfter = value;
	}
	readonly BarrierLayout _layoutAfter;

	/// <summary>
	/// <b>ID3D12Resource* pResource</b>
	/// </summary>
	public readonly T* PResource<T> () where T : unmanaged, IResource => (T*) _pResource;
	readonly void* _pResource;

	/// <summary>
	/// <b>D3D12_BARRIER_SUBRESOURCE_RANGE Subresources</b>
	/// </summary>
	public readonly BarrierSubresourceRange Subresources {
		get => _subresources;
		init => _subresources = value;
	}
	readonly BarrierSubresourceRange _subresources;

	/// <summary>
	/// <b>D3D12_TEXTURE_BARRIER_FLAGS Flags</b>
	/// </summary>
	public readonly TextureBarrierFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly TextureBarrierFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_BUFFER_BARRIER</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferBarrier {

	/// <summary>
	/// <b>D3D12_BARRIER_SYNC SyncBefore</b>
	/// </summary>
	public readonly BarrierSync SyncBefore {
		get => _syncBefore;
		init => _syncBefore = value;
	}
	readonly BarrierSync _syncBefore;

	/// <summary>
	/// <b>D3D12_BARRIER_SYNC SyncAfter</b>
	/// </summary>
	public readonly BarrierSync SyncAfter {
		get => _syncAfter;
		init => _syncAfter = value;
	}
	readonly BarrierSync _syncAfter;

	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS AccessBefore</b>
	/// </summary>
	public readonly BarrierAccess AccessBefore {
		get => _accessBefore;
		init => _accessBefore = value;
	}
	readonly BarrierAccess _accessBefore;

	/// <summary>
	/// <b>D3D12_BARRIER_ACCESS AccessAfter</b>
	/// </summary>
	public readonly BarrierAccess AccessAfter {
		get => _accessAfter;
		init => _accessAfter = value;
	}
	readonly BarrierAccess _accessAfter;

	/// <summary>
	/// <b>ID3D12Resource* pResource</b>
	/// </summary>
	public readonly T* PResource<T> () where T : unmanaged, IResource => (T*) _pResource;
	readonly void* _pResource;

	/// <summary>
	/// <b>UINT64 Offset</b>
	/// </summary>
	public readonly ulong Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly ulong _offset;

	/// <summary>
	/// <b>UINT64 Size</b>
	/// </summary>
	public readonly ulong Size {
		get => _size;
		init => _size = value;
	}
	readonly ulong _size;

}

/// <summary>
/// STRUCTURE <b>D3D12_BARRIER_GROUP</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BarrierGroup {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_67 {

		[FieldOffset (0)] public GlobalBarrier* _pGlobalBarriers;
		[FieldOffset (0)] public TextureBarrier* _pTextureBarriers;
		[FieldOffset (0)] public BufferBarrier* _pBufferBarriers;
	}

	/// <summary>
	/// <b>D3D12_BARRIER_TYPE Type</b>
	/// </summary>
	public readonly BarrierType Type {
		get => _type;
		init => _type = value;
	}
	readonly BarrierType _type;

	/// <summary>
	/// <b>UINT32 NumBarriers</b>
	/// </summary>
	public readonly uint NumBarriers {
		get => _numBarriers;
		init => _numBarriers = value;
	}
	readonly uint _numBarriers;

	/// <summary>
	/// <b>D3D12_GLOBAL_BARRIER* pGlobalBarriers</b>
	/// </summary>
	public readonly GlobalBarrier* PGlobalBarriers {
		get => __aSP_AUTO_GENERATED_FIELD_67._pGlobalBarriers;
		init => __aSP_AUTO_GENERATED_FIELD_67._pGlobalBarriers = value;
	}

	/// <summary>
	/// <b>D3D12_TEXTURE_BARRIER* pTextureBarriers</b>
	/// </summary>
	public readonly TextureBarrier* PTextureBarriers {
		get => __aSP_AUTO_GENERATED_FIELD_67._pTextureBarriers;
		init => __aSP_AUTO_GENERATED_FIELD_67._pTextureBarriers = value;
	}

	/// <summary>
	/// <b>D3D12_BUFFER_BARRIER* pBufferBarriers</b>
	/// </summary>
	public readonly BufferBarrier* PBufferBarriers {
		get => __aSP_AUTO_GENERATED_FIELD_67._pBufferBarriers;
		init => __aSP_AUTO_GENERATED_FIELD_67._pBufferBarriers = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_67 __aSP_AUTO_GENERATED_FIELD_67;

}

/// <summary>
/// STRUCTURE <b>D3D12_SUBRESOURCE_DATA</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SubresourceData {

	/// <summary>
	/// <b>void* pData</b>
	/// </summary>
	public readonly void* PData {
		get => _pData;
		init => _pData = value;
	}
	readonly void* _pData;

	/// <summary>
	/// <b>LONG_PTR RowPitch</b>
	/// </summary>
	public readonly IntPtr RowPitch {
		get => _rowPitch;
		init => _rowPitch = value;
	}
	readonly IntPtr _rowPitch;

	/// <summary>
	/// <b>LONG_PTR SlicePitch</b>
	/// </summary>
	public readonly IntPtr SlicePitch {
		get => _slicePitch;
		init => _slicePitch = value;
	}
	readonly IntPtr _slicePitch;

}

/// <summary>
/// STRUCTURE <b>D3D12_MEMCPY_DEST</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MemcpyDest {

	/// <summary>
	/// <b>void* pData</b>
	/// </summary>
	public readonly void* PData {
		get => _pData;
		init => _pData = value;
	}
	readonly void* _pData;

	/// <summary>
	/// <b>SIZE_T RowPitch</b>
	/// </summary>
	public readonly nuint RowPitch {
		get => _rowPitch;
		init => _rowPitch = value;
	}
	readonly nuint _rowPitch;

	/// <summary>
	/// <b>SIZE_T SlicePitch</b>
	/// </summary>
	public readonly nuint SlicePitch {
		get => _slicePitch;
		init => _slicePitch = value;
	}
	readonly nuint _slicePitch;

}

/// <summary>
/// STRUCTURE <b>D3D12_DISPATCH_MESH_ARGUMENTS</b><br/>
/// D3D12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DispatchMeshArguments {

	/// <summary>
	/// <b>UINT ThreadGroupCountX</b>
	/// </summary>
	public readonly uint ThreadGroupCountX {
		get => _threadGroupCountX;
		init => _threadGroupCountX = value;
	}
	readonly uint _threadGroupCountX;

	/// <summary>
	/// <b>UINT ThreadGroupCountY</b>
	/// </summary>
	public readonly uint ThreadGroupCountY {
		get => _threadGroupCountY;
		init => _threadGroupCountY = value;
	}
	readonly uint _threadGroupCountY;

	/// <summary>
	/// <b>UINT ThreadGroupCountZ</b>
	/// </summary>
	public readonly uint ThreadGroupCountZ {
		get => _threadGroupCountZ;
		init => _threadGroupCountZ = value;
	}
	readonly uint _threadGroupCountZ;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEBUG_DEVICE_GPU_BASED_VALIDATION_SETTINGS</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DebugDeviceGpuBasedValidationSettings {

	/// <summary>
	/// <b>UINT MaxMessagesPerCommandList</b>
	/// </summary>
	public readonly uint MaxMessagesPerCommandList {
		get => _maxMessagesPerCommandList;
		init => _maxMessagesPerCommandList = value;
	}
	readonly uint _maxMessagesPerCommandList;

	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE DefaultShaderPatchMode</b>
	/// </summary>
	public readonly GpuBasedValidationShaderPatchMode DefaultShaderPatchMode {
		get => _defaultShaderPatchMode;
		init => _defaultShaderPatchMode = value;
	}
	readonly GpuBasedValidationShaderPatchMode _defaultShaderPatchMode;

	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS PipelineStateCreateFlags</b>
	/// </summary>
	public readonly GpuBasedValidationPipelineStateCreateFlags PipelineStateCreateFlags {
		get => _pipelineStateCreateFlags;
		init => _pipelineStateCreateFlags = value;
	}
	readonly GpuBasedValidationPipelineStateCreateFlags _pipelineStateCreateFlags;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEBUG_DEVICE_GPU_SLOWDOWN_PERFORMANCE_FACTOR</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DebugDeviceGpuSlowdownPerformanceFactor {

	/// <summary>
	/// <b>FLOAT SlowdownFactor</b>
	/// </summary>
	public readonly float SlowdownFactor {
		get => _slowdownFactor;
		init => _slowdownFactor = value;
	}
	readonly float _slowdownFactor;

}

/// <summary>
/// STRUCTURE <b>D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DebugCommandListGpuBasedValidationSettings {

	/// <summary>
	/// <b>D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE ShaderPatchMode</b>
	/// </summary>
	public readonly GpuBasedValidationShaderPatchMode ShaderPatchMode {
		get => _shaderPatchMode;
		init => _shaderPatchMode = value;
	}
	readonly GpuBasedValidationShaderPatchMode _shaderPatchMode;

}

/// <summary>
/// STRUCTURE <b>D3D12_MESSAGE</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Message {

	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY Category</b>
	/// </summary>
	public readonly MessageCategory Category {
		get => _category;
		init => _category = value;
	}
	readonly MessageCategory _category;

	/// <summary>
	/// <b>D3D12_MESSAGE_SEVERITY Severity</b>
	/// </summary>
	public readonly MessageSeverity Severity {
		get => _severity;
		init => _severity = value;
	}
	readonly MessageSeverity _severity;

	/// <summary>
	/// <b>D3D12_MESSAGE_ID ID</b>
	/// </summary>
	public readonly MessageId Id {
		get => _iD;
		init => _iD = value;
	}
	readonly MessageId _iD;

	/// <summary>
	/// <b>char* pDescription</b>
	/// </summary>
	public readonly char* PDescription {
		get => _pDescription;
		init => _pDescription = value;
	}
	readonly char* _pDescription;

	/// <summary>
	/// <b>SIZE_T DescriptionByteLength</b>
	/// </summary>
	public readonly nuint DescriptionByteLength {
		get => _descriptionByteLength;
		init => _descriptionByteLength = value;
	}
	readonly nuint _descriptionByteLength;

}

/// <summary>
/// STRUCTURE <b>D3D12_INFO_QUEUE_FILTER_DESC</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InfoQueueFilterDesc {

	/// <summary>
	/// <b>UINT NumCategories</b>
	/// </summary>
	public readonly uint NumCategories {
		get => _numCategories;
		init => _numCategories = value;
	}
	readonly uint _numCategories;

	/// <summary>
	/// <b>D3D12_MESSAGE_CATEGORY* pCategoryList</b>
	/// </summary>
	public readonly MessageCategory* PCategoryList {
		get => _pCategoryList;
		init => _pCategoryList = value;
	}
	readonly MessageCategory* _pCategoryList;

	/// <summary>
	/// <b>UINT NumSeverities</b>
	/// </summary>
	public readonly uint NumSeverities {
		get => _numSeverities;
		init => _numSeverities = value;
	}
	readonly uint _numSeverities;

	/// <summary>
	/// <b>D3D12_MESSAGE_SEVERITY* pSeverityList</b>
	/// </summary>
	public readonly MessageSeverity* PSeverityList {
		get => _pSeverityList;
		init => _pSeverityList = value;
	}
	readonly MessageSeverity* _pSeverityList;

	/// <summary>
	/// <b>UINT NumIDs</b>
	/// </summary>
	public readonly uint NumIDs {
		get => _numIDs;
		init => _numIDs = value;
	}
	readonly uint _numIDs;

	/// <summary>
	/// <b>D3D12_MESSAGE_ID* pIDList</b>
	/// </summary>
	public readonly MessageId* PIDList {
		get => _pIDList;
		init => _pIDList = value;
	}
	readonly MessageId* _pIDList;

}

/// <summary>
/// STRUCTURE <b>D3D12_INFO_QUEUE_FILTER</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InfoQueueFilter {

	/// <summary>
	/// <b>D3D12_INFO_QUEUE_FILTER_DESC AllowList</b>
	/// </summary>
	public readonly InfoQueueFilterDesc AllowList {
		get => _allowList;
		init => _allowList = value;
	}
	readonly InfoQueueFilterDesc _allowList;

	/// <summary>
	/// <b>D3D12_INFO_QUEUE_FILTER_DESC DenyList</b>
	/// </summary>
	public readonly InfoQueueFilterDesc DenyList {
		get => _denyList;
		init => _denyList = value;
	}
	readonly InfoQueueFilterDesc _denyList;

}

/// <summary>
/// STRUCTURE <b>_D3D12_SIGNATURE_PARAMETER_DESC</b> (D3D12_SIGNATURE_PARAMETER_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SignatureParameterDesc {

	/// <summary>
	/// <b>LPCSTR SemanticName</b>
	/// </summary>
	public readonly char* SemanticName {
		get => _semanticName;
		init => _semanticName = value;
	}
	readonly char* _semanticName;

	/// <summary>
	/// <b>UINT SemanticIndex</b>
	/// </summary>
	public readonly uint SemanticIndex {
		get => _semanticIndex;
		init => _semanticIndex = value;
	}
	readonly uint _semanticIndex;

	/// <summary>
	/// <b>UINT Register</b>
	/// </summary>
	public readonly uint Register {
		get => _register;
		init => _register = value;
	}
	readonly uint _register;

	/// <summary>
	/// <b>D3D_NAME SystemValueType</b>
	/// </summary>
	public readonly Direct3D.Name SystemValueType {
		get => _systemValueType;
		init => _systemValueType = value;
	}
	readonly Direct3D.Name _systemValueType;

	/// <summary>
	/// <b>D3D_REGISTER_COMPONENT_TYPE ComponentType</b>
	/// </summary>
	public readonly Direct3D.RegisterComponentType ComponentType {
		get => _componentType;
		init => _componentType = value;
	}
	readonly Direct3D.RegisterComponentType _componentType;

	/// <summary>
	/// <b>BYTE Mask</b>
	/// </summary>
	public readonly byte Mask {
		get => _mask;
		init => _mask = value;
	}
	readonly byte _mask;

	/// <summary>
	/// <b>BYTE ReadWriteMask</b>
	/// </summary>
	public readonly byte ReadWriteMask {
		get => _readWriteMask;
		init => _readWriteMask = value;
	}
	readonly byte _readWriteMask;

	/// <summary>
	/// <b>UINT Stream</b>
	/// </summary>
	public readonly uint Stream {
		get => _stream;
		init => _stream = value;
	}
	readonly uint _stream;

	/// <summary>
	/// <b>D3D_MIN_PRECISION MinPrecision</b>
	/// </summary>
	public readonly Direct3D.MinPrecision MinPrecision {
		get => _minPrecision;
		init => _minPrecision = value;
	}
	readonly Direct3D.MinPrecision _minPrecision;

}

/// <summary>
/// STRUCTURE <b>_D3D12_SHADER_BUFFER_DESC</b> (D3D12_SHADER_BUFFER_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderBufferDesc {

	/// <summary>
	/// <b>LPCSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>D3D_CBUFFER_TYPE Type</b>
	/// </summary>
	public readonly Direct3D.CbufferType Type {
		get => _type;
		init => _type = value;
	}
	readonly Direct3D.CbufferType _type;

	/// <summary>
	/// <b>UINT Variables</b>
	/// </summary>
	public readonly uint Variables {
		get => _variables;
		init => _variables = value;
	}
	readonly uint _variables;

	/// <summary>
	/// <b>UINT Size</b>
	/// </summary>
	public readonly uint Size {
		get => _size;
		init => _size = value;
	}
	readonly uint _size;

	/// <summary>
	/// <b>UINT uFlags</b>
	/// </summary>
	public readonly uint UFlags {
		get => _uFlags;
		init => _uFlags = value;
	}
	readonly uint _uFlags;

}

/// <summary>
/// STRUCTURE <b>_D3D12_SHADER_VARIABLE_DESC</b> (D3D12_SHADER_VARIABLE_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderVariableDesc {

	/// <summary>
	/// <b>LPCSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>UINT StartOffset</b>
	/// </summary>
	public readonly uint StartOffset {
		get => _startOffset;
		init => _startOffset = value;
	}
	readonly uint _startOffset;

	/// <summary>
	/// <b>UINT Size</b>
	/// </summary>
	public readonly uint Size {
		get => _size;
		init => _size = value;
	}
	readonly uint _size;

	/// <summary>
	/// <b>UINT uFlags</b>
	/// </summary>
	public readonly uint UFlags {
		get => _uFlags;
		init => _uFlags = value;
	}
	readonly uint _uFlags;

	/// <summary>
	/// <b>LPVOID DefaultValue</b>
	/// </summary>
	public readonly void* DefaultValue {
		get => _defaultValue;
		init => _defaultValue = value;
	}
	readonly void* _defaultValue;

	/// <summary>
	/// <b>UINT StartTexture</b>
	/// </summary>
	public readonly uint StartTexture {
		get => _startTexture;
		init => _startTexture = value;
	}
	readonly uint _startTexture;

	/// <summary>
	/// <b>UINT TextureSize</b>
	/// </summary>
	public readonly uint TextureSize {
		get => _textureSize;
		init => _textureSize = value;
	}
	readonly uint _textureSize;

	/// <summary>
	/// <b>UINT StartSampler</b>
	/// </summary>
	public readonly uint StartSampler {
		get => _startSampler;
		init => _startSampler = value;
	}
	readonly uint _startSampler;

	/// <summary>
	/// <b>UINT SamplerSize</b>
	/// </summary>
	public readonly uint SamplerSize {
		get => _samplerSize;
		init => _samplerSize = value;
	}
	readonly uint _samplerSize;

}

/// <summary>
/// STRUCTURE <b>_D3D12_SHADER_TYPE_DESC</b> (D3D12_SHADER_TYPE_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderTypeDesc {

	/// <summary>
	/// <b>D3D_SHADER_VARIABLE_CLASS Class</b>
	/// </summary>
	public readonly Direct3D.ShaderVariableClass Class {
		get => _class;
		init => _class = value;
	}
	readonly Direct3D.ShaderVariableClass _class;

	/// <summary>
	/// <b>D3D_SHADER_VARIABLE_TYPE Type</b>
	/// </summary>
	public readonly Direct3D.ShaderVariableType Type {
		get => _type;
		init => _type = value;
	}
	readonly Direct3D.ShaderVariableType _type;

	/// <summary>
	/// <b>UINT Rows</b>
	/// </summary>
	public readonly uint Rows {
		get => _rows;
		init => _rows = value;
	}
	readonly uint _rows;

	/// <summary>
	/// <b>UINT Columns</b>
	/// </summary>
	public readonly uint Columns {
		get => _columns;
		init => _columns = value;
	}
	readonly uint _columns;

	/// <summary>
	/// <b>UINT Elements</b>
	/// </summary>
	public readonly uint Elements {
		get => _elements;
		init => _elements = value;
	}
	readonly uint _elements;

	/// <summary>
	/// <b>UINT Members</b>
	/// </summary>
	public readonly uint Members {
		get => _members;
		init => _members = value;
	}
	readonly uint _members;

	/// <summary>
	/// <b>UINT Offset</b>
	/// </summary>
	public readonly uint Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly uint _offset;

	/// <summary>
	/// <b>LPCSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

}

/// <summary>
/// STRUCTURE <b>_D3D12_SHADER_DESC</b> (D3D12_SHADER_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderDesc {

	/// <summary>
	/// <b>UINT Version</b>
	/// </summary>
	public readonly uint Version {
		get => _version;
		init => _version = value;
	}
	readonly uint _version;

	/// <summary>
	/// <b>LPCSTR Creator</b>
	/// </summary>
	public readonly char* Creator {
		get => _creator;
		init => _creator = value;
	}
	readonly char* _creator;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

	/// <summary>
	/// <b>UINT ConstantBuffers</b>
	/// </summary>
	public readonly uint ConstantBuffers {
		get => _constantBuffers;
		init => _constantBuffers = value;
	}
	readonly uint _constantBuffers;

	/// <summary>
	/// <b>UINT BoundResources</b>
	/// </summary>
	public readonly uint BoundResources {
		get => _boundResources;
		init => _boundResources = value;
	}
	readonly uint _boundResources;

	/// <summary>
	/// <b>UINT InputParameters</b>
	/// </summary>
	public readonly uint InputParameters {
		get => _inputParameters;
		init => _inputParameters = value;
	}
	readonly uint _inputParameters;

	/// <summary>
	/// <b>UINT OutputParameters</b>
	/// </summary>
	public readonly uint OutputParameters {
		get => _outputParameters;
		init => _outputParameters = value;
	}
	readonly uint _outputParameters;

	/// <summary>
	/// <b>UINT InstructionCount</b>
	/// </summary>
	public readonly uint InstructionCount {
		get => _instructionCount;
		init => _instructionCount = value;
	}
	readonly uint _instructionCount;

	/// <summary>
	/// <b>UINT TempRegisterCount</b>
	/// </summary>
	public readonly uint TempRegisterCount {
		get => _tempRegisterCount;
		init => _tempRegisterCount = value;
	}
	readonly uint _tempRegisterCount;

	/// <summary>
	/// <b>UINT TempArrayCount</b>
	/// </summary>
	public readonly uint TempArrayCount {
		get => _tempArrayCount;
		init => _tempArrayCount = value;
	}
	readonly uint _tempArrayCount;

	/// <summary>
	/// <b>UINT DefCount</b>
	/// </summary>
	public readonly uint DefCount {
		get => _defCount;
		init => _defCount = value;
	}
	readonly uint _defCount;

	/// <summary>
	/// <b>UINT DclCount</b>
	/// </summary>
	public readonly uint DclCount {
		get => _dclCount;
		init => _dclCount = value;
	}
	readonly uint _dclCount;

	/// <summary>
	/// <b>UINT TextureNormalInstructions</b>
	/// </summary>
	public readonly uint TextureNormalInstructions {
		get => _textureNormalInstructions;
		init => _textureNormalInstructions = value;
	}
	readonly uint _textureNormalInstructions;

	/// <summary>
	/// <b>UINT TextureLoadInstructions</b>
	/// </summary>
	public readonly uint TextureLoadInstructions {
		get => _textureLoadInstructions;
		init => _textureLoadInstructions = value;
	}
	readonly uint _textureLoadInstructions;

	/// <summary>
	/// <b>UINT TextureCompInstructions</b>
	/// </summary>
	public readonly uint TextureCompInstructions {
		get => _textureCompInstructions;
		init => _textureCompInstructions = value;
	}
	readonly uint _textureCompInstructions;

	/// <summary>
	/// <b>UINT TextureBiasInstructions</b>
	/// </summary>
	public readonly uint TextureBiasInstructions {
		get => _textureBiasInstructions;
		init => _textureBiasInstructions = value;
	}
	readonly uint _textureBiasInstructions;

	/// <summary>
	/// <b>UINT TextureGradientInstructions</b>
	/// </summary>
	public readonly uint TextureGradientInstructions {
		get => _textureGradientInstructions;
		init => _textureGradientInstructions = value;
	}
	readonly uint _textureGradientInstructions;

	/// <summary>
	/// <b>UINT FloatInstructionCount</b>
	/// </summary>
	public readonly uint FloatInstructionCount {
		get => _floatInstructionCount;
		init => _floatInstructionCount = value;
	}
	readonly uint _floatInstructionCount;

	/// <summary>
	/// <b>UINT IntInstructionCount</b>
	/// </summary>
	public readonly uint IntInstructionCount {
		get => _intInstructionCount;
		init => _intInstructionCount = value;
	}
	readonly uint _intInstructionCount;

	/// <summary>
	/// <b>UINT UintInstructionCount</b>
	/// </summary>
	public readonly uint UintInstructionCount {
		get => _uintInstructionCount;
		init => _uintInstructionCount = value;
	}
	readonly uint _uintInstructionCount;

	/// <summary>
	/// <b>UINT StaticFlowControlCount</b>
	/// </summary>
	public readonly uint StaticFlowControlCount {
		get => _staticFlowControlCount;
		init => _staticFlowControlCount = value;
	}
	readonly uint _staticFlowControlCount;

	/// <summary>
	/// <b>UINT DynamicFlowControlCount</b>
	/// </summary>
	public readonly uint DynamicFlowControlCount {
		get => _dynamicFlowControlCount;
		init => _dynamicFlowControlCount = value;
	}
	readonly uint _dynamicFlowControlCount;

	/// <summary>
	/// <b>UINT MacroInstructionCount</b>
	/// </summary>
	public readonly uint MacroInstructionCount {
		get => _macroInstructionCount;
		init => _macroInstructionCount = value;
	}
	readonly uint _macroInstructionCount;

	/// <summary>
	/// <b>UINT ArrayInstructionCount</b>
	/// </summary>
	public readonly uint ArrayInstructionCount {
		get => _arrayInstructionCount;
		init => _arrayInstructionCount = value;
	}
	readonly uint _arrayInstructionCount;

	/// <summary>
	/// <b>UINT CutInstructionCount</b>
	/// </summary>
	public readonly uint CutInstructionCount {
		get => _cutInstructionCount;
		init => _cutInstructionCount = value;
	}
	readonly uint _cutInstructionCount;

	/// <summary>
	/// <b>UINT EmitInstructionCount</b>
	/// </summary>
	public readonly uint EmitInstructionCount {
		get => _emitInstructionCount;
		init => _emitInstructionCount = value;
	}
	readonly uint _emitInstructionCount;

	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY GSOutputTopology</b>
	/// </summary>
	public readonly Direct3D.PrimitiveTopology GSOutputTopology {
		get => _gSOutputTopology;
		init => _gSOutputTopology = value;
	}
	readonly Direct3D.PrimitiveTopology _gSOutputTopology;

	/// <summary>
	/// <b>UINT GSMaxOutputVertexCount</b>
	/// </summary>
	public readonly uint GSMaxOutputVertexCount {
		get => _gSMaxOutputVertexCount;
		init => _gSMaxOutputVertexCount = value;
	}
	readonly uint _gSMaxOutputVertexCount;

	/// <summary>
	/// <b>D3D_PRIMITIVE InputPrimitive</b>
	/// </summary>
	public readonly Direct3D.Primitive InputPrimitive {
		get => _inputPrimitive;
		init => _inputPrimitive = value;
	}
	readonly Direct3D.Primitive _inputPrimitive;

	/// <summary>
	/// <b>UINT PatchConstantParameters</b>
	/// </summary>
	public readonly uint PatchConstantParameters {
		get => _patchConstantParameters;
		init => _patchConstantParameters = value;
	}
	readonly uint _patchConstantParameters;

	/// <summary>
	/// <b>UINT cGSInstanceCount</b>
	/// </summary>
	public readonly uint CGSInstanceCount {
		get => _cGSInstanceCount;
		init => _cGSInstanceCount = value;
	}
	readonly uint _cGSInstanceCount;

	/// <summary>
	/// <b>UINT cControlPoints</b>
	/// </summary>
	public readonly uint CControlPoints {
		get => _cControlPoints;
		init => _cControlPoints = value;
	}
	readonly uint _cControlPoints;

	/// <summary>
	/// <b>D3D_TESSELLATOR_OUTPUT_PRIMITIVE HSOutputPrimitive</b>
	/// </summary>
	public readonly Direct3D.TessellatorOutputPrimitive HSOutputPrimitive {
		get => _hSOutputPrimitive;
		init => _hSOutputPrimitive = value;
	}
	readonly Direct3D.TessellatorOutputPrimitive _hSOutputPrimitive;

	/// <summary>
	/// <b>D3D_TESSELLATOR_PARTITIONING HSPartitioning</b>
	/// </summary>
	public readonly Direct3D.TessellatorPartitioning HSPartitioning {
		get => _hSPartitioning;
		init => _hSPartitioning = value;
	}
	readonly Direct3D.TessellatorPartitioning _hSPartitioning;

	/// <summary>
	/// <b>D3D_TESSELLATOR_DOMAIN TessellatorDomain</b>
	/// </summary>
	public readonly Direct3D.TessellatorDomain TessellatorDomain {
		get => _tessellatorDomain;
		init => _tessellatorDomain = value;
	}
	readonly Direct3D.TessellatorDomain _tessellatorDomain;

	/// <summary>
	/// <b>UINT cBarrierInstructions</b>
	/// </summary>
	public readonly uint CBarrierInstructions {
		get => _cBarrierInstructions;
		init => _cBarrierInstructions = value;
	}
	readonly uint _cBarrierInstructions;

	/// <summary>
	/// <b>UINT cInterlockedInstructions</b>
	/// </summary>
	public readonly uint CInterlockedInstructions {
		get => _cInterlockedInstructions;
		init => _cInterlockedInstructions = value;
	}
	readonly uint _cInterlockedInstructions;

	/// <summary>
	/// <b>UINT cTextureStoreInstructions</b>
	/// </summary>
	public readonly uint CTextureStoreInstructions {
		get => _cTextureStoreInstructions;
		init => _cTextureStoreInstructions = value;
	}
	readonly uint _cTextureStoreInstructions;

}

/// <summary>
/// STRUCTURE <b>_D3D12_SHADER_INPUT_BIND_DESC</b> (D3D12_SHADER_INPUT_BIND_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderInputBindDesc {

	/// <summary>
	/// <b>LPCSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>D3D_SHADER_INPUT_TYPE Type</b>
	/// </summary>
	public readonly Direct3D.ShaderInputType Type {
		get => _type;
		init => _type = value;
	}
	readonly Direct3D.ShaderInputType _type;

	/// <summary>
	/// <b>UINT BindPoint</b>
	/// </summary>
	public readonly uint BindPoint {
		get => _bindPoint;
		init => _bindPoint = value;
	}
	readonly uint _bindPoint;

	/// <summary>
	/// <b>UINT BindCount</b>
	/// </summary>
	public readonly uint BindCount {
		get => _bindCount;
		init => _bindCount = value;
	}
	readonly uint _bindCount;

	/// <summary>
	/// <b>UINT uFlags</b>
	/// </summary>
	public readonly uint UFlags {
		get => _uFlags;
		init => _uFlags = value;
	}
	readonly uint _uFlags;

	/// <summary>
	/// <b>D3D_RESOURCE_RETURN_TYPE ReturnType</b>
	/// </summary>
	public readonly Direct3D.ResourceReturnType ReturnType {
		get => _returnType;
		init => _returnType = value;
	}
	readonly Direct3D.ResourceReturnType _returnType;

	/// <summary>
	/// <b>D3D_SRV_DIMENSION Dimension</b>
	/// </summary>
	public readonly Direct3D.SrvDimension Dimension {
		get => _dimension;
		init => _dimension = value;
	}
	readonly Direct3D.SrvDimension _dimension;

	/// <summary>
	/// <b>UINT NumSamples</b>
	/// </summary>
	public readonly uint NumSamples {
		get => _numSamples;
		init => _numSamples = value;
	}
	readonly uint _numSamples;

	/// <summary>
	/// <b>UINT Space</b>
	/// </summary>
	public readonly uint Space {
		get => _space;
		init => _space = value;
	}
	readonly uint _space;

	/// <summary>
	/// <b>UINT uID</b>
	/// </summary>
	public readonly uint UID {
		get => _uID;
		init => _uID = value;
	}
	readonly uint _uID;

}

/// <summary>
/// STRUCTURE <b>_D3D12_LIBRARY_DESC</b> (D3D12_LIBRARY_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LibraryDesc {

	/// <summary>
	/// <b>LPCSTR Creator</b>
	/// </summary>
	public readonly char* Creator {
		get => _creator;
		init => _creator = value;
	}
	readonly char* _creator;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

	/// <summary>
	/// <b>UINT FunctionCount</b>
	/// </summary>
	public readonly uint FunctionCount {
		get => _functionCount;
		init => _functionCount = value;
	}
	readonly uint _functionCount;

}

/// <summary>
/// STRUCTURE <b>_D3D12_FUNCTION_DESC</b> (D3D12_FUNCTION_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FunctionDesc {

	/// <summary>
	/// <b>UINT Version</b>
	/// </summary>
	public readonly uint Version {
		get => _version;
		init => _version = value;
	}
	readonly uint _version;

	/// <summary>
	/// <b>LPCSTR Creator</b>
	/// </summary>
	public readonly char* Creator {
		get => _creator;
		init => _creator = value;
	}
	readonly char* _creator;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

	/// <summary>
	/// <b>UINT ConstantBuffers</b>
	/// </summary>
	public readonly uint ConstantBuffers {
		get => _constantBuffers;
		init => _constantBuffers = value;
	}
	readonly uint _constantBuffers;

	/// <summary>
	/// <b>UINT BoundResources</b>
	/// </summary>
	public readonly uint BoundResources {
		get => _boundResources;
		init => _boundResources = value;
	}
	readonly uint _boundResources;

	/// <summary>
	/// <b>UINT InstructionCount</b>
	/// </summary>
	public readonly uint InstructionCount {
		get => _instructionCount;
		init => _instructionCount = value;
	}
	readonly uint _instructionCount;

	/// <summary>
	/// <b>UINT TempRegisterCount</b>
	/// </summary>
	public readonly uint TempRegisterCount {
		get => _tempRegisterCount;
		init => _tempRegisterCount = value;
	}
	readonly uint _tempRegisterCount;

	/// <summary>
	/// <b>UINT TempArrayCount</b>
	/// </summary>
	public readonly uint TempArrayCount {
		get => _tempArrayCount;
		init => _tempArrayCount = value;
	}
	readonly uint _tempArrayCount;

	/// <summary>
	/// <b>UINT DefCount</b>
	/// </summary>
	public readonly uint DefCount {
		get => _defCount;
		init => _defCount = value;
	}
	readonly uint _defCount;

	/// <summary>
	/// <b>UINT DclCount</b>
	/// </summary>
	public readonly uint DclCount {
		get => _dclCount;
		init => _dclCount = value;
	}
	readonly uint _dclCount;

	/// <summary>
	/// <b>UINT TextureNormalInstructions</b>
	/// </summary>
	public readonly uint TextureNormalInstructions {
		get => _textureNormalInstructions;
		init => _textureNormalInstructions = value;
	}
	readonly uint _textureNormalInstructions;

	/// <summary>
	/// <b>UINT TextureLoadInstructions</b>
	/// </summary>
	public readonly uint TextureLoadInstructions {
		get => _textureLoadInstructions;
		init => _textureLoadInstructions = value;
	}
	readonly uint _textureLoadInstructions;

	/// <summary>
	/// <b>UINT TextureCompInstructions</b>
	/// </summary>
	public readonly uint TextureCompInstructions {
		get => _textureCompInstructions;
		init => _textureCompInstructions = value;
	}
	readonly uint _textureCompInstructions;

	/// <summary>
	/// <b>UINT TextureBiasInstructions</b>
	/// </summary>
	public readonly uint TextureBiasInstructions {
		get => _textureBiasInstructions;
		init => _textureBiasInstructions = value;
	}
	readonly uint _textureBiasInstructions;

	/// <summary>
	/// <b>UINT TextureGradientInstructions</b>
	/// </summary>
	public readonly uint TextureGradientInstructions {
		get => _textureGradientInstructions;
		init => _textureGradientInstructions = value;
	}
	readonly uint _textureGradientInstructions;

	/// <summary>
	/// <b>UINT FloatInstructionCount</b>
	/// </summary>
	public readonly uint FloatInstructionCount {
		get => _floatInstructionCount;
		init => _floatInstructionCount = value;
	}
	readonly uint _floatInstructionCount;

	/// <summary>
	/// <b>UINT IntInstructionCount</b>
	/// </summary>
	public readonly uint IntInstructionCount {
		get => _intInstructionCount;
		init => _intInstructionCount = value;
	}
	readonly uint _intInstructionCount;

	/// <summary>
	/// <b>UINT UintInstructionCount</b>
	/// </summary>
	public readonly uint UintInstructionCount {
		get => _uintInstructionCount;
		init => _uintInstructionCount = value;
	}
	readonly uint _uintInstructionCount;

	/// <summary>
	/// <b>UINT StaticFlowControlCount</b>
	/// </summary>
	public readonly uint StaticFlowControlCount {
		get => _staticFlowControlCount;
		init => _staticFlowControlCount = value;
	}
	readonly uint _staticFlowControlCount;

	/// <summary>
	/// <b>UINT DynamicFlowControlCount</b>
	/// </summary>
	public readonly uint DynamicFlowControlCount {
		get => _dynamicFlowControlCount;
		init => _dynamicFlowControlCount = value;
	}
	readonly uint _dynamicFlowControlCount;

	/// <summary>
	/// <b>UINT MacroInstructionCount</b>
	/// </summary>
	public readonly uint MacroInstructionCount {
		get => _macroInstructionCount;
		init => _macroInstructionCount = value;
	}
	readonly uint _macroInstructionCount;

	/// <summary>
	/// <b>UINT ArrayInstructionCount</b>
	/// </summary>
	public readonly uint ArrayInstructionCount {
		get => _arrayInstructionCount;
		init => _arrayInstructionCount = value;
	}
	readonly uint _arrayInstructionCount;

	/// <summary>
	/// <b>UINT MovInstructionCount</b>
	/// </summary>
	public readonly uint MovInstructionCount {
		get => _movInstructionCount;
		init => _movInstructionCount = value;
	}
	readonly uint _movInstructionCount;

	/// <summary>
	/// <b>UINT MovcInstructionCount</b>
	/// </summary>
	public readonly uint MovcInstructionCount {
		get => _movcInstructionCount;
		init => _movcInstructionCount = value;
	}
	readonly uint _movcInstructionCount;

	/// <summary>
	/// <b>UINT ConversionInstructionCount</b>
	/// </summary>
	public readonly uint ConversionInstructionCount {
		get => _conversionInstructionCount;
		init => _conversionInstructionCount = value;
	}
	readonly uint _conversionInstructionCount;

	/// <summary>
	/// <b>UINT BitwiseInstructionCount</b>
	/// </summary>
	public readonly uint BitwiseInstructionCount {
		get => _bitwiseInstructionCount;
		init => _bitwiseInstructionCount = value;
	}
	readonly uint _bitwiseInstructionCount;

	/// <summary>
	/// <b>D3D_FEATURE_LEVEL MinFeatureLevel</b>
	/// </summary>
	public readonly Direct3D.FeatureLevel MinFeatureLevel {
		get => _minFeatureLevel;
		init => _minFeatureLevel = value;
	}
	readonly Direct3D.FeatureLevel _minFeatureLevel;

	/// <summary>
	/// <b>UINT64 RequiredFeatureFlags</b>
	/// </summary>
	public readonly ulong RequiredFeatureFlags {
		get => _requiredFeatureFlags;
		init => _requiredFeatureFlags = value;
	}
	readonly ulong _requiredFeatureFlags;

	/// <summary>
	/// <b>LPCSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>INT FunctionParameterCount</b>
	/// </summary>
	public readonly int FunctionParameterCount {
		get => _functionParameterCount;
		init => _functionParameterCount = value;
	}
	readonly int _functionParameterCount;

	/// <summary>
	/// <b>BOOL HasReturn</b>
	/// </summary>
	public readonly bool HasReturn {
		get => _hasReturn != 0;
		init => _hasReturn = value ? 1U : 0U;
	}
	readonly uint _hasReturn;

	/// <summary>
	/// <b>BOOL Has10Level9VertexShader</b>
	/// </summary>
	public readonly bool Has10Level9VertexShader {
		get => _has10Level9VertexShader != 0;
		init => _has10Level9VertexShader = value ? 1U : 0U;
	}
	readonly uint _has10Level9VertexShader;

	/// <summary>
	/// <b>BOOL Has10Level9PixelShader</b>
	/// </summary>
	public readonly bool Has10Level9PixelShader {
		get => _has10Level9PixelShader != 0;
		init => _has10Level9PixelShader = value ? 1U : 0U;
	}
	readonly uint _has10Level9PixelShader;

}

/// <summary>
/// STRUCTURE <b>_D3D12_PARAMETER_DESC</b> (D3D12_PARAMETER_DESC)<br/>
/// D3D12SHADER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ParameterDesc {

	/// <summary>
	/// <b>LPCSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>LPCSTR SemanticName</b>
	/// </summary>
	public readonly char* SemanticName {
		get => _semanticName;
		init => _semanticName = value;
	}
	readonly char* _semanticName;

	/// <summary>
	/// <b>D3D_SHADER_VARIABLE_TYPE Type</b>
	/// </summary>
	public readonly Direct3D.ShaderVariableType Type {
		get => _type;
		init => _type = value;
	}
	readonly Direct3D.ShaderVariableType _type;

	/// <summary>
	/// <b>D3D_SHADER_VARIABLE_CLASS Class</b>
	/// </summary>
	public readonly Direct3D.ShaderVariableClass Class {
		get => _class;
		init => _class = value;
	}
	readonly Direct3D.ShaderVariableClass _class;

	/// <summary>
	/// <b>UINT Rows</b>
	/// </summary>
	public readonly uint Rows {
		get => _rows;
		init => _rows = value;
	}
	readonly uint _rows;

	/// <summary>
	/// <b>UINT Columns</b>
	/// </summary>
	public readonly uint Columns {
		get => _columns;
		init => _columns = value;
	}
	readonly uint _columns;

	/// <summary>
	/// <b>D3D_INTERPOLATION_MODE InterpolationMode</b>
	/// </summary>
	public readonly Direct3D.InterpolationMode InterpolationMode {
		get => _interpolationMode;
		init => _interpolationMode = value;
	}
	readonly Direct3D.InterpolationMode _interpolationMode;

	/// <summary>
	/// <b>D3D_PARAMETER_FLAGS Flags</b>
	/// </summary>
	public readonly Direct3D.ParameterFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly Direct3D.ParameterFlags _flags;

	/// <summary>
	/// <b>UINT FirstInRegister</b>
	/// </summary>
	public readonly uint FirstInRegister {
		get => _firstInRegister;
		init => _firstInRegister = value;
	}
	readonly uint _firstInRegister;

	/// <summary>
	/// <b>UINT FirstInComponent</b>
	/// </summary>
	public readonly uint FirstInComponent {
		get => _firstInComponent;
		init => _firstInComponent = value;
	}
	readonly uint _firstInComponent;

	/// <summary>
	/// <b>UINT FirstOutRegister</b>
	/// </summary>
	public readonly uint FirstOutRegister {
		get => _firstOutRegister;
		init => _firstOutRegister = value;
	}
	readonly uint _firstOutRegister;

	/// <summary>
	/// <b>UINT FirstOutComponent</b>
	/// </summary>
	public readonly uint FirstOutComponent {
		get => _firstOutComponent;
		init => _firstOutComponent = value;
	}
	readonly uint _firstOutComponent;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_FORMAT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoFormat {

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE ColorSpace</b>
	/// </summary>
	public readonly DXGI.ColorSpaceType ColorSpace {
		get => _colorSpace;
		init => _colorSpace = value;
	}
	readonly DXGI.ColorSpaceType _colorSpace;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_SAMPLE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoSample {

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>D3D12_VIDEO_FORMAT Format</b>
	/// </summary>
	public readonly VideoFormat Format {
		get => _format;
		init => _format = value;
	}
	readonly VideoFormat _format;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_CONFIGURATION</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeConfiguration {

	/// <summary>
	/// <b>GUID DecodeProfile</b>
	/// </summary>
	public readonly Guid DecodeProfile {
		get => _decodeProfile;
		init => _decodeProfile = value;
	}
	readonly Guid _decodeProfile;

	/// <summary>
	/// <b>D3D12_BITSTREAM_ENCRYPTION_TYPE BitstreamEncryption</b>
	/// </summary>
	public readonly BitstreamEncryptionType BitstreamEncryption {
		get => _bitstreamEncryption;
		init => _bitstreamEncryption = value;
	}
	readonly BitstreamEncryptionType _bitstreamEncryption;

	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE InterlaceType</b>
	/// </summary>
	public readonly VideoFrameCodedInterlaceType InterlaceType {
		get => _interlaceType;
		init => _interlaceType = value;
	}
	readonly VideoFrameCodedInterlaceType _interlaceType;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODER_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION Configuration</b>
	/// </summary>
	public readonly VideoDecodeConfiguration Configuration {
		get => _configuration;
		init => _configuration = value;
	}
	readonly VideoDecodeConfiguration _configuration;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODER_HEAP_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderHeapDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION Configuration</b>
	/// </summary>
	public readonly VideoDecodeConfiguration Configuration {
		get => _configuration;
		init => _configuration = value;
	}
	readonly VideoDecodeConfiguration _configuration;

	/// <summary>
	/// <b>UINT DecodeWidth</b>
	/// </summary>
	public readonly uint DecodeWidth {
		get => _decodeWidth;
		init => _decodeWidth = value;
	}
	readonly uint _decodeWidth;

	/// <summary>
	/// <b>UINT DecodeHeight</b>
	/// </summary>
	public readonly uint DecodeHeight {
		get => _decodeHeight;
		init => _decodeHeight = value;
	}
	readonly uint _decodeHeight;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>DXGI_RATIONAL FrameRate</b>
	/// </summary>
	public readonly DXGI.Rational FrameRate {
		get => _frameRate;
		init => _frameRate = value;
	}
	readonly DXGI.Rational _frameRate;

	/// <summary>
	/// <b>UINT BitRate</b>
	/// </summary>
	public readonly uint BitRate {
		get => _bitRate;
		init => _bitRate = value;
	}
	readonly uint _bitRate;

	/// <summary>
	/// <b>UINT MaxDecodePictureBufferCount</b>
	/// </summary>
	public readonly uint MaxDecodePictureBufferCount {
		get => _maxDecodePictureBufferCount;
		init => _maxDecodePictureBufferCount = value;
	}
	readonly uint _maxDecodePictureBufferCount;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_SIZE_RANGE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoSizeRange {

	/// <summary>
	/// <b>UINT MaxWidth</b>
	/// </summary>
	public readonly uint MaxWidth {
		get => _maxWidth;
		init => _maxWidth = value;
	}
	readonly uint _maxWidth;

	/// <summary>
	/// <b>UINT MaxHeight</b>
	/// </summary>
	public readonly uint MaxHeight {
		get => _maxHeight;
		init => _maxHeight = value;
	}
	readonly uint _maxHeight;

	/// <summary>
	/// <b>UINT MinWidth</b>
	/// </summary>
	public readonly uint MinWidth {
		get => _minWidth;
		init => _minWidth = value;
	}
	readonly uint _minWidth;

	/// <summary>
	/// <b>UINT MinHeight</b>
	/// </summary>
	public readonly uint MinHeight {
		get => _minHeight;
		init => _minHeight = value;
	}
	readonly uint _minHeight;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_ALPHA_BLENDING</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessAlphaBlending {

	/// <summary>
	/// <b>BOOL Enable</b>
	/// </summary>
	public readonly bool Enable {
		get => _enable != 0;
		init => _enable = value ? 1U : 0U;
	}
	readonly uint _enable;

	/// <summary>
	/// <b>FLOAT Alpha</b>
	/// </summary>
	public readonly float Alpha {
		get => _alpha;
		init => _alpha = value;
	}
	readonly float _alpha;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_LUMA_KEY</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessLumaKey {

	/// <summary>
	/// <b>BOOL Enable</b>
	/// </summary>
	public readonly bool Enable {
		get => _enable != 0;
		init => _enable = value ? 1U : 0U;
	}
	readonly uint _enable;

	/// <summary>
	/// <b>FLOAT Lower</b>
	/// </summary>
	public readonly float Lower {
		get => _lower;
		init => _lower = value;
	}
	readonly float _lower;

	/// <summary>
	/// <b>FLOAT Upper</b>
	/// </summary>
	public readonly float Upper {
		get => _upper;
		init => _upper = value;
	}
	readonly float _upper;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessInputStreamDesc {

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE ColorSpace</b>
	/// </summary>
	public readonly DXGI.ColorSpaceType ColorSpace {
		get => _colorSpace;
		init => _colorSpace = value;
	}
	readonly DXGI.ColorSpaceType _colorSpace;

	/// <summary>
	/// <b>DXGI_RATIONAL SourceAspectRatio</b>
	/// </summary>
	public readonly DXGI.Rational SourceAspectRatio {
		get => _sourceAspectRatio;
		init => _sourceAspectRatio = value;
	}
	readonly DXGI.Rational _sourceAspectRatio;

	/// <summary>
	/// <b>DXGI_RATIONAL DestinationAspectRatio</b>
	/// </summary>
	public readonly DXGI.Rational DestinationAspectRatio {
		get => _destinationAspectRatio;
		init => _destinationAspectRatio = value;
	}
	readonly DXGI.Rational _destinationAspectRatio;

	/// <summary>
	/// <b>DXGI_RATIONAL FrameRate</b>
	/// </summary>
	public readonly DXGI.Rational FrameRate {
		get => _frameRate;
		init => _frameRate = value;
	}
	readonly DXGI.Rational _frameRate;

	/// <summary>
	/// <b>D3D12_VIDEO_SIZE_RANGE SourceSizeRange</b>
	/// </summary>
	public readonly VideoSizeRange SourceSizeRange {
		get => _sourceSizeRange;
		init => _sourceSizeRange = value;
	}
	readonly VideoSizeRange _sourceSizeRange;

	/// <summary>
	/// <b>D3D12_VIDEO_SIZE_RANGE DestinationSizeRange</b>
	/// </summary>
	public readonly VideoSizeRange DestinationSizeRange {
		get => _destinationSizeRange;
		init => _destinationSizeRange = value;
	}
	readonly VideoSizeRange _destinationSizeRange;

	/// <summary>
	/// <b>BOOL EnableOrientation</b>
	/// </summary>
	public readonly bool EnableOrientation {
		get => _enableOrientation != 0;
		init => _enableOrientation = value ? 1U : 0U;
	}
	readonly uint _enableOrientation;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterFlags</b>
	/// </summary>
	public readonly VideoProcessFilterFlags FilterFlags {
		get => _filterFlags;
		init => _filterFlags = value;
	}
	readonly VideoProcessFilterFlags _filterFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT StereoFormat</b>
	/// </summary>
	public readonly VideoFrameStereoFormat StereoFormat {
		get => _stereoFormat;
		init => _stereoFormat = value;
	}
	readonly VideoFrameStereoFormat _stereoFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_FIELD_TYPE FieldType</b>
	/// </summary>
	public readonly VideoFieldType FieldType {
		get => _fieldType;
		init => _fieldType = value;
	}
	readonly VideoFieldType _fieldType;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode</b>
	/// </summary>
	public readonly VideoProcessDeinterlaceFlags DeinterlaceMode {
		get => _deinterlaceMode;
		init => _deinterlaceMode = value;
	}
	readonly VideoProcessDeinterlaceFlags _deinterlaceMode;

	/// <summary>
	/// <b>BOOL EnableAlphaBlending</b>
	/// </summary>
	public readonly bool EnableAlphaBlending {
		get => _enableAlphaBlending != 0;
		init => _enableAlphaBlending = value ? 1U : 0U;
	}
	readonly uint _enableAlphaBlending;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_LUMA_KEY LumaKey</b>
	/// </summary>
	public readonly VideoProcessLumaKey LumaKey {
		get => _lumaKey;
		init => _lumaKey = value;
	}
	readonly VideoProcessLumaKey _lumaKey;

	/// <summary>
	/// <b>UINT NumPastFrames</b>
	/// </summary>
	public readonly uint NumPastFrames {
		get => _numPastFrames;
		init => _numPastFrames = value;
	}
	readonly uint _numPastFrames;

	/// <summary>
	/// <b>UINT NumFutureFrames</b>
	/// </summary>
	public readonly uint NumFutureFrames {
		get => _numFutureFrames;
		init => _numFutureFrames = value;
	}
	readonly uint _numFutureFrames;

	/// <summary>
	/// <b>BOOL EnableAutoProcessing</b>
	/// </summary>
	public readonly bool EnableAutoProcessing {
		get => _enableAutoProcessing != 0;
		init => _enableAutoProcessing = value ? 1U : 0U;
	}
	readonly uint _enableAutoProcessing;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessOutputStreamDesc {

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE ColorSpace</b>
	/// </summary>
	public readonly DXGI.ColorSpaceType ColorSpace {
		get => _colorSpace;
		init => _colorSpace = value;
	}
	readonly DXGI.ColorSpaceType _colorSpace;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE AlphaFillMode</b>
	/// </summary>
	public readonly VideoProcessAlphaFillMode AlphaFillMode {
		get => _alphaFillMode;
		init => _alphaFillMode = value;
	}
	readonly VideoProcessAlphaFillMode _alphaFillMode;

	/// <summary>
	/// <b>UINT AlphaFillModeSourceStreamIndex</b>
	/// </summary>
	public readonly uint AlphaFillModeSourceStreamIndex {
		get => _alphaFillModeSourceStreamIndex;
		init => _alphaFillModeSourceStreamIndex = value;
	}
	readonly uint _alphaFillModeSourceStreamIndex;

	/// <summary>
	/// <b>FLOAT BackgroundColor [4]</b>
	/// </summary>
	public readonly Span<float> BackgroundColor {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _backgroundColor)), 4);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_129 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [4];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_129 _backgroundColor;

	/// <summary>
	/// <b>DXGI_RATIONAL FrameRate</b>
	/// </summary>
	public readonly DXGI.Rational FrameRate {
		get => _frameRate;
		init => _frameRate = value;
	}
	readonly DXGI.Rational _frameRate;

	/// <summary>
	/// <b>BOOL EnableStereo</b>
	/// </summary>
	public readonly bool EnableStereo {
		get => _enableStereo != 0;
		init => _enableStereo = value ? 1U : 0U;
	}
	readonly uint _enableStereo;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION Configuration</b>
	/// </summary>
	public readonly VideoDecodeConfiguration Configuration {
		get => _configuration;
		init => _configuration = value;
	}
	readonly VideoDecodeConfiguration _configuration;

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>DXGI_FORMAT DecodeFormat</b>
	/// </summary>
	public readonly DXGI.Format DecodeFormat {
		get => _decodeFormat;
		init => _decodeFormat = value;
	}
	readonly DXGI.Format _decodeFormat;

	/// <summary>
	/// <b>DXGI_RATIONAL FrameRate</b>
	/// </summary>
	public readonly DXGI.Rational FrameRate {
		get => _frameRate;
		init => _frameRate = value;
	}
	readonly DXGI.Rational _frameRate;

	/// <summary>
	/// <b>UINT BitRate</b>
	/// </summary>
	public readonly uint BitRate {
		get => _bitRate;
		init => _bitRate = value;
	}
	readonly uint _bitRate;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoDecodeSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoDecodeSupportFlags _supportFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS ConfigurationFlags</b>
	/// </summary>
	public readonly VideoDecodeConfigurationFlags ConfigurationFlags {
		get => _configurationFlags;
		init => _configurationFlags = value;
	}
	readonly VideoDecodeConfigurationFlags _configurationFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_TIER DecodeTier</b>
	/// </summary>
	public readonly VideoDecodeTier DecodeTier {
		get => _decodeTier;
		init => _decodeTier = value;
	}
	readonly VideoDecodeTier _decodeTier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILE_COUNT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeProfileCount {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>UINT ProfileCount</b>
	/// </summary>
	public readonly uint ProfileCount {
		get => _profileCount;
		init => _profileCount = value;
	}
	readonly uint _profileCount;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeProfiles {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>UINT ProfileCount</b>
	/// </summary>
	public readonly uint ProfileCount {
		get => _profileCount;
		init => _profileCount = value;
	}
	readonly uint _profileCount;

	/// <summary>
	/// <b>GUID* pProfiles</b>
	/// </summary>
	public readonly Guid* PProfiles {
		get => _pProfiles;
		init => _pProfiles = value;
	}
	readonly Guid* _pProfiles;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_FORMAT_COUNT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeFormatCount {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION Configuration</b>
	/// </summary>
	public readonly VideoDecodeConfiguration Configuration {
		get => _configuration;
		init => _configuration = value;
	}
	readonly VideoDecodeConfiguration _configuration;

	/// <summary>
	/// <b>UINT FormatCount</b>
	/// </summary>
	public readonly uint FormatCount {
		get => _formatCount;
		init => _formatCount = value;
	}
	readonly uint _formatCount;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeFormats {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION Configuration</b>
	/// </summary>
	public readonly VideoDecodeConfiguration Configuration {
		get => _configuration;
		init => _configuration = value;
	}
	readonly VideoDecodeConfiguration _configuration;

	/// <summary>
	/// <b>UINT FormatCount</b>
	/// </summary>
	public readonly uint FormatCount {
		get => _formatCount;
		init => _formatCount = value;
	}
	readonly uint _formatCount;

	/// <summary>
	/// <b>DXGI_FORMAT* pOutputFormats</b>
	/// </summary>
	public readonly DXGI.Format* POutputFormats {
		get => _pOutputFormats;
		init => _pOutputFormats = value;
	}
	readonly DXGI.Format* _pOutputFormats;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoArchitecture {

	/// <summary>
	/// <b>BOOL IOCoherent</b>
	/// </summary>
	public readonly bool IOCoherent {
		get => _iOCoherent != 0;
		init => _iOCoherent = value ? 1U : 0U;
	}
	readonly uint _iOCoherent;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeHistogram {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>GUID DecodeProfile</b>
	/// </summary>
	public readonly Guid DecodeProfile {
		get => _decodeProfile;
		init => _decodeProfile = value;
	}
	readonly Guid _decodeProfile;

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>DXGI_FORMAT DecodeFormat</b>
	/// </summary>
	public readonly DXGI.Format DecodeFormat {
		get => _decodeFormat;
		init => _decodeFormat = value;
	}
	readonly DXGI.Format _decodeFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS Components</b>
	/// </summary>
	public readonly VideoDecodeHistogramComponentFlags Components {
		get => _components;
		init => _components = value;
	}
	readonly VideoDecodeHistogramComponentFlags _components;

	/// <summary>
	/// <b>UINT BinCount</b>
	/// </summary>
	public readonly uint BinCount {
		get => _binCount;
		init => _binCount = value;
	}
	readonly uint _binCount;

	/// <summary>
	/// <b>UINT CounterBitDepth</b>
	/// </summary>
	public readonly uint CounterBitDepth {
		get => _counterBitDepth;
		init => _counterBitDepth = value;
	}
	readonly uint _counterBitDepth;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_SCALE_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoScaleSupport {

	/// <summary>
	/// <b>D3D12_VIDEO_SIZE_RANGE OutputSizeRange</b>
	/// </summary>
	public readonly VideoSizeRange OutputSizeRange {
		get => _outputSizeRange;
		init => _outputSizeRange = value;
	}
	readonly VideoSizeRange _outputSizeRange;

	/// <summary>
	/// <b>D3D12_VIDEO_SCALE_SUPPORT_FLAGS Flags</b>
	/// </summary>
	public readonly VideoScaleSupportFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoScaleSupportFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeConversionSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION Configuration</b>
	/// </summary>
	public readonly VideoDecodeConfiguration Configuration {
		get => _configuration;
		init => _configuration = value;
	}
	readonly VideoDecodeConfiguration _configuration;

	/// <summary>
	/// <b>D3D12_VIDEO_SAMPLE DecodeSample</b>
	/// </summary>
	public readonly VideoSample DecodeSample {
		get => _decodeSample;
		init => _decodeSample = value;
	}
	readonly VideoSample _decodeSample;

	/// <summary>
	/// <b>D3D12_VIDEO_FORMAT OutputFormat</b>
	/// </summary>
	public readonly VideoFormat OutputFormat {
		get => _outputFormat;
		init => _outputFormat = value;
	}
	readonly VideoFormat _outputFormat;

	/// <summary>
	/// <b>DXGI_RATIONAL FrameRate</b>
	/// </summary>
	public readonly DXGI.Rational FrameRate {
		get => _frameRate;
		init => _frameRate = value;
	}
	readonly DXGI.Rational _frameRate;

	/// <summary>
	/// <b>UINT BitRate</b>
	/// </summary>
	public readonly uint BitRate {
		get => _bitRate;
		init => _bitRate = value;
	}
	readonly uint _bitRate;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoDecodeConversionSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoDecodeConversionSupportFlags _supportFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_SCALE_SUPPORT ScaleSupport</b>
	/// </summary>
	public readonly VideoScaleSupport ScaleSupport {
		get => _scaleSupport;
		init => _scaleSupport = value;
	}
	readonly VideoScaleSupport _scaleSupport;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecoderHeapSize {

	/// <summary>
	/// <b>D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc</b>
	/// </summary>
	public readonly VideoDecoderHeapDesc VideoDecoderHeapDesc {
		get => _videoDecoderHeapDesc;
		init => _videoDecoderHeapDesc = value;
	}
	readonly VideoDecoderHeapDesc _videoDecoderHeapDesc;

	/// <summary>
	/// <b>UINT64 MemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL0Size {
		get => _memoryPoolL0Size;
		init => _memoryPoolL0Size = value;
	}
	readonly ulong _memoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL1Size {
		get => _memoryPoolL1Size;
		init => _memoryPoolL1Size = value;
	}
	readonly ulong _memoryPoolL1Size;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoProcessorSize {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc</b>
	/// </summary>
	public readonly VideoProcessOutputStreamDesc* POutputStreamDesc {
		get => _pOutputStreamDesc;
		init => _pOutputStreamDesc = value;
	}
	readonly VideoProcessOutputStreamDesc* _pOutputStreamDesc;

	/// <summary>
	/// <b>UINT NumInputStreamDescs</b>
	/// </summary>
	public readonly uint NumInputStreamDescs {
		get => _numInputStreamDescs;
		init => _numInputStreamDescs = value;
	}
	readonly uint _numInputStreamDescs;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs</b>
	/// </summary>
	public readonly VideoProcessInputStreamDesc* PInputStreamDescs {
		get => _pInputStreamDescs;
		init => _pInputStreamDescs = value;
	}
	readonly VideoProcessInputStreamDesc* _pInputStreamDescs;

	/// <summary>
	/// <b>UINT64 MemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL0Size {
		get => _memoryPoolL0Size;
		init => _memoryPoolL0Size = value;
	}
	readonly ulong _memoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL1Size {
		get => _memoryPoolL1Size;
		init => _memoryPoolL1Size = value;
	}
	readonly ulong _memoryPoolL1Size;

}

/// <summary>
/// STRUCTURE <b>D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryDataVideoDecodeStatistics {

	/// <summary>
	/// <b>UINT64 Status</b>
	/// </summary>
	public readonly ulong Status {
		get => _status;
		init => _status = value;
	}
	readonly ulong _status;

	/// <summary>
	/// <b>UINT64 NumMacroblocksAffected</b>
	/// </summary>
	public readonly ulong NumMacroblocksAffected {
		get => _numMacroblocksAffected;
		init => _numMacroblocksAffected = value;
	}
	readonly ulong _numMacroblocksAffected;

	/// <summary>
	/// <b>DXGI_RATIONAL FrameRate</b>
	/// </summary>
	public readonly DXGI.Rational FrameRate {
		get => _frameRate;
		init => _frameRate = value;
	}
	readonly DXGI.Rational _frameRate;

	/// <summary>
	/// <b>UINT BitRate</b>
	/// </summary>
	public readonly uint BitRate {
		get => _bitRate;
		init => _bitRate = value;
	}
	readonly uint _bitRate;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_FRAME_ARGUMENT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeFrameArgument {

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_ARGUMENT_TYPE Type</b>
	/// </summary>
	public readonly VideoDecodeArgumentType Type {
		get => _type;
		init => _type = value;
	}
	readonly VideoDecodeArgumentType _type;

	/// <summary>
	/// <b>UINT Size</b>
	/// </summary>
	public readonly uint Size {
		get => _size;
		init => _size = value;
	}
	readonly uint _size;

	/// <summary>
	/// <b>void* pData</b>
	/// </summary>
	public readonly void* PData {
		get => _pData;
		init => _pData = value;
	}
	readonly void* _pData;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_REFERENCE_FRAMES</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeReferenceFrames {

	/// <summary>
	/// <b>UINT NumTexture2Ds</b>
	/// </summary>
	public readonly uint NumTexture2Ds {
		get => _numTexture2Ds;
		init => _numTexture2Ds = value;
	}
	readonly uint _numTexture2Ds;

	/// <summary>
	/// <b>ID3D12Resource** ppTexture2Ds</b>
	/// </summary>
	public readonly T** PpTexture2Ds<T> () where T : unmanaged, IResource => (T**) _ppTexture2Ds;
	readonly void* _ppTexture2Ds;

	/// <summary>
	/// <b>UINT* pSubresources</b>
	/// </summary>
	public readonly uint* PSubresources {
		get => _pSubresources;
		init => _pSubresources = value;
	}
	readonly uint* _pSubresources;

	/// <summary>
	/// <b>ID3D12VideoDecoderHeap** ppHeaps</b>
	/// </summary>
	public readonly T** PpHeaps<T> () where T : unmanaged, IVideoDecoderHeap => (T**) _ppHeaps;
	readonly void* _ppHeaps;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeCompressedBitstream {

	/// <summary>
	/// <b>ID3D12Resource* pBuffer</b>
	/// </summary>
	public readonly T* PBuffer<T> () where T : unmanaged, IResource => (T*) _pBuffer;
	readonly void* _pBuffer;

	/// <summary>
	/// <b>UINT64 Offset</b>
	/// </summary>
	public readonly ulong Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly ulong _offset;

	/// <summary>
	/// <b>UINT64 Size</b>
	/// </summary>
	public readonly ulong Size {
		get => _size;
		init => _size = value;
	}
	readonly ulong _size;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeConversionArguments {

	/// <summary>
	/// <b>BOOL Enable</b>
	/// </summary>
	public readonly bool Enable {
		get => _enable != 0;
		init => _enable = value ? 1U : 0U;
	}
	readonly uint _enable;

	/// <summary>
	/// <b>ID3D12Resource* pReferenceTexture2D</b>
	/// </summary>
	public readonly T* PReferenceTexture2D<T> () where T : unmanaged, IResource => (T*) _pReferenceTexture2D;
	readonly void* _pReferenceTexture2D;

	/// <summary>
	/// <b>UINT ReferenceSubresource</b>
	/// </summary>
	public readonly uint ReferenceSubresource {
		get => _referenceSubresource;
		init => _referenceSubresource = value;
	}
	readonly uint _referenceSubresource;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE OutputColorSpace</b>
	/// </summary>
	public readonly DXGI.ColorSpaceType OutputColorSpace {
		get => _outputColorSpace;
		init => _outputColorSpace = value;
	}
	readonly DXGI.ColorSpaceType _outputColorSpace;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE DecodeColorSpace</b>
	/// </summary>
	public readonly DXGI.ColorSpaceType DecodeColorSpace {
		get => _decodeColorSpace;
		init => _decodeColorSpace = value;
	}
	readonly DXGI.ColorSpaceType _decodeColorSpace;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeInputStreamArguments {

	/// <summary>
	/// <b>UINT NumFrameArguments</b>
	/// </summary>
	public readonly uint NumFrameArguments {
		get => _numFrameArguments;
		init => _numFrameArguments = value;
	}
	readonly uint _numFrameArguments;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_FRAME_ARGUMENT FrameArguments [10]</b>
	/// </summary>
	public readonly Span<VideoDecodeFrameArgument> FrameArguments {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _frameArguments)), 10);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_130 {
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_0;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_1;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_2;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_3;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_4;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_5;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_6;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_7;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_8;
		public VideoDecodeFrameArgument _ASP_AUTO_GENERATED_FIELD_9;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_130 _frameArguments;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_REFERENCE_FRAMES ReferenceFrames</b>
	/// </summary>
	public readonly VideoDecodeReferenceFrames ReferenceFrames {
		get => _referenceFrames;
		init => _referenceFrames = value;
	}
	readonly VideoDecodeReferenceFrames _referenceFrames;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM CompressedBitstream</b>
	/// </summary>
	public readonly VideoDecodeCompressedBitstream CompressedBitstream {
		get => _compressedBitstream;
		init => _compressedBitstream = value;
	}
	readonly VideoDecodeCompressedBitstream _compressedBitstream;

	/// <summary>
	/// <b>ID3D12VideoDecoderHeap* pHeap</b>
	/// </summary>
	public readonly T* PHeap<T> () where T : unmanaged, IVideoDecoderHeap => (T*) _pHeap;
	readonly void* _pHeap;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeOutputStreamArguments {

	/// <summary>
	/// <b>ID3D12Resource* pOutputTexture2D</b>
	/// </summary>
	public readonly T* POutputTexture2D<T> () where T : unmanaged, IResource => (T*) _pOutputTexture2D;
	readonly void* _pOutputTexture2D;

	/// <summary>
	/// <b>UINT OutputSubresource</b>
	/// </summary>
	public readonly uint OutputSubresource {
		get => _outputSubresource;
		init => _outputSubresource = value;
	}
	readonly uint _outputSubresource;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS ConversionArguments</b>
	/// </summary>
	public readonly VideoDecodeConversionArguments ConversionArguments {
		get => _conversionArguments;
		init => _conversionArguments = value;
	}
	readonly VideoDecodeConversionArguments _conversionArguments;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_FILTER_RANGE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessFilterRange {

	/// <summary>
	/// <b>INT Minimum</b>
	/// </summary>
	public readonly int Minimum {
		get => _minimum;
		init => _minimum = value;
	}
	readonly int _minimum;

	/// <summary>
	/// <b>INT Maximum</b>
	/// </summary>
	public readonly int Maximum {
		get => _maximum;
		init => _maximum = value;
	}
	readonly int _maximum;

	/// <summary>
	/// <b>INT Default</b>
	/// </summary>
	public readonly int Default {
		get => _default;
		init => _default = value;
	}
	readonly int _default;

	/// <summary>
	/// <b>FLOAT Multiplier</b>
	/// </summary>
	public readonly float Multiplier {
		get => _multiplier;
		init => _multiplier = value;
	}
	readonly float _multiplier;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoProcessSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_SAMPLE InputSample</b>
	/// </summary>
	public readonly VideoSample InputSample {
		get => _inputSample;
		init => _inputSample = value;
	}
	readonly VideoSample _inputSample;

	/// <summary>
	/// <b>D3D12_VIDEO_FIELD_TYPE InputFieldType</b>
	/// </summary>
	public readonly VideoFieldType InputFieldType {
		get => _inputFieldType;
		init => _inputFieldType = value;
	}
	readonly VideoFieldType _inputFieldType;

	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat</b>
	/// </summary>
	public readonly VideoFrameStereoFormat InputStereoFormat {
		get => _inputStereoFormat;
		init => _inputStereoFormat = value;
	}
	readonly VideoFrameStereoFormat _inputStereoFormat;

	/// <summary>
	/// <b>DXGI_RATIONAL InputFrameRate</b>
	/// </summary>
	public readonly DXGI.Rational InputFrameRate {
		get => _inputFrameRate;
		init => _inputFrameRate = value;
	}
	readonly DXGI.Rational _inputFrameRate;

	/// <summary>
	/// <b>D3D12_VIDEO_FORMAT OutputFormat</b>
	/// </summary>
	public readonly VideoFormat OutputFormat {
		get => _outputFormat;
		init => _outputFormat = value;
	}
	readonly VideoFormat _outputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat</b>
	/// </summary>
	public readonly VideoFrameStereoFormat OutputStereoFormat {
		get => _outputStereoFormat;
		init => _outputStereoFormat = value;
	}
	readonly VideoFrameStereoFormat _outputStereoFormat;

	/// <summary>
	/// <b>DXGI_RATIONAL OutputFrameRate</b>
	/// </summary>
	public readonly DXGI.Rational OutputFrameRate {
		get => _outputFrameRate;
		init => _outputFrameRate = value;
	}
	readonly DXGI.Rational _outputFrameRate;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoProcessSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoProcessSupportFlags _supportFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_SCALE_SUPPORT ScaleSupport</b>
	/// </summary>
	public readonly VideoScaleSupport ScaleSupport {
		get => _scaleSupport;
		init => _scaleSupport = value;
	}
	readonly VideoScaleSupport _scaleSupport;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport</b>
	/// </summary>
	public readonly VideoProcessFeatureFlags FeatureSupport {
		get => _featureSupport;
		init => _featureSupport = value;
	}
	readonly VideoProcessFeatureFlags _featureSupport;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport</b>
	/// </summary>
	public readonly VideoProcessDeinterlaceFlags DeinterlaceSupport {
		get => _deinterlaceSupport;
		init => _deinterlaceSupport = value;
	}
	readonly VideoProcessDeinterlaceFlags _deinterlaceSupport;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport</b>
	/// </summary>
	public readonly VideoProcessAutoProcessingFlags AutoProcessingSupport {
		get => _autoProcessingSupport;
		init => _autoProcessingSupport = value;
	}
	readonly VideoProcessAutoProcessingFlags _autoProcessingSupport;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport</b>
	/// </summary>
	public readonly VideoProcessFilterFlags FilterSupport {
		get => _filterSupport;
		init => _filterSupport = value;
	}
	readonly VideoProcessFilterFlags _filterSupport;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_RANGE FilterRangeSupport [32]</b>
	/// </summary>
	public readonly Span<VideoProcessFilterRange> FilterRangeSupport {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _filterRangeSupport)), 32);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_131 {
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_0;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_1;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_2;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_3;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_4;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_5;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_6;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_7;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_8;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_9;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_10;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_11;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_12;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_13;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_14;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_15;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_16;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_17;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_18;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_19;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_20;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_21;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_22;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_23;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_24;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_25;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_26;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_27;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_28;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_29;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_30;
		public VideoProcessFilterRange _ASP_AUTO_GENERATED_FIELD_31;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_131 _filterRangeSupport;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoProcessMaxInputStreams {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>UINT MaxInputStreams</b>
	/// </summary>
	public readonly uint MaxInputStreams {
		get => _maxInputStreams;
		init => _maxInputStreams = value;
	}
	readonly uint _maxInputStreams;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoProcessReferenceInfo {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode</b>
	/// </summary>
	public readonly VideoProcessDeinterlaceFlags DeinterlaceMode {
		get => _deinterlaceMode;
		init => _deinterlaceMode = value;
	}
	readonly VideoProcessDeinterlaceFlags _deinterlaceMode;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FILTER_FLAGS Filters</b>
	/// </summary>
	public readonly VideoProcessFilterFlags Filters {
		get => _filters;
		init => _filters = value;
	}
	readonly VideoProcessFilterFlags _filters;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport</b>
	/// </summary>
	public readonly VideoProcessFeatureFlags FeatureSupport {
		get => _featureSupport;
		init => _featureSupport = value;
	}
	readonly VideoProcessFeatureFlags _featureSupport;

	/// <summary>
	/// <b>DXGI_RATIONAL InputFrameRate</b>
	/// </summary>
	public readonly DXGI.Rational InputFrameRate {
		get => _inputFrameRate;
		init => _inputFrameRate = value;
	}
	readonly DXGI.Rational _inputFrameRate;

	/// <summary>
	/// <b>DXGI_RATIONAL OutputFrameRate</b>
	/// </summary>
	public readonly DXGI.Rational OutputFrameRate {
		get => _outputFrameRate;
		init => _outputFrameRate = value;
	}
	readonly DXGI.Rational _outputFrameRate;

	/// <summary>
	/// <b>BOOL EnableAutoProcessing</b>
	/// </summary>
	public readonly bool EnableAutoProcessing {
		get => _enableAutoProcessing != 0;
		init => _enableAutoProcessing = value ? 1U : 0U;
	}
	readonly uint _enableAutoProcessing;

	/// <summary>
	/// <b>UINT PastFrames</b>
	/// </summary>
	public readonly uint PastFrames {
		get => _pastFrames;
		init => _pastFrames = value;
	}
	readonly uint _pastFrames;

	/// <summary>
	/// <b>UINT FutureFrames</b>
	/// </summary>
	public readonly uint FutureFrames {
		get => _futureFrames;
		init => _futureFrames = value;
	}
	readonly uint _futureFrames;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_REFERENCE_SET</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessReferenceSet {

	/// <summary>
	/// <b>UINT NumPastFrames</b>
	/// </summary>
	public readonly uint NumPastFrames {
		get => _numPastFrames;
		init => _numPastFrames = value;
	}
	readonly uint _numPastFrames;

	/// <summary>
	/// <b>ID3D12Resource** ppPastFrames</b>
	/// </summary>
	public readonly T** PpPastFrames<T> () where T : unmanaged, IResource => (T**) _ppPastFrames;
	readonly void* _ppPastFrames;

	/// <summary>
	/// <b>UINT* pPastSubresources</b>
	/// </summary>
	public readonly uint* PPastSubresources {
		get => _pPastSubresources;
		init => _pPastSubresources = value;
	}
	readonly uint* _pPastSubresources;

	/// <summary>
	/// <b>UINT NumFutureFrames</b>
	/// </summary>
	public readonly uint NumFutureFrames {
		get => _numFutureFrames;
		init => _numFutureFrames = value;
	}
	readonly uint _numFutureFrames;

	/// <summary>
	/// <b>ID3D12Resource** ppFutureFrames</b>
	/// </summary>
	public readonly T** PpFutureFrames<T> () where T : unmanaged, IResource => (T**) _ppFutureFrames;
	readonly void* _ppFutureFrames;

	/// <summary>
	/// <b>UINT* pFutureSubresources</b>
	/// </summary>
	public readonly uint* PFutureSubresources {
		get => _pFutureSubresources;
		init => _pFutureSubresources = value;
	}
	readonly uint* _pFutureSubresources;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_TRANSFORM</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessTransform {

	/// <summary>
	/// <b>D3D12_RECT SourceRectangle</b>
	/// </summary>
	public readonly Vector4I SourceRectangle {
		get => _sourceRectangle;
		init => _sourceRectangle = value;
	}
	readonly Vector4I _sourceRectangle;

	/// <summary>
	/// <b>D3D12_RECT DestinationRectangle</b>
	/// </summary>
	public readonly Vector4I DestinationRectangle {
		get => _destinationRectangle;
		init => _destinationRectangle = value;
	}
	readonly Vector4I _destinationRectangle;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ORIENTATION Orientation</b>
	/// </summary>
	public readonly VideoProcessOrientation Orientation {
		get => _orientation;
		init => _orientation = value;
	}
	readonly VideoProcessOrientation _orientation;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessInputStreamRate {

	/// <summary>
	/// <b>UINT OutputIndex</b>
	/// </summary>
	public readonly uint OutputIndex {
		get => _outputIndex;
		init => _outputIndex = value;
	}
	readonly uint _outputIndex;

	/// <summary>
	/// <b>UINT InputFrameOrField</b>
	/// </summary>
	public readonly uint InputFrameOrField {
		get => _inputFrameOrField;
		init => _inputFrameOrField = value;
	}
	readonly uint _inputFrameOrField;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_INPUT_STREAM</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessInputStream {

	/// <summary>
	/// <b>ID3D12Resource* pTexture2D</b>
	/// </summary>
	public readonly T* PTexture2D<T> () where T : unmanaged, IResource => (T*) _pTexture2D;
	readonly void* _pTexture2D;

	/// <summary>
	/// <b>UINT Subresource</b>
	/// </summary>
	public readonly uint Subresource {
		get => _subresource;
		init => _subresource = value;
	}
	readonly uint _subresource;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_REFERENCE_SET ReferenceSet</b>
	/// </summary>
	public readonly VideoProcessReferenceSet ReferenceSet {
		get => _referenceSet;
		init => _referenceSet = value;
	}
	readonly VideoProcessReferenceSet _referenceSet;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessInputStreamArguments {

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM InputStream [2]</b>
	/// </summary>
	public readonly Span<VideoProcessInputStream> InputStream {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _inputStream)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_132 {
		public VideoProcessInputStream _ASP_AUTO_GENERATED_FIELD_0;
		public VideoProcessInputStream _ASP_AUTO_GENERATED_FIELD_1;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_132 _inputStream;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_TRANSFORM Transform</b>
	/// </summary>
	public readonly VideoProcessTransform Transform {
		get => _transform;
		init => _transform = value;
	}
	readonly VideoProcessTransform _transform;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags</b>
	/// </summary>
	public readonly VideoProcessInputStreamFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoProcessInputStreamFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo</b>
	/// </summary>
	public readonly VideoProcessInputStreamRate RateInfo {
		get => _rateInfo;
		init => _rateInfo = value;
	}
	readonly VideoProcessInputStreamRate _rateInfo;

	/// <summary>
	/// <b>INT FilterLevels [32]</b>
	/// </summary>
	public readonly Span<int> FilterLevels {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _filterLevels)), 32);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_133 {
		public fixed int _ASP_AUTO_GENERATED_FIELD_0 [32];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_133 _filterLevels;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending</b>
	/// </summary>
	public readonly VideoProcessAlphaBlending AlphaBlending {
		get => _alphaBlending;
		init => _alphaBlending = value;
	}
	readonly VideoProcessAlphaBlending _alphaBlending;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessOutputStream {

	/// <summary>
	/// <b>ID3D12Resource* pTexture2D</b>
	/// </summary>
	public readonly T* PTexture2D<T> () where T : unmanaged, IResource => (T*) _pTexture2D;
	readonly void* _pTexture2D;

	/// <summary>
	/// <b>UINT Subresource</b>
	/// </summary>
	public readonly uint Subresource {
		get => _subresource;
		init => _subresource = value;
	}
	readonly uint _subresource;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessOutputStreamArguments {

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM OutputStream [2]</b>
	/// </summary>
	public readonly Span<VideoProcessOutputStream> OutputStream {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _outputStream)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_134 {
		public VideoProcessOutputStream _ASP_AUTO_GENERATED_FIELD_0;
		public VideoProcessOutputStream _ASP_AUTO_GENERATED_FIELD_1;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_134 _outputStream;

	/// <summary>
	/// <b>D3D12_RECT TargetRectangle</b>
	/// </summary>
	public readonly Vector4I TargetRectangle {
		get => _targetRectangle;
		init => _targetRectangle = value;
	}
	readonly Vector4I _targetRectangle;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeOutputHistogram {

	/// <summary>
	/// <b>UINT64 Offset</b>
	/// </summary>
	public readonly ulong Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly ulong _offset;

	/// <summary>
	/// <b>ID3D12Resource* pBuffer</b>
	/// </summary>
	public readonly T* PBuffer<T> () where T : unmanaged, IResource => (T*) _pBuffer;
	readonly void* _pBuffer;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeConversionArguments1 {

	/// <summary>
	/// <b>BOOL Enable</b>
	/// </summary>
	public readonly bool Enable {
		get => _enable != 0;
		init => _enable = value ? 1U : 0U;
	}
	readonly uint _enable;

	/// <summary>
	/// <b>ID3D12Resource* pReferenceTexture2D</b>
	/// </summary>
	public readonly T* PReferenceTexture2D<T> () where T : unmanaged, IResource => (T*) _pReferenceTexture2D;
	readonly void* _pReferenceTexture2D;

	/// <summary>
	/// <b>UINT ReferenceSubresource</b>
	/// </summary>
	public readonly uint ReferenceSubresource {
		get => _referenceSubresource;
		init => _referenceSubresource = value;
	}
	readonly uint _referenceSubresource;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE OutputColorSpace</b>
	/// </summary>
	public readonly DXGI.ColorSpaceType OutputColorSpace {
		get => _outputColorSpace;
		init => _outputColorSpace = value;
	}
	readonly DXGI.ColorSpaceType _outputColorSpace;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE DecodeColorSpace</b>
	/// </summary>
	public readonly DXGI.ColorSpaceType DecodeColorSpace {
		get => _decodeColorSpace;
		init => _decodeColorSpace = value;
	}
	readonly DXGI.ColorSpaceType _decodeColorSpace;

	/// <summary>
	/// <b>UINT OutputWidth</b>
	/// </summary>
	public readonly uint OutputWidth {
		get => _outputWidth;
		init => _outputWidth = value;
	}
	readonly uint _outputWidth;

	/// <summary>
	/// <b>UINT OutputHeight</b>
	/// </summary>
	public readonly uint OutputHeight {
		get => _outputHeight;
		init => _outputHeight = value;
	}
	readonly uint _outputHeight;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecodeOutputStreamArguments1 {

	/// <summary>
	/// <b>ID3D12Resource* pOutputTexture2D</b>
	/// </summary>
	public readonly T* POutputTexture2D<T> () where T : unmanaged, IResource => (T*) _pOutputTexture2D;
	readonly void* _pOutputTexture2D;

	/// <summary>
	/// <b>UINT OutputSubresource</b>
	/// </summary>
	public readonly uint OutputSubresource {
		get => _outputSubresource;
		init => _outputSubresource = value;
	}
	readonly uint _outputSubresource;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1 ConversionArguments</b>
	/// </summary>
	public readonly VideoDecodeConversionArguments1 ConversionArguments {
		get => _conversionArguments;
		init => _conversionArguments = value;
	}
	readonly VideoDecodeConversionArguments1 _conversionArguments;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM Histograms [4]</b>
	/// </summary>
	public readonly Span<VideoDecodeOutputHistogram> Histograms {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _histograms)), 4);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_135 {
		public VideoDecodeOutputHistogram _ASP_AUTO_GENERATED_FIELD_0;
		public VideoDecodeOutputHistogram _ASP_AUTO_GENERATED_FIELD_1;
		public VideoDecodeOutputHistogram _ASP_AUTO_GENERATED_FIELD_2;
		public VideoDecodeOutputHistogram _ASP_AUTO_GENERATED_FIELD_3;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_135 _histograms;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessInputStreamArguments1 {

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM InputStream [2]</b>
	/// </summary>
	public readonly Span<VideoProcessInputStream> InputStream {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _inputStream)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_136 {
		public VideoProcessInputStream _ASP_AUTO_GENERATED_FIELD_0;
		public VideoProcessInputStream _ASP_AUTO_GENERATED_FIELD_1;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_136 _inputStream;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_TRANSFORM Transform</b>
	/// </summary>
	public readonly VideoProcessTransform Transform {
		get => _transform;
		init => _transform = value;
	}
	readonly VideoProcessTransform _transform;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags</b>
	/// </summary>
	public readonly VideoProcessInputStreamFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoProcessInputStreamFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo</b>
	/// </summary>
	public readonly VideoProcessInputStreamRate RateInfo {
		get => _rateInfo;
		init => _rateInfo = value;
	}
	readonly VideoProcessInputStreamRate _rateInfo;

	/// <summary>
	/// <b>INT FilterLevels [32]</b>
	/// </summary>
	public readonly Span<int> FilterLevels {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _filterLevels)), 32);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_137 {
		public fixed int _ASP_AUTO_GENERATED_FIELD_0 [32];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_137 _filterLevels;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending</b>
	/// </summary>
	public readonly VideoProcessAlphaBlending AlphaBlending {
		get => _alphaBlending;
		init => _alphaBlending = value;
	}
	readonly VideoProcessAlphaBlending _alphaBlending;

	/// <summary>
	/// <b>D3D12_VIDEO_FIELD_TYPE FieldType</b>
	/// </summary>
	public readonly VideoFieldType FieldType {
		get => _fieldType;
		init => _fieldType = value;
	}
	readonly VideoFieldType _fieldType;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoFeatureAreaSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>BOOL VideoDecodeSupport</b>
	/// </summary>
	public readonly bool VideoDecodeSupport {
		get => _videoDecodeSupport != 0;
		init => _videoDecodeSupport = value ? 1U : 0U;
	}
	readonly uint _videoDecodeSupport;

	/// <summary>
	/// <b>BOOL VideoProcessSupport</b>
	/// </summary>
	public readonly bool VideoProcessSupport {
		get => _videoProcessSupport != 0;
		init => _videoProcessSupport = value ? 1U : 0U;
	}
	readonly uint _videoProcessSupport;

	/// <summary>
	/// <b>BOOL VideoEncodeSupport</b>
	/// </summary>
	public readonly bool VideoEncodeSupport {
		get => _videoEncodeSupport != 0;
		init => _videoEncodeSupport = value ? 1U : 0U;
	}
	readonly uint _videoEncodeSupport;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoMotionEstimator {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>DXGI_FORMAT InputFormat</b>
	/// </summary>
	public readonly DXGI.Format InputFormat {
		get => _inputFormat;
		init => _inputFormat = value;
	}
	readonly DXGI.Format _inputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS BlockSizeFlags</b>
	/// </summary>
	public readonly VideoMotionEstimatorSearchBlockSizeFlags BlockSizeFlags {
		get => _blockSizeFlags;
		init => _blockSizeFlags = value;
	}
	readonly VideoMotionEstimatorSearchBlockSizeFlags _blockSizeFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS PrecisionFlags</b>
	/// </summary>
	public readonly VideoMotionEstimatorVectorPrecisionFlags PrecisionFlags {
		get => _precisionFlags;
		init => _precisionFlags = value;
	}
	readonly VideoMotionEstimatorVectorPrecisionFlags _precisionFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_SIZE_RANGE SizeRange</b>
	/// </summary>
	public readonly VideoSizeRange SizeRange {
		get => _sizeRange;
		init => _sizeRange = value;
	}
	readonly VideoSizeRange _sizeRange;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoMotionEstimatorSize {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>DXGI_FORMAT InputFormat</b>
	/// </summary>
	public readonly DXGI.Format InputFormat {
		get => _inputFormat;
		init => _inputFormat = value;
	}
	readonly DXGI.Format _inputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize</b>
	/// </summary>
	public readonly VideoMotionEstimatorSearchBlockSize BlockSize {
		get => _blockSize;
		init => _blockSize = value;
	}
	readonly VideoMotionEstimatorSearchBlockSize _blockSize;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision</b>
	/// </summary>
	public readonly VideoMotionEstimatorVectorPrecision Precision {
		get => _precision;
		init => _precision = value;
	}
	readonly VideoMotionEstimatorVectorPrecision _precision;

	/// <summary>
	/// <b>D3D12_VIDEO_SIZE_RANGE SizeRange</b>
	/// </summary>
	public readonly VideoSizeRange SizeRange {
		get => _sizeRange;
		init => _sizeRange = value;
	}
	readonly VideoSizeRange _sizeRange;

	/// <summary>
	/// <b>BOOL Protected</b>
	/// </summary>
	public readonly bool Protected {
		get => _protected != 0;
		init => _protected = value ? 1U : 0U;
	}
	readonly uint _protected;

	/// <summary>
	/// <b>UINT64 MotionVectorHeapMemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MotionVectorHeapMemoryPoolL0Size {
		get => _motionVectorHeapMemoryPoolL0Size;
		init => _motionVectorHeapMemoryPoolL0Size = value;
	}
	readonly ulong _motionVectorHeapMemoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MotionVectorHeapMemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MotionVectorHeapMemoryPoolL1Size {
		get => _motionVectorHeapMemoryPoolL1Size;
		init => _motionVectorHeapMemoryPoolL1Size = value;
	}
	readonly ulong _motionVectorHeapMemoryPoolL1Size;

	/// <summary>
	/// <b>UINT64 MotionEstimatorMemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MotionEstimatorMemoryPoolL0Size {
		get => _motionEstimatorMemoryPoolL0Size;
		init => _motionEstimatorMemoryPoolL0Size = value;
	}
	readonly ulong _motionEstimatorMemoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MotionEstimatorMemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MotionEstimatorMemoryPoolL1Size {
		get => _motionEstimatorMemoryPoolL1Size;
		init => _motionEstimatorMemoryPoolL1Size = value;
	}
	readonly ulong _motionEstimatorMemoryPoolL1Size;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_MOTION_ESTIMATOR_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoMotionEstimatorDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>DXGI_FORMAT InputFormat</b>
	/// </summary>
	public readonly DXGI.Format InputFormat {
		get => _inputFormat;
		init => _inputFormat = value;
	}
	readonly DXGI.Format _inputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize</b>
	/// </summary>
	public readonly VideoMotionEstimatorSearchBlockSize BlockSize {
		get => _blockSize;
		init => _blockSize = value;
	}
	readonly VideoMotionEstimatorSearchBlockSize _blockSize;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision</b>
	/// </summary>
	public readonly VideoMotionEstimatorVectorPrecision Precision {
		get => _precision;
		init => _precision = value;
	}
	readonly VideoMotionEstimatorVectorPrecision _precision;

	/// <summary>
	/// <b>D3D12_VIDEO_SIZE_RANGE SizeRange</b>
	/// </summary>
	public readonly VideoSizeRange SizeRange {
		get => _sizeRange;
		init => _sizeRange = value;
	}
	readonly VideoSizeRange _sizeRange;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoMotionVectorHeapDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>DXGI_FORMAT InputFormat</b>
	/// </summary>
	public readonly DXGI.Format InputFormat {
		get => _inputFormat;
		init => _inputFormat = value;
	}
	readonly DXGI.Format _inputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize</b>
	/// </summary>
	public readonly VideoMotionEstimatorSearchBlockSize BlockSize {
		get => _blockSize;
		init => _blockSize = value;
	}
	readonly VideoMotionEstimatorSearchBlockSize _blockSize;

	/// <summary>
	/// <b>D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision</b>
	/// </summary>
	public readonly VideoMotionEstimatorVectorPrecision Precision {
		get => _precision;
		init => _precision = value;
	}
	readonly VideoMotionEstimatorVectorPrecision _precision;

	/// <summary>
	/// <b>D3D12_VIDEO_SIZE_RANGE SizeRange</b>
	/// </summary>
	public readonly VideoSizeRange SizeRange {
		get => _sizeRange;
		init => _sizeRange = value;
	}
	readonly VideoSizeRange _sizeRange;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOURCE_COORDINATE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceCoordinate {

	/// <summary>
	/// <b>UINT64 X</b>
	/// </summary>
	public readonly ulong X {
		get => _x;
		init => _x = value;
	}
	readonly ulong _x;

	/// <summary>
	/// <b>UINT Y</b>
	/// </summary>
	public readonly uint Y {
		get => _y;
		init => _y = value;
	}
	readonly uint _y;

	/// <summary>
	/// <b>UINT Z</b>
	/// </summary>
	public readonly uint Z {
		get => _z;
		init => _z = value;
	}
	readonly uint _z;

	/// <summary>
	/// <b>UINT SubresourceIndex</b>
	/// </summary>
	public readonly uint SubresourceIndex {
		get => _subresourceIndex;
		init => _subresourceIndex = value;
	}
	readonly uint _subresourceIndex;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoMotionEstimatorOutput {

	/// <summary>
	/// <b>ID3D12VideoMotionVectorHeap* pMotionVectorHeap</b>
	/// </summary>
	public readonly T* PMotionVectorHeap<T> () where T : unmanaged, IVideoMotionVectorHeap => (T*) _pMotionVectorHeap;
	readonly void* _pMotionVectorHeap;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_MOTION_ESTIMATOR_INPUT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoMotionEstimatorInput {

	/// <summary>
	/// <b>ID3D12Resource* pInputTexture2D</b>
	/// </summary>
	public readonly T* PInputTexture2D<T> () where T : unmanaged, IResource => (T*) _pInputTexture2D;
	readonly void* _pInputTexture2D;

	/// <summary>
	/// <b>UINT InputSubresourceIndex</b>
	/// </summary>
	public readonly uint InputSubresourceIndex {
		get => _inputSubresourceIndex;
		init => _inputSubresourceIndex = value;
	}
	readonly uint _inputSubresourceIndex;

	/// <summary>
	/// <b>ID3D12Resource* pReferenceTexture2D</b>
	/// </summary>
	public readonly T* PReferenceTexture2D<T> () where T : unmanaged, IResource => (T*) _pReferenceTexture2D;
	readonly void* _pReferenceTexture2D;

	/// <summary>
	/// <b>UINT ReferenceSubresourceIndex</b>
	/// </summary>
	public readonly uint ReferenceSubresourceIndex {
		get => _referenceSubresourceIndex;
		init => _referenceSubresourceIndex = value;
	}
	readonly uint _referenceSubresourceIndex;

	/// <summary>
	/// <b>ID3D12VideoMotionVectorHeap* pHintMotionVectorHeap</b>
	/// </summary>
	public readonly T* PHintMotionVectorHeap<T> () where T : unmanaged, IVideoMotionVectorHeap => (T*) _pHintMotionVectorHeap;
	readonly void* _pHintMotionVectorHeap;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResolveVideoMotionVectorHeapOutput {

	/// <summary>
	/// <b>ID3D12Resource* pMotionVectorTexture2D</b>
	/// </summary>
	public readonly T* PMotionVectorTexture2D<T> () where T : unmanaged, IResource => (T*) _pMotionVectorTexture2D;
	readonly void* _pMotionVectorTexture2D;

	/// <summary>
	/// <b>D3D12_RESOURCE_COORDINATE MotionVectorCoordinate</b>
	/// </summary>
	public readonly ResourceCoordinate MotionVectorCoordinate {
		get => _motionVectorCoordinate;
		init => _motionVectorCoordinate = value;
	}
	readonly ResourceCoordinate _motionVectorCoordinate;

}

/// <summary>
/// STRUCTURE <b>D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResolveVideoMotionVectorHeapInput {

	/// <summary>
	/// <b>ID3D12VideoMotionVectorHeap* pMotionVectorHeap</b>
	/// </summary>
	public readonly T* PMotionVectorHeap<T> () where T : unmanaged, IVideoMotionVectorHeap => (T*) _pMotionVectorHeap;
	readonly void* _pMotionVectorHeap;

	/// <summary>
	/// <b>UINT PixelWidth</b>
	/// </summary>
	public readonly uint PixelWidth {
		get => _pixelWidth;
		init => _pixelWidth = value;
	}
	readonly uint _pixelWidth;

	/// <summary>
	/// <b>UINT PixelHeight</b>
	/// </summary>
	public readonly uint PixelHeight {
		get => _pixelHeight;
		init => _pixelHeight = value;
	}
	readonly uint _pixelHeight;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODE_PROTECTED_RESOURCES</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecodeProtectedResources {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_DECODE_CONFIGURATION Configuration</b>
	/// </summary>
	public readonly VideoDecodeConfiguration Configuration {
		get => _configuration;
		init => _configuration = value;
	}
	readonly VideoDecodeConfiguration _configuration;

	/// <summary>
	/// <b>D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoProtectedResourceSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoProtectedResourceSupportFlags _supportFlags;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_PROCESS_PROTECTED_RESOURCES</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoProcessProtectedResources {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoProtectedResourceSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoProtectedResourceSupportFlags _supportFlags;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoMotionEstimatorProtectedResources {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoProtectedResourceSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoProtectedResourceSupportFlags _supportFlags;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecoderHeapSize1 {

	/// <summary>
	/// <b>D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc</b>
	/// </summary>
	public readonly VideoDecoderHeapDesc VideoDecoderHeapDesc {
		get => _videoDecoderHeapDesc;
		init => _videoDecoderHeapDesc = value;
	}
	readonly VideoDecoderHeapDesc _videoDecoderHeapDesc;

	/// <summary>
	/// <b>BOOL Protected</b>
	/// </summary>
	public readonly bool Protected {
		get => _protected != 0;
		init => _protected = value ? 1U : 0U;
	}
	readonly uint _protected;

	/// <summary>
	/// <b>UINT64 MemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL0Size {
		get => _memoryPoolL0Size;
		init => _memoryPoolL0Size = value;
	}
	readonly ulong _memoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL1Size {
		get => _memoryPoolL1Size;
		init => _memoryPoolL1Size = value;
	}
	readonly ulong _memoryPoolL1Size;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoProcessorSize1 {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc</b>
	/// </summary>
	public readonly VideoProcessOutputStreamDesc* POutputStreamDesc {
		get => _pOutputStreamDesc;
		init => _pOutputStreamDesc = value;
	}
	readonly VideoProcessOutputStreamDesc* _pOutputStreamDesc;

	/// <summary>
	/// <b>UINT NumInputStreamDescs</b>
	/// </summary>
	public readonly uint NumInputStreamDescs {
		get => _numInputStreamDescs;
		init => _numInputStreamDescs = value;
	}
	readonly uint _numInputStreamDescs;

	/// <summary>
	/// <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs</b>
	/// </summary>
	public readonly VideoProcessInputStreamDesc* PInputStreamDescs {
		get => _pInputStreamDescs;
		init => _pInputStreamDescs = value;
	}
	readonly VideoProcessInputStreamDesc* _pInputStreamDescs;

	/// <summary>
	/// <b>BOOL Protected</b>
	/// </summary>
	public readonly bool Protected {
		get => _protected != 0;
		init => _protected = value ? 1U : 0U;
	}
	readonly uint _protected;

	/// <summary>
	/// <b>UINT64 MemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL0Size {
		get => _memoryPoolL0Size;
		init => _memoryPoolL0Size = value;
	}
	readonly ulong _memoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL1Size {
		get => _memoryPoolL1Size;
		init => _memoryPoolL1Size = value;
	}
	readonly ulong _memoryPoolL1Size;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoExtensionCommandCount {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>UINT CommandCount</b>
	/// </summary>
	public readonly uint CommandCount {
		get => _commandCount;
		init => _commandCount = value;
	}
	readonly uint _commandCount;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_EXTENSION_COMMAND_INFO</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoExtensionCommandInfo {

	/// <summary>
	/// <b>GUID CommandId</b>
	/// </summary>
	public readonly Guid CommandId {
		get => _commandId;
		init => _commandId = value;
	}
	readonly Guid _commandId;

	/// <summary>
	/// <b>LPCWSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>D3D12_COMMAND_LIST_SUPPORT_FLAGS CommandListSupportFlags</b>
	/// </summary>
	public readonly CommandListSupportFlags CommandListSupportFlags {
		get => _commandListSupportFlags;
		init => _commandListSupportFlags = value;
	}
	readonly CommandListSupportFlags _commandListSupportFlags;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoExtensionCommands {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>UINT CommandCount</b>
	/// </summary>
	public readonly uint CommandCount {
		get => _commandCount;
		init => _commandCount = value;
	}
	readonly uint _commandCount;

	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_INFO* pCommandInfos</b>
	/// </summary>
	public readonly VideoExtensionCommandInfo* PCommandInfos {
		get => _pCommandInfos;
		init => _pCommandInfos = value;
	}
	readonly VideoExtensionCommandInfo* _pCommandInfos;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoExtensionCommandParameterCount {

	/// <summary>
	/// <b>GUID CommandId</b>
	/// </summary>
	public readonly Guid CommandId {
		get => _commandId;
		init => _commandId = value;
	}
	readonly Guid _commandId;

	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage</b>
	/// </summary>
	public readonly VideoExtensionCommandParameterStage Stage {
		get => _stage;
		init => _stage = value;
	}
	readonly VideoExtensionCommandParameterStage _stage;

	/// <summary>
	/// <b>UINT ParameterCount</b>
	/// </summary>
	public readonly uint ParameterCount {
		get => _parameterCount;
		init => _parameterCount = value;
	}
	readonly uint _parameterCount;

	/// <summary>
	/// <b>UINT ParameterPacking</b>
	/// </summary>
	public readonly uint ParameterPacking {
		get => _parameterPacking;
		init => _parameterPacking = value;
	}
	readonly uint _parameterPacking;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoExtensionCommandParameterInfo {

	/// <summary>
	/// <b>LPCWSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE Type</b>
	/// </summary>
	public readonly VideoExtensionCommandParameterType Type {
		get => _type;
		init => _type = value;
	}
	readonly VideoExtensionCommandParameterType _type;

	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS Flags</b>
	/// </summary>
	public readonly VideoExtensionCommandParameterFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoExtensionCommandParameterFlags _flags;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoExtensionCommandParameters {

	/// <summary>
	/// <b>GUID CommandId</b>
	/// </summary>
	public readonly Guid CommandId {
		get => _commandId;
		init => _commandId = value;
	}
	readonly Guid _commandId;

	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage</b>
	/// </summary>
	public readonly VideoExtensionCommandParameterStage Stage {
		get => _stage;
		init => _stage = value;
	}
	readonly VideoExtensionCommandParameterStage _stage;

	/// <summary>
	/// <b>UINT ParameterCount</b>
	/// </summary>
	public readonly uint ParameterCount {
		get => _parameterCount;
		init => _parameterCount = value;
	}
	readonly uint _parameterCount;

	/// <summary>
	/// <b>D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO* pParameterInfos</b>
	/// </summary>
	public readonly VideoExtensionCommandParameterInfo* PParameterInfos {
		get => _pParameterInfos;
		init => _pParameterInfos = value;
	}
	readonly VideoExtensionCommandParameterInfo* _pParameterInfos;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoExtensionCommandSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>GUID CommandId</b>
	/// </summary>
	public readonly Guid CommandId {
		get => _commandId;
		init => _commandId = value;
	}
	readonly Guid _commandId;

	/// <summary>
	/// <b>void* pInputData</b>
	/// </summary>
	public readonly void* PInputData {
		get => _pInputData;
		init => _pInputData = value;
	}
	readonly void* _pInputData;

	/// <summary>
	/// <b>SIZE_T InputDataSizeInBytes</b>
	/// </summary>
	public readonly nuint InputDataSizeInBytes {
		get => _inputDataSizeInBytes;
		init => _inputDataSizeInBytes = value;
	}
	readonly nuint _inputDataSizeInBytes;

	/// <summary>
	/// <b>void* pOutputData</b>
	/// </summary>
	public readonly void* POutputData {
		get => _pOutputData;
		init => _pOutputData = value;
	}
	readonly void* _pOutputData;

	/// <summary>
	/// <b>SIZE_T OutputDataSizeInBytes</b>
	/// </summary>
	public readonly nuint OutputDataSizeInBytes {
		get => _outputDataSizeInBytes;
		init => _outputDataSizeInBytes = value;
	}
	readonly nuint _outputDataSizeInBytes;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoExtensionCommandSize {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>GUID CommandId</b>
	/// </summary>
	public readonly Guid CommandId {
		get => _commandId;
		init => _commandId = value;
	}
	readonly Guid _commandId;

	/// <summary>
	/// <b>void* pCreationParameters</b>
	/// </summary>
	public readonly void* PCreationParameters {
		get => _pCreationParameters;
		init => _pCreationParameters = value;
	}
	readonly void* _pCreationParameters;

	/// <summary>
	/// <b>SIZE_T CreationParametersSizeInBytes</b>
	/// </summary>
	public readonly nuint CreationParametersSizeInBytes {
		get => _creationParametersSizeInBytes;
		init => _creationParametersSizeInBytes = value;
	}
	readonly nuint _creationParametersSizeInBytes;

	/// <summary>
	/// <b>UINT64 MemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL0Size {
		get => _memoryPoolL0Size;
		init => _memoryPoolL0Size = value;
	}
	readonly ulong _memoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL1Size {
		get => _memoryPoolL1Size;
		init => _memoryPoolL1Size = value;
	}
	readonly ulong _memoryPoolL1Size;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_EXTENSION_COMMAND_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoExtensionCommandDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>GUID CommandId</b>
	/// </summary>
	public readonly Guid CommandId {
		get => _commandId;
		init => _commandId = value;
	}
	readonly Guid _commandId;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderRateControlCqp {

	/// <summary>
	/// <b>UINT ConstantQP_FullIntracodedFrame</b>
	/// </summary>
	public readonly uint ConstantQP_FullIntracodedFrame {
		get => _constantQP_FullIntracodedFrame;
		init => _constantQP_FullIntracodedFrame = value;
	}
	readonly uint _constantQP_FullIntracodedFrame;

	/// <summary>
	/// <b>UINT ConstantQP_InterPredictedFrame_PrevRefOnly</b>
	/// </summary>
	public readonly uint ConstantQP_InterPredictedFrame_PrevRefOnly {
		get => _constantQP_InterPredictedFrame_PrevRefOnly;
		init => _constantQP_InterPredictedFrame_PrevRefOnly = value;
	}
	readonly uint _constantQP_InterPredictedFrame_PrevRefOnly;

	/// <summary>
	/// <b>UINT ConstantQP_InterPredictedFrame_BiDirectionalRef</b>
	/// </summary>
	public readonly uint ConstantQP_InterPredictedFrame_BiDirectionalRef {
		get => _constantQP_InterPredictedFrame_BiDirectionalRef;
		init => _constantQP_InterPredictedFrame_BiDirectionalRef = value;
	}
	readonly uint _constantQP_InterPredictedFrame_BiDirectionalRef;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderRateControlCbr {

	/// <summary>
	/// <b>UINT InitialQP</b>
	/// </summary>
	public readonly uint InitialQP {
		get => _initialQP;
		init => _initialQP = value;
	}
	readonly uint _initialQP;

	/// <summary>
	/// <b>UINT MinQP</b>
	/// </summary>
	public readonly uint MinQP {
		get => _minQP;
		init => _minQP = value;
	}
	readonly uint _minQP;

	/// <summary>
	/// <b>UINT MaxQP</b>
	/// </summary>
	public readonly uint MaxQP {
		get => _maxQP;
		init => _maxQP = value;
	}
	readonly uint _maxQP;

	/// <summary>
	/// <b>UINT64 MaxFrameBitSize</b>
	/// </summary>
	public readonly ulong MaxFrameBitSize {
		get => _maxFrameBitSize;
		init => _maxFrameBitSize = value;
	}
	readonly ulong _maxFrameBitSize;

	/// <summary>
	/// <b>UINT64 TargetBitRate</b>
	/// </summary>
	public readonly ulong TargetBitRate {
		get => _targetBitRate;
		init => _targetBitRate = value;
	}
	readonly ulong _targetBitRate;

	/// <summary>
	/// <b>UINT64 VBVCapacity</b>
	/// </summary>
	public readonly ulong VBVCapacity {
		get => _vBVCapacity;
		init => _vBVCapacity = value;
	}
	readonly ulong _vBVCapacity;

	/// <summary>
	/// <b>UINT64 InitialVBVFullness</b>
	/// </summary>
	public readonly ulong InitialVBVFullness {
		get => _initialVBVFullness;
		init => _initialVBVFullness = value;
	}
	readonly ulong _initialVBVFullness;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderRateControlVbr {

	/// <summary>
	/// <b>UINT InitialQP</b>
	/// </summary>
	public readonly uint InitialQP {
		get => _initialQP;
		init => _initialQP = value;
	}
	readonly uint _initialQP;

	/// <summary>
	/// <b>UINT MinQP</b>
	/// </summary>
	public readonly uint MinQP {
		get => _minQP;
		init => _minQP = value;
	}
	readonly uint _minQP;

	/// <summary>
	/// <b>UINT MaxQP</b>
	/// </summary>
	public readonly uint MaxQP {
		get => _maxQP;
		init => _maxQP = value;
	}
	readonly uint _maxQP;

	/// <summary>
	/// <b>UINT64 MaxFrameBitSize</b>
	/// </summary>
	public readonly ulong MaxFrameBitSize {
		get => _maxFrameBitSize;
		init => _maxFrameBitSize = value;
	}
	readonly ulong _maxFrameBitSize;

	/// <summary>
	/// <b>UINT64 TargetAvgBitRate</b>
	/// </summary>
	public readonly ulong TargetAvgBitRate {
		get => _targetAvgBitRate;
		init => _targetAvgBitRate = value;
	}
	readonly ulong _targetAvgBitRate;

	/// <summary>
	/// <b>UINT64 PeakBitRate</b>
	/// </summary>
	public readonly ulong PeakBitRate {
		get => _peakBitRate;
		init => _peakBitRate = value;
	}
	readonly ulong _peakBitRate;

	/// <summary>
	/// <b>UINT64 VBVCapacity</b>
	/// </summary>
	public readonly ulong VBVCapacity {
		get => _vBVCapacity;
		init => _vBVCapacity = value;
	}
	readonly ulong _vBVCapacity;

	/// <summary>
	/// <b>UINT64 InitialVBVFullness</b>
	/// </summary>
	public readonly ulong InitialVBVFullness {
		get => _initialVBVFullness;
		init => _initialVBVFullness = value;
	}
	readonly ulong _initialVBVFullness;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderRateControlQvbr {

	/// <summary>
	/// <b>UINT InitialQP</b>
	/// </summary>
	public readonly uint InitialQP {
		get => _initialQP;
		init => _initialQP = value;
	}
	readonly uint _initialQP;

	/// <summary>
	/// <b>UINT MinQP</b>
	/// </summary>
	public readonly uint MinQP {
		get => _minQP;
		init => _minQP = value;
	}
	readonly uint _minQP;

	/// <summary>
	/// <b>UINT MaxQP</b>
	/// </summary>
	public readonly uint MaxQP {
		get => _maxQP;
		init => _maxQP = value;
	}
	readonly uint _maxQP;

	/// <summary>
	/// <b>UINT64 MaxFrameBitSize</b>
	/// </summary>
	public readonly ulong MaxFrameBitSize {
		get => _maxFrameBitSize;
		init => _maxFrameBitSize = value;
	}
	readonly ulong _maxFrameBitSize;

	/// <summary>
	/// <b>UINT64 TargetAvgBitRate</b>
	/// </summary>
	public readonly ulong TargetAvgBitRate {
		get => _targetAvgBitRate;
		init => _targetAvgBitRate = value;
	}
	readonly ulong _targetAvgBitRate;

	/// <summary>
	/// <b>UINT64 PeakBitRate</b>
	/// </summary>
	public readonly ulong PeakBitRate {
		get => _peakBitRate;
		init => _peakBitRate = value;
	}
	readonly ulong _peakBitRate;

	/// <summary>
	/// <b>UINT ConstantQualityTarget</b>
	/// </summary>
	public readonly uint ConstantQualityTarget {
		get => _constantQualityTarget;
		init => _constantQualityTarget = value;
	}
	readonly uint _constantQualityTarget;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderRateControlConfigurationParams {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_69 {

		[FieldOffset (0)] public VideoEncoderRateControlCqp* _pConfiguration_CQP;
		[FieldOffset (0)] public VideoEncoderRateControlCbr* _pConfiguration_CBR;
		[FieldOffset (0)] public VideoEncoderRateControlVbr* _pConfiguration_VBR;
		[FieldOffset (0)] public VideoEncoderRateControlQvbr* _pConfiguration_QVBR;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP* pConfiguration_CQP</b>
	/// </summary>
	public readonly VideoEncoderRateControlCqp* PConfiguration_CQP {
		get => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_CQP;
		init => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_CQP = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR* pConfiguration_CBR</b>
	/// </summary>
	public readonly VideoEncoderRateControlCbr* PConfiguration_CBR {
		get => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_CBR;
		init => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_CBR = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR* pConfiguration_VBR</b>
	/// </summary>
	public readonly VideoEncoderRateControlVbr* PConfiguration_VBR {
		get => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_VBR;
		init => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_VBR = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR* pConfiguration_QVBR</b>
	/// </summary>
	public readonly VideoEncoderRateControlQvbr* PConfiguration_QVBR {
		get => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_QVBR;
		init => __aSP_AUTO_GENERATED_FIELD_69._pConfiguration_QVBR = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_69 __aSP_AUTO_GENERATED_FIELD_69;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RATE_CONTROL</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderRateControl {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE Mode</b>
	/// </summary>
	public readonly VideoEncoderRateControlMode Mode {
		get => _mode;
		init => _mode = value;
	}
	readonly VideoEncoderRateControlMode _mode;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS Flags</b>
	/// </summary>
	public readonly VideoEncoderRateControlFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoEncoderRateControlFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS ConfigParams</b>
	/// </summary>
	public readonly VideoEncoderRateControlConfigurationParams ConfigParams {
		get => _configParams;
		init => _configParams = value;
	}
	readonly VideoEncoderRateControlConfigurationParams _configParams;

	/// <summary>
	/// <b>DXGI_RATIONAL TargetFrameRate</b>
	/// </summary>
	public readonly DXGI.Rational TargetFrameRate {
		get => _targetFrameRate;
		init => _targetFrameRate = value;
	}
	readonly DXGI.Rational _targetFrameRate;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderCodec {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PROFILE_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderProfileDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_71 {

		[FieldOffset (0)] public VideoEncoderProfileH264* _pH264Profile;
		[FieldOffset (0)] public VideoEncoderProfileHevc* _pHEVCProfile;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_H264* pH264Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileH264* PH264Profile {
		get => __aSP_AUTO_GENERATED_FIELD_71._pH264Profile;
		init => __aSP_AUTO_GENERATED_FIELD_71._pH264Profile = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_HEVC* pHEVCProfile</b>
	/// </summary>
	public readonly VideoEncoderProfileHevc* PHEVCProfile {
		get => __aSP_AUTO_GENERATED_FIELD_71._pHEVCProfile;
		init => __aSP_AUTO_GENERATED_FIELD_71._pHEVCProfile = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_71 __aSP_AUTO_GENERATED_FIELD_71;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderLevelTierConstraintsHevc {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_HEVC Level</b>
	/// </summary>
	public readonly VideoEncoderLevelsHevc Level {
		get => _level;
		init => _level = value;
	}
	readonly VideoEncoderLevelsHevc _level;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_TIER_HEVC Tier</b>
	/// </summary>
	public readonly VideoEncoderTierHevc Tier {
		get => _tier;
		init => _tier = value;
	}
	readonly VideoEncoderTierHevc _tier;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderLevelSetting {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_73 {

		[FieldOffset (0)] public VideoEncoderLevelsH264* _pH264LevelSetting;
		[FieldOffset (0)] public VideoEncoderLevelTierConstraintsHevc* _pHEVCLevelSetting;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVELS_H264* pH264LevelSetting</b>
	/// </summary>
	public readonly VideoEncoderLevelsH264* PH264LevelSetting {
		get => __aSP_AUTO_GENERATED_FIELD_73._pH264LevelSetting;
		init => __aSP_AUTO_GENERATED_FIELD_73._pH264LevelSetting = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC* pHEVCLevelSetting</b>
	/// </summary>
	public readonly VideoEncoderLevelTierConstraintsHevc* PHEVCLevelSetting {
		get => __aSP_AUTO_GENERATED_FIELD_73._pHEVCLevelSetting;
		init => __aSP_AUTO_GENERATED_FIELD_73._pHEVCLevelSetting = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_73 __aSP_AUTO_GENERATED_FIELD_73;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderProfileLevel {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc Profile {
		get => _profile;
		init => _profile = value;
	}
	readonly VideoEncoderProfileDesc _profile;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING MinSupportedLevel</b>
	/// </summary>
	public readonly VideoEncoderLevelSetting MinSupportedLevel {
		get => _minSupportedLevel;
		init => _minSupportedLevel = value;
	}
	readonly VideoEncoderLevelSetting _minSupportedLevel;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING MaxSupportedLevel</b>
	/// </summary>
	public readonly VideoEncoderLevelSetting MaxSupportedLevel {
		get => _maxSupportedLevel;
		init => _maxSupportedLevel = value;
	}
	readonly VideoEncoderLevelSetting _maxSupportedLevel;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureResolutionDesc {

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_RATIO_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureResolutionRatioDesc {

	/// <summary>
	/// <b>UINT WidthRatio</b>
	/// </summary>
	public readonly uint WidthRatio {
		get => _widthRatio;
		init => _widthRatio = value;
	}
	readonly uint _widthRatio;

	/// <summary>
	/// <b>UINT HeightRatio</b>
	/// </summary>
	public readonly uint HeightRatio {
		get => _heightRatio;
		init => _heightRatio = value;
	}
	readonly uint _heightRatio;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION_RATIOS_COUNT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderOutputResolutionRatiosCount {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>UINT ResolutionRatiosCount</b>
	/// </summary>
	public readonly uint ResolutionRatiosCount {
		get => _resolutionRatiosCount;
		init => _resolutionRatiosCount = value;
	}
	readonly uint _resolutionRatiosCount;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderOutputResolution {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>UINT ResolutionRatiosCount</b>
	/// </summary>
	public readonly uint ResolutionRatiosCount {
		get => _resolutionRatiosCount;
		init => _resolutionRatiosCount = value;
	}
	readonly uint _resolutionRatiosCount;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC MinResolutionSupported</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionDesc MinResolutionSupported {
		get => _minResolutionSupported;
		init => _minResolutionSupported = value;
	}
	readonly VideoEncoderPictureResolutionDesc _minResolutionSupported;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC MaxResolutionSupported</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionDesc MaxResolutionSupported {
		get => _maxResolutionSupported;
		init => _maxResolutionSupported = value;
	}
	readonly VideoEncoderPictureResolutionDesc _maxResolutionSupported;

	/// <summary>
	/// <b>UINT ResolutionWidthMultipleRequirement</b>
	/// </summary>
	public readonly uint ResolutionWidthMultipleRequirement {
		get => _resolutionWidthMultipleRequirement;
		init => _resolutionWidthMultipleRequirement = value;
	}
	readonly uint _resolutionWidthMultipleRequirement;

	/// <summary>
	/// <b>UINT ResolutionHeightMultipleRequirement</b>
	/// </summary>
	public readonly uint ResolutionHeightMultipleRequirement {
		get => _resolutionHeightMultipleRequirement;
		init => _resolutionHeightMultipleRequirement = value;
	}
	readonly uint _resolutionHeightMultipleRequirement;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_RATIO_DESC* pResolutionRatios</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionRatioDesc* PResolutionRatios {
		get => _pResolutionRatios;
		init => _pResolutionRatios = value;
	}
	readonly VideoEncoderPictureResolutionRatioDesc* _pResolutionRatios;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderInputFormat {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc Profile {
		get => _profile;
		init => _profile = value;
	}
	readonly VideoEncoderProfileDesc _profile;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_RATE_CONTROL_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderRateControlMode {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE RateControlMode</b>
	/// </summary>
	public readonly VideoEncoderRateControlMode RateControlMode {
		get => _rateControlMode;
		init => _rateControlMode = value;
	}
	readonly VideoEncoderRateControlMode _rateControlMode;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderIntraRefreshMode {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc Profile {
		get => _profile;
		init => _profile = value;
	}
	readonly VideoEncoderProfileDesc _profile;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING Level</b>
	/// </summary>
	public readonly VideoEncoderLevelSetting Level {
		get => _level;
		init => _level = value;
	}
	readonly VideoEncoderLevelSetting _level;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE IntraRefreshMode</b>
	/// </summary>
	public readonly VideoEncoderIntraRefreshMode IntraRefreshMode {
		get => _intraRefreshMode;
		init => _intraRefreshMode = value;
	}
	readonly VideoEncoderIntraRefreshMode _intraRefreshMode;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderFrameSubregionLayoutMode {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc Profile {
		get => _profile;
		init => _profile = value;
	}
	readonly VideoEncoderProfileDesc _profile;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING Level</b>
	/// </summary>
	public readonly VideoEncoderLevelSetting Level {
		get => _level;
		init => _level = value;
	}
	readonly VideoEncoderLevelSetting _level;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionMode</b>
	/// </summary>
	public readonly VideoEncoderFrameSubregionLayoutMode SubregionMode {
		get => _subregionMode;
		init => _subregionMode = value;
	}
	readonly VideoEncoderFrameSubregionLayoutMode _subregionMode;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_HEAP_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderHeapDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_HEAP_FLAGS Flags</b>
	/// </summary>
	public readonly VideoEncoderHeapFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoEncoderHeapFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC EncodeCodec</b>
	/// </summary>
	public readonly VideoEncoderCodec EncodeCodec {
		get => _encodeCodec;
		init => _encodeCodec = value;
	}
	readonly VideoEncoderCodec _encodeCodec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc EncodeProfile {
		get => _encodeProfile;
		init => _encodeProfile = value;
	}
	readonly VideoEncoderProfileDesc _encodeProfile;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING EncodeLevel</b>
	/// </summary>
	public readonly VideoEncoderLevelSetting EncodeLevel {
		get => _encodeLevel;
		init => _encodeLevel = value;
	}
	readonly VideoEncoderLevelSetting _encodeLevel;

	/// <summary>
	/// <b>UINT ResolutionsListCount</b>
	/// </summary>
	public readonly uint ResolutionsListCount {
		get => _resolutionsListCount;
		init => _resolutionsListCount = value;
	}
	readonly uint _resolutionsListCount;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionDesc* PResolutionList {
		get => _pResolutionList;
		init => _pResolutionList = value;
	}
	readonly VideoEncoderPictureResolutionDesc* _pResolutionList;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderHeapSize {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_HEAP_DESC HeapDesc</b>
	/// </summary>
	public readonly VideoEncoderHeapDesc HeapDesc {
		get => _heapDesc;
		init => _heapDesc = value;
	}
	readonly VideoEncoderHeapDesc _heapDesc;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

	/// <summary>
	/// <b>UINT64 MemoryPoolL0Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL0Size {
		get => _memoryPoolL0Size;
		init => _memoryPoolL0Size = value;
	}
	readonly ulong _memoryPoolL0Size;

	/// <summary>
	/// <b>UINT64 MemoryPoolL1Size</b>
	/// </summary>
	public readonly ulong MemoryPoolL1Size {
		get => _memoryPoolL1Size;
		init => _memoryPoolL1Size = value;
	}
	readonly ulong _memoryPoolL1Size;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecConfigurationSupportH264 {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationSupportH264Flags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoEncoderCodecConfigurationSupportH264Flags _supportFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAGS DisableDeblockingFilterSupportedModes</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags DisableDeblockingFilterSupportedModes {
		get => _disableDeblockingFilterSupportedModes;
		init => _disableDeblockingFilterSupportedModes = value;
	}
	readonly VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags _disableDeblockingFilterSupportedModes;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecConfigurationSupportHevc {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationSupportHevcFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoEncoderCodecConfigurationSupportHevcFlags _supportFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcCusize MinLumaCodingUnitSize {
		get => _minLumaCodingUnitSize;
		init => _minLumaCodingUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcCusize _minLumaCodingUnitSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcCusize MaxLumaCodingUnitSize {
		get => _maxLumaCodingUnitSize;
		init => _maxLumaCodingUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcCusize _maxLumaCodingUnitSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcTusize MinLumaTransformUnitSize {
		get => _minLumaTransformUnitSize;
		init => _minLumaTransformUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcTusize _minLumaTransformUnitSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcTusize MaxLumaTransformUnitSize {
		get => _maxLumaTransformUnitSize;
		init => _maxLumaTransformUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcTusize _maxLumaTransformUnitSize;

	/// <summary>
	/// <b>UCHAR max_transform_hierarchy_depth_inter</b>
	/// </summary>
	public readonly byte Max_transform_hierarchy_depth_inter {
		get => _max_transform_hierarchy_depth_inter;
		init => _max_transform_hierarchy_depth_inter = value;
	}
	readonly byte _max_transform_hierarchy_depth_inter;

	/// <summary>
	/// <b>UCHAR max_transform_hierarchy_depth_intra</b>
	/// </summary>
	public readonly byte Max_transform_hierarchy_depth_intra {
		get => _max_transform_hierarchy_depth_intra;
		init => _max_transform_hierarchy_depth_intra = value;
	}
	readonly byte _max_transform_hierarchy_depth_intra;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecConfigurationSupport {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_75 {

		[FieldOffset (0)] public VideoEncoderCodecConfigurationSupportH264* _pH264Support;
		[FieldOffset (0)] public VideoEncoderCodecConfigurationSupportHevc* _pHEVCSupport;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264* pH264Support</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationSupportH264* PH264Support {
		get => __aSP_AUTO_GENERATED_FIELD_75._pH264Support;
		init => __aSP_AUTO_GENERATED_FIELD_75._pH264Support = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC* pHEVCSupport</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationSupportHevc* PHEVCSupport {
		get => __aSP_AUTO_GENERATED_FIELD_75._pHEVCSupport;
		init => __aSP_AUTO_GENERATED_FIELD_75._pHEVCSupport = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_75 __aSP_AUTO_GENERATED_FIELD_75;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderCodecConfigurationSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc Profile {
		get => _profile;
		init => _profile = value;
	}
	readonly VideoEncoderProfileDesc _profile;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT CodecSupportLimits</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationSupport CodecSupportLimits {
		get => _codecSupportLimits;
		init => _codecSupportLimits = value;
	}
	readonly VideoEncoderCodecConfigurationSupport _codecSupportLimits;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecPictureControlSupportH264 {

	/// <summary>
	/// <b>UINT MaxL0ReferencesForP</b>
	/// </summary>
	public readonly uint MaxL0ReferencesForP {
		get => _maxL0ReferencesForP;
		init => _maxL0ReferencesForP = value;
	}
	readonly uint _maxL0ReferencesForP;

	/// <summary>
	/// <b>UINT MaxL0ReferencesForB</b>
	/// </summary>
	public readonly uint MaxL0ReferencesForB {
		get => _maxL0ReferencesForB;
		init => _maxL0ReferencesForB = value;
	}
	readonly uint _maxL0ReferencesForB;

	/// <summary>
	/// <b>UINT MaxL1ReferencesForB</b>
	/// </summary>
	public readonly uint MaxL1ReferencesForB {
		get => _maxL1ReferencesForB;
		init => _maxL1ReferencesForB = value;
	}
	readonly uint _maxL1ReferencesForB;

	/// <summary>
	/// <b>UINT MaxLongTermReferences</b>
	/// </summary>
	public readonly uint MaxLongTermReferences {
		get => _maxLongTermReferences;
		init => _maxLongTermReferences = value;
	}
	readonly uint _maxLongTermReferences;

	/// <summary>
	/// <b>UINT MaxDPBCapacity</b>
	/// </summary>
	public readonly uint MaxDPBCapacity {
		get => _maxDPBCapacity;
		init => _maxDPBCapacity = value;
	}
	readonly uint _maxDPBCapacity;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecPictureControlSupportHevc {

	/// <summary>
	/// <b>UINT MaxL0ReferencesForP</b>
	/// </summary>
	public readonly uint MaxL0ReferencesForP {
		get => _maxL0ReferencesForP;
		init => _maxL0ReferencesForP = value;
	}
	readonly uint _maxL0ReferencesForP;

	/// <summary>
	/// <b>UINT MaxL0ReferencesForB</b>
	/// </summary>
	public readonly uint MaxL0ReferencesForB {
		get => _maxL0ReferencesForB;
		init => _maxL0ReferencesForB = value;
	}
	readonly uint _maxL0ReferencesForB;

	/// <summary>
	/// <b>UINT MaxL1ReferencesForB</b>
	/// </summary>
	public readonly uint MaxL1ReferencesForB {
		get => _maxL1ReferencesForB;
		init => _maxL1ReferencesForB = value;
	}
	readonly uint _maxL1ReferencesForB;

	/// <summary>
	/// <b>UINT MaxLongTermReferences</b>
	/// </summary>
	public readonly uint MaxLongTermReferences {
		get => _maxLongTermReferences;
		init => _maxLongTermReferences = value;
	}
	readonly uint _maxLongTermReferences;

	/// <summary>
	/// <b>UINT MaxDPBCapacity</b>
	/// </summary>
	public readonly uint MaxDPBCapacity {
		get => _maxDPBCapacity;
		init => _maxDPBCapacity = value;
	}
	readonly uint _maxDPBCapacity;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecPictureControlSupport {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_77 {

		[FieldOffset (0)] public VideoEncoderCodecPictureControlSupportH264* _pH264Support;
		[FieldOffset (0)] public VideoEncoderCodecPictureControlSupportHevc* _pHEVCSupport;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264* pH264Support</b>
	/// </summary>
	public readonly VideoEncoderCodecPictureControlSupportH264* PH264Support {
		get => __aSP_AUTO_GENERATED_FIELD_77._pH264Support;
		init => __aSP_AUTO_GENERATED_FIELD_77._pH264Support = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC* pHEVCSupport</b>
	/// </summary>
	public readonly VideoEncoderCodecPictureControlSupportHevc* PHEVCSupport {
		get => __aSP_AUTO_GENERATED_FIELD_77._pHEVCSupport;
		init => __aSP_AUTO_GENERATED_FIELD_77._pHEVCSupport = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_77 __aSP_AUTO_GENERATED_FIELD_77;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderCodecPictureControlSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc Profile {
		get => _profile;
		init => _profile = value;
	}
	readonly VideoEncoderProfileDesc _profile;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT PictureSupport</b>
	/// </summary>
	public readonly VideoEncoderCodecPictureControlSupport PictureSupport {
		get => _pictureSupport;
		init => _pictureSupport = value;
	}
	readonly VideoEncoderCodecPictureControlSupport _pictureSupport;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecConfigurationH264 {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS ConfigurationFlags</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationH264Flags ConfigurationFlags {
		get => _configurationFlags;
		init => _configurationFlags = value;
	}
	readonly VideoEncoderCodecConfigurationH264Flags _configurationFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES DirectModeConfig</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationH264DirectModes DirectModeConfig {
		get => _directModeConfig;
		init => _directModeConfig = value;
	}
	readonly VideoEncoderCodecConfigurationH264DirectModes _directModeConfig;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODES DisableDeblockingFilterConfig</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationH264SlicesDeblockingModes DisableDeblockingFilterConfig {
		get => _disableDeblockingFilterConfig;
		init => _disableDeblockingFilterConfig = value;
	}
	readonly VideoEncoderCodecConfigurationH264SlicesDeblockingModes _disableDeblockingFilterConfig;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecConfigurationHevc {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS ConfigurationFlags</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcFlags ConfigurationFlags {
		get => _configurationFlags;
		init => _configurationFlags = value;
	}
	readonly VideoEncoderCodecConfigurationHevcFlags _configurationFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcCusize MinLumaCodingUnitSize {
		get => _minLumaCodingUnitSize;
		init => _minLumaCodingUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcCusize _minLumaCodingUnitSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcCusize MaxLumaCodingUnitSize {
		get => _maxLumaCodingUnitSize;
		init => _maxLumaCodingUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcCusize _maxLumaCodingUnitSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcTusize MinLumaTransformUnitSize {
		get => _minLumaTransformUnitSize;
		init => _minLumaTransformUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcTusize _minLumaTransformUnitSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevcTusize MaxLumaTransformUnitSize {
		get => _maxLumaTransformUnitSize;
		init => _maxLumaTransformUnitSize = value;
	}
	readonly VideoEncoderCodecConfigurationHevcTusize _maxLumaTransformUnitSize;

	/// <summary>
	/// <b>UCHAR max_transform_hierarchy_depth_inter</b>
	/// </summary>
	public readonly byte Max_transform_hierarchy_depth_inter {
		get => _max_transform_hierarchy_depth_inter;
		init => _max_transform_hierarchy_depth_inter = value;
	}
	readonly byte _max_transform_hierarchy_depth_inter;

	/// <summary>
	/// <b>UCHAR max_transform_hierarchy_depth_intra</b>
	/// </summary>
	public readonly byte Max_transform_hierarchy_depth_intra {
		get => _max_transform_hierarchy_depth_intra;
		init => _max_transform_hierarchy_depth_intra = value;
	}
	readonly byte _max_transform_hierarchy_depth_intra;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCodecConfiguration {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_79 {

		[FieldOffset (0)] public VideoEncoderCodecConfigurationH264* _pH264Config;
		[FieldOffset (0)] public VideoEncoderCodecConfigurationHevc* _pHEVCConfig;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264* pH264Config</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationH264* PH264Config {
		get => __aSP_AUTO_GENERATED_FIELD_79._pH264Config;
		init => __aSP_AUTO_GENERATED_FIELD_79._pH264Config = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC* pHEVCConfig</b>
	/// </summary>
	public readonly VideoEncoderCodecConfigurationHevc* PHEVCConfig {
		get => __aSP_AUTO_GENERATED_FIELD_79._pHEVCConfig;
		init => __aSP_AUTO_GENERATED_FIELD_79._pHEVCConfig = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_79 __aSP_AUTO_GENERATED_FIELD_79;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderIntraRefresh {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE Mode</b>
	/// </summary>
	public readonly VideoEncoderIntraRefreshMode Mode {
		get => _mode;
		init => _mode = value;
	}
	readonly VideoEncoderIntraRefreshMode _mode;

	/// <summary>
	/// <b>UINT IntraRefreshDuration</b>
	/// </summary>
	public readonly uint IntraRefreshDuration {
		get => _intraRefreshDuration;
		init => _intraRefreshDuration = value;
	}
	readonly uint _intraRefreshDuration;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderResolutionSupportLimits {

	/// <summary>
	/// <b>UINT MaxSubregionsNumber</b>
	/// </summary>
	public readonly uint MaxSubregionsNumber {
		get => _maxSubregionsNumber;
		init => _maxSubregionsNumber = value;
	}
	readonly uint _maxSubregionsNumber;

	/// <summary>
	/// <b>UINT MaxIntraRefreshFrameDuration</b>
	/// </summary>
	public readonly uint MaxIntraRefreshFrameDuration {
		get => _maxIntraRefreshFrameDuration;
		init => _maxIntraRefreshFrameDuration = value;
	}
	readonly uint _maxIntraRefreshFrameDuration;

	/// <summary>
	/// <b>UINT SubregionBlockPixelsSize</b>
	/// </summary>
	public readonly uint SubregionBlockPixelsSize {
		get => _subregionBlockPixelsSize;
		init => _subregionBlockPixelsSize = value;
	}
	readonly uint _subregionBlockPixelsSize;

	/// <summary>
	/// <b>UINT QPMapRegionPixelsSize</b>
	/// </summary>
	public readonly uint QPMapRegionPixelsSize {
		get => _qPMapRegionPixelsSize;
		init => _qPMapRegionPixelsSize = value;
	}
	readonly uint _qPMapRegionPixelsSize;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderSequenceGopStructureH264 {

	/// <summary>
	/// <b>UINT GOPLength</b>
	/// </summary>
	public readonly uint GOPLength {
		get => _gOPLength;
		init => _gOPLength = value;
	}
	readonly uint _gOPLength;

	/// <summary>
	/// <b>UINT PPicturePeriod</b>
	/// </summary>
	public readonly uint PPicturePeriod {
		get => _pPicturePeriod;
		init => _pPicturePeriod = value;
	}
	readonly uint _pPicturePeriod;

	/// <summary>
	/// <b>UCHAR pic_order_cnt_type</b>
	/// </summary>
	public readonly byte Pic_order_cnt_type {
		get => _pic_order_cnt_type;
		init => _pic_order_cnt_type = value;
	}
	readonly byte _pic_order_cnt_type;

	/// <summary>
	/// <b>UCHAR log2_max_frame_num_minus4</b>
	/// </summary>
	public readonly byte Log2_max_frame_num_minus4 {
		get => _log2_max_frame_num_minus4;
		init => _log2_max_frame_num_minus4 = value;
	}
	readonly byte _log2_max_frame_num_minus4;

	/// <summary>
	/// <b>UCHAR log2_max_pic_order_cnt_lsb_minus4</b>
	/// </summary>
	public readonly byte Log2_max_pic_order_cnt_lsb_minus4 {
		get => _log2_max_pic_order_cnt_lsb_minus4;
		init => _log2_max_pic_order_cnt_lsb_minus4 = value;
	}
	readonly byte _log2_max_pic_order_cnt_lsb_minus4;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderSequenceGopStructureHevc {

	/// <summary>
	/// <b>UINT GOPLength</b>
	/// </summary>
	public readonly uint GOPLength {
		get => _gOPLength;
		init => _gOPLength = value;
	}
	readonly uint _gOPLength;

	/// <summary>
	/// <b>UINT PPicturePeriod</b>
	/// </summary>
	public readonly uint PPicturePeriod {
		get => _pPicturePeriod;
		init => _pPicturePeriod = value;
	}
	readonly uint _pPicturePeriod;

	/// <summary>
	/// <b>UCHAR log2_max_pic_order_cnt_lsb_minus4</b>
	/// </summary>
	public readonly byte Log2_max_pic_order_cnt_lsb_minus4 {
		get => _log2_max_pic_order_cnt_lsb_minus4;
		init => _log2_max_pic_order_cnt_lsb_minus4 = value;
	}
	readonly byte _log2_max_pic_order_cnt_lsb_minus4;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderSequenceGopStructure {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_81 {

		[FieldOffset (0)] public VideoEncoderSequenceGopStructureH264* _pH264GroupOfPictures;
		[FieldOffset (0)] public VideoEncoderSequenceGopStructureHevc* _pHEVCGroupOfPictures;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264* pH264GroupOfPictures</b>
	/// </summary>
	public readonly VideoEncoderSequenceGopStructureH264* PH264GroupOfPictures {
		get => __aSP_AUTO_GENERATED_FIELD_81._pH264GroupOfPictures;
		init => __aSP_AUTO_GENERATED_FIELD_81._pH264GroupOfPictures = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC* pHEVCGroupOfPictures</b>
	/// </summary>
	public readonly VideoEncoderSequenceGopStructureHevc* PHEVCGroupOfPictures {
		get => __aSP_AUTO_GENERATED_FIELD_81._pHEVCGroupOfPictures;
		init => __aSP_AUTO_GENERATED_FIELD_81._pHEVCGroupOfPictures = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_81 __aSP_AUTO_GENERATED_FIELD_81;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderSupport {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>DXGI_FORMAT InputFormat</b>
	/// </summary>
	public readonly DXGI.Format InputFormat {
		get => _inputFormat;
		init => _inputFormat = value;
	}
	readonly DXGI.Format _inputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration</b>
	/// </summary>
	public readonly VideoEncoderCodecConfiguration CodecConfiguration {
		get => _codecConfiguration;
		init => _codecConfiguration = value;
	}
	readonly VideoEncoderCodecConfiguration _codecConfiguration;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence</b>
	/// </summary>
	public readonly VideoEncoderSequenceGopStructure CodecGopSequence {
		get => _codecGopSequence;
		init => _codecGopSequence = value;
	}
	readonly VideoEncoderSequenceGopStructure _codecGopSequence;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl</b>
	/// </summary>
	public readonly VideoEncoderRateControl RateControl {
		get => _rateControl;
		init => _rateControl = value;
	}
	readonly VideoEncoderRateControl _rateControl;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE IntraRefresh</b>
	/// </summary>
	public readonly VideoEncoderIntraRefreshMode IntraRefresh {
		get => _intraRefresh;
		init => _intraRefresh = value;
	}
	readonly VideoEncoderIntraRefreshMode _intraRefresh;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionFrameEncoding</b>
	/// </summary>
	public readonly VideoEncoderFrameSubregionLayoutMode SubregionFrameEncoding {
		get => _subregionFrameEncoding;
		init => _subregionFrameEncoding = value;
	}
	readonly VideoEncoderFrameSubregionLayoutMode _subregionFrameEncoding;

	/// <summary>
	/// <b>UINT ResolutionsListCount</b>
	/// </summary>
	public readonly uint ResolutionsListCount {
		get => _resolutionsListCount;
		init => _resolutionsListCount = value;
	}
	readonly uint _resolutionsListCount;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionDesc* PResolutionList {
		get => _pResolutionList;
		init => _pResolutionList = value;
	}
	readonly VideoEncoderPictureResolutionDesc* _pResolutionList;

	/// <summary>
	/// <b>UINT MaxReferenceFramesInDPB</b>
	/// </summary>
	public readonly uint MaxReferenceFramesInDPB {
		get => _maxReferenceFramesInDPB;
		init => _maxReferenceFramesInDPB = value;
	}
	readonly uint _maxReferenceFramesInDPB;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_VALIDATION_FLAGS ValidationFlags</b>
	/// </summary>
	public readonly VideoEncoderValidationFlags ValidationFlags {
		get => _validationFlags;
		init => _validationFlags = value;
	}
	readonly VideoEncoderValidationFlags _validationFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SUPPORT_FLAGS SupportFlags</b>
	/// </summary>
	public readonly VideoEncoderSupportFlags SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly VideoEncoderSupportFlags _supportFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC SuggestedProfile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc SuggestedProfile {
		get => _suggestedProfile;
		init => _suggestedProfile = value;
	}
	readonly VideoEncoderProfileDesc _suggestedProfile;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING SuggestedLevel</b>
	/// </summary>
	public readonly VideoEncoderLevelSetting SuggestedLevel {
		get => _suggestedLevel;
		init => _suggestedLevel = value;
	}
	readonly VideoEncoderLevelSetting _suggestedLevel;

	/// <summary>
	/// <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS* pResolutionDependentSupport</b>
	/// </summary>
	public readonly FeatureDataVideoEncoderResolutionSupportLimits* PResolutionDependentSupport {
		get => _pResolutionDependentSupport;
		init => _pResolutionDependentSupport = value;
	}
	readonly FeatureDataVideoEncoderResolutionSupportLimits* _pResolutionDependentSupport;

}

/// <summary>
/// STRUCTURE <b>D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoEncoderResourceRequirements {

	/// <summary>
	/// <b>UINT NodeIndex</b>
	/// </summary>
	public readonly uint NodeIndex {
		get => _nodeIndex;
		init => _nodeIndex = value;
	}
	readonly uint _nodeIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC Codec</b>
	/// </summary>
	public readonly VideoEncoderCodec Codec {
		get => _codec;
		init => _codec = value;
	}
	readonly VideoEncoderCodec _codec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC Profile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc Profile {
		get => _profile;
		init => _profile = value;
	}
	readonly VideoEncoderProfileDesc _profile;

	/// <summary>
	/// <b>DXGI_FORMAT InputFormat</b>
	/// </summary>
	public readonly DXGI.Format InputFormat {
		get => _inputFormat;
		init => _inputFormat = value;
	}
	readonly DXGI.Format _inputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionDesc PictureTargetResolution {
		get => _pictureTargetResolution;
		init => _pictureTargetResolution = value;
	}
	readonly VideoEncoderPictureResolutionDesc _pictureTargetResolution;

	/// <summary>
	/// <b>BOOL IsSupported</b>
	/// </summary>
	public readonly bool IsSupported {
		get => _isSupported != 0;
		init => _isSupported = value ? 1U : 0U;
	}
	readonly uint _isSupported;

	/// <summary>
	/// <b>UINT CompressedBitstreamBufferAccessAlignment</b>
	/// </summary>
	public readonly uint CompressedBitstreamBufferAccessAlignment {
		get => _compressedBitstreamBufferAccessAlignment;
		init => _compressedBitstreamBufferAccessAlignment = value;
	}
	readonly uint _compressedBitstreamBufferAccessAlignment;

	/// <summary>
	/// <b>UINT EncoderMetadataBufferAccessAlignment</b>
	/// </summary>
	public readonly uint EncoderMetadataBufferAccessAlignment {
		get => _encoderMetadataBufferAccessAlignment;
		init => _encoderMetadataBufferAccessAlignment = value;
	}
	readonly uint _encoderMetadataBufferAccessAlignment;

	/// <summary>
	/// <b>UINT MaxEncoderOutputMetadataBufferSize</b>
	/// </summary>
	public readonly uint MaxEncoderOutputMetadataBufferSize {
		get => _maxEncoderOutputMetadataBufferSize;
		init => _maxEncoderOutputMetadataBufferSize = value;
	}
	readonly uint _maxEncoderOutputMetadataBufferSize;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderDesc {

	/// <summary>
	/// <b>UINT NodeMask</b>
	/// </summary>
	public readonly uint NodeMask {
		get => _nodeMask;
		init => _nodeMask = value;
	}
	readonly uint _nodeMask;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FLAGS Flags</b>
	/// </summary>
	public readonly VideoEncoderFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoEncoderFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC EncodeCodec</b>
	/// </summary>
	public readonly VideoEncoderCodec EncodeCodec {
		get => _encodeCodec;
		init => _encodeCodec = value;
	}
	readonly VideoEncoderCodec _encodeCodec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc EncodeProfile {
		get => _encodeProfile;
		init => _encodeProfile = value;
	}
	readonly VideoEncoderProfileDesc _encodeProfile;

	/// <summary>
	/// <b>DXGI_FORMAT InputFormat</b>
	/// </summary>
	public readonly DXGI.Format InputFormat {
		get => _inputFormat;
		init => _inputFormat = value;
	}
	readonly DXGI.Format _inputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration</b>
	/// </summary>
	public readonly VideoEncoderCodecConfiguration CodecConfiguration {
		get => _codecConfiguration;
		init => _codecConfiguration = value;
	}
	readonly VideoEncoderCodecConfiguration _codecConfiguration;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE MaxMotionEstimationPrecision</b>
	/// </summary>
	public readonly VideoEncoderMotionEstimationPrecisionMode MaxMotionEstimationPrecision {
		get => _maxMotionEstimationPrecision;
		init => _maxMotionEstimationPrecision = value;
	}
	readonly VideoEncoderMotionEstimationPrecisionMode _maxMotionEstimationPrecision;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderReferencePictureDescriptorH264 {

	/// <summary>
	/// <b>UINT ReconstructedPictureResourceIndex</b>
	/// </summary>
	public readonly uint ReconstructedPictureResourceIndex {
		get => _reconstructedPictureResourceIndex;
		init => _reconstructedPictureResourceIndex = value;
	}
	readonly uint _reconstructedPictureResourceIndex;

	/// <summary>
	/// <b>BOOL IsLongTermReference</b>
	/// </summary>
	public readonly bool IsLongTermReference {
		get => _isLongTermReference != 0;
		init => _isLongTermReference = value ? 1U : 0U;
	}
	readonly uint _isLongTermReference;

	/// <summary>
	/// <b>UINT LongTermPictureIdx</b>
	/// </summary>
	public readonly uint LongTermPictureIdx {
		get => _longTermPictureIdx;
		init => _longTermPictureIdx = value;
	}
	readonly uint _longTermPictureIdx;

	/// <summary>
	/// <b>UINT PictureOrderCountNumber</b>
	/// </summary>
	public readonly uint PictureOrderCountNumber {
		get => _pictureOrderCountNumber;
		init => _pictureOrderCountNumber = value;
	}
	readonly uint _pictureOrderCountNumber;

	/// <summary>
	/// <b>UINT FrameDecodingOrderNumber</b>
	/// </summary>
	public readonly uint FrameDecodingOrderNumber {
		get => _frameDecodingOrderNumber;
		init => _frameDecodingOrderNumber = value;
	}
	readonly uint _frameDecodingOrderNumber;

	/// <summary>
	/// <b>UINT TemporalLayerIndex</b>
	/// </summary>
	public readonly uint TemporalLayerIndex {
		get => _temporalLayerIndex;
		init => _temporalLayerIndex = value;
	}
	readonly uint _temporalLayerIndex;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation {

	/// <summary>
	/// <b>UCHAR memory_management_control_operation</b>
	/// </summary>
	public readonly byte Memory_management_control_operation {
		get => _memory_management_control_operation;
		init => _memory_management_control_operation = value;
	}
	readonly byte _memory_management_control_operation;

	/// <summary>
	/// <b>UINT difference_of_pic_nums_minus1</b>
	/// </summary>
	public readonly uint Difference_of_pic_nums_minus1 {
		get => _difference_of_pic_nums_minus1;
		init => _difference_of_pic_nums_minus1 = value;
	}
	readonly uint _difference_of_pic_nums_minus1;

	/// <summary>
	/// <b>UINT long_term_pic_num</b>
	/// </summary>
	public readonly uint Long_term_pic_num {
		get => _long_term_pic_num;
		init => _long_term_pic_num = value;
	}
	readonly uint _long_term_pic_num;

	/// <summary>
	/// <b>UINT long_term_frame_idx</b>
	/// </summary>
	public readonly uint Long_term_frame_idx {
		get => _long_term_frame_idx;
		init => _long_term_frame_idx = value;
	}
	readonly uint _long_term_frame_idx;

	/// <summary>
	/// <b>UINT max_long_term_frame_idx_plus1</b>
	/// </summary>
	public readonly uint Max_long_term_frame_idx_plus1 {
		get => _max_long_term_frame_idx_plus1;
		init => _max_long_term_frame_idx_plus1 = value;
	}
	readonly uint _max_long_term_frame_idx_plus1;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation {

	/// <summary>
	/// <b>UCHAR modification_of_pic_nums_idc</b>
	/// </summary>
	public readonly byte Modification_of_pic_nums_idc {
		get => _modification_of_pic_nums_idc;
		init => _modification_of_pic_nums_idc = value;
	}
	readonly byte _modification_of_pic_nums_idc;

	/// <summary>
	/// <b>UINT abs_diff_pic_num_minus1</b>
	/// </summary>
	public readonly uint Abs_diff_pic_num_minus1 {
		get => _abs_diff_pic_num_minus1;
		init => _abs_diff_pic_num_minus1 = value;
	}
	readonly uint _abs_diff_pic_num_minus1;

	/// <summary>
	/// <b>UINT long_term_pic_num</b>
	/// </summary>
	public readonly uint Long_term_pic_num {
		get => _long_term_pic_num;
		init => _long_term_pic_num = value;
	}
	readonly uint _long_term_pic_num;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlCodecDataH264 {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS Flags</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecDataH264Flags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoEncoderPictureControlCodecDataH264Flags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_H264 FrameType</b>
	/// </summary>
	public readonly VideoEncoderFrameTypeH264 FrameType {
		get => _frameType;
		init => _frameType = value;
	}
	readonly VideoEncoderFrameTypeH264 _frameType;

	/// <summary>
	/// <b>UINT pic_parameter_set_id</b>
	/// </summary>
	public readonly uint Pic_parameter_set_id {
		get => _pic_parameter_set_id;
		init => _pic_parameter_set_id = value;
	}
	readonly uint _pic_parameter_set_id;

	/// <summary>
	/// <b>UINT idr_pic_id</b>
	/// </summary>
	public readonly uint Idr_pic_id {
		get => _idr_pic_id;
		init => _idr_pic_id = value;
	}
	readonly uint _idr_pic_id;

	/// <summary>
	/// <b>UINT PictureOrderCountNumber</b>
	/// </summary>
	public readonly uint PictureOrderCountNumber {
		get => _pictureOrderCountNumber;
		init => _pictureOrderCountNumber = value;
	}
	readonly uint _pictureOrderCountNumber;

	/// <summary>
	/// <b>UINT FrameDecodingOrderNumber</b>
	/// </summary>
	public readonly uint FrameDecodingOrderNumber {
		get => _frameDecodingOrderNumber;
		init => _frameDecodingOrderNumber = value;
	}
	readonly uint _frameDecodingOrderNumber;

	/// <summary>
	/// <b>UINT TemporalLayerIndex</b>
	/// </summary>
	public readonly uint TemporalLayerIndex {
		get => _temporalLayerIndex;
		init => _temporalLayerIndex = value;
	}
	readonly uint _temporalLayerIndex;

	/// <summary>
	/// <b>UINT List0ReferenceFramesCount</b>
	/// </summary>
	public readonly uint List0ReferenceFramesCount {
		get => _list0ReferenceFramesCount;
		init => _list0ReferenceFramesCount = value;
	}
	readonly uint _list0ReferenceFramesCount;

	/// <summary>
	/// <b>UINT* pList0ReferenceFrames</b>
	/// </summary>
	public readonly uint* PList0ReferenceFrames {
		get => _pList0ReferenceFrames;
		init => _pList0ReferenceFrames = value;
	}
	readonly uint* _pList0ReferenceFrames;

	/// <summary>
	/// <b>UINT List1ReferenceFramesCount</b>
	/// </summary>
	public readonly uint List1ReferenceFramesCount {
		get => _list1ReferenceFramesCount;
		init => _list1ReferenceFramesCount = value;
	}
	readonly uint _list1ReferenceFramesCount;

	/// <summary>
	/// <b>UINT* pList1ReferenceFrames</b>
	/// </summary>
	public readonly uint* PList1ReferenceFrames {
		get => _pList1ReferenceFrames;
		init => _pList1ReferenceFrames = value;
	}
	readonly uint* _pList1ReferenceFrames;

	/// <summary>
	/// <b>UINT ReferenceFramesReconPictureDescriptorsCount</b>
	/// </summary>
	public readonly uint ReferenceFramesReconPictureDescriptorsCount {
		get => _referenceFramesReconPictureDescriptorsCount;
		init => _referenceFramesReconPictureDescriptorsCount = value;
	}
	readonly uint _referenceFramesReconPictureDescriptorsCount;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264* pReferenceFramesReconPictureDescriptors</b>
	/// </summary>
	public readonly VideoEncoderReferencePictureDescriptorH264* PReferenceFramesReconPictureDescriptors {
		get => _pReferenceFramesReconPictureDescriptors;
		init => _pReferenceFramesReconPictureDescriptors = value;
	}
	readonly VideoEncoderReferencePictureDescriptorH264* _pReferenceFramesReconPictureDescriptors;

	/// <summary>
	/// <b>UCHAR adaptive_ref_pic_marking_mode_flag</b>
	/// </summary>
	public readonly byte Adaptive_ref_pic_marking_mode_flag {
		get => _adaptive_ref_pic_marking_mode_flag;
		init => _adaptive_ref_pic_marking_mode_flag = value;
	}
	readonly byte _adaptive_ref_pic_marking_mode_flag;

	/// <summary>
	/// <b>UINT RefPicMarkingOperationsCommandsCount</b>
	/// </summary>
	public readonly uint RefPicMarkingOperationsCommandsCount {
		get => _refPicMarkingOperationsCommandsCount;
		init => _refPicMarkingOperationsCommandsCount = value;
	}
	readonly uint _refPicMarkingOperationsCommandsCount;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION* pRefPicMarkingOperationsCommands</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation* PRefPicMarkingOperationsCommands {
		get => _pRefPicMarkingOperationsCommands;
		init => _pRefPicMarkingOperationsCommands = value;
	}
	readonly VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation* _pRefPicMarkingOperationsCommands;

	/// <summary>
	/// <b>UINT List0RefPicModificationsCount</b>
	/// </summary>
	public readonly uint List0RefPicModificationsCount {
		get => _list0RefPicModificationsCount;
		init => _list0RefPicModificationsCount = value;
	}
	readonly uint _list0RefPicModificationsCount;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION* pList0RefPicModifications</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* PList0RefPicModifications {
		get => _pList0RefPicModifications;
		init => _pList0RefPicModifications = value;
	}
	readonly VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* _pList0RefPicModifications;

	/// <summary>
	/// <b>UINT List1RefPicModificationsCount</b>
	/// </summary>
	public readonly uint List1RefPicModificationsCount {
		get => _list1RefPicModificationsCount;
		init => _list1RefPicModificationsCount = value;
	}
	readonly uint _list1RefPicModificationsCount;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION* pList1RefPicModifications</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* PList1RefPicModifications {
		get => _pList1RefPicModifications;
		init => _pList1RefPicModifications = value;
	}
	readonly VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* _pList1RefPicModifications;

	/// <summary>
	/// <b>UINT QPMapValuesCount</b>
	/// </summary>
	public readonly uint QPMapValuesCount {
		get => _qPMapValuesCount;
		init => _qPMapValuesCount = value;
	}
	readonly uint _qPMapValuesCount;

	/// <summary>
	/// <b>INT8* pRateControlQPMap</b>
	/// </summary>
	public readonly sbyte* PRateControlQPMap {
		get => _pRateControlQPMap;
		init => _pRateControlQPMap = value;
	}
	readonly sbyte* _pRateControlQPMap;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderReferencePictureDescriptorHevc {

	/// <summary>
	/// <b>UINT ReconstructedPictureResourceIndex</b>
	/// </summary>
	public readonly uint ReconstructedPictureResourceIndex {
		get => _reconstructedPictureResourceIndex;
		init => _reconstructedPictureResourceIndex = value;
	}
	readonly uint _reconstructedPictureResourceIndex;

	/// <summary>
	/// <b>BOOL IsRefUsedByCurrentPic</b>
	/// </summary>
	public readonly bool IsRefUsedByCurrentPic {
		get => _isRefUsedByCurrentPic != 0;
		init => _isRefUsedByCurrentPic = value ? 1U : 0U;
	}
	readonly uint _isRefUsedByCurrentPic;

	/// <summary>
	/// <b>BOOL IsLongTermReference</b>
	/// </summary>
	public readonly bool IsLongTermReference {
		get => _isLongTermReference != 0;
		init => _isLongTermReference = value ? 1U : 0U;
	}
	readonly uint _isLongTermReference;

	/// <summary>
	/// <b>UINT PictureOrderCountNumber</b>
	/// </summary>
	public readonly uint PictureOrderCountNumber {
		get => _pictureOrderCountNumber;
		init => _pictureOrderCountNumber = value;
	}
	readonly uint _pictureOrderCountNumber;

	/// <summary>
	/// <b>UINT TemporalLayerIndex</b>
	/// </summary>
	public readonly uint TemporalLayerIndex {
		get => _temporalLayerIndex;
		init => _temporalLayerIndex = value;
	}
	readonly uint _temporalLayerIndex;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlCodecDataHevc {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS Flags</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecDataHevcFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoEncoderPictureControlCodecDataHevcFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC FrameType</b>
	/// </summary>
	public readonly VideoEncoderFrameTypeHevc FrameType {
		get => _frameType;
		init => _frameType = value;
	}
	readonly VideoEncoderFrameTypeHevc _frameType;

	/// <summary>
	/// <b>UINT slice_pic_parameter_set_id</b>
	/// </summary>
	public readonly uint Slice_pic_parameter_set_id {
		get => _slice_pic_parameter_set_id;
		init => _slice_pic_parameter_set_id = value;
	}
	readonly uint _slice_pic_parameter_set_id;

	/// <summary>
	/// <b>UINT PictureOrderCountNumber</b>
	/// </summary>
	public readonly uint PictureOrderCountNumber {
		get => _pictureOrderCountNumber;
		init => _pictureOrderCountNumber = value;
	}
	readonly uint _pictureOrderCountNumber;

	/// <summary>
	/// <b>UINT TemporalLayerIndex</b>
	/// </summary>
	public readonly uint TemporalLayerIndex {
		get => _temporalLayerIndex;
		init => _temporalLayerIndex = value;
	}
	readonly uint _temporalLayerIndex;

	/// <summary>
	/// <b>UINT List0ReferenceFramesCount</b>
	/// </summary>
	public readonly uint List0ReferenceFramesCount {
		get => _list0ReferenceFramesCount;
		init => _list0ReferenceFramesCount = value;
	}
	readonly uint _list0ReferenceFramesCount;

	/// <summary>
	/// <b>UINT* pList0ReferenceFrames</b>
	/// </summary>
	public readonly uint* PList0ReferenceFrames {
		get => _pList0ReferenceFrames;
		init => _pList0ReferenceFrames = value;
	}
	readonly uint* _pList0ReferenceFrames;

	/// <summary>
	/// <b>UINT List1ReferenceFramesCount</b>
	/// </summary>
	public readonly uint List1ReferenceFramesCount {
		get => _list1ReferenceFramesCount;
		init => _list1ReferenceFramesCount = value;
	}
	readonly uint _list1ReferenceFramesCount;

	/// <summary>
	/// <b>UINT* pList1ReferenceFrames</b>
	/// </summary>
	public readonly uint* PList1ReferenceFrames {
		get => _pList1ReferenceFrames;
		init => _pList1ReferenceFrames = value;
	}
	readonly uint* _pList1ReferenceFrames;

	/// <summary>
	/// <b>UINT ReferenceFramesReconPictureDescriptorsCount</b>
	/// </summary>
	public readonly uint ReferenceFramesReconPictureDescriptorsCount {
		get => _referenceFramesReconPictureDescriptorsCount;
		init => _referenceFramesReconPictureDescriptorsCount = value;
	}
	readonly uint _referenceFramesReconPictureDescriptorsCount;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC* pReferenceFramesReconPictureDescriptors</b>
	/// </summary>
	public readonly VideoEncoderReferencePictureDescriptorHevc* PReferenceFramesReconPictureDescriptors {
		get => _pReferenceFramesReconPictureDescriptors;
		init => _pReferenceFramesReconPictureDescriptors = value;
	}
	readonly VideoEncoderReferencePictureDescriptorHevc* _pReferenceFramesReconPictureDescriptors;

	/// <summary>
	/// <b>UINT List0RefPicModificationsCount</b>
	/// </summary>
	public readonly uint List0RefPicModificationsCount {
		get => _list0RefPicModificationsCount;
		init => _list0RefPicModificationsCount = value;
	}
	readonly uint _list0RefPicModificationsCount;

	/// <summary>
	/// <b>UINT* pList0RefPicModifications</b>
	/// </summary>
	public readonly uint* PList0RefPicModifications {
		get => _pList0RefPicModifications;
		init => _pList0RefPicModifications = value;
	}
	readonly uint* _pList0RefPicModifications;

	/// <summary>
	/// <b>UINT List1RefPicModificationsCount</b>
	/// </summary>
	public readonly uint List1RefPicModificationsCount {
		get => _list1RefPicModificationsCount;
		init => _list1RefPicModificationsCount = value;
	}
	readonly uint _list1RefPicModificationsCount;

	/// <summary>
	/// <b>UINT* pList1RefPicModifications</b>
	/// </summary>
	public readonly uint* PList1RefPicModifications {
		get => _pList1RefPicModifications;
		init => _pList1RefPicModifications = value;
	}
	readonly uint* _pList1RefPicModifications;

	/// <summary>
	/// <b>UINT QPMapValuesCount</b>
	/// </summary>
	public readonly uint QPMapValuesCount {
		get => _qPMapValuesCount;
		init => _qPMapValuesCount = value;
	}
	readonly uint _qPMapValuesCount;

	/// <summary>
	/// <b>INT8* pRateControlQPMap</b>
	/// </summary>
	public readonly sbyte* PRateControlQPMap {
		get => _pRateControlQPMap;
		init => _pRateControlQPMap = value;
	}
	readonly sbyte* _pRateControlQPMap;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlCodecData {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_83 {

		[FieldOffset (0)] public VideoEncoderPictureControlCodecDataH264* _pH264PicData;
		[FieldOffset (0)] public VideoEncoderPictureControlCodecDataHevc* _pHEVCPicData;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264* pH264PicData</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecDataH264* PH264PicData {
		get => __aSP_AUTO_GENERATED_FIELD_83._pH264PicData;
		init => __aSP_AUTO_GENERATED_FIELD_83._pH264PicData = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC* pHEVCPicData</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecDataHevc* PHEVCPicData {
		get => __aSP_AUTO_GENERATED_FIELD_83._pHEVCPicData;
		init => __aSP_AUTO_GENERATED_FIELD_83._pHEVCPicData = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_83 __aSP_AUTO_GENERATED_FIELD_83;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODE_REFERENCE_FRAMES</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncodeReferenceFrames {

	/// <summary>
	/// <b>UINT NumTexture2Ds</b>
	/// </summary>
	public readonly uint NumTexture2Ds {
		get => _numTexture2Ds;
		init => _numTexture2Ds = value;
	}
	readonly uint _numTexture2Ds;

	/// <summary>
	/// <b>ID3D12Resource** ppTexture2Ds</b>
	/// </summary>
	public readonly T** PpTexture2Ds<T> () where T : unmanaged, IResource => (T**) _ppTexture2Ds;
	readonly void* _ppTexture2Ds;

	/// <summary>
	/// <b>UINT* pSubresources</b>
	/// </summary>
	public readonly uint* PSubresources {
		get => _pSubresources;
		init => _pSubresources = value;
	}
	readonly uint* _pSubresources;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlDesc {

	/// <summary>
	/// <b>UINT IntraRefreshFrameIndex</b>
	/// </summary>
	public readonly uint IntraRefreshFrameIndex {
		get => _intraRefreshFrameIndex;
		init => _intraRefreshFrameIndex = value;
	}
	readonly uint _intraRefreshFrameIndex;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS Flags</b>
	/// </summary>
	public readonly VideoEncoderPictureControlFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoEncoderPictureControlFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA PictureControlCodecData</b>
	/// </summary>
	public readonly VideoEncoderPictureControlCodecData PictureControlCodecData {
		get => _pictureControlCodecData;
		init => _pictureControlCodecData = value;
	}
	readonly VideoEncoderPictureControlCodecData _pictureControlCodecData;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODE_REFERENCE_FRAMES ReferenceFrames</b>
	/// </summary>
	public readonly VideoEncodeReferenceFrames ReferenceFrames {
		get => _referenceFrames;
		init => _referenceFrames = value;
	}
	readonly VideoEncodeReferenceFrames _referenceFrames;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlSubregionsLayoutDataSlices {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_85 {

		[FieldOffset (0)] public uint _maxBytesPerSlice;
		[FieldOffset (0)] public uint _numberOfCodingUnitsPerSlice;
		[FieldOffset (0)] public uint _numberOfRowsPerSlice;
		[FieldOffset (0)] public uint _numberOfSlicesPerFrame;
	}

	/// <summary>
	/// <b>UINT MaxBytesPerSlice</b>
	/// </summary>
	public readonly uint MaxBytesPerSlice {
		get => __aSP_AUTO_GENERATED_FIELD_85._maxBytesPerSlice;
		init => __aSP_AUTO_GENERATED_FIELD_85._maxBytesPerSlice = value;
	}

	/// <summary>
	/// <b>UINT NumberOfCodingUnitsPerSlice</b>
	/// </summary>
	public readonly uint NumberOfCodingUnitsPerSlice {
		get => __aSP_AUTO_GENERATED_FIELD_85._numberOfCodingUnitsPerSlice;
		init => __aSP_AUTO_GENERATED_FIELD_85._numberOfCodingUnitsPerSlice = value;
	}

	/// <summary>
	/// <b>UINT NumberOfRowsPerSlice</b>
	/// </summary>
	public readonly uint NumberOfRowsPerSlice {
		get => __aSP_AUTO_GENERATED_FIELD_85._numberOfRowsPerSlice;
		init => __aSP_AUTO_GENERATED_FIELD_85._numberOfRowsPerSlice = value;
	}

	/// <summary>
	/// <b>UINT NumberOfSlicesPerFrame</b>
	/// </summary>
	public readonly uint NumberOfSlicesPerFrame {
		get => __aSP_AUTO_GENERATED_FIELD_85._numberOfSlicesPerFrame;
		init => __aSP_AUTO_GENERATED_FIELD_85._numberOfSlicesPerFrame = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_85 __aSP_AUTO_GENERATED_FIELD_85;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderPictureControlSubregionsLayoutData {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_87 {

		[FieldOffset (0)] public VideoEncoderPictureControlSubregionsLayoutDataSlices* _pSlicesPartition_H264;
		[FieldOffset (0)] public VideoEncoderPictureControlSubregionsLayoutDataSlices* _pSlicesPartition_HEVC;
	}

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES* pSlicesPartition_H264</b>
	/// </summary>
	public readonly VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartition_H264 {
		get => __aSP_AUTO_GENERATED_FIELD_87._pSlicesPartition_H264;
		init => __aSP_AUTO_GENERATED_FIELD_87._pSlicesPartition_H264 = value;
	}

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES* pSlicesPartition_HEVC</b>
	/// </summary>
	public readonly VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartition_HEVC {
		get => __aSP_AUTO_GENERATED_FIELD_87._pSlicesPartition_HEVC;
		init => __aSP_AUTO_GENERATED_FIELD_87._pSlicesPartition_HEVC = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_87 __aSP_AUTO_GENERATED_FIELD_87;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderSequenceControlDesc {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS Flags</b>
	/// </summary>
	public readonly VideoEncoderSequenceControlFlags Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly VideoEncoderSequenceControlFlags _flags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_INTRA_REFRESH IntraRefreshConfig</b>
	/// </summary>
	public readonly VideoEncoderIntraRefresh IntraRefreshConfig {
		get => _intraRefreshConfig;
		init => _intraRefreshConfig = value;
	}
	readonly VideoEncoderIntraRefresh _intraRefreshConfig;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl</b>
	/// </summary>
	public readonly VideoEncoderRateControl RateControl {
		get => _rateControl;
		init => _rateControl = value;
	}
	readonly VideoEncoderRateControl _rateControl;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionDesc PictureTargetResolution {
		get => _pictureTargetResolution;
		init => _pictureTargetResolution = value;
	}
	readonly VideoEncoderPictureResolutionDesc _pictureTargetResolution;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SelectedLayoutMode</b>
	/// </summary>
	public readonly VideoEncoderFrameSubregionLayoutMode SelectedLayoutMode {
		get => _selectedLayoutMode;
		init => _selectedLayoutMode = value;
	}
	readonly VideoEncoderFrameSubregionLayoutMode _selectedLayoutMode;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA FrameSubregionsLayoutData</b>
	/// </summary>
	public readonly VideoEncoderPictureControlSubregionsLayoutData FrameSubregionsLayoutData {
		get => _frameSubregionsLayoutData;
		init => _frameSubregionsLayoutData = value;
	}
	readonly VideoEncoderPictureControlSubregionsLayoutData _frameSubregionsLayoutData;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence</b>
	/// </summary>
	public readonly VideoEncoderSequenceGopStructure CodecGopSequence {
		get => _codecGopSequence;
		init => _codecGopSequence = value;
	}
	readonly VideoEncoderSequenceGopStructure _codecGopSequence;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderEncodeframeInputArguments {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC SequenceControlDesc</b>
	/// </summary>
	public readonly VideoEncoderSequenceControlDesc SequenceControlDesc {
		get => _sequenceControlDesc;
		init => _sequenceControlDesc = value;
	}
	readonly VideoEncoderSequenceControlDesc _sequenceControlDesc;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC PictureControlDesc</b>
	/// </summary>
	public readonly VideoEncoderPictureControlDesc PictureControlDesc {
		get => _pictureControlDesc;
		init => _pictureControlDesc = value;
	}
	readonly VideoEncoderPictureControlDesc _pictureControlDesc;

	/// <summary>
	/// <b>ID3D12Resource* pInputFrame</b>
	/// </summary>
	public readonly T* PInputFrame<T> () where T : unmanaged, IResource => (T*) _pInputFrame;
	readonly void* _pInputFrame;

	/// <summary>
	/// <b>UINT InputFrameSubresource</b>
	/// </summary>
	public readonly uint InputFrameSubresource {
		get => _inputFrameSubresource;
		init => _inputFrameSubresource = value;
	}
	readonly uint _inputFrameSubresource;

	/// <summary>
	/// <b>UINT CurrentFrameBitstreamMetadataSize</b>
	/// </summary>
	public readonly uint CurrentFrameBitstreamMetadataSize {
		get => _currentFrameBitstreamMetadataSize;
		init => _currentFrameBitstreamMetadataSize = value;
	}
	readonly uint _currentFrameBitstreamMetadataSize;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderCompressedBitstream {

	/// <summary>
	/// <b>ID3D12Resource* pBuffer</b>
	/// </summary>
	public readonly T* PBuffer<T> () where T : unmanaged, IResource => (T*) _pBuffer;
	readonly void* _pBuffer;

	/// <summary>
	/// <b>UINT64 FrameStartOffset</b>
	/// </summary>
	public readonly ulong FrameStartOffset {
		get => _frameStartOffset;
		init => _frameStartOffset = value;
	}
	readonly ulong _frameStartOffset;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderReconstructedPicture {

	/// <summary>
	/// <b>ID3D12Resource* pReconstructedPicture</b>
	/// </summary>
	public readonly T* PReconstructedPicture<T> () where T : unmanaged, IResource => (T*) _pReconstructedPicture;
	readonly void* _pReconstructedPicture;

	/// <summary>
	/// <b>UINT ReconstructedPictureSubresource</b>
	/// </summary>
	public readonly uint ReconstructedPictureSubresource {
		get => _reconstructedPictureSubresource;
		init => _reconstructedPictureSubresource = value;
	}
	readonly uint _reconstructedPictureSubresource;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderFrameSubregionMetadata {

	/// <summary>
	/// <b>UINT64 bSize</b>
	/// </summary>
	public readonly ulong BSize {
		get => _bSize;
		init => _bSize = value;
	}
	readonly ulong _bSize;

	/// <summary>
	/// <b>UINT64 bStartOffset</b>
	/// </summary>
	public readonly ulong BStartOffset {
		get => _bStartOffset;
		init => _bStartOffset = value;
	}
	readonly ulong _bStartOffset;

	/// <summary>
	/// <b>UINT64 bHeaderSize</b>
	/// </summary>
	public readonly ulong BHeaderSize {
		get => _bHeaderSize;
		init => _bHeaderSize = value;
	}
	readonly ulong _bHeaderSize;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderOutputMetadataStatistics {

	/// <summary>
	/// <b>UINT64 AverageQP</b>
	/// </summary>
	public readonly ulong AverageQP {
		get => _averageQP;
		init => _averageQP = value;
	}
	readonly ulong _averageQP;

	/// <summary>
	/// <b>UINT64 IntraCodingUnitsCount</b>
	/// </summary>
	public readonly ulong IntraCodingUnitsCount {
		get => _intraCodingUnitsCount;
		init => _intraCodingUnitsCount = value;
	}
	readonly ulong _intraCodingUnitsCount;

	/// <summary>
	/// <b>UINT64 InterCodingUnitsCount</b>
	/// </summary>
	public readonly ulong InterCodingUnitsCount {
		get => _interCodingUnitsCount;
		init => _interCodingUnitsCount = value;
	}
	readonly ulong _interCodingUnitsCount;

	/// <summary>
	/// <b>UINT64 SkipCodingUnitsCount</b>
	/// </summary>
	public readonly ulong SkipCodingUnitsCount {
		get => _skipCodingUnitsCount;
		init => _skipCodingUnitsCount = value;
	}
	readonly ulong _skipCodingUnitsCount;

	/// <summary>
	/// <b>UINT64 AverageMotionEstimationXDirection</b>
	/// </summary>
	public readonly ulong AverageMotionEstimationXDirection {
		get => _averageMotionEstimationXDirection;
		init => _averageMotionEstimationXDirection = value;
	}
	readonly ulong _averageMotionEstimationXDirection;

	/// <summary>
	/// <b>UINT64 AverageMotionEstimationYDirection</b>
	/// </summary>
	public readonly ulong AverageMotionEstimationYDirection {
		get => _averageMotionEstimationYDirection;
		init => _averageMotionEstimationYDirection = value;
	}
	readonly ulong _averageMotionEstimationYDirection;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_OUTPUT_METADATA</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderOutputMetadata {

	/// <summary>
	/// <b>UINT64 EncodeErrorFlags</b>
	/// </summary>
	public readonly ulong EncodeErrorFlags {
		get => _encodeErrorFlags;
		init => _encodeErrorFlags = value;
	}
	readonly ulong _encodeErrorFlags;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS EncodeStats</b>
	/// </summary>
	public readonly VideoEncoderOutputMetadataStatistics EncodeStats {
		get => _encodeStats;
		init => _encodeStats = value;
	}
	readonly VideoEncoderOutputMetadataStatistics _encodeStats;

	/// <summary>
	/// <b>UINT64 EncodedBitstreamWrittenBytesCount</b>
	/// </summary>
	public readonly ulong EncodedBitstreamWrittenBytesCount {
		get => _encodedBitstreamWrittenBytesCount;
		init => _encodedBitstreamWrittenBytesCount = value;
	}
	readonly ulong _encodedBitstreamWrittenBytesCount;

	/// <summary>
	/// <b>UINT64 WrittenSubregionsCount</b>
	/// </summary>
	public readonly ulong WrittenSubregionsCount {
		get => _writtenSubregionsCount;
		init => _writtenSubregionsCount = value;
	}
	readonly ulong _writtenSubregionsCount;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderEncodeOperationMetadataBuffer {

	/// <summary>
	/// <b>ID3D12Resource* pBuffer</b>
	/// </summary>
	public readonly T* PBuffer<T> () where T : unmanaged, IResource => (T*) _pBuffer;
	readonly void* _pBuffer;

	/// <summary>
	/// <b>UINT64 Offset</b>
	/// </summary>
	public readonly ulong Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly ulong _offset;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderResolveMetadataInputArguments {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_CODEC EncoderCodec</b>
	/// </summary>
	public readonly VideoEncoderCodec EncoderCodec {
		get => _encoderCodec;
		init => _encoderCodec = value;
	}
	readonly VideoEncoderCodec _encoderCodec;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PROFILE_DESC EncoderProfile</b>
	/// </summary>
	public readonly VideoEncoderProfileDesc EncoderProfile {
		get => _encoderProfile;
		init => _encoderProfile = value;
	}
	readonly VideoEncoderProfileDesc _encoderProfile;

	/// <summary>
	/// <b>DXGI_FORMAT EncoderInputFormat</b>
	/// </summary>
	public readonly DXGI.Format EncoderInputFormat {
		get => _encoderInputFormat;
		init => _encoderInputFormat = value;
	}
	readonly DXGI.Format _encoderInputFormat;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncodedPictureEffectiveResolution</b>
	/// </summary>
	public readonly VideoEncoderPictureResolutionDesc EncodedPictureEffectiveResolution {
		get => _encodedPictureEffectiveResolution;
		init => _encodedPictureEffectiveResolution = value;
	}
	readonly VideoEncoderPictureResolutionDesc _encodedPictureEffectiveResolution;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER HWLayoutMetadata</b>
	/// </summary>
	public readonly VideoEncoderEncodeOperationMetadataBuffer HWLayoutMetadata {
		get => _hWLayoutMetadata;
		init => _hWLayoutMetadata = value;
	}
	readonly VideoEncoderEncodeOperationMetadataBuffer _hWLayoutMetadata;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_RESOLVE_METADATA_OUTPUT_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderResolveMetadataOutputArguments {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER ResolvedLayoutMetadata</b>
	/// </summary>
	public readonly VideoEncoderEncodeOperationMetadataBuffer ResolvedLayoutMetadata {
		get => _resolvedLayoutMetadata;
		init => _resolvedLayoutMetadata = value;
	}
	readonly VideoEncoderEncodeOperationMetadataBuffer _resolvedLayoutMetadata;

}

/// <summary>
/// STRUCTURE <b>D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS</b><br/>
/// D3D12VIDEO.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoEncoderEncodeframeOutputArguments {

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM Bitstream</b>
	/// </summary>
	public readonly VideoEncoderCompressedBitstream Bitstream {
		get => _bitstream;
		init => _bitstream = value;
	}
	readonly VideoEncoderCompressedBitstream _bitstream;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE ReconstructedPicture</b>
	/// </summary>
	public readonly VideoEncoderReconstructedPicture ReconstructedPicture {
		get => _reconstructedPicture;
		init => _reconstructedPicture = value;
	}
	readonly VideoEncoderReconstructedPicture _reconstructedPicture;

	/// <summary>
	/// <b>D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER EncoderOutputMetadata</b>
	/// </summary>
	public readonly VideoEncoderEncodeOperationMetadataBuffer EncoderOutputMetadata {
		get => _encoderOutputMetadata;
		init => _encoderOutputMetadata = value;
	}
	readonly VideoEncoderEncodeOperationMetadataBuffer _encoderOutputMetadata;

}

/// <summary>
/// CALLBACK <b>D3D12MessageFunc</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public delegate void MessageFunc (MessageCategory category, MessageSeverity severity, MessageId id, char* pDescription, void* pContext);
