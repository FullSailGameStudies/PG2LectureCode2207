using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Day02
    {
        public static void Run()
        {
            ArrayChallenge();

            List<int> numbers;//default is null for reference types
            //create an instance of List<int>
            numbers = new List<int>(10);// { 1, 2, 3, 4 };
            //numbers[0] = 1;//won't work!!
            Info(numbers);//Count: 0, Capacity: 0
            numbers.Add(5);
            Info(numbers);//Count: 1, Capacity: 4
            numbers.Add(5);
            numbers.Add(5);
            numbers.Add(5);//Count: 4, Capacity: 4
            numbers.Add(5);//Count: 5, Capacity: ?
            Info(numbers);//Count: 5, Capacity: 8
            numbers.Add(5);
            numbers.Add(5);
            numbers.Add(5);//Count: 8, Capacity: 8
            numbers.Add(5);
            Info(numbers);//Count: 9, Capacity: 16
            //Console.WriteLine(numbers[13]);

            ListChallenge();
        }

        static void ArrayChallenge()
        {
            Random randy = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randy.Next(100);
            }
            foreach (int number in nums)
            {
                Console.WriteLine(number);
            }
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();
            Random rando = new Random();

            for (int i = 0; i < 10; i++)
            {
                grades.Add(rando.NextDouble()*100);
            }
            PrintGrades(grades);
        }

        static void PrintGrades(List<double> courseGrades)
        {
            Console.WriteLine("----------GRADES-----------");
            foreach (double grade in courseGrades)
            {
                //,8  right-align in 8 spaces
                //:N2 number with 2 decimal places
                Console.WriteLine($"{grade,8:N2}");
            }
            //OR
            //for (int i = 0; i < courseGrades.Count; i++)
            //{

            //}
        }

        static void Info(List<int> list)
        {
            //Count - # of items added to the list
            //Capacity - Length of the internal array
            Console.WriteLine($"Count: {list.Count}\tCapacity: {list.Capacity}");
        }
    }
}
