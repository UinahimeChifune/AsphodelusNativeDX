using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontDownloadListener</b> : IUnknown<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontDownloadListener : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>void IDWriteFontDownloadListener::DownloadCompleted (IDWriteFontDownloadQueue* downloadQueue, IUnknown* context, HRESULT downloadResult)</b><br/>
	/// </summary>
	/// <param name="downloadQueue">_In_ <b>IDWriteFontDownloadQueue* downloadQueue</b></param>
	/// <param name="context">_In_opt_ <b>IUnknown* context</b></param>
	/// <param name="downloadResult"><b>HRESULT downloadResult</b></param>
	void DownloadCompleted<T0, T1> (T0* downloadQueue, T1* context, int downloadResult) where T0 : unmanaged, IFontDownloadQueue where T1 : unmanaged, IUnknown;
}

/// <summary>
/// Instance of <b>IDWriteFontDownloadListener</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontDownloadListener : IFontDownloadListener {
//unsafe public readonly struct IFontDownloadListenerObj : IFontDownloadListener {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontDownloadListener* GetCurrentPointer () => (FontDownloadListener*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontDownloadListenerObj* GetCurrentPointer () => (IFontDownloadListenerObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb06fe5b9, 0x43ec, 0x4393, 0x88, 0x1b, 0xdb, 0xe4, 0xdc, 0x72, 0xfd, 0xa7);

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
	public readonly void DownloadCompleted<T0, T1> (T0* downloadQueue, T1* context, int downloadResult) where T0 : unmanaged, IFontDownloadQueue where T1 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->DownloadCompleted (ptr, downloadQueue, context, downloadResult);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int, void> DownloadCompleted;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
