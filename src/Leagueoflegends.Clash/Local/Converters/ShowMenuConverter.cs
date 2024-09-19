using Leagueoflegends.Support.Local.Models;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Leagueoflegends.Clash.Local.Converters;

public class ShowMenuConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo language)
    {
        return value is MenuModel menu && menu.Name.Equals(parameter) ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
    {
        throw new NotImplementedException();
    }
}
