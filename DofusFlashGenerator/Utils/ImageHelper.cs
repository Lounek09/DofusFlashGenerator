using System.Drawing.Imaging;

namespace DofusFlashGenerator.Utils;

public static class ImageHelper
{
    public static readonly EncoderParameters HighQualityParameters = new(1)
    {
        Param =
        [
            new(Encoder.Quality, 100L)
        ]
    };

    public static readonly ImageCodecInfo JpgCodec = ImageCodecInfo.GetImageEncoders()
        .First(x => x.FormatID == ImageFormat.Jpeg.Guid)!;
}
