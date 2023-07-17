using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1CommandSink</b> : IUnknown<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface ICommandSink : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::BeginDraw ()</b><br/>
	/// </summary>
	int BeginDraw ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::EndDraw ()</b><br/>
	/// </summary>
	int EndDraw ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::SetAntialiasMode (D2D1_ANTIALIAS_MODE antialiasMode)</b><br/>
	/// </summary>
	/// <param name="antialiasMode"><b>D2D1_ANTIALIAS_MODE antialiasMode</b></param>
	int SetAntialiasMode (AntialiasMode antialiasMode);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::SetTags (D2D1_TAG tag1, D2D1_TAG tag2)</b><br/>
	/// </summary>
	/// <param name="tag1"><b>D2D1_TAG tag1</b></param>
	/// <param name="tag2"><b>D2D1_TAG tag2</b></param>
	int SetTags (ulong tag1, ulong tag2);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::SetTextAntialiasMode (D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)</b><br/>
	/// </summary>
	/// <param name="textAntialiasMode"><b>D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode</b></param>
	int SetTextAntialiasMode (TextAntialiasMode textAntialiasMode);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::SetTextRenderingParams (IDWriteRenderingParams* textRenderingParams)</b><br/>
	/// </summary>
	/// <param name="textRenderingParams">_In_opt_ <b>IDWriteRenderingParams* textRenderingParams</b></param>
	int SetTextRenderingParams<T0> (T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::SetTransform (D2D1_MATRIX_3X2_F* transform)</b><br/>
	/// </summary>
	/// <param name="transform">_In_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	int SetTransform (Matrix3x2F* transform);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::SetPrimitiveBlend (D2D1_PRIMITIVE_BLEND primitiveBlend)</b><br/>
	/// </summary>
	/// <param name="primitiveBlend"><b>D2D1_PRIMITIVE_BLEND primitiveBlend</b></param>
	int SetPrimitiveBlend (PrimitiveBlend primitiveBlend);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::SetUnitMode (D2D1_UNIT_MODE unitMode)</b><br/>
	/// </summary>
	/// <param name="unitMode"><b>D2D1_UNIT_MODE unitMode</b></param>
	int SetUnitMode (UnitMode unitMode);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::Clear (D2D1_COLOR_F* color)</b><br/>
	/// </summary>
	/// <param name="color">_In_opt_ <b>D2D1_COLOR_F* color</b></param>
	int Clear (Vector4F* color);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::DrawGlyphRun (D2D1_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode)</b><br/>
	/// </summary>
	/// <param name="baselineOrigin"><b>D2D1_POINT_2F baselineOrigin</b></param>
	/// <param name="glyphRun">_In_ <b>DWRITE_GLYPH_RUN* glyphRun</b></param>
	/// <param name="glyphRunDescription">_In_opt_ <b>DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription</b></param>
	/// <param name="foregroundBrush">_In_ <b>ID2D1Brush* foregroundBrush</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	int DrawGlyphRun<T0> (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, DirectWrite.GlyphRunDescription* glyphRunDescription, T0* foregroundBrush, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::DrawLine (D2D1_POINT_2F point0, D2D1_POINT_2F point1, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="point0"><b>D2D1_POINT_2F point0</b></param>
	/// <param name="point1"><b>D2D1_POINT_2F point1</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	int DrawLine<T0, T1> (Vector2F point0, Vector2F point1, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::DrawGeometry (ID2D1Geometry* geometry, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	int DrawGeometry<T0, T1, T2> (T0* geometry, T1* brush, float strokeWidth, T2* strokeStyle) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::DrawRectangle (D2D1_RECT_F* rect, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="rect">_In_ <b>D2D1_RECT_F* rect</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	int DrawRectangle<T0, T1> (Vector4F* rect, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::DrawBitmap (ID2D1Bitmap* bitmap, D2D1_RECT_F* destinationRectangle, FLOAT opacity, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_RECT_F* sourceRectangle, D2D1_MATRIX_4X4_F* perspectiveTransform)</b><br/>
	/// </summary>
	/// <param name="bitmap">_In_ <b>ID2D1Bitmap* bitmap</b></param>
	/// <param name="destinationRectangle">_In_opt_ <b>D2D1_RECT_F* destinationRectangle</b></param>
	/// <param name="opacity"><b>FLOAT opacity</b></param>
	/// <param name="interpolationMode"><b>D2D1_INTERPOLATION_MODE interpolationMode</b></param>
	/// <param name="sourceRectangle">_In_opt_ <b>D2D1_RECT_F* sourceRectangle</b></param>
	/// <param name="perspectiveTransform">_In_opt_ <b>D2D1_MATRIX_4X4_F* perspectiveTransform</b></param>
	int DrawBitmap<T0> (T0* bitmap, Vector4F* destinationRectangle, float opacity, InterpolationMode interpolationMode, Vector4F* sourceRectangle, Matrix4x4F* perspectiveTransform) where T0 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::DrawImage (ID2D1Image* image, D2D1_POINT_2F* targetOffset, D2D1_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)</b><br/>
	/// </summary>
	/// <param name="image">_In_ <b>ID2D1Image* image</b></param>
	/// <param name="targetOffset">_In_opt_ <b>D2D1_POINT_2F* targetOffset</b></param>
	/// <param name="imageRectangle">_In_opt_ <b>D2D1_RECT_F* imageRectangle</b></param>
	/// <param name="interpolationMode"><b>D2D1_INTERPOLATION_MODE interpolationMode</b></param>
	/// <param name="compositeMode"><b>D2D1_COMPOSITE_MODE compositeMode</b></param>
	int DrawImage<T0> (T0* image, Vector2F* targetOffset, Vector4F* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::DrawGdiMetafile (ID2D1GdiMetafile* gdiMetafile, D2D1_POINT_2F* targetOffset)</b><br/>
	/// </summary>
	/// <param name="gdiMetafile">_In_ <b>ID2D1GdiMetafile* gdiMetafile</b></param>
	/// <param name="targetOffset">_In_opt_ <b>D2D1_POINT_2F* targetOffset</b></param>
	int DrawGdiMetafile<T0> (T0* gdiMetafile, Vector2F* targetOffset) where T0 : unmanaged, IGdiMetafile;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::FillMesh (ID2D1Mesh* mesh, ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="mesh">_In_ <b>ID2D1Mesh* mesh</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	int FillMesh<T0, T1> (T0* mesh, T1* brush) where T0 : unmanaged, IMesh where T1 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::FillOpacityMask (ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_RECT_F* destinationRectangle, D2D1_RECT_F* sourceRectangle)</b><br/>
	/// </summary>
	/// <param name="opacityMask">_In_ <b>ID2D1Bitmap* opacityMask</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="destinationRectangle">_In_opt_ <b>D2D1_RECT_F* destinationRectangle</b></param>
	/// <param name="sourceRectangle">_In_opt_ <b>D2D1_RECT_F* sourceRectangle</b></param>
	int FillOpacityMask<T0, T1> (T0* opacityMask, T1* brush, Vector4F* destinationRectangle, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::FillGeometry (ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="opacityBrush">_In_opt_ <b>ID2D1Brush* opacityBrush</b></param>
	int FillGeometry<T0, T1, T2> (T0* geometry, T1* brush, T2* opacityBrush) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::FillRectangle (D2D1_RECT_F* rect, ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="rect">_In_ <b>D2D1_RECT_F* rect</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	int FillRectangle<T0> (Vector4F* rect, T0* brush) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::PushAxisAlignedClip (D2D1_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)</b><br/>
	/// </summary>
	/// <param name="clipRect">_In_ <b>D2D1_RECT_F* clipRect</b></param>
	/// <param name="antialiasMode"><b>D2D1_ANTIALIAS_MODE antialiasMode</b></param>
	int PushAxisAlignedClip (Vector4F* clipRect, AntialiasMode antialiasMode);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::PushLayer (D2D1_LAYER_PARAMETERS1* layerParameters1, ID2D1Layer* layer)</b><br/>
	/// </summary>
	/// <param name="layerParameters1">_In_ <b>D2D1_LAYER_PARAMETERS1* layerParameters1</b></param>
	/// <param name="layer">_In_opt_ <b>ID2D1Layer* layer</b></param>
	int PushLayer<T0> (LayerParameters1* layerParameters1, T0* layer) where T0 : unmanaged, ILayer;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::PopAxisAlignedClip ()</b><br/>
	/// </summary>
	int PopAxisAlignedClip ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink::PopLayer ()</b><br/>
	/// </summary>
	int PopLayer ();
}

/// <summary>
/// Instance of <b>ID2D1CommandSink</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct CommandSink : ICommandSink {
//unsafe public readonly struct ICommandSinkObj : ICommandSink {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly CommandSink* GetCurrentPointer () => (CommandSink*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ICommandSinkObj* GetCurrentPointer () => (ICommandSinkObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x54d7898a, 0xa061, 0x40a7, 0xbe, 0xc7, 0xe4, 0x65, 0xbc, 0xba, 0x2c, 0x4f);

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
	public readonly int BeginDraw () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->BeginDraw (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EndDraw () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EndDraw (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetAntialiasMode (AntialiasMode antialiasMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetAntialiasMode (ptr, antialiasMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTags (ulong tag1, ulong tag2) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTags (ptr, tag1, tag2);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTextAntialiasMode (TextAntialiasMode textAntialiasMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTextAntialiasMode (ptr, textAntialiasMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTextRenderingParams<T0> (T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTextRenderingParams (ptr, textRenderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTransform (ptr, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrimitiveBlend (PrimitiveBlend primitiveBlend) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrimitiveBlend (ptr, primitiveBlend);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetUnitMode (UnitMode unitMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetUnitMode (ptr, unitMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clear (Vector4F* color) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clear (ptr, color);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGlyphRun<T0> (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, DirectWrite.GlyphRunDescription* glyphRunDescription, T0* foregroundBrush, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGlyphRun (ptr, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawLine<T0, T1> (Vector2F point0, Vector2F point1, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawLine (ptr, point0, point1, brush, strokeWidth, strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGeometry<T0, T1, T2> (T0* geometry, T1* brush, float strokeWidth, T2* strokeStyle) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGeometry (ptr, geometry, brush, strokeWidth, strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawRectangle<T0, T1> (Vector4F* rect, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawRectangle (ptr, rect, brush, strokeWidth, strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawBitmap<T0> (T0* bitmap, Vector4F* destinationRectangle, float opacity, InterpolationMode interpolationMode, Vector4F* sourceRectangle, Matrix4x4F* perspectiveTransform) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawBitmap (ptr, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawImage<T0> (T0* image, Vector2F* targetOffset, Vector4F* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawImage (ptr, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGdiMetafile<T0> (T0* gdiMetafile, Vector2F* targetOffset) where T0 : unmanaged, IGdiMetafile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGdiMetafile (ptr, gdiMetafile, targetOffset);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillMesh<T0, T1> (T0* mesh, T1* brush) where T0 : unmanaged, IMesh where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillMesh (ptr, mesh, brush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillOpacityMask<T0, T1> (T0* opacityMask, T1* brush, Vector4F* destinationRectangle, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillOpacityMask (ptr, opacityMask, brush, destinationRectangle, sourceRectangle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillGeometry<T0, T1, T2> (T0* geometry, T1* brush, T2* opacityBrush) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillGeometry (ptr, geometry, brush, opacityBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillRectangle<T0> (Vector4F* rect, T0* brush) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillRectangle (ptr, rect, brush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushAxisAlignedClip (Vector4F* clipRect, AntialiasMode antialiasMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushAxisAlignedClip (ptr, clipRect, antialiasMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushLayer<T0> (LayerParameters1* layerParameters1, T0* layer) where T0 : unmanaged, ILayer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushLayer (ptr, layerParameters1, layer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PopAxisAlignedClip () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PopAxisAlignedClip (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PopLayer () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PopLayer (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, int> BeginDraw;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> EndDraw;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AntialiasMode, int> SetAntialiasMode;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, int> SetTags;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextAntialiasMode, int> SetTextAntialiasMode;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetTextRenderingParams;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, int> SetTransform;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PrimitiveBlend, int> SetPrimitiveBlend;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, UnitMode, int> SetUnitMode;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, int> Clear;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, DirectWrite.GlyphRun*, DirectWrite.GlyphRunDescription*, void*, DirectWrite.MeasuringMode, int> DrawGlyphRun;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, Vector2F, void*, float, void*, int> DrawLine;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, float, void*, int> DrawGeometry;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void*, float, void*, int> DrawRectangle;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, float, InterpolationMode, Vector4F*, Matrix4x4F*, int> DrawBitmap;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector2F*, Vector4F*, InterpolationMode, CompositeMode, int> DrawImage;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector2F*, int> DrawGdiMetafile;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> FillMesh;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, Vector4F*, Vector4F*, int> FillOpacityMask;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int> FillGeometry;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void*, int> FillRectangle;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, AntialiasMode, int> PushAxisAlignedClip;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LayerParameters1*, void*, int> PushLayer;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PopAxisAlignedClip;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PopLayer;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
