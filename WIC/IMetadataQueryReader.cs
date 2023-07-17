using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataQueryReader</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IMetadataQueryReader : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryReader::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (Guid* pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryReader::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (out Guid pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryReader::GetLocation (UINT cchMaxLength, WCHAR* wzNamespace, UINT* pcchActualLength)</b><br/>
	/// </summary>
	/// <param name="cchMaxLength"><b>UINT cchMaxLength</b></param>
	/// <param name="wzNamespace">__RPC__inout_ecount_full_opt(cchMaxLength) <b>WCHAR* wzNamespace</b></param>
	/// <param name="pcchActualLength">__RPC__out <b>UINT* pcchActualLength</b></param>
	int GetLocation (uint cchMaxLength, char* wzNamespace, uint* pcchActualLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryReader::GetLocation (UINT cchMaxLength, WCHAR* wzNamespace, UINT* pcchActualLength)</b><br/>
	/// </summary>
	/// <param name="cchMaxLength"><b>UINT cchMaxLength</b></param>
	/// <param name="wzNamespace">__RPC__inout_ecount_full_opt(cchMaxLength) <b>WCHAR* wzNamespace</b></param>
	/// <param name="pcchActualLength">__RPC__out <b>UINT* pcchActualLength</b></param>
	int GetLocation (uint cchMaxLength, char* wzNamespace, out uint pcchActualLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryReader::GetMetadataByName (LPCWSTR wzName, PROPVARIANT* pvarValue)</b><br/>
	/// </summary>
	/// <param name="wzName">__RPC__in <b>LPCWSTR wzName</b></param>
	/// <param name="pvarValue">__RPC__inout_opt <b>PROPVARIANT* pvarValue</b></param>
	int GetMetadataByName (char* wzName, void* pvarValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryReader::GetEnumerator (IEnumString** ppIEnumString)</b><br/>
	/// </summary>
	/// <param name="ppIEnumString">__RPC__deref_out_opt <b>IEnumString** ppIEnumString</b></param>
	int GetEnumerator<T0> (T0** ppIEnumString) where T0 : unmanaged, IEnumString;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryReader::GetEnumerator (IEnumString** ppIEnumString)</b><br/>
	/// </summary>
	/// <param name="ppIEnumString">__RPC__deref_out_opt <b>IEnumString** ppIEnumString</b></param>
	int GetEnumerator<T0> (out T0* ppIEnumString) where T0 : unmanaged, IEnumString;
}

/// <summary>
/// Instance of <b>IWICMetadataQueryReader</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct MetadataQueryReader : IMetadataQueryReader {
//unsafe public readonly struct IMetadataQueryReaderObj : IMetadataQueryReader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataQueryReader* GetCurrentPointer () => (MetadataQueryReader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataQueryReaderObj* GetCurrentPointer () => (IMetadataQueryReaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x30989668, 0xe1c9, 0x4597, 0xb3, 0x95, 0x45, 0x8e, 0xed, 0xb8, 0x08, 0xdf);

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
	public readonly int GetLocation (uint cchMaxLength, char* wzNamespace, uint* pcchActualLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocation (ptr, cchMaxLength, wzNamespace, pcchActualLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocation (uint cchMaxLength, char* wzNamespace, out uint pcchActualLength) {
		fixed (uint* _pcchActualLength = &pcchActualLength) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLocation (ptr, cchMaxLength, wzNamespace, _pcchActualLength);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataByName (char* wzName, void* pvarValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataByName (ptr, wzName, pvarValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEnumerator<T0> (T0** ppIEnumString) where T0 : unmanaged, IEnumString {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEnumerator (ptr, (void**) ppIEnumString);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEnumerator<T0> (out T0* ppIEnumString) where T0 : unmanaged, IEnumString {
		fixed (T0** _ppIEnumString = &ppIEnumString) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEnumerator (ptr, (void**) _ppIEnumString);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetContainerFormat;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetLocation;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*, int> GetMetadataByName;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetEnumerator;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
