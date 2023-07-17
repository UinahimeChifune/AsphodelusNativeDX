using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1GdiMetafile1</b> : ID2D1GdiMetafile<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IGdiMetafile1 : IGdiMetafile {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiMetafile1::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	int GetDpi (float* dpiX, float* dpiY);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiMetafile1::GetDpi (FLOAT* dpiX, FLOAT* dpiY)</b><br/>
	/// </summary>
	/// <param name="dpiX">_Out_ <b>FLOAT* dpiX</b></param>
	/// <param name="dpiY">_Out_ <b>FLOAT* dpiY</b></param>
	int GetDpi (out float dpiX, out float dpiY);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiMetafile1::GetSourceBounds (D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetSourceBounds (Vector4F* bounds);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiMetafile1::GetSourceBounds (D2D1_RECT_F* bounds)</b><br/>
	/// </summary>
	/// <param name="bounds">_Out_ <b>D2D1_RECT_F* bounds</b></param>
	int GetSourceBounds (out Vector4F bounds);
}

/// <summary>
/// Instance of <b>ID2D1GdiMetafile1</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct GdiMetafile1 : IGdiMetafile1 {
//unsafe public readonly struct IGdiMetafile1Obj : IGdiMetafile1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GdiMetafile1* GetCurrentPointer () => (GdiMetafile1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGdiMetafile1Obj* GetCurrentPointer () => (IGdiMetafile1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2e69f9e8, 0xdd3f, 0x4bf9, 0x95, 0xba, 0xc0, 0x4f, 0x49, 0xd7, 0x88, 0xdf);

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
	public readonly int Stream<T0> (T0* sink) where T0 : unmanaged, IGdiMetafileSink {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Stream (ptr, sink);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBounds (Vector4F* bounds) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBounds (ptr, bounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBounds (out Vector4F bounds) {
		fixed (Vector4F* _bounds = &bounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetBounds (ptr, _bounds);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDpi (float* dpiX, float* dpiY) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDpi (ptr, dpiX, dpiY);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDpi (out float dpiX, out float dpiY) {
		fixed (float* _dpiX = &dpiX) {
			fixed (float* _dpiY = &dpiY) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetDpi (ptr, _dpiX, _dpiY);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSourceBounds (Vector4F* bounds) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSourceBounds (ptr, bounds);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSourceBounds (out Vector4F bounds) {
		fixed (Vector4F* _bounds = &bounds) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSourceBounds (ptr, _bounds);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> Stream;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, int> GetBounds;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, float*, int> GetDpi;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, int> GetSourceBounds;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
