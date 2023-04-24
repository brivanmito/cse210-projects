using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        // Part 1 and 2, in the line 9 the user specified the number.
        // int magicNumber = int.Parse(Console.ReadLine());
        int guess;

        string continueGame = "yes";
        
        while(continueGame == "yes")
        {
            // Part 3. We generate a random number each time the 
            // user press yes.
            int magicNumber = randomGenerator.Next(1, 101);
            do
            {
                // Asking a guess
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());
                // Check if the user guess the Magic Number
                if(guess > magicNumber)
                {
                    Console.WriteLine("Higher.");
                }
                else if(guess < magicNumber)
                {
                    Console.WriteLine("Lower.");
                }
                else
                {
                    Console.WriteLine("You guessed it!.");
                    Console.WriteLine("Game over.");
                }
            } while(guess != magicNumber);
            Console.Write("Do you want to play again?:\n Type 'yes' or 'no': ");
            continueGame = Console.ReadLine().ToLower();
        }

    }
}