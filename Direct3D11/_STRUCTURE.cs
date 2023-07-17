using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// STRUCTURE <b>__MIDL___MIDL_itf_d3d11_0000_0034_0001</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MidlMidlitfd3d11000000340001 {

	/// <summary>
	/// <b>UINT ProtectionEnabled : 1</b>
	/// </summary>
	public readonly uint ProtectionEnabled {
		get => (_ASP_AUTO_GENERATED_FIELD_116 << 0) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_116 = ((value & 0b1) << 31) + (_ASP_AUTO_GENERATED_FIELD_116 & 0b01111111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT OverlayOrFullscreenRequired : 1</b>
	/// </summary>
	public readonly uint OverlayOrFullscreenRequired {
		get => (_ASP_AUTO_GENERATED_FIELD_116 << 1) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_116 = ((value & 0b1) << 30) + (_ASP_AUTO_GENERATED_FIELD_116 & 0b10111111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT Reserved : 30</b>
	/// </summary>
	public readonly uint Reserved {
		get => (_ASP_AUTO_GENERATED_FIELD_116 << 2) >>> 2;
		init => _ASP_AUTO_GENERATED_FIELD_116 = ((value & 0b111111111111111111111111111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_116 & 0b11000000000000000000000000000000);
	}

	readonly uint _ASP_AUTO_GENERATED_FIELD_116;
}

/// <summary>
/// STRUCTURE <b>D3D11_INPUT_ELEMENT_DESC</b><br/>
/// D3D11.h
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
	/// <b>D3D11_INPUT_CLASSIFICATION InputSlotClass</b>
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
/// STRUCTURE <b>D3D11_SO_DECLARATION_ENTRY</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_VIEWPORT</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_DRAW_INSTANCED_INDIRECT_ARGS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DrawInstancedIndirectArgs {

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
/// STRUCTURE <b>D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DrawIndexedInstancedIndirectArgs {

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
/// STRUCTURE <b>D3D11_BOX</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_DEPTH_STENCILOP_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DepthStencilopDesc {

	/// <summary>
	/// <b>D3D11_STENCIL_OP StencilFailOp</b>
	/// </summary>
	public readonly StencilOp StencilFailOp {
		get => _stencilFailOp;
		init => _stencilFailOp = value;
	}
	readonly StencilOp _stencilFailOp;

	/// <summary>
	/// <b>D3D11_STENCIL_OP StencilDepthFailOp</b>
	/// </summary>
	public readonly StencilOp StencilDepthFailOp {
		get => _stencilDepthFailOp;
		init => _stencilDepthFailOp = value;
	}
	readonly StencilOp _stencilDepthFailOp;

	/// <summary>
	/// <b>D3D11_STENCIL_OP StencilPassOp</b>
	/// </summary>
	public readonly StencilOp StencilPassOp {
		get => _stencilPassOp;
		init => _stencilPassOp = value;
	}
	readonly StencilOp _stencilPassOp;

	/// <summary>
	/// <b>D3D11_COMPARISON_FUNC StencilFunc</b>
	/// </summary>
	public readonly ComparisonFunc StencilFunc {
		get => _stencilFunc;
		init => _stencilFunc = value;
	}
	readonly ComparisonFunc _stencilFunc;

}

/// <summary>
/// STRUCTURE <b>D3D11_DEPTH_STENCIL_DESC</b><br/>
/// D3D11.h
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
	/// <b>D3D11_DEPTH_WRITE_MASK DepthWriteMask</b>
	/// </summary>
	public readonly DepthWriteMask DepthWriteMask {
		get => _depthWriteMask;
		init => _depthWriteMask = value;
	}
	readonly DepthWriteMask _depthWriteMask;

	/// <summary>
	/// <b>D3D11_COMPARISON_FUNC DepthFunc</b>
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
	/// <b>D3D11_DEPTH_STENCILOP_DESC FrontFace</b>
	/// </summary>
	public readonly DepthStencilopDesc FrontFace {
		get => _frontFace;
		init => _frontFace = value;
	}
	readonly DepthStencilopDesc _frontFace;

	/// <summary>
	/// <b>D3D11_DEPTH_STENCILOP_DESC BackFace</b>
	/// </summary>
	public readonly DepthStencilopDesc BackFace {
		get => _backFace;
		init => _backFace = value;
	}
	readonly DepthStencilopDesc _backFace;

}

/// <summary>
/// STRUCTURE <b>D3D11_RENDER_TARGET_BLEND_DESC</b><br/>
/// D3D11.h
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
	/// <b>D3D11_BLEND SrcBlend</b>
	/// </summary>
	public readonly Blend SrcBlend {
		get => _srcBlend;
		init => _srcBlend = value;
	}
	readonly Blend _srcBlend;

	/// <summary>
	/// <b>D3D11_BLEND DestBlend</b>
	/// </summary>
	public readonly Blend DestBlend {
		get => _destBlend;
		init => _destBlend = value;
	}
	readonly Blend _destBlend;

	/// <summary>
	/// <b>D3D11_BLEND_OP BlendOp</b>
	/// </summary>
	public readonly BlendOp BlendOp {
		get => _blendOp;
		init => _blendOp = value;
	}
	readonly BlendOp _blendOp;

	/// <summary>
	/// <b>D3D11_BLEND SrcBlendAlpha</b>
	/// </summary>
	public readonly Blend SrcBlendAlpha {
		get => _srcBlendAlpha;
		init => _srcBlendAlpha = value;
	}
	readonly Blend _srcBlendAlpha;

	/// <summary>
	/// <b>D3D11_BLEND DestBlendAlpha</b>
	/// </summary>
	public readonly Blend DestBlendAlpha {
		get => _destBlendAlpha;
		init => _destBlendAlpha = value;
	}
	readonly Blend _destBlendAlpha;

	/// <summary>
	/// <b>D3D11_BLEND_OP BlendOpAlpha</b>
	/// </summary>
	public readonly BlendOp BlendOpAlpha {
		get => _blendOpAlpha;
		init => _blendOpAlpha = value;
	}
	readonly BlendOp _blendOpAlpha;

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
/// STRUCTURE <b>D3D11_BLEND_DESC</b><br/>
/// D3D11.h
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
	/// <b>D3D11_RENDER_TARGET_BLEND_DESC RenderTarget [8]</b>
	/// </summary>
	public readonly Span<RenderTargetBlendDesc> RenderTarget {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _renderTarget)), 8);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_112 {
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_0;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_1;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_2;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_3;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_4;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_5;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_6;
		public RenderTargetBlendDesc _ASP_AUTO_GENERATED_FIELD_7;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_112 _renderTarget;

}

/// <summary>
/// STRUCTURE <b>D3D11_RASTERIZER_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RasterizerDesc {

	/// <summary>
	/// <b>D3D11_FILL_MODE FillMode</b>
	/// </summary>
	public readonly FillMode FillMode {
		get => _fillMode;
		init => _fillMode = value;
	}
	readonly FillMode _fillMode;

	/// <summary>
	/// <b>D3D11_CULL_MODE CullMode</b>
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
	/// <b>BOOL ScissorEnable</b>
	/// </summary>
	public readonly bool ScissorEnable {
		get => _scissorEnable != 0;
		init => _scissorEnable = value ? 1U : 0U;
	}
	readonly uint _scissorEnable;

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

}

/// <summary>
/// STRUCTURE <b>D3D11_SUBRESOURCE_DATA</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SubresourceData {

	/// <summary>
	/// <b>void* pSysMem</b>
	/// </summary>
	public readonly void* PSysMem {
		get => _pSysMem;
		init => _pSysMem = value;
	}
	readonly void* _pSysMem;

	/// <summary>
	/// <b>UINT SysMemPitch</b>
	/// </summary>
	public readonly uint SysMemPitch {
		get => _sysMemPitch;
		init => _sysMemPitch = value;
	}
	readonly uint _sysMemPitch;

	/// <summary>
	/// <b>UINT SysMemSlicePitch</b>
	/// </summary>
	public readonly uint SysMemSlicePitch {
		get => _sysMemSlicePitch;
		init => _sysMemSlicePitch = value;
	}
	readonly uint _sysMemSlicePitch;

}

/// <summary>
/// STRUCTURE <b>D3D11_MAPPED_SUBRESOURCE</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MappedSubresource {

	/// <summary>
	/// <b>void* pData</b>
	/// </summary>
	public readonly void* PData {
		get => _pData;
		init => _pData = value;
	}
	readonly void* _pData;

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
/// STRUCTURE <b>D3D11_BUFFER_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferDesc {

	/// <summary>
	/// <b>UINT ByteWidth</b>
	/// </summary>
	public readonly uint ByteWidth {
		get => _byteWidth;
		init => _byteWidth = value;
	}
	readonly uint _byteWidth;

	/// <summary>
	/// <b>D3D11_USAGE Usage</b>
	/// </summary>
	public readonly Usage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly Usage _usage;

	/// <summary>
	/// <b>UINT BindFlags</b>
	/// </summary>
	public readonly uint BindFlags {
		get => _bindFlags;
		init => _bindFlags = value;
	}
	readonly uint _bindFlags;

	/// <summary>
	/// <b>UINT CPUAccessFlags</b>
	/// </summary>
	public readonly uint CPUAccessFlags {
		get => _cPUAccessFlags;
		init => _cPUAccessFlags = value;
	}
	readonly uint _cPUAccessFlags;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

	/// <summary>
	/// <b>UINT StructureByteStride</b>
	/// </summary>
	public readonly uint StructureByteStride {
		get => _structureByteStride;
		init => _structureByteStride = value;
	}
	readonly uint _structureByteStride;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEXTURE1D_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Texture1dDesc {

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D11_USAGE Usage</b>
	/// </summary>
	public readonly Usage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly Usage _usage;

	/// <summary>
	/// <b>UINT BindFlags</b>
	/// </summary>
	public readonly uint BindFlags {
		get => _bindFlags;
		init => _bindFlags = value;
	}
	readonly uint _bindFlags;

	/// <summary>
	/// <b>UINT CPUAccessFlags</b>
	/// </summary>
	public readonly uint CPUAccessFlags {
		get => _cPUAccessFlags;
		init => _cPUAccessFlags = value;
	}
	readonly uint _cPUAccessFlags;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEXTURE2D_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Texture2dDesc {

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
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

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
	/// <b>D3D11_USAGE Usage</b>
	/// </summary>
	public readonly Usage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly Usage _usage;

	/// <summary>
	/// <b>UINT BindFlags</b>
	/// </summary>
	public readonly uint BindFlags {
		get => _bindFlags;
		init => _bindFlags = value;
	}
	readonly uint _bindFlags;

	/// <summary>
	/// <b>UINT CPUAccessFlags</b>
	/// </summary>
	public readonly uint CPUAccessFlags {
		get => _cPUAccessFlags;
		init => _cPUAccessFlags = value;
	}
	readonly uint _cPUAccessFlags;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEXTURE3D_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Texture3dDesc {

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
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D11_USAGE Usage</b>
	/// </summary>
	public readonly Usage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly Usage _usage;

	/// <summary>
	/// <b>UINT BindFlags</b>
	/// </summary>
	public readonly uint BindFlags {
		get => _bindFlags;
		init => _bindFlags = value;
	}
	readonly uint _bindFlags;

	/// <summary>
	/// <b>UINT CPUAccessFlags</b>
	/// </summary>
	public readonly uint CPUAccessFlags {
		get => _cPUAccessFlags;
		init => _cPUAccessFlags = value;
	}
	readonly uint _cPUAccessFlags;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

}

/// <summary>
/// STRUCTURE <b>D3D11_BUFFER_SRV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferSrv {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_0 {

		[FieldOffset (0)] public uint FirstElement;
		[FieldOffset (0)] public uint ElementOffset;
	}

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_2 {

		[FieldOffset (0)] public uint NumElements;
		[FieldOffset (0)] public uint ElementWidth;
	}

	/// <summary>
	/// <b>UINT FirstElement</b>
	/// </summary>
	public readonly uint FirstElement {
		get => __aSP_AUTO_GENERATED_FIELD_0.FirstElement;
		init => __aSP_AUTO_GENERATED_FIELD_0.FirstElement = value;
	}

	/// <summary>
	/// <b>UINT ElementOffset</b>
	/// </summary>
	public readonly uint ElementOffset {
		get => __aSP_AUTO_GENERATED_FIELD_0.ElementOffset;
		init => __aSP_AUTO_GENERATED_FIELD_0.ElementOffset = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_0 __aSP_AUTO_GENERATED_FIELD_0;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => __aSP_AUTO_GENERATED_FIELD_2.NumElements;
		init => __aSP_AUTO_GENERATED_FIELD_2.NumElements = value;
	}

	/// <summary>
	/// <b>UINT ElementWidth</b>
	/// </summary>
	public readonly uint ElementWidth {
		get => __aSP_AUTO_GENERATED_FIELD_2.ElementWidth;
		init => __aSP_AUTO_GENERATED_FIELD_2.ElementWidth = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_2 __aSP_AUTO_GENERATED_FIELD_2;

}

/// <summary>
/// STRUCTURE <b>D3D11_BUFFEREX_SRV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferexSrv {

	/// <summary>
	/// <b>UINT FirstElement</b>
	/// </summary>
	public readonly uint FirstElement {
		get => _firstElement;
		init => _firstElement = value;
	}
	readonly uint _firstElement;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => _numElements;
		init => _numElements = value;
	}
	readonly uint _numElements;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX1D_SRV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX1D_ARRAY_SRV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_SRV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_SRV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX3D_SRV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEXCUBE_SRV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEXCUBE_ARRAY_SRV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2DMS_SRV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2DMS_ARRAY_SRV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_SHADER_RESOURCE_VIEW_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderResourceViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_4 {

		[FieldOffset (0)] public BufferSrv buffer;
		[FieldOffset (0)] public Tex1dSrv texture1D;
		[FieldOffset (0)] public Tex1dArraySrv texture1DArray;
		[FieldOffset (0)] public Tex2dSrv texture2D;
		[FieldOffset (0)] public Tex2dArraySrv texture2DArray;
		[FieldOffset (0)] public Tex2dmsSrv texture2DMS;
		[FieldOffset (0)] public Tex2dmsArraySrv texture2DMSArray;
		[FieldOffset (0)] public Tex3dSrv texture3D;
		[FieldOffset (0)] public TexcubeSrv textureCube;
		[FieldOffset (0)] public TexcubeArraySrv textureCubeArray;
		[FieldOffset (0)] public BufferexSrv bufferEx;
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
	/// <b>D3D11_SRV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly Direct3D.SrvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly Direct3D.SrvDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_BUFFER_SRV Buffer</b>
	/// </summary>
	public readonly BufferSrv Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_4.buffer;
		init => __aSP_AUTO_GENERATED_FIELD_4.buffer = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_SRV Texture1D</b>
	/// </summary>
	public readonly Tex1dSrv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_4.texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_4.texture1D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_ARRAY_SRV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArraySrv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_4.texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_4.texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_SRV Texture2D</b>
	/// </summary>
	public readonly Tex2dSrv Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_4.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_4.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_SRV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArraySrv Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_4.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_4.texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_SRV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsSrv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_4.texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_4.texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArraySrv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_4.texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_4.texture2DMSArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX3D_SRV Texture3D</b>
	/// </summary>
	public readonly Tex3dSrv Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_4.texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_4.texture3D = value;
	}

	/// <summary>
	/// <b>D3D11_TEXCUBE_SRV TextureCube</b>
	/// </summary>
	public readonly TexcubeSrv TextureCube {
		get => __aSP_AUTO_GENERATED_FIELD_4.textureCube;
		init => __aSP_AUTO_GENERATED_FIELD_4.textureCube = value;
	}

	/// <summary>
	/// <b>D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray</b>
	/// </summary>
	public readonly TexcubeArraySrv TextureCubeArray {
		get => __aSP_AUTO_GENERATED_FIELD_4.textureCubeArray;
		init => __aSP_AUTO_GENERATED_FIELD_4.textureCubeArray = value;
	}

	/// <summary>
	/// <b>D3D11_BUFFEREX_SRV BufferEx</b>
	/// </summary>
	public readonly BufferexSrv BufferEx {
		get => __aSP_AUTO_GENERATED_FIELD_4.bufferEx;
		init => __aSP_AUTO_GENERATED_FIELD_4.bufferEx = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_4 __aSP_AUTO_GENERATED_FIELD_4;

}

/// <summary>
/// STRUCTURE <b>D3D11_BUFFER_RTV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferRtv {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_6 {

		[FieldOffset (0)] public uint firstElement;
		[FieldOffset (0)] public uint elementOffset;
	}

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_8 {

		[FieldOffset (0)] public uint numElements;
		[FieldOffset (0)] public uint elementWidth;
	}

	/// <summary>
	/// <b>UINT FirstElement</b>
	/// </summary>
	public readonly uint FirstElement {
		get => __aSP_AUTO_GENERATED_FIELD_6.firstElement;
		init => __aSP_AUTO_GENERATED_FIELD_6.firstElement = value;
	}

	/// <summary>
	/// <b>UINT ElementOffset</b>
	/// </summary>
	public readonly uint ElementOffset {
		get => __aSP_AUTO_GENERATED_FIELD_6.elementOffset;
		init => __aSP_AUTO_GENERATED_FIELD_6.elementOffset = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_6 __aSP_AUTO_GENERATED_FIELD_6;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => __aSP_AUTO_GENERATED_FIELD_8.numElements;
		init => __aSP_AUTO_GENERATED_FIELD_8.numElements = value;
	}

	/// <summary>
	/// <b>UINT ElementWidth</b>
	/// </summary>
	public readonly uint ElementWidth {
		get => __aSP_AUTO_GENERATED_FIELD_8.elementWidth;
		init => __aSP_AUTO_GENERATED_FIELD_8.elementWidth = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_8 __aSP_AUTO_GENERATED_FIELD_8;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX1D_RTV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX1D_ARRAY_RTV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2D_RTV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2DMS_RTV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_RTV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2DMS_ARRAY_RTV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX3D_RTV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_RENDER_TARGET_VIEW_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderTargetViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_10 {

		[FieldOffset (0)] public BufferRtv buffer;
		[FieldOffset (0)] public Tex1dRtv texture1D;
		[FieldOffset (0)] public Tex1dArrayRtv texture1DArray;
		[FieldOffset (0)] public Tex2dRtv texture2D;
		[FieldOffset (0)] public Tex2dArrayRtv texture2DArray;
		[FieldOffset (0)] public Tex2dmsRtv texture2DMS;
		[FieldOffset (0)] public Tex2dmsArrayRtv texture2DMSArray;
		[FieldOffset (0)] public Tex3dRtv texture3D;
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
	/// <b>D3D11_RTV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly RtvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly RtvDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_BUFFER_RTV Buffer</b>
	/// </summary>
	public readonly BufferRtv Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_10.buffer;
		init => __aSP_AUTO_GENERATED_FIELD_10.buffer = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_RTV Texture1D</b>
	/// </summary>
	public readonly Tex1dRtv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_10.texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_10.texture1D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_ARRAY_RTV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayRtv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_10.texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_10.texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_RTV Texture2D</b>
	/// </summary>
	public readonly Tex2dRtv Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_10.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_10.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_RTV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayRtv Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_10.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_10.texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_RTV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsRtv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_10.texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_10.texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArrayRtv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_10.texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_10.texture2DMSArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX3D_RTV Texture3D</b>
	/// </summary>
	public readonly Tex3dRtv Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_10.texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_10.texture3D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_10 __aSP_AUTO_GENERATED_FIELD_10;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX1D_DSV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX1D_ARRAY_DSV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2D_DSV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_DSV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2DMS_DSV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2DMS_ARRAY_DSV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_DEPTH_STENCIL_VIEW_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DepthStencilViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_12 {

		[FieldOffset (0)] public Tex1dDsv texture1D;
		[FieldOffset (0)] public Tex1dArrayDsv texture1DArray;
		[FieldOffset (0)] public Tex2dDsv texture2D;
		[FieldOffset (0)] public Tex2dArrayDsv texture2DArray;
		[FieldOffset (0)] public Tex2dmsDsv texture2DMS;
		[FieldOffset (0)] public Tex2dmsArrayDsv texture2DMSArray;
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
	/// <b>D3D11_DSV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly DsvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly DsvDimension _viewDimension;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

	/// <summary>
	/// <b>D3D11_TEX1D_DSV Texture1D</b>
	/// </summary>
	public readonly Tex1dDsv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_12.texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_12.texture1D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_ARRAY_DSV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayDsv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_12.texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_12.texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_DSV Texture2D</b>
	/// </summary>
	public readonly Tex2dDsv Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_12.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_12.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_DSV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayDsv Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_12.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_12.texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_DSV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsDsv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_12.texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_12.texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArrayDsv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_12.texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_12.texture2DMSArray = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_12 __aSP_AUTO_GENERATED_FIELD_12;

}

/// <summary>
/// STRUCTURE <b>D3D11_BUFFER_UAV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BufferUav {

	/// <summary>
	/// <b>UINT FirstElement</b>
	/// </summary>
	public readonly uint FirstElement {
		get => _firstElement;
		init => _firstElement = value;
	}
	readonly uint _firstElement;

	/// <summary>
	/// <b>UINT NumElements</b>
	/// </summary>
	public readonly uint NumElements {
		get => _numElements;
		init => _numElements = value;
	}
	readonly uint _numElements;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX1D_UAV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX1D_ARRAY_UAV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_TEX2D_UAV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_UAV</b><br/>
/// D3D11.h
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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX3D_UAV</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_UNORDERED_ACCESS_VIEW_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct UnorderedAccessViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_14 {

		[FieldOffset (0)] public BufferUav buffer;
		[FieldOffset (0)] public Tex1dUav texture1D;
		[FieldOffset (0)] public Tex1dArrayUav texture1DArray;
		[FieldOffset (0)] public Tex2dUav texture2D;
		[FieldOffset (0)] public Tex2dArrayUav texture2DArray;
		[FieldOffset (0)] public Tex3dUav texture3D;
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
	/// <b>D3D11_UAV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly UavDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly UavDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_BUFFER_UAV Buffer</b>
	/// </summary>
	public readonly BufferUav Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_14.buffer;
		init => __aSP_AUTO_GENERATED_FIELD_14.buffer = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_UAV Texture1D</b>
	/// </summary>
	public readonly Tex1dUav Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_14.texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_14.texture1D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_ARRAY_UAV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayUav Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_14.texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_14.texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_UAV Texture2D</b>
	/// </summary>
	public readonly Tex2dUav Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_14.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_14.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_UAV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayUav Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_14.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_14.texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX3D_UAV Texture3D</b>
	/// </summary>
	public readonly Tex3dUav Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_14.texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_14.texture3D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_14 __aSP_AUTO_GENERATED_FIELD_14;

}

/// <summary>
/// STRUCTURE <b>D3D11_SAMPLER_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SamplerDesc {

	/// <summary>
	/// <b>D3D11_FILTER Filter</b>
	/// </summary>
	public readonly Filter Filter {
		get => _filter;
		init => _filter = value;
	}
	readonly Filter _filter;

	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_MODE AddressU</b>
	/// </summary>
	public readonly TextureAddressMode AddressU {
		get => _addressU;
		init => _addressU = value;
	}
	readonly TextureAddressMode _addressU;

	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_MODE AddressV</b>
	/// </summary>
	public readonly TextureAddressMode AddressV {
		get => _addressV;
		init => _addressV = value;
	}
	readonly TextureAddressMode _addressV;

	/// <summary>
	/// <b>D3D11_TEXTURE_ADDRESS_MODE AddressW</b>
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
	/// <b>D3D11_COMPARISON_FUNC ComparisonFunc</b>
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

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_113 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [4];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_113 _borderColor;

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
/// STRUCTURE <b>D3D11_QUERY_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryDesc {

	/// <summary>
	/// <b>D3D11_QUERY Query</b>
	/// </summary>
	public readonly QueryEnum Query {
		get => _query;
		init => _query = value;
	}
	readonly QueryEnum _query;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

}

/// <summary>
/// STRUCTURE <b>D3D11_QUERY_DATA_TIMESTAMP_DISJOINT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryDataTimestampDisjoint {

	/// <summary>
	/// <b>UINT64 Frequency</b>
	/// </summary>
	public readonly ulong Frequency {
		get => _frequency;
		init => _frequency = value;
	}
	readonly ulong _frequency;

	/// <summary>
	/// <b>BOOL Disjoint</b>
	/// </summary>
	public readonly bool Disjoint {
		get => _disjoint != 0;
		init => _disjoint = value ? 1U : 0U;
	}
	readonly uint _disjoint;

}

/// <summary>
/// STRUCTURE <b>D3D11_QUERY_DATA_PIPELINE_STATISTICS</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_QUERY_DATA_SO_STATISTICS</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_COUNTER_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CounterDesc {

	/// <summary>
	/// <b>D3D11_COUNTER Counter</b>
	/// </summary>
	public readonly CounterEnum Counter {
		get => _counter;
		init => _counter = value;
	}
	readonly CounterEnum _counter;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

}

/// <summary>
/// STRUCTURE <b>D3D11_COUNTER_INFO</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CounterInfo {

	/// <summary>
	/// <b>D3D11_COUNTER LastDeviceDependentCounter</b>
	/// </summary>
	public readonly CounterEnum LastDeviceDependentCounter {
		get => _lastDeviceDependentCounter;
		init => _lastDeviceDependentCounter = value;
	}
	readonly CounterEnum _lastDeviceDependentCounter;

	/// <summary>
	/// <b>UINT NumSimultaneousCounters</b>
	/// </summary>
	public readonly uint NumSimultaneousCounters {
		get => _numSimultaneousCounters;
		init => _numSimultaneousCounters = value;
	}
	readonly uint _numSimultaneousCounters;

	/// <summary>
	/// <b>UINT8 NumDetectableParallelUnits</b>
	/// </summary>
	public readonly byte NumDetectableParallelUnits {
		get => _numDetectableParallelUnits;
		init => _numDetectableParallelUnits = value;
	}
	readonly byte _numDetectableParallelUnits;

}

/// <summary>
/// STRUCTURE <b>D3D11_CLASS_INSTANCE_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ClassInstanceDesc {

	/// <summary>
	/// <b>UINT InstanceId</b>
	/// </summary>
	public readonly uint InstanceId {
		get => _instanceId;
		init => _instanceId = value;
	}
	readonly uint _instanceId;

	/// <summary>
	/// <b>UINT InstanceIndex</b>
	/// </summary>
	public readonly uint InstanceIndex {
		get => _instanceIndex;
		init => _instanceIndex = value;
	}
	readonly uint _instanceIndex;

	/// <summary>
	/// <b>UINT TypeId</b>
	/// </summary>
	public readonly uint TypeId {
		get => _typeId;
		init => _typeId = value;
	}
	readonly uint _typeId;

	/// <summary>
	/// <b>UINT ConstantBuffer</b>
	/// </summary>
	public readonly uint ConstantBuffer {
		get => _constantBuffer;
		init => _constantBuffer = value;
	}
	readonly uint _constantBuffer;

	/// <summary>
	/// <b>UINT BaseConstantBufferOffset</b>
	/// </summary>
	public readonly uint BaseConstantBufferOffset {
		get => _baseConstantBufferOffset;
		init => _baseConstantBufferOffset = value;
	}
	readonly uint _baseConstantBufferOffset;

	/// <summary>
	/// <b>UINT BaseTexture</b>
	/// </summary>
	public readonly uint BaseTexture {
		get => _baseTexture;
		init => _baseTexture = value;
	}
	readonly uint _baseTexture;

	/// <summary>
	/// <b>UINT BaseSampler</b>
	/// </summary>
	public readonly uint BaseSampler {
		get => _baseSampler;
		init => _baseSampler = value;
	}
	readonly uint _baseSampler;

	/// <summary>
	/// <b>BOOL Created</b>
	/// </summary>
	public readonly bool Created {
		get => _created != 0;
		init => _created = value ? 1U : 0U;
	}
	readonly uint _created;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_THREADING</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataThreading {

	/// <summary>
	/// <b>BOOL DriverConcurrentCreates</b>
	/// </summary>
	public readonly bool DriverConcurrentCreates {
		get => _driverConcurrentCreates != 0;
		init => _driverConcurrentCreates = value ? 1U : 0U;
	}
	readonly uint _driverConcurrentCreates;

	/// <summary>
	/// <b>BOOL DriverCommandLists</b>
	/// </summary>
	public readonly bool DriverCommandLists {
		get => _driverCommandLists != 0;
		init => _driverCommandLists = value ? 1U : 0U;
	}
	readonly uint _driverCommandLists;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_DOUBLES</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataDoubles {

	/// <summary>
	/// <b>BOOL DoublePrecisionFloatShaderOps</b>
	/// </summary>
	public readonly bool DoublePrecisionFloatShaderOps {
		get => _doublePrecisionFloatShaderOps != 0;
		init => _doublePrecisionFloatShaderOps = value ? 1U : 0U;
	}
	readonly uint _doublePrecisionFloatShaderOps;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_FORMAT_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataFormatSupport {

	/// <summary>
	/// <b>DXGI_FORMAT InFormat</b>
	/// </summary>
	public readonly DXGI.Format InFormat {
		get => _inFormat;
		init => _inFormat = value;
	}
	readonly DXGI.Format _inFormat;

	/// <summary>
	/// <b>UINT OutFormatSupport</b>
	/// </summary>
	public readonly uint OutFormatSupport {
		get => _outFormatSupport;
		init => _outFormatSupport = value;
	}
	readonly uint _outFormatSupport;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_FORMAT_SUPPORT2</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataFormatSupport2 {

	/// <summary>
	/// <b>DXGI_FORMAT InFormat</b>
	/// </summary>
	public readonly DXGI.Format InFormat {
		get => _inFormat;
		init => _inFormat = value;
	}
	readonly DXGI.Format _inFormat;

	/// <summary>
	/// <b>UINT OutFormatSupport2</b>
	/// </summary>
	public readonly uint OutFormatSupport2 {
		get => _outFormatSupport2;
		init => _outFormatSupport2 = value;
	}
	readonly uint _outFormatSupport2;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d10XHardwareOptions {

	/// <summary>
	/// <b>BOOL ComputeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x</b>
	/// </summary>
	public readonly bool ComputeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x {
		get => _computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x != 0;
		init => _computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x = value ? 1U : 0U;
	}
	readonly uint _computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D11_OPTIONS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d11Options {

	/// <summary>
	/// <b>BOOL OutputMergerLogicOp</b>
	/// </summary>
	public readonly bool OutputMergerLogicOp {
		get => _outputMergerLogicOp != 0;
		init => _outputMergerLogicOp = value ? 1U : 0U;
	}
	readonly uint _outputMergerLogicOp;

	/// <summary>
	/// <b>BOOL UAVOnlyRenderingForcedSampleCount</b>
	/// </summary>
	public readonly bool UAVOnlyRenderingForcedSampleCount {
		get => _uAVOnlyRenderingForcedSampleCount != 0;
		init => _uAVOnlyRenderingForcedSampleCount = value ? 1U : 0U;
	}
	readonly uint _uAVOnlyRenderingForcedSampleCount;

	/// <summary>
	/// <b>BOOL DiscardAPIsSeenByDriver</b>
	/// </summary>
	public readonly bool DiscardAPIsSeenByDriver {
		get => _discardAPIsSeenByDriver != 0;
		init => _discardAPIsSeenByDriver = value ? 1U : 0U;
	}
	readonly uint _discardAPIsSeenByDriver;

	/// <summary>
	/// <b>BOOL FlagsForUpdateAndCopySeenByDriver</b>
	/// </summary>
	public readonly bool FlagsForUpdateAndCopySeenByDriver {
		get => _flagsForUpdateAndCopySeenByDriver != 0;
		init => _flagsForUpdateAndCopySeenByDriver = value ? 1U : 0U;
	}
	readonly uint _flagsForUpdateAndCopySeenByDriver;

	/// <summary>
	/// <b>BOOL ClearView</b>
	/// </summary>
	public readonly bool ClearView {
		get => _clearView != 0;
		init => _clearView = value ? 1U : 0U;
	}
	readonly uint _clearView;

	/// <summary>
	/// <b>BOOL CopyWithOverlap</b>
	/// </summary>
	public readonly bool CopyWithOverlap {
		get => _copyWithOverlap != 0;
		init => _copyWithOverlap = value ? 1U : 0U;
	}
	readonly uint _copyWithOverlap;

	/// <summary>
	/// <b>BOOL ConstantBufferPartialUpdate</b>
	/// </summary>
	public readonly bool ConstantBufferPartialUpdate {
		get => _constantBufferPartialUpdate != 0;
		init => _constantBufferPartialUpdate = value ? 1U : 0U;
	}
	readonly uint _constantBufferPartialUpdate;

	/// <summary>
	/// <b>BOOL ConstantBufferOffsetting</b>
	/// </summary>
	public readonly bool ConstantBufferOffsetting {
		get => _constantBufferOffsetting != 0;
		init => _constantBufferOffsetting = value ? 1U : 0U;
	}
	readonly uint _constantBufferOffsetting;

	/// <summary>
	/// <b>BOOL MapNoOverwriteOnDynamicConstantBuffer</b>
	/// </summary>
	public readonly bool MapNoOverwriteOnDynamicConstantBuffer {
		get => _mapNoOverwriteOnDynamicConstantBuffer != 0;
		init => _mapNoOverwriteOnDynamicConstantBuffer = value ? 1U : 0U;
	}
	readonly uint _mapNoOverwriteOnDynamicConstantBuffer;

	/// <summary>
	/// <b>BOOL MapNoOverwriteOnDynamicBufferSRV</b>
	/// </summary>
	public readonly bool MapNoOverwriteOnDynamicBufferSRV {
		get => _mapNoOverwriteOnDynamicBufferSRV != 0;
		init => _mapNoOverwriteOnDynamicBufferSRV = value ? 1U : 0U;
	}
	readonly uint _mapNoOverwriteOnDynamicBufferSRV;

	/// <summary>
	/// <b>BOOL MultisampleRTVWithForcedSampleCountOne</b>
	/// </summary>
	public readonly bool MultisampleRTVWithForcedSampleCountOne {
		get => _multisampleRTVWithForcedSampleCountOne != 0;
		init => _multisampleRTVWithForcedSampleCountOne = value ? 1U : 0U;
	}
	readonly uint _multisampleRTVWithForcedSampleCountOne;

	/// <summary>
	/// <b>BOOL SAD4ShaderInstructions</b>
	/// </summary>
	public readonly bool SAD4ShaderInstructions {
		get => _sAD4ShaderInstructions != 0;
		init => _sAD4ShaderInstructions = value ? 1U : 0U;
	}
	readonly uint _sAD4ShaderInstructions;

	/// <summary>
	/// <b>BOOL ExtendedDoublesShaderInstructions</b>
	/// </summary>
	public readonly bool ExtendedDoublesShaderInstructions {
		get => _extendedDoublesShaderInstructions != 0;
		init => _extendedDoublesShaderInstructions = value ? 1U : 0U;
	}
	readonly uint _extendedDoublesShaderInstructions;

	/// <summary>
	/// <b>BOOL ExtendedResourceSharing</b>
	/// </summary>
	public readonly bool ExtendedResourceSharing {
		get => _extendedResourceSharing != 0;
		init => _extendedResourceSharing = value ? 1U : 0U;
	}
	readonly uint _extendedResourceSharing;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_ARCHITECTURE_INFO</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataArchitectureInfo {

	/// <summary>
	/// <b>BOOL TileBasedDeferredRenderer</b>
	/// </summary>
	public readonly bool TileBasedDeferredRenderer {
		get => _tileBasedDeferredRenderer != 0;
		init => _tileBasedDeferredRenderer = value ? 1U : 0U;
	}
	readonly uint _tileBasedDeferredRenderer;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D9_OPTIONS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d9Options {

	/// <summary>
	/// <b>BOOL FullNonPow2TextureSupport</b>
	/// </summary>
	public readonly bool FullNonPow2TextureSupport {
		get => _fullNonPow2TextureSupport != 0;
		init => _fullNonPow2TextureSupport = value ? 1U : 0U;
	}
	readonly uint _fullNonPow2TextureSupport;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D9_SHADOW_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d9ShadowSupport {

	/// <summary>
	/// <b>BOOL SupportsDepthAsTextureWithLessEqualComparisonFilter</b>
	/// </summary>
	public readonly bool SupportsDepthAsTextureWithLessEqualComparisonFilter {
		get => _supportsDepthAsTextureWithLessEqualComparisonFilter != 0;
		init => _supportsDepthAsTextureWithLessEqualComparisonFilter = value ? 1U : 0U;
	}
	readonly uint _supportsDepthAsTextureWithLessEqualComparisonFilter;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataShaderMinPrecisionSupport {

	/// <summary>
	/// <b>UINT PixelShaderMinPrecision</b>
	/// </summary>
	public readonly uint PixelShaderMinPrecision {
		get => _pixelShaderMinPrecision;
		init => _pixelShaderMinPrecision = value;
	}
	readonly uint _pixelShaderMinPrecision;

	/// <summary>
	/// <b>UINT AllOtherShaderStagesMinPrecision</b>
	/// </summary>
	public readonly uint AllOtherShaderStagesMinPrecision {
		get => _allOtherShaderStagesMinPrecision;
		init => _allOtherShaderStagesMinPrecision = value;
	}
	readonly uint _allOtherShaderStagesMinPrecision;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D11_OPTIONS1</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d11Options1 {

	/// <summary>
	/// <b>D3D11_TILED_RESOURCES_TIER TiledResourcesTier</b>
	/// </summary>
	public readonly TiledResourcesTier TiledResourcesTier {
		get => _tiledResourcesTier;
		init => _tiledResourcesTier = value;
	}
	readonly TiledResourcesTier _tiledResourcesTier;

	/// <summary>
	/// <b>BOOL MinMaxFiltering</b>
	/// </summary>
	public readonly bool MinMaxFiltering {
		get => _minMaxFiltering != 0;
		init => _minMaxFiltering = value ? 1U : 0U;
	}
	readonly uint _minMaxFiltering;

	/// <summary>
	/// <b>BOOL ClearViewAlsoSupportsDepthOnlyFormats</b>
	/// </summary>
	public readonly bool ClearViewAlsoSupportsDepthOnlyFormats {
		get => _clearViewAlsoSupportsDepthOnlyFormats != 0;
		init => _clearViewAlsoSupportsDepthOnlyFormats = value ? 1U : 0U;
	}
	readonly uint _clearViewAlsoSupportsDepthOnlyFormats;

	/// <summary>
	/// <b>BOOL MapOnDefaultBuffers</b>
	/// </summary>
	public readonly bool MapOnDefaultBuffers {
		get => _mapOnDefaultBuffers != 0;
		init => _mapOnDefaultBuffers = value ? 1U : 0U;
	}
	readonly uint _mapOnDefaultBuffers;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D9_SIMPLE_INSTANCING_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d9SimpleInstancingSupport {

	/// <summary>
	/// <b>BOOL SimpleInstancingSupported</b>
	/// </summary>
	public readonly bool SimpleInstancingSupported {
		get => _simpleInstancingSupported != 0;
		init => _simpleInstancingSupported = value ? 1U : 0U;
	}
	readonly uint _simpleInstancingSupported;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_MARKER_SUPPORT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataMarkerSupport {

	/// <summary>
	/// <b>BOOL Profile</b>
	/// </summary>
	public readonly bool Profile {
		get => _profile != 0;
		init => _profile = value ? 1U : 0U;
	}
	readonly uint _profile;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D9_OPTIONS1</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d9Options1 {

	/// <summary>
	/// <b>BOOL FullNonPow2TextureSupported</b>
	/// </summary>
	public readonly bool FullNonPow2TextureSupported {
		get => _fullNonPow2TextureSupported != 0;
		init => _fullNonPow2TextureSupported = value ? 1U : 0U;
	}
	readonly uint _fullNonPow2TextureSupported;

	/// <summary>
	/// <b>BOOL DepthAsTextureWithLessEqualComparisonFilterSupported</b>
	/// </summary>
	public readonly bool DepthAsTextureWithLessEqualComparisonFilterSupported {
		get => _depthAsTextureWithLessEqualComparisonFilterSupported != 0;
		init => _depthAsTextureWithLessEqualComparisonFilterSupported = value ? 1U : 0U;
	}
	readonly uint _depthAsTextureWithLessEqualComparisonFilterSupported;

	/// <summary>
	/// <b>BOOL SimpleInstancingSupported</b>
	/// </summary>
	public readonly bool SimpleInstancingSupported {
		get => _simpleInstancingSupported != 0;
		init => _simpleInstancingSupported = value ? 1U : 0U;
	}
	readonly uint _simpleInstancingSupported;

	/// <summary>
	/// <b>BOOL TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported</b>
	/// </summary>
	public readonly bool TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported {
		get => _textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported != 0;
		init => _textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported = value ? 1U : 0U;
	}
	readonly uint _textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D11_OPTIONS2</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d11Options2 {

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
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier</b>
	/// </summary>
	public readonly ConservativeRasterizationTier ConservativeRasterizationTier {
		get => _conservativeRasterizationTier;
		init => _conservativeRasterizationTier = value;
	}
	readonly ConservativeRasterizationTier _conservativeRasterizationTier;

	/// <summary>
	/// <b>D3D11_TILED_RESOURCES_TIER TiledResourcesTier</b>
	/// </summary>
	public readonly TiledResourcesTier TiledResourcesTier {
		get => _tiledResourcesTier;
		init => _tiledResourcesTier = value;
	}
	readonly TiledResourcesTier _tiledResourcesTier;

	/// <summary>
	/// <b>BOOL MapOnDefaultTextures</b>
	/// </summary>
	public readonly bool MapOnDefaultTextures {
		get => _mapOnDefaultTextures != 0;
		init => _mapOnDefaultTextures = value ? 1U : 0U;
	}
	readonly uint _mapOnDefaultTextures;

	/// <summary>
	/// <b>BOOL StandardSwizzle</b>
	/// </summary>
	public readonly bool StandardSwizzle {
		get => _standardSwizzle != 0;
		init => _standardSwizzle = value ? 1U : 0U;
	}
	readonly uint _standardSwizzle;

	/// <summary>
	/// <b>BOOL UnifiedMemoryArchitecture</b>
	/// </summary>
	public readonly bool UnifiedMemoryArchitecture {
		get => _unifiedMemoryArchitecture != 0;
		init => _unifiedMemoryArchitecture = value ? 1U : 0U;
	}
	readonly uint _unifiedMemoryArchitecture;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D11_OPTIONS3</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d11Options3 {

	/// <summary>
	/// <b>BOOL VPAndRTArrayIndexFromAnyShaderFeedingRasterizer</b>
	/// </summary>
	public readonly bool VPAndRTArrayIndexFromAnyShaderFeedingRasterizer {
		get => _vPAndRTArrayIndexFromAnyShaderFeedingRasterizer != 0;
		init => _vPAndRTArrayIndexFromAnyShaderFeedingRasterizer = value ? 1U : 0U;
	}
	readonly uint _vPAndRTArrayIndexFromAnyShaderFeedingRasterizer;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT</b><br/>
/// D3D11.h
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
/// STRUCTURE <b>D3D11_FEATURE_DATA_SHADER_CACHE</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataShaderCache {

	/// <summary>
	/// <b>UINT SupportFlags</b>
	/// </summary>
	public readonly uint SupportFlags {
		get => _supportFlags;
		init => _supportFlags = value;
	}
	readonly uint _supportFlags;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_DISPLAYABLE</b><br/>
/// D3D11.h
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
	/// <b>D3D11_SHARED_RESOURCE_TIER SharedResourceTier</b>
	/// </summary>
	public readonly SharedResourceTier SharedResourceTier {
		get => _sharedResourceTier;
		init => _sharedResourceTier = value;
	}
	readonly SharedResourceTier _sharedResourceTier;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D11_OPTIONS5</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d11Options5 {

	/// <summary>
	/// <b>D3D11_SHARED_RESOURCE_TIER SharedResourceTier</b>
	/// </summary>
	public readonly SharedResourceTier SharedResourceTier {
		get => _sharedResourceTier;
		init => _sharedResourceTier = value;
	}
	readonly SharedResourceTier _sharedResourceTier;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderDesc {

	/// <summary>
	/// <b>GUID Guid</b>
	/// </summary>
	public readonly Guid Guid {
		get => _guid;
		init => _guid = value;
	}
	readonly Guid _guid;

	/// <summary>
	/// <b>UINT SampleWidth</b>
	/// </summary>
	public readonly uint SampleWidth {
		get => _sampleWidth;
		init => _sampleWidth = value;
	}
	readonly uint _sampleWidth;

	/// <summary>
	/// <b>UINT SampleHeight</b>
	/// </summary>
	public readonly uint SampleHeight {
		get => _sampleHeight;
		init => _sampleHeight = value;
	}
	readonly uint _sampleHeight;

	/// <summary>
	/// <b>DXGI_FORMAT OutputFormat</b>
	/// </summary>
	public readonly DXGI.Format OutputFormat {
		get => _outputFormat;
		init => _outputFormat = value;
	}
	readonly DXGI.Format _outputFormat;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_CONFIG</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderConfig {

	/// <summary>
	/// <b>GUID guidConfigBitstreamEncryption</b>
	/// </summary>
	public readonly Guid GuidConfigBitstreamEncryption {
		get => _guidConfigBitstreamEncryption;
		init => _guidConfigBitstreamEncryption = value;
	}
	readonly Guid _guidConfigBitstreamEncryption;

	/// <summary>
	/// <b>GUID guidConfigMBcontrolEncryption</b>
	/// </summary>
	public readonly Guid GuidConfigMBcontrolEncryption {
		get => _guidConfigMBcontrolEncryption;
		init => _guidConfigMBcontrolEncryption = value;
	}
	readonly Guid _guidConfigMBcontrolEncryption;

	/// <summary>
	/// <b>GUID guidConfigResidDiffEncryption</b>
	/// </summary>
	public readonly Guid GuidConfigResidDiffEncryption {
		get => _guidConfigResidDiffEncryption;
		init => _guidConfigResidDiffEncryption = value;
	}
	readonly Guid _guidConfigResidDiffEncryption;

	/// <summary>
	/// <b>UINT ConfigBitstreamRaw</b>
	/// </summary>
	public readonly uint ConfigBitstreamRaw {
		get => _configBitstreamRaw;
		init => _configBitstreamRaw = value;
	}
	readonly uint _configBitstreamRaw;

	/// <summary>
	/// <b>UINT ConfigMBcontrolRasterOrder</b>
	/// </summary>
	public readonly uint ConfigMBcontrolRasterOrder {
		get => _configMBcontrolRasterOrder;
		init => _configMBcontrolRasterOrder = value;
	}
	readonly uint _configMBcontrolRasterOrder;

	/// <summary>
	/// <b>UINT ConfigResidDiffHost</b>
	/// </summary>
	public readonly uint ConfigResidDiffHost {
		get => _configResidDiffHost;
		init => _configResidDiffHost = value;
	}
	readonly uint _configResidDiffHost;

	/// <summary>
	/// <b>UINT ConfigSpatialResid8</b>
	/// </summary>
	public readonly uint ConfigSpatialResid8 {
		get => _configSpatialResid8;
		init => _configSpatialResid8 = value;
	}
	readonly uint _configSpatialResid8;

	/// <summary>
	/// <b>UINT ConfigResid8Subtraction</b>
	/// </summary>
	public readonly uint ConfigResid8Subtraction {
		get => _configResid8Subtraction;
		init => _configResid8Subtraction = value;
	}
	readonly uint _configResid8Subtraction;

	/// <summary>
	/// <b>UINT ConfigSpatialHost8or9Clipping</b>
	/// </summary>
	public readonly uint ConfigSpatialHost8or9Clipping {
		get => _configSpatialHost8or9Clipping;
		init => _configSpatialHost8or9Clipping = value;
	}
	readonly uint _configSpatialHost8or9Clipping;

	/// <summary>
	/// <b>UINT ConfigSpatialResidInterleaved</b>
	/// </summary>
	public readonly uint ConfigSpatialResidInterleaved {
		get => _configSpatialResidInterleaved;
		init => _configSpatialResidInterleaved = value;
	}
	readonly uint _configSpatialResidInterleaved;

	/// <summary>
	/// <b>UINT ConfigIntraResidUnsigned</b>
	/// </summary>
	public readonly uint ConfigIntraResidUnsigned {
		get => _configIntraResidUnsigned;
		init => _configIntraResidUnsigned = value;
	}
	readonly uint _configIntraResidUnsigned;

	/// <summary>
	/// <b>UINT ConfigResidDiffAccelerator</b>
	/// </summary>
	public readonly uint ConfigResidDiffAccelerator {
		get => _configResidDiffAccelerator;
		init => _configResidDiffAccelerator = value;
	}
	readonly uint _configResidDiffAccelerator;

	/// <summary>
	/// <b>UINT ConfigHostInverseScan</b>
	/// </summary>
	public readonly uint ConfigHostInverseScan {
		get => _configHostInverseScan;
		init => _configHostInverseScan = value;
	}
	readonly uint _configHostInverseScan;

	/// <summary>
	/// <b>UINT ConfigSpecificIDCT</b>
	/// </summary>
	public readonly uint ConfigSpecificIDCT {
		get => _configSpecificIDCT;
		init => _configSpecificIDCT = value;
	}
	readonly uint _configSpecificIDCT;

	/// <summary>
	/// <b>UINT Config4GroupedCoefs</b>
	/// </summary>
	public readonly uint Config4GroupedCoefs {
		get => _config4GroupedCoefs;
		init => _config4GroupedCoefs = value;
	}
	readonly uint _config4GroupedCoefs;

	/// <summary>
	/// <b>USHORT ConfigMinRenderTargetBuffCount</b>
	/// </summary>
	public readonly ushort ConfigMinRenderTargetBuffCount {
		get => _configMinRenderTargetBuffCount;
		init => _configMinRenderTargetBuffCount = value;
	}
	readonly ushort _configMinRenderTargetBuffCount;

	/// <summary>
	/// <b>USHORT ConfigDecoderSpecific</b>
	/// </summary>
	public readonly ushort ConfigDecoderSpecific {
		get => _configDecoderSpecific;
		init => _configDecoderSpecific = value;
	}
	readonly ushort _configDecoderSpecific;

}

/// <summary>
/// STRUCTURE <b>_D3D11_AES_CTR_IV</b> (D3D11_AES_CTR_IV)<br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AesCtrIv {

	/// <summary>
	/// <b>UINT64 IV</b>
	/// </summary>
	public readonly ulong Iv {
		get => _iV;
		init => _iV = value;
	}
	readonly ulong _iV;

	/// <summary>
	/// <b>UINT64 Count</b>
	/// </summary>
	public readonly ulong Count {
		get => _count;
		init => _count = value;
	}
	readonly ulong _count;

}

/// <summary>
/// STRUCTURE <b>D3D11_ENCRYPTED_BLOCK_INFO</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct EncryptedBlockInfo {

	/// <summary>
	/// <b>UINT NumEncryptedBytesAtBeginning</b>
	/// </summary>
	public readonly uint NumEncryptedBytesAtBeginning {
		get => _numEncryptedBytesAtBeginning;
		init => _numEncryptedBytesAtBeginning = value;
	}
	readonly uint _numEncryptedBytesAtBeginning;

	/// <summary>
	/// <b>UINT NumBytesInSkipPattern</b>
	/// </summary>
	public readonly uint NumBytesInSkipPattern {
		get => _numBytesInSkipPattern;
		init => _numBytesInSkipPattern = value;
	}
	readonly uint _numBytesInSkipPattern;

	/// <summary>
	/// <b>UINT NumBytesInEncryptPattern</b>
	/// </summary>
	public readonly uint NumBytesInEncryptPattern {
		get => _numBytesInEncryptPattern;
		init => _numBytesInEncryptPattern = value;
	}
	readonly uint _numBytesInEncryptPattern;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_BUFFER_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderBufferDesc {

	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType</b>
	/// </summary>
	public readonly VideoDecoderBufferType BufferType {
		get => _bufferType;
		init => _bufferType = value;
	}
	readonly VideoDecoderBufferType _bufferType;

	/// <summary>
	/// <b>UINT BufferIndex</b>
	/// </summary>
	public readonly uint BufferIndex {
		get => _bufferIndex;
		init => _bufferIndex = value;
	}
	readonly uint _bufferIndex;

	/// <summary>
	/// <b>UINT DataOffset</b>
	/// </summary>
	public readonly uint DataOffset {
		get => _dataOffset;
		init => _dataOffset = value;
	}
	readonly uint _dataOffset;

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>UINT FirstMBaddress</b>
	/// </summary>
	public readonly uint FirstMBaddress {
		get => _firstMBaddress;
		init => _firstMBaddress = value;
	}
	readonly uint _firstMBaddress;

	/// <summary>
	/// <b>UINT NumMBsInBuffer</b>
	/// </summary>
	public readonly uint NumMBsInBuffer {
		get => _numMBsInBuffer;
		init => _numMBsInBuffer = value;
	}
	readonly uint _numMBsInBuffer;

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
	/// <b>UINT Stride</b>
	/// </summary>
	public readonly uint Stride {
		get => _stride;
		init => _stride = value;
	}
	readonly uint _stride;

	/// <summary>
	/// <b>UINT ReservedBits</b>
	/// </summary>
	public readonly uint ReservedBits {
		get => _reservedBits;
		init => _reservedBits = value;
	}
	readonly uint _reservedBits;

	/// <summary>
	/// <b>void* pIV</b>
	/// </summary>
	public readonly void* PIV {
		get => _pIV;
		init => _pIV = value;
	}
	readonly void* _pIV;

	/// <summary>
	/// <b>UINT IVSize</b>
	/// </summary>
	public readonly uint IVSize {
		get => _iVSize;
		init => _iVSize = value;
	}
	readonly uint _iVSize;

	/// <summary>
	/// <b>BOOL PartialEncryption</b>
	/// </summary>
	public readonly bool PartialEncryption {
		get => _partialEncryption != 0;
		init => _partialEncryption = value ? 1U : 0U;
	}
	readonly uint _partialEncryption;

	/// <summary>
	/// <b>D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo</b>
	/// </summary>
	public readonly EncryptedBlockInfo EncryptedBlockInfo {
		get => _encryptedBlockInfo;
		init => _encryptedBlockInfo = value;
	}
	readonly EncryptedBlockInfo _encryptedBlockInfo;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_EXTENSION</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderExtension {

	/// <summary>
	/// <b>UINT Function</b>
	/// </summary>
	public readonly uint Function {
		get => _function;
		init => _function = value;
	}
	readonly uint _function;

	/// <summary>
	/// <b>void* pPrivateInputData</b>
	/// </summary>
	public readonly void* PPrivateInputData {
		get => _pPrivateInputData;
		init => _pPrivateInputData = value;
	}
	readonly void* _pPrivateInputData;

	/// <summary>
	/// <b>UINT PrivateInputDataSize</b>
	/// </summary>
	public readonly uint PrivateInputDataSize {
		get => _privateInputDataSize;
		init => _privateInputDataSize = value;
	}
	readonly uint _privateInputDataSize;

	/// <summary>
	/// <b>void* pPrivateOutputData</b>
	/// </summary>
	public readonly void* PPrivateOutputData {
		get => _pPrivateOutputData;
		init => _pPrivateOutputData = value;
	}
	readonly void* _pPrivateOutputData;

	/// <summary>
	/// <b>UINT PrivateOutputDataSize</b>
	/// </summary>
	public readonly uint PrivateOutputDataSize {
		get => _privateOutputDataSize;
		init => _privateOutputDataSize = value;
	}
	readonly uint _privateOutputDataSize;

	/// <summary>
	/// <b>UINT ResourceCount</b>
	/// </summary>
	public readonly uint ResourceCount {
		get => _resourceCount;
		init => _resourceCount = value;
	}
	readonly uint _resourceCount;

	/// <summary>
	/// <b>ID3D11Resource** ppResourceList</b>
	/// </summary>
	public readonly T** PpResourceList<T> () where T : unmanaged, IResource => (T**) _ppResourceList;
	readonly void* _ppResourceList;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_CAPS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorCaps {

	/// <summary>
	/// <b>UINT DeviceCaps</b>
	/// </summary>
	public readonly uint DeviceCaps {
		get => _deviceCaps;
		init => _deviceCaps = value;
	}
	readonly uint _deviceCaps;

	/// <summary>
	/// <b>UINT FeatureCaps</b>
	/// </summary>
	public readonly uint FeatureCaps {
		get => _featureCaps;
		init => _featureCaps = value;
	}
	readonly uint _featureCaps;

	/// <summary>
	/// <b>UINT FilterCaps</b>
	/// </summary>
	public readonly uint FilterCaps {
		get => _filterCaps;
		init => _filterCaps = value;
	}
	readonly uint _filterCaps;

	/// <summary>
	/// <b>UINT InputFormatCaps</b>
	/// </summary>
	public readonly uint InputFormatCaps {
		get => _inputFormatCaps;
		init => _inputFormatCaps = value;
	}
	readonly uint _inputFormatCaps;

	/// <summary>
	/// <b>UINT AutoStreamCaps</b>
	/// </summary>
	public readonly uint AutoStreamCaps {
		get => _autoStreamCaps;
		init => _autoStreamCaps = value;
	}
	readonly uint _autoStreamCaps;

	/// <summary>
	/// <b>UINT StereoCaps</b>
	/// </summary>
	public readonly uint StereoCaps {
		get => _stereoCaps;
		init => _stereoCaps = value;
	}
	readonly uint _stereoCaps;

	/// <summary>
	/// <b>UINT RateConversionCapsCount</b>
	/// </summary>
	public readonly uint RateConversionCapsCount {
		get => _rateConversionCapsCount;
		init => _rateConversionCapsCount = value;
	}
	readonly uint _rateConversionCapsCount;

	/// <summary>
	/// <b>UINT MaxInputStreams</b>
	/// </summary>
	public readonly uint MaxInputStreams {
		get => _maxInputStreams;
		init => _maxInputStreams = value;
	}
	readonly uint _maxInputStreams;

	/// <summary>
	/// <b>UINT MaxStreamStates</b>
	/// </summary>
	public readonly uint MaxStreamStates {
		get => _maxStreamStates;
		init => _maxStreamStates = value;
	}
	readonly uint _maxStreamStates;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorRateConversionCaps {

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

	/// <summary>
	/// <b>UINT ProcessorCaps</b>
	/// </summary>
	public readonly uint ProcessorCaps {
		get => _processorCaps;
		init => _processorCaps = value;
	}
	readonly uint _processorCaps;

	/// <summary>
	/// <b>UINT ITelecineCaps</b>
	/// </summary>
	public readonly uint ITelecineCaps {
		get => _iTelecineCaps;
		init => _iTelecineCaps = value;
	}
	readonly uint _iTelecineCaps;

	/// <summary>
	/// <b>UINT CustomRateCount</b>
	/// </summary>
	public readonly uint CustomRateCount {
		get => _customRateCount;
		init => _customRateCount = value;
	}
	readonly uint _customRateCount;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_CONTENT_PROTECTION_CAPS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoContentProtectionCaps {

	/// <summary>
	/// <b>UINT Caps</b>
	/// </summary>
	public readonly uint Caps {
		get => _caps;
		init => _caps = value;
	}
	readonly uint _caps;

	/// <summary>
	/// <b>UINT KeyExchangeTypeCount</b>
	/// </summary>
	public readonly uint KeyExchangeTypeCount {
		get => _keyExchangeTypeCount;
		init => _keyExchangeTypeCount = value;
	}
	readonly uint _keyExchangeTypeCount;

	/// <summary>
	/// <b>UINT BlockAlignmentSize</b>
	/// </summary>
	public readonly uint BlockAlignmentSize {
		get => _blockAlignmentSize;
		init => _blockAlignmentSize = value;
	}
	readonly uint _blockAlignmentSize;

	/// <summary>
	/// <b>ULONGLONG ProtectedMemorySize</b>
	/// </summary>
	public readonly ulong ProtectedMemorySize {
		get => _protectedMemorySize;
		init => _protectedMemorySize = value;
	}
	readonly ulong _protectedMemorySize;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_CUSTOM_RATE</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorCustomRate {

	/// <summary>
	/// <b>DXGI_RATIONAL CustomRate</b>
	/// </summary>
	public readonly DXGI.Rational CustomRate {
		get => _customRate;
		init => _customRate = value;
	}
	readonly DXGI.Rational _customRate;

	/// <summary>
	/// <b>UINT OutputFrames</b>
	/// </summary>
	public readonly uint OutputFrames {
		get => _outputFrames;
		init => _outputFrames = value;
	}
	readonly uint _outputFrames;

	/// <summary>
	/// <b>BOOL InputInterlaced</b>
	/// </summary>
	public readonly bool InputInterlaced {
		get => _inputInterlaced != 0;
		init => _inputInterlaced = value ? 1U : 0U;
	}
	readonly uint _inputInterlaced;

	/// <summary>
	/// <b>UINT InputFramesOrFields</b>
	/// </summary>
	public readonly uint InputFramesOrFields {
		get => _inputFramesOrFields;
		init => _inputFramesOrFields = value;
	}
	readonly uint _inputFramesOrFields;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_FILTER_RANGE</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorFilterRange {

	/// <summary>
	/// <b>int Minimum</b>
	/// </summary>
	public readonly int Minimum {
		get => _minimum;
		init => _minimum = value;
	}
	readonly int _minimum;

	/// <summary>
	/// <b>int Maximum</b>
	/// </summary>
	public readonly int Maximum {
		get => _maximum;
		init => _maximum = value;
	}
	readonly int _maximum;

	/// <summary>
	/// <b>int Default</b>
	/// </summary>
	public readonly int Default {
		get => _default;
		init => _default = value;
	}
	readonly int _default;

	/// <summary>
	/// <b>float Multiplier</b>
	/// </summary>
	public readonly float Multiplier {
		get => _multiplier;
		init => _multiplier = value;
	}
	readonly float _multiplier;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_CONTENT_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorContentDesc {

	/// <summary>
	/// <b>D3D11_VIDEO_FRAME_FORMAT InputFrameFormat</b>
	/// </summary>
	public readonly VideoFrameFormat InputFrameFormat {
		get => _inputFrameFormat;
		init => _inputFrameFormat = value;
	}
	readonly VideoFrameFormat _inputFrameFormat;

	/// <summary>
	/// <b>DXGI_RATIONAL InputFrameRate</b>
	/// </summary>
	public readonly DXGI.Rational InputFrameRate {
		get => _inputFrameRate;
		init => _inputFrameRate = value;
	}
	readonly DXGI.Rational _inputFrameRate;

	/// <summary>
	/// <b>UINT InputWidth</b>
	/// </summary>
	public readonly uint InputWidth {
		get => _inputWidth;
		init => _inputWidth = value;
	}
	readonly uint _inputWidth;

	/// <summary>
	/// <b>UINT InputHeight</b>
	/// </summary>
	public readonly uint InputHeight {
		get => _inputHeight;
		init => _inputHeight = value;
	}
	readonly uint _inputHeight;

	/// <summary>
	/// <b>DXGI_RATIONAL OutputFrameRate</b>
	/// </summary>
	public readonly DXGI.Rational OutputFrameRate {
		get => _outputFrameRate;
		init => _outputFrameRate = value;
	}
	readonly DXGI.Rational _outputFrameRate;

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

	/// <summary>
	/// <b>D3D11_VIDEO_USAGE Usage</b>
	/// </summary>
	public readonly VideoUsage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly VideoUsage _usage;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_COLOR_RGBA</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoColorRgba {

	/// <summary>
	/// <b>float R</b>
	/// </summary>
	public readonly float R {
		get => _r;
		init => _r = value;
	}
	readonly float _r;

	/// <summary>
	/// <b>float G</b>
	/// </summary>
	public readonly float G {
		get => _g;
		init => _g = value;
	}
	readonly float _g;

	/// <summary>
	/// <b>float B</b>
	/// </summary>
	public readonly float B {
		get => _b;
		init => _b = value;
	}
	readonly float _b;

	/// <summary>
	/// <b>float A</b>
	/// </summary>
	public readonly float A {
		get => _a;
		init => _a = value;
	}
	readonly float _a;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_COLOR_YCbCrA</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoColorYCbCrA {

	/// <summary>
	/// <b>float Y</b>
	/// </summary>
	public readonly float Y {
		get => _y;
		init => _y = value;
	}
	readonly float _y;

	/// <summary>
	/// <b>float Cb</b>
	/// </summary>
	public readonly float Cb {
		get => _cb;
		init => _cb = value;
	}
	readonly float _cb;

	/// <summary>
	/// <b>float Cr</b>
	/// </summary>
	public readonly float Cr {
		get => _cr;
		init => _cr = value;
	}
	readonly float _cr;

	/// <summary>
	/// <b>float A</b>
	/// </summary>
	public readonly float A {
		get => _a;
		init => _a = value;
	}
	readonly float _a;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_COLOR</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoColor {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_16 {

		[FieldOffset (0)] public VideoColorYCbCrA yCbCr;
		[FieldOffset (0)] public VideoColorRgba rGBA;
	}

	/// <summary>
	/// <b>D3D11_VIDEO_COLOR_YCbCrA YCbCr</b>
	/// </summary>
	public readonly VideoColorYCbCrA YCbCr {
		get => __aSP_AUTO_GENERATED_FIELD_16.yCbCr;
		init => __aSP_AUTO_GENERATED_FIELD_16.yCbCr = value;
	}

	/// <summary>
	/// <b>D3D11_VIDEO_COLOR_RGBA RGBA</b>
	/// </summary>
	public readonly VideoColorRgba Rgba {
		get => __aSP_AUTO_GENERATED_FIELD_16.rGBA;
		init => __aSP_AUTO_GENERATED_FIELD_16.rGBA = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_16 __aSP_AUTO_GENERATED_FIELD_16;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_COLOR_SPACE</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorColorSpace {

	/// <summary>
	/// <b>UINT Usage : 1</b>
	/// </summary>
	public readonly uint Usage {
		get => (_ASP_AUTO_GENERATED_FIELD_114 << 0) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_114 = ((value & 0b1) << 31) + (_ASP_AUTO_GENERATED_FIELD_114 & 0b01111111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT RGB_Range : 1</b>
	/// </summary>
	public readonly uint RGB_Range {
		get => (_ASP_AUTO_GENERATED_FIELD_114 << 1) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_114 = ((value & 0b1) << 30) + (_ASP_AUTO_GENERATED_FIELD_114 & 0b10111111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT YCbCr_Matrix : 1</b>
	/// </summary>
	public readonly uint YCbCr_Matrix {
		get => (_ASP_AUTO_GENERATED_FIELD_114 << 2) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_114 = ((value & 0b1) << 29) + (_ASP_AUTO_GENERATED_FIELD_114 & 0b11011111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT YCbCr_xvYCC : 1</b>
	/// </summary>
	public readonly uint YCbCr_xvYCC {
		get => (_ASP_AUTO_GENERATED_FIELD_114 << 3) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_114 = ((value & 0b1) << 28) + (_ASP_AUTO_GENERATED_FIELD_114 & 0b11101111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT Nominal_Range : 2</b>
	/// </summary>
	public readonly uint Nominal_Range {
		get => (_ASP_AUTO_GENERATED_FIELD_114 << 4) >>> 30;
		init => _ASP_AUTO_GENERATED_FIELD_114 = ((value & 0b11) << 26) + (_ASP_AUTO_GENERATED_FIELD_114 & 0b11110011111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT Reserved : 26</b>
	/// </summary>
	public readonly uint Reserved {
		get => (_ASP_AUTO_GENERATED_FIELD_114 << 6) >>> 6;
		init => _ASP_AUTO_GENERATED_FIELD_114 = ((value & 0b11111111111111111111111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_114 & 0b11111100000000000000000000000000);
	}

	readonly uint _ASP_AUTO_GENERATED_FIELD_114;
}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_STREAM</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorStream {

	/// <summary>
	/// <b>BOOL Enable</b>
	/// </summary>
	public readonly bool Enable {
		get => _enable != 0;
		init => _enable = value ? 1U : 0U;
	}
	readonly uint _enable;

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

	/// <summary>
	/// <b>ID3D11VideoProcessorInputView** ppPastSurfaces</b>
	/// </summary>
	public readonly T** PpPastSurfaces<T> () where T : unmanaged, IVideoProcessorInputView => (T**) _ppPastSurfaces;
	readonly void* _ppPastSurfaces;

	/// <summary>
	/// <b>ID3D11VideoProcessorInputView* pInputSurface</b>
	/// </summary>
	public readonly T* PInputSurface<T> () where T : unmanaged, IVideoProcessorInputView => (T*) _pInputSurface;
	readonly void* _pInputSurface;

	/// <summary>
	/// <b>ID3D11VideoProcessorInputView** ppFutureSurfaces</b>
	/// </summary>
	public readonly T** PpFutureSurfaces<T> () where T : unmanaged, IVideoProcessorInputView => (T**) _ppFutureSurfaces;
	readonly void* _ppFutureSurfaces;

	/// <summary>
	/// <b>ID3D11VideoProcessorInputView** ppPastSurfacesRight</b>
	/// </summary>
	public readonly T** PpPastSurfacesRight<T> () where T : unmanaged, IVideoProcessorInputView => (T**) _ppPastSurfacesRight;
	readonly void* _ppPastSurfacesRight;

	/// <summary>
	/// <b>ID3D11VideoProcessorInputView* pInputSurfaceRight</b>
	/// </summary>
	public readonly T* PInputSurfaceRight<T> () where T : unmanaged, IVideoProcessorInputView => (T*) _pInputSurfaceRight;
	readonly void* _pInputSurfaceRight;

	/// <summary>
	/// <b>ID3D11VideoProcessorInputView** ppFutureSurfacesRight</b>
	/// </summary>
	public readonly T** PpFutureSurfacesRight<T> () where T : unmanaged, IVideoProcessorInputView => (T**) _ppFutureSurfacesRight;
	readonly void* _ppFutureSurfacesRight;

}

/// <summary>
/// STRUCTURE <b>D3D11_OMAC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Omac {

	/// <summary>
	/// <b>BYTE Omac [16]</b>
	/// </summary>
	public readonly Span<byte> Omac_ {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _omac)), 16);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_115 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [16];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_115 _omac;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryInput {

	/// <summary>
	/// <b>GUID QueryType</b>
	/// </summary>
	public readonly Guid QueryType {
		get => _queryType;
		init => _queryType = value;
	}
	readonly Guid _queryType;

	/// <summary>
	/// <b>HANDLE hChannel</b>
	/// </summary>
	public readonly IntPtr HChannel {
		get => _hChannel;
		init => _hChannel = value;
	}
	readonly IntPtr _hChannel;

	/// <summary>
	/// <b>UINT SequenceNumber</b>
	/// </summary>
	public readonly uint SequenceNumber {
		get => _sequenceNumber;
		init => _sequenceNumber = value;
	}
	readonly uint _sequenceNumber;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryOutput {

	/// <summary>
	/// <b>D3D11_OMAC omac</b>
	/// </summary>
	public readonly Omac Omac {
		get => _omac;
		init => _omac = value;
	}
	readonly Omac _omac;

	/// <summary>
	/// <b>GUID QueryType</b>
	/// </summary>
	public readonly Guid QueryType {
		get => _queryType;
		init => _queryType = value;
	}
	readonly Guid _queryType;

	/// <summary>
	/// <b>HANDLE hChannel</b>
	/// </summary>
	public readonly IntPtr HChannel {
		get => _hChannel;
		init => _hChannel = value;
	}
	readonly IntPtr _hChannel;

	/// <summary>
	/// <b>UINT SequenceNumber</b>
	/// </summary>
	public readonly uint SequenceNumber {
		get => _sequenceNumber;
		init => _sequenceNumber = value;
	}
	readonly uint _sequenceNumber;

	/// <summary>
	/// <b>HRESULT ReturnCode</b>
	/// </summary>
	public readonly int ReturnCode {
		get => _returnCode;
		init => _returnCode = value;
	}
	readonly int _returnCode;

}

/// <summary>
/// UNION <b>D3D11_AUTHENTICATED_PROTECTION_FLAGS</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Explicit)]
unsafe public readonly struct AuthenticatedProtectionFlags {

	/// <summary>
	/// <b>__MIDL___MIDL_itf_d3d11_0000_0034_0001 Flags</b>
	/// </summary>
	public readonly MidlMidlitfd3d11000000340001 Flags {
		get => _flags;
		init => _flags = value;
	}
	[FieldOffset (0)] readonly MidlMidlitfd3d11000000340001 _flags;

	/// <summary>
	/// <b>UINT Value</b>
	/// </summary>
	public readonly uint Value {
		get => _value;
		init => _value = value;
	}
	[FieldOffset (0)] readonly uint _value;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryProtectionOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_PROTECTION_FLAGS ProtectionFlags</b>
	/// </summary>
	public readonly AuthenticatedProtectionFlags ProtectionFlags {
		get => _protectionFlags;
		init => _protectionFlags = value;
	}
	readonly AuthenticatedProtectionFlags _protectionFlags;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryChannelTypeOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType</b>
	/// </summary>
	public readonly AuthenticatedChannelType ChannelType {
		get => _channelType;
		init => _channelType = value;
	}
	readonly AuthenticatedChannelType _channelType;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryDeviceHandleOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>HANDLE DeviceHandle</b>
	/// </summary>
	public readonly IntPtr DeviceHandle {
		get => _deviceHandle;
		init => _deviceHandle = value;
	}
	readonly IntPtr _deviceHandle;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryCryptoSessionInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_INPUT Input</b>
	/// </summary>
	public readonly AuthenticatedQueryInput Input {
		get => _input;
		init => _input = value;
	}
	readonly AuthenticatedQueryInput _input;

	/// <summary>
	/// <b>HANDLE DecoderHandle</b>
	/// </summary>
	public readonly IntPtr DecoderHandle {
		get => _decoderHandle;
		init => _decoderHandle = value;
	}
	readonly IntPtr _decoderHandle;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryCryptoSessionOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>HANDLE DecoderHandle</b>
	/// </summary>
	public readonly IntPtr DecoderHandle {
		get => _decoderHandle;
		init => _decoderHandle = value;
	}
	readonly IntPtr _decoderHandle;

	/// <summary>
	/// <b>HANDLE CryptoSessionHandle</b>
	/// </summary>
	public readonly IntPtr CryptoSessionHandle {
		get => _cryptoSessionHandle;
		init => _cryptoSessionHandle = value;
	}
	readonly IntPtr _cryptoSessionHandle;

	/// <summary>
	/// <b>HANDLE DeviceHandle</b>
	/// </summary>
	public readonly IntPtr DeviceHandle {
		get => _deviceHandle;
		init => _deviceHandle = value;
	}
	readonly IntPtr _deviceHandle;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryRestrictedSharedResourceProcessCountOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>UINT RestrictedSharedResourceProcessCount</b>
	/// </summary>
	public readonly uint RestrictedSharedResourceProcessCount {
		get => _restrictedSharedResourceProcessCount;
		init => _restrictedSharedResourceProcessCount = value;
	}
	readonly uint _restrictedSharedResourceProcessCount;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryRestrictedSharedResourceProcessInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_INPUT Input</b>
	/// </summary>
	public readonly AuthenticatedQueryInput Input {
		get => _input;
		init => _input = value;
	}
	readonly AuthenticatedQueryInput _input;

	/// <summary>
	/// <b>UINT ProcessIndex</b>
	/// </summary>
	public readonly uint ProcessIndex {
		get => _processIndex;
		init => _processIndex = value;
	}
	readonly uint _processIndex;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryRestrictedSharedResourceProcessOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>UINT ProcessIndex</b>
	/// </summary>
	public readonly uint ProcessIndex {
		get => _processIndex;
		init => _processIndex = value;
	}
	readonly uint _processIndex;

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessIdentifier</b>
	/// </summary>
	public readonly AuthenticatedProcessIdentifierType ProcessIdentifier {
		get => _processIdentifier;
		init => _processIdentifier = value;
	}
	readonly AuthenticatedProcessIdentifierType _processIdentifier;

	/// <summary>
	/// <b>HANDLE ProcessHandle</b>
	/// </summary>
	public readonly IntPtr ProcessHandle {
		get => _processHandle;
		init => _processHandle = value;
	}
	readonly IntPtr _processHandle;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryUnrestrictedProtectedSharedResourceCountOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>UINT UnrestrictedProtectedSharedResourceCount</b>
	/// </summary>
	public readonly uint UnrestrictedProtectedSharedResourceCount {
		get => _unrestrictedProtectedSharedResourceCount;
		init => _unrestrictedProtectedSharedResourceCount = value;
	}
	readonly uint _unrestrictedProtectedSharedResourceCount;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryOutputIdCountInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_INPUT Input</b>
	/// </summary>
	public readonly AuthenticatedQueryInput Input {
		get => _input;
		init => _input = value;
	}
	readonly AuthenticatedQueryInput _input;

	/// <summary>
	/// <b>HANDLE DeviceHandle</b>
	/// </summary>
	public readonly IntPtr DeviceHandle {
		get => _deviceHandle;
		init => _deviceHandle = value;
	}
	readonly IntPtr _deviceHandle;

	/// <summary>
	/// <b>HANDLE CryptoSessionHandle</b>
	/// </summary>
	public readonly IntPtr CryptoSessionHandle {
		get => _cryptoSessionHandle;
		init => _cryptoSessionHandle = value;
	}
	readonly IntPtr _cryptoSessionHandle;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryOutputIdCountOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>HANDLE DeviceHandle</b>
	/// </summary>
	public readonly IntPtr DeviceHandle {
		get => _deviceHandle;
		init => _deviceHandle = value;
	}
	readonly IntPtr _deviceHandle;

	/// <summary>
	/// <b>HANDLE CryptoSessionHandle</b>
	/// </summary>
	public readonly IntPtr CryptoSessionHandle {
		get => _cryptoSessionHandle;
		init => _cryptoSessionHandle = value;
	}
	readonly IntPtr _cryptoSessionHandle;

	/// <summary>
	/// <b>UINT OutputIDCount</b>
	/// </summary>
	public readonly uint OutputIDCount {
		get => _outputIDCount;
		init => _outputIDCount = value;
	}
	readonly uint _outputIDCount;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryOutputIdInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_INPUT Input</b>
	/// </summary>
	public readonly AuthenticatedQueryInput Input {
		get => _input;
		init => _input = value;
	}
	readonly AuthenticatedQueryInput _input;

	/// <summary>
	/// <b>HANDLE DeviceHandle</b>
	/// </summary>
	public readonly IntPtr DeviceHandle {
		get => _deviceHandle;
		init => _deviceHandle = value;
	}
	readonly IntPtr _deviceHandle;

	/// <summary>
	/// <b>HANDLE CryptoSessionHandle</b>
	/// </summary>
	public readonly IntPtr CryptoSessionHandle {
		get => _cryptoSessionHandle;
		init => _cryptoSessionHandle = value;
	}
	readonly IntPtr _cryptoSessionHandle;

	/// <summary>
	/// <b>UINT OutputIDIndex</b>
	/// </summary>
	public readonly uint OutputIDIndex {
		get => _outputIDIndex;
		init => _outputIDIndex = value;
	}
	readonly uint _outputIDIndex;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryOutputIdOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>HANDLE DeviceHandle</b>
	/// </summary>
	public readonly IntPtr DeviceHandle {
		get => _deviceHandle;
		init => _deviceHandle = value;
	}
	readonly IntPtr _deviceHandle;

	/// <summary>
	/// <b>HANDLE CryptoSessionHandle</b>
	/// </summary>
	public readonly IntPtr CryptoSessionHandle {
		get => _cryptoSessionHandle;
		init => _cryptoSessionHandle = value;
	}
	readonly IntPtr _cryptoSessionHandle;

	/// <summary>
	/// <b>UINT OutputIDIndex</b>
	/// </summary>
	public readonly uint OutputIDIndex {
		get => _outputIDIndex;
		init => _outputIDIndex = value;
	}
	readonly uint _outputIDIndex;

	/// <summary>
	/// <b>UINT64 OutputID</b>
	/// </summary>
	public readonly ulong OutputID {
		get => _outputID;
		init => _outputID = value;
	}
	readonly ulong _outputID;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT</b> (D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT)<br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryAcessibilityOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>D3D11_BUS_TYPE BusType</b>
	/// </summary>
	public readonly BusType BusType {
		get => _busType;
		init => _busType = value;
	}
	readonly BusType _busType;

	/// <summary>
	/// <b>BOOL AccessibleInContiguousBlocks</b>
	/// </summary>
	public readonly bool AccessibleInContiguousBlocks {
		get => _accessibleInContiguousBlocks != 0;
		init => _accessibleInContiguousBlocks = value ? 1U : 0U;
	}
	readonly uint _accessibleInContiguousBlocks;

	/// <summary>
	/// <b>BOOL AccessibleInNonContiguousBlocks</b>
	/// </summary>
	public readonly bool AccessibleInNonContiguousBlocks {
		get => _accessibleInNonContiguousBlocks != 0;
		init => _accessibleInNonContiguousBlocks = value ? 1U : 0U;
	}
	readonly uint _accessibleInNonContiguousBlocks;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_COUNT_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryAccessibilityEncryptionGuidCountOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>UINT EncryptionGuidCount</b>
	/// </summary>
	public readonly uint EncryptionGuidCount {
		get => _encryptionGuidCount;
		init => _encryptionGuidCount = value;
	}
	readonly uint _encryptionGuidCount;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryAccessibilityEncryptionGuidInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_INPUT Input</b>
	/// </summary>
	public readonly AuthenticatedQueryInput Input {
		get => _input;
		init => _input = value;
	}
	readonly AuthenticatedQueryInput _input;

	/// <summary>
	/// <b>UINT EncryptionGuidIndex</b>
	/// </summary>
	public readonly uint EncryptionGuidIndex {
		get => _encryptionGuidIndex;
		init => _encryptionGuidIndex = value;
	}
	readonly uint _encryptionGuidIndex;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryAccessibilityEncryptionGuidOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>UINT EncryptionGuidIndex</b>
	/// </summary>
	public readonly uint EncryptionGuidIndex {
		get => _encryptionGuidIndex;
		init => _encryptionGuidIndex = value;
	}
	readonly uint _encryptionGuidIndex;

	/// <summary>
	/// <b>GUID EncryptionGuid</b>
	/// </summary>
	public readonly Guid EncryptionGuid {
		get => _encryptionGuid;
		init => _encryptionGuid = value;
	}
	readonly Guid _encryptionGuid;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_QUERY_CURRENT_ACCESSIBILITY_ENCRYPTION_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedQueryCurrentAccessibilityEncryptionOutput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT Output</b>
	/// </summary>
	public readonly AuthenticatedQueryOutput Output {
		get => _output;
		init => _output = value;
	}
	readonly AuthenticatedQueryOutput _output;

	/// <summary>
	/// <b>GUID EncryptionGuid</b>
	/// </summary>
	public readonly Guid EncryptionGuid {
		get => _encryptionGuid;
		init => _encryptionGuid = value;
	}
	readonly Guid _encryptionGuid;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_CONFIGURE_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedConfigureInput {

	/// <summary>
	/// <b>D3D11_OMAC omac</b>
	/// </summary>
	public readonly Omac Omac {
		get => _omac;
		init => _omac = value;
	}
	readonly Omac _omac;

	/// <summary>
	/// <b>GUID ConfigureType</b>
	/// </summary>
	public readonly Guid ConfigureType {
		get => _configureType;
		init => _configureType = value;
	}
	readonly Guid _configureType;

	/// <summary>
	/// <b>HANDLE hChannel</b>
	/// </summary>
	public readonly IntPtr HChannel {
		get => _hChannel;
		init => _hChannel = value;
	}
	readonly IntPtr _hChannel;

	/// <summary>
	/// <b>UINT SequenceNumber</b>
	/// </summary>
	public readonly uint SequenceNumber {
		get => _sequenceNumber;
		init => _sequenceNumber = value;
	}
	readonly uint _sequenceNumber;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_CONFIGURE_OUTPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedConfigureOutput {

	/// <summary>
	/// <b>D3D11_OMAC omac</b>
	/// </summary>
	public readonly Omac Omac {
		get => _omac;
		init => _omac = value;
	}
	readonly Omac _omac;

	/// <summary>
	/// <b>GUID ConfigureType</b>
	/// </summary>
	public readonly Guid ConfigureType {
		get => _configureType;
		init => _configureType = value;
	}
	readonly Guid _configureType;

	/// <summary>
	/// <b>HANDLE hChannel</b>
	/// </summary>
	public readonly IntPtr HChannel {
		get => _hChannel;
		init => _hChannel = value;
	}
	readonly IntPtr _hChannel;

	/// <summary>
	/// <b>UINT SequenceNumber</b>
	/// </summary>
	public readonly uint SequenceNumber {
		get => _sequenceNumber;
		init => _sequenceNumber = value;
	}
	readonly uint _sequenceNumber;

	/// <summary>
	/// <b>HRESULT ReturnCode</b>
	/// </summary>
	public readonly int ReturnCode {
		get => _returnCode;
		init => _returnCode = value;
	}
	readonly int _returnCode;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedConfigureInitializeInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters</b>
	/// </summary>
	public readonly AuthenticatedConfigureInput Parameters {
		get => _parameters;
		init => _parameters = value;
	}
	readonly AuthenticatedConfigureInput _parameters;

	/// <summary>
	/// <b>UINT StartSequenceQuery</b>
	/// </summary>
	public readonly uint StartSequenceQuery {
		get => _startSequenceQuery;
		init => _startSequenceQuery = value;
	}
	readonly uint _startSequenceQuery;

	/// <summary>
	/// <b>UINT StartSequenceConfigure</b>
	/// </summary>
	public readonly uint StartSequenceConfigure {
		get => _startSequenceConfigure;
		init => _startSequenceConfigure = value;
	}
	readonly uint _startSequenceConfigure;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedConfigureProtectionInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters</b>
	/// </summary>
	public readonly AuthenticatedConfigureInput Parameters {
		get => _parameters;
		init => _parameters = value;
	}
	readonly AuthenticatedConfigureInput _parameters;

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_PROTECTION_FLAGS Protections</b>
	/// </summary>
	public readonly AuthenticatedProtectionFlags Protections {
		get => _protections;
		init => _protections = value;
	}
	readonly AuthenticatedProtectionFlags _protections;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedConfigureCryptoSessionInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters</b>
	/// </summary>
	public readonly AuthenticatedConfigureInput Parameters {
		get => _parameters;
		init => _parameters = value;
	}
	readonly AuthenticatedConfigureInput _parameters;

	/// <summary>
	/// <b>HANDLE DecoderHandle</b>
	/// </summary>
	public readonly IntPtr DecoderHandle {
		get => _decoderHandle;
		init => _decoderHandle = value;
	}
	readonly IntPtr _decoderHandle;

	/// <summary>
	/// <b>HANDLE CryptoSessionHandle</b>
	/// </summary>
	public readonly IntPtr CryptoSessionHandle {
		get => _cryptoSessionHandle;
		init => _cryptoSessionHandle = value;
	}
	readonly IntPtr _cryptoSessionHandle;

	/// <summary>
	/// <b>HANDLE DeviceHandle</b>
	/// </summary>
	public readonly IntPtr DeviceHandle {
		get => _deviceHandle;
		init => _deviceHandle = value;
	}
	readonly IntPtr _deviceHandle;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedConfigureSharedResourceInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters</b>
	/// </summary>
	public readonly AuthenticatedConfigureInput Parameters {
		get => _parameters;
		init => _parameters = value;
	}
	readonly AuthenticatedConfigureInput _parameters;

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType</b>
	/// </summary>
	public readonly AuthenticatedProcessIdentifierType ProcessType {
		get => _processType;
		init => _processType = value;
	}
	readonly AuthenticatedProcessIdentifierType _processType;

	/// <summary>
	/// <b>HANDLE ProcessHandle</b>
	/// </summary>
	public readonly IntPtr ProcessHandle {
		get => _processHandle;
		init => _processHandle = value;
	}
	readonly IntPtr _processHandle;

	/// <summary>
	/// <b>BOOL AllowAccess</b>
	/// </summary>
	public readonly bool AllowAccess {
		get => _allowAccess != 0;
		init => _allowAccess = value ? 1U : 0U;
	}
	readonly uint _allowAccess;

}

/// <summary>
/// STRUCTURE <b>D3D11_AUTHENTICATED_CONFIGURE_ACCESSIBLE_ENCRYPTION_INPUT</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AuthenticatedConfigureAccessibleEncryptionInput {

	/// <summary>
	/// <b>D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters</b>
	/// </summary>
	public readonly AuthenticatedConfigureInput Parameters {
		get => _parameters;
		init => _parameters = value;
	}
	readonly AuthenticatedConfigureInput _parameters;

	/// <summary>
	/// <b>GUID EncryptionGuid</b>
	/// </summary>
	public readonly Guid EncryptionGuid {
		get => _encryptionGuid;
		init => _encryptionGuid = value;
	}
	readonly Guid _encryptionGuid;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_VDOV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dVdov {

	/// <summary>
	/// <b>UINT ArraySlice</b>
	/// </summary>
	public readonly uint ArraySlice {
		get => _arraySlice;
		init => _arraySlice = value;
	}
	readonly uint _arraySlice;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderOutputViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_18 {

		[FieldOffset (0)] public Tex2dVdov texture2D;
	}

	/// <summary>
	/// <b>GUID DecodeProfile</b>
	/// </summary>
	public readonly Guid DecodeProfile {
		get => _decodeProfile;
		init => _decodeProfile = value;
	}
	readonly Guid _decodeProfile;

	/// <summary>
	/// <b>D3D11_VDOV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly VdovDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly VdovDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_TEX2D_VDOV Texture2D</b>
	/// </summary>
	public readonly Tex2dVdov Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_18.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_18.texture2D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_18 __aSP_AUTO_GENERATED_FIELD_18;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_VPIV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dVpiv {

	/// <summary>
	/// <b>UINT MipSlice</b>
	/// </summary>
	public readonly uint MipSlice {
		get => _mipSlice;
		init => _mipSlice = value;
	}
	readonly uint _mipSlice;

	/// <summary>
	/// <b>UINT ArraySlice</b>
	/// </summary>
	public readonly uint ArraySlice {
		get => _arraySlice;
		init => _arraySlice = value;
	}
	readonly uint _arraySlice;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorInputViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_20 {

		[FieldOffset (0)] public Tex2dVpiv texture2D;
	}

	/// <summary>
	/// <b>UINT FourCC</b>
	/// </summary>
	public readonly uint FourCC {
		get => _fourCC;
		init => _fourCC = value;
	}
	readonly uint _fourCC;

	/// <summary>
	/// <b>D3D11_VPIV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly VpivDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly VpivDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_TEX2D_VPIV Texture2D</b>
	/// </summary>
	public readonly Tex2dVpiv Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_20.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_20.texture2D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_20 __aSP_AUTO_GENERATED_FIELD_20;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_VPOV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dVpov {

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
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_VPOV</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArrayVpov {

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
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC</b><br/>
/// D3D11.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorOutputViewDesc {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_22 {

		[FieldOffset (0)] public Tex2dVpov texture2D;
		[FieldOffset (0)] public Tex2dArrayVpov texture2DArray;
	}

	/// <summary>
	/// <b>D3D11_VPOV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly VpovDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly VpovDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_TEX2D_VPOV Texture2D</b>
	/// </summary>
	public readonly Tex2dVpov Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_22.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_22.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_VPOV Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayVpov Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_22.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_22.texture2DArray = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_22 __aSP_AUTO_GENERATED_FIELD_22;

}

/// <summary>
/// STRUCTURE <b>D3D11_RESOURCE_FLAGS</b><br/>
/// D3D11ON12.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceFlags {

	/// <summary>
	/// <b>UINT BindFlags</b>
	/// </summary>
	public readonly uint BindFlags {
		get => _bindFlags;
		init => _bindFlags = value;
	}
	readonly uint _bindFlags;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

	/// <summary>
	/// <b>UINT CPUAccessFlags</b>
	/// </summary>
	public readonly uint CPUAccessFlags {
		get => _cPUAccessFlags;
		init => _cPUAccessFlags = value;
	}
	readonly uint _cPUAccessFlags;

	/// <summary>
	/// <b>UINT StructureByteStride</b>
	/// </summary>
	public readonly uint StructureByteStride {
		get => _structureByteStride;
		init => _structureByteStride = value;
	}
	readonly uint _structureByteStride;

}

/// <summary>
/// STRUCTURE <b>D3D11_MESSAGE</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Message {

	/// <summary>
	/// <b>D3D11_MESSAGE_CATEGORY Category</b>
	/// </summary>
	public readonly MessageCategory Category {
		get => _category;
		init => _category = value;
	}
	readonly MessageCategory _category;

	/// <summary>
	/// <b>D3D11_MESSAGE_SEVERITY Severity</b>
	/// </summary>
	public readonly MessageSeverity Severity {
		get => _severity;
		init => _severity = value;
	}
	readonly MessageSeverity _severity;

	/// <summary>
	/// <b>D3D11_MESSAGE_ID ID</b>
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
/// STRUCTURE <b>D3D11_INFO_QUEUE_FILTER_DESC</b><br/>
/// D3D11SDKLAYERS.h
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
	/// <b>D3D11_MESSAGE_CATEGORY* pCategoryList</b>
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
	/// <b>D3D11_MESSAGE_SEVERITY* pSeverityList</b>
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
	/// <b>D3D11_MESSAGE_ID* pIDList</b>
	/// </summary>
	public readonly MessageId* PIDList {
		get => _pIDList;
		init => _pIDList = value;
	}
	readonly MessageId* _pIDList;

}

/// <summary>
/// STRUCTURE <b>D3D11_INFO_QUEUE_FILTER</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InfoQueueFilter {

	/// <summary>
	/// <b>D3D11_INFO_QUEUE_FILTER_DESC AllowList</b>
	/// </summary>
	public readonly InfoQueueFilterDesc AllowList {
		get => _allowList;
		init => _allowList = value;
	}
	readonly InfoQueueFilterDesc _allowList;

	/// <summary>
	/// <b>D3D11_INFO_QUEUE_FILTER_DESC DenyList</b>
	/// </summary>
	public readonly InfoQueueFilterDesc DenyList {
		get => _denyList;
		init => _denyList = value;
	}
	readonly InfoQueueFilterDesc _denyList;

}

/// <summary>
/// STRUCTURE <b>_D3D11_SIGNATURE_PARAMETER_DESC</b> (D3D11_SIGNATURE_PARAMETER_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>_D3D11_SHADER_BUFFER_DESC</b> (D3D11_SHADER_BUFFER_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>_D3D11_SHADER_VARIABLE_DESC</b> (D3D11_SHADER_VARIABLE_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>_D3D11_SHADER_TYPE_DESC</b> (D3D11_SHADER_TYPE_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>_D3D11_SHADER_DESC</b> (D3D11_SHADER_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>_D3D11_SHADER_INPUT_BIND_DESC</b> (D3D11_SHADER_INPUT_BIND_DESC)<br/>
/// D3D11SHADER.h
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

}

/// <summary>
/// STRUCTURE <b>_D3D11_LIBRARY_DESC</b> (D3D11_LIBRARY_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>_D3D11_FUNCTION_DESC</b> (D3D11_FUNCTION_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>_D3D11_PARAMETER_DESC</b> (D3D11_PARAMETER_DESC)<br/>
/// D3D11SHADER.h
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
/// STRUCTURE <b>D3D11_RENDER_TARGET_BLEND_DESC1</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderTargetBlendDesc1 {

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
	/// <b>D3D11_BLEND SrcBlend</b>
	/// </summary>
	public readonly Blend SrcBlend {
		get => _srcBlend;
		init => _srcBlend = value;
	}
	readonly Blend _srcBlend;

	/// <summary>
	/// <b>D3D11_BLEND DestBlend</b>
	/// </summary>
	public readonly Blend DestBlend {
		get => _destBlend;
		init => _destBlend = value;
	}
	readonly Blend _destBlend;

	/// <summary>
	/// <b>D3D11_BLEND_OP BlendOp</b>
	/// </summary>
	public readonly BlendOp BlendOp {
		get => _blendOp;
		init => _blendOp = value;
	}
	readonly BlendOp _blendOp;

	/// <summary>
	/// <b>D3D11_BLEND SrcBlendAlpha</b>
	/// </summary>
	public readonly Blend SrcBlendAlpha {
		get => _srcBlendAlpha;
		init => _srcBlendAlpha = value;
	}
	readonly Blend _srcBlendAlpha;

	/// <summary>
	/// <b>D3D11_BLEND DestBlendAlpha</b>
	/// </summary>
	public readonly Blend DestBlendAlpha {
		get => _destBlendAlpha;
		init => _destBlendAlpha = value;
	}
	readonly Blend _destBlendAlpha;

	/// <summary>
	/// <b>D3D11_BLEND_OP BlendOpAlpha</b>
	/// </summary>
	public readonly BlendOp BlendOpAlpha {
		get => _blendOpAlpha;
		init => _blendOpAlpha = value;
	}
	readonly BlendOp _blendOpAlpha;

	/// <summary>
	/// <b>D3D11_LOGIC_OP LogicOp</b>
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
/// STRUCTURE <b>D3D11_BLEND_DESC1</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BlendDesc1 {

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
	/// <b>D3D11_RENDER_TARGET_BLEND_DESC1 RenderTarget [8]</b>
	/// </summary>
	public readonly Span<RenderTargetBlendDesc1> RenderTarget {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _renderTarget)), 8);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_117 {
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_0;
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_1;
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_2;
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_3;
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_4;
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_5;
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_6;
		public RenderTargetBlendDesc1 _ASP_AUTO_GENERATED_FIELD_7;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_117 _renderTarget;

}

/// <summary>
/// STRUCTURE <b>D3D11_RASTERIZER_DESC1</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RasterizerDesc1 {

	/// <summary>
	/// <b>D3D11_FILL_MODE FillMode</b>
	/// </summary>
	public readonly FillMode FillMode {
		get => _fillMode;
		init => _fillMode = value;
	}
	readonly FillMode _fillMode;

	/// <summary>
	/// <b>D3D11_CULL_MODE CullMode</b>
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
	/// <b>BOOL ScissorEnable</b>
	/// </summary>
	public readonly bool ScissorEnable {
		get => _scissorEnable != 0;
		init => _scissorEnable = value ? 1U : 0U;
	}
	readonly uint _scissorEnable;

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

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderSubSampleMappingBlock {

	/// <summary>
	/// <b>UINT ClearSize</b>
	/// </summary>
	public readonly uint ClearSize {
		get => _clearSize;
		init => _clearSize = value;
	}
	readonly uint _clearSize;

	/// <summary>
	/// <b>UINT EncryptedSize</b>
	/// </summary>
	public readonly uint EncryptedSize {
		get => _encryptedSize;
		init => _encryptedSize = value;
	}
	readonly uint _encryptedSize;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_BUFFER_DESC1</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderBufferDesc1 {

	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType</b>
	/// </summary>
	public readonly VideoDecoderBufferType BufferType {
		get => _bufferType;
		init => _bufferType = value;
	}
	readonly VideoDecoderBufferType _bufferType;

	/// <summary>
	/// <b>UINT DataOffset</b>
	/// </summary>
	public readonly uint DataOffset {
		get => _dataOffset;
		init => _dataOffset = value;
	}
	readonly uint _dataOffset;

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>void* pIV</b>
	/// </summary>
	public readonly void* PIV {
		get => _pIV;
		init => _pIV = value;
	}
	readonly void* _pIV;

	/// <summary>
	/// <b>UINT IVSize</b>
	/// </summary>
	public readonly uint IVSize {
		get => _iVSize;
		init => _iVSize = value;
	}
	readonly uint _iVSize;

	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK* pSubSampleMappingBlock</b>
	/// </summary>
	public readonly VideoDecoderSubSampleMappingBlock* PSubSampleMappingBlock {
		get => _pSubSampleMappingBlock;
		init => _pSubSampleMappingBlock = value;
	}
	readonly VideoDecoderSubSampleMappingBlock* _pSubSampleMappingBlock;

	/// <summary>
	/// <b>UINT SubSampleMappingCount</b>
	/// </summary>
	public readonly uint SubSampleMappingCount {
		get => _subSampleMappingCount;
		init => _subSampleMappingCount = value;
	}
	readonly uint _subSampleMappingCount;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderBeginFrameCryptoSession {

	/// <summary>
	/// <b>ID3D11CryptoSession* pCryptoSession</b>
	/// </summary>
	public readonly T* PCryptoSession<T> () where T : unmanaged, ICryptoSession => (T*) _pCryptoSession;
	readonly void* _pCryptoSession;

	/// <summary>
	/// <b>UINT BlobSize</b>
	/// </summary>
	public readonly uint BlobSize {
		get => _blobSize;
		init => _blobSize = value;
	}
	readonly uint _blobSize;

	/// <summary>
	/// <b>void* pBlob</b>
	/// </summary>
	public readonly void* PBlob {
		get => _pBlob;
		init => _pBlob = value;
	}
	readonly void* _pBlob;

	/// <summary>
	/// <b>GUID* pKeyInfoId</b>
	/// </summary>
	public readonly Guid* PKeyInfoId {
		get => _pKeyInfoId;
		init => _pKeyInfoId = value;
	}
	readonly Guid* _pKeyInfoId;

	/// <summary>
	/// <b>UINT PrivateDataSize</b>
	/// </summary>
	public readonly uint PrivateDataSize {
		get => _privateDataSize;
		init => _privateDataSize = value;
	}
	readonly uint _privateDataSize;

	/// <summary>
	/// <b>void* pPrivateData</b>
	/// </summary>
	public readonly void* PPrivateData {
		get => _pPrivateData;
		init => _pPrivateData = value;
	}
	readonly void* _pPrivateData;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoProcessorStreamBehaviorHint {

	/// <summary>
	/// <b>BOOL Enable</b>
	/// </summary>
	public readonly bool Enable {
		get => _enable != 0;
		init => _enable = value ? 1U : 0U;
	}
	readonly uint _enable;

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
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

}

/// <summary>
/// STRUCTURE <b>D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct KeyExchangeHwProtectionInputData {

	/// <summary>
	/// <b>UINT PrivateDataSize</b>
	/// </summary>
	public readonly uint PrivateDataSize {
		get => _privateDataSize;
		init => _privateDataSize = value;
	}
	readonly uint _privateDataSize;

	/// <summary>
	/// <b>UINT HWProtectionDataSize</b>
	/// </summary>
	public readonly uint HWProtectionDataSize {
		get => _hWProtectionDataSize;
		init => _hWProtectionDataSize = value;
	}
	readonly uint _hWProtectionDataSize;

	/// <summary>
	/// <b>BYTE pbInput [4]</b>
	/// </summary>
	public readonly Span<byte> PbInput {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _pbInput)), 4);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_118 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [4];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_118 _pbInput;

}

/// <summary>
/// STRUCTURE <b>D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct KeyExchangeHwProtectionOutputData {

	/// <summary>
	/// <b>UINT PrivateDataSize</b>
	/// </summary>
	public readonly uint PrivateDataSize {
		get => _privateDataSize;
		init => _privateDataSize = value;
	}
	readonly uint _privateDataSize;

	/// <summary>
	/// <b>UINT MaxHWProtectionDataSize</b>
	/// </summary>
	public readonly uint MaxHWProtectionDataSize {
		get => _maxHWProtectionDataSize;
		init => _maxHWProtectionDataSize = value;
	}
	readonly uint _maxHWProtectionDataSize;

	/// <summary>
	/// <b>UINT HWProtectionDataSize</b>
	/// </summary>
	public readonly uint HWProtectionDataSize {
		get => _hWProtectionDataSize;
		init => _hWProtectionDataSize = value;
	}
	readonly uint _hWProtectionDataSize;

	/// <summary>
	/// <b>UINT64 TransportTime</b>
	/// </summary>
	public readonly ulong TransportTime {
		get => _transportTime;
		init => _transportTime = value;
	}
	readonly ulong _transportTime;

	/// <summary>
	/// <b>UINT64 ExecutionTime</b>
	/// </summary>
	public readonly ulong ExecutionTime {
		get => _executionTime;
		init => _executionTime = value;
	}
	readonly ulong _executionTime;

	/// <summary>
	/// <b>BYTE pbOutput [4]</b>
	/// </summary>
	public readonly Span<byte> PbOutput {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _pbOutput)), 4);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_119 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [4];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_119 _pbOutput;

}

/// <summary>
/// STRUCTURE <b>D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct KeyExchangeHwProtectionData {

	/// <summary>
	/// <b>UINT HWProtectionFunctionID</b>
	/// </summary>
	public readonly uint HWProtectionFunctionID {
		get => _hWProtectionFunctionID;
		init => _hWProtectionFunctionID = value;
	}
	readonly uint _hWProtectionFunctionID;

	/// <summary>
	/// <b>D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA* pInputData</b>
	/// </summary>
	public readonly KeyExchangeHwProtectionInputData* PInputData {
		get => _pInputData;
		init => _pInputData = value;
	}
	readonly KeyExchangeHwProtectionInputData* _pInputData;

	/// <summary>
	/// <b>D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA* pOutputData</b>
	/// </summary>
	public readonly KeyExchangeHwProtectionOutputData* POutputData {
		get => _pOutputData;
		init => _pOutputData = value;
	}
	readonly KeyExchangeHwProtectionOutputData* _pOutputData;

	/// <summary>
	/// <b>HRESULT Status</b>
	/// </summary>
	public readonly int Status {
		get => _status;
		init => _status = value;
	}
	readonly int _status;

}

/// <summary>
/// STRUCTURE <b>D3D11_VIDEO_SAMPLE_DESC</b><br/>
/// D3D11_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoSampleDesc {

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
/// STRUCTURE <b>D3D11_TILED_RESOURCE_COORDINATE</b><br/>
/// D3D11_2.h
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
/// STRUCTURE <b>D3D11_TILE_REGION_SIZE</b><br/>
/// D3D11_2.h
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
	/// <b>BOOL bUseBox</b>
	/// </summary>
	public readonly bool BUseBox {
		get => _bUseBox != 0;
		init => _bUseBox = value ? 1U : 0U;
	}
	readonly uint _bUseBox;

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
/// STRUCTURE <b>D3D11_SUBRESOURCE_TILING</b><br/>
/// D3D11_2.h
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
/// STRUCTURE <b>D3D11_TILE_SHAPE</b><br/>
/// D3D11_2.h
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
/// STRUCTURE <b>D3D11_PACKED_MIP_DESC</b><br/>
/// D3D11_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PackedMipDesc {

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
/// STRUCTURE <b>D3D11_TEXTURE2D_DESC1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Texture2dDesc1 {

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
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

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
	/// <b>D3D11_USAGE Usage</b>
	/// </summary>
	public readonly Usage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly Usage _usage;

	/// <summary>
	/// <b>UINT BindFlags</b>
	/// </summary>
	public readonly uint BindFlags {
		get => _bindFlags;
		init => _bindFlags = value;
	}
	readonly uint _bindFlags;

	/// <summary>
	/// <b>UINT CPUAccessFlags</b>
	/// </summary>
	public readonly uint CPUAccessFlags {
		get => _cPUAccessFlags;
		init => _cPUAccessFlags = value;
	}
	readonly uint _cPUAccessFlags;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

	/// <summary>
	/// <b>D3D11_TEXTURE_LAYOUT TextureLayout</b>
	/// </summary>
	public readonly TextureLayout TextureLayout {
		get => _textureLayout;
		init => _textureLayout = value;
	}
	readonly TextureLayout _textureLayout;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEXTURE3D_DESC1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Texture3dDesc1 {

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
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D3D11_USAGE Usage</b>
	/// </summary>
	public readonly Usage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly Usage _usage;

	/// <summary>
	/// <b>UINT BindFlags</b>
	/// </summary>
	public readonly uint BindFlags {
		get => _bindFlags;
		init => _bindFlags = value;
	}
	readonly uint _bindFlags;

	/// <summary>
	/// <b>UINT CPUAccessFlags</b>
	/// </summary>
	public readonly uint CPUAccessFlags {
		get => _cPUAccessFlags;
		init => _cPUAccessFlags = value;
	}
	readonly uint _cPUAccessFlags;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

	/// <summary>
	/// <b>D3D11_TEXTURE_LAYOUT TextureLayout</b>
	/// </summary>
	public readonly TextureLayout TextureLayout {
		get => _textureLayout;
		init => _textureLayout = value;
	}
	readonly TextureLayout _textureLayout;

}

/// <summary>
/// STRUCTURE <b>D3D11_RASTERIZER_DESC2</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RasterizerDesc2 {

	/// <summary>
	/// <b>D3D11_FILL_MODE FillMode</b>
	/// </summary>
	public readonly FillMode FillMode {
		get => _fillMode;
		init => _fillMode = value;
	}
	readonly FillMode _fillMode;

	/// <summary>
	/// <b>D3D11_CULL_MODE CullMode</b>
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
	/// <b>BOOL ScissorEnable</b>
	/// </summary>
	public readonly bool ScissorEnable {
		get => _scissorEnable != 0;
		init => _scissorEnable = value ? 1U : 0U;
	}
	readonly uint _scissorEnable;

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
	/// <b>D3D11_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster</b>
	/// </summary>
	public readonly ConservativeRasterizationMode ConservativeRaster {
		get => _conservativeRaster;
		init => _conservativeRaster = value;
	}
	readonly ConservativeRasterizationMode _conservativeRaster;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_SRV1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dSrv1 {

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

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_SRV1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArraySrv1 {

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

}

/// <summary>
/// STRUCTURE <b>D3D11_SHADER_RESOURCE_VIEW_DESC1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderResourceViewDesc1 {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_24 {

		[FieldOffset (0)] public BufferSrv buffer;
		[FieldOffset (0)] public Tex1dSrv texture1D;
		[FieldOffset (0)] public Tex1dArraySrv texture1DArray;
		[FieldOffset (0)] public Tex2dSrv1 texture2D;
		[FieldOffset (0)] public Tex2dArraySrv1 texture2DArray;
		[FieldOffset (0)] public Tex2dmsSrv texture2DMS;
		[FieldOffset (0)] public Tex2dmsArraySrv texture2DMSArray;
		[FieldOffset (0)] public Tex3dSrv texture3D;
		[FieldOffset (0)] public TexcubeSrv textureCube;
		[FieldOffset (0)] public TexcubeArraySrv textureCubeArray;
		[FieldOffset (0)] public BufferexSrv bufferEx;
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
	/// <b>D3D11_SRV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly Direct3D.SrvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly Direct3D.SrvDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_BUFFER_SRV Buffer</b>
	/// </summary>
	public readonly BufferSrv Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_24.buffer;
		init => __aSP_AUTO_GENERATED_FIELD_24.buffer = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_SRV Texture1D</b>
	/// </summary>
	public readonly Tex1dSrv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_24.texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_24.texture1D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_ARRAY_SRV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArraySrv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_24.texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_24.texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_SRV1 Texture2D</b>
	/// </summary>
	public readonly Tex2dSrv1 Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_24.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_24.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_SRV1 Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArraySrv1 Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_24.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_24.texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_SRV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsSrv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_24.texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_24.texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArraySrv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_24.texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_24.texture2DMSArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX3D_SRV Texture3D</b>
	/// </summary>
	public readonly Tex3dSrv Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_24.texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_24.texture3D = value;
	}

	/// <summary>
	/// <b>D3D11_TEXCUBE_SRV TextureCube</b>
	/// </summary>
	public readonly TexcubeSrv TextureCube {
		get => __aSP_AUTO_GENERATED_FIELD_24.textureCube;
		init => __aSP_AUTO_GENERATED_FIELD_24.textureCube = value;
	}

	/// <summary>
	/// <b>D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray</b>
	/// </summary>
	public readonly TexcubeArraySrv TextureCubeArray {
		get => __aSP_AUTO_GENERATED_FIELD_24.textureCubeArray;
		init => __aSP_AUTO_GENERATED_FIELD_24.textureCubeArray = value;
	}

	/// <summary>
	/// <b>D3D11_BUFFEREX_SRV BufferEx</b>
	/// </summary>
	public readonly BufferexSrv BufferEx {
		get => __aSP_AUTO_GENERATED_FIELD_24.bufferEx;
		init => __aSP_AUTO_GENERATED_FIELD_24.bufferEx = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_24 __aSP_AUTO_GENERATED_FIELD_24;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_RTV1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dRtv1 {

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
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_RTV1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArrayRtv1 {

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
/// STRUCTURE <b>D3D11_RENDER_TARGET_VIEW_DESC1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderTargetViewDesc1 {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_26 {

		[FieldOffset (0)] public BufferRtv buffer;
		[FieldOffset (0)] public Tex1dRtv texture1D;
		[FieldOffset (0)] public Tex1dArrayRtv texture1DArray;
		[FieldOffset (0)] public Tex2dRtv1 texture2D;
		[FieldOffset (0)] public Tex2dArrayRtv1 texture2DArray;
		[FieldOffset (0)] public Tex2dmsRtv texture2DMS;
		[FieldOffset (0)] public Tex2dmsArrayRtv texture2DMSArray;
		[FieldOffset (0)] public Tex3dRtv texture3D;
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
	/// <b>D3D11_RTV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly RtvDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly RtvDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_BUFFER_RTV Buffer</b>
	/// </summary>
	public readonly BufferRtv Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_26.buffer;
		init => __aSP_AUTO_GENERATED_FIELD_26.buffer = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_RTV Texture1D</b>
	/// </summary>
	public readonly Tex1dRtv Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_26.texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_26.texture1D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_ARRAY_RTV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayRtv Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_26.texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_26.texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_RTV1 Texture2D</b>
	/// </summary>
	public readonly Tex2dRtv1 Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_26.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_26.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_RTV1 Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayRtv1 Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_26.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_26.texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_RTV Texture2DMS</b>
	/// </summary>
	public readonly Tex2dmsRtv Texture2DMS {
		get => __aSP_AUTO_GENERATED_FIELD_26.texture2DMS;
		init => __aSP_AUTO_GENERATED_FIELD_26.texture2DMS = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray</b>
	/// </summary>
	public readonly Tex2dmsArrayRtv Texture2DMSArray {
		get => __aSP_AUTO_GENERATED_FIELD_26.texture2DMSArray;
		init => __aSP_AUTO_GENERATED_FIELD_26.texture2DMSArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX3D_RTV Texture3D</b>
	/// </summary>
	public readonly Tex3dRtv Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_26.texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_26.texture3D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_26 __aSP_AUTO_GENERATED_FIELD_26;

}

/// <summary>
/// STRUCTURE <b>D3D11_TEX2D_UAV1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dUav1 {

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
/// STRUCTURE <b>D3D11_TEX2D_ARRAY_UAV1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Tex2dArrayUav1 {

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
/// STRUCTURE <b>D3D11_UNORDERED_ACCESS_VIEW_DESC1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct UnorderedAccessViewDesc1 {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_28 {

		[FieldOffset (0)] public BufferUav buffer;
		[FieldOffset (0)] public Tex1dUav texture1D;
		[FieldOffset (0)] public Tex1dArrayUav texture1DArray;
		[FieldOffset (0)] public Tex2dUav1 texture2D;
		[FieldOffset (0)] public Tex2dArrayUav1 texture2DArray;
		[FieldOffset (0)] public Tex3dUav texture3D;
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
	/// <b>D3D11_UAV_DIMENSION ViewDimension</b>
	/// </summary>
	public readonly UavDimension ViewDimension {
		get => _viewDimension;
		init => _viewDimension = value;
	}
	readonly UavDimension _viewDimension;

	/// <summary>
	/// <b>D3D11_BUFFER_UAV Buffer</b>
	/// </summary>
	public readonly BufferUav Buffer {
		get => __aSP_AUTO_GENERATED_FIELD_28.buffer;
		init => __aSP_AUTO_GENERATED_FIELD_28.buffer = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_UAV Texture1D</b>
	/// </summary>
	public readonly Tex1dUav Texture1D {
		get => __aSP_AUTO_GENERATED_FIELD_28.texture1D;
		init => __aSP_AUTO_GENERATED_FIELD_28.texture1D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX1D_ARRAY_UAV Texture1DArray</b>
	/// </summary>
	public readonly Tex1dArrayUav Texture1DArray {
		get => __aSP_AUTO_GENERATED_FIELD_28.texture1DArray;
		init => __aSP_AUTO_GENERATED_FIELD_28.texture1DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_UAV1 Texture2D</b>
	/// </summary>
	public readonly Tex2dUav1 Texture2D {
		get => __aSP_AUTO_GENERATED_FIELD_28.texture2D;
		init => __aSP_AUTO_GENERATED_FIELD_28.texture2D = value;
	}

	/// <summary>
	/// <b>D3D11_TEX2D_ARRAY_UAV1 Texture2DArray</b>
	/// </summary>
	public readonly Tex2dArrayUav1 Texture2DArray {
		get => __aSP_AUTO_GENERATED_FIELD_28.texture2DArray;
		init => __aSP_AUTO_GENERATED_FIELD_28.texture2DArray = value;
	}

	/// <summary>
	/// <b>D3D11_TEX3D_UAV Texture3D</b>
	/// </summary>
	public readonly Tex3dUav Texture3D {
		get => __aSP_AUTO_GENERATED_FIELD_28.texture3D;
		init => __aSP_AUTO_GENERATED_FIELD_28.texture3D = value;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_28 __aSP_AUTO_GENERATED_FIELD_28;

}

/// <summary>
/// STRUCTURE <b>D3D11_QUERY_DESC1</b><br/>
/// D3D11_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryDesc1 {

	/// <summary>
	/// <b>D3D11_QUERY Query</b>
	/// </summary>
	public readonly QueryEnum Query {
		get => _query;
		init => _query = value;
	}
	readonly QueryEnum _query;

	/// <summary>
	/// <b>UINT MiscFlags</b>
	/// </summary>
	public readonly uint MiscFlags {
		get => _miscFlags;
		init => _miscFlags = value;
	}
	readonly uint _miscFlags;

	/// <summary>
	/// <b>D3D11_CONTEXT_TYPE ContextType</b>
	/// </summary>
	public readonly ContextType ContextType {
		get => _contextType;
		init => _contextType = value;
	}
	readonly ContextType _contextType;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM</b><br/>
/// D3D11_4.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataVideoDecoderHistogram {

	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_DESC DecoderDesc</b>
	/// </summary>
	public readonly VideoDecoderDesc DecoderDesc {
		get => _decoderDesc;
		init => _decoderDesc = value;
	}
	readonly VideoDecoderDesc _decoderDesc;

	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS Components</b>
	/// </summary>
	public readonly VideoDecoderHistogramComponentFlags Components {
		get => _components;
		init => _components = value;
	}
	readonly VideoDecoderHistogramComponentFlags _components;

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
/// STRUCTURE <b>D3D11_VIDEO_DECODER_BUFFER_DESC2</b><br/>
/// D3D11_4.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VideoDecoderBufferDesc2 {

	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType</b>
	/// </summary>
	public readonly VideoDecoderBufferType BufferType {
		get => _bufferType;
		init => _bufferType = value;
	}
	readonly VideoDecoderBufferType _bufferType;

	/// <summary>
	/// <b>UINT DataOffset</b>
	/// </summary>
	public readonly uint DataOffset {
		get => _dataOffset;
		init => _dataOffset = value;
	}
	readonly uint _dataOffset;

	/// <summary>
	/// <b>UINT DataSize</b>
	/// </summary>
	public readonly uint DataSize {
		get => _dataSize;
		init => _dataSize = value;
	}
	readonly uint _dataSize;

	/// <summary>
	/// <b>void* pIV</b>
	/// </summary>
	public readonly void* PIV {
		get => _pIV;
		init => _pIV = value;
	}
	readonly void* _pIV;

	/// <summary>
	/// <b>UINT IVSize</b>
	/// </summary>
	public readonly uint IVSize {
		get => _iVSize;
		init => _iVSize = value;
	}
	readonly uint _iVSize;

	/// <summary>
	/// <b>D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK* pSubSampleMappingBlock</b>
	/// </summary>
	public readonly VideoDecoderSubSampleMappingBlock* PSubSampleMappingBlock {
		get => _pSubSampleMappingBlock;
		init => _pSubSampleMappingBlock = value;
	}
	readonly VideoDecoderSubSampleMappingBlock* _pSubSampleMappingBlock;

	/// <summary>
	/// <b>UINT SubSampleMappingCount</b>
	/// </summary>
	public readonly uint SubSampleMappingCount {
		get => _subSampleMappingCount;
		init => _subSampleMappingCount = value;
	}
	readonly uint _subSampleMappingCount;

	/// <summary>
	/// <b>UINT cBlocksStripeEncrypted</b>
	/// </summary>
	public readonly uint CBlocksStripeEncrypted {
		get => _cBlocksStripeEncrypted;
		init => _cBlocksStripeEncrypted = value;
	}
	readonly uint _cBlocksStripeEncrypted;

	/// <summary>
	/// <b>UINT cBlocksStripeClear</b>
	/// </summary>
	public readonly uint CBlocksStripeClear {
		get => _cBlocksStripeClear;
		init => _cBlocksStripeClear = value;
	}
	readonly uint _cBlocksStripeClear;

}

/// <summary>
/// STRUCTURE <b>D3D11_FEATURE_DATA_D3D11_OPTIONS4</b><br/>
/// D3D11_4.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d11Options4 {

	/// <summary>
	/// <b>BOOL ExtendedNV12SharedTextureSupported</b>
	/// </summary>
	public readonly bool ExtendedNV12SharedTextureSupported {
		get => _extendedNV12SharedTextureSupported != 0;
		init => _extendedNV12SharedTextureSupported = value ? 1U : 0U;
	}
	readonly uint _extendedNV12SharedTextureSupported;

}
