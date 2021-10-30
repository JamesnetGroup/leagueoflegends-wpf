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
    public class NewSkinList : ListBox
    {
        #region DefaultStyleKey

        static NewSkinList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NewSkinList), new FrameworkPropertyMetadata(typeof(NewSkinList)));
        }
        #endregion
    }
}
