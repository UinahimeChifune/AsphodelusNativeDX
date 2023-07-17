using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWritePixelSnapping</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IPixelSnapping : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWritePixelSnapping::IsPixelSnappingDisabled (void* clientDrawingContext, BOOL* isDisabled)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="isDisabled">_Out_ <b>BOOL* isDisabled</b></param>
	int IsPixelSnappingDisabled (void* clientDrawingContext, uint* isDisabled);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWritePixelSnapping::IsPixelSnappingDisabled (void* clientDrawingContext, BOOL* isDisabled)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="isDisabled">_Out_ <b>BOOL* isDisabled</b></param>
	int IsPixelSnappingDisabled (void* clientDrawingContext, out bool isDisabled);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWritePixelSnapping::GetCurrentTransform (void* clientDrawingContext, DWRITE_MATRIX* transform)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="transform">_Out_ <b>DWRITE_MATRIX* transform</b></param>
	int GetCurrentTransform (void* clientDrawingContext, Matrix3x2F* transform);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWritePixelSnapping::GetCurrentTransform (void* clientDrawingContext, DWRITE_MATRIX* transform)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="transform">_Out_ <b>DWRITE_MATRIX* transform</b></param>
	int GetCurrentTransform (void* clientDrawingContext, out Matrix3x2F transform);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWritePixelSnapping::GetPixelsPerDip (void* clientDrawingContext, FLOAT* pixelsPerDip)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="pixelsPerDip">_Out_ <b>FLOAT* pixelsPerDip</b></param>
	int GetPixelsPerDip (void* clientDrawingContext, float* pixelsPerDip);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWritePixelSnapping::GetPixelsPerDip (void* clientDrawingContext, FLOAT* pixelsPerDip)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="pixelsPerDip">_Out_ <b>FLOAT* pixelsPerDip</b></param>
	int GetPixelsPerDip (void* clientDrawingContext, out float pixelsPerDip);
}

/// <summary>
/// Instance of <b>IDWritePixelSnapping</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct PixelSnapping : IPixelSnapping {
//unsafe public readonly struct IPixelSnappingObj : IPixelSnapping {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PixelSnapping* GetCurrentPointer () => (PixelSnapping*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPixelSnappingObj* GetCurrentPointer () => (IPixelSnappingObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xeaf3a2da, 0xecf4, 0x4d24, 0xb6, 0x44, 0xb3, 0x4f, 0x68, 0x42, 0x02, 0x4b);

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
	public readonly int IsPixelSnappingDisabled (void* clientDrawingContext, uint* isDisabled) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsPixelSnappingDisabled (ptr, clientDrawingContext, isDisabled);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int IsPixelSnappingDisabled (void* clientDrawingContext, out bool isDisabled) {
		uint _isDisabled;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsPixelSnappingDisabled (ptr, clientDrawingContext, &_isDisabled);
		isDisabled = _isDisabled != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentTransform (void* clientDrawingContext, Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentTransform (ptr, clientDrawingContext, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentTransform (void* clientDrawingContext, out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentTransform (ptr, clientDrawingContext, _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelsPerDip (void* clientDrawingContext, float* pixelsPerDip) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelsPerDip (ptr, clientDrawingContext, pixelsPerDip);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelsPerDip (void* clientDrawingContext, out float pixelsPerDip) {
		fixed (float* _pixelsPerDip = &pixelsPerDip) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelsPerDip (ptr, clientDrawingContext, _pixelsPerDip);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, int> IsPixelSnappingDisabled;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Matrix3x2F*, int> GetCurrentTransform;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float*, int> GetPixelsPerDip;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
