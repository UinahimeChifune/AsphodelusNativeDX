using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteLocalFontFileLoader</b> : IDWriteFontFileLoader<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ILocalFontFileLoader : IFontFileLoader {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalFontFileLoader::GetFilePathLengthFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, UINT32* filePathLength)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="filePathLength">_Out_ <b>UINT32* filePathLength</b></param>
	int GetFilePathLengthFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, uint* filePathLength);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalFontFileLoader::GetFilePathLengthFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, UINT32* filePathLength)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="filePathLength">_Out_ <b>UINT32* filePathLength</b></param>
	int GetFilePathLengthFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out uint filePathLength);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalFontFileLoader::GetFilePathFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, WCHAR* filePath, UINT32 filePathSize)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="filePath">_Out_writes_z_(filePathSize) <b>WCHAR* filePath</b></param>
	/// <param name="filePathSize"><b>UINT32 filePathSize</b></param>
	int GetFilePathFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, char* filePath, uint filePathSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalFontFileLoader::GetLastWriteTimeFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, FILETIME* lastWriteTime)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="lastWriteTime">_Out_ <b>FILETIME* lastWriteTime</b></param>
	int GetLastWriteTimeFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, FileTime* lastWriteTime);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalFontFileLoader::GetLastWriteTimeFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, FILETIME* lastWriteTime)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="lastWriteTime">_Out_ <b>FILETIME* lastWriteTime</b></param>
	int GetLastWriteTimeFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out FileTime lastWriteTime);
}

/// <summary>
/// Instance of <b>IDWriteLocalFontFileLoader</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct LocalFontFileLoader : ILocalFontFileLoader {
//unsafe public readonly struct ILocalFontFileLoaderObj : ILocalFontFileLoader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly LocalFontFileLoader* GetCurrentPointer () => (LocalFontFileLoader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ILocalFontFileLoaderObj* GetCurrentPointer () => (ILocalFontFileLoaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb2d9f3ec, 0xc9fe, 0x4a11, 0xa2, 0xec, 0xd8, 0x62, 0x08, 0xf7, 0xc0, 0xa2);

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
	public readonly int CreateStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0** fontFileStream) where T0 : unmanaged, IFontFileStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateStreamFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, (void**) fontFileStream);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out T0* fontFileStream) where T0 : unmanaged, IFontFileStream {
		fixed (T0** _fontFileStream = &fontFileStream) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateStreamFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, (void**) _fontFileStream);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilePathLengthFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, uint* filePathLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFilePathLengthFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilePathLengthFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out uint filePathLength) {
		fixed (uint* _filePathLength = &filePathLength) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFilePathLengthFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, _filePathLength);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilePathFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, char* filePath, uint filePathSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFilePathFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLastWriteTimeFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, FileTime* lastWriteTime) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLastWriteTimeFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLastWriteTimeFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out FileTime lastWriteTime) {
		fixed (FileTime* _lastWriteTime = &lastWriteTime) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLastWriteTimeFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, _lastWriteTime);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void**, int> CreateStreamFromKey;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, int> GetFilePathLengthFromKey;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, char*, uint, int> GetFilePathFromKey;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, FileTime*, int> GetLastWriteTimeFromKey;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
