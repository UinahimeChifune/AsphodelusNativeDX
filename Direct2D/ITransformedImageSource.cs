using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1TransformedImageSource</b> : ID2D1Image<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface ITransformedImageSource : IImage {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1TransformedImageSource::GetSource (ID2D1ImageSource** imageSource)</b><br/>
	/// </summary>
	/// <param name="imageSource">_Outptr_result_maybenull_ <b>ID2D1ImageSource** imageSource</b></param>
	void GetSource<T0> (T0** imageSource) where T0 : unmanaged, IImageSource;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1TransformedImageSource::GetSource (ID2D1ImageSource** imageSource)</b><br/>
	/// </summary>
	/// <param name="imageSource">_Outptr_result_maybenull_ <b>ID2D1ImageSource** imageSource</b></param>
	void GetSource<T0> (out T0* imageSource) where T0 : unmanaged, IImageSource;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1TransformedImageSource::GetProperties (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)</b><br/>
	/// </summary>
	/// <param name="properties">_Out_ <b>D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties</b></param>
	void GetProperties (TransformedImageSourceProperties* properties);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1TransformedImageSource::GetProperties (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)</b><br/>
	/// </summary>
	/// <param name="properties">_Out_ <b>D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties</b></param>
	void GetProperties (out TransformedImageSourceProperties properties);
}

/// <summary>
/// Instance of <b>ID2D1TransformedImageSource</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct TransformedImageSource : ITransformedImageSource {
//unsafe public readonly struct ITransformedImageSourceObj : ITransformedImageSource {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TransformedImageSource* GetCurrentPointer () => (TransformedImageSource*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITransformedImageSourceObj* GetCurrentPointer () => (ITransformedImageSourceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x7f1f79e5, 0x2796, 0x416c, 0x8f, 0x55, 0x70, 0x0f, 0x91, 0x14, 0x45, 0xe5);

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
	public readonly void GetSource<T0> (T0** imageSource) where T0 : unmanaged, IImageSource {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetSource (ptr, (void**) imageSource);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetSource<T0> (out T0* imageSource) where T0 : unmanaged, IImageSource {
		fixed (T0** _imageSource = &imageSource) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetSource (ptr, (void**) _imageSource);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetProperties (TransformedImageSourceProperties* properties) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetProperties (ptr, properties);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetProperties (out TransformedImageSourceProperties properties) {
		fixed (TransformedImageSourceProperties* _properties = &properties) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetProperties (ptr, _properties);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetSource;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TransformedImageSourceProperties*, void> GetProperties;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
