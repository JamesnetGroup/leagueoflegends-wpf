using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.Client.UI.Units
{
    public class InputPress : Control
    {
        #region DefaultStyleKey

        static InputPress()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputPress), new FrameworkPropertyMetadata(typeof(InputPress)));
        }
        #endregion
    }
}
