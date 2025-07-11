using System.ComponentModel.DataAnnotations;

abstract class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _actionCost;

    public Activity(string activityName, string activityDescription, int actionCost)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _actionCost = actionCost;
    }

    public int GetActionCost()
    {
        return _actionCost;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"\n{_activityName} --- {_activityDescription} : Cost - {_actionCost}");
    }

    protected void DisplayLoadingCharacters()
    {
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            Console.Write(". ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    public abstract void RunActivity(Inventory inventory, GameDay gameDay);
}