using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private MenuItem r_Menu;
        private const string k_BackOption = "Back";
        private const string k_ExitOption = "Exit";
        private const int k_ChooseToQuit = 0;

        public MainMenu(string i_MenuTitle)
        {
            r_Menu = new MenuItem(i_MenuTitle, null);
        }
        public void AddNewSubMenu(string i_MenuTitle)
        {
            r_Menu.AddMenuToCurrentLevelMenus(i_MenuTitle);
        }
        public void Show() //main loop
        {
            bool exitPressed = false;

            while (!exitPressed)
            {
                string QuitOption = r_Menu.PreviousMenu == null ? k_ExitOption : k_BackOption;
                r_Menu.PrintMenu(QuitOption);
                int inputFromUser = gettingOptionFromUser();

                if (inputFromUser == k_ChooseToQuit) 
                {
                    if (r_Menu.PreviousMenu != null) 
                    {
                        r_Menu = r_Menu.PreviousMenu;
                    }
                    else
                    {
                        exitPressed = true;
                    }
                }
                else
                {
                    r_Menu = r_Menu.GetSubMenuChosenByUser(inputFromUser - 1);
                    if(r_Menu.ItemsBelongThisLevelLenght == 0)
                    {
                        r_Menu.SelectdOption();
                        r_Menu = r_Menu.PreviousMenu;
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
                catch (ValueOutOfRangeException ex)
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
                throw new FormatException("Invalid input format, Please enter a valid number. ");
            }
            else if (io_InputFromUser < 0 || io_InputFromUser > r_Menu.ItemsBelongThisLevelLenght)
            {
                throw new ValueOutOfRangeException(0, r_Menu.ItemsBelongThisLevelLenght);
            }
        }
    }
}
