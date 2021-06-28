using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Voice.UI.Units
{
	public class InputStatus : View
    {
        #region DefaultStyleKey

        static InputStatus()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputStatus), new FrameworkPropertyMetadata(typeof(InputStatus)));
        }
		#endregion
	}
}
