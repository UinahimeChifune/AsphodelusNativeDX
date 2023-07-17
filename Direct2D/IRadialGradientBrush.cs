using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1RadialGradientBrush</b> : ID2D1Brush<br/>
/// D2D1.h
/// </summary>
unsafe public interface IRadialGradientBrush : IBrush {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RadialGradientBrush::SetCenter (D2D1_POINT_2F center)</b><br/>
	/// </summary>
	/// <param name="center"><b>D2D1_POINT_2F center</b></param>
	void SetCenter (Vector2F center);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RadialGradientBrush::SetGradientOriginOffset (D2D1_POINT_2F gradientOriginOffset)</b><br/>
	/// </summary>
	/// <param name="gradientOriginOffset"><b>D2D1_POINT_2F gradientOriginOffset</b></param>
	void SetGradientOriginOffset (Vector2F gradientOriginOffset);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RadialGradientBrush::SetRadiusX (FLOAT radiusX)</b><br/>
	/// </summary>
	/// <param name="radiusX"><b>FLOAT radiusX</b></param>
	void SetRadiusX (float radiusX);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RadialGradientBrush::SetRadiusY (FLOAT radiusY)</b><br/>
	/// </summary>
	/// <param name="radiusY"><b>FLOAT radiusY</b></param>
	void SetRadiusY (float radiusY);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_POINT_2F ID2D1RadialGradientBrush::GetCenter ()</b><br/>
	/// </summary>
	Vector2F GetCenter ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_POINT_2F ID2D1RadialGradientBrush::GetGradientOriginOffset ()</b><br/>
	/// </summary>
	Vector2F GetGradientOriginOffset ();
	/// <summary>
	/// STDMETHOD_ <b>FLOAT ID2D1RadialGradientBrush::GetRadiusX ()</b><br/>
	/// </summary>
	float GetRadiusX ();
	/// <summary>
	/// STDMETHOD_ <b>FLOAT ID2D1RadialGradientBrush::GetRadiusY ()</b><br/>
	/// </summary>
	float GetRadiusY ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RadialGradientBrush::GetGradientStopCollection (ID2D1GradientStopCollection** gradientStopCollection)</b><br/>
	/// </summary>
	/// <param name="gradientStopCollection">_Outptr_ <b>ID2D1GradientStopCollection** gradientStopCollection</b></param>
	void GetGradientStopCollection<T0> (T0** gradientStopCollection) where T0 : unmanaged, IGradientStopCollection;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RadialGradientBrush::GetGradientStopCollection (ID2D1GradientStopCollection** gradientStopCollection)</b><br/>
	/// </summary>
	/// <param name="gradientStopCollection">_Outptr_ <b>ID2D1GradientStopCollection** gradientStopCollection</b></param>
	void GetGradientStopCollection<T0> (out T0* gradientStopCollection) where T0 : unmanaged, IGradientStopCollection;
}

/// <summary>
/// Instance of <b>ID2D1RadialGradientBrush</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct RadialGradientBrush : IRadialGradientBrush {
//unsafe public readonly struct IRadialGradientBrushObj : IRadialGradientBrush {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly RadialGradientBrush* GetCurrentPointer () => (RadialGradientBrush*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IRadialGradientBrushObj* GetCurrentPointer () => (IRadialGradientBrushObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd906ac, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	public readonly void SetOpacity (float opacity) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetOpacity (ptr, opacity);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetTransform (ptr, transform);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetOpacity () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetOpacity (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetTransform (ptr, transform);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTransform (out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetTransform (ptr, _transform);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetCenter (Vector2F center) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetCenter (ptr, center);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGradientOriginOffset (Vector2F gradientOriginOffset) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGradientOriginOffset (ptr, gradientOriginOffset);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetRadiusX (float radiusX) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetRadiusX (ptr, radiusX);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetRadiusY (float radiusY) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetRadiusY (ptr, radiusY);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2F GetCenter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCenter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2F GetGradientOriginOffset () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGradientOriginOffset (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetRadiusX () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRadiusX (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetRadiusY () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRadiusY (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetGradientStopCollection<T0> (T0** gradientStopCollection) where T0 : unmanaged, IGradientStopCollection {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetGradientStopCollection (ptr, (void**) gradientStopCollection);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetGradientStopCollection<T0> (out T0* gradientStopCollection) where T0 : unmanaged, IGradientStopCollection {
		fixed (T0** _gradientStopCollection = &gradientStopCollection) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetGradientStopCollection (ptr, (void**) _gradientStopCollection);
			return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, float, void> SetOpacity;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, void> SetTransform;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetOpacity;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, void> GetTransform;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, void> SetCenter;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, void> SetGradientOriginOffset;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, void> SetRadiusX;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float, void> SetRadiusY;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F> GetCenter;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F> GetGradientOriginOffset;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetRadiusX;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetRadiusY;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetGradientStopCollection;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
