using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : ISelectedLeafMenuItem
    {
        private readonly MenuItem r_MenuItem;

        public CountCapitals(MenuItem i_MenuItem)
        {
            r_MenuItem = i_MenuItem;
            r_MenuItem.AddListener(this);
        }

        void ISelectedLeafMenuItem.ExecuteMenuItemAction()
        {
            Methods.CountCapitals();
        }
    }
}
