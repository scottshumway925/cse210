using System;



class Program
{
    static void Main(string[] args)
    {
        RunMenu();
    }

    static void RunMenu()
    {
        int input;
        Goals goalList = new Goals();
        Console.Clear();
        do
        {
            Console.Clear();
            Console.WriteLine($"Your total amount of points is: {goalList.DisplayPoints()}");
            Console.Write("\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    BaseGoal goal = goalList.CreateGoal();
                    goalList.AddGoal(goal);
                    break;
                case 2:
                    goalList.DisplayGoalList();
                    Console.WriteLine("Enter to continue: ");
                    Console.ReadLine();
                    break;
                case 3:
                    goalList.SaveGoals();
                    break;
                case 4:
                    goalList.GetGoalData();
                    break;
                case 5:
                    goalList.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Thank you for using the Goal Checklist!");
                    break;
            }
        } while (input != 6);
    }
}