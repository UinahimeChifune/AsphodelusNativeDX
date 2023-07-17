using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1TransformGraph</b> : IUnknown<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface ITransformGraph : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1TransformGraph::GetInputCount ()</b><br/>
	/// </summary>
	uint GetInputCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TransformGraph::SetSingleTransformNode (ID2D1TransformNode* node)</b><br/>
	/// </summary>
	/// <param name="node">_In_ <b>ID2D1TransformNode* node</b></param>
	int SetSingleTransformNode<T0> (T0* node) where T0 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TransformGraph::AddNode (ID2D1TransformNode* node)</b><br/>
	/// </summary>
	/// <param name="node">_In_ <b>ID2D1TransformNode* node</b></param>
	int AddNode<T0> (T0* node) where T0 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TransformGraph::RemoveNode (ID2D1TransformNode* node)</b><br/>
	/// </summary>
	/// <param name="node">_In_ <b>ID2D1TransformNode* node</b></param>
	int RemoveNode<T0> (T0* node) where T0 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TransformGraph::SetOutputNode (ID2D1TransformNode* node)</b><br/>
	/// </summary>
	/// <param name="node">_In_ <b>ID2D1TransformNode* node</b></param>
	int SetOutputNode<T0> (T0* node) where T0 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TransformGraph::ConnectNode (ID2D1TransformNode* fromNode, ID2D1TransformNode* toNode, UINT32 toNodeInputIndex)</b><br/>
	/// </summary>
	/// <param name="fromNode">_In_ <b>ID2D1TransformNode* fromNode</b></param>
	/// <param name="toNode">_In_ <b>ID2D1TransformNode* toNode</b></param>
	/// <param name="toNodeInputIndex"><b>UINT32 toNodeInputIndex</b></param>
	int ConnectNode<T0, T1> (T0* fromNode, T1* toNode, uint toNodeInputIndex) where T0 : unmanaged, ITransformNode where T1 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TransformGraph::ConnectToEffectInput (UINT32 toEffectInputIndex, ID2D1TransformNode* node, UINT32 toNodeInputIndex)</b><br/>
	/// </summary>
	/// <param name="toEffectInputIndex"><b>UINT32 toEffectInputIndex</b></param>
	/// <param name="node">_In_ <b>ID2D1TransformNode* node</b></param>
	/// <param name="toNodeInputIndex"><b>UINT32 toNodeInputIndex</b></param>
	int ConnectToEffectInput<T0> (uint toEffectInputIndex, T0* node, uint toNodeInputIndex) where T0 : unmanaged, ITransformNode;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1TransformGraph::Clear ()</b><br/>
	/// </summary>
	void Clear ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1TransformGraph::SetPassthroughGraph (UINT32 effectInputIndex)</b><br/>
	/// </summary>
	/// <param name="effectInputIndex"><b>UINT32 effectInputIndex</b></param>
	int SetPassthroughGraph (uint effectInputIndex);
}

/// <summary>
/// Instance of <b>ID2D1TransformGraph</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct TransformGraph : ITransformGraph {
//unsafe public readonly struct ITransformGraphObj : ITransformGraph {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly TransformGraph* GetCurrentPointer () => (TransformGraph*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ITransformGraphObj* GetCurrentPointer () => (ITransformGraphObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x13d29038, 0xc3e6, 0x4034, 0x90, 0x81, 0x13, 0xb5, 0x3a, 0x41, 0x79, 0x92);

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
	public readonly uint GetInputCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetInputCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSingleTransformNode<T0> (T0* node) where T0 : unmanaged, ITransformNode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSingleTransformNode (ptr, node);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddNode<T0> (T0* node) where T0 : unmanaged, ITransformNode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddNode (ptr, node);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveNode<T0> (T0* node) where T0 : unmanaged, ITransformNode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveNode (ptr, node);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetOutputNode<T0> (T0* node) where T0 : unmanaged, ITransformNode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetOutputNode (ptr, node);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConnectNode<T0, T1> (T0* fromNode, T1* toNode, uint toNodeInputIndex) where T0 : unmanaged, ITransformNode where T1 : unmanaged, ITransformNode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ConnectNode (ptr, fromNode, toNode, toNodeInputIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ConnectToEffectInput<T0> (uint toEffectInputIndex, T0* node, uint toNodeInputIndex) where T0 : unmanaged, ITransformNode {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ConnectToEffectInput (ptr, toEffectInputIndex, node, toNodeInputIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void Clear () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->Clear (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPassthroughGraph (uint effectInputIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPassthroughGraph (ptr, effectInputIndex);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetInputCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetSingleTransformNode;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AddNode;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> RemoveNode;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetOutputNode;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, uint, int> ConnectNode;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, int> ConnectToEffectInput;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> Clear;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetPassthroughGraph;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
