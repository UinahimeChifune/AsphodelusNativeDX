using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontSet1</b> : IDWriteFontSet<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontSet1 : IFontSet {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetMatchingFonts (DWRITE_FONT_PROPERTY* fontProperty, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontSet1** matchingFonts)</b><br/>
	/// </summary>
	/// <param name="fontProperty">_In_opt_ <b>DWRITE_FONT_PROPERTY* fontProperty</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="matchingFonts">_COM_Outptr_ <b>IDWriteFontSet1** matchingFonts</b></param>
	int GetMatchingFonts<T0> (FontProperty* fontProperty, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** matchingFonts) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetMatchingFonts (DWRITE_FONT_PROPERTY* fontProperty, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontSet1** matchingFonts)</b><br/>
	/// </summary>
	/// <param name="fontProperty">_In_opt_ <b>DWRITE_FONT_PROPERTY* fontProperty</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="matchingFonts">_COM_Outptr_ <b>IDWriteFontSet1** matchingFonts</b></param>
	int GetMatchingFonts<T0> (FontProperty* fontProperty, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* matchingFonts) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFirstFontResources (IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFirstFontResources<T0> (T0** filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFirstFontResources (IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFirstFontResources<T0> (out T0* filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFonts (DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount, BOOL selectAnyProperty, IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="properties">_In_reads_opt_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	/// <param name="selectAnyProperty"><b>BOOL selectAnyProperty</b></param>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFilteredFonts<T0> (FontProperty* properties, uint propertyCount, bool selectAnyProperty, T0** filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFonts (DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount, BOOL selectAnyProperty, IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="properties">_In_reads_opt_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	/// <param name="selectAnyProperty"><b>BOOL selectAnyProperty</b></param>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFilteredFonts<T0> (FontProperty* properties, uint propertyCount, bool selectAnyProperty, out T0* filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFonts (DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 fontAxisRangeCount, BOOL selectAnyRange, IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="fontAxisRanges">_In_reads_(fontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="fontAxisRangeCount"><b>UINT32 fontAxisRangeCount</b></param>
	/// <param name="selectAnyRange"><b>BOOL selectAnyRange</b></param>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFilteredFonts<T0> (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, T0** filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFonts (DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 fontAxisRangeCount, BOOL selectAnyRange, IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="fontAxisRanges">_In_reads_(fontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="fontAxisRangeCount"><b>UINT32 fontAxisRangeCount</b></param>
	/// <param name="selectAnyRange"><b>BOOL selectAnyRange</b></param>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFilteredFonts<T0> (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, out T0* filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFonts (UINT32* indices, UINT32 indexCount, IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="indices">_In_reads_(indexCount) <b>UINT32* indices</b></param>
	/// <param name="indexCount"><b>UINT32 indexCount</b></param>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFilteredFonts<T0> (uint* indices, uint indexCount, T0** filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFonts (UINT32* indices, UINT32 indexCount, IDWriteFontSet1** filteredFontSet)</b><br/>
	/// </summary>
	/// <param name="indices">_In_reads_(indexCount) <b>UINT32* indices</b></param>
	/// <param name="indexCount"><b>UINT32 indexCount</b></param>
	/// <param name="filteredFontSet">_COM_Outptr_ <b>IDWriteFontSet1** filteredFontSet</b></param>
	int GetFilteredFonts<T0> (uint* indices, uint indexCount, out T0* filteredFontSet) where T0 : unmanaged, IFontSet1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFontIndices (DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount, BOOL selectAnyProperty, UINT32* indices, UINT32 maxIndexCount, UINT32* actualIndexCount)</b><br/>
	/// </summary>
	/// <param name="properties">_In_reads_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	/// <param name="selectAnyProperty"><b>BOOL selectAnyProperty</b></param>
	/// <param name="indices">_Out_writes_(maxIndexCount) <b>UINT32* indices</b></param>
	/// <param name="maxIndexCount"><b>UINT32 maxIndexCount</b></param>
	/// <param name="actualIndexCount">_Out_ <b>UINT32* actualIndexCount</b></param>
	int GetFilteredFontIndices (FontProperty* properties, uint propertyCount, bool selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFontIndices (DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount, BOOL selectAnyProperty, UINT32* indices, UINT32 maxIndexCount, UINT32* actualIndexCount)</b><br/>
	/// </summary>
	/// <param name="properties">_In_reads_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	/// <param name="selectAnyProperty"><b>BOOL selectAnyProperty</b></param>
	/// <param name="indices">_Out_writes_(maxIndexCount) <b>UINT32* indices</b></param>
	/// <param name="maxIndexCount"><b>UINT32 maxIndexCount</b></param>
	/// <param name="actualIndexCount">_Out_ <b>UINT32* actualIndexCount</b></param>
	int GetFilteredFontIndices (FontProperty* properties, uint propertyCount, bool selectAnyProperty, uint* indices, uint maxIndexCount, out uint actualIndexCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFontIndices (DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 fontAxisRangeCount, BOOL selectAnyRange, UINT32* indices, UINT32 maxIndexCount, UINT32* actualIndexCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisRanges">_In_reads_(fontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="fontAxisRangeCount"><b>UINT32 fontAxisRangeCount</b></param>
	/// <param name="selectAnyRange"><b>BOOL selectAnyRange</b></param>
	/// <param name="indices">_Out_writes_(maxIndexCount) <b>UINT32* indices</b></param>
	/// <param name="maxIndexCount"><b>UINT32 maxIndexCount</b></param>
	/// <param name="actualIndexCount">_Out_ <b>UINT32* actualIndexCount</b></param>
	int GetFilteredFontIndices (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, uint* indices, uint maxIndexCount, uint* actualIndexCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFilteredFontIndices (DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 fontAxisRangeCount, BOOL selectAnyRange, UINT32* indices, UINT32 maxIndexCount, UINT32* actualIndexCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisRanges">_In_reads_(fontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="fontAxisRangeCount"><b>UINT32 fontAxisRangeCount</b></param>
	/// <param name="selectAnyRange"><b>BOOL selectAnyRange</b></param>
	/// <param name="indices">_Out_writes_(maxIndexCount) <b>UINT32* indices</b></param>
	/// <param name="maxIndexCount"><b>UINT32 maxIndexCount</b></param>
	/// <param name="actualIndexCount">_Out_ <b>UINT32* actualIndexCount</b></param>
	int GetFilteredFontIndices (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, uint* indices, uint maxIndexCount, out uint actualIndexCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFontAxisRanges (DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 maxFontAxisRangeCount, UINT32* actualFontAxisRangeCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisRanges">_Out_writes_(maxFontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="maxFontAxisRangeCount"><b>UINT32 maxFontAxisRangeCount</b></param>
	/// <param name="actualFontAxisRangeCount">_Out_ <b>UINT32* actualFontAxisRangeCount</b></param>
	int GetFontAxisRanges (FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFontAxisRanges (DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 maxFontAxisRangeCount, UINT32* actualFontAxisRangeCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisRanges">_Out_writes_(maxFontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="maxFontAxisRangeCount"><b>UINT32 maxFontAxisRangeCount</b></param>
	/// <param name="actualFontAxisRangeCount">_Out_ <b>UINT32* actualFontAxisRangeCount</b></param>
	int GetFontAxisRanges (FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, out uint actualFontAxisRangeCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFontAxisRanges (UINT32 listIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 maxFontAxisRangeCount, UINT32* actualFontAxisRangeCount)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontAxisRanges">_Out_writes_(maxFontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="maxFontAxisRangeCount"><b>UINT32 maxFontAxisRangeCount</b></param>
	/// <param name="actualFontAxisRangeCount">_Out_ <b>UINT32* actualFontAxisRangeCount</b></param>
	int GetFontAxisRanges (uint listIndex, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFontAxisRanges (UINT32 listIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 maxFontAxisRangeCount, UINT32* actualFontAxisRangeCount)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontAxisRanges">_Out_writes_(maxFontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="maxFontAxisRangeCount"><b>UINT32 maxFontAxisRangeCount</b></param>
	/// <param name="actualFontAxisRangeCount">_Out_ <b>UINT32* actualFontAxisRangeCount</b></param>
	int GetFontAxisRanges (uint listIndex, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, out uint actualFontAxisRangeCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFontFaceReference (UINT32 listIndex, IDWriteFontFaceReference1** fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontFaceReference">_COM_Outptr_ <b>IDWriteFontFaceReference1** fontFaceReference</b></param>
	int GetFontFaceReference1<T0> (uint listIndex, T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::GetFontFaceReference (UINT32 listIndex, IDWriteFontFaceReference1** fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontFaceReference">_COM_Outptr_ <b>IDWriteFontFaceReference1** fontFaceReference</b></param>
	int GetFontFaceReference1<T0> (uint listIndex, out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::CreateFontResource (UINT32 listIndex, IDWriteFontResource** fontResource)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontResource">_COM_Outptr_ <b>IDWriteFontResource** fontResource</b></param>
	int CreateFontResource<T0> (uint listIndex, T0** fontResource) where T0 : unmanaged, IFontResource;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::CreateFontResource (UINT32 listIndex, IDWriteFontResource** fontResource)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontResource">_COM_Outptr_ <b>IDWriteFontResource** fontResource</b></param>
	int CreateFontResource<T0> (uint listIndex, out T0* fontResource) where T0 : unmanaged, IFontResource;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::CreateFontFace (UINT32 listIndex, IDWriteFontFace5** fontFace)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace5** fontFace</b></param>
	int CreateFontFace<T0> (uint listIndex, T0** fontFace) where T0 : unmanaged, IFontFace5;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet1::CreateFontFace (UINT32 listIndex, IDWriteFontFace5** fontFace)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace5** fontFace</b></param>
	int CreateFontFace<T0> (uint listIndex, out T0* fontFace) where T0 : unmanaged, IFontFace5;
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_LOCALITY IDWriteFontSet1::GetFontLocality (UINT32 listIndex)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	Locality GetFontLocality (uint listIndex);
}

/// <summary>
/// Instance of <b>IDWriteFontSet1</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontSet1 : IFontSet1 {
//unsafe public readonly struct IFontSet1Obj : IFontSet1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontSet1* GetCurrentPointer () => (FontSet1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontSet1Obj* GetCurrentPointer () => (IFontSet1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x7e9fda85, 0x6c92, 0x4053, 0xbc, 0x47, 0x7a, 0xe3, 0x53, 0x0d, 0xb4, 0xd3);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (FontProperty* fontProperty, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** matchingFonts) where T0 : unmanaged, IFontSet1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__GetMatchingFonts (ptr, fontProperty, fontAxisValues, fontAxisValueCount, (void**) matchingFonts);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFonts<T0> (FontProperty* fontProperty, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* matchingFonts) where T0 : unmanaged, IFontSet1 {
		fixed (T0** _matchingFonts = &matchingFonts) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->__GetMatchingFonts (ptr, fontProperty, fontAxisValues, fontAxisValueCount, (void**) _matchingFonts);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFirstFontResources<T0> (T0** filteredFontSet) where T0 : unmanaged, IFontSet1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFirstFontResources (ptr, (void**) filteredFontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFirstFontResources<T0> (out T0* filteredFontSet) where T0 : unmanaged, IFontSet1 {
		fixed (T0** _filteredFontSet = &filteredFontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFirstFontResources (ptr, (void**) _filteredFontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFonts<T0> (FontProperty* properties, uint propertyCount, bool selectAnyProperty, T0** filteredFontSet) where T0 : unmanaged, IFontSet1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFilteredFonts (ptr, properties, propertyCount, selectAnyProperty ? 1U : 0U, (void**) filteredFontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFonts<T0> (FontProperty* properties, uint propertyCount, bool selectAnyProperty, out T0* filteredFontSet) where T0 : unmanaged, IFontSet1 {
		fixed (T0** _filteredFontSet = &filteredFontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFilteredFonts (ptr, properties, propertyCount, selectAnyProperty ? 1U : 0U, (void**) _filteredFontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFonts<T0> (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, T0** filteredFontSet) where T0 : unmanaged, IFontSet1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFilteredFonts (ptr, fontAxisRanges, fontAxisRangeCount, selectAnyRange ? 1U : 0U, (void**) filteredFontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFonts<T0> (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, out T0* filteredFontSet) where T0 : unmanaged, IFontSet1 {
		fixed (T0** _filteredFontSet = &filteredFontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetFilteredFonts (ptr, fontAxisRanges, fontAxisRangeCount, selectAnyRange ? 1U : 0U, (void**) _filteredFontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFonts<T0> (uint* indices, uint indexCount, T0** filteredFontSet) where T0 : unmanaged, IFontSet1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__GetFilteredFonts (ptr, indices, indexCount, (void**) filteredFontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFonts<T0> (uint* indices, uint indexCount, out T0* filteredFontSet) where T0 : unmanaged, IFontSet1 {
		fixed (T0** _filteredFontSet = &filteredFontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->__GetFilteredFonts (ptr, indices, indexCount, (void**) _filteredFontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFontIndices (FontProperty* properties, uint propertyCount, bool selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFilteredFontIndices (ptr, properties, propertyCount, selectAnyProperty ? 1U : 0U, indices, maxIndexCount, actualIndexCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFontIndices (FontProperty* properties, uint propertyCount, bool selectAnyProperty, uint* indices, uint maxIndexCount, out uint actualIndexCount) {
		fixed (uint* _actualIndexCount = &actualIndexCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFilteredFontIndices (ptr, properties, propertyCount, selectAnyProperty ? 1U : 0U, indices, maxIndexCount, _actualIndexCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFontIndices (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, uint* indices, uint maxIndexCount, uint* actualIndexCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFilteredFontIndices (ptr, fontAxisRanges, fontAxisRangeCount, selectAnyRange ? 1U : 0U, indices, maxIndexCount, actualIndexCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFilteredFontIndices (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, uint* indices, uint maxIndexCount, out uint actualIndexCount) {
		fixed (uint* _actualIndexCount = &actualIndexCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetFilteredFontIndices (ptr, fontAxisRanges, fontAxisRangeCount, selectAnyRange ? 1U : 0U, indices, maxIndexCount, _actualIndexCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontAxisRanges (FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisRanges (ptr, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontAxisRanges (FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, out uint actualFontAxisRangeCount) {
		fixed (uint* _actualFontAxisRangeCount = &actualFontAxisRangeCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisRanges (ptr, fontAxisRanges, maxFontAxisRangeCount, _actualFontAxisRangeCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontAxisRanges (uint listIndex, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontAxisRanges (ptr, listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontAxisRanges (uint listIndex, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, out uint actualFontAxisRangeCount) {
		fixed (uint* _actualFontAxisRangeCount = &actualFontAxisRangeCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontAxisRanges (ptr, listIndex, fontAxisRanges, maxFontAxisRangeCount, _actualFontAxisRangeCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFaceReference1<T0> (uint listIndex, T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceReference1 (ptr, listIndex, (void**) fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFaceReference1<T0> (uint listIndex, out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference1 {
		fixed (T0** _fontFaceReference = &fontFaceReference) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceReference1 (ptr, listIndex, (void**) _fontFaceReference);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontResource<T0> (uint listIndex, T0** fontResource) where T0 : unmanaged, IFontResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontResource (ptr, listIndex, (void**) fontResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontResource<T0> (uint listIndex, out T0* fontResource) where T0 : unmanaged, IFontResource {
		fixed (T0** _fontResource = &fontResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontResource (ptr, listIndex, (void**) _fontResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0> (uint listIndex, T0** fontFace) where T0 : unmanaged, IFontFace5 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, listIndex, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0> (uint listIndex, out T0* fontFace) where T0 : unmanaged, IFontFace5 {
		fixed (T0** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, listIndex, (void**) _fontFace);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Locality GetFontLocality (uint listIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontLocality (ptr, listIndex);
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
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontProperty*, FontAxisValue*, uint, void**, int> __GetMatchingFonts;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFirstFontResources;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontProperty*, uint, uint, void**, int> GetFilteredFonts;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisRange*, uint, uint, void**, int> _GetFilteredFonts;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint, void**, int> __GetFilteredFonts;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontProperty*, uint, uint, uint*, uint, uint*, int> GetFilteredFontIndices;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisRange*, uint, uint, uint*, uint, uint*, int> _GetFilteredFontIndices;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisRange*, uint, uint*, int> GetFontAxisRanges;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontAxisRange*, uint, uint*, int> _GetFontAxisRanges;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFontFaceReference1;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> CreateFontResource;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> CreateFontFace;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Locality> GetFontLocality;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
