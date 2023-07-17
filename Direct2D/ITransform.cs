using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Transform</b> : ID2D1TransformNode<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface ITransform : ITransformNode {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Transform::MapOutputRectToInputRects (D2D1_RECT_L* outputRect, D2D1_RECT_L* inputRects, UINT32 inputRectsCount)</b><br/>
	/// </summary>
	/// <param name="outputRect">_In_ <b>D2D1_RECT_L* outputRect</b></param>
	/// <param name="inputRects">_Out_writes_(inputRectsCount) <b>D2D1_RECT_L* inputRects</b></param>
	/// <param name="inputRectsCount"><b>UINT32 inputRectsCount</b></param>
	int MapOutputRectToInputRects (Vector4I* outputRect, Vector4I* inputRects, uint inputRectsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Transform::MapInputRectsToOutputRect (D2D1_RECT_L* inputRects, D2D1_RECT_L* inputOpaqueSubRects, UINT32 inputRectCount, D2D1_RECT_L* outputRect, D2D1_RECT_L* outputOpaqueSubRect)</b><br/>
	/// </summary>
	/// <param name="inputRects">_In_reads_(inputRectCount) <b>D2D1_RECT_L* inputRects</b></param>
	/// <param name="inputOpaqueSubRects">_In_reads_(inputRectCount) <b>D2D1_RECT_L* inputOpaqueSubRects</b></param>
	/// <param name="inputRectCount"><b>UINT32 inputRectCount</b></param>
	/// <param name="outputRect">_Out_ <b>D2D1_RECT_L* outputRect</b></param>
	/// <param name="outputOpaqueSubRect">_Out_ <b>D2D1_RECT_L* outputOpaqueSubRect</b></param>
	int MapInputRectsToOutputRect (Vector4I* inputRects, Vector4I* inputOpaqueSubRects, uint inputRectCount, Vector4I* outputRect, Vector4I* outputOpaqueSubRect);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Transform::MapInputRectsToOutputRect (D2D1_RECT_L* inputRects, D2D1_RECT_L* inputOpaqueSubRects, UINT32 inputRectCount, D2D1_RECT_L* outputRect, D2D1_RECT_L* outputOpaqueSubRect)</b><br/>
	/// </summary>
	/// <param name="inputRects">_In_reads_(inputRectCount) <b>D2D1_RECT_L* inputRects</b></param>
	/// <param name="inputOpaqueSubRects">_In_reads_(inputRectCount) <b>D2D1_RECT_L* inputOpaqueSubRects</b></param>
	/// <param name="inputRectCount"><b>UINT32 inputRectCount</b></param>
	/// <param name="outputRect">_Out_ <b>D2D1_RECT_L* outputRect</b></param>
	/// <param name="outputOpaqueSubRect">_Out_ <b>D2D1_RECT_L* outputOpaqueSubRect</b></param>
	int MapInputRectsToOutputRect (Vector4I* inputRects, Vector4I* inputOpaqueSubRects, uint inputRectCount, out Vector4I outputRect, out Vector4I outputOpaqueSubRect);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Transform::MapInvalidRect (UINT32 inputIndex, D2D1_RECT_L invalidInputRect, D2D1_RECT_L* invalidOutputRect)</b><br/>
	/// </summary>
	/// <param name="inputIndex"><b>UINT32 inputIndex</b></param>
	/// <param name="invalidInputRect"><b>D2D1_RECT_L invalidInputRect</b></param>
	/// <param name="invalidOutputRect">_Out_ <b>D2D1_RECT_L* invalidOutputRect</b></param>
	int MapInvalidRect (uint inputIndex, Vector4I invalidInputRect, Vector4I* invalidOutputRect);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Transform::MapInvalidRect (UINT32 inputIndex, D2D1_RECT_L invalidInputRect, D2D1_RECT_L* invalidOutputRect)</b><br/>
	/// </summary>
	/// <param name="inputIndex"><b>UINT32 inputIndex</b></param>
	/// <param name="invalidInputRect"><b>D2D1_RECT_L invalidInputRect</b></param>
	/// <param name="invalidOutputRect">_Out_ <b>D2D1_RECT_L* invalidOutputRect</b></param>
	int MapInvalidRect (uint inputIndex, Vector4I invalidInputRect, out Vector4I invalidOutputRect);
}

/// <summary>
/// Instance of <b>ID2D1Transform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct Transform : ITransform {
//unsafe public readonly struct ITransformObj : ITransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Transform* GetCurrentPointer () => (Transform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITransformObj* GetCurrentPointer () => (ITransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xef1a287d, 0x342a, 0x4f76, 0x8f, 0xdb, 0xda, 0x0d, 0x6e, 0xa9, 0xf9, 0x2b);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
