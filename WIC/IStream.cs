using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICStream</b> : IStream<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IStream : AsphodelusNative.IStream {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStream::InitializeFromIStream (IStream* pIStream)</b><br/>
	/// </summary>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	int InitializeFromIStream<T0> (T0* pIStream) where T0 : unmanaged, AsphodelusNative.IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStream::InitializeFromFilename (LPCWSTR wzFileName, DWORD dwDesiredAccess)</b><br/>
	/// </summary>
	/// <param name="wzFileName">__RPC__in <b>LPCWSTR wzFileName</b></param>
	/// <param name="dwDesiredAccess"><b>DWORD dwDesiredAccess</b></param>
	int InitializeFromFilename (char* wzFileName, uint dwDesiredAccess);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStream::InitializeFromMemory (WICInProcPointer pbBuffer, DWORD cbBufferSize)</b><br/>
	/// </summary>
	/// <param name="pbBuffer">__RPC__in_ecount_full(cbBufferSize) <b>WICInProcPointer pbBuffer</b></param>
	/// <param name="cbBufferSize"><b>DWORD cbBufferSize</b></param>
	int InitializeFromMemory (IntPtr pbBuffer, uint cbBufferSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStream::InitializeFromIStreamRegion (IStream* pIStream, ULARGE_INTEGER ulOffset, ULARGE_INTEGER ulMaxSize)</b><br/>
	/// </summary>
	/// <param name="pIStream">__RPC__in_opt <b>IStream* pIStream</b></param>
	/// <param name="ulOffset"><b>ULARGE_INTEGER ulOffset</b></param>
	/// <param name="ulMaxSize"><b>ULARGE_INTEGER ulMaxSize</b></param>
	int InitializeFromIStreamRegion<T0> (T0* pIStream, ulong ulOffset, ulong ulMaxSize) where T0 : unmanaged, AsphodelusNative.IStream;
}

/// <summary>
/// Instance of <b>IWICStream</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct Stream : IStream {
//unsafe public readonly struct IStreamObj : IStream {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Stream* GetCurrentPointer () => (Stream*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IStreamObj* GetCurrentPointer () => (IStreamObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x135ff860, 0x22b7, 0x4ddf, 0xb0, 0xf6, 0x21, 0x8f, 0x4f, 0x29, 0x9a, 0x43);

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
	public readonly int Read (void* pv, uint cb, uint* pcbRead) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Read (ptr, pv, cb, pcbRead);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Read (void* pv, uint cb, out uint pcbRead) {
		fixed (uint* _pcbRead = &pcbRead) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Read (ptr, pv, cb, _pcbRead);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Write (void* pv, uint cb, uint* pcbWritten) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Write (ptr, pv, cb, pcbWritten);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Write (void* pv, uint cb, out uint pcbWritten) {
		fixed (uint* _pcbWritten = &pcbWritten) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Write (ptr, pv, cb, _pcbWritten);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Seek (long dlibMove, uint dwOrigin, ulong* plibNewPosition) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Seek (ptr, dlibMove, dwOrigin, plibNewPosition);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Seek (long dlibMove, uint dwOrigin, out ulong plibNewPosition) {
		fixed (ulong* _plibNewPosition = &plibNewPosition) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Seek (ptr, dlibMove, dwOrigin, _plibNewPosition);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSize (ulong libNewSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSize (ptr, libNewSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyTo<T0> (T0* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten) where T0 : unmanaged, AsphodelusNative.IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyTo (ptr, pstm, cb, pcbRead, pcbWritten);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyTo<T0> (T0* pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten) where T0 : unmanaged, AsphodelusNative.IStream {
		fixed (ulong* _pcbRead = &pcbRead) {
			fixed (ulong* _pcbWritten = &pcbWritten) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->CopyTo (ptr, pstm, cb, _pcbRead, _pcbWritten);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Commit (uint grfCommitFlags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Commit (ptr, grfCommitFlags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Revert () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Revert (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LockRegion (ulong libOffset, ulong cb, uint dwLockType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LockRegion (ptr, libOffset, cb, dwLockType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnlockRegion (ulong libOffset, ulong cb, uint dwLockType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnlockRegion (ptr, libOffset, cb, dwLockType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Stat (STATSTG* pstatstg, uint grfStatFlag) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Stat (ptr, pstatstg, grfStatFlag);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Stat (out STATSTG pstatstg, uint grfStatFlag) {
		fixed (STATSTG* _pstatstg = &pstatstg) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Stat (ptr, _pstatstg, grfStatFlag);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (T0** ppstm) where T0 : unmanaged, AsphodelusNative.IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) ppstm);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (out T0* ppstm) where T0 : unmanaged, AsphodelusNative.IStream {
		fixed (T0** _ppstm = &ppstm) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) _ppstm);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromIStream<T0> (T0* pIStream) where T0 : unmanaged, AsphodelusNative.IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromIStream (ptr, pIStream);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromFilename (char* wzFileName, uint dwDesiredAccess) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromFilename (ptr, wzFileName, dwDesiredAccess);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromMemory (IntPtr pbBuffer, uint cbBufferSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromMemory (ptr, pbBuffer, cbBufferSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromIStreamRegion<T0> (T0* pIStream, ulong ulOffset, ulong ulMaxSize) where T0 : unmanaged, AsphodelusNative.IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromIStreamRegion (ptr, pIStream, ulOffset, ulMaxSize);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, int> Read;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, int> Write;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, long, uint, ulong*, int> Seek;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, int> SetSize;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, ulong*, ulong*, int> CopyTo;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> Commit;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Revert;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, uint, int> LockRegion;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, uint, int> UnlockRegion;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, STATSTG*, uint, int> Stat;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> Clone;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> InitializeFromIStream;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> InitializeFromFilename;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint, int> InitializeFromMemory;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, ulong, int> InitializeFromIStreamRegion;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
