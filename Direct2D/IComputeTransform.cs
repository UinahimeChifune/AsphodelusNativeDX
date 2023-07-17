using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ComputeTransform</b> : ID2D1Transform<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IComputeTransform : ITransform {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ComputeTransform::SetComputeInfo (ID2D1ComputeInfo* computeInfo)</b><br/>
	/// </summary>
	/// <param name="computeInfo">_In_ <b>ID2D1ComputeInfo* computeInfo</b></param>
	int SetComputeInfo<T0> (T0* computeInfo) where T0 : unmanaged, IComputeInfo;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ComputeTransform::CalculateThreadgroups (D2D1_RECT_L* outputRect, UINT32* dimensionX, UINT32* dimensionY, UINT32* dimensionZ)</b><br/>
	/// </summary>
	/// <param name="outputRect">_In_ <b>D2D1_RECT_L* outputRect</b></param>
	/// <param name="dimensionX">_Out_ <b>UINT32* dimensionX</b></param>
	/// <param name="dimensionY">_Out_ <b>UINT32* dimensionY</b></param>
	/// <param name="dimensionZ">_Out_ <b>UINT32* dimensionZ</b></param>
	int CalculateThreadgroups (Vector4I* outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ComputeTransform::CalculateThreadgroups (D2D1_RECT_L* outputRect, UINT32* dimensionX, UINT32* dimensionY, UINT32* dimensionZ)</b><br/>
	/// </summary>
	/// <param name="outputRect">_In_ <b>D2D1_RECT_L* outputRect</b></param>
	/// <param name="dimensionX">_Out_ <b>UINT32* dimensionX</b></param>
	/// <param name="dimensionY">_Out_ <b>UINT32* dimensionY</b></param>
	/// <param name="dimensionZ">_Out_ <b>UINT32* dimensionZ</b></param>
	int CalculateThreadgroups (Vector4I* outputRect, out uint dimensionX, out uint dimensionY, out uint dimensionZ);
}

/// <summary>
/// Instance of <b>ID2D1ComputeTransform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct ComputeTransform : IComputeTransform {
//unsafe public readonly struct IComputeTransformObj : IComputeTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ComputeTransform* GetCurrentPointer () => (ComputeTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IComputeTransformObj* GetCurrentPointer () => (IComputeTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x0d85573c, 0x01e3, 0x4f7d, 0xbf, 0xd9, 0x0d, 0x60, 0x60, 0x8b, 0xf3, 0xc3);

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
	public readonly int SetComputeInfo<T0> (T0* computeInfo) where T0 : unmanaged, IComputeInfo {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetComputeInfo (ptr, computeInfo);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CalculateThreadgroups (Vector4I* outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CalculateThreadgroups (ptr, outputRect, dimensionX, dimensionY, dimensionZ);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CalculateThreadgroups (Vector4I* outputRect, out uint dimensionX, out uint dimensionY, out uint dimensionZ) {
		fixed (uint* _dimensionX = &dimensionX) {
			fixed (uint* _dimensionY = &dimensionY) {
				fixed (uint* _dimensionZ = &dimensionZ) {
					var ptr = GetCurrentPointer ();
					var hr = ((FunctionPointer*) ptr->_pointer)->CalculateThreadgroups (ptr, outputRect, _dimensionX, _dimensionY, _dimensionZ);
					return hr;
				}
			}
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
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetComputeInfo;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, uint*, uint*, uint*, int> CalculateThreadgroups;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
