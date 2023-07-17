using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// STRUCTURE <b>WICBitmapPattern</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BitmapPattern {

	/// <summary>
	/// <b>ULARGE_INTEGER Position</b>
	/// </summary>
	public readonly ulong Position {
		get => _position;
		init => _position = value;
	}
	readonly ulong _position;

	/// <summary>
	/// <b>ULONG Length</b>
	/// </summary>
	public readonly uint Length {
		get => _length;
		init => _length = value;
	}
	readonly uint _length;

	/// <summary>
	/// <b>BYTE* Pattern</b>
	/// </summary>
	public readonly byte* Pattern {
		get => _pattern;
		init => _pattern = value;
	}
	readonly byte* _pattern;

	/// <summary>
	/// <b>BYTE* Mask</b>
	/// </summary>
	public readonly byte* Mask {
		get => _mask;
		init => _mask = value;
	}
	readonly byte* _mask;

	/// <summary>
	/// <b>BOOL EndOfStream</b>
	/// </summary>
	public readonly bool EndOfStream {
		get => _endOfStream != 0;
		init => _endOfStream = value ? 1U : 0U;
	}
	readonly uint _endOfStream;

}

/// <summary>
/// STRUCTURE <b>WICImageParameters</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ImageParameters {

	/// <summary>
	/// <b>D2D1_PIXEL_FORMAT PixelFormat</b>
	/// </summary>
	public readonly Direct2D.PixelFormat PixelFormat {
		get => _pixelFormat;
		init => _pixelFormat = value;
	}
	readonly Direct2D.PixelFormat _pixelFormat;

	/// <summary>
	/// <b>FLOAT DpiX</b>
	/// </summary>
	public readonly float DpiX {
		get => _dpiX;
		init => _dpiX = value;
	}
	readonly float _dpiX;

	/// <summary>
	/// <b>FLOAT DpiY</b>
	/// </summary>
	public readonly float DpiY {
		get => _dpiY;
		init => _dpiY = value;
	}
	readonly float _dpiY;

	/// <summary>
	/// <b>FLOAT Top</b>
	/// </summary>
	public readonly float Top {
		get => _top;
		init => _top = value;
	}
	readonly float _top;

	/// <summary>
	/// <b>FLOAT Left</b>
	/// </summary>
	public readonly float Left {
		get => _left;
		init => _left = value;
	}
	readonly float _left;

	/// <summary>
	/// <b>UINT32 PixelWidth</b>
	/// </summary>
	public readonly uint PixelWidth {
		get => _pixelWidth;
		init => _pixelWidth = value;
	}
	readonly uint _pixelWidth;

	/// <summary>
	/// <b>UINT32 PixelHeight</b>
	/// </summary>
	public readonly uint PixelHeight {
		get => _pixelHeight;
		init => _pixelHeight = value;
	}
	readonly uint _pixelHeight;

}

/// <summary>
/// STRUCTURE <b>WICBitmapPlaneDescription</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BitmapPlaneDescription {

	/// <summary>
	/// <b>WICPixelFormatGUID Format</b>
	/// </summary>
	public readonly Guid Format {
		get => _format;
		init => _format = value;
	}
	readonly Guid _format;

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

}

/// <summary>
/// STRUCTURE <b>WICBitmapPlane</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct BitmapPlane {

	/// <summary>
	/// <b>WICPixelFormatGUID Format</b>
	/// </summary>
	public readonly Guid Format {
		get => _format;
		init => _format = value;
	}
	readonly Guid _format;

	/// <summary>
	/// <b>BYTE* pbBuffer</b>
	/// </summary>
	public readonly byte* PbBuffer {
		get => _pbBuffer;
		init => _pbBuffer = value;
	}
	readonly byte* _pbBuffer;

	/// <summary>
	/// <b>UINT cbStride</b>
	/// </summary>
	public readonly uint CbStride {
		get => _cbStride;
		init => _cbStride = value;
	}
	readonly uint _cbStride;

	/// <summary>
	/// <b>UINT cbBufferSize</b>
	/// </summary>
	public readonly uint CbBufferSize {
		get => _cbBufferSize;
		init => _cbBufferSize = value;
	}
	readonly uint _cbBufferSize;

}

/// <summary>
/// STRUCTURE <b>WICJpegFrameHeader</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct JpegFrameHeader {

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>WICJpegTransferMatrix TransferMatrix</b>
	/// </summary>
	public readonly JpegTransferMatrix TransferMatrix {
		get => _transferMatrix;
		init => _transferMatrix = value;
	}
	readonly JpegTransferMatrix _transferMatrix;

	/// <summary>
	/// <b>WICJpegScanType ScanType</b>
	/// </summary>
	public readonly JpegScanType ScanType {
		get => _scanType;
		init => _scanType = value;
	}
	readonly JpegScanType _scanType;

	/// <summary>
	/// <b>UINT cComponents</b>
	/// </summary>
	public readonly uint CComponents {
		get => _cComponents;
		init => _cComponents = value;
	}
	readonly uint _cComponents;

	/// <summary>
	/// <b>DWORD ComponentIdentifiers</b>
	/// </summary>
	public readonly uint ComponentIdentifiers {
		get => _componentIdentifiers;
		init => _componentIdentifiers = value;
	}
	readonly uint _componentIdentifiers;

	/// <summary>
	/// <b>DWORD SampleFactors</b>
	/// </summary>
	public readonly uint SampleFactors {
		get => _sampleFactors;
		init => _sampleFactors = value;
	}
	readonly uint _sampleFactors;

	/// <summary>
	/// <b>DWORD QuantizationTableIndices</b>
	/// </summary>
	public readonly uint QuantizationTableIndices {
		get => _quantizationTableIndices;
		init => _quantizationTableIndices = value;
	}
	readonly uint _quantizationTableIndices;

}

/// <summary>
/// STRUCTURE <b>WICJpegScanHeader</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct JpegScanHeader {

	/// <summary>
	/// <b>UINT cComponents</b>
	/// </summary>
	public readonly uint CComponents {
		get => _cComponents;
		init => _cComponents = value;
	}
	readonly uint _cComponents;

	/// <summary>
	/// <b>UINT RestartInterval</b>
	/// </summary>
	public readonly uint RestartInterval {
		get => _restartInterval;
		init => _restartInterval = value;
	}
	readonly uint _restartInterval;

	/// <summary>
	/// <b>DWORD ComponentSelectors</b>
	/// </summary>
	public readonly uint ComponentSelectors {
		get => _componentSelectors;
		init => _componentSelectors = value;
	}
	readonly uint _componentSelectors;

	/// <summary>
	/// <b>DWORD HuffmanTableIndices</b>
	/// </summary>
	public readonly uint HuffmanTableIndices {
		get => _huffmanTableIndices;
		init => _huffmanTableIndices = value;
	}
	readonly uint _huffmanTableIndices;

	/// <summary>
	/// <b>BYTE StartSpectralSelection</b>
	/// </summary>
	public readonly byte StartSpectralSelection {
		get => _startSpectralSelection;
		init => _startSpectralSelection = value;
	}
	readonly byte _startSpectralSelection;

	/// <summary>
	/// <b>BYTE EndSpectralSelection</b>
	/// </summary>
	public readonly byte EndSpectralSelection {
		get => _endSpectralSelection;
		init => _endSpectralSelection = value;
	}
	readonly byte _endSpectralSelection;

	/// <summary>
	/// <b>BYTE SuccessiveApproximationHigh</b>
	/// </summary>
	public readonly byte SuccessiveApproximationHigh {
		get => _successiveApproximationHigh;
		init => _successiveApproximationHigh = value;
	}
	readonly byte _successiveApproximationHigh;

	/// <summary>
	/// <b>BYTE SuccessiveApproximationLow</b>
	/// </summary>
	public readonly byte SuccessiveApproximationLow {
		get => _successiveApproximationLow;
		init => _successiveApproximationLow = value;
	}
	readonly byte _successiveApproximationLow;

}

/// <summary>
/// STRUCTURE <b>WICRawCapabilitiesInfo</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RawCapabilitiesInfo {

	/// <summary>
	/// <b>UINT cbSize</b>
	/// </summary>
	public readonly uint CbSize {
		get => _cbSize;
		init => _cbSize = value;
	}
	readonly uint _cbSize;

	/// <summary>
	/// <b>UINT CodecMajorVersion</b>
	/// </summary>
	public readonly uint CodecMajorVersion {
		get => _codecMajorVersion;
		init => _codecMajorVersion = value;
	}
	readonly uint _codecMajorVersion;

	/// <summary>
	/// <b>UINT CodecMinorVersion</b>
	/// </summary>
	public readonly uint CodecMinorVersion {
		get => _codecMinorVersion;
		init => _codecMinorVersion = value;
	}
	readonly uint _codecMinorVersion;

	/// <summary>
	/// <b>WICRawCapabilities ExposureCompensationSupport</b>
	/// </summary>
	public readonly RawCapabilities ExposureCompensationSupport {
		get => _exposureCompensationSupport;
		init => _exposureCompensationSupport = value;
	}
	readonly RawCapabilities _exposureCompensationSupport;

	/// <summary>
	/// <b>WICRawCapabilities ContrastSupport</b>
	/// </summary>
	public readonly RawCapabilities ContrastSupport {
		get => _contrastSupport;
		init => _contrastSupport = value;
	}
	readonly RawCapabilities _contrastSupport;

	/// <summary>
	/// <b>WICRawCapabilities RGBWhitePointSupport</b>
	/// </summary>
	public readonly RawCapabilities RGBWhitePointSupport {
		get => _rGBWhitePointSupport;
		init => _rGBWhitePointSupport = value;
	}
	readonly RawCapabilities _rGBWhitePointSupport;

	/// <summary>
	/// <b>WICRawCapabilities NamedWhitePointSupport</b>
	/// </summary>
	public readonly RawCapabilities NamedWhitePointSupport {
		get => _namedWhitePointSupport;
		init => _namedWhitePointSupport = value;
	}
	readonly RawCapabilities _namedWhitePointSupport;

	/// <summary>
	/// <b>UINT NamedWhitePointSupportMask</b>
	/// </summary>
	public readonly uint NamedWhitePointSupportMask {
		get => _namedWhitePointSupportMask;
		init => _namedWhitePointSupportMask = value;
	}
	readonly uint _namedWhitePointSupportMask;

	/// <summary>
	/// <b>WICRawCapabilities KelvinWhitePointSupport</b>
	/// </summary>
	public readonly RawCapabilities KelvinWhitePointSupport {
		get => _kelvinWhitePointSupport;
		init => _kelvinWhitePointSupport = value;
	}
	readonly RawCapabilities _kelvinWhitePointSupport;

	/// <summary>
	/// <b>WICRawCapabilities GammaSupport</b>
	/// </summary>
	public readonly RawCapabilities GammaSupport {
		get => _gammaSupport;
		init => _gammaSupport = value;
	}
	readonly RawCapabilities _gammaSupport;

	/// <summary>
	/// <b>WICRawCapabilities TintSupport</b>
	/// </summary>
	public readonly RawCapabilities TintSupport {
		get => _tintSupport;
		init => _tintSupport = value;
	}
	readonly RawCapabilities _tintSupport;

	/// <summary>
	/// <b>WICRawCapabilities SaturationSupport</b>
	/// </summary>
	public readonly RawCapabilities SaturationSupport {
		get => _saturationSupport;
		init => _saturationSupport = value;
	}
	readonly RawCapabilities _saturationSupport;

	/// <summary>
	/// <b>WICRawCapabilities SharpnessSupport</b>
	/// </summary>
	public readonly RawCapabilities SharpnessSupport {
		get => _sharpnessSupport;
		init => _sharpnessSupport = value;
	}
	readonly RawCapabilities _sharpnessSupport;

	/// <summary>
	/// <b>WICRawCapabilities NoiseReductionSupport</b>
	/// </summary>
	public readonly RawCapabilities NoiseReductionSupport {
		get => _noiseReductionSupport;
		init => _noiseReductionSupport = value;
	}
	readonly RawCapabilities _noiseReductionSupport;

	/// <summary>
	/// <b>WICRawCapabilities DestinationColorProfileSupport</b>
	/// </summary>
	public readonly RawCapabilities DestinationColorProfileSupport {
		get => _destinationColorProfileSupport;
		init => _destinationColorProfileSupport = value;
	}
	readonly RawCapabilities _destinationColorProfileSupport;

	/// <summary>
	/// <b>WICRawCapabilities ToneCurveSupport</b>
	/// </summary>
	public readonly RawCapabilities ToneCurveSupport {
		get => _toneCurveSupport;
		init => _toneCurveSupport = value;
	}
	readonly RawCapabilities _toneCurveSupport;

	/// <summary>
	/// <b>WICRawRotationCapabilities RotationSupport</b>
	/// </summary>
	public readonly RawRotationCapabilities RotationSupport {
		get => _rotationSupport;
		init => _rotationSupport = value;
	}
	readonly RawRotationCapabilities _rotationSupport;

	/// <summary>
	/// <b>WICRawCapabilities RenderModeSupport</b>
	/// </summary>
	public readonly RawCapabilities RenderModeSupport {
		get => _renderModeSupport;
		init => _renderModeSupport = value;
	}
	readonly RawCapabilities _renderModeSupport;

}

/// <summary>
/// STRUCTURE <b>WICRawToneCurvePoint</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RawToneCurvePoint {

	/// <summary>
	/// <b>double Input</b>
	/// </summary>
	public readonly double Input {
		get => _input;
		init => _input = value;
	}
	readonly double _input;

	/// <summary>
	/// <b>double Output</b>
	/// </summary>
	public readonly double Output {
		get => _output;
		init => _output = value;
	}
	readonly double _output;

}

/// <summary>
/// STRUCTURE <b>WICRawToneCurve</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct RawToneCurve {

	/// <summary>
	/// <b>UINT cPoints</b>
	/// </summary>
	public readonly uint CPoints {
		get => _cPoints;
		init => _cPoints = value;
	}
	readonly uint _cPoints;

	/// <summary>
	/// <b>WICRawToneCurvePoint aPoints [1]</b>
	/// </summary>
	public readonly Span<RawToneCurvePoint> APoints {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _aPoints)), 1);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_181 {
		public RawToneCurvePoint _ASP_AUTO_GENERATED_FIELD_0;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_181 _aPoints;

}

/// <summary>
/// STRUCTURE <b>WICDdsParameters</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DdsParameters {

	/// <summary>
	/// <b>UINT Width</b>
	/// </summary>
	public readonly uint Width {
		get => _width;
		init => _width = value;
	}
	readonly uint _width;

	/// <summary>
	/// <b>UINT Height</b>
	/// </summary>
	public readonly uint Height {
		get => _height;
		init => _height = value;
	}
	readonly uint _height;

	/// <summary>
	/// <b>UINT Depth</b>
	/// </summary>
	public readonly uint Depth {
		get => _depth;
		init => _depth = value;
	}
	readonly uint _depth;

	/// <summary>
	/// <b>UINT MipLevels</b>
	/// </summary>
	public readonly uint MipLevels {
		get => _mipLevels;
		init => _mipLevels = value;
	}
	readonly uint _mipLevels;

	/// <summary>
	/// <b>UINT ArraySize</b>
	/// </summary>
	public readonly uint ArraySize {
		get => _arraySize;
		init => _arraySize = value;
	}
	readonly uint _arraySize;

	/// <summary>
	/// <b>DXGI_FORMAT DxgiFormat</b>
	/// </summary>
	public readonly DXGI.Format DxgiFormat {
		get => _dxgiFormat;
		init => _dxgiFormat = value;
	}
	readonly DXGI.Format _dxgiFormat;

	/// <summary>
	/// <b>WICDdsDimension Dimension</b>
	/// </summary>
	public readonly DdsDimension Dimension {
		get => _dimension;
		init => _dimension = value;
	}
	readonly DdsDimension _dimension;

	/// <summary>
	/// <b>WICDdsAlphaMode AlphaMode</b>
	/// </summary>
	public readonly DdsAlphaMode AlphaMode {
		get => _alphaMode;
		init => _alphaMode = value;
	}
	readonly DdsAlphaMode _alphaMode;

}

/// <summary>
/// STRUCTURE <b>WICDdsFormatInfo</b><br/>
/// WINCODEC.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DdsFormatInfo {

	/// <summary>
	/// <b>DXGI_FORMAT DxgiFormat</b>
	/// </summary>
	public readonly DXGI.Format DxgiFormat {
		get => _dxgiFormat;
		init => _dxgiFormat = value;
	}
	readonly DXGI.Format _dxgiFormat;

	/// <summary>
	/// <b>UINT BytesPerBlock</b>
	/// </summary>
	public readonly uint BytesPerBlock {
		get => _bytesPerBlock;
		init => _bytesPerBlock = value;
	}
	readonly uint _bytesPerBlock;

	/// <summary>
	/// <b>UINT BlockWidth</b>
	/// </summary>
	public readonly uint BlockWidth {
		get => _blockWidth;
		init => _blockWidth = value;
	}
	readonly uint _blockWidth;

	/// <summary>
	/// <b>UINT BlockHeight</b>
	/// </summary>
	public readonly uint BlockHeight {
		get => _blockHeight;
		init => _blockHeight = value;
	}
	readonly uint _blockHeight;

}

/// <summary>
/// STRUCTURE <b>WICMetadataPattern</b><br/>
/// WINCODECSDK.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MetadataPattern {

	/// <summary>
	/// <b>ULARGE_INTEGER Position</b>
	/// </summary>
	public readonly ulong Position {
		get => _position;
		init => _position = value;
	}
	readonly ulong _position;

	/// <summary>
	/// <b>ULONG Length</b>
	/// </summary>
	public readonly uint Length {
		get => _length;
		init => _length = value;
	}
	readonly uint _length;

	/// <summary>
	/// <b>BYTE* Pattern</b>
	/// </summary>
	public readonly byte* Pattern {
		get => _pattern;
		init => _pattern = value;
	}
	readonly byte* _pattern;

	/// <summary>
	/// <b>BYTE* Mask</b>
	/// </summary>
	public readonly byte* Mask {
		get => _mask;
		init => _mask = value;
	}
	readonly byte* _mask;

	/// <summary>
	/// <b>ULARGE_INTEGER DataOffset</b>
	/// </summary>
	public readonly ulong DataOffset {
		get => _dataOffset;
		init => _dataOffset = value;
	}
	readonly ulong _dataOffset;

}

/// <summary>
/// STRUCTURE <b>WICMetadataHeader</b><br/>
/// WINCODECSDK.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MetadataHeader {

	/// <summary>
	/// <b>ULARGE_INTEGER Position</b>
	/// </summary>
	public readonly ulong Position {
		get => _position;
		init => _position = value;
	}
	readonly ulong _position;

	/// <summary>
	/// <b>ULONG Length</b>
	/// </summary>
	public readonly uint Length {
		get => _length;
		init => _length = value;
	}
	readonly uint _length;

	/// <summary>
	/// <b>BYTE* Header</b>
	/// </summary>
	public readonly byte* Header {
		get => _header;
		init => _header = value;
	}
	readonly byte* _header;

	/// <summary>
	/// <b>ULARGE_INTEGER DataOffset</b>
	/// </summary>
	public readonly ulong DataOffset {
		get => _dataOffset;
		init => _dataOffset = value;
	}
	readonly ulong _dataOffset;

}

/// <summary>
/// CALLBACK <b>PFNProgressNotification</b><br/>
/// WINCODEC.h
/// </summary>
/// <param name="pvData">__RPC__in <b>LPVOID pvData</b></param>
/// <param name="uFrameNum"><b>ULONG uFrameNum</b></param>
/// <param name="operation"><b>WICProgressOperation operation</b></param>
/// <param name="dblProgress"><b>double dblProgress</b></param>
unsafe public delegate int ProgressNotificationDelegate (void* pvData, uint uFrameNum, ProgressOperation operation, double dblProgress);
