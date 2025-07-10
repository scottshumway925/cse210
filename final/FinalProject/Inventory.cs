class Inventory
{
    private List<Item> _inventoryItems = new List<Item>();
    private int _currentMoney;

    public int GetCurrentMoney()
    {
        return _currentMoney;
    }

    public List<Item> GetInventory()
    {
        return _inventoryItems;
    }

    public void AddItem(Item item)
    {
        _inventoryItems.Add(item);
    }

    public void RemoveItem(Item item)
    {
        foreach (Item inventoryItem in _inventoryItems)
        {
            if (inventoryItem.GetName() == item.GetName())
            {
                _inventoryItems.Remove(inventoryItem);
                return;
            }
        }
    }
}