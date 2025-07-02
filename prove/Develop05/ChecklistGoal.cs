using System.Runtime.Versioning;

class ChecklistGoal : BaseGoal
{
    private int _bonusPoints;

    public ChecklistGoal(string goalType, int pointValue, string goalName, string goalDescription, bool isComplete, int currentCompletions, int bonusPoints, double numberOfMaxCompletions)
     : base(goalType, pointValue, goalName, goalDescription, isComplete, currentCompletions, numberOfMaxCompletions)
    {
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal()
    {

    }

    public override string GetSaveInfo()
    {
        return base.GetSaveInfo() + $":{_bonusPoints}";
    }

    public override void CreatingData(Double numberOfMaxCompletions = 0)
    {
        base.CreatingData(numberOfMaxCompletions);
        Console.WriteLine("Please enter the amount of bonus points awarded for completing the max number of completions: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordGoal()
    {
        base.RecordGoal();
        if (base.GetIsComplete())
        {
            int tempPoints = _bonusPoints + base.GetPointValue();
            _bonusPoints = 0;
            base.SetPointValue(0);
            return tempPoints;
        }
        else
        {
            return base.GetPointValue();
        }
    }
}