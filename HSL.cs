namespace DinoColors
{
    public class HSL
    {
        public float Hue { get; init; }
        public float Saturation { get; init; }
        public float Lightness { get; init; }

        public HSL(float hue, float saturation, float lightness)
        {
            Hue = hue;
            Saturation = saturation;
            Lightness = lightness;
        }

        public static HSL FromFractionalRGB(FractionalRGB rgb)
        {
            float maximumComponent = rgb.MaximumComponent;
            float minimumComponent = rgb.MinimumComponent;
            float chroma = rgb.Chroma;

            var hue = ColorTools.CalcHue(rgb.Red, rgb.Green, rgb.Blue, maximumComponent, chroma);
            var lightness = (maximumComponent + minimumComponent) / 2;
            var saturation = chroma.IsEqualTo(0) ? 0f : chroma / (1 - Math.Abs(2 * lightness - 1));

            return new HSL(hue, saturation, lightness);
        }

        public override string ToString()
        {
            return $"{Hue:F0}º, {Saturation:P0}, {Lightness:P0}";
        }
    }
}
