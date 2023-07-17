using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapSourceTransform</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapSourceTransform : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSourceTransform::CopyPixels (WICRect* prc, UINT uiWidth, UINT uiHeight, WICPixelFormatGUID* pguidDstFormat, WICBitmapTransformOptions dstTransform, UINT nStride, UINT cbBufferSize, BYTE* pbBuffer)</b><br/>
	/// </summary>
	/// <param name="prc">__RPC__in_opt <b>WICRect* prc</b></param>
	/// <param name="uiWidth"><b>UINT uiWidth</b></param>
	/// <param name="uiHeight"><b>UINT uiHeight</b></param>
	/// <param name="pguidDstFormat">__RPC__in_opt <b>WICPixelFormatGUID* pguidDstFormat</b></param>
	/// <param name="dstTransform"><b>WICBitmapTransformOptions dstTransform</b></param>
	/// <param name="nStride"><b>UINT nStride</b></param>
	/// <param name="cbBufferSize"><b>UINT cbBufferSize</b></param>
	/// <param name="pbBuffer">__RPC__out_ecount_full(cbBufferSize) <b>BYTE* pbBuffer</b></param>
	int CopyPixels (Vector4I* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSourceTransform::CopyPixels (WICRect* prc, UINT uiWidth, UINT uiHeight, WICPixelFormatGUID* pguidDstFormat, WICBitmapTransformOptions dstTransform, UINT nStride, UINT cbBufferSize, BYTE* pbBuffer)</b><br/>
	/// </summary>
	/// <param name="prc">__RPC__in_opt <b>WICRect* prc</b></param>
	/// <param name="uiWidth"><b>UINT uiWidth</b></param>
	/// <param name="uiHeight"><b>UINT uiHeight</b></param>
	/// <param name="pguidDstFormat">__RPC__in_opt <b>WICPixelFormatGUID* pguidDstFormat</b></param>
	/// <param name="dstTransform"><b>WICBitmapTransformOptions dstTransform</b></param>
	/// <param name="nStride"><b>UINT nStride</b></param>
	/// <param name="cbBufferSize"><b>UINT cbBufferSize</b></param>
	/// <param name="pbBuffer">__RPC__out_ecount_full(cbBufferSize) <b>BYTE* pbBuffer</b></param>
	int CopyPixels (Vector4I* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, out byte pbBuffer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSourceTransform::GetClosestSize (UINT* puiWidth, UINT* puiHeight)</b><br/>
	/// </summary>
	/// <param name="puiWidth">__RPC__inout <b>UINT* puiWidth</b></param>
	/// <param name="puiHeight">__RPC__inout <b>UINT* puiHeight</b></param>
	int GetClosestSize (uint* puiWidth, uint* puiHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSourceTransform::GetClosestPixelFormat (WICPixelFormatGUID* pguidDstFormat)</b><br/>
	/// </summary>
	/// <param name="pguidDstFormat">__RPC__inout <b>WICPixelFormatGUID* pguidDstFormat</b></param>
	int GetClosestPixelFormat (Guid* pguidDstFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSourceTransform::DoesSupportTransform (WICBitmapTransformOptions dstTransform, BOOL* pfIsSupported)</b><br/>
	/// </summary>
	/// <param name="dstTransform"><b>WICBitmapTransformOptions dstTransform</b></param>
	/// <param name="pfIsSupported">__RPC__out <b>BOOL* pfIsSupported</b></param>
	int DoesSupportTransform (BitmapTransformOptions dstTransform, uint* pfIsSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapSourceTransform::DoesSupportTransform (WICBitmapTransformOptions dstTransform, BOOL* pfIsSupported)</b><br/>
	/// </summary>
	/// <param name="dstTransform"><b>WICBitmapTransformOptions dstTransform</b></param>
	/// <param name="pfIsSupported">__RPC__out <b>BOOL* pfIsSupported</b></param>
	int DoesSupportTransform (BitmapTransformOptions dstTransform, out bool pfIsSupported);
}

/// <summary>
/// Instance of <b>IWICBitmapSourceTransform</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapSourceTransform : IBitmapSourceTransform {
//unsafe public readonly struct IBitmapSourceTransformObj : IBitmapSourceTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapSourceTransform* GetCurrentPointer () => (BitmapSourceTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapSourceTransformObj* GetCurrentPointer () => (IBitmapSourceTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3b16811b, 0x6a43, 0x4ec9, 0xb7, 0x13, 0x3d, 0x5a, 0x0c, 0x13, 0xb9, 0x40);

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
	public readonly int CopyPixels (Vector4I* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, out byte pbBuffer) {
		fixed (byte* _pbBuffer = &pbBuffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, _pbBuffer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClosestSize (uint* puiWidth, uint* puiHeight) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetClosestSize (ptr, puiWidth, puiHeight);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClosestPixelFormat (Guid* pguidDstFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetClosestPixelFormat (ptr, pguidDstFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportTransform (BitmapTransformOptions dstTransform, uint* pfIsSupported) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportTransform (ptr, dstTransform, pfIsSupported);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportTransform (BitmapTransformOptions dstTransform, out bool pfIsSupported) {
		uint _pfIsSupported;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportTransform (ptr, dstTransform, &_pfIsSupported);
		pfIsSupported = _pfIsSupported != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int> CopyPixels;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, int> GetClosestSize;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetClosestPixelFormat;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BitmapTransformOptions, uint*, int> DoesSupportTransform;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
