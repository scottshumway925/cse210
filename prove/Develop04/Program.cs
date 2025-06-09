using System;
class Program
{
    private static void MenuSystem()
    {
        int userChoice = 0;
        int overallTime = 0;
        while (userChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
            Console.Write("Select a Choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                BreathingActivity currentActivity = new BreathingActivity("breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                overallTime = currentActivity.RunActivity(overallTime);
            }
            else if (userChoice == 2)
            {
                ReflectionActivity currentActivity = new ReflectionActivity("reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                overallTime = currentActivity.RunActivity(overallTime);
            }
            else if (userChoice == 3)
            {
                ListingActivity currentActivity = new ListingActivity("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                overallTime = currentActivity.RunActivity(overallTime);
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Well done!\nYou spent a total of {overallTime} seconds doing mindfulness activities");
                Console.Write("The Program will end in: ");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }
        }

    }

    static void Main(string[] args)
    {
        MenuSystem();
    }
}