using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12Debug1</b> : IUnknown<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebug1 : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Debug1::EnableDebugLayer ()</b><br/>
	/// </summary>
	void EnableDebugLayer ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Debug1::SetEnableGPUBasedValidation (BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="enable"><b>BOOL Enable</b></param>
	void SetEnableGPUBasedValidation (bool enable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Debug1::SetEnableSynchronizedCommandQueueValidation (BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="enable"><b>BOOL Enable</b></param>
	void SetEnableSynchronizedCommandQueueValidation (bool enable);
}

/// <summary>
/// Instance of <b>ID3D12Debug1</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct Debug1 : IDebug1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Debug1* GetCurrentPointer () => (Debug1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xaffaa4ca, 0x63fe, 0x4d8e, 0xb8, 0xad, 0x15, 0x90, 0x00, 0xaf, 0x43, 0x04);

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
	public readonly void EnableDebugLayer () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EnableDebugLayer (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetEnableGPUBasedValidation (bool enable) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetEnableGPUBasedValidation (ptr, enable ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetEnableSynchronizedCommandQueueValidation (bool enable) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetEnableSynchronizedCommandQueueValidation (ptr, enable ? 1U : 0U);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void> EnableDebugLayer;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetEnableGPUBasedValidation;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetEnableSynchronizedCommandQueueValidation;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
