using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextAnalysisSource</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ITextAnalysisSource : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetTextAtPosition (UINT32 textPosition, WCHAR** textString, UINT32* textLength)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textString">_Outptr_result_buffer_(*textLength) <b>WCHAR** textString</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	int GetTextAtPosition (uint textPosition, char** textString, uint* textLength);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetTextAtPosition (UINT32 textPosition, WCHAR** textString, UINT32* textLength)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textString">_Outptr_result_buffer_(*textLength) <b>WCHAR** textString</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	int GetTextAtPosition (uint textPosition, out char* textString, out uint textLength);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetTextBeforePosition (UINT32 textPosition, WCHAR** textString, UINT32* textLength)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textString">_Outptr_result_buffer_(*textLength) <b>WCHAR** textString</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	int GetTextBeforePosition (uint textPosition, char** textString, uint* textLength);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetTextBeforePosition (UINT32 textPosition, WCHAR** textString, UINT32* textLength)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textString">_Outptr_result_buffer_(*textLength) <b>WCHAR** textString</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	int GetTextBeforePosition (uint textPosition, out char* textString, out uint textLength);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_READING_DIRECTION IDWriteTextAnalysisSource::GetParagraphReadingDirection ()</b><br/>
	/// </summary>
	ReadingDirection GetParagraphReadingDirection ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetLocaleName (UINT32 textPosition, UINT32* textLength, WCHAR** localeName)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	/// <param name="localeName">_Outptr_result_z_ <b>WCHAR** localeName</b></param>
	int GetLocaleName (uint textPosition, uint* textLength, char** localeName);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetLocaleName (UINT32 textPosition, UINT32* textLength, WCHAR** localeName)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	/// <param name="localeName">_Outptr_result_z_ <b>WCHAR** localeName</b></param>
	int GetLocaleName (uint textPosition, out uint textLength, out char* localeName);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetNumberSubstitution (UINT32 textPosition, UINT32* textLength, IDWriteNumberSubstitution** numberSubstitution)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	/// <param name="numberSubstitution">_COM_Outptr_ <b>IDWriteNumberSubstitution** numberSubstitution</b></param>
	int GetNumberSubstitution<T0> (uint textPosition, uint* textLength, T0** numberSubstitution) where T0 : unmanaged, INumberSubstitution;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSource::GetNumberSubstitution (UINT32 textPosition, UINT32* textLength, IDWriteNumberSubstitution** numberSubstitution)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength">_Out_ <b>UINT32* textLength</b></param>
	/// <param name="numberSubstitution">_COM_Outptr_ <b>IDWriteNumberSubstitution** numberSubstitution</b></param>
	int GetNumberSubstitution<T0> (uint textPosition, out uint textLength, out T0* numberSubstitution) where T0 : unmanaged, INumberSubstitution;
}

/// <summary>
/// Instance of <b>IDWriteTextAnalysisSource</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct TextAnalysisSource : ITextAnalysisSource {
//unsafe public readonly struct ITextAnalysisSourceObj : ITextAnalysisSource {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextAnalysisSource* GetCurrentPointer () => (TextAnalysisSource*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextAnalysisSourceObj* GetCurrentPointer () => (ITextAnalysisSourceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x688e1a58, 0x5094, 0x47c8, 0xad, 0xc8, 0xfb, 0xce, 0xa6, 0x0a, 0xe9, 0x2b);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
