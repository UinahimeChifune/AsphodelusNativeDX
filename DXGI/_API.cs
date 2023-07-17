using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// 
/// </summary>
unsafe public static partial class API {

	[LibraryImport ("DXGI.dll")]
	private static partial int CreateDXGIFactory (Guid riid, void** ppFactory);

	/// <summary>
	/// WINAPI <b>HRESULT CreateDXGIFactory (REFIID riid, void** ppFactory)</b><br/>
	/// DXGI.h<br/>
	/// DXGI.dll
	/// </summary>
	/// <!--param name="guid"><b>REFIID riid</b></param-->
	/// <param name="ppFactory">_COM_Outptr_ <b>void** ppFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory<T0> (T0** ppFactory) where T0 : unmanaged, IFactory {
		var hr = CreateDXGIFactory (T0.GUID, (void**) ppFactory);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT CreateDXGIFactory (REFIID riid, void** ppFactory)</b><br/>
	/// DXGI.h<br/>
	/// DXGI.dll
	/// </summary>
	/// <!--param name="guid"><b>REFIID riid</b></param-->
	/// <param name="ppFactory">_COM_Outptr_ <b>void** ppFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory<T0> (out T0* ppFactory) where T0 : unmanaged, IFactory {
		fixed (T0** _ppFactory = &ppFactory) {
			var hr = CreateDXGIFactory (T0.GUID, (void**) _ppFactory);
			return hr;
		}
	}

	[LibraryImport ("DXGI.dll")]
	private static partial int CreateDXGIFactory1 (Guid riid, void** ppFactory);

	/// <summary>
	/// WINAPI <b>HRESULT CreateDXGIFactory1 (REFIID riid, void** ppFactory)</b><br/>
	/// DXGI.h<br/>
	/// DXGI.dll
	/// </summary>
	/// <!--param name="guid"><b>REFIID riid</b></param-->
	/// <param name="ppFactory">_COM_Outptr_ <b>void** ppFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory1<T0> (T0** ppFactory) where T0 : unmanaged, IFactory1 {
		var hr = CreateDXGIFactory1 (T0.GUID, (void**) ppFactory);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT CreateDXGIFactory1 (REFIID riid, void** ppFactory)</b><br/>
	/// DXGI.h<br/>
	/// DXGI.dll
	/// </summary>
	/// <!--param name="guid"><b>REFIID riid</b></param-->
	/// <param name="ppFactory">_COM_Outptr_ <b>void** ppFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory1<T0> (out T0* ppFactory) where T0 : unmanaged, IFactory1 {
		fixed (T0** _ppFactory = &ppFactory) {
			var hr = CreateDXGIFactory1 (T0.GUID, (void**) _ppFactory);
			return hr;
		}
	}

	[LibraryImport ("DXGI.dll")]
	private static partial int CreateDXGIFactory2 (Guid riid, void** ppFactory);

	/// <summary>
	/// WINAPI <b>HRESULT CreateDXGIFactory2 (REFIID riid, void** ppFactory)</b><br/>
	/// DXGI1_3.h<br/>
	/// DXGI.dll
	/// </summary>
	/// <!--param name="guid"><b>REFIID riid</b></param-->
	/// <param name="ppFactory">_COM_Outptr_ <b>void** ppFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory2<T0> (T0** ppFactory) where T0 : unmanaged, IFactory2 {
		var hr = CreateDXGIFactory2 (T0.GUID, (void**) ppFactory);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT CreateDXGIFactory2 (REFIID riid, void** ppFactory)</b><br/>
	/// DXGI1_3.h<br/>
	/// DXGI.dll
	/// </summary>
	/// <!--param name="guid"><b>REFIID riid</b></param-->
	/// <param name="ppFactory">_COM_Outptr_ <b>void** ppFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory2<T0> (out T0* ppFactory) where T0 : unmanaged, IFactory2 {
		fixed (T0** _ppFactory = &ppFactory) {
			var hr = CreateDXGIFactory2 (T0.GUID, (void**) _ppFactory);
			return hr;
		}
	}

	[LibraryImport ("DXGI.dll")]
	private static partial int DXGIDeclareAdapterRemovalSupport ();

	/// <summary>
	/// WINAPI <b>HRESULT DXGIDeclareAdapterRemovalSupport ()</b><br/>
	/// DXGI1_6.h<br/>
	/// DXGI.dll
	/// </summary>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int DeclareAdapterRemovalSupport () {
		var hr = DXGIDeclareAdapterRemovalSupport ();
		return hr;
	}

	[LibraryImport ("DXGI.dll")]
	private static partial int DXGIDisableVBlankVirtualization ();

	/// <summary>
	/// WINAPI <b>HRESULT DXGIDisableVBlankVirtualization ()</b><br/>
	/// DXGI1_6.h<br/>
	/// DXGI.dll
	/// </summary>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int DisableVBlankVirtualization () {
		var hr = DXGIDisableVBlankVirtualization ();
		return hr;
	}

	[LibraryImport ("DXGIDEBUG.dll")]
	private static partial int DXGIGetDebugInterface (Guid riid, void** ppDebug);

	/// <summary>
	/// WINAPI <b>HRESULT DXGIGetDebugInterface (REFIID riid, void **ppDebug)</b><br/>
	/// DXGIDEBUG.h<br/>
	/// DXGIDEBUG.dll
	/// </summary>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppDebug"><b>void **ppDebug</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetDebugInterface (Guid riid, void** ppDebug) {
		var hr = DXGIGetDebugInterface (riid, ppDebug);
		return hr;
	}
}
