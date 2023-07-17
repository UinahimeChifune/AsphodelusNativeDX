using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1GradientStopCollection1</b> : ID2D1GradientStopCollection<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IGradientStopCollection1 : IGradientStopCollection {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1GradientStopCollection1::GetGradientStops1 (D2D1_GRADIENT_STOP* gradientStops, UINT32 gradientStopsCount)</b><br/>
	/// </summary>
	/// <param name="gradientStops">_Out_writes_to_(gradientStopsCount, _Inexpressible_("Retrieved through GetGradientStopCount()") ) <b>D2D1_GRADIENT_STOP* gradientStops</b></param>
	/// <param name="gradientStopsCount"><b>UINT32 gradientStopsCount</b></param>
	void GetGradientStops1 (GradientStop* gradientStops, uint gradientStopsCount);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_COLOR_SPACE ID2D1GradientStopCollection1::GetPreInterpolationSpace ()</b><br/>
	/// </summary>
	ColorSpace GetPreInterpolationSpace ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_COLOR_SPACE ID2D1GradientStopCollection1::GetPostInterpolationSpace ()</b><br/>
	/// </summary>
	ColorSpace GetPostInterpolationSpace ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_BUFFER_PRECISION ID2D1GradientStopCollection1::GetBufferPrecision ()</b><br/>
	/// </summary>
	BufferPrecision GetBufferPrecision ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_COLOR_INTERPOLATION_MODE ID2D1GradientStopCollection1::GetColorInterpolationMode ()</b><br/>
	/// </summary>
	ColorInterpolationMode GetColorInterpolationMode ();
}

/// <summary>
/// Instance of <b>ID2D1GradientStopCollection1</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct GradientStopCollection1 : IGradientStopCollection1 {
//unsafe public readonly struct IGradientStopCollection1Obj : IGradientStopCollection1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GradientStopCollection1* GetCurrentPointer () => (GradientStopCollection1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGradientStopCollection1Obj* GetCurrentPointer () => (IGradientStopCollection1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xae1572f4, 0x5dd0, 0x4777, 0x99, 0x8b, 0x92, 0x79, 0x47, 0x2a, 0xe6, 0x3b);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetGradientStops1 (GradientStop* gradientStops, uint gradientStopsCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetGradientStops1 (ptr, gradientStops, gradientStopsCount);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ColorSpace GetPreInterpolationSpace () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPreInterpolationSpace (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ColorSpace GetPostInterpolationSpace () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPostInterpolationSpace (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly BufferPrecision GetBufferPrecision () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBufferPrecision (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ColorInterpolationMode GetColorInterpolationMode () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorInterpolationMode (ptr);
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
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GradientStop*, uint, void> GetGradientStops1;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorSpace> GetPreInterpolationSpace;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorSpace> GetPostInterpolationSpace;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BufferPrecision> GetBufferPrecision;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorInterpolationMode> GetColorInterpolationMode;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
