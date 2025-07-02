class BaseGoal
{
    private string _goalType;
    private int _pointValue;
    private string _goalName;
    private string _goalDescription;
    private bool _isComplete;
    private Double _numberOfMaxCompletions;
    private int _currentCompletions;

    public BaseGoal(string goalType, int pointValue, string goalName, string goalDescription, bool isComplete, int currentCompletions, double numberOfMaxCompletions = 0)
    {
        _goalType = goalType;
        _pointValue = pointValue;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _isComplete = isComplete;
        _currentCompletions = currentCompletions;
    }

    public BaseGoal()
    {
        
    }

    public Double GetMaxCompletions()
    {
        return _numberOfMaxCompletions;
    }

    public void SetPointValue(int value)
    {
        _pointValue = value;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }

    public virtual void CreatingData(double numberOfMaxCompletions = 0)
    {
        _goalType = this.ToString();

        Console.WriteLine("Please enter the name of the goal you would like to create: ");
        _goalName = Console.ReadLine();

        Console.WriteLine("Please enter the point value associated with this goal: ");
        _pointValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a description for this goal: ");
        _goalDescription = Console.ReadLine();

        _currentCompletions = 0;
        _isComplete = false;

        if (_goalType == "ChecklistGoal")
        {
            Console.WriteLine("Please enter the maximum number of completions for this goal: ");
            numberOfMaxCompletions = int.Parse(Console.ReadLine());
        }
        _numberOfMaxCompletions = numberOfMaxCompletions;

        Console.WriteLine($"{_goalType}, {_goalName}, {_numberOfMaxCompletions}");
    }

    public virtual string GetSaveInfo()
    {
        return $"{_goalType}:{_pointValue}:{_goalName}:{_goalDescription}:{_isComplete}:{_currentCompletions}:{_numberOfMaxCompletions}";
    }

    public void DisplayGoal()
    {
        Console.WriteLine($"{_goalName} -- {_goalDescription} -- Current Completions {_currentCompletions}/{_numberOfMaxCompletions}");
    }

    public virtual int RecordGoal()
    {
        if (!_isComplete)
        {
            _currentCompletions += 1;
            if (_currentCompletions >= _numberOfMaxCompletions)
            {
                _isComplete = true;
                return _pointValue;
            }
            else
            {
                return _pointValue;
            }
        }
        else
        {
            Console.WriteLine("This goal is already complete!");
            return 0;
        }
    }
}