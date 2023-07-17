using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgPointCollection</b> : ID2D1SvgAttribute<br/>
/// D2D1SVG.h
/// </summary>
unsafe public interface ISvgPointCollection : ISvgAttribute {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPointCollection::RemovePointsAtEnd (UINT32 pointsCount)</b><br/>
	/// </summary>
	/// <param name="pointsCount"><b>UINT32 pointsCount</b></param>
	int RemovePointsAtEnd (uint pointsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPointCollection::UpdatePoints (D2D1_POINT_2F* points, UINT32 pointsCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="points">_In_reads_(pointsCount) <b>D2D1_POINT_2F* points</b></param>
	/// <param name="pointsCount"><b>UINT32 pointsCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int UpdatePoints (Vector2F* points, uint pointsCount, uint startIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPointCollection::GetPoints (D2D1_POINT_2F* points, UINT32 pointsCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="points">_Out_writes_(pointsCount) <b>D2D1_POINT_2F* points</b></param>
	/// <param name="pointsCount"><b>UINT32 pointsCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int GetPoints (Vector2F* points, uint pointsCount, uint startIndex);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgPointCollection::GetPointsCount ()</b><br/>
	/// </summary>
	uint GetPointsCount ();
}

/// <summary>
/// Instance of <b>ID2D1SvgPointCollection</b><br/>
/// D2D1SVG.h
/// </summary>
unsafe public readonly struct SvgPointCollection : ISvgPointCollection {
//unsafe public readonly struct ISvgPointCollectionObj : ISvgPointCollection {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgPointCollection* GetCurrentPointer () => (SvgPointCollection*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgPointCollectionObj* GetCurrentPointer () => (ISvgPointCollectionObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x9dbe4c0d, 0x3572, 0x4dd9, 0x98, 0x25, 0x55, 0x30, 0x81, 0x3b, 0xb7, 0x12);

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
	public readonly void GetFactory<T0> (T0** factory) where T0 : unmanaged, IFactory {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) factory);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFactory<T0> (out T0* factory) where T0 : unmanaged, IFactory {
		fixed (T0** _factory = &factory) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetFactory (ptr, (void**) _factory);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetElement<T0> (T0** element) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetElement (ptr, (void**) element);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetElement<T0> (out T0* element) where T0 : unmanaged, ISvgElement {
		fixed (T0** _element = &element) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetElement (ptr, (void**) _element);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (T0** attribute) where T0 : unmanaged, ISvgAttribute {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) attribute);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (out T0* attribute) where T0 : unmanaged, ISvgAttribute {
		fixed (T0** _attribute = &attribute) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) _attribute);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemovePointsAtEnd (uint pointsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemovePointsAtEnd (ptr, pointsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UpdatePoints (Vector2F* points, uint pointsCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UpdatePoints (ptr, points, pointsCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPoints (Vector2F* points, uint pointsCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPoints (ptr, points, pointsCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetPointsCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPointsCount (ptr);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFactory;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetElement;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> Clone;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemovePointsAtEnd;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F*, uint, uint, int> UpdatePoints;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F*, uint, uint, int> GetPoints;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetPointsCount;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
