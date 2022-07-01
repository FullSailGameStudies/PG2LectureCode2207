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

            DictionaryChallenges();
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

        }
    }
}
