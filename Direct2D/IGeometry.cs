using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Geometry</b> : ID2D1Resource<br/>
/// D2D1.h
/// </summary>
unsafe public interface IGeometry : IResource {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::GetBounds (D2D1_MATRIX_3X2_F* worldTransform, D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetBounds (Matrix3x2F* worldTransform, Vector4F* bounds);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::GetBounds (D2D1_MATRIX_3X2_F* worldTransform, D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetBounds (Matrix3x2F* worldTransform, out Vector4F bounds);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::GetWidenedBounds (FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetWidenedBounds<T0> (float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, Vector4F* bounds) where T0 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::GetWidenedBounds (FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetWidenedBounds<T0> (float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, out Vector4F bounds) where T0 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::StrokeContainsPoint (D2D1_POINT_2F point, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, BOOL* contains)</b><br/>
	/// </summary>
	/// <param name="point"><b>D2D1_POINT_2F point</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="contains">_Out_ <b>BOOL* contains</b></param>
	int StrokeContainsPoint<T0> (Vector2F point, float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, uint* contains) where T0 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::StrokeContainsPoint (D2D1_POINT_2F point, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, BOOL* contains)</b><br/>
	/// </summary>
	/// <param name="point"><b>D2D1_POINT_2F point</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="contains">_Out_ <b>BOOL* contains</b></param>
	int StrokeContainsPoint<T0> (Vector2F point, float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, out bool contains) where T0 : unmanaged, IStrokeStyle;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::FillContainsPoint (D2D1_POINT_2F point, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, BOOL* contains)</b><br/>
	/// </summary>
	/// <param name="point"><b>D2D1_POINT_2F point</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="contains">_Out_ <b>BOOL* contains</b></param>
	int FillContainsPoint (Vector2F point, Matrix3x2F* worldTransform, float flatteningTolerance, uint* contains);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::FillContainsPoint (D2D1_POINT_2F point, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, BOOL* contains)</b><br/>
	/// </summary>
	/// <param name="point"><b>D2D1_POINT_2F point</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="contains">_Out_ <b>BOOL* contains</b></param>
	int FillContainsPoint (Vector2F point, Matrix3x2F* worldTransform, float flatteningTolerance, out bool contains);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::CompareWithGeometry (ID2D1Geometry* inputGeometry, D2D1_MATRIX_3X2_F* inputGeometryTransform, FLOAT flatteningTolerance, D2D1_GEOMETRY_RELATION* relation)</b><br/>
	/// </summary>
	/// <param name="inputGeometry">_In_ <b>ID2D1Geometry* inputGeometry</b></param>
	/// <param name="inputGeometryTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* inputGeometryTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="relation">_Out_ <b>D2D1_GEOMETRY_RELATION* relation</b></param>
	int CompareWithGeometry<T0> (T0* inputGeometry, Matrix3x2F* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation) where T0 : unmanaged, IGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::CompareWithGeometry (ID2D1Geometry* inputGeometry, D2D1_MATRIX_3X2_F* inputGeometryTransform, FLOAT flatteningTolerance, D2D1_GEOMETRY_RELATION* relation)</b><br/>
	/// </summary>
	/// <param name="inputGeometry">_In_ <b>ID2D1Geometry* inputGeometry</b></param>
	/// <param name="inputGeometryTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* inputGeometryTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="relation">_Out_ <b>D2D1_GEOMETRY_RELATION* relation</b></param>
	int CompareWithGeometry<T0> (T0* inputGeometry, Matrix3x2F* inputGeometryTransform, float flatteningTolerance, out GeometryRelation relation) where T0 : unmanaged, IGeometry;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::Simplify (D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)</b><br/>
	/// </summary>
	/// <param name="simplificationOption"><b>D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="geometrySink">_In_ <b>ID2D1SimplifiedGeometrySink* geometrySink</b></param>
	int Simplify<T0> (GeometrySimplificationOption simplificationOption, Matrix3x2F* worldTransform, float flatteningTolerance, T0* geometrySink) where T0 : unmanaged, ISimplifiedGeometrySink;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::Tessellate (D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, ID2D1TessellationSink* tessellationSink)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="tessellationSink">_In_ <b>ID2D1TessellationSink* tessellationSink</b></param>
	int Tessellate<T0> (Matrix3x2F* worldTransform, float flatteningTolerance, T0* tessellationSink) where T0 : unmanaged, ITessellationSink;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::CombineWithGeometry (ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, D2D1_MATRIX_3X2_F* inputGeometryTransform, FLOAT flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)</b><br/>
	/// </summary>
	/// <param name="inputGeometry">_In_ <b>ID2D1Geometry* inputGeometry</b></param>
	/// <param name="combineMode"><b>D2D1_COMBINE_MODE combineMode</b></param>
	/// <param name="inputGeometryTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* inputGeometryTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="geometrySink">_In_ <b>ID2D1SimplifiedGeometrySink* geometrySink</b></param>
	int CombineWithGeometry<T0, T1> (T0* inputGeometry, CombineMode combineMode, Matrix3x2F* inputGeometryTransform, float flatteningTolerance, T1* geometrySink) where T0 : unmanaged, IGeometry where T1 : unmanaged, ISimplifiedGeometrySink;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::Outline (D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="geometrySink">_In_ <b>ID2D1SimplifiedGeometrySink* geometrySink</b></param>
	int Outline<T0> (Matrix3x2F* worldTransform, float flatteningTolerance, T0* geometrySink) where T0 : unmanaged, ISimplifiedGeometrySink;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::ComputeArea (D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, FLOAT* area)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="area">_Out_ <b>FLOAT* area</b></param>
	int ComputeArea (Matrix3x2F* worldTransform, float flatteningTolerance, float* area);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::ComputeArea (D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, FLOAT* area)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="area">_Out_ <b>FLOAT* area</b></param>
	int ComputeArea (Matrix3x2F* worldTransform, float flatteningTolerance, out float area);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::ComputeLength (D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, FLOAT* length)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="length">_Out_ <b>FLOAT* length</b></param>
	int ComputeLength (Matrix3x2F* worldTransform, float flatteningTolerance, float* length);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::ComputeLength (D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, FLOAT* length)</b><br/>
	/// </summary>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="length">_Out_ <b>FLOAT* length</b></param>
	int ComputeLength (Matrix3x2F* worldTransform, float flatteningTolerance, out float length);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::ComputePointAtLength (FLOAT length, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, D2D1_POINT_2F* point, D2D1_POINT_2F* unitTangentVector)</b><br/>
	/// </summary>
	/// <param name="length"><b>FLOAT length</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="point">_Out_opt_ <b>D2D1_POINT_2F* point</b></param>
	/// <param name="unitTangentVector">_Out_opt_ <b>D2D1_POINT_2F* unitTangentVector</b></param>
	int ComputePointAtLength (float length, Matrix3x2F* worldTransform, float flatteningTolerance, Vector2F* point, Vector2F* unitTangentVector);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::ComputePointAtLength (FLOAT length, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, D2D1_POINT_2F* point, D2D1_POINT_2F* unitTangentVector)</b><br/>
	/// </summary>
	/// <param name="length"><b>FLOAT length</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="point">_Out_opt_ <b>D2D1_POINT_2F* point</b></param>
	/// <param name="unitTangentVector">_Out_opt_ <b>D2D1_POINT_2F* unitTangentVector</b></param>
	int ComputePointAtLength (float length, Matrix3x2F* worldTransform, float flatteningTolerance, out Vector2F point, out Vector2F unitTangentVector);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Geometry::Widen (FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle, D2D1_MATRIX_3X2_F* worldTransform, FLOAT flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)</b><br/>
	/// </summary>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="strokeStyle">_In_opt_ <b>ID2D1StrokeStyle* strokeStyle</b></param>
	/// <param name="worldTransform">_In_opt_ <b>D2D1_MATRIX_3X2_F* worldTransform</b></param>
	/// <param name="flatteningTolerance"><b>FLOAT flatteningTolerance</b></param>
	/// <param name="geometrySink">_In_ <b>ID2D1SimplifiedGeometrySink* geometrySink</b></param>
	int Widen<T0, T1> (float strokeWidth, T0* strokeStyle, Matrix3x2F* worldTransform, float flatteningTolerance, T1* geometrySink) where T0 : unmanaged, IStrokeStyle where T1 : unmanaged, ISimplifiedGeometrySink;
}

/// <summary>
/// Instance of <b>ID2D1Geometry</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct Geometry : IGeometry {
//unsafe public readonly struct IGeometryObj : IGeometry {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Geometry* GetCurrentPointer () => (Geometry*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGeometryObj* GetCurrentPointer () => (IGeometryObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd906a1, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
