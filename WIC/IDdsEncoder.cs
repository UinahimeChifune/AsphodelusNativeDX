using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICDdsEncoder</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IDdsEncoder : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsEncoder::SetParameters (WICDdsParameters* pParameters)</b><br/>
	/// </summary>
	/// <param name="pParameters">__RPC__in <b>WICDdsParameters* pParameters</b></param>
	int SetParameters (DdsParameters* pParameters);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsEncoder::GetParameters (WICDdsParameters* pParameters)</b><br/>
	/// </summary>
	/// <param name="pParameters">__RPC__out <b>WICDdsParameters* pParameters</b></param>
	int GetParameters (DdsParameters* pParameters);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsEncoder::GetParameters (WICDdsParameters* pParameters)</b><br/>
	/// </summary>
	/// <param name="pParameters">__RPC__out <b>WICDdsParameters* pParameters</b></param>
	int GetParameters (out DdsParameters pParameters);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsEncoder::CreateNewFrame (IWICBitmapFrameEncode** ppIFrameEncode, UINT* pArrayIndex, UINT* pMipLevel, UINT* pSliceIndex)</b><br/>
	/// </summary>
	/// <param name="ppIFrameEncode">__RPC__deref_out_opt <b>IWICBitmapFrameEncode** ppIFrameEncode</b></param>
	/// <param name="pArrayIndex">__RPC__out <b>UINT* pArrayIndex</b></param>
	/// <param name="pMipLevel">__RPC__out <b>UINT* pMipLevel</b></param>
	/// <param name="pSliceIndex">__RPC__out <b>UINT* pSliceIndex</b></param>
	int CreateNewFrame<T0> (T0** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex) where T0 : unmanaged, IBitmapFrameEncode;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsEncoder::CreateNewFrame (IWICBitmapFrameEncode** ppIFrameEncode, UINT* pArrayIndex, UINT* pMipLevel, UINT* pSliceIndex)</b><br/>
	/// </summary>
	/// <param name="ppIFrameEncode">__RPC__deref_out_opt <b>IWICBitmapFrameEncode** ppIFrameEncode</b></param>
	/// <param name="pArrayIndex">__RPC__out <b>UINT* pArrayIndex</b></param>
	/// <param name="pMipLevel">__RPC__out <b>UINT* pMipLevel</b></param>
	/// <param name="pSliceIndex">__RPC__out <b>UINT* pSliceIndex</b></param>
	int CreateNewFrame<T0> (out T0* ppIFrameEncode, out uint pArrayIndex, out uint pMipLevel, out uint pSliceIndex) where T0 : unmanaged, IBitmapFrameEncode;
}

/// <summary>
/// Instance of <b>IWICDdsEncoder</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct DdsEncoder : IDdsEncoder {
//unsafe public readonly struct IDdsEncoderObj : IDdsEncoder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DdsEncoder* GetCurrentPointer () => (DdsEncoder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDdsEncoderObj* GetCurrentPointer () => (IDdsEncoderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x5cacdb4c, 0x407e, 0x41b3, 0xb9, 0x36, 0xd0, 0xf0, 0x10, 0xcd, 0x67, 0x32);

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
	public readonly int SetParameters (DdsParameters* pParameters) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetParameters (ptr, pParameters);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParameters (DdsParameters* pParameters) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetParameters (ptr, pParameters);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParameters (out DdsParameters pParameters) {
		fixed (DdsParameters* _pParameters = &pParameters) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetParameters (ptr, _pParameters);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateNewFrame<T0> (T0** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex) where T0 : unmanaged, IBitmapFrameEncode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateNewFrame (ptr, (void**) ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateNewFrame<T0> (out T0* ppIFrameEncode, out uint pArrayIndex, out uint pMipLevel, out uint pSliceIndex) where T0 : unmanaged, IBitmapFrameEncode {
		fixed (T0** _ppIFrameEncode = &ppIFrameEncode) {
			fixed (uint* _pArrayIndex = &pArrayIndex) {
				fixed (uint* _pMipLevel = &pMipLevel) {
					fixed (uint* _pSliceIndex = &pSliceIndex) {
						var ptr = GetCurrentPointer ();
						var hr = ((FunctionPointer*) ptr->_pointer)->CreateNewFrame (ptr, (void**) _ppIFrameEncode, _pArrayIndex, _pMipLevel, _pSliceIndex);
						return hr;
					}
				}
			}
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
		public readonly delegate* unmanaged[Stdcall]<void*, DdsParameters*, int> SetParameters;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DdsParameters*, int> GetParameters;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, uint*, uint*, uint*, int> CreateNewFrame;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
