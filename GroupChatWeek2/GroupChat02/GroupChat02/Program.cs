namespace GroupChat02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? number = null;//need a value assigned
            //scope
            if(false)
            {
                number = 10;//will never get here so line 8 needs to assign a value
            }

            Console.WriteLine(number);//will print 10

            int carYear = Input.ReadInteger("What is the year of your car? ", 1908, DateTime.Now.Year + 1);
            Console.WriteLine($"Your car's make year is {carYear}.");

            string make = string.Empty;
            Input.ReadString("What is the make of your car? ", ref make);

            string model = string.Empty;
            Input.ReadString("What is the model of your car? ", ref model);
            Console.WriteLine($"Your car is a {carYear} {make} {model}");

            string[] menu = new string[] { "1. Sell Car", "2. Buy Car", "3. Exit" };

            bool exitApp = false;
            do
            {
                Input.ReadChoice("Choice? ", menu, out int selection);
                if (selection == 1) Console.WriteLine("Buying another car?!");
                else if (selection == 2) Console.WriteLine("Selling your car?");
                else break;

                //
                //OR
                //
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Buying another car?!");
                        break;
                    case 2: 
                        Console.WriteLine("Selling your car?");
                        break;
                    case 3:
                        exitApp = true;
                        break;
                    default:
                        break;
                }
            } while (!exitApp);

        }


    }

    public static class Input
    {
        public static int ReadInteger(string prompt, int min, int max)
        {
            //don't return until the user enters a valid number
            do
            {
                Console.Write(prompt);

                //get input from the user
                //string? input = Console.ReadLine();

                //try to convert input to a number
                //bool isGood = int.TryParse(Console.ReadLine(), out int number);

                //validate the number
                //isGood and the min/max range
                if (int.TryParse(Console.ReadLine(), out int number) && number >= min && number <= max)
                    return number;//a good number

                Console.WriteLine($"That was not a valid number.");
            } while (true);
        }

        public static void ReadString(string prompt, ref string input)
        {
            do
            {
                Console.Write(prompt);
                //?? - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
                input = Console.ReadLine() ?? string.Empty;

                if (!string.IsNullOrWhiteSpace(input))
                    break;


                Console.WriteLine($"That was not a valid input.");
            } while (true);
        }

        public static void ReadChoice(string prompt, string[] options, out int menuSelection)
        {
            //show the menu options
            foreach (var menuOption in options)
                Console.WriteLine(menuOption);

            menuSelection = ReadInteger(prompt, 1, options.Length);
        }
    }
}