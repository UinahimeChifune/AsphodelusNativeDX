using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12Resource</b> : ID3D12Pageable<br/>
/// D3D12.h
/// </summary>
unsafe public interface IResource : IPageable {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Resource::Map (UINT Subresource, D3D12_RANGE* pReadRange, void** ppData)</b><br/>
	/// </summary>
	/// <param name="subresource"><b>UINT Subresource</b></param>
	/// <param name="pReadRange">_In_opt_ <b>D3D12_RANGE* pReadRange</b></param>
	/// <param name="ppData">_Outptr_opt_result_bytebuffer_(_Inexpressible_("Dependent on resource")) <b>void** ppData</b></param>
	int Map (uint subresource, Range* pReadRange, void** ppData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Resource::Map (UINT Subresource, D3D12_RANGE* pReadRange, void** ppData)</b><br/>
	/// </summary>
	/// <param name="subresource"><b>UINT Subresource</b></param>
	/// <param name="pReadRange">_In_opt_ <b>D3D12_RANGE* pReadRange</b></param>
	/// <param name="ppData">_Outptr_opt_result_bytebuffer_(_Inexpressible_("Dependent on resource")) <b>void** ppData</b></param>
	int Map (uint subresource, Range* pReadRange, out void* ppData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Resource::Unmap (UINT Subresource, D3D12_RANGE* pWrittenRange)</b><br/>
	/// </summary>
	/// <param name="subresource"><b>UINT Subresource</b></param>
	/// <param name="pWrittenRange">_In_opt_ <b>D3D12_RANGE* pWrittenRange</b></param>
	void Unmap (uint subresource, Range* pWrittenRange);
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_RESOURCE_DESC ID3D12Resource::GetDesc ()</b><br/>
	/// </summary>
	ResourceDesc GetDesc ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_GPU_VIRTUAL_ADDRESS ID3D12Resource::GetGPUVirtualAddress ()</b><br/>
	/// </summary>
	ulong GetGPUVirtualAddress ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Resource::WriteToSubresource (UINT DstSubresource, D3D12_BOX* pDstBox, void* pSrcData, UINT SrcRowPitch, UINT SrcDepthPitch)</b><br/>
	/// </summary>
	/// <param name="dstSubresource"><b>UINT DstSubresource</b></param>
	/// <param name="pDstBox">_In_opt_ <b>D3D12_BOX* pDstBox</b></param>
	/// <param name="pSrcData">_In_ <b>void* pSrcData</b></param>
	/// <param name="srcRowPitch"><b>UINT SrcRowPitch</b></param>
	/// <param name="srcDepthPitch"><b>UINT SrcDepthPitch</b></param>
	int WriteToSubresource (uint dstSubresource, Box* pDstBox, void* pSrcData, uint srcRowPitch, uint srcDepthPitch);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Resource::ReadFromSubresource (void* pDstData, UINT DstRowPitch, UINT DstDepthPitch, UINT SrcSubresource, D3D12_BOX* pSrcBox)</b><br/>
	/// </summary>
	/// <param name="pDstData">_Out_ <b>void* pDstData</b></param>
	/// <param name="dstRowPitch"><b>UINT DstRowPitch</b></param>
	/// <param name="dstDepthPitch"><b>UINT DstDepthPitch</b></param>
	/// <param name="srcSubresource"><b>UINT SrcSubresource</b></param>
	/// <param name="pSrcBox">_In_opt_ <b>D3D12_BOX* pSrcBox</b></param>
	int ReadFromSubresource (void* pDstData, uint dstRowPitch, uint dstDepthPitch, uint srcSubresource, Box* pSrcBox);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Resource::GetHeapProperties (D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS* pHeapFlags)</b><br/>
	/// </summary>
	/// <param name="pHeapProperties">_Out_opt_ <b>D3D12_HEAP_PROPERTIES* pHeapProperties</b></param>
	/// <param name="pHeapFlags">_Out_opt_ <b>D3D12_HEAP_FLAGS* pHeapFlags</b></param>
	int GetHeapProperties (HeapProperties* pHeapProperties, HeapFlags* pHeapFlags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12Resource::GetHeapProperties (D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS* pHeapFlags)</b><br/>
	/// </summary>
	/// <param name="pHeapProperties">_Out_opt_ <b>D3D12_HEAP_PROPERTIES* pHeapProperties</b></param>
	/// <param name="pHeapFlags">_Out_opt_ <b>D3D12_HEAP_FLAGS* pHeapFlags</b></param>
	int GetHeapProperties (out HeapProperties pHeapProperties, out HeapFlags pHeapFlags);
}

/// <summary>
/// Instance of <b>ID3D12Resource</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct Resource : IResource {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Resource* GetCurrentPointer () => (Resource*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x696442be, 0xa72e, 0x4059, 0xbc, 0x79, 0x5b, 0x5c, 0x98, 0x04, 0x0f, 0xad);

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
	public readonly int SetName (char* name) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetName (ptr, name);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDevice (Guid riid, void** ppvDevice) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, ppvDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDevice (Guid riid, out void* ppvDevice) {
		fixed (void** _ppvDevice = &ppvDevice) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, _ppvDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Map (uint subresource, Range* pReadRange, void** ppData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, subresource, pReadRange, ppData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Map (uint subresource, Range* pReadRange, out void* ppData) {
		fixed (void** _ppData = &ppData) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, subresource, pReadRange, _ppData);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Unmap (uint subresource, Range* pWrittenRange) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Unmap (ptr, subresource, pWrittenRange);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ResourceDesc GetDesc () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetGPUVirtualAddress () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGPUVirtualAddress (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int WriteToSubresource (uint dstSubresource, Box* pDstBox, void* pSrcData, uint srcRowPitch, uint srcDepthPitch) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WriteToSubresource (ptr, dstSubresource, pDstBox, pSrcData, srcRowPitch, srcDepthPitch);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReadFromSubresource (void* pDstData, uint dstRowPitch, uint dstDepthPitch, uint srcSubresource, Box* pSrcBox) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReadFromSubresource (ptr, pDstData, dstRowPitch, dstDepthPitch, srcSubresource, pSrcBox);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetHeapProperties (HeapProperties* pHeapProperties, HeapFlags* pHeapFlags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetHeapProperties (ptr, pHeapProperties, pHeapFlags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetHeapProperties (out HeapProperties pHeapProperties, out HeapFlags pHeapFlags) {
		fixed (HeapProperties* _pHeapProperties = &pHeapProperties) {
			fixed (HeapFlags* _pHeapFlags = &pHeapFlags) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetHeapProperties (ptr, _pHeapProperties, _pHeapFlags);
				return hr;
			}
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> SetName;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetDevice;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Range*, void**, int> Map;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Range*, void> Unmap;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ResourceDesc> GetDesc;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetGPUVirtualAddress;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Box*, void*, uint, uint, int> WriteToSubresource;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint, Box*, int> ReadFromSubresource;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, HeapProperties*, HeapFlags*, int> GetHeapProperties;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
