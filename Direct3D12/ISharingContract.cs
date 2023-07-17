using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12SharingContract</b> : IUnknown<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface ISharingContract : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12SharingContract::Present (ID3D12Resource* pResource, UINT Subresource, HWND window)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="subresource"><b>UINT Subresource</b></param>
	/// <param name="window">_In_ <b>HWND window</b></param>
	void Present<T0> (T0* pResource, uint subresource, IntPtr window) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12SharingContract::SharedFenceSignal (ID3D12Fence* pFence, UINT64 FenceValue)</b><br/>
	/// </summary>
	/// <param name="pFence">_In_ <b>ID3D12Fence* pFence</b></param>
	/// <param name="fenceValue"><b>UINT64 FenceValue</b></param>
	void SharedFenceSignal<T0> (T0* pFence, ulong fenceValue) where T0 : unmanaged, IFence;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12SharingContract::BeginCapturableWork (REFGUID guid)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	void BeginCapturableWork (Guid guid);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12SharingContract::EndCapturableWork (REFGUID guid)</b><br/>
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	void EndCapturableWork (Guid guid);
}

/// <summary>
/// Instance of <b>ID3D12SharingContract</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct SharingContract : ISharingContract {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SharingContract* GetCurrentPointer () => (SharingContract*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x0adf7d52, 0x929c, 0x4e61, 0xad, 0xdb, 0xff, 0xed, 0x30, 0xde, 0x66, 0xef);

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
	public readonly void Present<T0> (T0* pResource, uint subresource, IntPtr window) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Present (ptr, pResource, subresource, window);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SharedFenceSignal<T0> (T0* pFence, ulong fenceValue) where T0 : unmanaged, IFence {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SharedFenceSignal (ptr, pFence, fenceValue);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void BeginCapturableWork (Guid guid) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->BeginCapturableWork (ptr, guid);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void EndCapturableWork (Guid guid) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EndCapturableWork (ptr, guid);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, IntPtr, void> Present;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, void> SharedFenceSignal;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void> BeginCapturableWork;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void> EndCapturableWork;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
