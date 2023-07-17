using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIOutput2</b> : IDXGIOutput1<br/>
/// DXGI1_3.h
/// </summary>
unsafe public interface IOutput2 : IOutput1 {
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL IDXGIOutput2::SupportsOverlays ()</b><br/>
	/// </summary>
	bool SupportsOverlays ();
}

/// <summary>
/// Instance of <b>IDXGIOutput2</b><br/>
/// DXGI1_3.h
/// </summary>
unsafe public readonly struct Output2 : IOutput2 {
//unsafe public readonly struct IOutput2Obj : IOutput2 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Output2* GetCurrentPointer () => (Output2*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IOutput2Obj* GetCurrentPointer () => (IOutput2Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x595e39d1, 0x2724, 0x4663, 0x99, 0xb1, 0xda, 0x96, 0x9d, 0xe2, 0x83, 0x64);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDisplayModeList1 (Format enumFormat, uint flags, uint* pNumModes, ModeDesc1* pDesc) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDisplayModeList1 (ptr, enumFormat, flags, pNumModes, pDesc);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindClosestMatchingMode1<T0> (ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, T0* pConcernedDevice) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindClosestMatchingMode1 (ptr, pModeToMatch, pClosestMatch, pConcernedDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindClosestMatchingMode1<T0> (ModeDesc1* pModeToMatch, out ModeDesc1 pClosestMatch, T0* pConcernedDevice) where T0 : unmanaged, IUnknown {
		fixed (ModeDesc1* _pClosestMatch = &pClosestMatch) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindClosestMatchingMode1 (ptr, pModeToMatch, _pClosestMatch, pConcernedDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDisplaySurfaceData1<T0> (T0* pDestination) where T0 : unmanaged, IResource {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDisplaySurfaceData1 (ptr, pDestination);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DuplicateOutput<T0, T1> (T0* pDevice, T1** ppOutputDuplication) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutputDuplication {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->DuplicateOutput (ptr, pDevice, (void**) ppOutputDuplication);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int DuplicateOutput<T0, T1> (T0* pDevice, out T1* ppOutputDuplication) where T0 : unmanaged, IUnknown where T1 : unmanaged, IOutputDuplication {
		fixed (T1** _ppOutputDuplication = &ppOutputDuplication) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->DuplicateOutput (ptr, pDevice, (void**) _ppOutputDuplication);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool SupportsOverlays () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SupportsOverlays (ptr) != 0;
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
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Format, uint, uint*, ModeDesc1*, int> GetDisplayModeList1;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ModeDesc1*, ModeDesc1*, void*, int> FindClosestMatchingMode1;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> GetDisplaySurfaceData1;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> DuplicateOutput;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> SupportsOverlays;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
