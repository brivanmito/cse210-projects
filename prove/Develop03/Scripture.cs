// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 

//Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _contentWordByWord = new List<Word>();
    
    public Scripture()
    {
        // We choose a random Scripture from a File
        Random r = new Random();
        string[] _linesOfScriptures = System.IO.File.ReadAllLines("scriptures.txt");
        int randomNumber = r.Next(0, _linesOfScriptures.Count()-1);
        // Choose a random scripture of the File
        string line = _linesOfScriptures[randomNumber];
        // Split the variable line in reference and verses with the Caracter #
        string[] vector = line.Split('#');
        // S
        string reference = vector[0].Trim();
        string[] verses = vector[1].Trim().Split('$');

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
                _contentWordByWord.Add(word);
            }
        }
    }
    public void HideWords()
    {
        Random r = new Random();
        int optionIndex = r.Next(_contentWordByWord.Count());
        int times = 1;
        while(times <= 3 & IsCompletelyHidden() == false)
        {
            if (_contentWordByWord[optionIndex].IsHidden())
            {
                while(_contentWordByWord[optionIndex].IsHidden() == true)
                {
                    optionIndex = r.Next(_contentWordByWord.Count());
                }
                _contentWordByWord[optionIndex].Hide();
            }
            else
            {
                _contentWordByWord[optionIndex].Hide();
            }
            times++;
        }
        
    }
    public string GetRenderedText()
    {
        Console.Write(_reference.GetReference());
        string renderedText = "";
        foreach (Word word in _contentWordByWord)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText.Trim();

    }
    public bool IsCompletelyHidden()
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