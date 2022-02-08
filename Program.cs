using System;

namespace NumberAnalyzer
{
    public class NumberAnalyzer
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Hi " + userName + ", Welcome to My Magical Number Analyzer!");
            var analyze = true;

            do
            {
                Console.WriteLine();
                Console.Write("Please enter an integer between 1 and 100: ");
                var userInput = 0;
                var isInteger = Int32.TryParse(Console.ReadLine(), out userInput);

                if (!isInteger)
                {
                    Console.WriteLine(userName + ", " + userInput + " is not an integer.");
                }
                else if (userInput < 1 || userInput > 100)
                {
                    Console.WriteLine(userName + ", " + userInput + " is out of range.");
                }
                else if (userInput % 2 > 0 && userInput < 60)
                {
                    Console.WriteLine(userName + ", " + userInput + " is Odd and less than 60.");
                }
                else if (userInput % 2 > 0 && userInput > 60)
                {
                    Console.WriteLine(userName + ", " + userInput + " is Odd and greater than 60.");
                }
                else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 24)
                {
                    Console.WriteLine(userName + ", " + userInput + " is Even and less than 25.");
                }
                else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine(userName + ", " + userInput + " is Even and between 26 and 60 inclusive.");
                }
                else if (userInput % 2 == 0 && userInput > 60)
                {
                    Console.WriteLine(userName + ", " + userInput + " is Even and greater than 60.");
                }

                Console.WriteLine();
                Console.Write("To analyze another number, please enter 'y' or 'yes' -OR- press any other key to exit: ");
                var analyzeResponse = Console.ReadLine().ToLower();

                analyze = (analyzeResponse == "y" || analyzeResponse == "yes") ? true : false;

            } while (analyze == true);

            Console.WriteLine("Thanks for playing, Bye-bye!");
        }
    }
}