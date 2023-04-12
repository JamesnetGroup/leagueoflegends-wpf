using System.Windows.Input;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives
{
    public class BaseWindow : RiotWindow
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
                GetWindow(this).DragMove();
            }
        }
    }
}
