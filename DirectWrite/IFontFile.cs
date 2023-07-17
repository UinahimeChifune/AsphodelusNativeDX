using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFile</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontFile : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFile::GetReferenceKey (void** fontFileReferenceKey, UINT32* fontFileReferenceKeySize)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_Outptr_result_bytebuffer_(*fontFileReferenceKeySize) <b>void** fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize">_Out_ <b>UINT32* fontFileReferenceKeySize</b></param>
	int GetReferenceKey (void** fontFileReferenceKey, uint* fontFileReferenceKeySize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFile::GetReferenceKey (void** fontFileReferenceKey, UINT32* fontFileReferenceKeySize)</b><br/>
	/// </summary>
	/// <param name="fontFileReferenceKey">_Outptr_result_bytebuffer_(*fontFileReferenceKeySize) <b>void** fontFileReferenceKey</b></param>
	/// <param name="fontFileReferenceKeySize">_Out_ <b>UINT32* fontFileReferenceKeySize</b></param>
	int GetReferenceKey (out void* fontFileReferenceKey, out uint fontFileReferenceKeySize);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFile::GetLoader (IDWriteFontFileLoader** fontFileLoader)</b><br/>
	/// </summary>
	/// <param name="fontFileLoader">_COM_Outptr_ <b>IDWriteFontFileLoader** fontFileLoader</b></param>
	int GetLoader<T0> (T0** fontFileLoader) where T0 : unmanaged, IFontFileLoader;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFile::GetLoader (IDWriteFontFileLoader** fontFileLoader)</b><br/>
	/// </summary>
	/// <param name="fontFileLoader">_COM_Outptr_ <b>IDWriteFontFileLoader** fontFileLoader</b></param>
	int GetLoader<T0> (out T0* fontFileLoader) where T0 : unmanaged, IFontFileLoader;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFile::Analyze (BOOL* isSupportedFontType, DWRITE_FONT_FILE_TYPE* fontFileType, DWRITE_FONT_FACE_TYPE* fontFaceType, UINT32* numberOfFaces)</b><br/>
	/// </summary>
	/// <param name="isSupportedFontType">_Out_ <b>BOOL* isSupportedFontType</b></param>
	/// <param name="fontFileType">_Out_ <b>DWRITE_FONT_FILE_TYPE* fontFileType</b></param>
	/// <param name="fontFaceType">_Out_opt_ <b>DWRITE_FONT_FACE_TYPE* fontFaceType</b></param>
	/// <param name="numberOfFaces">_Out_ <b>UINT32* numberOfFaces</b></param>
	int Analyze (uint* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFile::Analyze (BOOL* isSupportedFontType, DWRITE_FONT_FILE_TYPE* fontFileType, DWRITE_FONT_FACE_TYPE* fontFaceType, UINT32* numberOfFaces)</b><br/>
	/// </summary>
	/// <param name="isSupportedFontType">_Out_ <b>BOOL* isSupportedFontType</b></param>
	/// <param name="fontFileType">_Out_ <b>DWRITE_FONT_FILE_TYPE* fontFileType</b></param>
	/// <param name="fontFaceType">_Out_opt_ <b>DWRITE_FONT_FACE_TYPE* fontFaceType</b></param>
	/// <param name="numberOfFaces">_Out_ <b>UINT32* numberOfFaces</b></param>
	int Analyze (out bool isSupportedFontType, out FontFileType fontFileType, out FontFaceType fontFaceType, out uint numberOfFaces);
}

/// <summary>
/// Instance of <b>IDWriteFontFile</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontFile : IFontFile {
//unsafe public readonly struct IFontFileObj : IFontFile {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFile* GetCurrentPointer () => (FontFile*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFileObj* GetCurrentPointer () => (IFontFileObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x739d886a, 0xcef5, 0x47dc, 0x87, 0x69, 0x1a, 0x8b, 0x41, 0xbe, 0xbb, 0xb0);

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
	public readonly int GetReferenceKey (void** fontFileReferenceKey, uint* fontFileReferenceKeySize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetReferenceKey (ptr, fontFileReferenceKey, fontFileReferenceKeySize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetReferenceKey (out void* fontFileReferenceKey, out uint fontFileReferenceKeySize) {
		fixed (void** _fontFileReferenceKey = &fontFileReferenceKey) {
			fixed (uint* _fontFileReferenceKeySize = &fontFileReferenceKeySize) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetReferenceKey (ptr, _fontFileReferenceKey, _fontFileReferenceKeySize);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLoader<T0> (T0** fontFileLoader) where T0 : unmanaged, IFontFileLoader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLoader (ptr, (void**) fontFileLoader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLoader<T0> (out T0* fontFileLoader) where T0 : unmanaged, IFontFileLoader {
		fixed (T0** _fontFileLoader = &fontFileLoader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLoader (ptr, (void**) _fontFileLoader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Analyze (uint* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Analyze (ptr, isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Analyze (out bool isSupportedFontType, out FontFileType fontFileType, out FontFaceType fontFaceType, out uint numberOfFaces) {
		uint _isSupportedFontType;
		fixed (FontFileType* _fontFileType = &fontFileType) {
			fixed (FontFaceType* _fontFaceType = &fontFaceType) {
				fixed (uint* _numberOfFaces = &numberOfFaces) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->Analyze (ptr, &_isSupportedFontType, _fontFileType, _fontFaceType, _numberOfFaces);
					isSupportedFontType = _isSupportedFontType != 0;
					return hr;
				}
			}
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint*, int> GetReferenceKey;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetLoader;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, FontFileType*, FontFaceType*, uint*, int> Analyze;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
