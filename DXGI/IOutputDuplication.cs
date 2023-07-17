using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIOutputDuplication</b> : IDXGIObject<br/>
/// DXGI1_2.h
/// </summary>
unsafe public interface IOutputDuplication : IObject {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIOutputDuplication::GetDesc (DXGI_OUTDUPL_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_OUTDUPL_DESC* pDesc</b></param>
	void GetDesc (OutduplDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIOutputDuplication::GetDesc (DXGI_OUTDUPL_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_OUTDUPL_DESC* pDesc</b></param>
	void GetDesc (out OutduplDesc pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::AcquireNextFrame (UINT TimeoutInMilliseconds, DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, IDXGIResource** ppDesktopResource)</b><br/>
	/// </summary>
	/// <param name="timeoutInMilliseconds">_In_ <b>UINT TimeoutInMilliseconds</b></param>
	/// <param name="pFrameInfo">_Out_ <b>DXGI_OUTDUPL_FRAME_INFO* pFrameInfo</b></param>
	/// <param name="ppDesktopResource">_COM_Outptr_ <b>IDXGIResource** ppDesktopResource</b></param>
	int AcquireNextFrame<T0> (uint timeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, T0** ppDesktopResource) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::AcquireNextFrame (UINT TimeoutInMilliseconds, DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, IDXGIResource** ppDesktopResource)</b><br/>
	/// </summary>
	/// <param name="timeoutInMilliseconds">_In_ <b>UINT TimeoutInMilliseconds</b></param>
	/// <param name="pFrameInfo">_Out_ <b>DXGI_OUTDUPL_FRAME_INFO* pFrameInfo</b></param>
	/// <param name="ppDesktopResource">_COM_Outptr_ <b>IDXGIResource** ppDesktopResource</b></param>
	int AcquireNextFrame<T0> (uint timeoutInMilliseconds, out OutduplFrameInfo pFrameInfo, out T0* ppDesktopResource) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::GetFrameDirtyRects (UINT DirtyRectsBufferSize, RECT* pDirtyRectsBuffer, UINT* pDirtyRectsBufferSizeRequired)</b><br/>
	/// </summary>
	/// <param name="dirtyRectsBufferSize">_In_ <b>UINT DirtyRectsBufferSize</b></param>
	/// <param name="pDirtyRectsBuffer">_Out_writes_bytes_to_(DirtyRectsBufferSize, *pDirtyRectsBufferSizeRequired) <b>RECT* pDirtyRectsBuffer</b></param>
	/// <param name="pDirtyRectsBufferSizeRequired">_Out_ <b>UINT* pDirtyRectsBufferSizeRequired</b></param>
	int GetFrameDirtyRects (uint dirtyRectsBufferSize, Vector4I* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::GetFrameDirtyRects (UINT DirtyRectsBufferSize, RECT* pDirtyRectsBuffer, UINT* pDirtyRectsBufferSizeRequired)</b><br/>
	/// </summary>
	/// <param name="dirtyRectsBufferSize">_In_ <b>UINT DirtyRectsBufferSize</b></param>
	/// <param name="pDirtyRectsBuffer">_Out_writes_bytes_to_(DirtyRectsBufferSize, *pDirtyRectsBufferSizeRequired) <b>RECT* pDirtyRectsBuffer</b></param>
	/// <param name="pDirtyRectsBufferSizeRequired">_Out_ <b>UINT* pDirtyRectsBufferSizeRequired</b></param>
	int GetFrameDirtyRects (uint dirtyRectsBufferSize, Vector4I* pDirtyRectsBuffer, out uint pDirtyRectsBufferSizeRequired);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::GetFrameMoveRects (UINT MoveRectsBufferSize, DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, UINT* pMoveRectsBufferSizeRequired)</b><br/>
	/// </summary>
	/// <param name="moveRectsBufferSize">_In_ <b>UINT MoveRectsBufferSize</b></param>
	/// <param name="pMoveRectBuffer">_Out_writes_bytes_to_(MoveRectsBufferSize, *pMoveRectsBufferSizeRequired) <b>DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer</b></param>
	/// <param name="pMoveRectsBufferSizeRequired">_Out_ <b>UINT* pMoveRectsBufferSizeRequired</b></param>
	int GetFrameMoveRects (uint moveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::GetFrameMoveRects (UINT MoveRectsBufferSize, DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, UINT* pMoveRectsBufferSizeRequired)</b><br/>
	/// </summary>
	/// <param name="moveRectsBufferSize">_In_ <b>UINT MoveRectsBufferSize</b></param>
	/// <param name="pMoveRectBuffer">_Out_writes_bytes_to_(MoveRectsBufferSize, *pMoveRectsBufferSizeRequired) <b>DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer</b></param>
	/// <param name="pMoveRectsBufferSizeRequired">_Out_ <b>UINT* pMoveRectsBufferSizeRequired</b></param>
	int GetFrameMoveRects (uint moveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, out uint pMoveRectsBufferSizeRequired);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::GetFramePointerShape (UINT PointerShapeBufferSize, void* pPointerShapeBuffer, UINT* pPointerShapeBufferSizeRequired, DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo)</b><br/>
	/// </summary>
	/// <param name="pointerShapeBufferSize">_In_ <b>UINT PointerShapeBufferSize</b></param>
	/// <param name="pPointerShapeBuffer">_Out_writes_bytes_to_(PointerShapeBufferSize, *pPointerShapeBufferSizeRequired) <b>void* pPointerShapeBuffer</b></param>
	/// <param name="pPointerShapeBufferSizeRequired">_Out_ <b>UINT* pPointerShapeBufferSizeRequired</b></param>
	/// <param name="pPointerShapeInfo">_Out_ <b>DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo</b></param>
	int GetFramePointerShape (uint pointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::GetFramePointerShape (UINT PointerShapeBufferSize, void* pPointerShapeBuffer, UINT* pPointerShapeBufferSizeRequired, DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo)</b><br/>
	/// </summary>
	/// <param name="pointerShapeBufferSize">_In_ <b>UINT PointerShapeBufferSize</b></param>
	/// <param name="pPointerShapeBuffer">_Out_writes_bytes_to_(PointerShapeBufferSize, *pPointerShapeBufferSizeRequired) <b>void* pPointerShapeBuffer</b></param>
	/// <param name="pPointerShapeBufferSizeRequired">_Out_ <b>UINT* pPointerShapeBufferSizeRequired</b></param>
	/// <param name="pPointerShapeInfo">_Out_ <b>DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo</b></param>
	int GetFramePointerShape (uint pointerShapeBufferSize, void* pPointerShapeBuffer, out uint pPointerShapeBufferSizeRequired, out OutduplPointerShapeInfo pPointerShapeInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::MapDesktopSurface (DXGI_MAPPED_RECT* pLockedRect)</b><br/>
	/// </summary>
	/// <param name="pLockedRect">_Out_ <b>DXGI_MAPPED_RECT* pLockedRect</b></param>
	int MapDesktopSurface (MappedRect* pLockedRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::MapDesktopSurface (DXGI_MAPPED_RECT* pLockedRect)</b><br/>
	/// </summary>
	/// <param name="pLockedRect">_Out_ <b>DXGI_MAPPED_RECT* pLockedRect</b></param>
	int MapDesktopSurface (out MappedRect pLockedRect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::UnMapDesktopSurface ()</b><br/>
	/// </summary>
	int UnMapDesktopSurface ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutputDuplication::ReleaseFrame ()</b><br/>
	/// </summary>
	int ReleaseFrame ();
}

/// <summary>
/// Instance of <b>IDXGIOutputDuplication</b><br/>
/// DXGI1_2.h
/// </summary>
unsafe public readonly struct OutputDuplication : IOutputDuplication {
//unsafe public readonly struct IOutputDuplicationObj : IOutputDuplication {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly OutputDuplication* GetCurrentPointer () => (OutputDuplication*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IOutputDuplicationObj* GetCurrentPointer () => (IOutputDuplicationObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x191cfac3, 0xa341, 0x470d, 0xb2, 0x6e, 0xa8, 0x64, 0xf4, 0x28, 0x31, 0x9c);

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
	public readonly int SetPrivateData (Guid name, uint dataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateData (ptr, name, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateDataInterface<T0> (Guid name, T0* pUnknown) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateDataInterface (ptr, name, pUnknown);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPrivateData (Guid name, uint* pDataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrivateData (ptr, name, pDataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParent (Guid riid, void** ppParent) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetParent (ptr, riid, ppParent);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParent (Guid riid, out void* ppParent) {
		fixed (void** _ppParent = &ppParent) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetParent (ptr, riid, _ppParent);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (OutduplDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (out OutduplDesc pDesc) {
		fixed (OutduplDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, _pDesc);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AcquireNextFrame<T0> (uint timeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, T0** ppDesktopResource) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AcquireNextFrame (ptr, timeoutInMilliseconds, pFrameInfo, (void**) ppDesktopResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AcquireNextFrame<T0> (uint timeoutInMilliseconds, out OutduplFrameInfo pFrameInfo, out T0* ppDesktopResource) where T0 : unmanaged, IResource {
		fixed (OutduplFrameInfo* _pFrameInfo = &pFrameInfo) {
			fixed (T0** _ppDesktopResource = &ppDesktopResource) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->AcquireNextFrame (ptr, timeoutInMilliseconds, _pFrameInfo, (void**) _ppDesktopResource);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameDirtyRects (uint dirtyRectsBufferSize, Vector4I* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameDirtyRects (ptr, dirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameDirtyRects (uint dirtyRectsBufferSize, Vector4I* pDirtyRectsBuffer, out uint pDirtyRectsBufferSizeRequired) {
		fixed (uint* _pDirtyRectsBufferSizeRequired = &pDirtyRectsBufferSizeRequired) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameDirtyRects (ptr, dirtyRectsBufferSize, pDirtyRectsBuffer, _pDirtyRectsBufferSizeRequired);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameMoveRects (uint moveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameMoveRects (ptr, moveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameMoveRects (uint moveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, out uint pMoveRectsBufferSizeRequired) {
		fixed (uint* _pMoveRectsBufferSizeRequired = &pMoveRectsBufferSizeRequired) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameMoveRects (ptr, moveRectsBufferSize, pMoveRectBuffer, _pMoveRectsBufferSizeRequired);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFramePointerShape (uint pointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFramePointerShape (ptr, pointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFramePointerShape (uint pointerShapeBufferSize, void* pPointerShapeBuffer, out uint pPointerShapeBufferSizeRequired, out OutduplPointerShapeInfo pPointerShapeInfo) {
		fixed (uint* _pPointerShapeBufferSizeRequired = &pPointerShapeBufferSizeRequired) {
			fixed (OutduplPointerShapeInfo* _pPointerShapeInfo = &pPointerShapeInfo) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetFramePointerShape (ptr, pointerShapeBufferSize, pPointerShapeBuffer, _pPointerShapeBufferSizeRequired, _pPointerShapeInfo);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapDesktopSurface (MappedRect* pLockedRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MapDesktopSurface (ptr, pLockedRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapDesktopSurface (out MappedRect pLockedRect) {
		fixed (MappedRect* _pLockedRect = &pLockedRect) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->MapDesktopSurface (ptr, _pLockedRect);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnMapDesktopSurface () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnMapDesktopSurface (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReleaseFrame () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReleaseFrame (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetParent;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OutduplDesc*, void> GetDesc;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, OutduplFrameInfo*, void**, int> AcquireNextFrame;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Vector4I*, uint*, int> GetFrameDirtyRects;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, OutduplMoveRect*, uint*, int> GetFrameMoveRects;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint*, OutduplPointerShapeInfo*, int> GetFramePointerShape;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MappedRect*, int> MapDesktopSurface;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> UnMapDesktopSurface;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> ReleaseFrame;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
