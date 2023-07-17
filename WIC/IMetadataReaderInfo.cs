using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataReaderInfo</b> : IWICMetadataHandlerInfo<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IMetadataReaderInfo : IMetadataHandlerInfo {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReaderInfo::GetPatterns (REFGUID guidContainerFormat, UINT cbSize, WICMetadataPattern* pPattern, UINT* pcCount, UINT* pcbActual)</b><br/>
	/// </summary>
	/// <param name="guidContainerFormat"><b>REFGUID guidContainerFormat</b></param>
	/// <param name="cbSize"><b>UINT cbSize</b></param>
	/// <param name="pPattern">_Out_writes_bytes_to_opt_(cbSize, *pcbActual) <b>WICMetadataPattern* pPattern</b></param>
	/// <param name="pcCount">_Out_opt_ <b>UINT* pcCount</b></param>
	/// <param name="pcbActual">_Out_opt_ <b>UINT* pcbActual</b></param>
	int GetPatterns (Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReaderInfo::GetPatterns (REFGUID guidContainerFormat, UINT cbSize, WICMetadataPattern* pPattern, UINT* pcCount, UINT* pcbActual)</b><br/>
	/// </summary>
	/// <param name="guidContainerFormat"><b>REFGUID guidContainerFormat</b></param>
	/// <param name="cbSize"><b>UINT cbSize</b></param>
	/// <param name="pPattern">_Out_writes_bytes_to_opt_(cbSize, *pcbActual) <b>WICMetadataPattern* pPattern</b></param>
	/// <param name="pcCount">_Out_opt_ <b>UINT* pcCount</b></param>
	/// <param name="pcbActual">_Out_opt_ <b>UINT* pcbActual</b></param>
	int GetPatterns (Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, out uint pcCount, out uint pcbActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReaderInfo::MatchesPattern (REFGUID guidContainerFormat, IStream* pIStream, BOOL* pfMatches)</b><br/>
	/// </summary>
	/// <param name="guidContainerFormat">__RPC__in <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="pfMatches">__RPC__out <b>BOOL* pfMatches</b></param>
	int MatchesPattern<T0> (Guid guidContainerFormat, T0* pIStream, uint* pfMatches) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReaderInfo::MatchesPattern (REFGUID guidContainerFormat, IStream* pIStream, BOOL* pfMatches)</b><br/>
	/// </summary>
	/// <param name="guidContainerFormat">__RPC__in <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="pfMatches">__RPC__out <b>BOOL* pfMatches</b></param>
	int MatchesPattern<T0> (Guid guidContainerFormat, T0* pIStream, out bool pfMatches) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReaderInfo::CreateInstance (IWICMetadataReader** ppIReader)</b><br/>
	/// </summary>
	/// <param name="ppIReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIReader</b></param>
	int CreateInstance<T0> (T0** ppIReader) where T0 : unmanaged, IMetadataReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReaderInfo::CreateInstance (IWICMetadataReader** ppIReader)</b><br/>
	/// </summary>
	/// <param name="ppIReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIReader</b></param>
	int CreateInstance<T0> (out T0* ppIReader) where T0 : unmanaged, IMetadataReader;
}

/// <summary>
/// Instance of <b>IWICMetadataReaderInfo</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct MetadataReaderInfo : IMetadataReaderInfo {
//unsafe public readonly struct IMetadataReaderInfoObj : IMetadataReaderInfo {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataReaderInfo* GetCurrentPointer () => (MetadataReaderInfo*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataReaderInfoObj* GetCurrentPointer () => (IMetadataReaderInfoObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xeebf1f5b, 0x07c1, 0x4447, 0xa3, 0xab, 0x22, 0xac, 0xaf, 0x78, 0xa8, 0x04);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPatterns (Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPatterns (ptr, guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPatterns (Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, out uint pcCount, out uint pcbActual) {
		fixed (uint* _pcCount = &pcCount) {
			fixed (uint* _pcbActual = &pcbActual) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetPatterns (ptr, guidContainerFormat, cbSize, pPattern, _pcCount, _pcbActual);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MatchesPattern<T0> (Guid guidContainerFormat, T0* pIStream, uint* pfMatches) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MatchesPattern (ptr, guidContainerFormat, pIStream, pfMatches);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MatchesPattern<T0> (Guid guidContainerFormat, T0* pIStream, out bool pfMatches) where T0 : unmanaged, IStream {
		uint _pfMatches;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MatchesPattern (ptr, guidContainerFormat, pIStream, &_pfMatches);
		pfMatches = _pfMatches != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateInstance<T0> (T0** ppIReader) where T0 : unmanaged, IMetadataReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateInstance (ptr, (void**) ppIReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateInstance<T0> (out T0* ppIReader) where T0 : unmanaged, IMetadataReader {
		fixed (T0** _ppIReader = &ppIReader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateInstance (ptr, (void**) _ppIReader);
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
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, MetadataPattern*, uint*, uint*, int> GetPatterns;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, uint*, int> MatchesPattern;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateInstance;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
