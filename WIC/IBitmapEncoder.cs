using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapEncoder</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapEncoder : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::Initialize (IStream* pIStream, WICBitmapEncoderCacheOption cacheOption)</b><br/>
	/// </summary>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="cacheOption"><b>WICBitmapEncoderCacheOption cacheOption</b></param>
	int Initialize<T0> (T0* pIStream, BitmapEncoderCacheOption cacheOption) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (Guid* pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (out Guid pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::GetEncoderInfo (IWICBitmapEncoderInfo** ppIEncoderInfo)</b><br/>
	/// </summary>
	/// <param name="ppIEncoderInfo">__RPC__deref_out_opt <b>IWICBitmapEncoderInfo** ppIEncoderInfo</b></param>
	int GetEncoderInfo<T0> (T0** ppIEncoderInfo) where T0 : unmanaged, IBitmapEncoderInfo;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::GetEncoderInfo (IWICBitmapEncoderInfo** ppIEncoderInfo)</b><br/>
	/// </summary>
	/// <param name="ppIEncoderInfo">__RPC__deref_out_opt <b>IWICBitmapEncoderInfo** ppIEncoderInfo</b></param>
	int GetEncoderInfo<T0> (out T0* ppIEncoderInfo) where T0 : unmanaged, IBitmapEncoderInfo;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::SetColorContexts (UINT cCount, IWICColorContext** ppIColorContext)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIColorContext">__RPC__in_ecount_full(cCount) <b>IWICColorContext** ppIColorContext</b></param>
	int SetColorContexts<T0> (uint cCount, T0** ppIColorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::SetPalette (IWICPalette* pIPalette)</b><br/>
	/// </summary>
	/// <param name="pIPalette">__RPC__in_opt <b>IWICPalette* pIPalette</b></param>
	int SetPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::SetThumbnail (IWICBitmapSource* pIThumbnail)</b><br/>
	/// </summary>
	/// <param name="pIThumbnail">__RPC__in_opt <b>IWICBitmapSource* pIThumbnail</b></param>
	int SetThumbnail<T0> (T0* pIThumbnail) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::SetPreview (IWICBitmapSource* pIPreview)</b><br/>
	/// </summary>
	/// <param name="pIPreview">__RPC__in_opt <b>IWICBitmapSource* pIPreview</b></param>
	int SetPreview<T0> (T0* pIPreview) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::CreateNewFrame (IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions)</b><br/>
	/// </summary>
	/// <param name="ppIFrameEncode">__RPC__deref_out_opt <b>IWICBitmapFrameEncode** ppIFrameEncode</b></param>
	/// <param name="ppIEncoderOptions">__RPC__deref_opt_inout_opt <b>IPropertyBag2** ppIEncoderOptions</b></param>
	[Obsolete ("'IPropertyBag2' not supported", true)]
	int CreateNewFrame<T0> (T0** ppIFrameEncode, void** ppIEncoderOptions) where T0 : unmanaged, IBitmapFrameEncode;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::CreateNewFrame (IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions)</b><br/>
	/// </summary>
	/// <param name="ppIFrameEncode">__RPC__deref_out_opt <b>IWICBitmapFrameEncode** ppIFrameEncode</b></param>
	/// <param name="ppIEncoderOptions">__RPC__deref_opt_inout_opt <b>IPropertyBag2** ppIEncoderOptions</b></param>
	[Obsolete ("'IPropertyBag2' not supported", true)]
	int CreateNewFrame<T0> (out T0* ppIFrameEncode, out void* ppIEncoderOptions) where T0 : unmanaged, IBitmapFrameEncode;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::Commit ()</b><br/>
	/// </summary>
	int Commit ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::GetMetadataQueryWriter (IWICMetadataQueryWriter** ppIMetadataQueryWriter)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIMetadataQueryWriter</b></param>
	int GetMetadataQueryWriter<T0> (T0** ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapEncoder::GetMetadataQueryWriter (IWICMetadataQueryWriter** ppIMetadataQueryWriter)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIMetadataQueryWriter</b></param>
	int GetMetadataQueryWriter<T0> (out T0* ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter;
}

/// <summary>
/// Instance of <b>IWICBitmapEncoder</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapEncoder : IBitmapEncoder {
//unsafe public readonly struct IBitmapEncoderObj : IBitmapEncoder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapEncoder* GetCurrentPointer () => (BitmapEncoder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapEncoderObj* GetCurrentPointer () => (IBitmapEncoderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000103, 0xa8f2, 0x4877, 0xba, 0x0a, 0xfd, 0x2b, 0x66, 0x45, 0xfb, 0x94);

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
	public readonly int Initialize<T0> (T0* pIStream, BitmapEncoderCacheOption cacheOption) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Initialize (ptr, pIStream, cacheOption);
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
	public readonly int GetEncoderInfo<T0> (T0** ppIEncoderInfo) where T0 : unmanaged, IBitmapEncoderInfo {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEncoderInfo (ptr, (void**) ppIEncoderInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEncoderInfo<T0> (out T0* ppIEncoderInfo) where T0 : unmanaged, IBitmapEncoderInfo {
		fixed (T0** _ppIEncoderInfo = &ppIEncoderInfo) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEncoderInfo (ptr, (void**) _ppIEncoderInfo);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetColorContexts<T0> (uint cCount, T0** ppIColorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetColorContexts (ptr, cCount, (void**) ppIColorContext);
		return hr;
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
	public readonly int SetThumbnail<T0> (T0* pIThumbnail) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetThumbnail (ptr, pIThumbnail);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPreview<T0> (T0* pIPreview) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPreview (ptr, pIPreview);
		return hr;
	}

	/// <inheritdoc />
	[Obsolete ("'IPropertyBag2' not supported", true)]
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateNewFrame<T0> (T0** ppIFrameEncode, void** ppIEncoderOptions) where T0 : unmanaged, IBitmapFrameEncode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateNewFrame (ptr, (void**) ppIFrameEncode, ppIEncoderOptions);
		return hr;
	}

	/// <inheritdoc />
	[Obsolete ("'IPropertyBag2' not supported", true)]
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateNewFrame<T0> (out T0* ppIFrameEncode, out void* ppIEncoderOptions) where T0 : unmanaged, IBitmapFrameEncode {
		fixed (T0** _ppIFrameEncode = &ppIFrameEncode) {
			fixed (void** _ppIEncoderOptions = &ppIEncoderOptions) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->CreateNewFrame (ptr, (void**) _ppIFrameEncode, _ppIEncoderOptions);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Commit () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Commit (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataQueryWriter<T0> (T0** ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryWriter (ptr, (void**) ppIMetadataQueryWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataQueryWriter<T0> (out T0* ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter {
		fixed (T0** _ppIMetadataQueryWriter = &ppIMetadataQueryWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryWriter (ptr, (void**) _ppIMetadataQueryWriter);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, BitmapEncoderCacheOption, int> Initialize;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetContainerFormat;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetEncoderInfo;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> SetColorContexts;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetPalette;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetThumbnail;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetPreview;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		[Obsolete ("'IPropertyBag2' not supported", true)]
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void**, int> CreateNewFrame;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Commit;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetMetadataQueryWriter;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
