using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIDevice</b> : IDXGIObject<br/>
/// DXGI.h
/// </summary>
unsafe public interface IDevice : IObject {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::GetAdapter (IDXGIAdapter** pAdapter)</b><br/>
	/// </summary>
	/// <param name="pAdapter">_COM_Outptr_ <b>IDXGIAdapter** pAdapter</b></param>
	int GetAdapter<T0> (T0** pAdapter) where T0 : unmanaged, IAdapter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::GetAdapter (IDXGIAdapter** pAdapter)</b><br/>
	/// </summary>
	/// <param name="pAdapter">_COM_Outptr_ <b>IDXGIAdapter** pAdapter</b></param>
	int GetAdapter<T0> (out T0* pAdapter) where T0 : unmanaged, IAdapter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::CreateSurface (DXGI_SURFACE_DESC* pDesc, UINT NumSurfaces, DXGI_USAGE Usage, DXGI_SHARED_RESOURCE* pSharedResource, IDXGISurface** ppSurface)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>DXGI_SURFACE_DESC* pDesc</b></param>
	/// <param name="numSurfaces"><b>UINT NumSurfaces</b></param>
	/// <param name="usage"><b>DXGI_USAGE Usage</b></param>
	/// <param name="pSharedResource">_In_opt_ <b>DXGI_SHARED_RESOURCE* pSharedResource</b></param>
	/// <param name="ppSurface">_Out_writes_(NumSurfaces) <b>IDXGISurface** ppSurface</b></param>
	int CreateSurface<T0> (SurfaceDesc* pDesc, uint numSurfaces, Usage usage, SharedResource* pSharedResource, T0** ppSurface) where T0 : unmanaged, ISurface;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::CreateSurface (DXGI_SURFACE_DESC* pDesc, UINT NumSurfaces, DXGI_USAGE Usage, DXGI_SHARED_RESOURCE* pSharedResource, IDXGISurface** ppSurface)</b><br/>
	/// </summary>
	/// <param name="pDesc">_In_ <b>DXGI_SURFACE_DESC* pDesc</b></param>
	/// <param name="numSurfaces"><b>UINT NumSurfaces</b></param>
	/// <param name="usage"><b>DXGI_USAGE Usage</b></param>
	/// <param name="pSharedResource">_In_opt_ <b>DXGI_SHARED_RESOURCE* pSharedResource</b></param>
	/// <param name="ppSurface">_Out_writes_(NumSurfaces) <b>IDXGISurface** ppSurface</b></param>
	int CreateSurface<T0> (SurfaceDesc* pDesc, uint numSurfaces, Usage usage, SharedResource* pSharedResource, out T0* ppSurface) where T0 : unmanaged, ISurface;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::QueryResourceResidency (IUnknown* ppResources, DXGI_RESIDENCY* pResidencyStatus, UINT NumResources)</b><br/>
	/// </summary>
	/// <param name="ppResources">_In_reads_(NumResources) <b>IUnknown* ppResources</b></param>
	/// <param name="pResidencyStatus">_Out_writes_(NumResources) <b>DXGI_RESIDENCY* pResidencyStatus</b></param>
	/// <param name="numResources"><b>UINT NumResources</b></param>
	int QueryResourceResidency<T0> (T0* ppResources, Residency* pResidencyStatus, uint numResources) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::SetGPUThreadPriority (INT Priority)</b><br/>
	/// </summary>
	/// <param name="priority"><b>INT Priority</b></param>
	int SetGPUThreadPriority (int priority);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::GetGPUThreadPriority (INT* pPriority)</b><br/>
	/// </summary>
	/// <param name="pPriority">_Out_ <b>INT* pPriority</b></param>
	int GetGPUThreadPriority (int* pPriority);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice::GetGPUThreadPriority (INT* pPriority)</b><br/>
	/// </summary>
	/// <param name="pPriority">_Out_ <b>INT* pPriority</b></param>
	int GetGPUThreadPriority (out int pPriority);
}

/// <summary>
/// Instance of <b>IDXGIDevice</b><br/>
/// DXGI.h
/// </summary>
unsafe public readonly struct Device : IDevice {
//unsafe public readonly struct IDeviceObj : IDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device* GetCurrentPointer () => (Device*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDeviceObj* GetCurrentPointer () => (IDeviceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x54ec77fa, 0x1377, 0x44e6, 0x8c, 0x32, 0x88, 0xfd, 0x5f, 0x44, 0xc8, 0x4c);

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
	public readonly int GetAdapter<T0> (T0** pAdapter) where T0 : unmanaged, IAdapter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAdapter (ptr, (void**) pAdapter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAdapter<T0> (out T0* pAdapter) where T0 : unmanaged, IAdapter {
		fixed (T0** _pAdapter = &pAdapter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAdapter (ptr, (void**) _pAdapter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSurface<T0> (SurfaceDesc* pDesc, uint numSurfaces, Usage usage, SharedResource* pSharedResource, T0** ppSurface) where T0 : unmanaged, ISurface {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSurface (ptr, pDesc, numSurfaces, usage, pSharedResource, (void**) ppSurface);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSurface<T0> (SurfaceDesc* pDesc, uint numSurfaces, Usage usage, SharedResource* pSharedResource, out T0* ppSurface) where T0 : unmanaged, ISurface {
		fixed (T0** _ppSurface = &ppSurface) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSurface (ptr, pDesc, numSurfaces, usage, pSharedResource, (void**) _ppSurface);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryResourceResidency<T0> (T0* ppResources, Residency* pResidencyStatus, uint numResources) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryResourceResidency (ptr, ppResources, pResidencyStatus, numResources);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetGPUThreadPriority (int priority) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetGPUThreadPriority (ptr, priority);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGPUThreadPriority (int* pPriority) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGPUThreadPriority (ptr, pPriority);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGPUThreadPriority (out int pPriority) {
		fixed (int* _pPriority = &pPriority) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGPUThreadPriority (ptr, _pPriority);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetAdapter;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SurfaceDesc*, uint, Usage, SharedResource*, void**, int> CreateSurface;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Residency*, uint, int> QueryResourceResidency;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int, int> SetGPUThreadPriority;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int*, int> GetGPUThreadPriority;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
