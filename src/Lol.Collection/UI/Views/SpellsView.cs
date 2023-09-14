using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class SpellsView : JamesContent
    {
        #region DefaultStyleKey

        static SpellsView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellsView), new FrameworkPropertyMetadata(typeof(SpellsView)));
        }
        #endregion
    }
}
