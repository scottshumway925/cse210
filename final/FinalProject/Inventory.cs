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

    public void IncreaseMoneyAmount(int amount)
    {
        _currentMoney += amount;
    }

    public void AddItem(Item item)
    {
        _inventoryItems.Add(item);
    }

    public void RemoveItem(int index)
    {
        _inventoryItems.Remove(_inventoryItems[index]);
    }

    public void DisplayContents()
    {
        Console.WriteLine("\nHere is your current inventory:");
        for (int i = 0; i < _inventoryItems.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. " + _inventoryItems[i].GetName());
        }
    }

    public void DisplayContentsWithCost()
    {
        Console.WriteLine("\nHere is your current inventory:");
        for (int i = 0; i < _inventoryItems.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. " + _inventoryItems[i].GetName() + " Sell Price -- " + _inventoryItems[i].GetSellPrice());
        }
    }
}