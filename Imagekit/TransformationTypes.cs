
using System;

namespace Imagekit
{
    public partial class Transformation
    {
        /// <summary>Width of a transformed image</summary>
        /// <param name="value"></param>
        public Transformation Width(int value) { return Add("w", value); }

        /// <summary>Height of a transformed image</summary>
        /// <param name="value"></param>
        public Transformation Height(int value) { return Add("h", value); }

        /// <summary>Aspect Ratio of a transformed image</summary>
        /// <param name="value"></param>
        public Transformation AspectRatio(string value) { return Add("ar", value); }

        /// <summary>
        /// JPG compression quality. 1 is the lowest quality and 100 is the highest. The default is the
        /// original image's quality or 80% if not available. 
        /// </summary>
        /// <param name="value"></param>
        public Transformation Quality(int value) { return Add("q", value); }

        /// <summary>Crop Transformation.</summary>
        /// <param name="value"></param>
        public Transformation Crop(string value) { return Add("c", value); }

        /// <summary>Crop Mode</summary>
        /// <param name="value"></param>
        public Transformation CropMode(string value) { return Add("cm", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation X(int value) { return Add("x", ConvertCoordinateParam(value)); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Y(int value) { return Add("y", ConvertCoordinateParam(value)); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Focus(string value) { return Add("fo", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Format(string value) { return Add("f", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Radius(object value) { return Add("r", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Background(string value) { return Add("bg", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Border(string value) { return Add("b", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Rotation(object value) { return Add("rt", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Rotate(object value) { return Add("rt", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Blur(int value) { return Add("bl", value); }

        /// <summary>Add named transformation.</summary>
        /// <param name="value">named transformation.</param>
        public Transformation Named(string value) { return Add("n", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImage(string value) { return Add("oi", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayX(int value) { return Add("ox", ConvertCoordinateParam(value)); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayY(int value) { return Add("oy", ConvertCoordinateParam(value)); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayFocus(string value) { return Add("ofo", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayHeight(int value) { return Add("oh", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayWidth(int value) { return Add("ow", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayText(string value) { return Add("ot", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextFontSize(int value) { return Add("ots", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextFontFamily(string value) { return Add("otf", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextColor(string value) { return Add("otc", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverylayAlpha(int value) { return Add("oa", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextTypography(string value) { return Add("ott", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextTransparency(int value) { return Add("oa", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextBackground(string value) { return Add("otbg", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextEncoded(string value) { return Add("ote", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextWidth(int value) { return Add("otw", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextPadding(int value) { return Add("otp", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayTextInnerAlignment(string value) { return Add("otia", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayRadius(int value) { return Add("or", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayBackground(string value) { return Add("obg", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImageTrim(bool value) { return Add("oit", value.ToString().ToLower()); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImageAspectRatio(string value) { return Add("oiar", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImageBackground(string value) { return Add("oibg", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImageBorder(string value) { return Add("oib", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImageDPR(object value) { return Add("oidpr", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImageQuality(int value) { return Add("oiq", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation OverlayImageCropping(string value) { return Add("oic", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Progressive(bool value) { return Add("pr", value.ToString().ToLower()); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Lossless(bool value) { return Add("lo", value.ToString().ToLower()); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Trim(int value) { return Add("t", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Metadata(bool value) { return Add("md", value.ToString().ToLower()); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation ColorProfile(bool value) { return Add("cp", value.ToString().ToLower()); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation DefaultImage(string value) { return Add("di", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation Dpr(object value) { return Add("dpr", value); }

        /// <summary></summary>
        public Transformation EffectSharpen() { return Add("e-sharpen", ""); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation EffectSharpen(int value) { return Add("e-sharpen", value); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation EffectUsm(string value) { return Add("e-usm", value); }

        /// <summary></summary>
        public Transformation EffectContrast() { return Add("e-contrast", ""); }

        /// <summary></summary>
        /// <param name="value"></param>
        public Transformation EffectContrast(object value) { return Add("e-contrast", value.ToString().ToLower()); }

        /// <summary></summary>
        public Transformation EffectGray() { return Add("e-grayscale", "true"); }

        /// <summary></summary>
        public Transformation Original() { return Add("orig", "true"); }

        /// <summary>
        /// Pass an raw transformation string (including chained transformations)
        /// </summary>
        /// <param name="value">A raw transformation string.</param>
        public Transformation RawTransformation(string value) { return Add(value,""); }

        private string ConvertCoordinateParam(int paramValue)
        {
            return paramValue < 0 
                ? $"N{Math.Abs(paramValue)}" 
                : $"{paramValue}";
        }
    }
}
