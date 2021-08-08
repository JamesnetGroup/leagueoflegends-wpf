using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.Client.UI.Views
{
    public class AlarmView : View
    {
        #region DefaultStyleKey

        static AlarmView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AlarmView), new FrameworkPropertyMetadata(typeof(AlarmView)));
        }
        #endregion
    }
}
