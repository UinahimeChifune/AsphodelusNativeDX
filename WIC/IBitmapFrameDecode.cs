using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapFrameDecode</b> : IWICBitmapSource<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapFrameDecode : IBitmapSource {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameDecode::GetMetadataQueryReader (IWICMetadataQueryReader** ppIMetadataQueryReader)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryReader">__RPC__deref_out_opt <b>IWICMetadataQueryReader** ppIMetadataQueryReader</b></param>
	int GetMetadataQueryReader<T0> (T0** ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameDecode::GetMetadataQueryReader (IWICMetadataQueryReader** ppIMetadataQueryReader)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryReader">__RPC__deref_out_opt <b>IWICMetadataQueryReader** ppIMetadataQueryReader</b></param>
	int GetMetadataQueryReader<T0> (out T0* ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameDecode::GetColorContexts (UINT cCount, IWICColorContext** ppIColorContexts, UINT* pcActualCount)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIColorContexts">__RPC__inout_ecount_full_opt(cCount) <b>IWICColorContext** ppIColorContexts</b></param>
	/// <param name="pcActualCount">__RPC__out <b>UINT* pcActualCount</b></param>
	int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, uint* pcActualCount) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameDecode::GetColorContexts (UINT cCount, IWICColorContext** ppIColorContexts, UINT* pcActualCount)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIColorContexts">__RPC__inout_ecount_full_opt(cCount) <b>IWICColorContext** ppIColorContexts</b></param>
	/// <param name="pcActualCount">__RPC__out <b>UINT* pcActualCount</b></param>
	int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, out uint pcActualCount) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameDecode::GetThumbnail (IWICBitmapSource** ppIThumbnail)</b><br/>
	/// </summary>
	/// <param name="ppIThumbnail">__RPC__deref_out_opt <b>IWICBitmapSource** ppIThumbnail</b></param>
	int GetThumbnail<T0> (T0** ppIThumbnail) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameDecode::GetThumbnail (IWICBitmapSource** ppIThumbnail)</b><br/>
	/// </summary>
	/// <param name="ppIThumbnail">__RPC__deref_out_opt <b>IWICBitmapSource** ppIThumbnail</b></param>
	int GetThumbnail<T0> (out T0* ppIThumbnail) where T0 : unmanaged, IBitmapSource;
}

/// <summary>
/// Instance of <b>IWICBitmapFrameDecode</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapFrameDecode : IBitmapFrameDecode {
//unsafe public readonly struct IBitmapFrameDecodeObj : IBitmapFrameDecode {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapFrameDecode* GetCurrentPointer () => (BitmapFrameDecode*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapFrameDecodeObj* GetCurrentPointer () => (IBitmapFrameDecodeObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3b16811b, 0x6a43, 0x4ec9, 0xa8, 0x13, 0x3d, 0x93, 0x0c, 0x13, 0xb9, 0x40);

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
	public readonly int GetMetadataQueryReader<T0> (T0** ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryReader (ptr, (void**) ppIMetadataQueryReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataQueryReader<T0> (out T0* ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader {
		fixed (T0** _ppIMetadataQueryReader = &ppIMetadataQueryReader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryReader (ptr, (void**) _ppIMetadataQueryReader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, uint* pcActualCount) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorContexts (ptr, cCount, (void**) ppIColorContexts, pcActualCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, out uint pcActualCount) where T0 : unmanaged, IColorContext {
		fixed (uint* _pcActualCount = &pcActualCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetColorContexts (ptr, cCount, (void**) ppIColorContexts, _pcActualCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetThumbnail<T0> (T0** ppIThumbnail) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetThumbnail (ptr, (void**) ppIThumbnail);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetThumbnail<T0> (out T0* ppIThumbnail) where T0 : unmanaged, IBitmapSource {
		fixed (T0** _ppIThumbnail = &ppIThumbnail) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetThumbnail (ptr, (void**) _ppIThumbnail);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetMetadataQueryReader;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, uint*, int> GetColorContexts;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetThumbnail;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
