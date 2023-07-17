using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1EffectImpl</b> : IUnknown<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IEffectImpl : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectImpl::Initialize (ID2D1EffectContext* effectContext, ID2D1TransformGraph* transformGraph)</b><br/>
	/// </summary>
	/// <param name="effectContext">_In_ <b>ID2D1EffectContext* effectContext</b></param>
	/// <param name="transformGraph">_In_ <b>ID2D1TransformGraph* transformGraph</b></param>
	int Initialize<T0, T1> (T0* effectContext, T1* transformGraph) where T0 : unmanaged, IEffectContext where T1 : unmanaged, ITransformGraph;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectImpl::PrepareForRender (D2D1_CHANGE_TYPE changeType)</b><br/>
	/// </summary>
	/// <param name="changeType"><b>D2D1_CHANGE_TYPE changeType</b></param>
	int PrepareForRender (ChangeType changeType);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1EffectImpl::SetGraph (ID2D1TransformGraph* transformGraph)</b><br/>
	/// </summary>
	/// <param name="transformGraph">_In_ <b>ID2D1TransformGraph* transformGraph</b></param>
	int SetGraph<T0> (T0* transformGraph) where T0 : unmanaged, ITransformGraph;
}

/// <summary>
/// Instance of <b>ID2D1EffectImpl</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct EffectImpl : IEffectImpl {
//unsafe public readonly struct IEffectImplObj : IEffectImpl {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly EffectImpl* GetCurrentPointer () => (EffectImpl*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IEffectImplObj* GetCurrentPointer () => (IEffectImplObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xa248fd3f, 0x3e6c, 0x4e63, 0x9f, 0x03, 0x7f, 0x68, 0xec, 0xc9, 0x1d, 0xb9);

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
	public readonly int Initialize<T0, T1> (T0* effectContext, T1* transformGraph) where T0 : unmanaged, IEffectContext where T1 : unmanaged, ITransformGraph {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Initialize (ptr, effectContext, transformGraph);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PrepareForRender (ChangeType changeType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PrepareForRender (ptr, changeType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetGraph<T0> (T0* transformGraph) where T0 : unmanaged, ITransformGraph {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetGraph (ptr, transformGraph);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> Initialize;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ChangeType, int> PrepareForRender;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetGraph;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
