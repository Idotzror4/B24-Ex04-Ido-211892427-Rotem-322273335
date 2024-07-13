using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InterfaceMenuTest
    {
        public static MainMenu CreateInterfaceMenu()
        {
            MainMenu mainMenu = new MainMenu("Interface Main Menu");

            MenuItem versionAndCapitalsMenu = addSubMenu(mainMenu, "Version and Capitals");
            MenuItem showDateTimeMenu = addSubMenu(mainMenu, "Show Date/Time");
            addMenuItems(versionAndCapitalsMenu, showDateTimeMenu);

            return mainMenu;
        }

        private static MenuItem addSubMenu(MainMenu i_MainMenu, string i_SubMenuTitle)
        {
            return i_MainMenu.AddNewSubMenu(i_SubMenuTitle);
        }

        private static void addMenuItems(MenuItem i_VersionAndCapitalsMenu, MenuItem i_ShowDateTimeMenu)
        {
            MenuItem showVersionMenuItem = 
                     i_VersionAndCapitalsMenu.AddMenuToCurrentLevelMenus("Show Version");
            MenuItem countCapitalsMenuItem = 
                     i_VersionAndCapitalsMenu.AddMenuToCurrentLevelMenus("Count Capitals");
            MenuItem showDateMenuItem = 
                     i_ShowDateTimeMenu.AddMenuToCurrentLevelMenus("Show Date");
            MenuItem showTimeMenuItem = 
                     i_ShowDateTimeMenu.AddMenuToCurrentLevelMenus("Show Time");

            new ShowVersion(showVersionMenuItem);
            new CountCapitals(countCapitalsMenuItem);
            new ShowDate(showDateMenuItem);
            new ShowTime(showTimeMenuItem);
        }
    }
}
