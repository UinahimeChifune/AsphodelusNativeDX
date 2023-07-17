using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoDevice</b> : IUnknown<br/>
/// D3D11.h
/// </summary>
unsafe public interface IVideoDevice : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoDecoder (D3D11_VIDEO_DECODER_DESC* pVideoDesc, D3D11_VIDEO_DECODER_CONFIG* pConfig, ID3D11VideoDecoder** ppDecoder)</b><br/>
	/// </summary>
	/// <param name="pVideoDesc">_In_ <b>D3D11_VIDEO_DECODER_DESC* pVideoDesc</b></param>
	/// <param name="pConfig">_In_ <b>D3D11_VIDEO_DECODER_CONFIG* pConfig</b></param>
	/// <param name="ppDecoder">_COM_Outptr_ <b>ID3D11VideoDecoder** ppDecoder</b></param>
	int CreateVideoDecoder<T0> (VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, T0** ppDecoder) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoDecoder (D3D11_VIDEO_DECODER_DESC* pVideoDesc, D3D11_VIDEO_DECODER_CONFIG* pConfig, ID3D11VideoDecoder** ppDecoder)</b><br/>
	/// </summary>
	/// <param name="pVideoDesc">_In_ <b>D3D11_VIDEO_DECODER_DESC* pVideoDesc</b></param>
	/// <param name="pConfig">_In_ <b>D3D11_VIDEO_DECODER_CONFIG* pConfig</b></param>
	/// <param name="ppDecoder">_COM_Outptr_ <b>ID3D11VideoDecoder** ppDecoder</b></param>
	int CreateVideoDecoder<T0> (VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, out T0* ppDecoder) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessor (ID3D11VideoProcessorEnumerator* pEnum, UINT RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)</b><br/>
	/// </summary>
	/// <param name="pEnum">_In_ <b>ID3D11VideoProcessorEnumerator* pEnum</b></param>
	/// <param name="rateConversionIndex">_In_ <b>UINT RateConversionIndex</b></param>
	/// <param name="ppVideoProcessor">_COM_Outptr_ <b>ID3D11VideoProcessor** ppVideoProcessor</b></param>
	int CreateVideoProcessor<T0, T1> (T0* pEnum, uint rateConversionIndex, T1** ppVideoProcessor) where T0 : unmanaged, IVideoProcessorEnumerator where T1 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessor (ID3D11VideoProcessorEnumerator* pEnum, UINT RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)</b><br/>
	/// </summary>
	/// <param name="pEnum">_In_ <b>ID3D11VideoProcessorEnumerator* pEnum</b></param>
	/// <param name="rateConversionIndex">_In_ <b>UINT RateConversionIndex</b></param>
	/// <param name="ppVideoProcessor">_COM_Outptr_ <b>ID3D11VideoProcessor** ppVideoProcessor</b></param>
	int CreateVideoProcessor<T0, T1> (T0* pEnum, uint rateConversionIndex, out T1* ppVideoProcessor) where T0 : unmanaged, IVideoProcessorEnumerator where T1 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateAuthenticatedChannel (D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)</b><br/>
	/// </summary>
	/// <param name="channelType">_In_ <b>D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType</b></param>
	/// <param name="ppAuthenticatedChannel">_COM_Outptr_ <b>ID3D11AuthenticatedChannel** ppAuthenticatedChannel</b></param>
	int CreateAuthenticatedChannel<T0> (AuthenticatedChannelType channelType, T0** ppAuthenticatedChannel) where T0 : unmanaged, IAuthenticatedChannel;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateAuthenticatedChannel (D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)</b><br/>
	/// </summary>
	/// <param name="channelType">_In_ <b>D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType</b></param>
	/// <param name="ppAuthenticatedChannel">_COM_Outptr_ <b>ID3D11AuthenticatedChannel** ppAuthenticatedChannel</b></param>
	int CreateAuthenticatedChannel<T0> (AuthenticatedChannelType channelType, out T0* ppAuthenticatedChannel) where T0 : unmanaged, IAuthenticatedChannel;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateCryptoSession (GUID* pCryptoType, GUID* pDecoderProfile, GUID* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_In_ <b>GUID* pCryptoType</b></param>
	/// <param name="pDecoderProfile">_In_opt_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="pKeyExchangeType">_In_ <b>GUID* pKeyExchangeType</b></param>
	/// <param name="ppCryptoSession">_COM_Outptr_ <b>ID3D11CryptoSession** ppCryptoSession</b></param>
	int CreateCryptoSession<T0> (Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, T0** ppCryptoSession) where T0 : unmanaged, ICryptoSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateCryptoSession (GUID* pCryptoType, GUID* pDecoderProfile, GUID* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_In_ <b>GUID* pCryptoType</b></param>
	/// <param name="pDecoderProfile">_In_opt_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="pKeyExchangeType">_In_ <b>GUID* pKeyExchangeType</b></param>
	/// <param name="ppCryptoSession">_COM_Outptr_ <b>ID3D11CryptoSession** ppCryptoSession</b></param>
	int CreateCryptoSession<T0> (Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, out T0* ppCryptoSession) where T0 : unmanaged, ICryptoSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoDecoderOutputView (ID3D11Resource* pResource, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc</b></param>
	/// <param name="ppVDOVView">_COM_Outptr_opt_ <b>ID3D11VideoDecoderOutputView** ppVDOVView</b></param>
	int CreateVideoDecoderOutputView<T0, T1> (T0* pResource, VideoDecoderOutputViewDesc* pDesc, T1** ppVDOVView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoDecoderOutputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoDecoderOutputView (ID3D11Resource* pResource, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc</b></param>
	/// <param name="ppVDOVView">_COM_Outptr_opt_ <b>ID3D11VideoDecoderOutputView** ppVDOVView</b></param>
	int CreateVideoDecoderOutputView<T0, T1> (T0* pResource, VideoDecoderOutputViewDesc* pDesc, out T1* ppVDOVView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoDecoderOutputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessorInputView (ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorInputView** ppVPIView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pEnum">_In_ <b>ID3D11VideoProcessorEnumerator* pEnum</b></param>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc</b></param>
	/// <param name="ppVPIView">_COM_Outptr_opt_ <b>ID3D11VideoProcessorInputView** ppVPIView</b></param>
	int CreateVideoProcessorInputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorInputViewDesc* pDesc, T2** ppVPIView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorInputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessorInputView (ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorInputView** ppVPIView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pEnum">_In_ <b>ID3D11VideoProcessorEnumerator* pEnum</b></param>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc</b></param>
	/// <param name="ppVPIView">_COM_Outptr_opt_ <b>ID3D11VideoProcessorInputView** ppVPIView</b></param>
	int CreateVideoProcessorInputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorInputViewDesc* pDesc, out T2* ppVPIView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorInputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessorOutputView (ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pEnum">_In_ <b>ID3D11VideoProcessorEnumerator* pEnum</b></param>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc</b></param>
	/// <param name="ppVPOView">_COM_Outptr_opt_ <b>ID3D11VideoProcessorOutputView** ppVPOView</b></param>
	int CreateVideoProcessorOutputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorOutputViewDesc* pDesc, T2** ppVPOView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorOutputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessorOutputView (ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pEnum">_In_ <b>ID3D11VideoProcessorEnumerator* pEnum</b></param>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc</b></param>
	/// <param name="ppVPOView">_COM_Outptr_opt_ <b>ID3D11VideoProcessorOutputView** ppVPOView</b></param>
	int CreateVideoProcessorOutputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorOutputViewDesc* pDesc, out T2* ppVPOView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorOutputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessorEnumerator (D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc</b></param>
	/// <param name="ppEnum">_COM_Outptr_ <b>ID3D11VideoProcessorEnumerator** ppEnum</b></param>
	int CreateVideoProcessorEnumerator<T0> (VideoProcessorContentDesc* pDesc, T0** ppEnum) where T0 : unmanaged, IVideoProcessorEnumerator;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CreateVideoProcessorEnumerator (D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc</b></param>
	/// <param name="ppEnum">_COM_Outptr_ <b>ID3D11VideoProcessorEnumerator** ppEnum</b></param>
	int CreateVideoProcessorEnumerator<T0> (VideoProcessorContentDesc* pDesc, out T0* ppEnum) where T0 : unmanaged, IVideoProcessorEnumerator;
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D11VideoDevice::GetVideoDecoderProfileCount ()</b><br/>
	/// </summary>
	uint GetVideoDecoderProfileCount ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetVideoDecoderProfile (UINT Index, GUID* pDecoderProfile)</b><br/>
	/// </summary>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	/// <param name="pDecoderProfile">_Out_ <b>GUID* pDecoderProfile</b></param>
	int GetVideoDecoderProfile (uint index, Guid* pDecoderProfile);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetVideoDecoderProfile (UINT Index, GUID* pDecoderProfile)</b><br/>
	/// </summary>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	/// <param name="pDecoderProfile">_Out_ <b>GUID* pDecoderProfile</b></param>
	int GetVideoDecoderProfile (uint index, out Guid pDecoderProfile);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CheckVideoDecoderFormat (GUID* pDecoderProfile, DXGI_FORMAT Format, BOOL* pSupported)</b><br/>
	/// </summary>
	/// <param name="pDecoderProfile">_In_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="pSupported">_Out_ <b>BOOL* pSupported</b></param>
	int CheckVideoDecoderFormat (Guid* pDecoderProfile, DXGI.Format format, uint* pSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CheckVideoDecoderFormat (GUID* pDecoderProfile, DXGI_FORMAT Format, BOOL* pSupported)</b><br/>
	/// </summary>
	/// <param name="pDecoderProfile">_In_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="pSupported">_Out_ <b>BOOL* pSupported</b></param>
	int CheckVideoDecoderFormat (Guid* pDecoderProfile, DXGI.Format format, out bool pSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetVideoDecoderConfigCount (D3D11_VIDEO_DECODER_DESC* pDesc, UINT* pCount)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="pCount">_Out_ <b>UINT* pCount</b></param>
	int GetVideoDecoderConfigCount (VideoDecoderDesc* pDesc, uint* pCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetVideoDecoderConfigCount (D3D11_VIDEO_DECODER_DESC* pDesc, UINT* pCount)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="pCount">_Out_ <b>UINT* pCount</b></param>
	int GetVideoDecoderConfigCount (VideoDecoderDesc* pDesc, out uint pCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetVideoDecoderConfig (D3D11_VIDEO_DECODER_DESC* pDesc, UINT Index, D3D11_VIDEO_DECODER_CONFIG* pConfig)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	/// <param name="pConfig">_Out_ <b>D3D11_VIDEO_DECODER_CONFIG* pConfig</b></param>
	int GetVideoDecoderConfig (VideoDecoderDesc* pDesc, uint index, VideoDecoderConfig* pConfig);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetVideoDecoderConfig (D3D11_VIDEO_DECODER_DESC* pDesc, UINT Index, D3D11_VIDEO_DECODER_CONFIG* pConfig)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	/// <param name="pConfig">_Out_ <b>D3D11_VIDEO_DECODER_CONFIG* pConfig</b></param>
	int GetVideoDecoderConfig (VideoDecoderDesc* pDesc, uint index, out VideoDecoderConfig pConfig);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetContentProtectionCaps (GUID* pCryptoType, GUID* pDecoderProfile, D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_In_opt_ <b>GUID* pCryptoType</b></param>
	/// <param name="pDecoderProfile">_In_opt_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps</b></param>
	int GetContentProtectionCaps (Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::GetContentProtectionCaps (GUID* pCryptoType, GUID* pDecoderProfile, D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_In_opt_ <b>GUID* pCryptoType</b></param>
	/// <param name="pDecoderProfile">_In_opt_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps</b></param>
	int GetContentProtectionCaps (Guid* pCryptoType, Guid* pDecoderProfile, out VideoContentProtectionCaps pCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CheckCryptoKeyExchange (GUID* pCryptoType, GUID* pDecoderProfile, UINT Index, GUID* pKeyExchangeType)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_In_ <b>GUID* pCryptoType</b></param>
	/// <param name="pDecoderProfile">_In_opt_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	/// <param name="pKeyExchangeType">_Out_ <b>GUID* pKeyExchangeType</b></param>
	int CheckCryptoKeyExchange (Guid* pCryptoType, Guid* pDecoderProfile, uint index, Guid* pKeyExchangeType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::CheckCryptoKeyExchange (GUID* pCryptoType, GUID* pDecoderProfile, UINT Index, GUID* pKeyExchangeType)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_In_ <b>GUID* pCryptoType</b></param>
	/// <param name="pDecoderProfile">_In_opt_ <b>GUID* pDecoderProfile</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	/// <param name="pKeyExchangeType">_Out_ <b>GUID* pKeyExchangeType</b></param>
	int CheckCryptoKeyExchange (Guid* pCryptoType, Guid* pDecoderProfile, uint index, out Guid pKeyExchangeType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::SetPrivateData (REFGUID guid, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(DataSize) <b>void* pData</b></param>
	int SetPrivateData (Guid guid, uint dataSize, void* pData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice::SetPrivateDataInterface (REFGUID guid, IUnknown* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="pData">_In_opt_ <b>IUnknown* pData</b></param>
	int SetPrivateDataInterface<T0> (Guid guid, T0* pData) where T0 : unmanaged, IUnknown;
}

/// <summary>
/// Instance of <b>ID3D11VideoDevice</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct VideoDevice : IVideoDevice {
//unsafe public readonly struct IVideoDeviceObj : IVideoDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoDevice* GetCurrentPointer () => (VideoDevice*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoDeviceObj* GetCurrentPointer () => (IVideoDeviceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x10ec4d5b, 0x975a, 0x4689, 0xb9, 0xe4, 0xd0, 0xaa, 0xc3, 0x0f, 0xe3, 0x33);

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
	public readonly int CreateVideoDecoder<T0> (VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, T0** ppDecoder) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoder (ptr, pVideoDesc, pConfig, (void**) ppDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoder<T0> (VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, out T0* ppDecoder) where T0 : unmanaged, IVideoDecoder {
		fixed (T0** _ppDecoder = &ppDecoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoder (ptr, pVideoDesc, pConfig, (void**) _ppDecoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessor<T0, T1> (T0* pEnum, uint rateConversionIndex, T1** ppVideoProcessor) where T0 : unmanaged, IVideoProcessorEnumerator where T1 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessor (ptr, pEnum, rateConversionIndex, (void**) ppVideoProcessor);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessor<T0, T1> (T0* pEnum, uint rateConversionIndex, out T1* ppVideoProcessor) where T0 : unmanaged, IVideoProcessorEnumerator where T1 : unmanaged, IVideoProcessor {
		fixed (T1** _ppVideoProcessor = &ppVideoProcessor) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessor (ptr, pEnum, rateConversionIndex, (void**) _ppVideoProcessor);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateAuthenticatedChannel<T0> (AuthenticatedChannelType channelType, T0** ppAuthenticatedChannel) where T0 : unmanaged, IAuthenticatedChannel {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateAuthenticatedChannel (ptr, channelType, (void**) ppAuthenticatedChannel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateAuthenticatedChannel<T0> (AuthenticatedChannelType channelType, out T0* ppAuthenticatedChannel) where T0 : unmanaged, IAuthenticatedChannel {
		fixed (T0** _ppAuthenticatedChannel = &ppAuthenticatedChannel) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateAuthenticatedChannel (ptr, channelType, (void**) _ppAuthenticatedChannel);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCryptoSession<T0> (Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, T0** ppCryptoSession) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCryptoSession (ptr, pCryptoType, pDecoderProfile, pKeyExchangeType, (void**) ppCryptoSession);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCryptoSession<T0> (Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, out T0* ppCryptoSession) where T0 : unmanaged, ICryptoSession {
		fixed (T0** _ppCryptoSession = &ppCryptoSession) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCryptoSession (ptr, pCryptoType, pDecoderProfile, pKeyExchangeType, (void**) _ppCryptoSession);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoderOutputView<T0, T1> (T0* pResource, VideoDecoderOutputViewDesc* pDesc, T1** ppVDOVView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoDecoderOutputView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoderOutputView (ptr, pResource, pDesc, (void**) ppVDOVView);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoderOutputView<T0, T1> (T0* pResource, VideoDecoderOutputViewDesc* pDesc, out T1* ppVDOVView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoDecoderOutputView {
		fixed (T1** _ppVDOVView = &ppVDOVView) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoderOutputView (ptr, pResource, pDesc, (void**) _ppVDOVView);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessorInputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorInputViewDesc* pDesc, T2** ppVPIView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorInputView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessorInputView (ptr, pResource, pEnum, pDesc, (void**) ppVPIView);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessorInputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorInputViewDesc* pDesc, out T2* ppVPIView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorInputView {
		fixed (T2** _ppVPIView = &ppVPIView) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessorInputView (ptr, pResource, pEnum, pDesc, (void**) _ppVPIView);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessorOutputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorOutputViewDesc* pDesc, T2** ppVPOView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorOutputView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessorOutputView (ptr, pResource, pEnum, pDesc, (void**) ppVPOView);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessorOutputView<T0, T1, T2> (T0* pResource, T1* pEnum, VideoProcessorOutputViewDesc* pDesc, out T2* ppVPOView) where T0 : unmanaged, IResource where T1 : unmanaged, IVideoProcessorEnumerator where T2 : unmanaged, IVideoProcessorOutputView {
		fixed (T2** _ppVPOView = &ppVPOView) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessorOutputView (ptr, pResource, pEnum, pDesc, (void**) _ppVPOView);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessorEnumerator<T0> (VideoProcessorContentDesc* pDesc, T0** ppEnum) where T0 : unmanaged, IVideoProcessorEnumerator {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessorEnumerator (ptr, pDesc, (void**) ppEnum);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessorEnumerator<T0> (VideoProcessorContentDesc* pDesc, out T0* ppEnum) where T0 : unmanaged, IVideoProcessorEnumerator {
		fixed (T0** _ppEnum = &ppEnum) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessorEnumerator (ptr, pDesc, (void**) _ppEnum);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetVideoDecoderProfileCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderProfileCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderProfile (uint index, Guid* pDecoderProfile) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderProfile (ptr, index, pDecoderProfile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderProfile (uint index, out Guid pDecoderProfile) {
		fixed (Guid* _pDecoderProfile = &pDecoderProfile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderProfile (ptr, index, _pDecoderProfile);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoDecoderFormat (Guid* pDecoderProfile, DXGI.Format format, uint* pSupported) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoDecoderFormat (ptr, pDecoderProfile, format, pSupported);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoDecoderFormat (Guid* pDecoderProfile, DXGI.Format format, out bool pSupported) {
		uint _pSupported;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoDecoderFormat (ptr, pDecoderProfile, format, &_pSupported);
		pSupported = _pSupported != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderConfigCount (VideoDecoderDesc* pDesc, uint* pCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderConfigCount (ptr, pDesc, pCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderConfigCount (VideoDecoderDesc* pDesc, out uint pCount) {
		fixed (uint* _pCount = &pCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderConfigCount (ptr, pDesc, _pCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderConfig (VideoDecoderDesc* pDesc, uint index, VideoDecoderConfig* pConfig) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderConfig (ptr, pDesc, index, pConfig);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderConfig (VideoDecoderDesc* pDesc, uint index, out VideoDecoderConfig pConfig) {
		fixed (VideoDecoderConfig* _pConfig = &pConfig) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderConfig (ptr, pDesc, index, _pConfig);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContentProtectionCaps (Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetContentProtectionCaps (ptr, pCryptoType, pDecoderProfile, pCaps);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContentProtectionCaps (Guid* pCryptoType, Guid* pDecoderProfile, out VideoContentProtectionCaps pCaps) {
		fixed (VideoContentProtectionCaps* _pCaps = &pCaps) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetContentProtectionCaps (ptr, pCryptoType, pDecoderProfile, _pCaps);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckCryptoKeyExchange (Guid* pCryptoType, Guid* pDecoderProfile, uint index, Guid* pKeyExchangeType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckCryptoKeyExchange (ptr, pCryptoType, pDecoderProfile, index, pKeyExchangeType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckCryptoKeyExchange (Guid* pCryptoType, Guid* pDecoderProfile, uint index, out Guid pKeyExchangeType) {
		fixed (Guid* _pKeyExchangeType = &pKeyExchangeType) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CheckCryptoKeyExchange (ptr, pCryptoType, pDecoderProfile, index, _pKeyExchangeType);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateData (Guid guid, uint dataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateData (ptr, guid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateDataInterface<T0> (Guid guid, T0* pData) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateDataInterface (ptr, guid, pData);
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
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, VideoDecoderConfig*, void**, int> CreateVideoDecoder;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void**, int> CreateVideoProcessor;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AuthenticatedChannelType, void**, int> CreateAuthenticatedChannel;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, Guid*, Guid*, void**, int> CreateCryptoSession;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoDecoderOutputViewDesc*, void**, int> CreateVideoDecoderOutputView;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, VideoProcessorInputViewDesc*, void**, int> CreateVideoProcessorInputView;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, VideoProcessorOutputViewDesc*, void**, int> CreateVideoProcessorOutputView;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoProcessorContentDesc*, void**, int> CreateVideoProcessorEnumerator;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetVideoDecoderProfileCount;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Guid*, int> GetVideoDecoderProfile;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, DXGI.Format, uint*, int> CheckVideoDecoderFormat;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, uint*, int> GetVideoDecoderConfigCount;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int> GetVideoDecoderConfig;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, Guid*, VideoContentProtectionCaps*, int> GetContentProtectionCaps;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, Guid*, uint, Guid*, int> CheckCryptoKeyExchange;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
