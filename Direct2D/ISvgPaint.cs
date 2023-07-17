using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgPaint</b> : ID2D1SvgAttribute<br/>
/// D2D1SVG.h
/// </summary>
unsafe public interface ISvgPaint : ISvgAttribute {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPaint::SetPaintType (D2D1_SVG_PAINT_TYPE paintType)</b><br/>
	/// </summary>
	/// <param name="paintType"><b>D2D1_SVG_PAINT_TYPE paintType</b></param>
	int SetPaintType (SvgPaintType paintType);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_SVG_PAINT_TYPE ID2D1SvgPaint::GetPaintType ()</b><br/>
	/// </summary>
	SvgPaintType GetPaintType ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPaint::SetColor (D2D1_COLOR_F* color)</b><br/>
	/// </summary>
	/// <param name="color">_In_ <b>D2D1_COLOR_F* color</b></param>
	int SetColor (Vector4F* color);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgPaint::GetColor (D2D1_COLOR_F* color)</b><br/>
	/// </summary>
	/// <param name="color">_Out_ <b>D2D1_COLOR_F* color</b></param>
	void GetColor (Vector4F* color);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgPaint::GetColor (D2D1_COLOR_F* color)</b><br/>
	/// </summary>
	/// <param name="color">_Out_ <b>D2D1_COLOR_F* color</b></param>
	void GetColor (out Vector4F color);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPaint::SetId (PCWSTR id)</b><br/>
	/// </summary>
	/// <param name="id">_In_ <b>PCWSTR id</b></param>
	int SetId (char* id);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPaint::GetId (PWSTR id, UINT32 idCount)</b><br/>
	/// </summary>
	/// <param name="id">_Out_writes_(idCount) <b>PWSTR id</b></param>
	/// <param name="idCount"><b>UINT32 idCount</b></param>
	int GetId (char* id, uint idCount);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgPaint::GetIdLength ()</b><br/>
	/// </summary>
	uint GetIdLength ();
}

/// <summary>
/// Instance of <b>ID2D1SvgPaint</b><br/>
/// D2D1SVG.h
/// </summary>
unsafe public readonly struct SvgPaint : ISvgPaint {
//unsafe public readonly struct ISvgPaintObj : ISvgPaint {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgPaint* GetCurrentPointer () => (SvgPaint*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgPaintObj* GetCurrentPointer () => (ISvgPaintObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xd59bab0a, 0x68a2, 0x455b, 0xa5, 0xdc, 0x9e, 0xb2, 0x85, 0x4e, 0x24, 0x90);

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
	public readonly void GetElement<T0> (T0** element) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetElement (ptr, (void**) element);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetElement<T0> (out T0* element) where T0 : unmanaged, ISvgElement {
		fixed (T0** _element = &element) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetElement (ptr, (void**) _element);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (T0** attribute) where T0 : unmanaged, ISvgAttribute {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) attribute);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (out T0* attribute) where T0 : unmanaged, ISvgAttribute {
		fixed (T0** _attribute = &attribute) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) _attribute);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPaintType (SvgPaintType paintType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPaintType (ptr, paintType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly SvgPaintType GetPaintType () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPaintType (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetColor (Vector4F* color) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetColor (ptr, color);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetColor (Vector4F* color) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetColor (ptr, color);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetColor (out Vector4F color) {
		fixed (Vector4F* _color = &color) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetColor (ptr, _color);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetId (char* id) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetId (ptr, id);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetId (char* id, uint idCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetId (ptr, id, idCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetIdLength () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetIdLength (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFactory;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetElement;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> Clone;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgPaintType, int> SetPaintType;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgPaintType> GetPaintType;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, int> SetColor;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector4F*, void> GetColor;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> SetId;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> GetId;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetIdLength;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
