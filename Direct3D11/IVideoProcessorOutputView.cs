using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoProcessorOutputView</b> : ID3D11View<br/>
/// D3D11.h
/// </summary>
unsafe public interface IVideoProcessorOutputView : IView {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoProcessorOutputView::GetDesc (D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc</b></param>
	void GetDesc (VideoProcessorOutputViewDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoProcessorOutputView::GetDesc (D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc</b></param>
	void GetDesc (out VideoProcessorOutputViewDesc pDesc);
}

/// <summary>
/// Instance of <b>ID3D11VideoProcessorOutputView</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct VideoProcessorOutputView : IVideoProcessorOutputView {
//unsafe public readonly struct IVideoProcessorOutputViewObj : IVideoProcessorOutputView {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoProcessorOutputView* GetCurrentPointer () => (VideoProcessorOutputView*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoProcessorOutputViewObj* GetCurrentPointer () => (IVideoProcessorOutputViewObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa048285e, 0x25a9, 0x4527, 0xbd, 0x93, 0xd6, 0x8b, 0x68, 0xc4, 0x42, 0x54);

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
	public readonly void GetDevice<T0> (T0** ppDevice) where T0 : unmanaged, IDevice {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) ppDevice);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDevice<T0> (out T0* ppDevice) where T0 : unmanaged, IDevice {
		fixed (T0** _ppDevice = &ppDevice) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, (void**) _ppDevice);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPrivateData (Guid guid, uint* pDataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrivateData (ptr, guid, pDataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateData (Guid guid, uint dataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateData (ptr, guid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateDataInterface<T0> (Guid guid, T0* pData) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateDataInterface (ptr, guid, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetResource<T0> (T0** ppResource) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetResource (ptr, (void**) ppResource);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetResource<T0> (out T0* ppResource) where T0 : unmanaged, IResource {
		fixed (T0** _ppResource = &ppResource) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetResource (ptr, (void**) _ppResource);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (VideoProcessorOutputViewDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (out VideoProcessorOutputViewDesc pDesc) {
		fixed (VideoProcessorOutputViewDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, _pDesc);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetDevice;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetResource;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoProcessorOutputViewDesc*, void> GetDesc;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
