// Author: Bryan Miño Toala
// Brigham Young University Idaho
// CSE 210 - Programming with Classes 

// Keeps track of a single word and whether it is shown or hidden.
public class Word
{
    private string _word;
    private bool _isHidden;
    public Word(string word)
    {
        _word = word;
        Show();
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetRenderedText()
    {
        if(_isHidden)
        {
            string _undercores = "";
            foreach(char word in _word)
            {
                _undercores += '_';
            }
            return _undercores;
        }
        else
        {
            return _word;
        }
    }
}