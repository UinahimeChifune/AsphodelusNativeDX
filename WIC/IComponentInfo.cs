using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICComponentInfo</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IComponentInfo : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetComponentType (WICComponentType* pType)</b><br/>
	/// </summary>
	/// <param name="pType">__RPC__out <b>WICComponentType* pType</b></param>
	int GetComponentType (ComponentType* pType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetComponentType (WICComponentType* pType)</b><br/>
	/// </summary>
	/// <param name="pType">__RPC__out <b>WICComponentType* pType</b></param>
	int GetComponentType (out ComponentType pType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetCLSID (CLSID* pclsid)</b><br/>
	/// </summary>
	/// <param name="pclsid">__RPC__out <b>CLSID* pclsid</b></param>
	int GetCLSID (Guid* pclsid);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetCLSID (CLSID* pclsid)</b><br/>
	/// </summary>
	/// <param name="pclsid">__RPC__out <b>CLSID* pclsid</b></param>
	int GetCLSID (out Guid pclsid);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetSigningStatus (DWORD* pStatus)</b><br/>
	/// </summary>
	/// <param name="pStatus">__RPC__out <b>DWORD* pStatus</b></param>
	int GetSigningStatus (uint* pStatus);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetSigningStatus (DWORD* pStatus)</b><br/>
	/// </summary>
	/// <param name="pStatus">__RPC__out <b>DWORD* pStatus</b></param>
	int GetSigningStatus (out uint pStatus);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetAuthor (UINT cchAuthor, WCHAR* wzAuthor, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchAuthor"><b>UINT cchAuthor</b></param>
	/// <param name="wzAuthor">__RPC__inout_ecount_full_opt(cchAuthor) <b>WCHAR* wzAuthor</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetAuthor (uint cchAuthor, char* wzAuthor, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetAuthor (UINT cchAuthor, WCHAR* wzAuthor, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchAuthor"><b>UINT cchAuthor</b></param>
	/// <param name="wzAuthor">__RPC__inout_ecount_full_opt(cchAuthor) <b>WCHAR* wzAuthor</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetAuthor (uint cchAuthor, char* wzAuthor, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetVendorGUID (GUID* pguidVendor)</b><br/>
	/// </summary>
	/// <param name="pguidVendor">__RPC__out <b>GUID* pguidVendor</b></param>
	int GetVendorGUID (Guid* pguidVendor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetVendorGUID (GUID* pguidVendor)</b><br/>
	/// </summary>
	/// <param name="pguidVendor">__RPC__out <b>GUID* pguidVendor</b></param>
	int GetVendorGUID (out Guid pguidVendor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetVersion (UINT cchVersion, WCHAR* wzVersion, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchVersion"><b>UINT cchVersion</b></param>
	/// <param name="wzVersion">__RPC__inout_ecount_full_opt(cchVersion) <b>WCHAR* wzVersion</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetVersion (uint cchVersion, char* wzVersion, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetVersion (UINT cchVersion, WCHAR* wzVersion, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchVersion"><b>UINT cchVersion</b></param>
	/// <param name="wzVersion">__RPC__inout_ecount_full_opt(cchVersion) <b>WCHAR* wzVersion</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetVersion (uint cchVersion, char* wzVersion, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetSpecVersion (UINT cchSpecVersion, WCHAR* wzSpecVersion, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchSpecVersion"><b>UINT cchSpecVersion</b></param>
	/// <param name="wzSpecVersion">__RPC__inout_ecount_full_opt(cchSpecVersion) <b>WCHAR* wzSpecVersion</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetSpecVersion (uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetSpecVersion (UINT cchSpecVersion, WCHAR* wzSpecVersion, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchSpecVersion"><b>UINT cchSpecVersion</b></param>
	/// <param name="wzSpecVersion">__RPC__inout_ecount_full_opt(cchSpecVersion) <b>WCHAR* wzSpecVersion</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetSpecVersion (uint cchSpecVersion, char* wzSpecVersion, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetFriendlyName (UINT cchFriendlyName, WCHAR* wzFriendlyName, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchFriendlyName"><b>UINT cchFriendlyName</b></param>
	/// <param name="wzFriendlyName">__RPC__inout_ecount_full_opt(cchFriendlyName) <b>WCHAR* wzFriendlyName</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetFriendlyName (uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICComponentInfo::GetFriendlyName (UINT cchFriendlyName, WCHAR* wzFriendlyName, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchFriendlyName"><b>UINT cchFriendlyName</b></param>
	/// <param name="wzFriendlyName">__RPC__inout_ecount_full_opt(cchFriendlyName) <b>WCHAR* wzFriendlyName</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetFriendlyName (uint cchFriendlyName, char* wzFriendlyName, out uint pcchActual);
}

/// <summary>
/// Instance of <b>IWICComponentInfo</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct ComponentInfo : IComponentInfo {
//unsafe public readonly struct IComponentInfoObj : IComponentInfo {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ComponentInfo* GetCurrentPointer () => (ComponentInfo*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IComponentInfoObj* GetCurrentPointer () => (IComponentInfoObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x23bc3f0a, 0x698b, 0x4357, 0x88, 0x6b, 0xf2, 0x4d, 0x50, 0x67, 0x13, 0x34);

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
	public readonly int GetComponentType (ComponentType* pType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetComponentType (ptr, pType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetComponentType (out ComponentType pType) {
		fixed (ComponentType* _pType = &pType) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetComponentType (ptr, _pType);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCLSID (Guid* pclsid) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCLSID (ptr, pclsid);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCLSID (out Guid pclsid) {
		fixed (Guid* _pclsid = &pclsid) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCLSID (ptr, _pclsid);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSigningStatus (uint* pStatus) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSigningStatus (ptr, pStatus);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSigningStatus (out uint pStatus) {
		fixed (uint* _pStatus = &pStatus) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSigningStatus (ptr, _pStatus);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAuthor (uint cchAuthor, char* wzAuthor, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAuthor (ptr, cchAuthor, wzAuthor, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAuthor (uint cchAuthor, char* wzAuthor, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAuthor (ptr, cchAuthor, wzAuthor, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVendorGUID (Guid* pguidVendor) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVendorGUID (ptr, pguidVendor);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVendorGUID (out Guid pguidVendor) {
		fixed (Guid* _pguidVendor = &pguidVendor) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVendorGUID (ptr, _pguidVendor);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVersion (uint cchVersion, char* wzVersion, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVersion (ptr, cchVersion, wzVersion, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVersion (uint cchVersion, char* wzVersion, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVersion (ptr, cchVersion, wzVersion, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSpecVersion (uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSpecVersion (ptr, cchSpecVersion, wzSpecVersion, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSpecVersion (uint cchSpecVersion, char* wzSpecVersion, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSpecVersion (ptr, cchSpecVersion, wzSpecVersion, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFriendlyName (uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFriendlyName (ptr, cchFriendlyName, wzFriendlyName, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFriendlyName (uint cchFriendlyName, char* wzFriendlyName, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFriendlyName (ptr, cchFriendlyName, wzFriendlyName, _pcchActual);
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
		public readonly delegate* unmanaged[Stdcall]<void*, ComponentType*, int> GetComponentType;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetCLSID;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetSigningStatus;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetAuthor;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetVendorGUID;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetVersion;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetSpecVersion;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetFriendlyName;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
