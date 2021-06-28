using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Voice.UI.Units
{
	public class InputMode : View
    {
        #region DefaultStyleKey

        static InputMode()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputMode), new FrameworkPropertyMetadata(typeof(InputMode)));
        }
		#endregion
	}
}
