using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFaceReference</b> : IUnknown<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontFaceReference : IUnknown {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::CreateFontFace (IDWriteFontFace3** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace3** fontFace</b></param>
	int CreateFontFace<T0> (T0** fontFace) where T0 : unmanaged, IFontFace3;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::CreateFontFace (IDWriteFontFace3** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace3** fontFace</b></param>
	int CreateFontFace<T0> (out T0* fontFace) where T0 : unmanaged, IFontFace3;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::CreateFontFaceWithSimulations (DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace3** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFaceSimulationFlags"><b>DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace3** fontFace</b></param>
	int CreateFontFaceWithSimulations<T0> (FontSimulations fontFaceSimulationFlags, T0** fontFace) where T0 : unmanaged, IFontFace3;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::CreateFontFaceWithSimulations (DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace3** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFaceSimulationFlags"><b>DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags</b></param>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace3** fontFace</b></param>
	int CreateFontFaceWithSimulations<T0> (FontSimulations fontFaceSimulationFlags, out T0* fontFace) where T0 : unmanaged, IFontFace3;
	/// <summary>
	/// STDMETHOD_ <b>BOOL IDWriteFontFaceReference::Equals (IDWriteFontFaceReference* fontFaceReference)</b><br/>
	/// </summary>
	/// <param name="fontFaceReference"><b>IDWriteFontFaceReference* fontFaceReference</b></param>
	bool Equals<T0> (T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontFaceReference::GetFontFaceIndex ()</b><br/>
	/// </summary>
	uint GetFontFaceIndex ();
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_FONT_SIMULATIONS IDWriteFontFaceReference::GetSimulations ()</b><br/>
	/// </summary>
	FontSimulations GetSimulations ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::GetFontFile (IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int GetFontFile<T0> (T0** fontFile) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::GetFontFile (IDWriteFontFile** fontFile)</b><br/>
	/// </summary>
	/// <param name="fontFile">_COM_Outptr_ <b>IDWriteFontFile** fontFile</b></param>
	int GetFontFile<T0> (out T0* fontFile) where T0 : unmanaged, IFontFile;
	/// <summary>
	/// STDMETHOD_ <b>UINT64 IDWriteFontFaceReference::GetLocalFileSize ()</b><br/>
	/// </summary>
	ulong GetLocalFileSize ();
	/// <summary>
	/// STDMETHOD_ <b>UINT64 IDWriteFontFaceReference::GetFileSize ()</b><br/>
	/// </summary>
	ulong GetFileSize ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::GetFileTime (FILETIME* lastWriteTime)</b><br/>
	/// </summary>
	/// <param name="lastWriteTime">_Out_ <b>FILETIME* lastWriteTime</b></param>
	int GetFileTime (FileTime* lastWriteTime);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::GetFileTime (FILETIME* lastWriteTime)</b><br/>
	/// </summary>
	/// <param name="lastWriteTime">_Out_ <b>FILETIME* lastWriteTime</b></param>
	int GetFileTime (out FileTime lastWriteTime);
	/// <summary>
	/// STDMETHOD_ <b>DWRITE_LOCALITY IDWriteFontFaceReference::GetLocality ()</b><br/>
	/// </summary>
	Locality GetLocality ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::EnqueueFontDownloadRequest ()</b><br/>
	/// </summary>
	int EnqueueFontDownloadRequest ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::EnqueueCharacterDownloadRequest (WCHAR* characters, UINT32 characterCount)</b><br/>
	/// </summary>
	/// <param name="characters">_In_reads_(characterCount) <b>WCHAR* characters</b></param>
	/// <param name="characterCount"><b>UINT32 characterCount</b></param>
	int EnqueueCharacterDownloadRequest (char* characters, uint characterCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::EnqueueGlyphDownloadRequest (UINT16* glyphIndices, UINT32 glyphCount)</b><br/>
	/// </summary>
	/// <param name="glyphIndices">_In_reads_(glyphCount) <b>UINT16* glyphIndices</b></param>
	/// <param name="glyphCount"><b>UINT32 glyphCount</b></param>
	int EnqueueGlyphDownloadRequest (ushort* glyphIndices, uint glyphCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference::EnqueueFileFragmentDownloadRequest (UINT64 fileOffset, UINT64 fragmentSize)</b><br/>
	/// </summary>
	/// <param name="fileOffset"><b>UINT64 fileOffset</b></param>
	/// <param name="fragmentSize"><b>UINT64 fragmentSize</b></param>
	int EnqueueFileFragmentDownloadRequest (ulong fileOffset, ulong fragmentSize);
}

/// <summary>
/// Instance of <b>IDWriteFontFaceReference</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontFaceReference : IFontFaceReference {
//unsafe public readonly struct IFontFaceReferenceObj : IFontFaceReference {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFaceReference* GetCurrentPointer () => (FontFaceReference*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFaceReferenceObj* GetCurrentPointer () => (IFontFaceReferenceObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x5e7fa7ca, 0xdde3, 0x424c, 0x89, 0xf0, 0x9f, 0xcd, 0x6f, 0xed, 0x58, 0xcd);

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
	public readonly int CreateFontFace<T0> (T0** fontFace) where T0 : unmanaged, IFontFace3 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace<T0> (out T0* fontFace) where T0 : unmanaged, IFontFace3 {
		fixed (T0** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace (ptr, (void**) _fontFace);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceWithSimulations<T0> (FontSimulations fontFaceSimulationFlags, T0** fontFace) where T0 : unmanaged, IFontFace3 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceWithSimulations (ptr, fontFaceSimulationFlags, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFaceWithSimulations<T0> (FontSimulations fontFaceSimulationFlags, out T0* fontFace) where T0 : unmanaged, IFontFace3 {
		fixed (T0** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFaceWithSimulations (ptr, fontFaceSimulationFlags, (void**) _fontFace);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool Equals<T0> (T0* fontFaceReference) where T0 : unmanaged, IFontFaceReference {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->_Equals (ptr, fontFaceReference) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontFaceIndex () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFaceIndex (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly FontSimulations GetSimulations () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSimulations (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFile<T0> (T0** fontFile) where T0 : unmanaged, IFontFile {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFile (ptr, (void**) fontFile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontFile<T0> (out T0* fontFile) where T0 : unmanaged, IFontFile {
		fixed (T0** _fontFile = &fontFile) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFontFile (ptr, (void**) _fontFile);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetLocalFileSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocalFileSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetFileSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFileSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileTime (FileTime* lastWriteTime) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFileTime (ptr, lastWriteTime);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFileTime (out FileTime lastWriteTime) {
		fixed (FileTime* _lastWriteTime = &lastWriteTime) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetFileTime (ptr, _lastWriteTime);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly Locality GetLocality () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetLocality (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnqueueFontDownloadRequest () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnqueueFontDownloadRequest (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnqueueCharacterDownloadRequest (char* characters, uint characterCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnqueueCharacterDownloadRequest (ptr, characters, characterCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnqueueGlyphDownloadRequest (ushort* glyphIndices, uint glyphCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnqueueGlyphDownloadRequest (ptr, glyphIndices, glyphCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int EnqueueFileFragmentDownloadRequest (ulong fileOffset, ulong fragmentSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->EnqueueFileFragmentDownloadRequest (ptr, fileOffset, fragmentSize);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontFace;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontSimulations, void**, int> CreateFontFaceWithSimulations;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint> _Equals;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontFaceIndex;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontSimulations> GetSimulations;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetFontFile;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetLocalFileSize;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetFileSize;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FileTime*, int> GetFileTime;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Locality> GetLocality;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> EnqueueFontDownloadRequest;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, uint, int> EnqueueCharacterDownloadRequest;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ushort*, uint, int> EnqueueGlyphDownloadRequest;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, int> EnqueueFileFragmentDownloadRequest;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
