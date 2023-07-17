using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Bitmap</b> : ID2D1Image<br/>
/// D2D1.h
/// </summary>
unsafe public interface IBitmap : IImage {
	/// <summary>
	/// STDMETHOD_ <b>D2D1_SIZE_F ID2D1Bitmap::GetSize ()</b><br/>
	/// </summary>
	Vector2F GetSize ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_SIZE_U ID2D1Bitmap::GetPixelSize ()</b><br/>
	/// </summary>
	Vector2U GetPixelSize ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_PIXEL_FORMAT ID2D1Bitmap::GetPixelFormat ()</b><br/>
	/// </summary>
	PixelFormat GetPixelFormat ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Bitmap::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDpi (float* dpiX, float* dpiY);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Bitmap::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDpi (out float dpiX, out float dpiY);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap::CopyFromBitmap (D2D1_POINT_2U* destPoint, ID2D1Bitmap* bitmap, D2D1_RECT_U* srcRect)</b><br/>
	/// </summary>
	/// <param name="destPoint">_In_opt_ <b>D2D1_POINT_2U* destPoint</b></param>
	/// <param name="bitmap">_In_ <b>ID2D1Bitmap* bitmap</b></param>
	/// <param name="srcRect">_In_opt_ <b>D2D1_RECT_U* srcRect</b></param>
	int CopyFromBitmap<T0> (Vector2U* destPoint, T0* bitmap, Vector4U* srcRect) where T0 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap::CopyFromRenderTarget (D2D1_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, D2D1_RECT_U* srcRect)</b><br/>
	/// </summary>
	/// <param name="destPoint">_In_opt_ <b>D2D1_POINT_2U* destPoint</b></param>
	/// <param name="renderTarget">_In_ <b>ID2D1RenderTarget* renderTarget</b></param>
	/// <param name="srcRect">_In_opt_ <b>D2D1_RECT_U* srcRect</b></param>
	int CopyFromRenderTarget<T0> (Vector2U* destPoint, T0* renderTarget, Vector4U* srcRect) where T0 : unmanaged, IRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Bitmap::CopyFromMemory (D2D1_RECT_U* dstRect, void* srcData, UINT32 pitch)</b><br/>
	/// </summary>
	/// <param name="dstRect">_In_opt_ <b>D2D1_RECT_U* dstRect</b></param>
	/// <param name="srcData">_In_ <b>void* srcData</b></param>
	/// <param name="pitch"><b>UINT32 pitch</b></param>
	int CopyFromMemory (Vector4U* dstRect, void* srcData, uint pitch);
}

/// <summary>
/// Instance of <b>ID2D1Bitmap</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct Bitmap : IBitmap {
//unsafe public readonly struct IBitmapObj : IBitmap {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Bitmap* GetCurrentPointer () => (Bitmap*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapObj* GetCurrentPointer () => (IBitmapObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa2296057, 0xea42, 0x4099, 0x98, 0x3b, 0x53, 0x9f, 0xb6, 0x50, 0x54, 0x26);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
