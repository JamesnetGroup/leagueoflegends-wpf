using System;

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
