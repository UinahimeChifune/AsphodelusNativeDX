using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextAnalysisSource1</b> : IDWriteTextAnalysisSource<br/>
/// DWRITE_1.h
/// </summary>
unsafe public interface ITextAnalysisSource1 : ITextAnalysisSource {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource1::GetVerticalGlyphOrientation (UINT32 textPosition, UINT32* textLength, DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, UINT8* bidiLevel)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	/// <param name="glyphOrientation">_Out_ <b>DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation</b></param>
	/// <param name="bidiLevel">_Out_ <b>UINT8* bidiLevel</b></param>
	int GetVerticalGlyphOrientation (uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource1::GetVerticalGlyphOrientation (UINT32 textPosition, UINT32* textLength, DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, UINT8* bidiLevel)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	/// <param name="glyphOrientation">_Out_ <b>DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation</b></param>
	/// <param name="bidiLevel">_Out_ <b>UINT8* bidiLevel</b></param>
	int GetVerticalGlyphOrientation (uint textPosition, out uint textLength, out VerticalGlyphOrientation glyphOrientation, out byte bidiLevel);
}

/// <summary>
/// Instance of <b>IDWriteTextAnalysisSource1</b><br/>
/// DWRITE_1.h
/// </summary>
unsafe public readonly struct TextAnalysisSource1 : ITextAnalysisSource1 {
//unsafe public readonly struct ITextAnalysisSource1Obj : ITextAnalysisSource1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextAnalysisSource1* GetCurrentPointer () => (TextAnalysisSource1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextAnalysisSource1Obj* GetCurrentPointer () => (ITextAnalysisSource1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x639cfad8, 0x0fb4, 0x4b21, 0xa5, 0x8a, 0x06, 0x79, 0x20, 0x12, 0x00, 0x09);

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
	public readonly int GetTextAtPosition (uint textPosition, char** textString, uint* textLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextAtPosition (ptr, textPosition, textString, textLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTextAtPosition (uint textPosition, out char* textString, out uint textLength) {
		fixed (char** _textString = &textString) {
			fixed (uint* _textLength = &textLength) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetTextAtPosition (ptr, textPosition, _textString, _textLength);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTextBeforePosition (uint textPosition, char** textString, uint* textLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextBeforePosition (ptr, textPosition, textString, textLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTextBeforePosition (uint textPosition, out char* textString, out uint textLength) {
		fixed (char** _textString = &textString) {
			fixed (uint* _textLength = &textLength) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetTextBeforePosition (ptr, textPosition, _textString, _textLength);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ReadingDirection GetParagraphReadingDirection () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetParagraphReadingDirection (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleName (uint textPosition, uint* textLength, char** localeName) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleName (ptr, textPosition, textLength, localeName);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleName (uint textPosition, out uint textLength, out char* localeName) {
		fixed (uint* _textLength = &textLength) {
			fixed (char** _localeName = &localeName) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleName (ptr, textPosition, _textLength, _localeName);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNumberSubstitution<T0> (uint textPosition, uint* textLength, T0** numberSubstitution) where T0 : unmanaged, INumberSubstitution {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumberSubstitution (ptr, textPosition, textLength, (void**) numberSubstitution);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNumberSubstitution<T0> (uint textPosition, out uint textLength, out T0* numberSubstitution) where T0 : unmanaged, INumberSubstitution {
		fixed (uint* _textLength = &textLength) {
			fixed (T0** _numberSubstitution = &numberSubstitution) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetNumberSubstitution (ptr, textPosition, _textLength, (void**) _numberSubstitution);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVerticalGlyphOrientation (uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVerticalGlyphOrientation (ptr, textPosition, textLength, glyphOrientation, bidiLevel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVerticalGlyphOrientation (uint textPosition, out uint textLength, out VerticalGlyphOrientation glyphOrientation, out byte bidiLevel) {
		fixed (uint* _textLength = &textLength) {
			fixed (VerticalGlyphOrientation* _glyphOrientation = &glyphOrientation) {
				fixed (byte* _bidiLevel = &bidiLevel) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->GetVerticalGlyphOrientation (ptr, textPosition, _textLength, _glyphOrientation, _bidiLevel);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char**, uint*, int> GetTextAtPosition;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char**, uint*, int> GetTextBeforePosition;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ReadingDirection> GetParagraphReadingDirection;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, char**, int> GetLocaleName;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, void**, int> GetNumberSubstitution;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, VerticalGlyphOrientation*, byte*, int> GetVerticalGlyphOrientation;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
