using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Device</b> : ID2D1Resource<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IDevice : IResource {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device::CreateDeviceContext (D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_DEVICE_CONTEXT_OPTIONS options</b></param>
	/// <param name="deviceContext">_COM_Outptr_ <b>ID2D1DeviceContext** deviceContext</b></param>
	int CreateDeviceContext<T0> (DeviceContextOptions options, T0** deviceContext) where T0 : unmanaged, IDeviceContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device::CreateDeviceContext (D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_DEVICE_CONTEXT_OPTIONS options</b></param>
	/// <param name="deviceContext">_COM_Outptr_ <b>ID2D1DeviceContext** deviceContext</b></param>
	int CreateDeviceContext<T0> (DeviceContextOptions options, out T0* deviceContext) where T0 : unmanaged, IDeviceContext;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device::CreatePrintControl (IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl)</b><br/>
	/// </summary>
	/// <param name="wicFactory">_In_ <b>IWICImagingFactory* wicFactory</b></param>
	/// <param name="documentTarget">_In_ <b>IPrintDocumentPackageTarget* documentTarget</b></param>
	/// <param name="printControlProperties">_In_opt_ <b>D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties</b></param>
	/// <param name="printControl">_COM_Outptr_ <b>ID2D1PrintControl** printControl</b></param>
	[Obsolete ("'IPrintDocumentPackageTarget' not supported", true)]
	int CreatePrintControl<T0, T1> (T0* wicFactory, void* documentTarget, PrintControlProperties* printControlProperties, T1** printControl) where T0 : unmanaged, WIC.IImagingFactory where T1 : unmanaged, IPrintControl;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device::CreatePrintControl (IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl)</b><br/>
	/// </summary>
	/// <param name="wicFactory">_In_ <b>IWICImagingFactory* wicFactory</b></param>
	/// <param name="documentTarget">_In_ <b>IPrintDocumentPackageTarget* documentTarget</b></param>
	/// <param name="printControlProperties">_In_opt_ <b>D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties</b></param>
	/// <param name="printControl">_COM_Outptr_ <b>ID2D1PrintControl** printControl</b></param>
	[Obsolete ("'IPrintDocumentPackageTarget' not supported", true)]
	int CreatePrintControl<T0, T1> (T0* wicFactory, void* documentTarget, PrintControlProperties* printControlProperties, out T1* printControl) where T0 : unmanaged, WIC.IImagingFactory where T1 : unmanaged, IPrintControl;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Device::SetMaximumTextureMemory (UINT64 maximumInBytes)</b><br/>
	/// </summary>
	/// <param name="maximumInBytes"><b>UINT64 maximumInBytes</b></param>
	void SetMaximumTextureMemory (ulong maximumInBytes);
	/// <summary>
	/// STDMETHOD_ <b>UINT64 ID2D1Device::GetMaximumTextureMemory ()</b><br/>
	/// </summary>
	ulong GetMaximumTextureMemory ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Device::ClearResources (UINT32 millisecondsSinceUse)</b><br/>
	/// </summary>
	/// <param name="millisecondsSinceUse"><b>UINT32 millisecondsSinceUse</b></param>
	void ClearResources (uint millisecondsSinceUse);
}

/// <summary>
/// Instance of <b>ID2D1Device</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct Device : IDevice {
//unsafe public readonly struct IDeviceObj : IDevice {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device* GetCurrentPointer () => (Device*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDeviceObj* GetCurrentPointer () => (IDeviceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x47dd575d, 0xac05, 0x4cdd, 0x80, 0x49, 0x9b, 0x02, 0xcd, 0x16, 0xf4, 0x4c);

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
	public readonly void GetFactory<T0> (T0** factory) where T0 : unmanaged, IFactory {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) factory);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFactory<T0> (out T0* factory) where T0 : unmanaged, IFactory {
		fixed (T0** _factory = &factory) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) _factory);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext<T0> (DeviceContextOptions options, T0** deviceContext) where T0 : unmanaged, IDeviceContext {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext (ptr, options, (void**) deviceContext);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext<T0> (DeviceContextOptions options, out T0* deviceContext) where T0 : unmanaged, IDeviceContext {
		fixed (T0** _deviceContext = &deviceContext) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext (ptr, options, (void**) _deviceContext);
			return hr;
		}
	}

	/// <inheritdoc />
	[Obsolete ("'IPrintDocumentPackageTarget' not supported", true)]
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePrintControl<T0, T1> (T0* wicFactory, void* documentTarget, PrintControlProperties* printControlProperties, T1** printControl) where T0 : unmanaged, WIC.IImagingFactory where T1 : unmanaged, IPrintControl {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePrintControl (ptr, wicFactory, documentTarget, printControlProperties, (void**) printControl);
		return hr;
	}

	/// <inheritdoc />
	[Obsolete ("'IPrintDocumentPackageTarget' not supported", true)]
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePrintControl<T0, T1> (T0* wicFactory, void* documentTarget, PrintControlProperties* printControlProperties, out T1* printControl) where T0 : unmanaged, WIC.IImagingFactory where T1 : unmanaged, IPrintControl {
		fixed (T1** _printControl = &printControl) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePrintControl (ptr, wicFactory, documentTarget, printControlProperties, (void**) _printControl);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetMaximumTextureMemory (ulong maximumInBytes) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetMaximumTextureMemory (ptr, maximumInBytes);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetMaximumTextureMemory () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMaximumTextureMemory (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearResources (uint millisecondsSinceUse) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearResources (ptr, millisecondsSinceUse);
		return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFactory;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DeviceContextOptions, void**, int> CreateDeviceContext;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		[Obsolete ("'IPrintDocumentPackageTarget' not supported", true)]
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, PrintControlProperties*, void**, int> CreatePrintControl;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, void> SetMaximumTextureMemory;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetMaximumTextureMemory;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> ClearResources;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
