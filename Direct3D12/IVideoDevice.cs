using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VideoDevice</b> : IUnknown<br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public interface IVideoDevice : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice::CheckFeatureSupport (D3D12_FEATURE_VIDEO FeatureVideo, void* pFeatureSupportData, UINT FeatureSupportDataSize)</b><br/>
	/// </summary>
	/// <param name="featureVideo"><b>D3D12_FEATURE_VIDEO FeatureVideo</b></param>
	/// <param name="pFeatureSupportData">_Inout_updates_bytes_(FeatureSupportDataSize) <b>void* pFeatureSupportData</b></param>
	/// <param name="featureSupportDataSize"><b>UINT FeatureSupportDataSize</b></param>
	int CheckFeatureSupport (FeatureVideo featureVideo, void* pFeatureSupportData, uint featureSupportDataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice::CreateVideoDecoder (D3D12_VIDEO_DECODER_DESC* pDesc, REFIID riid, void** ppVideoDecoder)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoder">_COM_Outptr_ <b>void** ppVideoDecoder</b></param>
	int CreateVideoDecoder (VideoDecoderDesc* pDesc, Guid riid, void** ppVideoDecoder);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice::CreateVideoDecoder (D3D12_VIDEO_DECODER_DESC* pDesc, REFIID riid, void** ppVideoDecoder)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoder">_COM_Outptr_ <b>void** ppVideoDecoder</b></param>
	int CreateVideoDecoder (VideoDecoderDesc* pDesc, Guid riid, out void* ppVideoDecoder);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice::CreateVideoDecoderHeap (D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, REFIID riid, void** ppVideoDecoderHeap)</b><br/>
	/// </summary>
	/// <param name="pVideoDecoderHeapDesc">_In_ <b>D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoderHeap">_COM_Outptr_ <b>void** ppVideoDecoderHeap</b></param>
	int CreateVideoDecoderHeap (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid riid, void** ppVideoDecoderHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice::CreateVideoDecoderHeap (D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, REFIID riid, void** ppVideoDecoderHeap)</b><br/>
	/// </summary>
	/// <param name="pVideoDecoderHeapDesc">_In_ <b>D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoderHeap">_COM_Outptr_ <b>void** ppVideoDecoderHeap</b></param>
	int CreateVideoDecoderHeap (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid riid, out void* ppVideoDecoderHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice::CreateVideoProcessor (UINT NodeMask, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, UINT NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, REFIID riid, void** ppVideoProcessor)</b><br/>
	/// </summary>
	/// <param name="nodeMask"><b>UINT NodeMask</b></param>
	/// <param name="pOutputStreamDesc">_In_ <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc</b></param>
	/// <param name="numInputStreamDescs"><b>UINT NumInputStreamDescs</b></param>
	/// <param name="pInputStreamDescs">_In_reads_(NumInputStreamDescs) <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoProcessor">_COM_Outptr_ <b>void** ppVideoProcessor</b></param>
	int CreateVideoProcessor (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid riid, void** ppVideoProcessor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice::CreateVideoProcessor (UINT NodeMask, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, UINT NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, REFIID riid, void** ppVideoProcessor)</b><br/>
	/// </summary>
	/// <param name="nodeMask"><b>UINT NodeMask</b></param>
	/// <param name="pOutputStreamDesc">_In_ <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc</b></param>
	/// <param name="numInputStreamDescs"><b>UINT NumInputStreamDescs</b></param>
	/// <param name="pInputStreamDescs">_In_reads_(NumInputStreamDescs) <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoProcessor">_COM_Outptr_ <b>void** ppVideoProcessor</b></param>
	int CreateVideoProcessor (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid riid, out void* ppVideoProcessor);
}

/// <summary>
/// Instance of <b>ID3D12VideoDevice</b><br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public readonly struct VideoDevice : IVideoDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoDevice* GetCurrentPointer () => (VideoDevice*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1f052807, 0x0b46, 0x4acc, 0x8a, 0x89, 0x36, 0x4f, 0x79, 0x37, 0x18, 0xa4);

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
	public readonly int CheckFeatureSupport (FeatureVideo featureVideo, void* pFeatureSupportData, uint featureSupportDataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckFeatureSupport (ptr, featureVideo, pFeatureSupportData, featureSupportDataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoder (VideoDecoderDesc* pDesc, Guid riid, void** ppVideoDecoder) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoder (ptr, pDesc, riid, ppVideoDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoder (VideoDecoderDesc* pDesc, Guid riid, out void* ppVideoDecoder) {
		fixed (void** _ppVideoDecoder = &ppVideoDecoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoder (ptr, pDesc, riid, _ppVideoDecoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoderHeap (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid riid, void** ppVideoDecoderHeap) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoderHeap (ptr, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoderHeap (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid riid, out void* ppVideoDecoderHeap) {
		fixed (void** _ppVideoDecoderHeap = &ppVideoDecoderHeap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoderHeap (ptr, pVideoDecoderHeapDesc, riid, _ppVideoDecoderHeap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessor (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid riid, void** ppVideoProcessor) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessor (ptr, nodeMask, pOutputStreamDesc, numInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessor (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid riid, out void* ppVideoProcessor) {
		fixed (void** _ppVideoProcessor = &ppVideoProcessor) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessor (ptr, nodeMask, pOutputStreamDesc, numInputStreamDescs, pInputStreamDescs, riid, _ppVideoProcessor);
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
		public readonly delegate* unmanaged[Stdcall]<void*, FeatureVideo, void*, uint, int> CheckFeatureSupport;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, Guid, void**, int> CreateVideoDecoder;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderHeapDesc*, Guid, void**, int> CreateVideoDecoderHeap;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid, void**, int> CreateVideoProcessor;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
