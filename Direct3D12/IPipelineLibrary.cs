using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12PipelineLibrary</b> : ID3D12DeviceChild<br/>
/// D3D12.h
/// </summary>
unsafe public interface IPipelineLibrary : IDeviceChild {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12PipelineLibrary::StorePipeline (LPCWSTR pName, ID3D12PipelineState* pPipeline)</b><br/>
	/// </summary>
	/// <param name="pName">_In_opt_ <b>LPCWSTR pName</b></param>
	/// <param name="pPipeline">_In_ <b>ID3D12PipelineState* pPipeline</b></param>
	int StorePipeline<T0> (char* pName, T0* pPipeline) where T0 : unmanaged, IPipelineState;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12PipelineLibrary::LoadGraphicsPipeline (LPCWSTR pName, D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pName">_In_ <b>LPCWSTR pName</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int LoadGraphicsPipeline (char* pName, GraphicsPipelineStateDesc* pDesc, Guid riid, void** ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12PipelineLibrary::LoadGraphicsPipeline (LPCWSTR pName, D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pName">_In_ <b>LPCWSTR pName</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int LoadGraphicsPipeline (char* pName, GraphicsPipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12PipelineLibrary::LoadComputePipeline (LPCWSTR pName, D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pName">_In_ <b>LPCWSTR pName</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int LoadComputePipeline (char* pName, ComputePipelineStateDesc* pDesc, Guid riid, void** ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12PipelineLibrary::LoadComputePipeline (LPCWSTR pName, D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, REFIID riid, void** ppPipelineState)</b><br/>
	/// </summary>
	/// <param name="pName">_In_ <b>LPCWSTR pName</b></param>
	/// <param name="pDesc">_In_ <b>D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc</b></param>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppPipelineState">_COM_Outptr_ <b>void** ppPipelineState</b></param>
	int LoadComputePipeline (char* pName, ComputePipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState);
	/// <summary>
	/// STDMETHODCALLTYPE <b>SIZE_T ID3D12PipelineLibrary::GetSerializedSize ()</b><br/>
	/// </summary>
	nuint GetSerializedSize ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12PipelineLibrary::Serialize (void* pData, SIZE_T DataSizeInBytes)</b><br/>
	/// </summary>
	/// <param name="pData">_Out_writes_(DataSizeInBytes) <b>void* pData</b></param>
	/// <param name="dataSizeInBytes"><b>SIZE_T DataSizeInBytes</b></param>
	int Serialize (void* pData, nuint dataSizeInBytes);
}

/// <summary>
/// Instance of <b>ID3D12PipelineLibrary</b><br/>
/// D3D12.h
/// </summary>
unsafe public readonly struct PipelineLibrary : IPipelineLibrary {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PipelineLibrary* GetCurrentPointer () => (PipelineLibrary*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xc64226a8, 0x9201, 0x46af, 0xb4, 0xcc, 0x53, 0xfb, 0x9f, 0xf7, 0x41, 0x4f);

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
	public readonly int StorePipeline<T0> (char* pName, T0* pPipeline) where T0 : unmanaged, IPipelineState {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->StorePipeline (ptr, pName, pPipeline);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadGraphicsPipeline (char* pName, GraphicsPipelineStateDesc* pDesc, Guid riid, void** ppPipelineState) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LoadGraphicsPipeline (ptr, pName, pDesc, riid, ppPipelineState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadGraphicsPipeline (char* pName, GraphicsPipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState) {
		fixed (void** _ppPipelineState = &ppPipelineState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->LoadGraphicsPipeline (ptr, pName, pDesc, riid, _ppPipelineState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadComputePipeline (char* pName, ComputePipelineStateDesc* pDesc, Guid riid, void** ppPipelineState) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LoadComputePipeline (ptr, pName, pDesc, riid, ppPipelineState);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LoadComputePipeline (char* pName, ComputePipelineStateDesc* pDesc, Guid riid, out void* ppPipelineState) {
		fixed (void** _ppPipelineState = &ppPipelineState) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->LoadComputePipeline (ptr, pName, pDesc, riid, _ppPipelineState);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly nuint GetSerializedSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSerializedSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Serialize (void* pData, nuint dataSizeInBytes) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Serialize (ptr, pData, dataSizeInBytes);
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
		public readonly delegate* unmanaged[Stdcall]<void*, char*, void*, int> StorePipeline;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, GraphicsPipelineStateDesc*, Guid, void**, int> LoadGraphicsPipeline;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, char*, ComputePipelineStateDesc*, Guid, void**, int> LoadComputePipeline;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, nuint> GetSerializedSize;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, nuint, int> Serialize;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
