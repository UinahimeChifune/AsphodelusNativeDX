using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12GraphicsCommandList</b> : ID3D12CommandList<br/>
/// D3D12.h
/// </summary>
unsafe public interface IGraphicsCommandList : ICommandList {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12GraphicsCommandList::Close ()</b><br/>
	/// </summary>
	int Close ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12GraphicsCommandList::Reset (ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)</b><br/>
	/// </summary>
	/// <param name="pAllocator">_In_ <b>ID3D12CommandAllocator* pAllocator</b></param>
	/// <param name="pInitialState">_In_opt_ <b>ID3D12PipelineState* pInitialState</b></param>
	int Reset<T0, T1> (T0* pAllocator, T1* pInitialState) where T0 : unmanaged, ICommandAllocator where T1 : unmanaged, IPipelineState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ClearState (ID3D12PipelineState* pPipelineState)</b><br/>
	/// </summary>
	/// <param name="pPipelineState">_In_opt_ <b>ID3D12PipelineState* pPipelineState</b></param>
	void ClearState<T0> (T0* pPipelineState) where T0 : unmanaged, IPipelineState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::DrawInstanced (UINT VertexCountPerInstance, UINT InstanceCount, UINT StartVertexLocation, UINT StartInstanceLocation)</b><br/>
	/// </summary>
	/// <param name="vertexCountPerInstance">_In_ <b>UINT VertexCountPerInstance</b></param>
	/// <param name="instanceCount">_In_ <b>UINT InstanceCount</b></param>
	/// <param name="startVertexLocation">_In_ <b>UINT StartVertexLocation</b></param>
	/// <param name="startInstanceLocation">_In_ <b>UINT StartInstanceLocation</b></param>
	void DrawInstanced (uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::DrawIndexedInstanced (UINT IndexCountPerInstance, UINT InstanceCount, UINT StartIndexLocation, INT BaseVertexLocation, UINT StartInstanceLocation)</b><br/>
	/// </summary>
	/// <param name="indexCountPerInstance">_In_ <b>UINT IndexCountPerInstance</b></param>
	/// <param name="instanceCount">_In_ <b>UINT InstanceCount</b></param>
	/// <param name="startIndexLocation">_In_ <b>UINT StartIndexLocation</b></param>
	/// <param name="baseVertexLocation">_In_ <b>INT BaseVertexLocation</b></param>
	/// <param name="startInstanceLocation">_In_ <b>UINT StartInstanceLocation</b></param>
	void DrawIndexedInstanced (uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexLocation, uint startInstanceLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::Dispatch (UINT ThreadGroupCountX, UINT ThreadGroupCountY, UINT ThreadGroupCountZ)</b><br/>
	/// </summary>
	/// <param name="threadGroupCountX">_In_ <b>UINT ThreadGroupCountX</b></param>
	/// <param name="threadGroupCountY">_In_ <b>UINT ThreadGroupCountY</b></param>
	/// <param name="threadGroupCountZ">_In_ <b>UINT ThreadGroupCountZ</b></param>
	void Dispatch (uint threadGroupCountX, uint threadGroupCountY, uint threadGroupCountZ);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::CopyBufferRegion (ID3D12Resource* pDstBuffer, UINT64 DstOffset, ID3D12Resource* pSrcBuffer, UINT64 SrcOffset, UINT64 NumBytes)</b><br/>
	/// </summary>
	/// <param name="pDstBuffer">_In_ <b>ID3D12Resource* pDstBuffer</b></param>
	/// <param name="dstOffset"><b>UINT64 DstOffset</b></param>
	/// <param name="pSrcBuffer">_In_ <b>ID3D12Resource* pSrcBuffer</b></param>
	/// <param name="srcOffset"><b>UINT64 SrcOffset</b></param>
	/// <param name="numBytes"><b>UINT64 NumBytes</b></param>
	void CopyBufferRegion<T0, T1> (T0* pDstBuffer, ulong dstOffset, T1* pSrcBuffer, ulong srcOffset, ulong numBytes) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::CopyTextureRegion (D3D12_TEXTURE_COPY_LOCATION* pDst, UINT DstX, UINT DstY, UINT DstZ, D3D12_TEXTURE_COPY_LOCATION* pSrc, D3D12_BOX* pSrcBox)</b><br/>
	/// </summary>
	/// <param name="pDst">_In_ <b>D3D12_TEXTURE_COPY_LOCATION* pDst</b></param>
	/// <param name="dstX"><b>UINT DstX</b></param>
	/// <param name="dstY"><b>UINT DstY</b></param>
	/// <param name="dstZ"><b>UINT DstZ</b></param>
	/// <param name="pSrc">_In_ <b>D3D12_TEXTURE_COPY_LOCATION* pSrc</b></param>
	/// <param name="pSrcBox">_In_opt_ <b>D3D12_BOX* pSrcBox</b></param>
	void CopyTextureRegion (TextureCopyLocation* pDst, uint dstX, uint dstY, uint dstZ, TextureCopyLocation* pSrc, Box* pSrcBox);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::CopyResource (ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D12Resource* pDstResource</b></param>
	/// <param name="pSrcResource">_In_ <b>ID3D12Resource* pSrcResource</b></param>
	void CopyResource<T0, T1> (T0* pDstResource, T1* pSrcResource) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::CopyTiles (ID3D12Resource* pTiledResource, D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, D3D12_TILE_REGION_SIZE* pTileRegionSize, ID3D12Resource* pBuffer, UINT64 BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags)</b><br/>
	/// </summary>
	/// <param name="pTiledResource">_In_ <b>ID3D12Resource* pTiledResource</b></param>
	/// <param name="pTileRegionStartCoordinate">_In_ <b>D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate</b></param>
	/// <param name="pTileRegionSize">_In_ <b>D3D12_TILE_REGION_SIZE* pTileRegionSize</b></param>
	/// <param name="pBuffer">_In_ <b>ID3D12Resource* pBuffer</b></param>
	/// <param name="bufferStartOffsetInBytes"><b>UINT64 BufferStartOffsetInBytes</b></param>
	/// <param name="flags"><b>D3D12_TILE_COPY_FLAGS Flags</b></param>
	void CopyTiles<T0, T1> (T0* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, T1* pBuffer, ulong bufferStartOffsetInBytes, TileCopyFlags flags) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ResolveSubresource (ID3D12Resource* pDstResource, UINT DstSubresource, ID3D12Resource* pSrcResource, UINT SrcSubresource, DXGI_FORMAT Format)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D12Resource* pDstResource</b></param>
	/// <param name="dstSubresource">_In_ <b>UINT DstSubresource</b></param>
	/// <param name="pSrcResource">_In_ <b>ID3D12Resource* pSrcResource</b></param>
	/// <param name="srcSubresource">_In_ <b>UINT SrcSubresource</b></param>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	void ResolveSubresource<T0, T1> (T0* pDstResource, uint dstSubresource, T1* pSrcResource, uint srcSubresource, DXGI.Format format) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::IASetPrimitiveTopology (D3D12_PRIMITIVE_TOPOLOGY PrimitiveTopology)</b><br/>
	/// </summary>
	/// <param name="primitiveTopology">_In_ <b>D3D12_PRIMITIVE_TOPOLOGY PrimitiveTopology</b></param>
	void IASetPrimitiveTopology (PrimitiveTopologyType primitiveTopology);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::RSSetViewports (UINT NumViewports, D3D12_VIEWPORT* pViewports)</b><br/>
	/// </summary>
	/// <param name="numViewports">_In_range_(0, D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) <b>UINT NumViewports</b></param>
	/// <param name="pViewports">_In_reads_( NumViewports) <b>D3D12_VIEWPORT* pViewports</b></param>
	void RSSetViewports (uint numViewports, Viewport* pViewports);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::RSSetScissorRects (UINT NumRects, D3D12_RECT* pRects)</b><br/>
	/// </summary>
	/// <param name="numRects">_In_range_(0, D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) <b>UINT NumRects</b></param>
	/// <param name="pRects">_In_reads_( NumRects) <b>D3D12_RECT* pRects</b></param>
	void RSSetScissorRects (uint numRects, Vector4I* pRects);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::OMSetBlendFactor ()</b><br/>
	/// </summary>
	void OMSetBlendFactor ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::OMSetStencilRef (UINT StencilRef)</b><br/>
	/// </summary>
	/// <param name="stencilRef">_In_ <b>UINT StencilRef</b></param>
	void OMSetStencilRef (uint stencilRef);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetPipelineState (ID3D12PipelineState* pPipelineState)</b><br/>
	/// </summary>
	/// <param name="pPipelineState">_In_ <b>ID3D12PipelineState* pPipelineState</b></param>
	void SetPipelineState<T0> (T0* pPipelineState) where T0 : unmanaged, IPipelineState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ResourceBarrier (UINT NumBarriers, D3D12_RESOURCE_BARRIER* pBarriers)</b><br/>
	/// </summary>
	/// <param name="numBarriers">_In_ <b>UINT NumBarriers</b></param>
	/// <param name="pBarriers">_In_reads_(NumBarriers) <b>D3D12_RESOURCE_BARRIER* pBarriers</b></param>
	void ResourceBarrier (uint numBarriers, ResourceBarrier* pBarriers);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ExecuteBundle (ID3D12GraphicsCommandList* pCommandList)</b><br/>
	/// </summary>
	/// <param name="pCommandList">_In_ <b>ID3D12GraphicsCommandList* pCommandList</b></param>
	void ExecuteBundle<T0> (T0* pCommandList) where T0 : unmanaged, IGraphicsCommandList;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetDescriptorHeaps (UINT NumDescriptorHeaps, ID3D12DescriptorHeap* ppDescriptorHeaps)</b><br/>
	/// </summary>
	/// <param name="numDescriptorHeaps">_In_ <b>UINT NumDescriptorHeaps</b></param>
	/// <param name="ppDescriptorHeaps">_In_reads_(NumDescriptorHeaps) <b>ID3D12DescriptorHeap* ppDescriptorHeaps</b></param>
	void SetDescriptorHeaps<T0> (uint numDescriptorHeaps, T0* ppDescriptorHeaps) where T0 : unmanaged, IDescriptorHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetComputeRootSignature (ID3D12RootSignature* pRootSignature)</b><br/>
	/// </summary>
	/// <param name="pRootSignature">_In_opt_ <b>ID3D12RootSignature* pRootSignature</b></param>
	void SetComputeRootSignature<T0> (T0* pRootSignature) where T0 : unmanaged, IRootSignature;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetGraphicsRootSignature (ID3D12RootSignature* pRootSignature)</b><br/>
	/// </summary>
	/// <param name="pRootSignature">_In_opt_ <b>ID3D12RootSignature* pRootSignature</b></param>
	void SetGraphicsRootSignature<T0> (T0* pRootSignature) where T0 : unmanaged, IRootSignature;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetComputeRootDescriptorTable (UINT RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="baseDescriptor">_In_ <b>D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor</b></param>
	void SetComputeRootDescriptorTable (uint rootParameterIndex, GpuDescriptorHandle baseDescriptor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetGraphicsRootDescriptorTable (UINT RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="baseDescriptor">_In_ <b>D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor</b></param>
	void SetGraphicsRootDescriptorTable (uint rootParameterIndex, GpuDescriptorHandle baseDescriptor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetComputeRoot32BitConstant (UINT RootParameterIndex, UINT SrcData, UINT DestOffsetIn32BitValues)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="srcData">_In_ <b>UINT SrcData</b></param>
	/// <param name="destOffsetIn32BitValues">_In_ <b>UINT DestOffsetIn32BitValues</b></param>
	void SetComputeRoot32BitConstant (uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetGraphicsRoot32BitConstant (UINT RootParameterIndex, UINT SrcData, UINT DestOffsetIn32BitValues)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="srcData">_In_ <b>UINT SrcData</b></param>
	/// <param name="destOffsetIn32BitValues">_In_ <b>UINT DestOffsetIn32BitValues</b></param>
	void SetGraphicsRoot32BitConstant (uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetComputeRoot32BitConstants (UINT RootParameterIndex, UINT Num32BitValuesToSet, void* pSrcData, UINT DestOffsetIn32BitValues)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="num32BitValuesToSet">_In_ <b>UINT Num32BitValuesToSet</b></param>
	/// <param name="pSrcData">_In_reads_(Num32BitValuesToSet*sizeof(UINT)) <b>void* pSrcData</b></param>
	/// <param name="destOffsetIn32BitValues">_In_ <b>UINT DestOffsetIn32BitValues</b></param>
	void SetComputeRoot32BitConstants (uint rootParameterIndex, uint num32BitValuesToSet, void* pSrcData, uint destOffsetIn32BitValues);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetGraphicsRoot32BitConstants (UINT RootParameterIndex, UINT Num32BitValuesToSet, void* pSrcData, UINT DestOffsetIn32BitValues)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="num32BitValuesToSet">_In_ <b>UINT Num32BitValuesToSet</b></param>
	/// <param name="pSrcData">_In_reads_(Num32BitValuesToSet*sizeof(UINT)) <b>void* pSrcData</b></param>
	/// <param name="destOffsetIn32BitValues">_In_ <b>UINT DestOffsetIn32BitValues</b></param>
	void SetGraphicsRoot32BitConstants (uint rootParameterIndex, uint num32BitValuesToSet, void* pSrcData, uint destOffsetIn32BitValues);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetComputeRootConstantBufferView (UINT RootParameterIndex, D3D12_GPU_VIRTUAL_ADDRESS BufferLocation)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="bufferLocation">_In_ <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b></param>
	void SetComputeRootConstantBufferView (uint rootParameterIndex, ulong bufferLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetGraphicsRootConstantBufferView (UINT RootParameterIndex, D3D12_GPU_VIRTUAL_ADDRESS BufferLocation)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="bufferLocation">_In_ <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b></param>
	void SetGraphicsRootConstantBufferView (uint rootParameterIndex, ulong bufferLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetComputeRootShaderResourceView (UINT RootParameterIndex, D3D12_GPU_VIRTUAL_ADDRESS BufferLocation)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="bufferLocation">_In_ <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b></param>
	void SetComputeRootShaderResourceView (uint rootParameterIndex, ulong bufferLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetGraphicsRootShaderResourceView (UINT RootParameterIndex, D3D12_GPU_VIRTUAL_ADDRESS BufferLocation)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="bufferLocation">_In_ <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b></param>
	void SetGraphicsRootShaderResourceView (uint rootParameterIndex, ulong bufferLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetComputeRootUnorderedAccessView (UINT RootParameterIndex, D3D12_GPU_VIRTUAL_ADDRESS BufferLocation)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="bufferLocation">_In_ <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b></param>
	void SetComputeRootUnorderedAccessView (uint rootParameterIndex, ulong bufferLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetGraphicsRootUnorderedAccessView (UINT RootParameterIndex, D3D12_GPU_VIRTUAL_ADDRESS BufferLocation)</b><br/>
	/// </summary>
	/// <param name="rootParameterIndex">_In_ <b>UINT RootParameterIndex</b></param>
	/// <param name="bufferLocation">_In_ <b>D3D12_GPU_VIRTUAL_ADDRESS BufferLocation</b></param>
	void SetGraphicsRootUnorderedAccessView (uint rootParameterIndex, ulong bufferLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::IASetIndexBuffer (D3D12_INDEX_BUFFER_VIEW* pView)</b><br/>
	/// </summary>
	/// <param name="pView">_In_opt_ <b>D3D12_INDEX_BUFFER_VIEW* pView</b></param>
	void IASetIndexBuffer (IndexBufferView* pView);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::IASetVertexBuffers (UINT StartSlot, UINT NumViews, D3D12_VERTEX_BUFFER_VIEW* pViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_ <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_ <b>UINT NumViews</b></param>
	/// <param name="pViews">_In_reads_opt_(NumViews) <b>D3D12_VERTEX_BUFFER_VIEW* pViews</b></param>
	void IASetVertexBuffers (uint startSlot, uint numViews, VertexBufferView* pViews);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SOSetTargets (UINT StartSlot, UINT NumViews, D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_ <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_ <b>UINT NumViews</b></param>
	/// <param name="pViews">_In_reads_opt_(NumViews) <b>D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews</b></param>
	void SOSetTargets (uint startSlot, uint numViews, StreamOutputBufferView* pViews);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::OMSetRenderTargets (UINT NumRenderTargetDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, BOOL RTsSingleHandleToDescriptorRange, D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor)</b><br/>
	/// </summary>
	/// <param name="numRenderTargetDescriptors">_In_ <b>UINT NumRenderTargetDescriptors</b></param>
	/// <param name="pRenderTargetDescriptors">_In_opt_ <b>D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors</b></param>
	/// <param name="rTsSingleHandleToDescriptorRange">_In_ <b>BOOL RTsSingleHandleToDescriptorRange</b></param>
	/// <param name="pDepthStencilDescriptor">_In_opt_ <b>D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor</b></param>
	void OMSetRenderTargets (uint numRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, bool rTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ClearDepthStencilView (D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, FLOAT Depth, UINT8 Stencil, UINT NumRects, D3D12_RECT* pRects)</b><br/>
	/// </summary>
	/// <param name="depthStencilView">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView</b></param>
	/// <param name="clearFlags">_In_ <b>D3D12_CLEAR_FLAGS ClearFlags</b></param>
	/// <param name="depth">_In_ <b>FLOAT Depth</b></param>
	/// <param name="stencil">_In_ <b>UINT8 Stencil</b></param>
	/// <param name="numRects">_In_ <b>UINT NumRects</b></param>
	/// <param name="pRects">_In_reads_(NumRects) <b>D3D12_RECT* pRects</b></param>
	void ClearDepthStencilView (CpuDescriptorHandle depthStencilView, ClearFlags clearFlags, float depth, byte stencil, uint numRects, Vector4I* pRects);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ClearRenderTargetView (D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, FLOAT [4] ColorRGBA, UINT NumRects, D3D12_RECT* pRects)</b><br/>
	/// </summary>
	/// <param name="renderTargetView">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView</b></param>
	/// <param name="colorRGBA">_In_ <b>FLOAT [4] ColorRGBA</b></param>
	/// <param name="numRects">_In_ <b>UINT NumRects</b></param>
	/// <param name="pRects">_In_reads_(NumRects) <b>D3D12_RECT* pRects</b></param>
	void ClearRenderTargetView (CpuDescriptorHandle renderTargetView, Vector4F* colorRGBA, uint numRects, Vector4I* pRects);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ClearUnorderedAccessViewUint (D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, UINT [4] Values, UINT NumRects, D3D12_RECT* pRects)</b><br/>
	/// </summary>
	/// <param name="viewGPUHandleInCurrentHeap">_In_ <b>D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap</b></param>
	/// <param name="viewCPUHandle">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle</b></param>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="values">_In_ <b>UINT [4] Values</b></param>
	/// <param name="numRects">_In_ <b>UINT NumRects</b></param>
	/// <param name="pRects">_In_reads_(NumRects) <b>D3D12_RECT* pRects</b></param>
	void ClearUnorderedAccessViewUint<T0> (GpuDescriptorHandle viewGPUHandleInCurrentHeap, CpuDescriptorHandle viewCPUHandle, T0* pResource, Vector4U* values, uint numRects, Vector4I* pRects) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ClearUnorderedAccessViewFloat (D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, FLOAT [4] Values, UINT NumRects, D3D12_RECT* pRects)</b><br/>
	/// </summary>
	/// <param name="viewGPUHandleInCurrentHeap">_In_ <b>D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap</b></param>
	/// <param name="viewCPUHandle">_In_ <b>D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle</b></param>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="values">_In_ <b>FLOAT [4] Values</b></param>
	/// <param name="numRects">_In_ <b>UINT NumRects</b></param>
	/// <param name="pRects">_In_reads_(NumRects) <b>D3D12_RECT* pRects</b></param>
	void ClearUnorderedAccessViewFloat<T0> (GpuDescriptorHandle viewGPUHandleInCurrentHeap, CpuDescriptorHandle viewCPUHandle, T0* pResource, Vector4F* values, uint numRects, Vector4I* pRects) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::DiscardResource (ID3D12Resource* pResource, D3D12_DISCARD_REGION* pRegion)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="pRegion">_In_opt_ <b>D3D12_DISCARD_REGION* pRegion</b></param>
	void DiscardResource<T0> (T0* pResource, DiscardRegion* pRegion) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::BeginQuery (ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, UINT Index)</b><br/>
	/// </summary>
	/// <param name="pQueryHeap">_In_ <b>ID3D12QueryHeap* pQueryHeap</b></param>
	/// <param name="type">_In_ <b>D3D12_QUERY_TYPE Type</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	void BeginQuery<T0> (T0* pQueryHeap, QueryType type, uint index) where T0 : unmanaged, IQueryHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::EndQuery (ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, UINT Index)</b><br/>
	/// </summary>
	/// <param name="pQueryHeap">_In_ <b>ID3D12QueryHeap* pQueryHeap</b></param>
	/// <param name="type">_In_ <b>D3D12_QUERY_TYPE Type</b></param>
	/// <param name="index">_In_ <b>UINT Index</b></param>
	void EndQuery<T0> (T0* pQueryHeap, QueryType type, uint index) where T0 : unmanaged, IQueryHeap;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ResolveQueryData (ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, UINT StartIndex, UINT NumQueries, ID3D12Resource* pDestinationBuffer, UINT64 AlignedDestinationBufferOffset)</b><br/>
	/// </summary>
	/// <param name="pQueryHeap">_In_ <b>ID3D12QueryHeap* pQueryHeap</b></param>
	/// <param name="type">_In_ <b>D3D12_QUERY_TYPE Type</b></param>
	/// <param name="startIndex">_In_ <b>UINT StartIndex</b></param>
	/// <param name="numQueries">_In_ <b>UINT NumQueries</b></param>
	/// <param name="pDestinationBuffer">_In_ <b>ID3D12Resource* pDestinationBuffer</b></param>
	/// <param name="alignedDestinationBufferOffset">_In_ <b>UINT64 AlignedDestinationBufferOffset</b></param>
	void ResolveQueryData<T0, T1> (T0* pQueryHeap, QueryType type, uint startIndex, uint numQueries, T1* pDestinationBuffer, ulong alignedDestinationBufferOffset) where T0 : unmanaged, IQueryHeap where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetPredication (ID3D12Resource* pBuffer, UINT64 AlignedBufferOffset, D3D12_PREDICATION_OP Operation)</b><br/>
	/// </summary>
	/// <param name="pBuffer">_In_opt_ <b>ID3D12Resource* pBuffer</b></param>
	/// <param name="alignedBufferOffset">_In_ <b>UINT64 AlignedBufferOffset</b></param>
	/// <param name="operation">_In_ <b>D3D12_PREDICATION_OP Operation</b></param>
	void SetPredication<T0> (T0* pBuffer, ulong alignedBufferOffset, PredicationOp operation) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::SetMarker (UINT Metadata, void* pData, UINT Size)</b><br/>
	/// </summary>
	/// <param name="metadata"><b>UINT Metadata</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(Size) <b>void* pData</b></param>
	/// <param name="size"><b>UINT Size</b></param>
	void SetMarker (uint metadata, void* pData, uint size);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::BeginEvent (UINT Metadata, void* pData, UINT Size)</b><br/>
	/// </summary>
	/// <param name="metadata"><b>UINT Metadata</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(Size) <b>void* pData</b></param>
	/// <param name="size"><b>UINT Size</b></param>
	void BeginEvent (uint metadata, void* pData, uint size);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::EndEvent ()</b><br/>
	/// </summary>
	void EndEvent ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList::ExecuteIndirect (ID3D12CommandSignature* pCommandSignature, UINT MaxCommandCount, ID3D12Resource* pArgumentBuffer, UINT64 ArgumentBufferOffset, ID3D12Resource* pCountBuffer, UINT64 CountBufferOffset)</b><br/>
	/// </summary>
	/// <param name="pCommandSignature">_In_ <b>ID3D12CommandSignature* pCommandSignature</b></param>
	/// <param name="maxCommandCount">_In_ <b>UINT MaxCommandCount</b></param>
	/// <param name="pArgumentBuffer">_In_ <b>ID3D12Resource* pArgumentBuffer</b></param>
	/// <param name="argumentBufferOffset">_In_ <b>UINT64 ArgumentBufferOffset</b></param>
	/// <param name="pCountBuffer">_In_opt_ <b>ID3D12Resource* pCountBuffer</b></param>
	/// <param name="countBufferOffset">_In_ <b>UINT64 CountBufferOffset</b></param>
	void ExecuteIndirect<T0, T1, T2> (T0* pCommandSignature, uint maxCommandCount, T1* pArgumentBuffer, ulong argumentBufferOffset, T2* pCountBuffer, ulong countBufferOffset) where T0 : unmanaged, ICommandSignature where T1 : unmanaged, IResource where T2 : unmanaged, IResource;
}

/// <summary>
/// Instance of <b>ID3D12GraphicsCommandList</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct GraphicsCommandList : IGraphicsCommandList {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GraphicsCommandList* GetCurrentPointer () => (GraphicsCommandList*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x5b160d0f, 0xac1b, 0x4185, 0x8b, 0xa8, 0xb3, 0xae, 0x42, 0xa5, 0xa4, 0x55);

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
	public readonly int Reset<T0, T1> (T0* pAllocator, T1* pInitialState) where T0 : unmanaged, ICommandAllocator where T1 : unmanaged, IPipelineState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Reset (ptr, pAllocator, pInitialState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearState<T0> (T0* pPipelineState) where T0 : unmanaged, IPipelineState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearState (ptr, pPipelineState);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawInstanced (uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawInstanced (ptr, vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawIndexedInstanced (uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexLocation, uint startInstanceLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawIndexedInstanced (ptr, indexCountPerInstance, instanceCount, startIndexLocation, baseVertexLocation, startInstanceLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Dispatch (uint threadGroupCountX, uint threadGroupCountY, uint threadGroupCountZ) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Dispatch (ptr, threadGroupCountX, threadGroupCountY, threadGroupCountZ);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyBufferRegion<T0, T1> (T0* pDstBuffer, ulong dstOffset, T1* pSrcBuffer, ulong srcOffset, ulong numBytes) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyBufferRegion (ptr, pDstBuffer, dstOffset, pSrcBuffer, srcOffset, numBytes);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyTextureRegion (TextureCopyLocation* pDst, uint dstX, uint dstY, uint dstZ, TextureCopyLocation* pSrc, Box* pSrcBox) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyTextureRegion (ptr, pDst, dstX, dstY, dstZ, pSrc, pSrcBox);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyResource<T0, T1> (T0* pDstResource, T1* pSrcResource) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyResource (ptr, pDstResource, pSrcResource);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyTiles<T0, T1> (T0* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, T1* pBuffer, ulong bufferStartOffsetInBytes, TileCopyFlags flags) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyTiles (ptr, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, bufferStartOffsetInBytes, flags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ResolveSubresource<T0, T1> (T0* pDstResource, uint dstSubresource, T1* pSrcResource, uint srcSubresource, DXGI.Format format) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ResolveSubresource (ptr, pDstResource, dstSubresource, pSrcResource, srcSubresource, format);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IASetPrimitiveTopology (PrimitiveTopologyType primitiveTopology) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IASetPrimitiveTopology (ptr, primitiveTopology);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RSSetViewports (uint numViewports, Viewport* pViewports) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->RSSetViewports (ptr, numViewports, pViewports);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RSSetScissorRects (uint numRects, Vector4I* pRects) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->RSSetScissorRects (ptr, numRects, pRects);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetBlendFactor () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetBlendFactor (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetStencilRef (uint stencilRef) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetStencilRef (ptr, stencilRef);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetPipelineState<T0> (T0* pPipelineState) where T0 : unmanaged, IPipelineState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetPipelineState (ptr, pPipelineState);
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
	public readonly void ExecuteBundle<T0> (T0* pCommandList) where T0 : unmanaged, IGraphicsCommandList {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ExecuteBundle (ptr, pCommandList);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetDescriptorHeaps<T0> (uint numDescriptorHeaps, T0* ppDescriptorHeaps) where T0 : unmanaged, IDescriptorHeap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetDescriptorHeaps (ptr, numDescriptorHeaps, ppDescriptorHeaps);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetComputeRootSignature<T0> (T0* pRootSignature) where T0 : unmanaged, IRootSignature {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetComputeRootSignature (ptr, pRootSignature);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGraphicsRootSignature<T0> (T0* pRootSignature) where T0 : unmanaged, IRootSignature {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGraphicsRootSignature (ptr, pRootSignature);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetComputeRootDescriptorTable (uint rootParameterIndex, GpuDescriptorHandle baseDescriptor) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetComputeRootDescriptorTable (ptr, rootParameterIndex, baseDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGraphicsRootDescriptorTable (uint rootParameterIndex, GpuDescriptorHandle baseDescriptor) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGraphicsRootDescriptorTable (ptr, rootParameterIndex, baseDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetComputeRoot32BitConstant (uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetComputeRoot32BitConstant (ptr, rootParameterIndex, srcData, destOffsetIn32BitValues);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGraphicsRoot32BitConstant (uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGraphicsRoot32BitConstant (ptr, rootParameterIndex, srcData, destOffsetIn32BitValues);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetComputeRoot32BitConstants (uint rootParameterIndex, uint num32BitValuesToSet, void* pSrcData, uint destOffsetIn32BitValues) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetComputeRoot32BitConstants (ptr, rootParameterIndex, num32BitValuesToSet, pSrcData, destOffsetIn32BitValues);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGraphicsRoot32BitConstants (uint rootParameterIndex, uint num32BitValuesToSet, void* pSrcData, uint destOffsetIn32BitValues) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGraphicsRoot32BitConstants (ptr, rootParameterIndex, num32BitValuesToSet, pSrcData, destOffsetIn32BitValues);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetComputeRootConstantBufferView (uint rootParameterIndex, ulong bufferLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetComputeRootConstantBufferView (ptr, rootParameterIndex, bufferLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGraphicsRootConstantBufferView (uint rootParameterIndex, ulong bufferLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGraphicsRootConstantBufferView (ptr, rootParameterIndex, bufferLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetComputeRootShaderResourceView (uint rootParameterIndex, ulong bufferLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetComputeRootShaderResourceView (ptr, rootParameterIndex, bufferLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGraphicsRootShaderResourceView (uint rootParameterIndex, ulong bufferLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGraphicsRootShaderResourceView (ptr, rootParameterIndex, bufferLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetComputeRootUnorderedAccessView (uint rootParameterIndex, ulong bufferLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetComputeRootUnorderedAccessView (ptr, rootParameterIndex, bufferLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGraphicsRootUnorderedAccessView (uint rootParameterIndex, ulong bufferLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGraphicsRootUnorderedAccessView (ptr, rootParameterIndex, bufferLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IASetIndexBuffer (IndexBufferView* pView) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IASetIndexBuffer (ptr, pView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IASetVertexBuffers (uint startSlot, uint numViews, VertexBufferView* pViews) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IASetVertexBuffers (ptr, startSlot, numViews, pViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SOSetTargets (uint startSlot, uint numViews, StreamOutputBufferView* pViews) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SOSetTargets (ptr, startSlot, numViews, pViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetRenderTargets (uint numRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, bool rTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetRenderTargets (ptr, numRenderTargetDescriptors, pRenderTargetDescriptors, rTsSingleHandleToDescriptorRange ? 1U : 0U, pDepthStencilDescriptor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearDepthStencilView (CpuDescriptorHandle depthStencilView, ClearFlags clearFlags, float depth, byte stencil, uint numRects, Vector4I* pRects) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearDepthStencilView (ptr, depthStencilView, clearFlags, depth, stencil, numRects, pRects);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearRenderTargetView (CpuDescriptorHandle renderTargetView, Vector4F* colorRGBA, uint numRects, Vector4I* pRects) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearRenderTargetView (ptr, renderTargetView, colorRGBA, numRects, pRects);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearUnorderedAccessViewUint<T0> (GpuDescriptorHandle viewGPUHandleInCurrentHeap, CpuDescriptorHandle viewCPUHandle, T0* pResource, Vector4U* values, uint numRects, Vector4I* pRects) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearUnorderedAccessViewUint (ptr, viewGPUHandleInCurrentHeap, viewCPUHandle, pResource, values, numRects, pRects);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearUnorderedAccessViewFloat<T0> (GpuDescriptorHandle viewGPUHandleInCurrentHeap, CpuDescriptorHandle viewCPUHandle, T0* pResource, Vector4F* values, uint numRects, Vector4I* pRects) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearUnorderedAccessViewFloat (ptr, viewGPUHandleInCurrentHeap, viewCPUHandle, pResource, values, numRects, pRects);
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
	public readonly void ExecuteIndirect<T0, T1, T2> (T0* pCommandSignature, uint maxCommandCount, T1* pArgumentBuffer, ulong argumentBufferOffset, T2* pCountBuffer, ulong countBufferOffset) where T0 : unmanaged, ICommandSignature where T1 : unmanaged, IResource where T2 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ExecuteIndirect (ptr, pCommandSignature, maxCommandCount, pArgumentBuffer, argumentBufferOffset, pCountBuffer, countBufferOffset);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> Reset;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ClearState;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, uint, void> DrawInstanced;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, void> Dispatch;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, void*, ulong, ulong, void> CopyBufferRegion;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void> CopyTextureRegion;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void> CopyResource;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TiledResourceCoordinate*, TileRegionSize*, void*, ulong, TileCopyFlags, void> CopyTiles;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, uint, DXGI.Format, void> ResolveSubresource;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PrimitiveTopologyType, void> IASetPrimitiveTopology;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Viewport*, void> RSSetViewports;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Vector4I*, void> RSSetScissorRects;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> OMSetBlendFactor;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> OMSetStencilRef;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetPipelineState;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ResourceBarrier*, void> ResourceBarrier;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ExecuteBundle;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, void> SetDescriptorHeaps;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetComputeRootSignature;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetGraphicsRootSignature;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, GpuDescriptorHandle, void> SetComputeRootDescriptorTable;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, GpuDescriptorHandle, void> SetGraphicsRootDescriptorTable;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, void> SetComputeRoot32BitConstant;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, void> SetGraphicsRoot32BitConstant;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint, void> SetComputeRoot32BitConstants;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint, void> SetGraphicsRoot32BitConstants;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ulong, void> SetComputeRootConstantBufferView;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ulong, void> SetGraphicsRootConstantBufferView;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ulong, void> SetComputeRootShaderResourceView;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ulong, void> SetGraphicsRootShaderResourceView;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ulong, void> SetComputeRootUnorderedAccessView;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ulong, void> SetGraphicsRootUnorderedAccessView;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IndexBufferView*, void> IASetIndexBuffer;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, VertexBufferView*, void> IASetVertexBuffers;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, StreamOutputBufferView*, void> SOSetTargets;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, CpuDescriptorHandle*, uint, CpuDescriptorHandle*, void> OMSetRenderTargets;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Vector4I*, void> ClearDepthStencilView;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CpuDescriptorHandle, Vector4F*, uint, Vector4I*, void> ClearRenderTargetView;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GpuDescriptorHandle, CpuDescriptorHandle, void*, Vector4U*, uint, Vector4I*, void> ClearUnorderedAccessViewUint;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GpuDescriptorHandle, CpuDescriptorHandle, void*, Vector4F*, uint, Vector4I*, void> ClearUnorderedAccessViewFloat;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DiscardRegion*, void> DiscardResource;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, QueryType, uint, void> BeginQuery;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, QueryType, uint, void> EndQuery;
		/// <summary>
		/// OFFSET 54
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, QueryType, uint, uint, void*, ulong, void> ResolveQueryData;
		/// <summary>
		/// OFFSET 55
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, PredicationOp, void> SetPredication;
		/// <summary>
		/// OFFSET 56
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, void> SetMarker;
		/// <summary>
		/// OFFSET 57
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, void> BeginEvent;
		/// <summary>
		/// OFFSET 58
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> EndEvent;
		/// <summary>
		/// OFFSET 59
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, ulong, void*, ulong, void> ExecuteIndirect;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
