using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Support.Local.Models
{
    public class MenuChangedEventArgs : EventArgs
    {
        public int MenuId = -1;
        public bool UseSubMenu = false;

        public MenuChangedEventArgs(int menuId)
        {
            MenuId = menuId;
        }
    }
}
