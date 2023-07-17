using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1EffectContext1</b> : ID2D1EffectContext<br/>
/// D2D1EFFECTAUTHOR_1.h
/// </summary>
unsafe public interface IEffectContext1 : IEffectContext {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext1::CreateLookupTable3D (D2D1_BUFFER_PRECISION precision, UINT32* extents, BYTE* data, UINT32 dataCount, UINT32* strides, ID2D1LookupTable3D** lookupTable)</b><br/>
	/// </summary>
	/// <param name="precision"><b>D2D1_BUFFER_PRECISION precision</b></param>
	/// <param name="extents">_In_reads_(3) <b>UINT32* extents</b></param>
	/// <param name="data">_In_reads_(dataCount) <b>BYTE* data</b></param>
	/// <param name="dataCount"><b>UINT32 dataCount</b></param>
	/// <param name="strides">_In_reads_(2) <b>UINT32* strides</b></param>
	/// <param name="lookupTable">_COM_Outptr_ <b>ID2D1LookupTable3D** lookupTable</b></param>
	int CreateLookupTable3D<T0> (BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, T0** lookupTable) where T0 : unmanaged, ILookupTable3D;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectContext1::CreateLookupTable3D (D2D1_BUFFER_PRECISION precision, UINT32* extents, BYTE* data, UINT32 dataCount, UINT32* strides, ID2D1LookupTable3D** lookupTable)</b><br/>
	/// </summary>
	/// <param name="precision"><b>D2D1_BUFFER_PRECISION precision</b></param>
	/// <param name="extents">_In_reads_(3) <b>UINT32* extents</b></param>
	/// <param name="data">_In_reads_(dataCount) <b>BYTE* data</b></param>
	/// <param name="dataCount"><b>UINT32 dataCount</b></param>
	/// <param name="strides">_In_reads_(2) <b>UINT32* strides</b></param>
	/// <param name="lookupTable">_COM_Outptr_ <b>ID2D1LookupTable3D** lookupTable</b></param>
	int CreateLookupTable3D<T0> (BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, out T0* lookupTable) where T0 : unmanaged, ILookupTable3D;
}

/// <summary>
/// Instance of <b>ID2D1EffectContext1</b><br/>
/// D2D1EFFECTAUTHOR_1.h
/// </summary>
unsafe public readonly struct EffectContext1 : IEffectContext1 {
//unsafe public readonly struct IEffectContext1Obj : IEffectContext1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly EffectContext1* GetCurrentPointer () => (EffectContext1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IEffectContext1Obj* GetCurrentPointer () => (IEffectContext1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x84ab595a, 0xfc81, 0x4546, 0xba, 0xcd, 0xe8, 0xef, 0x4d, 0x8a, 0xbe, 0x7a);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateLookupTable3D<T0> (BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, T0** lookupTable) where T0 : unmanaged, ILookupTable3D {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateLookupTable3D (ptr, precision, extents, data, dataCount, strides, (void**) lookupTable);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateLookupTable3D<T0> (BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, out T0* lookupTable) where T0 : unmanaged, ILookupTable3D {
		fixed (T0** _lookupTable = &lookupTable) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateLookupTable3D (ptr, precision, extents, data, dataCount, strides, (void**) _lookupTable);
			return hr;
		}
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
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BufferPrecision, uint*, byte*, uint, uint*, void**, int> CreateLookupTable3D;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
