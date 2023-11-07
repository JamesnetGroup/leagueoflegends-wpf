using Lol.Database.Entites.Schema;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lol.Settings.Client.UI.Units
{
    public class InputModeListBoxItem : ListBoxItem
    {
        public ICommand ChangeVoiceModeCommand
        {
            get { return (ICommand)GetValue (ChangeVoiceModeCommandProperty); }
            set { SetValue (ChangeVoiceModeCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VoiceChangeCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChangeVoiceModeCommandProperty =
            DependencyProperty.Register ("ChangeVoiceModeCommand", typeof (ICommand), typeof (InputModeListBoxItem), new PropertyMetadata (null));


        static InputModeListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InputModeListBoxItem), new FrameworkPropertyMetadata(typeof(InputModeListBoxItem)));
        }

        public InputModeListBoxItem()
        {
            Selected += (sender, args) =>
            {
                ChangeVoiceModeCommand?.Execute (this.DataContext as UsualCodes);
            };
        }
    }
}
