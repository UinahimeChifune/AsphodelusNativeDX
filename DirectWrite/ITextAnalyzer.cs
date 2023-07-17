using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextAnalyzer</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ITextAnalyzer : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::AnalyzeScript (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteTextAnalysisSink* analysisSink)</b><br/>
	/// </summary>
	/// <param name="analysisSource">_In_ <b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="analysisSink">_In_ <b>IDWriteTextAnalysisSink* analysisSink</b></param>
	int AnalyzeScript<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::AnalyzeBidi (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteTextAnalysisSink* analysisSink)</b><br/>
	/// </summary>
	/// <param name="analysisSource">_In_ <b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="analysisSink">_In_ <b>IDWriteTextAnalysisSink* analysisSink</b></param>
	int AnalyzeBidi<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::AnalyzeNumberSubstitution (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteTextAnalysisSink* analysisSink)</b><br/>
	/// </summary>
	/// <param name="analysisSource">_In_ <b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="analysisSink">_In_ <b>IDWriteTextAnalysisSink* analysisSink</b></param>
	int AnalyzeNumberSubstitution<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::AnalyzeLineBreakpoints (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteTextAnalysisSink* analysisSink)</b><br/>
	/// </summary>
	/// <param name="analysisSource">_In_ <b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="analysisSink">_In_ <b>IDWriteTextAnalysisSink* analysisSink</b></param>
	int AnalyzeLineBreakpoints<T0, T1> (T0* analysisSource, uint textPosition, uint textLength, T1* analysisSink) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, ITextAnalysisSink;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::GetGlyphs (WCHAR* textString, UINT32 textLength, IDWriteFontFace* fontFace, BOOL isSideways, BOOL isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, WCHAR* localeName, IDWriteNumberSubstitution* numberSubstitution, DWRITE_TYPOGRAPHIC_FEATURES** features, UINT32* featureRangeLengths, UINT32 featureRanges, UINT32 maxGlyphCount, UINT16* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, UINT16* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, UINT32* actualGlyphCount)</b><br/>
	/// </summary>
	/// <param name="textString">_In_reads_(textLength) <b>WCHAR* textString</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	/// <param name="scriptAnalysis">_In_ <b>DWRITE_SCRIPT_ANALYSIS* scriptAnalysis</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="numberSubstitution">_In_opt_ <b>IDWriteNumberSubstitution* numberSubstitution</b></param>
	/// <param name="features">_In_reads_opt_(featureRanges) <b>DWRITE_TYPOGRAPHIC_FEATURES** features</b></param>
	/// <param name="featureRangeLengths">_In_reads_opt_(featureRanges) <b>UINT32* featureRangeLengths</b></param>
	/// <param name="featureRanges"><b>UINT32 featureRanges</b></param>
	/// <param name="maxGlyphCount"><b>UINT32 maxGlyphCount</b></param>
	/// <param name="clusterMap">_Out_writes_(textLength) <b>UINT16* clusterMap</b></param>
	/// <param name="textProps">_Out_writes_(textLength) <b>DWRITE_SHAPING_TEXT_PROPERTIES* textProps</b></param>
	/// <param name="glyphIndices">_Out_writes_(maxGlyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphProps">_Out_writes_(maxGlyphCount) <b>DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps</b></param>
	/// <param name="actualGlyphCount">_Out_ <b>UINT32* actualGlyphCount</b></param>
	int GetGlyphs<T0, T1> (char* textString, uint textLength, T0* fontFace, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, T1* numberSubstitution, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where T0 : unmanaged, IFontFace where T1 : unmanaged, INumberSubstitution;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::GetGlyphs (WCHAR* textString, UINT32 textLength, IDWriteFontFace* fontFace, BOOL isSideways, BOOL isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, WCHAR* localeName, IDWriteNumberSubstitution* numberSubstitution, DWRITE_TYPOGRAPHIC_FEATURES** features, UINT32* featureRangeLengths, UINT32 featureRanges, UINT32 maxGlyphCount, UINT16* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, UINT16* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, UINT32* actualGlyphCount)</b><br/>
	/// </summary>
	/// <param name="textString">_In_reads_(textLength) <b>WCHAR* textString</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	/// <param name="scriptAnalysis">_In_ <b>DWRITE_SCRIPT_ANALYSIS* scriptAnalysis</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="numberSubstitution">_In_opt_ <b>IDWriteNumberSubstitution* numberSubstitution</b></param>
	/// <param name="features">_In_reads_opt_(featureRanges) <b>DWRITE_TYPOGRAPHIC_FEATURES** features</b></param>
	/// <param name="featureRangeLengths">_In_reads_opt_(featureRanges) <b>UINT32* featureRangeLengths</b></param>
	/// <param name="featureRanges"><b>UINT32 featureRanges</b></param>
	/// <param name="maxGlyphCount"><b>UINT32 maxGlyphCount</b></param>
	/// <param name="clusterMap">_Out_writes_(textLength) <b>UINT16* clusterMap</b></param>
	/// <param name="textProps">_Out_writes_(textLength) <b>DWRITE_SHAPING_TEXT_PROPERTIES* textProps</b></param>
	/// <param name="glyphIndices">_Out_writes_(maxGlyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphProps">_Out_writes_(maxGlyphCount) <b>DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps</b></param>
	/// <param name="actualGlyphCount">_Out_ <b>UINT32* actualGlyphCount</b></param>
	int GetGlyphs<T0, T1> (char* textString, uint textLength, T0* fontFace, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, T1* numberSubstitution, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, out uint actualGlyphCount) where T0 : unmanaged, IFontFace where T1 : unmanaged, INumberSubstitution;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::GetGlyphPlacements (WCHAR* textString, UINT16* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, UINT32 textLength, UINT16* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, UINT32 glyphCount, IDWriteFontFace* fontFace, FLOAT fontEmSize, BOOL isSideways, BOOL isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, WCHAR* localeName, DWRITE_TYPOGRAPHIC_FEATURES** features, UINT32* featureRangeLengths, UINT32 featureRanges, FLOAT* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets)</b><br/>
	/// </summary>
	/// <param name="textString">_In_reads_(textLength) <b>WCHAR* textString</b></param>
	/// <param name="clusterMap">_In_reads_(textLength) <b>UINT16* clusterMap</b></param>
	/// <param name="textProps">_Inout_updates_(textLength) <b>DWRITE_SHAPING_TEXT_PROPERTIES* textProps</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="glyphIndices">_In_reads_(glyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphProps">_In_reads_(glyphCount) <b>DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps</b></param>
	/// <param name="glyphCount"><b>UINT32 glyphCount</b></param>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="fontEmSize"><b>FLOAT fontEmSize</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	/// <param name="scriptAnalysis">_In_ <b>DWRITE_SCRIPT_ANALYSIS* scriptAnalysis</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="features">_In_reads_opt_(featureRanges) <b>DWRITE_TYPOGRAPHIC_FEATURES** features</b></param>
	/// <param name="featureRangeLengths">_In_reads_opt_(featureRanges) <b>UINT32* featureRangeLengths</b></param>
	/// <param name="featureRanges"><b>UINT32 featureRanges</b></param>
	/// <param name="glyphAdvances">_Out_writes_(glyphCount) <b>FLOAT* glyphAdvances</b></param>
	/// <param name="glyphOffsets">_Out_writes_(glyphCount) <b>DWRITE_GLYPH_OFFSET* glyphOffsets</b></param>
	int GetGlyphPlacements<T0> (char* textString, ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint glyphCount, T0* fontFace, float fontEmSize, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalyzer::GetGdiCompatibleGlyphPlacements (WCHAR* textString, UINT16* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, UINT32 textLength, UINT16* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, UINT32 glyphCount, IDWriteFontFace* fontFace, FLOAT fontEmSize, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, BOOL useGdiNatural, BOOL isSideways, BOOL isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, WCHAR* localeName, DWRITE_TYPOGRAPHIC_FEATURES** features, UINT32* featureRangeLengths, UINT32 featureRanges, FLOAT* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets)</b><br/>
	/// </summary>
	/// <param name="textString">_In_reads_(textLength) <b>WCHAR* textString</b></param>
	/// <param name="clusterMap">_In_reads_(textLength) <b>UINT16* clusterMap</b></param>
	/// <param name="textProps">_In_reads_(textLength) <b>DWRITE_SHAPING_TEXT_PROPERTIES* textProps</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="glyphIndices">_In_reads_(glyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphProps">_In_reads_(glyphCount) <b>DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps</b></param>
	/// <param name="glyphCount"><b>UINT32 glyphCount</b></param>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="fontEmSize"><b>FLOAT fontEmSize</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="useGdiNatural"><b>BOOL useGdiNatural</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	/// <param name="scriptAnalysis">_In_ <b>DWRITE_SCRIPT_ANALYSIS* scriptAnalysis</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="features">_In_reads_opt_(featureRanges) <b>DWRITE_TYPOGRAPHIC_FEATURES** features</b></param>
	/// <param name="featureRangeLengths">_In_reads_opt_(featureRanges) <b>UINT32* featureRangeLengths</b></param>
	/// <param name="featureRanges"><b>UINT32 featureRanges</b></param>
	/// <param name="glyphAdvances">_Out_writes_(glyphCount) <b>FLOAT* glyphAdvances</b></param>
	/// <param name="glyphOffsets">_Out_writes_(glyphCount) <b>DWRITE_GLYPH_OFFSET* glyphOffsets</b></param>
	int GetGdiCompatibleGlyphPlacements<T0> (char* textString, ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint glyphCount, T0* fontFace, float fontEmSize, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, bool isSideways, bool isRightToLeft, ScriptAnalysis* scriptAnalysis, char* localeName, TypographicFeatures** features, uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where T0 : unmanaged, IFontFace;
}

/// <summary>
/// Instance of <b>IDWriteTextAnalyzer</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct TextAnalyzer : ITextAnalyzer {
//unsafe public readonly struct ITextAnalyzerObj : ITextAnalyzer {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextAnalyzer* GetCurrentPointer () => (TextAnalyzer*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextAnalyzerObj* GetCurrentPointer () => (ITextAnalyzerObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb7e6163e, 0x7f46, 0x43b4, 0x84, 0xb3, 0xe4, 0xe6, 0x24, 0x9c, 0x36, 0x5d);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
