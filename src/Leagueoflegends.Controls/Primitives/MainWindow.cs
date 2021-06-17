using Leagueoflegends.Windowbase.Riotbase;
using System.Windows;
using System.Windows.Input;

namespace Leagueoflegends.Controls.Primitives
{
	public class MainWindow : RiotWindow
	{
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			if (GetTemplateChild("PART_DragBar") is DragBorder bar)
			{
				bar.MouseDown += Bar_MouseDown;
			}
		}

		private void Bar_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				Window.GetWindow(this).DragMove();
			}
		}
	}
}
