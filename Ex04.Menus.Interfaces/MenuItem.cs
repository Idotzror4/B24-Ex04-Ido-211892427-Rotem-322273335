using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private readonly string r_MenuTitle;
        private readonly MenuItem r_PreviousMenu;
        private List<MenuItem> m_ItemsBelongThisLevel = new List<MenuItem>();
        private List<ISelectedLeafMenuItem> m_ = new List<ISelectedLeafMenuItem>();
        private const string k_DottedLine = "-----------------------";

        public MenuItem PreviousMenu
        {
            get { return r_PreviousMenu; }
        }

        public int ItemsBelongThisLevelLenght
        {
            get { return m_ItemsBelongThisLevel.Count; }
        }

        public MenuItem GetSubMenuChosenByUser(int i_Index)
        {
            return m_ItemsBelongThisLevel[i_Index];
        }

        public MenuItem(string i_MenuTitle, MenuItem i_PreviousMenu)
        {
            r_MenuTitle = i_MenuTitle;
            r_PreviousMenu = i_PreviousMenu;
        }

        public void AddMenuToCurrentLevelMenus(string i_MenuTitle)
        {
            m_ItemsBelongThisLevel.Add(new MenuItem(i_MenuTitle, this));
        }

        public void SelectdOption()
        {
            Console.Clear();
            // notify listeners
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void PrintMenu(string i_quitTheMenu)
        {
            Console.Clear();

            Console.WriteLine($"**{r_MenuTitle}**");
            Console.WriteLine(k_DottedLine);

            for (int i = 0; i < m_ItemsBelongThisLevel.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> {m_ItemsBelongThisLevel[i].r_MenuTitle}");
            }
            Console.WriteLine($"0 -> {i_quitTheMenu}");

            Console.WriteLine(k_DottedLine);
            Console.WriteLine($"Enter your request: (1 to {m_ItemsBelongThisLevel.Count} or press '0' to {i_quitTheMenu}");
        }
    }
}
