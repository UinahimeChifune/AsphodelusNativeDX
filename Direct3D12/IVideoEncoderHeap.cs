using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12VideoEncoderHeap</b> : ID3D12Pageable<br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public interface IVideoEncoderHeap : IPageable {
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D12VideoEncoderHeap::GetNodeMask ()</b><br/>
	/// </summary>
	uint GetNodeMask ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_VIDEO_ENCODER_HEAP_FLAGS ID3D12VideoEncoderHeap::GetEncoderHeapFlags ()</b><br/>
	/// </summary>
	VideoEncoderHeapFlags GetEncoderHeapFlags ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>D3D12_VIDEO_ENCODER_CODEC ID3D12VideoEncoderHeap::GetCodec ()</b><br/>
	/// </summary>
	VideoEncoderCodec GetCodec ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoEncoderHeap::GetCodecProfile (D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile)</b><br/>
	/// </summary>
	/// <param name="dstProfile">_Inout_ <b>D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile</b></param>
	int GetCodecProfile (VideoEncoderProfileDesc dstProfile);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoEncoderHeap::GetCodecLevel (D3D12_VIDEO_ENCODER_LEVEL_SETTING dstLevel)</b><br/>
	/// </summary>
	/// <param name="dstLevel">_Inout_ <b>D3D12_VIDEO_ENCODER_LEVEL_SETTING dstLevel</b></param>
	int GetCodecLevel (VideoEncoderLevelSetting dstLevel);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D12VideoEncoderHeap::GetResolutionListCount ()</b><br/>
	/// </summary>
	uint GetResolutionListCount ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12VideoEncoderHeap::GetResolutionList (UINT ResolutionsListCount, D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList)</b><br/>
	/// </summary>
	/// <param name="resolutionsListCount"><b>UINT ResolutionsListCount</b></param>
	/// <param name="pResolutionList">_Out_writes_(ResolutionsListCount) <b>D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList</b></param>
	int GetResolutionList (uint resolutionsListCount, VideoEncoderPictureResolutionDesc* pResolutionList);
}

/// <summary>
/// Instance of <b>ID3D12VideoEncoderHeap</b><br/>
/// D3D12VIDEO.h
/// </summary>
unsafe public readonly struct VideoEncoderHeap : IVideoEncoderHeap {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly VideoEncoderHeap* GetCurrentPointer () => (VideoEncoderHeap*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x22b35d96, 0x876a, 0x44c0, 0xb2, 0x5e, 0xfb, 0x8c, 0x9c, 0x7f, 0x1c, 0x4a);

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
	public readonly int GetPrivateData (Guid guid, uint* pDataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetPrivateData (ptr, guid, pDataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateData (Guid guid, uint dataSize, void* pData) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateData (ptr, guid, dataSize, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPrivateDataInterface<T0> (Guid guid, T0* pData) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPrivateDataInterface (ptr, guid, pData);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetName (char* name) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetName (ptr, name);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDevice (Guid riid, void** ppvDevice) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, ppvDevice);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetDevice (Guid riid, out void* ppvDevice) {
		fixed (void** _ppvDevice = &ppvDevice) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetDevice (ptr, riid, _ppvDevice);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetNodeMask () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNodeMask (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly VideoEncoderHeapFlags GetEncoderHeapFlags () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetEncoderHeapFlags (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly VideoEncoderCodec GetCodec () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCodec (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCodecProfile (VideoEncoderProfileDesc dstProfile) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCodecProfile (ptr, dstProfile);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetCodecLevel (VideoEncoderLevelSetting dstLevel) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetCodecLevel (ptr, dstLevel);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetResolutionListCount () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetResolutionListCount (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetResolutionList (uint resolutionsListCount, VideoEncoderPictureResolutionDesc* pResolutionList) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetResolutionList (ptr, resolutionsListCount, pResolutionList);
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
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint*, void*, int> GetPrivateData;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void*, int> SetPrivateData;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void*, int> SetPrivateDataInterface;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, int> SetName;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> GetDevice;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetNodeMask;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoEncoderHeapFlags> GetEncoderHeapFlags;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoEncoderCodec> GetCodec;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoEncoderProfileDesc, int> GetCodecProfile;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, VideoEncoderLevelSetting, int> GetCodecLevel;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetResolutionListCount;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, VideoEncoderPictureResolutionDesc*, int> GetResolutionList;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
