using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DeviceRemovedExtendedDataSettings</b> : IUnknown<br/>
/// D3D12.h
/// </summary>
unsafe public interface IDeviceRemovedExtendedDataSettings : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12DeviceRemovedExtendedDataSettings::SetAutoBreadcrumbsEnablement (D3D12_DRED_ENABLEMENT Enablement)</b><br/>
	/// </summary>
	/// <param name="enablement"><b>D3D12_DRED_ENABLEMENT Enablement</b></param>
	void SetAutoBreadcrumbsEnablement (DredEnablement enablement);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12DeviceRemovedExtendedDataSettings::SetPageFaultEnablement (D3D12_DRED_ENABLEMENT Enablement)</b><br/>
	/// </summary>
	/// <param name="enablement"><b>D3D12_DRED_ENABLEMENT Enablement</b></param>
	void SetPageFaultEnablement (DredEnablement enablement);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12DeviceRemovedExtendedDataSettings::SetWatsonDumpEnablement (D3D12_DRED_ENABLEMENT Enablement)</b><br/>
	/// </summary>
	/// <param name="enablement"><b>D3D12_DRED_ENABLEMENT Enablement</b></param>
	void SetWatsonDumpEnablement (DredEnablement enablement);
}

/// <summary>
/// Instance of <b>ID3D12DeviceRemovedExtendedDataSettings</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct DeviceRemovedExtendedDataSettings : IDeviceRemovedExtendedDataSettings {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DeviceRemovedExtendedDataSettings* GetCurrentPointer () => (DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x82bc481c, 0x6b9b, 0x4030, 0xae, 0xdb, 0x7e, 0xe3, 0xd1, 0xdf, 0x1e, 0x63);

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
	public readonly void SetAutoBreadcrumbsEnablement (DredEnablement enablement) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetAutoBreadcrumbsEnablement (ptr, enablement);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetPageFaultEnablement (DredEnablement enablement) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetPageFaultEnablement (ptr, enablement);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetWatsonDumpEnablement (DredEnablement enablement) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetWatsonDumpEnablement (ptr, enablement);
		return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, DredEnablement, void> SetAutoBreadcrumbsEnablement;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DredEnablement, void> SetPageFaultEnablement;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DredEnablement, void> SetWatsonDumpEnablement;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
