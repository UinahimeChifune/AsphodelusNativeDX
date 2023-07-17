using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12DebugCommandList</b> : IUnknown<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebugCommandList : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D12DebugCommandList::AssertResourceState (ID3D12Resource* pResource, UINT Subresource, UINT State)</b><br/>
	/// </summary>
	/// <param name="pResource">_In_ <b>ID3D12Resource* pResource</b></param>
	/// <param name="subresource"><b>UINT Subresource</b></param>
	/// <param name="state"><b>UINT State</b></param>
	bool AssertResourceState<T0> (T0* pResource, uint subresource, uint state) where T0 : unmanaged, IResource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12DebugCommandList::SetFeatureMask (D3D12_DEBUG_FEATURE Mask)</b><br/>
	/// </summary>
	/// <param name="mask"><b>D3D12_DEBUG_FEATURE Mask</b></param>
	int SetFeatureMask (DebugFeature mask);
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_DEBUG_FEATURE ID3D12DebugCommandList::GetFeatureMask ()</b><br/>
	/// </summary>
	DebugFeature GetFeatureMask ();
}

/// <summary>
/// Instance of <b>ID3D12DebugCommandList</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct DebugCommandList : IDebugCommandList {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DebugCommandList* GetCurrentPointer () => (DebugCommandList*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x09e0bf36, 0x54ac, 0x484f, 0x88, 0x47, 0x4b, 0xae, 0xea, 0xb6, 0x05, 0x3f);

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
	public readonly bool AssertResourceState<T0> (T0* pResource, uint subresource, uint state) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AssertResourceState (ptr, pResource, subresource, state) != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, uint> AssertResourceState;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugFeature, int> SetFeatureMask;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DebugFeature> GetFeatureMask;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
