using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontCollection</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontCollection : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontCollection::GetFontFamilyCount ()</b><br/>
	/// </summary>
	uint GetFontFamilyCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection::GetFontFamily (UINT32 index, IDWriteFontFamily** fontFamily)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily** fontFamily</b></param>
	int GetFontFamily<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection::GetFontFamily (UINT32 index, IDWriteFontFamily** fontFamily)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily** fontFamily</b></param>
	int GetFontFamily<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection::FindFamilyName (WCHAR* familyName, UINT32* index, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="familyName">_In_z_ <b>WCHAR* familyName</b></param>
	/// <param name="index">_Out_ <b>UINT32* index</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindFamilyName (char* familyName, uint* index, uint* exists);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection::FindFamilyName (WCHAR* familyName, UINT32* index, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="familyName">_In_z_ <b>WCHAR* familyName</b></param>
	/// <param name="index">_Out_ <b>UINT32* index</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindFamilyName (char* familyName, out uint index, out bool exists);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection::GetFontFromFontFace (IDWriteFontFace* fontFace, IDWriteFont** font)</b><br/>
	/// </summary>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="font">_COM_Outptr_ <b>IDWriteFont** font</b></param>
	int GetFontFromFontFace<T0, T1> (T0* fontFace, T1** font) where T0 : unmanaged, IFontFace where T1 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection::GetFontFromFontFace (IDWriteFontFace* fontFace, IDWriteFont** font)</b><br/>
	/// </summary>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="font">_COM_Outptr_ <b>IDWriteFont** font</b></param>
	int GetFontFromFontFace<T0, T1> (T0* fontFace, out T1* font) where T0 : unmanaged, IFontFace where T1 : unmanaged, IFont;
}

/// <summary>
/// Instance of <b>IDWriteFontCollection</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontCollection : IFontCollection {
//unsafe public readonly struct IFontCollectionObj : IFontCollection {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontCollection* GetCurrentPointer () => (FontCollection*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontCollectionObj* GetCurrentPointer () => (IFontCollectionObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa84cee02, 0x3eea, 0x4eee, 0xa8, 0x27, 0x87, 0xc1, 0xa0, 0x2a, 0x0f, 0xcc);

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
	public readonly uint GetFontFamilyCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamilyCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily (ptr, index, (void**) fontFamily);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily {
		fixed (T0** _fontFamily = &fontFamily) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily (ptr, index, (void**) _fontFamily);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFamilyName (char* familyName, uint* index, uint* exists) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindFamilyName (ptr, familyName, index, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFamilyName (char* familyName, out uint index, out bool exists) {
		fixed (uint* _index = &index) {
			uint _exists;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindFamilyName (ptr, familyName, _index, &_exists);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFromFontFace<T0, T1> (T0* fontFace, T1** font) where T0 : unmanaged, IFontFace where T1 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFromFontFace (ptr, fontFace, (void**) font);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFromFontFace<T0, T1> (T0* fontFace, out T1* font) where T0 : unmanaged, IFontFace where T1 : unmanaged, IFont {
		fixed (T1** _font = &font) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFromFontFace (ptr, fontFace, (void**) _font);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontFamilyCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFontFamily;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint*, uint*, int> FindFamilyName;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> GetFontFromFontFace;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
