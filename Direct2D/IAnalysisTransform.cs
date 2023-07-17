using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1AnalysisTransform</b> : IUnknown<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IAnalysisTransform : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1AnalysisTransform::ProcessAnalysisResults (BYTE* analysisData, UINT32 analysisDataCount)</b><br/>
	/// </summary>
	/// <param name="analysisData">_In_reads_(analysisDataCount) <b>BYTE* analysisData</b></param>
	/// <param name="analysisDataCount"><b>UINT32 analysisDataCount</b></param>
	int ProcessAnalysisResults (byte* analysisData, uint analysisDataCount);
}

/// <summary>
/// Instance of <b>ID2D1AnalysisTransform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct AnalysisTransform : IAnalysisTransform {
//unsafe public readonly struct IAnalysisTransformObj : IAnalysisTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly AnalysisTransform* GetCurrentPointer () => (AnalysisTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IAnalysisTransformObj* GetCurrentPointer () => (IAnalysisTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x0359dc30, 0x95e6, 0x4568, 0x90, 0x55, 0x27, 0x72, 0x0d, 0x13, 0x0e, 0x93);

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
	public readonly int ProcessAnalysisResults (byte* analysisData, uint analysisDataCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ProcessAnalysisResults (ptr, analysisData, analysisDataCount);
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
		public readonly delegate* unmanaged[Stdcall]<void*, byte*, uint, int> ProcessAnalysisResults;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
