using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infrastructure
{
    /// <summary>
    /// This converter does nothing except breaking the debugger into the convert method
    /// </summary>
    public class DebugConverter : MarkupExtension, IValueConverter
    {
        #region Markup

        private static DebugConverter converter;

        public DebugConverter() { }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (converter == null)
                converter = new DebugConverter();

            return converter;
        }

        #endregion

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }
    }
}