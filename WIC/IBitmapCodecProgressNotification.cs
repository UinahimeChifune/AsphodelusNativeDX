using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICBitmapCodecProgressNotification</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IBitmapCodecProgressNotification : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICBitmapCodecProgressNotification::RegisterProgressNotification (PFNProgressNotification pfnProgressNotification, LPVOID pvData, DWORD dwProgressFlags)</b><br/>
	/// </summary>
	/// <param name="pfnProgressNotification">_In_opt_ <b>PFNProgressNotification pfnProgressNotification</b></param>
	/// <param name="pvData">_In_opt_ <b>LPVOID pvData</b></param>
	/// <param name="dwProgressFlags"><b>DWORD dwProgressFlags</b></param>
	int RegisterProgressNotification (ProgressNotificationDelegate pfnProgressNotification, void* pvData, uint dwProgressFlags);
}

/// <summary>
/// Instance of <b>IWICBitmapCodecProgressNotification</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct BitmapCodecProgressNotification : IBitmapCodecProgressNotification {
//unsafe public readonly struct IBitmapCodecProgressNotificationObj : IBitmapCodecProgressNotification {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly BitmapCodecProgressNotification* GetCurrentPointer () => (BitmapCodecProgressNotification*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IBitmapCodecProgressNotificationObj* GetCurrentPointer () => (IBitmapCodecProgressNotificationObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x64c1024e, 0xc3cf, 0x4462, 0x80, 0x78, 0x88, 0xc2, 0xb1, 0x1c, 0x46, 0xd9);

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
	public readonly int RegisterProgressNotification (ProgressNotificationDelegate pfnProgressNotification, void* pvData, uint dwProgressFlags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RegisterProgressNotification (ptr, (void*) Marshal.GetFunctionPointerForDelegate (pfnProgressNotification), pvData, dwProgressFlags);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, int> RegisterProgressNotification;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
