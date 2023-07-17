using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteGdiInterop</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IGdiInterop : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::CreateFontFromLOGFONT (LOGFONTW* logFont, IDWriteFont** font)</b><br/>
	/// </summary>
	/// <param name="logFont">_In_ <b>LOGFONTW* logFont</b></param>
	/// <param name="font">_COM_Outptr_ <b>IDWriteFont** font</b></param>
	int CreateFontFromLOGFONT<T0> (LogFontW* logFont, T0** font) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::CreateFontFromLOGFONT (LOGFONTW* logFont, IDWriteFont** font)</b><br/>
	/// </summary>
	/// <param name="logFont">_In_ <b>LOGFONTW* logFont</b></param>
	/// <param name="font">_COM_Outptr_ <b>IDWriteFont** font</b></param>
	int CreateFontFromLOGFONT<T0> (LogFontW* logFont, out T0* font) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::ConvertFontToLOGFONT (IDWriteFont* font, LOGFONTW* logFont, BOOL* isSystemFont)</b><br/>
	/// </summary>
	/// <param name="font">_In_ <b>IDWriteFont* font</b></param>
	/// <param name="logFont">_Out_ <b>LOGFONTW* logFont</b></param>
	/// <param name="isSystemFont">_Out_ <b>BOOL* isSystemFont</b></param>
	int ConvertFontToLOGFONT<T0> (T0* font, LogFontW* logFont, uint* isSystemFont) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::ConvertFontToLOGFONT (IDWriteFont* font, LOGFONTW* logFont, BOOL* isSystemFont)</b><br/>
	/// </summary>
	/// <param name="font">_In_ <b>IDWriteFont* font</b></param>
	/// <param name="logFont">_Out_ <b>LOGFONTW* logFont</b></param>
	/// <param name="isSystemFont">_Out_ <b>BOOL* isSystemFont</b></param>
	int ConvertFontToLOGFONT<T0> (T0* font, out LogFontW logFont, out bool isSystemFont) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::ConvertFontFaceToLOGFONT (IDWriteFontFace* font, LOGFONTW* logFont)</b><br/>
	/// </summary>
	/// <param name="font">_In_ <b>IDWriteFontFace* font</b></param>
	/// <param name="logFont">_Out_ <b>LOGFONTW* logFont</b></param>
	int ConvertFontFaceToLOGFONT<T0> (T0* font, LogFontW* logFont) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::ConvertFontFaceToLOGFONT (IDWriteFontFace* font, LOGFONTW* logFont)</b><br/>
	/// </summary>
	/// <param name="font">_In_ <b>IDWriteFontFace* font</b></param>
	/// <param name="logFont">_Out_ <b>LOGFONTW* logFont</b></param>
	int ConvertFontFaceToLOGFONT<T0> (T0* font, out LogFontW logFont) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::CreateFontFaceFromHdc (HDC hdc, IDWriteFontFace** fontFace)</b><br/>
	/// </summary>
	/// <param name="hdc"><b>HDC hdc</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace** fontFace</b></param>
	int CreateFontFaceFromHdc<T0> (IntPtr hdc, T0** fontFace) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::CreateFontFaceFromHdc (HDC hdc, IDWriteFontFace** fontFace)</b><br/>
	/// </summary>
	/// <param name="hdc"><b>HDC hdc</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace** fontFace</b></param>
	int CreateFontFaceFromHdc<T0> (IntPtr hdc, out T0* fontFace) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::CreateBitmapRenderTarget (HDC hdc, UINT32 width, UINT32 height, IDWriteBitmapRenderTarget** renderTarget)</b><br/>
	/// </summary>
	/// <param name="hdc">_In_opt_ <b>HDC hdc</b></param>
	/// <param name="width"><b>UINT32 width</b></param>
	/// <param name="height"><b>UINT32 height</b></param>
	/// <param name="renderTarget">_COM_Outptr_ <b>IDWriteBitmapRenderTarget** renderTarget</b></param>
	int CreateBitmapRenderTarget<T0> (IntPtr hdc, uint width, uint height, T0** renderTarget) where T0 : unmanaged, IBitmapRenderTarget;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop::CreateBitmapRenderTarget (HDC hdc, UINT32 width, UINT32 height, IDWriteBitmapRenderTarget** renderTarget)</b><br/>
	/// </summary>
	/// <param name="hdc">_In_opt_ <b>HDC hdc</b></param>
	/// <param name="width"><b>UINT32 width</b></param>
	/// <param name="height"><b>UINT32 height</b></param>
	/// <param name="renderTarget">_COM_Outptr_ <b>IDWriteBitmapRenderTarget** renderTarget</b></param>
	int CreateBitmapRenderTarget<T0> (IntPtr hdc, uint width, uint height, out T0* renderTarget) where T0 : unmanaged, IBitmapRenderTarget;
}

/// <summary>
/// Instance of <b>IDWriteGdiInterop</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct GdiInterop : IGdiInterop {
//unsafe public readonly struct IGdiInteropObj : IGdiInterop {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GdiInterop* GetCurrentPointer () => (GdiInterop*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGdiInteropObj* GetCurrentPointer () => (IGdiInteropObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1edd9491, 0x9853, 0x4299, 0x89, 0x8f, 0x64, 0x32, 0x98, 0x3b, 0x6f, 0x3a);

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
	public readonly int CreateFontFromLOGFONT<T0> (LogFontW* logFont, T0** font) where T0 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFromLOGFONT (ptr, logFont, (void**) font);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFromLOGFONT<T0> (LogFontW* logFont, out T0* font) where T0 : unmanaged, IFont {
		fixed (T0** _font = &font) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFromLOGFONT (ptr, logFont, (void**) _font);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConvertFontToLOGFONT<T0> (T0* font, LogFontW* logFont, uint* isSystemFont) where T0 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ConvertFontToLOGFONT (ptr, font, logFont, isSystemFont);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConvertFontToLOGFONT<T0> (T0* font, out LogFontW logFont, out bool isSystemFont) where T0 : unmanaged, IFont {
		fixed (LogFontW* _logFont = &logFont) {
			uint _isSystemFont;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->ConvertFontToLOGFONT (ptr, font, _logFont, &_isSystemFont);
			isSystemFont = _isSystemFont != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConvertFontFaceToLOGFONT<T0> (T0* font, LogFontW* logFont) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ConvertFontFaceToLOGFONT (ptr, font, logFont);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConvertFontFaceToLOGFONT<T0> (T0* font, out LogFontW logFont) where T0 : unmanaged, IFontFace {
		fixed (LogFontW* _logFont = &logFont) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->ConvertFontFaceToLOGFONT (ptr, font, _logFont);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceFromHdc<T0> (IntPtr hdc, T0** fontFace) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceFromHdc (ptr, hdc, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceFromHdc<T0> (IntPtr hdc, out T0* fontFace) where T0 : unmanaged, IFontFace {
		fixed (T0** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceFromHdc (ptr, hdc, (void**) _fontFace);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapRenderTarget<T0> (IntPtr hdc, uint width, uint height, T0** renderTarget) where T0 : unmanaged, IBitmapRenderTarget {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapRenderTarget (ptr, hdc, width, height, (void**) renderTarget);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateBitmapRenderTarget<T0> (IntPtr hdc, uint width, uint height, out T0* renderTarget) where T0 : unmanaged, IBitmapRenderTarget {
		fixed (T0** _renderTarget = &renderTarget) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateBitmapRenderTarget (ptr, hdc, width, height, (void**) _renderTarget);
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
		public readonly delegate* unmanaged[Stdcall]<void*, LogFontW*, void**, int> CreateFontFromLOGFONT;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, LogFontW*, uint*, int> ConvertFontToLOGFONT;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, LogFontW*, int> ConvertFontFaceToLOGFONT;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, void**, int> CreateFontFaceFromHdc;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr, uint, uint, void**, int> CreateBitmapRenderTarget;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
