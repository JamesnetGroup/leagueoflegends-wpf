using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Lol.Converter
{
    public class ThumbnailConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"/Lol.Resources;component/Images/{parameter}/{value}.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
