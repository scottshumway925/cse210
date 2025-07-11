class SimpleGoal : BaseGoal
{
    public SimpleGoal(string goalType, int pointValue, string goalName, string goalDescription, bool isComplete, int currentCompletions, double numberOfMaxCompletions = 1)
     : base(goalType, pointValue, goalName, goalDescription, isComplete, currentCompletions, numberOfMaxCompletions)
    {

    }

    public SimpleGoal()
    {

    }

    public override int addBonusPoints()
    {
        if (base.GetIsComplete())
        {
            return base.GetPointValue();
        }
        else
        {
            return 0;
        }
    }
}