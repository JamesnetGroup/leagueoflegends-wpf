using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
	public class AvataThumb : Control
	{
		#region DefaultStyleKey

		static AvataThumb()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(AvataThumb), new FrameworkPropertyMetadata(typeof(AvataThumb)));
		}
		#endregion
		public AvataThumb()
		{ 
		}
	}
}
