using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteColorGlyphRunEnumerator1</b> : IDWriteColorGlyphRunEnumerator<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IColorGlyphRunEnumerator1 : IColorGlyphRunEnumerator {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteColorGlyphRunEnumerator1::GetCurrentRun (DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun)</b><br/>
	/// </summary>
	/// <param name="colorGlyphRun">_Outptr_ <b>DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun</b></param>
	int GetCurrentRun (ColorGlyphRun1** colorGlyphRun);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteColorGlyphRunEnumerator1::GetCurrentRun (DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun)</b><br/>
	/// </summary>
	/// <param name="colorGlyphRun">_Outptr_ <b>DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun</b></param>
	int GetCurrentRun (out ColorGlyphRun1* colorGlyphRun);
}

/// <summary>
/// Instance of <b>IDWriteColorGlyphRunEnumerator1</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct ColorGlyphRunEnumerator1 : IColorGlyphRunEnumerator1 {
//unsafe public readonly struct IColorGlyphRunEnumerator1Obj : IColorGlyphRunEnumerator1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ColorGlyphRunEnumerator1* GetCurrentPointer () => (ColorGlyphRunEnumerator1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IColorGlyphRunEnumerator1Obj* GetCurrentPointer () => (IColorGlyphRunEnumerator1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x7c5f86da, 0xc7a1, 0x4f05, 0xb8, 0xe1, 0x55, 0xa1, 0x79, 0xfe, 0x5a, 0x35);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentRun (ColorGlyphRun1** colorGlyphRun) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentRun1 (ptr, colorGlyphRun);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentRun (out ColorGlyphRun1* colorGlyphRun) {
		fixed (ColorGlyphRun1** _colorGlyphRun = &colorGlyphRun) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentRun1 (ptr, _colorGlyphRun);
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
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorGlyphRun1**, int> GetCurrentRun1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
