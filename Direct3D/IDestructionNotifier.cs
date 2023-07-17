using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D;

/// <summary>
/// INTERFACE <b>ID3DDestructionNotifier</b> : IUnknown<br/>
/// D3DCOMMON.h
/// </summary>
unsafe public interface IDestructionNotifier : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3DDestructionNotifier::RegisterDestructionCallback (PFN_DESTRUCTION_CALLBACK callbackFn, void* pData, UINT* pCallbackID)</b><br/>
	/// </summary>
	/// <param name="callbackFn">_In_ <b>PFN_DESTRUCTION_CALLBACK callbackFn</b></param>
	/// <param name="pData">_In_ <b>void* pData</b></param>
	/// <param name="pCallbackID">_Out_ <b>UINT* pCallbackID</b></param>
	int RegisterDestructionCallback (Destruction callbackFn, void* pData, uint* pCallbackID);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3DDestructionNotifier::RegisterDestructionCallback (PFN_DESTRUCTION_CALLBACK callbackFn, void* pData, UINT* pCallbackID)</b><br/>
	/// </summary>
	/// <param name="callbackFn">_In_ <b>PFN_DESTRUCTION_CALLBACK callbackFn</b></param>
	/// <param name="pData">_In_ <b>void* pData</b></param>
	/// <param name="pCallbackID">_Out_ <b>UINT* pCallbackID</b></param>
	int RegisterDestructionCallback (Destruction callbackFn, void* pData, out uint pCallbackID);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3DDestructionNotifier::UnregisterDestructionCallback (UINT callbackID)</b><br/>
	/// </summary>
	/// <param name="callbackID">_In_ <b>UINT callbackID</b></param>
	int UnregisterDestructionCallback (uint callbackID);
}

/// <summary>
/// Instance of <b>ID3DDestructionNotifier</b><br/>
/// D3DCOMMON.h
/// </summary>
unsafe public readonly struct DestructionNotifier : IDestructionNotifier {
//unsafe public readonly struct IDestructionNotifierObj : IDestructionNotifier {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DestructionNotifier* GetCurrentPointer () => (DestructionNotifier*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDestructionNotifierObj* GetCurrentPointer () => (IDestructionNotifierObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa06eb39a, 0x50da, 0x425b, 0x8c, 0x31, 0x4e, 0xec, 0xd6, 0xc2, 0x70, 0xf3);

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
	public readonly int RegisterDestructionCallback (Destruction callbackFn, void* pData, uint* pCallbackID) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterDestructionCallback (ptr, (void*) Marshal.GetFunctionPointerForDelegate (callbackFn), pData, pCallbackID);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RegisterDestructionCallback (Destruction callbackFn, void* pData, out uint pCallbackID) {
		fixed (uint* _pCallbackID = &pCallbackID) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->RegisterDestructionCallback (ptr, (void*) Marshal.GetFunctionPointerForDelegate (callbackFn), pData, _pCallbackID);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnregisterDestructionCallback (uint callbackID) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnregisterDestructionCallback (ptr, callbackID);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint*, int> RegisterDestructionCallback;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> UnregisterDestructionCallback;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
