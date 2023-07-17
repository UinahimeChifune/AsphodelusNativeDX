using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12GraphicsCommandList1</b> : ID3D12GraphicsCommandList<br/>
/// D3D12.h
/// </summary>
unsafe public interface IGraphicsCommandList1 : IGraphicsCommandList {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList1::AtomicCopyBufferUINT (ID3D12Resource* pDstBuffer, UINT64 DstOffset, ID3D12Resource* pSrcBuffer, UINT64 SrcOffset, UINT Dependencies, ID3D12Resource* ppDependentResources, D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)</b><br/>
	/// </summary>
	/// <param name="pDstBuffer">_In_ <b>ID3D12Resource* pDstBuffer</b></param>
	/// <param name="dstOffset"><b>UINT64 DstOffset</b></param>
	/// <param name="pSrcBuffer">_In_ <b>ID3D12Resource* pSrcBuffer</b></param>
	/// <param name="srcOffset"><b>UINT64 SrcOffset</b></param>
	/// <param name="dependencies"><b>UINT Dependencies</b></param>
	/// <param name="ppDependentResources">_In_reads_(Dependencies) <b>ID3D12Resource* ppDependentResources</b></param>
	/// <param name="pDependentSubresourceRanges">_In_reads_(Dependencies) <b>D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges</b></param>
	void AtomicCopyBufferUINT<T0, T1, T2> (T0* pDstBuffer, ulong dstOffset, T1* pSrcBuffer, ulong srcOffset, uint dependencies, T2* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where T0 : unmanaged, IResource where T1 : unmanaged, IResource where T2 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList1::AtomicCopyBufferUINT64 (ID3D12Resource* pDstBuffer, UINT64 DstOffset, ID3D12Resource* pSrcBuffer, UINT64 SrcOffset, UINT Dependencies, ID3D12Resource* ppDependentResources, D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)</b><br/>
	/// </summary>
	/// <param name="pDstBuffer">_In_ <b>ID3D12Resource* pDstBuffer</b></param>
	/// <param name="dstOffset"><b>UINT64 DstOffset</b></param>
	/// <param name="pSrcBuffer">_In_ <b>ID3D12Resource* pSrcBuffer</b></param>
	/// <param name="srcOffset"><b>UINT64 SrcOffset</b></param>
	/// <param name="dependencies"><b>UINT Dependencies</b></param>
	/// <param name="ppDependentResources">_In_reads_(Dependencies) <b>ID3D12Resource* ppDependentResources</b></param>
	/// <param name="pDependentSubresourceRanges">_In_reads_(Dependencies) <b>D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges</b></param>
	void AtomicCopyBufferUINT64<T0, T1, T2> (T0* pDstBuffer, ulong dstOffset, T1* pSrcBuffer, ulong srcOffset, uint dependencies, T2* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where T0 : unmanaged, IResource where T1 : unmanaged, IResource where T2 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList1::OMSetDepthBounds (FLOAT Min, FLOAT Max)</b><br/>
	/// </summary>
	/// <param name="min">_In_ <b>FLOAT Min</b></param>
	/// <param name="max">_In_ <b>FLOAT Max</b></param>
	void OMSetDepthBounds (float min, float max);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList1::SetSamplePositions (UINT NumSamplesPerPixel, UINT NumPixels, D3D12_SAMPLE_POSITION* pSamplePositions)</b><br/>
	/// </summary>
	/// <param name="numSamplesPerPixel">_In_ <b>UINT NumSamplesPerPixel</b></param>
	/// <param name="numPixels">_In_ <b>UINT NumPixels</b></param>
	/// <param name="pSamplePositions">_In_reads_(NumSamplesPerPixel*NumPixels) <b>D3D12_SAMPLE_POSITION* pSamplePositions</b></param>
	void SetSamplePositions (uint numSamplesPerPixel, uint numPixels, SamplePosition* pSamplePositions);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList1::ResolveSubresourceRegion (ID3D12Resource* pDstResource, UINT DstSubresource, UINT DstX, UINT DstY, ID3D12Resource* pSrcResource, UINT SrcSubresource, D3D12_RECT* pSrcRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D12Resource* pDstResource</b></param>
	/// <param name="dstSubresource">_In_ <b>UINT DstSubresource</b></param>
	/// <param name="dstX">_In_ <b>UINT DstX</b></param>
	/// <param name="dstY">_In_ <b>UINT DstY</b></param>
	/// <param name="pSrcResource">_In_ <b>ID3D12Resource* pSrcResource</b></param>
	/// <param name="srcSubresource">_In_ <b>UINT SrcSubresource</b></param>
	/// <param name="pSrcRect">_In_opt_ <b>D3D12_RECT* pSrcRect</b></param>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="resolveMode">_In_ <b>D3D12_RESOLVE_MODE ResolveMode</b></param>
	void ResolveSubresourceRegion<T0, T1> (T0* pDstResource, uint dstSubresource, uint dstX, uint dstY, T1* pSrcResource, uint srcSubresource, Vector4I* pSrcRect, DXGI.Format format, ResolveMode resolveMode) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12GraphicsCommandList1::SetViewInstanceMask (UINT Mask)</b><br/>
	/// </summary>
	/// <param name="mask">_In_ <b>UINT Mask</b></param>
	void SetViewInstanceMask (uint mask);
}

/// <summary>
/// Instance of <b>ID3D12GraphicsCommandList1</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct GraphicsCommandList1 : IGraphicsCommandList1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GraphicsCommandList1* GetCurrentPointer () => (GraphicsCommandList1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x553103fb, 0x1fe7, 0x4557, 0xbb, 0x38, 0x94, 0x6d, 0x7d, 0x0e, 0x7c, 0xa7);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AtomicCopyBufferUINT<T0, T1, T2> (T0* pDstBuffer, ulong dstOffset, T1* pSrcBuffer, ulong srcOffset, uint dependencies, T2* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where T0 : unmanaged, IResource where T1 : unmanaged, IResource where T2 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AtomicCopyBufferUINT (ptr, pDstBuffer, dstOffset, pSrcBuffer, srcOffset, dependencies, ppDependentResources, pDependentSubresourceRanges);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AtomicCopyBufferUINT64<T0, T1, T2> (T0* pDstBuffer, ulong dstOffset, T1* pSrcBuffer, ulong srcOffset, uint dependencies, T2* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where T0 : unmanaged, IResource where T1 : unmanaged, IResource where T2 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AtomicCopyBufferUINT64 (ptr, pDstBuffer, dstOffset, pSrcBuffer, srcOffset, dependencies, ppDependentResources, pDependentSubresourceRanges);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetDepthBounds (float min, float max) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetDepthBounds (ptr, min, max);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetSamplePositions (uint numSamplesPerPixel, uint numPixels, SamplePosition* pSamplePositions) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetSamplePositions (ptr, numSamplesPerPixel, numPixels, pSamplePositions);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ResolveSubresourceRegion<T0, T1> (T0* pDstResource, uint dstSubresource, uint dstX, uint dstY, T1* pSrcResource, uint srcSubresource, Vector4I* pSrcRect, DXGI.Format format, ResolveMode resolveMode) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ResolveSubresourceRegion (ptr, pDstResource, dstSubresource, dstX, dstY, pSrcResource, srcSubresource, pSrcRect, format, resolveMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetViewInstanceMask (uint mask) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetViewInstanceMask (ptr, mask);
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
		/// <summary>
		/// OFFSET 60
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, void*, ulong, uint, void*, SubresourceRangeUint64*, void> AtomicCopyBufferUINT;
		/// <summary>
		/// OFFSET 61
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, void*, ulong, uint, void*, SubresourceRangeUint64*, void> AtomicCopyBufferUINT64;
		/// <summary>
		/// OFFSET 62
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, void> OMSetDepthBounds;
		/// <summary>
		/// OFFSET 63
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, SamplePosition*, void> SetSamplePositions;
		/// <summary>
		/// OFFSET 64
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint, void*, uint, Vector4I*, DXGI.Format, ResolveMode, void> ResolveSubresourceRegion;
		/// <summary>
		/// OFFSET 65
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetViewInstanceMask;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
