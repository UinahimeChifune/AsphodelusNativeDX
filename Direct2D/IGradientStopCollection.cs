using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1GradientStopCollection</b> : ID2D1Resource<br/>
/// D2D1.h
/// </summary>
unsafe public interface IGradientStopCollection : IResource {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1GradientStopCollection::GetGradientStopCount ()</b><br/>
	/// </summary>
	uint GetGradientStopCount ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1GradientStopCollection::GetGradientStops (D2D1_GRADIENT_STOP* gradientStops, UINT32 gradientStopsCount)</b><br/>
	/// </summary>
	/// <param name="gradientStops">_Out_writes_to_(gradientStopsCount, _Inexpressible_("Retrieved through GetGradientStopCount()") ) <b>D2D1_GRADIENT_STOP* gradientStops</b></param>
	/// <param name="gradientStopsCount"><b>UINT32 gradientStopsCount</b></param>
	void GetGradientStops (GradientStop* gradientStops, uint gradientStopsCount);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_GAMMA ID2D1GradientStopCollection::GetColorInterpolationGamma ()</b><br/>
	/// </summary>
	Gamma GetColorInterpolationGamma ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_EXTEND_MODE ID2D1GradientStopCollection::GetExtendMode ()</b><br/>
	/// </summary>
	ExtendMode GetExtendMode ();
}

/// <summary>
/// Instance of <b>ID2D1GradientStopCollection</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct GradientStopCollection : IGradientStopCollection {
//unsafe public readonly struct IGradientStopCollectionObj : IGradientStopCollection {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GradientStopCollection* GetCurrentPointer () => (GradientStopCollection*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGradientStopCollectionObj* GetCurrentPointer () => (IGradientStopCollectionObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd906a7, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	public readonly uint GetGradientStopCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGradientStopCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetGradientStops (GradientStop* gradientStops, uint gradientStopsCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetGradientStops (ptr, gradientStops, gradientStopsCount);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Gamma GetColorInterpolationGamma () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorInterpolationGamma (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ExtendMode GetExtendMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExtendMode (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetGradientStopCount;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GradientStop*, uint, void> GetGradientStops;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Gamma> GetColorInterpolationGamma;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode> GetExtendMode;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
