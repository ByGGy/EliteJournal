using System;

namespace Infrastructure
{
    public static class MathExtension
    {
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0)
                return min;

            if (val.CompareTo(max) > 0)
                return max;

            return val;
        }

        public static bool InRange<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0)
                return false;

            if (val.CompareTo(max) > 0)
                return false;

            return true;
        }

        private static float Center(float pA, float pB)
        {
            return (pA + pB) / 2.0f;
        }

        private static float Distance(float pA, float pB)
        {
            return Math.Abs(pB - pA);
        }

        /// <summary>Normalize a value from the range [min, max] into [-1, 1]</summary>
        public static float Normalize(this float value, float min, float max)
        {
            float mid = Center(min, max);
            float range = Distance(min, max);

            if (range <= 0.0)
                return mid;

            return 2 * (value - mid) / range;
        }

        /// <summary>Scale a value from the range [-1, 1] into [min, max]</summary>
        public static float Scale(this float normalizedValue, float min, float max)
        {
            float mid = Center(min, max);
            float range = Distance(min, max);

            return mid + ((normalizedValue * range) / 2);
        }
    }
}
