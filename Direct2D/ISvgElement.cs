using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1SvgElement</b> : ID2D1Resource<br/>
/// D2D1SVG.h
/// </summary>
unsafe public interface ISvgElement : IResource {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetDocument (ID2D1SvgDocument** document)</b><br/>
	/// </summary>
	/// <param name="document">_Outptr_result_maybenull_ <b>ID2D1SvgDocument** document</b></param>
	void GetDocument<T0> (T0** document) where T0 : unmanaged, ISvgDocument;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetDocument (ID2D1SvgDocument** document)</b><br/>
	/// </summary>
	/// <param name="document">_Outptr_result_maybenull_ <b>ID2D1SvgDocument** document</b></param>
	void GetDocument<T0> (out T0* document) where T0 : unmanaged, ISvgDocument;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetTagName (PWSTR name, UINT32 nameCount)</b><br/>
	/// </summary>
	/// <param name="name">_Out_writes_(nameCount) <b>PWSTR name</b></param>
	/// <param name="nameCount"><b>UINT32 nameCount</b></param>
	int GetTagName (char* name, uint nameCount);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgElement::GetTagNameLength ()</b><br/>
	/// </summary>
	uint GetTagNameLength ();
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1SvgElement::IsTextContent ()</b><br/>
	/// </summary>
	bool IsTextContent ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetParent (ID2D1SvgElement** parent)</b><br/>
	/// </summary>
	/// <param name="parent">_Outptr_result_maybenull_ <b>ID2D1SvgElement** parent</b></param>
	void GetParent<T0> (T0** parent) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetParent (ID2D1SvgElement** parent)</b><br/>
	/// </summary>
	/// <param name="parent">_Outptr_result_maybenull_ <b>ID2D1SvgElement** parent</b></param>
	void GetParent<T0> (out T0* parent) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1SvgElement::HasChildren ()</b><br/>
	/// </summary>
	bool HasChildren ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetFirstChild (ID2D1SvgElement** child)</b><br/>
	/// </summary>
	/// <param name="child">_Outptr_result_maybenull_ <b>ID2D1SvgElement** child</b></param>
	void GetFirstChild<T0> (T0** child) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetFirstChild (ID2D1SvgElement** child)</b><br/>
	/// </summary>
	/// <param name="child">_Outptr_result_maybenull_ <b>ID2D1SvgElement** child</b></param>
	void GetFirstChild<T0> (out T0* child) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetLastChild (ID2D1SvgElement** child)</b><br/>
	/// </summary>
	/// <param name="child">_Outptr_result_maybenull_ <b>ID2D1SvgElement** child</b></param>
	void GetLastChild<T0> (T0** child) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1SvgElement::GetLastChild (ID2D1SvgElement** child)</b><br/>
	/// </summary>
	/// <param name="child">_Outptr_result_maybenull_ <b>ID2D1SvgElement** child</b></param>
	void GetLastChild<T0> (out T0* child) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetPreviousChild (ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)</b><br/>
	/// </summary>
	/// <param name="referenceChild">_In_ <b>ID2D1SvgElement* referenceChild</b></param>
	/// <param name="previousChild">_COM_Outptr_result_maybenull_ <b>ID2D1SvgElement** previousChild</b></param>
	int GetPreviousChild<T0, T1> (T0* referenceChild, T1** previousChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetPreviousChild (ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)</b><br/>
	/// </summary>
	/// <param name="referenceChild">_In_ <b>ID2D1SvgElement* referenceChild</b></param>
	/// <param name="previousChild">_COM_Outptr_result_maybenull_ <b>ID2D1SvgElement** previousChild</b></param>
	int GetPreviousChild<T0, T1> (T0* referenceChild, out T1* previousChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetNextChild (ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)</b><br/>
	/// </summary>
	/// <param name="referenceChild">_In_ <b>ID2D1SvgElement* referenceChild</b></param>
	/// <param name="nextChild">_COM_Outptr_result_maybenull_ <b>ID2D1SvgElement** nextChild</b></param>
	int GetNextChild<T0, T1> (T0* referenceChild, T1** nextChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetNextChild (ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)</b><br/>
	/// </summary>
	/// <param name="referenceChild">_In_ <b>ID2D1SvgElement* referenceChild</b></param>
	/// <param name="nextChild">_COM_Outptr_result_maybenull_ <b>ID2D1SvgElement** nextChild</b></param>
	int GetNextChild<T0, T1> (T0* referenceChild, out T1* nextChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::InsertChildBefore (ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild)</b><br/>
	/// </summary>
	/// <param name="newChild">_In_ <b>ID2D1SvgElement* newChild</b></param>
	/// <param name="referenceChild">_In_opt_ <b>ID2D1SvgElement* referenceChild</b></param>
	int InsertChildBefore<T0, T1> (T0* newChild, T1* referenceChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::AppendChild (ID2D1SvgElement* newChild)</b><br/>
	/// </summary>
	/// <param name="newChild">_In_ <b>ID2D1SvgElement* newChild</b></param>
	int AppendChild<T0> (T0* newChild) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::ReplaceChild (ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)</b><br/>
	/// </summary>
	/// <param name="newChild">_In_ <b>ID2D1SvgElement* newChild</b></param>
	/// <param name="oldChild">_In_ <b>ID2D1SvgElement* oldChild</b></param>
	int ReplaceChild<T0, T1> (T0* newChild, T1* oldChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::RemoveChild (ID2D1SvgElement* oldChild)</b><br/>
	/// </summary>
	/// <param name="oldChild">_In_ <b>ID2D1SvgElement* oldChild</b></param>
	int RemoveChild<T0> (T0* oldChild) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::CreateChild (PCWSTR tagName, ID2D1SvgElement** newChild)</b><br/>
	/// </summary>
	/// <param name="tagName">_In_ <b>PCWSTR tagName</b></param>
	/// <param name="newChild">_COM_Outptr_ <b>ID2D1SvgElement** newChild</b></param>
	int CreateChild<T0> (char* tagName, T0** newChild) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::CreateChild (PCWSTR tagName, ID2D1SvgElement** newChild)</b><br/>
	/// </summary>
	/// <param name="tagName">_In_ <b>PCWSTR tagName</b></param>
	/// <param name="newChild">_COM_Outptr_ <b>ID2D1SvgElement** newChild</b></param>
	int CreateChild<T0> (char* tagName, out T0* newChild) where T0 : unmanaged, ISvgElement;
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1SvgElement::IsAttributeSpecified (PCWSTR name, BOOL* inherited)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="inherited">_Out_opt_ <b>BOOL* inherited</b></param>
	bool IsAttributeSpecified (char* name, uint* inherited);
	/// <summary>
	/// STDMETHOD_ <b>BOOL ID2D1SvgElement::IsAttributeSpecified (PCWSTR name, BOOL* inherited)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="inherited">_Out_opt_ <b>BOOL* inherited</b></param>
	bool IsAttributeSpecified (char* name, out bool inherited);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgElement::GetSpecifiedAttributeCount ()</b><br/>
	/// </summary>
	uint GetSpecifiedAttributeCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetSpecifiedAttributeName (UINT32 index, PWSTR name, UINT32 nameCount, BOOL* inherited)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="name">_Out_writes_(nameCount) <b>PWSTR name</b></param>
	/// <param name="nameCount"><b>UINT32 nameCount</b></param>
	/// <param name="inherited">_Out_opt_ <b>BOOL* inherited</b></param>
	int GetSpecifiedAttributeName (uint index, char* name, uint nameCount, uint* inherited);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetSpecifiedAttributeName (UINT32 index, PWSTR name, UINT32 nameCount, BOOL* inherited)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="name">_Out_writes_(nameCount) <b>PWSTR name</b></param>
	/// <param name="nameCount"><b>UINT32 nameCount</b></param>
	/// <param name="inherited">_Out_opt_ <b>BOOL* inherited</b></param>
	int GetSpecifiedAttributeName (uint index, char* name, uint nameCount, out bool inherited);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetSpecifiedAttributeNameLength (UINT32 index, UINT32* nameLength, BOOL* inherited)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="nameLength">_Out_ <b>UINT32* nameLength</b></param>
	/// <param name="inherited">_Out_opt_ <b>BOOL* inherited</b></param>
	int GetSpecifiedAttributeNameLength (uint index, uint* nameLength, uint* inherited);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetSpecifiedAttributeNameLength (UINT32 index, UINT32* nameLength, BOOL* inherited)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="nameLength">_Out_ <b>UINT32* nameLength</b></param>
	/// <param name="inherited">_Out_opt_ <b>BOOL* inherited</b></param>
	int GetSpecifiedAttributeNameLength (uint index, out uint nameLength, out bool inherited);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::RemoveAttribute (PCWSTR name)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	int RemoveAttribute (char* name);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::SetTextValue (WCHAR* name, UINT32 nameCount)</b><br/>
	/// </summary>
	/// <param name="name">_In_reads_(nameCount) <b>WCHAR* name</b></param>
	/// <param name="nameCount"><b>UINT32 nameCount</b></param>
	int SetTextValue (char* name, uint nameCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetTextValue (PWSTR name, UINT32 nameCount)</b><br/>
	/// </summary>
	/// <param name="name">_Out_writes_(nameCount) <b>PWSTR name</b></param>
	/// <param name="nameCount"><b>UINT32 nameCount</b></param>
	int GetTextValue (char* name, uint nameCount);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1SvgElement::GetTextValueLength ()</b><br/>
	/// </summary>
	uint GetTextValueLength ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::SetAttributeValue (PCWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, PCWSTR value)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_SVG_ATTRIBUTE_STRING_TYPE type</b></param>
	/// <param name="value">_In_ <b>PCWSTR value</b></param>
	int SetAttributeValue (char* name, SvgAttributeStringType type, char* value);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetAttributeValue (PCWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, PWSTR value, UINT32 valueCount)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_SVG_ATTRIBUTE_STRING_TYPE type</b></param>
	/// <param name="value">_Out_writes_(valueCount) <b>PWSTR value</b></param>
	/// <param name="valueCount"><b>UINT32 valueCount</b></param>
	int GetAttributeValue (char* name, SvgAttributeStringType type, char* value, uint valueCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetAttributeValueLength (PCWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, UINT32* valueLength)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_SVG_ATTRIBUTE_STRING_TYPE type</b></param>
	/// <param name="valueLength">_Out_ <b>UINT32* valueLength</b></param>
	int GetAttributeValueLength (char* name, SvgAttributeStringType type, uint* valueLength);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetAttributeValueLength (PCWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, UINT32* valueLength)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_SVG_ATTRIBUTE_STRING_TYPE type</b></param>
	/// <param name="valueLength">_Out_ <b>UINT32* valueLength</b></param>
	int GetAttributeValueLength (char* name, SvgAttributeStringType type, out uint valueLength);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::SetAttributeValue (PCWSTR name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, UINT32 valueSizeInBytes)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_SVG_ATTRIBUTE_POD_TYPE type</b></param>
	/// <param name="value">_In_reads_bytes_(valueSizeInBytes) <b>void* value</b></param>
	/// <param name="valueSizeInBytes"><b>UINT32 valueSizeInBytes</b></param>
	int SetAttributeValue (char* name, SvgAttributePodType type, void* value, uint valueSizeInBytes);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetAttributeValue (PCWSTR name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, UINT32 valueSizeInBytes)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_SVG_ATTRIBUTE_POD_TYPE type</b></param>
	/// <param name="value">_Out_writes_bytes_(valueSizeInBytes) <b>void* value</b></param>
	/// <param name="valueSizeInBytes"><b>UINT32 valueSizeInBytes</b></param>
	int GetAttributeValue (char* name, SvgAttributePodType type, void* value, uint valueSizeInBytes);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::SetAttributeValue (PCWSTR name, ID2D1SvgAttribute* value)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="value">_In_ <b>ID2D1SvgAttribute* value</b></param>
	int SetAttributeValue<T0> (char* name, T0* value) where T0 : unmanaged, ISvgAttribute;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetAttributeValue (PCWSTR name, REFIID riid, void** value)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="value">_COM_Outptr_result_maybenull_ <b>void** value</b></param>
	int GetAttributeValue (char* name, Guid riid, void** value);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1SvgElement::GetAttributeValue (PCWSTR name, REFIID riid, void** value)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="value">_COM_Outptr_result_maybenull_ <b>void** value</b></param>
	int GetAttributeValue (char* name, Guid riid, out void* value);
}

/// <summary>
/// Instance of <b>ID2D1SvgElement</b><br/>
/// D2D1SVG.h
/// </summary>
unsafe public readonly struct SvgElement : ISvgElement {
//unsafe public readonly struct ISvgElementObj : ISvgElement {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SvgElement* GetCurrentPointer () => (SvgElement*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISvgElementObj* GetCurrentPointer () => (ISvgElementObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xac7b67a6, 0x183e, 0x49c1, 0xa8, 0x23, 0x0e, 0xbe, 0x40, 0xb0, 0xdb, 0x29);

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
	public readonly void GetDocument<T0> (T0** document) where T0 : unmanaged, ISvgDocument {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetDocument (ptr, (void**) document);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetDocument<T0> (out T0* document) where T0 : unmanaged, ISvgDocument {
		fixed (T0** _document = &document) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetDocument (ptr, (void**) _document);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTagName (char* name, uint nameCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTagName (ptr, name, nameCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetTagNameLength () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTagNameLength (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsTextContent () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsTextContent (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetParent<T0> (T0** parent) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetParent (ptr, (void**) parent);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetParent<T0> (out T0* parent) where T0 : unmanaged, ISvgElement {
		fixed (T0** _parent = &parent) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetParent (ptr, (void**) _parent);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool HasChildren () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->HasChildren (ptr) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFirstChild<T0> (T0** child) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetFirstChild (ptr, (void**) child);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetFirstChild<T0> (out T0* child) where T0 : unmanaged, ISvgElement {
		fixed (T0** _child = &child) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetFirstChild (ptr, (void**) _child);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetLastChild<T0> (T0** child) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetLastChild (ptr, (void**) child);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetLastChild<T0> (out T0* child) where T0 : unmanaged, ISvgElement {
		fixed (T0** _child = &child) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetLastChild (ptr, (void**) _child);
			return;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPreviousChild<T0, T1> (T0* referenceChild, T1** previousChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPreviousChild (ptr, referenceChild, (void**) previousChild);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPreviousChild<T0, T1> (T0* referenceChild, out T1* previousChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement {
		fixed (T1** _previousChild = &previousChild) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetPreviousChild (ptr, referenceChild, (void**) _previousChild);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNextChild<T0, T1> (T0* referenceChild, T1** nextChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNextChild (ptr, referenceChild, (void**) nextChild);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetNextChild<T0, T1> (T0* referenceChild, out T1* nextChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement {
		fixed (T1** _nextChild = &nextChild) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetNextChild (ptr, referenceChild, (void**) _nextChild);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int InsertChildBefore<T0, T1> (T0* newChild, T1* referenceChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->InsertChildBefore (ptr, newChild, referenceChild);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AppendChild<T0> (T0* newChild) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AppendChild (ptr, newChild);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int ReplaceChild<T0, T1> (T0* newChild, T1* oldChild) where T0 : unmanaged, ISvgElement where T1 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->ReplaceChild (ptr, newChild, oldChild);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveChild<T0> (T0* oldChild) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveChild (ptr, oldChild);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateChild<T0> (char* tagName, T0** newChild) where T0 : unmanaged, ISvgElement {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateChild (ptr, tagName, (void**) newChild);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateChild<T0> (char* tagName, out T0* newChild) where T0 : unmanaged, ISvgElement {
		fixed (T0** _newChild = &newChild) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateChild (ptr, tagName, (void**) _newChild);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsAttributeSpecified (char* name, uint* inherited) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsAttributeSpecified (ptr, name, inherited) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool IsAttributeSpecified (char* name, out bool inherited) {
		uint _inherited;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsAttributeSpecified (ptr, name, &_inherited) != 0;
		inherited = _inherited != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetSpecifiedAttributeCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSpecifiedAttributeCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSpecifiedAttributeName (uint index, char* name, uint nameCount, uint* inherited) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSpecifiedAttributeName (ptr, index, name, nameCount, inherited);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSpecifiedAttributeName (uint index, char* name, uint nameCount, out bool inherited) {
		uint _inherited;
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSpecifiedAttributeName (ptr, index, name, nameCount, &_inherited);
		inherited = _inherited != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSpecifiedAttributeNameLength (uint index, uint* nameLength, uint* inherited) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSpecifiedAttributeNameLength (ptr, index, nameLength, inherited);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSpecifiedAttributeNameLength (uint index, out uint nameLength, out bool inherited) {
		fixed (uint* _nameLength = &nameLength) {
			uint _inherited;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSpecifiedAttributeNameLength (ptr, index, _nameLength, &_inherited);
			inherited = _inherited != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int RemoveAttribute (char* name) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->RemoveAttribute (ptr, name);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetTextValue (char* name, uint nameCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetTextValue (ptr, name, nameCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetTextValue (char* name, uint nameCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextValue (ptr, name, nameCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetTextValueLength () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetTextValueLength (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetAttributeValue (char* name, SvgAttributeStringType type, char* value) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__SetAttributeValue (ptr, name, type, value);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAttributeValue (char* name, SvgAttributeStringType type, char* value, uint valueCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->__GetAttributeValue (ptr, name, type, value, valueCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAttributeValueLength (char* name, SvgAttributeStringType type, uint* valueLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAttributeValueLength (ptr, name, type, valueLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAttributeValueLength (char* name, SvgAttributeStringType type, out uint valueLength) {
		fixed (uint* _valueLength = &valueLength) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAttributeValueLength (ptr, name, type, _valueLength);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetAttributeValue (char* name, SvgAttributePodType type, void* value, uint valueSizeInBytes) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_SetAttributeValue (ptr, name, type, value, valueSizeInBytes);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAttributeValue (char* name, SvgAttributePodType type, void* value, uint valueSizeInBytes) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetAttributeValue (ptr, name, type, value, valueSizeInBytes);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetAttributeValue<T0> (char* name, T0* value) where T0 : unmanaged, ISvgAttribute {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetAttributeValue (ptr, name, value);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAttributeValue (char* name, Guid riid, void** value) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetAttributeValue (ptr, name, riid, value);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetAttributeValue (char* name, Guid riid, out void* value) {
		fixed (void** _value = &value) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetAttributeValue (ptr, name, riid, _value);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetDocument;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> GetTagName;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetTagNameLength;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> IsTextContent;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetParent;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> HasChildren;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetFirstChild;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetLastChild;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> GetPreviousChild;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void**, int> GetNextChild;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> InsertChildBefore;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> AppendChild;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, void*, int> ReplaceChild;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> RemoveChild;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void**, int> CreateChild;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint*, uint> IsAttributeSpecified;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetSpecifiedAttributeCount;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, uint*, int> GetSpecifiedAttributeName;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, uint*, int> GetSpecifiedAttributeNameLength;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> RemoveAttribute;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> SetTextValue;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> GetTextValue;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetTextValueLength;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*, int> SetAttributeValue;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, SvgAttributePodType, void*, uint, int> _SetAttributeValue;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, SvgAttributeStringType, char*, int> __SetAttributeValue;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, Guid, void**, int> GetAttributeValue;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, SvgAttributePodType, void*, uint, int> _GetAttributeValue;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, SvgAttributeStringType, char*, uint, int> __GetAttributeValue;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, SvgAttributeStringType, uint*, int> GetAttributeValueLength;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
