using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12SwapChainAssistant</b> : IUnknown<br/>
/// D3D12.h
/// </summary>
unsafe public interface ISwapChainAssistant : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>LUID ID3D12SwapChainAssistant::GetLUID ()</b><br/>
	/// </summary>
	LUID GetLUID ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12SwapChainAssistant::GetSwapChainObject (REFIID riid, void** ppv)</b><br/>
	/// </summary>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppv">_COM_Outptr_ <b>void** ppv</b></param>
	int GetSwapChainObject (Guid riid, void** ppv);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12SwapChainAssistant::GetSwapChainObject (REFIID riid, void** ppv)</b><br/>
	/// </summary>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppv">_COM_Outptr_ <b>void** ppv</b></param>
	int GetSwapChainObject (Guid riid, out void* ppv);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12SwapChainAssistant::GetCurrentResourceAndCommandQueue (REFIID riidResource, void** ppvResource, REFIID riidQueue, void** ppvQueue)</b><br/>
	/// </summary>
	/// <param name="riidResource"><b>REFIID riidResource</b></param>
	/// <param name="ppvResource">_COM_Outptr_ <b>void** ppvResource</b></param>
	/// <param name="riidQueue"><b>REFIID riidQueue</b></param>
	/// <param name="ppvQueue">_COM_Outptr_ <b>void** ppvQueue</b></param>
	int GetCurrentResourceAndCommandQueue (Guid riidResource, void** ppvResource, Guid riidQueue, void** ppvQueue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12SwapChainAssistant::GetCurrentResourceAndCommandQueue (REFIID riidResource, void** ppvResource, REFIID riidQueue, void** ppvQueue)</b><br/>
	/// </summary>
	/// <param name="riidResource"><b>REFIID riidResource</b></param>
	/// <param name="ppvResource">_COM_Outptr_ <b>void** ppvResource</b></param>
	/// <param name="riidQueue"><b>REFIID riidQueue</b></param>
	/// <param name="ppvQueue">_COM_Outptr_ <b>void** ppvQueue</b></param>
	int GetCurrentResourceAndCommandQueue (Guid riidResource, out void* ppvResource, Guid riidQueue, out void* ppvQueue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12SwapChainAssistant::InsertImplicitSync ()</b><br/>
	/// </summary>
	int InsertImplicitSync ();
}

/// <summary>
/// Instance of <b>ID3D12SwapChainAssistant</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct SwapChainAssistant : ISwapChainAssistant {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SwapChainAssistant* GetCurrentPointer () => (SwapChainAssistant*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xf1df64b6, 0x57fd, 0x49cd, 0x88, 0x07, 0xc0, 0xeb, 0x88, 0xb4, 0x5c, 0x8f);

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
	public readonly LUID GetLUID () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLUID (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSwapChainObject (Guid riid, void** ppv) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSwapChainObject (ptr, riid, ppv);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSwapChainObject (Guid riid, out void* ppv) {
		fixed (void** _ppv = &ppv) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSwapChainObject (ptr, riid, _ppv);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentResourceAndCommandQueue (Guid riidResource, void** ppvResource, Guid riidQueue, void** ppvQueue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentResourceAndCommandQueue (ptr, riidResource, ppvResource, riidQueue, ppvQueue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentResourceAndCommandQueue (Guid riidResource, out void* ppvResource, Guid riidQueue, out void* ppvQueue) {
		fixed (void** _ppvResource = &ppvResource) {
			fixed (void** _ppvQueue = &ppvQueue) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentResourceAndCommandQueue (ptr, riidResource, _ppvResource, riidQueue, _ppvQueue);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InsertImplicitSync () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InsertImplicitSync (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, LUID> GetLUID;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetSwapChainObject;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, Guid, void**, int> GetCurrentResourceAndCommandQueue;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> InsertImplicitSync;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
