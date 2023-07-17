using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIResource1</b> : IDXGIResource<br/>
/// DXGI1_2.h
/// </summary>
unsafe public interface IResource1 : IResource {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIResource1::CreateSubresourceSurface (UINT index, IDXGISurface2** ppSurface)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT index</b></param>
	/// <param name="ppSurface">_COM_Outptr_ <b>IDXGISurface2** ppSurface</b></param>
	int CreateSubresourceSurface<T0> (uint index, T0** ppSurface) where T0 : unmanaged, ISurface2;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIResource1::CreateSubresourceSurface (UINT index, IDXGISurface2** ppSurface)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT index</b></param>
	/// <param name="ppSurface">_COM_Outptr_ <b>IDXGISurface2** ppSurface</b></param>
	int CreateSubresourceSurface<T0> (uint index, out T0* ppSurface) where T0 : unmanaged, ISurface2;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIResource1::CreateSharedHandle (SECURITY_ATTRIBUTES* pAttributes, DWORD dwAccess, LPCWSTR lpName, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pAttributes">_In_opt_ <b>SECURITY_ATTRIBUTES* pAttributes</b></param>
	/// <param name="dwAccess">_In_ <b>DWORD dwAccess</b></param>
	/// <param name="lpName">_In_opt_ <b>LPCWSTR lpName</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int CreateSharedHandle (SecurityAttributes* pAttributes, uint dwAccess, char* lpName, IntPtr* pHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIResource1::CreateSharedHandle (SECURITY_ATTRIBUTES* pAttributes, DWORD dwAccess, LPCWSTR lpName, HANDLE* pHandle)</b><br/>
	/// </summary>
	/// <param name="pAttributes">_In_opt_ <b>SECURITY_ATTRIBUTES* pAttributes</b></param>
	/// <param name="dwAccess">_In_ <b>DWORD dwAccess</b></param>
	/// <param name="lpName">_In_opt_ <b>LPCWSTR lpName</b></param>
	/// <param name="pHandle">_Out_ <b>HANDLE* pHandle</b></param>
	int CreateSharedHandle (SecurityAttributes* pAttributes, uint dwAccess, char* lpName, out IntPtr pHandle);
}

/// <summary>
/// Instance of <b>IDXGIResource1</b><br/>
/// DXGI1_2.h
/// </summary>
unsafe public readonly struct Resource1 : IResource1 {
//unsafe public readonly struct IResource1Obj : IResource1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Resource1* GetCurrentPointer () => (Resource1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IResource1Obj* GetCurrentPointer () => (IResource1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x30961379, 0x4609, 0x4a41, 0x99, 0x8e, 0x54, 0xfe, 0x56, 0x7e, 0xe0, 0xc1);

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
	public readonly int GetSharedHandle (IntPtr* pSharedHandle) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSharedHandle (ptr, pSharedHandle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSharedHandle (out IntPtr pSharedHandle) {
		fixed (IntPtr* _pSharedHandle = &pSharedHandle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSharedHandle (ptr, _pSharedHandle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetUsage (Usage* pUsage) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetUsage (ptr, pUsage);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetEvictionPriority (uint evictionPriority) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetEvictionPriority (ptr, evictionPriority);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEvictionPriority (uint* pEvictionPriority) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEvictionPriority (ptr, pEvictionPriority);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEvictionPriority (out uint pEvictionPriority) {
		fixed (uint* _pEvictionPriority = &pEvictionPriority) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEvictionPriority (ptr, _pEvictionPriority);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSubresourceSurface<T0> (uint index, T0** ppSurface) where T0 : unmanaged, ISurface2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSubresourceSurface (ptr, index, (void**) ppSurface);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSubresourceSurface<T0> (uint index, out T0* ppSurface) where T0 : unmanaged, ISurface2 {
		fixed (T0** _ppSurface = &ppSurface) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSubresourceSurface (ptr, index, (void**) _ppSurface);
			return hr;
		}
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
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr*, int> GetSharedHandle;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Usage*, int> GetUsage;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetEvictionPriority;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetEvictionPriority;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> CreateSubresourceSurface;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SecurityAttributes*, uint, char*, IntPtr*, int> CreateSharedHandle;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
