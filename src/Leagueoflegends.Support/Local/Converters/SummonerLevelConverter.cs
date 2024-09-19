using System.Globalization;
using System.Windows.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class SummonerLevelConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int level)
        {
            return $"SUMMONER LEVEL {level}";
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
