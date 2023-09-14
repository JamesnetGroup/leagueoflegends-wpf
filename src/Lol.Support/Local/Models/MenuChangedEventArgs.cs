using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Support.Local.Models
{
    public class MenuChangedEventArgs : EventArgs
    {
        public int MenuId = -1;
        public bool UseSubMenu = false;

        public bool GoHome = false;
        public bool ModeChange = false;

        public MenuChangedEventArgs(int menuId)
        {
            MenuId = menuId;
        }

        public MenuChangedEventArgs(string name)
        {
            if (name == "Home")
            { 
                GoHome = true;
            }
            if (name == "ModeChange")
            {
                ModeChange = true;
            }
        }

    }
}
