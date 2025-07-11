using System.Runtime.CompilerServices;

class SellActitivy : Activity
{
    public SellActitivy(string activityName, string activityDescription, int actionCost) : base(activityName, activityDescription, actionCost)
    {
        
    }


    public override void RunActivity(Inventory inventory, GameDay gameDay)
    {
        base.DisplayInformation();
        Console.WriteLine("Here is your inventory: ");
        inventory.DisplayContentsWithCost();
        Console.WriteLine("Press ENTER to sell an item or type 0 to exit");
        string performActivity = (Console.ReadLine());
        switch (performActivity)
        {
            case "":
                Console.Write("Please enter a number representing the item you would like to sell: ");
                int sellIndex = int.Parse(Console.ReadLine()) - 1;
                inventory.IncreaseMoneyAmount(inventory.GetInventory()[sellIndex].GetSellPrice());
                Console.WriteLine($"Your {inventory.GetInventory()[sellIndex].GetName()} has been sold for {inventory.GetInventory()[sellIndex].GetSellPrice()}");
                inventory.RemoveItem(sellIndex);
                gameDay.DecrementTimeInDay(base.GetActionCost());
                break;
            default:
                break;
        }
    }
}