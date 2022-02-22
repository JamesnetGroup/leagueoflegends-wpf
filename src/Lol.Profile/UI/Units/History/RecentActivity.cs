using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class RecentActivity : ListBox
    {
        #region DefaultStyleKey

        static RecentActivity()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RecentActivity), new FrameworkPropertyMetadata(typeof(RecentActivity)));
        }
        #endregion
    }
}
