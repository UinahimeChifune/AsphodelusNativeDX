using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFileEnumerator</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IFontFileEnumerator : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileEnumerator::MoveNext (BOOL* hasCurrentFile)</b><br/>
	/// </summary>
	/// <param name="hasCurrentFile">_Out_ <b>BOOL* hasCurrentFile</b></param>
	int MoveNext (uint* hasCurrentFile);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileEnumerator::MoveNext (BOOL* hasCurrentFile)</b><br/>
	/// </summary>
	/// <param name="hasCurrentFile">_Out_ <b>BOOL* hasCurrentFile</b></param>
	int MoveNext (out bool hasCurrentFile);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileEnumerator::GetCurrentFontFile (IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int GetCurrentFontFile<T0> (T0** fontFile) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFileEnumerator::GetCurrentFontFile (IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int GetCurrentFontFile<T0> (out T0* fontFile) where T0 : unmanaged, IFontFile;
}

/// <summary>
/// Instance of <b>IDWriteFontFileEnumerator</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct FontFileEnumerator : IFontFileEnumerator {
//unsafe public readonly struct IFontFileEnumeratorObj : IFontFileEnumerator {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFileEnumerator* GetCurrentPointer () => (FontFileEnumerator*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFileEnumeratorObj* GetCurrentPointer () => (IFontFileEnumeratorObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x72755049, 0x5ff7, 0x435d, 0x83, 0x48, 0x4b, 0xe9, 0x7c, 0xfa, 0x6c, 0x7c);

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
	public readonly int MoveNext (uint* hasCurrentFile) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MoveNext (ptr, hasCurrentFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MoveNext (out bool hasCurrentFile) {
		uint _hasCurrentFile;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MoveNext (ptr, &_hasCurrentFile);
		hasCurrentFile = _hasCurrentFile != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentFontFile<T0> (T0** fontFile) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentFontFile (ptr, (void**) fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentFontFile<T0> (out T0* fontFile) where T0 : unmanaged, IFontFile {
		fixed (T0** _fontFile = &fontFile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentFontFile (ptr, (void**) _fontFile);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> MoveNext;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetCurrentFontFile;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
