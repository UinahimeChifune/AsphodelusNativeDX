using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ResourceTexture</b> : IUnknown<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IResourceTexture : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ResourceTexture::Update (UINT32* minimumExtents, UINT32* maximimumExtents, UINT32* strides, UINT32 dimensions, BYTE* data, UINT32 dataCount)</b><br/>
	/// </summary>
	/// <param name="minimumExtents">_In_reads_opt_(dimensions) <b>UINT32* minimumExtents</b></param>
	/// <param name="maximimumExtents">_In_reads_opt_(dimensions) <b>UINT32* maximimumExtents</b></param>
	/// <param name="strides">_In_reads_opt_(dimensions - 1) <b>UINT32* strides</b></param>
	/// <param name="dimensions"><b>UINT32 dimensions</b></param>
	/// <param name="data">_In_reads_(dataCount) <b>BYTE* data</b></param>
	/// <param name="dataCount"><b>UINT32 dataCount</b></param>
	int Update (uint* minimumExtents, uint* maximimumExtents, uint* strides, uint dimensions, byte* data, uint dataCount);
}

/// <summary>
/// Instance of <b>ID2D1ResourceTexture</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct ResourceTexture : IResourceTexture {
//unsafe public readonly struct IResourceTextureObj : IResourceTexture {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ResourceTexture* GetCurrentPointer () => (ResourceTexture*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IResourceTextureObj* GetCurrentPointer () => (IResourceTextureObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x688d15c3, 0x02b0, 0x438d, 0xb1, 0x3a, 0xd1, 0xb4, 0x4c, 0x32, 0xc3, 0x9a);

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
	public readonly int Update (uint* minimumExtents, uint* maximimumExtents, uint* strides, uint dimensions, byte* data, uint dataCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Update (ptr, minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, uint*, uint*, uint, byte*, uint, int> Update;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
