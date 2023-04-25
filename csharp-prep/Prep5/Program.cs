using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling functions
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int numberSquare = SquareNumber(favoriteNumber);
        DisplayResult(name, numberSquare);




        // Functions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int numberSquared = favoriteNumber * favoriteNumber;
            return numberSquared;
        }
        
        static void DisplayResult(string name, int numberSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSquared}");
        }
    }
}