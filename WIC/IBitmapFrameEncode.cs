using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapFrameEncode</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapFrameEncode : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::Initialize (IPropertyBag2* pIEncoderOptions)</b><br/>
	/// </summary>
	/// <param name="pIEncoderOptions">__RPC__in_opt <b>IPropertyBag2* pIEncoderOptions</b></param>
	[Obsolete ("'IPropertyBag2' not supported", true)]
	int Initialize (void* pIEncoderOptions);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::SetSize (UINT uiWidth, UINT uiHeight)</b><br/>
	/// </summary>
	/// <param name="uiWidth"><b>UINT uiWidth</b></param>
	/// <param name="uiHeight"><b>UINT uiHeight</b></param>
	int SetSize (uint uiWidth, uint uiHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::SetResolution (double dpiX, double dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX"><b>double dpiX</b></param>
	/// <param name="dpiY"><b>double dpiY</b></param>
	int SetResolution (double dpiX, double dpiY);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::SetPixelFormat (WICPixelFormatGUID* pPixelFormat)</b><br/>
	/// </summary>
	/// <param name="pPixelFormat">__RPC__inout <b>WICPixelFormatGUID* pPixelFormat</b></param>
	int SetPixelFormat (Guid* pPixelFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::SetColorContexts (UINT cCount, IWICColorContext** ppIColorContext)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIColorContext">__RPC__in_ecount_full(cCount) <b>IWICColorContext** ppIColorContext</b></param>
	int SetColorContexts<T0> (uint cCount, T0** ppIColorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::SetPalette (IWICPalette* pIPalette)</b><br/>
	/// </summary>
	/// <param name="pIPalette">__RPC__in_opt <b>IWICPalette* pIPalette</b></param>
	int SetPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::SetThumbnail (IWICBitmapSource* pIThumbnail)</b><br/>
	/// </summary>
	/// <param name="pIThumbnail">__RPC__in_opt <b>IWICBitmapSource* pIThumbnail</b></param>
	int SetThumbnail<T0> (T0* pIThumbnail) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::WritePixels (UINT lineCount, UINT cbStride, UINT cbBufferSize, BYTE* pbPixels)</b><br/>
	/// </summary>
	/// <param name="lineCount"><b>UINT lineCount</b></param>
	/// <param name="cbStride"><b>UINT cbStride</b></param>
	/// <param name="cbBufferSize"><b>UINT cbBufferSize</b></param>
	/// <param name="pbPixels">__RPC__in_ecount_full(cbBufferSize) <b>BYTE* pbPixels</b></param>
	int WritePixels (uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::WriteSource (IWICBitmapSource* pIBitmapSource, WICRect* prc)</b><br/>
	/// </summary>
	/// <param name="pIBitmapSource">__RPC__in_opt <b>IWICBitmapSource* pIBitmapSource</b></param>
	/// <param name="prc">__RPC__in_opt <b>WICRect* prc</b></param>
	int WriteSource<T0> (T0* pIBitmapSource, Vector4I* prc) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::Commit ()</b><br/>
	/// </summary>
	int Commit ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::GetMetadataQueryWriter (IWICMetadataQueryWriter** ppIMetadataQueryWriter)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIMetadataQueryWriter</b></param>
	int GetMetadataQueryWriter<T0> (T0** ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapFrameEncode::GetMetadataQueryWriter (IWICMetadataQueryWriter** ppIMetadataQueryWriter)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIMetadataQueryWriter</b></param>
	int GetMetadataQueryWriter<T0> (out T0* ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter;
}

/// <summary>
/// Instance of <b>IWICBitmapFrameEncode</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapFrameEncode : IBitmapFrameEncode {
//unsafe public readonly struct IBitmapFrameEncodeObj : IBitmapFrameEncode {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapFrameEncode* GetCurrentPointer () => (BitmapFrameEncode*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapFrameEncodeObj* GetCurrentPointer () => (IBitmapFrameEncodeObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000105, 0xa8f2, 0x4877, 0xba, 0x0a, 0xfd, 0x2b, 0x66, 0x45, 0xfb, 0x94);

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
	[Obsolete ("'IPropertyBag2' not supported", true)]
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Initialize (void* pIEncoderOptions) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Initialize (ptr, pIEncoderOptions);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSize (uint uiWidth, uint uiHeight) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSize (ptr, uiWidth, uiHeight);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetResolution (double dpiX, double dpiY) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetResolution (ptr, dpiX, dpiY);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPixelFormat (Guid* pPixelFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPixelFormat (ptr, pPixelFormat);
		return hr;
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
	public readonly int WritePixels (uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WritePixels (ptr, lineCount, cbStride, cbBufferSize, pbPixels);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int WriteSource<T0> (T0* pIBitmapSource, Vector4I* prc) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WriteSource (ptr, pIBitmapSource, prc);
		return hr;
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
		[Obsolete ("'IPropertyBag2' not supported", true)]
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> Initialize;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, int> SetSize;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, double, int> SetResolution;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> SetPixelFormat;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> SetColorContexts;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetPalette;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetThumbnail;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, byte*, int> WritePixels;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4I*, int> WriteSource;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Commit;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetMetadataQueryWriter;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
