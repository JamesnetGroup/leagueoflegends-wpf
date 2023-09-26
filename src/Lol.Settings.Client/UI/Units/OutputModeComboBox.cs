using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;
namespace Lol.Settings.Client.UI.Units
{
    public class OutputModeComboBox : RiotComboBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new OutputModeComboBoxItem ();
        }
    }
}
