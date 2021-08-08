using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Friends.UI.Units
{
    public class AddButton : Button
    {
        #region DefaultStyleKey

        static AddButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AddButton), new FrameworkPropertyMetadata(typeof(AddButton)));
        }
        #endregion
    }
}
