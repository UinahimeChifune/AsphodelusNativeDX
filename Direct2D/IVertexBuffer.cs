using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1VertexBuffer</b> : IUnknown<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IVertexBuffer : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1VertexBuffer::Map (BYTE** data, UINT32 bufferSize)</b><br/>
	/// </summary>
	/// <param name="data">_Outptr_result_bytebuffer_(bufferSize) <b>BYTE** data</b></param>
	/// <param name="bufferSize"><b>UINT32 bufferSize</b></param>
	int Map (byte** data, uint bufferSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1VertexBuffer::Map (BYTE** data, UINT32 bufferSize)</b><br/>
	/// </summary>
	/// <param name="data">_Outptr_result_bytebuffer_(bufferSize) <b>BYTE** data</b></param>
	/// <param name="bufferSize"><b>UINT32 bufferSize</b></param>
	int Map (out byte* data, uint bufferSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1VertexBuffer::Unmap ()</b><br/>
	/// </summary>
	int Unmap ();
}

/// <summary>
/// Instance of <b>ID2D1VertexBuffer</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct VertexBuffer : IVertexBuffer {
//unsafe public readonly struct IVertexBufferObj : IVertexBuffer {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VertexBuffer* GetCurrentPointer () => (VertexBuffer*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IVertexBufferObj* GetCurrentPointer () => (IVertexBufferObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9b8b1336, 0x00a5, 0x4668, 0x92, 0xb7, 0xce, 0xd5, 0xd8, 0xbf, 0x9b, 0x7b);

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
	public readonly int Map (byte** data, uint bufferSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, data, bufferSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Map (out byte* data, uint bufferSize) {
		fixed (byte** _data = &data) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Map (ptr, _data, bufferSize);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Unmap () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Unmap (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, byte**, uint, int> Map;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Unmap;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
