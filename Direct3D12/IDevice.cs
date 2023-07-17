using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12Device</b> : ID3D12Object<br/>
/// D3D12.h
/// </summary>
unsafe public interface IDevice : IObject {
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D12Device::GetNodeCount ()</b><br/>
	/// </summary>
	uint GetNodeCount ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandQueue (D3D12_COMMAND_QUEUE_DESC* pDesc, REFIID riid, void** ppCommandQueue)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_COMMAND_QUEUE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppCommandQueue">_COM_Outptr_ <b>void** ppCommandQueue</b></param>
	int CreateCommandQueue (CommandQueueDesc* pDesc, Guid riid, void** ppCommandQueue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandQueue (D3D12_COMMAND_QUEUE_DESC* pDesc, REFIID riid, void** ppCommandQueue)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_COMMAND_QUEUE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppCommandQueue">_COM_Outptr_ <b>void** ppCommandQueue</b></param>
	int CreateCommandQueue (CommandQueueDesc* pDesc, Guid riid, out void* ppCommandQueue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandAllocator (D3D12_COMMAND_LIST_TYPE type, REFIID riid, void** ppCommandAllocator)</b><br/>
	/// </summary>
	/// <param name="type">_In_ <b>D3D12_COMMAND_LIST_TYPE type</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppCommandAllocator">_COM_Outptr_ <b>void** ppCommandAllocator</b></param>
	int CreateCommandAllocator (CommandListType type, Guid riid, void** ppCommandAllocator);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandAllocator (D3D12_COMMAND_LIST_TYPE type, REFIID riid, void** ppCommandAllocator)</b><br/>
	/// </summary>
	/// <param name="type">_In_ <b>D3D12_COMMAND_LIST_TYPE type</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppCommandAllocator">_COM_Outptr_ <b>void** ppCommandAllocator</b></param>
	int CreateCommandAllocator (CommandListType type, Guid riid, out void* ppCommandAllocator);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateGraphicsPipelineState (D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int CreateGraphicsPipelineState (GraphicsPipelineStateDesc* pDesc, Guid riid, void** ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateGraphicsPipelineState (D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int CreateGraphicsPipelineState (GraphicsPipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateComputePipelineState (D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int CreateComputePipelineState (ComputePipelineStateDesc* pDesc, Guid riid, void** ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateComputePipelineState (D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int CreateComputePipelineState (ComputePipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandList (UINT nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, REFIID riid, void** ppCommandList)</b><br/>
	/// </summary>
	/// <param name="nodeMask">_In_ <b>UINT nodeMask</b></param>
	/// <param name="type">_In_ <b>D3D12_COMMAND_LIST_TYPE type</b></param>
	/// <param name="pCommandAllocator">_In_ <b>ID3D12CommandAllocator* pCommandAllocator</b></param>
	/// <param name="pInitialState">_In_opt_ <b>ID3D12PipelineState* pInitialState</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppCommandList">_COM_Outptr_ <b>void** ppCommandList</b></param>
	int CreateCommandList<T0, T1> (uint nodeMask, CommandListType type, T0* pCommandAllocator, T1* pInitialState, Guid riid, void** ppCommandList) where T0 : unmanaged, ICommandAllocator where T1 : unmanaged, IPipelineState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandList (UINT nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, REFIID riid, void** ppCommandList)</b><br/>
	/// </summary>
	/// <param name="nodeMask">_In_ <b>UINT nodeMask</b></param>
	/// <param name="type">_In_ <b>D3D12_COMMAND_LIST_TYPE type</b></param>
	/// <param name="pCommandAllocator">_In_ <b>ID3D12CommandAllocator* pCommandAllocator</b></param>
	/// <param name="pInitialState">_In_opt_ <b>ID3D12PipelineState* pInitialState</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppCommandList">_COM_Outptr_ <b>void** ppCommandList</b></param>
	int CreateCommandList<T0, T1> (uint nodeMask, CommandListType type, T0* pCommandAllocator, T1* pInitialState, Guid riid, out void* ppCommandList) where T0 : unmanaged, ICommandAllocator where T1 : unmanaged, IPipelineState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CheckFeatureSupport (D3D12_FEATURE Feature, void* pFeatureSupportData, UINT FeatureSupportDataSize)</b><br/>
	/// </summary>
	/// <param name="feature"><b>D3D12_FEATURE Feature</b></param>
	/// <param name="pFeatureSupportData">_Inout_updates_bytes_(FeatureSupportDataSize) <b>void* pFeatureSupportData</b></param>
	/// <param name="featureSupportDataSize"><b>UINT FeatureSupportDataSize</b></param>
	int CheckFeatureSupport (Feature feature, void* pFeatureSupportData, uint featureSupportDataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateDescriptorHeap (D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, REFIID riid, void** ppvHeap)</b><br/>
	/// </summary>
	/// <param name="pDescriptorHeapDesc">_In_ <b>D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvHeap">_COM_Outptr_ <b>void** ppvHeap</b></param>
	int CreateDescriptorHeap (DescriptorHeapDesc* pDescriptorHeapDesc, Guid riid, void** ppvHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateDescriptorHeap (D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, REFIID riid, void** ppvHeap)</b><br/>
	/// </summary>
	/// <param name="pDescriptorHeapDesc">_In_ <b>D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvHeap">_COM_Outptr_ <b>void** ppvHeap</b></param>
	int CreateDescriptorHeap (DescriptorHeapDesc* pDescriptorHeapDesc, Guid riid, out void* ppvHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D12Device::GetDescriptorHandleIncrementSize (D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)</b><br/>
	/// </summary>
	/// <param name="descriptorHeapType">_In_ <b>D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType</b></param>
	uint GetDescriptorHandleIncrementSize (DescriptorHeapType descriptorHeapType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateRootSignature (UINT nodeMask, void* pBlobWithRootSignature, SIZE_T blobLengthInBytes, REFIID riid, void** ppvRootSignature)</b><br/>
	/// </summary>
	/// <param name="nodeMask">_In_ <b>UINT nodeMask</b></param>
	/// <param name="pBlobWithRootSignature">_In_reads_(blobLengthInBytes) <b>void* pBlobWithRootSignature</b></param>
	/// <param name="blobLengthInBytes">_In_ <b>SIZE_T blobLengthInBytes</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvRootSignature">_COM_Outptr_ <b>void** ppvRootSignature</b></param>
	int CreateRootSignature (uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid riid, void** ppvRootSignature);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateRootSignature (UINT nodeMask, void* pBlobWithRootSignature, SIZE_T blobLengthInBytes, REFIID riid, void** ppvRootSignature)</b><br/>
	/// </summary>
	/// <param name="nodeMask">_In_ <b>UINT nodeMask</b></param>
	/// <param name="pBlobWithRootSignature">_In_reads_(blobLengthInBytes) <b>void* pBlobWithRootSignature</b></param>
	/// <param name="blobLengthInBytes">_In_ <b>SIZE_T blobLengthInBytes</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvRootSignature">_COM_Outptr_ <b>void** ppvRootSignature</b></param>
	int CreateRootSignature (uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid riid, out void* ppvRootSignature);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CreateConstantBufferView (D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_opt_ <b>D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc</b></param>
	/// <param name="destDescriptor">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor</b></param>
	void CreateConstantBufferView (ConstantBufferViewDesc* pDesc, CpuDescriptorHandle destDescriptor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CreateShaderResourceView (ID3D12Resource* pResource, D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_opt_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc</b></param>
	/// <param name="destDescriptor">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor</b></param>
	void CreateShaderResourceView<T0> (T0* pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CreateUnorderedAccessView (ID3D12Resource* pResource, ID3D12Resource* pCounterResource, D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_opt_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="pCounterResource">_In_opt_ <b>ID3D12Resource* pCounterResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc</b></param>
	/// <param name="destDescriptor">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor</b></param>
	void CreateUnorderedAccessView<T0, T1> (T0* pResource, T1* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CreateRenderTargetView (ID3D12Resource* pResource, D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_opt_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D12_RENDER_TARGET_VIEW_DESC* pDesc</b></param>
	/// <param name="destDescriptor">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor</b></param>
	void CreateRenderTargetView<T0> (T0* pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CreateDepthStencilView (ID3D12Resource* pResource, D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_opt_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc</b></param>
	/// <param name="destDescriptor">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor</b></param>
	void CreateDepthStencilView<T0> (T0* pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle destDescriptor) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CreateSampler (D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_SAMPLER_DESC* pDesc</b></param>
	/// <param name="destDescriptor">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor</b></param>
	void CreateSampler (SamplerDesc* pDesc, CpuDescriptorHandle destDescriptor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CopyDescriptors (UINT NumDestDescriptorRanges, D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, UINT* pDestDescriptorRangeSizes, UINT NumSrcDescriptorRanges, D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, UINT* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)</b><br/>
	/// </summary>
	/// <param name="numDestDescriptorRanges">_In_ <b>UINT NumDestDescriptorRanges</b></param>
	/// <param name="pDestDescriptorRangeStarts">_In_reads_(NumDestDescriptorRanges) <b>D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts</b></param>
	/// <param name="pDestDescriptorRangeSizes">_In_reads_opt_(NumDestDescriptorRanges) <b>UINT* pDestDescriptorRangeSizes</b></param>
	/// <param name="numSrcDescriptorRanges">_In_ <b>UINT NumSrcDescriptorRanges</b></param>
	/// <param name="pSrcDescriptorRangeStarts">_In_reads_(NumSrcDescriptorRanges) <b>D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts</b></param>
	/// <param name="pSrcDescriptorRangeSizes">_In_reads_opt_(NumSrcDescriptorRanges) <b>UINT* pSrcDescriptorRangeSizes</b></param>
	/// <param name="descriptorHeapsType">_In_ <b>D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType</b></param>
	void CopyDescriptors (uint numDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint numSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType descriptorHeapsType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::CopyDescriptorsSimple (UINT NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)</b><br/>
	/// </summary>
	/// <param name="numDescriptors">_In_ <b>UINT NumDescriptors</b></param>
	/// <param name="destDescriptorRangeStart">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart</b></param>
	/// <param name="srcDescriptorRangeStart">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart</b></param>
	/// <param name="descriptorHeapsType">_In_ <b>D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType</b></param>
	void CopyDescriptorsSimple (uint numDescriptors, CpuDescriptorHandle destDescriptorRangeStart, CpuDescriptorHandle srcDescriptorRangeStart, DescriptorHeapType descriptorHeapsType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_RESOURCE_ALLOCATION_INFO ID3D12Device::GetResourceAllocationInfo (UINT visibleMask, UINT numResourceDescs, D3D12_RESOURCE_DESC* pResourceDescs)</b><br/>
	/// </summary>
	/// <param name="visibleMask">_In_ <b>UINT visibleMask</b></param>
	/// <param name="numResourceDescs">_In_ <b>UINT numResourceDescs</b></param>
	/// <param name="pResourceDescs">_In_reads_(numResourceDescs) <b>D3D12_RESOURCE_DESC* pResourceDescs</b></param>
	ResourceAllocationInfo GetResourceAllocationInfo (uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs);
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_HEAP_PROPERTIES ID3D12Device::GetCustomHeapProperties (UINT nodeMask, D3D12_HEAP_TYPE heapType)</b><br/>
	/// </summary>
	/// <param name="nodeMask">_In_ <b>UINT nodeMask</b></param>
	/// <param name="heapType"><b>D3D12_HEAP_TYPE heapType</b></param>
	HeapProperties GetCustomHeapProperties (uint nodeMask, HeapType heapType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommittedResource (D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, REFIID riidResource, void** ppvResource)</b><br/>
	/// </summary>
	/// <param name="pHeapProperties">_In_ <b>D3D12_HEAP_PROPERTIES* pHeapProperties</b></param>
	/// <param name="heapFlags"><b>D3D12_HEAP_FLAGS HeapFlags</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialResourceState"><b>D3D12_RESOURCE_STATES InitialResourceState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="riidResource"><b>REFIID riidResource</b></param>
	/// <param name="ppvResource">_COM_Outptr_opt_ <b>void** ppvResource</b></param>
	int CreateCommittedResource (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Guid riidResource, void** ppvResource);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommittedResource (D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, REFIID riidResource, void** ppvResource)</b><br/>
	/// </summary>
	/// <param name="pHeapProperties">_In_ <b>D3D12_HEAP_PROPERTIES* pHeapProperties</b></param>
	/// <param name="heapFlags"><b>D3D12_HEAP_FLAGS HeapFlags</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialResourceState"><b>D3D12_RESOURCE_STATES InitialResourceState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="riidResource"><b>REFIID riidResource</b></param>
	/// <param name="ppvResource">_COM_Outptr_opt_ <b>void** ppvResource</b></param>
	int CreateCommittedResource (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Guid riidResource, out void* ppvResource);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateHeap (D3D12_HEAP_DESC* pDesc, REFIID riid, void** ppvHeap)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_HEAP_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvHeap">_COM_Outptr_opt_ <b>void** ppvHeap</b></param>
	int CreateHeap (HeapDesc* pDesc, Guid riid, void** ppvHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateHeap (D3D12_HEAP_DESC* pDesc, REFIID riid, void** ppvHeap)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_HEAP_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvHeap">_COM_Outptr_opt_ <b>void** ppvHeap</b></param>
	int CreateHeap (HeapDesc* pDesc, Guid riid, out void* ppvHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreatePlacedResource (ID3D12Heap* pHeap, UINT64 HeapOffset, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, D3D12_CLEAR_VALUE* pOptimizedClearValue, REFIID riid, void** ppvResource)</b><br/>
	/// </summary>
	/// <param name="pHeap">_In_ <b>ID3D12Heap* pHeap</b></param>
	/// <param name="heapOffset"><b>UINT64 HeapOffset</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialState"><b>D3D12_RESOURCE_STATES InitialState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvResource">_COM_Outptr_opt_ <b>void** ppvResource</b></param>
	int CreatePlacedResource<T0> (T0* pHeap, ulong heapOffset, ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, void** ppvResource) where T0 : unmanaged, IHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreatePlacedResource (ID3D12Heap* pHeap, UINT64 HeapOffset, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, D3D12_CLEAR_VALUE* pOptimizedClearValue, REFIID riid, void** ppvResource)</b><br/>
	/// </summary>
	/// <param name="pHeap">_In_ <b>ID3D12Heap* pHeap</b></param>
	/// <param name="heapOffset"><b>UINT64 HeapOffset</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialState"><b>D3D12_RESOURCE_STATES InitialState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvResource">_COM_Outptr_opt_ <b>void** ppvResource</b></param>
	int CreatePlacedResource<T0> (T0* pHeap, ulong heapOffset, ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, out void* ppvResource) where T0 : unmanaged, IHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateReservedResource (D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, D3D12_CLEAR_VALUE* pOptimizedClearValue, REFIID riid, void** ppvResource)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialState"><b>D3D12_RESOURCE_STATES InitialState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvResource">_COM_Outptr_opt_ <b>void** ppvResource</b></param>
	int CreateReservedResource (ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, void** ppvResource);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateReservedResource (D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, D3D12_CLEAR_VALUE* pOptimizedClearValue, REFIID riid, void** ppvResource)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialState"><b>D3D12_RESOURCE_STATES InitialState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvResource">_COM_Outptr_opt_ <b>void** ppvResource</b></param>
	int CreateReservedResource (ResourceDesc* pDesc, ResourceStates initialState, ClearValue* pOptimizedClearValue, Guid riid, out void* ppvResource);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateSharedHandle (ID3D12DeviceChild* pObject, SECURITY_ATTRIBUTES* pAttributes, DWORD Access, LPCWSTR Name, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pObject">_In_ <b>ID3D12DeviceChild* pObject</b></param>
	/// <param name="pAttributes">_In_opt_ <b>SECURITY_ATTRIBUTES* pAttributes</b></param>
	/// <param name="access"><b>DWORD Access</b></param>
	/// <param name="name">_In_opt_ <b>LPCWSTR Name</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int CreateSharedHandle<T0> (T0* pObject, SecurityAttributes* pAttributes, uint access, char* name, IntPtr* pHandle) where T0 : unmanaged, IDeviceChild;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateSharedHandle (ID3D12DeviceChild* pObject, SECURITY_ATTRIBUTES* pAttributes, DWORD Access, LPCWSTR Name, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pObject">_In_ <b>ID3D12DeviceChild* pObject</b></param>
	/// <param name="pAttributes">_In_opt_ <b>SECURITY_ATTRIBUTES* pAttributes</b></param>
	/// <param name="access"><b>DWORD Access</b></param>
	/// <param name="name">_In_opt_ <b>LPCWSTR Name</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int CreateSharedHandle<T0> (T0* pObject, SecurityAttributes* pAttributes, uint access, char* name, out IntPtr pHandle) where T0 : unmanaged, IDeviceChild;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::OpenSharedHandle (HANDLE NTHandle, REFIID riid, void** ppvObj)</b><br/>
	/// </summary>
	/// <param name="nTHandle">_In_ <b>HANDLE NTHandle</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvObj">_COM_Outptr_opt_ <b>void** ppvObj</b></param>
	int OpenSharedHandle (IntPtr nTHandle, Guid riid, void** ppvObj);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::OpenSharedHandle (HANDLE NTHandle, REFIID riid, void** ppvObj)</b><br/>
	/// </summary>
	/// <param name="nTHandle">_In_ <b>HANDLE NTHandle</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvObj">_COM_Outptr_opt_ <b>void** ppvObj</b></param>
	int OpenSharedHandle (IntPtr nTHandle, Guid riid, out void* ppvObj);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::OpenSharedHandleByName (LPCWSTR Name, DWORD Access, HANDLE* pNTHandle)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>LPCWSTR Name</b></param>
	/// <param name="access"><b>DWORD Access</b></param>
	/// <param name="pNTHandle">_Out_ <b>HANDLE* pNTHandle</b></param>
	int OpenSharedHandleByName (char* name, uint access, IntPtr* pNTHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::OpenSharedHandleByName (LPCWSTR Name, DWORD Access, HANDLE* pNTHandle)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>LPCWSTR Name</b></param>
	/// <param name="access"><b>DWORD Access</b></param>
	/// <param name="pNTHandle">_Out_ <b>HANDLE* pNTHandle</b></param>
	int OpenSharedHandleByName (char* name, uint access, out IntPtr pNTHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::MakeResident (UINT NumObjects, ID3D12Pageable* ppObjects)</b><br/>
	/// </summary>
	/// <param name="numObjects"><b>UINT NumObjects</b></param>
	/// <param name="ppObjects">_In_reads_(NumObjects) <b>ID3D12Pageable* ppObjects</b></param>
	int MakeResident<T0> (uint numObjects, T0* ppObjects) where T0 : unmanaged, IPageable;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::Evict (UINT NumObjects, ID3D12Pageable* ppObjects)</b><br/>
	/// </summary>
	/// <param name="numObjects"><b>UINT NumObjects</b></param>
	/// <param name="ppObjects">_In_reads_(NumObjects) <b>ID3D12Pageable* ppObjects</b></param>
	int Evict<T0> (uint numObjects, T0* ppObjects) where T0 : unmanaged, IPageable;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateFence (UINT64 InitialValue, D3D12_FENCE_FLAGS Flags, REFIID riid, void** ppFence)</b><br/>
	/// </summary>
	/// <param name="initialValue"><b>UINT64 InitialValue</b></param>
	/// <param name="flags"><b>D3D12_FENCE_FLAGS Flags</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppFence">_COM_Outptr_ <b>void** ppFence</b></param>
	int CreateFence (ulong initialValue, FenceFlags flags, Guid riid, void** ppFence);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateFence (UINT64 InitialValue, D3D12_FENCE_FLAGS Flags, REFIID riid, void** ppFence)</b><br/>
	/// </summary>
	/// <param name="initialValue"><b>UINT64 InitialValue</b></param>
	/// <param name="flags"><b>D3D12_FENCE_FLAGS Flags</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppFence">_COM_Outptr_ <b>void** ppFence</b></param>
	int CreateFence (ulong initialValue, FenceFlags flags, Guid riid, out void* ppFence);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::GetDeviceRemovedReason ()</b><br/>
	/// </summary>
	int GetDeviceRemovedReason ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::GetCopyableFootprints (D3D12_RESOURCE_DESC* pResourceDesc, UINT FirstSubresource, UINT NumSubresources, UINT64 BaseOffset, D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, UINT* pNumRows, UINT64* pRowSizeInBytes, UINT64* pTotalBytes)</b><br/>
	/// </summary>
	/// <param name="pResourceDesc">_In_ <b>D3D12_RESOURCE_DESC* pResourceDesc</b></param>
	/// <param name="firstSubresource">_In_range_(0,D3D12_REQ_SUBRESOURCES) <b>UINT FirstSubresource</b></param>
	/// <param name="numSubresources">_In_range_(0,D3D12_REQ_SUBRESOURCES-FirstSubresource) <b>UINT NumSubresources</b></param>
	/// <param name="baseOffset"><b>UINT64 BaseOffset</b></param>
	/// <param name="pLayouts">_Out_writes_opt_(NumSubresources) <b>D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts</b></param>
	/// <param name="pNumRows">_Out_writes_opt_(NumSubresources) <b>UINT* pNumRows</b></param>
	/// <param name="pRowSizeInBytes">_Out_writes_opt_(NumSubresources) <b>UINT64* pRowSizeInBytes</b></param>
	/// <param name="pTotalBytes">_Out_opt_ <b>UINT64* pTotalBytes</b></param>
	void GetCopyableFootprints (ResourceDesc* pResourceDesc, uint firstSubresource, uint numSubresources, ulong baseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::GetCopyableFootprints (D3D12_RESOURCE_DESC* pResourceDesc, UINT FirstSubresource, UINT NumSubresources, UINT64 BaseOffset, D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, UINT* pNumRows, UINT64* pRowSizeInBytes, UINT64* pTotalBytes)</b><br/>
	/// </summary>
	/// <param name="pResourceDesc">_In_ <b>D3D12_RESOURCE_DESC* pResourceDesc</b></param>
	/// <param name="firstSubresource">_In_range_(0,D3D12_REQ_SUBRESOURCES) <b>UINT FirstSubresource</b></param>
	/// <param name="numSubresources">_In_range_(0,D3D12_REQ_SUBRESOURCES-FirstSubresource) <b>UINT NumSubresources</b></param>
	/// <param name="baseOffset"><b>UINT64 BaseOffset</b></param>
	/// <param name="pLayouts">_Out_writes_opt_(NumSubresources) <b>D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts</b></param>
	/// <param name="pNumRows">_Out_writes_opt_(NumSubresources) <b>UINT* pNumRows</b></param>
	/// <param name="pRowSizeInBytes">_Out_writes_opt_(NumSubresources) <b>UINT64* pRowSizeInBytes</b></param>
	/// <param name="pTotalBytes">_Out_opt_ <b>UINT64* pTotalBytes</b></param>
	void GetCopyableFootprints (ResourceDesc* pResourceDesc, uint firstSubresource, uint numSubresources, ulong baseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, out ulong pTotalBytes);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateQueryHeap (D3D12_QUERY_HEAP_DESC* pDesc, REFIID riid, void** ppvHeap)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_QUERY_HEAP_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvHeap">_COM_Outptr_opt_ <b>void** ppvHeap</b></param>
	int CreateQueryHeap (QueryHeapDesc* pDesc, Guid riid, void** ppvHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateQueryHeap (D3D12_QUERY_HEAP_DESC* pDesc, REFIID riid, void** ppvHeap)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_QUERY_HEAP_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvHeap">_COM_Outptr_opt_ <b>void** ppvHeap</b></param>
	int CreateQueryHeap (QueryHeapDesc* pDesc, Guid riid, out void* ppvHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::SetStablePowerState (BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="enable"><b>BOOL Enable</b></param>
	int SetStablePowerState (bool enable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandSignature (D3D12_COMMAND_SIGNATURE_DESC* pDesc, ID3D12RootSignature* pRootSignature, REFIID riid, void** ppvCommandSignature)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_COMMAND_SIGNATURE_DESC* pDesc</b></param>
	/// <param name="pRootSignature">_In_opt_ <b>ID3D12RootSignature* pRootSignature</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvCommandSignature">_COM_Outptr_opt_ <b>void** ppvCommandSignature</b></param>
	int CreateCommandSignature<T0> (CommandSignatureDesc* pDesc, T0* pRootSignature, Guid riid, void** ppvCommandSignature) where T0 : unmanaged, IRootSignature;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Device::CreateCommandSignature (D3D12_COMMAND_SIGNATURE_DESC* pDesc, ID3D12RootSignature* pRootSignature, REFIID riid, void** ppvCommandSignature)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D12_COMMAND_SIGNATURE_DESC* pDesc</b></param>
	/// <param name="pRootSignature">_In_opt_ <b>ID3D12RootSignature* pRootSignature</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvCommandSignature">_COM_Outptr_opt_ <b>void** ppvCommandSignature</b></param>
	int CreateCommandSignature<T0> (CommandSignatureDesc* pDesc, T0* pRootSignature, Guid riid, out void* ppvCommandSignature) where T0 : unmanaged, IRootSignature;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::GetResourceTiling (ID3D12Resource* pTiledResource, UINT* pNumTilesForEntireResource, D3D12_PACKED_MIP_INFO* pPackedMipDesc, D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, UINT* pNumSubresourceTilings, UINT FirstSubresourceTilingToGet, D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)</b><br/>
	/// </summary>
	/// <param name="pTiledResource">_In_ <b>ID3D12Resource* pTiledResource</b></param>
	/// <param name="pNumTilesForEntireResource">_Out_opt_ <b>UINT* pNumTilesForEntireResource</b></param>
	/// <param name="pPackedMipDesc">_Out_opt_ <b>D3D12_PACKED_MIP_INFO* pPackedMipDesc</b></param>
	/// <param name="pStandardTileShapeForNonPackedMips">_Out_opt_ <b>D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips</b></param>
	/// <param name="pNumSubresourceTilings">_Inout_opt_ <b>UINT* pNumSubresourceTilings</b></param>
	/// <param name="firstSubresourceTilingToGet">_In_ <b>UINT FirstSubresourceTilingToGet</b></param>
	/// <param name="pSubresourceTilingsForNonPackedMips">_Out_writes_(*pNumSubresourceTilings) <b>D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips</b></param>
	void GetResourceTiling<T0> (T0* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Device::GetResourceTiling (ID3D12Resource* pTiledResource, UINT* pNumTilesForEntireResource, D3D12_PACKED_MIP_INFO* pPackedMipDesc, D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, UINT* pNumSubresourceTilings, UINT FirstSubresourceTilingToGet, D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)</b><br/>
	/// </summary>
	/// <param name="pTiledResource">_In_ <b>ID3D12Resource* pTiledResource</b></param>
	/// <param name="pNumTilesForEntireResource">_Out_opt_ <b>UINT* pNumTilesForEntireResource</b></param>
	/// <param name="pPackedMipDesc">_Out_opt_ <b>D3D12_PACKED_MIP_INFO* pPackedMipDesc</b></param>
	/// <param name="pStandardTileShapeForNonPackedMips">_Out_opt_ <b>D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips</b></param>
	/// <param name="pNumSubresourceTilings">_Inout_opt_ <b>UINT* pNumSubresourceTilings</b></param>
	/// <param name="firstSubresourceTilingToGet">_In_ <b>UINT FirstSubresourceTilingToGet</b></param>
	/// <param name="pSubresourceTilingsForNonPackedMips">_Out_writes_(*pNumSubresourceTilings) <b>D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips</b></param>
	void GetResourceTiling<T0> (T0* pTiledResource, out uint pNumTilesForEntireResource, out PackedMipInfo pPackedMipDesc, out TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>LUID ID3D12Device::GetAdapterLuid ()</b><br/>
	/// </summary>
	LUID GetAdapterLuid ();
}

/// <summary>
/// Instance of <b>ID3D12Device</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct Device : IDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device* GetCurrentPointer () => (Device*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x189819f1, 0x1db6, 0x4b57, 0xbe, 0x54, 0x18, 0x21, 0x33, 0x9b, 0x85, 0xf7);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
