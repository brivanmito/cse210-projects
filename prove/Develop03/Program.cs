// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 
using System;
// Classes Used
// 1.- Scripture
// 2.- Reference
// 3.- Word

// Showing Creativity and Exceeding Requirements
   // One of the challenges I found is that some people don't want to memorize a whole list of scriptures at once, 
//    some want to do it on a daily basis, but only focusing on one scripture at a time. So I created a program that 
//    takes a random scripture from a text file, this file contains more than 5 scriptures. This makes it so that the 
//    person who is memorizing can focus on that one scripture. Each time the user runs the program a new script will be 
//    shown.

class Program
{
    static void Main(string[] args)
    {
        // Load a random scripture from a File
        string randomScripture = ChooseARandomScripture();
        string reference = ObtainReference(randomScripture);
        string versesContent = ObtainVerses(randomScripture);

        Scripture scripture = new Scripture(reference, versesContent);
        Console.Clear();
        string option = "";
        // Display the initial scripture
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
            
        }while(option != "quit" & scripture.IsTheScriptureCompletelyHidden() != true);
        

        // Functions
        static string ChooseARandomScripture()
        {
            // We choose a random Scripture from a File
            Random r = new Random();
            string[] _linesOfScriptures = System.IO.File.ReadAllLines("scriptures.txt");
            int randomNumber = r.Next(0, _linesOfScriptures.Count()-1);
            // Choose a random scripture of the File
            string scripture = _linesOfScriptures[randomNumber];
            // retur a string like this: "Jeremiah 17:7 # Blessed is the man that trusteth in the Lord, and whose hope the Lord is"
            return scripture;
        }
        static string ObtainReference(string randomScripture)
        {
            string[] vector = randomScripture.Split('#'); // vector = ["Jeremiah 17:7","Blessed is the man that trusteth in the Lord, and whose hope the Lord is"]
            // Save in the variable reference the Reference.
            string reference = vector[0].Trim();
            // return a string like this: "Jeremiah 17:7"
            return reference;
        }
        static string ObtainVerses(string randomScripture)
        {
            string[] vector = randomScripture.Split('#');
            // Save in the variable verses the Verse / Verses
            string verses = vector[1].Trim();
            // return a tring like this: "Blessed is the man that trusteth in the Lord, and whose hope the Lord is"
            return verses;
        }
    }
}