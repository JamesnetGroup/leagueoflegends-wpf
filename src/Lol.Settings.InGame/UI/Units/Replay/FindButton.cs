using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class FindButton : Control
    {
        #region DefaultStyleKey

        static FindButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FindButton), new FrameworkPropertyMetadata(typeof(FindButton)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty SavePathProperty = DependencyProperty.Register("SavePath", typeof(string), typeof(FindButton), new PropertyMetadata(""));
        #endregion

        #region SavePath

        public string SavePath
        {
            get { return (string)this.GetValue(SavePathProperty); }
            set { this.SetValue(SavePathProperty, value); }
        }
        #endregion
    }
}
