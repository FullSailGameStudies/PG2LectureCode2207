using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupChat03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileText = File.ReadAllText("inputFile.csv");
            List<string> comics = fileText.Split(',').ToList();
            List<string> sorted = comics.ToList();
            PG2Sorting.BubbleSort(sorted);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
