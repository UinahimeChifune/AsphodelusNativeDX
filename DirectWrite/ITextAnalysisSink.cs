using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextAnalysisSink</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ITextAnalysisSink : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSink::SetScriptAnalysis (UINT32 textPosition, UINT32 textLength, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="scriptAnalysis">_In_ <b>DWRITE_SCRIPT_ANALYSIS* scriptAnalysis</b></param>
	int SetScriptAnalysis (uint textPosition, uint textLength, ScriptAnalysis* scriptAnalysis);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSink::SetLineBreakpoints (UINT32 textPosition, UINT32 textLength, DWRITE_LINE_BREAKPOINT* lineBreakpoints)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="lineBreakpoints">_In_reads_(textLength) <b>DWRITE_LINE_BREAKPOINT* lineBreakpoints</b></param>
	int SetLineBreakpoints (uint textPosition, uint textLength, LineBreakpoint* lineBreakpoints);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSink::SetBidiLevel (UINT32 textPosition, UINT32 textLength, UINT8 explicitLevel, UINT8 resolvedLevel)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="explicitLevel"><b>UINT8 explicitLevel</b></param>
	/// <param name="resolvedLevel"><b>UINT8 resolvedLevel</b></param>
	int SetBidiLevel (uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextAnalysisSink::SetNumberSubstitution (UINT32 textPosition, UINT32 textLength, IDWriteNumberSubstitution* numberSubstitution)</b><br/>
	/// </summary>
	/// <param name="textPosition"><b>UINT32 textPosition</b></param>
	/// <param name="textLength"><b>UINT32 textLength</b></param>
	/// <param name="numberSubstitution">_In_ <b>IDWriteNumberSubstitution* numberSubstitution</b></param>
	int SetNumberSubstitution<T0> (uint textPosition, uint textLength, T0* numberSubstitution) where T0 : unmanaged, INumberSubstitution;
}

/// <summary>
/// Instance of <b>IDWriteTextAnalysisSink</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct TextAnalysisSink : ITextAnalysisSink {
//unsafe public readonly struct ITextAnalysisSinkObj : ITextAnalysisSink {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextAnalysisSink* GetCurrentPointer () => (TextAnalysisSink*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextAnalysisSinkObj* GetCurrentPointer () => (ITextAnalysisSinkObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x5810cd44, 0x0ca0, 0x4701, 0xb3, 0xfa, 0xbe, 0xc5, 0x18, 0x2a, 0xe4, 0xf6);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
