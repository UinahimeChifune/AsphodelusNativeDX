using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontSetBuilder2</b> : IDWriteFontSetBuilder1<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontSetBuilder2 : IFontSetBuilder1 {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSetBuilder2::AddFont (IDWriteFontFile* fontFile, UINT32 fontFaceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, UINT32 fontAxisRangeCount, DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount)</b><br/>
	/// </summary>
	/// <param name="fontFile">_In_ <b>IDWriteFontFile* fontFile</b></param>
	/// <param name="fontFaceIndex"><b>UINT32 fontFaceIndex</b></param>
	/// <param name="fontSimulations"><b>DWRITE_FONT_SIMULATIONS fontSimulations</b></param>
	/// <param name="fontAxisValues">_In_reads_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	/// <param name="fontAxisRanges">_In_reads_(fontAxisRangeCount) <b>DWRITE_FONT_AXIS_RANGE* fontAxisRanges</b></param>
	/// <param name="fontAxisRangeCount"><b>UINT32 fontAxisRangeCount</b></param>
	/// <param name="properties">_In_reads_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	int AddFont<T0> (T0* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, FontProperty* properties, uint propertyCount) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSetBuilder2::AddFontFile (WCHAR* filePath)</b><br/>
	/// </summary>
	/// <param name="filePath">_In_z_ <b>WCHAR* filePath</b></param>
	int AddFontFile (char* filePath);
}

/// <summary>
/// Instance of <b>IDWriteFontSetBuilder2</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontSetBuilder2 : IFontSetBuilder2 {
//unsafe public readonly struct IFontSetBuilder2Obj : IFontSetBuilder2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontSetBuilder2* GetCurrentPointer () => (FontSetBuilder2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontSetBuilder2Obj* GetCurrentPointer () => (IFontSetBuilder2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xee5ba612, 0xb131, 0x463c, 0x8f, 0x4f, 0x31, 0x89, 0xb9, 0x40, 0x1e, 0x45);

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
	public readonly int AddFontFaceReference<T0> (T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddFontFaceReference (ptr, fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddFontFaceReference<T0> (T0* fontFaceReference, FontProperty* properties, uint propertyCount) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_AddFontFaceReference (ptr, fontFaceReference, properties, propertyCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddFontSet<T0> (T0* fontSet) where T0 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddFontSet (ptr, fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSet<T0> (T0** fontSet) where T0 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSet (ptr, (void**) fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontSet<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet {
		fixed (T0** _fontSet = &fontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontSet (ptr, (void**) _fontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddFontFile<T0> (T0* fontFile) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddFontFile (ptr, fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddFont<T0> (T0* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, FontProperty* properties, uint propertyCount) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddFont (ptr, fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddFontFile (char* filePath) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_AddFontFile (ptr, filePath);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AddFontFaceReference;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, FontProperty*, uint, int> _AddFontFaceReference;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AddFontSet;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontSet;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AddFontFile;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int> AddFont;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> _AddFontFile;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
