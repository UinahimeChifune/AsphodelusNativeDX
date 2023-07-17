using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SimplifiedGeometrySink</b> : IUnknown<br/>
/// D2D1.h
/// </summary>
unsafe public interface ISimplifiedGeometrySink : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SimplifiedGeometrySink::SetFillMode (D2D1_FILL_MODE fillMode)</b><br/>
	/// </summary>
	/// <param name="fillMode"><b>D2D1_FILL_MODE fillMode</b></param>
	void SetFillMode (FillMode fillMode);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SimplifiedGeometrySink::SetSegmentFlags (D2D1_PATH_SEGMENT vertexFlags)</b><br/>
	/// </summary>
	/// <param name="vertexFlags"><b>D2D1_PATH_SEGMENT vertexFlags</b></param>
	void SetSegmentFlags (PathSegment vertexFlags);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SimplifiedGeometrySink::BeginFigure (D2D1_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)</b><br/>
	/// </summary>
	/// <param name="startPoint"><b>D2D1_POINT_2F startPoint</b></param>
	/// <param name="figureBegin"><b>D2D1_FIGURE_BEGIN figureBegin</b></param>
	void BeginFigure (Vector2F startPoint, FigureBegin figureBegin);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SimplifiedGeometrySink::AddLines (D2D1_POINT_2F* points, UINT32 pointsCount)</b><br/>
	/// </summary>
	/// <param name="points">_In_reads_(pointsCount) <b>D2D1_POINT_2F* points</b></param>
	/// <param name="pointsCount"><b>UINT32 pointsCount</b></param>
	void AddLines (Vector2F* points, uint pointsCount);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SimplifiedGeometrySink::AddBeziers (D2D1_BEZIER_SEGMENT* beziers, UINT32 beziersCount)</b><br/>
	/// </summary>
	/// <param name="beziers">_In_reads_(beziersCount) <b>D2D1_BEZIER_SEGMENT* beziers</b></param>
	/// <param name="beziersCount"><b>UINT32 beziersCount</b></param>
	void AddBeziers (BezierSegment* beziers, uint beziersCount);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SimplifiedGeometrySink::EndFigure (D2D1_FIGURE_END figureEnd)</b><br/>
	/// </summary>
	/// <param name="figureEnd"><b>D2D1_FIGURE_END figureEnd</b></param>
	void EndFigure (FigureEnd figureEnd);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SimplifiedGeometrySink::Close ()</b><br/>
	/// </summary>
	int Close ();
}

/// <summary>
/// Instance of <b>ID2D1SimplifiedGeometrySink</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct SimplifiedGeometrySink : ISimplifiedGeometrySink {
//unsafe public readonly struct ISimplifiedGeometrySinkObj : ISimplifiedGeometrySink {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SimplifiedGeometrySink* GetCurrentPointer () => (SimplifiedGeometrySink*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISimplifiedGeometrySinkObj* GetCurrentPointer () => (ISimplifiedGeometrySinkObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd9069e, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	public readonly void SetFillMode (FillMode fillMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetFillMode (ptr, fillMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetSegmentFlags (PathSegment vertexFlags) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetSegmentFlags (ptr, vertexFlags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void BeginFigure (Vector2F startPoint, FigureBegin figureBegin) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->BeginFigure (ptr, startPoint, figureBegin);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AddLines (Vector2F* points, uint pointsCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddLines (ptr, points, pointsCount);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AddBeziers (BezierSegment* beziers, uint beziersCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddBeziers (ptr, beziers, beziersCount);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void EndFigure (FigureEnd figureEnd) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EndFigure (ptr, figureEnd);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Close () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Close (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, FillMode, void> SetFillMode;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PathSegment, void> SetSegmentFlags;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, FigureBegin, void> BeginFigure;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F*, uint, void> AddLines;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BezierSegment*, uint, void> AddBeziers;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FigureEnd, void> EndFigure;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Close;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
