class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>() {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity(string activityType, string description) : base(activityType, description)
    {

    }

    public int RunActivity(int overallTime)
    {
        int timeForActivity = RunIntroMethods();
        RunListingSession(timeForActivity);
        DisplayFinish(timeForActivity);
        return overallTime + timeForActivity;
    }

    private void RunListingSession(int time)
    {
        // Intro text
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt(_prompts)} ---");
        Console.Write($"You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");

        // Getting the listings
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        DateTime currentTime;
        int iterations = 0;
        do
        {
            Console.Write(">");
            Console.ReadLine();
            iterations++;
            currentTime = DateTime.Now;
        } while (endTime > currentTime);
        Console.WriteLine($"You listed {iterations} items\n");
    }
}