using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// 
/// </summary>
unsafe public static partial class API {

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12SerializeRootSignature (RootSignatureDesc* pRootSignature, Direct3D.RootSignatureVersion version, void** ppBlob, void** ppErrorBlob);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12SerializeRootSignature (D3D12_ROOT_SIGNATURE_DESC* pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pRootSignature">_In_ <b>D3D12_ROOT_SIGNATURE_DESC* pRootSignature</b></param>
	/// <param name="version">_In_ <b>D3D_ROOT_SIGNATURE_VERSION Version</b></param>
	/// <param name="ppBlob">_Out_ <b>ID3DBlob** ppBlob</b></param>
	/// <param name="ppErrorBlob">_Always_(_Outptr_opt_result_maybenull_) <b>ID3DBlob** ppErrorBlob</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int SerializeRootSignature<T0, T1> (RootSignatureDesc* pRootSignature, Direct3D.RootSignatureVersion version, T0** ppBlob, T1** ppErrorBlob) where T0 : unmanaged, Direct3D.IBlob where T1 : unmanaged, Direct3D.IBlob {
		var hr = D3D12SerializeRootSignature (pRootSignature, version, (void**) ppBlob, (void**) ppErrorBlob);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D12SerializeRootSignature (D3D12_ROOT_SIGNATURE_DESC* pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pRootSignature">_In_ <b>D3D12_ROOT_SIGNATURE_DESC* pRootSignature</b></param>
	/// <param name="version">_In_ <b>D3D_ROOT_SIGNATURE_VERSION Version</b></param>
	/// <param name="ppBlob">_Out_ <b>ID3DBlob** ppBlob</b></param>
	/// <param name="ppErrorBlob">_Always_(_Outptr_opt_result_maybenull_) <b>ID3DBlob** ppErrorBlob</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int SerializeRootSignature<T0, T1> (RootSignatureDesc* pRootSignature, Direct3D.RootSignatureVersion version, out T0* ppBlob, out T1* ppErrorBlob) where T0 : unmanaged, Direct3D.IBlob where T1 : unmanaged, Direct3D.IBlob {
		fixed (T0** _ppBlob = &ppBlob) {
			fixed (T1** _ppErrorBlob = &ppErrorBlob) {
				var hr = D3D12SerializeRootSignature (pRootSignature, version, (void**) _ppBlob, (void**) _ppErrorBlob);
				return hr;
			}
		}
	}

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12CreateRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateRootSignatureDeserializer (LPCVOID pSrcData, SIZE_T SrcDataSizeInBytes, REFIID pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pSrcData">_In_reads_bytes_(SrcDataSizeInBytes) <b>LPCVOID pSrcData</b></param>
	/// <param name="srcDataSizeInBytes">_In_ <b>SIZE_T SrcDataSizeInBytes</b></param>
	/// <param name="pRootSignatureDeserializerInterface">_In_ <b>REFIID pRootSignatureDeserializerInterface</b></param>
	/// <param name="ppRootSignatureDeserializer">_Out_ <b>void** ppRootSignatureDeserializer</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) {
		var hr = D3D12CreateRootSignatureDeserializer (pSrcData, srcDataSizeInBytes, pRootSignatureDeserializerInterface, ppRootSignatureDeserializer);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateRootSignatureDeserializer (LPCVOID pSrcData, SIZE_T SrcDataSizeInBytes, REFIID pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pSrcData">_In_reads_bytes_(SrcDataSizeInBytes) <b>LPCVOID pSrcData</b></param>
	/// <param name="srcDataSizeInBytes">_In_ <b>SIZE_T SrcDataSizeInBytes</b></param>
	/// <param name="pRootSignatureDeserializerInterface">_In_ <b>REFIID pRootSignatureDeserializerInterface</b></param>
	/// <param name="ppRootSignatureDeserializer">_Out_ <b>void** ppRootSignatureDeserializer</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, out void* ppRootSignatureDeserializer) {
		fixed (void** _ppRootSignatureDeserializer = &ppRootSignatureDeserializer) {
			var hr = D3D12CreateRootSignatureDeserializer (pSrcData, srcDataSizeInBytes, pRootSignatureDeserializerInterface, _ppRootSignatureDeserializer);
			return hr;
		}
	}

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12SerializeVersionedRootSignature (VersionedRootSignatureDesc* pRootSignature, void** ppBlob, void** ppErrorBlob);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12SerializeVersionedRootSignature (D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pRootSignature">_In_ <b>D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature</b></param>
	/// <param name="ppBlob">_Out_ <b>ID3DBlob** ppBlob</b></param>
	/// <param name="ppErrorBlob">_Always_(_Outptr_opt_result_maybenull_) <b>ID3DBlob** ppErrorBlob</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int SerializeVersionedRootSignature<T0, T1> (VersionedRootSignatureDesc* pRootSignature, T0** ppBlob, T1** ppErrorBlob) where T0 : unmanaged, Direct3D.IBlob where T1 : unmanaged, Direct3D.IBlob {
		var hr = D3D12SerializeVersionedRootSignature (pRootSignature, (void**) ppBlob, (void**) ppErrorBlob);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D12SerializeVersionedRootSignature (D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pRootSignature">_In_ <b>D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature</b></param>
	/// <param name="ppBlob">_Out_ <b>ID3DBlob** ppBlob</b></param>
	/// <param name="ppErrorBlob">_Always_(_Outptr_opt_result_maybenull_) <b>ID3DBlob** ppErrorBlob</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int SerializeVersionedRootSignature<T0, T1> (VersionedRootSignatureDesc* pRootSignature, out T0* ppBlob, out T1* ppErrorBlob) where T0 : unmanaged, Direct3D.IBlob where T1 : unmanaged, Direct3D.IBlob {
		fixed (T0** _ppBlob = &ppBlob) {
			fixed (T1** _ppErrorBlob = &ppErrorBlob) {
				var hr = D3D12SerializeVersionedRootSignature (pRootSignature, (void**) _ppBlob, (void**) _ppErrorBlob);
				return hr;
			}
		}
	}

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12CreateVersionedRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateVersionedRootSignatureDeserializer (LPCVOID pSrcData, SIZE_T SrcDataSizeInBytes, REFIID pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pSrcData">_In_reads_bytes_(SrcDataSizeInBytes) <b>LPCVOID pSrcData</b></param>
	/// <param name="srcDataSizeInBytes">_In_ <b>SIZE_T SrcDataSizeInBytes</b></param>
	/// <param name="pRootSignatureDeserializerInterface">_In_ <b>REFIID pRootSignatureDeserializerInterface</b></param>
	/// <param name="ppRootSignatureDeserializer">_Out_ <b>void** ppRootSignatureDeserializer</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateVersionedRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) {
		var hr = D3D12CreateVersionedRootSignatureDeserializer (pSrcData, srcDataSizeInBytes, pRootSignatureDeserializerInterface, ppRootSignatureDeserializer);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateVersionedRootSignatureDeserializer (LPCVOID pSrcData, SIZE_T SrcDataSizeInBytes, REFIID pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pSrcData">_In_reads_bytes_(SrcDataSizeInBytes) <b>LPCVOID pSrcData</b></param>
	/// <param name="srcDataSizeInBytes">_In_ <b>SIZE_T SrcDataSizeInBytes</b></param>
	/// <param name="pRootSignatureDeserializerInterface">_In_ <b>REFIID pRootSignatureDeserializerInterface</b></param>
	/// <param name="ppRootSignatureDeserializer">_Out_ <b>void** ppRootSignatureDeserializer</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateVersionedRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, out void* ppRootSignatureDeserializer) {
		fixed (void** _ppRootSignatureDeserializer = &ppRootSignatureDeserializer) {
			var hr = D3D12CreateVersionedRootSignatureDeserializer (pSrcData, srcDataSizeInBytes, pRootSignatureDeserializerInterface, _ppRootSignatureDeserializer);
			return hr;
		}
	}

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12CreateDevice (void* pAdapter, Direct3D.FeatureLevel MinimumFeatureLevel, Guid riid, void** ppDevice);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateDevice (IUnknown* pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, REFIID riid, void** ppDevice)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pAdapter">_In_opt_ <b>IUnknown* pAdapter</b></param>
	/// <param name="minimumFeatureLevel"><b>D3D_FEATURE_LEVEL MinimumFeatureLevel</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppDevice">_COM_Outptr_opt_ <b>void** ppDevice</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDevice<T0> (T0* pAdapter, Direct3D.FeatureLevel minimumFeatureLevel, Guid riid, void** ppDevice) where T0 : unmanaged, IUnknown {
		var hr = D3D12CreateDevice (pAdapter, minimumFeatureLevel, riid, ppDevice);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateDevice (IUnknown* pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, REFIID riid, void** ppDevice)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="pAdapter">_In_opt_ <b>IUnknown* pAdapter</b></param>
	/// <param name="minimumFeatureLevel"><b>D3D_FEATURE_LEVEL MinimumFeatureLevel</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppDevice">_COM_Outptr_opt_ <b>void** ppDevice</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDevice<T0> (T0* pAdapter, Direct3D.FeatureLevel minimumFeatureLevel, Guid riid, out void* ppDevice) where T0 : unmanaged, IUnknown {
		fixed (void** _ppDevice = &ppDevice) {
			var hr = D3D12CreateDevice (pAdapter, minimumFeatureLevel, riid, _ppDevice);
			return hr;
		}
	}

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12GetDebugInterface (Guid riid, void** ppvDebug);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateDevice (REFIID riid, void** ppvDebug)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvDebug">_COM_Outptr_opt_ <b>void** ppvDebug</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetDebugInterface (Guid riid, void** ppvDebug) {
		var hr = D3D12GetDebugInterface (riid, ppvDebug);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D12CreateDevice (REFIID riid, void** ppvDebug)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvDebug">_COM_Outptr_opt_ <b>void** ppvDebug</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetDebugInterface (Guid riid, out void* ppvDebug) {
		fixed (void** _ppvDebug = &ppvDebug) {
			var hr = D3D12GetDebugInterface (riid, _ppvDebug);
			return hr;
		}
	}

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12EnableExperimentalFeatures (uint numFeatures, Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12EnableExperimentalFeatures (UINT NumFeatures, IID* pIIDs, void* pConfigurationStructs, UINT* pConfigurationStructSizes)</b><br/>
	/// D3D12.h<br/>
	/// D3D12.dll
	/// </summary>
	/// <param name="numFeatures"><b>UINT NumFeatures</b></param>
	/// <param name="pIIDs">_In_count_(NumFeatures) <b>IID* pIIDs</b></param>
	/// <param name="pConfigurationStructs">_In_opt_count_(NumFeatures) <b>void* pConfigurationStructs</b></param>
	/// <param name="pConfigurationStructSizes">_In_opt_count_(NumFeatures) <b>UINT* pConfigurationStructSizes</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int EnableExperimentalFeatures (uint numFeatures, Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes) {
		var hr = D3D12EnableExperimentalFeatures (numFeatures, pIIDs, pConfigurationStructs, pConfigurationStructSizes);
		return hr;
	}

	[LibraryImport ("D3D12.dll")]
	private static partial int D3D12GetInterface (Guid rclsid, Guid riid, void** ppvDebug);

	/// <summary>
	/// WINAPI <b>HRESULT D3D12GetInterface (REFCLSID rclsid, REFIID riid, void** ppvDebug)</b>
	/// </summary>
	/// <param name="rclsid">_In_ <b>REFCLSID rclsid</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvDebug">_COM_Outptr_opt_ <b>void** ppvDebug</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetInterface (Guid rclsid, Guid riid, void** ppvDebug) {
		var hr = D3D12GetInterface (rclsid, riid, ppvDebug);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D3D12GetInterface (REFCLSID rclsid, REFIID riid, void** ppvDebug)</b>
	/// </summary>
	/// <param name="rclsid">_In_ <b>REFCLSID rclsid</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppvDebug">_COM_Outptr_opt_ <b>void** ppvDebug</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetInterface (Guid rclsid, Guid riid, out void* ppvDebug) {
		fixed (void** _ppvDebug = &ppvDebug) {
			var hr = D3D12GetInterface (rclsid, riid, _ppvDebug);
			return hr;
		}
	}
}

/// <summary>
/// CALLBACK <b>PFN_D3D12_SERIALIZE_ROOT_SIGNATURE</b><br/>
/// D3D12.h
/// </summary>
unsafe public delegate int SerializeRootSignature<T0, T1> (RootSignatureDesc* pRootSignature, Direct3D.RootSignatureVersion version, T0** ppBlob, T0** ppErrorBlob) where T0 : unmanaged, Direct3D.IBlob where T1 : unmanaged, Direct3D.IBlob;

/// <summary>
/// CALLBACK <b>PFN_D3D12_CREATE_ROOT_SIGNATURE_DESERIALIZER</b><br/>
/// D3D12.h
/// </summary>
unsafe public delegate int CreateRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

/// <summary>
/// CALLBACK <b>PFN_D3D12_SERIALIZE_VERSIONED_ROOT_SIGNATURE</b><br/>
/// D3D12.h
/// </summary>
unsafe public delegate int SerializeVersionedRootSignature<T0, T1> (VersionedRootSignatureDesc* pRootSignature, T0** ppBlob, T1** ppErrorBlob) where T0 : unmanaged, Direct3D.IBlob where T1 : unmanaged, Direct3D.IBlob;

/// <summary>
/// CALLBACK <b>PFN_D3D12_CREATE_VERSIONED_ROOT_SIGNATURE_DESERIALIZER</b><br/>
/// D3D12.h
/// </summary>
unsafe public delegate int CreateVersionedRootSignatureDeserializer (void* pSrcData, nuint srcDataSizeInBytes, Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

/// <summary>
/// CALLBACK <b>PFN_D3D12_CREATE_DEVICE</b><br/>
/// D3D12.h
/// </summary>
unsafe public delegate int CreateDevice (void* pAdapter, Direct3D.FeatureLevel MinimumFeatureLevel, Guid riid, void** ppDevice);

/// <summary>
/// CALLBACK <b>PFN_D3D12_GET_DEBUG_INTERFACE</b><br/>
/// D3D12.h
/// </summary>
unsafe public delegate int GetDebugInterface (Guid riid, void** ppvDebug);

/// <summary>
/// CALLBACK <b>PFN_D3D12_GET_INTERFACE</b><br/>
/// D3D12.h
/// </summary>
unsafe public delegate int GetInterface (Guid rclsid, Guid riid, void** ppvDebug);
