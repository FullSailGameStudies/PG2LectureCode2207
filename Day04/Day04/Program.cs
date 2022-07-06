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

            WriteData(filePath);
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
