// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 
using System.IO;
using Microsoft.VisualBasic.FileIO;
public class Journal
{   // Atributes
    public List<Entry> _entries = new List<Entry>();
    public string _filename;

    // Methods
    public void AddingEntry(Entry a, PromptGenerator b)
    {
        a._dateAndTime = DateTime.Now;
        if (b._lines.Count() > 0)
        {
            a._entry = Console.ReadLine();

            if (a._entry.Length > 0)
            {
                if (a._entry.Contains(","))
                {
                    a._entry = $"\"{a._entry}\"";
                }
                _entries.Add(a);
                b.EliminateDuplicatedPrompts();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Info: Entry added!, ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Info: The entry is empty so it was not entered.");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press Enter....");

        }

    }
    public void DisplayingAllTheEntries()
    {
        if (_entries.Count() > 0)
        {
            Console.Clear();
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Info: No entries to display");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Press Enter....");
    }
    public void SavingToAFile()
    {
        // If there are no entries, nothing should be saved. Therefore, 
        //  if the _entries list is empty, it will display a message that it 
        //  cannot save to the file because the list is empty.
        if (_entries.Count() > 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is the filename?");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            _filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                Console.WriteLine($"\nSaving entries in the file.....\n");
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._dateAndTime},{entry._prompt},{entry._entry}");
                }
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Info: No entries to save");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Press Enter....");
    }
    public void LoadingFromAFile()
    {
        //the Journal display method could iterate through all Entry objects and call the Entry display method.
        Console.WriteLine("What is the filename?");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        _filename = Console.ReadLine();
        // Handling Errors: FileNotFoundException
        try
        {
            List<string[]> lines = new List<string[]>();
            using (TextFieldParser parser = new TextFieldParser(_filename))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",", "\t");

                while (!parser.EndOfData)
                {
                    string[] row = parser.ReadFields();
                    lines.Add(row);
                }
            }
            foreach (string[] row in lines)
            {
                Entry entry = new Entry();
                entry._dateAndTime = DateTime.Parse(row[0]);
                entry._prompt = row[1];
                entry._entry = row[2];
                entry.Display();
            }
        }
        catch (FileNotFoundException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Info: {_filename} file name does not exist, ");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\nPress Enter....");
    }
}