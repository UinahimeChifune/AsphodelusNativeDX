using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIDecodeSwapChain</b> : IUnknown<br/>
/// DXGI1_3.h
/// </summary>
unsafe public interface IDecodeSwapChain : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::PresentBuffer (UINT BufferToPresent, UINT SyncInterval, UINT Flags)</b><br/>
	/// </summary>
	/// <param name="bufferToPresent"><b>UINT BufferToPresent</b></param>
	/// <param name="syncInterval"><b>UINT SyncInterval</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	int PresentBuffer (uint bufferToPresent, uint syncInterval, uint flags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::SetSourceRect (RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pRect"><b>RECT* pRect</b></param>
	int SetSourceRect (Vector4I* pRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::SetTargetRect (RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pRect"><b>RECT* pRect</b></param>
	int SetTargetRect (Vector4I* pRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::SetDestSize (UINT Width, UINT Height)</b><br/>
	/// </summary>
	/// <param name="width"><b>UINT Width</b></param>
	/// <param name="height"><b>UINT Height</b></param>
	int SetDestSize (uint width, uint height);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::GetSourceRect (RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	int GetSourceRect (Vector4I* pRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::GetSourceRect (RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	int GetSourceRect (out Vector4I pRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::GetTargetRect (RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	int GetTargetRect (Vector4I* pRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::GetTargetRect (RECT* pRect)</b><br/>
	/// </summary>
	/// <param name="pRect">_Out_ <b>RECT* pRect</b></param>
	int GetTargetRect (out Vector4I pRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::GetDestSize (UINT* pWidth, UINT* pHeight)</b><br/>
	/// </summary>
	/// <param name="pWidth">_Out_ <b>UINT* pWidth</b></param>
	/// <param name="pHeight">_Out_ <b>UINT* pHeight</b></param>
	int GetDestSize (uint* pWidth, uint* pHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::GetDestSize (UINT* pWidth, UINT* pHeight)</b><br/>
	/// </summary>
	/// <param name="pWidth">_Out_ <b>UINT* pWidth</b></param>
	/// <param name="pHeight">_Out_ <b>UINT* pHeight</b></param>
	int GetDestSize (out uint pWidth, out uint pHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDecodeSwapChain::SetColorSpace (DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace)</b><br/>
	/// </summary>
	/// <param name="colorSpace"><b>DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace</b></param>
	int SetColorSpace (MultiplaneOverlayYCbCrFlags colorSpace);
	/// <summary>
	/// STDMETHODCALLTYPE <b>DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS IDXGIDecodeSwapChain::GetColorSpace ()</b><br/>
	/// </summary>
	MultiplaneOverlayYCbCrFlags GetColorSpace ();
}

/// <summary>
/// Instance of <b>IDXGIDecodeSwapChain</b><br/>
/// DXGI1_3.h
/// </summary>
unsafe public readonly struct DecodeSwapChain : IDecodeSwapChain {
//unsafe public readonly struct IDecodeSwapChainObj : IDecodeSwapChain {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DecodeSwapChain* GetCurrentPointer () => (DecodeSwapChain*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDecodeSwapChainObj* GetCurrentPointer () => (IDecodeSwapChainObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2633066b, 0x4514, 0x4c7a, 0x8f, 0xd8, 0x12, 0xea, 0x98, 0x05, 0x9d, 0x18);

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
	public readonly int PresentBuffer (uint bufferToPresent, uint syncInterval, uint flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PresentBuffer (ptr, bufferToPresent, syncInterval, flags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSourceRect (Vector4I* pRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSourceRect (ptr, pRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTargetRect (Vector4I* pRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTargetRect (ptr, pRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetDestSize (uint width, uint height) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetDestSize (ptr, width, height);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSourceRect (Vector4I* pRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSourceRect (ptr, pRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSourceRect (out Vector4I pRect) {
		fixed (Vector4I* _pRect = &pRect) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSourceRect (ptr, _pRect);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTargetRect (Vector4I* pRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTargetRect (ptr, pRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTargetRect (out Vector4I pRect) {
		fixed (Vector4I* _pRect = &pRect) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetTargetRect (ptr, _pRect);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDestSize (uint* pWidth, uint* pHeight) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDestSize (ptr, pWidth, pHeight);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDestSize (out uint pWidth, out uint pHeight) {
		fixed (uint* _pWidth = &pWidth) {
			fixed (uint* _pHeight = &pHeight) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetDestSize (ptr, _pWidth, _pHeight);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetColorSpace (MultiplaneOverlayYCbCrFlags colorSpace) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetColorSpace (ptr, colorSpace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly MultiplaneOverlayYCbCrFlags GetColorSpace () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorSpace (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, int> PresentBuffer;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, int> SetSourceRect;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, int> SetTargetRect;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, int> SetDestSize;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, int> GetSourceRect;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, int> GetTargetRect;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, int> GetDestSize;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MultiplaneOverlayYCbCrFlags, int> SetColorSpace;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MultiplaneOverlayYCbCrFlags> GetColorSpace;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
