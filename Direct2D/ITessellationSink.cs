using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1TessellationSink</b> : IUnknown<br/>
/// D2D1.h
/// </summary>
unsafe public interface ITessellationSink : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1TessellationSink::AddTriangles (D2D1_TRIANGLE* triangles, UINT32 trianglesCount)</b><br/>
	/// </summary>
	/// <param name="triangles">_In_reads_(trianglesCount) <b>D2D1_TRIANGLE* triangles</b></param>
	/// <param name="trianglesCount"><b>UINT32 trianglesCount</b></param>
	void AddTriangles (Triangle* triangles, uint trianglesCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TessellationSink::Close ()</b><br/>
	/// </summary>
	int Close ();
}

/// <summary>
/// Instance of <b>ID2D1TessellationSink</b><br/>
/// D2D1.h
/// </summary>
unsafe public readonly struct TessellationSink : ITessellationSink {
//unsafe public readonly struct ITessellationSinkObj : ITessellationSink {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TessellationSink* GetCurrentPointer () => (TessellationSink*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITessellationSinkObj* GetCurrentPointer () => (ITessellationSinkObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2cd906c1, 0x12e2, 0x11dc, 0x9f, 0xed, 0x00, 0x11, 0x43, 0xa0, 0x55, 0xf9);

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
	public readonly void AddTriangles (Triangle* triangles, uint trianglesCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->AddTriangles (ptr, triangles, trianglesCount);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Close () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Close (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Triangle*, uint, void> AddTriangles;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Close;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
