using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Voice.UI.Units
{
	public class InputPress : View
    {
        #region DefaultStyleKey

        static InputPress()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputPress), new FrameworkPropertyMetadata(typeof(InputPress)));
        }
		#endregion
	}
}
