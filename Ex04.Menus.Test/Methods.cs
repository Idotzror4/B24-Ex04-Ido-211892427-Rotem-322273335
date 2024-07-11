using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Methods
    {
        private const string k_TheVersion = "24.2.4.9504";

        public void ShowVersion()
        {
            Console.WriteLine($"App Version: {k_TheVersion}");
        }

        public void CountCapitals()
        {
            Console.WriteLine("Please enter a sentence you want to check: ");
            string sentenceFromUser = Console.ReadLine();
            int countOfUpperLetters = sentenceFromUser.Count(char.IsUpper);
            Console.WriteLine($"There are {k_TheVersion} capitals in your sentence.");
        }
        
        public void ShowTime()
        {
            DateTime currentHour = DateTime.Now;
            Console.WriteLine($"The hour is: {currentHour:HH:mm:ss}");
        }

        public void ShowDate()
        {
            DateTime todayDate = DateTime.Today;
            Console.WriteLine($"The date is: {todayDate:d}");
        }
    }
}
