using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteRemoteFontFileLoader</b> : IDWriteFontFileLoader<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IRemoteFontFileLoader : IFontFileLoader {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileLoader::CreateRemoteStreamFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="fontFileStream">_COM_Outptr_ <b>IDWriteRemoteFontFileStream** fontFileStream</b></param>
	int CreateRemoteStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0** fontFileStream) where T0 : unmanaged, IRemoteFontFileStream;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileLoader::CreateRemoteStreamFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="fontFileStream">_COM_Outptr_ <b>IDWriteRemoteFontFileStream** fontFileStream</b></param>
	int CreateRemoteStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out T0* fontFileStream) where T0 : unmanaged, IRemoteFontFileStream;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileLoader::GetLocalityFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, DWRITE_LOCALITY* locality)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="locality">_Out_ <b>DWRITE_LOCALITY* locality</b></param>
	int GetLocalityFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileLoader::GetLocalityFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, DWRITE_LOCALITY* locality)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="locality">_Out_ <b>DWRITE_LOCALITY* locality</b></param>
	int GetLocalityFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out Locality locality);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileLoader::CreateFontFileReferenceFromUrl (IDWriteFactory* factory, WCHAR* baseUrl, WCHAR* fontFileUrl, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="factory"><b>IDWriteFactory* factory</b></param>
	/// <param name="baseUrl">_In_opt_z_ <b>WCHAR* baseUrl</b></param>
	/// <param name="fontFileUrl">_In_z_ <b>WCHAR* fontFileUrl</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateFontFileReferenceFromUrl<T0, T1> (T0* factory, char* baseUrl, char* fontFileUrl, T1** fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteRemoteFontFileLoader::CreateFontFileReferenceFromUrl (IDWriteFactory* factory, WCHAR* baseUrl, WCHAR* fontFileUrl, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="factory"><b>IDWriteFactory* factory</b></param>
	/// <param name="baseUrl">_In_opt_z_ <b>WCHAR* baseUrl</b></param>
	/// <param name="fontFileUrl">_In_z_ <b>WCHAR* fontFileUrl</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateFontFileReferenceFromUrl<T0, T1> (T0* factory, char* baseUrl, char* fontFileUrl, out T1* fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFile;
}

/// <summary>
/// Instance of <b>IDWriteRemoteFontFileLoader</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct RemoteFontFileLoader : IRemoteFontFileLoader {
//unsafe public readonly struct IRemoteFontFileLoaderObj : IRemoteFontFileLoader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly RemoteFontFileLoader* GetCurrentPointer () => (RemoteFontFileLoader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IRemoteFontFileLoaderObj* GetCurrentPointer () => (IRemoteFontFileLoaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x68648c83, 0x6ede, 0x46c0, 0xab, 0x46, 0x20, 0x08, 0x3a, 0x88, 0x7f, 0xde);

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
	public readonly int CreateRemoteStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0** fontFileStream) where T0 : unmanaged, IRemoteFontFileStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRemoteStreamFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, (void**) fontFileStream);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRemoteStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out T0* fontFileStream) where T0 : unmanaged, IRemoteFontFileStream {
		fixed (T0** _fontFileStream = &fontFileStream) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRemoteStreamFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, (void**) _fontFileStream);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocalityFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocalityFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, locality);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocalityFromKey (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out Locality locality) {
		fixed (Locality* _locality = &locality) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLocalityFromKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize, _locality);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFileReferenceFromUrl<T0, T1> (T0* factory, char* baseUrl, char* fontFileUrl, T1** fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFileReferenceFromUrl (ptr, factory, baseUrl, fontFileUrl, (void**) fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFileReferenceFromUrl<T0, T1> (T0* factory, char* baseUrl, char* fontFileUrl, out T1* fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFile {
		fixed (T1** _fontFile = &fontFile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFileReferenceFromUrl (ptr, factory, baseUrl, fontFileUrl, (void**) _fontFile);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void**, int> CreateRemoteStreamFromKey;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Locality*, int> GetLocalityFromKey;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, char*, char*, void**, int> CreateFontFileReferenceFromUrl;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
