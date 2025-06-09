class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>() {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public ReflectionActivity(string activityType, string description) : base(activityType, description)
    {

    }

    public int RunActivity(int overallTime)
    {
        int timeForActivity = RunIntroMethods();
        RunReflectionSession(timeForActivity);
        DisplayFinish(timeForActivity);
        return overallTime + timeForActivity;
    }

    private void RunReflectionSession(int time)
    {
        // Setting up the reflection session
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt(_prompts)} ---");
        Console.WriteLine("When you think of something, press enter.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder each of the following questions as they relate to this experience.");

        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();

        // Giving the questions
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        DateTime currentTime;

        do
        {
            Console.Write($"{GetRandomPrompt(_questions)} ");
            DisplaySpinner();
            DisplaySpinner();
            Console.WriteLine("");
            currentTime = DateTime.Now;
        } while (endTime > currentTime);
        Console.WriteLine("");
    }
}