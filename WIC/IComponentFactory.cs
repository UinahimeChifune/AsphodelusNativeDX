using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICComponentFactory</b> : IWICImagingFactory<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IComponentFactory : IImagingFactory {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataReader (REFGUID guidMetadataFormat, GUID* pguidVendor, DWORD dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)</b><br/>
	/// </summary>
	/// <param name="guidMetadataFormat">__RPC__in <b>REFGUID guidMetadataFormat</b></param>
	/// <param name="pguidVendor">__RPC__in_ecount_full_opt(1) <b>GUID* pguidVendor</b></param>
	/// <param name="dwOptions"><b>DWORD dwOptions</b></param>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="ppIReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIReader</b></param>
	int CreateMetadataReader<T0, T1> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, T1** ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataReader (REFGUID guidMetadataFormat, GUID* pguidVendor, DWORD dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)</b><br/>
	/// </summary>
	/// <param name="guidMetadataFormat">__RPC__in <b>REFGUID guidMetadataFormat</b></param>
	/// <param name="pguidVendor">__RPC__in_ecount_full_opt(1) <b>GUID* pguidVendor</b></param>
	/// <param name="dwOptions"><b>DWORD dwOptions</b></param>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="ppIReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIReader</b></param>
	int CreateMetadataReader<T0, T1> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, out T1* ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataReaderFromContainer (REFGUID guidContainerFormat, GUID* pguidVendor, DWORD dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)</b><br/>
	/// </summary>
	/// <param name="guidContainerFormat">__RPC__in <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pguidVendor">__RPC__in_ecount_full_opt(1) <b>GUID* pguidVendor</b></param>
	/// <param name="dwOptions"><b>DWORD dwOptions</b></param>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="ppIReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIReader</b></param>
	int CreateMetadataReaderFromContainer<T0, T1> (Guid guidContainerFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, T1** ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataReaderFromContainer (REFGUID guidContainerFormat, GUID* pguidVendor, DWORD dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)</b><br/>
	/// </summary>
	/// <param name="guidContainerFormat">__RPC__in <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pguidVendor">__RPC__in_ecount_full_opt(1) <b>GUID* pguidVendor</b></param>
	/// <param name="dwOptions"><b>DWORD dwOptions</b></param>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="ppIReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIReader</b></param>
	int CreateMetadataReaderFromContainer<T0, T1> (Guid guidContainerFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, out T1* ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataWriter (REFGUID guidMetadataFormat, GUID* pguidVendor, DWORD dwMetadataOptions, IWICMetadataWriter** ppIWriter)</b><br/>
	/// </summary>
	/// <param name="guidMetadataFormat">__RPC__in <b>REFGUID guidMetadataFormat</b></param>
	/// <param name="pguidVendor">__RPC__in_ecount_full_opt(1) <b>GUID* pguidVendor</b></param>
	/// <param name="dwMetadataOptions"><b>DWORD dwMetadataOptions</b></param>
	/// <param name="ppIWriter">__RPC__deref_out_opt <b>IWICMetadataWriter** ppIWriter</b></param>
	int CreateMetadataWriter<T0> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwMetadataOptions, T0** ppIWriter) where T0 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataWriter (REFGUID guidMetadataFormat, GUID* pguidVendor, DWORD dwMetadataOptions, IWICMetadataWriter** ppIWriter)</b><br/>
	/// </summary>
	/// <param name="guidMetadataFormat">__RPC__in <b>REFGUID guidMetadataFormat</b></param>
	/// <param name="pguidVendor">__RPC__in_ecount_full_opt(1) <b>GUID* pguidVendor</b></param>
	/// <param name="dwMetadataOptions"><b>DWORD dwMetadataOptions</b></param>
	/// <param name="ppIWriter">__RPC__deref_out_opt <b>IWICMetadataWriter** ppIWriter</b></param>
	int CreateMetadataWriter<T0> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwMetadataOptions, out T0* ppIWriter) where T0 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataWriterFromReader (IWICMetadataReader* pIReader, GUID* pguidVendor, IWICMetadataWriter** ppIWriter)</b><br/>
	/// </summary>
	/// <param name="pIReader">__RPC__in_opt <b>IWICMetadataReader* pIReader</b></param>
	/// <param name="pguidVendor">__RPC__in_opt <b>GUID* pguidVendor</b></param>
	/// <param name="ppIWriter">__RPC__deref_out_opt <b>IWICMetadataWriter** ppIWriter</b></param>
	int CreateMetadataWriterFromReader<T0, T1> (T0* pIReader, Guid* pguidVendor, T1** ppIWriter) where T0 : unmanaged, IMetadataReader where T1 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateMetadataWriterFromReader (IWICMetadataReader* pIReader, GUID* pguidVendor, IWICMetadataWriter** ppIWriter)</b><br/>
	/// </summary>
	/// <param name="pIReader">__RPC__in_opt <b>IWICMetadataReader* pIReader</b></param>
	/// <param name="pguidVendor">__RPC__in_opt <b>GUID* pguidVendor</b></param>
	/// <param name="ppIWriter">__RPC__deref_out_opt <b>IWICMetadataWriter** ppIWriter</b></param>
	int CreateMetadataWriterFromReader<T0, T1> (T0* pIReader, Guid* pguidVendor, out T1* ppIWriter) where T0 : unmanaged, IMetadataReader where T1 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateQueryReaderFromBlockReader (IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader)</b><br/>
	/// </summary>
	/// <param name="pIBlockReader">__RPC__in_opt <b>IWICMetadataBlockReader* pIBlockReader</b></param>
	/// <param name="ppIQueryReader">__RPC__deref_out_opt <b>IWICMetadataQueryReader** ppIQueryReader</b></param>
	int CreateQueryReaderFromBlockReader<T0, T1> (T0* pIBlockReader, T1** ppIQueryReader) where T0 : unmanaged, IMetadataBlockReader where T1 : unmanaged, IMetadataQueryReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateQueryReaderFromBlockReader (IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader)</b><br/>
	/// </summary>
	/// <param name="pIBlockReader">__RPC__in_opt <b>IWICMetadataBlockReader* pIBlockReader</b></param>
	/// <param name="ppIQueryReader">__RPC__deref_out_opt <b>IWICMetadataQueryReader** ppIQueryReader</b></param>
	int CreateQueryReaderFromBlockReader<T0, T1> (T0* pIBlockReader, out T1* ppIQueryReader) where T0 : unmanaged, IMetadataBlockReader where T1 : unmanaged, IMetadataQueryReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateQueryWriterFromBlockWriter (IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter)</b><br/>
	/// </summary>
	/// <param name="pIBlockWriter">__RPC__in_opt <b>IWICMetadataBlockWriter* pIBlockWriter</b></param>
	/// <param name="ppIQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIQueryWriter</b></param>
	int CreateQueryWriterFromBlockWriter<T0, T1> (T0* pIBlockWriter, T1** ppIQueryWriter) where T0 : unmanaged, IMetadataBlockWriter where T1 : unmanaged, IMetadataQueryWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateQueryWriterFromBlockWriter (IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter)</b><br/>
	/// </summary>
	/// <param name="pIBlockWriter">__RPC__in_opt <b>IWICMetadataBlockWriter* pIBlockWriter</b></param>
	/// <param name="ppIQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIQueryWriter</b></param>
	int CreateQueryWriterFromBlockWriter<T0, T1> (T0* pIBlockWriter, out T1* ppIQueryWriter) where T0 : unmanaged, IMetadataBlockWriter where T1 : unmanaged, IMetadataQueryWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateEncoderPropertyBag (PROPBAG2* ppropOptions, UINT cCount, IPropertyBag2** ppIPropertyBag)</b><br/>
	/// </summary>
	/// <param name="ppropOptions">__RPC__in_ecount_full_opt(cCount) <b>PROPBAG2* ppropOptions</b></param>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIPropertyBag">__RPC__deref_out_opt <b>IPropertyBag2** ppIPropertyBag</b></param>
	[Obsolete ("'PROPBAG2', 'IPropertyBag2' not supported", true)]
	int CreateEncoderPropertyBag (void* ppropOptions, uint cCount, void** ppIPropertyBag);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentFactory::CreateEncoderPropertyBag (PROPBAG2* ppropOptions, UINT cCount, IPropertyBag2** ppIPropertyBag)</b><br/>
	/// </summary>
	/// <param name="ppropOptions">__RPC__in_ecount_full_opt(cCount) <b>PROPBAG2* ppropOptions</b></param>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="ppIPropertyBag">__RPC__deref_out_opt <b>IPropertyBag2** ppIPropertyBag</b></param>
	[Obsolete ("'PROPBAG2', 'IPropertyBag2' not supported", true)]
	int CreateEncoderPropertyBag (void* ppropOptions, uint cCount, out void* ppIPropertyBag);
}

/// <summary>
/// Instance of <b>IWICComponentFactory</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct ComponentFactory : IComponentFactory {
//unsafe public readonly struct IComponentFactoryObj : IComponentFactory {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ComponentFactory* GetCurrentPointer () => (ComponentFactory*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IComponentFactoryObj* GetCurrentPointer () => (IComponentFactoryObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid CLSID { get => WIC.CLSID._imagingFactory; }

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x412d0c3a, 0x9650, 0x44fa, 0xaf, 0x5b, 0xdd, 0x2a, 0x06, 0xc8, 0xe8, 0xfb);

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
	public readonly int CreateDecoderFromFilename<T0> (char* wzFilename, Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, T0** ppIDecoder) where T0 : unmanaged, IBitmapDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoderFromFilename (ptr, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (void**) ppIDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecoderFromFilename<T0> (char* wzFilename, Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, out T0* ppIDecoder) where T0 : unmanaged, IBitmapDecoder {
		fixed (T0** _ppIDecoder = &ppIDecoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoderFromFilename (ptr, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (void**) _ppIDecoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecoderFromStream<T0, T1> (T0* pIStream, Guid* pguidVendor, DecodeOptions metadataOptions, T1** ppIDecoder) where T0 : unmanaged, IStream where T1 : unmanaged, IBitmapDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoderFromStream (ptr, pIStream, pguidVendor, metadataOptions, (void**) ppIDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecoderFromStream<T0, T1> (T0* pIStream, Guid* pguidVendor, DecodeOptions metadataOptions, out T1* ppIDecoder) where T0 : unmanaged, IStream where T1 : unmanaged, IBitmapDecoder {
		fixed (T1** _ppIDecoder = &ppIDecoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoderFromStream (ptr, pIStream, pguidVendor, metadataOptions, (void**) _ppIDecoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecoderFromFileHandle<T0> (UIntPtr hFile, Guid* pguidVendor, DecodeOptions metadataOptions, T0** ppIDecoder) where T0 : unmanaged, IBitmapDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoderFromFileHandle (ptr, hFile, pguidVendor, metadataOptions, (void**) ppIDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecoderFromFileHandle<T0> (UIntPtr hFile, Guid* pguidVendor, DecodeOptions metadataOptions, out T0* ppIDecoder) where T0 : unmanaged, IBitmapDecoder {
		fixed (T0** _ppIDecoder = &ppIDecoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoderFromFileHandle (ptr, hFile, pguidVendor, metadataOptions, (void**) _ppIDecoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComponentInfo<T0> (Guid clsidComponent, T0** ppIInfo) where T0 : unmanaged, IComponentInfo {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateComponentInfo (ptr, clsidComponent, (void**) ppIInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComponentInfo<T0> (Guid clsidComponent, out T0* ppIInfo) where T0 : unmanaged, IComponentInfo {
		fixed (T0** _ppIInfo = &ppIInfo) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateComponentInfo (ptr, clsidComponent, (void**) _ppIInfo);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecoder<T0> (Guid guidContainerFormat, Guid* pguidVendor, T0** ppIDecoder) where T0 : unmanaged, IBitmapDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoder (ptr, guidContainerFormat, pguidVendor, (void**) ppIDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecoder<T0> (Guid guidContainerFormat, Guid* pguidVendor, out T0* ppIDecoder) where T0 : unmanaged, IBitmapDecoder {
		fixed (T0** _ppIDecoder = &ppIDecoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecoder (ptr, guidContainerFormat, pguidVendor, (void**) _ppIDecoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEncoder<T0> (Guid guidContainerFormat, Guid* pguidVendor, T0** ppIEncoder) where T0 : unmanaged, IBitmapEncoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateEncoder (ptr, guidContainerFormat, pguidVendor, (void**) ppIEncoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEncoder<T0> (Guid guidContainerFormat, Guid* pguidVendor, out T0* ppIEncoder) where T0 : unmanaged, IBitmapEncoder {
		fixed (T0** _ppIEncoder = &ppIEncoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateEncoder (ptr, guidContainerFormat, pguidVendor, (void**) _ppIEncoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePalette<T0> (T0** ppIPalette) where T0 : unmanaged, IPalette {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePalette (ptr, (void**) ppIPalette);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePalette<T0> (out T0* ppIPalette) where T0 : unmanaged, IPalette {
		fixed (T0** _ppIPalette = &ppIPalette) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePalette (ptr, (void**) _ppIPalette);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFormatConverter<T0> (T0** ppIFormatConverter) where T0 : unmanaged, IFormatConverter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFormatConverter (ptr, (void**) ppIFormatConverter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFormatConverter<T0> (out T0* ppIFormatConverter) where T0 : unmanaged, IFormatConverter {
		fixed (T0** _ppIFormatConverter = &ppIFormatConverter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFormatConverter (ptr, (void**) _ppIFormatConverter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapScaler<T0> (T0** ppIBitmapScaler) where T0 : unmanaged, IBitmapScaler {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapScaler (ptr, (void**) ppIBitmapScaler);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapScaler<T0> (out T0* ppIBitmapScaler) where T0 : unmanaged, IBitmapScaler {
		fixed (T0** _ppIBitmapScaler = &ppIBitmapScaler) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapScaler (ptr, (void**) _ppIBitmapScaler);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapClipper<T0> (T0** ppIBitmapClipper) where T0 : unmanaged, IBitmapClipper {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapClipper (ptr, (void**) ppIBitmapClipper);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapClipper<T0> (out T0* ppIBitmapClipper) where T0 : unmanaged, IBitmapClipper {
		fixed (T0** _ppIBitmapClipper = &ppIBitmapClipper) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapClipper (ptr, (void**) _ppIBitmapClipper);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFlipRotator<T0> (T0** ppIBitmapFlipRotator) where T0 : unmanaged, IBitmapFlipRotator {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFlipRotator (ptr, (void**) ppIBitmapFlipRotator);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFlipRotator<T0> (out T0* ppIBitmapFlipRotator) where T0 : unmanaged, IBitmapFlipRotator {
		fixed (T0** _ppIBitmapFlipRotator = &ppIBitmapFlipRotator) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFlipRotator (ptr, (void**) _ppIBitmapFlipRotator);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStream<T0> (T0** ppIWICStream) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateStream (ptr, (void**) ppIWICStream);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStream<T0> (out T0* ppIWICStream) where T0 : unmanaged, IStream {
		fixed (T0** _ppIWICStream = &ppIWICStream) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateStream (ptr, (void**) _ppIWICStream);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContext<T0> (T0** ppIWICColorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContext (ptr, (void**) ppIWICColorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContext<T0> (out T0* ppIWICColorContext) where T0 : unmanaged, IColorContext {
		fixed (T0** _ppIWICColorContext = &ppIWICColorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContext (ptr, (void**) _ppIWICColorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorTransformer<T0> (T0** ppIWICColorTransform) where T0 : unmanaged, IColorTransform {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorTransformer (ptr, (void**) ppIWICColorTransform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorTransformer<T0> (out T0* ppIWICColorTransform) where T0 : unmanaged, IColorTransform {
		fixed (T0** _ppIWICColorTransform = &ppIWICColorTransform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorTransformer (ptr, (void**) _ppIWICColorTransform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmap<T0> (uint uiWidth, uint uiHeight, Guid pixelFormat, BitmapCreateCacheOption option, T0** ppIBitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap (ptr, uiWidth, uiHeight, pixelFormat, option, (void**) ppIBitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmap<T0> (uint uiWidth, uint uiHeight, Guid pixelFormat, BitmapCreateCacheOption option, out T0* ppIBitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _ppIBitmap = &ppIBitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap (ptr, uiWidth, uiHeight, pixelFormat, option, (void**) _ppIBitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromSource<T0, T1> (T0* pIBitmapSource, BitmapCreateCacheOption option, T1** ppIBitmap) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromSource (ptr, pIBitmapSource, option, (void**) ppIBitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromSource<T0, T1> (T0* pIBitmapSource, BitmapCreateCacheOption option, out T1* ppIBitmap) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IBitmap {
		fixed (T1** _ppIBitmap = &ppIBitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromSource (ptr, pIBitmapSource, option, (void**) _ppIBitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromSourceRect<T0, T1> (T0* pIBitmapSource, uint x, uint y, uint width, uint height, T1** ppIBitmap) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromSourceRect (ptr, pIBitmapSource, x, y, width, height, (void**) ppIBitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromSourceRect<T0, T1> (T0* pIBitmapSource, uint x, uint y, uint width, uint height, out T1* ppIBitmap) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IBitmap {
		fixed (T1** _ppIBitmap = &ppIBitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromSourceRect (ptr, pIBitmapSource, x, y, width, height, (void**) _ppIBitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromMemory<T0> (uint uiWidth, uint uiHeight, Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, T0** ppIBitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromMemory (ptr, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (void**) ppIBitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromMemory<T0> (uint uiWidth, uint uiHeight, Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, out T0* ppIBitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _ppIBitmap = &ppIBitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromMemory (ptr, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (void**) _ppIBitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromHBITMAP<T0> (IntPtr hBitmap, IntPtr hPalette, BitmapAlphaChannelOption options, T0** ppIBitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromHBITMAP (ptr, hBitmap, hPalette, options, (void**) ppIBitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromHBITMAP<T0> (IntPtr hBitmap, IntPtr hPalette, BitmapAlphaChannelOption options, out T0* ppIBitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _ppIBitmap = &ppIBitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromHBITMAP (ptr, hBitmap, hPalette, options, (void**) _ppIBitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromHICON<T0> (IntPtr hIcon, T0** ppIBitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromHICON (ptr, hIcon, (void**) ppIBitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromHICON<T0> (IntPtr hIcon, out T0* ppIBitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _ppIBitmap = &ppIBitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromHICON (ptr, hIcon, (void**) _ppIBitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComponentEnumerator<T0> (uint componentTypes, uint options, T0** ppIEnumUnknown) where T0 : unmanaged, IEnumUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateComponentEnumerator (ptr, componentTypes, options, (void**) ppIEnumUnknown);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComponentEnumerator<T0> (uint componentTypes, uint options, out T0* ppIEnumUnknown) where T0 : unmanaged, IEnumUnknown {
		fixed (T0** _ppIEnumUnknown = &ppIEnumUnknown) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateComponentEnumerator (ptr, componentTypes, options, (void**) _ppIEnumUnknown);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFastMetadataEncoderFromDecoder<T0, T1> (T0* pIDecoder, T1** ppIFastEncoder) where T0 : unmanaged, IBitmapDecoder where T1 : unmanaged, IFastMetadataEncoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFastMetadataEncoderFromDecoder (ptr, pIDecoder, (void**) ppIFastEncoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFastMetadataEncoderFromDecoder<T0, T1> (T0* pIDecoder, out T1* ppIFastEncoder) where T0 : unmanaged, IBitmapDecoder where T1 : unmanaged, IFastMetadataEncoder {
		fixed (T1** _ppIFastEncoder = &ppIFastEncoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFastMetadataEncoderFromDecoder (ptr, pIDecoder, (void**) _ppIFastEncoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFastMetadataEncoderFromFrameDecode<T0, T1> (T0* pIFrameDecoder, T1** ppIFastEncoder) where T0 : unmanaged, IBitmapFrameDecode where T1 : unmanaged, IFastMetadataEncoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFastMetadataEncoderFromFrameDecode (ptr, pIFrameDecoder, (void**) ppIFastEncoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFastMetadataEncoderFromFrameDecode<T0, T1> (T0* pIFrameDecoder, out T1* ppIFastEncoder) where T0 : unmanaged, IBitmapFrameDecode where T1 : unmanaged, IFastMetadataEncoder {
		fixed (T1** _ppIFastEncoder = &ppIFastEncoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFastMetadataEncoderFromFrameDecode (ptr, pIFrameDecoder, (void**) _ppIFastEncoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryWriter<T0> (Guid guidMetadataFormat, Guid* pguidVendor, T0** ppIQueryWriter) where T0 : unmanaged, IMetadataQueryWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryWriter (ptr, guidMetadataFormat, pguidVendor, (void**) ppIQueryWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryWriter<T0> (Guid guidMetadataFormat, Guid* pguidVendor, out T0* ppIQueryWriter) where T0 : unmanaged, IMetadataQueryWriter {
		fixed (T0** _ppIQueryWriter = &ppIQueryWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryWriter (ptr, guidMetadataFormat, pguidVendor, (void**) _ppIQueryWriter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryWriterFromReader<T0, T1> (T0* pIQueryReader, Guid* pguidVendor, T1** ppIQueryWriter) where T0 : unmanaged, IMetadataQueryReader where T1 : unmanaged, IMetadataQueryWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryWriterFromReader (ptr, pIQueryReader, pguidVendor, (void**) ppIQueryWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryWriterFromReader<T0, T1> (T0* pIQueryReader, Guid* pguidVendor, out T1* ppIQueryWriter) where T0 : unmanaged, IMetadataQueryReader where T1 : unmanaged, IMetadataQueryWriter {
		fixed (T1** _ppIQueryWriter = &ppIQueryWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryWriterFromReader (ptr, pIQueryReader, pguidVendor, (void**) _ppIQueryWriter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataReader<T0, T1> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, T1** ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataReader (ptr, guidMetadataFormat, pguidVendor, dwOptions, pIStream, (void**) ppIReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataReader<T0, T1> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, out T1* ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader {
		fixed (T1** _ppIReader = &ppIReader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataReader (ptr, guidMetadataFormat, pguidVendor, dwOptions, pIStream, (void**) _ppIReader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataReaderFromContainer<T0, T1> (Guid guidContainerFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, T1** ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataReaderFromContainer (ptr, guidContainerFormat, pguidVendor, dwOptions, pIStream, (void**) ppIReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataReaderFromContainer<T0, T1> (Guid guidContainerFormat, Guid* pguidVendor, uint dwOptions, T0* pIStream, out T1* ppIReader) where T0 : unmanaged, IStream where T1 : unmanaged, IMetadataReader {
		fixed (T1** _ppIReader = &ppIReader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataReaderFromContainer (ptr, guidContainerFormat, pguidVendor, dwOptions, pIStream, (void**) _ppIReader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataWriter<T0> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwMetadataOptions, T0** ppIWriter) where T0 : unmanaged, IMetadataWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataWriter (ptr, guidMetadataFormat, pguidVendor, dwMetadataOptions, (void**) ppIWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataWriter<T0> (Guid guidMetadataFormat, Guid* pguidVendor, uint dwMetadataOptions, out T0* ppIWriter) where T0 : unmanaged, IMetadataWriter {
		fixed (T0** _ppIWriter = &ppIWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataWriter (ptr, guidMetadataFormat, pguidVendor, dwMetadataOptions, (void**) _ppIWriter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataWriterFromReader<T0, T1> (T0* pIReader, Guid* pguidVendor, T1** ppIWriter) where T0 : unmanaged, IMetadataReader where T1 : unmanaged, IMetadataWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataWriterFromReader (ptr, pIReader, pguidVendor, (void**) ppIWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMetadataWriterFromReader<T0, T1> (T0* pIReader, Guid* pguidVendor, out T1* ppIWriter) where T0 : unmanaged, IMetadataReader where T1 : unmanaged, IMetadataWriter {
		fixed (T1** _ppIWriter = &ppIWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateMetadataWriterFromReader (ptr, pIReader, pguidVendor, (void**) _ppIWriter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryReaderFromBlockReader<T0, T1> (T0* pIBlockReader, T1** ppIQueryReader) where T0 : unmanaged, IMetadataBlockReader where T1 : unmanaged, IMetadataQueryReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryReaderFromBlockReader (ptr, pIBlockReader, (void**) ppIQueryReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryReaderFromBlockReader<T0, T1> (T0* pIBlockReader, out T1* ppIQueryReader) where T0 : unmanaged, IMetadataBlockReader where T1 : unmanaged, IMetadataQueryReader {
		fixed (T1** _ppIQueryReader = &ppIQueryReader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryReaderFromBlockReader (ptr, pIBlockReader, (void**) _ppIQueryReader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryWriterFromBlockWriter<T0, T1> (T0* pIBlockWriter, T1** ppIQueryWriter) where T0 : unmanaged, IMetadataBlockWriter where T1 : unmanaged, IMetadataQueryWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryWriterFromBlockWriter (ptr, pIBlockWriter, (void**) ppIQueryWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryWriterFromBlockWriter<T0, T1> (T0* pIBlockWriter, out T1* ppIQueryWriter) where T0 : unmanaged, IMetadataBlockWriter where T1 : unmanaged, IMetadataQueryWriter {
		fixed (T1** _ppIQueryWriter = &ppIQueryWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryWriterFromBlockWriter (ptr, pIBlockWriter, (void**) _ppIQueryWriter);
			return hr;
		}
	}

	/// <inheritdoc />
	[Obsolete ("'PROPBAG2', 'IPropertyBag2' not supported", true)]
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEncoderPropertyBag (void* ppropOptions, uint cCount, void** ppIPropertyBag) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateEncoderPropertyBag (ptr, ppropOptions, cCount, ppIPropertyBag);
		return hr;
	}

	/// <inheritdoc />
	[Obsolete ("'PROPBAG2', 'IPropertyBag2' not supported", true)]
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEncoderPropertyBag (void* ppropOptions, uint cCount, out void* ppIPropertyBag) {
		fixed (void** _ppIPropertyBag = &ppIPropertyBag) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateEncoderPropertyBag (ptr, ppropOptions, cCount, _ppIPropertyBag);
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
		public readonly delegate* unmanaged[Stdcall]<void*, char*, Guid*, uint, DecodeOptions, void**, int> CreateDecoderFromFilename;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Guid*, DecodeOptions, void**, int> CreateDecoderFromStream;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, UIntPtr, Guid*, DecodeOptions, void**, int> CreateDecoderFromFileHandle;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> CreateComponentInfo;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, Guid*, void**, int> CreateDecoder;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, Guid*, void**, int> CreateEncoder;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreatePalette;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFormatConverter;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateBitmapScaler;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateBitmapClipper;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateBitmapFlipRotator;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateStream;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateColorContext;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateColorTransformer;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, Guid, BitmapCreateCacheOption, void**, int> CreateBitmap;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, BitmapCreateCacheOption, void**, int> CreateBitmapFromSource;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint, uint, void**, int> CreateBitmapFromSourceRect;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, Guid, uint, uint, byte*, void**, int> CreateBitmapFromMemory;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, IntPtr, BitmapAlphaChannelOption, void**, int> CreateBitmapFromHBITMAP;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, void**, int> CreateBitmapFromHICON;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, int> CreateComponentEnumerator;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateFastMetadataEncoderFromDecoder;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateFastMetadataEncoderFromFrameDecode;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, Guid*, void**, int> CreateQueryWriter;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Guid*, void**, int> CreateQueryWriterFromReader;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, Guid*, uint, void*, void**, int> CreateMetadataReader;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, Guid*, uint, void*, void**, int> CreateMetadataReaderFromContainer;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, Guid*, uint, void**, int> CreateMetadataWriter;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Guid*, void**, int> CreateMetadataWriterFromReader;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateQueryReaderFromBlockReader;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateQueryWriterFromBlockWriter;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		[Obsolete ("'PROPBAG2', 'IPropertyBag2' not supported", true)]
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void**, int> CreateEncoderPropertyBag;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
