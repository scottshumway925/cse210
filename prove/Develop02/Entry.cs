public class Entry
{
    string _textEntry;
    string _date;
    string _prompt;


    public string CreateEntryText()
    {
        GetPrompt();
        GetDate();
        Console.WriteLine($"{_prompt}");
        string tempEntry = Console.ReadLine();
        _textEntry = $"{_date}#{_prompt}#{tempEntry}";

        return _textEntry;
    }

    public string CreateEntryWithData(string date, string prompt, string text)
    {
        _date = date;
        _prompt = prompt;
        string tempEntry = text;
        _textEntry = $"{_date}#{_prompt}#{tempEntry}";

        return _textEntry;
    }

    private void GetDate()
    {
        _date = DateTime.Now.ToString();
    }

    private void GetPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 5);
        string setPrompt;

        switch (randomNumber)
        {
            case 0:
                setPrompt = "How have you seen the hand of the Lord in your life today?";
                break;
            case 1:
                setPrompt = "What is one thing you learned in your scripture study today?";
                break;
            case 2:
                setPrompt = "What is one way you felt the spirit today?";
                break;
            case 3:
                setPrompt = "How did the Lord bless other people through your efforts today?";
                break;
            case 4:
                setPrompt = "What is one fun thing that you did today?";
                break;
            case 5:
                setPrompt = "What did you do today to improve yourself?";
                break;
            default:
                setPrompt = "Broken";
                break;
        }
        _prompt = setPrompt;
    }
}