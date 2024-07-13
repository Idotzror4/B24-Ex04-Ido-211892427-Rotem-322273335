using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    internal class DelegateMenuTest
    {
        public static MainMenu CreateDelegateMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");

            MenuItem versionAndCapitalsMenu = addSubMenu(mainMenu, "Version and Capitals");
            MenuItem showDateTimeMenu = addSubMenu(mainMenu, "Show Date/Time");
            addMenuItems(versionAndCapitalsMenu, showDateTimeMenu);

            return mainMenu;
        }

        private static MenuItem addSubMenu(MainMenu i_MainMenu, string i_SubMenuTitle)
        {
            return i_MainMenu.AddNewSubMenu(i_SubMenuTitle);
        }

        private static void addMenuItems(MenuItem i_VersionAndCapitalsMenu,
                                         MenuItem i_ShowDateTimeMenu)
        {
            MenuItem showVersionMenuItem = 
                    i_VersionAndCapitalsMenu.AddMenuToCurrentLevelMenus("Show Version");
            MenuItem countCapitalsMenuItem = 
                    i_VersionAndCapitalsMenu.AddMenuToCurrentLevelMenus("Count Capitals");
            MenuItem showDateMenuItem = 
                    i_ShowDateTimeMenu.AddMenuToCurrentLevelMenus("Show Date");
            MenuItem showTimeMenuItem = 
                    i_ShowDateTimeMenu.AddMenuToCurrentLevelMenus("Show Time");

            showVersionMenuItem.Selected += showVersion_Selected;
            countCapitalsMenuItem.Selected += countCapitals_Selected;
            showDateMenuItem.Selected += showDate_Selected;
            showTimeMenuItem.Selected += showTime_Selected;
        }

        private static void showDate_Selected()
        {
            Methods.ShowDate();
        }

        private static void showTime_Selected()
        {
            Methods.ShowTime();
        }

        private static void countCapitals_Selected()
        {
            Methods.CountCapitals();
        }

        private static void showVersion_Selected()
        {
            Methods.ShowVersion();
        }
    }
}
