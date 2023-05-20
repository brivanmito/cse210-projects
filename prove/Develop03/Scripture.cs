// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 

//Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    public Scripture()
    {
        // We choose a random Scripture
        Random r = new Random();
        string[] _linesOfScriptures = System.IO.File.ReadAllLines("scriptures.txt");
        int randomNumber = r.Next(0, _linesOfScriptures.Count()-1);
        string line = _linesOfScriptures[randomNumber];
        string[] vector = line.Split('#');
        string reference = vector[0].ToString().Trim();
        string[] verses = vector[1].Split('$');

        LoadBookChapterAndVerse(reference);
        LoadWordsList(verses);
    }
    private void LoadBookChapterAndVerse(string reference)
    {
        string[] line = reference.Split(' '); //['Proverbs', '4:5-6']
        string book = line[0].Trim(); // book = Proverbs
        string[] line2 = line[1].Split(':'); // ['4', '5-6']
        int chapter = int.Parse(line2[0].Trim()); // chapter = 4
        if (line2[1].Contains("-")) 
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
                _words.Add(word);
            }
        }
    }
    public void HideWords()
    {
        Random r = new Random();
        int optionIndex = r.Next(_words.Count());
        int times = 1;
        while(times <= 3 & IsCompletelyHidden() == false)
        {
            if (_words[optionIndex].IsHidden())
            {
                while(_words[optionIndex].IsHidden() == true)
                {
                    optionIndex = r.Next(_words.Count());
                }
                _words[optionIndex].Hide();
            }
            else
            {
                _words[optionIndex].Hide();
            }
            times++;
        }
        
    }
    public string GetRenderedText()
    {
        Console.Write(_reference.GetReference());
        string renderedText = "";
        foreach (Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText.Trim();

    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}