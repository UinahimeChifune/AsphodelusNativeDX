using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12CompatibilityDevice</b> : IUnknown<br/>
/// D3D12COMPATIBILITY.h
/// </summary>
unsafe public interface ICompatibilityDevice : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CompatibilityDevice::CreateSharedResource (D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, D3D11_RESOURCE_FLAGS* pFlags11, D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags, ID3D12LifetimeTracker* pLifetimeTracker, ID3D12SwapChainAssistant* pOwningSwapchain, REFIID riid, void** ppResource)</b><br/>
	/// </summary>
	/// <param name="pHeapProperties">_In_ <b>D3D12_HEAP_PROPERTIES* pHeapProperties</b></param>
	/// <param name="heapFlags"><b>D3D12_HEAP_FLAGS HeapFlags</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialResourceState"><b>D3D12_RESOURCE_STATES InitialResourceState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="pFlags11">_In_opt_ <b>D3D11_RESOURCE_FLAGS* pFlags11</b></param>
	/// <param name="compatibilityFlags"><b>D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags</b></param>
	/// <param name="pLifetimeTracker">_In_opt_ <b>ID3D12LifetimeTracker* pLifetimeTracker</b></param>
	/// <param name="pOwningSwapchain">_In_opt_ <b>ID3D12SwapChainAssistant* pOwningSwapchain</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppResource">_COM_Outptr_opt_ <b>void** ppResource</b></param>
	int CreateSharedResource<T0, T1> (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Direct3D11.ResourceFlags* pFlags11, CompatibilitySharedFlags compatibilityFlags, T0* pLifetimeTracker, T1* pOwningSwapchain, Guid riid, void** ppResource) where T0 : unmanaged, ILifetimeTracker where T1 : unmanaged, ISwapChainAssistant;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CompatibilityDevice::CreateSharedResource (D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, D3D11_RESOURCE_FLAGS* pFlags11, D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags, ID3D12LifetimeTracker* pLifetimeTracker, ID3D12SwapChainAssistant* pOwningSwapchain, REFIID riid, void** ppResource)</b><br/>
	/// </summary>
	/// <param name="pHeapProperties">_In_ <b>D3D12_HEAP_PROPERTIES* pHeapProperties</b></param>
	/// <param name="heapFlags"><b>D3D12_HEAP_FLAGS HeapFlags</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_RESOURCE_DESC* pDesc</b></param>
	/// <param name="initialResourceState"><b>D3D12_RESOURCE_STATES InitialResourceState</b></param>
	/// <param name="pOptimizedClearValue">_In_opt_ <b>D3D12_CLEAR_VALUE* pOptimizedClearValue</b></param>
	/// <param name="pFlags11">_In_opt_ <b>D3D11_RESOURCE_FLAGS* pFlags11</b></param>
	/// <param name="compatibilityFlags"><b>D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags</b></param>
	/// <param name="pLifetimeTracker">_In_opt_ <b>ID3D12LifetimeTracker* pLifetimeTracker</b></param>
	/// <param name="pOwningSwapchain">_In_opt_ <b>ID3D12SwapChainAssistant* pOwningSwapchain</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppResource">_COM_Outptr_opt_ <b>void** ppResource</b></param>
	int CreateSharedResource<T0, T1> (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Direct3D11.ResourceFlags* pFlags11, CompatibilitySharedFlags compatibilityFlags, T0* pLifetimeTracker, T1* pOwningSwapchain, Guid riid, out void* ppResource) where T0 : unmanaged, ILifetimeTracker where T1 : unmanaged, ISwapChainAssistant;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CompatibilityDevice::CreateSharedHeap (D3D12_HEAP_DESC* pHeapDesc, D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags, REFIID riid, void** ppHeap)</b><br/>
	/// </summary>
	/// <param name="pHeapDesc">_In_ <b>D3D12_HEAP_DESC* pHeapDesc</b></param>
	/// <param name="compatibilityFlags"><b>D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppHeap">_COM_Outptr_opt_ <b>void** ppHeap</b></param>
	int CreateSharedHeap (HeapDesc* pHeapDesc, CompatibilitySharedFlags compatibilityFlags, Guid riid, void** ppHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CompatibilityDevice::CreateSharedHeap (D3D12_HEAP_DESC* pHeapDesc, D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags, REFIID riid, void** ppHeap)</b><br/>
	/// </summary>
	/// <param name="pHeapDesc">_In_ <b>D3D12_HEAP_DESC* pHeapDesc</b></param>
	/// <param name="compatibilityFlags"><b>D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppHeap">_COM_Outptr_opt_ <b>void** ppHeap</b></param>
	int CreateSharedHeap (HeapDesc* pHeapDesc, CompatibilitySharedFlags compatibilityFlags, Guid riid, out void* ppHeap);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12CompatibilityDevice::ReflectSharedProperties (ID3D12Object* pHeapOrResource, D3D12_REFLECT_SHARED_PROPERTY ReflectType, void* pData, UINT DataSize)</b><br/>
	/// </summary>
	/// <param name="pHeapOrResource">_In_ <b>ID3D12Object* pHeapOrResource</b></param>
	/// <param name="reflectType"><b>D3D12_REFLECT_SHARED_PROPERTY ReflectType</b></param>
	/// <param name="pData">_Out_writes_bytes_(DataSize) <b>void* pData</b></param>
	/// <param name="dataSize"><b>UINT DataSize</b></param>
	int ReflectSharedProperties<T0> (T0* pHeapOrResource, ReflectSharedProperty reflectType, void* pData, uint dataSize) where T0 : unmanaged, IObject;
}

/// <summary>
/// Instance of <b>ID3D12CompatibilityDevice</b><br/>
/// D3D12COMPATIBILITY.h
/// </summary>
unsafe public readonly struct CompatibilityDevice : ICompatibilityDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly CompatibilityDevice* GetCurrentPointer () => (CompatibilityDevice*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x8f1c0e3c, 0xfae3, 0x4a82, 0xb0, 0x98, 0xbf, 0xe1, 0x70, 0x82, 0x07, 0xff);

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
	public readonly int CreateSharedResource<T0, T1> (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Direct3D11.ResourceFlags* pFlags11, CompatibilitySharedFlags compatibilityFlags, T0* pLifetimeTracker, T1* pOwningSwapchain, Guid riid, void** ppResource) where T0 : unmanaged, ILifetimeTracker where T1 : unmanaged, ISwapChainAssistant {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedResource (ptr, pHeapProperties, heapFlags, pDesc, initialResourceState, pOptimizedClearValue, pFlags11, compatibilityFlags, pLifetimeTracker, pOwningSwapchain, riid, ppResource);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedResource<T0, T1> (HeapProperties* pHeapProperties, HeapFlags heapFlags, ResourceDesc* pDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Direct3D11.ResourceFlags* pFlags11, CompatibilitySharedFlags compatibilityFlags, T0* pLifetimeTracker, T1* pOwningSwapchain, Guid riid, out void* ppResource) where T0 : unmanaged, ILifetimeTracker where T1 : unmanaged, ISwapChainAssistant {
		fixed (void** _ppResource = &ppResource) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedResource (ptr, pHeapProperties, heapFlags, pDesc, initialResourceState, pOptimizedClearValue, pFlags11, compatibilityFlags, pLifetimeTracker, pOwningSwapchain, riid, _ppResource);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedHeap (HeapDesc* pHeapDesc, CompatibilitySharedFlags compatibilityFlags, Guid riid, void** ppHeap) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedHeap (ptr, pHeapDesc, compatibilityFlags, riid, ppHeap);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateSharedHeap (HeapDesc* pHeapDesc, CompatibilitySharedFlags compatibilityFlags, Guid riid, out void* ppHeap) {
		fixed (void** _ppHeap = &ppHeap) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateSharedHeap (ptr, pHeapDesc, compatibilityFlags, riid, _ppHeap);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReflectSharedProperties<T0> (T0* pHeapOrResource, ReflectSharedProperty reflectType, void* pData, uint dataSize) where T0 : unmanaged, IObject {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReflectSharedProperties (ptr, pHeapOrResource, reflectType, pData, dataSize);
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
		public readonly delegate* unmanaged[Stdcall]<void*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Direct3D11.ResourceFlags*, CompatibilitySharedFlags, void*, void*, Guid, void**, int> CreateSharedResource;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, HeapDesc*, CompatibilitySharedFlags, Guid, void**, int> CreateSharedHeap;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ReflectSharedProperty, void*, uint, int> ReflectSharedProperties;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
