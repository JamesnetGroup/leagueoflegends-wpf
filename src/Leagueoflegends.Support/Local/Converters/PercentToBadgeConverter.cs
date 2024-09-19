using System.Globalization;
using System.Windows.Data;
namespace Leagueoflegends.Support.Local.Converters;

public class PercentToBadgeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int percent)
        {
            return percent >= 50
                ? "/Leagueoflegends.Support;component/Images/badge_champion2.png"
                : "/Leagueoflegends.Support;component/Images/badge_champion1.png";
        }
        return "/Leagueoflegends.Support;component/Images/badge_champion1.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
