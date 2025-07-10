class ForageActivity : Activity
{
    private List<Item> foragableItems = new List<Item>();

    public ForageActivity(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {
        
    }

    public override void RunActivity(Inventory inventory, GameDay gameDay)
    {
        // inventory.AddItem(foragableItems[1]);
        gameDay.DecrementTimeInDay(base.GetActionCost());
    }
}