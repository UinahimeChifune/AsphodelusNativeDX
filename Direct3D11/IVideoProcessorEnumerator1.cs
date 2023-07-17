using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoProcessorEnumerator1</b> : ID3D11VideoProcessorEnumerator<br/>
/// D3D11_1.h
/// </summary>
unsafe public interface IVideoProcessorEnumerator1 : IVideoProcessorEnumerator {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator1::CheckVideoProcessorFormatConversion (DXGI_FORMAT InputFormat, DXGI_COLOR_SPACE_TYPE InputColorSpace, DXGI_FORMAT OutputFormat, DXGI_COLOR_SPACE_TYPE OutputColorSpace, BOOL* pSupported)</b><br/>
	/// </summary>
	/// <param name="inputFormat">_In_ <b>DXGI_FORMAT InputFormat</b></param>
	/// <param name="inputColorSpace">_In_ <b>DXGI_COLOR_SPACE_TYPE InputColorSpace</b></param>
	/// <param name="outputFormat">_In_ <b>DXGI_FORMAT OutputFormat</b></param>
	/// <param name="outputColorSpace">_In_ <b>DXGI_COLOR_SPACE_TYPE OutputColorSpace</b></param>
	/// <param name="pSupported">_Out_ <b>BOOL* pSupported</b></param>
	int CheckVideoProcessorFormatConversion (DXGI.Format inputFormat, DXGI.ColorSpaceType inputColorSpace, DXGI.Format outputFormat, DXGI.ColorSpaceType outputColorSpace, uint* pSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoProcessorEnumerator1::CheckVideoProcessorFormatConversion (DXGI_FORMAT InputFormat, DXGI_COLOR_SPACE_TYPE InputColorSpace, DXGI_FORMAT OutputFormat, DXGI_COLOR_SPACE_TYPE OutputColorSpace, BOOL* pSupported)</b><br/>
	/// </summary>
	/// <param name="inputFormat">_In_ <b>DXGI_FORMAT InputFormat</b></param>
	/// <param name="inputColorSpace">_In_ <b>DXGI_COLOR_SPACE_TYPE InputColorSpace</b></param>
	/// <param name="outputFormat">_In_ <b>DXGI_FORMAT OutputFormat</b></param>
	/// <param name="outputColorSpace">_In_ <b>DXGI_COLOR_SPACE_TYPE OutputColorSpace</b></param>
	/// <param name="pSupported">_Out_ <b>BOOL* pSupported</b></param>
	int CheckVideoProcessorFormatConversion (DXGI.Format inputFormat, DXGI.ColorSpaceType inputColorSpace, DXGI.Format outputFormat, DXGI.ColorSpaceType outputColorSpace, out bool pSupported);
}

/// <summary>
/// Instance of <b>ID3D11VideoProcessorEnumerator1</b><br/>
/// D3D11_1.h
/// </summary>
unsafe public readonly struct VideoProcessorEnumerator1 : IVideoProcessorEnumerator1 {
//unsafe public readonly struct IVideoProcessorEnumerator1Obj : IVideoProcessorEnumerator1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoProcessorEnumerator1* GetCurrentPointer () => (VideoProcessorEnumerator1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoProcessorEnumerator1Obj* GetCurrentPointer () => (IVideoProcessorEnumerator1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x465217f2, 0x5568, 0x43cf, 0xb5, 0xb9, 0xf6, 0x1d, 0x54, 0x53, 0x1c, 0xa1);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoProcessorFormatConversion (DXGI.Format inputFormat, DXGI.ColorSpaceType inputColorSpace, DXGI.Format outputFormat, DXGI.ColorSpaceType outputColorSpace, uint* pSupported) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoProcessorFormatConversion (ptr, inputFormat, inputColorSpace, outputFormat, outputColorSpace, pSupported);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckVideoProcessorFormatConversion (DXGI.Format inputFormat, DXGI.ColorSpaceType inputColorSpace, DXGI.Format outputFormat, DXGI.ColorSpaceType outputColorSpace, out bool pSupported) {
		uint _pSupported;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckVideoProcessorFormatConversion (ptr, inputFormat, inputColorSpace, outputFormat, outputColorSpace, &_pSupported);
		pSupported = _pSupported != 0;
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
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DXGI.Format, DXGI.ColorSpaceType, DXGI.Format, DXGI.ColorSpaceType, uint*, int> CheckVideoProcessorFormatConversion;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
