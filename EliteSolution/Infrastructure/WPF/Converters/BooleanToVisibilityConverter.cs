using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infrastructure
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityConverter : MarkupExtension, IValueConverter
    {
        #region Markup

        private static BooleanToVisibilityConverter converter;

        public BooleanToVisibilityConverter() { }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (converter == null)
                converter = new BooleanToVisibilityConverter();

            return converter;
        }

        #endregion

        #region Converter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isVisible = (bool)value;

            if (parameter != null)
            {
                if (bool.Parse((string)parameter))
                    isVisible = !isVisible;
            }

            return (isVisible ? Visibility.Visible : Visibility.Collapsed);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            bool isVisible = (visibility == Visibility.Visible);

            if (parameter != null)
            {
                if (bool.Parse((string)parameter))
                    isVisible = !isVisible;
            }

            return isVisible;
        }

        #endregion
    }
}
