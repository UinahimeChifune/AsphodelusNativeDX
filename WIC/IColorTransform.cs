using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICColorTransform</b> : IWICBitmapSource<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IColorTransform : IBitmapSource {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorTransform::Initialize (IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, REFWICPixelFormatGUID pixelFmtDest)</b><br/>
	/// </summary>
	/// <param name="pIBitmapSource">__RPC__in_opt <b>IWICBitmapSource* pIBitmapSource</b></param>
	/// <param name="pIContextSource">__RPC__in_opt <b>IWICColorContext* pIContextSource</b></param>
	/// <param name="pIContextDest">__RPC__in_opt <b>IWICColorContext* pIContextDest</b></param>
	/// <param name="pixelFmtDest">__RPC__in <b>REFWICPixelFormatGUID pixelFmtDest</b></param>
	int Initialize<T0, T1, T2> (T0* pIBitmapSource, T1* pIContextSource, T2* pIContextDest, Guid pixelFmtDest) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IColorContext where T2 : unmanaged, IColorContext;
}

/// <summary>
/// Instance of <b>IWICColorTransform</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct ColorTransform : IColorTransform {
//unsafe public readonly struct IColorTransformObj : IColorTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ColorTransform* GetCurrentPointer () => (ColorTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IColorTransformObj* GetCurrentPointer () => (IColorTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb66f034f, 0xd0e2, 0x40ab, 0xb4, 0x36, 0x6d, 0xe3, 0x9e, 0x32, 0x1a, 0x94);

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
	public readonly int GetSize (uint* puiWidth, uint* puiHeight) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, puiWidth, puiHeight);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSize (out uint puiWidth, out uint puiHeight) {
		fixed (uint* _puiWidth = &puiWidth) {
			fixed (uint* _puiHeight = &puiHeight) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, _puiWidth, _puiHeight);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormat (Guid* pPixelFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr, pPixelFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormat (out Guid pPixelFormat) {
		fixed (Guid* _pPixelFormat = &pPixelFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr, _pPixelFormat);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetResolution (double* pDpiX, double* pDpiY) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetResolution (ptr, pDpiX, pDpiY);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetResolution (out double pDpiX, out double pDpiY) {
		fixed (double* _pDpiX = &pDpiX) {
			fixed (double* _pDpiY = &pDpiY) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetResolution (ptr, _pDpiX, _pDpiY);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPalette (ptr, pIPalette);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, cbStride, cbBufferSize, pbBuffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prc, uint cbStride, uint cbBufferSize, out byte pbBuffer) {
		fixed (byte* _pbBuffer = &pbBuffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, cbStride, cbBufferSize, _pbBuffer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Initialize<T0, T1, T2> (T0* pIBitmapSource, T1* pIContextSource, T2* pIContextDest, Guid pixelFmtDest) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IColorContext where T2 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Initialize (ptr, pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDest);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, int> GetSize;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetPixelFormat;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, double*, int> GetResolution;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> CopyPalette;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint, uint, byte*, int> CopyPixels;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, Guid, int> Initialize;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
