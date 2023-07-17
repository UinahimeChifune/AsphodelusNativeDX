using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D11On12Device2</b> : ID3D11On12Device1<br/>
/// D3D11ON12.h
/// </summary>
unsafe public interface ID3D11On12Device2 : ID3D11On12Device1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11On12Device2::UnwrapUnderlyingResource (ID3D11Resource* pResource11, ID3D12CommandQueue* pCommandQueue, REFIID riid, void** ppvResource12)</b><br/>
	/// </summary>
	/// <param name="pResource11">_In_ <b>ID3D11Resource* pResource11</b></param>
	/// <param name="pCommandQueue">_In_ <b>ID3D12CommandQueue* pCommandQueue</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvResource12">_COM_Outptr_ <b>void** ppvResource12</b></param>
	int UnwrapUnderlyingResource<T0, T1> (T0* pResource11, T1* pCommandQueue, Guid riid, void** ppvResource12) where T0 : unmanaged, Direct3D11.IResource where T1 : unmanaged, ICommandQueue;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11On12Device2::UnwrapUnderlyingResource (ID3D11Resource* pResource11, ID3D12CommandQueue* pCommandQueue, REFIID riid, void** ppvResource12)</b><br/>
	/// </summary>
	/// <param name="pResource11">_In_ <b>ID3D11Resource* pResource11</b></param>
	/// <param name="pCommandQueue">_In_ <b>ID3D12CommandQueue* pCommandQueue</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvResource12">_COM_Outptr_ <b>void** ppvResource12</b></param>
	int UnwrapUnderlyingResource<T0, T1> (T0* pResource11, T1* pCommandQueue, Guid riid, out void* ppvResource12) where T0 : unmanaged, Direct3D11.IResource where T1 : unmanaged, ICommandQueue;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11On12Device2::ReturnUnderlyingResource (ID3D11Resource* pResource11, UINT NumSync, UINT64* pSignalValues, ID3D12Fence** ppFences)</b><br/>
	/// </summary>
	/// <param name="pResource11">_In_ <b>ID3D11Resource* pResource11</b></param>
	/// <param name="numSync"><b>UINT NumSync</b></param>
	/// <param name="pSignalValues">_In_reads_(NumSync) <b>UINT64* pSignalValues</b></param>
	/// <param name="ppFences">_In_reads_(NumSync) <b>ID3D12Fence** ppFences</b></param>
	int ReturnUnderlyingResource<T0, T1> (T0* pResource11, uint numSync, ulong* pSignalValues, T1** ppFences) where T0 : unmanaged, Direct3D11.IResource where T1 : unmanaged, IFence;
}

/// <summary>
/// Instance of <b>ID3D11On12Device2</b><br/>
/// D3D11ON12.h
/// </summary>
unsafe public readonly struct D3D11On12Device2 : ID3D11On12Device2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly D3D11On12Device2* GetCurrentPointer () => (D3D11On12Device2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xdc90f331, 0x4740, 0x43fa, 0x86, 0x6e, 0x67, 0xf1, 0x2c, 0xb5, 0x82, 0x23);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetD3D12Device (Guid riid, void** ppvDevice) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetD3D12Device (ptr, riid, ppvDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetD3D12Device (Guid riid, out void* ppvDevice) {
		fixed (void** _ppvDevice = &ppvDevice) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetD3D12Device (ptr, riid, _ppvDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnwrapUnderlyingResource<T0, T1> (T0* pResource11, T1* pCommandQueue, Guid riid, void** ppvResource12) where T0 : unmanaged, Direct3D11.IResource where T1 : unmanaged, ICommandQueue {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnwrapUnderlyingResource (ptr, pResource11, pCommandQueue, riid, ppvResource12);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnwrapUnderlyingResource<T0, T1> (T0* pResource11, T1* pCommandQueue, Guid riid, out void* ppvResource12) where T0 : unmanaged, Direct3D11.IResource where T1 : unmanaged, ICommandQueue {
		fixed (void** _ppvResource12 = &ppvResource12) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->UnwrapUnderlyingResource (ptr, pResource11, pCommandQueue, riid, _ppvResource12);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReturnUnderlyingResource<T0, T1> (T0* pResource11, uint numSync, ulong* pSignalValues, T1** ppFences) where T0 : unmanaged, Direct3D11.IResource where T1 : unmanaged, IFence {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReturnUnderlyingResource (ptr, pResource11, numSync, pSignalValues, (void**) ppFences);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Direct3D11.ResourceFlags*, ResourceStates, ResourceStates, Guid, void**, int> CreateWrappedResource;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> ReleaseWrappedResources;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, void> AcquireWrappedResources;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetD3D12Device;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, Guid, void**, int> UnwrapUnderlyingResource;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, ulong*, void**, int> ReturnUnderlyingResource;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
