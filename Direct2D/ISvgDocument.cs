using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgDocument</b> : ID2D1Resource<br/>
/// D2D1SVG.h
/// </summary>
unsafe public interface ISvgDocument : IResource {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::SetViewportSize (D2D1_SIZE_F viewportSize)</b><br/>
	/// </summary>
	/// <param name="viewportSize"><b>D2D1_SIZE_F viewportSize</b></param>
	int SetViewportSize (Vector2F viewportSize);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_SIZE_F ID2D1SvgDocument::GetViewportSize ()</b><br/>
	/// </summary>
	Vector2F GetViewportSize ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::SetRoot (ID2D1SvgElement* root)</b><br/>
	/// </summary>
	/// <param name="root">_In_opt_ <b>ID2D1SvgElement* root</b></param>
	int SetRoot<T0> (T0* root) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgDocument::GetRoot (ID2D1SvgElement** root)</b><br/>
	/// </summary>
	/// <param name="root">_Outptr_result_maybenull_ <b>ID2D1SvgElement** root</b></param>
	void GetRoot<T0> (T0** root) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgDocument::GetRoot (ID2D1SvgElement** root)</b><br/>
	/// </summary>
	/// <param name="root">_Outptr_result_maybenull_ <b>ID2D1SvgElement** root</b></param>
	void GetRoot<T0> (out T0* root) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::FindElementById (PCWSTR id, ID2D1SvgElement** svgElement)</b><br/>
	/// </summary>
	/// <param name="id">_In_ <b>PCWSTR id</b></param>
	/// <param name="svgElement">_COM_Outptr_result_maybenull_ <b>ID2D1SvgElement** svgElement</b></param>
	int FindElementById<T0> (char* id, T0** svgElement) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::FindElementById (PCWSTR id, ID2D1SvgElement** svgElement)</b><br/>
	/// </summary>
	/// <param name="id">_In_ <b>PCWSTR id</b></param>
	/// <param name="svgElement">_COM_Outptr_result_maybenull_ <b>ID2D1SvgElement** svgElement</b></param>
	int FindElementById<T0> (char* id, out T0* svgElement) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::Serialize (IStream* outputXmlStream, ID2D1SvgElement* subtree)</b><br/>
	/// </summary>
	/// <param name="outputXmlStream">_In_ <b>IStream* outputXmlStream</b></param>
	/// <param name="subtree">_In_opt_ <b>ID2D1SvgElement* subtree</b></param>
	int Serialize<T0, T1> (T0* outputXmlStream, T1* subtree) where T0 : unmanaged, IStream where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::Deserialize (IStream* inputXmlStream, ID2D1SvgElement** subtree)</b><br/>
	/// </summary>
	/// <param name="inputXmlStream">_In_ <b>IStream* inputXmlStream</b></param>
	/// <param name="subtree">_COM_Outptr_ <b>ID2D1SvgElement** subtree</b></param>
	int Deserialize<T0, T1> (T0* inputXmlStream, T1** subtree) where T0 : unmanaged, IStream where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::Deserialize (IStream* inputXmlStream, ID2D1SvgElement** subtree)</b><br/>
	/// </summary>
	/// <param name="inputXmlStream">_In_ <b>IStream* inputXmlStream</b></param>
	/// <param name="subtree">_COM_Outptr_ <b>ID2D1SvgElement** subtree</b></param>
	int Deserialize<T0, T1> (T0* inputXmlStream, out T1* subtree) where T0 : unmanaged, IStream where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreatePaint (D2D1_SVG_PAINT_TYPE paintType, D2D1_COLOR_F* color, PCWSTR id, ID2D1SvgPaint** paint)</b><br/>
	/// </summary>
	/// <param name="paintType"><b>D2D1_SVG_PAINT_TYPE paintType</b></param>
	/// <param name="color">_In_opt_ <b>D2D1_COLOR_F* color</b></param>
	/// <param name="id">_In_opt_ <b>PCWSTR id</b></param>
	/// <param name="paint">_COM_Outptr_ <b>ID2D1SvgPaint** paint</b></param>
	int CreatePaint<T0> (SvgPaintType paintType, Vector4F* color, char* id, T0** paint) where T0 : unmanaged, ISvgPaint;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreatePaint (D2D1_SVG_PAINT_TYPE paintType, D2D1_COLOR_F* color, PCWSTR id, ID2D1SvgPaint** paint)</b><br/>
	/// </summary>
	/// <param name="paintType"><b>D2D1_SVG_PAINT_TYPE paintType</b></param>
	/// <param name="color">_In_opt_ <b>D2D1_COLOR_F* color</b></param>
	/// <param name="id">_In_opt_ <b>PCWSTR id</b></param>
	/// <param name="paint">_COM_Outptr_ <b>ID2D1SvgPaint** paint</b></param>
	int CreatePaint<T0> (SvgPaintType paintType, Vector4F* color, char* id, out T0* paint) where T0 : unmanaged, ISvgPaint;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreateStrokeDashArray (D2D1_SVG_LENGTH* dashes, UINT32 dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)</b><br/>
	/// </summary>
	/// <param name="dashes">_In_reads_opt_(dashesCount) <b>D2D1_SVG_LENGTH* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="strokeDashArray">_COM_Outptr_ <b>ID2D1SvgStrokeDashArray** strokeDashArray</b></param>
	int CreateStrokeDashArray<T0> (SvgLength* dashes, uint dashesCount, T0** strokeDashArray) where T0 : unmanaged, ISvgStrokeDashArray;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreateStrokeDashArray (D2D1_SVG_LENGTH* dashes, UINT32 dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)</b><br/>
	/// </summary>
	/// <param name="dashes">_In_reads_opt_(dashesCount) <b>D2D1_SVG_LENGTH* dashes</b></param>
	/// <param name="dashesCount"><b>UINT32 dashesCount</b></param>
	/// <param name="strokeDashArray">_COM_Outptr_ <b>ID2D1SvgStrokeDashArray** strokeDashArray</b></param>
	int CreateStrokeDashArray<T0> (SvgLength* dashes, uint dashesCount, out T0* strokeDashArray) where T0 : unmanaged, ISvgStrokeDashArray;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreatePointCollection (D2D1_POINT_2F* points, UINT32 pointsCount, ID2D1SvgPointCollection** pointCollection)</b><br/>
	/// </summary>
	/// <param name="points">_In_reads_opt_(pointsCount) <b>D2D1_POINT_2F* points</b></param>
	/// <param name="pointsCount"><b>UINT32 pointsCount</b></param>
	/// <param name="pointCollection">_COM_Outptr_ <b>ID2D1SvgPointCollection** pointCollection</b></param>
	int CreatePointCollection<T0> (Vector2F* points, uint pointsCount, T0** pointCollection) where T0 : unmanaged, ISvgPointCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreatePointCollection (D2D1_POINT_2F* points, UINT32 pointsCount, ID2D1SvgPointCollection** pointCollection)</b><br/>
	/// </summary>
	/// <param name="points">_In_reads_opt_(pointsCount) <b>D2D1_POINT_2F* points</b></param>
	/// <param name="pointsCount"><b>UINT32 pointsCount</b></param>
	/// <param name="pointCollection">_COM_Outptr_ <b>ID2D1SvgPointCollection** pointCollection</b></param>
	int CreatePointCollection<T0> (Vector2F* points, uint pointsCount, out T0* pointCollection) where T0 : unmanaged, ISvgPointCollection;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreatePathData (FLOAT* segmentData, UINT32 segmentDataCount, D2D1_SVG_PATH_COMMAND* commands, UINT32 commandsCount, ID2D1SvgPathData** pathData)</b><br/>
	/// </summary>
	/// <param name="segmentData">_In_reads_opt_(segmentDataCount) <b>FLOAT* segmentData</b></param>
	/// <param name="segmentDataCount"><b>UINT32 segmentDataCount</b></param>
	/// <param name="commands">_In_reads_opt_(commandsCount) <b>D2D1_SVG_PATH_COMMAND* commands</b></param>
	/// <param name="commandsCount"><b>UINT32 commandsCount</b></param>
	/// <param name="pathData">_COM_Outptr_ <b>ID2D1SvgPathData** pathData</b></param>
	int CreatePathData<T0> (float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, T0** pathData) where T0 : unmanaged, ISvgPathData;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgDocument::CreatePathData (FLOAT* segmentData, UINT32 segmentDataCount, D2D1_SVG_PATH_COMMAND* commands, UINT32 commandsCount, ID2D1SvgPathData** pathData)</b><br/>
	/// </summary>
	/// <param name="segmentData">_In_reads_opt_(segmentDataCount) <b>FLOAT* segmentData</b></param>
	/// <param name="segmentDataCount"><b>UINT32 segmentDataCount</b></param>
	/// <param name="commands">_In_reads_opt_(commandsCount) <b>D2D1_SVG_PATH_COMMAND* commands</b></param>
	/// <param name="commandsCount"><b>UINT32 commandsCount</b></param>
	/// <param name="pathData">_COM_Outptr_ <b>ID2D1SvgPathData** pathData</b></param>
	int CreatePathData<T0> (float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, out T0* pathData) where T0 : unmanaged, ISvgPathData;
}

/// <summary>
/// Instance of <b>ID2D1SvgDocument</b><br/>
/// D2D1SVG.h
/// </summary>
unsafe public readonly struct SvgDocument : ISvgDocument {
//unsafe public readonly struct ISvgDocumentObj : ISvgDocument {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgDocument* GetCurrentPointer () => (SvgDocument*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgDocumentObj* GetCurrentPointer () => (ISvgDocumentObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x86b88e4d, 0xafa4, 0x4d7b, 0x88, 0xe4, 0x68, 0xa5, 0x1c, 0x4a, 0x0a, 0xec);

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
	public readonly int SetViewportSize (Vector2F viewportSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetViewportSize (ptr, viewportSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Vector2F GetViewportSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetViewportSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetRoot<T0> (T0* root) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetRoot (ptr, root);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetRoot<T0> (T0** root) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetRoot (ptr, (void**) root);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetRoot<T0> (out T0* root) where T0 : unmanaged, ISvgElement {
		fixed (T0** _root = &root) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetRoot (ptr, (void**) _root);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindElementById<T0> (char* id, T0** svgElement) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindElementById (ptr, id, (void**) svgElement);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindElementById<T0> (char* id, out T0* svgElement) where T0 : unmanaged, ISvgElement {
		fixed (T0** _svgElement = &svgElement) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindElementById (ptr, id, (void**) _svgElement);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Serialize<T0, T1> (T0* outputXmlStream, T1* subtree) where T0 : unmanaged, IStream where T1 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Serialize (ptr, outputXmlStream, subtree);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Deserialize<T0, T1> (T0* inputXmlStream, T1** subtree) where T0 : unmanaged, IStream where T1 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Deserialize (ptr, inputXmlStream, (void**) subtree);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Deserialize<T0, T1> (T0* inputXmlStream, out T1* subtree) where T0 : unmanaged, IStream where T1 : unmanaged, ISvgElement {
		fixed (T1** _subtree = &subtree) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Deserialize (ptr, inputXmlStream, (void**) _subtree);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePaint<T0> (SvgPaintType paintType, Vector4F* color, char* id, T0** paint) where T0 : unmanaged, ISvgPaint {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePaint (ptr, paintType, color, id, (void**) paint);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePaint<T0> (SvgPaintType paintType, Vector4F* color, char* id, out T0* paint) where T0 : unmanaged, ISvgPaint {
		fixed (T0** _paint = &paint) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePaint (ptr, paintType, color, id, (void**) _paint);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokeDashArray<T0> (SvgLength* dashes, uint dashesCount, T0** strokeDashArray) where T0 : unmanaged, ISvgStrokeDashArray {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokeDashArray (ptr, dashes, dashesCount, (void**) strokeDashArray);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateStrokeDashArray<T0> (SvgLength* dashes, uint dashesCount, out T0* strokeDashArray) where T0 : unmanaged, ISvgStrokeDashArray {
		fixed (T0** _strokeDashArray = &strokeDashArray) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateStrokeDashArray (ptr, dashes, dashesCount, (void**) _strokeDashArray);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePointCollection<T0> (Vector2F* points, uint pointsCount, T0** pointCollection) where T0 : unmanaged, ISvgPointCollection {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePointCollection (ptr, points, pointsCount, (void**) pointCollection);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePointCollection<T0> (Vector2F* points, uint pointsCount, out T0* pointCollection) where T0 : unmanaged, ISvgPointCollection {
		fixed (T0** _pointCollection = &pointCollection) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePointCollection (ptr, points, pointsCount, (void**) _pointCollection);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathData<T0> (float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, T0** pathData) where T0 : unmanaged, ISvgPathData {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathData (ptr, segmentData, segmentDataCount, commands, commandsCount, (void**) pathData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreatePathData<T0> (float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, out T0* pathData) where T0 : unmanaged, ISvgPathData {
		fixed (T0** _pathData = &pathData) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreatePathData (ptr, segmentData, segmentDataCount, commands, commandsCount, (void**) _pathData);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F, int> SetViewportSize;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F> GetViewportSize;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> SetRoot;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetRoot;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void**, int> FindElementById;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> Serialize;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> Deserialize;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgPaintType, Vector4F*, char*, void**, int> CreatePaint;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, SvgLength*, uint, void**, int> CreateStrokeDashArray;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Vector2F*, uint, void**, int> CreatePointCollection;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, float*, uint, SvgPathCommand*, uint, void**, int> CreatePathData;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
