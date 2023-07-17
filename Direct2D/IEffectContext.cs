using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1EffectContext</b> : IUnknown<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IEffectContext : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1EffectContext::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDpi (float* dpiX, float* dpiY);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1EffectContext::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDpi (out float dpiX, out float dpiY);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateEffect (REFCLSID effectId, ID2D1Effect** effect)</b><br/>
	/// </summary>
	/// <param name="effectId">_In_ <b>REFCLSID effectId</b></param>
	/// <param name="effect">_COM_Outptr_ <b>ID2D1Effect** effect</b></param>
	int CreateEffect<T0> (Guid effectId, T0** effect) where T0 : unmanaged, IEffect;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateEffect (REFCLSID effectId, ID2D1Effect** effect)</b><br/>
	/// </summary>
	/// <param name="effectId">_In_ <b>REFCLSID effectId</b></param>
	/// <param name="effect">_COM_Outptr_ <b>ID2D1Effect** effect</b></param>
	int CreateEffect<T0> (Guid effectId, out T0* effect) where T0 : unmanaged, IEffect;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::GetMaximumSupportedFeatureLevel (D3D_FEATURE_LEVEL* featureLevels, UINT32 featureLevelsCount, D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel)</b><br/>
	/// </summary>
	/// <param name="featureLevels">_In_reads_(featureLevelsCount) <b>D3D_FEATURE_LEVEL* featureLevels</b></param>
	/// <param name="featureLevelsCount"><b>UINT32 featureLevelsCount</b></param>
	/// <param name="maximumSupportedFeatureLevel">_Out_ <b>D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel</b></param>
	int GetMaximumSupportedFeatureLevel (Direct3D.FeatureLevel* featureLevels, uint featureLevelsCount, Direct3D.FeatureLevel* maximumSupportedFeatureLevel);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::GetMaximumSupportedFeatureLevel (D3D_FEATURE_LEVEL* featureLevels, UINT32 featureLevelsCount, D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel)</b><br/>
	/// </summary>
	/// <param name="featureLevels">_In_reads_(featureLevelsCount) <b>D3D_FEATURE_LEVEL* featureLevels</b></param>
	/// <param name="featureLevelsCount"><b>UINT32 featureLevelsCount</b></param>
	/// <param name="maximumSupportedFeatureLevel">_Out_ <b>D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel</b></param>
	int GetMaximumSupportedFeatureLevel (Direct3D.FeatureLevel* featureLevels, uint featureLevelsCount, out Direct3D.FeatureLevel maximumSupportedFeatureLevel);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateTransformNodeFromEffect (ID2D1Effect* effect, ID2D1TransformNode** transformNode)</b><br/>
	/// </summary>
	/// <param name="effect">_In_ <b>ID2D1Effect* effect</b></param>
	/// <param name="transformNode">_COM_Outptr_ <b>ID2D1TransformNode** transformNode</b></param>
	int CreateTransformNodeFromEffect<T0, T1> (T0* effect, T1** transformNode) where T0 : unmanaged, IEffect where T1 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateTransformNodeFromEffect (ID2D1Effect* effect, ID2D1TransformNode** transformNode)</b><br/>
	/// </summary>
	/// <param name="effect">_In_ <b>ID2D1Effect* effect</b></param>
	/// <param name="transformNode">_COM_Outptr_ <b>ID2D1TransformNode** transformNode</b></param>
	int CreateTransformNodeFromEffect<T0, T1> (T0* effect, out T1* transformNode) where T0 : unmanaged, IEffect where T1 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateBlendTransform (UINT32 numInputs, D2D1_BLEND_DESCRIPTION* blendDescription, ID2D1BlendTransform** transform)</b><br/>
	/// </summary>
	/// <param name="numInputs"><b>UINT32 numInputs</b></param>
	/// <param name="blendDescription">_In_ <b>D2D1_BLEND_DESCRIPTION* blendDescription</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1BlendTransform** transform</b></param>
	int CreateBlendTransform<T0> (uint numInputs, BlendDescription* blendDescription, T0** transform) where T0 : unmanaged, IBlendTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateBlendTransform (UINT32 numInputs, D2D1_BLEND_DESCRIPTION* blendDescription, ID2D1BlendTransform** transform)</b><br/>
	/// </summary>
	/// <param name="numInputs"><b>UINT32 numInputs</b></param>
	/// <param name="blendDescription">_In_ <b>D2D1_BLEND_DESCRIPTION* blendDescription</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1BlendTransform** transform</b></param>
	int CreateBlendTransform<T0> (uint numInputs, BlendDescription* blendDescription, out T0* transform) where T0 : unmanaged, IBlendTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateBorderTransform (D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, ID2D1BorderTransform** transform)</b><br/>
	/// </summary>
	/// <param name="extendModeX"><b>D2D1_EXTEND_MODE extendModeX</b></param>
	/// <param name="extendModeY"><b>D2D1_EXTEND_MODE extendModeY</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1BorderTransform** transform</b></param>
	int CreateBorderTransform<T0> (ExtendMode extendModeX, ExtendMode extendModeY, T0** transform) where T0 : unmanaged, IBorderTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateBorderTransform (D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, ID2D1BorderTransform** transform)</b><br/>
	/// </summary>
	/// <param name="extendModeX"><b>D2D1_EXTEND_MODE extendModeX</b></param>
	/// <param name="extendModeY"><b>D2D1_EXTEND_MODE extendModeY</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1BorderTransform** transform</b></param>
	int CreateBorderTransform<T0> (ExtendMode extendModeX, ExtendMode extendModeY, out T0* transform) where T0 : unmanaged, IBorderTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateOffsetTransform (D2D1_POINT_2L offset, ID2D1OffsetTransform** transform)</b><br/>
	/// </summary>
	/// <param name="offset"><b>D2D1_POINT_2L offset</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1OffsetTransform** transform</b></param>
	int CreateOffsetTransform<T0> (Vector2I offset, T0** transform) where T0 : unmanaged, IOffsetTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateOffsetTransform (D2D1_POINT_2L offset, ID2D1OffsetTransform** transform)</b><br/>
	/// </summary>
	/// <param name="offset"><b>D2D1_POINT_2L offset</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1OffsetTransform** transform</b></param>
	int CreateOffsetTransform<T0> (Vector2I offset, out T0* transform) where T0 : unmanaged, IOffsetTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateBoundsAdjustmentTransform (D2D1_RECT_L* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)</b><br/>
	/// </summary>
	/// <param name="outputRectangle">_In_ <b>D2D1_RECT_L* outputRectangle</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1BoundsAdjustmentTransform** transform</b></param>
	int CreateBoundsAdjustmentTransform<T0> (Vector4I* outputRectangle, T0** transform) where T0 : unmanaged, IBoundsAdjustmentTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateBoundsAdjustmentTransform (D2D1_RECT_L* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)</b><br/>
	/// </summary>
	/// <param name="outputRectangle">_In_ <b>D2D1_RECT_L* outputRectangle</b></param>
	/// <param name="transform">_COM_Outptr_ <b>ID2D1BoundsAdjustmentTransform** transform</b></param>
	int CreateBoundsAdjustmentTransform<T0> (Vector4I* outputRectangle, out T0* transform) where T0 : unmanaged, IBoundsAdjustmentTransform;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::LoadPixelShader (REFGUID shaderId, BYTE* shaderBuffer, UINT32 shaderBufferCount)</b><br/>
	/// </summary>
	/// <param name="shaderId"><b>REFGUID shaderId</b></param>
	/// <param name="shaderBuffer">_In_reads_(shaderBufferCount) <b>BYTE* shaderBuffer</b></param>
	/// <param name="shaderBufferCount"><b>UINT32 shaderBufferCount</b></param>
	int LoadPixelShader (Guid shaderId, byte* shaderBuffer, uint shaderBufferCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::LoadVertexShader (REFGUID resourceId, BYTE* shaderBuffer, UINT32 shaderBufferCount)</b><br/>
	/// </summary>
	/// <param name="resourceId"><b>REFGUID resourceId</b></param>
	/// <param name="shaderBuffer">_In_reads_(shaderBufferCount) <b>BYTE* shaderBuffer</b></param>
	/// <param name="shaderBufferCount"><b>UINT32 shaderBufferCount</b></param>
	int LoadVertexShader (Guid resourceId, byte* shaderBuffer, uint shaderBufferCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::LoadComputeShader (REFGUID resourceId, BYTE* shaderBuffer, UINT32 shaderBufferCount)</b><br/>
	/// </summary>
	/// <param name="resourceId"><b>REFGUID resourceId</b></param>
	/// <param name="shaderBuffer">_In_reads_(shaderBufferCount) <b>BYTE* shaderBuffer</b></param>
	/// <param name="shaderBufferCount"><b>UINT32 shaderBufferCount</b></param>
	int LoadComputeShader (Guid resourceId, byte* shaderBuffer, uint shaderBufferCount);
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1EffectContext::IsShaderLoaded (REFGUID shaderId)</b><br/>
	/// </summary>
	/// <param name="shaderId"><b>REFGUID shaderId</b></param>
	bool IsShaderLoaded (Guid shaderId);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateResourceTexture (GUID* resourceId, D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, BYTE* data, UINT32* strides, UINT32 dataSize, ID2D1ResourceTexture** resourceTexture)</b><br/>
	/// </summary>
	/// <param name="resourceId">_In_opt_ <b>GUID* resourceId</b></param>
	/// <param name="resourceTextureProperties">_In_ <b>D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties</b></param>
	/// <param name="data">_In_reads_opt_(dataSize) <b>BYTE* data</b></param>
	/// <param name="strides">_In_reads_opt_(resourceTextureProperties->dimensions - 1) <b>UINT32* strides</b></param>
	/// <param name="dataSize"><b>UINT32 dataSize</b></param>
	/// <param name="resourceTexture">_COM_Outptr_ <b>ID2D1ResourceTexture** resourceTexture</b></param>
	int CreateResourceTexture<T0> (Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, T0** resourceTexture) where T0 : unmanaged, IResourceTexture;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateResourceTexture (GUID* resourceId, D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, BYTE* data, UINT32* strides, UINT32 dataSize, ID2D1ResourceTexture** resourceTexture)</b><br/>
	/// </summary>
	/// <param name="resourceId">_In_opt_ <b>GUID* resourceId</b></param>
	/// <param name="resourceTextureProperties">_In_ <b>D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties</b></param>
	/// <param name="data">_In_reads_opt_(dataSize) <b>BYTE* data</b></param>
	/// <param name="strides">_In_reads_opt_(resourceTextureProperties->dimensions - 1) <b>UINT32* strides</b></param>
	/// <param name="dataSize"><b>UINT32 dataSize</b></param>
	/// <param name="resourceTexture">_COM_Outptr_ <b>ID2D1ResourceTexture** resourceTexture</b></param>
	int CreateResourceTexture<T0> (Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, out T0* resourceTexture) where T0 : unmanaged, IResourceTexture;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::FindResourceTexture (GUID* resourceId, ID2D1ResourceTexture** resourceTexture)</b><br/>
	/// </summary>
	/// <param name="resourceId">_In_ <b>GUID* resourceId</b></param>
	/// <param name="resourceTexture">_COM_Outptr_ <b>ID2D1ResourceTexture** resourceTexture</b></param>
	int FindResourceTexture<T0> (Guid* resourceId, T0** resourceTexture) where T0 : unmanaged, IResourceTexture;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::FindResourceTexture (GUID* resourceId, ID2D1ResourceTexture** resourceTexture)</b><br/>
	/// </summary>
	/// <param name="resourceId">_In_ <b>GUID* resourceId</b></param>
	/// <param name="resourceTexture">_COM_Outptr_ <b>ID2D1ResourceTexture** resourceTexture</b></param>
	int FindResourceTexture<T0> (Guid* resourceId, out T0* resourceTexture) where T0 : unmanaged, IResourceTexture;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateVertexBuffer (D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, GUID* resourceId, D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, ID2D1VertexBuffer** buffer)</b><br/>
	/// </summary>
	/// <param name="vertexBufferProperties">_In_ <b>D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties</b></param>
	/// <param name="resourceId">_In_opt_ <b>GUID* resourceId</b></param>
	/// <param name="customVertexBufferProperties">_In_opt_ <b>D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties</b></param>
	/// <param name="buffer">_COM_Outptr_ <b>ID2D1VertexBuffer** buffer</b></param>
	int CreateVertexBuffer<T0> (VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, T0** buffer) where T0 : unmanaged, IVertexBuffer;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateVertexBuffer (D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, GUID* resourceId, D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, ID2D1VertexBuffer** buffer)</b><br/>
	/// </summary>
	/// <param name="vertexBufferProperties">_In_ <b>D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties</b></param>
	/// <param name="resourceId">_In_opt_ <b>GUID* resourceId</b></param>
	/// <param name="customVertexBufferProperties">_In_opt_ <b>D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties</b></param>
	/// <param name="buffer">_COM_Outptr_ <b>ID2D1VertexBuffer** buffer</b></param>
	int CreateVertexBuffer<T0> (VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, out T0* buffer) where T0 : unmanaged, IVertexBuffer;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::FindVertexBuffer (GUID* resourceId, ID2D1VertexBuffer** buffer)</b><br/>
	/// </summary>
	/// <param name="resourceId">_In_ <b>GUID* resourceId</b></param>
	/// <param name="buffer">_COM_Outptr_ <b>ID2D1VertexBuffer** buffer</b></param>
	int FindVertexBuffer<T0> (Guid* resourceId, T0** buffer) where T0 : unmanaged, IVertexBuffer;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::FindVertexBuffer (GUID* resourceId, ID2D1VertexBuffer** buffer)</b><br/>
	/// </summary>
	/// <param name="resourceId">_In_ <b>GUID* resourceId</b></param>
	/// <param name="buffer">_COM_Outptr_ <b>ID2D1VertexBuffer** buffer</b></param>
	int FindVertexBuffer<T0> (Guid* resourceId, out T0* buffer) where T0 : unmanaged, IVertexBuffer;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateColorContext (D2D1_COLOR_SPACE space, BYTE* profile, UINT32 profileSize, ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="space"><b>D2D1_COLOR_SPACE space</b></param>
	/// <param name="profile">_In_reads_opt_(profileSize) <b>BYTE* profile</b></param>
	/// <param name="profileSize"><b>UINT32 profileSize</b></param>
	/// <param name="colorContext">_COM_Outptr_ <b>ID2D1ColorContext** colorContext</b></param>
	int CreateColorContext<T0> (ColorSpace space, byte* profile, uint profileSize, T0** colorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateColorContext (D2D1_COLOR_SPACE space, BYTE* profile, UINT32 profileSize, ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="space"><b>D2D1_COLOR_SPACE space</b></param>
	/// <param name="profile">_In_reads_opt_(profileSize) <b>BYTE* profile</b></param>
	/// <param name="profileSize"><b>UINT32 profileSize</b></param>
	/// <param name="colorContext">_COM_Outptr_ <b>ID2D1ColorContext** colorContext</b></param>
	int CreateColorContext<T0> (ColorSpace space, byte* profile, uint profileSize, out T0* colorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateColorContextFromFilename (PCWSTR filename, ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="filename">_In_ <b>PCWSTR filename</b></param>
	/// <param name="colorContext">_COM_Outptr_ <b>ID2D1ColorContext** colorContext</b></param>
	int CreateColorContextFromFilename<T0> (char* filename, T0** colorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateColorContextFromFilename (PCWSTR filename, ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="filename">_In_ <b>PCWSTR filename</b></param>
	/// <param name="colorContext">_COM_Outptr_ <b>ID2D1ColorContext** colorContext</b></param>
	int CreateColorContextFromFilename<T0> (char* filename, out T0* colorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateColorContextFromWicColorContext (IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="wicColorContext">_In_ <b>IWICColorContext* wicColorContext</b></param>
	/// <param name="colorContext">_COM_Outptr_ <b>ID2D1ColorContext** colorContext</b></param>
	int CreateColorContextFromWicColorContext<T0, T1> (T0* wicColorContext, T1** colorContext) where T0 : unmanaged, WIC.IColorContext where T1 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CreateColorContextFromWicColorContext (IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="wicColorContext">_In_ <b>IWICColorContext* wicColorContext</b></param>
	/// <param name="colorContext">_COM_Outptr_ <b>ID2D1ColorContext** colorContext</b></param>
	int CreateColorContextFromWicColorContext<T0, T1> (T0* wicColorContext, out T1* colorContext) where T0 : unmanaged, WIC.IColorContext where T1 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext::CheckFeatureSupport (D2D1_FEATURE feature, void* featureSupportData, UINT32 featureSupportDataSize)</b><br/>
	/// </summary>
	/// <param name="feature"><b>D2D1_FEATURE feature</b></param>
	/// <param name="featureSupportData">_Out_writes_bytes_(featureSupportDataSize) <b>void* featureSupportData</b></param>
	/// <param name="featureSupportDataSize"><b>UINT32 featureSupportDataSize</b></param>
	int CheckFeatureSupport (Feature feature, void* featureSupportData, uint featureSupportDataSize);
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1EffectContext::IsBufferPrecisionSupported (D2D1_BUFFER_PRECISION bufferPrecision)</b><br/>
	/// </summary>
	/// <param name="bufferPrecision"><b>D2D1_BUFFER_PRECISION bufferPrecision</b></param>
	bool IsBufferPrecisionSupported (BufferPrecision bufferPrecision);
}

/// <summary>
/// Instance of <b>ID2D1EffectContext</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct EffectContext : IEffectContext {
//unsafe public readonly struct IEffectContextObj : IEffectContext {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly EffectContext* GetCurrentPointer () => (EffectContext*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IEffectContextObj* GetCurrentPointer () => (IEffectContextObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3d9f916b, 0x27dc, 0x4ad7, 0xb4, 0xf1, 0x64, 0x94, 0x53, 0x40, 0xf5, 0x63);

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryInterface (Guid riid, void** ppvObject) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryInterface (ptr, riid, ppvObject);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryInterface (Guid riid, out void* ppvObject) {
		fixed (void** _ppvObject = &ppvObject) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->QueryInterface (ptr, riid, _ppvObject);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint AddRef () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddRef (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint Release () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Release (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDpi (float* dpiX, float* dpiY) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDpi (ptr, dpiX, dpiY);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDpi (out float dpiX, out float dpiY) {
		fixed (float* _dpiX = &dpiX) {
			fixed (float* _dpiY = &dpiY) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->GetDpi (ptr, _dpiX, _dpiY);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEffect<T0> (Guid effectId, T0** effect) where T0 : unmanaged, IEffect {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateEffect (ptr, effectId, (void**) effect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEffect<T0> (Guid effectId, out T0* effect) where T0 : unmanaged, IEffect {
		fixed (T0** _effect = &effect) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateEffect (ptr, effectId, (void**) _effect);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMaximumSupportedFeatureLevel (Direct3D.FeatureLevel* featureLevels, uint featureLevelsCount, Direct3D.FeatureLevel* maximumSupportedFeatureLevel) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMaximumSupportedFeatureLevel (ptr, featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMaximumSupportedFeatureLevel (Direct3D.FeatureLevel* featureLevels, uint featureLevelsCount, out Direct3D.FeatureLevel maximumSupportedFeatureLevel) {
		fixed (Direct3D.FeatureLevel* _maximumSupportedFeatureLevel = &maximumSupportedFeatureLevel) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMaximumSupportedFeatureLevel (ptr, featureLevels, featureLevelsCount, _maximumSupportedFeatureLevel);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTransformNodeFromEffect<T0, T1> (T0* effect, T1** transformNode) where T0 : unmanaged, IEffect where T1 : unmanaged, ITransformNode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTransformNodeFromEffect (ptr, effect, (void**) transformNode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTransformNodeFromEffect<T0, T1> (T0* effect, out T1* transformNode) where T0 : unmanaged, IEffect where T1 : unmanaged, ITransformNode {
		fixed (T1** _transformNode = &transformNode) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTransformNodeFromEffect (ptr, effect, (void**) _transformNode);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBlendTransform<T0> (uint numInputs, BlendDescription* blendDescription, T0** transform) where T0 : unmanaged, IBlendTransform {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBlendTransform (ptr, numInputs, blendDescription, (void**) transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBlendTransform<T0> (uint numInputs, BlendDescription* blendDescription, out T0* transform) where T0 : unmanaged, IBlendTransform {
		fixed (T0** _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBlendTransform (ptr, numInputs, blendDescription, (void**) _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBorderTransform<T0> (ExtendMode extendModeX, ExtendMode extendModeY, T0** transform) where T0 : unmanaged, IBorderTransform {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBorderTransform (ptr, extendModeX, extendModeY, (void**) transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBorderTransform<T0> (ExtendMode extendModeX, ExtendMode extendModeY, out T0* transform) where T0 : unmanaged, IBorderTransform {
		fixed (T0** _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBorderTransform (ptr, extendModeX, extendModeY, (void**) _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateOffsetTransform<T0> (Vector2I offset, T0** transform) where T0 : unmanaged, IOffsetTransform {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateOffsetTransform (ptr, offset, (void**) transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateOffsetTransform<T0> (Vector2I offset, out T0* transform) where T0 : unmanaged, IOffsetTransform {
		fixed (T0** _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateOffsetTransform (ptr, offset, (void**) _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBoundsAdjustmentTransform<T0> (Vector4I* outputRectangle, T0** transform) where T0 : unmanaged, IBoundsAdjustmentTransform {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBoundsAdjustmentTransform (ptr, outputRectangle, (void**) transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBoundsAdjustmentTransform<T0> (Vector4I* outputRectangle, out T0* transform) where T0 : unmanaged, IBoundsAdjustmentTransform {
		fixed (T0** _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBoundsAdjustmentTransform (ptr, outputRectangle, (void**) _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadPixelShader (Guid shaderId, byte* shaderBuffer, uint shaderBufferCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LoadPixelShader (ptr, shaderId, shaderBuffer, shaderBufferCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadVertexShader (Guid resourceId, byte* shaderBuffer, uint shaderBufferCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LoadVertexShader (ptr, resourceId, shaderBuffer, shaderBufferCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadComputeShader (Guid resourceId, byte* shaderBuffer, uint shaderBufferCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LoadComputeShader (ptr, resourceId, shaderBuffer, shaderBufferCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsShaderLoaded (Guid shaderId) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsShaderLoaded (ptr, shaderId) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateResourceTexture<T0> (Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, T0** resourceTexture) where T0 : unmanaged, IResourceTexture {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateResourceTexture (ptr, resourceId, resourceTextureProperties, data, strides, dataSize, (void**) resourceTexture);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateResourceTexture<T0> (Guid* resourceId, ResourceTextureProperties* resourceTextureProperties, byte* data, uint* strides, uint dataSize, out T0* resourceTexture) where T0 : unmanaged, IResourceTexture {
		fixed (T0** _resourceTexture = &resourceTexture) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateResourceTexture (ptr, resourceId, resourceTextureProperties, data, strides, dataSize, (void**) _resourceTexture);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindResourceTexture<T0> (Guid* resourceId, T0** resourceTexture) where T0 : unmanaged, IResourceTexture {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindResourceTexture (ptr, resourceId, (void**) resourceTexture);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindResourceTexture<T0> (Guid* resourceId, out T0* resourceTexture) where T0 : unmanaged, IResourceTexture {
		fixed (T0** _resourceTexture = &resourceTexture) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindResourceTexture (ptr, resourceId, (void**) _resourceTexture);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVertexBuffer<T0> (VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, T0** buffer) where T0 : unmanaged, IVertexBuffer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVertexBuffer (ptr, vertexBufferProperties, resourceId, customVertexBufferProperties, (void**) buffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVertexBuffer<T0> (VertexBufferProperties* vertexBufferProperties, Guid* resourceId, CustomVertexBufferProperties* customVertexBufferProperties, out T0* buffer) where T0 : unmanaged, IVertexBuffer {
		fixed (T0** _buffer = &buffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVertexBuffer (ptr, vertexBufferProperties, resourceId, customVertexBufferProperties, (void**) _buffer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindVertexBuffer<T0> (Guid* resourceId, T0** buffer) where T0 : unmanaged, IVertexBuffer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindVertexBuffer (ptr, resourceId, (void**) buffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindVertexBuffer<T0> (Guid* resourceId, out T0* buffer) where T0 : unmanaged, IVertexBuffer {
		fixed (T0** _buffer = &buffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindVertexBuffer (ptr, resourceId, (void**) _buffer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContext<T0> (ColorSpace space, byte* profile, uint profileSize, T0** colorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContext (ptr, space, profile, profileSize, (void**) colorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContext<T0> (ColorSpace space, byte* profile, uint profileSize, out T0* colorContext) where T0 : unmanaged, IColorContext {
		fixed (T0** _colorContext = &colorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContext (ptr, space, profile, profileSize, (void**) _colorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromFilename<T0> (char* filename, T0** colorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromFilename (ptr, filename, (void**) colorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromFilename<T0> (char* filename, out T0* colorContext) where T0 : unmanaged, IColorContext {
		fixed (T0** _colorContext = &colorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromFilename (ptr, filename, (void**) _colorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromWicColorContext<T0, T1> (T0* wicColorContext, T1** colorContext) where T0 : unmanaged, WIC.IColorContext where T1 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromWicColorContext (ptr, wicColorContext, (void**) colorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromWicColorContext<T0, T1> (T0* wicColorContext, out T1* colorContext) where T0 : unmanaged, WIC.IColorContext where T1 : unmanaged, IColorContext {
		fixed (T1** _colorContext = &colorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromWicColorContext (ptr, wicColorContext, (void**) _colorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckFeatureSupport (Feature feature, void* featureSupportData, uint featureSupportDataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckFeatureSupport (ptr, feature, featureSupportData, featureSupportDataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsBufferPrecisionSupported (BufferPrecision bufferPrecision) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsBufferPrecisionSupported (ptr, bufferPrecision) != 0;
		return hr;
	}

	[StructLayout (LayoutKind.Sequential)]
	readonly struct FunctionPointer {
		/// <summary>
		/// OFFSET 0
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> QueryInterface;
		/// <summary>
		/// OFFSET 1
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> AddRef;
		/// <summary>
		/// OFFSET 2
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> Release;
		/// <summary>
		/// OFFSET 3
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, float*, void> GetDpi;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> CreateEffect;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Direct3D.FeatureLevel*, uint, Direct3D.FeatureLevel*, int> GetMaximumSupportedFeatureLevel;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateTransformNodeFromEffect;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, BlendDescription*, void**, int> CreateBlendTransform;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode, ExtendMode, void**, int> CreateBorderTransform;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2I, void**, int> CreateOffsetTransform;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, void**, int> CreateBoundsAdjustmentTransform;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, byte*, uint, int> LoadPixelShader;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, byte*, uint, int> LoadVertexShader;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, byte*, uint, int> LoadComputeShader;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint> IsShaderLoaded;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, ResourceTextureProperties*, byte*, uint*, uint, void**, int> CreateResourceTexture;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, void**, int> FindResourceTexture;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VertexBufferProperties*, Guid*, CustomVertexBufferProperties*, void**, int> CreateVertexBuffer;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, void**, int> FindVertexBuffer;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorSpace, byte*, uint, void**, int> CreateColorContext;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void**, int> CreateColorContextFromFilename;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateColorContextFromWicColorContext;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Feature, void*, uint, int> CheckFeatureSupport;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BufferPrecision, uint> IsBufferPrecisionSupported;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
