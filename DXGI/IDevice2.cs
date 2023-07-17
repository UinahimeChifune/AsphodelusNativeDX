using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIDevice2</b> : IDXGIDevice1<br/>
/// DXGI1_2.h
/// </summary>
unsafe public interface IDevice2 : IDevice1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice2::OfferResources (UINT NumResources, IDXGIResource* ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority)</b><br/>
	/// </summary>
	/// <param name="numResources">_In_ <b>UINT NumResources</b></param>
	/// <param name="ppResources">_In_reads_(NumResources) <b>IDXGIResource* ppResources</b></param>
	/// <param name="priority">_In_ <b>DXGI_OFFER_RESOURCE_PRIORITY Priority</b></param>
	int OfferResources<T0> (uint numResources, T0* ppResources, OfferResourcePriority priority) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice2::ReclaimResources (UINT NumResources, IDXGIResource* ppResources, BOOL* pDiscarded)</b><br/>
	/// </summary>
	/// <param name="numResources">_In_ <b>UINT NumResources</b></param>
	/// <param name="ppResources">_In_reads_(NumResources) <b>IDXGIResource* ppResources</b></param>
	/// <param name="pDiscarded">_Out_writes_all_opt_(NumResources) <b>BOOL* pDiscarded</b></param>
	int ReclaimResources<T0> (uint numResources, T0* ppResources, uint* pDiscarded) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice2::ReclaimResources (UINT NumResources, IDXGIResource* ppResources, BOOL* pDiscarded)</b><br/>
	/// </summary>
	/// <param name="numResources">_In_ <b>UINT NumResources</b></param>
	/// <param name="ppResources">_In_reads_(NumResources) <b>IDXGIResource* ppResources</b></param>
	/// <param name="pDiscarded">_Out_writes_all_opt_(NumResources) <b>BOOL* pDiscarded</b></param>
	int ReclaimResources<T0> (uint numResources, T0* ppResources, out bool pDiscarded) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice2::EnqueueSetEvent (HANDLE hEvent)</b><br/>
	/// </summary>
	/// <param name="hEvent">_In_ <b>HANDLE hEvent</b></param>
	int EnqueueSetEvent (IntPtr hEvent);
}

/// <summary>
/// Instance of <b>IDXGIDevice2</b><br/>
/// DXGI1_2.h
/// </summary>
unsafe public readonly struct Device2 : IDevice2 {
//unsafe public readonly struct IDevice2Obj : IDevice2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device2* GetCurrentPointer () => (Device2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDevice2Obj* GetCurrentPointer () => (IDevice2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x05008617, 0xfbfd, 0x4051, 0xa7, 0x90, 0x14, 0x48, 0x84, 0xb4, 0xf6, 0xa9);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetMaximumFrameLatency (uint maxLatency) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetMaximumFrameLatency (ptr, maxLatency);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMaximumFrameLatency (uint* pMaxLatency) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMaximumFrameLatency (ptr, pMaxLatency);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMaximumFrameLatency (out uint pMaxLatency) {
		fixed (uint* _pMaxLatency = &pMaxLatency) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMaximumFrameLatency (ptr, _pMaxLatency);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OfferResources<T0> (uint numResources, T0* ppResources, OfferResourcePriority priority) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OfferResources (ptr, numResources, ppResources, priority);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReclaimResources<T0> (uint numResources, T0* ppResources, uint* pDiscarded) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReclaimResources (ptr, numResources, ppResources, pDiscarded);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReclaimResources<T0> (uint numResources, T0* ppResources, out bool pDiscarded) where T0 : unmanaged, IResource {
		uint _pDiscarded;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReclaimResources (ptr, numResources, ppResources, &_pDiscarded);
		pDiscarded = _pDiscarded != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnqueueSetEvent (IntPtr hEvent) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnqueueSetEvent (ptr, hEvent);
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
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetMaximumFrameLatency;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetMaximumFrameLatency;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, OfferResourcePriority, int> OfferResources;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint*, int> ReclaimResources;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, int> EnqueueSetEvent;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
