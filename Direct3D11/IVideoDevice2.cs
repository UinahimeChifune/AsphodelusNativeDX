using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoDevice2</b> : ID3D11VideoDevice1<br/>
/// D3D11_4.h
/// </summary>
unsafe public interface IVideoDevice2 : IVideoDevice1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice2::CheckFeatureSupport (D3D11_FEATURE_VIDEO Feature, void* pFeatureSupportData, UINT FeatureSupportDataSize)</b><br/>
	/// </summary>
	/// <param name="feature"><b>D3D11_FEATURE_VIDEO Feature</b></param>
	/// <param name="pFeatureSupportData">_Out_writes_bytes_(FeatureSupportDataSize) <b>void* pFeatureSupportData</b></param>
	/// <param name="featureSupportDataSize"><b>UINT FeatureSupportDataSize</b></param>
	int CheckFeatureSupport (FeatureVideo feature, void* pFeatureSupportData, uint featureSupportDataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDevice2::NegotiateCryptoSessionKeyExchangeMT (ID3D11CryptoSession* pCryptoSession, D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS flags, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="pCryptoSession">_In_ <b>ID3D11CryptoSession* pCryptoSession</b></param>
	/// <param name="flags">_In_ <b>D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS flags</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_Inout_updates_bytes_(DataSize) <b>void* pData</b></param>
	int NegotiateCryptoSessionKeyExchangeMT<T0> (T0* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint dataSize, void* pData) where T0 : unmanaged, ICryptoSession;
}

/// <summary>
/// Instance of <b>ID3D11VideoDevice2</b><br/>
/// D3D11_4.h
/// </summary>
unsafe public readonly struct VideoDevice2 : IVideoDevice2 {
//unsafe public readonly struct IVideoDevice2Obj : IVideoDevice2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoDevice2* GetCurrentPointer () => (VideoDevice2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoDevice2Obj* GetCurrentPointer () => (IVideoDevice2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x59c0cb01, 0x35f0, 0x4a70, 0x8f, 0x67, 0x87, 0x90, 0x5c, 0x90, 0x6a, 0x53);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCryptoSessionPrivateDataSize (Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCryptoSessionPrivateDataSize (ptr, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCryptoSessionPrivateDataSize (Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, out uint pPrivateInputSize, out uint pPrivateOutputSize) {
		fixed (uint* _pPrivateInputSize = &pPrivateInputSize) {
			fixed (uint* _pPrivateOutputSize = &pPrivateOutputSize) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetCryptoSessionPrivateDataSize (ptr, pCryptoType, pDecoderProfile, pKeyExchangeType, _pPrivateInputSize, _pPrivateOutputSize);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderCaps (Guid* pDecoderProfile, uint sampleWidth, uint sampleHeight, DXGI.Rational* pFrameRate, uint bitRate, Guid* pCryptoType, uint* pDecoderCaps) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderCaps (ptr, pDecoderProfile, sampleWidth, sampleHeight, pFrameRate, bitRate, pCryptoType, pDecoderCaps);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoDecoderCaps (Guid* pDecoderProfile, uint sampleWidth, uint sampleHeight, DXGI.Rational* pFrameRate, uint bitRate, Guid* pCryptoType, out uint pDecoderCaps) {
		fixed (uint* _pDecoderCaps = &pDecoderCaps) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoDecoderCaps (ptr, pDecoderProfile, sampleWidth, sampleHeight, pFrameRate, bitRate, pCryptoType, _pDecoderCaps);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoDecoderDownsampling (VideoDecoderDesc* pInputDesc, DXGI.ColorSpaceType inputColorSpace, VideoDecoderConfig* pInputConfig, DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, uint* pSupported, uint* pRealTimeHint) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoDecoderDownsampling (ptr, pInputDesc, inputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoDecoderDownsampling (VideoDecoderDesc* pInputDesc, DXGI.ColorSpaceType inputColorSpace, VideoDecoderConfig* pInputConfig, DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, out bool pSupported, out bool pRealTimeHint) {
		uint _pSupported;
		uint _pRealTimeHint;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoDecoderDownsampling (ptr, pInputDesc, inputColorSpace, pInputConfig, pFrameRate, pOutputDesc, &_pSupported, &_pRealTimeHint);
		pRealTimeHint = _pRealTimeHint != 0;
		pSupported = _pSupported != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RecommendVideoDecoderDownsampleParameters (VideoDecoderDesc* pInputDesc, DXGI.ColorSpaceType inputColorSpace, VideoDecoderConfig* pInputConfig, DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RecommendVideoDecoderDownsampleParameters (ptr, pInputDesc, inputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RecommendVideoDecoderDownsampleParameters (VideoDecoderDesc* pInputDesc, DXGI.ColorSpaceType inputColorSpace, VideoDecoderConfig* pInputConfig, DXGI.Rational* pFrameRate, out VideoSampleDesc pRecommendedOutputDesc) {
		fixed (VideoSampleDesc* _pRecommendedOutputDesc = &pRecommendedOutputDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RecommendVideoDecoderDownsampleParameters (ptr, pInputDesc, inputColorSpace, pInputConfig, pFrameRate, _pRecommendedOutputDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckFeatureSupport (FeatureVideo feature, void* pFeatureSupportData, uint featureSupportDataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckFeatureSupport (ptr, feature, pFeatureSupportData, featureSupportDataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int NegotiateCryptoSessionKeyExchangeMT<T0> (T0* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint dataSize, void* pData) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->NegotiateCryptoSessionKeyExchangeMT (ptr, pCryptoSession, flags, dataSize, pData);
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
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, Guid*, Guid*, uint*, uint*, int> GetCryptoSessionPrivateDataSize;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, uint, uint, DXGI.Rational*, uint, Guid*, uint*, int> GetVideoDecoderCaps;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, DXGI.ColorSpaceType, VideoDecoderConfig*, DXGI.Rational*, VideoSampleDesc*, uint*, uint*, int> CheckVideoDecoderDownsampling;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, DXGI.ColorSpaceType, VideoDecoderConfig*, DXGI.Rational*, VideoSampleDesc*, int> RecommendVideoDecoderDownsampleParameters;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FeatureVideo, void*, uint, int> CheckFeatureSupport;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, CryptoSessionKeyExchangeFlags, uint, void*, int> NegotiateCryptoSessionKeyExchangeMT;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
