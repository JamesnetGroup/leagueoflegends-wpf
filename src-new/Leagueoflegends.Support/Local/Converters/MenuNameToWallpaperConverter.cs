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
                case "HOME": fileName = "wallpaper-caitlyn.jpg"; break;
                case "TFT": fileName = "wallpaper-singed.png"; break;
                case "CLASH": fileName = "wallpaper-sena.png"; break;
                case "PROFILE": fileName = "wallpaper-leona.jpg"; break;
                case "COLLECTION": fileName = "wallpaper-ezreal.jpg"; break;
                case "LOOT": fileName = "wallpaper-rucian.png"; break;
                case "SHOP": fileName = "wallpaper-gnar.jpg"; break;
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
