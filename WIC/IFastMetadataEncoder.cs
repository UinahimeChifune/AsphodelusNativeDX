using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.WIC;

/// <summary>
/// INTERFACE <b>IWICFastMetadataEncoder</b> : IUnknown<br/>
/// WINCODEC.h
/// </summary>
unsafe public interface IFastMetadataEncoder : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICFastMetadataEncoder::Commit ()</b><br/>
	/// </summary>
	int Commit ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICFastMetadataEncoder::GetMetadataQueryWriter (IWICMetadataQueryWriter** ppIMetadataQueryWriter)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIMetadataQueryWriter</b></param>
	int GetMetadataQueryWriter<T0> (T0** ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IWICFastMetadataEncoder::GetMetadataQueryWriter (IWICMetadataQueryWriter** ppIMetadataQueryWriter)</b><br/>
	/// </summary>
	/// <param name="ppIMetadataQueryWriter">__RPC__deref_out_opt <b>IWICMetadataQueryWriter** ppIMetadataQueryWriter</b></param>
	int GetMetadataQueryWriter<T0> (out T0* ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter;
}

/// <summary>
/// Instance of <b>IWICFastMetadataEncoder</b><br/>
/// WINCODEC.h
/// </summary>
unsafe public readonly struct FastMetadataEncoder : IFastMetadataEncoder {
//unsafe public readonly struct IFastMetadataEncoderObj : IFastMetadataEncoder {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly FastMetadataEncoder* GetCurrentPointer () => (FastMetadataEncoder*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IFastMetadataEncoderObj* GetCurrentPointer () => (IFastMetadataEncoderObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xb84e2c09, 0x78c9, 0x4ac4, 0x8b, 0xd3, 0x52, 0x4a, 0xe1, 0x66, 0x3a, 0x2f);

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
	public readonly int Commit () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Commit (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataQueryWriter<T0> (T0** ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryWriter (ptr, (void**) ppIMetadataQueryWriter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMetadataQueryWriter<T0> (out T0* ppIMetadataQueryWriter) where T0 : unmanaged, IMetadataQueryWriter {
		fixed (T0** _ppIMetadataQueryWriter = &ppIMetadataQueryWriter) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetMetadataQueryWriter (ptr, (void**) _ppIMetadataQueryWriter);
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
		public readonly delegate* unmanaged[Stdcall]<void*, int> Commit;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> GetMetadataQueryWriter;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
