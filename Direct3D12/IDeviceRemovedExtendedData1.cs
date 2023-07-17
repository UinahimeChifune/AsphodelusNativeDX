using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DeviceRemovedExtendedData1</b> : ID3D12DeviceRemovedExtendedData<br/>
/// D3D12.h
/// </summary>
unsafe public interface IDeviceRemovedExtendedData1 : IDeviceRemovedExtendedData {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData1::GetAutoBreadcrumbsOutput1 (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1* pOutput</b></param>
	int GetAutoBreadcrumbsOutput1 (DredAutoBreadcrumbsOutput1* pOutput);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData1::GetAutoBreadcrumbsOutput1 (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1* pOutput</b></param>
	int GetAutoBreadcrumbsOutput1 (out DredAutoBreadcrumbsOutput1 pOutput);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData1::GetPageFaultAllocationOutput1 (D3D12_DRED_PAGE_FAULT_OUTPUT1* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_PAGE_FAULT_OUTPUT1* pOutput</b></param>
	int GetPageFaultAllocationOutput1 (DredPageFaultOutput1* pOutput);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DeviceRemovedExtendedData1::GetPageFaultAllocationOutput1 (D3D12_DRED_PAGE_FAULT_OUTPUT1* pOutput)</b><br/>
	/// </summary>
	/// <param name="pOutput">_Out_ <b>D3D12_DRED_PAGE_FAULT_OUTPUT1* pOutput</b></param>
	int GetPageFaultAllocationOutput1 (out DredPageFaultOutput1 pOutput);
}

/// <summary>
/// Instance of <b>ID3D12DeviceRemovedExtendedData1</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct DeviceRemovedExtendedData1 : IDeviceRemovedExtendedData1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DeviceRemovedExtendedData1* GetCurrentPointer () => (DeviceRemovedExtendedData1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9727a022, 0xcf1d, 0x4dda, 0x9e, 0xba, 0xef, 0xfa, 0x65, 0x3f, 0xc5, 0x06);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAutoBreadcrumbsOutput1 (DredAutoBreadcrumbsOutput1* pOutput) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAutoBreadcrumbsOutput1 (ptr, pOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAutoBreadcrumbsOutput1 (out DredAutoBreadcrumbsOutput1 pOutput) {
		fixed (DredAutoBreadcrumbsOutput1* _pOutput = &pOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAutoBreadcrumbsOutput1 (ptr, _pOutput);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPageFaultAllocationOutput1 (DredPageFaultOutput1* pOutput) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPageFaultAllocationOutput1 (ptr, pOutput);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPageFaultAllocationOutput1 (out DredPageFaultOutput1 pOutput) {
		fixed (DredPageFaultOutput1* _pOutput = &pOutput) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPageFaultAllocationOutput1 (ptr, _pOutput);
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
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DredAutoBreadcrumbsOutput1*, int> GetAutoBreadcrumbsOutput1;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DredPageFaultOutput1*, int> GetPageFaultAllocationOutput1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
