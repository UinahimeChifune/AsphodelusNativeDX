using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFallback</b> : IUnknown<br/>
/// DWRITE_2.h
/// </summary>
unsafe public interface IFontFallback : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallback::MapCharacters (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteFontCollection* baseFontCollection, wchar_t* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, UINT32* mappedLength, IDWriteFont** mappedFont, FLOAT* scale)</b><br/>
	/// </summary>
	/// <param name="analysisSource"><b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="baseFontCollection">_In_opt_ <b>IDWriteFontCollection* baseFontCollection</b></param>
	/// <param name="baseFamilyName">_In_opt_z_ <b>wchar_t* baseFamilyName</b></param>
	/// <param name="baseWeight"><b>DWRITE_FONT_WEIGHT baseWeight</b></param>
	/// <param name="baseStyle"><b>DWRITE_FONT_STYLE baseStyle</b></param>
	/// <param name="baseStretch"><b>DWRITE_FONT_STRETCH baseStretch</b></param>
	/// <param name="mappedLength">_Out_range_(0, textLength) <b>UINT32* mappedLength</b></param>
	/// <param name="mappedFont">_COM_Outptr_result_maybenull_ <b>IDWriteFont** mappedFont</b></param>
	/// <param name="scale">_Out_ <b>FLOAT* scale</b></param>
	int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, T2** mappedFont, float* scale) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFont;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallback::MapCharacters (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteFontCollection* baseFontCollection, wchar_t* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, UINT32* mappedLength, IDWriteFont** mappedFont, FLOAT* scale)</b><br/>
	/// </summary>
	/// <param name="analysisSource"><b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="baseFontCollection">_In_opt_ <b>IDWriteFontCollection* baseFontCollection</b></param>
	/// <param name="baseFamilyName">_In_opt_z_ <b>wchar_t* baseFamilyName</b></param>
	/// <param name="baseWeight"><b>DWRITE_FONT_WEIGHT baseWeight</b></param>
	/// <param name="baseStyle"><b>DWRITE_FONT_STYLE baseStyle</b></param>
	/// <param name="baseStretch"><b>DWRITE_FONT_STRETCH baseStretch</b></param>
	/// <param name="mappedLength">_Out_range_(0, textLength) <b>UINT32* mappedLength</b></param>
	/// <param name="mappedFont">_COM_Outptr_result_maybenull_ <b>IDWriteFont** mappedFont</b></param>
	/// <param name="scale">_Out_ <b>FLOAT* scale</b></param>
	int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, out uint mappedLength, out T2* mappedFont, out float scale) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFont;
}

/// <summary>
/// Instance of <b>IDWriteFontFallback</b><br/>
/// DWRITE_2.h
/// </summary>
unsafe public readonly struct FontFallback : IFontFallback {
//unsafe public readonly struct IFontFallbackObj : IFontFallback {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFallback* GetCurrentPointer () => (FontFallback*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFallbackObj* GetCurrentPointer () => (IFontFallbackObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xefa008f9, 0xf7a1, 0x48bf, 0xb0, 0x5c, 0xf2, 0x24, 0x71, 0x3c, 0xc0, 0xff);

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
	public readonly int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, T2** mappedFont, float* scale) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MapCharacters (ptr, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (void**) mappedFont, scale);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, out uint mappedLength, out T2* mappedFont, out float scale) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFont {
		fixed (uint* _mappedLength = &mappedLength) {
			fixed (T2** _mappedFont = &mappedFont) {
				fixed (float* _scale = &scale) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->MapCharacters (ptr, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, _mappedLength, (void**) _mappedFont, _scale);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, char*, FontWeight, FontStyle, FontStretch, uint*, void**, float*, int> MapCharacters;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
