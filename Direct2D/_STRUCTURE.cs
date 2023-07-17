using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// STRUCTURE <b>D2D1_BITMAP_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BitmapProperties {

	/// <summary>
	/// <b>D2D1_PIXEL_FORMAT pixelFormat</b>
	/// </summary>
	public readonly PixelFormat PixelFormat {
		get => _pixelFormat;
		init => _pixelFormat = value;
	}
	readonly PixelFormat _pixelFormat;

	/// <summary>
	/// <b>FLOAT dpiX</b>
	/// </summary>
	public readonly float DpiX {
		get => _dpiX;
		init => _dpiX = value;
	}
	readonly float _dpiX;

	/// <summary>
	/// <b>FLOAT dpiY</b>
	/// </summary>
	public readonly float DpiY {
		get => _dpiY;
		init => _dpiY = value;
	}
	readonly float _dpiY;

}

/// <summary>
/// STRUCTURE <b>D2D1_GRADIENT_STOP</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GradientStop {

	/// <summary>
	/// <b>FLOAT position</b>
	/// </summary>
	public readonly float Position {
		get => _position;
		init => _position = value;
	}
	readonly float _position;

	/// <summary>
	/// <b>D2D1_COLOR_F color</b>
	/// </summary>
	public readonly Vector4F Color {
		get => _color;
		init => _color = value;
	}
	readonly Vector4F _color;

}

/// <summary>
/// STRUCTURE <b>D2D1_BRUSH_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BrushProperties {

	/// <summary>
	/// <b>FLOAT opacity</b>
	/// </summary>
	public readonly float Opacity {
		get => _opacity;
		init => _opacity = value;
	}
	readonly float _opacity;

	/// <summary>
	/// <b>D2D1_MATRIX_3X2_F transform</b>
	/// </summary>
	public readonly Matrix3x2F Transform {
		get => _transform;
		init => _transform = value;
	}
	readonly Matrix3x2F _transform;

}

/// <summary>
/// STRUCTURE <b>D2D1_BITMAP_BRUSH_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BitmapBrushProperties {

	/// <summary>
	/// <b>D2D1_EXTEND_MODE extendModeX</b>
	/// </summary>
	public readonly ExtendMode ExtendModeX {
		get => _extendModeX;
		init => _extendModeX = value;
	}
	readonly ExtendMode _extendModeX;

	/// <summary>
	/// <b>D2D1_EXTEND_MODE extendModeY</b>
	/// </summary>
	public readonly ExtendMode ExtendModeY {
		get => _extendModeY;
		init => _extendModeY = value;
	}
	readonly ExtendMode _extendModeY;

	/// <summary>
	/// <b>D2D1_BITMAP_INTERPOLATION_MODE interpolationMode</b>
	/// </summary>
	public readonly BitmapInterpolationMode InterpolationMode {
		get => _interpolationMode;
		init => _interpolationMode = value;
	}
	readonly BitmapInterpolationMode _interpolationMode;

}

/// <summary>
/// STRUCTURE <b>D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LinearGradientBrushProperties {

	/// <summary>
	/// <b>D2D1_POINT_2F startPoint</b>
	/// </summary>
	public readonly Vector2F StartPoint {
		get => _startPoint;
		init => _startPoint = value;
	}
	readonly Vector2F _startPoint;

	/// <summary>
	/// <b>D2D1_POINT_2F endPoint</b>
	/// </summary>
	public readonly Vector2F EndPoint {
		get => _endPoint;
		init => _endPoint = value;
	}
	readonly Vector2F _endPoint;

}

/// <summary>
/// STRUCTURE <b>D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RadialGradientBrushProperties {

	/// <summary>
	/// <b>D2D1_POINT_2F center</b>
	/// </summary>
	public readonly Vector2F Center {
		get => _center;
		init => _center = value;
	}
	readonly Vector2F _center;

	/// <summary>
	/// <b>D2D1_POINT_2F gradientOriginOffset</b>
	/// </summary>
	public readonly Vector2F GradientOriginOffset {
		get => _gradientOriginOffset;
		init => _gradientOriginOffset = value;
	}
	readonly Vector2F _gradientOriginOffset;

	/// <summary>
	/// <b>FLOAT radiusX</b>
	/// </summary>
	public readonly float RadiusX {
		get => _radiusX;
		init => _radiusX = value;
	}
	readonly float _radiusX;

	/// <summary>
	/// <b>FLOAT radiusY</b>
	/// </summary>
	public readonly float RadiusY {
		get => _radiusY;
		init => _radiusY = value;
	}
	readonly float _radiusY;

}

/// <summary>
/// STRUCTURE <b>D2D1_BEZIER_SEGMENT</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BezierSegment {

	/// <summary>
	/// <b>D2D1_POINT_2F point1</b>
	/// </summary>
	public readonly Vector2F Point1 {
		get => _point1;
		init => _point1 = value;
	}
	readonly Vector2F _point1;

	/// <summary>
	/// <b>D2D1_POINT_2F point2</b>
	/// </summary>
	public readonly Vector2F Point2 {
		get => _point2;
		init => _point2 = value;
	}
	readonly Vector2F _point2;

	/// <summary>
	/// <b>D2D1_POINT_2F point3</b>
	/// </summary>
	public readonly Vector2F Point3 {
		get => _point3;
		init => _point3 = value;
	}
	readonly Vector2F _point3;

}

/// <summary>
/// STRUCTURE <b>D2D1_TRIANGLE</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Triangle {

	/// <summary>
	/// <b>D2D1_POINT_2F point1</b>
	/// </summary>
	public readonly Vector2F Point1 {
		get => _point1;
		init => _point1 = value;
	}
	readonly Vector2F _point1;

	/// <summary>
	/// <b>D2D1_POINT_2F point2</b>
	/// </summary>
	public readonly Vector2F Point2 {
		get => _point2;
		init => _point2 = value;
	}
	readonly Vector2F _point2;

	/// <summary>
	/// <b>D2D1_POINT_2F point3</b>
	/// </summary>
	public readonly Vector2F Point3 {
		get => _point3;
		init => _point3 = value;
	}
	readonly Vector2F _point3;

}

/// <summary>
/// STRUCTURE <b>D2D1_ARC_SEGMENT</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ArcSegment {

	/// <summary>
	/// <b>D2D1_POINT_2F point</b>
	/// </summary>
	public readonly Vector2F Point {
		get => _point;
		init => _point = value;
	}
	readonly Vector2F _point;

	/// <summary>
	/// <b>D2D1_SIZE_F size</b>
	/// </summary>
	public readonly Vector2F Size {
		get => _size;
		init => _size = value;
	}
	readonly Vector2F _size;

	/// <summary>
	/// <b>FLOAT rotationAngle</b>
	/// </summary>
	public readonly float RotationAngle {
		get => _rotationAngle;
		init => _rotationAngle = value;
	}
	readonly float _rotationAngle;

	/// <summary>
	/// <b>D2D1_SWEEP_DIRECTION sweepDirection</b>
	/// </summary>
	public readonly SweepDirection SweepDirection {
		get => _sweepDirection;
		init => _sweepDirection = value;
	}
	readonly SweepDirection _sweepDirection;

	/// <summary>
	/// <b>D2D1_ARC_SIZE arcSize</b>
	/// </summary>
	public readonly ArcSize ArcSize {
		get => _arcSize;
		init => _arcSize = value;
	}
	readonly ArcSize _arcSize;

}

/// <summary>
/// STRUCTURE <b>D2D1_QUADRATIC_BEZIER_SEGMENT</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QuadraticBezierSegment {

	/// <summary>
	/// <b>D2D1_POINT_2F point1</b>
	/// </summary>
	public readonly Vector2F Point1 {
		get => _point1;
		init => _point1 = value;
	}
	readonly Vector2F _point1;

	/// <summary>
	/// <b>D2D1_POINT_2F point2</b>
	/// </summary>
	public readonly Vector2F Point2 {
		get => _point2;
		init => _point2 = value;
	}
	readonly Vector2F _point2;

}

/// <summary>
/// STRUCTURE <b>D2D1_ELLIPSE</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Ellipse {

	/// <summary>
	/// <b>D2D1_POINT_2F point</b>
	/// </summary>
	public readonly Vector2F Point {
		get => _point;
		init => _point = value;
	}
	readonly Vector2F _point;

	/// <summary>
	/// <b>FLOAT radiusX</b>
	/// </summary>
	public readonly float RadiusX {
		get => _radiusX;
		init => _radiusX = value;
	}
	readonly float _radiusX;

	/// <summary>
	/// <b>FLOAT radiusY</b>
	/// </summary>
	public readonly float RadiusY {
		get => _radiusY;
		init => _radiusY = value;
	}
	readonly float _radiusY;

}

/// <summary>
/// STRUCTURE <b>D2D1_ROUNDED_RECT</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RoundedRect {

	/// <summary>
	/// <b>D2D1_RECT_F rect</b>
	/// </summary>
	public readonly Vector4F Rect {
		get => _rect;
		init => _rect = value;
	}
	readonly Vector4F _rect;

	/// <summary>
	/// <b>FLOAT radiusX</b>
	/// </summary>
	public readonly float RadiusX {
		get => _radiusX;
		init => _radiusX = value;
	}
	readonly float _radiusX;

	/// <summary>
	/// <b>FLOAT radiusY</b>
	/// </summary>
	public readonly float RadiusY {
		get => _radiusY;
		init => _radiusY = value;
	}
	readonly float _radiusY;

}

/// <summary>
/// STRUCTURE <b>D2D1_STROKE_STYLE_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StrokeStyleProperties {

	/// <summary>
	/// <b>D2D1_CAP_STYLE startCap</b>
	/// </summary>
	public readonly CapStyle StartCap {
		get => _startCap;
		init => _startCap = value;
	}
	readonly CapStyle _startCap;

	/// <summary>
	/// <b>D2D1_CAP_STYLE endCap</b>
	/// </summary>
	public readonly CapStyle EndCap {
		get => _endCap;
		init => _endCap = value;
	}
	readonly CapStyle _endCap;

	/// <summary>
	/// <b>D2D1_CAP_STYLE dashCap</b>
	/// </summary>
	public readonly CapStyle DashCap {
		get => _dashCap;
		init => _dashCap = value;
	}
	readonly CapStyle _dashCap;

	/// <summary>
	/// <b>D2D1_LINE_JOIN lineJoin</b>
	/// </summary>
	public readonly LineJoin LineJoin {
		get => _lineJoin;
		init => _lineJoin = value;
	}
	readonly LineJoin _lineJoin;

	/// <summary>
	/// <b>FLOAT miterLimit</b>
	/// </summary>
	public readonly float MiterLimit {
		get => _miterLimit;
		init => _miterLimit = value;
	}
	readonly float _miterLimit;

	/// <summary>
	/// <b>D2D1_DASH_STYLE dashStyle</b>
	/// </summary>
	public readonly DashStyle DashStyle {
		get => _dashStyle;
		init => _dashStyle = value;
	}
	readonly DashStyle _dashStyle;

	/// <summary>
	/// <b>FLOAT dashOffset</b>
	/// </summary>
	public readonly float DashOffset {
		get => _dashOffset;
		init => _dashOffset = value;
	}
	readonly float _dashOffset;

}

/// <summary>
/// STRUCTURE <b>D2D1_LAYER_PARAMETERS</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LayerParameters {

	/// <summary>
	/// <b>D2D1_RECT_F contentBounds</b>
	/// </summary>
	public readonly Vector4F ContentBounds {
		get => _contentBounds;
		init => _contentBounds = value;
	}
	readonly Vector4F _contentBounds;

	/// <summary>
	/// <b>ID2D1Geometry* geometricMask</b>
	/// </summary>
	public readonly T* GeometricMask<T> () where T : unmanaged, IGeometry => (T*) _geometricMask;
	readonly void* _geometricMask;

	/// <summary>
	/// <b>D2D1_ANTIALIAS_MODE maskAntialiasMode</b>
	/// </summary>
	public readonly AntialiasMode MaskAntialiasMode {
		get => _maskAntialiasMode;
		init => _maskAntialiasMode = value;
	}
	readonly AntialiasMode _maskAntialiasMode;

	/// <summary>
	/// <b>D2D1_MATRIX_3X2_F maskTransform</b>
	/// </summary>
	public readonly Matrix3x2F MaskTransform {
		get => _maskTransform;
		init => _maskTransform = value;
	}
	readonly Matrix3x2F _maskTransform;

	/// <summary>
	/// <b>FLOAT opacity</b>
	/// </summary>
	public readonly float Opacity {
		get => _opacity;
		init => _opacity = value;
	}
	readonly float _opacity;

	/// <summary>
	/// <b>ID2D1Brush* opacityBrush</b>
	/// </summary>
	public readonly T* OpacityBrush<T> () where T : unmanaged, IBrush => (T*) _opacityBrush;
	readonly void* _opacityBrush;

	/// <summary>
	/// <b>D2D1_LAYER_OPTIONS layerOptions</b>
	/// </summary>
	public readonly LayerOptions LayerOptions {
		get => _layerOptions;
		init => _layerOptions = value;
	}
	readonly LayerOptions _layerOptions;

}

/// <summary>
/// STRUCTURE <b>D2D1_RENDER_TARGET_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderTargetProperties {

	/// <summary>
	/// <b>D2D1_RENDER_TARGET_TYPE type</b>
	/// </summary>
	public readonly RenderTargetType Type {
		get => _type;
		init => _type = value;
	}
	readonly RenderTargetType _type;

	/// <summary>
	/// <b>D2D1_PIXEL_FORMAT pixelFormat</b>
	/// </summary>
	public readonly PixelFormat PixelFormat {
		get => _pixelFormat;
		init => _pixelFormat = value;
	}
	readonly PixelFormat _pixelFormat;

	/// <summary>
	/// <b>FLOAT dpiX</b>
	/// </summary>
	public readonly float DpiX {
		get => _dpiX;
		init => _dpiX = value;
	}
	readonly float _dpiX;

	/// <summary>
	/// <b>FLOAT dpiY</b>
	/// </summary>
	public readonly float DpiY {
		get => _dpiY;
		init => _dpiY = value;
	}
	readonly float _dpiY;

	/// <summary>
	/// <b>D2D1_RENDER_TARGET_USAGE usage</b>
	/// </summary>
	public readonly RenderTargetUsage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly RenderTargetUsage _usage;

	/// <summary>
	/// <b>D2D1_FEATURE_LEVEL minLevel</b>
	/// </summary>
	public readonly FeatureLevel MinLevel {
		get => _minLevel;
		init => _minLevel = value;
	}
	readonly FeatureLevel _minLevel;

}

/// <summary>
/// STRUCTURE <b>D2D1_HWND_RENDER_TARGET_PROPERTIES</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct HwndRenderTargetProperties {

	/// <summary>
	/// <b>HWND hwnd</b>
	/// </summary>
	public readonly IntPtr Hwnd {
		get => _hwnd;
		init => _hwnd = value;
	}
	readonly IntPtr _hwnd;

	/// <summary>
	/// <b>D2D1_SIZE_U pixelSize</b>
	/// </summary>
	public readonly Vector2U PixelSize {
		get => _pixelSize;
		init => _pixelSize = value;
	}
	readonly Vector2U _pixelSize;

	/// <summary>
	/// <b>D2D1_PRESENT_OPTIONS presentOptions</b>
	/// </summary>
	public readonly PresentOptions PresentOptions {
		get => _presentOptions;
		init => _presentOptions = value;
	}
	readonly PresentOptions _presentOptions;

}

/// <summary>
/// STRUCTURE <b>D2D1_DRAWING_STATE_DESCRIPTION</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DrawingStateDescription {

	/// <summary>
	/// <b>D2D1_ANTIALIAS_MODE antialiasMode</b>
	/// </summary>
	public readonly AntialiasMode AntialiasMode {
		get => _antialiasMode;
		init => _antialiasMode = value;
	}
	readonly AntialiasMode _antialiasMode;

	/// <summary>
	/// <b>D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode</b>
	/// </summary>
	public readonly TextAntialiasMode TextAntialiasMode {
		get => _textAntialiasMode;
		init => _textAntialiasMode = value;
	}
	readonly TextAntialiasMode _textAntialiasMode;

	/// <summary>
	/// <b>D2D1_TAG tag1</b>
	/// </summary>
	public readonly ulong Tag1 {
		get => _tag1;
		init => _tag1 = value;
	}
	readonly ulong _tag1;

	/// <summary>
	/// <b>D2D1_TAG tag2</b>
	/// </summary>
	public readonly ulong Tag2 {
		get => _tag2;
		init => _tag2 = value;
	}
	readonly ulong _tag2;

	/// <summary>
	/// <b>D2D1_MATRIX_3X2_F transform</b>
	/// </summary>
	public readonly Matrix3x2F Transform {
		get => _transform;
		init => _transform = value;
	}
	readonly Matrix3x2F _transform;

}

/// <summary>
/// STRUCTURE <b>D2D1_FACTORY_OPTIONS</b><br/>
/// D2D1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FactoryOptions {

	/// <summary>
	/// <b>D2D1_DEBUG_LEVEL debugLevel</b>
	/// </summary>
	public readonly DebugLevel DebugLevel {
		get => _debugLevel;
		init => _debugLevel = value;
	}
	readonly DebugLevel _debugLevel;

}

/// <summary>
/// CALLBACK <b>PD2D1_PROPERTY_GET_FUNCTION</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public delegate int PropertyGetFunction<T> (T* effect, byte* data, uint dataSize, uint* actualSize) where T : unmanaged, IEffect;

/// <summary>
/// CALLBACK <b>PD2D1_PROPERTY_SET_FUNCTION</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public delegate int PropertySetFunction<T> (T* effect, byte* data, uint dataSize) where T : unmanaged, IEffect;

/// <summary>
/// STRUCTURE <b>D2D1_PROPERTY_BINDING</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PropertyBinding {

	/// <summary>
	/// <b>PCWSTR propertyName</b>
	/// </summary>
	public readonly char* PropertyName {
		get => _propertyName;
		init => _propertyName = value;
	}
	readonly char* _propertyName;

	/// <summary>
	/// <b>PD2D1_PROPERTY_SET_FUNCTION setFunction</b>
	/// </summary>
	public readonly PropertySetFunction<T> SetFunction<T> () where T : unmanaged, IEffect => Marshal.GetDelegateForFunctionPointer<PropertySetFunction<T>> ((IntPtr) _setFunction);
	readonly void* _setFunction;

	/// <summary>
	/// <b>PD2D1_PROPERTY_GET_FUNCTION getFunction</b>
	/// </summary>
	public readonly PropertyGetFunction<T> GetFunction<T> () where T : unmanaged, IEffect => Marshal.GetDelegateForFunctionPointer<PropertyGetFunction<T>> ((IntPtr) _getFunction);
	readonly void* _getFunction;

}

/// <summary>
/// STRUCTURE <b>D2D1_RESOURCE_TEXTURE_PROPERTIES</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ResourceTextureProperties {

	/// <summary>
	/// <b>UINT32* extents</b>
	/// </summary>
	public readonly uint* Extents {
		get => _extents;
		init => _extents = value;
	}
	readonly uint* _extents;

	/// <summary>
	/// <b>UINT32 dimensions</b>
	/// </summary>
	public readonly uint Dimensions {
		get => _dimensions;
		init => _dimensions = value;
	}
	readonly uint _dimensions;

	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION bufferPrecision</b>
	/// </summary>
	public readonly BufferPrecision BufferPrecision {
		get => _bufferPrecision;
		init => _bufferPrecision = value;
	}
	readonly BufferPrecision _bufferPrecision;

	/// <summary>
	/// <b>D2D1_CHANNEL_DEPTH channelDepth</b>
	/// </summary>
	public readonly ChannelDepth ChannelDepth {
		get => _channelDepth;
		init => _channelDepth = value;
	}
	readonly ChannelDepth _channelDepth;

	/// <summary>
	/// <b>D2D1_FILTER filter</b>
	/// </summary>
	public readonly Filter Filter {
		get => _filter;
		init => _filter = value;
	}
	readonly Filter _filter;

	/// <summary>
	/// <b>D2D1_EXTEND_MODE* extendModes</b>
	/// </summary>
	public readonly ExtendMode* ExtendModes {
		get => _extendModes;
		init => _extendModes = value;
	}
	readonly ExtendMode* _extendModes;

}

/// <summary>
/// STRUCTURE <b>D2D1_INPUT_ELEMENT_DESC</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InputElementDesc {

	/// <summary>
	/// <b>PCSTR semanticName</b>
	/// </summary>
	public readonly char* SemanticName {
		get => _semanticName;
		init => _semanticName = value;
	}
	readonly char* _semanticName;

	/// <summary>
	/// <b>UINT32 semanticIndex</b>
	/// </summary>
	public readonly uint SemanticIndex {
		get => _semanticIndex;
		init => _semanticIndex = value;
	}
	readonly uint _semanticIndex;

	/// <summary>
	/// <b>DXGI_FORMAT format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>UINT32 inputSlot</b>
	/// </summary>
	public readonly uint InputSlot {
		get => _inputSlot;
		init => _inputSlot = value;
	}
	readonly uint _inputSlot;

	/// <summary>
	/// <b>UINT32 alignedByteOffset</b>
	/// </summary>
	public readonly uint AlignedByteOffset {
		get => _alignedByteOffset;
		init => _alignedByteOffset = value;
	}
	readonly uint _alignedByteOffset;

}

/// <summary>
/// STRUCTURE <b>D2D1_VERTEX_BUFFER_PROPERTIES</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VertexBufferProperties {

	/// <summary>
	/// <b>UINT32 inputCount</b>
	/// </summary>
	public readonly uint InputCount {
		get => _inputCount;
		init => _inputCount = value;
	}
	readonly uint _inputCount;

	/// <summary>
	/// <b>D2D1_VERTEX_USAGE usage</b>
	/// </summary>
	public readonly VertexUsage Usage {
		get => _usage;
		init => _usage = value;
	}
	readonly VertexUsage _usage;

	/// <summary>
	/// <b>BYTE* data</b>
	/// </summary>
	public readonly byte* Data {
		get => _data;
		init => _data = value;
	}
	readonly byte* _data;

	/// <summary>
	/// <b>UINT32 byteWidth</b>
	/// </summary>
	public readonly uint ByteWidth {
		get => _byteWidth;
		init => _byteWidth = value;
	}
	readonly uint _byteWidth;

}

/// <summary>
/// STRUCTURE <b>D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CustomVertexBufferProperties {

	/// <summary>
	/// <b>BYTE* shaderBufferWithInputSignature</b>
	/// </summary>
	public readonly byte* ShaderBufferWithInputSignature {
		get => _shaderBufferWithInputSignature;
		init => _shaderBufferWithInputSignature = value;
	}
	readonly byte* _shaderBufferWithInputSignature;

	/// <summary>
	/// <b>UINT32 shaderBufferSize</b>
	/// </summary>
	public readonly uint ShaderBufferSize {
		get => _shaderBufferSize;
		init => _shaderBufferSize = value;
	}
	readonly uint _shaderBufferSize;

	/// <summary>
	/// <b>D2D1_INPUT_ELEMENT_DESC* inputElements</b>
	/// </summary>
	public readonly InputElementDesc* InputElements {
		get => _inputElements;
		init => _inputElements = value;
	}
	readonly InputElementDesc* _inputElements;

	/// <summary>
	/// <b>UINT32 elementCount</b>
	/// </summary>
	public readonly uint ElementCount {
		get => _elementCount;
		init => _elementCount = value;
	}
	readonly uint _elementCount;

	/// <summary>
	/// <b>UINT32 stride</b>
	/// </summary>
	public readonly uint Stride {
		get => _stride;
		init => _stride = value;
	}
	readonly uint _stride;

}

/// <summary>
/// STRUCTURE <b>D2D1_VERTEX_RANGE</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct VertexRange {

	/// <summary>
	/// <b>UINT32 startVertex</b>
	/// </summary>
	public readonly uint StartVertex {
		get => _startVertex;
		init => _startVertex = value;
	}
	readonly uint _startVertex;

	/// <summary>
	/// <b>UINT32 vertexCount</b>
	/// </summary>
	public readonly uint VertexCount {
		get => _vertexCount;
		init => _vertexCount = value;
	}
	readonly uint _vertexCount;

}

/// <summary>
/// STRUCTURE <b>D2D1_BLEND_DESCRIPTION</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BlendDescription {

	/// <summary>
	/// <b>D2D1_BLEND sourceBlend</b>
	/// </summary>
	public readonly Blend SourceBlend {
		get => _sourceBlend;
		init => _sourceBlend = value;
	}
	readonly Blend _sourceBlend;

	/// <summary>
	/// <b>D2D1_BLEND destinationBlend</b>
	/// </summary>
	public readonly Blend DestinationBlend {
		get => _destinationBlend;
		init => _destinationBlend = value;
	}
	readonly Blend _destinationBlend;

	/// <summary>
	/// <b>D2D1_BLEND_OPERATION blendOperation</b>
	/// </summary>
	public readonly BlendOperation BlendOperation {
		get => _blendOperation;
		init => _blendOperation = value;
	}
	readonly BlendOperation _blendOperation;

	/// <summary>
	/// <b>D2D1_BLEND sourceBlendAlpha</b>
	/// </summary>
	public readonly Blend SourceBlendAlpha {
		get => _sourceBlendAlpha;
		init => _sourceBlendAlpha = value;
	}
	readonly Blend _sourceBlendAlpha;

	/// <summary>
	/// <b>D2D1_BLEND destinationBlendAlpha</b>
	/// </summary>
	public readonly Blend DestinationBlendAlpha {
		get => _destinationBlendAlpha;
		init => _destinationBlendAlpha = value;
	}
	readonly Blend _destinationBlendAlpha;

	/// <summary>
	/// <b>D2D1_BLEND_OPERATION blendOperationAlpha</b>
	/// </summary>
	public readonly BlendOperation BlendOperationAlpha {
		get => _blendOperationAlpha;
		init => _blendOperationAlpha = value;
	}
	readonly BlendOperation _blendOperationAlpha;

	/// <summary>
	/// <b>FLOAT blendFactor [4]</b>
	/// </summary>
	public readonly Span<float> BlendFactor {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _blendFactor)), 4);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_111 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [4];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_111 _blendFactor;

}

/// <summary>
/// STRUCTURE <b>D2D1_INPUT_DESCRIPTION</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InputDescription {

	/// <summary>
	/// <b>D2D1_FILTER filter</b>
	/// </summary>
	public readonly Filter Filter {
		get => _filter;
		init => _filter = value;
	}
	readonly Filter _filter;

	/// <summary>
	/// <b>UINT32 levelOfDetailCount</b>
	/// </summary>
	public readonly uint LevelOfDetailCount {
		get => _levelOfDetailCount;
		init => _levelOfDetailCount = value;
	}
	readonly uint _levelOfDetailCount;

}

/// <summary>
/// STRUCTURE <b>D2D1_FEATURE_DATA_DOUBLES</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataDoubles {

	/// <summary>
	/// <b>BOOL doublePrecisionFloatShaderOps</b>
	/// </summary>
	public readonly bool DoublePrecisionFloatShaderOps {
		get => _doublePrecisionFloatShaderOps != 0;
		init => _doublePrecisionFloatShaderOps = value ? 1U : 0U;
	}
	readonly uint _doublePrecisionFloatShaderOps;

}

/// <summary>
/// STRUCTURE <b>D2D1_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FeatureDataD3d10XHardwareOptions {

	/// <summary>
	/// <b>BOOL computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x</b>
	/// </summary>
	public readonly bool ComputeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x {
		get => _computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x != 0;
		init => _computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x = value ? 1U : 0U;
	}
	readonly uint _computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;

}

/// <summary>
/// STRUCTURE <b>D2D1_SVG_LENGTH</b><br/>
/// D2D1SVG.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SvgLength {

	/// <summary>
	/// <b>FLOAT value</b>
	/// </summary>
	public readonly float Value {
		get => _value;
		init => _value = value;
	}
	readonly float _value;

	/// <summary>
	/// <b>D2D1_SVG_LENGTH_UNITS units</b>
	/// </summary>
	public readonly SvgLengthUnits Units {
		get => _units;
		init => _units = value;
	}
	readonly SvgLengthUnits _units;

}

/// <summary>
/// STRUCTURE <b>D2D1_SVG_PRESERVE_ASPECT_RATIO</b><br/>
/// D2D1SVG.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SvgPreserveAspectRatio {

	/// <summary>
	/// <b>BOOL defer</b>
	/// </summary>
	public readonly bool Defer {
		get => _defer != 0;
		init => _defer = value ? 1U : 0U;
	}
	readonly uint _defer;

	/// <summary>
	/// <b>D2D1_SVG_ASPECT_ALIGN align</b>
	/// </summary>
	public readonly SvgAspectAlign Align {
		get => _align;
		init => _align = value;
	}
	readonly SvgAspectAlign _align;

	/// <summary>
	/// <b>D2D1_SVG_ASPECT_SCALING meetOrSlice</b>
	/// </summary>
	public readonly SvgAspectScaling MeetOrSlice {
		get => _meetOrSlice;
		init => _meetOrSlice = value;
	}
	readonly SvgAspectScaling _meetOrSlice;

}

/// <summary>
/// STRUCTURE <b>D2D1_SVG_VIEWBOX</b><br/>
/// D2D1SVG.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SvgViewbox {

	/// <summary>
	/// <b>FLOAT x</b>
	/// </summary>
	public readonly float X {
		get => _x;
		init => _x = value;
	}
	readonly float _x;

	/// <summary>
	/// <b>FLOAT y</b>
	/// </summary>
	public readonly float Y {
		get => _y;
		init => _y = value;
	}
	readonly float _y;

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

}

/// <summary>
/// STRUCTURE <b>D2D1_BITMAP_PROPERTIES1</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BitmapProperties1 {

	/// <summary>
	/// <b>D2D1_PIXEL_FORMAT pixelFormat</b>
	/// </summary>
	public readonly PixelFormat PixelFormat {
		get => _pixelFormat;
		init => _pixelFormat = value;
	}
	readonly PixelFormat _pixelFormat;

	/// <summary>
	/// <b>FLOAT dpiX</b>
	/// </summary>
	public readonly float DpiX {
		get => _dpiX;
		init => _dpiX = value;
	}
	readonly float _dpiX;

	/// <summary>
	/// <b>FLOAT dpiY</b>
	/// </summary>
	public readonly float DpiY {
		get => _dpiY;
		init => _dpiY = value;
	}
	readonly float _dpiY;

	/// <summary>
	/// <b>D2D1_BITMAP_OPTIONS bitmapOptions</b>
	/// </summary>
	public readonly BitmapOptions BitmapOptions {
		get => _bitmapOptions;
		init => _bitmapOptions = value;
	}
	readonly BitmapOptions _bitmapOptions;

	/// <summary>
	/// <b>ID2D1ColorContext* colorContext</b>
	/// </summary>
	public readonly T* ColorContext<T> () where T : unmanaged, IColorContext => (T*) _colorContext;
	readonly void* _colorContext;

}

/// <summary>
/// STRUCTURE <b>D2D1_MAPPED_RECT</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MappedRect {

	/// <summary>
	/// <b>UINT32 pitch</b>
	/// </summary>
	public readonly uint Pitch {
		get => _pitch;
		init => _pitch = value;
	}
	readonly uint _pitch;

	/// <summary>
	/// <b>BYTE* bits</b>
	/// </summary>
	public readonly byte* Bits {
		get => _bits;
		init => _bits = value;
	}
	readonly byte* _bits;

}

/// <summary>
/// STRUCTURE <b>D2D1_RENDERING_CONTROLS</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RenderingControls {

	/// <summary>
	/// <b>D2D1_BUFFER_PRECISION bufferPrecision</b>
	/// </summary>
	public readonly BufferPrecision BufferPrecision {
		get => _bufferPrecision;
		init => _bufferPrecision = value;
	}
	readonly BufferPrecision _bufferPrecision;

	/// <summary>
	/// <b>D2D1_SIZE_U tileSize</b>
	/// </summary>
	public readonly Vector2U TileSize {
		get => _tileSize;
		init => _tileSize = value;
	}
	readonly Vector2U _tileSize;

}

/// <summary>
/// STRUCTURE <b>D2D1_EFFECT_INPUT_DESCRIPTION</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct EffectInputDescription {

	/// <summary>
	/// <b>ID2D1Effect* effect</b>
	/// </summary>
	public readonly T* Effect<T> () where T : unmanaged, IEffect => (T*) _effect;
	readonly void* _effect;

	/// <summary>
	/// <b>UINT32 inputIndex</b>
	/// </summary>
	public readonly uint InputIndex {
		get => _inputIndex;
		init => _inputIndex = value;
	}
	readonly uint _inputIndex;

	/// <summary>
	/// <b>D2D1_RECT_F inputRectangle</b>
	/// </summary>
	public readonly Vector4F InputRectangle {
		get => _inputRectangle;
		init => _inputRectangle = value;
	}
	readonly Vector4F _inputRectangle;

}

/// <summary>
/// STRUCTURE <b>D2D1_POINT_DESCRIPTION</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PointDescription {

	/// <summary>
	/// <b>D2D1_POINT_2F point</b>
	/// </summary>
	public readonly Vector2F Point {
		get => _point;
		init => _point = value;
	}
	readonly Vector2F _point;

	/// <summary>
	/// <b>D2D1_POINT_2F unitTangentVector</b>
	/// </summary>
	public readonly Vector2F UnitTangentVector {
		get => _unitTangentVector;
		init => _unitTangentVector = value;
	}
	readonly Vector2F _unitTangentVector;

	/// <summary>
	/// <b>UINT32 endSegment</b>
	/// </summary>
	public readonly uint EndSegment {
		get => _endSegment;
		init => _endSegment = value;
	}
	readonly uint _endSegment;

	/// <summary>
	/// <b>UINT32 endFigure</b>
	/// </summary>
	public readonly uint EndFigure {
		get => _endFigure;
		init => _endFigure = value;
	}
	readonly uint _endFigure;

	/// <summary>
	/// <b>FLOAT lengthToEndSegment</b>
	/// </summary>
	public readonly float LengthToEndSegment {
		get => _lengthToEndSegment;
		init => _lengthToEndSegment = value;
	}
	readonly float _lengthToEndSegment;

}

/// <summary>
/// STRUCTURE <b>D2D1_IMAGE_BRUSH_PROPERTIES</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ImageBrushProperties {

	/// <summary>
	/// <b>D2D1_RECT_F sourceRectangle</b>
	/// </summary>
	public readonly Vector4F SourceRectangle {
		get => _sourceRectangle;
		init => _sourceRectangle = value;
	}
	readonly Vector4F _sourceRectangle;

	/// <summary>
	/// <b>D2D1_EXTEND_MODE extendModeX</b>
	/// </summary>
	public readonly ExtendMode ExtendModeX {
		get => _extendModeX;
		init => _extendModeX = value;
	}
	readonly ExtendMode _extendModeX;

	/// <summary>
	/// <b>D2D1_EXTEND_MODE extendModeY</b>
	/// </summary>
	public readonly ExtendMode ExtendModeY {
		get => _extendModeY;
		init => _extendModeY = value;
	}
	readonly ExtendMode _extendModeY;

	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE interpolationMode</b>
	/// </summary>
	public readonly InterpolationMode InterpolationMode {
		get => _interpolationMode;
		init => _interpolationMode = value;
	}
	readonly InterpolationMode _interpolationMode;

}

/// <summary>
/// STRUCTURE <b>D2D1_BITMAP_BRUSH_PROPERTIES1</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BitmapBrushProperties1 {

	/// <summary>
	/// <b>D2D1_EXTEND_MODE extendModeX</b>
	/// </summary>
	public readonly ExtendMode ExtendModeX {
		get => _extendModeX;
		init => _extendModeX = value;
	}
	readonly ExtendMode _extendModeX;

	/// <summary>
	/// <b>D2D1_EXTEND_MODE extendModeY</b>
	/// </summary>
	public readonly ExtendMode ExtendModeY {
		get => _extendModeY;
		init => _extendModeY = value;
	}
	readonly ExtendMode _extendModeY;

	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE interpolationMode</b>
	/// </summary>
	public readonly InterpolationMode InterpolationMode {
		get => _interpolationMode;
		init => _interpolationMode = value;
	}
	readonly InterpolationMode _interpolationMode;

}

/// <summary>
/// STRUCTURE <b>D2D1_STROKE_STYLE_PROPERTIES1</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StrokeStyleProperties1 {

	/// <summary>
	/// <b>D2D1_CAP_STYLE startCap</b>
	/// </summary>
	public readonly CapStyle StartCap {
		get => _startCap;
		init => _startCap = value;
	}
	readonly CapStyle _startCap;

	/// <summary>
	/// <b>D2D1_CAP_STYLE endCap</b>
	/// </summary>
	public readonly CapStyle EndCap {
		get => _endCap;
		init => _endCap = value;
	}
	readonly CapStyle _endCap;

	/// <summary>
	/// <b>D2D1_CAP_STYLE dashCap</b>
	/// </summary>
	public readonly CapStyle DashCap {
		get => _dashCap;
		init => _dashCap = value;
	}
	readonly CapStyle _dashCap;

	/// <summary>
	/// <b>D2D1_LINE_JOIN lineJoin</b>
	/// </summary>
	public readonly LineJoin LineJoin {
		get => _lineJoin;
		init => _lineJoin = value;
	}
	readonly LineJoin _lineJoin;

	/// <summary>
	/// <b>FLOAT miterLimit</b>
	/// </summary>
	public readonly float MiterLimit {
		get => _miterLimit;
		init => _miterLimit = value;
	}
	readonly float _miterLimit;

	/// <summary>
	/// <b>D2D1_DASH_STYLE dashStyle</b>
	/// </summary>
	public readonly DashStyle DashStyle {
		get => _dashStyle;
		init => _dashStyle = value;
	}
	readonly DashStyle _dashStyle;

	/// <summary>
	/// <b>FLOAT dashOffset</b>
	/// </summary>
	public readonly float DashOffset {
		get => _dashOffset;
		init => _dashOffset = value;
	}
	readonly float _dashOffset;

	/// <summary>
	/// <b>D2D1_STROKE_TRANSFORM_TYPE transformType</b>
	/// </summary>
	public readonly StrokeTransformType TransformType {
		get => _transformType;
		init => _transformType = value;
	}
	readonly StrokeTransformType _transformType;

}

/// <summary>
/// STRUCTURE <b>D2D1_LAYER_PARAMETERS1</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LayerParameters1 {

	/// <summary>
	/// <b>D2D1_RECT_F contentBounds</b>
	/// </summary>
	public readonly Vector4F ContentBounds {
		get => _contentBounds;
		init => _contentBounds = value;
	}
	readonly Vector4F _contentBounds;

	/// <summary>
	/// <b>ID2D1Geometry* geometricMask</b>
	/// </summary>
	public readonly T* GeometricMask<T> () where T : unmanaged, IGeometry => (T*) _geometricMask;
	readonly void* _geometricMask;

	/// <summary>
	/// <b>D2D1_ANTIALIAS_MODE maskAntialiasMode</b>
	/// </summary>
	public readonly AntialiasMode MaskAntialiasMode {
		get => _maskAntialiasMode;
		init => _maskAntialiasMode = value;
	}
	readonly AntialiasMode _maskAntialiasMode;

	/// <summary>
	/// <b>D2D1_MATRIX_3X2_F maskTransform</b>
	/// </summary>
	public readonly Matrix3x2F MaskTransform {
		get => _maskTransform;
		init => _maskTransform = value;
	}
	readonly Matrix3x2F _maskTransform;

	/// <summary>
	/// <b>FLOAT opacity</b>
	/// </summary>
	public readonly float Opacity {
		get => _opacity;
		init => _opacity = value;
	}
	readonly float _opacity;

	/// <summary>
	/// <b>ID2D1Brush* opacityBrush</b>
	/// </summary>
	public readonly T* OpacityBrush<T> () where T : unmanaged, IBrush => (T*) _opacityBrush;
	readonly void* _opacityBrush;

	/// <summary>
	/// <b>D2D1_LAYER_OPTIONS1 layerOptions</b>
	/// </summary>
	public readonly LayerOptions1 LayerOptions {
		get => _layerOptions;
		init => _layerOptions = value;
	}
	readonly LayerOptions1 _layerOptions;

}

/// <summary>
/// STRUCTURE <b>D2D1_DRAWING_STATE_DESCRIPTION1</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DrawingStateDescription1 {

	/// <summary>
	/// <b>D2D1_ANTIALIAS_MODE antialiasMode</b>
	/// </summary>
	public readonly AntialiasMode AntialiasMode {
		get => _antialiasMode;
		init => _antialiasMode = value;
	}
	readonly AntialiasMode _antialiasMode;

	/// <summary>
	/// <b>D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode</b>
	/// </summary>
	public readonly TextAntialiasMode TextAntialiasMode {
		get => _textAntialiasMode;
		init => _textAntialiasMode = value;
	}
	readonly TextAntialiasMode _textAntialiasMode;

	/// <summary>
	/// <b>D2D1_TAG tag1</b>
	/// </summary>
	public readonly ulong Tag1 {
		get => _tag1;
		init => _tag1 = value;
	}
	readonly ulong _tag1;

	/// <summary>
	/// <b>D2D1_TAG tag2</b>
	/// </summary>
	public readonly ulong Tag2 {
		get => _tag2;
		init => _tag2 = value;
	}
	readonly ulong _tag2;

	/// <summary>
	/// <b>D2D1_MATRIX_3X2_F transform</b>
	/// </summary>
	public readonly Matrix3x2F Transform {
		get => _transform;
		init => _transform = value;
	}
	readonly Matrix3x2F _transform;

	/// <summary>
	/// <b>D2D1_PRIMITIVE_BLEND primitiveBlend</b>
	/// </summary>
	public readonly PrimitiveBlend PrimitiveBlend {
		get => _primitiveBlend;
		init => _primitiveBlend = value;
	}
	readonly PrimitiveBlend _primitiveBlend;

	/// <summary>
	/// <b>D2D1_UNIT_MODE unitMode</b>
	/// </summary>
	public readonly UnitMode UnitMode {
		get => _unitMode;
		init => _unitMode = value;
	}
	readonly UnitMode _unitMode;

}

/// <summary>
/// STRUCTURE <b>D2D1_PRINT_CONTROL_PROPERTIES</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PrintControlProperties {

	/// <summary>
	/// <b>D2D1_PRINT_FONT_SUBSET_MODE fontSubset</b>
	/// </summary>
	public readonly PrintFontSubsetMode FontSubset {
		get => _fontSubset;
		init => _fontSubset = value;
	}
	readonly PrintFontSubsetMode _fontSubset;

	/// <summary>
	/// <b>FLOAT rasterDPI</b>
	/// </summary>
	public readonly float RasterDPI {
		get => _rasterDPI;
		init => _rasterDPI = value;
	}
	readonly float _rasterDPI;

	/// <summary>
	/// <b>D2D1_COLOR_SPACE colorSpace</b>
	/// </summary>
	public readonly ColorSpace ColorSpace {
		get => _colorSpace;
		init => _colorSpace = value;
	}
	readonly ColorSpace _colorSpace;

}

/// <summary>
/// STRUCTURE <b>D2D1_CREATION_PROPERTIES</b><br/>
/// D2D1_1.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct CreationProperties {

	/// <summary>
	/// <b>D2D1_THREADING_MODE threadingMode</b>
	/// </summary>
	public readonly ThreadingMode ThreadingMode {
		get => _threadingMode;
		init => _threadingMode = value;
	}
	readonly ThreadingMode _threadingMode;

	/// <summary>
	/// <b>D2D1_DEBUG_LEVEL debugLevel</b>
	/// </summary>
	public readonly DebugLevel DebugLevel {
		get => _debugLevel;
		init => _debugLevel = value;
	}
	readonly DebugLevel _debugLevel;

	/// <summary>
	/// <b>D2D1_DEVICE_CONTEXT_OPTIONS options</b>
	/// </summary>
	public readonly DeviceContextOptions Options {
		get => _options;
		init => _options = value;
	}
	readonly DeviceContextOptions _options;

}

/// <summary>
/// STRUCTURE <b>D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES</b><br/>
/// D2D1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TransformedImageSourceProperties {

	/// <summary>
	/// <b>D2D1_ORIENTATION orientation</b>
	/// </summary>
	public readonly Orientation Orientation {
		get => _orientation;
		init => _orientation = value;
	}
	readonly Orientation _orientation;

	/// <summary>
	/// <b>FLOAT scaleX</b>
	/// </summary>
	public readonly float ScaleX {
		get => _scaleX;
		init => _scaleX = value;
	}
	readonly float _scaleX;

	/// <summary>
	/// <b>FLOAT scaleY</b>
	/// </summary>
	public readonly float ScaleY {
		get => _scaleY;
		init => _scaleY = value;
	}
	readonly float _scaleY;

	/// <summary>
	/// <b>D2D1_INTERPOLATION_MODE interpolationMode</b>
	/// </summary>
	public readonly InterpolationMode InterpolationMode {
		get => _interpolationMode;
		init => _interpolationMode = value;
	}
	readonly InterpolationMode _interpolationMode;

	/// <summary>
	/// <b>D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS options</b>
	/// </summary>
	public readonly TransformedImageSourceOptions Options {
		get => _options;
		init => _options = value;
	}
	readonly TransformedImageSourceOptions _options;

}

/// <summary>
/// STRUCTURE <b>D2D1_INK_POINT</b><br/>
/// D2D1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InkPoint {

	/// <summary>
	/// <b>FLOAT x</b>
	/// </summary>
	public readonly float X {
		get => _x;
		init => _x = value;
	}
	readonly float _x;

	/// <summary>
	/// <b>FLOAT y</b>
	/// </summary>
	public readonly float Y {
		get => _y;
		init => _y = value;
	}
	readonly float _y;

	/// <summary>
	/// <b>FLOAT radius</b>
	/// </summary>
	public readonly float Radius {
		get => _radius;
		init => _radius = value;
	}
	readonly float _radius;

}

/// <summary>
/// STRUCTURE <b>D2D1_INK_BEZIER_SEGMENT</b><br/>
/// D2D1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InkBezierSegment {

	/// <summary>
	/// <b>D2D1_INK_POINT point1</b>
	/// </summary>
	public readonly InkPoint Point1 {
		get => _point1;
		init => _point1 = value;
	}
	readonly InkPoint _point1;

	/// <summary>
	/// <b>D2D1_INK_POINT point2</b>
	/// </summary>
	public readonly InkPoint Point2 {
		get => _point2;
		init => _point2 = value;
	}
	readonly InkPoint _point2;

	/// <summary>
	/// <b>D2D1_INK_POINT point3</b>
	/// </summary>
	public readonly InkPoint Point3 {
		get => _point3;
		init => _point3 = value;
	}
	readonly InkPoint _point3;

}

/// <summary>
/// STRUCTURE <b>D2D1_INK_STYLE_PROPERTIES</b><br/>
/// D2D1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InkStyleProperties {

	/// <summary>
	/// <b>D2D1_INK_NIB_SHAPE nibShape</b>
	/// </summary>
	public readonly InkNibShape NibShape {
		get => _nibShape;
		init => _nibShape = value;
	}
	readonly InkNibShape _nibShape;

	/// <summary>
	/// <b>D2D1_MATRIX_3X2_F nibTransform</b>
	/// </summary>
	public readonly Matrix3x2F NibTransform {
		get => _nibTransform;
		init => _nibTransform = value;
	}
	readonly Matrix3x2F _nibTransform;

}

/// <summary>
/// STRUCTURE <b>D2D1_GRADIENT_MESH_PATCH</b><br/>
/// D2D1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GradientMeshPatch {

	/// <summary>
	/// <b>D2D1_POINT_2F point00</b>
	/// </summary>
	public readonly Vector2F Point00 {
		get => _point00;
		init => _point00 = value;
	}
	readonly Vector2F _point00;

	/// <summary>
	/// <b>D2D1_POINT_2F point01</b>
	/// </summary>
	public readonly Vector2F Point01 {
		get => _point01;
		init => _point01 = value;
	}
	readonly Vector2F _point01;

	/// <summary>
	/// <b>D2D1_POINT_2F point02</b>
	/// </summary>
	public readonly Vector2F Point02 {
		get => _point02;
		init => _point02 = value;
	}
	readonly Vector2F _point02;

	/// <summary>
	/// <b>D2D1_POINT_2F point03</b>
	/// </summary>
	public readonly Vector2F Point03 {
		get => _point03;
		init => _point03 = value;
	}
	readonly Vector2F _point03;

	/// <summary>
	/// <b>D2D1_POINT_2F point10</b>
	/// </summary>
	public readonly Vector2F Point10 {
		get => _point10;
		init => _point10 = value;
	}
	readonly Vector2F _point10;

	/// <summary>
	/// <b>D2D1_POINT_2F point11</b>
	/// </summary>
	public readonly Vector2F Point11 {
		get => _point11;
		init => _point11 = value;
	}
	readonly Vector2F _point11;

	/// <summary>
	/// <b>D2D1_POINT_2F point12</b>
	/// </summary>
	public readonly Vector2F Point12 {
		get => _point12;
		init => _point12 = value;
	}
	readonly Vector2F _point12;

	/// <summary>
	/// <b>D2D1_POINT_2F point13</b>
	/// </summary>
	public readonly Vector2F Point13 {
		get => _point13;
		init => _point13 = value;
	}
	readonly Vector2F _point13;

	/// <summary>
	/// <b>D2D1_POINT_2F point20</b>
	/// </summary>
	public readonly Vector2F Point20 {
		get => _point20;
		init => _point20 = value;
	}
	readonly Vector2F _point20;

	/// <summary>
	/// <b>D2D1_POINT_2F point21</b>
	/// </summary>
	public readonly Vector2F Point21 {
		get => _point21;
		init => _point21 = value;
	}
	readonly Vector2F _point21;

	/// <summary>
	/// <b>D2D1_POINT_2F point22</b>
	/// </summary>
	public readonly Vector2F Point22 {
		get => _point22;
		init => _point22 = value;
	}
	readonly Vector2F _point22;

	/// <summary>
	/// <b>D2D1_POINT_2F point23</b>
	/// </summary>
	public readonly Vector2F Point23 {
		get => _point23;
		init => _point23 = value;
	}
	readonly Vector2F _point23;

	/// <summary>
	/// <b>D2D1_POINT_2F point30</b>
	/// </summary>
	public readonly Vector2F Point30 {
		get => _point30;
		init => _point30 = value;
	}
	readonly Vector2F _point30;

	/// <summary>
	/// <b>D2D1_POINT_2F point31</b>
	/// </summary>
	public readonly Vector2F Point31 {
		get => _point31;
		init => _point31 = value;
	}
	readonly Vector2F _point31;

	/// <summary>
	/// <b>D2D1_POINT_2F point32</b>
	/// </summary>
	public readonly Vector2F Point32 {
		get => _point32;
		init => _point32 = value;
	}
	readonly Vector2F _point32;

	/// <summary>
	/// <b>D2D1_POINT_2F point33</b>
	/// </summary>
	public readonly Vector2F Point33 {
		get => _point33;
		init => _point33 = value;
	}
	readonly Vector2F _point33;

	/// <summary>
	/// <b>D2D1_COLOR_F color00</b>
	/// </summary>
	public readonly Vector4F Color00 {
		get => _color00;
		init => _color00 = value;
	}
	readonly Vector4F _color00;

	/// <summary>
	/// <b>D2D1_COLOR_F color03</b>
	/// </summary>
	public readonly Vector4F Color03 {
		get => _color03;
		init => _color03 = value;
	}
	readonly Vector4F _color03;

	/// <summary>
	/// <b>D2D1_COLOR_F color30</b>
	/// </summary>
	public readonly Vector4F Color30 {
		get => _color30;
		init => _color30 = value;
	}
	readonly Vector4F _color30;

	/// <summary>
	/// <b>D2D1_COLOR_F color33</b>
	/// </summary>
	public readonly Vector4F Color33 {
		get => _color33;
		init => _color33 = value;
	}
	readonly Vector4F _color33;

	/// <summary>
	/// <b>D2D1_PATCH_EDGE_MODE topEdgeMode</b>
	/// </summary>
	public readonly PatchEdgeMode TopEdgeMode {
		get => _topEdgeMode;
		init => _topEdgeMode = value;
	}
	readonly PatchEdgeMode _topEdgeMode;

	/// <summary>
	/// <b>D2D1_PATCH_EDGE_MODE leftEdgeMode</b>
	/// </summary>
	public readonly PatchEdgeMode LeftEdgeMode {
		get => _leftEdgeMode;
		init => _leftEdgeMode = value;
	}
	readonly PatchEdgeMode _leftEdgeMode;

	/// <summary>
	/// <b>D2D1_PATCH_EDGE_MODE bottomEdgeMode</b>
	/// </summary>
	public readonly PatchEdgeMode BottomEdgeMode {
		get => _bottomEdgeMode;
		init => _bottomEdgeMode = value;
	}
	readonly PatchEdgeMode _bottomEdgeMode;

	/// <summary>
	/// <b>D2D1_PATCH_EDGE_MODE rightEdgeMode</b>
	/// </summary>
	public readonly PatchEdgeMode RightEdgeMode {
		get => _rightEdgeMode;
		init => _rightEdgeMode = value;
	}
	readonly PatchEdgeMode _rightEdgeMode;

}

/// <summary>
/// STRUCTURE <b>D2D1_SIMPLE_COLOR_PROFILE</b><br/>
/// D2D1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SimpleColorProfile {

	/// <summary>
	/// <b>D2D1_POINT_2F redPrimary</b>
	/// </summary>
	public readonly Vector2F RedPrimary {
		get => _redPrimary;
		init => _redPrimary = value;
	}
	readonly Vector2F _redPrimary;

	/// <summary>
	/// <b>D2D1_POINT_2F greenPrimary</b>
	/// </summary>
	public readonly Vector2F GreenPrimary {
		get => _greenPrimary;
		init => _greenPrimary = value;
	}
	readonly Vector2F _greenPrimary;

	/// <summary>
	/// <b>D2D1_POINT_2F bluePrimary</b>
	/// </summary>
	public readonly Vector2F BluePrimary {
		get => _bluePrimary;
		init => _bluePrimary = value;
	}
	readonly Vector2F _bluePrimary;

	/// <summary>
	/// <b>D2D1_POINT_2F whitePointXZ</b>
	/// </summary>
	public readonly Vector2F WhitePointXZ {
		get => _whitePointXZ;
		init => _whitePointXZ = value;
	}
	readonly Vector2F _whitePointXZ;

	/// <summary>
	/// <b>D2D1_GAMMA1 gamma</b>
	/// </summary>
	public readonly Gamma1 Gamma {
		get => _gamma;
		init => _gamma = value;
	}
	readonly Gamma1 _gamma;

}

/// <summary>
/// STRUCTURE <b>D2D1_PIXEL_FORMAT</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PixelFormat {

	/// <summary>
	/// <b>DXGI_FORMAT format</b>
	/// </summary>
	public readonly DXGI.Format Format {
		get => _format;
		init => _format = value;
	}
	readonly DXGI.Format _format;

	/// <summary>
	/// <b>D2D1_ALPHA_MODE alphaMode</b>
	/// </summary>
	public readonly AlphaMode AlphaMode {
		get => _alphaMode;
		init => _alphaMode = value;
	}
	readonly AlphaMode _alphaMode;

}

/*

/// <summary>
/// STRUCTURE <b>D2D_POINT_2U</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Point2U {

	/// <summary>
	/// <b>UINT32 x</b>
	/// </summary>
	public readonly uint X {
		get => _x;
		init => _x = value;
	}
	readonly uint _x;

	/// <summary>
	/// <b>UINT32 y</b>
	/// </summary>
	public readonly uint Y {
		get => _y;
		init => _y = value;
	}
	readonly uint _y;

}

/// <summary>
/// STRUCTURE <b>D2D_POINT_2F</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Point2F {

	/// <summary>
	/// <b>FLOAT x</b>
	/// </summary>
	public readonly float X {
		get => _x;
		init => _x = value;
	}
	readonly float _x;

	/// <summary>
	/// <b>FLOAT y</b>
	/// </summary>
	public readonly float Y {
		get => _y;
		init => _y = value;
	}
	readonly float _y;

}

/// <summary>
/// STRUCTURE <b>D2D_VECTOR_2F</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Vector2F {

	/// <summary>
	/// <b>FLOAT x</b>
	/// </summary>
	public readonly float X {
		get => _x;
		init => _x = value;
	}
	readonly float _x;

	/// <summary>
	/// <b>FLOAT y</b>
	/// </summary>
	public readonly float Y {
		get => _y;
		init => _y = value;
	}
	readonly float _y;

}

/// <summary>
/// STRUCTURE <b>D2D_VECTOR_3F</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Vector3F {

	/// <summary>
	/// <b>FLOAT x</b>
	/// </summary>
	public readonly float X {
		get => _x;
		init => _x = value;
	}
	readonly float _x;

	/// <summary>
	/// <b>FLOAT y</b>
	/// </summary>
	public readonly float Y {
		get => _y;
		init => _y = value;
	}
	readonly float _y;

	/// <summary>
	/// <b>FLOAT z</b>
	/// </summary>
	public readonly float Z {
		get => _z;
		init => _z = value;
	}
	readonly float _z;

}

/// <summary>
/// STRUCTURE <b>D2D_VECTOR_4F</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Vector4F {

	/// <summary>
	/// <b>FLOAT x</b>
	/// </summary>
	public readonly float X {
		get => _x;
		init => _x = value;
	}
	readonly float _x;

	/// <summary>
	/// <b>FLOAT y</b>
	/// </summary>
	public readonly float Y {
		get => _y;
		init => _y = value;
	}
	readonly float _y;

	/// <summary>
	/// <b>FLOAT z</b>
	/// </summary>
	public readonly float Z {
		get => _z;
		init => _z = value;
	}
	readonly float _z;

	/// <summary>
	/// <b>FLOAT w</b>
	/// </summary>
	public readonly float W {
		get => _w;
		init => _w = value;
	}
	readonly float _w;

}

/// <summary>
/// STRUCTURE <b>D2D_RECT_F</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RectF {

	/// <summary>
	/// <b>FLOAT left</b>
	/// </summary>
	public readonly float Left {
		get => _left;
		init => _left = value;
	}
	readonly float _left;

	/// <summary>
	/// <b>FLOAT top</b>
	/// </summary>
	public readonly float Top {
		get => _top;
		init => _top = value;
	}
	readonly float _top;

	/// <summary>
	/// <b>FLOAT right</b>
	/// </summary>
	public readonly float Right {
		get => _right;
		init => _right = value;
	}
	readonly float _right;

	/// <summary>
	/// <b>FLOAT bottom</b>
	/// </summary>
	public readonly float Bottom {
		get => _bottom;
		init => _bottom = value;
	}
	readonly float _bottom;

}

/// <summary>
/// STRUCTURE <b>D2D_RECT_U</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RectU {

	/// <summary>
	/// <b>UINT32 left</b>
	/// </summary>
	public readonly uint Left {
		get => _left;
		init => _left = value;
	}
	readonly uint _left;

	/// <summary>
	/// <b>UINT32 top</b>
	/// </summary>
	public readonly uint Top {
		get => _top;
		init => _top = value;
	}
	readonly uint _top;

	/// <summary>
	/// <b>UINT32 right</b>
	/// </summary>
	public readonly uint Right {
		get => _right;
		init => _right = value;
	}
	readonly uint _right;

	/// <summary>
	/// <b>UINT32 bottom</b>
	/// </summary>
	public readonly uint Bottom {
		get => _bottom;
		init => _bottom = value;
	}
	readonly uint _bottom;

}

/// <summary>
/// STRUCTURE <b>D2D_SIZE_F</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SizeF {

	/// <summary>
	/// <b>FLOAT width</b>
	/// </summary>
	public readonly float Width {
		get => _width;
		init => _width = value;
	}
	readonly float _width;

	/// <summary>
	/// <b>FLOAT height</b>
	/// </summary>
	public readonly float Height {
		get => _height;
		init => _height = value;
	}
	readonly float _height;

}

/// <summary>
/// STRUCTURE <b>D2D_SIZE_U</b><br/>
/// DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SizeU {

	/// <summary>
	/// <b>UINT32 width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT32 height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

}

*/
