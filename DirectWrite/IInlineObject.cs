using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteInlineObject</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface IInlineObject : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInlineObject::Draw (void* clientDrawingContext, IDWriteTextRenderer* renderer, FLOAT originX, FLOAT originY, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect)</b><br/>
	/// </summary>
	/// <param name="clientDrawingContext">_In_opt_ <b>void* clientDrawingContext</b></param>
	/// <param name="renderer">_In_ <b>IDWriteTextRenderer* renderer</b></param>
	/// <param name="originX"><b>FLOAT originX</b></param>
	/// <param name="originY"><b>FLOAT originY</b></param>
	/// <param name="isSideways"><b>BOOL isSideways</b></param>
	/// <param name="isRightToLeft"><b>BOOL isRightToLeft</b></param>
	/// <param name="clientDrawingEffect">_In_opt_ <b>IUnknown* clientDrawingEffect</b></param>
	int Draw<T0, T1> (void* clientDrawingContext, T0* renderer, float originX, float originY, bool isSideways, bool isRightToLeft, T1* clientDrawingEffect) where T0 : unmanaged, ITextRenderer where T1 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInlineObject::GetMetrics (DWRITE_INLINE_OBJECT_METRICS* metrics)</b><br/>
	/// </summary>
	/// <param name="metrics">_Out_ <b>DWRITE_INLINE_OBJECT_METRICS* metrics</b></param>
	int GetMetrics (InlineObjectMetrics* metrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInlineObject::GetMetrics (DWRITE_INLINE_OBJECT_METRICS* metrics)</b><br/>
	/// </summary>
	/// <param name="metrics">_Out_ <b>DWRITE_INLINE_OBJECT_METRICS* metrics</b></param>
	int GetMetrics (out InlineObjectMetrics metrics);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInlineObject::GetOverhangMetrics (DWRITE_OVERHANG_METRICS* overhangs)</b><br/>
	/// </summary>
	/// <param name="overhangs">_Out_ <b>DWRITE_OVERHANG_METRICS* overhangs</b></param>
	int GetOverhangMetrics (OverhangMetrics* overhangs);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInlineObject::GetOverhangMetrics (DWRITE_OVERHANG_METRICS* overhangs)</b><br/>
	/// </summary>
	/// <param name="overhangs">_Out_ <b>DWRITE_OVERHANG_METRICS* overhangs</b></param>
	int GetOverhangMetrics (out OverhangMetrics overhangs);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInlineObject::GetBreakConditions (DWRITE_BREAK_CONDITION* breakConditionBefore, DWRITE_BREAK_CONDITION* breakConditionAfter)</b><br/>
	/// </summary>
	/// <param name="breakConditionBefore">_Out_ <b>DWRITE_BREAK_CONDITION* breakConditionBefore</b></param>
	/// <param name="breakConditionAfter">_Out_ <b>DWRITE_BREAK_CONDITION* breakConditionAfter</b></param>
	int GetBreakConditions (BreakCondition* breakConditionBefore, BreakCondition* breakConditionAfter);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteInlineObject::GetBreakConditions (DWRITE_BREAK_CONDITION* breakConditionBefore, DWRITE_BREAK_CONDITION* breakConditionAfter)</b><br/>
	/// </summary>
	/// <param name="breakConditionBefore">_Out_ <b>DWRITE_BREAK_CONDITION* breakConditionBefore</b></param>
	/// <param name="breakConditionAfter">_Out_ <b>DWRITE_BREAK_CONDITION* breakConditionAfter</b></param>
	int GetBreakConditions (out BreakCondition breakConditionBefore, out BreakCondition breakConditionAfter);
}

/// <summary>
/// Instance of <b>IDWriteInlineObject</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct InlineObject : IInlineObject {
//unsafe public readonly struct IInlineObjectObj : IInlineObject {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly InlineObject* GetCurrentPointer () => (InlineObject*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IInlineObjectObj* GetCurrentPointer () => (IInlineObjectObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x8339fde3, 0x106f, 0x47ab, 0x83, 0x73, 0x1c, 0x62, 0x95, 0xeb, 0x10, 0xb3);

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
	public readonly int Draw<T0, T1> (void* clientDrawingContext, T0* renderer, float originX, float originY, bool isSideways, bool isRightToLeft, T1* clientDrawingEffect) where T0 : unmanaged, ITextRenderer where T1 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Draw (ptr, clientDrawingContext, renderer, originX, originY, isSideways ? 1U : 0U, isRightToLeft ? 1U : 0U, clientDrawingEffect);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetrics (InlineObjectMetrics* metrics) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, metrics);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetrics (out InlineObjectMetrics metrics) {
		fixed (InlineObjectMetrics* _metrics = &metrics) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetrics (ptr, _metrics);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetOverhangMetrics (OverhangMetrics* overhangs) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetOverhangMetrics (ptr, overhangs);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetOverhangMetrics (out OverhangMetrics overhangs) {
		fixed (OverhangMetrics* _overhangs = &overhangs) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetOverhangMetrics (ptr, _overhangs);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBreakConditions (BreakCondition* breakConditionBefore, BreakCondition* breakConditionAfter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakConditions (ptr, breakConditionBefore, breakConditionAfter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetBreakConditions (out BreakCondition breakConditionBefore, out BreakCondition breakConditionAfter) {
		fixed (BreakCondition* _breakConditionBefore = &breakConditionBefore) {
			fixed (BreakCondition* _breakConditionAfter = &breakConditionAfter) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakConditions (ptr, _breakConditionBefore, _breakConditionAfter);
				return hr;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, float, float, uint, uint, void*, int> Draw;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InlineObjectMetrics*, int> GetMetrics;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OverhangMetrics*, int> GetOverhangMetrics;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BreakCondition*, BreakCondition*, int> GetBreakConditions;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
