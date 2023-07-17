using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataHandlerInfo</b> : IWICComponentInfo<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IMetadataHandlerInfo : IComponentInfo {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetMetadataFormat (GUID* pguidMetadataFormat)</b><br/>
	/// </summary>
	/// <param name="pguidMetadataFormat">__RPC__out <b>GUID* pguidMetadataFormat</b></param>
	int GetMetadataFormat (Guid* pguidMetadataFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetMetadataFormat (GUID* pguidMetadataFormat)</b><br/>
	/// </summary>
	/// <param name="pguidMetadataFormat">__RPC__out <b>GUID* pguidMetadataFormat</b></param>
	int GetMetadataFormat (out Guid pguidMetadataFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetContainerFormats (UINT cContainerFormats, GUID* pguidContainerFormats, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cContainerFormats"><b>UINT cContainerFormats</b></param>
	/// <param name="pguidContainerFormats">__RPC__inout_ecount_full_opt(cContainerFormats) <b>GUID* pguidContainerFormats</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetContainerFormats (uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetContainerFormats (UINT cContainerFormats, GUID* pguidContainerFormats, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cContainerFormats"><b>UINT cContainerFormats</b></param>
	/// <param name="pguidContainerFormats">__RPC__inout_ecount_full_opt(cContainerFormats) <b>GUID* pguidContainerFormats</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetContainerFormats (uint cContainerFormats, Guid* pguidContainerFormats, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetDeviceManufacturer (UINT cchDeviceManufacturer, WCHAR* wzDeviceManufacturer, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceManufacturer"><b>UINT cchDeviceManufacturer</b></param>
	/// <param name="wzDeviceManufacturer">__RPC__inout_ecount_full_opt(cchDeviceManufacturer) <b>WCHAR* wzDeviceManufacturer</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceManufacturer (uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetDeviceManufacturer (UINT cchDeviceManufacturer, WCHAR* wzDeviceManufacturer, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceManufacturer"><b>UINT cchDeviceManufacturer</b></param>
	/// <param name="wzDeviceManufacturer">__RPC__inout_ecount_full_opt(cchDeviceManufacturer) <b>WCHAR* wzDeviceManufacturer</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceManufacturer (uint cchDeviceManufacturer, char* wzDeviceManufacturer, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetDeviceModels (UINT cchDeviceModels, WCHAR* wzDeviceModels, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceModels"><b>UINT cchDeviceModels</b></param>
	/// <param name="wzDeviceModels">__RPC__inout_ecount_full_opt(cchDeviceModels) <b>WCHAR* wzDeviceModels</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceModels (uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::GetDeviceModels (UINT cchDeviceModels, WCHAR* wzDeviceModels, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceModels"><b>UINT cchDeviceModels</b></param>
	/// <param name="wzDeviceModels">__RPC__inout_ecount_full_opt(cchDeviceModels) <b>WCHAR* wzDeviceModels</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceModels (uint cchDeviceModels, char* wzDeviceModels, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::DoesRequireFullStream (BOOL* pfRequiresFullStream)</b><br/>
	/// </summary>
	/// <param name="pfRequiresFullStream">__RPC__out <b>BOOL* pfRequiresFullStream</b></param>
	int DoesRequireFullStream (uint* pfRequiresFullStream);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::DoesRequireFullStream (BOOL* pfRequiresFullStream)</b><br/>
	/// </summary>
	/// <param name="pfRequiresFullStream">__RPC__out <b>BOOL* pfRequiresFullStream</b></param>
	int DoesRequireFullStream (out bool pfRequiresFullStream);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::DoesSupportPadding (BOOL* pfSupportsPadding)</b><br/>
	/// </summary>
	/// <param name="pfSupportsPadding">__RPC__out <b>BOOL* pfSupportsPadding</b></param>
	int DoesSupportPadding (uint* pfSupportsPadding);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::DoesSupportPadding (BOOL* pfSupportsPadding)</b><br/>
	/// </summary>
	/// <param name="pfSupportsPadding">__RPC__out <b>BOOL* pfSupportsPadding</b></param>
	int DoesSupportPadding (out bool pfSupportsPadding);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::DoesRequireFixedSize (BOOL* pfFixedSize)</b><br/>
	/// </summary>
	/// <param name="pfFixedSize">__RPC__out <b>BOOL* pfFixedSize</b></param>
	int DoesRequireFixedSize (uint* pfFixedSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataHandlerInfo::DoesRequireFixedSize (BOOL* pfFixedSize)</b><br/>
	/// </summary>
	/// <param name="pfFixedSize">__RPC__out <b>BOOL* pfFixedSize</b></param>
	int DoesRequireFixedSize (out bool pfFixedSize);
}

/// <summary>
/// Instance of <b>IWICMetadataHandlerInfo</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct MetadataHandlerInfo : IMetadataHandlerInfo {
//unsafe public readonly struct IMetadataHandlerInfoObj : IMetadataHandlerInfo {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataHandlerInfo* GetCurrentPointer () => (MetadataHandlerInfo*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataHandlerInfoObj* GetCurrentPointer () => (IMetadataHandlerInfoObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xaba958bf, 0xc672, 0x44d1, 0x8d, 0x61, 0xce, 0x6d, 0xf2, 0xe6, 0x82, 0xc2);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataFormat (Guid* pguidMetadataFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataFormat (ptr, pguidMetadataFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataFormat (out Guid pguidMetadataFormat) {
		fixed (Guid* _pguidMetadataFormat = &pguidMetadataFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataFormat (ptr, _pguidMetadataFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContainerFormats (uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetContainerFormats (ptr, cContainerFormats, pguidContainerFormats, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContainerFormats (uint cContainerFormats, Guid* pguidContainerFormats, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetContainerFormats (ptr, cContainerFormats, pguidContainerFormats, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDeviceManufacturer (uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDeviceManufacturer (ptr, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDeviceManufacturer (uint cchDeviceManufacturer, char* wzDeviceManufacturer, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDeviceManufacturer (ptr, cchDeviceManufacturer, wzDeviceManufacturer, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDeviceModels (uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDeviceModels (ptr, cchDeviceModels, wzDeviceModels, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDeviceModels (uint cchDeviceModels, char* wzDeviceModels, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDeviceModels (ptr, cchDeviceModels, wzDeviceModels, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesRequireFullStream (uint* pfRequiresFullStream) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesRequireFullStream (ptr, pfRequiresFullStream);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesRequireFullStream (out bool pfRequiresFullStream) {
		uint _pfRequiresFullStream;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesRequireFullStream (ptr, &_pfRequiresFullStream);
		pfRequiresFullStream = _pfRequiresFullStream != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportPadding (uint* pfSupportsPadding) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportPadding (ptr, pfSupportsPadding);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportPadding (out bool pfSupportsPadding) {
		uint _pfSupportsPadding;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportPadding (ptr, &_pfSupportsPadding);
		pfSupportsPadding = _pfSupportsPadding != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesRequireFixedSize (uint* pfFixedSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesRequireFixedSize (ptr, pfFixedSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesRequireFixedSize (out bool pfFixedSize) {
		uint _pfFixedSize;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesRequireFixedSize (ptr, &_pfFixedSize);
		pfFixedSize = _pfFixedSize != 0;
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
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetMetadataFormat;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Guid*, uint*, int> GetContainerFormats;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetDeviceManufacturer;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetDeviceModels;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesRequireFullStream;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesSupportPadding;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesRequireFixedSize;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
