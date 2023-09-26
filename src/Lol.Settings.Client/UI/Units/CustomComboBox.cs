using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;
namespace Lol.Settings.Client.UI.Units
{
    public class CustomComboBox : RiotComboBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CustomComboBoxItem ();
        }
    }
}
