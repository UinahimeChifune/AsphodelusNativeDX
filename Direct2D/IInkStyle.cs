using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1InkStyle</b> : ID2D1Resource<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IInkStyle : IResource {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1InkStyle::SetNibTransform (D2D1_MATRIX_3X2_F* transform)</b><br/>
	/// </summary>
	/// <param name="transform">_In_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	void SetNibTransform (Matrix3x2F* transform);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1InkStyle::GetNibTransform (D2D1_MATRIX_3X2_F* transform)</b><br/>
	/// </summary>
	/// <param name="transform">_Out_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	void GetNibTransform (Matrix3x2F* transform);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1InkStyle::GetNibTransform (D2D1_MATRIX_3X2_F* transform)</b><br/>
	/// </summary>
	/// <param name="transform">_Out_ <b>D2D1_MATRIX_3X2_F* transform</b></param>
	void GetNibTransform (out Matrix3x2F transform);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1InkStyle::SetNibShape (D2D1_INK_NIB_SHAPE nibShape)</b><br/>
	/// </summary>
	/// <param name="nibShape"><b>D2D1_INK_NIB_SHAPE nibShape</b></param>
	void SetNibShape (InkNibShape nibShape);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_INK_NIB_SHAPE ID2D1InkStyle::GetNibShape ()</b><br/>
	/// </summary>
	InkNibShape GetNibShape ();
}

/// <summary>
/// Instance of <b>ID2D1InkStyle</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct InkStyle : IInkStyle {
//unsafe public readonly struct IInkStyleObj : IInkStyle {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly InkStyle* GetCurrentPointer () => (InkStyle*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IInkStyleObj* GetCurrentPointer () => (IInkStyleObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xbae8b344, 0x23fc, 0x4071, 0x8c, 0xb5, 0xd0, 0x5d, 0x6f, 0x07, 0x38, 0x48);

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
	public readonly void SetNibTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetNibTransform (ptr, transform);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetNibTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetNibTransform (ptr, transform);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetNibTransform (out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetNibTransform (ptr, _transform);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetNibShape (InkNibShape nibShape) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetNibShape (ptr, nibShape);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly InkNibShape GetNibShape () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNibShape (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, void> SetNibTransform;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, void> GetNibTransform;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InkNibShape, void> SetNibShape;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InkNibShape> GetNibShape;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
