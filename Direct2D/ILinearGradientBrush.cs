using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1LinearGradientBrush</b> : ID2D1Brush<br/>
/// D2D1.h
/// </summary>
unsafe public interface ILinearGradientBrush : IBrush {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1LinearGradientBrush::SetStartPoint (D2D1_POINT_2F startPoint)</b><br/>
	/// </summary>
	/// <param name="startPoint"><b>D2D1_POINT_2F startPoint</b></param>
	void SetStartPoint (Vector2F startPoint);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1LinearGradientBrush::SetEndPoint (D2D1_POINT_2F endPoint)</b><br/>
	/// </summary>
	/// <param name="endPoint"><b>D2D1_POINT_2F endPoint</b></param>
	void SetEndPoint (Vector2F endPoint);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_POINT_2F ID2D1LinearGradientBrush::GetStartPoint ()</b><br/>
	/// </summary>
	Vector2F GetStartPoint ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_POINT_2F ID2D1LinearGradientBrush::GetEndPoint ()</b><br/>
	/// </summary>
	Vector2F GetEndPoint ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1LinearGradientBrush::GetGradientStopCollection (ID2D1GradientStopCollection** gradientStopCollection)</b><br/>
	/// </summary>
	/// <param name="gradientStopCollection">_Outptr_ <b>ID2D1GradientStopCollection** gradientStopCollection</b></param>
	void GetGradientStopCollection<T0> (T0** gradientStopCollection) where T0 : unmanaged, IGradientStopCollection;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1LinearGradientBrush::GetGradientStopCollection (ID2D1GradientStopCollection** gradientStopCollection)</b><br/>
	/// </summary>
	/// <param name="gradientStopCollection">_Outptr_ <b>ID2D1GradientStopCollection** gradientStopCollection</b></param>
	void GetGradientStopCollection<T0> (out T0* gradientStopCollection) where T0 : unmanaged, IGradientStopCollection;
}

/// <summary>
/// Instance of <b>ID2D1LinearGradientBrush</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct LinearGradientBrush : ILinearGradientBrush {
//unsafe public readonly struct ILinearGradientBrushObj : ILinearGradientBrush {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly LinearGradientBrush* GetCurrentPointer () => (LinearGradientBrush*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ILinearGradientBrushObj* GetCurrentPointer () => (ILinearGradientBrushObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd906ab, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	public readonly void SetStartPoint (Vector2F startPoint) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetStartPoint (ptr, startPoint);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetEndPoint (Vector2F endPoint) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetEndPoint (ptr, endPoint);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2F GetStartPoint () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStartPoint (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2F GetEndPoint () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEndPoint (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, void> SetStartPoint;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, void> SetEndPoint;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F> GetStartPoint;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F> GetEndPoint;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetGradientStopCollection;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
