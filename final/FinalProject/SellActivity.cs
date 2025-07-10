using System.Runtime.CompilerServices;

class SellActitivy : Activity
{
    public SellActitivy(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {
        
    }


    public override void RunActivity(Inventory inventory, GameDay gameDay)
    {
        // Item item = new ConsumableItem();
        // inventory.RemoveItem(item);
        gameDay.DecrementTimeInDay(base.GetActionCost());
    }
}