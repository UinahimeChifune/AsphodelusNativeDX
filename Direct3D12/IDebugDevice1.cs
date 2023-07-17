using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DebugDevice1</b> : IUnknown<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebugDevice1 : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugDevice1::SetDebugParameter (D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, UINT DataSize)</b><br/>
	/// </summary>
	/// <param name="type"><b>D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type</b></param>
	/// <param name="pData">_In_reads_bytes_(DataSize) <b>void* pData</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	int SetDebugParameter (DebugDeviceParameterType type, void* pData, uint dataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugDevice1::GetDebugParameter (D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, UINT DataSize)</b><br/>
	/// </summary>
	/// <param name="type"><b>D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type</b></param>
	/// <param name="pData">_Out_writes_bytes_(DataSize) <b>void* pData</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	int GetDebugParameter (DebugDeviceParameterType type, void* pData, uint dataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugDevice1::ReportLiveDeviceObjects (D3D12_RLDO_FLAGS Flags)</b><br/>
	/// </summary>
	/// <param name="flags"><b>D3D12_RLDO_FLAGS Flags</b></param>
	int ReportLiveDeviceObjects (RldoFlags flags);
}

/// <summary>
/// Instance of <b>ID3D12DebugDevice1</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct DebugDevice1 : IDebugDevice1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DebugDevice1* GetCurrentPointer () => (DebugDevice1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa9b71770, 0xd099, 0x4a65, 0xa6, 0x98, 0x3d, 0xee, 0x10, 0x02, 0x0f, 0x88);

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
	public readonly int SetDebugParameter (DebugDeviceParameterType type, void* pData, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetDebugParameter (ptr, type, pData, dataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDebugParameter (DebugDeviceParameterType type, void* pData, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDebugParameter (ptr, type, pData, dataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReportLiveDeviceObjects (RldoFlags flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReportLiveDeviceObjects (ptr, flags);
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
		public readonly delegate* unmanaged[Stdcall]<void*, DebugDeviceParameterType, void*, uint, int> SetDebugParameter;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugDeviceParameterType, void*, uint, int> GetDebugParameter;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RldoFlags, int> ReportLiveDeviceObjects;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
