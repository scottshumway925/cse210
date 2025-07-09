class CraftActivity : Activity
{
    public override void RunActivity(Inventory inventory)
    {
        Item item = new ConsumableItem();
        inventory.AddItem(item);
    }
}