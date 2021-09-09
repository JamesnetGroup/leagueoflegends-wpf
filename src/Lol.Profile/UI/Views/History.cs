using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Profile.UI.Views
{

	public class History : View
    {
        #region DefaultStyleKey

        static History()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(History), new FrameworkPropertyMetadata(typeof(History)));
        }
        #endregion
    }
}
