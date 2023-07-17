using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGISwapChain</b> : IDXGIDeviceSubObject<br/>
/// DXGI.h
/// </summary>
unsafe public interface ISwapChain : IDeviceSubObject {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::Present (UINT SyncInterval, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="syncInterval"><b>UINT SyncInterval</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	int Present (uint syncInterval, uint flags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetBuffer (UINT Buffer, REFIID riid, void** ppSurface)</b><br/>
	/// </summary>
	/// <param name="buffer"><b>UINT Buffer</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppSurface">_COM_Outptr_ <b>void** ppSurface</b></param>
	int GetBuffer (uint buffer, Guid riid, void** ppSurface);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetBuffer (UINT Buffer, REFIID riid, void** ppSurface)</b><br/>
	/// </summary>
	/// <param name="buffer"><b>UINT Buffer</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppSurface">_COM_Outptr_ <b>void** ppSurface</b></param>
	int GetBuffer (uint buffer, Guid riid, out void* ppSurface);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::SetFullscreenState (BOOL Fullscreen, IDXGIOutput* pTarget)</b><br/>
	/// </summary>
	/// <param name="fullscreen"><b>BOOL Fullscreen</b></param>
	/// <param name="pTarget">_In_opt_ <b>IDXGIOutput* pTarget</b></param>
	int SetFullscreenState<T0> (bool fullscreen, T0* pTarget) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetFullscreenState (BOOL* pFullscreen, IDXGIOutput** ppTarget)</b><br/>
	/// </summary>
	/// <param name="pFullscreen">_Out_opt_ <b>BOOL* pFullscreen</b></param>
	/// <param name="ppTarget">_COM_Outptr_opt_result_maybenull_ <b>IDXGIOutput** ppTarget</b></param>
	int GetFullscreenState<T0> (uint* pFullscreen, T0** ppTarget) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetFullscreenState (BOOL* pFullscreen, IDXGIOutput** ppTarget)</b><br/>
	/// </summary>
	/// <param name="pFullscreen">_Out_opt_ <b>BOOL* pFullscreen</b></param>
	/// <param name="ppTarget">_COM_Outptr_opt_result_maybenull_ <b>IDXGIOutput** ppTarget</b></param>
	int GetFullscreenState<T0> (out bool pFullscreen, out T0* ppTarget) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetDesc (DXGI_SWAP_CHAIN_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_SWAP_CHAIN_DESC* pDesc</b></param>
	int GetDesc (SwapChainDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetDesc (DXGI_SWAP_CHAIN_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_SWAP_CHAIN_DESC* pDesc</b></param>
	int GetDesc (out SwapChainDesc pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::ResizeBuffers (UINT BufferCount, UINT Width, UINT Height, DXGI_FORMAT NewFormat, UINT SwapChainFlags)</b><br/>
	/// </summary>
	/// <param name="bufferCount"><b>UINT BufferCount</b></param>
	/// <param name="width"><b>UINT Width</b></param>
	/// <param name="height"><b>UINT Height</b></param>
	/// <param name="newFormat"><b>DXGI_FORMAT NewFormat</b></param>
	/// <param name="swapChainFlags"><b>UINT SwapChainFlags</b></param>
	int ResizeBuffers (uint bufferCount, uint width, uint height, Format newFormat, uint swapChainFlags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::ResizeTarget (DXGI_MODE_DESC* pNewTargetParameters)</b><br/>
	/// </summary>
	/// <param name="pNewTargetParameters">_In_ <b>DXGI_MODE_DESC* pNewTargetParameters</b></param>
	int ResizeTarget (ModeDesc* pNewTargetParameters);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetContainingOutput (IDXGIOutput** ppOutput)</b><br/>
	/// </summary>
	/// <param name="ppOutput">_COM_Outptr_ <b>IDXGIOutput** ppOutput</b></param>
	int GetContainingOutput<T0> (T0** ppOutput) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetContainingOutput (IDXGIOutput** ppOutput)</b><br/>
	/// </summary>
	/// <param name="ppOutput">_COM_Outptr_ <b>IDXGIOutput** ppOutput</b></param>
	int GetContainingOutput<T0> (out T0* ppOutput) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetFrameStatistics (DXGI_FRAME_STATISTICS* pStats)</b><br/>
	/// </summary>
	/// <param name="pStats">_Out_ <b>DXGI_FRAME_STATISTICS* pStats</b></param>
	int GetFrameStatistics (FrameStatistics* pStats);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetFrameStatistics (DXGI_FRAME_STATISTICS* pStats)</b><br/>
	/// </summary>
	/// <param name="pStats">_Out_ <b>DXGI_FRAME_STATISTICS* pStats</b></param>
	int GetFrameStatistics (out FrameStatistics pStats);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetLastPresentCount (UINT* pLastPresentCount)</b><br/>
	/// </summary>
	/// <param name="pLastPresentCount">_Out_ <b>UINT* pLastPresentCount</b></param>
	int GetLastPresentCount (uint* pLastPresentCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChain::GetLastPresentCount (UINT* pLastPresentCount)</b><br/>
	/// </summary>
	/// <param name="pLastPresentCount">_Out_ <b>UINT* pLastPresentCount</b></param>
	int GetLastPresentCount (out uint pLastPresentCount);
}

/// <summary>
/// Instance of <b>IDXGISwapChain</b><br/>
/// DXGI.h
/// </summary>
unsafe public readonly struct SwapChain : ISwapChain {
//unsafe public readonly struct ISwapChainObj : ISwapChain {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SwapChain* GetCurrentPointer () => (SwapChain*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISwapChainObj* GetCurrentPointer () => (ISwapChainObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x310d36a0, 0xd2e7, 0x4c0a, 0xaa, 0x04, 0x6a, 0x9d, 0x23, 0xb8, 0x88, 0x6a);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
