using System.Globalization;
using System.Net;
using System.Security.Cryptography;

public class Scripture
{
    private List<Word> _text = new List<Word>();
    private Reference _reference;
    private List<int> _indexes = new List<int>();
    private Random _randomGenerator = new Random();

    public Scripture(string book, int chapter, int firstVerse, string text)
    {
        _reference = new Reference(book, chapter, firstVerse);
        SplitWords(text);
        for (int i = 0; i < _text.Count; i++)
        {
            _indexes.Add(i);
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        _reference.DisplayReference();
        foreach (Word word in _text)
        {
            word.DisplayWord();
        }
        Console.WriteLine("");
    }

    private void SplitWords(string text)
    {
        string[] textParts = text.Split(' ');
        foreach (string word in textParts)
        {
            Word newWord = new Word(word);
            _text.Add(newWord);
        }
    }

    public bool HideWords()
    {
        if (_indexes.Count >= 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int rNumber = _randomGenerator.Next(0, _indexes.Count);
                _text[_indexes[rNumber]].HideWord();
                _indexes.RemoveAt(rNumber);
            }
        }
        else if (_indexes.Count > 0)
        {
            for (int i = 0; i < _indexes.Count() + 1; i++)
            {
                int rNumber = _randomGenerator.Next(0, _indexes.Count);
                _text[_indexes[rNumber]].HideWord();
                _indexes.RemoveAt(rNumber);
            }
        }
        else
        {
            return true;
        }
        
        return false;
    }
}