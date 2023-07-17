using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextLayout</b> : IDWriteTextFormat<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ITextLayout : ITextFormat {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetMaxWidth (FLOAT maxWidth)</b><br/>
	/// </summary>
	/// <param name="maxWidth"><b>FLOAT maxWidth</b></param>
	int SetMaxWidth (float maxWidth);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetMaxHeight (FLOAT maxHeight)</b><br/>
	/// </summary>
	/// <param name="maxHeight"><b>FLOAT maxHeight</b></param>
	int SetMaxHeight (float maxHeight);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetFontCollection (IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="fontCollection">_In_ <b>IDWriteFontCollection* fontCollection</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetFontCollection<T0> (T0* fontCollection, TextRange textRange) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetFontFamilyName (WCHAR* fontFamilyName, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="fontFamilyName">_In_z_ <b>WCHAR* fontFamilyName</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetFontFamilyName (char* fontFamilyName, TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetFontWeight (DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="fontWeight"><b>DWRITE_FONT_WEIGHT fontWeight</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetFontWeight (FontWeight fontWeight, TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetFontStyle (DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="fontStyle"><b>DWRITE_FONT_STYLE fontStyle</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetFontStyle (FontStyle fontStyle, TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetFontStretch (DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="fontStretch"><b>DWRITE_FONT_STRETCH fontStretch</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetFontStretch (FontStretch fontStretch, TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetFontSize (FLOAT fontSize, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="fontSize"><b>FLOAT fontSize</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetFontSize (float fontSize, TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetUnderline (BOOL hasUnderline, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="hasUnderline"><b>BOOL hasUnderline</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetUnderline (bool hasUnderline, TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetStrikethrough (BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="hasStrikethrough"><b>BOOL hasStrikethrough</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetStrikethrough (bool hasStrikethrough, TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetDrawingEffect (IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="drawingEffect"><b>IUnknown* drawingEffect</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetDrawingEffect<T0> (T0* drawingEffect, TextRange textRange) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetInlineObject (IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="inlineObject">_In_ <b>IDWriteInlineObject* inlineObject</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetInlineObject<T0> (T0* inlineObject, TextRange textRange) where T0 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetTypography (IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="typography">_In_ <b>IDWriteTypography* typography</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetTypography<T0> (T0* typography, TextRange textRange) where T0 : unmanaged, ITypography;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::SetLocaleName (WCHAR* localeName, DWRITE_TEXT_RANGE textRange)</b><br/>
	/// </summary>
	/// <param name="localeName">_In_z_ <b>WCHAR* localeName</b></param>
	/// <param name="textRange"><b>DWRITE_TEXT_RANGE textRange</b></param>
	int SetLocaleName (char* localeName, TextRange textRange);
	/// <summary>
	/// STDMETHOD_ <b>FLOAT IDWriteTextLayout::GetMaxWidth ()</b><br/>
	/// </summary>
	float GetMaxWidth ();
	/// <summary>
	/// STDMETHOD_ <b>FLOAT IDWriteTextLayout::GetMaxHeight ()</b><br/>
	/// </summary>
	float GetMaxHeight ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontCollection (UINT32 currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontCollection<T0> (uint currentPosition, T0** fontCollection, TextRange* textRange) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontCollection (UINT32 currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontCollection<T0> (uint currentPosition, out T0* fontCollection, out TextRange textRange) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontFamilyNameLength (UINT32 currentPosition, UINT32* nameLength, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="nameLength">_Out_ <b>UINT32* nameLength</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontFamilyNameLength (uint currentPosition, uint* nameLength, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontFamilyNameLength (UINT32 currentPosition, UINT32* nameLength, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="nameLength">_Out_ <b>UINT32* nameLength</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontFamilyNameLength (uint currentPosition, out uint nameLength, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontFamilyName (UINT32 currentPosition, WCHAR* fontFamilyName, UINT32 nameSize, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontFamilyName">_Out_writes_z_(nameSize) <b>WCHAR* fontFamilyName</b></param>
	/// <param name="nameSize"><b>UINT32 nameSize</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontFamilyName (uint currentPosition, char* fontFamilyName, uint nameSize, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontFamilyName (UINT32 currentPosition, WCHAR* fontFamilyName, UINT32 nameSize, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontFamilyName">_Out_writes_z_(nameSize) <b>WCHAR* fontFamilyName</b></param>
	/// <param name="nameSize"><b>UINT32 nameSize</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontFamilyName (uint currentPosition, char* fontFamilyName, uint nameSize, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontWeight (UINT32 currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontWeight">_Out_ <b>DWRITE_FONT_WEIGHT* fontWeight</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontWeight (uint currentPosition, FontWeight* fontWeight, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontWeight (UINT32 currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontWeight">_Out_ <b>DWRITE_FONT_WEIGHT* fontWeight</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontWeight (uint currentPosition, out FontWeight fontWeight, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontStyle (UINT32 currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontStyle">_Out_ <b>DWRITE_FONT_STYLE* fontStyle</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontStyle (uint currentPosition, FontStyle* fontStyle, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontStyle (UINT32 currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontStyle">_Out_ <b>DWRITE_FONT_STYLE* fontStyle</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontStyle (uint currentPosition, out FontStyle fontStyle, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontStretch (UINT32 currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontStretch">_Out_ <b>DWRITE_FONT_STRETCH* fontStretch</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontStretch (uint currentPosition, FontStretch* fontStretch, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontStretch (UINT32 currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontStretch">_Out_ <b>DWRITE_FONT_STRETCH* fontStretch</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontStretch (uint currentPosition, out FontStretch fontStretch, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontSize (UINT32 currentPosition, FLOAT* fontSize, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontSize">_Out_ <b>FLOAT* fontSize</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontSize (uint currentPosition, float* fontSize, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetFontSize (UINT32 currentPosition, FLOAT* fontSize, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="fontSize">_Out_ <b>FLOAT* fontSize</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetFontSize (uint currentPosition, out float fontSize, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetUnderline (UINT32 currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="hasUnderline">_Out_ <b>BOOL* hasUnderline</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetUnderline (uint currentPosition, uint* hasUnderline, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetUnderline (UINT32 currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="hasUnderline">_Out_ <b>BOOL* hasUnderline</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetUnderline (uint currentPosition, out bool hasUnderline, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetStrikethrough (UINT32 currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="hasStrikethrough">_Out_ <b>BOOL* hasStrikethrough</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetStrikethrough (uint currentPosition, uint* hasStrikethrough, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetStrikethrough (UINT32 currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="hasStrikethrough">_Out_ <b>BOOL* hasStrikethrough</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetStrikethrough (uint currentPosition, out bool hasStrikethrough, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetDrawingEffect (UINT32 currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="drawingEffect">_COM_Outptr_ <b>IUnknown** drawingEffect</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetDrawingEffect<T0> (uint currentPosition, T0** drawingEffect, TextRange* textRange) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetDrawingEffect (UINT32 currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="drawingEffect">_COM_Outptr_ <b>IUnknown** drawingEffect</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetDrawingEffect<T0> (uint currentPosition, out T0* drawingEffect, out TextRange textRange) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetInlineObject (UINT32 currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="inlineObject">_COM_Outptr_ <b>IDWriteInlineObject** inlineObject</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetInlineObject<T0> (uint currentPosition, T0** inlineObject, TextRange* textRange) where T0 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetInlineObject (UINT32 currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="inlineObject">_COM_Outptr_ <b>IDWriteInlineObject** inlineObject</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetInlineObject<T0> (uint currentPosition, out T0* inlineObject, out TextRange textRange) where T0 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetTypography (UINT32 currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="typography">_COM_Outptr_ <b>IDWriteTypography** typography</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetTypography<T0> (uint currentPosition, T0** typography, TextRange* textRange) where T0 : unmanaged, ITypography;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetTypography (UINT32 currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="typography">_COM_Outptr_ <b>IDWriteTypography** typography</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetTypography<T0> (uint currentPosition, out T0* typography, out TextRange textRange) where T0 : unmanaged, ITypography;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetLocaleNameLength (UINT32 currentPosition, UINT32* nameLength, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="nameLength">_Out_ <b>UINT32* nameLength</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetLocaleNameLength (uint currentPosition, uint* nameLength, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetLocaleNameLength (UINT32 currentPosition, UINT32* nameLength, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="nameLength">_Out_ <b>UINT32* nameLength</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetLocaleNameLength (uint currentPosition, out uint nameLength, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetLocaleName (UINT32 currentPosition, WCHAR* localeName, UINT32 nameSize, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="localeName">_Out_writes_z_(nameSize) <b>WCHAR* localeName</b></param>
	/// <param name="nameSize"><b>UINT32 nameSize</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetLocaleName (uint currentPosition, char* localeName, uint nameSize, TextRange* textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetLocaleName (UINT32 currentPosition, WCHAR* localeName, UINT32 nameSize, DWRITE_TEXT_RANGE* textRange)</b><br/>
	/// </summary>
	/// <param name="currentPosition"><b>UINT32 currentPosition</b></param>
	/// <param name="localeName">_Out_writes_z_(nameSize) <b>WCHAR* localeName</b></param>
	/// <param name="nameSize"><b>UINT32 nameSize</b></param>
	/// <param name="textRange">_Out_opt_ <b>DWRITE_TEXT_RANGE* textRange</b></param>
	int GetLocaleName (uint currentPosition, char* localeName, uint nameSize, out TextRange textRange);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::Draw (void* clientDrawingContext, IDWriteTextRenderer* renderer, FLOAT originX, FLOAT originY)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="renderer">_In_ <b>IDWriteTextRenderer* renderer</b></param>
	/// <param name="originX"><b>FLOAT originX</b></param>
	/// <param name="originY"><b>FLOAT originY</b></param>
	int Draw<T0> (void* clientDrawingContext, T0* renderer, float originX, float originY) where T0 : unmanaged, ITextRenderer;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetLineMetrics (DWRITE_LINE_METRICS* lineMetrics, UINT32 maxLineCount, UINT32* actualLineCount)</b><br/>
	/// </summary>
	/// <param name="lineMetrics">_Out_writes_opt_(maxLineCount) <b>DWRITE_LINE_METRICS* lineMetrics</b></param>
	/// <param name="maxLineCount"><b>UINT32 maxLineCount</b></param>
	/// <param name="actualLineCount">_Out_ <b>UINT32* actualLineCount</b></param>
	int GetLineMetrics (LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetLineMetrics (DWRITE_LINE_METRICS* lineMetrics, UINT32 maxLineCount, UINT32* actualLineCount)</b><br/>
	/// </summary>
	/// <param name="lineMetrics">_Out_writes_opt_(maxLineCount) <b>DWRITE_LINE_METRICS* lineMetrics</b></param>
	/// <param name="maxLineCount"><b>UINT32 maxLineCount</b></param>
	/// <param name="actualLineCount">_Out_ <b>UINT32* actualLineCount</b></param>
	int GetLineMetrics (LineMetrics* lineMetrics, uint maxLineCount, out uint actualLineCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetMetrics (DWRITE_TEXT_METRICS* textMetrics)</b><br/>
	/// </summary>
	/// <param name="textMetrics">_Out_ <b>DWRITE_TEXT_METRICS* textMetrics</b></param>
	int GetMetrics (TextMetrics* textMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetMetrics (DWRITE_TEXT_METRICS* textMetrics)</b><br/>
	/// </summary>
	/// <param name="textMetrics">_Out_ <b>DWRITE_TEXT_METRICS* textMetrics</b></param>
	int GetMetrics (out TextMetrics textMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetOverhangMetrics (DWRITE_OVERHANG_METRICS* overhangs)</b><br/>
	/// </summary>
	/// <param name="overhangs">_Out_ <b>DWRITE_OVERHANG_METRICS* overhangs</b></param>
	int GetOverhangMetrics (OverhangMetrics* overhangs);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetOverhangMetrics (DWRITE_OVERHANG_METRICS* overhangs)</b><br/>
	/// </summary>
	/// <param name="overhangs">_Out_ <b>DWRITE_OVERHANG_METRICS* overhangs</b></param>
	int GetOverhangMetrics (out OverhangMetrics overhangs);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetClusterMetrics (DWRITE_CLUSTER_METRICS* clusterMetrics, UINT32 maxClusterCount, UINT32* actualClusterCount)</b><br/>
	/// </summary>
	/// <param name="clusterMetrics">_Out_writes_opt_(maxClusterCount) <b>DWRITE_CLUSTER_METRICS* clusterMetrics</b></param>
	/// <param name="maxClusterCount"><b>UINT32 maxClusterCount</b></param>
	/// <param name="actualClusterCount">_Out_ <b>UINT32* actualClusterCount</b></param>
	int GetClusterMetrics (ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::GetClusterMetrics (DWRITE_CLUSTER_METRICS* clusterMetrics, UINT32 maxClusterCount, UINT32* actualClusterCount)</b><br/>
	/// </summary>
	/// <param name="clusterMetrics">_Out_writes_opt_(maxClusterCount) <b>DWRITE_CLUSTER_METRICS* clusterMetrics</b></param>
	/// <param name="maxClusterCount"><b>UINT32 maxClusterCount</b></param>
	/// <param name="actualClusterCount">_Out_ <b>UINT32* actualClusterCount</b></param>
	int GetClusterMetrics (ClusterMetrics* clusterMetrics, uint maxClusterCount, out uint actualClusterCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::DetermineMinWidth (FLOAT* minWidth)</b><br/>
	/// </summary>
	/// <param name="minWidth">_Out_ <b>FLOAT* minWidth</b></param>
	int DetermineMinWidth (float* minWidth);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::DetermineMinWidth (FLOAT* minWidth)</b><br/>
	/// </summary>
	/// <param name="minWidth">_Out_ <b>FLOAT* minWidth</b></param>
	int DetermineMinWidth (out float minWidth);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::HitTestPoint (FLOAT pointX, FLOAT pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)</b><br/>
	/// </summary>
	/// <param name="pointX"><b>FLOAT pointX</b></param>
	/// <param name="pointY"><b>FLOAT pointY</b></param>
	/// <param name="isTrailingHit">_Out_ <b>BOOL* isTrailingHit</b></param>
	/// <param name="isInside">_Out_ <b>BOOL* isInside</b></param>
	/// <param name="hitTestMetrics">_Out_ <b>DWRITE_HIT_TEST_METRICS* hitTestMetrics</b></param>
	int HitTestPoint (float pointX, float pointY, uint* isTrailingHit, uint* isInside, HitTestMetrics* hitTestMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::HitTestPoint (FLOAT pointX, FLOAT pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)</b><br/>
	/// </summary>
	/// <param name="pointX"><b>FLOAT pointX</b></param>
	/// <param name="pointY"><b>FLOAT pointY</b></param>
	/// <param name="isTrailingHit">_Out_ <b>BOOL* isTrailingHit</b></param>
	/// <param name="isInside">_Out_ <b>BOOL* isInside</b></param>
	/// <param name="hitTestMetrics">_Out_ <b>DWRITE_HIT_TEST_METRICS* hitTestMetrics</b></param>
	int HitTestPoint (float pointX, float pointY, out bool isTrailingHit, out bool isInside, out HitTestMetrics hitTestMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::HitTestTextPosition (UINT32 textPosition, BOOL isTrailingHit, FLOAT* pointX, FLOAT* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="isTrailingHit"><b>BOOL isTrailingHit</b></param>
	/// <param name="pointX">_Out_ <b>FLOAT* pointX</b></param>
	/// <param name="pointY">_Out_ <b>FLOAT* pointY</b></param>
	/// <param name="hitTestMetrics">_Out_ <b>DWRITE_HIT_TEST_METRICS* hitTestMetrics</b></param>
	int HitTestTextPosition (uint textPosition, bool isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::HitTestTextPosition (UINT32 textPosition, BOOL isTrailingHit, FLOAT* pointX, FLOAT* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="isTrailingHit"><b>BOOL isTrailingHit</b></param>
	/// <param name="pointX">_Out_ <b>FLOAT* pointX</b></param>
	/// <param name="pointY">_Out_ <b>FLOAT* pointY</b></param>
	/// <param name="hitTestMetrics">_Out_ <b>DWRITE_HIT_TEST_METRICS* hitTestMetrics</b></param>
	int HitTestTextPosition (uint textPosition, bool isTrailingHit, out float pointX, out float pointY, out HitTestMetrics hitTestMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::HitTestTextRange (UINT32 textPosition, UINT32 textLength, FLOAT originX, FLOAT originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, UINT32 maxHitTestMetricsCount, UINT32* actualHitTestMetricsCount)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="originX"><b>FLOAT originX</b></param>
	/// <param name="originY"><b>FLOAT originY</b></param>
	/// <param name="hitTestMetrics">_Out_writes_opt_(maxHitTestMetricsCount) <b>DWRITE_HIT_TEST_METRICS* hitTestMetrics</b></param>
	/// <param name="maxHitTestMetricsCount"><b>UINT32 maxHitTestMetricsCount</b></param>
	/// <param name="actualHitTestMetricsCount">_Out_ <b>UINT32* actualHitTestMetricsCount</b></param>
	int HitTestTextRange (uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextLayout::HitTestTextRange (UINT32 textPosition, UINT32 textLength, FLOAT originX, FLOAT originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, UINT32 maxHitTestMetricsCount, UINT32* actualHitTestMetricsCount)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="originX"><b>FLOAT originX</b></param>
	/// <param name="originY"><b>FLOAT originY</b></param>
	/// <param name="hitTestMetrics">_Out_writes_opt_(maxHitTestMetricsCount) <b>DWRITE_HIT_TEST_METRICS* hitTestMetrics</b></param>
	/// <param name="maxHitTestMetricsCount"><b>UINT32 maxHitTestMetricsCount</b></param>
	/// <param name="actualHitTestMetricsCount">_Out_ <b>UINT32* actualHitTestMetricsCount</b></param>
	int HitTestTextRange (uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, out uint actualHitTestMetricsCount);
}

/// <summary>
/// Instance of <b>IDWriteTextLayout</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct TextLayout : ITextLayout {
//unsafe public readonly struct ITextLayoutObj : ITextLayout {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextLayout* GetCurrentPointer () => (TextLayout*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextLayoutObj* GetCurrentPointer () => (ITextLayoutObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x53737037, 0x6d14, 0x410b, 0x9b, 0xfe, 0x0b, 0x18, 0x2b, 0xb7, 0x09, 0x61);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
