class SimpleGoal : BaseGoal
{
    public SimpleGoal(string goalType, int pointValue, string goalName, string goalDescription, bool isComplete, int currentCompletions, double numberOfMaxCompletions = 1)
     : base(goalType, pointValue, goalName, goalDescription, isComplete, currentCompletions, numberOfMaxCompletions)
    {

    }

    // public override void CreateGoal()
    // {

    // }

    public SimpleGoal()
    {

    }

    public override void DisplayGoal()
    {
        Console.WriteLine("I'm working Base");
    }
}