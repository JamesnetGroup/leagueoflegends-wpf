using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class RiotTextBox : TextBox
    {
        #region DefaultStyleKey

        static RiotTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotTextBox), new FrameworkPropertyMetadata(typeof(RiotTextBox)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(RiotTextBox));
        #endregion

        #region Command

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }
        #endregion

        #region OnTextInput

        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            base.OnTextInput(e);
        }
        #endregion

        #region OnTextChanged

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);
            Command?.Execute(this);
        }
        #endregion

        #region OnKeyDown

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
		#endregion
	}
}
