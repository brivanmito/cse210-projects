// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 

// Keeps track of the book, chapter, and verse information.
public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verseNumber = new List<int>();

    public Reference(int number, string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber.Add(number);
    }
    public Reference(int start, int end, string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber.Add(start);
        _verseNumber.Add(end);
    }
    public string GetReference()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        if(_verseNumber.Count() > 1)
        {
            return $"{_book} {_chapter}:{_verseNumber[0]}-{_verseNumber[1]}. ";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseNumber[0]}. ";
        }
    }
}