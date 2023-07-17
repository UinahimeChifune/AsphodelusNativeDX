using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphodelusNative.Direct3D11;

/// <summary>
/// 
/// </summary>
public static class GUID {

	/// <summary>
	/// 
	/// </summary>
	public static class DecoderProfile {

		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Mpeg2Mocomp</b>
		/// </summary>
		public static Guid Mpeg2Mocomp { get => _mpeg2Mocomp; }
		internal static readonly Guid _mpeg2Mocomp = new (0xe6a9f44b, 0x61b0, 0x4563, 0x9e, 0xa4, 0x63, 0xd2, 0xa3, 0xc6, 0xfe, 0x66);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Mpeg2Idct</b>
		/// </summary>
		public static Guid Mpeg2Idct { get => _mpeg2Idct; }
		internal static readonly Guid _mpeg2Idct = new (0xbf22ad00, 0x03ea, 0x4690, 0x80, 0x77, 0x47, 0x33, 0x46, 0x20, 0x9b, 0x7e);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Mpeg2Vld</b>
		/// </summary>
		public static Guid Mpeg2Vld { get => _mpeg2Vld; }
		internal static readonly Guid _mpeg2Vld = new (0xee27417f, 0x5e28, 0x4e65, 0xbe, 0xea, 0x1d, 0x26, 0xb5, 0x08, 0xad, 0xc9);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Mpeg1Vld</b>
		/// </summary>
		public static Guid Mpeg1Vld { get => _mpeg1Vld; }
		internal static readonly Guid _mpeg1Vld = new (0x6f3ec719, 0x3735, 0x42cc, 0x80, 0x63, 0x65, 0xcc, 0x3c, 0xb3, 0x66, 0x16);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_MPEG2and1Vld</b>
		/// </summary>
		public static Guid MPEG2and1Vld { get => _mPEG2and1Vld; }
		internal static readonly Guid _mPEG2and1Vld = new (0x86695f12, 0x340e, 0x4f04, 0x9f, 0xd3, 0x92, 0x53, 0xdd, 0x32, 0x74, 0x60);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264MocompNofgt</b>
		/// </summary>
		public static Guid H264MocompNofgt { get => _h264MocompNofgt; }
		internal static readonly Guid _h264MocompNofgt = new (0x1b81be64, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264MocompFgt</b>
		/// </summary>
		public static Guid H264MocompFgt { get => _h264MocompFgt; }
		internal static readonly Guid _h264MocompFgt = new (0x1b81be65, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264IdctNofgt</b>
		/// </summary>
		public static Guid H264IdctNofgt { get => _h264IdctNofgt; }
		internal static readonly Guid _h264IdctNofgt = new (0x1b81be66, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264IdctFgt</b>
		/// </summary>
		public static Guid H264IdctFgt { get => _h264IdctFgt; }
		internal static readonly Guid _h264IdctFgt = new (0x1b81be67, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264VldNofgt</b>
		/// </summary>
		public static Guid H264VldNofgt { get => _h264VldNofgt; }
		internal static readonly Guid _h264VldNofgt = new (0x1b81be68, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264VldFgt</b>
		/// </summary>
		public static Guid H264VldFgt { get => _h264VldFgt; }
		internal static readonly Guid _h264VldFgt = new (0x1b81be69, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264VldWithfmoasoNofgt</b>
		/// </summary>
		public static Guid H264VldWithfmoasoNofgt { get => _h264VldWithfmoasoNofgt; }
		internal static readonly Guid _h264VldWithfmoasoNofgt = new (0xd5f04ff9, 0x3418, 0x45d8, 0x95, 0x61, 0x32, 0xa7, 0x6a, 0xae, 0x2d, 0xdd);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264VldStereoProgressiveNofgt</b>
		/// </summary>
		public static Guid H264VldStereoProgressiveNofgt { get => _h264VldStereoProgressiveNofgt; }
		internal static readonly Guid _h264VldStereoProgressiveNofgt = new (0xd79be8da, 0x0cf1, 0x4c81, 0xb8, 0x2a, 0x69, 0xa4, 0xe2, 0x36, 0xf4, 0x3d);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264VldStereoNofgt</b>
		/// </summary>
		public static Guid H264VldStereoNofgt { get => _h264VldStereoNofgt; }
		internal static readonly Guid _h264VldStereoNofgt = new (0xf9aaccbb, 0xc2b6, 0x4cfc, 0x87, 0x79, 0x57, 0x07, 0xb1, 0x76, 0x05, 0x52);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_H264VldMultiviewNofgt</b>
		/// </summary>
		public static Guid H264VldMultiviewNofgt { get => _h264VldMultiviewNofgt; }
		internal static readonly Guid _h264VldMultiviewNofgt = new (0x705b9d82, 0x76cf, 0x49d6, 0xb7, 0xe6, 0xac, 0x88, 0x72, 0xdb, 0x01, 0x3c);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Wmv8Postproc</b>
		/// </summary>
		public static Guid Wmv8Postproc { get => _wmv8Postproc; }
		internal static readonly Guid _wmv8Postproc = new (0x1b81be80, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Wmv8Mocomp</b>
		/// </summary>
		public static Guid Wmv8Mocomp { get => _wmv8Mocomp; }
		internal static readonly Guid _wmv8Mocomp = new (0x1b81be81, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Wmv9Postproc</b>
		/// </summary>
		public static Guid Wmv9Postproc { get => _wmv9Postproc; }
		internal static readonly Guid _wmv9Postproc = new (0x1b81be90, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Wmv9Mocomp</b>
		/// </summary>
		public static Guid Wmv9Mocomp { get => _wmv9Mocomp; }
		internal static readonly Guid _wmv9Mocomp = new (0x1b81be91, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Wmv9Idct</b>
		/// </summary>
		public static Guid Wmv9Idct { get => _wmv9Idct; }
		internal static readonly Guid _wmv9Idct = new (0x1b81be94, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vc1Postproc</b>
		/// </summary>
		public static Guid Vc1Postproc { get => _vc1Postproc; }
		internal static readonly Guid _vc1Postproc = new (0x1b81bea0, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vc1Mocomp</b>
		/// </summary>
		public static Guid Vc1Mocomp { get => _vc1Mocomp; }
		internal static readonly Guid _vc1Mocomp = new (0x1b81bea1, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vc1Idct</b>
		/// </summary>
		public static Guid Vc1Idct { get => _vc1Idct; }
		internal static readonly Guid _vc1Idct = new (0x1b81bea2, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vc1Vld</b>
		/// </summary>
		public static Guid Vc1Vld { get => _vc1Vld; }
		internal static readonly Guid _vc1Vld = new (0x1b81bea3, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vc1D2010</b>
		/// </summary>
		public static Guid Vc1D2010 { get => _vc1D2010; }
		internal static readonly Guid _vc1D2010 = new (0x1b81bea4, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Mpeg4pt2VldSimple</b>
		/// </summary>
		public static Guid Mpeg4pt2VldSimple { get => _mpeg4pt2VldSimple; }
		internal static readonly Guid _mpeg4pt2VldSimple = new (0xefd64d74, 0xc9e8, 0x41d7, 0xa5, 0xe9, 0xe9, 0xb0, 0xe3, 0x9f, 0xa3, 0x19);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Mpeg4pt2VldAdvsimpleNogmc</b>
		/// </summary>
		public static Guid Mpeg4pt2VldAdvsimpleNogmc { get => _mpeg4pt2VldAdvsimpleNogmc; }
		internal static readonly Guid _mpeg4pt2VldAdvsimpleNogmc = new (0xed418a9f, 0x010d, 0x4eda, 0x9a, 0xe3, 0x9a, 0x65, 0x35, 0x8d, 0x8d, 0x2e);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Mpeg4pt2VldAdvsimpleGmc</b>
		/// </summary>
		public static Guid Mpeg4pt2VldAdvsimpleGmc { get => _mpeg4pt2VldAdvsimpleGmc; }
		internal static readonly Guid _mpeg4pt2VldAdvsimpleGmc = new (0xab998b5b, 0x4258, 0x44a9, 0x9f, 0xeb, 0x94, 0xe5, 0x97, 0xa6, 0xba, 0xae);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_HevcVldMain</b>
		/// </summary>
		public static Guid HevcVldMain { get => _hevcVldMain; }
		internal static readonly Guid _hevcVldMain = new (0x5b11d51b, 0x2f4c, 0x4452, 0xbc, 0xc3, 0x09, 0xf2, 0xa1, 0x16, 0x0c, 0xc0);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_HevcVldMain10</b>
		/// </summary>
		public static Guid HevcVldMain10 { get => _hevcVldMain10; }
		internal static readonly Guid _hevcVldMain10 = new (0x107af0e0, 0xef1a, 0x4d19, 0xab, 0xa8, 0x67, 0xa1, 0x63, 0x07, 0x3d, 0x13);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vp9VldProfile0</b>
		/// </summary>
		public static Guid Vp9VldProfile0 { get => _vp9VldProfile0; }
		internal static readonly Guid _vp9VldProfile0 = new (0x463707f8, 0xa1d0, 0x4585, 0x87, 0x6d, 0x83, 0xaa, 0x6d, 0x60, 0xb8, 0x9e);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vp9Vld10BitProfile2</b>
		/// </summary>
		public static Guid Vp9Vld10BitProfile2 { get => _vp9Vld10BitProfile2; }
		internal static readonly Guid _vp9Vld10BitProfile2 = new (0xa4c749ef, 0x6ecf, 0x48aa, 0x84, 0x48, 0x50, 0xa7, 0xa1, 0x16, 0x5f, 0xf7);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Vp8Vld</b>
		/// </summary>
		public static Guid Vp8Vld { get => _vp8Vld; }
		internal static readonly Guid _vp8Vld = new (0x90b899ea, 0x3a62, 0x4705, 0x88, 0xb3, 0x8d, 0xf0, 0x4b, 0x27, 0x44, 0xe7);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Av1VldProfile0</b>
		/// </summary>
		public static Guid Av1VldProfile0 { get => _av1VldProfile0; }
		internal static readonly Guid _av1VldProfile0 = new (0xb8be4ccb, 0xcf53, 0x46ba, 0x8d, 0x59, 0xd6, 0xb8, 0xa6, 0xda, 0x5d, 0x2a);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Av1VldProfile1</b>
		/// </summary>
		public static Guid Av1VldProfile1 { get => _av1VldProfile1; }
		internal static readonly Guid _av1VldProfile1 = new (0x6936ff0f, 0x45b1, 0x4163, 0x9c, 0xc1, 0x64, 0x6e, 0xf6, 0x94, 0x61, 0x08);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Av1VldProfile2</b>
		/// </summary>
		public static Guid Av1VldProfile2 { get => _av1VldProfile2; }
		internal static readonly Guid _av1VldProfile2 = new (0x0c5f2aa1, 0xe541, 0x4089, 0xbb, 0x7b, 0x98, 0x11, 0x0a, 0x19, 0xd7, 0xc8);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Av1Vld12BitProfile2</b>
		/// </summary>
		public static Guid Av1Vld12BitProfile2 { get => _av1Vld12BitProfile2; }
		internal static readonly Guid _av1Vld12BitProfile2 = new (0x17127009, 0xa00f, 0x4ce1, 0x99, 0x4e, 0xbf, 0x40, 0x81, 0xf6, 0xf3, 0xf0);
		/// <summary>
		/// <b>D3D11_DECODER_PROFILE_Av1Vld12BitProfile2420</b>
		/// </summary>
		public static Guid Av1Vld12BitProfile2420 { get => _av1Vld12BitProfile2420; }
		internal static readonly Guid _av1Vld12BitProfile2420 = new (0x2d80bed6, 0x9cac, 0x4835, 0x9e, 0x91, 0x32, 0x7b, 0xbc, 0x4f, 0x9e, 0xe8);

	}

	/// <summary>
	/// <b>D3D11_CryptoTypeAes128Ctr</b>
	/// </summary>
	public static Guid CryptoTypeAes128Ctr { get => _cryptoTypeAes128Ctr; }
	internal static readonly Guid _cryptoTypeAes128Ctr = new (0x9b6bd711, 0x4f74, 0x41c9, 0x9e, 0x7b, 0xb, 0xe2, 0xd7, 0xd9, 0x3b, 0x4f);
	/// <summary>
	/// <b>D3D11_DecoderEncryptionHwCenc</b>
	/// </summary>
	public static Guid DecoderEncryptionHwCenc { get => _decoderEncryptionHwCenc; }
	internal static readonly Guid _decoderEncryptionHwCenc = new (0x89d6ac4f, 0x9f2, 0x4229, 0xb2, 0xcd, 0x37, 0x74, 0xa, 0x6d, 0xfd, 0x81);
	/// <summary>
	/// <b>D3D11_DecoderBitstreamEncryptionTypeCenc</b>
	/// </summary>
	public static Guid DecoderBitstreamEncryptionTypeCenc { get => _decoderBitstreamEncryptionTypeCenc; }
	internal static readonly Guid _decoderBitstreamEncryptionTypeCenc = new (0xb0405235, 0xc13d, 0x44f2, 0x9a, 0xe5, 0xdd, 0x48, 0xe0, 0x8e, 0x5b, 0x67);
	/// <summary>
	/// <b>D3D11_DecoderBitstreamEncryptionTypeCbcs</b>
	/// </summary>
	public static Guid DecoderBitstreamEncryptionTypeCbcs { get => _decoderBitstreamEncryptionTypeCbcs; }
	internal static readonly Guid _decoderBitstreamEncryptionTypeCbcs = new (0x422d9319, 0x9d21, 0x4bb7, 0x93, 0x71, 0xfa, 0xf5, 0xa8, 0x2c, 0x3e, 0x04);
	/// <summary>
	/// <b>D3D11_KeyExchangeHwProtection</b>
	/// </summary>
	public static Guid KeyExchangeHwProtection { get => _keyExchangeHwProtection; }
	internal static readonly Guid _keyExchangeHwProtection = new (0xb1170d8a, 0x628d, 0x4da3, 0xad, 0x3b, 0x82, 0xdd, 0xb0, 0x8b, 0x49, 0x70);

	/// <summary>
	/// 
	/// </summary>
	public static class AuthenticatedQuery {
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_PROTECTION</b>
		/// </summary>
		public static Guid Protection { get => _protection; }
		internal static readonly Guid _protection = new (0xa84eb584, 0xc495, 0x48aa, 0xb9, 0x4d, 0x8b, 0xd2, 0xd6, 0xfb, 0xce, 0x5);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE</b>
		/// </summary>
		public static Guid ChannelType { get => _channelType; }
		internal static readonly Guid _channelType = new (0xbc1b18a5, 0xb1fb, 0x42ab, 0xbd, 0x94, 0xb5, 0x82, 0x8b, 0x4b, 0xf7, 0xbe);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE</b>
		/// </summary>
		public static Guid DeviceHandle { get => _deviceHandle; }
		internal static readonly Guid _deviceHandle = new (0xec1c539d, 0x8cff, 0x4e2a, 0xbc, 0xc4, 0xf5, 0x69, 0x2f, 0x99, 0xf4, 0x80);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION</b>
		/// </summary>
		public static Guid CryptoSession { get => _cryptoSession; }
		internal static readonly Guid _cryptoSession = new (0x2634499e, 0xd018, 0x4d74, 0xac, 0x17, 0x7f, 0x72, 0x40, 0x59, 0x52, 0x8d);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT</b>
		/// </summary>
		public static Guid RestrictedSharedResourceProcessCount { get => _restrictedSharedResourceProcessCount; }
		internal static readonly Guid _restrictedSharedResourceProcessCount = new (0xdb207b3, 0x9450, 0x46a6, 0x82, 0xde, 0x1b, 0x96, 0xd4, 0x4f, 0x9c, 0xf2);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS</b>
		/// </summary>
		public static Guid RestrictedSharedResourceProcess { get => _restrictedSharedResourceProcess; }
		internal static readonly Guid _restrictedSharedResourceProcess = new (0x649bbadb, 0xf0f4, 0x4639, 0xa1, 0x5b, 0x24, 0x39, 0x3f, 0xc3, 0xab, 0xac);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT</b>
		/// </summary>
		public static Guid UnrestrictedProtectedSharedResourceCount { get => _unrestrictedProtectedSharedResourceCount; }
		internal static readonly Guid _unrestrictedProtectedSharedResourceCount = new (0x12f0bd6, 0xe662, 0x4474, 0xbe, 0xfd, 0xaa, 0x53, 0xe5, 0x14, 0x3c, 0x6d);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT</b>
		/// </summary>
		public static Guid OutputIdCount { get => _outputIdCount; }
		internal static readonly Guid _outputIdCount = new (0x2c042b5e, 0x8c07, 0x46d5, 0xaa, 0xbe, 0x8f, 0x75, 0xcb, 0xad, 0x4c, 0x31);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_OUTPUT_ID</b>
		/// </summary>
		public static Guid OutputId { get => _outputId; }
		internal static readonly Guid _outputId = new (0x839ddca3, 0x9b4e, 0x41e4, 0xb0, 0x53, 0x89, 0x2b, 0xd2, 0xa1, 0x1e, 0xe7);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTES</b>
		/// </summary>
		public static Guid AccessibilityAttributes { get => _accessibilityAttributes; }
		internal static readonly Guid _accessibilityAttributes = new (0x6214d9d2, 0x432c, 0x4abb, 0x9f, 0xce, 0x21, 0x6e, 0xea, 0x26, 0x9e, 0x3b);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNT</b>
		/// </summary>
		public static Guid EncryptionWhenAccessibleGuidCount { get => _encryptionWhenAccessibleGuidCount; }
		internal static readonly Guid _encryptionWhenAccessibleGuidCount = new (0xb30f7066, 0x203c, 0x4b07, 0x93, 0xfc, 0xce, 0xaa, 0xfd, 0x61, 0x24, 0x1e);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID</b>
		/// </summary>
		public static Guid EncryptionWhenAccessibleGuid { get => _encryptionWhenAccessibleGuid; }
		internal static readonly Guid _encryptionWhenAccessibleGuid = new (0xf83a5958, 0xe986, 0x4bda, 0xbe, 0xb0, 0x41, 0x1f, 0x6a, 0x7a, 0x1, 0xb7);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLE</b>
		/// </summary>
		public static Guid CurrentEncryptionWhenAccessible { get => _currentEncryptionWhenAccessible; }
		internal static readonly Guid _currentEncryptionWhenAccessible = new (0xec1791c7, 0xdad3, 0x4f15, 0x9e, 0xc3, 0xfa, 0xa9, 0x3d, 0x60, 0xd4, 0xf0);

	}

	/// <summary>
	/// 
	/// </summary>
	public static class AuthenticatedConfigure {

		/// <summary>
		/// <b>D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE</b>
		/// </summary>
		public static Guid Initialize { get => _initialize; }
		internal static readonly Guid _initialize = new (0x6114bdb, 0x3523, 0x470a, 0x8d, 0xca, 0xfb, 0xc2, 0x84, 0x51, 0x54, 0xf0);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_CONFIGURE_PROTECTION</b>
		/// </summary>
		public static Guid Protection { get => _protection; }
		internal static readonly Guid _protection = new (0x50455658, 0x3f47, 0x4362, 0xbf, 0x99, 0xbf, 0xdf, 0xcd, 0xe9, 0xed, 0x29);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION</b>
		/// </summary>
		public static Guid CryptoSession { get => _cryptoSession; }
		internal static readonly Guid _cryptoSession = new (0x6346cc54, 0x2cfc, 0x4ad4, 0x82, 0x24, 0xd1, 0x58, 0x37, 0xde, 0x77, 0x0);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE</b>
		/// </summary>
		public static Guid SharedResource { get => _sharedResource; }
		internal static readonly Guid _sharedResource = new (0x772d047, 0x1b40, 0x48e8, 0x9c, 0xa6, 0xb5, 0xf5, 0x10, 0xde, 0x9f, 0x1);
		/// <summary>
		/// <b>D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLE</b>
		/// </summary>
		public static Guid EncryptionWhenAccessible { get => _encryptionWhenAccessible; }
		internal static readonly Guid _encryptionWhenAccessible = new (0x41fff286, 0x6ae0, 0x4d43, 0x9d, 0x55, 0xa4, 0x6e, 0x9e, 0xfd, 0x15, 0x8a);

	}

	/// <summary>
	/// <b>D3D11_KEY_EXCHANGE_RSAES_OAEP</b>
	/// </summary>
	public static Guid KeyExchangeRsaesOaep { get => _keyExchangeRsaesOaep; }
	internal static readonly Guid _keyExchangeRsaesOaep = new (0xc1949895, 0xd72a, 0x4a1d, 0x8e, 0x5d, 0xed, 0x85, 0x7d, 0x17, 0x15, 0x20);

}
