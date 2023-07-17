using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11SwitchToRef</b> : IUnknown<br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public interface ISwitchToRef : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D11SwitchToRef::SetUseRef (BOOL UseRef)</b><br/>
	/// </summary>
	/// <param name="useRef"><b>BOOL UseRef</b></param>
	bool SetUseRef (bool useRef);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D11SwitchToRef::GetUseRef ()</b><br/>
	/// </summary>
	bool GetUseRef ();
}

/// <summary>
/// Instance of <b>ID3D11SwitchToRef</b><br/>
/// D3D11SDKLAYERS.h
/// </summary>
unsafe public readonly struct SwitchToRef : ISwitchToRef {
//unsafe public readonly struct ISwitchToRefObj : ISwitchToRef {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SwitchToRef* GetCurrentPointer () => (SwitchToRef*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISwitchToRefObj* GetCurrentPointer () => (ISwitchToRefObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1ef337e3, 0x58e7, 0x4f83, 0xa6, 0x92, 0xdb, 0x22, 0x1f, 0x5e, 0xd4, 0x7e);

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
	public readonly bool SetUseRef (bool useRef) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetUseRef (ptr, useRef ? 1U : 0U) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetUseRef () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetUseRef (ptr) != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> SetUseRef;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetUseRef;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
