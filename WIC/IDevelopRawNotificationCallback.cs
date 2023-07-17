using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICDevelopRawNotificationCallback</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IDevelopRawNotificationCallback : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICDevelopRawNotificationCallback::Notify (UINT NotificationMask)</b><br/>
	/// </summary>
	/// <param name="notificationMask"><b>UINT NotificationMask</b></param>
	int Notify (uint notificationMask);
}

/// <summary>
/// Instance of <b>IWICDevelopRawNotificationCallback</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct DevelopRawNotificationCallback : IDevelopRawNotificationCallback {
//unsafe public readonly struct IDevelopRawNotificationCallbackObj : IDevelopRawNotificationCallback {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DevelopRawNotificationCallback* GetCurrentPointer () => (DevelopRawNotificationCallback*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDevelopRawNotificationCallbackObj* GetCurrentPointer () => (IDevelopRawNotificationCallbackObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x95c75a6e, 0x3e8c, 0x4ec2, 0x85, 0xa8, 0xae, 0xbc, 0xc5, 0x51, 0xe5, 0x9b);

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
	public readonly int Notify (uint notificationMask) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Notify (ptr, notificationMask);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> Notify;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
