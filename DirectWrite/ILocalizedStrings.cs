using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteLocalizedStrings</b> : IUnknown<br/>
/// DWRITE.h
/// </summary>
unsafe public interface ILocalizedStrings : IUnknown {
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteLocalizedStrings::GetCount ()</b><br/>
	/// </summary>
	uint GetCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::FindLocaleName (WCHAR* localeName, UINT32* index, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="localeName">_In_z_ <b>WCHAR* localeName</b></param>
	/// <param name="index">_Out_ <b>UINT32* index</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindLocaleName (char* localeName, uint* index, uint* exists);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::FindLocaleName (WCHAR* localeName, UINT32* index, BOOL* exists)</b><br/>
	/// </summary>
	/// <param name="localeName">_In_z_ <b>WCHAR* localeName</b></param>
	/// <param name="index">_Out_ <b>UINT32* index</b></param>
	/// <param name="exists">_Out_ <b>BOOL* exists</b></param>
	int FindLocaleName (char* localeName, out uint index, out bool exists);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::GetLocaleNameLength (UINT32 index, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetLocaleNameLength (uint index, uint* length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::GetLocaleNameLength (UINT32 index, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetLocaleNameLength (uint index, out uint length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::GetLocaleName (UINT32 index, WCHAR* localeName, UINT32 size)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="localeName">_Out_writes_z_(size) <b>WCHAR* localeName</b></param>
	/// <param name="size"><b>UINT32 size</b></param>
	int GetLocaleName (uint index, char* localeName, uint size);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::GetStringLength (UINT32 index, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetStringLength (uint index, uint* length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::GetStringLength (UINT32 index, UINT32* length)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="length">_Out_ <b>UINT32* length</b></param>
	int GetStringLength (uint index, out uint length);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteLocalizedStrings::GetString (UINT32 index, WCHAR* stringBuffer, UINT32 size)</b><br/>
	/// </summary>
	/// <param name="index"><b>UINT32 index</b></param>
	/// <param name="stringBuffer">_Out_writes_z_(size) <b>WCHAR* stringBuffer</b></param>
	/// <param name="size"><b>UINT32 size</b></param>
	int GetString (uint index, char* stringBuffer, uint size);
}

/// <summary>
/// Instance of <b>IDWriteLocalizedStrings</b><br/>
/// DWRITE.h
/// </summary>
unsafe public readonly struct LocalizedStrings : ILocalizedStrings {
//unsafe public readonly struct ILocalizedStringsObj : ILocalizedStrings {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly LocalizedStrings* GetCurrentPointer () => (LocalizedStrings*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ILocalizedStringsObj* GetCurrentPointer () => (ILocalizedStringsObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x08256209, 0x099a, 0x4b34, 0xb8, 0x6d, 0xc2, 0x2b, 0x11, 0x0e, 0x77, 0x71);

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
	public readonly int FindLocaleName (char* localeName, uint* index, uint* exists) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->FindLocaleName (ptr, localeName, index, exists);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int FindLocaleName (char* localeName, out uint index, out bool exists) {
		fixed (uint* _index = &index) {
			uint _exists;
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->FindLocaleName (ptr, localeName, _index, &_exists);
			exists = _exists != 0;
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleNameLength (uint index, uint* length) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleNameLength (ptr, index, length);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleNameLength (uint index, out uint length) {
		fixed (uint* _length = &length) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleNameLength (ptr, index, _length);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetLocaleName (uint index, char* localeName, uint size) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocaleName (ptr, index, localeName, size);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStringLength (uint index, uint* length) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStringLength (ptr, index, length);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStringLength (uint index, out uint length) {
		fixed (uint* _length = &length) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetStringLength (ptr, index, _length);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetString (uint index, char* stringBuffer, uint size) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetString (ptr, index, stringBuffer, size);
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
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint*, uint*, int> FindLocaleName;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, int> GetLocaleNameLength;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, int> GetLocaleName;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, uint*, int> GetStringLength;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, char*, uint, int> GetString;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
