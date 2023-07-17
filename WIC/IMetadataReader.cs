using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataReader</b> : IUnknown<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IMetadataReader : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetMetadataFormat (GUID* pguidMetadataFormat)</b><br/>
	/// </summary>
	/// <param name="pguidMetadataFormat">__RPC__out <b>GUID* pguidMetadataFormat</b></param>
	int GetMetadataFormat (Guid* pguidMetadataFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetMetadataFormat (GUID* pguidMetadataFormat)</b><br/>
	/// </summary>
	/// <param name="pguidMetadataFormat">__RPC__out <b>GUID* pguidMetadataFormat</b></param>
	int GetMetadataFormat (out Guid pguidMetadataFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetMetadataHandlerInfo (IWICMetadataHandlerInfo** ppIHandler)</b><br/>
	/// </summary>
	/// <param name="ppIHandler">__RPC__deref_out_opt <b>IWICMetadataHandlerInfo** ppIHandler</b></param>
	int GetMetadataHandlerInfo<T0> (T0** ppIHandler) where T0 : unmanaged, IMetadataHandlerInfo;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetMetadataHandlerInfo (IWICMetadataHandlerInfo** ppIHandler)</b><br/>
	/// </summary>
	/// <param name="ppIHandler">__RPC__deref_out_opt <b>IWICMetadataHandlerInfo** ppIHandler</b></param>
	int GetMetadataHandlerInfo<T0> (out T0* ppIHandler) where T0 : unmanaged, IMetadataHandlerInfo;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetCount (UINT* pcCount)</b><br/>
	/// </summary>
	/// <param name="pcCount">__RPC__out <b>UINT* pcCount</b></param>
	int GetCount (uint* pcCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetCount (UINT* pcCount)</b><br/>
	/// </summary>
	/// <param name="pcCount">__RPC__out <b>UINT* pcCount</b></param>
	int GetCount (out uint pcCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetValueByIndex (UINT nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)</b><br/>
	/// </summary>
	/// <param name="nIndex"><b>UINT nIndex</b></param>
	/// <param name="pvarSchema">__RPC__inout_opt <b>PROPVARIANT* pvarSchema</b></param>
	/// <param name="pvarId">__RPC__inout_opt <b>PROPVARIANT* pvarId</b></param>
	/// <param name="pvarValue">__RPC__inout_opt <b>PROPVARIANT* pvarValue</b></param>
	int GetValueByIndex (uint nIndex, void* pvarSchema, void* pvarId, void* pvarValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetValue (PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)</b><br/>
	/// </summary>
	/// <param name="pvarSchema">__RPC__in_opt <b>PROPVARIANT* pvarSchema</b></param>
	/// <param name="pvarId">__RPC__in <b>PROPVARIANT* pvarId</b></param>
	/// <param name="pvarValue">__RPC__inout_opt <b>PROPVARIANT* pvarValue</b></param>
	int GetValue (void* pvarSchema, void* pvarId, void* pvarValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetEnumerator (IWICEnumMetadataItem** ppIEnumMetadata)</b><br/>
	/// </summary>
	/// <param name="ppIEnumMetadata">__RPC__deref_out_opt <b>IWICEnumMetadataItem** ppIEnumMetadata</b></param>
	int GetEnumerator<T0> (T0** ppIEnumMetadata) where T0 : unmanaged, IEnumMetadataItem;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataReader::GetEnumerator (IWICEnumMetadataItem** ppIEnumMetadata)</b><br/>
	/// </summary>
	/// <param name="ppIEnumMetadata">__RPC__deref_out_opt <b>IWICEnumMetadataItem** ppIEnumMetadata</b></param>
	int GetEnumerator<T0> (out T0* ppIEnumMetadata) where T0 : unmanaged, IEnumMetadataItem;
}

/// <summary>
/// Instance of <b>IWICMetadataReader</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct MetadataReader : IMetadataReader {
//unsafe public readonly struct IMetadataReaderObj : IMetadataReader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataReader* GetCurrentPointer () => (MetadataReader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataReaderObj* GetCurrentPointer () => (IMetadataReaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9204fe99, 0xd8fc, 0x4fd5, 0xa0, 0x01, 0x95, 0x36, 0xb0, 0x67, 0xa8, 0x99);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
