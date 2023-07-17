using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11DeviceChild</b> : IUnknown<br/>
/// D3D11.h
/// </summary>
unsafe public interface IDeviceChild : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceChild::GetDevice (ID3D11Device** ppDevice)</b><br/>
	/// </summary>
	/// <param name="ppDevice">_Outptr_ <b>ID3D11Device** ppDevice</b></param>
	void GetDevice<T0> (T0** ppDevice) where T0 : unmanaged, IDevice;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11DeviceChild::GetDevice (ID3D11Device** ppDevice)</b><br/>
	/// </summary>
	/// <param name="ppDevice">_Outptr_ <b>ID3D11Device** ppDevice</b></param>
	void GetDevice<T0> (out T0* ppDevice) where T0 : unmanaged, IDevice;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceChild::GetPrivateData (REFGUID guid, UINT* pDataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="pDataSize">_Inout_ <b>UINT* pDataSize</b></param>
	/// <param name="pData">_Out_writes_bytes_opt_( *pDataSize ) <b>void* pData</b></param>
	int GetPrivateData (Guid guid, uint* pDataSize, void* pData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceChild::SetPrivateData (REFGUID guid, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="dataSize">_In_ <b>UINT DataSize</b></param>
	/// <param name="pData">_In_reads_bytes_opt_( DataSize ) <b>void* pData</b></param>
	int SetPrivateData (Guid guid, uint dataSize, void* pData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11DeviceChild::SetPrivateDataInterface (REFGUID guid, IUnknown* pData)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="pData">_In_opt_ <b>IUnknown* pData</b></param>
	int SetPrivateDataInterface<T0> (Guid guid, T0* pData) where T0 : unmanaged, IUnknown;
}

/// <summary>
/// Instance of <b>ID3D11DeviceChild</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct DeviceChild : IDeviceChild {
//unsafe public readonly struct IDeviceChildObj : IDeviceChild {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DeviceChild* GetCurrentPointer () => (DeviceChild*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDeviceChildObj* GetCurrentPointer () => (IDeviceChildObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1841e5c8, 0x16b0, 0x489b, 0xbc, 0xc8, 0x44, 0xcf, 0xb0, 0xd5, 0xde, 0xae);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
