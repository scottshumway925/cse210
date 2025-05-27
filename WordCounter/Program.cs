class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        WordCounter wordCounter = new WordCounter("This is a text string that will test my counter class to see if it is working well.");
        wordCounter.DisplayWords();
        Console.WriteLine(wordCounter.CountWords());
    }
}