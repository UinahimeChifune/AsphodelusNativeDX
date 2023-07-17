using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICImageEncoder</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IImageEncoder : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICImageEncoder::WriteFrame (ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, WICImageParameters* pImageParameters)</b><br/>
	/// </summary>
	/// <param name="pImage"><b>ID2D1Image* pImage</b></param>
	/// <param name="pFrameEncode"><b>IWICBitmapFrameEncode* pFrameEncode</b></param>
	/// <param name="pImageParameters"><b>WICImageParameters* pImageParameters</b></param>
	int WriteFrame<T0, T1> (T0* pImage, T1* pFrameEncode, ImageParameters* pImageParameters) where T0 : unmanaged, Direct2D.IImage where T1 : unmanaged, IBitmapFrameEncode;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICImageEncoder::WriteFrameThumbnail (ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, WICImageParameters* pImageParameters)</b><br/>
	/// </summary>
	/// <param name="pImage"><b>ID2D1Image* pImage</b></param>
	/// <param name="pFrameEncode"><b>IWICBitmapFrameEncode* pFrameEncode</b></param>
	/// <param name="pImageParameters"><b>WICImageParameters* pImageParameters</b></param>
	int WriteFrameThumbnail<T0, T1> (T0* pImage, T1* pFrameEncode, ImageParameters* pImageParameters) where T0 : unmanaged, Direct2D.IImage where T1 : unmanaged, IBitmapFrameEncode;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICImageEncoder::WriteThumbnail (ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, WICImageParameters* pImageParameters)</b><br/>
	/// </summary>
	/// <param name="pImage"><b>ID2D1Image* pImage</b></param>
	/// <param name="pEncoder"><b>IWICBitmapEncoder* pEncoder</b></param>
	/// <param name="pImageParameters"><b>WICImageParameters* pImageParameters</b></param>
	int WriteThumbnail<T0, T1> (T0* pImage, T1* pEncoder, ImageParameters* pImageParameters) where T0 : unmanaged, Direct2D.IImage where T1 : unmanaged, IBitmapEncoder;
}

/// <summary>
/// Instance of <b>IWICImageEncoder</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct ImageEncoder : IImageEncoder {
//unsafe public readonly struct IImageEncoderObj : IImageEncoder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ImageEncoder* GetCurrentPointer () => (ImageEncoder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IImageEncoderObj* GetCurrentPointer () => (IImageEncoderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x04c75bf8, 0x3ce1, 0x473b, 0xac, 0xc5, 0x3c, 0xc4, 0xf5, 0xe9, 0x49, 0x99);

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
	public readonly int WriteFrame<T0, T1> (T0* pImage, T1* pFrameEncode, ImageParameters* pImageParameters) where T0 : unmanaged, Direct2D.IImage where T1 : unmanaged, IBitmapFrameEncode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WriteFrame (ptr, pImage, pFrameEncode, pImageParameters);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int WriteFrameThumbnail<T0, T1> (T0* pImage, T1* pFrameEncode, ImageParameters* pImageParameters) where T0 : unmanaged, Direct2D.IImage where T1 : unmanaged, IBitmapFrameEncode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WriteFrameThumbnail (ptr, pImage, pFrameEncode, pImageParameters);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int WriteThumbnail<T0, T1> (T0* pImage, T1* pEncoder, ImageParameters* pImageParameters) where T0 : unmanaged, Direct2D.IImage where T1 : unmanaged, IBitmapEncoder {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WriteThumbnail (ptr, pImage, pEncoder, pImageParameters);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, ImageParameters*, int> WriteFrame;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, ImageParameters*, int> WriteFrameThumbnail;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, ImageParameters*, int> WriteThumbnail;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
