using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontSet3</b> : IDWriteFontSet2<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontSet3 : IFontSet2 {
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_SOURCE_TYPE IDWriteFontSet3::GetFontSourceType (UINT32 fontIndex)</b><br/>
	/// </summary>
	/// <param name="fontIndex"><b>UINT32 fontIndex</b></param>
	FontSourceType GetFontSourceType (uint fontIndex);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontSet3::GetFontSourceNameLength (UINT32 listIndex)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	uint GetFontSourceNameLength (uint listIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSet3::GetFontSourceName (UINT32 listIndex, WCHAR* stringBuffer, UINT32 stringBufferSize)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="stringBuffer">_Out_writes_z_(stringBufferSize) <b>WCHAR* stringBuffer</b></param>
	/// <param name="stringBufferSize"><b>UINT32 stringBufferSize</b></param>
	int GetFontSourceName (uint listIndex, char* stringBuffer, uint stringBufferSize);
}

/// <summary>
/// Instance of <b>IDWriteFontSet3</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontSet3 : IFontSet3 {
//unsafe public readonly struct IFontSet3Obj : IFontSet3 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontSet3* GetCurrentPointer () => (FontSet3*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontSet3Obj* GetCurrentPointer () => (IFontSet3Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x7c073ef2, 0xa7f4, 0x4045, 0x8c, 0x32, 0x8a, 0xb8, 0xae, 0x64, 0x0f, 0x90);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly IntPtr GetExpirationEvent () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExpirationEvent (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontSourceType GetFontSourceType (uint fontIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSourceType (ptr, fontIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontSourceNameLength (uint listIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSourceNameLength (ptr, listIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSourceName (uint listIndex, char* stringBuffer, uint stringBufferSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSourceName (ptr, listIndex, stringBuffer, stringBufferSize);
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
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr> GetExpirationEvent;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontSourceType> GetFontSourceType;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> GetFontSourceNameLength;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, int> GetFontSourceName;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
