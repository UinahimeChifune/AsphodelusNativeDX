using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11CryptoSession</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface ICryptoSession : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11CryptoSession::GetCryptoType (GUID* pCryptoType)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_Out_ <b>GUID* pCryptoType</b></param>
	void GetCryptoType (Guid* pCryptoType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11CryptoSession::GetCryptoType (GUID* pCryptoType)</b><br/>
	/// </summary>
	/// <param name="pCryptoType">_Out_ <b>GUID* pCryptoType</b></param>
	void GetCryptoType (out Guid pCryptoType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11CryptoSession::GetDecoderProfile (GUID* pDecoderProfile)</b><br/>
	/// </summary>
	/// <param name="pDecoderProfile">_Out_ <b>GUID* pDecoderProfile</b></param>
	void GetDecoderProfile (Guid* pDecoderProfile);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11CryptoSession::GetDecoderProfile (GUID* pDecoderProfile)</b><br/>
	/// </summary>
	/// <param name="pDecoderProfile">_Out_ <b>GUID* pDecoderProfile</b></param>
	void GetDecoderProfile (out Guid pDecoderProfile);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11CryptoSession::GetCertificateSize (UINT* pCertificateSize)</b><br/>
	/// </summary>
	/// <param name="pCertificateSize">_Out_ <b>UINT* pCertificateSize</b></param>
	int GetCertificateSize (uint* pCertificateSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11CryptoSession::GetCertificateSize (UINT* pCertificateSize)</b><br/>
	/// </summary>
	/// <param name="pCertificateSize">_Out_ <b>UINT* pCertificateSize</b></param>
	int GetCertificateSize (out uint pCertificateSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11CryptoSession::GetCertificate (UINT CertificateSize, BYTE* pCertificate)</b><br/>
	/// </summary>
	/// <param name="certificateSize">_In_ <b>UINT CertificateSize</b></param>
	/// <param name="pCertificate">_Out_writes_bytes_(CertificateSize) <b>BYTE* pCertificate</b></param>
	int GetCertificate (uint certificateSize, byte* pCertificate);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11CryptoSession::GetCryptoSessionHandle (HANDLE* pCryptoSessionHandle)</b><br/>
	/// </summary>
	/// <param name="pCryptoSessionHandle">_Out_ <b>HANDLE* pCryptoSessionHandle</b></param>
	void GetCryptoSessionHandle (IntPtr* pCryptoSessionHandle);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11CryptoSession::GetCryptoSessionHandle (HANDLE* pCryptoSessionHandle)</b><br/>
	/// </summary>
	/// <param name="pCryptoSessionHandle">_Out_ <b>HANDLE* pCryptoSessionHandle</b></param>
	void GetCryptoSessionHandle (out IntPtr pCryptoSessionHandle);
}

/// <summary>
/// Instance of <b>ID3D11CryptoSession</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct CryptoSession : ICryptoSession {
//unsafe public readonly struct ICryptoSessionObj : ICryptoSession {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly CryptoSession* GetCurrentPointer () => (CryptoSession*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ICryptoSessionObj* GetCurrentPointer () => (ICryptoSessionObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9b32f9ad, 0xbdcc, 0x40a6, 0xa3, 0x9d, 0xd5, 0xc8, 0x65, 0x84, 0x57, 0x20);

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
	public readonly void GetCryptoType (Guid* pCryptoType) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetCryptoType (ptr, pCryptoType);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetCryptoType (out Guid pCryptoType) {
		fixed (Guid* _pCryptoType = &pCryptoType) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetCryptoType (ptr, _pCryptoType);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDecoderProfile (Guid* pDecoderProfile) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDecoderProfile (ptr, pDecoderProfile);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDecoderProfile (out Guid pDecoderProfile) {
		fixed (Guid* _pDecoderProfile = &pDecoderProfile) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDecoderProfile (ptr, _pDecoderProfile);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCertificateSize (uint* pCertificateSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCertificateSize (ptr, pCertificateSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCertificateSize (out uint pCertificateSize) {
		fixed (uint* _pCertificateSize = &pCertificateSize) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCertificateSize (ptr, _pCertificateSize);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCertificate (uint certificateSize, byte* pCertificate) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCertificate (ptr, certificateSize, pCertificate);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetCryptoSessionHandle (IntPtr* pCryptoSessionHandle) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetCryptoSessionHandle (ptr, pCryptoSessionHandle);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetCryptoSessionHandle (out IntPtr pCryptoSessionHandle) {
		fixed (IntPtr* _pCryptoSessionHandle = &pCryptoSessionHandle) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetCryptoSessionHandle (ptr, _pCryptoSessionHandle);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, void> GetCryptoType;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, void> GetDecoderProfile;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetCertificateSize;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, byte*, int> GetCertificate;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, IntPtr*, void> GetCryptoSessionHandle;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
