using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ImageBrush</b> : ID2D1Brush<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IImageBrush : IBrush {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::SetImage (ID2D1Image* image)</b><br/>
	/// </summary>
	/// <param name="image">_In_opt_ <b>ID2D1Image* image</b></param>
	void SetImage<T0> (T0* image) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::SetExtendModeX (D2D1_EXTEND_MODE extendModeX)</b><br/>
	/// </summary>
	/// <param name="extendModeX"><b>D2D1_EXTEND_MODE extendModeX</b></param>
	void SetExtendModeX (ExtendMode extendModeX);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::SetExtendModeY (D2D1_EXTEND_MODE extendModeY)</b><br/>
	/// </summary>
	/// <param name="extendModeY"><b>D2D1_EXTEND_MODE extendModeY</b></param>
	void SetExtendModeY (ExtendMode extendModeY);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::SetInterpolationMode (D2D1_INTERPOLATION_MODE interpolationMode)</b><br/>
	/// </summary>
	/// <param name="interpolationMode"><b>D2D1_INTERPOLATION_MODE interpolationMode</b></param>
	void SetInterpolationMode (InterpolationMode interpolationMode);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::SetSourceRectangle (D2D1_RECT_F* sourceRectangle)</b><br/>
	/// </summary>
	/// <param name="sourceRectangle">_In_ <b>D2D1_RECT_F* sourceRectangle</b></param>
	void SetSourceRectangle (Vector4F* sourceRectangle);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::GetImage (ID2D1Image** image)</b><br/>
	/// </summary>
	/// <param name="image">_Outptr_result_maybenull_ <b>ID2D1Image** image</b></param>
	void GetImage<T0> (T0** image) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::GetImage (ID2D1Image** image)</b><br/>
	/// </summary>
	/// <param name="image">_Outptr_result_maybenull_ <b>ID2D1Image** image</b></param>
	void GetImage<T0> (out T0* image) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD_ <b>D2D1_EXTEND_MODE ID2D1ImageBrush::GetExtendModeX ()</b><br/>
	/// </summary>
	ExtendMode GetExtendModeX ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_EXTEND_MODE ID2D1ImageBrush::GetExtendModeY ()</b><br/>
	/// </summary>
	ExtendMode GetExtendModeY ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_INTERPOLATION_MODE ID2D1ImageBrush::GetInterpolationMode ()</b><br/>
	/// </summary>
	InterpolationMode GetInterpolationMode ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::GetSourceRectangle (D2D1_RECT_F* sourceRectangle)</b><br/>
	/// </summary>
	/// <param name="sourceRectangle">_Out_ <b>D2D1_RECT_F* sourceRectangle</b></param>
	void GetSourceRectangle (Vector4F* sourceRectangle);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageBrush::GetSourceRectangle (D2D1_RECT_F* sourceRectangle)</b><br/>
	/// </summary>
	/// <param name="sourceRectangle">_Out_ <b>D2D1_RECT_F* sourceRectangle</b></param>
	void GetSourceRectangle (out Vector4F sourceRectangle);
}

/// <summary>
/// Instance of <b>ID2D1ImageBrush</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct ImageBrush : IImageBrush {
//unsafe public readonly struct IImageBrushObj : IImageBrush {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ImageBrush* GetCurrentPointer () => (ImageBrush*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IImageBrushObj* GetCurrentPointer () => (IImageBrushObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xfe9e984d, 0x3f95, 0x407c, 0xb5, 0xdb, 0xcb, 0x94, 0xd4, 0xe8, 0xf8, 0x7c);

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
	public readonly void SetImage<T0> (T0* image) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetImage (ptr, image);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetExtendModeX (ExtendMode extendModeX) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetExtendModeX (ptr, extendModeX);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetExtendModeY (ExtendMode extendModeY) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetExtendModeY (ptr, extendModeY);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetInterpolationMode (InterpolationMode interpolationMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetInterpolationMode (ptr, interpolationMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetSourceRectangle (Vector4F* sourceRectangle) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetSourceRectangle (ptr, sourceRectangle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetImage<T0> (T0** image) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetImage (ptr, (void**) image);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetImage<T0> (out T0* image) where T0 : unmanaged, IImage {
		fixed (T0** _image = &image) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetImage (ptr, (void**) _image);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ExtendMode GetExtendModeX () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExtendModeX (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ExtendMode GetExtendModeY () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExtendModeY (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly InterpolationMode GetInterpolationMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInterpolationMode (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetSourceRectangle (Vector4F* sourceRectangle) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetSourceRectangle (ptr, sourceRectangle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetSourceRectangle (out Vector4F sourceRectangle) {
		fixed (Vector4F* _sourceRectangle = &sourceRectangle) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetSourceRectangle (ptr, _sourceRectangle);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetImage;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode, void> SetExtendModeX;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode, void> SetExtendModeY;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InterpolationMode, void> SetInterpolationMode;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void> SetSourceRectangle;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetImage;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode> GetExtendModeX;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode> GetExtendModeY;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InterpolationMode> GetInterpolationMode;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void> GetSourceRectangle;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
