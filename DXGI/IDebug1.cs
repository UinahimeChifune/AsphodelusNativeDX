using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIDebug1</b> : IDXGIDebug<br/>
/// DXGIDEBUG.h
/// </summary>
unsafe public interface IDebug1 : IDebug {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIDebug1::EnableLeakTrackingForThread ()</b><br/>
	/// </summary>
	void EnableLeakTrackingForThread ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIDebug1::DisableLeakTrackingForThread ()</b><br/>
	/// </summary>
	void DisableLeakTrackingForThread ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL IDXGIDebug1::IsLeakTrackingEnabledForThread ()</b><br/>
	/// </summary>
	bool IsLeakTrackingEnabledForThread ();
}

/// <summary>
/// Instance of <b>IDXGIDebug1</b><br/>
/// DXGIDEBUG.h
/// </summary>
unsafe public readonly struct Debug1 : IDebug1 {
//unsafe public readonly struct IDebug1Obj : IDebug1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Debug1* GetCurrentPointer () => (Debug1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDebug1Obj* GetCurrentPointer () => (IDebug1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc5a05f0c, 0x16f2, 0x4adf, 0x9f, 0x4d, 0xa8, 0xc4, 0xd5, 0x8a, 0xc5, 0x50);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void EnableLeakTrackingForThread () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->EnableLeakTrackingForThread (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void DisableLeakTrackingForThread () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DisableLeakTrackingForThread (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsLeakTrackingEnabledForThread () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsLeakTrackingEnabledForThread (ptr) != 0;
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
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> EnableLeakTrackingForThread;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> DisableLeakTrackingForThread;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsLeakTrackingEnabledForThread;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
