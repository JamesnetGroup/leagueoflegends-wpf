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

namespace Lol.Profile.UI.Units
{
    public class MyItemInfoList : ListBox
    {
        #region DefaultStyleKey

        static MyItemInfoList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyItemInfoList), new FrameworkPropertyMetadata(typeof(MyItemInfoList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MyItemInfoListItem();
        }
        #endregion
    }
}
