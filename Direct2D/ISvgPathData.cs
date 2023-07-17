using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgPathData</b> : ID2D1SvgAttribute<br/>
/// D2D1SVG.h
/// </summary>
unsafe public interface ISvgPathData : ISvgAttribute {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::RemoveSegmentDataAtEnd (UINT32 dataCount)</b><br/>
	/// </summary>
	/// <param name="dataCount"><b>UINT32 dataCount</b></param>
	int RemoveSegmentDataAtEnd (uint dataCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::UpdateSegmentData (FLOAT* data, UINT32 dataCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="data">_In_reads_(dataCount) <b>FLOAT* data</b></param>
	/// <param name="dataCount"><b>UINT32 dataCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int UpdateSegmentData (float* data, uint dataCount, uint startIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::GetSegmentData (FLOAT* data, UINT32 dataCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="data">_Out_writes_(dataCount) <b>FLOAT* data</b></param>
	/// <param name="dataCount"><b>UINT32 dataCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int GetSegmentData (float* data, uint dataCount, uint startIndex);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgPathData::GetSegmentDataCount ()</b><br/>
	/// </summary>
	uint GetSegmentDataCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::RemoveCommandsAtEnd (UINT32 commandsCount)</b><br/>
	/// </summary>
	/// <param name="commandsCount"><b>UINT32 commandsCount</b></param>
	int RemoveCommandsAtEnd (uint commandsCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::UpdateCommands (D2D1_SVG_PATH_COMMAND* commands, UINT32 commandsCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="commands">_In_reads_(commandsCount) <b>D2D1_SVG_PATH_COMMAND* commands</b></param>
	/// <param name="commandsCount"><b>UINT32 commandsCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int UpdateCommands (SvgPathCommand* commands, uint commandsCount, uint startIndex);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::GetCommands (D2D1_SVG_PATH_COMMAND* commands, UINT32 commandsCount, UINT32 startIndex)</b><br/>
	/// </summary>
	/// <param name="commands">_Out_writes_(commandsCount) <b>D2D1_SVG_PATH_COMMAND* commands</b></param>
	/// <param name="commandsCount"><b>UINT32 commandsCount</b></param>
	/// <param name="startIndex"><b>UINT32 startIndex</b></param>
	int GetCommands (SvgPathCommand* commands, uint commandsCount, uint startIndex);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgPathData::GetCommandsCount ()</b><br/>
	/// </summary>
	uint GetCommandsCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::CreatePathGeometry (D2D1_FILL_MODE fillMode, ID2D1PathGeometry1** pathGeometry)</b><br/>
	/// </summary>
	/// <param name="fillMode"><b>D2D1_FILL_MODE fillMode</b></param>
	/// <param name="pathGeometry">_COM_Outptr_ <b>ID2D1PathGeometry1** pathGeometry</b></param>
	int CreatePathGeometry<T0> (FillMode fillMode, T0** pathGeometry) where T0 : unmanaged, IPathGeometry1;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgPathData::CreatePathGeometry (D2D1_FILL_MODE fillMode, ID2D1PathGeometry1** pathGeometry)</b><br/>
	/// </summary>
	/// <param name="fillMode"><b>D2D1_FILL_MODE fillMode</b></param>
	/// <param name="pathGeometry">_COM_Outptr_ <b>ID2D1PathGeometry1** pathGeometry</b></param>
	int CreatePathGeometry<T0> (FillMode fillMode, out T0* pathGeometry) where T0 : unmanaged, IPathGeometry1;
}

/// <summary>
/// Instance of <b>ID2D1SvgPathData</b><br/>
/// D2D1SVG.h
/// </summary>
unsafe public readonly struct SvgPathData : ISvgPathData {
//unsafe public readonly struct ISvgPathDataObj : ISvgPathData {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgPathData* GetCurrentPointer () => (SvgPathData*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgPathDataObj* GetCurrentPointer () => (ISvgPathDataObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc095e4f4, 0xbb98, 0x43d6, 0x97, 0x45, 0x4d, 0x1b, 0x84, 0xec, 0x98, 0x88);

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
	public readonly int RemoveSegmentDataAtEnd (uint dataCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveSegmentDataAtEnd (ptr, dataCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UpdateSegmentData (float* data, uint dataCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UpdateSegmentData (ptr, data, dataCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSegmentData (float* data, uint dataCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSegmentData (ptr, data, dataCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetSegmentDataCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSegmentDataCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveCommandsAtEnd (uint commandsCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveCommandsAtEnd (ptr, commandsCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UpdateCommands (SvgPathCommand* commands, uint commandsCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UpdateCommands (ptr, commands, commandsCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCommands (SvgPathCommand* commands, uint commandsCount, uint startIndex) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCommands (ptr, commands, commandsCount, startIndex);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetCommandsCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCommandsCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathGeometry<T0> (FillMode fillMode, T0** pathGeometry) where T0 : unmanaged, IPathGeometry1 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathGeometry (ptr, fillMode, (void**) pathGeometry);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathGeometry<T0> (FillMode fillMode, out T0* pathGeometry) where T0 : unmanaged, IPathGeometry1 {
		fixed (T0** _pathGeometry = &pathGeometry) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathGeometry (ptr, fillMode, (void**) _pathGeometry);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemoveSegmentDataAtEnd;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, uint, uint, int> UpdateSegmentData;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, uint, uint, int> GetSegmentData;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetSegmentDataCount;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> RemoveCommandsAtEnd;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgPathCommand*, uint, uint, int> UpdateCommands;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgPathCommand*, uint, uint, int> GetCommands;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetCommandsCount;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FillMode, void**, int> CreatePathGeometry;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
