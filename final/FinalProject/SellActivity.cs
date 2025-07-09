using System.Runtime.CompilerServices;

class SellActitivy : Activity
{
    public override void RunActivity(Inventory inventory)
    {
        Item item = new ConsumableItem();
        inventory.RemoveItem(item);
    }
}