using Ex04.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu interfaceMenu = InterfaceMenuTest.CreateInterfaceMenu();
            interfaceMenu.Show();

            Events.MainMenu delegatesMenu = DelegateMenuTest.CreateDelegateMenu();
            delegatesMenu.Show();
        }
    }
}
