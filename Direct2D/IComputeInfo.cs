using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1ComputeInfo</b> : ID2D1RenderInfo<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IComputeInfo : IRenderInfo {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ComputeInfo::SetComputeShaderConstantBuffer (BYTE* buffer, UINT32 bufferCount)</b><br/>
	/// </summary>
	/// <param name="buffer">_In_reads_(bufferCount) <b>BYTE* buffer</b></param>
	/// <param name="bufferCount"><b>UINT32 bufferCount</b></param>
	int SetComputeShaderConstantBuffer (byte* buffer, uint bufferCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ComputeInfo::SetComputeShader (REFGUID shaderId)</b><br/>
	/// </summary>
	/// <param name="shaderId">_In_ <b>REFGUID shaderId</b></param>
	int SetComputeShader (Guid shaderId);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1ComputeInfo::SetResourceTexture (UINT32 textureIndex, ID2D1ResourceTexture* resourceTexture)</b><br/>
	/// </summary>
	/// <param name="textureIndex"><b>UINT32 textureIndex</b></param>
	/// <param name="resourceTexture">_In_ <b>ID2D1ResourceTexture* resourceTexture</b></param>
	int SetResourceTexture<T0> (uint textureIndex, T0* resourceTexture) where T0 : unmanaged, IResourceTexture;
}

/// <summary>
/// Instance of <b>ID2D1ComputeInfo</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct ComputeInfo : IComputeInfo {
//unsafe public readonly struct IComputeInfoObj : IComputeInfo {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly ComputeInfo* GetCurrentPointer () => (ComputeInfo*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IComputeInfoObj* GetCurrentPointer () => (IComputeInfoObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x5598b14b, 0x9fd7, 0x48b7, 0x9b, 0xdb, 0x8f, 0x09, 0x64, 0xeb, 0x38, 0xbc);

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
	public readonly int SetInputDescription (uint inputIndex, InputDescription inputDescription) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetInputDescription (ptr, inputIndex, inputDescription);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetOutputBuffer (BufferPrecision bufferPrecision, ChannelDepth channelDepth) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetOutputBuffer (ptr, bufferPrecision, channelDepth);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetCached (bool isCached) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetCached (ptr, isCached ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetInstructionCountHint (uint instructionCount) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetInstructionCountHint (ptr, instructionCount);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetComputeShaderConstantBuffer (byte* buffer, uint bufferCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetComputeShaderConstantBuffer (ptr, buffer, bufferCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetComputeShader (Guid shaderId) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetComputeShader (ptr, shaderId);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetResourceTexture<T0> (uint textureIndex, T0* resourceTexture) where T0 : unmanaged, IResourceTexture {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetResourceTexture (ptr, textureIndex, resourceTexture);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, InputDescription, int> SetInputDescription;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, BufferPrecision, ChannelDepth, int> SetOutputBuffer;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetCached;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetInstructionCountHint;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, byte*, uint, int> SetComputeShaderConstantBuffer;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> SetComputeShader;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, int> SetResourceTexture;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
