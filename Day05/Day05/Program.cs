using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (true)
            {
                number++;
                if (number > 10) break;
            }
            Console.WriteLine("FOR-------------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("RECURSION-----------");
            Counter(0);
            Console.ResetColor();
            Console.WriteLine();
            Bats(0);
            Console.WriteLine("Batman!");

            int N = 5;
            long result = Factorial(N);
            Console.WriteLine($"{N}! = {result}");
        }

        static long Factorial(int N)
        {
            //exit condition
            if (N <= 1) return 1;

            //N! = N * (N-1)!
            long result = N * Factorial(N - 1);
            return result;
        }


        static void Bats(int i)
        {
            if(i < 100)
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(i + 1);
            }
        }
        static void Counter(int num)
        {
            if (num < 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(num);
                Counter(num + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(num);
            }
        }//last line in Counter.
    }
}
