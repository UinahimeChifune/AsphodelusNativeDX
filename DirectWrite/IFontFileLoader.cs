using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFileLoader</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontFileLoader : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileLoader::CreateStreamFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="fontFileStream">_COM_Outptr_ <b>IDWriteFontFileStream** fontFileStream</b></param>
	int CreateStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0** fontFileStream) where T0 : unmanaged, IFontFileStream;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileLoader::CreateStreamFromKey (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="fontFileStream">_COM_Outptr_ <b>IDWriteFontFileStream** fontFileStream</b></param>
	int CreateStreamFromKey<T0> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, out T0* fontFileStream) where T0 : unmanaged, IFontFileStream;
}

/// <summary>
/// Instance of <b>IDWriteFontFileLoader</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontFileLoader : IFontFileLoader {
//unsafe public readonly struct IFontFileLoaderObj : IFontFileLoader {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFileLoader* GetCurrentPointer () => (FontFileLoader*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFileLoaderObj* GetCurrentPointer () => (IFontFileLoaderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x727cad4e, 0xd6af, 0x4c9e, 0x8a, 0x08, 0xd6, 0x95, 0xb1, 0x1c, 0xaa, 0x49);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
