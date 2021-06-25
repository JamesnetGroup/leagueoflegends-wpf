using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Voice.UI.Units
{
	public class InputSetting : View
    {
        #region DefaultStyleKey

        static InputSetting()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputSetting), new FrameworkPropertyMetadata(typeof(InputSetting)));
        }
		#endregion
	}
}
