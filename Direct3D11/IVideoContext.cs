using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoContext</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface IVideoContext : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::GetDecoderBuffer (ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, UINT* pBufferSize, void** ppBuffer)</b><br/>
	/// </summary>
	/// <param name="pDecoder">_In_ <b>ID3D11VideoDecoder* pDecoder</b></param>
	/// <param name="type"><b>D3D11_VIDEO_DECODER_BUFFER_TYPE Type</b></param>
	/// <param name="pBufferSize">_Out_ <b>UINT* pBufferSize</b></param>
	/// <param name="ppBuffer">_Outptr_result_bytebuffer_(*pBufferSize) <b>void** ppBuffer</b></param>
	int GetDecoderBuffer<T0> (T0* pDecoder, VideoDecoderBufferType type, uint* pBufferSize, void** ppBuffer) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::GetDecoderBuffer (ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, UINT* pBufferSize, void** ppBuffer)</b><br/>
	/// </summary>
	/// <param name="pDecoder">_In_ <b>ID3D11VideoDecoder* pDecoder</b></param>
	/// <param name="type"><b>D3D11_VIDEO_DECODER_BUFFER_TYPE Type</b></param>
	/// <param name="pBufferSize">_Out_ <b>UINT* pBufferSize</b></param>
	/// <param name="ppBuffer">_Outptr_result_bytebuffer_(*pBufferSize) <b>void** ppBuffer</b></param>
	int GetDecoderBuffer<T0> (T0* pDecoder, VideoDecoderBufferType type, out uint pBufferSize, out void* ppBuffer) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::ReleaseDecoderBuffer (ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type)</b><br/>
	/// </summary>
	/// <param name="pDecoder">_In_ <b>ID3D11VideoDecoder* pDecoder</b></param>
	/// <param name="type">_In_ <b>D3D11_VIDEO_DECODER_BUFFER_TYPE Type</b></param>
	int ReleaseDecoderBuffer<T0> (T0* pDecoder, VideoDecoderBufferType type) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::DecoderBeginFrame (ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, UINT ContentKeySize, void* pContentKey)</b><br/>
	/// </summary>
	/// <param name="pDecoder">_In_ <b>ID3D11VideoDecoder* pDecoder</b></param>
	/// <param name="pView">_In_ <b>ID3D11VideoDecoderOutputView* pView</b></param>
	/// <param name="contentKeySize"><b>UINT ContentKeySize</b></param>
	/// <param name="pContentKey">_In_reads_bytes_opt_(ContentKeySize) <b>void* pContentKey</b></param>
	int DecoderBeginFrame<T0, T1> (T0* pDecoder, T1* pView, uint contentKeySize, void* pContentKey) where T0 : unmanaged, IVideoDecoder where T1 : unmanaged, IVideoDecoderOutputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::DecoderEndFrame (ID3D11VideoDecoder* pDecoder)</b><br/>
	/// </summary>
	/// <param name="pDecoder">_In_ <b>ID3D11VideoDecoder* pDecoder</b></param>
	int DecoderEndFrame<T0> (T0* pDecoder) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::SubmitDecoderBuffers (ID3D11VideoDecoder* pDecoder, UINT NumBuffers, D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc)</b><br/>
	/// </summary>
	/// <param name="pDecoder">_In_ <b>ID3D11VideoDecoder* pDecoder</b></param>
	/// <param name="numBuffers">_In_ <b>UINT NumBuffers</b></param>
	/// <param name="pBufferDesc">_In_reads_(NumBuffers) <b>D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc</b></param>
	int SubmitDecoderBuffers<T0> (T0* pDecoder, uint numBuffers, VideoDecoderBufferDesc* pBufferDesc) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>APP_DEPRECATED_HRESULT ID3D11VideoContext::DecoderExtension (ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_EXTENSION* pExtensionData)</b><br/>
	/// </summary>
	/// <param name="pDecoder">_In_ <b>ID3D11VideoDecoder* pDecoder</b></param>
	/// <param name="pExtensionData">_In_ <b>D3D11_VIDEO_DECODER_EXTENSION* pExtensionData</b></param>
	int DecoderExtension<T0> (T0* pDecoder, VideoDecoderExtension* pExtensionData) where T0 : unmanaged, IVideoDecoder;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetOutputTargetRect (ID3D11VideoProcessor* pVideoProcessor, BOOL Enable, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="pRect">_In_opt_ <b>RECT* pRect</b></param>
	void VideoProcessorSetOutputTargetRect<T0> (T0* pVideoProcessor, bool enable, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetOutputBackgroundColor (ID3D11VideoProcessor* pVideoProcessor, BOOL YCbCr, D3D11_VIDEO_COLOR* pColor)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="yCbCr">_In_ <b>BOOL YCbCr</b></param>
	/// <param name="pColor">_In_ <b>D3D11_VIDEO_COLOR* pColor</b></param>
	void VideoProcessorSetOutputBackgroundColor<T0> (T0* pVideoProcessor, bool yCbCr, VideoColor* pColor) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetOutputColorSpace (ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pColorSpace">_In_ <b>D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace</b></param>
	void VideoProcessorSetOutputColorSpace<T0> (T0* pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetOutputAlphaFillMode (ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, UINT StreamIndex)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="alphaFillMode">_In_ <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	void VideoProcessorSetOutputAlphaFillMode<T0> (T0* pVideoProcessor, VideoProcessorAlphaFillMode alphaFillMode, uint streamIndex) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetOutputConstriction (ID3D11VideoProcessor* pVideoProcessor, BOOL Enable, SIZE Size)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="size">_In_ <b>SIZE Size</b></param>
	void VideoProcessorSetOutputConstriction<T0> (T0* pVideoProcessor, bool enable, Vector2I size) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetOutputStereoMode (ID3D11VideoProcessor* pVideoProcessor, BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	void VideoProcessorSetOutputStereoMode<T0> (T0* pVideoProcessor, bool enable) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>APP_DEPRECATED_HRESULT ID3D11VideoContext::VideoProcessorSetOutputExtension (ID3D11VideoProcessor* pVideoProcessor, GUID* pExtensionGuid, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pExtensionGuid">_In_ <b>GUID* pExtensionGuid</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_In_ <b>void* pData</b></param>
	int VideoProcessorSetOutputExtension<T0> (T0* pVideoProcessor, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputTargetRect (ID3D11VideoProcessor* pVideoProcessor, BOOL* Enabled, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="enabled">_Out_ <b>BOOL* Enabled</b></param>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	void VideoProcessorGetOutputTargetRect<T0> (T0* pVideoProcessor, uint* enabled, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputTargetRect (ID3D11VideoProcessor* pVideoProcessor, BOOL* Enabled, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="enabled">_Out_ <b>BOOL* Enabled</b></param>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	void VideoProcessorGetOutputTargetRect<T0> (T0* pVideoProcessor, out bool enabled, out Vector4I pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputBackgroundColor (ID3D11VideoProcessor* pVideoProcessor, BOOL* pYCbCr, D3D11_VIDEO_COLOR* pColor)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pYCbCr">_Out_ <b>BOOL* pYCbCr</b></param>
	/// <param name="pColor">_Out_ <b>D3D11_VIDEO_COLOR* pColor</b></param>
	void VideoProcessorGetOutputBackgroundColor<T0> (T0* pVideoProcessor, uint* pYCbCr, VideoColor* pColor) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputBackgroundColor (ID3D11VideoProcessor* pVideoProcessor, BOOL* pYCbCr, D3D11_VIDEO_COLOR* pColor)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pYCbCr">_Out_ <b>BOOL* pYCbCr</b></param>
	/// <param name="pColor">_Out_ <b>D3D11_VIDEO_COLOR* pColor</b></param>
	void VideoProcessorGetOutputBackgroundColor<T0> (T0* pVideoProcessor, out bool pYCbCr, out VideoColor pColor) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputColorSpace (ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pColorSpace">_Out_ <b>D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace</b></param>
	void VideoProcessorGetOutputColorSpace<T0> (T0* pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputColorSpace (ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pColorSpace">_Out_ <b>D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace</b></param>
	void VideoProcessorGetOutputColorSpace<T0> (T0* pVideoProcessor, out VideoProcessorColorSpace pColorSpace) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputAlphaFillMode (ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, UINT* pStreamIndex)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pAlphaFillMode">_Out_ <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode</b></param>
	/// <param name="pStreamIndex">_Out_ <b>UINT* pStreamIndex</b></param>
	void VideoProcessorGetOutputAlphaFillMode<T0> (T0* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputAlphaFillMode (ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, UINT* pStreamIndex)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pAlphaFillMode">_Out_ <b>D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode</b></param>
	/// <param name="pStreamIndex">_Out_ <b>UINT* pStreamIndex</b></param>
	void VideoProcessorGetOutputAlphaFillMode<T0> (T0* pVideoProcessor, out VideoProcessorAlphaFillMode pAlphaFillMode, out uint pStreamIndex) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputConstriction (ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled, SIZE* pSize)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pSize">_Out_ <b>SIZE* pSize</b></param>
	void VideoProcessorGetOutputConstriction<T0> (T0* pVideoProcessor, uint* pEnabled, Vector2I* pSize) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputConstriction (ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled, SIZE* pSize)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pSize">_Out_ <b>SIZE* pSize</b></param>
	void VideoProcessorGetOutputConstriction<T0> (T0* pVideoProcessor, out bool pEnabled, out Vector2I pSize) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputStereoMode (ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	void VideoProcessorGetOutputStereoMode<T0> (T0* pVideoProcessor, uint* pEnabled) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetOutputStereoMode (ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	void VideoProcessorGetOutputStereoMode<T0> (T0* pVideoProcessor, out bool pEnabled) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>APP_DEPRECATED_HRESULT ID3D11VideoContext::VideoProcessorGetOutputExtension (ID3D11VideoProcessor* pVideoProcessor, GUID* pExtensionGuid, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pExtensionGuid">_In_ <b>GUID* pExtensionGuid</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_Out_writes_bytes_(DataSize) <b>void* pData</b></param>
	int VideoProcessorGetOutputExtension<T0> (T0* pVideoProcessor, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamFrameFormat (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="frameFormat">_In_ <b>D3D11_VIDEO_FRAME_FORMAT FrameFormat</b></param>
	void VideoProcessorSetStreamFrameFormat<T0> (T0* pVideoProcessor, uint streamIndex, VideoFrameFormat frameFormat) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamColorSpace (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pColorSpace">_In_ <b>D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace</b></param>
	void VideoProcessorSetStreamColorSpace<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamOutputRate (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, BOOL RepeatFrame, DXGI_RATIONAL* pCustomRate)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="outputRate">_In_ <b>D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate</b></param>
	/// <param name="repeatFrame">_In_ <b>BOOL RepeatFrame</b></param>
	/// <param name="pCustomRate">_In_opt_ <b>DXGI_RATIONAL* pCustomRate</b></param>
	void VideoProcessorSetStreamOutputRate<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorOutputRate outputRate, bool repeatFrame, DXGI.Rational* pCustomRate) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamSourceRect (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="pRect">_In_opt_ <b>RECT* pRect</b></param>
	void VideoProcessorSetStreamSourceRect<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamDestRect (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="pRect">_In_opt_ <b>RECT* pRect</b></param>
	void VideoProcessorSetStreamDestRect<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamAlpha (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable, FLOAT Alpha)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="alpha">_In_ <b>FLOAT Alpha</b></param>
	void VideoProcessorSetStreamAlpha<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, float alpha) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamPalette (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, UINT Count, UINT* pEntries)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="count">_In_ <b>UINT Count</b></param>
	/// <param name="pEntries">_In_reads_opt_(Count) <b>UINT* pEntries</b></param>
	void VideoProcessorSetStreamPalette<T0> (T0* pVideoProcessor, uint streamIndex, uint count, uint* pEntries) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamPixelAspectRatio (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable, DXGI_RATIONAL* pSourceAspectRatio, DXGI_RATIONAL* pDestinationAspectRatio)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="pSourceAspectRatio">_In_opt_ <b>DXGI_RATIONAL* pSourceAspectRatio</b></param>
	/// <param name="pDestinationAspectRatio">_In_opt_ <b>DXGI_RATIONAL* pDestinationAspectRatio</b></param>
	void VideoProcessorSetStreamPixelAspectRatio<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, DXGI.Rational* pSourceAspectRatio, DXGI.Rational* pDestinationAspectRatio) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamLumaKey (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable, FLOAT Lower, FLOAT Upper)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="lower">_In_ <b>FLOAT Lower</b></param>
	/// <param name="upper">_In_ <b>FLOAT Upper</b></param>
	void VideoProcessorSetStreamLumaKey<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, float lower, float upper) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamStereoFormat (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, BOOL LeftViewFrame0, BOOL BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="format">_In_ <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format</b></param>
	/// <param name="leftViewFrame0">_In_ <b>BOOL LeftViewFrame0</b></param>
	/// <param name="baseViewFrame0">_In_ <b>BOOL BaseViewFrame0</b></param>
	/// <param name="flipMode">_In_ <b>D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode</b></param>
	/// <param name="monoOffset">_In_ <b>int MonoOffset</b></param>
	void VideoProcessorSetStreamStereoFormat<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, VideoProcessorStereoFormat format, bool leftViewFrame0, bool baseViewFrame0, VideoProcessorStereoFlipMode flipMode, int monoOffset) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamAutoProcessingMode (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	void VideoProcessorSetStreamAutoProcessingMode<T0> (T0* pVideoProcessor, uint streamIndex, bool enable) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamFilter (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL Enable, int Level)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="filter">_In_ <b>D3D11_VIDEO_PROCESSOR_FILTER Filter</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="level">_In_ <b>int Level</b></param>
	void VideoProcessorSetStreamFilter<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorFilter filter, bool enable, int level) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>APP_DEPRECATED_HRESULT ID3D11VideoContext::VideoProcessorSetStreamExtension (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, GUID* pExtensionGuid, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pExtensionGuid">_In_ <b>GUID* pExtensionGuid</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_In_ <b>void* pData</b></param>
	int VideoProcessorSetStreamExtension<T0> (T0* pVideoProcessor, uint streamIndex, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamFrameFormat (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pFrameFormat">_Out_ <b>D3D11_VIDEO_FRAME_FORMAT* pFrameFormat</b></param>
	void VideoProcessorGetStreamFrameFormat<T0> (T0* pVideoProcessor, uint streamIndex, VideoFrameFormat* pFrameFormat) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamFrameFormat (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pFrameFormat">_Out_ <b>D3D11_VIDEO_FRAME_FORMAT* pFrameFormat</b></param>
	void VideoProcessorGetStreamFrameFormat<T0> (T0* pVideoProcessor, uint streamIndex, out VideoFrameFormat pFrameFormat) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamColorSpace (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pColorSpace">_Out_ <b>D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace</b></param>
	void VideoProcessorGetStreamColorSpace<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorColorSpace* pColorSpace) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamColorSpace (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pColorSpace">_Out_ <b>D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace</b></param>
	void VideoProcessorGetStreamColorSpace<T0> (T0* pVideoProcessor, uint streamIndex, out VideoProcessorColorSpace pColorSpace) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamOutputRate (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, BOOL* pRepeatFrame, DXGI_RATIONAL* pCustomRate)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pOutputRate">_Out_ <b>D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate</b></param>
	/// <param name="pRepeatFrame">_Out_ <b>BOOL* pRepeatFrame</b></param>
	/// <param name="pCustomRate">_Out_ <b>DXGI_RATIONAL* pCustomRate</b></param>
	void VideoProcessorGetStreamOutputRate<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorOutputRate* pOutputRate, uint* pRepeatFrame, DXGI.Rational* pCustomRate) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamOutputRate (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, BOOL* pRepeatFrame, DXGI_RATIONAL* pCustomRate)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pOutputRate">_Out_ <b>D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate</b></param>
	/// <param name="pRepeatFrame">_Out_ <b>BOOL* pRepeatFrame</b></param>
	/// <param name="pCustomRate">_Out_ <b>DXGI_RATIONAL* pCustomRate</b></param>
	void VideoProcessorGetStreamOutputRate<T0> (T0* pVideoProcessor, uint streamIndex, out VideoProcessorOutputRate pOutputRate, out bool pRepeatFrame, out DXGI.Rational pCustomRate) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamSourceRect (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	void VideoProcessorGetStreamSourceRect<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamSourceRect (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	void VideoProcessorGetStreamSourceRect<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out Vector4I pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamDestRect (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	void VideoProcessorGetStreamDestRect<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, Vector4I* pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamDestRect (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	void VideoProcessorGetStreamDestRect<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out Vector4I pRect) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamAlpha (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, FLOAT* pAlpha)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pAlpha">_Out_ <b>FLOAT* pAlpha</b></param>
	void VideoProcessorGetStreamAlpha<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, float* pAlpha) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamAlpha (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, FLOAT* pAlpha)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pAlpha">_Out_ <b>FLOAT* pAlpha</b></param>
	void VideoProcessorGetStreamAlpha<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out float pAlpha) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamPalette (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, UINT Count, UINT* pEntries)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="count">_In_ <b>UINT Count</b></param>
	/// <param name="pEntries">_Out_writes_(Count) <b>UINT* pEntries</b></param>
	void VideoProcessorGetStreamPalette<T0> (T0* pVideoProcessor, uint streamIndex, uint count, uint* pEntries) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamPixelAspectRatio (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, DXGI_RATIONAL* pSourceAspectRatio, DXGI_RATIONAL* pDestinationAspectRatio)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pSourceAspectRatio">_Out_ <b>DXGI_RATIONAL* pSourceAspectRatio</b></param>
	/// <param name="pDestinationAspectRatio">_Out_ <b>DXGI_RATIONAL* pDestinationAspectRatio</b></param>
	void VideoProcessorGetStreamPixelAspectRatio<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, DXGI.Rational* pSourceAspectRatio, DXGI.Rational* pDestinationAspectRatio) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamPixelAspectRatio (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, DXGI_RATIONAL* pSourceAspectRatio, DXGI_RATIONAL* pDestinationAspectRatio)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pSourceAspectRatio">_Out_ <b>DXGI_RATIONAL* pSourceAspectRatio</b></param>
	/// <param name="pDestinationAspectRatio">_Out_ <b>DXGI_RATIONAL* pDestinationAspectRatio</b></param>
	void VideoProcessorGetStreamPixelAspectRatio<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out DXGI.Rational pSourceAspectRatio, out DXGI.Rational pDestinationAspectRatio) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamLumaKey (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, FLOAT* pLower, FLOAT* pUpper)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pLower">_Out_ <b>FLOAT* pLower</b></param>
	/// <param name="pUpper">_Out_ <b>FLOAT* pUpper</b></param>
	void VideoProcessorGetStreamLumaKey<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled, float* pLower, float* pUpper) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamLumaKey (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled, FLOAT* pLower, FLOAT* pUpper)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pLower">_Out_ <b>FLOAT* pLower</b></param>
	/// <param name="pUpper">_Out_ <b>FLOAT* pUpper</b></param>
	void VideoProcessorGetStreamLumaKey<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled, out float pLower, out float pUpper) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamStereoFormat (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, BOOL* pLeftViewFrame0, BOOL* pBaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, int* MonoOffset)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnable">_Out_ <b>BOOL* pEnable</b></param>
	/// <param name="pFormat">_Out_ <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat</b></param>
	/// <param name="pLeftViewFrame0">_Out_ <b>BOOL* pLeftViewFrame0</b></param>
	/// <param name="pBaseViewFrame0">_Out_ <b>BOOL* pBaseViewFrame0</b></param>
	/// <param name="pFlipMode">_Out_ <b>D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode</b></param>
	/// <param name="monoOffset">_Out_ <b>int* MonoOffset</b></param>
	void VideoProcessorGetStreamStereoFormat<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnable, VideoProcessorStereoFormat* pFormat, uint* pLeftViewFrame0, uint* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* monoOffset) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamStereoFormat (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, BOOL* pLeftViewFrame0, BOOL* pBaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, int* MonoOffset)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnable">_Out_ <b>BOOL* pEnable</b></param>
	/// <param name="pFormat">_Out_ <b>D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat</b></param>
	/// <param name="pLeftViewFrame0">_Out_ <b>BOOL* pLeftViewFrame0</b></param>
	/// <param name="pBaseViewFrame0">_Out_ <b>BOOL* pBaseViewFrame0</b></param>
	/// <param name="pFlipMode">_Out_ <b>D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode</b></param>
	/// <param name="monoOffset">_Out_ <b>int* MonoOffset</b></param>
	void VideoProcessorGetStreamStereoFormat<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnable, out VideoProcessorStereoFormat pFormat, out bool pLeftViewFrame0, out bool pBaseViewFrame0, out VideoProcessorStereoFlipMode pFlipMode, out int monoOffset) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamAutoProcessingMode (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	void VideoProcessorGetStreamAutoProcessingMode<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnabled) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamAutoProcessingMode (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnabled)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	void VideoProcessorGetStreamAutoProcessingMode<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnabled) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamFilter (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL* pEnabled, int* pLevel)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="filter">_In_ <b>D3D11_VIDEO_PROCESSOR_FILTER Filter</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pLevel">_Out_ <b>int* pLevel</b></param>
	void VideoProcessorGetStreamFilter<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorFilter filter, uint* pEnabled, int* pLevel) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamFilter (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL* pEnabled, int* pLevel)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="filter">_In_ <b>D3D11_VIDEO_PROCESSOR_FILTER Filter</b></param>
	/// <param name="pEnabled">_Out_ <b>BOOL* pEnabled</b></param>
	/// <param name="pLevel">_Out_ <b>int* pLevel</b></param>
	void VideoProcessorGetStreamFilter<T0> (T0* pVideoProcessor, uint streamIndex, VideoProcessorFilter filter, out bool pEnabled, out int pLevel) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>APP_DEPRECATED_HRESULT ID3D11VideoContext::VideoProcessorGetStreamExtension (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, GUID* pExtensionGuid, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pExtensionGuid">_In_ <b>GUID* pExtensionGuid</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_Out_writes_bytes_(DataSize) <b>void* pData</b></param>
	int VideoProcessorGetStreamExtension<T0> (T0* pVideoProcessor, uint streamIndex, Guid* pExtensionGuid, uint dataSize, void* pData) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::VideoProcessorBlt (ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, UINT OutputFrame, UINT StreamCount, D3D11_VIDEO_PROCESSOR_STREAM* pStreams)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pView">_In_ <b>ID3D11VideoProcessorOutputView* pView</b></param>
	/// <param name="outputFrame">_In_ <b>UINT OutputFrame</b></param>
	/// <param name="streamCount">_In_ <b>UINT StreamCount</b></param>
	/// <param name="pStreams">_In_reads_(StreamCount) <b>D3D11_VIDEO_PROCESSOR_STREAM* pStreams</b></param>
	int VideoProcessorBlt<T0, T1> (T0* pVideoProcessor, T1* pView, uint outputFrame, uint streamCount, VideoProcessorStream* pStreams) where T0 : unmanaged, IVideoProcessor where T1 : unmanaged, IVideoProcessorOutputView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::NegotiateCryptoSessionKeyExchange (ID3D11CryptoSession* pCryptoSession, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="pCryptoSession">_In_ <b>ID3D11CryptoSession* pCryptoSession</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_Inout_updates_bytes_(DataSize) <b>void* pData</b></param>
	int NegotiateCryptoSessionKeyExchange<T0> (T0* pCryptoSession, uint dataSize, void* pData) where T0 : unmanaged, ICryptoSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::EncryptionBlt (ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, UINT IVSize, void* pIV)</b><br/>
	/// </summary>
	/// <param name="pCryptoSession">_In_ <b>ID3D11CryptoSession* pCryptoSession</b></param>
	/// <param name="pSrcSurface">_In_ <b>ID3D11Texture2D* pSrcSurface</b></param>
	/// <param name="pDstSurface">_In_ <b>ID3D11Texture2D* pDstSurface</b></param>
	/// <param name="iVSize">_In_ <b>UINT IVSize</b></param>
	/// <param name="pIV">_Inout_opt_bytecount_(IVSize) <b>void* pIV</b></param>
	void EncryptionBlt<T0, T1, T2> (T0* pCryptoSession, T1* pSrcSurface, T2* pDstSurface, uint iVSize, void* pIV) where T0 : unmanaged, ICryptoSession where T1 : unmanaged, ITexture2D where T2 : unmanaged, ITexture2D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::DecryptionBlt (ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, UINT ContentKeySize, void* pContentKey, UINT IVSize, void* pIV)</b><br/>
	/// </summary>
	/// <param name="pCryptoSession">_In_ <b>ID3D11CryptoSession* pCryptoSession</b></param>
	/// <param name="pSrcSurface">_In_ <b>ID3D11Texture2D* pSrcSurface</b></param>
	/// <param name="pDstSurface">_In_ <b>ID3D11Texture2D* pDstSurface</b></param>
	/// <param name="pEncryptedBlockInfo">_In_opt_ <b>D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo</b></param>
	/// <param name="contentKeySize">_In_ <b>UINT ContentKeySize</b></param>
	/// <param name="pContentKey">_In_reads_bytes_opt_(ContentKeySize) <b>void* pContentKey</b></param>
	/// <param name="iVSize">_In_ <b>UINT IVSize</b></param>
	/// <param name="pIV">_Inout_opt_bytecount_(IVSize) <b>void* pIV</b></param>
	void DecryptionBlt<T0, T1, T2> (T0* pCryptoSession, T1* pSrcSurface, T2* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint contentKeySize, void* pContentKey, uint iVSize, void* pIV) where T0 : unmanaged, ICryptoSession where T1 : unmanaged, ITexture2D where T2 : unmanaged, ITexture2D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::StartSessionKeyRefresh (ID3D11CryptoSession* pCryptoSession, UINT RandomNumberSize, void* pRandomNumber)</b><br/>
	/// </summary>
	/// <param name="pCryptoSession">_In_ <b>ID3D11CryptoSession* pCryptoSession</b></param>
	/// <param name="randomNumberSize">_In_ <b>UINT RandomNumberSize</b></param>
	/// <param name="pRandomNumber">_Out_writes_bytes_(RandomNumberSize) <b>void* pRandomNumber</b></param>
	void StartSessionKeyRefresh<T0> (T0* pCryptoSession, uint randomNumberSize, void* pRandomNumber) where T0 : unmanaged, ICryptoSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::FinishSessionKeyRefresh (ID3D11CryptoSession* pCryptoSession)</b><br/>
	/// </summary>
	/// <param name="pCryptoSession">_In_ <b>ID3D11CryptoSession* pCryptoSession</b></param>
	void FinishSessionKeyRefresh<T0> (T0* pCryptoSession) where T0 : unmanaged, ICryptoSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::GetEncryptionBltKey (ID3D11CryptoSession* pCryptoSession, UINT KeySize, void* pReadbackKey)</b><br/>
	/// </summary>
	/// <param name="pCryptoSession">_In_ <b>ID3D11CryptoSession* pCryptoSession</b></param>
	/// <param name="keySize">_In_ <b>UINT KeySize</b></param>
	/// <param name="pReadbackKey">_Out_writes_bytes_(KeySize) <b>void* pReadbackKey</b></param>
	int GetEncryptionBltKey<T0> (T0* pCryptoSession, uint keySize, void* pReadbackKey) where T0 : unmanaged, ICryptoSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::NegotiateAuthenticatedChannelKeyExchange (ID3D11AuthenticatedChannel* pChannel, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="pChannel">_In_ <b>ID3D11AuthenticatedChannel* pChannel</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_Inout_updates_bytes_(DataSize) <b>void* pData</b></param>
	int NegotiateAuthenticatedChannelKeyExchange<T0> (T0* pChannel, uint dataSize, void* pData) where T0 : unmanaged, IAuthenticatedChannel;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::QueryAuthenticatedChannel (ID3D11AuthenticatedChannel* pChannel, UINT InputSize, void* pInput, UINT OutputSize, void* pOutput)</b><br/>
	/// </summary>
	/// <param name="pChannel">_In_ <b>ID3D11AuthenticatedChannel* pChannel</b></param>
	/// <param name="inputSize">_In_ <b>UINT InputSize</b></param>
	/// <param name="pInput">_In_reads_bytes_(InputSize) <b>void* pInput</b></param>
	/// <param name="outputSize">_In_ <b>UINT OutputSize</b></param>
	/// <param name="pOutput">_Out_writes_bytes_(OutputSize) <b>void* pOutput</b></param>
	int QueryAuthenticatedChannel<T0> (T0* pChannel, uint inputSize, void* pInput, uint outputSize, void* pOutput) where T0 : unmanaged, IAuthenticatedChannel;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::ConfigureAuthenticatedChannel (ID3D11AuthenticatedChannel* pChannel, UINT InputSize, void* pInput, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)</b><br/>
	/// </summary>
	/// <param name="pChannel">_In_ <b>ID3D11AuthenticatedChannel* pChannel</b></param>
	/// <param name="inputSize">_In_ <b>UINT InputSize</b></param>
	/// <param name="pInput">_In_reads_bytes_(InputSize) <b>void* pInput</b></param>
	/// <param name="pOutput">_Out_ <b>D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput</b></param>
	int ConfigureAuthenticatedChannel<T0> (T0* pChannel, uint inputSize, void* pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged, IAuthenticatedChannel;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoContext::ConfigureAuthenticatedChannel (ID3D11AuthenticatedChannel* pChannel, UINT InputSize, void* pInput, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)</b><br/>
	/// </summary>
	/// <param name="pChannel">_In_ <b>ID3D11AuthenticatedChannel* pChannel</b></param>
	/// <param name="inputSize">_In_ <b>UINT InputSize</b></param>
	/// <param name="pInput">_In_reads_bytes_(InputSize) <b>void* pInput</b></param>
	/// <param name="pOutput">_Out_ <b>D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput</b></param>
	int ConfigureAuthenticatedChannel<T0> (T0* pChannel, uint inputSize, void* pInput, out AuthenticatedConfigureOutput pOutput) where T0 : unmanaged, IAuthenticatedChannel;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorSetStreamRotation (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="enable">_In_ <b>BOOL Enable</b></param>
	/// <param name="rotation">_In_ <b>D3D11_VIDEO_PROCESSOR_ROTATION Rotation</b></param>
	void VideoProcessorSetStreamRotation<T0> (T0* pVideoProcessor, uint streamIndex, bool enable, VideoProcessorRotation rotation) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamRotation (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnable">_Out_ <b>BOOL* pEnable</b></param>
	/// <param name="pRotation">_Out_ <b>D3D11_VIDEO_PROCESSOR_ROTATION* pRotation</b></param>
	void VideoProcessorGetStreamRotation<T0> (T0* pVideoProcessor, uint streamIndex, uint* pEnable, VideoProcessorRotation* pRotation) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoContext::VideoProcessorGetStreamRotation (ID3D11VideoProcessor* pVideoProcessor, UINT StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D11VideoProcessor* pVideoProcessor</b></param>
	/// <param name="streamIndex">_In_ <b>UINT StreamIndex</b></param>
	/// <param name="pEnable">_Out_ <b>BOOL* pEnable</b></param>
	/// <param name="pRotation">_Out_ <b>D3D11_VIDEO_PROCESSOR_ROTATION* pRotation</b></param>
	void VideoProcessorGetStreamRotation<T0> (T0* pVideoProcessor, uint streamIndex, out bool pEnable, out VideoProcessorRotation pRotation) where T0 : unmanaged, IVideoProcessor;
}

/// <summary>
/// Instance of <b>ID3D11VideoContext</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct VideoContext : IVideoContext {
//unsafe public readonly struct IVideoContextObj : IVideoContext {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoContext* GetCurrentPointer () => (VideoContext*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoContextObj* GetCurrentPointer () => (IVideoContextObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x61f21c45, 0x3c0e, 0x4a74, 0x9c, 0xea, 0x67, 0x10, 0x0d, 0x9a, 0xd5, 0xe4);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
