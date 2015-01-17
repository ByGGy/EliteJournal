using System;
using System.Text;

namespace Infrastructure
{
    public static class ArrayExtension
    {
        public static void Initialize<T>(this T[] array, T defaultValue)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = defaultValue;
        }

        public static string ToString<T>(this T[] array, string format, string separator)
        {
            if (array != null)
            {
                StringBuilder builder = new StringBuilder();
                Array.ForEach(array, (T value) => { builder.AppendFormat(format, value, separator); });
                return builder.ToString();
            }

            return string.Empty;
        }
    }
}
