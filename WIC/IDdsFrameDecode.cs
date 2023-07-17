using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICDdsFrameDecode</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IDdsFrameDecode : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsFrameDecode::GetSizeInBlocks (UINT* pWidthInBlocks, UINT* pHeightInBlocks)</b><br/>
	/// </summary>
	/// <param name="pWidthInBlocks">__RPC__out <b>UINT* pWidthInBlocks</b></param>
	/// <param name="pHeightInBlocks">__RPC__out <b>UINT* pHeightInBlocks</b></param>
	int GetSizeInBlocks (uint* pWidthInBlocks, uint* pHeightInBlocks);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsFrameDecode::GetSizeInBlocks (UINT* pWidthInBlocks, UINT* pHeightInBlocks)</b><br/>
	/// </summary>
	/// <param name="pWidthInBlocks">__RPC__out <b>UINT* pWidthInBlocks</b></param>
	/// <param name="pHeightInBlocks">__RPC__out <b>UINT* pHeightInBlocks</b></param>
	int GetSizeInBlocks (out uint pWidthInBlocks, out uint pHeightInBlocks);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsFrameDecode::GetFormatInfo (WICDdsFormatInfo* pFormatInfo)</b><br/>
	/// </summary>
	/// <param name="pFormatInfo">__RPC__out <b>WICDdsFormatInfo* pFormatInfo</b></param>
	int GetFormatInfo (DdsFormatInfo* pFormatInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsFrameDecode::GetFormatInfo (WICDdsFormatInfo* pFormatInfo)</b><br/>
	/// </summary>
	/// <param name="pFormatInfo">__RPC__out <b>WICDdsFormatInfo* pFormatInfo</b></param>
	int GetFormatInfo (out DdsFormatInfo pFormatInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsFrameDecode::CopyBlocks (WICRect* prcBoundsInBlocks, UINT cbStride, UINT cbBufferSize, BYTE* pbBuffer)</b><br/>
	/// </summary>
	/// <param name="prcBoundsInBlocks">__RPC__in_opt <b>WICRect* prcBoundsInBlocks</b></param>
	/// <param name="cbStride"><b>UINT cbStride</b></param>
	/// <param name="cbBufferSize"><b>UINT cbBufferSize</b></param>
	/// <param name="pbBuffer">__RPC__out_ecount_full(cbBufferSize) <b>BYTE* pbBuffer</b></param>
	int CopyBlocks (Vector4I* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDdsFrameDecode::CopyBlocks (WICRect* prcBoundsInBlocks, UINT cbStride, UINT cbBufferSize, BYTE* pbBuffer)</b><br/>
	/// </summary>
	/// <param name="prcBoundsInBlocks">__RPC__in_opt <b>WICRect* prcBoundsInBlocks</b></param>
	/// <param name="cbStride"><b>UINT cbStride</b></param>
	/// <param name="cbBufferSize"><b>UINT cbBufferSize</b></param>
	/// <param name="pbBuffer">__RPC__out_ecount_full(cbBufferSize) <b>BYTE* pbBuffer</b></param>
	int CopyBlocks (Vector4I* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, out byte pbBuffer);
}

/// <summary>
/// Instance of <b>IWICDdsFrameDecode</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct DdsFrameDecode : IDdsFrameDecode {
//unsafe public readonly struct IDdsFrameDecodeObj : IDdsFrameDecode {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DdsFrameDecode* GetCurrentPointer () => (DdsFrameDecode*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDdsFrameDecodeObj* GetCurrentPointer () => (IDdsFrameDecodeObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x3d4c0c61, 0x18a4, 0x41e4, 0xbd, 0x80, 0x48, 0x1a, 0x4f, 0xc9, 0xf4, 0x64);

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
	public readonly int GetSizeInBlocks (uint* pWidthInBlocks, uint* pHeightInBlocks) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSizeInBlocks (ptr, pWidthInBlocks, pHeightInBlocks);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSizeInBlocks (out uint pWidthInBlocks, out uint pHeightInBlocks) {
		fixed (uint* _pWidthInBlocks = &pWidthInBlocks) {
			fixed (uint* _pHeightInBlocks = &pHeightInBlocks) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetSizeInBlocks (ptr, _pWidthInBlocks, _pHeightInBlocks);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFormatInfo (DdsFormatInfo* pFormatInfo) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFormatInfo (ptr, pFormatInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFormatInfo (out DdsFormatInfo pFormatInfo) {
		fixed (DdsFormatInfo* _pFormatInfo = &pFormatInfo) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFormatInfo (ptr, _pFormatInfo);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyBlocks (Vector4I* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyBlocks (ptr, prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyBlocks (Vector4I* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, out byte pbBuffer) {
		fixed (byte* _pbBuffer = &pbBuffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CopyBlocks (ptr, prcBoundsInBlocks, cbStride, cbBufferSize, _pbBuffer);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, int> GetSizeInBlocks;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DdsFormatInfo*, int> GetFormatInfo;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint, uint, byte*, int> CopyBlocks;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
