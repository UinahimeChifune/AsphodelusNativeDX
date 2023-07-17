using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1GdiInteropRenderTarget</b> : IUnknown<br/>
/// D2D1.h
/// </summary>
unsafe public interface IGdiInteropRenderTarget : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiInteropRenderTarget::GetDC (D2D1_DC_INITIALIZE_MODE mode, HDC* hdc)</b><br/>
	/// </summary>
	/// <param name="mode"><b>D2D1_DC_INITIALIZE_MODE mode</b></param>
	/// <param name="hdc">_Out_ <b>HDC* hdc</b></param>
	int GetDC (DcInitializeMode mode, IntPtr* hdc);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiInteropRenderTarget::GetDC (D2D1_DC_INITIALIZE_MODE mode, HDC* hdc)</b><br/>
	/// </summary>
	/// <param name="mode"><b>D2D1_DC_INITIALIZE_MODE mode</b></param>
	/// <param name="hdc">_Out_ <b>HDC* hdc</b></param>
	int GetDC (DcInitializeMode mode, out IntPtr hdc);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiInteropRenderTarget::ReleaseDC (RECT* update)</b><br/>
	/// </summary>
	/// <param name="update">_In_opt_ <b>RECT* update</b></param>
	int ReleaseDC (Vector4I* update);
}

/// <summary>
/// Instance of <b>ID2D1GdiInteropRenderTarget</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct GdiInteropRenderTarget : IGdiInteropRenderTarget {
//unsafe public readonly struct IGdiInteropRenderTargetObj : IGdiInteropRenderTarget {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GdiInteropRenderTarget* GetCurrentPointer () => (GdiInteropRenderTarget*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGdiInteropRenderTargetObj* GetCurrentPointer () => (IGdiInteropRenderTargetObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xe0db51c3, 0x6f77, 0x4bae, 0xb3, 0xd5, 0xe4, 0x75, 0x09, 0xb3, 0x58, 0x38);

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
	public readonly int GetDC (DcInitializeMode mode, IntPtr* hdc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDC (ptr, mode, hdc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDC (DcInitializeMode mode, out IntPtr hdc) {
		fixed (IntPtr* _hdc = &hdc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDC (ptr, mode, _hdc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReleaseDC (Vector4I* update) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReleaseDC (ptr, update);
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
		public readonly delegate* unmanaged[Stdcall]<void*, DcInitializeMode, IntPtr*, int> GetDC;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, int> ReleaseDC;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
