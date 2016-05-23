using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        public readonly string r_Name;

        protected MenuItem(string i_Name)
        {
            r_Name = i_Name;
        }
    }
}
