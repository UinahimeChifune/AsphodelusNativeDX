using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// 
/// </summary>
unsafe public static partial class API {

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICConvertBitmapSource (Guid dstFormat, void* pISrc, void** ppIDst);

	/// <summary>
	/// WINAPI <b>HRESULT WICConvertBitmapSource (REFWICPixelFormatGUID dstFormat, IWICBitmapSource *pISrc, IWICBitmapSource **ppIDst)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="dstFormat">_In_ <b>REFWICPixelFormatGUID dstFormat</b></param>
	/// <param name="pISrc">_In_ <b>IWICBitmapSource *pISrc</b></param>
	/// <param name="ppIDst">_Outptr_ <b>IWICBitmapSource **ppIDst</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int ConvertBitmapSource<T0, T1> (Guid dstFormat, T0* pISrc, T1** ppIDst) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IBitmapSource {
		var hr = WICConvertBitmapSource (dstFormat, pISrc, (void**) ppIDst);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICConvertBitmapSource (REFWICPixelFormatGUID dstFormat, IWICBitmapSource *pISrc, IWICBitmapSource **ppIDst)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="dstFormat">_In_ <b>REFWICPixelFormatGUID dstFormat</b></param>
	/// <param name="pISrc">_In_ <b>IWICBitmapSource *pISrc</b></param>
	/// <param name="ppIDst">_Outptr_ <b>IWICBitmapSource **ppIDst</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int ConvertBitmapSource<T0, T1> (Guid dstFormat, T0* pISrc, out T1* ppIDst) where T0 : unmanaged, IBitmapSource where T1 : unmanaged, IBitmapSource {
		fixed (T1** _ppIDst = &ppIDst) {
			var hr = WICConvertBitmapSource (dstFormat, pISrc, (void**) _ppIDst);
			return hr;
		}
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICCreateBitmapFromSection (uint width, uint height, Guid pixelFormat, IntPtr hSection, uint stride, uint offset, void** ppIBitmap);

	/// <summary>
	/// WINAPI <b>HRESULT WICCreateBitmapFromSection(UINT width, UINT height, REFWICPixelFormatGUID pixelFormat, HANDLE hSection, UINT stride, UINT offset, IWICBitmap **ppIBitmap)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="width">_In_ <b>UINT width</b></param>
	/// <param name="height">_In_ <b>UINT height</b></param>
	/// <param name="pixelFormat">_In_ <b>REFWICPixelFormatGUID pixelFormat</b></param>
	/// <param name="hSection">_In_ <b>HANDLE hSection</b></param>
	/// <param name="stride">_In_ <b>UINT stride</b></param>
	/// <param name="offset">_In_ <b>UINT offset</b></param>
	/// <param name="ppIBitmap">_Outptr_ <b>IWICBitmap **ppIBitmap</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateBitmapFromSection<T0> (uint width, uint height, Guid pixelFormat, IntPtr hSection, uint stride, uint offset, T0** ppIBitmap) where T0 : unmanaged, IBitmap {
		var hr = WICCreateBitmapFromSection (width, height, pixelFormat, hSection, stride, offset, (void**) ppIBitmap);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICCreateBitmapFromSection(UINT width, UINT height, REFWICPixelFormatGUID pixelFormat, HANDLE hSection, UINT stride, UINT offset, IWICBitmap **ppIBitmap)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="width">_In_ <b>UINT width</b></param>
	/// <param name="height">_In_ <b>UINT height</b></param>
	/// <param name="pixelFormat">_In_ <b>REFWICPixelFormatGUID pixelFormat</b></param>
	/// <param name="hSection">_In_ <b>HANDLE hSection</b></param>
	/// <param name="stride">_In_ <b>UINT stride</b></param>
	/// <param name="offset">_In_ <b>UINT offset</b></param>
	/// <param name="ppIBitmap">_Outptr_ <b>IWICBitmap **ppIBitmap</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateBitmapFromSection<T0> (uint width, uint height, Guid pixelFormat, IntPtr hSection, uint stride, uint offset, out T0* ppIBitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _ppIBitmap = &ppIBitmap) {
			var hr = WICCreateBitmapFromSection (width, height, pixelFormat, hSection, stride, offset, (void**) _ppIBitmap);
			return hr;
		}
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICCreateBitmapFromSectionEx (uint width, uint height, Guid pixelFormat, IntPtr hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, void** ppIBitmap);

	/// <summary>
	/// WINAPI <b>HRESULT WICCreateBitmapFromSectionEx(UINT width, UINT height, REFWICPixelFormatGUID pixelFormat, HANDLE hSection, UINT stride, UINT offset, IWICBitmap **ppIBitmap)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="width">_In_ <b>UINT width</b></param>
	/// <param name="height">_In_ <b>UINT height</b></param>
	/// <param name="pixelFormat">_In_ <b>REFWICPixelFormatGUID pixelFormat</b></param>
	/// <param name="hSection">_In_ <b>HANDLE hSection</b></param>
	/// <param name="stride">_In_ <b>UINT stride</b></param>
	/// <param name="offset">_In_ <b>UINT offset</b></param>
	/// <param name="desiredAccessLevel">_In_ <b>WICSectionAccessLevel desiredAccessLevel</b></param>
	/// <param name="ppIBitmap">_Outptr_ <b>IWICBitmap **ppIBitmap</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateBitmapFromSectionEx<T0> (uint width, uint height, Guid pixelFormat, IntPtr hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, T0** ppIBitmap) where T0 : unmanaged, IBitmap {
		var hr = WICCreateBitmapFromSectionEx (width, height, pixelFormat, hSection, stride, offset, desiredAccessLevel, (void**) ppIBitmap);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICCreateBitmapFromSectionEx(UINT width, UINT height, REFWICPixelFormatGUID pixelFormat, HANDLE hSection, UINT stride, UINT offset, IWICBitmap **ppIBitmap)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="width">_In_ <b>UINT width</b></param>
	/// <param name="height">_In_ <b>UINT height</b></param>
	/// <param name="pixelFormat">_In_ <b>REFWICPixelFormatGUID pixelFormat</b></param>
	/// <param name="hSection">_In_ <b>HANDLE hSection</b></param>
	/// <param name="stride">_In_ <b>UINT stride</b></param>
	/// <param name="offset">_In_ <b>UINT offset</b></param>
	/// <param name="desiredAccessLevel">_In_ <b>WICSectionAccessLevel desiredAccessLevel</b></param>
	/// <param name="ppIBitmap">_Outptr_ <b>IWICBitmap **ppIBitmap</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateBitmapFromSectionEx<T0> (uint width, uint height, Guid pixelFormat, IntPtr hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, out T0* ppIBitmap) where T0 : unmanaged, IBitmap {
		fixed (T0** _ppIBitmap = &ppIBitmap) {
			var hr = WICCreateBitmapFromSectionEx (width, height, pixelFormat, hSection, stride, offset, desiredAccessLevel, (void**) _ppIBitmap);
			return hr;
		}
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICMapGuidToShortName (Guid guid, uint cchName, char* wzName, uint* pcchActual);

	/// <summary>
	/// WINAPI <b>HRESULT WICMapGuidToShortName (REFGUID guid, UINT cchName, WCHAR *wzName, UINT *pcchActual)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="cchName">_In_ <b>UINT cchName</b></param>
	/// <param name="wzName">_Inout_updates_opt_(cchName) <b>WCHAR *wzName</b></param>
	/// <param name="pcchActual">_Out_ <b>UINT *pcchActual</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MapGuidToShortName (Guid guid, uint cchName, char* wzName, uint* pcchActual) {
		var hr = WICMapGuidToShortName (guid, cchName, wzName, pcchActual);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICMapGuidToShortName (REFGUID guid, UINT cchName, WCHAR *wzName, UINT *pcchActual)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="guid">_In_ <b>REFGUID guid</b></param>
	/// <param name="cchName">_In_ <b>UINT cchName</b></param>
	/// <param name="wzName">_Inout_updates_opt_(cchName) <b>WCHAR *wzName</b></param>
	/// <param name="pcchActual">_Out_ <b>UINT *pcchActual</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MapGuidToShortName (Guid guid, uint cchName, char* wzName, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var hr = WICMapGuidToShortName (guid, cchName, wzName, _pcchActual);
			return hr;
		}
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICMapShortNameToGuid (char* wzName, Guid* pguid);

	/// <summary>
	/// WINAPI <b>HRESULT WICMapShortNameToGuid (PCWSTR wzName, GUID *pguid)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="wzName">_In_ <b>PCWSTR wzName</b></param>
	/// <param name="pguid">_Out_ <b>GUID *pguid</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MapShortNameToGuid (char* wzName, Guid* pguid) {
		var hr = WICMapShortNameToGuid (wzName, pguid);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICMapShortNameToGuid (PCWSTR wzName, GUID *pguid)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="wzName">_In_ <b>PCWSTR wzName</b></param>
	/// <param name="pguid">_Out_ <b>GUID *pguid</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MapShortNameToGuid (char* wzName, out Guid pguid) {
		fixed (Guid* _pguid = &pguid) {
			var hr = WICMapShortNameToGuid (wzName, _pguid);
			return hr;
		}
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICMapSchemaToName (Guid guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, uint* pcchActual);

	/// <summary>
	/// WINAPI <b>HRESULT WICMapSchemaToName (REFGUID guidMetadataFormat, LPWSTR pwzSchema, UINT cchName, WCHAR *wzName, UINT *pcchActual)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="guidMetadataFormat">_In_ <b>REFGUID guidMetadataFormat</b></param>
	/// <param name="pwzSchema">_In_ <b>LPWSTR pwzSchema</b></param>
	/// <param name="cchName">_In_ <b>UINT cchName</b></param>
	/// <param name="wzName">_Inout_updates_opt_(cchName) <b>WCHAR *wzName</b></param>
	/// <param name="pcchActual">_Out_ <b>UINT *pcchActual</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MapSchemaToName (Guid guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, uint* pcchActual) {
		var hr = WICMapSchemaToName (guidMetadataFormat, pwzSchema, cchName, wzName, pcchActual);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICMapSchemaToName (REFGUID guidMetadataFormat, LPWSTR pwzSchema, UINT cchName, WCHAR *wzName, UINT *pcchActual)</b><br/>
	/// WINCODEC.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="guidMetadataFormat">_In_ <b>REFGUID guidMetadataFormat</b></param>
	/// <param name="pwzSchema">_In_ <b>LPWSTR pwzSchema</b></param>
	/// <param name="cchName">_In_ <b>UINT cchName</b></param>
	/// <param name="wzName">_Inout_updates_opt_(cchName) <b>WCHAR *wzName</b></param>
	/// <param name="pcchActual">_Out_ <b>UINT *pcchActual</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MapSchemaToName (Guid guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, out uint pcchActual) {
		fixed (uint* _pcchActual = &pcchActual) {
			var hr = WICMapSchemaToName (guidMetadataFormat, pwzSchema, cchName, wzName, _pcchActual);
			return hr;
		}
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICMatchMetadataContent (Guid guidContainerFormat, Guid* pguidVendor, void* pIStream, Guid* pguidMetadataFormat);

	/// <summary>
	/// WINAPI <b>HRESULT WICMatchMetadataContent (REFGUID guidContainerFormat, GUID *pguidVendor, IStream *pIStream, GUID *pguidMetadataFormat)</b><br/>
	/// WINCODECSDK.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <param name="guidContainerFormat">_In_ <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pguidVendor">_In_opt_ <b>GUID *pguidVendor</b></param>
	/// <param name="pIStream">_In_ <b>IStream *pIStream</b></param>
	/// <param name="pguidMetadataFormat">_Out_ <b>GUID *pguidMetadataFormat</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MatchMetadataContent<T0> (Guid guidContainerFormat, Guid* pguidVendor, T0* pIStream, Guid* pguidMetadataFormat) where T0 : unmanaged, AsphodelusNative.IStream {
		var hr = WICMatchMetadataContent (guidContainerFormat, pguidVendor, pIStream, pguidMetadataFormat);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICMatchMetadataContent (REFGUID guidContainerFormat, GUID *pguidVendor, IStream *pIStream, GUID *pguidMetadataFormat)</b><br/>
	/// WINCODECSDK.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <param name="guidContainerFormat">_In_ <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pguidVendor">_In_opt_ <b>GUID *pguidVendor</b></param>
	/// <param name="pIStream">_In_ <b>IStream *pIStream</b></param>
	/// <param name="pguidMetadataFormat">_Out_ <b>GUID *pguidMetadataFormat</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int MatchMetadataContent<T0> (Guid guidContainerFormat, Guid* pguidVendor, T0* pIStream, out Guid pguidMetadataFormat) where T0 : unmanaged, AsphodelusNative.IStream {
		fixed (Guid* _pguidMetadataFormat = &pguidMetadataFormat) {
			var hr = WICMatchMetadataContent (guidContainerFormat, pguidVendor, pIStream, _pguidMetadataFormat);
			return hr;
		}
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICSerializeMetadataContent (Guid guidContainerFormat, void* pIWriter, uint dwPersistOptions, void* pIStream);

	/// <summary>
	/// WINAPI <b>HRESULT WICSerializeMetadataContent (REFGUID guidContainerFormat, IWICMetadataWriter *pIWriter, DWORD dwPersistOptions, IStream *pIStream)</b><br/>
	/// WINCODECSDK.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="guidContainerFormat">_In_ <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pIWriter">_In_ <b>IWICMetadataWriter *pIWriter</b></param>
	/// <param name="dwPersistOptions">_In_ <b>DWORD dwPersistOptions</b></param>
	/// <param name="pIStream">_In_ <b>IStream *pIStream</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int SerializeMetadataContent<T0, T1> (Guid guidContainerFormat, T0* pIWriter, uint dwPersistOptions, T1* pIStream) where T0 : unmanaged, IMetadataWriter where T1 : unmanaged, AsphodelusNative.IStream {
		var hr = WICSerializeMetadataContent (guidContainerFormat, pIWriter, dwPersistOptions, pIStream);
		return hr;
	}

	[LibraryImport ("WINDOWSCODECS.dll")]
	private static partial int WICGetMetadataContentSize (Guid guidContainerFormat, void* pIWriter, ulong* pcbSize);

	/// <summary>
	/// WINAPI <b>HRESULT WICGetMetadataContentSize (REFGUID guidContainerFormat, IWICMetadataWriter *pIWriter, ULARGE_INTEGER *pcbSize)</b><br/>
	/// WINCODECSDK.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="guidContainerFormat">_In_ <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pIWriter">_In_ <b>IWICMetadataWriter *pIWriter</b></param>
	/// <param name="pcbSize">_Out_ <b>ULARGE_INTEGER *pcbSize</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetMetadataContentSize<T0> (Guid guidContainerFormat, T0* pIWriter, ulong* pcbSize) where T0 : unmanaged, IMetadataWriter {
		var hr = WICGetMetadataContentSize (guidContainerFormat, pIWriter, pcbSize);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT WICGetMetadataContentSize (REFGUID guidContainerFormat, IWICMetadataWriter *pIWriter, ULARGE_INTEGER *pcbSize)</b><br/>
	/// WINCODECSDK.h<br/>
	/// WINDOWSCODECS.dll
	/// </summary>
	/// <param name="guidContainerFormat">_In_ <b>REFGUID guidContainerFormat</b></param>
	/// <param name="pIWriter">_In_ <b>IWICMetadataWriter *pIWriter</b></param>
	/// <param name="pcbSize">_Out_ <b>ULARGE_INTEGER *pcbSize</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetMetadataContentSize<T0> (Guid guidContainerFormat, T0* pIWriter, out ulong pcbSize) where T0 : unmanaged, IMetadataWriter {
		fixed (ulong* _pcbSize = &pcbSize) {
			var hr = WICGetMetadataContentSize (guidContainerFormat, pIWriter, _pcbSize);
			return hr;
		}
	}
}
