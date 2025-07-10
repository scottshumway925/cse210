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

    }

    public abstract void RunActivity(Inventory inventory, GameDay gameDay);
}