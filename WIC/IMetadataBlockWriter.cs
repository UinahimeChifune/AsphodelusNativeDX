using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataBlockWriter</b> : IWICMetadataBlockReader<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IMetadataBlockWriter : IMetadataBlockReader {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockWriter::InitializeFromBlockReader (IWICMetadataBlockReader* pIMDBlockReader)</b><br/>
	/// </summary>
	/// <param name="pIMDBlockReader">__RPC__in_opt <b>IWICMetadataBlockReader* pIMDBlockReader</b></param>
	int InitializeFromBlockReader<T0> (T0* pIMDBlockReader) where T0 : unmanaged, IMetadataBlockReader;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockWriter::GetWriterByIndex (UINT nIndex, IWICMetadataWriter** ppIMetadataWriter)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	/// <param name="ppIMetadataWriter">__RPC__deref_out_opt <b>IWICMetadataWriter** ppIMetadataWriter</b></param>
	int GetWriterByIndex<T0> (uint nIndex, T0** ppIMetadataWriter) where T0 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockWriter::GetWriterByIndex (UINT nIndex, IWICMetadataWriter** ppIMetadataWriter)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	/// <param name="ppIMetadataWriter">__RPC__deref_out_opt <b>IWICMetadataWriter** ppIMetadataWriter</b></param>
	int GetWriterByIndex<T0> (uint nIndex, out T0* ppIMetadataWriter) where T0 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockWriter::AddWriter (IWICMetadataWriter* pIMetadataWriter)</b><br/>
	/// </summary>
	/// <param name="pIMetadataWriter">__RPC__in_opt <b>IWICMetadataWriter* pIMetadataWriter</b></param>
	int AddWriter<T0> (T0* pIMetadataWriter) where T0 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockWriter::SetWriterByIndex (UINT nIndex, IWICMetadataWriter* pIMetadataWriter)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	/// <param name="pIMetadataWriter">__RPC__in_opt <b>IWICMetadataWriter* pIMetadataWriter</b></param>
	int SetWriterByIndex<T0> (uint nIndex, T0* pIMetadataWriter) where T0 : unmanaged, IMetadataWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataBlockWriter::RemoveWriterByIndex (UINT nIndex)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	int RemoveWriterByIndex (uint nIndex);
}

/// <summary>
/// Instance of <b>IWICMetadataBlockWriter</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct MetadataBlockWriter : IMetadataBlockWriter {
//unsafe public readonly struct IMetadataBlockWriterObj : IMetadataBlockWriter {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataBlockWriter* GetCurrentPointer () => (MetadataBlockWriter*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataBlockWriterObj* GetCurrentPointer () => (IMetadataBlockWriterObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x08fb9676, 0xb444, 0x41e8, 0x8d, 0xbe, 0x6a, 0x53, 0xa5, 0x42, 0xbf, 0xf1);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromBlockReader<T0> (T0* pIMDBlockReader) where T0 : unmanaged, IMetadataBlockReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromBlockReader (ptr, pIMDBlockReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWriterByIndex<T0> (uint nIndex, T0** ppIMetadataWriter) where T0 : unmanaged, IMetadataWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetWriterByIndex (ptr, nIndex, (void**) ppIMetadataWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWriterByIndex<T0> (uint nIndex, out T0* ppIMetadataWriter) where T0 : unmanaged, IMetadataWriter {
		fixed (T0** _ppIMetadataWriter = &ppIMetadataWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetWriterByIndex (ptr, nIndex, (void**) _ppIMetadataWriter);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddWriter<T0> (T0* pIMetadataWriter) where T0 : unmanaged, IMetadataWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddWriter (ptr, pIMetadataWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetWriterByIndex<T0> (uint nIndex, T0* pIMetadataWriter) where T0 : unmanaged, IMetadataWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetWriterByIndex (ptr, nIndex, pIMetadataWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveWriterByIndex (uint nIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveWriterByIndex (ptr, nIndex);
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
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> InitializeFromBlockReader;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetWriterByIndex;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AddWriter;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, int> SetWriterByIndex;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemoveWriterByIndex;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
