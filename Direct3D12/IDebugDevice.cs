using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DebugDevice</b> : IUnknown<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebugDevice : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugDevice::SetFeatureMask (D3D12_DEBUG_FEATURE Mask)</b><br/>
	/// </summary>
	/// <param name="mask"><b>D3D12_DEBUG_FEATURE Mask</b></param>
	int SetFeatureMask (DebugFeature mask);
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_DEBUG_FEATURE ID3D12DebugDevice::GetFeatureMask ()</b><br/>
	/// </summary>
	DebugFeature GetFeatureMask ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugDevice::ReportLiveDeviceObjects (D3D12_RLDO_FLAGS Flags)</b><br/>
	/// </summary>
	/// <param name="flags"><b>D3D12_RLDO_FLAGS Flags</b></param>
	int ReportLiveDeviceObjects (RldoFlags flags);
}

/// <summary>
/// Instance of <b>ID3D12DebugDevice</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct DebugDevice : IDebugDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DebugDevice* GetCurrentPointer () => (DebugDevice*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3febd6dd, 0x4973, 0x4787, 0x81, 0x94, 0xe4, 0x5f, 0x9e, 0x28, 0x92, 0x3e);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
