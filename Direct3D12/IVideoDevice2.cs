using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VideoDevice2</b> : ID3D12VideoDevice1<br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public interface IVideoDevice2 : IVideoDevice1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoDecoder1 (D3D12_VIDEO_DECODER_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoDecoder)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoder">_COM_Outptr_ <b>void** ppVideoDecoder</b></param>
	int CreateVideoDecoder1<T0> (VideoDecoderDesc* pDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoDecoder) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoDecoder1 (D3D12_VIDEO_DECODER_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoDecoder)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_DECODER_DESC* pDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoder">_COM_Outptr_ <b>void** ppVideoDecoder</b></param>
	int CreateVideoDecoder1<T0> (VideoDecoderDesc* pDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoDecoder) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoDecoderHeap1 (D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoDecoderHeap)</b><br/>
	/// </summary>
	/// <param name="pVideoDecoderHeapDesc">_In_ <b>D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoderHeap">_COM_Outptr_ <b>void** ppVideoDecoderHeap</b></param>
	int CreateVideoDecoderHeap1<T0> (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoDecoderHeap) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoDecoderHeap1 (D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoDecoderHeap)</b><br/>
	/// </summary>
	/// <param name="pVideoDecoderHeapDesc">_In_ <b>D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoDecoderHeap">_COM_Outptr_ <b>void** ppVideoDecoderHeap</b></param>
	int CreateVideoDecoderHeap1<T0> (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoDecoderHeap) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoProcessor1 (UINT NodeMask, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, UINT NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoProcessor)</b><br/>
	/// </summary>
	/// <param name="nodeMask"><b>UINT NodeMask</b></param>
	/// <param name="pOutputStreamDesc">_In_ <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc</b></param>
	/// <param name="numInputStreamDescs"><b>UINT NumInputStreamDescs</b></param>
	/// <param name="pInputStreamDescs">_In_reads_(NumInputStreamDescs) <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoProcessor">_COM_Outptr_ <b>void** ppVideoProcessor</b></param>
	int CreateVideoProcessor1<T0> (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, T0* pProtectedResourceSession, Guid riid, void** ppVideoProcessor) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoProcessor1 (UINT NodeMask, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, UINT NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoProcessor)</b><br/>
	/// </summary>
	/// <param name="nodeMask"><b>UINT NodeMask</b></param>
	/// <param name="pOutputStreamDesc">_In_ <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc</b></param>
	/// <param name="numInputStreamDescs"><b>UINT NumInputStreamDescs</b></param>
	/// <param name="pInputStreamDescs">_In_reads_(NumInputStreamDescs) <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoProcessor">_COM_Outptr_ <b>void** ppVideoProcessor</b></param>
	int CreateVideoProcessor1<T0> (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, T0* pProtectedResourceSession, Guid riid, out void* ppVideoProcessor) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoExtensionCommand (D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc, void* pCreationParameters, SIZE_T CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoExtensionCommand)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc</b></param>
	/// <param name="pCreationParameters">_In_reads_bytes_(CreationParametersDataSizeInBytes) <b>void* pCreationParameters</b></param>
	/// <param name="creationParametersDataSizeInBytes"><b>SIZE_T CreationParametersDataSizeInBytes</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoExtensionCommand">_COM_Outptr_ <b>void** ppVideoExtensionCommand</b></param>
	int CreateVideoExtensionCommand<T0> (VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint creationParametersDataSizeInBytes, T0* pProtectedResourceSession, Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::CreateVideoExtensionCommand (D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc, void* pCreationParameters, SIZE_T CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoExtensionCommand)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc</b></param>
	/// <param name="pCreationParameters">_In_reads_bytes_(CreationParametersDataSizeInBytes) <b>void* pCreationParameters</b></param>
	/// <param name="creationParametersDataSizeInBytes"><b>SIZE_T CreationParametersDataSizeInBytes</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoExtensionCommand">_COM_Outptr_ <b>void** ppVideoExtensionCommand</b></param>
	int CreateVideoExtensionCommand<T0> (VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint creationParametersDataSizeInBytes, T0* pProtectedResourceSession, Guid riid, out void* ppVideoExtensionCommand) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice2::ExecuteExtensionCommand (ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, SIZE_T ExecutionParametersSizeInBytes, void* pOutputData, SIZE_T OutputDataSizeInBytes)</b><br/>
	/// </summary>
	/// <param name="pExtensionCommand">_In_ <b>ID3D12VideoExtensionCommand* pExtensionCommand</b></param>
	/// <param name="pExecutionParameters">_In_reads_bytes_(ExecutionParametersSizeInBytes) <b>void* pExecutionParameters</b></param>
	/// <param name="executionParametersSizeInBytes"><b>SIZE_T ExecutionParametersSizeInBytes</b></param>
	/// <param name="pOutputData">_Out_writes_bytes_(OutputDataSizeInBytes) <b>void* pOutputData</b></param>
	/// <param name="outputDataSizeInBytes"><b>SIZE_T OutputDataSizeInBytes</b></param>
	int ExecuteExtensionCommand<T0> (T0* pExtensionCommand, void* pExecutionParameters, nuint executionParametersSizeInBytes, void* pOutputData, nuint outputDataSizeInBytes) where T0 : unmanaged, IVideoExtensionCommand;
}

/// <summary>
/// Instance of <b>ID3D12VideoDevice2</b><br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public readonly struct VideoDevice2 : IVideoDevice2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoDevice2* GetCurrentPointer () => (VideoDevice2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xf019ac49, 0xf838, 0x4a95, 0x9b, 0x17, 0x57, 0x94, 0x37, 0xc8, 0xf5, 0x13);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoMotionEstimator<T0> (VideoMotionEstimatorDesc* pDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoMotionEstimator) where T0 : unmanaged, IProtectedResourceSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoMotionEstimator (ptr, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoMotionEstimator<T0> (VideoMotionEstimatorDesc* pDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoMotionEstimator) where T0 : unmanaged, IProtectedResourceSession {
		fixed (void** _ppVideoMotionEstimator = &ppVideoMotionEstimator) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoMotionEstimator (ptr, pDesc, pProtectedResourceSession, riid, _ppVideoMotionEstimator);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoMotionVectorHeap<T0> (VideoMotionVectorHeapDesc* pDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoMotionVectorHeap) where T0 : unmanaged, IProtectedResourceSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoMotionVectorHeap (ptr, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoMotionVectorHeap<T0> (VideoMotionVectorHeapDesc* pDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoMotionVectorHeap) where T0 : unmanaged, IProtectedResourceSession {
		fixed (void** _ppVideoMotionVectorHeap = &ppVideoMotionVectorHeap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoMotionVectorHeap (ptr, pDesc, pProtectedResourceSession, riid, _ppVideoMotionVectorHeap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoder1<T0> (VideoDecoderDesc* pDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoDecoder) where T0 : unmanaged, IProtectedResourceSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoder1 (ptr, pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoder1<T0> (VideoDecoderDesc* pDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoDecoder) where T0 : unmanaged, IProtectedResourceSession {
		fixed (void** _ppVideoDecoder = &ppVideoDecoder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoder1 (ptr, pDesc, pProtectedResourceSession, riid, _ppVideoDecoder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoderHeap1<T0> (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoDecoderHeap) where T0 : unmanaged, IProtectedResourceSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoderHeap1 (ptr, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoDecoderHeap1<T0> (VideoDecoderHeapDesc* pVideoDecoderHeapDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoDecoderHeap) where T0 : unmanaged, IProtectedResourceSession {
		fixed (void** _ppVideoDecoderHeap = &ppVideoDecoderHeap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoDecoderHeap1 (ptr, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, _ppVideoDecoderHeap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessor1<T0> (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, T0* pProtectedResourceSession, Guid riid, void** ppVideoProcessor) where T0 : unmanaged, IProtectedResourceSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessor1 (ptr, nodeMask, pOutputStreamDesc, numInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoProcessor1<T0> (uint nodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint numInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, T0* pProtectedResourceSession, Guid riid, out void* ppVideoProcessor) where T0 : unmanaged, IProtectedResourceSession {
		fixed (void** _ppVideoProcessor = &ppVideoProcessor) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoProcessor1 (ptr, nodeMask, pOutputStreamDesc, numInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, _ppVideoProcessor);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoExtensionCommand<T0> (VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint creationParametersDataSizeInBytes, T0* pProtectedResourceSession, Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged, IProtectedResourceSession {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoExtensionCommand (ptr, pDesc, pCreationParameters, creationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVideoExtensionCommand<T0> (VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint creationParametersDataSizeInBytes, T0* pProtectedResourceSession, Guid riid, out void* ppVideoExtensionCommand) where T0 : unmanaged, IProtectedResourceSession {
		fixed (void** _ppVideoExtensionCommand = &ppVideoExtensionCommand) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVideoExtensionCommand (ptr, pDesc, pCreationParameters, creationParametersDataSizeInBytes, pProtectedResourceSession, riid, _ppVideoExtensionCommand);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ExecuteExtensionCommand<T0> (T0* pExtensionCommand, void* pExecutionParameters, nuint executionParametersSizeInBytes, void* pOutputData, nuint outputDataSizeInBytes) where T0 : unmanaged, IVideoExtensionCommand {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ExecuteExtensionCommand (ptr, pExtensionCommand, pExecutionParameters, executionParametersSizeInBytes, pOutputData, outputDataSizeInBytes);
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
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoMotionEstimatorDesc*, void*, Guid, void**, int> CreateVideoMotionEstimator;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoMotionVectorHeapDesc*, void*, Guid, void**, int> CreateVideoMotionVectorHeap;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, void*, Guid, void**, int> CreateVideoDecoder1;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderHeapDesc*, void*, Guid, void**, int> CreateVideoDecoderHeap1;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, void*, Guid, void**, int> CreateVideoProcessor1;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoExtensionCommandDesc*, void*, nuint, void*, Guid, void**, int> CreateVideoExtensionCommand;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, nuint, void*, nuint, int> ExecuteExtensionCommand;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
