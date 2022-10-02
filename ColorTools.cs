namespace DinoColors
{
    public static class ColorTools
    {
        public static float CalcHue(float red, float green, float blue, float maximumComponent, float chroma)
        {
            float hue = 0f;

            if (chroma.IsEqualTo(0)) return hue;

            if (maximumComponent.IsEqualTo(red))
            {
                hue = (green - blue) / chroma;
            }

            if (maximumComponent.IsEqualTo(green))
            {
                hue = 2 + (blue - red) / chroma;
            }

            if (maximumComponent.IsEqualTo(blue))
            {
                hue = 4 + (red - green) / chroma;
            }

            hue *= 60;
            if (hue < 0)
            {
                hue += 360;
            }

            return hue;
        }
    }
}
