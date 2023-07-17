using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontCollectionLoader</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontCollectionLoader : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollectionLoader::CreateEnumeratorFromKey (IDWriteFactory* factory, void* collectionKey, UINT32 collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)</b><br/>
	/// </summary>
	/// <param name="factory">_In_ <b>IDWriteFactory* factory</b></param>
	/// <param name="collectionKey">_In_reads_bytes_(collectionKeySize) <b>void* collectionKey</b></param>
	/// <param name="collectionKeySize"><b>UINT32 collectionKeySize</b></param>
	/// <param name="fontFileEnumerator">_COM_Outptr_ <b>IDWriteFontFileEnumerator** fontFileEnumerator</b></param>
	int CreateEnumeratorFromKey<T0, T1> (T0* factory, void* collectionKey, uint collectionKeySize, T1** fontFileEnumerator) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFileEnumerator;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollectionLoader::CreateEnumeratorFromKey (IDWriteFactory* factory, void* collectionKey, UINT32 collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)</b><br/>
	/// </summary>
	/// <param name="factory">_In_ <b>IDWriteFactory* factory</b></param>
	/// <param name="collectionKey">_In_reads_bytes_(collectionKeySize) <b>void* collectionKey</b></param>
	/// <param name="collectionKeySize"><b>UINT32 collectionKeySize</b></param>
	/// <param name="fontFileEnumerator">_COM_Outptr_ <b>IDWriteFontFileEnumerator** fontFileEnumerator</b></param>
	int CreateEnumeratorFromKey<T0, T1> (T0* factory, void* collectionKey, uint collectionKeySize, out T1* fontFileEnumerator) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFileEnumerator;
}

/// <summary>
/// Instance of <b>IDWriteFontCollectionLoader</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontCollectionLoader : IFontCollectionLoader {
//unsafe public readonly struct IFontCollectionLoaderObj : IFontCollectionLoader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontCollectionLoader* GetCurrentPointer () => (FontCollectionLoader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontCollectionLoaderObj* GetCurrentPointer () => (IFontCollectionLoaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xcca920e4, 0x52f0, 0x492b, 0xbf, 0xa8, 0x29, 0xc7, 0x2e, 0xe0, 0xa4, 0x68);

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
	public readonly int CreateEnumeratorFromKey<T0, T1> (T0* factory, void* collectionKey, uint collectionKeySize, T1** fontFileEnumerator) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFileEnumerator {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateEnumeratorFromKey (ptr, factory, collectionKey, collectionKeySize, (void**) fontFileEnumerator);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEnumeratorFromKey<T0, T1> (T0* factory, void* collectionKey, uint collectionKeySize, out T1* fontFileEnumerator) where T0 : unmanaged, IFactory where T1 : unmanaged, IFontFileEnumerator {
		fixed (T1** _fontFileEnumerator = &fontFileEnumerator) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateEnumeratorFromKey (ptr, factory, collectionKey, collectionKeySize, (void**) _fontFileEnumerator);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void**, int> CreateEnumeratorFromKey;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
