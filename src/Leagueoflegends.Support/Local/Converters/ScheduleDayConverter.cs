using System.Globalization;
using System.Windows.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class ScheduleDayConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int day)
        {
            return $"DAY {day}";
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
