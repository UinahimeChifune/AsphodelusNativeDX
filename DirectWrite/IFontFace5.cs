using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFace5</b> : IDWriteFontFace4<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontFace5 : IFontFace4 {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontFace5::GetFontAxisValueCount ()</b><br/>
	/// </summary>
	uint GetFontAxisValueCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace5::GetFontAxisValues (DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisValues">_Out_writes_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	int GetFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount);
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFontFace5::HasVariations ()</b><br/>
	/// </summary>
	bool HasVariations ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace5::GetFontResource (IDWriteFontResource** fontResource)</b><br/>
	/// </summary>
	/// <param name="fontResource">_COM_Outptr_ <b>IDWriteFontResource** fontResource</b></param>
	int GetFontResource<T0> (T0** fontResource) where T0 : unmanaged, IFontResource;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace5::GetFontResource (IDWriteFontResource** fontResource)</b><br/>
	/// </summary>
	/// <param name="fontResource">_COM_Outptr_ <b>IDWriteFontResource** fontResource</b></param>
	int GetFontResource<T0> (out T0* fontResource) where T0 : unmanaged, IFontResource;
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFontFace5::Equals (IDWriteFontFace* fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFace"><b>IDWriteFontFace* fontFace</b></param>
	bool Equals<T0> (T0* fontFace) where T0 : unmanaged, IFontFace;
}

/// <summary>
/// Instance of <b>IDWriteFontFace5</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontFace5 : IFontFace5 {
//unsafe public readonly struct IFontFace5Obj : IFontFace5 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFace5* GetCurrentPointer () => (FontFace5*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFace5Obj* GetCurrentPointer () => (IFontFace5Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x98eff3a5, 0xb667, 0x479a, 0xb1, 0x45, 0xe2, 0xfa, 0x5b, 0x9f, 0xdc, 0x29);

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
	public readonly FontFaceType GetFontFaceType () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFiles<T0> (uint* numberOfFiles, T0** fontFiles) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFiles (ptr, numberOfFiles, (void**) fontFiles);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFiles<T0> (uint* numberOfFiles, out T0* fontFiles) where T0 : unmanaged, IFontFile {
		fixed (T0** _fontFiles = &fontFiles) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFiles (ptr, numberOfFiles, (void**) _fontFiles);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetIndex () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetIndex (ptr);
		return hr;
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
	public readonly bool IsSymbolFont () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsSymbolFont (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (FontMetrics* fontFaceMetrics) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, fontFaceMetrics);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (out FontMetrics fontFaceMetrics) {
		fixed (FontMetrics* _fontFaceMetrics = &fontFaceMetrics) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, _fontFaceMetrics);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ushort GetGlyphCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesignGlyphMetrics (ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool isSideways) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesignGlyphMetrics (ptr, glyphIndices, glyphCount, glyphMetrics, isSideways ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphIndices (uint* codePoints, uint codePointCount, ushort* glyphIndices) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphIndices (ptr, codePoints, codePointCount, glyphIndices);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TryGetFontTable (uint openTypeTableTag, void** tableData, uint* tableSize, void** tableContext, uint* exists) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->TryGetFontTable (ptr, openTypeTableTag, tableData, tableSize, tableContext, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TryGetFontTable (uint openTypeTableTag, out void* tableData, out uint tableSize, out void* tableContext, out bool exists) {
		fixed (void** _tableData = &tableData) {
			fixed (uint* _tableSize = &tableSize) {
				fixed (void** _tableContext = &tableContext) {
					uint _exists;
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->TryGetFontTable (ptr, openTypeTableTag, _tableData, _tableSize, _tableContext, &_exists);
					exists = _exists != 0;
					return hr;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ReleaseFontTable (void* tableContext) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ReleaseFontTable (ptr, tableContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphRunOutline<T0> (float emSize, ushort* glyphIndices, float* glyphAdvances, GlyphOffset* glyphOffsets, uint glyphCount, bool isSideways, bool isRightToLeft, T0* geometrySink) where T0 : unmanaged, Direct2D.ISimplifiedGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphRunOutline (ptr, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float emSize, float pixelsPerDip, MeasuringMode measuringMode, T0* renderingParams, RenderingMode* renderingMode) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRecommendedRenderingMode (ptr, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float emSize, float pixelsPerDip, MeasuringMode measuringMode, T0* renderingParams, out RenderingMode renderingMode) where T0 : unmanaged, IRenderingParams {
		fixed (RenderingMode* _renderingMode = &renderingMode) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetRecommendedRenderingMode (ptr, emSize, pixelsPerDip, measuringMode, renderingParams, _renderingMode);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, FontMetrics* fontFaceMetrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleMetrics (ptr, emSize, pixelsPerDip, transform, fontFaceMetrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, out FontMetrics fontFaceMetrics) {
		fixed (FontMetrics* _fontFaceMetrics = &fontFaceMetrics) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleMetrics (ptr, emSize, pixelsPerDip, transform, _fontFaceMetrics);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleGlyphMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool isSideways) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleGlyphMetrics (ptr, emSize, pixelsPerDip, transform, useGdiNatural ? 1U : 0U, glyphIndices, glyphCount, glyphMetrics, isSideways ? 1U : 0U);
		return hr;
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
	public readonly int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, FontMetrics1* fontMetrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleMetrics1 (ptr, emSize, pixelsPerDip, transform, fontMetrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, out FontMetrics1 fontMetrics) {
		fixed (FontMetrics1* _fontMetrics = &fontMetrics) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleMetrics1 (ptr, emSize, pixelsPerDip, transform, _fontMetrics);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetCaretMetrics (CaretMetrics* caretMetrics) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetCaretMetrics (ptr, caretMetrics);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetCaretMetrics (out CaretMetrics caretMetrics) {
		fixed (CaretMetrics* _caretMetrics = &caretMetrics) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetCaretMetrics (ptr, _caretMetrics);
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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesignGlyphAdvances (uint glyphCount, ushort* glyphIndices, int* glyphAdvances, bool isSideways) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesignGlyphAdvances (ptr, glyphCount, glyphIndices, glyphAdvances, isSideways ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleGlyphAdvances (float emSize, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, bool isSideways, uint glyphCount, ushort* glyphIndices, int* glyphAdvances) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleGlyphAdvances (ptr, emSize, pixelsPerDip, transform, useGdiNatural ? 1U : 0U, isSideways ? 1U : 0U, glyphCount, glyphIndices, glyphAdvances);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetKerningPairAdjustments (uint glyphCount, ushort* glyphIndices, int* glyphAdvanceAdjustments) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetKerningPairAdjustments (ptr, glyphCount, glyphIndices, glyphAdvanceAdjustments);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool HasKerningPairs () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasKerningPairs (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, RenderingMode* renderingMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetRecommendedRenderingMode (ptr, fontEmSize, dpiX, dpiY, transform, isSideways ? 1U : 0U, outlineThreshold, measuringMode, renderingMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, out RenderingMode renderingMode) {
		fixed (RenderingMode* _renderingMode = &renderingMode) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetRecommendedRenderingMode (ptr, fontEmSize, dpiX, dpiY, transform, isSideways ? 1U : 0U, outlineThreshold, measuringMode, _renderingMode);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVerticalGlyphVariants (uint glyphCount, ushort* nominalGlyphIndices, ushort* verticalGlyphIndices) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVerticalGlyphVariants (ptr, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool HasVerticalGlyphVariants () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasVerticalGlyphVariants (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsColorFont () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsColorFont (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetColorPaletteCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorPaletteCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetPaletteEntryCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPaletteEntryCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPaletteEntries (uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Vector4F* paletteEntries) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPaletteEntries (ptr, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, T0* renderingParams, RenderingMode* renderingMode, GridFitMode* gridFitMode) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__GetRecommendedRenderingMode (ptr, fontEmSize, dpiX, dpiY, transform, isSideways ? 1U : 0U, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, T0* renderingParams, out RenderingMode renderingMode, out GridFitMode gridFitMode) where T0 : unmanaged, IRenderingParams {
		fixed (RenderingMode* _renderingMode = &renderingMode) {
			fixed (GridFitMode* _gridFitMode = &gridFitMode) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->__GetRecommendedRenderingMode (ptr, fontEmSize, dpiX, dpiY, transform, isSideways ? 1U : 0U, outlineThreshold, measuringMode, renderingParams, _renderingMode, _gridFitMode);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFaceReference<T0> (T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceReference (ptr, (void**) fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFaceReference<T0> (out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		fixed (T0** _fontFaceReference = &fontFaceReference) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceReference (ptr, (void**) _fontFaceReference);
			return hr;
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
	public readonly bool HasCharacter (uint unicodeValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasCharacter (ptr, unicodeValue) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, T0* renderingParams, RenderingMode1* renderingMode, GridFitMode* gridFitMode) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__GetRecommendedRenderingMode1 (ptr, fontEmSize, dpiX, dpiY, transform, isSideways ? 1U : 0U, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, T0* renderingParams, out RenderingMode1 renderingMode, out GridFitMode gridFitMode) where T0 : unmanaged, IRenderingParams {
		fixed (RenderingMode1* _renderingMode = &renderingMode) {
			fixed (GridFitMode* _gridFitMode = &gridFitMode) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->__GetRecommendedRenderingMode1 (ptr, fontEmSize, dpiX, dpiY, transform, isSideways ? 1U : 0U, outlineThreshold, measuringMode, renderingParams, _renderingMode, _gridFitMode);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsCharacterLocal (uint unicodeValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsCharacterLocal (ptr, unicodeValue) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsGlyphLocal (ushort glyphId) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsGlyphLocal (ptr, glyphId) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AreCharactersLocal (char* characters, uint characterCount, bool enqueueIfNotLocal, uint* isLocal) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AreCharactersLocal (ptr, characters, characterCount, enqueueIfNotLocal ? 1U : 0U, isLocal);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AreCharactersLocal (char* characters, uint characterCount, bool enqueueIfNotLocal, out bool isLocal) {
		uint _isLocal;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AreCharactersLocal (ptr, characters, characterCount, enqueueIfNotLocal ? 1U : 0U, &_isLocal);
		isLocal = _isLocal != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AreGlyphsLocal (ushort* glyphIndices, uint glyphCount, bool enqueueIfNotLocal, uint* isLocal) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AreGlyphsLocal (ptr, glyphIndices, glyphCount, enqueueIfNotLocal ? 1U : 0U, isLocal);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AreGlyphsLocal (ushort* glyphIndices, uint glyphCount, bool enqueueIfNotLocal, out bool isLocal) {
		uint _isLocal;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AreGlyphsLocal (ptr, glyphIndices, glyphCount, enqueueIfNotLocal ? 1U : 0U, &_isLocal);
		isLocal = _isLocal != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly GlyphImageFormats GetGlyphImageFormats () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphImageFormats (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphImageFormats (ushort glyphId, uint pixelsPerEmFirst, uint pixelsPerEmLast, GlyphImageFormats* glyphImageFormats) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetGlyphImageFormats (ptr, glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphImageFormats (ushort glyphId, uint pixelsPerEmFirst, uint pixelsPerEmLast, out GlyphImageFormats glyphImageFormats) {
		fixed (GlyphImageFormats* _glyphImageFormats = &glyphImageFormats) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetGlyphImageFormats (ptr, glyphId, pixelsPerEmFirst, pixelsPerEmLast, _glyphImageFormats);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphImageData (ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, void** glyphDataContext) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphImageData (ptr, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphImageData (ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, out GlyphImageData glyphData, out void* glyphDataContext) {
		fixed (GlyphImageData* _glyphData = &glyphData) {
			fixed (void** _glyphDataContext = &glyphDataContext) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphImageData (ptr, glyphId, pixelsPerEm, glyphImageFormat, _glyphData, _glyphDataContext);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ReleaseGlyphImageData (void* glyphDataContext) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ReleaseGlyphImageData (ptr, glyphDataContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontAxisValueCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisValueCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisValues (ptr, fontAxisValues, fontAxisValueCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool HasVariations () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasVariations (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontResource<T0> (T0** fontResource) where T0 : unmanaged, IFontResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontResource (ptr, (void**) fontResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontResource<T0> (out T0* fontResource) where T0 : unmanaged, IFontResource {
		fixed (T0** _fontResource = &fontResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontResource (ptr, (void**) _fontResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool Equals<T0> (T0* fontFace) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_Equals (ptr, fontFace) != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, FontFaceType> _GetType;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, void**, int> GetFiles;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetIndex;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontSimulations> GetSimulations;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsSymbolFont;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontMetrics*, void> GetMetrics;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort> GetGlyphCount;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort*, uint, GlyphMetrics*, uint, int> GetDesignGlyphMetrics;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint, ushort*, int> GetGlyphIndices;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, uint*, void**, uint*, int> TryGetFontTable;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ReleaseFontTable;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, ushort*, float*, GlyphOffset*, uint, uint, uint, void*, int> GetGlyphRunOutline;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, MeasuringMode, void*, RenderingMode*, int> GetRecommendedRenderingMode;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, Matrix3x2F*, FontMetrics*, int> GetGdiCompatibleMetrics;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, Matrix3x2F*, uint, ushort*, uint, GlyphMetrics*, uint, int> GetGdiCompatibleGlyphMetrics;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontMetrics1*, void> GetMetrics1;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, Matrix3x2F*, FontMetrics1*, int> GetGdiCompatibleMetrics1;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CaretMetrics*, void> GetCaretMetrics;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, UnicodeRange*, uint*, int> GetUnicodeRanges;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsMonospacedFont;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ushort*, int*, uint, int> GetDesignGlyphAdvances;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, Matrix3x2F*, uint, uint, uint, ushort*, int*, int> GetGdiCompatibleGlyphAdvances;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ushort*, int*, int> GetKerningPairAdjustments;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> HasKerningPairs;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, Matrix3x2F*, uint, OutlineThreshold, MeasuringMode, RenderingMode*, int> _GetRecommendedRenderingMode;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ushort*, ushort*, int> GetVerticalGlyphVariants;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> HasVerticalGlyphVariants;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsColorFont;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetColorPaletteCount;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetPaletteEntryCount;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, Vector4F*, int> GetPaletteEntries;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, Matrix3x2F*, uint, OutlineThreshold, MeasuringMode, void*, RenderingMode*, GridFitMode*, int> __GetRecommendedRenderingMode;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontFaceReference;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Panose*, void> GetPanose;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontWeight> GetWeight;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStretch> GetStretch;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStyle> GetStyle;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFamilyNames;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFaceNames;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InformationalStringId, void**, uint*, int> GetInformationalStrings;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> HasCharacter;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, Matrix3x2F*, uint, OutlineThreshold, MeasuringMode, void*, RenderingMode1*, GridFitMode*, int> __GetRecommendedRenderingMode1;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> IsCharacterLocal;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort, uint> IsGlyphLocal;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, uint, uint*, int> AreCharactersLocal;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort*, uint, uint, uint*, int> AreGlyphsLocal;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphImageFormats> GetGlyphImageFormats;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort, uint, uint, GlyphImageFormats*, int> _GetGlyphImageFormats;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int> GetGlyphImageData;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ReleaseGlyphImageData;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontAxisValueCount;
		/// <summary>
		/// OFFSET 54
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisValue*, uint, int> GetFontAxisValues;
		/// <summary>
		/// OFFSET 55
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> HasVariations;
		/// <summary>
		/// OFFSET 56
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontResource;
		/// <summary>
		/// OFFSET 57
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint> _Equals;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
