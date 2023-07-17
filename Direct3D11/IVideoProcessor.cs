using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoProcessor</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface IVideoProcessor : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoProcessor::GetContentDesc (D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc</b></param>
	void GetContentDesc (VideoProcessorContentDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoProcessor::GetContentDesc (D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc</b></param>
	void GetContentDesc (out VideoProcessorContentDesc pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoProcessor::GetRateConversionCaps (D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps</b></param>
	void GetRateConversionCaps (VideoProcessorRateConversionCaps* pCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11VideoProcessor::GetRateConversionCaps (D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps</b></param>
	void GetRateConversionCaps (out VideoProcessorRateConversionCaps pCaps);
}

/// <summary>
/// Instance of <b>ID3D11VideoProcessor</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct VideoProcessor : IVideoProcessor {
//unsafe public readonly struct IVideoProcessorObj : IVideoProcessor {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoProcessor* GetCurrentPointer () => (VideoProcessor*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoProcessorObj* GetCurrentPointer () => (IVideoProcessorObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1d7b0652, 0x185f, 0x41c6, 0x85, 0xce, 0x0c, 0x5b, 0xe3, 0xd4, 0xae, 0x6c);

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
	public readonly void GetContentDesc (VideoProcessorContentDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetContentDesc (ptr, pDesc);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetContentDesc (out VideoProcessorContentDesc pDesc) {
		fixed (VideoProcessorContentDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetContentDesc (ptr, _pDesc);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetRateConversionCaps (VideoProcessorRateConversionCaps* pCaps) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetRateConversionCaps (ptr, pCaps);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetRateConversionCaps (out VideoProcessorRateConversionCaps pCaps) {
		fixed (VideoProcessorRateConversionCaps* _pCaps = &pCaps) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetRateConversionCaps (ptr, _pCaps);
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
		public readonly delegate* unmanaged[Stdcall]<void*, VideoProcessorContentDesc*, void> GetContentDesc;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoProcessorRateConversionCaps*, void> GetRateConversionCaps;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
