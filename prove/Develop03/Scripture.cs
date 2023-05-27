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
        // Example: Jeremiah 17:7 # Blessed is the man that trusteth in the Lord, and whose hope the Lord is.
        string[] vector = line.Split('#'); // vector = ["Jeremiah 17:7","Blessed is the man that trusteth in the Lord, and whose hope the Lord is"]
        // Save in the respective variable the Reference and Verses
        string reference = vector[0].Trim(); // vector[0] = "Jeremiah 17:7"
        // vector[1] = "Blessed is the man that trusteth in the Lord, and whose hope the Lord is"
        string[] verses = vector[1].Trim().Split('$'); // verses = ["Blessed", "is", "the", "man", .....]
        // Call to the function LoadBookChapterAndVerse to create a object of the class Reference sending the variable reference
        LoadBookChapterAndVerse(reference);
        LoadWordsList(verses);
    }
    private void LoadBookChapterAndVerse(string reference)
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
        // In this loop I hide the 3 words each time the users press "Enter"
        while(times <= 3 & IsCompletelyHidden() == false)
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
        foreach (Word word in _contentWordByWord)
        {
            renderedText += word.GetRenderedWord() + " ";
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