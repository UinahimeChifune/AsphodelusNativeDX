using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// 
/// </summary>
unsafe public static partial class API {

	[LibraryImport ("D2D1.dll")]
	private static partial int D2D1CreateFactory (FactoryType factoryType, Guid riid, FactoryOptions* pFactoryOptions, void** ppIFactory);

	/// <summary>
	/// WINAPI <b>HRESULT D2D1CreateFactory (D2D1_FACTORY_TYPE factoryType, REFIID riid, D2D1_FACTORY_OPTIONS *pFactoryOptions, void **ppIFactory)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="factoryType">_In_ <b>D2D1_FACTORY_TYPE factoryType</b></param>
	/// <!--param name="riid">_In_ <b>REFIID riid</b></param-->
	/// <param name="pFactoryOptions">_In_opt_ <b>D2D1_FACTORY_OPTIONS *pFactoryOptions</b></param>
	/// <param name="ppIFactory">_Out_ <b>void **ppIFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory<T0> (FactoryType factoryType, FactoryOptions* pFactoryOptions, T0** ppIFactory) where T0 : unmanaged, IFactory {
		var hr = D2D1CreateFactory (factoryType, T0.GUID, pFactoryOptions, (void**) ppIFactory);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D2D1CreateFactory (D2D1_FACTORY_TYPE factoryType, REFIID riid, D2D1_FACTORY_OPTIONS *pFactoryOptions, void **ppIFactory)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="factoryType">_In_ <b>D2D1_FACTORY_TYPE factoryType</b></param>
	/// <!--param name="riid">_In_ <b>REFIID riid</b></param-->
	/// <param name="pFactoryOptions">_In_opt_ <b>D2D1_FACTORY_OPTIONS *pFactoryOptions</b></param>
	/// <param name="ppIFactory">_Out_ <b>void **ppIFactory</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateFactory<T0> (FactoryType factoryType, FactoryOptions* pFactoryOptions, out T0* ppIFactory) where T0 : unmanaged, IFactory {
		fixed (T0** _ppIFactory = &ppIFactory) {
			var hr = D2D1CreateFactory (factoryType, T0.GUID, pFactoryOptions, (void**) _ppIFactory);
			return hr;
		}
	}

	[LibraryImport ("D2D1.dll")]
	private static partial void D2D1MakeRotateMatrix (float angle, Vector2F center, Matrix3x2F* matrix);

	/// <summary>
	/// WINAPI <b>void D2D1MakeRotateMatrix (FLOAT angle, D2D1_POINT_2F center, D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="angle">_In_ <b>FLOAT angle</b></param>
	/// <param name="center">_In_ <b>D2D1_POINT_2F center</b></param>
	/// <param name="matrix">_Out_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static void MakeRotateMatrix (float angle, Vector2F center, Matrix3x2F* matrix) {
		D2D1MakeRotateMatrix (angle, center, matrix);
	}

	/// <summary>
	/// WINAPI <b>void D2D1MakeRotateMatrix (FLOAT angle, D2D1_POINT_2F center, D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="angle">_In_ <b>FLOAT angle</b></param>
	/// <param name="center">_In_ <b>D2D1_POINT_2F center</b></param>
	/// <param name="matrix">_Out_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static void MakeRotateMatrix (float angle, Vector2F center, out Matrix3x2F matrix) {
		fixed (Matrix3x2F* _matrix = &matrix) {
			D2D1MakeRotateMatrix (angle, center, _matrix);
		}
	}

	[LibraryImport ("D2D1.dll")]
	private static partial void D2D1MakeSkewMatrix (float angleX, float angleY, Vector2F center, Matrix3x2F* matrix);

	/// <summary>
	/// WINAPI <b>void D2D1MakeSkewMatrix (FLOAT angleX, FLOAT angleY, D2D1_POINT_2F center, D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="angleX">_In_ <b>FLOAT angleX</b></param>
	/// <param name="angleY">_In_ <b>FLOAT angleY</b></param>
	/// <param name="center">_In_ <b>D2D1_POINT_2F center</b></param>
	/// <param name="matrix">_Out_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static void MakeSkewMatrix (float angleX, float angleY, Vector2F center, Matrix3x2F* matrix) {
		D2D1MakeSkewMatrix (angleX, angleY, center, matrix);
	}

	/// <summary>
	/// WINAPI <b>void D2D1MakeSkewMatrix (FLOAT angleX, FLOAT angleY, D2D1_POINT_2F center, D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="angleX">_In_ <b>FLOAT angleX</b></param>
	/// <param name="angleY">_In_ <b>FLOAT angleY</b></param>
	/// <param name="center">_In_ <b>D2D1_POINT_2F center</b></param>
	/// <param name="matrix">_Out_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static void MakeSkewMatrix (float angleX, float angleY, Vector2F center, out Matrix3x2F matrix) {
		fixed (Matrix3x2F* _matrix = &matrix) {
			D2D1MakeSkewMatrix (angleX, angleY, center, _matrix);
		}
	}

	[LibraryImport ("D2D1.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	private static partial bool D2D1IsMatrixInvertible (Matrix3x2F* matrix);

	/// <summary>
	/// WINAPI <b>BOOL D2D1IsMatrixInvertible (D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="matrix">_In_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool IsMatrixInvertible (Matrix3x2F* matrix) {
		var hr = D2D1IsMatrixInvertible (matrix);
		return hr;
	}

	[LibraryImport ("D2D1.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	private static partial bool D2D1InvertMatrix (Matrix3x2F* matrix);

	/// <summary>
	/// WINAPI <b>BOOL D2D1InvertMatrix (D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="matrix">_Inout_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool InvertMatrix (Matrix3x2F* matrix) {
		var hr = D2D1InvertMatrix (matrix);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>BOOL D2D1InvertMatrix (D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="matrix">_Inout_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool InvertMatrix (ref Matrix3x2F matrix) {
		fixed (Matrix3x2F* _matrix = &matrix) {
			return D2D1InvertMatrix (_matrix);
		}
	}

	[LibraryImport ("D2D1.dll")]
	private static partial int D2D1CreateDevice (void* dxgiDevice, CreationProperties* creationProperties, void** d2dDevice);

	/// <summary>
	/// WINAPI <b>HRESULT D2D1CreateDevice (IDXGIDevice *dxgiDevice, D2D1_CREATION_PROPERTIES *creationProperties, ID2D1Device **d2dDevice)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="dxgiDevice">_In_ <b>IDXGIDevice *dxgiDevice</b></param>
	/// <param name="creationProperties">_In_opt_ <b>D2D1_CREATION_PROPERTIES *creationProperties</b></param>
	/// <param name="d2dDevice">_Outptr_ <b>ID2D1Device **d2dDevice</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDevice<T0, T1> (T0* dxgiDevice, CreationProperties* creationProperties, T1** d2dDevice) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice {
		var hr = D2D1CreateDevice (dxgiDevice, creationProperties, (void**) d2dDevice);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D2D1CreateDevice (IDXGIDevice *dxgiDevice, D2D1_CREATION_PROPERTIES *creationProperties, ID2D1Device **d2dDevice)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="dxgiDevice">_In_ <b>IDXGIDevice *dxgiDevice</b></param>
	/// <param name="creationProperties">_In_opt_ <b>D2D1_CREATION_PROPERTIES *creationProperties</b></param>
	/// <param name="d2dDevice">_Outptr_ <b>ID2D1Device **d2dDevice</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDevice<T0, T1> (T0* dxgiDevice, CreationProperties* creationProperties, out T1* d2dDevice) where T0 : unmanaged, DXGI.IDevice where T1 : unmanaged, IDevice {
		fixed (T1** _d2dDevice = &d2dDevice) {
			var hr = D2D1CreateDevice (dxgiDevice, creationProperties, (void**) _d2dDevice);
			return hr;
		}
	}

	[LibraryImport ("D2D1.dll")]
	private static partial int D2D1CreateDeviceContext (void* dxgiSurface, CreationProperties* creationProperties, void** d2dDeviceContext);

	/// <summary>
	/// WINAPI <b>HRESULT D2D1CreateDeviceContext (IDXGISurface *dxgiSurface, D2D1_CREATION_PROPERTIES *creationProperties, ID2D1DeviceContext **d2dDeviceContext)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="dxgiSurface">_In_ <b>IDXGISurface *dxgiSurface</b></param>
	/// <param name="creationProperties">_In_opt_ <b>D2D1_CREATION_PROPERTIES *creationProperties</b></param>
	/// <param name="d2dDeviceContext">_Outptr_ <b>ID2D1DeviceContext **d2dDeviceContext</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDeviceContext<T0, T1> (T0* dxgiSurface, CreationProperties* creationProperties, T1** d2dDeviceContext) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IDeviceContext {
		var hr = D2D1CreateDeviceContext (dxgiSurface, creationProperties, (void**) d2dDeviceContext);
		return hr;
	}

	/// <summary>
	/// WINAPI <b>HRESULT D2D1CreateDeviceContext (IDXGISurface *dxgiSurface, D2D1_CREATION_PROPERTIES *creationProperties, ID2D1DeviceContext **d2dDeviceContext)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="dxgiSurface">_In_ <b>IDXGISurface *dxgiSurface</b></param>
	/// <param name="creationProperties">_In_opt_ <b>D2D1_CREATION_PROPERTIES *creationProperties</b></param>
	/// <param name="d2dDeviceContext">_Outptr_ <b>ID2D1DeviceContext **d2dDeviceContext</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CreateDeviceContext<T0, T1> (T0* dxgiSurface, CreationProperties* creationProperties, out T1* d2dDeviceContext) where T0 : unmanaged, DXGI.ISurface where T1 : unmanaged, IDeviceContext {
		fixed (T1** _d2dDeviceContext = &d2dDeviceContext) {
			var hr = D2D1CreateDeviceContext (dxgiSurface, creationProperties, (void**) _d2dDeviceContext);
			return hr;
		}
	}

	[LibraryImport ("D2D1.dll")]
	private static partial Vector4F D2D1ConvertColorSpace (ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, Vector4F* color);

	/// <summary>
	/// WINAPI <b>D2D1_COLOR_F D2D1ConvertColorSpace (D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, D2D1_COLOR_F* color)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="sourceColorSpace"><b>D2D1_COLOR_SPACE sourceColorSpace</b></param>
	/// <param name="destinationColorSpace"><b>D2D1_COLOR_SPACE destinationColorSpace</b></param>
	/// <param name="color">_In_ <b>D2D1_COLOR_F* color</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4F ConvertColorSpace (ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, Vector4F* color) {
		var hr = D2D1ConvertColorSpace (sourceColorSpace, destinationColorSpace, color);
		return hr;
	}

	[LibraryImport ("D2D1.dll")]
	private static partial void D2D1SinCos (float angle, float* s, float* c);

	/// <summary>
	/// WINAPI <b>void D2D1SinCos (FLOAT angle, FLOAT *s, FLOAT *c)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="angle">_In_ <b>FLOAT angle</b></param>
	/// <param name="s">_Out_ <b>FLOAT *s</b></param>
	/// <param name="c">_Out_ <b>FLOAT *c</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	private static void SinCos (float angle, float* s, float* c) {
		D2D1SinCos (angle, s, c);
	}

	/// <summary>
	/// WINAPI <b>void D2D1SinCos (FLOAT angle, FLOAT *s, FLOAT *c)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="angle">_In_ <b>FLOAT angle</b></param>
	/// <param name="s">_Out_ <b>FLOAT *s</b></param>
	/// <param name="c">_Out_ <b>FLOAT *c</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	private static void SinCos (float angle, out float s, out float c) {
		fixed (float* _s = &s) {
			fixed (float* _c = &c) {
				D2D1SinCos (angle, _s, _c);
			}
		}
	}

	[LibraryImport ("D2D1.dll")]
	private static partial float D2D1Tan (float angle);

	/// <summary>
	/// WINAPI <b>FLOAT D2D1Tan (FLOAT angle)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="angle">_In_ <b>FLOAT angle</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static float Tan (float angle) {
		var hr = D2D1Tan (angle);
		return hr;
	}

	[LibraryImport ("D2D1.dll")]
	private static partial float D2D1Vec3Length (float x, float y, float z);

	/// <summary>
	/// WINAPI <b>FLOAT D2D1Vec3Length (FLOAT angle)</b><br/>
	/// D2D1_1.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="x">_In_ <b>FLOAT x</b></param>
	/// <param name="y">_In_ <b>FLOAT y</b></param>
	/// <param name="z">_In_ <b>FLOAT z</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static float Vec3Length (float x, float y, float z) {
		var hr = D2D1Vec3Length (x, y, z);
		return hr;
	}

	[LibraryImport ("D2D1.dll")]
	private static partial float D2D1ComputeMaximumScaleFactor (Matrix3x2F* matrix);

	/// <summary>
	/// WINAPI <b>FLOAT D2D1ComputeMaximumScaleFactor (D2D1_MATRIX_3X2_F *matrix)</b><br/>
	/// D2D1_2.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="matrix">_In_ <b>D2D1_MATRIX_3X2_F *matrix</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static float ComputeMaximumScaleFactor (Matrix3x2F* matrix) {
		var hr = D2D1ComputeMaximumScaleFactor (matrix);
		return hr;
	}

	[LibraryImport ("D2D1.dll")]
	private static partial void D2D1GetGradientMeshInteriorPointsFromCoonsPatch (Vector2F* pPoint0, Vector2F* pPoint1, Vector2F* pPoint2, Vector2F* pPoint3, Vector2F* pPoint4, Vector2F* pPoint5, Vector2F* pPoint6, Vector2F* pPoint7, Vector2F* pPoint8, Vector2F* pPoint9, Vector2F* pPoint10, Vector2F* pPoint11, Vector2F* pTensorPoint11, Vector2F* pTensorPoint12, Vector2F* pTensorPoint21, Vector2F* pTensorPoint22);

	/// <summary>
	/// WINAPI <b>void D2D1GetGradientMeshInteriorPointsFromCoonsPatch (D2D1_POINT_2F *pPoint0, D2D1_POINT_2F *pPoint1, D2D1_POINT_2F *pPoint2, D2D1_POINT_2F *pPoint3, D2D1_POINT_2F *pPoint4, D2D1_POINT_2F *pPoint5, D2D1_POINT_2F *pPoint6, D2D1_POINT_2F *pPoint7, D2D1_POINT_2F *pPoint8, D2D1_POINT_2F *pPoint9, D2D1_POINT_2F *pPoint10, D2D1_POINT_2F *pPoint11, D2D1_POINT_2F *pTensorPoint11, D2D1_POINT_2F *pTensorPoint12, D2D1_POINT_2F *pTensorPoint21, D2D1_POINT_2F *pTensorPoint22)</b><br/>
	/// D2D1_3.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="pPoint0">_In_ <b>D2D1_POINT_2F *pPoint0</b></param>
	/// <param name="pPoint1">_In_ <b>D2D1_POINT_2F *pPoint1</b></param>
	/// <param name="pPoint2">_In_ <b>D2D1_POINT_2F *pPoint2</b></param>
	/// <param name="pPoint3">_In_ <b>D2D1_POINT_2F *pPoint3</b></param>
	/// <param name="pPoint4">_In_ <b>D2D1_POINT_2F *pPoint4</b></param>
	/// <param name="pPoint5">_In_ <b>D2D1_POINT_2F *pPoint5</b></param>
	/// <param name="pPoint6">_In_ <b>D2D1_POINT_2F *pPoint6</b></param>
	/// <param name="pPoint7">_In_ <b>D2D1_POINT_2F *pPoint7</b></param>
	/// <param name="pPoint8">_In_ <b>D2D1_POINT_2F *pPoint8</b></param>
	/// <param name="pPoint9">_In_ <b>D2D1_POINT_2F *pPoint9</b></param>
	/// <param name="pPoint10">_In_ <b>D2D1_POINT_2F *pPoint10</b></param>
	/// <param name="pPoint11">_In_ <b>D2D1_POINT_2F *pPoint11</b></param>
	/// <param name="pTensorPoint11">_Out_ <b>D2D1_POINT_2F *pTensorPoint11</b></param>
	/// <param name="pTensorPoint12">_Out_ <b>D2D1_POINT_2F *pTensorPoint12</b></param>
	/// <param name="pTensorPoint21">_Out_ <b>D2D1_POINT_2F *pTensorPoint21</b></param>
	/// <param name="pTensorPoint22">_Out_ <b>D2D1_POINT_2F *pTensorPoint22</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static void GetGradientMeshInteriorPointsFromCoonsPatch (Vector2F* pPoint0, Vector2F* pPoint1, Vector2F* pPoint2, Vector2F* pPoint3, Vector2F* pPoint4, Vector2F* pPoint5, Vector2F* pPoint6, Vector2F* pPoint7, Vector2F* pPoint8, Vector2F* pPoint9, Vector2F* pPoint10, Vector2F* pPoint11, Vector2F* pTensorPoint11, Vector2F* pTensorPoint12, Vector2F* pTensorPoint21, Vector2F* pTensorPoint22) {
		D2D1GetGradientMeshInteriorPointsFromCoonsPatch (pPoint0, pPoint1, pPoint2, pPoint3, pPoint4, pPoint5, pPoint6, pPoint7, pPoint8, pPoint9, pPoint10, pPoint11, pTensorPoint11, pTensorPoint12, pTensorPoint21, pTensorPoint22);
	}

	/// <summary>
	/// WINAPI <b>void D2D1GetGradientMeshInteriorPointsFromCoonsPatch (D2D1_POINT_2F *pPoint0, D2D1_POINT_2F *pPoint1, D2D1_POINT_2F *pPoint2, D2D1_POINT_2F *pPoint3, D2D1_POINT_2F *pPoint4, D2D1_POINT_2F *pPoint5, D2D1_POINT_2F *pPoint6, D2D1_POINT_2F *pPoint7, D2D1_POINT_2F *pPoint8, D2D1_POINT_2F *pPoint9, D2D1_POINT_2F *pPoint10, D2D1_POINT_2F *pPoint11, D2D1_POINT_2F *pTensorPoint11, D2D1_POINT_2F *pTensorPoint12, D2D1_POINT_2F *pTensorPoint21, D2D1_POINT_2F *pTensorPoint22)</b><br/>
	/// D2D1_3.h<br/>
	/// D2D1.dll
	/// </summary>
	/// <param name="pPoint0">_In_ <b>D2D1_POINT_2F *pPoint0</b></param>
	/// <param name="pPoint1">_In_ <b>D2D1_POINT_2F *pPoint1</b></param>
	/// <param name="pPoint2">_In_ <b>D2D1_POINT_2F *pPoint2</b></param>
	/// <param name="pPoint3">_In_ <b>D2D1_POINT_2F *pPoint3</b></param>
	/// <param name="pPoint4">_In_ <b>D2D1_POINT_2F *pPoint4</b></param>
	/// <param name="pPoint5">_In_ <b>D2D1_POINT_2F *pPoint5</b></param>
	/// <param name="pPoint6">_In_ <b>D2D1_POINT_2F *pPoint6</b></param>
	/// <param name="pPoint7">_In_ <b>D2D1_POINT_2F *pPoint7</b></param>
	/// <param name="pPoint8">_In_ <b>D2D1_POINT_2F *pPoint8</b></param>
	/// <param name="pPoint9">_In_ <b>D2D1_POINT_2F *pPoint9</b></param>
	/// <param name="pPoint10">_In_ <b>D2D1_POINT_2F *pPoint10</b></param>
	/// <param name="pPoint11">_In_ <b>D2D1_POINT_2F *pPoint11</b></param>
	/// <param name="pTensorPoint11">_Out_ <b>D2D1_POINT_2F *pTensorPoint11</b></param>
	/// <param name="pTensorPoint12">_Out_ <b>D2D1_POINT_2F *pTensorPoint12</b></param>
	/// <param name="pTensorPoint21">_Out_ <b>D2D1_POINT_2F *pTensorPoint21</b></param>
	/// <param name="pTensorPoint22">_Out_ <b>D2D1_POINT_2F *pTensorPoint22</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static void GetGradientMeshInteriorPointsFromCoonsPatch (Vector2F* pPoint0, Vector2F* pPoint1, Vector2F* pPoint2, Vector2F* pPoint3, Vector2F* pPoint4, Vector2F* pPoint5, Vector2F* pPoint6, Vector2F* pPoint7, Vector2F* pPoint8, Vector2F* pPoint9, Vector2F* pPoint10, Vector2F* pPoint11, out Vector2F pTensorPoint11, out Vector2F pTensorPoint12, out Vector2F pTensorPoint21, out Vector2F pTensorPoint22) {
		fixed (Vector2F* _pTensorPoint11 = &pTensorPoint11) {
			fixed (Vector2F* _pTensorPoint12 = &pTensorPoint12) {
				fixed (Vector2F* _pTensorPoint21 = &pTensorPoint21) {
					fixed (Vector2F* _pTensorPoint22 = &pTensorPoint22) {
						D2D1GetGradientMeshInteriorPointsFromCoonsPatch (pPoint0, pPoint1, pPoint2, pPoint3, pPoint4, pPoint5, pPoint6, pPoint7, pPoint8, pPoint9, pPoint10, pPoint11, _pTensorPoint11, _pTensorPoint12, _pTensorPoint21, _pTensorPoint22);
					}
				}
			}
		}
	}
}
