using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
	public class SocialTool : ContentControl
	{
		#region DefaultStyleKey

		static SocialTool()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SocialTool), new FrameworkPropertyMetadata(typeof(SocialTool)));
		}
		#endregion
	}
}
