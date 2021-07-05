using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Leagueoflegends.Converter
{
	public class ThumbnailConverter : MarkupExtension, IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return $"/Leagueoflegends.Resources;component/Images/Square/{value}.png";
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
