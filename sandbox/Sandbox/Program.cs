using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);
        int sleepTime = 250;
        string animationString = "(^o^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }
    }
}