using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ImageSourceFromWic</b> : ID2D1ImageSource<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IImageSourceFromWic : IImageSource {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ImageSourceFromWic::EnsureCached (D2D1_RECT_U* rectangleToFill)</b><br/>
	/// </summary>
	/// <param name="rectangleToFill">_In_opt_ <b>D2D1_RECT_U* rectangleToFill</b></param>
	int EnsureCached (Vector4U* rectangleToFill);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ImageSourceFromWic::TrimCache (D2D1_RECT_U* rectangleToPreserve)</b><br/>
	/// </summary>
	/// <param name="rectangleToPreserve">_In_opt_ <b>D2D1_RECT_U* rectangleToPreserve</b></param>
	int TrimCache (Vector4U* rectangleToPreserve);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageSourceFromWic::GetSource (IWICBitmapSource** wicBitmapSource)</b><br/>
	/// </summary>
	/// <param name="wicBitmapSource">_Outptr_result_maybenull_ <b>IWICBitmapSource** wicBitmapSource</b></param>
	void GetSource<T0> (T0** wicBitmapSource) where T0 : unmanaged, WIC.IBitmapSource;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ImageSourceFromWic::GetSource (IWICBitmapSource** wicBitmapSource)</b><br/>
	/// </summary>
	/// <param name="wicBitmapSource">_Outptr_result_maybenull_ <b>IWICBitmapSource** wicBitmapSource</b></param>
	void GetSource<T0> (out T0* wicBitmapSource) where T0 : unmanaged, WIC.IBitmapSource;
}

/// <summary>
/// Instance of <b>ID2D1ImageSourceFromWic</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct ImageSourceFromWic : IImageSourceFromWic {
//unsafe public readonly struct IImageSourceFromWicObj : IImageSourceFromWic {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ImageSourceFromWic* GetCurrentPointer () => (ImageSourceFromWic*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IImageSourceFromWicObj* GetCurrentPointer () => (IImageSourceFromWicObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x77395441, 0x1c8f, 0x4555, 0x86, 0x83, 0xf5, 0x0d, 0xab, 0x0f, 0xe7, 0x92);

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
	public readonly int OfferResources () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->OfferResources (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TryReclaimResources (uint* resourcesDiscarded) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->TryReclaimResources (ptr, resourcesDiscarded);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TryReclaimResources (out bool resourcesDiscarded) {
		uint _resourcesDiscarded;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->TryReclaimResources (ptr, &_resourcesDiscarded);
		resourcesDiscarded = _resourcesDiscarded != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnsureCached (Vector4U* rectangleToFill) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnsureCached (ptr, rectangleToFill);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TrimCache (Vector4U* rectangleToPreserve) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->TrimCache (ptr, rectangleToPreserve);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetSource<T0> (T0** wicBitmapSource) where T0 : unmanaged, WIC.IBitmapSource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetSource (ptr, (void**) wicBitmapSource);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetSource<T0> (out T0* wicBitmapSource) where T0 : unmanaged, WIC.IBitmapSource {
		fixed (T0** _wicBitmapSource = &wicBitmapSource) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetSource (ptr, (void**) _wicBitmapSource);
			return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, int> OfferResources;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> TryReclaimResources;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4U*, int> EnsureCached;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4U*, int> TrimCache;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetSource;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
