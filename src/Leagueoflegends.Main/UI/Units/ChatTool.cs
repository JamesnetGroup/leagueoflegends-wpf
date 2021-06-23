using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
	public class ChatTool : ContentControl
	{
		#region DefaultStyleKey

		static ChatTool()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatTool), new FrameworkPropertyMetadata(typeof(ChatTool)));
		}
		#endregion
	}
}
