using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteBitmapRenderTarget1</b> : IDWriteBitmapRenderTarget<br/>
/// DWRITE_1.h
/// </summary>
unsafe public interface IBitmapRenderTarget1 : IBitmapRenderTarget {
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_TEXT_ANTIALIAS_MODE IDWriteBitmapRenderTarget1::GetTextAntialiasMode ()</b><br/>
	/// </summary>
	TextAntialiasMode GetTextAntialiasMode ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteBitmapRenderTarget1::SetTextAntialiasMode (DWRITE_TEXT_ANTIALIAS_MODE antialiasMode)</b><br/>
	/// </summary>
	/// <param name="antialiasMode"><b>DWRITE_TEXT_ANTIALIAS_MODE antialiasMode</b></param>
	int SetTextAntialiasMode (TextAntialiasMode antialiasMode);
}

/// <summary>
/// Instance of <b>IDWriteBitmapRenderTarget1</b><br/>
/// DWRITE_1.h
/// </summary>
unsafe public readonly struct BitmapRenderTarget1 : IBitmapRenderTarget1 {
//unsafe public readonly struct IBitmapRenderTarget1Obj : IBitmapRenderTarget1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapRenderTarget1* GetCurrentPointer () => (BitmapRenderTarget1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapRenderTarget1Obj* GetCurrentPointer () => (IBitmapRenderTarget1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x791e8298, 0x3ef3, 0x4230, 0x98, 0x80, 0xc9, 0xbd, 0xec, 0xc4, 0x20, 0x64);

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
	public readonly int DrawGlyphRun<T0> (float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, GlyphRun* glyphRun, T0* renderingParams, uint textColor, Vector4I* nULL) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGlyphRun (ptr, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, nULL);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGlyphRun<T0> (float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, GlyphRun* glyphRun, T0* renderingParams, uint textColor, out Vector4I nULL) where T0 : unmanaged, IRenderingParams {
		fixed (Vector4I* _nULL = &nULL) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->DrawGlyphRun (ptr, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, _nULL);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly IntPtr GetMemoryDC () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMemoryDC (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetPixelsPerDip () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelsPerDip (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPixelsPerDip (float pixelsPerDip) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPixelsPerDip (ptr, pixelsPerDip);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentTransform (ptr, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentTransform (out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentTransform (ptr, _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetCurrentTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetCurrentTransform (ptr, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSize (Vector2I* size) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, size);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSize (out Vector2I size) {
		fixed (Vector2I* _size = &size) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, _size);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Resize (uint width, uint height) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Resize (ptr, width, height);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly TextAntialiasMode GetTextAntialiasMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextAntialiasMode (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTextAntialiasMode (TextAntialiasMode antialiasMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTextAntialiasMode (ptr, antialiasMode);
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
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, MeasuringMode, GlyphRun*, void*, uint, Vector4I*, int> DrawGlyphRun;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr> GetMemoryDC;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetPixelsPerDip;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, int> SetPixelsPerDip;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, int> GetCurrentTransform;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, int> SetCurrentTransform;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2I*, int> GetSize;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, int> Resize;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextAntialiasMode> GetTextAntialiasMode;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextAntialiasMode, int> SetTextAntialiasMode;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
