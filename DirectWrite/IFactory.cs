using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFactory</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFactory : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::GetSystemFontCollection (IDWriteFontCollection** fontCollection, BOOL FALSE)</b><br/>
	/// </summary>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	/// <param name="fALSE"><b>BOOL FALSE</b></param>
	int GetSystemFontCollection<T0> (T0** fontCollection, bool fALSE) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::GetSystemFontCollection (IDWriteFontCollection** fontCollection, BOOL FALSE)</b><br/>
	/// </summary>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	/// <param name="fALSE"><b>BOOL FALSE</b></param>
	int GetSystemFontCollection<T0> (out T0* fontCollection, bool fALSE) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateCustomFontCollection (IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, UINT32 collectionKeySize, IDWriteFontCollection** fontCollection)</b><br/>
	/// </summary>
	/// <param name="collectionLoader">_In_ <b>IDWriteFontCollectionLoader* collectionLoader</b></param>
	/// <param name="collectionKey">_In_reads_bytes_(collectionKeySize) <b>void* collectionKey</b></param>
	/// <param name="collectionKeySize"><b>UINT32 collectionKeySize</b></param>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	int CreateCustomFontCollection<T0, T1> (T0* collectionLoader, void* collectionKey, uint collectionKeySize, T1** fontCollection) where T0 : unmanaged, IFontCollectionLoader where T1 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateCustomFontCollection (IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, UINT32 collectionKeySize, IDWriteFontCollection** fontCollection)</b><br/>
	/// </summary>
	/// <param name="collectionLoader">_In_ <b>IDWriteFontCollectionLoader* collectionLoader</b></param>
	/// <param name="collectionKey">_In_reads_bytes_(collectionKeySize) <b>void* collectionKey</b></param>
	/// <param name="collectionKeySize"><b>UINT32 collectionKeySize</b></param>
	/// <param name="fontCollection">_COM_Outptr_ <b>IDWriteFontCollection** fontCollection</b></param>
	int CreateCustomFontCollection<T0, T1> (T0* collectionLoader, void* collectionKey, uint collectionKeySize, out T1* fontCollection) where T0 : unmanaged, IFontCollectionLoader where T1 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::RegisterFontCollectionLoader (IDWriteFontCollectionLoader* fontCollectionLoader)</b><br/>
	/// </summary>
	/// <param name="fontCollectionLoader">_In_ <b>IDWriteFontCollectionLoader* fontCollectionLoader</b></param>
	int RegisterFontCollectionLoader<T0> (T0* fontCollectionLoader) where T0 : unmanaged, IFontCollectionLoader;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::UnregisterFontCollectionLoader (IDWriteFontCollectionLoader* fontCollectionLoader)</b><br/>
	/// </summary>
	/// <param name="fontCollectionLoader">_In_ <b>IDWriteFontCollectionLoader* fontCollectionLoader</b></param>
	int UnregisterFontCollectionLoader<T0> (T0* fontCollectionLoader) where T0 : unmanaged, IFontCollectionLoader;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateFontFileReference (WCHAR* filePath, FILETIME* lastWriteTime, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="filePath">_In_z_ <b>WCHAR* filePath</b></param>
	/// <param name="lastWriteTime">_In_opt_ <b>FILETIME* lastWriteTime</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateFontFileReference<T0> (char* filePath, FileTime* lastWriteTime, T0** fontFile) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateFontFileReference (WCHAR* filePath, FILETIME* lastWriteTime, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="filePath">_In_z_ <b>WCHAR* filePath</b></param>
	/// <param name="lastWriteTime">_In_opt_ <b>FILETIME* lastWriteTime</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateFontFileReference<T0> (char* filePath, FileTime* lastWriteTime, out T0* fontFile) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateCustomFontFileReference (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="fontFileLoader">_In_ <b>IDWriteFontFileLoader* fontFileLoader</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateCustomFontFileReference<T0, T1> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0* fontFileLoader, T1** fontFile) where T0 : unmanaged, IFontFileLoader where T1 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateCustomFontFileReference (void* fontFileReferenceKey, UINT32 fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_In_reads_bytes_(fontFileReferenceKeySize) <b>void* fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize"><b>UINT32 fontFileReferenceKeySize</b></param>
	/// <param name="fontFileLoader">_In_ <b>IDWriteFontFileLoader* fontFileLoader</b></param>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int CreateCustomFontFileReference<T0, T1> (void* fontFileReferenceKey, uint fontFileReferenceKeySize, T0* fontFileLoader, out T1* fontFile) where T0 : unmanaged, IFontFileLoader where T1 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateFontFace (DWRITE_FONT_FACE_TYPE fontFaceType, UINT32 numberOfFiles, IDWriteFontFile** fontFiles, UINT32 faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFaceType"><b>DWRITE_FONT_FACE_TYPE fontFaceType</b></param>
	/// <param name="numberOfFiles"><b>UINT32 numberOfFiles</b></param>
	/// <param name="fontFiles">_In_reads_(numberOfFiles) <b>IDWriteFontFile** fontFiles</b></param>
	/// <param name="faceIndex"><b>UINT32 faceIndex</b></param>
	/// <param name="fontFaceSimulationFlags"><b>DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace** fontFace</b></param>
	int CreateFontFace<T0, T1> (FontFaceType fontFaceType, uint numberOfFiles, T0** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, T1** fontFace) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateFontFace (DWRITE_FONT_FACE_TYPE fontFaceType, UINT32 numberOfFiles, IDWriteFontFile** fontFiles, UINT32 faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFaceType"><b>DWRITE_FONT_FACE_TYPE fontFaceType</b></param>
	/// <param name="numberOfFiles"><b>UINT32 numberOfFiles</b></param>
	/// <param name="fontFiles">_In_reads_(numberOfFiles) <b>IDWriteFontFile** fontFiles</b></param>
	/// <param name="faceIndex"><b>UINT32 faceIndex</b></param>
	/// <param name="fontFaceSimulationFlags"><b>DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace** fontFace</b></param>
	int CreateFontFace<T0, T1> (FontFaceType fontFaceType, uint numberOfFiles, T0** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, out T1* fontFace) where T0 : unmanaged, IFontFile where T1 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateRenderingParams (IDWriteRenderingParams** renderingParams)</b><br/>
	/// </summary>
	/// <param name="renderingParams">_COM_Outptr_ <b>IDWriteRenderingParams** renderingParams</b></param>
	int CreateRenderingParams<T0> (T0** renderingParams) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateRenderingParams (IDWriteRenderingParams** renderingParams)</b><br/>
	/// </summary>
	/// <param name="renderingParams">_COM_Outptr_ <b>IDWriteRenderingParams** renderingParams</b></param>
	int CreateRenderingParams<T0> (out T0* renderingParams) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateMonitorRenderingParams (HMONITOR monitor, IDWriteRenderingParams** renderingParams)</b><br/>
	/// </summary>
	/// <param name="monitor"><b>HMONITOR monitor</b></param>
	/// <param name="renderingParams">_COM_Outptr_ <b>IDWriteRenderingParams** renderingParams</b></param>
	int CreateMonitorRenderingParams<T0> (IntPtr monitor, T0** renderingParams) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateMonitorRenderingParams (HMONITOR monitor, IDWriteRenderingParams** renderingParams)</b><br/>
	/// </summary>
	/// <param name="monitor"><b>HMONITOR monitor</b></param>
	/// <param name="renderingParams">_COM_Outptr_ <b>IDWriteRenderingParams** renderingParams</b></param>
	int CreateMonitorRenderingParams<T0> (IntPtr monitor, out T0* renderingParams) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateCustomRenderingParams (FLOAT gamma, FLOAT enhancedContrast, FLOAT clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)</b><br/>
	/// </summary>
	/// <param name="gamma"><b>FLOAT gamma</b></param>
	/// <param name="enhancedContrast"><b>FLOAT enhancedContrast</b></param>
	/// <param name="clearTypeLevel"><b>FLOAT clearTypeLevel</b></param>
	/// <param name="pixelGeometry"><b>DWRITE_PIXEL_GEOMETRY pixelGeometry</b></param>
	/// <param name="renderingMode"><b>DWRITE_RENDERING_MODE renderingMode</b></param>
	/// <param name="renderingParams">_COM_Outptr_ <b>IDWriteRenderingParams** renderingParams</b></param>
	int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, T0** renderingParams) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateCustomRenderingParams (FLOAT gamma, FLOAT enhancedContrast, FLOAT clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)</b><br/>
	/// </summary>
	/// <param name="gamma"><b>FLOAT gamma</b></param>
	/// <param name="enhancedContrast"><b>FLOAT enhancedContrast</b></param>
	/// <param name="clearTypeLevel"><b>FLOAT clearTypeLevel</b></param>
	/// <param name="pixelGeometry"><b>DWRITE_PIXEL_GEOMETRY pixelGeometry</b></param>
	/// <param name="renderingMode"><b>DWRITE_RENDERING_MODE renderingMode</b></param>
	/// <param name="renderingParams">_COM_Outptr_ <b>IDWriteRenderingParams** renderingParams</b></param>
	int CreateCustomRenderingParams<T0> (float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, out T0* renderingParams) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::RegisterFontFileLoader (IDWriteFontFileLoader* fontFileLoader)</b><br/>
	/// </summary>
	/// <param name="fontFileLoader">_In_ <b>IDWriteFontFileLoader* fontFileLoader</b></param>
	int RegisterFontFileLoader<T0> (T0* fontFileLoader) where T0 : unmanaged, IFontFileLoader;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::UnregisterFontFileLoader (IDWriteFontFileLoader* fontFileLoader)</b><br/>
	/// </summary>
	/// <param name="fontFileLoader">_In_ <b>IDWriteFontFileLoader* fontFileLoader</b></param>
	int UnregisterFontFileLoader<T0> (T0* fontFileLoader) where T0 : unmanaged, IFontFileLoader;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTextFormat (WCHAR* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, FLOAT fontSize, WCHAR* localeName, IDWriteTextFormat** textFormat)</b><br/>
	/// </summary>
	/// <param name="fontFamilyName">_In_z_ <b>WCHAR* fontFamilyName</b></param>
	/// <param name="fontCollection">_In_opt_ <b>IDWriteFontCollection* fontCollection</b></param>
	/// <param name="fontWeight"><b>DWRITE_FONT_WEIGHT fontWeight</b></param>
	/// <param name="fontStyle"><b>DWRITE_FONT_STYLE fontStyle</b></param>
	/// <param name="fontStretch"><b>DWRITE_FONT_STRETCH fontStretch</b></param>
	/// <param name="fontSize"><b>FLOAT fontSize</b></param>
	/// <param name="localeName">_In_z_ <b>WCHAR* localeName</b></param>
	/// <param name="textFormat">_COM_Outptr_ <b>IDWriteTextFormat** textFormat</b></param>
	int CreateTextFormat<T0, T1> (char* fontFamilyName, T0* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, char* localeName, T1** textFormat) where T0 : unmanaged, IFontCollection where T1 : unmanaged, ITextFormat;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTextFormat (WCHAR* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, FLOAT fontSize, WCHAR* localeName, IDWriteTextFormat** textFormat)</b><br/>
	/// </summary>
	/// <param name="fontFamilyName">_In_z_ <b>WCHAR* fontFamilyName</b></param>
	/// <param name="fontCollection">_In_opt_ <b>IDWriteFontCollection* fontCollection</b></param>
	/// <param name="fontWeight"><b>DWRITE_FONT_WEIGHT fontWeight</b></param>
	/// <param name="fontStyle"><b>DWRITE_FONT_STYLE fontStyle</b></param>
	/// <param name="fontStretch"><b>DWRITE_FONT_STRETCH fontStretch</b></param>
	/// <param name="fontSize"><b>FLOAT fontSize</b></param>
	/// <param name="localeName">_In_z_ <b>WCHAR* localeName</b></param>
	/// <param name="textFormat">_COM_Outptr_ <b>IDWriteTextFormat** textFormat</b></param>
	int CreateTextFormat<T0, T1> (char* fontFamilyName, T0* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, char* localeName, out T1* textFormat) where T0 : unmanaged, IFontCollection where T1 : unmanaged, ITextFormat;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTypography (IDWriteTypography** typography)</b><br/>
	/// </summary>
	/// <param name="typography">_COM_Outptr_ <b>IDWriteTypography** typography</b></param>
	int CreateTypography<T0> (T0** typography) where T0 : unmanaged, ITypography;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTypography (IDWriteTypography** typography)</b><br/>
	/// </summary>
	/// <param name="typography">_COM_Outptr_ <b>IDWriteTypography** typography</b></param>
	int CreateTypography<T0> (out T0* typography) where T0 : unmanaged, ITypography;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::GetGdiInterop (IDWriteGdiInterop** gdiInterop)</b><br/>
	/// </summary>
	/// <param name="gdiInterop">_COM_Outptr_ <b>IDWriteGdiInterop** gdiInterop</b></param>
	int GetGdiInterop<T0> (T0** gdiInterop) where T0 : unmanaged, IGdiInterop;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::GetGdiInterop (IDWriteGdiInterop** gdiInterop)</b><br/>
	/// </summary>
	/// <param name="gdiInterop">_COM_Outptr_ <b>IDWriteGdiInterop** gdiInterop</b></param>
	int GetGdiInterop<T0> (out T0* gdiInterop) where T0 : unmanaged, IGdiInterop;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTextLayout (WCHAR* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT maxWidth, FLOAT maxHeight, IDWriteTextLayout** textLayout)</b><br/>
	/// </summary>
	/// <param name="string">_In_reads_(stringLength) <b>WCHAR* string</b></param>
	/// <param name="stringLength"><b>UINT32 stringLength</b></param>
	/// <param name="textFormat">_In_ <b>IDWriteTextFormat* textFormat</b></param>
	/// <param name="maxWidth"><b>FLOAT maxWidth</b></param>
	/// <param name="maxHeight"><b>FLOAT maxHeight</b></param>
	/// <param name="textLayout">_COM_Outptr_ <b>IDWriteTextLayout** textLayout</b></param>
	int CreateTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float maxWidth, float maxHeight, T1** textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTextLayout (WCHAR* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT maxWidth, FLOAT maxHeight, IDWriteTextLayout** textLayout)</b><br/>
	/// </summary>
	/// <param name="string">_In_reads_(stringLength) <b>WCHAR* string</b></param>
	/// <param name="stringLength"><b>UINT32 stringLength</b></param>
	/// <param name="textFormat">_In_ <b>IDWriteTextFormat* textFormat</b></param>
	/// <param name="maxWidth"><b>FLOAT maxWidth</b></param>
	/// <param name="maxHeight"><b>FLOAT maxHeight</b></param>
	/// <param name="textLayout">_COM_Outptr_ <b>IDWriteTextLayout** textLayout</b></param>
	int CreateTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float maxWidth, float maxHeight, out T1* textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateGdiCompatibleTextLayout (WCHAR* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT layoutWidth, FLOAT layoutHeight, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, BOOL useGdiNatural, IDWriteTextLayout** textLayout)</b><br/>
	/// </summary>
	/// <param name="string">_In_reads_(stringLength) <b>WCHAR* string</b></param>
	/// <param name="stringLength"><b>UINT32 stringLength</b></param>
	/// <param name="textFormat">_In_ <b>IDWriteTextFormat* textFormat</b></param>
	/// <param name="layoutWidth"><b>FLOAT layoutWidth</b></param>
	/// <param name="layoutHeight"><b>FLOAT layoutHeight</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="useGdiNatural"><b>BOOL useGdiNatural</b></param>
	/// <param name="textLayout">_COM_Outptr_ <b>IDWriteTextLayout** textLayout</b></param>
	int CreateGdiCompatibleTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, T1** textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateGdiCompatibleTextLayout (WCHAR* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT layoutWidth, FLOAT layoutHeight, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, BOOL useGdiNatural, IDWriteTextLayout** textLayout)</b><br/>
	/// </summary>
	/// <param name="string">_In_reads_(stringLength) <b>WCHAR* string</b></param>
	/// <param name="stringLength"><b>UINT32 stringLength</b></param>
	/// <param name="textFormat">_In_ <b>IDWriteTextFormat* textFormat</b></param>
	/// <param name="layoutWidth"><b>FLOAT layoutWidth</b></param>
	/// <param name="layoutHeight"><b>FLOAT layoutHeight</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="useGdiNatural"><b>BOOL useGdiNatural</b></param>
	/// <param name="textLayout">_COM_Outptr_ <b>IDWriteTextLayout** textLayout</b></param>
	int CreateGdiCompatibleTextLayout<T0, T1> (char* @string, uint stringLength, T0* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, out T1* textLayout) where T0 : unmanaged, ITextFormat where T1 : unmanaged, ITextLayout;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateEllipsisTrimmingSign (IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)</b><br/>
	/// </summary>
	/// <param name="textFormat">_In_ <b>IDWriteTextFormat* textFormat</b></param>
	/// <param name="trimmingSign">_COM_Outptr_ <b>IDWriteInlineObject** trimmingSign</b></param>
	int CreateEllipsisTrimmingSign<T0, T1> (T0* textFormat, T1** trimmingSign) where T0 : unmanaged, ITextFormat where T1 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateEllipsisTrimmingSign (IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)</b><br/>
	/// </summary>
	/// <param name="textFormat">_In_ <b>IDWriteTextFormat* textFormat</b></param>
	/// <param name="trimmingSign">_COM_Outptr_ <b>IDWriteInlineObject** trimmingSign</b></param>
	int CreateEllipsisTrimmingSign<T0, T1> (T0* textFormat, out T1* trimmingSign) where T0 : unmanaged, ITextFormat where T1 : unmanaged, IInlineObject;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTextAnalyzer (IDWriteTextAnalyzer** textAnalyzer)</b><br/>
	/// </summary>
	/// <param name="textAnalyzer">_COM_Outptr_ <b>IDWriteTextAnalyzer** textAnalyzer</b></param>
	int CreateTextAnalyzer<T0> (T0** textAnalyzer) where T0 : unmanaged, ITextAnalyzer;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateTextAnalyzer (IDWriteTextAnalyzer** textAnalyzer)</b><br/>
	/// </summary>
	/// <param name="textAnalyzer">_COM_Outptr_ <b>IDWriteTextAnalyzer** textAnalyzer</b></param>
	int CreateTextAnalyzer<T0> (out T0* textAnalyzer) where T0 : unmanaged, ITextAnalyzer;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateNumberSubstitution (DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, WCHAR* localeName, BOOL ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)</b><br/>
	/// </summary>
	/// <param name="substitutionMethod">_In_ <b>DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod</b></param>
	/// <param name="localeName">_In_z_ <b>WCHAR* localeName</b></param>
	/// <param name="ignoreUserOverride">_In_ <b>BOOL ignoreUserOverride</b></param>
	/// <param name="numberSubstitution">_COM_Outptr_ <b>IDWriteNumberSubstitution** numberSubstitution</b></param>
	int CreateNumberSubstitution<T0> (NumberSubstitutionMethod substitutionMethod, char* localeName, bool ignoreUserOverride, T0** numberSubstitution) where T0 : unmanaged, INumberSubstitution;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateNumberSubstitution (DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, WCHAR* localeName, BOOL ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)</b><br/>
	/// </summary>
	/// <param name="substitutionMethod">_In_ <b>DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod</b></param>
	/// <param name="localeName">_In_z_ <b>WCHAR* localeName</b></param>
	/// <param name="ignoreUserOverride">_In_ <b>BOOL ignoreUserOverride</b></param>
	/// <param name="numberSubstitution">_COM_Outptr_ <b>IDWriteNumberSubstitution** numberSubstitution</b></param>
	int CreateNumberSubstitution<T0> (NumberSubstitutionMethod substitutionMethod, char* localeName, bool ignoreUserOverride, out T0* numberSubstitution) where T0 : unmanaged, INumberSubstitution;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateGlyphRunAnalysis (DWRITE_GLYPH_RUN* glyphRun, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, FLOAT baselineOriginX, FLOAT baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)</b><br/>
	/// </summary>
	/// <param name="glyphRun">_In_ <b>DWRITE_GLYPH_RUN* glyphRun</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="renderingMode"><b>DWRITE_RENDERING_MODE renderingMode</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	/// <param name="baselineOriginX"><b>FLOAT baselineOriginX</b></param>
	/// <param name="baselineOriginY"><b>FLOAT baselineOriginY</b></param>
	/// <param name="glyphRunAnalysis">_COM_Outptr_ <b>IDWriteGlyphRunAnalysis** glyphRunAnalysis</b></param>
	int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2F* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, T0** glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFactory::CreateGlyphRunAnalysis (DWRITE_GLYPH_RUN* glyphRun, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, FLOAT baselineOriginX, FLOAT baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)</b><br/>
	/// </summary>
	/// <param name="glyphRun">_In_ <b>DWRITE_GLYPH_RUN* glyphRun</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="renderingMode"><b>DWRITE_RENDERING_MODE renderingMode</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	/// <param name="baselineOriginX"><b>FLOAT baselineOriginX</b></param>
	/// <param name="baselineOriginY"><b>FLOAT baselineOriginY</b></param>
	/// <param name="glyphRunAnalysis">_COM_Outptr_ <b>IDWriteGlyphRunAnalysis** glyphRunAnalysis</b></param>
	int CreateGlyphRunAnalysis<T0> (GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2F* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, out T0* glyphRunAnalysis) where T0 : unmanaged, IGlyphRunAnalysis;
}

/// <summary>
/// Instance of <b>IDWriteFactory</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct Factory : IFactory {
//unsafe public readonly struct IFactoryObj : IFactory {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Factory* GetCurrentPointer () => (Factory*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFactoryObj* GetCurrentPointer () => (IFactoryObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb859ee5a, 0xd838, 0x4b5b, 0xa2, 0xe8, 0x1a, 0xdc, 0x7d, 0x93, 0xdb, 0x48);

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
	public readonly int GetSystemFontCollection<T0> (T0** fontCollection, bool fALSE) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection (ptr, (void**) fontCollection, fALSE ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSystemFontCollection<T0> (out T0* fontCollection, bool fALSE) where T0 : unmanaged, IFontCollection {
		fixed (T0** _fontCollection = &fontCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSystemFontCollection (ptr, (void**) _fontCollection, fALSE ? 1U : 0U);
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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
