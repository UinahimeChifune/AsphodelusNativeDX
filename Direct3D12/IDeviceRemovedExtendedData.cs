using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DeviceRemovedExtendedData</b> : IUnknown<br/>
/// D3D12.h
/// </summary>
unsafe public interface IDeviceRemovedExtendedData : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData::GetAutoBreadcrumbsOutput (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput</b></param>
	int GetAutoBreadcrumbsOutput (DredAutoBreadcrumbsOutput* pOutput);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData::GetAutoBreadcrumbsOutput (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput</b></param>
	int GetAutoBreadcrumbsOutput (out DredAutoBreadcrumbsOutput pOutput);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData::GetPageFaultAllocationOutput (D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput</b></param>
	int GetPageFaultAllocationOutput (DredPageFaultOutput* pOutput);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData::GetPageFaultAllocationOutput (D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput</b></param>
	int GetPageFaultAllocationOutput (out DredPageFaultOutput pOutput);
}

/// <summary>
/// Instance of <b>ID3D12DeviceRemovedExtendedData</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct DeviceRemovedExtendedData : IDeviceRemovedExtendedData {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DeviceRemovedExtendedData* GetCurrentPointer () => (DeviceRemovedExtendedData*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x98931d33, 0x5ae8, 0x4791, 0xaa, 0x3c, 0x1a, 0x73, 0xa2, 0x93, 0x4e, 0x71);

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
	public readonly int GetAutoBreadcrumbsOutput (DredAutoBreadcrumbsOutput* pOutput) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAutoBreadcrumbsOutput (ptr, pOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAutoBreadcrumbsOutput (out DredAutoBreadcrumbsOutput pOutput) {
		fixed (DredAutoBreadcrumbsOutput* _pOutput = &pOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAutoBreadcrumbsOutput (ptr, _pOutput);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPageFaultAllocationOutput (DredPageFaultOutput* pOutput) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPageFaultAllocationOutput (ptr, pOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPageFaultAllocationOutput (out DredPageFaultOutput pOutput) {
		fixed (DredPageFaultOutput* _pOutput = &pOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPageFaultAllocationOutput (ptr, _pOutput);
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
		public readonly delegate* unmanaged[Stdcall]<void*, DredAutoBreadcrumbsOutput*, int> GetAutoBreadcrumbsOutput;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DredPageFaultOutput*, int> GetPageFaultAllocationOutput;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
