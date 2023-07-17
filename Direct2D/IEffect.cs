using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1Effect</b> : ID2D1Properties<br/>
/// D2D1_1.h
/// </summary>
unsafe public interface IEffect : IProperties {
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Effect::SetInput (UINT32 index, ID2D1Image* input, BOOL invalidate)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="input">_In_opt_ <b>ID2D1Image* input</b></param>
	/// <param name="invalidate"><b>BOOL invalidate</b></param>
	void SetInput<T0> (uint index, T0* input, bool invalidate) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1Effect::SetInputCount (UINT32 inputCount)</b><br/>
	/// </summary>
	/// <param name="inputCount"><b>UINT32 inputCount</b></param>
	int SetInputCount (uint inputCount);
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Effect::GetInput (UINT32 index, ID2D1Image** input)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="input">_Outptr_result_maybenull_ <b>ID2D1Image** input</b></param>
	void GetInput<T0> (uint index, T0** input) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Effect::GetInput (UINT32 index, ID2D1Image** input)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="input">_Outptr_result_maybenull_ <b>ID2D1Image** input</b></param>
	void GetInput<T0> (uint index, out T0* input) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 ID2D1Effect::GetInputCount ()</b><br/>
	/// </summary>
	uint GetInputCount ();
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Effect::GetOutput (ID2D1Image** outputImage)</b><br/>
	/// </summary>
	/// <param name="outputImage">_Outptr_ <b>ID2D1Image** outputImage</b></param>
	void GetOutput<T0> (T0** outputImage) where T0 : unmanaged, IImage;
	/// <summary>
	/// STDMETHOD_ <b>void ID2D1Effect::GetOutput (ID2D1Image** outputImage)</b><br/>
	/// </summary>
	/// <param name="outputImage">_Outptr_ <b>ID2D1Image** outputImage</b></param>
	void GetOutput<T0> (out T0* outputImage) where T0 : unmanaged, IImage;
}

/// <summary>
/// Instance of <b>ID2D1Effect</b><br/>
/// D2D1_1.h
/// </summary>
unsafe public readonly struct Effect : IEffect {
//unsafe public readonly struct IEffectObj : IEffect {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Effect* GetCurrentPointer () => (Effect*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IEffectObj* GetCurrentPointer () => (IEffectObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x28211a43, 0x7d89, 0x476f, 0x81, 0x81, 0x2d, 0x61, 0x59, 0xb2, 0x20, 0xad);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetInput<T0> (uint index, T0* input, bool invalidate) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetInput (ptr, index, input, invalidate ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetInputCount (uint inputCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetInputCount (ptr, inputCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetInput<T0> (uint index, T0** input) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetInput (ptr, index, (void**) input);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetInput<T0> (uint index, out T0* input) where T0 : unmanaged, IImage {
		fixed (T0** _input = &input) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetInput (ptr, index, (void**) _input);
			return;
		}
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
	public readonly void GetOutput<T0> (T0** outputImage) where T0 : unmanaged, IImage {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->GetOutput (ptr, (void**) outputImage);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void GetOutput<T0> (out T0* outputImage) where T0 : unmanaged, IImage {
		fixed (T0** _outputImage = &outputImage) {
			var ptr = GetCurrentPointer ();
			((FunctionPointer*) ptr->_pointer)->GetOutput (ptr, (void**) _outputImage);
			return;
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
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, uint, void> SetInput;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> SetInputCount;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, void> GetInput;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetInputCount;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, void> GetOutput;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
