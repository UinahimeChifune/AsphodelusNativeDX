using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapCodecInfo</b> : IWICComponentInfo<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapCodecInfo : IComponentInfo {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (Guid* pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (out Guid pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetPixelFormats (UINT cFormats, GUID* pguidPixelFormats, UINT* pcActual)</b><br/>
	/// </summary>
	/// <param name="cFormats"><b>UINT cFormats</b></param>
	/// <param name="pguidPixelFormats">__RPC__inout_ecount_full_opt(cFormats) <b>GUID* pguidPixelFormats</b></param>
	/// <param name="pcActual">__RPC__out <b>UINT* pcActual</b></param>
	int GetPixelFormats (uint cFormats, Guid* pguidPixelFormats, uint* pcActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetPixelFormats (UINT cFormats, GUID* pguidPixelFormats, UINT* pcActual)</b><br/>
	/// </summary>
	/// <param name="cFormats"><b>UINT cFormats</b></param>
	/// <param name="pguidPixelFormats">__RPC__inout_ecount_full_opt(cFormats) <b>GUID* pguidPixelFormats</b></param>
	/// <param name="pcActual">__RPC__out <b>UINT* pcActual</b></param>
	int GetPixelFormats (uint cFormats, Guid* pguidPixelFormats, out uint pcActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetColorManagementVersion (UINT cchColorManagementVersion, WCHAR* wzColorManagementVersion, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchColorManagementVersion"><b>UINT cchColorManagementVersion</b></param>
	/// <param name="wzColorManagementVersion">__RPC__inout_ecount_full_opt(cchColorManagementVersion) <b>WCHAR* wzColorManagementVersion</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetColorManagementVersion (uint cchColorManagementVersion, char* wzColorManagementVersion, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetColorManagementVersion (UINT cchColorManagementVersion, WCHAR* wzColorManagementVersion, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchColorManagementVersion"><b>UINT cchColorManagementVersion</b></param>
	/// <param name="wzColorManagementVersion">__RPC__inout_ecount_full_opt(cchColorManagementVersion) <b>WCHAR* wzColorManagementVersion</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetColorManagementVersion (uint cchColorManagementVersion, char* wzColorManagementVersion, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetDeviceManufacturer (UINT cchDeviceManufacturer, WCHAR* wzDeviceManufacturer, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceManufacturer"><b>UINT cchDeviceManufacturer</b></param>
	/// <param name="wzDeviceManufacturer">__RPC__inout_ecount_full_opt(cchDeviceManufacturer) <b>WCHAR* wzDeviceManufacturer</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceManufacturer (uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetDeviceManufacturer (UINT cchDeviceManufacturer, WCHAR* wzDeviceManufacturer, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceManufacturer"><b>UINT cchDeviceManufacturer</b></param>
	/// <param name="wzDeviceManufacturer">__RPC__inout_ecount_full_opt(cchDeviceManufacturer) <b>WCHAR* wzDeviceManufacturer</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceManufacturer (uint cchDeviceManufacturer, char* wzDeviceManufacturer, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetDeviceModels (UINT cchDeviceModels, WCHAR* wzDeviceModels, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceModels"><b>UINT cchDeviceModels</b></param>
	/// <param name="wzDeviceModels">__RPC__inout_ecount_full_opt(cchDeviceModels) <b>WCHAR* wzDeviceModels</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceModels (uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetDeviceModels (UINT cchDeviceModels, WCHAR* wzDeviceModels, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchDeviceModels"><b>UINT cchDeviceModels</b></param>
	/// <param name="wzDeviceModels">__RPC__inout_ecount_full_opt(cchDeviceModels) <b>WCHAR* wzDeviceModels</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetDeviceModels (uint cchDeviceModels, char* wzDeviceModels, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetMimeTypes (UINT cchMimeTypes, WCHAR* wzMimeTypes, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchMimeTypes"><b>UINT cchMimeTypes</b></param>
	/// <param name="wzMimeTypes">__RPC__inout_ecount_full_opt(cchMimeTypes) <b>WCHAR* wzMimeTypes</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetMimeTypes (uint cchMimeTypes, char* wzMimeTypes, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetMimeTypes (UINT cchMimeTypes, WCHAR* wzMimeTypes, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchMimeTypes"><b>UINT cchMimeTypes</b></param>
	/// <param name="wzMimeTypes">__RPC__inout_ecount_full_opt(cchMimeTypes) <b>WCHAR* wzMimeTypes</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetMimeTypes (uint cchMimeTypes, char* wzMimeTypes, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetFileExtensions (UINT cchFileExtensions, WCHAR* wzFileExtensions, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchFileExtensions"><b>UINT cchFileExtensions</b></param>
	/// <param name="wzFileExtensions">__RPC__inout_ecount_full_opt(cchFileExtensions) <b>WCHAR* wzFileExtensions</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetFileExtensions (uint cchFileExtensions, char* wzFileExtensions, uint* pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::GetFileExtensions (UINT cchFileExtensions, WCHAR* wzFileExtensions, UINT* pcchActual)</b><br/>
	/// </summary>
	/// <param name="cchFileExtensions"><b>UINT cchFileExtensions</b></param>
	/// <param name="wzFileExtensions">__RPC__inout_ecount_full_opt(cchFileExtensions) <b>WCHAR* wzFileExtensions</b></param>
	/// <param name="pcchActual">__RPC__out <b>UINT* pcchActual</b></param>
	int GetFileExtensions (uint cchFileExtensions, char* wzFileExtensions, out uint pcchActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportAnimation (BOOL* pfSupportAnimation)</b><br/>
	/// </summary>
	/// <param name="pfSupportAnimation">__RPC__out <b>BOOL* pfSupportAnimation</b></param>
	int DoesSupportAnimation (uint* pfSupportAnimation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportAnimation (BOOL* pfSupportAnimation)</b><br/>
	/// </summary>
	/// <param name="pfSupportAnimation">__RPC__out <b>BOOL* pfSupportAnimation</b></param>
	int DoesSupportAnimation (out bool pfSupportAnimation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportChromakey (BOOL* pfSupportChromakey)</b><br/>
	/// </summary>
	/// <param name="pfSupportChromakey">__RPC__out <b>BOOL* pfSupportChromakey</b></param>
	int DoesSupportChromakey (uint* pfSupportChromakey);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportChromakey (BOOL* pfSupportChromakey)</b><br/>
	/// </summary>
	/// <param name="pfSupportChromakey">__RPC__out <b>BOOL* pfSupportChromakey</b></param>
	int DoesSupportChromakey (out bool pfSupportChromakey);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportLossless (BOOL* pfSupportLossless)</b><br/>
	/// </summary>
	/// <param name="pfSupportLossless">__RPC__out <b>BOOL* pfSupportLossless</b></param>
	int DoesSupportLossless (uint* pfSupportLossless);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportLossless (BOOL* pfSupportLossless)</b><br/>
	/// </summary>
	/// <param name="pfSupportLossless">__RPC__out <b>BOOL* pfSupportLossless</b></param>
	int DoesSupportLossless (out bool pfSupportLossless);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportMultiframe (BOOL* pfSupportMultiframe)</b><br/>
	/// </summary>
	/// <param name="pfSupportMultiframe">__RPC__out <b>BOOL* pfSupportMultiframe</b></param>
	int DoesSupportMultiframe (uint* pfSupportMultiframe);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::DoesSupportMultiframe (BOOL* pfSupportMultiframe)</b><br/>
	/// </summary>
	/// <param name="pfSupportMultiframe">__RPC__out <b>BOOL* pfSupportMultiframe</b></param>
	int DoesSupportMultiframe (out bool pfSupportMultiframe);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::MatchesMimeType (LPCWSTR wzMimeType, BOOL* pfMatches)</b><br/>
	/// </summary>
	/// <param name="wzMimeType">__RPC__in <b>LPCWSTR wzMimeType</b></param>
	/// <param name="pfMatches">__RPC__out <b>BOOL* pfMatches</b></param>
	int MatchesMimeType (char* wzMimeType, uint* pfMatches);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecInfo::MatchesMimeType (LPCWSTR wzMimeType, BOOL* pfMatches)</b><br/>
	/// </summary>
	/// <param name="wzMimeType">__RPC__in <b>LPCWSTR wzMimeType</b></param>
	/// <param name="pfMatches">__RPC__out <b>BOOL* pfMatches</b></param>
	int MatchesMimeType (char* wzMimeType, out bool pfMatches);
}

/// <summary>
/// Instance of <b>IWICBitmapCodecInfo</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapCodecInfo : IBitmapCodecInfo {
//unsafe public readonly struct IBitmapCodecInfoObj : IBitmapCodecInfo {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapCodecInfo* GetCurrentPointer () => (BitmapCodecInfo*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapCodecInfoObj* GetCurrentPointer () => (IBitmapCodecInfoObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xe87a44c4, 0xb76e, 0x4c47, 0x8b, 0x09, 0x29, 0x8e, 0xb1, 0x2a, 0x27, 0x14);

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
	public readonly int GetContainerFormat (Guid* pguidContainerFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetContainerFormat (ptr, pguidContainerFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContainerFormat (out Guid pguidContainerFormat) {
		fixed (Guid* _pguidContainerFormat = &pguidContainerFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetContainerFormat (ptr, _pguidContainerFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormats (uint cFormats, Guid* pguidPixelFormats, uint* pcActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormats (ptr, cFormats, pguidPixelFormats, pcActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormats (uint cFormats, Guid* pguidPixelFormats, out uint pcActual) {
		fixed (uint* _pcActual = &pcActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormats (ptr, cFormats, pguidPixelFormats, _pcActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorManagementVersion (uint cchColorManagementVersion, char* wzColorManagementVersion, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorManagementVersion (ptr, cchColorManagementVersion, wzColorManagementVersion, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorManagementVersion (uint cchColorManagementVersion, char* wzColorManagementVersion, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetColorManagementVersion (ptr, cchColorManagementVersion, wzColorManagementVersion, _pcchActual);
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
	public readonly int GetMimeTypes (uint cchMimeTypes, char* wzMimeTypes, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMimeTypes (ptr, cchMimeTypes, wzMimeTypes, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMimeTypes (uint cchMimeTypes, char* wzMimeTypes, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMimeTypes (ptr, cchMimeTypes, wzMimeTypes, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileExtensions (uint cchFileExtensions, char* wzFileExtensions, uint* pcchActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFileExtensions (ptr, cchFileExtensions, wzFileExtensions, pcchActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileExtensions (uint cchFileExtensions, char* wzFileExtensions, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFileExtensions (ptr, cchFileExtensions, wzFileExtensions, _pcchActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportAnimation (uint* pfSupportAnimation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportAnimation (ptr, pfSupportAnimation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportAnimation (out bool pfSupportAnimation) {
		uint _pfSupportAnimation;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportAnimation (ptr, &_pfSupportAnimation);
		pfSupportAnimation = _pfSupportAnimation != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportChromakey (uint* pfSupportChromakey) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportChromakey (ptr, pfSupportChromakey);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportChromakey (out bool pfSupportChromakey) {
		uint _pfSupportChromakey;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportChromakey (ptr, &_pfSupportChromakey);
		pfSupportChromakey = _pfSupportChromakey != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportLossless (uint* pfSupportLossless) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportLossless (ptr, pfSupportLossless);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportLossless (out bool pfSupportLossless) {
		uint _pfSupportLossless;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportLossless (ptr, &_pfSupportLossless);
		pfSupportLossless = _pfSupportLossless != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportMultiframe (uint* pfSupportMultiframe) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportMultiframe (ptr, pfSupportMultiframe);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportMultiframe (out bool pfSupportMultiframe) {
		uint _pfSupportMultiframe;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportMultiframe (ptr, &_pfSupportMultiframe);
		pfSupportMultiframe = _pfSupportMultiframe != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MatchesMimeType (char* wzMimeType, uint* pfMatches) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MatchesMimeType (ptr, wzMimeType, pfMatches);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MatchesMimeType (char* wzMimeType, out bool pfMatches) {
		uint _pfMatches;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MatchesMimeType (ptr, wzMimeType, &_pfMatches);
		pfMatches = _pfMatches != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetContainerFormat;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Guid*, uint*, int> GetPixelFormats;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetColorManagementVersion;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetDeviceManufacturer;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetDeviceModels;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetMimeTypes;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetFileExtensions;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesSupportAnimation;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesSupportChromakey;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesSupportLossless;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesSupportMultiframe;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint*, int> MatchesMimeType;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
