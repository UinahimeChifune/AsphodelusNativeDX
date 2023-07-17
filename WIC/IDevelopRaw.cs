using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICDevelopRaw</b> : IWICBitmapFrameDecode<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IDevelopRaw : IBitmapFrameDecode {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::QueryRawCapabilitiesInfo (WICRawCapabilitiesInfo* pInfo)</b><br/>
	/// </summary>
	/// <param name="pInfo"><b>WICRawCapabilitiesInfo* pInfo</b></param>
	int QueryRawCapabilitiesInfo (RawCapabilitiesInfo* pInfo);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::LoadParameterSet (WICRawParameterSet ParameterSet)</b><br/>
	/// </summary>
	/// <param name="parameterSet"><b>WICRawParameterSet ParameterSet</b></param>
	int LoadParameterSet (RawParameterSet parameterSet);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetCurrentParameterSet (IPropertyBag2** ppCurrentParameterSet)</b><br/>
	/// </summary>
	/// <param name="ppCurrentParameterSet">__RPC__deref_out_opt <b>IPropertyBag2** ppCurrentParameterSet</b></param>
	[Obsolete ("'IPropertyBag2' not supported", true)]
	int GetCurrentParameterSet (void** ppCurrentParameterSet);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetCurrentParameterSet (IPropertyBag2** ppCurrentParameterSet)</b><br/>
	/// </summary>
	/// <param name="ppCurrentParameterSet">__RPC__deref_out_opt <b>IPropertyBag2** ppCurrentParameterSet</b></param>
	[Obsolete ("'IPropertyBag2' not supported", true)]
	int GetCurrentParameterSet (out void* ppCurrentParameterSet);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetExposureCompensation (double ev)</b><br/>
	/// </summary>
	/// <param name="ev"><b>double ev</b></param>
	int SetExposureCompensation (double ev);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetExposureCompensation (double* pEV)</b><br/>
	/// </summary>
	/// <param name="pEV">__RPC__out <b>double* pEV</b></param>
	int GetExposureCompensation (double* pEV);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetExposureCompensation (double* pEV)</b><br/>
	/// </summary>
	/// <param name="pEV">__RPC__out <b>double* pEV</b></param>
	int GetExposureCompensation (out double pEV);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetWhitePointRGB (UINT Red, UINT Green, UINT Blue)</b><br/>
	/// </summary>
	/// <param name="red"><b>UINT Red</b></param>
	/// <param name="green"><b>UINT Green</b></param>
	/// <param name="blue"><b>UINT Blue</b></param>
	int SetWhitePointRGB (uint red, uint green, uint blue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetWhitePointRGB (UINT* pRed, UINT* pGreen, UINT* pBlue)</b><br/>
	/// </summary>
	/// <param name="pRed">__RPC__out <b>UINT* pRed</b></param>
	/// <param name="pGreen">__RPC__out <b>UINT* pGreen</b></param>
	/// <param name="pBlue">__RPC__out <b>UINT* pBlue</b></param>
	int GetWhitePointRGB (uint* pRed, uint* pGreen, uint* pBlue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetWhitePointRGB (UINT* pRed, UINT* pGreen, UINT* pBlue)</b><br/>
	/// </summary>
	/// <param name="pRed">__RPC__out <b>UINT* pRed</b></param>
	/// <param name="pGreen">__RPC__out <b>UINT* pGreen</b></param>
	/// <param name="pBlue">__RPC__out <b>UINT* pBlue</b></param>
	int GetWhitePointRGB (out uint pRed, out uint pGreen, out uint pBlue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetNamedWhitePoint (WICNamedWhitePoint WhitePoint)</b><br/>
	/// </summary>
	/// <param name="whitePoint"><b>WICNamedWhitePoint WhitePoint</b></param>
	int SetNamedWhitePoint (NamedWhitePoint whitePoint);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetNamedWhitePoint (WICNamedWhitePoint* pWhitePoint)</b><br/>
	/// </summary>
	/// <param name="pWhitePoint">__RPC__out <b>WICNamedWhitePoint* pWhitePoint</b></param>
	int GetNamedWhitePoint (NamedWhitePoint* pWhitePoint);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetNamedWhitePoint (WICNamedWhitePoint* pWhitePoint)</b><br/>
	/// </summary>
	/// <param name="pWhitePoint">__RPC__out <b>WICNamedWhitePoint* pWhitePoint</b></param>
	int GetNamedWhitePoint (out NamedWhitePoint pWhitePoint);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetWhitePointKelvin (UINT WhitePointKelvin)</b><br/>
	/// </summary>
	/// <param name="whitePointKelvin"><b>UINT WhitePointKelvin</b></param>
	int SetWhitePointKelvin (uint whitePointKelvin);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetWhitePointKelvin (UINT* pWhitePointKelvin)</b><br/>
	/// </summary>
	/// <param name="pWhitePointKelvin">__RPC__out <b>UINT* pWhitePointKelvin</b></param>
	int GetWhitePointKelvin (uint* pWhitePointKelvin);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetWhitePointKelvin (UINT* pWhitePointKelvin)</b><br/>
	/// </summary>
	/// <param name="pWhitePointKelvin">__RPC__out <b>UINT* pWhitePointKelvin</b></param>
	int GetWhitePointKelvin (out uint pWhitePointKelvin);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetKelvinRangeInfo (UINT* pMinKelvinTemp, UINT* pMaxKelvinTemp, UINT* pKelvinTempStepValue)</b><br/>
	/// </summary>
	/// <param name="pMinKelvinTemp">__RPC__out <b>UINT* pMinKelvinTemp</b></param>
	/// <param name="pMaxKelvinTemp">__RPC__out <b>UINT* pMaxKelvinTemp</b></param>
	/// <param name="pKelvinTempStepValue">__RPC__out <b>UINT* pKelvinTempStepValue</b></param>
	int GetKelvinRangeInfo (uint* pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetKelvinRangeInfo (UINT* pMinKelvinTemp, UINT* pMaxKelvinTemp, UINT* pKelvinTempStepValue)</b><br/>
	/// </summary>
	/// <param name="pMinKelvinTemp">__RPC__out <b>UINT* pMinKelvinTemp</b></param>
	/// <param name="pMaxKelvinTemp">__RPC__out <b>UINT* pMaxKelvinTemp</b></param>
	/// <param name="pKelvinTempStepValue">__RPC__out <b>UINT* pKelvinTempStepValue</b></param>
	int GetKelvinRangeInfo (out uint pMinKelvinTemp, out uint pMaxKelvinTemp, out uint pKelvinTempStepValue);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetContrast (double Contrast)</b><br/>
	/// </summary>
	/// <param name="contrast"><b>double Contrast</b></param>
	int SetContrast (double contrast);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetContrast (double* pContrast)</b><br/>
	/// </summary>
	/// <param name="pContrast">__RPC__out <b>double* pContrast</b></param>
	int GetContrast (double* pContrast);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetContrast (double* pContrast)</b><br/>
	/// </summary>
	/// <param name="pContrast">__RPC__out <b>double* pContrast</b></param>
	int GetContrast (out double pContrast);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetGamma (double Gamma)</b><br/>
	/// </summary>
	/// <param name="gamma"><b>double Gamma</b></param>
	int SetGamma (double gamma);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetGamma (double* pGamma)</b><br/>
	/// </summary>
	/// <param name="pGamma">__RPC__out <b>double* pGamma</b></param>
	int GetGamma (double* pGamma);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetGamma (double* pGamma)</b><br/>
	/// </summary>
	/// <param name="pGamma">__RPC__out <b>double* pGamma</b></param>
	int GetGamma (out double pGamma);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetSharpness (double Sharpness)</b><br/>
	/// </summary>
	/// <param name="sharpness"><b>double Sharpness</b></param>
	int SetSharpness (double sharpness);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetSharpness (double* pSharpness)</b><br/>
	/// </summary>
	/// <param name="pSharpness">__RPC__out <b>double* pSharpness</b></param>
	int GetSharpness (double* pSharpness);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetSharpness (double* pSharpness)</b><br/>
	/// </summary>
	/// <param name="pSharpness">__RPC__out <b>double* pSharpness</b></param>
	int GetSharpness (out double pSharpness);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetSaturation (double Saturation)</b><br/>
	/// </summary>
	/// <param name="saturation"><b>double Saturation</b></param>
	int SetSaturation (double saturation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetSaturation (double* pSaturation)</b><br/>
	/// </summary>
	/// <param name="pSaturation">__RPC__out <b>double* pSaturation</b></param>
	int GetSaturation (double* pSaturation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetSaturation (double* pSaturation)</b><br/>
	/// </summary>
	/// <param name="pSaturation">__RPC__out <b>double* pSaturation</b></param>
	int GetSaturation (out double pSaturation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetTint (double Tint)</b><br/>
	/// </summary>
	/// <param name="tint"><b>double Tint</b></param>
	int SetTint (double tint);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetTint (double* pTint)</b><br/>
	/// </summary>
	/// <param name="pTint">__RPC__out <b>double* pTint</b></param>
	int GetTint (double* pTint);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetTint (double* pTint)</b><br/>
	/// </summary>
	/// <param name="pTint">__RPC__out <b>double* pTint</b></param>
	int GetTint (out double pTint);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetNoiseReduction (double NoiseReduction)</b><br/>
	/// </summary>
	/// <param name="noiseReduction"><b>double NoiseReduction</b></param>
	int SetNoiseReduction (double noiseReduction);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetNoiseReduction (double* pNoiseReduction)</b><br/>
	/// </summary>
	/// <param name="pNoiseReduction">__RPC__out <b>double* pNoiseReduction</b></param>
	int GetNoiseReduction (double* pNoiseReduction);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetNoiseReduction (double* pNoiseReduction)</b><br/>
	/// </summary>
	/// <param name="pNoiseReduction">__RPC__out <b>double* pNoiseReduction</b></param>
	int GetNoiseReduction (out double pNoiseReduction);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetDestinationColorContext (IWICColorContext* pColorContext)</b><br/>
	/// </summary>
	/// <param name="pColorContext">__RPC__in_opt <b>IWICColorContext* pColorContext</b></param>
	int SetDestinationColorContext<T0> (T0* pColorContext) where T0 : unmanaged, IColorContext;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetToneCurve (UINT cbToneCurveSize, WICRawToneCurve* pToneCurve)</b><br/>
	/// </summary>
	/// <param name="cbToneCurveSize"><b>UINT cbToneCurveSize</b></param>
	/// <param name="pToneCurve">_In_reads_bytes_(cbToneCurveSize) <b>WICRawToneCurve* pToneCurve</b></param>
	int SetToneCurve (uint cbToneCurveSize, RawToneCurve* pToneCurve);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetToneCurve (UINT cbToneCurveBufferSize, WICRawToneCurve* pToneCurve, UINT* pcbActualToneCurveBufferSize)</b><br/>
	/// </summary>
	/// <param name="cbToneCurveBufferSize"><b>UINT cbToneCurveBufferSize</b></param>
	/// <param name="pToneCurve">_Out_writes_bytes_to_opt_(cbToneCurveBufferSize, *pcbActualToneCurveBufferSize) <b>WICRawToneCurve* pToneCurve</b></param>
	/// <param name="pcbActualToneCurveBufferSize">_Inout_opt_ <b>UINT* pcbActualToneCurveBufferSize</b></param>
	int GetToneCurve (uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetRotation (double Rotation)</b><br/>
	/// </summary>
	/// <param name="rotation"><b>double Rotation</b></param>
	int SetRotation (double rotation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetRotation (double* pRotation)</b><br/>
	/// </summary>
	/// <param name="pRotation">__RPC__out <b>double* pRotation</b></param>
	int GetRotation (double* pRotation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetRotation (double* pRotation)</b><br/>
	/// </summary>
	/// <param name="pRotation">__RPC__out <b>double* pRotation</b></param>
	int GetRotation (out double pRotation);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetRenderMode (WICRawRenderMode RenderMode)</b><br/>
	/// </summary>
	/// <param name="renderMode"><b>WICRawRenderMode RenderMode</b></param>
	int SetRenderMode (RawRenderMode renderMode);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetRenderMode (WICRawRenderMode* pRenderMode)</b><br/>
	/// </summary>
	/// <param name="pRenderMode">__RPC__out <b>WICRawRenderMode* pRenderMode</b></param>
	int GetRenderMode (RawRenderMode* pRenderMode);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::GetRenderMode (WICRawRenderMode* pRenderMode)</b><br/>
	/// </summary>
	/// <param name="pRenderMode">__RPC__out <b>WICRawRenderMode* pRenderMode</b></param>
	int GetRenderMode (out RawRenderMode pRenderMode);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRaw::SetNotificationCallback (IWICDevelopRawNotificationCallback* pCallback)</b><br/>
	/// </summary>
	/// <param name="pCallback">__RPC__in_opt <b>IWICDevelopRawNotificationCallback* pCallback</b></param>
	int SetNotificationCallback<T0> (T0* pCallback) where T0 : unmanaged, IDevelopRawNotificationCallback;
}

/// <summary>
/// Instance of <b>IWICDevelopRaw</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct DevelopRaw : IDevelopRaw {
//unsafe public readonly struct IDevelopRawObj : IDevelopRaw {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DevelopRaw* GetCurrentPointer () => (DevelopRaw*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDevelopRawObj* GetCurrentPointer () => (IDevelopRawObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xfbec5e44, 0xf7be, 0x4b65, 0xb7, 0xf8, 0xc0, 0xc8, 0x1f, 0xef, 0x02, 0x6d);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetResolution (double* pDpiX, double* pDpiY) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetResolution (ptr, pDpiX, pDpiY);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetResolution (out double pDpiX, out double pDpiY) {
		fixed (double* _pDpiX = &pDpiX) {
			fixed (double* _pDpiY = &pDpiY) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetResolution (ptr, _pDpiX, _pDpiY);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPalette (ptr, pIPalette);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, cbStride, cbBufferSize, pbBuffer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyPixels (Vector4I* prc, uint cbStride, uint cbBufferSize, out byte pbBuffer) {
		fixed (byte* _pbBuffer = &pbBuffer) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CopyPixels (ptr, prc, cbStride, cbBufferSize, _pbBuffer);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataQueryReader<T0> (T0** ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryReader (ptr, (void**) ppIMetadataQueryReader);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataQueryReader<T0> (out T0* ppIMetadataQueryReader) where T0 : unmanaged, IMetadataQueryReader {
		fixed (T0** _ppIMetadataQueryReader = &ppIMetadataQueryReader) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryReader (ptr, (void**) _ppIMetadataQueryReader);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, uint* pcActualCount) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorContexts (ptr, cCount, (void**) ppIColorContexts, pcActualCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorContexts<T0> (uint cCount, T0** ppIColorContexts, out uint pcActualCount) where T0 : unmanaged, IColorContext {
		fixed (uint* _pcActualCount = &pcActualCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetColorContexts (ptr, cCount, (void**) ppIColorContexts, _pcActualCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetThumbnail<T0> (T0** ppIThumbnail) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetThumbnail (ptr, (void**) ppIThumbnail);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetThumbnail<T0> (out T0* ppIThumbnail) where T0 : unmanaged, IBitmapSource {
		fixed (T0** _ppIThumbnail = &ppIThumbnail) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetThumbnail (ptr, (void**) _ppIThumbnail);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryRawCapabilitiesInfo (RawCapabilitiesInfo* pInfo) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryRawCapabilitiesInfo (ptr, pInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadParameterSet (RawParameterSet parameterSet) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LoadParameterSet (ptr, parameterSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	[Obsolete ("'IPropertyBag2' not supported", true)]
	public readonly int GetCurrentParameterSet (void** ppCurrentParameterSet) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentParameterSet (ptr, ppCurrentParameterSet);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	[Obsolete ("'IPropertyBag2' not supported", true)]
	public readonly int GetCurrentParameterSet (out void* ppCurrentParameterSet) {
		fixed (void** _ppCurrentParameterSet = &ppCurrentParameterSet) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentParameterSet (ptr, _ppCurrentParameterSet);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetExposureCompensation (double ev) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetExposureCompensation (ptr, ev);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetExposureCompensation (double* pEV) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExposureCompensation (ptr, pEV);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetExposureCompensation (out double pEV) {
		fixed (double* _pEV = &pEV) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetExposureCompensation (ptr, _pEV);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetWhitePointRGB (uint red, uint green, uint blue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetWhitePointRGB (ptr, red, green, blue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWhitePointRGB (uint* pRed, uint* pGreen, uint* pBlue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetWhitePointRGB (ptr, pRed, pGreen, pBlue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWhitePointRGB (out uint pRed, out uint pGreen, out uint pBlue) {
		fixed (uint* _pRed = &pRed) {
			fixed (uint* _pGreen = &pGreen) {
				fixed (uint* _pBlue = &pBlue) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->GetWhitePointRGB (ptr, _pRed, _pGreen, _pBlue);
					return hr;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetNamedWhitePoint (NamedWhitePoint whitePoint) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetNamedWhitePoint (ptr, whitePoint);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNamedWhitePoint (NamedWhitePoint* pWhitePoint) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNamedWhitePoint (ptr, pWhitePoint);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNamedWhitePoint (out NamedWhitePoint pWhitePoint) {
		fixed (NamedWhitePoint* _pWhitePoint = &pWhitePoint) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetNamedWhitePoint (ptr, _pWhitePoint);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetWhitePointKelvin (uint whitePointKelvin) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetWhitePointKelvin (ptr, whitePointKelvin);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWhitePointKelvin (uint* pWhitePointKelvin) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetWhitePointKelvin (ptr, pWhitePointKelvin);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetWhitePointKelvin (out uint pWhitePointKelvin) {
		fixed (uint* _pWhitePointKelvin = &pWhitePointKelvin) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetWhitePointKelvin (ptr, _pWhitePointKelvin);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetKelvinRangeInfo (uint* pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetKelvinRangeInfo (ptr, pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetKelvinRangeInfo (out uint pMinKelvinTemp, out uint pMaxKelvinTemp, out uint pKelvinTempStepValue) {
		fixed (uint* _pMinKelvinTemp = &pMinKelvinTemp) {
			fixed (uint* _pMaxKelvinTemp = &pMaxKelvinTemp) {
				fixed (uint* _pKelvinTempStepValue = &pKelvinTempStepValue) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->GetKelvinRangeInfo (ptr, _pMinKelvinTemp, _pMaxKelvinTemp, _pKelvinTempStepValue);
					return hr;
				}
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetContrast (double contrast) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetContrast (ptr, contrast);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContrast (double* pContrast) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetContrast (ptr, pContrast);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetContrast (out double pContrast) {
		fixed (double* _pContrast = &pContrast) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetContrast (ptr, _pContrast);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetGamma (double gamma) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetGamma (ptr, gamma);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGamma (double* pGamma) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGamma (ptr, pGamma);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGamma (out double pGamma) {
		fixed (double* _pGamma = &pGamma) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGamma (ptr, _pGamma);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSharpness (double sharpness) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSharpness (ptr, sharpness);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSharpness (double* pSharpness) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSharpness (ptr, pSharpness);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSharpness (out double pSharpness) {
		fixed (double* _pSharpness = &pSharpness) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSharpness (ptr, _pSharpness);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSaturation (double saturation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSaturation (ptr, saturation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSaturation (double* pSaturation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSaturation (ptr, pSaturation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSaturation (out double pSaturation) {
		fixed (double* _pSaturation = &pSaturation) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSaturation (ptr, _pSaturation);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTint (double tint) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTint (ptr, tint);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTint (double* pTint) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTint (ptr, pTint);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTint (out double pTint) {
		fixed (double* _pTint = &pTint) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetTint (ptr, _pTint);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetNoiseReduction (double noiseReduction) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetNoiseReduction (ptr, noiseReduction);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNoiseReduction (double* pNoiseReduction) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNoiseReduction (ptr, pNoiseReduction);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNoiseReduction (out double pNoiseReduction) {
		fixed (double* _pNoiseReduction = &pNoiseReduction) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetNoiseReduction (ptr, _pNoiseReduction);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetDestinationColorContext<T0> (T0* pColorContext) where T0 : unmanaged, IColorContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetDestinationColorContext (ptr, pColorContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetToneCurve (uint cbToneCurveSize, RawToneCurve* pToneCurve) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetToneCurve (ptr, cbToneCurveSize, pToneCurve);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetToneCurve (uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetToneCurve (ptr, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetRotation (double rotation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetRotation (ptr, rotation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRotation (double* pRotation) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRotation (ptr, pRotation);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRotation (out double pRotation) {
		fixed (double* _pRotation = &pRotation) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetRotation (ptr, _pRotation);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetRenderMode (RawRenderMode renderMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetRenderMode (ptr, renderMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRenderMode (RawRenderMode* pRenderMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRenderMode (ptr, pRenderMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRenderMode (out RawRenderMode pRenderMode) {
		fixed (RawRenderMode* _pRenderMode = &pRenderMode) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetRenderMode (ptr, _pRenderMode);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetNotificationCallback<T0> (T0* pCallback) where T0 : unmanaged, IDevelopRawNotificationCallback {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetNotificationCallback (ptr, pCallback);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, int> GetSize;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetPixelFormat;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, double*, int> GetResolution;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> CopyPalette;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint, uint, byte*, int> CopyPixels;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetMetadataQueryReader;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, uint*, int> GetColorContexts;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetThumbnail;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RawCapabilitiesInfo*, int> QueryRawCapabilitiesInfo;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RawParameterSet, int> LoadParameterSet;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		[Obsolete ("'IPropertyBag2' not supported", true)]
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetCurrentParameterSet;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetExposureCompensation;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetExposureCompensation;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, uint, int> SetWhitePointRGB;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, uint*, int> GetWhitePointRGB;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, NamedWhitePoint, int> SetNamedWhitePoint;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, NamedWhitePoint*, int> GetNamedWhitePoint;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetWhitePointKelvin;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetWhitePointKelvin;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, uint*, int> GetKelvinRangeInfo;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetContrast;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetContrast;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetGamma;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetGamma;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetSharpness;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetSharpness;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetSaturation;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetSaturation;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetTint;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetTint;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetNoiseReduction;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetNoiseReduction;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetDestinationColorContext;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, RawToneCurve*, int> SetToneCurve;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, RawToneCurve*, uint*, int> GetToneCurve;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double, int> SetRotation;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, double*, int> GetRotation;
		/// <summary>
		/// OFFSET 40
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RawRenderMode, int> SetRenderMode;
		/// <summary>
		/// OFFSET 41
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RawRenderMode*, int> GetRenderMode;
		/// <summary>
		/// OFFSET 42
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetNotificationCallback;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
