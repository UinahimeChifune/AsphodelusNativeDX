using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Ink</b> : ID2D1Resource<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IInk : IResource {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Ink::SetStartPoint (D2D1_INK_POINT* startPoint)</b><br/>
	/// </summary>
	/// <param name="startPoint">_In_ <b>D2D1_INK_POINT* startPoint</b></param>
	void SetStartPoint (InkPoint* startPoint);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_INK_POINT ID2D1Ink::GetStartPoint ()</b><br/>
	/// </summary>
	InkPoint GetStartPoint ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::AddSegments (D2D1_INK_BEZIER_SEGMENT* segments, UINT32 segmentsCount)</b><br/>
	/// </summary>
	/// <param name="segments">_In_reads_(segmentsCount) <b>D2D1_INK_BEZIER_SEGMENT* segments</b></param>
	/// <param name="segmentsCount"><b>UINT32 segmentsCount</b></param>
	int AddSegments (InkBezierSegment* segments, uint segmentsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::RemoveSegmentsAtEnd (UINT32 segmentsCount)</b><br/>
	/// </summary>
	/// <param name="segmentsCount"><b>UINT32 segmentsCount</b></param>
	int RemoveSegmentsAtEnd (uint segmentsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::SetSegments (UINT32 startSegment, D2D1_INK_BEZIER_SEGMENT* segments, UINT32 segmentsCount)</b><br/>
	/// </summary>
	/// <param name="startSegment"><b>UINT32 startSegment</b></param>
	/// <param name="segments">_In_reads_(segmentsCount) <b>D2D1_INK_BEZIER_SEGMENT* segments</b></param>
	/// <param name="segmentsCount"><b>UINT32 segmentsCount</b></param>
	int SetSegments (uint startSegment, InkBezierSegment* segments, uint segmentsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::SetSegmentAtEnd (D2D1_INK_BEZIER_SEGMENT* segment)</b><br/>
	/// </summary>
	/// <param name="segment">_In_ <b>D2D1_INK_BEZIER_SEGMENT* segment</b></param>
	int SetSegmentAtEnd (InkBezierSegment* segment);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1Ink::GetSegmentCount ()</b><br/>
	/// </summary>
	uint GetSegmentCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::GetSegments (UINT32 startSegment, D2D1_INK_BEZIER_SEGMENT* segments, UINT32 segmentsCount)</b><br/>
	/// </summary>
	/// <param name="startSegment"><b>UINT32 startSegment</b></param>
	/// <param name="segments">_Out_writes_(segmentsCount) <b>D2D1_INK_BEZIER_SEGMENT* segments</b></param>
	/// <param name="segmentsCount"><b>UINT32 segmentsCount</b></param>
	int GetSegments (uint startSegment, InkBezierSegment* segments, uint segmentsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::StreamAsGeometry (ID2D1InkStyle* inkStyle, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)</b><br/>
	/// </summary>
	/// <param name="inkStyle">_In_opt_ <b>ID2D1InkStyle* inkStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="geometrySink">_In_ <b>ID2D1SimplifiedGeometrySink* geometrySink</b></param>
	int StreamAsGeometry<T0, T1> (T0* inkStyle, Matrix3x2F* worldTransform, float flatteningTolerance, T1* geometrySink) where T0 : unmanaged, IInkStyle where T1 : unmanaged, ISimplifiedGeometrySink;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::GetBounds (ID2D1InkStyle* inkStyle, D2D1_MATRIX_3X2_F* worldTransform, D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="inkStyle">_In_opt_ <b>ID2D1InkStyle* inkStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetBounds<T0> (T0* inkStyle, Matrix3x2F* worldTransform, Vector4F* bounds) where T0 : unmanaged, IInkStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Ink::GetBounds (ID2D1InkStyle* inkStyle, D2D1_MATRIX_3X2_F* worldTransform, D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="inkStyle">_In_opt_ <b>ID2D1InkStyle* inkStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetBounds<T0> (T0* inkStyle, Matrix3x2F* worldTransform, out Vector4F bounds) where T0 : unmanaged, IInkStyle;
}

/// <summary>
/// Instance of <b>ID2D1Ink</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct Ink : IInk {
//unsafe public readonly struct IInkObj : IInk {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Ink* GetCurrentPointer () => (Ink*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IInkObj* GetCurrentPointer () => (IInkObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb499923b, 0x7029, 0x478f, 0xa8, 0xb3, 0x43, 0x2c, 0x7c, 0x5f, 0x53, 0x12);

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
	public readonly void GetFactory<T0> (T0** factory) where T0 : unmanaged, IFactory {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) factory);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFactory<T0> (out T0* factory) where T0 : unmanaged, IFactory {
		fixed (T0** _factory = &factory) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) _factory);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetStartPoint (InkPoint* startPoint) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetStartPoint (ptr, startPoint);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly InkPoint GetStartPoint () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStartPoint (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddSegments (InkBezierSegment* segments, uint segmentsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddSegments (ptr, segments, segmentsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveSegmentsAtEnd (uint segmentsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveSegmentsAtEnd (ptr, segmentsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSegments (uint startSegment, InkBezierSegment* segments, uint segmentsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSegments (ptr, startSegment, segments, segmentsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSegmentAtEnd (InkBezierSegment* segment) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSegmentAtEnd (ptr, segment);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetSegmentCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSegmentCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSegments (uint startSegment, InkBezierSegment* segments, uint segmentsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSegments (ptr, startSegment, segments, segmentsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int StreamAsGeometry<T0, T1> (T0* inkStyle, Matrix3x2F* worldTransform, float flatteningTolerance, T1* geometrySink) where T0 : unmanaged, IInkStyle where T1 : unmanaged, ISimplifiedGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->StreamAsGeometry (ptr, inkStyle, worldTransform, flatteningTolerance, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBounds<T0> (T0* inkStyle, Matrix3x2F* worldTransform, Vector4F* bounds) where T0 : unmanaged, IInkStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBounds (ptr, inkStyle, worldTransform, bounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBounds<T0> (T0* inkStyle, Matrix3x2F* worldTransform, out Vector4F bounds) where T0 : unmanaged, IInkStyle {
		fixed (Vector4F* _bounds = &bounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetBounds (ptr, inkStyle, worldTransform, _bounds);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFactory;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InkPoint*, void> SetStartPoint;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InkPoint> GetStartPoint;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InkBezierSegment*, uint, int> AddSegments;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemoveSegmentsAtEnd;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, InkBezierSegment*, uint, int> SetSegments;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InkBezierSegment*, int> SetSegmentAtEnd;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetSegmentCount;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, InkBezierSegment*, uint, int> GetSegments;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Matrix3x2F*, float, void*, int> StreamAsGeometry;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Matrix3x2F*, Vector4F*, int> GetBounds;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
