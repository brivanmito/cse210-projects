// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 

// Showing Creativity and Exceeding Requirements
// 1. Think of other problems that keep people from writing in their journal and address one of those.
     // * One of the issues why people don't keep a diary is because they feel they have nothing to say, which may tempt them not to write in their diary.
     // * The application has many validations where it verifies that the input is a non-empty string of text, so the user will be more motivated to write because they cannot save anything until they answer the prompt.

// 2. Save other information in the journal entry.
     // * I found it necessary to save the time when the user writes in their diary, so they can know based on saved entries which time is better for them to write

// 3. Improve the process of saving and loading to save as a .csv file that could be opened in Excel (make sure to account for quotation marks and commas correctly in your content.
     // * "I used the TextFieldParser class, which is part of the Microsoft.VisualBasic.FileIO library in C#. 
    //      This class helped me with reading CSV files that contain double quotes (""). In my program, when a user 
    //      enters an input that contains commas (,), the program saves it in the .csv file as follows: 
    //      "Hello, My name is Bryan". Therefore, when I tried to read it conventionally with the separator (,), 
    //      it would split the input into several fields. The TextFieldParser class allowed me to read files, 
    //      regardless of whether they have commas in the input. This allows them to be opened correctly in Excel."

// Colors: I used colors in the menu, and I also set the color Magenta for all user inputs
// The prompts are not repeated during the program's execution.

// Handling Errors: 
//          Menu Otions: The program has a numerical options menu. If a user enters a letter or string, it alerts.
//             them that there was an error and prompts them to enter a new option, but it must be a number within the menu
//          Try / Catch: Capture the exception that occurs when a requested file, whose name was provided by the user, does not exist
using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        //Create an object for the Journal App
        Journal journal = new Journal();
        //Create an object for the Prompts 
        PromptGenerator prompts = new PromptGenerator();
        //Call the method LoadingPrompts to read the prompts saved in the file.
        prompts.LoadingPrompts();
        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("     MY JOURNAL APP\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("          Menu\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.- Adding an entry.");
            Console.WriteLine("2.- Display all the entries.");
            Console.WriteLine("3.- Loading from a file.");
            Console.WriteLine("4.- Saving a file.");
            Console.WriteLine("5.- Exit.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nWhat would you like to do? ");
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                case 1:
                    // Each time the user wants to enter an input, an object of the Entry class will be created.
                    Entry entry = new Entry();
                    // This object will use the ChoosingRandomPrompts method to randomly select a prompt.
                    prompts.ChoosingRandomPrompts();
                    // The prompts object contains the prompt that will be displayed, therefore it should 
                    //   be stored in the _prompt attribute of the entry object.
                    entry._prompt = prompts._randomPrompt;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    journal.AddingEntry(entry, prompts);
                    Console.ReadKey();
                    break;
                case 2:
                    journal.DisplayingAllTheEntries();
                    Console.ReadKey();
                    break;
                case 3:
                    journal.LoadingFromAFile();
                    Console.ReadKey();
                    break;
                case 4:
                    journal.SavingToAFile();
                    Console.ReadKey();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Error!, Please enter an option in the Menu.");
                    Console.ReadKey();
                    break;
                }
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error! No letters are allowed to be entered in the Menu options.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press 'Enter'.");
                Console.ReadKey();
                Console.Clear();
            }

        }

    }
}