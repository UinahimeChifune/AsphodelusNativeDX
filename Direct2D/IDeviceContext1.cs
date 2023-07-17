using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1DeviceContext1</b> : ID2D1DeviceContext<br/>
/// D2D1_2.h
/// </summary>
unsafe public interface IDeviceContext1 : IDeviceContext {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DeviceContext1::CreateFilledGeometryRealization (ID2D1Geometry* geometry, FLOAT flatteningTolerance, ID2D1GeometryRealization** geometryRealization)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="geometryRealization">_COM_Outptr_ <b>ID2D1GeometryRealization** geometryRealization</b></param>
	int CreateFilledGeometryRealization<T0, T1> (T0* geometry, float flatteningTolerance, T1** geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryRealization;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DeviceContext1::CreateFilledGeometryRealization (ID2D1Geometry* geometry, FLOAT flatteningTolerance, ID2D1GeometryRealization** geometryRealization)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="geometryRealization">_COM_Outptr_ <b>ID2D1GeometryRealization** geometryRealization</b></param>
	int CreateFilledGeometryRealization<T0, T1> (T0* geometry, float flatteningTolerance, out T1* geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryRealization;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DeviceContext1::CreateStrokedGeometryRealization (ID2D1Geometry* geometry, FLOAT flatteningTolerance, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle, ID2D1GeometryRealization** geometryRealization)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	/// <param name="geometryRealization">_COM_Outptr_ <b>ID2D1GeometryRealization** geometryRealization</b></param>
	int CreateStrokedGeometryRealization<T0, T1, T2> (T0* geometry, float flatteningTolerance, float strokeWidth, T1* strokeStyle, T2** geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IStrokeStyle where T2 : unmanaged, IGeometryRealization;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DeviceContext1::CreateStrokedGeometryRealization (ID2D1Geometry* geometry, FLOAT flatteningTolerance, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle, ID2D1GeometryRealization** geometryRealization)</b><br/>
	/// </summary>
	/// <param name="geometry">_In_ <b>ID2D1Geometry* geometry</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	/// <param name="geometryRealization">_COM_Outptr_ <b>ID2D1GeometryRealization** geometryRealization</b></param>
	int CreateStrokedGeometryRealization<T0, T1, T2> (T0* geometry, float flatteningTolerance, float strokeWidth, T1* strokeStyle, out T2* geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IStrokeStyle where T2 : unmanaged, IGeometryRealization;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DeviceContext1::DrawGeometryRealization (ID2D1GeometryRealization* geometryRealization, ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="geometryRealization">_In_ <b>ID2D1GeometryRealization* geometryRealization</b></param>
	/// <param name="brush">_In_ <b>ID2D1Brush* brush</b></param>
	void DrawGeometryRealization<T0, T1> (T0* geometryRealization, T1* brush) where T0 : unmanaged, IGeometryRealization where T1 : unmanaged, IBrush;
}

/// <summary>
/// Instance of <b>ID2D1DeviceContext1</b><br/>
/// D2D1_2.h
/// </summary>
unsafe public readonly struct DeviceContext1 : IDeviceContext1 {
//unsafe public readonly struct IDeviceContext1Obj : IDeviceContext1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DeviceContext1* GetCurrentPointer () => (DeviceContext1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDeviceContext1Obj* GetCurrentPointer () => (IDeviceContext1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xd37f57e4, 0x6908, 0x459f, 0xa1, 0x99, 0xe7, 0x2f, 0x24, 0xf7, 0x99, 0x87);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmap<T0> (Vector2U size, void* sourceData, uint pitch, BitmapProperties1* bitmapProperties, T0** bitmap) where T0 : unmanaged, IBitmap1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap1 (ptr, size, sourceData, pitch, bitmapProperties, (void**) bitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmap<T0> (Vector2U size, void* sourceData, uint pitch, BitmapProperties1* bitmapProperties, out T0* bitmap) where T0 : unmanaged, IBitmap1 {
		fixed (T0** _bitmap = &bitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap1 (ptr, size, sourceData, pitch, bitmapProperties, (void**) _bitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromWicBitmap<T0, T1> (T0* wicBitmapSource, BitmapProperties1* bitmapProperties, T1** bitmap) where T0 : unmanaged, WIC.IBitmapSource where T1 : unmanaged, IBitmap1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap1FromWicBitmap (ptr, wicBitmapSource, bitmapProperties, (void**) bitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromWicBitmap<T0, T1> (T0* wicBitmapSource, BitmapProperties1* bitmapProperties, out T1* bitmap) where T0 : unmanaged, WIC.IBitmapSource where T1 : unmanaged, IBitmap1 {
		fixed (T1** _bitmap = &bitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmap1FromWicBitmap (ptr, wicBitmapSource, bitmapProperties, (void**) _bitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContext<T0> (ColorSpace space, byte* profile, uint profileSize, T0** colorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContext (ptr, space, profile, profileSize, (void**) colorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContext<T0> (ColorSpace space, byte* profile, uint profileSize, out T0* colorContext) where T0 : unmanaged, IColorContext {
		fixed (T0** _colorContext = &colorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContext (ptr, space, profile, profileSize, (void**) _colorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromFilename<T0> (char* filename, T0** colorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromFilename (ptr, filename, (void**) colorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromFilename<T0> (char* filename, out T0* colorContext) where T0 : unmanaged, IColorContext {
		fixed (T0** _colorContext = &colorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromFilename (ptr, filename, (void**) _colorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromWicColorContext<T0, T1> (T0* wicColorContext, T1** colorContext) where T0 : unmanaged, WIC.IColorContext where T1 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromWicColorContext (ptr, wicColorContext, (void**) colorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateColorContextFromWicColorContext<T0, T1> (T0* wicColorContext, out T1* colorContext) where T0 : unmanaged, WIC.IColorContext where T1 : unmanaged, IColorContext {
		fixed (T1** _colorContext = &colorContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateColorContextFromWicColorContext (ptr, wicColorContext, (void**) _colorContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromDxgiSurface<T0, T1> (T0* surface, BitmapProperties1* bitmapProperties, T1** bitmap) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IBitmap1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromDxgiSurface (ptr, surface, bitmapProperties, (void**) bitmap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapFromDxgiSurface<T0, T1> (T0* surface, BitmapProperties1* bitmapProperties, out T1* bitmap) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IBitmap1 {
		fixed (T1** _bitmap = &bitmap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapFromDxgiSurface (ptr, surface, bitmapProperties, (void**) _bitmap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEffect<T0> (Guid effectId, T0** effect) where T0 : unmanaged, IEffect {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateEffect (ptr, effectId, (void**) effect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateEffect<T0> (Guid effectId, out T0* effect) where T0 : unmanaged, IEffect {
		fixed (T0** _effect = &effect) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateEffect (ptr, effectId, (void**) _effect);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGradientStopCollection<T0> (GradientStop* straightAlphaGradientStops, uint straightAlphaGradientStopsCount, ColorSpace preInterpolationSpace, ColorSpace postInterpolationSpace, BufferPrecision bufferPrecision, ExtendMode extendMode, ColorInterpolationMode colorInterpolationMode, T0** gradientStopCollection1) where T0 : unmanaged, IGradientStopCollection1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateGradientStopCollection1 (ptr, straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, (void**) gradientStopCollection1);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateGradientStopCollection<T0> (GradientStop* straightAlphaGradientStops, uint straightAlphaGradientStopsCount, ColorSpace preInterpolationSpace, ColorSpace postInterpolationSpace, BufferPrecision bufferPrecision, ExtendMode extendMode, ColorInterpolationMode colorInterpolationMode, out T0* gradientStopCollection1) where T0 : unmanaged, IGradientStopCollection1 {
		fixed (T0** _gradientStopCollection1 = &gradientStopCollection1) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateGradientStopCollection1 (ptr, straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, (void**) _gradientStopCollection1);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateImageBrush<T0, T1> (T0* image, ImageBrushProperties* imageBrushProperties, BrushProperties* brushProperties, T1** imageBrush) where T0 : unmanaged, IImage where T1 : unmanaged, IImageBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateImageBrush (ptr, image, imageBrushProperties, brushProperties, (void**) imageBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateImageBrush<T0, T1> (T0* image, ImageBrushProperties* imageBrushProperties, BrushProperties* brushProperties, out T1* imageBrush) where T0 : unmanaged, IImage where T1 : unmanaged, IImageBrush {
		fixed (T1** _imageBrush = &imageBrush) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateImageBrush (ptr, image, imageBrushProperties, brushProperties, (void**) _imageBrush);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapBrush<T0, T1> (T0* bitmap, BitmapBrushProperties1* bitmapBrushProperties, BrushProperties* brushProperties, T1** bitmapBrush) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBitmapBrush1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapBrush1 (ptr, bitmap, bitmapBrushProperties, brushProperties, (void**) bitmapBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapBrush<T0, T1> (T0* bitmap, BitmapBrushProperties1* bitmapBrushProperties, BrushProperties* brushProperties, out T1* bitmapBrush) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBitmapBrush1 {
		fixed (T1** _bitmapBrush = &bitmapBrush) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapBrush1 (ptr, bitmap, bitmapBrushProperties, brushProperties, (void**) _bitmapBrush);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandList<T0> (T0** commandList) where T0 : unmanaged, ICommandList {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandList (ptr, (void**) commandList);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateCommandList<T0> (out T0* commandList) where T0 : unmanaged, ICommandList {
		fixed (T0** _commandList = &commandList) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateCommandList (ptr, (void**) _commandList);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsDxgiFormatSupported (DXGI.Format format) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsDxgiFormatSupported (ptr, format) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsBufferPrecisionSupported (BufferPrecision bufferPrecision) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsBufferPrecisionSupported (ptr, bufferPrecision) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetImageLocalBounds<T0> (T0* image, Vector4F* localBounds) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetImageLocalBounds (ptr, image, localBounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetImageLocalBounds<T0> (T0* image, out Vector4F localBounds) where T0 : unmanaged, IImage {
		fixed (Vector4F* _localBounds = &localBounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetImageLocalBounds (ptr, image, _localBounds);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetImageWorldBounds<T0> (T0* image, Vector4F* worldBounds) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetImageWorldBounds (ptr, image, worldBounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetImageWorldBounds<T0> (T0* image, out Vector4F worldBounds) where T0 : unmanaged, IImage {
		fixed (Vector4F* _worldBounds = &worldBounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetImageWorldBounds (ptr, image, _worldBounds);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphRunWorldBounds (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, DirectWrite.MeasuringMode measuringMode, Vector4F* bounds) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphRunWorldBounds (ptr, baselineOrigin, glyphRun, measuringMode, bounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGlyphRunWorldBounds (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, DirectWrite.MeasuringMode measuringMode, out Vector4F bounds) {
		fixed (Vector4F* _bounds = &bounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGlyphRunWorldBounds (ptr, baselineOrigin, glyphRun, measuringMode, _bounds);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDevice<T0> (T0** device) where T0 : unmanaged, IDevice {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) device);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDevice<T0> (out T0* device) where T0 : unmanaged, IDevice {
		fixed (T0** _device = &device) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) _device);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetTarget<T0> (T0* image) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetTarget (ptr, image);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTarget<T0> (T0** image) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetTarget (ptr, (void**) image);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTarget<T0> (out T0* image) where T0 : unmanaged, IImage {
		fixed (T0** _image = &image) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetTarget (ptr, (void**) _image);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetRenderingControls (RenderingControls* renderingControls) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetRenderingControls (ptr, renderingControls);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetRenderingControls (RenderingControls* renderingControls) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetRenderingControls (ptr, renderingControls);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetRenderingControls (out RenderingControls renderingControls) {
		fixed (RenderingControls* _renderingControls = &renderingControls) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetRenderingControls (ptr, _renderingControls);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetPrimitiveBlend (PrimitiveBlend primitiveBlend) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetPrimitiveBlend (ptr, primitiveBlend);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly PrimitiveBlend GetPrimitiveBlend () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrimitiveBlend (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetUnitMode (UnitMode unitMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetUnitMode (ptr, unitMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly UnitMode GetUnitMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetUnitMode (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawGlyphRun<T0> (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, DirectWrite.GlyphRunDescription* glyphRunDescription, T0* foregroundBrush, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->_DrawGlyphRun (ptr, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawImage<T0> (T0* image, Vector2F* targetOffset, Vector4F* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawImage (ptr, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawGdiMetafile<T0> (T0* gdiMetafile, Vector2F* targetOffset) where T0 : unmanaged, IGdiMetafile {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawGdiMetafile (ptr, gdiMetafile, targetOffset);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawBitmap<T0> (T0* bitmap, Vector4F* destinationRectangle, float opacity, InterpolationMode interpolationMode, Vector4F* sourceRectangle, Matrix4x4F* perspectiveTransform) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->_DrawBitmap (ptr, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PushLayer<T0> (LayerParameters1* layerParameters, T0* layer) where T0 : unmanaged, ILayer {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->_PushLayer (ptr, layerParameters, layer);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InvalidateEffectInputRectangle<T0> (T0* effect, uint input, Vector4F* inputRectangle) where T0 : unmanaged, IEffect {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InvalidateEffectInputRectangle (ptr, effect, input, inputRectangle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEffectInvalidRectangleCount<T0> (T0* effect, uint* rectangleCount) where T0 : unmanaged, IEffect {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEffectInvalidRectangleCount (ptr, effect, rectangleCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEffectInvalidRectangleCount<T0> (T0* effect, out uint rectangleCount) where T0 : unmanaged, IEffect {
		fixed (uint* _rectangleCount = &rectangleCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetEffectInvalidRectangleCount (ptr, effect, _rectangleCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEffectInvalidRectangles<T0> (T0* effect, Vector4F* rectangles, uint rectanglesCount) where T0 : unmanaged, IEffect {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEffectInvalidRectangles (ptr, effect, rectangles, rectanglesCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetEffectRequiredInputRectangles<T0> (T0* renderEffect, Vector4F* renderImageRectangle, EffectInputDescription* inputDescriptions, Vector4F* requiredInputRects, uint inputCount) where T0 : unmanaged, IEffect {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEffectRequiredInputRectangles (ptr, renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FillOpacityMask<T0, T1> (T0* opacityMask, T1* brush, Vector4F* destinationRectangle, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->_FillOpacityMask (ptr, opacityMask, brush, destinationRectangle, sourceRectangle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFilledGeometryRealization<T0, T1> (T0* geometry, float flatteningTolerance, T1** geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryRealization {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFilledGeometryRealization (ptr, geometry, flatteningTolerance, (void**) geometryRealization);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFilledGeometryRealization<T0, T1> (T0* geometry, float flatteningTolerance, out T1* geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IGeometryRealization {
		fixed (T1** _geometryRealization = &geometryRealization) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFilledGeometryRealization (ptr, geometry, flatteningTolerance, (void**) _geometryRealization);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokedGeometryRealization<T0, T1, T2> (T0* geometry, float flatteningTolerance, float strokeWidth, T1* strokeStyle, T2** geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IStrokeStyle where T2 : unmanaged, IGeometryRealization {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokedGeometryRealization (ptr, geometry, flatteningTolerance, strokeWidth, strokeStyle, (void**) geometryRealization);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokedGeometryRealization<T0, T1, T2> (T0* geometry, float flatteningTolerance, float strokeWidth, T1* strokeStyle, out T2* geometryRealization) where T0 : unmanaged, IGeometry where T1 : unmanaged, IStrokeStyle where T2 : unmanaged, IGeometryRealization {
		fixed (T2** _geometryRealization = &geometryRealization) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokedGeometryRealization (ptr, geometry, flatteningTolerance, strokeWidth, strokeStyle, (void**) _geometryRealization);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DrawGeometryRealization<T0, T1> (T0* geometryRealization, T1* brush) where T0 : unmanaged, IGeometryRealization where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DrawGeometryRealization (ptr, geometryRealization, brush);
		return;
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
		/// <summary>
		/// OFFSET 57
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2U, void*, uint, BitmapProperties1*, void**, int> CreateBitmap1;
		/// <summary>
		/// OFFSET 58
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, BitmapProperties1*, void**, int> CreateBitmap1FromWicBitmap;
		/// <summary>
		/// OFFSET 59
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorSpace, byte*, uint, void**, int> CreateColorContext;
		/// <summary>
		/// OFFSET 60
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void**, int> CreateColorContextFromFilename;
		/// <summary>
		/// OFFSET 61
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> CreateColorContextFromWicColorContext;
		/// <summary>
		/// OFFSET 62
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, BitmapProperties1*, void**, int> CreateBitmapFromDxgiSurface;
		/// <summary>
		/// OFFSET 63
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> CreateEffect;
		/// <summary>
		/// OFFSET 64
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GradientStop*, uint, ColorSpace, ColorSpace, BufferPrecision, ExtendMode, ColorInterpolationMode, void**, int> CreateGradientStopCollection1;
		/// <summary>
		/// OFFSET 65
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ImageBrushProperties*, BrushProperties*, void**, int> CreateImageBrush;
		/// <summary>
		/// OFFSET 66
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, BitmapBrushProperties1*, BrushProperties*, void**, int> CreateBitmapBrush1;
		/// <summary>
		/// OFFSET 67
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateCommandList;
		/// <summary>
		/// OFFSET 68
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DXGI.Format, uint> IsDxgiFormatSupported;
		/// <summary>
		/// OFFSET 69
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BufferPrecision, uint> IsBufferPrecisionSupported;
		/// <summary>
		/// OFFSET 70
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, int> GetImageLocalBounds;
		/// <summary>
		/// OFFSET 71
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, int> GetImageWorldBounds;
		/// <summary>
		/// OFFSET 72
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, DirectWrite.GlyphRun*, DirectWrite.MeasuringMode, Vector4F*, int> GetGlyphRunWorldBounds;
		/// <summary>
		/// OFFSET 73
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetDevice;
		/// <summary>
		/// OFFSET 74
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetTarget;
		/// <summary>
		/// OFFSET 75
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetTarget;
		/// <summary>
		/// OFFSET 76
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RenderingControls*, void> SetRenderingControls;
		/// <summary>
		/// OFFSET 77
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RenderingControls*, void> GetRenderingControls;
		/// <summary>
		/// OFFSET 78
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PrimitiveBlend, void> SetPrimitiveBlend;
		/// <summary>
		/// OFFSET 79
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PrimitiveBlend> GetPrimitiveBlend;
		/// <summary>
		/// OFFSET 80
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, UnitMode, void> SetUnitMode;
		/// <summary>
		/// OFFSET 81
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, UnitMode> GetUnitMode;
		/// <summary>
		/// OFFSET 82
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, DirectWrite.GlyphRun*, DirectWrite.GlyphRunDescription*, void*, DirectWrite.MeasuringMode, void> _DrawGlyphRun;
		/// <summary>
		/// OFFSET 83
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector2F*, Vector4F*, InterpolationMode, CompositeMode, void> DrawImage;
		/// <summary>
		/// OFFSET 84
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector2F*, void> DrawGdiMetafile;
		/// <summary>
		/// OFFSET 85
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, float, InterpolationMode, Vector4F*, Matrix4x4F*, void> _DrawBitmap;
		/// <summary>
		/// OFFSET 86
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LayerParameters1*, void*, void> _PushLayer;
		/// <summary>
		/// OFFSET 87
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, Vector4F*, int> InvalidateEffectInputRectangle;
		/// <summary>
		/// OFFSET 88
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, int> GetEffectInvalidRectangleCount;
		/// <summary>
		/// OFFSET 89
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, uint, int> GetEffectInvalidRectangles;
		/// <summary>
		/// OFFSET 90
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, EffectInputDescription*, Vector4F*, uint, int> GetEffectRequiredInputRectangles;
		/// <summary>
		/// OFFSET 91
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, Vector4F*, Vector4F*, void> _FillOpacityMask;
		/// <summary>
		/// OFFSET 92
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, void**, int> CreateFilledGeometryRealization;
		/// <summary>
		/// OFFSET 93
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, float, void*, void**, int> CreateStrokedGeometryRealization;
		/// <summary>
		/// OFFSET 94
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void> DrawGeometryRealization;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
