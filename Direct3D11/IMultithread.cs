using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// INTERFACE <b>ID3D11Multithread</b> : IUnknown<br/>
/// D3D11_4.h
/// </summary>
unsafe public interface IMultithread : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Multithread::Enter ()</b><br/>
	/// </summary>
	void Enter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D11Multithread::Leave ()</b><br/>
	/// </summary>
	void Leave ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D11Multithread::SetMultithreadProtected (BOOL bMTProtect)</b><br/>
	/// </summary>
	/// <param name="bMTProtect">_In_ <b>BOOL bMTProtect</b></param>
	bool SetMultithreadProtected (bool bMTProtect);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D11Multithread::GetMultithreadProtected ()</b><br/>
	/// </summary>
	bool GetMultithreadProtected ();
}

/// <summary>
/// Instance of <b>ID3D11Multithread</b><br/>
/// D3D11_4.h
/// </summary>
unsafe public readonly struct Multithread : IMultithread {
//unsafe public readonly struct IMultithreadObj : IMultithread {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Multithread* GetCurrentPointer () => (Multithread*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IMultithreadObj* GetCurrentPointer () => (IMultithreadObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9b7e4e00, 0x342c, 0x4106, 0xa1, 0x9f, 0x4f, 0x27, 0x04, 0xf6, 0x89, 0xf0);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool SetMultithreadProtected (bool bMTProtect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetMultithreadProtected (ptr, bMTProtect ? 1U : 0U) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetMultithreadProtected () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMultithreadProtected (ptr) != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void> Enter;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> Leave;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> SetMultithreadProtected;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetMultithreadProtected;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
