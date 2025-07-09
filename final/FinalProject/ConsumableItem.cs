class ConsumableItem : Item
{
    public ConsumableItem(string name, string description, int sellPrice, int useTimeCost)
        : base(name, description, sellPrice, useTimeCost)
    {

    }

    public ConsumableItem() : base()
    {
        
    }

    public override int ApplyEffects()
    {
        return base.ApplyEffects();
    }

    public override void UseItem()
    {
        
    }
}