using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGISwapChainMedia</b> : IUnknown<br/>
/// DXGI1_3.h
/// </summary>
unsafe public interface ISwapChainMedia : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChainMedia::GetFrameStatisticsMedia (DXGI_FRAME_STATISTICS_MEDIA* pStats)</b><br/>
	/// </summary>
	/// <param name="pStats">_Out_ <b>DXGI_FRAME_STATISTICS_MEDIA* pStats</b></param>
	int GetFrameStatisticsMedia (FrameStatisticsMedia* pStats);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChainMedia::GetFrameStatisticsMedia (DXGI_FRAME_STATISTICS_MEDIA* pStats)</b><br/>
	/// </summary>
	/// <param name="pStats">_Out_ <b>DXGI_FRAME_STATISTICS_MEDIA* pStats</b></param>
	int GetFrameStatisticsMedia (out FrameStatisticsMedia pStats);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChainMedia::SetPresentDuration (UINT Duration)</b><br/>
	/// </summary>
	/// <param name="duration"><b>UINT Duration</b></param>
	int SetPresentDuration (uint duration);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChainMedia::CheckPresentDurationSupport (UINT DesiredPresentDuration, UINT* pClosestSmallerPresentDuration, UINT* pClosestLargerPresentDuration)</b><br/>
	/// </summary>
	/// <param name="desiredPresentDuration"><b>UINT DesiredPresentDuration</b></param>
	/// <param name="pClosestSmallerPresentDuration">_Out_ <b>UINT* pClosestSmallerPresentDuration</b></param>
	/// <param name="pClosestLargerPresentDuration">_Out_ <b>UINT* pClosestLargerPresentDuration</b></param>
	int CheckPresentDurationSupport (uint desiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGISwapChainMedia::CheckPresentDurationSupport (UINT DesiredPresentDuration, UINT* pClosestSmallerPresentDuration, UINT* pClosestLargerPresentDuration)</b><br/>
	/// </summary>
	/// <param name="desiredPresentDuration"><b>UINT DesiredPresentDuration</b></param>
	/// <param name="pClosestSmallerPresentDuration">_Out_ <b>UINT* pClosestSmallerPresentDuration</b></param>
	/// <param name="pClosestLargerPresentDuration">_Out_ <b>UINT* pClosestLargerPresentDuration</b></param>
	int CheckPresentDurationSupport (uint desiredPresentDuration, out uint pClosestSmallerPresentDuration, out uint pClosestLargerPresentDuration);
}

/// <summary>
/// Instance of <b>IDXGISwapChainMedia</b><br/>
/// DXGI1_3.h
/// </summary>
unsafe public readonly struct SwapChainMedia : ISwapChainMedia {
//unsafe public readonly struct ISwapChainMediaObj : ISwapChainMedia {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SwapChainMedia* GetCurrentPointer () => (SwapChainMedia*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISwapChainMediaObj* GetCurrentPointer () => (ISwapChainMediaObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xdd95b90b, 0xf05f, 0x4f6a, 0xbd, 0x65, 0x25, 0xbf, 0xb2, 0x64, 0xbd, 0x84);

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
	public readonly int GetFrameStatisticsMedia (FrameStatisticsMedia* pStats) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameStatisticsMedia (ptr, pStats);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameStatisticsMedia (out FrameStatisticsMedia pStats) {
		fixed (FrameStatisticsMedia* _pStats = &pStats) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameStatisticsMedia (ptr, _pStats);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPresentDuration (uint duration) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPresentDuration (ptr, duration);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckPresentDurationSupport (uint desiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CheckPresentDurationSupport (ptr, desiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CheckPresentDurationSupport (uint desiredPresentDuration, out uint pClosestSmallerPresentDuration, out uint pClosestLargerPresentDuration) {
		fixed (uint* _pClosestSmallerPresentDuration = &pClosestSmallerPresentDuration) {
			fixed (uint* _pClosestLargerPresentDuration = &pClosestLargerPresentDuration) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->CheckPresentDurationSupport (ptr, desiredPresentDuration, _pClosestSmallerPresentDuration, _pClosestLargerPresentDuration);
				return hr;
			}
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
		public readonly delegate* unmanaged[Stdcall]<void*, FrameStatisticsMedia*, int> GetFrameStatisticsMedia;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetPresentDuration;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, uint*, int> CheckPresentDurationSupport;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
