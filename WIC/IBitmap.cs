using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmap</b> : IWICBitmapSource<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmap : IBitmapSource {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmap::Lock (WICRect* prcLock, DWORD flags, IWICBitmapLock** ppILock)</b><br/>
	/// </summary>
	/// <param name="prcLock">__RPC__in_opt <b>WICRect* prcLock</b></param>
	/// <param name="flags"><b>DWORD flags</b></param>
	/// <param name="ppILock">__RPC__deref_out_opt <b>IWICBitmapLock** ppILock</b></param>
	int Lock<T0> (Vector4I* prcLock, uint flags, T0** ppILock) where T0 : unmanaged, IBitmapLock;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmap::Lock (WICRect* prcLock, DWORD flags, IWICBitmapLock** ppILock)</b><br/>
	/// </summary>
	/// <param name="prcLock">__RPC__in_opt <b>WICRect* prcLock</b></param>
	/// <param name="flags"><b>DWORD flags</b></param>
	/// <param name="ppILock">__RPC__deref_out_opt <b>IWICBitmapLock** ppILock</b></param>
	int Lock<T0> (Vector4I* prcLock, uint flags, out T0* ppILock) where T0 : unmanaged, IBitmapLock;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmap::SetPalette (IWICPalette* pIPalette)</b><br/>
	/// </summary>
	/// <param name="pIPalette">__RPC__in_opt <b>IWICPalette* pIPalette</b></param>
	int SetPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmap::SetResolution (double dpiX, double dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX"><b>double dpiX</b></param>
	/// <param name="dpiY"><b>double dpiY</b></param>
	int SetResolution (double dpiX, double dpiY);
}

/// <summary>
/// Instance of <b>IWICBitmap</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct Bitmap : IBitmap {
//unsafe public readonly struct IBitmapObj : IBitmap {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Bitmap* GetCurrentPointer () => (Bitmap*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapObj* GetCurrentPointer () => (IBitmapObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000121, 0xa8f2, 0x4877, 0xba, 0x0a, 0xfd, 0x2b, 0x66, 0x45, 0xfb, 0x94);

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
	public readonly int GetSize (uint* puiWidth, uint* puiHeight) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, puiWidth, puiHeight);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSize (out uint puiWidth, out uint puiHeight) {
		fixed (uint* _puiWidth = &puiWidth) {
			fixed (uint* _puiHeight = &puiHeight) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, _puiWidth, _puiHeight);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormat (Guid* pPixelFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr, pPixelFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormat (out Guid pPixelFormat) {
		fixed (Guid* _pPixelFormat = &pPixelFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr, _pPixelFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetResolution (double* pDpiX, double* pDpiY) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetResolution (ptr, pDpiX, pDpiY);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetResolution (out double pDpiX, out double pDpiY) {
		fixed (double* _pDpiX = &pDpiX) {
			fixed (double* _pDpiY = &pDpiY) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetResolution (ptr, _pDpiX, _pDpiY);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPalette (ptr, pIPalette);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, cbStride, cbBufferSize, pbBuffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prc, uint cbStride, uint cbBufferSize, out byte pbBuffer) {
		fixed (byte* _pbBuffer = &pbBuffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, cbStride, cbBufferSize, _pbBuffer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Lock<T0> (Vector4I* prcLock, uint flags, T0** ppILock) where T0 : unmanaged, IBitmapLock {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Lock (ptr, prcLock, flags, (void**) ppILock);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Lock<T0> (Vector4I* prcLock, uint flags, out T0* ppILock) where T0 : unmanaged, IBitmapLock {
		fixed (T0** _ppILock = &ppILock) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Lock (ptr, prcLock, flags, (void**) _ppILock);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPalette (ptr, pIPalette);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetResolution (double dpiX, double dpiY) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetResolution (ptr, dpiX, dpiY);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, int> GetSize;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetPixelFormat;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, double*, int> GetResolution;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> CopyPalette;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint, uint, byte*, int> CopyPixels;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint, void**, int> Lock;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetPalette;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, double, int> SetResolution;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
