using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1BitmapBrush1</b> : ID2D1BitmapBrush<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IBitmapBrush1 : IBitmapBrush {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BitmapBrush1::SetInterpolationMode1 (D2D1_INTERPOLATION_MODE interpolationMode)</b><br/>
	/// </summary>
	/// <param name="interpolationMode"><b>D2D1_INTERPOLATION_MODE interpolationMode</b></param>
	void SetInterpolationMode1 (InterpolationMode interpolationMode);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_INTERPOLATION_MODE ID2D1BitmapBrush1::GetInterpolationMode1 ()</b><br/>
	/// </summary>
	InterpolationMode GetInterpolationMode1 ();
}

/// <summary>
/// Instance of <b>ID2D1BitmapBrush1</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct BitmapBrush1 : IBitmapBrush1 {
//unsafe public readonly struct IBitmapBrush1Obj : IBitmapBrush1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapBrush1* GetCurrentPointer () => (BitmapBrush1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapBrush1Obj* GetCurrentPointer () => (IBitmapBrush1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x41343a53, 0xe41a, 0x49a2, 0x91, 0xcd, 0x21, 0x79, 0x3b, 0xbb, 0x62, 0xe5);

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
	public readonly void SetInterpolationMode (BitmapInterpolationMode interpolationMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetInterpolationMode (ptr, interpolationMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetBitmap<T0> (T0* bitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetBitmap (ptr, bitmap);
		return;
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
	public readonly BitmapInterpolationMode GetInterpolationMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInterpolationMode (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetBitmap<T0> (T0** bitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetBitmap (ptr, (void**) bitmap);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetBitmap<T0> (out T0* bitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _bitmap = &bitmap) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetBitmap (ptr, (void**) _bitmap);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetInterpolationMode1 (InterpolationMode interpolationMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetInterpolationMode1 (ptr, interpolationMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly InterpolationMode GetInterpolationMode1 () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInterpolationMode1 (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode, void> SetExtendModeX;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode, void> SetExtendModeY;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BitmapInterpolationMode, void> SetInterpolationMode;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetBitmap;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode> GetExtendModeX;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode> GetExtendModeY;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BitmapInterpolationMode> GetInterpolationMode;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetBitmap;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InterpolationMode, void> SetInterpolationMode1;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InterpolationMode> GetInterpolationMode1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
