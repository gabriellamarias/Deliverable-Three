using System;

namespace Deliverable3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputContinue = "y";
            bool userContinue = true;

            string userNumberInput = "";
            int userNumber = 0;

            string userName = "";

            Console.WriteLine("Welcome to the Super Advanced and Highly Intelligent Number Describer (TM)!");
            Console.Write("Weary traveler, what is your name?: ");

            userName = Console.ReadLine();

            while (userContinue == true)
            {
                Console.Write(userName + ", please enter a whole number between 1 and 100: ");

                userNumberInput = Console.ReadLine();
                userNumber = Int16.Parse(userNumberInput);

                if (userNumber <= 0)
                {
                    Console.WriteLine("Now, now, " + userName + " you know the rules! Please pick a number higher than 0");
                }

                else if (userNumber > 100)
                {
                    Console.WriteLine(userName + "! Are you trying to break me?! I'm a very fragile machine, that number is far too high!");
                }

                else if (userNumber % 2 != 0 && userNumber > 60)
                {
                    Console.WriteLine(userNumber + "...very peculiar...I mean odd!");
                }

                else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 25)
                {
                    Console.WriteLine("The number is even, and less than 25.");
                }

                else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                {
                    Console.WriteLine("...even...even Steven! Isn't that your name? Oh, my apologies, " + userName);
                }

                else if (userNumber % 2 == 0 && userNumber > 60)
                {
                    Console.WriteLine(userNumber + " is an even number.");
                }

                else if (userNumber % 2 != 0)
                {
                    Console.WriteLine(userNumber + "...what an odd number to input...very odd indeed...");
                }


                Console.Write("Do you wish to continue? (y/n): ");
                userInputContinue = Console.ReadLine().ToLower();

                if (userInputContinue == "y")
                {
                    userContinue = true;

                }
                else if (userInputContinue == "n")
                {
                    Console.WriteLine("Thank you for spending time with this rickity old machine! Safe travels, " + userName + ".");
                    userContinue = false;

                    System.Environment.Exit(0);

                }


            }
        }
    }
}
        
    

    

