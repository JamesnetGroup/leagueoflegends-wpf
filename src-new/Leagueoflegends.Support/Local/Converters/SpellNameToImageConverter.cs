using System.Globalization;
using System.Windows.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class SpellNameToImageConverter : IValueConverter
{
    private const string BaseImagePath = "/Leagueoflegends.Support;component/Images/";

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string spellName && !string.IsNullOrEmpty(spellName))
        {
            string formattedSpellName = spellName.ToLower();
            return $"{BaseImagePath}spell_{formattedSpellName}.png";
        }
        return $"{BaseImagePath}spell_default.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
