using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICJpegFrameEncode</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IJpegFrameEncode : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameEncode::GetAcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pAcHuffmanTable">__RPC__out <b>DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable</b></param>
	int GetAcHuffmanTable (uint scanIndex, uint tableIndex, DXGI.JpegAcHuffmanTable* pAcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameEncode::GetAcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pAcHuffmanTable">__RPC__out <b>DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable</b></param>
	int GetAcHuffmanTable (uint scanIndex, uint tableIndex, out DXGI.JpegAcHuffmanTable pAcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameEncode::GetDcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pDcHuffmanTable">__RPC__out <b>DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable</b></param>
	int GetDcHuffmanTable (uint scanIndex, uint tableIndex, DXGI.JpegDcHuffmanTable* pDcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameEncode::GetDcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pDcHuffmanTable">__RPC__out <b>DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable</b></param>
	int GetDcHuffmanTable (uint scanIndex, uint tableIndex, out DXGI.JpegDcHuffmanTable pDcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameEncode::GetQuantizationTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pQuantizationTable">__RPC__out <b>DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable</b></param>
	int GetQuantizationTable (uint scanIndex, uint tableIndex, DXGI.JpegQuantizationTable* pQuantizationTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameEncode::GetQuantizationTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pQuantizationTable">__RPC__out <b>DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable</b></param>
	int GetQuantizationTable (uint scanIndex, uint tableIndex, out DXGI.JpegQuantizationTable pQuantizationTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameEncode::WriteScan (UINT cbScanData, BYTE* pbScanData)</b><br/>
	/// </summary>
	/// <param name="cbScanData"><b>UINT cbScanData</b></param>
	/// <param name="pbScanData">__RPC__in_ecount_full(cbScanData) <b>BYTE* pbScanData</b></param>
	int WriteScan (uint cbScanData, byte* pbScanData);
}

/// <summary>
/// Instance of <b>IWICJpegFrameEncode</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct JpegFrameEncode : IJpegFrameEncode {
//unsafe public readonly struct IJpegFrameEncodeObj : IJpegFrameEncode {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly JpegFrameEncode* GetCurrentPointer () => (JpegFrameEncode*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IJpegFrameEncodeObj* GetCurrentPointer () => (IJpegFrameEncodeObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2f0c601f, 0xd2c6, 0x468c, 0xab, 0xfa, 0x49, 0x49, 0x5d, 0x98, 0x3e, 0xd1);

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
	public readonly int GetAcHuffmanTable (uint scanIndex, uint tableIndex, DXGI.JpegAcHuffmanTable* pAcHuffmanTable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAcHuffmanTable (ptr, scanIndex, tableIndex, pAcHuffmanTable);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAcHuffmanTable (uint scanIndex, uint tableIndex, out DXGI.JpegAcHuffmanTable pAcHuffmanTable) {
		fixed (DXGI.JpegAcHuffmanTable* _pAcHuffmanTable = &pAcHuffmanTable) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAcHuffmanTable (ptr, scanIndex, tableIndex, _pAcHuffmanTable);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDcHuffmanTable (uint scanIndex, uint tableIndex, DXGI.JpegDcHuffmanTable* pDcHuffmanTable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDcHuffmanTable (ptr, scanIndex, tableIndex, pDcHuffmanTable);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDcHuffmanTable (uint scanIndex, uint tableIndex, out DXGI.JpegDcHuffmanTable pDcHuffmanTable) {
		fixed (DXGI.JpegDcHuffmanTable* _pDcHuffmanTable = &pDcHuffmanTable) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDcHuffmanTable (ptr, scanIndex, tableIndex, _pDcHuffmanTable);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetQuantizationTable (uint scanIndex, uint tableIndex, DXGI.JpegQuantizationTable* pQuantizationTable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetQuantizationTable (ptr, scanIndex, tableIndex, pQuantizationTable);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetQuantizationTable (uint scanIndex, uint tableIndex, out DXGI.JpegQuantizationTable pQuantizationTable) {
		fixed (DXGI.JpegQuantizationTable* _pQuantizationTable = &pQuantizationTable) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetQuantizationTable (ptr, scanIndex, tableIndex, _pQuantizationTable);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int WriteScan (uint cbScanData, byte* pbScanData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WriteScan (ptr, cbScanData, pbScanData);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, DXGI.JpegAcHuffmanTable*, int> GetAcHuffmanTable;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, DXGI.JpegDcHuffmanTable*, int> GetDcHuffmanTable;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, DXGI.JpegQuantizationTable*, int> GetQuantizationTable;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, byte*, int> WriteScan;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
