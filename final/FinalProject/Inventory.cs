class Inventory
{
    private List<Item> inventoryItems;
  
    public List<Item> GetInventory()
    {
        return inventoryItems;
    }

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
    }

    public void RemoveItem(Item item)
    {
        foreach (Item inventoryItem in inventoryItems)
        {
            if (inventoryItem.GetName() == item.GetName())
            {
                inventoryItems.Remove(inventoryItem);
                return;
            }
        }
    }
}