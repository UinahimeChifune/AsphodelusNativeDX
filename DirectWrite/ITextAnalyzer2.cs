using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextAnalyzer2</b> : IDWriteTextAnalyzer1<br/>
/// DWRITE_2.h
/// </summary>
unsafe public interface ITextAnalyzer2 : ITextAnalyzer1 {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer2::GetGlyphOrientationTransform (DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, BOOL isSideways, FLOAT originX, FLOAT originY, DWRITE_MATRIX* transform)</b><br/>
	/// </summary>
	/// <param name="glyphOrientationAngle"><b>DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="originX"><b>FLOAT originX</b></param>
	/// <param name="originY"><b>FLOAT originY</b></param>
	/// <param name="transform">_Out_ <b>DWRITE_MATRIX* transform</b></param>
	int GetGlyphOrientationTransform (GlyphOrientationAngle glyphOrientationAngle, bool isSideways, float originX, float originY, Matrix3x2F* transform);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer2::GetGlyphOrientationTransform (DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, BOOL isSideways, FLOAT originX, FLOAT originY, DWRITE_MATRIX* transform)</b><br/>
	/// </summary>
	/// <param name="glyphOrientationAngle"><b>DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="originX"><b>FLOAT originX</b></param>
	/// <param name="originY"><b>FLOAT originY</b></param>
	/// <param name="transform">_Out_ <b>DWRITE_MATRIX* transform</b></param>
	int GetGlyphOrientationTransform (GlyphOrientationAngle glyphOrientationAngle, bool isSideways, float originX, float originY, out Matrix3x2F transform);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer2::GetTypographicFeatures (IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, WCHAR* localeName, UINT32 maxTagCount, UINT32* actualTagCount, DWRITE_FONT_FEATURE_TAG* tags)</b><br/>
	/// </summary>
	/// <param name="fontFace"><b>IDWriteFontFace* fontFace</b></param>
	/// <param name="scriptAnalysis"><b>DWRITE_SCRIPT_ANALYSIS scriptAnalysis</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="maxTagCount"><b>UINT32 maxTagCount</b></param>
	/// <param name="actualTagCount">_Out_ <b>UINT32* actualTagCount</b></param>
	/// <param name="tags">_Out_writes_(maxTagCount) <b>DWRITE_FONT_FEATURE_TAG* tags</b></param>
	int GetTypographicFeatures<T0> (T0* fontFace, ScriptAnalysis scriptAnalysis, char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer2::GetTypographicFeatures (IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, WCHAR* localeName, UINT32 maxTagCount, UINT32* actualTagCount, DWRITE_FONT_FEATURE_TAG* tags)</b><br/>
	/// </summary>
	/// <param name="fontFace"><b>IDWriteFontFace* fontFace</b></param>
	/// <param name="scriptAnalysis"><b>DWRITE_SCRIPT_ANALYSIS scriptAnalysis</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="maxTagCount"><b>UINT32 maxTagCount</b></param>
	/// <param name="actualTagCount">_Out_ <b>UINT32* actualTagCount</b></param>
	/// <param name="tags">_Out_writes_(maxTagCount) <b>DWRITE_FONT_FEATURE_TAG* tags</b></param>
	int GetTypographicFeatures<T0> (T0* fontFace, ScriptAnalysis scriptAnalysis, char* localeName, uint maxTagCount, out uint actualTagCount, FontFeatureTag* tags) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer2::CheckTypographicFeature (IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, WCHAR* localeName, DWRITE_FONT_FEATURE_TAG featureTag, UINT32 glyphCount, UINT16* glyphIndices, UINT8* featureApplies)</b><br/>
	/// </summary>
	/// <param name="fontFace"><b>IDWriteFontFace* fontFace</b></param>
	/// <param name="scriptAnalysis"><b>DWRITE_SCRIPT_ANALYSIS scriptAnalysis</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="featureTag"><b>DWRITE_FONT_FEATURE_TAG featureTag</b></param>
	/// <param name="glyphCount"><b>UINT32 glyphCount</b></param>
	/// <param name="glyphIndices">_In_reads_(glyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="featureApplies">_Out_writes_(glyphCount) <b>UINT8* featureApplies</b></param>
	int CheckTypographicFeature<T0> (T0* fontFace, ScriptAnalysis scriptAnalysis, char* localeName, FontFeatureTag featureTag, uint glyphCount, ushort* glyphIndices, byte* featureApplies) where T0 : unmanaged, IFontFace;
}

/// <summary>
/// Instance of <b>IDWriteTextAnalyzer2</b><br/>
/// DWRITE_2.h
/// </summary>
unsafe public readonly struct TextAnalyzer2 : ITextAnalyzer2 {
//unsafe public readonly struct ITextAnalyzer2Obj : ITextAnalyzer2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextAnalyzer2* GetCurrentPointer () => (TextAnalyzer2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextAnalyzer2Obj* GetCurrentPointer () => (ITextAnalyzer2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x553a9ff3, 0x5693, 0x4df7, 0xb5, 0x2b, 0x74, 0x80, 0x6f, 0x7f, 0x2e, 0xb9);

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
	public readonly int AnalyzeScript<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AnalyzeScript (ptr, analysisSource, textPosition, textLength, analysisSink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AnalyzeBidi<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AnalyzeBidi (ptr, analysisSource, textPosition, textLength, analysisSink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AnalyzeNumberSubstitution<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AnalyzeNumberSubstitution (ptr, analysisSource, textPosition, textLength, analysisSink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AnalyzeLineBreakpoints<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AnalyzeLineBreakpoints (ptr, analysisSource, textPosition, textLength, analysisSink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphs<T0, T1> (char* textString, uint textLength, T0* fontFace, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, T1* numberSubstitution, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where T0 : unmanaged, IFontFace where T1 : unmanaged, INumberSubstitution {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphs (ptr, textString, textLength, fontFace, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphs<T0, T1> (char* textString, uint textLength, T0* fontFace, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, T1* numberSubstitution, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, out uint actualGlyphCount) where T0 : unmanaged, IFontFace where T1 : unmanaged, INumberSubstitution {
		fixed (uint* _actualGlyphCount = &actualGlyphCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphs (ptr, textString, textLength, fontFace, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, _actualGlyphCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphPlacements<T0> (char* textString, ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint glyphCount, T0* fontFace, float fontEmSize, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphPlacements (ptr, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleGlyphPlacements<T0> (char* textString, ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint glyphCount, T0* fontFace, float fontEmSize, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleGlyphPlacements (ptr, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural ? 1U : 0U, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ApplyCharacterSpacing (float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, uint textLength, uint glyphCount, ushort* clusterMap, float* glyphAdvances, GlyphOffset* glyphOffsets, ShapingGlyphProperties* glyphProperties, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ApplyCharacterSpacing (ptr, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textLength, glyphCount, clusterMap, glyphAdvances, glyphOffsets, glyphProperties, modifiedGlyphAdvances, modifiedGlyphOffsets);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBaseline<T0> (T0* fontFace, Baseline baseline, bool isVertical, bool isSimulationAllowed, ScriptAnalysis scriptAnalysis, char* localeName, int* baselineCoordinate, uint* exists) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBaseline (ptr, fontFace, baseline, isVertical ? 1U : 0U, isSimulationAllowed ? 1U : 0U, scriptAnalysis, localeName, baselineCoordinate, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBaseline<T0> (T0* fontFace, Baseline baseline, bool isVertical, bool isSimulationAllowed, ScriptAnalysis scriptAnalysis, char* localeName, out int baselineCoordinate, out bool exists) where T0 : unmanaged, IFontFace {
		fixed (int* _baselineCoordinate = &baselineCoordinate) {
			uint _exists;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetBaseline (ptr, fontFace, baseline, isVertical ? 1U : 0U, isSimulationAllowed ? 1U : 0U, scriptAnalysis, localeName, _baselineCoordinate, &_exists);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AnalyzeVerticalGlyphOrientation<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource1 where T1 : unmanaged, ITextAnalysisSink1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AnalyzeVerticalGlyphOrientation (ptr, analysisSource, textPosition, textLength, analysisSink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphOrientationTransform (GlyphOrientationAngle glyphOrientationAngle, bool isSideways, Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphOrientationTransform (ptr, glyphOrientationAngle, isSideways ? 1U : 0U, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphOrientationTransform (GlyphOrientationAngle glyphOrientationAngle, bool isSideways, out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphOrientationTransform (ptr, glyphOrientationAngle, isSideways ? 1U : 0U, _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetScriptProperties (ScriptAnalysis scriptAnalysis, ScriptProperties* scriptProperties) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetScriptProperties (ptr, scriptAnalysis, scriptProperties);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetScriptProperties (ScriptAnalysis scriptAnalysis, out ScriptProperties scriptProperties) {
		fixed (ScriptProperties* _scriptProperties = &scriptProperties) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetScriptProperties (ptr, scriptAnalysis, _scriptProperties);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTextComplexity<T0> (char* textString, uint textLength, T0* fontFace, uint* isTextSimple, uint* textLengthRead, ushort* glyphIndices) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextComplexity (ptr, textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTextComplexity<T0> (char* textString, uint textLength, T0* fontFace, out bool isTextSimple, out uint textLengthRead, ushort* glyphIndices) where T0 : unmanaged, IFontFace {
		uint _isTextSimple;
		fixed (uint* _textLengthRead = &textLengthRead) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetTextComplexity (ptr, textString, textLength, fontFace, &_isTextSimple, _textLengthRead, glyphIndices);
			isTextSimple = _isTextSimple != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetJustificationOpportunities<T0> (T0* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, char* textString, ushort* clusterMap, ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetJustificationOpportunities (ptr, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int JustifyGlyphAdvances (float lineWidth, uint glyphCount, JustificationOpportunity* justificationOpportunities, float* glyphAdvances, GlyphOffset* glyphOffsets, float* justifiedGlyphAdvances, GlyphOffset* justifiedGlyphOffsets) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->JustifyGlyphAdvances (ptr, lineWidth, glyphCount, justificationOpportunities, glyphAdvances, glyphOffsets, justifiedGlyphAdvances, justifiedGlyphOffsets);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetJustifiedGlyphs<T0> (T0* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, ushort* clusterMap, ushort* glyphIndices, float* glyphAdvances, float* justifiedGlyphAdvances, GlyphOffset* justifiedGlyphOffsets, ShapingGlyphProperties* glyphProperties, uint* actualGlyphCount, ushort* modifiedClusterMap, ushort* modifiedGlyphIndices, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetJustifiedGlyphs (ptr, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetJustifiedGlyphs<T0> (T0* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, ushort* clusterMap, ushort* glyphIndices, float* glyphAdvances, float* justifiedGlyphAdvances, GlyphOffset* justifiedGlyphOffsets, ShapingGlyphProperties* glyphProperties, out uint actualGlyphCount, ushort* modifiedClusterMap, ushort* modifiedGlyphIndices, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets) where T0 : unmanaged, IFontFace {
		fixed (uint* _actualGlyphCount = &actualGlyphCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetJustifiedGlyphs (ptr, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, _actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphOrientationTransform (GlyphOrientationAngle glyphOrientationAngle, bool isSideways, float originX, float originY, Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetGlyphOrientationTransform (ptr, glyphOrientationAngle, isSideways ? 1U : 0U, originX, originY, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphOrientationTransform (GlyphOrientationAngle glyphOrientationAngle, bool isSideways, float originX, float originY, out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetGlyphOrientationTransform (ptr, glyphOrientationAngle, isSideways ? 1U : 0U, originX, originY, _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTypographicFeatures<T0> (T0* fontFace, ScriptAnalysis scriptAnalysis, char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTypographicFeatures (ptr, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTypographicFeatures<T0> (T0* fontFace, ScriptAnalysis scriptAnalysis, char* localeName, uint maxTagCount, out uint actualTagCount, FontFeatureTag* tags) where T0 : unmanaged, IFontFace {
		fixed (uint* _actualTagCount = &actualTagCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetTypographicFeatures (ptr, fontFace, scriptAnalysis, localeName, maxTagCount, _actualTagCount, tags);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckTypographicFeature<T0> (T0* fontFace, ScriptAnalysis scriptAnalysis, char* localeName, FontFeatureTag featureTag, uint glyphCount, ushort* glyphIndices, byte* featureApplies) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckTypographicFeature (ptr, fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, int> AnalyzeScript;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, int> AnalyzeBidi;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, int> AnalyzeNumberSubstitution;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, int> AnalyzeLineBreakpoints;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, void*, uint, uint, ScriptAnalysis*, char*, void*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int> GetGlyphs;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, void*, float, uint, uint, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int> GetGlyphPlacements;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, void*, float, float, Matrix3x2F*, uint, uint, uint, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int> GetGdiCompatibleGlyphPlacements;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, uint, uint, ushort*, float*, GlyphOffset*, ShapingGlyphProperties*, float*, GlyphOffset*, int> ApplyCharacterSpacing;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Baseline, uint, uint, ScriptAnalysis, char*, int*, uint*, int> GetBaseline;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, int> AnalyzeVerticalGlyphOrientation;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphOrientationAngle, uint, Matrix3x2F*, int> GetGlyphOrientationTransform;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ScriptAnalysis, ScriptProperties*, int> GetScriptProperties;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, void*, uint*, uint*, ushort*, int> GetTextComplexity;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, ScriptAnalysis, uint, uint, char*, ushort*, ShapingGlyphProperties*, JustificationOpportunity*, int> GetJustificationOpportunities;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, uint, JustificationOpportunity*, float*, GlyphOffset*, float*, GlyphOffset*, int> JustifyGlyphAdvances;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, ScriptAnalysis, uint, uint, uint, ushort*, ushort*, float*, float*, GlyphOffset*, ShapingGlyphProperties*, uint*, ushort*, ushort*, float*, GlyphOffset*, int> GetJustifiedGlyphs;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphOrientationAngle, uint, float, float, Matrix3x2F*, int> _GetGlyphOrientationTransform;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int> GetTypographicFeatures;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ScriptAnalysis, char*, FontFeatureTag, uint, ushort*, byte*, int> CheckTypographicFeature;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
