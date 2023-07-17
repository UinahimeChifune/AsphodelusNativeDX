using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteGlyphRunAnalysis</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IGlyphRunAnalysis : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGlyphRunAnalysis::GetAlphaTextureBounds (DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds)</b><br/>
	/// </summary>
	/// <param name="textureType"><b>DWRITE_TEXTURE_TYPE textureType</b></param>
	/// <param name="textureBounds">_Out_ <b>RECT* textureBounds</b></param>
	int GetAlphaTextureBounds (TextureType textureType, Vector4I* textureBounds);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGlyphRunAnalysis::GetAlphaTextureBounds (DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds)</b><br/>
	/// </summary>
	/// <param name="textureType"><b>DWRITE_TEXTURE_TYPE textureType</b></param>
	/// <param name="textureBounds">_Out_ <b>RECT* textureBounds</b></param>
	int GetAlphaTextureBounds (TextureType textureType, out Vector4I textureBounds);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGlyphRunAnalysis::CreateAlphaTexture (DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds, BYTE* alphaValues, UINT32 bufferSize)</b><br/>
	/// </summary>
	/// <param name="textureType"><b>DWRITE_TEXTURE_TYPE textureType</b></param>
	/// <param name="textureBounds">_In_ <b>RECT* textureBounds</b></param>
	/// <param name="alphaValues">_Out_writes_bytes_(bufferSize) <b>BYTE* alphaValues</b></param>
	/// <param name="bufferSize"><b>UINT32 bufferSize</b></param>
	int CreateAlphaTexture (TextureType textureType, Vector4I* textureBounds, byte* alphaValues, uint bufferSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGlyphRunAnalysis::GetAlphaBlendParams (IDWriteRenderingParams* renderingParams, FLOAT* blendGamma, FLOAT* blendEnhancedContrast, FLOAT* blendClearTypeLevel)</b><br/>
	/// </summary>
	/// <param name="renderingParams">_In_ <b>IDWriteRenderingParams* renderingParams</b></param>
	/// <param name="blendGamma">_Out_ <b>FLOAT* blendGamma</b></param>
	/// <param name="blendEnhancedContrast">_Out_ <b>FLOAT* blendEnhancedContrast</b></param>
	/// <param name="blendClearTypeLevel">_Out_ <b>FLOAT* blendClearTypeLevel</b></param>
	int GetAlphaBlendParams<T0> (T0* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGlyphRunAnalysis::GetAlphaBlendParams (IDWriteRenderingParams* renderingParams, FLOAT* blendGamma, FLOAT* blendEnhancedContrast, FLOAT* blendClearTypeLevel)</b><br/>
	/// </summary>
	/// <param name="renderingParams">_In_ <b>IDWriteRenderingParams* renderingParams</b></param>
	/// <param name="blendGamma">_Out_ <b>FLOAT* blendGamma</b></param>
	/// <param name="blendEnhancedContrast">_Out_ <b>FLOAT* blendEnhancedContrast</b></param>
	/// <param name="blendClearTypeLevel">_Out_ <b>FLOAT* blendClearTypeLevel</b></param>
	int GetAlphaBlendParams<T0> (T0* renderingParams, out float blendGamma, out float blendEnhancedContrast, out float blendClearTypeLevel) where T0 : unmanaged, IRenderingParams;
}

/// <summary>
/// Instance of <b>IDWriteGlyphRunAnalysis</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct GlyphRunAnalysis : IGlyphRunAnalysis {
//unsafe public readonly struct IGlyphRunAnalysisObj : IGlyphRunAnalysis {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GlyphRunAnalysis* GetCurrentPointer () => (GlyphRunAnalysis*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGlyphRunAnalysisObj* GetCurrentPointer () => (IGlyphRunAnalysisObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x7d97dbf7, 0xe085, 0x42d4, 0x81, 0xe3, 0x6a, 0x88, 0x3b, 0xde, 0xd1, 0x18);

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
	public readonly int GetAlphaTextureBounds (TextureType textureType, Vector4I* textureBounds) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAlphaTextureBounds (ptr, textureType, textureBounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAlphaTextureBounds (TextureType textureType, out Vector4I textureBounds) {
		fixed (Vector4I* _textureBounds = &textureBounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAlphaTextureBounds (ptr, textureType, _textureBounds);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateAlphaTexture (TextureType textureType, Vector4I* textureBounds, byte* alphaValues, uint bufferSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateAlphaTexture (ptr, textureType, textureBounds, alphaValues, bufferSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAlphaBlendParams<T0> (T0* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAlphaBlendParams (ptr, renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAlphaBlendParams<T0> (T0* renderingParams, out float blendGamma, out float blendEnhancedContrast, out float blendClearTypeLevel) where T0 : unmanaged, IRenderingParams {
		fixed (float* _blendGamma = &blendGamma) {
			fixed (float* _blendEnhancedContrast = &blendEnhancedContrast) {
				fixed (float* _blendClearTypeLevel = &blendClearTypeLevel) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->GetAlphaBlendParams (ptr, renderingParams, _blendGamma, _blendEnhancedContrast, _blendClearTypeLevel);
					return hr;
				}
			}
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
		public readonly delegate* unmanaged[Stdcall]<void*, TextureType, Vector4I*, int> GetAlphaTextureBounds;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextureType, Vector4I*, byte*, uint, int> CreateAlphaTexture;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float*, float*, float*, int> GetAlphaBlendParams;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
