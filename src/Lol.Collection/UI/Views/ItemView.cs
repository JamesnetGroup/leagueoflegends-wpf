using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class ItemView : View
    {
        #region DefaultStyleKey

        static ItemView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemView), new FrameworkPropertyMetadata(typeof(ItemView)));
        }
        #endregion
    }
}
