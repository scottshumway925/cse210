class ForageActivity : Activity
{
    private List<Item> foragableItems;
    public override void RunActivity(Inventory inventory)
    {
        inventory.AddItem(foragableItems[1]);
    }
}