using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIAdapter</b> : IDXGIObject<br/>
/// DXGI.h
/// </summary>
unsafe public interface IAdapter : IObject {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter::EnumOutputs (UINT Output, IDXGIOutput** ppOutput)</b><br/>
	/// </summary>
	/// <param name="output"><b>UINT Output</b></param>
	/// <param name="ppOutput">_COM_Outptr_ <b>IDXGIOutput** ppOutput</b></param>
	int EnumOutputs<T0> (uint output, T0** ppOutput) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter::EnumOutputs (UINT Output, IDXGIOutput** ppOutput)</b><br/>
	/// </summary>
	/// <param name="output"><b>UINT Output</b></param>
	/// <param name="ppOutput">_COM_Outptr_ <b>IDXGIOutput** ppOutput</b></param>
	int EnumOutputs<T0> (uint output, out T0* ppOutput) where T0 : unmanaged, IOutput;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter::GetDesc (DXGI_ADAPTER_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_ADAPTER_DESC* pDesc</b></param>
	int GetDesc (AdapterDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter::GetDesc (DXGI_ADAPTER_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_ADAPTER_DESC* pDesc</b></param>
	int GetDesc (out AdapterDesc pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter::CheckInterfaceSupport (REFGUID InterfaceName, LARGE_INTEGER* pUMDVersion)</b><br/>
	/// </summary>
	/// <param name="interfaceName">_In_ <b>REFGUID InterfaceName</b></param>
	/// <param name="pUMDVersion">_Out_ <b>LARGE_INTEGER* pUMDVersion</b></param>
	int CheckInterfaceSupport (Guid interfaceName, long* pUMDVersion);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIAdapter::CheckInterfaceSupport (REFGUID InterfaceName, LARGE_INTEGER* pUMDVersion)</b><br/>
	/// </summary>
	/// <param name="interfaceName">_In_ <b>REFGUID InterfaceName</b></param>
	/// <param name="pUMDVersion">_Out_ <b>LARGE_INTEGER* pUMDVersion</b></param>
	int CheckInterfaceSupport (Guid interfaceName, out long pUMDVersion);
}

/// <summary>
/// Instance of <b>IDXGIAdapter</b><br/>
/// DXGI.h
/// </summary>
unsafe public readonly struct Adapter : IAdapter {
//unsafe public readonly struct IAdapterObj : IAdapter {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Adapter* GetCurrentPointer () => (Adapter*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IAdapterObj* GetCurrentPointer () => (IAdapterObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2411e7e1, 0x12ac, 0x4ccf, 0xbd, 0x14, 0x97, 0x98, 0xe8, 0x53, 0x4d, 0xc0);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
