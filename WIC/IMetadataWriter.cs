using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataWriter</b> : IWICMetadataReader<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IMetadataWriter : IMetadataReader {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataWriter::SetValue (PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)</b><br/>
	/// </summary>
	/// <param name="pvarSchema">__RPC__in_opt <b>PROPVARIANT* pvarSchema</b></param>
	/// <param name="pvarId">__RPC__in <b>PROPVARIANT* pvarId</b></param>
	/// <param name="pvarValue">__RPC__in <b>PROPVARIANT* pvarValue</b></param>
	int SetValue (void* pvarSchema, void* pvarId, void* pvarValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataWriter::SetValueByIndex (UINT nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	/// <param name="pvarSchema">__RPC__in_opt <b>PROPVARIANT* pvarSchema</b></param>
	/// <param name="pvarId">__RPC__in <b>PROPVARIANT* pvarId</b></param>
	/// <param name="pvarValue">__RPC__in <b>PROPVARIANT* pvarValue</b></param>
	int SetValueByIndex (uint nIndex, void* pvarSchema, void* pvarId, void* pvarValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataWriter::RemoveValue (PROPVARIANT* pvarSchema, PROPVARIANT* pvarId)</b><br/>
	/// </summary>
	/// <param name="pvarSchema">__RPC__in_opt <b>PROPVARIANT* pvarSchema</b></param>
	/// <param name="pvarId">__RPC__in <b>PROPVARIANT* pvarId</b></param>
	int RemoveValue (void* pvarSchema, void* pvarId);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataWriter::RemoveValueByIndex (UINT nIndex)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	int RemoveValueByIndex (uint nIndex);
}

/// <summary>
/// Instance of <b>IWICMetadataWriter</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct MetadataWriter : IMetadataWriter {
//unsafe public readonly struct IMetadataWriterObj : IMetadataWriter {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataWriter* GetCurrentPointer () => (MetadataWriter*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataWriterObj* GetCurrentPointer () => (IMetadataWriterObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xf7836e16, 0x3be0, 0x470b, 0x86, 0xbb, 0x16, 0x0d, 0x0a, 0xec, 0xd7, 0xde);

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
	public readonly int GetMetadataHandlerInfo<T0> (T0** ppIHandler) where T0 : unmanaged, IMetadataHandlerInfo {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataHandlerInfo (ptr, (void**) ppIHandler);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataHandlerInfo<T0> (out T0* ppIHandler) where T0 : unmanaged, IMetadataHandlerInfo {
		fixed (T0** _ppIHandler = &ppIHandler) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataHandlerInfo (ptr, (void**) _ppIHandler);
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
	public readonly int GetValueByIndex (uint nIndex, void* pvarSchema, void* pvarId, void* pvarValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetValueByIndex (ptr, nIndex, pvarSchema, pvarId, pvarValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetValue (void* pvarSchema, void* pvarId, void* pvarValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetValue (ptr, pvarSchema, pvarId, pvarValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEnumerator<T0> (T0** ppIEnumMetadata) where T0 : unmanaged, IEnumMetadataItem {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEnumerator (ptr, (void**) ppIEnumMetadata);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEnumerator<T0> (out T0* ppIEnumMetadata) where T0 : unmanaged, IEnumMetadataItem {
		fixed (T0** _ppIEnumMetadata = &ppIEnumMetadata) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEnumerator (ptr, (void**) _ppIEnumMetadata);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetValue (void* pvarSchema, void* pvarId, void* pvarValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetValue (ptr, pvarSchema, pvarId, pvarValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetValueByIndex (uint nIndex, void* pvarSchema, void* pvarId, void* pvarValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetValueByIndex (ptr, nIndex, pvarSchema, pvarId, pvarValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveValue (void* pvarSchema, void* pvarId) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveValue (ptr, pvarSchema, pvarId);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveValueByIndex (uint nIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveValueByIndex (ptr, nIndex);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetMetadataFormat;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetMetadataHandlerInfo;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetCount;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, void*, void*, int> GetValueByIndex;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int> GetValue;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetEnumerator;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int> SetValue;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, void*, void*, int> SetValueByIndex;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> RemoveValue;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemoveValueByIndex;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
