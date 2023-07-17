using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12Device2</b> : ID3D12Device1<br/>
/// D3D12.h
/// </summary>
unsafe public interface IDevice2 : IDevice1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device2::CreatePipelineState (D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pDesc"><b>D3D12_PIPELINE_STATE_STREAM_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int CreatePipelineState (PipelineStateStreamDesc* pDesc, Guid riid, void** ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device2::CreatePipelineState (D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pDesc"><b>D3D12_PIPELINE_STATE_STREAM_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int CreatePipelineState (PipelineStateStreamDesc* pDesc, Guid riid, out void* ppPipelineState);
}

/// <summary>
/// Instance of <b>ID3D12Device2</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct Device2 : IDevice2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device2* GetCurrentPointer () => (Device2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x30baa41e, 0xb15b, 0x475c, 0xa0, 0xbb, 0x1a, 0xf5, 0xc5, 0xb6, 0x43, 0x28);

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
	public readonly uint GetNodeCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNodeCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandQueue (CommandQueueDesc* pDesc, Guid riid, void** ppCommandQueue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandQueue (ptr, pDesc, riid, ppCommandQueue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandQueue (CommandQueueDesc* pDesc, Guid riid, out void* ppCommandQueue) {
		fixed (void** _ppCommandQueue = &ppCommandQueue) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandQueue (ptr, pDesc, riid, _ppCommandQueue);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandAllocator (CommandListType type, Guid riid, void** ppCommandAllocator) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandAllocator (ptr, type, riid, ppCommandAllocator);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandAllocator (CommandListType type, Guid riid, out void* ppCommandAllocator) {
		fixed (void** _ppCommandAllocator = &ppCommandAllocator) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandAllocator (ptr, type, riid, _ppCommandAllocator);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGraphicsPipelineState (GraphicsPipelineStateDesc* pDesc, Guid riid, void** ppPipelineState) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGraphicsPipelineState (ptr, pDesc, riid, ppPipelineState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGraphicsPipelineState (GraphicsPipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState) {
		fixed (void** _ppPipelineState = &ppPipelineState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGraphicsPipelineState (ptr, pDesc, riid, _ppPipelineState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComputePipelineState (ComputePipelineStateDesc* pDesc, Guid riid, void** ppPipelineState) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateComputePipelineState (ptr, pDesc, riid, ppPipelineState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComputePipelineState (ComputePipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState) {
		fixed (void** _ppPipelineState = &ppPipelineState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateComputePipelineState (ptr, pDesc, riid, _ppPipelineState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandList<T0, T1> (uint nodeMask, CommandListType type, T0* pCommandAllocator, T1* pInitialState, Guid riid, void** ppCommandList) where T0 : unmanaged, ICommandAllocator where T1 : unmanaged, IPipelineState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandList (ptr, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandList<T0, T1> (uint nodeMask, CommandListType type, T0* pCommandAllocator, T1* pInitialState, Guid riid, out void* ppCommandList) where T0 : unmanaged, ICommandAllocator where T1 : unmanaged, IPipelineState {
		fixed (void** _ppCommandList = &ppCommandList) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandList (ptr, nodeMask, type, pCommandAllocator, pInitialState, riid, _ppCommandList);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckFeatureSupport (Feature feature, void* pFeatureSupportData, uint featureSupportDataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckFeatureSupport (ptr, feature, pFeatureSupportData, featureSupportDataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDescriptorHeap (DescriptorHeapDesc* pDescriptorHeapDesc, Guid riid, void** ppvHeap) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDescriptorHeap (ptr, pDescriptorHeapDesc, riid, ppvHeap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDescriptorHeap (DescriptorHeapDesc* pDescriptorHeapDesc, Guid riid, out void* ppvHeap) {
		fixed (void** _ppvHeap = &ppvHeap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDescriptorHeap (ptr, pDescriptorHeapDesc, riid, _ppvHeap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetDescriptorHandleIncrementSize (DescriptorHeapType descriptorHeapType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDescriptorHandleIncrementSize (ptr, descriptorHeapType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRootSignature (uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid riid, void** ppvRootSignature) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRootSignature (ptr, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRootSignature (uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid riid, out void* ppvRootSignature) {
		fixed (void** _ppvRootSignature = &ppvRootSignature) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRootSignature (ptr, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, _ppvRootSignature);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CreateConstantBufferView (ConstantBufferViewDesc* pDesc, CpuDescriptorHandle destDescriptor) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CreateConstantBufferView (ptr, pDesc, destDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CreateShaderResourceView<T0> (T0* pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CreateShaderResourceView (ptr, pResource, pDesc, destDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CreateUnorderedAccessView<T0, T1> (T0* pResource, T1* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CreateUnorderedAccessView (ptr, pResource, pCounterResource, pDesc, destDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CreateRenderTargetView<T0> (T0* pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CreateRenderTargetView (ptr, pResource, pDesc, destDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CreateDepthStencilView<T0> (T0* pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CreateDepthStencilView (ptr, pResource, pDesc, destDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CreateSampler (SamplerDesc* pDesc, CpuDescriptorHandle destDescriptor) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CreateSampler (ptr, pDesc, destDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyDescriptors (uint numDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint numSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType descriptorHeapsType) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyDescriptors (ptr, numDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, numSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, descriptorHeapsType);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyDescriptorsSimple (uint numDescriptors, CpuDescriptorHandle destDescriptorRangeStart, CpuDescriptorHandle srcDescriptorRangeStart, DescriptorHeapType descriptorHeapsType) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyDescriptorsSimple (ptr, numDescriptors, destDescriptorRangeStart, srcDescriptorRangeStart, descriptorHeapsType);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ResourceAllocationInfo GetResourceAllocationInfo (uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetResourceAllocationInfo (ptr, visibleMask, numResourceDescs, pResourceDescs);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly HeapProperties GetCustomHeapProperties (uint nodeMask, HeapType heapType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCustomHeapProperties (ptr, nodeMask, heapType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommittedResource (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Guid riidResource, void** ppvResource) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommittedResource (ptr, pHeapProperties, heapFlags, pDesc, initialResourceState, pOptimizedClearValue, riidResource, ppvResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommittedResource (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Guid riidResource, out void* ppvResource) {
		fixed (void** _ppvResource = &ppvResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommittedResource (ptr, pHeapProperties, heapFlags, pDesc, initialResourceState, pOptimizedClearValue, riidResource, _ppvResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHeap (HeapDesc* pDesc, Guid riid, void** ppvHeap) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateHeap (ptr, pDesc, riid, ppvHeap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHeap (HeapDesc* pDesc, Guid riid, out void* ppvHeap) {
		fixed (void** _ppvHeap = &ppvHeap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateHeap (ptr, pDesc, riid, _ppvHeap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePlacedResource<T0> (T0* pHeap, ulong heapOffset, ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, void** ppvResource) where T0 : unmanaged, IHeap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePlacedResource (ptr, pHeap, heapOffset, pDesc, initialState, pOptimizedClearValue, riid, ppvResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePlacedResource<T0> (T0* pHeap, ulong heapOffset, ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, out void* ppvResource) where T0 : unmanaged, IHeap {
		fixed (void** _ppvResource = &ppvResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePlacedResource (ptr, pHeap, heapOffset, pDesc, initialState, pOptimizedClearValue, riid, _ppvResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateReservedResource (ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, void** ppvResource) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateReservedResource (ptr, pDesc, initialState, pOptimizedClearValue, riid, ppvResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateReservedResource (ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, out void* ppvResource) {
		fixed (void** _ppvResource = &ppvResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateReservedResource (ptr, pDesc, initialState, pOptimizedClearValue, riid, _ppvResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedHandle<T0> (T0* pObject, SecurityAttributes* pAttributes, uint access, char* name, IntPtr* pHandle) where T0 : unmanaged, IDeviceChild {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedHandle (ptr, pObject, pAttributes, access, name, pHandle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedHandle<T0> (T0* pObject, SecurityAttributes* pAttributes, uint access, char* name, out IntPtr pHandle) where T0 : unmanaged, IDeviceChild {
		fixed (IntPtr* _pHandle = &pHandle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedHandle (ptr, pObject, pAttributes, access, name, _pHandle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedHandle (IntPtr nTHandle, Guid riid, void** ppvObj) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedHandle (ptr, nTHandle, riid, ppvObj);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedHandle (IntPtr nTHandle, Guid riid, out void* ppvObj) {
		fixed (void** _ppvObj = &ppvObj) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedHandle (ptr, nTHandle, riid, _ppvObj);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedHandleByName (char* name, uint access, IntPtr* pNTHandle) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedHandleByName (ptr, name, access, pNTHandle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedHandleByName (char* name, uint access, out IntPtr pNTHandle) {
		fixed (IntPtr* _pNTHandle = &pNTHandle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedHandleByName (ptr, name, access, _pNTHandle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MakeResident<T0> (uint numObjects, T0* ppObjects) where T0 : unmanaged, IPageable {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MakeResident (ptr, numObjects, ppObjects);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Evict<T0> (uint numObjects, T0* ppObjects) where T0 : unmanaged, IPageable {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Evict (ptr, numObjects, ppObjects);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFence (ulong initialValue, FenceFlags flags, Guid riid, void** ppFence) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFence (ptr, initialValue, flags, riid, ppFence);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFence (ulong initialValue, FenceFlags flags, Guid riid, out void* ppFence) {
		fixed (void** _ppFence = &ppFence) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFence (ptr, initialValue, flags, riid, _ppFence);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDeviceRemovedReason () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDeviceRemovedReason (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetCopyableFootprints (ResourceDesc* pResourceDesc, uint firstSubresource, uint numSubresources, ulong baseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetCopyableFootprints (ptr, pResourceDesc, firstSubresource, numSubresources, baseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetCopyableFootprints (ResourceDesc* pResourceDesc, uint firstSubresource, uint numSubresources, ulong baseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, out ulong pTotalBytes) {
		fixed (ulong* _pTotalBytes = &pTotalBytes) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetCopyableFootprints (ptr, pResourceDesc, firstSubresource, numSubresources, baseOffset, pLayouts, pNumRows, pRowSizeInBytes, _pTotalBytes);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryHeap (QueryHeapDesc* pDesc, Guid riid, void** ppvHeap) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryHeap (ptr, pDesc, riid, ppvHeap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQueryHeap (QueryHeapDesc* pDesc, Guid riid, out void* ppvHeap) {
		fixed (void** _ppvHeap = &ppvHeap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateQueryHeap (ptr, pDesc, riid, _ppvHeap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetStablePowerState (bool enable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetStablePowerState (ptr, enable ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandSignature<T0> (CommandSignatureDesc* pDesc, T0* pRootSignature, Guid riid, void** ppvCommandSignature) where T0 : unmanaged, IRootSignature {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandSignature (ptr, pDesc, pRootSignature, riid, ppvCommandSignature);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandSignature<T0> (CommandSignatureDesc* pDesc, T0* pRootSignature, Guid riid, out void* ppvCommandSignature) where T0 : unmanaged, IRootSignature {
		fixed (void** _ppvCommandSignature = &ppvCommandSignature) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandSignature (ptr, pDesc, pRootSignature, riid, _ppvCommandSignature);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetResourceTiling<T0> (T0* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetResourceTiling (ptr, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, firstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetResourceTiling<T0> (T0* pTiledResource, out uint pNumTilesForEntireResource, out PackedMipInfo pPackedMipDesc, out TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource {
		fixed (uint* _pNumTilesForEntireResource = &pNumTilesForEntireResource) {
			fixed (PackedMipInfo* _pPackedMipDesc = &pPackedMipDesc) {
				fixed (TileShape* _pStandardTileShapeForNonPackedMips = &pStandardTileShapeForNonPackedMips) {
					var ptr = GetCurrentPointer ();
					((FunctionPointer*) ptr->_pointer)->GetResourceTiling (ptr, pTiledResource, _pNumTilesForEntireResource, _pPackedMipDesc, _pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, firstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
					return;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly LUID GetAdapterLuid () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAdapterLuid (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePipelineLibrary (void* pLibraryBlob, nuint blobLength, Guid riid, void** ppPipelineLibrary) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePipelineLibrary (ptr, pLibraryBlob, blobLength, riid, ppPipelineLibrary);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePipelineLibrary (void* pLibraryBlob, nuint blobLength, Guid riid, out void* ppPipelineLibrary) {
		fixed (void** _ppPipelineLibrary = &ppPipelineLibrary) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePipelineLibrary (ptr, pLibraryBlob, blobLength, riid, _ppPipelineLibrary);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetEventOnMultipleFenceCompletion<T0> (T0* ppFences, ulong* pFenceValues, uint numFences, MultipleFenceWaitFlags flags, IntPtr hEvent) where T0 : unmanaged, IFence {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetEventOnMultipleFenceCompletion (ptr, ppFences, pFenceValues, numFences, flags, hEvent);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetResidencyPriority<T0> (uint numObjects, T0* ppObjects, ResidencyPriority* pPriorities) where T0 : unmanaged, IPageable {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetResidencyPriority (ptr, numObjects, ppObjects, pPriorities);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePipelineState (PipelineStateStreamDesc* pDesc, Guid riid, void** ppPipelineState) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePipelineState (ptr, pDesc, riid, ppPipelineState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePipelineState (PipelineStateStreamDesc* pDesc, Guid riid, out void* ppPipelineState) {
		fixed (void** _ppPipelineState = &ppPipelineState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePipelineState (ptr, pDesc, riid, _ppPipelineState);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetNodeCount;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CommandQueueDesc*, Guid, void**, int> CreateCommandQueue;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CommandListType, Guid, void**, int> CreateCommandAllocator;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GraphicsPipelineStateDesc*, Guid, void**, int> CreateGraphicsPipelineState;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ComputePipelineStateDesc*, Guid, void**, int> CreateComputePipelineState;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, CommandListType, void*, void*, Guid, void**, int> CreateCommandList;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Feature, void*, uint, int> CheckFeatureSupport;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DescriptorHeapDesc*, Guid, void**, int> CreateDescriptorHeap;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DescriptorHeapType, uint> GetDescriptorHandleIncrementSize;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, nuint, Guid, void**, int> CreateRootSignature;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ConstantBufferViewDesc*, CpuDescriptorHandle, void> CreateConstantBufferView;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ShaderResourceViewDesc*, CpuDescriptorHandle, void> CreateShaderResourceView;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void> CreateUnorderedAccessView;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, RenderTargetViewDesc*, CpuDescriptorHandle, void> CreateRenderTargetView;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DepthStencilViewDesc*, CpuDescriptorHandle, void> CreateDepthStencilView;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SamplerDesc*, CpuDescriptorHandle, void> CreateSampler;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void> CopyDescriptors;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void> CopyDescriptorsSimple;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, ResourceDesc*, ResourceAllocationInfo> GetResourceAllocationInfo;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, HeapType, HeapProperties> GetCustomHeapProperties;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid, void**, int> CreateCommittedResource;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, HeapDesc*, Guid, void**, int> CreateHeap;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid, void**, int> CreatePlacedResource;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ResourceDesc*, ResourceStates, ClearValue*, Guid, void**, int> CreateReservedResource;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, SecurityAttributes*, uint, char*, IntPtr*, int> CreateSharedHandle;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, Guid, void**, int> OpenSharedHandle;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, IntPtr*, int> OpenSharedHandleByName;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, int> MakeResident;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, int> Evict;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, FenceFlags, Guid, void**, int> CreateFence;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> GetDeviceRemovedReason;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void> GetCopyableFootprints;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, QueryHeapDesc*, Guid, void**, int> CreateQueryHeap;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetStablePowerState;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CommandSignatureDesc*, void*, Guid, void**, int> CreateCommandSignature;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void> GetResourceTiling;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LUID> GetAdapterLuid;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, Guid, void**, int> CreatePipelineLibrary;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong*, uint, MultipleFenceWaitFlags, IntPtr, int> SetEventOnMultipleFenceCompletion;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, ResidencyPriority*, int> SetResidencyPriority;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PipelineStateStreamDesc*, Guid, void**, int> CreatePipelineState;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
