using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Clash.UI.Units
{
	public class CityCup : Control
    {
        #region DefaultStyleKey

        static CityCup()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CityCup), new FrameworkPropertyMetadata(typeof(CityCup)));
        }
        #endregion
    }
}
