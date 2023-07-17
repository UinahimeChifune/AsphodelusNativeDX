using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12StateObjectProperties</b> : IUnknown<br/>
/// D3D12.h
/// </summary>
unsafe public interface IStateObjectProperties : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void* ID3D12StateObjectProperties::GetShaderIdentifier (LPCWSTR pExportName)</b><br/>
	/// </summary>
	/// <param name="pExportName">_In_ <b>LPCWSTR pExportName</b></param>
	void* GetShaderIdentifier (char* pExportName);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12StateObjectProperties::GetShaderStackSize (LPCWSTR pExportName)</b><br/>
	/// </summary>
	/// <param name="pExportName">_In_ <b>LPCWSTR pExportName</b></param>
	ulong GetShaderStackSize (char* pExportName);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12StateObjectProperties::GetPipelineStackSize ()</b><br/>
	/// </summary>
	ulong GetPipelineStackSize ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12StateObjectProperties::SetPipelineStackSize (UINT64 PipelineStackSizeInBytes)</b><br/>
	/// </summary>
	/// <param name="pipelineStackSizeInBytes"><b>UINT64 PipelineStackSizeInBytes</b></param>
	void SetPipelineStackSize (ulong pipelineStackSizeInBytes);
}

/// <summary>
/// Instance of <b>ID3D12StateObjectProperties</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct StateObjectProperties : IStateObjectProperties {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly StateObjectProperties* GetCurrentPointer () => (StateObjectProperties*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xde5fa827, 0x9bf9, 0x4f26, 0x89, 0xff, 0xd7, 0xf5, 0x6f, 0xde, 0x38, 0x60);

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
	public readonly void* GetShaderIdentifier (char* pExportName) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetShaderIdentifier (ptr, pExportName);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetShaderStackSize (char* pExportName) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetShaderStackSize (ptr, pExportName);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetPipelineStackSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPipelineStackSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetPipelineStackSize (ulong pipelineStackSizeInBytes) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetPipelineStackSize (ptr, pipelineStackSizeInBytes);
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
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*> GetShaderIdentifier;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, ulong> GetShaderStackSize;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetPipelineStackSize;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, void> SetPipelineStackSize;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
