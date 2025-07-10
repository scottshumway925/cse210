class CraftActivity : Activity
{
    public CraftActivity(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {
        
    }


    public override void RunActivity(Inventory inventory, GameDay gameDay)
    {
        // Item item = new ConsumableItem();
        // inventory.AddItem(item);
        gameDay.DecrementTimeInDay(base.GetActionCost());
    }
}