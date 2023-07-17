using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICMetadataQueryWriter</b> : IWICMetadataQueryReader<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IMetadataQueryWriter : IMetadataQueryReader {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryWriter::SetMetadataByName (LPCWSTR wzName, PROPVARIANT* pvarValue)</b><br/>
	/// </summary>
	/// <param name="wzName">__RPC__in <b>LPCWSTR wzName</b></param>
	/// <param name="pvarValue">__RPC__in <b>PROPVARIANT* pvarValue</b></param>
	int SetMetadataByName (char* wzName, void* pvarValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICMetadataQueryWriter::RemoveMetadataByName (LPCWSTR wzName)</b><br/>
	/// </summary>
	/// <param name="wzName">__RPC__in <b>LPCWSTR wzName</b></param>
	int RemoveMetadataByName (char* wzName);
}

/// <summary>
/// Instance of <b>IWICMetadataQueryWriter</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct MetadataQueryWriter : IMetadataQueryWriter {
//unsafe public readonly struct IMetadataQueryWriterObj : IMetadataQueryWriter {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly MetadataQueryWriter* GetCurrentPointer () => (MetadataQueryWriter*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMetadataQueryWriterObj* GetCurrentPointer () => (IMetadataQueryWriterObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa721791a, 0x0def, 0x4d06, 0xbd, 0x91, 0x21, 0x18, 0xbf, 0x1d, 0xb1, 0x0b);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetMetadataByName (char* wzName, void* pvarValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetMetadataByName (ptr, wzName, pvarValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveMetadataByName (char* wzName) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveMetadataByName (ptr, wzName);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint*, int> GetLocation;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*, int> GetMetadataByName;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetEnumerator;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*, int> SetMetadataByName;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> RemoveMetadataByName;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
