using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFileStream</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontFileStream : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileStream::ReadFileFragment (void** fragmentStart, UINT64 fileOffset, UINT64 fragmentSize, void** fragmentContext)</b><br/>
	/// </summary>
	/// <param name="fragmentStart">_Outptr_result_bytebuffer_(fragmentSize) <b>void** fragmentStart</b></param>
	/// <param name="fileOffset"><b>UINT64 fileOffset</b></param>
	/// <param name="fragmentSize"><b>UINT64 fragmentSize</b></param>
	/// <param name="fragmentContext">_Out_ <b>void** fragmentContext</b></param>
	int ReadFileFragment (void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileStream::ReadFileFragment (void** fragmentStart, UINT64 fileOffset, UINT64 fragmentSize, void** fragmentContext)</b><br/>
	/// </summary>
	/// <param name="fragmentStart">_Outptr_result_bytebuffer_(fragmentSize) <b>void** fragmentStart</b></param>
	/// <param name="fileOffset"><b>UINT64 fileOffset</b></param>
	/// <param name="fragmentSize"><b>UINT64 fragmentSize</b></param>
	/// <param name="fragmentContext">_Out_ <b>void** fragmentContext</b></param>
	int ReadFileFragment (out void* fragmentStart, ulong fileOffset, ulong fragmentSize, out void* fragmentContext);
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFontFileStream::ReleaseFileFragment (void* fragmentContext)</b><br/>
	/// </summary>
	/// <param name="fragmentContext"><b>void* fragmentContext</b></param>
	void ReleaseFileFragment (void* fragmentContext);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileStream::GetFileSize (UINT64* fileSize)</b><br/>
	/// </summary>
	/// <param name="fileSize">_Out_ <b>UINT64* fileSize</b></param>
	int GetFileSize (ulong* fileSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileStream::GetFileSize (UINT64* fileSize)</b><br/>
	/// </summary>
	/// <param name="fileSize">_Out_ <b>UINT64* fileSize</b></param>
	int GetFileSize (out ulong fileSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileStream::GetLastWriteTime (UINT64* lastWriteTime)</b><br/>
	/// </summary>
	/// <param name="lastWriteTime">_Out_ <b>UINT64* lastWriteTime</b></param>
	int GetLastWriteTime (ulong* lastWriteTime);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileStream::GetLastWriteTime (UINT64* lastWriteTime)</b><br/>
	/// </summary>
	/// <param name="lastWriteTime">_Out_ <b>UINT64* lastWriteTime</b></param>
	int GetLastWriteTime (out ulong lastWriteTime);
}

/// <summary>
/// Instance of <b>IDWriteFontFileStream</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontFileStream : IFontFileStream {
//unsafe public readonly struct IFontFileStreamObj : IFontFileStream {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFileStream* GetCurrentPointer () => (FontFileStream*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFileStreamObj* GetCurrentPointer () => (IFontFileStreamObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x6d4865fe, 0x0ab8, 0x4d91, 0x8f, 0x62, 0x5d, 0xd6, 0xbe, 0x34, 0xa3, 0xe0);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
