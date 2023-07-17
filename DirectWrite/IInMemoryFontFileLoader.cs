using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteInMemoryFontFileLoader</b> : IDWriteFontFileLoader<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IInMemoryFontFileLoader : IFontFileLoader {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInMemoryFontFileLoader::CreateInMemoryFontFileReference (IDWriteFactory* factory, void* fontData, UINT32 fontDataSize, IUnknown* ownerObject, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="factory"><b>IDWriteFactory* factory</b></param>
	/// <param name="fontData">_In_reads_bytes_(fontDataSize) <b>void* fontData</b></param>
	/// <param name="fontDataSize"><b>UINT32 fontDataSize</b></param>
	/// <param name="ownerObject">_In_opt_ <b>IUnknown* ownerObject</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateInMemoryFontFileReference<T0, T1, T2> (T0* factory, void* fontData, uint fontDataSize, T1* ownerObject, T2** fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IUnknown where T2 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInMemoryFontFileLoader::CreateInMemoryFontFileReference (IDWriteFactory* factory, void* fontData, UINT32 fontDataSize, IUnknown* ownerObject, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="factory"><b>IDWriteFactory* factory</b></param>
	/// <param name="fontData">_In_reads_bytes_(fontDataSize) <b>void* fontData</b></param>
	/// <param name="fontDataSize"><b>UINT32 fontDataSize</b></param>
	/// <param name="ownerObject">_In_opt_ <b>IUnknown* ownerObject</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateInMemoryFontFileReference<T0, T1, T2> (T0* factory, void* fontData, uint fontDataSize, T1* ownerObject, out T2* fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IUnknown where T2 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteInMemoryFontFileLoader::GetFileCount ()</b><br/>
	/// </summary>
	uint GetFileCount ();
}

/// <summary>
/// Instance of <b>IDWriteInMemoryFontFileLoader</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct InMemoryFontFileLoader : IInMemoryFontFileLoader {
//unsafe public readonly struct IInMemoryFontFileLoaderObj : IInMemoryFontFileLoader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly InMemoryFontFileLoader* GetCurrentPointer () => (InMemoryFontFileLoader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IInMemoryFontFileLoaderObj* GetCurrentPointer () => (IInMemoryFontFileLoaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xdc102f47, 0xa12d, 0x4b1c, 0x82, 0x2d, 0x9e, 0x11, 0x7e, 0x33, 0x04, 0x3f);

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
	public readonly int CreateInMemoryFontFileReference<T0, T1, T2> (T0* factory, void* fontData, uint fontDataSize, T1* ownerObject, T2** fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IUnknown where T2 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateInMemoryFontFileReference (ptr, factory, fontData, fontDataSize, ownerObject, (void**) fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateInMemoryFontFileReference<T0, T1, T2> (T0* factory, void* fontData, uint fontDataSize, T1* ownerObject, out T2* fontFile) where T0 : unmanaged, IFactory where T1 : unmanaged, IUnknown where T2 : unmanaged, IFontFile {
		fixed (T2** _fontFile = &fontFile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateInMemoryFontFileReference (ptr, factory, fontData, fontDataSize, ownerObject, (void**) _fontFile);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFileCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFileCount (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void**, int> CreateStreamFromKey;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void*, void**, int> CreateInMemoryFontFileReference;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFileCount;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
