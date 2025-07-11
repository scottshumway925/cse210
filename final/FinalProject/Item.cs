abstract class Item
{
    private string _itemName;
    private string _description;
    private int _sellPrice;
    private int _useTimeCost;
    private bool _isReagent;

    public Item()
    {
        
    }

    public Item(string name, string description, int sellPrice, int useTimeCost, bool isReagent = true)
    {
        _itemName = name;
        _description = description;
        _sellPrice = sellPrice;
        _useTimeCost = useTimeCost;
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

    public abstract void UseItem();

    public int SellItem()
    {
        return 0;
    }

    public void DispayItem()
    {
        
    }
}