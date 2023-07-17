using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1RenderTarget</b> : ID2D1Resource<br/>
/// D2D1.h
/// </summary>
unsafe public interface IRenderTarget : IResource {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateBitmap (D2D1_SIZE_U size, void* srcData, UINT32 pitch, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)</b><br/>
	/// </summary>
	/// <param name="size"><b>D2D1_SIZE_U size</b></param>
	/// <param name="srcData">_In_opt_ <b>void* srcData</b></param>
	/// <param name="pitch"><b>UINT32 pitch</b></param>
	/// <param name="bitmapProperties">_In_ <b>D2D1_BITMAP_PROPERTIES* bitmapProperties</b></param>
	/// <param name="bitmap">_COM_Outptr_ <b>ID2D1Bitmap** bitmap</b></param>
	int CreateBitmap<T0> (Vector2U size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, T0** bitmap) where T0 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateBitmap (D2D1_SIZE_U size, void* srcData, UINT32 pitch, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)</b><br/>
	/// </summary>
	/// <param name="size"><b>D2D1_SIZE_U size</b></param>
	/// <param name="srcData">_In_opt_ <b>void* srcData</b></param>
	/// <param name="pitch"><b>UINT32 pitch</b></param>
	/// <param name="bitmapProperties">_In_ <b>D2D1_BITMAP_PROPERTIES* bitmapProperties</b></param>
	/// <param name="bitmap">_COM_Outptr_ <b>ID2D1Bitmap** bitmap</b></param>
	int CreateBitmap<T0> (Vector2U size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, out T0* bitmap) where T0 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateBitmapFromWicBitmap (IWICBitmapSource* wicBitmapSource, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)</b><br/>
	/// </summary>
	/// <param name="wicBitmapSource">_In_ <b>IWICBitmapSource* wicBitmapSource</b></param>
	/// <param name="bitmapProperties">_In_opt_ <b>D2D1_BITMAP_PROPERTIES* bitmapProperties</b></param>
	/// <param name="bitmap">_COM_Outptr_ <b>ID2D1Bitmap** bitmap</b></param>
	int CreateBitmapFromWicBitmap<T0, T1> (T0* wicBitmapSource, BitmapProperties* bitmapProperties, T1** bitmap) where T0 : unmanaged, WIC.IBitmapSource where T1 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateBitmapFromWicBitmap (IWICBitmapSource* wicBitmapSource, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)</b><br/>
	/// </summary>
	/// <param name="wicBitmapSource">_In_ <b>IWICBitmapSource* wicBitmapSource</b></param>
	/// <param name="bitmapProperties">_In_opt_ <b>D2D1_BITMAP_PROPERTIES* bitmapProperties</b></param>
	/// <param name="bitmap">_COM_Outptr_ <b>ID2D1Bitmap** bitmap</b></param>
	int CreateBitmapFromWicBitmap<T0, T1> (T0* wicBitmapSource, BitmapProperties* bitmapProperties, out T1* bitmap) where T0 : unmanaged, WIC.IBitmapSource where T1 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateSharedBitmap (REFIID riid, void* data, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)</b><br/>
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="data">_Inout_ <b>void* data</b></param>
	/// <param name="bitmapProperties">_In_opt_ <b>D2D1_BITMAP_PROPERTIES* bitmapProperties</b></param>
	/// <param name="bitmap">_COM_Outptr_ <b>ID2D1Bitmap** bitmap</b></param>
	int CreateSharedBitmap<T0> (Guid riid, void* data, BitmapProperties* bitmapProperties, T0** bitmap) where T0 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateSharedBitmap (REFIID riid, void* data, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)</b><br/>
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="data">_Inout_ <b>void* data</b></param>
	/// <param name="bitmapProperties">_In_opt_ <b>D2D1_BITMAP_PROPERTIES* bitmapProperties</b></param>
	/// <param name="bitmap">_COM_Outptr_ <b>ID2D1Bitmap** bitmap</b></param>
	int CreateSharedBitmap<T0> (Guid riid, void* data, BitmapProperties* bitmapProperties, out T0* bitmap) where T0 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateBitmapBrush (ID2D1Bitmap* bitmap, D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush)</b><br/>
	/// </summary>
	/// <param name="bitmap">_In_opt_ <b>ID2D1Bitmap* bitmap</b></param>
	/// <param name="bitmapBrushProperties">_In_opt_ <b>D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="bitmapBrush">_COM_Outptr_ <b>ID2D1BitmapBrush** bitmapBrush</b></param>
	int CreateBitmapBrush<T0, T1> (T0* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, T1** bitmapBrush) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBitmapBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateBitmapBrush (ID2D1Bitmap* bitmap, D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush)</b><br/>
	/// </summary>
	/// <param name="bitmap">_In_opt_ <b>ID2D1Bitmap* bitmap</b></param>
	/// <param name="bitmapBrushProperties">_In_opt_ <b>D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="bitmapBrush">_COM_Outptr_ <b>ID2D1BitmapBrush** bitmapBrush</b></param>
	int CreateBitmapBrush<T0, T1> (T0* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, out T1* bitmapBrush) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBitmapBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateSolidColorBrush (D2D1_COLOR_F* color, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush)</b><br/>
	/// </summary>
	/// <param name="color">_In_ <b>D2D1_COLOR_F* color</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="solidColorBrush">_COM_Outptr_ <b>ID2D1SolidColorBrush** solidColorBrush</b></param>
	int CreateSolidColorBrush<T0> (Vector4F* color, BrushProperties* brushProperties, T0** solidColorBrush) where T0 : unmanaged, ISolidColorBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateSolidColorBrush (D2D1_COLOR_F* color, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush)</b><br/>
	/// </summary>
	/// <param name="color">_In_ <b>D2D1_COLOR_F* color</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="solidColorBrush">_COM_Outptr_ <b>ID2D1SolidColorBrush** solidColorBrush</b></param>
	int CreateSolidColorBrush<T0> (Vector4F* color, BrushProperties* brushProperties, out T0* solidColorBrush) where T0 : unmanaged, ISolidColorBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateGradientStopCollection (D2D1_GRADIENT_STOP* gradientStops, UINT32 gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection)</b><br/>
	/// </summary>
	/// <param name="gradientStops">_In_reads_(gradientStopsCount) <b>D2D1_GRADIENT_STOP* gradientStops</b></param>
	/// <param name="gradientStopsCount">_In_range_(>=,1) <b>UINT32 gradientStopsCount</b></param>
	/// <param name="colorInterpolationGamma"><b>D2D1_GAMMA colorInterpolationGamma</b></param>
	/// <param name="extendMode"><b>D2D1_EXTEND_MODE extendMode</b></param>
	/// <param name="gradientStopCollection">_COM_Outptr_ <b>ID2D1GradientStopCollection** gradientStopCollection</b></param>
	int CreateGradientStopCollection<T0> (GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, T0** gradientStopCollection) where T0 : unmanaged, IGradientStopCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateGradientStopCollection (D2D1_GRADIENT_STOP* gradientStops, UINT32 gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection)</b><br/>
	/// </summary>
	/// <param name="gradientStops">_In_reads_(gradientStopsCount) <b>D2D1_GRADIENT_STOP* gradientStops</b></param>
	/// <param name="gradientStopsCount">_In_range_(>=,1) <b>UINT32 gradientStopsCount</b></param>
	/// <param name="colorInterpolationGamma"><b>D2D1_GAMMA colorInterpolationGamma</b></param>
	/// <param name="extendMode"><b>D2D1_EXTEND_MODE extendMode</b></param>
	/// <param name="gradientStopCollection">_COM_Outptr_ <b>ID2D1GradientStopCollection** gradientStopCollection</b></param>
	int CreateGradientStopCollection<T0> (GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, out T0* gradientStopCollection) where T0 : unmanaged, IGradientStopCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateLinearGradientBrush (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)</b><br/>
	/// </summary>
	/// <param name="linearGradientBrushProperties">_In_ <b>D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="gradientStopCollection">_In_ <b>ID2D1GradientStopCollection* gradientStopCollection</b></param>
	/// <param name="linearGradientBrush">_COM_Outptr_ <b>ID2D1LinearGradientBrush** linearGradientBrush</b></param>
	int CreateLinearGradientBrush<T0, T1> (LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, T1** linearGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, ILinearGradientBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateLinearGradientBrush (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)</b><br/>
	/// </summary>
	/// <param name="linearGradientBrushProperties">_In_ <b>D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="gradientStopCollection">_In_ <b>ID2D1GradientStopCollection* gradientStopCollection</b></param>
	/// <param name="linearGradientBrush">_COM_Outptr_ <b>ID2D1LinearGradientBrush** linearGradientBrush</b></param>
	int CreateLinearGradientBrush<T0, T1> (LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, out T1* linearGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, ILinearGradientBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateRadialGradientBrush (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)</b><br/>
	/// </summary>
	/// <param name="radialGradientBrushProperties">_In_ <b>D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="gradientStopCollection">_In_ <b>ID2D1GradientStopCollection* gradientStopCollection</b></param>
	/// <param name="radialGradientBrush">_COM_Outptr_ <b>ID2D1RadialGradientBrush** radialGradientBrush</b></param>
	int CreateRadialGradientBrush<T0, T1> (RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, T1** radialGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, IRadialGradientBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateRadialGradientBrush (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)</b><br/>
	/// </summary>
	/// <param name="radialGradientBrushProperties">_In_ <b>D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties</b></param>
	/// <param name="brushProperties">_In_opt_ <b>D2D1_BRUSH_PROPERTIES* brushProperties</b></param>
	/// <param name="gradientStopCollection">_In_ <b>ID2D1GradientStopCollection* gradientStopCollection</b></param>
	/// <param name="radialGradientBrush">_COM_Outptr_ <b>ID2D1RadialGradientBrush** radialGradientBrush</b></param>
	int CreateRadialGradientBrush<T0, T1> (RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, out T1* radialGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, IRadialGradientBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateCompatibleRenderTarget (D2D1_SIZE_F* desiredSize, D2D1_SIZE_U* desiredPixelSize, D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget)</b><br/>
	/// </summary>
	/// <param name="desiredSize">_In_opt_ <b>D2D1_SIZE_F* desiredSize</b></param>
	/// <param name="desiredPixelSize">_In_opt_ <b>D2D1_SIZE_U* desiredPixelSize</b></param>
	/// <param name="desiredFormat">_In_opt_ <b>D2D1_PIXEL_FORMAT* desiredFormat</b></param>
	/// <param name="options"><b>D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options</b></param>
	/// <param name="bitmapRenderTarget">_COM_Outptr_ <b>ID2D1BitmapRenderTarget** bitmapRenderTarget</b></param>
	int CreateCompatibleRenderTarget<T0> (Vector2F* desiredSize, Vector2U* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, T0** bitmapRenderTarget) where T0 : unmanaged, IBitmapRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateCompatibleRenderTarget (D2D1_SIZE_F* desiredSize, D2D1_SIZE_U* desiredPixelSize, D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget)</b><br/>
	/// </summary>
	/// <param name="desiredSize">_In_opt_ <b>D2D1_SIZE_F* desiredSize</b></param>
	/// <param name="desiredPixelSize">_In_opt_ <b>D2D1_SIZE_U* desiredPixelSize</b></param>
	/// <param name="desiredFormat">_In_opt_ <b>D2D1_PIXEL_FORMAT* desiredFormat</b></param>
	/// <param name="options"><b>D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options</b></param>
	/// <param name="bitmapRenderTarget">_COM_Outptr_ <b>ID2D1BitmapRenderTarget** bitmapRenderTarget</b></param>
	int CreateCompatibleRenderTarget<T0> (Vector2F* desiredSize, Vector2U* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, out T0* bitmapRenderTarget) where T0 : unmanaged, IBitmapRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateLayer (D2D1_SIZE_F* size, ID2D1Layer** layer)</b><br/>
	/// </summary>
	/// <param name="size">_In_opt_ <b>D2D1_SIZE_F* size</b></param>
	/// <param name="layer">_COM_Outptr_ <b>ID2D1Layer** layer</b></param>
	int CreateLayer<T0> (Vector2F* size, T0** layer) where T0 : unmanaged, ILayer;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateLayer (D2D1_SIZE_F* size, ID2D1Layer** layer)</b><br/>
	/// </summary>
	/// <param name="size">_In_opt_ <b>D2D1_SIZE_F* size</b></param>
	/// <param name="layer">_COM_Outptr_ <b>ID2D1Layer** layer</b></param>
	int CreateLayer<T0> (Vector2F* size, out T0* layer) where T0 : unmanaged, ILayer;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateMesh (ID2D1Mesh** mesh)</b><br/>
	/// </summary>
	/// <param name="mesh">_COM_Outptr_ <b>ID2D1Mesh** mesh</b></param>
	int CreateMesh<T0> (T0** mesh) where T0 : unmanaged, IMesh;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::CreateMesh (ID2D1Mesh** mesh)</b><br/>
	/// </summary>
	/// <param name="mesh">_COM_Outptr_ <b>ID2D1Mesh** mesh</b></param>
	int CreateMesh<T0> (out T0* mesh) where T0 : unmanaged, IMesh;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawLine (D2D1_POINT_2F point0, D2D1_POINT_2F point1, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="point0"><b>D2D1_POINT_2F point0</b></param>
	/// <param name="point1"><b>D2D1_POINT_2F point1</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	void DrawLine<T0, T1> (Vector2F point0, Vector2F point1, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawRectangle (D2D1_RECT_F* rect, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="rect">_In_ <b>D2D1_RECT_F* rect</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	void DrawRectangle<T0, T1> (Vector4F* rect, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::FillRectangle (D2D1_RECT_F* rect, ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="rect">_In_ <b>D2D1_RECT_F* rect</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	void FillRectangle<T0> (Vector4F* rect, T0* brush) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawRoundedRectangle (D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="roundedRect">_In_ <b>D2D1_ROUNDED_RECT* roundedRect</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	void DrawRoundedRectangle<T0, T1> (RoundedRect* roundedRect, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::FillRoundedRectangle (D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="roundedRect">_In_ <b>D2D1_ROUNDED_RECT* roundedRect</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	void FillRoundedRectangle<T0> (RoundedRect* roundedRect, T0* brush) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawEllipse (D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="ellipse">_In_ <b>D2D1_ELLIPSE* ellipse</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	void DrawEllipse<T0, T1> (Ellipse* ellipse, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::FillEllipse (D2D1_ELLIPSE* ellipse, ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="ellipse">_In_ <b>D2D1_ELLIPSE* ellipse</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	void FillEllipse<T0> (Ellipse* ellipse, T0* brush) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawGeometry (ID2D1Geometry* geometry, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	void DrawGeometry<T0, T1, T2> (T0* geometry, T1* brush, float strokeWidth, T2* strokeStyle) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::FillGeometry (ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="opacityBrush">_In_opt_ <b>ID2D1Brush* opacityBrush</b></param>
	void FillGeometry<T0, T1, T2> (T0* geometry, T1* brush, T2* opacityBrush) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::FillMesh (ID2D1Mesh* mesh, ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="mesh">_In_ <b>ID2D1Mesh* mesh</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	void FillMesh<T0, T1> (T0* mesh, T1* brush) where T0 : unmanaged, IMesh where T1 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::FillOpacityMask (ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, D2D1_RECT_F* destinationRectangle, D2D1_RECT_F* sourceRectangle)</b><br/>
	/// </summary>
	/// <param name="opacityMask">_In_ <b>ID2D1Bitmap* opacityMask</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	/// <param name="content"><b>D2D1_OPACITY_MASK_CONTENT content</b></param>
	/// <param name="destinationRectangle">_In_opt_ <b>D2D1_RECT_F* destinationRectangle</b></param>
	/// <param name="sourceRectangle">_In_opt_ <b>D2D1_RECT_F* sourceRectangle</b></param>
	void FillOpacityMask<T0, T1> (T0* opacityMask, T1* brush, OpacityMaskContent content, Vector4F* destinationRectangle, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawBitmap (ID2D1Bitmap* bitmap, D2D1_RECT_F* destinationRectangle, FLOAT opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_RECT_F* sourceRectangle)</b><br/>
	/// </summary>
	/// <param name="bitmap">_In_ <b>ID2D1Bitmap* bitmap</b></param>
	/// <param name="destinationRectangle">_In_opt_ <b>D2D1_RECT_F* destinationRectangle</b></param>
	/// <param name="opacity"><b>FLOAT opacity</b></param>
	/// <param name="interpolationMode"><b>D2D1_BITMAP_INTERPOLATION_MODE interpolationMode</b></param>
	/// <param name="sourceRectangle">_In_opt_ <b>D2D1_RECT_F* sourceRectangle</b></param>
	void DrawBitmap<T0> (T0* bitmap, Vector4F* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawText (WCHAR* string, UINT32 stringLength, IDWriteTextFormat* textFormat, D2D1_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)</b><br/>
	/// </summary>
	/// <param name="string">_In_reads_(stringLength) <b>WCHAR* string</b></param>
	/// <param name="stringLength"><b>UINT32 stringLength</b></param>
	/// <param name="textFormat">_In_ <b>IDWriteTextFormat* textFormat</b></param>
	/// <param name="layoutRect">_In_ <b>D2D1_RECT_F* layoutRect</b></param>
	/// <param name="defaultFillBrush">_In_ <b>ID2D1Brush* defaultFillBrush</b></param>
	/// <param name="options"><b>D2D1_DRAW_TEXT_OPTIONS options</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	void DrawText<T0, T1> (char* @string, uint stringLength, T0* textFormat, Vector4F* layoutRect, T1* defaultFillBrush, DrawTextOptions options, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, DirectWrite.ITextFormat where T1 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawTextLayout (D2D1_POINT_2F origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options)</b><br/>
	/// </summary>
	/// <param name="origin"><b>D2D1_POINT_2F origin</b></param>
	/// <param name="textLayout">_In_ <b>IDWriteTextLayout* textLayout</b></param>
	/// <param name="defaultFillBrush">_In_ <b>ID2D1Brush* defaultFillBrush</b></param>
	/// <param name="options"><b>D2D1_DRAW_TEXT_OPTIONS options</b></param>
	void DrawTextLayout<T0, T1> (Vector2F origin, T0* textLayout, T1* defaultFillBrush, DrawTextOptions options) where T0 : unmanaged, DirectWrite.ITextLayout where T1 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::DrawGlyphRun (D2D1_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode)</b><br/>
	/// </summary>
	/// <param name="baselineOrigin"><b>D2D1_POINT_2F baselineOrigin</b></param>
	/// <param name="glyphRun">_In_ <b>DWRITE_GLYPH_RUN* glyphRun</b></param>
	/// <param name="foregroundBrush">_In_ <b>ID2D1Brush* foregroundBrush</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	void DrawGlyphRun<T0> (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, T0* foregroundBrush, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::SetTransform (D2D1_MATRIX_3X2_F* transform)</b><br/>
	/// </summary>
	/// <param name="transform">_In_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	void SetTransform (Matrix3x2F* transform);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetTransform (D2D1_MATRIX_3X2_F* transform)</b><br/>
	/// </summary>
	/// <param name="transform">_Out_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	void GetTransform (Matrix3x2F* transform);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetTransform (D2D1_MATRIX_3X2_F* transform)</b><br/>
	/// </summary>
	/// <param name="transform">_Out_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	void GetTransform (out Matrix3x2F transform);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::SetAntialiasMode (D2D1_ANTIALIAS_MODE antialiasMode)</b><br/>
	/// </summary>
	/// <param name="antialiasMode"><b>D2D1_ANTIALIAS_MODE antialiasMode</b></param>
	void SetAntialiasMode (AntialiasMode antialiasMode);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_ANTIALIAS_MODE ID2D1RenderTarget::GetAntialiasMode ()</b><br/>
	/// </summary>
	AntialiasMode GetAntialiasMode ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::SetTextAntialiasMode (D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)</b><br/>
	/// </summary>
	/// <param name="textAntialiasMode"><b>D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode</b></param>
	void SetTextAntialiasMode (TextAntialiasMode textAntialiasMode);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_TEXT_ANTIALIAS_MODE ID2D1RenderTarget::GetTextAntialiasMode ()</b><br/>
	/// </summary>
	TextAntialiasMode GetTextAntialiasMode ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::SetTextRenderingParams (IDWriteRenderingParams* textRenderingParams)</b><br/>
	/// </summary>
	/// <param name="textRenderingParams">_In_opt_ <b>IDWriteRenderingParams* textRenderingParams</b></param>
	void SetTextRenderingParams<T0> (T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetTextRenderingParams (IDWriteRenderingParams** textRenderingParams)</b><br/>
	/// </summary>
	/// <param name="textRenderingParams">_Outptr_result_maybenull_ <b>IDWriteRenderingParams** textRenderingParams</b></param>
	void GetTextRenderingParams<T0> (T0** textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetTextRenderingParams (IDWriteRenderingParams** textRenderingParams)</b><br/>
	/// </summary>
	/// <param name="textRenderingParams">_Outptr_result_maybenull_ <b>IDWriteRenderingParams** textRenderingParams</b></param>
	void GetTextRenderingParams<T0> (out T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::SetTags (D2D1_TAG tag1, D2D1_TAG tag2)</b><br/>
	/// </summary>
	/// <param name="tag1"><b>D2D1_TAG tag1</b></param>
	/// <param name="tag2"><b>D2D1_TAG tag2</b></param>
	void SetTags (ulong tag1, ulong tag2);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetTags (D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	void GetTags (ulong* tag1, ulong* tag2);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetTags (D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	void GetTags (out ulong tag1, out ulong tag2);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::PushLayer (D2D1_LAYER_PARAMETERS* layerParameters, ID2D1Layer* layer)</b><br/>
	/// </summary>
	/// <param name="layerParameters">_In_ <b>D2D1_LAYER_PARAMETERS* layerParameters</b></param>
	/// <param name="layer">_In_opt_ <b>ID2D1Layer* layer</b></param>
	void PushLayer<T0> (LayerParameters* layerParameters, T0* layer) where T0 : unmanaged, ILayer;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::PopLayer ()</b><br/>
	/// </summary>
	void PopLayer ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::Flush (D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	int Flush (ulong* tag1, ulong* tag2);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::Flush (D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	int Flush (out ulong tag1, out ulong tag2);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::SaveDrawingState (ID2D1DrawingStateBlock* drawingStateBlock)</b><br/>
	/// </summary>
	/// <param name="drawingStateBlock">_Inout_ <b>ID2D1DrawingStateBlock* drawingStateBlock</b></param>
	void SaveDrawingState<T0> (T0* drawingStateBlock) where T0 : unmanaged, IDrawingStateBlock;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::RestoreDrawingState (ID2D1DrawingStateBlock* drawingStateBlock)</b><br/>
	/// </summary>
	/// <param name="drawingStateBlock">_In_ <b>ID2D1DrawingStateBlock* drawingStateBlock</b></param>
	void RestoreDrawingState<T0> (T0* drawingStateBlock) where T0 : unmanaged, IDrawingStateBlock;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::PushAxisAlignedClip (D2D1_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)</b><br/>
	/// </summary>
	/// <param name="clipRect">_In_ <b>D2D1_RECT_F* clipRect</b></param>
	/// <param name="antialiasMode"><b>D2D1_ANTIALIAS_MODE antialiasMode</b></param>
	void PushAxisAlignedClip (Vector4F* clipRect, AntialiasMode antialiasMode);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::PopAxisAlignedClip ()</b><br/>
	/// </summary>
	void PopAxisAlignedClip ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::Clear (D2D1_COLOR_F* clearColor)</b><br/>
	/// </summary>
	/// <param name="clearColor">_In_opt_ <b>D2D1_COLOR_F* clearColor</b></param>
	void Clear (Vector4F* clearColor);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::BeginDraw ()</b><br/>
	/// </summary>
	void BeginDraw ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::EndDraw (D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	int EndDraw (ulong* tag1, ulong* tag2);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderTarget::EndDraw (D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	int EndDraw (out ulong tag1, out ulong tag2);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_PIXEL_FORMAT ID2D1RenderTarget::GetPixelFormat ()</b><br/>
	/// </summary>
	PixelFormat GetPixelFormat ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::SetDpi (FLOAT dpiX, FLOAT dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX"><b>FLOAT dpiX</b></param>
	/// <param name="dpiY"><b>FLOAT dpiY</b></param>
	void SetDpi (float dpiX, float dpiY);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDpi (float* dpiX, float* dpiY);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderTarget::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDpi (out float dpiX, out float dpiY);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_SIZE_F ID2D1RenderTarget::GetSize ()</b><br/>
	/// </summary>
	Vector2F GetSize ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_SIZE_U ID2D1RenderTarget::GetPixelSize ()</b><br/>
	/// </summary>
	Vector2U GetPixelSize ();
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1RenderTarget::GetMaximumBitmapSize ()</b><br/>
	/// </summary>
	uint GetMaximumBitmapSize ();
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1RenderTarget::IsSupported (D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)</b><br/>
	/// </summary>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	bool IsSupported (RenderTargetProperties* renderTargetProperties);
}

/// <summary>
/// Instance of <b>ID2D1RenderTarget</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct RenderTarget : IRenderTarget {
//unsafe public readonly struct IRenderTargetObj : IRenderTarget {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly RenderTarget* GetCurrentPointer () => (RenderTarget*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IRenderTargetObj* GetCurrentPointer () => (IRenderTargetObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd90694, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	public readonly void GetFactory<T0> (T0** factory) where T0 : unmanaged, IFactory {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) factory);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFactory<T0> (out T0* factory) where T0 : unmanaged, IFactory {
		fixed (T0** _factory = &factory) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) _factory);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmap<T0> (Vector2U size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, T0** bitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap (ptr, size, srcData, pitch, bitmapProperties, (void**) bitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmap<T0> (Vector2U size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, out T0* bitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _bitmap = &bitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap (ptr, size, srcData, pitch, bitmapProperties, (void**) _bitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromWicBitmap<T0, T1> (T0* wicBitmapSource, BitmapProperties* bitmapProperties, T1** bitmap) where T0 : unmanaged, WIC.IBitmapSource where T1 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromWicBitmap (ptr, wicBitmapSource, bitmapProperties, (void**) bitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromWicBitmap<T0, T1> (T0* wicBitmapSource, BitmapProperties* bitmapProperties, out T1* bitmap) where T0 : unmanaged, WIC.IBitmapSource where T1 : unmanaged, IBitmap {
		fixed (T1** _bitmap = &bitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromWicBitmap (ptr, wicBitmapSource, bitmapProperties, (void**) _bitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedBitmap<T0> (Guid riid, void* data, BitmapProperties* bitmapProperties, T0** bitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedBitmap (ptr, riid, data, bitmapProperties, (void**) bitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedBitmap<T0> (Guid riid, void* data, BitmapProperties* bitmapProperties, out T0* bitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _bitmap = &bitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedBitmap (ptr, riid, data, bitmapProperties, (void**) _bitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapBrush<T0, T1> (T0* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, T1** bitmapBrush) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBitmapBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapBrush (ptr, bitmap, bitmapBrushProperties, brushProperties, (void**) bitmapBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapBrush<T0, T1> (T0* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, out T1* bitmapBrush) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBitmapBrush {
		fixed (T1** _bitmapBrush = &bitmapBrush) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapBrush (ptr, bitmap, bitmapBrushProperties, brushProperties, (void**) _bitmapBrush);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSolidColorBrush<T0> (Vector4F* color, BrushProperties* brushProperties, T0** solidColorBrush) where T0 : unmanaged, ISolidColorBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSolidColorBrush (ptr, color, brushProperties, (void**) solidColorBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSolidColorBrush<T0> (Vector4F* color, BrushProperties* brushProperties, out T0* solidColorBrush) where T0 : unmanaged, ISolidColorBrush {
		fixed (T0** _solidColorBrush = &solidColorBrush) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSolidColorBrush (ptr, color, brushProperties, (void**) _solidColorBrush);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGradientStopCollection<T0> (GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, T0** gradientStopCollection) where T0 : unmanaged, IGradientStopCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGradientStopCollection (ptr, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, (void**) gradientStopCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGradientStopCollection<T0> (GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, out T0* gradientStopCollection) where T0 : unmanaged, IGradientStopCollection {
		fixed (T0** _gradientStopCollection = &gradientStopCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGradientStopCollection (ptr, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, (void**) _gradientStopCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateLinearGradientBrush<T0, T1> (LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, T1** linearGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, ILinearGradientBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateLinearGradientBrush (ptr, linearGradientBrushProperties, brushProperties, gradientStopCollection, (void**) linearGradientBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateLinearGradientBrush<T0, T1> (LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, out T1* linearGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, ILinearGradientBrush {
		fixed (T1** _linearGradientBrush = &linearGradientBrush) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateLinearGradientBrush (ptr, linearGradientBrushProperties, brushProperties, gradientStopCollection, (void**) _linearGradientBrush);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRadialGradientBrush<T0, T1> (RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, T1** radialGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, IRadialGradientBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRadialGradientBrush (ptr, radialGradientBrushProperties, brushProperties, gradientStopCollection, (void**) radialGradientBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRadialGradientBrush<T0, T1> (RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, T0* gradientStopCollection, out T1* radialGradientBrush) where T0 : unmanaged, IGradientStopCollection where T1 : unmanaged, IRadialGradientBrush {
		fixed (T1** _radialGradientBrush = &radialGradientBrush) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRadialGradientBrush (ptr, radialGradientBrushProperties, brushProperties, gradientStopCollection, (void**) _radialGradientBrush);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCompatibleRenderTarget<T0> (Vector2F* desiredSize, Vector2U* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, T0** bitmapRenderTarget) where T0 : unmanaged, IBitmapRenderTarget {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCompatibleRenderTarget (ptr, desiredSize, desiredPixelSize, desiredFormat, options, (void**) bitmapRenderTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCompatibleRenderTarget<T0> (Vector2F* desiredSize, Vector2U* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, out T0* bitmapRenderTarget) where T0 : unmanaged, IBitmapRenderTarget {
		fixed (T0** _bitmapRenderTarget = &bitmapRenderTarget) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCompatibleRenderTarget (ptr, desiredSize, desiredPixelSize, desiredFormat, options, (void**) _bitmapRenderTarget);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateLayer<T0> (Vector2F* size, T0** layer) where T0 : unmanaged, ILayer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateLayer (ptr, size, (void**) layer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateLayer<T0> (Vector2F* size, out T0* layer) where T0 : unmanaged, ILayer {
		fixed (T0** _layer = &layer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateLayer (ptr, size, (void**) _layer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMesh<T0> (T0** mesh) where T0 : unmanaged, IMesh {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateMesh (ptr, (void**) mesh);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateMesh<T0> (out T0* mesh) where T0 : unmanaged, IMesh {
		fixed (T0** _mesh = &mesh) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateMesh (ptr, (void**) _mesh);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawLine<T0, T1> (Vector2F point0, Vector2F point1, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawLine (ptr, point0, point1, brush, strokeWidth, strokeStyle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawRectangle<T0, T1> (Vector4F* rect, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawRectangle (ptr, rect, brush, strokeWidth, strokeStyle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FillRectangle<T0> (Vector4F* rect, T0* brush) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FillRectangle (ptr, rect, brush);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawRoundedRectangle<T0, T1> (RoundedRect* roundedRect, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawRoundedRectangle (ptr, roundedRect, brush, strokeWidth, strokeStyle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FillRoundedRectangle<T0> (RoundedRect* roundedRect, T0* brush) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FillRoundedRectangle (ptr, roundedRect, brush);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawEllipse<T0, T1> (Ellipse* ellipse, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawEllipse (ptr, ellipse, brush, strokeWidth, strokeStyle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FillEllipse<T0> (Ellipse* ellipse, T0* brush) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FillEllipse (ptr, ellipse, brush);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawGeometry<T0, T1, T2> (T0* geometry, T1* brush, float strokeWidth, T2* strokeStyle) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawGeometry (ptr, geometry, brush, strokeWidth, strokeStyle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FillGeometry<T0, T1, T2> (T0* geometry, T1* brush, T2* opacityBrush) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FillGeometry (ptr, geometry, brush, opacityBrush);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FillMesh<T0, T1> (T0* mesh, T1* brush) where T0 : unmanaged, IMesh where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FillMesh (ptr, mesh, brush);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FillOpacityMask<T0, T1> (T0* opacityMask, T1* brush, OpacityMaskContent content, Vector4F* destinationRectangle, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FillOpacityMask (ptr, opacityMask, brush, content, destinationRectangle, sourceRectangle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawBitmap<T0> (T0* bitmap, Vector4F* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawBitmap (ptr, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawText<T0, T1> (char* @string, uint stringLength, T0* textFormat, Vector4F* layoutRect, T1* defaultFillBrush, DrawTextOptions options, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, DirectWrite.ITextFormat where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawText (ptr, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawTextLayout<T0, T1> (Vector2F origin, T0* textLayout, T1* defaultFillBrush, DrawTextOptions options) where T0 : unmanaged, DirectWrite.ITextLayout where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawTextLayout (ptr, origin, textLayout, defaultFillBrush, options);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawGlyphRun<T0> (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, T0* foregroundBrush, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawGlyphRun (ptr, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetTransform (ptr, transform);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetTransform (ptr, transform);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTransform (out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetTransform (ptr, _transform);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetAntialiasMode (AntialiasMode antialiasMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetAntialiasMode (ptr, antialiasMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly AntialiasMode GetAntialiasMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAntialiasMode (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetTextAntialiasMode (TextAntialiasMode textAntialiasMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetTextAntialiasMode (ptr, textAntialiasMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly TextAntialiasMode GetTextAntialiasMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextAntialiasMode (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetTextRenderingParams<T0> (T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetTextRenderingParams (ptr, textRenderingParams);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTextRenderingParams<T0> (T0** textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetTextRenderingParams (ptr, (void**) textRenderingParams);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTextRenderingParams<T0> (out T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		fixed (T0** _textRenderingParams = &textRenderingParams) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetTextRenderingParams (ptr, (void**) _textRenderingParams);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetTags (ulong tag1, ulong tag2) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetTags (ptr, tag1, tag2);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTags (ulong* tag1, ulong* tag2) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetTags (ptr, tag1, tag2);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTags (out ulong tag1, out ulong tag2) {
		fixed (ulong* _tag1 = &tag1) {
			fixed (ulong* _tag2 = &tag2) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->GetTags (ptr, _tag1, _tag2);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PushLayer<T0> (LayerParameters* layerParameters, T0* layer) where T0 : unmanaged, ILayer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PushLayer (ptr, layerParameters, layer);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PopLayer () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PopLayer (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Flush (ulong* tag1, ulong* tag2) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Flush (ptr, tag1, tag2);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Flush (out ulong tag1, out ulong tag2) {
		fixed (ulong* _tag1 = &tag1) {
			fixed (ulong* _tag2 = &tag2) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->Flush (ptr, _tag1, _tag2);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SaveDrawingState<T0> (T0* drawingStateBlock) where T0 : unmanaged, IDrawingStateBlock {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SaveDrawingState (ptr, drawingStateBlock);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void RestoreDrawingState<T0> (T0* drawingStateBlock) where T0 : unmanaged, IDrawingStateBlock {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->RestoreDrawingState (ptr, drawingStateBlock);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PushAxisAlignedClip (Vector4F* clipRect, AntialiasMode antialiasMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PushAxisAlignedClip (ptr, clipRect, antialiasMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PopAxisAlignedClip () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PopAxisAlignedClip (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Clear (Vector4F* clearColor) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Clear (ptr, clearColor);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void BeginDraw () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->BeginDraw (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EndDraw (ulong* tag1, ulong* tag2) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EndDraw (ptr, tag1, tag2);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EndDraw (out ulong tag1, out ulong tag2) {
		fixed (ulong* _tag1 = &tag1) {
			fixed (ulong* _tag2 = &tag2) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->EndDraw (ptr, _tag1, _tag2);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly PixelFormat GetPixelFormat () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetDpi (float dpiX, float dpiY) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetDpi (ptr, dpiX, dpiY);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDpi (float* dpiX, float* dpiY) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDpi (ptr, dpiX, dpiY);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDpi (out float dpiX, out float dpiY) {
		fixed (float* _dpiX = &dpiX) {
			fixed (float* _dpiY = &dpiY) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->GetDpi (ptr, _dpiX, _dpiY);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2F GetSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2U GetPixelSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetMaximumBitmapSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMaximumBitmapSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsSupported (RenderTargetProperties* renderTargetProperties) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsSupported (ptr, renderTargetProperties) != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFactory;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2U, void*, uint, BitmapProperties*, void**, int> CreateBitmap;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, BitmapProperties*, void**, int> CreateBitmapFromWicBitmap;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, BitmapProperties*, void**, int> CreateSharedBitmap;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, BitmapBrushProperties*, BrushProperties*, void**, int> CreateBitmapBrush;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, BrushProperties*, void**, int> CreateSolidColorBrush;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GradientStop*, uint, Gamma, ExtendMode, void**, int> CreateGradientStopCollection;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LinearGradientBrushProperties*, BrushProperties*, void*, void**, int> CreateLinearGradientBrush;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RadialGradientBrushProperties*, BrushProperties*, void*, void**, int> CreateRadialGradientBrush;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F*, Vector2U*, PixelFormat*, CompatibleRenderTargetOptions, void**, int> CreateCompatibleRenderTarget;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F*, void**, int> CreateLayer;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateMesh;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, Vector2F, void*, float, void*, void> DrawLine;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void*, float, void*, void> DrawRectangle;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void*, void> FillRectangle;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RoundedRect*, void*, float, void*, void> DrawRoundedRectangle;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RoundedRect*, void*, void> FillRoundedRectangle;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Ellipse*, void*, float, void*, void> DrawEllipse;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Ellipse*, void*, void> FillEllipse;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, float, void*, void> DrawGeometry;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, void> FillGeometry;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void> FillMesh;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, OpacityMaskContent, Vector4F*, Vector4F*, void> FillOpacityMask;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, float, BitmapInterpolationMode, Vector4F*, void> DrawBitmap;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, void*, Vector4F*, void*, DrawTextOptions, DirectWrite.MeasuringMode, void> DrawText;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, void*, void*, DrawTextOptions, void> DrawTextLayout;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, DirectWrite.GlyphRun*, void*, DirectWrite.MeasuringMode, void> DrawGlyphRun;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, void> SetTransform;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, void> GetTransform;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AntialiasMode, void> SetAntialiasMode;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AntialiasMode> GetAntialiasMode;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextAntialiasMode, void> SetTextAntialiasMode;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextAntialiasMode> GetTextAntialiasMode;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetTextRenderingParams;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetTextRenderingParams;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, void> SetTags;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, ulong*, void> GetTags;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LayerParameters*, void*, void> PushLayer;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> PopLayer;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, ulong*, int> Flush;
		/// <summary>
		/// OFFSET 43
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SaveDrawingState;
		/// <summary>
		/// OFFSET 44
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> RestoreDrawingState;
		/// <summary>
		/// OFFSET 45
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, AntialiasMode, void> PushAxisAlignedClip;
		/// <summary>
		/// OFFSET 46
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> PopAxisAlignedClip;
		/// <summary>
		/// OFFSET 47
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void> Clear;
		/// <summary>
		/// OFFSET 48
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> BeginDraw;
		/// <summary>
		/// OFFSET 49
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, ulong*, int> EndDraw;
		/// <summary>
		/// OFFSET 50
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PixelFormat> GetPixelFormat;
		/// <summary>
		/// OFFSET 51
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, float, void> SetDpi;
		/// <summary>
		/// OFFSET 52
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, float*, void> GetDpi;
		/// <summary>
		/// OFFSET 53
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F> GetSize;
		/// <summary>
		/// OFFSET 54
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2U> GetPixelSize;
		/// <summary>
		/// OFFSET 55
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetMaximumBitmapSize;
		/// <summary>
		/// OFFSET 56
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RenderTargetProperties*, uint> IsSupported;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
