using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : ISelectedLeafMenuItem
    {
        private readonly MenuItem r_MenuItem;

        public ShowDate(MenuItem i_MenuItem)
        {
            r_MenuItem = i_MenuItem;
            r_MenuItem.AddListener(this);
        }

        void ISelectedLeafMenuItem.ExecuteMenuItemAction()
        {
            Methods.ShowDate();
        }
    }
}
