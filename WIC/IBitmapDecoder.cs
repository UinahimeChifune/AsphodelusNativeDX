using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapDecoder</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapDecoder : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::QueryCapability (IStream* pIStream, DWORD* pdwCapability)</b><br/>
	/// </summary>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="pdwCapability">__RPC__out <b>DWORD* pdwCapability</b></param>
	int QueryCapability<T0> (T0* pIStream, uint* pdwCapability) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::QueryCapability (IStream* pIStream, DWORD* pdwCapability)</b><br/>
	/// </summary>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="pdwCapability">__RPC__out <b>DWORD* pdwCapability</b></param>
	int QueryCapability<T0> (T0* pIStream, out uint pdwCapability) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::Initialize (IStream* pIStream, WICDecodeOptions cacheOptions)</b><br/>
	/// </summary>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="cacheOptions"><b>WICDecodeOptions cacheOptions</b></param>
	int Initialize<T0> (T0* pIStream, DecodeOptions cacheOptions) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (Guid* pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (out Guid pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetDecoderInfo (IWICBitmapDecoderInfo** ppIDecoderInfo)</b><br/>
	/// </summary>
	/// <param name="ppIDecoderInfo">__RPC__deref_out_opt <b>IWICBitmapDecoderInfo** ppIDecoderInfo</b></param>
	int GetDecoderInfo<T0> (T0** ppIDecoderInfo) where T0 : unmanaged, IBitmapDecoderInfo;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetDecoderInfo (IWICBitmapDecoderInfo** ppIDecoderInfo)</b><br/>
	/// </summary>
	/// <param name="ppIDecoderInfo">__RPC__deref_out_opt <b>IWICBitmapDecoderInfo** ppIDecoderInfo</b></param>
	int GetDecoderInfo<T0> (out T0* ppIDecoderInfo) where T0 : unmanaged, IBitmapDecoderInfo;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::CopyPalette (IWICPalette* pIPalette)</b><br/>
	/// </summary>
	/// <param name="pIPalette">__RPC__in_opt <b>IWICPalette* pIPalette</b></param>
	int CopyPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetMetadataQueryReader (IWICMetadataQueryReader** ppIMetadataQueryReader)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryReader">__RPC__deref_out_opt <b>IWICMetadataQueryReader** ppIMetadataQueryReader</b></param>
	int GetMetadataQueryReader<T0> (T0** ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetMetadataQueryReader (IWICMetadataQueryReader** ppIMetadataQueryReader)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryReader">__RPC__deref_out_opt <b>IWICMetadataQueryReader** ppIMetadataQueryReader</b></param>
	int GetMetadataQueryReader<T0> (out T0* ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetPreview (IWICBitmapSource** ppIBitmapSource)</b><br/>
	/// </summary>
	/// <param name="ppIBitmapSource">__RPC__deref_out_opt <b>IWICBitmapSource** ppIBitmapSource</b></param>
	int GetPreview<T0> (T0** ppIBitmapSource) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetPreview (IWICBitmapSource** ppIBitmapSource)</b><br/>
	/// </summary>
	/// <param name="ppIBitmapSource">__RPC__deref_out_opt <b>IWICBitmapSource** ppIBitmapSource</b></param>
	int GetPreview<T0> (out T0* ppIBitmapSource) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetColorContexts (UINT cCount, IWICColorContext** ppIColorContexts, UINT* pcActualCount)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIColorContexts">__RPC__inout_ecount_full_opt(cCount) <b>IWICColorContext** ppIColorContexts</b></param>
	/// <param name="pcActualCount">__RPC__out <b>UINT* pcActualCount</b></param>
	int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, uint* pcActualCount) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetColorContexts (UINT cCount, IWICColorContext** ppIColorContexts, UINT* pcActualCount)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIColorContexts">__RPC__inout_ecount_full_opt(cCount) <b>IWICColorContext** ppIColorContexts</b></param>
	/// <param name="pcActualCount">__RPC__out <b>UINT* pcActualCount</b></param>
	int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, out uint pcActualCount) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetThumbnail (IWICBitmapSource** ppIThumbnail)</b><br/>
	/// </summary>
	/// <param name="ppIThumbnail">__RPC__deref_out_opt <b>IWICBitmapSource** ppIThumbnail</b></param>
	int GetThumbnail<T0> (T0** ppIThumbnail) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetThumbnail (IWICBitmapSource** ppIThumbnail)</b><br/>
	/// </summary>
	/// <param name="ppIThumbnail">__RPC__deref_out_opt <b>IWICBitmapSource** ppIThumbnail</b></param>
	int GetThumbnail<T0> (out T0* ppIThumbnail) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetFrameCount (UINT* pCount)</b><br/>
	/// </summary>
	/// <param name="pCount">__RPC__out <b>UINT* pCount</b></param>
	int GetFrameCount (uint* pCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetFrameCount (UINT* pCount)</b><br/>
	/// </summary>
	/// <param name="pCount">__RPC__out <b>UINT* pCount</b></param>
	int GetFrameCount (out uint pCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetFrame (UINT index, IWICBitmapFrameDecode** ppIBitmapFrame)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT index</b></param>
	/// <param name="ppIBitmapFrame">__RPC__deref_out_opt <b>IWICBitmapFrameDecode** ppIBitmapFrame</b></param>
	int GetFrame<T0> (uint index, T0** ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapDecoder::GetFrame (UINT index, IWICBitmapFrameDecode** ppIBitmapFrame)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT index</b></param>
	/// <param name="ppIBitmapFrame">__RPC__deref_out_opt <b>IWICBitmapFrameDecode** ppIBitmapFrame</b></param>
	int GetFrame<T0> (uint index, out T0* ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode;
}

/// <summary>
/// Instance of <b>IWICBitmapDecoder</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapDecoder : IBitmapDecoder {
//unsafe public readonly struct IBitmapDecoderObj : IBitmapDecoder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapDecoder* GetCurrentPointer () => (BitmapDecoder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapDecoderObj* GetCurrentPointer () => (IBitmapDecoderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9edde9e7, 0x8dee, 0x47ea, 0x99, 0xdf, 0xe6, 0xfa, 0xf2, 0xed, 0x44, 0xbf);

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
	public readonly int QueryCapability<T0> (T0* pIStream, uint* pdwCapability) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryCapability (ptr, pIStream, pdwCapability);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryCapability<T0> (T0* pIStream, out uint pdwCapability) where T0 : unmanaged, IStream {
		fixed (uint* _pdwCapability = &pdwCapability) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->QueryCapability (ptr, pIStream, _pdwCapability);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Initialize<T0> (T0* pIStream, DecodeOptions cacheOptions) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Initialize (ptr, pIStream, cacheOptions);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContainerFormat (Guid* pguidContainerFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetContainerFormat (ptr, pguidContainerFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContainerFormat (out Guid pguidContainerFormat) {
		fixed (Guid* _pguidContainerFormat = &pguidContainerFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetContainerFormat (ptr, _pguidContainerFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDecoderInfo<T0> (T0** ppIDecoderInfo) where T0 : unmanaged, IBitmapDecoderInfo {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDecoderInfo (ptr, (void**) ppIDecoderInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDecoderInfo<T0> (out T0* ppIDecoderInfo) where T0 : unmanaged, IBitmapDecoderInfo {
		fixed (T0** _ppIDecoderInfo = &ppIDecoderInfo) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDecoderInfo (ptr, (void**) _ppIDecoderInfo);
			return hr;
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
	public readonly int GetPreview<T0> (T0** ppIBitmapSource) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPreview (ptr, (void**) ppIBitmapSource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPreview<T0> (out T0* ppIBitmapSource) where T0 : unmanaged, IBitmapSource {
		fixed (T0** _ppIBitmapSource = &ppIBitmapSource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPreview (ptr, (void**) _ppIBitmapSource);
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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameCount (uint* pCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameCount (ptr, pCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameCount (out uint pCount) {
		fixed (uint* _pCount = &pCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameCount (ptr, _pCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrame<T0> (uint index, T0** ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrame (ptr, index, (void**) ppIBitmapFrame);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrame<T0> (uint index, out T0* ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode {
		fixed (T0** _ppIBitmapFrame = &ppIBitmapFrame) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrame (ptr, index, (void**) _ppIBitmapFrame);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, int> QueryCapability;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DecodeOptions, int> Initialize;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetContainerFormat;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetDecoderInfo;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> CopyPalette;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetMetadataQueryReader;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetPreview;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, uint*, int> GetColorContexts;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetThumbnail;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetFrameCount;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFrame;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
