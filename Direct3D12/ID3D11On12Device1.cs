using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D11On12Device1</b> : ID3D11On12Device<br/>
/// D3D11ON12.h
/// </summary>
unsafe public interface ID3D11On12Device1 : ID3D11On12Device {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11On12Device1::GetD3D12Device (REFIID riid, void** ppvDevice)</b><br/>
	/// </summary>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvDevice">_COM_Outptr_ <b>void** ppvDevice</b></param>
	int GetD3D12Device (Guid riid, void** ppvDevice);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11On12Device1::GetD3D12Device (REFIID riid, void** ppvDevice)</b><br/>
	/// </summary>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvDevice">_COM_Outptr_ <b>void** ppvDevice</b></param>
	int GetD3D12Device (Guid riid, out void* ppvDevice);
}

/// <summary>
/// Instance of <b>ID3D11On12Device1</b><br/>
/// D3D11ON12.h
/// </summary>
unsafe public readonly struct D3D11On12Device1 : ID3D11On12Device1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly D3D11On12Device1* GetCurrentPointer () => (D3D11On12Device1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xbdb64df4, 0xea2f, 0x4c70, 0xb8, 0x61, 0xaa, 0xab, 0x12, 0x58, 0xbb, 0x5d);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
