using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.Views
{
	public class Currency : ContentControl
	{
		#region DefaultStyleKey

		static Currency()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Currency), new FrameworkPropertyMetadata(typeof(Currency)));
		}
		#endregion
	}
}
