using Lol.LayoutSupport.Controls;
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
