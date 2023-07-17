using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontSetBuilder</b> : IUnknown<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontSetBuilder : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSetBuilder::AddFontFaceReference (IDWriteFontFaceReference* fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="fontFaceReference">_In_ <b>IDWriteFontFaceReference* fontFaceReference</b></param>
	int AddFontFaceReference<T0> (T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSetBuilder::AddFontFaceReference (IDWriteFontFaceReference* fontFaceReference, DWRITE_FONT_PROPERTY* properties, UINT32 propertyCount)</b><br/>
	/// </summary>
	/// <param name="fontFaceReference">_In_ <b>IDWriteFontFaceReference* fontFaceReference</b></param>
	/// <param name="properties">_In_reads_(propertyCount) <b>DWRITE_FONT_PROPERTY* properties</b></param>
	/// <param name="propertyCount"><b>UINT32 propertyCount</b></param>
	int AddFontFaceReference<T0> (T0* fontFaceReference, FontProperty* properties, uint propertyCount) where T0 : unmanaged, IFontFaceReference;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSetBuilder::AddFontSet (IDWriteFontSet* fontSet)</b><br/>
	/// </summary>
	/// <param name="fontSet">_In_ <b>IDWriteFontSet* fontSet</b></param>
	int AddFontSet<T0> (T0* fontSet) where T0 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSetBuilder::CreateFontSet (IDWriteFontSet** fontSet)</b><br/>
	/// </summary>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet** fontSet</b></param>
	int CreateFontSet<T0> (T0** fontSet) where T0 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontSetBuilder::CreateFontSet (IDWriteFontSet** fontSet)</b><br/>
	/// </summary>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet** fontSet</b></param>
	int CreateFontSet<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet;
}

/// <summary>
/// Instance of <b>IDWriteFontSetBuilder</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontSetBuilder : IFontSetBuilder {
//unsafe public readonly struct IFontSetBuilderObj : IFontSetBuilder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontSetBuilder* GetCurrentPointer () => (FontSetBuilder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontSetBuilderObj* GetCurrentPointer () => (IFontSetBuilderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2f642afe, 0x9c68, 0x4f40, 0xb8, 0xbe, 0x45, 0x74, 0x01, 0xaf, 0xcb, 0x3d);

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
		var hr = ((FunctionPointer*) ptr->_pointer)->_AddFontFaceReference (ptr, fontFaceReference);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddFontFaceReference<T0> (T0* fontFaceReference, FontProperty* properties, uint propertyCount) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddFontFaceReference (ptr, fontFaceReference, properties, propertyCount);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, FontProperty*, uint, int> AddFontFaceReference;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> _AddFontFaceReference;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AddFontSet;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontSet;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
