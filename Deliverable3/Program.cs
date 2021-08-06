using System;

namespace Deliverable3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputContinue = "y";
            bool userContinue = true;
            bool userTryAgain = true;

            string userNumberInput = "";
            int userNumber = 0;

            string userName = "";

            Console.WriteLine("Welcome to the Super Advanced and Highly Intelligent Number Describer (TM)!");
            Console.Write("Weary traveler, what is your name?: ");

            userName = Console.ReadLine();

            while (userContinue == true)
            {
                userTryAgain = true;

                Console.Write(userName + ", please enter a whole number between 1 and 100: ");
                userNumberInput = Console.ReadLine();
                if (int.TryParse(userNumberInput, out userNumber))
                {
                }

                else
                {
                    Console.WriteLine("Now, now, an integer, if you please.");
                    userContinue = true;
                }


                if (userNumber < 0)
                {
                    Console.WriteLine("Now, now, " + userName + " you know the rules! Please pick a number higher than 0");
                    userContinue = true;
                }

                else if (userNumber > 100)
                {
                    Console.WriteLine(userName + "! Are you trying to break me?! I'm a very fragile machine, that number is far too high!");
                    userContinue = true;
                }

                else if (userNumber % 2 != 0 & userNumber > 60)
                {
                    Console.WriteLine(userNumber + "...very peculiar...I mean odd!");
                    userContinue = false;
                }

                else if (userNumber % 2 == 0 & userNumber >= 2 && userNumber <= 25)
                {
                    Console.WriteLine("The number is even, and less than 25.");
                    userContinue = false;
                }

                else if (userNumber % 2 == 0 & userNumber >= 26 && userNumber <= 60)
                {
                    Console.WriteLine("...even...even Steven! Isn't that your name? Oh, my apologies, " + userName);
                    userContinue = false;
                }

                else if (userNumber % 2 == 0 & userNumber > 60)
                {
                    Console.WriteLine(userNumber + " is an even number.");
                    userContinue = false;
                }

                else if (userNumber % 2 != 0)
                {
                    Console.WriteLine(userNumber + "...what an odd number to input...very odd indeed...");
                    userContinue = false;
                }


                while (userTryAgain == true & userContinue == false)

                {
                    Console.Write("Do you wish to continue? (y/n): ");
                    userInputContinue = Console.ReadLine().ToLower();

                    if (userInputContinue == "y")
                    {
                        userContinue = true;
                        userTryAgain = false;
                    }
                    else if (userInputContinue == "n")
                    {
                        Console.WriteLine("Thank you for spending time with this rickity old machine! Safe travels, " + userName + ".");
                        userContinue = false;
                        userTryAgain = false;

                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("I didn't understand that, please try again.");
                        userTryAgain = true;
                    }

                }
            }
        }
    }
}
        
    

    

