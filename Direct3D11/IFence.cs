using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11Fence</b> : ID3D11DeviceChild<br/>
/// D3D11_3.h
/// </summary>
unsafe public interface IFence : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Fence::CreateSharedHandle (SECURITY_ATTRIBUTES* pAttributes, DWORD dwAccess, LPCWSTR lpName, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pAttributes">_In_opt_ <b>SECURITY_ATTRIBUTES* pAttributes</b></param>
	/// <param name="dwAccess">_In_ <b>DWORD dwAccess</b></param>
	/// <param name="lpName">_In_opt_ <b>LPCWSTR lpName</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int CreateSharedHandle (SecurityAttributes* pAttributes, uint dwAccess, char* lpName, IntPtr* pHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Fence::CreateSharedHandle (SECURITY_ATTRIBUTES* pAttributes, DWORD dwAccess, LPCWSTR lpName, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pAttributes">_In_opt_ <b>SECURITY_ATTRIBUTES* pAttributes</b></param>
	/// <param name="dwAccess">_In_ <b>DWORD dwAccess</b></param>
	/// <param name="lpName">_In_opt_ <b>LPCWSTR lpName</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int CreateSharedHandle (SecurityAttributes* pAttributes, uint dwAccess, char* lpName, out IntPtr pHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D11Fence::GetCompletedValue ()</b><br/>
	/// </summary>
	ulong GetCompletedValue ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11Fence::SetEventOnCompletion (UINT64 Value, HANDLE hEvent)</b><br/>
	/// </summary>
	/// <param name="value">_In_ <b>UINT64 Value</b></param>
	/// <param name="hEvent">_In_ <b>HANDLE hEvent</b></param>
	int SetEventOnCompletion (ulong value, IntPtr hEvent);
}

/// <summary>
/// Instance of <b>ID3D11Fence</b><br/>
/// D3D11_3.h
/// </summary>
unsafe public readonly struct Fence : IFence {
//unsafe public readonly struct IFenceObj : IFence {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Fence* GetCurrentPointer () => (Fence*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFenceObj* GetCurrentPointer () => (IFenceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xaffde9d1, 0x1df7, 0x4bb7, 0x8a, 0x34, 0x0f, 0x46, 0x25, 0x1d, 0xab, 0x80);

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
	public readonly void GetDevice<T0> (T0** ppDevice) where T0 : unmanaged, IDevice {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) ppDevice);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDevice<T0> (out T0* ppDevice) where T0 : unmanaged, IDevice {
		fixed (T0** _ppDevice = &ppDevice) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) _ppDevice);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPrivateData (Guid guid, uint* pDataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrivateData (ptr, guid, pDataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateData (Guid guid, uint dataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateData (ptr, guid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateDataInterface<T0> (Guid guid, T0* pData) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateDataInterface (ptr, guid, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedHandle (SecurityAttributes* pAttributes, uint dwAccess, char* lpName, IntPtr* pHandle) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedHandle (ptr, pAttributes, dwAccess, lpName, pHandle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedHandle (SecurityAttributes* pAttributes, uint dwAccess, char* lpName, out IntPtr pHandle) {
		fixed (IntPtr* _pHandle = &pHandle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedHandle (ptr, pAttributes, dwAccess, lpName, _pHandle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetCompletedValue () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCompletedValue (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetEventOnCompletion (ulong value, IntPtr hEvent) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetEventOnCompletion (ptr, value, hEvent);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetDevice;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SecurityAttributes*, uint, char*, IntPtr*, int> CreateSharedHandle;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetCompletedValue;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, IntPtr, int> SetEventOnCompletion;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
