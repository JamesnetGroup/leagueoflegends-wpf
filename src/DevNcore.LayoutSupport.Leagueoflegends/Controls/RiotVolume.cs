using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotVolume : Control
    {
        #region DefaultStyleKey

        static RiotVolume()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotVolume), new FrameworkPropertyMetadata(typeof(RiotVolume)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(double), typeof(RiotVolume), new PropertyMetadata(double.NaN));
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(RiotVolume), new PropertyMetadata(""));
        public static readonly DependencyProperty IsMuteProperty = DependencyProperty.Register("IsMute", typeof(bool), typeof(RiotVolume), new PropertyMetadata(false));
        public static readonly DependencyProperty IsHeaderVisibleProperty = DependencyProperty.Register("IsHeaderVisible", typeof(bool), typeof(RiotVolume), new PropertyMetadata(false));
        #endregion

        #region Value

        public double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }
        #endregion

        #region Header

        public string Header
        {
            get { return (string)this.GetValue(HeaderProperty); }
            set { this.SetValue(HeaderProperty, value); }
        }
        #endregion

        #region IsMute

        public bool IsMute
        {
            get { return (bool)this.GetValue(IsMuteProperty); }
            set { this.SetValue(IsMuteProperty, value); }
        }
        #endregion

        #region IsHeaderVisible

        public bool IsHeaderVisible
        {
            get { return (bool)this.GetValue(IsHeaderVisibleProperty); }
            set { this.SetValue(IsHeaderVisibleProperty, value); }
        }
        #endregion
    }
}
