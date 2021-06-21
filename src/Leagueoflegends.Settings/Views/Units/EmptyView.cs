using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.Views
{
	public class EmptyView : View
	{
		static EmptyView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyView), new FrameworkPropertyMetadata(typeof(EmptyView)));
		}
	}
}
