using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11TracingDevice</b> : IUnknown<br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public interface ITracingDevice : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11TracingDevice::SetShaderTrackingOptionsByType (UINT ResourceTypeFlags, UINT Options)</b><br/>
	/// </summary>
	/// <param name="resourceTypeFlags">_In_ <b>UINT ResourceTypeFlags</b></param>
	/// <param name="options">_In_ <b>UINT Options</b></param>
	int SetShaderTrackingOptionsByType (uint resourceTypeFlags, uint options);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D11TracingDevice::SetShaderTrackingOptions (IUnknown* pShader, UINT Options)</b><br/>
	/// </summary>
	/// <param name="pShader">_In_ <b>IUnknown* pShader</b></param>
	/// <param name="options">_In_ <b>UINT Options</b></param>
	int SetShaderTrackingOptions<T0> (T0* pShader, uint options) where T0 : unmanaged, IUnknown;
}

/// <summary>
/// Instance of <b>ID3D11TracingDevice</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public readonly struct TracingDevice : ITracingDevice {
//unsafe public readonly struct ITracingDeviceObj : ITracingDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TracingDevice* GetCurrentPointer () => (TracingDevice*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITracingDeviceObj* GetCurrentPointer () => (ITracingDeviceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1911c771, 0x1587, 0x413e, 0xa7, 0xe0, 0xfb, 0x26, 0xc3, 0xde, 0x02, 0x68);

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
	public readonly int SetShaderTrackingOptionsByType (uint resourceTypeFlags, uint options) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetShaderTrackingOptionsByType (ptr, resourceTypeFlags, options);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetShaderTrackingOptions<T0> (T0* pShader, uint options) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetShaderTrackingOptions (ptr, pShader, options);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, int> SetShaderTrackingOptionsByType;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, int> SetShaderTrackingOptions;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
