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

        public static void ShowVersion()
        {
            Console.WriteLine($"App Version: {k_TheVersion}");
        }

        public static void CountCapitals()
        {
            Console.WriteLine(string.Format("Please enter a sentence you want to check: "));
            string sentenceFromUser = Console.ReadLine();

            int countOfUpperLetters = sentenceFromUser.Count(char.IsUpper);
            Console.WriteLine($"There are {countOfUpperLetters} capitals in your sentence.");
        }
        
        public static void ShowTime()
        {
            DateTime currentHour = DateTime.Now;

            Console.WriteLine($"The hour is: {currentHour:HH:mm:ss}");
        }

        public static void ShowDate()
        {
            DateTime todayDate = DateTime.Today;

            Console.WriteLine($"The date is: {todayDate:dd/MM/yyyy}");
        }
    }
}
