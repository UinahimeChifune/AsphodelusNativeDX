using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11DeviceContext</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface IDeviceContext : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSSetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer* ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppConstantBuffers</b></param>
	void VSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSSetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView* ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_In_reads_opt_(NumViews) <b>ID3D11ShaderResourceView* ppShaderResourceViews</b></param>
	void PSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSSetShader (ID3D11PixelShader* pPixelShader, ID3D11ClassInstance* ppClassInstances, UINT NumClassInstances)</b><br/>
	/// </summary>
	/// <param name="pPixelShader">_In_opt_ <b>ID3D11PixelShader* pPixelShader</b></param>
	/// <param name="ppClassInstances">_In_reads_opt_(NumClassInstances) <b>ID3D11ClassInstance* ppClassInstances</b></param>
	/// <param name="numClassInstances"><b>UINT NumClassInstances</b></param>
	void PSSetShader<T0, T1> (T0* pPixelShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IPixelShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSSetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState* ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_In_reads_opt_(NumSamplers) <b>ID3D11SamplerState* ppSamplers</b></param>
	void PSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSSetShader (ID3D11VertexShader* pVertexShader, ID3D11ClassInstance* ppClassInstances, UINT NumClassInstances)</b><br/>
	/// </summary>
	/// <param name="pVertexShader">_In_opt_ <b>ID3D11VertexShader* pVertexShader</b></param>
	/// <param name="ppClassInstances">_In_reads_opt_(NumClassInstances) <b>ID3D11ClassInstance* ppClassInstances</b></param>
	/// <param name="numClassInstances"><b>UINT NumClassInstances</b></param>
	void VSSetShader<T0, T1> (T0* pVertexShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IVertexShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DrawIndexed (UINT IndexCount, UINT StartIndexLocation, INT BaseVertexLocation)</b><br/>
	/// </summary>
	/// <param name="indexCount">_In_ <b>UINT IndexCount</b></param>
	/// <param name="startIndexLocation">_In_ <b>UINT StartIndexLocation</b></param>
	/// <param name="baseVertexLocation">_In_ <b>INT BaseVertexLocation</b></param>
	void DrawIndexed (uint indexCount, uint startIndexLocation, int baseVertexLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::Draw (UINT VertexCount, UINT StartVertexLocation)</b><br/>
	/// </summary>
	/// <param name="vertexCount">_In_ <b>UINT VertexCount</b></param>
	/// <param name="startVertexLocation">_In_ <b>UINT StartVertexLocation</b></param>
	void Draw (uint vertexCount, uint startVertexLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext::Map (ID3D11Resource* pResource, UINT Subresource, D3D11_MAP MapType, UINT MapFlags, D3D11_MAPPED_SUBRESOURCE* pMappedResource)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="subresource">_In_ <b>UINT Subresource</b></param>
	/// <param name="mapType">_In_ <b>D3D11_MAP MapType</b></param>
	/// <param name="mapFlags">_In_ <b>UINT MapFlags</b></param>
	/// <param name="pMappedResource">_Out_opt_ <b>D3D11_MAPPED_SUBRESOURCE* pMappedResource</b></param>
	int Map<T0> (T0* pResource, uint subresource, Map mapType, uint mapFlags, MappedSubresource* pMappedResource) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext::Map (ID3D11Resource* pResource, UINT Subresource, D3D11_MAP MapType, UINT MapFlags, D3D11_MAPPED_SUBRESOURCE* pMappedResource)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="subresource">_In_ <b>UINT Subresource</b></param>
	/// <param name="mapType">_In_ <b>D3D11_MAP MapType</b></param>
	/// <param name="mapFlags">_In_ <b>UINT MapFlags</b></param>
	/// <param name="pMappedResource">_Out_opt_ <b>D3D11_MAPPED_SUBRESOURCE* pMappedResource</b></param>
	int Map<T0> (T0* pResource, uint subresource, Map mapType, uint mapFlags, out MappedSubresource pMappedResource) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::Unmap (ID3D11Resource* pResource, UINT Subresource)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="subresource">_In_ <b>UINT Subresource</b></param>
	void Unmap<T0> (T0* pResource, uint subresource) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSSetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer* ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppConstantBuffers</b></param>
	void PSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IASetInputLayout (ID3D11InputLayout* pInputLayout)</b><br/>
	/// </summary>
	/// <param name="pInputLayout">_In_opt_ <b>ID3D11InputLayout* pInputLayout</b></param>
	void IASetInputLayout<T0> (T0* pInputLayout) where T0 : unmanaged, IInputLayout;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IASetVertexBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer* ppVertexBuffers, UINT* pStrides, UINT* pOffsets)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppVertexBuffers">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppVertexBuffers</b></param>
	/// <param name="pStrides">_In_reads_opt_(NumBuffers) <b>UINT* pStrides</b></param>
	/// <param name="pOffsets">_In_reads_opt_(NumBuffers) <b>UINT* pOffsets</b></param>
	void IASetVertexBuffers<T0> (uint startSlot, uint numBuffers, T0* ppVertexBuffers, uint* pStrides, uint* pOffsets) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IASetIndexBuffer (ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, UINT Offset)</b><br/>
	/// </summary>
	/// <param name="pIndexBuffer">_In_opt_ <b>ID3D11Buffer* pIndexBuffer</b></param>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="offset">_In_ <b>UINT Offset</b></param>
	void IASetIndexBuffer<T0> (T0* pIndexBuffer, DXGI.Format format, uint offset) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DrawIndexedInstanced (UINT IndexCountPerInstance, UINT InstanceCount, UINT StartIndexLocation, INT BaseVertexLocation, UINT StartInstanceLocation)</b><br/>
	/// </summary>
	/// <param name="indexCountPerInstance">_In_ <b>UINT IndexCountPerInstance</b></param>
	/// <param name="instanceCount">_In_ <b>UINT InstanceCount</b></param>
	/// <param name="startIndexLocation">_In_ <b>UINT StartIndexLocation</b></param>
	/// <param name="baseVertexLocation">_In_ <b>INT BaseVertexLocation</b></param>
	/// <param name="startInstanceLocation">_In_ <b>UINT StartInstanceLocation</b></param>
	void DrawIndexedInstanced (uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexLocation, uint startInstanceLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DrawInstanced (UINT VertexCountPerInstance, UINT InstanceCount, UINT StartVertexLocation, UINT StartInstanceLocation)</b><br/>
	/// </summary>
	/// <param name="vertexCountPerInstance">_In_ <b>UINT VertexCountPerInstance</b></param>
	/// <param name="instanceCount">_In_ <b>UINT InstanceCount</b></param>
	/// <param name="startVertexLocation">_In_ <b>UINT StartVertexLocation</b></param>
	/// <param name="startInstanceLocation">_In_ <b>UINT StartInstanceLocation</b></param>
	void DrawInstanced (uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSSetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer* ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppConstantBuffers</b></param>
	void GSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSSetShader (ID3D11GeometryShader* pShader, ID3D11ClassInstance* ppClassInstances, UINT NumClassInstances)</b><br/>
	/// </summary>
	/// <param name="pShader">_In_opt_ <b>ID3D11GeometryShader* pShader</b></param>
	/// <param name="ppClassInstances">_In_reads_opt_(NumClassInstances) <b>ID3D11ClassInstance* ppClassInstances</b></param>
	/// <param name="numClassInstances"><b>UINT NumClassInstances</b></param>
	void GSSetShader<T0, T1> (T0* pShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IGeometryShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IASetPrimitiveTopology (D3D11_PRIMITIVE_TOPOLOGY Topology)</b><br/>
	/// </summary>
	/// <param name="topology">_In_ <b>D3D11_PRIMITIVE_TOPOLOGY Topology</b></param>
	void IASetPrimitiveTopology (Direct3D.PrimitiveTopology topology);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSSetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView* ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_In_reads_opt_(NumViews) <b>ID3D11ShaderResourceView* ppShaderResourceViews</b></param>
	void VSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSSetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState* ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_In_reads_opt_(NumSamplers) <b>ID3D11SamplerState* ppSamplers</b></param>
	void VSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::Begin (ID3D11Asynchronous* pAsync)</b><br/>
	/// </summary>
	/// <param name="pAsync">_In_ <b>ID3D11Asynchronous* pAsync</b></param>
	void Begin<T0> (T0* pAsync) where T0 : unmanaged, IAsynchronous;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::End (ID3D11Asynchronous* pAsync)</b><br/>
	/// </summary>
	/// <param name="pAsync">_In_ <b>ID3D11Asynchronous* pAsync</b></param>
	void End<T0> (T0* pAsync) where T0 : unmanaged, IAsynchronous;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext::GetData (ID3D11Asynchronous* pAsync, void* pData, UINT DataSize, UINT GetDataFlags)</b><br/>
	/// </summary>
	/// <param name="pAsync">_In_ <b>ID3D11Asynchronous* pAsync</b></param>
	/// <param name="pData">_Out_writes_bytes_opt_( DataSize ) <b>void* pData</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="getDataFlags">_In_ <b>UINT GetDataFlags</b></param>
	int GetData<T0> (T0* pAsync, void* pData, uint dataSize, uint getDataFlags) where T0 : unmanaged, IAsynchronous;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::SetPredication (ID3D11Predicate* pPredicate, BOOL PredicateValue)</b><br/>
	/// </summary>
	/// <param name="pPredicate">_In_opt_ <b>ID3D11Predicate* pPredicate</b></param>
	/// <param name="predicateValue">_In_ <b>BOOL PredicateValue</b></param>
	void SetPredication<T0> (T0* pPredicate, bool predicateValue) where T0 : unmanaged, IPredicate;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSSetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView* ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_In_reads_opt_(NumViews) <b>ID3D11ShaderResourceView* ppShaderResourceViews</b></param>
	void GSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSSetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState* ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_In_reads_opt_(NumSamplers) <b>ID3D11SamplerState* ppSamplers</b></param>
	void GSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMSetRenderTargets (UINT NumViews, ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)</b><br/>
	/// </summary>
	/// <param name="numViews">_In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) <b>UINT NumViews</b></param>
	/// <param name="ppRenderTargetViews">_In_reads_opt_(NumViews) <b>ID3D11RenderTargetView* ppRenderTargetViews</b></param>
	/// <param name="pDepthStencilView">_In_opt_ <b>ID3D11DepthStencilView* pDepthStencilView</b></param>
	void OMSetRenderTargets<T0, T1> (uint numViews, T0* ppRenderTargetViews, T1* pDepthStencilView) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMSetRenderTargetsAndUnorderedAccessViews (UINT NumRTVs, ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, UINT UAVStartSlot, UINT NumUAVs, ID3D11UnorderedAccessView* ppUnorderedAccessViews, UINT* pUAVInitialCounts)</b><br/>
	/// </summary>
	/// <param name="numRTVs">_In_ <b>UINT NumRTVs</b></param>
	/// <param name="ppRenderTargetViews">_In_reads_opt_(NumRTVs) <b>ID3D11RenderTargetView* ppRenderTargetViews</b></param>
	/// <param name="pDepthStencilView">_In_opt_ <b>ID3D11DepthStencilView* pDepthStencilView</b></param>
	/// <param name="uAVStartSlot">_In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) <b>UINT UAVStartSlot</b></param>
	/// <param name="numUAVs">_In_ <b>UINT NumUAVs</b></param>
	/// <param name="ppUnorderedAccessViews">_In_reads_opt_(NumUAVs) <b>ID3D11UnorderedAccessView* ppUnorderedAccessViews</b></param>
	/// <param name="pUAVInitialCounts">_In_reads_opt_(NumUAVs) <b>UINT* pUAVInitialCounts</b></param>
	void OMSetRenderTargetsAndUnorderedAccessViews<T0, T1, T2> (uint numRTVs, T0* ppRenderTargetViews, T1* pDepthStencilView, uint uAVStartSlot, uint numUAVs, T2* ppUnorderedAccessViews, uint* pUAVInitialCounts) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView where T2 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMSetBlendState (ID3D11BlendState* pBlendState, FLOAT 4, UINT SampleMask)</b><br/>
	/// </summary>
	/// <param name="pBlendState">_In_opt_ <b>ID3D11BlendState* pBlendState</b></param>
	/// <param name="blendFactor">_In_opt_ <b>FLOAT [4] BlendFactor</b></param>
	/// <param name="sampleMask">_In_ <b>UINT SampleMask</b></param>
	void OMSetBlendState<T0> (T0* pBlendState, Vector4F* blendFactor, uint sampleMask) where T0 : unmanaged, IBlendState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMSetDepthStencilState (ID3D11DepthStencilState* pDepthStencilState, UINT StencilRef)</b><br/>
	/// </summary>
	/// <param name="pDepthStencilState">_In_opt_ <b>ID3D11DepthStencilState* pDepthStencilState</b></param>
	/// <param name="stencilRef">_In_ <b>UINT StencilRef</b></param>
	void OMSetDepthStencilState<T0> (T0* pDepthStencilState, uint stencilRef) where T0 : unmanaged, IDepthStencilState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::SOSetTargets (UINT NumBuffers, ID3D11Buffer* ppSOTargets, UINT* pOffsets)</b><br/>
	/// </summary>
	/// <param name="numBuffers">_In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT) <b>UINT NumBuffers</b></param>
	/// <param name="ppSOTargets">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppSOTargets</b></param>
	/// <param name="pOffsets">_In_reads_opt_(NumBuffers) <b>UINT* pOffsets</b></param>
	void SOSetTargets<T0> (uint numBuffers, T0* ppSOTargets, uint* pOffsets) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DrawAuto ()</b><br/>
	/// </summary>
	void DrawAuto ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DrawIndexedInstancedIndirect (ID3D11Buffer* pBufferForArgs, UINT AlignedByteOffsetForArgs)</b><br/>
	/// </summary>
	/// <param name="pBufferForArgs">_In_ <b>ID3D11Buffer* pBufferForArgs</b></param>
	/// <param name="alignedByteOffsetForArgs">_In_ <b>UINT AlignedByteOffsetForArgs</b></param>
	void DrawIndexedInstancedIndirect<T0> (T0* pBufferForArgs, uint alignedByteOffsetForArgs) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DrawInstancedIndirect (ID3D11Buffer* pBufferForArgs, UINT AlignedByteOffsetForArgs)</b><br/>
	/// </summary>
	/// <param name="pBufferForArgs">_In_ <b>ID3D11Buffer* pBufferForArgs</b></param>
	/// <param name="alignedByteOffsetForArgs">_In_ <b>UINT AlignedByteOffsetForArgs</b></param>
	void DrawInstancedIndirect<T0> (T0* pBufferForArgs, uint alignedByteOffsetForArgs) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::Dispatch (UINT ThreadGroupCountX, UINT ThreadGroupCountY, UINT ThreadGroupCountZ)</b><br/>
	/// </summary>
	/// <param name="threadGroupCountX">_In_ <b>UINT ThreadGroupCountX</b></param>
	/// <param name="threadGroupCountY">_In_ <b>UINT ThreadGroupCountY</b></param>
	/// <param name="threadGroupCountZ">_In_ <b>UINT ThreadGroupCountZ</b></param>
	void Dispatch (uint threadGroupCountX, uint threadGroupCountY, uint threadGroupCountZ);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DispatchIndirect (ID3D11Buffer* pBufferForArgs, UINT AlignedByteOffsetForArgs)</b><br/>
	/// </summary>
	/// <param name="pBufferForArgs">_In_ <b>ID3D11Buffer* pBufferForArgs</b></param>
	/// <param name="alignedByteOffsetForArgs">_In_ <b>UINT AlignedByteOffsetForArgs</b></param>
	void DispatchIndirect<T0> (T0* pBufferForArgs, uint alignedByteOffsetForArgs) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::RSSetState (ID3D11RasterizerState* pRasterizerState)</b><br/>
	/// </summary>
	/// <param name="pRasterizerState">_In_opt_ <b>ID3D11RasterizerState* pRasterizerState</b></param>
	void RSSetState<T0> (T0* pRasterizerState) where T0 : unmanaged, IRasterizerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::RSSetViewports (UINT NumViewports, D3D11_VIEWPORT* pViewports)</b><br/>
	/// </summary>
	/// <param name="numViewports">_In_range_(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) <b>UINT NumViewports</b></param>
	/// <param name="pViewports">_In_reads_opt_(NumViewports) <b>D3D11_VIEWPORT* pViewports</b></param>
	void RSSetViewports (uint numViewports, Viewport* pViewports);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::RSSetScissorRects (UINT NumRects, D3D11_RECT* pRects)</b><br/>
	/// </summary>
	/// <param name="numRects">_In_range_(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) <b>UINT NumRects</b></param>
	/// <param name="pRects">_In_reads_opt_(NumRects) <b>D3D11_RECT* pRects</b></param>
	void RSSetScissorRects (uint numRects, Vector4I* pRects);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CopySubresourceRegion (ID3D11Resource* pDstResource, UINT DstSubresource, UINT DstX, UINT DstY, UINT DstZ, ID3D11Resource* pSrcResource, UINT SrcSubresource, D3D11_BOX* pSrcBox)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D11Resource* pDstResource</b></param>
	/// <param name="dstSubresource">_In_ <b>UINT DstSubresource</b></param>
	/// <param name="dstX">_In_ <b>UINT DstX</b></param>
	/// <param name="dstY">_In_ <b>UINT DstY</b></param>
	/// <param name="dstZ">_In_ <b>UINT DstZ</b></param>
	/// <param name="pSrcResource">_In_ <b>ID3D11Resource* pSrcResource</b></param>
	/// <param name="srcSubresource">_In_ <b>UINT SrcSubresource</b></param>
	/// <param name="pSrcBox">_In_opt_ <b>D3D11_BOX* pSrcBox</b></param>
	void CopySubresourceRegion<T0, T1> (T0* pDstResource, uint dstSubresource, uint dstX, uint dstY, uint dstZ, T1* pSrcResource, uint srcSubresource, Box* pSrcBox) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CopyResource (ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D11Resource* pDstResource</b></param>
	/// <param name="pSrcResource">_In_ <b>ID3D11Resource* pSrcResource</b></param>
	void CopyResource<T0, T1> (T0* pDstResource, T1* pSrcResource) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::UpdateSubresource (ID3D11Resource* pDstResource, UINT DstSubresource, D3D11_BOX* pDstBox, void* pSrcData, UINT SrcRowPitch, UINT SrcDepthPitch)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D11Resource* pDstResource</b></param>
	/// <param name="dstSubresource">_In_ <b>UINT DstSubresource</b></param>
	/// <param name="pDstBox">_In_opt_ <b>D3D11_BOX* pDstBox</b></param>
	/// <param name="pSrcData">_In_ <b>void* pSrcData</b></param>
	/// <param name="srcRowPitch">_In_ <b>UINT SrcRowPitch</b></param>
	/// <param name="srcDepthPitch">_In_ <b>UINT SrcDepthPitch</b></param>
	void UpdateSubresource<T0> (T0* pDstResource, uint dstSubresource, Box* pDstBox, void* pSrcData, uint srcRowPitch, uint srcDepthPitch) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CopyStructureCount (ID3D11Buffer* pDstBuffer, UINT DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)</b><br/>
	/// </summary>
	/// <param name="pDstBuffer">_In_ <b>ID3D11Buffer* pDstBuffer</b></param>
	/// <param name="dstAlignedByteOffset">_In_ <b>UINT DstAlignedByteOffset</b></param>
	/// <param name="pSrcView">_In_ <b>ID3D11UnorderedAccessView* pSrcView</b></param>
	void CopyStructureCount<T0, T1> (T0* pDstBuffer, uint dstAlignedByteOffset, T1* pSrcView) where T0 : unmanaged, IBuffer where T1 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::ClearRenderTargetView (ID3D11RenderTargetView* pRenderTargetView)</b><br/>
	/// </summary>
	/// <param name="pRenderTargetView">_In_ <b>ID3D11RenderTargetView* pRenderTargetView</b></param>
	void ClearRenderTargetView<T0> (T0* pRenderTargetView) where T0 : unmanaged, IRenderTargetView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::ClearUnorderedAccessViewUint (ID3D11UnorderedAccessView* pUnorderedAccessView)</b><br/>
	/// </summary>
	/// <param name="pUnorderedAccessView">_In_ <b>ID3D11UnorderedAccessView* pUnorderedAccessView</b></param>
	void ClearUnorderedAccessViewUint<T0> (T0* pUnorderedAccessView) where T0 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::ClearUnorderedAccessViewFloat (ID3D11UnorderedAccessView* pUnorderedAccessView)</b><br/>
	/// </summary>
	/// <param name="pUnorderedAccessView">_In_ <b>ID3D11UnorderedAccessView* pUnorderedAccessView</b></param>
	void ClearUnorderedAccessViewFloat<T0> (T0* pUnorderedAccessView) where T0 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::ClearDepthStencilView (ID3D11DepthStencilView* pDepthStencilView, UINT ClearFlags, FLOAT Depth, UINT8 Stencil)</b><br/>
	/// </summary>
	/// <param name="pDepthStencilView">_In_ <b>ID3D11DepthStencilView* pDepthStencilView</b></param>
	/// <param name="clearFlags">_In_ <b>UINT ClearFlags</b></param>
	/// <param name="depth">_In_ <b>FLOAT Depth</b></param>
	/// <param name="stencil">_In_ <b>UINT8 Stencil</b></param>
	void ClearDepthStencilView<T0> (T0* pDepthStencilView, uint clearFlags, float depth, byte stencil) where T0 : unmanaged, IDepthStencilView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GenerateMips (ID3D11ShaderResourceView* pShaderResourceView)</b><br/>
	/// </summary>
	/// <param name="pShaderResourceView">_In_ <b>ID3D11ShaderResourceView* pShaderResourceView</b></param>
	void GenerateMips<T0> (T0* pShaderResourceView) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::SetResourceMinLOD (ID3D11Resource* pResource, FLOAT MinLOD)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="minLOD"><b>FLOAT MinLOD</b></param>
	void SetResourceMinLOD<T0> (T0* pResource, float minLOD) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>FLOAT ID3D11DeviceContext::GetResourceMinLOD (ID3D11Resource* pResource)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	float GetResourceMinLOD<T0> (T0* pResource) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::ResolveSubresource (ID3D11Resource* pDstResource, UINT DstSubresource, ID3D11Resource* pSrcResource, UINT SrcSubresource, DXGI_FORMAT Format)</b><br/>
	/// </summary>
	/// <param name="pDstResource">_In_ <b>ID3D11Resource* pDstResource</b></param>
	/// <param name="dstSubresource">_In_ <b>UINT DstSubresource</b></param>
	/// <param name="pSrcResource">_In_ <b>ID3D11Resource* pSrcResource</b></param>
	/// <param name="srcSubresource">_In_ <b>UINT SrcSubresource</b></param>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	void ResolveSubresource<T0, T1> (T0* pDstResource, uint dstSubresource, T1* pSrcResource, uint srcSubresource, DXGI.Format format) where T0 : unmanaged, IResource where T1 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::ExecuteCommandList (ID3D11CommandList* pCommandList, BOOL RestoreContextState)</b><br/>
	/// </summary>
	/// <param name="pCommandList">_In_ <b>ID3D11CommandList* pCommandList</b></param>
	/// <param name="restoreContextState"><b>BOOL RestoreContextState</b></param>
	void ExecuteCommandList<T0> (T0* pCommandList, bool restoreContextState) where T0 : unmanaged, ICommandList;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSSetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView* ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_In_reads_opt_(NumViews) <b>ID3D11ShaderResourceView* ppShaderResourceViews</b></param>
	void HSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSSetShader (ID3D11HullShader* pHullShader, ID3D11ClassInstance* ppClassInstances, UINT NumClassInstances)</b><br/>
	/// </summary>
	/// <param name="pHullShader">_In_opt_ <b>ID3D11HullShader* pHullShader</b></param>
	/// <param name="ppClassInstances">_In_reads_opt_(NumClassInstances) <b>ID3D11ClassInstance* ppClassInstances</b></param>
	/// <param name="numClassInstances"><b>UINT NumClassInstances</b></param>
	void HSSetShader<T0, T1> (T0* pHullShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IHullShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSSetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState* ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_In_reads_opt_(NumSamplers) <b>ID3D11SamplerState* ppSamplers</b></param>
	void HSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSSetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer* ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppConstantBuffers</b></param>
	void HSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSSetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView* ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_In_reads_opt_(NumViews) <b>ID3D11ShaderResourceView* ppShaderResourceViews</b></param>
	void DSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSSetShader (ID3D11DomainShader* pDomainShader, ID3D11ClassInstance* ppClassInstances, UINT NumClassInstances)</b><br/>
	/// </summary>
	/// <param name="pDomainShader">_In_opt_ <b>ID3D11DomainShader* pDomainShader</b></param>
	/// <param name="ppClassInstances">_In_reads_opt_(NumClassInstances) <b>ID3D11ClassInstance* ppClassInstances</b></param>
	/// <param name="numClassInstances"><b>UINT NumClassInstances</b></param>
	void DSSetShader<T0, T1> (T0* pDomainShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IDomainShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSSetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState* ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_In_reads_opt_(NumSamplers) <b>ID3D11SamplerState* ppSamplers</b></param>
	void DSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSSetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer* ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppConstantBuffers</b></param>
	void DSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSSetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView* ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_In_reads_opt_(NumViews) <b>ID3D11ShaderResourceView* ppShaderResourceViews</b></param>
	void CSSetShaderResources<T0> (uint startSlot, uint numViews, T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSSetUnorderedAccessViews (UINT StartSlot, UINT NumUAVs, ID3D11UnorderedAccessView* ppUnorderedAccessViews, UINT* pUAVInitialCounts)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numUAVs">_In_range_( 0, D3D11_1_UAV_SLOT_COUNT - StartSlot ) <b>UINT NumUAVs</b></param>
	/// <param name="ppUnorderedAccessViews">_In_reads_opt_(NumUAVs) <b>ID3D11UnorderedAccessView* ppUnorderedAccessViews</b></param>
	/// <param name="pUAVInitialCounts">_In_reads_opt_(NumUAVs) <b>UINT* pUAVInitialCounts</b></param>
	void CSSetUnorderedAccessViews<T0> (uint startSlot, uint numUAVs, T0* ppUnorderedAccessViews, uint* pUAVInitialCounts) where T0 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSSetShader (ID3D11ComputeShader* pComputeShader, ID3D11ClassInstance* ppClassInstances, UINT NumClassInstances)</b><br/>
	/// </summary>
	/// <param name="pComputeShader">_In_opt_ <b>ID3D11ComputeShader* pComputeShader</b></param>
	/// <param name="ppClassInstances">_In_reads_opt_(NumClassInstances) <b>ID3D11ClassInstance* ppClassInstances</b></param>
	/// <param name="numClassInstances"><b>UINT NumClassInstances</b></param>
	void CSSetShader<T0, T1> (T0* pComputeShader, T1* ppClassInstances, uint numClassInstances) where T0 : unmanaged, IComputeShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSSetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState* ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_In_reads_opt_(NumSamplers) <b>ID3D11SamplerState* ppSamplers</b></param>
	void CSSetSamplers<T0> (uint startSlot, uint numSamplers, T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSSetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer* ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_In_reads_opt_(NumBuffers) <b>ID3D11Buffer* ppConstantBuffers</b></param>
	void CSSetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void VSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void VSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void PSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void PSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetShader (ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppPixelShader">_Outptr_result_maybenull_ <b>ID3D11PixelShader** ppPixelShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void PSGetShader<T0, T1> (T0** ppPixelShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IPixelShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetShader (ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppPixelShader">_Outptr_result_maybenull_ <b>ID3D11PixelShader** ppPixelShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void PSGetShader<T0, T1> (out T0* ppPixelShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IPixelShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void PSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void PSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetShader (ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppVertexShader">_Outptr_result_maybenull_ <b>ID3D11VertexShader** ppVertexShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void VSGetShader<T0, T1> (T0** ppVertexShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IVertexShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetShader (ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppVertexShader">_Outptr_result_maybenull_ <b>ID3D11VertexShader** ppVertexShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void VSGetShader<T0, T1> (out T0* ppVertexShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IVertexShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void PSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::PSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void PSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetInputLayout (ID3D11InputLayout** ppInputLayout)</b><br/>
	/// </summary>
	/// <param name="ppInputLayout">_Outptr_result_maybenull_ <b>ID3D11InputLayout** ppInputLayout</b></param>
	void IAGetInputLayout<T0> (T0** ppInputLayout) where T0 : unmanaged, IInputLayout;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetInputLayout (ID3D11InputLayout** ppInputLayout)</b><br/>
	/// </summary>
	/// <param name="ppInputLayout">_Outptr_result_maybenull_ <b>ID3D11InputLayout** ppInputLayout</b></param>
	void IAGetInputLayout<T0> (out T0* ppInputLayout) where T0 : unmanaged, IInputLayout;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetVertexBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppVertexBuffers, UINT* pStrides, UINT* pOffsets)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppVertexBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppVertexBuffers</b></param>
	/// <param name="pStrides">_Out_writes_opt_(NumBuffers) <b>UINT* pStrides</b></param>
	/// <param name="pOffsets">_Out_writes_opt_(NumBuffers) <b>UINT* pOffsets</b></param>
	void IAGetVertexBuffers<T0> (uint startSlot, uint numBuffers, T0** ppVertexBuffers, uint* pStrides, uint* pOffsets) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetVertexBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppVertexBuffers, UINT* pStrides, UINT* pOffsets)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppVertexBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppVertexBuffers</b></param>
	/// <param name="pStrides">_Out_writes_opt_(NumBuffers) <b>UINT* pStrides</b></param>
	/// <param name="pOffsets">_Out_writes_opt_(NumBuffers) <b>UINT* pOffsets</b></param>
	void IAGetVertexBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppVertexBuffers, uint* pStrides, uint* pOffsets) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetIndexBuffer (ID3D11Buffer** pIndexBuffer, DXGI_FORMAT* Format, UINT* Offset)</b><br/>
	/// </summary>
	/// <param name="pIndexBuffer">_Outptr_opt_result_maybenull_ <b>ID3D11Buffer** pIndexBuffer</b></param>
	/// <param name="format">_Out_opt_ <b>DXGI_FORMAT* Format</b></param>
	/// <param name="offset">_Out_opt_ <b>UINT* Offset</b></param>
	void IAGetIndexBuffer<T0> (T0** pIndexBuffer, DXGI.Format* format, uint* offset) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetIndexBuffer (ID3D11Buffer** pIndexBuffer, DXGI_FORMAT* Format, UINT* Offset)</b><br/>
	/// </summary>
	/// <param name="pIndexBuffer">_Outptr_opt_result_maybenull_ <b>ID3D11Buffer** pIndexBuffer</b></param>
	/// <param name="format">_Out_opt_ <b>DXGI_FORMAT* Format</b></param>
	/// <param name="offset">_Out_opt_ <b>UINT* Offset</b></param>
	void IAGetIndexBuffer<T0> (out T0* pIndexBuffer, out DXGI.Format format, out uint offset) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void GSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void GSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetShader (ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppGeometryShader">_Outptr_result_maybenull_ <b>ID3D11GeometryShader** ppGeometryShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void GSGetShader<T0, T1> (T0** ppGeometryShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IGeometryShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetShader (ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppGeometryShader">_Outptr_result_maybenull_ <b>ID3D11GeometryShader** ppGeometryShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void GSGetShader<T0, T1> (out T0* ppGeometryShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IGeometryShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetPrimitiveTopology (D3D11_PRIMITIVE_TOPOLOGY* pTopology)</b><br/>
	/// </summary>
	/// <param name="pTopology">_Out_ <b>D3D11_PRIMITIVE_TOPOLOGY* pTopology</b></param>
	void IAGetPrimitiveTopology (Direct3D.PrimitiveTopology* pTopology);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::IAGetPrimitiveTopology (D3D11_PRIMITIVE_TOPOLOGY* pTopology)</b><br/>
	/// </summary>
	/// <param name="pTopology">_Out_ <b>D3D11_PRIMITIVE_TOPOLOGY* pTopology</b></param>
	void IAGetPrimitiveTopology (out Direct3D.PrimitiveTopology pTopology);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void VSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void VSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void VSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::VSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void VSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GetPredication (ID3D11Predicate** ppPredicate, BOOL* pPredicateValue)</b><br/>
	/// </summary>
	/// <param name="ppPredicate">_Outptr_opt_result_maybenull_ <b>ID3D11Predicate** ppPredicate</b></param>
	/// <param name="pPredicateValue">_Out_opt_ <b>BOOL* pPredicateValue</b></param>
	void GetPredication<T0> (T0** ppPredicate, uint* pPredicateValue) where T0 : unmanaged, IPredicate;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GetPredication (ID3D11Predicate** ppPredicate, BOOL* pPredicateValue)</b><br/>
	/// </summary>
	/// <param name="ppPredicate">_Outptr_opt_result_maybenull_ <b>ID3D11Predicate** ppPredicate</b></param>
	/// <param name="pPredicateValue">_Out_opt_ <b>BOOL* pPredicateValue</b></param>
	void GetPredication<T0> (out T0* ppPredicate, out bool pPredicateValue) where T0 : unmanaged, IPredicate;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void GSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void GSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void GSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::GSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void GSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetRenderTargets (UINT NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)</b><br/>
	/// </summary>
	/// <param name="numViews">_In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) <b>UINT NumViews</b></param>
	/// <param name="ppRenderTargetViews">_Out_writes_opt_(NumViews) <b>ID3D11RenderTargetView** ppRenderTargetViews</b></param>
	/// <param name="ppDepthStencilView">_Outptr_opt_result_maybenull_ <b>ID3D11DepthStencilView** ppDepthStencilView</b></param>
	void OMGetRenderTargets<T0, T1> (uint numViews, T0** ppRenderTargetViews, T1** ppDepthStencilView) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetRenderTargets (UINT NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)</b><br/>
	/// </summary>
	/// <param name="numViews">_In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) <b>UINT NumViews</b></param>
	/// <param name="ppRenderTargetViews">_Out_writes_opt_(NumViews) <b>ID3D11RenderTargetView** ppRenderTargetViews</b></param>
	/// <param name="ppDepthStencilView">_Outptr_opt_result_maybenull_ <b>ID3D11DepthStencilView** ppDepthStencilView</b></param>
	void OMGetRenderTargets<T0, T1> (uint numViews, out T0* ppRenderTargetViews, out T1* ppDepthStencilView) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetRenderTargetsAndUnorderedAccessViews (UINT NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, UINT UAVStartSlot, UINT NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)</b><br/>
	/// </summary>
	/// <param name="numRTVs">_In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) <b>UINT NumRTVs</b></param>
	/// <param name="ppRenderTargetViews">_Out_writes_opt_(NumRTVs) <b>ID3D11RenderTargetView** ppRenderTargetViews</b></param>
	/// <param name="ppDepthStencilView">_Outptr_opt_result_maybenull_ <b>ID3D11DepthStencilView** ppDepthStencilView</b></param>
	/// <param name="uAVStartSlot">_In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - 1 ) <b>UINT UAVStartSlot</b></param>
	/// <param name="numUAVs">_In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - UAVStartSlot ) <b>UINT NumUAVs</b></param>
	/// <param name="ppUnorderedAccessViews">_Out_writes_opt_(NumUAVs) <b>ID3D11UnorderedAccessView** ppUnorderedAccessViews</b></param>
	void OMGetRenderTargetsAndUnorderedAccessViews<T0, T1, T2> (uint numRTVs, T0** ppRenderTargetViews, T1** ppDepthStencilView, uint uAVStartSlot, uint numUAVs, T2** ppUnorderedAccessViews) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView where T2 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetRenderTargetsAndUnorderedAccessViews (UINT NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, UINT UAVStartSlot, UINT NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)</b><br/>
	/// </summary>
	/// <param name="numRTVs">_In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) <b>UINT NumRTVs</b></param>
	/// <param name="ppRenderTargetViews">_Out_writes_opt_(NumRTVs) <b>ID3D11RenderTargetView** ppRenderTargetViews</b></param>
	/// <param name="ppDepthStencilView">_Outptr_opt_result_maybenull_ <b>ID3D11DepthStencilView** ppDepthStencilView</b></param>
	/// <param name="uAVStartSlot">_In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - 1 ) <b>UINT UAVStartSlot</b></param>
	/// <param name="numUAVs">_In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - UAVStartSlot ) <b>UINT NumUAVs</b></param>
	/// <param name="ppUnorderedAccessViews">_Out_writes_opt_(NumUAVs) <b>ID3D11UnorderedAccessView** ppUnorderedAccessViews</b></param>
	void OMGetRenderTargetsAndUnorderedAccessViews<T0, T1, T2> (uint numRTVs, out T0* ppRenderTargetViews, out T1* ppDepthStencilView, uint uAVStartSlot, uint numUAVs, out T2* ppUnorderedAccessViews) where T0 : unmanaged, IRenderTargetView where T1 : unmanaged, IDepthStencilView where T2 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetBlendState (ID3D11BlendState** ppBlendState, FLOAT [4] BlendFactor, UINT* pSampleMask)</b><br/>
	/// </summary>
	/// <param name="ppBlendState">_Outptr_opt_result_maybenull_ <b>ID3D11BlendState** ppBlendState</b></param>
	/// <param name="blendFactor">_Out_opt_ <b>FLOAT [4] BlendFactor</b></param>
	/// <param name="pSampleMask">_Out_opt_ <b>UINT* pSampleMask</b></param>
	void OMGetBlendState<T0> (T0** ppBlendState, Vector4F* blendFactor, uint* pSampleMask) where T0 : unmanaged, IBlendState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetBlendState (ID3D11BlendState** ppBlendState, FLOAT [4] BlendFactor, UINT* pSampleMask)</b><br/>
	/// </summary>
	/// <param name="ppBlendState">_Outptr_opt_result_maybenull_ <b>ID3D11BlendState** ppBlendState</b></param>
	/// <param name="blendFactor">_Out_opt_ <b>FLOAT [4] BlendFactor</b></param>
	/// <param name="pSampleMask">_Out_opt_ <b>UINT* pSampleMask</b></param>
	void OMGetBlendState<T0> (out T0* ppBlendState, out Vector4F blendFactor, out uint pSampleMask) where T0 : unmanaged, IBlendState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetDepthStencilState (ID3D11DepthStencilState** ppDepthStencilState, UINT* pStencilRef)</b><br/>
	/// </summary>
	/// <param name="ppDepthStencilState">_Outptr_opt_result_maybenull_ <b>ID3D11DepthStencilState** ppDepthStencilState</b></param>
	/// <param name="pStencilRef">_Out_opt_ <b>UINT* pStencilRef</b></param>
	void OMGetDepthStencilState<T0> (T0** ppDepthStencilState, uint* pStencilRef) where T0 : unmanaged, IDepthStencilState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::OMGetDepthStencilState (ID3D11DepthStencilState** ppDepthStencilState, UINT* pStencilRef)</b><br/>
	/// </summary>
	/// <param name="ppDepthStencilState">_Outptr_opt_result_maybenull_ <b>ID3D11DepthStencilState** ppDepthStencilState</b></param>
	/// <param name="pStencilRef">_Out_opt_ <b>UINT* pStencilRef</b></param>
	void OMGetDepthStencilState<T0> (out T0* ppDepthStencilState, out uint pStencilRef) where T0 : unmanaged, IDepthStencilState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::SOGetTargets (UINT NumBuffers, ID3D11Buffer** ppSOTargets)</b><br/>
	/// </summary>
	/// <param name="numBuffers">_In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT ) <b>UINT NumBuffers</b></param>
	/// <param name="ppSOTargets">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppSOTargets</b></param>
	void SOGetTargets<T0> (uint numBuffers, T0** ppSOTargets) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::SOGetTargets (UINT NumBuffers, ID3D11Buffer** ppSOTargets)</b><br/>
	/// </summary>
	/// <param name="numBuffers">_In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT ) <b>UINT NumBuffers</b></param>
	/// <param name="ppSOTargets">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppSOTargets</b></param>
	void SOGetTargets<T0> (uint numBuffers, out T0* ppSOTargets) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::RSGetState (ID3D11RasterizerState** ppRasterizerState)</b><br/>
	/// </summary>
	/// <param name="ppRasterizerState">_Outptr_result_maybenull_ <b>ID3D11RasterizerState** ppRasterizerState</b></param>
	void RSGetState<T0> (T0** ppRasterizerState) where T0 : unmanaged, IRasterizerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::RSGetState (ID3D11RasterizerState** ppRasterizerState)</b><br/>
	/// </summary>
	/// <param name="ppRasterizerState">_Outptr_result_maybenull_ <b>ID3D11RasterizerState** ppRasterizerState</b></param>
	void RSGetState<T0> (out T0* ppRasterizerState) where T0 : unmanaged, IRasterizerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::RSGetViewports (UINT* pNumViewports, D3D11_VIEWPORT* pViewports)</b><br/>
	/// </summary>
	/// <param name="pNumViewports">_Inout_ <b>UINT* pNumViewports</b></param>
	/// <param name="pViewports">_Out_writes_opt_(*pNumViewports) <b>D3D11_VIEWPORT* pViewports</b></param>
	void RSGetViewports (uint* pNumViewports, Viewport* pViewports);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::RSGetScissorRects (UINT* pNumRects, D3D11_RECT* pRects)</b><br/>
	/// </summary>
	/// <param name="pNumRects">_Inout_ <b>UINT* pNumRects</b></param>
	/// <param name="pRects">_Out_writes_opt_(*pNumRects) <b>D3D11_RECT* pRects</b></param>
	void RSGetScissorRects (uint* pNumRects, Vector4I* pRects);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void HSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void HSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetShader (ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppHullShader">_Outptr_result_maybenull_ <b>ID3D11HullShader** ppHullShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void HSGetShader<T0, T1> (T0** ppHullShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IHullShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetShader (ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppHullShader">_Outptr_result_maybenull_ <b>ID3D11HullShader** ppHullShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void HSGetShader<T0, T1> (out T0* ppHullShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IHullShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void HSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void HSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void HSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::HSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void HSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void DSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void DSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetShader (ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppDomainShader">_Outptr_result_maybenull_ <b>ID3D11DomainShader** ppDomainShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void DSGetShader<T0, T1> (T0** ppDomainShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IDomainShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetShader (ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppDomainShader">_Outptr_result_maybenull_ <b>ID3D11DomainShader** ppDomainShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void DSGetShader<T0, T1> (out T0* ppDomainShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IDomainShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void DSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void DSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void DSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::DSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void DSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void CSGetShaderResources<T0> (uint startSlot, uint numViews, T0** ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetShaderResources (UINT StartSlot, UINT NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numViews">_In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) <b>UINT NumViews</b></param>
	/// <param name="ppShaderResourceViews">_Out_writes_opt_(NumViews) <b>ID3D11ShaderResourceView** ppShaderResourceViews</b></param>
	void CSGetShaderResources<T0> (uint startSlot, uint numViews, out T0* ppShaderResourceViews) where T0 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetUnorderedAccessViews (UINT StartSlot, UINT NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numUAVs">_In_range_( 0, D3D11_1_UAV_SLOT_COUNT - StartSlot ) <b>UINT NumUAVs</b></param>
	/// <param name="ppUnorderedAccessViews">_Out_writes_opt_(NumUAVs) <b>ID3D11UnorderedAccessView** ppUnorderedAccessViews</b></param>
	void CSGetUnorderedAccessViews<T0> (uint startSlot, uint numUAVs, T0** ppUnorderedAccessViews) where T0 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetUnorderedAccessViews (UINT StartSlot, UINT NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numUAVs">_In_range_( 0, D3D11_1_UAV_SLOT_COUNT - StartSlot ) <b>UINT NumUAVs</b></param>
	/// <param name="ppUnorderedAccessViews">_Out_writes_opt_(NumUAVs) <b>ID3D11UnorderedAccessView** ppUnorderedAccessViews</b></param>
	void CSGetUnorderedAccessViews<T0> (uint startSlot, uint numUAVs, out T0* ppUnorderedAccessViews) where T0 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetShader (ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppComputeShader">_Outptr_result_maybenull_ <b>ID3D11ComputeShader** ppComputeShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void CSGetShader<T0, T1> (T0** ppComputeShader, T1** ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IComputeShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetShader (ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, UINT* pNumClassInstances)</b><br/>
	/// </summary>
	/// <param name="ppComputeShader">_Outptr_result_maybenull_ <b>ID3D11ComputeShader** ppComputeShader</b></param>
	/// <param name="ppClassInstances">_Out_writes_opt_(*pNumClassInstances) <b>ID3D11ClassInstance** ppClassInstances</b></param>
	/// <param name="pNumClassInstances">_Inout_opt_ <b>UINT* pNumClassInstances</b></param>
	void CSGetShader<T0, T1> (out T0* ppComputeShader, out T1* ppClassInstances, uint* pNumClassInstances) where T0 : unmanaged, IComputeShader where T1 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void CSGetSamplers<T0> (uint startSlot, uint numSamplers, T0** ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetSamplers (UINT StartSlot, UINT NumSamplers, ID3D11SamplerState** ppSamplers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numSamplers">_In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) <b>UINT NumSamplers</b></param>
	/// <param name="ppSamplers">_Out_writes_opt_(NumSamplers) <b>ID3D11SamplerState** ppSamplers</b></param>
	void CSGetSamplers<T0> (uint startSlot, uint numSamplers, out T0* ppSamplers) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void CSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, T0** ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::CSGetConstantBuffers (UINT StartSlot, UINT NumBuffers, ID3D11Buffer** ppConstantBuffers)</b><br/>
	/// </summary>
	/// <param name="startSlot">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) <b>UINT StartSlot</b></param>
	/// <param name="numBuffers">_In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) <b>UINT NumBuffers</b></param>
	/// <param name="ppConstantBuffers">_Out_writes_opt_(NumBuffers) <b>ID3D11Buffer** ppConstantBuffers</b></param>
	void CSGetConstantBuffers<T0> (uint startSlot, uint numBuffers, out T0* ppConstantBuffers) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::ClearState ()</b><br/>
	/// </summary>
	void ClearState ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceContext::Flush ()</b><br/>
	/// </summary>
	void Flush ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D11_DEVICE_CONTEXT_TYPE ID3D11DeviceContext::GetType ()</b><br/>
	/// </summary>
	DeviceContextType GetDeviceContextType ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D11DeviceContext::GetContextFlags ()</b><br/>
	/// </summary>
	uint GetContextFlags ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext::FinishCommandList (BOOL RestoreDeferredContextState, ID3D11CommandList** ppCommandList)</b><br/>
	/// </summary>
	/// <param name="restoreDeferredContextState"><b>BOOL RestoreDeferredContextState</b></param>
	/// <param name="ppCommandList">_COM_Outptr_opt_ <b>ID3D11CommandList** ppCommandList</b></param>
	int FinishCommandList<T0> (bool restoreDeferredContextState, T0** ppCommandList) where T0 : unmanaged, ICommandList;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceContext::FinishCommandList (BOOL RestoreDeferredContextState, ID3D11CommandList** ppCommandList)</b><br/>
	/// </summary>
	/// <param name="restoreDeferredContextState"><b>BOOL RestoreDeferredContextState</b></param>
	/// <param name="ppCommandList">_COM_Outptr_opt_ <b>ID3D11CommandList** ppCommandList</b></param>
	int FinishCommandList<T0> (bool restoreDeferredContextState, out T0* ppCommandList) where T0 : unmanaged, ICommandList;
}

/// <summary>
/// Instance of <b>ID3D11DeviceContext</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct DeviceContext : IDeviceContext {
//unsafe public readonly struct IDeviceContextObj : IDeviceContext {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DeviceContext* GetCurrentPointer () => (DeviceContext*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDeviceContextObj* GetCurrentPointer () => (IDeviceContextObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc0bfa96c, 0xe089, 0x44fb, 0x8e, 0xaf, 0x26, 0xf8, 0x79, 0x61, 0x90, 0xda);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
