using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11Debug</b> : IUnknown<br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public interface IDebug : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::SetFeatureMask (UINT Mask)</b><br/>
	/// </summary>
	/// <param name="mask"><b>UINT Mask</b></param>
	int SetFeatureMask (uint mask);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D11Debug::GetFeatureMask ()</b><br/>
	/// </summary>
	uint GetFeatureMask ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::SetPresentPerRenderOpDelay (UINT Milliseconds)</b><br/>
	/// </summary>
	/// <param name="milliseconds"><b>UINT Milliseconds</b></param>
	int SetPresentPerRenderOpDelay (uint milliseconds);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D11Debug::GetPresentPerRenderOpDelay ()</b><br/>
	/// </summary>
	uint GetPresentPerRenderOpDelay ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::SetSwapChain (IDXGISwapChain* pSwapChain)</b><br/>
	/// </summary>
	/// <param name="pSwapChain">_In_opt_ <b>IDXGISwapChain* pSwapChain</b></param>
	int SetSwapChain<T0> (T0* pSwapChain) where T0 : unmanaged, DXGI.ISwapChain;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::GetSwapChain (IDXGISwapChain** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="ppSwapChain">_Out_ <b>IDXGISwapChain** ppSwapChain</b></param>
	int GetSwapChain<T0> (T0** ppSwapChain) where T0 : unmanaged, DXGI.ISwapChain;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::GetSwapChain (IDXGISwapChain** ppSwapChain)</b><br/>
	/// </summary>
	/// <param name="ppSwapChain">_Out_ <b>IDXGISwapChain** ppSwapChain</b></param>
	int GetSwapChain<T0> (out T0* ppSwapChain) where T0 : unmanaged, DXGI.ISwapChain;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::ValidateContext (ID3D11DeviceContext* pContext)</b><br/>
	/// </summary>
	/// <param name="pContext">_In_ <b>ID3D11DeviceContext* pContext</b></param>
	int ValidateContext<T0> (T0* pContext) where T0 : unmanaged, IDeviceContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::ReportLiveDeviceObjects (D3D11_RLDO_FLAGS Flags)</b><br/>
	/// </summary>
	/// <param name="flags"><b>D3D11_RLDO_FLAGS Flags</b></param>
	int ReportLiveDeviceObjects (RldoFlags flags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Debug::ValidateContextForDispatch (ID3D11DeviceContext* pContext)</b><br/>
	/// </summary>
	/// <param name="pContext">_In_ <b>ID3D11DeviceContext* pContext</b></param>
	int ValidateContextForDispatch<T0> (T0* pContext) where T0 : unmanaged, IDeviceContext;
}

/// <summary>
/// Instance of <b>ID3D11Debug</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public readonly struct Debug : IDebug {
//unsafe public readonly struct IDebugObj : IDebug {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Debug* GetCurrentPointer () => (Debug*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDebugObj* GetCurrentPointer () => (IDebugObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x79cf2233, 0x7536, 0x4948, 0x9d, 0x36, 0x1e, 0x46, 0x92, 0xdc, 0x57, 0x60);

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
	public readonly int SetFeatureMask (uint mask) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFeatureMask (ptr, mask);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFeatureMask () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFeatureMask (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPresentPerRenderOpDelay (uint milliseconds) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPresentPerRenderOpDelay (ptr, milliseconds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetPresentPerRenderOpDelay () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPresentPerRenderOpDelay (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSwapChain<T0> (T0* pSwapChain) where T0 : unmanaged, DXGI.ISwapChain {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSwapChain (ptr, pSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSwapChain<T0> (T0** ppSwapChain) where T0 : unmanaged, DXGI.ISwapChain {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSwapChain (ptr, (void**) ppSwapChain);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSwapChain<T0> (out T0* ppSwapChain) where T0 : unmanaged, DXGI.ISwapChain {
		fixed (T0** _ppSwapChain = &ppSwapChain) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSwapChain (ptr, (void**) _ppSwapChain);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ValidateContext<T0> (T0* pContext) where T0 : unmanaged, IDeviceContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ValidateContext (ptr, pContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReportLiveDeviceObjects (RldoFlags flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReportLiveDeviceObjects (ptr, flags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ValidateContextForDispatch<T0> (T0* pContext) where T0 : unmanaged, IDeviceContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ValidateContextForDispatch (ptr, pContext);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetFeatureMask;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFeatureMask;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetPresentPerRenderOpDelay;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetPresentPerRenderOpDelay;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetSwapChain;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetSwapChain;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> ValidateContext;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RldoFlags, int> ReportLiveDeviceObjects;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> ValidateContextForDispatch;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
