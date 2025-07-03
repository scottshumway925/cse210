using System.Diagnostics;
using System.IO;

class Goals
{
    private List<BaseGoal> _goalList = new List<BaseGoal>();
    private int _totalPoints = 0;

    public Goals()
    {

    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the file you would like to save to? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (BaseGoal goal in _goalList)
            {
                string saveData = goal.GetSaveInfo();
                outputFile.WriteLine(saveData);
            }            
        }
    }

    public BaseGoal CreateGoal()
    {
        Console.Clear();
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
        Console.WriteLine("Goal Successfully Created -- Press enter to continue");
        Console.ReadLine();
        return constructedGoal;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goalList.Add(goal);
    }

    public void GetGoalData()
    {
        Console.Write("Please enter the file to extract data from: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] saveData = line.Split(":");
            BaseGoal newGoal;
            switch (saveData[0])
            {
                case "SimpleGoal":
                    newGoal = new SimpleGoal(saveData[0], int.Parse(saveData[1]), saveData[2], saveData[3], bool.Parse(saveData[4]), int.Parse(saveData[5]));
                    break;
                case "EternalGoal":
                    newGoal = new EternalGoal(saveData[0], int.Parse(saveData[1]), saveData[2], saveData[3], bool.Parse(saveData[4]), int.Parse(saveData[5]));
                    break;
                case "ChecklistGoal":
                    newGoal = new ChecklistGoal(saveData[0], int.Parse(saveData[1]), saveData[2], saveData[3], bool.Parse(saveData[4]), int.Parse(saveData[5]), int.Parse(saveData[7]), Double.Parse(saveData[6]));
                    break;
                default:
                    Console.WriteLine("Data is no good");
                    newGoal = null;
                    break;
            }

            _goalList.Add(newGoal);
            _totalPoints += newGoal.addBonusPoints();
        }
    }

    public void DisplayGoalList()
    {
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.Write((i + 1) + ". ");
            _goalList[i].DisplayGoal();
        }
    }

    public int DisplayPoints()
    {
        return _totalPoints;
    }

    public void RecordEvent()
    {
        this.DisplayGoalList();
        Console.WriteLine("Which Goal would you like to record: ");
        BaseGoal choice = _goalList[int.Parse(Console.ReadLine()) - 1];
        int pointIncrease = choice.RecordGoal();
        _totalPoints += pointIncrease;
    }
}