using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SpriteBatch</b> : ID2D1Resource<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface ISpriteBatch : IResource {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SpriteBatch::AddSprites (UINT32 spriteCount, D2D1_RECT_F* destinationRectangles, D2D1_RECT_U* sourceRectangles, D2D1_COLOR_F* colors, D2D1_MATRIX_3X2_F* transforms, UINT32 destinationRectanglesStride, UINT32 sourceRectanglesStride, UINT32 colorsStride, UINT32 transformsStride)</b><br/>
	/// </summary>
	/// <param name="spriteCount"><b>UINT32 spriteCount</b></param>
	/// <param name="destinationRectangles">_In_reads_bytes_(sizeof(D2D1_RECT_F) + (spriteCount - 1) * destinationRectanglesStride) <b>D2D1_RECT_F* destinationRectangles</b></param>
	/// <param name="sourceRectangles">_In_reads_bytes_opt_(sizeof(D2D1_RECT_U) + (spriteCount - 1) * sourceRectanglesStride) <b>D2D1_RECT_U* sourceRectangles</b></param>
	/// <param name="colors">_In_reads_bytes_opt_(sizeof(D2D1_COLOR_F) + (spriteCount - 1) * colorsStride) <b>D2D1_COLOR_F* colors</b></param>
	/// <param name="transforms">_In_reads_bytes_opt_(sizeof(D2D1_MATRIX_3X2_F) + (spriteCount - 1) * transformsStride) <b>D2D1_MATRIX_3X2_F* transforms</b></param>
	/// <param name="destinationRectanglesStride"><b>UINT32 destinationRectanglesStride</b></param>
	/// <param name="sourceRectanglesStride"><b>UINT32 sourceRectanglesStride</b></param>
	/// <param name="colorsStride"><b>UINT32 colorsStride</b></param>
	/// <param name="transformsStride"><b>UINT32 transformsStride</b></param>
	int AddSprites (uint spriteCount, Vector4F* destinationRectangles, Vector4U* sourceRectangles, Vector4F* colors, Matrix3x2F* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SpriteBatch::SetSprites (UINT32 startIndex, UINT32 spriteCount, D2D1_RECT_F* destinationRectangles, D2D1_RECT_U* sourceRectangles, D2D1_COLOR_F* colors, D2D1_MATRIX_3X2_F* transforms, UINT32 destinationRectanglesStride, UINT32 sourceRectanglesStride, UINT32 colorsStride, UINT32 transformsStride)</b><br/>
	/// </summary>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	/// <param name="spriteCount"><b>UINT32 spriteCount</b></param>
	/// <param name="destinationRectangles">_In_reads_bytes_opt_(sizeof(D2D1_RECT_F) + (spriteCount - 1) * destinationRectanglesStride) <b>D2D1_RECT_F* destinationRectangles</b></param>
	/// <param name="sourceRectangles">_In_reads_bytes_opt_(sizeof(D2D1_RECT_U) + (spriteCount - 1) * sourceRectanglesStride) <b>D2D1_RECT_U* sourceRectangles</b></param>
	/// <param name="colors">_In_reads_bytes_opt_(sizeof(D2D1_COLOR_F) + (spriteCount - 1) * colorsStride) <b>D2D1_COLOR_F* colors</b></param>
	/// <param name="transforms">_In_reads_bytes_opt_(sizeof(D2D1_MATRIX_3X2_F) + (spriteCount - 1) * transformsStride) <b>D2D1_MATRIX_3X2_F* transforms</b></param>
	/// <param name="destinationRectanglesStride"><b>UINT32 destinationRectanglesStride</b></param>
	/// <param name="sourceRectanglesStride"><b>UINT32 sourceRectanglesStride</b></param>
	/// <param name="colorsStride"><b>UINT32 colorsStride</b></param>
	/// <param name="transformsStride"><b>UINT32 transformsStride</b></param>
	int SetSprites (uint startIndex, uint spriteCount, Vector4F* destinationRectangles, Vector4U* sourceRectangles, Vector4F* colors, Matrix3x2F* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SpriteBatch::GetSprites (UINT32 startIndex, UINT32 spriteCount, D2D1_RECT_F* destinationRectangles, D2D1_RECT_U* sourceRectangles, D2D1_COLOR_F* colors, D2D1_MATRIX_3X2_F* transforms)</b><br/>
	/// </summary>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	/// <param name="spriteCount"><b>UINT32 spriteCount</b></param>
	/// <param name="destinationRectangles">_Out_writes_opt_(spriteCount) <b>D2D1_RECT_F* destinationRectangles</b></param>
	/// <param name="sourceRectangles">_Out_writes_opt_(spriteCount) <b>D2D1_RECT_U* sourceRectangles</b></param>
	/// <param name="colors">_Out_writes_opt_(spriteCount) <b>D2D1_COLOR_F* colors</b></param>
	/// <param name="transforms">_Out_writes_opt_(spriteCount) <b>D2D1_MATRIX_3X2_F* transforms</b></param>
	int GetSprites (uint startIndex, uint spriteCount, Vector4F* destinationRectangles, Vector4U* sourceRectangles, Vector4F* colors, Matrix3x2F* transforms);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SpriteBatch::GetSpriteCount ()</b><br/>
	/// </summary>
	uint GetSpriteCount ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SpriteBatch::Clear ()</b><br/>
	/// </summary>
	void Clear ();
}

/// <summary>
/// Instance of <b>ID2D1SpriteBatch</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct SpriteBatch : ISpriteBatch {
//unsafe public readonly struct ISpriteBatchObj : ISpriteBatch {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SpriteBatch* GetCurrentPointer () => (SpriteBatch*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISpriteBatchObj* GetCurrentPointer () => (ISpriteBatchObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x4dc583bf, 0x3a10, 0x438a, 0x87, 0x22, 0xe9, 0x76, 0x52, 0x24, 0xf1, 0xf1);

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
	public readonly int AddSprites (uint spriteCount, Vector4F* destinationRectangles, Vector4U* sourceRectangles, Vector4F* colors, Matrix3x2F* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddSprites (ptr, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSprites (uint startIndex, uint spriteCount, Vector4F* destinationRectangles, Vector4U* sourceRectangles, Vector4F* colors, Matrix3x2F* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSprites (ptr, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSprites (uint startIndex, uint spriteCount, Vector4F* destinationRectangles, Vector4U* sourceRectangles, Vector4F* colors, Matrix3x2F* transforms) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSprites (ptr, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetSpriteCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSpriteCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Clear () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Clear (ptr);
		return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Vector4F*, Vector4U*, Vector4F*, Matrix3x2F*, uint, uint, uint, uint, int> AddSprites;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, Vector4F*, Vector4U*, Vector4F*, Matrix3x2F*, uint, uint, uint, uint, int> SetSprites;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint, Vector4F*, Vector4U*, Vector4F*, Matrix3x2F*, int> GetSprites;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetSpriteCount;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> Clear;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
