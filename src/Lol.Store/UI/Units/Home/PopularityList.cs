using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lol.Store.UI.Units
{
    public class PopularityList : ListBox
    {
        #region DefaultStyleKey

        static PopularityList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopularityList), new FrameworkPropertyMetadata(typeof(PopularityList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PopularityListItem();
        }
        #endregion
    }
}
