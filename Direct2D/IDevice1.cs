using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Device1</b> : ID2D1Device<br/>
/// D2D1_2.h
/// </summary>
unsafe public interface IDevice1 : IDevice {
	/// <summary>
	/// STDMETHOD_ <b>D2D1_RENDERING_PRIORITY ID2D1Device1::GetRenderingPriority ()</b><br/>
	/// </summary>
	RenderingPriority GetRenderingPriority ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Device1::SetRenderingPriority (D2D1_RENDERING_PRIORITY renderingPriority)</b><br/>
	/// </summary>
	/// <param name="renderingPriority"><b>D2D1_RENDERING_PRIORITY renderingPriority</b></param>
	void SetRenderingPriority (RenderingPriority renderingPriority);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device1::CreateDeviceContext (D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext1** deviceContext1)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_DEVICE_CONTEXT_OPTIONS options</b></param>
	/// <param name="deviceContext1">_COM_Outptr_ <b>ID2D1DeviceContext1** deviceContext1</b></param>
	int CreateDeviceContext1<T0> (DeviceContextOptions options, T0** deviceContext1) where T0 : unmanaged, IDeviceContext1;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device1::CreateDeviceContext (D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext1** deviceContext1)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_DEVICE_CONTEXT_OPTIONS options</b></param>
	/// <param name="deviceContext1">_COM_Outptr_ <b>ID2D1DeviceContext1** deviceContext1</b></param>
	int CreateDeviceContext1<T0> (DeviceContextOptions options, out T0* deviceContext1) where T0 : unmanaged, IDeviceContext1;
}

/// <summary>
/// Instance of <b>ID2D1Device1</b><br/>
/// D2D1_2.h
/// </summary>
unsafe public readonly struct Device1 : IDevice1 {
//unsafe public readonly struct IDevice1Obj : IDevice1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device1* GetCurrentPointer () => (Device1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDevice1Obj* GetCurrentPointer () => (IDevice1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xd21768e1, 0x23a4, 0x4823, 0xa1, 0x4b, 0x7c, 0x3e, 0xba, 0x85, 0xd6, 0x58);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly RenderingPriority GetRenderingPriority () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRenderingPriority (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetRenderingPriority (RenderingPriority renderingPriority) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetRenderingPriority (ptr, renderingPriority);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext1<T0> (DeviceContextOptions options, T0** deviceContext1) where T0 : unmanaged, IDeviceContext1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext (ptr, options, (void**) deviceContext1);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext1<T0> (DeviceContextOptions options, out T0* deviceContext1) where T0 : unmanaged, IDeviceContext1 {
		fixed (T0** _deviceContext1 = &deviceContext1) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext (ptr, options, (void**) _deviceContext1);
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
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RenderingPriority> GetRenderingPriority;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, RenderingPriority, void> SetRenderingPriority;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DeviceContextOptions, void**, int> CreateDeviceContext1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
