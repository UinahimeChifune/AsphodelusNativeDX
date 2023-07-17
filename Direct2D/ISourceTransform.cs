using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SourceTransform</b> : ID2D1Transform<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface ISourceTransform : ITransform {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SourceTransform::SetRenderInfo (ID2D1RenderInfo* renderInfo)</b><br/>
	/// </summary>
	/// <param name="renderInfo">_In_ <b>ID2D1RenderInfo* renderInfo</b></param>
	int SetRenderInfo<T0> (T0* renderInfo) where T0 : unmanaged, IRenderInfo;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SourceTransform::Draw (ID2D1Bitmap1* target, D2D1_RECT_L* drawRect, D2D1_POINT_2U targetOrigin)</b><br/>
	/// </summary>
	/// <param name="target">_In_ <b>ID2D1Bitmap1* target</b></param>
	/// <param name="drawRect">_In_ <b>D2D1_RECT_L* drawRect</b></param>
	/// <param name="targetOrigin"><b>D2D1_POINT_2U targetOrigin</b></param>
	int Draw<T0> (T0* target, Vector4I* drawRect, Vector2U targetOrigin) where T0 : unmanaged, IBitmap1;
}

/// <summary>
/// Instance of <b>ID2D1SourceTransform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct SourceTransform : ISourceTransform {
//unsafe public readonly struct ISourceTransformObj : ISourceTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SourceTransform* GetCurrentPointer () => (SourceTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISourceTransformObj* GetCurrentPointer () => (ISourceTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xdb1800dd, 0x0c34, 0x4cf9, 0xbe, 0x90, 0x31, 0xcc, 0x0a, 0x56, 0x53, 0xe1);

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
	public readonly uint GetInputCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInputCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapOutputRectToInputRects (Vector4I* outputRect, Vector4I* inputRects, uint inputRectsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MapOutputRectToInputRects (ptr, outputRect, inputRects, inputRectsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapInputRectsToOutputRect (Vector4I* inputRects, Vector4I* inputOpaqueSubRects, uint inputRectCount, Vector4I* outputRect, Vector4I* outputOpaqueSubRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MapInputRectsToOutputRect (ptr, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapInputRectsToOutputRect (Vector4I* inputRects, Vector4I* inputOpaqueSubRects, uint inputRectCount, out Vector4I outputRect, out Vector4I outputOpaqueSubRect) {
		fixed (Vector4I* _outputRect = &outputRect) {
			fixed (Vector4I* _outputOpaqueSubRect = &outputOpaqueSubRect) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->MapInputRectsToOutputRect (ptr, inputRects, inputOpaqueSubRects, inputRectCount, _outputRect, _outputOpaqueSubRect);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapInvalidRect (uint inputIndex, Vector4I invalidInputRect, Vector4I* invalidOutputRect) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->MapInvalidRect (ptr, inputIndex, invalidInputRect, invalidOutputRect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int MapInvalidRect (uint inputIndex, Vector4I invalidInputRect, out Vector4I invalidOutputRect) {
		fixed (Vector4I* _invalidOutputRect = &invalidOutputRect) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->MapInvalidRect (ptr, inputIndex, invalidInputRect, _invalidOutputRect);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetRenderInfo<T0> (T0* renderInfo) where T0 : unmanaged, IRenderInfo {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetRenderInfo (ptr, renderInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Draw<T0> (T0* target, Vector4I* drawRect, Vector2U targetOrigin) where T0 : unmanaged, IBitmap1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Draw (ptr, target, drawRect, targetOrigin);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetInputCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, Vector4I*, uint, int> MapOutputRectToInputRects;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, Vector4I*, uint, Vector4I*, Vector4I*, int> MapInputRectsToOutputRect;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, Vector4I, Vector4I*, int> MapInvalidRect;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetRenderInfo;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector4I*, Vector2U, int> Draw;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
