using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextAnalysisSink1</b> : IDWriteTextAnalysisSink<br/>
/// DWRITE_1.h
/// </summary>
unsafe public interface ITextAnalysisSink1 : ITextAnalysisSink {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSink1::SetGlyphOrientation (UINT32 textPosition, UINT32 textLength, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, UINT8 adjustedBidiLevel, BOOL isSideways, BOOL isRightToLeft)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="glyphOrientationAngle"><b>DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle</b></param>
	/// <param name="adjustedBidiLevel"><b>UINT8 adjustedBidiLevel</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	int SetGlyphOrientation (uint textPosition, uint textLength, GlyphOrientationAngle glyphOrientationAngle, byte adjustedBidiLevel, bool isSideways, bool isRightToLeft);
}

/// <summary>
/// Instance of <b>IDWriteTextAnalysisSink1</b><br/>
/// DWRITE_1.h
/// </summary>
unsafe public readonly struct TextAnalysisSink1 : ITextAnalysisSink1 {
//unsafe public readonly struct ITextAnalysisSink1Obj : ITextAnalysisSink1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextAnalysisSink1* GetCurrentPointer () => (TextAnalysisSink1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextAnalysisSink1Obj* GetCurrentPointer () => (ITextAnalysisSink1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb0d941a0, 0x85e7, 0x4d8b, 0x9f, 0xd3, 0x5c, 0xed, 0x99, 0x34, 0x48, 0x2a);

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
	public readonly int SetScriptAnalysis (uint textPosition, uint textLength, ScriptAnalysis* scriptAnalysis) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetScriptAnalysis (ptr, textPosition, textLength, scriptAnalysis);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetLineBreakpoints (uint textPosition, uint textLength, LineBreakpoint* lineBreakpoints) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetLineBreakpoints (ptr, textPosition, textLength, lineBreakpoints);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBidiLevel (uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBidiLevel (ptr, textPosition, textLength, explicitLevel, resolvedLevel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetNumberSubstitution<T0> (uint textPosition, uint textLength, T0* numberSubstitution) where T0 : unmanaged, INumberSubstitution {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetNumberSubstitution (ptr, textPosition, textLength, numberSubstitution);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetGlyphOrientation (uint textPosition, uint textLength, GlyphOrientationAngle glyphOrientationAngle, byte adjustedBidiLevel, bool isSideways, bool isRightToLeft) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetGlyphOrientation (ptr, textPosition, textLength, glyphOrientationAngle, adjustedBidiLevel, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, ScriptAnalysis*, int> SetScriptAnalysis;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, LineBreakpoint*, int> SetLineBreakpoints;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, byte, byte, int> SetBidiLevel;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, void*, int> SetNumberSubstitution;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, GlyphOrientationAngle, byte, uint, uint, int> SetGlyphOrientation;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
