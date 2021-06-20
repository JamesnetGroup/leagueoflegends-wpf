using Leagueoflegends.Controls.Primitives;
using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Main.Views
{
	public class MainView : ContentsWindow
	{
		#region DefaultStyleKey

		static MainView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
		}
		#endregion
	}
}
