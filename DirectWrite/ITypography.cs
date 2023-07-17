using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTypography</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ITypography : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTypography::AddFontFeature (DWRITE_FONT_FEATURE fontFeature)</b><br/>
	/// </summary>
	/// <param name="fontFeature"><b>DWRITE_FONT_FEATURE fontFeature</b></param>
	int AddFontFeature (FontFeature fontFeature);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteTypography::GetFontFeatureCount ()</b><br/>
	/// </summary>
	uint GetFontFeatureCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTypography::GetFontFeature (UINT32 fontFeatureIndex, DWRITE_FONT_FEATURE* fontFeature)</b><br/>
	/// </summary>
	/// <param name="fontFeatureIndex"><b>UINT32 fontFeatureIndex</b></param>
	/// <param name="fontFeature">_Out_ <b>DWRITE_FONT_FEATURE* fontFeature</b></param>
	int GetFontFeature (uint fontFeatureIndex, FontFeature* fontFeature);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTypography::GetFontFeature (UINT32 fontFeatureIndex, DWRITE_FONT_FEATURE* fontFeature)</b><br/>
	/// </summary>
	/// <param name="fontFeatureIndex"><b>UINT32 fontFeatureIndex</b></param>
	/// <param name="fontFeature">_Out_ <b>DWRITE_FONT_FEATURE* fontFeature</b></param>
	int GetFontFeature (uint fontFeatureIndex, out FontFeature fontFeature);
}

/// <summary>
/// Instance of <b>IDWriteTypography</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct Typography : ITypography {
//unsafe public readonly struct ITypographyObj : ITypography {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Typography* GetCurrentPointer () => (Typography*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITypographyObj* GetCurrentPointer () => (ITypographyObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x55f1112b, 0x1dc2, 0x4b3c, 0x95, 0x41, 0xf4, 0x68, 0x94, 0xed, 0x85, 0xb6);

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
	public readonly int AddFontFeature (FontFeature fontFeature) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddFontFeature (ptr, fontFeature);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontFeatureCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFeatureCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFeature (uint fontFeatureIndex, FontFeature* fontFeature) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFeature (ptr, fontFeatureIndex, fontFeature);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFeature (uint fontFeatureIndex, out FontFeature fontFeature) {
		fixed (FontFeature* _fontFeature = &fontFeature) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFeature (ptr, fontFeatureIndex, _fontFeature);
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
		public readonly delegate* unmanaged[Stdcall]<void*, FontFeature, int> AddFontFeature;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontFeatureCount;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, FontFeature*, int> GetFontFeature;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
