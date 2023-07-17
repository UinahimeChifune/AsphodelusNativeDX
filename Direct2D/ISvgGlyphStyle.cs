using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgGlyphStyle</b> : ID2D1Resource<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface ISvgGlyphStyle : IResource {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgGlyphStyle::SetFill (ID2D1Brush* brush)</b><br/>
	/// </summary>
	/// <param name="brush">_In_opt_ <b>ID2D1Brush* brush</b></param>
	int SetFill<T0> (T0* brush) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgGlyphStyle::GetFill (ID2D1Brush** brush)</b><br/>
	/// </summary>
	/// <param name="brush">_Outptr_result_maybenull_ <b>ID2D1Brush** brush</b></param>
	void GetFill<T0> (T0** brush) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgGlyphStyle::GetFill (ID2D1Brush** brush)</b><br/>
	/// </summary>
	/// <param name="brush">_Outptr_result_maybenull_ <b>ID2D1Brush** brush</b></param>
	void GetFill<T0> (out T0* brush) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgGlyphStyle::SetStroke (ID2D1Brush* brush, FLOAT strokeWidth, FLOAT* dashes, UINT32 dashesCount, FLOAT dashOffset)</b><br/>
	/// </summary>
	/// <param name="brush">_In_opt_ <b>ID2D1Brush* brush</b></param>
	/// <param name="strokeWidth"><b>FLOAT strokeWidth</b></param>
	/// <param name="dashes">_In_reads_opt_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="dashOffset"><b>FLOAT dashOffset</b></param>
	int SetStroke<T0> (T0* brush, float strokeWidth, float* dashes, uint dashesCount, float dashOffset) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgGlyphStyle::GetStrokeDashesCount ()</b><br/>
	/// </summary>
	uint GetStrokeDashesCount ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgGlyphStyle::GetStroke (ID2D1Brush** brush, FLOAT* strokeWidth, FLOAT* dashes, UINT32 dashesCount, FLOAT* dashOffset)</b><br/>
	/// </summary>
	/// <param name="brush">_Outptr_opt_result_maybenull_ <b>ID2D1Brush** brush</b></param>
	/// <param name="strokeWidth">_Out_opt_ <b>FLOAT* strokeWidth</b></param>
	/// <param name="dashes">_Out_writes_opt_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="dashOffset">_Out_opt_ <b>FLOAT* dashOffset</b></param>
	void GetStroke<T0> (T0** brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset) where T0 : unmanaged, IBrush;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgGlyphStyle::GetStroke (ID2D1Brush** brush, FLOAT* strokeWidth, FLOAT* dashes, UINT32 dashesCount, FLOAT* dashOffset)</b><br/>
	/// </summary>
	/// <param name="brush">_Outptr_opt_result_maybenull_ <b>ID2D1Brush** brush</b></param>
	/// <param name="strokeWidth">_Out_opt_ <b>FLOAT* strokeWidth</b></param>
	/// <param name="dashes">_Out_writes_opt_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="dashOffset">_Out_opt_ <b>FLOAT* dashOffset</b></param>
	void GetStroke<T0> (out T0* brush, out float strokeWidth, float* dashes, uint dashesCount, out float dashOffset) where T0 : unmanaged, IBrush;
}

/// <summary>
/// Instance of <b>ID2D1SvgGlyphStyle</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct SvgGlyphStyle : ISvgGlyphStyle {
//unsafe public readonly struct ISvgGlyphStyleObj : ISvgGlyphStyle {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgGlyphStyle* GetCurrentPointer () => (SvgGlyphStyle*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgGlyphStyleObj* GetCurrentPointer () => (ISvgGlyphStyleObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xaf671749, 0xd241, 0x4db8, 0x8e, 0x41, 0xdc, 0xc2, 0xe5, 0xc1, 0xa4, 0x38);

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
	public readonly int SetFill<T0> (T0* brush) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetFill (ptr, brush);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFill<T0> (T0** brush) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetFill (ptr, (void**) brush);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFill<T0> (out T0* brush) where T0 : unmanaged, IBrush {
		fixed (T0** _brush = &brush) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetFill (ptr, (void**) _brush);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetStroke<T0> (T0* brush, float strokeWidth, float* dashes, uint dashesCount, float dashOffset) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetStroke (ptr, brush, strokeWidth, dashes, dashesCount, dashOffset);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetStrokeDashesCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStrokeDashesCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetStroke<T0> (T0** brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset) where T0 : unmanaged, IBrush {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetStroke (ptr, (void**) brush, strokeWidth, dashes, dashesCount, dashOffset);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetStroke<T0> (out T0* brush, out float strokeWidth, float* dashes, uint dashesCount, out float dashOffset) where T0 : unmanaged, IBrush {
		fixed (T0** _brush = &brush) {
			fixed (float* _strokeWidth = &strokeWidth) {
				fixed (float* _dashOffset = &dashOffset) {
					var ptr = GetCurrentPointer ();
					((FunctionPointer*) ptr->_pointer)->GetStroke (ptr, (void**) _brush, _strokeWidth, dashes, dashesCount, _dashOffset);
					return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFactory;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetFill;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFill;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, float, float*, uint, float, int> SetStroke;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetStrokeDashesCount;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, float*, float*, uint, float*, void> GetStroke;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
