using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFont1</b> : IDWriteFont<br/>
/// DWRITE_1.h
/// </summary>
unsafe public interface IFont1 : IFont {
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFont1::GetMetrics (DWRITE_FONT_METRICS1* fontMetrics)</b><br/>
	/// </summary>
	/// <param name="fontMetrics">_Out_ <b>DWRITE_FONT_METRICS1* fontMetrics</b></param>
	void GetMetrics (FontMetrics1* fontMetrics);
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFont1::GetMetrics (DWRITE_FONT_METRICS1* fontMetrics)</b><br/>
	/// </summary>
	/// <param name="fontMetrics">_Out_ <b>DWRITE_FONT_METRICS1* fontMetrics</b></param>
	void GetMetrics (out FontMetrics1 fontMetrics);
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFont1::GetPanose (DWRITE_PANOSE* panose)</b><br/>
	/// </summary>
	/// <param name="panose">_Out_ <b>DWRITE_PANOSE* panose</b></param>
	void GetPanose (Panose* panose);
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFont1::GetPanose (DWRITE_PANOSE* panose)</b><br/>
	/// </summary>
	/// <param name="panose">_Out_ <b>DWRITE_PANOSE* panose</b></param>
	void GetPanose (out Panose panose);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont1::GetUnicodeRanges (UINT32 maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, UINT32* actualRangeCount)</b><br/>
	/// </summary>
	/// <param name="maxRangeCount"><b>UINT32 maxRangeCount</b></param>
	/// <param name="unicodeRanges">_Out_writes_to_opt_(maxRangeCount, *actualRangeCount) <b>DWRITE_UNICODE_RANGE* unicodeRanges</b></param>
	/// <param name="actualRangeCount">_Out_ <b>UINT32* actualRangeCount</b></param>
	int GetUnicodeRanges (uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFont1::GetUnicodeRanges (UINT32 maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, UINT32* actualRangeCount)</b><br/>
	/// </summary>
	/// <param name="maxRangeCount"><b>UINT32 maxRangeCount</b></param>
	/// <param name="unicodeRanges">_Out_writes_to_opt_(maxRangeCount, *actualRangeCount) <b>DWRITE_UNICODE_RANGE* unicodeRanges</b></param>
	/// <param name="actualRangeCount">_Out_ <b>UINT32* actualRangeCount</b></param>
	int GetUnicodeRanges (uint maxRangeCount, UnicodeRange* unicodeRanges, out uint actualRangeCount);
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFont1::IsMonospacedFont ()</b><br/>
	/// </summary>
	bool IsMonospacedFont ();
}

/// <summary>
/// Instance of <b>IDWriteFont1</b><br/>
/// DWRITE_1.h
/// </summary>
unsafe public readonly struct Font1 : IFont1 {
//unsafe public readonly struct IFont1Obj : IFont1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Font1* GetCurrentPointer () => (Font1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFont1Obj* GetCurrentPointer () => (IFont1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xacd16696, 0x8c14, 0x4f5d, 0x87, 0x7e, 0xfe, 0x3f, 0xc1, 0xd3, 0x27, 0x38);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (FontMetrics1* fontMetrics) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetMetrics1 (ptr, fontMetrics);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (out FontMetrics1 fontMetrics) {
		fixed (FontMetrics1* _fontMetrics = &fontMetrics) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetMetrics1 (ptr, _fontMetrics);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetPanose (Panose* panose) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetPanose (ptr, panose);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetPanose (out Panose panose) {
		fixed (Panose* _panose = &panose) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetPanose (ptr, _panose);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetUnicodeRanges (uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetUnicodeRanges (ptr, maxRangeCount, unicodeRanges, actualRangeCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetUnicodeRanges (uint maxRangeCount, UnicodeRange* unicodeRanges, out uint actualRangeCount) {
		fixed (uint* _actualRangeCount = &actualRangeCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetUnicodeRanges (ptr, maxRangeCount, unicodeRanges, _actualRangeCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsMonospacedFont () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsMonospacedFont (ptr) != 0;
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
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontMetrics1*, void> GetMetrics1;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Panose*, void> GetPanose;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, UnicodeRange*, uint*, int> GetUnicodeRanges;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsMonospacedFont;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
