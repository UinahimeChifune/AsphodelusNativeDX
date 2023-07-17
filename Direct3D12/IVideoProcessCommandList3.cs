using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VideoProcessCommandList3</b> : ID3D12VideoProcessCommandList2<br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public interface IVideoProcessCommandList3 : IVideoProcessCommandList2 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12VideoProcessCommandList3::Barrier (UINT32 NumBarrierGroups, D3D12_BARRIER_GROUP* pBarrierGroups)</b><br/>
	/// </summary>
	/// <param name="numBarrierGroups"><b>UINT32 NumBarrierGroups</b></param>
	/// <param name="pBarrierGroups">_In_reads_(NumBarrierGroups) <b>D3D12_BARRIER_GROUP* pBarrierGroups</b></param>
	void Barrier (uint numBarrierGroups, BarrierGroup* pBarrierGroups);
}

/// <summary>
/// Instance of <b>ID3D12VideoProcessCommandList3</b><br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public readonly struct VideoProcessCommandList3 : IVideoProcessCommandList3 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoProcessCommandList3* GetCurrentPointer () => (VideoProcessCommandList3*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1a0a4ca4, 0x9f08, 0x40ce, 0x95, 0x58, 0xb4, 0x11, 0xfd, 0x26, 0x66, 0xff);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ProcessFrames1<T0> (T0* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint numInputStreams, VideoProcessInputStreamArguments1* pInputArguments) where T0 : unmanaged, IVideoProcessor {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ProcessFrames1 (ptr, pVideoProcessor, pOutputArguments, numInputStreams, pInputArguments);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetProtectedResourceSession<T0> (T0* pProtectedResourceSession) where T0 : unmanaged, IProtectedResourceSession {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetProtectedResourceSession (ptr, pProtectedResourceSession);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void InitializeExtensionCommand<T0> (T0* pExtensionCommand, void* pInitializationParameters, nuint initializationParametersSizeInBytes) where T0 : unmanaged, IVideoExtensionCommand {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->InitializeExtensionCommand (ptr, pExtensionCommand, pInitializationParameters, initializationParametersSizeInBytes);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ExecuteExtensionCommand<T0> (T0* pExtensionCommand, void* pExecutionParameters, nuint executionParametersSizeInBytes) where T0 : unmanaged, IVideoExtensionCommand {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ExecuteExtensionCommand (ptr, pExtensionCommand, pExecutionParameters, executionParametersSizeInBytes);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Barrier (uint numBarrierGroups, BarrierGroup* pBarrierGroups) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Barrier (ptr, numBarrierGroups, pBarrierGroups);
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
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void> ProcessFrames1;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetProtectedResourceSession;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, nuint, void> InitializeExtensionCommand;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, nuint, void> ExecuteExtensionCommand;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, BarrierGroup*, void> Barrier;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
