using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
	public class Champions : View
    {
        #region DefaultStyleKey

        static Champions()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Champions), new FrameworkPropertyMetadata(typeof(Champions)));
        }
		#endregion
	}
}
