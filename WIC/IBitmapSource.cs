using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapSource</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapSource : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::GetSize (UINT* puiWidth, UINT* puiHeight)</b><br/>
	/// </summary>
	/// <param name="puiWidth">__RPC__out <b>UINT* puiWidth</b></param>
	/// <param name="puiHeight">__RPC__out <b>UINT* puiHeight</b></param>
	int GetSize (uint* puiWidth, uint* puiHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::GetSize (UINT* puiWidth, UINT* puiHeight)</b><br/>
	/// </summary>
	/// <param name="puiWidth">__RPC__out <b>UINT* puiWidth</b></param>
	/// <param name="puiHeight">__RPC__out <b>UINT* puiHeight</b></param>
	int GetSize (out uint puiWidth, out uint puiHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::GetPixelFormat (WICPixelFormatGUID* pPixelFormat)</b><br/>
	/// </summary>
	/// <param name="pPixelFormat">__RPC__out <b>WICPixelFormatGUID* pPixelFormat</b></param>
	int GetPixelFormat (Guid* pPixelFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::GetPixelFormat (WICPixelFormatGUID* pPixelFormat)</b><br/>
	/// </summary>
	/// <param name="pPixelFormat">__RPC__out <b>WICPixelFormatGUID* pPixelFormat</b></param>
	int GetPixelFormat (out Guid pPixelFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::GetResolution (double* pDpiX, double* pDpiY)</b><br/>
	/// </summary>
	/// <param name="pDpiX">__RPC__out <b>double* pDpiX</b></param>
	/// <param name="pDpiY">__RPC__out <b>double* pDpiY</b></param>
	int GetResolution (double* pDpiX, double* pDpiY);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::GetResolution (double* pDpiX, double* pDpiY)</b><br/>
	/// </summary>
	/// <param name="pDpiX">__RPC__out <b>double* pDpiX</b></param>
	/// <param name="pDpiY">__RPC__out <b>double* pDpiY</b></param>
	int GetResolution (out double pDpiX, out double pDpiY);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::CopyPalette (IWICPalette* pIPalette)</b><br/>
	/// </summary>
	/// <param name="pIPalette">__RPC__in_opt <b>IWICPalette* pIPalette</b></param>
	int CopyPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSource::CopyPixels (WICRect* prc, UINT cbStride, UINT cbBufferSize, BYTE* pbBuffer)</b><br/>
	/// </summary>
	/// <param name="prc">__RPC__in_opt <b>WICRect* prc</b></param>
	/// <param name="cbStride"><b>UINT cbStride</b></param>
	/// <param name="cbBufferSize"><b>UINT cbBufferSize</b></param>
	/// <param name="pbBuffer">__RPC__out_ecount_full(cbBufferSize) <b>BYTE* pbBuffer</b></param>
	int CopyPixels (Vector4I* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer);
}

/// <summary>
/// Instance of <b>IWICBitmapSource</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapSource : IBitmapSource {
//unsafe public readonly struct IBitmapSourceObj : IBitmapSource {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapSource* GetCurrentPointer () => (BitmapSource*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapSourceObj* GetCurrentPointer () => (IBitmapSourceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000120, 0xa8f2, 0x4877, 0xba, 0x0a, 0xfd, 0x2b, 0x66, 0x45, 0xfb, 0x94);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
