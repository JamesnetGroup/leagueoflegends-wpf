using System.Globalization;
using System.Windows.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class MenuNameToWallpaperConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string menuName)
        {
            string fileName = "wallpaper-rucian.png";
            switch (menuName.ToUpper())
            {
                case "CLASH": fileName = "wallpaper-fiora.jpg"; break;
                case "HOME": fileName = "wallpaper-leesin.png"; break;
                case "TFT": fileName = "wallpaper-tft.jpg"; break;
                case "PROFILE": fileName = "wallpaper-leona.jpg"; break;
                case "COLLECTION": fileName = "wallpaper-ezreal.jpg"; break;
                case "LOOT": fileName = "wallpaper-rucian.png"; break;
                case "SHOP": fileName = "wallpaper-leesin.png"; break;
                case "STORE": fileName = "wallpaper-maokai.jpg"; break;
            }
            return $"/Leagueoflegends.Support;component/Images/{fileName}";
        }
        return "/Leagueoflegends.Support;component/Images/wallpaper-rucian.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException("ConvertBack is not implemented for this one-way converter.");
    }
}
