using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Factory</b> : IUnknown<br/>
/// D2D1.h
/// </summary>
unsafe public interface IFactory : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::ReloadSystemMetrics ()</b><br/>
	/// </summary>
	int ReloadSystemMetrics ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Factory::GetDesktopDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDesktopDpi (float* dpiX, float* dpiY);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Factory::GetDesktopDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	void GetDesktopDpi (out float dpiX, out float dpiY);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateRectangleGeometry (D2D1_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry)</b><br/>
	/// </summary>
	/// <param name="rectangle">_In_ <b>D2D1_RECT_F* rectangle</b></param>
	/// <param name="rectangleGeometry">_COM_Outptr_ <b>ID2D1RectangleGeometry** rectangleGeometry</b></param>
	int CreateRectangleGeometry<T0> (Vector4F* rectangle, T0** rectangleGeometry) where T0 : unmanaged, IRectangleGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateRectangleGeometry (D2D1_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry)</b><br/>
	/// </summary>
	/// <param name="rectangle">_In_ <b>D2D1_RECT_F* rectangle</b></param>
	/// <param name="rectangleGeometry">_COM_Outptr_ <b>ID2D1RectangleGeometry** rectangleGeometry</b></param>
	int CreateRectangleGeometry<T0> (Vector4F* rectangle, out T0* rectangleGeometry) where T0 : unmanaged, IRectangleGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateRoundedRectangleGeometry (D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)</b><br/>
	/// </summary>
	/// <param name="roundedRectangle">_In_ <b>D2D1_ROUNDED_RECT* roundedRectangle</b></param>
	/// <param name="roundedRectangleGeometry">_COM_Outptr_ <b>ID2D1RoundedRectangleGeometry** roundedRectangleGeometry</b></param>
	int CreateRoundedRectangleGeometry<T0> (RoundedRect* roundedRectangle, T0** roundedRectangleGeometry) where T0 : unmanaged, IRoundedRectangleGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateRoundedRectangleGeometry (D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)</b><br/>
	/// </summary>
	/// <param name="roundedRectangle">_In_ <b>D2D1_ROUNDED_RECT* roundedRectangle</b></param>
	/// <param name="roundedRectangleGeometry">_COM_Outptr_ <b>ID2D1RoundedRectangleGeometry** roundedRectangleGeometry</b></param>
	int CreateRoundedRectangleGeometry<T0> (RoundedRect* roundedRectangle, out T0* roundedRectangleGeometry) where T0 : unmanaged, IRoundedRectangleGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateEllipseGeometry (D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry)</b><br/>
	/// </summary>
	/// <param name="ellipse">_In_ <b>D2D1_ELLIPSE* ellipse</b></param>
	/// <param name="ellipseGeometry">_COM_Outptr_ <b>ID2D1EllipseGeometry** ellipseGeometry</b></param>
	int CreateEllipseGeometry<T0> (Ellipse* ellipse, T0** ellipseGeometry) where T0 : unmanaged, IEllipseGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateEllipseGeometry (D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry)</b><br/>
	/// </summary>
	/// <param name="ellipse">_In_ <b>D2D1_ELLIPSE* ellipse</b></param>
	/// <param name="ellipseGeometry">_COM_Outptr_ <b>ID2D1EllipseGeometry** ellipseGeometry</b></param>
	int CreateEllipseGeometry<T0> (Ellipse* ellipse, out T0* ellipseGeometry) where T0 : unmanaged, IEllipseGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateGeometryGroup (D2D1_FILL_MODE fillMode, ID2D1Geometry** geometries, UINT32 geometriesCount, ID2D1GeometryGroup** geometryGroup)</b><br/>
	/// </summary>
	/// <param name="fillMode"><b>D2D1_FILL_MODE fillMode</b></param>
	/// <param name="geometries">_In_reads_(geometriesCount) <b>ID2D1Geometry** geometries</b></param>
	/// <param name="geometriesCount"><b>UINT32 geometriesCount</b></param>
	/// <param name="geometryGroup">_COM_Outptr_ <b>ID2D1GeometryGroup** geometryGroup</b></param>
	int CreateGeometryGroup<T0, T1> (FillMode fillMode, T0** geometries, uint geometriesCount, T1** geometryGroup) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryGroup;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateGeometryGroup (D2D1_FILL_MODE fillMode, ID2D1Geometry** geometries, UINT32 geometriesCount, ID2D1GeometryGroup** geometryGroup)</b><br/>
	/// </summary>
	/// <param name="fillMode"><b>D2D1_FILL_MODE fillMode</b></param>
	/// <param name="geometries">_In_reads_(geometriesCount) <b>ID2D1Geometry** geometries</b></param>
	/// <param name="geometriesCount"><b>UINT32 geometriesCount</b></param>
	/// <param name="geometryGroup">_COM_Outptr_ <b>ID2D1GeometryGroup** geometryGroup</b></param>
	int CreateGeometryGroup<T0, T1> (FillMode fillMode, T0** geometries, uint geometriesCount, out T1* geometryGroup) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryGroup;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateTransformedGeometry (ID2D1Geometry* sourceGeometry, D2D1_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry)</b><br/>
	/// </summary>
	/// <param name="sourceGeometry">_In_ <b>ID2D1Geometry* sourceGeometry</b></param>
	/// <param name="transform">_In_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	/// <param name="transformedGeometry">_COM_Outptr_ <b>ID2D1TransformedGeometry** transformedGeometry</b></param>
	int CreateTransformedGeometry<T0, T1> (T0* sourceGeometry, Matrix3x2F* transform, T1** transformedGeometry) where T0 : unmanaged, IGeometry where T1 : unmanaged, ITransformedGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateTransformedGeometry (ID2D1Geometry* sourceGeometry, D2D1_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry)</b><br/>
	/// </summary>
	/// <param name="sourceGeometry">_In_ <b>ID2D1Geometry* sourceGeometry</b></param>
	/// <param name="transform">_In_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	/// <param name="transformedGeometry">_COM_Outptr_ <b>ID2D1TransformedGeometry** transformedGeometry</b></param>
	int CreateTransformedGeometry<T0, T1> (T0* sourceGeometry, Matrix3x2F* transform, out T1* transformedGeometry) where T0 : unmanaged, IGeometry where T1 : unmanaged, ITransformedGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreatePathGeometry (ID2D1PathGeometry** pathGeometry)</b><br/>
	/// </summary>
	/// <param name="pathGeometry">_COM_Outptr_ <b>ID2D1PathGeometry** pathGeometry</b></param>
	int CreatePathGeometry<T0> (T0** pathGeometry) where T0 : unmanaged, IPathGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreatePathGeometry (ID2D1PathGeometry** pathGeometry)</b><br/>
	/// </summary>
	/// <param name="pathGeometry">_COM_Outptr_ <b>ID2D1PathGeometry** pathGeometry</b></param>
	int CreatePathGeometry<T0> (out T0* pathGeometry) where T0 : unmanaged, IPathGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateStrokeStyle (D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, FLOAT* dashes, UINT32 dashesCount, ID2D1StrokeStyle** strokeStyle)</b><br/>
	/// </summary>
	/// <param name="strokeStyleProperties">_In_ <b>D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties</b></param>
	/// <param name="dashes">_In_reads_opt_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="strokeStyle">_COM_Outptr_ <b>ID2D1StrokeStyle** strokeStyle</b></param>
	int CreateStrokeStyle<T0> (StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, T0** strokeStyle) where T0 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateStrokeStyle (D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, FLOAT* dashes, UINT32 dashesCount, ID2D1StrokeStyle** strokeStyle)</b><br/>
	/// </summary>
	/// <param name="strokeStyleProperties">_In_ <b>D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties</b></param>
	/// <param name="dashes">_In_reads_opt_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="strokeStyle">_COM_Outptr_ <b>ID2D1StrokeStyle** strokeStyle</b></param>
	int CreateStrokeStyle<T0> (StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, out T0* strokeStyle) where T0 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateDrawingStateBlock (D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)</b><br/>
	/// </summary>
	/// <param name="drawingStateDescription">_In_opt_ <b>D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription</b></param>
	/// <param name="textRenderingParams">_In_opt_ <b>IDWriteRenderingParams* textRenderingParams</b></param>
	/// <param name="drawingStateBlock">_COM_Outptr_ <b>ID2D1DrawingStateBlock** drawingStateBlock</b></param>
	int CreateDrawingStateBlock<T0, T1> (DrawingStateDescription* drawingStateDescription, T0* textRenderingParams, T1** drawingStateBlock) where T0 : unmanaged, DirectWrite.IRenderingParams where T1 : unmanaged, IDrawingStateBlock;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateDrawingStateBlock (D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)</b><br/>
	/// </summary>
	/// <param name="drawingStateDescription">_In_opt_ <b>D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription</b></param>
	/// <param name="textRenderingParams">_In_opt_ <b>IDWriteRenderingParams* textRenderingParams</b></param>
	/// <param name="drawingStateBlock">_COM_Outptr_ <b>ID2D1DrawingStateBlock** drawingStateBlock</b></param>
	int CreateDrawingStateBlock<T0, T1> (DrawingStateDescription* drawingStateDescription, T0* textRenderingParams, out T1* drawingStateBlock) where T0 : unmanaged, DirectWrite.IRenderingParams where T1 : unmanaged, IDrawingStateBlock;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateWicBitmapRenderTarget (IWICBitmap* target, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)</b><br/>
	/// </summary>
	/// <param name="target">_In_ <b>IWICBitmap* target</b></param>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="renderTarget">_COM_Outptr_ <b>ID2D1RenderTarget** renderTarget</b></param>
	int CreateWicBitmapRenderTarget<T0, T1> (T0* target, RenderTargetProperties* renderTargetProperties, T1** renderTarget) where T0 : unmanaged, WIC.IBitmap where T1 : unmanaged, IRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateWicBitmapRenderTarget (IWICBitmap* target, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)</b><br/>
	/// </summary>
	/// <param name="target">_In_ <b>IWICBitmap* target</b></param>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="renderTarget">_COM_Outptr_ <b>ID2D1RenderTarget** renderTarget</b></param>
	int CreateWicBitmapRenderTarget<T0, T1> (T0* target, RenderTargetProperties* renderTargetProperties, out T1* renderTarget) where T0 : unmanaged, WIC.IBitmap where T1 : unmanaged, IRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateHwndRenderTarget (D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)</b><br/>
	/// </summary>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="hwndRenderTargetProperties">_In_ <b>D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties</b></param>
	/// <param name="hwndRenderTarget">_COM_Outptr_ <b>ID2D1HwndRenderTarget** hwndRenderTarget</b></param>
	int CreateHwndRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, T0** hwndRenderTarget) where T0 : unmanaged, IHwndRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateHwndRenderTarget (D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)</b><br/>
	/// </summary>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="hwndRenderTargetProperties">_In_ <b>D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties</b></param>
	/// <param name="hwndRenderTarget">_COM_Outptr_ <b>ID2D1HwndRenderTarget** hwndRenderTarget</b></param>
	int CreateHwndRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, out T0* hwndRenderTarget) where T0 : unmanaged, IHwndRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateDxgiSurfaceRenderTarget (IDXGISurface* dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)</b><br/>
	/// </summary>
	/// <param name="dxgiSurface">_In_ <b>IDXGISurface* dxgiSurface</b></param>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="renderTarget">_COM_Outptr_ <b>ID2D1RenderTarget** renderTarget</b></param>
	int CreateDxgiSurfaceRenderTarget<T0, T1> (T0* dxgiSurface, RenderTargetProperties* renderTargetProperties, T1** renderTarget) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateDxgiSurfaceRenderTarget (IDXGISurface* dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)</b><br/>
	/// </summary>
	/// <param name="dxgiSurface">_In_ <b>IDXGISurface* dxgiSurface</b></param>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="renderTarget">_COM_Outptr_ <b>ID2D1RenderTarget** renderTarget</b></param>
	int CreateDxgiSurfaceRenderTarget<T0, T1> (T0* dxgiSurface, RenderTargetProperties* renderTargetProperties, out T1* renderTarget) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateDCRenderTarget (D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)</b><br/>
	/// </summary>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="dcRenderTarget">_COM_Outptr_ <b>ID2D1DCRenderTarget** dcRenderTarget</b></param>
	int CreateDCRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, T0** dcRenderTarget) where T0 : unmanaged, IDCRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory::CreateDCRenderTarget (D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)</b><br/>
	/// </summary>
	/// <param name="renderTargetProperties">_In_ <b>D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties</b></param>
	/// <param name="dcRenderTarget">_COM_Outptr_ <b>ID2D1DCRenderTarget** dcRenderTarget</b></param>
	int CreateDCRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, out T0* dcRenderTarget) where T0 : unmanaged, IDCRenderTarget;
}

/// <summary>
/// Instance of <b>ID2D1Factory</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct Factory : IFactory {
//unsafe public readonly struct IFactoryObj : IFactory {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Factory* GetCurrentPointer () => (Factory*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFactoryObj* GetCurrentPointer () => (IFactoryObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x06152247, 0x6f50, 0x465a, 0x92, 0x45, 0x11, 0x8b, 0xfd, 0x3b, 0x60, 0x07);

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
	public readonly int ReloadSystemMetrics () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReloadSystemMetrics (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesktopDpi (float* dpiX, float* dpiY) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDesktopDpi (ptr, dpiX, dpiY);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesktopDpi (out float dpiX, out float dpiY) {
		fixed (float* _dpiX = &dpiX) {
			fixed (float* _dpiY = &dpiY) {
				var ptr = GetCurrentPointer ();
				((FunctionPointer*) ptr->_pointer)->GetDesktopDpi (ptr, _dpiX, _dpiY);
				return;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRectangleGeometry<T0> (Vector4F* rectangle, T0** rectangleGeometry) where T0 : unmanaged, IRectangleGeometry {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRectangleGeometry (ptr, rectangle, (void**) rectangleGeometry);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRectangleGeometry<T0> (Vector4F* rectangle, out T0* rectangleGeometry) where T0 : unmanaged, IRectangleGeometry {
		fixed (T0** _rectangleGeometry = &rectangleGeometry) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRectangleGeometry (ptr, rectangle, (void**) _rectangleGeometry);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRoundedRectangleGeometry<T0> (RoundedRect* roundedRectangle, T0** roundedRectangleGeometry) where T0 : unmanaged, IRoundedRectangleGeometry {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateRoundedRectangleGeometry (ptr, roundedRectangle, (void**) roundedRectangleGeometry);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateRoundedRectangleGeometry<T0> (RoundedRect* roundedRectangle, out T0* roundedRectangleGeometry) where T0 : unmanaged, IRoundedRectangleGeometry {
		fixed (T0** _roundedRectangleGeometry = &roundedRectangleGeometry) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateRoundedRectangleGeometry (ptr, roundedRectangle, (void**) _roundedRectangleGeometry);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEllipseGeometry<T0> (Ellipse* ellipse, T0** ellipseGeometry) where T0 : unmanaged, IEllipseGeometry {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateEllipseGeometry (ptr, ellipse, (void**) ellipseGeometry);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEllipseGeometry<T0> (Ellipse* ellipse, out T0* ellipseGeometry) where T0 : unmanaged, IEllipseGeometry {
		fixed (T0** _ellipseGeometry = &ellipseGeometry) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateEllipseGeometry (ptr, ellipse, (void**) _ellipseGeometry);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGeometryGroup<T0, T1> (FillMode fillMode, T0** geometries, uint geometriesCount, T1** geometryGroup) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryGroup {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGeometryGroup (ptr, fillMode, (void**) geometries, geometriesCount, (void**) geometryGroup);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGeometryGroup<T0, T1> (FillMode fillMode, T0** geometries, uint geometriesCount, out T1* geometryGroup) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryGroup {
		fixed (T1** _geometryGroup = &geometryGroup) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGeometryGroup (ptr, fillMode, (void**) geometries, geometriesCount, (void**) _geometryGroup);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTransformedGeometry<T0, T1> (T0* sourceGeometry, Matrix3x2F* transform, T1** transformedGeometry) where T0 : unmanaged, IGeometry where T1 : unmanaged, ITransformedGeometry {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateTransformedGeometry (ptr, sourceGeometry, transform, (void**) transformedGeometry);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateTransformedGeometry<T0, T1> (T0* sourceGeometry, Matrix3x2F* transform, out T1* transformedGeometry) where T0 : unmanaged, IGeometry where T1 : unmanaged, ITransformedGeometry {
		fixed (T1** _transformedGeometry = &transformedGeometry) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateTransformedGeometry (ptr, sourceGeometry, transform, (void**) _transformedGeometry);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathGeometry<T0> (T0** pathGeometry) where T0 : unmanaged, IPathGeometry {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathGeometry (ptr, (void**) pathGeometry);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathGeometry<T0> (out T0* pathGeometry) where T0 : unmanaged, IPathGeometry {
		fixed (T0** _pathGeometry = &pathGeometry) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathGeometry (ptr, (void**) _pathGeometry);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokeStyle<T0> (StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, T0** strokeStyle) where T0 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokeStyle (ptr, strokeStyleProperties, dashes, dashesCount, (void**) strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokeStyle<T0> (StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, out T0* strokeStyle) where T0 : unmanaged, IStrokeStyle {
		fixed (T0** _strokeStyle = &strokeStyle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokeStyle (ptr, strokeStyleProperties, dashes, dashesCount, (void**) _strokeStyle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDrawingStateBlock<T0, T1> (DrawingStateDescription* drawingStateDescription, T0* textRenderingParams, T1** drawingStateBlock) where T0 : unmanaged, DirectWrite.IRenderingParams where T1 : unmanaged, IDrawingStateBlock {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDrawingStateBlock (ptr, drawingStateDescription, textRenderingParams, (void**) drawingStateBlock);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDrawingStateBlock<T0, T1> (DrawingStateDescription* drawingStateDescription, T0* textRenderingParams, out T1* drawingStateBlock) where T0 : unmanaged, DirectWrite.IRenderingParams where T1 : unmanaged, IDrawingStateBlock {
		fixed (T1** _drawingStateBlock = &drawingStateBlock) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDrawingStateBlock (ptr, drawingStateDescription, textRenderingParams, (void**) _drawingStateBlock);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateWicBitmapRenderTarget<T0, T1> (T0* target, RenderTargetProperties* renderTargetProperties, T1** renderTarget) where T0 : unmanaged, WIC.IBitmap where T1 : unmanaged, IRenderTarget {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateWicBitmapRenderTarget (ptr, target, renderTargetProperties, (void**) renderTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateWicBitmapRenderTarget<T0, T1> (T0* target, RenderTargetProperties* renderTargetProperties, out T1* renderTarget) where T0 : unmanaged, WIC.IBitmap where T1 : unmanaged, IRenderTarget {
		fixed (T1** _renderTarget = &renderTarget) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateWicBitmapRenderTarget (ptr, target, renderTargetProperties, (void**) _renderTarget);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHwndRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, T0** hwndRenderTarget) where T0 : unmanaged, IHwndRenderTarget {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateHwndRenderTarget (ptr, renderTargetProperties, hwndRenderTargetProperties, (void**) hwndRenderTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateHwndRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, out T0* hwndRenderTarget) where T0 : unmanaged, IHwndRenderTarget {
		fixed (T0** _hwndRenderTarget = &hwndRenderTarget) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateHwndRenderTarget (ptr, renderTargetProperties, hwndRenderTargetProperties, (void**) _hwndRenderTarget);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDxgiSurfaceRenderTarget<T0, T1> (T0* dxgiSurface, RenderTargetProperties* renderTargetProperties, T1** renderTarget) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IRenderTarget {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDxgiSurfaceRenderTarget (ptr, dxgiSurface, renderTargetProperties, (void**) renderTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDxgiSurfaceRenderTarget<T0, T1> (T0* dxgiSurface, RenderTargetProperties* renderTargetProperties, out T1* renderTarget) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IRenderTarget {
		fixed (T1** _renderTarget = &renderTarget) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDxgiSurfaceRenderTarget (ptr, dxgiSurface, renderTargetProperties, (void**) _renderTarget);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDCRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, T0** dcRenderTarget) where T0 : unmanaged, IDCRenderTarget {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDCRenderTarget (ptr, renderTargetProperties, (void**) dcRenderTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDCRenderTarget<T0> (RenderTargetProperties* renderTargetProperties, out T0* dcRenderTarget) where T0 : unmanaged, IDCRenderTarget {
		fixed (T0** _dcRenderTarget = &dcRenderTarget) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDCRenderTarget (ptr, renderTargetProperties, (void**) _dcRenderTarget);
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
		public readonly delegate* unmanaged[Stdcall]<void*, int> ReloadSystemMetrics;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, float*, void> GetDesktopDpi;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void**, int> CreateRectangleGeometry;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RoundedRect*, void**, int> CreateRoundedRectangleGeometry;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Ellipse*, void**, int> CreateEllipseGeometry;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FillMode, void**, uint, void**, int> CreateGeometryGroup;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Matrix3x2F*, void**, int> CreateTransformedGeometry;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreatePathGeometry;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, StrokeStyleProperties*, float*, uint, void**, int> CreateStrokeStyle;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DrawingStateDescription*, void*, void**, int> CreateDrawingStateBlock;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, RenderTargetProperties*, void**, int> CreateWicBitmapRenderTarget;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RenderTargetProperties*, HwndRenderTargetProperties*, void**, int> CreateHwndRenderTarget;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, RenderTargetProperties*, void**, int> CreateDxgiSurfaceRenderTarget;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RenderTargetProperties*, void**, int> CreateDCRenderTarget;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
