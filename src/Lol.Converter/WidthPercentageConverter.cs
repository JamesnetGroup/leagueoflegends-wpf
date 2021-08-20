using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Lol.Converter
{
    public class WidthPercentageConverter : MarkupExtension, IValueConverter
    {
        private static WidthPercentageConverter _instance;

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDouble(value) * System.Convert.ToDouble(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ??= new WidthPercentageConverter();
        }
    }
}
