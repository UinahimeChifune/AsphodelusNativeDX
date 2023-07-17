using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// 
/// </summary>
unsafe public static partial class API {

	/// <summary>
	/// 
	/// </summary>
	public const uint SDKVersion = 7;

	[LibraryImport ("D3D11.dll")]
	private static partial int D3D11CreateDevice (void* pAdapter, Direct3D.DriverType driverType, IntPtr software, CreateDeviceFlag flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, void** ppDevice, void* pFeatureLevel, void** ppImmediateContext);

	/// <summary>
	/// WINAPI <b>HRESULT D3D11CreateDevice (IDXGIAdapter *pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, UINT Flags, D3D_FEATURE_LEVEL *pFeatureLevels, UINT FeatureLevels, UINT SDKVersion, ID3D11Device **ppDevice, D3D_FEATURE_LEVEL *pFeatureLevel, ID3D11DeviceContext **ppImmediateContext)</b><br/>
	/// D3D11.h<br/>
	/// D3D11.dll
	/// </summary>
	/// <param name="pAdapter">_In_opt_ <b>IDXGIAdapter *pAdapter</b></param>
	/// <param name="driverType"><b>D3D_DRIVER_TYPE DriverType</b></param>
	/// <param name="software"><b>HMODULE Software</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	/// <param name="pFeatureLevels">_In_reads_opt_(FeatureLevels) <b>D3D_FEATURE_LEVEL *pFeatureLevels</b></param>
	/// <param name="featureLevels"><b>UINT FeatureLevels</b></param>
	/// <param name="sDKVersion"><b>UINT SDKVersion</b></param>
	/// <param name="ppDevice">_COM_Outptr_opt_ <b>ID3D11Device **ppDevice</b></param>
	/// <param name="pFeatureLevel">_Out_opt_ <b>D3D_FEATURE_LEVEL *pFeatureLevel</b></param>
	/// <param name="ppImmediateContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext **ppImmediateContext</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDevice<T0, T1, T2> (T0* pAdapter, Direct3D.DriverType driverType, IntPtr software, CreateDeviceFlag flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, T1** ppDevice, Direct3D.FeatureLevel* pFeatureLevel, T2** ppImmediateContext) where T0 : unmanaged, DXGI.IAdapter where T1 : unmanaged, IDevice where T2 : unmanaged, IDeviceContext {
		var hr = D3D11CreateDevice (pAdapter, driverType, software, flags, pFeatureLevels, featureLevels, sDKVersion, (void**) ppDevice, pFeatureLevel, (void**) ppImmediateContext);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D11CreateDevice (IDXGIAdapter *pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, UINT Flags, D3D_FEATURE_LEVEL *pFeatureLevels, UINT FeatureLevels, UINT SDKVersion, ID3D11Device **ppDevice, D3D_FEATURE_LEVEL *pFeatureLevel, ID3D11DeviceContext **ppImmediateContext)</b><br/>
	/// D3D11.h<br/>
	/// D3D11.dll
	/// </summary>
	/// <param name="pAdapter">_In_opt_ <b>IDXGIAdapter *pAdapter</b></param>
	/// <param name="driverType"><b>D3D_DRIVER_TYPE DriverType</b></param>
	/// <param name="software"><b>HMODULE Software</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	/// <param name="pFeatureLevels">_In_reads_opt_(FeatureLevels) <b>D3D_FEATURE_LEVEL *pFeatureLevels</b></param>
	/// <param name="featureLevels"><b>UINT FeatureLevels</b></param>
	/// <param name="sDKVersion"><b>UINT SDKVersion</b></param>
	/// <param name="ppDevice">_COM_Outptr_opt_ <b>ID3D11Device **ppDevice</b></param>
	/// <param name="pFeatureLevel">_Out_opt_ <b>D3D_FEATURE_LEVEL *pFeatureLevel</b></param>
	/// <param name="ppImmediateContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext **ppImmediateContext</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDevice<T0, T1, T2> (T0* pAdapter, Direct3D.DriverType driverType, IntPtr software, CreateDeviceFlag flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, out T1* ppDevice, out Direct3D.FeatureLevel pFeatureLevel, out T2* ppImmediateContext) where T0 : unmanaged, DXGI.IAdapter where T1 : unmanaged, IDevice where T2 : unmanaged, IDeviceContext {
		fixed (T1** _ppDevice = &ppDevice) {
			fixed (Direct3D.FeatureLevel* _pFeatureLevel = &pFeatureLevel) {
				fixed (T2** _ppImmediateContext = &ppImmediateContext) {
					var hr = D3D11CreateDevice (pAdapter, driverType, software, flags, pFeatureLevels, featureLevels, sDKVersion, (void**) _ppDevice, _pFeatureLevel, (void**) _ppImmediateContext);
					return hr;
				}
			}
		}
	}

	[LibraryImport ("D3D11.dll")]
	private static partial int D3D11CreateDeviceAndSwapChain (void* pAdapter, Direct3D.DriverType driverType, IntPtr software, CreateDeviceFlag flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, DXGI.SwapChainDesc* pSwapChainDesc, void** ppSwapChain, void** ppDevice, void* pFeatureLevel, void** ppImmediateContext);

	/// <summary>
	/// WINAPI <b>HRESULT D3D11CreateDevice (IDXGIAdapter *pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, UINT Flags, D3D_FEATURE_LEVEL *pFeatureLevels, UINT FeatureLevels, UINT SDKVersion, ID3D11Device **ppDevice, D3D_FEATURE_LEVEL *pFeatureLevel, ID3D11DeviceContext **ppImmediateContext)</b><br/>
	/// D3D11.h<br/>
	/// D3D11.dll
	/// </summary>
	/// <param name="pAdapter">_In_opt_ <b>IDXGIAdapter *pAdapter</b></param>
	/// <param name="driverType"><b>D3D_DRIVER_TYPE DriverType</b></param>
	/// <param name="software"><b>HMODULE Software</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	/// <param name="pFeatureLevels">_In_reads_opt_(FeatureLevels) <b>D3D_FEATURE_LEVEL *pFeatureLevels</b></param>
	/// <param name="featureLevels"><b>UINT FeatureLevels</b></param>
	/// <param name="sDKVersion"><b>UINT SDKVersion</b></param>
	/// <param name="pSwapChainDesc">_In_opt_ <b>DXGI_SWAP_CHAIN_DESC* pSwapChainDesc</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_opt_ <b>IDXGISwapChain** ppSwapChain</b></param>
	/// <param name="ppDevice">_COM_Outptr_opt_ <b>ID3D11Device **ppDevice</b></param>
	/// <param name="pFeatureLevel">_Out_opt_ <b>D3D_FEATURE_LEVEL *pFeatureLevel</b></param>
	/// <param name="ppImmediateContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext **ppImmediateContext</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDeviceAndSwapChain<T0, T1, T2, T3> (T0* pAdapter, Direct3D.DriverType driverType, IntPtr software, CreateDeviceFlag flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, DXGI.SwapChainDesc* pSwapChainDesc, T1** ppSwapChain, T2** ppDevice, Direct3D.FeatureLevel* pFeatureLevel, T3** ppImmediateContext) where T0 : unmanaged, DXGI.IAdapter where T1 : unmanaged, DXGI.ISwapChain where T2 : unmanaged, IDevice where T3 : unmanaged, IDeviceContext {
		var hr = D3D11CreateDeviceAndSwapChain (pAdapter, driverType, software, flags, pFeatureLevels, featureLevels, sDKVersion, pSwapChainDesc, (void**) ppSwapChain, (void**) ppDevice, pFeatureLevel, (void**) ppImmediateContext);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D11CreateDevice (IDXGIAdapter *pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, UINT Flags, D3D_FEATURE_LEVEL *pFeatureLevels, UINT FeatureLevels, UINT SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device **ppDevice, D3D_FEATURE_LEVEL *pFeatureLevel, ID3D11DeviceContext **ppImmediateContext)</b><br/>
	/// D3D11.h<br/>
	/// D3D11.dll
	/// </summary>
	/// <param name="pAdapter">_In_opt_ <b>IDXGIAdapter *pAdapter</b></param>
	/// <param name="driverType"><b>D3D_DRIVER_TYPE DriverType</b></param>
	/// <param name="software"><b>HMODULE Software</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	/// <param name="pFeatureLevels">_In_reads_opt_(FeatureLevels) <b>D3D_FEATURE_LEVEL *pFeatureLevels</b></param>
	/// <param name="featureLevels"><b>UINT FeatureLevels</b></param>
	/// <param name="sDKVersion"><b>UINT SDKVersion</b></param>
	/// <param name="pSwapChainDesc">_In_opt_ <b>DXGI_SWAP_CHAIN_DESC* pSwapChainDesc</b></param>
	/// <param name="ppSwapChain">_COM_Outptr_opt_ <b>IDXGISwapChain** ppSwapChain</b></param>
	/// <param name="ppDevice">_COM_Outptr_opt_ <b>ID3D11Device **ppDevice</b></param>
	/// <param name="pFeatureLevel">_Out_opt_ <b>D3D_FEATURE_LEVEL *pFeatureLevel</b></param>
	/// <param name="ppImmediateContext">_COM_Outptr_opt_ <b>ID3D11DeviceContext **ppImmediateContext</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDeviceAndSwapChain<T0, T1, T2, T3> (T0* pAdapter, Direct3D.DriverType driverType, IntPtr software, CreateDeviceFlag flags, Direct3D.FeatureLevel* pFeatureLevels, uint featureLevels, uint sDKVersion, DXGI.SwapChainDesc* pSwapChainDesc, out T1* ppSwapChain, out T2* ppDevice, out Direct3D.FeatureLevel pFeatureLevel, out T3* ppImmediateContext) where T0 : unmanaged, DXGI.IAdapter where T1 : unmanaged, DXGI.ISwapChain where T2 : unmanaged, IDevice where T3 : unmanaged, IDeviceContext {
		fixed (T1** _ppSwapChain = &ppSwapChain) {
			fixed (T2** _ppDevice = &ppDevice) {
				fixed (Direct3D.FeatureLevel* _pFeatureLevel = &pFeatureLevel) {
					fixed (T3** _ppImmediateContext = &ppImmediateContext) {
						var hr = D3D11CreateDeviceAndSwapChain (pAdapter, driverType, software, flags, pFeatureLevels, featureLevels, sDKVersion, pSwapChainDesc, (void**) _ppSwapChain, (void**) _ppDevice, _pFeatureLevel, (void**) _ppImmediateContext);
						return hr;
					}
				}
			}
		}
	}
}
