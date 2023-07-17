using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteGdiInterop1</b> : IDWriteGdiInterop<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IGdiInterop1 : IGdiInterop {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::CreateFontFromLOGFONT (LOGFONTW* logFont, IDWriteFontCollection* fontCollection, IDWriteFont** font)</b><br/>
	/// </summary>
	/// <param name="logFont">_In_ <b>LOGFONTW* logFont</b></param>
	/// <param name="fontCollection">_In_opt_ <b>IDWriteFontCollection* fontCollection</b></param>
	/// <param name="font">_COM_Outptr_ <b>IDWriteFont** font</b></param>
	int CreateFontFromLOGFONT<T0, T1> (LogFontW* logFont, T0* fontCollection, T1** font) where T0 : unmanaged, IFontCollection where T1 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::CreateFontFromLOGFONT (LOGFONTW* logFont, IDWriteFontCollection* fontCollection, IDWriteFont** font)</b><br/>
	/// </summary>
	/// <param name="logFont">_In_ <b>LOGFONTW* logFont</b></param>
	/// <param name="fontCollection">_In_opt_ <b>IDWriteFontCollection* fontCollection</b></param>
	/// <param name="font">_COM_Outptr_ <b>IDWriteFont** font</b></param>
	int CreateFontFromLOGFONT<T0, T1> (LogFontW* logFont, T0* fontCollection, out T1* font) where T0 : unmanaged, IFontCollection where T1 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::GetFontSignature (IDWriteFont* font, FONTSIGNATURE* fontSignature)</b><br/>
	/// </summary>
	/// <param name="font">_In_ <b>IDWriteFont* font</b></param>
	/// <param name="fontSignature">_Out_ <b>FONTSIGNATURE* fontSignature</b></param>
	int GetFontSignature<T0> (T0* font, FontSignature* fontSignature) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::GetFontSignature (IDWriteFont* font, FONTSIGNATURE* fontSignature)</b><br/>
	/// </summary>
	/// <param name="font">_In_ <b>IDWriteFont* font</b></param>
	/// <param name="fontSignature">_Out_ <b>FONTSIGNATURE* fontSignature</b></param>
	int GetFontSignature<T0> (T0* font, out FontSignature fontSignature) where T0 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::GetFontSignature (IDWriteFontFace* fontFace, FONTSIGNATURE* fontSignature)</b><br/>
	/// </summary>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="fontSignature">_Out_ <b>FONTSIGNATURE* fontSignature</b></param>
	int GetFontSignatureFromFontFace<T0> (T0* fontFace, FontSignature* fontSignature) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::GetFontSignature (IDWriteFontFace* fontFace, FONTSIGNATURE* fontSignature)</b><br/>
	/// </summary>
	/// <param name="fontFace">_In_ <b>IDWriteFontFace* fontFace</b></param>
	/// <param name="fontSignature">_Out_ <b>FONTSIGNATURE* fontSignature</b></param>
	int GetFontSignatureFromFontFace<T0> (T0* fontFace, out FontSignature fontSignature) where T0 : unmanaged, IFontFace;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::GetMatchingFontsByLOGFONT (LOGFONT* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)</b><br/>
	/// </summary>
	/// <param name="logFont">_In_ <b>LOGFONT* logFont</b></param>
	/// <param name="fontSet">_In_ <b>IDWriteFontSet* fontSet</b></param>
	/// <param name="filteredSet">_COM_Outptr_ <b>IDWriteFontSet** filteredSet</b></param>
	int GetMatchingFontsByLOGFONT<T0, T1> (LogFontW* logFont, T0* fontSet, T1** filteredSet) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteGdiInterop1::GetMatchingFontsByLOGFONT (LOGFONT* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)</b><br/>
	/// </summary>
	/// <param name="logFont">_In_ <b>LOGFONT* logFont</b></param>
	/// <param name="fontSet">_In_ <b>IDWriteFontSet* fontSet</b></param>
	/// <param name="filteredSet">_COM_Outptr_ <b>IDWriteFontSet** filteredSet</b></param>
	int GetMatchingFontsByLOGFONT<T0, T1> (LogFontW* logFont, T0* fontSet, out T1* filteredSet) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontSet;
}

/// <summary>
/// Instance of <b>IDWriteGdiInterop1</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct GdiInterop1 : IGdiInterop1 {
//unsafe public readonly struct IGdiInterop1Obj : IGdiInterop1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GdiInterop1* GetCurrentPointer () => (GdiInterop1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGdiInterop1Obj* GetCurrentPointer () => (IGdiInterop1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x4556be70, 0x3abd, 0x4f70, 0x90, 0xbe, 0x42, 0x17, 0x80, 0xa6, 0xf5, 0x15);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFromLOGFONT<T0, T1> (LogFontW* logFont, T0* fontCollection, T1** font) where T0 : unmanaged, IFontCollection where T1 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_CreateFontFromLOGFONT (ptr, logFont, fontCollection, (void**) font);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFromLOGFONT<T0, T1> (LogFontW* logFont, T0* fontCollection, out T1* font) where T0 : unmanaged, IFontCollection where T1 : unmanaged, IFont {
		fixed (T1** _font = &font) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_CreateFontFromLOGFONT (ptr, logFont, fontCollection, (void**) _font);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSignature<T0> (T0* font, FontSignature* fontSignature) where T0 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSignature (ptr, font, fontSignature);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSignature<T0> (T0* font, out FontSignature fontSignature) where T0 : unmanaged, IFont {
		fixed (FontSignature* _fontSignature = &fontSignature) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSignature (ptr, font, _fontSignature);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSignatureFromFontFace<T0> (T0* fontFace, FontSignature* fontSignature) where T0 : unmanaged, IFontFace {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontSignature (ptr, fontFace, fontSignature);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSignatureFromFontFace<T0> (T0* fontFace, out FontSignature fontSignature) where T0 : unmanaged, IFontFace {
		fixed (FontSignature* _fontSignature = &fontSignature) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetFontSignature (ptr, fontFace, _fontSignature);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFontsByLOGFONT<T0, T1> (LogFontW* logFont, T0* fontSet, T1** filteredSet) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFontsByLOGFONT (ptr, logFont, fontSet, (void**) filteredSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMatchingFontsByLOGFONT<T0, T1> (LogFontW* logFont, T0* fontSet, out T1* filteredSet) where T0 : unmanaged, IFontSet where T1 : unmanaged, IFontSet {
		fixed (T1** _filteredSet = &filteredSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMatchingFontsByLOGFONT (ptr, logFont, fontSet, (void**) _filteredSet);
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
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LogFontW*, void*, void**, int> _CreateFontFromLOGFONT;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, FontSignature*, int> GetFontSignature;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, FontSignature*, int> _GetFontSignature;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LogFontW*, void*, void**, int> GetMatchingFontsByLOGFONT;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
