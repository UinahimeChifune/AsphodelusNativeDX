using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFace2</b> : IDWriteFontFace1<br/>
/// DWRITE_2.h
/// </summary>
unsafe public interface IFontFace2 : IFontFace1 {
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFontFace2::IsColorFont ()</b><br/>
	/// </summary>
	bool IsColorFont ();
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontFace2::GetColorPaletteCount ()</b><br/>
	/// </summary>
	uint GetColorPaletteCount ();
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontFace2::GetPaletteEntryCount ()</b><br/>
	/// </summary>
	uint GetPaletteEntryCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace2::GetPaletteEntries (UINT32 colorPaletteIndex, UINT32 firstEntryIndex, UINT32 entryCount, DWRITE_COLOR_F* paletteEntries)</b><br/>
	/// </summary>
	/// <param name="colorPaletteIndex"><b>UINT32 colorPaletteIndex</b></param>
	/// <param name="firstEntryIndex"><b>UINT32 firstEntryIndex</b></param>
	/// <param name="entryCount"><b>UINT32 entryCount</b></param>
	/// <param name="paletteEntries">_Out_writes_(entryCount) <b>DWRITE_COLOR_F* paletteEntries</b></param>
	int GetPaletteEntries (uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Vector4F* paletteEntries);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace2::GetRecommendedRenderingMode (FLOAT fontEmSize, FLOAT dpiX, FLOAT dpiY, DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)</b><br/>
	/// </summary>
	/// <param name="fontEmSize"><b>FLOAT fontEmSize</b></param>
	/// <param name="dpiX"><b>FLOAT dpiX</b></param>
	/// <param name="dpiY"><b>FLOAT dpiY</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="outlineThreshold"><b>DWRITE_OUTLINE_THRESHOLD outlineThreshold</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	/// <param name="renderingParams">_In_opt_ <b>IDWriteRenderingParams* renderingParams</b></param>
	/// <param name="renderingMode">_Out_ <b>DWRITE_RENDERING_MODE* renderingMode</b></param>
	/// <param name="gridFitMode">_Out_ <b>DWRITE_GRID_FIT_MODE* gridFitMode</b></param>
	int GetRecommendedRenderingMode<T0> (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, T0* renderingParams, RenderingMode* renderingMode, GridFitMode* gridFitMode) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace2::GetRecommendedRenderingMode (FLOAT fontEmSize, FLOAT dpiX, FLOAT dpiY, DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)</b><br/>
	/// </summary>
	/// <param name="fontEmSize"><b>FLOAT fontEmSize</b></param>
	/// <param name="dpiX"><b>FLOAT dpiX</b></param>
	/// <param name="dpiY"><b>FLOAT dpiY</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="outlineThreshold"><b>DWRITE_OUTLINE_THRESHOLD outlineThreshold</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	/// <param name="renderingParams">_In_opt_ <b>IDWriteRenderingParams* renderingParams</b></param>
	/// <param name="renderingMode">_Out_ <b>DWRITE_RENDERING_MODE* renderingMode</b></param>
	/// <param name="gridFitMode">_Out_ <b>DWRITE_GRID_FIT_MODE* gridFitMode</b></param>
	int GetRecommendedRenderingMode<T0> (float fontEmSize, float dpiX, float dpiY, Matrix3x2F* transform, bool isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, T0* renderingParams, out RenderingMode renderingMode, out GridFitMode gridFitMode) where T0 : unmanaged, IRenderingParams;
}

/// <summary>
/// Instance of <b>IDWriteFontFace2</b><br/>
/// DWRITE_2.h
/// </summary>
unsafe public readonly struct FontFace2 : IFontFace2 {
//unsafe public readonly struct IFontFace2Obj : IFontFace2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFace2* GetCurrentPointer () => (FontFace2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFace2Obj* GetCurrentPointer () => (IFontFace2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xd8b768ff, 0x64bc, 0x4e66, 0x98, 0x2b, 0xec, 0x8e, 0x87, 0xf6, 0x93, 0xf7);

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
	public readonly int GetDesignGlyphMetrics (ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool fALSE) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesignGlyphMetrics (ptr, glyphIndices, glyphCount, glyphMetrics, fALSE ? 1U : 0U);
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
	public readonly int GetGdiCompatibleGlyphMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool fALSE) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleGlyphMetrics (ptr, emSize, pixelsPerDip, transform, useGdiNatural ? 1U : 0U, glyphIndices, glyphCount, glyphMetrics, fALSE ? 1U : 0U);
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
	public readonly int GetDesignGlyphAdvances (uint glyphCount, ushort* glyphIndices, int* glyphAdvances, bool fALSE) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesignGlyphAdvances (ptr, glyphCount, glyphIndices, glyphAdvances, fALSE ? 1U : 0U);
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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
