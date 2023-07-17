using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIFactory4</b> : IDXGIFactory3<br/>
/// DXGI1_4.h
/// </summary>
unsafe public interface IFactory4 : IFactory3 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory4::EnumAdapterByLuid (LUID AdapterLuid, REFIID riid, void** ppvAdapter)</b><br/>
	/// </summary>
	/// <param name="adapterLuid">_In_ <b>LUID AdapterLuid</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvAdapter">_COM_Outptr_ <b>void** ppvAdapter</b></param>
	int EnumAdapterByLuid (LUID adapterLuid, Guid riid, void** ppvAdapter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory4::EnumAdapterByLuid (LUID AdapterLuid, REFIID riid, void** ppvAdapter)</b><br/>
	/// </summary>
	/// <param name="adapterLuid">_In_ <b>LUID AdapterLuid</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvAdapter">_COM_Outptr_ <b>void** ppvAdapter</b></param>
	int EnumAdapterByLuid (LUID adapterLuid, Guid riid, out void* ppvAdapter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory4::EnumWarpAdapter (REFIID riid, void** ppvAdapter)</b><br/>
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvAdapter">_COM_Outptr_ <b>void** ppvAdapter</b></param>
	int EnumWarpAdapter (Guid riid, void** ppvAdapter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIFactory4::EnumWarpAdapter (REFIID riid, void** ppvAdapter)</b><br/>
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvAdapter">_COM_Outptr_ <b>void** ppvAdapter</b></param>
	int EnumWarpAdapter (Guid riid, out void* ppvAdapter);
}

/// <summary>
/// Instance of <b>IDXGIFactory4</b><br/>
/// DXGI1_4.h
/// </summary>
unsafe public readonly struct Factory4 : IFactory4 {
//unsafe public readonly struct IFactory4Obj : IFactory4 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Factory4* GetCurrentPointer () => (Factory4*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFactory4Obj* GetCurrentPointer () => (IFactory4Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1bc6ea02, 0xef36, 0x464f, 0xbf, 0x0c, 0x21, 0xca, 0x39, 0xe5, 0x16, 0x8a);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumAdapters1<T0> (uint adapter, T0** ppAdapter) where T0 : unmanaged, IAdapter1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnumAdapters1 (ptr, adapter, (void**) ppAdapter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumAdapters1<T0> (uint adapter, out T0* ppAdapter) where T0 : unmanaged, IAdapter1 {
		fixed (T0** _ppAdapter = &ppAdapter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->EnumAdapters1 (ptr, adapter, (void**) _ppAdapter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsCurrent () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsCurrent (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsWindowedStereoEnabled () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsWindowedStereoEnabled (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChainForHwnd<T0, T1, T2> (T0* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, T1* pRestrictToOutput, T2** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForHwnd (ptr, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, (void**) ppSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChainForHwnd<T0, T1, T2> (T0* pDevice, IntPtr hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, T1* pRestrictToOutput, out T2* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1 {
		fixed (T2** _ppSwapChain = &ppSwapChain) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForHwnd (ptr, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, (void**) _ppSwapChain);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChainForCoreWindow<T0, T1, T2, T3> (T0* pDevice, T1* pWindow, SwapChainDesc1* pDesc, T2* pRestrictToOutput, T3** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IUnknown where T2 : unmanaged, IOutput where T3 : unmanaged, ISwapChain1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForCoreWindow (ptr, pDevice, pWindow, pDesc, pRestrictToOutput, (void**) ppSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChainForCoreWindow<T0, T1, T2, T3> (T0* pDevice, T1* pWindow, SwapChainDesc1* pDesc, T2* pRestrictToOutput, out T3* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IUnknown where T2 : unmanaged, IOutput where T3 : unmanaged, ISwapChain1 {
		fixed (T3** _ppSwapChain = &ppSwapChain) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForCoreWindow (ptr, pDevice, pWindow, pDesc, pRestrictToOutput, (void**) _ppSwapChain);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSharedResourceAdapterLuid (IntPtr hResource, LUID* pLuid) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSharedResourceAdapterLuid (ptr, hResource, pLuid);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSharedResourceAdapterLuid (IntPtr hResource, out LUID pLuid) {
		fixed (LUID* _pLuid = &pLuid) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSharedResourceAdapterLuid (ptr, hResource, _pLuid);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterStereoStatusWindow (IntPtr windowHandle, uint wMsg, uint* pdwCookie) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterStereoStatusWindow (ptr, windowHandle, wMsg, pdwCookie);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterStereoStatusWindow (IntPtr windowHandle, uint wMsg, out uint pdwCookie) {
		fixed (uint* _pdwCookie = &pdwCookie) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RegisterStereoStatusWindow (ptr, windowHandle, wMsg, _pdwCookie);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterStereoStatusEvent (IntPtr hEvent, uint* pdwCookie) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterStereoStatusEvent (ptr, hEvent, pdwCookie);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterStereoStatusEvent (IntPtr hEvent, out uint pdwCookie) {
		fixed (uint* _pdwCookie = &pdwCookie) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RegisterStereoStatusEvent (ptr, hEvent, _pdwCookie);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void UnregisterStereoStatus (uint dwCookie) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UnregisterStereoStatus (ptr, dwCookie);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterOcclusionStatusWindow (IntPtr windowHandle, uint wMsg, uint* pdwCookie) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterOcclusionStatusWindow (ptr, windowHandle, wMsg, pdwCookie);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterOcclusionStatusWindow (IntPtr windowHandle, uint wMsg, out uint pdwCookie) {
		fixed (uint* _pdwCookie = &pdwCookie) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RegisterOcclusionStatusWindow (ptr, windowHandle, wMsg, _pdwCookie);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterOcclusionStatusEvent (IntPtr hEvent, uint* pdwCookie) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterOcclusionStatusEvent (ptr, hEvent, pdwCookie);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterOcclusionStatusEvent (IntPtr hEvent, out uint pdwCookie) {
		fixed (uint* _pdwCookie = &pdwCookie) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RegisterOcclusionStatusEvent (ptr, hEvent, _pdwCookie);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void UnregisterOcclusionStatus (uint dwCookie) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UnregisterOcclusionStatus (ptr, dwCookie);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChainForComposition<T0, T1, T2> (T0* pDevice, SwapChainDesc1* pDesc, T1* pRestrictToOutput, T2** ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForComposition (ptr, pDevice, pDesc, pRestrictToOutput, (void**) ppSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSwapChainForComposition<T0, T1, T2> (T0* pDevice, SwapChainDesc1* pDesc, T1* pRestrictToOutput, out T2* ppSwapChain) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutput where T2 : unmanaged, ISwapChain1 {
		fixed (T2** _ppSwapChain = &ppSwapChain) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSwapChainForComposition (ptr, pDevice, pDesc, pRestrictToOutput, (void**) _ppSwapChain);
			return hr;
		}
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
	public readonly int EnumAdapterByLuid (LUID adapterLuid, Guid riid, void** ppvAdapter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnumAdapterByLuid (ptr, adapterLuid, riid, ppvAdapter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumAdapterByLuid (LUID adapterLuid, Guid riid, out void* ppvAdapter) {
		fixed (void** _ppvAdapter = &ppvAdapter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->EnumAdapterByLuid (ptr, adapterLuid, riid, _ppvAdapter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumWarpAdapter (Guid riid, void** ppvAdapter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnumWarpAdapter (ptr, riid, ppvAdapter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumWarpAdapter (Guid riid, out void* ppvAdapter) {
		fixed (void** _ppvAdapter = &ppvAdapter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->EnumWarpAdapter (ptr, riid, _ppvAdapter);
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
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> EnumAdapters1;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsCurrent;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsWindowedStereoEnabled;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, IntPtr, SwapChainDesc1*, SwapChainFullscreenDesc*, void*, void**, int> CreateSwapChainForHwnd;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, SwapChainDesc1*, void*, void**, int> CreateSwapChainForCoreWindow;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, LUID*, int> GetSharedResourceAdapterLuid;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint, uint*, int> RegisterStereoStatusWindow;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint*, int> RegisterStereoStatusEvent;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> UnregisterStereoStatus;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint, uint*, int> RegisterOcclusionStatusWindow;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint*, int> RegisterOcclusionStatusEvent;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> UnregisterOcclusionStatus;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, SwapChainDesc1*, void*, void**, int> CreateSwapChainForComposition;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetCreationFlags;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LUID, Guid, void**, int> EnumAdapterByLuid;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> EnumWarpAdapter;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
