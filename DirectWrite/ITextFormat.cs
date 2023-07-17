using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextFormat</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ITextFormat : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetTextAlignment (DWRITE_TEXT_ALIGNMENT textAlignment)</b><br/>
	/// </summary>
	/// <param name="textAlignment"><b>DWRITE_TEXT_ALIGNMENT textAlignment</b></param>
	int SetTextAlignment (TextAlignment textAlignment);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetParagraphAlignment (DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)</b><br/>
	/// </summary>
	/// <param name="paragraphAlignment"><b>DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment</b></param>
	int SetParagraphAlignment (ParagraphAlignment paragraphAlignment);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetWordWrapping (DWRITE_WORD_WRAPPING wordWrapping)</b><br/>
	/// </summary>
	/// <param name="wordWrapping"><b>DWRITE_WORD_WRAPPING wordWrapping</b></param>
	int SetWordWrapping (WordWrapping wordWrapping);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetReadingDirection (DWRITE_READING_DIRECTION readingDirection)</b><br/>
	/// </summary>
	/// <param name="readingDirection"><b>DWRITE_READING_DIRECTION readingDirection</b></param>
	int SetReadingDirection (ReadingDirection readingDirection);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetFlowDirection (DWRITE_FLOW_DIRECTION flowDirection)</b><br/>
	/// </summary>
	/// <param name="flowDirection"><b>DWRITE_FLOW_DIRECTION flowDirection</b></param>
	int SetFlowDirection (FlowDirection flowDirection);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetIncrementalTabStop (FLOAT incrementalTabStop)</b><br/>
	/// </summary>
	/// <param name="incrementalTabStop"><b>FLOAT incrementalTabStop</b></param>
	int SetIncrementalTabStop (float incrementalTabStop);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetTrimming (DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)</b><br/>
	/// </summary>
	/// <param name="trimmingOptions">_In_ <b>DWRITE_TRIMMING* trimmingOptions</b></param>
	/// <param name="trimmingSign">_In_opt_ <b>IDWriteInlineObject* trimmingSign</b></param>
	int SetTrimming<T0> (Trimming* trimmingOptions, T0* trimmingSign) where T0 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::SetLineSpacing (DWRITE_LINE_SPACING_METHOD lineSpacingMethod, FLOAT lineSpacing, FLOAT baseline)</b><br/>
	/// </summary>
	/// <param name="lineSpacingMethod"><b>DWRITE_LINE_SPACING_METHOD lineSpacingMethod</b></param>
	/// <param name="lineSpacing"><b>FLOAT lineSpacing</b></param>
	/// <param name="baseline"><b>FLOAT baseline</b></param>
	int SetLineSpacing (LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_TEXT_ALIGNMENT IDWriteTextFormat::GetTextAlignment ()</b><br/>
	/// </summary>
	TextAlignment GetTextAlignment ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_PARAGRAPH_ALIGNMENT IDWriteTextFormat::GetParagraphAlignment ()</b><br/>
	/// </summary>
	ParagraphAlignment GetParagraphAlignment ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_WORD_WRAPPING IDWriteTextFormat::GetWordWrapping ()</b><br/>
	/// </summary>
	WordWrapping GetWordWrapping ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_READING_DIRECTION IDWriteTextFormat::GetReadingDirection ()</b><br/>
	/// </summary>
	ReadingDirection GetReadingDirection ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FLOW_DIRECTION IDWriteTextFormat::GetFlowDirection ()</b><br/>
	/// </summary>
	FlowDirection GetFlowDirection ();
	/// <summary>
	/// STDMETHOD_ <b>FLOAT IDWriteTextFormat::GetIncrementalTabStop ()</b><br/>
	/// </summary>
	float GetIncrementalTabStop ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetTrimming (DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)</b><br/>
	/// </summary>
	/// <param name="trimmingOptions">_Out_ <b>DWRITE_TRIMMING* trimmingOptions</b></param>
	/// <param name="trimmingSign">_COM_Outptr_ <b>IDWriteInlineObject** trimmingSign</b></param>
	int GetTrimming<T0> (Trimming* trimmingOptions, T0** trimmingSign) where T0 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetTrimming (DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)</b><br/>
	/// </summary>
	/// <param name="trimmingOptions">_Out_ <b>DWRITE_TRIMMING* trimmingOptions</b></param>
	/// <param name="trimmingSign">_COM_Outptr_ <b>IDWriteInlineObject** trimmingSign</b></param>
	int GetTrimming<T0> (out Trimming trimmingOptions, out T0* trimmingSign) where T0 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetLineSpacing (DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, FLOAT* lineSpacing, FLOAT* baseline)</b><br/>
	/// </summary>
	/// <param name="lineSpacingMethod">_Out_ <b>DWRITE_LINE_SPACING_METHOD* lineSpacingMethod</b></param>
	/// <param name="lineSpacing">_Out_ <b>FLOAT* lineSpacing</b></param>
	/// <param name="baseline">_Out_ <b>FLOAT* baseline</b></param>
	int GetLineSpacing (LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetLineSpacing (DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, FLOAT* lineSpacing, FLOAT* baseline)</b><br/>
	/// </summary>
	/// <param name="lineSpacingMethod">_Out_ <b>DWRITE_LINE_SPACING_METHOD* lineSpacingMethod</b></param>
	/// <param name="lineSpacing">_Out_ <b>FLOAT* lineSpacing</b></param>
	/// <param name="baseline">_Out_ <b>FLOAT* baseline</b></param>
	int GetLineSpacing (out LineSpacingMethod lineSpacingMethod, out float lineSpacing, out float baseline);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetFontCollection (IDWriteFontCollection** fontCollection)</b><br/>
	/// </summary>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	int GetFontCollection<T0> (T0** fontCollection) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetFontCollection (IDWriteFontCollection** fontCollection)</b><br/>
	/// </summary>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	int GetFontCollection<T0> (out T0* fontCollection) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteTextFormat::GetFontFamilyNameLength ()</b><br/>
	/// </summary>
	uint GetFontFamilyNameLength ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetFontFamilyName (WCHAR* fontFamilyName, UINT32 nameSize)</b><br/>
	/// </summary>
	/// <param name="fontFamilyName">_Out_writes_z_(nameSize) <b>WCHAR* fontFamilyName</b></param>
	/// <param name="nameSize"><b>UINT32 nameSize</b></param>
	int GetFontFamilyName (char* fontFamilyName, uint nameSize);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_WEIGHT IDWriteTextFormat::GetFontWeight ()</b><br/>
	/// </summary>
	FontWeight GetFontWeight ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_STYLE IDWriteTextFormat::GetFontStyle ()</b><br/>
	/// </summary>
	FontStyle GetFontStyle ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_STRETCH IDWriteTextFormat::GetFontStretch ()</b><br/>
	/// </summary>
	FontStretch GetFontStretch ();
	/// <summary>
	/// STDMETHOD_ <b>FLOAT IDWriteTextFormat::GetFontSize ()</b><br/>
	/// </summary>
	float GetFontSize ();
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteTextFormat::GetLocaleNameLength ()</b><br/>
	/// </summary>
	uint GetLocaleNameLength ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat::GetLocaleName (WCHAR* localeName, UINT32 nameSize)</b><br/>
	/// </summary>
	/// <param name="localeName">_Out_writes_z_(nameSize) <b>WCHAR* localeName</b></param>
	/// <param name="nameSize"><b>UINT32 nameSize</b></param>
	int GetLocaleName (char* localeName, uint nameSize);
}

/// <summary>
/// Instance of <b>IDWriteTextFormat</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct TextFormat : ITextFormat {
//unsafe public readonly struct ITextFormatObj : ITextFormat {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextFormat* GetCurrentPointer () => (TextFormat*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextFormatObj* GetCurrentPointer () => (ITextFormatObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9c906818, 0x31d7, 0x4fd3, 0xa1, 0x51, 0x7c, 0x5e, 0x22, 0x5d, 0xb5, 0x5a);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
