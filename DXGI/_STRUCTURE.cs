using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// STRUCTURE <b>DXGI_FRAME_STATISTICS</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FrameStatistics {

	/// <summary>
	/// <b>UINT PresentCount</b>
	/// </summary>
	public readonly uint PresentCount {
		get => _presentCount;
		init => _presentCount = value;
	}
	readonly uint _presentCount;

	/// <summary>
	/// <b>UINT PresentRefreshCount</b>
	/// </summary>
	public readonly uint PresentRefreshCount {
		get => _presentRefreshCount;
		init => _presentRefreshCount = value;
	}
	readonly uint _presentRefreshCount;

	/// <summary>
	/// <b>UINT SyncRefreshCount</b>
	/// </summary>
	public readonly uint SyncRefreshCount {
		get => _syncRefreshCount;
		init => _syncRefreshCount = value;
	}
	readonly uint _syncRefreshCount;

	/// <summary>
	/// <b>LARGE_INTEGER SyncQPCTime</b>
	/// </summary>
	public readonly long SyncQPCTime {
		get => _syncQPCTime;
		init => _syncQPCTime = value;
	}
	readonly long _syncQPCTime;

	/// <summary>
	/// <b>LARGE_INTEGER SyncGPUTime</b>
	/// </summary>
	public readonly long SyncGPUTime {
		get => _syncGPUTime;
		init => _syncGPUTime = value;
	}
	readonly long _syncGPUTime;

}

/// <summary>
/// STRUCTURE <b>DXGI_MAPPED_RECT</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MappedRect {

	/// <summary>
	/// <b>INT Pitch</b>
	/// </summary>
	public readonly int Pitch {
		get => _pitch;
		init => _pitch = value;
	}
	readonly int _pitch;

	/// <summary>
	/// <b>BYTE* pBits</b>
	/// </summary>
	public readonly byte* PBits {
		get => _pBits;
		init => _pBits = value;
	}
	readonly byte* _pBits;

}

/// <summary>
/// STRUCTURE <b>DXGI_ADAPTER_DESC</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AdapterDesc {

	/// <summary>
	/// <b>WCHAR Description [128]</b>
	/// </summary>
	public readonly Span<char> Description {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _description)), 128);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_153 {
		public fixed char _ASP_AUTO_GENERATED_FIELD_0 [128];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_153 _description;

	/// <summary>
	/// <b>UINT VendorId</b>
	/// </summary>
	public readonly uint VendorId {
		get => _vendorId;
		init => _vendorId = value;
	}
	readonly uint _vendorId;

	/// <summary>
	/// <b>UINT DeviceId</b>
	/// </summary>
	public readonly uint DeviceId {
		get => _deviceId;
		init => _deviceId = value;
	}
	readonly uint _deviceId;

	/// <summary>
	/// <b>UINT SubSysId</b>
	/// </summary>
	public readonly uint SubSysId {
		get => _subSysId;
		init => _subSysId = value;
	}
	readonly uint _subSysId;

	/// <summary>
	/// <b>UINT Revision</b>
	/// </summary>
	public readonly uint Revision {
		get => _revision;
		init => _revision = value;
	}
	readonly uint _revision;

	/// <summary>
	/// <b>SIZE_T DedicatedVideoMemory</b>
	/// </summary>
	public readonly nuint DedicatedVideoMemory {
		get => _dedicatedVideoMemory;
		init => _dedicatedVideoMemory = value;
	}
	readonly nuint _dedicatedVideoMemory;

	/// <summary>
	/// <b>SIZE_T DedicatedSystemMemory</b>
	/// </summary>
	public readonly nuint DedicatedSystemMemory {
		get => _dedicatedSystemMemory;
		init => _dedicatedSystemMemory = value;
	}
	readonly nuint _dedicatedSystemMemory;

	/// <summary>
	/// <b>SIZE_T SharedSystemMemory</b>
	/// </summary>
	public readonly nuint SharedSystemMemory {
		get => _sharedSystemMemory;
		init => _sharedSystemMemory = value;
	}
	readonly nuint _sharedSystemMemory;

	/// <summary>
	/// <b>LUID AdapterLuid</b>
	/// </summary>
	public readonly LUID AdapterLuid {
		get => _adapterLuid;
		init => _adapterLuid = value;
	}
	readonly LUID _adapterLuid;

}

/// <summary>
/// STRUCTURE <b>DXGI_OUTPUT_DESC</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OutputDesc {

	/// <summary>
	/// <b>WCHAR DeviceName [32]</b>
	/// </summary>
	public readonly Span<char> DeviceName {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _deviceName)), 32);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_154 {
		public fixed char _ASP_AUTO_GENERATED_FIELD_0 [32];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_154 _deviceName;

	/// <summary>
	/// <b>RECT DesktopCoordinates</b>
	/// </summary>
	public readonly Vector4I DesktopCoordinates {
		get => _desktopCoordinates;
		init => _desktopCoordinates = value;
	}
	readonly Vector4I _desktopCoordinates;

	/// <summary>
	/// <b>BOOL AttachedToDesktop</b>
	/// </summary>
	public readonly bool AttachedToDesktop {
		get => _attachedToDesktop != 0;
		init => _attachedToDesktop = value ? 1U : 0U;
	}
	readonly uint _attachedToDesktop;

	/// <summary>
	/// <b>DXGI_MODE_ROTATION Rotation</b>
	/// </summary>
	public readonly ModeRotation Rotation {
		get => _rotation;
		init => _rotation = value;
	}
	readonly ModeRotation _rotation;

	/// <summary>
	/// <b>HMONITOR Monitor</b>
	/// </summary>
	public readonly IntPtr Monitor {
		get => _monitor;
		init => _monitor = value;
	}
	readonly IntPtr _monitor;

}

/// <summary>
/// STRUCTURE <b>DXGI_SHARED_RESOURCE</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SharedResource {

	/// <summary>
	/// <b>HANDLE Handle</b>
	/// </summary>
	public readonly IntPtr Handle {
		get => _handle;
		init => _handle = value;
	}
	readonly IntPtr _handle;

}

/// <summary>
/// STRUCTURE <b>DXGI_SURFACE_DESC</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SurfaceDesc {

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
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly Format Format {
		get => _format;
		init => _format = value;
	}
	readonly Format _format;

	/// <summary>
	/// <b>DXGI_SAMPLE_DESC SampleDesc</b>
	/// </summary>
	public readonly SampleDesc SampleDesc {
		get => _sampleDesc;
		init => _sampleDesc = value;
	}
	readonly SampleDesc _sampleDesc;

}

/// <summary>
/// STRUCTURE <b>DXGI_SWAP_CHAIN_DESC</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SwapChainDesc {

	/// <summary>
	/// <b>DXGI_MODE_DESC BufferDesc</b>
	/// </summary>
	public readonly ModeDesc BufferDesc {
		get => _bufferDesc;
		init => _bufferDesc = value;
	}
	readonly ModeDesc _bufferDesc;

	/// <summary>
	/// <b>DXGI_SAMPLE_DESC SampleDesc</b>
	/// </summary>
	public readonly SampleDesc SampleDesc {
		get => _sampleDesc;
		init => _sampleDesc = value;
	}
	readonly SampleDesc _sampleDesc;

	/// <summary>
	/// <b>DXGI_USAGE BufferUsage</b>
	/// </summary>
	public readonly Usage BufferUsage {
		get => _bufferUsage;
		init => _bufferUsage = value;
	}
	readonly Usage _bufferUsage;

	/// <summary>
	/// <b>UINT BufferCount</b>
	/// </summary>
	public readonly uint BufferCount {
		get => _bufferCount;
		init => _bufferCount = value;
	}
	readonly uint _bufferCount;

	/// <summary>
	/// <b>HWND OutputWindow</b>
	/// </summary>
	public readonly IntPtr OutputWindow {
		get => _outputWindow;
		init => _outputWindow = value;
	}
	readonly IntPtr _outputWindow;

	/// <summary>
	/// <b>BOOL Windowed</b>
	/// </summary>
	public readonly bool Windowed {
		get => _windowed != 0;
		init => _windowed = value ? 1U : 0U;
	}
	readonly uint _windowed;

	/// <summary>
	/// <b>DXGI_SWAP_EFFECT SwapEffect</b>
	/// </summary>
	public readonly SwapEffect SwapEffect {
		get => _swapEffect;
		init => _swapEffect = value;
	}
	readonly SwapEffect _swapEffect;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

}

/// <summary>
/// STRUCTURE <b>DXGI_ADAPTER_DESC1</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AdapterDesc1 {

	/// <summary>
	/// <b>WCHAR Description [128]</b>
	/// </summary>
	public readonly Span<char> Description {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _description)), 128);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_155 {
		public fixed char _ASP_AUTO_GENERATED_FIELD_0 [128];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_155 _description;

	/// <summary>
	/// <b>UINT VendorId</b>
	/// </summary>
	public readonly uint VendorId {
		get => _vendorId;
		init => _vendorId = value;
	}
	readonly uint _vendorId;

	/// <summary>
	/// <b>UINT DeviceId</b>
	/// </summary>
	public readonly uint DeviceId {
		get => _deviceId;
		init => _deviceId = value;
	}
	readonly uint _deviceId;

	/// <summary>
	/// <b>UINT SubSysId</b>
	/// </summary>
	public readonly uint SubSysId {
		get => _subSysId;
		init => _subSysId = value;
	}
	readonly uint _subSysId;

	/// <summary>
	/// <b>UINT Revision</b>
	/// </summary>
	public readonly uint Revision {
		get => _revision;
		init => _revision = value;
	}
	readonly uint _revision;

	/// <summary>
	/// <b>SIZE_T DedicatedVideoMemory</b>
	/// </summary>
	public readonly nuint DedicatedVideoMemory {
		get => _dedicatedVideoMemory;
		init => _dedicatedVideoMemory = value;
	}
	readonly nuint _dedicatedVideoMemory;

	/// <summary>
	/// <b>SIZE_T DedicatedSystemMemory</b>
	/// </summary>
	public readonly nuint DedicatedSystemMemory {
		get => _dedicatedSystemMemory;
		init => _dedicatedSystemMemory = value;
	}
	readonly nuint _dedicatedSystemMemory;

	/// <summary>
	/// <b>SIZE_T SharedSystemMemory</b>
	/// </summary>
	public readonly nuint SharedSystemMemory {
		get => _sharedSystemMemory;
		init => _sharedSystemMemory = value;
	}
	readonly nuint _sharedSystemMemory;

	/// <summary>
	/// <b>LUID AdapterLuid</b>
	/// </summary>
	public readonly LUID AdapterLuid {
		get => _adapterLuid;
		init => _adapterLuid = value;
	}
	readonly LUID _adapterLuid;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

}

/// <summary>
/// STRUCTURE <b>DXGI_DISPLAY_COLOR_SPACE</b><br/>
/// DXGI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DisplayColorSpace {

	/// <summary>
	/// <b>FLOAT PrimaryCoordinates [8][2]</b>
	/// </summary>
	public readonly Span<float> PrimaryCoordinates {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _primaryCoordinates)), 8 * 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_156 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [8 * 2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_156 _primaryCoordinates;

	/// <summary>
	/// <b>FLOAT WhitePoints [16][2]</b>
	/// </summary>
	public readonly Span<float> WhitePoints {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _whitePoints)), 16 * 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_157 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [16 * 2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_157 _whitePoints;

}

/// <summary>
/// STRUCTURE <b>DXGI_OUTDUPL_MOVE_RECT</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OutduplMoveRect {

	/// <summary>
	/// <b>POINT SourcePoint</b>
	/// </summary>
	public readonly Vector2I SourcePoint {
		get => _sourcePoint;
		init => _sourcePoint = value;
	}
	readonly Vector2I _sourcePoint;

	/// <summary>
	/// <b>RECT DestinationRect</b>
	/// </summary>
	public readonly Vector4I DestinationRect {
		get => _destinationRect;
		init => _destinationRect = value;
	}
	readonly Vector4I _destinationRect;

}

/// <summary>
/// STRUCTURE <b>DXGI_OUTDUPL_DESC</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OutduplDesc {

	/// <summary>
	/// <b>DXGI_MODE_DESC ModeDesc</b>
	/// </summary>
	public readonly ModeDesc ModeDesc {
		get => _modeDesc;
		init => _modeDesc = value;
	}
	readonly ModeDesc _modeDesc;

	/// <summary>
	/// <b>DXGI_MODE_ROTATION Rotation</b>
	/// </summary>
	public readonly ModeRotation Rotation {
		get => _rotation;
		init => _rotation = value;
	}
	readonly ModeRotation _rotation;

	/// <summary>
	/// <b>BOOL DesktopImageInSystemMemory</b>
	/// </summary>
	public readonly bool DesktopImageInSystemMemory {
		get => _desktopImageInSystemMemory != 0;
		init => _desktopImageInSystemMemory = value ? 1U : 0U;
	}
	readonly uint _desktopImageInSystemMemory;

}

/// <summary>
/// STRUCTURE <b>DXGI_OUTDUPL_POINTER_POSITION</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OutduplPointerPosition {

	/// <summary>
	/// <b>POINT Position</b>
	/// </summary>
	public readonly Vector2I Position {
		get => _position;
		init => _position = value;
	}
	readonly Vector2I _position;

	/// <summary>
	/// <b>BOOL Visible</b>
	/// </summary>
	public readonly bool Visible {
		get => _visible != 0;
		init => _visible = value ? 1U : 0U;
	}
	readonly uint _visible;

}

/// <summary>
/// STRUCTURE <b>DXGI_OUTDUPL_POINTER_SHAPE_INFO</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OutduplPointerShapeInfo {

	/// <summary>
	/// <b>UINT Type</b>
	/// </summary>
	public readonly uint Type {
		get => _type;
		init => _type = value;
	}
	readonly uint _type;

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
	/// <b>UINT Pitch</b>
	/// </summary>
	public readonly uint Pitch {
		get => _pitch;
		init => _pitch = value;
	}
	readonly uint _pitch;

	/// <summary>
	/// <b>POINT HotSpot</b>
	/// </summary>
	public readonly Vector2I HotSpot {
		get => _hotSpot;
		init => _hotSpot = value;
	}
	readonly Vector2I _hotSpot;

}

/// <summary>
/// STRUCTURE <b>DXGI_OUTDUPL_FRAME_INFO</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OutduplFrameInfo {

	/// <summary>
	/// <b>LARGE_INTEGER LastPresentTime</b>
	/// </summary>
	public readonly long LastPresentTime {
		get => _lastPresentTime;
		init => _lastPresentTime = value;
	}
	readonly long _lastPresentTime;

	/// <summary>
	/// <b>LARGE_INTEGER LastMouseUpdateTime</b>
	/// </summary>
	public readonly long LastMouseUpdateTime {
		get => _lastMouseUpdateTime;
		init => _lastMouseUpdateTime = value;
	}
	readonly long _lastMouseUpdateTime;

	/// <summary>
	/// <b>UINT AccumulatedFrames</b>
	/// </summary>
	public readonly uint AccumulatedFrames {
		get => _accumulatedFrames;
		init => _accumulatedFrames = value;
	}
	readonly uint _accumulatedFrames;

	/// <summary>
	/// <b>BOOL RectsCoalesced</b>
	/// </summary>
	public readonly bool RectsCoalesced {
		get => _rectsCoalesced != 0;
		init => _rectsCoalesced = value ? 1U : 0U;
	}
	readonly uint _rectsCoalesced;

	/// <summary>
	/// <b>BOOL ProtectedContentMaskedOut</b>
	/// </summary>
	public readonly bool ProtectedContentMaskedOut {
		get => _protectedContentMaskedOut != 0;
		init => _protectedContentMaskedOut = value ? 1U : 0U;
	}
	readonly uint _protectedContentMaskedOut;

	/// <summary>
	/// <b>DXGI_OUTDUPL_POINTER_POSITION PointerPosition</b>
	/// </summary>
	public readonly OutduplPointerPosition PointerPosition {
		get => _pointerPosition;
		init => _pointerPosition = value;
	}
	readonly OutduplPointerPosition _pointerPosition;

	/// <summary>
	/// <b>UINT TotalMetadataBufferSize</b>
	/// </summary>
	public readonly uint TotalMetadataBufferSize {
		get => _totalMetadataBufferSize;
		init => _totalMetadataBufferSize = value;
	}
	readonly uint _totalMetadataBufferSize;

	/// <summary>
	/// <b>UINT PointerShapeBufferSize</b>
	/// </summary>
	public readonly uint PointerShapeBufferSize {
		get => _pointerShapeBufferSize;
		init => _pointerShapeBufferSize = value;
	}
	readonly uint _pointerShapeBufferSize;

}

/// <summary>
/// STRUCTURE <b>DXGI_MODE_DESC1</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ModeDesc1 {

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
	/// <b>DXGI_RATIONAL RefreshRate</b>
	/// </summary>
	public readonly Rational RefreshRate {
		get => _refreshRate;
		init => _refreshRate = value;
	}
	readonly Rational _refreshRate;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly Format Format {
		get => _format;
		init => _format = value;
	}
	readonly Format _format;

	/// <summary>
	/// <b>DXGI_MODE_SCANLINE_ORDER ScanlineOrdering</b>
	/// </summary>
	public readonly ModeScanlineOrder ScanlineOrdering {
		get => _scanlineOrdering;
		init => _scanlineOrdering = value;
	}
	readonly ModeScanlineOrder _scanlineOrdering;

	/// <summary>
	/// <b>DXGI_MODE_SCALING Scaling</b>
	/// </summary>
	public readonly ModeScaling Scaling {
		get => _scaling;
		init => _scaling = value;
	}
	readonly ModeScaling _scaling;

	/// <summary>
	/// <b>BOOL Stereo</b>
	/// </summary>
	public readonly bool Stereo {
		get => _stereo != 0;
		init => _stereo = value ? 1U : 0U;
	}
	readonly uint _stereo;

}

/// <summary>
/// STRUCTURE <b>DXGI_SWAP_CHAIN_DESC1</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SwapChainDesc1 {

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
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly Format Format {
		get => _format;
		init => _format = value;
	}
	readonly Format _format;

	/// <summary>
	/// <b>BOOL Stereo</b>
	/// </summary>
	public readonly bool Stereo {
		get => _stereo != 0;
		init => _stereo = value ? 1U : 0U;
	}
	readonly uint _stereo;

	/// <summary>
	/// <b>DXGI_SAMPLE_DESC SampleDesc</b>
	/// </summary>
	public readonly SampleDesc SampleDesc {
		get => _sampleDesc;
		init => _sampleDesc = value;
	}
	readonly SampleDesc _sampleDesc;

	/// <summary>
	/// <b>DXGI_USAGE BufferUsage</b>
	/// </summary>
	public readonly Usage BufferUsage {
		get => _bufferUsage;
		init => _bufferUsage = value;
	}
	readonly Usage _bufferUsage;

	/// <summary>
	/// <b>UINT BufferCount</b>
	/// </summary>
	public readonly uint BufferCount {
		get => _bufferCount;
		init => _bufferCount = value;
	}
	readonly uint _bufferCount;

	/// <summary>
	/// <b>DXGI_SCALING Scaling</b>
	/// </summary>
	public readonly Scaling Scaling {
		get => _scaling;
		init => _scaling = value;
	}
	readonly Scaling _scaling;

	/// <summary>
	/// <b>DXGI_SWAP_EFFECT SwapEffect</b>
	/// </summary>
	public readonly SwapEffect SwapEffect {
		get => _swapEffect;
		init => _swapEffect = value;
	}
	readonly SwapEffect _swapEffect;

	/// <summary>
	/// <b>DXGI_ALPHA_MODE AlphaMode</b>
	/// </summary>
	public readonly AlphaMode AlphaMode {
		get => _alphaMode;
		init => _alphaMode = value;
	}
	readonly AlphaMode _alphaMode;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

}

/// <summary>
/// STRUCTURE <b>DXGI_SWAP_CHAIN_FULLSCREEN_DESC</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SwapChainFullscreenDesc {

	/// <summary>
	/// <b>DXGI_RATIONAL RefreshRate</b>
	/// </summary>
	public readonly Rational RefreshRate {
		get => _refreshRate;
		init => _refreshRate = value;
	}
	readonly Rational _refreshRate;

	/// <summary>
	/// <b>DXGI_MODE_SCANLINE_ORDER ScanlineOrdering</b>
	/// </summary>
	public readonly ModeScanlineOrder ScanlineOrdering {
		get => _scanlineOrdering;
		init => _scanlineOrdering = value;
	}
	readonly ModeScanlineOrder _scanlineOrdering;

	/// <summary>
	/// <b>DXGI_MODE_SCALING Scaling</b>
	/// </summary>
	public readonly ModeScaling Scaling {
		get => _scaling;
		init => _scaling = value;
	}
	readonly ModeScaling _scaling;

	/// <summary>
	/// <b>BOOL Windowed</b>
	/// </summary>
	public readonly bool Windowed {
		get => _windowed != 0;
		init => _windowed = value ? 1U : 0U;
	}
	readonly uint _windowed;

}

/// <summary>
/// STRUCTURE <b>DXGI_PRESENT_PARAMETERS</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct PresentParameters {

	/// <summary>
	/// <b>UINT DirtyRectsCount</b>
	/// </summary>
	public readonly uint DirtyRectsCount {
		get => _dirtyRectsCount;
		init => _dirtyRectsCount = value;
	}
	readonly uint _dirtyRectsCount;

	/// <summary>
	/// <b>RECT* pDirtyRects</b>
	/// </summary>
	public readonly Vector4I* PDirtyRects {
		get => _pDirtyRects;
		init => _pDirtyRects = value;
	}
	readonly Vector4I* _pDirtyRects;

	/// <summary>
	/// <b>RECT* pScrollRect</b>
	/// </summary>
	public readonly Vector4I* PScrollRect {
		get => _pScrollRect;
		init => _pScrollRect = value;
	}
	readonly Vector4I* _pScrollRect;

	/// <summary>
	/// <b>POINT* pScrollOffset</b>
	/// </summary>
	public readonly Vector2I* PScrollOffset {
		get => _pScrollOffset;
		init => _pScrollOffset = value;
	}
	readonly Vector2I* _pScrollOffset;

}

/// <summary>
/// STRUCTURE <b>DXGI_ADAPTER_DESC2</b><br/>
/// DXGI1_2.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AdapterDesc2 {

	/// <summary>
	/// <b>WCHAR Description [128]</b>
	/// </summary>
	public readonly Span<char> Description {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _description)), 128);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_158 {
		public fixed char _ASP_AUTO_GENERATED_FIELD_0 [128];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_158 _description;

	/// <summary>
	/// <b>UINT VendorId</b>
	/// </summary>
	public readonly uint VendorId {
		get => _vendorId;
		init => _vendorId = value;
	}
	readonly uint _vendorId;

	/// <summary>
	/// <b>UINT DeviceId</b>
	/// </summary>
	public readonly uint DeviceId {
		get => _deviceId;
		init => _deviceId = value;
	}
	readonly uint _deviceId;

	/// <summary>
	/// <b>UINT SubSysId</b>
	/// </summary>
	public readonly uint SubSysId {
		get => _subSysId;
		init => _subSysId = value;
	}
	readonly uint _subSysId;

	/// <summary>
	/// <b>UINT Revision</b>
	/// </summary>
	public readonly uint Revision {
		get => _revision;
		init => _revision = value;
	}
	readonly uint _revision;

	/// <summary>
	/// <b>SIZE_T DedicatedVideoMemory</b>
	/// </summary>
	public readonly nuint DedicatedVideoMemory {
		get => _dedicatedVideoMemory;
		init => _dedicatedVideoMemory = value;
	}
	readonly nuint _dedicatedVideoMemory;

	/// <summary>
	/// <b>SIZE_T DedicatedSystemMemory</b>
	/// </summary>
	public readonly nuint DedicatedSystemMemory {
		get => _dedicatedSystemMemory;
		init => _dedicatedSystemMemory = value;
	}
	readonly nuint _dedicatedSystemMemory;

	/// <summary>
	/// <b>SIZE_T SharedSystemMemory</b>
	/// </summary>
	public readonly nuint SharedSystemMemory {
		get => _sharedSystemMemory;
		init => _sharedSystemMemory = value;
	}
	readonly nuint _sharedSystemMemory;

	/// <summary>
	/// <b>LUID AdapterLuid</b>
	/// </summary>
	public readonly LUID AdapterLuid {
		get => _adapterLuid;
		init => _adapterLuid = value;
	}
	readonly LUID _adapterLuid;

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

	/// <summary>
	/// <b>DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity</b>
	/// </summary>
	public readonly GraphicsPreemptionGranularity GraphicsPreemptionGranularity {
		get => _graphicsPreemptionGranularity;
		init => _graphicsPreemptionGranularity = value;
	}
	readonly GraphicsPreemptionGranularity _graphicsPreemptionGranularity;

	/// <summary>
	/// <b>DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity</b>
	/// </summary>
	public readonly ComputePreemptionGranularity ComputePreemptionGranularity {
		get => _computePreemptionGranularity;
		init => _computePreemptionGranularity = value;
	}
	readonly ComputePreemptionGranularity _computePreemptionGranularity;

}

/// <summary>
/// STRUCTURE <b>DXGI_DECODE_SWAP_CHAIN_DESC</b><br/>
/// DXGI1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct DecodeSwapChainDesc {

	/// <summary>
	/// <b>UINT Flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

}

/// <summary>
/// STRUCTURE <b>DXGI_FRAME_STATISTICS_MEDIA</b><br/>
/// DXGI1_3.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FrameStatisticsMedia {

	/// <summary>
	/// <b>UINT PresentCount</b>
	/// </summary>
	public readonly uint PresentCount {
		get => _presentCount;
		init => _presentCount = value;
	}
	readonly uint _presentCount;

	/// <summary>
	/// <b>UINT PresentRefreshCount</b>
	/// </summary>
	public readonly uint PresentRefreshCount {
		get => _presentRefreshCount;
		init => _presentRefreshCount = value;
	}
	readonly uint _presentRefreshCount;

	/// <summary>
	/// <b>UINT SyncRefreshCount</b>
	/// </summary>
	public readonly uint SyncRefreshCount {
		get => _syncRefreshCount;
		init => _syncRefreshCount = value;
	}
	readonly uint _syncRefreshCount;

	/// <summary>
	/// <b>LARGE_INTEGER SyncQPCTime</b>
	/// </summary>
	public readonly long SyncQPCTime {
		get => _syncQPCTime;
		init => _syncQPCTime = value;
	}
	readonly long _syncQPCTime;

	/// <summary>
	/// <b>LARGE_INTEGER SyncGPUTime</b>
	/// </summary>
	public readonly long SyncGPUTime {
		get => _syncGPUTime;
		init => _syncGPUTime = value;
	}
	readonly long _syncGPUTime;

	/// <summary>
	/// <b>DXGI_FRAME_PRESENTATION_MODE CompositionMode</b>
	/// </summary>
	public readonly FramePresentationMode CompositionMode {
		get => _compositionMode;
		init => _compositionMode = value;
	}
	readonly FramePresentationMode _compositionMode;

	/// <summary>
	/// <b>UINT ApprovedPresentDuration</b>
	/// </summary>
	public readonly uint ApprovedPresentDuration {
		get => _approvedPresentDuration;
		init => _approvedPresentDuration = value;
	}
	readonly uint _approvedPresentDuration;

}

/// <summary>
/// STRUCTURE <b>DXGI_QUERY_VIDEO_MEMORY_INFO</b><br/>
/// DXGI1_4.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct QueryVideoMemoryInfo {

	/// <summary>
	/// <b>UINT64 Budget</b>
	/// </summary>
	public readonly ulong Budget {
		get => _budget;
		init => _budget = value;
	}
	readonly ulong _budget;

	/// <summary>
	/// <b>UINT64 CurrentUsage</b>
	/// </summary>
	public readonly ulong CurrentUsage {
		get => _currentUsage;
		init => _currentUsage = value;
	}
	readonly ulong _currentUsage;

	/// <summary>
	/// <b>UINT64 AvailableForReservation</b>
	/// </summary>
	public readonly ulong AvailableForReservation {
		get => _availableForReservation;
		init => _availableForReservation = value;
	}
	readonly ulong _availableForReservation;

	/// <summary>
	/// <b>UINT64 CurrentReservation</b>
	/// </summary>
	public readonly ulong CurrentReservation {
		get => _currentReservation;
		init => _currentReservation = value;
	}
	readonly ulong _currentReservation;

}

/// <summary>
/// STRUCTURE <b>DXGI_HDR_METADATA_HDR10</b><br/>
/// DXGI1_5.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct HdrMetadataHdr10 {

	/// <summary>
	/// <b>UINT16 RedPrimary [2]</b>
	/// </summary>
	public readonly Span<ushort> RedPrimary {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _redPrimary)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_159 {
		public fixed ushort _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_159 _redPrimary;

	/// <summary>
	/// <b>UINT16 GreenPrimary [2]</b>
	/// </summary>
	public readonly Span<ushort> GreenPrimary {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _greenPrimary)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_160 {
		public fixed ushort _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_160 _greenPrimary;

	/// <summary>
	/// <b>UINT16 BluePrimary [2]</b>
	/// </summary>
	public readonly Span<ushort> BluePrimary {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _bluePrimary)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_161 {
		public fixed ushort _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_161 _bluePrimary;

	/// <summary>
	/// <b>UINT16 WhitePoint [2]</b>
	/// </summary>
	public readonly Span<ushort> WhitePoint {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _whitePoint)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_162 {
		public fixed ushort _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_162 _whitePoint;

	/// <summary>
	/// <b>UINT MaxMasteringLuminance</b>
	/// </summary>
	public readonly uint MaxMasteringLuminance {
		get => _maxMasteringLuminance;
		init => _maxMasteringLuminance = value;
	}
	readonly uint _maxMasteringLuminance;

	/// <summary>
	/// <b>UINT MinMasteringLuminance</b>
	/// </summary>
	public readonly uint MinMasteringLuminance {
		get => _minMasteringLuminance;
		init => _minMasteringLuminance = value;
	}
	readonly uint _minMasteringLuminance;

	/// <summary>
	/// <b>UINT16 MaxContentLightLevel</b>
	/// </summary>
	public readonly ushort MaxContentLightLevel {
		get => _maxContentLightLevel;
		init => _maxContentLightLevel = value;
	}
	readonly ushort _maxContentLightLevel;

	/// <summary>
	/// <b>UINT16 MaxFrameAverageLightLevel</b>
	/// </summary>
	public readonly ushort MaxFrameAverageLightLevel {
		get => _maxFrameAverageLightLevel;
		init => _maxFrameAverageLightLevel = value;
	}
	readonly ushort _maxFrameAverageLightLevel;

}

/// <summary>
/// STRUCTURE <b>DXGI_HDR_METADATA_HDR10PLUS</b><br/>
/// DXGI1_5.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct HdrMetadataHdr10plus {

	/// <summary>
	/// <b>BYTE Data [72]</b>
	/// </summary>
	public readonly Span<byte> Data {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _data)), 72);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_163 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [72];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_163 _data;

}

/// <summary>
/// STRUCTURE <b>DXGI_ADAPTER_DESC3</b><br/>
/// DXGI1_6.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct AdapterDesc3 {

	/// <summary>
	/// <b>WCHAR Description [128]</b>
	/// </summary>
	public readonly Span<char> Description {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _description)), 128);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_164 {
		public fixed char _ASP_AUTO_GENERATED_FIELD_0 [128];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_164 _description;

	/// <summary>
	/// <b>UINT VendorId</b>
	/// </summary>
	public readonly uint VendorId {
		get => _vendorId;
		init => _vendorId = value;
	}
	readonly uint _vendorId;

	/// <summary>
	/// <b>UINT DeviceId</b>
	/// </summary>
	public readonly uint DeviceId {
		get => _deviceId;
		init => _deviceId = value;
	}
	readonly uint _deviceId;

	/// <summary>
	/// <b>UINT SubSysId</b>
	/// </summary>
	public readonly uint SubSysId {
		get => _subSysId;
		init => _subSysId = value;
	}
	readonly uint _subSysId;

	/// <summary>
	/// <b>UINT Revision</b>
	/// </summary>
	public readonly uint Revision {
		get => _revision;
		init => _revision = value;
	}
	readonly uint _revision;

	/// <summary>
	/// <b>SIZE_T DedicatedVideoMemory</b>
	/// </summary>
	public readonly nuint DedicatedVideoMemory {
		get => _dedicatedVideoMemory;
		init => _dedicatedVideoMemory = value;
	}
	readonly nuint _dedicatedVideoMemory;

	/// <summary>
	/// <b>SIZE_T DedicatedSystemMemory</b>
	/// </summary>
	public readonly nuint DedicatedSystemMemory {
		get => _dedicatedSystemMemory;
		init => _dedicatedSystemMemory = value;
	}
	readonly nuint _dedicatedSystemMemory;

	/// <summary>
	/// <b>SIZE_T SharedSystemMemory</b>
	/// </summary>
	public readonly nuint SharedSystemMemory {
		get => _sharedSystemMemory;
		init => _sharedSystemMemory = value;
	}
	readonly nuint _sharedSystemMemory;

	/// <summary>
	/// <b>LUID AdapterLuid</b>
	/// </summary>
	public readonly LUID AdapterLuid {
		get => _adapterLuid;
		init => _adapterLuid = value;
	}
	readonly LUID _adapterLuid;

	/// <summary>
	/// <b>DXGI_ADAPTER_FLAG3 Flags</b>
	/// </summary>
	public readonly AdapterFlag3 Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly AdapterFlag3 _flags;

	/// <summary>
	/// <b>DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity</b>
	/// </summary>
	public readonly GraphicsPreemptionGranularity GraphicsPreemptionGranularity {
		get => _graphicsPreemptionGranularity;
		init => _graphicsPreemptionGranularity = value;
	}
	readonly GraphicsPreemptionGranularity _graphicsPreemptionGranularity;

	/// <summary>
	/// <b>DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity</b>
	/// </summary>
	public readonly ComputePreemptionGranularity ComputePreemptionGranularity {
		get => _computePreemptionGranularity;
		init => _computePreemptionGranularity = value;
	}
	readonly ComputePreemptionGranularity _computePreemptionGranularity;

}

/// <summary>
/// STRUCTURE <b>DXGI_OUTPUT_DESC1</b><br/>
/// DXGI1_6.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct OutputDesc1 {

	/// <summary>
	/// <b>WCHAR DeviceName [32]</b>
	/// </summary>
	public readonly Span<char> DeviceName {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _deviceName)), 32);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_165 {
		public fixed char _ASP_AUTO_GENERATED_FIELD_0 [32];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_165 _deviceName;

	/// <summary>
	/// <b>RECT DesktopCoordinates</b>
	/// </summary>
	public readonly Vector4I DesktopCoordinates {
		get => _desktopCoordinates;
		init => _desktopCoordinates = value;
	}
	readonly Vector4I _desktopCoordinates;

	/// <summary>
	/// <b>BOOL AttachedToDesktop</b>
	/// </summary>
	public readonly bool AttachedToDesktop {
		get => _attachedToDesktop != 0;
		init => _attachedToDesktop = value ? 1U : 0U;
	}
	readonly uint _attachedToDesktop;

	/// <summary>
	/// <b>DXGI_MODE_ROTATION Rotation</b>
	/// </summary>
	public readonly ModeRotation Rotation {
		get => _rotation;
		init => _rotation = value;
	}
	readonly ModeRotation _rotation;

	/// <summary>
	/// <b>HMONITOR Monitor</b>
	/// </summary>
	public readonly IntPtr Monitor {
		get => _monitor;
		init => _monitor = value;
	}
	readonly IntPtr _monitor;

	/// <summary>
	/// <b>UINT BitsPerColor</b>
	/// </summary>
	public readonly uint BitsPerColor {
		get => _bitsPerColor;
		init => _bitsPerColor = value;
	}
	readonly uint _bitsPerColor;

	/// <summary>
	/// <b>DXGI_COLOR_SPACE_TYPE ColorSpace</b>
	/// </summary>
	public readonly ColorSpaceType ColorSpace {
		get => _colorSpace;
		init => _colorSpace = value;
	}
	readonly ColorSpaceType _colorSpace;

	/// <summary>
	/// <b>FLOAT RedPrimary [2]</b>
	/// </summary>
	public readonly Span<float> RedPrimary {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _redPrimary)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_166 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_166 _redPrimary;

	/// <summary>
	/// <b>FLOAT GreenPrimary [2]</b>
	/// </summary>
	public readonly Span<float> GreenPrimary {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _greenPrimary)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_167 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_167 _greenPrimary;

	/// <summary>
	/// <b>FLOAT BluePrimary [2]</b>
	/// </summary>
	public readonly Span<float> BluePrimary {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _bluePrimary)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_168 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_168 _bluePrimary;

	/// <summary>
	/// <b>FLOAT WhitePoint [2]</b>
	/// </summary>
	public readonly Span<float> WhitePoint {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _whitePoint)), 2);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_169 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [2];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_169 _whitePoint;

	/// <summary>
	/// <b>FLOAT MinLuminance</b>
	/// </summary>
	public readonly float MinLuminance {
		get => _minLuminance;
		init => _minLuminance = value;
	}
	readonly float _minLuminance;

	/// <summary>
	/// <b>FLOAT MaxLuminance</b>
	/// </summary>
	public readonly float MaxLuminance {
		get => _maxLuminance;
		init => _maxLuminance = value;
	}
	readonly float _maxLuminance;

	/// <summary>
	/// <b>FLOAT MaxFullFrameLuminance</b>
	/// </summary>
	public readonly float MaxFullFrameLuminance {
		get => _maxFullFrameLuminance;
		init => _maxFullFrameLuminance = value;
	}
	readonly float _maxFullFrameLuminance;

}

/// <summary>
/// STRUCTURE <b>DXGI_RATIONAL</b><br/>
/// DXGICOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Rational {

	/// <summary>
	/// <b>UINT Numerator</b>
	/// </summary>
	public readonly uint Numerator {
		get => _numerator;
		init => _numerator = value;
	}
	readonly uint _numerator;

	/// <summary>
	/// <b>UINT Denominator</b>
	/// </summary>
	public readonly uint Denominator {
		get => _denominator;
		init => _denominator = value;
	}
	readonly uint _denominator;

}

/// <summary>
/// STRUCTURE <b>DXGI_SAMPLE_DESC</b><br/>
/// DXGICOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SampleDesc {

	/// <summary>
	/// <b>UINT Count</b>
	/// </summary>
	public readonly uint Count {
		get => _count;
		init => _count = value;
	}
	readonly uint _count;

	/// <summary>
	/// <b>UINT Quality</b>
	/// </summary>
	public readonly uint Quality {
		get => _quality;
		init => _quality = value;
	}
	readonly uint _quality;

}

/// <summary>
/// STRUCTURE <b>DXGI_INFO_QUEUE_MESSAGE</b><br/>
/// DXGIDEBUG.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InfoQueueMessage {

	/// <summary>
	/// <b>DXGI_DEBUG_ID Producer</b>
	/// </summary>
	public readonly Guid Producer {
		get => _producer;
		init => _producer = value;
	}
	readonly Guid _producer;

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category</b>
	/// </summary>
	public readonly InfoQueueMessageCategory Category {
		get => _category;
		init => _category = value;
	}
	readonly InfoQueueMessageCategory _category;

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity</b>
	/// </summary>
	public readonly InfoQueueMessageSeverity Severity {
		get => _severity;
		init => _severity = value;
	}
	readonly InfoQueueMessageSeverity _severity;

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_ID ID</b>
	/// </summary>
	public readonly int Id {
		get => _iD;
		init => _iD = value;
	}
	readonly int _iD;

	/// <summary>
	/// <b>char* pDescription</b>
	/// </summary>
	public readonly char* PDescription {
		get => _pDescription;
		init => _pDescription = value;
	}
	readonly char* _pDescription;

	/// <summary>
	/// <b>SIZE_T DescriptionByteLength</b>
	/// </summary>
	public readonly nuint DescriptionByteLength {
		get => _descriptionByteLength;
		init => _descriptionByteLength = value;
	}
	readonly nuint _descriptionByteLength;

}

/// <summary>
/// STRUCTURE <b>DXGI_INFO_QUEUE_FILTER_DESC</b><br/>
/// DXGIDEBUG.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InfoQueueFilterDesc {

	/// <summary>
	/// <b>UINT NumCategories</b>
	/// </summary>
	public readonly uint NumCategories {
		get => _numCategories;
		init => _numCategories = value;
	}
	readonly uint _numCategories;

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY* pCategoryList</b>
	/// </summary>
	public readonly InfoQueueMessageCategory* PCategoryList {
		get => _pCategoryList;
		init => _pCategoryList = value;
	}
	readonly InfoQueueMessageCategory* _pCategoryList;

	/// <summary>
	/// <b>UINT NumSeverities</b>
	/// </summary>
	public readonly uint NumSeverities {
		get => _numSeverities;
		init => _numSeverities = value;
	}
	readonly uint _numSeverities;

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY* pSeverityList</b>
	/// </summary>
	public readonly InfoQueueMessageSeverity* PSeverityList {
		get => _pSeverityList;
		init => _pSeverityList = value;
	}
	readonly InfoQueueMessageSeverity* _pSeverityList;

	/// <summary>
	/// <b>UINT NumIDs</b>
	/// </summary>
	public readonly uint NumIDs {
		get => _numIDs;
		init => _numIDs = value;
	}
	readonly uint _numIDs;

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_MESSAGE_ID* pIDList</b>
	/// </summary>
	public readonly int* PIDList {
		get => _pIDList;
		init => _pIDList = value;
	}
	readonly int* _pIDList;

}

/// <summary>
/// STRUCTURE <b>DXGI_INFO_QUEUE_FILTER</b><br/>
/// DXGIDEBUG.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct InfoQueueFilter {

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_FILTER_DESC AllowList</b>
	/// </summary>
	public readonly InfoQueueFilterDesc AllowList {
		get => _allowList;
		init => _allowList = value;
	}
	readonly InfoQueueFilterDesc _allowList;

	/// <summary>
	/// <b>DXGI_INFO_QUEUE_FILTER_DESC DenyList</b>
	/// </summary>
	public readonly InfoQueueFilterDesc DenyList {
		get => _denyList;
		init => _denyList = value;
	}
	readonly InfoQueueFilterDesc _denyList;

}

/// <summary>
/// STRUCTURE <b>DXGI_GAMMA_CONTROL</b><br/>
/// DXGITYPE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GammaControl {

	/// <summary>
	/// <b>DXGI_RGB Scale</b>
	/// </summary>
	public readonly Vector3F Scale {
		get => _scale;
		init => _scale = value;
	}
	readonly Vector3F _scale;

	/// <summary>
	/// <b>DXGI_RGB Offset</b>
	/// </summary>
	public readonly Vector3F Offset {
		get => _offset;
		init => _offset = value;
	}
	readonly Vector3F _offset;

	/// <summary>
	/// <b>DXGI_RGB GammaCurve [1025]</b>
	/// </summary>
	public readonly Span<Vector3F> GammaCurve {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _gammaCurve)), 1025);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_170 {
		public Vector3F _ASP_AUTO_GENERATED_FIELD_0;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_2;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_3;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_4;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_5;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_6;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_7;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_8;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_9;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_10;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_11;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_12;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_13;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_14;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_15;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_16;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_17;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_18;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_19;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_20;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_21;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_22;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_23;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_24;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_25;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_26;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_27;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_28;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_29;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_30;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_31;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_32;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_33;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_34;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_35;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_36;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_37;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_38;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_39;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_40;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_41;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_42;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_43;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_44;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_45;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_46;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_47;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_48;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_49;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_50;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_51;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_52;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_53;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_54;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_55;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_56;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_57;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_58;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_59;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_60;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_61;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_62;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_63;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_64;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_65;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_66;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_67;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_68;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_69;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_70;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_71;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_72;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_73;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_74;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_75;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_76;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_77;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_78;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_79;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_80;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_81;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_82;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_83;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_84;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_85;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_86;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_87;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_88;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_89;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_90;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_91;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_92;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_93;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_94;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_95;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_96;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_97;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_98;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_99;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_100;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_101;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_102;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_103;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_104;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_105;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_106;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_107;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_108;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_109;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_110;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_111;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_112;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_113;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_114;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_115;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_116;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_117;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_118;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_119;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_120;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_121;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_122;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_123;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_124;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_125;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_126;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_127;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_128;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_129;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_130;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_131;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_132;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_133;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_134;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_135;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_136;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_137;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_138;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_139;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_140;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_141;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_142;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_143;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_144;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_145;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_146;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_147;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_148;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_149;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_150;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_151;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_152;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_153;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_154;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_155;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_156;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_157;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_158;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_159;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_160;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_161;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_162;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_163;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_164;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_165;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_166;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_167;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_168;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_169;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_170;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_171;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_172;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_173;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_174;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_175;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_176;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_177;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_178;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_179;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_180;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_181;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_182;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_183;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_184;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_185;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_186;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_187;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_188;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_189;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_190;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_191;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_192;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_193;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_194;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_195;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_196;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_197;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_198;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_199;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_200;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_201;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_202;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_203;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_204;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_205;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_206;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_207;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_208;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_209;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_210;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_211;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_212;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_213;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_214;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_215;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_216;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_217;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_218;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_219;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_220;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_221;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_222;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_223;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_224;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_225;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_226;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_227;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_228;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_229;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_230;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_231;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_232;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_233;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_234;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_235;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_236;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_237;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_238;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_239;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_240;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_241;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_242;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_243;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_244;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_245;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_246;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_247;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_248;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_249;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_250;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_251;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_252;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_253;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_254;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_255;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_256;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_257;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_258;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_259;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_260;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_261;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_262;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_263;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_264;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_265;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_266;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_267;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_268;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_269;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_270;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_271;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_272;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_273;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_274;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_275;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_276;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_277;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_278;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_279;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_280;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_281;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_282;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_283;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_284;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_285;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_286;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_287;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_288;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_289;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_290;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_291;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_292;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_293;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_294;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_295;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_296;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_297;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_298;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_299;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_300;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_301;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_302;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_303;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_304;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_305;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_306;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_307;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_308;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_309;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_310;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_311;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_312;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_313;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_314;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_315;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_316;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_317;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_318;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_319;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_320;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_321;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_322;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_323;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_324;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_325;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_326;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_327;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_328;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_329;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_330;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_331;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_332;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_333;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_334;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_335;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_336;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_337;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_338;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_339;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_340;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_341;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_342;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_343;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_344;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_345;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_346;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_347;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_348;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_349;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_350;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_351;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_352;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_353;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_354;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_355;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_356;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_357;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_358;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_359;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_360;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_361;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_362;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_363;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_364;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_365;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_366;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_367;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_368;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_369;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_370;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_371;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_372;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_373;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_374;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_375;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_376;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_377;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_378;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_379;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_380;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_381;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_382;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_383;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_384;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_385;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_386;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_387;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_388;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_389;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_390;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_391;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_392;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_393;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_394;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_395;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_396;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_397;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_398;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_399;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_400;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_401;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_402;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_403;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_404;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_405;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_406;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_407;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_408;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_409;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_410;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_411;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_412;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_413;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_414;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_415;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_416;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_417;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_418;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_419;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_420;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_421;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_422;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_423;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_424;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_425;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_426;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_427;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_428;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_429;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_430;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_431;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_432;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_433;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_434;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_435;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_436;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_437;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_438;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_439;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_440;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_441;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_442;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_443;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_444;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_445;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_446;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_447;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_448;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_449;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_450;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_451;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_452;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_453;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_454;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_455;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_456;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_457;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_458;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_459;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_460;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_461;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_462;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_463;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_464;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_465;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_466;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_467;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_468;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_469;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_470;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_471;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_472;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_473;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_474;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_475;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_476;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_477;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_478;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_479;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_480;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_481;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_482;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_483;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_484;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_485;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_486;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_487;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_488;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_489;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_490;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_491;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_492;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_493;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_494;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_495;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_496;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_497;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_498;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_499;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_500;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_501;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_502;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_503;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_504;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_505;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_506;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_507;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_508;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_509;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_510;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_511;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_512;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_513;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_514;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_515;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_516;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_517;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_518;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_519;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_520;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_521;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_522;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_523;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_524;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_525;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_526;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_527;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_528;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_529;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_530;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_531;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_532;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_533;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_534;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_535;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_536;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_537;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_538;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_539;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_540;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_541;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_542;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_543;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_544;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_545;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_546;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_547;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_548;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_549;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_550;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_551;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_552;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_553;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_554;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_555;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_556;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_557;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_558;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_559;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_560;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_561;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_562;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_563;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_564;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_565;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_566;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_567;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_568;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_569;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_570;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_571;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_572;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_573;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_574;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_575;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_576;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_577;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_578;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_579;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_580;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_581;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_582;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_583;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_584;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_585;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_586;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_587;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_588;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_589;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_590;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_591;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_592;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_593;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_594;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_595;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_596;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_597;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_598;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_599;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_600;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_601;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_602;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_603;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_604;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_605;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_606;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_607;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_608;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_609;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_610;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_611;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_612;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_613;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_614;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_615;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_616;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_617;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_618;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_619;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_620;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_621;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_622;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_623;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_624;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_625;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_626;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_627;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_628;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_629;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_630;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_631;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_632;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_633;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_634;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_635;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_636;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_637;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_638;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_639;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_640;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_641;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_642;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_643;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_644;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_645;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_646;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_647;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_648;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_649;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_650;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_651;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_652;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_653;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_654;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_655;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_656;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_657;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_658;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_659;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_660;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_661;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_662;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_663;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_664;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_665;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_666;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_667;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_668;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_669;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_670;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_671;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_672;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_673;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_674;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_675;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_676;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_677;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_678;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_679;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_680;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_681;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_682;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_683;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_684;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_685;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_686;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_687;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_688;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_689;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_690;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_691;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_692;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_693;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_694;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_695;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_696;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_697;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_698;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_699;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_700;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_701;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_702;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_703;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_704;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_705;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_706;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_707;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_708;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_709;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_710;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_711;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_712;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_713;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_714;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_715;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_716;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_717;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_718;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_719;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_720;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_721;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_722;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_723;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_724;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_725;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_726;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_727;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_728;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_729;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_730;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_731;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_732;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_733;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_734;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_735;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_736;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_737;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_738;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_739;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_740;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_741;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_742;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_743;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_744;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_745;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_746;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_747;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_748;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_749;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_750;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_751;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_752;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_753;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_754;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_755;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_756;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_757;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_758;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_759;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_760;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_761;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_762;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_763;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_764;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_765;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_766;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_767;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_768;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_769;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_770;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_771;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_772;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_773;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_774;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_775;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_776;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_777;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_778;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_779;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_780;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_781;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_782;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_783;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_784;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_785;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_786;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_787;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_788;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_789;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_790;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_791;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_792;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_793;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_794;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_795;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_796;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_797;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_798;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_799;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_800;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_801;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_802;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_803;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_804;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_805;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_806;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_807;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_808;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_809;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_810;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_811;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_812;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_813;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_814;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_815;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_816;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_817;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_818;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_819;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_820;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_821;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_822;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_823;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_824;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_825;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_826;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_827;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_828;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_829;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_830;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_831;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_832;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_833;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_834;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_835;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_836;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_837;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_838;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_839;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_840;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_841;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_842;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_843;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_844;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_845;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_846;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_847;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_848;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_849;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_850;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_851;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_852;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_853;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_854;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_855;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_856;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_857;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_858;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_859;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_860;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_861;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_862;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_863;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_864;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_865;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_866;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_867;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_868;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_869;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_870;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_871;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_872;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_873;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_874;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_875;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_876;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_877;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_878;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_879;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_880;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_881;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_882;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_883;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_884;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_885;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_886;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_887;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_888;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_889;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_890;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_891;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_892;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_893;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_894;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_895;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_896;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_897;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_898;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_899;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_900;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_901;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_902;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_903;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_904;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_905;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_906;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_907;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_908;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_909;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_910;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_911;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_912;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_913;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_914;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_915;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_916;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_917;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_918;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_919;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_920;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_921;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_922;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_923;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_924;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_925;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_926;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_927;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_928;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_929;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_930;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_931;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_932;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_933;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_934;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_935;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_936;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_937;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_938;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_939;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_940;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_941;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_942;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_943;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_944;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_945;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_946;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_947;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_948;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_949;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_950;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_951;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_952;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_953;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_954;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_955;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_956;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_957;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_958;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_959;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_960;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_961;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_962;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_963;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_964;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_965;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_966;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_967;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_968;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_969;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_970;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_971;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_972;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_973;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_974;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_975;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_976;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_977;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_978;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_979;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_980;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_981;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_982;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_983;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_984;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_985;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_986;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_987;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_988;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_989;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_990;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_991;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_992;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_993;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_994;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_995;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_996;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_997;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_998;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_999;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1000;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1001;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1002;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1003;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1004;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1005;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1006;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1007;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1008;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1009;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1010;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1011;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1012;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1013;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1014;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1015;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1016;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1017;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1018;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1019;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1020;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1021;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1022;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1023;
		public Vector3F _ASP_AUTO_GENERATED_FIELD_1024;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_170 _gammaCurve;

}

/// <summary>
/// STRUCTURE <b>DXGI_GAMMA_CONTROL_CAPABILITIES</b><br/>
/// DXGITYPE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GammaControlCapabilities {

	/// <summary>
	/// <b>BOOL ScaleAndOffsetSupported</b>
	/// </summary>
	public readonly bool ScaleAndOffsetSupported {
		get => _scaleAndOffsetSupported != 0;
		init => _scaleAndOffsetSupported = value ? 1U : 0U;
	}
	readonly uint _scaleAndOffsetSupported;

	/// <summary>
	/// <b>float MaxConvertedValue</b>
	/// </summary>
	public readonly float MaxConvertedValue {
		get => _maxConvertedValue;
		init => _maxConvertedValue = value;
	}
	readonly float _maxConvertedValue;

	/// <summary>
	/// <b>float MinConvertedValue</b>
	/// </summary>
	public readonly float MinConvertedValue {
		get => _minConvertedValue;
		init => _minConvertedValue = value;
	}
	readonly float _minConvertedValue;

	/// <summary>
	/// <b>UINT NumGammaControlPoints</b>
	/// </summary>
	public readonly uint NumGammaControlPoints {
		get => _numGammaControlPoints;
		init => _numGammaControlPoints = value;
	}
	readonly uint _numGammaControlPoints;

	/// <summary>
	/// <b>float ControlPointPositions [1025]</b>
	/// </summary>
	public readonly Span<float> ControlPointPositions {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _controlPointPositions)), 1025);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_171 {
		public fixed float _ASP_AUTO_GENERATED_FIELD_0 [1025];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_171 _controlPointPositions;

}

/// <summary>
/// STRUCTURE <b>DXGI_MODE_DESC</b><br/>
/// DXGITYPE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ModeDesc {

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
	/// <b>DXGI_RATIONAL RefreshRate</b>
	/// </summary>
	public readonly Rational RefreshRate {
		get => _refreshRate;
		init => _refreshRate = value;
	}
	readonly Rational _refreshRate;

	/// <summary>
	/// <b>DXGI_FORMAT Format</b>
	/// </summary>
	public readonly Format Format {
		get => _format;
		init => _format = value;
	}
	readonly Format _format;

	/// <summary>
	/// <b>DXGI_MODE_SCANLINE_ORDER ScanlineOrdering</b>
	/// </summary>
	public readonly ModeScanlineOrder ScanlineOrdering {
		get => _scanlineOrdering;
		init => _scanlineOrdering = value;
	}
	readonly ModeScanlineOrder _scanlineOrdering;

	/// <summary>
	/// <b>DXGI_MODE_SCALING Scaling</b>
	/// </summary>
	public readonly ModeScaling Scaling {
		get => _scaling;
		init => _scaling = value;
	}
	readonly ModeScaling _scaling;

}

/// <summary>
/// STRUCTURE <b>DXGI_JPEG_DC_HUFFMAN_TABLE</b><br/>
/// DXGITYPE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct JpegDcHuffmanTable {

	/// <summary>
	/// <b>BYTE CodeCounts [12]</b>
	/// </summary>
	public readonly Span<byte> CodeCounts {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _codeCounts)), 12);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_172 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [12];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_172 _codeCounts;

	/// <summary>
	/// <b>BYTE CodeValues [12]</b>
	/// </summary>
	public readonly Span<byte> CodeValues {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _codeValues)), 12);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_173 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [12];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_173 _codeValues;

}

/// <summary>
/// STRUCTURE <b>DXGI_JPEG_AC_HUFFMAN_TABLE</b><br/>
/// DXGITYPE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct JpegAcHuffmanTable {

	/// <summary>
	/// <b>BYTE CodeCounts [16]</b>
	/// </summary>
	public readonly Span<byte> CodeCounts {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _codeCounts)), 16);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_174 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [16];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_174 _codeCounts;

	/// <summary>
	/// <b>BYTE CodeValues [162]</b>
	/// </summary>
	public readonly Span<byte> CodeValues {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _codeValues)), 162);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_175 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [162];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_175 _codeValues;

}

/// <summary>
/// STRUCTURE <b>DXGI_JPEG_QUANTIZATION_TABLE</b><br/>
/// DXGITYPE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct JpegQuantizationTable {

	/// <summary>
	/// <b>BYTE Elements [64]</b>
	/// </summary>
	public readonly Span<byte> Elements {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _elements)), 64);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_176 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [64];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_176 _elements;

}
