using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D;

/// <summary>
/// INTERFACE <b>ID3DUserDefinedAnnotation</b> : IUnknown<br/>
/// D3D11_1.h
/// </summary>
unsafe public interface IUserDefinedAnnotation : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>INT ID3DUserDefinedAnnotation::BeginEvent (LPCWSTR Name)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>LPCWSTR Name</b></param>
	int BeginEvent (char* name);
	/// <summary>
	/// STDMETHODCALLTYPE <b>INT ID3DUserDefinedAnnotation::EndEvent ()</b><br/>
	/// </summary>
	int EndEvent ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3DUserDefinedAnnotation::SetMarker (LPCWSTR Name)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>LPCWSTR Name</b></param>
	void SetMarker (char* name);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3DUserDefinedAnnotation::GetStatus ()</b><br/>
	/// </summary>
	bool GetStatus ();
}

/// <summary>
/// Instance of <b>ID3DUserDefinedAnnotation</b><br/>
/// D3D11_1.h
/// </summary>
unsafe public readonly struct UserDefinedAnnotation : IUserDefinedAnnotation {
//unsafe public readonly struct IUserDefinedAnnotationObj : IUserDefinedAnnotation {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly UserDefinedAnnotation* GetCurrentPointer () => (UserDefinedAnnotation*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IUserDefinedAnnotationObj* GetCurrentPointer () => (IUserDefinedAnnotationObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb2daad8b, 0x03d4, 0x4dbf, 0x95, 0xeb, 0x32, 0xab, 0x4b, 0x63, 0xd0, 0xab);

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
	public readonly int BeginEvent (char* name) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->BeginEvent (ptr, name);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EndEvent () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EndEvent (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetMarker (char* name) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetMarker (ptr, name);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetStatus () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStatus (ptr) != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> BeginEvent;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> EndEvent;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void> SetMarker;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetStatus;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
