namespace DinoColors
{
    public static class FloatExtensions
    {
        public static bool IsEqualTo(this float a, float b)
        {
            return Math.Abs(a - b) < double.Epsilon;
        }
    }
}
