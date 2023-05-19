// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 
public class PromptGenerator
{
    public string _filename = "myFile.txt";
    public string[] _lines;
    public int _randPosition;
    public string _randomPrompt;
    //This method reads all the lines of the file where the prompts are stored.
    public void LoadingPrompts()
    {
        _lines = System.IO.File.ReadAllLines(_filename);
    }
    public void ChoosingRandomPrompts()
    {
        if (_lines.Count() > 0)
        {
            Random rand = new Random();
            _randPosition = rand.Next(0, _lines.Count());

            _randomPrompt = _lines[_randPosition];
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_randomPrompt);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("All the prompts were displayed");
        }
    }
    //This method adjusts the size of the vector, 
    // making it smaller on each call, eliminating 
    // prompts that have already been entered into 
    // the file, so they will not be displayed repeatedly.
    public void EliminateDuplicatedPrompts()
    {
        string last_prompt = _lines[_lines.Count() - 1];
        _lines[_randPosition] = last_prompt;

        Array.Resize(ref _lines, _lines.Count() - 1);
        Console.ForegroundColor = ConsoleColor.DarkGray;
    }

}