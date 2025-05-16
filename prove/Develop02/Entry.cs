public class Entry
{
    string _textEntry;
    string _date;
    string _prompt;


    public string CreateEntryText()
    {
        GetPrompt();
        GetDate();
        Console.WriteLine($"{_prompt}: ");
        string tempEntry = Console.ReadLine();
        _textEntry = $"\n{_date}#{_prompt}#\n{tempEntry}";

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
                setPrompt = "Prompt 1";
                break;
            case 1:
                setPrompt = "Prompt 2";
                break;
            case 2:
                setPrompt = "Prompt 3";
                break;
            case 3:
                setPrompt = "Prompt 4";
                break;
            case 4:
                setPrompt = "Prompt 5";
                break;
            case 5:
                setPrompt = "Prompt 6";
                break;
            default:
                setPrompt = "Broken";
                break;
        }
        _prompt = setPrompt;
    }
}