using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11Device2</b> : ID3D11Device1<br/>
/// D3D11_2.h
/// </summary>
unsafe public interface IDevice2 : IDevice1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device2::GetImmediateContext2 (ID3D11DeviceContext2** ppImmediateContext)</b><br/>
	/// </summary>
	/// <param name="ppImmediateContext">_Outptr_ <b>ID3D11DeviceContext2** ppImmediateContext</b></param>
	void GetImmediateContext2<T0> (T0** ppImmediateContext) where T0 : unmanaged, IDeviceContext2;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device2::GetImmediateContext2 (ID3D11DeviceContext2** ppImmediateContext)</b><br/>
	/// </summary>
	/// <param name="ppImmediateContext">_Outptr_ <b>ID3D11DeviceContext2** ppImmediateContext</b></param>
	void GetImmediateContext2<T0> (out T0* ppImmediateContext) where T0 : unmanaged, IDeviceContext2;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device2::CreateDeferredContext2 (UINT ContextFlags, ID3D11DeviceContext2** ppDeferredContext)</b><br/>
	/// </summary>
	/// <param name="contextFlags"><b>UINT ContextFlags</b></param>
	/// <param name="ppDeferredContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext2** ppDeferredContext</b></param>
	int CreateDeferredContext2<T0> (uint contextFlags, T0** ppDeferredContext) where T0 : unmanaged, IDeviceContext2;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device2::CreateDeferredContext2 (UINT ContextFlags, ID3D11DeviceContext2** ppDeferredContext)</b><br/>
	/// </summary>
	/// <param name="contextFlags"><b>UINT ContextFlags</b></param>
	/// <param name="ppDeferredContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext2** ppDeferredContext</b></param>
	int CreateDeferredContext2<T0> (uint contextFlags, out T0* ppDeferredContext) where T0 : unmanaged, IDeviceContext2;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device2::GetResourceTiling (ID3D11Resource* pTiledResource, UINT* pNumTilesForEntireResource, D3D11_PACKED_MIP_DESC* pPackedMipDesc, D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips, UINT* pNumSubresourceTilings, UINT FirstSubresourceTilingToGet, D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)</b><br/>
	/// </summary>
	/// <param name="pTiledResource">_In_ <b>ID3D11Resource* pTiledResource</b></param>
	/// <param name="pNumTilesForEntireResource">_Out_opt_ <b>UINT* pNumTilesForEntireResource</b></param>
	/// <param name="pPackedMipDesc">_Out_opt_ <b>D3D11_PACKED_MIP_DESC* pPackedMipDesc</b></param>
	/// <param name="pStandardTileShapeForNonPackedMips">_Out_opt_ <b>D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips</b></param>
	/// <param name="pNumSubresourceTilings">_Inout_opt_ <b>UINT* pNumSubresourceTilings</b></param>
	/// <param name="firstSubresourceTilingToGet">_In_ <b>UINT FirstSubresourceTilingToGet</b></param>
	/// <param name="pSubresourceTilingsForNonPackedMips">_Out_writes_(*pNumSubresourceTilings) <b>D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips</b></param>
	void GetResourceTiling<T0> (T0* pTiledResource, uint* pNumTilesForEntireResource, PackedMipDesc* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Device2::GetResourceTiling (ID3D11Resource* pTiledResource, UINT* pNumTilesForEntireResource, D3D11_PACKED_MIP_DESC* pPackedMipDesc, D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips, UINT* pNumSubresourceTilings, UINT FirstSubresourceTilingToGet, D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)</b><br/>
	/// </summary>
	/// <param name="pTiledResource">_In_ <b>ID3D11Resource* pTiledResource</b></param>
	/// <param name="pNumTilesForEntireResource">_Out_opt_ <b>UINT* pNumTilesForEntireResource</b></param>
	/// <param name="pPackedMipDesc">_Out_opt_ <b>D3D11_PACKED_MIP_DESC* pPackedMipDesc</b></param>
	/// <param name="pStandardTileShapeForNonPackedMips">_Out_opt_ <b>D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips</b></param>
	/// <param name="pNumSubresourceTilings">_Inout_opt_ <b>UINT* pNumSubresourceTilings</b></param>
	/// <param name="firstSubresourceTilingToGet">_In_ <b>UINT FirstSubresourceTilingToGet</b></param>
	/// <param name="pSubresourceTilingsForNonPackedMips">_Out_writes_(*pNumSubresourceTilings) <b>D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips</b></param>
	void GetResourceTiling<T0> (T0* pTiledResource, out uint pNumTilesForEntireResource, out PackedMipDesc pPackedMipDesc, out TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device2::CheckMultisampleQualityLevels1 (DXGI_FORMAT Format, UINT SampleCount, UINT Flags, UINT* pNumQualityLevels)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="sampleCount">_In_ <b>UINT SampleCount</b></param>
	/// <param name="flags">_In_ <b>UINT Flags</b></param>
	/// <param name="pNumQualityLevels">_Out_ <b>UINT* pNumQualityLevels</b></param>
	int CheckMultisampleQualityLevels1 (DXGI.Format format, uint sampleCount, uint flags, uint* pNumQualityLevels);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Device2::CheckMultisampleQualityLevels1 (DXGI_FORMAT Format, UINT SampleCount, UINT Flags, UINT* pNumQualityLevels)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="sampleCount">_In_ <b>UINT SampleCount</b></param>
	/// <param name="flags">_In_ <b>UINT Flags</b></param>
	/// <param name="pNumQualityLevels">_Out_ <b>UINT* pNumQualityLevels</b></param>
	int CheckMultisampleQualityLevels1 (DXGI.Format format, uint sampleCount, uint flags, out uint pNumQualityLevels);
}

/// <summary>
/// Instance of <b>ID3D11Device2</b><br/>
/// D3D11_2.h
/// </summary>
unsafe public readonly struct Device2 : IDevice2 {
//unsafe public readonly struct IDevice2Obj : IDevice2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device2* GetCurrentPointer () => (Device2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDevice2Obj* GetCurrentPointer () => (IDevice2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9d06dffa, 0xd1e5, 0x4d07, 0x83, 0xa8, 0x1b, 0xb1, 0x23, 0xf2, 0xf8, 0x41);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetImmediateContext1<T0> (T0** ppImmediateContext) where T0 : unmanaged, IDeviceContext1 {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetImmediateContext1 (ptr, (void**) ppImmediateContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetImmediateContext1<T0> (out T0* ppImmediateContext) where T0 : unmanaged, IDeviceContext1 {
		fixed (T0** _ppImmediateContext = &ppImmediateContext) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetImmediateContext1 (ptr, (void**) _ppImmediateContext);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeferredContext1<T0> (uint contextFlags, T0** ppDeferredContext) where T0 : unmanaged, IDeviceContext1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeferredContext1 (ptr, contextFlags, (void**) ppDeferredContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeferredContext1<T0> (uint contextFlags, out T0* ppDeferredContext) where T0 : unmanaged, IDeviceContext1 {
		fixed (T0** _ppDeferredContext = &ppDeferredContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeferredContext1 (ptr, contextFlags, (void**) _ppDeferredContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBlendState1<T0> (BlendDesc1* pBlendStateDesc, T0** ppBlendState) where T0 : unmanaged, IBlendState1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBlendState1 (ptr, pBlendStateDesc, (void**) ppBlendState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBlendState1<T0> (BlendDesc1* pBlendStateDesc, out T0* ppBlendState) where T0 : unmanaged, IBlendState1 {
		fixed (T0** _ppBlendState = &ppBlendState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBlendState1 (ptr, pBlendStateDesc, (void**) _ppBlendState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRasterizerState1<T0> (RasterizerDesc1* pRasterizerDesc, T0** ppRasterizerState) where T0 : unmanaged, IRasterizerState1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRasterizerState1 (ptr, pRasterizerDesc, (void**) ppRasterizerState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRasterizerState1<T0> (RasterizerDesc1* pRasterizerDesc, out T0* ppRasterizerState) where T0 : unmanaged, IRasterizerState1 {
		fixed (T0** _ppRasterizerState = &ppRasterizerState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRasterizerState1 (ptr, pRasterizerDesc, (void**) _ppRasterizerState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContextState<T0> (uint flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, Guid emulatedInterface, Direct3D.FeatureLevel* pChosenFeatureLevel, T0** ppContextState) where T0 : unmanaged, Direct3D.IDeviceContextState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContextState (ptr, flags, pFeatureLevels, featureLevels, sDKVersion, emulatedInterface, pChosenFeatureLevel, (void**) ppContextState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContextState<T0> (uint flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, Guid emulatedInterface, out Direct3D.FeatureLevel pChosenFeatureLevel, out T0* ppContextState) where T0 : unmanaged, Direct3D.IDeviceContextState {
		fixed (Direct3D.FeatureLevel* _pChosenFeatureLevel = &pChosenFeatureLevel) {
			fixed (T0** _ppContextState = &ppContextState) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContextState (ptr, flags, pFeatureLevels, featureLevels, sDKVersion, emulatedInterface, _pChosenFeatureLevel, (void**) _ppContextState);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedResource1 (IntPtr hResource, Guid returnedInterface, void** ppResource) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedResource1 (ptr, hResource, returnedInterface, ppResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedResource1 (IntPtr hResource, Guid returnedInterface, out void* ppResource) {
		fixed (void** _ppResource = &ppResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedResource1 (ptr, hResource, returnedInterface, _ppResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedResourceByName (char* lpName, uint dwDesiredAccess, Guid returnedInterface, void** ppResource) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedResourceByName (ptr, lpName, dwDesiredAccess, returnedInterface, ppResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OpenSharedResourceByName (char* lpName, uint dwDesiredAccess, Guid returnedInterface, out void* ppResource) {
		fixed (void** _ppResource = &ppResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->OpenSharedResourceByName (ptr, lpName, dwDesiredAccess, returnedInterface, _ppResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetImmediateContext2<T0> (T0** ppImmediateContext) where T0 : unmanaged, IDeviceContext2 {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetImmediateContext2 (ptr, (void**) ppImmediateContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetImmediateContext2<T0> (out T0* ppImmediateContext) where T0 : unmanaged, IDeviceContext2 {
		fixed (T0** _ppImmediateContext = &ppImmediateContext) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetImmediateContext2 (ptr, (void**) _ppImmediateContext);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeferredContext2<T0> (uint contextFlags, T0** ppDeferredContext) where T0 : unmanaged, IDeviceContext2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeferredContext2 (ptr, contextFlags, (void**) ppDeferredContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeferredContext2<T0> (uint contextFlags, out T0* ppDeferredContext) where T0 : unmanaged, IDeviceContext2 {
		fixed (T0** _ppDeferredContext = &ppDeferredContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeferredContext2 (ptr, contextFlags, (void**) _ppDeferredContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetResourceTiling<T0> (T0* pTiledResource, uint* pNumTilesForEntireResource, PackedMipDesc* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetResourceTiling (ptr, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, firstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetResourceTiling<T0> (T0* pTiledResource, out uint pNumTilesForEntireResource, out PackedMipDesc pPackedMipDesc, out TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint firstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where T0 : unmanaged, IResource {
		fixed (uint* _pNumTilesForEntireResource = &pNumTilesForEntireResource) {
			fixed (PackedMipDesc* _pPackedMipDesc = &pPackedMipDesc) {
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
	public readonly int CheckMultisampleQualityLevels1 (DXGI.Format format, uint sampleCount, uint flags, uint* pNumQualityLevels) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckMultisampleQualityLevels1 (ptr, format, sampleCount, flags, pNumQualityLevels);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckMultisampleQualityLevels1 (DXGI.Format format, uint sampleCount, uint flags, out uint pNumQualityLevels) {
		fixed (uint* _pNumQualityLevels = &pNumQualityLevels) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CheckMultisampleQualityLevels1 (ptr, format, sampleCount, flags, _pNumQualityLevels);
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
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetImmediateContext1;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> CreateDeferredContext1;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BlendDesc1*, void**, int> CreateBlendState1;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RasterizerDesc1*, void**, int> CreateRasterizerState1;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Direct3D.FeatureLevel*, uint, uint, Guid, Direct3D.FeatureLevel*, void**, int> CreateDeviceContextState;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, Guid, void**, int> OpenSharedResource1;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, Guid, void**, int> OpenSharedResourceByName;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetImmediateContext2;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> CreateDeferredContext2;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, PackedMipDesc*, TileShape*, uint*, uint, SubresourceTiling*, void> GetResourceTiling;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DXGI.Format, uint, uint, uint*, int> CheckMultisampleQualityLevels1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
