using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ConcreteTransform</b> : ID2D1TransformNode<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IConcreteTransform : ITransformNode {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ConcreteTransform::SetOutputBuffer (D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)</b><br/>
	/// </summary>
	/// <param name="bufferPrecision"><b>D2D1_BUFFER_PRECISION bufferPrecision</b></param>
	/// <param name="channelDepth"><b>D2D1_CHANNEL_DEPTH channelDepth</b></param>
	int SetOutputBuffer (BufferPrecision bufferPrecision, ChannelDepth channelDepth);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1ConcreteTransform::SetCached (BOOL isCached)</b><br/>
	/// </summary>
	/// <param name="isCached"><b>BOOL isCached</b></param>
	void SetCached (bool isCached);
}

/// <summary>
/// Instance of <b>ID2D1ConcreteTransform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct ConcreteTransform : IConcreteTransform {
//unsafe public readonly struct IConcreteTransformObj : IConcreteTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ConcreteTransform* GetCurrentPointer () => (ConcreteTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IConcreteTransformObj* GetCurrentPointer () => (IConcreteTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x1a799d8a, 0x69f7, 0x4e4c, 0x9f, 0xed, 0x43, 0x7c, 0xcc, 0x66, 0x84, 0xcc);

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
	public readonly uint GetInputCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInputCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetOutputBuffer (BufferPrecision bufferPrecision, ChannelDepth channelDepth) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetOutputBuffer (ptr, bufferPrecision, channelDepth);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetCached (bool isCached) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetCached (ptr, isCached ? 1U : 0U);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetInputCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BufferPrecision, ChannelDepth, int> SetOutputBuffer;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetCached;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
