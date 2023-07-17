using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1BlendTransform</b> : ID2D1ConcreteTransform<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IBlendTransform : IConcreteTransform {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BlendTransform::SetDescription (D2D1_BLEND_DESCRIPTION* description)</b><br/>
	/// </summary>
	/// <param name="description">_In_ <b>D2D1_BLEND_DESCRIPTION* description</b></param>
	void SetDescription (BlendDescription* description);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BlendTransform::GetDescription (D2D1_BLEND_DESCRIPTION* description)</b><br/>
	/// </summary>
	/// <param name="description">_Out_ <b>D2D1_BLEND_DESCRIPTION* description</b></param>
	void GetDescription (BlendDescription* description);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1BlendTransform::GetDescription (D2D1_BLEND_DESCRIPTION* description)</b><br/>
	/// </summary>
	/// <param name="description">_Out_ <b>D2D1_BLEND_DESCRIPTION* description</b></param>
	void GetDescription (out BlendDescription description);
}

/// <summary>
/// Instance of <b>ID2D1BlendTransform</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct BlendTransform : IBlendTransform {
//unsafe public readonly struct IBlendTransformObj : IBlendTransform {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BlendTransform* GetCurrentPointer () => (BlendTransform*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBlendTransformObj* GetCurrentPointer () => (IBlendTransformObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x63ac0b32, 0xba44, 0x450f, 0x88, 0x06, 0x7f, 0x4c, 0xa1, 0xff, 0x2f, 0x1b);

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
	public readonly void SetDescription (BlendDescription* description) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetDescription (ptr, description);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDescription (BlendDescription* description) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDescription (ptr, description);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDescription (out BlendDescription description) {
		fixed (BlendDescription* _description = &description) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDescription (ptr, _description);
			return;
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
		public readonly delegate* unmanaged[Stdcall]<void*, BlendDescription*, void> SetDescription;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BlendDescription*, void> GetDescription;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
