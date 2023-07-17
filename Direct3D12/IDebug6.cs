using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12Debug6</b> : ID3D12Debug5<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebug6 : IDebug5 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Debug6::SetForceLegacyBarrierValidation (BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="enable"><b>BOOL Enable</b></param>
	void SetForceLegacyBarrierValidation (bool enable);
}

/// <summary>
/// Instance of <b>ID3D12Debug6</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct Debug6 : IDebug6 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Debug6* GetCurrentPointer () => (Debug6*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x82a816d6, 0x5d01, 0x4157, 0x97, 0xd0, 0x49, 0x75, 0x46, 0x3f, 0xd1, 0xed);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetGPUBasedValidationFlags (GpuBasedValidationFlags flags) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetGPUBasedValidationFlags (ptr, flags);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DisableDebugLayer () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DisableDebugLayer (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetEnableAutoName (bool enable) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetEnableAutoName (ptr, enable ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetForceLegacyBarrierValidation (bool enable) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetForceLegacyBarrierValidation (ptr, enable ? 1U : 0U);
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
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GpuBasedValidationFlags, void> SetGPUBasedValidationFlags;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> DisableDebugLayer;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetEnableAutoName;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetForceLegacyBarrierValidation;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
