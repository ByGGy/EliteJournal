using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infrastructure
{
    [ValueConversion(typeof(System.Drawing.Color), typeof(System.Windows.Media.Color))]
    public class ColorConverter : MarkupExtension, IValueConverter
    {
        #region Markup

        private static ColorConverter converter;

        public ColorConverter() { }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (converter == null)
                converter = new ColorConverter();

            return converter;
        }

        #endregion

        #region Converter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            System.Drawing.Color originalColor = (System.Drawing.Color)value;

            return System.Windows.Media.Color.FromArgb(originalColor.A, originalColor.R, originalColor.G, originalColor.B);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            System.Windows.Media.Color originalColor = (System.Windows.Media.Color)value;

            return System.Drawing.Color.FromArgb(originalColor.A, originalColor.R, originalColor.G, originalColor.B);
        }

        #endregion
    }
}