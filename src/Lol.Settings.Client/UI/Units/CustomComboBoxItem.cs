using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;
using System.Windows.Input;

namespace Lol.Settings.Client.UI.Units
{
    public class CustomComboBoxItem : RiotComboBoxItem
    {
        public ICommand ChangeItmeModeCommand
        {
            get { return (ICommand)GetValue (ChangeItmeModeCommandProperty); }
            set { SetValue (ChangeItmeModeCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VoiceChangeCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChangeItmeModeCommandProperty =
            DependencyProperty.Register ("ChangeItmeModeCommand", typeof (ICommand), typeof (RiotComboBoxItem), new PropertyMetadata (null));

        public CustomComboBoxItem()
        {
            this.Selected += ((s, e) =>
            {
                this.ChangeItmeModeCommand?.Execute (this.DataContext);
            });
        }
    }
}
