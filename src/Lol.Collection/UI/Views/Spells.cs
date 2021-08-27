using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
	public class Spells : View
    {
        #region DefaultStyleKey

        static Spells()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spells), new FrameworkPropertyMetadata(typeof(Spells)));
        }
		#endregion
	}
}
