using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontResource</b> : IUnknown<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontResource : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetFontFile (IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int GetFontFile<T0> (T0** fontFile) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetFontFile (IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int GetFontFile<T0> (out T0* fontFile) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontResource::GetFontFaceIndex ()</b><br/>
	/// </summary>
	uint GetFontFaceIndex ();
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontResource::GetFontAxisCount ()</b><br/>
	/// </summary>
	uint GetFontAxisCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetDefaultFontAxisValues (DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisValues">_Out_writes_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	int GetDefaultFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetFontAxisRanges (DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 fontAxisRangeCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisRanges">_Out_writes_(fontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="fontAxisRangeCount"><b>UINT32 fontAxisRangeCount</b></param>
	int GetFontAxisRanges (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_AXIS_ATTRIBUTES IDWriteFontResource::GetFontAxisAttributes (UINT32 axisIndex)</b><br/>
	/// </summary>
	/// <param name="axisIndex"><b>UINT32 axisIndex</b></param>
	FontAxisAttributes GetFontAxisAttributes (uint axisIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetAxisNames (UINT32 axisIndex, IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="axisIndex"><b>UINT32 axisIndex</b></param>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetAxisNames<T0> (uint axisIndex, T0** names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetAxisNames (UINT32 axisIndex, IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="axisIndex"><b>UINT32 axisIndex</b></param>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetAxisNames<T0> (uint axisIndex, out T0* names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontResource::GetAxisValueNameCount (UINT32 axisIndex)</b><br/>
	/// </summary>
	/// <param name="axisIndex"><b>UINT32 axisIndex</b></param>
	uint GetAxisValueNameCount (uint axisIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetAxisValueNames (UINT32 axisIndex, UINT32 axisValueIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRange, IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="axisIndex"><b>UINT32 axisIndex</b></param>
	/// <param name="axisValueIndex"><b>UINT32 axisValueIndex</b></param>
	/// <param name="fontAxisRange">_Out_ <b>DWRITE_FONT_AXIS_RANGE* fontAxisRange</b></param>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetAxisValueNames<T0> (uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, T0** names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::GetAxisValueNames (UINT32 axisIndex, UINT32 axisValueIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRange, IDWriteLocalizedStrings** names)</b><br/>
	/// </summary>
	/// <param name="axisIndex"><b>UINT32 axisIndex</b></param>
	/// <param name="axisValueIndex"><b>UINT32 axisValueIndex</b></param>
	/// <param name="fontAxisRange">_Out_ <b>DWRITE_FONT_AXIS_RANGE* fontAxisRange</b></param>
	/// <param name="names">_COM_Outptr_ <b>IDWriteLocalizedStrings** names</b></param>
	int GetAxisValueNames<T0> (uint axisIndex, uint axisValueIndex, out FontAxisRange fontAxisRange, out T0* names) where T0 : unmanaged, ILocalizedStrings;
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFontResource::HasVariations ()</b><br/>
	/// </summary>
	bool HasVariations ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::CreateFontFace (DWRITE_FONT_SIMULATIONS fontSimulations, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontFace5** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontSimulations"><b>DWRITE_FONT_SIMULATIONS fontSimulations</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace5** fontFace</b></param>
	int CreateFontFace<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** fontFace) where T0 : unmanaged, IFontFace5;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::CreateFontFace (DWRITE_FONT_SIMULATIONS fontSimulations, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontFace5** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontSimulations"><b>DWRITE_FONT_SIMULATIONS fontSimulations</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace5** fontFace</b></param>
	int CreateFontFace<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* fontFace) where T0 : unmanaged, IFontFace5;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::CreateFontFaceReference (DWRITE_FONT_SIMULATIONS fontSimulations, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="fontSimulations"><b>DWRITE_FONT_SIMULATIONS fontSimulations</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="fontFaceReference">_COM_Outptr_ <b>IDWriteFontFaceReference1** fontFaceReference</b></param>
	int CreateFontFaceReference<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontResource::CreateFontFaceReference (DWRITE_FONT_SIMULATIONS fontSimulations, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="fontSimulations"><b>DWRITE_FONT_SIMULATIONS fontSimulations</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="fontFaceReference">_COM_Outptr_ <b>IDWriteFontFaceReference1** fontFaceReference</b></param>
	int CreateFontFaceReference<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference1;
}

/// <summary>
/// Instance of <b>IDWriteFontResource</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontResource : IFontResource {
//unsafe public readonly struct IFontResourceObj : IFontResource {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontResource* GetCurrentPointer () => (FontResource*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontResourceObj* GetCurrentPointer () => (IFontResourceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1f803a76, 0x6871, 0x48e8, 0x98, 0x7f, 0xb9, 0x75, 0x55, 0x1c, 0x50, 0xf2);

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
	public readonly int GetFontFile<T0> (T0** fontFile) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFile (ptr, (void**) fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFile<T0> (out T0* fontFile) where T0 : unmanaged, IFontFile {
		fixed (T0** _fontFile = &fontFile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFile (ptr, (void**) _fontFile);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontFaceIndex () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceIndex (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontAxisCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDefaultFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDefaultFontAxisValues (ptr, fontAxisValues, fontAxisValueCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontAxisRanges (FontAxisRange* fontAxisRanges, uint fontAxisRangeCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisRanges (ptr, fontAxisRanges, fontAxisRangeCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontAxisAttributes GetFontAxisAttributes (uint axisIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisAttributes (ptr, axisIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAxisNames<T0> (uint axisIndex, T0** names) where T0 : unmanaged, ILocalizedStrings {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAxisNames (ptr, axisIndex, (void**) names);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAxisNames<T0> (uint axisIndex, out T0* names) where T0 : unmanaged, ILocalizedStrings {
		fixed (T0** _names = &names) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAxisNames (ptr, axisIndex, (void**) _names);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetAxisValueNameCount (uint axisIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAxisValueNameCount (ptr, axisIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAxisValueNames<T0> (uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, T0** names) where T0 : unmanaged, ILocalizedStrings {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAxisValueNames (ptr, axisIndex, axisValueIndex, fontAxisRange, (void**) names);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAxisValueNames<T0> (uint axisIndex, uint axisValueIndex, out FontAxisRange fontAxisRange, out T0* names) where T0 : unmanaged, ILocalizedStrings {
		fixed (FontAxisRange* _fontAxisRange = &fontAxisRange) {
			fixed (T0** _names = &names) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetAxisValueNames (ptr, axisIndex, axisValueIndex, _fontAxisRange, (void**) _names);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool HasVariations () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasVariations (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** fontFace) where T0 : unmanaged, IFontFace5 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, fontSimulations, fontAxisValues, fontAxisValueCount, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* fontFace) where T0 : unmanaged, IFontFace5 {
		fixed (T0** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, fontSimulations, fontAxisValues, fontAxisValueCount, (void**) _fontFace);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, T0** fontFaceReference) where T0 : unmanaged, IFontFaceReference1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceReference (ptr, fontSimulations, fontAxisValues, fontAxisValueCount, (void**) fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceReference<T0> (FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, out T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference1 {
		fixed (T0** _fontFaceReference = &fontFaceReference) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceReference (ptr, fontSimulations, fontAxisValues, fontAxisValueCount, (void**) _fontFaceReference);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontFile;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontFaceIndex;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontAxisCount;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisValue*, uint, int> GetDefaultFontAxisValues;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisRange*, uint, int> GetFontAxisRanges;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontAxisAttributes> GetFontAxisAttributes;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetAxisNames;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> GetAxisValueNameCount;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, FontAxisRange*, void**, int> GetAxisValueNames;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> HasVariations;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontSimulations, FontAxisValue*, uint, void**, int> CreateFontFace;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontSimulations, FontAxisValue*, uint, void**, int> CreateFontFaceReference;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
