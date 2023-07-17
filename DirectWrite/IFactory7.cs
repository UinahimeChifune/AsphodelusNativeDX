using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFactory7</b> : IDWriteFactory6<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFactory7 : IFactory6 {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory7::GetSystemFontSet (BOOL includeDownloadableFonts, IDWriteFontSet2** fontSet)</b><br/>
	/// </summary>
	/// <param name="includeDownloadableFonts"><b>BOOL includeDownloadableFonts</b></param>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet2** fontSet</b></param>
	int GetSystemFontSet2<T0> (bool includeDownloadableFonts, T0** fontSet) where T0 : unmanaged, IFontSet2;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory7::GetSystemFontSet (BOOL includeDownloadableFonts, IDWriteFontSet2** fontSet)</b><br/>
	/// </summary>
	/// <param name="includeDownloadableFonts"><b>BOOL includeDownloadableFonts</b></param>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet2** fontSet</b></param>
	int GetSystemFontSet2<T0> (bool includeDownloadableFonts, out T0* fontSet) where T0 : unmanaged, IFontSet2;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory7::GetSystemFontCollection (BOOL includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteFontCollection3** fontCollection)</b><br/>
	/// </summary>
	/// <param name="includeDownloadableFonts"><b>BOOL includeDownloadableFonts</b></param>
	/// <param name="fontFamilyModel"><b>DWRITE_FONT_FAMILY_MODEL fontFamilyModel</b></param>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection3** fontCollection</b></param>
	int GetSystemFontCollection3<T0> (bool includeDownloadableFonts, FontFamilyModel fontFamilyModel, T0** fontCollection) where T0 : unmanaged, IFontCollection3;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory7::GetSystemFontCollection (BOOL includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteFontCollection3** fontCollection)</b><br/>
	/// </summary>
	/// <param name="includeDownloadableFonts"><b>BOOL includeDownloadableFonts</b></param>
	/// <param name="fontFamilyModel"><b>DWRITE_FONT_FAMILY_MODEL fontFamilyModel</b></param>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection3** fontCollection</b></param>
	int GetSystemFontCollection3<T0> (bool includeDownloadableFonts, FontFamilyModel fontFamilyModel, out T0* fontCollection) where T0 : unmanaged, IFontCollection3;
}

/// <summary>
/// Instance of <b>IDWriteFactory7</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct Factory7 : IFactory7 {
//unsafe public readonly struct IFactory7Obj : IFactory7 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Factory7* GetCurrentPointer () => (Factory7*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFactory7Obj* GetCurrentPointer () => (IFactory7Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x35d0e0b3, 0x9076, 0x4d2e, 0xa0, 0x16, 0xa9, 0x1b, 0x56, 0x8a, 0x06, 0xb4);

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
	public readonly int GetSystemFontCollection<T0> (T0** fontCollection, bool checkForUpdates) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection (ptr, (void**) fontCollection, checkForUpdates ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection<T0> (out T0* fontCollection, bool checkForUpdates) where T0 : unmanaged, IFontCollection {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection (ptr, (void**) _fontCollection, checkForUpdates ? 1U : 0U);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomFontCollection<T0, T1> (T0* collectionLoader, void* collectionKey, uint collectionKeySize, T1** fontCollection) where T0 : unmanaged, IFontCollectionLoader where T1 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomFontCollection (ptr, collectionLoader, collectionKey, collectionKeySize, (void**) fontCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomFontCollection<T0, T1> (T0* collectionLoader, void* collectionKey, uint collectionKeySize, out T1* fontCollection) where T0 : unmanaged, IFontCollectionLoader where T1 : unmanaged, IFontCollection {
		fixed (T1** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomFontCollection (ptr, collectionLoader, collectionKey, collectionKeySize, (void**) _fontCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterFontCollectionLoader<T0> (T0* fontCollectionLoader) where T0 : unmanaged, IFontCollectionLoader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterFontCollectionLoader (ptr, fontCollectionLoader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnregisterFontCollectionLoader<T0> (T0* fontCollectionLoader) where T0 : unmanaged, IFontCollectionLoader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnregisterFontCollectionLoader (ptr, fontCollectionLoader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFileReference<T0> (char* filePath, FileTime* lastWriteTime, T0** fontFile) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFileReference (ptr, filePath, lastWriteTime, (void**) fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFileReference<T0> (char* filePath, FileTime* lastWriteTime, out T0* fontFile) where T0 : unmanaged, IFontFile {
		fixed (T0** _fontFile = &fontFile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFileReference (ptr, filePath, lastWriteTime, (void**) _fontFile);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomFontFileReference<T0, T1> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0* fontFileLoader, T1** fontFile) where T0 : unmanaged, IFontFileLoader where T1 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomFontFileReference (ptr, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, (void**) fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomFontFileReference<T0, T1> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0* fontFileLoader, out T1* fontFile) where T0 : unmanaged, IFontFileLoader where T1 : unmanaged, IFontFile {
		fixed (T1** _fontFile = &fontFile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomFontFileReference (ptr, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, (void**) _fontFile);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0, T1> (FontFaceType fontFaceType, uint numberOfFiles, T0** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, T1** fontFace) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, fontFaceType, numberOfFiles, (void**) fontFiles, faceIndex, fontFaceSimulationFlags, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0, T1> (FontFaceType fontFaceType, uint numberOfFiles, T0** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, out T1* fontFace) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFace {
		fixed (T1** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, fontFaceType, numberOfFiles, (void**) fontFiles, faceIndex, fontFaceSimulationFlags, (void**) _fontFace);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRenderingParams<T0> (T0** renderingParams) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRenderingParams (ptr, (void**) renderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRenderingParams<T0> (out T0* renderingParams) where T0 : unmanaged, IRenderingParams {
		fixed (T0** _renderingParams = &renderingParams) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRenderingParams (ptr, (void**) _renderingParams);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMonitorRenderingParams<T0> (IntPtr monitor, T0** renderingParams) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateMonitorRenderingParams (ptr, monitor, (void**) renderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMonitorRenderingParams<T0> (IntPtr monitor, out T0* renderingParams) where T0 : unmanaged, IRenderingParams {
		fixed (T0** _renderingParams = &renderingParams) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateMonitorRenderingParams (ptr, monitor, (void**) _renderingParams);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, T0** renderingParams) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams (ptr, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, (void**) renderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, out T0* renderingParams) where T0 : unmanaged, IRenderingParams {
		fixed (T0** _renderingParams = &renderingParams) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams (ptr, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, (void**) _renderingParams);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterFontFileLoader<T0> (T0* fontFileLoader) where T0 : unmanaged, IFontFileLoader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterFontFileLoader (ptr, fontFileLoader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnregisterFontFileLoader<T0> (T0* fontFileLoader) where T0 : unmanaged, IFontFileLoader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnregisterFontFileLoader (ptr, fontFileLoader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextFormat<T0, T1> (char* fontFamilyName, T0* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, char* localeName, T1** textFormat) where T0 : unmanaged, IFontCollection where T1 : unmanaged, ITextFormat {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextFormat (ptr, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (void**) textFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextFormat<T0, T1> (char* fontFamilyName, T0* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, char* localeName, out T1* textFormat) where T0 : unmanaged, IFontCollection where T1 : unmanaged, ITextFormat {
		fixed (T1** _textFormat = &textFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextFormat (ptr, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (void**) _textFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTypography<T0> (T0** typography) where T0 : unmanaged, ITypography {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTypography (ptr, (void**) typography);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTypography<T0> (out T0* typography) where T0 : unmanaged, ITypography {
		fixed (T0** _typography = &typography) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTypography (ptr, (void**) _typography);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiInterop<T0> (T0** gdiInterop) where T0 : unmanaged, IGdiInterop {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiInterop (ptr, (void**) gdiInterop);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiInterop<T0> (out T0* gdiInterop) where T0 : unmanaged, IGdiInterop {
		fixed (T0** _gdiInterop = &gdiInterop) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiInterop (ptr, (void**) _gdiInterop);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float maxWidth, float maxHeight, T1** textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextLayout (ptr, @string, stringLength, textFormat, maxWidth, maxHeight, (void**) textLayout);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float maxWidth, float maxHeight, out T1* textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout {
		fixed (T1** _textLayout = &textLayout) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextLayout (ptr, @string, stringLength, textFormat, maxWidth, maxHeight, (void**) _textLayout);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGdiCompatibleTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, T1** textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGdiCompatibleTextLayout (ptr, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural ? 1U : 0U, (void**) textLayout);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGdiCompatibleTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, out T1* textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout {
		fixed (T1** _textLayout = &textLayout) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGdiCompatibleTextLayout (ptr, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural ? 1U : 0U, (void**) _textLayout);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEllipsisTrimmingSign<T0, T1> (T0* textFormat, T1** trimmingSign) where T0 : unmanaged, ITextFormat where T1 : unmanaged, IInlineObject {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateEllipsisTrimmingSign (ptr, textFormat, (void**) trimmingSign);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEllipsisTrimmingSign<T0, T1> (T0* textFormat, out T1* trimmingSign) where T0 : unmanaged, ITextFormat where T1 : unmanaged, IInlineObject {
		fixed (T1** _trimmingSign = &trimmingSign) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateEllipsisTrimmingSign (ptr, textFormat, (void**) _trimmingSign);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextAnalyzer<T0> (T0** textAnalyzer) where T0 : unmanaged, ITextAnalyzer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextAnalyzer (ptr, (void**) textAnalyzer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextAnalyzer<T0> (out T0* textAnalyzer) where T0 : unmanaged, ITextAnalyzer {
		fixed (T0** _textAnalyzer = &textAnalyzer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextAnalyzer (ptr, (void**) _textAnalyzer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateNumberSubstitution<T0> (NumberSubstitutionMethod substitutionMethod, char* localeName, bool ignoreUserOverride, T0** numberSubstitution) where T0 : unmanaged, INumberSubstitution {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateNumberSubstitution (ptr, substitutionMethod, localeName, ignoreUserOverride ? 1U : 0U, (void**) numberSubstitution);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateNumberSubstitution<T0> (NumberSubstitutionMethod substitutionMethod, char* localeName, bool ignoreUserOverride, out T0* numberSubstitution) where T0 : unmanaged, INumberSubstitution {
		fixed (T0** _numberSubstitution = &numberSubstitution) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateNumberSubstitution (ptr, substitutionMethod, localeName, ignoreUserOverride ? 1U : 0U, (void**) _numberSubstitution);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2F* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, T0** glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGlyphRunAnalysis (ptr, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (void**) glyphRunAnalysis);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2F* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, out T0* glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis {
		fixed (T0** _glyphRunAnalysis = &glyphRunAnalysis) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGlyphRunAnalysis (ptr, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (void**) _glyphRunAnalysis);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEudcFontCollection<T0> (T0** fontCollection, bool checkForUpdates) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEudcFontCollection (ptr, (void**) fontCollection, checkForUpdates ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEudcFontCollection<T0> (out T0* fontCollection, bool checkForUpdates) where T0 : unmanaged, IFontCollection {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEudcFontCollection (ptr, (void**) _fontCollection, checkForUpdates ? 1U : 0U);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, T0** renderingParams) where T0 : unmanaged, IRenderingParams1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams1 (ptr, gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, (void**) renderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, out T0* renderingParams) where T0 : unmanaged, IRenderingParams1 {
		fixed (T0** _renderingParams = &renderingParams) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams1 (ptr, gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, (void**) _renderingParams);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontFallback<T0> (T0** fontFallback) where T0 : unmanaged, IFontFallback {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontFallback (ptr, (void**) fontFallback);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontFallback<T0> (out T0* fontFallback) where T0 : unmanaged, IFontFallback {
		fixed (T0** _fontFallback = &fontFallback) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontFallback (ptr, (void**) _fontFallback);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFallbackBuilder<T0> (T0** fontFallbackBuilder) where T0 : unmanaged, IFontFallbackBuilder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFallbackBuilder (ptr, (void**) fontFallbackBuilder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFallbackBuilder<T0> (out T0* fontFallbackBuilder) where T0 : unmanaged, IFontFallbackBuilder {
		fixed (T0** _fontFallbackBuilder = &fontFallbackBuilder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFallbackBuilder (ptr, (void**) _fontFallbackBuilder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TranslateColorGlyphRun<T0> (float baselineOriginX, float baselineOriginY, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, Matrix3x2F* worldToDeviceTransform, uint colorPaletteIndex, T0** colorLayers) where T0 : unmanaged, IColorGlyphRunEnumerator {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->TranslateColorGlyphRun (ptr, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (void**) colorLayers);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TranslateColorGlyphRun<T0> (float baselineOriginX, float baselineOriginY, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, Matrix3x2F* worldToDeviceTransform, uint colorPaletteIndex, out T0* colorLayers) where T0 : unmanaged, IColorGlyphRunEnumerator {
		fixed (T0** _colorLayers = &colorLayers) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->TranslateColorGlyphRun (ptr, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (void**) _colorLayers);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, GridFitMode gridFitMode, T0** renderingParams) where T0 : unmanaged, IRenderingParams2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams2 (ptr, gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, (void**) renderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, GridFitMode gridFitMode, out T0* renderingParams) where T0 : unmanaged, IRenderingParams2 {
		fixed (T0** _renderingParams = &renderingParams) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams2 (ptr, gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, (void**) _renderingParams);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, Matrix3x2F* transform, RenderingMode renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, T0** glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_CreateGlyphRunAnalysis (ptr, glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, (void**) glyphRunAnalysis);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, Matrix3x2F* transform, RenderingMode renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, out T0* glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis {
		fixed (T0** _glyphRunAnalysis = &glyphRunAnalysis) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_CreateGlyphRunAnalysis (ptr, glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, (void**) _glyphRunAnalysis);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, Matrix3x2F* transform, RenderingMode1 renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, T0** glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__CreateGlyphRunAnalysis (ptr, glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, (void**) glyphRunAnalysis);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, Matrix3x2F* transform, RenderingMode1 renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, out T0* glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis {
		fixed (T0** _glyphRunAnalysis = &glyphRunAnalysis) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->__CreateGlyphRunAnalysis (ptr, glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, (void**) _glyphRunAnalysis);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode1 renderingMode, GridFitMode gridFitMode, T0** renderingParams) where T0 : unmanaged, IRenderingParams3 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams3 (ptr, gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, (void**) renderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode1 renderingMode, GridFitMode gridFitMode, out T0* renderingParams) where T0 : unmanaged, IRenderingParams3 {
		fixed (T0** _renderingParams = &renderingParams) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCustomRenderingParams3 (ptr, gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, (void**) _renderingParams);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0> (char* filePath, FileTime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceReference (ptr, filePath, lastWriteTime, faceIndex, fontSimulations, (void**) fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0> (char* filePath, FileTime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		fixed (T0** _fontFaceReference = &fontFaceReference) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceReference (ptr, filePath, lastWriteTime, faceIndex, fontSimulations, (void**) _fontFaceReference);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0, T1> (T0* fontFile, uint faceIndex, FontSimulations fontSimulations, T1** fontFaceReference) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_CreateFontFaceReference (ptr, fontFile, faceIndex, fontSimulations, (void**) fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0, T1> (T0* fontFile, uint faceIndex, FontSimulations fontSimulations, out T1* fontFaceReference) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFaceReference {
		fixed (T1** _fontFaceReference = &fontFaceReference) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_CreateFontFaceReference (ptr, fontFile, faceIndex, fontSimulations, (void**) _fontFaceReference);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontSet<T0> (T0** fontSet) where T0 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontSet (ptr, (void**) fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontSet<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet {
		fixed (T0** _fontSet = &fontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontSet (ptr, (void**) _fontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSetBuilder<T0> (T0** fontSetBuilder) where T0 : unmanaged, IFontSetBuilder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSetBuilder (ptr, (void**) fontSetBuilder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSetBuilder<T0> (out T0* fontSetBuilder) where T0 : unmanaged, IFontSetBuilder {
		fixed (T0** _fontSetBuilder = &fontSetBuilder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSetBuilder (ptr, (void**) _fontSetBuilder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontCollectionFromFontSet<T0, T1> (T0* fontSet, T1** fontCollection) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontCollection1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontCollectionFromFontSet (ptr, fontSet, (void**) fontCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontCollectionFromFontSet<T0, T1> (T0* fontSet, out T1* fontCollection) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontCollection1 {
		fixed (T1** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontCollectionFromFontSet (ptr, fontSet, (void**) _fontCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection<T0> (bool includeDownloadableFonts, T0** fontCollection, bool checkForUpdates) where T0 : unmanaged, IFontCollection1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection1 (ptr, includeDownloadableFonts ? 1U : 0U, (void**) fontCollection, checkForUpdates ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection<T0> (bool includeDownloadableFonts, out T0* fontCollection, bool checkForUpdates) where T0 : unmanaged, IFontCollection1 {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection1 (ptr, includeDownloadableFonts ? 1U : 0U, (void**) _fontCollection, checkForUpdates ? 1U : 0U);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontDownloadQueue<T0> (T0** fontDownloadQueue) where T0 : unmanaged, IFontDownloadQueue {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontDownloadQueue (ptr, (void**) fontDownloadQueue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontDownloadQueue<T0> (out T0* fontDownloadQueue) where T0 : unmanaged, IFontDownloadQueue {
		fixed (T0** _fontDownloadQueue = &fontDownloadQueue) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontDownloadQueue (ptr, (void**) _fontDownloadQueue);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TranslateColorGlyphRun<T0> (Vector2F baselineOrigin, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, GlyphImageFormats desiredGlyphImageFormats, MeasuringMode measuringMode, Matrix3x2F* worldAndDpiTransform, uint colorPaletteIndex, T0** colorLayers) where T0 : unmanaged, IColorGlyphRunEnumerator1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_TranslateColorGlyphRun (ptr, baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, (void**) colorLayers);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TranslateColorGlyphRun<T0> (Vector2F baselineOrigin, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, GlyphImageFormats desiredGlyphImageFormats, MeasuringMode measuringMode, Matrix3x2F* worldAndDpiTransform, uint colorPaletteIndex, out T0* colorLayers) where T0 : unmanaged, IColorGlyphRunEnumerator1 {
		fixed (T0** _colorLayers = &colorLayers) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_TranslateColorGlyphRun (ptr, baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, (void**) _colorLayers);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputeGlyphOrigins (GlyphRun* glyphRun, MeasuringMode measuringMode, Vector2F baselineOrigin, Matrix3x2F* worldAndDpiTransform, Vector2F* glyphOrigins) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ComputeGlyphOrigins (ptr, glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputeGlyphOrigins (GlyphRun* glyphRun, Vector2F baselineOrigin, Vector2F* glyphOrigins) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_ComputeGlyphOrigins (ptr, glyphRun, baselineOrigin, glyphOrigins);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSetBuilder1<T0> (T0** fontSetBuilder) where T0 : unmanaged, IFontSetBuilder1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSetBuilder1 (ptr, (void**) fontSetBuilder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSetBuilder1<T0> (out T0* fontSetBuilder) where T0 : unmanaged, IFontSetBuilder1 {
		fixed (T0** _fontSetBuilder = &fontSetBuilder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSetBuilder1 (ptr, (void**) _fontSetBuilder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateInMemoryFontFileLoader<T0> (T0** newLoader) where T0 : unmanaged, IInMemoryFontFileLoader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateInMemoryFontFileLoader (ptr, (void**) newLoader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateInMemoryFontFileLoader<T0> (out T0* newLoader) where T0 : unmanaged, IInMemoryFontFileLoader {
		fixed (T0** _newLoader = &newLoader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateInMemoryFontFileLoader (ptr, (void**) _newLoader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHttpFontFileLoader<T0> (char* referrerUrl, char* extraHeaders, T0** newLoader) where T0 : unmanaged, IRemoteFontFileLoader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateHttpFontFileLoader (ptr, referrerUrl, extraHeaders, (void**) newLoader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHttpFontFileLoader<T0> (char* referrerUrl, char* extraHeaders, out T0* newLoader) where T0 : unmanaged, IRemoteFontFileLoader {
		fixed (T0** _newLoader = &newLoader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateHttpFontFileLoader (ptr, referrerUrl, extraHeaders, (void**) _newLoader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ContainerType AnalyzeContainerType (void* fileData, uint fileDataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AnalyzeContainerType (ptr, fileData, fileDataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnpackFontFile<T0> (ContainerType containerType, void* fileData, uint fileDataSize, T0** unpackedFontStream) where T0 : unmanaged, IFontFileStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnpackFontFile (ptr, containerType, fileData, fileDataSize, (void**) unpackedFontStream);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnpackFontFile<T0> (ContainerType containerType, void* fileData, uint fileDataSize, out T0* unpackedFontStream) where T0 : unmanaged, IFontFileStream {
		fixed (T0** _unpackedFontStream = &unpackedFontStream) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->UnpackFontFile (ptr, containerType, fileData, fileDataSize, (void**) _unpackedFontStream);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0, T1> (T0* fontFile, uint faceIndex, FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T1** fontFaceReference) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFaceReference1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_CreateFontFaceReference1 (ptr, fontFile, faceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, (void**) fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0, T1> (T0* fontFile, uint faceIndex, FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T1* fontFaceReference) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFaceReference1 {
		fixed (T1** _fontFaceReference = &fontFaceReference) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_CreateFontFaceReference1 (ptr, fontFile, faceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, (void**) _fontFaceReference);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontResource<T0, T1> (T0* fontFile, uint faceIndex, T1** fontResource) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontResource (ptr, fontFile, faceIndex, (void**) fontResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontResource<T0, T1> (T0* fontFile, uint faceIndex, out T1* fontResource) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontResource {
		fixed (T1** _fontResource = &fontResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontResource (ptr, fontFile, faceIndex, (void**) _fontResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontSet<T0> (bool includeDownloadableFonts, T0** fontSet) where T0 : unmanaged, IFontSet1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontSet1 (ptr, includeDownloadableFonts ? 1U : 0U, (void**) fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontSet<T0> (bool includeDownloadableFonts, out T0* fontSet) where T0 : unmanaged, IFontSet1 {
		fixed (T0** _fontSet = &fontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontSet1 (ptr, includeDownloadableFonts ? 1U : 0U, (void**) _fontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection<T0> (bool includeDownloadableFonts, FontFamilyModel fontFamilyModel, T0** fontCollection) where T0 : unmanaged, IFontCollection2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection2 (ptr, includeDownloadableFonts ? 1U : 0U, fontFamilyModel, (void**) fontCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection<T0> (bool includeDownloadableFonts, FontFamilyModel fontFamilyModel, out T0* fontCollection) where T0 : unmanaged, IFontCollection2 {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection2 (ptr, includeDownloadableFonts ? 1U : 0U, fontFamilyModel, (void**) _fontCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontCollectionFromFontSet<T0, T1> (T0* fontSet, FontFamilyModel fontFamilyModel, T1** fontCollection) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontCollection2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontCollection2FromFontSet (ptr, fontSet, fontFamilyModel, (void**) fontCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontCollectionFromFontSet<T0, T1> (T0* fontSet, FontFamilyModel fontFamilyModel, out T1* fontCollection) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontCollection2 {
		fixed (T1** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontCollection2FromFontSet (ptr, fontSet, fontFamilyModel, (void**) _fontCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSetBuilder2<T0> (T0** fontSetBuilder) where T0 : unmanaged, IFontSetBuilder2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSetBuilder2 (ptr, (void**) fontSetBuilder);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSetBuilder2<T0> (out T0* fontSetBuilder) where T0 : unmanaged, IFontSetBuilder2 {
		fixed (T0** _fontSetBuilder = &fontSetBuilder) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSetBuilder2 (ptr, (void**) _fontSetBuilder);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextFormat<T0, T1> (char* fontFamilyName, T0* fontCollection, FontAxisValue* fontAxisValues, uint fontAxisValueCount, float fontSize, char* localeName, T1** textFormat) where T0 : unmanaged, IFontCollection where T1 : unmanaged, ITextFormat3 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextFormat3 (ptr, fontFamilyName, fontCollection, fontAxisValues, fontAxisValueCount, fontSize, localeName, (void**) textFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTextFormat<T0, T1> (char* fontFamilyName, T0* fontCollection, FontAxisValue* fontAxisValues, uint fontAxisValueCount, float fontSize, char* localeName, out T1* textFormat) where T0 : unmanaged, IFontCollection where T1 : unmanaged, ITextFormat3 {
		fixed (T1** _textFormat = &textFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTextFormat3 (ptr, fontFamilyName, fontCollection, fontAxisValues, fontAxisValueCount, fontSize, localeName, (void**) _textFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontSet2<T0> (bool includeDownloadableFonts, T0** fontSet) where T0 : unmanaged, IFontSet2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontSet2 (ptr, includeDownloadableFonts ? 1U : 0U, (void**) fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontSet2<T0> (bool includeDownloadableFonts, out T0* fontSet) where T0 : unmanaged, IFontSet2 {
		fixed (T0** _fontSet = &fontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontSet2 (ptr, includeDownloadableFonts ? 1U : 0U, (void**) _fontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection3<T0> (bool includeDownloadableFonts, FontFamilyModel fontFamilyModel, T0** fontCollection) where T0 : unmanaged, IFontCollection3 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection3 (ptr, includeDownloadableFonts ? 1U : 0U, fontFamilyModel, (void**) fontCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection3<T0> (bool includeDownloadableFonts, FontFamilyModel fontFamilyModel, out T0* fontCollection) where T0 : unmanaged, IFontCollection3 {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection3 (ptr, includeDownloadableFonts ? 1U : 0U, fontFamilyModel, (void**) _fontCollection);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint, int> GetSystemFontCollection;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, void**, int> CreateCustomFontCollection;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> RegisterFontCollectionLoader;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> UnregisterFontCollectionLoader;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, FileTime*, void**, int> CreateFontFileReference;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void*, void**, int> CreateCustomFontFileReference;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontFaceType, uint, void**, uint, FontSimulations, void**, int> CreateFontFace;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateRenderingParams;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, void**, int> CreateMonitorRenderingParams;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, PixelGeometry, RenderingMode, void**, int> CreateCustomRenderingParams;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> RegisterFontFileLoader;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> UnregisterFontFileLoader;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*, FontWeight, FontStyle, FontStretch, float, char*, void**, int> CreateTextFormat;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateTypography;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetGdiInterop;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, void*, float, float, void**, int> CreateTextLayout;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, void*, float, float, float, Matrix3x2F*, uint, void**, int> CreateGdiCompatibleTextLayout;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateEllipsisTrimmingSign;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateTextAnalyzer;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, NumberSubstitutionMethod, char*, uint, void**, int> CreateNumberSubstitution;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphRun*, float, Matrix3x2F*, RenderingMode, MeasuringMode, float, float, void**, int> CreateGlyphRunAnalysis;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint, int> GetEudcFontCollection;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, float, PixelGeometry, RenderingMode, void**, int> CreateCustomRenderingParams1;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetSystemFontFallback;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontFallbackBuilder;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix3x2F*, uint, void**, int> TranslateColorGlyphRun;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, float, PixelGeometry, RenderingMode, GridFitMode, void**, int> CreateCustomRenderingParams2;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphRun*, Matrix3x2F*, RenderingMode, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, void**, int> _CreateGlyphRunAnalysis;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphRun*, Matrix3x2F*, RenderingMode1, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, void**, int> __CreateGlyphRunAnalysis;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, float, float, PixelGeometry, RenderingMode1, GridFitMode, void**, int> CreateCustomRenderingParams3;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, FileTime*, uint, FontSimulations, void**, int> CreateFontFaceReference;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, FontSimulations, void**, int> _CreateFontFaceReference;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetSystemFontSet;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontSetBuilder;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateFontCollectionFromFontSet;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, uint, int> GetSystemFontCollection1;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontDownloadQueue;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, GlyphRun*, GlyphRunDescription*, GlyphImageFormats, MeasuringMode, Matrix3x2F*, uint, void**, int> _TranslateColorGlyphRun;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphRun*, MeasuringMode, Vector2F, Matrix3x2F*, Vector2F*, int> ComputeGlyphOrigins;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GlyphRun*, Vector2F, Vector2F*, int> _ComputeGlyphOrigins;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontSetBuilder1;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateInMemoryFontFileLoader;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, char*, void**, int> CreateHttpFontFileLoader;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, ContainerType> AnalyzeContainerType;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ContainerType, void*, uint, void**, int> UnpackFontFile;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, FontSimulations, FontAxisValue*, uint, void**, int> _CreateFontFaceReference1;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void**, int> CreateFontResource;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetSystemFontSet1;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontFamilyModel, void**, int> GetSystemFontCollection2;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, FontFamilyModel, void**, int> CreateFontCollection2FromFontSet;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontSetBuilder2;
		/// <summary>
		/// OFFSET 54
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*, FontAxisValue*, uint, float, char*, void**, int> CreateTextFormat3;
		/// <summary>
		/// OFFSET 55
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetSystemFontSet2;
		/// <summary>
		/// OFFSET 56
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontFamilyModel, void**, int> GetSystemFontCollection3;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
