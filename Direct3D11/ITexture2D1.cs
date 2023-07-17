using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11Texture2D1</b> : ID3D11Texture2D<br/>
/// D3D11_3.h
/// </summary>
unsafe public interface ITexture2D1 : ITexture2D {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Texture2D1::GetDesc1 (D3D11_TEXTURE2D_DESC1* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_TEXTURE2D_DESC1* pDesc</b></param>
	void GetDesc1 (Texture2dDesc1* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Texture2D1::GetDesc1 (D3D11_TEXTURE2D_DESC1* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>D3D11_TEXTURE2D_DESC1* pDesc</b></param>
	void GetDesc1 (out Texture2dDesc1 pDesc);
}

/// <summary>
/// Instance of <b>ID3D11Texture2D1</b><br/>
/// D3D11_3.h
/// </summary>
unsafe public readonly struct Texture2D1 : ITexture2D1 {
//unsafe public readonly struct ITexture2D1Obj : ITexture2D1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Texture2D1* GetCurrentPointer () => (Texture2D1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITexture2D1Obj* GetCurrentPointer () => (ITexture2D1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x51218251, 0x1e33, 0x4617, 0x9c, 0xcb, 0x4d, 0x3a, 0x43, 0x67, 0xe7, 0xbb);

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
	public readonly void GetType (ResourceDimension* pResourceDimension) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->_GetType (ptr, pResourceDimension);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetType (out ResourceDimension pResourceDimension) {
		fixed (ResourceDimension* _pResourceDimension = &pResourceDimension) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->_GetType (ptr, _pResourceDimension);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetEvictionPriority (uint evictionPriority) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetEvictionPriority (ptr, evictionPriority);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetEvictionPriority () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEvictionPriority (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (Texture2dDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc (out Texture2dDesc pDesc) {
		fixed (Texture2dDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, _pDesc);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc1 (Texture2dDesc1* pDesc) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDesc1 (ptr, pDesc);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDesc1 (out Texture2dDesc1 pDesc) {
		fixed (Texture2dDesc1* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDesc1 (ptr, _pDesc);
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
		public readonly delegate* unmanaged[Stdcall]<void*, ResourceDimension*, void> _GetType;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetEvictionPriority;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetEvictionPriority;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Texture2dDesc*, void> GetDesc;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Texture2dDesc1*, void> GetDesc1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
