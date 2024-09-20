using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class ChampionsView : JamesContent
    {
        static ChampionsView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampionsView), new FrameworkPropertyMetadata(typeof(ChampionsView)));
        }
    }
}
