using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1PrintControl</b> : IUnknown<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IPrintControl : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1PrintControl::AddPage (ID2D1CommandList* commandList, D2D_SIZE_F pageSize, IStream* pagePrintTicketStream, D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="commandList">_In_ <b>ID2D1CommandList* commandList</b></param>
	/// <param name="pageSize"><b>D2D_SIZE_F pageSize</b></param>
	/// <param name="pagePrintTicketStream">_In_opt_ <b>IStream* pagePrintTicketStream</b></param>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	int AddPage<T0, T1> (T0* commandList, Vector2F pageSize, T1* pagePrintTicketStream, ulong* tag1, ulong* tag2) where T0 : unmanaged, ICommandList where T1 : unmanaged, IStream;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1PrintControl::AddPage (ID2D1CommandList* commandList, D2D_SIZE_F pageSize, IStream* pagePrintTicketStream, D2D1_TAG* tag1, D2D1_TAG* tag2)</b><br/>
	/// </summary>
	/// <param name="commandList">_In_ <b>ID2D1CommandList* commandList</b></param>
	/// <param name="pageSize"><b>D2D_SIZE_F pageSize</b></param>
	/// <param name="pagePrintTicketStream">_In_opt_ <b>IStream* pagePrintTicketStream</b></param>
	/// <param name="tag1">_Out_opt_ <b>D2D1_TAG* tag1</b></param>
	/// <param name="tag2">_Out_opt_ <b>D2D1_TAG* tag2</b></param>
	int AddPage<T0, T1> (T0* commandList, Vector2F pageSize, T1* pagePrintTicketStream, out ulong tag1, out ulong tag2) where T0 : unmanaged, ICommandList where T1 : unmanaged, IStream;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1PrintControl::Close ()</b><br/>
	/// </summary>
	int Close ();
}

/// <summary>
/// Instance of <b>ID2D1PrintControl</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct PrintControl : IPrintControl {
//unsafe public readonly struct IPrintControlObj : IPrintControl {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PrintControl* GetCurrentPointer () => (PrintControl*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPrintControlObj* GetCurrentPointer () => (IPrintControlObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x2c1d867d, 0xc290, 0x41c8, 0xae, 0x7e, 0x34, 0xa9, 0x87, 0x02, 0xe9, 0xa5);

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
	public readonly int AddPage<T0, T1> (T0* commandList, Vector2F pageSize, T1* pagePrintTicketStream, ulong* tag1, ulong* tag2) where T0 : unmanaged, ICommandList where T1 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddPage (ptr, commandList, pageSize, pagePrintTicketStream, tag1, tag2);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddPage<T0, T1> (T0* commandList, Vector2F pageSize, T1* pagePrintTicketStream, out ulong tag1, out ulong tag2) where T0 : unmanaged, ICommandList where T1 : unmanaged, IStream {
		fixed (ulong* _tag1 = &tag1) {
			fixed (ulong* _tag2 = &tag2) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->AddPage (ptr, commandList, pageSize, pagePrintTicketStream, _tag1, _tag2);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Close () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Close (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, Vector2F, void*, ulong*, ulong*, int> AddPage;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Close;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
