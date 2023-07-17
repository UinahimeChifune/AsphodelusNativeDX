using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataBlockReader</b> : IUnknown<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IMetadataBlockReader : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (Guid* pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetContainerFormat (GUID* pguidContainerFormat)</b><br/>
	/// </summary>
	/// <param name="pguidContainerFormat">__RPC__out <b>GUID* pguidContainerFormat</b></param>
	int GetContainerFormat (out Guid pguidContainerFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetCount (UINT* pcCount)</b><br/>
	/// </summary>
	/// <param name="pcCount">__RPC__out <b>UINT* pcCount</b></param>
	int GetCount (uint* pcCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetCount (UINT* pcCount)</b><br/>
	/// </summary>
	/// <param name="pcCount">__RPC__out <b>UINT* pcCount</b></param>
	int GetCount (out uint pcCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetReaderByIndex (UINT nIndex, IWICMetadataReader** ppIMetadataReader)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	/// <param name="ppIMetadataReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIMetadataReader</b></param>
	int GetReaderByIndex<T0> (uint nIndex, T0** ppIMetadataReader) where T0 : unmanaged, IMetadataReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetReaderByIndex (UINT nIndex, IWICMetadataReader** ppIMetadataReader)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	/// <param name="ppIMetadataReader">__RPC__deref_out_opt <b>IWICMetadataReader** ppIMetadataReader</b></param>
	int GetReaderByIndex<T0> (uint nIndex, out T0* ppIMetadataReader) where T0 : unmanaged, IMetadataReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetEnumerator (IEnumUnknown** ppIEnumMetadata)</b><br/>
	/// </summary>
	/// <param name="ppIEnumMetadata">__RPC__deref_out_opt <b>IEnumUnknown** ppIEnumMetadata</b></param>
	int GetEnumerator<T0> (T0** ppIEnumMetadata) where T0 : unmanaged, IEnumUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockReader::GetEnumerator (IEnumUnknown** ppIEnumMetadata)</b><br/>
	/// </summary>
	/// <param name="ppIEnumMetadata">__RPC__deref_out_opt <b>IEnumUnknown** ppIEnumMetadata</b></param>
	int GetEnumerator<T0> (out T0* ppIEnumMetadata) where T0 : unmanaged, IEnumUnknown;
}

/// <summary>
/// Instance of <b>IWICMetadataBlockReader</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct MetadataBlockReader : IMetadataBlockReader {
//unsafe public readonly struct IMetadataBlockReaderObj : IMetadataBlockReader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataBlockReader* GetCurrentPointer () => (MetadataBlockReader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataBlockReaderObj* GetCurrentPointer () => (IMetadataBlockReaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xfeaa2a8d, 0xb3f3, 0x43e4, 0xb2, 0x5c, 0xd1, 0xde, 0x99, 0x0a, 0x1a, 0xe1);

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
	public readonly int GetCount (uint* pcCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCount (ptr, pcCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCount (out uint pcCount) {
		fixed (uint* _pcCount = &pcCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCount (ptr, _pcCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetReaderByIndex<T0> (uint nIndex, T0** ppIMetadataReader) where T0 : unmanaged, IMetadataReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetReaderByIndex (ptr, nIndex, (void**) ppIMetadataReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetReaderByIndex<T0> (uint nIndex, out T0* ppIMetadataReader) where T0 : unmanaged, IMetadataReader {
		fixed (T0** _ppIMetadataReader = &ppIMetadataReader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetReaderByIndex (ptr, nIndex, (void**) _ppIMetadataReader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEnumerator<T0> (T0** ppIEnumMetadata) where T0 : unmanaged, IEnumUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEnumerator (ptr, (void**) ppIEnumMetadata);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEnumerator<T0> (out T0* ppIEnumMetadata) where T0 : unmanaged, IEnumUnknown {
		fixed (T0** _ppIEnumMetadata = &ppIEnumMetadata) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEnumerator (ptr, (void**) _ppIEnumMetadata);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetCount;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetReaderByIndex;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetEnumerator;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
