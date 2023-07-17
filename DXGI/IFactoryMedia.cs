using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIFactoryMedia</b> : IUnknown<br/>
/// DXGI1_3.h
/// </summary>
unsafe public interface IFactoryMedia : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactoryMedia::CreateSwapChainForCompositionSurfaceHandle (IUnknown* pDevice, HANDLE hSurface, DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="pDevice">_In_ <b>IUnknown* pDevice</b></param>
	/// <param name="hSurface">_In_opt_ <b>HANDLE hSurface</b></param>
	/// <param name="pDesc">_In_ <b>DXGI_SWAP_CHAIN_DESC1* pDesc</b></param>
	/// <param name="pRestrictToOutput">_In_opt_ <b>IDXGIOutput* pRestrictToOutput</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_ <b>IDXGISwapChain1** ppSwapChain</b></param>
	int CreateSwapChainForCompositionSurfaceHandle<T0, T1, T2> (T0* pDevice, IntPtr hSurface, SwapChainDesc1* pDesc, T1* pRestrictToOutput, T2** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactoryMedia::CreateSwapChainForCompositionSurfaceHandle (IUnknown* pDevice, HANDLE hSurface, DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="pDevice">_In_ <b>IUnknown* pDevice</b></param>
	/// <param name="hSurface">_In_opt_ <b>HANDLE hSurface</b></param>
	/// <param name="pDesc">_In_ <b>DXGI_SWAP_CHAIN_DESC1* pDesc</b></param>
	/// <param name="pRestrictToOutput">_In_opt_ <b>IDXGIOutput* pRestrictToOutput</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_ <b>IDXGISwapChain1** ppSwapChain</b></param>
	int CreateSwapChainForCompositionSurfaceHandle<T0, T1, T2> (T0* pDevice, IntPtr hSurface, SwapChainDesc1* pDesc, T1* pRestrictToOutput, out T2* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactoryMedia::CreateDecodeSwapChainForCompositionSurfaceHandle (IUnknown* pDevice, HANDLE hSurface, DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="pDevice">_In_ <b>IUnknown* pDevice</b></param>
	/// <param name="hSurface">_In_opt_ <b>HANDLE hSurface</b></param>
	/// <param name="pDesc">_In_ <b>DXGI_DECODE_SWAP_CHAIN_DESC* pDesc</b></param>
	/// <param name="pYuvDecodeBuffers">_In_ <b>IDXGIResource* pYuvDecodeBuffers</b></param>
	/// <param name="pRestrictToOutput">_In_opt_ <b>IDXGIOutput* pRestrictToOutput</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_ <b>IDXGIDecodeSwapChain** ppSwapChain</b></param>
	int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, T1, T2, T3> (T0* pDevice, IntPtr hSurface, DecodeSwapChainDesc* pDesc, T1* pYuvDecodeBuffers, T2* pRestrictToOutput, T3** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IResource where T2 : unmanaged, IOutput where T3 : unmanaged, IDecodeSwapChain;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactoryMedia::CreateDecodeSwapChainForCompositionSurfaceHandle (IUnknown* pDevice, HANDLE hSurface, DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="pDevice">_In_ <b>IUnknown* pDevice</b></param>
	/// <param name="hSurface">_In_opt_ <b>HANDLE hSurface</b></param>
	/// <param name="pDesc">_In_ <b>DXGI_DECODE_SWAP_CHAIN_DESC* pDesc</b></param>
	/// <param name="pYuvDecodeBuffers">_In_ <b>IDXGIResource* pYuvDecodeBuffers</b></param>
	/// <param name="pRestrictToOutput">_In_opt_ <b>IDXGIOutput* pRestrictToOutput</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_ <b>IDXGIDecodeSwapChain** ppSwapChain</b></param>
	int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, T1, T2, T3> (T0* pDevice, IntPtr hSurface, DecodeSwapChainDesc* pDesc, T1* pYuvDecodeBuffers, T2* pRestrictToOutput, out T3* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IResource where T2 : unmanaged, IOutput where T3 : unmanaged, IDecodeSwapChain;
}

/// <summary>
/// Instance of <b>IDXGIFactoryMedia</b><br/>
/// DXGI1_3.h
/// </summary>
unsafe public readonly struct FactoryMedia : IFactoryMedia {
//unsafe public readonly struct IFactoryMediaObj : IFactoryMedia {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FactoryMedia* GetCurrentPointer () => (FactoryMedia*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFactoryMediaObj* GetCurrentPointer () => (IFactoryMediaObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x41e7d1f2, 0xa591, 0x4f7b, 0xa2, 0xe5, 0xfa, 0x9c, 0x84, 0x3e, 0x1c, 0x12);

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
	public readonly int CreateSwapChainForCompositionSurfaceHandle<T0, T1, T2> (T0* pDevice, IntPtr hSurface, SwapChainDesc1* pDesc, T1* pRestrictToOutput, T2** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForCompositionSurfaceHandle (ptr, pDevice, hSurface, pDesc, pRestrictToOutput, (void**) ppSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChainForCompositionSurfaceHandle<T0, T1, T2> (T0* pDevice, IntPtr hSurface, SwapChainDesc1* pDesc, T1* pRestrictToOutput, out T2* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1 {
		fixed (T2** _ppSwapChain = &ppSwapChain) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForCompositionSurfaceHandle (ptr, pDevice, hSurface, pDesc, pRestrictToOutput, (void**) _ppSwapChain);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, T1, T2, T3> (T0* pDevice, IntPtr hSurface, DecodeSwapChainDesc* pDesc, T1* pYuvDecodeBuffers, T2* pRestrictToOutput, T3** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IResource where T2 : unmanaged, IOutput where T3 : unmanaged, IDecodeSwapChain {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecodeSwapChainForCompositionSurfaceHandle (ptr, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, (void**) ppSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, T1, T2, T3> (T0* pDevice, IntPtr hSurface, DecodeSwapChainDesc* pDesc, T1* pYuvDecodeBuffers, T2* pRestrictToOutput, out T3* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IResource where T2 : unmanaged, IOutput where T3 : unmanaged, IDecodeSwapChain {
		fixed (T3** _ppSwapChain = &ppSwapChain) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDecodeSwapChainForCompositionSurfaceHandle (ptr, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, (void**) _ppSwapChain);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, IntPtr, SwapChainDesc1*, void*, void**, int> CreateSwapChainForCompositionSurfaceHandle;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, IntPtr, DecodeSwapChainDesc*, void*, void*, void**, int> CreateDecodeSwapChainForCompositionSurfaceHandle;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
