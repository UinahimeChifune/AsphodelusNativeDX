using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextFormat3</b> : IDWriteTextFormat2<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface ITextFormat3 : ITextFormat2 {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat3::SetFontAxisValues (DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	int SetFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteTextFormat3::GetFontAxisValueCount ()</b><br/>
	/// </summary>
	uint GetFontAxisValueCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat3::GetFontAxisValues (DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisValues">_Out_writes_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	int GetFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_AUTOMATIC_FONT_AXES IDWriteTextFormat3::GetAutomaticFontAxes ()</b><br/>
	/// </summary>
	AutomaticFontAxes GetAutomaticFontAxes ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextFormat3::SetAutomaticFontAxes (DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes)</b><br/>
	/// </summary>
	/// <param name="automaticFontAxes"><b>DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes</b></param>
	int SetAutomaticFontAxes (AutomaticFontAxes automaticFontAxes);
}

/// <summary>
/// Instance of <b>IDWriteTextFormat3</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct TextFormat3 : ITextFormat3 {
//unsafe public readonly struct ITextFormat3Obj : ITextFormat3 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextFormat3* GetCurrentPointer () => (TextFormat3*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextFormat3Obj* GetCurrentPointer () => (ITextFormat3Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x6d3b5641, 0xe550, 0x430d, 0xa8, 0x5b, 0xb7, 0xbf, 0x48, 0xa9, 0x34, 0x27);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetLineSpacing (LineSpacing* lineSpacingOptions) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_SetLineSpacing (ptr, lineSpacingOptions);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLineSpacing (LineSpacing* lineSpacingOptions) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetLineSpacing (ptr, lineSpacingOptions);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLineSpacing (out LineSpacing lineSpacingOptions) {
		fixed (LineSpacing* _lineSpacingOptions = &lineSpacingOptions) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetLineSpacing (ptr, _lineSpacingOptions);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFontAxisValues (ptr, fontAxisValues, fontAxisValueCount);
		return hr;
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
	public readonly AutomaticFontAxes GetAutomaticFontAxes () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAutomaticFontAxes (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetAutomaticFontAxes (AutomaticFontAxes automaticFontAxes) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetAutomaticFontAxes (ptr, automaticFontAxes);
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
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VerticalGlyphOrientation, int> SetVerticalGlyphOrientation;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VerticalGlyphOrientation> GetVerticalGlyphOrientation;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetLastLineWrapping;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetLastLineWrapping;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OpticalAlignment, int> SetOpticalAlignment;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OpticalAlignment> GetOpticalAlignment;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetFontFallback;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontFallback;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LineSpacing*, int> _SetLineSpacing;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LineSpacing*, int> _GetLineSpacing;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisValue*, uint, int> SetFontAxisValues;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontAxisValueCount;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisValue*, uint, int> GetFontAxisValues;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AutomaticFontAxes> GetAutomaticFontAxes;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AutomaticFontAxes, int> SetAutomaticFontAxes;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
