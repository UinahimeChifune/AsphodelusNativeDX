using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIDevice4</b> : IDXGIDevice3<br/>
/// DXGI1_5.h
/// </summary>
unsafe public interface IDevice4 : IDevice3 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice4::OfferResources1 (UINT NumResources, IDXGIResource* ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="numResources">_In_ <b>UINT NumResources</b></param>
	/// <param name="ppResources">_In_reads_(NumResources) <b>IDXGIResource* ppResources</b></param>
	/// <param name="priority">_In_ <b>DXGI_OFFER_RESOURCE_PRIORITY Priority</b></param>
	/// <param name="flags">_In_ <b>UINT Flags</b></param>
	int OfferResources1<T0> (uint numResources, T0* ppResources, OfferResourcePriority priority, uint flags) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDevice4::ReclaimResources1 (UINT NumResources, IDXGIResource* ppResources, DXGI_RECLAIM_RESOURCE_RESULTS* pResults)</b><br/>
	/// </summary>
	/// <param name="numResources">_In_ <b>UINT NumResources</b></param>
	/// <param name="ppResources">_In_reads_(NumResources) <b>IDXGIResource* ppResources</b></param>
	/// <param name="pResults">_Out_writes_all_(NumResources) <b>DXGI_RECLAIM_RESOURCE_RESULTS* pResults</b></param>
	int ReclaimResources1<T0> (uint numResources, T0* ppResources, ReclaimResourceResults* pResults) where T0 : unmanaged, IResource;
}

/// <summary>
/// Instance of <b>IDXGIDevice4</b><br/>
/// DXGI1_5.h
/// </summary>
unsafe public readonly struct Device4 : IDevice4 {
//unsafe public readonly struct IDevice4Obj : IDevice4 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device4* GetCurrentPointer () => (Device4*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDevice4Obj* GetCurrentPointer () => (IDevice4Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x95b4f95f, 0xd8da, 0x4ca4, 0x9e, 0xe6, 0x3b, 0x76, 0xd5, 0x96, 0x8a, 0x10);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Trim () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Trim (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int OfferResources1<T0> (uint numResources, T0* ppResources, OfferResourcePriority priority, uint flags) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OfferResources1 (ptr, numResources, ppResources, priority, flags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReclaimResources1<T0> (uint numResources, T0* ppResources, ReclaimResourceResults* pResults) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReclaimResources1 (ptr, numResources, ppResources, pResults);
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
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> Trim;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, OfferResourcePriority, uint, int> OfferResources1;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, ReclaimResourceResults*, int> ReclaimResources1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
