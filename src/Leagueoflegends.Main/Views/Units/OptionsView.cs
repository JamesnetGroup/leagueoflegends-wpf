using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Main.Views
{
	public class OptionsView : View
	{
		static OptionsView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(OptionsView), new FrameworkPropertyMetadata(typeof(OptionsView)));
		}
	}
}
