using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11Device</b> : IUnknown<br/>
/// D3D11.h
/// </summary>
unsafe public interface IDevice : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateBuffer (D3D11_BUFFER_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Buffer** ppBuffer)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_BUFFER_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_opt_ <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppBuffer">_COM_Outptr_opt_ <b>ID3D11Buffer** ppBuffer</b></param>
	int CreateBuffer<T0> (BufferDesc* pDesc, SubresourceData* pInitialData, T0** ppBuffer) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateBuffer (D3D11_BUFFER_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Buffer** ppBuffer)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_BUFFER_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_opt_ <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppBuffer">_COM_Outptr_opt_ <b>ID3D11Buffer** ppBuffer</b></param>
	int CreateBuffer<T0> (BufferDesc* pDesc, SubresourceData* pInitialData, out T0* ppBuffer) where T0 : unmanaged, IBuffer;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateTexture1D (D3D11_TEXTURE1D_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture1D** ppTexture1D)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_TEXTURE1D_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppTexture1D">_COM_Outptr_opt_ <b>ID3D11Texture1D** ppTexture1D</b></param>
	int CreateTexture1D<T0> (Texture1dDesc* pDesc, SubresourceData* pInitialData, T0** ppTexture1D) where T0 : unmanaged, ITexture1D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateTexture1D (D3D11_TEXTURE1D_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture1D** ppTexture1D)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_TEXTURE1D_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppTexture1D">_COM_Outptr_opt_ <b>ID3D11Texture1D** ppTexture1D</b></param>
	int CreateTexture1D<T0> (Texture1dDesc* pDesc, SubresourceData* pInitialData, out T0* ppTexture1D) where T0 : unmanaged, ITexture1D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateTexture2D (D3D11_TEXTURE2D_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture2D** ppTexture2D)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_TEXTURE2D_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppTexture2D">_COM_Outptr_opt_ <b>ID3D11Texture2D** ppTexture2D</b></param>
	int CreateTexture2D<T0> (Texture2dDesc* pDesc, SubresourceData* pInitialData, T0** ppTexture2D) where T0 : unmanaged, ITexture2D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateTexture2D (D3D11_TEXTURE2D_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture2D** ppTexture2D)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_TEXTURE2D_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppTexture2D">_COM_Outptr_opt_ <b>ID3D11Texture2D** ppTexture2D</b></param>
	int CreateTexture2D<T0> (Texture2dDesc* pDesc, SubresourceData* pInitialData, out T0* ppTexture2D) where T0 : unmanaged, ITexture2D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateTexture3D (D3D11_TEXTURE3D_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture3D** ppTexture3D)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_TEXTURE3D_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_reads_opt_(_Inexpressible_(pDesc->MipLevels)) <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppTexture3D">_COM_Outptr_opt_ <b>ID3D11Texture3D** ppTexture3D</b></param>
	int CreateTexture3D<T0> (Texture3dDesc* pDesc, SubresourceData* pInitialData, T0** ppTexture3D) where T0 : unmanaged, ITexture3D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateTexture3D (D3D11_TEXTURE3D_DESC* pDesc, D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture3D** ppTexture3D)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_TEXTURE3D_DESC* pDesc</b></param>
	/// <param name="pInitialData">_In_reads_opt_(_Inexpressible_(pDesc->MipLevels)) <b>D3D11_SUBRESOURCE_DATA* pInitialData</b></param>
	/// <param name="ppTexture3D">_COM_Outptr_opt_ <b>ID3D11Texture3D** ppTexture3D</b></param>
	int CreateTexture3D<T0> (Texture3dDesc* pDesc, SubresourceData* pInitialData, out T0* ppTexture3D) where T0 : unmanaged, ITexture3D;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateShaderResourceView (ID3D11Resource* pResource, D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, ID3D11ShaderResourceView** ppSRView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc</b></param>
	/// <param name="ppSRView">_COM_Outptr_opt_ <b>ID3D11ShaderResourceView** ppSRView</b></param>
	int CreateShaderResourceView<T0, T1> (T0* pResource, ShaderResourceViewDesc* pDesc, T1** ppSRView) where T0 : unmanaged, IResource where T1 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateShaderResourceView (ID3D11Resource* pResource, D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, ID3D11ShaderResourceView** ppSRView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc</b></param>
	/// <param name="ppSRView">_COM_Outptr_opt_ <b>ID3D11ShaderResourceView** ppSRView</b></param>
	int CreateShaderResourceView<T0, T1> (T0* pResource, ShaderResourceViewDesc* pDesc, out T1* ppSRView) where T0 : unmanaged, IResource where T1 : unmanaged, IShaderResourceView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateUnorderedAccessView (ID3D11Resource* pResource, D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, ID3D11UnorderedAccessView** ppUAView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc</b></param>
	/// <param name="ppUAView">_COM_Outptr_opt_ <b>ID3D11UnorderedAccessView** ppUAView</b></param>
	int CreateUnorderedAccessView<T0, T1> (T0* pResource, UnorderedAccessViewDesc* pDesc, T1** ppUAView) where T0 : unmanaged, IResource where T1 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateUnorderedAccessView (ID3D11Resource* pResource, D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, ID3D11UnorderedAccessView** ppUAView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc</b></param>
	/// <param name="ppUAView">_COM_Outptr_opt_ <b>ID3D11UnorderedAccessView** ppUAView</b></param>
	int CreateUnorderedAccessView<T0, T1> (T0* pResource, UnorderedAccessViewDesc* pDesc, out T1* ppUAView) where T0 : unmanaged, IResource where T1 : unmanaged, IUnorderedAccessView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateRenderTargetView (ID3D11Resource* pResource, D3D11_RENDER_TARGET_VIEW_DESC* pDesc, ID3D11RenderTargetView** ppRTView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_RENDER_TARGET_VIEW_DESC* pDesc</b></param>
	/// <param name="ppRTView">_COM_Outptr_opt_ <b>ID3D11RenderTargetView** ppRTView</b></param>
	int CreateRenderTargetView<T0, T1> (T0* pResource, RenderTargetViewDesc* pDesc, T1** ppRTView) where T0 : unmanaged, IResource where T1 : unmanaged, IRenderTargetView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateRenderTargetView (ID3D11Resource* pResource, D3D11_RENDER_TARGET_VIEW_DESC* pDesc, ID3D11RenderTargetView** ppRTView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_RENDER_TARGET_VIEW_DESC* pDesc</b></param>
	/// <param name="ppRTView">_COM_Outptr_opt_ <b>ID3D11RenderTargetView** ppRTView</b></param>
	int CreateRenderTargetView<T0, T1> (T0* pResource, RenderTargetViewDesc* pDesc, out T1* ppRTView) where T0 : unmanaged, IResource where T1 : unmanaged, IRenderTargetView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDepthStencilView (ID3D11Resource* pResource, D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, ID3D11DepthStencilView** ppDepthStencilView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc</b></param>
	/// <param name="ppDepthStencilView">_COM_Outptr_opt_ <b>ID3D11DepthStencilView** ppDepthStencilView</b></param>
	int CreateDepthStencilView<T0, T1> (T0* pResource, DepthStencilViewDesc* pDesc, T1** ppDepthStencilView) where T0 : unmanaged, IResource where T1 : unmanaged, IDepthStencilView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDepthStencilView (ID3D11Resource* pResource, D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, ID3D11DepthStencilView** ppDepthStencilView)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D11Resource* pResource</b></param>
	/// <param name="pDesc">_In_opt_ <b>D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc</b></param>
	/// <param name="ppDepthStencilView">_COM_Outptr_opt_ <b>ID3D11DepthStencilView** ppDepthStencilView</b></param>
	int CreateDepthStencilView<T0, T1> (T0* pResource, DepthStencilViewDesc* pDesc, out T1* ppDepthStencilView) where T0 : unmanaged, IResource where T1 : unmanaged, IDepthStencilView;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateInputLayout (D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, UINT NumElements, void* pShaderBytecodeWithInputSignature, SIZE_T BytecodeLength, ID3D11InputLayout** ppInputLayout)</b><br/>
	/// </summary>
	/// <param name="pInputElementDescs">_In_reads_(NumElements) <b>D3D11_INPUT_ELEMENT_DESC* pInputElementDescs</b></param>
	/// <param name="numElements">_In_range_( 0, D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ) <b>UINT NumElements</b></param>
	/// <param name="pShaderBytecodeWithInputSignature">_In_reads_(BytecodeLength) <b>void* pShaderBytecodeWithInputSignature</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="ppInputLayout">_COM_Outptr_opt_ <b>ID3D11InputLayout** ppInputLayout</b></param>
	int CreateInputLayout<T0> (InputElementDesc* pInputElementDescs, uint numElements, void* pShaderBytecodeWithInputSignature, nuint bytecodeLength, T0** ppInputLayout) where T0 : unmanaged, IInputLayout;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateInputLayout (D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, UINT NumElements, void* pShaderBytecodeWithInputSignature, SIZE_T BytecodeLength, ID3D11InputLayout** ppInputLayout)</b><br/>
	/// </summary>
	/// <param name="pInputElementDescs">_In_reads_(NumElements) <b>D3D11_INPUT_ELEMENT_DESC* pInputElementDescs</b></param>
	/// <param name="numElements">_In_range_( 0, D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ) <b>UINT NumElements</b></param>
	/// <param name="pShaderBytecodeWithInputSignature">_In_reads_(BytecodeLength) <b>void* pShaderBytecodeWithInputSignature</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="ppInputLayout">_COM_Outptr_opt_ <b>ID3D11InputLayout** ppInputLayout</b></param>
	int CreateInputLayout<T0> (InputElementDesc* pInputElementDescs, uint numElements, void* pShaderBytecodeWithInputSignature, nuint bytecodeLength, out T0* ppInputLayout) where T0 : unmanaged, IInputLayout;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateVertexShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppVertexShader">_COM_Outptr_opt_ <b>ID3D11VertexShader** ppVertexShader</b></param>
	int CreateVertexShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppVertexShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IVertexShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateVertexShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppVertexShader">_COM_Outptr_opt_ <b>ID3D11VertexShader** ppVertexShader</b></param>
	int CreateVertexShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppVertexShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IVertexShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateGeometryShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppGeometryShader">_COM_Outptr_opt_ <b>ID3D11GeometryShader** ppGeometryShader</b></param>
	int CreateGeometryShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateGeometryShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppGeometryShader">_COM_Outptr_opt_ <b>ID3D11GeometryShader** ppGeometryShader</b></param>
	int CreateGeometryShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateGeometryShaderWithStreamOutput (void* pShaderBytecode, SIZE_T BytecodeLength, D3D11_SO_DECLARATION_ENTRY* pSODeclaration, UINT NumEntries, UINT* pBufferStrides, UINT NumStrides, UINT RasterizedStream, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pSODeclaration">_In_reads_opt_(NumEntries) <b>D3D11_SO_DECLARATION_ENTRY* pSODeclaration</b></param>
	/// <param name="numEntries">_In_range_( 0, D3D11_SO_STREAM_COUNT * D3D11_SO_OUTPUT_COMPONENT_COUNT ) <b>UINT NumEntries</b></param>
	/// <param name="pBufferStrides">_In_reads_opt_(NumStrides) <b>UINT* pBufferStrides</b></param>
	/// <param name="numStrides">_In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT ) <b>UINT NumStrides</b></param>
	/// <param name="rasterizedStream">_In_ <b>UINT RasterizedStream</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppGeometryShader">_COM_Outptr_opt_ <b>ID3D11GeometryShader** ppGeometryShader</b></param>
	int CreateGeometryShaderWithStreamOutput<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, SoDeclarationEntry* pSODeclaration, uint numEntries, uint* pBufferStrides, uint numStrides, uint rasterizedStream, T0* pClassLinkage, T1** ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateGeometryShaderWithStreamOutput (void* pShaderBytecode, SIZE_T BytecodeLength, D3D11_SO_DECLARATION_ENTRY* pSODeclaration, UINT NumEntries, UINT* pBufferStrides, UINT NumStrides, UINT RasterizedStream, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pSODeclaration">_In_reads_opt_(NumEntries) <b>D3D11_SO_DECLARATION_ENTRY* pSODeclaration</b></param>
	/// <param name="numEntries">_In_range_( 0, D3D11_SO_STREAM_COUNT * D3D11_SO_OUTPUT_COMPONENT_COUNT ) <b>UINT NumEntries</b></param>
	/// <param name="pBufferStrides">_In_reads_opt_(NumStrides) <b>UINT* pBufferStrides</b></param>
	/// <param name="numStrides">_In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT ) <b>UINT NumStrides</b></param>
	/// <param name="rasterizedStream">_In_ <b>UINT RasterizedStream</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppGeometryShader">_COM_Outptr_opt_ <b>ID3D11GeometryShader** ppGeometryShader</b></param>
	int CreateGeometryShaderWithStreamOutput<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, SoDeclarationEntry* pSODeclaration, uint numEntries, uint* pBufferStrides, uint numStrides, uint rasterizedStream, T0* pClassLinkage, out T1* ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreatePixelShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppPixelShader">_COM_Outptr_opt_ <b>ID3D11PixelShader** ppPixelShader</b></param>
	int CreatePixelShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppPixelShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IPixelShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreatePixelShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppPixelShader">_COM_Outptr_opt_ <b>ID3D11PixelShader** ppPixelShader</b></param>
	int CreatePixelShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppPixelShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IPixelShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateHullShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11HullShader** ppHullShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppHullShader">_COM_Outptr_opt_ <b>ID3D11HullShader** ppHullShader</b></param>
	int CreateHullShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppHullShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IHullShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateHullShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11HullShader** ppHullShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppHullShader">_COM_Outptr_opt_ <b>ID3D11HullShader** ppHullShader</b></param>
	int CreateHullShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppHullShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IHullShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDomainShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11DomainShader** ppDomainShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppDomainShader">_COM_Outptr_opt_ <b>ID3D11DomainShader** ppDomainShader</b></param>
	int CreateDomainShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppDomainShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IDomainShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDomainShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11DomainShader** ppDomainShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppDomainShader">_COM_Outptr_opt_ <b>ID3D11DomainShader** ppDomainShader</b></param>
	int CreateDomainShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppDomainShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IDomainShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateComputeShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppComputeShader">_COM_Outptr_opt_ <b>ID3D11ComputeShader** ppComputeShader</b></param>
	int CreateComputeShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppComputeShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IComputeShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateComputeShader (void* pShaderBytecode, SIZE_T BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)</b><br/>
	/// </summary>
	/// <param name="pShaderBytecode">_In_reads_(BytecodeLength) <b>void* pShaderBytecode</b></param>
	/// <param name="bytecodeLength">_In_ <b>SIZE_T BytecodeLength</b></param>
	/// <param name="pClassLinkage">_In_opt_ <b>ID3D11ClassLinkage* pClassLinkage</b></param>
	/// <param name="ppComputeShader">_COM_Outptr_opt_ <b>ID3D11ComputeShader** ppComputeShader</b></param>
	int CreateComputeShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppComputeShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IComputeShader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateClassLinkage (ID3D11ClassLinkage** ppLinkage)</b><br/>
	/// </summary>
	/// <param name="ppLinkage">_COM_Outptr_ <b>ID3D11ClassLinkage** ppLinkage</b></param>
	int CreateClassLinkage<T0> (T0** ppLinkage) where T0 : unmanaged, IClassLinkage;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateClassLinkage (ID3D11ClassLinkage** ppLinkage)</b><br/>
	/// </summary>
	/// <param name="ppLinkage">_COM_Outptr_ <b>ID3D11ClassLinkage** ppLinkage</b></param>
	int CreateClassLinkage<T0> (out T0* ppLinkage) where T0 : unmanaged, IClassLinkage;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateBlendState (D3D11_BLEND_DESC* pBlendStateDesc, ID3D11BlendState** ppBlendState)</b><br/>
	/// </summary>
	/// <param name="pBlendStateDesc">_In_ <b>D3D11_BLEND_DESC* pBlendStateDesc</b></param>
	/// <param name="ppBlendState">_COM_Outptr_opt_ <b>ID3D11BlendState** ppBlendState</b></param>
	int CreateBlendState<T0> (BlendDesc* pBlendStateDesc, T0** ppBlendState) where T0 : unmanaged, IBlendState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateBlendState (D3D11_BLEND_DESC* pBlendStateDesc, ID3D11BlendState** ppBlendState)</b><br/>
	/// </summary>
	/// <param name="pBlendStateDesc">_In_ <b>D3D11_BLEND_DESC* pBlendStateDesc</b></param>
	/// <param name="ppBlendState">_COM_Outptr_opt_ <b>ID3D11BlendState** ppBlendState</b></param>
	int CreateBlendState<T0> (BlendDesc* pBlendStateDesc, out T0* ppBlendState) where T0 : unmanaged, IBlendState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDepthStencilState (D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, ID3D11DepthStencilState** ppDepthStencilState)</b><br/>
	/// </summary>
	/// <param name="pDepthStencilDesc">_In_ <b>D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc</b></param>
	/// <param name="ppDepthStencilState">_COM_Outptr_opt_ <b>ID3D11DepthStencilState** ppDepthStencilState</b></param>
	int CreateDepthStencilState<T0> (DepthStencilDesc* pDepthStencilDesc, T0** ppDepthStencilState) where T0 : unmanaged, IDepthStencilState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDepthStencilState (D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, ID3D11DepthStencilState** ppDepthStencilState)</b><br/>
	/// </summary>
	/// <param name="pDepthStencilDesc">_In_ <b>D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc</b></param>
	/// <param name="ppDepthStencilState">_COM_Outptr_opt_ <b>ID3D11DepthStencilState** ppDepthStencilState</b></param>
	int CreateDepthStencilState<T0> (DepthStencilDesc* pDepthStencilDesc, out T0* ppDepthStencilState) where T0 : unmanaged, IDepthStencilState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateRasterizerState (D3D11_RASTERIZER_DESC* pRasterizerDesc, ID3D11RasterizerState** ppRasterizerState)</b><br/>
	/// </summary>
	/// <param name="pRasterizerDesc">_In_ <b>D3D11_RASTERIZER_DESC* pRasterizerDesc</b></param>
	/// <param name="ppRasterizerState">_COM_Outptr_opt_ <b>ID3D11RasterizerState** ppRasterizerState</b></param>
	int CreateRasterizerState<T0> (RasterizerDesc* pRasterizerDesc, T0** ppRasterizerState) where T0 : unmanaged, IRasterizerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateRasterizerState (D3D11_RASTERIZER_DESC* pRasterizerDesc, ID3D11RasterizerState** ppRasterizerState)</b><br/>
	/// </summary>
	/// <param name="pRasterizerDesc">_In_ <b>D3D11_RASTERIZER_DESC* pRasterizerDesc</b></param>
	/// <param name="ppRasterizerState">_COM_Outptr_opt_ <b>ID3D11RasterizerState** ppRasterizerState</b></param>
	int CreateRasterizerState<T0> (RasterizerDesc* pRasterizerDesc, out T0* ppRasterizerState) where T0 : unmanaged, IRasterizerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateSamplerState (D3D11_SAMPLER_DESC* pSamplerDesc, ID3D11SamplerState** ppSamplerState)</b><br/>
	/// </summary>
	/// <param name="pSamplerDesc">_In_ <b>D3D11_SAMPLER_DESC* pSamplerDesc</b></param>
	/// <param name="ppSamplerState">_COM_Outptr_opt_ <b>ID3D11SamplerState** ppSamplerState</b></param>
	int CreateSamplerState<T0> (SamplerDesc* pSamplerDesc, T0** ppSamplerState) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateSamplerState (D3D11_SAMPLER_DESC* pSamplerDesc, ID3D11SamplerState** ppSamplerState)</b><br/>
	/// </summary>
	/// <param name="pSamplerDesc">_In_ <b>D3D11_SAMPLER_DESC* pSamplerDesc</b></param>
	/// <param name="ppSamplerState">_COM_Outptr_opt_ <b>ID3D11SamplerState** ppSamplerState</b></param>
	int CreateSamplerState<T0> (SamplerDesc* pSamplerDesc, out T0* ppSamplerState) where T0 : unmanaged, ISamplerState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateQuery (D3D11_QUERY_DESC* pQueryDesc, ID3D11Query** ppQuery)</b><br/>
	/// </summary>
	/// <param name="pQueryDesc">_In_ <b>D3D11_QUERY_DESC* pQueryDesc</b></param>
	/// <param name="ppQuery">_COM_Outptr_opt_ <b>ID3D11Query** ppQuery</b></param>
	int CreateQuery<T0> (QueryDesc* pQueryDesc, T0** ppQuery) where T0 : unmanaged, IQuery;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateQuery (D3D11_QUERY_DESC* pQueryDesc, ID3D11Query** ppQuery)</b><br/>
	/// </summary>
	/// <param name="pQueryDesc">_In_ <b>D3D11_QUERY_DESC* pQueryDesc</b></param>
	/// <param name="ppQuery">_COM_Outptr_opt_ <b>ID3D11Query** ppQuery</b></param>
	int CreateQuery<T0> (QueryDesc* pQueryDesc, out T0* ppQuery) where T0 : unmanaged, IQuery;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreatePredicate (D3D11_QUERY_DESC* pPredicateDesc, ID3D11Predicate** ppPredicate)</b><br/>
	/// </summary>
	/// <param name="pPredicateDesc">_In_ <b>D3D11_QUERY_DESC* pPredicateDesc</b></param>
	/// <param name="ppPredicate">_COM_Outptr_opt_ <b>ID3D11Predicate** ppPredicate</b></param>
	int CreatePredicate<T0> (QueryDesc* pPredicateDesc, T0** ppPredicate) where T0 : unmanaged, IPredicate;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreatePredicate (D3D11_QUERY_DESC* pPredicateDesc, ID3D11Predicate** ppPredicate)</b><br/>
	/// </summary>
	/// <param name="pPredicateDesc">_In_ <b>D3D11_QUERY_DESC* pPredicateDesc</b></param>
	/// <param name="ppPredicate">_COM_Outptr_opt_ <b>ID3D11Predicate** ppPredicate</b></param>
	int CreatePredicate<T0> (QueryDesc* pPredicateDesc, out T0* ppPredicate) where T0 : unmanaged, IPredicate;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateCounter (D3D11_COUNTER_DESC* pCounterDesc, ID3D11Counter** ppCounter)</b><br/>
	/// </summary>
	/// <param name="pCounterDesc">_In_ <b>D3D11_COUNTER_DESC* pCounterDesc</b></param>
	/// <param name="ppCounter">_COM_Outptr_opt_ <b>ID3D11Counter** ppCounter</b></param>
	int CreateCounter<T0> (CounterDesc* pCounterDesc, T0** ppCounter) where T0 : unmanaged, ICounter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateCounter (D3D11_COUNTER_DESC* pCounterDesc, ID3D11Counter** ppCounter)</b><br/>
	/// </summary>
	/// <param name="pCounterDesc">_In_ <b>D3D11_COUNTER_DESC* pCounterDesc</b></param>
	/// <param name="ppCounter">_COM_Outptr_opt_ <b>ID3D11Counter** ppCounter</b></param>
	int CreateCounter<T0> (CounterDesc* pCounterDesc, out T0* ppCounter) where T0 : unmanaged, ICounter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDeferredContext (UINT ContextFlags, ID3D11DeviceContext** ppDeferredContext)</b><br/>
	/// </summary>
	/// <param name="contextFlags"><b>UINT ContextFlags</b></param>
	/// <param name="ppDeferredContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext** ppDeferredContext</b></param>
	int CreateDeferredContext<T0> (uint contextFlags, T0** ppDeferredContext) where T0 : unmanaged, IDeviceContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CreateDeferredContext (UINT ContextFlags, ID3D11DeviceContext** ppDeferredContext)</b><br/>
	/// </summary>
	/// <param name="contextFlags"><b>UINT ContextFlags</b></param>
	/// <param name="ppDeferredContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext** ppDeferredContext</b></param>
	int CreateDeferredContext<T0> (uint contextFlags, out T0* ppDeferredContext) where T0 : unmanaged, IDeviceContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::OpenSharedResource (HANDLE hResource, REFIID ReturnedInterface, void** ppResource)</b><br/>
	/// </summary>
	/// <param name="hResource">_In_ <b>HANDLE hResource</b></param>
	/// <param name="returnedInterface">_In_ <b>REFIID ReturnedInterface</b></param>
	/// <param name="ppResource">_COM_Outptr_opt_ <b>void** ppResource</b></param>
	int OpenSharedResource (IntPtr hResource, Guid returnedInterface, void** ppResource);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::OpenSharedResource (HANDLE hResource, REFIID ReturnedInterface, void** ppResource)</b><br/>
	/// </summary>
	/// <param name="hResource">_In_ <b>HANDLE hResource</b></param>
	/// <param name="returnedInterface">_In_ <b>REFIID ReturnedInterface</b></param>
	/// <param name="ppResource">_COM_Outptr_opt_ <b>void** ppResource</b></param>
	int OpenSharedResource (IntPtr hResource, Guid returnedInterface, out void* ppResource);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CheckFormatSupport (DXGI_FORMAT Format, UINT* pFormatSupport)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="pFormatSupport">_Out_ <b>UINT* pFormatSupport</b></param>
	int CheckFormatSupport (DXGI.Format format, uint* pFormatSupport);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CheckFormatSupport (DXGI_FORMAT Format, UINT* pFormatSupport)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="pFormatSupport">_Out_ <b>UINT* pFormatSupport</b></param>
	int CheckFormatSupport (DXGI.Format format, out uint pFormatSupport);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CheckMultisampleQualityLevels (DXGI_FORMAT Format, UINT SampleCount, UINT* pNumQualityLevels)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="sampleCount">_In_ <b>UINT SampleCount</b></param>
	/// <param name="pNumQualityLevels">_Out_ <b>UINT* pNumQualityLevels</b></param>
	int CheckMultisampleQualityLevels (DXGI.Format format, uint sampleCount, uint* pNumQualityLevels);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CheckMultisampleQualityLevels (DXGI_FORMAT Format, UINT SampleCount, UINT* pNumQualityLevels)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="sampleCount">_In_ <b>UINT SampleCount</b></param>
	/// <param name="pNumQualityLevels">_Out_ <b>UINT* pNumQualityLevels</b></param>
	int CheckMultisampleQualityLevels (DXGI.Format format, uint sampleCount, out uint pNumQualityLevels);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device::CheckCounterInfo (D3D11_COUNTER_INFO* pCounterInfo)</b><br/>
	/// </summary>
	/// <param name="pCounterInfo">_Out_ <b>D3D11_COUNTER_INFO* pCounterInfo</b></param>
	void CheckCounterInfo (CounterInfo* pCounterInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device::CheckCounterInfo (D3D11_COUNTER_INFO* pCounterInfo)</b><br/>
	/// </summary>
	/// <param name="pCounterInfo">_Out_ <b>D3D11_COUNTER_INFO* pCounterInfo</b></param>
	void CheckCounterInfo (out CounterInfo pCounterInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CheckCounter (D3D11_COUNTER_DESC* pDesc, D3D11_COUNTER_TYPE* pType, UINT* pActiveCounters, LPSTR szName, UINT* pNameLength, LPSTR szUnits, UINT* pUnitsLength, LPSTR szDescription, UINT* pDescriptionLength)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_COUNTER_DESC* pDesc</b></param>
	/// <param name="pType">_Out_ <b>D3D11_COUNTER_TYPE* pType</b></param>
	/// <param name="pActiveCounters">_Out_ <b>UINT* pActiveCounters</b></param>
	/// <param name="szName">_Out_writes_opt_(*pNameLength) <b>LPSTR szName</b></param>
	/// <param name="pNameLength">_Inout_opt_ <b>UINT* pNameLength</b></param>
	/// <param name="szUnits">_Out_writes_opt_(*pUnitsLength) <b>LPSTR szUnits</b></param>
	/// <param name="pUnitsLength">_Inout_opt_ <b>UINT* pUnitsLength</b></param>
	/// <param name="szDescription">_Out_writes_opt_(*pDescriptionLength) <b>LPSTR szDescription</b></param>
	/// <param name="pDescriptionLength">_Inout_opt_ <b>UINT* pDescriptionLength</b></param>
	int CheckCounter (CounterDesc* pDesc, CounterType* pType, uint* pActiveCounters, char* szName, uint* pNameLength, char* szUnits, uint* pUnitsLength, char* szDescription, uint* pDescriptionLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CheckCounter (D3D11_COUNTER_DESC* pDesc, D3D11_COUNTER_TYPE* pType, UINT* pActiveCounters, LPSTR szName, UINT* pNameLength, LPSTR szUnits, UINT* pUnitsLength, LPSTR szDescription, UINT* pDescriptionLength)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>D3D11_COUNTER_DESC* pDesc</b></param>
	/// <param name="pType">_Out_ <b>D3D11_COUNTER_TYPE* pType</b></param>
	/// <param name="pActiveCounters">_Out_ <b>UINT* pActiveCounters</b></param>
	/// <param name="szName">_Out_writes_opt_(*pNameLength) <b>LPSTR szName</b></param>
	/// <param name="pNameLength">_Inout_opt_ <b>UINT* pNameLength</b></param>
	/// <param name="szUnits">_Out_writes_opt_(*pUnitsLength) <b>LPSTR szUnits</b></param>
	/// <param name="pUnitsLength">_Inout_opt_ <b>UINT* pUnitsLength</b></param>
	/// <param name="szDescription">_Out_writes_opt_(*pDescriptionLength) <b>LPSTR szDescription</b></param>
	/// <param name="pDescriptionLength">_Inout_opt_ <b>UINT* pDescriptionLength</b></param>
	int CheckCounter (CounterDesc* pDesc, out CounterType pType, out uint pActiveCounters, char* szName, uint* pNameLength, char* szUnits, uint* pUnitsLength, char* szDescription, uint* pDescriptionLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::CheckFeatureSupport (D3D11_FEATURE Feature, void* pFeatureSupportData, UINT FeatureSupportDataSize)</b><br/>
	/// </summary>
	/// <param name="feature"><b>D3D11_FEATURE Feature</b></param>
	/// <param name="pFeatureSupportData">_Out_writes_bytes_(FeatureSupportDataSize) <b>void* pFeatureSupportData</b></param>
	/// <param name="featureSupportDataSize"><b>UINT FeatureSupportDataSize</b></param>
	int CheckFeatureSupport (Feature feature, void* pFeatureSupportData, uint featureSupportDataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::GetPrivateData (REFGUID guid, UINT* pDataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="pDataSize">_Inout_ <b>UINT* pDataSize</b></param>
	/// <param name="pData">_Out_writes_bytes_opt_(*pDataSize) <b>void* pData</b></param>
	int GetPrivateData (Guid guid, uint* pDataSize, void* pData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::SetPrivateData (REFGUID guid, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_In_reads_bytes_opt_(DataSize) <b>void* pData</b></param>
	int SetPrivateData (Guid guid, uint dataSize, void* pData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::SetPrivateDataInterface (REFGUID guid, IUnknown* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="pData">_In_opt_ <b>IUnknown* pData</b></param>
	int SetPrivateDataInterface<T0> (Guid guid, T0* pData) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D_FEATURE_LEVEL ID3D11Device::GetFeatureLevel ()</b><br/>
	/// </summary>
	Direct3D.FeatureLevel GetFeatureLevel ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D11Device::GetCreationFlags ()</b><br/>
	/// </summary>
	uint GetCreationFlags ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::GetDeviceRemovedReason ()</b><br/>
	/// </summary>
	int GetDeviceRemovedReason ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device::GetImmediateContext (ID3D11DeviceContext** ppImmediateContext)</b><br/>
	/// </summary>
	/// <param name="ppImmediateContext">_Outptr_ <b>ID3D11DeviceContext** ppImmediateContext</b></param>
	void GetImmediateContext<T0> (T0** ppImmediateContext) where T0 : unmanaged, IDeviceContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device::GetImmediateContext (ID3D11DeviceContext** ppImmediateContext)</b><br/>
	/// </summary>
	/// <param name="ppImmediateContext">_Outptr_ <b>ID3D11DeviceContext** ppImmediateContext</b></param>
	void GetImmediateContext<T0> (out T0* ppImmediateContext) where T0 : unmanaged, IDeviceContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device::SetExceptionMode (UINT RaiseFlags)</b><br/>
	/// </summary>
	/// <param name="raiseFlags"><b>UINT RaiseFlags</b></param>
	int SetExceptionMode (uint raiseFlags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D11Device::GetExceptionMode ()</b><br/>
	/// </summary>
	uint GetExceptionMode ();
}

/// <summary>
/// Instance of <b>ID3D11Device</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct Device : IDevice {
//unsafe public readonly struct IDeviceObj : IDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device* GetCurrentPointer () => (Device*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDeviceObj* GetCurrentPointer () => (IDeviceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xdb6f6ddb, 0xac77, 0x4e88, 0x82, 0x53, 0x81, 0x9d, 0xf9, 0xbb, 0xf1, 0x40);

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
	public readonly int CreateBuffer<T0> (BufferDesc* pDesc, SubresourceData* pInitialData, T0** ppBuffer) where T0 : unmanaged, IBuffer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBuffer (ptr, pDesc, pInitialData, (void**) ppBuffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBuffer<T0> (BufferDesc* pDesc, SubresourceData* pInitialData, out T0* ppBuffer) where T0 : unmanaged, IBuffer {
		fixed (T0** _ppBuffer = &ppBuffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBuffer (ptr, pDesc, pInitialData, (void**) _ppBuffer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTexture1D<T0> (Texture1dDesc* pDesc, SubresourceData* pInitialData, T0** ppTexture1D) where T0 : unmanaged, ITexture1D {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTexture1D (ptr, pDesc, pInitialData, (void**) ppTexture1D);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTexture1D<T0> (Texture1dDesc* pDesc, SubresourceData* pInitialData, out T0* ppTexture1D) where T0 : unmanaged, ITexture1D {
		fixed (T0** _ppTexture1D = &ppTexture1D) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTexture1D (ptr, pDesc, pInitialData, (void**) _ppTexture1D);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTexture2D<T0> (Texture2dDesc* pDesc, SubresourceData* pInitialData, T0** ppTexture2D) where T0 : unmanaged, ITexture2D {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTexture2D (ptr, pDesc, pInitialData, (void**) ppTexture2D);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTexture2D<T0> (Texture2dDesc* pDesc, SubresourceData* pInitialData, out T0* ppTexture2D) where T0 : unmanaged, ITexture2D {
		fixed (T0** _ppTexture2D = &ppTexture2D) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTexture2D (ptr, pDesc, pInitialData, (void**) _ppTexture2D);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTexture3D<T0> (Texture3dDesc* pDesc, SubresourceData* pInitialData, T0** ppTexture3D) where T0 : unmanaged, ITexture3D {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTexture3D (ptr, pDesc, pInitialData, (void**) ppTexture3D);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTexture3D<T0> (Texture3dDesc* pDesc, SubresourceData* pInitialData, out T0* ppTexture3D) where T0 : unmanaged, ITexture3D {
		fixed (T0** _ppTexture3D = &ppTexture3D) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTexture3D (ptr, pDesc, pInitialData, (void**) _ppTexture3D);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateShaderResourceView<T0, T1> (T0* pResource, ShaderResourceViewDesc* pDesc, T1** ppSRView) where T0 : unmanaged, IResource where T1 : unmanaged, IShaderResourceView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateShaderResourceView (ptr, pResource, pDesc, (void**) ppSRView);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateShaderResourceView<T0, T1> (T0* pResource, ShaderResourceViewDesc* pDesc, out T1* ppSRView) where T0 : unmanaged, IResource where T1 : unmanaged, IShaderResourceView {
		fixed (T1** _ppSRView = &ppSRView) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateShaderResourceView (ptr, pResource, pDesc, (void**) _ppSRView);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateUnorderedAccessView<T0, T1> (T0* pResource, UnorderedAccessViewDesc* pDesc, T1** ppUAView) where T0 : unmanaged, IResource where T1 : unmanaged, IUnorderedAccessView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateUnorderedAccessView (ptr, pResource, pDesc, (void**) ppUAView);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateUnorderedAccessView<T0, T1> (T0* pResource, UnorderedAccessViewDesc* pDesc, out T1* ppUAView) where T0 : unmanaged, IResource where T1 : unmanaged, IUnorderedAccessView {
		fixed (T1** _ppUAView = &ppUAView) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateUnorderedAccessView (ptr, pResource, pDesc, (void**) _ppUAView);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRenderTargetView<T0, T1> (T0* pResource, RenderTargetViewDesc* pDesc, T1** ppRTView) where T0 : unmanaged, IResource where T1 : unmanaged, IRenderTargetView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRenderTargetView (ptr, pResource, pDesc, (void**) ppRTView);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRenderTargetView<T0, T1> (T0* pResource, RenderTargetViewDesc* pDesc, out T1* ppRTView) where T0 : unmanaged, IResource where T1 : unmanaged, IRenderTargetView {
		fixed (T1** _ppRTView = &ppRTView) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRenderTargetView (ptr, pResource, pDesc, (void**) _ppRTView);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDepthStencilView<T0, T1> (T0* pResource, DepthStencilViewDesc* pDesc, T1** ppDepthStencilView) where T0 : unmanaged, IResource where T1 : unmanaged, IDepthStencilView {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDepthStencilView (ptr, pResource, pDesc, (void**) ppDepthStencilView);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDepthStencilView<T0, T1> (T0* pResource, DepthStencilViewDesc* pDesc, out T1* ppDepthStencilView) where T0 : unmanaged, IResource where T1 : unmanaged, IDepthStencilView {
		fixed (T1** _ppDepthStencilView = &ppDepthStencilView) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDepthStencilView (ptr, pResource, pDesc, (void**) _ppDepthStencilView);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateInputLayout<T0> (InputElementDesc* pInputElementDescs, uint numElements, void* pShaderBytecodeWithInputSignature, nuint bytecodeLength, T0** ppInputLayout) where T0 : unmanaged, IInputLayout {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateInputLayout (ptr, pInputElementDescs, numElements, pShaderBytecodeWithInputSignature, bytecodeLength, (void**) ppInputLayout);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateInputLayout<T0> (InputElementDesc* pInputElementDescs, uint numElements, void* pShaderBytecodeWithInputSignature, nuint bytecodeLength, out T0* ppInputLayout) where T0 : unmanaged, IInputLayout {
		fixed (T0** _ppInputLayout = &ppInputLayout) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateInputLayout (ptr, pInputElementDescs, numElements, pShaderBytecodeWithInputSignature, bytecodeLength, (void**) _ppInputLayout);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVertexShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppVertexShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IVertexShader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateVertexShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) ppVertexShader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateVertexShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppVertexShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IVertexShader {
		fixed (T1** _ppVertexShader = &ppVertexShader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateVertexShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) _ppVertexShader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGeometryShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGeometryShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) ppGeometryShader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGeometryShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader {
		fixed (T1** _ppGeometryShader = &ppGeometryShader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGeometryShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) _ppGeometryShader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGeometryShaderWithStreamOutput<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, SoDeclarationEntry* pSODeclaration, uint numEntries, uint* pBufferStrides, uint numStrides, uint rasterizedStream, T0* pClassLinkage, T1** ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGeometryShaderWithStreamOutput (ptr, pShaderBytecode, bytecodeLength, pSODeclaration, numEntries, pBufferStrides, numStrides, rasterizedStream, pClassLinkage, (void**) ppGeometryShader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGeometryShaderWithStreamOutput<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, SoDeclarationEntry* pSODeclaration, uint numEntries, uint* pBufferStrides, uint numStrides, uint rasterizedStream, T0* pClassLinkage, out T1* ppGeometryShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IGeometryShader {
		fixed (T1** _ppGeometryShader = &ppGeometryShader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGeometryShaderWithStreamOutput (ptr, pShaderBytecode, bytecodeLength, pSODeclaration, numEntries, pBufferStrides, numStrides, rasterizedStream, pClassLinkage, (void**) _ppGeometryShader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePixelShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppPixelShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IPixelShader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePixelShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) ppPixelShader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePixelShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppPixelShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IPixelShader {
		fixed (T1** _ppPixelShader = &ppPixelShader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePixelShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) _ppPixelShader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHullShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppHullShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IHullShader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateHullShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) ppHullShader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHullShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppHullShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IHullShader {
		fixed (T1** _ppHullShader = &ppHullShader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateHullShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) _ppHullShader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDomainShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppDomainShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IDomainShader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDomainShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) ppDomainShader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDomainShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppDomainShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IDomainShader {
		fixed (T1** _ppDomainShader = &ppDomainShader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDomainShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) _ppDomainShader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComputeShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, T1** ppComputeShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IComputeShader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateComputeShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) ppComputeShader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateComputeShader<T0, T1> (void* pShaderBytecode, nuint bytecodeLength, T0* pClassLinkage, out T1* ppComputeShader) where T0 : unmanaged, IClassLinkage where T1 : unmanaged, IComputeShader {
		fixed (T1** _ppComputeShader = &ppComputeShader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateComputeShader (ptr, pShaderBytecode, bytecodeLength, pClassLinkage, (void**) _ppComputeShader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateClassLinkage<T0> (T0** ppLinkage) where T0 : unmanaged, IClassLinkage {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateClassLinkage (ptr, (void**) ppLinkage);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateClassLinkage<T0> (out T0* ppLinkage) where T0 : unmanaged, IClassLinkage {
		fixed (T0** _ppLinkage = &ppLinkage) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateClassLinkage (ptr, (void**) _ppLinkage);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBlendState<T0> (BlendDesc* pBlendStateDesc, T0** ppBlendState) where T0 : unmanaged, IBlendState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBlendState (ptr, pBlendStateDesc, (void**) ppBlendState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBlendState<T0> (BlendDesc* pBlendStateDesc, out T0* ppBlendState) where T0 : unmanaged, IBlendState {
		fixed (T0** _ppBlendState = &ppBlendState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBlendState (ptr, pBlendStateDesc, (void**) _ppBlendState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDepthStencilState<T0> (DepthStencilDesc* pDepthStencilDesc, T0** ppDepthStencilState) where T0 : unmanaged, IDepthStencilState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDepthStencilState (ptr, pDepthStencilDesc, (void**) ppDepthStencilState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDepthStencilState<T0> (DepthStencilDesc* pDepthStencilDesc, out T0* ppDepthStencilState) where T0 : unmanaged, IDepthStencilState {
		fixed (T0** _ppDepthStencilState = &ppDepthStencilState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDepthStencilState (ptr, pDepthStencilDesc, (void**) _ppDepthStencilState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRasterizerState<T0> (RasterizerDesc* pRasterizerDesc, T0** ppRasterizerState) where T0 : unmanaged, IRasterizerState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRasterizerState (ptr, pRasterizerDesc, (void**) ppRasterizerState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRasterizerState<T0> (RasterizerDesc* pRasterizerDesc, out T0* ppRasterizerState) where T0 : unmanaged, IRasterizerState {
		fixed (T0** _ppRasterizerState = &ppRasterizerState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRasterizerState (ptr, pRasterizerDesc, (void**) _ppRasterizerState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSamplerState<T0> (SamplerDesc* pSamplerDesc, T0** ppSamplerState) where T0 : unmanaged, ISamplerState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSamplerState (ptr, pSamplerDesc, (void**) ppSamplerState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSamplerState<T0> (SamplerDesc* pSamplerDesc, out T0* ppSamplerState) where T0 : unmanaged, ISamplerState {
		fixed (T0** _ppSamplerState = &ppSamplerState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSamplerState (ptr, pSamplerDesc, (void**) _ppSamplerState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQuery<T0> (QueryDesc* pQueryDesc, T0** ppQuery) where T0 : unmanaged, IQuery {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateQuery (ptr, pQueryDesc, (void**) ppQuery);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateQuery<T0> (QueryDesc* pQueryDesc, out T0* ppQuery) where T0 : unmanaged, IQuery {
		fixed (T0** _ppQuery = &ppQuery) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateQuery (ptr, pQueryDesc, (void**) _ppQuery);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePredicate<T0> (QueryDesc* pPredicateDesc, T0** ppPredicate) where T0 : unmanaged, IPredicate {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePredicate (ptr, pPredicateDesc, (void**) ppPredicate);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePredicate<T0> (QueryDesc* pPredicateDesc, out T0* ppPredicate) where T0 : unmanaged, IPredicate {
		fixed (T0** _ppPredicate = &ppPredicate) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePredicate (ptr, pPredicateDesc, (void**) _ppPredicate);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCounter<T0> (CounterDesc* pCounterDesc, T0** ppCounter) where T0 : unmanaged, ICounter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCounter (ptr, pCounterDesc, (void**) ppCounter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCounter<T0> (CounterDesc* pCounterDesc, out T0* ppCounter) where T0 : unmanaged, ICounter {
		fixed (T0** _ppCounter = &ppCounter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCounter (ptr, pCounterDesc, (void**) _ppCounter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeferredContext<T0> (uint contextFlags, T0** ppDeferredContext) where T0 : unmanaged, IDeviceContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeferredContext (ptr, contextFlags, (void**) ppDeferredContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeferredContext<T0> (uint contextFlags, out T0* ppDeferredContext) where T0 : unmanaged, IDeviceContext {
		fixed (T0** _ppDeferredContext = &ppDeferredContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeferredContext (ptr, contextFlags, (void**) _ppDeferredContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedResource (IntPtr hResource, Guid returnedInterface, void** ppResource) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedResource (ptr, hResource, returnedInterface, ppResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedResource (IntPtr hResource, Guid returnedInterface, out void* ppResource) {
		fixed (void** _ppResource = &ppResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedResource (ptr, hResource, returnedInterface, _ppResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckFormatSupport (DXGI.Format format, uint* pFormatSupport) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckFormatSupport (ptr, format, pFormatSupport);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckFormatSupport (DXGI.Format format, out uint pFormatSupport) {
		fixed (uint* _pFormatSupport = &pFormatSupport) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CheckFormatSupport (ptr, format, _pFormatSupport);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckMultisampleQualityLevels (DXGI.Format format, uint sampleCount, uint* pNumQualityLevels) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckMultisampleQualityLevels (ptr, format, sampleCount, pNumQualityLevels);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckMultisampleQualityLevels (DXGI.Format format, uint sampleCount, out uint pNumQualityLevels) {
		fixed (uint* _pNumQualityLevels = &pNumQualityLevels) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CheckMultisampleQualityLevels (ptr, format, sampleCount, _pNumQualityLevels);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CheckCounterInfo (CounterInfo* pCounterInfo) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->CheckCounterInfo (ptr, pCounterInfo);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void CheckCounterInfo (out CounterInfo pCounterInfo) {
		fixed (CounterInfo* _pCounterInfo = &pCounterInfo) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->CheckCounterInfo (ptr, _pCounterInfo);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckCounter (CounterDesc* pDesc, CounterType* pType, uint* pActiveCounters, char* szName, uint* pNameLength, char* szUnits, uint* pUnitsLength, char* szDescription, uint* pDescriptionLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckCounter (ptr, pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckCounter (CounterDesc* pDesc, out CounterType pType, out uint pActiveCounters, char* szName, uint* pNameLength, char* szUnits, uint* pUnitsLength, char* szDescription, uint* pDescriptionLength) {
		fixed (CounterType* _pType = &pType) {
			fixed (uint* _pActiveCounters = &pActiveCounters) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->CheckCounter (ptr, pDesc, _pType, _pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
				return hr;
			}
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
	public readonly Direct3D.FeatureLevel GetFeatureLevel () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFeatureLevel (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetCreationFlags () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCreationFlags (ptr);
		return hr;
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
	public readonly void GetImmediateContext<T0> (T0** ppImmediateContext) where T0 : unmanaged, IDeviceContext {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetImmediateContext (ptr, (void**) ppImmediateContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetImmediateContext<T0> (out T0* ppImmediateContext) where T0 : unmanaged, IDeviceContext {
		fixed (T0** _ppImmediateContext = &ppImmediateContext) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetImmediateContext (ptr, (void**) _ppImmediateContext);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetExceptionMode (uint raiseFlags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetExceptionMode (ptr, raiseFlags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetExceptionMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExceptionMode (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, BufferDesc*, SubresourceData*, void**, int> CreateBuffer;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Texture1dDesc*, SubresourceData*, void**, int> CreateTexture1D;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Texture2dDesc*, SubresourceData*, void**, int> CreateTexture2D;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Texture3dDesc*, SubresourceData*, void**, int> CreateTexture3D;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ShaderResourceViewDesc*, void**, int> CreateShaderResourceView;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, UnorderedAccessViewDesc*, void**, int> CreateUnorderedAccessView;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, RenderTargetViewDesc*, void**, int> CreateRenderTargetView;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, DepthStencilViewDesc*, void**, int> CreateDepthStencilView;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InputElementDesc*, uint, void*, nuint, void**, int> CreateInputLayout;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, void*, void**, int> CreateVertexShader;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, void*, void**, int> CreateGeometryShader;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, SoDeclarationEntry*, uint, uint*, uint, uint, void*, void**, int> CreateGeometryShaderWithStreamOutput;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, void*, void**, int> CreatePixelShader;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, void*, void**, int> CreateHullShader;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, void*, void**, int> CreateDomainShader;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, void*, void**, int> CreateComputeShader;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateClassLinkage;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BlendDesc*, void**, int> CreateBlendState;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DepthStencilDesc*, void**, int> CreateDepthStencilState;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RasterizerDesc*, void**, int> CreateRasterizerState;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SamplerDesc*, void**, int> CreateSamplerState;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, QueryDesc*, void**, int> CreateQuery;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, QueryDesc*, void**, int> CreatePredicate;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CounterDesc*, void**, int> CreateCounter;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> CreateDeferredContext;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, Guid, void**, int> OpenSharedResource;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DXGI.Format, uint*, int> CheckFormatSupport;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DXGI.Format, uint, uint*, int> CheckMultisampleQualityLevels;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CounterInfo*, void> CheckCounterInfo;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CounterDesc*, CounterType*, uint*, char*, uint*, char*, uint*, char*, uint*, int> CheckCounter;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Feature, void*, uint, int> CheckFeatureSupport;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Direct3D.FeatureLevel> GetFeatureLevel;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetCreationFlags;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> GetDeviceRemovedReason;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetImmediateContext;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetExceptionMode;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetExceptionMode;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
