using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VirtualizationGuestDevice</b> : IUnknown<br/>
/// D3D12.h
/// </summary>
unsafe public interface IVirtualizationGuestDevice : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VirtualizationGuestDevice::ShareWithHost (ID3D12DeviceChild* pObject, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pObject">_In_ <b>ID3D12DeviceChild* pObject</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int ShareWithHost<T0> (T0* pObject, IntPtr* pHandle) where T0 : unmanaged, IDeviceChild;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VirtualizationGuestDevice::ShareWithHost (ID3D12DeviceChild* pObject, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pObject">_In_ <b>ID3D12DeviceChild* pObject</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int ShareWithHost<T0> (T0* pObject, out IntPtr pHandle) where T0 : unmanaged, IDeviceChild;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VirtualizationGuestDevice::CreateFenceFd (ID3D12Fence* pFence, UINT64 FenceValue, int* pFenceFd)</b><br/>
	/// </summary>
	/// <param name="pFence">_In_ <b>ID3D12Fence* pFence</b></param>
	/// <param name="fenceValue"><b>UINT64 FenceValue</b></param>
	/// <param name="pFenceFd">_Out_ <b>int* pFenceFd</b></param>
	int CreateFenceFd<T0> (T0* pFence, ulong fenceValue, int* pFenceFd) where T0 : unmanaged, IFence;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VirtualizationGuestDevice::CreateFenceFd (ID3D12Fence* pFence, UINT64 FenceValue, int* pFenceFd)</b><br/>
	/// </summary>
	/// <param name="pFence">_In_ <b>ID3D12Fence* pFence</b></param>
	/// <param name="fenceValue"><b>UINT64 FenceValue</b></param>
	/// <param name="pFenceFd">_Out_ <b>int* pFenceFd</b></param>
	int CreateFenceFd<T0> (T0* pFence, ulong fenceValue, out int pFenceFd) where T0 : unmanaged, IFence;
}

/// <summary>
/// Instance of <b>ID3D12VirtualizationGuestDevice</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct VirtualizationGuestDevice : IVirtualizationGuestDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VirtualizationGuestDevice* GetCurrentPointer () => (VirtualizationGuestDevice*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xbc66d368, 0x7373, 0x4943, 0x87, 0x57, 0xfc, 0x87, 0xdc, 0x79, 0xe4, 0x76);

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
	public readonly int ShareWithHost<T0> (T0* pObject, IntPtr* pHandle) where T0 : unmanaged, IDeviceChild {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ShareWithHost (ptr, pObject, pHandle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ShareWithHost<T0> (T0* pObject, out IntPtr pHandle) where T0 : unmanaged, IDeviceChild {
		fixed (IntPtr* _pHandle = &pHandle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->ShareWithHost (ptr, pObject, _pHandle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFenceFd<T0> (T0* pFence, ulong fenceValue, int* pFenceFd) where T0 : unmanaged, IFence {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFenceFd (ptr, pFence, fenceValue, pFenceFd);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFenceFd<T0> (T0* pFence, ulong fenceValue, out int pFenceFd) where T0 : unmanaged, IFence {
		fixed (int* _pFenceFd = &pFenceFd) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFenceFd (ptr, pFence, fenceValue, _pFenceFd);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, IntPtr*, int> ShareWithHost;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, int*, int> CreateFenceFd;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
