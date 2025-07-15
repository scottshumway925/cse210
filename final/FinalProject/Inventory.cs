class Inventory
{
    private List<Item> _inventoryItems = new List<Item>();
    private List<ItemRecipe> _recipes = new List<ItemRecipe>();
    private int _currentMoney;
    private ItemRecipe luckyCoin = new ItemRecipe("Gold Bar,Leprachauns Bud,Living Wood", "Lucky Coin", 20, "People believe these coins grant them more luck than is reasonable.");
    private ItemRecipe gatheringPotion = new ItemRecipe("Fiddle Fern,Toadstool", "Gathering Potion", 10, "This potion increases the swiftness of individuals, allowing them to finish quicker.");
    private ItemRecipe doublingPotion = new ItemRecipe("Gold Bar,Golden Bloom,Toadstool,Living Wood", "Doubling Potion", 16, "This potion either sells for a lot of money, as people believe it will double their income.");
    private ItemRecipe regalTonic = new ItemRecipe("Golden Bloom,Toadstool", "Regal Tonic", 10, "This potion allows people to exude the aura of royalty.");
    private ItemRecipe goldBar = new ItemRecipe("Raw Gold,Fire Lichen", "Gold Bar", 8, "This gold bar is used in a lot of crafting recipes.");
    private ItemRecipe ironBar = new ItemRecipe("Raw Iron,Fire Lichen", "Iron Bar", 5, "This iron bar is used in a lot of crafting recipes.");
    private ItemRecipe sword = new ItemRecipe("Iron Bar,Living Wood", "Sword", 15, "This is a sharp blade. It doesn't do anything other than sell for a lot.");
    private ItemRecipe encrustedSheild = new ItemRecipe("Iron Bar,Gold Bar,Living Wood", "Encrusted Shield", 30, "This beautiful shield sells for immense amounts of money.");

    public Inventory()
    {
        _recipes.Add(ironBar);
        _recipes.Add(goldBar);
        _recipes.Add(luckyCoin);
        _recipes.Add(sword);
        _recipes.Add(encrustedSheild);
        _recipes.Add(gatheringPotion);
        _recipes.Add(doublingPotion);
        _recipes.Add(regalTonic);
    }

    public int GetCurrentMoney()
    {
        return _currentMoney;
    }

    public void SubtractFromCurrentMoney(int amount)
    {
        _currentMoney -= amount;
    }

    public List<Item> GetInventory()
    {
        return _inventoryItems;
    }

    public List<ItemRecipe> GetRecipeList()
    {
        return _recipes;
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

    public void DisplayRecipes()
    {
        for (int i = 0; i < _recipes.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_recipes[i].GetName()} -- {_recipes[i].GetRequirements()}");
        }
    }

    public void DisplayContents()
    {
        Console.WriteLine("\nHere is your current inventory:");
        _inventoryItems.Sort((a, b) => a.GetName().CompareTo(b.GetName()));
        for (int i = 0; i < _inventoryItems.Count(); i++)
        {
            Console.WriteLine($"  {i + 1}. {_inventoryItems[i].GetName()} -- {_inventoryItems[i].GetDescription()}");
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