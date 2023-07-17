using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12CommandQueue</b> : ID3D12Pageable<br/>
/// D3D12.h
/// </summary>
unsafe public interface ICommandQueue : IPageable {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12CommandQueue::UpdateTileMappings (ID3D12Resource* pResource, UINT NumResourceRegions, D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates, D3D12_TILE_REGION_SIZE* pResourceRegionSizes, ID3D12Heap* pHeap, UINT NumRanges, D3D12_TILE_RANGE_FLAGS* pRangeFlags, UINT* pHeapRangeStartOffsets, UINT* pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="numResourceRegions"><b>UINT NumResourceRegions</b></param>
	/// <param name="pResourceRegionStartCoordinates">_In_reads_opt_(NumResourceRegions) <b>D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates</b></param>
	/// <param name="pResourceRegionSizes">_In_reads_opt_(NumResourceRegions) <b>D3D12_TILE_REGION_SIZE* pResourceRegionSizes</b></param>
	/// <param name="pHeap">_In_opt_ <b>ID3D12Heap* pHeap</b></param>
	/// <param name="numRanges"><b>UINT NumRanges</b></param>
	/// <param name="pRangeFlags">_In_reads_opt_(NumRanges) <b>D3D12_TILE_RANGE_FLAGS* pRangeFlags</b></param>
	/// <param name="pHeapRangeStartOffsets">_In_reads_opt_(NumRanges) <b>UINT* pHeapRangeStartOffsets</b></param>
	/// <param name="pRangeTileCounts">_In_reads_opt_(NumRanges) <b>UINT* pRangeTileCounts</b></param>
	/// <param name="flags"><b>D3D12_TILE_MAPPING_FLAGS Flags</b></param>
	void UpdateTileMappings<T0, T1> (T0* pResource, uint numResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, T1* pHeap, uint numRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags flags) where T0 : unmanaged, IResource where T1 : unmanaged, IHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12CommandQueue::CopyTileMappings (ID3D12Resource* pDstResource, D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate, D3D12_TILE_REGION_SIZE* pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D12Resource* pDstResource</b></param>
	/// <param name="pDstRegionStartCoordinate">_In_ <b>D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate</b></param>
	/// <param name="pSrcResource">_In_ <b>ID3D12Resource* pSrcResource</b></param>
	/// <param name="pSrcRegionStartCoordinate">_In_ <b>D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate</b></param>
	/// <param name="pRegionSize">_In_ <b>D3D12_TILE_REGION_SIZE* pRegionSize</b></param>
	/// <param name="flags"><b>D3D12_TILE_MAPPING_FLAGS Flags</b></param>
	void CopyTileMappings<T0, T1> (T0* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, T1* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags flags) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12CommandQueue::ExecuteCommandLists (UINT NumCommandLists, ID3D12CommandList* ppCommandLists)</b><br/>
	/// </summary>
	/// <param name="numCommandLists">_In_ <b>UINT NumCommandLists</b></param>
	/// <param name="ppCommandLists">_In_reads_(NumCommandLists) <b>ID3D12CommandList* ppCommandLists</b></param>
	void ExecuteCommandLists<T0> (uint numCommandLists, T0* ppCommandLists) where T0 : unmanaged, ICommandList;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12CommandQueue::SetMarker (UINT Metadata, void* pData, UINT Size)</b><br/>
	/// </summary>
	/// <param name="metadata"><b>UINT Metadata</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(Size) <b>void* pData</b></param>
	/// <param name="size"><b>UINT Size</b></param>
	void SetMarker (uint metadata, void* pData, uint size);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12CommandQueue::BeginEvent (UINT Metadata, void* pData, UINT Size)</b><br/>
	/// </summary>
	/// <param name="metadata"><b>UINT Metadata</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(Size) <b>void* pData</b></param>
	/// <param name="size"><b>UINT Size</b></param>
	void BeginEvent (uint metadata, void* pData, uint size);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12CommandQueue::EndEvent ()</b><br/>
	/// </summary>
	void EndEvent ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CommandQueue::Signal (ID3D12Fence* pFence, UINT64 Value)</b><br/>
	/// </summary>
	/// <param name="pFence"><b>ID3D12Fence* pFence</b></param>
	/// <param name="value"><b>UINT64 Value</b></param>
	int Signal<T0> (T0* pFence, ulong value) where T0 : unmanaged, IFence;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CommandQueue::Wait (ID3D12Fence* pFence, UINT64 Value)</b><br/>
	/// </summary>
	/// <param name="pFence"><b>ID3D12Fence* pFence</b></param>
	/// <param name="value"><b>UINT64 Value</b></param>
	int Wait<T0> (T0* pFence, ulong value) where T0 : unmanaged, IFence;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CommandQueue::GetTimestampFrequency (UINT64* pFrequency)</b><br/>
	/// </summary>
	/// <param name="pFrequency">_Out_ <b>UINT64* pFrequency</b></param>
	int GetTimestampFrequency (ulong* pFrequency);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CommandQueue::GetTimestampFrequency (UINT64* pFrequency)</b><br/>
	/// </summary>
	/// <param name="pFrequency">_Out_ <b>UINT64* pFrequency</b></param>
	int GetTimestampFrequency (out ulong pFrequency);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CommandQueue::GetClockCalibration (UINT64* pGpuTimestamp, UINT64* pCpuTimestamp)</b><br/>
	/// </summary>
	/// <param name="pGpuTimestamp">_Out_ <b>UINT64* pGpuTimestamp</b></param>
	/// <param name="pCpuTimestamp">_Out_ <b>UINT64* pCpuTimestamp</b></param>
	int GetClockCalibration (ulong* pGpuTimestamp, ulong* pCpuTimestamp);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CommandQueue::GetClockCalibration (UINT64* pGpuTimestamp, UINT64* pCpuTimestamp)</b><br/>
	/// </summary>
	/// <param name="pGpuTimestamp">_Out_ <b>UINT64* pGpuTimestamp</b></param>
	/// <param name="pCpuTimestamp">_Out_ <b>UINT64* pCpuTimestamp</b></param>
	int GetClockCalibration (out ulong pGpuTimestamp, out ulong pCpuTimestamp);
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_COMMAND_QUEUE_DESC ID3D12CommandQueue::GetDesc ()</b><br/>
	/// </summary>
	CommandQueueDesc GetDesc ();
}

/// <summary>
/// Instance of <b>ID3D12CommandQueue</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct CommandQueue : ICommandQueue {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly CommandQueue* GetCurrentPointer () => (CommandQueue*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x0ec870a6, 0x5d7e, 0x4c22, 0x8c, 0xfc, 0x5b, 0xaa, 0xe0, 0x76, 0x16, 0xed);

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
	public readonly void UpdateTileMappings<T0, T1> (T0* pResource, uint numResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, T1* pHeap, uint numRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags flags) where T0 : unmanaged, IResource where T1 : unmanaged, IHeap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UpdateTileMappings (ptr, pResource, numResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, numRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, flags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyTileMappings<T0, T1> (T0* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, T1* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags flags) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyTileMappings (ptr, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, flags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ExecuteCommandLists<T0> (uint numCommandLists, T0* ppCommandLists) where T0 : unmanaged, ICommandList {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ExecuteCommandLists (ptr, numCommandLists, ppCommandLists);
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
	public readonly int Signal<T0> (T0* pFence, ulong value) where T0 : unmanaged, IFence {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Signal (ptr, pFence, value);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Wait<T0> (T0* pFence, ulong value) where T0 : unmanaged, IFence {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Wait (ptr, pFence, value);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTimestampFrequency (ulong* pFrequency) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTimestampFrequency (ptr, pFrequency);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTimestampFrequency (out ulong pFrequency) {
		fixed (ulong* _pFrequency = &pFrequency) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetTimestampFrequency (ptr, _pFrequency);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClockCalibration (ulong* pGpuTimestamp, ulong* pCpuTimestamp) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetClockCalibration (ptr, pGpuTimestamp, pCpuTimestamp);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClockCalibration (out ulong pGpuTimestamp, out ulong pCpuTimestamp) {
		fixed (ulong* _pGpuTimestamp = &pGpuTimestamp) {
			fixed (ulong* _pCpuTimestamp = &pCpuTimestamp) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetClockCalibration (ptr, _pGpuTimestamp, _pCpuTimestamp);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly CommandQueueDesc GetDesc () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, TiledResourceCoordinate*, TileRegionSize*, void*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void> UpdateTileMappings;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TiledResourceCoordinate*, void*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void> CopyTileMappings;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, void> ExecuteCommandLists;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, void> SetMarker;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, void> BeginEvent;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> EndEvent;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, int> Signal;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, int> Wait;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, int> GetTimestampFrequency;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, ulong*, int> GetClockCalibration;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CommandQueueDesc> GetDesc;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
