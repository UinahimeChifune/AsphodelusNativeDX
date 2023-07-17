using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoProcessorEnumerator</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface IVideoProcessorEnumerator : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorContentDesc (D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)</b><br/>
	/// </summary>
	/// <param name="pContentDesc">_Out_ <b>D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc</b></param>
	int GetVideoProcessorContentDesc (VideoProcessorContentDesc* pContentDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorContentDesc (D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)</b><br/>
	/// </summary>
	/// <param name="pContentDesc">_Out_ <b>D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc</b></param>
	int GetVideoProcessorContentDesc (out VideoProcessorContentDesc pContentDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::CheckVideoProcessorFormat (DXGI_FORMAT Format, UINT* pFlags)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="pFlags">_Out_ <b>UINT* pFlags</b></param>
	int CheckVideoProcessorFormat (DXGI.Format format, uint* pFlags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::CheckVideoProcessorFormat (DXGI_FORMAT Format, UINT* pFlags)</b><br/>
	/// </summary>
	/// <param name="format">_In_ <b>DXGI_FORMAT Format</b></param>
	/// <param name="pFlags">_Out_ <b>UINT* pFlags</b></param>
	int CheckVideoProcessorFormat (DXGI.Format format, out uint pFlags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorCaps (D3D11_VIDEO_PROCESSOR_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_PROCESSOR_CAPS* pCaps</b></param>
	int GetVideoProcessorCaps (VideoProcessorCaps* pCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorCaps (D3D11_VIDEO_PROCESSOR_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_PROCESSOR_CAPS* pCaps</b></param>
	int GetVideoProcessorCaps (out VideoProcessorCaps pCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorRateConversionCaps (UINT TypeIndex, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="typeIndex">_In_ <b>UINT TypeIndex</b></param>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps</b></param>
	int GetVideoProcessorRateConversionCaps (uint typeIndex, VideoProcessorRateConversionCaps* pCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorRateConversionCaps (UINT TypeIndex, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)</b><br/>
	/// </summary>
	/// <param name="typeIndex">_In_ <b>UINT TypeIndex</b></param>
	/// <param name="pCaps">_Out_ <b>D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps</b></param>
	int GetVideoProcessorRateConversionCaps (uint typeIndex, out VideoProcessorRateConversionCaps pCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorCustomRate (UINT TypeIndex, UINT CustomRateIndex, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate)</b><br/>
	/// </summary>
	/// <param name="typeIndex">_In_ <b>UINT TypeIndex</b></param>
	/// <param name="customRateIndex">_In_ <b>UINT CustomRateIndex</b></param>
	/// <param name="pRate">_Out_ <b>D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate</b></param>
	int GetVideoProcessorCustomRate (uint typeIndex, uint customRateIndex, VideoProcessorCustomRate* pRate);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorCustomRate (UINT TypeIndex, UINT CustomRateIndex, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate)</b><br/>
	/// </summary>
	/// <param name="typeIndex">_In_ <b>UINT TypeIndex</b></param>
	/// <param name="customRateIndex">_In_ <b>UINT CustomRateIndex</b></param>
	/// <param name="pRate">_Out_ <b>D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate</b></param>
	int GetVideoProcessorCustomRate (uint typeIndex, uint customRateIndex, out VideoProcessorCustomRate pRate);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorFilterRange (D3D11_VIDEO_PROCESSOR_FILTER Filter, D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange)</b><br/>
	/// </summary>
	/// <param name="filter">_In_ <b>D3D11_VIDEO_PROCESSOR_FILTER Filter</b></param>
	/// <param name="pRange">_Out_ <b>D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange</b></param>
	int GetVideoProcessorFilterRange (VideoProcessorFilter filter, VideoProcessorFilterRange* pRange);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator::GetVideoProcessorFilterRange (D3D11_VIDEO_PROCESSOR_FILTER Filter, D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange)</b><br/>
	/// </summary>
	/// <param name="filter">_In_ <b>D3D11_VIDEO_PROCESSOR_FILTER Filter</b></param>
	/// <param name="pRange">_Out_ <b>D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange</b></param>
	int GetVideoProcessorFilterRange (VideoProcessorFilter filter, out VideoProcessorFilterRange pRange);
}

/// <summary>
/// Instance of <b>ID3D11VideoProcessorEnumerator</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct VideoProcessorEnumerator : IVideoProcessorEnumerator {
//unsafe public readonly struct IVideoProcessorEnumeratorObj : IVideoProcessorEnumerator {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoProcessorEnumerator* GetCurrentPointer () => (VideoProcessorEnumerator*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoProcessorEnumeratorObj* GetCurrentPointer () => (IVideoProcessorEnumeratorObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x31627037, 0x53ab, 0x4200, 0x90, 0x61, 0x05, 0xfa, 0xa9, 0xab, 0x45, 0xf9);

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
	public readonly int GetVideoProcessorContentDesc (VideoProcessorContentDesc* pContentDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorContentDesc (ptr, pContentDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorContentDesc (out VideoProcessorContentDesc pContentDesc) {
		fixed (VideoProcessorContentDesc* _pContentDesc = &pContentDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorContentDesc (ptr, _pContentDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoProcessorFormat (DXGI.Format format, uint* pFlags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoProcessorFormat (ptr, format, pFlags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoProcessorFormat (DXGI.Format format, out uint pFlags) {
		fixed (uint* _pFlags = &pFlags) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoProcessorFormat (ptr, format, _pFlags);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorCaps (VideoProcessorCaps* pCaps) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorCaps (ptr, pCaps);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorCaps (out VideoProcessorCaps pCaps) {
		fixed (VideoProcessorCaps* _pCaps = &pCaps) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorCaps (ptr, _pCaps);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorRateConversionCaps (uint typeIndex, VideoProcessorRateConversionCaps* pCaps) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorRateConversionCaps (ptr, typeIndex, pCaps);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorRateConversionCaps (uint typeIndex, out VideoProcessorRateConversionCaps pCaps) {
		fixed (VideoProcessorRateConversionCaps* _pCaps = &pCaps) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorRateConversionCaps (ptr, typeIndex, _pCaps);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorCustomRate (uint typeIndex, uint customRateIndex, VideoProcessorCustomRate* pRate) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorCustomRate (ptr, typeIndex, customRateIndex, pRate);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorCustomRate (uint typeIndex, uint customRateIndex, out VideoProcessorCustomRate pRate) {
		fixed (VideoProcessorCustomRate* _pRate = &pRate) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorCustomRate (ptr, typeIndex, customRateIndex, _pRate);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorFilterRange (VideoProcessorFilter filter, VideoProcessorFilterRange* pRange) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorFilterRange (ptr, filter, pRange);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetVideoProcessorFilterRange (VideoProcessorFilter filter, out VideoProcessorFilterRange pRange) {
		fixed (VideoProcessorFilterRange* _pRange = &pRange) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetVideoProcessorFilterRange (ptr, filter, _pRange);
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
		public readonly delegate* unmanaged[Stdcall]<void*, VideoProcessorContentDesc*, int> GetVideoProcessorContentDesc;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DXGI.Format, uint*, int> CheckVideoProcessorFormat;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoProcessorCaps*, int> GetVideoProcessorCaps;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, VideoProcessorRateConversionCaps*, int> GetVideoProcessorRateConversionCaps;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, VideoProcessorCustomRate*, int> GetVideoProcessorCustomRate;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoProcessorFilter, VideoProcessorFilterRange*, int> GetVideoProcessorFilterRange;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
