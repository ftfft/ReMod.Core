using UnityEngine;

namespace ReMod.Core.Unity
{
    public static class ColorExtensions
    {
        public static string ToHex(this Color color)
        {
            return ColorUtility.ToHtmlStringRGB(color);
        }
        public static Color ScaleMinimumValue(this Color color, float MinVal)
        {
            Color.RGBToHSV(color, out float h, out float s, out float v);
            return Color.HSVToRGB(h, s, (v * (1 - MinVal)) + MinVal);
        }
    }
}
