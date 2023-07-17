using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VersionedRootSignatureDeserializer</b> : IUnknown<br/>
/// D3D12.h
/// </summary>
unsafe public interface IVersionedRootSignatureDeserializer : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VersionedRootSignatureDeserializer::GetRootSignatureDescAtVersion (D3D_ROOT_SIGNATURE_VERSION convertToVersion, D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc)</b><br/>
	/// </summary>
	/// <param name="convertToVersion"><b>D3D_ROOT_SIGNATURE_VERSION convertToVersion</b></param>
	/// <param name="ppDesc">_Out_ <b>D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc</b></param>
	int GetRootSignatureDescAtVersion (Direct3D.RootSignatureVersion convertToVersion, VersionedRootSignatureDesc** ppDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VersionedRootSignatureDeserializer::GetRootSignatureDescAtVersion (D3D_ROOT_SIGNATURE_VERSION convertToVersion, D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc)</b><br/>
	/// </summary>
	/// <param name="convertToVersion"><b>D3D_ROOT_SIGNATURE_VERSION convertToVersion</b></param>
	/// <param name="ppDesc">_Out_ <b>D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc</b></param>
	int GetRootSignatureDescAtVersion (Direct3D.RootSignatureVersion convertToVersion, out VersionedRootSignatureDesc* ppDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_VERSIONED_ROOT_SIGNATURE_DESC* ID3D12VersionedRootSignatureDeserializer::GetUnconvertedRootSignatureDesc ()</b><br/>
	/// </summary>
	VersionedRootSignatureDesc* GetUnconvertedRootSignatureDesc ();
}

/// <summary>
/// Instance of <b>ID3D12VersionedRootSignatureDeserializer</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct VersionedRootSignatureDeserializer : IVersionedRootSignatureDeserializer {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VersionedRootSignatureDeserializer* GetCurrentPointer () => (VersionedRootSignatureDeserializer*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x7f91ce67, 0x090c, 0x4bb7, 0xb7, 0x8e, 0xed, 0x8f, 0xf2, 0xe3, 0x1d, 0xa0);

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
	public readonly int GetRootSignatureDescAtVersion (Direct3D.RootSignatureVersion convertToVersion, VersionedRootSignatureDesc** ppDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRootSignatureDescAtVersion (ptr, convertToVersion, ppDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRootSignatureDescAtVersion (Direct3D.RootSignatureVersion convertToVersion, out VersionedRootSignatureDesc* ppDesc) {
		fixed (VersionedRootSignatureDesc** _ppDesc = &ppDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetRootSignatureDescAtVersion (ptr, convertToVersion, _ppDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly VersionedRootSignatureDesc* GetUnconvertedRootSignatureDesc () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetUnconvertedRootSignatureDesc (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Direct3D.RootSignatureVersion, VersionedRootSignatureDesc**, int> GetRootSignatureDescAtVersion;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VersionedRootSignatureDesc*> GetUnconvertedRootSignatureDesc;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
