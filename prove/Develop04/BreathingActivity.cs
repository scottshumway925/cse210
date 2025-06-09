class BreathingActivity : Activity
{
    public BreathingActivity(string activityType, string description) : base(activityType, description)
    {
        
    }

    public int RunActivity(int overallTime)
    {
        int timeForActivity = RunIntroMethods();
        RunBreathingSession(timeForActivity);
        DisplayFinish(timeForActivity);
        return timeForActivity + overallTime;
    }

    private void RunBreathingSession(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        DateTime currentTime;

        do
        {
            Console.Write("Breathe In... ");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");

            Console.Write("Breathe Out... ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("\n");

            currentTime = DateTime.Now;
        } while (endTime > currentTime);
    }
}