using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11RefDefaultTrackingOptions</b> : IUnknown<br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public interface IRefDefaultTrackingOptions : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11RefDefaultTrackingOptions::SetTrackingOptions (UINT ResourceTypeFlags, UINT Options)</b><br/>
	/// </summary>
	/// <param name="resourceTypeFlags"><b>UINT ResourceTypeFlags</b></param>
	/// <param name="options"><b>UINT Options</b></param>
	int SetTrackingOptions (uint resourceTypeFlags, uint options);
}

/// <summary>
/// Instance of <b>ID3D11RefDefaultTrackingOptions</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public readonly struct RefDefaultTrackingOptions : IRefDefaultTrackingOptions {
//unsafe public readonly struct IRefDefaultTrackingOptionsObj : IRefDefaultTrackingOptions {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly RefDefaultTrackingOptions* GetCurrentPointer () => (RefDefaultTrackingOptions*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IRefDefaultTrackingOptionsObj* GetCurrentPointer () => (IRefDefaultTrackingOptionsObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x03916615, 0xc644, 0x418c, 0x9b, 0xf4, 0x75, 0xdb, 0x5b, 0xe6, 0x3c, 0xa0);

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
	public readonly int SetTrackingOptions (uint resourceTypeFlags, uint options) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTrackingOptions (ptr, resourceTypeFlags, options);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, int> SetTrackingOptions;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
