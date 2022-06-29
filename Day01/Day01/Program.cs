using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 15, n2 = 10;
            int result = Add(n1, n2);
            PrintMessage();
            string callSign = GetMessage();
            PrintMessage(callSign);
            Timestamp(ref callSign);
            PrintMessage(callSign);

            Random rando = new Random();
            n1 = rando.Next(100);
            n2 = rando.Next(100);
            int result2 = 0;
            GetSum(n1, n2, ref result2);
            //$ - C# interpolated string
            Console.WriteLine($"{n1} + {n2} = {result2}");
            Console.WriteLine(DateTime.Now);

            string aNumber = "5";
            bool didSucceed = IntTryParse(aNumber, out int number);
            if(didSucceed)
                Console.WriteLine(number);
            else
                Console.WriteLine("ERROR!");

            MyFavoriteNumber(out int myFavorite);
            Console.WriteLine($"Your favorite number is {myFavorite}? Weird.");

            result = Add(100);
        }

        static void MyFavoriteNumber(out int fave)
        {
            Console.Write("What is your favorite number? ");
            int.TryParse(Console.ReadLine(), out fave);
        }

        static bool IntTryParse(string stringToParse, out int theNumber)
        {
            bool didParse = false;
            theNumber = 0;
            try
            {
                theNumber = int.Parse(stringToParse);
                didParse = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("That was not a number! Steev.");
            }
            return didParse;
        }

        static void Timestamp(ref string message)
        {
            message = $"{DateTime.Now}: {message}";
        }

        static void GetSum(int num1, int num2, ref int sum)
        {
            sum = num1 + num2;
        }

        static int Add(int num1, int num2 = 1)
        {
            num1 += 5;
            int sum = num1 + num2;
            return sum;
        }

        //static void PrintMessage()
        //{
        //    Console.WriteLine("Hello Gotham!");
        //}

        static void PrintMessage(string message = "Hello Gotham!")
        {
            Console.WriteLine(message);
        }

        static string GetMessage()
        {
            Console.Write("What is your call sign? ");
            string msg = Console.ReadLine();
            return msg;
        }

    }
}
