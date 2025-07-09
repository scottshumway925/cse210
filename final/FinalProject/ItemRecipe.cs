class ItemRecipe
{
    private bool _requirementsMet;

    public bool CheckForRequirements()
    {
        return _requirementsMet;
    }

    public Item CreateConsumableItem(string itemName)
    {
        return new ConsumableItem("Name", "Description", 1, 1);
    }

    public Item CreateNonConsumableItem(string itemName)
    {
        return new NonConsumableItem("Name", "Description", 1, 1);
    }
}