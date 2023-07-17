using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICStreamProvider</b> : IUnknown<br/>
/// WINCODECSDK.h
/// </summary>
unsafe public interface IStreamProvider : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStreamProvider::GetStream (IStream** ppIStream)</b><br/>
	/// </summary>
	/// <param name="ppIStream">__RPC__deref_out_opt <b>IStream** ppIStream</b></param>
	int GetStream<T0> (T0** ppIStream) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStreamProvider::GetStream (IStream** ppIStream)</b><br/>
	/// </summary>
	/// <param name="ppIStream">__RPC__deref_out_opt <b>IStream** ppIStream</b></param>
	int GetStream<T0> (out T0* ppIStream) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStreamProvider::GetPersistOptions (DWORD* pdwPersistOptions)</b><br/>
	/// </summary>
	/// <param name="pdwPersistOptions">__RPC__out <b>DWORD* pdwPersistOptions</b></param>
	int GetPersistOptions (uint* pdwPersistOptions);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStreamProvider::GetPersistOptions (DWORD* pdwPersistOptions)</b><br/>
	/// </summary>
	/// <param name="pdwPersistOptions">__RPC__out <b>DWORD* pdwPersistOptions</b></param>
	int GetPersistOptions (out uint pdwPersistOptions);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStreamProvider::GetPreferredVendorGUID (GUID* pguidPreferredVendor)</b><br/>
	/// </summary>
	/// <param name="pguidPreferredVendor">__RPC__out <b>GUID* pguidPreferredVendor</b></param>
	int GetPreferredVendorGUID (Guid* pguidPreferredVendor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStreamProvider::GetPreferredVendorGUID (GUID* pguidPreferredVendor)</b><br/>
	/// </summary>
	/// <param name="pguidPreferredVendor">__RPC__out <b>GUID* pguidPreferredVendor</b></param>
	int GetPreferredVendorGUID (out Guid pguidPreferredVendor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICStreamProvider::RefreshStream ()</b><br/>
	/// </summary>
	int RefreshStream ();
}

/// <summary>
/// Instance of <b>IWICStreamProvider</b><br/>
/// WINCODECSDK.h
/// </summary>
unsafe public readonly struct StreamProvider : IStreamProvider {
//unsafe public readonly struct IStreamProviderObj : IStreamProvider {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly StreamProvider* GetCurrentPointer () => (StreamProvider*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IStreamProviderObj* GetCurrentPointer () => (IStreamProviderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x449494bc, 0xb468, 0x4927, 0x96, 0xd7, 0xba, 0x90, 0xd3, 0x1a, 0xb5, 0x05);

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
	public readonly int GetStream<T0> (T0** ppIStream) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStream (ptr, (void**) ppIStream);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStream<T0> (out T0* ppIStream) where T0 : unmanaged, IStream {
		fixed (T0** _ppIStream = &ppIStream) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetStream (ptr, (void**) _ppIStream);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPersistOptions (uint* pdwPersistOptions) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPersistOptions (ptr, pdwPersistOptions);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPersistOptions (out uint pdwPersistOptions) {
		fixed (uint* _pdwPersistOptions = &pdwPersistOptions) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPersistOptions (ptr, _pdwPersistOptions);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPreferredVendorGUID (Guid* pguidPreferredVendor) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPreferredVendorGUID (ptr, pguidPreferredVendor);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPreferredVendorGUID (out Guid pguidPreferredVendor) {
		fixed (Guid* _pguidPreferredVendor = &pguidPreferredVendor) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPreferredVendorGUID (ptr, _pguidPreferredVendor);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RefreshStream () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RefreshStream (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetStream;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetPersistOptions;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetPreferredVendorGUID;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> RefreshStream;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
