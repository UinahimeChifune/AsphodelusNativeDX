using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICProgressiveLevelControl</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IProgressiveLevelControl : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICProgressiveLevelControl::GetLevelCount (UINT* pcLevels)</b><br/>
	/// </summary>
	/// <param name="pcLevels">__RPC__out <b>UINT* pcLevels</b></param>
	int GetLevelCount (uint* pcLevels);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICProgressiveLevelControl::GetLevelCount (UINT* pcLevels)</b><br/>
	/// </summary>
	/// <param name="pcLevels">__RPC__out <b>UINT* pcLevels</b></param>
	int GetLevelCount (out uint pcLevels);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICProgressiveLevelControl::GetCurrentLevel (UINT* pnLevel)</b><br/>
	/// </summary>
	/// <param name="pnLevel">__RPC__out <b>UINT* pnLevel</b></param>
	int GetCurrentLevel (uint* pnLevel);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICProgressiveLevelControl::GetCurrentLevel (UINT* pnLevel)</b><br/>
	/// </summary>
	/// <param name="pnLevel">__RPC__out <b>UINT* pnLevel</b></param>
	int GetCurrentLevel (out uint pnLevel);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICProgressiveLevelControl::SetCurrentLevel (UINT nLevel)</b><br/>
	/// </summary>
	/// <param name="nLevel"><b>UINT nLevel</b></param>
	int SetCurrentLevel (uint nLevel);
}

/// <summary>
/// Instance of <b>IWICProgressiveLevelControl</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct ProgressiveLevelControl : IProgressiveLevelControl {
//unsafe public readonly struct IProgressiveLevelControlObj : IProgressiveLevelControl {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ProgressiveLevelControl* GetCurrentPointer () => (ProgressiveLevelControl*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IProgressiveLevelControlObj* GetCurrentPointer () => (IProgressiveLevelControlObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xdaac296f, 0x7aa5, 0x4dbf, 0x8d, 0x15, 0x22, 0x5c, 0x59, 0x76, 0xf8, 0x91);

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
	public readonly int GetLevelCount (uint* pcLevels) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLevelCount (ptr, pcLevels);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLevelCount (out uint pcLevels) {
		fixed (uint* _pcLevels = &pcLevels) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLevelCount (ptr, _pcLevels);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentLevel (uint* pnLevel) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentLevel (ptr, pnLevel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCurrentLevel (out uint pnLevel) {
		fixed (uint* _pnLevel = &pnLevel) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetCurrentLevel (ptr, _pnLevel);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetCurrentLevel (uint nLevel) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetCurrentLevel (ptr, nLevel);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetLevelCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint*, int> GetCurrentLevel;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetCurrentLevel;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
