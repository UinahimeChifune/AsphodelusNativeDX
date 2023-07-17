using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// 
/// </summary>
public static class GUID {

	/// <summary>
	/// 
	/// </summary>
	public static class ExperimentalFeature {

		/// <summary>
		/// <b>D3D12ExperimentalShaderModels</b><br/>
		/// D3D12.h
		/// </summary>
		public static Guid ExperimentalShaderModels { get => _experimentalShaderModels; }
		static readonly Guid _experimentalShaderModels = new (0x76f5573e, 0xf13a, 0x40f5, 0xb2, 0x97, 0x81, 0xce, 0x9e, 0x18, 0x93, 0x3f);
		/// <summary>
		/// <b>D3D12TiledResourceTier4</b><br/>
		/// D3D12.h
		/// </summary>
		public static Guid TiledResourceTier4 { get => _tiledResourceTier4; }
		static readonly Guid _tiledResourceTier4 = new (0xc9c4725f, 0xa81a, 0x4f56, 0x8c, 0x5b, 0xc5, 0x10, 0x39, 0xd6, 0x94, 0xfb);
		/// <summary>
		/// <b>D3D12MetaCommand</b><br/>
		/// D3D12.h
		/// </summary>
		public static Guid MetaCommand { get => _metaCommand; }
		static readonly Guid _metaCommand = new (0xc734c97e, 0x8077, 0x48c8, 0x9f, 0xdc, 0xd9, 0xd1, 0xdd, 0x31, 0xdd, 0x77);

	}

	/// <summary>
	/// 
	/// </summary>
	public static class VideoDecodeProfile {

		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Mpeg2</b>
		/// </summary>
		public static Guid Mpeg2 { get => _mpeg2; }
		internal static readonly Guid _mpeg2 = new (0xee27417f, 0x5e28, 0x4e65, 0xbe, 0xea, 0x1d, 0x26, 0xb5, 0x08, 0xad, 0xc9);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Mpeg1AndMpeg2</b>
		/// </summary>
		public static Guid Mpeg1AndMpeg2 { get => _mpeg1AndMpeg2; }
		internal static readonly Guid _mpeg1AndMpeg2 = new (0x86695f12, 0x340e, 0x4f04, 0x9f, 0xd3, 0x92, 0x53, 0xdd, 0x32, 0x74, 0x60);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_H264</b>
		/// </summary>
		public static Guid H264 { get => _h264; }
		internal static readonly Guid _h264 = new (0x1b81be68, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_H264StereoProgressive</b>
		/// </summary>
		public static Guid H264StereoProgressive { get => _h264StereoProgressive; }
		internal static readonly Guid _h264StereoProgressive = new (0xd79be8da, 0x0cf1, 0x4c81, 0xb8, 0x2a, 0x69, 0xa4, 0xe2, 0x36, 0xf4, 0x3d);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_H264Stereo</b>
		/// </summary>
		public static Guid H264Stereo { get => _h264Stereo; }
		internal static readonly Guid _h264Stereo = new (0xf9aaccbb, 0xc2b6, 0x4cfc, 0x87, 0x79, 0x57, 0x07, 0xb1, 0x76, 0x05, 0x52);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_H264Multiview</b>
		/// </summary>
		public static Guid H264Multiview { get => _h264Multiview; }
		internal static readonly Guid _h264Multiview = new (0x705b9d82, 0x76cf, 0x49d6, 0xb7, 0xe6, 0xac, 0x88, 0x72, 0xdb, 0x01, 0x3c);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Vc1</b>
		/// </summary>
		public static Guid Vc1 { get => _vc1; }
		internal static readonly Guid _vc1 = new (0x1b81bea3, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Vc1D2010</b>
		/// </summary>
		public static Guid Vc1D2010 { get => _vc1D2010; }
		internal static readonly Guid _vc1D2010 = new (0x1b81bea4, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Mpeg4pt2Simple</b>
		/// </summary>
		public static Guid Mpeg4pt2Simple { get => _mpeg4pt2Simple; }
		internal static readonly Guid _mpeg4pt2Simple = new (0xefd64d74, 0xc9e8, 0x41d7, 0xa5, 0xe9, 0xe9, 0xb0, 0xe3, 0x9f, 0xa3, 0x19);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Mpeg4pt2AdvsimpleNogmc</b>
		/// </summary>
		public static Guid Mpeg4pt2AdvsimpleNogmc { get => _mpeg4pt2AdvsimpleNogmc; }
		internal static readonly Guid _mpeg4pt2AdvsimpleNogmc = new (0xed418a9f, 0x010d, 0x4eda, 0x9a, 0xe3, 0x9a, 0x65, 0x35, 0x8d, 0x8d, 0x2e);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_HevcMain</b>
		/// </summary>
		public static Guid HevcMain { get => _hevcMain; }
		internal static readonly Guid _hevcMain = new (0x5b11d51b, 0x2f4c, 0x4452, 0xbc, 0xc3, 0x09, 0xf2, 0xa1, 0x16, 0x0c, 0xc0);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_HevcMain10</b>
		/// </summary>
		public static Guid HevcMain10 { get => _hevcMain10; }
		internal static readonly Guid _hevcMain10 = new (0x107af0e0, 0xef1a, 0x4d19, 0xab, 0xa8, 0x67, 0xa1, 0x63, 0x07, 0x3d, 0x13);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Vp9</b>
		/// </summary>
		public static Guid Vp9 { get => _vp9; }
		internal static readonly Guid _vp9 = new (0x463707f8, 0xa1d0, 0x4585, 0x87, 0x6d, 0x83, 0xaa, 0x6d, 0x60, 0xb8, 0x9e);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Vp910BitProfile2</b>
		/// </summary>
		public static Guid Vp910BitProfile2 { get => _vp910BitProfile2; }
		internal static readonly Guid _vp910BitProfile2 = new (0xa4c749ef, 0x6ecf, 0x48aa, 0x84, 0x48, 0x50, 0xa7, 0xa1, 0x16, 0x5f, 0xf7);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Vp8</b>
		/// </summary>
		public static Guid Vp8 { get => _vp8; }
		internal static readonly Guid _vp8 = new (0x90b899ea, 0x3a62, 0x4705, 0x88, 0xb3, 0x8d, 0xf0, 0x4b, 0x27, 0x44, 0xe7);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Av1Profile0</b>
		/// </summary>
		public static Guid Av1Profile0 { get => _av1Profile0; }
		internal static readonly Guid _av1Profile0 = new (0xb8be4ccb, 0xcf53, 0x46ba, 0x8d, 0x59, 0xd6, 0xb8, 0xa6, 0xda, 0x5d, 0x2a);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Av1Profile1</b>
		/// </summary>
		public static Guid Av1Profile1 { get => _av1Profile1; }
		internal static readonly Guid _av1Profile1 = new (0x6936ff0f, 0x45b1, 0x4163, 0x9c, 0xc1, 0x64, 0x6e, 0xf6, 0x94, 0x61, 0x08);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Av1Profile2</b>
		/// </summary>
		public static Guid Av1Profile2 { get => _av1Profile2; }
		internal static readonly Guid _av1Profile2 = new (0x0c5f2aa1, 0xe541, 0x4089, 0xbb, 0x7b, 0x98, 0x11, 0x0a, 0x19, 0xd7, 0xc8);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Av112BitProfile2</b>
		/// </summary>
		public static Guid Av112BitProfile2 { get => _av112BitProfile2; }
		internal static readonly Guid _av112BitProfile2 = new (0x17127009, 0xa00f, 0x4ce1, 0x99, 0x4e, 0xbf, 0x40, 0x81, 0xf6, 0xf3, 0xf0);
		/// <summary>
		/// <b>D3D12_VIDEO_DECODE_PROFILE_Av112BitProfile2420</b>
		/// </summary>
		public static Guid Av112BitProfile2420 { get => _av112BitProfile2420; }
		internal static readonly Guid _av112BitProfile2420 = new (0x2d80bed6, 0x9cac, 0x4835, 0x9e, 0x91, 0x32, 0x7b, 0xbc, 0x4f, 0x9e, 0xe8);

	}
}

/// <summary>
/// 
/// </summary>
public static class CLSID {

	/// <summary>
	/// <b>CLSID_D3D12Debug</b>
	/// </summary>
	public static Guid Debug { get => _debug; }
	internal static readonly Guid _debug = new (0xf2352aeb, 0xdd84, 0x49fe, 0xb9, 0x7b, 0xa9, 0xdc, 0xfd, 0xcc, 0x1b, 0x4f);
	/// <summary>
	/// <b>CLSID_D3D12Tools</b>
	/// </summary>
	public static Guid Tools { get => _tools; }
	internal static readonly Guid _tools = new (0xe38216b1, 0x3c8c, 0x4833, 0xaa, 0x09, 0x0a, 0x06, 0xb6, 0x5d, 0x96, 0xc8);
	/// <summary>
	/// <b>CLSID_D3D12DeviceRemovedExtendedData</b>
	/// </summary>
	public static Guid DeviceRemovedExtendedData { get => _deviceRemovedExtendedData; }
	internal static readonly Guid _deviceRemovedExtendedData = new (0x4a75bbc4, 0x9ff4, 0x4ad8, 0x9f, 0x18, 0xab, 0xae, 0x84, 0xdc, 0x5f, 0xf2);
	/// <summary>
	/// <b>CLSID_D3D12SDKConfiguration</b>
	/// </summary>
	public static Guid SDKConfiguration { get => _sDKConfiguration; }
	internal static readonly Guid _sDKConfiguration = new (0x7cda6aca, 0xa03e, 0x49c8, 0x94, 0x58, 0x03, 0x34, 0xd2, 0x0e, 0x07, 0xce);

}
