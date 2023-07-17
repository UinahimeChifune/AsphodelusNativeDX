using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1RenderInfo</b> : IUnknown<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IRenderInfo : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderInfo::SetInputDescription (UINT32 inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)</b><br/>
	/// </summary>
	/// <param name="inputIndex"><b>UINT32 inputIndex</b></param>
	/// <param name="inputDescription"><b>D2D1_INPUT_DESCRIPTION inputDescription</b></param>
	int SetInputDescription (uint inputIndex, InputDescription inputDescription);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1RenderInfo::SetOutputBuffer (D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)</b><br/>
	/// </summary>
	/// <param name="bufferPrecision"><b>D2D1_BUFFER_PRECISION bufferPrecision</b></param>
	/// <param name="channelDepth"><b>D2D1_CHANNEL_DEPTH channelDepth</b></param>
	int SetOutputBuffer (BufferPrecision bufferPrecision, ChannelDepth channelDepth);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderInfo::SetCached (BOOL isCached)</b><br/>
	/// </summary>
	/// <param name="isCached"><b>BOOL isCached</b></param>
	void SetCached (bool isCached);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1RenderInfo::SetInstructionCountHint (UINT32 instructionCount)</b><br/>
	/// </summary>
	/// <param name="instructionCount"><b>UINT32 instructionCount</b></param>
	void SetInstructionCountHint (uint instructionCount);
}

/// <summary>
/// Instance of <b>ID2D1RenderInfo</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct RenderInfo : IRenderInfo {
//unsafe public readonly struct IRenderInfoObj : IRenderInfo {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly RenderInfo* GetCurrentPointer () => (RenderInfo*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IRenderInfoObj* GetCurrentPointer () => (IRenderInfoObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x519ae1bd, 0xd19a, 0x420d, 0xb8, 0x49, 0x36, 0x4f, 0x59, 0x47, 0x76, 0xb7);

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
	public readonly int SetInputDescription (uint inputIndex, InputDescription inputDescription) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetInputDescription (ptr, inputIndex, inputDescription);
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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetInstructionCountHint (uint instructionCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetInstructionCountHint (ptr, instructionCount);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, InputDescription, int> SetInputDescription;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BufferPrecision, ChannelDepth, int> SetOutputBuffer;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetCached;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetInstructionCountHint;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
