using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11ClassInstance</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface IClassInstance : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11ClassInstance::GetClassLinkage (ID3D11ClassLinkage** ppLinkage)</b><br/>
	/// </summary>
	/// <param name="ppLinkage">_Outptr_ <b>ID3D11ClassLinkage** ppLinkage</b></param>
	void GetClassLinkage<T0> (T0** ppLinkage) where T0 : unmanaged, IClassLinkage;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11ClassInstance::GetClassLinkage (ID3D11ClassLinkage** ppLinkage)</b><br/>
	/// </summary>
	/// <param name="ppLinkage">_Outptr_ <b>ID3D11ClassLinkage** ppLinkage</b></param>
	void GetClassLinkage<T0> (out T0* ppLinkage) where T0 : unmanaged, IClassLinkage;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11ClassInstance::GetDesc (D3D11_CLASS_INSTANCE_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_CLASS_INSTANCE_DESC* pDesc</b></param>
	void GetDesc (ClassInstanceDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11ClassInstance::GetDesc (D3D11_CLASS_INSTANCE_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_CLASS_INSTANCE_DESC* pDesc</b></param>
	void GetDesc (out ClassInstanceDesc pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11ClassInstance::GetInstanceName (LPSTR pInstanceName, SIZE_T* pBufferLength)</b><br/>
	/// </summary>
	/// <param name="pInstanceName">_Out_writes_opt_(*pBufferLength) <b>LPSTR pInstanceName</b></param>
	/// <param name="pBufferLength">_Inout_ <b>SIZE_T* pBufferLength</b></param>
	void GetInstanceName (char* pInstanceName, nuint* pBufferLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11ClassInstance::GetTypeName (LPSTR pTypeName, SIZE_T* pBufferLength)</b><br/>
	/// </summary>
	/// <param name="pTypeName">_Out_writes_opt_(*pBufferLength) <b>LPSTR pTypeName</b></param>
	/// <param name="pBufferLength">_Inout_ <b>SIZE_T* pBufferLength</b></param>
	void GetTypeName (char* pTypeName, nuint* pBufferLength);
}

/// <summary>
/// Instance of <b>ID3D11ClassInstance</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct ClassInstance : IClassInstance {
//unsafe public readonly struct IClassInstanceObj : IClassInstance {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ClassInstance* GetCurrentPointer () => (ClassInstance*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IClassInstanceObj* GetCurrentPointer () => (IClassInstanceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa6cd7faa, 0xb0b7, 0x4a2f, 0x94, 0x36, 0x86, 0x62, 0xa6, 0x57, 0x97, 0xcb);

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
	public readonly void GetClassLinkage<T0> (T0** ppLinkage) where T0 : unmanaged, IClassLinkage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetClassLinkage (ptr, (void**) ppLinkage);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetClassLinkage<T0> (out T0* ppLinkage) where T0 : unmanaged, IClassLinkage {
		fixed (T0** _ppLinkage = &ppLinkage) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetClassLinkage (ptr, (void**) _ppLinkage);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (ClassInstanceDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (out ClassInstanceDesc pDesc) {
		fixed (ClassInstanceDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, _pDesc);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetInstanceName (char* pInstanceName, nuint* pBufferLength) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetInstanceName (ptr, pInstanceName, pBufferLength);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTypeName (char* pTypeName, nuint* pBufferLength) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetTypeName (ptr, pTypeName, pBufferLength);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetClassLinkage;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ClassInstanceDesc*, void> GetDesc;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, nuint*, void> GetInstanceName;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, nuint*, void> GetTypeName;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
