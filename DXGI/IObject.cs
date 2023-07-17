using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIObject</b> : IUnknown<br/>
/// DXGI.h
/// </summary>
unsafe public interface IObject : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIObject::SetPrivateData (REFGUID Name, UINT DataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>REFGUID Name</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	/// <param name="pData">_In_reads_bytes_(DataSize) <b>void* pData</b></param>
	int SetPrivateData (Guid name, uint dataSize, void* pData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIObject::SetPrivateDataInterface (REFGUID Name, IUnknown* pUnknown)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>REFGUID Name</b></param>
	/// <param name="pUnknown">_In_opt_ <b>IUnknown* pUnknown</b></param>
	int SetPrivateDataInterface<T0> (Guid name, T0* pUnknown) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIObject::GetPrivateData (REFGUID Name, UINT* pDataSize, void* pData)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>REFGUID Name</b></param>
	/// <param name="pDataSize">_Inout_ <b>UINT* pDataSize</b></param>
	/// <param name="pData">_Out_writes_bytes_(*pDataSize) <b>void* pData</b></param>
	int GetPrivateData (Guid name, uint* pDataSize, void* pData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIObject::GetParent (REFIID riid, void** ppParent)</b><br/>
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppParent">_COM_Outptr_ <b>void** ppParent</b></param>
	int GetParent (Guid riid, void** ppParent);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIObject::GetParent (REFIID riid, void** ppParent)</b><br/>
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppParent">_COM_Outptr_ <b>void** ppParent</b></param>
	int GetParent (Guid riid, out void* ppParent);
}

/// <summary>
/// Instance of <b>IDXGIObject</b><br/>
/// DXGI.h
/// </summary>
unsafe public readonly struct Object : IObject {
//unsafe public readonly struct IObjectObj : IObject {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Object* GetCurrentPointer () => (Object*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IObjectObj* GetCurrentPointer () => (IObjectObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xaec22fb8, 0x76f3, 0x4639, 0x9b, 0xe0, 0x28, 0xeb, 0x43, 0xa6, 0x7a, 0x2e);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
