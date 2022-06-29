using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            List<int> num2 = numbers.ToList();
            num2 = new List<int>(numbers);

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

            List<int> numList1 = nums.ToList();
            List<int> numList2 = new List<int>(nums);
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();
            Random rando = new Random();

            for (int i = 0; i < 10; i++)
            {
                grades.Add(rando.NextDouble() * 100);
            }
            PrintGrades(grades);
            int numDropped = DropFailing(grades);
            Console.WriteLine($"Dropped {numDropped} from the course.");
            PrintGrades(grades);
            Console.WriteLine("Curving grades...");
            List<double> curvedGrades = CurveGrades(grades);
            PrintGrades(curvedGrades);
        }

        static List<double> CurveGrades(List<double> course)
        {
            List<double> curved = course.ToList();
            for (int i = 0; i < curved.Count; i++)
            {
                //if (curved[i] > 95) curved[i] = 100;
                //else curved[i] += 5;
                //OR use a ternary operator
                curved[i] = (curved[i] > 95) ? 100 : curved[i] + 5;
            }
            return curved;
        }

        static int DropFailing(List<double> course)
        {
            int drops = 0;
            for (int i = 0; i < course.Count; i++)
            {
                if (course[i] < 59.5)
                {
                    course.RemoveAt(i);
                    drops++;
                    i--;
                }
            }
            //OR use a reverse for loop
            //for (int i = course.Count - 1; i >= 0; i--)
            //{
            //    if (course[i] < 59.5)
            //    {
            //        course.RemoveAt(i);
            //        drops++;
            //    }
            //}
            return drops;
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
            //OR with a for loop
            //for (int i = 0; i < courseGrades.Count; i++)
            //{
            //    Console.WriteLine($"{courseGrades[i],8:N2}");
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
