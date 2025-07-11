class CraftActivity : Activity
{
    public CraftActivity(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {
        
    }


    public override void RunActivity(Inventory inventory, GameDay gameDay)
    {
        base.DisplayInformation();
        Console.WriteLine("Would you like to proceed with foraging?");
        Console.WriteLine("Press ENTER to continue or type 0 to exit");
        string performActivity = (Console.ReadLine());
        switch (performActivity)
        {
            case "":
                gameDay.DecrementTimeInDay(base.GetActionCost());
                break;
            default:
                break;
        }
    }
}