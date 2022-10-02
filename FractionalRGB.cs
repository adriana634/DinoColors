namespace DinoColors
{
    public class FractionalRGB
    {
        public float Red { get; init; }
        public float Green { get; init; }
        public float Blue { get; init; }

        public FractionalRGB(float red, float green, float blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public static FractionalRGB FromDecimalRGB(DecimalRGB rgb)
        {
            var redFractional = rgb.Red / 255f;
            var greenFractional = rgb.Green / 255f;
            var blueFractional = rgb.Blue / 255f;

            return new FractionalRGB(redFractional, greenFractional, blueFractional);
        }

        public float MaximumComponent
        {
            get
            {
                return Math.Max(Red, Math.Max(Green, Blue));
            }
        }

        public float MinimumComponent
        {
            get
            {
                return Math.Min(Red, Math.Min(Green, Blue));
            }
        }

        public float Chroma
        {
            get
            {
                return MaximumComponent - MinimumComponent;
            }
        }

        public override string ToString()
        {
            return $"{Red:P0}, {Green:P0}, {Blue:P0}";
        }
    }
}
