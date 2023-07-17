using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1BoundsAdjustmentTransform</b> : ID2D1TransformNode<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IBoundsAdjustmentTransform : ITransformNode {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BoundsAdjustmentTransform::SetOutputBounds (D2D1_RECT_L* outputBounds)</b><br/>
	/// </summary>
	/// <param name="outputBounds">_In_ <b>D2D1_RECT_L* outputBounds</b></param>
	void SetOutputBounds (Vector4I* outputBounds);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BoundsAdjustmentTransform::GetOutputBounds (D2D1_RECT_L* outputBounds)</b><br/>
	/// </summary>
	/// <param name="outputBounds">_Out_ <b>D2D1_RECT_L* outputBounds</b></param>
	void GetOutputBounds (Vector4I* outputBounds);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BoundsAdjustmentTransform::GetOutputBounds (D2D1_RECT_L* outputBounds)</b><br/>
	/// </summary>
	/// <param name="outputBounds">_Out_ <b>D2D1_RECT_L* outputBounds</b></param>
	void GetOutputBounds (out Vector4I outputBounds);
}

/// <summary>
/// Instance of <b>ID2D1BoundsAdjustmentTransform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct BoundsAdjustmentTransform : IBoundsAdjustmentTransform {
//unsafe public readonly struct IBoundsAdjustmentTransformObj : IBoundsAdjustmentTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BoundsAdjustmentTransform* GetCurrentPointer () => (BoundsAdjustmentTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBoundsAdjustmentTransformObj* GetCurrentPointer () => (IBoundsAdjustmentTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x90f732e2, 0x5092, 0x4606, 0xa8, 0x19, 0x86, 0x51, 0x97, 0x0b, 0xac, 0xcd);

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
	public readonly void SetOutputBounds (Vector4I* outputBounds) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetOutputBounds (ptr, outputBounds);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetOutputBounds (Vector4I* outputBounds) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetOutputBounds (ptr, outputBounds);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetOutputBounds (out Vector4I outputBounds) {
		fixed (Vector4I* _outputBounds = &outputBounds) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetOutputBounds (ptr, _outputBounds);
			return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, void> SetOutputBounds;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4I*, void> GetOutputBounds;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
