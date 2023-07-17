using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Device4</b> : ID2D1Device3<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IDevice4 : IDevice3 {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device4::CreateDeviceContext (D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext4** deviceContext4)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_DEVICE_CONTEXT_OPTIONS options</b></param>
	/// <param name="deviceContext4">_COM_Outptr_ <b>ID2D1DeviceContext4** deviceContext4</b></param>
	int CreateDeviceContext4<T0> (DeviceContextOptions options, T0** deviceContext4) where T0 : unmanaged, IDeviceContext4;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Device4::CreateDeviceContext (D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext4** deviceContext4)</b><br/>
	/// </summary>
	/// <param name="options"><b>D2D1_DEVICE_CONTEXT_OPTIONS options</b></param>
	/// <param name="deviceContext4">_COM_Outptr_ <b>ID2D1DeviceContext4** deviceContext4</b></param>
	int CreateDeviceContext4<T0> (DeviceContextOptions options, out T0* deviceContext4) where T0 : unmanaged, IDeviceContext4;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Device4::SetMaximumColorGlyphCacheMemory (UINT64 maximumInBytes)</b><br/>
	/// </summary>
	/// <param name="maximumInBytes"><b>UINT64 maximumInBytes</b></param>
	void SetMaximumColorGlyphCacheMemory (ulong maximumInBytes);
	/// <summary>
	/// STDMETHOD_ <b>UINT64 ID2D1Device4::GetMaximumColorGlyphCacheMemory ()</b><br/>
	/// </summary>
	ulong GetMaximumColorGlyphCacheMemory ();
}

/// <summary>
/// Instance of <b>ID2D1Device4</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct Device4 : IDevice4 {
//unsafe public readonly struct IDevice4Obj : IDevice4 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Device4* GetCurrentPointer () => (Device4*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDevice4Obj* GetCurrentPointer () => (IDevice4Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xd7bdb159, 0x5683, 0x4a46, 0xbc, 0x9c, 0x72, 0xdc, 0x72, 0x0b, 0x85, 0x8b);

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
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext1 (ptr, options, (void**) deviceContext1);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext1<T0> (DeviceContextOptions options, out T0* deviceContext1) where T0 : unmanaged, IDeviceContext1 {
		fixed (T0** _deviceContext1 = &deviceContext1) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext1 (ptr, options, (void**) _deviceContext1);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext2<T0> (DeviceContextOptions options, T0** deviceContext2) where T0 : unmanaged, IDeviceContext2 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext2 (ptr, options, (void**) deviceContext2);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext2<T0> (DeviceContextOptions options, out T0* deviceContext2) where T0 : unmanaged, IDeviceContext2 {
		fixed (T0** _deviceContext2 = &deviceContext2) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext2 (ptr, options, (void**) _deviceContext2);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void FlushDeviceContexts<T0> (T0* bitmap) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->FlushDeviceContexts (ptr, bitmap);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDxgiDevice<T0> (T0** dxgiDevice) where T0 : unmanaged, DXGI.IDevice {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDxgiDevice (ptr, (void**) dxgiDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDxgiDevice<T0> (out T0* dxgiDevice) where T0 : unmanaged, DXGI.IDevice {
		fixed (T0** _dxgiDevice = &dxgiDevice) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDxgiDevice (ptr, (void**) _dxgiDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext3<T0> (DeviceContextOptions options, T0** deviceContext3) where T0 : unmanaged, IDeviceContext3 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext3 (ptr, options, (void**) deviceContext3);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext3<T0> (DeviceContextOptions options, out T0* deviceContext3) where T0 : unmanaged, IDeviceContext3 {
		fixed (T0** _deviceContext3 = &deviceContext3) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext3 (ptr, options, (void**) _deviceContext3);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext4<T0> (DeviceContextOptions options, T0** deviceContext4) where T0 : unmanaged, IDeviceContext4 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext4 (ptr, options, (void**) deviceContext4);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateDeviceContext4<T0> (DeviceContextOptions options, out T0* deviceContext4) where T0 : unmanaged, IDeviceContext4 {
		fixed (T0** _deviceContext4 = &deviceContext4) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateDeviceContext4 (ptr, options, (void**) _deviceContext4);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetMaximumColorGlyphCacheMemory (ulong maximumInBytes) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetMaximumColorGlyphCacheMemory (ptr, maximumInBytes);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetMaximumColorGlyphCacheMemory () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMaximumColorGlyphCacheMemory (ptr);
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
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DeviceContextOptions, void**, int> CreateDeviceContext2;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> FlushDeviceContexts;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetDxgiDevice;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DeviceContextOptions, void**, int> CreateDeviceContext3;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DeviceContextOptions, void**, int> CreateDeviceContext4;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, void> SetMaximumColorGlyphCacheMemory;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetMaximumColorGlyphCacheMemory;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
