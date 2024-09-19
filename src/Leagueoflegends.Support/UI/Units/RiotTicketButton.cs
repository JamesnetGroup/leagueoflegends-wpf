using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotTicketButton : Button
{
    public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(Thickness), typeof(RiotTicketButton), new PropertyMetadata(new Thickness(0, 0, 0, 0)));

    public Thickness CornerRadius
    {
        get { return (Thickness)GetValue(CornerRadiusProperty); }
        set { SetValue(CornerRadiusProperty, value); }
    }

    public RiotTicketButton()
    {
        DefaultStyleKey = typeof(RiotTicketButton);
    }
}
