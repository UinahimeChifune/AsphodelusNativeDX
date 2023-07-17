using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICDdsDecoder</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IDdsDecoder : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsDecoder::GetParameters (WICDdsParameters* pParameters)</b><br/>
	/// </summary>
	/// <param name="pParameters">__RPC__out <b>WICDdsParameters* pParameters</b></param>
	int GetParameters (DdsParameters* pParameters);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsDecoder::GetParameters (WICDdsParameters* pParameters)</b><br/>
	/// </summary>
	/// <param name="pParameters">__RPC__out <b>WICDdsParameters* pParameters</b></param>
	int GetParameters (out DdsParameters pParameters);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsDecoder::GetFrame (UINT arrayIndex, UINT mipLevel, UINT sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame)</b><br/>
	/// </summary>
	/// <param name="arrayIndex"><b>UINT arrayIndex</b></param>
	/// <param name="mipLevel"><b>UINT mipLevel</b></param>
	/// <param name="sliceIndex"><b>UINT sliceIndex</b></param>
	/// <param name="ppIBitmapFrame">__RPC__deref_out_opt <b>IWICBitmapFrameDecode** ppIBitmapFrame</b></param>
	int GetFrame<T0> (uint arrayIndex, uint mipLevel, uint sliceIndex, T0** ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsDecoder::GetFrame (UINT arrayIndex, UINT mipLevel, UINT sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame)</b><br/>
	/// </summary>
	/// <param name="arrayIndex"><b>UINT arrayIndex</b></param>
	/// <param name="mipLevel"><b>UINT mipLevel</b></param>
	/// <param name="sliceIndex"><b>UINT sliceIndex</b></param>
	/// <param name="ppIBitmapFrame">__RPC__deref_out_opt <b>IWICBitmapFrameDecode** ppIBitmapFrame</b></param>
	int GetFrame<T0> (uint arrayIndex, uint mipLevel, uint sliceIndex, out T0* ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode;
}

/// <summary>
/// Instance of <b>IWICDdsDecoder</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct DdsDecoder : IDdsDecoder {
//unsafe public readonly struct IDdsDecoderObj : IDdsDecoder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DdsDecoder* GetCurrentPointer () => (DdsDecoder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDdsDecoderObj* GetCurrentPointer () => (IDdsDecoderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x409cd537, 0x8532, 0x40cb, 0x97, 0x74, 0xe2, 0xfe, 0xb2, 0xdf, 0x4e, 0x9c);

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
	public readonly int GetFrame<T0> (uint arrayIndex, uint mipLevel, uint sliceIndex, T0** ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrame (ptr, arrayIndex, mipLevel, sliceIndex, (void**) ppIBitmapFrame);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrame<T0> (uint arrayIndex, uint mipLevel, uint sliceIndex, out T0* ppIBitmapFrame) where T0 : unmanaged, IBitmapFrameDecode {
		fixed (T0** _ppIBitmapFrame = &ppIBitmapFrame) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrame (ptr, arrayIndex, mipLevel, sliceIndex, (void**) _ppIBitmapFrame);
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
		public readonly delegate* unmanaged[Stdcall]<void*, DdsParameters*, int> GetParameters;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, void**, int> GetFrame;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
