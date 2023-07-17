using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteTextRenderer</b> : IDWritePixelSnapping<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ITextRenderer : IPixelSnapping {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextRenderer::DrawGlyphRun (void* clientDrawingContext, FLOAT baselineOriginX, FLOAT baselineOriginY, DWRITE_MEASURING_MODE measuringMode, DWRITE_GLYPH_RUN* glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, IUnknown* clientDrawingEffect)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="baselineOriginX"><b>FLOAT baselineOriginX</b></param>
	/// <param name="baselineOriginY"><b>FLOAT baselineOriginY</b></param>
	/// <param name="measuringMode"><b>DWRITE_MEASURING_MODE measuringMode</b></param>
	/// <param name="glyphRun">_In_ <b>DWRITE_GLYPH_RUN* glyphRun</b></param>
	/// <param name="glyphRunDescription">_In_ <b>DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription</b></param>
	/// <param name="clientDrawingEffect">_In_opt_ <b>IUnknown* clientDrawingEffect</b></param>
	int DrawGlyphRun<T0> (void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, T0* clientDrawingEffect) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextRenderer::DrawUnderline (void* clientDrawingContext, FLOAT baselineOriginX, FLOAT baselineOriginY, DWRITE_UNDERLINE* underline, IUnknown* clientDrawingEffect)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="baselineOriginX"><b>FLOAT baselineOriginX</b></param>
	/// <param name="baselineOriginY"><b>FLOAT baselineOriginY</b></param>
	/// <param name="underline">_In_ <b>DWRITE_UNDERLINE* underline</b></param>
	/// <param name="clientDrawingEffect">_In_opt_ <b>IUnknown* clientDrawingEffect</b></param>
	int DrawUnderline<T0> (void* clientDrawingContext, float baselineOriginX, float baselineOriginY, Underline* underline, T0* clientDrawingEffect) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextRenderer::DrawStrikethrough (void* clientDrawingContext, FLOAT baselineOriginX, FLOAT baselineOriginY, DWRITE_STRIKETHROUGH* strikethrough, IUnknown* clientDrawingEffect)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="baselineOriginX"><b>FLOAT baselineOriginX</b></param>
	/// <param name="baselineOriginY"><b>FLOAT baselineOriginY</b></param>
	/// <param name="strikethrough">_In_ <b>DWRITE_STRIKETHROUGH* strikethrough</b></param>
	/// <param name="clientDrawingEffect">_In_opt_ <b>IUnknown* clientDrawingEffect</b></param>
	int DrawStrikethrough<T0> (void* clientDrawingContext, float baselineOriginX, float baselineOriginY, Strikethrough* strikethrough, T0* clientDrawingEffect) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteTextRenderer::DrawInlineObject (void* clientDrawingContext, FLOAT originX, FLOAT originY, IDWriteInlineObject* inlineObject, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="originX"><b>FLOAT originX</b></param>
	/// <param name="originY"><b>FLOAT originY</b></param>
	/// <param name="inlineObject">_In_ <b>IDWriteInlineObject* inlineObject</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	/// <param name="clientDrawingEffect">_In_opt_ <b>IUnknown* clientDrawingEffect</b></param>
	int DrawInlineObject<T0, T1> (void* clientDrawingContext, float originX, float originY, T0* inlineObject, bool isSideways, bool isRightToLeft, T1* clientDrawingEffect) where T0 : unmanaged, IInlineObject where T1 : unmanaged, IUnknown;
}

/// <summary>
/// Instance of <b>IDWriteTextRenderer</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct TextRenderer : ITextRenderer {
//unsafe public readonly struct ITextRendererObj : ITextRenderer {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TextRenderer* GetCurrentPointer () => (TextRenderer*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITextRendererObj* GetCurrentPointer () => (ITextRendererObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xef8a8135, 0x5cc6, 0x45fe, 0x88, 0x25, 0xc5, 0xa0, 0x72, 0x4e, 0xb8, 0x19);

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
	public readonly int IsPixelSnappingDisabled (void* clientDrawingContext, uint* isDisabled) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsPixelSnappingDisabled (ptr, clientDrawingContext, isDisabled);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int IsPixelSnappingDisabled (void* clientDrawingContext, out bool isDisabled) {
		uint _isDisabled;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsPixelSnappingDisabled (ptr, clientDrawingContext, &_isDisabled);
		isDisabled = _isDisabled != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentTransform (void* clientDrawingContext, Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentTransform (ptr, clientDrawingContext, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentTransform (void* clientDrawingContext, out Matrix3x2F transform) {
		fixed (Matrix3x2F* _transform = &transform) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentTransform (ptr, clientDrawingContext, _transform);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelsPerDip (void* clientDrawingContext, float* pixelsPerDip) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelsPerDip (ptr, clientDrawingContext, pixelsPerDip);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPixelsPerDip (void* clientDrawingContext, out float pixelsPerDip) {
		fixed (float* _pixelsPerDip = &pixelsPerDip) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPixelsPerDip (ptr, clientDrawingContext, _pixelsPerDip);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGlyphRun<T0> (void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, T0* clientDrawingEffect) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGlyphRun (ptr, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawUnderline<T0> (void* clientDrawingContext, float baselineOriginX, float baselineOriginY, Underline* underline, T0* clientDrawingEffect) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawUnderline (ptr, clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawStrikethrough<T0> (void* clientDrawingContext, float baselineOriginX, float baselineOriginY, Strikethrough* strikethrough, T0* clientDrawingEffect) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawStrikethrough (ptr, clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawInlineObject<T0, T1> (void* clientDrawingContext, float originX, float originY, T0* inlineObject, bool isSideways, bool isRightToLeft, T1* clientDrawingEffect) where T0 : unmanaged, IInlineObject where T1 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawInlineObject (ptr, clientDrawingContext, originX, originY, inlineObject, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, clientDrawingEffect);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, int> IsPixelSnappingDisabled;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Matrix3x2F*, int> GetCurrentTransform;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float*, int> GetPixelsPerDip;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, void*, int> DrawGlyphRun;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, float, Underline*, void*, int> DrawUnderline;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, float, Strikethrough*, void*, int> DrawStrikethrough;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, float, void*, uint, uint, void*, int> DrawInlineObject;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
