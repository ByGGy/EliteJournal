using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Infrastructure
{
    public static class EnumExtension
    {
        public static string Description(this Enum value)
        {
            Type enumType = value.GetType();
            FieldInfo field = enumType.GetField(value.ToString());
            object[] attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length == 0) ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }

        public static T Previous<T>(this Enum value)
        {
            if (!(value is T))
                throw new ArgumentException("Type do not match");

            T previous = default(T);

            Type enumType = value.GetType();
            IEnumerator i = Enum.GetValues(enumType).GetEnumerator();

            i.Reset();
            i.MoveNext();
            do
            {
                previous = (T)i.Current;
            }
            while (i.MoveNext() && !i.Current.Equals(value));

            return previous;
        }

        public static T Next<T>(this Enum value)
        {
            if (!(value is T))
                throw new ArgumentException("Type do not match");
            
            Type enumType = value.GetType();
            IEnumerator i = Enum.GetValues(enumType).GetEnumerator();

            i.Reset();
            while (i.MoveNext() && !i.Current.Equals(value)) ;

            if (i.MoveNext())
                return (T)i.Current;

            return default(T);
        }

        public static int MinValue(this Type enumType)
        {
            if (!enumType.IsEnum)
                throw new ArgumentException("Type must be an Enum");

            return Enum.GetValues(enumType).Cast<int>().Min();
        }

        public static int MaxValue(this Type enumType)
        {
            if (!enumType.IsEnum)
                throw new ArgumentException("Type must be an Enum");

            return Enum.GetValues(enumType).Cast<int>().Max();
        }
    }
}
