using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DebugDevice2</b> : ID3D12DebugDevice<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebugDevice2 : IDebugDevice {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugDevice2::SetDebugParameter (D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, UINT DataSize)</b><br/>
	/// </summary>
	/// <param name="type"><b>D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type</b></param>
	/// <param name="pData">_In_reads_bytes_(DataSize) <b>void* pData</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	int SetDebugParameter (DebugDeviceParameterType type, void* pData, uint dataSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugDevice2::GetDebugParameter (D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, UINT DataSize)</b><br/>
	/// </summary>
	/// <param name="type"><b>D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type</b></param>
	/// <param name="pData">_Out_writes_bytes_(DataSize) <b>void* pData</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	int GetDebugParameter (DebugDeviceParameterType type, void* pData, uint dataSize);
}

/// <summary>
/// Instance of <b>ID3D12DebugDevice2</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct DebugDevice2 : IDebugDevice2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DebugDevice2* GetCurrentPointer () => (DebugDevice2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x60eccbc1, 0x378d, 0x4df1, 0x89, 0x4c, 0xf8, 0xac, 0x5c, 0xe4, 0xd7, 0xdd);

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
	public readonly int SetFeatureMask (DebugFeature mask) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFeatureMask (ptr, mask);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly DebugFeature GetFeatureMask () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFeatureMask (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReportLiveDeviceObjects (RldoFlags flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReportLiveDeviceObjects (ptr, flags);
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
		public readonly delegate* unmanaged[Stdcall]<void*, DebugFeature, int> SetFeatureMask;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugFeature> GetFeatureMask;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RldoFlags, int> ReportLiveDeviceObjects;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugDeviceParameterType, void*, uint, int> SetDebugParameter;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugDeviceParameterType, void*, uint, int> GetDebugParameter;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
