namespace AsphodelusNative.Direct3D;

/// <summary>
/// ENUM <b>D3D_DRIVER_TYPE</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum DriverType : uint {
	/// <summary>
	/// <b>D3D_DRIVER_TYPE_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D_DRIVER_TYPE_HARDWARE</b> = ( D3D_DRIVER_TYPE_UNKNOWN + 1 )
	/// </summary>
	Hardware = Unknown + 1,
	/// <summary>
	/// <b>D3D_DRIVER_TYPE_REFERENCE</b> = ( D3D_DRIVER_TYPE_HARDWARE + 1 )
	/// </summary>
	Reference = Hardware + 1,
	/// <summary>
	/// <b>D3D_DRIVER_TYPE_NULL</b> = ( D3D_DRIVER_TYPE_REFERENCE + 1 )
	/// </summary>
	Null = Reference + 1,
	/// <summary>
	/// <b>D3D_DRIVER_TYPE_SOFTWARE</b> = ( D3D_DRIVER_TYPE_NULL + 1 )
	/// </summary>
	Software = Null + 1,
	/// <summary>
	/// <b>D3D_DRIVER_TYPE_WARP</b> = ( D3D_DRIVER_TYPE_SOFTWARE + 1 )
	/// </summary>
	Warp = Software + 1,
}

/// <summary>
/// ENUM <b>D3D_FEATURE_LEVEL</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum FeatureLevel : uint {
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_1_0_CORE</b> = 0x1000
	/// </summary>
	Level10Core = 4096,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_9_1</b> = 0x9100
	/// </summary>
	Level91 = 37120,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_9_2</b> = 0x9200
	/// </summary>
	Level92 = 37376,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_9_3</b> = 0x9300
	/// </summary>
	Level93 = 37632,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_10_0</b> = 0xa000
	/// </summary>
	Level100 = 40960,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_10_1</b> = 0xa100
	/// </summary>
	Level101 = 41216,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_11_0</b> = 0xb000
	/// </summary>
	Level110 = 45056,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_11_1</b> = 0xb100
	/// </summary>
	Level111 = 45312,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_12_0</b> = 0xc000
	/// </summary>
	Level120 = 49152,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_12_1</b> = 0xc100
	/// </summary>
	Level121 = 49408,
	/// <summary>
	/// <b>D3D_FEATURE_LEVEL_12_2</b> = 0xc200
	/// </summary>
	Level122 = 49664,
}

/// <summary>
/// ENUM <b>D3D_PRIMITIVE_TOPOLOGY</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum PrimitiveTopology : uint {
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_POINTLIST</b> = 1
	/// </summary>
	Pointlist = 1,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_LINELIST</b> = 2
	/// </summary>
	Linelist = 2,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP</b> = 3
	/// </summary>
	Linestrip = 3,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST</b> = 4
	/// </summary>
	Trianglelist = 4,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP</b> = 5
	/// </summary>
	Trianglestrip = 5,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ</b> = 10
	/// </summary>
	LinelistAdj = 10,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ</b> = 11
	/// </summary>
	LinestripAdj = 11,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ</b> = 12
	/// </summary>
	TrianglelistAdj = 12,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ</b> = 13
	/// </summary>
	TrianglestripAdj = 13,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST</b> = 33
	/// </summary>
	Topology1ControlPointPatchlist = 33,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST</b> = 34
	/// </summary>
	Topology2ControlPointPatchlist = 34,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST</b> = 35
	/// </summary>
	Topology3ControlPointPatchlist = 35,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST</b> = 36
	/// </summary>
	Topology4ControlPointPatchlist = 36,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST</b> = 37
	/// </summary>
	Topology5ControlPointPatchlist = 37,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST</b> = 38
	/// </summary>
	Topology6ControlPointPatchlist = 38,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST</b> = 39
	/// </summary>
	Topology7ControlPointPatchlist = 39,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST</b> = 40
	/// </summary>
	Topology8ControlPointPatchlist = 40,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST</b> = 41
	/// </summary>
	Topology9ControlPointPatchlist = 41,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST</b> = 42
	/// </summary>
	Topology10ControlPointPatchlist = 42,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST</b> = 43
	/// </summary>
	Topology11ControlPointPatchlist = 43,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST</b> = 44
	/// </summary>
	Topology12ControlPointPatchlist = 44,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST</b> = 45
	/// </summary>
	Topology13ControlPointPatchlist = 45,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST</b> = 46
	/// </summary>
	Topology14ControlPointPatchlist = 46,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST</b> = 47
	/// </summary>
	Topology15ControlPointPatchlist = 47,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST</b> = 48
	/// </summary>
	Topology16ControlPointPatchlist = 48,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST</b> = 49
	/// </summary>
	Topology17ControlPointPatchlist = 49,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST</b> = 50
	/// </summary>
	Topology18ControlPointPatchlist = 50,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST</b> = 51
	/// </summary>
	Topology19ControlPointPatchlist = 51,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST</b> = 52
	/// </summary>
	Topology20ControlPointPatchlist = 52,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST</b> = 53
	/// </summary>
	Topology21ControlPointPatchlist = 53,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST</b> = 54
	/// </summary>
	Topology22ControlPointPatchlist = 54,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST</b> = 55
	/// </summary>
	Topology23ControlPointPatchlist = 55,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST</b> = 56
	/// </summary>
	Topology24ControlPointPatchlist = 56,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST</b> = 57
	/// </summary>
	Topology25ControlPointPatchlist = 57,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST</b> = 58
	/// </summary>
	Topology26ControlPointPatchlist = 58,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST</b> = 59
	/// </summary>
	Topology27ControlPointPatchlist = 59,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST</b> = 60
	/// </summary>
	Topology28ControlPointPatchlist = 60,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST</b> = 61
	/// </summary>
	Topology29ControlPointPatchlist = 61,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST</b> = 62
	/// </summary>
	Topology30ControlPointPatchlist = 62,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST</b> = 63
	/// </summary>
	Topology31ControlPointPatchlist = 63,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST</b> = 64
	/// </summary>
	Topology32ControlPointPatchlist = 64,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_UNDEFINED</b> = D3D_PRIMITIVE_TOPOLOGY_UNDEFINED
	/// </summary>
	D3D10Undefined = Undefined,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_POINTLIST</b> = D3D_PRIMITIVE_TOPOLOGY_POINTLIST
	/// </summary>
	D3D10Pointlist = Pointlist,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_LINELIST</b> = D3D_PRIMITIVE_TOPOLOGY_LINELIST
	/// </summary>
	D3D10Linelist = Linelist,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP</b> = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP
	/// </summary>
	D3D10Linestrip = Linestrip,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST
	/// </summary>
	D3D10Trianglelist = Trianglelist,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP
	/// </summary>
	D3D10Trianglestrip = Trianglestrip,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_LINELIST_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ
	/// </summary>
	D3D10LinelistAdj = LinelistAdj,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ
	/// </summary>
	D3D10LinestripAdj = LinestripAdj,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ
	/// </summary>
	D3D10TrianglelistAdj = TrianglelistAdj,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ
	/// </summary>
	D3D10TrianglestripAdj = TrianglestripAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_UNDEFINED</b> = D3D_PRIMITIVE_TOPOLOGY_UNDEFINED
	/// </summary>
	D3D11Undefined = Undefined,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_POINTLIST</b> = D3D_PRIMITIVE_TOPOLOGY_POINTLIST
	/// </summary>
	D3D11Pointlist = Pointlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_LINELIST</b> = D3D_PRIMITIVE_TOPOLOGY_LINELIST
	/// </summary>
	D3D11Linelist = Linelist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP</b> = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP
	/// </summary>
	D3D11Linestrip = Linestrip,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST
	/// </summary>
	D3D11Trianglelist = Trianglelist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP
	/// </summary>
	D3D11Trianglestrip = Trianglestrip,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ
	/// </summary>
	D3D11LinelistAdj = LinelistAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ
	/// </summary>
	D3D11LinestripAdj = LinestripAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ
	/// </summary>
	D3D11TrianglelistAdj = TrianglelistAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ</b> = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ
	/// </summary>
	D3D11TrianglestripAdj = TrianglestripAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology1ControlPointPatchlist = Topology1ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology2ControlPointPatchlist = Topology2ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology3ControlPointPatchlist = Topology3ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology4ControlPointPatchlist = Topology4ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology5ControlPointPatchlist = Topology5ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology6ControlPointPatchlist = Topology6ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology7ControlPointPatchlist = Topology7ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology8ControlPointPatchlist = Topology8ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology9ControlPointPatchlist = Topology9ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology10ControlPointPatchlist = Topology10ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology11ControlPointPatchlist = Topology11ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology12ControlPointPatchlist = Topology12ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology13ControlPointPatchlist = Topology13ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology14ControlPointPatchlist = Topology14ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology15ControlPointPatchlist = Topology15ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology16ControlPointPatchlist = Topology16ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology17ControlPointPatchlist = Topology17ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology18ControlPointPatchlist = Topology18ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology19ControlPointPatchlist = Topology19ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology20ControlPointPatchlist = Topology20ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology21ControlPointPatchlist = Topology21ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology22ControlPointPatchlist = Topology22ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology23ControlPointPatchlist = Topology23ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology24ControlPointPatchlist = Topology24ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology25ControlPointPatchlist = Topology25ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology26ControlPointPatchlist = Topology26ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology27ControlPointPatchlist = Topology27ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology28ControlPointPatchlist = Topology28ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology29ControlPointPatchlist = Topology29ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology30ControlPointPatchlist = Topology30ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology31ControlPointPatchlist = Topology31ControlPointPatchlist,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST</b> = D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST
	/// </summary>
	D3D11Topology32ControlPointPatchlist = Topology32ControlPointPatchlist,
}

/// <summary>
/// ENUM <b>D3D_PRIMITIVE</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum Primitive : uint {
	/// <summary>
	/// <b>D3D_PRIMITIVE_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D_PRIMITIVE_POINT</b> = 1
	/// </summary>
	Point = 1,
	/// <summary>
	/// <b>D3D_PRIMITIVE_LINE</b> = 2
	/// </summary>
	Line = 2,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TRIANGLE</b> = 3
	/// </summary>
	Triangle = 3,
	/// <summary>
	/// <b>D3D_PRIMITIVE_LINE_ADJ</b> = 6
	/// </summary>
	LineAdj = 6,
	/// <summary>
	/// <b>D3D_PRIMITIVE_TRIANGLE_ADJ</b> = 7
	/// </summary>
	TriangleAdj = 7,
	/// <summary>
	/// <b>D3D_PRIMITIVE_1_CONTROL_POINT_PATCH</b> = 8
	/// </summary>
	Primitive1ControlPointPatch = 8,
	/// <summary>
	/// <b>D3D_PRIMITIVE_2_CONTROL_POINT_PATCH</b> = 9
	/// </summary>
	Primitive2ControlPointPatch = 9,
	/// <summary>
	/// <b>D3D_PRIMITIVE_3_CONTROL_POINT_PATCH</b> = 10
	/// </summary>
	Primitive3ControlPointPatch = 10,
	/// <summary>
	/// <b>D3D_PRIMITIVE_4_CONTROL_POINT_PATCH</b> = 11
	/// </summary>
	Primitive4ControlPointPatch = 11,
	/// <summary>
	/// <b>D3D_PRIMITIVE_5_CONTROL_POINT_PATCH</b> = 12
	/// </summary>
	Primitive5ControlPointPatch = 12,
	/// <summary>
	/// <b>D3D_PRIMITIVE_6_CONTROL_POINT_PATCH</b> = 13
	/// </summary>
	Primitive6ControlPointPatch = 13,
	/// <summary>
	/// <b>D3D_PRIMITIVE_7_CONTROL_POINT_PATCH</b> = 14
	/// </summary>
	Primitive7ControlPointPatch = 14,
	/// <summary>
	/// <b>D3D_PRIMITIVE_8_CONTROL_POINT_PATCH</b> = 15
	/// </summary>
	Primitive8ControlPointPatch = 15,
	/// <summary>
	/// <b>D3D_PRIMITIVE_9_CONTROL_POINT_PATCH</b> = 16
	/// </summary>
	Primitive9ControlPointPatch = 16,
	/// <summary>
	/// <b>D3D_PRIMITIVE_10_CONTROL_POINT_PATCH</b> = 17
	/// </summary>
	Primitive10ControlPointPatch = 17,
	/// <summary>
	/// <b>D3D_PRIMITIVE_11_CONTROL_POINT_PATCH</b> = 18
	/// </summary>
	Primitive11ControlPointPatch = 18,
	/// <summary>
	/// <b>D3D_PRIMITIVE_12_CONTROL_POINT_PATCH</b> = 19
	/// </summary>
	Primitive12ControlPointPatch = 19,
	/// <summary>
	/// <b>D3D_PRIMITIVE_13_CONTROL_POINT_PATCH</b> = 20
	/// </summary>
	Primitive13ControlPointPatch = 20,
	/// <summary>
	/// <b>D3D_PRIMITIVE_14_CONTROL_POINT_PATCH</b> = 21
	/// </summary>
	Primitive14ControlPointPatch = 21,
	/// <summary>
	/// <b>D3D_PRIMITIVE_15_CONTROL_POINT_PATCH</b> = 22
	/// </summary>
	Primitive15ControlPointPatch = 22,
	/// <summary>
	/// <b>D3D_PRIMITIVE_16_CONTROL_POINT_PATCH</b> = 23
	/// </summary>
	Primitive16ControlPointPatch = 23,
	/// <summary>
	/// <b>D3D_PRIMITIVE_17_CONTROL_POINT_PATCH</b> = 24
	/// </summary>
	Primitive17ControlPointPatch = 24,
	/// <summary>
	/// <b>D3D_PRIMITIVE_18_CONTROL_POINT_PATCH</b> = 25
	/// </summary>
	Primitive18ControlPointPatch = 25,
	/// <summary>
	/// <b>D3D_PRIMITIVE_19_CONTROL_POINT_PATCH</b> = 26
	/// </summary>
	Primitive19ControlPointPatch = 26,
	/// <summary>
	/// <b>D3D_PRIMITIVE_20_CONTROL_POINT_PATCH</b> = 27
	/// </summary>
	Primitive20ControlPointPatch = 27,
	/// <summary>
	/// <b>D3D_PRIMITIVE_21_CONTROL_POINT_PATCH</b> = 28
	/// </summary>
	Primitive21ControlPointPatch = 28,
	/// <summary>
	/// <b>D3D_PRIMITIVE_22_CONTROL_POINT_PATCH</b> = 29
	/// </summary>
	Primitive22ControlPointPatch = 29,
	/// <summary>
	/// <b>D3D_PRIMITIVE_23_CONTROL_POINT_PATCH</b> = 30
	/// </summary>
	Primitive23ControlPointPatch = 30,
	/// <summary>
	/// <b>D3D_PRIMITIVE_24_CONTROL_POINT_PATCH</b> = 31
	/// </summary>
	Primitive24ControlPointPatch = 31,
	/// <summary>
	/// <b>D3D_PRIMITIVE_25_CONTROL_POINT_PATCH</b> = 32
	/// </summary>
	Primitive25ControlPointPatch = 32,
	/// <summary>
	/// <b>D3D_PRIMITIVE_26_CONTROL_POINT_PATCH</b> = 33
	/// </summary>
	Primitive26ControlPointPatch = 33,
	/// <summary>
	/// <b>D3D_PRIMITIVE_27_CONTROL_POINT_PATCH</b> = 34
	/// </summary>
	Primitive27ControlPointPatch = 34,
	/// <summary>
	/// <b>D3D_PRIMITIVE_28_CONTROL_POINT_PATCH</b> = 35
	/// </summary>
	Primitive28ControlPointPatch = 35,
	/// <summary>
	/// <b>D3D_PRIMITIVE_29_CONTROL_POINT_PATCH</b> = 36
	/// </summary>
	Primitive29ControlPointPatch = 36,
	/// <summary>
	/// <b>D3D_PRIMITIVE_30_CONTROL_POINT_PATCH</b> = 37
	/// </summary>
	Primitive30ControlPointPatch = 37,
	/// <summary>
	/// <b>D3D_PRIMITIVE_31_CONTROL_POINT_PATCH</b> = 38
	/// </summary>
	Primitive31ControlPointPatch = 38,
	/// <summary>
	/// <b>D3D_PRIMITIVE_32_CONTROL_POINT_PATCH</b> = 39
	/// </summary>
	Primitive32ControlPointPatch = 39,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_UNDEFINED</b> = D3D_PRIMITIVE_UNDEFINED
	/// </summary>
	D3D10Undefined = Undefined,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_POINT</b> = D3D_PRIMITIVE_POINT
	/// </summary>
	D3D10Point = Point,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_LINE</b> = D3D_PRIMITIVE_LINE
	/// </summary>
	D3D10Line = Line,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TRIANGLE</b> = D3D_PRIMITIVE_TRIANGLE
	/// </summary>
	D3D10Triangle = Triangle,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_LINE_ADJ</b> = D3D_PRIMITIVE_LINE_ADJ
	/// </summary>
	D3D10LineAdj = LineAdj,
	/// <summary>
	/// <b>D3D10_PRIMITIVE_TRIANGLE_ADJ</b> = D3D_PRIMITIVE_TRIANGLE_ADJ
	/// </summary>
	D3D10TriangleAdj = TriangleAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_UNDEFINED</b> = D3D_PRIMITIVE_UNDEFINED
	/// </summary>
	D3D11Undefined = Undefined,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_POINT</b> = D3D_PRIMITIVE_POINT
	/// </summary>
	D3D11Point = Point,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_LINE</b> = D3D_PRIMITIVE_LINE
	/// </summary>
	D3D11Line = Line,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TRIANGLE</b> = D3D_PRIMITIVE_TRIANGLE
	/// </summary>
	D3D11Triangle = Triangle,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_LINE_ADJ</b> = D3D_PRIMITIVE_LINE_ADJ
	/// </summary>
	D3D11LineAdj = LineAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_TRIANGLE_ADJ</b> = D3D_PRIMITIVE_TRIANGLE_ADJ
	/// </summary>
	D3D11TriangleAdj = TriangleAdj,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_1_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_1_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive1ControlPointPatch = Primitive1ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_2_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_2_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive2ControlPointPatch = Primitive2ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_3_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_3_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive3ControlPointPatch = Primitive3ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_4_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_4_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive4ControlPointPatch = Primitive4ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_5_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_5_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive5ControlPointPatch = Primitive5ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_6_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_6_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive6ControlPointPatch = Primitive6ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_7_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_7_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive7ControlPointPatch = Primitive7ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_8_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_8_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive8ControlPointPatch = Primitive8ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_9_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_9_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive9ControlPointPatch = Primitive9ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_10_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_10_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive10ControlPointPatch = Primitive10ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_11_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_11_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive11ControlPointPatch = Primitive11ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_12_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_12_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive12ControlPointPatch = Primitive12ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_13_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_13_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive13ControlPointPatch = Primitive13ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_14_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_14_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive14ControlPointPatch = Primitive14ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_15_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_15_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive15ControlPointPatch = Primitive15ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_16_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_16_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive16ControlPointPatch = Primitive16ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_17_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_17_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive17ControlPointPatch = Primitive17ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_18_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_18_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive18ControlPointPatch = Primitive18ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_19_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_19_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive19ControlPointPatch = Primitive19ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_20_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_20_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive20ControlPointPatch = Primitive20ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_21_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_21_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive21ControlPointPatch = Primitive21ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_22_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_22_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive22ControlPointPatch = Primitive22ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_23_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_23_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive23ControlPointPatch = Primitive23ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_24_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_24_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive24ControlPointPatch = Primitive24ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_25_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_25_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive25ControlPointPatch = Primitive25ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_26_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_26_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive26ControlPointPatch = Primitive26ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_27_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_27_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive27ControlPointPatch = Primitive27ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_28_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_28_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive28ControlPointPatch = Primitive28ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_29_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_29_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive29ControlPointPatch = Primitive29ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_30_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_30_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive30ControlPointPatch = Primitive30ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_31_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_31_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive31ControlPointPatch = Primitive31ControlPointPatch,
	/// <summary>
	/// <b>D3D11_PRIMITIVE_32_CONTROL_POINT_PATCH</b> = D3D_PRIMITIVE_32_CONTROL_POINT_PATCH
	/// </summary>
	D3D11Primitive32ControlPointPatch = Primitive32ControlPointPatch,
}

/// <summary>
/// ENUM <b>D3D_SRV_DIMENSION</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum SrvDimension : uint {
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_BUFFER</b> = 1
	/// </summary>
	Buffer = 1,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURE1D</b> = 2
	/// </summary>
	Texture1d = 2,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURE1DARRAY</b> = 3
	/// </summary>
	Texture1darray = 3,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURE2D</b> = 4
	/// </summary>
	Texture2d = 4,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURE2DARRAY</b> = 5
	/// </summary>
	Texture2darray = 5,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURE2DMS</b> = 6
	/// </summary>
	Texture2dms = 6,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURE2DMSARRAY</b> = 7
	/// </summary>
	Texture2dmsarray = 7,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURE3D</b> = 8
	/// </summary>
	Texture3d = 8,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURECUBE</b> = 9
	/// </summary>
	Texturecube = 9,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_TEXTURECUBEARRAY</b> = 10
	/// </summary>
	Texturecubearray = 10,
	/// <summary>
	/// <b>D3D_SRV_DIMENSION_BUFFEREX</b> = 11
	/// </summary>
	Bufferex = 11,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_UNKNOWN</b> = D3D_SRV_DIMENSION_UNKNOWN
	/// </summary>
	D3D10Unknown = Unknown,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_BUFFER</b> = D3D_SRV_DIMENSION_BUFFER
	/// </summary>
	D3D10Buffer = Buffer,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURE1D</b> = D3D_SRV_DIMENSION_TEXTURE1D
	/// </summary>
	D3D10Texture1d = Texture1d,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURE1DARRAY</b> = D3D_SRV_DIMENSION_TEXTURE1DARRAY
	/// </summary>
	D3D10Texture1darray = Texture1darray,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURE2D</b> = D3D_SRV_DIMENSION_TEXTURE2D
	/// </summary>
	D3D10Texture2d = Texture2d,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURE2DARRAY</b> = D3D_SRV_DIMENSION_TEXTURE2DARRAY
	/// </summary>
	D3D10Texture2darray = Texture2darray,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURE2DMS</b> = D3D_SRV_DIMENSION_TEXTURE2DMS
	/// </summary>
	D3D10Texture2dms = Texture2dms,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY</b> = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY
	/// </summary>
	D3D10Texture2dmsarray = Texture2dmsarray,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURE3D</b> = D3D_SRV_DIMENSION_TEXTURE3D
	/// </summary>
	D3D10Texture3d = Texture3d,
	/// <summary>
	/// <b>D3D10_SRV_DIMENSION_TEXTURECUBE</b> = D3D_SRV_DIMENSION_TEXTURECUBE
	/// </summary>
	D3D10Texturecube = Texturecube,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_UNKNOWN</b> = D3D_SRV_DIMENSION_UNKNOWN
	/// </summary>
	D3D101SrvDimensionUnknown = Unknown,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_BUFFER</b> = D3D_SRV_DIMENSION_BUFFER
	/// </summary>
	D3D101SrvDimensionBuffer = Buffer,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURE1D</b> = D3D_SRV_DIMENSION_TEXTURE1D
	/// </summary>
	D3D101SrvDimensionTexture1d = Texture1d,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY</b> = D3D_SRV_DIMENSION_TEXTURE1DARRAY
	/// </summary>
	D3D101SrvDimensionTexture1darray = Texture1darray,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURE2D</b> = D3D_SRV_DIMENSION_TEXTURE2D
	/// </summary>
	D3D101SrvDimensionTexture2d = Texture2d,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY</b> = D3D_SRV_DIMENSION_TEXTURE2DARRAY
	/// </summary>
	D3D101SrvDimensionTexture2darray = Texture2darray,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURE2DMS</b> = D3D_SRV_DIMENSION_TEXTURE2DMS
	/// </summary>
	D3D101SrvDimensionTexture2dms = Texture2dms,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY</b> = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY
	/// </summary>
	D3D101SrvDimensionTexture2dmsarray = Texture2dmsarray,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURE3D</b> = D3D_SRV_DIMENSION_TEXTURE3D
	/// </summary>
	D3D101SrvDimensionTexture3d = Texture3d,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURECUBE</b> = D3D_SRV_DIMENSION_TEXTURECUBE
	/// </summary>
	D3D101SrvDimensionTexturecube = Texturecube,
	/// <summary>
	/// <b>D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY</b> = D3D_SRV_DIMENSION_TEXTURECUBEARRAY
	/// </summary>
	D3D101SrvDimensionTexturecubearray = Texturecubearray,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_UNKNOWN</b> = D3D_SRV_DIMENSION_UNKNOWN
	/// </summary>
	D3D11Unknown = Unknown,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_BUFFER</b> = D3D_SRV_DIMENSION_BUFFER
	/// </summary>
	D3D11Buffer = Buffer,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURE1D</b> = D3D_SRV_DIMENSION_TEXTURE1D
	/// </summary>
	D3D11Texture1d = Texture1d,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURE1DARRAY</b> = D3D_SRV_DIMENSION_TEXTURE1DARRAY
	/// </summary>
	D3D11Texture1darray = Texture1darray,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURE2D</b> = D3D_SRV_DIMENSION_TEXTURE2D
	/// </summary>
	D3D11Texture2d = Texture2d,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURE2DARRAY</b> = D3D_SRV_DIMENSION_TEXTURE2DARRAY
	/// </summary>
	D3D11Texture2darray = Texture2darray,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURE2DMS</b> = D3D_SRV_DIMENSION_TEXTURE2DMS
	/// </summary>
	D3D11Texture2dms = Texture2dms,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY</b> = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY
	/// </summary>
	D3D11Texture2dmsarray = Texture2dmsarray,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURE3D</b> = D3D_SRV_DIMENSION_TEXTURE3D
	/// </summary>
	D3D11Texture3d = Texture3d,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURECUBE</b> = D3D_SRV_DIMENSION_TEXTURECUBE
	/// </summary>
	D3D11Texturecube = Texturecube,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_TEXTURECUBEARRAY</b> = D3D_SRV_DIMENSION_TEXTURECUBEARRAY
	/// </summary>
	D3D11Texturecubearray = Texturecubearray,
	/// <summary>
	/// <b>D3D11_SRV_DIMENSION_BUFFEREX</b> = D3D_SRV_DIMENSION_BUFFEREX
	/// </summary>
	D3D11Bufferex = Bufferex,
}

/// <summary>
/// ENUM <b>_D3D_INCLUDE_TYPE</b> (D3D_INCLUDE_TYPE)<br/>
/// D3DCOMMON.h
/// </summary>
public enum IncludeType : uint {
	/// <summary>
	/// <b>D3D_INCLUDE_LOCAL</b> = 0
	/// </summary>
	Local = 0,
	/// <summary>
	/// <b>D3D_INCLUDE_SYSTEM</b> = ( D3D_INCLUDE_LOCAL + 1 )
	/// </summary>
	System = Local + 1,
	/// <summary>
	/// <b>D3D10_INCLUDE_LOCAL</b> = D3D_INCLUDE_LOCAL
	/// </summary>
	D3D10Local = Local,
	/// <summary>
	/// <b>D3D10_INCLUDE_SYSTEM</b> = D3D_INCLUDE_SYSTEM
	/// </summary>
	D3D10System = System,
}

/// <summary>
/// ENUM <b>_D3D_SHADER_VARIABLE_CLASS</b> (D3D_SHADER_VARIABLE_CLASS)<br/>
/// D3DCOMMON.h
/// </summary>
public enum ShaderVariableClass : uint {
	/// <summary>
	/// <b>D3D_SVC_SCALAR</b> = 0
	/// </summary>
	SvcScalar = 0,
	/// <summary>
	/// <b>D3D_SVC_VECTOR</b> = ( D3D_SVC_SCALAR + 1 )
	/// </summary>
	SvcVector = SvcScalar + 1,
	/// <summary>
	/// <b>D3D_SVC_MATRIX_ROWS</b> = ( D3D_SVC_VECTOR + 1 )
	/// </summary>
	SvcMatrixRows = SvcVector + 1,
	/// <summary>
	/// <b>D3D_SVC_MATRIX_COLUMNS</b> = ( D3D_SVC_MATRIX_ROWS + 1 )
	/// </summary>
	SvcMatrixColumns = SvcMatrixRows + 1,
	/// <summary>
	/// <b>D3D_SVC_OBJECT</b> = ( D3D_SVC_MATRIX_COLUMNS + 1 )
	/// </summary>
	SvcObject = SvcMatrixColumns + 1,
	/// <summary>
	/// <b>D3D_SVC_STRUCT</b> = ( D3D_SVC_OBJECT + 1 )
	/// </summary>
	SvcStruct = SvcObject + 1,
	/// <summary>
	/// <b>D3D_SVC_INTERFACE_CLASS</b> = ( D3D_SVC_STRUCT + 1 )
	/// </summary>
	SvcInterfaceClass = SvcStruct + 1,
	/// <summary>
	/// <b>D3D_SVC_INTERFACE_POINTER</b> = ( D3D_SVC_INTERFACE_CLASS + 1 )
	/// </summary>
	SvcInterfacePointer = SvcInterfaceClass + 1,
	/// <summary>
	/// <b>D3D10_SVC_SCALAR</b> = D3D_SVC_SCALAR
	/// </summary>
	D3D10SvcScalar = SvcScalar,
	/// <summary>
	/// <b>D3D10_SVC_VECTOR</b> = D3D_SVC_VECTOR
	/// </summary>
	D3D10SvcVector = SvcVector,
	/// <summary>
	/// <b>D3D10_SVC_MATRIX_ROWS</b> = D3D_SVC_MATRIX_ROWS
	/// </summary>
	D3D10SvcMatrixRows = SvcMatrixRows,
	/// <summary>
	/// <b>D3D10_SVC_MATRIX_COLUMNS</b> = D3D_SVC_MATRIX_COLUMNS
	/// </summary>
	D3D10SvcMatrixColumns = SvcMatrixColumns,
	/// <summary>
	/// <b>D3D10_SVC_OBJECT</b> = D3D_SVC_OBJECT
	/// </summary>
	D3D10SvcObject = SvcObject,
	/// <summary>
	/// <b>D3D10_SVC_STRUCT</b> = D3D_SVC_STRUCT
	/// </summary>
	D3D10SvcStruct = SvcStruct,
	/// <summary>
	/// <b>D3D11_SVC_INTERFACE_CLASS</b> = D3D_SVC_INTERFACE_CLASS
	/// </summary>
	D3D11SvcInterfaceClass = SvcInterfaceClass,
	/// <summary>
	/// <b>D3D11_SVC_INTERFACE_POINTER</b> = D3D_SVC_INTERFACE_POINTER
	/// </summary>
	D3D11SvcInterfacePointer = SvcInterfacePointer,
}

/// <summary>
/// ENUM <b>_D3D_SHADER_VARIABLE_FLAGS</b> (D3D_SHADER_VARIABLE_FLAGS)<br/>
/// D3DCOMMON.h
/// </summary>
public enum ShaderVariableFlags : uint {
	/// <summary>
	/// <b>D3D_SVF_USERPACKED</b> = 1
	/// </summary>
	SvfUserpacked = 1,
	/// <summary>
	/// <b>D3D_SVF_USED</b> = 2
	/// </summary>
	SvfUsed = 2,
	/// <summary>
	/// <b>D3D_SVF_INTERFACE_POINTER</b> = 4
	/// </summary>
	SvfInterfacePointer = 4,
	/// <summary>
	/// <b>D3D_SVF_INTERFACE_PARAMETER</b> = 8
	/// </summary>
	SvfInterfaceParameter = 8,
	/// <summary>
	/// <b>D3D10_SVF_USERPACKED</b> = D3D_SVF_USERPACKED
	/// </summary>
	D3D10SvfUserpacked = SvfUserpacked,
	/// <summary>
	/// <b>D3D10_SVF_USED</b> = D3D_SVF_USED
	/// </summary>
	D3D10SvfUsed = SvfUsed,
	/// <summary>
	/// <b>D3D11_SVF_INTERFACE_POINTER</b> = D3D_SVF_INTERFACE_POINTER
	/// </summary>
	D3D11SvfInterfacePointer = SvfInterfacePointer,
	/// <summary>
	/// <b>D3D11_SVF_INTERFACE_PARAMETER</b> = D3D_SVF_INTERFACE_PARAMETER
	/// </summary>
	D3D11SvfInterfaceParameter = SvfInterfaceParameter,
}

/// <summary>
/// ENUM <b>_D3D_SHADER_VARIABLE_TYPE</b> (D3D_SHADER_VARIABLE_TYPE)<br/>
/// D3DCOMMON.h
/// </summary>
public enum ShaderVariableType : uint {
	/// <summary>
	/// <b>D3D_SVT_VOID</b> = 0
	/// </summary>
	SvtVoid = 0,
	/// <summary>
	/// <b>D3D_SVT_BOOL</b> = 1
	/// </summary>
	SvtBool = 1,
	/// <summary>
	/// <b>D3D_SVT_INT</b> = 2
	/// </summary>
	SvtInt = 2,
	/// <summary>
	/// <b>D3D_SVT_FLOAT</b> = 3
	/// </summary>
	SvtFloat = 3,
	/// <summary>
	/// <b>D3D_SVT_STRING</b> = 4
	/// </summary>
	SvtString = 4,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE</b> = 5
	/// </summary>
	SvtTexture = 5,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE1D</b> = 6
	/// </summary>
	SvtTexture1d = 6,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE2D</b> = 7
	/// </summary>
	SvtTexture2d = 7,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE3D</b> = 8
	/// </summary>
	SvtTexture3d = 8,
	/// <summary>
	/// <b>D3D_SVT_TEXTURECUBE</b> = 9
	/// </summary>
	SvtTexturecube = 9,
	/// <summary>
	/// <b>D3D_SVT_SAMPLER</b> = 10
	/// </summary>
	SvtSampler = 10,
	/// <summary>
	/// <b>D3D_SVT_SAMPLER1D</b> = 11
	/// </summary>
	SvtSampler1d = 11,
	/// <summary>
	/// <b>D3D_SVT_SAMPLER2D</b> = 12
	/// </summary>
	SvtSampler2d = 12,
	/// <summary>
	/// <b>D3D_SVT_SAMPLER3D</b> = 13
	/// </summary>
	SvtSampler3d = 13,
	/// <summary>
	/// <b>D3D_SVT_SAMPLERCUBE</b> = 14
	/// </summary>
	SvtSamplercube = 14,
	/// <summary>
	/// <b>D3D_SVT_PIXELSHADER</b> = 15
	/// </summary>
	SvtPixelshader = 15,
	/// <summary>
	/// <b>D3D_SVT_VERTEXSHADER</b> = 16
	/// </summary>
	SvtVertexshader = 16,
	/// <summary>
	/// <b>D3D_SVT_PIXELFRAGMENT</b> = 17
	/// </summary>
	SvtPixelfragment = 17,
	/// <summary>
	/// <b>D3D_SVT_VERTEXFRAGMENT</b> = 18
	/// </summary>
	SvtVertexfragment = 18,
	/// <summary>
	/// <b>D3D_SVT_UINT</b> = 19
	/// </summary>
	SvtUint = 19,
	/// <summary>
	/// <b>D3D_SVT_UINT8</b> = 20
	/// </summary>
	SvtUint8 = 20,
	/// <summary>
	/// <b>D3D_SVT_GEOMETRYSHADER</b> = 21
	/// </summary>
	SvtGeometryshader = 21,
	/// <summary>
	/// <b>D3D_SVT_RASTERIZER</b> = 22
	/// </summary>
	SvtRasterizer = 22,
	/// <summary>
	/// <b>D3D_SVT_DEPTHSTENCIL</b> = 23
	/// </summary>
	SvtDepthstencil = 23,
	/// <summary>
	/// <b>D3D_SVT_BLEND</b> = 24
	/// </summary>
	SvtBlend = 24,
	/// <summary>
	/// <b>D3D_SVT_BUFFER</b> = 25
	/// </summary>
	SvtBuffer = 25,
	/// <summary>
	/// <b>D3D_SVT_CBUFFER</b> = 26
	/// </summary>
	SvtCbuffer = 26,
	/// <summary>
	/// <b>D3D_SVT_TBUFFER</b> = 27
	/// </summary>
	SvtTbuffer = 27,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE1DARRAY</b> = 28
	/// </summary>
	SvtTexture1darray = 28,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE2DARRAY</b> = 29
	/// </summary>
	SvtTexture2darray = 29,
	/// <summary>
	/// <b>D3D_SVT_RENDERTARGETVIEW</b> = 30
	/// </summary>
	SvtRendertargetview = 30,
	/// <summary>
	/// <b>D3D_SVT_DEPTHSTENCILVIEW</b> = 31
	/// </summary>
	SvtDepthstencilview = 31,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE2DMS</b> = 32
	/// </summary>
	SvtTexture2dms = 32,
	/// <summary>
	/// <b>D3D_SVT_TEXTURE2DMSARRAY</b> = 33
	/// </summary>
	SvtTexture2dmsarray = 33,
	/// <summary>
	/// <b>D3D_SVT_TEXTURECUBEARRAY</b> = 34
	/// </summary>
	SvtTexturecubearray = 34,
	/// <summary>
	/// <b>D3D_SVT_HULLSHADER</b> = 35
	/// </summary>
	SvtHullshader = 35,
	/// <summary>
	/// <b>D3D_SVT_DOMAINSHADER</b> = 36
	/// </summary>
	SvtDomainshader = 36,
	/// <summary>
	/// <b>D3D_SVT_INTERFACE_POINTER</b> = 37
	/// </summary>
	SvtInterfacePointer = 37,
	/// <summary>
	/// <b>D3D_SVT_COMPUTESHADER</b> = 38
	/// </summary>
	SvtComputeshader = 38,
	/// <summary>
	/// <b>D3D_SVT_DOUBLE</b> = 39
	/// </summary>
	SvtDouble = 39,
	/// <summary>
	/// <b>D3D_SVT_RWTEXTURE1D</b> = 40
	/// </summary>
	SvtRwtexture1d = 40,
	/// <summary>
	/// <b>D3D_SVT_RWTEXTURE1DARRAY</b> = 41
	/// </summary>
	SvtRwtexture1darray = 41,
	/// <summary>
	/// <b>D3D_SVT_RWTEXTURE2D</b> = 42
	/// </summary>
	SvtRwtexture2d = 42,
	/// <summary>
	/// <b>D3D_SVT_RWTEXTURE2DARRAY</b> = 43
	/// </summary>
	SvtRwtexture2darray = 43,
	/// <summary>
	/// <b>D3D_SVT_RWTEXTURE3D</b> = 44
	/// </summary>
	SvtRwtexture3d = 44,
	/// <summary>
	/// <b>D3D_SVT_RWBUFFER</b> = 45
	/// </summary>
	SvtRwbuffer = 45,
	/// <summary>
	/// <b>D3D_SVT_BYTEADDRESS_BUFFER</b> = 46
	/// </summary>
	SvtByteaddressBuffer = 46,
	/// <summary>
	/// <b>D3D_SVT_RWBYTEADDRESS_BUFFER</b> = 47
	/// </summary>
	SvtRwbyteaddressBuffer = 47,
	/// <summary>
	/// <b>D3D_SVT_STRUCTURED_BUFFER</b> = 48
	/// </summary>
	SvtStructuredBuffer = 48,
	/// <summary>
	/// <b>D3D_SVT_RWSTRUCTURED_BUFFER</b> = 49
	/// </summary>
	SvtRwstructuredBuffer = 49,
	/// <summary>
	/// <b>D3D_SVT_APPEND_STRUCTURED_BUFFER</b> = 50
	/// </summary>
	SvtAppendStructuredBuffer = 50,
	/// <summary>
	/// <b>D3D_SVT_CONSUME_STRUCTURED_BUFFER</b> = 51
	/// </summary>
	SvtConsumeStructuredBuffer = 51,
	/// <summary>
	/// <b>D3D_SVT_MIN8FLOAT</b> = 52
	/// </summary>
	SvtMin8float = 52,
	/// <summary>
	/// <b>D3D_SVT_MIN10FLOAT</b> = 53
	/// </summary>
	SvtMin10float = 53,
	/// <summary>
	/// <b>D3D_SVT_MIN16FLOAT</b> = 54
	/// </summary>
	SvtMin16float = 54,
	/// <summary>
	/// <b>D3D_SVT_MIN12INT</b> = 55
	/// </summary>
	SvtMin12int = 55,
	/// <summary>
	/// <b>D3D_SVT_MIN16INT</b> = 56
	/// </summary>
	SvtMin16int = 56,
	/// <summary>
	/// <b>D3D_SVT_MIN16UINT</b> = 57
	/// </summary>
	SvtMin16uint = 57,
	/// <summary>
	/// <b>D3D_SVT_INT16</b> = 58
	/// </summary>
	SvtInt16 = 58,
	/// <summary>
	/// <b>D3D_SVT_UINT16</b> = 59
	/// </summary>
	SvtUint16 = 59,
	/// <summary>
	/// <b>D3D_SVT_FLOAT16</b> = 60
	/// </summary>
	SvtFloat16 = 60,
	/// <summary>
	/// <b>D3D_SVT_INT64</b> = 61
	/// </summary>
	SvtInt64 = 61,
	/// <summary>
	/// <b>D3D_SVT_UINT64</b> = 62
	/// </summary>
	SvtUint64 = 62,
	/// <summary>
	/// <b>D3D10_SVT_VOID</b> = D3D_SVT_VOID
	/// </summary>
	D3D10SvtVoid = SvtVoid,
	/// <summary>
	/// <b>D3D10_SVT_BOOL</b> = D3D_SVT_BOOL
	/// </summary>
	D3D10SvtBool = SvtBool,
	/// <summary>
	/// <b>D3D10_SVT_INT</b> = D3D_SVT_INT
	/// </summary>
	D3D10SvtInt = SvtInt,
	/// <summary>
	/// <b>D3D10_SVT_FLOAT</b> = D3D_SVT_FLOAT
	/// </summary>
	D3D10SvtFloat = SvtFloat,
	/// <summary>
	/// <b>D3D10_SVT_STRING</b> = D3D_SVT_STRING
	/// </summary>
	D3D10SvtString = SvtString,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE</b> = D3D_SVT_TEXTURE
	/// </summary>
	D3D10SvtTexture = SvtTexture,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE1D</b> = D3D_SVT_TEXTURE1D
	/// </summary>
	D3D10SvtTexture1d = SvtTexture1d,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE2D</b> = D3D_SVT_TEXTURE2D
	/// </summary>
	D3D10SvtTexture2d = SvtTexture2d,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE3D</b> = D3D_SVT_TEXTURE3D
	/// </summary>
	D3D10SvtTexture3d = SvtTexture3d,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURECUBE</b> = D3D_SVT_TEXTURECUBE
	/// </summary>
	D3D10SvtTexturecube = SvtTexturecube,
	/// <summary>
	/// <b>D3D10_SVT_SAMPLER</b> = D3D_SVT_SAMPLER
	/// </summary>
	D3D10SvtSampler = SvtSampler,
	/// <summary>
	/// <b>D3D10_SVT_SAMPLER1D</b> = D3D_SVT_SAMPLER1D
	/// </summary>
	D3D10SvtSampler1d = SvtSampler1d,
	/// <summary>
	/// <b>D3D10_SVT_SAMPLER2D</b> = D3D_SVT_SAMPLER2D
	/// </summary>
	D3D10SvtSampler2d = SvtSampler2d,
	/// <summary>
	/// <b>D3D10_SVT_SAMPLER3D</b> = D3D_SVT_SAMPLER3D
	/// </summary>
	D3D10SvtSampler3d = SvtSampler3d,
	/// <summary>
	/// <b>D3D10_SVT_SAMPLERCUBE</b> = D3D_SVT_SAMPLERCUBE
	/// </summary>
	D3D10SvtSamplercube = SvtSamplercube,
	/// <summary>
	/// <b>D3D10_SVT_PIXELSHADER</b> = D3D_SVT_PIXELSHADER
	/// </summary>
	D3D10SvtPixelshader = SvtPixelshader,
	/// <summary>
	/// <b>D3D10_SVT_VERTEXSHADER</b> = D3D_SVT_VERTEXSHADER
	/// </summary>
	D3D10SvtVertexshader = SvtVertexshader,
	/// <summary>
	/// <b>D3D10_SVT_PIXELFRAGMENT</b> = D3D_SVT_PIXELFRAGMENT
	/// </summary>
	D3D10SvtPixelfragment = SvtPixelfragment,
	/// <summary>
	/// <b>D3D10_SVT_VERTEXFRAGMENT</b> = D3D_SVT_VERTEXFRAGMENT
	/// </summary>
	D3D10SvtVertexfragment = SvtVertexfragment,
	/// <summary>
	/// <b>D3D10_SVT_UINT</b> = D3D_SVT_UINT
	/// </summary>
	D3D10SvtUint = SvtUint,
	/// <summary>
	/// <b>D3D10_SVT_UINT8</b> = D3D_SVT_UINT8
	/// </summary>
	D3D10SvtUint8 = SvtUint8,
	/// <summary>
	/// <b>D3D10_SVT_GEOMETRYSHADER</b> = D3D_SVT_GEOMETRYSHADER
	/// </summary>
	D3D10SvtGeometryshader = SvtGeometryshader,
	/// <summary>
	/// <b>D3D10_SVT_RASTERIZER</b> = D3D_SVT_RASTERIZER
	/// </summary>
	D3D10SvtRasterizer = SvtRasterizer,
	/// <summary>
	/// <b>D3D10_SVT_DEPTHSTENCIL</b> = D3D_SVT_DEPTHSTENCIL
	/// </summary>
	D3D10SvtDepthstencil = SvtDepthstencil,
	/// <summary>
	/// <b>D3D10_SVT_BLEND</b> = D3D_SVT_BLEND
	/// </summary>
	D3D10SvtBlend = SvtBlend,
	/// <summary>
	/// <b>D3D10_SVT_BUFFER</b> = D3D_SVT_BUFFER
	/// </summary>
	D3D10SvtBuffer = SvtBuffer,
	/// <summary>
	/// <b>D3D10_SVT_CBUFFER</b> = D3D_SVT_CBUFFER
	/// </summary>
	D3D10SvtCbuffer = SvtCbuffer,
	/// <summary>
	/// <b>D3D10_SVT_TBUFFER</b> = D3D_SVT_TBUFFER
	/// </summary>
	D3D10SvtTbuffer = SvtTbuffer,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE1DARRAY</b> = D3D_SVT_TEXTURE1DARRAY
	/// </summary>
	D3D10SvtTexture1darray = SvtTexture1darray,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE2DARRAY</b> = D3D_SVT_TEXTURE2DARRAY
	/// </summary>
	D3D10SvtTexture2darray = SvtTexture2darray,
	/// <summary>
	/// <b>D3D10_SVT_RENDERTARGETVIEW</b> = D3D_SVT_RENDERTARGETVIEW
	/// </summary>
	D3D10SvtRendertargetview = SvtRendertargetview,
	/// <summary>
	/// <b>D3D10_SVT_DEPTHSTENCILVIEW</b> = D3D_SVT_DEPTHSTENCILVIEW
	/// </summary>
	D3D10SvtDepthstencilview = SvtDepthstencilview,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE2DMS</b> = D3D_SVT_TEXTURE2DMS
	/// </summary>
	D3D10SvtTexture2dms = SvtTexture2dms,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURE2DMSARRAY</b> = D3D_SVT_TEXTURE2DMSARRAY
	/// </summary>
	D3D10SvtTexture2dmsarray = SvtTexture2dmsarray,
	/// <summary>
	/// <b>D3D10_SVT_TEXTURECUBEARRAY</b> = D3D_SVT_TEXTURECUBEARRAY
	/// </summary>
	D3D10SvtTexturecubearray = SvtTexturecubearray,
	/// <summary>
	/// <b>D3D11_SVT_HULLSHADER</b> = D3D_SVT_HULLSHADER
	/// </summary>
	D3D11SvtHullshader = SvtHullshader,
	/// <summary>
	/// <b>D3D11_SVT_DOMAINSHADER</b> = D3D_SVT_DOMAINSHADER
	/// </summary>
	D3D11SvtDomainshader = SvtDomainshader,
	/// <summary>
	/// <b>D3D11_SVT_INTERFACE_POINTER</b> = D3D_SVT_INTERFACE_POINTER
	/// </summary>
	D3D11SvtInterfacePointer = SvtInterfacePointer,
	/// <summary>
	/// <b>D3D11_SVT_COMPUTESHADER</b> = D3D_SVT_COMPUTESHADER
	/// </summary>
	D3D11SvtComputeshader = SvtComputeshader,
	/// <summary>
	/// <b>D3D11_SVT_DOUBLE</b> = D3D_SVT_DOUBLE
	/// </summary>
	D3D11SvtDouble = SvtDouble,
	/// <summary>
	/// <b>D3D11_SVT_RWTEXTURE1D</b> = D3D_SVT_RWTEXTURE1D
	/// </summary>
	D3D11SvtRwtexture1d = SvtRwtexture1d,
	/// <summary>
	/// <b>D3D11_SVT_RWTEXTURE1DARRAY</b> = D3D_SVT_RWTEXTURE1DARRAY
	/// </summary>
	D3D11SvtRwtexture1darray = SvtRwtexture1darray,
	/// <summary>
	/// <b>D3D11_SVT_RWTEXTURE2D</b> = D3D_SVT_RWTEXTURE2D
	/// </summary>
	D3D11SvtRwtexture2d = SvtRwtexture2d,
	/// <summary>
	/// <b>D3D11_SVT_RWTEXTURE2DARRAY</b> = D3D_SVT_RWTEXTURE2DARRAY
	/// </summary>
	D3D11SvtRwtexture2darray = SvtRwtexture2darray,
	/// <summary>
	/// <b>D3D11_SVT_RWTEXTURE3D</b> = D3D_SVT_RWTEXTURE3D
	/// </summary>
	D3D11SvtRwtexture3d = SvtRwtexture3d,
	/// <summary>
	/// <b>D3D11_SVT_RWBUFFER</b> = D3D_SVT_RWBUFFER
	/// </summary>
	D3D11SvtRwbuffer = SvtRwbuffer,
	/// <summary>
	/// <b>D3D11_SVT_BYTEADDRESS_BUFFER</b> = D3D_SVT_BYTEADDRESS_BUFFER
	/// </summary>
	D3D11SvtByteaddressBuffer = SvtByteaddressBuffer,
	/// <summary>
	/// <b>D3D11_SVT_RWBYTEADDRESS_BUFFER</b> = D3D_SVT_RWBYTEADDRESS_BUFFER
	/// </summary>
	D3D11SvtRwbyteaddressBuffer = SvtRwbyteaddressBuffer,
	/// <summary>
	/// <b>D3D11_SVT_STRUCTURED_BUFFER</b> = D3D_SVT_STRUCTURED_BUFFER
	/// </summary>
	D3D11SvtStructuredBuffer = SvtStructuredBuffer,
	/// <summary>
	/// <b>D3D11_SVT_RWSTRUCTURED_BUFFER</b> = D3D_SVT_RWSTRUCTURED_BUFFER
	/// </summary>
	D3D11SvtRwstructuredBuffer = SvtRwstructuredBuffer,
	/// <summary>
	/// <b>D3D11_SVT_APPEND_STRUCTURED_BUFFER</b> = D3D_SVT_APPEND_STRUCTURED_BUFFER
	/// </summary>
	D3D11SvtAppendStructuredBuffer = SvtAppendStructuredBuffer,
	/// <summary>
	/// <b>D3D11_SVT_CONSUME_STRUCTURED_BUFFER</b> = D3D_SVT_CONSUME_STRUCTURED_BUFFER
	/// </summary>
	D3D11SvtConsumeStructuredBuffer = SvtConsumeStructuredBuffer,
}

/// <summary>
/// ENUM <b>_D3D_SHADER_INPUT_FLAGS</b> (D3D_SHADER_INPUT_FLAGS)<br/>
/// D3DCOMMON.h
/// </summary>
public enum ShaderInputFlags : uint {
	/// <summary>
	/// <b>D3D_SIF_USERPACKED</b> = 0x1
	/// </summary>
	SifUserpacked = 1,
	/// <summary>
	/// <b>D3D_SIF_COMPARISON_SAMPLER</b> = 0x2
	/// </summary>
	SifComparisonSampler = 2,
	/// <summary>
	/// <b>D3D_SIF_TEXTURE_COMPONENT_0</b> = 0x4
	/// </summary>
	SifTextureComponent0 = 4,
	/// <summary>
	/// <b>D3D_SIF_TEXTURE_COMPONENT_1</b> = 0x8
	/// </summary>
	SifTextureComponent1 = 8,
	/// <summary>
	/// <b>D3D_SIF_TEXTURE_COMPONENTS</b> = 0xc
	/// </summary>
	SifTextureComponents = 12,
	/// <summary>
	/// <b>D3D_SIF_UNUSED</b> = 0x10
	/// </summary>
	SifUnused = 16,
	/// <summary>
	/// <b>D3D10_SIF_USERPACKED</b> = D3D_SIF_USERPACKED
	/// </summary>
	D3D10SifUserpacked = SifUserpacked,
	/// <summary>
	/// <b>D3D10_SIF_COMPARISON_SAMPLER</b> = D3D_SIF_COMPARISON_SAMPLER
	/// </summary>
	D3D10SifComparisonSampler = SifComparisonSampler,
	/// <summary>
	/// <b>D3D10_SIF_TEXTURE_COMPONENT_0</b> = D3D_SIF_TEXTURE_COMPONENT_0
	/// </summary>
	D3D10SifTextureComponent0 = SifTextureComponent0,
	/// <summary>
	/// <b>D3D10_SIF_TEXTURE_COMPONENT_1</b> = D3D_SIF_TEXTURE_COMPONENT_1
	/// </summary>
	D3D10SifTextureComponent1 = SifTextureComponent1,
	/// <summary>
	/// <b>D3D10_SIF_TEXTURE_COMPONENTS</b> = D3D_SIF_TEXTURE_COMPONENTS
	/// </summary>
	D3D10SifTextureComponents = SifTextureComponents,
}

/// <summary>
/// ENUM <b>_D3D_SHADER_INPUT_TYPE</b> (D3D_SHADER_INPUT_TYPE)<br/>
/// D3DCOMMON.h
/// </summary>
public enum ShaderInputType : uint {
	/// <summary>
	/// <b>D3D_SIT_CBUFFER</b> = 0
	/// </summary>
	SitCbuffer = 0,
	/// <summary>
	/// <b>D3D_SIT_TBUFFER</b> = ( D3D_SIT_CBUFFER + 1 )
	/// </summary>
	SitTbuffer = SitCbuffer + 1,
	/// <summary>
	/// <b>D3D_SIT_TEXTURE</b> = ( D3D_SIT_TBUFFER + 1 )
	/// </summary>
	SitTexture = SitTbuffer + 1,
	/// <summary>
	/// <b>D3D_SIT_SAMPLER</b> = ( D3D_SIT_TEXTURE + 1 )
	/// </summary>
	SitSampler = SitTexture + 1,
	/// <summary>
	/// <b>D3D_SIT_UAV_RWTYPED</b> = ( D3D_SIT_SAMPLER + 1 )
	/// </summary>
	SitUavRwtyped = SitSampler + 1,
	/// <summary>
	/// <b>D3D_SIT_STRUCTURED</b> = ( D3D_SIT_UAV_RWTYPED + 1 )
	/// </summary>
	SitStructured = SitUavRwtyped + 1,
	/// <summary>
	/// <b>D3D_SIT_UAV_RWSTRUCTURED</b> = ( D3D_SIT_STRUCTURED + 1 )
	/// </summary>
	SitUavRwstructured = SitStructured + 1,
	/// <summary>
	/// <b>D3D_SIT_BYTEADDRESS</b> = ( D3D_SIT_UAV_RWSTRUCTURED + 1 )
	/// </summary>
	SitByteaddress = SitUavRwstructured + 1,
	/// <summary>
	/// <b>D3D_SIT_UAV_RWBYTEADDRESS</b> = ( D3D_SIT_BYTEADDRESS + 1 )
	/// </summary>
	SitUavRwbyteaddress = SitByteaddress + 1,
	/// <summary>
	/// <b>D3D_SIT_UAV_APPEND_STRUCTURED</b> = ( D3D_SIT_UAV_RWBYTEADDRESS + 1 )
	/// </summary>
	SitUavAppendStructured = SitUavRwbyteaddress + 1,
	/// <summary>
	/// <b>D3D_SIT_UAV_CONSUME_STRUCTURED</b> = ( D3D_SIT_UAV_APPEND_STRUCTURED + 1 )
	/// </summary>
	SitUavConsumeStructured = SitUavAppendStructured + 1,
	/// <summary>
	/// <b>D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER</b> = ( D3D_SIT_UAV_CONSUME_STRUCTURED + 1 )
	/// </summary>
	SitUavRwstructuredWithCounter = SitUavConsumeStructured + 1,
	/// <summary>
	/// <b>D3D_SIT_RTACCELERATIONSTRUCTURE</b> = ( D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER + 1 )
	/// </summary>
	SitRtaccelerationstructure = SitUavRwstructuredWithCounter + 1,
	/// <summary>
	/// <b>D3D_SIT_UAV_FEEDBACKTEXTURE</b> = ( D3D_SIT_RTACCELERATIONSTRUCTURE + 1 )
	/// </summary>
	SitUavFeedbacktexture = SitRtaccelerationstructure + 1,
	/// <summary>
	/// <b>D3D10_SIT_CBUFFER</b> = D3D_SIT_CBUFFER
	/// </summary>
	D3D10SitCbuffer = SitCbuffer,
	/// <summary>
	/// <b>D3D10_SIT_TBUFFER</b> = D3D_SIT_TBUFFER
	/// </summary>
	D3D10SitTbuffer = SitTbuffer,
	/// <summary>
	/// <b>D3D10_SIT_TEXTURE</b> = D3D_SIT_TEXTURE
	/// </summary>
	D3D10SitTexture = SitTexture,
	/// <summary>
	/// <b>D3D10_SIT_SAMPLER</b> = D3D_SIT_SAMPLER
	/// </summary>
	D3D10SitSampler = SitSampler,
	/// <summary>
	/// <b>D3D11_SIT_UAV_RWTYPED</b> = D3D_SIT_UAV_RWTYPED
	/// </summary>
	D3D11SitUavRwtyped = SitUavRwtyped,
	/// <summary>
	/// <b>D3D11_SIT_STRUCTURED</b> = D3D_SIT_STRUCTURED
	/// </summary>
	D3D11SitStructured = SitStructured,
	/// <summary>
	/// <b>D3D11_SIT_UAV_RWSTRUCTURED</b> = D3D_SIT_UAV_RWSTRUCTURED
	/// </summary>
	D3D11SitUavRwstructured = SitUavRwstructured,
	/// <summary>
	/// <b>D3D11_SIT_BYTEADDRESS</b> = D3D_SIT_BYTEADDRESS
	/// </summary>
	D3D11SitByteaddress = SitByteaddress,
	/// <summary>
	/// <b>D3D11_SIT_UAV_RWBYTEADDRESS</b> = D3D_SIT_UAV_RWBYTEADDRESS
	/// </summary>
	D3D11SitUavRwbyteaddress = SitUavRwbyteaddress,
	/// <summary>
	/// <b>D3D11_SIT_UAV_APPEND_STRUCTURED</b> = D3D_SIT_UAV_APPEND_STRUCTURED
	/// </summary>
	D3D11SitUavAppendStructured = SitUavAppendStructured,
	/// <summary>
	/// <b>D3D11_SIT_UAV_CONSUME_STRUCTURED</b> = D3D_SIT_UAV_CONSUME_STRUCTURED
	/// </summary>
	D3D11SitUavConsumeStructured = SitUavConsumeStructured,
	/// <summary>
	/// <b>D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER</b> = D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER
	/// </summary>
	D3D11SitUavRwstructuredWithCounter = SitUavRwstructuredWithCounter,
}

/// <summary>
/// ENUM <b>_D3D_SHADER_CBUFFER_FLAGS</b> (D3D_SHADER_CBUFFER_FLAGS)<br/>
/// D3DCOMMON.h
/// </summary>
public enum ShaderCbufferFlags : uint {
	/// <summary>
	/// <b>D3D_CBF_USERPACKED</b> = 1
	/// </summary>
	CbfUserpacked = 1,
	/// <summary>
	/// <b>D3D10_CBF_USERPACKED</b> = D3D_CBF_USERPACKED
	/// </summary>
	D3D10CbfUserpacked = CbfUserpacked,
}

/// <summary>
/// ENUM <b>_D3D_CBUFFER_TYPE</b> (D3D_CBUFFER_TYPE)<br/>
/// D3DCOMMON.h
/// </summary>
public enum CbufferType : uint {
	/// <summary>
	/// <b>D3D_CT_CBUFFER</b> = 0
	/// </summary>
	CtCbuffer = 0,
	/// <summary>
	/// <b>D3D_CT_TBUFFER</b> = ( D3D_CT_CBUFFER + 1 )
	/// </summary>
	CtTbuffer = CtCbuffer + 1,
	/// <summary>
	/// <b>D3D_CT_INTERFACE_POINTERS</b> = ( D3D_CT_TBUFFER + 1 )
	/// </summary>
	CtInterfacePointers = CtTbuffer + 1,
	/// <summary>
	/// <b>D3D_CT_RESOURCE_BIND_INFO</b> = ( D3D_CT_INTERFACE_POINTERS + 1 )
	/// </summary>
	CtResourceBindInfo = CtInterfacePointers + 1,
	/// <summary>
	/// <b>D3D10_CT_CBUFFER</b> = D3D_CT_CBUFFER
	/// </summary>
	D3D10CtCbuffer = CtCbuffer,
	/// <summary>
	/// <b>D3D10_CT_TBUFFER</b> = D3D_CT_TBUFFER
	/// </summary>
	D3D10CtTbuffer = CtTbuffer,
	/// <summary>
	/// <b>D3D11_CT_CBUFFER</b> = D3D_CT_CBUFFER
	/// </summary>
	D3D11CtCbuffer = CtCbuffer,
	/// <summary>
	/// <b>D3D11_CT_TBUFFER</b> = D3D_CT_TBUFFER
	/// </summary>
	D3D11CtTbuffer = CtTbuffer,
	/// <summary>
	/// <b>D3D11_CT_INTERFACE_POINTERS</b> = D3D_CT_INTERFACE_POINTERS
	/// </summary>
	D3D11CtInterfacePointers = CtInterfacePointers,
	/// <summary>
	/// <b>D3D11_CT_RESOURCE_BIND_INFO</b> = D3D_CT_RESOURCE_BIND_INFO
	/// </summary>
	D3D11CtResourceBindInfo = CtResourceBindInfo,
}

/// <summary>
/// ENUM <b>D3D_NAME</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum Name : uint {
	/// <summary>
	/// <b>D3D_NAME_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D_NAME_POSITION</b> = 1
	/// </summary>
	Position = 1,
	/// <summary>
	/// <b>D3D_NAME_CLIP_DISTANCE</b> = 2
	/// </summary>
	ClipDistance = 2,
	/// <summary>
	/// <b>D3D_NAME_CULL_DISTANCE</b> = 3
	/// </summary>
	CullDistance = 3,
	/// <summary>
	/// <b>D3D_NAME_RENDER_TARGET_ARRAY_INDEX</b> = 4
	/// </summary>
	RenderTargetArrayIndex = 4,
	/// <summary>
	/// <b>D3D_NAME_VIEWPORT_ARRAY_INDEX</b> = 5
	/// </summary>
	ViewportArrayIndex = 5,
	/// <summary>
	/// <b>D3D_NAME_VERTEX_ID</b> = 6
	/// </summary>
	VertexId = 6,
	/// <summary>
	/// <b>D3D_NAME_PRIMITIVE_ID</b> = 7
	/// </summary>
	PrimitiveId = 7,
	/// <summary>
	/// <b>D3D_NAME_INSTANCE_ID</b> = 8
	/// </summary>
	InstanceId = 8,
	/// <summary>
	/// <b>D3D_NAME_IS_FRONT_FACE</b> = 9
	/// </summary>
	IsFrontFace = 9,
	/// <summary>
	/// <b>D3D_NAME_SAMPLE_INDEX</b> = 10
	/// </summary>
	SampleIndex = 10,
	/// <summary>
	/// <b>D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR</b> = 11
	/// </summary>
	FinalQuadEdgeTessfactor = 11,
	/// <summary>
	/// <b>D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR</b> = 12
	/// </summary>
	FinalQuadInsideTessfactor = 12,
	/// <summary>
	/// <b>D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR</b> = 13
	/// </summary>
	FinalTriEdgeTessfactor = 13,
	/// <summary>
	/// <b>D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR</b> = 14
	/// </summary>
	FinalTriInsideTessfactor = 14,
	/// <summary>
	/// <b>D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR</b> = 15
	/// </summary>
	FinalLineDetailTessfactor = 15,
	/// <summary>
	/// <b>D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR</b> = 16
	/// </summary>
	FinalLineDensityTessfactor = 16,
	/// <summary>
	/// <b>D3D_NAME_BARYCENTRICS</b> = 23
	/// </summary>
	Barycentrics = 23,
	/// <summary>
	/// <b>D3D_NAME_SHADINGRATE</b> = 24
	/// </summary>
	Shadingrate = 24,
	/// <summary>
	/// <b>D3D_NAME_CULLPRIMITIVE</b> = 25
	/// </summary>
	Cullprimitive = 25,
	/// <summary>
	/// <b>D3D_NAME_TARGET</b> = 64
	/// </summary>
	Target = 64,
	/// <summary>
	/// <b>D3D_NAME_DEPTH</b> = 65
	/// </summary>
	Depth = 65,
	/// <summary>
	/// <b>D3D_NAME_COVERAGE</b> = 66
	/// </summary>
	Coverage = 66,
	/// <summary>
	/// <b>D3D_NAME_DEPTH_GREATER_EQUAL</b> = 67
	/// </summary>
	DepthGreaterEqual = 67,
	/// <summary>
	/// <b>D3D_NAME_DEPTH_LESS_EQUAL</b> = 68
	/// </summary>
	DepthLessEqual = 68,
	/// <summary>
	/// <b>D3D_NAME_STENCIL_REF</b> = 69
	/// </summary>
	StencilRef = 69,
	/// <summary>
	/// <b>D3D_NAME_INNER_COVERAGE</b> = 70
	/// </summary>
	InnerCoverage = 70,
	/// <summary>
	/// <b>D3D10_NAME_UNDEFINED</b> = D3D_NAME_UNDEFINED
	/// </summary>
	D3D10Undefined = Undefined,
	/// <summary>
	/// <b>D3D10_NAME_POSITION</b> = D3D_NAME_POSITION
	/// </summary>
	D3D10Position = Position,
	/// <summary>
	/// <b>D3D10_NAME_CLIP_DISTANCE</b> = D3D_NAME_CLIP_DISTANCE
	/// </summary>
	D3D10ClipDistance = ClipDistance,
	/// <summary>
	/// <b>D3D10_NAME_CULL_DISTANCE</b> = D3D_NAME_CULL_DISTANCE
	/// </summary>
	D3D10CullDistance = CullDistance,
	/// <summary>
	/// <b>D3D10_NAME_RENDER_TARGET_ARRAY_INDEX</b> = D3D_NAME_RENDER_TARGET_ARRAY_INDEX
	/// </summary>
	D3D10RenderTargetArrayIndex = RenderTargetArrayIndex,
	/// <summary>
	/// <b>D3D10_NAME_VIEWPORT_ARRAY_INDEX</b> = D3D_NAME_VIEWPORT_ARRAY_INDEX
	/// </summary>
	D3D10ViewportArrayIndex = ViewportArrayIndex,
	/// <summary>
	/// <b>D3D10_NAME_VERTEX_ID</b> = D3D_NAME_VERTEX_ID
	/// </summary>
	D3D10VertexId = VertexId,
	/// <summary>
	/// <b>D3D10_NAME_PRIMITIVE_ID</b> = D3D_NAME_PRIMITIVE_ID
	/// </summary>
	D3D10PrimitiveId = PrimitiveId,
	/// <summary>
	/// <b>D3D10_NAME_INSTANCE_ID</b> = D3D_NAME_INSTANCE_ID
	/// </summary>
	D3D10InstanceId = InstanceId,
	/// <summary>
	/// <b>D3D10_NAME_IS_FRONT_FACE</b> = D3D_NAME_IS_FRONT_FACE
	/// </summary>
	D3D10IsFrontFace = IsFrontFace,
	/// <summary>
	/// <b>D3D10_NAME_SAMPLE_INDEX</b> = D3D_NAME_SAMPLE_INDEX
	/// </summary>
	D3D10SampleIndex = SampleIndex,
	/// <summary>
	/// <b>D3D10_NAME_TARGET</b> = D3D_NAME_TARGET
	/// </summary>
	D3D10Target = Target,
	/// <summary>
	/// <b>D3D10_NAME_DEPTH</b> = D3D_NAME_DEPTH
	/// </summary>
	D3D10Depth = Depth,
	/// <summary>
	/// <b>D3D10_NAME_COVERAGE</b> = D3D_NAME_COVERAGE
	/// </summary>
	D3D10Coverage = Coverage,
	/// <summary>
	/// <b>D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR</b> = D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR
	/// </summary>
	D3D11FinalQuadEdgeTessfactor = FinalQuadEdgeTessfactor,
	/// <summary>
	/// <b>D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR</b> = D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR
	/// </summary>
	D3D11FinalQuadInsideTessfactor = FinalQuadInsideTessfactor,
	/// <summary>
	/// <b>D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR</b> = D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR
	/// </summary>
	D3D11FinalTriEdgeTessfactor = FinalTriEdgeTessfactor,
	/// <summary>
	/// <b>D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR</b> = D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR
	/// </summary>
	D3D11FinalTriInsideTessfactor = FinalTriInsideTessfactor,
	/// <summary>
	/// <b>D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR</b> = D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR
	/// </summary>
	D3D11FinalLineDetailTessfactor = FinalLineDetailTessfactor,
	/// <summary>
	/// <b>D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR</b> = D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR
	/// </summary>
	D3D11FinalLineDensityTessfactor = FinalLineDensityTessfactor,
	/// <summary>
	/// <b>D3D11_NAME_DEPTH_GREATER_EQUAL</b> = D3D_NAME_DEPTH_GREATER_EQUAL
	/// </summary>
	D3D11DepthGreaterEqual = DepthGreaterEqual,
	/// <summary>
	/// <b>D3D11_NAME_DEPTH_LESS_EQUAL</b> = D3D_NAME_DEPTH_LESS_EQUAL
	/// </summary>
	D3D11DepthLessEqual = DepthLessEqual,
	/// <summary>
	/// <b>D3D11_NAME_STENCIL_REF</b> = D3D_NAME_STENCIL_REF
	/// </summary>
	D3D11StencilRef = StencilRef,
	/// <summary>
	/// <b>D3D11_NAME_INNER_COVERAGE</b> = D3D_NAME_INNER_COVERAGE
	/// </summary>
	D3D11InnerCoverage = InnerCoverage,
	/// <summary>
	/// <b>D3D12_NAME_BARYCENTRICS</b> = D3D_NAME_BARYCENTRICS
	/// </summary>
	D3D12Barycentrics = Barycentrics,
	/// <summary>
	/// <b>D3D12_NAME_SHADINGRATE</b> = D3D_NAME_SHADINGRATE
	/// </summary>
	D3D12Shadingrate = Shadingrate,
	/// <summary>
	/// <b>D3D12_NAME_CULLPRIMITIVE</b> = D3D_NAME_CULLPRIMITIVE
	/// </summary>
	D3D12Cullprimitive = Cullprimitive,
}

/// <summary>
/// ENUM <b>D3D_RESOURCE_RETURN_TYPE</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum ResourceReturnType : uint {
	/// <summary>
	/// <b>D3D_RETURN_TYPE_UNORM</b> = 1
	/// </summary>
	ReturnTypeUnorm = 1,
	/// <summary>
	/// <b>D3D_RETURN_TYPE_SNORM</b> = 2
	/// </summary>
	ReturnTypeSnorm = 2,
	/// <summary>
	/// <b>D3D_RETURN_TYPE_SINT</b> = 3
	/// </summary>
	ReturnTypeSint = 3,
	/// <summary>
	/// <b>D3D_RETURN_TYPE_UINT</b> = 4
	/// </summary>
	ReturnTypeUint = 4,
	/// <summary>
	/// <b>D3D_RETURN_TYPE_FLOAT</b> = 5
	/// </summary>
	ReturnTypeFloat = 5,
	/// <summary>
	/// <b>D3D_RETURN_TYPE_MIXED</b> = 6
	/// </summary>
	ReturnTypeMixed = 6,
	/// <summary>
	/// <b>D3D_RETURN_TYPE_DOUBLE</b> = 7
	/// </summary>
	ReturnTypeDouble = 7,
	/// <summary>
	/// <b>D3D_RETURN_TYPE_CONTINUED</b> = 8
	/// </summary>
	ReturnTypeContinued = 8,
	/// <summary>
	/// <b>D3D10_RETURN_TYPE_UNORM</b> = D3D_RETURN_TYPE_UNORM
	/// </summary>
	D3D10ReturnTypeUnorm = ReturnTypeUnorm,
	/// <summary>
	/// <b>D3D10_RETURN_TYPE_SNORM</b> = D3D_RETURN_TYPE_SNORM
	/// </summary>
	D3D10ReturnTypeSnorm = ReturnTypeSnorm,
	/// <summary>
	/// <b>D3D10_RETURN_TYPE_SINT</b> = D3D_RETURN_TYPE_SINT
	/// </summary>
	D3D10ReturnTypeSint = ReturnTypeSint,
	/// <summary>
	/// <b>D3D10_RETURN_TYPE_UINT</b> = D3D_RETURN_TYPE_UINT
	/// </summary>
	D3D10ReturnTypeUint = ReturnTypeUint,
	/// <summary>
	/// <b>D3D10_RETURN_TYPE_FLOAT</b> = D3D_RETURN_TYPE_FLOAT
	/// </summary>
	D3D10ReturnTypeFloat = ReturnTypeFloat,
	/// <summary>
	/// <b>D3D10_RETURN_TYPE_MIXED</b> = D3D_RETURN_TYPE_MIXED
	/// </summary>
	D3D10ReturnTypeMixed = ReturnTypeMixed,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_UNORM</b> = D3D_RETURN_TYPE_UNORM
	/// </summary>
	D3D11ReturnTypeUnorm = ReturnTypeUnorm,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_SNORM</b> = D3D_RETURN_TYPE_SNORM
	/// </summary>
	D3D11ReturnTypeSnorm = ReturnTypeSnorm,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_SINT</b> = D3D_RETURN_TYPE_SINT
	/// </summary>
	D3D11ReturnTypeSint = ReturnTypeSint,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_UINT</b> = D3D_RETURN_TYPE_UINT
	/// </summary>
	D3D11ReturnTypeUint = ReturnTypeUint,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_FLOAT</b> = D3D_RETURN_TYPE_FLOAT
	/// </summary>
	D3D11ReturnTypeFloat = ReturnTypeFloat,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_MIXED</b> = D3D_RETURN_TYPE_MIXED
	/// </summary>
	D3D11ReturnTypeMixed = ReturnTypeMixed,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_DOUBLE</b> = D3D_RETURN_TYPE_DOUBLE
	/// </summary>
	D3D11ReturnTypeDouble = ReturnTypeDouble,
	/// <summary>
	/// <b>D3D11_RETURN_TYPE_CONTINUED</b> = D3D_RETURN_TYPE_CONTINUED
	/// </summary>
	D3D11ReturnTypeContinued = ReturnTypeContinued,
}

/// <summary>
/// ENUM <b>D3D_REGISTER_COMPONENT_TYPE</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum RegisterComponentType : uint {
	/// <summary>
	/// <b>D3D_REGISTER_COMPONENT_UNKNOWN</b> = 0
	/// </summary>
	Unknown = 0,
	/// <summary>
	/// <b>D3D_REGISTER_COMPONENT_UINT32</b> = 1
	/// </summary>
	Uint32 = 1,
	/// <summary>
	/// <b>D3D_REGISTER_COMPONENT_SINT32</b> = 2
	/// </summary>
	Sint32 = 2,
	/// <summary>
	/// <b>D3D_REGISTER_COMPONENT_FLOAT32</b> = 3
	/// </summary>
	Float32 = 3,
	/// <summary>
	/// <b>D3D10_REGISTER_COMPONENT_UNKNOWN</b> = D3D_REGISTER_COMPONENT_UNKNOWN
	/// </summary>
	D3D10Unknown = Unknown,
	/// <summary>
	/// <b>D3D10_REGISTER_COMPONENT_UINT32</b> = D3D_REGISTER_COMPONENT_UINT32
	/// </summary>
	D3D10Uint32 = Uint32,
	/// <summary>
	/// <b>D3D10_REGISTER_COMPONENT_SINT32</b> = D3D_REGISTER_COMPONENT_SINT32
	/// </summary>
	D3D10Sint32 = Sint32,
	/// <summary>
	/// <b>D3D10_REGISTER_COMPONENT_FLOAT32</b> = D3D_REGISTER_COMPONENT_FLOAT32
	/// </summary>
	D3D10Float32 = Float32,
}

/// <summary>
/// ENUM <b>D3D_TESSELLATOR_DOMAIN</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum TessellatorDomain : uint {
	/// <summary>
	/// <b>D3D_TESSELLATOR_DOMAIN_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D_TESSELLATOR_DOMAIN_ISOLINE</b> = 1
	/// </summary>
	Isoline = 1,
	/// <summary>
	/// <b>D3D_TESSELLATOR_DOMAIN_TRI</b> = 2
	/// </summary>
	Tri = 2,
	/// <summary>
	/// <b>D3D_TESSELLATOR_DOMAIN_QUAD</b> = 3
	/// </summary>
	Quad = 3,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_DOMAIN_UNDEFINED</b> = D3D_TESSELLATOR_DOMAIN_UNDEFINED
	/// </summary>
	D3D11Undefined = Undefined,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_DOMAIN_ISOLINE</b> = D3D_TESSELLATOR_DOMAIN_ISOLINE
	/// </summary>
	D3D11Isoline = Isoline,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_DOMAIN_TRI</b> = D3D_TESSELLATOR_DOMAIN_TRI
	/// </summary>
	D3D11Tri = Tri,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_DOMAIN_QUAD</b> = D3D_TESSELLATOR_DOMAIN_QUAD
	/// </summary>
	D3D11Quad = Quad,
}

/// <summary>
/// ENUM <b>D3D_TESSELLATOR_PARTITIONING</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum TessellatorPartitioning : uint {
	/// <summary>
	/// <b>D3D_TESSELLATOR_PARTITIONING_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D_TESSELLATOR_PARTITIONING_INTEGER</b> = 1
	/// </summary>
	Integer = 1,
	/// <summary>
	/// <b>D3D_TESSELLATOR_PARTITIONING_POW2</b> = 2
	/// </summary>
	Pow2 = 2,
	/// <summary>
	/// <b>D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD</b> = 3
	/// </summary>
	FractionalOdd = 3,
	/// <summary>
	/// <b>D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN</b> = 4
	/// </summary>
	FractionalEven = 4,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_PARTITIONING_UNDEFINED</b> = D3D_TESSELLATOR_PARTITIONING_UNDEFINED
	/// </summary>
	D3D11Undefined = Undefined,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_PARTITIONING_INTEGER</b> = D3D_TESSELLATOR_PARTITIONING_INTEGER
	/// </summary>
	D3D11Integer = Integer,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_PARTITIONING_POW2</b> = D3D_TESSELLATOR_PARTITIONING_POW2
	/// </summary>
	D3D11Pow2 = Pow2,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD</b> = D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD
	/// </summary>
	D3D11FractionalOdd = FractionalOdd,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN</b> = D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN
	/// </summary>
	D3D11FractionalEven = FractionalEven,
}

/// <summary>
/// ENUM <b>D3D_TESSELLATOR_OUTPUT_PRIMITIVE</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum TessellatorOutputPrimitive : uint {
	/// <summary>
	/// <b>D3D_TESSELLATOR_OUTPUT_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D_TESSELLATOR_OUTPUT_POINT</b> = 1
	/// </summary>
	Point = 1,
	/// <summary>
	/// <b>D3D_TESSELLATOR_OUTPUT_LINE</b> = 2
	/// </summary>
	Line = 2,
	/// <summary>
	/// <b>D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW</b> = 3
	/// </summary>
	TriangleCw = 3,
	/// <summary>
	/// <b>D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW</b> = 4
	/// </summary>
	TriangleCcw = 4,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_OUTPUT_UNDEFINED</b> = D3D_TESSELLATOR_OUTPUT_UNDEFINED
	/// </summary>
	D3D11Undefined = Undefined,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_OUTPUT_POINT</b> = D3D_TESSELLATOR_OUTPUT_POINT
	/// </summary>
	D3D11Point = Point,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_OUTPUT_LINE</b> = D3D_TESSELLATOR_OUTPUT_LINE
	/// </summary>
	D3D11Line = Line,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW</b> = D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW
	/// </summary>
	D3D11TriangleCw = TriangleCw,
	/// <summary>
	/// <b>D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW</b> = D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW
	/// </summary>
	D3D11TriangleCcw = TriangleCcw,
}

/// <summary>
/// ENUM <b>D3D_MIN_PRECISION</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum MinPrecision : uint {
	/// <summary>
	/// <b>D3D_MIN_PRECISION_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>D3D_MIN_PRECISION_FLOAT_16</b> = 1
	/// </summary>
	Float16 = 1,
	/// <summary>
	/// <b>D3D_MIN_PRECISION_FLOAT_2_8</b> = 2
	/// </summary>
	Float28 = 2,
	/// <summary>
	/// <b>D3D_MIN_PRECISION_RESERVED</b> = 3
	/// </summary>
	Reserved = 3,
	/// <summary>
	/// <b>D3D_MIN_PRECISION_SINT_16</b> = 4
	/// </summary>
	Sint16 = 4,
	/// <summary>
	/// <b>D3D_MIN_PRECISION_UINT_16</b> = 5
	/// </summary>
	Uint16 = 5,
	/// <summary>
	/// <b>D3D_MIN_PRECISION_ANY_16</b> = 0xf0
	/// </summary>
	Any16 = 240,
	/// <summary>
	/// <b>D3D_MIN_PRECISION_ANY_10</b> = 0xf1
	/// </summary>
	Any10 = 241,
}

/// <summary>
/// ENUM <b>D3D_INTERPOLATION_MODE</b><br/>
/// D3DCOMMON.h
/// </summary>
public enum InterpolationMode : uint {
	/// <summary>
	/// <b>D3D_INTERPOLATION_UNDEFINED</b> = 0
	/// </summary>
	Undefined = 0,
	/// <summary>
	/// <b>D3D_INTERPOLATION_CONSTANT</b> = 1
	/// </summary>
	Constant = 1,
	/// <summary>
	/// <b>D3D_INTERPOLATION_LINEAR</b> = 2
	/// </summary>
	Linear = 2,
	/// <summary>
	/// <b>D3D_INTERPOLATION_LINEAR_CENTROID</b> = 3
	/// </summary>
	LinearCentroid = 3,
	/// <summary>
	/// <b>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE</b> = 4
	/// </summary>
	LinearNoperspective = 4,
	/// <summary>
	/// <b>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID</b> = 5
	/// </summary>
	LinearNoperspectiveCentroid = 5,
	/// <summary>
	/// <b>D3D_INTERPOLATION_LINEAR_SAMPLE</b> = 6
	/// </summary>
	LinearSample = 6,
	/// <summary>
	/// <b>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE</b> = 7
	/// </summary>
	LinearNoperspectiveSample = 7,
}

/// <summary>
/// ENUM <b>_D3D_PARAMETER_FLAGS</b> (D3D_PARAMETER_FLAGS)<br/>
/// D3DCOMMON.h
/// </summary>
public enum ParameterFlags : uint {
	/// <summary>
	/// <b>D3D_PF_NONE</b> = 0
	/// </summary>
	PfNone = 0,
	/// <summary>
	/// <b>D3D_PF_IN</b> = 0x1
	/// </summary>
	PfIn = 1,
	/// <summary>
	/// <b>D3D_PF_OUT</b> = 0x2
	/// </summary>
	PfOut = 2,
}

/// <summary>
/// ENUM <b>D3D_ROOT_SIGNATURE_VERSION</b><br/>
/// D3D12.h
/// </summary>
public enum RootSignatureVersion : uint {
	/// <summary>
	/// <b>D3D_ROOT_SIGNATURE_VERSION_1</b> = 0x1
	/// </summary>
	Version1 = 1,
	/// <summary>
	/// <b>D3D_ROOT_SIGNATURE_VERSION_1_0</b> = 0x1
	/// </summary>
	Version10 = 1,
	/// <summary>
	/// <b>D3D_ROOT_SIGNATURE_VERSION_1_1</b> = 0x2
	/// </summary>
	Version11 = 2,
}

/// <summary>
/// ENUM <b>D3D_SHADER_MODEL</b><br/>
/// D3D12.h
/// </summary>
public enum ShaderModel : uint {
	/// <summary>
	/// <b>D3D_SHADER_MODEL_5_1</b> = 0x51
	/// </summary>
	Model51 = 81,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_0</b> = 0x60
	/// </summary>
	Model60 = 96,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_1</b> = 0x61
	/// </summary>
	Model61 = 97,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_2</b> = 0x62
	/// </summary>
	Model62 = 98,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_3</b> = 0x63
	/// </summary>
	Model63 = 99,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_4</b> = 0x64
	/// </summary>
	Model64 = 100,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_5</b> = 0x65
	/// </summary>
	Model65 = 101,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_6</b> = 0x66
	/// </summary>
	Model66 = 102,
	/// <summary>
	/// <b>D3D_SHADER_MODEL_6_7</b> = 0x67
	/// </summary>
	Model67 = 103,
	/// <summary>
	/// <b>D3D_HIGHEST_SHADER_MODEL</b> = D3D_SHADER_MODEL_6_7
	/// </summary>
	HighestShaderModel = Model67,
}
