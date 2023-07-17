using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D11On12Device</b> : IUnknown<br/>
/// D3D11ON12.h
/// </summary>
unsafe public interface ID3D11On12Device : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11On12Device::CreateWrappedResource (IUnknown* pResource12, D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, REFIID riid, void** ppResource11)</b><br/>
	/// </summary>
	/// <param name="pResource12">_In_ <b>IUnknown* pResource12</b></param>
	/// <param name="pFlags11">_In_ <b>D3D11_RESOURCE_FLAGS* pFlags11</b></param>
	/// <param name="inState"><b>D3D12_RESOURCE_STATES InState</b></param>
	/// <param name="outState"><b>D3D12_RESOURCE_STATES OutState</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppResource11">_COM_Outptr_opt_ <b>void** ppResource11</b></param>
	int CreateWrappedResource<T0> (T0* pResource12, Direct3D11.ResourceFlags* pFlags11, ResourceStates inState, ResourceStates outState, Guid riid, void** ppResource11) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11On12Device::CreateWrappedResource (IUnknown* pResource12, D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, REFIID riid, void** ppResource11)</b><br/>
	/// </summary>
	/// <param name="pResource12">_In_ <b>IUnknown* pResource12</b></param>
	/// <param name="pFlags11">_In_ <b>D3D11_RESOURCE_FLAGS* pFlags11</b></param>
	/// <param name="inState"><b>D3D12_RESOURCE_STATES InState</b></param>
	/// <param name="outState"><b>D3D12_RESOURCE_STATES OutState</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppResource11">_COM_Outptr_opt_ <b>void** ppResource11</b></param>
	int CreateWrappedResource<T0> (T0* pResource12, Direct3D11.ResourceFlags* pFlags11, ResourceStates inState, ResourceStates outState, Guid riid, out void* ppResource11) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11On12Device::ReleaseWrappedResources (ID3D11Resource* ppResources, UINT NumResources)</b><br/>
	/// </summary>
	/// <param name="ppResources">_In_reads_( NumResources ) <b>ID3D11Resource* ppResources</b></param>
	/// <param name="numResources"><b>UINT NumResources</b></param>
	void ReleaseWrappedResources<T0> (T0* ppResources, uint numResources) where T0 : unmanaged, Direct3D11.IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11On12Device::AcquireWrappedResources (ID3D11Resource* ppResources, UINT NumResources)</b><br/>
	/// </summary>
	/// <param name="ppResources">_In_reads_( NumResources ) <b>ID3D11Resource* ppResources</b></param>
	/// <param name="numResources"><b>UINT NumResources</b></param>
	void AcquireWrappedResources<T0> (T0* ppResources, uint numResources) where T0 : unmanaged, Direct3D11.IResource;
}

/// <summary>
/// Instance of <b>ID3D11On12Device</b><br/>
/// D3D11ON12.h
/// </summary>
unsafe public readonly struct D3D11On12Device : ID3D11On12Device {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly D3D11On12Device* GetCurrentPointer () => (D3D11On12Device*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x85611e73, 0x70a9, 0x490e, 0x96, 0x14, 0xa9, 0xe3, 0x02, 0x77, 0x79, 0x04);

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
	public readonly int CreateWrappedResource<T0> (T0* pResource12, Direct3D11.ResourceFlags* pFlags11, ResourceStates inState, ResourceStates outState, Guid riid, void** ppResource11) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateWrappedResource (ptr, pResource12, pFlags11, inState, outState, riid, ppResource11);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateWrappedResource<T0> (T0* pResource12, Direct3D11.ResourceFlags* pFlags11, ResourceStates inState, ResourceStates outState, Guid riid, out void* ppResource11) where T0 : unmanaged, IUnknown {
		fixed (void** _ppResource11 = &ppResource11) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateWrappedResource (ptr, pResource12, pFlags11, inState, outState, riid, _ppResource11);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ReleaseWrappedResources<T0> (T0* ppResources, uint numResources) where T0 : unmanaged, Direct3D11.IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ReleaseWrappedResources (ptr, ppResources, numResources);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void AcquireWrappedResources<T0> (T0* ppResources, uint numResources) where T0 : unmanaged, Direct3D11.IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AcquireWrappedResources (ptr, ppResources, numResources);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Direct3D11.ResourceFlags*, ResourceStates, ResourceStates, Guid, void**, int> CreateWrappedResource;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> ReleaseWrappedResources;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> AcquireWrappedResources;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
