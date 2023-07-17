using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VideoProcessCommandList</b> : ID3D12CommandList<br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public interface IVideoProcessCommandList : ICommandList {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoProcessCommandList::Close ()</b><br/>
	/// </summary>
	int Close ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoProcessCommandList::Reset (ID3D12CommandAllocator* pAllocator)</b><br/>
	/// </summary>
	/// <param name="pAllocator">_In_ <b>ID3D12CommandAllocator* pAllocator</b></param>
	int Reset<T0> (T0* pAllocator) where T0 : unmanaged, ICommandAllocator;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::ClearState ()</b><br/>
	/// </summary>
	void ClearState ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::ResourceBarrier (UINT NumBarriers, D3D12_RESOURCE_BARRIER* pBarriers)</b><br/>
	/// </summary>
	/// <param name="numBarriers">_In_ <b>UINT NumBarriers</b></param>
	/// <param name="pBarriers">_In_reads_(NumBarriers) <b>D3D12_RESOURCE_BARRIER* pBarriers</b></param>
	void ResourceBarrier (uint numBarriers, ResourceBarrier* pBarriers);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::DiscardResource (ID3D12Resource* pResource, D3D12_DISCARD_REGION* pRegion)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="pRegion">_In_opt_ <b>D3D12_DISCARD_REGION* pRegion</b></param>
	void DiscardResource<T0> (T0* pResource, DiscardRegion* pRegion) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::BeginQuery (ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, UINT Index)</b><br/>
	/// </summary>
	/// <param name="pQueryHeap">_In_ <b>ID3D12QueryHeap* pQueryHeap</b></param>
	/// <param name="type">_In_ <b>D3D12_QUERY_TYPE Type</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	void BeginQuery<T0> (T0* pQueryHeap, QueryType type, uint index) where T0 : unmanaged, IQueryHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::EndQuery (ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, UINT Index)</b><br/>
	/// </summary>
	/// <param name="pQueryHeap">_In_ <b>ID3D12QueryHeap* pQueryHeap</b></param>
	/// <param name="type">_In_ <b>D3D12_QUERY_TYPE Type</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	void EndQuery<T0> (T0* pQueryHeap, QueryType type, uint index) where T0 : unmanaged, IQueryHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::ResolveQueryData (ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, UINT StartIndex, UINT NumQueries, ID3D12Resource* pDestinationBuffer, UINT64 AlignedDestinationBufferOffset)</b><br/>
	/// </summary>
	/// <param name="pQueryHeap">_In_ <b>ID3D12QueryHeap* pQueryHeap</b></param>
	/// <param name="type">_In_ <b>D3D12_QUERY_TYPE Type</b></param>
	/// <param name="startIndex">_In_ <b>UINT StartIndex</b></param>
	/// <param name="numQueries">_In_ <b>UINT NumQueries</b></param>
	/// <param name="pDestinationBuffer">_In_ <b>ID3D12Resource* pDestinationBuffer</b></param>
	/// <param name="alignedDestinationBufferOffset">_In_ <b>UINT64 AlignedDestinationBufferOffset</b></param>
	void ResolveQueryData<T0, T1> (T0* pQueryHeap, QueryType type, uint startIndex, uint numQueries, T1* pDestinationBuffer, ulong alignedDestinationBufferOffset) where T0 : unmanaged, IQueryHeap where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::SetPredication (ID3D12Resource* pBuffer, UINT64 AlignedBufferOffset, D3D12_PREDICATION_OP Operation)</b><br/>
	/// </summary>
	/// <param name="pBuffer">_In_opt_ <b>ID3D12Resource* pBuffer</b></param>
	/// <param name="alignedBufferOffset">_In_ <b>UINT64 AlignedBufferOffset</b></param>
	/// <param name="operation">_In_ <b>D3D12_PREDICATION_OP Operation</b></param>
	void SetPredication<T0> (T0* pBuffer, ulong alignedBufferOffset, PredicationOp operation) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::SetMarker (UINT Metadata, void* pData, UINT Size)</b><br/>
	/// </summary>
	/// <param name="metadata"><b>UINT Metadata</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(Size) <b>void* pData</b></param>
	/// <param name="size"><b>UINT Size</b></param>
	void SetMarker (uint metadata, void* pData, uint size);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::BeginEvent (UINT Metadata, void* pData, UINT Size)</b><br/>
	/// </summary>
	/// <param name="metadata"><b>UINT Metadata</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(Size) <b>void* pData</b></param>
	/// <param name="size"><b>UINT Size</b></param>
	void BeginEvent (uint metadata, void* pData, uint size);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::EndEvent ()</b><br/>
	/// </summary>
	void EndEvent ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::ProcessFrames (ID3D12VideoProcessor* pVideoProcessor, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, UINT NumInputStreams, D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS* pInputArguments)</b><br/>
	/// </summary>
	/// <param name="pVideoProcessor">_In_ <b>ID3D12VideoProcessor* pVideoProcessor</b></param>
	/// <param name="pOutputArguments">_In_ <b>D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS* pOutputArguments</b></param>
	/// <param name="numInputStreams"><b>UINT NumInputStreams</b></param>
	/// <param name="pInputArguments">_In_reads_(NumInputStreams) <b>D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS* pInputArguments</b></param>
	void ProcessFrames<T0> (T0* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint numInputStreams, VideoProcessInputStreamArguments* pInputArguments) where T0 : unmanaged, IVideoProcessor;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList::WriteBufferImmediate (UINT Count, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)</b><br/>
	/// </summary>
	/// <param name="count"><b>UINT Count</b></param>
	/// <param name="pParams">_In_reads_(Count) <b>D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams</b></param>
	/// <param name="pModes">_In_reads_opt_(Count) <b>D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes</b></param>
	void WriteBufferImmediate (uint count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes);
}

/// <summary>
/// Instance of <b>ID3D12VideoProcessCommandList</b><br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public readonly struct VideoProcessCommandList : IVideoProcessCommandList {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoProcessCommandList* GetCurrentPointer () => (VideoProcessCommandList*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xaeb2543a, 0x167f, 0x4682, 0xac, 0xc8, 0xd1, 0x59, 0xed, 0x4a, 0x62, 0x09);

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
	public readonly int SetName (char* name) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetName (ptr, name);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDevice (Guid riid, void** ppvDevice) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, ppvDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDevice (Guid riid, out void* ppvDevice) {
		fixed (void** _ppvDevice = &ppvDevice) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, _ppvDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly CommandListType GetCommandListType () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Close () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Close (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Reset<T0> (T0* pAllocator) where T0 : unmanaged, ICommandAllocator {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Reset (ptr, pAllocator);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearState () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearState (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ResourceBarrier (uint numBarriers, ResourceBarrier* pBarriers) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ResourceBarrier (ptr, numBarriers, pBarriers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DiscardResource<T0> (T0* pResource, DiscardRegion* pRegion) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DiscardResource (ptr, pResource, pRegion);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void BeginQuery<T0> (T0* pQueryHeap, QueryType type, uint index) where T0 : unmanaged, IQueryHeap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->BeginQuery (ptr, pQueryHeap, type, index);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void EndQuery<T0> (T0* pQueryHeap, QueryType type, uint index) where T0 : unmanaged, IQueryHeap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EndQuery (ptr, pQueryHeap, type, index);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ResolveQueryData<T0, T1> (T0* pQueryHeap, QueryType type, uint startIndex, uint numQueries, T1* pDestinationBuffer, ulong alignedDestinationBufferOffset) where T0 : unmanaged, IQueryHeap where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ResolveQueryData (ptr, pQueryHeap, type, startIndex, numQueries, pDestinationBuffer, alignedDestinationBufferOffset);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetPredication<T0> (T0* pBuffer, ulong alignedBufferOffset, PredicationOp operation) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetPredication (ptr, pBuffer, alignedBufferOffset, operation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetMarker (uint metadata, void* pData, uint size) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetMarker (ptr, metadata, pData, size);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void BeginEvent (uint metadata, void* pData, uint size) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->BeginEvent (ptr, metadata, pData, size);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void EndEvent () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EndEvent (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ProcessFrames<T0> (T0* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint numInputStreams, VideoProcessInputStreamArguments* pInputArguments) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ProcessFrames (ptr, pVideoProcessor, pOutputArguments, numInputStreams, pInputArguments);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void WriteBufferImmediate (uint count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->WriteBufferImmediate (ptr, count, pParams, pModes);
		return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> SetName;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetDevice;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CommandListType> _GetType;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Close;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> Reset;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> ClearState;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ResourceBarrier*, void> ResourceBarrier;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DiscardRegion*, void> DiscardResource;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, QueryType, uint, void> BeginQuery;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, QueryType, uint, void> EndQuery;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, QueryType, uint, uint, void*, ulong, void> ResolveQueryData;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, PredicationOp, void> SetPredication;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, void> SetMarker;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, void> BeginEvent;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> EndEvent;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void> ProcessFrames;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void> WriteBufferImmediate;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
