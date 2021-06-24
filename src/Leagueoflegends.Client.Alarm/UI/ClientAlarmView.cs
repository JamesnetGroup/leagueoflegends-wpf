using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Alarm.UI
{
	public class ClientAlarmView : View
    {
        #region DefaultStyleKey

        static ClientAlarmView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientAlarmView), new FrameworkPropertyMetadata(typeof(ClientAlarmView)));
        }
		#endregion
	}
}
