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

namespace Lol.GameRoom.UI.Units
{
    public class MapTitle_Custom : Control
    {
        #region DefaultStyleKey


        static MapTitle_Custom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapTitle_Custom), new FrameworkPropertyMetadata(typeof(MapTitle_Custom)));
        }
        #endregion
    }
}
