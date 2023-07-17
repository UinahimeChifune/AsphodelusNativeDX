using System;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DirectWrite;

/// <summary>
/// 
/// </summary>
unsafe public static partial class API {

	[LibraryImport ("DWRITE.dll")]
	private static partial int DWriteCreateFactory (FactoryType factoryType, Guid iid, void** factory);

	/// <summary>
	/// DWRITE_EXPORT <b>HRESULT DWriteCreateFactory (DWRITE_FACTORY_TYPE factoryType, REFIID iid, IUnknown **factory)</b><br/>
	/// DWRITE.h<br/>
	/// DWRITE.dll
	/// </summary>
	/// <param name="factoryType">_In_ <b>DWRITE_FACTORY_TYPE factoryType</b></param>
	/// <param name="factory">_COM_Outptr_ <b>IUnknown **factory</b></param>
	public static int CreateFactory<T0> (FactoryType factoryType, T0** factory) where T0 : unmanaged, IFactory {
		var hr = DWriteCreateFactory (factoryType, T0.GUID, (void**) factory);
		return hr;
	}

	/// <summary>
	/// DWRITE_EXPORT <b>HRESULT DWriteCreateFactory (DWRITE_FACTORY_TYPE factoryType, REFIID iid, IUnknown **factory)</b><br/>
	/// DWRITE.h<br/>
	/// DWRITE.dll
	/// </summary>
	/// <param name="factoryType">_In_ <b>DWRITE_FACTORY_TYPE factoryType</b></param>
	/// <param name="factory">_COM_Outptr_ <b>IUnknown **factory</b></param>
	public static int CreateFactory<T0> (FactoryType factoryType, out T0* factory) where T0 : unmanaged, IFactory {
		fixed (T0** _factory = &factory) {
			var hr = DWriteCreateFactory (factoryType, T0.GUID, (void**) _factory);
			return hr;
		}
	}
}
