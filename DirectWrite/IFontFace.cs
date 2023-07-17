using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFace</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontFace : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_FACE_TYPE IDWriteFontFace::GetType ()</b><br/>
	/// </summary>
	FontFaceType GetFontFaceType ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetFiles (UINT32* numberOfFiles, IDWriteFontFile** fontFiles)</b><br/>
	/// </summary>
	/// <param name="numberOfFiles">_Inout_ <b>UINT32* numberOfFiles</b></param>
	/// <param name="fontFiles">_Out_writes_opt_(*numberOfFiles) <b>IDWriteFontFile** fontFiles</b></param>
	int GetFiles<T0> (uint* numberOfFiles, T0** fontFiles) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetFiles (UINT32* numberOfFiles, IDWriteFontFile** fontFiles)</b><br/>
	/// </summary>
	/// <param name="numberOfFiles">_Inout_ <b>UINT32* numberOfFiles</b></param>
	/// <param name="fontFiles">_Out_writes_opt_(*numberOfFiles) <b>IDWriteFontFile** fontFiles</b></param>
	int GetFiles<T0> (uint* numberOfFiles, out T0* fontFiles) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontFace::GetIndex ()</b><br/>
	/// </summary>
	uint GetIndex ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_SIMULATIONS IDWriteFontFace::GetSimulations ()</b><br/>
	/// </summary>
	FontSimulations GetSimulations ();
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFontFace::IsSymbolFont ()</b><br/>
	/// </summary>
	bool IsSymbolFont ();
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFontFace::GetMetrics (DWRITE_FONT_METRICS* fontFaceMetrics)</b><br/>
	/// </summary>
	/// <param name="fontFaceMetrics">_Out_ <b>DWRITE_FONT_METRICS* fontFaceMetrics</b></param>
	void GetMetrics (FontMetrics* fontFaceMetrics);
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFontFace::GetMetrics (DWRITE_FONT_METRICS* fontFaceMetrics)</b><br/>
	/// </summary>
	/// <param name="fontFaceMetrics">_Out_ <b>DWRITE_FONT_METRICS* fontFaceMetrics</b></param>
	void GetMetrics (out FontMetrics fontFaceMetrics);
	/// <summary>
	/// STDMETHOD_ <b>UINT16 IDWriteFontFace::GetGlyphCount ()</b><br/>
	/// </summary>
	ushort GetGlyphCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetDesignGlyphMetrics (UINT16* glyphIndices, UINT32 glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, BOOL FALSE)</b><br/>
	/// </summary>
	/// <param name="glyphIndices">_In_reads_(glyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphCount"><b>UINT32 glyphCount</b></param>
	/// <param name="glyphMetrics">_Out_writes_(glyphCount) <b>DWRITE_GLYPH_METRICS* glyphMetrics</b></param>
	/// <param name="fALSE"><b>BOOL FALSE</b></param>
	int GetDesignGlyphMetrics (ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool fALSE);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetGlyphIndices (UINT32* codePoints, UINT32 codePointCount, UINT16* glyphIndices)</b><br/>
	/// </summary>
	/// <param name="codePoints">_In_reads_(codePointCount) <b>UINT32* codePoints</b></param>
	/// <param name="codePointCount"><b>UINT32 codePointCount</b></param>
	/// <param name="glyphIndices">_Out_writes_(codePointCount) <b>UINT16* glyphIndices</b></param>
	int GetGlyphIndices (uint* codePoints, uint codePointCount, ushort* glyphIndices);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::TryGetFontTable (UINT32 openTypeTableTag, void** tableData, UINT32* tableSize, void** tableContext, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="openTypeTableTag">_In_ <b>UINT32 openTypeTableTag</b></param>
	/// <param name="tableData">_Outptr_result_bytebuffer_(*tableSize) <b>void** tableData</b></param>
	/// <param name="tableSize">_Out_ <b>UINT32* tableSize</b></param>
	/// <param name="tableContext">_Out_ <b>void** tableContext</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int TryGetFontTable (uint openTypeTableTag, void** tableData, uint* tableSize, void** tableContext, uint* exists);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::TryGetFontTable (UINT32 openTypeTableTag, void** tableData, UINT32* tableSize, void** tableContext, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="openTypeTableTag">_In_ <b>UINT32 openTypeTableTag</b></param>
	/// <param name="tableData">_Outptr_result_bytebuffer_(*tableSize) <b>void** tableData</b></param>
	/// <param name="tableSize">_Out_ <b>UINT32* tableSize</b></param>
	/// <param name="tableContext">_Out_ <b>void** tableContext</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int TryGetFontTable (uint openTypeTableTag, out void* tableData, out uint tableSize, out void* tableContext, out bool exists);
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFontFace::ReleaseFontTable (void* tableContext)</b><br/>
	/// </summary>
	/// <param name="tableContext">_In_ <b>void* tableContext</b></param>
	void ReleaseFontTable (void* tableContext);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetGlyphRunOutline (FLOAT emSize, UINT16* glyphIndices, FLOAT* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets, UINT32 glyphCount, BOOL isSideways, BOOL isRightToLeft, IDWriteGeometrySink* geometrySink)</b><br/>
	/// </summary>
	/// <param name="emSize"><b>FLOAT emSize</b></param>
	/// <param name="glyphIndices">_In_reads_(glyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphAdvances">_In_reads_opt_(glyphCount) <b>FLOAT* glyphAdvances</b></param>
	/// <param name="glyphOffsets">_In_reads_opt_(glyphCount) <b>DWRITE_GLYPH_OFFSET* glyphOffsets</b></param>
	/// <param name="glyphCount"><b>UINT32 glyphCount</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	/// <param name="geometrySink">_In_ <b>IDWriteGeometrySink* geometrySink</b></param>
	int GetGlyphRunOutline<T0> (float emSize, ushort* glyphIndices, float* glyphAdvances, GlyphOffset* glyphOffsets, uint glyphCount, bool isSideways, bool isRightToLeft, T0* geometrySink) where T0 : unmanaged, Direct2D.ISimplifiedGeometrySink;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetRecommendedRenderingMode (FLOAT emSize, FLOAT pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)</b><br/>
	/// </summary>
	/// <param name="emSize"><b>FLOAT emSize</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	/// <param name="renderingParams"><b>IDWriteRenderingParams* renderingParams</b></param>
	/// <param name="renderingMode">_Out_ <b>DWRITE_RENDERING_MODE* renderingMode</b></param>
	int GetRecommendedRenderingMode<T0> (float emSize, float pixelsPerDip, MeasuringMode measuringMode, T0* renderingParams, RenderingMode* renderingMode) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetRecommendedRenderingMode (FLOAT emSize, FLOAT pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)</b><br/>
	/// </summary>
	/// <param name="emSize"><b>FLOAT emSize</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	/// <param name="renderingParams"><b>IDWriteRenderingParams* renderingParams</b></param>
	/// <param name="renderingMode">_Out_ <b>DWRITE_RENDERING_MODE* renderingMode</b></param>
	int GetRecommendedRenderingMode<T0> (float emSize, float pixelsPerDip, MeasuringMode measuringMode, T0* renderingParams, out RenderingMode renderingMode) where T0 : unmanaged, IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetGdiCompatibleMetrics (FLOAT emSize, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)</b><br/>
	/// </summary>
	/// <param name="emSize"><b>FLOAT emSize</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="fontFaceMetrics">_Out_ <b>DWRITE_FONT_METRICS* fontFaceMetrics</b></param>
	int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, FontMetrics* fontFaceMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetGdiCompatibleMetrics (FLOAT emSize, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)</b><br/>
	/// </summary>
	/// <param name="emSize"><b>FLOAT emSize</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="fontFaceMetrics">_Out_ <b>DWRITE_FONT_METRICS* fontFaceMetrics</b></param>
	int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, out FontMetrics fontFaceMetrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFace::GetGdiCompatibleGlyphMetrics (FLOAT emSize, FLOAT pixelsPerDip, DWRITE_MATRIX* transform, BOOL useGdiNatural, UINT16* glyphIndices, UINT32 glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, BOOL FALSE)</b><br/>
	/// </summary>
	/// <param name="emSize"><b>FLOAT emSize</b></param>
	/// <param name="pixelsPerDip"><b>FLOAT pixelsPerDip</b></param>
	/// <param name="transform">_In_opt_ <b>DWRITE_MATRIX* transform</b></param>
	/// <param name="useGdiNatural"><b>BOOL useGdiNatural</b></param>
	/// <param name="glyphIndices">_In_reads_(glyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphCount"><b>UINT32 glyphCount</b></param>
	/// <param name="glyphMetrics">_Out_writes_(glyphCount) <b>DWRITE_GLYPH_METRICS* glyphMetrics</b></param>
	/// <param name="fALSE"><b>BOOL FALSE</b></param>
	int GetGdiCompatibleGlyphMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool fALSE);
}

/// <summary>
/// Instance of <b>IDWriteFontFace</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontFace : IFontFace {
//unsafe public readonly struct IFontFaceObj : IFontFace {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFace* GetCurrentPointer () => (FontFace*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFaceObj* GetCurrentPointer () => (IFontFaceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x5f49804d, 0x7024, 0x4d43, 0xbf, 0xa9, 0xd2, 0x59, 0x84, 0xf5, 0x38, 0x49);

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
	public readonly FontFaceType GetFontFaceType () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFiles<T0> (uint* numberOfFiles, T0** fontFiles) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFiles (ptr, numberOfFiles, (void**) fontFiles);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFiles<T0> (uint* numberOfFiles, out T0* fontFiles) where T0 : unmanaged, IFontFile {
		fixed (T0** _fontFiles = &fontFiles) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFiles (ptr, numberOfFiles, (void**) _fontFiles);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetIndex () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetIndex (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontSimulations GetSimulations () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSimulations (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsSymbolFont () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsSymbolFont (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (FontMetrics* fontFaceMetrics) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, fontFaceMetrics);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetMetrics (out FontMetrics fontFaceMetrics) {
		fixed (FontMetrics* _fontFaceMetrics = &fontFaceMetrics) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, _fontFaceMetrics);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ushort GetGlyphCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesignGlyphMetrics (ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool fALSE) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesignGlyphMetrics (ptr, glyphIndices, glyphCount, glyphMetrics, fALSE ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphIndices (uint* codePoints, uint codePointCount, ushort* glyphIndices) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphIndices (ptr, codePoints, codePointCount, glyphIndices);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TryGetFontTable (uint openTypeTableTag, void** tableData, uint* tableSize, void** tableContext, uint* exists) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->TryGetFontTable (ptr, openTypeTableTag, tableData, tableSize, tableContext, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TryGetFontTable (uint openTypeTableTag, out void* tableData, out uint tableSize, out void* tableContext, out bool exists) {
		fixed (void** _tableData = &tableData) {
			fixed (uint* _tableSize = &tableSize) {
				fixed (void** _tableContext = &tableContext) {
					uint _exists;
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->TryGetFontTable (ptr, openTypeTableTag, _tableData, _tableSize, _tableContext, &_exists);
					exists = _exists != 0;
					return hr;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ReleaseFontTable (void* tableContext) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ReleaseFontTable (ptr, tableContext);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphRunOutline<T0> (float emSize, ushort* glyphIndices, float* glyphAdvances, GlyphOffset* glyphOffsets, uint glyphCount, bool isSideways, bool isRightToLeft, T0* geometrySink) where T0 : unmanaged, Direct2D.ISimplifiedGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphRunOutline (ptr, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float emSize, float pixelsPerDip, MeasuringMode measuringMode, T0* renderingParams, RenderingMode* renderingMode) where T0 : unmanaged, IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRecommendedRenderingMode (ptr, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRecommendedRenderingMode<T0> (float emSize, float pixelsPerDip, MeasuringMode measuringMode, T0* renderingParams, out RenderingMode renderingMode) where T0 : unmanaged, IRenderingParams {
		fixed (RenderingMode* _renderingMode = &renderingMode) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetRecommendedRenderingMode (ptr, emSize, pixelsPerDip, measuringMode, renderingParams, _renderingMode);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, FontMetrics* fontFaceMetrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleMetrics (ptr, emSize, pixelsPerDip, transform, fontFaceMetrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, out FontMetrics fontFaceMetrics) {
		fixed (FontMetrics* _fontFaceMetrics = &fontFaceMetrics) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleMetrics (ptr, emSize, pixelsPerDip, transform, _fontFaceMetrics);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGdiCompatibleGlyphMetrics (float emSize, float pixelsPerDip, Matrix3x2F* transform, bool useGdiNatural, ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, bool fALSE) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGdiCompatibleGlyphMetrics (ptr, emSize, pixelsPerDip, transform, useGdiNatural ? 1U : 0U, glyphIndices, glyphCount, glyphMetrics, fALSE ? 1U : 0U);
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
		public readonly delegate* unmanaged[Stdcall]<void*, FontFaceType> _GetType;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, void**, int> GetFiles;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetIndex;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontSimulations> GetSimulations;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsSymbolFont;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontMetrics*, void> GetMetrics;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort> GetGlyphCount;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort*, uint, GlyphMetrics*, uint, int> GetDesignGlyphMetrics;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint, ushort*, int> GetGlyphIndices;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, uint*, void**, uint*, int> TryGetFontTable;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> ReleaseFontTable;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, ushort*, float*, GlyphOffset*, uint, uint, uint, void*, int> GetGlyphRunOutline;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, MeasuringMode, void*, RenderingMode*, int> GetRecommendedRenderingMode;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, Matrix3x2F*, FontMetrics*, int> GetGdiCompatibleMetrics;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, Matrix3x2F*, uint, ushort*, uint, GlyphMetrics*, uint, int> GetGdiCompatibleGlyphMetrics;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
