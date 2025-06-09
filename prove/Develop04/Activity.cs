using System.Runtime.CompilerServices;

class Activity
{
    private string _activityType;
    private string _description;
    List<string> _animationStrings = new List<string>() { "-", "\\", "|", "/", "-", "\\", "|", "/", "-" };

    public Activity(string activityType, string description)
    {
        _activityType = activityType;
        _description = description;
    }

    protected int RunIntroMethods()
    {
        DisplayIntroMessage();
        int timeForActivity = GetTime();
        Console.Write("Get Ready... ");
        DisplaySpinner();
        Console.Clear();
        return timeForActivity;
    }

    private void DisplayIntroMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityType} activity.\n\n{_description}\n");
    }

    private int GetTime()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        return int.Parse(Console.ReadLine());
    }

    protected void DisplaySpinner()
    {
        foreach (string s in _animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    protected void DisplayFinish(int time)
    {
        Console.Write("Well Done! ");
        DisplaySpinner();
        Console.WriteLine("");
        Console.Write($"You have completed another {time} seconds of {_activityType} activity. ");
        DisplaySpinner();
    }

    protected string GetRandomPrompt(List<string> prompts)
    {
        Random randomNumber = new Random();
        int promptNumber = randomNumber.Next(0, prompts.Count);
        return prompts[promptNumber];
    }
}