using System.Diagnostics;

class Goals
{
    private List<BaseGoal> _goalList = new List<BaseGoal>();
    private int _totalPoints = 0;

    public Goals()
    {

    }

    public void SaveGoals()
    {

    }

    public BaseGoal CreateGoal()
    {
        Console.WriteLine("The Types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        int chosenType = int.Parse(Console.ReadLine());
        BaseGoal constructedGoal;

        switch (chosenType)
        {
            case 1:
                constructedGoal = new SimpleGoal();
                constructedGoal.CreatingData(1);
                break;
            case 2:
                constructedGoal = new EternalGoal();
                constructedGoal.CreatingData(Double.PositiveInfinity);
                break;
            case 3:
                constructedGoal = new ChecklistGoal();
                constructedGoal.CreatingData();
                break;
            default:
                constructedGoal = null;
                break;
        }
        return constructedGoal;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goalList.Add(goal);
    }

    public void GetGoalData()
    {

    }

    public void DisplayGoalList()
    {
        foreach (BaseGoal goal in _goalList)
        {
            goal.DisplayGoal();
        }
    }

    public int DsiplayPoints()
    {
        return _totalPoints;
    }
}