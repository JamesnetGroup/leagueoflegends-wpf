using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Client.Voice.UI.Units
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
