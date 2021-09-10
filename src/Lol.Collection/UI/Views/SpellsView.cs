using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
	public class SpellsView : View
    {
        #region DefaultStyleKey

        static SpellsView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellsView), new FrameworkPropertyMetadata(typeof(SpellsView)));
        }
		#endregion
	}
}
