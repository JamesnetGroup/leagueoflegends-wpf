using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Options.Views
{
	public class OptionsView : View
	{
		static OptionsView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(OptionsView), new FrameworkPropertyMetadata(typeof(OptionsView)));
		}
	}
}
