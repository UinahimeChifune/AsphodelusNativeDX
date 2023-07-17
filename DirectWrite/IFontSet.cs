using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontSet</b> : IUnknown<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontSet : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontSet::GetFontCount ()</b><br/>
	/// </summary>
	uint GetFontCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetFontFaceReference (UINT32 listIndex, IDWriteFontFaceReference** fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontFaceReference">_COM_Outptr_ <b>IDWriteFontFaceReference** fontFaceReference</b></param>
	int GetFontFaceReference<T0> (uint listIndex, T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetFontFaceReference (UINT32 listIndex, IDWriteFontFaceReference** fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontFaceReference">_COM_Outptr_ <b>IDWriteFontFaceReference** fontFaceReference</b></param>
	int GetFontFaceReference<T0> (uint listIndex, out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::FindFontFaceReference (IDWriteFontFaceReference* fontFaceReference, UINT32* listIndex, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="fontFaceReference"><b>IDWriteFontFaceReference* fontFaceReference</b></param>
	/// <param name="listIndex">_Out_ <b>UINT32* listIndex</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindFontFaceReference<T0> (T0* fontFaceReference, uint* listIndex, uint* exists) where T0 : unmanaged, IFontFaceReference;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::FindFontFaceReference (IDWriteFontFaceReference* fontFaceReference, UINT32* listIndex, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="fontFaceReference"><b>IDWriteFontFaceReference* fontFaceReference</b></param>
	/// <param name="listIndex">_Out_ <b>UINT32* listIndex</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindFontFaceReference<T0> (T0* fontFaceReference, out uint listIndex, out bool exists) where T0 : unmanaged, IFontFaceReference;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::FindFontFace (IDWriteFontFace* fontFace, UINT32* listIndex, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="fontFace"><b>IDWriteFontFace* fontFace</b></param>
	/// <param name="listIndex">_Out_ <b>UINT32* listIndex</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindFontFace<T0> (T0* fontFace, uint* listIndex, uint* exists) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::FindFontFace (IDWriteFontFace* fontFace, UINT32* listIndex, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="fontFace"><b>IDWriteFontFace* fontFace</b></param>
	/// <param name="listIndex">_Out_ <b>UINT32* listIndex</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindFontFace<T0> (T0* fontFace, out uint listIndex, out bool exists) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyValues (UINT32 listIndex, DWRITE_FONT_PROPERTY_ID propertyId, BOOL* exists, IDWriteLocalizedStrings** values)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="propertyId"><b>DWRITE_FONT_PROPERTY_ID propertyId</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	/// <param name="values">_COM_Outptr_result_maybenull_ <b>IDWriteLocalizedStrings** values</b></param>
	int GetPropertyValues<T0> (uint listIndex, FontPropertyId propertyId, uint* exists, T0** values) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyValues (UINT32 listIndex, DWRITE_FONT_PROPERTY_ID propertyId, BOOL* exists, IDWriteLocalizedStrings** values)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="propertyId"><b>DWRITE_FONT_PROPERTY_ID propertyId</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	/// <param name="values">_COM_Outptr_result_maybenull_ <b>IDWriteLocalizedStrings** values</b></param>
	int GetPropertyValues<T0> (uint listIndex, FontPropertyId propertyId, out bool exists, out T0* values) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyValues (DWRITE_FONT_PROPERTY_ID propertyID, WCHAR* preferredLocaleNames, IDWriteStringList** values)</b><br/>
	/// </summary>
	/// <param name="propertyID"><b>DWRITE_FONT_PROPERTY_ID propertyID</b></param>
	/// <param name="preferredLocaleNames">_In_z_ <b>WCHAR* preferredLocaleNames</b></param>
	/// <param name="values">_COM_Outptr_ <b>IDWriteStringList** values</b></param>
	int GetPropertyValues<T0> (FontPropertyId propertyID, char* preferredLocaleNames, T0** values) where T0 : unmanaged, IStringList;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyValues (DWRITE_FONT_PROPERTY_ID propertyID, WCHAR* preferredLocaleNames, IDWriteStringList** values)</b><br/>
	/// </summary>
	/// <param name="propertyID"><b>DWRITE_FONT_PROPERTY_ID propertyID</b></param>
	/// <param name="preferredLocaleNames">_In_z_ <b>WCHAR* preferredLocaleNames</b></param>
	/// <param name="values">_COM_Outptr_ <b>IDWriteStringList** values</b></param>
	int GetPropertyValues<T0> (FontPropertyId propertyID, char* preferredLocaleNames, out T0* values) where T0 : unmanaged, IStringList;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyValues (DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList** values)</b><br/>
	/// </summary>
	/// <param name="propertyID"><b>DWRITE_FONT_PROPERTY_ID propertyID</b></param>
	/// <param name="values">_COM_Outptr_ <b>IDWriteStringList** values</b></param>
	int GetPropertyValues<T0> (FontPropertyId propertyID, T0** values) where T0 : unmanaged, IStringList;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyValues (DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList** values)</b><br/>
	/// </summary>
	/// <param name="propertyID"><b>DWRITE_FONT_PROPERTY_ID propertyID</b></param>
	/// <param name="values">_COM_Outptr_ <b>IDWriteStringList** values</b></param>
	int GetPropertyValues<T0> (FontPropertyId propertyID, out T0* values) where T0 : unmanaged, IStringList;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyOccurrenceCount (DWRITE_FONT_PROPERTY* property, UINT32* propertyOccurrenceCount)</b><br/>
	/// </summary>
	/// <param name="property">_In_ <b>DWRITE_FONT_PROPERTY* property</b></param>
	/// <param name="propertyOccurrenceCount">_Out_ <b>UINT32* propertyOccurrenceCount</b></param>
	int GetPropertyOccurrenceCount (FontProperty* property, uint* propertyOccurrenceCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetPropertyOccurrenceCount (DWRITE_FONT_PROPERTY* property, UINT32* propertyOccurrenceCount)</b><br/>
	/// </summary>
	/// <param name="property">_In_ <b>DWRITE_FONT_PROPERTY* property</b></param>
	/// <param name="propertyOccurrenceCount">_Out_ <b>UINT32* propertyOccurrenceCount</b></param>
	int GetPropertyOccurrenceCount (FontProperty* property, out uint propertyOccurrenceCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetMatchingFonts (DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount, IDWriteFontSet** filteredSet)</b><br/>
	/// </summary>
	/// <param name="properties">_In_reads_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	/// <param name="filteredSet">_COM_Outptr_ <b>IDWriteFontSet** filteredSet</b></param>
	int GetMatchingFonts<T0> (FontProperty* properties, uint propertyCount, T0** filteredSet) where T0 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetMatchingFonts (DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount, IDWriteFontSet** filteredSet)</b><br/>
	/// </summary>
	/// <param name="properties">_In_reads_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	/// <param name="filteredSet">_COM_Outptr_ <b>IDWriteFontSet** filteredSet</b></param>
	int GetMatchingFonts<T0> (FontProperty* properties, uint propertyCount, out T0* filteredSet) where T0 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetMatchingFonts (WCHAR* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, IDWriteFontSet** filteredSet)</b><br/>
	/// </summary>
	/// <param name="familyName">_In_z_ <b>WCHAR* familyName</b></param>
	/// <param name="fontWeight"><b>DWRITE_FONT_WEIGHT fontWeight</b></param>
	/// <param name="fontStretch"><b>DWRITE_FONT_STRETCH fontStretch</b></param>
	/// <param name="fontStyle"><b>DWRITE_FONT_STYLE fontStyle</b></param>
	/// <param name="filteredSet">_COM_Outptr_ <b>IDWriteFontSet** filteredSet</b></param>
	int GetMatchingFonts<T0> (char* familyName, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, T0** filteredSet) where T0 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet::GetMatchingFonts (WCHAR* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, IDWriteFontSet** filteredSet)</b><br/>
	/// </summary>
	/// <param name="familyName">_In_z_ <b>WCHAR* familyName</b></param>
	/// <param name="fontWeight"><b>DWRITE_FONT_WEIGHT fontWeight</b></param>
	/// <param name="fontStretch"><b>DWRITE_FONT_STRETCH fontStretch</b></param>
	/// <param name="fontStyle"><b>DWRITE_FONT_STYLE fontStyle</b></param>
	/// <param name="filteredSet">_COM_Outptr_ <b>IDWriteFontSet** filteredSet</b></param>
	int GetMatchingFonts<T0> (char* familyName, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, out T0* filteredSet) where T0 : unmanaged, IFontSet;
}

/// <summary>
/// Instance of <b>IDWriteFontSet</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontSet : IFontSet {
//unsafe public readonly struct IFontSetObj : IFontSet {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontSet* GetCurrentPointer () => (FontSet*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontSetObj* GetCurrentPointer () => (IFontSetObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x53585141, 0xd9f8, 0x4095, 0x83, 0x21, 0xd7, 0x3c, 0xf6, 0xbd, 0x11, 0x6b);

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
	public readonly uint GetFontCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFaceReference<T0> (uint listIndex, T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceReference (ptr, listIndex, (void**) fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFaceReference<T0> (uint listIndex, out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		fixed (T0** _fontFaceReference = &fontFaceReference) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceReference (ptr, listIndex, (void**) _fontFaceReference);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFontFaceReference<T0> (T0* fontFaceReference, uint* listIndex, uint* exists) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindFontFaceReference (ptr, fontFaceReference, listIndex, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFontFaceReference<T0> (T0* fontFaceReference, out uint listIndex, out bool exists) where T0 : unmanaged, IFontFaceReference {
		fixed (uint* _listIndex = &listIndex) {
			uint _exists;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindFontFaceReference (ptr, fontFaceReference, _listIndex, &_exists);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFontFace<T0> (T0* fontFace, uint* listIndex, uint* exists) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindFontFace (ptr, fontFace, listIndex, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFontFace<T0> (T0* fontFace, out uint listIndex, out bool exists) where T0 : unmanaged, IFontFace {
		fixed (uint* _listIndex = &listIndex) {
			uint _exists;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindFontFace (ptr, fontFace, _listIndex, &_exists);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyValues<T0> (uint listIndex, FontPropertyId propertyId, uint* exists, T0** values) where T0 : unmanaged, ILocalizedStrings {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__GetPropertyValues (ptr, listIndex, propertyId, exists, (void**) values);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyValues<T0> (uint listIndex, FontPropertyId propertyId, out bool exists, out T0* values) where T0 : unmanaged, ILocalizedStrings {
		uint _exists;
		fixed (T0** _values = &values) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->__GetPropertyValues (ptr, listIndex, propertyId, &_exists, (void**) _values);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyValues<T0> (FontPropertyId propertyID, char* preferredLocaleNames, T0** values) where T0 : unmanaged, IStringList {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetPropertyValues (ptr, propertyID, preferredLocaleNames, (void**) values);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyValues<T0> (FontPropertyId propertyID, char* preferredLocaleNames, out T0* values) where T0 : unmanaged, IStringList {
		fixed (T0** _values = &values) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetPropertyValues (ptr, propertyID, preferredLocaleNames, (void**) _values);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyValues<T0> (FontPropertyId propertyID, T0** values) where T0 : unmanaged, IStringList {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyValues (ptr, propertyID, (void**) values);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyValues<T0> (FontPropertyId propertyID, out T0* values) where T0 : unmanaged, IStringList {
		fixed (T0** _values = &values) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyValues (ptr, propertyID, (void**) _values);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyOccurrenceCount (FontProperty* property, uint* propertyOccurrenceCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyOccurrenceCount (ptr, property, propertyOccurrenceCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyOccurrenceCount (FontProperty* property, out uint propertyOccurrenceCount) {
		fixed (uint* _propertyOccurrenceCount = &propertyOccurrenceCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyOccurrenceCount (ptr, property, _propertyOccurrenceCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (FontProperty* properties, uint propertyCount, T0** filteredSet) where T0 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetMatchingFonts (ptr, properties, propertyCount, (void**) filteredSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (FontProperty* properties, uint propertyCount, out T0* filteredSet) where T0 : unmanaged, IFontSet {
		fixed (T0** _filteredSet = &filteredSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetMatchingFonts (ptr, properties, propertyCount, (void**) _filteredSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (char* familyName, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, T0** filteredSet) where T0 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFonts (ptr, familyName, fontWeight, fontStretch, fontStyle, (void**) filteredSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (char* familyName, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, out T0* filteredSet) where T0 : unmanaged, IFontSet {
		fixed (T0** _filteredSet = &filteredSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFonts (ptr, familyName, fontWeight, fontStretch, fontStyle, (void**) _filteredSet);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFontFaceReference;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, uint*, int> FindFontFaceReference;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, uint*, int> FindFontFace;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontPropertyId, void**, int> GetPropertyValues;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontPropertyId, char*, void**, int> _GetPropertyValues;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontPropertyId, uint*, void**, int> __GetPropertyValues;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontProperty*, uint*, int> GetPropertyOccurrenceCount;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, FontWeight, FontStretch, FontStyle, void**, int> GetMatchingFonts;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontProperty*, uint, void**, int> _GetMatchingFonts;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
