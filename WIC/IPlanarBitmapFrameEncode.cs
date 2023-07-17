using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;
/// <summary>
/// INTERFACE <b>IWICPlanarBitmapFrameEncode</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IPlanarBitmapFrameEncode : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarBitmapFrameEncode::WritePixels (UINT lineCount, WICBitmapPlane* pPlanes, UINT cPlanes)</b><br/>
	/// </summary>
	/// <param name="lineCount"><b>UINT lineCount</b></param>
	/// <param name="pPlanes">__RPC__in_ecount_full(cPlanes) <b>WICBitmapPlane* pPlanes</b></param>
	/// <param name="cPlanes"><b>UINT cPlanes</b></param>
	int WritePixels (uint lineCount, BitmapPlane* pPlanes, uint cPlanes);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPlanarBitmapFrameEncode::WriteSource (IWICBitmapSource** ppPlanes, UINT cPlanes, WICRect* prcSource)</b><br/>
	/// </summary>
	/// <param name="ppPlanes">__RPC__in_ecount_full(cPlanes) <b>IWICBitmapSource** ppPlanes</b></param>
	/// <param name="cPlanes"><b>UINT cPlanes</b></param>
	/// <param name="prcSource">__RPC__in_opt <b>WICRect* prcSource</b></param>
	int WriteSource<T0> (T0** ppPlanes, uint cPlanes, Vector4I* prcSource) where T0 : unmanaged, IBitmapSource;
}

/// <summary>
/// Instance of <b>IWICPlanarBitmapFrameEncode</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct PlanarBitmapFrameEncode : IPlanarBitmapFrameEncode {
//unsafe public readonly struct IPlanarBitmapFrameEncodeObj : IPlanarBitmapFrameEncode {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PlanarBitmapFrameEncode* GetCurrentPointer () => (PlanarBitmapFrameEncode*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPlanarBitmapFrameEncodeObj* GetCurrentPointer () => (IPlanarBitmapFrameEncodeObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xf928b7b8, 0x2221, 0x40c1, 0xb7, 0x2e, 0x7e, 0x82, 0xf1, 0x97, 0x4d, 0x1a);

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
	public readonly int WritePixels (uint lineCount, BitmapPlane* pPlanes, uint cPlanes) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WritePixels (ptr, lineCount, pPlanes, cPlanes);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int WriteSource<T0> (T0** ppPlanes, uint cPlanes, Vector4I* prcSource) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WriteSource (ptr, (void**) ppPlanes, cPlanes, prcSource);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, BitmapPlane*, uint, int> WritePixels;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint, Vector4I*, int> WriteSource;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
