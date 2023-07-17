using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// INTERFACE <b>IDWriteFontFaceReference1</b> : IDWriteFontFaceReference<br/>
/// DWRITE_3.h
/// </summary>
unsafe public interface IFontFaceReference1 : IFontFaceReference {
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference1::CreateFontFace (IDWriteFontFace5** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace5** fontFace</b></param>
	int CreateFontFace5<T0> (T0** fontFace) where T0 : unmanaged, IFontFace5;
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference1::CreateFontFace (IDWriteFontFace5** fontFace)</b><br/>
	/// </summary>
	/// <param name="fontFace">_COM_Outptr_ <b>IDWriteFontFace5** fontFace</b></param>
	int CreateFontFace5<T0> (out T0* fontFace) where T0 : unmanaged, IFontFace5;
	/// <summary>
	/// STDMETHOD_ <b>UINT32 IDWriteFontFaceReference1::GetFontAxisValueCount ()</b><br/>
	/// </summary>
	uint GetFontAxisValueCount ();
	/// <summary>
	/// STDMETHOD <b>HRESULT IDWriteFontFaceReference1::GetFontAxisValues (DWRITE_FONT_AXIS_VALUE* fontAxisValues, UINT32 fontAxisValueCount)</b><br/>
	/// </summary>
	/// <param name="fontAxisValues">_Out_writes_(fontAxisValueCount) <b>DWRITE_FONT_AXIS_VALUE* fontAxisValues</b></param>
	/// <param name="fontAxisValueCount"><b>UINT32 fontAxisValueCount</b></param>
	int GetFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount);
}

/// <summary>
/// Instance of <b>IDWriteFontFaceReference1</b><br/>
/// DWRITE_3.h
/// </summary>
unsafe public readonly struct FontFaceReference1 : IFontFaceReference1 {
//unsafe public readonly struct IFontFaceReference1Obj : IFontFaceReference1 {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FontFaceReference1* GetCurrentPointer () => (FontFaceReference1*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFontFaceReference1Obj* GetCurrentPointer () => (IFontFaceReference1Obj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc081fe77, 0x2fd1, 0x41ac, 0xa5, 0xa3, 0x34, 0x98, 0x3c, 0x4b, 0xa6, 0x1a);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace5<T0> (T0** fontFace) where T0 : unmanaged, IFontFace5 {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace5 (ptr, (void**) fontFace);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CreateFontFace5<T0> (out T0* fontFace) where T0 : unmanaged, IFontFace5 {
		fixed (T0** _fontFace = &fontFace) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->CreateFontFace5 (ptr, (void**) _fontFace);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetFontAxisValueCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisValueCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetFontAxisValues (FontAxisValue* fontAxisValues, uint fontAxisValueCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetFontAxisValues (ptr, fontAxisValues, fontAxisValueCount);
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
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> CreateFontFace5;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetFontAxisValueCount;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, FontAxisValue*, uint, int> GetFontAxisValues;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
