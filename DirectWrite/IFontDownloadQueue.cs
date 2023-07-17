using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontDownloadQueue</b> : IUnknown<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontDownloadQueue : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontDownloadQueue::AddListener (IDWriteFontDownloadListener* listener, UINT32* token)</b><br/>
	/// </summary>
	/// <param name="listener"><b>IDWriteFontDownloadListener* listener</b></param>
	/// <param name="token">_Out_ <b>UINT32* token</b></param>
	int AddListener<T0> (T0* listener, uint* token) where T0 : unmanaged, IFontDownloadListener;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontDownloadQueue::AddListener (IDWriteFontDownloadListener* listener, UINT32* token)</b><br/>
	/// </summary>
	/// <param name="listener"><b>IDWriteFontDownloadListener* listener</b></param>
	/// <param name="token">_Out_ <b>UINT32* token</b></param>
	int AddListener<T0> (T0* listener, out uint token) where T0 : unmanaged, IFontDownloadListener;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontDownloadQueue::RemoveListener (UINT32 token)</b><br/>
	/// </summary>
	/// <param name="token"><b>UINT32 token</b></param>
	int RemoveListener (uint token);
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFontDownloadQueue::IsEmpty ()</b><br/>
	/// </summary>
	bool IsEmpty ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontDownloadQueue::BeginDownload (IUnknown* nullptr)</b><br/>
	/// </summary>
	/// <param name="nullptr">_In_opt_ <b>IUnknown* nullptr</b></param>
	int BeginDownload<T0> (T0* nullptr) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontDownloadQueue::CancelDownload ()</b><br/>
	/// </summary>
	int CancelDownload ();
	/// <summary>
	/// STDMETHOD_ <b>UINT64 IDWriteFontDownloadQueue::GetGenerationCount ()</b><br/>
	/// </summary>
	ulong GetGenerationCount ();
}

/// <summary>
/// Instance of <b>IDWriteFontDownloadQueue</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontDownloadQueue : IFontDownloadQueue {
//unsafe public readonly struct IFontDownloadQueueObj : IFontDownloadQueue {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontDownloadQueue* GetCurrentPointer () => (FontDownloadQueue*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontDownloadQueueObj* GetCurrentPointer () => (IFontDownloadQueueObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb71e6052, 0x5aea, 0x4fa3, 0x83, 0x2e, 0xf6, 0x0d, 0x43, 0x1f, 0x7e, 0x91);

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
	public readonly int AddListener<T0> (T0* listener, uint* token) where T0 : unmanaged, IFontDownloadListener {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddListener (ptr, listener, token);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddListener<T0> (T0* listener, out uint token) where T0 : unmanaged, IFontDownloadListener {
		fixed (uint* _token = &token) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->AddListener (ptr, listener, _token);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveListener (uint token) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveListener (ptr, token);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsEmpty () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsEmpty (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int BeginDownload<T0> (T0* nullptr) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->BeginDownload (ptr, nullptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CancelDownload () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CancelDownload (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetGenerationCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGenerationCount (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint*, int> AddListener;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemoveListener;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsEmpty;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> BeginDownload;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> CancelDownload;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetGenerationCount;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
