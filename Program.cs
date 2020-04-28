using System;

// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            /* string name = "Bruno Lopes";
             int age = 25;
             Console.WriteLine(name+" é "+age);
             Console.WriteLine("{0} é {1}", name, age);*/

            
            GetAppInfo(); //Run function 

            GreetUser(); //Run function 

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Advinha um número entre 1 e 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    // Make suer its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Tem que ser um numero pah!");
                        
                        //Keep Going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guee to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red , "Incorrecto!, Tenta novamente");
                    }

                }

                //Output success message

                PrintColorMessage(ConsoleColor.Yellow, "CORRETISSIMO PA!");

                //Ask to play again
                Console.WriteLine("Play again [Y or N]");

                //Get answer
                String answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Bruno Lopes";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //Ask a users name
        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("Qual é o teu nome?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.", inputName);
        }

        //Print coor message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
