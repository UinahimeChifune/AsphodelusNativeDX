using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// INTERFACE <b>ID2D1DrawInfo</b> : ID2D1RenderInfo<br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public interface IDrawInfo : IRenderInfo {
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DrawInfo::SetPixelShaderConstantBuffer (BYTE* buffer, UINT32 bufferCount)</b><br/>
	/// </summary>
	/// <param name="buffer">_In_reads_(bufferCount) <b>BYTE* buffer</b></param>
	/// <param name="bufferCount"><b>UINT32 bufferCount</b></param>
	int SetPixelShaderConstantBuffer (byte* buffer, uint bufferCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DrawInfo::SetResourceTexture (UINT32 textureIndex, ID2D1ResourceTexture* resourceTexture)</b><br/>
	/// </summary>
	/// <param name="textureIndex"><b>UINT32 textureIndex</b></param>
	/// <param name="resourceTexture">_In_ <b>ID2D1ResourceTexture* resourceTexture</b></param>
	int SetResourceTexture<T0> (uint textureIndex, T0* resourceTexture) where T0 : unmanaged, IResourceTexture;
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DrawInfo::SetVertexShaderConstantBuffer (BYTE* buffer, UINT32 bufferCount)</b><br/>
	/// </summary>
	/// <param name="buffer">_In_reads_(bufferCount) <b>BYTE* buffer</b></param>
	/// <param name="bufferCount"><b>UINT32 bufferCount</b></param>
	int SetVertexShaderConstantBuffer (byte* buffer, uint bufferCount);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DrawInfo::SetPixelShader (REFGUID shaderId, D2D1_PIXEL_OPTIONS pixelOptions)</b><br/>
	/// </summary>
	/// <param name="shaderId">_In_ <b>REFGUID shaderId</b></param>
	/// <param name="pixelOptions"><b>D2D1_PIXEL_OPTIONS pixelOptions</b></param>
	int SetPixelShader (Guid shaderId, PixelOptions pixelOptions);
	/// <summary>
	/// STDMETHOD <b>HRESULT ID2D1DrawInfo::SetVertexProcessing (ID2D1VertexBuffer* vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, D2D1_BLEND_DESCRIPTION* blendDescription, D2D1_VERTEX_RANGE* vertexRange, GUID* vertexShader)</b><br/>
	/// </summary>
	/// <param name="vertexBuffer">_In_opt_ <b>ID2D1VertexBuffer* vertexBuffer</b></param>
	/// <param name="vertexOptions"><b>D2D1_VERTEX_OPTIONS vertexOptions</b></param>
	/// <param name="blendDescription">_In_opt_ <b>D2D1_BLEND_DESCRIPTION* blendDescription</b></param>
	/// <param name="vertexRange">_In_opt_ <b>D2D1_VERTEX_RANGE* vertexRange</b></param>
	/// <param name="vertexShader">_In_opt_ <b>GUID* vertexShader</b></param>
	int SetVertexProcessing<T0> (T0* vertexBuffer, VertexOptions vertexOptions, BlendDescription* blendDescription, VertexRange* vertexRange, Guid* vertexShader) where T0 : unmanaged, IVertexBuffer;
}

/// <summary>
/// Instance of <b>ID2D1DrawInfo</b><br/>
/// D2D1EFFECTAUTHOR.h
/// </summary>
unsafe public readonly struct DrawInfo : IDrawInfo {
//unsafe public readonly struct IDrawInfoObj : IDrawInfo {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly DrawInfo* GetCurrentPointer () => (DrawInfo*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IDrawInfoObj* GetCurrentPointer () => (IDrawInfoObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x693ce632, 0x7f2f, 0x45de, 0x93, 0xfe, 0x18, 0xd8, 0x8b, 0x37, 0xaa, 0x21);

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
	public readonly int SetPixelShaderConstantBuffer (byte* buffer, uint bufferCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPixelShaderConstantBuffer (ptr, buffer, bufferCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetResourceTexture<T0> (uint textureIndex, T0* resourceTexture) where T0 : unmanaged, IResourceTexture {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetResourceTexture (ptr, textureIndex, resourceTexture);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetVertexShaderConstantBuffer (byte* buffer, uint bufferCount) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetVertexShaderConstantBuffer (ptr, buffer, bufferCount);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetPixelShader (Guid shaderId, PixelOptions pixelOptions) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetPixelShader (ptr, shaderId, pixelOptions);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetVertexProcessing<T0> (T0* vertexBuffer, VertexOptions vertexOptions, BlendDescription* blendDescription, VertexRange* vertexRange, Guid* vertexShader) where T0 : unmanaged, IVertexBuffer {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetVertexProcessing (ptr, vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
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
		public readonly delegate* unmanaged[Stdcall]<void*, byte*, uint, int> SetPixelShaderConstantBuffer;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void*, int> SetResourceTexture;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, byte*, uint, int> SetVertexShaderConstantBuffer;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, PixelOptions, int> SetPixelShader;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int> SetVertexProcessing;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
