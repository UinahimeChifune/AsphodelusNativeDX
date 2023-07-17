using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1DrawingStateBlock</b> : ID2D1Resource<br/>
/// D2D1.h
/// </summary>
unsafe public interface IDrawingStateBlock : IResource {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock::GetDescription (D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)</b><br/>
	/// </summary>
	/// <param name="stateDescription">_Out_ <b>D2D1_DRAWING_STATE_DESCRIPTION* stateDescription</b></param>
	void GetDescription (DrawingStateDescription* stateDescription);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock::GetDescription (D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)</b><br/>
	/// </summary>
	/// <param name="stateDescription">_Out_ <b>D2D1_DRAWING_STATE_DESCRIPTION* stateDescription</b></param>
	void GetDescription (out DrawingStateDescription stateDescription);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock::SetDescription (D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)</b><br/>
	/// </summary>
	/// <param name="stateDescription">_In_ <b>D2D1_DRAWING_STATE_DESCRIPTION* stateDescription</b></param>
	void SetDescription (DrawingStateDescription* stateDescription);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock::SetTextRenderingParams (IDWriteRenderingParams* textRenderingParams)</b><br/>
	/// </summary>
	/// <param name="textRenderingParams">_In_opt_ <b>IDWriteRenderingParams* textRenderingParams</b></param>
	void SetTextRenderingParams<T0> (T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock::GetTextRenderingParams (IDWriteRenderingParams** textRenderingParams)</b><br/>
	/// </summary>
	/// <param name="textRenderingParams">_Outptr_result_maybenull_ <b>IDWriteRenderingParams** textRenderingParams</b></param>
	void GetTextRenderingParams<T0> (T0** textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1DrawingStateBlock::GetTextRenderingParams (IDWriteRenderingParams** textRenderingParams)</b><br/>
	/// </summary>
	/// <param name="textRenderingParams">_Outptr_result_maybenull_ <b>IDWriteRenderingParams** textRenderingParams</b></param>
	void GetTextRenderingParams<T0> (out T0* textRenderingParams) where T0 : unmanaged, DirectWrite.IRenderingParams;
}

/// <summary>
/// Instance of <b>ID2D1DrawingStateBlock</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct DrawingStateBlock : IDrawingStateBlock {
//unsafe public readonly struct IDrawingStateBlockObj : IDrawingStateBlock {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DrawingStateBlock* GetCurrentPointer () => (DrawingStateBlock*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDrawingStateBlockObj* GetCurrentPointer () => (IDrawingStateBlockObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x28506e39, 0xebf6, 0x46a1, 0xbb, 0x47, 0xfd, 0x85, 0x56, 0x5a, 0xb9, 0x57);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
