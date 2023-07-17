using System;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// ENUM <b>DWRITE_MEASURING_MODE</b><br/>
/// DCOMMON.h
/// </summary>
public enum MeasuringMode : uint {
	/// <summary>
	/// <b>DWRITE_MEASURING_MODE_NATURAL</b>
	/// </summary>
	Natural,
	/// <summary>
	/// <b>DWRITE_MEASURING_MODE_GDI_CLASSIC</b>
	/// </summary>
	GdiClassic,
	/// <summary>
	/// <b>DWRITE_MEASURING_MODE_GDI_NATURAL</b>
	/// </summary>
	GdiNatural,
}

/// <summary>
/// ENUM <b>DWRITE_GLYPH_IMAGE_FORMATS</b><br/>
/// DCOMMON.h
/// </summary>
[Flags]
public enum GlyphImageFormats : uint {
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_NONE</b> = 0x00000000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE</b> = 0x00000001
	/// </summary>
	Truetype = 1,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_CFF</b> = 0x00000002
	/// </summary>
	Cff = 2,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_COLR</b> = 0x00000004
	/// </summary>
	Colr = 4,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_SVG</b> = 0x00000008
	/// </summary>
	Svg = 8,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_PNG</b> = 0x00000010
	/// </summary>
	Png = 16,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_JPEG</b> = 0x00000020
	/// </summary>
	Jpeg = 32,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_TIFF</b> = 0x00000040
	/// </summary>
	Tiff = 64,
	/// <summary>
	/// <b>DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8</b> = 0x00000080
	/// </summary>
	PremultipliedB8g8r8a8 = 128,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_FILE_TYPE</b><br/>
/// DWRITE.h
/// </summary>
public enum FontFileType : uint {
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_UNKNOWN</b>
	/// </summary>
	Unknown,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_CFF</b>
	/// </summary>
	Cff,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_TRUETYPE</b>
	/// </summary>
	Truetype,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION</b>
	/// </summary>
	OpentypeCollection,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_TYPE1_PFM</b>
	/// </summary>
	Type1Pfm,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_TYPE1_PFB</b>
	/// </summary>
	Type1Pfb,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_VECTOR</b>
	/// </summary>
	Vector,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_BITMAP</b>
	/// </summary>
	Bitmap,
	/// <summary>
	/// <b>DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION</b> = DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION
	/// </summary>
	TruetypeCollection = OpentypeCollection,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_FACE_TYPE</b><br/>
/// DWRITE.h
/// </summary>
public enum FontFaceType : uint {
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_CFF</b>
	/// </summary>
	Cff,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_TRUETYPE</b>
	/// </summary>
	Truetype,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION</b>
	/// </summary>
	OpentypeCollection,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_TYPE1</b>
	/// </summary>
	Type1,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_VECTOR</b>
	/// </summary>
	Vector,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_BITMAP</b>
	/// </summary>
	Bitmap,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_UNKNOWN</b>
	/// </summary>
	Unknown,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_RAW_CFF</b>
	/// </summary>
	RawCff,
	/// <summary>
	/// <b>DWRITE_FONT_FACE_TYPE_TRUETYPE_COLLECTION</b> = DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION
	/// </summary>
	TruetypeCollection = OpentypeCollection,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_SIMULATIONS</b><br/>
/// DWRITE.h
/// </summary>
[Flags]
public enum FontSimulations : uint {
	/// <summary>
	/// <b>DWRITE_FONT_SIMULATIONS_NONE</b> = 0x0000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>DWRITE_FONT_SIMULATIONS_BOLD</b> = 0x0001
	/// </summary>
	Bold = 1,
	/// <summary>
	/// <b>DWRITE_FONT_SIMULATIONS_OBLIQUE</b> = 0x0002
	/// </summary>
	Oblique = 2,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_WEIGHT</b><br/>
/// DWRITE.h
/// </summary>
public enum FontWeight : uint {
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_THIN</b> = 100
	/// </summary>
	Thin = 100,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_EXTRA_LIGHT</b> = 200
	/// </summary>
	ExtraLight = 200,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_ULTRA_LIGHT</b> = 200
	/// </summary>
	UltraLight = 200,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_LIGHT</b> = 300
	/// </summary>
	Light = 300,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_SEMI_LIGHT</b> = 350
	/// </summary>
	SemiLight = 350,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_NORMAL</b> = 400
	/// </summary>
	Normal = 400,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_REGULAR</b> = 400
	/// </summary>
	Regular = 400,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_MEDIUM</b> = 500
	/// </summary>
	Medium = 500,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_DEMI_BOLD</b> = 600
	/// </summary>
	DemiBold = 600,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_SEMI_BOLD</b> = 600
	/// </summary>
	SemiBold = 600,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_BOLD</b> = 700
	/// </summary>
	Bold = 700,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_EXTRA_BOLD</b> = 800
	/// </summary>
	ExtraBold = 800,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_ULTRA_BOLD</b> = 800
	/// </summary>
	UltraBold = 800,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_BLACK</b> = 900
	/// </summary>
	Black = 900,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_HEAVY</b> = 900
	/// </summary>
	Heavy = 900,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_EXTRA_BLACK</b> = 950
	/// </summary>
	ExtraBlack = 950,
	/// <summary>
	/// <b>DWRITE_FONT_WEIGHT_ULTRA_BLACK</b> = 950
	/// </summary>
	UltraBlack = 950,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_STRETCH</b><br/>
/// DWRITE.h
/// </summary>
public enum FontStretch : uint {
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_ULTRA_CONDENSED</b> = 1
	/// </summary>
	UltraCondensed = 1,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_EXTRA_CONDENSED</b> = 2
	/// </summary>
	ExtraCondensed = 2,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_CONDENSED</b> = 3
	/// </summary>
	Condensed = 3,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_SEMI_CONDENSED</b> = 4
	/// </summary>
	SemiCondensed = 4,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_NORMAL</b> = 5
	/// </summary>
	Normal = 5,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_MEDIUM</b> = 5
	/// </summary>
	Medium = 5,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_SEMI_EXPANDED</b> = 6
	/// </summary>
	SemiExpanded = 6,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_EXPANDED</b> = 7
	/// </summary>
	Expanded = 7,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_EXTRA_EXPANDED</b> = 8
	/// </summary>
	ExtraExpanded = 8,
	/// <summary>
	/// <b>DWRITE_FONT_STRETCH_ULTRA_EXPANDED</b> = 9
	/// </summary>
	UltraExpanded = 9,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_STYLE</b><br/>
/// DWRITE.h
/// </summary>
public enum FontStyle : uint {
	/// <summary>
	/// <b>DWRITE_FONT_STYLE_NORMAL</b>
	/// </summary>
	Normal,
	/// <summary>
	/// <b>DWRITE_FONT_STYLE_OBLIQUE</b>
	/// </summary>
	Oblique,
	/// <summary>
	/// <b>DWRITE_FONT_STYLE_ITALIC</b>
	/// </summary>
	Italic,
}

/// <summary>
/// ENUM <b>DWRITE_INFORMATIONAL_STRING_ID</b><br/>
/// DWRITE.h
/// </summary>
public enum InformationalStringId : uint {
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_NONE</b>
	/// </summary>
	None,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE</b>
	/// </summary>
	CopyrightNotice,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS</b>
	/// </summary>
	VersionStrings,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_TRADEMARK</b>
	/// </summary>
	Trademark,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_MANUFACTURER</b>
	/// </summary>
	Manufacturer,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_DESIGNER</b>
	/// </summary>
	Designer,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_DESIGNER_URL</b>
	/// </summary>
	DesignerUrl,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_DESCRIPTION</b>
	/// </summary>
	Description,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL</b>
	/// </summary>
	FontVendorUrl,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION</b>
	/// </summary>
	LicenseDescription,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL</b>
	/// </summary>
	LicenseInfoUrl,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES</b>
	/// </summary>
	Win32FamilyNames,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES</b>
	/// </summary>
	Win32SubfamilyNames,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES</b>
	/// </summary>
	TypographicFamilyNames,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES</b>
	/// </summary>
	TypographicSubfamilyNames,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT</b>
	/// </summary>
	SampleText,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_FULL_NAME</b>
	/// </summary>
	FullName,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME</b>
	/// </summary>
	PostscriptName,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME</b>
	/// </summary>
	PostscriptCidName,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME</b>
	/// </summary>
	WeightStretchStyleFamilyName,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_DESIGN_SCRIPT_LANGUAGE_TAG</b>
	/// </summary>
	DesignScriptLanguageTag,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_SUPPORTED_SCRIPT_LANGUAGE_TAG</b>
	/// </summary>
	SupportedScriptLanguageTag,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES</b> = DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES
	/// </summary>
	PreferredFamilyNames = TypographicFamilyNames,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES</b> = DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES
	/// </summary>
	PreferredSubfamilyNames = TypographicSubfamilyNames,
	/// <summary>
	/// <b>DWRITE_INFORMATIONAL_STRING_WWS_FAMILY_NAME</b> = DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME
	/// </summary>
	WwsFamilyName = WeightStretchStyleFamilyName,
}

/// <summary>
/// ENUM <b>DWRITE_FACTORY_TYPE</b><br/>
/// DWRITE.h
/// </summary>
public enum FactoryType : uint {
	/// <summary>
	/// <b>DWRITE_FACTORY_TYPE_SHARED</b>
	/// </summary>
	Shared,
	/// <summary>
	/// <b>DWRITE_FACTORY_TYPE_ISOLATED</b>
	/// </summary>
	Isolated,
}

/// <summary>
/// ENUM <b>DWRITE_PIXEL_GEOMETRY</b><br/>
/// DWRITE.h
/// </summary>
public enum PixelGeometry : uint {
	/// <summary>
	/// <b>DWRITE_PIXEL_GEOMETRY_FLAT</b>
	/// </summary>
	Flat,
	/// <summary>
	/// <b>DWRITE_PIXEL_GEOMETRY_RGB</b>
	/// </summary>
	Rgb,
	/// <summary>
	/// <b>DWRITE_PIXEL_GEOMETRY_BGR</b>
	/// </summary>
	Bgr,
}

/// <summary>
/// ENUM <b>DWRITE_RENDERING_MODE</b><br/>
/// DWRITE.h
/// </summary>
public enum RenderingMode : uint {
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_DEFAULT</b>
	/// </summary>
	Default,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_ALIASED</b>
	/// </summary>
	Aliased,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_GDI_CLASSIC</b>
	/// </summary>
	GdiClassic,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_GDI_NATURAL</b>
	/// </summary>
	GdiNatural,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_NATURAL</b>
	/// </summary>
	Natural,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC</b>
	/// </summary>
	NaturalSymmetric,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_OUTLINE</b>
	/// </summary>
	Outline,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC</b> = DWRITE_RENDERING_MODE_GDI_CLASSIC
	/// </summary>
	CleartypeGdiClassic = GdiClassic,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL</b> = DWRITE_RENDERING_MODE_GDI_NATURAL
	/// </summary>
	CleartypeGdiNatural = GdiNatural,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL</b> = DWRITE_RENDERING_MODE_NATURAL
	/// </summary>
	CleartypeNatural = Natural,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL_SYMMETRIC</b> = DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC
	/// </summary>
	CleartypeNaturalSymmetric = NaturalSymmetric,
}

/// <summary>
/// ENUM <b>DWRITE_READING_DIRECTION</b><br/>
/// DWRITE.h
/// </summary>
public enum ReadingDirection : uint {
	/// <summary>
	/// <b>DWRITE_READING_DIRECTION_LEFT_TO_RIGHT</b> = 0
	/// </summary>
	LeftToRight = 0,
	/// <summary>
	/// <b>DWRITE_READING_DIRECTION_RIGHT_TO_LEFT</b> = 1
	/// </summary>
	RightToLeft = 1,
	/// <summary>
	/// <b>DWRITE_READING_DIRECTION_TOP_TO_BOTTOM</b> = 2
	/// </summary>
	TopToBottom = 2,
	/// <summary>
	/// <b>DWRITE_READING_DIRECTION_BOTTOM_TO_TOP</b> = 3
	/// </summary>
	BottomToTop = 3,
}

/// <summary>
/// ENUM <b>DWRITE_FLOW_DIRECTION</b><br/>
/// DWRITE.h
/// </summary>
public enum FlowDirection : uint {
	/// <summary>
	/// <b>DWRITE_FLOW_DIRECTION_TOP_TO_BOTTOM</b> = 0
	/// </summary>
	TopToBottom = 0,
	/// <summary>
	/// <b>DWRITE_FLOW_DIRECTION_BOTTOM_TO_TOP</b> = 1
	/// </summary>
	BottomToTop = 1,
	/// <summary>
	/// <b>DWRITE_FLOW_DIRECTION_LEFT_TO_RIGHT</b> = 2
	/// </summary>
	LeftToRight = 2,
	/// <summary>
	/// <b>DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT</b> = 3
	/// </summary>
	RightToLeft = 3,
}

/// <summary>
/// ENUM <b>DWRITE_TEXT_ALIGNMENT</b><br/>
/// DWRITE.h
/// </summary>
public enum TextAlignment : uint {
	/// <summary>
	/// <b>DWRITE_TEXT_ALIGNMENT_LEADING</b>
	/// </summary>
	Leading,
	/// <summary>
	/// <b>DWRITE_TEXT_ALIGNMENT_TRAILING</b>
	/// </summary>
	Trailing,
	/// <summary>
	/// <b>DWRITE_TEXT_ALIGNMENT_CENTER</b>
	/// </summary>
	Center,
	/// <summary>
	/// <b>DWRITE_TEXT_ALIGNMENT_JUSTIFIED</b>
	/// </summary>
	Justified,
}

/// <summary>
/// ENUM <b>DWRITE_PARAGRAPH_ALIGNMENT</b><br/>
/// DWRITE.h
/// </summary>
public enum ParagraphAlignment : uint {
	/// <summary>
	/// <b>DWRITE_PARAGRAPH_ALIGNMENT_NEAR</b>
	/// </summary>
	Near,
	/// <summary>
	/// <b>DWRITE_PARAGRAPH_ALIGNMENT_FAR</b>
	/// </summary>
	Far,
	/// <summary>
	/// <b>DWRITE_PARAGRAPH_ALIGNMENT_CENTER</b>
	/// </summary>
	Center,
}

/// <summary>
/// ENUM <b>DWRITE_WORD_WRAPPING</b><br/>
/// DWRITE.h
/// </summary>
public enum WordWrapping : uint {
	/// <summary>
	/// <b>DWRITE_WORD_WRAPPING_WRAP</b> = 0
	/// </summary>
	Wrap = 0,
	/// <summary>
	/// <b>DWRITE_WORD_WRAPPING_NO_WRAP</b> = 1
	/// </summary>
	NoWrap = 1,
	/// <summary>
	/// <b>DWRITE_WORD_WRAPPING_EMERGENCY_BREAK</b> = 2
	/// </summary>
	EmergencyBreak = 2,
	/// <summary>
	/// <b>DWRITE_WORD_WRAPPING_WHOLE_WORD</b> = 3
	/// </summary>
	WholeWord = 3,
	/// <summary>
	/// <b>DWRITE_WORD_WRAPPING_CHARACTER</b> = 4
	/// </summary>
	Character = 4,
}

/// <summary>
/// ENUM <b>DWRITE_LINE_SPACING_METHOD</b><br/>
/// DWRITE.h
/// </summary>
public enum LineSpacingMethod : uint {
	/// <summary>
	/// <b>DWRITE_LINE_SPACING_METHOD_DEFAULT</b>
	/// </summary>
	Default,
	/// <summary>
	/// <b>DWRITE_LINE_SPACING_METHOD_UNIFORM</b>
	/// </summary>
	Uniform,
	/// <summary>
	/// <b>DWRITE_LINE_SPACING_METHOD_PROPORTIONAL</b>
	/// </summary>
	Proportional,
}

/// <summary>
/// ENUM <b>DWRITE_TRIMMING_GRANULARITY</b><br/>
/// DWRITE.h
/// </summary>
public enum TrimmingGranularity : uint {
	/// <summary>
	/// <b>DWRITE_TRIMMING_GRANULARITY_NONE</b>
	/// </summary>
	None,
	/// <summary>
	/// <b>DWRITE_TRIMMING_GRANULARITY_CHARACTER</b>
	/// </summary>
	Character,
	/// <summary>
	/// <b>DWRITE_TRIMMING_GRANULARITY_WORD</b>
	/// </summary>
	Word,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_FEATURE_TAG</b><br/>
/// DWRITE.h
/// </summary>
public enum FontFeatureTag : uint {
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_ALTERNATIVE_FRACTIONS</b> = DWRITE_MAKE_OPENTYPE_TAG('a','f','r','c')
	/// </summary>
	AlternativeFractions = 1668441697,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS_FROM_CAPITALS</b> = DWRITE_MAKE_OPENTYPE_TAG('c','2','p','c')
	/// </summary>
	PetiteCapitalsFromCapitals = 1668297315,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS_FROM_CAPITALS</b> = DWRITE_MAKE_OPENTYPE_TAG('c','2','s','c')
	/// </summary>
	SmallCapitalsFromCapitals = 1668493923,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_ALTERNATES</b> = DWRITE_MAKE_OPENTYPE_TAG('c','a','l','t')
	/// </summary>
	ContextualAlternates = 1953259875,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_CASE_SENSITIVE_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('c','a','s','e')
	/// </summary>
	CaseSensitiveForms = 1702060387,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_GLYPH_COMPOSITION_DECOMPOSITION</b> = DWRITE_MAKE_OPENTYPE_TAG('c','c','m','p')
	/// </summary>
	GlyphCompositionDecomposition = 1886217059,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_LIGATURES</b> = DWRITE_MAKE_OPENTYPE_TAG('c','l','i','g')
	/// </summary>
	ContextualLigatures = 1734962275,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_CAPITAL_SPACING</b> = DWRITE_MAKE_OPENTYPE_TAG('c','p','s','p')
	/// </summary>
	CapitalSpacing = 1886613603,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_SWASH</b> = DWRITE_MAKE_OPENTYPE_TAG('c','s','w','h')
	/// </summary>
	ContextualSwash = 1752658787,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_CURSIVE_POSITIONING</b> = DWRITE_MAKE_OPENTYPE_TAG('c','u','r','s')
	/// </summary>
	CursivePositioning = 1936880995,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_DEFAULT</b> = DWRITE_MAKE_OPENTYPE_TAG('d','f','l','t')
	/// </summary>
	Default = 1953261156,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_DISCRETIONARY_LIGATURES</b> = DWRITE_MAKE_OPENTYPE_TAG('d','l','i','g')
	/// </summary>
	DiscretionaryLigatures = 1734962276,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_EXPERT_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('e','x','p','t')
	/// </summary>
	ExpertForms = 1953527909,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_FRACTIONS</b> = DWRITE_MAKE_OPENTYPE_TAG('f','r','a','c')
	/// </summary>
	Fractions = 1667330662,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_FULL_WIDTH</b> = DWRITE_MAKE_OPENTYPE_TAG('f','w','i','d')
	/// </summary>
	FullWidth = 1684633446,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_HALF_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('h','a','l','f')
	/// </summary>
	HalfForms = 1718378856,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_HALANT_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('h','a','l','n')
	/// </summary>
	HalantForms = 1852596584,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_ALTERNATE_HALF_WIDTH</b> = DWRITE_MAKE_OPENTYPE_TAG('h','a','l','t')
	/// </summary>
	AlternateHalfWidth = 1953259880,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_HISTORICAL_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('h','i','s','t')
	/// </summary>
	HistoricalForms = 1953720680,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_HORIZONTAL_KANA_ALTERNATES</b> = DWRITE_MAKE_OPENTYPE_TAG('h','k','n','a')
	/// </summary>
	HorizontalKanaAlternates = 1634626408,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_HISTORICAL_LIGATURES</b> = DWRITE_MAKE_OPENTYPE_TAG('h','l','i','g')
	/// </summary>
	HistoricalLigatures = 1734962280,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_HALF_WIDTH</b> = DWRITE_MAKE_OPENTYPE_TAG('h','w','i','d')
	/// </summary>
	HalfWidth = 1684633448,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_HOJO_KANJI_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('h','o','j','o')
	/// </summary>
	HojoKanjiForms = 1869246312,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_JIS04_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('j','p','0','4')
	/// </summary>
	Jis04Forms = 875589738,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_JIS78_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('j','p','7','8')
	/// </summary>
	Jis78Forms = 943157354,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_JIS83_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('j','p','8','3')
	/// </summary>
	Jis83Forms = 859336810,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_JIS90_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('j','p','9','0')
	/// </summary>
	Jis90Forms = 809070698,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_KERNING</b> = DWRITE_MAKE_OPENTYPE_TAG('k','e','r','n')
	/// </summary>
	Kerning = 1852990827,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STANDARD_LIGATURES</b> = DWRITE_MAKE_OPENTYPE_TAG('l','i','g','a')
	/// </summary>
	StandardLigatures = 1634167148,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_LINING_FIGURES</b> = DWRITE_MAKE_OPENTYPE_TAG('l','n','u','m')
	/// </summary>
	LiningFigures = 1836412524,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_LOCALIZED_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('l','o','c','l')
	/// </summary>
	LocalizedForms = 1818455916,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_MARK_POSITIONING</b> = DWRITE_MAKE_OPENTYPE_TAG('m','a','r','k')
	/// </summary>
	MarkPositioning = 1802658157,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_MATHEMATICAL_GREEK</b> = DWRITE_MAKE_OPENTYPE_TAG('m','g','r','k')
	/// </summary>
	MathematicalGreek = 1802659693,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_MARK_TO_MARK_POSITIONING</b> = DWRITE_MAKE_OPENTYPE_TAG('m','k','m','k')
	/// </summary>
	MarkToMarkPositioning = 1802333037,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_ALTERNATE_ANNOTATION_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('n','a','l','t')
	/// </summary>
	AlternateAnnotationForms = 1953259886,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_NLC_KANJI_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('n','l','c','k')
	/// </summary>
	NlcKanjiForms = 1801677934,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_OLD_STYLE_FIGURES</b> = DWRITE_MAKE_OPENTYPE_TAG('o','n','u','m')
	/// </summary>
	OldStyleFigures = 1836412527,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_ORDINALS</b> = DWRITE_MAKE_OPENTYPE_TAG('o','r','d','n')
	/// </summary>
	Ordinals = 1852076655,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_ALTERNATE_WIDTH</b> = DWRITE_MAKE_OPENTYPE_TAG('p','a','l','t')
	/// </summary>
	ProportionalAlternateWidth = 1953259888,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS</b> = DWRITE_MAKE_OPENTYPE_TAG('p','c','a','p')
	/// </summary>
	PetiteCapitals = 1885430640,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_FIGURES</b> = DWRITE_MAKE_OPENTYPE_TAG('p','n','u','m')
	/// </summary>
	ProportionalFigures = 1836412528,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_WIDTHS</b> = DWRITE_MAKE_OPENTYPE_TAG('p','w','i','d')
	/// </summary>
	ProportionalWidths = 1684633456,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_QUARTER_WIDTHS</b> = DWRITE_MAKE_OPENTYPE_TAG('q','w','i','d')
	/// </summary>
	QuarterWidths = 1684633457,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_REQUIRED_LIGATURES</b> = DWRITE_MAKE_OPENTYPE_TAG('r','l','i','g')
	/// </summary>
	RequiredLigatures = 1734962290,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_RUBY_NOTATION_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('r','u','b','y')
	/// </summary>
	RubyNotationForms = 2036495730,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_ALTERNATES</b> = DWRITE_MAKE_OPENTYPE_TAG('s','a','l','t')
	/// </summary>
	StylisticAlternates = 1953259891,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SCIENTIFIC_INFERIORS</b> = DWRITE_MAKE_OPENTYPE_TAG('s','i','n','f')
	/// </summary>
	ScientificInferiors = 1718511987,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS</b> = DWRITE_MAKE_OPENTYPE_TAG('s','m','c','p')
	/// </summary>
	SmallCapitals = 1885564275,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SIMPLIFIED_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('s','m','p','l')
	/// </summary>
	SimplifiedForms = 1819307379,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_1</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','1')
	/// </summary>
	StylisticSet1 = 825258867,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_2</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','2')
	/// </summary>
	StylisticSet2 = 842036083,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_3</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','3')
	/// </summary>
	StylisticSet3 = 858813299,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_4</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','4')
	/// </summary>
	StylisticSet4 = 875590515,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_5</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','5')
	/// </summary>
	StylisticSet5 = 892367731,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_6</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','6')
	/// </summary>
	StylisticSet6 = 909144947,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','7')
	/// </summary>
	StylisticSet7 = 925922163,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_8</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','8')
	/// </summary>
	StylisticSet8 = 942699379,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_9</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','0','9')
	/// </summary>
	StylisticSet9 = 959476595,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_10</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','0')
	/// </summary>
	StylisticSet10 = 808547187,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_11</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','1')
	/// </summary>
	StylisticSet11 = 825324403,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_12</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','2')
	/// </summary>
	StylisticSet12 = 842101619,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_13</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','3')
	/// </summary>
	StylisticSet13 = 858878835,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_14</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','4')
	/// </summary>
	StylisticSet14 = 875656051,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_15</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','5')
	/// </summary>
	StylisticSet15 = 892433267,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_16</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','6')
	/// </summary>
	StylisticSet16 = 909210483,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_17</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','7')
	/// </summary>
	StylisticSet17 = 925987699,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_18</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','8')
	/// </summary>
	StylisticSet18 = 942764915,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_19</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','1','9')
	/// </summary>
	StylisticSet19 = 959542131,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_20</b> = DWRITE_MAKE_OPENTYPE_TAG('s','s','2','0')
	/// </summary>
	StylisticSet20 = 808612723,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SUBSCRIPT</b> = DWRITE_MAKE_OPENTYPE_TAG('s','u','b','s')
	/// </summary>
	Subscript = 1935832435,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SUPERSCRIPT</b> = DWRITE_MAKE_OPENTYPE_TAG('s','u','p','s')
	/// </summary>
	Superscript = 1936749939,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SWASH</b> = DWRITE_MAKE_OPENTYPE_TAG('s','w','s','h')
	/// </summary>
	Swash = 1752397683,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_TITLING</b> = DWRITE_MAKE_OPENTYPE_TAG('t','i','t','l')
	/// </summary>
	Titling = 1819568500,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_TRADITIONAL_NAME_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('t','n','a','m')
	/// </summary>
	TraditionalNameForms = 1835101812,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_TABULAR_FIGURES</b> = DWRITE_MAKE_OPENTYPE_TAG('t','n','u','m')
	/// </summary>
	TabularFigures = 1836412532,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_TRADITIONAL_FORMS</b> = DWRITE_MAKE_OPENTYPE_TAG('t','r','a','d')
	/// </summary>
	TraditionalForms = 1684107892,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_THIRD_WIDTHS</b> = DWRITE_MAKE_OPENTYPE_TAG('t','w','i','d')
	/// </summary>
	ThirdWidths = 1684633460,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_UNICASE</b> = DWRITE_MAKE_OPENTYPE_TAG('u','n','i','c')
	/// </summary>
	Unicase = 1667853941,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_VERTICAL_WRITING</b> = DWRITE_MAKE_OPENTYPE_TAG('v','e','r','t')
	/// </summary>
	VerticalWriting = 1953654134,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_VERTICAL_ALTERNATES_AND_ROTATION</b> = DWRITE_MAKE_OPENTYPE_TAG('v','r','t','2')
	/// </summary>
	VerticalAlternatesAndRotation = 846492278,
	/// <summary>
	/// <b>DWRITE_FONT_FEATURE_TAG_SLASHED_ZERO</b> = DWRITE_MAKE_OPENTYPE_TAG('z','e','r','o')
	/// </summary>
	SlashedZero = 1869768058,
}

/// <summary>
/// ENUM <b>DWRITE_SCRIPT_SHAPES</b><br/>
/// DWRITE.h
/// </summary>
public enum ScriptShapes : uint {
	/// <summary>
	/// <b>DWRITE_SCRIPT_SHAPES_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>DWRITE_SCRIPT_SHAPES_NO_VISUAL</b> = 1
	/// </summary>
	NoVisual = 1,
}

/// <summary>
/// ENUM <b>DWRITE_BREAK_CONDITION</b><br/>
/// DWRITE.h
/// </summary>
public enum BreakCondition : uint {
	/// <summary>
	/// <b>DWRITE_BREAK_CONDITION_NEUTRAL</b>
	/// </summary>
	Neutral,
	/// <summary>
	/// <b>DWRITE_BREAK_CONDITION_CAN_BREAK</b>
	/// </summary>
	CanBreak,
	/// <summary>
	/// <b>DWRITE_BREAK_CONDITION_MAY_NOT_BREAK</b>
	/// </summary>
	MayNotBreak,
	/// <summary>
	/// <b>DWRITE_BREAK_CONDITION_MUST_BREAK</b>
	/// </summary>
	MustBreak,
}

/// <summary>
/// ENUM <b>DWRITE_NUMBER_SUBSTITUTION_METHOD</b><br/>
/// DWRITE.h
/// </summary>
public enum NumberSubstitutionMethod : uint {
	/// <summary>
	/// <b>DWRITE_NUMBER_SUBSTITUTION_METHOD_FROM_CULTURE</b>
	/// </summary>
	FromCulture,
	/// <summary>
	/// <b>DWRITE_NUMBER_SUBSTITUTION_METHOD_CONTEXTUAL</b>
	/// </summary>
	Contextual,
	/// <summary>
	/// <b>DWRITE_NUMBER_SUBSTITUTION_METHOD_NONE</b>
	/// </summary>
	None,
	/// <summary>
	/// <b>DWRITE_NUMBER_SUBSTITUTION_METHOD_NATIONAL</b>
	/// </summary>
	National,
	/// <summary>
	/// <b>DWRITE_NUMBER_SUBSTITUTION_METHOD_TRADITIONAL</b>
	/// </summary>
	Traditional,
}

/// <summary>
/// ENUM <b>DWRITE_TEXTURE_TYPE</b><br/>
/// DWRITE.h
/// </summary>
public enum TextureType : uint {
	/// <summary>
	/// <b>DWRITE_TEXTURE_ALIASED_1x1</b>
	/// </summary>
	Aliased1x1,
	/// <summary>
	/// <b>DWRITE_TEXTURE_CLEARTYPE_3x1</b>
	/// </summary>
	Cleartype3x1,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_FAMILY</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseFamily : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_FAMILY_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_FAMILY_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_FAMILY_TEXT_DISPLAY</b> = 2
	/// </summary>
	TextDisplay = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_FAMILY_SCRIPT</b> = 3
	/// </summary>
	Script = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_FAMILY_DECORATIVE</b> = 4
	/// </summary>
	Decorative = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_FAMILY_SYMBOL</b> = 5
	/// </summary>
	Symbol = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_FAMILY_PICTORIAL</b> = DWRITE_PANOSE_FAMILY_SYMBOL
	/// </summary>
	Pictorial = Symbol,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_SERIF_STYLE</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseSerifStyle : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_COVE</b> = 2
	/// </summary>
	Cove = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_OBTUSE_COVE</b> = 3
	/// </summary>
	ObtuseCove = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_SQUARE_COVE</b> = 4
	/// </summary>
	SquareCove = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_OBTUSE_SQUARE_COVE</b> = 5
	/// </summary>
	ObtuseSquareCove = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_SQUARE</b> = 6
	/// </summary>
	Square = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_THIN</b> = 7
	/// </summary>
	Thin = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_OVAL</b> = 8
	/// </summary>
	Oval = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_EXAGGERATED</b> = 9
	/// </summary>
	Exaggerated = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_TRIANGLE</b> = 10
	/// </summary>
	Triangle = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_NORMAL_SANS</b> = 11
	/// </summary>
	NormalSans = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_OBTUSE_SANS</b> = 12
	/// </summary>
	ObtuseSans = 12,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_PERPENDICULAR_SANS</b> = 13
	/// </summary>
	PerpendicularSans = 13,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_FLARED</b> = 14
	/// </summary>
	Flared = 14,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_ROUNDED</b> = 15
	/// </summary>
	Rounded = 15,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_SCRIPT</b> = 16
	/// </summary>
	Script = 16,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_PERP_SANS</b> = DWRITE_PANOSE_SERIF_STYLE_PERPENDICULAR_SANS
	/// </summary>
	PerpSans = PerpendicularSans,
	/// <summary>
	/// <b>DWRITE_PANOSE_SERIF_STYLE_BONE</b> = DWRITE_PANOSE_SERIF_STYLE_OVAL
	/// </summary>
	Bone = Oval,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_WEIGHT</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseWeight : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_VERY_LIGHT</b> = 2
	/// </summary>
	VeryLight = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_LIGHT</b> = 3
	/// </summary>
	Light = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_THIN</b> = 4
	/// </summary>
	Thin = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_BOOK</b> = 5
	/// </summary>
	Book = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_MEDIUM</b> = 6
	/// </summary>
	Medium = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_DEMI</b> = 7
	/// </summary>
	Demi = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_BOLD</b> = 8
	/// </summary>
	Bold = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_HEAVY</b> = 9
	/// </summary>
	Heavy = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_BLACK</b> = 10
	/// </summary>
	Black = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_EXTRA_BLACK</b> = 11
	/// </summary>
	ExtraBlack = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_WEIGHT_NORD</b> = DWRITE_PANOSE_WEIGHT_EXTRA_BLACK
	/// </summary>
	Nord = ExtraBlack,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_PROPORTION</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseProportion : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_OLD_STYLE</b> = 2
	/// </summary>
	OldStyle = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_MODERN</b> = 3
	/// </summary>
	Modern = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_EVEN_WIDTH</b> = 4
	/// </summary>
	EvenWidth = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_EXPANDED</b> = 5
	/// </summary>
	Expanded = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_CONDENSED</b> = 6
	/// </summary>
	Condensed = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_VERY_EXPANDED</b> = 7
	/// </summary>
	VeryExpanded = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_VERY_CONDENSED</b> = 8
	/// </summary>
	VeryCondensed = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_PROPORTION_MONOSPACED</b> = 9
	/// </summary>
	Monospaced = 9,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_CONTRAST</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseContrast : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_NONE</b> = 2
	/// </summary>
	None = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_VERY_LOW</b> = 3
	/// </summary>
	VeryLow = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_LOW</b> = 4
	/// </summary>
	Low = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_MEDIUM_LOW</b> = 5
	/// </summary>
	MediumLow = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_MEDIUM</b> = 6
	/// </summary>
	Medium = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_MEDIUM_HIGH</b> = 7
	/// </summary>
	MediumHigh = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_HIGH</b> = 8
	/// </summary>
	High = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_VERY_HIGH</b> = 9
	/// </summary>
	VeryHigh = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_HORIZONTAL_LOW</b> = 10
	/// </summary>
	HorizontalLow = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_HORIZONTAL_MEDIUM</b> = 11
	/// </summary>
	HorizontalMedium = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_HORIZONTAL_HIGH</b> = 12
	/// </summary>
	HorizontalHigh = 12,
	/// <summary>
	/// <b>DWRITE_PANOSE_CONTRAST_BROKEN</b> = 13
	/// </summary>
	Broken = 13,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_STROKE_VARIATION</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseStrokeVariation : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_NO_VARIATION</b> = 2
	/// </summary>
	NoVariation = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_DIAGONAL</b> = 3
	/// </summary>
	GradualDiagonal = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_TRANSITIONAL</b> = 4
	/// </summary>
	GradualTransitional = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_VERTICAL</b> = 5
	/// </summary>
	GradualVertical = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_HORIZONTAL</b> = 6
	/// </summary>
	GradualHorizontal = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_RAPID_VERTICAL</b> = 7
	/// </summary>
	RapidVertical = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_RAPID_HORIZONTAL</b> = 8
	/// </summary>
	RapidHorizontal = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_INSTANT_VERTICAL</b> = 9
	/// </summary>
	InstantVertical = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_STROKE_VARIATION_INSTANT_HORIZONTAL</b> = 10
	/// </summary>
	InstantHorizontal = 10,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_ARM_STYLE</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseArmStyle : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORIZONTAL</b> = 2
	/// </summary>
	StraightArmsHorizontal = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_WEDGE</b> = 3
	/// </summary>
	StraightArmsWedge = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERTICAL</b> = 4
	/// </summary>
	StraightArmsVertical = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_SINGLE_SERIF</b> = 5
	/// </summary>
	StraightArmsSingleSerif = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_DOUBLE_SERIF</b> = 6
	/// </summary>
	StraightArmsDoubleSerif = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_HORIZONTAL</b> = 7
	/// </summary>
	NonstraightArmsHorizontal = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_WEDGE</b> = 8
	/// </summary>
	NonstraightArmsWedge = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_VERTICAL</b> = 9
	/// </summary>
	NonstraightArmsVertical = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_SINGLE_SERIF</b> = 10
	/// </summary>
	NonstraightArmsSingleSerif = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_DOUBLE_SERIF</b> = 11
	/// </summary>
	NonstraightArmsDoubleSerif = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORZ</b> = DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORIZONTAL
	/// </summary>
	StraightArmsHorz = StraightArmsHorizontal,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERT</b> = DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERTICAL
	/// </summary>
	StraightArmsVert = StraightArmsVertical,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_HORZ</b> = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_HORIZONTAL
	/// </summary>
	BentArmsHorz = NonstraightArmsHorizontal,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_WEDGE</b> = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_WEDGE
	/// </summary>
	BentArmsWedge = NonstraightArmsWedge,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_VERT</b> = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_VERTICAL
	/// </summary>
	BentArmsVert = NonstraightArmsVertical,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_SINGLE_SERIF</b> = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_SINGLE_SERIF
	/// </summary>
	BentArmsSingleSerif = NonstraightArmsSingleSerif,
	/// <summary>
	/// <b>DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_DOUBLE_SERIF</b> = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_DOUBLE_SERIF
	/// </summary>
	BentArmsDoubleSerif = NonstraightArmsDoubleSerif,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_LETTERFORM</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseLetterform : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NORMAL_CONTACT</b> = 2
	/// </summary>
	NormalContact = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NORMAL_WEIGHTED</b> = 3
	/// </summary>
	NormalWeighted = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NORMAL_BOXED</b> = 4
	/// </summary>
	NormalBoxed = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NORMAL_FLATTENED</b> = 5
	/// </summary>
	NormalFlattened = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NORMAL_ROUNDED</b> = 6
	/// </summary>
	NormalRounded = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NORMAL_OFF_CENTER</b> = 7
	/// </summary>
	NormalOffCenter = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_NORMAL_SQUARE</b> = 8
	/// </summary>
	NormalSquare = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_OBLIQUE_CONTACT</b> = 9
	/// </summary>
	ObliqueContact = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_OBLIQUE_WEIGHTED</b> = 10
	/// </summary>
	ObliqueWeighted = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_OBLIQUE_BOXED</b> = 11
	/// </summary>
	ObliqueBoxed = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_OBLIQUE_FLATTENED</b> = 12
	/// </summary>
	ObliqueFlattened = 12,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_OBLIQUE_ROUNDED</b> = 13
	/// </summary>
	ObliqueRounded = 13,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_OBLIQUE_OFF_CENTER</b> = 14
	/// </summary>
	ObliqueOffCenter = 14,
	/// <summary>
	/// <b>DWRITE_PANOSE_LETTERFORM_OBLIQUE_SQUARE</b> = 15
	/// </summary>
	ObliqueSquare = 15,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_MIDLINE</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseMidline : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_STANDARD_TRIMMED</b> = 2
	/// </summary>
	StandardTrimmed = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_STANDARD_POINTED</b> = 3
	/// </summary>
	StandardPointed = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_STANDARD_SERIFED</b> = 4
	/// </summary>
	StandardSerifed = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_HIGH_TRIMMED</b> = 5
	/// </summary>
	HighTrimmed = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_HIGH_POINTED</b> = 6
	/// </summary>
	HighPointed = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_HIGH_SERIFED</b> = 7
	/// </summary>
	HighSerifed = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_CONSTANT_TRIMMED</b> = 8
	/// </summary>
	ConstantTrimmed = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_CONSTANT_POINTED</b> = 9
	/// </summary>
	ConstantPointed = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_CONSTANT_SERIFED</b> = 10
	/// </summary>
	ConstantSerifed = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_LOW_TRIMMED</b> = 11
	/// </summary>
	LowTrimmed = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_LOW_POINTED</b> = 12
	/// </summary>
	LowPointed = 12,
	/// <summary>
	/// <b>DWRITE_PANOSE_MIDLINE_LOW_SERIFED</b> = 13
	/// </summary>
	LowSerifed = 13,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_XHEIGHT</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseXheight : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_CONSTANT_SMALL</b> = 2
	/// </summary>
	ConstantSmall = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD</b> = 3
	/// </summary>
	ConstantStandard = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_CONSTANT_LARGE</b> = 4
	/// </summary>
	ConstantLarge = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_DUCKING_SMALL</b> = 5
	/// </summary>
	DuckingSmall = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD</b> = 6
	/// </summary>
	DuckingStandard = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_DUCKING_LARGE</b> = 7
	/// </summary>
	DuckingLarge = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_CONSTANT_STD</b> = DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD
	/// </summary>
	ConstantStd = ConstantStandard,
	/// <summary>
	/// <b>DWRITE_PANOSE_XHEIGHT_DUCKING_STD</b> = DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD
	/// </summary>
	DuckingStd = DuckingStandard,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_TOOL_KIND</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseToolKind : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_FLAT_NIB</b> = 2
	/// </summary>
	FlatNib = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_PRESSURE_POINT</b> = 3
	/// </summary>
	PressurePoint = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_ENGRAVED</b> = 4
	/// </summary>
	Engraved = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_BALL</b> = 5
	/// </summary>
	Ball = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_BRUSH</b> = 6
	/// </summary>
	Brush = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_ROUGH</b> = 7
	/// </summary>
	Rough = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_FELT_PEN_BRUSH_TIP</b> = 8
	/// </summary>
	FeltPenBrushTip = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_TOOL_KIND_WILD_BRUSH</b> = 9
	/// </summary>
	WildBrush = 9,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_SPACING</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseSpacing : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_SPACING_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_SPACING_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_SPACING_PROPORTIONAL_SPACED</b> = 2
	/// </summary>
	ProportionalSpaced = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_SPACING_MONOSPACED</b> = 3
	/// </summary>
	Monospaced = 3,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_ASPECT_RATIO</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseAspectRatio : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_RATIO_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_RATIO_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_RATIO_VERY_CONDENSED</b> = 2
	/// </summary>
	VeryCondensed = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_RATIO_CONDENSED</b> = 3
	/// </summary>
	Condensed = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_RATIO_NORMAL</b> = 4
	/// </summary>
	Normal = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_RATIO_EXPANDED</b> = 5
	/// </summary>
	Expanded = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_RATIO_VERY_EXPANDED</b> = 6
	/// </summary>
	VeryExpanded = 6,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseScriptTopology : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_ROMAN_DISCONNECTED</b> = 2
	/// </summary>
	RomanDisconnected = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_ROMAN_TRAILING</b> = 3
	/// </summary>
	RomanTrailing = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_ROMAN_CONNECTED</b> = 4
	/// </summary>
	RomanConnected = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_CURSIVE_DISCONNECTED</b> = 5
	/// </summary>
	CursiveDisconnected = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_CURSIVE_TRAILING</b> = 6
	/// </summary>
	CursiveTrailing = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_CURSIVE_CONNECTED</b> = 7
	/// </summary>
	CursiveConnected = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_BLACKLETTER_DISCONNECTED</b> = 8
	/// </summary>
	BlackletterDisconnected = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_BLACKLETTER_TRAILING</b> = 9
	/// </summary>
	BlackletterTrailing = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_TOPOLOGY_BLACKLETTER_CONNECTED</b> = 10
	/// </summary>
	BlackletterConnected = 10,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_SCRIPT_FORM</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseScriptForm : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_NO_WRAPPING</b> = 2
	/// </summary>
	UprightNoWrapping = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_SOME_WRAPPING</b> = 3
	/// </summary>
	UprightSomeWrapping = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_MORE_WRAPPING</b> = 4
	/// </summary>
	UprightMoreWrapping = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_EXTREME_WRAPPING</b> = 5
	/// </summary>
	UprightExtremeWrapping = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_NO_WRAPPING</b> = 6
	/// </summary>
	ObliqueNoWrapping = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_SOME_WRAPPING</b> = 7
	/// </summary>
	ObliqueSomeWrapping = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_MORE_WRAPPING</b> = 8
	/// </summary>
	ObliqueMoreWrapping = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_EXTREME_WRAPPING</b> = 9
	/// </summary>
	ObliqueExtremeWrapping = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_NO_WRAPPING</b> = 10
	/// </summary>
	ExaggeratedNoWrapping = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_SOME_WRAPPING</b> = 11
	/// </summary>
	ExaggeratedSomeWrapping = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_MORE_WRAPPING</b> = 12
	/// </summary>
	ExaggeratedMoreWrapping = 12,
	/// <summary>
	/// <b>DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_EXTREME_WRAPPING</b> = 13
	/// </summary>
	ExaggeratedExtremeWrapping = 13,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_FINIALS</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseFinials : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_NONE_NO_LOOPS</b> = 2
	/// </summary>
	NoneNoLoops = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_NONE_CLOSED_LOOPS</b> = 3
	/// </summary>
	NoneClosedLoops = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_NONE_OPEN_LOOPS</b> = 4
	/// </summary>
	NoneOpenLoops = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_SHARP_NO_LOOPS</b> = 5
	/// </summary>
	SharpNoLoops = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_SHARP_CLOSED_LOOPS</b> = 6
	/// </summary>
	SharpClosedLoops = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_SHARP_OPEN_LOOPS</b> = 7
	/// </summary>
	SharpOpenLoops = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_TAPERED_NO_LOOPS</b> = 8
	/// </summary>
	TaperedNoLoops = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_TAPERED_CLOSED_LOOPS</b> = 9
	/// </summary>
	TaperedClosedLoops = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_TAPERED_OPEN_LOOPS</b> = 10
	/// </summary>
	TaperedOpenLoops = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_ROUND_NO_LOOPS</b> = 11
	/// </summary>
	RoundNoLoops = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_ROUND_CLOSED_LOOPS</b> = 12
	/// </summary>
	RoundClosedLoops = 12,
	/// <summary>
	/// <b>DWRITE_PANOSE_FINIALS_ROUND_OPEN_LOOPS</b> = 13
	/// </summary>
	RoundOpenLoops = 13,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_XASCENT</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseXascent : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_XASCENT_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_XASCENT_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_XASCENT_VERY_LOW</b> = 2
	/// </summary>
	VeryLow = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_XASCENT_LOW</b> = 3
	/// </summary>
	Low = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_XASCENT_MEDIUM</b> = 4
	/// </summary>
	Medium = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_XASCENT_HIGH</b> = 5
	/// </summary>
	High = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_XASCENT_VERY_HIGH</b> = 6
	/// </summary>
	VeryHigh = 6,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_DECORATIVE_CLASS</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseDecorativeClass : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_DERIVATIVE</b> = 2
	/// </summary>
	Derivative = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_NONSTANDARD_TOPOLOGY</b> = 3
	/// </summary>
	NonstandardTopology = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_NONSTANDARD_ELEMENTS</b> = 4
	/// </summary>
	NonstandardElements = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_NONSTANDARD_ASPECT</b> = 5
	/// </summary>
	NonstandardAspect = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_INITIALS</b> = 6
	/// </summary>
	Initials = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_CARTOON</b> = 7
	/// </summary>
	Cartoon = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_PICTURE_STEMS</b> = 8
	/// </summary>
	PictureStems = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_ORNAMENTED</b> = 9
	/// </summary>
	Ornamented = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_TEXT_AND_BACKGROUND</b> = 10
	/// </summary>
	TextAndBackground = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_COLLAGE</b> = 11
	/// </summary>
	Collage = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_CLASS_MONTAGE</b> = 12
	/// </summary>
	Montage = 12,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_ASPECT</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseAspect : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_SUPER_CONDENSED</b> = 2
	/// </summary>
	SuperCondensed = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_VERY_CONDENSED</b> = 3
	/// </summary>
	VeryCondensed = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_CONDENSED</b> = 4
	/// </summary>
	Condensed = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_NORMAL</b> = 5
	/// </summary>
	Normal = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_EXTENDED</b> = 6
	/// </summary>
	Extended = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_VERY_EXTENDED</b> = 7
	/// </summary>
	VeryExtended = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_SUPER_EXTENDED</b> = 8
	/// </summary>
	SuperExtended = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_ASPECT_MONOSPACED</b> = 9
	/// </summary>
	Monospaced = 9,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_FILL</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseFill : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_STANDARD_SOLID_FILL</b> = 2
	/// </summary>
	StandardSolidFill = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_NO_FILL</b> = 3
	/// </summary>
	NoFill = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_PATTERNED_FILL</b> = 4
	/// </summary>
	PatternedFill = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_COMPLEX_FILL</b> = 5
	/// </summary>
	ComplexFill = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_SHAPED_FILL</b> = 6
	/// </summary>
	ShapedFill = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_FILL_DRAWN_DISTRESSED</b> = 7
	/// </summary>
	DrawnDistressed = 7,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_LINING</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseLining : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_NONE</b> = 2
	/// </summary>
	None = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_INLINE</b> = 3
	/// </summary>
	Inline = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_OUTLINE</b> = 4
	/// </summary>
	Outline = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_ENGRAVED</b> = 5
	/// </summary>
	Engraved = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_SHADOW</b> = 6
	/// </summary>
	Shadow = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_RELIEF</b> = 7
	/// </summary>
	Relief = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_LINING_BACKDROP</b> = 8
	/// </summary>
	Backdrop = 8,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseDecorativeTopology : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_STANDARD</b> = 2
	/// </summary>
	Standard = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_SQUARE</b> = 3
	/// </summary>
	Square = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_MULTIPLE_SEGMENT</b> = 4
	/// </summary>
	MultipleSegment = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_ART_DECO</b> = 5
	/// </summary>
	ArtDeco = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_UNEVEN_WEIGHTING</b> = 6
	/// </summary>
	UnevenWeighting = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_DIVERSE_ARMS</b> = 7
	/// </summary>
	DiverseArms = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_DIVERSE_FORMS</b> = 8
	/// </summary>
	DiverseForms = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_LOMBARDIC_FORMS</b> = 9
	/// </summary>
	LombardicForms = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_UPPER_CASE_IN_LOWER_CASE</b> = 10
	/// </summary>
	UpperCaseInLowerCase = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_IMPLIED_TOPOLOGY</b> = 11
	/// </summary>
	ImpliedTopology = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_HORSESHOE_E_AND_A</b> = 12
	/// </summary>
	HorseshoeEAndA = 12,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_CURSIVE</b> = 13
	/// </summary>
	Cursive = 13,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_BLACKLETTER</b> = 14
	/// </summary>
	Blackletter = 14,
	/// <summary>
	/// <b>DWRITE_PANOSE_DECORATIVE_TOPOLOGY_SWASH_VARIANCE</b> = 15
	/// </summary>
	SwashVariance = 15,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_CHARACTER_RANGES</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseCharacterRanges : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_CHARACTER_RANGES_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_CHARACTER_RANGES_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_CHARACTER_RANGES_EXTENDED_COLLECTION</b> = 2
	/// </summary>
	ExtendedCollection = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_CHARACTER_RANGES_LITERALS</b> = 3
	/// </summary>
	Literals = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_CHARACTER_RANGES_NO_LOWER_CASE</b> = 4
	/// </summary>
	NoLowerCase = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_CHARACTER_RANGES_SMALL_CAPS</b> = 5
	/// </summary>
	SmallCaps = 5,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_SYMBOL_KIND</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseSymbolKind : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_MONTAGES</b> = 2
	/// </summary>
	Montages = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_PICTURES</b> = 3
	/// </summary>
	Pictures = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_SHAPES</b> = 4
	/// </summary>
	Shapes = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_SCIENTIFIC</b> = 5
	/// </summary>
	Scientific = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_MUSIC</b> = 6
	/// </summary>
	Music = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_EXPERT</b> = 7
	/// </summary>
	Expert = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_PATTERNS</b> = 8
	/// </summary>
	Patterns = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_BOARDERS</b> = 9
	/// </summary>
	Boarders = 9,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_ICONS</b> = 10
	/// </summary>
	Icons = 10,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_LOGOS</b> = 11
	/// </summary>
	Logos = 11,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_KIND_INDUSTRY_SPECIFIC</b> = 12
	/// </summary>
	IndustrySpecific = 12,
}

/// <summary>
/// ENUM <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO</b><br/>
/// DWRITE_1.h
/// </summary>
public enum PanoseSymbolAspectRatio : uint {
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_ANY</b> = 0
	/// </summary>
	Any = 0,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NO_FIT</b> = 1
	/// </summary>
	NoFit = 1,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NO_WIDTH</b> = 2
	/// </summary>
	NoWidth = 2,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_EXCEPTIONALLY_WIDE</b> = 3
	/// </summary>
	ExceptionallyWide = 3,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_SUPER_WIDE</b> = 4
	/// </summary>
	SuperWide = 4,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_VERY_WIDE</b> = 5
	/// </summary>
	VeryWide = 5,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_WIDE</b> = 6
	/// </summary>
	Wide = 6,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NORMAL</b> = 7
	/// </summary>
	Normal = 7,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NARROW</b> = 8
	/// </summary>
	Narrow = 8,
	/// <summary>
	/// <b>DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_VERY_NARROW</b> = 9
	/// </summary>
	VeryNarrow = 9,
}

/// <summary>
/// ENUM <b>DWRITE_OUTLINE_THRESHOLD</b><br/>
/// DWRITE_1.h
/// </summary>
public enum OutlineThreshold : uint {
	/// <summary>
	/// <b>DWRITE_OUTLINE_THRESHOLD_ANTIALIASED</b>
	/// </summary>
	Antialiased,
	/// <summary>
	/// <b>DWRITE_OUTLINE_THRESHOLD_ALIASED</b>
	/// </summary>
	Aliased,
}

/// <summary>
/// ENUM <b>DWRITE_BASELINE</b><br/>
/// DWRITE_1.h
/// </summary>
public enum Baseline : uint {
	/// <summary>
	/// <b>DWRITE_BASELINE_DEFAULT</b>
	/// </summary>
	Default,
	/// <summary>
	/// <b>DWRITE_BASELINE_ROMAN</b>
	/// </summary>
	Roman,
	/// <summary>
	/// <b>DWRITE_BASELINE_CENTRAL</b>
	/// </summary>
	Central,
	/// <summary>
	/// <b>DWRITE_BASELINE_MATH</b>
	/// </summary>
	Math,
	/// <summary>
	/// <b>DWRITE_BASELINE_HANGING</b>
	/// </summary>
	Hanging,
	/// <summary>
	/// <b>DWRITE_BASELINE_IDEOGRAPHIC_BOTTOM</b>
	/// </summary>
	IdeographicBottom,
	/// <summary>
	/// <b>DWRITE_BASELINE_IDEOGRAPHIC_TOP</b>
	/// </summary>
	IdeographicTop,
	/// <summary>
	/// <b>DWRITE_BASELINE_MINIMUM</b>
	/// </summary>
	Minimum,
	/// <summary>
	/// <b>DWRITE_BASELINE_MAXIMUM</b>
	/// </summary>
	Maximum,
}

/// <summary>
/// ENUM <b>DWRITE_VERTICAL_GLYPH_ORIENTATION</b><br/>
/// DWRITE_1.h
/// </summary>
public enum VerticalGlyphOrientation : uint {
	/// <summary>
	/// <b>DWRITE_VERTICAL_GLYPH_ORIENTATION_DEFAULT</b>
	/// </summary>
	Default,
	/// <summary>
	/// <b>DWRITE_VERTICAL_GLYPH_ORIENTATION_STACKED</b>
	/// </summary>
	Stacked,
}

/// <summary>
/// ENUM <b>DWRITE_GLYPH_ORIENTATION_ANGLE</b><br/>
/// DWRITE_1.h
/// </summary>
public enum GlyphOrientationAngle : uint {
	/// <summary>
	/// <b>DWRITE_GLYPH_ORIENTATION_ANGLE_0_DEGREES</b>
	/// </summary>
	Angle0Degrees,
	/// <summary>
	/// <b>DWRITE_GLYPH_ORIENTATION_ANGLE_90_DEGREES</b>
	/// </summary>
	Angle90Degrees,
	/// <summary>
	/// <b>DWRITE_GLYPH_ORIENTATION_ANGLE_180_DEGREES</b>
	/// </summary>
	Angle180Degrees,
	/// <summary>
	/// <b>DWRITE_GLYPH_ORIENTATION_ANGLE_270_DEGREES</b>
	/// </summary>
	Angle270Degrees,
}

/// <summary>
/// ENUM <b>DWRITE_TEXT_ANTIALIAS_MODE</b><br/>
/// DWRITE_1.h
/// </summary>
public enum TextAntialiasMode : uint {
	/// <summary>
	/// <b>DWRITE_TEXT_ANTIALIAS_MODE_CLEARTYPE</b>
	/// </summary>
	Cleartype,
	/// <summary>
	/// <b>DWRITE_TEXT_ANTIALIAS_MODE_GRAYSCALE</b>
	/// </summary>
	Grayscale,
}

/// <summary>
/// ENUM <b>DWRITE_OPTICAL_ALIGNMENT</b><br/>
/// DWRITE_2.h
/// </summary>
public enum OpticalAlignment : uint {
	/// <summary>
	/// <b>DWRITE_OPTICAL_ALIGNMENT_NONE</b>
	/// </summary>
	None,
	/// <summary>
	/// <b>DWRITE_OPTICAL_ALIGNMENT_NO_SIDE_BEARINGS</b>
	/// </summary>
	NoSideBearings,
}

/// <summary>
/// ENUM <b>DWRITE_GRID_FIT_MODE</b><br/>
/// DWRITE_2.h
/// </summary>
public enum GridFitMode : uint {
	/// <summary>
	/// <b>DWRITE_GRID_FIT_MODE_DEFAULT</b>
	/// </summary>
	Default,
	/// <summary>
	/// <b>DWRITE_GRID_FIT_MODE_DISABLED</b>
	/// </summary>
	Disabled,
	/// <summary>
	/// <b>DWRITE_GRID_FIT_MODE_ENABLED</b>
	/// </summary>
	Enabled,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_PROPERTY_ID</b><br/>
/// DWRITE_3.h
/// </summary>
public enum FontPropertyId : uint {
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_NONE</b>
	/// </summary>
	None,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME</b>
	/// </summary>
	WeightStretchStyleFamilyName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME</b>
	/// </summary>
	TypographicFamilyName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FACE_NAME</b>
	/// </summary>
	WeightStretchStyleFaceName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_FULL_NAME</b>
	/// </summary>
	FullName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_WIN32_FAMILY_NAME</b>
	/// </summary>
	Win32FamilyName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_POSTSCRIPT_NAME</b>
	/// </summary>
	PostscriptName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG</b>
	/// </summary>
	DesignScriptLanguageTag,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_SUPPORTED_SCRIPT_LANGUAGE_TAG</b>
	/// </summary>
	SupportedScriptLanguageTag,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_SEMANTIC_TAG</b>
	/// </summary>
	SemanticTag,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_WEIGHT</b>
	/// </summary>
	Weight,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_STRETCH</b>
	/// </summary>
	Stretch,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_STYLE</b>
	/// </summary>
	Style,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME</b>
	/// </summary>
	TypographicFaceName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_TOTAL</b> = DWRITE_FONT_PROPERTY_ID_STYLE + 1
	/// </summary>
	Total = Style + 1,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_TOTAL_RS3</b> = DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME + 1
	/// </summary>
	TotalRs3 = TypographicFaceName + 1,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_PREFERRED_FAMILY_NAME</b> = DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME
	/// </summary>
	PreferredFamilyName = TypographicFamilyName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_FAMILY_NAME</b> = DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME
	/// </summary>
	FamilyName = WeightStretchStyleFamilyName,
	/// <summary>
	/// <b>DWRITE_FONT_PROPERTY_ID_FACE_NAME</b> = DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FACE_NAME
	/// </summary>
	FaceName = WeightStretchStyleFaceName,
}

/// <summary>
/// ENUM <b>DWRITE_LOCALITY</b><br/>
/// DWRITE_3.h
/// </summary>
public enum Locality : uint {
	/// <summary>
	/// <b>DWRITE_LOCALITY_REMOTE</b>
	/// </summary>
	Remote,
	/// <summary>
	/// <b>DWRITE_LOCALITY_PARTIAL</b>
	/// </summary>
	Partial,
	/// <summary>
	/// <b>DWRITE_LOCALITY_LOCAL</b>
	/// </summary>
	Local,
}

/// <summary>
/// ENUM <b>DWRITE_RENDERING_MODE1</b><br/>
/// DWRITE_3.h
/// </summary>
public enum RenderingMode1 : uint {
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_DEFAULT</b> = DWRITE_RENDERING_MODE_DEFAULT
	/// </summary>
	Default = RenderingMode.Default,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_ALIASED</b> = DWRITE_RENDERING_MODE_ALIASED
	/// </summary>
	Aliased = RenderingMode.Aliased,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_GDI_CLASSIC</b> = DWRITE_RENDERING_MODE_GDI_CLASSIC
	/// </summary>
	GdiClassic = RenderingMode.GdiClassic,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_GDI_NATURAL</b> = DWRITE_RENDERING_MODE_GDI_NATURAL
	/// </summary>
	GdiNatural = RenderingMode.GdiNatural,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_NATURAL</b> = DWRITE_RENDERING_MODE_NATURAL
	/// </summary>
	Natural = RenderingMode.Natural,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC</b> = DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC
	/// </summary>
	NaturalSymmetric = RenderingMode.NaturalSymmetric,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_OUTLINE</b> = DWRITE_RENDERING_MODE_OUTLINE
	/// </summary>
	Outline = RenderingMode.Outline,
	/// <summary>
	/// <b>DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC_DOWNSAMPLED</b>
	/// </summary>
	NaturalSymmetricDownsampled,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_LINE_GAP_USAGE</b><br/>
/// DWRITE_3.h
/// </summary>
public enum FontLineGapUsage : uint {
	/// <summary>
	/// <b>DWRITE_FONT_LINE_GAP_USAGE_DEFAULT</b>
	/// </summary>
	Default,
	/// <summary>
	/// <b>DWRITE_FONT_LINE_GAP_USAGE_DISABLED</b>
	/// </summary>
	Disabled,
	/// <summary>
	/// <b>DWRITE_FONT_LINE_GAP_USAGE_ENABLED</b>
	/// </summary>
	Enabled,
}

/// <summary>
/// ENUM <b>DWRITE_CONTAINER_TYPE</b><br/>
/// DWRITE_3.h
/// </summary>
public enum ContainerType : uint {
	/// <summary>
	/// <b>DWRITE_CONTAINER_TYPE_UNKNOWN</b>
	/// </summary>
	Unknown,
	/// <summary>
	/// <b>DWRITE_CONTAINER_TYPE_WOFF</b>
	/// </summary>
	Woff,
	/// <summary>
	/// <b>DWRITE_CONTAINER_TYPE_WOFF2</b>
	/// </summary>
	Woff2,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_AXIS_TAG</b><br/>
/// DWRITE_3.h
/// </summary>
public enum FontAxisTag : uint {
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_TAG_WEIGHT</b> = DWRITE_MAKE_FONT_AXIS_TAG('w','g','h','t')
	/// </summary>
	Weight = 1952999287,
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_TAG_WIDTH</b> = DWRITE_MAKE_FONT_AXIS_TAG('w','d','t','h')
	/// </summary>
	Width = 1752458359,
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_TAG_SLANT</b> = DWRITE_MAKE_FONT_AXIS_TAG('s','l','n','t')
	/// </summary>
	Slant = 1953393779,
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE</b> = DWRITE_MAKE_FONT_AXIS_TAG('o','p','s','z')
	/// </summary>
	OpticalSize = 2054385775,
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_TAG_ITALIC</b> = DWRITE_MAKE_FONT_AXIS_TAG('i','t','a','l')
	/// </summary>
	Italic = 1818326121,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_FAMILY_MODEL</b><br/>
/// DWRITE_3.h
/// </summary>
public enum FontFamilyModel : uint {
	/// <summary>
	/// <b>DWRITE_FONT_FAMILY_MODEL_TYPOGRAPHIC</b>
	/// </summary>
	Typographic,
	/// <summary>
	/// <b>DWRITE_FONT_FAMILY_MODEL_WEIGHT_STRETCH_STYLE</b>
	/// </summary>
	WeightStretchStyle,
}

/// <summary>
/// ENUM <b>DWRITE_AUTOMATIC_FONT_AXES</b><br/>
/// DWRITE_3.h
/// </summary>
public enum AutomaticFontAxes : uint {
	/// <summary>
	/// <b>DWRITE_AUTOMATIC_FONT_AXES_NONE</b> = 0x0000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>DWRITE_AUTOMATIC_FONT_AXES_OPTICAL_SIZE</b> = 0x0001
	/// </summary>
	OpticalSize = 1,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_AXIS_ATTRIBUTES</b><br/>
/// DWRITE_3.h
/// </summary>
public enum FontAxisAttributes : uint {
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_ATTRIBUTES_NONE</b> = 0x0000
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_ATTRIBUTES_VARIABLE</b> = 0x0001
	/// </summary>
	Variable = 1,
	/// <summary>
	/// <b>DWRITE_FONT_AXIS_ATTRIBUTES_HIDDEN</b> = 0x0002
	/// </summary>
	Hidden = 2,
}

/// <summary>
/// ENUM <b>DWRITE_FONT_SOURCE_TYPE</b><br/>
/// DWRITE_3.h
/// </summary>
public enum FontSourceType : uint {
	/// <summary>
	/// <b>DWRITE_FONT_SOURCE_TYPE_UNKNOWN</b>
	/// </summary>
	Unknown,
	/// <summary>
	/// <b>DWRITE_FONT_SOURCE_TYPE_PER_MACHINE</b>
	/// </summary>
	PerMachine,
	/// <summary>
	/// <b>DWRITE_FONT_SOURCE_TYPE_PER_USER</b>
	/// </summary>
	PerUser,
	/// <summary>
	/// <b>DWRITE_FONT_SOURCE_TYPE_APPX_PACKAGE</b>
	/// </summary>
	AppxPackage,
	/// <summary>
	/// <b>DWRITE_FONT_SOURCE_TYPE_REMOTE_FONT_PROVIDER</b>
	/// </summary>
	RemoteFontProvider,
}
