using System.Globalization;

namespace DinoColors
{
    public class DecimalRGB
    {
        public byte Red { get; init; }
        public byte Green { get; init; }
        public byte Blue { get; init; }

        public DecimalRGB(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public static DecimalRGB FromHex(string rawRGB)
        {
            var rgbHex = rawRGB.Split("#")[1];
            var redHex = rgbHex.Substring(0, 2);
            var greenHex = rgbHex.Substring(2, 2);
            var blueHex = rgbHex.Substring(4, 2);

            var redDecimal = byte.Parse(redHex, NumberStyles.HexNumber);
            var greenDecimal = byte.Parse(greenHex, NumberStyles.HexNumber);
            var blueDecimal = byte.Parse(blueHex, NumberStyles.HexNumber);

            return new DecimalRGB(redDecimal, greenDecimal, blueDecimal);
        }

        public override string ToString()
        {
            return $"{Red}, {Green}, {Blue}";
        }
    }
}
