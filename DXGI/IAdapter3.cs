using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIAdapter3</b> : IDXGIAdapter2<br/>
/// DXGI1_4.h
/// </summary>
unsafe public interface IAdapter3 : IAdapter2 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter3::RegisterHardwareContentProtectionTeardownStatusEvent (HANDLE hEvent, DWORD* pdwCookie)</b><br/>
	/// </summary>
	/// <param name="hEvent">_In_ <b>HANDLE hEvent</b></param>
	/// <param name="pdwCookie">_Out_ <b>DWORD* pdwCookie</b></param>
	int RegisterHardwareContentProtectionTeardownStatusEvent (IntPtr hEvent, uint* pdwCookie);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter3::RegisterHardwareContentProtectionTeardownStatusEvent (HANDLE hEvent, DWORD* pdwCookie)</b><br/>
	/// </summary>
	/// <param name="hEvent">_In_ <b>HANDLE hEvent</b></param>
	/// <param name="pdwCookie">_Out_ <b>DWORD* pdwCookie</b></param>
	int RegisterHardwareContentProtectionTeardownStatusEvent (IntPtr hEvent, out uint pdwCookie);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIAdapter3::UnregisterHardwareContentProtectionTeardownStatus (DWORD dwCookie)</b><br/>
	/// </summary>
	/// <param name="dwCookie">_In_ <b>DWORD dwCookie</b></param>
	void UnregisterHardwareContentProtectionTeardownStatus (uint dwCookie);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter3::QueryVideoMemoryInfo (UINT NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo)</b><br/>
	/// </summary>
	/// <param name="nodeIndex">_In_ <b>UINT NodeIndex</b></param>
	/// <param name="memorySegmentGroup">_In_ <b>DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup</b></param>
	/// <param name="pVideoMemoryInfo">_Out_ <b>DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo</b></param>
	int QueryVideoMemoryInfo (uint nodeIndex, MemorySegmentGroup memorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter3::QueryVideoMemoryInfo (UINT NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo)</b><br/>
	/// </summary>
	/// <param name="nodeIndex">_In_ <b>UINT NodeIndex</b></param>
	/// <param name="memorySegmentGroup">_In_ <b>DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup</b></param>
	/// <param name="pVideoMemoryInfo">_Out_ <b>DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo</b></param>
	int QueryVideoMemoryInfo (uint nodeIndex, MemorySegmentGroup memorySegmentGroup, out QueryVideoMemoryInfo pVideoMemoryInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter3::SetVideoMemoryReservation (UINT NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, UINT64 Reservation)</b><br/>
	/// </summary>
	/// <param name="nodeIndex">_In_ <b>UINT NodeIndex</b></param>
	/// <param name="memorySegmentGroup">_In_ <b>DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup</b></param>
	/// <param name="reservation">_In_ <b>UINT64 Reservation</b></param>
	int SetVideoMemoryReservation (uint nodeIndex, MemorySegmentGroup memorySegmentGroup, ulong reservation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter3::RegisterVideoMemoryBudgetChangeNotificationEvent (HANDLE hEvent, DWORD* pdwCookie)</b><br/>
	/// </summary>
	/// <param name="hEvent">_In_ <b>HANDLE hEvent</b></param>
	/// <param name="pdwCookie">_Out_ <b>DWORD* pdwCookie</b></param>
	int RegisterVideoMemoryBudgetChangeNotificationEvent (IntPtr hEvent, uint* pdwCookie);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter3::RegisterVideoMemoryBudgetChangeNotificationEvent (HANDLE hEvent, DWORD* pdwCookie)</b><br/>
	/// </summary>
	/// <param name="hEvent">_In_ <b>HANDLE hEvent</b></param>
	/// <param name="pdwCookie">_Out_ <b>DWORD* pdwCookie</b></param>
	int RegisterVideoMemoryBudgetChangeNotificationEvent (IntPtr hEvent, out uint pdwCookie);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIAdapter3::UnregisterVideoMemoryBudgetChangeNotification (DWORD dwCookie)</b><br/>
	/// </summary>
	/// <param name="dwCookie">_In_ <b>DWORD dwCookie</b></param>
	void UnregisterVideoMemoryBudgetChangeNotification (uint dwCookie);
}

/// <summary>
/// Instance of <b>IDXGIAdapter3</b><br/>
/// DXGI1_4.h
/// </summary>
unsafe public readonly struct Adapter3 : IAdapter3 {
//unsafe public readonly struct IAdapter3Obj : IAdapter3 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Adapter3* GetCurrentPointer () => (Adapter3*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IAdapter3Obj* GetCurrentPointer () => (IAdapter3Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x645967a4, 0x1392, 0x4310, 0xa7, 0x98, 0x80, 0x53, 0xce, 0x3e, 0x93, 0xfd);

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
	public readonly int EnumOutputs<T0> (uint output, T0** ppOutput) where T0 : unmanaged, IOutput {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnumOutputs (ptr, output, (void**) ppOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnumOutputs<T0> (uint output, out T0* ppOutput) where T0 : unmanaged, IOutput {
		fixed (T0** _ppOutput = &ppOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->EnumOutputs (ptr, output, (void**) _ppOutput);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc (AdapterDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc (out AdapterDesc pDesc) {
		fixed (AdapterDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, _pDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckInterfaceSupport (Guid interfaceName, long* pUMDVersion) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckInterfaceSupport (ptr, interfaceName, pUMDVersion);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckInterfaceSupport (Guid interfaceName, out long pUMDVersion) {
		fixed (long* _pUMDVersion = &pUMDVersion) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CheckInterfaceSupport (ptr, interfaceName, _pUMDVersion);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc1 (AdapterDesc1* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc1 (ptr, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc1 (out AdapterDesc1 pDesc) {
		fixed (AdapterDesc1* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc1 (ptr, _pDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc2 (AdapterDesc2* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc2 (ptr, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc2 (out AdapterDesc2 pDesc) {
		fixed (AdapterDesc2* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc2 (ptr, _pDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterHardwareContentProtectionTeardownStatusEvent (IntPtr hEvent, uint* pdwCookie) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterHardwareContentProtectionTeardownStatusEvent (ptr, hEvent, pdwCookie);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterHardwareContentProtectionTeardownStatusEvent (IntPtr hEvent, out uint pdwCookie) {
		fixed (uint* _pdwCookie = &pdwCookie) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RegisterHardwareContentProtectionTeardownStatusEvent (ptr, hEvent, _pdwCookie);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void UnregisterHardwareContentProtectionTeardownStatus (uint dwCookie) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UnregisterHardwareContentProtectionTeardownStatus (ptr, dwCookie);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryVideoMemoryInfo (uint nodeIndex, MemorySegmentGroup memorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryVideoMemoryInfo (ptr, nodeIndex, memorySegmentGroup, pVideoMemoryInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryVideoMemoryInfo (uint nodeIndex, MemorySegmentGroup memorySegmentGroup, out QueryVideoMemoryInfo pVideoMemoryInfo) {
		fixed (QueryVideoMemoryInfo* _pVideoMemoryInfo = &pVideoMemoryInfo) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->QueryVideoMemoryInfo (ptr, nodeIndex, memorySegmentGroup, _pVideoMemoryInfo);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetVideoMemoryReservation (uint nodeIndex, MemorySegmentGroup memorySegmentGroup, ulong reservation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetVideoMemoryReservation (ptr, nodeIndex, memorySegmentGroup, reservation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterVideoMemoryBudgetChangeNotificationEvent (IntPtr hEvent, uint* pdwCookie) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterVideoMemoryBudgetChangeNotificationEvent (ptr, hEvent, pdwCookie);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterVideoMemoryBudgetChangeNotificationEvent (IntPtr hEvent, out uint pdwCookie) {
		fixed (uint* _pdwCookie = &pdwCookie) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RegisterVideoMemoryBudgetChangeNotificationEvent (ptr, hEvent, _pdwCookie);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void UnregisterVideoMemoryBudgetChangeNotification (uint dwCookie) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->UnregisterVideoMemoryBudgetChangeNotification (ptr, dwCookie);
		return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> EnumOutputs;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AdapterDesc*, int> GetDesc;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, long*, int> CheckInterfaceSupport;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AdapterDesc1*, int> GetDesc1;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AdapterDesc2*, int> GetDesc2;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint*, int> RegisterHardwareContentProtectionTeardownStatusEvent;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> UnregisterHardwareContentProtectionTeardownStatus;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int> QueryVideoMemoryInfo;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, MemorySegmentGroup, ulong, int> SetVideoMemoryReservation;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint*, int> RegisterVideoMemoryBudgetChangeNotificationEvent;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> UnregisterVideoMemoryBudgetChangeNotification;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
