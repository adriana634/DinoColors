namespace DinoColors
{
    public class CMYK
    {
        public float CyanColor { get; init; }
        public float MagentaColor { get; init; }
        public float YellowColor { get; init; }
        public float BlackKey { get; init; }

        public CMYK(float cyanColor, float magentaColor, float yellowColor, float blackKey)
        {
            CyanColor = cyanColor;
            MagentaColor = magentaColor;
            YellowColor = yellowColor;
            BlackKey = blackKey;
        }

        public static CMYK FromFractionalRGB(FractionalRGB rgb)
        {
            var blackKey = 1 - Math.Max(rgb.Red, Math.Max(rgb.Green, rgb.Blue));
            var cyanColor = rgb.Red.IsEqualTo(0) ? 0f : (1 - rgb.Red - blackKey) / (1 - blackKey);
            var magentaColor = rgb.Green.IsEqualTo(0) ? 0f : (1 - rgb.Green - blackKey) / (1 - blackKey);
            var yellowColor = rgb.Blue.IsEqualTo(0) ? 0f : (1 - rgb.Blue - blackKey) / (1 - blackKey);

            return new CMYK(cyanColor, magentaColor, yellowColor, blackKey);
        }

        public override string ToString()
        {
            return $"{CyanColor:P0}, {MagentaColor:P0}, {YellowColor:P0}, {BlackKey:P0}";
        }
    }
}
