using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgStrokeDashArray</b> : ID2D1SvgAttribute<br/>
/// D2D1SVG.h
/// </summary>
unsafe public interface ISvgStrokeDashArray : ISvgAttribute {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgStrokeDashArray::RemoveDashesAtEnd (UINT32 dashesCount)</b><br/>
	/// </summary>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	int RemoveDashesAtEnd (uint dashesCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgStrokeDashArray::UpdateDashes (FLOAT* dashes, UINT32 dashesCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="dashes">_In_reads_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int UpdateDashes (float* dashes, uint dashesCount, uint startIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgStrokeDashArray::UpdateDashes (D2D1_SVG_LENGTH* dashes, UINT32 dashesCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="dashes">_In_reads_(dashesCount) <b>D2D1_SVG_LENGTH* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int UpdateDashes (SvgLength* dashes, uint dashesCount, uint startIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgStrokeDashArray::GetDashes (FLOAT* dashes, UINT32 dashesCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="dashes">_Out_writes_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int GetDashes (float* dashes, uint dashesCount, uint startIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgStrokeDashArray::GetDashes (D2D1_SVG_LENGTH* dashes, UINT32 dashesCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="dashes">_Out_writes_(dashesCount) <b>D2D1_SVG_LENGTH* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int GetDashes (SvgLength* dashes, uint dashesCount, uint startIndex);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgStrokeDashArray::GetDashesCount ()</b><br/>
	/// </summary>
	uint GetDashesCount ();
}

/// <summary>
/// Instance of <b>ID2D1SvgStrokeDashArray</b><br/>
/// D2D1SVG.h
/// </summary>
unsafe public readonly struct SvgStrokeDashArray : ISvgStrokeDashArray {
//unsafe public readonly struct ISvgStrokeDashArrayObj : ISvgStrokeDashArray {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgStrokeDashArray* GetCurrentPointer () => (SvgStrokeDashArray*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgStrokeDashArrayObj* GetCurrentPointer () => (ISvgStrokeDashArrayObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xf1c0ca52, 0x92a3, 0x4f00, 0xb4, 0xce, 0xf3, 0x56, 0x91, 0xef, 0xd9, 0xd9);

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
	public readonly int RemoveDashesAtEnd (uint dashesCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveDashesAtEnd (ptr, dashesCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UpdateDashes (float* dashes, uint dashesCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UpdateDashes (ptr, dashes, dashesCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UpdateDashes (SvgLength* dashes, uint dashesCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_UpdateDashes (ptr, dashes, dashesCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDashes (float* dashes, uint dashesCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDashes (ptr, dashes, dashesCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDashes (SvgLength* dashes, uint dashesCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetDashes (ptr, dashes, dashesCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetDashesCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDashesCount (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemoveDashesAtEnd;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, uint, uint, int> UpdateDashes;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgLength*, uint, uint, int> _UpdateDashes;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, uint, uint, int> GetDashes;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgLength*, uint, uint, int> _GetDashes;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetDashesCount;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
