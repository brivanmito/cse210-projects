// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 

//Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _contentWordByWord = new List<Word>();
    
    public Scripture(string reference, string verses)
    {
        string[] versesSplited = verses.Split(' ');

        ObtainBookChapterAndVerse(reference);
        LoadWordsList(versesSplited); // verses = ["Blessed", "is", "the", "man", .....]
    }

    // Special method to obtain the name of a book, chapter, and verses/verses
    private void ObtainBookChapterAndVerse(string reference)
    {
        // reference = "Jeremiah 17:7"
        string[] line = reference.Split(' '); // line = ["Jeremiah", "17:7"]
        string book = line[0].Trim(); // book = "Jeremiah"
        string[] line2 = line[1].Split(':'); // ['17', '7']
        int chapter = int.Parse(line2[0].Trim()); // chapter = 17
        if (line2[1].Contains("-")) // line2[1] = 17 -> No contain the caracther "-"
        {
            line = line2[1].Split('-');
            int start = int.Parse(line[0]);
            int end = int.Parse(line[1]);
            _reference = new Reference(start, end, book, chapter);
        }
        else
        {
            
            int start = int.Parse(line2[1]);
            _reference = new Reference(start, book, chapter);
        }
    }
    private void LoadWordsList(string[] verses)
    {
        foreach(string verse in verses)
        {
            string[] words = verse.Split(' ');
            foreach(string singleWord in words)
            {
                Word word = new Word(singleWord.Trim());
                _contentWordByWord.Add(word);
            }
        }
    }
    public void HideWords()
    {
        Random r = new Random();

        int randomWordIndex = r.Next(_contentWordByWord.Count());
        int times = 1;
        // In this loop I hide 3 words each time the users press "Enter"
        while(times <= 3 & IsTheScriptureCompletelyHidden() == false)
        {
            if (_contentWordByWord[randomWordIndex].IsHidden())
            {
                while(_contentWordByWord[randomWordIndex].IsHidden() == true)
                {
                    randomWordIndex = r.Next(_contentWordByWord.Count());
                }
                _contentWordByWord[randomWordIndex].Hide();
            }
            else
            {
                _contentWordByWord[randomWordIndex].Hide();
            }
            times++;
        }
        
    }
    public string GetScripture()
    {
        Console.Write(_reference.GetReference());
        string renderedText = "";
        Console.ForegroundColor = ConsoleColor.White;
        foreach (Word word in _contentWordByWord)
        {
            renderedText += word.GetRenderedWord() + " ";
        }
        return renderedText.Trim();

    }
    public bool IsTheScriptureCompletelyHidden()
    {
        foreach (Word word in _contentWordByWord)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}