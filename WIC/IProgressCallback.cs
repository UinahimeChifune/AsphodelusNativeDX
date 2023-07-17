using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICProgressCallback</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IProgressCallback : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICProgressCallback::Notify (ULONG uFrameNum, WICProgressOperation operation, double dblProgress)</b><br/>
	/// </summary>
	/// <param name="uFrameNum"><b>ULONG uFrameNum</b></param>
	/// <param name="operation"><b>WICProgressOperation operation</b></param>
	/// <param name="dblProgress"><b>double dblProgress</b></param>
	int Notify (uint uFrameNum, ProgressOperation operation, double dblProgress);
}

/// <summary>
/// Instance of <b>IWICProgressCallback</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct ProgressCallback : IProgressCallback {
//unsafe public readonly struct IProgressCallbackObj : IProgressCallback {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ProgressCallback* GetCurrentPointer () => (ProgressCallback*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IProgressCallbackObj* GetCurrentPointer () => (IProgressCallbackObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x4776f9cd, 0x9517, 0x45fa, 0xbf, 0x24, 0xe8, 0x9c, 0x5e, 0xc5, 0xc6, 0x0c);

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
	public readonly int Notify (uint uFrameNum, ProgressOperation operation, double dblProgress) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Notify (ptr, uFrameNum, operation, dblProgress);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, ProgressOperation, double, int> Notify;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
