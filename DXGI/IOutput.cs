using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIOutput</b> : IDXGIObject<br/>
/// DXGI.h
/// </summary>
unsafe public interface IOutput : IObject {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetDesc (DXGI_OUTPUT_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_OUTPUT_DESC* pDesc</b></param>
	int GetDesc (OutputDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetDesc (DXGI_OUTPUT_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="pDesc">_Out_ <b>DXGI_OUTPUT_DESC* pDesc</b></param>
	int GetDesc (out OutputDesc pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetDisplayModeList (DXGI_FORMAT EnumFormat, UINT Flags, UINT* pNumModes, DXGI_MODE_DESC* pDesc)</b><br/>
	/// </summary>
	/// <param name="enumFormat"><b>DXGI_FORMAT EnumFormat</b></param>
	/// <param name="flags"><b>UINT Flags</b></param>
	/// <param name="pNumModes">_Inout_ <b>UINT* pNumModes</b></param>
	/// <param name="pDesc">_Out_writes_to_opt_(*pNumModes,*pNumModes) <b>DXGI_MODE_DESC* pDesc</b></param>
	int GetDisplayModeList (Format enumFormat, uint flags, uint* pNumModes, ModeDesc* pDesc);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::FindClosestMatchingMode (DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice)</b><br/>
	/// </summary>
	/// <param name="pModeToMatch">_In_ <b>DXGI_MODE_DESC* pModeToMatch</b></param>
	/// <param name="pClosestMatch">_Out_ <b>DXGI_MODE_DESC* pClosestMatch</b></param>
	/// <param name="pConcernedDevice">_In_opt_ <b>IUnknown* pConcernedDevice</b></param>
	int FindClosestMatchingMode<T0> (ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, T0* pConcernedDevice) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::FindClosestMatchingMode (DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice)</b><br/>
	/// </summary>
	/// <param name="pModeToMatch">_In_ <b>DXGI_MODE_DESC* pModeToMatch</b></param>
	/// <param name="pClosestMatch">_Out_ <b>DXGI_MODE_DESC* pClosestMatch</b></param>
	/// <param name="pConcernedDevice">_In_opt_ <b>IUnknown* pConcernedDevice</b></param>
	int FindClosestMatchingMode<T0> (ModeDesc* pModeToMatch, out ModeDesc pClosestMatch, T0* pConcernedDevice) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::WaitForVBlank ()</b><br/>
	/// </summary>
	int WaitForVBlank ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::TakeOwnership (IUnknown* pDevice, BOOL Exclusive)</b><br/>
	/// </summary>
	/// <param name="pDevice">_In_ <b>IUnknown* pDevice</b></param>
	/// <param name="exclusive"><b>BOOL Exclusive</b></param>
	int TakeOwnership<T0> (T0* pDevice, bool exclusive) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIOutput::ReleaseOwnership ()</b><br/>
	/// </summary>
	void ReleaseOwnership ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetGammaControlCapabilities (DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)</b><br/>
	/// </summary>
	/// <param name="pGammaCaps">_Out_ <b>DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps</b></param>
	int GetGammaControlCapabilities (GammaControlCapabilities* pGammaCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetGammaControlCapabilities (DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)</b><br/>
	/// </summary>
	/// <param name="pGammaCaps">_Out_ <b>DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps</b></param>
	int GetGammaControlCapabilities (out GammaControlCapabilities pGammaCaps);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::SetGammaControl (DXGI_GAMMA_CONTROL* pArray)</b><br/>
	/// </summary>
	/// <param name="pArray">_In_ <b>DXGI_GAMMA_CONTROL* pArray</b></param>
	int SetGammaControl (GammaControl* pArray);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetGammaControl (DXGI_GAMMA_CONTROL* pArray)</b><br/>
	/// </summary>
	/// <param name="pArray">_Out_ <b>DXGI_GAMMA_CONTROL* pArray</b></param>
	int GetGammaControl (GammaControl* pArray);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetGammaControl (DXGI_GAMMA_CONTROL* pArray)</b><br/>
	/// </summary>
	/// <param name="pArray">_Out_ <b>DXGI_GAMMA_CONTROL* pArray</b></param>
	int GetGammaControl (out GammaControl pArray);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::SetDisplaySurface (IDXGISurface* pScanoutSurface)</b><br/>
	/// </summary>
	/// <param name="pScanoutSurface">_In_ <b>IDXGISurface* pScanoutSurface</b></param>
	int SetDisplaySurface<T0> (T0* pScanoutSurface) where T0 : unmanaged, ISurface;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetDisplaySurfaceData (IDXGISurface* pDestination)</b><br/>
	/// </summary>
	/// <param name="pDestination">_In_ <b>IDXGISurface* pDestination</b></param>
	int GetDisplaySurfaceData<T0> (T0* pDestination) where T0 : unmanaged, ISurface;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetFrameStatistics (DXGI_FRAME_STATISTICS* pStats)</b><br/>
	/// </summary>
	/// <param name="pStats">_Out_ <b>DXGI_FRAME_STATISTICS* pStats</b></param>
	int GetFrameStatistics (FrameStatistics* pStats);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIOutput::GetFrameStatistics (DXGI_FRAME_STATISTICS* pStats)</b><br/>
	/// </summary>
	/// <param name="pStats">_Out_ <b>DXGI_FRAME_STATISTICS* pStats</b></param>
	int GetFrameStatistics (out FrameStatistics pStats);
}

/// <summary>
/// Instance of <b>IDXGIOutput</b><br/>
/// DXGI.h
/// </summary>
unsafe public readonly struct Output : IOutput {
//unsafe public readonly struct IOutputObj : IOutput {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Output* GetCurrentPointer () => (Output*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IOutputObj* GetCurrentPointer () => (IOutputObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xae02eedb, 0xc735, 0x4690, 0x8d, 0x52, 0x5a, 0x8d, 0xc2, 0x02, 0x13, 0xaa);

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
	public readonly int SetPrivateData (Guid name, uint dataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateData (ptr, name, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateDataInterface<T0> (Guid name, T0* pUnknown) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateDataInterface (ptr, name, pUnknown);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPrivateData (Guid name, uint* pDataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrivateData (ptr, name, pDataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParent (Guid riid, void** ppParent) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetParent (ptr, riid, ppParent);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetParent (Guid riid, out void* ppParent) {
		fixed (void** _ppParent = &ppParent) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetParent (ptr, riid, _ppParent);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc (OutputDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDesc (out OutputDesc pDesc) {
		fixed (OutputDesc* _pDesc = &pDesc) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDesc (ptr, _pDesc);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDisplayModeList (Format enumFormat, uint flags, uint* pNumModes, ModeDesc* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDisplayModeList (ptr, enumFormat, flags, pNumModes, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindClosestMatchingMode<T0> (ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, T0* pConcernedDevice) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindClosestMatchingMode (ptr, pModeToMatch, pClosestMatch, pConcernedDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindClosestMatchingMode<T0> (ModeDesc* pModeToMatch, out ModeDesc pClosestMatch, T0* pConcernedDevice) where T0 : unmanaged, IUnknown {
		fixed (ModeDesc* _pClosestMatch = &pClosestMatch) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindClosestMatchingMode (ptr, pModeToMatch, _pClosestMatch, pConcernedDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int WaitForVBlank () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->WaitForVBlank (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int TakeOwnership<T0> (T0* pDevice, bool exclusive) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->TakeOwnership (ptr, pDevice, exclusive ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ReleaseOwnership () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ReleaseOwnership (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGammaControlCapabilities (GammaControlCapabilities* pGammaCaps) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGammaControlCapabilities (ptr, pGammaCaps);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGammaControlCapabilities (out GammaControlCapabilities pGammaCaps) {
		fixed (GammaControlCapabilities* _pGammaCaps = &pGammaCaps) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGammaControlCapabilities (ptr, _pGammaCaps);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetGammaControl (GammaControl* pArray) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetGammaControl (ptr, pArray);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGammaControl (GammaControl* pArray) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetGammaControl (ptr, pArray);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetGammaControl (out GammaControl pArray) {
		fixed (GammaControl* _pArray = &pArray) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetGammaControl (ptr, _pArray);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetDisplaySurface<T0> (T0* pScanoutSurface) where T0 : unmanaged, ISurface {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetDisplaySurface (ptr, pScanoutSurface);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDisplaySurfaceData<T0> (T0* pDestination) where T0 : unmanaged, ISurface {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDisplaySurfaceData (ptr, pDestination);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameStatistics (FrameStatistics* pStats) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameStatistics (ptr, pStats);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFrameStatistics (out FrameStatistics pStats) {
		fixed (FrameStatistics* _pStats = &pStats) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFrameStatistics (ptr, _pStats);
			return hr;
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetParent;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, OutputDesc*, int> GetDesc;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Format, uint, uint*, ModeDesc*, int> GetDisplayModeList;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ModeDesc*, ModeDesc*, void*, int> FindClosestMatchingMode;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> WaitForVBlank;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, int> TakeOwnership;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> ReleaseOwnership;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GammaControlCapabilities*, int> GetGammaControlCapabilities;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GammaControl*, int> SetGammaControl;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, GammaControl*, int> GetGammaControl;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetDisplaySurface;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> GetDisplaySurfaceData;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FrameStatistics*, int> GetFrameStatistics;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
