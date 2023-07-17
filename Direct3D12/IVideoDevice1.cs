using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VideoDevice1</b> : ID3D12VideoDevice<br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public interface IVideoDevice1 : IVideoDevice {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice1::CreateVideoMotionEstimator (D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoMotionEstimator)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoMotionEstimator">_COM_Outptr_ <b>void** ppVideoMotionEstimator</b></param>
	int CreateVideoMotionEstimator<T0> (VideoMotionEstimatorDesc* pDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoMotionEstimator) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice1::CreateVideoMotionEstimator (D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoMotionEstimator)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoMotionEstimator">_COM_Outptr_ <b>void** ppVideoMotionEstimator</b></param>
	int CreateVideoMotionEstimator<T0> (VideoMotionEstimatorDesc* pDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoMotionEstimator) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice1::CreateVideoMotionVectorHeap (D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoMotionVectorHeap)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoMotionVectorHeap">_COM_Outptr_ <b>void** ppVideoMotionVectorHeap</b></param>
	int CreateVideoMotionVectorHeap<T0> (VideoMotionVectorHeapDesc* pDesc, T0* pProtectedResourceSession, Guid riid, void** ppVideoMotionVectorHeap) where T0 : unmanaged, IProtectedResourceSession;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoDevice1::CreateVideoMotionVectorHeap (D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, REFIID riid, void** ppVideoMotionVectorHeap)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc</b></param>
	/// <param name="pProtectedResourceSession">_In_opt_ <b>ID3D12ProtectedResourceSession* pProtectedResourceSession</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppVideoMotionVectorHeap">_COM_Outptr_ <b>void** ppVideoMotionVectorHeap</b></param>
	int CreateVideoMotionVectorHeap<T0> (VideoMotionVectorHeapDesc* pDesc, T0* pProtectedResourceSession, Guid riid, out void* ppVideoMotionVectorHeap) where T0 : unmanaged, IProtectedResourceSession;
}

/// <summary>
/// Instance of <b>ID3D12VideoDevice1</b><br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public readonly struct VideoDevice1 : IVideoDevice1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoDevice1* GetCurrentPointer () => (VideoDevice1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x981611ad, 0xa144, 0x4c83, 0x98, 0x90, 0xf3, 0x0e, 0x26, 0xd6, 0x58, 0xab);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
