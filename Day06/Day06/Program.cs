using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 5, 4, 1, 13, 7 };
            Swap(numbers, 1, 2);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            string s1 = "Batman", s2 = "Aquaman";
            //string1.CompareTo(string2)
            //returns...
            //  -1: string1 less than string2
            //   0: string1 equals string2
            //   1: string1 greater than string2
            int compResult = s1.CompareTo(s2);
            if (compResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if(compResult == -1) Console.WriteLine($"{s1} LESS THAN {s2}");
            else if (compResult == 1) Console.WriteLine($"{s1} GREATER THAN {s2}");
        }

        static void Swap(double[] nums, int index1, int index2)
        {
            //double temp = nums[index1];
            //nums[index1] = nums[index2];
            //nums[index2] = temp;

            (nums[index2], nums[index1]) = (nums[index1], nums[index2]);
        }
    }
}
