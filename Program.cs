using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    //main class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            //Set app vars
            string appname = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vegar Fredriksen";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appname, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            //ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);

            while (true)
            {

                //init  correct number
                //int correctNumber = 7;

                //create new random object
                Random random = new Random();

                //init  correct number
                int correctNumber = random.Next(1, 10);


                //init guess var 
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //validate input as number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;


                        //Tell user its not a number
                        Console.WriteLine("WHOPS! input is not a number, enter a number retard");

                        //Reset text color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;


                        //Tell user its the wrong number
                        Console.WriteLine("Wrong number, please try again");

                        //Reset text color
                        Console.ResetColor();
                    }
                }

                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;


                //tell user its the right number
                Console.WriteLine("You are correct! GJDM MIRIN' HARD!");

                //Reset text color
                Console.ResetColor();

                // ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
