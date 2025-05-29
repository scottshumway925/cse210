public class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string wordText)
    {
        _word = wordText;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    private void DisplayHiddenWord()
    {
        foreach (char letter in _word)
        {
            Console.Write("_");
        }
        Console.Write(" ");
    }

    public void DisplayWord()
    {
        if (!_isHidden)
        {
            Console.Write($"{_word} ");
        }
        else
        {
            DisplayHiddenWord();
        }
    }
}