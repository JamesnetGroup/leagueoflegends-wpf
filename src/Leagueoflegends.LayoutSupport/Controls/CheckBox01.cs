using Leagueoflegends.Controls;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
    public class CheckBox01 : RiotCheckBox
    {
        #region DefaultStyleKey

        static CheckBox01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBox01), new FrameworkPropertyMetadata(typeof(CheckBox01)));
        }
        #endregion
    }
}
