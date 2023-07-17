using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Properties</b> : IUnknown<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IProperties : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1Properties::GetPropertyCount ()</b><br/>
	/// </summary>
	uint GetPropertyCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Properties::GetPropertyName (UINT32 index, PWSTR name, UINT32 nameCount)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="name">_Out_writes_(nameCount) <b>PWSTR name</b></param>
	/// <param name="nameCount"><b>UINT32 nameCount</b></param>
	int GetPropertyName (uint index, char* name, uint nameCount);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1Properties::GetPropertyNameLength (UINT32 index)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	uint GetPropertyNameLength (uint index);
	/// <summary>
	/// STDMETHOD_ <b>D2D1_PROPERTY_TYPE ID2D1Properties::GetType (UINT32 index)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	PropertyType GetType (uint index);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1Properties::GetPropertyIndex (PCWSTR name)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	uint GetPropertyIndex (char* name);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Properties::SetValueByName (PCWSTR name, D2D1_PROPERTY_TYPE type, BYTE* data, UINT32 dataSize)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_PROPERTY_TYPE type</b></param>
	/// <param name="data">_In_reads_(dataSize) <b>BYTE* data</b></param>
	/// <param name="dataSize"><b>UINT32 dataSize</b></param>
	int SetValueByName (char* name, PropertyType type, byte* data, uint dataSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Properties::SetValue (UINT32 index, D2D1_PROPERTY_TYPE type, BYTE* data, UINT32 dataSize)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="type"><b>D2D1_PROPERTY_TYPE type</b></param>
	/// <param name="data">_In_reads_(dataSize) <b>BYTE* data</b></param>
	/// <param name="dataSize"><b>UINT32 dataSize</b></param>
	int SetValue (uint index, PropertyType type, byte* data, uint dataSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Properties::GetValueByName (PCWSTR name, D2D1_PROPERTY_TYPE type, BYTE* data, UINT32 dataSize)</b><br/>
	/// </summary>
	/// <param name="name">_In_ <b>PCWSTR name</b></param>
	/// <param name="type"><b>D2D1_PROPERTY_TYPE type</b></param>
	/// <param name="data">_Out_writes_(dataSize) <b>BYTE* data</b></param>
	/// <param name="dataSize"><b>UINT32 dataSize</b></param>
	int GetValueByName (char* name, PropertyType type, byte* data, uint dataSize);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Properties::GetValue (UINT32 index, D2D1_PROPERTY_TYPE type, BYTE* data, UINT32 dataSize)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="type"><b>D2D1_PROPERTY_TYPE type</b></param>
	/// <param name="data">_Out_writes_(dataSize) <b>BYTE* data</b></param>
	/// <param name="dataSize"><b>UINT32 dataSize</b></param>
	int GetValue (uint index, PropertyType type, byte* data, uint dataSize);
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1Properties::GetValueSize (UINT32 index)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	uint GetValueSize (uint index);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Properties::GetSubProperties (UINT32 index, ID2D1Properties** subProperties)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="subProperties">_COM_Outptr_result_maybenull_ <b>ID2D1Properties** subProperties</b></param>
	int GetSubProperties<T0> (uint index, T0** subProperties) where T0 : unmanaged, IProperties;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Properties::GetSubProperties (UINT32 index, ID2D1Properties** subProperties)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="subProperties">_COM_Outptr_result_maybenull_ <b>ID2D1Properties** subProperties</b></param>
	int GetSubProperties<T0> (uint index, out T0* subProperties) where T0 : unmanaged, IProperties;
}

/// <summary>
/// Instance of <b>ID2D1Properties</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct Properties : IProperties {
//unsafe public readonly struct IPropertiesObj : IProperties {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Properties* GetCurrentPointer () => (Properties*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPropertiesObj* GetCurrentPointer () => (IPropertiesObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x483473d7, 0xcd46, 0x4f9d, 0x9d, 0x3a, 0x31, 0x12, 0xaa, 0x80, 0x15, 0x9d);

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
	public readonly uint GetPropertyCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetPropertyName (uint index, char* name, uint nameCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyName (ptr, index, name, nameCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetPropertyNameLength (uint index) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyNameLength (ptr, index);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly PropertyType GetType (uint index) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_GetType (ptr, index);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetPropertyIndex (char* name) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPropertyIndex (ptr, name);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetValueByName (char* name, PropertyType type, byte* data, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetValueByName (ptr, name, type, data, dataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetValue (uint index, PropertyType type, byte* data, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetValue (ptr, index, type, data, dataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetValueByName (char* name, PropertyType type, byte* data, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetValueByName (ptr, name, type, data, dataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetValue (uint index, PropertyType type, byte* data, uint dataSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetValue (ptr, index, type, data, dataSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetValueSize (uint index) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetValueSize (ptr, index);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSubProperties<T0> (uint index, T0** subProperties) where T0 : unmanaged, IProperties {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSubProperties (ptr, index, (void**) subProperties);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSubProperties<T0> (uint index, out T0* subProperties) where T0 : unmanaged, IProperties {
		fixed (T0** _subProperties = &subProperties) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSubProperties (ptr, index, (void**) _subProperties);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetPropertyCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, int> GetPropertyName;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> GetPropertyNameLength;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, PropertyType> _GetType;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint> GetPropertyIndex;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, PropertyType, byte*, uint, int> SetValueByName;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, PropertyType, byte*, uint, int> SetValue;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, PropertyType, byte*, uint, int> GetValueByName;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, PropertyType, byte*, uint, int> GetValue;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint> GetValueSize;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, int> GetSubProperties;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
