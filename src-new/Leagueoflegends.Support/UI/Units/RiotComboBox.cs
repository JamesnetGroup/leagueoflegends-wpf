
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Leagueoflegends.Support.UI.Units;
public class RiotComboBox : ComboBox
{
    public static readonly DependencyProperty LightDismissOverlayBackgroundProperty = DependencyProperty.Register("LightDismissOverlayBackground", typeof(Brush), typeof(RiotComboBox), new PropertyMetadata(null));

    public Brush LightDismissOverlayBackground
    {
        get { return (Brush)GetValue(LightDismissOverlayBackgroundProperty); }
        set { SetValue(LightDismissOverlayBackgroundProperty, value); }
    }

public RiotComboBox()
    {
        DefaultStyleKey = typeof(RiotComboBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotComboBoxItem();
    }
}
