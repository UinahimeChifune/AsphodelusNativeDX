using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D;

/// <summary>
/// STRUCTURE <b>_D3D_SHADER_MACRO</b> (D3D_SHADER_MACRO)<br/>
/// D3DCOMMON.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct ShaderMacro {

	/// <summary>
	/// <b>LPCSTR Name</b>
	/// </summary>
	public readonly char* Name {
		get => _name;
		init => _name = value;
	}
	readonly char* _name;

	/// <summary>
	/// <b>LPCSTR Definition</b>
	/// </summary>
	public readonly char* Definition {
		get => _definition;
		init => _definition = value;
	}
	readonly char* _definition;

}

/// <summary>
/// CALLBACK <b>PFN_DESTRUCTION_CALLBACK</b><br/>
/// D3DCOMMON.h
/// </summary>
unsafe public delegate void Destruction (void* pData);
