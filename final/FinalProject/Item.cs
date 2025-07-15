class Item
{
    private string _itemName;
    private string _description;
    private int _sellPrice;
    private bool _isReagent;

    public Item()
    {

    }

    public Item(string name, string description, int sellPrice, int useTimeCost, bool isReagent = true)
    {
        _itemName = name;
        _description = description;
        _sellPrice = sellPrice;
        _isReagent = isReagent;
    }

    public bool GetIsReagent()
    {
        return _isReagent;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetName()
    {
        return _itemName;
    }

    public int GetSellPrice()
    {
        return _sellPrice;
    }

    public virtual int ApplyEffects()
    {
        return 0;
    }

    public int SellItem()
    {
        return 0;
    }
}