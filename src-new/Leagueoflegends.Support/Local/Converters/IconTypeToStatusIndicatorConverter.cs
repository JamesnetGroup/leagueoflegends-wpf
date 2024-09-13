using System.Globalization;
using System.Windows.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class IconTypeToStatusIndicatorConverter : IValueConverter
{
    private const string RpPath = "/Leagueoflegends.Support;component/Images/rp.png";
    private const string BlueEssencePath = "/Leagueoflegends.Support;component/Images/blue-essence.png";

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string iconType)
        {
            return iconType.ToLower() switch
            {
                "rp" => RpPath,
                "blueessence" => BlueEssencePath,
                _ => string.Empty
            };
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
