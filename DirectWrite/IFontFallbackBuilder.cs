using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFallbackBuilder</b> : IUnknown<br/>
/// DWRITE_2.h
/// </summary>
unsafe public interface IFontFallbackBuilder : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallbackBuilder::AddMapping (DWRITE_UNICODE_RANGE* ranges, UINT32 rangesCount, WCHAR** targetFamilyNames, UINT32 targetFamilyNamesCount, IDWriteFontCollection* NULL, WCHAR* localeName, WCHAR* baseFamilyName)</b><br/>
	/// </summary>
	/// <param name="ranges">_In_reads_(rangesCount) <b>DWRITE_UNICODE_RANGE* ranges</b></param>
	/// <param name="rangesCount"><b>UINT32 rangesCount</b></param>
	/// <param name="targetFamilyNames">_In_reads_(targetFamilyNamesCount) <b>WCHAR** targetFamilyNames</b></param>
	/// <param name="targetFamilyNamesCount"><b>UINT32 targetFamilyNamesCount</b></param>
	/// <param name="nULL">_In_opt_ <b>IDWriteFontCollection* NULL</b></param>
	/// <param name="localeName">_In_opt_z_ <b>WCHAR* localeName</b></param>
	/// <param name="baseFamilyName">_In_opt_z_ <b>WCHAR* baseFamilyName</b></param>
	int AddMapping<T0> (UnicodeRange* ranges, uint rangesCount, char** targetFamilyNames, uint targetFamilyNamesCount, T0* nULL, char* localeName, char* baseFamilyName) where T0 : unmanaged, IFontCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallbackBuilder::AddMappings (IDWriteFontFallback* fontFallback)</b><br/>
	/// </summary>
	/// <param name="fontFallback"><b>IDWriteFontFallback* fontFallback</b></param>
	int AddMappings<T0> (T0* fontFallback) where T0 : unmanaged, IFontFallback;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallbackBuilder::CreateFontFallback (IDWriteFontFallback** fontFallback)</b><br/>
	/// </summary>
	/// <param name="fontFallback">_COM_Outptr_ <b>IDWriteFontFallback** fontFallback</b></param>
	int CreateFontFallback<T0> (T0** fontFallback) where T0 : unmanaged, IFontFallback;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFallbackBuilder::CreateFontFallback (IDWriteFontFallback** fontFallback)</b><br/>
	/// </summary>
	/// <param name="fontFallback">_COM_Outptr_ <b>IDWriteFontFallback** fontFallback</b></param>
	int CreateFontFallback<T0> (out T0* fontFallback) where T0 : unmanaged, IFontFallback;
}

/// <summary>
/// Instance of <b>IDWriteFontFallbackBuilder</b><br/>
/// DWRITE_2.h
/// </summary>
unsafe public readonly struct FontFallbackBuilder : IFontFallbackBuilder {
//unsafe public readonly struct IFontFallbackBuilderObj : IFontFallbackBuilder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFallbackBuilder* GetCurrentPointer () => (FontFallbackBuilder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFallbackBuilderObj* GetCurrentPointer () => (IFontFallbackBuilderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xfd882d06, 0x8aba, 0x4fb8, 0xb8, 0x49, 0x8b, 0xe8, 0xb7, 0x3e, 0x14, 0xde);

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
	public readonly int AddMapping<T0> (UnicodeRange* ranges, uint rangesCount, char** targetFamilyNames, uint targetFamilyNamesCount, T0* nULL, char* localeName, char* baseFamilyName) where T0 : unmanaged, IFontCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddMapping (ptr, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, nULL, localeName, baseFamilyName);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddMappings<T0> (T0* fontFallback) where T0 : unmanaged, IFontFallback {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddMappings (ptr, fontFallback);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFallback<T0> (T0** fontFallback) where T0 : unmanaged, IFontFallback {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFallback (ptr, (void**) fontFallback);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFallback<T0> (out T0* fontFallback) where T0 : unmanaged, IFontFallback {
		fixed (T0** _fontFallback = &fontFallback) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFallback (ptr, (void**) _fontFallback);
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
		public readonly delegate* unmanaged[Stdcall]<void*, UnicodeRange*, uint, char**, uint, void*, char*, char*, int> AddMapping;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AddMappings;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontFallback;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
