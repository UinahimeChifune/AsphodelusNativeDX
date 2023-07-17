using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextLayout2</b> : IDWriteTextLayout1<br/>
/// DWRITE_2.h
/// </summary>
unsafe public interface ITextLayout2 : ITextLayout1 {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::GetMetrics (DWRITE_TEXT_METRICS1* textMetrics)</b><br/>
	/// </summary>
	/// <param name="textMetrics">_Out_ <b>DWRITE_TEXT_METRICS1* textMetrics</b></param>
	int GetMetrics (TextMetrics1* textMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::GetMetrics (DWRITE_TEXT_METRICS1* textMetrics)</b><br/>
	/// </summary>
	/// <param name="textMetrics">_Out_ <b>DWRITE_TEXT_METRICS1* textMetrics</b></param>
	int GetMetrics (out TextMetrics1 textMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::SetVerticalGlyphOrientation (DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)</b><br/>
	/// </summary>
	/// <param name="glyphOrientation"><b>DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation</b></param>
	int SetVerticalGlyphOrientation (VerticalGlyphOrientation glyphOrientation);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_VERTICAL_GLYPH_ORIENTATION IDWriteTextLayout2::GetVerticalGlyphOrientation ()</b><br/>
	/// </summary>
	VerticalGlyphOrientation GetVerticalGlyphOrientation ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::SetLastLineWrapping (BOOL isLastLineWrappingEnabled)</b><br/>
	/// </summary>
	/// <param name="isLastLineWrappingEnabled"><b>BOOL isLastLineWrappingEnabled</b></param>
	int SetLastLineWrapping (bool isLastLineWrappingEnabled);
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteTextLayout2::GetLastLineWrapping ()</b><br/>
	/// </summary>
	bool GetLastLineWrapping ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::SetOpticalAlignment (DWRITE_OPTICAL_ALIGNMENT opticalAlignment)</b><br/>
	/// </summary>
	/// <param name="opticalAlignment"><b>DWRITE_OPTICAL_ALIGNMENT opticalAlignment</b></param>
	int SetOpticalAlignment (OpticalAlignment opticalAlignment);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_OPTICAL_ALIGNMENT IDWriteTextLayout2::GetOpticalAlignment ()</b><br/>
	/// </summary>
	OpticalAlignment GetOpticalAlignment ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::SetFontFallback (IDWriteFontFallback* fontFallback)</b><br/>
	/// </summary>
	/// <param name="fontFallback"><b>IDWriteFontFallback* fontFallback</b></param>
	int SetFontFallback<T0> (T0* fontFallback) where T0 : unmanaged, IFontFallback;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::GetFontFallback (IDWriteFontFallback** fontFallback)</b><br/>
	/// </summary>
	/// <param name="fontFallback">__out <b>IDWriteFontFallback** fontFallback</b></param>
	int GetFontFallback<T0> (T0** fontFallback) where T0 : unmanaged, IFontFallback;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout2::GetFontFallback (IDWriteFontFallback** fontFallback)</b><br/>
	/// </summary>
	/// <param name="fontFallback">__out <b>IDWriteFontFallback** fontFallback</b></param>
	int GetFontFallback<T0> (out T0* fontFallback) where T0 : unmanaged, IFontFallback;
}

/// <summary>
/// Instance of <b>IDWriteTextLayout2</b><br/>
/// DWRITE_2.h
/// </summary>
unsafe public readonly struct TextLayout2 : ITextLayout2 {
//unsafe public readonly struct ITextLayout2Obj : ITextLayout2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextLayout2* GetCurrentPointer () => (TextLayout2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextLayout2Obj* GetCurrentPointer () => (ITextLayout2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1093c18f, 0x8d5e, 0x43f0, 0xb0, 0x64, 0x09, 0x17, 0x31, 0x1b, 0x52, 0x5e);

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
	public readonly int SetTextAlignment (TextAlignment textAlignment) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTextAlignment (ptr, textAlignment);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetParagraphAlignment (ParagraphAlignment paragraphAlignment) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetParagraphAlignment (ptr, paragraphAlignment);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetWordWrapping (WordWrapping wordWrapping) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetWordWrapping (ptr, wordWrapping);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetReadingDirection (ReadingDirection readingDirection) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetReadingDirection (ptr, readingDirection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFlowDirection (FlowDirection flowDirection) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFlowDirection (ptr, flowDirection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetIncrementalTabStop (float incrementalTabStop) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetIncrementalTabStop (ptr, incrementalTabStop);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTrimming<T0> (Trimming* trimmingOptions, T0* trimmingSign) where T0 : unmanaged, IInlineObject {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTrimming (ptr, trimmingOptions, trimmingSign);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetLineSpacing (LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetLineSpacing (ptr, lineSpacingMethod, lineSpacing, baseline);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly TextAlignment GetTextAlignment () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextAlignment (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ParagraphAlignment GetParagraphAlignment () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetParagraphAlignment (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly WordWrapping GetWordWrapping () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetWordWrapping (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ReadingDirection GetReadingDirection () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetReadingDirection (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FlowDirection GetFlowDirection () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFlowDirection (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetIncrementalTabStop () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetIncrementalTabStop (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTrimming<T0> (Trimming* trimmingOptions, T0** trimmingSign) where T0 : unmanaged, IInlineObject {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTrimming (ptr, trimmingOptions, (void**) trimmingSign);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTrimming<T0> (out Trimming trimmingOptions, out T0* trimmingSign) where T0 : unmanaged, IInlineObject {
		fixed (Trimming* _trimmingOptions = &trimmingOptions) {
			fixed (T0** _trimmingSign = &trimmingSign) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetTrimming (ptr, _trimmingOptions, (void**) _trimmingSign);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLineSpacing (LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLineSpacing (ptr, lineSpacingMethod, lineSpacing, baseline);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLineSpacing (out LineSpacingMethod lineSpacingMethod, out float lineSpacing, out float baseline) {
		fixed (LineSpacingMethod* _lineSpacingMethod = &lineSpacingMethod) {
			fixed (float* _lineSpacing = &lineSpacing) {
				fixed (float* _baseline = &baseline) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->GetLineSpacing (ptr, _lineSpacingMethod, _lineSpacing, _baseline);
					return hr;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontCollection<T0> (T0** fontCollection) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontCollection (ptr, (void**) fontCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontCollection<T0> (out T0* fontCollection) where T0 : unmanaged, IFontCollection {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontCollection (ptr, (void**) _fontCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontFamilyNameLength () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamilyNameLength (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamilyName (char* fontFamilyName, uint nameSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamilyName (ptr, fontFamilyName, nameSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontWeight GetFontWeight () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontWeight (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontStyle GetFontStyle () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontStyle (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontStretch GetFontStretch () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontStretch (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetFontSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetLocaleNameLength () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleNameLength (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleName (char* localeName, uint nameSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleName (ptr, localeName, nameSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetMaxWidth (float maxWidth) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetMaxWidth (ptr, maxWidth);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetMaxHeight (float maxHeight) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetMaxHeight (ptr, maxHeight);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontCollection<T0> (T0* fontCollection, TextRange textRange) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontCollection (ptr, fontCollection, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontFamilyName (char* fontFamilyName, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontFamilyName (ptr, fontFamilyName, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontWeight (FontWeight fontWeight, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontWeight (ptr, fontWeight, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontStyle (FontStyle fontStyle, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontStyle (ptr, fontStyle, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontStretch (FontStretch fontStretch, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontStretch (ptr, fontStretch, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontSize (float fontSize, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontSize (ptr, fontSize, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetUnderline (bool hasUnderline, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetUnderline (ptr, hasUnderline ? 1U : 0U, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetStrikethrough (bool hasStrikethrough, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetStrikethrough (ptr, hasStrikethrough ? 1U : 0U, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetDrawingEffect<T0> (T0* drawingEffect, TextRange textRange) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetDrawingEffect (ptr, drawingEffect, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetInlineObject<T0> (T0* inlineObject, TextRange textRange) where T0 : unmanaged, IInlineObject {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetInlineObject (ptr, inlineObject, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTypography<T0> (T0* typography, TextRange textRange) where T0 : unmanaged, ITypography {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTypography (ptr, typography, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetLocaleName (char* localeName, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetLocaleName (ptr, localeName, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetMaxWidth () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMaxWidth (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetMaxHeight () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMaxHeight (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontCollection<T0> (uint currentPosition, T0** fontCollection, TextRange* textRange) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontCollection (ptr, currentPosition, (void**) fontCollection, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontCollection<T0> (uint currentPosition, out T0* fontCollection, out TextRange textRange) where T0 : unmanaged, IFontCollection {
		fixed (T0** _fontCollection = &fontCollection) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontCollection (ptr, currentPosition, (void**) _fontCollection, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamilyNameLength (uint currentPosition, uint* nameLength, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontFamilyNameLength (ptr, currentPosition, nameLength, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamilyNameLength (uint currentPosition, out uint nameLength, out TextRange textRange) {
		fixed (uint* _nameLength = &nameLength) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontFamilyNameLength (ptr, currentPosition, _nameLength, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamilyName (uint currentPosition, char* fontFamilyName, uint nameSize, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontFamilyName (ptr, currentPosition, fontFamilyName, nameSize, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamilyName (uint currentPosition, char* fontFamilyName, uint nameSize, out TextRange textRange) {
		fixed (TextRange* _textRange = &textRange) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontFamilyName (ptr, currentPosition, fontFamilyName, nameSize, _textRange);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontWeight (uint currentPosition, FontWeight* fontWeight, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontWeight (ptr, currentPosition, fontWeight, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontWeight (uint currentPosition, out FontWeight fontWeight, out TextRange textRange) {
		fixed (FontWeight* _fontWeight = &fontWeight) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontWeight (ptr, currentPosition, _fontWeight, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontStyle (uint currentPosition, FontStyle* fontStyle, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontStyle (ptr, currentPosition, fontStyle, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontStyle (uint currentPosition, out FontStyle fontStyle, out TextRange textRange) {
		fixed (FontStyle* _fontStyle = &fontStyle) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontStyle (ptr, currentPosition, _fontStyle, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontStretch (uint currentPosition, FontStretch* fontStretch, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontStretch (ptr, currentPosition, fontStretch, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontStretch (uint currentPosition, out FontStretch fontStretch, out TextRange textRange) {
		fixed (FontStretch* _fontStretch = &fontStretch) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontStretch (ptr, currentPosition, _fontStretch, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSize (uint currentPosition, float* fontSize, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontSize (ptr, currentPosition, fontSize, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSize (uint currentPosition, out float fontSize, out TextRange textRange) {
		fixed (float* _fontSize = &fontSize) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontSize (ptr, currentPosition, _fontSize, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetUnderline (uint currentPosition, uint* hasUnderline, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetUnderline (ptr, currentPosition, hasUnderline, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetUnderline (uint currentPosition, out bool hasUnderline, out TextRange textRange) {
		uint _hasUnderline;
		fixed (TextRange* _textRange = &textRange) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetUnderline (ptr, currentPosition, &_hasUnderline, _textRange);
			hasUnderline = _hasUnderline != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStrikethrough (uint currentPosition, uint* hasStrikethrough, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStrikethrough (ptr, currentPosition, hasStrikethrough, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStrikethrough (uint currentPosition, out bool hasStrikethrough, out TextRange textRange) {
		uint _hasStrikethrough;
		fixed (TextRange* _textRange = &textRange) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetStrikethrough (ptr, currentPosition, &_hasStrikethrough, _textRange);
			hasStrikethrough = _hasStrikethrough != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDrawingEffect<T0> (uint currentPosition, T0** drawingEffect, TextRange* textRange) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDrawingEffect (ptr, currentPosition, (void**) drawingEffect, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDrawingEffect<T0> (uint currentPosition, out T0* drawingEffect, out TextRange textRange) where T0 : unmanaged, IUnknown {
		fixed (T0** _drawingEffect = &drawingEffect) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetDrawingEffect (ptr, currentPosition, (void**) _drawingEffect, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetInlineObject<T0> (uint currentPosition, T0** inlineObject, TextRange* textRange) where T0 : unmanaged, IInlineObject {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInlineObject (ptr, currentPosition, (void**) inlineObject, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetInlineObject<T0> (uint currentPosition, out T0* inlineObject, out TextRange textRange) where T0 : unmanaged, IInlineObject {
		fixed (T0** _inlineObject = &inlineObject) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetInlineObject (ptr, currentPosition, (void**) _inlineObject, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTypography<T0> (uint currentPosition, T0** typography, TextRange* textRange) where T0 : unmanaged, ITypography {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTypography (ptr, currentPosition, (void**) typography, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTypography<T0> (uint currentPosition, out T0* typography, out TextRange textRange) where T0 : unmanaged, ITypography {
		fixed (T0** _typography = &typography) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetTypography (ptr, currentPosition, (void**) _typography, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleNameLength (uint currentPosition, uint* nameLength, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetLocaleNameLength (ptr, currentPosition, nameLength, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleNameLength (uint currentPosition, out uint nameLength, out TextRange textRange) {
		fixed (uint* _nameLength = &nameLength) {
			fixed (TextRange* _textRange = &textRange) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->_GetLocaleNameLength (ptr, currentPosition, _nameLength, _textRange);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleName (uint currentPosition, char* localeName, uint nameSize, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetLocaleName (ptr, currentPosition, localeName, nameSize, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleName (uint currentPosition, char* localeName, uint nameSize, out TextRange textRange) {
		fixed (TextRange* _textRange = &textRange) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetLocaleName (ptr, currentPosition, localeName, nameSize, _textRange);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Draw<T0> (void* clientDrawingContext, T0* renderer, float originX, float originY) where T0 : unmanaged, ITextRenderer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Draw (ptr, clientDrawingContext, renderer, originX, originY);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLineMetrics (LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLineMetrics (ptr, lineMetrics, maxLineCount, actualLineCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLineMetrics (LineMetrics* lineMetrics, uint maxLineCount, out uint actualLineCount) {
		fixed (uint* _actualLineCount = &actualLineCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLineMetrics (ptr, lineMetrics, maxLineCount, _actualLineCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetrics (TextMetrics* textMetrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, textMetrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetrics (out TextMetrics textMetrics) {
		fixed (TextMetrics* _textMetrics = &textMetrics) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, _textMetrics);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetOverhangMetrics (OverhangMetrics* overhangs) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetOverhangMetrics (ptr, overhangs);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetOverhangMetrics (out OverhangMetrics overhangs) {
		fixed (OverhangMetrics* _overhangs = &overhangs) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetOverhangMetrics (ptr, _overhangs);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClusterMetrics (ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetClusterMetrics (ptr, clusterMetrics, maxClusterCount, actualClusterCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClusterMetrics (ClusterMetrics* clusterMetrics, uint maxClusterCount, out uint actualClusterCount) {
		fixed (uint* _actualClusterCount = &actualClusterCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetClusterMetrics (ptr, clusterMetrics, maxClusterCount, _actualClusterCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DetermineMinWidth (float* minWidth) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DetermineMinWidth (ptr, minWidth);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DetermineMinWidth (out float minWidth) {
		fixed (float* _minWidth = &minWidth) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->DetermineMinWidth (ptr, _minWidth);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HitTestPoint (float pointX, float pointY, uint* isTrailingHit, uint* isInside, HitTestMetrics* hitTestMetrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HitTestPoint (ptr, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HitTestPoint (float pointX, float pointY, out bool isTrailingHit, out bool isInside, out HitTestMetrics hitTestMetrics) {
		uint _isTrailingHit;
		uint _isInside;
		fixed (HitTestMetrics* _hitTestMetrics = &hitTestMetrics) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->HitTestPoint (ptr, pointX, pointY, &_isTrailingHit, &_isInside, _hitTestMetrics);
			isInside = _isInside != 0;
			isTrailingHit = _isTrailingHit != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HitTestTextPosition (uint textPosition, bool isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HitTestTextPosition (ptr, textPosition, isTrailingHit ? 1U : 0U, pointX, pointY, hitTestMetrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HitTestTextPosition (uint textPosition, bool isTrailingHit, out float pointX, out float pointY, out HitTestMetrics hitTestMetrics) {
		fixed (float* _pointX = &pointX) {
			fixed (float* _pointY = &pointY) {
				fixed (HitTestMetrics* _hitTestMetrics = &hitTestMetrics) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->HitTestTextPosition (ptr, textPosition, isTrailingHit ? 1U : 0U, _pointX, _pointY, _hitTestMetrics);
					return hr;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HitTestTextRange (uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HitTestTextRange (ptr, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HitTestTextRange (uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, out uint actualHitTestMetricsCount) {
		fixed (uint* _actualHitTestMetricsCount = &actualHitTestMetricsCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->HitTestTextRange (ptr, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, _actualHitTestMetricsCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPairKerning (bool isPairKerningEnabled, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPairKerning (ptr, isPairKerningEnabled ? 1U : 0U, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPairKerning (uint currentPosition, uint* isPairKerningEnabled, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPairKerning (ptr, currentPosition, isPairKerningEnabled, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPairKerning (uint currentPosition, out bool isPairKerningEnabled, out TextRange textRange) {
		uint _isPairKerningEnabled;
		fixed (TextRange* _textRange = &textRange) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPairKerning (ptr, currentPosition, &_isPairKerningEnabled, _textRange);
			isPairKerningEnabled = _isPairKerningEnabled != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetCharacterSpacing (float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, TextRange textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetCharacterSpacing (ptr, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCharacterSpacing (uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCharacterSpacing (ptr, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCharacterSpacing (uint currentPosition, out float leadingSpacing, out float trailingSpacing, out float minimumAdvanceWidth, out TextRange textRange) {
		fixed (float* _leadingSpacing = &leadingSpacing) {
			fixed (float* _trailingSpacing = &trailingSpacing) {
				fixed (float* _minimumAdvanceWidth = &minimumAdvanceWidth) {
					fixed (TextRange* _textRange = &textRange) {
						var ptr = GetCurrentPointer ();
						var hr = ((FunctionPointer*) ptr->_pointer)->GetCharacterSpacing (ptr, currentPosition, _leadingSpacing, _trailingSpacing, _minimumAdvanceWidth, _textRange);
						return hr;
					}
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetrics (TextMetrics1* textMetrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetrics1 (ptr, textMetrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetrics (out TextMetrics1 textMetrics) {
		fixed (TextMetrics1* _textMetrics = &textMetrics) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetrics1 (ptr, _textMetrics);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetVerticalGlyphOrientation (VerticalGlyphOrientation glyphOrientation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetVerticalGlyphOrientation (ptr, glyphOrientation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly VerticalGlyphOrientation GetVerticalGlyphOrientation () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVerticalGlyphOrientation (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetLastLineWrapping (bool isLastLineWrappingEnabled) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetLastLineWrapping (ptr, isLastLineWrappingEnabled ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetLastLineWrapping () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLastLineWrapping (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetOpticalAlignment (OpticalAlignment opticalAlignment) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetOpticalAlignment (ptr, opticalAlignment);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly OpticalAlignment GetOpticalAlignment () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetOpticalAlignment (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontFallback<T0> (T0* fontFallback) where T0 : unmanaged, IFontFallback {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontFallback (ptr, fontFallback);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFallback<T0> (T0** fontFallback) where T0 : unmanaged, IFontFallback {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFallback (ptr, (void**) fontFallback);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFallback<T0> (out T0* fontFallback) where T0 : unmanaged, IFontFallback {
		fixed (T0** _fontFallback = &fontFallback) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFallback (ptr, (void**) _fontFallback);
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
		public readonly delegate* unmanaged[Stdcall]<void*, TextAlignment, int> SetTextAlignment;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ParagraphAlignment, int> SetParagraphAlignment;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, WordWrapping, int> SetWordWrapping;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ReadingDirection, int> SetReadingDirection;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FlowDirection, int> SetFlowDirection;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, int> SetIncrementalTabStop;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Trimming*, void*, int> SetTrimming;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LineSpacingMethod, float, float, int> SetLineSpacing;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextAlignment> GetTextAlignment;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ParagraphAlignment> GetParagraphAlignment;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, WordWrapping> GetWordWrapping;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ReadingDirection> GetReadingDirection;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FlowDirection> GetFlowDirection;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetIncrementalTabStop;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Trimming*, void**, int> GetTrimming;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LineSpacingMethod*, float*, float*, int> GetLineSpacing;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontCollection;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontFamilyNameLength;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> GetFontFamilyName;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontWeight> GetFontWeight;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStyle> GetFontStyle;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStretch> GetFontStretch;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetFontSize;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetLocaleNameLength;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> GetLocaleName;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, int> SetMaxWidth;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, int> SetMaxHeight;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TextRange, int> SetFontCollection;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, TextRange, int> SetFontFamilyName;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontWeight, TextRange, int> SetFontWeight;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStyle, TextRange, int> SetFontStyle;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontStretch, TextRange, int> SetFontStretch;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, TextRange, int> SetFontSize;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, TextRange, int> SetUnderline;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, TextRange, int> SetStrikethrough;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TextRange, int> SetDrawingEffect;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TextRange, int> SetInlineObject;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, TextRange, int> SetTypography;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, TextRange, int> SetLocaleName;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetMaxWidth;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetMaxHeight;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, TextRange*, int> _GetFontCollection;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, TextRange*, int> _GetFontFamilyNameLength;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, TextRange*, int> _GetFontFamilyName;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontWeight*, TextRange*, int> _GetFontWeight;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontStyle*, TextRange*, int> _GetFontStyle;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontStretch*, TextRange*, int> _GetFontStretch;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, float*, TextRange*, int> _GetFontSize;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, TextRange*, int> GetUnderline;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, TextRange*, int> GetStrikethrough;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, TextRange*, int> GetDrawingEffect;
		/// <summary>
		/// OFFSET 54
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, TextRange*, int> GetInlineObject;
		/// <summary>
		/// OFFSET 55
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, TextRange*, int> GetTypography;
		/// <summary>
		/// OFFSET 56
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, TextRange*, int> _GetLocaleNameLength;
		/// <summary>
		/// OFFSET 57
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, TextRange*, int> _GetLocaleName;
		/// <summary>
		/// OFFSET 58
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, float, float, int> Draw;
		/// <summary>
		/// OFFSET 59
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LineMetrics*, uint, uint*, int> GetLineMetrics;
		/// <summary>
		/// OFFSET 60
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextMetrics*, int> GetMetrics;
		/// <summary>
		/// OFFSET 61
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OverhangMetrics*, int> GetOverhangMetrics;
		/// <summary>
		/// OFFSET 62
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ClusterMetrics*, uint, uint*, int> GetClusterMetrics;
		/// <summary>
		/// OFFSET 63
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, int> DetermineMinWidth;
		/// <summary>
		/// OFFSET 64
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, uint*, uint*, HitTestMetrics*, int> HitTestPoint;
		/// <summary>
		/// OFFSET 65
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, float*, float*, HitTestMetrics*, int> HitTestTextPosition;
		/// <summary>
		/// OFFSET 66
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int> HitTestTextRange;
		/// <summary>
		/// OFFSET 67
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, TextRange, int> SetPairKerning;
		/// <summary>
		/// OFFSET 68
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, TextRange*, int> GetPairKerning;
		/// <summary>
		/// OFFSET 69
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, TextRange, int> SetCharacterSpacing;
		/// <summary>
		/// OFFSET 70
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, float*, float*, float*, TextRange*, int> GetCharacterSpacing;
		/// <summary>
		/// OFFSET 71
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextMetrics1*, int> GetMetrics1;
		/// <summary>
		/// OFFSET 72
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VerticalGlyphOrientation, int> SetVerticalGlyphOrientation;
		/// <summary>
		/// OFFSET 73
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VerticalGlyphOrientation> GetVerticalGlyphOrientation;
		/// <summary>
		/// OFFSET 74
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetLastLineWrapping;
		/// <summary>
		/// OFFSET 75
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetLastLineWrapping;
		/// <summary>
		/// OFFSET 76
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OpticalAlignment, int> SetOpticalAlignment;
		/// <summary>
		/// OFFSET 77
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OpticalAlignment> GetOpticalAlignment;
		/// <summary>
		/// OFFSET 78
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetFontFallback;
		/// <summary>
		/// OFFSET 79
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontFallback;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
