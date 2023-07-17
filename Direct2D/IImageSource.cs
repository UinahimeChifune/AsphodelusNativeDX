using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ImageSource</b> : ID2D1Image<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IImageSource : IImage {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ImageSource::OfferResources ()</b><br/>
	/// </summary>
	int OfferResources ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ImageSource::TryReclaimResources (BOOL* resourcesDiscarded)</b><br/>
	/// </summary>
	/// <param name="resourcesDiscarded">_Out_ <b>BOOL* resourcesDiscarded</b></param>
	int TryReclaimResources (uint* resourcesDiscarded);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ImageSource::TryReclaimResources (BOOL* resourcesDiscarded)</b><br/>
	/// </summary>
	/// <param name="resourcesDiscarded">_Out_ <b>BOOL* resourcesDiscarded</b></param>
	int TryReclaimResources (out bool resourcesDiscarded);
}

/// <summary>
/// Instance of <b>ID2D1ImageSource</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct ImageSource : IImageSource {
//unsafe public readonly struct IImageSourceObj : IImageSource {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ImageSource* GetCurrentPointer () => (ImageSource*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IImageSourceObj* GetCurrentPointer () => (IImageSourceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc9b664e5, 0x74a1, 0x4378, 0x9a, 0xc2, 0xee, 0xfc, 0x37, 0xa3, 0xf4, 0xd8);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
