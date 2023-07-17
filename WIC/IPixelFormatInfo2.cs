using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICPixelFormatInfo2</b> : IWICPixelFormatInfo<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IPixelFormatInfo2 : IPixelFormatInfo {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPixelFormatInfo2::SupportsTransparency (BOOL* pfSupportsTransparency)</b><br/>
	/// </summary>
	/// <param name="pfSupportsTransparency">__RPC__out <b>BOOL* pfSupportsTransparency</b></param>
	int SupportsTransparency (uint* pfSupportsTransparency);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPixelFormatInfo2::SupportsTransparency (BOOL* pfSupportsTransparency)</b><br/>
	/// </summary>
	/// <param name="pfSupportsTransparency">__RPC__out <b>BOOL* pfSupportsTransparency</b></param>
	int SupportsTransparency (out bool pfSupportsTransparency);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPixelFormatInfo2::GetNumericRepresentation (WICPixelFormatNumericRepresentation* pNumericRepresentation)</b><br/>
	/// </summary>
	/// <param name="pNumericRepresentation">__RPC__out <b>WICPixelFormatNumericRepresentation* pNumericRepresentation</b></param>
	int GetNumericRepresentation (PixelFormatNumericRepresentation* pNumericRepresentation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPixelFormatInfo2::GetNumericRepresentation (WICPixelFormatNumericRepresentation* pNumericRepresentation)</b><br/>
	/// </summary>
	/// <param name="pNumericRepresentation">__RPC__out <b>WICPixelFormatNumericRepresentation* pNumericRepresentation</b></param>
	int GetNumericRepresentation (out PixelFormatNumericRepresentation pNumericRepresentation);
}

/// <summary>
/// Instance of <b>IWICPixelFormatInfo2</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct PixelFormatInfo2 : IPixelFormatInfo2 {
//unsafe public readonly struct IPixelFormatInfo2Obj : IPixelFormatInfo2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PixelFormatInfo2* GetCurrentPointer () => (PixelFormatInfo2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPixelFormatInfo2Obj* GetCurrentPointer () => (IPixelFormatInfo2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa9db33a2, 0xaf5f, 0x43c7, 0xb6, 0x79, 0x74, 0xf5, 0x98, 0x4b, 0x5a, 0xa4);

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
	public readonly int GetFormatGUID (Guid* pFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFormatGUID (ptr, pFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFormatGUID (out Guid pFormat) {
		fixed (Guid* _pFormat = &pFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFormatGUID (ptr, _pFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorContext<T0> (T0** ppIColorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorContext (ptr, (void**) ppIColorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorContext<T0> (out T0* ppIColorContext) where T0 : unmanaged, IColorContext {
		fixed (T0** _ppIColorContext = &ppIColorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetColorContext (ptr, (void**) _ppIColorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBitsPerPixel (uint* puiBitsPerPixel) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBitsPerPixel (ptr, puiBitsPerPixel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBitsPerPixel (out uint puiBitsPerPixel) {
		fixed (uint* _puiBitsPerPixel = &puiBitsPerPixel) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetBitsPerPixel (ptr, _puiBitsPerPixel);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetChannelCount (uint* puiChannelCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetChannelCount (ptr, puiChannelCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetChannelCount (out uint puiChannelCount) {
		fixed (uint* _puiChannelCount = &puiChannelCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetChannelCount (ptr, _puiChannelCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetChannelMask (uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetChannelMask (ptr, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetChannelMask (uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, out uint pcbActual) {
		fixed (uint* _pcbActual = &pcbActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetChannelMask (ptr, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, _pcbActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SupportsTransparency (uint* pfSupportsTransparency) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SupportsTransparency (ptr, pfSupportsTransparency);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SupportsTransparency (out bool pfSupportsTransparency) {
		uint _pfSupportsTransparency;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SupportsTransparency (ptr, &_pfSupportsTransparency);
		pfSupportsTransparency = _pfSupportsTransparency != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNumericRepresentation (PixelFormatNumericRepresentation* pNumericRepresentation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumericRepresentation (ptr, pNumericRepresentation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNumericRepresentation (out PixelFormatNumericRepresentation pNumericRepresentation) {
		fixed (PixelFormatNumericRepresentation* _pNumericRepresentation = &pNumericRepresentation) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetNumericRepresentation (ptr, _pNumericRepresentation);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetFormatGUID;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetColorContext;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetBitsPerPixel;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetChannelCount;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, byte*, uint*, int> GetChannelMask;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> SupportsTransparency;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PixelFormatNumericRepresentation*, int> GetNumericRepresentation;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
