using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Leagueoflegends.Support.Local.Converters;

public class MatchResultToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string result)
        {
            switch (result.ToLower())
            {
                case "victory": return "#1BA83E";
                case "defeat": return "#D31A45";
            }
        }
        return new SolidColorBrush(Colors.Gray);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
