using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Factory2</b> : ID2D1Factory1<br/>
/// D2D1_2.h
/// </summary>
unsafe public interface IFactory2 : IFactory1 {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory2::CreateDevice (IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1)</b><br/>
	/// </summary>
	/// <param name="dxgiDevice">_In_ <b>IDXGIDevice* dxgiDevice</b></param>
	/// <param name="d2dDevice1">_COM_Outptr_ <b>ID2D1Device1** d2dDevice1</b></param>
	int CreateDevice1<T0, T1> (T0* dxgiDevice, T1** d2dDevice1) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice1;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Factory2::CreateDevice (IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1)</b><br/>
	/// </summary>
	/// <param name="dxgiDevice">_In_ <b>IDXGIDevice* dxgiDevice</b></param>
	/// <param name="d2dDevice1">_COM_Outptr_ <b>ID2D1Device1** d2dDevice1</b></param>
	int CreateDevice1<T0, T1> (T0* dxgiDevice, out T1* d2dDevice1) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice1;
}

/// <summary>
/// Instance of <b>ID2D1Factory2</b><br/>
/// D2D1_2.h
/// </summary>
unsafe public readonly struct Factory2 : IFactory2 {
//unsafe public readonly struct IFactory2Obj : IFactory2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Factory2* GetCurrentPointer () => (Factory2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFactory2Obj* GetCurrentPointer () => (IFactory2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x94f81a73, 0x9212, 0x4376, 0x9c, 0x58, 0xb1, 0x6a, 0x3a, 0x0d, 0x39, 0x92);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDevice<T0, T1> (T0* dxgiDevice, T1** d2dDevice) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDevice (ptr, dxgiDevice, (void**) d2dDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDevice<T0, T1> (T0* dxgiDevice, out T1* d2dDevice) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice {
		fixed (T1** _d2dDevice = &d2dDevice) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDevice (ptr, dxgiDevice, (void**) _d2dDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokeStyle<T0> (StrokeStyleProperties1* strokeStyleProperties, float* dashes, uint dashesCount, T0** strokeStyle) where T0 : unmanaged, IStrokeStyle1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokeStyle1 (ptr, strokeStyleProperties, dashes, dashesCount, (void**) strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokeStyle<T0> (StrokeStyleProperties1* strokeStyleProperties, float* dashes, uint dashesCount, out T0* strokeStyle) where T0 : unmanaged, IStrokeStyle1 {
		fixed (T0** _strokeStyle = &strokeStyle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokeStyle1 (ptr, strokeStyleProperties, dashes, dashesCount, (void**) _strokeStyle);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathGeometry1<T0> (T0** pathGeometry) where T0 : unmanaged, IPathGeometry1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathGeometry1 (ptr, (void**) pathGeometry);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathGeometry1<T0> (out T0* pathGeometry) where T0 : unmanaged, IPathGeometry1 {
		fixed (T0** _pathGeometry = &pathGeometry) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathGeometry1 (ptr, (void**) _pathGeometry);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDrawingStateBlock<T0, T1> (DrawingStateDescription1* drawingStateDescription, T0* textRenderingParams, T1** drawingStateBlock) where T0 : unmanaged, DirectWrite.IRenderingParams where T1 : unmanaged, IDrawingStateBlock1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDrawingStateBlock1 (ptr, drawingStateDescription, textRenderingParams, (void**) drawingStateBlock);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDrawingStateBlock<T0, T1> (DrawingStateDescription1* drawingStateDescription, T0* textRenderingParams, out T1* drawingStateBlock) where T0 : unmanaged, DirectWrite.IRenderingParams where T1 : unmanaged, IDrawingStateBlock1 {
		fixed (T1** _drawingStateBlock = &drawingStateBlock) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDrawingStateBlock1 (ptr, drawingStateDescription, textRenderingParams, (void**) _drawingStateBlock);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGdiMetafile<T0, T1> (T0* metafileStream, T1** metafile) where T0 : unmanaged, IStream where T1 : unmanaged, IGdiMetafile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGdiMetafile (ptr, metafileStream, (void**) metafile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGdiMetafile<T0, T1> (T0* metafileStream, out T1* metafile) where T0 : unmanaged, IStream where T1 : unmanaged, IGdiMetafile {
		fixed (T1** _metafile = &metafile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGdiMetafile (ptr, metafileStream, (void**) _metafile);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterEffectFromStream<T0, T1> (Guid classId, T0* propertyXml, PropertyBinding* bindings, uint bindingsCount, EffectFactory<T1> effectFactory) where T0 : unmanaged, IStream where T1 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterEffectFromStream (ptr, classId, propertyXml, bindings, bindingsCount, (void*) Marshal.GetFunctionPointerForDelegate (effectFactory));
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterEffectFromString<T0> (Guid classId, char* propertyXml, PropertyBinding* bindings, uint bindingsCount, EffectFactory<T0> effectFactory) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterEffectFromString (ptr, classId, propertyXml, bindings, bindingsCount, (void*) Marshal.GetFunctionPointerForDelegate (effectFactory));
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnregisterEffect (Guid classId) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnregisterEffect (ptr, classId);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRegisteredEffects (Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRegisteredEffects (ptr, effects, effectsCount, effectsReturned, effectsRegistered);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRegisteredEffects (Guid* effects, uint effectsCount, out uint effectsReturned, out uint effectsRegistered) {
		fixed (uint* _effectsReturned = &effectsReturned) {
			fixed (uint* _effectsRegistered = &effectsRegistered) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetRegisteredEffects (ptr, effects, effectsCount, _effectsReturned, _effectsRegistered);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEffectProperties<T0> (Guid effectId, T0** properties) where T0 : unmanaged, IProperties {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEffectProperties (ptr, effectId, (void**) properties);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEffectProperties<T0> (Guid effectId, out T0* properties) where T0 : unmanaged, IProperties {
		fixed (T0** _properties = &properties) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEffectProperties (ptr, effectId, (void**) _properties);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDevice1<T0, T1> (T0* dxgiDevice, T1** d2dDevice1) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDevice1 (ptr, dxgiDevice, (void**) d2dDevice1);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDevice1<T0, T1> (T0* dxgiDevice, out T1* d2dDevice1) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice1 {
		fixed (T1** _d2dDevice1 = &d2dDevice1) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDevice1 (ptr, dxgiDevice, (void**) _d2dDevice1);
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
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateDevice;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, StrokeStyleProperties1*, float*, uint, void**, int> CreateStrokeStyle1;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreatePathGeometry1;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DrawingStateDescription1*, void*, void**, int> CreateDrawingStateBlock1;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateGdiMetafile;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, PropertyBinding*, uint, void*, int> RegisterEffectFromStream;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, char*, PropertyBinding*, uint, void*, int> RegisterEffectFromString;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> UnregisterEffect;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, uint, uint*, uint*, int> GetRegisteredEffects;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetEffectProperties;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateDevice1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
