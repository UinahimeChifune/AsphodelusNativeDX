using System;

namespace AsphodelusNative.WIC;

/// <summary>
/// 
/// </summary>
public static class GUID {

	/// <summary>
	/// <b>GUID_VendorMicrosoft</b>
	/// </summary>
	public static Guid VendorMicrosoft { get => _vendorMicrosoft; }
	internal static readonly Guid _vendorMicrosoft = new (0xf0e749ca, 0xedef, 0x4589, 0xa7, 0x3a, 0xee, 0xe, 0x62, 0x6a, 0x2a, 0x2b);
	/// <summary>
	/// <b>GUID_VendorMicrosoftBuiltIn</b>
	/// </summary>
	public static Guid VendorMicrosoftBuiltIn { get => _vendorMicrosoftBuiltIn; }
	internal static readonly Guid _vendorMicrosoftBuiltIn = new (0x257a30fd, 0x6b6, 0x462b, 0xae, 0xa4, 0x63, 0xf7, 0xb, 0x86, 0xe5, 0x33);

	/// <summary>
	/// 
	/// </summary>
	public static class Container {

		/// <summary>
		/// <b>GUID_ContainerFormatBmp</b>
		/// </summary>
		public static Guid FormatBmp { get => _formatBmp; }
		internal static readonly Guid _formatBmp = new (0x0af1d87e, 0xfcfe, 0x4188, 0xbd, 0xeb, 0xa7, 0x90, 0x64, 0x71, 0xcb, 0xe3);
		/// <summary>
		/// <b>GUID_ContainerFormatPng</b>
		/// </summary>
		public static Guid FormatPng { get => _formatPng; }
		internal static readonly Guid _formatPng = new (0x1b7cfaf4, 0x713f, 0x473c, 0xbb, 0xcd, 0x61, 0x37, 0x42, 0x5f, 0xae, 0xaf);
		/// <summary>
		/// <b>GUID_ContainerFormatIco</b>
		/// </summary>
		public static Guid FormatIco { get => _formatIco; }
		internal static readonly Guid _formatIco = new (0xa3a860c4, 0x338f, 0x4c17, 0x91, 0x9a, 0xfb, 0xa4, 0xb5, 0x62, 0x8f, 0x21);
		/// <summary>
		/// <b>GUID_ContainerFormatJpeg</b>
		/// </summary>
		public static Guid FormatJpeg { get => _formatJpeg; }
		internal static readonly Guid _formatJpeg = new (0x19e4a5aa, 0x5662, 0x4fc5, 0xa0, 0xc0, 0x17, 0x58, 0x02, 0x8e, 0x10, 0x57);
		/// <summary>
		/// <b>GUID_ContainerFormatTiff</b>
		/// </summary>
		public static Guid FormatTiff { get => _formatTiff; }
		internal static readonly Guid _formatTiff = new (0x163bcc30, 0xe2e9, 0x4f0b, 0x96, 0x1d, 0xa3, 0xe9, 0xfd, 0xb7, 0x88, 0xa3);
		/// <summary>
		/// <b>GUID_ContainerFormatGif</b>
		/// </summary>
		public static Guid FormatGif { get => _formatGif; }
		internal static readonly Guid _formatGif = new (0x1f8a5601, 0x7d4d, 0x4cbd, 0x9c, 0x82, 0x1b, 0xc8, 0xd4, 0xee, 0xb9, 0xa5);
		/// <summary>
		/// <b>GUID_ContainerFormatWmp</b>
		/// </summary>
		public static Guid FormatWmp { get => _formatWmp; }
		internal static readonly Guid _formatWmp = new (0x57a37caa, 0x367a, 0x4540, 0x91, 0x6b, 0xf1, 0x83, 0xc5, 0x09, 0x3a, 0x4b);
		/// <summary>
		/// <b>GUID_ContainerFormatDds</b>
		/// </summary>
		public static Guid FormatDds { get => _formatDds; }
		internal static readonly Guid _formatDds = new (0x9967cb95, 0x2e85, 0x4ac8, 0x8c, 0xa2, 0x83, 0xd7, 0xcc, 0xd4, 0x25, 0xc9);
		/// <summary>
		/// <b>GUID_ContainerFormatAdng</b>
		/// </summary>
		public static Guid FormatAdng { get => _formatAdng; }
		internal static readonly Guid _formatAdng = new (0xf3ff6d0d, 0x38c0, 0x41c4, 0xb1, 0xfe, 0x1f, 0x38, 0x24, 0xf1, 0x7b, 0x84);
		/// <summary>
		/// <b>GUID_ContainerFormatHeif</b>
		/// </summary>
		public static Guid FormatHeif { get => _formatHeif; }
		internal static readonly Guid _formatHeif = new (0xe1e62521, 0x6787, 0x405b, 0xa3, 0x39, 0x50, 0x07, 0x15, 0xb5, 0x76, 0x3f);
		/// <summary>
		/// <b>GUID_ContainerFormatWebp</b>
		/// </summary>
		public static Guid FormatWebp { get => _formatWebp; }
		internal static readonly Guid _formatWebp = new (0xe094b0e2, 0x67f2, 0x45b3, 0xb0, 0xea, 0x11, 0x53, 0x37, 0xca, 0x7c, 0xf3);
		/// <summary>
		/// <b>GUID_ContainerFormatRaw</b>
		/// </summary>
		public static Guid FormatRaw { get => _formatRaw; }
		internal static readonly Guid _formatRaw = new (0xfe99ce60, 0xf19c, 0x433c, 0xa3, 0xae, 0x00, 0xac, 0xef, 0xa9, 0xca, 0x21);

	}

	/// <summary>
	/// 
	/// </summary>
	public static class PixelFormat {

		/// <summary>
		/// <b>GUID_WICPixelFormatDontCare</b>
		/// </summary>
		public static Guid FormatDontCare { get => _formatDontCare; }
		internal static readonly Guid _formatDontCare = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x00);
		/// <summary>
		/// <b>GUID_WICPixelFormat1bppIndexed</b>
		/// </summary>
		public static Guid Format1bppIndexed { get => _format1bppIndexed; }
		internal static readonly Guid _format1bppIndexed = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x01);
		/// <summary>
		/// <b>GUID_WICPixelFormat2bppIndexed</b>
		/// </summary>
		public static Guid Format2bppIndexed { get => _format2bppIndexed; }
		internal static readonly Guid _format2bppIndexed = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x02);
		/// <summary>
		/// <b>GUID_WICPixelFormat4bppIndexed</b>
		/// </summary>
		public static Guid Format4bppIndexed { get => _format4bppIndexed; }
		internal static readonly Guid _format4bppIndexed = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x03);
		/// <summary>
		/// <b>GUID_WICPixelFormat8bppIndexed</b>
		/// </summary>
		public static Guid Format8bppIndexed { get => _format8bppIndexed; }
		internal static readonly Guid _format8bppIndexed = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x04);
		/// <summary>
		/// <b>GUID_WICPixelFormatBlackWhite</b>
		/// </summary>
		public static Guid FormatBlackWhite { get => _formatBlackWhite; }
		internal static readonly Guid _formatBlackWhite = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x05);
		/// <summary>
		/// <b>GUID_WICPixelFormat2bppGray</b>
		/// </summary>
		public static Guid Format2bppGray { get => _format2bppGray; }
		internal static readonly Guid _format2bppGray = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x06);
		/// <summary>
		/// <b>GUID_WICPixelFormat4bppGray</b>
		/// </summary>
		public static Guid Format4bppGray { get => _format4bppGray; }
		internal static readonly Guid _format4bppGray = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x07);
		/// <summary>
		/// <b>GUID_WICPixelFormat8bppGray</b>
		/// </summary>
		public static Guid Format8bppGray { get => _format8bppGray; }
		internal static readonly Guid _format8bppGray = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x08);
		/// <summary>
		/// <b>GUID_WICPixelFormat8bppAlpha</b>
		/// </summary>
		public static Guid Format8bppAlpha { get => _format8bppAlpha; }
		internal static readonly Guid _format8bppAlpha = new (0xe6cd0116, 0xeeba, 0x4161, 0xaa, 0x85, 0x27, 0xdd, 0x9f, 0xb3, 0xa8, 0x95);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppBGR555</b>
		/// </summary>
		public static Guid Format16bppBGR555 { get => _format16bppBGR555; }
		internal static readonly Guid _format16bppBGR555 = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x09);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppBGR565</b>
		/// </summary>
		public static Guid Format16bppBGR565 { get => _format16bppBGR565; }
		internal static readonly Guid _format16bppBGR565 = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0a);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppBGRA5551</b>
		/// </summary>
		public static Guid Format16bppBGRA5551 { get => _format16bppBGRA5551; }
		internal static readonly Guid _format16bppBGRA5551 = new (0x05ec7c2b, 0xf1e6, 0x4961, 0xad, 0x46, 0xe1, 0xcc, 0x81, 0x0a, 0x87, 0xd2);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppGray</b>
		/// </summary>
		public static Guid Format16bppGray { get => _format16bppGray; }
		internal static readonly Guid _format16bppGray = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0b);
		/// <summary>
		/// <b>GUID_WICPixelFormat24bppBGR</b>
		/// </summary>
		public static Guid Format24bppBGR { get => _format24bppBGR; }
		internal static readonly Guid _format24bppBGR = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0c);
		/// <summary>
		/// <b>GUID_WICPixelFormat24bppRGB</b>
		/// </summary>
		public static Guid Format24bppRGB { get => _format24bppRGB; }
		internal static readonly Guid _format24bppRGB = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0d);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppBGR</b>
		/// </summary>
		public static Guid Format32bppBGR { get => _format32bppBGR; }
		internal static readonly Guid _format32bppBGR = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0e);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppBGRA</b>
		/// </summary>
		public static Guid Format32bppBGRA { get => _format32bppBGRA; }
		internal static readonly Guid _format32bppBGRA = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0f);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppPBGRA</b>
		/// </summary>
		public static Guid Format32bppPBGRA { get => _format32bppPBGRA; }
		internal static readonly Guid _format32bppPBGRA = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x10);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppGrayFloat</b>
		/// </summary>
		public static Guid Format32bppGrayFloat { get => _format32bppGrayFloat; }
		internal static readonly Guid _format32bppGrayFloat = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x11);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppRGB</b>
		/// </summary>
		public static Guid Format32bppRGB { get => _format32bppRGB; }
		internal static readonly Guid _format32bppRGB = new (0xd98c6b95, 0x3efe, 0x47d6, 0xbb, 0x25, 0xeb, 0x17, 0x48, 0xab, 0x0c, 0xf1);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppRGBA</b>
		/// </summary>
		public static Guid Format32bppRGBA { get => _format32bppRGBA; }
		internal static readonly Guid _format32bppRGBA = new (0xf5c7ad2d, 0x6a8d, 0x43dd, 0xa7, 0xa8, 0xa2, 0x99, 0x35, 0x26, 0x1a, 0xe9);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppPRGBA</b>
		/// </summary>
		public static Guid Format32bppPRGBA { get => _format32bppPRGBA; }
		internal static readonly Guid _format32bppPRGBA = new (0x3cc4a650, 0xa527, 0x4d37, 0xa9, 0x16, 0x31, 0x42, 0xc7, 0xeb, 0xed, 0xba);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bppRGB</b>
		/// </summary>
		public static Guid Format48bppRGB { get => _format48bppRGB; }
		internal static readonly Guid _format48bppRGB = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x15);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bppBGR</b>
		/// </summary>
		public static Guid Format48bppBGR { get => _format48bppBGR; }
		internal static readonly Guid _format48bppBGR = new (0xe605a384, 0xb468, 0x46ce, 0xbb, 0x2e, 0x36, 0xf1, 0x80, 0xe6, 0x43, 0x13);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppRGB</b>
		/// </summary>
		public static Guid Format64bppRGB { get => _format64bppRGB; }
		internal static readonly Guid _format64bppRGB = new (0xa1182111, 0x186d, 0x4d42, 0xbc, 0x6a, 0x9c, 0x83, 0x03, 0xa8, 0xdf, 0xf9);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppRGBA</b>
		/// </summary>
		public static Guid Format64bppRGBA { get => _format64bppRGBA; }
		internal static readonly Guid _format64bppRGBA = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x16);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppBGRA</b>
		/// </summary>
		public static Guid Format64bppBGRA { get => _format64bppBGRA; }
		internal static readonly Guid _format64bppBGRA = new (0x1562ff7c, 0xd352, 0x46f9, 0x97, 0x9e, 0x42, 0x97, 0x6b, 0x79, 0x22, 0x46);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppPRGBA</b>
		/// </summary>
		public static Guid Format64bppPRGBA { get => _format64bppPRGBA; }
		internal static readonly Guid _format64bppPRGBA = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x17);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppPBGRA</b>
		/// </summary>
		public static Guid Format64bppPBGRA { get => _format64bppPBGRA; }
		internal static readonly Guid _format64bppPBGRA = new (0x8c518e8e, 0xa4ec, 0x468b, 0xae, 0x70, 0xc9, 0xa3, 0x5a, 0x9c, 0x55, 0x30);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppGrayFixedPoint</b>
		/// </summary>
		public static Guid Format16bppGrayFixedPoint { get => _format16bppGrayFixedPoint; }
		internal static readonly Guid _format16bppGrayFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x13);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppBGR101010</b>
		/// </summary>
		public static Guid Format32bppBGR101010 { get => _format32bppBGR101010; }
		internal static readonly Guid _format32bppBGR101010 = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x14);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bppRGBFixedPoint</b>
		/// </summary>
		public static Guid Format48bppRGBFixedPoint { get => _format48bppRGBFixedPoint; }
		internal static readonly Guid _format48bppRGBFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x12);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bppBGRFixedPoint</b>
		/// </summary>
		public static Guid Format48bppBGRFixedPoint { get => _format48bppBGRFixedPoint; }
		internal static readonly Guid _format48bppBGRFixedPoint = new (0x49ca140e, 0xcab6, 0x493b, 0x9d, 0xdf, 0x60, 0x18, 0x7c, 0x37, 0x53, 0x2a);
		/// <summary>
		/// <b>GUID_WICPixelFormat96bppRGBFixedPoint</b>
		/// </summary>
		public static Guid Format96bppRGBFixedPoint { get => _format96bppRGBFixedPoint; }
		internal static readonly Guid _format96bppRGBFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x18);
		/// <summary>
		/// <b>GUID_WICPixelFormat96bppRGBFloat</b>
		/// </summary>
		public static Guid Format96bppRGBFloat { get => _format96bppRGBFloat; }
		internal static readonly Guid _format96bppRGBFloat = new (0xe3fed78f, 0xe8db, 0x4acf, 0x84, 0xc1, 0xe9, 0x7f, 0x61, 0x36, 0xb3, 0x27);
		/// <summary>
		/// <b>GUID_WICPixelFormat128bppRGBAFloat</b>
		/// </summary>
		public static Guid Format128bppRGBAFloat { get => _format128bppRGBAFloat; }
		internal static readonly Guid _format128bppRGBAFloat = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x19);
		/// <summary>
		/// <b>GUID_WICPixelFormat128bppPRGBAFloat</b>
		/// </summary>
		public static Guid Format128bppPRGBAFloat { get => _format128bppPRGBAFloat; }
		internal static readonly Guid _format128bppPRGBAFloat = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1a);
		/// <summary>
		/// <b>GUID_WICPixelFormat128bppRGBFloat</b>
		/// </summary>
		public static Guid Format128bppRGBFloat { get => _format128bppRGBFloat; }
		internal static readonly Guid _format128bppRGBFloat = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1b);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppCMYK</b>
		/// </summary>
		public static Guid Format32bppCMYK { get => _format32bppCMYK; }
		internal static readonly Guid _format32bppCMYK = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1c);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppRGBAFixedPoint</b>
		/// </summary>
		public static Guid Format64bppRGBAFixedPoint { get => _format64bppRGBAFixedPoint; }
		internal static readonly Guid _format64bppRGBAFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1d);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppBGRAFixedPoint</b>
		/// </summary>
		public static Guid Format64bppBGRAFixedPoint { get => _format64bppBGRAFixedPoint; }
		internal static readonly Guid _format64bppBGRAFixedPoint = new (0x356de33c, 0x54d2, 0x4a23, 0xbb, 0x4, 0x9b, 0x7b, 0xf9, 0xb1, 0xd4, 0x2d);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppRGBFixedPoint</b>
		/// </summary>
		public static Guid Format64bppRGBFixedPoint { get => _format64bppRGBFixedPoint; }
		internal static readonly Guid _format64bppRGBFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x40);
		/// <summary>
		/// <b>GUID_WICPixelFormat128bppRGBAFixedPoint</b>
		/// </summary>
		public static Guid Format128bppRGBAFixedPoint { get => _format128bppRGBAFixedPoint; }
		internal static readonly Guid _format128bppRGBAFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1e);
		/// <summary>
		/// <b>GUID_WICPixelFormat128bppRGBFixedPoint</b>
		/// </summary>
		public static Guid Format128bppRGBFixedPoint { get => _format128bppRGBFixedPoint; }
		internal static readonly Guid _format128bppRGBFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x41);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppRGBAHalf</b>
		/// </summary>
		public static Guid Format64bppRGBAHalf { get => _format64bppRGBAHalf; }
		internal static readonly Guid _format64bppRGBAHalf = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3a);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppPRGBAHalf</b>
		/// </summary>
		public static Guid Format64bppPRGBAHalf { get => _format64bppPRGBAHalf; }
		internal static readonly Guid _format64bppPRGBAHalf = new (0x58ad26c2, 0xc623, 0x4d9d, 0xb3, 0x20, 0x38, 0x7e, 0x49, 0xf8, 0xc4, 0x42);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppRGBHalf</b>
		/// </summary>
		public static Guid Format64bppRGBHalf { get => _format64bppRGBHalf; }
		internal static readonly Guid _format64bppRGBHalf = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x42);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bppRGBHalf</b>
		/// </summary>
		public static Guid Format48bppRGBHalf { get => _format48bppRGBHalf; }
		internal static readonly Guid _format48bppRGBHalf = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3b);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppRGBE</b>
		/// </summary>
		public static Guid Format32bppRGBE { get => _format32bppRGBE; }
		internal static readonly Guid _format32bppRGBE = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3d);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppGrayHalf</b>
		/// </summary>
		public static Guid Format16bppGrayHalf { get => _format16bppGrayHalf; }
		internal static readonly Guid _format16bppGrayHalf = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3e);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppGrayFixedPoint</b>
		/// </summary>
		public static Guid Format32bppGrayFixedPoint { get => _format32bppGrayFixedPoint; }
		internal static readonly Guid _format32bppGrayFixedPoint = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3f);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppRGBA1010102</b>
		/// </summary>
		public static Guid Format32bppRGBA1010102 { get => _format32bppRGBA1010102; }
		internal static readonly Guid _format32bppRGBA1010102 = new (0x25238d72, 0xfcf9, 0x4522, 0xb5, 0x14, 0x55, 0x78, 0xe5, 0xad, 0x55, 0xe0);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppRGBA1010102XR</b>
		/// </summary>
		public static Guid Format32bppRGBA1010102XR { get => _format32bppRGBA1010102XR; }
		internal static readonly Guid _format32bppRGBA1010102XR = new (0x00de6b9a, 0xc101, 0x434b, 0xb5, 0x02, 0xd0, 0x16, 0x5e, 0xe1, 0x12, 0x2c);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppR10G10B10A2</b>
		/// </summary>
		public static Guid Format32bppR10G10B10A2 { get => _format32bppR10G10B10A2; }
		internal static readonly Guid _format32bppR10G10B10A2 = new (0x604e1bb5, 0x8a3c, 0x4b65, 0xb1, 0x1c, 0xbc, 0x0b, 0x8d, 0xd7, 0x5b, 0x7f);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bppR10G10B10A2HDR10</b>
		/// </summary>
		public static Guid Format32bppR10G10B10A2HDR10 { get => _format32bppR10G10B10A2HDR10; }
		internal static readonly Guid _format32bppR10G10B10A2HDR10 = new (0x9c215c5d, 0x1acc, 0x4f0e, 0xa4, 0xbc, 0x70, 0xfb, 0x3a, 0xe8, 0xfd, 0x28);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bppCMYK</b>
		/// </summary>
		public static Guid Format64bppCMYK { get => _format64bppCMYK; }
		internal static readonly Guid _format64bppCMYK = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1f);
		/// <summary>
		/// <b>GUID_WICPixelFormat24bpp3Channels</b>
		/// </summary>
		public static Guid Format24bpp3Channels { get => _format24bpp3Channels; }
		internal static readonly Guid _format24bpp3Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x20);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bpp4Channels</b>
		/// </summary>
		public static Guid Format32bpp4Channels { get => _format32bpp4Channels; }
		internal static readonly Guid _format32bpp4Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x21);
		/// <summary>
		/// <b>GUID_WICPixelFormat40bpp5Channels</b>
		/// </summary>
		public static Guid Format40bpp5Channels { get => _format40bpp5Channels; }
		internal static readonly Guid _format40bpp5Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x22);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bpp6Channels</b>
		/// </summary>
		public static Guid Format48bpp6Channels { get => _format48bpp6Channels; }
		internal static readonly Guid _format48bpp6Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x23);
		/// <summary>
		/// <b>GUID_WICPixelFormat56bpp7Channels</b>
		/// </summary>
		public static Guid Format56bpp7Channels { get => _format56bpp7Channels; }
		internal static readonly Guid _format56bpp7Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x24);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bpp8Channels</b>
		/// </summary>
		public static Guid Format64bpp8Channels { get => _format64bpp8Channels; }
		internal static readonly Guid _format64bpp8Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x25);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bpp3Channels</b>
		/// </summary>
		public static Guid Format48bpp3Channels { get => _format48bpp3Channels; }
		internal static readonly Guid _format48bpp3Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x26);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bpp4Channels</b>
		/// </summary>
		public static Guid Format64bpp4Channels { get => _format64bpp4Channels; }
		internal static readonly Guid _format64bpp4Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x27);
		/// <summary>
		/// <b>GUID_WICPixelFormat80bpp5Channels</b>
		/// </summary>
		public static Guid Format80bpp5Channels { get => _format80bpp5Channels; }
		internal static readonly Guid _format80bpp5Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x28);
		/// <summary>
		/// <b>GUID_WICPixelFormat96bpp6Channels</b>
		/// </summary>
		public static Guid Format96bpp6Channels { get => _format96bpp6Channels; }
		internal static readonly Guid _format96bpp6Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x29);
		/// <summary>
		/// <b>GUID_WICPixelFormat112bpp7Channels</b>
		/// </summary>
		public static Guid Format112bpp7Channels { get => _format112bpp7Channels; }
		internal static readonly Guid _format112bpp7Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2a);
		/// <summary>
		/// <b>GUID_WICPixelFormat128bpp8Channels</b>
		/// </summary>
		public static Guid Format128bpp8Channels { get => _format128bpp8Channels; }
		internal static readonly Guid _format128bpp8Channels = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2b);
		/// <summary>
		/// <b>GUID_WICPixelFormat40bppCMYKAlpha</b>
		/// </summary>
		public static Guid Format40bppCMYKAlpha { get => _format40bppCMYKAlpha; }
		internal static readonly Guid _format40bppCMYKAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2c);
		/// <summary>
		/// <b>GUID_WICPixelFormat80bppCMYKAlpha</b>
		/// </summary>
		public static Guid Format80bppCMYKAlpha { get => _format80bppCMYKAlpha; }
		internal static readonly Guid _format80bppCMYKAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2d);
		/// <summary>
		/// <b>GUID_WICPixelFormat32bpp3ChannelsAlpha</b>
		/// </summary>
		public static Guid Format32bpp3ChannelsAlpha { get => _format32bpp3ChannelsAlpha; }
		internal static readonly Guid _format32bpp3ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2e);
		/// <summary>
		/// <b>GUID_WICPixelFormat40bpp4ChannelsAlpha</b>
		/// </summary>
		public static Guid Format40bpp4ChannelsAlpha { get => _format40bpp4ChannelsAlpha; }
		internal static readonly Guid _format40bpp4ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2f);
		/// <summary>
		/// <b>GUID_WICPixelFormat48bpp5ChannelsAlpha</b>
		/// </summary>
		public static Guid Format48bpp5ChannelsAlpha { get => _format48bpp5ChannelsAlpha; }
		internal static readonly Guid _format48bpp5ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x30);
		/// <summary>
		/// <b>GUID_WICPixelFormat56bpp6ChannelsAlpha</b>
		/// </summary>
		public static Guid Format56bpp6ChannelsAlpha { get => _format56bpp6ChannelsAlpha; }
		internal static readonly Guid _format56bpp6ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x31);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bpp7ChannelsAlpha</b>
		/// </summary>
		public static Guid Format64bpp7ChannelsAlpha { get => _format64bpp7ChannelsAlpha; }
		internal static readonly Guid _format64bpp7ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x32);
		/// <summary>
		/// <b>GUID_WICPixelFormat72bpp8ChannelsAlpha</b>
		/// </summary>
		public static Guid Format72bpp8ChannelsAlpha { get => _format72bpp8ChannelsAlpha; }
		internal static readonly Guid _format72bpp8ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x33);
		/// <summary>
		/// <b>GUID_WICPixelFormat64bpp3ChannelsAlpha</b>
		/// </summary>
		public static Guid Format64bpp3ChannelsAlpha { get => _format64bpp3ChannelsAlpha; }
		internal static readonly Guid _format64bpp3ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x34);
		/// <summary>
		/// <b>GUID_WICPixelFormat80bpp4ChannelsAlpha</b>
		/// </summary>
		public static Guid Format80bpp4ChannelsAlpha { get => _format80bpp4ChannelsAlpha; }
		internal static readonly Guid _format80bpp4ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x35);
		/// <summary>
		/// <b>GUID_WICPixelFormat96bpp5ChannelsAlpha</b>
		/// </summary>
		public static Guid Format96bpp5ChannelsAlpha { get => _format96bpp5ChannelsAlpha; }
		internal static readonly Guid _format96bpp5ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x36);
		/// <summary>
		/// <b>GUID_WICPixelFormat112bpp6ChannelsAlpha</b>
		/// </summary>
		public static Guid Format112bpp6ChannelsAlpha { get => _format112bpp6ChannelsAlpha; }
		internal static readonly Guid _format112bpp6ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x37);
		/// <summary>
		/// <b>GUID_WICPixelFormat128bpp7ChannelsAlpha</b>
		/// </summary>
		public static Guid Format128bpp7ChannelsAlpha { get => _format128bpp7ChannelsAlpha; }
		internal static readonly Guid _format128bpp7ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x38);
		/// <summary>
		/// <b>GUID_WICPixelFormat144bpp8ChannelsAlpha</b>
		/// </summary>
		public static Guid Format144bpp8ChannelsAlpha { get => _format144bpp8ChannelsAlpha; }
		internal static readonly Guid _format144bpp8ChannelsAlpha = new (0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x39);
		/// <summary>
		/// <b>GUID_WICPixelFormat8bppY</b>
		/// </summary>
		public static Guid Format8bppY { get => _format8bppY; }
		internal static readonly Guid _format8bppY = new (0x91b4db54, 0x2df9, 0x42f0, 0xb4, 0x49, 0x29, 0x09, 0xbb, 0x3d, 0xf8, 0x8e);
		/// <summary>
		/// <b>GUID_WICPixelFormat8bppCb</b>
		/// </summary>
		public static Guid Format8bppCb { get => _format8bppCb; }
		internal static readonly Guid _format8bppCb = new (0x1339f224, 0x6bfe, 0x4c3e, 0x93, 0x02, 0xe4, 0xf3, 0xa6, 0xd0, 0xca, 0x2a);
		/// <summary>
		/// <b>GUID_WICPixelFormat8bppCr</b>
		/// </summary>
		public static Guid Format8bppCr { get => _format8bppCr; }
		internal static readonly Guid _format8bppCr = new (0xb8145053, 0x2116, 0x49f0, 0x88, 0x35, 0xed, 0x84, 0x4b, 0x20, 0x5c, 0x51);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppCbCr</b>
		/// </summary>
		public static Guid Format16bppCbCr { get => _format16bppCbCr; }
		internal static readonly Guid _format16bppCbCr = new (0xff95ba6e, 0x11e0, 0x4263, 0xbb, 0x45, 0x01, 0x72, 0x1f, 0x34, 0x60, 0xa4);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppYQuantizedDctCoefficients</b>
		/// </summary>
		public static Guid Format16bppYQuantizedDctCoefficients { get => _format16bppYQuantizedDctCoefficients; }
		internal static readonly Guid _format16bppYQuantizedDctCoefficients = new (0xa355f433, 0x48e8, 0x4a42, 0x84, 0xd8, 0xe2, 0xaa, 0x26, 0xca, 0x80, 0xa4);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppCbQuantizedDctCoefficients</b>
		/// </summary>
		public static Guid Format16bppCbQuantizedDctCoefficients { get => _format16bppCbQuantizedDctCoefficients; }
		internal static readonly Guid _format16bppCbQuantizedDctCoefficients = new (0xd2c4ff61, 0x56a5, 0x49c2, 0x8b, 0x5c, 0x4c, 0x19, 0x25, 0x96, 0x48, 0x37);
		/// <summary>
		/// <b>GUID_WICPixelFormat16bppCrQuantizedDctCoefficients</b>
		/// </summary>
		public static Guid Format16bppCrQuantizedDctCoefficients { get => _format16bppCrQuantizedDctCoefficients; }
		internal static readonly Guid _format16bppCrQuantizedDctCoefficients = new (0x2fe354f0, 0x1680, 0x42d8, 0x92, 0x31, 0xe7, 0x3c, 0x05, 0x65, 0xbf, 0xc1);

	}
}

/// <summary>
/// 
/// </summary>
public static class CLSID {

	/// <summary>
	/// <b>CLSID_WICImagingFactory</b>
	/// </summary>
	public static Guid ImagingFactory { get => _imagingFactory; }
	internal static readonly Guid _imagingFactory = new (0xcacaf262, 0x9370, 0x4615, 0xa1, 0x3b, 0x9f, 0x55, 0x39, 0xda, 0x4c, 0xa);
	/// <summary>
	/// <b>CLSID_WICImagingFactory1</b>
	/// </summary>
	public static Guid ImagingFactory1 { get => _imagingFactory1; }
	internal static readonly Guid _imagingFactory1 = new (0xcacaf262, 0x9370, 0x4615, 0xa1, 0x3b, 0x9f, 0x55, 0x39, 0xda, 0x4c, 0xa);
	/// <summary>
	/// <b>CLSID_WICImagingFactory2</b>
	/// </summary>
	public static Guid ImagingFactory2 { get => _imagingFactory2; }
	internal static readonly Guid _imagingFactory2 = new (0x317d06e8, 0x5f24, 0x433d, 0xbd, 0xf7, 0x79, 0xce, 0x68, 0xd8, 0xab, 0xc2);

	/// <summary>
	/// 
	/// </summary>
	public static class Encoder {

		/// <summary>
		/// <b>CLSID_WICBmpEncoder</b>
		/// </summary>
		public static Guid BmpEncoder { get => _bmpEncoder; }
		internal static readonly Guid _bmpEncoder = new (0x69be8bb4, 0xd66d, 0x47c8, 0x86, 0x5a, 0xed, 0x15, 0x89, 0x43, 0x37, 0x82);
		/// <summary>
		/// <b>CLSID_WICPngEncoder</b>
		/// </summary>
		public static Guid PngEncoder { get => _pngEncoder; }
		internal static readonly Guid _pngEncoder = new (0x27949969, 0x876a, 0x41d7, 0x94, 0x47, 0x56, 0x8f, 0x6a, 0x35, 0xa4, 0xdc);
		/// <summary>
		/// <b>CLSID_WICJpegEncoder</b>
		/// </summary>
		public static Guid JpegEncoder { get => _jpegEncoder; }
		internal static readonly Guid _jpegEncoder = new (0x1a34f5c1, 0x4a5a, 0x46dc, 0xb6, 0x44, 0x1f, 0x45, 0x67, 0xe7, 0xa6, 0x76);
		/// <summary>
		/// <b>CLSID_WICGifEncoder</b>
		/// </summary>
		public static Guid GifEncoder { get => _gifEncoder; }
		internal static readonly Guid _gifEncoder = new (0x114f5598, 0x0b22, 0x40a0, 0x86, 0xa1, 0xc8, 0x3e, 0xa4, 0x95, 0xad, 0xbd);
		/// <summary>
		/// <b>CLSID_WICTiffEncoder</b>
		/// </summary>
		public static Guid TiffEncoder { get => _tiffEncoder; }
		internal static readonly Guid _tiffEncoder = new (0x0131be10, 0x2001, 0x4c5f, 0xa9, 0xb0, 0xcc, 0x88, 0xfa, 0xb6, 0x4c, 0xe8);
		/// <summary>
		/// <b>CLSID_WICWmpEncoder</b>
		/// </summary>
		public static Guid WmpEncoder { get => _wmpEncoder; }
		internal static readonly Guid _wmpEncoder = new (0xac4ce3cb, 0xe1c1, 0x44cd, 0x82, 0x15, 0x5a, 0x16, 0x65, 0x50, 0x9e, 0xc2);
		/// <summary>
		/// <b>CLSID_WICDdsEncoder</b>
		/// </summary>
		public static Guid DdsEncoder { get => _ddsEncoder; }
		internal static readonly Guid _ddsEncoder = new (0xa61dde94, 0x66ce, 0x4ac1, 0x88, 0x1b, 0x71, 0x68, 0x05, 0x88, 0x89, 0x5e);
		/// <summary>
		/// <b>CLSID_WICJpegQualcommPhoneEncoder</b>
		/// </summary>
		public static Guid JpegQualcommPhoneEncoder { get => _jpegQualcommPhoneEncoder; }
		internal static readonly Guid _jpegQualcommPhoneEncoder = new (0x68ed5c62, 0xf534, 0x4979, 0xb2, 0xb3, 0x68, 0x6a, 0x12, 0xb2, 0xb3, 0x4c);
		/// <summary>
		/// <b>CLSID_WICHeifEncoder</b>
		/// </summary>
		public static Guid HeifEncoder { get => _heifEncoder; }
		internal static readonly Guid _heifEncoder = new (0x0dbecec1, 0x9eb3, 0x4860, 0x9c, 0x6f, 0xdd, 0xbe, 0x86, 0x63, 0x45, 0x75);

	}

	/// <summary>
	/// 
	/// </summary>
	public static class Decoder {

		/// <summary>
		/// <b>CLSID_WICPngDecoder</b>
		/// </summary>
		public static Guid PngDecoder { get => _pngDecoder; }
		internal static readonly Guid _pngDecoder = new (0x389ea17b, 0x5078, 0x4cde, 0xb6, 0xef, 0x25, 0xc1, 0x51, 0x75, 0xc7, 0x51);
		/// <summary>
		/// <b>CLSID_WICPngDecoder1</b>
		/// </summary>
		public static Guid PngDecoder1 { get => _pngDecoder1; }
		internal static readonly Guid _pngDecoder1 = new (0x389ea17b, 0x5078, 0x4cde, 0xb6, 0xef, 0x25, 0xc1, 0x51, 0x75, 0xc7, 0x51);
		/// <summary>
		/// <b>CLSID_WICPngDecoder2</b>
		/// </summary>
		public static Guid PngDecoder2 { get => _pngDecoder2; }
		internal static readonly Guid _pngDecoder2 = new (0xe018945b, 0xaa86, 0x4008, 0x9b, 0xd4, 0x67, 0x77, 0xa1, 0xe4, 0x0c, 0x11);
		/// <summary>
		/// <b>CLSID_WICBmpDecoder</b>
		/// </summary>
		public static Guid BmpDecoder { get => _bmpDecoder; }
		internal static readonly Guid _bmpDecoder = new (0x6b462062, 0x7cbf, 0x400d, 0x9f, 0xdb, 0x81, 0x3d, 0xd1, 0x0f, 0x27, 0x78);
		/// <summary>
		/// <b>CLSID_WICIcoDecoder</b>
		/// </summary>
		public static Guid IcoDecoder { get => _icoDecoder; }
		internal static readonly Guid _icoDecoder = new (0xc61bfcdf, 0x2e0f, 0x4aad, 0xa8, 0xd7, 0xe0, 0x6b, 0xaf, 0xeb, 0xcd, 0xfe);
		/// <summary>
		/// <b>CLSID_WICJpegDecoder</b>
		/// </summary>
		public static Guid JpegDecoder { get => _jpegDecoder; }
		internal static readonly Guid _jpegDecoder = new (0x9456a480, 0xe88b, 0x43ea, 0x9e, 0x73, 0x0b, 0x2d, 0x9b, 0x71, 0xb1, 0xca);
		/// <summary>
		/// <b>CLSID_WICGifDecoder</b>
		/// </summary>
		public static Guid GifDecoder { get => _gifDecoder; }
		internal static readonly Guid _gifDecoder = new (0x381dda3c, 0x9ce9, 0x4834, 0xa2, 0x3e, 0x1f, 0x98, 0xf8, 0xfc, 0x52, 0xbe);
		/// <summary>
		/// <b>CLSID_WICTiffDecoder</b>
		/// </summary>
		public static Guid TiffDecoder { get => _tiffDecoder; }
		internal static readonly Guid _tiffDecoder = new (0xb54e85d9, 0xfe23, 0x499f, 0x8b, 0x88, 0x6a, 0xce, 0xa7, 0x13, 0x75, 0x2b);
		/// <summary>
		/// <b>CLSID_WICWmpDecoder</b>
		/// </summary>
		public static Guid WmpDecoder { get => _wmpDecoder; }
		internal static readonly Guid _wmpDecoder = new (0xa26cec36, 0x234c, 0x4950, 0xae, 0x16, 0xe3, 0x4a, 0xac, 0xe7, 0x1d, 0x0d);
		/// <summary>
		/// <b>CLSID_WICDdsDecoder</b>
		/// </summary>
		public static Guid DdsDecoder { get => _ddsDecoder; }
		internal static readonly Guid _ddsDecoder = new (0x9053699f, 0xa341, 0x429d, 0x9e, 0x90, 0xee, 0x43, 0x7c, 0xf8, 0x0c, 0x73);
		/// <summary>
		/// <b>CLSID_WICAdngDecoder</b>
		/// </summary>
		public static Guid AdngDecoder { get => _adngDecoder; }
		internal static readonly Guid _adngDecoder = new (0x981d9411, 0x909e, 0x42a7, 0x8f, 0x5d, 0xa7, 0x47, 0xff, 0x05, 0x2e, 0xdb);
		/// <summary>
		/// <b>CLSID_WICHeifDecoder</b>
		/// </summary>
		public static Guid HeifDecoder { get => _heifDecoder; }
		internal static readonly Guid _heifDecoder = new (0xe9a4a80a, 0x44fe, 0x4de4, 0x89, 0x71, 0x71, 0x50, 0xb1, 0x0a, 0x51, 0x99);
		/// <summary>
		/// <b>CLSID_WICWebpDecoder</b>
		/// </summary>
		public static Guid WebpDecoder { get => _webpDecoder; }
		internal static readonly Guid _webpDecoder = new (0x7693e886, 0x51c9, 0x4070, 0x84, 0x19, 0x9f, 0x70, 0x73, 0x8e, 0xc8, 0xfa);
		/// <summary>
		/// <b>CLSID_WICRAWDecoder</b>
		/// </summary>
		public static Guid RAWDecoder { get => _rAWDecoder; }
		internal static readonly Guid _rAWDecoder = new (0x41945702, 0x8302, 0x44a6, 0x94, 0x45, 0xac, 0x98, 0xe8, 0xaf, 0xa0, 0x86);

	}

	/// <summary>
	/// <b>CLSID_WICImagingCategories</b>
	/// </summary>
	public static Guid ImagingCategories { get => _imagingCategories; }
	internal static readonly Guid _imagingCategories = new (0xfae3d380, 0xfea4, 0x4623, 0x8c, 0x75, 0xc6, 0xb6, 0x11, 0x10, 0xb6, 0x81);
	/// <summary>
	/// <b>CLSID_WICDefaultFormatConverter</b>
	/// </summary>
	public static Guid DefaultFormatConverter { get => _defaultFormatConverter; }
	internal static readonly Guid _defaultFormatConverter = new (0x1a3f11dc, 0xb514, 0x4b17, 0x8c, 0x5f, 0x21, 0x54, 0x51, 0x38, 0x52, 0xf1);
	/// <summary>
	/// <b>CLSID_WICFormatConverterHighColor</b>
	/// </summary>
	public static Guid FormatConverterHighColor { get => _formatConverterHighColor; }
	internal static readonly Guid _formatConverterHighColor = new (0xac75d454, 0x9f37, 0x48f8, 0xb9, 0x72, 0x4e, 0x19, 0xbc, 0x85, 0x60, 0x11);
	/// <summary>
	/// <b>CLSID_WICFormatConverterNChannel</b>
	/// </summary>
	public static Guid FormatConverterNChannel { get => _formatConverterNChannel; }
	internal static readonly Guid _formatConverterNChannel = new (0xc17cabb2, 0xd4a3, 0x47d7, 0xa5, 0x57, 0x33, 0x9b, 0x2e, 0xfb, 0xd4, 0xf1);
	/// <summary>
	/// <b>CLSID_WICFormatConverterWMPhoto</b>
	/// </summary>
	public static Guid FormatConverterWMPhoto { get => _formatConverterWMPhoto; }
	internal static readonly Guid _formatConverterWMPhoto = new (0x9cb5172b, 0xd600, 0x46ba, 0xab, 0x77, 0x77, 0xbb, 0x7e, 0x3a, 0x00, 0xd9);
	/// <summary>
	/// <b>CLSID_WICPlanarFormatConverter</b>
	/// </summary>
	public static Guid PlanarFormatConverter { get => _planarFormatConverter; }
	internal static readonly Guid _planarFormatConverter = new (0x184132b8, 0x32f8, 0x4784, 0x91, 0x31, 0xdd, 0x72, 0x24, 0xb2, 0x34, 0x38);

}
