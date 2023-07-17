using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICPlanarBitmapSourceTransform</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IPlanarBitmapSourceTransform : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarBitmapSourceTransform::DoesSupportTransform (UINT* puiWidth, UINT* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, WICPixelFormatGUID* pguidDstFormats, WICBitmapPlaneDescription* pPlaneDescriptions, UINT cPlanes, BOOL* pfIsSupported)</b><br/>
	/// </summary>
	/// <param name="puiWidth">__RPC__inout <b>UINT* puiWidth</b></param>
	/// <param name="puiHeight">__RPC__inout <b>UINT* puiHeight</b></param>
	/// <param name="dstTransform"><b>WICBitmapTransformOptions dstTransform</b></param>
	/// <param name="dstPlanarOptions"><b>WICPlanarOptions dstPlanarOptions</b></param>
	/// <param name="pguidDstFormats">__RPC__in_ecount_full(cPlanes) <b>WICPixelFormatGUID* pguidDstFormats</b></param>
	/// <param name="pPlaneDescriptions">__RPC__out_ecount_full(cPlanes) <b>WICBitmapPlaneDescription* pPlaneDescriptions</b></param>
	/// <param name="cPlanes"><b>UINT cPlanes</b></param>
	/// <param name="pfIsSupported">__RPC__out <b>BOOL* pfIsSupported</b></param>
	int DoesSupportTransform (uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, uint* pfIsSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarBitmapSourceTransform::DoesSupportTransform (UINT* puiWidth, UINT* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, WICPixelFormatGUID* pguidDstFormats, WICBitmapPlaneDescription* pPlaneDescriptions, UINT cPlanes, BOOL* pfIsSupported)</b><br/>
	/// </summary>
	/// <param name="puiWidth">__RPC__inout <b>UINT* puiWidth</b></param>
	/// <param name="puiHeight">__RPC__inout <b>UINT* puiHeight</b></param>
	/// <param name="dstTransform"><b>WICBitmapTransformOptions dstTransform</b></param>
	/// <param name="dstPlanarOptions"><b>WICPlanarOptions dstPlanarOptions</b></param>
	/// <param name="pguidDstFormats">__RPC__in_ecount_full(cPlanes) <b>WICPixelFormatGUID* pguidDstFormats</b></param>
	/// <param name="pPlaneDescriptions">__RPC__out_ecount_full(cPlanes) <b>WICBitmapPlaneDescription* pPlaneDescriptions</b></param>
	/// <param name="cPlanes"><b>UINT cPlanes</b></param>
	/// <param name="pfIsSupported">__RPC__out <b>BOOL* pfIsSupported</b></param>
	int DoesSupportTransform (uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, Guid* pguidDstFormats, out BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, out bool pfIsSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarBitmapSourceTransform::CopyPixels (WICRect* prcSource, UINT uiWidth, UINT uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, WICBitmapPlane* pDstPlanes, UINT cPlanes)</b><br/>
	/// </summary>
	/// <param name="prcSource">__RPC__in_opt <b>WICRect* prcSource</b></param>
	/// <param name="uiWidth"><b>UINT uiWidth</b></param>
	/// <param name="uiHeight"><b>UINT uiHeight</b></param>
	/// <param name="dstTransform"><b>WICBitmapTransformOptions dstTransform</b></param>
	/// <param name="dstPlanarOptions"><b>WICPlanarOptions dstPlanarOptions</b></param>
	/// <param name="pDstPlanes">__RPC__in_ecount_full(cPlanes) <b>WICBitmapPlane* pDstPlanes</b></param>
	/// <param name="cPlanes"><b>UINT cPlanes</b></param>
	int CopyPixels (Vector4I* prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, BitmapPlane* pDstPlanes, uint cPlanes);
}

/// <summary>
/// Instance of <b>IWICPlanarBitmapSourceTransform</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct PlanarBitmapSourceTransform : IPlanarBitmapSourceTransform {
//unsafe public readonly struct IPlanarBitmapSourceTransformObj : IPlanarBitmapSourceTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PlanarBitmapSourceTransform* GetCurrentPointer () => (PlanarBitmapSourceTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPlanarBitmapSourceTransformObj* GetCurrentPointer () => (IPlanarBitmapSourceTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3aff9cce, 0xbe95, 0x4303, 0xb9, 0x27, 0xe7, 0xd1, 0x6f, 0xf4, 0xa6, 0x13);

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
	public readonly int DoesSupportTransform (uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, uint* pfIsSupported) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportTransform (ptr, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportTransform (uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, Guid* pguidDstFormats, out BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, out bool pfIsSupported) {
		fixed (BitmapPlaneDescription* _pPlaneDescriptions = &pPlaneDescriptions) {
			uint _pfIsSupported;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportTransform (ptr, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, _pPlaneDescriptions, cPlanes, &_pfIsSupported);
			pfIsSupported = _pfIsSupported != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, BitmapPlane* pDstPlanes, uint cPlanes) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, uint*, int> DoesSupportTransform;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int> CopyPixels;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
