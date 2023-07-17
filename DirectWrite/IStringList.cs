using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteStringList</b> : IUnknown<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IStringList : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteStringList::GetCount ()</b><br/>
	/// </summary>
	uint GetCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteStringList::GetLocaleNameLength (UINT32 listIndex, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetLocaleNameLength (uint listIndex, uint* length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteStringList::GetLocaleNameLength (UINT32 listIndex, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetLocaleNameLength (uint listIndex, out uint length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteStringList::GetLocaleName (UINT32 listIndex, WCHAR* localeName, UINT32 size)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="localeName">_Out_writes_z_(size) <b>WCHAR* localeName</b></param>
	/// <param name="size"><b>UINT32 size</b></param>
	int GetLocaleName (uint listIndex, char* localeName, uint size);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteStringList::GetStringLength (UINT32 listIndex, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetStringLength (uint listIndex, uint* length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteStringList::GetStringLength (UINT32 listIndex, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetStringLength (uint listIndex, out uint length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteStringList::GetString (UINT32 listIndex, WCHAR* stringBuffer, UINT32 stringBufferSize)</b><br/>
	/// </summary>
	/// <param name="listIndex"><b>UINT32 listIndex</b></param>
	/// <param name="stringBuffer">_Out_writes_z_(stringBufferSize) <b>WCHAR* stringBuffer</b></param>
	/// <param name="stringBufferSize"><b>UINT32 stringBufferSize</b></param>
	int GetString (uint listIndex, char* stringBuffer, uint stringBufferSize);
}

/// <summary>
/// Instance of <b>IDWriteStringList</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct StringList : IStringList {
//unsafe public readonly struct IStringListObj : IStringList {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly StringList* GetCurrentPointer () => (StringList*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IStringListObj* GetCurrentPointer () => (IStringListObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xcfee3140, 0x1157, 0x47ca, 0x8b, 0x85, 0x31, 0xbf, 0xcf, 0x3f, 0x2d, 0x0e);

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
	public readonly uint GetCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleNameLength (uint listIndex, uint* length) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleNameLength (ptr, listIndex, length);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleNameLength (uint listIndex, out uint length) {
		fixed (uint* _length = &length) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleNameLength (ptr, listIndex, _length);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleName (uint listIndex, char* localeName, uint size) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleName (ptr, listIndex, localeName, size);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStringLength (uint listIndex, uint* length) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStringLength (ptr, listIndex, length);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStringLength (uint listIndex, out uint length) {
		fixed (uint* _length = &length) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetStringLength (ptr, listIndex, _length);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetString (uint listIndex, char* stringBuffer, uint stringBufferSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetString (ptr, listIndex, stringBuffer, stringBufferSize);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetCount;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, int> GetLocaleNameLength;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, int> GetLocaleName;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, int> GetStringLength;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, int> GetString;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
