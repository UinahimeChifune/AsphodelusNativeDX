using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontCollection2</b> : IDWriteFontCollection1<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontCollection2 : IFontCollection1 {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection2::GetFontFamily (UINT32 index, IDWriteFontFamily2** fontFamily)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily2** fontFamily</b></param>
	int GetFontFamily2<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily2;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection2::GetFontFamily (UINT32 index, IDWriteFontFamily2** fontFamily)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily2** fontFamily</b></param>
	int GetFontFamily2<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily2;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection2::GetMatchingFonts (WCHAR* familyName, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontList2** fontList)</b><br/>
	/// </summary>
	/// <param name="familyName">_In_z_ <b>WCHAR* familyName</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="fontList">_COM_Outptr_ <b>IDWriteFontList2** fontList</b></param>
	int GetMatchingFonts<T0> (char* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** fontList) where T0 : unmanaged, IFontList2;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection2::GetMatchingFonts (WCHAR* familyName, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontList2** fontList)</b><br/>
	/// </summary>
	/// <param name="familyName">_In_z_ <b>WCHAR* familyName</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="fontList">_COM_Outptr_ <b>IDWriteFontList2** fontList</b></param>
	int GetMatchingFonts<T0> (char* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* fontList) where T0 : unmanaged, IFontList2;
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_FAMILY_MODEL IDWriteFontCollection2::GetFontFamilyModel ()</b><br/>
	/// </summary>
	FontFamilyModel GetFontFamilyModel ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection2::GetFontSet (IDWriteFontSet1** fontSet)</b><br/>
	/// </summary>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet1** fontSet</b></param>
	int GetFontSet1<T0> (T0** fontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection2::GetFontSet (IDWriteFontSet1** fontSet)</b><br/>
	/// </summary>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet1** fontSet</b></param>
	int GetFontSet1<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet1;
}

/// <summary>
/// Instance of <b>IDWriteFontCollection2</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontCollection2 : IFontCollection2 {
//unsafe public readonly struct IFontCollection2Obj : IFontCollection2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontCollection2* GetCurrentPointer () => (FontCollection2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontCollection2Obj* GetCurrentPointer () => (IFontCollection2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x514039c6, 0x4617, 0x4064, 0xbf, 0x8b, 0x92, 0xea, 0x83, 0xe5, 0x06, 0xe0);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSet<T0> (T0** fontSet) where T0 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSet (ptr, (void**) fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSet<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet {
		fixed (T0** _fontSet = &fontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSet (ptr, (void**) _fontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily1<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily1 (ptr, index, (void**) fontFamily);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily1<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily1 {
		fixed (T0** _fontFamily = &fontFamily) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily1 (ptr, index, (void**) _fontFamily);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily2<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily2 (ptr, index, (void**) fontFamily);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily2<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily2 {
		fixed (T0** _fontFamily = &fontFamily) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily2 (ptr, index, (void**) _fontFamily);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (char* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** fontList) where T0 : unmanaged, IFontList2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFonts (ptr, familyName, fontAxisValues, fontAxisValueCount, (void**) fontList);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (char* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* fontList) where T0 : unmanaged, IFontList2 {
		fixed (T0** _fontList = &fontList) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFonts (ptr, familyName, fontAxisValues, fontAxisValueCount, (void**) _fontList);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontFamilyModel GetFontFamilyModel () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamilyModel (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSet1<T0> (T0** fontSet) where T0 : unmanaged, IFontSet1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSet (ptr, (void**) fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSet1<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet1 {
		fixed (T0** _fontSet = &fontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSet (ptr, (void**) _fontSet);
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
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontSet;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFontFamily1;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFontFamily2;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, FontAxisValue*, uint, void**, int> GetMatchingFonts;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontFamilyModel> GetFontFamilyModel;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontSet1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
