using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapLock</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapLock : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetSize (UINT* puiWidth, UINT* puiHeight)</b><br/>
	/// </summary>
	/// <param name="puiWidth">__RPC__out <b>UINT* puiWidth</b></param>
	/// <param name="puiHeight">__RPC__out <b>UINT* puiHeight</b></param>
	int GetSize (uint* puiWidth, uint* puiHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetSize (UINT* puiWidth, UINT* puiHeight)</b><br/>
	/// </summary>
	/// <param name="puiWidth">__RPC__out <b>UINT* puiWidth</b></param>
	/// <param name="puiHeight">__RPC__out <b>UINT* puiHeight</b></param>
	int GetSize (out uint puiWidth, out uint puiHeight);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetStride (UINT* pcbStride)</b><br/>
	/// </summary>
	/// <param name="pcbStride">__RPC__out <b>UINT* pcbStride</b></param>
	int GetStride (uint* pcbStride);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetStride (UINT* pcbStride)</b><br/>
	/// </summary>
	/// <param name="pcbStride">__RPC__out <b>UINT* pcbStride</b></param>
	int GetStride (out uint pcbStride);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetDataPointer (UINT* pcbBufferSize, WICInProcPointer* ppbData)</b><br/>
	/// </summary>
	/// <param name="pcbBufferSize">__RPC__out <b>UINT* pcbBufferSize</b></param>
	/// <param name="ppbData">__RPC__deref_out_ecount_full_opt(*pcbBufferSize) <b>WICInProcPointer* ppbData</b></param>
	int GetDataPointer (uint* pcbBufferSize, IntPtr* ppbData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetDataPointer (UINT* pcbBufferSize, WICInProcPointer* ppbData)</b><br/>
	/// </summary>
	/// <param name="pcbBufferSize">__RPC__out <b>UINT* pcbBufferSize</b></param>
	/// <param name="ppbData">__RPC__deref_out_ecount_full_opt(*pcbBufferSize) <b>WICInProcPointer* ppbData</b></param>
	int GetDataPointer (out uint pcbBufferSize, out IntPtr ppbData);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetPixelFormat (WICPixelFormatGUID* pPixelFormat)</b><br/>
	/// </summary>
	/// <param name="pPixelFormat">__RPC__out <b>WICPixelFormatGUID* pPixelFormat</b></param>
	int GetPixelFormat (Guid* pPixelFormat);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapLock::GetPixelFormat (WICPixelFormatGUID* pPixelFormat)</b><br/>
	/// </summary>
	/// <param name="pPixelFormat">__RPC__out <b>WICPixelFormatGUID* pPixelFormat</b></param>
	int GetPixelFormat (out Guid pPixelFormat);
}

/// <summary>
/// Instance of <b>IWICBitmapLock</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapLock : IBitmapLock {
//unsafe public readonly struct IBitmapLockObj : IBitmapLock {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapLock* GetCurrentPointer () => (BitmapLock*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapLockObj* GetCurrentPointer () => (IBitmapLockObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000123, 0xa8f2, 0x4877, 0xba, 0x0a, 0xfd, 0x2b, 0x66, 0x45, 0xfb, 0x94);

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
	public readonly int GetSize (uint* puiWidth, uint* puiHeight) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, puiWidth, puiHeight);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSize (out uint puiWidth, out uint puiHeight) {
		fixed (uint* _puiWidth = &puiWidth) {
			fixed (uint* _puiHeight = &puiHeight) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetSize (ptr, _puiWidth, _puiHeight);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStride (uint* pcbStride) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStride (ptr, pcbStride);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStride (out uint pcbStride) {
		fixed (uint* _pcbStride = &pcbStride) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetStride (ptr, _pcbStride);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDataPointer (uint* pcbBufferSize, IntPtr* ppbData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDataPointer (ptr, pcbBufferSize, ppbData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDataPointer (out uint pcbBufferSize, out IntPtr ppbData) {
		fixed (uint* _pcbBufferSize = &pcbBufferSize) {
			fixed (IntPtr* _ppbData = &ppbData) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetDataPointer (ptr, _pcbBufferSize, _ppbData);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormat (Guid* pPixelFormat) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr, pPixelFormat);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelFormat (out Guid pPixelFormat) {
		fixed (Guid* _pPixelFormat = &pPixelFormat) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelFormat (ptr, _pPixelFormat);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, int> GetSize;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetStride;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, IntPtr*, int> GetDataPointer;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetPixelFormat;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
