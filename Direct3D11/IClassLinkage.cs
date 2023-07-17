using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11ClassLinkage</b> : ID3D11DeviceChild<br/>
/// D3D11.h
/// </summary>
unsafe public interface IClassLinkage : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11ClassLinkage::GetClassInstance (LPCSTR pClassInstanceName, UINT InstanceIndex, ID3D11ClassInstance** ppInstance)</b><br/>
	/// </summary>
	/// <param name="pClassInstanceName">_In_ <b>LPCSTR pClassInstanceName</b></param>
	/// <param name="instanceIndex">_In_ <b>UINT InstanceIndex</b></param>
	/// <param name="ppInstance">_COM_Outptr_ <b>ID3D11ClassInstance** ppInstance</b></param>
	int GetClassInstance<T0> (char* pClassInstanceName, uint instanceIndex, T0** ppInstance) where T0 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11ClassLinkage::GetClassInstance (LPCSTR pClassInstanceName, UINT InstanceIndex, ID3D11ClassInstance** ppInstance)</b><br/>
	/// </summary>
	/// <param name="pClassInstanceName">_In_ <b>LPCSTR pClassInstanceName</b></param>
	/// <param name="instanceIndex">_In_ <b>UINT InstanceIndex</b></param>
	/// <param name="ppInstance">_COM_Outptr_ <b>ID3D11ClassInstance** ppInstance</b></param>
	int GetClassInstance<T0> (char* pClassInstanceName, uint instanceIndex, out T0* ppInstance) where T0 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11ClassLinkage::CreateClassInstance (LPCSTR pClassTypeName, UINT ConstantBufferOffset, UINT ConstantVectorOffset, UINT TextureOffset, UINT SamplerOffset, ID3D11ClassInstance** ppInstance)</b><br/>
	/// </summary>
	/// <param name="pClassTypeName">_In_ <b>LPCSTR pClassTypeName</b></param>
	/// <param name="constantBufferOffset">_In_ <b>UINT ConstantBufferOffset</b></param>
	/// <param name="constantVectorOffset">_In_ <b>UINT ConstantVectorOffset</b></param>
	/// <param name="textureOffset">_In_ <b>UINT TextureOffset</b></param>
	/// <param name="samplerOffset">_In_ <b>UINT SamplerOffset</b></param>
	/// <param name="ppInstance">_COM_Outptr_ <b>ID3D11ClassInstance** ppInstance</b></param>
	int CreateClassInstance<T0> (char* pClassTypeName, uint constantBufferOffset, uint constantVectorOffset, uint textureOffset, uint samplerOffset, T0** ppInstance) where T0 : unmanaged, IClassInstance;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11ClassLinkage::CreateClassInstance (LPCSTR pClassTypeName, UINT ConstantBufferOffset, UINT ConstantVectorOffset, UINT TextureOffset, UINT SamplerOffset, ID3D11ClassInstance** ppInstance)</b><br/>
	/// </summary>
	/// <param name="pClassTypeName">_In_ <b>LPCSTR pClassTypeName</b></param>
	/// <param name="constantBufferOffset">_In_ <b>UINT ConstantBufferOffset</b></param>
	/// <param name="constantVectorOffset">_In_ <b>UINT ConstantVectorOffset</b></param>
	/// <param name="textureOffset">_In_ <b>UINT TextureOffset</b></param>
	/// <param name="samplerOffset">_In_ <b>UINT SamplerOffset</b></param>
	/// <param name="ppInstance">_COM_Outptr_ <b>ID3D11ClassInstance** ppInstance</b></param>
	int CreateClassInstance<T0> (char* pClassTypeName, uint constantBufferOffset, uint constantVectorOffset, uint textureOffset, uint samplerOffset, out T0* ppInstance) where T0 : unmanaged, IClassInstance;
}

/// <summary>
/// Instance of <b>ID3D11ClassLinkage</b><br/>
/// D3D11.h
/// </summary>
unsafe public readonly struct ClassLinkage : IClassLinkage {
//unsafe public readonly struct IClassLinkageObj : IClassLinkage {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ClassLinkage* GetCurrentPointer () => (ClassLinkage*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IClassLinkageObj* GetCurrentPointer () => (IClassLinkageObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xddf57cba, 0x9543, 0x46e4, 0xa1, 0x2b, 0xf2, 0x07, 0xa0, 0xfe, 0x7f, 0xed);

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
	public readonly int GetClassInstance<T0> (char* pClassInstanceName, uint instanceIndex, T0** ppInstance) where T0 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetClassInstance (ptr, pClassInstanceName, instanceIndex, (void**) ppInstance);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClassInstance<T0> (char* pClassInstanceName, uint instanceIndex, out T0* ppInstance) where T0 : unmanaged, IClassInstance {
		fixed (T0** _ppInstance = &ppInstance) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetClassInstance (ptr, pClassInstanceName, instanceIndex, (void**) _ppInstance);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateClassInstance<T0> (char* pClassTypeName, uint constantBufferOffset, uint constantVectorOffset, uint textureOffset, uint samplerOffset, T0** ppInstance) where T0 : unmanaged, IClassInstance {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateClassInstance (ptr, pClassTypeName, constantBufferOffset, constantVectorOffset, textureOffset, samplerOffset, (void**) ppInstance);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateClassInstance<T0> (char* pClassTypeName, uint constantBufferOffset, uint constantVectorOffset, uint textureOffset, uint samplerOffset, out T0* ppInstance) where T0 : unmanaged, IClassInstance {
		fixed (T0** _ppInstance = &ppInstance) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateClassInstance (ptr, pClassTypeName, constantBufferOffset, constantVectorOffset, textureOffset, samplerOffset, (void**) _ppInstance);
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
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, void**, int> GetClassInstance;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, uint, uint, uint, void**, int> CreateClassInstance;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
