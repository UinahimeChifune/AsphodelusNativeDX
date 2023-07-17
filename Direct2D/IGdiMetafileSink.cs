using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1GdiMetafileSink</b> : IUnknown<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IGdiMetafileSink : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1GdiMetafileSink::ProcessRecord (DWORD recordType, void* recordData, DWORD recordDataSize)</b><br/>
	/// </summary>
	/// <param name="recordType"><b>DWORD recordType</b></param>
	/// <param name="recordData">_In_opt_ <b>void* recordData</b></param>
	/// <param name="recordDataSize"><b>DWORD recordDataSize</b></param>
	int ProcessRecord (uint recordType, void* recordData, uint recordDataSize);
}

/// <summary>
/// Instance of <b>ID2D1GdiMetafileSink</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct GdiMetafileSink : IGdiMetafileSink {
//unsafe public readonly struct IGdiMetafileSinkObj : IGdiMetafileSink {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly GdiMetafileSink* GetCurrentPointer () => (GdiMetafileSink*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IGdiMetafileSinkObj* GetCurrentPointer () => (IGdiMetafileSinkObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x82237326, 0x8111, 0x4f7c, 0xbc, 0xf4, 0xb5, 0xc1, 0x17, 0x55, 0x64, 0xfe);

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
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
