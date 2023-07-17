using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgAttribute</b> : ID2D1Resource<br/>
/// D2D1SVG.h
/// </summary>
unsafe public interface ISvgAttribute : IResource {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgAttribute::GetElement (ID2D1SvgElement** element)</b><br/>
	/// </summary>
	/// <param name="element">_Outptr_result_maybenull_ <b>ID2D1SvgElement** element</b></param>
	void GetElement<T0> (T0** element) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgAttribute::GetElement (ID2D1SvgElement** element)</b><br/>
	/// </summary>
	/// <param name="element">_Outptr_result_maybenull_ <b>ID2D1SvgElement** element</b></param>
	void GetElement<T0> (out T0* element) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgAttribute::Clone (ID2D1SvgAttribute** attribute)</b><br/>
	/// </summary>
	/// <param name="attribute">_COM_Outptr_ <b>ID2D1SvgAttribute** attribute</b></param>
	int Clone<T0> (T0** attribute) where T0 : unmanaged, ISvgAttribute;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgAttribute::Clone (ID2D1SvgAttribute** attribute)</b><br/>
	/// </summary>
	/// <param name="attribute">_COM_Outptr_ <b>ID2D1SvgAttribute** attribute</b></param>
	int Clone<T0> (out T0* attribute) where T0 : unmanaged, ISvgAttribute;
}

/// <summary>
/// Instance of <b>ID2D1SvgAttribute</b><br/>
/// D2D1SVG.h
/// </summary>
unsafe public readonly struct SvgAttribute : ISvgAttribute {
//unsafe public readonly struct ISvgAttributeObj : ISvgAttribute {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgAttribute* GetCurrentPointer () => (SvgAttribute*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgAttributeObj* GetCurrentPointer () => (ISvgAttributeObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc9cdb0dd, 0xf8c9, 0x4e70, 0xb7, 0xc2, 0x30, 0x1c, 0x80, 0x29, 0x2c, 0x5e);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
