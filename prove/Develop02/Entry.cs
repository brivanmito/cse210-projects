// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 
public class Entry
{
    public string _entry;
    public DateTime _dateAndTime;
    public string _prompt;
    public void Display()
    {
        Console.WriteLine($"Date: {_dateAndTime} - Prompt: {_prompt}\n{_entry}");
    }
}