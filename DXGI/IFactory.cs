using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIFactory</b> : IDXGIObject<br/>
/// DXGI.h
/// </summary>
unsafe public interface IFactory : IObject {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::EnumAdapters (UINT Adapter, IDXGIAdapter** ppAdapter)</b><br/>
	/// </summary>
	/// <param name="adapter"><b>UINT Adapter</b></param>
	/// <param name="ppAdapter">_COM_Outptr_ <b>IDXGIAdapter** ppAdapter</b></param>
	int EnumAdapters<T0> (uint adapter, T0** ppAdapter) where T0 : unmanaged, IAdapter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::EnumAdapters (UINT Adapter, IDXGIAdapter** ppAdapter)</b><br/>
	/// </summary>
	/// <param name="adapter"><b>UINT Adapter</b></param>
	/// <param name="ppAdapter">_COM_Outptr_ <b>IDXGIAdapter** ppAdapter</b></param>
	int EnumAdapters<T0> (uint adapter, out T0* ppAdapter) where T0 : unmanaged, IAdapter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::MakeWindowAssociation (HWND WindowHandle, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="windowHandle"><b>HWND WindowHandle</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	int MakeWindowAssociation (IntPtr windowHandle, uint flags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::GetWindowAssociation (HWND* pWindowHandle)</b><br/>
	/// </summary>
	/// <param name="pWindowHandle">_Out_ <b>HWND* pWindowHandle</b></param>
	int GetWindowAssociation (IntPtr* pWindowHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::GetWindowAssociation (HWND* pWindowHandle)</b><br/>
	/// </summary>
	/// <param name="pWindowHandle">_Out_ <b>HWND* pWindowHandle</b></param>
	int GetWindowAssociation (out IntPtr pWindowHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::CreateSwapChain (IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="pDevice">_In_ <b>IUnknown* pDevice</b></param>
	/// <param name="pDesc">_In_ <b>DXGI_SWAP_CHAIN_DESC* pDesc</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_ <b>IDXGISwapChain** ppSwapChain</b></param>
	int CreateSwapChain<T0, T1> (T0* pDevice, SwapChainDesc* pDesc, T1** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, ISwapChain;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::CreateSwapChain (IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="pDevice">_In_ <b>IUnknown* pDevice</b></param>
	/// <param name="pDesc">_In_ <b>DXGI_SWAP_CHAIN_DESC* pDesc</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_ <b>IDXGISwapChain** ppSwapChain</b></param>
	int CreateSwapChain<T0, T1> (T0* pDevice, SwapChainDesc* pDesc, out T1* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, ISwapChain;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::CreateSoftwareAdapter (HMODULE Module, IDXGIAdapter** ppAdapter)</b><br/>
	/// </summary>
	/// <param name="module"><b>HMODULE Module</b></param>
	/// <param name="ppAdapter">_COM_Outptr_ <b>IDXGIAdapter** ppAdapter</b></param>
	int CreateSoftwareAdapter<T0> (IntPtr module, T0** ppAdapter) where T0 : unmanaged, IAdapter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory::CreateSoftwareAdapter (HMODULE Module, IDXGIAdapter** ppAdapter)</b><br/>
	/// </summary>
	/// <param name="module"><b>HMODULE Module</b></param>
	/// <param name="ppAdapter">_COM_Outptr_ <b>IDXGIAdapter** ppAdapter</b></param>
	int CreateSoftwareAdapter<T0> (IntPtr module, out T0* ppAdapter) where T0 : unmanaged, IAdapter;
}

/// <summary>
/// Instance of <b>IDXGIFactory</b><br/>
/// DXGI.h
/// </summary>
unsafe public readonly struct Factory : IFactory {
//unsafe public readonly struct IFactoryObj : IFactory {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Factory* GetCurrentPointer () => (Factory*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFactoryObj* GetCurrentPointer () => (IFactoryObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x7b7166ec, 0x21c7, 0x44ae, 0xb2, 0x1a, 0xc9, 0xae, 0x32, 0x1a, 0xe3, 0x69);

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
	public readonly int SetPrivateData (Guid name, uint dataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateData (ptr, name, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateDataInterface<T0> (Guid name, T0* pUnknown) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateDataInterface (ptr, name, pUnknown);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPrivateData (Guid name, uint* pDataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrivateData (ptr, name, pDataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParent (Guid riid, void** ppParent) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetParent (ptr, riid, ppParent);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParent (Guid riid, out void* ppParent) {
		fixed (void** _ppParent = &ppParent) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetParent (ptr, riid, _ppParent);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumAdapters<T0> (uint adapter, T0** ppAdapter) where T0 : unmanaged, IAdapter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnumAdapters (ptr, adapter, (void**) ppAdapter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumAdapters<T0> (uint adapter, out T0* ppAdapter) where T0 : unmanaged, IAdapter {
		fixed (T0** _ppAdapter = &ppAdapter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->EnumAdapters (ptr, adapter, (void**) _ppAdapter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MakeWindowAssociation (IntPtr windowHandle, uint flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MakeWindowAssociation (ptr, windowHandle, flags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWindowAssociation (IntPtr* pWindowHandle) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetWindowAssociation (ptr, pWindowHandle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWindowAssociation (out IntPtr pWindowHandle) {
		fixed (IntPtr* _pWindowHandle = &pWindowHandle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetWindowAssociation (ptr, _pWindowHandle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChain<T0, T1> (T0* pDevice, SwapChainDesc* pDesc, T1** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, ISwapChain {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChain (ptr, pDevice, pDesc, (void**) ppSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChain<T0, T1> (T0* pDevice, SwapChainDesc* pDesc, out T1* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, ISwapChain {
		fixed (T1** _ppSwapChain = &ppSwapChain) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChain (ptr, pDevice, pDesc, (void**) _ppSwapChain);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSoftwareAdapter<T0> (IntPtr module, T0** ppAdapter) where T0 : unmanaged, IAdapter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSoftwareAdapter (ptr, module, (void**) ppAdapter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSoftwareAdapter<T0> (IntPtr module, out T0* ppAdapter) where T0 : unmanaged, IAdapter {
		fixed (T0** _ppAdapter = &ppAdapter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSoftwareAdapter (ptr, module, (void**) _ppAdapter);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetParent;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> EnumAdapters;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint, int> MakeWindowAssociation;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr*, int> GetWindowAssociation;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, SwapChainDesc*, void**, int> CreateSwapChain;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, void**, int> CreateSoftwareAdapter;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
