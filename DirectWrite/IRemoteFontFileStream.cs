using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteRemoteFontFileStream</b> : IDWriteFontFileStream<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IRemoteFontFileStream : IFontFileStream {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileStream::GetLocalFileSize (UINT64* localFileSize)</b><br/>
	/// </summary>
	/// <param name="localFileSize">_Out_ <b>UINT64* localFileSize</b></param>
	int GetLocalFileSize (ulong* localFileSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileStream::GetLocalFileSize (UINT64* localFileSize)</b><br/>
	/// </summary>
	/// <param name="localFileSize">_Out_ <b>UINT64* localFileSize</b></param>
	int GetLocalFileSize (out ulong localFileSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileStream::GetFileFragmentLocality (UINT64 fileOffset, UINT64 fragmentSize, BOOL* isLocal, UINT64* partialSize)</b><br/>
	/// </summary>
	/// <param name="fileOffset"><b>UINT64 fileOffset</b></param>
	/// <param name="fragmentSize"><b>UINT64 fragmentSize</b></param>
	/// <param name="isLocal">_Out_ <b>BOOL* isLocal</b></param>
	/// <param name="partialSize">_Out_range_(0, fragmentSize) <b>UINT64* partialSize</b></param>
	int GetFileFragmentLocality (ulong fileOffset, ulong fragmentSize, uint* isLocal, ulong* partialSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileStream::GetFileFragmentLocality (UINT64 fileOffset, UINT64 fragmentSize, BOOL* isLocal, UINT64* partialSize)</b><br/>
	/// </summary>
	/// <param name="fileOffset"><b>UINT64 fileOffset</b></param>
	/// <param name="fragmentSize"><b>UINT64 fragmentSize</b></param>
	/// <param name="isLocal">_Out_ <b>BOOL* isLocal</b></param>
	/// <param name="partialSize">_Out_range_(0, fragmentSize) <b>UINT64* partialSize</b></param>
	int GetFileFragmentLocality (ulong fileOffset, ulong fragmentSize, out bool isLocal, out ulong partialSize);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_LOCALITY IDWriteRemoteFontFileStream::GetLocality ()</b><br/>
	/// </summary>
	Locality GetLocality ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileStream::BeginDownload (UUID* downloadOperationID, DWRITE_FILE_FRAGMENT* fileFragments, UINT32 fragmentCount, IDWriteAsyncResult** asyncResult)</b><br/>
	/// </summary>
	/// <param name="downloadOperationID">_In_ <b>UUID* downloadOperationID</b></param>
	/// <param name="fileFragments">_In_reads_(fragmentCount) <b>DWRITE_FILE_FRAGMENT* fileFragments</b></param>
	/// <param name="fragmentCount"><b>UINT32 fragmentCount</b></param>
	/// <param name="asyncResult">_COM_Outptr_result_maybenull_ <b>IDWriteAsyncResult** asyncResult</b></param>
	int BeginDownload<T0> (Guid* downloadOperationID, FileFragment* fileFragments, uint fragmentCount, T0** asyncResult) where T0 : unmanaged, IAsyncResult;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileStream::BeginDownload (UUID* downloadOperationID, DWRITE_FILE_FRAGMENT* fileFragments, UINT32 fragmentCount, IDWriteAsyncResult** asyncResult)</b><br/>
	/// </summary>
	/// <param name="downloadOperationID">_In_ <b>UUID* downloadOperationID</b></param>
	/// <param name="fileFragments">_In_reads_(fragmentCount) <b>DWRITE_FILE_FRAGMENT* fileFragments</b></param>
	/// <param name="fragmentCount"><b>UINT32 fragmentCount</b></param>
	/// <param name="asyncResult">_COM_Outptr_result_maybenull_ <b>IDWriteAsyncResult** asyncResult</b></param>
	int BeginDownload<T0> (Guid* downloadOperationID, FileFragment* fileFragments, uint fragmentCount, out T0* asyncResult) where T0 : unmanaged, IAsyncResult;
}

/// <summary>
/// Instance of <b>IDWriteRemoteFontFileStream</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct RemoteFontFileStream : IRemoteFontFileStream {
//unsafe public readonly struct IRemoteFontFileStreamObj : IRemoteFontFileStream {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly RemoteFontFileStream* GetCurrentPointer () => (RemoteFontFileStream*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IRemoteFontFileStreamObj* GetCurrentPointer () => (IRemoteFontFileStreamObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x4db3757a, 0x2c72, 0x4ed9, 0xb2, 0xb6, 0x1a, 0xba, 0xbe, 0x1a, 0xff, 0x9c);

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
	public readonly int ReadFileFragment (void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReadFileFragment (ptr, fragmentStart, fileOffset, fragmentSize, fragmentContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReadFileFragment (out void* fragmentStart, ulong fileOffset, ulong fragmentSize, out void* fragmentContext) {
		fixed (void** _fragmentStart = &fragmentStart) {
			fixed (void** _fragmentContext = &fragmentContext) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->ReadFileFragment (ptr, _fragmentStart, fileOffset, fragmentSize, _fragmentContext);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ReleaseFileFragment (void* fragmentContext) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ReleaseFileFragment (ptr, fragmentContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileSize (ulong* fileSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFileSize (ptr, fileSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileSize (out ulong fileSize) {
		fixed (ulong* _fileSize = &fileSize) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFileSize (ptr, _fileSize);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLastWriteTime (ulong* lastWriteTime) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLastWriteTime (ptr, lastWriteTime);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLastWriteTime (out ulong lastWriteTime) {
		fixed (ulong* _lastWriteTime = &lastWriteTime) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLastWriteTime (ptr, _lastWriteTime);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocalFileSize (ulong* localFileSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocalFileSize (ptr, localFileSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocalFileSize (out ulong localFileSize) {
		fixed (ulong* _localFileSize = &localFileSize) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLocalFileSize (ptr, _localFileSize);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileFragmentLocality (ulong fileOffset, ulong fragmentSize, uint* isLocal, ulong* partialSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFileFragmentLocality (ptr, fileOffset, fragmentSize, isLocal, partialSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileFragmentLocality (ulong fileOffset, ulong fragmentSize, out bool isLocal, out ulong partialSize) {
		uint _isLocal;
		fixed (ulong* _partialSize = &partialSize) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFileFragmentLocality (ptr, fileOffset, fragmentSize, &_isLocal, _partialSize);
			isLocal = _isLocal != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Locality GetLocality () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocality (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int BeginDownload<T0> (Guid* downloadOperationID, FileFragment* fileFragments, uint fragmentCount, T0** asyncResult) where T0 : unmanaged, IAsyncResult {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->BeginDownload (ptr, downloadOperationID, fileFragments, fragmentCount, (void**) asyncResult);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int BeginDownload<T0> (Guid* downloadOperationID, FileFragment* fileFragments, uint fragmentCount, out T0* asyncResult) where T0 : unmanaged, IAsyncResult {
		fixed (T0** _asyncResult = &asyncResult) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->BeginDownload (ptr, downloadOperationID, fileFragments, fragmentCount, (void**) _asyncResult);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, ulong, ulong, void**, int> ReadFileFragment;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ReleaseFileFragment;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, int> GetFileSize;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, int> GetLastWriteTime;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, int> GetLocalFileSize;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, uint*, ulong*, int> GetFileFragmentLocality;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Locality> GetLocality;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, FileFragment*, uint, void**, int> BeginDownload;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
