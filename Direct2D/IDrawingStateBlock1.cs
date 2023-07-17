using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1DrawingStateBlock1</b> : ID2D1DrawingStateBlock<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IDrawingStateBlock1 : IDrawingStateBlock {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock1::GetDescription (D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)</b><br/>
	/// </summary>
	/// <param name="stateDescription">_Out_ <b>D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription</b></param>
	void GetDescription (DrawingStateDescription1* stateDescription);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock1::GetDescription (D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)</b><br/>
	/// </summary>
	/// <param name="stateDescription">_Out_ <b>D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription</b></param>
	void GetDescription (out DrawingStateDescription1 stateDescription);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock1::SetDescription (D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)</b><br/>
	/// </summary>
	/// <param name="stateDescription">_In_ <b>D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription</b></param>
	void SetDescription (DrawingStateDescription1* stateDescription);
}

/// <summary>
/// Instance of <b>ID2D1DrawingStateBlock1</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct DrawingStateBlock1 : IDrawingStateBlock1 {
//unsafe public readonly struct IDrawingStateBlock1Obj : IDrawingStateBlock1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DrawingStateBlock1* GetCurrentPointer () => (DrawingStateBlock1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDrawingStateBlock1Obj* GetCurrentPointer () => (IDrawingStateBlock1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x689f1f85, 0xc72e, 0x4e33, 0x8f, 0x19, 0x85, 0x75, 0x4e, 0xfd, 0x5a, 0xce);

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
	public readonly void GetDescription (DrawingStateDescription* stateDescription) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDescription (ptr, stateDescription);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDescription (out DrawingStateDescription stateDescription) {
		fixed (DrawingStateDescription* _stateDescription = &stateDescription) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDescription (ptr, _stateDescription);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetDescription (DrawingStateDescription* stateDescription) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetDescription (ptr, stateDescription);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetTextRenderingParams<T0> (T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetTextRenderingParams (ptr, textRenderingParams);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTextRenderingParams<T0> (T0** textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetTextRenderingParams (ptr, (void**) textRenderingParams);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetTextRenderingParams<T0> (out T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams {
		fixed (T0** _textRenderingParams = &textRenderingParams) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetTextRenderingParams (ptr, (void**) _textRenderingParams);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDescription (DrawingStateDescription1* stateDescription) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDescription1 (ptr, stateDescription);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDescription (out DrawingStateDescription1 stateDescription) {
		fixed (DrawingStateDescription1* _stateDescription = &stateDescription) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDescription1 (ptr, _stateDescription);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetDescription (DrawingStateDescription1* stateDescription) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetDescription1 (ptr, stateDescription);
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
		public readonly delegate* unmanaged[Stdcall]<void*, DrawingStateDescription*, void> GetDescription;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DrawingStateDescription*, void> SetDescription;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void> SetTextRenderingParams;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetTextRenderingParams;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DrawingStateDescription1*, void> GetDescription1;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DrawingStateDescription1*, void> SetDescription1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
