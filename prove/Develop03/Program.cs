// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 
using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Console.Clear();
        string option = "";
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("\nPress Enter to continue or type 'quit' to finish\n");
        
        do
        {
            option = Console.ReadLine();
            if(option != "quit")
            {
                Console.Clear();
                scripture.HideWords();
                Console.WriteLine(scripture.GetScripture());
                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish\n");
            }
        }while(option != "quit" & scripture.IsCompletelyHidden() != true);
        
    }
}