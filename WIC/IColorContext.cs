using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICColorContext</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IColorContext : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::InitializeFromFilename (LPCWSTR wzFilename)</b><br/>
	/// </summary>
	/// <param name="wzFilename">__RPC__in <b>LPCWSTR wzFilename</b></param>
	int InitializeFromFilename (char* wzFilename);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::InitializeFromMemory (BYTE* pbBuffer, UINT cbBufferSize)</b><br/>
	/// </summary>
	/// <param name="pbBuffer">__RPC__in_ecount_full(cbBufferSize) <b>BYTE* pbBuffer</b></param>
	/// <param name="cbBufferSize"><b>UINT cbBufferSize</b></param>
	int InitializeFromMemory (byte* pbBuffer, uint cbBufferSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::InitializeFromExifColorSpace (UINT value)</b><br/>
	/// </summary>
	/// <param name="value"><b>UINT value</b></param>
	int InitializeFromExifColorSpace (uint value);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::GetType (WICColorContextType* pType)</b><br/>
	/// </summary>
	/// <param name="pType">__RPC__out <b>WICColorContextType* pType</b></param>
	int GetType (ColorContextType* pType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::GetType (WICColorContextType* pType)</b><br/>
	/// </summary>
	/// <param name="pType">__RPC__out <b>WICColorContextType* pType</b></param>
	int GetType (out ColorContextType pType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::GetProfileBytes (UINT cbBuffer, BYTE* pbBuffer, UINT* pcbActual)</b><br/>
	/// </summary>
	/// <param name="cbBuffer"><b>UINT cbBuffer</b></param>
	/// <param name="pbBuffer">__RPC__inout_ecount_full_opt(cbBuffer) <b>BYTE* pbBuffer</b></param>
	/// <param name="pcbActual">__RPC__out <b>UINT* pcbActual</b></param>
	int GetProfileBytes (uint cbBuffer, byte* pbBuffer, uint* pcbActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::GetProfileBytes (UINT cbBuffer, BYTE* pbBuffer, UINT* pcbActual)</b><br/>
	/// </summary>
	/// <param name="cbBuffer"><b>UINT cbBuffer</b></param>
	/// <param name="pbBuffer">__RPC__inout_ecount_full_opt(cbBuffer) <b>BYTE* pbBuffer</b></param>
	/// <param name="pcbActual">__RPC__out <b>UINT* pcbActual</b></param>
	int GetProfileBytes (uint cbBuffer, byte* pbBuffer, out uint pcbActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::GetExifColorSpace (UINT* pValue)</b><br/>
	/// </summary>
	/// <param name="pValue">__RPC__out <b>UINT* pValue</b></param>
	int GetExifColorSpace (uint* pValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICColorContext::GetExifColorSpace (UINT* pValue)</b><br/>
	/// </summary>
	/// <param name="pValue">__RPC__out <b>UINT* pValue</b></param>
	int GetExifColorSpace (out uint pValue);
}

/// <summary>
/// Instance of <b>IWICColorContext</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct ColorContext : IColorContext {
//unsafe public readonly struct IColorContextObj : IColorContext {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ColorContext* GetCurrentPointer () => (ColorContext*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IColorContextObj* GetCurrentPointer () => (IColorContextObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3c613a02, 0x34b2, 0x44ea, 0x9a, 0x7c, 0x45, 0xae, 0xa9, 0xc6, 0xfd, 0x6d);

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
	public readonly int InitializeFromFilename (char* wzFilename) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromFilename (ptr, wzFilename);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromMemory (byte* pbBuffer, uint cbBufferSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromMemory (ptr, pbBuffer, cbBufferSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromExifColorSpace (uint value) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromExifColorSpace (ptr, value);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetType (ColorContextType* pType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr, pType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetType (out ColorContextType pType) {
		fixed (ColorContextType* _pType = &pType) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr, _pType);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetProfileBytes (uint cbBuffer, byte* pbBuffer, uint* pcbActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetProfileBytes (ptr, cbBuffer, pbBuffer, pcbActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetProfileBytes (uint cbBuffer, byte* pbBuffer, out uint pcbActual) {
		fixed (uint* _pcbActual = &pcbActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetProfileBytes (ptr, cbBuffer, pbBuffer, _pcbActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetExifColorSpace (uint* pValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExifColorSpace (ptr, pValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetExifColorSpace (out uint pValue) {
		fixed (uint* _pValue = &pValue) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetExifColorSpace (ptr, _pValue);
			return hr;
		}
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
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> InitializeFromFilename;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, byte*, uint, int> InitializeFromMemory;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> InitializeFromExifColorSpace;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorContextType*, int> _GetType;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, byte*, uint*, int> GetProfileBytes;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetExifColorSpace;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
