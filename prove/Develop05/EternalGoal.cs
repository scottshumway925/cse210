class EternalGoal : BaseGoal
{
    public EternalGoal(string goalType, int pointValue, string goalName, string goalDescription, bool isComplete, int currentCompletions,  double numberOfMaxCompletions = Double.PositiveInfinity)
     : base(goalType, pointValue, goalName, goalDescription, isComplete, currentCompletions, numberOfMaxCompletions)
    {

    }

    public EternalGoal()
    {
        
    }

    // public override EternalGoal CreateGoal()
    // {
    //     throw new NotImplementedException();
    // }

    // public override void DisplayGoal()
    // {
    //     Console.WriteLine("I'm Working Eternal");
    // }
}