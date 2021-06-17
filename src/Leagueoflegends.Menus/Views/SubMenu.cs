using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Menus.Views
{
	public class SubMenu : ListBox
	{
		static SubMenu()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SubMenu), new FrameworkPropertyMetadata(typeof(SubMenu)));
		}
	}
}
