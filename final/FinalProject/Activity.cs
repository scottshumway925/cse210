abstract class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _actionCost;

    public void DisplayInformation()
    {

    }

    public abstract void RunActivity(Inventory inventory);
}