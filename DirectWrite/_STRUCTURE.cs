using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// STRUCTURE <b>DWRITE_FONT_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FontMetrics {

	/// <summary>
	/// <b>UINT16 designUnitsPerEm</b>
	/// </summary>
	public readonly ushort DesignUnitsPerEm {
		get => _designUnitsPerEm;
		init => _designUnitsPerEm = value;
	}
	readonly ushort _designUnitsPerEm;

	/// <summary>
	/// <b>UINT16 ascent</b>
	/// </summary>
	public readonly ushort Ascent {
		get => _ascent;
		init => _ascent = value;
	}
	readonly ushort _ascent;

	/// <summary>
	/// <b>UINT16 descent</b>
	/// </summary>
	public readonly ushort Descent {
		get => _descent;
		init => _descent = value;
	}
	readonly ushort _descent;

	/// <summary>
	/// <b>INT16 lineGap</b>
	/// </summary>
	public readonly short LineGap {
		get => _lineGap;
		init => _lineGap = value;
	}
	readonly short _lineGap;

	/// <summary>
	/// <b>UINT16 capHeight</b>
	/// </summary>
	public readonly ushort CapHeight {
		get => _capHeight;
		init => _capHeight = value;
	}
	readonly ushort _capHeight;

	/// <summary>
	/// <b>UINT16 xHeight</b>
	/// </summary>
	public readonly ushort XHeight {
		get => _xHeight;
		init => _xHeight = value;
	}
	readonly ushort _xHeight;

	/// <summary>
	/// <b>INT16 underlinePosition</b>
	/// </summary>
	public readonly short UnderlinePosition {
		get => _underlinePosition;
		init => _underlinePosition = value;
	}
	readonly short _underlinePosition;

	/// <summary>
	/// <b>UINT16 underlineThickness</b>
	/// </summary>
	public readonly ushort UnderlineThickness {
		get => _underlineThickness;
		init => _underlineThickness = value;
	}
	readonly ushort _underlineThickness;

	/// <summary>
	/// <b>INT16 strikethroughPosition</b>
	/// </summary>
	public readonly short StrikethroughPosition {
		get => _strikethroughPosition;
		init => _strikethroughPosition = value;
	}
	readonly short _strikethroughPosition;

	/// <summary>
	/// <b>UINT16 strikethroughThickness</b>
	/// </summary>
	public readonly ushort StrikethroughThickness {
		get => _strikethroughThickness;
		init => _strikethroughThickness = value;
	}
	readonly ushort _strikethroughThickness;

}

/// <summary>
/// STRUCTURE <b>DWRITE_GLYPH_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GlyphMetrics {

	/// <summary>
	/// <b>INT32 leftSideBearing</b>
	/// </summary>
	public readonly int LeftSideBearing {
		get => _leftSideBearing;
		init => _leftSideBearing = value;
	}
	readonly int _leftSideBearing;

	/// <summary>
	/// <b>UINT32 advanceWidth</b>
	/// </summary>
	public readonly uint AdvanceWidth {
		get => _advanceWidth;
		init => _advanceWidth = value;
	}
	readonly uint _advanceWidth;

	/// <summary>
	/// <b>INT32 rightSideBearing</b>
	/// </summary>
	public readonly int RightSideBearing {
		get => _rightSideBearing;
		init => _rightSideBearing = value;
	}
	readonly int _rightSideBearing;

	/// <summary>
	/// <b>INT32 topSideBearing</b>
	/// </summary>
	public readonly int TopSideBearing {
		get => _topSideBearing;
		init => _topSideBearing = value;
	}
	readonly int _topSideBearing;

	/// <summary>
	/// <b>UINT32 advanceHeight</b>
	/// </summary>
	public readonly uint AdvanceHeight {
		get => _advanceHeight;
		init => _advanceHeight = value;
	}
	readonly uint _advanceHeight;

	/// <summary>
	/// <b>INT32 bottomSideBearing</b>
	/// </summary>
	public readonly int BottomSideBearing {
		get => _bottomSideBearing;
		init => _bottomSideBearing = value;
	}
	readonly int _bottomSideBearing;

	/// <summary>
	/// <b>INT32 verticalOriginY</b>
	/// </summary>
	public readonly int VerticalOriginY {
		get => _verticalOriginY;
		init => _verticalOriginY = value;
	}
	readonly int _verticalOriginY;

}

/// <summary>
/// STRUCTURE <b>DWRITE_GLYPH_OFFSET</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GlyphOffset {

	/// <summary>
	/// <b>FLOAT advanceOffset</b>
	/// </summary>
	public readonly float AdvanceOffset {
		get => _advanceOffset;
		init => _advanceOffset = value;
	}
	readonly float _advanceOffset;

	/// <summary>
	/// <b>FLOAT ascenderOffset</b>
	/// </summary>
	public readonly float AscenderOffset {
		get => _ascenderOffset;
		init => _ascenderOffset = value;
	}
	readonly float _ascenderOffset;

}

/*

/// <summary>
/// STRUCTURE <b>DWRITE_MATRIX</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Matrix {

	/// <summary>
	/// <b>FLOAT m11</b>
	/// </summary>
	public readonly float M11 {
		get => _m11;
		init => _m11 = value;
	}
	readonly float _m11;

	/// <summary>
	/// <b>FLOAT m12</b>
	/// </summary>
	public readonly float M12 {
		get => _m12;
		init => _m12 = value;
	}
	readonly float _m12;

	/// <summary>
	/// <b>FLOAT m21</b>
	/// </summary>
	public readonly float M21 {
		get => _m21;
		init => _m21 = value;
	}
	readonly float _m21;

	/// <summary>
	/// <b>FLOAT m22</b>
	/// </summary>
	public readonly float M22 {
		get => _m22;
		init => _m22 = value;
	}
	readonly float _m22;

	/// <summary>
	/// <b>FLOAT dx</b>
	/// </summary>
	public readonly float Dx {
		get => _dx;
		init => _dx = value;
	}
	readonly float _dx;

	/// <summary>
	/// <b>FLOAT dy</b>
	/// </summary>
	public readonly float Dy {
		get => _dy;
		init => _dy = value;
	}
	readonly float _dy;

}

*/

/// <summary>
/// STRUCTURE <b>DWRITE_TEXT_RANGE</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TextRange {

	/// <summary>
	/// <b>UINT32 startPosition</b>
	/// </summary>
	public readonly uint StartPosition {
		get => _startPosition;
		init => _startPosition = value;
	}
	readonly uint _startPosition;

	/// <summary>
	/// <b>UINT32 length</b>
	/// </summary>
	public readonly uint Length {
		get => _length;
		init => _length = value;
	}
	readonly uint _length;

}

/// <summary>
/// STRUCTURE <b>DWRITE_FONT_FEATURE</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FontFeature {

	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG nameTag</b>
	/// </summary>
	public readonly FontFeatureTag NameTag {
		get => _nameTag;
		init => _nameTag = value;
	}
	readonly FontFeatureTag _nameTag;

	/// <summary>
	/// <b>UINT32 parameter</b>
	/// </summary>
	public readonly uint Parameter {
		get => _parameter;
		init => _parameter = value;
	}
	readonly uint _parameter;

}

/// <summary>
/// STRUCTURE <b>DWRITE_TYPOGRAPHIC_FEATURES</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TypographicFeatures {

	/// <summary>
	/// <b>DWRITE_FONT_FEATURE* features</b>
	/// </summary>
	public readonly FontFeature* Features {
		get => _features;
		init => _features = value;
	}
	readonly FontFeature* _features;

	/// <summary>
	/// <b>UINT32 featureCount</b>
	/// </summary>
	public readonly uint FeatureCount {
		get => _featureCount;
		init => _featureCount = value;
	}
	readonly uint _featureCount;

}

/// <summary>
/// STRUCTURE <b>DWRITE_TRIMMING</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Trimming {

	/// <summary>
	/// <b>DWRITE_TRIMMING_GRANULARITY granularity</b>
	/// </summary>
	public readonly TrimmingGranularity Granularity {
		get => _granularity;
		init => _granularity = value;
	}
	readonly TrimmingGranularity _granularity;

	/// <summary>
	/// <b>UINT32 delimiter</b>
	/// </summary>
	public readonly uint Delimiter {
		get => _delimiter;
		init => _delimiter = value;
	}
	readonly uint _delimiter;

	/// <summary>
	/// <b>UINT32 delimiterCount</b>
	/// </summary>
	public readonly uint DelimiterCount {
		get => _delimiterCount;
		init => _delimiterCount = value;
	}
	readonly uint _delimiterCount;

}

/// <summary>
/// STRUCTURE <b>DWRITE_SCRIPT_ANALYSIS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ScriptAnalysis {

	/// <summary>
	/// <b>UINT16 script</b>
	/// </summary>
	public readonly ushort Script {
		get => _script;
		init => _script = value;
	}
	readonly ushort _script;

	/// <summary>
	/// <b>DWRITE_SCRIPT_SHAPES shapes</b>
	/// </summary>
	public readonly ScriptShapes Shapes {
		get => _shapes;
		init => _shapes = value;
	}
	readonly ScriptShapes _shapes;

}

/// <summary>
/// STRUCTURE <b>DWRITE_LINE_BREAKPOINT</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LineBreakpoint {

	/// <summary>
	/// <b>UINT8 breakConditionBefore : 2</b>
	/// </summary>
	public readonly byte BreakConditionBefore {
		get => (byte) ((_ASP_AUTO_GENERATED_FIELD_146 << 0) >>> 6);
		init => _ASP_AUTO_GENERATED_FIELD_146 = (byte) (((value & 0b11) << 6) + (_ASP_AUTO_GENERATED_FIELD_146 & 0b00111111));
	}

	/// <summary>
	/// <b>UINT8 breakConditionAfter : 2</b>
	/// </summary>
	public readonly byte BreakConditionAfter {
		get => (byte) ((_ASP_AUTO_GENERATED_FIELD_146 << 2) >>> 6);
		init => _ASP_AUTO_GENERATED_FIELD_146 = (byte) (((value & 0b11) << 4) + (_ASP_AUTO_GENERATED_FIELD_146 & 0b11001111));
	}

	/// <summary>
	/// <b>UINT8 isWhitespace : 1</b>
	/// </summary>
	public readonly byte IsWhitespace {
		get => (byte) ((_ASP_AUTO_GENERATED_FIELD_146 << 4) >>> 7);
		init => _ASP_AUTO_GENERATED_FIELD_146 = (byte) (((value & 0b1) << 3) + (_ASP_AUTO_GENERATED_FIELD_146 & 0b11110111));
	}

	/// <summary>
	/// <b>UINT8 isSoftHyphen : 1</b>
	/// </summary>
	public readonly byte IsSoftHyphen {
		get => (byte) ((_ASP_AUTO_GENERATED_FIELD_146 << 5) >>> 7);
		init => _ASP_AUTO_GENERATED_FIELD_146 = (byte) (((value & 0b1) << 2) + (_ASP_AUTO_GENERATED_FIELD_146 & 0b11111011));
	}

	/// <summary>
	/// <b>UINT8 padding : 2</b>
	/// </summary>
	public readonly byte Padding {
		get => (byte) ((_ASP_AUTO_GENERATED_FIELD_146 << 6) >>> 6);
		init => _ASP_AUTO_GENERATED_FIELD_146 = (byte) (((value & 0b11) << 0) + (_ASP_AUTO_GENERATED_FIELD_146 & 0b11111100));
	}

	readonly byte _ASP_AUTO_GENERATED_FIELD_146;
}

/// <summary>
/// STRUCTURE <b>DWRITE_SHAPING_TEXT_PROPERTIES</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShapingTextProperties {

	/// <summary>
	/// <b>UINT16 isShapedAlone : 1</b>
	/// </summary>
	public readonly ushort IsShapedAlone {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_147 << 0) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_147 = (ushort) (((value & 0b1) << 15) + (_ASP_AUTO_GENERATED_FIELD_147 & 0b0111111111111111));
	}

	/// <summary>
	/// <b>UINT16 reserved1 : 1</b>
	/// </summary>
	public readonly ushort Reserved1 {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_147 << 1) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_147 = (ushort) (((value & 0b1) << 14) + (_ASP_AUTO_GENERATED_FIELD_147 & 0b1011111111111111));
	}

	/// <summary>
	/// <b>UINT16 canBreakShapingAfter : 1</b>
	/// </summary>
	public readonly ushort CanBreakShapingAfter {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_147 << 2) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_147 = (ushort) (((value & 0b1) << 13) + (_ASP_AUTO_GENERATED_FIELD_147 & 0b1101111111111111));
	}

	/// <summary>
	/// <b>UINT16 reserved : 13</b>
	/// </summary>
	public readonly ushort Reserved {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_147 << 3) >>> 3);
		init => _ASP_AUTO_GENERATED_FIELD_147 = (ushort) (((value & 0b1111111111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_147 & 0b1110000000000000));
	}

	readonly ushort _ASP_AUTO_GENERATED_FIELD_147;
}

/// <summary>
/// STRUCTURE <b>DWRITE_SHAPING_GLYPH_PROPERTIES</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShapingGlyphProperties {

	/// <summary>
	/// <b>UINT16 justification : 4</b>
	/// </summary>
	public readonly ushort Justification {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_148 << 0) >>> 12);
		init => _ASP_AUTO_GENERATED_FIELD_148 = (ushort) (((value & 0b1111) << 12) + (_ASP_AUTO_GENERATED_FIELD_148 & 0b0000111111111111));
	}

	/// <summary>
	/// <b>UINT16 isClusterStart : 1</b>
	/// </summary>
	public readonly ushort IsClusterStart {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_148 << 4) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_148 = (ushort) (((value & 0b1) << 11) + (_ASP_AUTO_GENERATED_FIELD_148 & 0b1111011111111111));
	}

	/// <summary>
	/// <b>UINT16 isDiacritic : 1</b>
	/// </summary>
	public readonly ushort IsDiacritic {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_148 << 5) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_148 = (ushort) (((value & 0b1) << 10) + (_ASP_AUTO_GENERATED_FIELD_148 & 0b1111101111111111));
	}

	/// <summary>
	/// <b>UINT16 isZeroWidthSpace : 1</b>
	/// </summary>
	public readonly ushort IsZeroWidthSpace {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_148 << 6) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_148 = (ushort) (((value & 0b1) << 9) + (_ASP_AUTO_GENERATED_FIELD_148 & 0b1111110111111111));
	}

	/// <summary>
	/// <b>UINT16 reserved : 9</b>
	/// </summary>
	public readonly ushort Reserved {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_148 << 7) >>> 7);
		init => _ASP_AUTO_GENERATED_FIELD_148 = (ushort) (((value & 0b111111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_148 & 0b1111111000000000));
	}

	readonly ushort _ASP_AUTO_GENERATED_FIELD_148;
}

/// <summary>
/// STRUCTURE <b>DWRITE_GLYPH_RUN</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GlyphRun {

	/// <summary>
	/// <b>IDWriteFontFace* fontFace</b>
	/// </summary>
	public readonly T* FontFace<T> () where T : unmanaged, IFontFace => (T*) _fontFace;
	readonly void* _fontFace;

	/// <summary>
	/// <b>FLOAT fontEmSize</b>
	/// </summary>
	public readonly float FontEmSize {
		get => _fontEmSize;
		init => _fontEmSize = value;
	}
	readonly float _fontEmSize;

	/// <summary>
	/// <b>UINT32 glyphCount</b>
	/// </summary>
	public readonly uint GlyphCount {
		get => _glyphCount;
		init => _glyphCount = value;
	}
	readonly uint _glyphCount;

	/// <summary>
	/// <b>UINT16* glyphIndices</b>
	/// </summary>
	public readonly ushort* GlyphIndices {
		get => _glyphIndices;
		init => _glyphIndices = value;
	}
	readonly ushort* _glyphIndices;

	/// <summary>
	/// <b>FLOAT* glyphAdvances</b>
	/// </summary>
	public readonly float* GlyphAdvances {
		get => _glyphAdvances;
		init => _glyphAdvances = value;
	}
	readonly float* _glyphAdvances;

	/// <summary>
	/// <b>DWRITE_GLYPH_OFFSET* glyphOffsets</b>
	/// </summary>
	public readonly GlyphOffset* GlyphOffsets {
		get => _glyphOffsets;
		init => _glyphOffsets = value;
	}
	readonly GlyphOffset* _glyphOffsets;

	/// <summary>
	/// <b>BOOL isSideways</b>
	/// </summary>
	public readonly bool IsSideways {
		get => _isSideways != 0;
		init => _isSideways = value ? 1U : 0U;
	}
	readonly uint _isSideways;

	/// <summary>
	/// <b>UINT32 bidiLevel</b>
	/// </summary>
	public readonly uint BidiLevel {
		get => _bidiLevel;
		init => _bidiLevel = value;
	}
	readonly uint _bidiLevel;

}

/// <summary>
/// STRUCTURE <b>DWRITE_GLYPH_RUN_DESCRIPTION</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GlyphRunDescription {

	/// <summary>
	/// <b>WCHAR* localeName</b>
	/// </summary>
	public readonly char* LocaleName {
		get => _localeName;
		init => _localeName = value;
	}
	readonly char* _localeName;

	/// <summary>
	/// <b>WCHAR* string</b>
	/// </summary>
	public readonly char* String {
		get => _string;
		init => _string = value;
	}
	readonly char* _string;

	/// <summary>
	/// <b>UINT32 stringLength</b>
	/// </summary>
	public readonly uint StringLength {
		get => _stringLength;
		init => _stringLength = value;
	}
	readonly uint _stringLength;

	/// <summary>
	/// <b>UINT16* clusterMap</b>
	/// </summary>
	public readonly ushort* ClusterMap {
		get => _clusterMap;
		init => _clusterMap = value;
	}
	readonly ushort* _clusterMap;

	/// <summary>
	/// <b>UINT32 textPosition</b>
	/// </summary>
	public readonly uint TextPosition {
		get => _textPosition;
		init => _textPosition = value;
	}
	readonly uint _textPosition;

}

/// <summary>
/// STRUCTURE <b>DWRITE_UNDERLINE</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Underline {

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT thickness</b>
	/// </summary>
	public readonly float Thickness {
		get => _thickness;
		init => _thickness = value;
	}
	readonly float _thickness;

	/// <summary>
	/// <b>FLOAT offset</b>
	/// </summary>
	public readonly float Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly float _offset;

	/// <summary>
	/// <b>FLOAT runHeight</b>
	/// </summary>
	public readonly float RunHeight {
		get => _runHeight;
		init => _runHeight = value;
	}
	readonly float _runHeight;

	/// <summary>
	/// <b>DWRITE_READING_DIRECTION readingDirection</b>
	/// </summary>
	public readonly ReadingDirection ReadingDirection {
		get => _readingDirection;
		init => _readingDirection = value;
	}
	readonly ReadingDirection _readingDirection;

	/// <summary>
	/// <b>DWRITE_FLOW_DIRECTION flowDirection</b>
	/// </summary>
	public readonly FlowDirection FlowDirection {
		get => _flowDirection;
		init => _flowDirection = value;
	}
	readonly FlowDirection _flowDirection;

	/// <summary>
	/// <b>WCHAR* localeName</b>
	/// </summary>
	public readonly char* LocaleName {
		get => _localeName;
		init => _localeName = value;
	}
	readonly char* _localeName;

	/// <summary>
	/// <b>DWRITE_MEASURING_MODE measuringMode</b>
	/// </summary>
	public readonly MeasuringMode MeasuringMode {
		get => _measuringMode;
		init => _measuringMode = value;
	}
	readonly MeasuringMode _measuringMode;

}

/// <summary>
/// STRUCTURE <b>DWRITE_STRIKETHROUGH</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Strikethrough {

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT thickness</b>
	/// </summary>
	public readonly float Thickness {
		get => _thickness;
		init => _thickness = value;
	}
	readonly float _thickness;

	/// <summary>
	/// <b>FLOAT offset</b>
	/// </summary>
	public readonly float Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly float _offset;

	/// <summary>
	/// <b>DWRITE_READING_DIRECTION readingDirection</b>
	/// </summary>
	public readonly ReadingDirection ReadingDirection {
		get => _readingDirection;
		init => _readingDirection = value;
	}
	readonly ReadingDirection _readingDirection;

	/// <summary>
	/// <b>DWRITE_FLOW_DIRECTION flowDirection</b>
	/// </summary>
	public readonly FlowDirection FlowDirection {
		get => _flowDirection;
		init => _flowDirection = value;
	}
	readonly FlowDirection _flowDirection;

	/// <summary>
	/// <b>WCHAR* localeName</b>
	/// </summary>
	public readonly char* LocaleName {
		get => _localeName;
		init => _localeName = value;
	}
	readonly char* _localeName;

	/// <summary>
	/// <b>DWRITE_MEASURING_MODE measuringMode</b>
	/// </summary>
	public readonly MeasuringMode MeasuringMode {
		get => _measuringMode;
		init => _measuringMode = value;
	}
	readonly MeasuringMode _measuringMode;

}

/// <summary>
/// STRUCTURE <b>DWRITE_LINE_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LineMetrics {

	/// <summary>
	/// <b>UINT32 length</b>
	/// </summary>
	public readonly uint Length {
		get => _length;
		init => _length = value;
	}
	readonly uint _length;

	/// <summary>
	/// <b>UINT32 trailingWhitespaceLength</b>
	/// </summary>
	public readonly uint TrailingWhitespaceLength {
		get => _trailingWhitespaceLength;
		init => _trailingWhitespaceLength = value;
	}
	readonly uint _trailingWhitespaceLength;

	/// <summary>
	/// <b>UINT32 newlineLength</b>
	/// </summary>
	public readonly uint NewlineLength {
		get => _newlineLength;
		init => _newlineLength = value;
	}
	readonly uint _newlineLength;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>FLOAT baseline</b>
	/// </summary>
	public readonly float Baseline {
		get => _baseline;
		init => _baseline = value;
	}
	readonly float _baseline;

	/// <summary>
	/// <b>BOOL isTrimmed</b>
	/// </summary>
	public readonly bool IsTrimmed {
		get => _isTrimmed != 0;
		init => _isTrimmed = value ? 1U : 0U;
	}
	readonly uint _isTrimmed;

}

/// <summary>
/// STRUCTURE <b>DWRITE_CLUSTER_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ClusterMetrics {

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>UINT16 length</b>
	/// </summary>
	public readonly ushort Length {
		get => _length;
		init => _length = value;
	}
	readonly ushort _length;

	/// <summary>
	/// <b>UINT16 canWrapLineAfter : 1</b>
	/// </summary>
	public readonly ushort CanWrapLineAfter {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_149 << 0) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_149 = (ushort) (((value & 0b1) << 15) + (_ASP_AUTO_GENERATED_FIELD_149 & 0b0111111111111111));
	}

	/// <summary>
	/// <b>UINT16 isWhitespace : 1</b>
	/// </summary>
	public readonly ushort IsWhitespace {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_149 << 1) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_149 = (ushort) (((value & 0b1) << 14) + (_ASP_AUTO_GENERATED_FIELD_149 & 0b1011111111111111));
	}

	/// <summary>
	/// <b>UINT16 isNewline : 1</b>
	/// </summary>
	public readonly ushort IsNewline {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_149 << 2) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_149 = (ushort) (((value & 0b1) << 13) + (_ASP_AUTO_GENERATED_FIELD_149 & 0b1101111111111111));
	}

	/// <summary>
	/// <b>UINT16 isSoftHyphen : 1</b>
	/// </summary>
	public readonly ushort IsSoftHyphen {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_149 << 3) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_149 = (ushort) (((value & 0b1) << 12) + (_ASP_AUTO_GENERATED_FIELD_149 & 0b1110111111111111));
	}

	/// <summary>
	/// <b>UINT16 isRightToLeft : 1</b>
	/// </summary>
	public readonly ushort IsRightToLeft {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_149 << 4) >>> 15);
		init => _ASP_AUTO_GENERATED_FIELD_149 = (ushort) (((value & 0b1) << 11) + (_ASP_AUTO_GENERATED_FIELD_149 & 0b1111011111111111));
	}

	/// <summary>
	/// <b>UINT16 padding : 11</b>
	/// </summary>
	public readonly ushort Padding {
		get => (ushort) ((_ASP_AUTO_GENERATED_FIELD_149 << 5) >>> 5);
		init => _ASP_AUTO_GENERATED_FIELD_149 = (ushort) (((value & 0b11111111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_149 & 0b1111100000000000));
	}

	readonly ushort _ASP_AUTO_GENERATED_FIELD_149;
}

/// <summary>
/// STRUCTURE <b>DWRITE_TEXT_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TextMetrics {

	/// <summary>
	/// <b>FLOAT left</b>
	/// </summary>
	public readonly float Left {
		get => _left;
		init => _left = value;
	}
	readonly float _left;

	/// <summary>
	/// <b>FLOAT top</b>
	/// </summary>
	public readonly float Top {
		get => _top;
		init => _top = value;
	}
	readonly float _top;

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT widthIncludingTrailingWhitespace</b>
	/// </summary>
	public readonly float WidthIncludingTrailingWhitespace {
		get => _widthIncludingTrailingWhitespace;
		init => _widthIncludingTrailingWhitespace = value;
	}
	readonly float _widthIncludingTrailingWhitespace;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>FLOAT layoutWidth</b>
	/// </summary>
	public readonly float LayoutWidth {
		get => _layoutWidth;
		init => _layoutWidth = value;
	}
	readonly float _layoutWidth;

	/// <summary>
	/// <b>FLOAT layoutHeight</b>
	/// </summary>
	public readonly float LayoutHeight {
		get => _layoutHeight;
		init => _layoutHeight = value;
	}
	readonly float _layoutHeight;

	/// <summary>
	/// <b>UINT32 maxBidiReorderingDepth</b>
	/// </summary>
	public readonly uint MaxBidiReorderingDepth {
		get => _maxBidiReorderingDepth;
		init => _maxBidiReorderingDepth = value;
	}
	readonly uint _maxBidiReorderingDepth;

	/// <summary>
	/// <b>UINT32 lineCount</b>
	/// </summary>
	public readonly uint LineCount {
		get => _lineCount;
		init => _lineCount = value;
	}
	readonly uint _lineCount;

}

/// <summary>
/// STRUCTURE <b>DWRITE_INLINE_OBJECT_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InlineObjectMetrics {

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>FLOAT baseline</b>
	/// </summary>
	public readonly float Baseline {
		get => _baseline;
		init => _baseline = value;
	}
	readonly float _baseline;

	/// <summary>
	/// <b>BOOL supportsSideways</b>
	/// </summary>
	public readonly bool SupportsSideways {
		get => _supportsSideways != 0;
		init => _supportsSideways = value ? 1U : 0U;
	}
	readonly uint _supportsSideways;

}

/// <summary>
/// STRUCTURE <b>DWRITE_OVERHANG_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OverhangMetrics {

	/// <summary>
	/// <b>FLOAT left</b>
	/// </summary>
	public readonly float Left {
		get => _left;
		init => _left = value;
	}
	readonly float _left;

	/// <summary>
	/// <b>FLOAT top</b>
	/// </summary>
	public readonly float Top {
		get => _top;
		init => _top = value;
	}
	readonly float _top;

	/// <summary>
	/// <b>FLOAT right</b>
	/// </summary>
	public readonly float Right {
		get => _right;
		init => _right = value;
	}
	readonly float _right;

	/// <summary>
	/// <b>FLOAT bottom</b>
	/// </summary>
	public readonly float Bottom {
		get => _bottom;
		init => _bottom = value;
	}
	readonly float _bottom;

}

/// <summary>
/// STRUCTURE <b>DWRITE_HIT_TEST_METRICS</b><br/>
/// DWRITE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct HitTestMetrics {

	/// <summary>
	/// <b>UINT32 textPosition</b>
	/// </summary>
	public readonly uint TextPosition {
		get => _textPosition;
		init => _textPosition = value;
	}
	readonly uint _textPosition;

	/// <summary>
	/// <b>UINT32 length</b>
	/// </summary>
	public readonly uint Length {
		get => _length;
		init => _length = value;
	}
	readonly uint _length;

	/// <summary>
	/// <b>FLOAT left</b>
	/// </summary>
	public readonly float Left {
		get => _left;
		init => _left = value;
	}
	readonly float _left;

	/// <summary>
	/// <b>FLOAT top</b>
	/// </summary>
	public readonly float Top {
		get => _top;
		init => _top = value;
	}
	readonly float _top;

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>UINT32 bidiLevel</b>
	/// </summary>
	public readonly uint BidiLevel {
		get => _bidiLevel;
		init => _bidiLevel = value;
	}
	readonly uint _bidiLevel;

	/// <summary>
	/// <b>BOOL isText</b>
	/// </summary>
	public readonly bool IsText {
		get => _isText != 0;
		init => _isText = value ? 1U : 0U;
	}
	readonly uint _isText;

	/// <summary>
	/// <b>BOOL isTrimmed</b>
	/// </summary>
	public readonly bool IsTrimmed {
		get => _isTrimmed != 0;
		init => _isTrimmed = value ? 1U : 0U;
	}
	readonly uint _isTrimmed;

}

/// <summary>
/// STRUCTURE <b>DWRITE_FONT_METRICS1</b><br/>
/// DWRITE_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FontMetrics1 {

	/// <summary>
	/// <b>UINT16 designUnitsPerEm</b>
	/// </summary>
	public readonly ushort DesignUnitsPerEm {
		get => _designUnitsPerEm;
		init => _designUnitsPerEm = value;
	}
	readonly ushort _designUnitsPerEm;

	/// <summary>
	/// <b>UINT16 ascent</b>
	/// </summary>
	public readonly ushort Ascent {
		get => _ascent;
		init => _ascent = value;
	}
	readonly ushort _ascent;

	/// <summary>
	/// <b>UINT16 descent</b>
	/// </summary>
	public readonly ushort Descent {
		get => _descent;
		init => _descent = value;
	}
	readonly ushort _descent;

	/// <summary>
	/// <b>INT16 lineGap</b>
	/// </summary>
	public readonly short LineGap {
		get => _lineGap;
		init => _lineGap = value;
	}
	readonly short _lineGap;

	/// <summary>
	/// <b>UINT16 capHeight</b>
	/// </summary>
	public readonly ushort CapHeight {
		get => _capHeight;
		init => _capHeight = value;
	}
	readonly ushort _capHeight;

	/// <summary>
	/// <b>UINT16 xHeight</b>
	/// </summary>
	public readonly ushort XHeight {
		get => _xHeight;
		init => _xHeight = value;
	}
	readonly ushort _xHeight;

	/// <summary>
	/// <b>INT16 underlinePosition</b>
	/// </summary>
	public readonly short UnderlinePosition {
		get => _underlinePosition;
		init => _underlinePosition = value;
	}
	readonly short _underlinePosition;

	/// <summary>
	/// <b>UINT16 underlineThickness</b>
	/// </summary>
	public readonly ushort UnderlineThickness {
		get => _underlineThickness;
		init => _underlineThickness = value;
	}
	readonly ushort _underlineThickness;

	/// <summary>
	/// <b>INT16 strikethroughPosition</b>
	/// </summary>
	public readonly short StrikethroughPosition {
		get => _strikethroughPosition;
		init => _strikethroughPosition = value;
	}
	readonly short _strikethroughPosition;

	/// <summary>
	/// <b>UINT16 strikethroughThickness</b>
	/// </summary>
	public readonly ushort StrikethroughThickness {
		get => _strikethroughThickness;
		init => _strikethroughThickness = value;
	}
	readonly ushort _strikethroughThickness;

	/// <summary>
	/// <b>INT16 glyphBoxLeft</b>
	/// </summary>
	public readonly short GlyphBoxLeft {
		get => _glyphBoxLeft;
		init => _glyphBoxLeft = value;
	}
	readonly short _glyphBoxLeft;

	/// <summary>
	/// <b>INT16 glyphBoxTop</b>
	/// </summary>
	public readonly short GlyphBoxTop {
		get => _glyphBoxTop;
		init => _glyphBoxTop = value;
	}
	readonly short _glyphBoxTop;

	/// <summary>
	/// <b>INT16 glyphBoxRight</b>
	/// </summary>
	public readonly short GlyphBoxRight {
		get => _glyphBoxRight;
		init => _glyphBoxRight = value;
	}
	readonly short _glyphBoxRight;

	/// <summary>
	/// <b>INT16 glyphBoxBottom</b>
	/// </summary>
	public readonly short GlyphBoxBottom {
		get => _glyphBoxBottom;
		init => _glyphBoxBottom = value;
	}
	readonly short _glyphBoxBottom;

	/// <summary>
	/// <b>INT16 subscriptPositionX</b>
	/// </summary>
	public readonly short SubscriptPositionX {
		get => _subscriptPositionX;
		init => _subscriptPositionX = value;
	}
	readonly short _subscriptPositionX;

	/// <summary>
	/// <b>INT16 subscriptPositionY</b>
	/// </summary>
	public readonly short SubscriptPositionY {
		get => _subscriptPositionY;
		init => _subscriptPositionY = value;
	}
	readonly short _subscriptPositionY;

	/// <summary>
	/// <b>INT16 subscriptSizeX</b>
	/// </summary>
	public readonly short SubscriptSizeX {
		get => _subscriptSizeX;
		init => _subscriptSizeX = value;
	}
	readonly short _subscriptSizeX;

	/// <summary>
	/// <b>INT16 subscriptSizeY</b>
	/// </summary>
	public readonly short SubscriptSizeY {
		get => _subscriptSizeY;
		init => _subscriptSizeY = value;
	}
	readonly short _subscriptSizeY;

	/// <summary>
	/// <b>INT16 superscriptPositionX</b>
	/// </summary>
	public readonly short SuperscriptPositionX {
		get => _superscriptPositionX;
		init => _superscriptPositionX = value;
	}
	readonly short _superscriptPositionX;

	/// <summary>
	/// <b>INT16 superscriptPositionY</b>
	/// </summary>
	public readonly short SuperscriptPositionY {
		get => _superscriptPositionY;
		init => _superscriptPositionY = value;
	}
	readonly short _superscriptPositionY;

	/// <summary>
	/// <b>INT16 superscriptSizeX</b>
	/// </summary>
	public readonly short SuperscriptSizeX {
		get => _superscriptSizeX;
		init => _superscriptSizeX = value;
	}
	readonly short _superscriptSizeX;

	/// <summary>
	/// <b>INT16 superscriptSizeY</b>
	/// </summary>
	public readonly short SuperscriptSizeY {
		get => _superscriptSizeY;
		init => _superscriptSizeY = value;
	}
	readonly short _superscriptSizeY;

	/// <summary>
	/// <b>BOOL hasTypographicMetrics</b>
	/// </summary>
	public readonly bool HasTypographicMetrics {
		get => _hasTypographicMetrics != 0;
		init => _hasTypographicMetrics = value ? 1U : 0U;
	}
	readonly uint _hasTypographicMetrics;

}

/// <summary>
/// STRUCTURE <b>DWRITE_CARET_METRICS</b><br/>
/// DWRITE_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CaretMetrics {

	/// <summary>
	/// <b>INT16 slopeRise</b>
	/// </summary>
	public readonly short SlopeRise {
		get => _slopeRise;
		init => _slopeRise = value;
	}
	readonly short _slopeRise;

	/// <summary>
	/// <b>INT16 slopeRun</b>
	/// </summary>
	public readonly short SlopeRun {
		get => _slopeRun;
		init => _slopeRun = value;
	}
	readonly short _slopeRun;

	/// <summary>
	/// <b>INT16 offset</b>
	/// </summary>
	public readonly short Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly short _offset;

}

/// <summary>
/// UNION <b>DWRITE_PANOSE</b><br/>
/// DWRITE_1.h
/// </summary>
[StructLayout (LayoutKind.Explicit)]
unsafe public readonly struct Panose {

	[StructLayout (LayoutKind.Sequential)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_98 {

		public byte familyKind;
		public byte serifStyle;
		public byte weight;
		public byte proportion;
		public byte contrast;
		public byte strokeVariation;
		public byte armStyle;
		public byte letterform;
		public byte midline;
		public byte xHeight;
	}

	[StructLayout (LayoutKind.Sequential)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_99 {

		public byte familyKind;
		public byte toolKind;
		public byte weight;
		public byte spacing;
		public byte aspectRatio;
		public byte contrast;
		public byte scriptTopology;
		public byte scriptForm;
		public byte finials;
		public byte xAscent;
	}

	[StructLayout (LayoutKind.Sequential)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_100 {

		public byte familyKind;
		public byte decorativeClass;
		public byte weight;
		public byte aspect;
		public byte contrast;
		public byte serifVariant;
		public byte fill;
		public byte lining;
		public byte decorativeTopology;
		public byte characterRange;
	}

	[StructLayout (LayoutKind.Sequential)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_101 {

		public byte familyKind;
		public byte symbolKind;
		public byte weight;
		public byte spacing;
		public byte aspectRatioAndContrast;
		public byte aspectRatio94;
		public byte aspectRatio119;
		public byte aspectRatio157;
		public byte aspectRatio163;
		public byte aspectRatio211;
	}

	/// <summary>
	/// <b>UINT8 values [10]</b>
	/// </summary>
	public readonly Span<byte> Values {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _values)), 10);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_150 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [10];
	}

	[FieldOffset (0)] readonly _ASP_AUTO_GENERATED_STRUCTURE_150 _values;

	/// <summary>
	/// <b>UINT8 familyKind</b>
	/// </summary>
	public readonly byte FamilyKind {
		get => _familyKind;
		init => _familyKind = value;
	}
	[FieldOffset (0)] readonly byte _familyKind;

	/// <summary>
	/// <b>UINT8 familyKind</b>
	/// </summary>
	public readonly byte TextFamilyKind {
		get => _text.familyKind;
		init => _text.familyKind = value;
	}

	/// <summary>
	/// <b>UINT8 serifStyle</b>
	/// </summary>
	public readonly byte TextSerifStyle {
		get => _text.serifStyle;
		init => _text.serifStyle = value;
	}

	/// <summary>
	/// <b>UINT8 weight</b>
	/// </summary>
	public readonly byte TextWeight {
		get => _text.weight;
		init => _text.weight = value;
	}

	/// <summary>
	/// <b>UINT8 proportion</b>
	/// </summary>
	public readonly byte TextProportion {
		get => _text.proportion;
		init => _text.proportion = value;
	}

	/// <summary>
	/// <b>UINT8 contrast</b>
	/// </summary>
	public readonly byte TextContrast {
		get => _text.contrast;
		init => _text.contrast = value;
	}

	/// <summary>
	/// <b>UINT8 strokeVariation</b>
	/// </summary>
	public readonly byte TextStrokeVariation {
		get => _text.strokeVariation;
		init => _text.strokeVariation = value;
	}

	/// <summary>
	/// <b>UINT8 armStyle</b>
	/// </summary>
	public readonly byte TextArmStyle {
		get => _text.armStyle;
		init => _text.armStyle = value;
	}

	/// <summary>
	/// <b>UINT8 letterform</b>
	/// </summary>
	public readonly byte TextLetterform {
		get => _text.letterform;
		init => _text.letterform = value;
	}

	/// <summary>
	/// <b>UINT8 midline</b>
	/// </summary>
	public readonly byte TextMidline {
		get => _text.midline;
		init => _text.midline = value;
	}

	/// <summary>
	/// <b>UINT8 xHeight</b>
	/// </summary>
	public readonly byte TextXHeight {
		get => _text.xHeight;
		init => _text.xHeight = value;
	}

	[FieldOffset (0)] readonly _ASP_AUTO_GENERATED_STRUCTURE_98 _text;

	/// <summary>
	/// <b>UINT8 familyKind</b>
	/// </summary>
	public readonly byte ScriptFamilyKind {
		get => _script.familyKind;
		init => _script.familyKind = value;
	}

	/// <summary>
	/// <b>UINT8 toolKind</b>
	/// </summary>
	public readonly byte ScriptToolKind {
		get => _script.toolKind;
		init => _script.toolKind = value;
	}

	/// <summary>
	/// <b>UINT8 weight</b>
	/// </summary>
	public readonly byte ScriptWeight {
		get => _script.weight;
		init => _script.weight = value;
	}

	/// <summary>
	/// <b>UINT8 spacing</b>
	/// </summary>
	public readonly byte ScriptSpacing {
		get => _script.spacing;
		init => _script.spacing = value;
	}

	/// <summary>
	/// <b>UINT8 aspectRatio</b>
	/// </summary>
	public readonly byte ScriptAspectRatio {
		get => _script.aspectRatio;
		init => _script.aspectRatio = value;
	}

	/// <summary>
	/// <b>UINT8 contrast</b>
	/// </summary>
	public readonly byte ScriptContrast {
		get => _script.contrast;
		init => _script.contrast = value;
	}

	/// <summary>
	/// <b>UINT8 scriptTopology</b>
	/// </summary>
	public readonly byte ScriptScriptTopology {
		get => _script.scriptTopology;
		init => _script.scriptTopology = value;
	}

	/// <summary>
	/// <b>UINT8 scriptForm</b>
	/// </summary>
	public readonly byte ScriptScriptForm {
		get => _script.scriptForm;
		init => _script.scriptForm = value;
	}

	/// <summary>
	/// <b>UINT8 finials</b>
	/// </summary>
	public readonly byte ScriptFinials {
		get => _script.finials;
		init => _script.finials = value;
	}

	/// <summary>
	/// <b>UINT8 xAscent</b>
	/// </summary>
	public readonly byte ScriptXAscent {
		get => _script.xAscent;
		init => _script.xAscent = value;
	}

	[FieldOffset (0)] readonly _ASP_AUTO_GENERATED_STRUCTURE_99 _script;

	/// <summary>
	/// <b>UINT8 familyKind</b>
	/// </summary>
	public readonly byte DecorativeFamilyKind {
		get => _decorative.familyKind;
		init => _decorative.familyKind = value;
	}

	/// <summary>
	/// <b>UINT8 decorativeClass</b>
	/// </summary>
	public readonly byte DecorativeDecorativeClass {
		get => _decorative.decorativeClass;
		init => _decorative.decorativeClass = value;
	}

	/// <summary>
	/// <b>UINT8 weight</b>
	/// </summary>
	public readonly byte DecorativeWeight {
		get => _decorative.weight;
		init => _decorative.weight = value;
	}

	/// <summary>
	/// <b>UINT8 aspect</b>
	/// </summary>
	public readonly byte DecorativeAspect {
		get => _decorative.aspect;
		init => _decorative.aspect = value;
	}

	/// <summary>
	/// <b>UINT8 contrast</b>
	/// </summary>
	public readonly byte DecorativeContrast {
		get => _decorative.contrast;
		init => _decorative.contrast = value;
	}

	/// <summary>
	/// <b>UINT8 serifVariant</b>
	/// </summary>
	public readonly byte DecorativeSerifVariant {
		get => _decorative.serifVariant;
		init => _decorative.serifVariant = value;
	}

	/// <summary>
	/// <b>UINT8 fill</b>
	/// </summary>
	public readonly byte DecorativeFill {
		get => _decorative.fill;
		init => _decorative.fill = value;
	}

	/// <summary>
	/// <b>UINT8 lining</b>
	/// </summary>
	public readonly byte DecorativeLining {
		get => _decorative.lining;
		init => _decorative.lining = value;
	}

	/// <summary>
	/// <b>UINT8 decorativeTopology</b>
	/// </summary>
	public readonly byte DecorativeDecorativeTopology {
		get => _decorative.decorativeTopology;
		init => _decorative.decorativeTopology = value;
	}

	/// <summary>
	/// <b>UINT8 characterRange</b>
	/// </summary>
	public readonly byte DecorativeCharacterRange {
		get => _decorative.characterRange;
		init => _decorative.characterRange = value;
	}

	[FieldOffset (0)] readonly _ASP_AUTO_GENERATED_STRUCTURE_100 _decorative;

	/// <summary>
	/// <b>UINT8 familyKind</b>
	/// </summary>
	public readonly byte SymbolFamilyKind {
		get => _symbol.familyKind;
		init => _symbol.familyKind = value;
	}

	/// <summary>
	/// <b>UINT8 symbolKind</b>
	/// </summary>
	public readonly byte SymbolSymbolKind {
		get => _symbol.symbolKind;
		init => _symbol.symbolKind = value;
	}

	/// <summary>
	/// <b>UINT8 weight</b>
	/// </summary>
	public readonly byte SymbolWeight {
		get => _symbol.weight;
		init => _symbol.weight = value;
	}

	/// <summary>
	/// <b>UINT8 spacing</b>
	/// </summary>
	public readonly byte SymbolSpacing {
		get => _symbol.spacing;
		init => _symbol.spacing = value;
	}

	/// <summary>
	/// <b>UINT8 aspectRatioAndContrast</b>
	/// </summary>
	public readonly byte SymbolAspectRatioAndContrast {
		get => _symbol.aspectRatioAndContrast;
		init => _symbol.aspectRatioAndContrast = value;
	}

	/// <summary>
	/// <b>UINT8 aspectRatio94</b>
	/// </summary>
	public readonly byte SymbolAspectRatio94 {
		get => _symbol.aspectRatio94;
		init => _symbol.aspectRatio94 = value;
	}

	/// <summary>
	/// <b>UINT8 aspectRatio119</b>
	/// </summary>
	public readonly byte SymbolAspectRatio119 {
		get => _symbol.aspectRatio119;
		init => _symbol.aspectRatio119 = value;
	}

	/// <summary>
	/// <b>UINT8 aspectRatio157</b>
	/// </summary>
	public readonly byte SymbolAspectRatio157 {
		get => _symbol.aspectRatio157;
		init => _symbol.aspectRatio157 = value;
	}

	/// <summary>
	/// <b>UINT8 aspectRatio163</b>
	/// </summary>
	public readonly byte SymbolAspectRatio163 {
		get => _symbol.aspectRatio163;
		init => _symbol.aspectRatio163 = value;
	}

	/// <summary>
	/// <b>UINT8 aspectRatio211</b>
	/// </summary>
	public readonly byte SymbolAspectRatio211 {
		get => _symbol.aspectRatio211;
		init => _symbol.aspectRatio211 = value;
	}

	[FieldOffset (0)] readonly _ASP_AUTO_GENERATED_STRUCTURE_101 _symbol;

}

/// <summary>
/// STRUCTURE <b>DWRITE_UNICODE_RANGE</b><br/>
/// DWRITE_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct UnicodeRange {

	/// <summary>
	/// <b>UINT32 first</b>
	/// </summary>
	public readonly uint First {
		get => _first;
		init => _first = value;
	}
	readonly uint _first;

	/// <summary>
	/// <b>UINT32 last</b>
	/// </summary>
	public readonly uint Last {
		get => _last;
		init => _last = value;
	}
	readonly uint _last;

}

/// <summary>
/// STRUCTURE <b>DWRITE_SCRIPT_PROPERTIES</b><br/>
/// DWRITE_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ScriptProperties {

	/// <summary>
	/// <b>UINT32 isoScriptCode</b>
	/// </summary>
	public readonly uint IsoScriptCode {
		get => _isoScriptCode;
		init => _isoScriptCode = value;
	}
	readonly uint _isoScriptCode;

	/// <summary>
	/// <b>UINT32 isoScriptNumber</b>
	/// </summary>
	public readonly uint IsoScriptNumber {
		get => _isoScriptNumber;
		init => _isoScriptNumber = value;
	}
	readonly uint _isoScriptNumber;

	/// <summary>
	/// <b>UINT32 clusterLookahead</b>
	/// </summary>
	public readonly uint ClusterLookahead {
		get => _clusterLookahead;
		init => _clusterLookahead = value;
	}
	readonly uint _clusterLookahead;

	/// <summary>
	/// <b>UINT32 justificationCharacter</b>
	/// </summary>
	public readonly uint JustificationCharacter {
		get => _justificationCharacter;
		init => _justificationCharacter = value;
	}
	readonly uint _justificationCharacter;

	/// <summary>
	/// <b>UINT32 restrictCaretToClusters : 1</b>
	/// </summary>
	public readonly uint RestrictCaretToClusters {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 0) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1) << 31) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b01111111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 usesWordDividers : 1</b>
	/// </summary>
	public readonly uint UsesWordDividers {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 1) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1) << 30) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b10111111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 isDiscreteWriting : 1</b>
	/// </summary>
	public readonly uint IsDiscreteWriting {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 2) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1) << 29) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b11011111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 isBlockWriting : 1</b>
	/// </summary>
	public readonly uint IsBlockWriting {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 3) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1) << 28) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b11101111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 isDistributedWithinCluster : 1</b>
	/// </summary>
	public readonly uint IsDistributedWithinCluster {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 4) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1) << 27) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b11110111111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 isConnectedWriting : 1</b>
	/// </summary>
	public readonly uint IsConnectedWriting {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 5) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1) << 26) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b11111011111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 isCursiveWriting : 1</b>
	/// </summary>
	public readonly uint IsCursiveWriting {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 6) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1) << 25) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b11111101111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 reserved : 25</b>
	/// </summary>
	public readonly uint Reserved {
		get => (_ASP_AUTO_GENERATED_FIELD_151 << 7) >>> 7;
		init => _ASP_AUTO_GENERATED_FIELD_151 = ((value & 0b1111111111111111111111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_151 & 0b11111110000000000000000000000000);
	}

	readonly uint _ASP_AUTO_GENERATED_FIELD_151;
}

/// <summary>
/// STRUCTURE <b>DWRITE_JUSTIFICATION_OPPORTUNITY</b><br/>
/// DWRITE_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct JustificationOpportunity {

	/// <summary>
	/// <b>FLOAT expansionMinimum</b>
	/// </summary>
	public readonly float ExpansionMinimum {
		get => _expansionMinimum;
		init => _expansionMinimum = value;
	}
	readonly float _expansionMinimum;

	/// <summary>
	/// <b>FLOAT expansionMaximum</b>
	/// </summary>
	public readonly float ExpansionMaximum {
		get => _expansionMaximum;
		init => _expansionMaximum = value;
	}
	readonly float _expansionMaximum;

	/// <summary>
	/// <b>FLOAT compressionMaximum</b>
	/// </summary>
	public readonly float CompressionMaximum {
		get => _compressionMaximum;
		init => _compressionMaximum = value;
	}
	readonly float _compressionMaximum;

	/// <summary>
	/// <b>UINT32 expansionPriority : 8</b>
	/// </summary>
	public readonly uint ExpansionPriority {
		get => (_ASP_AUTO_GENERATED_FIELD_152 << 0) >>> 24;
		init => _ASP_AUTO_GENERATED_FIELD_152 = ((value & 0b11111111) << 24) + (_ASP_AUTO_GENERATED_FIELD_152 & 0b00000000111111111111111111111111);
	}

	/// <summary>
	/// <b>UINT32 compressionPriority : 8</b>
	/// </summary>
	public readonly uint CompressionPriority {
		get => (_ASP_AUTO_GENERATED_FIELD_152 << 8) >>> 24;
		init => _ASP_AUTO_GENERATED_FIELD_152 = ((value & 0b11111111) << 16) + (_ASP_AUTO_GENERATED_FIELD_152 & 0b11111111000000001111111111111111);
	}

	/// <summary>
	/// <b>UINT32 allowResidualExpansion : 1</b>
	/// </summary>
	public readonly uint AllowResidualExpansion {
		get => (_ASP_AUTO_GENERATED_FIELD_152 << 16) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_152 = ((value & 0b1) << 15) + (_ASP_AUTO_GENERATED_FIELD_152 & 0b11111111111111110111111111111111);
	}

	/// <summary>
	/// <b>UINT32 allowResidualCompression : 1</b>
	/// </summary>
	public readonly uint AllowResidualCompression {
		get => (_ASP_AUTO_GENERATED_FIELD_152 << 17) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_152 = ((value & 0b1) << 14) + (_ASP_AUTO_GENERATED_FIELD_152 & 0b11111111111111111011111111111111);
	}

	/// <summary>
	/// <b>UINT32 applyToLeadingEdge : 1</b>
	/// </summary>
	public readonly uint ApplyToLeadingEdge {
		get => (_ASP_AUTO_GENERATED_FIELD_152 << 18) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_152 = ((value & 0b1) << 13) + (_ASP_AUTO_GENERATED_FIELD_152 & 0b11111111111111111101111111111111);
	}

	/// <summary>
	/// <b>UINT32 applyToTrailingEdge : 1</b>
	/// </summary>
	public readonly uint ApplyToTrailingEdge {
		get => (_ASP_AUTO_GENERATED_FIELD_152 << 19) >>> 31;
		init => _ASP_AUTO_GENERATED_FIELD_152 = ((value & 0b1) << 12) + (_ASP_AUTO_GENERATED_FIELD_152 & 0b11111111111111111110111111111111);
	}

	/// <summary>
	/// <b>UINT32 reserved : 12</b>
	/// </summary>
	public readonly uint Reserved {
		get => (_ASP_AUTO_GENERATED_FIELD_152 << 20) >>> 20;
		init => _ASP_AUTO_GENERATED_FIELD_152 = ((value & 0b111111111111) << 0) + (_ASP_AUTO_GENERATED_FIELD_152 & 0b11111111111111111111000000000000);
	}

	readonly uint _ASP_AUTO_GENERATED_FIELD_152;
}

/// <summary>
/// STRUCTURE <b>DWRITE_TEXT_METRICS1</b><br/>
/// DWRITE_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TextMetrics1 {

	/// <summary>
	/// <b>FLOAT left</b>
	/// </summary>
	public readonly float Left {
		get => _left;
		init => _left = value;
	}
	readonly float _left;

	/// <summary>
	/// <b>FLOAT top</b>
	/// </summary>
	public readonly float Top {
		get => _top;
		init => _top = value;
	}
	readonly float _top;

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT widthIncludingTrailingWhitespace</b>
	/// </summary>
	public readonly float WidthIncludingTrailingWhitespace {
		get => _widthIncludingTrailingWhitespace;
		init => _widthIncludingTrailingWhitespace = value;
	}
	readonly float _widthIncludingTrailingWhitespace;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>FLOAT layoutWidth</b>
	/// </summary>
	public readonly float LayoutWidth {
		get => _layoutWidth;
		init => _layoutWidth = value;
	}
	readonly float _layoutWidth;

	/// <summary>
	/// <b>FLOAT layoutHeight</b>
	/// </summary>
	public readonly float LayoutHeight {
		get => _layoutHeight;
		init => _layoutHeight = value;
	}
	readonly float _layoutHeight;

	/// <summary>
	/// <b>UINT32 maxBidiReorderingDepth</b>
	/// </summary>
	public readonly uint MaxBidiReorderingDepth {
		get => _maxBidiReorderingDepth;
		init => _maxBidiReorderingDepth = value;
	}
	readonly uint _maxBidiReorderingDepth;

	/// <summary>
	/// <b>UINT32 lineCount</b>
	/// </summary>
	public readonly uint LineCount {
		get => _lineCount;
		init => _lineCount = value;
	}
	readonly uint _lineCount;

	/// <summary>
	/// <b>FLOAT heightIncludingTrailingWhitespace</b>
	/// </summary>
	public readonly float HeightIncludingTrailingWhitespace {
		get => _heightIncludingTrailingWhitespace;
		init => _heightIncludingTrailingWhitespace = value;
	}
	readonly float _heightIncludingTrailingWhitespace;

}

/// <summary>
/// STRUCTURE <b>DWRITE_COLOR_GLYPH_RUN</b><br/>
/// DWRITE_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ColorGlyphRun {

	/// <summary>
	/// <b>DWRITE_GLYPH_RUN glyphRun</b>
	/// </summary>
	public readonly GlyphRun GlyphRun {
		get => _glyphRun;
		init => _glyphRun = value;
	}
	readonly GlyphRun _glyphRun;

	/// <summary>
	/// <b>DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription</b>
	/// </summary>
	public readonly GlyphRunDescription* GlyphRunDescription {
		get => _glyphRunDescription;
		init => _glyphRunDescription = value;
	}
	readonly GlyphRunDescription* _glyphRunDescription;

	/// <summary>
	/// <b>FLOAT baselineOriginX</b>
	/// </summary>
	public readonly float BaselineOriginX {
		get => _baselineOriginX;
		init => _baselineOriginX = value;
	}
	readonly float _baselineOriginX;

	/// <summary>
	/// <b>FLOAT baselineOriginY</b>
	/// </summary>
	public readonly float BaselineOriginY {
		get => _baselineOriginY;
		init => _baselineOriginY = value;
	}
	readonly float _baselineOriginY;

	/// <summary>
	/// <b>DWRITE_COLOR_F runColor</b>
	/// </summary>
	public readonly Vector4F RunColor {
		get => _runColor;
		init => _runColor = value;
	}
	readonly Vector4F _runColor;

	/// <summary>
	/// <b>UINT16 paletteIndex</b>
	/// </summary>
	public readonly ushort PaletteIndex {
		get => _paletteIndex;
		init => _paletteIndex = value;
	}
	readonly ushort _paletteIndex;

}

/// <summary>
/// STRUCTURE <b>DWRITE_FONT_PROPERTY</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FontProperty {

	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID propertyId</b>
	/// </summary>
	public readonly FontPropertyId PropertyId {
		get => _propertyId;
		init => _propertyId = value;
	}
	readonly FontPropertyId _propertyId;

	/// <summary>
	/// <b>WCHAR* propertyValue</b>
	/// </summary>
	public readonly char* PropertyValue {
		get => _propertyValue;
		init => _propertyValue = value;
	}
	readonly char* _propertyValue;

	/// <summary>
	/// <b>WCHAR* localeName</b>
	/// </summary>
	public readonly char* LocaleName {
		get => _localeName;
		init => _localeName = value;
	}
	readonly char* _localeName;

}

/// <summary>
/// STRUCTURE <b>DWRITE_LINE_METRICS1</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LineMetrics1 {

	/// <summary>
	/// <b>UINT32 length</b>
	/// </summary>
	public readonly uint Length {
		get => _length;
		init => _length = value;
	}
	readonly uint _length;

	/// <summary>
	/// <b>UINT32 trailingWhitespaceLength</b>
	/// </summary>
	public readonly uint TrailingWhitespaceLength {
		get => _trailingWhitespaceLength;
		init => _trailingWhitespaceLength = value;
	}
	readonly uint _trailingWhitespaceLength;

	/// <summary>
	/// <b>UINT32 newlineLength</b>
	/// </summary>
	public readonly uint NewlineLength {
		get => _newlineLength;
		init => _newlineLength = value;
	}
	readonly uint _newlineLength;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>FLOAT baseline</b>
	/// </summary>
	public readonly float Baseline {
		get => _baseline;
		init => _baseline = value;
	}
	readonly float _baseline;

	/// <summary>
	/// <b>BOOL isTrimmed</b>
	/// </summary>
	public readonly bool IsTrimmed {
		get => _isTrimmed != 0;
		init => _isTrimmed = value ? 1U : 0U;
	}
	readonly uint _isTrimmed;

	/// <summary>
	/// <b>FLOAT leadingBefore</b>
	/// </summary>
	public readonly float LeadingBefore {
		get => _leadingBefore;
		init => _leadingBefore = value;
	}
	readonly float _leadingBefore;

	/// <summary>
	/// <b>FLOAT leadingAfter</b>
	/// </summary>
	public readonly float LeadingAfter {
		get => _leadingAfter;
		init => _leadingAfter = value;
	}
	readonly float _leadingAfter;

}

/// <summary>
/// STRUCTURE <b>DWRITE_LINE_SPACING</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LineSpacing {

	/// <summary>
	/// <b>DWRITE_LINE_SPACING_METHOD method</b>
	/// </summary>
	public readonly LineSpacingMethod Method {
		get => _method;
		init => _method = value;
	}
	readonly LineSpacingMethod _method;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

	/// <summary>
	/// <b>FLOAT baseline</b>
	/// </summary>
	public readonly float Baseline {
		get => _baseline;
		init => _baseline = value;
	}
	readonly float _baseline;

	/// <summary>
	/// <b>FLOAT leadingBefore</b>
	/// </summary>
	public readonly float LeadingBefore {
		get => _leadingBefore;
		init => _leadingBefore = value;
	}
	readonly float _leadingBefore;

	/// <summary>
	/// <b>DWRITE_FONT_LINE_GAP_USAGE fontLineGapUsage</b>
	/// </summary>
	public readonly FontLineGapUsage FontLineGapUsage {
		get => _fontLineGapUsage;
		init => _fontLineGapUsage = value;
	}
	readonly FontLineGapUsage _fontLineGapUsage;

}

/// <summary>
/// STRUCTURE <b>DWRITE_COLOR_GLYPH_RUN1</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ColorGlyphRun1 {

	/// <summary>
	/// <b>DWRITE_GLYPH_RUN glyphRun</b>
	/// </summary>
	public readonly GlyphRun GlyphRun {
		get => _glyphRun;
		init => _glyphRun = value;
	}
	readonly GlyphRun _glyphRun;

	/// <summary>
	/// <b>DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription</b>
	/// </summary>
	public readonly GlyphRunDescription* GlyphRunDescription {
		get => _glyphRunDescription;
		init => _glyphRunDescription = value;
	}
	readonly GlyphRunDescription* _glyphRunDescription;

	/// <summary>
	/// <b>FLOAT baselineOriginX</b>
	/// </summary>
	public readonly float BaselineOriginX {
		get => _baselineOriginX;
		init => _baselineOriginX = value;
	}
	readonly float _baselineOriginX;

	/// <summary>
	/// <b>FLOAT baselineOriginY</b>
	/// </summary>
	public readonly float BaselineOriginY {
		get => _baselineOriginY;
		init => _baselineOriginY = value;
	}
	readonly float _baselineOriginY;

	/// <summary>
	/// <b>DWRITE_COLOR_F runColor</b>
	/// </summary>
	public readonly Vector4F RunColor {
		get => _runColor;
		init => _runColor = value;
	}
	readonly Vector4F _runColor;

	/// <summary>
	/// <b>UINT16 paletteIndex</b>
	/// </summary>
	public readonly ushort PaletteIndex {
		get => _paletteIndex;
		init => _paletteIndex = value;
	}
	readonly ushort _paletteIndex;

	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat</b>
	/// </summary>
	public readonly GlyphImageFormats GlyphImageFormat {
		get => _glyphImageFormat;
		init => _glyphImageFormat = value;
	}
	readonly GlyphImageFormats _glyphImageFormat;

	/// <summary>
	/// <b>DWRITE_MEASURING_MODE measuringMode</b>
	/// </summary>
	public readonly MeasuringMode MeasuringMode {
		get => _measuringMode;
		init => _measuringMode = value;
	}
	readonly MeasuringMode _measuringMode;

}

/// <summary>
/// STRUCTURE <b>DWRITE_GLYPH_IMAGE_DATA</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GlyphImageData {

	/// <summary>
	/// <b>void* imageData</b>
	/// </summary>
	public readonly void* ImageData {
		get => _imageData;
		init => _imageData = value;
	}
	readonly void* _imageData;

	/// <summary>
	/// <b>UINT32 imageDataSize</b>
	/// </summary>
	public readonly uint ImageDataSize {
		get => _imageDataSize;
		init => _imageDataSize = value;
	}
	readonly uint _imageDataSize;

	/// <summary>
	/// <b>UINT32 uniqueDataId</b>
	/// </summary>
	public readonly uint UniqueDataId {
		get => _uniqueDataId;
		init => _uniqueDataId = value;
	}
	readonly uint _uniqueDataId;

	/// <summary>
	/// <b>UINT32 pixelsPerEm</b>
	/// </summary>
	public readonly uint PixelsPerEm {
		get => _pixelsPerEm;
		init => _pixelsPerEm = value;
	}
	readonly uint _pixelsPerEm;

	/// <summary>
	/// <b>D2D1_SIZE_U pixelSize</b>
	/// </summary>
	public readonly Vector2U PixelSize {
		get => _pixelSize;
		init => _pixelSize = value;
	}
	readonly Vector2U _pixelSize;

	/// <summary>
	/// <b>D2D1_POINT_2L horizontalLeftOrigin</b>
	/// </summary>
	public readonly Vector2I HorizontalLeftOrigin {
		get => _horizontalLeftOrigin;
		init => _horizontalLeftOrigin = value;
	}
	readonly Vector2I _horizontalLeftOrigin;

	/// <summary>
	/// <b>D2D1_POINT_2L horizontalRightOrigin</b>
	/// </summary>
	public readonly Vector2I HorizontalRightOrigin {
		get => _horizontalRightOrigin;
		init => _horizontalRightOrigin = value;
	}
	readonly Vector2I _horizontalRightOrigin;

	/// <summary>
	/// <b>D2D1_POINT_2L verticalTopOrigin</b>
	/// </summary>
	public readonly Vector2I VerticalTopOrigin {
		get => _verticalTopOrigin;
		init => _verticalTopOrigin = value;
	}
	readonly Vector2I _verticalTopOrigin;

	/// <summary>
	/// <b>D2D1_POINT_2L verticalBottomOrigin</b>
	/// </summary>
	public readonly Vector2I VerticalBottomOrigin {
		get => _verticalBottomOrigin;
		init => _verticalBottomOrigin = value;
	}
	readonly Vector2I _verticalBottomOrigin;

}

/// <summary>
/// STRUCTURE <b>DWRITE_FILE_FRAGMENT</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FileFragment {

	/// <summary>
	/// <b>UINT64 fileOffset</b>
	/// </summary>
	public readonly ulong FileOffset {
		get => _fileOffset;
		init => _fileOffset = value;
	}
	readonly ulong _fileOffset;

	/// <summary>
	/// <b>UINT64 fragmentSize</b>
	/// </summary>
	public readonly ulong FragmentSize {
		get => _fragmentSize;
		init => _fragmentSize = value;
	}
	readonly ulong _fragmentSize;

}

/// <summary>
/// STRUCTURE <b>DWRITE_FONT_AXIS_VALUE</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FontAxisValue {

	/// <summary>
	/// <b>DWRITE_FONT_AXIS_TAG axisTag</b>
	/// </summary>
	public readonly FontAxisTag AxisTag {
		get => _axisTag;
		init => _axisTag = value;
	}
	readonly FontAxisTag _axisTag;

	/// <summary>
	/// <b>FLOAT value</b>
	/// </summary>
	public readonly float Value {
		get => _value;
		init => _value = value;
	}
	readonly float _value;

}

/// <summary>
/// STRUCTURE <b>DWRITE_FONT_AXIS_RANGE</b><br/>
/// DWRITE_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FontAxisRange {

	/// <summary>
	/// <b>DWRITE_FONT_AXIS_TAG axisTag</b>
	/// </summary>
	public readonly FontAxisTag AxisTag {
		get => _axisTag;
		init => _axisTag = value;
	}
	readonly FontAxisTag _axisTag;

	/// <summary>
	/// <b>FLOAT minValue</b>
	/// </summary>
	public readonly float MinValue {
		get => _minValue;
		init => _minValue = value;
	}
	readonly float _minValue;

	/// <summary>
	/// <b>FLOAT maxValue</b>
	/// </summary>
	public readonly float MaxValue {
		get => _maxValue;
		init => _maxValue = value;
	}
	readonly float _maxValue;

}
