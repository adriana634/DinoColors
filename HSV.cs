namespace DinoColors
{
    public class HSV
    {
        public float Hue { get; init; }
        public float Saturation { get; init; }
        public float Value { get; init; }

        public HSV(float hue, float saturation, float value)
        {
            Hue = hue;
            Saturation = saturation;
            Value = value;
        }

        public static HSV FromFractionalRGB(FractionalRGB rgb)
        {
            float maximumComponent = rgb.MaximumComponent;
            float chroma = rgb.Chroma;

            var hue = ColorTools.CalcHue(rgb.Red, rgb.Green, rgb.Blue, maximumComponent, chroma);
            var saturation = chroma.IsEqualTo(0) ? 0f : chroma / maximumComponent;
            var value = maximumComponent;

            return new HSV(hue, saturation, value);        
        }

        public override string ToString()
        {
            return $"{Hue:F0}º, {Saturation:P0}, {Value:P0}";
        }
    }
}
