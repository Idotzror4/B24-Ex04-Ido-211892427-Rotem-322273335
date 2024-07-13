using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private MenuItem m_Menu;
        private const string k_BackOption = "Back";
        private const string k_ExitOption = "Exit";
        private const int k_ChooseToQuit = 0;

        public MainMenu(string i_MenuTitle)
        {
            m_Menu = new MenuItem(i_MenuTitle, null);
        }

        public MenuItem TheMenu
        {
            get { return m_Menu; }
        }

        public MenuItem AddNewSubMenu(string i_MenuTitle)
        {
            return m_Menu.AddMenuToCurrentLevelMenus(i_MenuTitle);
        }

        public void Show() //main loop
        {
            bool exitPressed = false;

            while (!exitPressed)
            {
                string QuitOption = m_Menu.PreviousMenu ==
                                      null ? k_ExitOption : k_BackOption;
                int inputFromUser;

                m_Menu.PrintMenu(QuitOption);
                inputFromUser = gettingOptionFromUser();
                if (inputFromUser == k_ChooseToQuit)
                {
                    if (m_Menu.PreviousMenu != null)
                    {
                        m_Menu = m_Menu.PreviousMenu;
                    }
                    else
                    {
                        exitPressed = true;
                    }
                }
                else
                {
                    m_Menu = m_Menu.GetSubMenuChosenByUser(inputFromUser - 1);
                    if (m_Menu.ItemsBelongThisLevelLenght == 0)
                    {
                        m_Menu.SelectedOption();
                        m_Menu = m_Menu.PreviousMenu;
                    }
                }
            }
        }

        private int gettingOptionFromUser()
        {
            bool validInput = false;
            int inputFromUser = 0;

            while (!validInput)
            {
                try
                {
                    validationCheckForUserInput(out inputFromUser);
                    validInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return inputFromUser;
        }

        private void validationCheckForUserInput(out int io_InputFromUser)
        {
            if (!int.TryParse(Console.ReadLine(), out io_InputFromUser))
            {
                throw new FormatException(string.Format(
                                      "Invalid input format, Please enter a valid number."));
            }
            else if (io_InputFromUser < 0 || 
                                      io_InputFromUser > m_Menu.ItemsBelongThisLevelLenght)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
