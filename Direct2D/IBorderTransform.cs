using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1BorderTransform</b> : ID2D1ConcreteTransform<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IBorderTransform : IConcreteTransform {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BorderTransform::SetExtendModeX (D2D1_EXTEND_MODE extendMode)</b><br/>
	/// </summary>
	/// <param name="extendMode"><b>D2D1_EXTEND_MODE extendMode</b></param>
	void SetExtendModeX (ExtendMode extendMode);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BorderTransform::SetExtendModeY (D2D1_EXTEND_MODE extendMode)</b><br/>
	/// </summary>
	/// <param name="extendMode"><b>D2D1_EXTEND_MODE extendMode</b></param>
	void SetExtendModeY (ExtendMode extendMode);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_EXTEND_MODE ID2D1BorderTransform::GetExtendModeX ()</b><br/>
	/// </summary>
	ExtendMode GetExtendModeX ();
	/// <summary>
	/// STDMETHOD_ <b>D2D1_EXTEND_MODE ID2D1BorderTransform::GetExtendModeY ()</b><br/>
	/// </summary>
	ExtendMode GetExtendModeY ();
}

/// <summary>
/// Instance of <b>ID2D1BorderTransform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct BorderTransform : IBorderTransform {
//unsafe public readonly struct IBorderTransformObj : IBorderTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BorderTransform* GetCurrentPointer () => (BorderTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBorderTransformObj* GetCurrentPointer () => (IBorderTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x4998735c, 0x3a19, 0x473c, 0x97, 0x81, 0x65, 0x68, 0x47, 0xe3, 0xa3, 0x47);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetExtendModeX (ExtendMode extendMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetExtendModeX (ptr, extendMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetExtendModeY (ExtendMode extendMode) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetExtendModeY (ptr, extendMode);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ExtendMode GetExtendModeX () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExtendModeX (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ExtendMode GetExtendModeY () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetExtendModeY (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetInputCount;
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
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode, void> SetExtendModeX;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode, void> SetExtendModeY;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode> GetExtendModeX;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ExtendMode> GetExtendModeY;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
