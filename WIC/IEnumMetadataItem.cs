using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICEnumMetadataItem</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IEnumMetadataItem : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICEnumMetadataItem::Next (ULONG celt, PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue, ULONG* pceltFetched)</b><br/>
	/// </summary>
	/// <param name="celt"><b>ULONG celt</b></param>
	/// <param name="rgeltSchema">__RPC__inout_ecount_full_opt(celt) <b>PROPVARIANT* rgeltSchema</b></param>
	/// <param name="rgeltId">__RPC__inout_ecount_full(celt) <b>PROPVARIANT* rgeltId</b></param>
	/// <param name="rgeltValue">__RPC__inout_ecount_full(celt) <b>PROPVARIANT* rgeltValue</b></param>
	/// <param name="pceltFetched">__RPC__out <b>ULONG* pceltFetched</b></param>
	int Next (uint celt, void* rgeltSchema, void* rgeltId, void* rgeltValue, uint* pceltFetched);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICEnumMetadataItem::Next (ULONG celt, PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue, ULONG* pceltFetched)</b><br/>
	/// </summary>
	/// <param name="celt"><b>ULONG celt</b></param>
	/// <param name="rgeltSchema">__RPC__inout_ecount_full_opt(celt) <b>PROPVARIANT* rgeltSchema</b></param>
	/// <param name="rgeltId">__RPC__inout_ecount_full(celt) <b>PROPVARIANT* rgeltId</b></param>
	/// <param name="rgeltValue">__RPC__inout_ecount_full(celt) <b>PROPVARIANT* rgeltValue</b></param>
	/// <param name="pceltFetched">__RPC__out <b>ULONG* pceltFetched</b></param>
	int Next (uint celt, void* rgeltSchema, void* rgeltId, void* rgeltValue, out uint pceltFetched);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICEnumMetadataItem::Skip (ULONG celt)</b><br/>
	/// </summary>
	/// <param name="celt"><b>ULONG celt</b></param>
	int Skip (uint celt);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICEnumMetadataItem::Reset ()</b><br/>
	/// </summary>
	int Reset ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICEnumMetadataItem::Clone (IWICEnumMetadataItem** ppIEnumMetadataItem)</b><br/>
	/// </summary>
	/// <param name="ppIEnumMetadataItem">__RPC__deref_out_opt <b>IWICEnumMetadataItem** ppIEnumMetadataItem</b></param>
	int Clone<T0> (T0** ppIEnumMetadataItem) where T0 : unmanaged, IEnumMetadataItem;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICEnumMetadataItem::Clone (IWICEnumMetadataItem** ppIEnumMetadataItem)</b><br/>
	/// </summary>
	/// <param name="ppIEnumMetadataItem">__RPC__deref_out_opt <b>IWICEnumMetadataItem** ppIEnumMetadataItem</b></param>
	int Clone<T0> (out T0* ppIEnumMetadataItem) where T0 : unmanaged, IEnumMetadataItem;
}

/// <summary>
/// Instance of <b>IWICEnumMetadataItem</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct EnumMetadataItem : IEnumMetadataItem {
//unsafe public readonly struct IEnumMetadataItemObj : IEnumMetadataItem {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly EnumMetadataItem* GetCurrentPointer () => (EnumMetadataItem*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IEnumMetadataItemObj* GetCurrentPointer () => (IEnumMetadataItemObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xdc2bb46d, 0x3f07, 0x481e, 0x86, 0x25, 0x22, 0x0c, 0x4a, 0xed, 0xbb, 0x33);

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
	public readonly int Next (uint celt, void* rgeltSchema, void* rgeltId, void* rgeltValue, uint* pceltFetched) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Next (ptr, celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Next (uint celt, void* rgeltSchema, void* rgeltId, void* rgeltValue, out uint pceltFetched) {
		fixed (uint* _pceltFetched = &pceltFetched) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Next (ptr, celt, rgeltSchema, rgeltId, rgeltValue, _pceltFetched);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Skip (uint celt) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Skip (ptr, celt);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Reset () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Reset (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (T0** ppIEnumMetadataItem) where T0 : unmanaged, IEnumMetadataItem {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) ppIEnumMetadataItem);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (out T0* ppIEnumMetadataItem) where T0 : unmanaged, IEnumMetadataItem {
		fixed (T0** _ppIEnumMetadataItem = &ppIEnumMetadataItem) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) _ppIEnumMetadataItem);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, void*, void*, uint*, int> Next;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> Skip;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Reset;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> Clone;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
