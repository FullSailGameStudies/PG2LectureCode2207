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

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            Split(nums);

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

            int number = 77;
            int index = LinearSearch(nums, number);
            Console.WriteLine();
            if (index < 0) Console.WriteLine($"{number} is not found.");
            else Console.WriteLine($"{number} is at index {index}");
        }

        static int LinearSearch(List<int> numbers, int itemToFind)
        {
            int foundIndex = -1;//-1 means not found
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == itemToFind)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }

        static void Split(List<int> numbers)
        {
            List<int> left = new List<int>();
            List<int> right = new();
            int mid = numbers.Count / 2;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < mid) left.Add(numbers[i]);
                else right.Add(numbers[i]);
            }

            Console.WriteLine("\n\n-------LEFT-------");
            foreach (var item in left)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n\n-------RIGHT-------");
            foreach (var item in right)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
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
