using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICPalette</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IPalette : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::InitializePredefined (WICBitmapPaletteType ePaletteType, BOOL fAddTransparentColor)</b><br/>
	/// </summary>
	/// <param name="ePaletteType"><b>WICBitmapPaletteType ePaletteType</b></param>
	/// <param name="fAddTransparentColor"><b>BOOL fAddTransparentColor</b></param>
	int InitializePredefined (BitmapPaletteType ePaletteType, bool fAddTransparentColor);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::InitializeCustom (WICColor* pColors, UINT cCount)</b><br/>
	/// </summary>
	/// <param name="pColors">__RPC__in_ecount_full(cCount) <b>WICColor* pColors</b></param>
	/// <param name="cCount"><b>UINT cCount</b></param>
	int InitializeCustom (uint* pColors, uint cCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::InitializeFromBitmap (IWICBitmapSource* pISurface, UINT cCount, BOOL fAddTransparentColor)</b><br/>
	/// </summary>
	/// <param name="pISurface">__RPC__in_opt <b>IWICBitmapSource* pISurface</b></param>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="fAddTransparentColor"><b>BOOL fAddTransparentColor</b></param>
	int InitializeFromBitmap<T0> (T0* pISurface, uint cCount, bool fAddTransparentColor) where T0 : unmanaged, IBitmapSource;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::InitializeFromPalette (IWICPalette* pIPalette)</b><br/>
	/// </summary>
	/// <param name="pIPalette">__RPC__in_opt <b>IWICPalette* pIPalette</b></param>
	int InitializeFromPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::GetType (WICBitmapPaletteType* pePaletteType)</b><br/>
	/// </summary>
	/// <param name="pePaletteType">__RPC__out <b>WICBitmapPaletteType* pePaletteType</b></param>
	int GetType (BitmapPaletteType* pePaletteType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::GetType (WICBitmapPaletteType* pePaletteType)</b><br/>
	/// </summary>
	/// <param name="pePaletteType">__RPC__out <b>WICBitmapPaletteType* pePaletteType</b></param>
	int GetType (out BitmapPaletteType pePaletteType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::GetColorCount (UINT* pcCount)</b><br/>
	/// </summary>
	/// <param name="pcCount">__RPC__out <b>UINT* pcCount</b></param>
	int GetColorCount (uint* pcCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::GetColorCount (UINT* pcCount)</b><br/>
	/// </summary>
	/// <param name="pcCount">__RPC__out <b>UINT* pcCount</b></param>
	int GetColorCount (out uint pcCount);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::GetColors (UINT cCount, WICColor* pColors, UINT* pcActualColors)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="pColors">__RPC__out_ecount_full(cCount) <b>WICColor* pColors</b></param>
	/// <param name="pcActualColors">__RPC__out <b>UINT* pcActualColors</b></param>
	int GetColors (uint cCount, uint* pColors, uint* pcActualColors);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::GetColors (UINT cCount, WICColor* pColors, UINT* pcActualColors)</b><br/>
	/// </summary>
	/// <param name="cCount"><b>UINT cCount</b></param>
	/// <param name="pColors">__RPC__out_ecount_full(cCount) <b>WICColor* pColors</b></param>
	/// <param name="pcActualColors">__RPC__out <b>UINT* pcActualColors</b></param>
	int GetColors (uint cCount, out uint pColors, out uint pcActualColors);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::IsBlackWhite (BOOL* pfIsBlackWhite)</b><br/>
	/// </summary>
	/// <param name="pfIsBlackWhite">__RPC__out <b>BOOL* pfIsBlackWhite</b></param>
	int IsBlackWhite (uint* pfIsBlackWhite);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::IsBlackWhite (BOOL* pfIsBlackWhite)</b><br/>
	/// </summary>
	/// <param name="pfIsBlackWhite">__RPC__out <b>BOOL* pfIsBlackWhite</b></param>
	int IsBlackWhite (out bool pfIsBlackWhite);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::IsGrayscale (BOOL* pfIsGrayscale)</b><br/>
	/// </summary>
	/// <param name="pfIsGrayscale">__RPC__out <b>BOOL* pfIsGrayscale</b></param>
	int IsGrayscale (uint* pfIsGrayscale);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::IsGrayscale (BOOL* pfIsGrayscale)</b><br/>
	/// </summary>
	/// <param name="pfIsGrayscale">__RPC__out <b>BOOL* pfIsGrayscale</b></param>
	int IsGrayscale (out bool pfIsGrayscale);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::HasAlpha (BOOL* pfHasAlpha)</b><br/>
	/// </summary>
	/// <param name="pfHasAlpha">__RPC__out <b>BOOL* pfHasAlpha</b></param>
	int HasAlpha (uint* pfHasAlpha);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICPalette::HasAlpha (BOOL* pfHasAlpha)</b><br/>
	/// </summary>
	/// <param name="pfHasAlpha">__RPC__out <b>BOOL* pfHasAlpha</b></param>
	int HasAlpha (out bool pfHasAlpha);
}

/// <summary>
/// Instance of <b>IWICPalette</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct Palette : IPalette {
//unsafe public readonly struct IPaletteObj : IPalette {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Palette* GetCurrentPointer () => (Palette*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPaletteObj* GetCurrentPointer () => (IPaletteObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000040, 0xa8f2, 0x4877, 0xba, 0x0a, 0xfd, 0x2b, 0x66, 0x45, 0xfb, 0x94);

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
	public readonly int InitializePredefined (BitmapPaletteType ePaletteType, bool fAddTransparentColor) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializePredefined (ptr, ePaletteType, fAddTransparentColor ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeCustom (uint* pColors, uint cCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeCustom (ptr, pColors, cCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromBitmap<T0> (T0* pISurface, uint cCount, bool fAddTransparentColor) where T0 : unmanaged, IBitmapSource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromBitmap (ptr, pISurface, cCount, fAddTransparentColor ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InitializeFromPalette<T0> (T0* pIPalette) where T0 : unmanaged, IPalette {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InitializeFromPalette (ptr, pIPalette);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetType (BitmapPaletteType* pePaletteType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr, pePaletteType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetType (out BitmapPaletteType pePaletteType) {
		fixed (BitmapPaletteType* _pePaletteType = &pePaletteType) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr, _pePaletteType);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorCount (uint* pcCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColorCount (ptr, pcCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColorCount (out uint pcCount) {
		fixed (uint* _pcCount = &pcCount) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetColorCount (ptr, _pcCount);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColors (uint cCount, uint* pColors, uint* pcActualColors) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetColors (ptr, cCount, pColors, pcActualColors);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetColors (uint cCount, out uint pColors, out uint pcActualColors) {
		fixed (uint* _pColors = &pColors) {
			fixed (uint* _pcActualColors = &pcActualColors) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetColors (ptr, cCount, _pColors, _pcActualColors);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int IsBlackWhite (uint* pfIsBlackWhite) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsBlackWhite (ptr, pfIsBlackWhite);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int IsBlackWhite (out bool pfIsBlackWhite) {
		uint _pfIsBlackWhite;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsBlackWhite (ptr, &_pfIsBlackWhite);
		pfIsBlackWhite = _pfIsBlackWhite != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int IsGrayscale (uint* pfIsGrayscale) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsGrayscale (ptr, pfIsGrayscale);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int IsGrayscale (out bool pfIsGrayscale) {
		uint _pfIsGrayscale;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsGrayscale (ptr, &_pfIsGrayscale);
		pfIsGrayscale = _pfIsGrayscale != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HasAlpha (uint* pfHasAlpha) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasAlpha (ptr, pfHasAlpha);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int HasAlpha (out bool pfHasAlpha) {
		uint _pfHasAlpha;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasAlpha (ptr, &_pfHasAlpha);
		pfHasAlpha = _pfHasAlpha != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, BitmapPaletteType, uint, int> InitializePredefined;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint, int> InitializeCustom;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, int> InitializeFromBitmap;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> InitializeFromPalette;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BitmapPaletteType*, int> _GetType;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetColorCount;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, uint*, int> GetColors;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> IsBlackWhite;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> IsGrayscale;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> HasAlpha;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
