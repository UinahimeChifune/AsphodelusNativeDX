using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIDebug</b> : IUnknown<br/>
/// DXGIDEBUG.h
/// </summary>
unsafe public interface IDebug : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIDebug::ReportLiveObjects (GUID apiid, DXGI_DEBUG_RLO_FLAGS flags)</b><br/>
	/// </summary>
	/// <param name="apiid"><b>GUID apiid</b></param>
	/// <param name="flags"><b>DXGI_DEBUG_RLO_FLAGS flags</b></param>
	int ReportLiveObjects (Guid apiid, DebugRloFlags flags);
}

/// <summary>
/// Instance of <b>IDXGIDebug</b><br/>
/// DXGIDEBUG.h
/// </summary>
unsafe public readonly struct Debug : IDebug {
//unsafe public readonly struct IDebugObj : IDebug {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Debug* GetCurrentPointer () => (Debug*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDebugObj* GetCurrentPointer () => (IDebugObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x119e7452, 0xde9e, 0x40fe, 0x88, 0x06, 0x88, 0xf9, 0x0c, 0x12, 0xb4, 0x41);

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
	public readonly int ReportLiveObjects (Guid apiid, DebugRloFlags flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReportLiveObjects (ptr, apiid, flags);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, DebugRloFlags, int> ReportLiveObjects;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
