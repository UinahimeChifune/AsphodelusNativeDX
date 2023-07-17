using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ColorContext1</b> : ID2D1ColorContext<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IColorContext1 : IColorContext {
	/// <summary>
	/// STDMETHOD_ <b>D2D1_COLOR_CONTEXT_TYPE ID2D1ColorContext1::GetColorContextType ()</b><br/>
	/// </summary>
	ColorContextType GetColorContextType ();
	/// <summary>
	/// STDMETHOD_ <b>DXGI_COLOR_SPACE_TYPE ID2D1ColorContext1::GetDXGIColorSpace ()</b><br/>
	/// </summary>
	DXGI.ColorSpaceType GetDXGIColorSpace ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ColorContext1::GetSimpleColorProfile (D2D1_SIMPLE_COLOR_PROFILE* simpleProfile)</b><br/>
	/// </summary>
	/// <param name="simpleProfile">_Out_ <b>D2D1_SIMPLE_COLOR_PROFILE* simpleProfile</b></param>
	int GetSimpleColorProfile (SimpleColorProfile* simpleProfile);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ColorContext1::GetSimpleColorProfile (D2D1_SIMPLE_COLOR_PROFILE* simpleProfile)</b><br/>
	/// </summary>
	/// <param name="simpleProfile">_Out_ <b>D2D1_SIMPLE_COLOR_PROFILE* simpleProfile</b></param>
	int GetSimpleColorProfile (out SimpleColorProfile simpleProfile);
}

/// <summary>
/// Instance of <b>ID2D1ColorContext1</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct ColorContext1 : IColorContext1 {
//unsafe public readonly struct IColorContext1Obj : IColorContext1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ColorContext1* GetCurrentPointer () => (ColorContext1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IColorContext1Obj* GetCurrentPointer () => (IColorContext1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1ab42875, 0xc57f, 0x4be9, 0xbd, 0x85, 0x9c, 0xd7, 0x8d, 0x6f, 0x55, 0xee);

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
	public readonly ColorSpace GetColorSpace () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorSpace (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetProfileSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetProfileSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetProfile (byte* profile, uint profileSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetProfile (ptr, profile, profileSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ColorContextType GetColorContextType () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorContextType (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly DXGI.ColorSpaceType GetDXGIColorSpace () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDXGIColorSpace (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSimpleColorProfile (SimpleColorProfile* simpleProfile) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSimpleColorProfile (ptr, simpleProfile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSimpleColorProfile (out SimpleColorProfile simpleProfile) {
		fixed (SimpleColorProfile* _simpleProfile = &simpleProfile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSimpleColorProfile (ptr, _simpleProfile);
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
		public readonly delegate* unmanaged[Stdcall]<void*, ColorSpace> GetColorSpace;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetProfileSize;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, byte*, uint, int> GetProfile;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ColorContextType> GetColorContextType;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DXGI.ColorSpaceType> GetDXGIColorSpace;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SimpleColorProfile*, int> GetSimpleColorProfile;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
