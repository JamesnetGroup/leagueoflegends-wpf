using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Settings.UI.Views
{
    public class EmptyView : View
    {
        static EmptyView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyView), new FrameworkPropertyMetadata(typeof(EmptyView)));
        }
    }
}
