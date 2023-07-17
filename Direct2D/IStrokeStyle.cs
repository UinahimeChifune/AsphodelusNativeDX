using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1StrokeStyle</b> : ID2D1Resource<br/>
/// D2D1.h
/// </summary>
unsafe public interface IStrokeStyle : IResource {
	/// <summary>
	/// STDMETHOD_ <b>D2D1_CAP_STYLE ID2D1StrokeStyle::GetStartCap ()</b><br/>
	/// </summary>
	CapStyle GetStartCap ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_CAP_STYLE ID2D1StrokeStyle::GetEndCap ()</b><br/>
	/// </summary>
	CapStyle GetEndCap ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_CAP_STYLE ID2D1StrokeStyle::GetDashCap ()</b><br/>
	/// </summary>
	CapStyle GetDashCap ();
	/// <summary>
	/// STDMETHOD_ <b>FLOAT ID2D1StrokeStyle::GetMiterLimit ()</b><br/>
	/// </summary>
	float GetMiterLimit ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_LINE_JOIN ID2D1StrokeStyle::GetLineJoin ()</b><br/>
	/// </summary>
	LineJoin GetLineJoin ();
	/// <summary>
	/// STDMETHOD_ <b>FLOAT ID2D1StrokeStyle::GetDashOffset ()</b><br/>
	/// </summary>
	float GetDashOffset ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_DASH_STYLE ID2D1StrokeStyle::GetDashStyle ()</b><br/>
	/// </summary>
	DashStyle GetDashStyle ();
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1StrokeStyle::GetDashesCount ()</b><br/>
	/// </summary>
	uint GetDashesCount ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1StrokeStyle::GetDashes (FLOAT* dashes, UINT32 dashesCount)</b><br/>
	/// </summary>
	/// <param name="dashes">_Out_writes_(dashesCount) <b>FLOAT* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	void GetDashes (float* dashes, uint dashesCount);
}

/// <summary>
/// Instance of <b>ID2D1StrokeStyle</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct StrokeStyle : IStrokeStyle {
//unsafe public readonly struct IStrokeStyleObj : IStrokeStyle {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly StrokeStyle* GetCurrentPointer () => (StrokeStyle*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IStrokeStyleObj* GetCurrentPointer () => (IStrokeStyleObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd9069d, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	public readonly CapStyle GetStartCap () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStartCap (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly CapStyle GetEndCap () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEndCap (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly CapStyle GetDashCap () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDashCap (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetMiterLimit () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMiterLimit (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly LineJoin GetLineJoin () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLineJoin (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly float GetDashOffset () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDashOffset (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly DashStyle GetDashStyle () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDashStyle (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetDashesCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDashesCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDashes (float* dashes, uint dashesCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDashes (ptr, dashes, dashesCount);
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
		public readonly delegate* unmanaged[Stdcall]<void*, CapStyle> GetStartCap;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CapStyle> GetEndCap;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, CapStyle> GetDashCap;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetMiterLimit;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, LineJoin> GetLineJoin;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float> GetDashOffset;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, DashStyle> GetDashStyle;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetDashesCount;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, uint, void> GetDashes;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
