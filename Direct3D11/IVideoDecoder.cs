using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11VideoDecoder</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface IVideoDecoder : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDecoder::GetCreationParameters (D3D11_VIDEO_DECODER_DESC* pVideoDesc, D3D11_VIDEO_DECODER_CONFIG* pConfig)</b><br/>
	/// </summary>
	/// <param name="pVideoDesc">_Out_ <b>D3D11_VIDEO_DECODER_DESC* pVideoDesc</b></param>
	/// <param name="pConfig">_Out_ <b>D3D11_VIDEO_DECODER_CONFIG* pConfig</b></param>
	int GetCreationParameters (VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDecoder::GetCreationParameters (D3D11_VIDEO_DECODER_DESC* pVideoDesc, D3D11_VIDEO_DECODER_CONFIG* pConfig)</b><br/>
	/// </summary>
	/// <param name="pVideoDesc">_Out_ <b>D3D11_VIDEO_DECODER_DESC* pVideoDesc</b></param>
	/// <param name="pConfig">_Out_ <b>D3D11_VIDEO_DECODER_CONFIG* pConfig</b></param>
	int GetCreationParameters (out VideoDecoderDesc pVideoDesc, out VideoDecoderConfig pConfig);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDecoder::GetDriverHandle (HANDLE* pDriverHandle)</b><br/>
	/// </summary>
	/// <param name="pDriverHandle">_Out_ <b>HANDLE* pDriverHandle</b></param>
	int GetDriverHandle (IntPtr* pDriverHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11VideoDecoder::GetDriverHandle (HANDLE* pDriverHandle)</b><br/>
	/// </summary>
	/// <param name="pDriverHandle">_Out_ <b>HANDLE* pDriverHandle</b></param>
	int GetDriverHandle (out IntPtr pDriverHandle);
}

/// <summary>
/// Instance of <b>ID3D11VideoDecoder</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct VideoDecoder : IVideoDecoder {
//unsafe public readonly struct IVideoDecoderObj : IVideoDecoder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoDecoder* GetCurrentPointer () => (VideoDecoder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVideoDecoderObj* GetCurrentPointer () => (IVideoDecoderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3c9c5b51, 0x995d, 0x48d1, 0x9b, 0x8d, 0xfa, 0x5c, 0xae, 0xde, 0xd6, 0x5c);

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
	public readonly int GetCreationParameters (VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCreationParameters (ptr, pVideoDesc, pConfig);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCreationParameters (out VideoDecoderDesc pVideoDesc, out VideoDecoderConfig pConfig) {
		fixed (VideoDecoderDesc* _pVideoDesc = &pVideoDesc) {
			fixed (VideoDecoderConfig* _pConfig = &pConfig) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetCreationParameters (ptr, _pVideoDesc, _pConfig);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDriverHandle (IntPtr* pDriverHandle) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDriverHandle (ptr, pDriverHandle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDriverHandle (out IntPtr pDriverHandle) {
		fixed (IntPtr* _pDriverHandle = &pDriverHandle) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDriverHandle (ptr, _pDriverHandle);
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
		public readonly delegate* unmanaged[Stdcall]<void*, VideoDecoderDesc*, VideoDecoderConfig*, int> GetCreationParameters;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr*, int> GetDriverHandle;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
