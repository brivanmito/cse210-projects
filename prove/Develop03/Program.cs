// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 
using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        // Mostrar el texto original
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());

        string option = "";

        while(scripture.IsCompletelyHidden() != true)
        {
            // Esperar que el usuario presione Enter para ocultar una palabra
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish");
            option = Console.ReadLine().ToLower();
            if(option != "quit")
            {
                Console.Clear();
                // Ocultar una palabra del Scripture
                scripture.HideWords();
                // Mostrar el texto actualizado
                Console.WriteLine(scripture.GetRenderedText());
            }
            else
            {
                break;
            }
        }
        
    }
}