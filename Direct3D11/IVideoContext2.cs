using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoContext2</b> : ID3D11VideoContext1<br/>
/// D3D11_4.h
/// </summary>
unsafe public interface IVideoContext2 : IVideoContext1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext2::VideoProcessorSetOutputHDRMetaData (ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE Type, UINT Size, void* pHDRMetaData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="type">_In_ <b>DXGI_HDR_METADATA_TYPE Type</b></param>
	/// <param name="size">_In_ <b>UINT Size</b></param>
	/// <param name="pHDRMetaData">_In_reads_bytes_opt_(Size) <b>void* pHDRMetaData</b></param>
	void VideoProcessorSetOutputHDRMetaData<T0> (T0* pVideoProcessor, DXGI.HdrMetadataType type, uint size, void* pHDRMetaData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext2::VideoProcessorGetOutputHDRMetaData (ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE* pType, UINT Size, void* pMetaData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pType">_Out_ <b>DXGI_HDR_METADATA_TYPE* pType</b></param>
	/// <param name="size">_In_ <b>UINT Size</b></param>
	/// <param name="pMetaData">_Out_writes_bytes_opt_(Size) <b>void* pMetaData</b></param>
	void VideoProcessorGetOutputHDRMetaData<T0> (T0* pVideoProcessor, DXGI.HdrMetadataType* pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext2::VideoProcessorGetOutputHDRMetaData (ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE* pType, UINT Size, void* pMetaData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pType">_Out_ <b>DXGI_HDR_METADATA_TYPE* pType</b></param>
	/// <param name="size">_In_ <b>UINT Size</b></param>
	/// <param name="pMetaData">_Out_writes_bytes_opt_(Size) <b>void* pMetaData</b></param>
	void VideoProcessorGetOutputHDRMetaData<T0> (T0* pVideoProcessor, out DXGI.HdrMetadataType pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext2::VideoProcessorSetStreamHDRMetaData (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, DXGI_HDR_METADATA_TYPE Type, UINT Size, void* pHDRMetaData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="type">_In_ <b>DXGI_HDR_METADATA_TYPE Type</b></param>
	/// <param name="size">_In_ <b>UINT Size</b></param>
	/// <param name="pHDRMetaData">_In_reads_bytes_opt_(Size) <b>void* pHDRMetaData</b></param>
	void VideoProcessorSetStreamHDRMetaData<T0> (T0* pVideoProcessor, uint streamIndex, DXGI.HdrMetadataType type, uint size, void* pHDRMetaData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext2::VideoProcessorGetStreamHDRMetaData (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, DXGI_HDR_METADATA_TYPE* pType, UINT Size, void* pMetaData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pType">_Out_ <b>DXGI_HDR_METADATA_TYPE* pType</b></param>
	/// <param name="size">_In_ <b>UINT Size</b></param>
	/// <param name="pMetaData">_Out_writes_bytes_opt_(Size) <b>void* pMetaData</b></param>
	void VideoProcessorGetStreamHDRMetaData<T0> (T0* pVideoProcessor, uint streamIndex, DXGI.HdrMetadataType* pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext2::VideoProcessorGetStreamHDRMetaData (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, DXGI_HDR_METADATA_TYPE* pType, UINT Size, void* pMetaData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pType">_Out_ <b>DXGI_HDR_METADATA_TYPE* pType</b></param>
	/// <param name="size">_In_ <b>UINT Size</b></param>
	/// <param name="pMetaData">_Out_writes_bytes_opt_(Size) <b>void* pMetaData</b></param>
	void VideoProcessorGetStreamHDRMetaData<T0> (T0* pVideoProcessor, uint streamIndex, out DXGI.HdrMetadataType pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor;
}

/// <summary>
/// Instance of <b>ID3D11VideoContext2</b><br/>
/// D3D11_4.h
/// </summary>
unsafe public readonly struct VideoContext2 : IVideoContext2 {
//unsafe public readonly struct IVideoContext2Obj : IVideoContext2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoContext2* GetCurrentPointer () => (VideoContext2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoContext2Obj* GetCurrentPointer () => (IVideoContext2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc4e7374c, 0x6243, 0x4d1b, 0xae, 0x87, 0x52, 0xb4, 0xf7, 0x40, 0xe2, 0x61);

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
	public readonly void GetDevice<T0> (T0** ppDevice) where T0 : unmanaged, IDevice {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) ppDevice);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDevice<T0> (out T0* ppDevice) where T0 : unmanaged, IDevice {
		fixed (T0** _ppDevice = &ppDevice) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) _ppDevice);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPrivateData (Guid guid, uint* pDataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrivateData (ptr, guid, pDataSize, pData);
		return hr;
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
	public readonly int GetDecoderBuffer<T0> (T0* pDecoder, VideoDecoderBufferType type, uint* pBufferSize, void** ppBuffer) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDecoderBuffer (ptr, pDecoder, type, pBufferSize, ppBuffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDecoderBuffer<T0> (T0* pDecoder, VideoDecoderBufferType type, out uint pBufferSize, out void* ppBuffer) where T0 : unmanaged, IVideoDecoder {
		fixed (uint* _pBufferSize = &pBufferSize) {
			fixed (void** _ppBuffer = &ppBuffer) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetDecoderBuffer (ptr, pDecoder, type, _pBufferSize, _ppBuffer);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReleaseDecoderBuffer<T0> (T0* pDecoder, VideoDecoderBufferType type) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReleaseDecoderBuffer (ptr, pDecoder, type);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DecoderBeginFrame<T0, T1> (T0* pDecoder, T1* pView, uint contentKeySize, void* pContentKey) where T0 : unmanaged, IVideoDecoder where T1 : unmanaged, IVideoDecoderOutputView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DecoderBeginFrame (ptr, pDecoder, pView, contentKeySize, pContentKey);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DecoderEndFrame<T0> (T0* pDecoder) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DecoderEndFrame (ptr, pDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SubmitDecoderBuffers<T0> (T0* pDecoder, uint numBuffers, VideoDecoderBufferDesc* pBufferDesc) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SubmitDecoderBuffers (ptr, pDecoder, numBuffers, pBufferDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DecoderExtension<T0> (T0* pDecoder, VideoDecoderExtension* pExtensionData) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DecoderExtension (ptr, pDecoder, pExtensionData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputTargetRect<T0> (T0* pVideoProcessor, bool enable, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputTargetRect (ptr, pVideoProcessor, enable ? 1U : 0U, pRect);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputBackgroundColor<T0> (T0* pVideoProcessor, bool yCbCr, VideoColor* pColor) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputBackgroundColor (ptr, pVideoProcessor, yCbCr ? 1U : 0U, pColor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputColorSpace<T0> (T0* pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputColorSpace (ptr, pVideoProcessor, pColorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputAlphaFillMode<T0> (T0* pVideoProcessor, VideoProcessorAlphaFillMode alphaFillMode, uint streamIndex) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputAlphaFillMode (ptr, pVideoProcessor, alphaFillMode, streamIndex);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputConstriction<T0> (T0* pVideoProcessor, bool enable, Vector2I size) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputConstriction (ptr, pVideoProcessor, enable ? 1U : 0U, size);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputStereoMode<T0> (T0* pVideoProcessor, bool enable) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputStereoMode (ptr, pVideoProcessor, enable ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int VideoProcessorSetOutputExtension<T0> (T0* pVideoProcessor, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputExtension (ptr, pVideoProcessor, pExtensionGuid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputTargetRect<T0> (T0* pVideoProcessor, uint* enabled, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputTargetRect (ptr, pVideoProcessor, enabled, pRect);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputTargetRect<T0> (T0* pVideoProcessor, out bool enabled, out Vector4I pRect) where T0 : unmanaged, IVideoProcessor {
		uint _enabled;
		fixed (Vector4I* _pRect = &pRect) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputTargetRect (ptr, pVideoProcessor, &_enabled, _pRect);
			enabled = _enabled != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputBackgroundColor<T0> (T0* pVideoProcessor, uint* pYCbCr, VideoColor* pColor) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputBackgroundColor (ptr, pVideoProcessor, pYCbCr, pColor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputBackgroundColor<T0> (T0* pVideoProcessor, out bool pYCbCr, out VideoColor pColor) where T0 : unmanaged, IVideoProcessor {
		uint _pYCbCr;
		fixed (VideoColor* _pColor = &pColor) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputBackgroundColor (ptr, pVideoProcessor, &_pYCbCr, _pColor);
			pYCbCr = _pYCbCr != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputColorSpace<T0> (T0* pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputColorSpace (ptr, pVideoProcessor, pColorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputColorSpace<T0> (T0* pVideoProcessor, out VideoProcessorColorSpace pColorSpace) where T0 : unmanaged, IVideoProcessor {
		fixed (VideoProcessorColorSpace* _pColorSpace = &pColorSpace) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputColorSpace (ptr, pVideoProcessor, _pColorSpace);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputAlphaFillMode<T0> (T0* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputAlphaFillMode (ptr, pVideoProcessor, pAlphaFillMode, pStreamIndex);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputAlphaFillMode<T0> (T0* pVideoProcessor, out VideoProcessorAlphaFillMode pAlphaFillMode, out uint pStreamIndex) where T0 : unmanaged, IVideoProcessor {
		fixed (VideoProcessorAlphaFillMode* _pAlphaFillMode = &pAlphaFillMode) {
			fixed (uint* _pStreamIndex = &pStreamIndex) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputAlphaFillMode (ptr, pVideoProcessor, _pAlphaFillMode, _pStreamIndex);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputConstriction<T0> (T0* pVideoProcessor, uint* pEnabled, Vector2I* pSize) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputConstriction (ptr, pVideoProcessor, pEnabled, pSize);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputConstriction<T0> (T0* pVideoProcessor, out bool pEnabled, out Vector2I pSize) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		fixed (Vector2I* _pSize = &pSize) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputConstriction (ptr, pVideoProcessor, &_pEnabled, _pSize);
			pEnabled = _pEnabled != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputStereoMode<T0> (T0* pVideoProcessor, uint* pEnabled) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputStereoMode (ptr, pVideoProcessor, pEnabled);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputStereoMode<T0> (T0* pVideoProcessor, out bool pEnabled) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputStereoMode (ptr, pVideoProcessor, &_pEnabled);
		pEnabled = _pEnabled != 0;
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int VideoProcessorGetOutputExtension<T0> (T0* pVideoProcessor, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputExtension (ptr, pVideoProcessor, pExtensionGuid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamFrameFormat<T0> (T0* pVideoProcessor, uint streamIndex, VideoFrameFormat frameFormat) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamFrameFormat (ptr, pVideoProcessor, streamIndex, frameFormat);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamColorSpace<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamColorSpace (ptr, pVideoProcessor, streamIndex, pColorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamOutputRate<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorOutputRate outputRate, bool repeatFrame, DXGI.Rational* pCustomRate) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamOutputRate (ptr, pVideoProcessor, streamIndex, outputRate, repeatFrame ? 1U : 0U, pCustomRate);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamSourceRect<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamSourceRect (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, pRect);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamDestRect<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamDestRect (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, pRect);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamAlpha<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, float alpha) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamAlpha (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, alpha);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamPalette<T0> (T0* pVideoProcessor, uint streamIndex, uint count, uint* pEntries) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamPalette (ptr, pVideoProcessor, streamIndex, count, pEntries);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamPixelAspectRatio<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, DXGI.Rational* pSourceAspectRatio, DXGI.Rational* pDestinationAspectRatio) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamPixelAspectRatio (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, pSourceAspectRatio, pDestinationAspectRatio);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamLumaKey<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, float lower, float upper) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamLumaKey (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, lower, upper);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamStereoFormat<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, VideoProcessorStereoFormat format, bool leftViewFrame0, bool baseViewFrame0, VideoProcessorStereoFlipMode flipMode, int monoOffset) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamStereoFormat (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, format, leftViewFrame0 ? 1U : 0U, baseViewFrame0 ? 1U : 0U, flipMode, monoOffset);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamAutoProcessingMode<T0> (T0* pVideoProcessor, uint streamIndex, bool enable) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamAutoProcessingMode (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamFilter<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorFilter filter, bool enable, int level) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamFilter (ptr, pVideoProcessor, streamIndex, filter, enable ? 1U : 0U, level);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int VideoProcessorSetStreamExtension<T0> (T0* pVideoProcessor, uint streamIndex, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamExtension (ptr, pVideoProcessor, streamIndex, pExtensionGuid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamFrameFormat<T0> (T0* pVideoProcessor, uint streamIndex, VideoFrameFormat* pFrameFormat) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamFrameFormat (ptr, pVideoProcessor, streamIndex, pFrameFormat);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamFrameFormat<T0> (T0* pVideoProcessor, uint streamIndex, out VideoFrameFormat pFrameFormat) where T0 : unmanaged, IVideoProcessor {
		fixed (VideoFrameFormat* _pFrameFormat = &pFrameFormat) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamFrameFormat (ptr, pVideoProcessor, streamIndex, _pFrameFormat);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamColorSpace<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamColorSpace (ptr, pVideoProcessor, streamIndex, pColorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamColorSpace<T0> (T0* pVideoProcessor, uint streamIndex, out VideoProcessorColorSpace pColorSpace) where T0 : unmanaged, IVideoProcessor {
		fixed (VideoProcessorColorSpace* _pColorSpace = &pColorSpace) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamColorSpace (ptr, pVideoProcessor, streamIndex, _pColorSpace);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamOutputRate<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorOutputRate* pOutputRate, uint* pRepeatFrame, DXGI.Rational* pCustomRate) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamOutputRate (ptr, pVideoProcessor, streamIndex, pOutputRate, pRepeatFrame, pCustomRate);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamOutputRate<T0> (T0* pVideoProcessor, uint streamIndex, out VideoProcessorOutputRate pOutputRate, out bool pRepeatFrame, out DXGI.Rational pCustomRate) where T0 : unmanaged, IVideoProcessor {
		fixed (VideoProcessorOutputRate* _pOutputRate = &pOutputRate) {
			uint _pRepeatFrame;
			fixed (DXGI.Rational* _pCustomRate = &pCustomRate) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamOutputRate (ptr, pVideoProcessor, streamIndex, _pOutputRate, &_pRepeatFrame, _pCustomRate);
				pRepeatFrame = _pRepeatFrame != 0;
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamSourceRect<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamSourceRect (ptr, pVideoProcessor, streamIndex, pEnabled, pRect);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamSourceRect<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out Vector4I pRect) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		fixed (Vector4I* _pRect = &pRect) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamSourceRect (ptr, pVideoProcessor, streamIndex, &_pEnabled, _pRect);
			pEnabled = _pEnabled != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamDestRect<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamDestRect (ptr, pVideoProcessor, streamIndex, pEnabled, pRect);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamDestRect<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out Vector4I pRect) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		fixed (Vector4I* _pRect = &pRect) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamDestRect (ptr, pVideoProcessor, streamIndex, &_pEnabled, _pRect);
			pEnabled = _pEnabled != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamAlpha<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, float* pAlpha) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamAlpha (ptr, pVideoProcessor, streamIndex, pEnabled, pAlpha);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamAlpha<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out float pAlpha) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		fixed (float* _pAlpha = &pAlpha) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamAlpha (ptr, pVideoProcessor, streamIndex, &_pEnabled, _pAlpha);
			pEnabled = _pEnabled != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamPalette<T0> (T0* pVideoProcessor, uint streamIndex, uint count, uint* pEntries) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamPalette (ptr, pVideoProcessor, streamIndex, count, pEntries);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamPixelAspectRatio<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, DXGI.Rational* pSourceAspectRatio, DXGI.Rational* pDestinationAspectRatio) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamPixelAspectRatio (ptr, pVideoProcessor, streamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamPixelAspectRatio<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out DXGI.Rational pSourceAspectRatio, out DXGI.Rational pDestinationAspectRatio) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		fixed (DXGI.Rational* _pSourceAspectRatio = &pSourceAspectRatio) {
			fixed (DXGI.Rational* _pDestinationAspectRatio = &pDestinationAspectRatio) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamPixelAspectRatio (ptr, pVideoProcessor, streamIndex, &_pEnabled, _pSourceAspectRatio, _pDestinationAspectRatio);
				pEnabled = _pEnabled != 0;
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamLumaKey<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, float* pLower, float* pUpper) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamLumaKey (ptr, pVideoProcessor, streamIndex, pEnabled, pLower, pUpper);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamLumaKey<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out float pLower, out float pUpper) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		fixed (float* _pLower = &pLower) {
			fixed (float* _pUpper = &pUpper) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamLumaKey (ptr, pVideoProcessor, streamIndex, &_pEnabled, _pLower, _pUpper);
				pEnabled = _pEnabled != 0;
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamStereoFormat<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnable, VideoProcessorStereoFormat* pFormat, uint* pLeftViewFrame0, uint* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* monoOffset) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamStereoFormat (ptr, pVideoProcessor, streamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, monoOffset);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamStereoFormat<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnable, out VideoProcessorStereoFormat pFormat, out bool pLeftViewFrame0, out bool pBaseViewFrame0, out VideoProcessorStereoFlipMode pFlipMode, out int monoOffset) where T0 : unmanaged, IVideoProcessor {
		uint _pEnable;
		fixed (VideoProcessorStereoFormat* _pFormat = &pFormat) {
			uint _pLeftViewFrame0;
			uint _pBaseViewFrame0;
			fixed (VideoProcessorStereoFlipMode* _pFlipMode = &pFlipMode) {
				fixed (int* _monoOffset = &monoOffset) {
					var ptr = GetCurrentPointer ();
					((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamStereoFormat (ptr, pVideoProcessor, streamIndex, &_pEnable, _pFormat, &_pLeftViewFrame0, &_pBaseViewFrame0, _pFlipMode, _monoOffset);
					pBaseViewFrame0 = _pBaseViewFrame0 != 0;
					pLeftViewFrame0 = _pLeftViewFrame0 != 0;
					pEnable = _pEnable != 0;
					return;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamAutoProcessingMode<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamAutoProcessingMode (ptr, pVideoProcessor, streamIndex, pEnabled);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamAutoProcessingMode<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamAutoProcessingMode (ptr, pVideoProcessor, streamIndex, &_pEnabled);
		pEnabled = _pEnabled != 0;
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamFilter<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorFilter filter, uint* pEnabled, int* pLevel) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamFilter (ptr, pVideoProcessor, streamIndex, filter, pEnabled, pLevel);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamFilter<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorFilter filter, out bool pEnabled, out int pLevel) where T0 : unmanaged, IVideoProcessor {
		uint _pEnabled;
		fixed (int* _pLevel = &pLevel) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamFilter (ptr, pVideoProcessor, streamIndex, filter, &_pEnabled, _pLevel);
			pEnabled = _pEnabled != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int VideoProcessorGetStreamExtension<T0> (T0* pVideoProcessor, uint streamIndex, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamExtension (ptr, pVideoProcessor, streamIndex, pExtensionGuid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int VideoProcessorBlt<T0, T1> (T0* pVideoProcessor, T1* pView, uint outputFrame, uint streamCount, VideoProcessorStream* pStreams) where T0 : unmanaged, IVideoProcessor where T1 : unmanaged, IVideoProcessorOutputView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->VideoProcessorBlt (ptr, pVideoProcessor, pView, outputFrame, streamCount, pStreams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int NegotiateCryptoSessionKeyExchange<T0> (T0* pCryptoSession, uint dataSize, void* pData) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->NegotiateCryptoSessionKeyExchange (ptr, pCryptoSession, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void EncryptionBlt<T0, T1, T2> (T0* pCryptoSession, T1* pSrcSurface, T2* pDstSurface, uint iVSize, void* pIV) where T0 : unmanaged, ICryptoSession where T1 : unmanaged, ITexture2D where T2 : unmanaged, ITexture2D {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EncryptionBlt (ptr, pCryptoSession, pSrcSurface, pDstSurface, iVSize, pIV);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DecryptionBlt<T0, T1, T2> (T0* pCryptoSession, T1* pSrcSurface, T2* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint contentKeySize, void* pContentKey, uint iVSize, void* pIV) where T0 : unmanaged, ICryptoSession where T1 : unmanaged, ITexture2D where T2 : unmanaged, ITexture2D {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DecryptionBlt (ptr, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, contentKeySize, pContentKey, iVSize, pIV);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void StartSessionKeyRefresh<T0> (T0* pCryptoSession, uint randomNumberSize, void* pRandomNumber) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->StartSessionKeyRefresh (ptr, pCryptoSession, randomNumberSize, pRandomNumber);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FinishSessionKeyRefresh<T0> (T0* pCryptoSession) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FinishSessionKeyRefresh (ptr, pCryptoSession);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEncryptionBltKey<T0> (T0* pCryptoSession, uint keySize, void* pReadbackKey) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEncryptionBltKey (ptr, pCryptoSession, keySize, pReadbackKey);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int NegotiateAuthenticatedChannelKeyExchange<T0> (T0* pChannel, uint dataSize, void* pData) where T0 : unmanaged, IAuthenticatedChannel {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->NegotiateAuthenticatedChannelKeyExchange (ptr, pChannel, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryAuthenticatedChannel<T0> (T0* pChannel, uint inputSize, void* pInput, uint outputSize, void* pOutput) where T0 : unmanaged, IAuthenticatedChannel {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryAuthenticatedChannel (ptr, pChannel, inputSize, pInput, outputSize, pOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConfigureAuthenticatedChannel<T0> (T0* pChannel, uint inputSize, void* pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged, IAuthenticatedChannel {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ConfigureAuthenticatedChannel (ptr, pChannel, inputSize, pInput, pOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConfigureAuthenticatedChannel<T0> (T0* pChannel, uint inputSize, void* pInput, out AuthenticatedConfigureOutput pOutput) where T0 : unmanaged, IAuthenticatedChannel {
		fixed (AuthenticatedConfigureOutput* _pOutput = &pOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->ConfigureAuthenticatedChannel (ptr, pChannel, inputSize, pInput, _pOutput);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamRotation<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, VideoProcessorRotation rotation) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamRotation (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, rotation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamRotation<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnable, VideoProcessorRotation* pRotation) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamRotation (ptr, pVideoProcessor, streamIndex, pEnable, pRotation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamRotation<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnable, out VideoProcessorRotation pRotation) where T0 : unmanaged, IVideoProcessor {
		uint _pEnable;
		fixed (VideoProcessorRotation* _pRotation = &pRotation) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamRotation (ptr, pVideoProcessor, streamIndex, &_pEnable, _pRotation);
			pEnable = _pEnable != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SubmitDecoderBuffers1<T0> (T0* pDecoder, uint numBuffers, VideoDecoderBufferDesc1* pBufferDesc) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SubmitDecoderBuffers1 (ptr, pDecoder, numBuffers, pBufferDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDataForNewHardwareKey<T0> (T0* pCryptoSession, uint privateInputSize, void* pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDataForNewHardwareKey (ptr, pCryptoSession, privateInputSize, pPrivatInputData, pPrivateOutputData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDataForNewHardwareKey<T0> (T0* pCryptoSession, uint privateInputSize, void* pPrivatInputData, out ulong pPrivateOutputData) where T0 : unmanaged, ICryptoSession {
		fixed (ulong* _pPrivateOutputData = &pPrivateOutputData) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDataForNewHardwareKey (ptr, pCryptoSession, privateInputSize, pPrivatInputData, _pPrivateOutputData);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckCryptoSessionStatus<T0> (T0* pCryptoSession, CryptoSessionStatus* pStatus) where T0 : unmanaged, ICryptoSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckCryptoSessionStatus (ptr, pCryptoSession, pStatus);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckCryptoSessionStatus<T0> (T0* pCryptoSession, out CryptoSessionStatus pStatus) where T0 : unmanaged, ICryptoSession {
		fixed (CryptoSessionStatus* _pStatus = &pStatus) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CheckCryptoSessionStatus (ptr, pCryptoSession, _pStatus);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DecoderEnableDownsampling<T0> (T0* pDecoder, DXGI.ColorSpaceType inputColorSpace, VideoSampleDesc* pOutputDesc, uint referenceFrameCount) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DecoderEnableDownsampling (ptr, pDecoder, inputColorSpace, pOutputDesc, referenceFrameCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DecoderUpdateDownsampling<T0> (T0* pDecoder, VideoSampleDesc* pOutputDesc) where T0 : unmanaged, IVideoDecoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DecoderUpdateDownsampling (ptr, pDecoder, pOutputDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputColorSpace1<T0> (T0* pVideoProcessor, DXGI.ColorSpaceType colorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputColorSpace1 (ptr, pVideoProcessor, colorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputShaderUsage<T0> (T0* pVideoProcessor, bool shaderUsage) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputShaderUsage (ptr, pVideoProcessor, shaderUsage ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputColorSpace1<T0> (T0* pVideoProcessor, DXGI.ColorSpaceType* pColorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputColorSpace1 (ptr, pVideoProcessor, pColorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputColorSpace1<T0> (T0* pVideoProcessor, out DXGI.ColorSpaceType pColorSpace) where T0 : unmanaged, IVideoProcessor {
		fixed (DXGI.ColorSpaceType* _pColorSpace = &pColorSpace) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputColorSpace1 (ptr, pVideoProcessor, _pColorSpace);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputShaderUsage<T0> (T0* pVideoProcessor, uint* pShaderUsage) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputShaderUsage (ptr, pVideoProcessor, pShaderUsage);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputShaderUsage<T0> (T0* pVideoProcessor, out bool pShaderUsage) where T0 : unmanaged, IVideoProcessor {
		uint _pShaderUsage;
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputShaderUsage (ptr, pVideoProcessor, &_pShaderUsage);
		pShaderUsage = _pShaderUsage != 0;
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamColorSpace1<T0> (T0* pVideoProcessor, uint streamIndex, DXGI.ColorSpaceType colorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamColorSpace1 (ptr, pVideoProcessor, streamIndex, colorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamMirror<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, bool flipHorizontal, bool flipVertical) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamMirror (ptr, pVideoProcessor, streamIndex, enable ? 1U : 0U, flipHorizontal ? 1U : 0U, flipVertical ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamColorSpace1<T0> (T0* pVideoProcessor, uint streamIndex, DXGI.ColorSpaceType* pColorSpace) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamColorSpace1 (ptr, pVideoProcessor, streamIndex, pColorSpace);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamColorSpace1<T0> (T0* pVideoProcessor, uint streamIndex, out DXGI.ColorSpaceType pColorSpace) where T0 : unmanaged, IVideoProcessor {
		fixed (DXGI.ColorSpaceType* _pColorSpace = &pColorSpace) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamColorSpace1 (ptr, pVideoProcessor, streamIndex, _pColorSpace);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamMirror<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnable, uint* pFlipHorizontal, uint* pFlipVertical) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamMirror (ptr, pVideoProcessor, streamIndex, pEnable, pFlipHorizontal, pFlipVertical);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamMirror<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnable, out bool pFlipHorizontal, out bool pFlipVertical) where T0 : unmanaged, IVideoProcessor {
		uint _pEnable;
		uint _pFlipHorizontal;
		uint _pFlipVertical;
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamMirror (ptr, pVideoProcessor, streamIndex, &_pEnable, &_pFlipHorizontal, &_pFlipVertical);
		pFlipVertical = _pFlipVertical != 0;
		pFlipHorizontal = _pFlipHorizontal != 0;
		pEnable = _pEnable != 0;
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int VideoProcessorGetBehaviorHints<T0> (T0* pVideoProcessor, uint outputWidth, uint outputHeight, DXGI.Format outputFormat, uint streamCount, VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->VideoProcessorGetBehaviorHints (ptr, pVideoProcessor, outputWidth, outputHeight, outputFormat, streamCount, pStreams, pBehaviorHints);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int VideoProcessorGetBehaviorHints<T0> (T0* pVideoProcessor, uint outputWidth, uint outputHeight, DXGI.Format outputFormat, uint streamCount, VideoProcessorStreamBehaviorHint* pStreams, out uint pBehaviorHints) where T0 : unmanaged, IVideoProcessor {
		fixed (uint* _pBehaviorHints = &pBehaviorHints) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->VideoProcessorGetBehaviorHints (ptr, pVideoProcessor, outputWidth, outputHeight, outputFormat, streamCount, pStreams, _pBehaviorHints);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetOutputHDRMetaData<T0> (T0* pVideoProcessor, DXGI.HdrMetadataType type, uint size, void* pHDRMetaData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetOutputHDRMetaData (ptr, pVideoProcessor, type, size, pHDRMetaData);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputHDRMetaData<T0> (T0* pVideoProcessor, DXGI.HdrMetadataType* pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputHDRMetaData (ptr, pVideoProcessor, pType, size, pMetaData);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetOutputHDRMetaData<T0> (T0* pVideoProcessor, out DXGI.HdrMetadataType pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor {
		fixed (DXGI.HdrMetadataType* _pType = &pType) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetOutputHDRMetaData (ptr, pVideoProcessor, _pType, size, pMetaData);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorSetStreamHDRMetaData<T0> (T0* pVideoProcessor, uint streamIndex, DXGI.HdrMetadataType type, uint size, void* pHDRMetaData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorSetStreamHDRMetaData (ptr, pVideoProcessor, streamIndex, type, size, pHDRMetaData);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamHDRMetaData<T0> (T0* pVideoProcessor, uint streamIndex, DXGI.HdrMetadataType* pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamHDRMetaData (ptr, pVideoProcessor, streamIndex, pType, size, pMetaData);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VideoProcessorGetStreamHDRMetaData<T0> (T0* pVideoProcessor, uint streamIndex, out DXGI.HdrMetadataType pType, uint size, void* pMetaData) where T0 : unmanaged, IVideoProcessor {
		fixed (DXGI.HdrMetadataType* _pType = &pType) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VideoProcessorGetStreamHDRMetaData (ptr, pVideoProcessor, streamIndex, _pType, size, pMetaData);
			return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetDevice;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoDecoderBufferType, uint*, void**, int> GetDecoderBuffer;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoDecoderBufferType, int> ReleaseDecoderBuffer;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void*, int> DecoderBeginFrame;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> DecoderEndFrame;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoDecoderBufferDesc*, int> SubmitDecoderBuffers;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoDecoderExtension*, int> DecoderExtension;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Vector4I*, void> VideoProcessorSetOutputTargetRect;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoColor*, void> VideoProcessorSetOutputBackgroundColor;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoProcessorColorSpace*, void> VideoProcessorSetOutputColorSpace;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoProcessorAlphaFillMode, uint, void> VideoProcessorSetOutputAlphaFillMode;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Vector2I, void> VideoProcessorSetOutputConstriction;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> VideoProcessorSetOutputStereoMode;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Guid*, uint, void*, int> VideoProcessorSetOutputExtension;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, Vector4I*, void> VideoProcessorGetOutputTargetRect;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, VideoColor*, void> VideoProcessorGetOutputBackgroundColor;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoProcessorColorSpace*, void> VideoProcessorGetOutputColorSpace;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoProcessorAlphaFillMode*, uint*, void> VideoProcessorGetOutputAlphaFillMode;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, Vector2I*, void> VideoProcessorGetOutputConstriction;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, void> VideoProcessorGetOutputStereoMode;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Guid*, uint, void*, int> VideoProcessorGetOutputExtension;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoFrameFormat, void> VideoProcessorSetStreamFrameFormat;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoProcessorColorSpace*, void> VideoProcessorSetStreamColorSpace;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoProcessorOutputRate, uint, DXGI.Rational*, void> VideoProcessorSetStreamOutputRate;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, Vector4I*, void> VideoProcessorSetStreamSourceRect;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, Vector4I*, void> VideoProcessorSetStreamDestRect;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, float, void> VideoProcessorSetStreamAlpha;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint*, void> VideoProcessorSetStreamPalette;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, DXGI.Rational*, DXGI.Rational*, void> VideoProcessorSetStreamPixelAspectRatio;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, float, float, void> VideoProcessorSetStreamLumaKey;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, VideoProcessorStereoFormat, uint, uint, VideoProcessorStereoFlipMode, int, void> VideoProcessorSetStreamStereoFormat;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void> VideoProcessorSetStreamAutoProcessingMode;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoProcessorFilter, uint, int, void> VideoProcessorSetStreamFilter;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Guid*, uint, void*, int> VideoProcessorSetStreamExtension;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoFrameFormat*, void> VideoProcessorGetStreamFrameFormat;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoProcessorColorSpace*, void> VideoProcessorGetStreamColorSpace;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoProcessorOutputRate*, uint*, DXGI.Rational*, void> VideoProcessorGetStreamOutputRate;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, Vector4I*, void> VideoProcessorGetStreamSourceRect;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, Vector4I*, void> VideoProcessorGetStreamDestRect;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, float*, void> VideoProcessorGetStreamAlpha;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint*, void> VideoProcessorGetStreamPalette;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, DXGI.Rational*, DXGI.Rational*, void> VideoProcessorGetStreamPixelAspectRatio;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, float*, float*, void> VideoProcessorGetStreamLumaKey;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, VideoProcessorStereoFormat*, uint*, uint*, VideoProcessorStereoFlipMode*, int*, void> VideoProcessorGetStreamStereoFormat;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, void> VideoProcessorGetStreamAutoProcessingMode;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoProcessorFilter, uint*, int*, void> VideoProcessorGetStreamFilter;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Guid*, uint, void*, int> VideoProcessorGetStreamExtension;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, uint, VideoProcessorStream*, int> VideoProcessorBlt;
		/// <summary>
		/// OFFSET 54
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, int> NegotiateCryptoSessionKeyExchange;
		/// <summary>
		/// OFFSET 55
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, uint, void*, void> EncryptionBlt;
		/// <summary>
		/// OFFSET 56
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, EncryptedBlockInfo*, uint, void*, uint, void*, void> DecryptionBlt;
		/// <summary>
		/// OFFSET 57
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, void> StartSessionKeyRefresh;
		/// <summary>
		/// OFFSET 58
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> FinishSessionKeyRefresh;
		/// <summary>
		/// OFFSET 59
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, int> GetEncryptionBltKey;
		/// <summary>
		/// OFFSET 60
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, int> NegotiateAuthenticatedChannelKeyExchange;
		/// <summary>
		/// OFFSET 61
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, uint, void*, int> QueryAuthenticatedChannel;
		/// <summary>
		/// OFFSET 62
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, AuthenticatedConfigureOutput*, int> ConfigureAuthenticatedChannel;
		/// <summary>
		/// OFFSET 63
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, VideoProcessorRotation, void> VideoProcessorSetStreamRotation;
		/// <summary>
		/// OFFSET 64
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, VideoProcessorRotation*, void> VideoProcessorGetStreamRotation;
		/// <summary>
		/// OFFSET 65
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, VideoDecoderBufferDesc1*, int> SubmitDecoderBuffers1;
		/// <summary>
		/// OFFSET 66
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, ulong*, int> GetDataForNewHardwareKey;
		/// <summary>
		/// OFFSET 67
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, CryptoSessionStatus*, int> CheckCryptoSessionStatus;
		/// <summary>
		/// OFFSET 68
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DXGI.ColorSpaceType, VideoSampleDesc*, uint, int> DecoderEnableDownsampling;
		/// <summary>
		/// OFFSET 69
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoSampleDesc*, int> DecoderUpdateDownsampling;
		/// <summary>
		/// OFFSET 70
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DXGI.ColorSpaceType, void> VideoProcessorSetOutputColorSpace1;
		/// <summary>
		/// OFFSET 71
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> VideoProcessorSetOutputShaderUsage;
		/// <summary>
		/// OFFSET 72
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DXGI.ColorSpaceType*, void> VideoProcessorGetOutputColorSpace1;
		/// <summary>
		/// OFFSET 73
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, void> VideoProcessorGetOutputShaderUsage;
		/// <summary>
		/// OFFSET 74
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, DXGI.ColorSpaceType, void> VideoProcessorSetStreamColorSpace1;
		/// <summary>
		/// OFFSET 75
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint, uint, void> VideoProcessorSetStreamMirror;
		/// <summary>
		/// OFFSET 76
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, DXGI.ColorSpaceType*, void> VideoProcessorGetStreamColorSpace1;
		/// <summary>
		/// OFFSET 77
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, uint*, uint*, void> VideoProcessorGetStreamMirror;
		/// <summary>
		/// OFFSET 78
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int> VideoProcessorGetBehaviorHints;
		/// <summary>
		/// OFFSET 79
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DXGI.HdrMetadataType, uint, void*, void> VideoProcessorSetOutputHDRMetaData;
		/// <summary>
		/// OFFSET 80
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DXGI.HdrMetadataType*, uint, void*, void> VideoProcessorGetOutputHDRMetaData;
		/// <summary>
		/// OFFSET 81
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, DXGI.HdrMetadataType, uint, void*, void> VideoProcessorSetStreamHDRMetaData;
		/// <summary>
		/// OFFSET 82
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, DXGI.HdrMetadataType*, uint, void*, void> VideoProcessorGetStreamHDRMetaData;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
