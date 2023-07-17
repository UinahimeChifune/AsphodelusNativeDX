using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICPlanarFormatConverter</b> : IWICBitmapSource<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IPlanarFormatConverter : IBitmapSource {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarFormatConverter::Initialize (IWICBitmapSource** ppPlanes, UINT cPlanes, REFWICPixelFormatGUID dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)</b><br/>
	/// </summary>
	/// <param name="ppPlanes">__RPC__in_ecount_full(cPlanes) <b>IWICBitmapSource** ppPlanes</b></param>
	/// <param name="cPlanes"><b>UINT cPlanes</b></param>
	/// <param name="dstFormat">__RPC__in <b>REFWICPixelFormatGUID dstFormat</b></param>
	/// <param name="dither"><b>WICBitmapDitherType dither</b></param>
	/// <param name="pIPalette">__RPC__in_opt <b>IWICPalette* pIPalette</b></param>
	/// <param name="alphaThresholdPercent"><b>double alphaThresholdPercent</b></param>
	/// <param name="paletteTranslate"><b>WICBitmapPaletteType paletteTranslate</b></param>
	int Initialize<T0, T1> (T0** ppPlanes, uint cPlanes, Guid dstFormat, BitmapDitherType dither, T1* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IPalette;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarFormatConverter::CanConvert (WICPixelFormatGUID* pSrcPixelFormats, UINT cSrcPlanes, REFWICPixelFormatGUID dstPixelFormat, BOOL* pfCanConvert)</b><br/>
	/// </summary>
	/// <param name="pSrcPixelFormats">__RPC__in_ecount_full(cSrcPlanes) <b>WICPixelFormatGUID* pSrcPixelFormats</b></param>
	/// <param name="cSrcPlanes"><b>UINT cSrcPlanes</b></param>
	/// <param name="dstPixelFormat">__RPC__in <b>REFWICPixelFormatGUID dstPixelFormat</b></param>
	/// <param name="pfCanConvert">__RPC__out <b>BOOL* pfCanConvert</b></param>
	int CanConvert (Guid* pSrcPixelFormats, uint cSrcPlanes, Guid dstPixelFormat, uint* pfCanConvert);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarFormatConverter::CanConvert (WICPixelFormatGUID* pSrcPixelFormats, UINT cSrcPlanes, REFWICPixelFormatGUID dstPixelFormat, BOOL* pfCanConvert)</b><br/>
	/// </summary>
	/// <param name="pSrcPixelFormats">__RPC__in_ecount_full(cSrcPlanes) <b>WICPixelFormatGUID* pSrcPixelFormats</b></param>
	/// <param name="cSrcPlanes"><b>UINT cSrcPlanes</b></param>
	/// <param name="dstPixelFormat">__RPC__in <b>REFWICPixelFormatGUID dstPixelFormat</b></param>
	/// <param name="pfCanConvert">__RPC__out <b>BOOL* pfCanConvert</b></param>
	int CanConvert (Guid* pSrcPixelFormats, uint cSrcPlanes, Guid dstPixelFormat, out bool pfCanConvert);
}

/// <summary>
/// Instance of <b>IWICPlanarFormatConverter</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct PlanarFormatConverter : IPlanarFormatConverter {
//unsafe public readonly struct IPlanarFormatConverterObj : IPlanarFormatConverter {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PlanarFormatConverter* GetCurrentPointer () => (PlanarFormatConverter*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPlanarFormatConverterObj* GetCurrentPointer () => (IPlanarFormatConverterObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xbebee9cb, 0x83b0, 0x4dcc, 0x81, 0x32, 0xb0, 0xaa, 0xa5, 0x5e, 0xac, 0x96);

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
	public readonly int Initialize<T0, T1> (T0** ppPlanes, uint cPlanes, Guid dstFormat, BitmapDitherType dither, T1* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IPalette {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Initialize (ptr, (void**) ppPlanes, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CanConvert (Guid* pSrcPixelFormats, uint cSrcPlanes, Guid dstPixelFormat, uint* pfCanConvert) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CanConvert (ptr, pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvert);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CanConvert (Guid* pSrcPixelFormats, uint cSrcPlanes, Guid dstPixelFormat, out bool pfCanConvert) {
		uint _pfCanConvert;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CanConvert (ptr, pSrcPixelFormats, cSrcPlanes, dstPixelFormat, &_pfCanConvert);
		pfCanConvert = _pfCanConvert != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint, Guid, BitmapDitherType, void*, double, BitmapPaletteType, int> Initialize;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, uint, Guid, uint*, int> CanConvert;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
