using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Bitmap1</b> : ID2D1Bitmap<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IBitmap1 : IBitmap {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Bitmap1::GetColorContext (ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="colorContext">_Outptr_result_maybenull_ <b>ID2D1ColorContext** colorContext</b></param>
	void GetColorContext<T0> (T0** colorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Bitmap1::GetColorContext (ID2D1ColorContext** colorContext)</b><br/>
	/// </summary>
	/// <param name="colorContext">_Outptr_result_maybenull_ <b>ID2D1ColorContext** colorContext</b></param>
	void GetColorContext<T0> (out T0* colorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHOD_ <b>D2D1_BITMAP_OPTIONS ID2D1Bitmap1::GetOptions ()</b><br/>
	/// </summary>
	BitmapOptions GetOptions ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap1::GetSurface (IDXGISurface** dxgiSurface)</b><br/>
	/// </summary>
	/// <param name="dxgiSurface">_COM_Outptr_result_maybenull_ <b>IDXGISurface** dxgiSurface</b></param>
	int GetSurface<T0> (T0** dxgiSurface) where T0 : unmanaged, DXGI.ISurface;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap1::GetSurface (IDXGISurface** dxgiSurface)</b><br/>
	/// </summary>
	/// <param name="dxgiSurface">_COM_Outptr_result_maybenull_ <b>IDXGISurface** dxgiSurface</b></param>
	int GetSurface<T0> (out T0* dxgiSurface) where T0 : unmanaged, DXGI.ISurface;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap1::Map (D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT* mappedRect)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_MAP_OPTIONS options</b></param>
	/// <param name="mappedRect">_Out_ <b>D2D1_MAPPED_RECT* mappedRect</b></param>
	int Map (MapOptions options, MappedRect* mappedRect);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap1::Map (D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT* mappedRect)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_MAP_OPTIONS options</b></param>
	/// <param name="mappedRect">_Out_ <b>D2D1_MAPPED_RECT* mappedRect</b></param>
	int Map (MapOptions options, out MappedRect mappedRect);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap1::Unmap ()</b><br/>
	/// </summary>
	int Unmap ();
}

/// <summary>
/// Instance of <b>ID2D1Bitmap1</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct Bitmap1 : IBitmap1 {
//unsafe public readonly struct IBitmap1Obj : IBitmap1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Bitmap1* GetCurrentPointer () => (Bitmap1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmap1Obj* GetCurrentPointer () => (IBitmap1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa898a84c, 0x3873, 0x4588, 0xb0, 0x8b, 0xeb, 0xbf, 0x97, 0x8d, 0xf0, 0x41);

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
	public readonly void GetFactory<T0> (T0** factory) where T0 : unmanaged, IFactory {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) factory);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFactory<T0> (out T0* factory) where T0 : unmanaged, IFactory {
		fixed (T0** _factory = &factory) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) _factory);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2F GetSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2U GetPixelSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly PixelFormat GetPixelFormat () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr);
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
	public readonly int CopyFromBitmap<T0> (Vector2U* destPoint, T0* bitmap, Vector4U* srcRect) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyFromBitmap (ptr, destPoint, bitmap, srcRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyFromRenderTarget<T0> (Vector2U* destPoint, T0* renderTarget, Vector4U* srcRect) where T0 : unmanaged, IRenderTarget {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyFromRenderTarget (ptr, destPoint, renderTarget, srcRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyFromMemory (Vector4U* dstRect, void* srcData, uint pitch) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyFromMemory (ptr, dstRect, srcData, pitch);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetColorContext<T0> (T0** colorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetColorContext (ptr, (void**) colorContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetColorContext<T0> (out T0* colorContext) where T0 : unmanaged, IColorContext {
		fixed (T0** _colorContext = &colorContext) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetColorContext (ptr, (void**) _colorContext);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly BitmapOptions GetOptions () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetOptions (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSurface<T0> (T0** dxgiSurface) where T0 : unmanaged, DXGI.ISurface {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSurface (ptr, (void**) dxgiSurface);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSurface<T0> (out T0* dxgiSurface) where T0 : unmanaged, DXGI.ISurface {
		fixed (T0** _dxgiSurface = &dxgiSurface) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSurface (ptr, (void**) _dxgiSurface);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Map (MapOptions options, MappedRect* mappedRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, options, mappedRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Map (MapOptions options, out MappedRect mappedRect) {
		fixed (MappedRect* _mappedRect = &mappedRect) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, options, _mappedRect);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Unmap () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Unmap (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFactory;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F> GetSize;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2U> GetPixelSize;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PixelFormat> GetPixelFormat;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, float*, void> GetDpi;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2U*, void*, Vector4U*, int> CopyFromBitmap;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2U*, void*, Vector4U*, int> CopyFromRenderTarget;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4U*, void*, uint, int> CopyFromMemory;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetColorContext;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BitmapOptions> GetOptions;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetSurface;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MapOptions, MappedRect*, int> Map;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Unmap;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
