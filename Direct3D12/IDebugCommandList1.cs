using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DebugCommandList1</b> : IUnknown<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebugCommandList1 : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D12DebugCommandList1::AssertResourceState (ID3D12Resource* pResource, UINT Subresource, UINT State)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="subresource"><b>UINT Subresource</b></param>
	/// <param name="state"><b>UINT State</b></param>
	bool AssertResourceState<T0> (T0* pResource, uint subresource, uint state) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugCommandList1::SetDebugParameter (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, UINT DataSize)</b><br/>
	/// </summary>
	/// <param name="type"><b>D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type</b></param>
	/// <param name="pData">_In_reads_bytes_(DataSize) <b>void* pData</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	int SetDebugParameter (DebugCommandListParameterType type, void* pData, uint dataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugCommandList1::GetDebugParameter (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, UINT DataSize)</b><br/>
	/// </summary>
	/// <param name="type"><b>D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type</b></param>
	/// <param name="pData">_Out_writes_bytes_(DataSize) <b>void* pData</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	int GetDebugParameter (DebugCommandListParameterType type, void* pData, uint dataSize);
}

/// <summary>
/// Instance of <b>ID3D12DebugCommandList1</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct DebugCommandList1 : IDebugCommandList1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DebugCommandList1* GetCurrentPointer () => (DebugCommandList1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x102ca951, 0x311b, 0x4b01, 0xb1, 0x1f, 0xec, 0xb8, 0x3e, 0x06, 0x1b, 0x37);

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
	public readonly bool AssertResourceState<T0> (T0* pResource, uint subresource, uint state) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AssertResourceState (ptr, pResource, subresource, state) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetDebugParameter (DebugCommandListParameterType type, void* pData, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetDebugParameter (ptr, type, pData, dataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDebugParameter (DebugCommandListParameterType type, void* pData, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDebugParameter (ptr, type, pData, dataSize);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint> AssertResourceState;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugCommandListParameterType, void*, uint, int> SetDebugParameter;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugCommandListParameterType, void*, uint, int> GetDebugParameter;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
