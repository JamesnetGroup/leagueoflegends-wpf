using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using Lol.Data.Codes;
using System.Windows;
using System.Windows.Input;

namespace Lol.Settings.Client.UI.Units
{
    public class OutputModeComboBoxItem : RiotComboBoxItem
    {
        public ICommand ChangeOutputModeCommand
        {
            get { return (ICommand)GetValue (ChangeOutputModeCommandProperty); }
            set { SetValue (ChangeOutputModeCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VoiceChangeCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChangeOutputModeCommandProperty =
            DependencyProperty.Register ("ChangeOutputModeCommand", typeof (ICommand), typeof (RiotComboBoxItem), new PropertyMetadata (null));

        public OutputModeComboBoxItem()
        {
            this.Selected += ((s, e) =>
            {
                this.ChangeOutputModeCommand?.Execute (this.DataContext as AudioDevice);
            });
        }
    }
}
