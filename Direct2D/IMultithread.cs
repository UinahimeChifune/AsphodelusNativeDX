using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Multithread</b> : IUnknown<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IMultithread : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1Multithread::GetMultithreadProtected ()</b><br/>
	/// </summary>
	bool GetMultithreadProtected ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Multithread::Enter ()</b><br/>
	/// </summary>
	void Enter ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Multithread::Leave ()</b><br/>
	/// </summary>
	void Leave ();
}

/// <summary>
/// Instance of <b>ID2D1Multithread</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct Multithread : IMultithread {
//unsafe public readonly struct IMultithreadObj : IMultithread {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Multithread* GetCurrentPointer () => (Multithread*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMultithreadObj* GetCurrentPointer () => (IMultithreadObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x31e6e7bc, 0xe0ff, 0x4d46, 0x8c, 0x64, 0xa0, 0xa8, 0xc4, 0x1c, 0x15, 0xd3);

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
	public readonly bool GetMultithreadProtected () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMultithreadProtected (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Enter () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Enter (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Leave () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Leave (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetMultithreadProtected;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> Enter;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> Leave;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
