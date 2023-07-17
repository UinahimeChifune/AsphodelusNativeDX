using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICJpegFrameDecode</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IJpegFrameDecode : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::DoesSupportIndexing (BOOL* pfIndexingSupported)</b><br/>
	/// </summary>
	/// <param name="pfIndexingSupported">__RPC__out <b>BOOL* pfIndexingSupported</b></param>
	int DoesSupportIndexing (uint* pfIndexingSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::DoesSupportIndexing (BOOL* pfIndexingSupported)</b><br/>
	/// </summary>
	/// <param name="pfIndexingSupported">__RPC__out <b>BOOL* pfIndexingSupported</b></param>
	int DoesSupportIndexing (out bool pfIndexingSupported);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::SetIndexing (WICJpegIndexingOptions options, UINT horizontalIntervalSize)</b><br/>
	/// </summary>
	/// <param name="options"><b>WICJpegIndexingOptions options</b></param>
	/// <param name="horizontalIntervalSize"><b>UINT horizontalIntervalSize</b></param>
	int SetIndexing (JpegIndexingOptions options, uint horizontalIntervalSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::ClearIndexing ()</b><br/>
	/// </summary>
	int ClearIndexing ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetAcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pAcHuffmanTable">__RPC__out <b>DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable</b></param>
	int GetAcHuffmanTable (uint scanIndex, uint tableIndex, DXGI.JpegAcHuffmanTable* pAcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetAcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pAcHuffmanTable">__RPC__out <b>DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable</b></param>
	int GetAcHuffmanTable (uint scanIndex, uint tableIndex, out DXGI.JpegAcHuffmanTable pAcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetDcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pDcHuffmanTable">__RPC__out <b>DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable</b></param>
	int GetDcHuffmanTable (uint scanIndex, uint tableIndex, DXGI.JpegDcHuffmanTable* pDcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetDcHuffmanTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pDcHuffmanTable">__RPC__out <b>DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable</b></param>
	int GetDcHuffmanTable (uint scanIndex, uint tableIndex, out DXGI.JpegDcHuffmanTable pDcHuffmanTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetQuantizationTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pQuantizationTable">__RPC__out <b>DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable</b></param>
	int GetQuantizationTable (uint scanIndex, uint tableIndex, DXGI.JpegQuantizationTable* pQuantizationTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetQuantizationTable (UINT scanIndex, UINT tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="tableIndex">__RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) <b>UINT tableIndex</b></param>
	/// <param name="pQuantizationTable">__RPC__out <b>DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable</b></param>
	int GetQuantizationTable (uint scanIndex, uint tableIndex, out DXGI.JpegQuantizationTable pQuantizationTable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetFrameHeader (WICJpegFrameHeader* pFrameHeader)</b><br/>
	/// </summary>
	/// <param name="pFrameHeader">__RPC__out <b>WICJpegFrameHeader* pFrameHeader</b></param>
	int GetFrameHeader (JpegFrameHeader* pFrameHeader);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetFrameHeader (WICJpegFrameHeader* pFrameHeader)</b><br/>
	/// </summary>
	/// <param name="pFrameHeader">__RPC__out <b>WICJpegFrameHeader* pFrameHeader</b></param>
	int GetFrameHeader (out JpegFrameHeader pFrameHeader);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetScanHeader (UINT scanIndex, WICJpegScanHeader* pScanHeader)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="pScanHeader">__RPC__out <b>WICJpegScanHeader* pScanHeader</b></param>
	int GetScanHeader (uint scanIndex, JpegScanHeader* pScanHeader);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::GetScanHeader (UINT scanIndex, WICJpegScanHeader* pScanHeader)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="pScanHeader">__RPC__out <b>WICJpegScanHeader* pScanHeader</b></param>
	int GetScanHeader (uint scanIndex, out JpegScanHeader pScanHeader);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::CopyScan (UINT scanIndex, UINT scanOffset, UINT cbScanData, BYTE* pbScanData, UINT* pcbScanDataActual)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="scanOffset"><b>UINT scanOffset</b></param>
	/// <param name="cbScanData"><b>UINT cbScanData</b></param>
	/// <param name="pbScanData">__RPC__out_ecount_part(cbScanData, *pcbScanDataActual) <b>BYTE* pbScanData</b></param>
	/// <param name="pcbScanDataActual">__RPC__out <b>UINT* pcbScanDataActual</b></param>
	int CopyScan (uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::CopyScan (UINT scanIndex, UINT scanOffset, UINT cbScanData, BYTE* pbScanData, UINT* pcbScanDataActual)</b><br/>
	/// </summary>
	/// <param name="scanIndex"><b>UINT scanIndex</b></param>
	/// <param name="scanOffset"><b>UINT scanOffset</b></param>
	/// <param name="cbScanData"><b>UINT cbScanData</b></param>
	/// <param name="pbScanData">__RPC__out_ecount_part(cbScanData, *pcbScanDataActual) <b>BYTE* pbScanData</b></param>
	/// <param name="pcbScanDataActual">__RPC__out <b>UINT* pcbScanDataActual</b></param>
	int CopyScan (uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, out uint pcbScanDataActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::CopyMinimalStream (UINT streamOffset, UINT cbStreamData, BYTE* pbStreamData, UINT* pcbStreamDataActual)</b><br/>
	/// </summary>
	/// <param name="streamOffset"><b>UINT streamOffset</b></param>
	/// <param name="cbStreamData"><b>UINT cbStreamData</b></param>
	/// <param name="pbStreamData">__RPC__out_ecount_part(cbStreamData, *pcbStreamDataActual) <b>BYTE* pbStreamData</b></param>
	/// <param name="pcbStreamDataActual">__RPC__out <b>UINT* pcbStreamDataActual</b></param>
	int CopyMinimalStream (uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICJpegFrameDecode::CopyMinimalStream (UINT streamOffset, UINT cbStreamData, BYTE* pbStreamData, UINT* pcbStreamDataActual)</b><br/>
	/// </summary>
	/// <param name="streamOffset"><b>UINT streamOffset</b></param>
	/// <param name="cbStreamData"><b>UINT cbStreamData</b></param>
	/// <param name="pbStreamData">__RPC__out_ecount_part(cbStreamData, *pcbStreamDataActual) <b>BYTE* pbStreamData</b></param>
	/// <param name="pcbStreamDataActual">__RPC__out <b>UINT* pcbStreamDataActual</b></param>
	int CopyMinimalStream (uint streamOffset, uint cbStreamData, byte* pbStreamData, out uint pcbStreamDataActual);
}

/// <summary>
/// Instance of <b>IWICJpegFrameDecode</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct JpegFrameDecode : IJpegFrameDecode {
//unsafe public readonly struct IJpegFrameDecodeObj : IJpegFrameDecode {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly JpegFrameDecode* GetCurrentPointer () => (JpegFrameDecode*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IJpegFrameDecodeObj* GetCurrentPointer () => (IJpegFrameDecodeObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x8939f66e, 0xc46a, 0x4c21, 0xa9, 0xd1, 0x98, 0xb3, 0x27, 0xce, 0x16, 0x79);

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
	public readonly int DoesSupportIndexing (uint* pfIndexingSupported) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportIndexing (ptr, pfIndexingSupported);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DoesSupportIndexing (out bool pfIndexingSupported) {
		uint _pfIndexingSupported;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DoesSupportIndexing (ptr, &_pfIndexingSupported);
		pfIndexingSupported = _pfIndexingSupported != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetIndexing (JpegIndexingOptions options, uint horizontalIntervalSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetIndexing (ptr, options, horizontalIntervalSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ClearIndexing () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ClearIndexing (ptr);
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
	public readonly int GetFrameHeader (JpegFrameHeader* pFrameHeader) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameHeader (ptr, pFrameHeader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameHeader (out JpegFrameHeader pFrameHeader) {
		fixed (JpegFrameHeader* _pFrameHeader = &pFrameHeader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameHeader (ptr, _pFrameHeader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetScanHeader (uint scanIndex, JpegScanHeader* pScanHeader) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetScanHeader (ptr, scanIndex, pScanHeader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetScanHeader (uint scanIndex, out JpegScanHeader pScanHeader) {
		fixed (JpegScanHeader* _pScanHeader = &pScanHeader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetScanHeader (ptr, scanIndex, _pScanHeader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyScan (uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyScan (ptr, scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyScan (uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, out uint pcbScanDataActual) {
		fixed (uint* _pcbScanDataActual = &pcbScanDataActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CopyScan (ptr, scanIndex, scanOffset, cbScanData, pbScanData, _pcbScanDataActual);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyMinimalStream (uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyMinimalStream (ptr, streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyMinimalStream (uint streamOffset, uint cbStreamData, byte* pbStreamData, out uint pcbStreamDataActual) {
		fixed (uint* _pcbStreamDataActual = &pcbStreamDataActual) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CopyMinimalStream (ptr, streamOffset, cbStreamData, pbStreamData, _pcbStreamDataActual);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> DoesSupportIndexing;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, JpegIndexingOptions, uint, int> SetIndexing;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> ClearIndexing;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, DXGI.JpegAcHuffmanTable*, int> GetAcHuffmanTable;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, DXGI.JpegDcHuffmanTable*, int> GetDcHuffmanTable;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, DXGI.JpegQuantizationTable*, int> GetQuantizationTable;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, JpegFrameHeader*, int> GetFrameHeader;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, JpegScanHeader*, int> GetScanHeader;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, byte*, uint*, int> CopyScan;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, byte*, uint*, int> CopyMinimalStream;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
