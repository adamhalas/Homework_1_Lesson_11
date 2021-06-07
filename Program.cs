using System;

namespace Zadanie_domowe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("******** Even or Odd  ********");
            Console.WriteLine("******************************");

            var play = true;

            while (play == true)
            {
                var number = GetNumber();

                DisplayMessage(getEven(number));

                while (true)
                {
                    Console.Write("\nGramy dalej? t/n : ");
                    var userInput = Console.ReadLine();

                    if (userInput.ToLower() != "t" && userInput.ToLower() != "n" )
                    {
                        Console.WriteLine("Please choose between 't' or 'n'. No other input!");
                        continue;
                    }
                    else if (userInput == "t")
                    {
                        break;
                    }
                    play = false;
                    break;
                }
            }

            Console.WriteLine("\nThanks for your time! Goodbye!.");

            Console.ReadLine();
        }

        private static void DisplayMessage(bool v)
        {
            switch (v)
            {
                case true:
                    Console.WriteLine("The number you entered is even.");
                    break;
                case false:
                    Console.WriteLine("The number you entered is odd.");
                    break;
            }
        }

        private static bool getEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        private static int GetNumber()
        {
            while (true)
            {

                Console.Write("\nEnter your number, please: ");
                if (!int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine("Data entered is not an integer number, try again!");
                    continue;
                }
                return result;
            }
        }
    }

}
