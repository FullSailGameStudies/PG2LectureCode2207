using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\2207\data.csv";

            char delimiter = '>';
            #region Write CSV
            //1. Open the file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //2.Write the data
                sw.Write("Batman was here.");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(true);
                sw.Write(delimiter);
                sw.Write(13.2);
                sw.Write(delimiter);
                sw.Write(571);
            }//3. closes the file 
            #endregion

            #region Read CSV
            //1. open the file
            using (StreamReader sr = new StreamReader(filePath))
            {
                //2. read the file
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] data = line.Split(delimiter);
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }//3. close the file
            //OR....use File.ReadAllText to read the entire file
            string lineData = File.ReadAllText(filePath);//opens, reads, closes the file
            string[] dataCSV = lineData.Split(delimiter);
            #endregion


            WriteData(filePath);
            ReadData(filePath);
        }

        private static void ReadData(string filePath)
        {
            char delimiter = '>';
            string fileText = File.ReadAllText(filePath);
            string[] nums = fileText.Split(delimiter);
            List<int> numbers = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (int.TryParse(nums[i], out int num))
                    numbers.Add(num);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static void WriteData(string fPath)
        {
            List<int> nums = new() { 5, 4, 3, 2, 1 };

            char delimiter = '>';
            //1. Open the file
            using (StreamWriter sw = new StreamWriter(fPath))
            {
                bool isFirst = true;
                for (int i = 0; i < nums.Count; i++)
                {
                    if(!isFirst)
                        sw.Write(delimiter);
                    sw.Write(nums[i]);
                    isFirst = false;
                }
            }
        }
    }
}
