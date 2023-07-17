using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFallback1</b> : IDWriteFontFallback<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontFallback1 : IFontFallback {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallback1::MapCharacters (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteFontCollection* baseFontCollection, WCHAR* baseFamilyName, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, UINT32* mappedLength, FLOAT* scale, IDWriteFontFace5** mappedFontFace)</b><br/>
	/// </summary>
	/// <param name="analysisSource"><b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="baseFontCollection">_In_opt_ <b>IDWriteFontCollection* baseFontCollection</b></param>
	/// <param name="baseFamilyName">_In_opt_z_ <b>WCHAR* baseFamilyName</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="mappedLength">_Deref_out_range_(0, textLength) <b>UINT32* mappedLength</b></param>
	/// <param name="scale">_Out_ <b>FLOAT* scale</b></param>
	/// <param name="mappedFontFace">_COM_Outptr_ <b>IDWriteFontFace5** mappedFontFace</b></param>
	int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, uint* mappedLength, float* scale, T2** mappedFontFace) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFontFace5;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallback1::MapCharacters (IDWriteTextAnalysisSource* analysisSource, UINT32 textPosition, UINT32 textLength, IDWriteFontCollection* baseFontCollection, WCHAR* baseFamilyName, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, UINT32* mappedLength, FLOAT* scale, IDWriteFontFace5** mappedFontFace)</b><br/>
	/// </summary>
	/// <param name="analysisSource"><b>IDWriteTextAnalysisSource* analysisSource</b></param>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="baseFontCollection">_In_opt_ <b>IDWriteFontCollection* baseFontCollection</b></param>
	/// <param name="baseFamilyName">_In_opt_z_ <b>WCHAR* baseFamilyName</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="mappedLength">_Deref_out_range_(0, textLength) <b>UINT32* mappedLength</b></param>
	/// <param name="scale">_Out_ <b>FLOAT* scale</b></param>
	/// <param name="mappedFontFace">_COM_Outptr_ <b>IDWriteFontFace5** mappedFontFace</b></param>
	int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out uint mappedLength, out float scale, out T2* mappedFontFace) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFontFace5;
}

/// <summary>
/// Instance of <b>IDWriteFontFallback1</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontFallback1 : IFontFallback1 {
//unsafe public readonly struct IFontFallback1Obj : IFontFallback1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFallback1* GetCurrentPointer () => (FontFallback1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFallback1Obj* GetCurrentPointer () => (IFontFallback1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2397599d, 0xdd0d, 0x4681, 0xbd, 0x6a, 0xf4, 0xf3, 0x1e, 0xaa, 0xde, 0x77);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, uint* mappedLength, float* scale, T2** mappedFontFace) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFontFace5 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_MapCharacters (ptr, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, fontAxisValues, fontAxisValueCount, mappedLength, scale, (void**) mappedFontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapCharacters<T0, T1, T2> (T0* analysisSource, uint textPosition, uint textLength, T1* baseFontCollection, char* baseFamilyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out uint mappedLength, out float scale, out T2* mappedFontFace) where T0 : unmanaged, ITextAnalysisSource where T1 : unmanaged, IFontCollection where T2 : unmanaged, IFontFace5 {
		fixed (uint* _mappedLength = &mappedLength) {
			fixed (float* _scale = &scale) {
				fixed (T2** _mappedFontFace = &mappedFontFace) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->_MapCharacters (ptr, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, fontAxisValues, fontAxisValueCount, _mappedLength, _scale, (void**) _mappedFontFace);
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
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, char*, FontAxisValue*, uint, uint*, float*, void**, int> _MapCharacters;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
