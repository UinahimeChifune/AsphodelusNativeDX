using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11DeviceContext2</b> : ID3D11DeviceContext1<br/>
/// D3D11_2.h
/// </summary>
unsafe public interface IDeviceContext2 : IDeviceContext1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext2::UpdateTileMappings (ID3D11Resource* pTiledResource, UINT NumTiledResourceRegions, D3D11_TILED_RESOURCE_COORDINATE* pTiledResourceRegionStartCoordinates, D3D11_TILE_REGION_SIZE* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, UINT NumRanges, UINT* pRangeFlags, UINT* pTilePoolStartOffsets, UINT* pRangeTileCounts, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="pTiledResource">_In_ <b>ID3D11Resource* pTiledResource</b></param>
	/// <param name="numTiledResourceRegions">_In_ <b>UINT NumTiledResourceRegions</b></param>
	/// <param name="pTiledResourceRegionStartCoordinates">_In_reads_opt_(NumTiledResourceRegions) <b>D3D11_TILED_RESOURCE_COORDINATE* pTiledResourceRegionStartCoordinates</b></param>
	/// <param name="pTiledResourceRegionSizes">_In_reads_opt_(NumTiledResourceRegions) <b>D3D11_TILE_REGION_SIZE* pTiledResourceRegionSizes</b></param>
	/// <param name="pTilePool">_In_opt_ <b>ID3D11Buffer* pTilePool</b></param>
	/// <param name="numRanges">_In_ <b>UINT NumRanges</b></param>
	/// <param name="pRangeFlags">_In_reads_opt_(NumRanges) <b>UINT* pRangeFlags</b></param>
	/// <param name="pTilePoolStartOffsets">_In_reads_opt_(NumRanges) <b>UINT* pTilePoolStartOffsets</b></param>
	/// <param name="pRangeTileCounts">_In_reads_opt_(NumRanges) <b>UINT* pRangeTileCounts</b></param>
	/// <param name="flags">_In_ <b>UINT Flags</b></param>
	int UpdateTileMappings<T0, T1> (T0* pTiledResource, uint numTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, T1* pTilePool, uint numRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint flags) where T0 : unmanaged, IResource where T1 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext2::CopyTileMappings (ID3D11Resource* pDestTiledResource, D3D11_TILED_RESOURCE_COORDINATE* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, D3D11_TILED_RESOURCE_COORDINATE* pSourceRegionStartCoordinate, D3D11_TILE_REGION_SIZE* pTileRegionSize, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="pDestTiledResource">_In_ <b>ID3D11Resource* pDestTiledResource</b></param>
	/// <param name="pDestRegionStartCoordinate">_In_ <b>D3D11_TILED_RESOURCE_COORDINATE* pDestRegionStartCoordinate</b></param>
	/// <param name="pSourceTiledResource">_In_ <b>ID3D11Resource* pSourceTiledResource</b></param>
	/// <param name="pSourceRegionStartCoordinate">_In_ <b>D3D11_TILED_RESOURCE_COORDINATE* pSourceRegionStartCoordinate</b></param>
	/// <param name="pTileRegionSize">_In_ <b>D3D11_TILE_REGION_SIZE* pTileRegionSize</b></param>
	/// <param name="flags">_In_ <b>UINT Flags</b></param>
	int CopyTileMappings<T0, T1> (T0* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, T1* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint flags) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext2::CopyTiles (ID3D11Resource* pTiledResource, D3D11_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, D3D11_TILE_REGION_SIZE* pTileRegionSize, ID3D11Buffer* pBuffer, UINT64 BufferStartOffsetInBytes, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="pTiledResource">_In_ <b>ID3D11Resource* pTiledResource</b></param>
	/// <param name="pTileRegionStartCoordinate">_In_ <b>D3D11_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate</b></param>
	/// <param name="pTileRegionSize">_In_ <b>D3D11_TILE_REGION_SIZE* pTileRegionSize</b></param>
	/// <param name="pBuffer">_In_ <b>ID3D11Buffer* pBuffer</b></param>
	/// <param name="bufferStartOffsetInBytes">_In_ <b>UINT64 BufferStartOffsetInBytes</b></param>
	/// <param name="flags">_In_ <b>UINT Flags</b></param>
	void CopyTiles<T0, T1> (T0* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, T1* pBuffer, ulong bufferStartOffsetInBytes, uint flags) where T0 : unmanaged, IResource where T1 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext2::UpdateTiles (ID3D11Resource* pDestTiledResource, D3D11_TILED_RESOURCE_COORDINATE* pDestTileRegionStartCoordinate, D3D11_TILE_REGION_SIZE* pDestTileRegionSize, void* pSourceTileData, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="pDestTiledResource">_In_ <b>ID3D11Resource* pDestTiledResource</b></param>
	/// <param name="pDestTileRegionStartCoordinate">_In_ <b>D3D11_TILED_RESOURCE_COORDINATE* pDestTileRegionStartCoordinate</b></param>
	/// <param name="pDestTileRegionSize">_In_ <b>D3D11_TILE_REGION_SIZE* pDestTileRegionSize</b></param>
	/// <param name="pSourceTileData">_In_ <b>void* pSourceTileData</b></param>
	/// <param name="flags">_In_ <b>UINT Flags</b></param>
	void UpdateTiles<T0> (T0* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint flags) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext2::ResizeTilePool (ID3D11Buffer* pTilePool, UINT64 NewSizeInBytes)</b><br/>
	/// </summary>
	/// <param name="pTilePool">_In_ <b>ID3D11Buffer* pTilePool</b></param>
	/// <param name="newSizeInBytes">_In_ <b>UINT64 NewSizeInBytes</b></param>
	int ResizeTilePool<T0> (T0* pTilePool, ulong newSizeInBytes) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext2::TiledResourceBarrier (ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)</b><br/>
	/// </summary>
	/// <param name="pTiledResourceOrViewAccessBeforeBarrier">_In_opt_ <b>ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier</b></param>
	/// <param name="pTiledResourceOrViewAccessAfterBarrier">_In_opt_ <b>ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier</b></param>
	void TiledResourceBarrier<T0, T1> (T0* pTiledResourceOrViewAccessBeforeBarrier, T1* pTiledResourceOrViewAccessAfterBarrier) where T0 : unmanaged, IDeviceChild where T1 : unmanaged, IDeviceChild;
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D11DeviceContext2::IsAnnotationEnabled ()</b><br/>
	/// </summary>
	bool IsAnnotationEnabled ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext2::SetMarkerInt (LPCWSTR pLabel, INT Data)</b><br/>
	/// </summary>
	/// <param name="pLabel">_In_ <b>LPCWSTR pLabel</b></param>
	/// <param name="data"><b>INT Data</b></param>
	void SetMarkerInt (char* pLabel, int data);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext2::BeginEventInt (LPCWSTR pLabel, INT Data)</b><br/>
	/// </summary>
	/// <param name="pLabel">_In_ <b>LPCWSTR pLabel</b></param>
	/// <param name="data"><b>INT Data</b></param>
	void BeginEventInt (char* pLabel, int data);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext2::EndEvent ()</b><br/>
	/// </summary>
	void EndEvent ();
}

/// <summary>
/// Instance of <b>ID3D11DeviceContext2</b><br/>
/// D3D11_2.h
/// </summary>
unsafe public readonly struct DeviceContext2 : IDeviceContext2 {
//unsafe public readonly struct IDeviceContext2Obj : IDeviceContext2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DeviceContext2* GetCurrentPointer () => (DeviceContext2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDeviceContext2Obj* GetCurrentPointer () => (IDeviceContext2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x420d5b32, 0xb90c, 0x4da4, 0xbe, 0xf0, 0x35, 0x9f, 0x6a, 0x24, 0xa8, 0x3a);

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
	public readonly void GetDevice<T0> (T0** ppDevice) where T0 : unmanaged, IDevice {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) ppDevice);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDevice<T0> (out T0* ppDevice) where T0 : unmanaged, IDevice {
		fixed (T0** _ppDevice = &ppDevice) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) _ppDevice);
			return;
		}
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
	public readonly void VSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSSetConstantBuffers (ptr, startSlot, numBuffers, ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSSetShaderResources (ptr, startSlot, numViews, ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSSetShader<T0, T1> (T0* pPixelShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IPixelShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSSetShader (ptr, pPixelShader, ppClassInstances, numClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSSetSamplers (ptr, startSlot, numSamplers, ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSSetShader<T0, T1> (T0* pVertexShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IVertexShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSSetShader (ptr, pVertexShader, ppClassInstances, numClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawIndexed (uint indexCount, uint startIndexLocation, int baseVertexLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawIndexed (ptr, indexCount, startIndexLocation, baseVertexLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Draw (uint vertexCount, uint startVertexLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Draw (ptr, vertexCount, startVertexLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Map<T0> (T0* pResource, uint subresource, Map mapType, uint mapFlags, MappedSubresource* pMappedResource) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, pResource, subresource, mapType, mapFlags, pMappedResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Map<T0> (T0* pResource, uint subresource, Map mapType, uint mapFlags, out MappedSubresource pMappedResource) where T0 : unmanaged, IResource {
		fixed (MappedSubresource* _pMappedResource = &pMappedResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, pResource, subresource, mapType, mapFlags, _pMappedResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Unmap<T0> (T0* pResource, uint subresource) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Unmap (ptr, pResource, subresource);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSSetConstantBuffers (ptr, startSlot, numBuffers, ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IASetInputLayout<T0> (T0* pInputLayout) where T0 : unmanaged, IInputLayout {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IASetInputLayout (ptr, pInputLayout);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IASetVertexBuffers<T0> (uint startSlot, uint numBuffers, T0* ppVertexBuffers, uint* pStrides, uint* pOffsets) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IASetVertexBuffers (ptr, startSlot, numBuffers, ppVertexBuffers, pStrides, pOffsets);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IASetIndexBuffer<T0> (T0* pIndexBuffer, DXGI.Format format, uint offset) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IASetIndexBuffer (ptr, pIndexBuffer, format, offset);
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
	public readonly void DrawInstanced (uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawInstanced (ptr, vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSSetConstantBuffers (ptr, startSlot, numBuffers, ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSSetShader<T0, T1> (T0* pShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IGeometryShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSSetShader (ptr, pShader, ppClassInstances, numClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IASetPrimitiveTopology (Direct3D.PrimitiveTopology topology) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IASetPrimitiveTopology (ptr, topology);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSSetShaderResources (ptr, startSlot, numViews, ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSSetSamplers (ptr, startSlot, numSamplers, ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Begin<T0> (T0* pAsync) where T0 : unmanaged, IAsynchronous {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Begin (ptr, pAsync);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void End<T0> (T0* pAsync) where T0 : unmanaged, IAsynchronous {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->End (ptr, pAsync);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetData<T0> (T0* pAsync, void* pData, uint dataSize, uint getDataFlags) where T0 : unmanaged, IAsynchronous {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetData (ptr, pAsync, pData, dataSize, getDataFlags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetPredication<T0> (T0* pPredicate, bool predicateValue) where T0 : unmanaged, IPredicate {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetPredication (ptr, pPredicate, predicateValue ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSSetShaderResources (ptr, startSlot, numViews, ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSSetSamplers (ptr, startSlot, numSamplers, ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetRenderTargets<T0, T1> (uint numViews, T0* ppRenderTargetViews, T1* pDepthStencilView) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetRenderTargets (ptr, numViews, ppRenderTargetViews, pDepthStencilView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetRenderTargetsAndUnorderedAccessViews<T0, T1, T2> (uint numRTVs, T0* ppRenderTargetViews, T1* pDepthStencilView, uint uAVStartSlot, uint numUAVs, T2* ppUnorderedAccessViews, uint* pUAVInitialCounts) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView where T2 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetRenderTargetsAndUnorderedAccessViews (ptr, numRTVs, ppRenderTargetViews, pDepthStencilView, uAVStartSlot, numUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetBlendState<T0> (T0* pBlendState, Vector4F* blendFactor, uint sampleMask) where T0 : unmanaged, IBlendState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetBlendState (ptr, pBlendState, blendFactor, sampleMask);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMSetDepthStencilState<T0> (T0* pDepthStencilState, uint stencilRef) where T0 : unmanaged, IDepthStencilState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMSetDepthStencilState (ptr, pDepthStencilState, stencilRef);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SOSetTargets<T0> (uint numBuffers, T0* ppSOTargets, uint* pOffsets) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SOSetTargets (ptr, numBuffers, ppSOTargets, pOffsets);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawAuto () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawAuto (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawIndexedInstancedIndirect<T0> (T0* pBufferForArgs, uint alignedByteOffsetForArgs) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawIndexedInstancedIndirect (ptr, pBufferForArgs, alignedByteOffsetForArgs);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawInstancedIndirect<T0> (T0* pBufferForArgs, uint alignedByteOffsetForArgs) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawInstancedIndirect (ptr, pBufferForArgs, alignedByteOffsetForArgs);
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
	public readonly void DispatchIndirect<T0> (T0* pBufferForArgs, uint alignedByteOffsetForArgs) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DispatchIndirect (ptr, pBufferForArgs, alignedByteOffsetForArgs);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RSSetState<T0> (T0* pRasterizerState) where T0 : unmanaged, IRasterizerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->RSSetState (ptr, pRasterizerState);
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
	public readonly void CopySubresourceRegion<T0, T1> (T0* pDstResource, uint dstSubresource, uint dstX, uint dstY, uint dstZ, T1* pSrcResource, uint srcSubresource, Box* pSrcBox) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopySubresourceRegion (ptr, pDstResource, dstSubresource, dstX, dstY, dstZ, pSrcResource, srcSubresource, pSrcBox);
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
	public readonly void UpdateSubresource<T0> (T0* pDstResource, uint dstSubresource, Box* pDstBox, void* pSrcData, uint srcRowPitch, uint srcDepthPitch) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UpdateSubresource (ptr, pDstResource, dstSubresource, pDstBox, pSrcData, srcRowPitch, srcDepthPitch);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyStructureCount<T0, T1> (T0* pDstBuffer, uint dstAlignedByteOffset, T1* pSrcView) where T0 : unmanaged, IBuffer where T1 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyStructureCount (ptr, pDstBuffer, dstAlignedByteOffset, pSrcView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearRenderTargetView<T0> (T0* pRenderTargetView) where T0 : unmanaged, IRenderTargetView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearRenderTargetView (ptr, pRenderTargetView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearUnorderedAccessViewUint<T0> (T0* pUnorderedAccessView) where T0 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearUnorderedAccessViewUint (ptr, pUnorderedAccessView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearUnorderedAccessViewFloat<T0> (T0* pUnorderedAccessView) where T0 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearUnorderedAccessViewFloat (ptr, pUnorderedAccessView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearDepthStencilView<T0> (T0* pDepthStencilView, uint clearFlags, float depth, byte stencil) where T0 : unmanaged, IDepthStencilView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearDepthStencilView (ptr, pDepthStencilView, clearFlags, depth, stencil);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GenerateMips<T0> (T0* pShaderResourceView) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GenerateMips (ptr, pShaderResourceView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetResourceMinLOD<T0> (T0* pResource, float minLOD) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetResourceMinLOD (ptr, pResource, minLOD);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetResourceMinLOD<T0> (T0* pResource) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetResourceMinLOD (ptr, pResource);
		return hr;
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
	public readonly void ExecuteCommandList<T0> (T0* pCommandList, bool restoreContextState) where T0 : unmanaged, ICommandList {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ExecuteCommandList (ptr, pCommandList, restoreContextState ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSSetShaderResources (ptr, startSlot, numViews, ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSSetShader<T0, T1> (T0* pHullShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IHullShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSSetShader (ptr, pHullShader, ppClassInstances, numClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSSetSamplers (ptr, startSlot, numSamplers, ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSSetConstantBuffers (ptr, startSlot, numBuffers, ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSSetShaderResources (ptr, startSlot, numViews, ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSSetShader<T0, T1> (T0* pDomainShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IDomainShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSSetShader (ptr, pDomainShader, ppClassInstances, numClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSSetSamplers (ptr, startSlot, numSamplers, ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSSetConstantBuffers (ptr, startSlot, numBuffers, ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSSetShaderResources (ptr, startSlot, numViews, ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSSetUnorderedAccessViews<T0> (uint startSlot, uint numUAVs, T0* ppUnorderedAccessViews, uint* pUAVInitialCounts) where T0 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSSetUnorderedAccessViews (ptr, startSlot, numUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSSetShader<T0, T1> (T0* pComputeShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IComputeShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSSetShader (ptr, pComputeShader, ppClassInstances, numClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSSetSamplers (ptr, startSlot, numSamplers, ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSSetConstantBuffers (ptr, startSlot, numBuffers, ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSGetShaderResources (ptr, startSlot, numViews, (void**) ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		fixed (T0** _ppShaderResourceViews = &ppShaderResourceViews) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->PSGetShaderResources (ptr, startSlot, numViews, (void**) _ppShaderResourceViews);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetShader<T0, T1> (T0** ppPixelShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IPixelShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSGetShader (ptr, (void**) ppPixelShader, (void**) ppClassInstances, pNumClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetShader<T0, T1> (out T0* ppPixelShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IPixelShader where T1 : unmanaged, IClassInstance {
		fixed (T0** _ppPixelShader = &ppPixelShader) {
			fixed (T1** _ppClassInstances = &ppClassInstances) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->PSGetShader (ptr, (void**) _ppPixelShader, (void**) _ppClassInstances, pNumClassInstances);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSGetSamplers (ptr, startSlot, numSamplers, (void**) ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		fixed (T0** _ppSamplers = &ppSamplers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->PSGetSamplers (ptr, startSlot, numSamplers, (void**) _ppSamplers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetShader<T0, T1> (T0** ppVertexShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IVertexShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSGetShader (ptr, (void**) ppVertexShader, (void**) ppClassInstances, pNumClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetShader<T0, T1> (out T0* ppVertexShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IVertexShader where T1 : unmanaged, IClassInstance {
		fixed (T0** _ppVertexShader = &ppVertexShader) {
			fixed (T1** _ppClassInstances = &ppClassInstances) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->VSGetShader (ptr, (void**) _ppVertexShader, (void**) _ppClassInstances, pNumClassInstances);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->PSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetInputLayout<T0> (T0** ppInputLayout) where T0 : unmanaged, IInputLayout {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IAGetInputLayout (ptr, (void**) ppInputLayout);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetInputLayout<T0> (out T0* ppInputLayout) where T0 : unmanaged, IInputLayout {
		fixed (T0** _ppInputLayout = &ppInputLayout) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->IAGetInputLayout (ptr, (void**) _ppInputLayout);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetVertexBuffers<T0> (uint startSlot, uint numBuffers, T0** ppVertexBuffers, uint* pStrides, uint* pOffsets) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IAGetVertexBuffers (ptr, startSlot, numBuffers, (void**) ppVertexBuffers, pStrides, pOffsets);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetVertexBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppVertexBuffers, uint* pStrides, uint* pOffsets) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppVertexBuffers = &ppVertexBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->IAGetVertexBuffers (ptr, startSlot, numBuffers, (void**) _ppVertexBuffers, pStrides, pOffsets);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetIndexBuffer<T0> (T0** pIndexBuffer, DXGI.Format* format, uint* offset) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IAGetIndexBuffer (ptr, (void**) pIndexBuffer, format, offset);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetIndexBuffer<T0> (out T0* pIndexBuffer, out DXGI.Format format, out uint offset) where T0 : unmanaged, IBuffer {
		fixed (T0** _pIndexBuffer = &pIndexBuffer) {
			fixed (DXGI.Format* _format = &format) {
				fixed (uint* _offset = &offset) {
					var ptr = GetCurrentPointer ();
					((FunctionPointer*) ptr->_pointer)->IAGetIndexBuffer (ptr, (void**) _pIndexBuffer, _format, _offset);
					return;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetShader<T0, T1> (T0** ppGeometryShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IGeometryShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSGetShader (ptr, (void**) ppGeometryShader, (void**) ppClassInstances, pNumClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetShader<T0, T1> (out T0* ppGeometryShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IGeometryShader where T1 : unmanaged, IClassInstance {
		fixed (T0** _ppGeometryShader = &ppGeometryShader) {
			fixed (T1** _ppClassInstances = &ppClassInstances) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->GSGetShader (ptr, (void**) _ppGeometryShader, (void**) _ppClassInstances, pNumClassInstances);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetPrimitiveTopology (Direct3D.PrimitiveTopology* pTopology) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->IAGetPrimitiveTopology (ptr, pTopology);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void IAGetPrimitiveTopology (out Direct3D.PrimitiveTopology pTopology) {
		fixed (Direct3D.PrimitiveTopology* _pTopology = &pTopology) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->IAGetPrimitiveTopology (ptr, _pTopology);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSGetShaderResources (ptr, startSlot, numViews, (void**) ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		fixed (T0** _ppShaderResourceViews = &ppShaderResourceViews) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VSGetShaderResources (ptr, startSlot, numViews, (void**) _ppShaderResourceViews);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSGetSamplers (ptr, startSlot, numSamplers, (void**) ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		fixed (T0** _ppSamplers = &ppSamplers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VSGetSamplers (ptr, startSlot, numSamplers, (void**) _ppSamplers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetPredication<T0> (T0** ppPredicate, uint* pPredicateValue) where T0 : unmanaged, IPredicate {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetPredication (ptr, (void**) ppPredicate, pPredicateValue);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetPredication<T0> (out T0* ppPredicate, out bool pPredicateValue) where T0 : unmanaged, IPredicate {
		fixed (T0** _ppPredicate = &ppPredicate) {
			uint _pPredicateValue;
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetPredication (ptr, (void**) _ppPredicate, &_pPredicateValue);
			pPredicateValue = _pPredicateValue != 0;
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSGetShaderResources (ptr, startSlot, numViews, (void**) ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		fixed (T0** _ppShaderResourceViews = &ppShaderResourceViews) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GSGetShaderResources (ptr, startSlot, numViews, (void**) _ppShaderResourceViews);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSGetSamplers (ptr, startSlot, numSamplers, (void**) ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		fixed (T0** _ppSamplers = &ppSamplers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GSGetSamplers (ptr, startSlot, numSamplers, (void**) _ppSamplers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetRenderTargets<T0, T1> (uint numViews, T0** ppRenderTargetViews, T1** ppDepthStencilView) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMGetRenderTargets (ptr, numViews, (void**) ppRenderTargetViews, (void**) ppDepthStencilView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetRenderTargets<T0, T1> (uint numViews, out T0* ppRenderTargetViews, out T1* ppDepthStencilView) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView {
		fixed (T0** _ppRenderTargetViews = &ppRenderTargetViews) {
			fixed (T1** _ppDepthStencilView = &ppDepthStencilView) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->OMGetRenderTargets (ptr, numViews, (void**) _ppRenderTargetViews, (void**) _ppDepthStencilView);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetRenderTargetsAndUnorderedAccessViews<T0, T1, T2> (uint numRTVs, T0** ppRenderTargetViews, T1** ppDepthStencilView, uint uAVStartSlot, uint numUAVs, T2** ppUnorderedAccessViews) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView where T2 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMGetRenderTargetsAndUnorderedAccessViews (ptr, numRTVs, (void**) ppRenderTargetViews, (void**) ppDepthStencilView, uAVStartSlot, numUAVs, (void**) ppUnorderedAccessViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetRenderTargetsAndUnorderedAccessViews<T0, T1, T2> (uint numRTVs, out T0* ppRenderTargetViews, out T1* ppDepthStencilView, uint uAVStartSlot, uint numUAVs, out T2* ppUnorderedAccessViews) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView where T2 : unmanaged, IUnorderedAccessView {
		fixed (T0** _ppRenderTargetViews = &ppRenderTargetViews) {
			fixed (T1** _ppDepthStencilView = &ppDepthStencilView) {
				fixed (T2** _ppUnorderedAccessViews = &ppUnorderedAccessViews) {
					var ptr = GetCurrentPointer ();
					((FunctionPointer*) ptr->_pointer)->OMGetRenderTargetsAndUnorderedAccessViews (ptr, numRTVs, (void**) _ppRenderTargetViews, (void**) _ppDepthStencilView, uAVStartSlot, numUAVs, (void**) _ppUnorderedAccessViews);
					return;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetBlendState<T0> (T0** ppBlendState, Vector4F* blendFactor, uint* pSampleMask) where T0 : unmanaged, IBlendState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMGetBlendState (ptr, (void**) ppBlendState, blendFactor, pSampleMask);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetBlendState<T0> (out T0* ppBlendState, out Vector4F blendFactor, out uint pSampleMask) where T0 : unmanaged, IBlendState {
		fixed (T0** _ppBlendState = &ppBlendState) {
			fixed (Vector4F* _blendFactor = &blendFactor) {
				fixed (uint* _pSampleMask = &pSampleMask) {
					var ptr = GetCurrentPointer ();
					((FunctionPointer*) ptr->_pointer)->OMGetBlendState (ptr, (void**) _ppBlendState, _blendFactor, _pSampleMask);
					return;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetDepthStencilState<T0> (T0** ppDepthStencilState, uint* pStencilRef) where T0 : unmanaged, IDepthStencilState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->OMGetDepthStencilState (ptr, (void**) ppDepthStencilState, pStencilRef);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void OMGetDepthStencilState<T0> (out T0* ppDepthStencilState, out uint pStencilRef) where T0 : unmanaged, IDepthStencilState {
		fixed (T0** _ppDepthStencilState = &ppDepthStencilState) {
			fixed (uint* _pStencilRef = &pStencilRef) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->OMGetDepthStencilState (ptr, (void**) _ppDepthStencilState, _pStencilRef);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SOGetTargets<T0> (uint numBuffers, T0** ppSOTargets) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SOGetTargets (ptr, numBuffers, (void**) ppSOTargets);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SOGetTargets<T0> (uint numBuffers, out T0* ppSOTargets) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppSOTargets = &ppSOTargets) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->SOGetTargets (ptr, numBuffers, (void**) _ppSOTargets);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RSGetState<T0> (T0** ppRasterizerState) where T0 : unmanaged, IRasterizerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->RSGetState (ptr, (void**) ppRasterizerState);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RSGetState<T0> (out T0* ppRasterizerState) where T0 : unmanaged, IRasterizerState {
		fixed (T0** _ppRasterizerState = &ppRasterizerState) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->RSGetState (ptr, (void**) _ppRasterizerState);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RSGetViewports (uint* pNumViewports, Viewport* pViewports) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->RSGetViewports (ptr, pNumViewports, pViewports);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RSGetScissorRects (uint* pNumRects, Vector4I* pRects) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->RSGetScissorRects (ptr, pNumRects, pRects);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSGetShaderResources (ptr, startSlot, numViews, (void**) ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		fixed (T0** _ppShaderResourceViews = &ppShaderResourceViews) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->HSGetShaderResources (ptr, startSlot, numViews, (void**) _ppShaderResourceViews);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetShader<T0, T1> (T0** ppHullShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IHullShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSGetShader (ptr, (void**) ppHullShader, (void**) ppClassInstances, pNumClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetShader<T0, T1> (out T0* ppHullShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IHullShader where T1 : unmanaged, IClassInstance {
		fixed (T0** _ppHullShader = &ppHullShader) {
			fixed (T1** _ppClassInstances = &ppClassInstances) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->HSGetShader (ptr, (void**) _ppHullShader, (void**) _ppClassInstances, pNumClassInstances);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSGetSamplers (ptr, startSlot, numSamplers, (void**) ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		fixed (T0** _ppSamplers = &ppSamplers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->HSGetSamplers (ptr, startSlot, numSamplers, (void**) _ppSamplers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->HSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSGetShaderResources (ptr, startSlot, numViews, (void**) ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		fixed (T0** _ppShaderResourceViews = &ppShaderResourceViews) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->DSGetShaderResources (ptr, startSlot, numViews, (void**) _ppShaderResourceViews);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetShader<T0, T1> (T0** ppDomainShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IDomainShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSGetShader (ptr, (void**) ppDomainShader, (void**) ppClassInstances, pNumClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetShader<T0, T1> (out T0* ppDomainShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IDomainShader where T1 : unmanaged, IClassInstance {
		fixed (T0** _ppDomainShader = &ppDomainShader) {
			fixed (T1** _ppClassInstances = &ppClassInstances) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->DSGetShader (ptr, (void**) _ppDomainShader, (void**) _ppClassInstances, pNumClassInstances);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSGetSamplers (ptr, startSlot, numSamplers, (void**) ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		fixed (T0** _ppSamplers = &ppSamplers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->DSGetSamplers (ptr, startSlot, numSamplers, (void**) _ppSamplers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->DSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSGetShaderResources (ptr, startSlot, numViews, (void**) ppShaderResourceViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView {
		fixed (T0** _ppShaderResourceViews = &ppShaderResourceViews) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->CSGetShaderResources (ptr, startSlot, numViews, (void**) _ppShaderResourceViews);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetUnorderedAccessViews<T0> (uint startSlot, uint numUAVs, T0** ppUnorderedAccessViews) where T0 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSGetUnorderedAccessViews (ptr, startSlot, numUAVs, (void**) ppUnorderedAccessViews);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetUnorderedAccessViews<T0> (uint startSlot, uint numUAVs, out T0* ppUnorderedAccessViews) where T0 : unmanaged, IUnorderedAccessView {
		fixed (T0** _ppUnorderedAccessViews = &ppUnorderedAccessViews) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->CSGetUnorderedAccessViews (ptr, startSlot, numUAVs, (void**) _ppUnorderedAccessViews);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetShader<T0, T1> (T0** ppComputeShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IComputeShader where T1 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSGetShader (ptr, (void**) ppComputeShader, (void**) ppClassInstances, pNumClassInstances);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetShader<T0, T1> (out T0* ppComputeShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IComputeShader where T1 : unmanaged, IClassInstance {
		fixed (T0** _ppComputeShader = &ppComputeShader) {
			fixed (T1** _ppClassInstances = &ppClassInstances) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->CSGetShader (ptr, (void**) _ppComputeShader, (void**) _ppClassInstances, pNumClassInstances);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSGetSamplers (ptr, startSlot, numSamplers, (void**) ppSamplers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState {
		fixed (T0** _ppSamplers = &ppSamplers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->CSGetSamplers (ptr, startSlot, numSamplers, (void**) _ppSamplers);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) ppConstantBuffers);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->CSGetConstantBuffers (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers);
			return;
		}
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
	public readonly void Flush () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Flush (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly DeviceContextType GetDeviceContextType () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetContextFlags () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetContextFlags (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FinishCommandList<T0> (bool restoreDeferredContextState, T0** ppCommandList) where T0 : unmanaged, ICommandList {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FinishCommandList (ptr, restoreDeferredContextState ? 1U : 0U, (void**) ppCommandList);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FinishCommandList<T0> (bool restoreDeferredContextState, out T0* ppCommandList) where T0 : unmanaged, ICommandList {
		fixed (T0** _ppCommandList = &ppCommandList) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FinishCommandList (ptr, restoreDeferredContextState ? 1U : 0U, (void**) _ppCommandList);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopySubresourceRegion1<T0, T1> (T0* pDstResource, uint dstSubresource, uint dstX, uint dstY, uint dstZ, T1* pSrcResource, uint srcSubresource, Box* pSrcBox, uint copyFlags) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopySubresourceRegion1 (ptr, pDstResource, dstSubresource, dstX, dstY, dstZ, pSrcResource, srcSubresource, pSrcBox, copyFlags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void UpdateSubresource1<T0> (T0* pDstResource, uint dstSubresource, Box* pDstBox, void* pSrcData, uint srcRowPitch, uint srcDepthPitch, uint copyFlags) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UpdateSubresource1 (ptr, pDstResource, dstSubresource, pDstBox, pSrcData, srcRowPitch, srcDepthPitch, copyFlags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DiscardResource<T0> (T0* pResource) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DiscardResource (ptr, pResource);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DiscardView<T0> (T0* pResourceView) where T0 : unmanaged, IView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DiscardView (ptr, pResourceView);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSSetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSSetConstantBuffers1 (ptr, startSlot, numBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSSetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSSetConstantBuffers1 (ptr, startSlot, numBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSSetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSSetConstantBuffers1 (ptr, startSlot, numBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSSetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSSetConstantBuffers1 (ptr, startSlot, numBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSSetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSSetConstantBuffers1 (ptr, startSlot, numBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSSetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSSetConstantBuffers1 (ptr, startSlot, numBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->VSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void VSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->VSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers, pFirstConstant, pNumConstants);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->HSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void HSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->HSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers, pFirstConstant, pNumConstants);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->DSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers, pFirstConstant, pNumConstants);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers, pFirstConstant, pNumConstants);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->PSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers, pFirstConstant, pNumConstants);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) ppConstantBuffers, pFirstConstant, pNumConstants);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CSGetConstantBuffers1<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppConstantBuffers = &ppConstantBuffers) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->CSGetConstantBuffers1 (ptr, startSlot, numBuffers, (void**) _ppConstantBuffers, pFirstConstant, pNumConstants);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SwapDeviceContextState<T0, T1> (T0* pState, T1** ppPreviousState) where T0 : unmanaged, Direct3D.IDeviceContextState where T1 : unmanaged, Direct3D.IDeviceContextState {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SwapDeviceContextState (ptr, pState, (void**) ppPreviousState);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SwapDeviceContextState<T0, T1> (T0* pState, out T1* ppPreviousState) where T0 : unmanaged, Direct3D.IDeviceContextState where T1 : unmanaged, Direct3D.IDeviceContextState {
		fixed (T1** _ppPreviousState = &ppPreviousState) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->SwapDeviceContextState (ptr, pState, (void**) _ppPreviousState);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearView<T0> (T0* pView, Vector4F* color, Vector4I* pRect, uint numRects) where T0 : unmanaged, IView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearView (ptr, pView, color, pRect, numRects);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DiscardView1<T0> (T0* pResourceView, Vector4I* pRects, uint numRects) where T0 : unmanaged, IView {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DiscardView1 (ptr, pResourceView, pRects, numRects);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UpdateTileMappings<T0, T1> (T0* pTiledResource, uint numTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, T1* pTilePool, uint numRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint flags) where T0 : unmanaged, IResource where T1 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UpdateTileMappings (ptr, pTiledResource, numTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, numRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, flags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyTileMappings<T0, T1> (T0* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, T1* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint flags) where T0 : unmanaged, IResource where T1 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyTileMappings (ptr, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, flags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CopyTiles<T0, T1> (T0* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, T1* pBuffer, ulong bufferStartOffsetInBytes, uint flags) where T0 : unmanaged, IResource where T1 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CopyTiles (ptr, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, bufferStartOffsetInBytes, flags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void UpdateTiles<T0> (T0* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint flags) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UpdateTiles (ptr, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, flags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ResizeTilePool<T0> (T0* pTilePool, ulong newSizeInBytes) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ResizeTilePool (ptr, pTilePool, newSizeInBytes);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void TiledResourceBarrier<T0, T1> (T0* pTiledResourceOrViewAccessBeforeBarrier, T1* pTiledResourceOrViewAccessAfterBarrier) where T0 : unmanaged, IDeviceChild where T1 : unmanaged, IDeviceChild {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->TiledResourceBarrier (ptr, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsAnnotationEnabled () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsAnnotationEnabled (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetMarkerInt (char* pLabel, int data) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetMarkerInt (ptr, pLabel, data);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void BeginEventInt (char* pLabel, int data) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->BeginEventInt (ptr, pLabel, data);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void EndEvent () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EndEvent (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetDevice;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> VSSetConstantBuffers;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> PSSetShaderResources;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void> PSSetShader;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> PSSetSamplers;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void> VSSetShader;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, int, void> DrawIndexed;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void> Draw;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Map, uint, MappedSubresource*, int> Map;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> Unmap;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> PSSetConstantBuffers;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> IASetInputLayout;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, uint*, void> IASetVertexBuffers;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DXGI.Format, uint, void> IASetIndexBuffer;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, uint, void> DrawInstanced;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> GSSetConstantBuffers;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void> GSSetShader;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Direct3D.PrimitiveTopology, void> IASetPrimitiveTopology;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> VSSetShaderResources;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> VSSetSamplers;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> Begin;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> End;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, uint, int> GetData;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> SetPredication;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> GSSetShaderResources;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> GSSetSamplers;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, void*, void> OMSetRenderTargets;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, void*, uint, uint, void*, uint*, void> OMSetRenderTargetsAndUnorderedAccessViews;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, uint, void> OMSetBlendState;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> OMSetDepthStencilState;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint*, void> SOSetTargets;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> DrawAuto;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> DrawIndexedInstancedIndirect;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> DrawInstancedIndirect;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, void> Dispatch;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> DispatchIndirect;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> RSSetState;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Viewport*, void> RSSetViewports;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Vector4I*, void> RSSetScissorRects;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint, uint, void*, uint, Box*, void> CopySubresourceRegion;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void> CopyResource;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Box*, void*, uint, uint, void> UpdateSubresource;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, void> CopyStructureCount;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ClearRenderTargetView;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ClearUnorderedAccessViewUint;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ClearUnorderedAccessViewFloat;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, float, byte, void> ClearDepthStencilView;
		/// <summary>
		/// OFFSET 54
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> GenerateMips;
		/// <summary>
		/// OFFSET 55
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, void> SetResourceMinLOD;
		/// <summary>
		/// OFFSET 56
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float> GetResourceMinLOD;
		/// <summary>
		/// OFFSET 57
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, uint, DXGI.Format, void> ResolveSubresource;
		/// <summary>
		/// OFFSET 58
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> ExecuteCommandList;
		/// <summary>
		/// OFFSET 59
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> HSSetShaderResources;
		/// <summary>
		/// OFFSET 60
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void> HSSetShader;
		/// <summary>
		/// OFFSET 61
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> HSSetSamplers;
		/// <summary>
		/// OFFSET 62
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> HSSetConstantBuffers;
		/// <summary>
		/// OFFSET 63
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> DSSetShaderResources;
		/// <summary>
		/// OFFSET 64
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void> DSSetShader;
		/// <summary>
		/// OFFSET 65
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> DSSetSamplers;
		/// <summary>
		/// OFFSET 66
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> DSSetConstantBuffers;
		/// <summary>
		/// OFFSET 67
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> CSSetShaderResources;
		/// <summary>
		/// OFFSET 68
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, void> CSSetUnorderedAccessViews;
		/// <summary>
		/// OFFSET 69
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void> CSSetShader;
		/// <summary>
		/// OFFSET 70
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> CSSetSamplers;
		/// <summary>
		/// OFFSET 71
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, void> CSSetConstantBuffers;
		/// <summary>
		/// OFFSET 72
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> VSGetConstantBuffers;
		/// <summary>
		/// OFFSET 73
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> PSGetShaderResources;
		/// <summary>
		/// OFFSET 74
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void**, uint*, void> PSGetShader;
		/// <summary>
		/// OFFSET 75
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> PSGetSamplers;
		/// <summary>
		/// OFFSET 76
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void**, uint*, void> VSGetShader;
		/// <summary>
		/// OFFSET 77
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> PSGetConstantBuffers;
		/// <summary>
		/// OFFSET 78
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> IAGetInputLayout;
		/// <summary>
		/// OFFSET 79
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, uint*, uint*, void> IAGetVertexBuffers;
		/// <summary>
		/// OFFSET 80
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, DXGI.Format*, uint*, void> IAGetIndexBuffer;
		/// <summary>
		/// OFFSET 81
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> GSGetConstantBuffers;
		/// <summary>
		/// OFFSET 82
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void**, uint*, void> GSGetShader;
		/// <summary>
		/// OFFSET 83
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Direct3D.PrimitiveTopology*, void> IAGetPrimitiveTopology;
		/// <summary>
		/// OFFSET 84
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> VSGetShaderResources;
		/// <summary>
		/// OFFSET 85
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> VSGetSamplers;
		/// <summary>
		/// OFFSET 86
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint*, void> GetPredication;
		/// <summary>
		/// OFFSET 87
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> GSGetShaderResources;
		/// <summary>
		/// OFFSET 88
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> GSGetSamplers;
		/// <summary>
		/// OFFSET 89
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, void**, void> OMGetRenderTargets;
		/// <summary>
		/// OFFSET 90
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, void**, uint, uint, void**, void> OMGetRenderTargetsAndUnorderedAccessViews;
		/// <summary>
		/// OFFSET 91
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, Vector4F*, uint*, void> OMGetBlendState;
		/// <summary>
		/// OFFSET 92
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint*, void> OMGetDepthStencilState;
		/// <summary>
		/// OFFSET 93
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, void> SOGetTargets;
		/// <summary>
		/// OFFSET 94
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> RSGetState;
		/// <summary>
		/// OFFSET 95
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, Viewport*, void> RSGetViewports;
		/// <summary>
		/// OFFSET 96
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, Vector4I*, void> RSGetScissorRects;
		/// <summary>
		/// OFFSET 97
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> HSGetShaderResources;
		/// <summary>
		/// OFFSET 98
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void**, uint*, void> HSGetShader;
		/// <summary>
		/// OFFSET 99
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> HSGetSamplers;
		/// <summary>
		/// OFFSET 100
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> HSGetConstantBuffers;
		/// <summary>
		/// OFFSET 101
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> DSGetShaderResources;
		/// <summary>
		/// OFFSET 102
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void**, uint*, void> DSGetShader;
		/// <summary>
		/// OFFSET 103
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> DSGetSamplers;
		/// <summary>
		/// OFFSET 104
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> DSGetConstantBuffers;
		/// <summary>
		/// OFFSET 105
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> CSGetShaderResources;
		/// <summary>
		/// OFFSET 106
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> CSGetUnorderedAccessViews;
		/// <summary>
		/// OFFSET 107
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void**, uint*, void> CSGetShader;
		/// <summary>
		/// OFFSET 108
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> CSGetSamplers;
		/// <summary>
		/// OFFSET 109
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, void> CSGetConstantBuffers;
		/// <summary>
		/// OFFSET 110
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> ClearState;
		/// <summary>
		/// OFFSET 111
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> Flush;
		/// <summary>
		/// OFFSET 112
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DeviceContextType> _GetType;
		/// <summary>
		/// OFFSET 113
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetContextFlags;
		/// <summary>
		/// OFFSET 114
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> FinishCommandList;
		/// <summary>
		/// OFFSET 115
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint, uint, void*, uint, Box*, uint, void> CopySubresourceRegion1;
		/// <summary>
		/// OFFSET 116
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Box*, void*, uint, uint, uint, void> UpdateSubresource1;
		/// <summary>
		/// OFFSET 117
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> DiscardResource;
		/// <summary>
		/// OFFSET 118
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> DiscardView;
		/// <summary>
		/// OFFSET 119
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, uint*, void> VSSetConstantBuffers1;
		/// <summary>
		/// OFFSET 120
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, uint*, void> HSSetConstantBuffers1;
		/// <summary>
		/// OFFSET 121
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, uint*, void> DSSetConstantBuffers1;
		/// <summary>
		/// OFFSET 122
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, uint*, void> GSSetConstantBuffers1;
		/// <summary>
		/// OFFSET 123
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, uint*, void> PSSetConstantBuffers1;
		/// <summary>
		/// OFFSET 124
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, uint*, uint*, void> CSSetConstantBuffers1;
		/// <summary>
		/// OFFSET 125
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, uint*, uint*, void> VSGetConstantBuffers1;
		/// <summary>
		/// OFFSET 126
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, uint*, uint*, void> HSGetConstantBuffers1;
		/// <summary>
		/// OFFSET 127
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, uint*, uint*, void> DSGetConstantBuffers1;
		/// <summary>
		/// OFFSET 128
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, uint*, uint*, void> GSGetConstantBuffers1;
		/// <summary>
		/// OFFSET 129
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, uint*, uint*, void> PSGetConstantBuffers1;
		/// <summary>
		/// OFFSET 130
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void**, uint*, uint*, void> CSGetConstantBuffers1;
		/// <summary>
		/// OFFSET 131
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, void> SwapDeviceContextState;
		/// <summary>
		/// OFFSET 132
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, Vector4I*, uint, void> ClearView;
		/// <summary>
		/// OFFSET 133
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4I*, uint, void> DiscardView1;
		/// <summary>
		/// OFFSET 134
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, TiledResourceCoordinate*, TileRegionSize*, void*, uint, uint*, uint*, uint*, uint, int> UpdateTileMappings;
		/// <summary>
		/// OFFSET 135
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TiledResourceCoordinate*, void*, TiledResourceCoordinate*, TileRegionSize*, uint, int> CopyTileMappings;
		/// <summary>
		/// OFFSET 136
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TiledResourceCoordinate*, TileRegionSize*, void*, ulong, uint, void> CopyTiles;
		/// <summary>
		/// OFFSET 137
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void> UpdateTiles;
		/// <summary>
		/// OFFSET 138
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, int> ResizeTilePool;
		/// <summary>
		/// OFFSET 139
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void> TiledResourceBarrier;
		/// <summary>
		/// OFFSET 140
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsAnnotationEnabled;
		/// <summary>
		/// OFFSET 141
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int, void> SetMarkerInt;
		/// <summary>
		/// OFFSET 142
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int, void> BeginEventInt;
		/// <summary>
		/// OFFSET 143
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> EndEvent;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
