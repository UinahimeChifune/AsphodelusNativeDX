using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12Debug3</b> : ID3D12Debug<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IDebug3 : IDebug {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Debug3::SetEnableGPUBasedValidation (BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="enable"><b>BOOL Enable</b></param>
	void SetEnableGPUBasedValidation (bool enable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Debug3::SetEnableSynchronizedCommandQueueValidation (BOOL Enable)</b><br/>
	/// </summary>
	/// <param name="enable"><b>BOOL Enable</b></param>
	void SetEnableSynchronizedCommandQueueValidation (bool enable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12Debug3::SetGPUBasedValidationFlags (D3D12_GPU_BASED_VALIDATION_FLAGS Flags)</b><br/>
	/// </summary>
	/// <param name="flags"><b>D3D12_GPU_BASED_VALIDATION_FLAGS Flags</b></param>
	void SetGPUBasedValidationFlags (GpuBasedValidationFlags flags);
}

/// <summary>
/// Instance of <b>ID3D12Debug3</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct Debug3 : IDebug3 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Debug3* GetCurrentPointer () => (Debug3*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x5cf4e58f, 0xf671, 0x4ff1, 0xa5, 0x42, 0x36, 0x86, 0xe3, 0xd1, 0x53, 0xd1);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
