using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1GeometrySink</b> : ID2D1SimplifiedGeometrySink<br/>
/// D2D1.h
/// </summary>
unsafe public interface IGeometrySink : ISimplifiedGeometrySink {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1GeometrySink::AddLine (D2D1_POINT_2F point)</b><br/>
	/// </summary>
	/// <param name="point"><b>D2D1_POINT_2F point</b></param>
	void AddLine (Vector2F point);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1GeometrySink::AddBezier (D2D1_BEZIER_SEGMENT* bezier)</b><br/>
	/// </summary>
	/// <param name="bezier">_In_ <b>D2D1_BEZIER_SEGMENT* bezier</b></param>
	void AddBezier (BezierSegment* bezier);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1GeometrySink::AddQuadraticBezier (D2D1_QUADRATIC_BEZIER_SEGMENT* bezier)</b><br/>
	/// </summary>
	/// <param name="bezier">_In_ <b>D2D1_QUADRATIC_BEZIER_SEGMENT* bezier</b></param>
	void AddQuadraticBezier (QuadraticBezierSegment* bezier);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1GeometrySink::AddQuadraticBeziers (D2D1_QUADRATIC_BEZIER_SEGMENT* beziers, UINT32 beziersCount)</b><br/>
	/// </summary>
	/// <param name="beziers">_In_reads_(beziersCount) <b>D2D1_QUADRATIC_BEZIER_SEGMENT* beziers</b></param>
	/// <param name="beziersCount"><b>UINT32 beziersCount</b></param>
	void AddQuadraticBeziers (QuadraticBezierSegment* beziers, uint beziersCount);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1GeometrySink::AddArc (D2D1_ARC_SEGMENT* arc)</b><br/>
	/// </summary>
	/// <param name="arc">_In_ <b>D2D1_ARC_SEGMENT* arc</b></param>
	void AddArc (ArcSegment* arc);
}

/// <summary>
/// Instance of <b>ID2D1GeometrySink</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct GeometrySink : IGeometrySink {
//unsafe public readonly struct IGeometrySinkObj : IGeometrySink {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GeometrySink* GetCurrentPointer () => (GeometrySink*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGeometrySinkObj* GetCurrentPointer () => (IGeometrySinkObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd9069f, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AddLine (Vector2F point) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddLine (ptr, point);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AddBezier (BezierSegment* bezier) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddBezier (ptr, bezier);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AddQuadraticBezier (QuadraticBezierSegment* bezier) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddQuadraticBezier (ptr, bezier);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AddQuadraticBeziers (QuadraticBezierSegment* beziers, uint beziersCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddQuadraticBeziers (ptr, beziers, beziersCount);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AddArc (ArcSegment* arc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddArc (ptr, arc);
		return;
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
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, void> AddLine;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BezierSegment*, void> AddBezier;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, QuadraticBezierSegment*, void> AddQuadraticBezier;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, QuadraticBezierSegment*, uint, void> AddQuadraticBeziers;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ArcSegment*, void> AddArc;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
