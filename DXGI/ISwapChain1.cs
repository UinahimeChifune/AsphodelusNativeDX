using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGISwapChain1</b> : IDXGISwapChain<br/>
/// DXGI1_2.h
/// </summary>
unsafe public interface ISwapChain1 : ISwapChain {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetDesc1 (DXGI_SWAP_CHAIN_DESC1* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_SWAP_CHAIN_DESC1* pDesc</b></param>
	int GetDesc1 (SwapChainDesc1* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetDesc1 (DXGI_SWAP_CHAIN_DESC1* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_SWAP_CHAIN_DESC1* pDesc</b></param>
	int GetDesc1 (out SwapChainDesc1 pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetFullscreenDesc (DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc</b></param>
	int GetFullscreenDesc (SwapChainFullscreenDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetFullscreenDesc (DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc</b></param>
	int GetFullscreenDesc (out SwapChainFullscreenDesc pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetHwnd (HWND* pHwnd)</b><br/>
	/// </summary>
	/// <param name="pHwnd">_Out_ <b>HWND* pHwnd</b></param>
	int GetHwnd (IntPtr* pHwnd);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetHwnd (HWND* pHwnd)</b><br/>
	/// </summary>
	/// <param name="pHwnd">_Out_ <b>HWND* pHwnd</b></param>
	int GetHwnd (out IntPtr pHwnd);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetCoreWindow (REFIID refiid, void** ppUnk)</b><br/>
	/// </summary>
	/// <param name="refiid">_In_ <b>REFIID refiid</b></param>
	/// <param name="ppUnk">_COM_Outptr_ <b>void** ppUnk</b></param>
	int GetCoreWindow (Guid refiid, void** ppUnk);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetCoreWindow (REFIID refiid, void** ppUnk)</b><br/>
	/// </summary>
	/// <param name="refiid">_In_ <b>REFIID refiid</b></param>
	/// <param name="ppUnk">_COM_Outptr_ <b>void** ppUnk</b></param>
	int GetCoreWindow (Guid refiid, out void* ppUnk);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::Present1 (UINT SyncInterval, UINT PresentFlags, DXGI_PRESENT_PARAMETERS* pPresentParameters)</b><br/>
	/// </summary>
	/// <param name="syncInterval"><b>UINT SyncInterval</b></param>
	/// <param name="presentFlags"><b>UINT PresentFlags</b></param>
	/// <param name="pPresentParameters">_In_ <b>DXGI_PRESENT_PARAMETERS* pPresentParameters</b></param>
	int Present1 (uint syncInterval, uint presentFlags, PresentParameters* pPresentParameters);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL IDXGISwapChain1::IsTemporaryMonoSupported ()</b><br/>
	/// </summary>
	bool IsTemporaryMonoSupported ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetRestrictToOutput (IDXGIOutput** ppRestrictToOutput)</b><br/>
	/// </summary>
	/// <param name="ppRestrictToOutput">_Out_ <b>IDXGIOutput** ppRestrictToOutput</b></param>
	int GetRestrictToOutput<T0> (T0** ppRestrictToOutput) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetRestrictToOutput (IDXGIOutput** ppRestrictToOutput)</b><br/>
	/// </summary>
	/// <param name="ppRestrictToOutput">_Out_ <b>IDXGIOutput** ppRestrictToOutput</b></param>
	int GetRestrictToOutput<T0> (out T0* ppRestrictToOutput) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::SetBackgroundColor (DXGI_RGBA* pColor)</b><br/>
	/// </summary>
	/// <param name="pColor">_In_ <b>DXGI_RGBA* pColor</b></param>
	int SetBackgroundColor (Vector4F* pColor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetBackgroundColor (DXGI_RGBA* pColor)</b><br/>
	/// </summary>
	/// <param name="pColor">_Out_ <b>DXGI_RGBA* pColor</b></param>
	int GetBackgroundColor (Vector4F* pColor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetBackgroundColor (DXGI_RGBA* pColor)</b><br/>
	/// </summary>
	/// <param name="pColor">_Out_ <b>DXGI_RGBA* pColor</b></param>
	int GetBackgroundColor (out Vector4F pColor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::SetRotation (DXGI_MODE_ROTATION Rotation)</b><br/>
	/// </summary>
	/// <param name="rotation">_In_ <b>DXGI_MODE_ROTATION Rotation</b></param>
	int SetRotation (ModeRotation rotation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetRotation (DXGI_MODE_ROTATION* pRotation)</b><br/>
	/// </summary>
	/// <param name="pRotation">_Out_ <b>DXGI_MODE_ROTATION* pRotation</b></param>
	int GetRotation (ModeRotation* pRotation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain1::GetRotation (DXGI_MODE_ROTATION* pRotation)</b><br/>
	/// </summary>
	/// <param name="pRotation">_Out_ <b>DXGI_MODE_ROTATION* pRotation</b></param>
	int GetRotation (out ModeRotation pRotation);
}

/// <summary>
/// Instance of <b>IDXGISwapChain1</b><br/>
/// DXGI1_2.h
/// </summary>
unsafe public readonly struct SwapChain1 : ISwapChain1 {
//unsafe public readonly struct ISwapChain1Obj : ISwapChain1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SwapChain1* GetCurrentPointer () => (SwapChain1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISwapChain1Obj* GetCurrentPointer () => (ISwapChain1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x790a45f7, 0x0d42, 0x4876, 0x98, 0x3a, 0x0a, 0x55, 0xcf, 0xe6, 0xf4, 0xaa);

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
	public readonly int GetDevice (Guid riid, void** ppDevice) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, ppDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDevice (Guid riid, out void* ppDevice) {
		fixed (void** _ppDevice = &ppDevice) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, _ppDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Present (uint syncInterval, uint flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Present (ptr, syncInterval, flags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBuffer (uint buffer, Guid riid, void** ppSurface) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBuffer (ptr, buffer, riid, ppSurface);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBuffer (uint buffer, Guid riid, out void* ppSurface) {
		fixed (void** _ppSurface = &ppSurface) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetBuffer (ptr, buffer, riid, _ppSurface);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFullscreenState<T0> (bool fullscreen, T0* pTarget) where T0 : unmanaged, IOutput {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFullscreenState (ptr, fullscreen ? 1U : 0U, pTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFullscreenState<T0> (uint* pFullscreen, T0** ppTarget) where T0 : unmanaged, IOutput {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFullscreenState (ptr, pFullscreen, (void**) ppTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFullscreenState<T0> (out bool pFullscreen, out T0* ppTarget) where T0 : unmanaged, IOutput {
		uint _pFullscreen;
		fixed (T0** _ppTarget = &ppTarget) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFullscreenState (ptr, &_pFullscreen, (void**) _ppTarget);
			pFullscreen = _pFullscreen != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc (SwapChainDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc (out SwapChainDesc pDesc) {
		fixed (SwapChainDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, _pDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ResizeBuffers (uint bufferCount, uint width, uint height, Format newFormat, uint swapChainFlags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ResizeBuffers (ptr, bufferCount, width, height, newFormat, swapChainFlags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ResizeTarget (ModeDesc* pNewTargetParameters) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ResizeTarget (ptr, pNewTargetParameters);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContainingOutput<T0> (T0** ppOutput) where T0 : unmanaged, IOutput {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetContainingOutput (ptr, (void**) ppOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContainingOutput<T0> (out T0* ppOutput) where T0 : unmanaged, IOutput {
		fixed (T0** _ppOutput = &ppOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetContainingOutput (ptr, (void**) _ppOutput);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameStatistics (FrameStatistics* pStats) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameStatistics (ptr, pStats);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameStatistics (out FrameStatistics pStats) {
		fixed (FrameStatistics* _pStats = &pStats) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameStatistics (ptr, _pStats);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLastPresentCount (uint* pLastPresentCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLastPresentCount (ptr, pLastPresentCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLastPresentCount (out uint pLastPresentCount) {
		fixed (uint* _pLastPresentCount = &pLastPresentCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLastPresentCount (ptr, _pLastPresentCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc1 (SwapChainDesc1* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc1 (ptr, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc1 (out SwapChainDesc1 pDesc) {
		fixed (SwapChainDesc1* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc1 (ptr, _pDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFullscreenDesc (SwapChainFullscreenDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFullscreenDesc (ptr, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFullscreenDesc (out SwapChainFullscreenDesc pDesc) {
		fixed (SwapChainFullscreenDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFullscreenDesc (ptr, _pDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetHwnd (IntPtr* pHwnd) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetHwnd (ptr, pHwnd);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetHwnd (out IntPtr pHwnd) {
		fixed (IntPtr* _pHwnd = &pHwnd) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetHwnd (ptr, _pHwnd);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCoreWindow (Guid refiid, void** ppUnk) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCoreWindow (ptr, refiid, ppUnk);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCoreWindow (Guid refiid, out void* ppUnk) {
		fixed (void** _ppUnk = &ppUnk) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCoreWindow (ptr, refiid, _ppUnk);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Present1 (uint syncInterval, uint presentFlags, PresentParameters* pPresentParameters) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Present1 (ptr, syncInterval, presentFlags, pPresentParameters);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsTemporaryMonoSupported () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsTemporaryMonoSupported (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRestrictToOutput<T0> (T0** ppRestrictToOutput) where T0 : unmanaged, IOutput {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRestrictToOutput (ptr, (void**) ppRestrictToOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRestrictToOutput<T0> (out T0* ppRestrictToOutput) where T0 : unmanaged, IOutput {
		fixed (T0** _ppRestrictToOutput = &ppRestrictToOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetRestrictToOutput (ptr, (void**) _ppRestrictToOutput);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBackgroundColor (Vector4F* pColor) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBackgroundColor (ptr, pColor);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBackgroundColor (Vector4F* pColor) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBackgroundColor (ptr, pColor);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBackgroundColor (out Vector4F pColor) {
		fixed (Vector4F* _pColor = &pColor) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetBackgroundColor (ptr, _pColor);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetRotation (ModeRotation rotation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetRotation (ptr, rotation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRotation (ModeRotation* pRotation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRotation (ptr, pRotation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRotation (out ModeRotation pRotation) {
		fixed (ModeRotation* _pRotation = &pRotation) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetRotation (ptr, _pRotation);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetDevice;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, int> Present;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Guid, void**, int> GetBuffer;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, int> SetFullscreenState;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, void**, int> GetFullscreenState;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SwapChainDesc*, int> GetDesc;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, Format, uint, int> ResizeBuffers;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ModeDesc*, int> ResizeTarget;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetContainingOutput;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FrameStatistics*, int> GetFrameStatistics;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetLastPresentCount;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SwapChainDesc1*, int> GetDesc1;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SwapChainFullscreenDesc*, int> GetFullscreenDesc;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr*, int> GetHwnd;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetCoreWindow;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, PresentParameters*, int> Present1;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsTemporaryMonoSupported;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetRestrictToOutput;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, int> SetBackgroundColor;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, int> GetBackgroundColor;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ModeRotation, int> SetRotation;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ModeRotation*, int> GetRotation;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
