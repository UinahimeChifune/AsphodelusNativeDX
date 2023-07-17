using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1GdiMetafileSink1</b> : ID2D1GdiMetafileSink<br/>
/// D2D1_3.h
/// </summary>
unsafe public interface IGdiMetafileSink1 : IGdiMetafileSink {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiMetafileSink1::ProcessRecord (DWORD recordType, void* recordData, DWORD recordDataSize, UINT32 flags)</b><br/>
	/// </summary>
	/// <param name="recordType"><b>DWORD recordType</b></param>
	/// <param name="recordData">_In_opt_ <b>void* recordData</b></param>
	/// <param name="recordDataSize"><b>DWORD recordDataSize</b></param>
	/// <param name="flags"><b>UINT32 flags</b></param>
	int ProcessRecord (uint recordType, void* recordData, uint recordDataSize, uint flags);
}

/// <summary>
/// Instance of <b>ID2D1GdiMetafileSink1</b><br/>
/// D2D1_3.h
/// </summary>
unsafe public readonly struct GdiMetafileSink1 : IGdiMetafileSink1 {
//unsafe public readonly struct IGdiMetafileSink1Obj : IGdiMetafileSink1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GdiMetafileSink1* GetCurrentPointer () => (GdiMetafileSink1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGdiMetafileSink1Obj* GetCurrentPointer () => (IGdiMetafileSink1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xfd0ecb6b, 0x91e6, 0x411e, 0x86, 0x55, 0x39, 0x5e, 0x76, 0x0f, 0x91, 0xb4);

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
	public readonly int ProcessRecord (uint recordType, void* recordData, uint recordDataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ProcessRecord (ptr, recordType, recordData, recordDataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ProcessRecord (uint recordType, void* recordData, uint recordDataSize, uint flags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_ProcessRecord (ptr, recordType, recordData, recordDataSize, flags);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, int> ProcessRecord;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, uint, int> _ProcessRecord;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
