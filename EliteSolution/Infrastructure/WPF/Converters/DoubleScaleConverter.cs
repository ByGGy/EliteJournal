using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infrastructure
{
    [ValueConversion(typeof(double), typeof(double))]
    public class DoubleScaleConverter : MarkupExtension, IValueConverter
    {
        #region Markup

        private static DoubleScaleConverter converter;

        public DoubleScaleConverter() { }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (converter == null)
                converter = new DoubleScaleConverter();

            return converter;
        }

        #endregion

        #region Converter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double currentValue = System.Convert.ToDouble(value);

            double scale;
            if (double.TryParse(parameter as string, NumberStyles.Any, CultureInfo.InvariantCulture, out scale))
                return currentValue * scale;
            else
                return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double currentValue = System.Convert.ToDouble(value);

            double scale;
            if (double.TryParse(parameter as string, NumberStyles.Any, CultureInfo.InvariantCulture, out scale) && (scale != 0.0f))
                return currentValue / scale;
            else
                return DependencyProperty.UnsetValue;
        }

        #endregion
    }
}