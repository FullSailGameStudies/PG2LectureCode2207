using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal static class Day3
    {
        public static void Run()
        {
            DictionaryExample();

            PressAnyKey();

            DictionaryChallenges();
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DictionaryChallenges()
        {
            List<string> students = new()
            {
                "Dominic", "Tanner", "Deven", "Bobby", "Noah",
                "Erik", "Reagan", "Desmond", "Mason", "Victor", "Bailey",
                "Derek", "John"
            };           

            Random rando = new Random();

            Dictionary<string, double> pg2 = new()
            {
                {"Garrett",rando.NextDouble()*100 }
            };
            for (int i = 0; i < students.Count; i++)
            {
                pg2.Add(students[i], rando.NextDouble() * 100);
                //OR
                pg2[students[i]] = rando.NextDouble() * 100;
            }

            PrintGrades(pg2);
        }

        static void PrintGrades(Dictionary<string, double> course)
        {
            Console.Clear();
            string title = "------GRADES-------";
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2 - course.Count / 2;
            Console.SetCursorPosition(x - title.Length / 2, y);
            Console.WriteLine(title);
            foreach (var student in course)
            {
                Console.CursorLeft = x - 7;
                double grade = student.Value;
                Console.Write($"{student.Key}");

                Console.CursorLeft = x + 2;

                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if(grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{grade,7:N2}");
                Console.ResetColor();
            }
        }

        private static void DictionaryExample()
        {
            List<int> nu = new List<int>() { 1, 2, 3, 4 };
            nu.Add(5);
            //RULES:
            //  keys MUST BE UNIQUE
            //  values does not need to be unique
            Dictionary<string, float> menu = new()
            {
                //{key, value}
                { "Burger", 4.99F },
                { "Cheesy Burger", 6.99F }
                //{ "Cheesy Burger", 8.99F }//throws exception
            };
            //Add(key,value)
            menu.Add("fries", 2.99F);
            //menu.Add("fries", 2.99F);//throws exception

            //[key] = value;
            menu["choc shake"] = 4.99F;
            menu["choc shake"] = 7.99F;//overwrites. no exception.

            ShowMenu(menu);

            string itemToRemove = "tater tots";
            bool wasRemoved = menu.Remove(itemToRemove);
            if(wasRemoved)
                Console.WriteLine($"{itemToRemove} was removed from the menu.");
            else
                Console.WriteLine($"{itemToRemove} was not on the menu.");
        }

        private static void ShowMenu(Dictionary<string, float> menu)
        {
            Console.Clear();
            Console.WriteLine("------------FullSail Bites-----------");
            foreach (KeyValuePair<string,float> menuItem in menu)
            {
                Console.WriteLine($"{menuItem.Value,8:C2} {menuItem.Key}");
            }
        }
    }
}
