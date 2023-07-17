using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoDecoderOutputView</b> : ID3D11View<br/>
/// D3D11.h
/// </summary>
unsafe public interface IVideoDecoderOutputView : IView {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoDecoderOutputView::GetDesc (D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc</b></param>
	void GetDesc (VideoDecoderOutputViewDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoDecoderOutputView::GetDesc (D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc</b></param>
	void GetDesc (out VideoDecoderOutputViewDesc pDesc);
}

/// <summary>
/// Instance of <b>ID3D11VideoDecoderOutputView</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct VideoDecoderOutputView : IVideoDecoderOutputView {
//unsafe public readonly struct IVideoDecoderOutputViewObj : IVideoDecoderOutputView {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoDecoderOutputView* GetCurrentPointer () => (VideoDecoderOutputView*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoDecoderOutputViewObj* GetCurrentPointer () => (IVideoDecoderOutputViewObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc2931aea, 0x2a85, 0x4f20, 0x86, 0x0f, 0xfb, 0xa1, 0xfd, 0x25, 0x6e, 0x18);

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
	public readonly void GetDesc (VideoDecoderOutputViewDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (out VideoDecoderOutputViewDesc pDesc) {
		fixed (VideoDecoderOutputViewDesc* _pDesc = &pDesc) {
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
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderOutputViewDesc*, void> GetDesc;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
