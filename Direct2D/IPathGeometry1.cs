using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1PathGeometry1</b> : ID2D1PathGeometry<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IPathGeometry1 : IPathGeometry {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1PathGeometry1::ComputePointAndSegmentAtLength (FLOAT length, UINT32 startSegment, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, D2D1_POINT_DESCRIPTION* pointDescription)</b><br/>
	/// </summary>
	/// <param name="length"><b>FLOAT length</b></param>
	/// <param name="startSegment"><b>UINT32 startSegment</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="pointDescription">_Out_ <b>D2D1_POINT_DESCRIPTION* pointDescription</b></param>
	int ComputePointAndSegmentAtLength (float length, uint startSegment, Matrix3x2F* worldTransform, float flatteningTolerance, PointDescription* pointDescription);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1PathGeometry1::ComputePointAndSegmentAtLength (FLOAT length, UINT32 startSegment, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, D2D1_POINT_DESCRIPTION* pointDescription)</b><br/>
	/// </summary>
	/// <param name="length"><b>FLOAT length</b></param>
	/// <param name="startSegment"><b>UINT32 startSegment</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="pointDescription">_Out_ <b>D2D1_POINT_DESCRIPTION* pointDescription</b></param>
	int ComputePointAndSegmentAtLength (float length, uint startSegment, Matrix3x2F* worldTransform, float flatteningTolerance, out PointDescription pointDescription);
}

/// <summary>
/// Instance of <b>ID2D1PathGeometry1</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct PathGeometry1 : IPathGeometry1 {
//unsafe public readonly struct IPathGeometry1Obj : IPathGeometry1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PathGeometry1* GetCurrentPointer () => (PathGeometry1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPathGeometry1Obj* GetCurrentPointer () => (IPathGeometry1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x62baa2d2, 0xab54, 0x41b7, 0xb8, 0x72, 0x78, 0x7e, 0x01, 0x06, 0xa4, 0x21);

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
	public readonly int GetBounds (Matrix3x2F* worldTransform, Vector4F* bounds) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBounds (ptr, worldTransform, bounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBounds (Matrix3x2F* worldTransform, out Vector4F bounds) {
		fixed (Vector4F* _bounds = &bounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetBounds (ptr, worldTransform, _bounds);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWidenedBounds<T0> (float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, Vector4F* bounds) where T0 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetWidenedBounds (ptr, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWidenedBounds<T0> (float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, out Vector4F bounds) where T0 : unmanaged, IStrokeStyle {
		fixed (Vector4F* _bounds = &bounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetWidenedBounds (ptr, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, _bounds);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int StrokeContainsPoint<T0> (Vector2F point, float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, uint* contains) where T0 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->StrokeContainsPoint (ptr, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int StrokeContainsPoint<T0> (Vector2F point, float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, out bool contains) where T0 : unmanaged, IStrokeStyle {
		uint _contains;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->StrokeContainsPoint (ptr, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, &_contains);
		contains = _contains != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillContainsPoint (Vector2F point, Matrix3x2F* worldTransform, float flatteningTolerance, uint* contains) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillContainsPoint (ptr, point, worldTransform, flatteningTolerance, contains);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillContainsPoint (Vector2F point, Matrix3x2F* worldTransform, float flatteningTolerance, out bool contains) {
		uint _contains;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillContainsPoint (ptr, point, worldTransform, flatteningTolerance, &_contains);
		contains = _contains != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CompareWithGeometry<T0> (T0* inputGeometry, Matrix3x2F* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation) where T0 : unmanaged, IGeometry {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CompareWithGeometry (ptr, inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CompareWithGeometry<T0> (T0* inputGeometry, Matrix3x2F* inputGeometryTransform, float flatteningTolerance, out GeometryRelation relation) where T0 : unmanaged, IGeometry {
		fixed (GeometryRelation* _relation = &relation) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CompareWithGeometry (ptr, inputGeometry, inputGeometryTransform, flatteningTolerance, _relation);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Simplify<T0> (GeometrySimplificationOption simplificationOption, Matrix3x2F* worldTransform, float flatteningTolerance, T0* geometrySink) where T0 : unmanaged, ISimplifiedGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Simplify (ptr, simplificationOption, worldTransform, flatteningTolerance, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Tessellate<T0> (Matrix3x2F* worldTransform, float flatteningTolerance, T0* tessellationSink) where T0 : unmanaged, ITessellationSink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Tessellate (ptr, worldTransform, flatteningTolerance, tessellationSink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CombineWithGeometry<T0, T1> (T0* inputGeometry, CombineMode combineMode, Matrix3x2F* inputGeometryTransform, float flatteningTolerance, T1* geometrySink) where T0 : unmanaged, IGeometry where T1 : unmanaged, ISimplifiedGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CombineWithGeometry (ptr, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Outline<T0> (Matrix3x2F* worldTransform, float flatteningTolerance, T0* geometrySink) where T0 : unmanaged, ISimplifiedGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Outline (ptr, worldTransform, flatteningTolerance, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputeArea (Matrix3x2F* worldTransform, float flatteningTolerance, float* area) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ComputeArea (ptr, worldTransform, flatteningTolerance, area);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputeArea (Matrix3x2F* worldTransform, float flatteningTolerance, out float area) {
		fixed (float* _area = &area) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->ComputeArea (ptr, worldTransform, flatteningTolerance, _area);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputeLength (Matrix3x2F* worldTransform, float flatteningTolerance, float* length) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ComputeLength (ptr, worldTransform, flatteningTolerance, length);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputeLength (Matrix3x2F* worldTransform, float flatteningTolerance, out float length) {
		fixed (float* _length = &length) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->ComputeLength (ptr, worldTransform, flatteningTolerance, _length);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputePointAtLength (float length, Matrix3x2F* worldTransform, float flatteningTolerance, Vector2F* point, Vector2F* unitTangentVector) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ComputePointAtLength (ptr, length, worldTransform, flatteningTolerance, point, unitTangentVector);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputePointAtLength (float length, Matrix3x2F* worldTransform, float flatteningTolerance, out Vector2F point, out Vector2F unitTangentVector) {
		fixed (Vector2F* _point = &point) {
			fixed (Vector2F* _unitTangentVector = &unitTangentVector) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->ComputePointAtLength (ptr, length, worldTransform, flatteningTolerance, _point, _unitTangentVector);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Widen<T0, T1> (float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, T1* geometrySink) where T0 : unmanaged, IStrokeStyle where T1 : unmanaged, ISimplifiedGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Widen (ptr, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Open<T0> (T0** geometrySink) where T0 : unmanaged, IGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Open (ptr, (void**) geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Open<T0> (out T0* geometrySink) where T0 : unmanaged, IGeometrySink {
		fixed (T0** _geometrySink = &geometrySink) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Open (ptr, (void**) _geometrySink);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Stream<T0> (T0* geometrySink) where T0 : unmanaged, IGeometrySink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Stream (ptr, geometrySink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSegmentCount (uint* count) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSegmentCount (ptr, count);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSegmentCount (out uint count) {
		fixed (uint* _count = &count) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSegmentCount (ptr, _count);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFigureCount (uint* count) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFigureCount (ptr, count);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFigureCount (out uint count) {
		fixed (uint* _count = &count) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFigureCount (ptr, _count);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputePointAndSegmentAtLength (float length, uint startSegment, Matrix3x2F* worldTransform, float flatteningTolerance, PointDescription* pointDescription) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ComputePointAndSegmentAtLength (ptr, length, startSegment, worldTransform, flatteningTolerance, pointDescription);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ComputePointAndSegmentAtLength (float length, uint startSegment, Matrix3x2F* worldTransform, float flatteningTolerance, out PointDescription pointDescription) {
		fixed (PointDescription* _pointDescription = &pointDescription) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->ComputePointAndSegmentAtLength (ptr, length, startSegment, worldTransform, flatteningTolerance, _pointDescription);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, Vector4F*, int> GetBounds;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, void*, Matrix3x2F*, float, Vector4F*, int> GetWidenedBounds;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, float, void*, Matrix3x2F*, float, uint*, int> StrokeContainsPoint;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, Matrix3x2F*, float, uint*, int> FillContainsPoint;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Matrix3x2F*, float, GeometryRelation*, int> CompareWithGeometry;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GeometrySimplificationOption, Matrix3x2F*, float, void*, int> Simplify;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, float, void*, int> Tessellate;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, CombineMode, Matrix3x2F*, float, void*, int> CombineWithGeometry;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, float, void*, int> Outline;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, float, float*, int> ComputeArea;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, float, float*, int> ComputeLength;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, Matrix3x2F*, float, Vector2F*, Vector2F*, int> ComputePointAtLength;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, void*, Matrix3x2F*, float, void*, int> Widen;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> Open;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> Stream;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetSegmentCount;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetFigureCount;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, uint, Matrix3x2F*, float, PointDescription*, int> ComputePointAndSegmentAtLength;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
