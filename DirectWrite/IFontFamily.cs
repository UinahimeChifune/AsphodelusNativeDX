using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFamily</b> : IDWriteFontList<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontFamily : IFontList {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFamily::GetFamilyNames (IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetFamilyNames<T0> (T0** names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFamily::GetFamilyNames (IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetFamilyNames<T0> (out T0* names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFamily::GetFirstMatchingFont (DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFont** matchingFont)</b><br/>
	/// </summary>
	/// <param name="weight"><b>DWRITE_FONT_WEIGHT weight</b></param>
	/// <param name="stretch"><b>DWRITE_FONT_STRETCH stretch</b></param>
	/// <param name="style"><b>DWRITE_FONT_STYLE style</b></param>
	/// <param name="matchingFont">_COM_Outptr_ <b>IDWriteFont** matchingFont</b></param>
	int GetFirstMatchingFont<T0> (FontWeight weight, FontStretch stretch, FontStyle style, T0** matchingFont) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFamily::GetFirstMatchingFont (DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFont** matchingFont)</b><br/>
	/// </summary>
	/// <param name="weight"><b>DWRITE_FONT_WEIGHT weight</b></param>
	/// <param name="stretch"><b>DWRITE_FONT_STRETCH stretch</b></param>
	/// <param name="style"><b>DWRITE_FONT_STYLE style</b></param>
	/// <param name="matchingFont">_COM_Outptr_ <b>IDWriteFont** matchingFont</b></param>
	int GetFirstMatchingFont<T0> (FontWeight weight, FontStretch stretch, FontStyle style, out T0* matchingFont) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFamily::GetMatchingFonts (DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFontList** matchingFonts)</b><br/>
	/// </summary>
	/// <param name="weight"><b>DWRITE_FONT_WEIGHT weight</b></param>
	/// <param name="stretch"><b>DWRITE_FONT_STRETCH stretch</b></param>
	/// <param name="style"><b>DWRITE_FONT_STYLE style</b></param>
	/// <param name="matchingFonts">_COM_Outptr_ <b>IDWriteFontList** matchingFonts</b></param>
	int GetMatchingFonts<T0> (FontWeight weight, FontStretch stretch, FontStyle style, T0** matchingFonts) where T0 : unmanaged, IFontList;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFamily::GetMatchingFonts (DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFontList** matchingFonts)</b><br/>
	/// </summary>
	/// <param name="weight"><b>DWRITE_FONT_WEIGHT weight</b></param>
	/// <param name="stretch"><b>DWRITE_FONT_STRETCH stretch</b></param>
	/// <param name="style"><b>DWRITE_FONT_STYLE style</b></param>
	/// <param name="matchingFonts">_COM_Outptr_ <b>IDWriteFontList** matchingFonts</b></param>
	int GetMatchingFonts<T0> (FontWeight weight, FontStretch stretch, FontStyle style, out T0* matchingFonts) where T0 : unmanaged, IFontList;
}

/// <summary>
/// Instance of <b>IDWriteFontFamily</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontFamily : IFontFamily {
//unsafe public readonly struct IFontFamilyObj : IFontFamily {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFamily* GetCurrentPointer () => (FontFamily*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFamilyObj* GetCurrentPointer () => (IFontFamilyObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xda20d8ef, 0x812a, 0x4c43, 0x98, 0x02, 0x62, 0xec, 0x4a, 0xbd, 0x7a, 0xdd);

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
	public readonly int GetFontCollection<T0> (T0** fontCollection) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontCollection (ptr, (void**) fontCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontCollection<T0> (out T0* fontCollection) where T0 : unmanaged, IFontCollection {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontCollection (ptr, (void**) _fontCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFont<T0> (uint index, T0** font) where T0 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFont (ptr, index, (void**) font);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFont<T0> (uint index, out T0* font) where T0 : unmanaged, IFont {
		fixed (T0** _font = &font) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFont (ptr, index, (void**) _font);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFamilyNames<T0> (T0** names) where T0 : unmanaged, ILocalizedStrings {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFamilyNames (ptr, (void**) names);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFamilyNames<T0> (out T0* names) where T0 : unmanaged, ILocalizedStrings {
		fixed (T0** _names = &names) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFamilyNames (ptr, (void**) _names);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFirstMatchingFont<T0> (FontWeight weight, FontStretch stretch, FontStyle style, T0** matchingFont) where T0 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFirstMatchingFont (ptr, weight, stretch, style, (void**) matchingFont);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFirstMatchingFont<T0> (FontWeight weight, FontStretch stretch, FontStyle style, out T0* matchingFont) where T0 : unmanaged, IFont {
		fixed (T0** _matchingFont = &matchingFont) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFirstMatchingFont (ptr, weight, stretch, style, (void**) _matchingFont);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (FontWeight weight, FontStretch stretch, FontStyle style, T0** matchingFonts) where T0 : unmanaged, IFontList {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFonts (ptr, weight, stretch, style, (void**) matchingFonts);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (FontWeight weight, FontStretch stretch, FontStyle style, out T0* matchingFonts) where T0 : unmanaged, IFontList {
		fixed (T0** _matchingFonts = &matchingFonts) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFonts (ptr, weight, stretch, style, (void**) _matchingFonts);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontCollection;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontCount;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFont;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFamilyNames;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontWeight, FontStretch, FontStyle, void**, int> GetFirstMatchingFont;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontWeight, FontStretch, FontStyle, void**, int> GetMatchingFonts;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
