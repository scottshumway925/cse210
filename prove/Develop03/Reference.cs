public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _secondVerse;

    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = 0;
    }

    public Reference(string book, int chapter, int firstVerse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = secondVerse;
    }

    public void DisplayReference()
    {
        if (_secondVerse == 0)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_secondVerse}");
        }
    }
}