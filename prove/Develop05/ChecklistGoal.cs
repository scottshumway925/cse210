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

    public override void CreatingData(Double numberOfMaxCompletions = 0)
    {
        base.CreatingData(numberOfMaxCompletions);
        Console.WriteLine("Please enter the amount of bonus points awarded for completing the max number of completions: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void DisplayGoal()
    {
        Console.WriteLine("I'm Working Check");
    }

    public override int RecordGoal()
    {
        return 10;
    }
}