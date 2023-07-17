using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1CommandSink4</b> : ID2D1CommandSink3<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface ICommandSink4 : ICommandSink3 {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1CommandSink4::SetPrimitiveBlend2 (D2D1_PRIMITIVE_BLEND primitiveBlend)</b><br/>
	/// </summary>
	/// <param name="primitiveBlend"><b>D2D1_PRIMITIVE_BLEND primitiveBlend</b></param>
	int SetPrimitiveBlend2 (PrimitiveBlend primitiveBlend);
}

/// <summary>
/// Instance of <b>ID2D1CommandSink4</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct CommandSink4 : ICommandSink4 {
//unsafe public readonly struct ICommandSink4Obj : ICommandSink4 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly CommandSink4* GetCurrentPointer () => (CommandSink4*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ICommandSink4Obj* GetCurrentPointer () => (ICommandSink4Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc78a6519, 0x40d6, 0x4218, 0xb2, 0xde, 0xbe, 0xee, 0xb7, 0x44, 0xbb, 0x3e);

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
	public readonly int BeginDraw () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->BeginDraw (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EndDraw () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EndDraw (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetAntialiasMode (AntialiasMode antialiasMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetAntialiasMode (ptr, antialiasMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTags (ulong tag1, ulong tag2) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTags (ptr, tag1, tag2);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTextAntialiasMode (TextAntialiasMode textAntialiasMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTextAntialiasMode (ptr, textAntialiasMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTextRenderingParams<T0> (T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTextRenderingParams (ptr, textRenderingParams);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTransform (Matrix3x2F* transform) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTransform (ptr, transform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrimitiveBlend (PrimitiveBlend primitiveBlend) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrimitiveBlend (ptr, primitiveBlend);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetUnitMode (UnitMode unitMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetUnitMode (ptr, unitMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clear (Vector4F* color) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clear (ptr, color);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGlyphRun<T0> (Vector2F baselineOrigin, DirectWrite.GlyphRun* glyphRun, DirectWrite.GlyphRunDescription* glyphRunDescription, T0* foregroundBrush, DirectWrite.MeasuringMode measuringMode) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGlyphRun (ptr, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawLine<T0, T1> (Vector2F point0, Vector2F point1, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawLine (ptr, point0, point1, brush, strokeWidth, strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGeometry<T0, T1, T2> (T0* geometry, T1* brush, float strokeWidth, T2* strokeStyle) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGeometry (ptr, geometry, brush, strokeWidth, strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawRectangle<T0, T1> (Vector4F* rect, T0* brush, float strokeWidth, T1* strokeStyle) where T0 : unmanaged, IBrush where T1 : unmanaged, IStrokeStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawRectangle (ptr, rect, brush, strokeWidth, strokeStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawBitmap<T0> (T0* bitmap, Vector4F* destinationRectangle, float opacity, InterpolationMode interpolationMode, Vector4F* sourceRectangle, Matrix4x4F* perspectiveTransform) where T0 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawBitmap (ptr, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawImage<T0> (T0* image, Vector2F* targetOffset, Vector4F* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawImage (ptr, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGdiMetafile<T0> (T0* gdiMetafile, Vector2F* targetOffset) where T0 : unmanaged, IGdiMetafile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGdiMetafile (ptr, gdiMetafile, targetOffset);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillMesh<T0, T1> (T0* mesh, T1* brush) where T0 : unmanaged, IMesh where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillMesh (ptr, mesh, brush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillOpacityMask<T0, T1> (T0* opacityMask, T1* brush, Vector4F* destinationRectangle, Vector4F* sourceRectangle) where T0 : unmanaged, IBitmap where T1 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillOpacityMask (ptr, opacityMask, brush, destinationRectangle, sourceRectangle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillGeometry<T0, T1, T2> (T0* geometry, T1* brush, T2* opacityBrush) where T0 : unmanaged, IGeometry where T1 : unmanaged, IBrush where T2 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillGeometry (ptr, geometry, brush, opacityBrush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FillRectangle<T0> (Vector4F* rect, T0* brush) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FillRectangle (ptr, rect, brush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushAxisAlignedClip (Vector4F* clipRect, AntialiasMode antialiasMode) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushAxisAlignedClip (ptr, clipRect, antialiasMode);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushLayer<T0> (LayerParameters1* layerParameters1, T0* layer) where T0 : unmanaged, ILayer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushLayer (ptr, layerParameters1, layer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PopAxisAlignedClip () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PopAxisAlignedClip (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PopLayer () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PopLayer (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrimitiveBlend1 (PrimitiveBlend primitiveBlend) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrimitiveBlend1 (ptr, primitiveBlend);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawInk<T0, T1, T2> (T0* ink, T1* brush, T2* inkStyle) where T0 : unmanaged, IInk where T1 : unmanaged, IBrush where T2 : unmanaged, IInkStyle {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawInk (ptr, ink, brush, inkStyle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGradientMesh<T0> (T0* gradientMesh) where T0 : unmanaged, IGradientMesh {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawGradientMesh (ptr, gradientMesh);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawGdiMetafile<T0> (T0* gdiMetafile, Vector4F* destinationRectangle, Vector4F* sourceRectangle) where T0 : unmanaged, IGdiMetafile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_DrawGdiMetafile (ptr, gdiMetafile, destinationRectangle, sourceRectangle);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DrawSpriteBatch<T0, T1> (T0* spriteBatch, uint startIndex, uint spriteCount, T1* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions) where T0 : unmanaged, ISpriteBatch where T1 : unmanaged, IBitmap {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DrawSpriteBatch (ptr, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrimitiveBlend2 (PrimitiveBlend primitiveBlend) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrimitiveBlend2 (ptr, primitiveBlend);
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
		public readonly delegate* unmanaged[Stdcall]<void*, int> BeginDraw;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> EndDraw;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, AntialiasMode, int> SetAntialiasMode;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, int> SetTags;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, TextAntialiasMode, int> SetTextAntialiasMode;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetTextRenderingParams;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Matrix3x2F*, int> SetTransform;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PrimitiveBlend, int> SetPrimitiveBlend;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, UnitMode, int> SetUnitMode;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, int> Clear;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, DirectWrite.GlyphRun*, DirectWrite.GlyphRunDescription*, void*, DirectWrite.MeasuringMode, int> DrawGlyphRun;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, Vector2F, void*, float, void*, int> DrawLine;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, float, void*, int> DrawGeometry;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void*, float, void*, int> DrawRectangle;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, float, InterpolationMode, Vector4F*, Matrix4x4F*, int> DrawBitmap;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector2F*, Vector4F*, InterpolationMode, CompositeMode, int> DrawImage;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector2F*, int> DrawGdiMetafile;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> FillMesh;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, Vector4F*, Vector4F*, int> FillOpacityMask;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int> FillGeometry;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void*, int> FillRectangle;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, AntialiasMode, int> PushAxisAlignedClip;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LayerParameters1*, void*, int> PushLayer;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PopAxisAlignedClip;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PopLayer;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PrimitiveBlend, int> SetPrimitiveBlend1;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int> DrawInk;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> DrawGradientMesh;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4F*, Vector4F*, int> _DrawGdiMetafile;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint, void*, BitmapInterpolationMode, SpriteOptions, int> DrawSpriteBatch;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, PrimitiveBlend, int> SetPrimitiveBlend2;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
