using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontCollection1</b> : IDWriteFontCollection<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontCollection1 : IFontCollection {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection1::GetFontSet (IDWriteFontSet** fontSet)</b><br/>
	/// </summary>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet** fontSet</b></param>
	int GetFontSet<T0> (T0** fontSet) where T0 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection1::GetFontSet (IDWriteFontSet** fontSet)</b><br/>
	/// </summary>
	/// <param name="fontSet">_COM_Outptr_ <b>IDWriteFontSet** fontSet</b></param>
	int GetFontSet<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection1::GetFontFamily (UINT32 index, IDWriteFontFamily1** fontFamily)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily1** fontFamily</b></param>
	int GetFontFamily1<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily1;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontCollection1::GetFontFamily (UINT32 index, IDWriteFontFamily1** fontFamily)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="fontFamily">_COM_Outptr_ <b>IDWriteFontFamily1** fontFamily</b></param>
	int GetFontFamily1<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily1;
}

/// <summary>
/// Instance of <b>IDWriteFontCollection1</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontCollection1 : IFontCollection1 {
//unsafe public readonly struct IFontCollection1Obj : IFontCollection1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontCollection1* GetCurrentPointer () => (FontCollection1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontCollection1Obj* GetCurrentPointer () => (IFontCollection1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x53585141, 0xd9f8, 0x4095, 0x83, 0x21, 0xd7, 0x3c, 0xf6, 0xbd, 0x11, 0x6c);

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
	public readonly uint GetFontFamilyCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamilyCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily (ptr, index, (void**) fontFamily);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily {
		fixed (T0** _fontFamily = &fontFamily) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily (ptr, index, (void**) _fontFamily);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFamilyName (char* familyName, uint* index, uint* exists) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindFamilyName (ptr, familyName, index, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindFamilyName (char* familyName, out uint index, out bool exists) {
		fixed (uint* _index = &index) {
			uint _exists;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindFamilyName (ptr, familyName, _index, &_exists);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFromFontFace<T0, T1> (T0* fontFace, T1** font) where T0 : unmanaged, IFontFace where T1 : unmanaged, IFont {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFromFontFace (ptr, fontFace, (void**) font);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFromFontFace<T0, T1> (T0* fontFace, out T1* font) where T0 : unmanaged, IFontFace where T1 : unmanaged, IFont {
		fixed (T1** _font = &font) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFromFontFace (ptr, fontFace, (void**) _font);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSet<T0> (T0** fontSet) where T0 : unmanaged, IFontSet {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSet (ptr, (void**) fontSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontSet<T0> (out T0* fontSet) where T0 : unmanaged, IFontSet {
		fixed (T0** _fontSet = &fontSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontSet (ptr, (void**) _fontSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily1<T0> (uint index, T0** fontFamily) where T0 : unmanaged, IFontFamily1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily1 (ptr, index, (void**) fontFamily);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFamily1<T0> (uint index, out T0* fontFamily) where T0 : unmanaged, IFontFamily1 {
		fixed (T0** _fontFamily = &fontFamily) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFamily1 (ptr, index, (void**) _fontFamily);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontFamilyCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFontFamily;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint*, uint*, int> FindFamilyName;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> GetFontFromFontFace;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontSet;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetFontFamily1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
