using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteColorGlyphRunEnumerator</b> : IUnknown<br/>
/// DWRITE_2.h
/// </summary>
unsafe public interface IColorGlyphRunEnumerator : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteColorGlyphRunEnumerator::MoveNext (BOOL* hasRun)</b><br/>
	/// </summary>
	/// <param name="hasRun">_Out_ <b>BOOL* hasRun</b></param>
	int MoveNext (uint* hasRun);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteColorGlyphRunEnumerator::MoveNext (BOOL* hasRun)</b><br/>
	/// </summary>
	/// <param name="hasRun">_Out_ <b>BOOL* hasRun</b></param>
	int MoveNext (out bool hasRun);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteColorGlyphRunEnumerator::GetCurrentRun (DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)</b><br/>
	/// </summary>
	/// <param name="colorGlyphRun">_Outptr_ <b>DWRITE_COLOR_GLYPH_RUN** colorGlyphRun</b></param>
	int GetCurrentRun (ColorGlyphRun** colorGlyphRun);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteColorGlyphRunEnumerator::GetCurrentRun (DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)</b><br/>
	/// </summary>
	/// <param name="colorGlyphRun">_Outptr_ <b>DWRITE_COLOR_GLYPH_RUN** colorGlyphRun</b></param>
	int GetCurrentRun (out ColorGlyphRun* colorGlyphRun);
}

/// <summary>
/// Instance of <b>IDWriteColorGlyphRunEnumerator</b><br/>
/// DWRITE_2.h
/// </summary>
unsafe public readonly struct ColorGlyphRunEnumerator : IColorGlyphRunEnumerator {
//unsafe public readonly struct IColorGlyphRunEnumeratorObj : IColorGlyphRunEnumerator {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ColorGlyphRunEnumerator* GetCurrentPointer () => (ColorGlyphRunEnumerator*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IColorGlyphRunEnumeratorObj* GetCurrentPointer () => (IColorGlyphRunEnumeratorObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xd31fbe17, 0xf157, 0x41a2, 0x8d, 0x24, 0xcb, 0x77, 0x9e, 0x05, 0x60, 0xe8);

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
	public readonly int MoveNext (uint* hasRun) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MoveNext (ptr, hasRun);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MoveNext (out bool hasRun) {
		uint _hasRun;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MoveNext (ptr, &_hasRun);
		hasRun = _hasRun != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentRun (ColorGlyphRun** colorGlyphRun) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentRun (ptr, colorGlyphRun);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentRun (out ColorGlyphRun* colorGlyphRun) {
		fixed (ColorGlyphRun** _colorGlyphRun = &colorGlyphRun) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentRun (ptr, _colorGlyphRun);
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
		public readonly delegate* unmanaged[Stdcall]<void*, ColorGlyphRun**, int> GetCurrentRun;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
