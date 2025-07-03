using System.Runtime.Versioning;

class ChecklistGoal : BaseGoal
{
    private int _bonusPoints;
    private bool _bonusAdded = false;

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
            if (_bonusAdded)
            {
                return 0;
            }
            else
            {
                _bonusAdded = true;
                return base.GetPointValue() + _bonusPoints;
            }
        }
        else
        {
            return base.GetPointValue();
        }
    }

    public override int addBonusPoints()
    {
        int totalPoints = base.GetPointValue() * base.GetNumberOfCompletions();
        if (this.GetIsComplete())
        {
            totalPoints += _bonusPoints;
        }
        return totalPoints;
    }
}