using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Main.Views
{
	public class EmptyContent : View
	{
		static EmptyContent()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyContent), new FrameworkPropertyMetadata(typeof(EmptyContent)));
		}
	}
}
