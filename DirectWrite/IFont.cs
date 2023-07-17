using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFont</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFont : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::GetFontFamily (IDWriteFontFamily** fontFamily)</b><br/>
	/// </summary>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily** fontFamily</b></param>
	int GetFontFamily<T0> (T0** fontFamily) where T0 : unmanaged, IFontFamily;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::GetFontFamily (IDWriteFontFamily** fontFamily)</b><br/>
	/// </summary>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily** fontFamily</b></param>
	int GetFontFamily<T0> (out T0* fontFamily) where T0 : unmanaged, IFontFamily;
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_WEIGHT IDWriteFont::GetWeight ()</b><br/>
	/// </summary>
	FontWeight GetWeight ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_STRETCH IDWriteFont::GetStretch ()</b><br/>
	/// </summary>
	FontStretch GetStretch ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_STYLE IDWriteFont::GetStyle ()</b><br/>
	/// </summary>
	FontStyle GetStyle ();
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFont::IsSymbolFont ()</b><br/>
	/// </summary>
	bool IsSymbolFont ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::GetFaceNames (IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetFaceNames<T0> (T0** names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::GetFaceNames (IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetFaceNames<T0> (out T0* names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::GetInformationalStrings (DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="informationalStringID"><b>DWRITE_INFORMATIONAL_STRING_ID informationalStringID</b></param>
	/// <param name="informationalStrings">_COM_Outptr_result_maybenull_ <b>IDWriteLocalizedStrings** informationalStrings</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int GetInformationalStrings<T0> (InformationalStringId informationalStringID, T0** informationalStrings, uint* exists) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::GetInformationalStrings (DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="informationalStringID"><b>DWRITE_INFORMATIONAL_STRING_ID informationalStringID</b></param>
	/// <param name="informationalStrings">_COM_Outptr_result_maybenull_ <b>IDWriteLocalizedStrings** informationalStrings</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int GetInformationalStrings<T0> (InformationalStringId informationalStringID, out T0* informationalStrings, out bool exists) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_SIMULATIONS IDWriteFont::GetSimulations ()</b><br/>
	/// </summary>
	FontSimulations GetSimulations ();
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFont::GetMetrics (DWRITE_FONT_METRICS* fontMetrics)</b><br/>
	/// </summary>
	/// <param name="fontMetrics">_Out_ <b>DWRITE_FONT_METRICS* fontMetrics</b></param>
	void GetMetrics (FontMetrics* fontMetrics);
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFont::GetMetrics (DWRITE_FONT_METRICS* fontMetrics)</b><br/>
	/// </summary>
	/// <param name="fontMetrics">_Out_ <b>DWRITE_FONT_METRICS* fontMetrics</b></param>
	void GetMetrics (out FontMetrics fontMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::HasCharacter (UINT32 unicodeValue, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="unicodeValue"><b>UINT32 unicodeValue</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int HasCharacter (uint unicodeValue, uint* exists);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::HasCharacter (UINT32 unicodeValue, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="unicodeValue"><b>UINT32 unicodeValue</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int HasCharacter (uint unicodeValue, out bool exists);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::CreateFontFace (IDWriteFontFace** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace** fontFace</b></param>
	int CreateFontFace<T0> (T0** fontFace) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont::CreateFontFace (IDWriteFontFace** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace** fontFace</b></param>
	int CreateFontFace<T0> (out T0* fontFace) where T0 : unmanaged, IFontFace;
}

/// <summary>
/// Instance of <b>IDWriteFont</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct Font : IFont {
//unsafe public readonly struct IFontObj : IFont {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Font* GetCurrentPointer () => (Font*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontObj* GetCurrentPointer () => (IFontObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xacd16696, 0x8c14, 0x4f5d, 0x87, 0x7e, 0xfe, 0x3f, 0xc1, 0xd3, 0x27, 0x37);

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
	public readonly int GetFontFamily<T0> (T0** fontFamily) where T0 : unmanaged, IFontFamily {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily (ptr, (void**) fontFamily);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily<T0> (out T0* fontFamily) where T0 : unmanaged, IFontFamily {
		fixed (T0** _fontFamily = &fontFamily) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily (ptr, (void**) _fontFamily);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontWeight GetWeight () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetWeight (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontStretch GetStretch () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStretch (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontStyle GetStyle () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStyle (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsSymbolFont () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsSymbolFont (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFaceNames<T0> (T0** names) where T0 : unmanaged, ILocalizedStrings {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFaceNames (ptr, (void**) names);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFaceNames<T0> (out T0* names) where T0 : unmanaged, ILocalizedStrings {
		fixed (T0** _names = &names) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFaceNames (ptr, (void**) _names);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetInformationalStrings<T0> (InformationalStringId informationalStringID, T0** informationalStrings, uint* exists) where T0 : unmanaged, ILocalizedStrings {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInformationalStrings (ptr, informationalStringID, (void**) informationalStrings, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetInformationalStrings<T0> (InformationalStringId informationalStringID, out T0* informationalStrings, out bool exists) where T0 : unmanaged, ILocalizedStrings {
		fixed (T0** _informationalStrings = &informationalStrings) {
			uint _exists;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetInformationalStrings (ptr, informationalStringID, (void**) _informationalStrings, &_exists);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontSimulations GetSimulations () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSimulations (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (FontMetrics* fontMetrics) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, fontMetrics);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (out FontMetrics fontMetrics) {
		fixed (FontMetrics* _fontMetrics = &fontMetrics) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, _fontMetrics);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HasCharacter (uint unicodeValue, uint* exists) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasCharacter (ptr, unicodeValue, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HasCharacter (uint unicodeValue, out bool exists) {
		uint _exists;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasCharacter (ptr, unicodeValue, &_exists);
		exists = _exists != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0> (T0** fontFace) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0> (out T0* fontFace) where T0 : unmanaged, IFontFace {
		fixed (T0** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, (void**) _fontFace);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontFamily;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontWeight> GetWeight;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStretch> GetStretch;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStyle> GetStyle;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsSymbolFont;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFaceNames;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InformationalStringId, void**, uint*, int> GetInformationalStrings;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontSimulations> GetSimulations;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontMetrics*, void> GetMetrics;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, int> HasCharacter;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontFace;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
