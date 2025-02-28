using Jamesnet.Foundation;
using Jamesnet.Platform.WPF;
using System.Windows.Controls;

namespace Leagueoflegends.Clash.UI.Views;

public class HubContent : ContentControl, IView
{
    public HubContent()
    {
        DefaultStyleKey = typeof(HubContent);   
    }
}
