using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Client.Voice.UI.Units
{
	public class InputStatus : Control
    {
        #region DefaultStyleKey

        static InputStatus()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputStatus), new FrameworkPropertyMetadata(typeof(InputStatus)));
        }
		#endregion
	}
}
