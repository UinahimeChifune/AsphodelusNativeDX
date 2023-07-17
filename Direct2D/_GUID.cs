using System;

namespace AsphodelusNative.Direct2D;

/// <summary>
/// 
/// </summary>
public static class CLSID {

	/// <summary>
	/// 
	/// </summary>
	public static class Effect {

		/// <summary>
		/// <b>CLSID_D2D12DAffineTransform</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Affine2DTransform { get => _2dAffineTransform; }
		internal static readonly Guid _2dAffineTransform = new (0x6AA97485, 0x6354, 0x4cfc, 0x90, 0x8C, 0xE4, 0xA7, 0x4F, 0x62, 0xC9, 0x6C);
		/// <summary>
		/// <b>CLSID_D2D13DPerspectiveTransform</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Perspective3DTransform { get => _3dPerspectiveTransform; }
		internal static readonly Guid _3dPerspectiveTransform = new (0xC2844D0B, 0x3D86, 0x46e7, 0x85, 0xBA, 0x52, 0x6C, 0x92, 0x40, 0xF3, 0xFB);
		/// <summary>
		/// <b>CLSID_D2D13DTransform</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Transform3D { get => _3dTransform; }
		internal static readonly Guid _3dTransform = new (0xe8467b04, 0xec61, 0x4b8a, 0xb5, 0xde, 0xd4, 0xd7, 0x3d, 0xeb, 0xea, 0x5a);
		/// <summary>
		/// <b>CLSID_D2D1ArithmeticComposite</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid ArithmeticComposite { get => _arithmeticComposite; }
		internal static readonly Guid _arithmeticComposite = new (0xfc151437, 0x049a, 0x4784, 0xa2, 0x4a, 0xf1, 0xc4, 0xda, 0xf2, 0x09, 0x87);
		/// <summary>
		/// <b>CLSID_D2D1Atlas</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Atlas { get => _atlas; }
		internal static readonly Guid _atlas = new (0x913e2be4, 0xfdcf, 0x4fe2, 0xa5, 0xf0, 0x24, 0x54, 0xf1, 0x4f, 0xf4, 0x8);
		/// <summary>
		/// <b>CLSID_D2D1BitmapSource</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid BitmapSource { get => _bitmapSource; }
		internal static readonly Guid _bitmapSource = new (0x5fb6c24d, 0xc6dd, 0x4231, 0x94, 0x4, 0x50, 0xf4, 0xd5, 0xc3, 0x25, 0x2d);
		/// <summary>
		/// <b>CLSID_D2D1Blend</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Blend { get => _blend; }
		internal static readonly Guid _blend = new (0x81c5b77b, 0x13f8, 0x4cdd, 0xad, 0x20, 0xc8, 0x90, 0x54, 0x7a, 0xc6, 0x5d);
		/// <summary>
		/// <b>CLSID_D2D1Border</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Border { get => _border; }
		internal static readonly Guid _border = new (0x2A2D49C0, 0x4ACF, 0x43c7, 0x8C, 0x6A, 0x7C, 0x4A, 0x27, 0x87, 0x4D, 0x27);
		/// <summary>
		/// <b>CLSID_D2D1Brightness</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Brightness { get => _brightness; }
		internal static readonly Guid _brightness = new (0x8cea8d1e, 0x77b0, 0x4986, 0xb3, 0xb9, 0x2f, 0x0c, 0x0e, 0xae, 0x78, 0x87);
		/// <summary>
		/// <b>CLSID_D2D1ColorManagement</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid ColorManagement { get => _colorManagement; }
		internal static readonly Guid _colorManagement = new (0x1A28524C, 0xFDD6, 0x4AA4, 0xAE, 0x8F, 0x83, 0x7E, 0xB8, 0x26, 0x7B, 0x37);
		/// <summary>
		/// <b>CLSID_D2D1ColorMatrix</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid ColorMatrix { get => _colorMatrix; }
		internal static readonly Guid _colorMatrix = new (0x921F03D6, 0x641C, 0x47DF, 0x85, 0x2D, 0xB4, 0xBB, 0x61, 0x53, 0xAE, 0x11);
		/// <summary>
		/// <b>CLSID_D2D1Composite</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Composite { get => _composite; }
		internal static readonly Guid _composite = new (0x48fc9f51, 0xf6ac, 0x48f1, 0x8b, 0x58, 0x3b, 0x28, 0xac, 0x46, 0xf7, 0x6d);
		/// <summary>
		/// <b>CLSID_D2D1ConvolveMatrix</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid ConvolveMatrix { get => _convolveMatrix; }
		internal static readonly Guid _convolveMatrix = new (0x407f8c08, 0x5533, 0x4331, 0xa3, 0x41, 0x23, 0xcc, 0x38, 0x77, 0x84, 0x3e);
		/// <summary>
		/// <b>CLSID_D2D1Crop</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Crop { get => _crop; }
		internal static readonly Guid _crop = new (0xE23F7110, 0x0E9A, 0x4324, 0xAF, 0x47, 0x6A, 0x2C, 0x0C, 0x46, 0xF3, 0x5B);
		/// <summary>
		/// <b>CLSID_D2D1DirectionalBlur</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid DirectionalBlur { get => _directionalBlur; }
		internal static readonly Guid _directionalBlur = new (0x174319a6, 0x58e9, 0x49b2, 0xbb, 0x63, 0xca, 0xf2, 0xc8, 0x11, 0xa3, 0xdb);
		/// <summary>
		/// <b>CLSID_D2D1DiscreteTransfer</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid DiscreteTransfer { get => _discreteTransfer; }
		internal static readonly Guid _discreteTransfer = new (0x90866fcd, 0x488e, 0x454b, 0xaf, 0x06, 0xe5, 0x04, 0x1b, 0x66, 0xc3, 0x6c);
		/// <summary>
		/// <b>CLSID_D2D1DisplacementMap</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid DisplacementMap { get => _displacementMap; }
		internal static readonly Guid _displacementMap = new (0xedc48364, 0x417, 0x4111, 0x94, 0x50, 0x43, 0x84, 0x5f, 0xa9, 0xf8, 0x90);
		/// <summary>
		/// <b>CLSID_D2D1DistantDiffuse</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid DistantDiffuse { get => _distantDiffuse; }
		internal static readonly Guid _distantDiffuse = new (0x3e7efd62, 0xa32d, 0x46d4, 0xa8, 0x3c, 0x52, 0x78, 0x88, 0x9a, 0xc9, 0x54);
		/// <summary>
		/// <b>CLSID_D2D1DistantSpecular</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid DistantSpecular { get => _distantSpecular; }
		internal static readonly Guid _distantSpecular = new (0x428c1ee5, 0x77b8, 0x4450, 0x8a, 0xb5, 0x72, 0x21, 0x9c, 0x21, 0xab, 0xda);
		/// <summary>
		/// <b>CLSID_D2D1DpiCompensation</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid DpiCompensation { get => _dpiCompensation; }
		internal static readonly Guid _dpiCompensation = new (0x6c26c5c7, 0x34e0, 0x46fc, 0x9c, 0xfd, 0xe5, 0x82, 0x37, 0x6, 0xe2, 0x28);
		/// <summary>
		/// <b>CLSID_D2D1Flood</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Flood { get => _flood; }
		internal static readonly Guid _flood = new (0x61c23c20, 0xae69, 0x4d8e, 0x94, 0xcf, 0x50, 0x07, 0x8d, 0xf6, 0x38, 0xf2);
		/// <summary>
		/// <b>CLSID_D2D1GammaTransfer</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid GammaTransfer { get => _gammaTransfer; }
		internal static readonly Guid _gammaTransfer = new (0x409444c4, 0xc419, 0x41a0, 0xb0, 0xc1, 0x8c, 0xd0, 0xc0, 0xa1, 0x8e, 0x42);
		/// <summary>
		/// <b>CLSID_D2D1GaussianBlur</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid GaussianBlur { get => _gaussianBlur; }
		internal static readonly Guid _gaussianBlur = new (0x1feb6d69, 0x2fe6, 0x4ac9, 0x8c, 0x58, 0x1d, 0x7f, 0x93, 0xe7, 0xa6, 0xa5);
		/// <summary>
		/// <b>CLSID_D2D1Scale</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Scale { get => _scale; }
		internal static readonly Guid _scale = new (0x9daf9369, 0x3846, 0x4d0e, 0xa4, 0x4e, 0xc, 0x60, 0x79, 0x34, 0xa5, 0xd7);
		/// <summary>
		/// <b>CLSID_D2D1Histogram</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Histogram { get => _histogram; }
		internal static readonly Guid _histogram = new (0x881db7d0, 0xf7ee, 0x4d4d, 0xa6, 0xd2, 0x46, 0x97, 0xac, 0xc6, 0x6e, 0xe8);
		/// <summary>
		/// <b>CLSID_D2D1HueRotation</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid HueRotation { get => _hueRotation; }
		internal static readonly Guid _hueRotation = new (0x0f4458ec, 0x4b32, 0x491b, 0x9e, 0x85, 0xbd, 0x73, 0xf4, 0x4d, 0x3e, 0xb6);
		/// <summary>
		/// <b>CLSID_D2D1LinearTransfer</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid LinearTransfer { get => _linearTransfer; }
		internal static readonly Guid _linearTransfer = new (0xad47c8fd, 0x63ef, 0x4acc, 0x9b, 0x51, 0x67, 0x97, 0x9c, 0x03, 0x6c, 0x06);
		/// <summary>
		/// <b>CLSID_D2D1LuminanceToAlpha</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid LuminanceToAlpha { get => _luminanceToAlpha; }
		internal static readonly Guid _luminanceToAlpha = new (0x41251ab7, 0x0beb, 0x46f8, 0x9d, 0xa7, 0x59, 0xe9, 0x3f, 0xcc, 0xe5, 0xde);
		/// <summary>
		/// <b>CLSID_D2D1Morphology</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Morphology { get => _morphology; }
		internal static readonly Guid _morphology = new (0xeae6c40d, 0x626a, 0x4c2d, 0xbf, 0xcb, 0x39, 0x10, 0x01, 0xab, 0xe2, 0x02);
		/// <summary>
		/// <b>CLSID_D2D1OpacityMetadata</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid OpacityMetadata { get => _opacityMetadata; }
		internal static readonly Guid _opacityMetadata = new (0x6c53006a, 0x4450, 0x4199, 0xaa, 0x5b, 0xad, 0x16, 0x56, 0xfe, 0xce, 0x5e);
		/// <summary>
		/// <b>CLSID_D2D1PointDiffuse</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid PointDiffuse { get => _pointDiffuse; }
		internal static readonly Guid _pointDiffuse = new (0xb9e303c3, 0xc08c, 0x4f91, 0x8b, 0x7b, 0x38, 0x65, 0x6b, 0xc4, 0x8c, 0x20);
		/// <summary>
		/// <b>CLSID_D2D1PointSpecular</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid PointSpecular { get => _pointSpecular; }
		internal static readonly Guid _pointSpecular = new (0x09c3ca26, 0x3ae2, 0x4f09, 0x9e, 0xbc, 0xed, 0x38, 0x65, 0xd5, 0x3f, 0x22);
		/// <summary>
		/// <b>CLSID_D2D1Premultiply</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Premultiply { get => _premultiply; }
		internal static readonly Guid _premultiply = new (0x06eab419, 0xdeed, 0x4018, 0x80, 0xd2, 0x3e, 0x1d, 0x47, 0x1a, 0xde, 0xb2);
		/// <summary>
		/// <b>CLSID_D2D1Saturation</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Saturation { get => _saturation; }
		internal static readonly Guid _saturation = new (0x5cb2d9cf, 0x327d, 0x459f, 0xa0, 0xce, 0x40, 0xc0, 0xb2, 0x08, 0x6b, 0xf7);
		/// <summary>
		/// <b>CLSID_D2D1Shadow</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Shadow { get => _shadow; }
		internal static readonly Guid _shadow = new (0xC67EA361, 0x1863, 0x4e69, 0x89, 0xDB, 0x69, 0x5D, 0x3E, 0x9A, 0x5B, 0x6B);
		/// <summary>
		/// <b>CLSID_D2D1SpotDiffuse</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid SpotDiffuse { get => _spotDiffuse; }
		internal static readonly Guid _spotDiffuse = new (0x818a1105, 0x7932, 0x44f4, 0xaa, 0x86, 0x08, 0xae, 0x7b, 0x2f, 0x2c, 0x93);
		/// <summary>
		/// <b>CLSID_D2D1SpotSpecular</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid SpotSpecular { get => _spotSpecular; }
		internal static readonly Guid _spotSpecular = new (0xedae421e, 0x7654, 0x4a37, 0x9d, 0xb8, 0x71, 0xac, 0xc1, 0xbe, 0xb3, 0xc1);
		/// <summary>
		/// <b>CLSID_D2D1TableTransfer</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid TableTransfer { get => _tableTransfer; }
		internal static readonly Guid _tableTransfer = new (0x5bf818c3, 0x5e43, 0x48cb, 0xb6, 0x31, 0x86, 0x83, 0x96, 0xd6, 0xa1, 0xd4);
		/// <summary>
		/// <b>CLSID_D2D1Tile</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Tile { get => _tile; }
		internal static readonly Guid _tile = new (0xB0784138, 0x3B76, 0x4bc5, 0xB1, 0x3B, 0x0F, 0xA2, 0xAD, 0x02, 0x65, 0x9F);
		/// <summary>
		/// <b>CLSID_D2D1Turbulence</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid Turbulence { get => _turbulence; }
		internal static readonly Guid _turbulence = new (0xCF2BB6AE, 0x889A, 0x4ad7, 0xBA, 0x29, 0xA2, 0xFD, 0x73, 0x2C, 0x9F, 0xC9);
		/// <summary>
		/// <b>CLSID_D2D1UnPremultiply</b><br/>
		/// D2D1EFFECTS.h
		/// </summary>
		public static Guid UnPremultiply { get => _unPremultiply; }
		internal static readonly Guid _unPremultiply = new (0xfb9ac489, 0xad8d, 0x41ed, 0x99, 0x99, 0xbb, 0x63, 0x47, 0xd1, 0x10, 0xf7);
		/// <summary>
		/// <b>CLSID_D2D1YCbCr</b><br/>
		/// D2D1EFFECTS_1.h
		/// </summary>
		public static Guid YCbCr { get => _yCbCr; }
		internal static readonly Guid _yCbCr = new (0x99503cc1, 0x66c7, 0x45c9, 0xa8, 0x75, 0x8a, 0xd8, 0xa7, 0x91, 0x44, 0x01);
		/// <summary>
		/// <b>CLSID_D2D1Contrast</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Contrast { get => _contrast; }
		internal static readonly Guid _contrast = new (0xb648a78a, 0x0ed5, 0x4f80, 0xa9, 0x4a, 0x8e, 0x82, 0x5a, 0xca, 0x6b, 0x77);
		/// <summary>
		/// <b>CLSID_D2D1RgbToHue</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid RgbToHue { get => _rgbToHue; }
		internal static readonly Guid _rgbToHue = new (0x23f3e5ec, 0x91e8, 0x4d3d, 0xad, 0x0a, 0xaf, 0xad, 0xc1, 0x00, 0x4a, 0xa1);
		/// <summary>
		/// <b>CLSID_D2D1HueToRgb</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid HueToRgb { get => _hueToRgb; }
		internal static readonly Guid _hueToRgb = new (0x7b78a6bd, 0x0141, 0x4def, 0x8a, 0x52, 0x63, 0x56, 0xee, 0x0c, 0xbd, 0xd5);
		/// <summary>
		/// <b>CLSID_D2D1ChromaKey</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid ChromaKey { get => _chromaKey; }
		internal static readonly Guid _chromaKey = new (0x74C01F5B, 0x2A0D, 0x408C, 0x88, 0xE2, 0xC7, 0xA3, 0xC7, 0x19, 0x77, 0x42);
		/// <summary>
		/// <b>CLSID_D2D1Emboss</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Emboss { get => _emboss; }
		internal static readonly Guid _emboss = new (0xb1c5eb2b, 0x0348, 0x43f0, 0x81, 0x07, 0x49, 0x57, 0xca, 0xcb, 0xa2, 0xae);
		/// <summary>
		/// <b>CLSID_D2D1Exposure</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Exposure { get => _exposure; }
		internal static readonly Guid _exposure = new (0xb56c8cfa, 0xf634, 0x41ee, 0xbe, 0xe0, 0xff, 0xa6, 0x17, 0x10, 0x60, 0x04);
		/// <summary>
		/// <b>CLSID_D2D1Grayscale</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Grayscale { get => _grayscale; }
		internal static readonly Guid _grayscale = new (0x36DDE0EB, 0x3725, 0x42E0, 0x83, 0x6D, 0x52, 0xFB, 0x20, 0xAE, 0xE6, 0x44);
		/// <summary>
		/// <b>CLSID_D2D1Invert</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Invert { get => _invert; }
		internal static readonly Guid _invert = new (0xe0c3784d, 0xcb39, 0x4e84, 0xb6, 0xfd, 0x6b, 0x72, 0xf0, 0x81, 0x02, 0x63);
		/// <summary>
		/// <b>CLSID_D2D1Posterize</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Posterize { get => _posterize; }
		internal static readonly Guid _posterize = new (0x2188945e, 0x33a3, 0x4366, 0xb7, 0xbc, 0x08, 0x6b, 0xd0, 0x2d, 0x08, 0x84);
		/// <summary>
		/// <b>CLSID_D2D1Sepia</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Sepia { get => _sepia; }
		internal static readonly Guid _sepia = new (0x3a1af410, 0x5f1d, 0x4dbe, 0x84, 0xdf, 0x91, 0x5d, 0xa7, 0x9b, 0x71, 0x53);
		/// <summary>
		/// <b>CLSID_D2D1Sharpen</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Sharpen { get => _sharpen; }
		internal static readonly Guid _sharpen = new (0xC9B887CB, 0xC5FF, 0x4DC5, 0x97, 0x79, 0x27, 0x3D, 0xCF, 0x41, 0x7C, 0x7D);
		/// <summary>
		/// <b>CLSID_D2D1Straighten</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Straighten { get => _straighten; }
		internal static readonly Guid _straighten = new (0x4da47b12, 0x79a3, 0x4fb0, 0x82, 0x37, 0xbb, 0xc3, 0xb2, 0xa4, 0xde, 0x08);
		/// <summary>
		/// <b>CLSID_D2D1TemperatureTint</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid TemperatureTint { get => _temperatureTint; }
		internal static readonly Guid _temperatureTint = new (0x89176087, 0x8AF9, 0x4A08, 0xAE, 0xB1, 0x89, 0x5F, 0x38, 0xDB, 0x17, 0x66);
		/// <summary>
		/// <b>CLSID_D2D1Vignette</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Vignette { get => _vignette; }
		internal static readonly Guid _vignette = new (0xc00c40be, 0x5e67, 0x4ca3, 0x95, 0xb4, 0xf4, 0xb0, 0x2c, 0x11, 0x51, 0x35);
		/// <summary>
		/// <b>CLSID_D2D1EdgeDetection</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid EdgeDetection { get => _edgeDetection; }
		internal static readonly Guid _edgeDetection = new (0xEFF583CA, 0xCB07, 0x4AA9, 0xAC, 0x5D, 0x2C, 0xC4, 0x4C, 0x76, 0x46, 0x0F);
		/// <summary>
		/// <b>CLSID_D2D1HighlightsShadows</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid HighlightsShadows { get => _highlightsShadows; }
		internal static readonly Guid _highlightsShadows = new (0xCADC8384, 0x323F, 0x4C7E, 0xA3, 0x61, 0x2E, 0x2B, 0x24, 0xDF, 0x6E, 0xE4);
		/// <summary>
		/// <b>CLSID_D2D1LookupTable3D</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid LookupTable3D { get => _lookupTable3D; }
		internal static readonly Guid _lookupTable3D = new (0x349E0EDA, 0x0088, 0x4A79, 0x9C, 0xA3, 0xC7, 0xE3, 0x00, 0x20, 0x20, 0x20);
		/// <summary>
		/// <b>CLSID_D2D1Opacity</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Opacity { get => _opacity; }
		internal static readonly Guid _opacity = new (0x811d79a4, 0xde28, 0x4454, 0x80, 0x94, 0xc6, 0x46, 0x85, 0xf8, 0xbd, 0x4c);
		/// <summary>
		/// <b>CLSID_D2D1AlphaMask</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid AlphaMask { get => _alphaMask; }
		internal static readonly Guid _alphaMask = new (0xc80ecff0, 0x3fd5, 0x4f05, 0x83, 0x28, 0xc5, 0xd1, 0x72, 0x4b, 0x4f, 0x0a);
		/// <summary>
		/// <b>CLSID_D2D1CrossFade</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid CrossFade { get => _crossFade; }
		internal static readonly Guid _crossFade = new (0x12f575e8, 0x4db1, 0x485f, 0x9a, 0x84, 0x03, 0xa0, 0x7d, 0xd3, 0x82, 0x9f);
		/// <summary>
		/// <b>CLSID_D2D1Tint</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid Tint { get => _tint; }
		internal static readonly Guid _tint = new (0x36312b17, 0xf7dd, 0x4014, 0x91, 0x5d, 0xff, 0xca, 0x76, 0x8c, 0xf2, 0x11);
		/// <summary>
		/// <b>CLSID_D2D1WhiteLevelAdjustment</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid WhiteLevelAdjustment { get => _whiteLevelAdjustment; }
		internal static readonly Guid _whiteLevelAdjustment = new (0x44a1cadb, 0x6cdd, 0x4818, 0x8f, 0xf4, 0x26, 0xc1, 0xcf, 0xe9, 0x5b, 0xdb);
		/// <summary>
		/// <b>CLSID_D2D1HdrToneMap</b><br/>
		/// D2D1EFFECTS_2.h
		/// </summary>
		public static Guid HdrToneMap { get => _hdrToneMap; }
		internal static readonly Guid _hdrToneMap = new (0x7b0b748d, 0x4610, 0x4486, 0xa9, 0x0c, 0x99, 0x9d, 0x9a, 0x2e, 0x2b, 0x11);

	}
}
