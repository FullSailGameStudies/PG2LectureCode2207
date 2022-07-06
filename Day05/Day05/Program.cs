using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            //0,0
            //1,1
            _fib.Add(0, 0);
            _fib[1] = 1;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 145; i++)
            {
                sw.Restart();
                ulong fib = Fibonacci2(i);
                sw.Stop();
                long ms = sw.ElapsedMilliseconds;
                Console.Write($"Fib({i}) = {fib}");
                Console.CursorLeft = 50;
                Console.WriteLine($"{ms} ms");
            }
        }

        static Dictionary<int, ulong> _fib = new Dictionary<int, ulong>();

        static ulong Fibonacci2(int N)
        {
            //exit condition
            if (_fib.TryGetValue(N, out ulong result))
                return result;

            //Fib(N) = Fib(N-1) + Fib(N-2)
            result = Fibonacci2(N - 1) + Fibonacci2(N - 2);
            _fib.Add(N, result);
            return result;
        }//O(N) - linear

        static ulong Fibonacci(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;

            //Fib(N) = Fib(N-1) + Fib(N-2)
            ulong result = Fibonacci(N - 1) + Fibonacci(N - 2);
            return result;
        }//O(2^N)

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
