using System.Globalization;
using System.Windows.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class ChampionNameToThumbnailConverter : IValueConverter
{
    private const string BaseImagePath = "/Leagueoflegends.Support;component/Images/thumbnails/";

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string itemName && !string.IsNullOrEmpty(itemName))
        {
            return $"{BaseImagePath}{itemName}.png";
        }
        return $"{BaseImagePath}rocketbelt.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
